Imports System.Xml
Imports System.IO

Public Class LucidityControl

  Public Event LucidFolderSelected(ByVal Category As String)

  Private Sub lstLucdity_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstLucidity.MouseMove
    If Not lstLucidity.GetItemAt(e.X, e.Y) Is Nothing Then
      lstLucidity.Cursor = Cursors.Hand
    Else
      lstLucidity.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub lstLucdity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLucidity.SelectedIndexChanged
    If lstLucidity.SelectedItems.Count = 0 Then Return
    RaiseEvent LucidFolderSelected(lstLucidity.SelectedItems(0).Text)
  End Sub

End Class
