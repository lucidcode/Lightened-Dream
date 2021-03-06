﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchControl
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
    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel3 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim CustomLabel4 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
    Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchControl))
    Me.lstDreams = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D()
    Me.graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
    Me.Panel3D4 = New lucidcode.Controls.Panel3D()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel3D1 = New lucidcode.Controls.Panel3D()
    Me.btnSearch = New System.Windows.Forms.Button()
    Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
    Me.txtSearch = New System.Windows.Forms.TextBox()
    Me.Panel3D3 = New lucidcode.Controls.Panel3D()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.mnuCategories = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuAddTo = New System.Windows.Forms.ToolStripMenuItem()
    Me.CategoryMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.Panel3D2.SuspendLayout()
    CType(Me.graph, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D4.SuspendLayout()
    Me.Panel3D1.SuspendLayout()
    Me.Panel3D3.SuspendLayout()
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
    Me.lstDreams.Location = New System.Drawing.Point(200, 25)
    Me.lstDreams.MultiSelect = False
    Me.lstDreams.Name = "lstDreams"
    Me.lstDreams.Size = New System.Drawing.Size(226, 167)
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
    Me.Panel3D2.Controls.Add(Me.graph)
    Me.Panel3D2.Controls.Add(Me.lstDreams)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D2.Location = New System.Drawing.Point(0, 77)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(640, 403)
    Me.Panel3D2.TabIndex = 8
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
    ChartArea1.Area3DStyle.PointGapDepth = 0
    ChartArea1.Area3DStyle.Rotation = 10
    ChartArea1.Area3DStyle.WallWidth = 0
    CustomLabel1.FromPosition = 0.5R
    CustomLabel1.Text = "2009/11"
    CustomLabel1.ToPosition = 1.5R
    CustomLabel2.FromPosition = 1.5R
    CustomLabel2.Text = "2009/12"
    CustomLabel2.ToPosition = 2.5R
    ChartArea1.AxisX.CustomLabels.Add(CustomLabel1)
    ChartArea1.AxisX.CustomLabels.Add(CustomLabel2)
    ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisX.IsLabelAutoFit = False
    ChartArea1.AxisX.LabelStyle.Angle = 90
    ChartArea1.AxisX.LabelStyle.Interval = 0.0R
    CustomLabel3.Text = "x"
    CustomLabel4.Text = "x"
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel3)
    ChartArea1.AxisX2.CustomLabels.Add(CustomLabel4)
    ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
    ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
    ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
    ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
    ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
    ChartArea1.AxisY2.Maximum = 11.0R
    ChartArea1.AxisY2.Minimum = -11.0R
    ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave
    ChartArea1.AxisY2.ScaleBreakStyle.Enabled = True
    ChartArea1.BackColor = System.Drawing.Color.White
    ChartArea1.BackImageTransparentColor = System.Drawing.Color.White
    ChartArea1.BackSecondaryColor = System.Drawing.Color.White
    ChartArea1.BorderColor = System.Drawing.Color.White
    ChartArea1.Name = "ChartArea1"
    ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.graph.ChartAreas.Add(ChartArea1)
    Legend1.BackColor = System.Drawing.Color.LightSteelBlue
    Legend1.ForeColor = System.Drawing.Color.MidnightBlue
    Legend1.Name = "Legend1"
    Me.graph.Legends.Add(Legend1)
    Me.graph.Location = New System.Drawing.Point(3, 25)
    Me.graph.Name = "graph"
    Series1.ChartArea = "ChartArea1"
    Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
    Series1.Legend = "Legend1"
    Series1.Name = "Series2"
    Series2.ChartArea = "ChartArea1"
    Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
    Series2.Legend = "Legend1"
    Series2.Name = "Series3"
    Me.graph.Series.Add(Series1)
    Me.graph.Series.Add(Series2)
    Me.graph.Size = New System.Drawing.Size(634, 375)
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
    Me.lblTitle.Text = "Dreams"
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
    'Panel3D1
    '
    Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D1.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Panel3D1.Controls.Add(Me.btnSearch)
    Me.Panel3D1.Controls.Add(Me.txtSearch)
    Me.Panel3D1.Controls.Add(Me.Panel3D3)
    Me.Panel3D1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D1.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(640, 71)
    Me.Panel3D1.TabIndex = 0
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
    Me.btnSearch.Location = New System.Drawing.Point(536, 27)
    Me.btnSearch.Name = "btnSearch"
    Me.btnSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
    Me.btnSearch.Size = New System.Drawing.Size(101, 39)
    Me.btnSearch.TabIndex = 1
    Me.btnSearch.Text = "&Search"
    Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnSearch.UseVisualStyleBackColor = True
    '
    'lstImgTlb
    '
    Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
    Me.lstImgTlb.Images.SetKeyName(0, "File.Dream.Search.3.bmp")
    Me.lstImgTlb.Images.SetKeyName(1, "File.Dream.Search.Clear.bmp")
    '
    'txtSearch
    '
    Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtSearch.Location = New System.Drawing.Point(6, 27)
    Me.txtSearch.Multiline = True
    Me.txtSearch.Name = "txtSearch"
    Me.txtSearch.Size = New System.Drawing.Size(524, 39)
    Me.txtSearch.TabIndex = 0
    '
    'Panel3D3
    '
    Me.Panel3D3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D3.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D3.Controls.Add(Me.Label1)
    Me.Panel3D3.Controls.Add(Me.Label3)
    Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D3.Name = "Panel3D3"
    Me.Panel3D3.Size = New System.Drawing.Size(640, 24)
    Me.Panel3D3.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label1.Location = New System.Drawing.Point(7, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(630, 19)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Search"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label3.Location = New System.Drawing.Point(8, 3)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(90, 19)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Dream"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'mnuCategories
    '
    Me.mnuCategories.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddTo})
    Me.mnuCategories.Name = "mnuCategories"
    Me.mnuCategories.Size = New System.Drawing.Size(114, 26)
    '
    'mnuAddTo
    '
    Me.mnuAddTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoryMenuItem})
    Me.mnuAddTo.Image = CType(resources.GetObject("mnuAddTo.Image"), System.Drawing.Image)
    Me.mnuAddTo.Name = "mnuAddTo"
    Me.mnuAddTo.Size = New System.Drawing.Size(113, 22)
    Me.mnuAddTo.Text = "&Add To"
    '
    'CategoryMenuItem
    '
    Me.CategoryMenuItem.Image = CType(resources.GetObject("CategoryMenuItem.Image"), System.Drawing.Image)
    Me.CategoryMenuItem.Name = "CategoryMenuItem"
    Me.CategoryMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.CategoryMenuItem.Text = "Category"
    Me.CategoryMenuItem.Visible = False
    '
    'SearchControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Controls.Add(Me.Panel3D1)
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font
    Me.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor
    Me.Name = "SearchControl"
    Me.Size = New System.Drawing.Size(640, 480)
    Me.Panel3D2.ResumeLayout(False)
    CType(Me.graph, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D4.ResumeLayout(False)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
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
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label1 As System.Windows.Forms.Label
  Public WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtSearch As System.Windows.Forms.TextBox
  Public WithEvents btnSearch As System.Windows.Forms.Button
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Friend WithEvents graph As System.Windows.Forms.DataVisualization.Charting.Chart
  Friend WithEvents mnuCategories As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuAddTo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CategoryMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
