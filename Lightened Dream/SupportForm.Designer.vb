<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupportForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupportForm))
        Dim MySettings2 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Me.panel3D2 = New lucidcode.Controls.Panel3D
        Me.webSupport = New System.Windows.Forms.WebBrowser
        Me.Panel3D1 = New lucidcode.Controls.Panel3D
        Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.txtOS = New System.Windows.Forms.TextBox
        Me.txtReplyAddress = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.Panel3D3 = New lucidcode.Controls.Panel3D
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.panel3D2.SuspendLayout()
        Me.Panel3D1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3D3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel3D2
        '
        Me.panel3D2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel3D2.Controls.Add(Me.webSupport)
        Me.panel3D2.Location = New System.Drawing.Point(12, 162)
        Me.panel3D2.Name = "panel3D2"
        Me.panel3D2.Size = New System.Drawing.Size(763, 268)
        Me.panel3D2.TabIndex = 16
        '
        'webSupport
        '
        Me.webSupport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webSupport.Location = New System.Drawing.Point(3, 3)
        Me.webSupport.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webSupport.Name = "webSupport"
        Me.webSupport.Size = New System.Drawing.Size(757, 262)
        Me.webSupport.TabIndex = 283
        Me.webSupport.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.btnOk)
        Me.Panel3D1.Controls.Add(Me.btnCancel)
        Me.Panel3D1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3D1.Controls.Add(Me.txtMessage)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Controls.Add(Me.Label9)
        Me.Panel3D1.Location = New System.Drawing.Point(12, 12)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(763, 144)
        Me.Panel3D1.TabIndex = 16
        '
        'lstImgTlb
        '
        Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
        Me.lstImgTlb.Images.SetKeyName(0, "Send.2.bmp")
        Me.lstImgTlb.Images.SetKeyName(1, "Send.Cancel.bmp")
        Me.lstImgTlb.Images.SetKeyName(2, "Action.Forward.bmp")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtOS, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtReplyAddress, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbType, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtOS
        '
        Me.txtOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOS.Location = New System.Drawing.Point(227, 3)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(237, 21)
        Me.txtOS.TabIndex = 280
        '
        'txtReplyAddress
        '
        Me.txtReplyAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReplyAddress.Location = New System.Drawing.Point(570, 3)
        Me.txtReplyAddress.Name = "txtReplyAddress"
        Me.txtReplyAddress.Size = New System.Drawing.Size(184, 21)
        Me.txtReplyAddress.TabIndex = 1
        Me.txtReplyAddress.Text = "anonymous@lucid-code.com"
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 29)
        Me.Label15.TabIndex = 270
        Me.Label15.Text = "Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Bug Report", "Feature Request", "Comment", "Contribution"})
        Me.cmbType.Location = New System.Drawing.Point(79, 3)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(102, 21)
        Me.cmbType.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(470, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 29)
        Me.Label11.TabIndex = 278
        Me.Label11.Text = "Reply Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(187, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 29)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "OS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Location = New System.Drawing.Point(82, 55)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(564, 84)
        Me.txtMessage.TabIndex = 1
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
        Me.Panel3D3.Controls.Add(Me.Label7)
        Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings2, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D3.Name = "Panel3D3"
        Me.Panel3D3.Size = New System.Drawing.Size(763, 24)
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
        Me.Label7.Size = New System.Drawing.Size(753, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Feedback"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(8, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 21)
        Me.Label9.TabIndex = 280
        Me.Label9.Text = "Message"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnOk.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.ImageIndex = 0
        Me.btnOk.ImageList = Me.lstImgTlb
        Me.btnOk.Location = New System.Drawing.Point(652, 55)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(105, 39)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Submit"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.ImageList = Me.lstImgTlb
        Me.btnCancel.Location = New System.Drawing.Point(652, 100)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(105, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SupportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.Panel3D1)
        Me.Controls.Add(Me.panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.LightenedDream.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.LightenedDream.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.LightenedDream.My.MySettings.Default.Font
        Me.ForeColor = Global.LightenedDream.My.MySettings.Default.FormForeColor
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SupportForm"
        Me.Text = "Support Lightened Dream"
    Me.panel3D2.ResumeLayout(False)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents webSupport As System.Windows.Forms.WebBrowser
  Friend WithEvents cmbType As System.Windows.Forms.ComboBox
  Friend WithEvents txtReplyAddress As System.Windows.Forms.TextBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txtMessage As System.Windows.Forms.TextBox
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
  Public WithEvents btnOk As System.Windows.Forms.Button
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents txtOS As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
