Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization
Imports System.Drawing.Drawing2D

Public Class MonthListControl

  Public Event DreamSelected(ByVal Dream As String)

  Public Sub LoadMonth(ByVal Folder As String, ByVal Year As String, ByVal Month As String)
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

    lblTitle.Text = "Dreams - " & Format(dtMonth, "yyyy - MMMM")

    ' Load each dream
    For Each strDreamFile As String In Directory.GetFiles(Folder, "*.ld3")
      Dim xmlDream As New XmlDocument
      Dim intLucidity As Integer = 1
      xmlDream.Load(strDreamFile)
      lstItem = New ListViewItem(xmlDream.DocumentElement.SelectSingleNode("Date").InnerText)
      lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText)
      lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.Split(" ").Length)
      If xmlDream.DocumentElement.SelectSingleNode("Sleep") IsNot Nothing Then
        'If xmlDream.DocumentElement.SelectSingleNode("Sleep").InnerText = xmlDream.DocumentElement.SelectSingleNode("Awake").InnerText Then
        '  lstItem.SubItems.Add("23:30")
        '  lstItem.SubItems.Add("06:30")
        'Else
        lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Sleep").InnerText)
        lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Awake").InnerText)
        'End If

        lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Time").InnerText)
      End If

      If xmlDream.DocumentElement.SelectSingleNode("Lucidity") IsNot Nothing Then
        intLucidity = xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText
      End If

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

    Dim objMoonSeries As Series = graph.Series.Add("Moon")
    objMoonSeries.ChartType = SeriesChartType.SplineArea
    objMoonSeries.Color = Color.WhiteSmoke
    graph.ApplyPaletteColors()

    Dim star As New AnnotationGroup()
    star.Width = 15
    star.Height = 15
    star.AllowSelecting = True
    star.AllowResizing = True

    graph.Annotations.Add(star)

    Dim starPolygon As PointF() = New PointF() {New PointF(1, 6), New PointF(27, 23), New PointF(33, 5), New PointF(44, 22), New PointF(58, 0), New PointF(57, 19), _
 New PointF(75, 11), New PointF(70, 28), New PointF(100, 37), New PointF(81, 53), New PointF(99, 65), New PointF(75, 67), _
 New PointF(87, 98), New PointF(63, 69), New PointF(60, 94), New PointF(47, 69), New PointF(34, 100), New PointF(32, 69), _
 New PointF(23, 74), New PointF(26, 61), New PointF(4, 72), New PointF(22, 49), New PointF(0, 39), New PointF(23, 32), _
 New PointF(1, 6)}

    Dim starPath As New GraphicsPath

    starPath.AddPolygon(starPolygon)
    Dim poly As New PolygonAnnotation()
    poly.Name = "Star"
    poly.GraphicsPath = starPath
    star.Annotations.Add(poly)

    ' Set star polygon annotation position and appearance
    star.Annotations("Star").X = 0
    star.Annotations("Star").Y = 0
    star.Annotations("Star").Width = 100
    star.Annotations("Star").Height = 100
    star.Annotations("Star").LineColor = System.Drawing.Color.LightSteelBlue
    star.Annotations("Star").BackColor = Color.White
    star.Annotations("Star").ShadowColor = System.Drawing.Color.SteelBlue
    star.Annotations("Star").ShadowOffset = 1

    ' Add text in the middle of the star shape
    Dim textAnnotation As New TextAnnotation()
    textAnnotation.Name = "StarText"
    textAnnotation.Text = "Lucid"
    textAnnotation.X = 20
    textAnnotation.Y = 15
    textAnnotation.Width = 60
    textAnnotation.Height = 60
    textAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    textAnnotation.ForeColor = System.Drawing.Color.SteelBlue
    star.Annotations.Add(textAnnotation)

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

              If strMostLucidDream = lstItem.Text & " - " & lstItem.SubItems(1).Text Then

                star.AnchorDataPoint = objSeriesN.Points(intPoint)
                star.AnchorAlignment = ContentAlignment.BottomCenter
                textAnnotation.Text = lstItem.SubItems(1).Text
                star.Tag = Format(dtMonth2, "dd") & " " & lstItem.SubItems(1).Text

              Else

                Dim objCalloutCloud As New Charting.CalloutAnnotation
                'objCalloutCloud.ClipToChartArea = "ChartArea1"
                '              objCalloutCloud.BackColor = Color.WhiteSmoke  'Color.FromArgb(0, 0, 0, 0)
                '              objCalloutCloud.BackColor = Color.FromArgb(0, 0, 0, 0)
                objCalloutCloud.AllowSelecting = True
                objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
                objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
                objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
                objCalloutCloud.Name = Guid.NewGuid.ToString
                objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
                '              objCalloutCloud.ShadowColor = Color.FromArgb(0, 0, 0, 0) ' System.Drawing.Color.
                objCalloutCloud.ShadowOffset = 1
                objCalloutCloud.Text = lstItem.SubItems(1).Text
                objCalloutCloud.Tag = Format(dtMonth2, "dd") & " " & lstItem.SubItems(1).Text
                objCalloutCloud.AnchorAlignment = ContentAlignment.BottomCenter
                objCalloutCloud.AnchorDataPoint = objSeriesN.Points(intPoint)
                Me.graph.Annotations.Add(objCalloutCloud)

              End If

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

    Dim dblLastVals() As Double
    'objSleepSeries.Points.Add(New Double() {100, 50})
    dblLastVals = New Double() {100, 50}

    Dim boolFirstDream As Boolean = True
    Dim intMissedDreamTimes As Integer = 1
    Dim intPointDream As Integer

    Do
      Dim intValue As Integer = 0
      Dim boolFound As Boolean = False

      For Each lstItem In lstDreams.Items
        If lstItem.Text = dtMonth Then
          intValue += lstItem.SubItems(2).Text
        End If
      Next

      For Each lstItem In lstDreams.Items
        If lstItem.Text = dtMonth Then
          boolFound = True
          Exit For
        End If
      Next

      If boolFound Then

        Dim arrSleep() As String = lstItem.SubItems(3).Text.Split(":")
        Dim arrAwake() As String = lstItem.SubItems(4).Text.Split(":")
        Dim arrDream() As String = lstItem.SubItems(5).Text.Split(":")

        Dim dtSleep As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, arrSleep(0), arrSleep(1), 0)
        Dim dtAwake As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, arrAwake(0), arrAwake(1), 0)
        Dim dtDream As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, arrDream(0), arrDream(1), 0)

        Dim intPointA As Integer = (dtSleep.Hour * 100) + dtSleep.Minute
        Dim intPointB As Integer = (dtAwake.Hour * 100) + dtAwake.Minute
        intPointDream = (dtDream.Hour * 100) + dtDream.Minute

        If intPointA > 1200 Then
          intPointA = intPointA - 2400
        End If

        If intPointB > 1200 Then
          intPointB = intPointB - 2400
        End If

        If intPointDream > 1200 Then
          intPointDream = intPointDream - 2400
        End If

        If intPointA = intPointB Then
          intPointA -= 1
        End If

        If intPointA > intPointB Then
          Dim intTemp As Integer = intPointA
          intPointA = intPointB
          intPointB = intTemp
        End If

        objSleepSeries.Points.Add(New Double() {intPointB, intPointA})
        objDreamSeries.Points.Add(intPointDream)

        dblLastVals = New Double() {intPointB, intPointA}

        If boolFirstDream Then
          boolFirstDream = False
          For i As Integer = 0 To intMissedDreamTimes - 1
            objSleepSeries.Points.Add(New Double() {intPointB, intPointA})
            objDreamSeries.Points.Add(intPointDream)
          Next
        End If

        'Dim boolOverlap As Boolean = False
        'If dtSleep > dtAwake Then
        '  dtSleep = dtSleep.AddDays(-1)
        '  boolOverlap = True
        'End If

        'Dim dtTime As TimeSpan = dtAwake.Subtract(dtSleep)

        'Dim intPointA As Integer = (intLongestDream / 1440) * (12 * 60) / 2

        'If boolOverlap Then
        '  intPointA += (intLongestDream / 1440) * (((24 - dtSleep.Hour) * 60) + dtSleep.Minute) / 2
        'Else
        '  intPointA += (intLongestDream / 1440) * (((dtSleep.Hour) * 60) + dtSleep.Minute) / 2
        'End If

        'Dim intPointB As Integer = intPointA + ((intLongestDream / 1440) * (dtTime.TotalMinutes)) / 2
        'If intPointA > intPointB Then
        '  objSleepSeries.Points.Add(New Double() {intPointA + 2, intPointB})
        '  dblLastVals = New Double() {intPointA + 2, intPointB}
        'Else
        '  objSleepSeries.Points.Add(New Double() {intPointB + 2, intPointA})
        '  dblLastVals = New Double() {intPointB + 2, intPointA}
        'End If

      Else
        If boolFirstDream Then
          intMissedDreamTimes += 1
        Else
          objSleepSeries.Points.Add(dblLastVals)
          objDreamSeries.Points.Add(intPointDream)
        End If

        'Dim intPointA As Integer = (intLongestDream / 1440) * (12 * 60) / 2
        'Dim intPointB As Integer = intPointA
        'If dblLastVals Is Nothing Then
        '  dblLastVals = New Double() {intPointB + 2, intPointA}
        'End If
        'objSleepSeries.Points.Add(dblLastVals)
      End If

      Dim intMoonAge As Integer = MoonAge(dtMonth.Year, dtMonth.Month, dtMonth.Day)
      objMoonSeries.Points.AddY((intLongestDream / 14) * intMoonAge)

      dtMonth = dtMonth.AddDays(1)
      intPos = intPos + 1
    Loop Until dtMonth.Month <> Month

  End Sub

  Private Function MoonAge(ByVal Year As String, ByVal Month As String, ByVal Day As String) As Integer
    Dim strmonth, strday, stryear
    Dim yy, y, m, d, p2, mm, k1, k2, k3, j, v, ip, ag

    strmonth = Month
    strday = Day
    stryear = Year

    y = stryear
    m = strmonth
    d = strday
    p2 = 2 * 3.14159

    yy = y - Int((12 - m) / 10)
    mm = m + 9
    If mm >= 12 Then
      mm = mm - 12
    End If
    k1 = Int(365.25 * (yy + 4712))
    k2 = Int(30.6 * mm + 0.5)
    k3 = Int(Int((yy / 100) + 49) * 0.75) - 38

    ' JD for dates in Julian calendar
    j = k1 + k2 + d + 59
    If j > 2299160 Then
      ' For Gregorian calendar
      j = j - k3
    End If

    ' J is the Julian date at 12h UT on day in question

    ' Calculate illumination (synodic) phase
    v = (j - 2451550.1) / 29.530588853
    v = v - Int(v)
    If v < 0 Then
      v = v + 1
    End If
    ip = v

    ' Moon's age in days
    ag = ip * 29.53


    '' phases from
    'phase = Array("new", "waxing crescent", "in its first quarter", _
    '"waxing gibbous", "full", "waning gibbous", _
    '"in its last quarter", "waning crescent")
    Select Case Int(ag)
      Case 0, 29
        Return 0
      Case 1, 2, 3, 4, 5, 6
        Return Int(ag)
      Case 7
        Return Int(ag)
      Case 8, 9, 10, 11, 12, 13
        Return Int(ag)
      Case 14
        Return 14
      Case 15, 16, 17, 18, 19, 20, 21
        Return 14 - (Int(ag) - 14)
      Case 22
        Return 14 - (Int(ag) - 14)
      Case 23, 24, 25, 26, 27, 28
        Return 14 - (Int(ag) - 14)
    End Select

    If Int(ag) = 29 Then Return 0
    Return Int(ag)
  End Function

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
      'For Each point In graph.Series("Sleep").Points
      '  point.Color = Color.FromArgb(100, 65, 240, 40)
      'Next
      For Each point In graph.Series("DreamTime").Points
        point.Color = Color.FromArgb(200, 65, 140, 240)
      Next

      For Each objAnnotation In graph.Annotations
        objAnnotation.BackColor = Color.White
        objAnnotation.ForeColor = Color.SteelBlue
      Next



      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("Day") Then

          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue

          'graph.Series("Sleep").Points(result.PointIndex + 1).Color = Color.FromArgb(200, 65, 240, 40)
          graph.Series("DreamTime").Points(result.PointIndex + 1).Color = Color.FromArgb(255, 65, 140, 240)

          For Each objAnnotation In graph.Annotations
            If objAnnotation.AnchorDataPoint Is point Then
              objAnnotation.BackColor = Color.FromArgb(200, 65, 140, 240)
              objAnnotation.ForeColor = Color.White
            End If
          Next

        ElseIf result.Series.Name.StartsWith("Sleep") Then

          '' Set cursor type 
          'Me.Cursor = Cursors.Hand

          '' Find selected data point
          'point = result.Series.Points(result.PointIndex)
          'point.Color = Color.FromArgb(200, 65, 240, 40) ' Color.LightSteelBlue



        Else
          ' Set default cursor
          Me.Cursor = Cursors.Default
        End If
      Else
        If result.ChartElementType = ChartElementType.Annotation Then

          Me.Cursor = Cursors.Hand



          point = result.Object.AnchorDataPoint
          point.Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue

          'graph.Series("Sleep").Points(point.Tag).Color = Color.FromArgb(200, 65, 240, 40)
          graph.Series("DreamTime").Points(point.Tag).Color = Color.FromArgb(255, 65, 140, 240)

          CType(result.Object, Annotation).BackColor = Color.FromArgb(200, 65, 140, 240)
          CType(result.Object, Annotation).ForeColor = Color.White
        Else
          ' Set default cursor
          Me.Cursor = Cursors.Default
        End If
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
