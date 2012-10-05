Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class YearsListControl

  Public Event MonthSelected(ByVal Month As String)
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
  Private m_boolSearching As Boolean = False
  Private objDreamSeries As Series

  Private m_strSelectedNewCategory As String

  Public Sub LoadYears()

    If m_boolSearching Then
      Return
    End If

    m_boolSearching = True

    Try
      Dim intPos As Double = 0.5

      Dim xmlDream As New XmlDocument

      graph.Series.Clear()
      graph.ChartAreas(0).AxisX.CustomLabels.Clear()
      graph.Visible = True

      objDreamSeries = graph.Series.Add("Dreams")
      objDreamSeries.ChartType = SeriesChartType.Column
      objDreamSeries.Tag = 0
      objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240)
      objDreamSeries.BorderWidth = 1
      objDreamSeries("BarLabelStyle") = "Center"


      For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Lucidity\Exercises")
        For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)

          objDreamSeries.Points.AddY(0)

          graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name)
          intPos += 1

          For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")

            objDreamSeries.Tag += 1
            objDreamSeries.Points(objDreamSeries.Points.Count - 1).YValues(0) += 1
            objDreamSeries.Points(objDreamSeries.Points.Count - 1).ToolTip = New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name

          Next

          Application.DoEvents()

        Next
      Next

      ' Totals
      objDreamSeries.Name += " (" & objDreamSeries.Tag & ")"

    Catch ex As Exception

    End Try

    m_boolSearching = False
  End Sub

  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Try
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

      ' Reset Data Point Attributes
      Dim point As DataPoint
      For Each objSeries As Series In graph.Series
        For Each point In objSeries.Points
          point.Color = Color.FromArgb(200, point.Color.R, point.Color.G, point.Color.B)
        Next point
      Next

      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("Dreams (") Then
          Me.Cursor = Cursors.Hand
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B)
        Else
          Me.Cursor = Cursors.Default
        End If
      Else
        Me.Cursor = Cursors.Default
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub graph_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
      Dim point As DataPoint
      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("Dreams (") Then
          point = objDreamSeries.Points(result.PointIndex)
          RaiseEvent MonthSelected(point.ToolTip)
        End If
      End If
    End If
  End Sub

End Class
