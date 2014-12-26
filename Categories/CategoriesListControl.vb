Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CategoriesListControl

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_strFileName As String

    Public Event CategorySelected(ByVal Category As String)

    Public Sub LoadCategories()
        Try
            graph.ChartAreas(0).BackColor = Me.BackColor

            Dim objSeries As Series = graph.Series("DreamSeries")
            objSeries.Points.Clear()
            objSeries("PieDrawingStyle") = "SoftEdge"
            lstCategories.Items.Clear()

      Dim objDozenSeries As Series = graphDozen.Series("DreamSeries")
      objDozenSeries.Color = Color.FromArgb(200, 65, 140, 240)
      objDozenSeries.BorderWidth = 1
      objSeries("BarLabelStyle") = "Right"
      objDozenSeries.Points.Clear()

      Dim total As Integer

      For Each categoryPath As String In Directory.GetDirectories(m_strPath + "Categories")
        Dim intCount As Integer = 0
        For Each categoryFile As String In Directory.GetFiles(categoryPath, "*.ld3", SearchOption.AllDirectories)
          Dim xmlDoc As New Xml.XmlDocument
          xmlDoc.Load(categoryFile)
          intCount += xmlDoc.DocumentElement.SelectNodes("//Dream").Count
        Next

        Dim lstItem As New ListViewItem(New FileInfo(categoryPath).Name)
        lstItem.SubItems.Add(intCount)
        lstCategories.Items.Add(lstItem)

        If intCount > 0 Then
          Dim intPoint As Integer = objSeries.Points.AddY(intCount)
          objSeries.Points(intPoint).Label = New FileInfo(categoryPath).Name

          Dim intPointDozen As Integer = objDozenSeries.Points.AddY(intCount)
          objDozenSeries.Points(intPointDozen).Label = " " + New FileInfo(categoryPath).Name
          total += 1
        End If
      Next

      If total > 12 Then
        graphDozen.Visible = True
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    End Sub

  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

    ' Reset Data Point Attributes
    Dim point As DataPoint
    For Each point In graph.Series(0).Points
      point("PieDrawingStyle") = "SoftEdge"
      'point("Exploded") = "False"
    Next point

    If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
      ' Set cursor type 
      Me.Cursor = Cursors.Hand

      ' Find selected data point
      point = graph.Series(0).Points(result.PointIndex)
      point("PieDrawingStyle") = "Concave"
      'point("Exploded") = "True"
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
