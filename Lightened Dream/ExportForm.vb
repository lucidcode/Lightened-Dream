Public Class ExportForm

  Private m_boolChecking As Boolean

  Private Sub ExportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Close()
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

  End Sub

  Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
    m_boolChecking = True
    CheckNodes(trvMain.Nodes, chkSelectAll.Checked)
    m_boolChecking = False
  End Sub

  Private Sub CheckNodes(ByVal Nodes As TreeNodeCollection, ByVal Checked As Boolean)
    For Each trvNode As TreeNode In Nodes
      trvNode.Checked = Checked
      CheckNodes(trvNode.Nodes, Checked)
    Next
  End Sub

  Private Sub trvMain_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterCheck
    If m_boolChecking Then Return

    CheckNodes(e.Node.Nodes, e.Node.Checked)
  End Sub
End Class