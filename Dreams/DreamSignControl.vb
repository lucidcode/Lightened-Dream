Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Windows.Forms.DataVisualization

Public Class DreamSignControl

  Public Event MonthSelected(ByVal Month As String)
  Public Event CategoryFileSelected(ByVal Category As String, ByVal Item As String)
  Public Event CategoryFileCreated(ByVal Category As String, ByVal Item As String)
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"
    Private m_boolSearching As Boolean = False

    Private m_arrDreamFiles As String()
    Private m_intSelectedFile As Integer = 0

    Private m_strSelectedNewCategory As String
    Private m_arrWords As New List(Of Word)
    Private m_arrIgnore As New List(Of String)

    Private objSeries As Series
    Private objDreams As Series
    Private m_arrTop100 As New List(Of Word)
    Private m_arrTop10 As New List(Of Word)

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objDreams = Chart1.Series.Add("Dreams")
        objDreams.ChartType = SeriesChartType.Column
        objDreams.Color = Color.FromArgb(200, 65, 140, 240)
        objDreams.BorderWidth = 1
    End Sub

    Private Class Word
        Public Name As String = ""
        Public Count As Integer = 1
    End Class

    Public Sub StartSearch()
        objDreams.Points.Clear()
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(0)
        objDreams.Points.AddY(1000)
        tmrSearching.Enabled = True


        pnlSearching.Visible = True
        graph.Height = Me.Height - graph.Top - 48

        Dim xmlDocIgnore As New XmlDocument
        Dim strXml As String = ""


        m_arrWords = New List(Of Word)
        m_arrIgnore = New List(Of String)
        m_arrTop100 = New List(Of Word)
        m_arrTop10 = New List(Of Word)

        ' Make sure that the ignore file exists
        If (Not File.Exists(m_strPath & "IgnoreList.ld3")) Then
            ' Create the ignore file
            strXml = "<LightenedDream>"
            strXml += "</LightenedDream>"
            xmlDocIgnore.LoadXml(strXml)
            xmlDocIgnore.Save(m_strPath & "IgnoreList.ld3")
        End If

        xmlDocIgnore.Load(m_strPath & "IgnoreList.ld3")

        For Each xmlNode As XmlNode In xmlDocIgnore.DocumentElement.SelectNodes("Ignore")
            m_arrIgnore.Add(xmlNode.InnerText.ToLower)
        Next

        For Each strCategory As String In m_strCategories.Split(",")
            For Each strCatgeoryFile As String In Directory.GetFiles(m_strPath + "Categories\" + strCategory, "*.ld3")
                Dim strName As String = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")
                m_arrIgnore.Add(strName.ToLower)
            Next
        Next

        m_arrDreamFiles = Directory.GetFiles(m_strPath & "Dreams\", "*.ld3", SearchOption.AllDirectories)
        m_arrWords.Clear()

        graph.Series.Clear()
        graph.ChartAreas(0).AxisX.CustomLabels.Clear()
        graph.Visible = True

        m_intSelectedFile = 0

        tmrDreamSigns.Enabled = True

        objSeries = graph.Series.Add("DreamSigns")
        objSeries.ChartType = SeriesChartType.Column

        objSeries.Color = Color.FromArgb(200, 65, 140, 240)
        objSeries.BorderWidth = 1
        objSeries("BarLabelStyle") = "Center"

    End Sub

    Private Sub tmrDreamSigns_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDreamSigns.Tick
        tmrDreamSigns.Enabled = False

        If m_intSelectedFile >= m_arrDreamFiles.Length Then
            tmrDreamSigns.Enabled = False
            pnlSearching.Visible = False
            graph.Height = Me.Height - graph.Top - 8
            tmrSearching.Enabled = False
            Exit Sub
        End If

        Dim xmlDream As New XmlDocument
        xmlDream.Load(m_arrDreamFiles(m_intSelectedFile))

        Dim arrWords() As String = Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText)
        Search(arrWords)

        m_intSelectedFile += 1
        tmrDreamSigns.Enabled = True
    End Sub

    Private Sub Search(ByVal arrWords() As String)
        If m_boolSearching Then
            Return
        End If

        For Each strWord As String In arrWords

            If strWord <> "" Then

                ' Check if the word is in the list
                Dim boolFound As Boolean = False
                For Each objWord As Word In m_arrWords
                    If objWord.Name.ToLower = strWord.ToLower Then
                        objWord.Count += 1
                        boolFound = True
                        Exit For
                    End If
                Next

                If Not boolFound Then
                    ' Check if it is in the black list
                    Dim boolIgnored As Boolean = False
                    For Each strIgnoreWord As String In m_arrIgnore
                        If strIgnoreWord.ToLower = strWord.ToLower Then
                            boolIgnored = True
                            Exit For
                        End If
                    Next

                    If Not boolIgnored Then
                        ' Add it to the list
                        Dim objWord As New Word
                        objWord.Name = strWord
                        m_arrWords.Add(objWord)
                    End If

                End If
            End If

        Next

        ' Find the top 100
        For Each objWord As Word In m_arrWords

            If m_arrTop100.Count < 100 Then
                Dim boolAlreadyExists As Boolean = False
                For Each objTopWord As Word In m_arrTop100
                    If objWord.Name.ToLower = objTopWord.Name.ToLower Then
                        boolAlreadyExists = True
                        Exit For
                    End If
                Next

                If Not boolAlreadyExists Then
                    m_arrTop100.Add(objWord)
                End If
            Else

                Dim boolAlreadyExists As Boolean = False
                For Each objTopWord As Word In m_arrTop100
                    If objWord.Name.ToLower = objTopWord.Name.ToLower Then
                        boolAlreadyExists = True
                        Exit For
                    End If
                Next

                If Not boolAlreadyExists Then
                    For Each objTopWord As Word In m_arrTop100
                        If objWord.Count > objTopWord.Count Then

                            objTopWord.Name = objWord.Name
                            objTopWord.Count = objWord.Count

                            Application.DoEvents()

                            Exit For
                        End If
                    Next
                End If

            End If
        Next

        LoadGraph()

        m_boolSearching = False
    End Sub

    Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
        Try
            If tmrSearching.Enabled Then Exit Sub

            Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

            ' Reset Data Point Attributes
            Dim point As DataPoint
            For Each objSeries As Series In graph.Series
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub graph_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseDown
        tmrDreamSigns.Enabled = False
        pnlSearching.Visible = False
        graph.Height = Me.Height - graph.Top - 8
        tmrSearching.Enabled = False

        Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
        Dim point As DataPoint
        If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
            point = result.Series.Points(result.PointIndex)
            m_strSelectedNewCategory = point.Tag.ToString
            mnuAddTo.Text = "Add '" & m_strSelectedNewCategory & "' to"
            mnuIgnore.Text = "Ignore '" & m_strSelectedNewCategory & "'"
            mnuCategories.Show(graph, e.X, e.Y)
        End If
    End Sub

    Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCharacters.Click, mnuActions.Click, mnuEmotions.Click, mnuLocations.Click, mnuObjects.Click, mnuThemes.Click
        RaiseEvent CategoryFileCreated(CType(sender, ToolStripMenuItem).Tag, m_strSelectedNewCategory)

        For Each objWord As Word In m_arrTop100
            If objWord.Name = m_strSelectedNewCategory Then
                m_arrTop100.Remove(objWord)
                Exit For
            End If
        Next
        LoadGraph()
    End Sub

    Private Sub tmrSearching_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSearching.Tick
        objDreams.Points.AddY(Int(Rnd() * 1000))
        objDreams.Points.Remove(objDreams.Points(0))
    End Sub

    Private Sub LoadGraph()
        objSeries.Points.Clear()
        graph.Annotations.Clear()



        ' Find the top 10
        For Each objWord As Word In m_arrTop100

            If m_arrTop10.Count < 10 Then
                Dim boolAlreadyExists As Boolean = False
                For Each objTopWord As Word In m_arrTop10
                    If objWord.Name.ToLower = objTopWord.Name.ToLower Then
                        boolAlreadyExists = True
                        Exit For
                    End If
                Next

                If Not boolAlreadyExists Then
                    m_arrTop10.Add(objWord)
                End If
            Else

                Dim boolAlreadyExists As Boolean = False
                For Each objTopWord As Word In m_arrTop10
                    If objWord.Name.ToLower = objTopWord.Name.ToLower Then
                        boolAlreadyExists = True
                        Exit For
                    End If
                Next

                If Not boolAlreadyExists Then
                    If m_arrTop10.Count > 0 Then
                        For Each objTopWord As Word In m_arrTop10
                            If objWord.Count > objTopWord.Count Then

                                objTopWord.Name = objWord.Name
                                objTopWord.Count = objWord.Count

                                Application.DoEvents()

                                Exit For
                            End If
                        Next
                    End If
                End If

            End If
        Next


        Dim intAdded As Integer = 0
        For Each objTopWord As Word In m_arrTop10
            objSeries.Points.AddY(objTopWord.Count)
            objSeries.Points(objSeries.Points.Count - 1).Tag = objTopWord.Name
            objSeries.Points(objSeries.Points.Count - 1).ToolTip = objTopWord.Name & " (" & objTopWord.Count & ")"

            Dim objDreamAnnotation As New Charting.CalloutAnnotation
            objDreamAnnotation.AllowMoving = True
            objDreamAnnotation.AllowResizing = True
            objDreamAnnotation.AllowSelecting = True
            objDreamAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
            objDreamAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            objDreamAnnotation.ForeColor = System.Drawing.Color.SteelBlue
            objDreamAnnotation.LineColor = System.Drawing.Color.LightSteelBlue
            objDreamAnnotation.Name = Guid.NewGuid.ToString
            objDreamAnnotation.ShadowColor = System.Drawing.Color.SteelBlue
            objDreamAnnotation.ShadowOffset = 1
            objDreamAnnotation.Text = objTopWord.Name
            objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
            objDreamAnnotation.AnchorDataPoint = objSeries.Points(objSeries.Points.Count - 1)
            Me.graph.Annotations.Add(objDreamAnnotation)
            intAdded += 1
            If intAdded > 10 Then
                Exit For
            End If
        Next

        If pnlSearching.Visible = False Then
            If m_arrTop100.Count < 10 Then
                StartSearch()
            End If
        End If

    End Sub

    Private Sub mnuIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIgnore.Click
        Try

            ' Load the ignore file
            Dim xmlDocIgnore As New XmlDocument
            xmlDocIgnore.Load(m_strPath & "IgnoreList.ld3")

            ' Add the new word to the ignore file
            Dim xmlNode As XmlNode = xmlDocIgnore.CreateElement("Ignore")
            xmlNode.InnerText = m_strSelectedNewCategory
            xmlDocIgnore.DocumentElement.AppendChild(xmlNode)
            xmlDocIgnore.Save(m_strPath & "IgnoreList.ld3")

            ' Reload the graph
            For Each objWord As Word In m_arrTop100
                If objWord.Name = m_strSelectedNewCategory Then
                    m_arrTop100.Remove(objWord)
                    Exit For
                End If
            Next

            LoadGraph()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.DreamSigns.Ignore()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
