Imports lucidcode.LightenedDream
Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization
Imports System.Net
Imports System.Threading

Public Class MainForm

    Public Loaded As Boolean = False
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
    Private m_arrCategories As New List(Of String)
    Private m_arrBackHistory As New List(Of TreeNode)
    Private m_arrForwardHistory As New List(Of TreeNode)
    Private m_boolNavigating As Boolean
    Private m_boolChanged As Boolean = False

    Private m_objDreamViewControl As New Dreams.DreamViewControl
    Private m_objMonthListControl As New Dreams.MonthListControl
    Private m_objYearListControl As New Dreams.YearListControl
    Private m_objYearsListControl As New Dreams.YearsListControl
    Private m_objSearchControl As New Dreams.SearchControl
    Private m_objDreamSignListControl As New Dreams.DreamSignControl
    Private m_objCompareDreamsControl As New Dreams.CompareDreamsControl

    Private m_objCategoryViewControl As New Categories.ViewControl
    Private m_objCategoriesListControl As New Categories.CategoriesListControl
    Private m_objCategoryListControl As New Categories.CategoryListControl

    Private m_objREMCyclesControl As New Lucidity.REMCyclesControl
    Private m_objLucidItemControl As New Lucidity.ItemViewControl
    Private m_objLucidFolderViewControl As New Lucidity.FolderViewControl
    Private m_objLucidityControl As New Lucidity.LucidityControl

    Private m_objExerciseViewControl As New Lucidity.ExerciseViewControl
    Private m_objExerciseMonthListControl As New Lucidity.MonthListControl
    Private m_objExerciseYearListControl As New Lucidity.YearListControl
    Private m_objExerciseYearsListControl As New Lucidity.YearsListControl
    Private trvNodeImported As TreeNode = Nothing

    Private m_boolYearSelected = False
    Private m_boolAgentWorks As Boolean = False
    Private m_dtLastREMPlayed As DateTime
    Private m_formAbout As AboutForm
    Private m_objUpdateControl As New UpdateControl

    Friend objMerlin As New AxAgentObjects.AxAgent
    Private resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Private m_objDreams As Series

    Private m_objUpdater As New UpdateClass
    Private m_objUpdateThread As Thread

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        Try

            tmrLoad.Enabled = False

            Try
                m_objUpdateThread = New Thread(AddressOf m_objUpdater.CheckForUpdate)
                m_objUpdateThread.Start()
            Catch ex As Exception
            End Try

            Dim strImportType As String = ""
            Dim strImportFileName As String = ""
            Dim strNewPath As String = ""
            Try
                If Environment.GetCommandLineArgs.Length > 1 Then
                    strImportFileName = New FileInfo(Environment.GetCommandLineArgs(1)).Name
                    Dim xmlReader As XmlReader = xmlReader.Create(Environment.GetCommandLineArgs(1))
                    xmlReader.Read()
                    strImportType = xmlReader.Name
                    If xmlReader.Name = "xml" Then
                        xmlReader.Read()
                        strImportType = xmlReader.Name
                    End If
                    If xmlReader.Name = "XML" Then
                        xmlReader.Read()
                        strImportType = xmlReader.Name
                    End If

                    If strImportType = "REM" Then
                        strNewPath = m_strPath & "Lucidity\REM Cycles\" & strImportFileName
                    ElseIf strImportType = "Check" Then
                        strNewPath = m_strPath & "Lucidity\Checks\" & strImportFileName
                    ElseIf strImportType = "Subliminal" Then
                        strNewPath = m_strPath & "Lucidity\Subliminals\" & strImportFileName
                    ElseIf strImportType = "Exercises" Then
                        strNewPath = m_strPath & "Lucidity\Exercises\" & strImportFileName
                    ElseIf strImportType = "Recording" Then
                        strNewPath = m_strPath & "Lucidity\Recordings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName

                    ElseIf strImportType = "Category" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    ElseIf strImportType = "Reading" Then
                        strNewPath = m_strPath & "Lucidity\Readings\" & strImportFileName
                    End If

                    'If File.Exists(m_strPath & "Lucidity\Readings\" & strImportFileName) Then
                    Try
                        File.Copy(Environment.GetCommandLineArgs(1), strNewPath, True)
                    Catch ex As Exception
                    End Try
                    'End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "LightenedDream.Import()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.DoubleBuffered = True
            LoadGUI()
            LoadTree()
            LoadSpellCheckLanguages()
            'Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            lblStatus.Text = ""
            toolBack.Enabled = False
            m_arrBackHistory.Clear()
            m_arrBackHistory.Add(trvMain.SelectedNode)

            AddHandler m_objDreamViewControl.CategoryCreated, AddressOf CategoryCreated
            AddHandler m_objDreamViewControl.PlayingStopped, AddressOf PlayingStopped
            AddHandler m_objDreamViewControl.RandomWord, AddressOf RandomWord

            AddHandler m_objMonthListControl.DreamSelected, AddressOf DreamSelected
            AddHandler m_objYearListControl.MonthSelected, AddressOf MonthSelected
            AddHandler m_objYearsListControl.MonthSelected, AddressOf SearchMonthSelected

            AddHandler m_objExerciseMonthListControl.DreamSelected, AddressOf ExerciseDreamSelected
            AddHandler m_objExerciseYearListControl.MonthSelected, AddressOf ExerciseMonthSelected
            AddHandler m_objExerciseYearsListControl.MonthSelected, AddressOf ExercisesearchMonthSelected

            AddHandler m_objSearchControl.MonthSelected, AddressOf SearchMonthSelected
            AddHandler m_objSearchControl.CategoryFileSelected, AddressOf SearchCategoryFileSelected
            AddHandler m_objSearchControl.CategoryFileCreated, AddressOf SearchCategoryFileCreated
            AddHandler m_objDreamSignListControl.CategoryFileCreated, AddressOf DreamSignCategoryFileCreated

            AddHandler m_objCategoryViewControl.SelectDream, AddressOf SelectDream
            AddHandler m_objCategoryViewControl.RandomWord, AddressOf RandomWord
            AddHandler m_objCategoriesListControl.CategorySelected, AddressOf CategorySelected
            AddHandler m_objCategoryListControl.CategorySelected, AddressOf CategorySelected

            AddHandler m_objLucidFolderViewControl.LucidItemSelected, AddressOf LucidItemSelected
            AddHandler m_objLucidityControl.LucidFolderSelected, AddressOf LucidFolderSelected

            Loaded = True

            SplitContainer1.SplitterDistance = 247

            If strImportType <> "" Then
                If strImportType = "REM" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "REM Cycles"), strImportFileName.Replace(".ld3", ""))
                ElseIf strImportType = "Check" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "Checks"), strImportFileName.Replace(".ld3", ""))
                ElseIf strImportType = "Subliminal" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "Subliminals"), strImportFileName.Replace(".ld3", ""))
                ElseIf strImportType = "Exercises" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "Exercises"), strImportFileName.Replace(".ld3", ""))
                ElseIf strImportType = "Recording" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "Recordings"), strImportFileName.Replace(".ld3", ""))
                ElseIf strImportType = "Reading" Then
                    trvNodeImported = FindNode(FindNode(trvMain.Nodes(2), "Readings"), strImportFileName.Replace(".ld3", ""))
                End If
            End If

            Randomize()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        m_objDreamViewControl.Focus()
        m_objDreamViewControl.txtDream.Focus()
    End Sub

    Public Sub LoadMerlin()
        Try
            Me.Controls.Add(objMerlin)
            objMerlin.Enabled = True
            objMerlin.Location = New System.Drawing.Point(0, 0)
            objMerlin.Name = "objMerlin"
            objMerlin.Size = New System.Drawing.Size(0, 0)
            objMerlin.TabIndex = 29
            objMerlin.Characters.Load("Merlin", "C:\Windows\msagent\chars\merlin.acs")
            objMerlin.Characters("Merlin").Activate()
            objMerlin.Characters("Merlin").MoveTo(trvMain.Width + trvMain.Left - objMerlin.Characters("Merlin").Width, trvMain.Height + trvMain.Top)

            If (My.MySettings.Default("ShowMerlin") = True) Then
                objMerlin.Characters("Merlin").Show()
            End If

            m_objLucidItemControl.SetMerlin(objMerlin)
            m_boolAgentWorks = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "LightenedDream.LoadMerlin()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadImport()
        If Not trvNodeImported Is Nothing Then
            trvMain.SelectedNode = trvNodeImported
            If mnuToolsPlay.Enabled Then
                Threading.Thread.Sleep(250)
                Application.DoEvents()
                Threading.Thread.Sleep(250)
                PlayLucid()
            End If
        End If
    End Sub

    Private Sub ImportFile()

    End Sub

    ' Load all the user controls to speed up resizing / loading later
    Private Sub LoadGUI()
        ' Dreams
        pnlContainer.Controls.Clear()
        m_objDreamViewControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objDreamViewControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objMonthListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objMonthListControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objYearListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objYearListControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objYearsListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objYearsListControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objSearchControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objSearchControl)
        Application.DoEvents()

        ' Categories
        pnlContainer.Controls.Clear()
        m_objCategoryViewControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objCategoryViewControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objCategoriesListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objCategoriesListControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objCategoryListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objCategoryListControl)
        Application.DoEvents()

        ' Lucidity
        pnlContainer.Controls.Clear()
        m_objREMCyclesControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objREMCyclesControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objLucidItemControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objLucidItemControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objLucidFolderViewControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objLucidFolderViewControl)
        Application.DoEvents()

        pnlContainer.Controls.Clear()
        m_objLucidityControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objLucidityControl)
        Application.DoEvents()

        ' Exercises
    End Sub

    Private Sub LoadTree()
        Try
            trvMain.Nodes.Clear()
            LoadDreams()
            LoadCategories()
            LoadLucidity()
            LoadExercises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadTree()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDreams()
        Try
            ' Create the Dream node
            Dim trvDreams As New TreeNode("Dreams")
            Dim trvDream As TreeNode = Nothing
            Dim objDreamsFolderTag As New Dreams.Tags.YearsFolder(m_strPath + "Dreams", "")
            trvDreams.Tag = objDreamsFolderTag
            trvMain.Nodes.Add(trvDreams)

            ' Make sure that the dreams folder exists
            If Not Directory.Exists(m_strPath + "Dreams") Then
                Directory.CreateDirectory(m_strPath + "Dreams")
            End If

            ' Make sure we have an entry
            If Directory.GetDirectories(m_strPath + "Dreams").Length = 0 Then
                CreateWelcomeDream()
            End If

            ' Load each year
            For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
                Dim trvYear As New TreeNode(New DirectoryInfo(strYearFolder).Name)
                Dim objYearTag As New Dreams.Tags.YearFolder(strYearFolder, trvYear.Text)
                trvYear.Tag = objYearTag
                trvDreams.Nodes.Add(trvYear)

                ' Load each month
                For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
                    Dim trvMonth As New TreeNode(New DirectoryInfo(strMonthFolder).Name)
                    Dim objMonthTag As New Dreams.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text)
                    trvMonth.Tag = objMonthTag
                    trvYear.Nodes.Add(trvMonth)

                    ' Load each dream
                    For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
                        trvDream = New TreeNode(New FileInfo(strDreamFile).Name.Replace(".ld3", ""))
                        Dim objDreamTag As New Dreams.Tags.DreamFile(strDreamFile)
                        trvDream.Tag = objDreamTag
                        trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                        trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                        trvMonth.Nodes.Add(trvDream)

                        ' Add the loading node
                        Dim trvLoading As New TreeNode("Loading Categories...")
                        trvDream.Nodes.Add(trvLoading)
                    Next

                Next
            Next

            If trvDream IsNot Nothing Then
                trvMain.SelectedNode = trvDream
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadDreams()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateWelcomeDream()
        Directory.CreateDirectory(m_strPath + "Dreams\" + Now.Year.ToString)
        Directory.CreateDirectory(m_strPath + "Dreams\" + Now.Year.ToString + "\" + Format(Now, "MM"))

        Dim strXml As String = "<Dream>"
        strXml += "<Date>" + Format(Now, "yyyy-MM-dd") + "</Date>"
        strXml += "<Time>04:20</Time>"
        strXml += "<Sleep>23:30</Sleep>"
        strXml += "<Awake>06:30</Awake>"
        strXml += "<Title>" + "First Entry" + "</Title>"
        strXml += "<Dream>" + "" + "</Dream>"
        strXml += "<Clarity>" + "5" + "</Clarity>"
        strXml += "<Lessons>" + "" + "</Lessons>"
        strXml += "</Dream>"

        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)
        Dim strFileName As String = m_strPath + "Dreams\" + Now.Year.ToString + "\" + Format(Now, "MM") + "\" + Format(Now, "dd") + " " + "First Entry" + ".ld3"
        xmlDoc.Save(strFileName)
    End Sub

    Private Sub CreateWelcomeExercise()
        Directory.CreateDirectory(m_strPath + "\Lucidity\Exercises\" + Now.Year.ToString)
        Directory.CreateDirectory(m_strPath + "\Lucidity\Exercises\" + Now.Year.ToString + "\" + Format(Now, "MM"))

        Dim strXml As String = "<Exercise>"
        strXml += "<Date>" + Format(Now, "yyyy-MM-dd") + "</Date>"
        strXml += "<Time>" + Format(Now, "HH:mm") + "</Time>"
        strXml += "<Title>" + "First Exercise" + "</Title>"
        strXml += "<Task>" + "Install Lightened Dream." + "</Task>"
        strXml += "<Details></Details>"
        strXml += "<Lucidity>" + "5" + "</Lucidity>"
        strXml += "</Exercise>"

        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)
        Dim strFileName As String = m_strPath + "Lucidity\Exercises\" + Now.Year.ToString + "\" + Format(Now, "MM") + "\" + Format(Now, "dd") + " " + "First Exercise" + ".ld3"
        xmlDoc.Save(strFileName)
    End Sub

    Private Sub LoadCategories()
        Try
            ' Create the Categories node
            Dim trvCategories As New TreeNode("Categories")
            Dim objCategoriesFolderTag As New Categories.Tags.CategoriesFolder(m_strPath + "Categories")
            trvCategories.Tag = objCategoriesFolderTag
            trvMain.Nodes.Add(trvCategories)

            ' Load each Category
            For Each strCategory As String In m_strCategories.Split(",")
                LoadCategoryFolder(strCategory)
                'Dim objToolMenuItem As New ToolStripMenuItem
                'objToolMenuItem.Text = strCategory.Substring(0, strCategory.Length - 1)
                'AddHandler objToolMenuItem.Click, AddressOf mnuToolNewCategory_Click
                'toolNew.DropDownItems.Add(objToolMenuItem)
            Next

            ' Load each custom category
            For Each strFolder As String In Directory.GetDirectories(m_strPath + "Categories")
                Dim boolisDefault As Boolean = False
                For Each strCategory As String In m_strCategories.Split(",")
                    If strCategory.ToLower = New DirectoryInfo(strFolder).Name.ToLower Then
                        boolisDefault = True
                        Exit For
                    End If
                Next

                If Not boolisDefault Then
                    LoadCategoryFolder(New DirectoryInfo(strFolder).Name)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCategoryFolder(ByVal strCategory As String)
        Dim trvCategoryFolder As New TreeNode(strCategory)
        Dim objCategoryFolderTag As New Categories.Tags.CategoryFolder(m_strPath + "Categories\" + strCategory)
        trvCategoryFolder.Tag = objCategoryFolderTag
        If lstImgTrv.Images.IndexOfKey("Folder." & strCategory) <> -1 Then
            trvCategoryFolder.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." & strCategory)
            trvCategoryFolder.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." & strCategory)
        End If
        trvMain.Nodes(1).Nodes.Add(trvCategoryFolder)

        ' Make sure that the folder exists
        If Not Directory.Exists(m_strPath + "Categories\" + strCategory) Then
            Directory.CreateDirectory(m_strPath + "Categories\" + strCategory)
        End If

        ' Load each item
        For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3")
            Dim trvCategory As New TreeNode(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
            Dim objCategoryTag As New Categories.Tags.CategoryFile(strCatgeoryFile, strCategory)
            objCategoryTag.Category = strCategory.Substring(0, strCategory.Length - 1)
            trvCategory.Tag = objCategoryTag
            trvCategory.ImageIndex = 2
            trvCategory.SelectedImageIndex = 2
            If lstImgTrv.Images.IndexOfKey("File." & strCategory) <> -1 Then
                trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
            End If
            trvCategoryFolder.Nodes.Add(trvCategory)
            m_arrCategories.Add(trvCategory.Text)

            ' Load each dream
            Dim xmlCategory As New Xml.XmlDocument
            xmlCategory.Load(strCatgeoryFile)
            For Each xmlDreamNode As XmlNode In xmlCategory.DocumentElement.SelectNodes("//Dream")
                Dim trvDream As New TreeNode(xmlDreamNode.Attributes("Date").InnerText + " " + xmlDreamNode.Attributes("Title").InnerText)
                Dim objDreamTag As New Dreams.Tags.DreamFile(m_strPath + "Dreams\" + xmlDreamNode.Attributes("Date").InnerText.Replace("-", "/") + " " + xmlDreamNode.Attributes("Title").InnerText + ".ld3")
                trvDream.Tag = objDreamTag
                trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                trvCategory.Nodes.Add(trvDream)
                ' Add the loading node
                Dim trvLoading As New TreeNode("Loading Categories...")
                trvDream.Nodes.Add(trvLoading)
            Next
        Next
    End Sub

    Private Sub LoadLucidity()
        Try
            ' Create the Lucidty node
            Dim trvLucidity As TreeNode = trvMain.Nodes.Add("Lucidity", "Lucidity")
            Dim objLucidityFolderTag As New Lucidity.Tags.LucidityFolder(m_strPath + "Lucidity")
            trvLucidity.Tag = objLucidityFolderTag

            Dim strLucidity As String = "REM Cycles,Checks,Subliminals,Recordings,Readings"

            ' Load each Category
            For Each strCategory As String In strLucidity.Split(",")
                Dim trvCategoryFolder As TreeNode = trvLucidity.Nodes.Add(strCategory, strCategory)
                'If strCategory = "REM Cycles" Then
                '  Dim objCategoryFolderTag As New Lucidity.Tags.REMCyclesFolder(m_strPath + "Lucidity\" + strCategory)
                '  trvCategoryFolder.Tag = objCategoryFolderTag
                '  If lstImgTrv.Images.IndexOfKey("Folder." & strCategory) <> -1 Then
                '    trvCategoryFolder.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." & strCategory)
                '    trvCategoryFolder.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." & strCategory)
                '  End If
                'Else
                Dim objCategoryFolderTag As New Lucidity.Tags.LucidItemFolder(m_strPath + "Lucidity\" + strCategory, strCategory)
                trvCategoryFolder.Tag = objCategoryFolderTag
                If lstImgTrv.Images.IndexOfKey("Folder." & strCategory) <> -1 Then
                    trvCategoryFolder.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." & strCategory)
                    trvCategoryFolder.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." & strCategory)
                End If
                'End If

                ' Make sure that the folder exists
                If Not Directory.Exists(m_strPath + "Lucidity\" + strCategory) Then
                    Directory.CreateDirectory(m_strPath + "Lucidity\" + strCategory)
                End If

                ' Load each item
                For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Lucidity\" + strCategory, "*.ld3")
                    If strCategory = "REM Cycles" Then
                        Dim trvCategory As New TreeNode(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
                        Dim objCategoryTag As New Lucidity.Tags.REMCycleFile(strCatgeoryFile)
                        trvCategory.Tag = objCategoryTag
                        trvCategory.ImageIndex = 2
                        trvCategory.SelectedImageIndex = 2
                        If lstImgTrv.Images.IndexOfKey("File." & strCategory) <> -1 Then
                            trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                            trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                        End If
                        trvCategoryFolder.Nodes.Add(trvCategory)
                    Else
                        Dim trvCategory As New TreeNode(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
                        Dim objCategoryTag As New Lucidity.Tags.LucidItemFile(strCatgeoryFile, New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
                        trvCategory.Tag = objCategoryTag
                        trvCategory.ImageIndex = 2
                        trvCategory.SelectedImageIndex = 2
                        If lstImgTrv.Images.IndexOfKey("File." & strCategory) <> -1 Then
                            trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                            trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                        End If
                        trvCategoryFolder.Nodes.Add(trvCategory)

                    End If
                Next

                ' Create the menu items
                'Dim objToolMenuItem As New ToolStripMenuItem
                'objToolMenuItem.Text = strCategory.Substring(0, strCategory.Length - 1)
                'AddHandler objToolMenuItem.Click, AddressOf mnuToolNewCategory_Click
                'toolNew.DropDownItems.Add(objToolMenuItem)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadExercises()
        Try
            ' Create the Exercises node
            Dim trvExercises As New TreeNode("Exercises")
            Dim trvDream As TreeNode = Nothing
            Dim objExercisesFolderTag As New Lucidity.Tags.YearsFolder(m_strPath + "Lucidity\Exercises", "")
            trvExercises.Tag = objExercisesFolderTag
            trvMain.Nodes(2).Nodes.Add(trvExercises)

            ' Make sure that the Exercises folder exists
            If Not Directory.Exists(m_strPath + "Lucidity\Exercises") Then
                Directory.CreateDirectory(m_strPath + "Lucidity\Exercises")
            End If

            ' Make sure we have an entry
            If Directory.GetDirectories(m_strPath + "Lucidity\Exercises").Length = 0 Then
                CreateWelcomeExercise()
            End If

            ' Load each year
            For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Lucidity\Exercises")
                Dim trvYear As New TreeNode(New DirectoryInfo(strYearFolder).Name)
                Dim objYearTag As New Lucidity.Tags.YearFolder(strYearFolder, trvYear.Text)
                trvYear.Tag = objYearTag
                trvExercises.Nodes.Add(trvYear)

                ' Load each month
                For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
                    Dim trvMonth As New TreeNode(New DirectoryInfo(strMonthFolder).Name)
                    Dim objMonthTag As New Lucidity.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text)
                    trvMonth.Tag = objMonthTag
                    trvYear.Nodes.Add(trvMonth)

                    ' Load each dream
                    For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
                        trvDream = New TreeNode(New FileInfo(strDreamFile).Name.Replace(".ld3", ""))
                        Dim objDreamTag As New Lucidity.Tags.DreamFile(strDreamFile)
                        trvDream.Tag = objDreamTag
                        trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Exercise")
                        trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Exercise")
                        trvMonth.Nodes.Add(trvDream)

                        ' Add the loading node
                        'Dim trvLoading As New TreeNode("Loading Categories...")
                        'trvDream.Nodes.Add(trvLoading)
                    Next

                Next
            Next

            'If trvDream IsNot Nothing Then
            '  trvMain.SelectedNode = trvDream
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadExercises()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSpellCheckLanguages()
        Try
            Dim xmlDocSettings As New XmlDocument

            ' Make sure the file exists
            If Not File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck.xml") Then
                Dim strXml As String = "<lucidcode>"

                strXml += "<Language>English</Language>"
                strXml += "<CheckSpelling>True</CheckSpelling>"

                strXml += "</lucidcode>"
                xmlDocSettings.LoadXml(strXml)
                xmlDocSettings.Save(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck.xml")
            End If

            xmlDocSettings.Load(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck.xml")
            If xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText = "True" Then
                m_objDreamViewControl.EnableSpellCheck()
                m_objLucidItemControl.EnableSpellCheck()
                mnuCheckSpelling.Checked = True
            Else
                mnuCheckSpelling.Checked = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadSpellCheckLanguages()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuCheckSpelling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckSpelling.Click
        Try
            Dim xmlDocSettings As New XmlDocument
            xmlDocSettings.Load(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck.xml")

            If mnuCheckSpelling.Checked Then
                xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText = "True"
                m_objDreamViewControl.EnableSpellCheck()
                m_objLucidItemControl.EnableSpellCheck()
            Else
                xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText = "False"
                m_objDreamViewControl.DisableSpellCheck()
                m_objLucidItemControl.DisableSpellCheck()
            End If

            xmlDocSettings.Save(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck.xml")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.SetSpellCheck()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CancelForSave(ByVal trvNode As TreeNode, ByVal boolClosing As Boolean) As Boolean
        Try
            Dim boolChanged As Boolean = False
            If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
                boolChanged = m_objDreamViewControl.Changed
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.DreamFile Then
                boolChanged = m_objExerciseViewControl.Changed
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFile Then
                boolChanged = m_objCategoryViewControl.Changed
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                boolChanged = m_objREMCyclesControl.Changed
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFile Then
                boolChanged = m_objLucidItemControl.Changed
            End If

            If boolChanged Then
                Dim objResult As DialogResult
                objResult = MessageBox.Show("Would you like to save the changes you made to '" & trvMain.SelectedNode.Text & "'?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If objResult = Windows.Forms.DialogResult.Yes Then
                    'Save
                    Save()
                    'If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
                    '  m_objDreamViewControl.Save()
                    'ElseIf TypeOf (trvNode.Tag) Is Categories.Tags.CategoryFile Then
                    '  m_objCategoryViewControl.Save()
                    'ElseIf TypeOf (trvNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                    '  m_objREMCyclesControl.Save()
                    'ElseIf TypeOf (trvNode.Tag) Is Lucidity.Tags.LucidItemFile Then
                    '  m_objLucidItemControl.Save()
                    'End If
                ElseIf objResult = Windows.Forms.DialogResult.Cancel Then
                    Return True
                End If
            End If

            If TypeOf (trvNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                If m_objREMCyclesControl.tmrWatch.Enabled Then
                    If (m_objREMCyclesControl.txtTitle.Text <> trvNode.Text) Or boolClosing Then
                        If MessageBox.Show("The REM Cycle '" & m_objREMCyclesControl.txtTitle.Text & "' is currently playing." & vbNewLine & "Are you sure you wish to stop it?", "Stop REM Cycle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) <> DialogResult.Yes Then
                            Return True
                        End If
                    End If
                End If
            End If

            Return False

        Catch ex As Exception

        End Try
    End Function

    Private Sub SelectTreeNode()
        Try
            toolSave.Enabled = False
            toolUpdate.Enabled = False
            toolDelete.Enabled = False
            toolPlay.Enabled = False
            toolPlay.Image = My.Resources.Function_Play
            toolPlay.Text = "&Play"
            mnuToolsPlay.Enabled = False
            toolBack.Enabled = False
            toolForward.Enabled = False
            lblStatus.Text = ""

            If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
                pnlContainer.Controls.Clear()
                m_objDreamViewControl.Dock = DockStyle.Fill
                pnlContainer.Controls.Add(m_objDreamViewControl)
                Application.DoEvents()
                m_objDreamViewControl.LoadDream(CType(trvMain.SelectedNode.Tag, Dreams.Tags.DreamFile).Path)
                If Not TypeOf (trvMain.SelectedNode.Parent.Tag) Is Categories.Tags.CategoryFile Then
                    toolSave.Enabled = True
                    toolDelete.Enabled = True
                End If
                If m_objDreamViewControl.Words = 1 Then
                    lblStatus.Text = m_objDreamViewControl.Words.ToString + " Word"
                Else
                    lblStatus.Text = m_objDreamViewControl.Words.ToString + " Words"
                End If

                toolPlay.Enabled = True
                mnuToolsPlay.Enabled = True
                If m_objDreamViewControl.Playing Then
                    toolPlay.Image = My.Resources.Function_Stop
                    toolPlay.Text = "&Stop"
                Else
                    toolPlay.Image = My.Resources.Function_Play
                    toolPlay.Text = "&Play"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.DreamFile Then
                pnlContainer.Controls.Clear()
                m_objExerciseViewControl.Dock = DockStyle.Fill
                pnlContainer.Controls.Add(m_objExerciseViewControl)
                Application.DoEvents()
                m_objExerciseViewControl.LoadExercise(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.DreamFile).Path)
                If Not TypeOf (trvMain.SelectedNode.Parent.Tag) Is Categories.Tags.CategoryFile Then
                    toolSave.Enabled = True
                    toolDelete.Enabled = True
                End If
                If m_objExerciseViewControl.Words = 1 Then
                    lblStatus.Text = m_objExerciseViewControl.Words.ToString + " Word"
                Else
                    lblStatus.Text = m_objExerciseViewControl.Words.ToString + " Words"
                End If

                toolPlay.Enabled = True
                mnuToolsPlay.Enabled = True
                If m_objExerciseViewControl.Playing Then
                    toolPlay.Image = My.Resources.Function_Stop
                    toolPlay.Text = "&Stop"
                Else
                    toolPlay.Image = My.Resources.Function_Play
                    toolPlay.Text = "&Play"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.MonthFolder Then
                pnlContainer.Controls.Clear()
                m_objMonthListControl.Dock = DockStyle.Fill
                m_objMonthListControl.LoadMonth(CType(trvMain.SelectedNode.Tag, Dreams.Tags.MonthFolder).Path, CType(trvMain.SelectedNode.Tag, Dreams.Tags.MonthFolder).Year, CType(trvMain.SelectedNode.Tag, Dreams.Tags.MonthFolder).Month)
                Application.DoEvents()
                pnlContainer.Controls.Add(m_objMonthListControl)
                If trvMain.SelectedNode.Nodes.Count = 1 Then
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Dream"
                Else
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Dreams"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.MonthFolder Then
                pnlContainer.Controls.Clear()
                m_objExerciseMonthListControl.Dock = DockStyle.Fill
                m_objExerciseMonthListControl.LoadMonth(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.MonthFolder).Path, CType(trvMain.SelectedNode.Tag, Lucidity.Tags.MonthFolder).Year, CType(trvMain.SelectedNode.Tag, Lucidity.Tags.MonthFolder).Month)
                Application.DoEvents()
                pnlContainer.Controls.Add(m_objExerciseMonthListControl)
                If trvMain.SelectedNode.Nodes.Count = 1 Then
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Exercise"
                Else
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Exercises"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.YearFolder Then
                pnlContainer.Controls.Clear()
                m_objYearListControl.Dock = DockStyle.Fill
                m_objYearListControl.LoadYear(CType(trvMain.SelectedNode.Tag, Dreams.Tags.YearFolder).Path, CType(trvMain.SelectedNode.Tag, Dreams.Tags.YearFolder).Year)
                pnlContainer.Controls.Add(m_objYearListControl)
                If trvMain.SelectedNode.Nodes.Count = 1 Then
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Month"
                Else
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Months"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.YearFolder Then
                pnlContainer.Controls.Clear()
                m_objExerciseYearListControl.Dock = DockStyle.Fill
                m_objExerciseYearListControl.LoadYear(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.YearFolder).Path, CType(trvMain.SelectedNode.Tag, Lucidity.Tags.YearFolder).Year)
                pnlContainer.Controls.Add(m_objExerciseYearListControl)
                If trvMain.SelectedNode.Nodes.Count = 1 Then
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Month"
                Else
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Months"
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.YearsFolder Then
                If m_boolYearSelected Then Exit Sub
                m_boolYearSelected = True
                pnlContainer.Controls.Clear()
                m_objYearsListControl.Dock = DockStyle.Fill
                m_objYearsListControl.LoadYears()
                pnlContainer.Controls.Add(m_objYearsListControl)
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.YearsFolder Then
                pnlContainer.Controls.Clear()
                m_objExerciseYearsListControl.Dock = DockStyle.Fill
                m_objExerciseYearsListControl.LoadYears()
                pnlContainer.Controls.Add(m_objExerciseYearsListControl)

                ' Categories
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFile Then
                pnlContainer.Controls.Clear()
                m_objCategoryViewControl.Dock = DockStyle.Fill
                m_objCategoryViewControl.LoadCategory(CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFile).Path, CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFile).Category)
                pnlContainer.Controls.Add(m_objCategoryViewControl)
                If Not TypeOf (trvMain.SelectedNode.Parent.Tag) Is Dreams.Tags.DreamFile Then
                    toolSave.Enabled = True
                    toolDelete.Enabled = True
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFolder Then
                If trvMain.SelectedNode.Nodes.Count = 1 Then
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Entry"
                Else
                    lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString + " Entries"
                End If
                pnlContainer.Controls.Clear()
                m_objCategoryListControl.Dock = DockStyle.Fill
                m_objCategoryListControl.Category = trvMain.SelectedNode.Text
                m_objCategoryListControl.LoadCategory()
                pnlContainer.Controls.Add(m_objCategoryListControl)

                Dim boolIsDefault = False
                For Each strFolder As String In m_strCategories
                    If strFolder.ToLower = trvMain.SelectedNode.Text.ToLower Then
                        boolIsDefault = True
                        Exit For
                    End If
                Next
                If Not boolIsDefault Then
                    toolSave.Enabled = True
                    toolDelete.Enabled = True
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoriesFolder Then
                pnlContainer.Controls.Clear()
                m_objCategoriesListControl.Dock = DockStyle.Fill
                m_objCategoriesListControl.Categories = m_strCategories
                m_objCategoriesListControl.LoadCategories()
                pnlContainer.Controls.Add(m_objCategoriesListControl)

                ' Lucidity 
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidityFolder Then
                pnlContainer.Controls.Clear()
                m_objLucidityControl.Dock = DockStyle.Fill
                pnlContainer.Controls.Add(m_objLucidityControl)
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFolder Then
                pnlContainer.Controls.Clear()
                m_objLucidFolderViewControl.Dock = DockStyle.Fill
                m_objLucidFolderViewControl.LoadFolder(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.LucidItemFolder).Type)
                pnlContainer.Controls.Add(m_objLucidFolderViewControl)

                If trvMain.SelectedNode.Text = "Checks" Then
                    toolPlay.Enabled = True
                    If m_objLucidFolderViewControl.Playing Then
                        toolPlay.Image = My.Resources.Function_Stop
                        toolPlay.Text = "&Stop"
                    Else
                        toolPlay.Image = My.Resources.Function_Play
                        toolPlay.Text = "&Play"
                    End If
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                pnlContainer.Controls.Clear()
                m_objREMCyclesControl.Dock = DockStyle.Fill
                m_objREMCyclesControl.LoadREM(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.REMCycleFile).Path)
                pnlContainer.Controls.Add(m_objREMCyclesControl)
                toolSave.Enabled = True
                toolDelete.Enabled = True
                toolPlay.Enabled = True
                mnuToolsPlay.Enabled = True
                If m_objREMCyclesControl.tmrWatch.Enabled Then
                    toolPlay.Image = My.Resources.Function_Stop
                    toolPlay.Text = "&Stop"
                Else
                    toolPlay.Image = My.Resources.Function_Play
                    toolPlay.Text = "&Play"
                End If
                toolBack.Enabled = True
                toolForward.Enabled = True
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFile Then
                pnlContainer.Controls.Clear()
                m_objLucidItemControl.Dock = DockStyle.Fill
                m_objLucidItemControl.LoadFile(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.LucidItemFile).Path)
                pnlContainer.Controls.Add(m_objLucidItemControl)
                toolSave.Enabled = True
                toolDelete.Enabled = True
                toolPlay.Enabled = True
                mnuToolsPlay.Enabled = True
                toolBack.Enabled = True
                toolForward.Enabled = True
                If m_objLucidItemControl.Playing Then
                    toolPlay.Image = My.Resources.Function_Stop
                    toolPlay.Text = "&Stop"
                Else
                    toolPlay.Image = My.Resources.Function_Play
                    toolPlay.Text = "&Play"
                End If
            End If

            toolUpdate.Enabled = toolSave.Enabled

            ' Navigation
            If Not m_boolNavigating Then
                m_arrBackHistory.Add(trvMain.SelectedNode)
                If (m_arrBackHistory.Count >= 1) Then
                    toolBack.Enabled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.SelectTreeNode()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelectREMCycles()
        trvMain.SelectedNode = trvMain.Nodes("Lucidity").Nodes("REM Cycles")
    End Sub

    Private Sub trvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterSelect
        SelectTreeNode()
    End Sub

    Private Sub mnuToolNewDream_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolNewDream.Click, DreamToolStripMenuItem.Click, ToolStripMenuItem2.Click
        CreateNewDream()
    End Sub

    Private Sub CreateNewDream()
        ' Generate new filename
        Dim strTitle As String = "New Dream"
        Dim strFileName As String = GetFolder(Now) + Format(Now, "dd") + " " + strTitle + ".ld3"
        Dim intPos As Integer = 2
        Do
            If (File.Exists(strFileName)) Then
                strTitle = "New Dream " + intPos.ToString
                strFileName = GetFolder(Now) + Format(Now, "dd") + " " + strTitle + ".ld3"
                intPos += 1
            Else
                Exit Do
            End If
        Loop

        ' Create a blank dream
        Dim strXml As String
        strXml = "<Dream>"
        strXml += "<Date>" + Format(Now, "yyyy-MM-dd") + "</Date>"
        strXml += "<Time>04:20</Time>"
        If m_dtLastREMPlayed = Nothing Then
            m_dtLastREMPlayed = Now
        End If
        strXml += "<Sleep>23:30</Sleep>"
        strXml += "<Awake>06:30</Awake>"
        strXml += "<Title>" + strTitle + "</Title>"
        strXml += "<Lucidity>5</Lucidity>"
        strXml += "<Dream>" + "" + "</Dream>"
        strXml += "<Clarity>" + "" + "</Clarity>"
        strXml += "<Lessons>" + "" + "</Lessons>"
        strXml += "</Dream>"
        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)
        xmlDoc.Save(strFileName)

        ' Update Tree   
        Dim trvDream As New TreeNode(New FileInfo(strFileName).Name.Replace(".ld3", ""))
        Dim objDreamTag As New Dreams.Tags.DreamFile(strFileName)
        trvDream.Tag = objDreamTag
        trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
        trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
        GetDreamFolder(Now).Nodes.Add(trvDream)

        ' Select Dream
        trvMain.SelectedNode = trvDream
        m_objDreamViewControl.Focus()
    End Sub

    Private Sub CreateNewExercise(ByVal Random As Boolean)
        Dim strSelectedName = "New Exercise"
        Dim strSelectedTask = ""
        Dim strSelectedDetails = ""
        Dim strSelectedLucidity = "1"

        If Random Then
            ' Randomly select Exercise
            Dim xmlDocExercises As New XmlDocument
            Dim objMemStream As New MemoryStream(Lucidity.My.Resources.Exercises)
            xmlDocExercises.Load(objMemStream)
            Dim intCount As Integer = xmlDocExercises.DocumentElement.SelectNodes("Exercise").Count
            Dim intExercise As Integer = Int(Rnd() * intCount)
            Dim intPosition As Integer = 0
            Dim xmlNodeExercise As XmlNode

            For Each xmlNodeExercises As XmlNode In xmlDocExercises.DocumentElement.SelectNodes("Exercise")
                If intPosition = intExercise Then
                    xmlNodeExercise = xmlNodeExercises
                    strSelectedName = xmlNodeExercise.SelectSingleNode("Title").InnerText
                    strSelectedTask = xmlNodeExercise.SelectSingleNode("Task").InnerText
                    strSelectedLucidity = xmlNodeExercise.SelectSingleNode("Lucidity").InnerText
                    If Not xmlNodeExercise.SelectSingleNode("Details") Is Nothing Then
                        strSelectedDetails = xmlNodeExercise.SelectSingleNode("Details").InnerText
                    End If
                    Exit For
                End If
                intPosition += 1
            Next
        End If

        ' Generate new filename
        Dim strTitle As String = strSelectedName
        Dim strFileName As String = GetFolderExercise(Now) + Format(Now, "dd") + " " + strTitle + ".ld3"
        Dim intPos As Integer = 2
        Do
            If (File.Exists(strFileName)) Then
                strTitle = strSelectedName & " " & intPos.ToString
                strFileName = GetFolderExercise(Now) + Format(Now, "dd") + " " + strTitle + ".ld3"
                intPos += 1
            Else
                Exit Do
            End If
        Loop

        ' Create a new Exercise
        Dim strXml As String
        strXml = "<Exercise>"
        strXml += "<Date>" & Format(Now, "yyyy-MM-dd") & "</Date>"
        strXml += "<Time>" & Format(Now, "HH:mm") & "</Time>"
        strXml += "<Title>" + strSelectedName + "</Title>"
        strXml += "<Task>" & strSelectedTask & "</Task>"
        strXml += "<Details>" & strSelectedDetails & "</Details>"
        strXml += "<Lucidity>" & strSelectedLucidity & "</Lucidity>"
        strXml += "</Exercise>"

        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)
        xmlDoc.Save(strFileName)

        ' Update Tree   
        Dim trvDream As New TreeNode(New FileInfo(strFileName).Name.Replace(".ld3", ""))
        Dim objDreamTag As New Lucidity.Tags.DreamFile(strFileName)
        trvDream.Tag = objDreamTag
        trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Exercise")
        trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Exercise")
        GetExerciseFolder(Now).Nodes.Add(trvDream)

        ' Select Exercise
        trvMain.SelectedNode = trvDream
        m_objExerciseViewControl.Focus()
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

    Private Function GetFolderExercise(ByVal FolderDate As DateTime) As String
        If Not Directory.Exists(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy")) Then
            Directory.CreateDirectory(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy"))
        End If
        If Not Directory.Exists(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM")) Then
            Directory.CreateDirectory(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM"))
        End If
        Return m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM") + "\"
    End Function

    Private Function GetDreamFolder(ByVal FolderDate As DateTime) As TreeNode
        If FindNode(trvMain.Nodes(0), (Format(FolderDate, "yyyy"))) Is Nothing Then
            ' Create a new year node
            Dim trvYearNode As TreeNode = trvMain.Nodes(0).Nodes.Add(Format(FolderDate, "yyyy"))
            Dim objYearTag As New Dreams.Tags.YearFolder(m_strPath & "Dreams\" & Format(FolderDate, "yyyy"), Format(FolderDate, "yyyy"))
            trvYearNode.Tag = objYearTag
        End If
        If FindNode(FindNode(trvMain.Nodes(0), Format(FolderDate, "yyyy")), Format(FolderDate, "MM")) Is Nothing Then
            ' Create a new month node
            Dim trvMonthNode As TreeNode = FindNode(trvMain.Nodes(0), (Format(FolderDate, "yyyy"))).Nodes.Add(Format(FolderDate, "MM"))
            Dim objMonthTag As New Dreams.Tags.MonthFolder(m_strPath & "Dreams\" & Format(FolderDate, "yyyy") & "\" & Format(FolderDate, "MM"), Format(FolderDate, "yyyy"), Format(FolderDate, "MM"))
            trvMonthNode.Tag = objMonthTag
        End If
        Return FindNode(FindNode(trvMain.Nodes(0), Format(FolderDate, "yyyy")), Format(FolderDate, "MM"))
    End Function

    Private Function GetExerciseFolder(ByVal FolderDate As DateTime) As TreeNode
        If FindNode(trvMain.Nodes(2).Nodes(5), (Format(FolderDate, "yyyy"))) Is Nothing Then
            ' Create a new year node
            Dim trvYearNode As TreeNode = trvMain.Nodes(2).Nodes(5).Nodes.Add(Format(FolderDate, "yyyy"))
            Dim objYearTag As New Lucidity.Tags.YearFolder(m_strPath & "Lucidity\Exercises\" & Format(FolderDate, "yyyy"), Format(FolderDate, "yyyy"))
            trvYearNode.Tag = objYearTag
        End If
        If FindNode(FindNode(trvMain.Nodes(2).Nodes(5), Format(FolderDate, "yyyy")), Format(FolderDate, "MM")) Is Nothing Then
            ' Create a new month node
            Dim trvMonthNode As TreeNode = FindNode(trvMain.Nodes(2).Nodes(5), (Format(FolderDate, "yyyy"))).Nodes.Add(Format(FolderDate, "MM"))
            Dim objMonthTag As New Lucidity.Tags.MonthFolder(m_strPath & "Lucidity\Exercises\" & Format(FolderDate, "yyyy") & "\" & Format(FolderDate, "MM"), Format(FolderDate, "yyyy"), Format(FolderDate, "MM"))
            trvMonthNode.Tag = objMonthTag
        End If
        Return FindNode(FindNode(trvMain.Nodes(2).Nodes(5), Format(FolderDate, "yyyy")), Format(FolderDate, "MM"))
    End Function

    Private Sub mnuToolNewCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolNewCharacter.Click, mnuToolNewTheme.Click, mnuToolNewObject.Click, mnuToolNewLocation.Click, mnuToolNewEmotion.Click, mnuToolNewAction.Click, ThemeToolStripMenuItem2.Click, ObjectToolStripMenuItem.Click, LocationToolStripMenuItem1.Click, EmotionToolStripMenuItem1.Click, CharacterToolStripMenuItem1.Click, ActionToolStripMenuItem1.Click, ToolStripMenuItem8.Click, ToolStripMenuItem4.Click, ToolStripMenuItem14.Click, ToolStripMenuItem13.Click, ToolStripMenuItem12.Click, ToolStripMenuItem10.Click
        CreateNewCategory(CType(sender, ToolStripMenuItem).Text)
    End Sub

    Private Sub CreateNewCategory(ByVal Type As String, Optional ByVal Name As String = "")
        If Name = "" Then
            Name = "New " + Type
        End If
        Dim strTitle As String = Name
        Dim strFileName As String
        strFileName = m_strPath + "\Categories\" + Type + "s\" + strTitle + ".ld3"

        Dim intPos As Integer = 2
        Do
            If (File.Exists(strFileName)) Then
                strTitle = "New " + Type + " " + intPos.ToString
                strFileName = m_strPath + "\Categories\" + Type + "s\" + strTitle + ".ld3"
                intPos += 1
            Else
                Exit Do
            End If
        Loop

        Dim strXml As String
        strXml = "<Category>"
        strXml += "<Name>" + strTitle + "</Name>"
        strXml += "<Description></Description>"
        strXml += "<Names></Names>"
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
                    If (xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower.Contains(strTitle.ToLower)) Then
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
        xmlDoc.Save(strFileName)

        ' Update Tree   
        Dim trvCategoryItem As New TreeNode(New FileInfo(strFileName).Name.Replace(".ld3", ""))
        Dim objCategoryTag As New Categories.Tags.CategoryFile(strFileName, Type)
        trvCategoryItem.Tag = objCategoryTag
        trvCategoryItem.ImageIndex = 2
        trvCategoryItem.SelectedImageIndex = 2
        If lstImgTrv.Images.IndexOfKey("File." & Type + "s") <> -1 Then
            trvCategoryItem.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & Type + "s")
            trvCategoryItem.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & Type + "s")
        End If

        ' Add Item
        If FindNode(trvMain.Nodes(1), Type + "s") IsNot Nothing Then
            FindNode(trvMain.Nodes(1), Type + "s").Nodes.Add(trvCategoryItem)
        End If

        ' Select Item
        trvMain.SelectedNode = trvCategoryItem

        ' Load each dream
        Dim xmlCategory As New Xml.XmlDocument
        xmlCategory.Load(strFileName)
        For Each xmlDreamNode As XmlNode In xmlCategory.DocumentElement.SelectNodes("//Dream")
            Dim trvDream As New TreeNode(xmlDreamNode.Attributes("Date").InnerText + " " + xmlDreamNode.Attributes("Title").InnerText)
            Dim objDreamTag As New Dreams.Tags.DreamFile(m_strPath + "Dreams\" + xmlDreamNode.Attributes("Date").InnerText.Replace("-", "/") + " " + xmlDreamNode.Attributes("Title").InnerText + ".ld3")
            trvDream.Tag = objDreamTag
            trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
            trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
            trvCategoryItem.Nodes.Add(trvDream)
            ' Add the loading node
            Dim trvLoading As New TreeNode("Loading Categories...")
            trvDream.Nodes.Add(trvLoading)
        Next

        m_objCategoryViewControl.Focus()
    End Sub

    Private Function FindNode(ByVal Parent As TreeNode, ByVal Value As String) As TreeNode
        For Each trvNode As TreeNode In Parent.Nodes
            If trvNode.Text.ToLower = Value.ToLower Then
                Return trvNode
            End If
        Next
        Return Nothing
    End Function

    Private Sub toolSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSave.Click
        Save()
    End Sub

    Private Sub Save()
        Try
            ShowSearching()
            Application.DoEvents()

            ' Disabe the form
            Enabled = False

            If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
                m_objDreamViewControl.Save()
                'm_objDreamViewControl.UpdateView()
                trvMain.SelectedNode.Text = New FileInfo(m_objDreamViewControl.FileName).Name.Replace(".ld3", "")
                trvMain.SelectedNode.Tag = New Dreams.Tags.DreamFile(m_objDreamViewControl.FileName)
                Dim trvNewFolder As TreeNode = GetDreamFolder(m_objDreamViewControl.dtDate.Value)
                If Not trvNewFolder Is trvMain.SelectedNode.Parent Then
                    Dim trvTemp As TreeNode = trvMain.SelectedNode
                    trvTemp.Remove()
                    trvNewFolder.Nodes.Add(trvTemp)
                    trvMain.SelectedNode = trvTemp
                End If
                ReloadDreamNodes(trvMain.SelectedNode)
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.DreamFile Then
                m_objExerciseViewControl.Save()
                'm_objDreamViewControl.UpdateView()
                trvMain.SelectedNode.Text = New FileInfo(m_objExerciseViewControl.FileName).Name.Replace(".ld3", "")
                trvMain.SelectedNode.Tag = New Lucidity.Tags.DreamFile(m_objExerciseViewControl.FileName)
                Dim trvNewFolder As TreeNode = GetExerciseFolder(m_objExerciseViewControl.dtDate.Value)
                If Not trvNewFolder Is trvMain.SelectedNode.Parent Then
                    Dim trvTemp As TreeNode = trvMain.SelectedNode
                    trvTemp.Remove()
                    trvNewFolder.Nodes.Add(trvTemp)
                    trvMain.SelectedNode = trvTemp
                End If
                'ReloadDreamNodes(trvMain.SelectedNode)
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFolder Then
                m_objCategoryListControl.Save()
                If m_objCategoryListControl.txtName.Text <> trvMain.SelectedNode.Text Then
                    trvMain.SelectedNode.Text = m_objCategoryListControl.txtName.Text
                    CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFolder).Path = m_strPath & "Categories\" & trvMain.SelectedNode.Text
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFile Then
                m_objCategoryViewControl.Save()
                If m_objCategoryViewControl.txtName.Text <> trvMain.SelectedNode.Text Then
                    ' !ToDo: Update Tree
                    trvMain.SelectedNode.Text = m_objCategoryViewControl.txtName.Text
                    CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFile).Path = m_objCategoryViewControl.FileName

                    ' Load each dream
                    Dim xmlCategory As New Xml.XmlDocument
                    xmlCategory.Load(m_objCategoryViewControl.FileName)
                    trvMain.SelectedNode.Nodes.Clear()
                    For Each xmlDreamNode As XmlNode In xmlCategory.DocumentElement.SelectNodes("//Dream")
                        Dim trvDream As New TreeNode(xmlDreamNode.Attributes("Date").InnerText + " " + xmlDreamNode.Attributes("Title").InnerText)
                        Dim objDreamTag As New Dreams.Tags.DreamFile(m_strPath + "Dreams\" + xmlDreamNode.Attributes("Date").InnerText.Replace("-", "/") + " " + xmlDreamNode.Attributes("Title").InnerText + ".ld3")
                        trvDream.Tag = objDreamTag
                        trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                        trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                        trvMain.SelectedNode.Nodes.Add(trvDream)
                        ' Add the loading node
                        Dim trvLoading As New TreeNode("Loading Categories...")
                        trvDream.Nodes.Add(trvLoading)
                    Next
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFile Then
                m_objLucidItemControl.Save(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.LucidItemFile).Type)
                ' Update Tree
                trvMain.SelectedNode.Text = New FileInfo(m_objLucidItemControl.FileName).Name.Replace(".ld3", "")
                CType(trvMain.SelectedNode.Tag, Lucidity.Tags.LucidItemFile).Path = m_objLucidItemControl.FileName
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                m_objREMCyclesControl.Save()
                ' Update Tree
                trvMain.SelectedNode.Text = New FileInfo(m_objREMCyclesControl.FileName).Name.Replace(".ld3", "")
                CType(trvMain.SelectedNode.Tag, Lucidity.Tags.REMCycleFile).Path = m_objREMCyclesControl.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Edit()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Enabled = True
        HideSearching()
    End Sub

    Private Sub toolDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDelete.Click
        Delete()
    End Sub

    Private Sub Delete()
        Try
            If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
                If MessageBox.Show("Are you sure you wish to delete the dream '" & trvMain.SelectedNode.Text & "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(CType(trvMain.SelectedNode.Tag, Dreams.Tags.DreamFile).Path)
                    If trvMain.SelectedNode.Parent.Nodes.Count = 1 Then
                        ' It is the last dream in the month, delete it
                        Directory.Delete(CType(trvMain.SelectedNode.Parent.Tag, Dreams.Tags.MonthFolder).Path)
                        If trvMain.SelectedNode.Parent.Parent.Nodes.Count = 1 Then
                            ' It is the last dream in the year, delete it
                            Directory.Delete(CType(trvMain.SelectedNode.Parent.Parent.Tag, Dreams.Tags.YearFolder).Path)
                            trvMain.SelectedNode.Parent.Parent.Remove()
                        Else
                            trvMain.SelectedNode.Parent.Remove()
                        End If
                    Else
                        trvMain.SelectedNode.Remove()
                    End If
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.DreamFile Then
                If MessageBox.Show("Are you sure you wish to delete the Exercise '" & trvMain.SelectedNode.Text & "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.DreamFile).Path)
                    If trvMain.SelectedNode.Parent.Nodes.Count = 1 Then
                        ' It is the last Exercise in the month, delete it
                        Directory.Delete(CType(trvMain.SelectedNode.Parent.Tag, Lucidity.Tags.MonthFolder).Path)
                        If trvMain.SelectedNode.Parent.Parent.Nodes.Count = 1 Then
                            ' It is the last dream in the year, delete it
                            Directory.Delete(CType(trvMain.SelectedNode.Parent.Parent.Tag, Lucidity.Tags.YearFolder).Path)
                            trvMain.SelectedNode.Parent.Parent.Remove()
                        Else
                            trvMain.SelectedNode.Parent.Remove()
                        End If
                    Else
                        trvMain.SelectedNode.Remove()
                    End If
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFolder Then
                If MessageBox.Show("Are you sure you wish to delete '" & trvMain.SelectedNode.Text & "'?" & vbNewLine & "And any files in it?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Directory.Delete(CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFolder).Path, True)
                    trvMain.SelectedNode.Remove()
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Categories.Tags.CategoryFile Then
                If MessageBox.Show("Are you sure you wish to delete '" & trvMain.SelectedNode.Text & "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(CType(trvMain.SelectedNode.Tag, Categories.Tags.CategoryFile).Path)
                    trvMain.SelectedNode.Remove()
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFile Then
                If MessageBox.Show("Are you sure you wish to delete '" & trvMain.SelectedNode.Text & "'", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.LucidItemFile).Path)
                    trvMain.SelectedNode.Remove()
                End If
            ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.REMCycleFile Then
                If MessageBox.Show("Are you sure you wish to delete '" & trvMain.SelectedNode.Text & "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(CType(trvMain.SelectedNode.Tag, Lucidity.Tags.REMCycleFile).Path)
                    trvMain.SelectedNode.Remove()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Delete()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub trvMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles trvMain.KeyDown
        If e.KeyCode = Keys.Delete Then
            Delete()
        End If
    End Sub

    Private Sub trvMain_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterExpand
        If TypeOf (e.Node.Tag) Is Dreams.Tags.MonthFolder Then
            e.Node.ImageIndex = 1
        ElseIf TypeOf (e.Node.Tag) Is Dreams.Tags.YearFolder Then
            e.Node.ImageIndex = 1
        ElseIf TypeOf (e.Node.Tag) Is Dreams.Tags.DreamsFolder Then
            e.Node.ImageIndex = 1
        ElseIf TypeOf (e.Node.Tag) Is Categories.Tags.CategoryFolder Then
            If lstImgTrv.Images.IndexOfKey("Folder." & e.Node.Text) <> -1 Then
                e.Node.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." & e.Node.Text)
            Else
                e.Node.ImageIndex = 1
            End If
        ElseIf TypeOf (e.Node.Tag) Is Categories.Tags.CategoriesFolder Then
            e.Node.ImageIndex = 1
        End If
    End Sub

    Private Sub trvMain_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterCollapse
        If TypeOf (e.Node.Tag) Is Dreams.Tags.MonthFolder Then
            e.Node.ImageIndex = 0
        ElseIf TypeOf (e.Node.Tag) Is Dreams.Tags.YearFolder Then
            e.Node.ImageIndex = 0
        ElseIf TypeOf (e.Node.Tag) Is Dreams.Tags.DreamsFolder Then
            e.Node.ImageIndex = 0
        ElseIf TypeOf (e.Node.Tag) Is Categories.Tags.CategoryFolder Then
            If lstImgTrv.Images.IndexOfKey("Folder." & e.Node.Text) <> -1 Then
                e.Node.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." & e.Node.Text)
            Else
                e.Node.ImageIndex = 0
            End If
        ElseIf TypeOf (e.Node.Tag) Is Categories.Tags.CategoriesFolder Then
            e.Node.ImageIndex = 0
        End If
    End Sub

    Private Sub toolNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolNew.Click

    End Sub

    Private Sub trvMain_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trvMain.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub trvMain_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trvMain.DragDrop
        Dim myItem As ListViewItem
        Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
        Dim i As Integer = 0

        For Each myItem In myItems
            ' Add the item to the target list.
            CreateNewCategory(trvMain.SelectedNode.Text.Substring(0, trvMain.SelectedNode.Text.Length - 1), myItems(i).Text.Substring(0, 1).ToUpper + myItems(i).Text.Substring(1))

        Next
    End Sub

    Private Sub trvMain_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles trvMain.DragOver
        Dim tree As TreeView = CType(sender, TreeView)

        e.Effect = DragDropEffects.None

        'If Not e.Data.GetData(GetType(TreeNode)) Is Nothing Then
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            Dim pt As New Point(e.X, e.Y)
            pt = tree.PointToClient(pt)
            Dim node As TreeNode = tree.GetNodeAt(pt)
            If Not node Is Nothing Then
                If TypeOf (node.Tag) Is Categories.Tags.CategoryFolder Then
                    e.Effect = DragDropEffects.Link
                    node.EnsureVisible()
                    m_boolNavigating = True
                    tree.SelectedNode = node
                    m_boolNavigating = False
                End If
                If node.Text = "Categories" Then
                    'e.Effect = DragDropEffects.Link
                    'tree.SelectedNode = node
                    node.Expand()
                End If
            End If
        End If
    End Sub

    Private Sub CategoryCreated(ByVal Category As String, ByVal Name As String, ByVal FileName As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Category Then
                trvMain.SelectedNode = trvNode
            End If
        Next

        Dim trvCategory As New TreeNode(Name)
        Dim objCategoryTag As New Categories.Tags.CategoryFile(FileName, Category)
        objCategoryTag.Category = Category
        trvCategory.Tag = objCategoryTag
        trvCategory.ImageIndex = 2
        trvCategory.SelectedImageIndex = 2
        If lstImgTrv.Images.IndexOfKey("File." & Category) <> -1 Then
            trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & Category)
            trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & Category)
        End If
        FindNode(trvMain.Nodes(1), Category).Nodes.Add(trvCategory)
        m_arrCategories.Add(trvCategory.Text)

        ' Load each dream
        Dim xmlCategory As New Xml.XmlDocument
        xmlCategory.Load(FileName)
        For Each xmlDreamNode As XmlNode In xmlCategory.DocumentElement.SelectNodes("//Dream")
            Dim trvDream As New TreeNode(xmlDreamNode.Attributes("Date").InnerText + " " + xmlDreamNode.Attributes("Title").InnerText)
            Dim objDreamTag As New Dreams.Tags.DreamFile(m_strPath + "Dreams\" + xmlDreamNode.Attributes("Date").InnerText.Replace("-", "/") + " " + xmlDreamNode.Attributes("Title").InnerText + ".ld3")
            trvDream.Tag = objDreamTag
            trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
            trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
            trvCategory.Nodes.Add(trvDream)
            ' Add the loading node
            Dim trvLoading As New TreeNode("Loading Categories...")
            trvDream.Nodes.Add(trvLoading)
        Next

        'ReloadDreamNodes(trvMain.SelectedNode)
    End Sub

    Private Sub PlayingStopped()
        If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
            toolPlay.Image = My.Resources.Function_Play
            toolPlay.Text = "&Play"
        End If
    End Sub

    Private Sub CategorySelected(ByVal Category As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Category Then
                trvMain.SelectedNode = trvNode
            End If
        Next
    End Sub

    Private Sub DreamSelected(ByVal Dream As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Dream Then
                trvMain.SelectedNode = trvNode
            End If
        Next
    End Sub

    Private Sub ExerciseDreamSelected(ByVal Dream As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Dream Then
                trvMain.SelectedNode = trvNode
            End If
        Next
    End Sub

    Private Sub SelectDream(ByVal DreamDate As String, ByVal Dream As String)
        'For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
        '  If trvNode.Text = DreamDate & " " & Dream Then
        '    trvMain.SelectedNode = trvNode
        '  End If
        'Next
        'Return

        Dim arrMonth() As String = DreamDate.Split("-")
        If FindNode(trvMain.Nodes(0), arrMonth(0)) IsNot Nothing Then
            If FindNode(FindNode(trvMain.Nodes(0), arrMonth(0)), arrMonth(1)) IsNot Nothing Then
                If FindNode(FindNode(FindNode(trvMain.Nodes(0), arrMonth(0)), arrMonth(1)), arrMonth(2) & " " & Dream) IsNot Nothing Then
                    trvMain.SelectedNode = FindNode(FindNode(FindNode(trvMain.Nodes(0), arrMonth(0)), arrMonth(1)), arrMonth(2) & " " & Dream)
                End If
            End If
        End If
    End Sub

    Private Sub MonthSelected(ByVal Month As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Month Then
                trvMain.SelectedNode = trvNode
            End If
        Next
    End Sub

    Private Sub ExerciseMonthSelected(ByVal Month As String)
        For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
            If trvNode.Text = Month Then
                trvMain.SelectedNode = trvNode
            End If
        Next
    End Sub

    Private Sub SearchMonthSelected(ByVal Month As String)
        Dim arrMonth() As String = Month.Split("-")
        If FindNode(trvMain.Nodes(0), arrMonth(0)) IsNot Nothing Then
            If FindNode(FindNode(trvMain.Nodes(0), arrMonth(0)), arrMonth(1)) IsNot Nothing Then
                trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes(0), arrMonth(0)), arrMonth(1))
            End If
        End If
    End Sub

    Private Sub ExercisesearchMonthSelected(ByVal Month As String)
        Dim arrMonth() As String = Month.Split("-")
        If FindNode(trvMain.Nodes(2).Nodes(5), arrMonth(0)) IsNot Nothing Then
            If FindNode(FindNode(trvMain.Nodes(2).Nodes(5), arrMonth(0)), arrMonth(1)) IsNot Nothing Then
                trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes(2).Nodes(5), arrMonth(0)), arrMonth(1))
            End If
        End If
    End Sub

    Private Sub SearchCategoryFileSelected(ByVal Category As String, ByVal Item As String)
        If FindNode(trvMain.Nodes(1), Category) IsNot Nothing Then
            If FindNode(FindNode(trvMain.Nodes(1), Category), Item) IsNot Nothing Then
                trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes(1), Category), Item)
            End If
        End If
    End Sub

    Private Sub SearchCategoryFileCreated(ByVal Category As String, ByVal Item As String)
        CreateNewCategory(Category, Item)
    End Sub

    Private Sub DreamSignCategoryFileCreated(ByVal Category As String, ByVal Item As String)
        CreateNewCategory(Category, Item)
        trvMain.SelectedNode = trvMain.Nodes(0)
        trvMain.SelectedNode = Nothing
        pnlContainer.Controls.Clear()
        m_objDreamSignListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objDreamSignListControl)
    End Sub

    Private Sub LucidItemSelected(ByVal Category As String, ByVal FileName As String)
        If FindNode(trvMain.Nodes(2), Category) IsNot Nothing Then
            If FindNode(FindNode(trvMain.Nodes(2), Category), FileName) IsNot Nothing Then
                trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes(2), Category), FileName)
            End If
        End If
    End Sub

    Private Sub LucidFolderSelected(ByVal Category As String)
        If FindNode(trvMain.Nodes(2), Category) IsNot Nothing Then
            trvMain.SelectedNode = FindNode(trvMain.Nodes(2), Category)
        End If
    End Sub

    Private Sub toolBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolBack.Click
        m_boolNavigating = True
        m_arrForwardHistory.Add(trvMain.SelectedNode)
        toolForward.Enabled = True
        trvMain.SelectedNode = m_arrBackHistory.Item(m_arrBackHistory.Count - 2)
        m_arrBackHistory.Remove(m_arrBackHistory.Item(m_arrBackHistory.Count - 2))
        If m_arrBackHistory.Count <= 1 Then
            toolBack.Enabled = False
            m_arrBackHistory.Clear()
            m_arrBackHistory.Add(trvMain.SelectedNode)
        End If
        m_boolNavigating = False
    End Sub

    Private Sub toolForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolForward.Click
        trvMain.SelectedNode = m_arrForwardHistory.Item(m_arrForwardHistory.Count - 1)
        m_arrForwardHistory.Remove(m_arrForwardHistory.Item(m_arrForwardHistory.Count - 1))
        If m_arrForwardHistory.Count = 0 Then
            toolForward.Enabled = False
        End If
    End Sub

    Private Sub toolUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolUpdate.Click
        Save()
        '  UpdateDatabase()
    End Sub

    Private Sub UpdateDatabase()
        pnlContainer.Controls.Clear()
        m_objDreamViewControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objUpdateControl)
        m_objUpdateControl.UpdateDatabase()
    End Sub

    Private Sub toolCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCharacters.Click, toolThemes.Click, toolObjects.Click, toolLocations.Click, toolActions.Click, toolEmotions.Click
        If FindNode(trvMain.Nodes(1), CType(sender, ToolStripButton).Tag) IsNot Nothing Then
            trvMain.SelectedNode = FindNode(trvMain.Nodes(1), CType(sender, ToolStripButton).Tag)
        End If
    End Sub

    Private Sub toolPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolPlay.Click
        PlayLucid()
    End Sub

    Private Sub PlayLucid()

        If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then

            If m_objDreamViewControl.Playing Then
                m_objDreamViewControl.StopPlaying()
                toolPlay.Image = My.Resources.Function_Play
                toolPlay.Text = "&Play"
            Else
                m_objDreamViewControl.Play()
                toolPlay.Image = My.Resources.Function_Stop
                toolPlay.Text = "&Stop"
            End If

        ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.REMCycleFile Then

            If m_objREMCyclesControl.tmrWatch.Enabled Then
                m_objREMCyclesControl.StopRunning()
                toolPlay.Image = My.Resources.Function_Play
                toolPlay.Text = "&Play"
            Else
                ' Play
                Dim formFullScreen As New FullScreenForm
                formFullScreen.pnlContainer.Controls.Add(m_objREMCyclesControl)
                m_objREMCyclesControl.Play()
                formFullScreen.Location = New Point(0, 0)
                formFullScreen.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                formFullScreen.ShowDialog()
                pnlContainer.Controls.Add(m_objREMCyclesControl)
                m_dtLastREMPlayed = DateTime.Now
                toolPlay.Image = My.Resources.Function_Stop
                toolPlay.Text = "&Stop"
            End If

        ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFile Then

            If m_objLucidItemControl.Playing() Then
                m_objLucidItemControl.StopRunning()
                toolPlay.Image = My.Resources.Function_Play
                toolPlay.Text = "&Play"
            Else
                If m_objLucidItemControl.Play() Then
                    toolPlay.Image = My.Resources.Function_Stop
                    toolPlay.Text = "&Stop"
                End If
            End If

        ElseIf TypeOf (trvMain.SelectedNode.Tag) Is Lucidity.Tags.LucidItemFolder Then

            If m_objLucidFolderViewControl.Playing Then
                m_objLucidFolderViewControl.StopRunning()
                toolPlay.Image = My.Resources.Function_Play
                toolPlay.Text = "&Play"
            Else
                m_objLucidFolderViewControl.Play(objMerlin)
                toolPlay.Image = My.Resources.Function_Stop
                toolPlay.Text = "&Stop"
            End If

        End If
    End Sub

    Private Sub trvMain_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvMain.BeforeExpand
        ExpandTree(e)
    End Sub

    Private Sub ExpandTree(ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)
        If TypeOf (e.Node.Tag) Is Dreams.Tags.DreamFile Then
            ReloadDreamNodes(e.Node)
        ElseIf TypeOf (e.Node.Tag) Is Categories.Tags.CategoryFile Then
            ReloadCatgeoryNodes(e.Node)
        End If
    End Sub

    Private Sub ReloadDreamNodes(ByVal trvNode As TreeNode)
        Dim boolExpanded As Boolean
        boolExpanded = trvNode.IsExpanded
        trvNode.Nodes.Clear()
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(CType(trvNode.Tag, Dreams.Tags.DreamFile).Path)
        For Each strCategory As String In m_strCategories.Split(",")
            For Each XmlNode As XmlNode In xmlDoc.DocumentElement.SelectNodes("Categories/" + strCategory)
                Dim trvCategory As New TreeNode(XmlNode.InnerText)
                trvCategory.Tag = New Categories.Tags.CategoryFile(m_strPath & "Categories\" & strCategory & "\" & XmlNode.InnerText & ".ld3", strCategory)
                trvCategory.ImageIndex = 2
                trvCategory.SelectedImageIndex = 2
                If lstImgTrv.Images.IndexOfKey("File." & strCategory) <> -1 Then
                    trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                    trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & strCategory)
                End If
                trvNode.Nodes.Add(trvCategory)

                Dim trvLoading As New TreeNode("Loading Categories...")
                trvCategory.Nodes.Add(trvLoading)
            Next
        Next
        If boolExpanded Then trvNode.Expand()
    End Sub

    Private Sub ReloadCatgeoryNodes(ByVal trvNode As TreeNode)
        Try
            Dim boolExpanded As Boolean
            boolExpanded = trvNode.IsExpanded
            trvNode.Nodes.Clear()

            ' Make sure it is not a sub category
            Dim strFileName As String = CType(trvNode.Tag, Categories.Tags.CategoryFile).Path
            If Not File.Exists(strFileName) Then
                Dim strSubName As String = strFileName.Replace(m_strPath + "Categories\" + CType(trvNode.Tag, Categories.Tags.CategoryFile).Category + "\", "").Replace(".ld3", "")
                For Each strSubFile In Directory.GetFiles(m_strPath + "Categories\" + CType(trvNode.Tag, Categories.Tags.CategoryFile).Category, "*.ld3")
                    Dim boolFoundSub As Boolean = False
                    Dim xmlDocSibling As New XmlDocument
                    xmlDocSibling.Load(strSubFile)
                    For Each xmlWord As XmlNode In xmlDocSibling.DocumentElement.SelectNodes("Names/Name")
                        If strSubName = xmlWord.InnerText Then
                            strFileName = strSubFile
                            boolFoundSub = True
                            Exit For
                        End If
                    Next
                    If boolFoundSub Then Exit For
                Next
            End If

            Dim xmlCategory As New Xml.XmlDocument
            xmlCategory.Load(strFileName)
            For Each xmlDreamNode As XmlNode In xmlCategory.DocumentElement.SelectNodes("//Dream")
                If Format(Convert.ToDateTime(xmlDreamNode.Attributes("Date").InnerText), "dd") + " " + xmlDreamNode.Attributes("Title").InnerText <> trvNode.Parent.Text Then
                    Dim trvDream As New TreeNode(xmlDreamNode.Attributes("Date").InnerText + " " + xmlDreamNode.Attributes("Title").InnerText)
                    Dim objDreamTag As New Dreams.Tags.DreamFile(m_strPath + "Dreams\" + xmlDreamNode.Attributes("Date").InnerText.Replace("-", "/") + " " + xmlDreamNode.Attributes("Title").InnerText + ".ld3")
                    trvDream.Tag = objDreamTag
                    trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                    trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream")
                    trvNode.Nodes.Add(trvDream)
                    ' Add the loading node
                    Dim trvLoading As New TreeNode("Loading Categories...")
                    trvDream.Nodes.Add(trvLoading)
                End If
            Next
            If boolExpanded Then trvNode.Expand()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub toolLucidity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolREMCycles.Click, toolReadings.Click, toolSubliminals.Click, toolChecks.Click, toolRecordings.Click, toolLucidityExercises.Click
        SelectLucidItem(CType(sender, ToolStripButton).Tag)
    End Sub

    Private Sub SelectLucidItem(ByVal Type As String)
        If FindNode(trvMain.Nodes(2), Type) IsNot Nothing Then
            trvMain.SelectedNode = FindNode(trvMain.Nodes(2), Type)
        End If
    End Sub

    Private Sub trvMain_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvMain.BeforeSelect
        If CancelForSave(e.Node, False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub trvMain_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles trvMain.ItemDrag
        Try
            Dim myItem As TreeNode
            Dim myItems(sender.nodes.Count - 1) As TreeNode
            Dim i As Integer = 0

            ' Loop though the SelectedNodes collection for the source.
            For Each myItem In sender.nodes
                ' Add the TreeNode to the array of ListViewItems.
                myItems(i) = myItem
                i = i + 1
            Next
            ' Create a DataObject containg the array of ListViewItems.
            sender.DoDragDrop(New  _
            DataObject("System.Windows.Forms.TreeNode()", myItems), DragDropEffects.Link)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Main.ItemDrag()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        If m_formAbout Is Nothing Then
            m_formAbout = New AboutForm
        End If
        m_formAbout.ShowDialog()
    End Sub

    Private Class UpdateClass

        Public Version As String
        Public URL As String
        Public Complete As Boolean = False

        Public Sub CheckForUpdate()
            Try

                WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials
                Dim objRequest As HttpWebRequest = CType(WebRequest.Create("http://www.lucid-code.com/LightenedDream/updates/LatestVersion.html"), HttpWebRequest)
                objRequest.Method = "GET"
                Dim objWebResponse As HttpWebResponse = CType(objRequest.GetResponse(), HttpWebResponse)
                Dim objResponseStream As StreamReader = New StreamReader(objWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding(1252))
                Dim strResponse = objResponseStream.ReadToEnd()
                objWebResponse.Close()
                objResponseStream.Close()

                If strResponse.StartsWith("Version ") Then
                    Dim arrLines() As String = strResponse.Split(vbNewLine)
                    Version = arrLines(0).Replace("Version ", "")
                    URL = arrLines(1)
                End If

                If UpdateAvailable(Version) Then
                    If MessageBox.Show("A new version (" & Version & ") is available. Would you like to download it now?", "Lightened Dream", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start(URL)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "LightenedDream.Update.Launch()", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If

            Catch ex As Exception
            End Try

            Complete = True
        End Sub

        Private Function UpdateAvailable(ByVal NewVersion As String) As Boolean
            Try

                Dim OldVersion As String = Application.ProductVersion
                Dim arrOldVersion() As String = Split(Application.ProductVersion, ".") ' 2.9.9.0
                Dim arrNewVersion() As String = Split(NewVersion, ".") '    ' 2.9.9.1

                If Val(arrNewVersion(0)) > Val(arrOldVersion(0)) Then
                    Return True
                Else
                    If Val(arrNewVersion(1)) > Val(arrOldVersion(1)) Then
                        Return True
                    Else
                        If Val(arrNewVersion(2)) > Val(arrOldVersion(2)) Then
                            Return True
                        Else
                            If Val(arrNewVersion(3)) > Val(arrOldVersion(3)) Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

    End Class

    Private Sub mnuHelpSupport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpSupport.Click
        Dim formSupport As New SupportForm
        formSupport.ShowDialog()
    End Sub

    Private Sub mnuTrvDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvDelete.Click
        Delete()
    End Sub

    Private Sub mnuToolNewLucidItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolNewSubliminal.Click, mnuToolNewRecording.Click, mnuToolNewReading.Click, mnuToolNewCheck.Click
        CreateNewLucidityItem(CType(sender, ToolStripMenuItem).Tag)
    End Sub

    Private Sub CreateNewLucidityItem(ByVal Type As String)
        Dim strFilename As String = m_objLucidItemControl.CreateNew(Type)

        ' Update Tree   
        Dim trvLucidItem As New TreeNode(New FileInfo(strFilename).Name.Replace(".ld3", ""))
        Dim objDreamTag As New Lucidity.Tags.LucidItemFile(strFilename, New FileInfo(strFilename).Name.Replace(".ld3", ""))
        trvLucidItem.Tag = objDreamTag
        trvLucidItem.ImageIndex = 2
        trvLucidItem.SelectedImageIndex = 2
        If lstImgTrv.Images.IndexOfKey("File." & Type & "s") <> -1 Then
            trvLucidItem.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & Type & "s")
            trvLucidItem.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & Type & "s")
        End If

        ' Add Item
        If FindNode(trvMain.Nodes(2), Type + "s") IsNot Nothing Then
            FindNode(trvMain.Nodes(2), Type + "s").Nodes.Add(trvLucidItem)
        End If

        ' Select Item
        trvMain.SelectedNode = trvLucidItem
    End Sub

    Private Sub mnuToolNewREMCycle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolNewREMCycle.Click
        CreateNewREMCycle()
    End Sub

    Private Sub CreateNewREMCycle()
        Dim strFilename As String = m_objREMCyclesControl.CreateNew()

        ' Update Tree   
        Dim trvLucidItem As New TreeNode(New FileInfo(strFilename).Name.Replace(".ld3", ""))
        Dim objDreamTag As New Lucidity.Tags.REMCycleFile(strFilename)
        trvLucidItem.Tag = objDreamTag
        trvLucidItem.ImageIndex = 2
        trvLucidItem.SelectedImageIndex = 2
        If lstImgTrv.Images.IndexOfKey("File." & "REM Cycles") <> -1 Then
            trvLucidItem.ImageIndex = lstImgTrv.Images.IndexOfKey("File." & "REM Cycles")
            trvLucidItem.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." & "REM Cycles")
        End If

        ' Add Item
        If FindNode(trvMain.Nodes(2), "REM Cycle" + "s") IsNot Nothing Then
            FindNode(trvMain.Nodes(2), "REM Cycle" + "s").Nodes.Add(trvLucidItem)
        End If

        ' Select Item
        trvMain.SelectedNode = trvLucidItem
    End Sub

    Private Sub mnuFileExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExport.Click
        Export()
    End Sub

    Private Sub Export()
        Dim formExport As New ExportForm
        formExport.trvMain.Nodes.Clear()
        For Each trvNode As TreeNode In trvMain.Nodes
            formExport.trvMain.Nodes.Add(trvNode.Clone())
        Next
        formExport.chkSelectAll.Checked = True
        formExport.ShowDialog()
    End Sub

    Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCategoriesCharacters.Click, mnuCategoriesThemes.Click, mnuCategoriesObjects.Click, mnuCategoriesLocations.Click, mnuCategoriesEmotions.Click
        If FindNode(trvMain.Nodes(1), CType(sender, ToolStripMenuItem).Tag) IsNot Nothing Then
            trvMain.SelectedNode = FindNode(trvMain.Nodes(1), CType(sender, ToolStripMenuItem).Tag)
        End If
    End Sub

    Private m_intIco As Integer = 0
    Private m_arrIcons As List(Of Icon) = New List(Of Icon)

    Private Sub tmrProcessing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrProcessing.Tick
        Try
            If m_arrIcons.Count = 0 Then
                For Each objImage As Image In lstImgIco.Images
                    m_arrIcons.Add(Icon.FromHandle(CType(lstImgIco.Images(m_intIco), Bitmap).GetHicon))
                    m_intIco += 1
                Next
                m_intIco = 0
            End If

            Me.Icon = m_arrIcons(m_intIco)
            m_intIco += 1
            If m_intIco >= lstImgIco.Images.Count Then
                m_intIco = 0
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Close()
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        Save()
    End Sub

    Private Sub mnuFileDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileDelete.Click
        Delete()
    End Sub

    Private Sub mnuLucidityPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PlayLucid()
    End Sub

    Private Sub mnuToolsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateDatabase()
    End Sub

    Private Sub REMCycleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMCycleToolStripMenuItem1.Click, ToolStripMenuItem15.Click
        CreateNewREMCycle()
    End Sub

    Private Sub CheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckToolStripMenuItem.Click, SubliminalToolStripMenuItem.Click, RecordingToolStripMenuItem1.Click, ReadingToolStripMenuItem.Click, ToolStripMenuItem19.Click, ToolStripMenuItem18.Click, ToolStripMenuItem17.Click, ToolStripMenuItem16.Click
        CreateNewLucidityItem(CType(sender, ToolStripMenuItem).Tag)
    End Sub

    Private Sub mnuToolsPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsPlay.Click
        PlayLucid()
    End Sub

    Private Sub toolVariables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("This feature is still dreaming itself into existence.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub mnuLucidity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLucidityREMCycles.Click, mnuLuciditySubliminals.Click, mnuLucidityRecordings.Click, mnuLucidityReadings.Click, mnuLucidityChecks.Click
        If FindNode(trvMain.Nodes(2), CType(sender, ToolStripMenuItem).Tag) IsNot Nothing Then
            trvMain.SelectedNode = FindNode(trvMain.Nodes(2), CType(sender, ToolStripMenuItem).Tag)
        End If
    End Sub

    Private Sub mnuTrvSendToDesktop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvSendToDesktop.Click
        Try
            File.Copy(trvMain.SelectedNode.Tag.Path, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & New FileInfo(trvMain.SelectedNode.Tag.Path).Name)

            Shell("explorer /select, """ & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & New FileInfo(trvMain.SelectedNode.Tag.Path).Name & """", AppWinStyle.NormalFocus)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.SendTo.Desktop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuTrvPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvPlay.Click
        PlayLucid()
    End Sub

    Private Sub mnuTrv_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuTrv.Opening
        If trvMain.SelectedNode Is Nothing Then
            mnuTrvPlay.Enabled = False
            mnuTrvDelete.Enabled = False
            mnuTrvSendTo.Enabled = False
            mnuTrvExplorer.Enabled = False
        Else
            mnuTrvPlay.Enabled = mnuToolsPlay.Enabled
            mnuTrvDelete.Enabled = toolDelete.Enabled
            mnuTrvSendTo.Enabled = toolDelete.Enabled
            mnuTrvExplorer.Enabled = True
        End If
    End Sub

    Private Sub trvMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvMain.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not trvMain.GetNodeAt(e.X, e.Y) Is Nothing Then
                trvMain.SelectedNode = trvMain.GetNodeAt(e.X, e.Y)
            End If
        End If
    End Sub

    Private Sub toolSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSearch.Click
        SelectSearch()
    End Sub

    Private Sub SelectSearch()
        trvMain.SelectedNode = Nothing
        pnlContainer.Controls.Clear()
        m_objSearchControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objSearchControl)
        m_objSearchControl.Activate()
    End Sub

    Private Sub mnuTrvExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvExplorer.Click

        Shell("explorer /select, """ & New FileInfo(trvMain.SelectedNode.Tag.Path).DirectoryName & "\" & New FileInfo(trvMain.SelectedNode.Tag.Path).Name & """", AppWinStyle.NormalFocus)

    End Sub

    Private Sub mnuFileNewCategoryFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateCustomCategory()
    End Sub

    Private Sub CreateCustomCategory()
        Dim strName As String = "New Category"
        Dim strDirectory As String = m_strPath + "\Categories\" + strName

        ' Create folder
        Dim intPos As Integer = 2
        Do
            If (Directory.Exists(strDirectory)) Then
                strName = "New Catgeory " + intPos.ToString
                strDirectory = m_strPath + "\Categories\" + strName
                intPos += 1
            Else
                Exit Do
            End If
        Loop

        Directory.CreateDirectory(strDirectory)

        ' Add to tree
        Dim trvItem As New TreeNode(strName)
        trvItem.Tag = New Categories.Tags.CategoryFolder(strDirectory)
        trvMain.Nodes(1).Nodes.Add(trvItem)

        trvMain.SelectedNode = trvItem
    End Sub

    Private Sub mnuNewCustomCatgeory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewCustomCatgeory.Click
        CreateCustomCategory()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CancelForSave(trvMain.SelectedNode, True) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuTrvCopyToRecordings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuFileNewExercise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNewExercise.Click
        CreateNewExercise(False)
    End Sub

    Private Sub ExerciseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExerciseToolStripMenuItem.Click
        CreateNewExercise(False)
    End Sub

    Private Sub mnuTrvNewExercise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvNewExercise.Click
        CreateNewExercise(False)
    End Sub

    Private Sub ExerciseRndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExerciseRndToolStripMenuItem.Click
        CreateNewExercise(True)
    End Sub

    Private Sub RandomExerciseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomExerciseToolStripMenuItem.Click
        CreateNewExercise(True)
    End Sub

    Private Sub RandomExerciseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomExerciseToolStripMenuItem1.Click
        CreateNewExercise(True)
    End Sub

    Private Sub mnuToolsWILD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsWILD.Click
        Dim formWILD As New Lucidity.WILDForm
        formWILD.ShowDialog()
    End Sub

    Private Sub mnuToolsFIELD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsFIELD.Click
        Dim formFIELD As New Lucidity.FIELDForm
        formFIELD.ShowDialog()
    End Sub

    Private Sub mnuToolsDreamSigns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsDreamSigns.Click
        trvMain.SelectedNode = trvMain.Nodes(0)
        trvMain.SelectedNode = Nothing
        pnlContainer.Controls.Clear()
        m_objDreamSignListControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objDreamSignListControl)
        m_objDreamSignListControl.StartSearch()
    End Sub

    Private Sub mnuToolsCompareDreams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsCompareDreams.Click
        trvMain.SelectedNode = trvMain.Nodes(0)
        trvMain.SelectedNode = Nothing
        pnlContainer.Controls.Clear()
        m_objCompareDreamsControl.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(m_objCompareDreamsControl)
        m_objCompareDreamsControl.StartSearch()
    End Sub

    Private Sub mnuHelpUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpUpdate.Click
        Dim formRegister As New RegisterForm
        formRegister.ShowDialog()
    End Sub

    Private Sub mnuQuickStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuickStart.Click
        Shell("explorer """ & Application.StartupPath & "\QuickStart.pdf" & """", AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuTrvSendToLD4All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrvSendToLD4All.Click
        Dim xmlDoc As New XmlDocument
        Dim strXml As String = ""

        ' Make sure that the LD4All file exists
        If (Not File.Exists(m_strPath & "LD4All.ld3")) Then
            ' Create the LD4All file



            strXml = "<LightenedDream>"
            strXml += "</LightenedDream>"
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(m_strPath & "LD4All.ld3")
        End If


    End Sub

    Private Sub tmrSearching_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Private Delegate Sub AddSearchItemDelegate()
    'Private Sub AddSearchItem()
    '  Try
    '    If InvokeRequired Then
    '      Dim d As New AddSearchItemDelegate(AddressOf AddSearchItem)
    '      Invoke(d)
    '    Else
    '      m_objDreams.Points.AddY(Int(Rnd() * 1000))
    '      m_objDreams.Points.Remove(m_objDreams.Points(0))
    '    End If
    '  Catch ex As Exception
    '  End Try
    'End Sub

    'Private m_objProcessingThread As Threading.Thread

    'Private Sub DoProcessingWork()
    '  Do
    '    AddSearchItem()
    '    Threading.Thread.Sleep(128)
    '  Loop
    'End Sub

    Private Sub ShowSearching()
        DoubleBuffered = True

        graph.ChartAreas(0).AxisX.CustomLabels.Clear()
        graph.Series.Clear()
        graph.ResetAutoValues()
        graph.Annotations.Clear()

        m_objDreams = graph.Series.Add("Dreams")
        m_objDreams.ChartType = SeriesChartType.Column
        m_objDreams.Color = Color.FromArgb(200, 65, 140, 240)
        m_objDreams.BorderWidth = 1

        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(0)
        m_objDreams.Points.AddY(1000)

        m_arrRandomWords = New List(Of String)

        tmrSaving.Interval = 128
        pnlProcessing.Visible = True
        tmrSaving.Enabled = True
        m_boolDoneProcessing = False
        m_dtStartTime = Now


        'm_objProcessingThread = New Threading.Thread(AddressOf DoProcessingWork)
        'm_objProcessingThread.Start()
    End Sub

    Private m_dtStartTime As DateTime

    Private m_boolDoneProcessing = False

    Private Sub HideSearching()

        'Make sure that 500 milliseconds have passed
        Do
            Dim dtSpeed As TimeSpan = DateTime.Now.Subtract(m_dtStartTime)
            If dtSpeed.TotalMilliseconds > 500 Then
                Exit Do
            End If

            Threading.Thread.Sleep(64)
            Application.DoEvents()

        Loop


        pnlProcessing.Visible = False
        tmrSaving.Enabled = False
        m_boolDoneProcessing = True
    End Sub

    Private Sub tmrSaving_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSaving.Tick
        'tmrSaving.Enabled = False
        If m_boolDoneProcessing Then Exit Sub

        Dim dtSpeed As TimeSpan = DateTime.Now.Subtract(m_dtStartTime)
        If dtSpeed.TotalSeconds > 6 Then
            tmrSaving.Interval = 512
        End If

        m_objDreams.Points.AddY(Int(Rnd() * 1000))

        If Not m_objDreams.Points(0).Tag Is Nothing Then
            If m_objDreams.Points(0).Tag = "X" Then
                For Each objDreamAnnotation In graph.Annotations
                    If objDreamAnnotation.AnchorDataPoint Is m_objDreams.Points(0) Then
                        graph.Annotations.Remove(objDreamAnnotation)
                        Exit For
                    End If
                Next
            End If
        End If

        m_objDreams.Points.Remove(m_objDreams.Points(0))
        Application.DoEvents()

        If m_arrRandomWords.Count > 0 Then
            Dim objDreamAnnotation As New Charting.CalloutAnnotation
            objDreamAnnotation.AllowMoving = True
            objDreamAnnotation.AllowResizing = True
            objDreamAnnotation.AllowSelecting = True
            objDreamAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
            objDreamAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            objDreamAnnotation.ForeColor = System.Drawing.Color.SteelBlue
            objDreamAnnotation.LineColor = System.Drawing.Color.LightSteelBlue
            objDreamAnnotation.Name = Guid.NewGuid.ToString
            objDreamAnnotation.ShadowColor = System.Drawing.Color.SteelBlue
            objDreamAnnotation.ShadowOffset = 1
            objDreamAnnotation.Text = m_arrRandomWords.Item(0)
            objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter

            Dim objDataPoint As DataPoint = m_objDreams.Points(m_objDreams.Points.Count - 1)
            objDreamAnnotation.AnchorDataPoint = objDataPoint
            objDataPoint.Tag = "X"

            Me.graph.Annotations.Add(objDreamAnnotation)

            m_arrRandomWords.Remove(m_arrRandomWords.Item(0))

        End If
    End Sub

    Private m_arrRandomWords As List(Of String)

    Private Sub RandomWord(ByVal Word As String)
        m_arrRandomWords.Add(Word)
    End Sub

    Private Sub mnuToolsWhyLD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsWhyLD.Click
        Dim formWhyLD As New Lucidity.WhyLDForm
        formWhyLD.ShowDialog()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = (Keys.Control Or Keys.Back) Then
            SendKeys.SendWait("^+{LEFT}{BACKSPACE}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub MainForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Try
        '  If e.Control And e.KeyCode = Keys.Back Then
        '    If TypeOf (sender) Is TextBox Then
        '      e.SuppressKeyPress = True
        '      Dim selStart As Integer = CType(sender, TextBox).SelectionStart
        '      While selStart > 0 AndAlso CType(sender, TextBox).Text.Substring(selStart - 1, 1) = " "
        '        selStart -= 1
        '      End While
        '      Dim prevSpacePos As Integer = -1
        '      If selStart <> 0 Then
        '        prevSpacePos = CType(sender, TextBox).Text.LastIndexOf(" "c, selStart - 1)
        '      End If
        '      CType(sender, TextBox).[Select](prevSpacePos + 1, CType(sender, TextBox).SelectionStart - prevSpacePos - 1)
        '      CType(sender, TextBox).SelectedText = ""
        '    Else
        '      e.SuppressKeyPress = True
        '      SendKeys.SendWait("^+{LEFT}{BACKSPACE}")
        '      e.Handled = True
        '    End If
        '  End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub MainForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub MainForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

    End Sub
End Class