Imports System.Xml
Imports System.IO

Public Class ExerciseViewControl

  Public Words As Integer
  Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
    Private m_boolLoading As Boolean = False
    Private m_objSpeechSynthesizer As New System.Speech.Synthesis.SpeechSynthesizer()

    Public Playing As Boolean = False

    Public Event CategoryCreated(ByVal Category As String, ByVal Name As String, ByVal FileName As String)
    Public Event PlayingStopped()
    Public Changed As Boolean = False

    Public Sub New()
        InitializeComponent()
        AddHandler m_objSpeechSynthesizer.SpeakCompleted, AddressOf m_objSpeechSynthesizer_SpeakCompleted
    End Sub

    Public Sub EnableSpellCheck()
        NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtExercise, True)
    End Sub

    Public Sub DisableSpellCheck()
        NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtExercise, False)
    End Sub

    Public Sub LoadExercise(ByVal strFileName As String)
        Try
            If FileName <> strFileName Then
                m_objSpeechSynthesizer.SpeakAsyncCancelAll()
                Playing = False
            End If

            m_boolLoading = True
            Dim xmlDoc As New XmlDocument
            FileName = strFileName
            xmlDoc.Load(FileName)

            Try
                Dim arrDate() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Date").InnerText, "-")
                Dim arrTime() As String = Split(xmlDoc.DocumentElement.SelectSingleNode("Time").InnerText, ":")
                dtDate.Value = New Date(arrDate(0), arrDate(1), arrDate(2), arrTime(0), arrTime(1), 0)
            Catch ex As Exception
            End Try

            txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
            txtTask.Text = xmlDoc.DocumentElement.SelectSingleNode("Task").InnerText
            txtExercise.Text = xmlDoc.DocumentElement.SelectSingleNode("Details").InnerText
            lblTitle.Text = "Lucidity - Exercises - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text

            cmbLucidity.Text = xmlDoc.DocumentElement.SelectSingleNode("Lucidity").InnerText

            Words = txtExercise.Text.Split(" ").Length
            m_boolLoading = False
            Changed = False
            Playing = False
            'LoadCategories()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Exercises.LoadExercise()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save()
        Try
            Dim strXml As String

            strXml = "<Exercise>"
            strXml += "<Date>" & Format(dtDate.Value, "yyyy-MM-dd") & "</Date>"
            strXml += "<Time>" & Format(dtDate.Value, "HH:mm") & "</Time>"
            strXml += "<Title>" & txtTitle.Text + "</Title>"
            strXml += "<Task>" & txtTask.Text + "</Task>"
            strXml += "<Details></Details>"
            strXml += "<Lucidity>" & Val(cmbLucidity.Text) & "</Lucidity>"
            strXml += "</Exercise>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.DocumentElement.SelectSingleNode("Details").InnerText = txtExercise.Text
            If (FileName <> GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3") Then
                File.Delete(FileName)
            End If
            FileName = GetFolder(dtDate.Value) + Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3"
            xmlDoc.Save(FileName)
            Changed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Exercises.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Play()
        Try
            m_objSpeechSynthesizer.SpeakAsync(txtExercise.Text)
            Playing = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Exercises.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub m_objSpeechSynthesizer_SpeakCompleted(ByVal sender As Object, ByVal e As System.Speech.Synthesis.SpeakCompletedEventArgs)
        Playing = False
        RaiseEvent PlayingStopped()
    End Sub

    Public Sub StopPlaying()
        Try
            m_objSpeechSynthesizer.SpeakAsyncCancelAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Exercises.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Function GetFolder(ByVal FolderDate As DateTime) As String
    If Not Directory.Exists(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy")) Then
      Directory.CreateDirectory(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy"))
    End If
    If Not Directory.Exists(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM")) Then
      Directory.CreateDirectory(m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM"))
    End If
    Return m_strPath + "Lucidity\Exercises\" + Format(FolderDate, "yyyy") + "\" + Format(FolderDate, "MM") + "\"
  End Function

  Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
    lblTitle.Text = "Lucidity - Exercises - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text
    Changed = True
  End Sub

  Private Sub dtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDate.ValueChanged
    lblTitle.Text = "Lucidity - Exercises - " + Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text
    Try
    Catch ex As Exception
    End Try
    Changed = True
  End Sub

  Private Sub txtExercise_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExercise.TextChanged
    If Not m_boolLoading Then
      Changed = True
    End If
  End Sub

  Private Sub cmbLucidity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLucidity.SelectedIndexChanged
    Changed = True
  End Sub

End Class
