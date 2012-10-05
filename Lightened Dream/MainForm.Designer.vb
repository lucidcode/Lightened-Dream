<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0")
    Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dreams", New System.Windows.Forms.TreeNode() {TreeNode1})
    Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Characters")
    Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Locations")
    Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Objects")
    Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Actions")
    Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Themes")
    Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Categories", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
    Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REM Cycles")
    Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reality Checks")
    Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dream Inductions")
    Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lucidity", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
    Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.toolNew = New System.Windows.Forms.ToolStripDropDownButton
    Me.mnuToolNewDream = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuNewCustomCatgeory = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewCharacter = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewLocation = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewObject = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewAction = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewTheme = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewEmotion = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuToolNewREMCycle = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewCheck = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewSubliminal = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewRecording = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolNewReading = New System.Windows.Forms.ToolStripMenuItem
    Me.ExerciseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ExerciseRndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.toolDelete = New System.Windows.Forms.ToolStripButton
    Me.toolSave = New System.Windows.Forms.ToolStripButton
    Me.toolUpdate = New System.Windows.Forms.ToolStripButton
    Me.toolSearch = New System.Windows.Forms.ToolStripButton
    Me.toolBack = New System.Windows.Forms.ToolStripButton
    Me.toolForward = New System.Windows.Forms.ToolStripButton
    Me.Panel3D3 = New lucidcode.Controls.Panel3D
    Me.Panel3D6 = New lucidcode.Controls.Panel3D
    Me.Label16 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DreamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.CharacterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.LocationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ObjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ActionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ThemeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
    Me.EmotionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
    Me.REMCycleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.SubliminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RecordingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ReadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuFileNewExercise = New System.Windows.Forms.ToolStripMenuItem
    Me.RandomExerciseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuFileDelete = New System.Windows.Forms.ToolStripMenuItem
    Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuFileExport = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
    Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCategoriesCharacters = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCategoriesLocations = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCategoriesObjects = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCategoriesThemes = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCategoriesEmotions = New System.Windows.Forms.ToolStripMenuItem
    Me.LucidityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLucidityREMCycles = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLucidityChecks = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLuciditySubliminals = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLucidityRecordings = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLucidityReadings = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolsPlay = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuToolsDreamSigns = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolsCompareDreams = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolsFIELD = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolsWILD = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuToolsWhyLD = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
    Me.SpellingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCheckSpelling = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuSpellingLanguage = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuEnglish = New System.Windows.Forms.ToolStripMenuItem
    Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuQuickStart = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuHelpUpdate = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuHelpSupport = New System.Windows.Forms.ToolStripMenuItem
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.Panel3D8 = New lucidcode.Controls.Panel3D
    Me.Label3 = New System.Windows.Forms.Label
    Me.trvMain = New System.Windows.Forms.TreeView
    Me.mnuTrv = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuTrvNewExercise = New System.Windows.Forms.ToolStripMenuItem
    Me.RandomExerciseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuTrvDelete = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuTrvPlay = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuTrvExplorer = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuTrvSendTo = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuTrvSendToDesktop = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuTrvSendToLD4All = New System.Windows.Forms.ToolStripMenuItem
    Me.lstImgTrv = New System.Windows.Forms.ImageList(Me.components)
    Me.pnlContainer = New System.Windows.Forms.Panel
    Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.toolCharacters = New System.Windows.Forms.ToolStripButton
    Me.toolLocations = New System.Windows.Forms.ToolStripButton
    Me.toolObjects = New System.Windows.Forms.ToolStripButton
    Me.toolActions = New System.Windows.Forms.ToolStripButton
    Me.toolThemes = New System.Windows.Forms.ToolStripButton
    Me.toolEmotions = New System.Windows.Forms.ToolStripButton
    Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
    Me.Panel3D5 = New lucidcode.Controls.Panel3D
    Me.Panel3D7 = New lucidcode.Controls.Panel3D
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
    Me.toolPlay = New System.Windows.Forms.ToolStripButton
    Me.toolREMCycles = New System.Windows.Forms.ToolStripButton
    Me.toolChecks = New System.Windows.Forms.ToolStripButton
    Me.toolSubliminals = New System.Windows.Forms.ToolStripButton
    Me.toolRecordings = New System.Windows.Forms.ToolStripButton
    Me.toolReadings = New System.Windows.Forms.ToolStripButton
    Me.toolLucidityExercises = New System.Windows.Forms.ToolStripButton
    Me.lblStatus = New System.Windows.Forms.Label
    Me.lstImgIco = New System.Windows.Forms.ImageList(Me.components)
    Me.tmrProcessing = New System.Windows.Forms.Timer(Me.components)
    Me.pnlProcessing = New lucidcode.Controls.Panel3D
    Me.pnlSearching = New lucidcode.Controls.Panel3D
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.tmrSaving = New System.Windows.Forms.Timer(Me.components)
    Me.ToolStrip1.SuspendLayout()
    Me.Panel3D3.SuspendLayout()
    Me.Panel3D6.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel3D1.SuspendLayout()
    Me.Panel3D8.SuspendLayout()
    Me.mnuTrv.SuspendLayout()
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.Panel3D5.SuspendLayout()
    Me.Panel3D7.SuspendLayout()
    Me.ToolStrip3.SuspendLayout()
    Me.pnlProcessing.SuspendLayout()
    Me.pnlSearching.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ToolStrip1.AutoSize = False
    Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
    Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNew, Me.toolDelete, Me.toolSave, Me.toolUpdate, Me.toolSearch, Me.toolBack, Me.toolForward})
    Me.ToolStrip1.Location = New System.Drawing.Point(10, 27)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.ShowItemToolTips = False
    Me.ToolStrip1.Size = New System.Drawing.Size(250, 54)
    Me.ToolStrip1.TabIndex = 6
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'toolNew
    '
    Me.toolNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolNewDream, Me.ToolStripMenuItem6, Me.mnuNewCustomCatgeory, Me.mnuToolNewCharacter, Me.mnuToolNewLocation, Me.mnuToolNewObject, Me.mnuToolNewAction, Me.mnuToolNewTheme, Me.mnuToolNewEmotion, Me.ToolStripMenuItem7, Me.mnuToolNewREMCycle, Me.mnuToolNewCheck, Me.mnuToolNewSubliminal, Me.mnuToolNewRecording, Me.mnuToolNewReading, Me.ExerciseToolStripMenuItem, Me.ExerciseRndToolStripMenuItem})
    Me.toolNew.Image = CType(resources.GetObject("toolNew.Image"), System.Drawing.Image)
    Me.toolNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolNew.ImageTransparentColor = System.Drawing.Color.White
    Me.toolNew.Name = "toolNew"
    Me.toolNew.Size = New System.Drawing.Size(44, 51)
    Me.toolNew.Text = "&New"
    Me.toolNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'mnuToolNewDream
    '
    Me.mnuToolNewDream.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final2
    Me.mnuToolNewDream.Name = "mnuToolNewDream"
    Me.mnuToolNewDream.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewDream.Text = "&Dream"
    '
    'ToolStripMenuItem6
    '
    Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
    Me.ToolStripMenuItem6.Size = New System.Drawing.Size(160, 6)
    '
    'mnuNewCustomCatgeory
    '
    Me.mnuNewCustomCatgeory.Image = CType(resources.GetObject("mnuNewCustomCatgeory.Image"), System.Drawing.Image)
    Me.mnuNewCustomCatgeory.Name = "mnuNewCustomCatgeory"
    Me.mnuNewCustomCatgeory.Size = New System.Drawing.Size(163, 22)
    Me.mnuNewCustomCatgeory.Text = "Category &Folder"
    Me.mnuNewCustomCatgeory.Visible = False
    '
    'mnuToolNewCharacter
    '
    Me.mnuToolNewCharacter.Image = Global.LightenedDream.My.Resources.Resources.Character2
    Me.mnuToolNewCharacter.Name = "mnuToolNewCharacter"
    Me.mnuToolNewCharacter.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewCharacter.Tag = "Character"
    Me.mnuToolNewCharacter.Text = "Character"
    '
    'mnuToolNewLocation
    '
    Me.mnuToolNewLocation.Image = CType(resources.GetObject("mnuToolNewLocation.Image"), System.Drawing.Image)
    Me.mnuToolNewLocation.Name = "mnuToolNewLocation"
    Me.mnuToolNewLocation.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewLocation.Tag = "Location"
    Me.mnuToolNewLocation.Text = "Location"
    '
    'mnuToolNewObject
    '
    Me.mnuToolNewObject.Image = CType(resources.GetObject("mnuToolNewObject.Image"), System.Drawing.Image)
    Me.mnuToolNewObject.Name = "mnuToolNewObject"
    Me.mnuToolNewObject.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewObject.Tag = "Object"
    Me.mnuToolNewObject.Text = "Object"
    '
    'mnuToolNewAction
    '
    Me.mnuToolNewAction.Image = CType(resources.GetObject("mnuToolNewAction.Image"), System.Drawing.Image)
    Me.mnuToolNewAction.Name = "mnuToolNewAction"
    Me.mnuToolNewAction.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewAction.Tag = "Action"
    Me.mnuToolNewAction.Text = "Action"
    '
    'mnuToolNewTheme
    '
    Me.mnuToolNewTheme.Image = CType(resources.GetObject("mnuToolNewTheme.Image"), System.Drawing.Image)
    Me.mnuToolNewTheme.Name = "mnuToolNewTheme"
    Me.mnuToolNewTheme.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewTheme.Tag = "Theme"
    Me.mnuToolNewTheme.Text = "Theme"
    '
    'mnuToolNewEmotion
    '
    Me.mnuToolNewEmotion.Image = CType(resources.GetObject("mnuToolNewEmotion.Image"), System.Drawing.Image)
    Me.mnuToolNewEmotion.Name = "mnuToolNewEmotion"
    Me.mnuToolNewEmotion.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewEmotion.Tag = "Emotion"
    Me.mnuToolNewEmotion.Text = "Emotion"
    '
    'ToolStripMenuItem7
    '
    Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
    Me.ToolStripMenuItem7.Size = New System.Drawing.Size(160, 6)
    '
    'mnuToolNewREMCycle
    '
    Me.mnuToolNewREMCycle.Image = CType(resources.GetObject("mnuToolNewREMCycle.Image"), System.Drawing.Image)
    Me.mnuToolNewREMCycle.Name = "mnuToolNewREMCycle"
    Me.mnuToolNewREMCycle.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewREMCycle.Tag = "REM Cycle"
    Me.mnuToolNewREMCycle.Text = "REM Cycle"
    '
    'mnuToolNewCheck
    '
    Me.mnuToolNewCheck.Image = CType(resources.GetObject("mnuToolNewCheck.Image"), System.Drawing.Image)
    Me.mnuToolNewCheck.Name = "mnuToolNewCheck"
    Me.mnuToolNewCheck.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewCheck.Tag = "Check"
    Me.mnuToolNewCheck.Text = "&Check"
    '
    'mnuToolNewSubliminal
    '
    Me.mnuToolNewSubliminal.Image = CType(resources.GetObject("mnuToolNewSubliminal.Image"), System.Drawing.Image)
    Me.mnuToolNewSubliminal.Name = "mnuToolNewSubliminal"
    Me.mnuToolNewSubliminal.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewSubliminal.Tag = "Subliminal"
    Me.mnuToolNewSubliminal.Text = "&Subliminal"
    '
    'mnuToolNewRecording
    '
    Me.mnuToolNewRecording.Image = CType(resources.GetObject("mnuToolNewRecording.Image"), System.Drawing.Image)
    Me.mnuToolNewRecording.Name = "mnuToolNewRecording"
    Me.mnuToolNewRecording.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewRecording.Tag = "Recording"
    Me.mnuToolNewRecording.Text = "&Recording"
    '
    'mnuToolNewReading
    '
    Me.mnuToolNewReading.Image = CType(resources.GetObject("mnuToolNewReading.Image"), System.Drawing.Image)
    Me.mnuToolNewReading.Name = "mnuToolNewReading"
    Me.mnuToolNewReading.Size = New System.Drawing.Size(163, 22)
    Me.mnuToolNewReading.Tag = "Reading"
    Me.mnuToolNewReading.Text = "&Reading"
    '
    'ExerciseToolStripMenuItem
    '
    Me.ExerciseToolStripMenuItem.Image = CType(resources.GetObject("ExerciseToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ExerciseToolStripMenuItem.Name = "ExerciseToolStripMenuItem"
    Me.ExerciseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.ExerciseToolStripMenuItem.Text = "&Exercise"
    '
    'ExerciseRndToolStripMenuItem
    '
    Me.ExerciseRndToolStripMenuItem.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final_2
    Me.ExerciseRndToolStripMenuItem.Name = "ExerciseRndToolStripMenuItem"
    Me.ExerciseRndToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.ExerciseRndToolStripMenuItem.Text = "&Random Exercise"
    '
    'toolDelete
    '
    Me.toolDelete.AutoSize = False
    Me.toolDelete.Image = CType(resources.GetObject("toolDelete.Image"), System.Drawing.Image)
    Me.toolDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolDelete.ImageTransparentColor = System.Drawing.Color.White
    Me.toolDelete.Name = "toolDelete"
    Me.toolDelete.Size = New System.Drawing.Size(50, 48)
    Me.toolDelete.Text = "&Delete"
    Me.toolDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolSave
    '
    Me.toolSave.AutoSize = False
    Me.toolSave.Image = CType(resources.GetObject("toolSave.Image"), System.Drawing.Image)
    Me.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolSave.ImageTransparentColor = System.Drawing.Color.White
    Me.toolSave.Name = "toolSave"
    Me.toolSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolSave.Size = New System.Drawing.Size(40, 48)
    Me.toolSave.Text = "&Save"
    Me.toolSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolUpdate
    '
    Me.toolUpdate.AutoSize = False
    Me.toolUpdate.Image = CType(resources.GetObject("toolUpdate.Image"), System.Drawing.Image)
    Me.toolUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolUpdate.ImageTransparentColor = System.Drawing.Color.White
    Me.toolUpdate.Name = "toolUpdate"
    Me.toolUpdate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolUpdate.Size = New System.Drawing.Size(50, 48)
    Me.toolUpdate.Text = "&Refresh"
    Me.toolUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolSearch
    '
    Me.toolSearch.AutoSize = False
    Me.toolSearch.Image = CType(resources.GetObject("toolSearch.Image"), System.Drawing.Image)
    Me.toolSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolSearch.ImageTransparentColor = System.Drawing.Color.White
    Me.toolSearch.Name = "toolSearch"
    Me.toolSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolSearch.Size = New System.Drawing.Size(50, 48)
    Me.toolSearch.Text = "&Search"
    Me.toolSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolBack
    '
    Me.toolBack.AutoSize = False
    Me.toolBack.Enabled = False
    Me.toolBack.Image = CType(resources.GetObject("toolBack.Image"), System.Drawing.Image)
    Me.toolBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolBack.ImageTransparentColor = System.Drawing.Color.White
    Me.toolBack.Name = "toolBack"
    Me.toolBack.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolBack.Size = New System.Drawing.Size(48, 48)
    Me.toolBack.Text = "&Back"
    Me.toolBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.toolBack.Visible = False
    '
    'toolForward
    '
    Me.toolForward.AutoSize = False
    Me.toolForward.Enabled = False
    Me.toolForward.Image = CType(resources.GetObject("toolForward.Image"), System.Drawing.Image)
    Me.toolForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolForward.ImageTransparentColor = System.Drawing.Color.White
    Me.toolForward.Name = "toolForward"
    Me.toolForward.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolForward.Size = New System.Drawing.Size(50, 48)
    Me.toolForward.Text = "&Forward"
    Me.toolForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.toolForward.Visible = False
    '
    'Panel3D3
    '
    Me.Panel3D3.Controls.Add(Me.ToolStrip1)
    Me.Panel3D3.Controls.Add(Me.Panel3D6)
    Me.Panel3D3.Location = New System.Drawing.Point(12, 27)
    Me.Panel3D3.Name = "Panel3D3"
    Me.Panel3D3.Size = New System.Drawing.Size(247, 80)
    Me.Panel3D3.TabIndex = 23
    '
    'Panel3D6
    '
    Me.Panel3D6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D6.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
    Me.Panel3D6.Controls.Add(Me.Label16)
    Me.Panel3D6.Controls.Add(Me.Label4)
    Me.Panel3D6.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D6.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D6.Name = "Panel3D6"
    Me.Panel3D6.Size = New System.Drawing.Size(247, 24)
    Me.Panel3D6.TabIndex = 5
    '
    'Label16
    '
    Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label16.BackColor = System.Drawing.Color.Transparent
    Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label16.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label16.Location = New System.Drawing.Point(24, 3)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(220, 19)
    Me.Label16.TabIndex = 3
    Me.Label16.Text = "Controls"
    Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.Color.Transparent
    Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label4.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
    Me.Label4.Location = New System.Drawing.Point(4, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(16, 16)
    Me.Label4.TabIndex = 4
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MenuStrip1
    '
    Me.MenuStrip1.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.LucidityToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
    Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
    Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
    Me.MenuStrip1.TabIndex = 24
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.mnuFileSave, Me.mnuFileDelete, Me.ImportToolStripMenuItem, Me.mnuFileExport, Me.ToolStripMenuItem3, Me.mnuFileExit})
    Me.FileToolStripMenuItem.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "&File"
    '
    'NewToolStripMenuItem
    '
    Me.NewToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
    Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DreamToolStripMenuItem, Me.ToolStripSeparator4, Me.CharacterToolStripMenuItem1, Me.LocationToolStripMenuItem1, Me.ObjectToolStripMenuItem, Me.ActionToolStripMenuItem1, Me.ThemeToolStripMenuItem2, Me.EmotionToolStripMenuItem1, Me.ToolStripMenuItem9, Me.REMCycleToolStripMenuItem1, Me.CheckToolStripMenuItem, Me.SubliminalToolStripMenuItem, Me.RecordingToolStripMenuItem1, Me.ReadingToolStripMenuItem, Me.mnuFileNewExercise, Me.RandomExerciseToolStripMenuItem})
    Me.NewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
    Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
    Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
    Me.NewToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
    Me.NewToolStripMenuItem.Text = "&New"
    '
    'DreamToolStripMenuItem
    '
    Me.DreamToolStripMenuItem.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final2
    Me.DreamToolStripMenuItem.Name = "DreamToolStripMenuItem"
    Me.DreamToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.DreamToolStripMenuItem.Text = "&Dream"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(160, 6)
    '
    'CharacterToolStripMenuItem1
    '
    Me.CharacterToolStripMenuItem1.Image = Global.LightenedDream.My.Resources.Resources.Character2
    Me.CharacterToolStripMenuItem1.Name = "CharacterToolStripMenuItem1"
    Me.CharacterToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.CharacterToolStripMenuItem1.Tag = "Character"
    Me.CharacterToolStripMenuItem1.Text = "Character"
    '
    'LocationToolStripMenuItem1
    '
    Me.LocationToolStripMenuItem1.Image = Global.LightenedDream.My.Resources.Resources.Locations
    Me.LocationToolStripMenuItem1.Name = "LocationToolStripMenuItem1"
    Me.LocationToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.LocationToolStripMenuItem1.Tag = "Location"
    Me.LocationToolStripMenuItem1.Text = "Location"
    '
    'ObjectToolStripMenuItem
    '
    Me.ObjectToolStripMenuItem.Image = CType(resources.GetObject("ObjectToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ObjectToolStripMenuItem.Name = "ObjectToolStripMenuItem"
    Me.ObjectToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.ObjectToolStripMenuItem.Tag = "Object"
    Me.ObjectToolStripMenuItem.Text = "Object"
    '
    'ActionToolStripMenuItem1
    '
    Me.ActionToolStripMenuItem1.Image = CType(resources.GetObject("ActionToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.ActionToolStripMenuItem1.Name = "ActionToolStripMenuItem1"
    Me.ActionToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.ActionToolStripMenuItem1.Tag = "Action"
    Me.ActionToolStripMenuItem1.Text = "Action"
    '
    'ThemeToolStripMenuItem2
    '
    Me.ThemeToolStripMenuItem2.Image = CType(resources.GetObject("ThemeToolStripMenuItem2.Image"), System.Drawing.Image)
    Me.ThemeToolStripMenuItem2.Name = "ThemeToolStripMenuItem2"
    Me.ThemeToolStripMenuItem2.Size = New System.Drawing.Size(163, 22)
    Me.ThemeToolStripMenuItem2.Tag = "Theme"
    Me.ThemeToolStripMenuItem2.Text = "Theme"
    '
    'EmotionToolStripMenuItem1
    '
    Me.EmotionToolStripMenuItem1.Image = CType(resources.GetObject("EmotionToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.EmotionToolStripMenuItem1.Name = "EmotionToolStripMenuItem1"
    Me.EmotionToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.EmotionToolStripMenuItem1.Tag = "Emotion"
    Me.EmotionToolStripMenuItem1.Text = "Emotion"
    '
    'ToolStripMenuItem9
    '
    Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
    Me.ToolStripMenuItem9.Size = New System.Drawing.Size(160, 6)
    '
    'REMCycleToolStripMenuItem1
    '
    Me.REMCycleToolStripMenuItem1.Image = CType(resources.GetObject("REMCycleToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.REMCycleToolStripMenuItem1.Name = "REMCycleToolStripMenuItem1"
    Me.REMCycleToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.REMCycleToolStripMenuItem1.Text = "REM Cycle"
    '
    'CheckToolStripMenuItem
    '
    Me.CheckToolStripMenuItem.Image = CType(resources.GetObject("CheckToolStripMenuItem.Image"), System.Drawing.Image)
    Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
    Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.CheckToolStripMenuItem.Tag = "Check"
    Me.CheckToolStripMenuItem.Text = "&Check"
    '
    'SubliminalToolStripMenuItem
    '
    Me.SubliminalToolStripMenuItem.Image = CType(resources.GetObject("SubliminalToolStripMenuItem.Image"), System.Drawing.Image)
    Me.SubliminalToolStripMenuItem.Name = "SubliminalToolStripMenuItem"
    Me.SubliminalToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.SubliminalToolStripMenuItem.Tag = "Subliminal"
    Me.SubliminalToolStripMenuItem.Text = "&Subliminal"
    '
    'RecordingToolStripMenuItem1
    '
    Me.RecordingToolStripMenuItem1.Image = CType(resources.GetObject("RecordingToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.RecordingToolStripMenuItem1.Name = "RecordingToolStripMenuItem1"
    Me.RecordingToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.RecordingToolStripMenuItem1.Tag = "Recording"
    Me.RecordingToolStripMenuItem1.Text = "&Recording"
    '
    'ReadingToolStripMenuItem
    '
    Me.ReadingToolStripMenuItem.Image = CType(resources.GetObject("ReadingToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ReadingToolStripMenuItem.Name = "ReadingToolStripMenuItem"
    Me.ReadingToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.ReadingToolStripMenuItem.Tag = "Reading"
    Me.ReadingToolStripMenuItem.Text = "&Reading"
    '
    'mnuFileNewExercise
    '
    Me.mnuFileNewExercise.Image = CType(resources.GetObject("mnuFileNewExercise.Image"), System.Drawing.Image)
    Me.mnuFileNewExercise.Name = "mnuFileNewExercise"
    Me.mnuFileNewExercise.Size = New System.Drawing.Size(163, 22)
    Me.mnuFileNewExercise.Text = "&Exercise"
    '
    'RandomExerciseToolStripMenuItem
    '
    Me.RandomExerciseToolStripMenuItem.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final_2
    Me.RandomExerciseToolStripMenuItem.Name = "RandomExerciseToolStripMenuItem"
    Me.RandomExerciseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
    Me.RandomExerciseToolStripMenuItem.Text = "&Random Exercise"
    '
    'mnuFileSave
    '
    Me.mnuFileSave.Image = CType(resources.GetObject("mnuFileSave.Image"), System.Drawing.Image)
    Me.mnuFileSave.Name = "mnuFileSave"
    Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.mnuFileSave.Size = New System.Drawing.Size(158, 22)
    Me.mnuFileSave.Text = "&Save"
    '
    'mnuFileDelete
    '
    Me.mnuFileDelete.Image = CType(resources.GetObject("mnuFileDelete.Image"), System.Drawing.Image)
    Me.mnuFileDelete.Name = "mnuFileDelete"
    Me.mnuFileDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
    Me.mnuFileDelete.Size = New System.Drawing.Size(158, 22)
    Me.mnuFileDelete.Text = "&Delete"
    '
    'ImportToolStripMenuItem
    '
    Me.ImportToolStripMenuItem.Image = Global.LightenedDream.My.Resources.Resources.Graph_Import
    Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
    Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
    Me.ImportToolStripMenuItem.Text = "&Import..."
    Me.ImportToolStripMenuItem.Visible = False
    '
    'mnuFileExport
    '
    Me.mnuFileExport.Image = Global.LightenedDream.My.Resources.Resources.Graph_Export
    Me.mnuFileExport.Name = "mnuFileExport"
    Me.mnuFileExport.Size = New System.Drawing.Size(158, 22)
    Me.mnuFileExport.Text = "Ex&port"
    Me.mnuFileExport.Visible = False
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 6)
    '
    'mnuFileExit
    '
    Me.mnuFileExit.Image = Global.LightenedDream.My.Resources.Resources.Graph_Import
    Me.mnuFileExit.Name = "mnuFileExit"
    Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
    Me.mnuFileExit.Size = New System.Drawing.Size(158, 22)
    Me.mnuFileExit.Text = "E&xit"
    '
    'EditToolStripMenuItem
    '
    Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCategoriesCharacters, Me.mnuCategoriesLocations, Me.mnuCategoriesObjects, Me.mnuCategoriesThemes, Me.mnuCategoriesEmotions})
    Me.EditToolStripMenuItem.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
    Me.EditToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
    Me.EditToolStripMenuItem.Text = "&Categories"
    '
    'mnuCategoriesCharacters
    '
    Me.mnuCategoriesCharacters.Image = Global.LightenedDream.My.Resources.Resources.Character2
    Me.mnuCategoriesCharacters.Name = "mnuCategoriesCharacters"
    Me.mnuCategoriesCharacters.Size = New System.Drawing.Size(130, 22)
    Me.mnuCategoriesCharacters.Tag = "Characters"
    Me.mnuCategoriesCharacters.Text = "&Characters"
    '
    'mnuCategoriesLocations
    '
    Me.mnuCategoriesLocations.Image = Global.LightenedDream.My.Resources.Resources.Locations
    Me.mnuCategoriesLocations.Name = "mnuCategoriesLocations"
    Me.mnuCategoriesLocations.Size = New System.Drawing.Size(130, 22)
    Me.mnuCategoriesLocations.Tag = "Locations"
    Me.mnuCategoriesLocations.Text = "&Locations"
    '
    'mnuCategoriesObjects
    '
    Me.mnuCategoriesObjects.Image = Global.LightenedDream.My.Resources.Resources.objectsdl
    Me.mnuCategoriesObjects.Name = "mnuCategoriesObjects"
    Me.mnuCategoriesObjects.Size = New System.Drawing.Size(130, 22)
    Me.mnuCategoriesObjects.Tag = "Objects"
    Me.mnuCategoriesObjects.Text = "&Objects"
    '
    'mnuCategoriesThemes
    '
    Me.mnuCategoriesThemes.Image = Global.LightenedDream.My.Resources.Resources.Themes
    Me.mnuCategoriesThemes.Name = "mnuCategoriesThemes"
    Me.mnuCategoriesThemes.Size = New System.Drawing.Size(130, 22)
    Me.mnuCategoriesThemes.Tag = "Themes"
    Me.mnuCategoriesThemes.Text = "&Themes"
    '
    'mnuCategoriesEmotions
    '
    Me.mnuCategoriesEmotions.Image = Global.LightenedDream.My.Resources.Resources.Emotions
    Me.mnuCategoriesEmotions.Name = "mnuCategoriesEmotions"
    Me.mnuCategoriesEmotions.Size = New System.Drawing.Size(130, 22)
    Me.mnuCategoriesEmotions.Tag = "Emotions"
    Me.mnuCategoriesEmotions.Text = "&Emotions"
    '
    'LucidityToolStripMenuItem
    '
    Me.LucidityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLucidityREMCycles, Me.mnuLucidityChecks, Me.mnuLuciditySubliminals, Me.mnuLucidityRecordings, Me.mnuLucidityReadings})
    Me.LucidityToolStripMenuItem.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.LucidityToolStripMenuItem.Name = "LucidityToolStripMenuItem"
    Me.LucidityToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
    Me.LucidityToolStripMenuItem.Text = "&Lucidity"
    '
    'mnuLucidityREMCycles
    '
    Me.mnuLucidityREMCycles.Image = CType(resources.GetObject("mnuLucidityREMCycles.Image"), System.Drawing.Image)
    Me.mnuLucidityREMCycles.Name = "mnuLucidityREMCycles"
    Me.mnuLucidityREMCycles.Size = New System.Drawing.Size(152, 22)
    Me.mnuLucidityREMCycles.Tag = "REM Cycles"
    Me.mnuLucidityREMCycles.Text = "&REM Cycles"
    '
    'mnuLucidityChecks
    '
    Me.mnuLucidityChecks.Image = CType(resources.GetObject("mnuLucidityChecks.Image"), System.Drawing.Image)
    Me.mnuLucidityChecks.Name = "mnuLucidityChecks"
    Me.mnuLucidityChecks.Size = New System.Drawing.Size(152, 22)
    Me.mnuLucidityChecks.Tag = "Checks"
    Me.mnuLucidityChecks.Text = "&Checks"
    '
    'mnuLuciditySubliminals
    '
    Me.mnuLuciditySubliminals.Image = CType(resources.GetObject("mnuLuciditySubliminals.Image"), System.Drawing.Image)
    Me.mnuLuciditySubliminals.Name = "mnuLuciditySubliminals"
    Me.mnuLuciditySubliminals.Size = New System.Drawing.Size(152, 22)
    Me.mnuLuciditySubliminals.Tag = "Subliminals"
    Me.mnuLuciditySubliminals.Text = "&Subliminals"
    '
    'mnuLucidityRecordings
    '
    Me.mnuLucidityRecordings.Image = CType(resources.GetObject("mnuLucidityRecordings.Image"), System.Drawing.Image)
    Me.mnuLucidityRecordings.Name = "mnuLucidityRecordings"
    Me.mnuLucidityRecordings.Size = New System.Drawing.Size(152, 22)
    Me.mnuLucidityRecordings.Tag = "Recordings"
    Me.mnuLucidityRecordings.Text = "&Recordings"
    '
    'mnuLucidityReadings
    '
    Me.mnuLucidityReadings.Image = CType(resources.GetObject("mnuLucidityReadings.Image"), System.Drawing.Image)
    Me.mnuLucidityReadings.Name = "mnuLucidityReadings"
    Me.mnuLucidityReadings.Size = New System.Drawing.Size(152, 22)
    Me.mnuLucidityReadings.Tag = "Readings"
    Me.mnuLucidityReadings.Text = "&Readings"
    '
    'ToolsToolStripMenuItem
    '
    Me.ToolsToolStripMenuItem.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsPlay, Me.ToolStripMenuItem22, Me.mnuToolsDreamSigns, Me.mnuToolsCompareDreams, Me.mnuToolsFIELD, Me.mnuToolsWILD, Me.mnuToolsWhyLD, Me.ToolStripMenuItem5, Me.SpellingToolStripMenuItem})
    Me.ToolsToolStripMenuItem.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
    Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
    Me.ToolsToolStripMenuItem.Text = "&Tools"
    '
    'mnuToolsPlay
    '
    Me.mnuToolsPlay.Image = CType(resources.GetObject("mnuToolsPlay.Image"), System.Drawing.Image)
    Me.mnuToolsPlay.Name = "mnuToolsPlay"
    Me.mnuToolsPlay.ShortcutKeys = System.Windows.Forms.Keys.F5
    Me.mnuToolsPlay.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsPlay.Text = "&Play"
    '
    'ToolStripMenuItem22
    '
    Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
    Me.ToolStripMenuItem22.Size = New System.Drawing.Size(172, 6)
    '
    'mnuToolsDreamSigns
    '
    Me.mnuToolsDreamSigns.Image = CType(resources.GetObject("mnuToolsDreamSigns.Image"), System.Drawing.Image)
    Me.mnuToolsDreamSigns.Name = "mnuToolsDreamSigns"
    Me.mnuToolsDreamSigns.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsDreamSigns.Text = "&Dream Sign Builder"
    '
    'mnuToolsCompareDreams
    '
    Me.mnuToolsCompareDreams.Image = Global.LightenedDream.My.Resources.Resources.Dream4
    Me.mnuToolsCompareDreams.Name = "mnuToolsCompareDreams"
    Me.mnuToolsCompareDreams.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsCompareDreams.Text = "&Compare Dreams"
    '
    'mnuToolsFIELD
    '
    Me.mnuToolsFIELD.Image = Global.LightenedDream.My.Resources.Resources.Lucidity2
    Me.mnuToolsFIELD.Name = "mnuToolsFIELD"
    Me.mnuToolsFIELD.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsFIELD.Text = "FIELD Inducer"
    '
    'mnuToolsWILD
    '
    Me.mnuToolsWILD.Image = CType(resources.GetObject("mnuToolsWILD.Image"), System.Drawing.Image)
    Me.mnuToolsWILD.Name = "mnuToolsWILD"
    Me.mnuToolsWILD.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsWILD.Text = "&WILD Inducer"
    '
    'mnuToolsWhyLD
    '
    Me.mnuToolsWhyLD.Image = CType(resources.GetObject("mnuToolsWhyLD.Image"), System.Drawing.Image)
    Me.mnuToolsWhyLD.Name = "mnuToolsWhyLD"
    Me.mnuToolsWhyLD.Size = New System.Drawing.Size(175, 22)
    Me.mnuToolsWhyLD.Text = "Why LD"
    '
    'ToolStripMenuItem5
    '
    Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
    Me.ToolStripMenuItem5.Size = New System.Drawing.Size(172, 6)
    '
    'SpellingToolStripMenuItem
    '
    Me.SpellingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCheckSpelling, Me.mnuSpellingLanguage})
    Me.SpellingToolStripMenuItem.Image = CType(resources.GetObject("SpellingToolStripMenuItem.Image"), System.Drawing.Image)
    Me.SpellingToolStripMenuItem.Name = "SpellingToolStripMenuItem"
    Me.SpellingToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
    Me.SpellingToolStripMenuItem.Text = "&Spelling"
    '
    'mnuCheckSpelling
    '
    Me.mnuCheckSpelling.Checked = True
    Me.mnuCheckSpelling.CheckOnClick = True
    Me.mnuCheckSpelling.CheckState = System.Windows.Forms.CheckState.Checked
    Me.mnuCheckSpelling.Name = "mnuCheckSpelling"
    Me.mnuCheckSpelling.Size = New System.Drawing.Size(152, 22)
    Me.mnuCheckSpelling.Text = "Check Spelling"
    '
    'mnuSpellingLanguage
    '
    Me.mnuSpellingLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnglish})
    Me.mnuSpellingLanguage.Name = "mnuSpellingLanguage"
    Me.mnuSpellingLanguage.Size = New System.Drawing.Size(152, 22)
    Me.mnuSpellingLanguage.Text = "&Language"
    '
    'mnuEnglish
    '
    Me.mnuEnglish.Checked = True
    Me.mnuEnglish.CheckOnClick = True
    Me.mnuEnglish.CheckState = System.Windows.Forms.CheckState.Checked
    Me.mnuEnglish.Name = "mnuEnglish"
    Me.mnuEnglish.Size = New System.Drawing.Size(112, 22)
    Me.mnuEnglish.Text = "&English"
    '
    'HelpToolStripMenuItem
    '
    Me.HelpToolStripMenuItem.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.mnuQuickStart, Me.ToolStripMenuItem11, Me.mnuHelpUpdate, Me.mnuHelpSupport})
    Me.HelpToolStripMenuItem.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
    Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
    Me.HelpToolStripMenuItem.Text = "&Help"
    '
    'mnuHelpAbout
    '
    Me.mnuHelpAbout.Image = CType(resources.GetObject("mnuHelpAbout.Image"), System.Drawing.Image)
    Me.mnuHelpAbout.Name = "mnuHelpAbout"
    Me.mnuHelpAbout.Size = New System.Drawing.Size(132, 22)
    Me.mnuHelpAbout.Text = "&About"
    '
    'mnuQuickStart
    '
    Me.mnuQuickStart.Image = CType(resources.GetObject("mnuQuickStart.Image"), System.Drawing.Image)
    Me.mnuQuickStart.Name = "mnuQuickStart"
    Me.mnuQuickStart.Size = New System.Drawing.Size(132, 22)
    Me.mnuQuickStart.Text = "&Quick Start"
    '
    'ToolStripMenuItem11
    '
    Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
    Me.ToolStripMenuItem11.Size = New System.Drawing.Size(129, 6)
    '
    'mnuHelpUpdate
    '
    Me.mnuHelpUpdate.Image = CType(resources.GetObject("mnuHelpUpdate.Image"), System.Drawing.Image)
    Me.mnuHelpUpdate.Name = "mnuHelpUpdate"
    Me.mnuHelpUpdate.Size = New System.Drawing.Size(132, 22)
    Me.mnuHelpUpdate.Text = "&Register..."
    '
    'mnuHelpSupport
    '
    Me.mnuHelpSupport.Image = CType(resources.GetObject("mnuHelpSupport.Image"), System.Drawing.Image)
    Me.mnuHelpSupport.Name = "mnuHelpSupport"
    Me.mnuHelpSupport.Size = New System.Drawing.Size(132, 22)
    Me.mnuHelpSupport.Text = "&Support..."
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(12, 113)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3D1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.pnlContainer)
    Me.SplitContainer1.Size = New System.Drawing.Size(984, 605)
    Me.SplitContainer1.SplitterDistance = 246
    Me.SplitContainer1.SplitterWidth = 5
    Me.SplitContainer1.TabIndex = 26
    '
    'Panel3D1
    '
    Me.Panel3D1.BackColor = System.Drawing.Color.White
    Me.Panel3D1.Controls.Add(Me.Panel3D8)
    Me.Panel3D1.Controls.Add(Me.trvMain)
    Me.Panel3D1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D1.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(246, 605)
    Me.Panel3D1.TabIndex = 23
    '
    'Panel3D8
    '
    Me.Panel3D8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D8.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
    Me.Panel3D8.Controls.Add(Me.Label3)
    Me.Panel3D8.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D8.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D8.Name = "Panel3D8"
    Me.Panel3D8.Size = New System.Drawing.Size(246, 24)
    Me.Panel3D8.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label3.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label3.Location = New System.Drawing.Point(7, 3)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(236, 19)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Explorer"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'trvMain
    '
    Me.trvMain.AllowDrop = True
    Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.trvMain.BackColor = Global.LightenedDream.My.MySettings.Default.TextBackColor
    Me.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.trvMain.ContextMenuStrip = Me.mnuTrv
    Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.trvMain.Font = Global.LightenedDream.My.MySettings.Default.Font
    Me.trvMain.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.trvMain.HideSelection = False
    Me.trvMain.ImageIndex = 0
    Me.trvMain.ImageList = Me.lstImgTrv
    Me.trvMain.ItemHeight = 18
    Me.trvMain.Location = New System.Drawing.Point(2, 25)
    Me.trvMain.Name = "trvMain"
    TreeNode1.Name = "Node0"
    TreeNode1.Text = "Node0"
    TreeNode2.Name = "Node0"
    TreeNode2.Text = "Dreams"
    TreeNode3.Name = "Node1"
    TreeNode3.Text = "Characters"
    TreeNode4.Name = "Node3"
    TreeNode4.Text = "Locations"
    TreeNode5.Name = "Node4"
    TreeNode5.Text = "Objects"
    TreeNode6.Name = "Node0"
    TreeNode6.Text = "Actions"
    TreeNode7.Name = "Node5"
    TreeNode7.Text = "Themes"
    TreeNode8.Name = "Node14"
    TreeNode8.Text = "Categories"
    TreeNode9.Name = "Node10"
    TreeNode9.Text = "REM Cycles"
    TreeNode10.Name = "Node11"
    TreeNode10.Text = "Reality Checks"
    TreeNode11.Name = "Node12"
    TreeNode11.Text = "Dream Inductions"
    TreeNode12.Name = "Node8"
    TreeNode12.Text = "Lucidity"
    Me.trvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode8, TreeNode12})
    Me.trvMain.SelectedImageIndex = 1
    Me.trvMain.ShowLines = False
    Me.trvMain.Size = New System.Drawing.Size(240, 578)
    Me.trvMain.TabIndex = 0
    '
    'mnuTrv
    '
    Me.mnuTrv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem20, Me.mnuTrvDelete, Me.mnuTrvPlay, Me.ToolStripMenuItem21, Me.mnuTrvExplorer, Me.mnuTrvSendTo})
    Me.mnuTrv.Name = "mnuTrv"
    Me.mnuTrv.Size = New System.Drawing.Size(174, 126)
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
    Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem8, Me.ToolStripMenuItem10, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripSeparator2, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18, Me.ToolStripMenuItem19, Me.mnuTrvNewExercise, Me.RandomExerciseToolStripMenuItem1})
    Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
    Me.ToolStripMenuItem1.Text = "&New"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final2
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem2.Text = "&Dream"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Image = Global.LightenedDream.My.Resources.Resources.Character2
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem4.Tag = "Character"
    Me.ToolStripMenuItem4.Text = "Character"
    '
    'ToolStripMenuItem8
    '
    Me.ToolStripMenuItem8.Image = Global.LightenedDream.My.Resources.Resources.Locations
    Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
    Me.ToolStripMenuItem8.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem8.Tag = "Location"
    Me.ToolStripMenuItem8.Text = "Location"
    '
    'ToolStripMenuItem10
    '
    Me.ToolStripMenuItem10.Image = CType(resources.GetObject("ToolStripMenuItem10.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
    Me.ToolStripMenuItem10.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem10.Tag = "Object"
    Me.ToolStripMenuItem10.Text = "Object"
    '
    'ToolStripMenuItem12
    '
    Me.ToolStripMenuItem12.Image = CType(resources.GetObject("ToolStripMenuItem12.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
    Me.ToolStripMenuItem12.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem12.Tag = "Action"
    Me.ToolStripMenuItem12.Text = "Action"
    '
    'ToolStripMenuItem13
    '
    Me.ToolStripMenuItem13.Image = CType(resources.GetObject("ToolStripMenuItem13.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
    Me.ToolStripMenuItem13.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem13.Tag = "Theme"
    Me.ToolStripMenuItem13.Text = "Theme"
    '
    'ToolStripMenuItem14
    '
    Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
    Me.ToolStripMenuItem14.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem14.Tag = "Emotion"
    Me.ToolStripMenuItem14.Text = "Emotion"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
    '
    'ToolStripMenuItem15
    '
    Me.ToolStripMenuItem15.Image = CType(resources.GetObject("ToolStripMenuItem15.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
    Me.ToolStripMenuItem15.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem15.Text = "&REM Cycle"
    '
    'ToolStripMenuItem16
    '
    Me.ToolStripMenuItem16.Image = CType(resources.GetObject("ToolStripMenuItem16.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
    Me.ToolStripMenuItem16.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem16.Tag = "Check"
    Me.ToolStripMenuItem16.Text = "&Check"
    '
    'ToolStripMenuItem17
    '
    Me.ToolStripMenuItem17.Image = CType(resources.GetObject("ToolStripMenuItem17.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
    Me.ToolStripMenuItem17.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem17.Tag = "Subliminal"
    Me.ToolStripMenuItem17.Text = "&Subliminal"
    '
    'ToolStripMenuItem18
    '
    Me.ToolStripMenuItem18.Image = CType(resources.GetObject("ToolStripMenuItem18.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
    Me.ToolStripMenuItem18.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem18.Tag = "Recording"
    Me.ToolStripMenuItem18.Text = "&Recording"
    '
    'ToolStripMenuItem19
    '
    Me.ToolStripMenuItem19.Image = CType(resources.GetObject("ToolStripMenuItem19.Image"), System.Drawing.Image)
    Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
    Me.ToolStripMenuItem19.Size = New System.Drawing.Size(163, 22)
    Me.ToolStripMenuItem19.Tag = "Reading"
    Me.ToolStripMenuItem19.Text = "&Reading"
    '
    'mnuTrvNewExercise
    '
    Me.mnuTrvNewExercise.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final1
    Me.mnuTrvNewExercise.Name = "mnuTrvNewExercise"
    Me.mnuTrvNewExercise.Size = New System.Drawing.Size(163, 22)
    Me.mnuTrvNewExercise.Text = "&Exercise"
    '
    'RandomExerciseToolStripMenuItem1
    '
    Me.RandomExerciseToolStripMenuItem1.Image = Global.LightenedDream.My.Resources.Resources.Dream_Final_2
    Me.RandomExerciseToolStripMenuItem1.Name = "RandomExerciseToolStripMenuItem1"
    Me.RandomExerciseToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
    Me.RandomExerciseToolStripMenuItem1.Text = "&Random Exercise"
    '
    'ToolStripMenuItem20
    '
    Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
    Me.ToolStripMenuItem20.Size = New System.Drawing.Size(170, 6)
    '
    'mnuTrvDelete
    '
    Me.mnuTrvDelete.Image = CType(resources.GetObject("mnuTrvDelete.Image"), System.Drawing.Image)
    Me.mnuTrvDelete.Name = "mnuTrvDelete"
    Me.mnuTrvDelete.Size = New System.Drawing.Size(173, 22)
    Me.mnuTrvDelete.Text = "&Delete"
    '
    'mnuTrvPlay
    '
    Me.mnuTrvPlay.Image = CType(resources.GetObject("mnuTrvPlay.Image"), System.Drawing.Image)
    Me.mnuTrvPlay.Name = "mnuTrvPlay"
    Me.mnuTrvPlay.Size = New System.Drawing.Size(173, 22)
    Me.mnuTrvPlay.Text = "&Play"
    '
    'ToolStripMenuItem21
    '
    Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
    Me.ToolStripMenuItem21.Size = New System.Drawing.Size(170, 6)
    '
    'mnuTrvExplorer
    '
    Me.mnuTrvExplorer.Image = Global.LightenedDream.My.Resources.Resources.Folder_Launch_16
    Me.mnuTrvExplorer.Name = "mnuTrvExplorer"
    Me.mnuTrvExplorer.Size = New System.Drawing.Size(173, 22)
    Me.mnuTrvExplorer.Text = "&Open File Location"
    '
    'mnuTrvSendTo
    '
    Me.mnuTrvSendTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTrvSendToDesktop, Me.mnuTrvSendToLD4All})
    Me.mnuTrvSendTo.Image = Global.LightenedDream.My.Resources.Resources.Graph_Export
    Me.mnuTrvSendTo.Name = "mnuTrvSendTo"
    Me.mnuTrvSendTo.Size = New System.Drawing.Size(173, 22)
    Me.mnuTrvSendTo.Text = "&Send To"
    '
    'mnuTrvSendToDesktop
    '
    Me.mnuTrvSendToDesktop.Image = CType(resources.GetObject("mnuTrvSendToDesktop.Image"), System.Drawing.Image)
    Me.mnuTrvSendToDesktop.Name = "mnuTrvSendToDesktop"
    Me.mnuTrvSendToDesktop.Size = New System.Drawing.Size(117, 22)
    Me.mnuTrvSendToDesktop.Text = "&Desktop"
    '
    'mnuTrvSendToLD4All
    '
    Me.mnuTrvSendToLD4All.Name = "mnuTrvSendToLD4All"
    Me.mnuTrvSendToLD4All.Size = New System.Drawing.Size(117, 22)
    Me.mnuTrvSendToLD4All.Text = "LD4All"
    Me.mnuTrvSendToLD4All.Visible = False
    '
    'lstImgTrv
    '
    Me.lstImgTrv.ImageStream = CType(resources.GetObject("lstImgTrv.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgTrv.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImgTrv.Images.SetKeyName(0, "Folder.16.ico")
    Me.lstImgTrv.Images.SetKeyName(1, "Folder.Open.16.ico")
    Me.lstImgTrv.Images.SetKeyName(2, "File.Characters0")
    Me.lstImgTrv.Images.SetKeyName(3, "File.Characters")
    Me.lstImgTrv.Images.SetKeyName(4, "File.Locations")
    Me.lstImgTrv.Images.SetKeyName(5, "File.Objects")
    Me.lstImgTrv.Images.SetKeyName(6, "File.Themes")
    Me.lstImgTrv.Images.SetKeyName(7, "File.Emotions")
    Me.lstImgTrv.Images.SetKeyName(8, "File.Actions")
    Me.lstImgTrv.Images.SetKeyName(9, "File.Recordings")
    Me.lstImgTrv.Images.SetKeyName(10, "File.Subliminals")
    Me.lstImgTrv.Images.SetKeyName(11, "File.Checks")
    Me.lstImgTrv.Images.SetKeyName(12, "File.Readings")
    Me.lstImgTrv.Images.SetKeyName(13, "File.REM Cycles")
    Me.lstImgTrv.Images.SetKeyName(14, "Dream")
    Me.lstImgTrv.Images.SetKeyName(15, "Exercise")
    '
    'pnlContainer
    '
    Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
    Me.pnlContainer.Name = "pnlContainer"
    Me.pnlContainer.Size = New System.Drawing.Size(733, 605)
    Me.pnlContainer.TabIndex = 0
    '
    'tmrLoad
    '
    Me.tmrLoad.Enabled = True
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Controls.Add(Me.ToolStrip2)
    Me.Panel3D2.Location = New System.Drawing.Point(265, 27)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(348, 80)
    Me.Panel3D2.TabIndex = 27
    Me.Panel3D2.Visible = False
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.Label5)
    Me.Panel3D4.Controls.Add(Me.Label1)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(348, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.Color.Transparent
    Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label5.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label5.Image = Global.LightenedDream.My.Resources.Resources.Categories
    Me.Label5.Location = New System.Drawing.Point(4, 4)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(16, 16)
    Me.Label5.TabIndex = 5
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label1.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label1.Location = New System.Drawing.Point(24, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(321, 19)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Categories"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ToolStrip2.AutoSize = False
    Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
    Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolCharacters, Me.toolLocations, Me.toolObjects, Me.toolActions, Me.toolThemes, Me.toolEmotions, Me.ToolStripButton10})
    Me.ToolStrip2.Location = New System.Drawing.Point(10, 27)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.ShowItemToolTips = False
    Me.ToolStrip2.Size = New System.Drawing.Size(363, 54)
    Me.ToolStrip2.TabIndex = 6
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'toolCharacters
    '
    Me.toolCharacters.AutoSize = False
    Me.toolCharacters.Image = CType(resources.GetObject("toolCharacters.Image"), System.Drawing.Image)
    Me.toolCharacters.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolCharacters.ImageTransparentColor = System.Drawing.Color.White
    Me.toolCharacters.Name = "toolCharacters"
    Me.toolCharacters.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolCharacters.Size = New System.Drawing.Size(64, 48)
    Me.toolCharacters.Tag = "Characters"
    Me.toolCharacters.Text = "&Characters"
    Me.toolCharacters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolLocations
    '
    Me.toolLocations.AutoSize = False
    Me.toolLocations.Image = CType(resources.GetObject("toolLocations.Image"), System.Drawing.Image)
    Me.toolLocations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolLocations.ImageTransparentColor = System.Drawing.Color.White
    Me.toolLocations.Name = "toolLocations"
    Me.toolLocations.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolLocations.Size = New System.Drawing.Size(58, 48)
    Me.toolLocations.Tag = "Locations"
    Me.toolLocations.Text = "&Locations"
    Me.toolLocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolObjects
    '
    Me.toolObjects.AutoSize = False
    Me.toolObjects.Image = CType(resources.GetObject("toolObjects.Image"), System.Drawing.Image)
    Me.toolObjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolObjects.ImageTransparentColor = System.Drawing.Color.White
    Me.toolObjects.Name = "toolObjects"
    Me.toolObjects.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolObjects.Size = New System.Drawing.Size(50, 48)
    Me.toolObjects.Tag = "Objects"
    Me.toolObjects.Text = "&Objects"
    Me.toolObjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolActions
    '
    Me.toolActions.AutoSize = False
    Me.toolActions.Image = CType(resources.GetObject("toolActions.Image"), System.Drawing.Image)
    Me.toolActions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolActions.ImageTransparentColor = System.Drawing.Color.White
    Me.toolActions.Name = "toolActions"
    Me.toolActions.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolActions.Size = New System.Drawing.Size(50, 48)
    Me.toolActions.Tag = "Actions"
    Me.toolActions.Text = "&Actions"
    Me.toolActions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolThemes
    '
    Me.toolThemes.AutoSize = False
    Me.toolThemes.Image = CType(resources.GetObject("toolThemes.Image"), System.Drawing.Image)
    Me.toolThemes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolThemes.ImageTransparentColor = System.Drawing.Color.White
    Me.toolThemes.Name = "toolThemes"
    Me.toolThemes.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolThemes.Size = New System.Drawing.Size(50, 48)
    Me.toolThemes.Tag = "Themes"
    Me.toolThemes.Text = "&Themes"
    Me.toolThemes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolEmotions
    '
    Me.toolEmotions.AutoSize = False
    Me.toolEmotions.Image = CType(resources.GetObject("toolEmotions.Image"), System.Drawing.Image)
    Me.toolEmotions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolEmotions.ImageTransparentColor = System.Drawing.Color.White
    Me.toolEmotions.Name = "toolEmotions"
    Me.toolEmotions.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolEmotions.Size = New System.Drawing.Size(60, 48)
    Me.toolEmotions.Tag = "Emotions"
    Me.toolEmotions.Text = "&Emotions"
    Me.toolEmotions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton10
    '
    Me.ToolStripButton10.AutoSize = False
    Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
    Me.ToolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.White
    Me.ToolStripButton10.Name = "ToolStripButton10"
    Me.ToolStripButton10.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.ToolStripButton10.Size = New System.Drawing.Size(54, 48)
    Me.ToolStripButton10.Text = "&Lessons"
    Me.ToolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'Panel3D5
    '
    Me.Panel3D5.Controls.Add(Me.Panel3D7)
    Me.Panel3D5.Controls.Add(Me.ToolStrip3)
    Me.Panel3D5.Location = New System.Drawing.Point(265, 27)
    Me.Panel3D5.Name = "Panel3D5"
    Me.Panel3D5.Size = New System.Drawing.Size(422, 80)
    Me.Panel3D5.TabIndex = 28
    '
    'Panel3D7
    '
    Me.Panel3D7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D7.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
    Me.Panel3D7.Controls.Add(Me.Label6)
    Me.Panel3D7.Controls.Add(Me.Label2)
    Me.Panel3D7.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D7.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D7.Name = "Panel3D7"
    Me.Panel3D7.Size = New System.Drawing.Size(422, 24)
    Me.Panel3D7.TabIndex = 5
    '
    'Label6
    '
    Me.Label6.BackColor = System.Drawing.Color.Transparent
    Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label6.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label6.Image = Global.LightenedDream.My.Resources.Resources.Lucidity
    Me.Label6.Location = New System.Drawing.Point(4, 4)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(16, 16)
    Me.Label6.TabIndex = 6
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label2.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
    Me.Label2.Location = New System.Drawing.Point(24, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(395, 19)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Lucidity"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ToolStrip3
    '
    Me.ToolStrip3.AutoSize = False
    Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
    Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPlay, Me.toolREMCycles, Me.toolChecks, Me.toolSubliminals, Me.toolRecordings, Me.toolReadings, Me.toolLucidityExercises})
    Me.ToolStrip3.Location = New System.Drawing.Point(10, 27)
    Me.ToolStrip3.Name = "ToolStrip3"
    Me.ToolStrip3.ShowItemToolTips = False
    Me.ToolStrip3.Size = New System.Drawing.Size(424, 54)
    Me.ToolStrip3.TabIndex = 6
    Me.ToolStrip3.Text = "ToolStrip3"
    '
    'toolPlay
    '
    Me.toolPlay.AutoSize = False
    Me.toolPlay.Enabled = False
    Me.toolPlay.Image = Global.LightenedDream.My.Resources.Resources.Function_Play
    Me.toolPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolPlay.ImageTransparentColor = System.Drawing.Color.White
    Me.toolPlay.Name = "toolPlay"
    Me.toolPlay.Size = New System.Drawing.Size(40, 48)
    Me.toolPlay.Text = "&Play"
    Me.toolPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolREMCycles
    '
    Me.toolREMCycles.AutoSize = False
    Me.toolREMCycles.Image = CType(resources.GetObject("toolREMCycles.Image"), System.Drawing.Image)
    Me.toolREMCycles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolREMCycles.ImageTransparentColor = System.Drawing.Color.White
    Me.toolREMCycles.Name = "toolREMCycles"
    Me.toolREMCycles.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolREMCycles.Size = New System.Drawing.Size(68, 48)
    Me.toolREMCycles.Tag = "REM Cycles"
    Me.toolREMCycles.Text = "&REM Cycles"
    Me.toolREMCycles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolChecks
    '
    Me.toolChecks.AutoSize = False
    Me.toolChecks.Image = CType(resources.GetObject("toolChecks.Image"), System.Drawing.Image)
    Me.toolChecks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolChecks.ImageTransparentColor = System.Drawing.Color.White
    Me.toolChecks.Name = "toolChecks"
    Me.toolChecks.Size = New System.Drawing.Size(50, 48)
    Me.toolChecks.Tag = "Checks"
    Me.toolChecks.Text = "&Checks"
    Me.toolChecks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolSubliminals
    '
    Me.toolSubliminals.AutoSize = False
    Me.toolSubliminals.Image = CType(resources.GetObject("toolSubliminals.Image"), System.Drawing.Image)
    Me.toolSubliminals.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolSubliminals.ImageTransparentColor = System.Drawing.Color.White
    Me.toolSubliminals.Name = "toolSubliminals"
    Me.toolSubliminals.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolSubliminals.Size = New System.Drawing.Size(68, 48)
    Me.toolSubliminals.Tag = "Subliminals"
    Me.toolSubliminals.Text = "&Subliminals"
    Me.toolSubliminals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolRecordings
    '
    Me.toolRecordings.AutoSize = False
    Me.toolRecordings.Image = Global.LightenedDream.My.Resources.Resources.Action_Record
    Me.toolRecordings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolRecordings.ImageTransparentColor = System.Drawing.Color.White
    Me.toolRecordings.Name = "toolRecordings"
    Me.toolRecordings.Size = New System.Drawing.Size(64, 48)
    Me.toolRecordings.Tag = "Recordings"
    Me.toolRecordings.Text = "&Recordings"
    Me.toolRecordings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolReadings
    '
    Me.toolReadings.AutoSize = False
    Me.toolReadings.Image = CType(resources.GetObject("toolReadings.Image"), System.Drawing.Image)
    Me.toolReadings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolReadings.ImageTransparentColor = System.Drawing.Color.White
    Me.toolReadings.Name = "toolReadings"
    Me.toolReadings.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolReadings.Size = New System.Drawing.Size(56, 48)
    Me.toolReadings.Tag = "Readings"
    Me.toolReadings.Text = "Readin&gs"
    Me.toolReadings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolLucidityExercises
    '
    Me.toolLucidityExercises.AutoSize = False
    Me.toolLucidityExercises.Image = CType(resources.GetObject("toolLucidityExercises.Image"), System.Drawing.Image)
    Me.toolLucidityExercises.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolLucidityExercises.ImageTransparentColor = System.Drawing.Color.White
    Me.toolLucidityExercises.Name = "toolLucidityExercises"
    Me.toolLucidityExercises.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.toolLucidityExercises.Size = New System.Drawing.Size(58, 48)
    Me.toolLucidityExercises.Tag = "Exercises"
    Me.toolLucidityExercises.Text = "E&xercises"
    Me.toolLucidityExercises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'lblStatus
    '
    Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblStatus.Location = New System.Drawing.Point(12, 708)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(984, 18)
    Me.lblStatus.TabIndex = 29
    Me.lblStatus.Visible = False
    '
    'lstImgIco
    '
    Me.lstImgIco.ImageStream = CType(resources.GetObject("lstImgIco.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgIco.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImgIco.Images.SetKeyName(0, "Dream.0.ico")
    Me.lstImgIco.Images.SetKeyName(1, "Dream.1.ico")
    Me.lstImgIco.Images.SetKeyName(2, "Dream.2.ico")
    Me.lstImgIco.Images.SetKeyName(3, "Dream.3.ico")
    Me.lstImgIco.Images.SetKeyName(4, "Dream.4.ico")
    Me.lstImgIco.Images.SetKeyName(5, "Dream.5.ico")
    Me.lstImgIco.Images.SetKeyName(6, "Dream.6.ico")
    Me.lstImgIco.Images.SetKeyName(7, "Dream.7.ico")
    Me.lstImgIco.Images.SetKeyName(8, "Dream.8.ico")
    Me.lstImgIco.Images.SetKeyName(9, "Dream.9.ico")
    Me.lstImgIco.Images.SetKeyName(10, "Dream.10.ico")
    Me.lstImgIco.Images.SetKeyName(11, "Dream.11.ico")
    Me.lstImgIco.Images.SetKeyName(12, "Dream.12.ico")
    Me.lstImgIco.Images.SetKeyName(13, "Dream.13.ico")
    Me.lstImgIco.Images.SetKeyName(14, "Dream.14.ico")
    Me.lstImgIco.Images.SetKeyName(15, "Dream.15.ico")
    Me.lstImgIco.Images.SetKeyName(16, "Dream.16.ico")
    Me.lstImgIco.Images.SetKeyName(17, "Dream.17.ico")
    Me.lstImgIco.Images.SetKeyName(18, "Dream.18.ico")
    Me.lstImgIco.Images.SetKeyName(19, "Dream.19.ico")
    Me.lstImgIco.Images.SetKeyName(20, "Dream.20.ico")
    Me.lstImgIco.Images.SetKeyName(21, "Dream.21.ico")
    Me.lstImgIco.Images.SetKeyName(22, "Dream.22.ico")
    Me.lstImgIco.Images.SetKeyName(23, "Dream.23.ico")
    Me.lstImgIco.Images.SetKeyName(24, "Dream.24.ico")
    Me.lstImgIco.Images.SetKeyName(25, "Dream.25.ico")
    Me.lstImgIco.Images.SetKeyName(26, "Dream.26.ico")
    Me.lstImgIco.Images.SetKeyName(27, "Dream.27.ico")
    Me.lstImgIco.Images.SetKeyName(28, "Dream.28.ico")
    Me.lstImgIco.Images.SetKeyName(29, "Dream.29.ico")
    Me.lstImgIco.Images.SetKeyName(30, "Dream.30.ico")
    Me.lstImgIco.Images.SetKeyName(31, "Dream.31.ico")
    Me.lstImgIco.Images.SetKeyName(32, "Dream.32.ico")
    Me.lstImgIco.Images.SetKeyName(33, "Dream.33.ico")
    '
    'tmrProcessing
    '
    Me.tmrProcessing.Enabled = True
    Me.tmrProcessing.Interval = 250
    '
    'pnlProcessing
    '
    Me.pnlProcessing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlProcessing.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.pnlProcessing.Controls.Add(Me.pnlSearching)
    Me.pnlProcessing.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlProcessing.Location = New System.Drawing.Point(12, 27)
    Me.pnlProcessing.Name = "pnlProcessing"
    Me.pnlProcessing.Size = New System.Drawing.Size(984, 691)
    Me.pnlProcessing.TabIndex = 30
    Me.pnlProcessing.Visible = False
    '
    'pnlSearching
    '
    Me.pnlSearching.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    MySettings1.Font = New System.Drawing.Font("Verdana", 8.25!)
    MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue
    MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue
    MySettings1.LastAsleep = New Date(CType(0, Long))
    MySettings1.LastAwake = New Date(CType(0, Long))
    MySettings1.SettingsKey = ""
    MySettings1.TextBackColor = System.Drawing.Color.White
    MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue
    MySettings1.TitleForeColor = System.Drawing.Color.White
    Me.pnlSearching.BackColor = MySettings1.FormBackColor
    Me.pnlSearching.Controls.Add(Me.graph)
    Me.pnlSearching.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlSearching.Location = New System.Drawing.Point(0, 0)
    Me.pnlSearching.Name = "pnlSearching"
    Me.pnlSearching.Size = New System.Drawing.Size(984, 691)
    Me.pnlSearching.TabIndex = 19
    '
    'graph
    '
    Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.graph.BackColor = System.Drawing.Color.Transparent
    ChartArea1.Area3DStyle.Enable3D = True
    ChartArea1.Area3DStyle.Inclination = 10
    ChartArea1.Area3DStyle.IsClustered = True
    ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
    ChartArea1.Area3DStyle.PointDepth = 200
    ChartArea1.Area3DStyle.PointGapDepth = 0
    ChartArea1.Area3DStyle.Rotation = 10
    ChartArea1.Area3DStyle.WallWidth = 0
    ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisX.IsLabelAutoFit = False
    ChartArea1.AxisX.LabelStyle.Angle = 90
    ChartArea1.AxisX.LabelStyle.Enabled = False
    ChartArea1.AxisX.LabelStyle.Interval = 0
    ChartArea1.AxisX.LineColor = System.Drawing.Color.Transparent
    ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
    ChartArea1.AxisX.LineWidth = 0
    ChartArea1.AxisX.MajorGrid.Enabled = False
    ChartArea1.AxisX.MajorGrid.LineWidth = 0
    ChartArea1.AxisX.MajorTickMark.Enabled = False
    ChartArea1.AxisX.MajorTickMark.LineWidth = 0
    ChartArea1.AxisX.MajorTickMark.Size = 0.0!
    ChartArea1.AxisX.MinorGrid.LineWidth = 0
    ChartArea1.AxisX.MinorTickMark.LineWidth = 0
    ChartArea1.AxisX.MinorTickMark.Size = 0.0!
    ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue
    CustomLabel1.Text = "x"
    CustomLabel2.Text = "x"
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2)
    ChartArea1.AxisX2.LineWidth = 0
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisY.LabelStyle.Enabled = False
    ChartArea1.AxisY.LineWidth = 0
    ChartArea1.AxisY.MajorGrid.Enabled = False
    ChartArea1.AxisY.MajorTickMark.Enabled = False
    ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.LightSteelBlue
    ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
    ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
    ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.LineWidth = 0
    ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
    ChartArea1.AxisY2.Maximum = 11
    ChartArea1.AxisY2.Minimum = -11
    ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave
    ChartArea1.AxisY2.ScaleBreakStyle.Enabled = True
    ChartArea1.BackColor = System.Drawing.Color.LightSteelBlue
    ChartArea1.BackImageTransparentColor = System.Drawing.Color.White
    ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
    ChartArea1.BorderColor = System.Drawing.Color.LightSteelBlue
    ChartArea1.BorderWidth = 0
    ChartArea1.Name = "ChartArea1"
    ChartArea1.ShadowColor = System.Drawing.Color.Transparent
    Me.graph.ChartAreas.Add(ChartArea1)
    Me.graph.Location = New System.Drawing.Point(3, 3)
    Me.graph.Name = "graph"
    Series1.ChartArea = "ChartArea1"
    Series1.Name = "Series1"
    Me.graph.Series.Add(Series1)
    Me.graph.Size = New System.Drawing.Size(978, 685)
    Me.graph.TabIndex = 283
    '
    'tmrSaving
    '
    Me.tmrSaving.Interval = 128
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
    Me.ClientSize = New System.Drawing.Size(1008, 730)
    Me.Controls.Add(Me.pnlProcessing)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.lblStatus)
    Me.Controls.Add(Me.Panel3D3)
    Me.Controls.Add(Me.Panel3D5)
    Me.Controls.Add(Me.Panel3D2)
    Me.Controls.Add(Me.MenuStrip1)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.LightenedDream.My.MySettings.Default.Font
    Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "MainForm"
    Me.Text = "Lightened Dream"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.Panel3D6.ResumeLayout(False)
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D8.ResumeLayout(False)
    Me.mnuTrv.ResumeLayout(False)
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.Panel3D5.ResumeLayout(False)
    Me.Panel3D7.ResumeLayout(False)
    Me.ToolStrip3.ResumeLayout(False)
    Me.ToolStrip3.PerformLayout()
    Me.pnlProcessing.ResumeLayout(False)
    Me.pnlSearching.ResumeLayout(False)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents toolSave As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolDelete As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolBack As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D6 As lucidcode.Controls.Panel3D
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents trvMain As System.Windows.Forms.TreeView
  Friend WithEvents pnlContainer As System.Windows.Forms.Panel
  Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
  Friend WithEvents toolNew As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents mnuToolNewDream As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents lstImgTrv As System.Windows.Forms.ImageList
  Friend WithEvents Panel3D8 As lucidcode.Controls.Panel3D
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents toolCharacters As System.Windows.Forms.ToolStripButton
  Friend WithEvents Panel3D5 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D7 As lucidcode.Controls.Panel3D
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
  Friend WithEvents toolREMCycles As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolChecks As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolLocations As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolObjects As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolActions As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolThemes As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolEmotions As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolForward As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolUpdate As System.Windows.Forms.ToolStripButton
  Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFileDelete As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents toolPlay As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnuFileExport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolsPlay As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents toolRecordings As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DreamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuToolNewCharacter As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewLocation As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewObject As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewAction As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewTheme As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewEmotion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuToolNewREMCycle As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewCheck As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewSubliminal As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CharacterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ActionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ThemeToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EmotionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents RecordingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents REMCycleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LocationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuHelpSupport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents toolSubliminals As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolReadings As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnuTrv As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuTrvSendTo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTrvDelete As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTrvSendToDesktop As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewRecording As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuToolNewReading As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SubliminalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCategoriesCharacters As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCategoriesLocations As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCategoriesObjects As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCategoriesThemes As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCategoriesEmotions As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LucidityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLucidityREMCycles As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLucidityChecks As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLuciditySubliminals As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLucidityRecordings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLucidityReadings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents toolSearch As System.Windows.Forms.ToolStripButton
  Friend WithEvents lstImgIco As System.Windows.Forms.ImageList
  Friend WithEvents tmrProcessing As System.Windows.Forms.Timer
  Friend WithEvents mnuTrvPlay As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTrvExplorer As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNewCustomCatgeory As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents SpellingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCheckSpelling As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSpellingLanguage As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEnglish As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExerciseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFileNewExercise As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTrvNewExercise As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExerciseRndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RandomExerciseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RandomExerciseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents toolLucidityExercises As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuToolsWILD As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuToolsDreamSigns As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuHelpUpdate As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuQuickStart As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTrvSendToLD4All As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents pnlProcessing As lucidcode.Controls.Panel3D
  Friend WithEvents pnlSearching As lucidcode.Controls.Panel3D
    Friend WithEvents tmrSaving As System.Windows.Forms.Timer
    Friend WithEvents mnuToolsWhyLD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuToolsCompareDreams As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents mnuToolsFIELD As System.Windows.Forms.ToolStripMenuItem

End Class
