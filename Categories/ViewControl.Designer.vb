<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewControl
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewControl))
    Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
    Dim CustomLabel5 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel6 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel7 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim CustomLabel8 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
    Me.lstImgDreams = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.lstDreams = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.Label12 = New System.Windows.Forms.Label
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
    Me.txtKeywords = New System.Windows.Forms.TextBox
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.lblType = New System.Windows.Forms.Label
    Me.txtName = New System.Windows.Forms.TextBox
    Me.txtDescription = New System.Windows.Forms.TextBox
    Me.Panel3D2.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'lstImgDreams
    '
    Me.lstImgDreams.ImageStream = CType(resources.GetObject("lstImgDreams.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgDreams.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImgDreams.Images.SetKeyName(0, "Dream4.ico")
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.Label2)
    Me.Panel3D2.Controls.Add(Me.Label1)
    Me.Panel3D2.Controls.Add(Me.lstDreams)
    Me.Panel3D2.Controls.Add(Me.Label12)
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.txtKeywords)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Controls.Add(Me.txtName)
    Me.Panel3D2.Controls.Add(Me.txtDescription)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.TabIndex = 7
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(8, 81)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(77, 21)
    Me.Label2.TabIndex = 32
    Me.Label2.Text = "Description"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(8, 54)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(77, 21)
    Me.Label1.TabIndex = 31
    Me.Label1.Text = "Words"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstDreams
    '
    Me.lstDreams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDreams.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.TextBackColor
        Me.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDreams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstDreams.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lstDreams.FullRowSelect = True
        Me.lstDreams.Location = New System.Drawing.Point(353, 51)
        Me.lstDreams.MultiSelect = False
        Me.lstDreams.Name = "lstDreams"
        Me.lstDreams.Size = New System.Drawing.Size(270, 136)
        Me.lstDreams.SmallImageList = Me.lstImgDreams
        Me.lstDreams.TabIndex = 1
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
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 21)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Title"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'graph
        '
        Me.graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graph.BackColor = Global.lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.Inclination = 10
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.PointDepth = 200
        ChartArea2.Area3DStyle.PointGapDepth = 0
        ChartArea2.Area3DStyle.Rotation = 10
        ChartArea2.Area3DStyle.WallWidth = 0
        CustomLabel5.FromPosition = 0.5
        CustomLabel5.Text = "2009/11"
        CustomLabel5.ToPosition = 1.5
        CustomLabel6.FromPosition = 1.5
        CustomLabel6.Text = "2009/12"
        CustomLabel6.ToPosition = 2.5
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel5)
        ChartArea2.AxisX.CustomLabels.Add(CustomLabel6)
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = 90
        ChartArea2.AxisX.LabelStyle.Interval = 0
        ChartArea2.AxisX.Title = "Dreams"
        CustomLabel7.Text = "x"
        CustomLabel8.Text = "x"
        ChartArea2.AxisX2.CustomLabels.Add(CustomLabel7)
        ChartArea2.AxisX2.CustomLabels.Add(CustomLabel8)
        ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.White
        Me.graph.ChartAreas.Add(ChartArea2)
        Me.graph.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.graph.Location = New System.Drawing.Point(3, 137)
        Me.graph.Name = "graph"
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Series2.Name = "DreamSeries"
        Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.graph.Series.Add(Series2)
        Me.graph.Size = New System.Drawing.Size(633, 340)
        Me.graph.TabIndex = 0
        Me.graph.TabStop = False
        '
        'txtKeywords
        '
        Me.txtKeywords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeywords.Location = New System.Drawing.Point(91, 54)
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(542, 21)
        Me.txtKeywords.TabIndex = 1
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
        Me.lblTitle.Text = "Title"
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
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(91, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(542, 21)
        Me.txtName.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(91, 81)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(541, 41)
        Me.txtDescription.TabIndex = 2
        '
        'ViewControl
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
    Me.Name = "ViewControl"
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
  Public WithEvents lblType As System.Windows.Forms.Label
  Friend WithEvents lstDreams As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents lstImgDreams As System.Windows.Forms.ImageList
  Public WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents txtDescription As System.Windows.Forms.TextBox
  Public WithEvents txtKeywords As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
