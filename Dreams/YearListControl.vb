Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class YearListControl

  Public Event MonthSelected(ByVal Month As String)

  Public Sub LoadYear(ByVal Folder As String, ByVal Year As String)
    Dim intPos As Double = 0.5
    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Series.Clear()
    lstDreams.Items.Clear()

    Dim dtYear As DateTime = New DateTime(Year, 1, 1)
    Dim currentMonth As Integer = 0


    Dim objSeries As Series = graph.Series.Add("Year")
    objSeries.ChartType = SeriesChartType.Column
    lblTitle.Text = "Dreams - " & Year

    'objSeries.BorderDashStyle = ChartDashStyle.Solid
    objSeries.Color = Color.FromArgb(200, 65, 140, 240)
    objSeries.BorderWidth = 1
    objSeries("BarLabelStyle") = "Center"


    For Each strMonthFolder As String In Directory.GetDirectories(Folder)

      objSeries.Points.AddY(0)
      objSeries.Points(objSeries.Points.Count - 1).ToolTip = New DirectoryInfo(strMonthFolder).Name

      graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, New DirectoryInfo(strMonthFolder).Name)
      intPos += 1

      For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
        objSeries.Points(objSeries.Points.Count - 1).YValues(0) += 1
      Next
      Application.DoEvents()
    Next

    Return

    Do

      Dim dtMonth As DateTime = New DateTime(Year, dtYear.Month, 1)

      Dim intPoint As Integer
      Dim lstItem As ListViewItem

      lblTitle.Text = "Dreams - " & Year

      Dim intValue As Integer = 0
      If IO.Directory.Exists(Folder & "\" & Format(dtYear, "MM")) Then


        'objSeries.Label = Format(dtMonth, "MMM")
        intPos = 0.5

        ' Load each dream
        For Each strDreamFile As String In Directory.GetFiles(Folder & "\" & Format(dtYear, "MM"), "*.ld3")
          Dim xmlDream As New XmlDocument
          xmlDream.Load(strDreamFile)
          lstItem = New ListViewItem(xmlDream.DocumentElement.SelectSingleNode("Date").InnerText)
          lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText)
          lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.Split(" ").Length)
          lstItem.Tag = strDreamFile
          lstDreams.Items.Add(lstItem)
        Next

        Do

          Dim boolFound As Boolean = False
          For Each lstItem In lstDreams.Items
            If lstItem.Text = dtMonth Then
              boolFound = True
              Exit For
            End If
          Next

          If boolFound Then
            ' intPoint = objSeries.Points.AddY(lstItem.SubItems(2).Text)
            intValue += lstItem.SubItems(2).Text
          Else
            'intPoint = objSeries.Points.AddY(0)
          End If


          dtMonth = dtMonth.AddDays(1)
          intPos = intPos + 1
        Loop Until dtMonth.Month <> dtYear.Month


      End If

      intPoint = objSeries.Points.AddY(intValue)
      objSeries.Points(intPoint).ToolTip = Format(dtYear, "MM")

      dtYear = dtYear.AddMonths(1)
    Loop Until dtYear.Year <> Year
  End Sub

  Private Sub tbcMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub lstCategories_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

  End Sub

  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Try
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

      ' Reset Data Point Attributes
      Dim point As DataPoint
      For Each point In graph.Series("Year").Points
        point.Color = Color.FromArgb(200, 65, 140, 240)
      Next point

      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name = "Year" Then

          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = graph.Series("Year").Points(result.PointIndex)
          point.Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue
        Else
          ' Set default cursor
          Me.Cursor = Cursors.Default
        End If
      Else
        ' Set default cursor
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
        If result.Series.Name = "Year" Then
          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = graph.Series("Year").Points(result.PointIndex)
          RaiseEvent MonthSelected(point.ToolTip)
        End If
      End If
    End If
  End Sub
End Class
