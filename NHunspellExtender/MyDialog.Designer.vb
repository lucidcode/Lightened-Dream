<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.chkDisable = New System.Windows.Forms.CheckBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdOK, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(119, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(145, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.Location = New System.Drawing.Point(75, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(66, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "No"
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOK.Location = New System.Drawing.Point(3, 3)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(66, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "Yes"
        '
        'chkDisable
        '
        Me.chkDisable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDisable.AutoSize = True
        Me.chkDisable.Location = New System.Drawing.Point(12, 44)
        Me.chkDisable.Name = "chkDisable"
        Me.chkDisable.Size = New System.Drawing.Size(97, 17)
        Me.chkDisable.TabIndex = 1
        Me.chkDisable.Text = "Disable Prompt"
        Me.chkDisable.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(9, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(402, 13)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "This is a test to see if the dialog will automatically resize the form when it ge" & _
            "ts too big"
        '
        'MyDialog
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 78)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.chkDisable)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MyDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents chkDisable As System.Windows.Forms.CheckBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button

End Class
