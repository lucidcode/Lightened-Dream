<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubliminalViewControl
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
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.Label2 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.txtDuration = New System.Windows.Forms.TextBox
    Me.txtInterval = New System.Windows.Forms.TextBox
    Me.cmbSize = New System.Windows.Forms.ComboBox
    Me.Label13 = New System.Windows.Forms.Label
    Me.colText = New lucidcode.Controls.ColorPicker
    Me.Label12 = New System.Windows.Forms.Label
    Me.colBackground = New lucidcode.Controls.ColorPicker
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblInterval = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.cmbTransparency = New System.Windows.Forms.ComboBox
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.Panel3D3 = New lucidcode.Controls.Panel3D
    Me.Label8 = New System.Windows.Forms.Label
    Me.txtMessages = New System.Windows.Forms.TextBox
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel3D1.SuspendLayout()
    Me.Panel3D3.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Controls.Add(Me.TableLayoutPanel1)
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(732, 83)
    Me.Panel3D2.TabIndex = 6
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
        Me.Panel3D4.Size = New System.Drawing.Size(732, 24)
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
        Me.Label2.Size = New System.Drawing.Size(719, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Settings"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtDuration, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInterval, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSize, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.colText, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.colBackground, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInterval, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTransparency, 5, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(724, 52)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'txtDuration
        '
        Me.txtDuration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDuration.Location = New System.Drawing.Point(316, 3)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(151, 21)
        Me.txtDuration.TabIndex = 6
        '
        'txtInterval
        '
        Me.txtInterval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInterval.Location = New System.Drawing.Point(95, 3)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(151, 21)
        Me.txtInterval.TabIndex = 39
        '
        'cmbSize
        '
        Me.cmbSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.cmbSize.Location = New System.Drawing.Point(569, 27)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(152, 21)
        Me.cmbSize.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(473, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 28)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Size"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colText
        '
        Me.colText.Color = System.Drawing.Color.White
        Me.colText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colText.Location = New System.Drawing.Point(316, 27)
        Me.colText.Name = "colText"
        Me.colText.Size = New System.Drawing.Size(151, 22)
        Me.colText.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(252, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 28)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Text"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colBackground
        '
        Me.colBackground.Color = System.Drawing.Color.SteelBlue
        Me.colBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colBackground.Location = New System.Drawing.Point(95, 27)
        Me.colBackground.Name = "colBackground"
        Me.colBackground.Size = New System.Drawing.Size(151, 22)
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
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(473, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Transparency"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInterval
        '
        Me.lblInterval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInterval.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInterval.Location = New System.Drawing.Point(3, 0)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(86, 24)
        Me.lblInterval.TabIndex = 25
        Me.lblInterval.Text = "Interval"
        Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(252, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Duration"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTransparency
        '
        Me.cmbTransparency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbTransparency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransparency.FormattingEnabled = True
        Me.cmbTransparency.Items.AddRange(New Object() {"99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50", "49", "48", "47", "46", "45", "44", "43", "42", "41", "40", "39", "38", "37", "36", "35", "34", "33", "32", "31", "30", "29", "28", "27", "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cmbTransparency.Location = New System.Drawing.Point(569, 3)
        Me.cmbTransparency.Name = "cmbTransparency"
        Me.cmbTransparency.Size = New System.Drawing.Size(152, 21)
        Me.cmbTransparency.TabIndex = 31
        '
        'Panel3D1
        '
        Me.Panel3D1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D1.Controls.Add(Me.Panel3D3)
        Me.Panel3D1.Controls.Add(Me.txtMessages)
        Me.Panel3D1.Location = New System.Drawing.Point(0, 89)
        Me.Panel3D1.Name = "Panel3D1"
        Me.Panel3D1.Size = New System.Drawing.Size(732, 263)
        Me.Panel3D1.TabIndex = 30
        '
        'Panel3D3
        '
        Me.Panel3D3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D3.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor
        Me.Panel3D3.Controls.Add(Me.Label8)
        Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D3.Name = "Panel3D3"
        Me.Panel3D3.Size = New System.Drawing.Size(735, 24)
        Me.Panel3D3.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor
    Me.Label8.Location = New System.Drawing.Point(8, 3)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(722, 19)
    Me.Label8.TabIndex = 3
    Me.Label8.Text = "Messages"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtMessages
    '
    Me.txtMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtMessages.Location = New System.Drawing.Point(3, 25)
    Me.txtMessages.Multiline = True
    Me.txtMessages.Name = "txtMessages"
    Me.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtMessages.Size = New System.Drawing.Size(726, 235)
    Me.txtMessages.TabIndex = 2
    '
    'SubliminalViewControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Controls.Add(Me.Panel3D2)
    Me.Controls.Add(Me.Panel3D1)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Name = "SubliminalViewControl"
    Me.Size = New System.Drawing.Size(732, 352)
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblInterval As System.Windows.Forms.Label
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cmbTransparency As System.Windows.Forms.ComboBox
  Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents colText As lucidcode.Controls.ColorPicker
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents colBackground As lucidcode.Controls.ColorPicker
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents txtDuration As System.Windows.Forms.TextBox
  Friend WithEvents txtInterval As System.Windows.Forms.TextBox
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Public WithEvents txtMessages As System.Windows.Forms.TextBox

End Class
