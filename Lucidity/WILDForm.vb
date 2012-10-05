Public Class WILDForm

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Close()
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    Try

      Dim formFlashes As New Lucidity.FlashesForm(txtInterval.Text)
      formFlashes.FlashColor = colText.Color
      formFlashes.BackColor = colBackground.Color
      formFlashes.Timeout = cmbLength.Text * 1000
      formFlashes.Show()
      formFlashes.Play()

    Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.WILD.Induce()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
    tmrLoad.Enabled = False
    cmbLength.Text = 15
  End Sub
End Class