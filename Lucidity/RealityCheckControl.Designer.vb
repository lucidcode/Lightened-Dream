<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealityCheckControl
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
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"00:30", "DJ Tiesto - Lord of Trance"}, 0)
    Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("02:00")
    Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("03:30")
    Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("05:00")
    Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("06:30")
    Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("08:00")
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealityCheckControl))
    Dim Border3DAnnotation1 As System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation = New System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Me.cmbCycles = New System.Windows.Forms.ComboBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.dtStart = New System.Windows.Forms.DateTimePicker
    Me.Label4 = New System.Windows.Forms.Label
    Me.ListView1 = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Panel3D2.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmbCycles
    '
    Me.cmbCycles.FormattingEnabled = True
    Me.cmbCycles.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8"})
    Me.cmbCycles.Location = New System.Drawing.Point(378, 27)
    Me.cmbCycles.Name = "cmbCycles"
    Me.cmbCycles.Size = New System.Drawing.Size(96, 21)
    Me.cmbCycles.TabIndex = 10
    Me.cmbCycles.Text = "6"
    '
    'Label5
    '
    Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label5.Location = New System.Drawing.Point(244, 27)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(128, 21)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Cycles"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtStart
    '
    Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
    Me.dtStart.Location = New System.Drawing.Point(142, 27)
    Me.dtStart.Name = "dtStart"
    Me.dtStart.Size = New System.Drawing.Size(96, 21)
    Me.dtStart.TabIndex = 5
    Me.dtStart.Value = New Date(2009, 12, 2, 23, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label4.Location = New System.Drawing.Point(8, 27)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(128, 21)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Start Time"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ListView1
    '
    Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
    Me.ListView1.Location = New System.Drawing.Point(9, 51)
    Me.ListView1.MultiSelect = False
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(619, 174)
    Me.ListView1.SmallImageList = Me.lstImg
    Me.ListView1.TabIndex = 1
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
    Me.ListView1.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Time"
    Me.ColumnHeader1.Width = 97
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "File"
    Me.ColumnHeader2.Width = 249
    '
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "Sounds.ico")
    '
    'Panel3D2
    '
        Me.Panel3D2.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
        Me.Panel3D2.Controls.Add(Me.graph)
        Me.Panel3D2.Controls.Add(Me.cmbCycles)
        Me.Panel3D2.Controls.Add(Me.Panel3D4)
        Me.Panel3D2.Controls.Add(Me.Label5)
        Me.Panel3D2.Controls.Add(Me.dtStart)
        Me.Panel3D2.Controls.Add(Me.Label4)
        Me.Panel3D2.Controls.Add(Me.ListView1)
        Me.Panel3D2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D2.Name = "Panel3D2"
        Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
        Me.Panel3D2.TabIndex = 8
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
        Border3DAnnotation1.BackColor = System.Drawing.Color.LightSteelBlue
        Border3DAnnotation1.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Border3DAnnotation1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
        Border3DAnnotation1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Border3DAnnotation1.ForeColor = System.Drawing.Color.MidnightBlue
        Border3DAnnotation1.IsMultiline = True
        Border3DAnnotation1.LineColor = System.Drawing.Color.Empty
        Border3DAnnotation1.Name = "Border3DAnnotation1"
        Border3DAnnotation1.Text = "Tiesto - Lord of Trance"
        Me.graph.Annotations.Add(Border3DAnnotation1)
        Me.graph.BackColor = System.Drawing.Color.Transparent
        Me.graph.BorderlineWidth = 0
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 0
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
        Me.graph.Location = New System.Drawing.Point(3, 110)
        Me.graph.Name = "graph"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
        Series1.Name = "Series2"
        Series1.YValuesPerPoint = 6
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Series2.LabelAngle = 90
        Series2.LabelBorderWidth = 0
        Series2.MarkerBorderWidth = 0
        Series2.Name = "DreamSeries"
        Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.graph.Series.Add(Series1)
        Me.graph.Series.Add(Series2)
        Me.graph.Size = New System.Drawing.Size(634, 342)
        Me.graph.TabIndex = 11
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
    Me.lblTitle.Text = "Reality Check"
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
    'RealityCheckControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel3D2)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.Name = "RealityCheckControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.ResumeLayout(False)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cmbCycles As System.Windows.Forms.ComboBox
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
