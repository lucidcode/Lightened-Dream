Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CategoriesListControl

    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strFileName As String
    Public Categories As String

    Public Event CategorySelected(ByVal Category As String)

    Public Sub LoadCategories()
        Try
            graph.ChartAreas(0).BackColor = Me.BackColor

            Dim objSeries As Series = graph.Series("DreamSeries")
            objSeries.Points.Clear()
            objSeries("PieDrawingStyle") = "SoftEdge"
            lstCategories.Items.Clear()
            For Each strCategory As String In Categories.Split(",")
                Dim intCount As Integer = Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3").Length

                Dim lstItem As New ListViewItem(strCategory)
                lstItem.SubItems.Add(intCount)
                lstCategories.Items.Add(lstItem)

                If intCount > 0 Then
                    Dim intPoint As Integer = objSeries.Points.AddY(intCount)
                    objSeries.Points(intPoint).Label = strCategory
                End If
            Next

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
End Class
