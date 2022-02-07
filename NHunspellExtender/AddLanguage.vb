Public Class AddLanguage

    Private _result As System.Windows.Forms.DialogResult

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _result = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdAff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAff.Click
        Dim newDialog As New System.Windows.Forms.OpenFileDialog

        newDialog.Title = "Select the Aff file"
        newDialog.Filter = "Aff Files (*.aff)|*.aff|All Files (*.*)|*.*"
        newDialog.FilterIndex = 1
        If newDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtAff.Text = newDialog.FileName
        End If
    End Sub

    Private Sub cmdDic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDic.Click
        Dim newDialog As New System.Windows.Forms.OpenFileDialog

        newDialog.Title = "Select the Dic file"
        newDialog.Filter = "Dic Files (*.dic)|*.dic|All Files (*.*)|*.*"
        newDialog.FilterIndex = 1
        If newDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDic.Text = newDialog.FileName
        End If
    End Sub

    Public ReadOnly Property Result As System.Windows.Forms.DialogResult
        Get
            Return _result
        End Get
    End Property

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If txtAff.Text = "" Or txtDic.Text = "" Or txtName.Text = "" Then
            System.Windows.Forms.MessageBox.Show("You must enter all 3 values")
            Return
        End If

        _result = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class