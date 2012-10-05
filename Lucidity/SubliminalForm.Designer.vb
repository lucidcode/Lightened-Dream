<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubliminalForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubliminalForm))
    Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.lblText = New System.Windows.Forms.Label
    Me.tmrHide = New System.Windows.Forms.Timer(Me.components)
    Me.Panel3D1.SuspendLayout()
    Me.SuspendLayout()
    '
    'tmrLoad
    '
    Me.tmrLoad.Enabled = True
    Me.tmrLoad.Interval = 5000
    '
    'Panel3D1
    '
    Me.Panel3D1.Controls.Add(Me.lblText)
    Me.Panel3D1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D1.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(192, 21)
    Me.Panel3D1.TabIndex = 13
    '
    'lblText
    '
    Me.lblText.AutoSize = True
    Me.lblText.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblText.ForeColor = System.Drawing.Color.White
    Me.lblText.Location = New System.Drawing.Point(2, 2)
    Me.lblText.MaximumSize = New System.Drawing.Size(256, 0)
    Me.lblText.Name = "lblText"
    Me.lblText.Size = New System.Drawing.Size(0, 16)
    Me.lblText.TabIndex = 1
    Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'tmrHide
    '
    Me.tmrHide.Interval = 5000
    '
    'SubliminalForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.SteelBlue
    Me.ClientSize = New System.Drawing.Size(192, 21)
    Me.Controls.Add(Me.Panel3D1)
    Me.ForeColor = System.Drawing.Color.MidnightBlue
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "SubliminalForm"
    Me.Opacity = 0.8
    Me.ShowInTaskbar = False
    Me.Text = "SubliminalForm"
    Me.TopMost = True
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents lblText As System.Windows.Forms.Label
  Friend WithEvents tmrHide As System.Windows.Forms.Timer
End Class
