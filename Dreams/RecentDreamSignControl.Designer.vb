<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecentDreamSignControl
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
    Me.components = New System.ComponentModel.Container()
    Dim ChartArea16 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim CustomLabel31 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel32 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim ChartArea15 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim CustomLabel29 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel30 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecentDreamSignControl))
    Me.lstDreams = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D()
    Me.pnlSearching = New lucidcode.Controls.Panel3D()
    Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.Panel3D4 = New lucidcode.Controls.Panel3D()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
    Me.mnuCategories = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuIgnore = New System.Windows.Forms.ToolStripMenuItem()
    Me.tmrDreamSigns = New System.Windows.Forms.Timer(Me.components)
    Me.tmrSearching = New System.Windows.Forms.Timer(Me.components)
    Me.tmrDreamTypes = New System.Windows.Forms.Timer(Me.components)
    Me.Label11 = New System.Windows.Forms.Label()
    Me.cmbFromYear = New System.Windows.Forms.ComboBox()
    Me.cmbFromMonth = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmbToMonth = New System.Windows.Forms.ComboBox()
    Me.cmbToYear = New System.Windows.Forms.ComboBox()
    Me.Panel3D2.SuspendLayout()
    Me.pnlSearching.SuspendLayout()
    CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.mnuCategories.SuspendLayout()
    Me.SuspendLayout()
    '
    'lstDreams
    '
    Me.lstDreams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstDreams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
    Me.lstDreams.FullRowSelect = True
    Me.lstDreams.Location = New System.Drawing.Point(484, 30)
    Me.lstDreams.MultiSelect = False
    Me.lstDreams.Name = "lstDreams"
    Me.lstDreams.Size = New System.Drawing.Size(226, 244)
    Me.lstDreams.TabIndex = 2
    Me.lstDreams.UseCompatibleStateImageBehavior = False
    Me.lstDreams.View = System.Windows.Forms.View.Details
    Me.lstDreams.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Date"
    Me.ColumnHeader1.Width = 124
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Title"
    Me.ColumnHeader2.Width = 296
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Words"
    '
    'Panel3D2
    '
    Me.Panel3D2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D2.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Panel3D2.Controls.Add(Me.cmbToMonth)
    Me.Panel3D2.Controls.Add(Me.cmbToYear)
    Me.Panel3D2.Controls.Add(Me.Label1)
    Me.Panel3D2.Controls.Add(Me.cmbFromMonth)
    Me.Panel3D2.Controls.Add(Me.cmbFromYear)
    Me.Panel3D2.Controls.Add(Me.Label11)
    Me.Panel3D2.Controls.Add(Me.pnlSearching)
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.lstDreams)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.TabIndex = 8
    '
    'pnlSearching
    '
    Me.pnlSearching.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlSearching.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.pnlSearching.Controls.Add(Me.Chart1)
    Me.pnlSearching.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlSearching.Location = New System.Drawing.Point(3, 438)
    Me.pnlSearching.Name = "pnlSearching"
    Me.pnlSearching.Size = New System.Drawing.Size(634, 39)
    Me.pnlSearching.TabIndex = 19
    '
    'Chart1
    '
    Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Chart1.BackColor = System.Drawing.Color.Transparent
    ChartArea16.Area3DStyle.Enable3D = True
    ChartArea16.Area3DStyle.Inclination = 10
    ChartArea16.Area3DStyle.IsClustered = True
    ChartArea16.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
    ChartArea16.Area3DStyle.PointDepth = 200
    ChartArea16.Area3DStyle.PointGapDepth = 0
    ChartArea16.Area3DStyle.Rotation = 10
    ChartArea16.Area3DStyle.WallWidth = 0
    ChartArea16.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea16.AxisX.IsLabelAutoFit = False
    ChartArea16.AxisX.LabelStyle.Angle = 90
    ChartArea16.AxisX.LabelStyle.Enabled = False
    ChartArea16.AxisX.LabelStyle.Interval = 0.0R
    ChartArea16.AxisX.LineColor = System.Drawing.Color.Transparent
    ChartArea16.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
    ChartArea16.AxisX.LineWidth = 0
    ChartArea16.AxisX.MajorGrid.Enabled = False
    ChartArea16.AxisX.MajorGrid.LineWidth = 0
    ChartArea16.AxisX.MajorTickMark.Enabled = False
    ChartArea16.AxisX.MajorTickMark.LineWidth = 0
    ChartArea16.AxisX.MajorTickMark.Size = 0.0!
    ChartArea16.AxisX.MinorGrid.LineWidth = 0
    ChartArea16.AxisX.MinorTickMark.LineWidth = 0
    ChartArea16.AxisX.MinorTickMark.Size = 0.0!
    ChartArea16.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue
    CustomLabel31.Text = "x"
    CustomLabel32.Text = "x"
    ChartArea16.AxisX2.CustomLabels.Add(CustomLabel31)
    ChartArea16.AxisX2.CustomLabels.Add(CustomLabel32)
    ChartArea16.AxisX2.LineWidth = 0
    ChartArea16.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea16.AxisY.LabelStyle.Enabled = False
    ChartArea16.AxisY.LineWidth = 0
    ChartArea16.AxisY.MajorGrid.Enabled = False
    ChartArea16.AxisY.MajorTickMark.Enabled = False
    ChartArea16.AxisY.TitleForeColor = System.Drawing.Color.LightSteelBlue
    ChartArea16.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
    ChartArea16.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
    ChartArea16.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea16.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea16.AxisY2.LineWidth = 0
    ChartArea16.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
    ChartArea16.AxisY2.Maximum = 11.0R
    ChartArea16.AxisY2.Minimum = -11.0R
    ChartArea16.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave
    ChartArea16.AxisY2.ScaleBreakStyle.Enabled = True
    ChartArea16.BackColor = System.Drawing.Color.LightSteelBlue
    ChartArea16.BackImageTransparentColor = System.Drawing.Color.White
    ChartArea16.BackSecondaryColor = System.Drawing.Color.Transparent
    ChartArea16.BorderColor = System.Drawing.Color.LightSteelBlue
    ChartArea16.BorderWidth = 0
    ChartArea16.Name = "ChartArea1"
    ChartArea16.ShadowColor = System.Drawing.Color.Transparent
    Me.Chart1.ChartAreas.Add(ChartArea16)
    Me.Chart1.Location = New System.Drawing.Point(3, 3)
    Me.Chart1.Name = "Chart1"
    Series24.ChartArea = "ChartArea1"
    Series24.Name = "Series1"
    Me.Chart1.Series.Add(Series24)
    Me.Chart1.Size = New System.Drawing.Size(628, 33)
    Me.Chart1.TabIndex = 283
    '
    'graph
    '
    Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.graph.BackColor = System.Drawing.Color.Transparent
    ChartArea15.Area3DStyle.Enable3D = True
    ChartArea15.Area3DStyle.Inclination = 10
    ChartArea15.Area3DStyle.IsClustered = True
    ChartArea15.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
    ChartArea15.Area3DStyle.PointGapDepth = 0
    ChartArea15.Area3DStyle.Rotation = 10
    ChartArea15.Area3DStyle.WallWidth = 0
    ChartArea15.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea15.AxisX.IsLabelAutoFit = False
    ChartArea15.AxisX.LabelStyle.Angle = 90
    ChartArea15.AxisX.LabelStyle.Enabled = False
    ChartArea15.AxisX.LabelStyle.Interval = 0.0R
    ChartArea15.AxisX.MajorGrid.Enabled = False
    ChartArea15.AxisX.MajorTickMark.Enabled = False
    CustomLabel29.Text = "x"
    CustomLabel30.Text = "x"
    ChartArea15.AxisX2.CustomLabels.Add(CustomLabel29)
    ChartArea15.AxisX2.CustomLabels.Add(CustomLabel30)
    ChartArea15.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea15.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
    ChartArea15.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
    ChartArea15.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea15.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea15.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
    ChartArea15.AxisY2.Maximum = 11.0R
    ChartArea15.AxisY2.Minimum = -11.0R
    ChartArea15.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave
    ChartArea15.AxisY2.ScaleBreakStyle.Enabled = True
    ChartArea15.BackColor = System.Drawing.Color.White
    ChartArea15.BackImageTransparentColor = System.Drawing.Color.White
    ChartArea15.BackSecondaryColor = System.Drawing.Color.White
    ChartArea15.BorderColor = System.Drawing.Color.White
    ChartArea15.Name = "ChartArea1"
    ChartArea15.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.graph.ChartAreas.Add(ChartArea15)
    Me.graph.Location = New System.Drawing.Point(3, 58)
    Me.graph.Name = "graph"
    Series22.ChartArea = "ChartArea1"
    Series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
    Series22.Name = "Series2"
    Series23.ChartArea = "ChartArea1"
    Series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
    Series23.Name = "Series3"
    Me.graph.Series.Add(Series22)
    Me.graph.Series.Add(Series23)
    Me.graph.Size = New System.Drawing.Size(634, 374)
    Me.graph.TabIndex = 6
    Me.graph.Visible = False
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.Label2)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(640, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.lblTitle.Location = New System.Drawing.Point(7, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(630, 19)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Recent Dream Signs"
    Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label2.Location = New System.Drawing.Point(8, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 19)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Dream"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstImgTlb
    '
    Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
    Me.lstImgTlb.Images.SetKeyName(0, "File.Dream.Search.3.bmp")
    Me.lstImgTlb.Images.SetKeyName(1, "File.Dream.Search.Clear.bmp")
    '
    'mnuCategories
    '
    Me.mnuCategories.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIgnore})
    Me.mnuCategories.Name = "mnuCategories"
    Me.mnuCategories.Size = New System.Drawing.Size(109, 26)
    '
    'mnuIgnore
    '
    Me.mnuIgnore.Name = "mnuIgnore"
    Me.mnuIgnore.Size = New System.Drawing.Size(108, 22)
    Me.mnuIgnore.Text = "&Ignore"
    '
    'tmrDreamSigns
    '
    '
    'tmrSearching
    '
    Me.tmrSearching.Interval = 128
    '
    'tmrDreamTypes
    '
    '
    'Label11
    '
    Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label11.Location = New System.Drawing.Point(8, 30)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(74, 21)
    Me.Label11.TabIndex = 32
    Me.Label11.Text = "Date Range"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cmbFromYear
    '
    Me.cmbFromYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbFromYear.FormattingEnabled = True
    Me.cmbFromYear.Items.AddRange(New Object() {"2014"})
    Me.cmbFromYear.Location = New System.Drawing.Point(88, 31)
    Me.cmbFromYear.Name = "cmbFromYear"
    Me.cmbFromYear.Size = New System.Drawing.Size(56, 21)
    Me.cmbFromYear.TabIndex = 33
    '
    'cmbFromMonth
    '
    Me.cmbFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbFromMonth.FormattingEnabled = True
    Me.cmbFromMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cmbFromMonth.Location = New System.Drawing.Point(150, 31)
    Me.cmbFromMonth.Name = "cmbFromMonth"
    Me.cmbFromMonth.Size = New System.Drawing.Size(38, 21)
    Me.cmbFromMonth.TabIndex = 34
    '
    'Label1
    '
    Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label1.Location = New System.Drawing.Point(194, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(11, 21)
    Me.Label1.TabIndex = 35
    Me.Label1.Text = "-"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cmbToMonth
    '
    Me.cmbToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbToMonth.FormattingEnabled = True
    Me.cmbToMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cmbToMonth.Location = New System.Drawing.Point(273, 31)
    Me.cmbToMonth.Name = "cmbToMonth"
    Me.cmbToMonth.Size = New System.Drawing.Size(38, 21)
    Me.cmbToMonth.TabIndex = 37
    '
    'cmbToYear
    '
    Me.cmbToYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbToYear.FormattingEnabled = True
    Me.cmbToYear.Items.AddRange(New Object() {"2014"})
    Me.cmbToYear.Location = New System.Drawing.Point(211, 31)
    Me.cmbToYear.Name = "cmbToYear"
    Me.cmbToYear.Size = New System.Drawing.Size(56, 21)
    Me.cmbToYear.TabIndex = 36
    '
    'RecentDreamSignControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font
    Me.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor
    Me.Name = "RecentDreamSignControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.ResumeLayout(False)
    Me.pnlSearching.ResumeLayout(False)
    CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D4.ResumeLayout(False)
    Me.mnuCategories.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lstDreams As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents mnuCategories As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents tmrDreamSigns As System.Windows.Forms.Timer
  Friend WithEvents pnlSearching As lucidcode.Controls.Panel3D
  Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents tmrSearching As System.Windows.Forms.Timer
  Friend WithEvents mnuIgnore As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents tmrDreamTypes As System.Windows.Forms.Timer
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents cmbToMonth As System.Windows.Forms.ComboBox
  Friend WithEvents cmbToYear As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cmbFromMonth As System.Windows.Forms.ComboBox
  Friend WithEvents cmbFromYear As System.Windows.Forms.ComboBox

End Class
