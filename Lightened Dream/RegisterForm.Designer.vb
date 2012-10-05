<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Me.Panel3D1 = New lucidcode.Controls.Panel3D
        Me.btnOk = New System.Windows.Forms.Button
        Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel3D3 = New lucidcode.Controls.Panel3D
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtReplyAddress = New System.Windows.Forms.TextBox
        Me.Panel3D1.SuspendLayout()
        Me.Panel3D3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.btnOk)
        Me.Panel3D1.Controls.Add(Me.txtReplyAddress)
        Me.Panel3D1.Controls.Add(Me.btnCancel)
        Me.Panel3D1.Controls.Add(Me.Label11)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Location = New System.Drawing.Point(12, 12)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(325, 96)
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
        Me.btnOk.ImageList = Me.lstImgTlb
        Me.btnOk.Location = New System.Drawing.Point(106, 54)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(105, 39)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Submit"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstImgTlb
        '
        Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
        Me.lstImgTlb.Images.SetKeyName(0, "Send.2.bmp")
        Me.lstImgTlb.Images.SetKeyName(1, "Send.Cancel.bmp")
        Me.lstImgTlb.Images.SetKeyName(2, "Action.Forward.bmp")
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
        Me.btnCancel.Location = New System.Drawing.Point(217, 54)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(105, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
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
        Me.Panel3D3.Size = New System.Drawing.Size(325, 24)
        Me.Panel3D3.TabIndex = 282
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = Global.LightenedDream.My.MySettings.Default.TitleBackColor
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = Global.LightenedDream.My.MySettings.Default.TitleForeColor
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(315, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Register for Updates"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(7, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 21)
        Me.Label11.TabIndex = 278
        Me.Label11.Text = "Email Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReplyAddress
        '
        Me.txtReplyAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReplyAddress.Location = New System.Drawing.Point(107, 27)
        Me.txtReplyAddress.Name = "txtReplyAddress"
        Me.txtReplyAddress.Size = New System.Drawing.Size(215, 21)
        Me.txtReplyAddress.TabIndex = 1
        Me.txtReplyAddress.Text = "anonymous@lucid-code.com"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(349, 120)
        Me.Controls.Add(Me.Panel3D1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterForm"
        Me.Text = "Register for Lightened Dream Updates"
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label7 As System.Windows.Forms.Label
  Public WithEvents btnOk As System.Windows.Forms.Button
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents txtReplyAddress As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
