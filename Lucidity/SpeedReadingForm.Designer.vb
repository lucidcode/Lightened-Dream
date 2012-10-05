<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedReadingForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpeedReadingForm))
    Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
    Me.lblText = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'tmrLoad
    '
    Me.tmrLoad.Interval = 5000
    '
    'lblText
    '
    Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblText.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblText.ForeColor = System.Drawing.Color.White
    Me.lblText.Location = New System.Drawing.Point(0, 0)
    Me.lblText.Name = "lblText"
    Me.lblText.Size = New System.Drawing.Size(666, 410)
    Me.lblText.TabIndex = 1
    Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'SpeedReadingForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.SteelBlue
    Me.ClientSize = New System.Drawing.Size(666, 410)
    Me.Controls.Add(Me.lblText)
    Me.ForeColor = System.Drawing.Color.MidnightBlue
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.Name = "SpeedReadingForm"
    Me.ShowInTaskbar = False
    Me.Text = "SubliminalForm"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tmrLoad As System.Windows.Forms.Timer
  Friend WithEvents lblText As System.Windows.Forms.Label
End Class
