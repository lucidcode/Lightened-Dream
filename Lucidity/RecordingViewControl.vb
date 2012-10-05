Imports System.Xml
Imports System.IO
Imports Microsoft.VisualBasic.Devices

Public Class RecordingViewControl

  Public FileName As String
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strTitle As String
    Private m_strFile As String
    Private Declare Ansi Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private m_boolImported As Boolean = False
    Public Changed As Boolean = False
    Private m_objSpeechSynthesizer As New System.Speech.Synthesis.SpeechSynthesizer()

    Public Sub LoadFile(ByVal strFileName As String)
        Try

            If FileName = strFileName Then Return
            objPlayer.Visible = False

            ' Delete old temp files
            Try
                For Each strFile As String In Directory.GetFiles(m_strPath + "\Resources\", "*.*")
                    File.Delete(strFile)
                Next
            Catch ex As Exception
            End Try

            Dim xmlDoc As New XmlDocument
            FileName = strFileName
            xmlDoc.Load(FileName)

            Try
                m_strTitle = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
            Catch ex2 As Exception
            End Try

            If Not xmlDoc.DocumentElement.SelectSingleNode("Data") Is Nothing Then
                Dim arrByte() As Byte = Convert.FromBase64String(xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText)
                Dim objFS As New FileStream(m_strPath + "\Resources\" + m_strTitle + ".mp3", FileMode.Create)
                objFS.Write(arrByte, 0, arrByte.Length)
                objFS.Close()
                If arrByte.Length > 0 Then
                    objPlayer.Visible = True
                End If
                ' objPlayer.URL = (m_strPath + "\Resources\" + m_strTitle + ".mp3")
            End If

            txtSpeech.Text = ""
            If Not xmlDoc.DocumentElement.SelectSingleNode("Speech") Is Nothing Then
                txtSpeech.Text = xmlDoc.DocumentElement.SelectSingleNode("Speech").InnerText
                'm_objSpeechSynthesizer.SpeakAsync(txtSpeech.Text)
            End If

            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save(ByVal Title As String, ByVal Description As String, ByVal strFileName As String)
        Try

            FileName = strFileName

            objPlayer.close()
            Application.DoEvents()

            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(FileName)

            xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText = Title
            xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText = Description

            If xmlDoc.DocumentElement.SelectSingleNode("Data") Is Nothing Then
                Dim xmlDataNode As XmlNode = xmlDoc.CreateElement("Data")
                xmlDoc.DocumentElement.AppendChild(xmlDataNode)
            End If

            If m_boolImported Then
                Dim objFS As FileStream
                objFS = New FileStream(m_strFile, FileMode.Open)
                Dim arrBytes As Byte() = New Byte(objFS.Length) {}
                objFS.Read(arrBytes, 0, objFS.Length)
                objFS.Close()
                xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText = Convert.ToBase64String(arrBytes)
            Else
                If File.Exists(m_strPath + "\Resources\" + m_strFile) Then
                    Dim objFS As FileStream
                    objFS = New FileStream(m_strPath + "\Resources\" + m_strFile, FileMode.Open)
                    Dim arrBytes As Byte() = New Byte(objFS.Length) {}
                    objFS.Read(arrBytes, 0, objFS.Length)
                    objFS.Close()
                    xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText = Convert.ToBase64String(arrBytes)
                End If
            End If

            If xmlDoc.DocumentElement.SelectSingleNode("Speech") Is Nothing Then
                Dim xmlDataNode As XmlNode = xmlDoc.CreateElement("Speech")
                xmlDoc.DocumentElement.AppendChild(xmlDataNode)
            End If

            xmlDoc.DocumentElement.SelectSingleNode("Speech").InnerText = txtSpeech.Text

            xmlDoc.Save(FileName)
            m_boolImported = False
            Changed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Play()
        Try

            If objPlayer.URL <> m_strPath + "\Resources\stop.mp3" Then
                Dim strFile As String = objPlayer.URL
                objPlayer.URL = m_strPath + "\Resources\stop.mp3"
                objPlayer.URL = m_strPath + "\Resources\" + m_strTitle + ".mp3"
            End If

            'objPlayer.URL = (m_strPath + "\Resources\stop.mp3")
            'Application.DoEvents()
            'objPlayer.close()
            'Application.DoEvents()
            'Me.objPlayer.settings.volume = 100
            'm_objSpeechSynthesizer.SpeakAsyncCancelAll()

            'Dim xmlDocRec As New XmlDocument
            'xmlDocRec.Load(FileName)

            'If Not xmlDocRec.DocumentElement.SelectSingleNode("Data") Is Nothing Then
            '  If xmlDocRec.DocumentElement.SelectSingleNode("Data").InnerText <> "" Then
            '    Dim arrByte() As Byte = Convert.FromBase64String(xmlDocRec.DocumentElement.SelectSingleNode("Data").InnerText)
            '    Dim objFS As New FileStream(m_strPath + "\Resources\" + m_strTitle + ".mp3", FileMode.Create)
            '    objFS.Write(arrByte, 0, arrByte.Length)
            '    objFS.Close()

            '    objPlayer.URL = (m_strPath + "\Resources\" + m_strTitle + ".mp3")
            '  End If
            'End If

            If txtSpeech.Text <> "" Then
                m_objSpeechSynthesizer.SpeakAsync(txtSpeech.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopRunning()
        Try

            objPlayer.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub toolStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStart.Click
    If toolStart.Text = "&Start" Then
      m_boolImported = False
      If m_strFile <> "" Then
        If File.Exists(m_strPath + "\Resources\" + m_strFile) Then
          File.Delete(m_strPath + "\Resources\" + m_strFile)
        End If
      End If
      m_strFile = Now.Ticks.ToString + ".wav"
      mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
      mciSendString("record recsound", "", 0, 0)
      toolStart.Text = "&Stop"
    Else
      Dim intres As Integer = mciSendString("save recsound """ + m_strPath + "Resources\" + m_strFile + """", "", 0, 0)
      mciSendString("close recsound ", "", 0, 0)
      objPlayer.URL = (m_strPath + "\Resources\" + m_strFile)
      toolStart.Text = "&Start"
      Changed = True
      objPlayer.Visible = True
    End If
  End Sub

  Private Sub toolImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolImport.Click
    Dim objOFD As New OpenFileDialog
    objOFD.Title = "Select Sound File"
    objOFD.Filter = "All Files|*.*|Wave Files|*.wav|MP3 Files|*.mp3"
    If objOFD.ShowDialog = Windows.Forms.DialogResult.OK Then
      objPlayer.URL = (objOFD.FileName)
      m_strFile = objOFD.FileName
      m_boolImported = True
      Changed = True
      objPlayer.Visible = True

    End If
  End Sub
End Class
