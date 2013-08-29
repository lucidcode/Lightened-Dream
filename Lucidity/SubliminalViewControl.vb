Imports System.Xml

Public Class SubliminalViewControl

  Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\Lucidity\Subliminals"
    Private m_formSubliminal As SubliminalForm
    Public Changed As Boolean
    Public Playing As Boolean = False

    Public Sub LoadFile(ByVal strFileName As String)
        Try
            Dim xmlDoc As New XmlDocument
            FileName = strFileName
            xmlDoc.Load(FileName)

            ' Set default values
            txtInterval.Text = 5000
            txtDuration.Text = 1000
            cmbTransparency.Text = 50
            cmbSize.Text = 12

            Try
                If xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText <> "" Then
                    txtInterval.Text = xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText
                End If
                If xmlDoc.DocumentElement.SelectSingleNode("Duration").InnerText <> "" Then
                    txtDuration.Text = xmlDoc.DocumentElement.SelectSingleNode("Duration").InnerText
                End If
                If xmlDoc.DocumentElement.SelectSingleNode("Transparency").InnerText <> "" Then
                    cmbTransparency.Text = xmlDoc.DocumentElement.SelectSingleNode("Transparency").InnerText
                End If
                If xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText <> "" Then
                    colBackground.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText)
                End If
                If xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText <> "" Then
                    colText.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText)
                End If
                If xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText <> "" Then
                    cmbSize.Text = xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText
                End If
            Catch ex2 As Exception
                txtInterval.Text = 5000
                txtDuration.Text = 1000
                cmbTransparency.Text = 50
                cmbSize.Text = 12
            End Try

            txtMessages.Text = ""
            For Each xmlMessage As XmlNode In xmlDoc.DocumentElement.SelectNodes("Messages/Message")
                txtMessages.Text += xmlMessage.InnerText + vbNewLine
            Next

            ' Remove last NewLine
            If txtMessages.Text.Length > 0 Then
                txtMessages.Text = txtMessages.Text.Substring(0, txtMessages.Text.Length - 1)
            End If
            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save(ByVal Title As String, ByVal Description As String, ByVal strFileName As String)
        Try
            Dim strXml As String
            FileName = strFileName

            strXml = "<Subliminal>"
            strXml += "<Title>" + Title + "</Title>"
            strXml += "<Description>" + Description + "</Description>"
            strXml += "<Interval>" + txtInterval.Text + "</Interval>"
            strXml += "<Duration>" + txtDuration.Text + "</Duration>"
            strXml += "<Transparency>" + cmbTransparency.Text + "</Transparency>"
            strXml += "<Background>" + colBackground.Color.ToArgb.ToString() + "</Background>"
            strXml += "<Text>" + colText.Color.ToArgb.ToString() + "</Text>"
            strXml += "<Size>" + cmbSize.Text + "</Size>"
            strXml += "<Messages>"
            For Each strMessage As String In txtMessages.Text.Split(vbNewLine)
                Dim strReplaces = strMessage.Replace(vbNewLine, "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
                If strReplaces <> "" Then
                    strXml += "<Message>" + strReplaces & "</Message>"
                End If
            Next
            strXml += "</Messages>"
            strXml += "</Subliminal>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(FileName)
            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Play()
        Try

            If Not m_formSubliminal Is Nothing Then
                m_formSubliminal.Close()
            End If

            m_formSubliminal = New SubliminalForm(txtInterval.Text, txtDuration.Text, (100 - cmbTransparency.Text) / 100, colBackground.Color, colText.Color, txtMessages.Text.Split(vbNewLine), New Font(lblInterval.Font.FontFamily, Convert.ToSingle(cmbSize.Text), FontStyle.Regular))
            m_formSubliminal.Show()
            Playing = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopRunning()
        Try
            If Not m_formSubliminal Is Nothing Then
                m_formSubliminal.Close()
            End If
            Playing = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub txtInterval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterval.TextChanged
    Changed = True
  End Sub

  Private Sub txtDuration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDuration.TextChanged
    Changed = True
  End Sub

  Private Sub txtMessages_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessages.TextChanged
    Changed = True
  End Sub

  Private Sub cmbTransparency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransparency.SelectedIndexChanged
    Changed = True
  End Sub

  Private Sub cmbSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSize.SelectedIndexChanged
    Changed = True
  End Sub

  Private Sub colText_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colText.ColorChanged
    Changed = True
  End Sub

  Private Sub colBackground_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colBackground.ColorChanged
    Changed = True
  End Sub
End Class
