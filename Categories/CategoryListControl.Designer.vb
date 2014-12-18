<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryListControl
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
    Me.Panel3D2 = New lucidcode.Controls.Panel3D()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.lblT = New System.Windows.Forms.Label()
    Me.lstCategories = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.Panel3D4 = New lucidcode.Controls.Panel3D()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.Panel3D2.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.txtName)
    Me.Panel3D2.Controls.Add(Me.lblT)
    Me.Panel3D2.Controls.Add(Me.lstCategories)
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.TabIndex = 7
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(50, 27)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(234, 21)
    Me.txtName.TabIndex = 32
    Me.txtName.Visible = False
    '
    'lblT
    '
    Me.lblT.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lblT.Location = New System.Drawing.Point(5, 27)
    Me.lblT.Name = "lblT"
    Me.lblT.Size = New System.Drawing.Size(39, 21)
    Me.lblT.TabIndex = 33
    Me.lblT.Text = "Title"
    Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lblT.Visible = False
    '
    'lstCategories
    '
    Me.lstCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstCategories.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.lstCategories.Location = New System.Drawing.Point(162, 62)
    Me.lstCategories.MultiSelect = False
    Me.lstCategories.Name = "lstCategories"
    Me.lstCategories.Size = New System.Drawing.Size(317, 222)
    Me.lstCategories.TabIndex = 1
    Me.lstCategories.UseCompatibleStateImageBehavior = False
    Me.lstCategories.View = System.Windows.Forms.View.Details
    Me.lstCategories.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Entry"
    Me.ColumnHeader1.Width = 124
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Dreams"
    Me.ColumnHeader2.Width = 74
    '
    'graph
    '
    Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.graph.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor
    ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisX.LabelStyle.Interval = 0.0R
    CustomLabel1.Text = "x"
    CustomLabel2.Text = "x"
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2)
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.Name = "ChartArea1"
    Me.graph.ChartAreas.Add(ChartArea1)
    Me.graph.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.graph.Location = New System.Drawing.Point(3, 30)
    Me.graph.Name = "graph"
    Me.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
    Series1.ChartArea = "ChartArea1"
    Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
    Series1.Font = New System.Drawing.Font("Verdana", 8.25!)
    Series1.Name = "DreamSeries"
    DataPoint1.AxisLabel = "yyy"
    DataPoint2.AxisLabel = "xxx"
    DataPoint2.Label = "x"
    DataPoint2.LegendText = "xx"
    DataPoint2.ToolTip = "xx"
    Series1.Points.Add(DataPoint1)
    Series1.Points.Add(DataPoint2)
    Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
    Me.graph.Series.Add(Series1)
    Me.graph.Size = New System.Drawing.Size(634, 447)
    Me.graph.TabIndex = 1
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
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
    'CategoryListControl
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
    Me.Name = "CategoryListControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D2.PerformLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Friend WithEvents lstCategories As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents lblT As System.Windows.Forms.Label
  Public WithEvents txtName As System.Windows.Forms.TextBox

End Class
