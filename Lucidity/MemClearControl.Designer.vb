<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemClearControl
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
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel3 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel4 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 0)
    Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 0)
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.lstDreams = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
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
    CustomLabel1.FromPosition = 0.5
    CustomLabel1.Text = "2009/11"
    CustomLabel1.ToPosition = 1.5
    CustomLabel2.FromPosition = 1.5
    CustomLabel2.Text = "2009/12"
    CustomLabel2.ToPosition = 2.5
    ChartArea1.AxisX.CustomLabels.Add(CustomLabel1)
    ChartArea1.AxisX.CustomLabels.Add(CustomLabel2)
    ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisX.IsLabelAutoFit = False
    ChartArea1.AxisX.LabelStyle.Angle = 90
    ChartArea1.AxisX.LabelStyle.Interval = 0
    CustomLabel3.Text = "x"
    CustomLabel4.Text = "x"
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel3)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel4)
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
    ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.IsStartedFromZero = False
    ChartArea1.AxisY2.LabelStyle.Enabled = False
    ChartArea1.AxisY2.MajorGrid.Enabled = False
    ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
    ChartArea1.AxisY2.MajorTickMark.Enabled = False
    ChartArea1.AxisY2.Maximum = 1200
    ChartArea1.AxisY2.Minimum = -1200
    ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave
    ChartArea1.AxisY2.ScaleBreakStyle.Enabled = True
    ChartArea1.BackColor = System.Drawing.Color.White
    ChartArea1.BackImageTransparentColor = System.Drawing.Color.White
    ChartArea1.BackSecondaryColor = System.Drawing.Color.White
    ChartArea1.BorderColor = System.Drawing.Color.White
    ChartArea1.Name = "ChartArea1"
    ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.graph.ChartAreas.Add(ChartArea1)
    Me.graph.Location = New System.Drawing.Point(3, 30)
    Me.graph.Name = "graph"
    Series1.ChartArea = "ChartArea1"
    Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
    Series1.Name = "Series2"
    Series1.Points.Add(DataPoint1)
    Series1.Points.Add(DataPoint2)
    Me.graph.Series.Add(Series1)
    Me.graph.Size = New System.Drawing.Size(1007, 582)
    Me.graph.TabIndex = 1
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.lstDreams)
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(1013, 615)
    Me.Panel3D2.TabIndex = 8
    '
    'lstDreams
    '
    Me.lstDreams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstDreams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
    Me.lstDreams.FullRowSelect = True
    Me.lstDreams.Location = New System.Drawing.Point(191, 30)
    Me.lstDreams.MultiSelect = False
    Me.lstDreams.Name = "lstDreams"
    Me.lstDreams.Size = New System.Drawing.Size(708, 28)
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
    Me.ColumnHeader2.Width = 72
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Words"
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Sleep"
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Awake"
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
    Me.Panel3D4.BackColor = MySettings1.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.Label2)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(1013, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.ForeColor = MySettings1.TitleForeColor
    Me.lblTitle.Location = New System.Drawing.Point(7, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(1003, 19)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Clear Memory - Day"
    Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = MySettings1.TitleForeColor
    Me.Label2.Location = New System.Drawing.Point(8, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 19)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Dream"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'MemClearControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = MySettings1.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", MySettings1, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = MySettings1.Font
    Me.ForeColor = MySettings1.FormForeColor
    Me.Name = "MemClearControl"
    Me.Size = New System.Drawing.Size(1013, 615)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents lstDreams As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class
