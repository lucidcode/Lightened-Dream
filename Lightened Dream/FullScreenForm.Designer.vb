<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullScreenForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullScreenForm))
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.pnlContainer = New System.Windows.Forms.Panel
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.pnlClose = New lucidcode.Controls.Panel3D
    Me.lblClose = New System.Windows.Forms.Label
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.pnlClose.SuspendLayout()
    Me.SuspendLayout()
    '
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "Sounds.ico")
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.pnlContainer)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(836, 498)
    Me.Panel3D2.TabIndex = 9
    '
    'pnlContainer
    '
    Me.pnlContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlContainer.Location = New System.Drawing.Point(3, 25)
    Me.pnlContainer.Name = "pnlContainer"
    Me.pnlContainer.Size = New System.Drawing.Size(830, 470)
    Me.pnlContainer.TabIndex = 7
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = System.Drawing.Color.SteelBlue
    Me.Panel3D4.Controls.Add(Me.pnlClose)
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.Label2)
    Me.Panel3D4.ForeColor = System.Drawing.Color.White
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(836, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'pnlClose
    '
    Me.pnlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pnlClose.BackColor = System.Drawing.Color.SteelBlue
    Me.pnlClose.Controls.Add(Me.lblClose)
    Me.pnlClose.Location = New System.Drawing.Point(813, 0)
    Me.pnlClose.Name = "pnlClose"
    Me.pnlClose.Size = New System.Drawing.Size(23, 24)
    Me.pnlClose.TabIndex = 6
    '
    'lblClose
    '
    Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblClose.BackColor = System.Drawing.Color.LightSteelBlue
    Me.lblClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblClose.ForeColor = System.Drawing.Color.Black
    Me.lblClose.Location = New System.Drawing.Point(3, 3)
    Me.lblClose.Name = "lblClose"
    Me.lblClose.Size = New System.Drawing.Size(17, 19)
    Me.lblClose.TabIndex = 3
    Me.lblClose.Text = "_"
    Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.Location = New System.Drawing.Point(26, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(807, 19)
    Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Lightened Dream"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FullScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.LightenedDream.My.MySettings.Default.FormBackColor
        Me.ClientSize = New System.Drawing.Size(836, 498)
        Me.Controls.Add(Me.Panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.LightenedDream.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FullScreenForm"
        Me.ShowInTaskbar = False
        Me.Text = "Lightened Dream"
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.pnlClose.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents pnlContainer As System.Windows.Forms.Panel
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pnlClose As lucidcode.Controls.Panel3D
  Public WithEvents lblClose As System.Windows.Forms.Label
End Class
