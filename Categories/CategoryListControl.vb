Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CategoryListControl

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_strFileName As String
    Public Category As String
    Public CategoryFile As String

    Public Event CategorySelected(ByVal Entry As String)

    Public Sub LoadCategory()
        Try
            graph.ChartAreas(0).BackColor = Me.BackColor

            lblT.Visible = True
            txtName.Visible = True
            txtName.Text = Category

            Dim objSeries As Series = graph.Series("DreamSeries")
            objSeries.Points.Clear()
            objSeries("PieDrawingStyle") = "SoftEdge"
            lstCategories.Items.Clear()
            lblTitle.Text = "Categories - " + Category

      Dim hasData As Boolean = False

      Dim objDozenSeries As Series = graphDozen.Series("DreamSeries")
      objDozenSeries.Color = Color.FromArgb(200, 65, 140, 240)
      objDozenSeries.BorderWidth = 1
      objSeries("BarLabelStyle") = "Right"
      objDozenSeries.Points.Clear()

      Dim total As Integer

      For Each strCatgeoryFolder As String In Directory.GetDirectories(CategoryFile)
        Dim intCount As Integer = 0
        For Each strCatgeoryFile As String In Directory.GetFiles(strCatgeoryFolder, "*.ld3", SearchOption.AllDirectories)
          Dim xmlDoc As New Xml.XmlDocument
          xmlDoc.Load(strCatgeoryFile)

          intCount += xmlDoc.DocumentElement.SelectNodes("//Dream").Count
        Next

        Dim lstItem As New ListViewItem(New DirectoryInfo(strCatgeoryFolder).Name)
        lstItem.SubItems.Add(intCount)
        lstCategories.Items.Add(lstItem)

        If intCount > 0 Then
          Dim intPoint As Integer = objSeries.Points.AddY(intCount)
          objSeries.Points(intPoint).Label = lstItem.Text
          hasData = True

          Dim intPointDozen As Integer = objDozenSeries.Points.AddY(intCount)
          objDozenSeries.Points(intPointDozen).Label = " " + New DirectoryInfo(strCatgeoryFolder).Name
          total += 1
        End If
      Next

      For Each strCatgeoryFile As String In Directory.GetFiles(CategoryFile, "*.ld3")
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(strCatgeoryFile)

        Dim intCount As Integer = xmlDoc.DocumentElement.SelectNodes("//Dream").Count

        Dim lstItem As New ListViewItem(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
        lstItem.SubItems.Add(intCount)
        lstCategories.Items.Add(lstItem)

        If intCount > 0 Then
          Dim intPoint As Integer = objSeries.Points.AddY(intCount)
          objSeries.Points(intPoint).Label = lstItem.Text
          hasData = True

          Dim intPointDozen As Integer = objDozenSeries.Points.AddY(intCount)
          objDozenSeries.Points(intPointDozen).Label = " " + New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
          total += 1
        End If
      Next

      graph.Visible = hasData

      If total > 12 Then
        graphDozen.Visible = True
      Else
        graphDozen.Visible = False
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

  Public Sub Save()
    If txtName.Text <> Category Then
      Directory.Move(CategoryFile, New DirectoryInfo(CategoryFile).Parent.FullName + "\" & txtName.Text)
      CategoryFile = New DirectoryInfo(CategoryFile).Parent.FullName + "\" & txtName.Text
      Category = txtName.Text
    End If
  End Sub

  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

    ' Reset Data Point Attributes
    Dim point As DataPoint
    For Each point In graph.Series(0).Points
      point("PieDrawingStyle") = "SoftEdge"
    Next point

    If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
      ' Set cursor type 
      Me.Cursor = Cursors.Hand

      ' Find selected data point
      point = graph.Series(0).Points(result.PointIndex)
      point("PieDrawingStyle") = "Concave"
    Else
      ' Set default cursor
      Me.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub graph_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
      Dim point As DataPoint
      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        ' Set cursor type 
        Me.Cursor = Cursors.Hand

        ' Find selected data point
        point = graph.Series(0).Points(result.PointIndex)
        RaiseEvent CategorySelected(point.Label)
      End If

    End If
  End Sub

  Private Sub graphDozen_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles graphDozen.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      Dim result As HitTestResult = graphDozen.HitTest(e.X, e.Y)
      Dim point As DataPoint
      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        ' Set cursor type 
        Me.Cursor = Cursors.Hand

        ' Find selected data point
        point = graphDozen.Series(0).Points(result.PointIndex)
        RaiseEvent CategorySelected(point.Label.Trim(" "))
      End If

    End If
  End Sub

  Private Sub graphDozen_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles graphDozen.MouseMove
    Dim result As HitTestResult = graphDozen.HitTest(e.X, e.Y)

    ' Reset Data Point Attributes
    Dim point As DataPoint
    For Each objSeries As Series In graphDozen.Series
      For Each point In objSeries.Points
        point.Color = Color.FromArgb(200, point.Color.R, point.Color.G, point.Color.B)
      Next point
    Next

    If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
      Me.Cursor = Cursors.Hand
      point = result.Series.Points(result.PointIndex)
      point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B)
    Else
      Me.Cursor = Cursors.Default
    End If
  End Sub
End Class
