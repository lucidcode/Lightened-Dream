Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CategoryListControl

    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strFileName As String
    Public Category As String

    Public Event CategorySelected(ByVal Entry As String)

    Public Sub LoadCategory()
        Try
            graph.ChartAreas(0).BackColor = Me.BackColor

            lblT.Visible = True
            txtName.Visible = True
            txtName.Text = Category

            For Each strCategory As String In "Characters,Locations,Objects,Actions,Themes,Emotions".Split(",")
                If Category.ToLower = strCategory.ToLower Then
                    lblT.Visible = False
                    txtName.Visible = False
                    Exit For
                End If
            Next

            Dim objSeries As Series = graph.Series("DreamSeries")
            objSeries.Points.Clear()
            objSeries("PieDrawingStyle") = "SoftEdge"
            lstCategories.Items.Clear()
            lblTitle.Text = "Categories - " + Category

            For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + Category, "*.ld3")
                Dim xmlDoc As New Xml.XmlDocument
                xmlDoc.Load(strCatgeoryFile)

                Dim intCount As Integer = xmlDoc.DocumentElement.SelectNodes("//Dream").Count

                Dim lstItem As New ListViewItem(New FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""))
                lstItem.SubItems.Add(intCount)
                lstCategories.Items.Add(lstItem)

                If intCount > 0 Then
                    Dim intPoint As Integer = objSeries.Points.AddY(intCount)
                    objSeries.Points(intPoint).Label = lstItem.Text
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Public Sub Save()
    If txtName.Text <> Category Then
      Directory.Move(m_strPath & "Categories\" & Category, m_strPath & "Categories\" & txtName.Text)
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
End Class
