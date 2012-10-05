<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportForm
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
    Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dreams")
    Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Characters")
    Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Locations")
    Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Objects")
    Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Actions")
    Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Themes")
    Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Categories", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
    Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("REM Cycles")
    Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reality Checks")
    Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dream Inductions")
    Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lucidity", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Dim MySettings2 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportForm))
        Me.panel3D2 = New lucidcode.Controls.Panel3D
        Me.trvMain = New System.Windows.Forms.TreeView
        Me.Panel3D4 = New lucidcode.Controls.Panel3D
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3D1 = New lucidcode.Controls.Panel3D
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.Panel3D3 = New lucidcode.Controls.Panel3D
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pgbStatus = New System.Windows.Forms.ProgressBar
        Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
        Me.lstImgTrv = New System.Windows.Forms.ImageList(Me.components)
        Me.panel3D2.SuspendLayout()
        Me.Panel3D4.SuspendLayout()
        Me.Panel3D1.SuspendLayout()
        Me.Panel3D3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3D2
        '
        Me.panel3D2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel3D2.Controls.Add(Me.trvMain)
        Me.panel3D2.Controls.Add(Me.Panel3D4)
        Me.panel3D2.Location = New System.Drawing.Point(12, 12)
        Me.panel3D2.Name = "panel3D2"
        Me.panel3D2.Size = New System.Drawing.Size(268, 325)
        Me.panel3D2.TabIndex = 16
        '
        'trvMain
        '
        Me.trvMain.AllowDrop = True
        Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvMain.BackColor = Global.LightenedDream.My.MySettings.Default.TextBackColor
        Me.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trvMain.CheckBoxes = True
        Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.trvMain.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.trvMain.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.trvMain.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
        Me.trvMain.HideSelection = False
        Me.trvMain.ImageIndex = 0
        Me.trvMain.ImageList = Me.lstImgTrv
        Me.trvMain.Indent = 19
        Me.trvMain.ItemHeight = 18
        Me.trvMain.Location = New System.Drawing.Point(3, 25)
        Me.trvMain.Name = "trvMain"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Dreams"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Characters"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Locations"
        TreeNode4.Name = "Node4"
        TreeNode4.Text = "Objects"
        TreeNode5.Name = "Node0"
        TreeNode5.Text = "Actions"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "Themes"
        TreeNode7.Name = "Node14"
        TreeNode7.Text = "Categories"
        TreeNode8.Name = "Node10"
        TreeNode8.Text = "REM Cycles"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "Reality Checks"
        TreeNode10.Name = "Node12"
        TreeNode10.Text = "Dream Inductions"
        TreeNode11.Name = "Node8"
        TreeNode11.Text = "Lucidity"
        Me.trvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode7, TreeNode11})
        Me.trvMain.SelectedImageIndex = 1
        Me.trvMain.Size = New System.Drawing.Size(262, 297)
        Me.trvMain.TabIndex = 17
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
        Me.Panel3D4.Controls.Add(Me.Label4)
        Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D4.Name = "Panel3D4"
        Me.Panel3D4.Size = New System.Drawing.Size(268, 24)
        Me.Panel3D4.TabIndex = 282
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
        Me.lblTitle.Location = New System.Drawing.Point(7, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 19)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Export"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dream"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.btnOk)
        Me.Panel3D1.Controls.Add(Me.btnCancel)
        Me.Panel3D1.Controls.Add(Me.chkSelectAll)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Location = New System.Drawing.Point(12, 343)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(268, 66)
        Me.Panel3D1.TabIndex = 16
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnOk.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(86, 26)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 37)
        Me.btnOk.TabIndex = 309
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 0
        Me.btnCancel.Location = New System.Drawing.Point(173, 26)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(92, 37)
        Me.btnCancel.TabIndex = 308
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(11, 30)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(79, 17)
        Me.chkSelectAll.TabIndex = 283
        Me.chkSelectAll.Text = "&Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'Panel3D3
        '
        Me.Panel3D3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MySettings2.Font = New System.Drawing.Font("Verdana", 8.25!)
        MySettings2.FormBackColor = System.Drawing.Color.LightSteelBlue
        MySettings2.FormForeColor = System.Drawing.Color.MidnightBlue
        MySettings2.LastAsleep = New Date(CType(0, Long))
        MySettings2.LastAwake = New Date(CType(0, Long))
        MySettings2.SettingsKey = ""
        MySettings2.TextBackColor = System.Drawing.Color.White
        MySettings2.TitleBackColor = System.Drawing.Color.SteelBlue
        MySettings2.TitleForeColor = System.Drawing.Color.White
        Me.Panel3D3.BackColor = MySettings2.TitleBackColor
        Me.Panel3D3.Controls.Add(Me.Label1)
        Me.Panel3D3.Controls.Add(Me.Label2)
        Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings2, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D3.Name = "Panel3D3"
        Me.Panel3D3.Size = New System.Drawing.Size(268, 24)
        Me.Panel3D3.TabIndex = 282
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'pgbStatus
        '
        Me.pgbStatus.Location = New System.Drawing.Point(12, 426)
        Me.pgbStatus.Name = "pgbStatus"
        Me.pgbStatus.Size = New System.Drawing.Size(268, 27)
        Me.pgbStatus.TabIndex = 310
        '
        'lstImgTlb
        '
        Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
        Me.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp")
        Me.lstImgTlb.Images.SetKeyName(1, "File.LucidScribe.Add.bmp")
        '
        'lstImgTrv
        '
        Me.lstImgTrv.ImageStream = CType(resources.GetObject("lstImgTrv.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTrv.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImgTrv.Images.SetKeyName(0, "Folder.16.ico")
        Me.lstImgTrv.Images.SetKeyName(1, "Folder.Open.16.ico")
        Me.lstImgTrv.Images.SetKeyName(2, "File.Characters0")
        Me.lstImgTrv.Images.SetKeyName(3, "File.Characters")
        Me.lstImgTrv.Images.SetKeyName(4, "File.Locations")
        Me.lstImgTrv.Images.SetKeyName(5, "File.Objects")
        Me.lstImgTrv.Images.SetKeyName(6, "File.Themes")
        Me.lstImgTrv.Images.SetKeyName(7, "File.Emotions")
        Me.lstImgTrv.Images.SetKeyName(8, "File.Actions")
        Me.lstImgTrv.Images.SetKeyName(9, "File.Recordings")
        Me.lstImgTrv.Images.SetKeyName(10, "File.Subliminals")
        Me.lstImgTrv.Images.SetKeyName(11, "File.Checks")
        Me.lstImgTrv.Images.SetKeyName(12, "File.Readings")
        Me.lstImgTrv.Images.SetKeyName(13, "File.REM Cycles")
        Me.lstImgTrv.Images.SetKeyName(14, "Dream")
        '
        'ExportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(289, 465)
        Me.Controls.Add(Me.pgbStatus)
        Me.Controls.Add(Me.Panel3D1)
        Me.Controls.Add(Me.panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ExportForm"
    Me.Text = "Export"
    Me.panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents trvMain As System.Windows.Forms.TreeView
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label1 As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
  Public WithEvents btnOk As System.Windows.Forms.Button
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents pgbStatus As System.Windows.Forms.ProgressBar
  Friend WithEvents lstImgTrv As System.Windows.Forms.ImageList
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
End Class
