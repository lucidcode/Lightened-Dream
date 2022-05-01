Imports System.Net
Imports System.IO
Imports System.Threading

Public Class AboutForm

    Private m_strUpdateURL As String = "https://www.lucid-code.com/LightenedDream"
    Private m_boolClosing As Boolean = False

    Private Sub AboutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = Application.ProductVersion
    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Try

            Dim objUpdater As New UpdateClass
            Dim objUpdateThread As New Thread(AddressOf objUpdater.CheckForUpdate)
            objUpdateThread.Start()

            Do
                Application.DoEvents()
                System.Threading.Thread.Sleep(10)

                If objUpdater.Complete Then
                    Exit Do
                End If
                If m_boolClosing Then
                    'objUpdateThread.Abort()
                    Exit Sub
                End If
            Loop

            If UpdateAvailable(objUpdater.Version) Then
                m_strUpdateURL = objUpdater.URL
                lblUpdate.Visible = True
                lblUpdate.Text = "A new version (" & objUpdater.Version & ") is available. Download now!"
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Function UpdateAvailable(ByVal NewVersion As String) As Boolean
        Try

            Dim OldVersion As String = lblVersion.Text
            Dim arrOldVersion() As String = Split(lblVersion.Text, ".") ' 2.9.9.0
            Dim arrNewVersion() As String = Split(NewVersion, ".") '    ' 2.9.9.1

            If Val(arrNewVersion(0)) > Val(arrOldVersion(0)) Then
                Return True
            Else
                If Val(arrNewVersion(1)) > Val(arrOldVersion(1)) Then
                    Return True
                Else
                    If Val(arrNewVersion(2)) > Val(arrOldVersion(2)) Then
                        Return True
                    Else
                        If Val(arrNewVersion(3)) > Val(arrOldVersion(3)) Then
                            Return True
                        Else
                            Return False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub lblUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblUpdate.LinkClicked
        Try
            System.Diagnostics.Process.Start(m_strUpdateURL)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.About.Link()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblWeb.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://www.lucidcode.com/LightenedDream/")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.About.Link()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AboutForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        m_boolClosing = True
    End Sub

    Private Class UpdateClass

        Public Version As String
        Public URL As String
        Public Complete As Boolean = False

        Public Sub CheckForUpdate()
            Try

                WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials
                Dim objRequest As HttpWebRequest = CType(WebRequest.Create("https://www.lucid-code.com/LightenedDream/updates/LatestVersion.html"), HttpWebRequest)
                objRequest.Method = "GET"
                Dim objWebResponse As HttpWebResponse = CType(objRequest.GetResponse(), HttpWebResponse)
                Dim objResponseStream As StreamReader = New StreamReader(objWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding(1252))
                Dim strResponse = objResponseStream.ReadToEnd()
                objWebResponse.Close()
                objResponseStream.Close()

                If strResponse.StartsWith("Version ") Then
                    Dim arrLines() As String = strResponse.Split(vbNewLine)
                    Version = arrLines(0).Replace("Version ", "")
                    URL = arrLines(1)
                End If

            Catch ex As Exception
            End Try

            Complete = True
        End Sub

    End Class
End Class