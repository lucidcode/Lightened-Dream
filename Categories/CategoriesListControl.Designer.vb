<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriesListControl
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
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 1.0R)
    Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 2.0R)
    Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim CustomLabel3 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel4 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 1.0R)
    Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 2.0R)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D()
    Me.graphDozen = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.lstCategories = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.lblDescription = New System.Windows.Forms.Label()
    Me.Panel3D4 = New lucidcode.Controls.Panel3D()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.lblType = New System.Windows.Forms.Label()
    Me.Panel3D2.SuspendLayout()
    CType(Me.graphDozen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.graphDozen)
    Me.Panel3D2.Controls.Add(Me.lstCategories)
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.lblDescription)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.TabIndex = 7
    '
    'graphDozen
    '
    Me.graphDozen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.graphDozen.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor
    ChartArea1.Area3DStyle.Enable3D = True
    ChartArea1.Area3DStyle.Inclination = 10
    ChartArea1.Area3DStyle.PointDepth = 50
    ChartArea1.Area3DStyle.PointGapDepth = 50
    ChartArea1.Area3DStyle.Rotation = 10
    ChartArea1.Area3DStyle.WallWidth = 0
    ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisX.LabelStyle.Interval = 0.0R
    ChartArea1.AxisX.MajorGrid.Enabled = False
    ChartArea1.AxisX.MajorTickMark.Enabled = False
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2)
    ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.BackColor = System.Drawing.Color.LightSteelBlue
    ChartArea1.Name = "ChartArea1"
    Me.graphDozen.ChartAreas.Add(ChartArea1)
    Me.graphDozen.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.graphDozen.Location = New System.Drawing.Point(3, 30)
    Me.graphDozen.Name = "graphDozen"
    Me.graphDozen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
    Series1.ChartArea = "ChartArea1"
    Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
    Series1.CustomProperties = "BarLabelStyle=Outside"
    Series1.Font = New System.Drawing.Font("Verdana", 8.25!)
    Series1.LabelForeColor = System.Drawing.Color.MidnightBlue
    Series1.Name = "DreamSeries"
    DataPoint1.AxisLabel = "yyy"
    DataPoint2.AxisLabel = "xxx"
    DataPoint2.Label = "x"
    DataPoint2.LegendText = "xx"
    DataPoint2.ToolTip = "xx"
    Series1.Points.Add(DataPoint1)
    Series1.Points.Add(DataPoint2)
    Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
    Series1.SmartLabelStyle.MaxMovingDistance = 50.0R
    Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
    Me.graphDozen.Series.Add(Series1)
    Me.graphDozen.Size = New System.Drawing.Size(634, 447)
    Me.graphDozen.TabIndex = 24
    Me.graphDozen.Visible = False
    '
    'lstCategories
    '
    Me.lstCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstCategories.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.lstCategories.Location = New System.Drawing.Point(435, 49)
    Me.lstCategories.MultiSelect = False
    Me.lstCategories.Name = "lstCategories"
    Me.lstCategories.Size = New System.Drawing.Size(172, 167)
    Me.lstCategories.TabIndex = 1
    Me.lstCategories.UseCompatibleStateImageBehavior = False
    Me.lstCategories.View = System.Windows.Forms.View.Details
    Me.lstCategories.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Category"
    Me.ColumnHeader1.Width = 124
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Entries"
    Me.ColumnHeader2.Width = 74
    '
    'graph
    '
    Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.graph.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor
    ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea2.AxisX.LabelStyle.Interval = 0.0R
    ChartArea2.AxisX.Title = "Dreams"
    CustomLabel3.Text = "x"
    CustomLabel4.Text = "x"
    ChartArea2.AxisX2.CustomLabels.Add(CustomLabel3)
    ChartArea2.AxisX2.CustomLabels.Add(CustomLabel4)
    ChartArea2.AxisX2.Title = "x"
    ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea2.BackColor = System.Drawing.Color.LightSteelBlue
    ChartArea2.Name = "ChartArea1"
    Me.graph.ChartAreas.Add(ChartArea2)
    Me.graph.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.graph.Location = New System.Drawing.Point(3, 30)
    Me.graph.Name = "graph"
    Me.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
    Series2.ChartArea = "ChartArea1"
    Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
    Series2.Font = New System.Drawing.Font("Verdana", 8.25!)
    Series2.Name = "DreamSeries"
    DataPoint3.AxisLabel = "yyy"
    DataPoint4.AxisLabel = "xxx"
    DataPoint4.Label = "x"
    DataPoint4.LegendText = "xx"
    DataPoint4.ToolTip = "xx"
    Series2.Points.Add(DataPoint3)
    Series2.Points.Add(DataPoint4)
    Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
    Me.graph.Series.Add(Series2)
    Me.graph.Size = New System.Drawing.Size(634, 447)
    Me.graph.TabIndex = 1
    '
    'lblDescription
    '
    Me.lblDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblDescription.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lblDescription.Location = New System.Drawing.Point(8, 27)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(621, 31)
    Me.lblDescription.TabIndex = 23
    Me.lblDescription.Text = "Dream"
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.lblType)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(640, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
    Me.lblTitle.ForeColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleForeColor
    Me.lblTitle.Location = New System.Drawing.Point(8, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(628, 19)
    Me.lblTitle.TabIndex = 2
    Me.lblTitle.Text = "Categories"
    Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblType
    '
    Me.lblType.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
    Me.lblType.ForeColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleForeColor
    Me.lblType.Location = New System.Drawing.Point(8, 3)
    Me.lblType.Name = "lblType"
    Me.lblType.Size = New System.Drawing.Size(90, 19)
    Me.lblType.TabIndex = 3
    Me.lblType.Text = "Category"
    Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'CategoriesListControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.Font
    Me.ForeColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormForeColor
    Me.Name = "CategoriesListControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.ResumeLayout(False)
    CType(Me.graphDozen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Public WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents lblType As System.Windows.Forms.Label
  Friend WithEvents lstCategories As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents graphDozen As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
