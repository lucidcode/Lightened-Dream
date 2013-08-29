Imports System.IO
Imports System.Xml

Public Class DataDirectory

    Public Shared Function GetFolderPath() As String
        Dim strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\"
        If (File.Exists(strPath & "LightenedDreamDirectory.ld3")) Then
            Dim xmlDocDataDirectory As New XmlDocument
            xmlDocDataDirectory.Load(strPath & "LightenedDreamDirectory.ld3")
            If Directory.Exists(xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText) Then
                Return xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText
            End If
        End If

        Return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\"
    End Function

End Class
