Public Class FlashesForm

  Private m_intPosition As Integer
  Public FlashColor As Color
  Public BGColor As Color
  Public Timeout As Integer = 1000
  Private m_boolOn As Boolean = False


  Public Sub New(ByVal Interval As Integer)
    InitializeComponent()

    Me.Width = Screen.PrimaryScreen.Bounds.Width
    Me.Height = Screen.PrimaryScreen.Bounds.Height

    tmrLoad.Interval = Interval
  End Sub

  Public Sub Play()
    tmrLoad.Enabled = True
  End Sub

  Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
    tmrLoad.Enabled = False
    If m_boolOn Then
      m_boolOn = False
      lblText.BackColor = BGColor
    Else
      m_boolOn = True
      lblText.BackColor = FlashColor
    End If

    m_intPosition += 1

    If m_intPosition >= Timeout Then
      tmrLoad.Enabled = False
      Close()
      Return
    End If
    tmrLoad.Enabled = True
  End Sub

  Private Sub lblText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblText.Click
    Close()
  End Sub

  Private Sub FlashesForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
    Close()
  End Sub

  Private Sub SpeedReadingForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cursor.Show()
  End Sub

  Private Sub SpeedReadingForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.Escape Then
      Close()
    End If

    tmrLoad.Enabled = Not tmrLoad.Enabled
  End Sub

  Private Sub SpeedReadingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Cursor.Hide()
  End Sub
End Class