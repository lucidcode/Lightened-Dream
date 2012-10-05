Imports System.Xml

Public Class SpeedReadingViewControl

  Public FileName As String
  Private m_formSpeedReading As SpeedReadingForm
  Public Changed As Boolean

  Public Sub LoadFile(ByVal strFileName As String)
    Try
      Dim xmlDoc As New XmlDocument
      FileName = strFileName
      xmlDoc.Load(FileName)

      ' Set defaults
      txtInterval.Text = 1024
      txtWidth.Text = -1
      txtHeight.Text = -1
      cmbSize.Text = 36

      Try
        If xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText <> "" Then
          txtInterval.Text = xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText
        End If
        If xmlDoc.DocumentElement.SelectSingleNode("Width").InnerText <> "" Then
          txtWidth.Text = xmlDoc.DocumentElement.SelectSingleNode("Width").InnerText
        End If
        If xmlDoc.DocumentElement.SelectSingleNode("Height").InnerText <> "" Then
          txtHeight.Text = xmlDoc.DocumentElement.SelectSingleNode("Height").InnerText
        End If
        If xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText <> "" Then
          cmbSize.Text = xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText
        End If
        If xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText <> "" Then
          colBackground.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText)
        End If
        If xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText <> "" Then
          colText.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText)
        End If
      Catch ex2 As Exception
        txtInterval.Text = 1000
        txtWidth.Text = -1
        txtHeight.Text = -1
        cmbSize.Text = 36
      End Try

      txtReadings.Text = ""
      For Each xmlMessage As XmlNode In xmlDoc.DocumentElement.SelectNodes("Messages/Message")
        txtReadings.Text += xmlMessage.InnerText + vbNewLine
      Next

      ' Remove last NewLine
      If txtReadings.Text.Length > 0 Then
        txtReadings.Text = txtReadings.Text.Substring(0, txtReadings.Text.Length - 1)
      End If
      Changed = False

    Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save(ByVal Title As String, ByVal Description As String, ByVal strFileName As String)
        Try
            Dim strXml As String

            FileName = strFileName

            strXml = "<Reading>"
            strXml += "<Title>" + Title + "</Title>"
            strXml += "<Description>" + Description + "</Description>"
            strXml += "<Interval>" + txtInterval.Text + "</Interval>"
            strXml += "<Width>" + txtWidth.Text + "</Width>"
            strXml += "<Height>" + txtHeight.Text + "</Height>"
            strXml += "<Background>" + colBackground.Color.ToArgb.ToString() + "</Background>"
            strXml += "<Text>" + colText.Color.ToArgb.ToString() + "</Text>"
            strXml += "<Size>" + cmbSize.Text + "</Size>"
            strXml += "<Messages>"
            For Each strMessage As String In txtReadings.Text.Split(vbNewLine)
                Dim strReplaces = strMessage.Replace(vbNewLine, "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
                strXml += "<Message>" + strReplaces & "</Message>"
            Next
            strXml += "</Messages>"
            strXml += "</Reading>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(FileName)
            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Play()
        Try
            If Not m_formSpeedReading Is Nothing Then
                m_formSpeedReading.Close()
            End If

            m_formSpeedReading = New SpeedReadingForm(txtInterval.Text)
            m_formSpeedReading.BackColor = colBackground.Color
            m_formSpeedReading.lblText.ForeColor = colText.Color
            m_formSpeedReading.lblText.Font = New Font(m_formSpeedReading.lblText.Font.FontFamily, Convert.ToInt32(cmbSize.Text), FontStyle.Regular)
            m_formSpeedReading.Messages = txtReadings.Text.Split(vbNewLine)
            m_formSpeedReading.Show()
            m_formSpeedReading.Top = 0
            m_formSpeedReading.Left = 0
            m_formSpeedReading.Play()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopRunning()
        Try
            If m_formSpeedReading Is Nothing Then
                m_formSpeedReading.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
    Dim arrWords() As String = txtReadings.Text.Split(" ")
    txtReadings.Text = ""
    For Each strWord As String In arrWords
      txtReadings.Text &= strWord & vbNewLine
    Next
  End Sub

  Private Sub txtInterval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInterval.TextChanged
    Changed = True
  End Sub

  Private Sub txtWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWidth.TextChanged
    Changed = True
  End Sub

  Private Sub txtHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged
    Changed = True
  End Sub

  Private Sub txtMessages_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReadings.TextChanged
    Changed = True
  End Sub

  Private Sub colBackground_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colBackground.ColorChanged
    Changed = True
  End Sub

  Private Sub colText_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colText.ColorChanged
    Changed = True
  End Sub

  Private Sub cmbSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSize.SelectedIndexChanged
    Changed = True
  End Sub
End Class
