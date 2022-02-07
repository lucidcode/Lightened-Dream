<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpellCheckForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lboSuggestions = New System.Windows.Forms.ListBox()
        Me.cmdIgnoreOnce = New System.Windows.Forms.Button()
        Me.cmdIgnoreAll = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdChangeAll = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtCurrentSentence = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Not in Dictionary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Suggestions:"
        '
        'lboSuggestions
        '
        Me.lboSuggestions.FormattingEnabled = True
        Me.lboSuggestions.Location = New System.Drawing.Point(15, 127)
        Me.lboSuggestions.Name = "lboSuggestions"
        Me.lboSuggestions.ScrollAlwaysVisible = True
        Me.lboSuggestions.Size = New System.Drawing.Size(297, 82)
        Me.lboSuggestions.TabIndex = 3
        '
        'cmdIgnoreOnce
        '
        Me.cmdIgnoreOnce.Location = New System.Drawing.Point(328, 23)
        Me.cmdIgnoreOnce.Name = "cmdIgnoreOnce"
        Me.cmdIgnoreOnce.Size = New System.Drawing.Size(104, 22)
        Me.cmdIgnoreOnce.TabIndex = 4
        Me.cmdIgnoreOnce.Text = "Ignore Once"
        Me.cmdIgnoreOnce.UseVisualStyleBackColor = True
        '
        'cmdIgnoreAll
        '
        Me.cmdIgnoreAll.Location = New System.Drawing.Point(328, 56)
        Me.cmdIgnoreAll.Name = "cmdIgnoreAll"
        Me.cmdIgnoreAll.Size = New System.Drawing.Size(104, 21)
        Me.cmdIgnoreAll.TabIndex = 5
        Me.cmdIgnoreAll.Text = "Ignore All"
        Me.cmdIgnoreAll.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(328, 87)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(104, 21)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "Add to Dictionary"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(328, 127)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(104, 21)
        Me.cmdChange.TabIndex = 7
        Me.cmdChange.Text = "Change"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdChangeAll
        '
        Me.cmdChangeAll.Location = New System.Drawing.Point(328, 158)
        Me.cmdChangeAll.Name = "cmdChangeAll"
        Me.cmdChangeAll.Size = New System.Drawing.Size(104, 21)
        Me.cmdChangeAll.TabIndex = 8
        Me.cmdChangeAll.Text = "Change All"
        Me.cmdChangeAll.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(328, 188)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(104, 21)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtCurrentSentence
        '
        Me.txtCurrentSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentSentence.Location = New System.Drawing.Point(15, 25)
        Me.txtCurrentSentence.Name = "txtCurrentSentence"
        Me.txtCurrentSentence.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtCurrentSentence.Size = New System.Drawing.Size(297, 82)
        Me.txtCurrentSentence.TabIndex = 10
        Me.txtCurrentSentence.Text = ""
        '
        'SpellCheckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 229)
        Me.Controls.Add(Me.txtCurrentSentence)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdChangeAll)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdIgnoreAll)
        Me.Controls.Add(Me.cmdIgnoreOnce)
        Me.Controls.Add(Me.lboSuggestions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SpellCheckForm"
        Me.Text = "Spelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lboSuggestions As System.Windows.Forms.ListBox
    Friend WithEvents cmdIgnoreOnce As System.Windows.Forms.Button
    Friend WithEvents cmdIgnoreAll As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents cmdChangeAll As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtCurrentSentence As System.Windows.Forms.RichTextBox
End Class
