Imports lucidcode.LightenedDream
Imports System.IO

Public Class UpdateControl

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"

    Public Sub UpdateDatabase()
        ' Load each year
        For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
            Dim trvYear As New TreeNode(New DirectoryInfo(strYearFolder).Name)
            Dim objYearTag As New Dreams.Tags.YearFolder(strYearFolder, trvYear.Text)
            trvYear.Tag = objYearTag
            'trvDreams.Nodes.Add(trvYear)

            ' Load each month
            For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
                Dim trvMonth As New TreeNode(New DirectoryInfo(strMonthFolder).Name)
                Dim objMonthTag As New Dreams.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text)
                trvMonth.Tag = objMonthTag
                trvYear.Nodes.Add(trvMonth)

                ' Load each dream
                For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
                    'trvDream = New TreeNode(New FileInfo(strDreamFile).Name.Replace(".ld3", ""))
                    Dim objDreamTag As New Dreams.Tags.DreamFile(strDreamFile)
                    'trvDream.Tag = objDreamTag
                    'trvDream.ImageIndex = 12
                    'trvDream.SelectedImageIndex = 12
                    'trvMonth.Nodes.Add(trvDream)

                    '' Add the loading node
                    'Dim trvLoading As New TreeNode("Loading Categories...")
                    'trvDream.Nodes.Add(trvLoading)
                Next

            Next
        Next
    End Sub

End Class
