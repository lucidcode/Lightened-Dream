Imports System.Xml
Imports System.IO

Public Class FolderViewControl

  Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\Lucidity\"
    Private m_strFolder As String
    Public Playing As Boolean = False

    Public Event LucidItemSelected(ByVal Category As String, ByVal FileName As String)
    Private m_objMerlinViewControl As MerlinViewControl = New MerlinViewControl

    Public Sub LoadFolder(ByVal Folder As String)
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

    Public Sub Play(ByVal Merlin As AxAgentObjects.AxAgent)
        Try

            m_objMerlinViewControl.objMerlin = Merlin
            Randomize()

            If m_strFolder = "Checks" Then
                DoCheck()
                Playing = True
                tmrChecks.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Checks.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopRunning()
        Try

            If m_strFolder = "Checks" Then
                m_objMerlinViewControl.StopRunning()
                Playing = False
                tmrChecks.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Checks.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DoCheck()
        Try

            tmrChecks.Interval = (600000) + (Rnd() * 1200000)
            m_objMerlinViewControl.LoadFile(m_strPath + m_strFolder + "\" + lstLucidity.Items(GetRandomItem(lstLucidity.Items.Count)).Text + ".ld3")
            m_objMerlinViewControl.Play()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Checks.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Function GetRandomItem(ByVal Max As Integer) As Integer
    Dim intId As Integer = Rnd() * Max
    If intId >= Max Then intId = Max - 1
    Return intId
  End Function

  Private Sub tmrChecks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChecks.Tick
    DoCheck()
  End Sub

End Class
