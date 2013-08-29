Imports System.Xml
Imports System.IO

Public Class WhyLDForm

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try

            Dim xmlDocReason As New XmlDocument
            Dim strXml As String = ""

            ' Create the reason file
            strXml = "<LightenedDream>"
            strXml += "<Reason></Reason>"
            strXml += "</LightenedDream>"
            xmlDocReason.LoadXml(strXml)
            xmlDocReason.DocumentElement.SelectSingleNode("Reason").InnerText = txtReason.Text
            xmlDocReason.Save(m_strPath & "WhyLD.ld3")

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.WhyLD()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Try

            Dim xmlDocReason As New XmlDocument
            Dim strXml As String = ""

            ' Make sure that the reason file exists
            If (Not File.Exists(m_strPath & "WhyLD.ld3")) Then
                ' Create the reason file
                strXml = "<LightenedDream>"
                strXml += "<Reason></Reason>"
                strXml += "</LightenedDream>"
                xmlDocReason.LoadXml(strXml)
                xmlDocReason.Save(m_strPath & "WhyLD.ld3")
            End If

            xmlDocReason.Load(m_strPath & "WhyLD.ld3")
            txtReason.Text = xmlDocReason.DocumentElement.SelectSingleNode("Reason").InnerText

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.WhyLD()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class