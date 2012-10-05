Public Class SubliminalForm

  Public Messages() As String
  Public Duration As Integer = 200
  Private m_intPosition As Integer

  Public Sub New(ByVal Interval As Integer, ByVal Duration As Integer, ByVal dblOpacity As Double, ByVal colBackColor As Color, ByVal colForeColor As Color, ByVal arrMessages() As String, ByVal objFont As Font)
    InitializeComponent()
    tmrLoad.Interval = Interval
    tmrHide.Interval = Duration
    Messages = arrMessages
    lblText.Font = objFont
    Opacity = dblOpacity
    BackColor = colBackColor
    lblText.ForeColor = colForeColor
    Me.Duration = Duration
    Me.Visible = True
    Me.Location = New Point(-10000, -10000)
    tmrLoad_Tick(Nothing, Nothing)
    Randomize()
  End Sub

  Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
    tmrLoad.Enabled = False

    Try
      Dim intScreensHeight As Integer
      Dim intScreensWidth As Integer

      For Each objScreen As Screen In Screen.AllScreens
        intScreensWidth += objScreen.Bounds.Width
        intScreensHeight += objScreen.Bounds.Height
      Next

      lblText.Text = Messages(m_intPosition).Replace(vbNewLine, "").Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")

      m_intPosition += 1

      If m_intPosition >= Messages.Length Then m_intPosition = 0

      If lblText.Text = "" Then
        tmrLoad_Tick(Nothing, Nothing)
        Exit Sub
      End If

      lblText.Location = New Point(2, 4)
      Application.DoEvents()
      Me.Left = Int(Rnd() * (intScreensWidth - Me.Width))
      Me.Top = Int(Rnd() * (intScreensHeight - Me.Height))
      Application.DoEvents()

      Me.Width = lblText.Width + 4
      Me.Height = lblText.Height + 8
      'Me.Visible = True
      'If Not ParentForm Is Nothing Then
      '  ParentForm.Focus()
      'End If
    Catch ex As Exception

    End Try
    
    tmrHide.Enabled = True
  End Sub

  Private Sub tmrHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHide.Tick
    tmrHide.Enabled = False
    Application.DoEvents()
    Me.Location = New Point(-10000, -10000)
    'Me.Visible = False
    tmrLoad.Enabled = True
  End Sub
End Class