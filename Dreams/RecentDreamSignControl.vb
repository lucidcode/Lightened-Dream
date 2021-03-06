﻿Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Windows.Forms.DataVisualization

Public Class RecentDreamSignControl

  Public Event CategoryFileCreated(ByVal Category As String, ByVal Item As String)
  Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
  Private m_boolSearching As Boolean = False
  Private m_boolLoading As Boolean = True

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

  Private Sub mnuToolNewCategoryItem_Click(sender As System.Object, e As System.EventArgs)
    RaiseEvent CategoryFileCreated(CType(sender, ToolStripMenuItem).Tag, m_strSelectedNewCategory)

    For Each objWord As Word In m_arrTop100
      If objWord.Name = m_strSelectedNewCategory Then
        objWord.Name = ""
      End If
    Next

    mnuCategories.Hide()

    m_arrTop10.Clear()
    LoadGraph()
  End Sub

  Public Sub StartSearch()
    cmbFromYear.Items.Clear()
    cmbToYear.Items.Clear()

    For Each year As String In Directory.GetDirectories(m_strPath + "Dreams")
      cmbFromYear.Items.Add(New DirectoryInfo(year).Name)
      cmbToYear.Items.Add(New DirectoryInfo(year).Name)
    Next

    cmbFromYear.Text = cmbFromYear.Items(0)
    cmbToYear.Text = cmbFromYear.Items(cmbFromYear.Items.Count - 1)

    cmbFromMonth.Text = "1"
    cmbToMonth.Text = DateTime.Now.Month

    m_boolLoading = False
    RunSearch()
  End Sub


  Private Sub RunSearch()
    If m_boolLoading Then Return

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

    lblTitle.Text = "Recent Dream Signs"

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

  Public Sub CountDreamTypes()
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
    objDreams.Points.AddY(1000)
    tmrSearching.Enabled = True

    lblTitle.Text = "Dream Types"

    pnlSearching.Visible = True
    graph.Height = Me.Height - graph.Top - 48

    m_arrWords = New List(Of Word)
    m_arrIgnore = New List(Of String)
    m_arrTop100 = New List(Of Word)
    m_arrTop10 = New List(Of Word)

    m_arrDreamFiles = Directory.GetFiles(m_strPath & "Dreams\", "*.ld3", SearchOption.AllDirectories)
    m_arrWords.Clear()

    graph.Series.Clear()
    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Visible = True

    m_intSelectedFile = 0

    tmrDreamTypes.Enabled = True

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

    Dim month As Integer = New FileInfo(m_arrDreamFiles(m_intSelectedFile)).Directory.Name
    Dim year As Integer = New FileInfo(m_arrDreamFiles(m_intSelectedFile)).Directory.Parent.Name

    Dim fromYear As Integer = cmbFromYear.Text
    Dim fromMonth As Integer = cmbFromMonth.Text
    Dim toYear As Integer = cmbToYear.Text
    Dim toMonth As Integer = cmbToMonth.Text

    If (year > fromYear) Or (year = fromYear And month >= fromMonth) Then
      If (year < toYear) Or (year = toYear And month <= toMonth) Then
        Dim xmlDream As New XmlDocument
        xmlDream.Load(m_arrDreamFiles(m_intSelectedFile))
        Dim arrWords() As String = Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText)
        Search(arrWords)
      End If
    End If

    m_intSelectedFile += 1
    tmrDreamSigns.Enabled = True
  End Sub

  Private Sub tmrDreamTypes_Tick(sender As System.Object, e As System.EventArgs) Handles tmrDreamTypes.Tick
    tmrDreamTypes.Enabled = False

    If m_intSelectedFile >= m_arrDreamFiles.Length Then
      tmrDreamTypes.Enabled = False
      pnlSearching.Visible = False
      graph.Height = Me.Height - graph.Top - 8
      tmrSearching.Enabled = False
      Exit Sub
    End If

    Dim xmlDream As New XmlDocument
    xmlDream.Load(m_arrDreamFiles(m_intSelectedFile))

    Dim strDreamType As String = xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText

    Select Case strDreamType
      Case "1" : strDreamType = "Thought"
      Case "2" : strDreamType = "Daydream"
      Case "3" : strDreamType = "Nightmare"
      Case "4" : strDreamType = "Foggy Dream"
      Case "5" : strDreamType = "Normal Dream"
      Case "6" : strDreamType = "Vivid Dream"
      Case "7" : strDreamType = "Lucid Dream"
      Case "8" : strDreamType = "Epic Dream"
      Case "9" : strDreamType = "Wake Induced"
      Case Else : strDreamType = "Unclassified"
    End Select

    Dim boolAlreadyExists As Boolean = False
    For Each objTopWord As Word In m_arrTop100
      If strDreamType.ToLower = objTopWord.Name.ToLower Then
        boolAlreadyExists = True
        objTopWord.Count += 1
        Exit For
      End If
    Next

    If Not boolAlreadyExists Then
      Dim objDreamType As New Word
      objDreamType.Name = strDreamType
      objDreamType.Count = 1
      m_arrTop100.Add(objDreamType)
    End If

    LoadGraph(True)

    m_intSelectedFile += 1
    tmrDreamTypes.Enabled = True
  End Sub

  Private Sub Search(ByVal arrWords() As String)
    If m_boolSearching Then
      Return
    End If

    Dim FoundList As New List(Of String)

    For Each strWord As String In arrWords

      If strWord <> "" Then

        ' Check if the word is in the list
        Dim boolFound As Boolean = False
        For Each objWord As Word In m_arrWords
          If objWord.Name.ToLower = strWord.ToLower Then
            boolFound = True
            If Not FoundList.Contains(strWord.ToLower) Then
              objWord.Count += 1
              FoundList.Add(strWord.ToLower)
            End If
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
            FoundList.Add(strWord.ToLower)
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
      If lblTitle.Text = "Dream Types" Then Exit Sub

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
    If lblTitle.Text = "Dream Types" Then Exit Sub

    tmrDreamSigns.Enabled = False
    pnlSearching.Visible = False
    graph.Height = Me.Height - graph.Top - 8
    tmrSearching.Enabled = False

    Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
    Dim point As DataPoint
    If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
      point = result.Series.Points(result.PointIndex)
      m_strSelectedNewCategory = point.Tag.ToString
      mnuIgnore.Text = "Ignore '" & m_strSelectedNewCategory & "'"
      mnuCategories.Show(graph, e.X, e.Y)
    End If
  End Sub

  Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent CategoryFileCreated(CType(sender, ToolStripMenuItem).Tag, m_strSelectedNewCategory)

    For Each objWord As Word In m_arrTop100
      If objWord.Name = m_strSelectedNewCategory Then
        objWord.Name = ""
      End If
    Next
    m_arrTop10.Clear()
    LoadGraph()
  End Sub

  Private Sub tmrSearching_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSearching.Tick
    objDreams.Points.AddY(Int(Rnd() * 1000))
    objDreams.Points.Remove(objDreams.Points(0))
  End Sub

  Private Sub LoadGraph(Optional ByVal DisplayCount As Boolean = False)
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
          If objWord.Name <> "" Then
            m_arrTop10.Add(objWord)
          End If
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
                If objWord.Name <> "" Then
                  objTopWord.Name = objWord.Name
                  objTopWord.Count = objWord.Count
                  Application.DoEvents()
                  Exit For
                End If
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
      If DisplayCount Then objDreamAnnotation.Text = objDreamAnnotation.Text & " (" & objTopWord.Count & ")"
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

  Private Sub cmbFromYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFromYear.SelectedIndexChanged
    RunSearch()
  End Sub

  Private Sub cmbFromMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFromMonth.SelectedIndexChanged
    RunSearch()
  End Sub

  Private Sub cmbToYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbToYear.SelectedIndexChanged
    RunSearch()
  End Sub

  Private Sub cmbToMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbToMonth.SelectedIndexChanged
    RunSearch()
  End Sub
End Class
