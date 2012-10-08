<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageBrowserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageBrowserForm))
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
        Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.Panel3D1 = New lucidcode.Controls.Panel3D
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3D3 = New lucidcode.Controls.Panel3D
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKeywords = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tmrSearching = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3D2 = New lucidcode.Controls.Panel3D
        Me.lstImages = New lucidcode.LightenedDream.Dreams.ListViewNF
        Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlSearching = New lucidcode.Controls.Panel3D
        Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.lblRAC = New System.Windows.Forms.LinkLabel
        Me.lblAuthor = New System.Windows.Forms.Label
        Me.tmrDoSearch = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3D1.SuspendLayout()
        Me.Panel3D3.SuspendLayout()
        Me.Panel3D2.SuspendLayout()
        Me.pnlSearching.SuspendLayout()
        CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.btnSearch)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Controls.Add(Me.txtKeywords)
        Me.Panel3D1.Location = New System.Drawing.Point(12, 12)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(720, 76)
        Me.Panel3D1.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 0
        Me.btnSearch.ImageList = Me.lstImgTlb
        Me.btnSearch.Location = New System.Drawing.Point(612, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(105, 39)
        Me.btnSearch.TabIndex = 283
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstImgTlb
        '
        Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
        Me.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp")
        Me.lstImgTlb.Images.SetKeyName(1, "Function.Stop.bmp")
        '
        'Panel3D3
        '
        Me.Panel3D3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.Panel3D3.BackColor = MySettings1.TitleBackColor
        Me.Panel3D3.Controls.Add(Me.Label7)
        Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D3.Name = "Panel3D3"
        Me.Panel3D3.Size = New System.Drawing.Size(720, 24)
        Me.Panel3D3.TabIndex = 282
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(710, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Keywords"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKeywords
        '
        Me.txtKeywords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeywords.Location = New System.Drawing.Point(10, 30)
        Me.txtKeywords.Multiline = True
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(596, 39)
        Me.txtKeywords.TabIndex = 39
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.ImageList = Me.lstImgTlb
        Me.btnCancel.Location = New System.Drawing.Point(627, 391)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(105, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tmrSearching
        '
        Me.tmrSearching.Interval = 128
        '
        'Panel3D2
        '
        Me.Panel3D2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D2.BackColor = System.Drawing.Color.White
        Me.Panel3D2.Controls.Add(Me.lstImages)
        Me.Panel3D2.Location = New System.Drawing.Point(12, 94)
        Me.Panel3D2.Name = "Panel3D2"
        Me.Panel3D2.Size = New System.Drawing.Size(720, 291)
        Me.Panel3D2.TabIndex = 17
        '
        'lstImages
        '
        Me.lstImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstImages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstImages.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lstImages.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor
        Me.lstImages.LargeImageList = Me.lstImg
        Me.lstImages.Location = New System.Drawing.Point(2, 2)
        Me.lstImages.Name = "lstImages"
        Me.lstImages.Size = New System.Drawing.Size(716, 287)
        Me.lstImages.TabIndex = 0
        Me.lstImages.UseCompatibleStateImageBehavior = False
        '
        'lstImg
        '
        Me.lstImg.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.lstImg.ImageSize = New System.Drawing.Size(110, 110)
        Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
        '
        'pnlSearching
        '
        Me.pnlSearching.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearching.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
        Me.pnlSearching.Controls.Add(Me.graph)
        Me.pnlSearching.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pnlSearching.Location = New System.Drawing.Point(12, 391)
        Me.pnlSearching.Name = "pnlSearching"
        Me.pnlSearching.Size = New System.Drawing.Size(606, 39)
        Me.pnlSearching.TabIndex = 18
        Me.pnlSearching.Visible = False
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
        Me.graph.Size = New System.Drawing.Size(600, 33)
        Me.graph.TabIndex = 283
        '
        'lblRAC
        '
        Me.lblRAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRAC.LinkArea = New System.Windows.Forms.LinkArea(0, 37)
        Me.lblRAC.Location = New System.Drawing.Point(131, 401)
        Me.lblRAC.Name = "lblRAC"
        Me.lblRAC.Size = New System.Drawing.Size(86, 21)
        Me.lblRAC.TabIndex = 286
        Me.lblRAC.TabStop = True
        Me.lblRAC.Text = "iStockphoto"
        Me.lblRAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRAC.UseCompatibleTextRendering = True
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.ForeColor = System.Drawing.Color.Black
        Me.lblAuthor.Location = New System.Drawing.Point(12, 400)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(205, 21)
        Me.lblAuthor.TabIndex = 285
        Me.lblAuthor.Tag = ""
        Me.lblAuthor.Text = "Images courtesy of "
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrDoSearch
        '
        Me.tmrDoSearch.Interval = 128
        '
        'ImageBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(745, 442)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlSearching)
        Me.Controls.Add(Me.Panel3D2)
        Me.Controls.Add(Me.Panel3D1)
        Me.Controls.Add(Me.lblRAC)
        Me.Controls.Add(Me.lblAuthor)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font
        Me.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImageBrowserForm"
        Me.Text = "Image Browser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3D1.ResumeLayout(False)
        Me.Panel3D1.PerformLayout()
        Me.Panel3D3.ResumeLayout(False)
        Me.Panel3D2.ResumeLayout(False)
        Me.pnlSearching.ResumeLayout(False)
        CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents tmrSearching As System.Windows.Forms.Timer
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents txtKeywords As System.Windows.Forms.TextBox
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents lstImages As ListViewNF
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Public WithEvents btnSearch As System.Windows.Forms.Button
  Friend WithEvents pnlSearching As lucidcode.Controls.Panel3D
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents lblRAC As System.Windows.Forms.LinkLabel
  Friend WithEvents lblAuthor As System.Windows.Forms.Label
  Friend WithEvents tmrDoSearch As System.Windows.Forms.Timer
End Class
