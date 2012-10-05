Imports System.Xml
Imports System.IO

Public Class DreamViewControl

    Public Words As Integer
    Public FileName As String
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
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
        lstUnassigned.Items.Clear()
        lstActions.Items.Clear()
        lstCharacters.Items.Clear()
        lstEmotions.Items.Clear()
        lstLocations.Items.Clear()
        lstObjects.Items.Clear()
        lstThemes.Items.Clear()

        Dim objCategoryBuilder As New CategoryBuilder()
        objCategoryBuilder.Dream = txtDream.Text

        AddHandler objCategoryBuilder.RandomWord, AddressOf RandomWordLocal
        AddHandler objCategoryBuilder.AddCategoryItem, AddressOf AddCategoryItemLocal

        Dim objProcessingThread As New Threading.Thread(AddressOf objCategoryBuilder.LoadCategories)
        objProcessingThread.Start()

        Do
            Threading.Thread.Sleep(10)
            Application.DoEvents()
            If objCategoryBuilder.Completed Then Exit Do
        Loop

        DoSave()
    End Sub

    Private Sub RandomWordLocal(ByVal Word As String)
        RaiseEvent RandomWord(Word)
    End Sub

    Private Sub AddCategoryItemLocal(ByVal Category As String, ByVal Item As String)
        AddCategoryItem(Category, Item)
    End Sub

    Public Sub DoSave()
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
            strXml += "<Image></Image>"
            strXml += "</Dream>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText = txtTitle.Text
            xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText = txtDream.Text

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

    Private Function SafeFilename(ByVal fileName As String) As String
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
        Try
            If InvokeRequired Then
                Dim d As New AddCategoryItemDelegate(AddressOf AddCategoryItem)
                Invoke(d, Category, Item)
            Else
                Dim lstItem As New ListViewItem(Item)
                lstItem.Tag = Category
                FindListView(Category).Items.Add(lstItem)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Class CategoryBuilder

        Public Dream As String
        Public Completed As Boolean
        Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
        Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"

        Public Event RandomWord(ByVal Word As String)
        Public Event AddCategoryItem(ByVal Category As String, ByVal Item As String)

        Public Sub LoadCategories()
            Try

                Dim arrCategoryItems As New List(Of CategoryItem)

                Dim arrUnassigned As New List(Of String)
                Dim arrAssigned As New List(Of String)

                ' Preload categories
                For Each strCategory As String In m_strCategories.Split(",")
                    For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3")
                        Dim objCatgeoryItem As New CategoryItem
                        objCatgeoryItem.Category = strCategory
                        objCatgeoryItem.Name = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
                        arrCategoryItems.Add(objCatgeoryItem)

                        Dim xmlDocCategory As New XmlDocument
                        xmlDocCategory.Load(strCatgeoryFile)
                        For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
                            Dim objCatgeorySubItem As New CategoryItem
                            objCatgeorySubItem.Category = strCategory
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

                For Each strWord As String In Dreams.Dreaming.GetWords(Dream)
                    Threading.Thread.Sleep(2)
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

                                    ' Now update the item


                                Catch ex As Exception
                                End Try
                                Exit For
                            End If

                            If boolCatgegorized Then
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
                strXml += "<Year Value='" + Format(dtDate.Value, "yyyy") + "'>"
                strXml += "<Month Value='" + Format(dtDate.Value, "MM") + "'>"
                strXml += "<Dream Date='" + Format(dtDate.Value, "yyyy-MM-dd") + "' Title='' />"
                strXml += "</Month>"
                strXml += "</Year>"
                strXml += "</Dreams>"
                strXml += "</Category>"

                Dim xmlDoc As New XmlDocument
                xmlDoc.LoadXml(strXml)
                xmlDoc.DocumentElement.SelectSingleNode("Dreams/Year/Month/Dream").Attributes("Title").InnerText = txtTitle.Text
                Dim strFileName As String = m_strPath + "Categories\" + strCategory + "\" + lstItem.Text + ".ld3"
                xmlDoc.Save(strFileName)

                AddCategoryItem(strCategory, lstItem.Text)
                RaiseEvent CategoryCreated(strCategory, lstItem.Text, strFileName)

                For Each lstOldItem As ListViewItem In lstUnassigned.Items
                    If lstOldItem.Text.ToLower = lstItem.Text.ToLower Then
                        CType(sender, ListView).Items.Remove(lstOldItem)
                        Exit For
                    End If
                Next
                'CType(sender, ListView).Items.Add(lstItem)
                'myItem.ListView.Items.Remove(myItem)
            Next

            DoSave()

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

    Private Sub pbDream_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDream.Click

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

    Private Sub pbDream_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbDream.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If m_formImageBrowser Is Nothing Then
                m_formImageBrowser = New ImageBrowserForm
                If lstLocations.Items.Count > 0 Then
                    m_formImageBrowser.txtKeywords.Text = lstLocations.Items(GetRandomItem(lstLocations.Items.Count)).Text
                    m_formImageBrowser.tmrDoSearch.Enabled = True
                Else
                    If lstObjects.Items.Count > 0 Then
                        m_formImageBrowser.txtKeywords.Text = lstObjects.Items(GetRandomItem(lstObjects.Items.Count)).Text
                        m_formImageBrowser.tmrDoSearch.Enabled = True
                    Else
                        If lstActions.Items.Count > 0 Then
                            m_formImageBrowser.txtKeywords.Text = lstActions.Items(GetRandomItem(lstActions.Items.Count)).Text
                            m_formImageBrowser.tmrDoSearch.Enabled = True
                        Else
                            If lstThemes.Items.Count > 0 Then
                                m_formImageBrowser.txtKeywords.Text = lstThemes.Items(GetRandomItem(lstThemes.Items.Count)).Text
                                m_formImageBrowser.tmrDoSearch.Enabled = True
                            Else
                                If lstEmotions.Items.Count > 0 Then
                                    m_formImageBrowser.txtKeywords.Text = lstEmotions.Items(GetRandomItem(lstEmotions.Items.Count)).Text
                                    m_formImageBrowser.tmrDoSearch.Enabled = True
                                Else
                                    If lstCharacters.Items.Count > 0 Then
                                        m_formImageBrowser.txtKeywords.Text = lstCharacters.Items(GetRandomItem(lstCharacters.Items.Count)).Text
                                        m_formImageBrowser.tmrDoSearch.Enabled = True
                                    Else
                                        If lstUnassigned.Items.Count > 0 Then
                                            m_formImageBrowser.txtKeywords.Text = lstUnassigned.Items(GetRandomItem(lstUnassigned.Items.Count)).Text
                                            m_formImageBrowser.tmrDoSearch.Enabled = True
                                        Else

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

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
