Public Class SupportForm

  Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
    tmrLoad.Enabled = False
    cmbType.Text = "Comment"
    Try
      txtOS.Text = Environment.OSVersion.ToString
    Catch ex As Exception

    End Try
    txtReplyAddress.Focus()
    Application.DoEvents()
    webSupport.Url = New Uri("https://www.lucid-code.com/LightenedDream/Support")
  End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            Dim objEmailService As New EmailService.EmailService()
            Dim strResult As String = objEmailService.Send(txtReplyAddress.Text, cmbType.Text, txtOS.Text, txtMessage.Text)

            If strResult = "Success!" Then
                MessageBox.Show("The message has been sent. Thank you for your " & cmbType.Text.ToLower & "!", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(strResult, "LightenedDream.Support.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Support.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class