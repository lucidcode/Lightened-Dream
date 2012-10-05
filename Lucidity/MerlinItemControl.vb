Public Class MerlinItemControl

  Public Event Delete(ByRef Item As MerlinItemControl)
  Public Event Edit(ByRef Item As MerlinItemControl)

  Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    RaiseEvent Delete(Me)
  End Sub

  Private Sub lblType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblType.Click
    RaiseEvent Edit(Me)
  End Sub

  Private Sub lblDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescription.Click
    RaiseEvent Edit(Me)
  End Sub
End Class
