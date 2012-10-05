<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REMCyclesControl
  Inherits System.Windows.Forms.UserControl

  'UserControl1 overrides dispose to clean up the component list.
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
    Dim mnuAddSoundFile As System.Windows.Forms.ToolStripMenuItem
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REMCyclesControl))
    Dim Border3DAnnotation1 As System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation = New System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation
    Dim VerticalLineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation = New System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation
    Dim LineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation
    Dim VerticalLineAnnotation2 As System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation = New System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation
    Dim ArrowAnnotation1 As System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation = New System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation
    Dim ImageAnnotation1 As System.Windows.Forms.DataVisualization.Charting.ImageAnnotation = New System.Windows.Forms.DataVisualization.Charting.ImageAnnotation
    Dim CalloutAnnotation1 As System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation = New System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation
    Dim CalloutAnnotation2 As System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation = New System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation
    Dim TextAnnotation1 As System.Windows.Forms.DataVisualization.Charting.TextAnnotation = New System.Windows.Forms.DataVisualization.Charting.TextAnnotation
    Dim PolygonAnnotation1 As System.Windows.Forms.DataVisualization.Charting.PolygonAnnotation = New System.Windows.Forms.DataVisualization.Charting.PolygonAnnotation
    Dim PolylineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation = New System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation
    Dim AnnotationPathPoint1 As System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint = New System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint
    Dim AnnotationPathPoint2 As System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint = New System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint
    Dim AnnotationPathPoint3 As System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint = New System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"00:30", "DJ Tiesto - Lord of Trance"}, 0)
    Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("02:00")
    Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("03:30")
    Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("05:00")
    Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("06:30")
    Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("08:00")
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.tmrWatch = New System.Windows.Forms.Timer(Me.components)
    Me.mnuAnnotation = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuAnnotationAdd = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuChecks = New System.Windows.Forms.ToolStripMenuItem
    Me.LoadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuSubliminals = New System.Windows.Forms.ToolStripMenuItem
    Me.LoadingToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuRecordings = New System.Windows.Forms.ToolStripMenuItem
    Me.LoadingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuReadings = New System.Windows.Forms.ToolStripMenuItem
    Me.LoadingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuAnnotationPlay = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAnnotationCopy = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAnnotationPaste = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAnnotationDelete = New System.Windows.Forms.ToolStripMenuItem
    Me.Label5 = New System.Windows.Forms.Label
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.cmbCycles = New System.Windows.Forms.ComboBox
    Me.txtTime = New System.Windows.Forms.TextBox
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.lstItems = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.Label1 = New System.Windows.Forms.Label
    Me.cmbCycleLength = New System.Windows.Forms.ComboBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtDescription = New System.Windows.Forms.TextBox
    Me.txtTitle = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label11 = New System.Windows.Forms.Label
    Me.objPlayer = New AxWMPLib.AxWindowsMediaPlayer
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.objOpenFileDialog = New System.Windows.Forms.OpenFileDialog
    mnuAddSoundFile = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAnnotation.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D2.SuspendLayout()
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D1.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuAddSoundFile
    '
    mnuAddSoundFile.Image = CType(resources.GetObject("mnuAddSoundFile.Image"), System.Drawing.Image)
    mnuAddSoundFile.Name = "mnuAddSoundFile"
    mnuAddSoundFile.Size = New System.Drawing.Size(138, 22)
    mnuAddSoundFile.Text = "&Sound File..."
    AddHandler mnuAddSoundFile.Click, AddressOf Me.mnuAddSoundFile_Click
    '
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "Sounds.ico")
    '
    'tmrWatch
    '
    Me.tmrWatch.Interval = 1000
    '
    'mnuAnnotation
    '
    Me.mnuAnnotation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAnnotationAdd, Me.ToolStripMenuItem1, Me.mnuAnnotationPlay, Me.mnuAnnotationCopy, Me.mnuAnnotationPaste, Me.mnuAnnotationDelete})
    Me.mnuAnnotation.Name = "mnuAnnotation"
    Me.mnuAnnotation.Size = New System.Drawing.Size(111, 120)
    '
    'mnuAnnotationAdd
    '
    Me.mnuAnnotationAdd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChecks, Me.mnuSubliminals, Me.mnuRecordings, Me.mnuReadings, Me.ToolStripMenuItem2, mnuAddSoundFile})
    Me.mnuAnnotationAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuAnnotationAdd.Image = CType(resources.GetObject("mnuAnnotationAdd.Image"), System.Drawing.Image)
    Me.mnuAnnotationAdd.Name = "mnuAnnotationAdd"
    Me.mnuAnnotationAdd.Size = New System.Drawing.Size(110, 22)
    Me.mnuAnnotationAdd.Text = "&Import"
    '
    'mnuChecks
    '
    Me.mnuChecks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingToolStripMenuItem})
    Me.mnuChecks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
    Me.mnuChecks.Image = CType(resources.GetObject("mnuChecks.Image"), System.Drawing.Image)
    Me.mnuChecks.Name = "mnuChecks"
    Me.mnuChecks.Size = New System.Drawing.Size(138, 22)
    Me.mnuChecks.Tag = "Checks"
    Me.mnuChecks.Text = "&Checks"
    '
    'LoadingToolStripMenuItem
    '
    Me.LoadingToolStripMenuItem.Name = "LoadingToolStripMenuItem"
    Me.LoadingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    Me.LoadingToolStripMenuItem.Text = "Loading..."
    '
    'mnuSubliminals
    '
    Me.mnuSubliminals.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingToolStripMenuItem3})
    Me.mnuSubliminals.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuSubliminals.Image = CType(resources.GetObject("mnuSubliminals.Image"), System.Drawing.Image)
    Me.mnuSubliminals.Name = "mnuSubliminals"
    Me.mnuSubliminals.Size = New System.Drawing.Size(138, 22)
    Me.mnuSubliminals.Tag = "Subliminals"
    Me.mnuSubliminals.Text = "&Subliminals"
    '
    'LoadingToolStripMenuItem3
    '
    Me.LoadingToolStripMenuItem3.Name = "LoadingToolStripMenuItem3"
    Me.LoadingToolStripMenuItem3.Size = New System.Drawing.Size(126, 22)
    Me.LoadingToolStripMenuItem3.Text = "Loading..."
    '
    'mnuRecordings
    '
    Me.mnuRecordings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingToolStripMenuItem2})
    Me.mnuRecordings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuRecordings.Image = CType(resources.GetObject("mnuRecordings.Image"), System.Drawing.Image)
    Me.mnuRecordings.Name = "mnuRecordings"
    Me.mnuRecordings.Size = New System.Drawing.Size(138, 22)
    Me.mnuRecordings.Tag = "Recordings"
    Me.mnuRecordings.Text = "&Recordings"
    '
    'LoadingToolStripMenuItem2
    '
    Me.LoadingToolStripMenuItem2.Name = "LoadingToolStripMenuItem2"
    Me.LoadingToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
    Me.LoadingToolStripMenuItem2.Text = "Loading..."
    '
    'mnuReadings
    '
    Me.mnuReadings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingToolStripMenuItem1})
    Me.mnuReadings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.mnuReadings.Image = CType(resources.GetObject("mnuReadings.Image"), System.Drawing.Image)
    Me.mnuReadings.Name = "mnuReadings"
    Me.mnuReadings.Size = New System.Drawing.Size(138, 22)
    Me.mnuReadings.Tag = "Readings"
    Me.mnuReadings.Text = "&Readings"
    '
    'LoadingToolStripMenuItem1
    '
    Me.LoadingToolStripMenuItem1.Name = "LoadingToolStripMenuItem1"
    Me.LoadingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
    Me.LoadingToolStripMenuItem1.Text = "Loading..."
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(135, 6)
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 6)
    '
    'mnuAnnotationPlay
    '
    Me.mnuAnnotationPlay.Image = CType(resources.GetObject("mnuAnnotationPlay.Image"), System.Drawing.Image)
    Me.mnuAnnotationPlay.Name = "mnuAnnotationPlay"
    Me.mnuAnnotationPlay.Size = New System.Drawing.Size(110, 22)
    Me.mnuAnnotationPlay.Text = "&Play"
    '
    'mnuAnnotationCopy
    '
    Me.mnuAnnotationCopy.Image = CType(resources.GetObject("mnuAnnotationCopy.Image"), System.Drawing.Image)
    Me.mnuAnnotationCopy.Name = "mnuAnnotationCopy"
    Me.mnuAnnotationCopy.Size = New System.Drawing.Size(110, 22)
    Me.mnuAnnotationCopy.Text = "&Copy"
    '
    'mnuAnnotationPaste
    '
    Me.mnuAnnotationPaste.Enabled = False
    Me.mnuAnnotationPaste.Image = CType(resources.GetObject("mnuAnnotationPaste.Image"), System.Drawing.Image)
    Me.mnuAnnotationPaste.Name = "mnuAnnotationPaste"
    Me.mnuAnnotationPaste.Size = New System.Drawing.Size(110, 22)
    Me.mnuAnnotationPaste.Text = "&Paste"
    '
    'mnuAnnotationDelete
    '
    Me.mnuAnnotationDelete.Image = CType(resources.GetObject("mnuAnnotationDelete.Image"), System.Drawing.Image)
    Me.mnuAnnotationDelete.Name = "mnuAnnotationDelete"
    Me.mnuAnnotationDelete.Size = New System.Drawing.Size(110, 22)
    Me.mnuAnnotationDelete.Text = "&Delete"
    '
    'Label5
    '
    Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label5.Location = New System.Drawing.Point(7, 30)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(82, 21)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Sleep Cycles"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor
        Me.Panel3D4.Controls.Add(Me.lblTitle)
        Me.Panel3D4.Controls.Add(Me.Label2)
        Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D4.Name = "Panel3D4"
        Me.Panel3D4.Size = New System.Drawing.Size(640, 24)
        Me.Panel3D4.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor
        Me.lblTitle.Location = New System.Drawing.Point(7, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(630, 19)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "REM Cycles"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dream"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCycles
        '
        Me.cmbCycles.FormattingEnabled = True
        Me.cmbCycles.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbCycles.Location = New System.Drawing.Point(95, 30)
        Me.cmbCycles.Name = "cmbCycles"
        Me.cmbCycles.Size = New System.Drawing.Size(38, 21)
        Me.cmbCycles.TabIndex = 10
        Me.cmbCycles.Text = "6"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(346, 31)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(71, 21)
        Me.txtTime.TabIndex = 13
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'graph
        '
        Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Border3DAnnotation1.AllowAnchorMoving = True
        Border3DAnnotation1.AllowMoving = True
        Border3DAnnotation1.AllowSelecting = True
        Border3DAnnotation1.AllowTextEditing = True
        Border3DAnnotation1.AnchorX = 5
        Border3DAnnotation1.AnchorY = 50
        Border3DAnnotation1.AxisXName = "ChartArea1\rX"
        Border3DAnnotation1.BackColor = System.Drawing.Color.LightSteelBlue
        Border3DAnnotation1.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Border3DAnnotation1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
        Border3DAnnotation1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Border3DAnnotation1.ForeColor = System.Drawing.Color.MidnightBlue
        Border3DAnnotation1.IsMultiline = True
        Border3DAnnotation1.LineColor = System.Drawing.Color.Empty
        Border3DAnnotation1.Name = "Border3DAnnotation1"
        Border3DAnnotation1.Text = "Tiesto - Lord of Trance"
        Border3DAnnotation1.YAxisName = "ChartArea1\rY"
        VerticalLineAnnotation1.AllowMoving = True
        VerticalLineAnnotation1.AnchorX = 15
        VerticalLineAnnotation1.AnchorY = 10
        VerticalLineAnnotation1.IsInfinitive = True
        VerticalLineAnnotation1.LineColor = System.Drawing.Color.DarkCyan
        VerticalLineAnnotation1.LineWidth = 5
        VerticalLineAnnotation1.Name = "VerticalLineAnnotation1"
        VerticalLineAnnotation1.ShadowOffset = 1
        VerticalLineAnnotation1.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round
        LineAnnotation1.Name = "LineAnnotation1"
        LineAnnotation1.Width = 3
        VerticalLineAnnotation2.AnchorX = 1
        VerticalLineAnnotation2.AnchorY = 1
        VerticalLineAnnotation2.LineColor = System.Drawing.Color.SteelBlue
        VerticalLineAnnotation2.LineWidth = 2
        VerticalLineAnnotation2.Name = "objNow"
        VerticalLineAnnotation2.X = 12
        VerticalLineAnnotation2.Y = 50
        ArrowAnnotation1.ArrowSize = 7
        ArrowAnnotation1.Name = "ArrowAnnotation1"
        ArrowAnnotation1.X = 50
        ArrowAnnotation1.Y = 20
        ImageAnnotation1.AllowMoving = True
        ImageAnnotation1.AllowSelecting = True
        ImageAnnotation1.AllowTextEditing = True
        ImageAnnotation1.Image = "C:\lucidcode\Development\lucidcode\ico\Lightened Dream\Action.Forward.bmp"
        ImageAnnotation1.ImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled
        ImageAnnotation1.Name = "ImageAnnotation1"
        ImageAnnotation1.ToolTip = "xxx"
        CalloutAnnotation1.AllowTextEditing = True
        CalloutAnnotation1.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
        CalloutAnnotation1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CalloutAnnotation1.ForeColor = System.Drawing.Color.SteelBlue
        CalloutAnnotation1.LineColor = System.Drawing.Color.LightSteelBlue
        CalloutAnnotation1.Name = "objCalloutCloud"
        CalloutAnnotation1.ShadowColor = System.Drawing.Color.SteelBlue
        CalloutAnnotation1.ShadowOffset = 1
        CalloutAnnotation1.Text = "Dj Tiesto - Lord of Trance"
        CalloutAnnotation1.X = 20
        CalloutAnnotation1.Y = 20
        CalloutAnnotation2.AllowAnchorMoving = True
        CalloutAnnotation2.BackColor = System.Drawing.Color.LightYellow
        CalloutAnnotation2.CalloutAnchorCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond
        CalloutAnnotation2.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
        CalloutAnnotation2.ClipToChartArea = "ChartArea1"
        CalloutAnnotation2.IsMultiline = True
        CalloutAnnotation2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        CalloutAnnotation2.LineWidth = 4
        CalloutAnnotation2.Name = "CalloutAnnotation3"
        CalloutAnnotation2.ShadowOffset = 2
        CalloutAnnotation2.Text = "xxxxxxxxxx bhh hh"
        CalloutAnnotation2.X = 40
        CalloutAnnotation2.Y = 10
        TextAnnotation1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        TextAnnotation1.IsMultiline = True
        TextAnnotation1.Name = "TextAnnotation1"
        TextAnnotation1.ShadowOffset = 2
        TextAnnotation1.Text = "TextAnnotation1"
        TextAnnotation1.X = 20
        TextAnnotation1.Y = 10
        PolygonAnnotation1.Name = "PolygonAnnotation1"
        AnnotationPathPoint1.PointType = CType(0, Byte)
        AnnotationPathPoint1.X = 5.0!
        AnnotationPathPoint1.Y = 5.0!
        AnnotationPathPoint2.X = 40.0!
        AnnotationPathPoint2.Y = 40.0!
        PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint1)
        PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint2)
        PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint3)
        PolylineAnnotation1.Name = "PolylineAnnotation1"
        Me.graph.Annotations.Add(Border3DAnnotation1)
        Me.graph.Annotations.Add(VerticalLineAnnotation1)
        Me.graph.Annotations.Add(LineAnnotation1)
        Me.graph.Annotations.Add(VerticalLineAnnotation2)
        Me.graph.Annotations.Add(ArrowAnnotation1)
        Me.graph.Annotations.Add(ImageAnnotation1)
        Me.graph.Annotations.Add(CalloutAnnotation1)
        Me.graph.Annotations.Add(CalloutAnnotation2)
        Me.graph.Annotations.Add(TextAnnotation1)
        Me.graph.Annotations.Add(PolygonAnnotation1)
        Me.graph.Annotations.Add(PolylineAnnotation1)
        Me.graph.BackColor = System.Drawing.Color.LightSteelBlue
        Me.graph.BorderlineWidth = 0
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 10
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.PointDepth = 300
        ChartArea1.Area3DStyle.PointGapDepth = 0
        ChartArea1.Area3DStyle.Rotation = 10
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 90
        ChartArea1.AxisX.LabelStyle.Interval = 0
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked
        CustomLabel1.Text = "x"
        CustomLabel2.Text = "x"
        ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1)
        ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2)
        ChartArea1.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.graph.ChartAreas.Add(ChartArea1)
        Me.graph.Location = New System.Drawing.Point(3, 3)
        Me.graph.Name = "graph"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Series1.LabelAngle = 90
        Series1.LabelBorderWidth = 0
        Series1.MarkerBorderWidth = 0
        Series1.Name = "DreamSeries"
        Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.graph.Series.Add(Series1)
        Me.graph.Size = New System.Drawing.Size(634, 364)
        Me.graph.TabIndex = 2
        '
        'Panel3D2
        '
        Me.Panel3D2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3D2.Controls.Add(Me.lstItems)
        Me.Panel3D2.Controls.Add(Me.Label1)
        Me.Panel3D2.Controls.Add(Me.cmbCycleLength)
        Me.Panel3D2.Controls.Add(Me.Label3)
        Me.Panel3D2.Controls.Add(Me.Label5)
        Me.Panel3D2.Controls.Add(Me.txtDescription)
        Me.Panel3D2.Controls.Add(Me.txtTitle)
        Me.Panel3D2.Controls.Add(Me.Label4)
        Me.Panel3D2.Controls.Add(Me.cmbCycles)
        Me.Panel3D2.Controls.Add(Me.Label11)
        Me.Panel3D2.Controls.Add(Me.txtTime)
        Me.Panel3D2.Controls.Add(Me.Panel3D4)
        Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D2.Name = "Panel3D2"
        Me.Panel3D2.Size = New System.Drawing.Size(640, 104)
        Me.Panel3D2.TabIndex = 8
        '
        'lstItems
        '
        Me.lstItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2})
        Me.lstItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItems.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lstItems.Location = New System.Drawing.Point(474, 31)
        Me.lstItems.MultiSelect = False
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(163, 70)
        Me.lstItems.SmallImageList = Me.lstImg
        Me.lstItems.TabIndex = 1
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        Me.lstItems.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Time"
        Me.ColumnHeader1.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File"
        Me.ColumnHeader2.Width = 249
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(296, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCycleLength
        '
        Me.cmbCycleLength.FormattingEnabled = True
        Me.cmbCycleLength.Items.AddRange(New Object() {"15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120"})
        Me.cmbCycleLength.Location = New System.Drawing.Point(232, 31)
        Me.cmbCycleLength.Name = "cmbCycleLength"
        Me.cmbCycleLength.Size = New System.Drawing.Size(44, 21)
        Me.cmbCycleLength.TabIndex = 10
        Me.cmbCycleLength.Text = "60"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(144, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cycle Length"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(94, 78)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(543, 21)
        Me.txtDescription.TabIndex = 32
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(94, 54)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(543, 21)
        Me.txtTitle.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(8, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(8, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Title"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'objPlayer
        '
        Me.objPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.objPlayer.Enabled = True
        Me.objPlayer.Location = New System.Drawing.Point(217, 28)
        Me.objPlayer.Name = "objPlayer"
        Me.objPlayer.OcxState = CType(resources.GetObject("objPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.objPlayer.Size = New System.Drawing.Size(284, 45)
        Me.objPlayer.TabIndex = 22
        Me.objPlayer.Visible = False
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3D1.Controls.Add(Me.graph)
        Me.Panel3D1.Controls.Add(Me.objPlayer)
        Me.Panel3D1.Location = New System.Drawing.Point(0, 110)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(640, 370)
        Me.Panel3D1.TabIndex = 9
        '
        'objOpenFileDialog
        '
        Me.objOpenFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*"
        Me.objOpenFileDialog.Title = "REM Cycles - Import"
        '
        'REMCyclesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
        Me.Controls.Add(Me.Panel3D1)
        Me.Controls.Add(Me.Panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.Name = "REMCyclesControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.mnuAnnotation.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D2.PerformLayout()
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents mnuAnnotation As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuAnnotationAdd As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuAnnotationCopy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAnnotationPaste As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAnnotationDelete As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cmbCycles As System.Windows.Forms.ComboBox
  Friend WithEvents txtTime As System.Windows.Forms.TextBox
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents objPlayer As AxWMPLib.AxWindowsMediaPlayer
  Friend WithEvents lstItems As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cmbCycleLength As System.Windows.Forms.ComboBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents txtDescription As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents mnuChecks As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuReadings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuRecordings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LoadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LoadingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LoadingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSubliminals As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LoadingToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents objOpenFileDialog As System.Windows.Forms.OpenFileDialog
  Friend WithEvents mnuAnnotationPlay As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents tmrWatch As System.Windows.Forms.Timer
  Public WithEvents txtTitle As System.Windows.Forms.TextBox

End Class
