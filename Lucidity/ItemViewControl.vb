Imports System.Xml
Imports System.IO

Public Class ItemViewControl

  Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\Lucidity\"
    Private m_strType As String
    Private m_boolSpelling As Boolean = False

  Public Sub EnableSpellCheck()
    m_boolSpelling = True
  End Sub

    Public Sub DisableSpellCheck()
        m_boolSpelling = False
    End Sub

    Public Function Changed() As Boolean

        If m_strType = "Subliminal" Then
            Return objSublinalControl.Changed
        ElseIf m_strType = "Reading" Then
            Return objSpeedReadingControl.Changed
        ElseIf m_strType = "Recording" Then
            Return objRecordingViewControl.Changed
        End If

    End Function

    Public Sub LoadFile(ByVal strFileName As String)
        Try

            Dim xmlDoc As New XmlDocument
            FileName = strFileName
            xmlDoc.Load(strFileName)

            pnlContainer.Controls.Clear()

            m_strType = xmlDoc.DocumentElement.Name
            txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
            txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText

            If m_strType = "Subliminal" Then
                pnlContainer.Controls.Add(objSublinalControl)
                objSublinalControl.Location = New Point(0, 0)
                objSublinalControl.Dock = DockStyle.Fill
                lblTitle.Text = "Lucidity - Subliminals - " + txtTitle.Text
                objSublinalControl.LoadFile(strFileName)
                NHunspellTextBoxExtender1.SetSpellCheckEnabled(objSublinalControl.txtMessages, True)
            ElseIf m_strType = "Reading" Then
                pnlContainer.Controls.Add(objSpeedReadingControl)
                objSpeedReadingControl.Location = New Point(0, 0)
                objSpeedReadingControl.Dock = DockStyle.Fill
                lblTitle.Text = "Lucidity - Readings - " + txtTitle.Text
                objSpeedReadingControl.LoadFile(strFileName)
                NHunspellTextBoxExtender1.SetSpellCheckEnabled(objSpeedReadingControl.txtReadings, True)
            ElseIf m_strType = "Recording" Then
                pnlContainer.Controls.Add(objRecordingViewControl)
                objRecordingViewControl.Location = New Point(0, 0)
                objRecordingViewControl.Dock = DockStyle.Fill
                lblTitle.Text = "Lucidity - Recordings - " + txtTitle.Text
                objRecordingViewControl.LoadFile(strFileName)
                NHunspellTextBoxExtender1.SetSpellCheckEnabled(objRecordingViewControl.txtSpeech, True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save(ByVal Type As String)
        Try

            Dim strFileName As String
            strFileName = m_strPath + m_strType + "s\" + txtTitle.Text + ".ld3"
            If (FileName <> strFileName) Then
                ' Make sure the file doesn't already exist
                If (File.Exists(strFileName)) Then
                    If MessageBox.Show("The file '" & New FileInfo(strFileName).Name.Replace(".ld3", "") & "' already exists." & vbNewLine & "Would you like to replace it?", "Overwrite File?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                        File.Delete(strFileName)
                    Else
                        Return
                    End If
                End If

                File.Move(FileName, strFileName)
                FileName = strFileName
            End If

            If m_strType = "Subliminal" Then
                objSublinalControl.Save(txtTitle.Text, txtDescription.Text, strFileName)
            ElseIf m_strType = "Reading" Then
                objSpeedReadingControl.Save(txtTitle.Text, txtDescription.Text, strFileName)
            ElseIf m_strType = "Recording" Then
                objRecordingViewControl.Save(txtTitle.Text, txtDescription.Text, strFileName)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function CreateNew(ByVal Type As String) As String
        Try

            m_strType = Type
            Dim strTitle As String = "New " + m_strType
            Dim strFileName As String
            strFileName = m_strPath + m_strType + "s\" + strTitle + ".ld3"

            Dim intPos As Integer = 2
            Do
                If (File.Exists(strFileName)) Then
                    strTitle = "New " + m_strType + " " + intPos.ToString
                    strFileName = m_strPath + m_strType + "s\" + strTitle + ".ld3"
                    intPos += 1
                Else
                    Exit Do
                End If
            Loop

            Dim strXml As String
            strXml = "<" + m_strType + ">"
            strXml += "<Title>" + strTitle + "</Title>"
            strXml += "<Description></Description>"
            strXml += "</" + m_strType + ">"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(strFileName)

            Return strFileName

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Create()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

  Public Function Play() As Boolean
    If m_strType = "Subliminal" Then
      objSublinalControl.Play()
      Return True
    ElseIf m_strType = "Reading" Then
      objSpeedReadingControl.Play()
    ElseIf m_strType = "Recording" Then
      objRecordingViewControl.Play()
    End If
    Return False
  End Function

  Public Function Playing() As Boolean
    If m_strType = "Subliminal" Then
      Return objSublinalControl.Playing
    End If
    Return False
  End Function

  Public Sub StopRunning()
    If m_strType = "Subliminal" Then
      objSublinalControl.StopRunning()
    ElseIf m_strType = "Reading" Then
      objSpeedReadingControl.StopRunning()
    ElseIf m_strType = "Recording" Then
      objRecordingViewControl.StopRunning()
    End If
  End Sub

End Class
