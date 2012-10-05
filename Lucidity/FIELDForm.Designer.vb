<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIELDForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIELDForm))
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.btnBrowse = New System.Windows.Forms.Button
    Me.Panel3D3 = New lucidcode.Controls.Panel3D
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtAnthem = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.btnOk = New System.Windows.Forms.Button
    Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
    Me.btnCancel = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.tmrFIELD = New System.Windows.Forms.Timer(Me.components)
    Me.objPlayer = New AxWMPLib.AxWindowsMediaPlayer
    Me.objOpenFileDialog = New System.Windows.Forms.OpenFileDialog
    Me.Panel3D1.SuspendLayout()
    Me.Panel3D3.SuspendLayout()
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel3D1
    '
    Me.Panel3D1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D1.Controls.Add(Me.btnBrowse)
    Me.Panel3D1.Controls.Add(Me.Panel3D3)
    Me.Panel3D1.Controls.Add(Me.txtAnthem)
    Me.Panel3D1.Controls.Add(Me.Label4)
    Me.Panel3D1.Location = New System.Drawing.Point(12, 12)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(548, 57)
    Me.Panel3D1.TabIndex = 16
    '
    'btnBrowse
    '
    Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnBrowse.Font = New System.Drawing.Font("Verdana", 10.0!)
    Me.btnBrowse.ForeColor = System.Drawing.Color.MidnightBlue
    Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBrowse.ImageIndex = 0
    Me.btnBrowse.Location = New System.Drawing.Point(509, 26)
    Me.btnBrowse.Name = "btnBrowse"
    Me.btnBrowse.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
    Me.btnBrowse.Size = New System.Drawing.Size(31, 23)
    Me.btnBrowse.TabIndex = 36
    Me.btnBrowse.Text = "..."
    Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnBrowse.UseVisualStyleBackColor = True
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
    Me.Panel3D3.Size = New System.Drawing.Size(548, 24)
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
    Me.Label7.Size = New System.Drawing.Size(537, 19)
    Me.Label7.TabIndex = 3
    Me.Label7.Text = "Settings"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtAnthem
    '
    Me.txtAnthem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtAnthem.Location = New System.Drawing.Point(99, 27)
    Me.txtAnthem.Name = "txtAnthem"
    Me.txtAnthem.Size = New System.Drawing.Size(404, 21)
    Me.txtAnthem.TabIndex = 39
    '
    'Label4
    '
    Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label4.Location = New System.Drawing.Point(7, 27)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(86, 24)
    Me.Label4.TabIndex = 25
    Me.Label4.Text = "Anthem"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
    Me.btnOk.Location = New System.Drawing.Point(455, 75)
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
    Me.btnCancel.Location = New System.Drawing.Point(344, 75)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
    Me.btnCancel.Size = New System.Drawing.Size(105, 39)
    Me.btnCancel.TabIndex = 3
    Me.btnCancel.Text = "&Cancel"
    Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label2.Location = New System.Drawing.Point(12, 72)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(326, 42)
    Me.Label2.TabIndex = 34
    Me.Label2.Text = "Click and hold down the induce button and the anthem will play when you let go. T" & _
        "he idea is to catch yourself when you fall asleep - in a dream, but awake." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'tmrFIELD
    '
    Me.tmrFIELD.Enabled = True
    '
    'objPlayer
    '
    Me.objPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.objPlayer.Enabled = True
    Me.objPlayer.Location = New System.Drawing.Point(99, 9)
    Me.objPlayer.Name = "objPlayer"
    Me.objPlayer.OcxState = CType(resources.GetObject("objPlayer.OcxState"), System.Windows.Forms.AxHost.State)
    Me.objPlayer.Size = New System.Drawing.Size(373, 45)
    Me.objPlayer.TabIndex = 35
    Me.objPlayer.Visible = False
    '
    'objOpenFileDialog
    '
    Me.objOpenFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*"
    Me.objOpenFileDialog.Title = "REM Cycles - Import"
    '
    'FIELDForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
    Me.ClientSize = New System.Drawing.Size(572, 120)
    Me.Controls.Add(Me.objPlayer)
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
    Me.Name = "FIELDForm"
    Me.Text = "FIELD Inducer"
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.Panel3D3.ResumeLayout(False)
    CType(Me.objPlayer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
    Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents lstImgTlb As System.Windows.Forms.ImageList
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtAnthem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrFIELD As System.Windows.Forms.Timer
    Friend WithEvents objPlayer As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents objOpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
