Imports System.Xml
Imports System.IO

Public Class ExercisesViewControl

  Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\Lucidity\"
    Private m_strFolder As String

    Public Event LucidItemSelected(ByVal Category As String, ByVal FileName As String)

    Public Sub LoadFiles(ByVal Folder As String)
        Try

            m_strFolder = Folder
            lblTitle.Text = "Lucidity - " & m_strFolder
            lstLucidity.Items.Clear()
            For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + m_strFolder, "*.ld3")
                Dim lstItem As New ListViewItem(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
                lstItem.ImageIndex = lstImg.Images.IndexOfKey(m_strFolder)
                lstLucidity.Items.Add(lstItem)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Items.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub lstLucdity_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstLucidity.MouseMove
    If Not lstLucidity.GetItemAt(e.X, e.Y) Is Nothing Then
      lstLucidity.Cursor = Cursors.Hand
    Else
      lstLucidity.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub lstLucdity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLucidity.SelectedIndexChanged
    If lstLucidity.SelectedItems.Count = 0 Then Return
    RaiseEvent LucidItemSelected(m_strFolder, lstLucidity.SelectedItems(0).Text)
  End Sub
End Class
