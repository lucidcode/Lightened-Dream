Imports System.Drawing.Design
Imports System.Windows.Forms.Design

Public Class LanguageEditor
    Inherits System.Drawing.Design.UITypeEditor

    Public Overloads Overrides Function GetEditStyle(ByVal context As System.ComponentModel.ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.DropDown
    End Function

    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        ' Get an IWindowsFormsEditorService.
        Dim editor_service As IWindowsFormsEditorService = _
            CType(provider.GetService(GetType(IWindowsFormsEditorService)),  _
                  IWindowsFormsEditorService)

        ' If we failed to get the editor service, return the value.
        If editor_service Is Nothing Then Return value

        Dim strValue As String = TryCast(value, String)

        If strValue Is Nothing Then Return value

        Dim newListBox As New LanguageListBox(editor_service, strValue)

        editor_service.DropDownControl(newListBox)

        'Add the Item to the registry
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        regKey.SetValue("Default", newListBox.SelectedItem)

        regKey.Close()
        regKey.Dispose()

        Return newListBox.SelectedItem
    End Function
End Class
