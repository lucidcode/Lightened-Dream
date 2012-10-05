Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization
Imports System.Drawing.Drawing2D

Public Class MemClearControl

  Public Event DreamSelected(ByVal Dream As String)

  Public Sub LoadDay(ByVal Folder As String, ByVal Year As String, ByVal Month As String)
    Dim intPos As Double = 0.5
    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Series.Clear()
    graph.ResetAutoValues()
    graph.Annotations.Clear()

    lstDreams.Items.Clear()

    Dim dtMonth As DateTime = New DateTime(Year, Month, 1)

    Dim intPoint As Integer
    Dim lstItem As ListViewItem
    Dim intLongestDream As Integer = 0

    Dim intMostLucidDream As Integer = 0

    Dim strMostLucidDream As String = ""

    lblTitle.Text = "Lucidity - Exercises - " & Format(dtMonth, "yyyy - MMMM")

    ' Load each dream
    For Each strDreamFile As String In Directory.GetFiles(Folder, "*.ld3")
      Dim xmlDream As New XmlDocument
      Dim intLucidity As Integer = 1
      xmlDream.Load(strDreamFile)
      lstItem = New ListViewItem(xmlDream.DocumentElement.SelectSingleNode("Date").InnerText)
      lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText)
      lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText)

      lstItem.Tag = strDreamFile
      lstDreams.Items.Add(lstItem)
      If lstItem.SubItems(2).Text > intLongestDream Then
        intLongestDream = lstItem.SubItems(2).Text
      End If

      If lstItem.SubItems(2).Text * intLucidity > intMostLucidDream Then
        intMostLucidDream = lstItem.SubItems(2).Text * intLucidity
        strMostLucidDream = lstItem.Text & " - " & lstItem.SubItems(1).Text
      End If
    Next

    Dim intDayCountOutside As Integer = 0

    Do

      intDayCountOutside += 1

      Dim intDayCount As Integer = 0

      For Each lstItem In lstDreams.Items
        If lstItem.Text = dtMonth Then
          intDayCount += 1

          Dim objSeriesN As Series = graph.Series.Add("Day" & intDayCountOutside & "." & intDayCount)
          objSeriesN.ChartType = SeriesChartType.StackedColumn
          objSeriesN.Color = Color.FromArgb(200, 65, 140, 240)
          objSeriesN.BorderWidth = 1
          Dim dtMonth2 As DateTime = New DateTime(Year, Month, 1)
          Do

            If lstItem.Text = dtMonth2 Then
              intPoint = objSeriesN.Points.AddY(lstItem.SubItems(2).Text)
              objSeriesN.Points(intPoint).ToolTip = Format(dtMonth2, "dd") & " " & lstItem.SubItems(1).Text
              objSeriesN.Points(intPoint).Tag = dtMonth2.Day
            Else
              objSeriesN.Points.AddY(0)
            End If

            dtMonth2 = dtMonth2.AddDays(1)
          Loop Until dtMonth2.Month <> Month

        End If
      Next

      dtMonth = dtMonth.AddDays(1)
      intPos = intPos + 1
    Loop Until dtMonth.Month <> Month

    Dim objSleepSeries As Series = graph.Series.Add("Sleep")
    objSleepSeries.ChartType = SeriesChartType.SplineRange
    objSleepSeries.Color = Color.FromArgb(100, 65, 240, 40)
    objSleepSeries.YAxisType = AxisType.Secondary

    Dim objDreamSeries As Series = graph.Series.Add("DreamTime")
    objDreamSeries.ChartType = SeriesChartType.Spline
    objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240) 'Color.FromArgb(128, Color.LightSteelBlue.R, Color.LightSteelBlue.G, Color.LightSteelBlue.B)
    objDreamSeries.YAxisType = AxisType.Secondary

    dtMonth = New DateTime(Year, Month, 1)
  End Sub

  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Try
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

      ' Reset Data Point Attributes
      Dim point As DataPoint
      For Each objSeries In graph.Series
        If objSeries.Name.StartsWith("Day") Then
          For Each point In objSeries.Points
            point.Color = Color.FromArgb(200, 65, 140, 240)
          Next point
        End If
      Next


      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("Day") Then

          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue

        Else
          ' Set default cursor
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
        If result.Series.Name.StartsWith("Day") Then
          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = result.Series.Points(result.PointIndex)
          RaiseEvent DreamSelected(point.ToolTip)
        End If
      Else
        If result.ChartElementType = ChartElementType.Annotation Then
          point = result.Object.AnchorDataPoint
          RaiseEvent DreamSelected(point.ToolTip)
        End If
      End If
    End If
  End Sub
End Class
