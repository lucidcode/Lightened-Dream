Namespace Tags

  Public Class CategoriesFolder
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class CategoryFolder
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class CategoryFile
    Public Path As String = ""
    Public Category As String = ""

    Public Sub New(ByVal File As String, ByVal Type As String)
      Path = File
      Category = Type
    End Sub
  End Class

End Namespace
