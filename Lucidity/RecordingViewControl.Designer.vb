<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordingViewControl
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordingViewControl))
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"today", "xxx"}, 0)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.objPlayer = New AxWMPLib.AxWindowsMediaPlayer
    Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
    Me.toolStart = New System.Windows.Forms.ToolStripButton
    Me.toolImport = New System.Windows.Forms.ToolStripButton
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.Label2 = New System.Windows.Forms.Label
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.lstRecordings = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.txtSpeech = New System.Windows.Forms.TextBox
    Me.Panel3D2.SuspendLayout()
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip3.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.Panel3D1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D2.Controls.Add(Me.objPlayer)
    Me.Panel3D2.Controls.Add(Me.ToolStrip3)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(411, 80)
    Me.Panel3D2.TabIndex = 6
    '
    'objPlayer
    '
    Me.objPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.objPlayer.Enabled = True
    Me.objPlayer.Location = New System.Drawing.Point(112, 29)
    Me.objPlayer.Name = "objPlayer"
    Me.objPlayer.OcxState = CType(resources.GetObject("objPlayer.OcxState"), System.Windows.Forms.AxHost.State)
    Me.objPlayer.Size = New System.Drawing.Size(294, 45)
    Me.objPlayer.TabIndex = 34
    Me.objPlayer.Visible = False
    '
    'ToolStrip3
    '
    Me.ToolStrip3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ToolStrip3.AutoSize = False
    Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
    Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStart, Me.toolImport})
    Me.ToolStrip3.Location = New System.Drawing.Point(3, 27)
    Me.ToolStrip3.Name = "ToolStrip3"
    Me.ToolStrip3.ShowItemToolTips = False
    Me.ToolStrip3.Size = New System.Drawing.Size(470, 54)
    Me.ToolStrip3.TabIndex = 33
    Me.ToolStrip3.Text = "ToolStrip3"
    '
    'toolStart
    '
    Me.toolStart.AutoSize = False
    Me.toolStart.Image = CType(resources.GetObject("toolStart.Image"), System.Drawing.Image)
    Me.toolStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolStart.ImageTransparentColor = System.Drawing.Color.White
    Me.toolStart.Name = "toolStart"
    Me.toolStart.Size = New System.Drawing.Size(50, 48)
    Me.toolStart.Text = "&Start"
    Me.toolStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'toolImport
    '
    Me.toolImport.AutoSize = False
    Me.toolImport.Image = CType(resources.GetObject("toolImport.Image"), System.Drawing.Image)
    Me.toolImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.toolImport.ImageTransparentColor = System.Drawing.Color.White
    Me.toolImport.Name = "toolImport"
    Me.toolImport.Size = New System.Drawing.Size(50, 48)
    Me.toolImport.Text = "&Import"
    Me.toolImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor
        Me.Panel3D4.Controls.Add(Me.Label2)
        Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D4.Name = "Panel3D4"
        Me.Panel3D4.Size = New System.Drawing.Size(411, 24)
        Me.Panel3D4.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor
    Me.Label2.Location = New System.Drawing.Point(8, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(398, 19)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Recording"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "File.Recording.ico")
    '
    'lstRecordings
    '
    Me.lstRecordings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstRecordings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
    Me.lstRecordings.FullRowSelect = True
    Me.lstRecordings.HideSelection = False
    Me.lstRecordings.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
    Me.lstRecordings.LabelEdit = True
    Me.lstRecordings.Location = New System.Drawing.Point(3, 158)
    Me.lstRecordings.Name = "lstRecordings"
    Me.lstRecordings.Size = New System.Drawing.Size(405, 157)
    Me.lstRecordings.SmallImageList = Me.lstImg
    Me.lstRecordings.TabIndex = 0
    Me.lstRecordings.UseCompatibleStateImageBehavior = False
    Me.lstRecordings.View = System.Windows.Forms.View.Details
    Me.lstRecordings.Visible = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.DisplayIndex = 2
    Me.ColumnHeader1.Text = "Description"
    Me.ColumnHeader1.Width = 116
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.DisplayIndex = 0
    Me.ColumnHeader2.Text = "Date"
    Me.ColumnHeader2.Width = 161
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.DisplayIndex = 1
    Me.ColumnHeader3.Text = "Length"
    Me.ColumnHeader3.Width = 88
    '
    'Panel3D1
    '
    Me.Panel3D1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D1.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Panel3D1.Controls.Add(Me.lstRecordings)
    Me.Panel3D1.Controls.Add(Me.txtSpeech)
    Me.Panel3D1.Location = New System.Drawing.Point(0, 84)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(411, 389)
    Me.Panel3D1.TabIndex = 8
    '
    'txtSpeech
    '
    Me.txtSpeech.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtSpeech.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSpeech.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtSpeech.Location = New System.Drawing.Point(3, 3)
    Me.txtSpeech.Multiline = True
    Me.txtSpeech.Name = "txtSpeech"
    Me.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtSpeech.Size = New System.Drawing.Size(403, 376)
    Me.txtSpeech.TabIndex = 2
    '
    'RecordingViewControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Controls.Add(Me.Panel3D1)
    Me.Controls.Add(Me.Panel3D2)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Name = "RecordingViewControl"
    Me.Size = New System.Drawing.Size(411, 473)
    Me.Panel3D2.ResumeLayout(False)
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip3.ResumeLayout(False)
    Me.ToolStrip3.PerformLayout()
    Me.Panel3D4.ResumeLayout(False)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents objPlayer As AxWMPLib.AxWindowsMediaPlayer
  Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
  Friend WithEvents toolStart As System.Windows.Forms.ToolStripButton
  Friend WithEvents toolImport As System.Windows.Forms.ToolStripButton
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents lstRecordings As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Public WithEvents txtSpeech As System.Windows.Forms.TextBox

End Class
