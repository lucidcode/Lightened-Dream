Imports System.Xml
Imports System.IO

Public Class ViewControl

  Public Words As Integer
  Public FileName As String
  Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream III\"
  Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
  Private m_boolLoading As Boolean = False
  Private m_objSpeechSynthesizer As New System.Speech.Synthesis.SpeechSynthesizer()

  Public Playing As Boolean = False

  Public Event CategoryCreated(ByVal Category As String, ByVal Name As String, ByVal FileName As String)
  Public Event PlayingStopped()
  Public Changed As Boolean = False

  Public Sub New()
    InitializeComponent()
    AddHandler m_objSpeechSynthesizer.SpeakCompleted, AddressOf m_objSpeechSynthesizer_SpeakCompleted
  End Sub

  Public Sub EnableSpellCheck()
    NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtDream, True)
  End Sub

  Public Sub DisableSpellCheck()
    NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtDream, False)
  End Sub

  Public Sub LoadDream(ByVal strFileName As String)
    Try
      If FileName <> strFileName Then
        m_objSpeechSynthesizer.SpeakAsyncCancelAll()
        Playing = False
      End If

      m_boolLoading = True
      Dim xmlDoc As New XmlDocument
      FileName = strFileName
      xmlDoc.Load(FileName)

      Try
        Dim arrDate() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Date").InnerText, "-")
        Dim arrTime() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Time").InnerText, ":")
        dtDate.Value = New Date(arrDate(0), arrDate(1), arrDate(2), arrTime(0), arrTime(1), 0)
      Catch ex As Exception
      End Try

      txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
      txtDream.Text = xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText
      lblTitle.Text = "Dreams - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text

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

      lstUnassigned.Items.Clear()
      lstActions.Items.Clear()
      lstCharacters.Items.Clear()
      lstEmotions.Items.Clear()
      lstLocations.Items.Clear()
      lstObjects.Items.Clear()
      lstThemes.Items.Clear()
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Unassigned")
        lstUnassigned.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Characters")
        lstCharacters.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Locations")
        lstLocations.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Objects")
        lstObjects.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Actions")
        lstActions.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Themes")
        lstThemes.Items.Add(xmlWord.InnerText)
      Next
      For Each xmlWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/Emotions")
        lstEmotions.Items.Add(xmlWord.InnerText)
      Next

      tbUnassigned.Value = 5

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
    Try
      Dim strXml As String

      LoadCategories()

      strXml = "<Dream>"

      strXml += "<Date>" & Format(dtDate.Value, "yyyy-MM-dd") & "</Date>"
      strXml += "<Time>" & Format(dtDate.Value, "HH:mm") & "</Time>"
      strXml += "<Sleep>" & Format(dtStart.Value, "HH:mm") & "</Sleep>"
      strXml += "<Awake>" & Format(dtEnd.Value, "HH:mm") & "</Awake>"
      strXml += "<Title>" & txtTitle.Text + "</Title>"
      strXml += "<Lucidity>" & Val(cmbLucidity.Text) & "</Lucidity>"
      strXml += "<Dream></Dream>"
      strXml += "<Clarity>5</Clarity>"

      strXml += "<Categories>"
      For Each lstItem As ListViewItem In lstUnassigned.Items
        strXml += "<Unassigned>" & lstItem.Text & "</Unassigned>"
      Next
      For Each lstItem As ListViewItem In lstCharacters.Items
        strXml += "<Characters>" & lstItem.Text & "</Characters>"
      Next
      For Each lstItem As ListViewItem In lstLocations.Items
        strXml += "<Locations>" & lstItem.Text & "</Locations>"
      Next
      For Each lstItem As ListViewItem In lstObjects.Items
        strXml += "<Objects>" & lstItem.Text & "</Objects>"
      Next
      For Each lstItem As ListViewItem In lstActions.Items
        strXml += "<Actions>" & lstItem.Text & "</Actions>"
      Next
      For Each lstItem As ListViewItem In lstThemes.Items
        strXml += "<Themes>" & lstItem.Text & "</Themes>"
      Next
      For Each lstItem As ListViewItem In lstEmotions.Items
        strXml += "<Emotions>" & lstItem.Text & "</Emotions>"
      Next
      strXml += "</Categories>"
      strXml += "</Dream>"

      Dim xmlDoc As New XmlDocument
      xmlDoc.LoadXml(strXml)
      xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText = txtDream.Text
      If (FileName <> GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3") Then
        File.Delete(FileName)
      End If
      FileName = GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3"
      xmlDoc.Save(FileName)
      Changed = False
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

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

  Private Sub LoadCategories()
    Try
      lstUnassigned.Items.Clear()
      lstActions.Items.Clear()
      lstCharacters.Items.Clear()
      lstEmotions.Items.Clear()
      lstLocations.Items.Clear()
      lstObjects.Items.Clear()
      lstThemes.Items.Clear()

      lstUnassigned.BeginUpdate()

      For Each strWord As String In Dreams.Dreaming.GetWords(txtDream.Text)
        If strWord.Length > tbUnassigned.Value Then
          Dim boolExists As Boolean = False
          For Each lstItem As ListViewItem In lstUnassigned.Items
            If lstItem.Text.ToLower = strWord.ToLower Then
              boolExists = True
              Exit For
            End If
          Next
          For Each strCategory As String In m_strCategories.Split(",")
            For Each lstItem As ListViewItem In FindListView(strCategory).Items
              If lstItem.Text.ToLower = strWord.ToLower Then
                boolExists = True
                Exit For
              End If
            Next
          Next

          If Not boolExists Then
            Dim lstItem As New ListViewItem(strWord)
            Dim boolCatgegorized As Boolean = False
            For Each strCategory As String In m_strCategories.Split(",")

              For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3")
                Dim strName As String = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
                If strName.ToLower = strWord.ToLower Then
                  boolCatgegorized = True
                  lstItem.Tag = strCategory
                  FindListView(strCategory).Items.Add(lstItem)
                  Exit For
                End If

                Dim xmlDocCategory As New XmlDocument
                xmlDocCategory.Load(strCatgeoryFile)
                For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
                  If xmlWord.InnerText.ToLower = strWord.ToLower Then
                    boolCatgegorized = True
                    lstItem.Tag = strCategory
                    lstItem.Text = strName
                    FindListView(strCategory).Items.Add(lstItem)
                    Exit For
                  End If
                Next

                Application.DoEvents()
                If m_boolLoading Then Return
              Next
              If boolCatgegorized Then
                Exit For
              End If
            Next

            If Not boolCatgegorized Then
              lstUnassigned.Items.Add(lstItem)
            End If

          End If
        End If
      Next

      lstUnassigned.EndUpdate()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function FindListView(ByVal Name As String) As ListView
    If Name = "Characters" Then
      Return lstCharacters
    End If
    If Name = "Actions" Then
      Return lstActions
    End If
    If Name = "Emotions" Then
      Return lstEmotions
    End If
    If Name = "Locations" Then
      Return lstLocations
    End If
    If Name = "Objects" Then
      Return lstObjects
    End If
    If Name = "Themes" Then
      Return lstThemes
    End If
    Return lstUnassigned
  End Function

  Private Sub lst_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lstUnassigned.ItemDrag
    Dim myItem As ListViewItem
    Dim myItems(sender.SelectedItems.Count - 1) As ListViewItem
    Dim i As Integer = 0

    ' Loop though the SelectedItems collection for the source.
    For Each myItem In sender.SelectedItems
      ' Add the ListViewItem to the array of ListViewItems.
      myItems(i) = myItem
      i = i + 1
    Next
    ' Create a DataObject containg the array of ListViewItems.
    sender.DoDragDrop(New  _
    DataObject("System.Windows.Forms.ListViewItem()", myItems), DragDropEffects.Link)
  End Sub

  Private Sub lst_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstCharacters.DragEnter, lstActions.DragEnter, lstEmotions.DragEnter, lstLocations.DragEnter, lstObjects.DragEnter, lstThemes.DragEnter
    If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
      e.Effect = DragDropEffects.Link
    Else
      e.Effect = DragDropEffects.None
    End If
  End Sub

  Private Sub lst_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstCharacters.DragDrop, lstActions.DragDrop, lstEmotions.DragDrop, lstLocations.DragDrop, lstObjects.DragDrop, lstThemes.DragDrop
    Try
      Dim myItem As ListViewItem
      Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
      Dim i As Integer = 0

      Dim strCategory As String = CType(sender, ListView).Name.Replace("lst", "")

      For Each myItem In myItems

        Dim lstItem As New ListViewItem(myItems(i).Text.Substring(0, 1).ToUpper + myItems(i).Text.Substring(1))

        Dim strXml As String
        strXml = "<Category>"
        strXml += "<Name>" + lstItem.Text + "</Name>"
        strXml += "<Description></Description>"
        strXml += "<Dreams>"
        For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
          strXml += "<Year Value='" + New DirectoryInfo(strYearFolder).Name + "'>"
          ' Load each month
          For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
            strXml += "<Month Value='" + New DirectoryInfo(strMonthFolder).Name + "'>"
            ' Load each dream
            For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
              Dim xmlDream As New XmlDocument
              xmlDream.Load(strDreamFile)
              If (xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower.Contains(lstItem.Text.ToLower)) Then
                strXml += "<Dream Date='" + xmlDream.DocumentElement.SelectSingleNode("Date").InnerText + "' Title='" + xmlDream.DocumentElement.SelectSingleNode("Title").InnerText + "' />"
              End If
            Next
            strXml += "</Month>"
          Next
          strXml += "</Year>"
        Next
        strXml += "</Dreams>"
        strXml += "</Category>"

        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)
        Dim strFileName As String = m_strPath + "Categories\" + strCategory + "\" + lstItem.Text + ".ld3"
        xmlDoc.Save(strFileName)

        Save()

        RaiseEvent CategoryCreated(strCategory, lstItem.Text, strFileName)

        'CType(sender, ListView).Items.Add(lstItem)
        'myItem.ListView.Items.Remove(myItem)
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.DragCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub lst_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstCharacters.DragOver, lstActions.DragOver, lstEmotions.DragOver, lstLocations.DragOver, lstObjects.DragOver, lstThemes.DragOver
    If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
      e.Effect = DragDropEffects.Link
    Else
      e.Effect = DragDropEffects.None
    End If
  End Sub

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

  Private Sub tbUnassigned_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUnassigned.Scroll
    If m_boolLoading Then Return
    LoadCategories()
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
End Class
