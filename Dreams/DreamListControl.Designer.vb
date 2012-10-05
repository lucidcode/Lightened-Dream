<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DreamListControl
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
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.lstDreams = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
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
    Me.graph.BackColor = System.Drawing.Color.LightSteelBlue
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
    ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.White
    ChartArea1.AxisX.IsLabelAutoFit = False
    ChartArea1.AxisX.LabelStyle.Angle = 90
    ChartArea1.AxisX.LabelStyle.Interval = 0
    CustomLabel3.Text = "x"
    CustomLabel4.Text = "x"
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel3)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel4)
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.BackColor = System.Drawing.Color.White
    ChartArea1.Name = "ChartArea1"
    ChartArea1.ShadowColor = System.Drawing.Color.White
    Me.graph.ChartAreas.Add(ChartArea1)
    Me.graph.Location = New System.Drawing.Point(3, 30)
    Me.graph.Name = "graph"
    Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
    Series1.BackSecondaryColor = System.Drawing.Color.Black
    Series1.BorderColor = System.Drawing.Color.Black
    Series1.ChartArea = "ChartArea1"
    Series1.Color = System.Drawing.Color.LightSteelBlue
    Series1.CustomProperties = "StackedGroupName=_X_Secondary_Y_Primary__"
    Series1.Font = New System.Drawing.Font("Verdana", 8.25!)
    Series1.Name = "DreamSeries"
    Series1.ShadowOffset = 1
    Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
    Series2.BorderColor = System.Drawing.Color.Black
    Series2.ChartArea = "ChartArea1"
    Series2.Name = "Series2"
    Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
    Me.graph.Series.Add(Series1)
    Me.graph.Series.Add(Series2)
    Me.graph.Size = New System.Drawing.Size(634, 447)
    Me.graph.TabIndex = 1
    '
    'lstDreams
    '
    Me.lstDreams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstDreams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
    Me.lstDreams.FullRowSelect = True
    Me.lstDreams.Location = New System.Drawing.Point(367, 40)
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
        Me.Panel3D2.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
        Me.Panel3D2.Controls.Add(Me.lstDreams)
        Me.Panel3D2.Controls.Add(Me.Panel3D4)
        Me.Panel3D2.Controls.Add(Me.graph)
        Me.Panel3D2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D2.Name = "Panel3D2"
        Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
        Me.Panel3D2.TabIndex = 8
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
        Me.lblTitle.Text = "Dreams - Year"
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
    'YearListControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel3D2)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.Name = "YearListControl"
    Me.Size = New System.Drawing.Size(640, 480)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
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
  Private WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
