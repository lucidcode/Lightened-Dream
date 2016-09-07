Imports System.Xml
Imports System.IO

Public Class DataDirectoryForm

    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\"
    Private m_strOldPath As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try

            ' Check if the path has changed
            If m_strOldPath <> txtDataDirectory.Text Then

                ' Make sure the new directory exists
                If Not Directory.Exists(txtDataDirectory.Text) Then
                    Directory.CreateDirectory(txtDataDirectory.Text)
                End If

                ' Check if there already is a Lightened Dream directory
                If Directory.Exists(txtDataDirectory.Text + "\Lightened Dream") Then
                    ' Check if there are any files in it
                    If (Directory.GetFiles(txtDataDirectory.Text + "\Lightened Dream").Length > 0) Then
                        ' Move the pre-existing files to a backup folder
                        Directory.Move(txtDataDirectory.Text + "\Lightened Dream", txtDataDirectory.Text + "\Lightened Dream" + DateTime.Now.ToString(" - Backup yyyy-MM-Mdd_HHmmss"))
                    Else
                        Directory.Delete(txtDataDirectory.Text + "\Lightened Dream")
                    End If
                End If

                ' Move the data
                FileIO.FileSystem.MoveDirectory(m_strOldPath + "\Lightened Dream", txtDataDirectory.Text + "\Lightened Dream")

                ' Save the new path
                Dim xmlDocDataDirectory As New XmlDocument
                Dim strXml As String = ""
                strXml = "<LightenedDream>"
                strXml += "<Directory></Directory>"
                strXml += "</LightenedDream>"
                xmlDocDataDirectory.LoadXml(strXml)
                xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText = txtDataDirectory.Text
                xmlDocDataDirectory.Save(m_strPath & "LightenedDreamDirectory.ld3")

                Application.Restart()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.SetDataDirectory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Try

            If (File.Exists(m_strPath & "LightenedDreamDirectory.ld3")) Then
                Dim xmlDocDataDirectory As New XmlDocument
                xmlDocDataDirectory.Load(m_strPath & "LightenedDreamDirectory.ld3")
                txtDataDirectory.Text = xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText
            Else
                txtDataDirectory.Text = m_strPath
            End If

            m_strOldPath = txtDataDirectory.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.LoadDataDirectory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class