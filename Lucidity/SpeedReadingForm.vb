﻿Public Class SpeedReadingForm

  Public Messages() As String
  Private m_intPosition As Integer

  Public PlayLoop As Boolean = True

  Public Sub New(ByVal Interval As Integer)
    InitializeComponent()

    Me.Width = Screen.PrimaryScreen.Bounds.Width
    Me.Height = Screen.PrimaryScreen.Bounds.Height

    tmrLoad.Interval = Interval
  End Sub

  Public Sub Play()
    tmrLoad.Enabled = True
    tmrLoad_Tick(Nothing, Nothing)
  End Sub

  Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
    lblText.Text = Messages(m_intPosition).Replace(vbNewLine, "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
    Application.DoEvents()

    m_intPosition += 1
    If m_intPosition >= Messages.Length - 1 Then
      If PlayLoop Then
        m_intPosition = 0
      Else
        tmrLoad.Enabled = False
        Me.Close()
      End If
    End If
  End Sub

  Private Sub lblText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblText.Click
    Close()
  End Sub

  Private Sub SpeedReadingForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cursor.Show()
  End Sub

  Private Sub SpeedReadingForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Escape Then
      Close()
    End If

    If tmrLoad.Enabled = True Then
      lblText.Text = "[PAUSED]"
    Else
      lblText.Text = Messages(m_intPosition).Replace(vbNewLine, "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
    End If
    tmrLoad.Enabled = Not tmrLoad.Enabled
  End Sub

  Private Sub SpeedReadingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Cursor.Hide()
  End Sub
End Class