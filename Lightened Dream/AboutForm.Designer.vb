<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings()
        Me.panel3D3 = New lucidcode.Controls.Panel3D()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel3D2 = New lucidcode.Controls.Panel3D()
        Me.lblUpdate = New System.Windows.Forms.LinkLabel()
        Me.Panel3D4 = New lucidcode.Controls.Panel3D()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.panel3D3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3D2.SuspendLayout()
        Me.Panel3D4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3D3
        '
        Me.panel3D3.Controls.Add(Me.PictureBox2)
        Me.panel3D3.Location = New System.Drawing.Point(12, 12)
        Me.panel3D3.Name = "panel3D3"
        Me.panel3D3.Size = New System.Drawing.Size(662, 187)
        Me.panel3D3.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 183)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'panel3D2
        '
        Me.panel3D2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel3D2.Controls.Add(Me.lblUpdate)
        Me.panel3D2.Controls.Add(Me.Panel3D4)
        Me.panel3D2.Controls.Add(Me.label6)
        Me.panel3D2.Controls.Add(Me.lblAuthor)
        Me.panel3D2.Controls.Add(Me.label1)
        Me.panel3D2.Controls.Add(Me.lblDescription)
        Me.panel3D2.Controls.Add(Me.lblWeb)
        Me.panel3D2.Controls.Add(Me.Label5)
        Me.panel3D2.Controls.Add(Me.Label8)
        Me.panel3D2.Controls.Add(Me.label3)
        Me.panel3D2.Controls.Add(Me.lblCopyright)
        Me.panel3D2.Controls.Add(Me.label2)
        Me.panel3D2.Controls.Add(Me.lblVersion)
        Me.panel3D2.Controls.Add(Me.lblProductName)
        Me.panel3D2.Location = New System.Drawing.Point(12, 205)
        Me.panel3D2.Name = "panel3D2"
        Me.panel3D2.Size = New System.Drawing.Size(662, 165)
        Me.panel3D2.TabIndex = 16
        '
        'lblUpdate
        '
        Me.lblUpdate.LinkArea = New System.Windows.Forms.LinkArea(0, 99)
        Me.lblUpdate.Location = New System.Drawing.Point(141, 91)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(517, 21)
        Me.lblUpdate.TabIndex = 283
        Me.lblUpdate.TabStop = True
        Me.lblUpdate.Text = "(Version 0.0.1 is now available!)"
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUpdate.UseCompatibleTextRendering = True
        Me.lblUpdate.Visible = False
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
        Me.Panel3D4.Size = New System.Drawing.Size(662, 24)
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
        Me.lblTitle.Size = New System.Drawing.Size(652, 19)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "About"
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
        'label6
        '
        Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label6.Location = New System.Drawing.Point(8, 69)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(90, 21)
        Me.label6.TabIndex = 280
        Me.label6.Text = "Author"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.ForeColor = System.Drawing.Color.Black
        Me.lblAuthor.Location = New System.Drawing.Point(104, 69)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(554, 21)
        Me.lblAuthor.TabIndex = 281
        Me.lblAuthor.Tag = ""
        Me.lblAuthor.Text = "Michael Paul Coder"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label1.Location = New System.Drawing.Point(8, 48)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(90, 21)
        Me.label1.TabIndex = 278
        Me.label1.Text = "Description"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(104, 48)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(554, 21)
        Me.lblDescription.TabIndex = 279
        Me.lblDescription.Tag = ""
        Me.lblDescription.Text = "A dream journal designed to focus your conscious awareness in the dream state."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWeb
        '
        Me.lblWeb.LinkArea = New System.Windows.Forms.LinkArea(0, 40)
        Me.lblWeb.Location = New System.Drawing.Point(103, 132)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(557, 21)
        Me.lblWeb.TabIndex = 277
        Me.lblWeb.TabStop = True
        Me.lblWeb.Text = "http://www.lucidcode.com/LightenedDream"
        Me.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWeb.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(7, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 276
        Me.Label5.Text = "Web"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(8, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 21)
        Me.Label8.TabIndex = 270
        Me.Label8.Text = "Copyright"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label3
        '
        Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label3.Location = New System.Drawing.Point(8, 90)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 21)
        Me.label3.TabIndex = 270
        Me.label3.Text = "Version"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.ForeColor = System.Drawing.Color.Black
        Me.lblCopyright.Location = New System.Drawing.Point(104, 111)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(554, 21)
        Me.lblCopyright.TabIndex = 271
        Me.lblCopyright.Tag = ""
        Me.lblCopyright.Text = "© 2000 - 2014 lucidcode"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label2.Location = New System.Drawing.Point(8, 27)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(90, 21)
        Me.label2.TabIndex = 270
        Me.label2.Text = "Product"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.ForeColor = System.Drawing.Color.Black
        Me.lblVersion.Location = New System.Drawing.Point(104, 90)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(554, 21)
        Me.lblVersion.TabIndex = 271
        Me.lblVersion.Tag = ""
        Me.lblVersion.Text = "0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.ForeColor = System.Drawing.Color.Black
        Me.lblProductName.Location = New System.Drawing.Point(104, 27)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(554, 21)
        Me.lblProductName.TabIndex = 271
        Me.lblProductName.Tag = ""
        Me.lblProductName.Text = "Lightened Dream"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(683, 380)
        Me.Controls.Add(Me.panel3D2)
        Me.Controls.Add(Me.panel3D3)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.Text = "About Lightened Dream"
        Me.panel3D3.ResumeLayout(False)
        Me.panel3D3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3D2.ResumeLayout(False)
        Me.Panel3D4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents panel3D3 As lucidcode.Controls.Panel3D
  Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents label6 As System.Windows.Forms.Label
  Friend WithEvents lblAuthor As System.Windows.Forms.Label
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents lblWeb As System.Windows.Forms.LinkLabel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents lblVersion As System.Windows.Forms.Label
  Friend WithEvents lblProductName As System.Windows.Forms.Label
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblCopyright As System.Windows.Forms.Label
  Friend WithEvents lblUpdate As System.Windows.Forms.LinkLabel
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
End Class
