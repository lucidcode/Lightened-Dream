﻿Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SearchControl

  Public Event MonthSelected(ByVal Month As String)
  Public Event CategoryFileSelected(ByVal Category As String, ByVal Item As String)
  Public Event CategoryFileCreated(ByVal Category As String, ByVal Item As String)
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
  Private m_boolSearching As Boolean = False
  Private objDreamSeries As Series

  Private m_strSelectedNewCategory As String

  Public Sub Activate()
    txtSearch.Focus()
    If txtSearch.Text <> "" Then
      Search()
    End If
  End Sub

  Private Sub Search()

    If m_boolSearching Then
      Return
    End If

    m_boolSearching = True

    Try
      Dim intPos As Double = 0.5

      Dim arrWords = txtSearch.Text.Replace(",", " ").Replace(vbNewLine, " ").Split(" ")
      Dim xmlDream As New XmlDocument

      graph.Series.Clear()
      graph.ChartAreas(0).AxisX.CustomLabels.Clear()
      graph.Visible = True


      objDreamSeries = graph.Series.Add("Dreams")
      objDreamSeries.ChartType = SeriesChartType.SplineArea
      objDreamSeries.Tag = 0
      objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240)
      objDreamSeries.BorderWidth = 1
      objDreamSeries("BarLabelStyle") = "Center"

      objDreamSeries.Points.AddY(0)
      intPos = 1

      ' Load all the words
      For Each strWord As String In arrWords
        If strWord <> "" Then
          Dim objSeries As Series = graph.Series.Add(strWord)
          objSeries.ChartType = SeriesChartType.StackedColumn
          graph.ApplyPaletteColors()
          objSeries.Points.Add(0)
          objSeries.Tag = 0
        End If
      Next

      For Each objSeries As Series In graph.Series
        objSeries.Color = Color.FromArgb(200, objSeries.Color.R, objSeries.Color.G, objSeries.Color.B)
      Next

      For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
        For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)

          objDreamSeries.Points.AddY(0)

          For Each strWord As String In arrWords
            If strWord <> "" Then
              graph.Series(strWord).Points.AddY(0)
              graph.Series(strWord).Points(graph.Series(strWord).Points.Count - 1).ToolTip = strWord & " - " & New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name
            End If
          Next

          graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name)
          intPos += 1

          For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")

            objDreamSeries.Tag += 1
            objDreamSeries.Points(objDreamSeries.Points.Count - 1).YValues(0) += 1
            objDreamSeries.Points(objDreamSeries.Points.Count - 1).ToolTip = New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name

            xmlDream.Load(strDreamFile)

            For Each strWord As String In arrWords
              If strWord <> "" Then
                If (xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower.Contains(strWord.ToLower)) Then

                  graph.Series(strWord).Points(graph.Series(strWord).Points.Count - 1).YValues(0) += 1
                  graph.Series(strWord).Tag += 1

                End If
              End If
            Next

          Next

          For Each strWord As String In arrWords
            If strWord <> "" Then
              graph.Series(strWord).Points(graph.Series(strWord).Points.Count - 1).ToolTip = New DirectoryInfo(strYearFolder).Name & "-" & New DirectoryInfo(strMonthFolder).Name & " - " & strWord & " (" & graph.Series(strWord).Points(graph.Series(strWord).Points.Count - 1).YValues(0) & ")"
            End If
          Next

          Application.DoEvents()

        Next
      Next

      ' Link to categories
      For Each objSeries As Series In graph.Series
        If objSeries.Name <> "Dreams" Then
          For Each strCategory As String In "Characters,Locations,Objects,Actions,Themes,Emotions".Split(",")
            For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3")
              Dim strName As String = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
              If strName.ToLower = objSeries.Name.ToLower Then
                Dim strTag As String = objSeries.Tag
                objSeries.Tag = strCategory & "\" & objSeries.Name
                objSeries.Name += " (" & strTag & ")"
                Exit For
              End If

              Dim xmlDocCategory As New XmlDocument
              xmlDocCategory.Load(strCatgeoryFile)
              For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
                If xmlWord.InnerText.ToLower = objSeries.Name.ToLower Then
                  Dim strTag As String = objSeries.Tag
                  objSeries.Tag = strCategory & "\" & objSeries.Name
                  objSeries.Name += " (" & strTag & ")"
                  Exit For
                End If
              Next
            Next
          Next
        End If
      Next


      ' Totals
      For Each objSeries As Series In graph.Series
        If objSeries.Name <> "Dreams" Then
          If Val(objSeries.Tag) > 0 Then
            Dim strName As String = objSeries.Name
            objSeries.Name += " (" & objSeries.Tag & ")"
            objSeries.Tag = strName
          End If
        End If
      Next
      objDreamSeries.Name += " (" & objDreamSeries.Tag & ")"
      'For Each strWord As String In arrWords
      '  If strWord <> "" Then
      '    graph.Series(strWord).Name += " (" & graph.Series(strWord).Tag & ")"
      '  End If
      'Next

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
        If result.Series.Tag.ToString.Contains("\") Then
          Me.Cursor = Cursors.Hand
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B)
        ElseIf result.Series.Name.StartsWith("Dreams (") Then
          Me.Cursor = Cursors.Hand
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B)
        Else
          Me.Cursor = Cursors.Default
          point = result.Series.Points(result.PointIndex)
          point.Color = Color.FromArgb(220, point.Color.R, point.Color.G, point.Color.B)
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
        Else
          If result.Series.Tag.ToString.Contains("\") Then
            Dim arrCategoryFile() As String = result.Series.Tag.ToString.Split("\")
            RaiseEvent CategoryFileSelected(arrCategoryFile(0), arrCategoryFile(1))
          Else
            m_strSelectedNewCategory = result.Series.Tag.ToString
            mnuAddTo.Text = "Add '" & m_strSelectedNewCategory & "' to"
            mnuCategories.Show(graph, e.X, e.Y)
          End If
        End If
      End If
    End If

    If e.Button = Windows.Forms.MouseButtons.Right Then
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("Dreams (") Then
        Else
          If result.Series.Tag.ToString.Contains("\") Then
          Else
            m_strSelectedNewCategory = result.Series.Tag.ToString
            mnuAddTo.Text = "Add '" & m_strSelectedNewCategory & "' to"
            mnuCategories.Show(graph, e.X, e.Y)
          End If
        End If
      End If
    End If
  End Sub

  Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
    If e.KeyCode = Keys.Enter Then
      Search()
    End If
  End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    Search()
  End Sub

  Private Sub graph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graph.Click

  End Sub

  Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCharacters.Click, mnuActions.Click, mnuEmotions.Click, mnuLocations.Click, mnuObjects.Click, mnuThemes.Click
    RaiseEvent CategoryFileCreated(CType(sender, ToolStripMenuItem).Tag, m_strSelectedNewCategory)
  End Sub
End Class
