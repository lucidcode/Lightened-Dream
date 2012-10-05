Namespace Tags

  Public Class DreamsFolder
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class YearFolder
    Public Path As String = ""
    Public Year As String = ""

    Public Sub New(ByVal Folder As String, ByVal strYear As String)
      Path = Folder
      Year = strYear
    End Sub
  End Class

  Public Class YearsFolder
    Public Path As String = ""
    Public Year As String = ""

    Public Sub New(ByVal Folder As String, ByVal strYear As String)
      Path = Folder
      Year = strYear
    End Sub
  End Class

  Public Class MonthFolder
    Public Path As String = ""
    Public Year As String = ""
    Public Month As String = ""

    Public Sub New(ByVal Folder As String, ByVal strYear As String, ByVal strMonth As String)
      Path = Folder
      Year = strYear
      Month = strMonth
    End Sub
  End Class

  Public Class DreamFile
    Public Path As String = ""

    Public Sub New(ByVal File As String)
      Path = File
    End Sub
  End Class

End Namespace


Public Class Dreaming

  Public Shared Function GetWords(ByVal Dream As String) As String()
    Dim strWords As String = Dream.Replace(",", " ")
    strWords = strWords.Replace(".", " ")
    strWords = strWords.Replace("/", " ")
    strWords = strWords.Replace("\", " ")
    strWords = strWords.Replace(";", " ")
    strWords = strWords.Replace("-", " ")
    strWords = strWords.Replace("!", " ")
    strWords = strWords.Replace("?", " ")
    strWords = strWords.Replace("&", " ")
    strWords = strWords.Replace("'s", " ")
    strWords = strWords.Replace(">", " ")
    strWords = strWords.Replace("<", " ")
    strWords = strWords.Replace("(", " ")
    strWords = strWords.Replace(")", " ")
    strWords = strWords.Replace(vbNewLine, " ")
    strWords = strWords.Replace(vbCr, " ")
    strWords = strWords.Replace(vbLf, " ")
    Return strWords.Split(" ")
  End Function

End Class


