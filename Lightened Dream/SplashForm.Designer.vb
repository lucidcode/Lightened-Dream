<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashForm))
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panel3D2 = New lucidcode.Controls.Panel3D()
        CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3D2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 10
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
        ChartArea1.AxisX.LabelStyle.Interval = 0.0R
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
        ChartArea1.AxisY2.Maximum = 11.0R
        ChartArea1.AxisY2.Minimum = -11.0R
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
        Me.graph.Location = New System.Drawing.Point(2, 2)
        Me.graph.Name = "graph"
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.graph.Series.Add(Series1)
        Me.graph.Size = New System.Drawing.Size(636, 476)
        Me.graph.TabIndex = 2
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Font = New System.Drawing.Font("Viner Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.SteelBlue
        Title1.Name = "Title1"
        Title1.ShadowColor = System.Drawing.Color.White
        Title1.ShadowOffset = 2
        Title1.Text = "Lightened Dream"
        Me.graph.Titles.Add(Title1)
        '
        'panel3D2
        '
        Me.panel3D2.Controls.Add(Me.graph)
        Me.panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3D2.Location = New System.Drawing.Point(0, 0)
        Me.panel3D2.Name = "panel3D2"
        Me.panel3D2.Size = New System.Drawing.Size(640, 480)
        Me.panel3D2.TabIndex = 17
        '
        'SplashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lightened Dream"
        Me.TopMost = True
        CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3D2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
    Friend WithEvents panel3D2 As lucidcode.Controls.Panel3D
    Private WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
