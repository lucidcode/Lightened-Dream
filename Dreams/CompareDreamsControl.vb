Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Windows.Forms.DataVisualization

Public Class CompareDreamsControl

  Public Event MonthSelected(ByVal Month As String)
  Public Event CategoryFileSelected(ByVal Category As String, ByVal Item As String)
    Public Event CategoryFileCreated(ByVal Category As String, ByVal Item As String)

    Public OnlyCategories As Boolean = False

    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
    Private m_boolSearching As Boolean = False

    Private m_arrDreams As New List(Of Dream)
    Private m_intSelectedFile As Integer = 0

    Private m_strSelectedNewCategory As String
    Private m_arrWords As New List(Of Word)
    Private m_arrIgnore As New List(Of String)
    Private m_arrCategories As New List(Of String)

    Private objSeries As Series
    Private objDreams As Series

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

    Private Class Dream
        Public File As String = ""
        Public Name As String = ""
        Public Words As New List(Of String)
        Public Matches As Integer
        Public Parent As Dream
        Public SimilarDreams As List(Of Dream)
        Public SharedWords As String = ""
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
        m_arrCategories = New List(Of String)

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

    ' Load each Category
    For Each strCategory As String In Directory.GetDirectories(m_strPath + "Categories")
      LoadCategoryFolder(strCategory)
    Next

        Dim arrDreamFiles As String() = Directory.GetFiles(m_strPath & "Dreams\", "*.ld3", SearchOption.AllDirectories)
        For Each strDreamFile As String In arrDreamFiles
            Dim objDream As New Dream
            objDream.File = strDreamFile
            m_arrDreams.Add(objDream)
        Next

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

  Private Sub LoadCategoryFolder(ByVal categoryPath As String)
    For Each strCatgeoryFile As String In Directory.GetFiles(categoryPath, "*.ld3")
      Dim strName As String = New FileInfo(strCatgeoryFile).Name.Replace(".ld3", "")

      m_arrCategories.Add(strName.ToLower)

      Dim xmlDocCategory As New XmlDocument
      xmlDocCategory.Load(strCatgeoryFile)
      For Each xmlWord As XmlNode In xmlDocCategory.DocumentElement.SelectNodes("Names/Name")
          m_arrCategories.Add(xmlWord.InnerText.ToLower)
      Next
    Next

    For Each subCategory As String In Directory.GetDirectories(categoryPath)
      LoadCategoryFolder(subCategory)
    Next
  End Sub

    Private Sub tmrDreamSigns_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDreamSigns.Tick
        tmrDreamSigns.Enabled = False

        If m_intSelectedFile >= m_arrDreams.Count Then
            tmrDreamSigns.Enabled = False

            m_intSelectedFile = 0
            tmrDreams.Enabled = True
            Exit Sub
        End If

        Dim xmlDream As New XmlDocument
        xmlDream.Load(m_arrDreams(m_intSelectedFile).File)

        m_arrDreams(m_intSelectedFile).Name = New FileInfo(m_arrDreams(m_intSelectedFile).File).Name.Replace(".ld3", "")
        Dim arrWords() As String = Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText)
        Dim arrWordsInDream As List(Of String) = SearchForDreamSigns(arrWords, m_arrDreams(m_intSelectedFile).Name)
        m_arrDreams(m_intSelectedFile).Words = arrWordsInDream

        m_intSelectedFile += 1
        tmrDreamSigns.Enabled = True
    End Sub

    Private Sub tmrDreams_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDreams.Tick
        tmrDreams.Enabled = False

        If m_intSelectedFile >= m_arrDreams.Count Then
            tmrSearching.Enabled = False
            tmrDreams.Enabled = False
            pnlSearching.Visible = False

            graph.Height = Me.Height - graph.Top - 8
            tmrDreams.Enabled = False

            CalculateSimliarities()
            Exit Sub
        End If


        m_arrDreams(m_intSelectedFile).SimilarDreams = New List(Of Dream)

        ' Compare lists
        For Each objExisitingDream As Dream In m_arrDreams

            Dim strSharedWords As String = ""
            If m_arrDreams(m_intSelectedFile).File <> objExisitingDream.File Then
                Dim intSameWords As Integer = 0
                For Each objOtherWord As String In m_arrDreams(m_intSelectedFile).Words
                    For Each objWord As String In objExisitingDream.Words
                        If objOtherWord = objWord Then
                            intSameWords += 1
                            strSharedWords += objWord + ", "
                            Exit For
                        End If
                    Next
                Next

                If intSameWords > 0 Then
                    Dim objExisitingDreamClone As New Dream
                    objExisitingDreamClone.Name = objExisitingDream.Name
                    objExisitingDreamClone.File = objExisitingDream.File
                    objExisitingDreamClone.Matches = intSameWords
                    objExisitingDreamClone.SharedWords = strSharedWords.TrimEnd(" ").TrimEnd(",")
                    'objExisitingDreamClone.Parent = m_arrDreams(m_intSelectedFile)
                    m_arrDreams(m_intSelectedFile).SimilarDreams.Add(objExisitingDreamClone)
                End If

                ' Cull to top 3
                Dim arrTop3 As New List(Of Dream)
                For Each objSimilarDream As Dream In m_arrDreams(m_intSelectedFile).SimilarDreams

                    If arrTop3.Count < 3 Then
                        arrTop3.Add(objSimilarDream)
                    Else

                        For Each objTopDream As Dream In arrTop3
                            If objSimilarDream.Matches > objTopDream.Matches Then

                                arrTop3.Remove(objTopDream)

                                Dim objDreamClone As New Dream
                                objDreamClone.Name = objSimilarDream.Name
                                objDreamClone.File = objSimilarDream.File
                                objDreamClone.Matches = objSimilarDream.Matches
                                objDreamClone.SharedWords = objSimilarDream.SharedWords

                                arrTop3.Add(objDreamClone)

                                Exit For
                            End If
                        Next

                    End If
                Next

                m_arrDreams(m_intSelectedFile).SimilarDreams = arrTop3

            End If
        Next

        CalculateSimliarities()

        m_intSelectedFile += 1
        tmrDreams.Enabled = True
    End Sub

    Dim m_arrAllWordsDreams As New List(Of Word)

    Dim m_arrLatestDreams As New List(Of Word)

    Private Function SearchForDreamSigns(ByVal arrWords() As String, ByVal Entry As String) As List(Of String)
        If m_boolSearching Then
            Return Nothing
        End If

        Dim arrWordsInDream As New List(Of String)

        For Each strWord As String In arrWords

            If strWord <> "" Then

                ' Check if the word is already in the list
                Dim boolFound As Boolean = False
                For Each strExisitingWord As String In arrWordsInDream
                    If strExisitingWord.ToLower = strWord.ToLower Then
                        boolFound = True
                        Exit For
                    End If
                Next

                ' Make sure it isn't in the ignore list
                For Each strExisitingWord As String In m_arrIgnore
                    If strExisitingWord.ToLower = strWord.ToLower Then
                        boolFound = True
                        Exit For
                    End If
                Next

                If Not boolFound Then
                    If OnlyCategories Then
                        For Each strCategory As String In m_arrCategories
                            If strCategory.ToLower = strWord.ToLower Then
                                arrWordsInDream.Add(strWord.ToLower)
                                Exit For
                            End If
                        Next
                    Else
                        arrWordsInDream.Add(strWord.ToLower)
                    End If



                End If
            End If

        Next

        If m_arrLatestDreams.Count > 10 Then
            m_arrLatestDreams.Remove(m_arrLatestDreams(0))
        End If

        Dim objDreamWord As New Word
        objDreamWord.Name = Entry
        objDreamWord.Count = arrWordsInDream.Count
        m_arrLatestDreams.Add(objDreamWord)

        ' Find the top 10
        '    For Each objWord As String In arrWordsInDream

        '        If m_arrTop10.Count < 10 Then
        '            m_arrTop10.Add(objWord)
        '        Else

        '            Dim boolAlreadyExists As Boolean = False
        '            For Each objTopWord As Word In m_arrTop10
        '                If objWord.Name.ToLower = objTopWord.Name.ToLower Then
        '                    boolAlreadyExists = True
        '                    Exit For
        '                End If
        '            Next

        '            If Not boolAlreadyExists Then
        '                For Each objTopWord As Word In m_arrTop10
        '                    If objWord.Count > objTopWord.Count Then

        '                        objTopWord.Name = objWord.Name
        '                        objTopWord.Count = objWord.Count

        '                        Application.DoEvents()

        '                        Exit For
        '                    End If
        '                Next
        '            End If

        '        End If

        '    Next

        objSeries.Points.Clear()
        graph.Annotations.Clear()

        For Each objTopWord As Word In m_arrLatestDreams
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
        Next

        m_boolSearching = False

        Return arrWordsInDream
    End Function

    Dim strReport As String = ""
    Private Sub CalculateSimliarities()
        Dim arrTop10 As New List(Of Dream)

        For Each objDream As Dream In m_arrDreams

            If Not objDream.SimilarDreams Is Nothing Then
                For Each objSimilarDream As Dream In objDream.SimilarDreams

                    If arrTop10.Count < 5 Then

                        ' Make sure it doesn't exist yet
                        Dim boolExists As Boolean = False
                        For Each objAlreadyTop10 As Dream In arrTop10
                            If objAlreadyTop10.File = objSimilarDream.File Then
                                If objAlreadyTop10.Parent.File = objDream.File Then
                                    boolExists = True
                                    Exit For
                                End If
                            End If
                        Next

                        'Flip
                        For Each objAlreadyTop10 As Dream In arrTop10
                            If objAlreadyTop10.Parent.File = objSimilarDream.File Then
                                If objAlreadyTop10.File = objDream.File Then
                                    boolExists = True
                                    Exit For
                                End If
                            End If
                        Next

                        If Not boolExists Then
                            Dim objDreamClone As New Dream
                            objDreamClone.Name = objSimilarDream.Name
                            objDreamClone.File = objSimilarDream.File
                            objDreamClone.Parent = objDream
                            objDreamClone.Matches = objSimilarDream.Matches
                            objDreamClone.SharedWords = objSimilarDream.SharedWords

                            arrTop10.Add(objDreamClone)
                        End If
                    Else

                        ' Make sure it doesn't exist yet
                        Dim boolExists As Boolean = False
                        For Each objAlreadyTop10 As Dream In arrTop10
                            If objAlreadyTop10.File = objSimilarDream.File Then
                                If objAlreadyTop10.Parent.File = objDream.File Then
                                    boolExists = True
                                    Exit For
                                End If
                            End If
                        Next

                        'Flip
                        For Each objAlreadyTop10 As Dream In arrTop10
                            If objAlreadyTop10.Parent.File = objSimilarDream.File Then
                                If objAlreadyTop10.File = objDream.File Then
                                    boolExists = True
                                    Exit For
                                End If
                            End If
                        Next

                        If Not boolExists Then
                            For Each objTopDream As Dream In arrTop10
                                If objSimilarDream.Matches > objTopDream.Matches Then
                                    arrTop10.Remove(objTopDream)

                                    Dim objDreamClone As New Dream
                                    objDreamClone.Name = objSimilarDream.Name
                                    objDreamClone.File = objSimilarDream.File
                                    objDreamClone.Matches = objSimilarDream.Matches
                                    objDreamClone.Parent = objDream
                                    objDreamClone.SharedWords = objSimilarDream.SharedWords
                                    arrTop10.Add(objDreamClone)

                                    Application.DoEvents()

                                    Exit For
                                End If
                            Next
                        End If
                    End If

                Next
            End If
        Next

        objSeries.Points.Clear()
        graph.Annotations.Clear()

        strReport = ""
        For Each objTopDream As Dream In arrTop10
            objSeries.Points.AddY(objTopDream.Matches)
            objSeries.Points(objSeries.Points.Count - 1).Tag = objTopDream.Name
            objSeries.Points(objSeries.Points.Count - 1).ToolTip = "[" & objTopDream.Matches & "]: " + ParaString(objTopDream.SharedWords)

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
            objDreamAnnotation.Text = objTopDream.Parent.Name & vbNewLine & " ≈≈≈ " & vbNewLine & objTopDream.Name & vbNewLine
            objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
            objDreamAnnotation.AnchorDataPoint = objSeries.Points(objSeries.Points.Count - 1)
            Me.graph.Annotations.Add(objDreamAnnotation)
            strReport += objTopDream.Parent.Name & " ≈≈≈ " & objTopDream.Name & vbNewLine & "[" & objTopDream.Matches & "]: " + objTopDream.SharedWords & vbNewLine & vbNewLine
        Next
        strReport = strReport.TrimEnd(vbNewLine)
        strReport = strReport.TrimEnd(vbNewLine)
        Application.DoEvents()

    End Sub

    Private Function ParaString(ByVal str As String) As String
        Dim chunkSize As Integer = 64
        Dim stringLength As Integer = str.Length
        Dim i As Integer = 0
        Dim strResponse As String = ""

        While i < stringLength
            If i + chunkSize > stringLength Then
                chunkSize = stringLength - i
            End If

            strResponse += str.Substring(i, chunkSize) & vbNewLine

            i += chunkSize
        End While

        Return strResponse.TrimEnd(vbNewLine)
    End Function

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

        mnuCategories.Show(graph, e.X, e.Y)
    End Sub

    Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent CategoryFileCreated(CType(sender, ToolStripMenuItem).Tag, m_strSelectedNewCategory)

    End Sub

    Private Sub tmrSearching_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSearching.Tick
        objDreams.Points.AddY(Int(Rnd() * 1000))
        objDreams.Points.Remove(objDreams.Points(0))
    End Sub

    Private Sub mnuIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            ' Load the ignore file
            Dim xmlDocIgnore As New XmlDocument
            xmlDocIgnore.Load(m_strPath & "IgnoreList.ld3")

            ' Add the new word to the ignore file
            Dim xmlNode As XmlNode = xmlDocIgnore.CreateElement("Ignore")
            xmlNode.InnerText = m_strSelectedNewCategory
            xmlDocIgnore.DocumentElement.AppendChild(xmlNode)
            xmlDocIgnore.Save(m_strPath & "IgnoreList.ld3")

            ' Rerun the search
            StartSearch()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.DreamSigns.Ignore()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        Clipboard.SetText(strReport)
        MessageBox.Show("The comparison report was successfully copied to the clipboard.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
