Namespace Tags

  Public Class LucidityFolder
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class REMCyclesFolder
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class REMCycleFile
    Public Path As String = ""

    Public Sub New(ByVal Folder As String)
      Path = Folder
    End Sub
  End Class

  Public Class LucidItemFolder
    Public Path As String = ""
    Public Type As String = ""

    Public Sub New(ByVal Folder As String, ByVal strType As String)
      Path = Folder
      Type = strType
    End Sub
  End Class

  Public Class LucidItemFile
    Public Path As String = ""
    Public Type As String = ""

    Public Sub New(ByVal strPath As String, ByVal strType As String)
      Path = strPath
      Type = strType
    End Sub
  End Class


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
