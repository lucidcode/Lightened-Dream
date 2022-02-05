Imports System.Xml
Imports System.IO

Public Class DreamViewControl

  Public Words As Integer
  Public FileName As String
  Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
  Private m_boolLoading As Boolean = False
  Private m_objSpeechSynthesizer As New System.Speech.Synthesis.SpeechSynthesizer()

  Public Playing As Boolean = False

  Public Event RandomWord(ByVal Word As String)
  Public Event CategoryCreated(ByVal Category As String, ByVal Name As String, ByVal FileName As String)
  Public Event PlayingStopped()
  Public Changed As Boolean = False

  Dim m_formImageBrowser As ImageBrowserForm

  Public Sub New()
    InitializeComponent()
    Randomize()
    LoadDreamTypes()
    AddHandler m_objSpeechSynthesizer.SpeakCompleted, AddressOf m_objSpeechSynthesizer_SpeakCompleted
  End Sub

  Private Sub LoadDreamTypes()
    Dim xmlDocDreamTypes As New XmlDocument

    ' Make sure that the dream types file exists
    If Not File.Exists(m_strPath & "DreamTypes.ld3") Then
      ' Create the dream types file
      Dim strXml As String = "<LightenedDream>"
      strXml += "<DreamType>1 Thought</DreamType>"
      strXml += "<DreamType>2 Daydream</DreamType>"
      strXml += "<DreamType>3 Nightmare</DreamType>"
      strXml += "<DreamType>4 Foggy Dream</DreamType>"
      strXml += "<DreamType>5 Normal Dream</DreamType>"
      strXml += "<DreamType>6 Vivid Dream</DreamType>"
      strXml += "<DreamType>7 Lucid Dream</DreamType>"
      strXml += "<DreamType>8 Epic Dream</DreamType>"
      strXml += "<DreamType>9 Wake Induced</DreamType>"
      strXml += "</LightenedDream>"
      xmlDocDreamTypes.LoadXml(strXml)
      xmlDocDreamTypes.Save(m_strPath & "DreamTypes.ld3")
    End If

    cmbLucidity.Items.Clear()
    xmlDocDreamTypes.Load(m_strPath & "DreamTypes.ld3")
    For Each xmlDreamType As XmlNode In xmlDocDreamTypes.DocumentElement.SelectNodes("DreamType")
      cmbLucidity.Items.Add(xmlDreamType.InnerText)
    Next
  End Sub

  Public Sub LoadDream(ByVal strFileName As String, ByVal locked As Boolean)
    Try
      If FileName <> strFileName Then
        m_objSpeechSynthesizer.SpeakAsyncCancelAll()
        Playing = False
      End If

      txtTitle.ReadOnly = locked
      cmbLucidity.Enabled = Not locked
      dtDate.Enabled = Not locked
      dtStart.Enabled = Not locked
      dtEnd.Enabled = Not locked
      objDreamSlider.Enabled = Not locked
      txtDream.Enabled = Not locked

      m_boolLoading = True
      Dim xmlDoc As New XmlDocument
      FileName = strFileName
      xmlDoc.Load(FileName)
      m_formImageBrowser = Nothing

      Try
        Dim arrDate() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Date").InnerText, "-")
        Dim arrTime() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Time").InnerText, ":")
        dtDate.Value = New Date(arrDate(0), arrDate(1), arrDate(2), arrTime(0), arrTime(1), 0)
      Catch ex As Exception
      End Try

      txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
      txtDream.Text = xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText
      lblTitle.Text = "Dreams - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text

      If Not xmlDoc.DocumentElement.SelectSingleNode("Comments") Is Nothing Then
        txtComments.Text = xmlDoc.DocumentElement.SelectSingleNode("Comments").InnerText
      Else
        txtComments.Text = ""
      End If

      Try
        dtStart.Value = Now.Date + " " + xmlDoc.DocumentElement.SelectSingleNode("Sleep").InnerText
        dtEnd.Value = Now.Date + " " + xmlDoc.DocumentElement.SelectSingleNode("Awake").InnerText
        objDreamSlider.setStartTime(New TimeSpan(dtStart.Value.Hour, dtStart.Value.Minute, 0))
        objDreamSlider.setStopTime(New TimeSpan(dtEnd.Value.Hour, dtEnd.Value.Minute, 0))
        objDreamSlider.setDreamTime(New TimeSpan(dtDate.Value.Hour, dtDate.Value.Minute, 0))
      Catch ex As Exception
      End Try

      Try
        If dtStart.Value = dtEnd.Value Then
          dtStart.Value = Now.Date + " 23:30"
          dtEnd.Value = Now.Date + " 06:30"
        End If
      Catch ex As Exception

      End Try

      cmbLucidity.Text = "5 Normal Dream"
      If Not xmlDoc.DocumentElement.SelectSingleNode("Lucidity") Is Nothing Then
        For Each strItem As Object In cmbLucidity.Items
          If strItem.StartsWith(xmlDoc.DocumentElement.SelectSingleNode("Lucidity").InnerText) Then
            cmbLucidity.SelectedItem = strItem
            Exit For
          End If
        Next
      End If

      If Not xmlDoc.DocumentElement.SelectSingleNode("Image") Is Nothing Then
        Dim objMemStream As New MemoryStream(Convert.FromBase64String(xmlDoc.DocumentElement.SelectSingleNode("Image").InnerText))
        pbDream.Image = Image.FromStream(objMemStream)
      Else
        pbDream.Image = lstImgDreams.Images(GetRandomItem(lstImgDreams.Images.Count))
        Save()
      End If
      ResizeImage()

      Words = txtDream.Text.Split(" ").Length
      m_boolLoading = False
      Changed = False
      Playing = False
      'LoadCategories()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.LoadDream()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub Save()
    Dim objCategoryBuilder As New CategoryBuilder()
    objCategoryBuilder.Dream = txtDream.Text
    objCategoryBuilder.Words = Dreaming.GetWords(objCategoryBuilder.Dream)

    AddHandler objCategoryBuilder.RandomWord, AddressOf RandomWordLocal
    AddHandler objCategoryBuilder.AddCategoryItem, AddressOf AddCategoryItemLocal

    Dim objProcessingThread As New Threading.Thread(AddressOf objCategoryBuilder.LoadCategories)
    objProcessingThread.Start()

    Do
      Threading.Thread.Sleep(10)
      Application.DoEvents()
      If objCategoryBuilder.Completed Then Exit Do
    Loop

    DoSave(objCategoryBuilder.Categories)
  End Sub

  Private Sub RandomWordLocal(ByVal Word As String)
    RaiseEvent RandomWord(Word)
  End Sub

  Private Sub AddCategoryItemLocal(ByVal Category As String, ByVal Item As String)
    AddCategoryItem(Category, Item)
  End Sub

  Public Sub DoSave(ByVal Categories As String)
    Try
      Dim strXml As String

      strXml = "<Dream>"
      strXml += "<Date>" & Format(dtDate.Value, "yyyy-MM-dd") & "</Date>"
      strXml += "<Time>" & Format(dtDate.Value, "HH:mm") & "</Time>"
      strXml += "<Sleep>" & Format(dtStart.Value, "HH:mm") & "</Sleep>"
      strXml += "<Awake>" & Format(dtEnd.Value, "HH:mm") & "</Awake>"
      strXml += "<Title></Title>"
      strXml += "<Lucidity>" & Val(cmbLucidity.Text) & "</Lucidity>"
      strXml += "<Dream></Dream>"
      strXml += "<Comments></Comments>"
      strXml += "<Clarity>5</Clarity>"

      strXml += "<SubCategories>" + Categories + "</SubCategories>"
      strXml += "<Image></Image>"
      strXml += "</Dream>"

      Dim xmlDoc As New XmlDocument
      xmlDoc.LoadXml(strXml)
      xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText = txtTitle.Text
      xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText = txtDream.Text
      xmlDoc.DocumentElement.SelectSingleNode("Comments").InnerText = txtComments.Text

      Try
        Dim objMemStream As New MemoryStream()
        pbDream.Image.Save(objMemStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        xmlDoc.DocumentElement.SelectSingleNode("Image").InnerText = Convert.ToBase64String(objMemStream.ToArray)
      Catch ex As Exception

      End Try

      If (FileName <> GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + SafeFilename(txtTitle.Text) + ".ld3") Then
        File.Delete(FileName)
      End If
      FileName = GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + SafeFilename(txtTitle.Text) + ".ld3"
      xmlDoc.Save(FileName)
      Changed = False
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Function SafeFilename(ByVal fileName As String) As String
    For i As Integer = 0 To Path.GetInvalidFileNameChars().Length - 1
      fileName = fileName.Replace(Path.GetInvalidFileNameChars()(i), "_")
    Next
    Return fileName
  End Function

  Public Sub Play()
    Try
      m_objSpeechSynthesizer.SpeakAsync(txtDream.Text)
      Playing = True
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub m_objSpeechSynthesizer_SpeakCompleted(ByVal sender As Object, ByVal e As System.Speech.Synthesis.SpeakCompletedEventArgs)
    Playing = False
    RaiseEvent PlayingStopped()
  End Sub

  Public Sub StopPlaying()
    Try
      m_objSpeechSynthesizer.SpeakAsyncCancelAll()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function GetFolder(ByVal FolderDate As DateTime) As String
    If Not Directory.Exists(m_strPath + "Dreams\" + Format(FolderDate, "yyyy")) Then
      Directory.CreateDirectory(m_strPath + "Dreams\" + Format(FolderDate, "yyyy"))
    End If
    If Not Directory.Exists(m_strPath + "Dreams\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM")) Then
      Directory.CreateDirectory(m_strPath + "Dreams\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM"))
    End If
    Return m_strPath + "Dreams\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM") + "\"
  End Function

  Private Class CategoryItem
    Public Category As String
    Public Name As String
    Public SubItems As New List(Of String)
  End Class

  Private Delegate Sub AddCategoryItemDelegate(ByVal Category As String, ByVal Item As String)
  Private Sub AddCategoryItem(ByVal Category As String, ByVal Item As String)
    'Try
    '    If InvokeRequired Then
    '        Dim d As New AddCategoryItemDelegate(AddressOf AddCategoryItem)
    '        Invoke(d, Category, Item)
    '    Else
    '        Dim lstItem As New ListViewItem(Item)
    '        lstItem.Tag = Category
    '        FindListView(Category).Items.Add(lstItem)
    '    End If
    'Catch ex As Exception
    'End Try
  End Sub

  Private Class CategoryBuilder

    Public Dream As String
    Public Completed As Boolean
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"

    Public Event RandomWord(ByVal Word As String)
    Public Event AddCategoryItem(ByVal Category As String, ByVal Item As String)
    Public Words As String()

    Public Categories As String

    Public FoundList As New List(Of String)

    Public Function LoadCategories(category As String) As String
      Dim initialRun = False
      If category Is Nothing Then
        category = m_strPath + "Categories"
        initialRun = True
      End If

      For Each subCategory As String In Directory.GetDirectories(category)
        LoadCategories(subCategory)
      Next

      For Each file As String In Directory.GetFiles(category)
        Dim xmlDocCategory As New XmlDocument
        xmlDocCategory.Load(file)

        Dim foundWord As Boolean = False
        For Each word As String In Words
          If Not FoundList.Contains(word.ToLower) Then
            If word.ToLower = New FileInfo(file).Name.Replace(".ld3", "").ToLower Then
              RaiseEvent RandomWord(word)
              FoundList.Add(word.ToLower)
              Categories += "<Category Path='" + category.Replace(m_strPath + "Categories\", "") + "'>" + New FileInfo(file).Name.Replace(".ld3", "") + "</Category>"
            End If
          End If
        Next

        For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
          For Each word As String In Words
            If Not FoundList.Contains(word.ToLower) Then
              If word.ToLower = xmlWord.InnerText.ToLower Then
                RaiseEvent RandomWord(word)
                FoundList.Add(word.ToLower)
                Categories += "<Category Path='" + category.Replace(m_strPath + "Categories\", "") + "'>" + New FileInfo(file).Name.Replace(".ld3", "") + "</Category>"
              End If
            End If
          Next
        Next
      Next

      If initialRun Then
        Completed = True
      End If
    End Function

    Public Sub LoadCategoriesOld()
      Try

        Dim arrCategoryItems As New List(Of CategoryItem)

        Dim arrUnassigned As New List(Of String)
        Dim arrAssigned As New List(Of String)

        ' Preload categories
        For Each strCategoryDirectory As String In Directory.GetDirectories(m_strPath + "Categories")
          For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategoryDirectory, "*.ld3")
            Dim objCatgeoryItem As New CategoryItem
            objCatgeoryItem.Category = strCategoryDirectory
            objCatgeoryItem.Name = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
            arrCategoryItems.Add(objCatgeoryItem)

            Dim xmlDocCategory As New XmlDocument
            xmlDocCategory.Load(strCatgeoryFile)
            For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
              Dim objCatgeorySubItem As New CategoryItem
              objCatgeorySubItem.Category = strCategoryDirectory
              objCatgeorySubItem.Name = xmlWord.InnerText.Trim(" ")
              objCatgeoryItem.SubItems.Add(xmlWord.InnerText)
              arrCategoryItems.Add(objCatgeorySubItem)
            Next
          Next
        Next

        ' Preload ignore list
        Dim xmlDocIgnore As New XmlDocument
        If (File.Exists(m_strPath & "IgnoreList.ld3")) Then
          xmlDocIgnore.Load(m_strPath & "IgnoreList.ld3")
          For Each xmlNode As XmlNode In xmlDocIgnore.DocumentElement.SelectNodes("Ignore")
            arrUnassigned.Add(xmlNode.InnerText.ToLower)
          Next
        End If

        For Each objCategoryItem As CategoryItem In arrCategoryItems
          Dim strName As String = objCategoryItem.Name

          If strName.Contains(" ") Then
            If Dream.ToLower().Contains(strName.ToLower()) Then
              RaiseEvent AddCategoryItem(objCategoryItem.Category, strName)
              RaiseEvent RandomWord(strName)

              arrAssigned.Add(strName.ToLower)

              For Each strSubItem As String In objCategoryItem.SubItems
                arrAssigned.Add(strSubItem.ToLower)
              Next

            End If
          End If
        Next

        For Each strWord As String In Dreams.Dreaming.GetWords(Dream)
          Dim boolExists As Boolean = False
          For Each strItem As String In arrUnassigned
            If strItem = strWord.ToLower Then
              boolExists = True
              Exit For
            End If
          Next
          For Each strItem As String In arrAssigned
            If strItem = strWord.ToLower Then
              boolExists = True
              Exit For
            End If
          Next

          If Not boolExists Then
            Dim lstItem As New ListViewItem(strWord)
            Dim boolCatgegorized As Boolean = False
            For Each objCategoryItem As CategoryItem In arrCategoryItems
              Dim strName As String = objCategoryItem.Name

              If strName.ToLower = strWord.ToLower Then
                boolCatgegorized = True
                lstItem.Tag = objCategoryItem.Category
                Try
                  RaiseEvent AddCategoryItem(objCategoryItem.Category, strWord)
                  RaiseEvent RandomWord(strWord)

                  arrAssigned.Add(strWord.ToLower)

                  For Each strSubItem As String In objCategoryItem.SubItems
                    arrAssigned.Add(strSubItem.ToLower)
                  Next

                Catch ex As Exception
                End Try
                Exit For
              End If
            Next

            If strWord.Length > 4 Then
              If Not boolCatgegorized Then
                Try
                  arrUnassigned.Add(strWord.ToLower)
                  RaiseEvent AddCategoryItem("Unassigned", strWord)
                Catch ex As Exception
                End Try
              End If
            End If
          End If
        Next

        Completed = True
      Catch ex As Exception
        Completed = True
        MessageBox.Show(ex.Message, "LightenedDream.Dreams.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub

  End Class

  Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
    lblTitle.Text = "Dreams - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text
    Changed = True
  End Sub

  Private Sub dtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDate.ValueChanged
    lblTitle.Text = "Dreams - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text
    Try
      objDreamSlider.setDreamTime(New TimeSpan(dtDate.Value.Hour, dtDate.Value.Minute, 0))
    Catch ex As Exception
    End Try
    Changed = True
  End Sub

  Private Sub txtDream_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDream.TextChanged
    If Not m_boolLoading Then
      Changed = True
    End If
  End Sub

  Private Sub dtStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtStart.ValueChanged
    objDreamSlider.setStartTime(New TimeSpan(dtStart.Value.Hour, dtStart.Value.Minute, 0))
    Changed = True
  End Sub

  Private Sub dtEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtEnd.ValueChanged
    objDreamSlider.setStopTime(New TimeSpan(dtEnd.Value.Hour, dtEnd.Value.Minute, 0))
    Changed = True
  End Sub

  Private Sub cmbLucidity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLucidity.SelectedIndexChanged
    Changed = True
  End Sub

  Private Sub objSleepHours_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objDreamSlider.Resize
    If objDreamSlider.Width > 310 Then
      objDreamSlider.ShowIncrement = True
    End If
    If objDreamSlider.Width <= 310 Then
      objDreamSlider.ShowIncrement = False
    End If

    If objDreamSlider.Width > 400 Then
      objDreamSlider.DisplayInterval = 6
    End If
    If objDreamSlider.Width <= 400 Then
      objDreamSlider.DisplayInterval = 12
    End If
    If objDreamSlider.Width <= 200 Then
      objDreamSlider.DisplayInterval = 24
    End If
    If objDreamSlider.Width <= 100 Then
      objDreamSlider.DisplayInterval = 48
    End If
  End Sub

  Private Sub objDreamSlider_StartTimeChanged(ByVal Time As System.TimeSpan) Handles objDreamSlider.StartTimeChanged
    Try
      dtStart.Value = New Date(Now.Year, Now.Month, Now.Day, Time.Hours, Time.Minutes, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub objDreamSlider_EndTimeChanged(ByVal Time As System.TimeSpan) Handles objDreamSlider.EndTimeChanged
    Try
      dtEnd.Value = New Date(Now.Year, Now.Month, Now.Day, Time.Hours, Time.Minutes, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub objDreamSlider_DreamTimeChanged(ByVal Time As System.TimeSpan) Handles objDreamSlider.DreamTimeChanged
    Try
      dtDate.Value = New Date(dtDate.Value.Year, dtDate.Value.Month, dtDate.Value.Day, Time.Hours, Time.Minutes, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ResizeImage()
    pnlDreamImage.Width = pbDream.Width + 4
    pnlDreamImage.Height = pbDream.Height + 4

    pnlControls.Left = pnlDreamImage.Left + pnlDreamImage.Width + 8
    pnlControls.Width = SplitContainer1.Width - pnlControls.Left - 2
  End Sub

  Private Sub mnuThumbnail_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuThumbnail.Opening
    If Clipboard.ContainsImage Then
      mnuThumbnailPaste.Enabled = True
    Else
      mnuThumbnailPaste.Enabled = False
    End If
  End Sub

  Private Sub mnuThumbnailCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThumbnailCopy.Click
    Clipboard.SetImage(pbDream.Image)
  End Sub

  Private Sub mnuThumbnailPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThumbnailPaste.Click
    pbDream.Image = Clipboard.GetImage
  End Sub

  Private Function GetRandomItem(ByVal Max As Integer) As Integer
    Randomize()
    Dim intId As Integer = Rnd() * Max
    If intId >= Max Then intId = Max - 1
    Return intId
  End Function

  Private Function GetRandomWord() As String
    Randomize()
    Dim arrWords As String() = Dreaming.GetWords(txtDream.Text)
    Dim intId As Integer = (New Random).Next(0, arrWords.Length)
    Return arrWords(intId)
  End Function

  Private Sub pbDream_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbDream.MouseClick
    If e.Button = Windows.Forms.MouseButtons.Left Then
      If m_formImageBrowser Is Nothing Then
        m_formImageBrowser = New ImageBrowserForm
      End If

      m_formImageBrowser.txtKeywords.Text = GetRandomWord()
      m_formImageBrowser.tmrDoSearch.Enabled = True

      If m_formImageBrowser.ShowDialog() = DialogResult.OK Then
        If Not m_formImageBrowser.DreamImage Is Nothing Then
          pbDream.Image = m_formImageBrowser.DreamImage
          ResizeImage()
          Changed = True
        End If
      End If
    End If
  End Sub
End Class
