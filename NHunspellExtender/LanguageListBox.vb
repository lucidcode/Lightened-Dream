Imports System.Windows.Forms.Design

Public Class LanguageListBox
    Inherits System.Windows.Forms.ListBox

    ' The editor service displaying us.
    Private m_EditorService As IWindowsFormsEditorService


    Public Sub New(ByVal editor_service As IWindowsFormsEditorService, ByVal Value As String)
        MyBase.New()
        m_EditorService = editor_service

        LoadLanguages(Value)
    End Sub

    Private Sub LoadLanguages(Optional ByVal Value As String = "")
        Me.Items.Clear()

        'Get all languages in list
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages")

        Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())

        For Each language In languages
            Me.Items.Add(language)
        Next

        regKey.Dispose()

        Me.Items.Add("<Add a new language>")

        For i = 0 To Me.Items.Count - 1
            If Me.Items(i) = Value Then
                Me.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub LanguageListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Me.SelectedItem = "<Add a new language>" Then
            Dim newAddLang = New AddLanguage

            newAddLang.ShowDialog()

            If newAddLang.Result = Windows.Forms.DialogResult.Cancel Then
                Return
            End If

            'Add the Item to the registry
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

            Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())

            Dim boolFound As Boolean = False
            For Each language In languages
                If language = newAddLang.txtName.Text Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                ReDim Preserve languages(UBound(languages) + 1)
                languages(UBound(languages)) = newAddLang.txtName.Text

                regKey.SetValue("LanguageList", languages, Microsoft.Win32.RegistryValueKind.MultiString)
            End If

            Dim paths(1) As String

            paths(0) = newAddLang.txtAff.Text
            paths(1) = newAddLang.txtDic.Text

            regKey.SetValue(newAddLang.txtName.Text, paths, Microsoft.Win32.RegistryValueKind.MultiString)

            regKey.Close()
            regKey.Dispose()

            Dim selection As Integer = Me.Items.Add(newAddLang.txtName.Text)
            Me.SelectedIndex = selection
        Else
            'Check if the paths are still valid
            Dim regKey As Microsoft.Win32.RegistryKey = _
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

            Dim paths() As String = TryCast(regKey.GetValue(Me.SelectedItem), String())

            If paths Is Nothing Then
                System.Windows.Forms.MessageBox.Show("Aff and Dic files are missing")

                Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())
                Dim newLanguageList(UBound(languages) - 1) As String
                Dim count As Integer = 0

                For Each language In languages
                    If language <> Me.SelectedItem Then
                        newLanguageList(count) = language
                        count += 1
                    End If
                Next

                regKey.SetValue("LanguageList", newLanguageList, Microsoft.Win32.RegistryValueKind.MultiString)
                regKey.DeleteValue(Me.SelectedItem)

                LoadLanguages()

                regKey.Close()
                regKey.Dispose()

                Return
            Else
                For Each path In paths
                    If Not System.IO.File.Exists(path) Then
                        System.Windows.Forms.MessageBox.Show("Aff and Dic files are missing")

                        Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())
                        Dim newLanguageList(UBound(languages) - 1) As String
                        Dim count As Integer = 0

                        For Each language In languages
                            If language <> Me.SelectedItem Then
                                newLanguageList(count) = language
                                count += 1
                            End If
                        Next

                        regKey.SetValue("LanguageList", newLanguageList, Microsoft.Win32.RegistryValueKind.MultiString)
                        regKey.DeleteValue(Me.SelectedItem)

                        LoadLanguages()

                        regKey.Close()
                        regKey.Dispose()

                        Return
                    End If
                Next
            End If

        End If

        If m_EditorService IsNot Nothing Then m_EditorService.CloseDropDown()
    End Sub


End Class
