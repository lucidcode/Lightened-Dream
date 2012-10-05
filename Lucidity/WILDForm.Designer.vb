<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WILDForm
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
        Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WILDForm))
        Me.Panel3D1 = New lucidcode.Controls.Panel3D
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmbLength = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtInterval = New System.Windows.Forms.TextBox
        Me.colText = New lucidcode.Controls.ColorPicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.colBackground = New lucidcode.Controls.ColorPicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3D3 = New lucidcode.Controls.Panel3D
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3D1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3D3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Location = New System.Drawing.Point(12, 12)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(459, 88)
        Me.Panel3D1.TabIndex = 16
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLength, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInterval, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.colText, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.colBackground, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(445, 52)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'cmbLength
        '
        Me.cmbLength.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLength.FormattingEnabled = True
        Me.cmbLength.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "30"})
        Me.cmbLength.Location = New System.Drawing.Point(301, 3)
        Me.cmbLength.Name = "cmbLength"
        Me.cmbLength.Size = New System.Drawing.Size(141, 21)
        Me.cmbLength.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(241, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Length"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInterval
        '
        Me.txtInterval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInterval.Location = New System.Drawing.Point(95, 3)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(140, 21)
        Me.txtInterval.TabIndex = 39
        Me.txtInterval.Text = "128"
        '
        'colText
        '
        Me.colText.Color = System.Drawing.Color.White
        Me.colText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colText.Location = New System.Drawing.Point(301, 27)
        Me.colText.Name = "colText"
        Me.colText.Size = New System.Drawing.Size(141, 22)
        Me.colText.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(241, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 28)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Flash"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colBackground
        '
        Me.colBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colBackground.Location = New System.Drawing.Point(95, 27)
        Me.colBackground.Name = "colBackground"
        Me.colBackground.Size = New System.Drawing.Size(140, 22)
        Me.colBackground.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(3, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 28)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Background"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Interval (ms)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel3D3.Size = New System.Drawing.Size(459, 24)
        Me.Panel3D3.TabIndex = 282
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(448, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Settings"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnOk.Location = New System.Drawing.Point(366, 106)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(105, 39)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Induce"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstImgTlb
        '
        Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
        Me.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp")
        Me.lstImgTlb.Images.SetKeyName(1, "Function.Stop.bmp")
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
        Me.btnCancel.Location = New System.Drawing.Point(255, 106)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(105, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 42)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Darken the room, lean forward, close your eyes and watch closely."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WILDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(483, 151)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel3D1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font
        Me.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "WILDForm"
    Me.Text = "WILD Inducer"
    Me.Panel3D1.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Public WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
  Public WithEvents btnOk As System.Windows.Forms.Button
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txtInterval As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents colText As lucidcode.Controls.ColorPicker
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents colBackground As lucidcode.Controls.ColorPicker
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cmbLength As System.Windows.Forms.ComboBox
End Class
