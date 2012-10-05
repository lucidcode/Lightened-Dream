<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MerlinItemControl
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MerlinItemControl))
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.lblType = New System.Windows.Forms.Label
    Me.lblDescription = New System.Windows.Forms.Label
    Me.lstImgTlb = New System.Windows.Forms.ImageList(Me.components)
    Me.btnDelete = New System.Windows.Forms.Button
    Me.Panel3D2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.btnDelete)
    Me.Panel3D2.Controls.Add(Me.lblType)
    Me.Panel3D2.Controls.Add(Me.lblDescription)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(812, 25)
    Me.Panel3D2.TabIndex = 6
    '
    'lblType
    '
    Me.lblType.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lblType.Location = New System.Drawing.Point(2, 2)
    Me.lblType.Name = "lblType"
    Me.lblType.Size = New System.Drawing.Size(94, 21)
    Me.lblType.TabIndex = 39
    Me.lblType.Text = "Action"
    Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblDescription
    '
    Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblDescription.ForeColor = System.Drawing.Color.Black
    Me.lblDescription.Location = New System.Drawing.Point(102, 2)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(707, 21)
    Me.lblDescription.TabIndex = 40
    Me.lblDescription.Text = "Action"
    Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstImgTlb
    '
    Me.lstImgTlb.ImageStream = CType(resources.GetObject("lstImgTlb.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImgTlb.TransparentColor = System.Drawing.Color.White
    Me.lstImgTlb.Images.SetKeyName(0, "Action.Delete.bmp")
    '
    'btnDelete
    '
    Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Default
    Me.btnDelete.Font = New System.Drawing.Font("Verdana", 10.0!)
    Me.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue
    Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnDelete.ImageIndex = 0
    Me.btnDelete.ImageList = Me.lstImgTlb
    Me.btnDelete.Location = New System.Drawing.Point(782, 2)
    Me.btnDelete.Name = "btnDelete"
    Me.btnDelete.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
    Me.btnDelete.Size = New System.Drawing.Size(27, 22)
    Me.btnDelete.TabIndex = 310
    Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnDelete.UseVisualStyleBackColor = True
    '
    'MerlinItemControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Controls.Add(Me.Panel3D2)
    Me.Font = New System.Drawing.Font("Verdana", 8.25!)
    Me.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Name = "MerlinItemControl"
    Me.Size = New System.Drawing.Size(812, 25)
    Me.Panel3D2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents lblType As System.Windows.Forms.Label
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Public WithEvents btnDelete As System.Windows.Forms.Button
  Private WithEvents lstImgTlb As System.Windows.Forms.ImageList

End Class
