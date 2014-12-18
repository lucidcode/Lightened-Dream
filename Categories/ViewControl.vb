Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ViewControl

  Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"
  Public FileName As String
  Public Event SelectDream(ByVal DreamDate As String, ByVal Title As String)
  Private m_strCategory As String
  Public Changed As Boolean = False
  Public Event RandomWord(ByVal Word As String)

  Public Sub LoadCategory(ByVal strFileName As String, ByVal Category As String)
    Try

      ' Make sure it is not a sub category
      If Not File.Exists(strFileName) Then
        Dim strSubName As String = strFileName.Replace(m_strPath + "Categories\" + Category + "\", "").Replace(".ld3", "")
        For Each strSubFile In Directory.GetFiles(m_strPath + "Categories\" + Category, "*.ld3")
          Dim boolFoundSub As Boolean = False
          Dim xmlDocSibling As New XmlDocument
          xmlDocSibling.Load(strSubFile)
          For Each xmlWord As XmlNode In xmlDocSibling.DocumentElement.SelectNodes("Names/Name")
            If strSubName = xmlWord.InnerText Then
              strFileName = strSubFile
              boolFoundSub = True
              Exit For
            End If
          Next
          If boolFoundSub Then Exit For
        Next
      End If

      Dim xmlDoc As New XmlDocument
      FileName = strFileName
      xmlDoc.Load(FileName)
      m_strCategory = Category
      lblType.Text = m_strCategory
            lblTitle.Text = "Categories - " + Category + " - " + xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText
      txtName.Text = xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText
      txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText
      lblTitle.Tag = xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText
      txtKeywords.Text = ""
      Dim arrKeywords As New List(Of String)

      For Each xmlKeyWord As XmlNode In xmlDoc.DocumentElement.SelectNodes("Names/Name")
        arrKeywords.Add(xmlKeyWord.InnerText)
      Next

      arrKeywords.Sort()

      For Each strKeyword As String In arrKeywords
        txtKeywords.Text += strKeyword + ", "
      Next

      If txtKeywords.Text.Length > 2 Then
        txtKeywords.Text = txtKeywords.Text.Substring(0, txtKeywords.Text.Length - 2)
      End If

      UpdateView()
      Changed = False
    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub lstCategorized_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub tbcMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    UpdateView()
  End Sub

  Private Sub UpdateView()
    Dim xmlDoc As New XmlDocument
    xmlDoc.Load(FileName)

    ' Get Top Month
    Dim intTopMonth As Integer = 0
    If Not xmlDoc.DocumentElement.SelectSingleNode("Dreams") Is Nothing Then
      For Each xmlYear As XmlNode In xmlDoc.DocumentElement.SelectSingleNode("Dreams").ChildNodes
        For Each xmlMonth As XmlNode In xmlYear.ChildNodes
          If xmlMonth.ChildNodes.Count > intTopMonth Then
            intTopMonth = xmlMonth.ChildNodes.Count
          End If
        Next
      Next
    End If

    Dim intPos As Double = 0.5
    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Series.Clear()

    For i As Integer = 1 To intTopMonth
      Dim objSeries As Charting.Series = graph.Series.Add("DreamSeries." & i)
      objSeries.ChartType = SeriesChartType.StackedColumn
      objSeries.Color = Color.FromArgb(200, 65, 140, 240)
    Next

    For Each xmlYear As XmlNode In xmlDoc.DocumentElement.SelectNodes("Dreams/Year")
      For Each xmlMonth As XmlNode In xmlYear.SelectNodes("Month")

        Dim intSeries As Integer = 1
        For Each xmlDream As XmlNode In xmlMonth.SelectNodes("Dream")
          Dim intPoint As Integer = graph.Series("DreamSeries." & intSeries).Points.AddY(1)
          graph.Series("DreamSeries." & intSeries).Points(intPoint).ToolTip = xmlDream.Attributes("Title").InnerText
          graph.Series("DreamSeries." & intSeries).Points(intPoint).Tag = xmlDream.Attributes("Date").InnerText
          intSeries += 1
        Next

        For i As Integer = intSeries To intTopMonth
          graph.Series("DreamSeries." & i).Points.AddY(0)
        Next

        Dim objLabel As Charting.CustomLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, xmlYear.Attributes("Value").InnerText + "-" + xmlMonth.Attributes("Value").InnerText)
        intPos = intPos + 1
      Next
    Next
  End Sub

  Public Sub Save()
    Changed = False
    If txtName.Text <> lblTitle.Tag Then
      Dim newFileName = New FileInfo(FileName).Directory.FullName + "\" + txtName.Text + ".ld3"
      File.Move(FileName, newFileName)
      FileName = newFileName
    End If

    Dim objWorkerClass As New WorkerClass()
    objWorkerClass.Name = txtName.Text
    objWorkerClass.Description = txtDescription.Text
    objWorkerClass.Keywords = txtKeywords.Text
    objWorkerClass.FileName = FileName
    AddHandler objWorkerClass.RandomWord, AddressOf RandomWordLocal

    Dim objProcessingThread As New Threading.Thread(AddressOf objWorkerClass.DoSave)
    objProcessingThread.Start()

    Do
      Threading.Thread.Sleep(1)
      Application.DoEvents()
      If objWorkerClass.Completed Then Exit Do
    Loop

    UpdateView()

  End Sub

  Private Sub RandomWordLocal(ByVal Word As String)
    RaiseEvent RandomWord(Word)
  End Sub

  Private Class WorkerClass

    Public Completed As Boolean
    Public Name As String
    Public Description As String
    Public Keywords As String
    Public FileName As String
    Private m_strPath As String = DataDirectory.GetFolderPath() + "\Lightened Dream\"

    Public Event RandomWord(ByVal Word As String)

    Private Class SafeFilename
      Public Filename As String
      Public Guid As String
    End Class

    Public Sub DoSave()
      Try

        Dim safeFilenames As New List(Of SafeFilename)

        Dim strXml As String
        strXml = "<Category>"

        strXml += "<Name></Name>"
        strXml += "<Description></Description>"
        strXml += "<Names>"

        Dim strNamesXml = ""
        Dim arrKeywords As New List(Of String)
        arrKeywords.Add(Name.ToLower)
        For Each strKeyWord As String In Keywords.Split(", ")
          If strKeyWord <> "" Then
            arrKeywords.Add(strKeyWord.ToLower)
            strXml += "<Name>" + strKeyWord.TrimStart(" ") + "</Name>"
          End If
        Next

        strXml += "</Names>"

        ' Update the list
        ' Load each year
        strXml += "<Dreams>"
        For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
          strXml += "<Year Value='" + New DirectoryInfo(strYearFolder).Name + "'>"
          ' Load each month
          For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
            strXml += "<Month Value='" + New DirectoryInfo(strMonthFolder).Name + "'>"
            ' Load each dream
            For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
              Threading.Thread.Sleep(2)
              Dim xmlDream As New XmlDocument
              xmlDream.Load(strDreamFile)

              For Each strKeyWord As String In arrKeywords
                Dim boolFound As Boolean = False

                If (strKeyWord.Contains(" ")) Then
                  If (xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower.Contains(strKeyWord)) Then
                    boolFound = True
                  End If
                Else
                  For Each strWord As String In Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower)
                    If strWord = strKeyWord Then
                      boolFound = True
                      Exit For
                    End If
                  Next
                End If

                If boolFound Then
                  RaiseEvent RandomWord(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText)

                  Dim safeFilename As New SafeFilename
                  safeFilename.Guid = Guid.NewGuid.ToString
                  safeFilename.Filename = xmlDream.DocumentElement.SelectSingleNode("Title").InnerText

                  safeFilenames.Add(safeFilename)
                  strXml += "<Dream Date='" + xmlDream.DocumentElement.SelectSingleNode("Date").InnerText + "' Title='" + safeFilename.Guid + "' />"

                  Exit For
                End If

              Next

            Next
            strXml += "</Month>"
          Next
          strXml += "</Year>"
        Next
        strXml += "</Dreams>"
        strXml += "</Category>"

        Dim xmlDoc As New XmlDocument
        xmlDoc.LoadXml(strXml)

        xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText = Name
        xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText = Description

        For Each xmlDream As XmlNode In xmlDoc.DocumentElement.SelectNodes("//Dream")
          For Each safeFilename As SafeFilename In safeFilenames
            If safeFilename.Guid = xmlDream.Attributes("Title").InnerText Then
              xmlDream.Attributes("Title").InnerText = safeFilename.Filename
            End If
          Next
        Next

        xmlDoc.Save(FileName)
        Completed = True

      Catch ex As Exception
        Completed = True
        MessageBox.Show(ex.Message + "/r/n" + "Stack trace: " + ex.StackTrace, "LightenedDream.Categories.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

    End Sub

  End Class

  Private Sub lstDreams_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDreams.DoubleClick
    If lstDreams.SelectedItems.Count = 0 Then Return
    RaiseEvent SelectDream(lstDreams.SelectedItems(0).Text, lstDreams.SelectedItems(0).SubItems(1).Text)
  End Sub

  Private Sub graph_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
      Dim point As DataPoint
      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("DreamSeries") Then
          ' Set cursor type 
          Me.Cursor = Cursors.Hand

          ' Find selected data point
          point = result.Series.Points(result.PointIndex)
          RaiseEvent SelectDream(point.Tag, point.ToolTip)
        End If
      End If
    End If
  End Sub

  Private Sub graph_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Try
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

      ' Reset Data Point Attributes
      Dim point As DataPoint
      For Each objSeries In graph.Series
        If objSeries.Name.StartsWith("DreamSeries") Then
          For Each point In objSeries.Points
            point.Color = Color.FromArgb(200, 65, 140, 240)
          Next point
        End If
      Next

      If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
        If result.Series.Name.StartsWith("DreamSeries") Then

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
        ' Set default cursor
        Me.Cursor = Cursors.Default
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        lblTitle.Text = "Categories - " + m_strCategory + " - " + txtName.Text
    Changed = True
  End Sub

  Private Sub txtKeywords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeywords.TextChanged
    Changed = True
  End Sub

  Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
    Changed = True
  End Sub
End Class
