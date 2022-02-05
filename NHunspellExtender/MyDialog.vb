Imports System.Windows.Forms

Public Class MyDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub lblText_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.Resize
        'We need to resize the form to match
        If lblText.Width + 25 > 290 Then
            Me.Width = lblText.Width + 25
        Else
            Me.Width = 290
        End If

        If lblText.Height + 100 > 110 Then
            Me.Height = lblText.Height + 100
        Else
            Me.Height = 110
        End If
    End Sub

    Public Overloads Shared Function Show(ByVal Text As String, Optional ByVal Caption As String = "") As DialogResult
        Dim newDialog As New MyDialog
        newDialog.Text = Caption
        newDialog.lblText.Text = Text

        Dim myStackTrace As New StackTrace

        newDialog.ShowDialog()

        Dim disable As DialogResult

        If newDialog.chkDisable.Checked Then
            disable = Windows.Forms.DialogResult.Ignore
        Else
            disable = Windows.Forms.DialogResult.None
        End If

        Return newDialog.DialogResult + disable
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Public ReadOnly Property DisableFuturePrompts As Boolean
        Get
            Return chkDisable.Checked
        End Get
    End Property
End Class
