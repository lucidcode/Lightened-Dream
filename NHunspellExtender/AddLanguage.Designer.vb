<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLanguage
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDic = New System.Windows.Forms.TextBox()
        Me.cmdAff = New System.Windows.Forms.Button()
        Me.cmdDic = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 20)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Aff Path:"
        '
        'txtAff
        '
        Me.txtAff.Location = New System.Drawing.Point(69, 32)
        Me.txtAff.Name = "txtAff"
        Me.txtAff.ReadOnly = True
        Me.txtAff.Size = New System.Drawing.Size(224, 20)
        Me.txtAff.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dic Path:"
        '
        'txtDic
        '
        Me.txtDic.Location = New System.Drawing.Point(69, 58)
        Me.txtDic.Name = "txtDic"
        Me.txtDic.ReadOnly = True
        Me.txtDic.Size = New System.Drawing.Size(224, 20)
        Me.txtDic.TabIndex = 4
        '
        'cmdAff
        '
        Me.cmdAff.Image = Global.NHunspellExtender.My.Resources.Resources.folder_go
        Me.cmdAff.Location = New System.Drawing.Point(299, 30)
        Me.cmdAff.Name = "cmdAff"
        Me.cmdAff.Size = New System.Drawing.Size(29, 23)
        Me.cmdAff.TabIndex = 6
        Me.cmdAff.UseVisualStyleBackColor = True
        '
        'cmdDic
        '
        Me.cmdDic.Image = Global.NHunspellExtender.My.Resources.Resources.folder_go
        Me.cmdDic.Location = New System.Drawing.Point(299, 56)
        Me.cmdDic.Name = "cmdDic"
        Me.cmdDic.Size = New System.Drawing.Size(29, 23)
        Me.cmdDic.TabIndex = 7
        Me.cmdDic.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(253, 85)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 8
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'AddLanguage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 118)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.cmdDic)
        Me.Controls.Add(Me.cmdAff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "AddLanguage"
        Me.Text = "Add a New Language"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDic As System.Windows.Forms.TextBox
    Friend WithEvents cmdAff As System.Windows.Forms.Button
    Friend WithEvents cmdDic As System.Windows.Forms.Button
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
End Class
