Imports System.IO
Imports System.Xml

Public Class FIELDForm

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_boolMouseDown As Boolean
    Private m_boolStartTime As DateTime

    Private Sub FIELDForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Check if the FIELD file exists
        If (File.Exists(m_strPath & "FIELD.ld3")) Then
            Dim xmlDocFIELD As New XmlDocument
            xmlDocFIELD.Load(m_strPath & "FIELD.ld3")
            txtAnthem.Text = xmlDocFIELD.DocumentElement.SelectSingleNode("Anthem").InnerText
        End If
        If txtAnthem.Text = "" Then
            txtAnthem.Text = m_strPath & "Anthem.mp3"
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOk_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOk.MouseDown
        m_boolMouseDown = True
        m_boolStartTime = DateTime.Now
    End Sub

    Private Sub btnOk_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOk.MouseUp
        m_boolMouseDown = False

        Try

            ' Play the anthem
            If (File.Exists(txtAnthem.Text)) Then

                objPlayer.close()
                Application.DoEvents()
                Me.objPlayer.settings.volume = 100
                objPlayer.URL = txtAnthem.Text

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.FIELD.Induce()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tmrFIELD_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFIELD.Tick
        If m_boolMouseDown Then
            Dim dtDiff As TimeSpan = DateTime.Now.Subtract(m_boolStartTime)
            Dim strDiff As String = ""

            If dtDiff.Days < 10 Then
                strDiff &= "0" & dtDiff.Days
            Else
                strDiff &= dtDiff.Days
            End If
            If dtDiff.Hours < 10 Then
                strDiff &= ":" & "0" & dtDiff.Hours
            Else
                strDiff &= ":" & dtDiff.Hours
            End If
            If dtDiff.Minutes < 10 Then
                strDiff &= ":" & "0" & dtDiff.Minutes
            Else
                strDiff &= ":" & dtDiff.Minutes
            End If
            If dtDiff.Seconds < 10 Then
                strDiff &= ":" & "0" & dtDiff.Seconds
            Else
                strDiff &= ":" & dtDiff.Seconds
            End If
            If dtDiff.Milliseconds < 10 Then
                strDiff &= ":" & "0" & dtDiff.Milliseconds
            Else
                strDiff &= ":" & dtDiff.Milliseconds
            End If

            Text = "FIELD Inducer - " & strDiff
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            If objOpenFileDialog.ShowDialog = DialogResult.OK Then
                txtAnthem.Text = objOpenFileDialog.FileName
            End If

            ' Save the FIELD file
            Dim strXml As String
            strXml = "<LightenedDream>"
            strXml += "<Anthem>"
            strXml += "</Anthem>"
            strXml += "</LightenedDream>"
            Dim xmlDocFIELD As New XmlDocument
            xmlDocFIELD.LoadXml(strXml)
            xmlDocFIELD.DocumentElement.SelectSingleNode("Anthem").InnerText = txtAnthem.Text
            xmlDocFIELD.Save(m_strPath & "FIELD.ld3")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.FIELD.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class