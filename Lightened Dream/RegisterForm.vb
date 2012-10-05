Public Class RegisterForm

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Close()
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    Try
      Dim objEmailService As New EmailService.EmailService()
      Dim strResult As String = objEmailService.Send(txtReplyAddress.Text, "Update Request", Environment.OSVersion.ToString, "")

      If strResult = "Success!" Then
                MessageBox.Show("Thank you for your update request! An email will be sent to " & txtReplyAddress.Text & " when the next version is released.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(strResult, "LightenedDream.Register.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Register.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class