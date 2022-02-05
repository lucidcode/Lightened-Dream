Imports NHunspellExtender

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DreamViewControl
  Inherits System.Windows.Forms.UserControl

  'UserControl1 overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DreamViewControl))
    Me.Panel3D2 = New lucidcode.Controls.Panel3D()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.pnlText = New lucidcode.Controls.Panel3D()
    Me.txtDream = New System.Windows.Forms.TextBox()
    Me.pnlControls = New lucidcode.Controls.Panel3D()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.dtStart = New System.Windows.Forms.DateTimePicker()
    Me.cmbLucidity = New System.Windows.Forms.ComboBox()
    Me.dtEnd = New System.Windows.Forms.DateTimePicker()
    Me.txtTitle = New System.Windows.Forms.TextBox()
    Me.dtDate = New System.Windows.Forms.DateTimePicker()
    Me.objDreamSlider = New lucidcode.Controls.MultiSliderControl.SliderControl()
    Me.pnlDreamImage = New lucidcode.Controls.Panel3D()
    Me.pbDream = New System.Windows.Forms.PictureBox()
    Me.mnuThumbnail = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuThumbnailCopy = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuThumbnailPaste = New System.Windows.Forms.ToolStripMenuItem()
    Me.txtComments = New System.Windows.Forms.TextBox()
    Me.Panel3D4 = New lucidcode.Controls.Panel3D()
    Me.lblTitle = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.NHunspellTextBoxExtender1 = New NHunspellTextBoxExtender()
    Me.lstImgDreams = New System.Windows.Forms.ImageList(Me.components)
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.Panel3D2.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.pnlText.SuspendLayout()
    Me.pnlControls.SuspendLayout()
    Me.pnlDreamImage.SuspendLayout()
    CType(Me.pbDream, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.mnuThumbnail.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.SplitContainer1)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D2.TabIndex = 8
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(3, 25)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.pnlText)
    Me.SplitContainer1.Panel1.Controls.Add(Me.pnlControls)
    Me.SplitContainer1.Panel1.Controls.Add(Me.pnlDreamImage)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.txtComments)
    Me.SplitContainer1.Size = New System.Drawing.Size(868, 554)
    Me.SplitContainer1.SplitterDistance = 420
    Me.SplitContainer1.SplitterWidth = 2
    Me.SplitContainer1.TabIndex = 11
    '
    'pnlText
    '
    Me.pnlText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlText.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.pnlText.Controls.Add(Me.txtDream)
    Me.pnlText.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlText.Location = New System.Drawing.Point(4, 123)
    Me.pnlText.Name = "pnlText"
    Me.pnlText.Size = New System.Drawing.Size(861, 294)
    Me.pnlText.TabIndex = 42
    '
    'txtDream
    '
    Me.txtDream.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDream.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TextBackColor
    Me.txtDream.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtDream.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtDream.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDream.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtDream.Location = New System.Drawing.Point(2, 2)
    Me.txtDream.Multiline = True
    Me.txtDream.Name = "txtDream"
    Me.txtDream.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtDream.Size = New System.Drawing.Size(857, 290)
    Me.txtDream.TabIndex = 2
    '
    'pnlControls
    '
    Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlControls.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.pnlControls.Controls.Add(Me.Label11)
    Me.pnlControls.Controls.Add(Me.Label12)
    Me.pnlControls.Controls.Add(Me.dtStart)
    Me.pnlControls.Controls.Add(Me.cmbLucidity)
    Me.pnlControls.Controls.Add(Me.dtEnd)
    Me.pnlControls.Controls.Add(Me.txtTitle)
    Me.pnlControls.Controls.Add(Me.dtDate)
    Me.pnlControls.Controls.Add(Me.objDreamSlider)
    Me.pnlControls.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlControls.Location = New System.Drawing.Point(83, 5)
    Me.pnlControls.Name = "pnlControls"
    Me.pnlControls.Size = New System.Drawing.Size(782, 114)
    Me.pnlControls.TabIndex = 41
    '
    'Label11
    '
    Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label11.Location = New System.Drawing.Point(5, 6)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(38, 21)
    Me.Label11.TabIndex = 31
    Me.Label11.Text = "Title"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(5, 35)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(37, 21)
    Me.Label12.TabIndex = 29
    Me.Label12.Text = "Date"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtStart
    '
    Me.dtStart.CustomFormat = "HH:mm"
    Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtStart.Location = New System.Drawing.Point(229, 35)
    Me.dtStart.Name = "dtStart"
    Me.dtStart.ShowUpDown = True
    Me.dtStart.Size = New System.Drawing.Size(58, 21)
    Me.dtStart.TabIndex = 4
    Me.ToolTip1.SetToolTip(Me.dtStart, "Sleep start time (time you fell asleep)")
    Me.dtStart.Value = New Date(2009, 12, 2, 23, 0, 0, 0)
    '
    'cmbLucidity
    '
    Me.cmbLucidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbLucidity.FormattingEnabled = True
    Me.cmbLucidity.Items.AddRange(New Object() {"1 Thought", "2 Daydream", "3 Nightmare", "4 Foggy Dream", "5 Normal Dream", "6 Vivid Dream", "7 Lucid Dream", "8 Epic Dream", "9 Wake Induced"})
    Me.cmbLucidity.Location = New System.Drawing.Point(229, 6)
    Me.cmbLucidity.Name = "cmbLucidity"
    Me.cmbLucidity.Size = New System.Drawing.Size(122, 21)
    Me.cmbLucidity.TabIndex = 3
    Me.ToolTip1.SetToolTip(Me.cmbLucidity, "Type of dream")
    '
    'dtEnd
    '
    Me.dtEnd.CustomFormat = "HH:mm"
    Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtEnd.Location = New System.Drawing.Point(293, 35)
    Me.dtEnd.Name = "dtEnd"
    Me.dtEnd.ShowUpDown = True
    Me.dtEnd.Size = New System.Drawing.Size(58, 21)
    Me.dtEnd.TabIndex = 5
    Me.ToolTip1.SetToolTip(Me.dtEnd, "Sleep end time (time you woke up)")
    Me.dtEnd.Value = New Date(2009, 12, 2, 6, 0, 0, 0)
    '
    'txtTitle
    '
    Me.txtTitle.Location = New System.Drawing.Point(49, 6)
    Me.txtTitle.Name = "txtTitle"
    Me.txtTitle.Size = New System.Drawing.Size(171, 21)
    Me.txtTitle.TabIndex = 0
    Me.ToolTip1.SetToolTip(Me.txtTitle, "Title of the dream")
    '
    'dtDate
    '
    Me.dtDate.CustomFormat = "ddd yyyy-MM-dd HH:mm"
    Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtDate.Location = New System.Drawing.Point(49, 35)
    Me.dtDate.Name = "dtDate"
    Me.dtDate.Size = New System.Drawing.Size(171, 21)
    Me.dtDate.TabIndex = 1
    Me.ToolTip1.SetToolTip(Me.dtDate, "Date and time of the dream")
    '
    'objDreamSlider
    '
    Me.objDreamSlider.AllowDream = True
    Me.objDreamSlider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.objDreamSlider.DisplayInterval = 12
    Me.objDreamSlider.DreamTime = System.TimeSpan.Parse("23:30:00")
    Me.objDreamSlider.Increment = 10
    Me.objDreamSlider.Location = New System.Drawing.Point(5, 63)
    Me.objDreamSlider.Maximum = System.TimeSpan.Parse("12:00:00")
    Me.objDreamSlider.Minimum = System.TimeSpan.Parse("12:00:01")
    Me.objDreamSlider.Name = "objDreamSlider"
    Me.objDreamSlider.ShowIncrement = True
    Me.objDreamSlider.Size = New System.Drawing.Size(772, 49)
    Me.objDreamSlider.StartTime = System.TimeSpan.Parse("22:30:01")
    Me.objDreamSlider.StopTime = System.TimeSpan.Parse("23:50:00")
    Me.objDreamSlider.TabIndex = 38
    '
    'pnlDreamImage
    '
    Me.pnlDreamImage.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.pnlDreamImage.Controls.Add(Me.pbDream)
    Me.pnlDreamImage.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.pnlDreamImage.Location = New System.Drawing.Point(4, 5)
    Me.pnlDreamImage.Name = "pnlDreamImage"
    Me.pnlDreamImage.Size = New System.Drawing.Size(75, 114)
    Me.pnlDreamImage.TabIndex = 39
    '
    'pbDream
    '
    Me.pbDream.ContextMenuStrip = Me.mnuThumbnail
    Me.pbDream.Cursor = System.Windows.Forms.Cursors.Hand
    Me.pbDream.Location = New System.Drawing.Point(2, 2)
    Me.pbDream.Name = "pbDream"
    Me.pbDream.Size = New System.Drawing.Size(71, 110)
    Me.pbDream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.pbDream.TabIndex = 40
    Me.pbDream.TabStop = False
    '
    'mnuThumbnail
    '
    Me.mnuThumbnail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuThumbnailCopy, Me.mnuThumbnailPaste})
    Me.mnuThumbnail.Name = "mnuThumbnail"
    Me.mnuThumbnail.Size = New System.Drawing.Size(103, 48)
    '
    'mnuThumbnailCopy
    '
    Me.mnuThumbnailCopy.Name = "mnuThumbnailCopy"
    Me.mnuThumbnailCopy.Size = New System.Drawing.Size(102, 22)
    Me.mnuThumbnailCopy.Text = "&Copy"
    '
    'mnuThumbnailPaste
    '
    Me.mnuThumbnailPaste.Name = "mnuThumbnailPaste"
    Me.mnuThumbnailPaste.Size = New System.Drawing.Size(102, 22)
    Me.mnuThumbnailPaste.Text = "&Paste"
    '
    'txtComments
    '
    Me.txtComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtComments.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.TextBackColor
    Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtComments.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtComments.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtComments.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtComments.Location = New System.Drawing.Point(4, 1)
    Me.txtComments.Multiline = True
    Me.txtComments.Name = "txtComments"
    Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtComments.Size = New System.Drawing.Size(859, 128)
    Me.txtComments.TabIndex = 3
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
    Me.Panel3D4.Size = New System.Drawing.Size(874, 24)
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
    Me.lblTitle.Size = New System.Drawing.Size(864, 19)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Title"
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
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "Categories.ico")
    Me.lstImg.Images.SetKeyName(1, "Lucidity.ico")
    '
    'NHunspellTextBoxExtender1
    '
    Me.NHunspellTextBoxExtender1.Language = "English"
    Me.NHunspellTextBoxExtender1.MaintainUserChoice = False
    Me.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7
    Me.NHunspellTextBoxExtender1.SpellAsYouType = True
    '
    'lstImgDreams
    '
    Me.lstImgDreams.ImageStream = CType(resources.GetObject("lstImgDreams.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgDreams.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImgDreams.Images.SetKeyName(0, "1.png")
    Me.lstImgDreams.Images.SetKeyName(1, "2.png")
    Me.lstImgDreams.Images.SetKeyName(2, "4.png")
    Me.lstImgDreams.Images.SetKeyName(3, "5.png")
    Me.lstImgDreams.Images.SetKeyName(4, "6.png")
    Me.lstImgDreams.Images.SetKeyName(5, "7.png")
    Me.lstImgDreams.Images.SetKeyName(6, "8.png")
    Me.lstImgDreams.Images.SetKeyName(7, "9.png")
    Me.lstImgDreams.Images.SetKeyName(8, "10.png")
    Me.lstImgDreams.Images.SetKeyName(9, "11.png")
    Me.lstImgDreams.Images.SetKeyName(10, "13.png")
    '
    'ToolTip1
    '
    Me.ToolTip1.AutoPopDelay = 5000
    Me.ToolTip1.BackColor = System.Drawing.Color.SteelBlue
    Me.ToolTip1.ForeColor = System.Drawing.Color.White
    Me.ToolTip1.InitialDelay = 500
    Me.ToolTip1.IsBalloon = True
    Me.ToolTip1.ReshowDelay = 100
    '
    'DreamViewControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font
    Me.ForeColor = Global.lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor
    Me.Name = "DreamViewControl"
    Me.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D2.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    Me.SplitContainer1.ResumeLayout(False)
    Me.pnlText.ResumeLayout(False)
    Me.pnlText.PerformLayout()
    Me.pnlControls.ResumeLayout(False)
    Me.pnlControls.PerformLayout()
    Me.pnlDreamImage.ResumeLayout(False)
    Me.pnlDreamImage.PerformLayout()
    CType(Me.pbDream, System.ComponentModel.ISupportInitialize).EndInit()
    Me.mnuThumbnail.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtTitle As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Public WithEvents dtDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents objDreamSlider As lucidcode.Controls.MultiSliderControl.SliderControl
  Friend WithEvents cmbLucidity As System.Windows.Forms.ComboBox
  Friend WithEvents NHunspellTextBoxExtender1 As NHunspellTextBoxExtender
  Friend WithEvents pnlDreamImage As lucidcode.Controls.Panel3D
  Friend WithEvents pbDream As System.Windows.Forms.PictureBox
  Friend WithEvents pnlText As lucidcode.Controls.Panel3D
  Public WithEvents txtDream As System.Windows.Forms.TextBox
  Friend WithEvents pnlControls As lucidcode.Controls.Panel3D
  Friend WithEvents mnuThumbnail As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuThumbnailCopy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuThumbnailPaste As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents lstImgDreams As System.Windows.Forms.ImageList
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents txtComments As System.Windows.Forms.TextBox

End Class
