Imports System.Xml
Imports System.IO
Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class REMCyclesControl

    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Public FileName As String
    Private m_dtStartTime As DateTime
    Private m_intLastMinute As Integer = -1
    Private m_objNow As System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation = New System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation

    Public Changed As Boolean = False
    Private m_formSpeedReading As SpeedReadingForm
    Private m_objSpeechSynthesizer As New System.Speech.Synthesis.SpeechSynthesizer()

    Private Sub REMCyclesControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Public Function CreateNew() As String
        Try

            Dim strTitle As String = "New REM Cycle"
            Dim strFileName As String
            strFileName = m_strPath + "\Lucidity\REM Cycles\" + strTitle + ".ld3"

            Dim intPos As Integer = 2
            Do
                If (File.Exists(strFileName)) Then
                    strTitle = "New " + "REM Cycle" + " " + intPos.ToString
                    strFileName = m_strPath + "\Lucidity\REM Cycles\" + strTitle + ".ld3"
                    intPos += 1
                Else
                    Exit Do
                End If
            Loop

            Dim strXml As String
            strXml = "<REM>"
            strXml += "<Title>" + strTitle + "</Title>"
            strXml += "<Description></Description>"
            strXml += "<Cycles>6</Cycles>"
            strXml += "<CyclesLength>90</CyclesLength>"
            strXml += "</REM>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(strFileName)

            Return strFileName

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Create()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub Save()
        Try

            Dim strFileName As String
            strFileName = m_strPath + "Lucidity\REM Cycles\" + txtTitle.Text + ".ld3"
            If (FileName <> strFileName) Then
                File.Move(FileName, strFileName)
                FileName = strFileName
            End If

            lblTitle.Text = "Lucidity - REM Cycles - " + txtTitle.Text

            Dim textWriter As XmlWriter = New XmlTextWriter(strFileName & ".tmp", Nothing)
            textWriter.WriteStartElement("REM")

            textWriter.WriteStartElement("Title")
            textWriter.WriteString(txtTitle.Text)
            textWriter.WriteEndElement()

            textWriter.WriteStartElement("Description")
            textWriter.WriteString(txtDescription.Text)
            textWriter.WriteEndElement()

            textWriter.WriteStartElement("Cycles")
            textWriter.WriteString(cmbCycles.Text)
            textWriter.WriteEndElement()

            textWriter.WriteStartElement("CyclesLength")
            textWriter.WriteString(cmbCycleLength.Text)
            textWriter.WriteEndElement()

            textWriter.WriteStartElement("Items")
            For Each objAnnotation As Annotation In graph.Annotations
                If TypeOf objAnnotation Is CalloutAnnotation Then
                    textWriter.WriteStartElement("Item")
                    textWriter.WriteAttributeString("Position", objAnnotation.AnchorDataPoint.ToolTip)

                    If objAnnotation.Tag.ToString.StartsWith("MP3::") Then

                        textWriter.WriteAttributeString("Name", New FileInfo(objAnnotation.Tag.ToString.Replace("MP3::", "")).Name)
                        textWriter.WriteAttributeString("Path", objAnnotation.Tag.ToString.Replace("MP3::", ""))

                    ElseIf objAnnotation.Tag.ToString.StartsWith("MEM::MP3::") Then
                        ' Read the item from the loaded xml doc
                        Dim reader As XmlReader = XmlReader.Create(strFileName)
                        Dim boolFound As Boolean
                        Do

                            boolFound = reader.ReadToFollowing("Item")
                            If boolFound Then

                                If objAnnotation.Tag.ToString.Replace("MEM::MP3::", "") = reader.GetAttribute("Name") Then
                                    reader.Read()
                                    If reader.Name() = "" Then
                                        reader.Read()
                                    End If
                                    Exit Do
                                End If

                            Else
                                Exit Do
                            End If
                        Loop
                        textWriter.WriteAttributeString("Name", objAnnotation.Tag.ToString.Replace("MEM::MP3::", ""))

                        ' Insert loaded xml doc item into REM
                        textWriter.WriteNode(reader, True)
                        textWriter.Flush()
                        reader.Close()

                    ElseIf objAnnotation.Tag.ToString.StartsWith("MEM::") Then
                        ' Read the item from the loaded xml doc
                        Dim reader As XmlReader = XmlReader.Create(strFileName)
                        Dim boolFound As Boolean
                        Do

                            boolFound = reader.ReadToFollowing("Item")
                            If boolFound Then

                                'reader.ReadString()
                                If objAnnotation.Tag.ToString.Replace("MEM::", "") = reader.GetAttribute("Name") Then
                                    reader.Read()
                                    If reader.Name() = "" Then
                                        reader.Read()
                                    End If
                                    'reader.ReadToDescendant()
                                    Exit Do
                                End If

                            Else
                                Exit Do
                            End If
                        Loop
                        'boolFound = reader.ReadToFollowing("@Name='" + objAnnotation.Tag.ToString.Replace("MEM::", "") + "'")

                        textWriter.WriteAttributeString("Name", objAnnotation.Tag.ToString.Replace("MEM::", ""))

                        ' Insert loaded xml doc item into REM
                        textWriter.WriteNode(reader, True)
                        textWriter.Flush()
                        reader.Close()
                    Else
                        If objAnnotation.Tag.ToString.EndsWith(".ld3") Then
                            ' Read the original lucidity item
                            Dim reader As XmlReader = XmlReader.Create(objAnnotation.Tag)
                            reader.Read()

                            textWriter.WriteAttributeString("Name", New FileInfo(objAnnotation.Tag).Name.Replace(".ld3", ""))

                            ' Insert the original lucidity item into REM
                            textWriter.WriteNode(reader, True)
                            textWriter.Flush()
                            reader.Close()
                        Else
                            ' Read the sound file

                            ' Insert the sound file into REM
                        End If
                    End If
                    textWriter.WriteEndElement()
                End If
            Next

            textWriter.WriteEndElement()
            textWriter.WriteEndElement()
            textWriter.Close()

            File.Delete(strFileName)
            File.Move(strFileName & ".tmp", strFileName)

            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadREM(ByVal strFileName As String)
        Try
            If FileName = strFileName Then Return ' Don't reload if it is the same file.

            Changed = False
            tmrWatch.Enabled = False

            FileName = strFileName
            Dim reader As XmlReader = XmlReader.Create(FileName)
            reader.Read()

            Dim boolFound As Boolean

            boolFound = reader.ReadToFollowing("Title")
            If boolFound Then
                If reader.Name <> "Title" Then reader.Read()
                If reader.Value = "" Then reader.Read()
                lblTitle.Text = "Lucidity - REM Cycles - " + reader.Value
                txtTitle.Text = reader.Value
            End If

            boolFound = reader.ReadToFollowing("Description")
            If boolFound Then
                If reader.Name <> "Description" Then reader.Read()
                If reader.Value = "" Then reader.Read()
                txtDescription.Text = reader.Value
            End If

            ' Reset to be safe of empty description node
            reader = XmlReader.Create(FileName)
            reader.Read()

            boolFound = reader.ReadToFollowing("Cycles")
            If boolFound Then
                If reader.Name <> "Cycles" Then reader.Read()
                If reader.Value = "" Then reader.Read()
                cmbCycles.Text = reader.Value
            End If

            boolFound = reader.ReadToFollowing("CyclesLength")
            If boolFound Then
                If reader.Name <> "CyclesLength" Then reader.Read()
                If reader.Value = "" Then reader.Read()
                cmbCycleLength.Text = reader.Value
            End If

            DrawGraph()


            Me.graph.Annotations.Clear()
            Dim intCount As Integer = 1
            m_objNow.LineColor = System.Drawing.Color.SteelBlue
            m_objNow.BackColor = Color.Green
            m_objNow.LineWidth = 4
            m_objNow.StartCap = LineAnchorCapStyle.Arrow
            m_objNow.EndCap = LineAnchorCapStyle.Arrow
            m_objNow.Name = Guid.NewGuid.ToString
            m_objNow.Visible = True
            m_objNow.IsInfinitive = True
            m_objNow.SetAnchor(graph.Series("REM").Points(0), graph.Series("REM").Points(0))
            Me.graph.Annotations.Add(m_objNow)

            m_intPoint = 0

            lstItems.Items.Clear()
            Do

                boolFound = reader.ReadToFollowing("Item")
                If boolFound Then

                    Dim objCalloutCloud As New Charting.CalloutAnnotation
                    objCalloutCloud.AllowSelecting = True
                    objCalloutCloud.AllowAnchorMoving = True
                    objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
                    objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
                    objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
                    objCalloutCloud.Name = Guid.NewGuid.ToString
                    objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
                    objCalloutCloud.ShadowOffset = 1
                    objCalloutCloud.SmartLabelStyle.Enabled = True
                    objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
                    objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
                    objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes

                    Dim strPosition As String = ""
                    Dim strName As String = ""
                    Dim strFirstChildName As String = ""

                    boolFound = reader.MoveToAttribute("Position")
                    If boolFound Then
                        strPosition = reader.Value
                    End If

                    boolFound = reader.MoveToAttribute("Name")
                    If boolFound Then
                        strName = reader.Value
                    End If

                    objCalloutCloud.Text = strName & " (" + strPosition + ")"
                    objCalloutCloud.ToolTip = objCalloutCloud.Text

                    boolFound = reader.MoveToAttribute("Path")
                    If boolFound Then
                        strName = reader.Value
                        objCalloutCloud.Tag = "MP3::" & strName
                    Else
                        reader.Read()
                        reader.Read()
                        strFirstChildName = reader.Name
                        If strFirstChildName = "FILE" Then
                            objCalloutCloud.Tag = "MEM::MP3::" & strName
                        Else ' Recording
                            objCalloutCloud.Tag = "MEM::" & strName
                        End If
                    End If
                    For Each point As DataPoint In graph.Series("REM").Points
                        If point.ToolTip = strPosition Then
                            objCalloutCloud.AnchorDataPoint = point
                            objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter
                        End If
                    Next point
                    Me.graph.Annotations.Add(objCalloutCloud)
                    intCount += 1

                    Dim lstItem As New ListViewItem(strPosition)
                    lstItem.SubItems.Add(strName)
                    lstItem.SubItems.Add(strName)
                    lstItem.Tag = strName
                    lstItems.Items.Add(lstItem)

                Else
                    Exit Do
                End If

            Loop

            Return

            Dim xmlDoc As New XmlDocument
            xmlDoc.Load(FileName)
            lblTitle.Text = "Lucidity - REM Cycles - " + xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
            txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText
            txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText
            cmbCycles.Text = xmlDoc.DocumentElement.SelectSingleNode("Cycles").InnerText
            If Not xmlDoc.DocumentElement.SelectSingleNode("CyclesLength") Is Nothing Then
                cmbCycleLength.Text = xmlDoc.DocumentElement.SelectSingleNode("CyclesLength").InnerText
            Else
                cmbCycleLength.Text = "90"
            End If


            For Each xmlItem As XmlNode In xmlDoc.DocumentElement.SelectNodes("Items/Item")

                Dim objCalloutCloud As New Charting.CalloutAnnotation
                objCalloutCloud.AllowSelecting = True
                objCalloutCloud.AllowAnchorMoving = True
                objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
                objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
                objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
                objCalloutCloud.Name = Guid.NewGuid.ToString
                objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
                objCalloutCloud.ShadowOffset = 1
                objCalloutCloud.SmartLabelStyle.Enabled = True
                objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
                objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
                objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                objCalloutCloud.Text = xmlItem.Attributes("Name").InnerText & " (" + xmlItem.Attributes("Position").InnerText + ")"

                If Not xmlItem.Attributes("Path") Is Nothing Then
                    objCalloutCloud.Tag = "MP3::" & xmlItem.Attributes("Path").InnerText
                Else
                    If xmlItem.FirstChild.Name = "FILE" Then
                        objCalloutCloud.Tag = "MEM::MP3::" & xmlItem.Attributes("Name").InnerText
                    Else ' Recording
                        objCalloutCloud.Tag = "MEM::" & xmlItem.Attributes("Name").InnerText
                    End If
                End If

                For Each point As DataPoint In graph.Series("REM").Points
                    If point.ToolTip = xmlItem.Attributes("Position").InnerText Then
                        objCalloutCloud.AnchorDataPoint = point
                        objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter
                    End If
                Next point

                Me.graph.Annotations.Add(objCalloutCloud)
                intCount += 1

                Dim lstItem As New ListViewItem(xmlItem.Attributes("Position").InnerText)
                lstItem.SubItems.Add(xmlItem.Attributes("Name").InnerText)
                lstItem.SubItems.Add(xmlItem.Attributes("Name").InnerText)
                lstItem.Tag = xmlItem.Attributes("Name").InnerText
                lstItems.Items.Add(lstItem)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Play()
        m_intLastMinute = -1
        m_dtStartTime = Now.AddSeconds(1)
        m_objNow.SetAnchor(graph.Series("REM").Points(0), graph.Series("REM").Points(0))
        tmrWatch.Enabled = True
    End Sub

    Public Sub StopRunning()
        m_intLastMinute = -1
        m_dtStartTime = Now.AddSeconds(1)
        m_objNow.SetAnchor(graph.Series("REM").Points(0), graph.Series("REM").Points(0))
        tmrWatch.Enabled = False
        objPlayer.close()
    End Sub

    Private Sub Execute(ByVal Item As String)
        Try

            objPlayer.close()

            ' Delete old temp files
            Try
                For Each strFile As String In Directory.GetFiles(m_strPath + "\Lucidity\REM Cycles\Temp", "*.*")
                    File.Delete(strFile)
                Next
            Catch ex As Exception
            End Try

            If Item.StartsWith("Reading") Then

            ElseIf Item.StartsWith("MP3::") Then
                objPlayer.close()
                Application.DoEvents()
                Me.objPlayer.settings.volume = 100
                objPlayer.URL = Item.Replace("MP3::", "")
            ElseIf Item.StartsWith("MEM::MP3::") Then

                Dim reader As XmlReader = XmlReader.Create(FileName)
                Dim boolFound As Boolean
                Do

                    boolFound = reader.ReadToFollowing("Item")
                    If boolFound Then
                        If Item.ToString.Replace("MEM::MP3::", "") = reader.GetAttribute("Name") Then
                            reader.Read()
                            Dim strType As String = reader.Name()
                            If strType = "" Then
                                reader.Read()
                                strType = reader.Name()
                            End If
                            ' Recording
                            If strType = "FILE" Then
                                objPlayer.close()
                                Application.DoEvents()
                                Me.objPlayer.settings.volume = 100
                                Dim fs As New FileStream(m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::MP3::", ""), FileMode.Create)

                                Dim buf(1023) As Byte
                                Dim numRead As Integer = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                While (numRead > 0)
                                    fs.Write(buf, 0, numRead)
                                    numRead = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                End While

                                fs.Close()
                                reader.Close()

                                objPlayer.URL = m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::MP3::", "")
                                Return
                            End If
                        End If

                    Else
                        Exit Do
                    End If
                Loop
                reader.Close()
            ElseIf Item.StartsWith("MEM::") Then
                Dim reader As XmlReader = XmlReader.Create(FileName)
                Dim boolFound As Boolean
                Do
                    boolFound = reader.ReadToFollowing("Item")
                    If boolFound Then
                        If Item.ToString.Replace("MEM::", "") = reader.GetAttribute("Name") Then
                            reader.Read()
                            Dim strType As String = reader.Name()
                            If strType = "" Then
                                reader.Read()
                                strType = reader.Name()
                            End If
                            ' Recording

                            If strType = "FILE" Then

                                objPlayer.close()
                                Application.DoEvents()
                                Me.objPlayer.settings.volume = 100
                                Dim fs As New FileStream(m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::", ""), FileMode.Create)

                                Dim buf(1023) As Byte
                                Dim numRead As Integer = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                While (numRead > 0)
                                    fs.Write(buf, 0, numRead)
                                    numRead = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                End While

                                fs.Close()
                                reader.Close()
                                objPlayer.URL = m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::", "")
                                Return
                            ElseIf strType = "Recording" Then
                                If reader.ReadToFollowing("Data") Then

                                    objPlayer.close()
                                    Application.DoEvents()
                                    Me.objPlayer.settings.volume = 100
                                    Dim fs As New FileStream(m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::", "") & ".mp3", FileMode.Create)
                                    Dim buf(1023) As Byte
                                    Dim numRead As Integer = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                    While (numRead > 0)
                                        fs.Write(buf, 0, numRead)
                                        numRead = reader.ReadElementContentAsBase64(buf, 0, 1024)
                                    End While

                                    fs.Close()

                                    objPlayer.URL = m_strPath + "\Lucidity\REM Cycles\Temp\" + Item.ToString.Replace("MEM::", "") & ".mp3"

                                    ' Speak
                                    If reader.ReadToFollowing("Speech") Then
                                        reader.Read()
                                        m_objSpeechSynthesizer.SpeakAsyncCancelAll()
                                        m_objSpeechSynthesizer.SpeakAsync(reader.Value)
                                    End If

                                    reader.Close()

                                    Return
                                End If

                                ' Reading
                            ElseIf strType = "Reading" Then

                                If Not m_formSpeedReading Is Nothing Then
                                    m_formSpeedReading.Close()
                                End If

                                m_formSpeedReading = New SpeedReadingForm(GetReaderValue(reader, "Interval"))
                                m_formSpeedReading.BackColor = Color.FromArgb(GetReaderValue(reader, "Background"))
                                m_formSpeedReading.lblText.ForeColor = Color.FromArgb(GetReaderValue(reader, "Text"))
                                m_formSpeedReading.lblText.Font = New Font(m_formSpeedReading.lblText.Font.FontFamily, Convert.ToInt32(GetReaderValue(reader, "Size")), FontStyle.Regular)

                                Dim strMessages As String = ""

                                Do While reader.ReadToFollowing("Message")
                                    reader.Read()
                                    strMessages += reader.Value & vbNewLine
                                Loop

                                If strMessages.Length > 0 Then
                                    strMessages = strMessages.Substring(0, strMessages.Length - 1)
                                End If

                                m_formSpeedReading.Messages = strMessages.Split(vbNewLine)
                                m_formSpeedReading.Show()
                                m_formSpeedReading.BringToFront()
                                m_formSpeedReading.Top = 0
                                m_formSpeedReading.Left = 0
                                m_formSpeedReading.PlayLoop = False
                                m_formSpeedReading.Play()
                                reader.Close()
                                Return


                                ' Subliminal
                            ElseIf strType = "Subliminal" Then


                            End If
                        End If

                    Else
                        Exit Do
                    End If
                Loop


                reader.Close()

            Else
                Dim reader As XmlReader = XmlReader.Create(Item)
                If reader.ReadToFollowing("Data") Then

                    objPlayer.close()
                    Application.DoEvents()
                    Me.objPlayer.settings.volume = 100
                    Dim fs As New FileStream(m_strPath + "\Lucidity\REM Cycles\Temp\" + New FileInfo(Item).Name.Replace(".ld3", ".mp3"), FileMode.Create)

                    Dim buf(1023) As Byte
                    Dim numRead As Integer = reader.ReadElementContentAsBase64(buf, 0, 1024)
                    While (numRead > 0)
                        fs.Write(buf, 0, numRead)
                        numRead = reader.ReadElementContentAsBase64(buf, 0, 1024)
                    End While

                    fs.Close()

                    objPlayer.URL = m_strPath + "\Lucidity\REM Cycles\Temp\" + New FileInfo(Item).Name.Replace(".ld3", ".mp3")

                    ' Speak
                    If reader.ReadToFollowing("Speech") Then
                        reader.Read()
                        m_objSpeechSynthesizer.SpeakAsyncCancelAll()
                        m_objSpeechSynthesizer.SpeakAsync(reader.Value)
                    End If


                    reader.Close()

                    Return

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Execute()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Function GetReaderValue(ByVal Reader As XmlReader, ByVal Node As String) As String
    Reader.ReadToFollowing(Node)
    Reader.Read()
    Return Reader.Value
  End Function

  Private Function GetHour(ByVal StartTime As String) As Int32
    Return Split(StartTime, ":")(0)
  End Function

  Private Function GetMinute(ByVal StartTime As String) As Int32
    Return Split(StartTime, ":")(1)
  End Function

  Private Sub dtStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '   Dim x As Microsoft.Visua

  End Sub

  Private m_boolUp As Boolean = False

  Private Sub DrawGraph()
    Try
      Dim intPos As Double = 0.5
      graph.ChartAreas(0).AxisX.CustomLabels.Clear()
      graph.Series.Clear()

      Dim intCycles As Integer = 6
      Dim intLength As Integer = 6

      Try
        If cmbCycles.Text <> "" Then
          intCycles = Convert.ToInt32(cmbCycles.Text)
        End If
      Catch ex As Exception
      End Try
      Try
        If cmbCycles.Text <> "" Then
          intLength = Convert.ToInt32(cmbCycleLength.Text)
        End If
      Catch ex As Exception
      End Try

      Dim objLabel As Charting.CustomLabel
      Dim dtTime As DateTime = DateTime.Now

      Dim objSeriesView As Series = graph.Series.Add("View")
      objSeriesView.ChartType = SeriesChartType.SplineArea

      Dim objSeries As Series = graph.Series.Add("REM")
      objSeries.ChartType = SeriesChartType.Column  'SeriesChartType.Column 

      objSeries.Color = Color.FromArgb(0, 65, 140, 240)
      objSeries("BarLabelStyle") = "Center"
      objSeriesView.Color = Color.FromArgb(200, 65, 140, 240)
      objSeriesView.BorderWidth = 2
      objSeriesView.Points.AddXY(1, intLength - (intLength / 3))

      Dim x As Integer = 2
      For iCycle As Integer = 0 To intCycles - 1
        If m_boolUp Then
          m_boolUp = False
        Else
          m_boolUp = True
        End If

        objSeriesView.Points.AddXY(x, intLength - (intLength / 3))

        Dim boolDirChanged As Boolean = False
        Dim boolDirDrawn As Boolean = False

        For iMinute As Integer = 1 To intLength + 1

          If iMinute <= intLength / 2 Then
            x = objSeries.Points.AddY(intLength - iMinute + 1 - (intLength / 3))
          Else
            boolDirChanged = True
            x = objSeries.Points.AddY(iMinute - (intLength / 3))
          End If

          If boolDirChanged Then
            If Not boolDirDrawn Then
              boolDirDrawn = True
              objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos - 5, intPos + 5, Format(dtTime, "HH:mm"))
              objSeriesView.Points.AddXY(x, intLength / 2 - (intLength / 3))
            End If
          End If


          objSeries.Points(objSeries.Points.Count - 1).ToolTip = objSeries.Points.Count - 1
          intPos += 1
          dtTime = dtTime.AddMinutes(1)
        Next

        objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos - 5, intPos + 5, Format(dtTime, "HH:mm"))
      Next


      'For intCycle As Integer = 1 To intCycles

      '  For intSubCycle As Integer = 1 To 30

      '  Next

      '  intPoint = objSeries.Points.AddY(4)
      '  intPos = intPos + 1
      '  intPoint = objSeries.Points.AddY(2)
      '  intPos = intPos + 1
      '  intPoint = objSeries.Points.AddY(6)
      '  intPos = intPos + 1
      '  intPoint = objSeries.Points.AddY(4)
      '  intPos = intPos + 1

      '  dtTime = dtTime.AddMinutes(90)

      '  intPoint = objSeries.Points.AddY(10 + intCycle)
      '  objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))
      '  intPos = intPos + 1
      'Next

      'Dim intREMLength As Integer = cmbCycleLength.Text
      'For intCycle As Integer = 1 To intCycles

      '  For intSubCycle As Integer = 1 To intREMLength
      '    dtTime = dtTime.AddMinutes(1)
      '    intPoint = objSeries.Points.AddY(12)
      '    objSeries.Points(intPoint).Tag = dtTime.ToString()
      '    objSeries.Points(intPoint).Color = Color.FromArgb(0, 0, 0, 32)
      '    intPos = intPos + 1
      '  Next
      '  'intPoint = objSeries.Points.AddY(10)

      'Next


      'For intCycle As Integer = 1 To intCycles

      '  For intSubCycle As Integer = 1 To 30
      '    intPoint = objSeries.Points.AddY(4)
      '    intPos = intPos + 1
      '    dtTime = dtTime.AddMinutes(1)
      '  Next
      '  'objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))

      '  For intSubCycle As Integer = 1 To 30
      '    intPoint = objSeries.Points.AddY(2)
      '    intPos = intPos + 1
      '    dtTime = dtTime.AddMinutes(1)
      '  Next
      '  'objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))

      '  For intSubCycle As Integer = 1 To 30
      '    intPoint = objSeries.Points.AddY(6)
      '    intPos = intPos + 1
      '    dtTime = dtTime.AddMinutes(1)
      '  Next

      '  intPoint = objSeries.Points.AddY(10 + intCycle)
      '  objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))
      '  intPos = intPos + 1
      'Next

      'LoadREM(FileName)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub tmrWatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWatch.Tick
    Dim dtTime As TimeSpan = DateTime.Now.Subtract(m_dtStartTime)
    Dim intCurrentMinute As Integer = dtTime.TotalMinutes - 0.5
    txtTime.Text = Format(dtTime.Hours, "00") & ":" & Format(dtTime.Minutes, "00") & ":" & Format(dtTime.Seconds, "00")

    If m_intLastMinute <> Convert.ToInt32(intCurrentMinute) Then
      m_intLastMinute = intCurrentMinute
      If graph.Series("REM").Points.Count - 1 >= intCurrentMinute Then
        m_objNow.SetAnchor(graph.Series("REM").Points(intCurrentMinute), graph.Series("REM").Points(intCurrentMinute))
        For Each objAnnotation As Annotation In graph.Annotations
          If TypeOf (objAnnotation) Is CalloutAnnotation Then
            If objAnnotation.AnchorDataPoint Is graph.Series("REM").Points(intCurrentMinute) Then
              objAnnotation.BackColor = Color.LightSteelBlue
              objAnnotation.ForeColor = Color.White
              Application.DoEvents()
              Execute(objAnnotation.Tag)
              objAnnotation.BackColor = Color.SteelBlue
              objAnnotation.ForeColor = Color.White
            End If
          End If
        Next
      Else
        tmrWatch.Enabled = False
        Return
      End If
      'graph.Series("REM").Points(dtTime.TotalMinutes - 1).Color = Color.FromArgb(0, 0, 0, 0)
      'graph.Series("REM").Points(intCurrentMinute).Color = Color.SteelBlue

    End If

  End Sub

  Private Sub graph_AnnotationPlaced(ByVal sender As Object, ByVal e As System.EventArgs) Handles graph.AnnotationPlaced
  End Sub

  Private Function FindNearestDataPoint(ByVal X As Double, ByVal Y As Double) As PointF
    ' get the int portion of the X value
    Dim curIndex As Integer = CInt(Math.Round(X))

    ' if curIndex is less than 1 curIndex is set to 1
    curIndex = CInt(Math.Max(curIndex, 1))

    ' if curIndex is greater than 11 curIndex is set to 11 (X Value of max point in series)
    curIndex = CInt(Math.Min(curIndex, graph.Series("REM").Points.Count - 5))

    ' return the point value of the nearest point
    Return New PointF(curIndex, CSng(graph.Series("REM").Points(curIndex - 1).YValues(0)))
  End Function


  Private m_objSelectedAnnotation As Annotation

  Private Sub graph_AnnotationPositionChanging(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs) Handles graph.AnnotationPositionChanging
    m_objSelectedAnnotation = e.Annotation
    Return
  End Sub

  Private Sub graph_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Right Then
      m_ptPaste = New Point(e.X, e.Y)
      Dim result As HitTestResult = graph.HitTest(e.X, e.Y)
      If result.ChartElementType = ChartElementType.Annotation Then
        If TypeOf result.Object Is CalloutAnnotation Then
          m_objClickedAnnotation = result.Object
          mnuAnnotationPlay.Enabled = True
          mnuAnnotationCopy.Enabled = True
          mnuAnnotationDelete.Enabled = True
          If m_objCopiedAnnotation Is Nothing Then
            mnuAnnotationPaste.Enabled = False
          Else
            mnuAnnotationPaste.Enabled = True
          End If
          mnuAnnotation.Show(graph, e.X, e.Y)
        End If
      Else
        mnuAnnotationPlay.Enabled = False
        mnuAnnotationCopy.Enabled = False
        mnuAnnotationDelete.Enabled = False
        If m_objCopiedAnnotation Is Nothing Then
          mnuAnnotationPaste.Enabled = False
        Else
          mnuAnnotationPaste.Enabled = True
        End If
        mnuAnnotation.Show(graph, e.X, e.Y)
      End If
    End If
  End Sub

  Private m_ptPaste As Point

  Private m_objCopiedAnnotation As Charting.CalloutAnnotation
  Private m_objClickedAnnotation As Charting.CalloutAnnotation

  Private Sub mnuAnnotationCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnotationCopy.Click
    mnuAnnotationPaste.Enabled = True
    m_objCopiedAnnotation = m_objClickedAnnotation
  End Sub

  Private Sub mnuAnnotationPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnotationPaste.Click
    PasteAnnotation()
  End Sub

  Private Sub PasteAnnotation()
    If Not m_objCopiedAnnotation Is Nothing Then
      Dim objCalloutCloud As New Charting.CalloutAnnotation
      'objCalloutCloud.ClipToChartArea = "ChartArea1"
      objCalloutCloud.AllowAnchorMoving = True
      objCalloutCloud.AllowSelecting = True
      objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
      objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
      objCalloutCloud.Name = Guid.NewGuid.ToString
      objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.ShadowOffset = 1
      objCalloutCloud.Text = m_objCopiedAnnotation.Text
      objCalloutCloud.Tag = m_objCopiedAnnotation.Tag
      objCalloutCloud.AnchorDataPoint = m_objCopiedAnnotation.AnchorDataPoint
      objCalloutCloud.SmartLabelStyle.Enabled = True
      objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
      objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
      objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
      Me.graph.Annotations.Add(objCalloutCloud)
      Changed = True
    End If
  End Sub

  Private Sub cmbCycles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCycles.SelectedIndexChanged
    DrawGraph()
  End Sub

  Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCycleLength.SelectedIndexChanged
    DrawGraph()
  End Sub

  Private m_intLastX As Integer
  Private m_intLastY As Integer
  Private m_intLastTag As DateTime

  Dim m_intPoint As Integer = 0
  Private Sub graph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles graph.MouseMove
    Dim result As HitTestResult = graph.HitTest(e.X, e.Y)

    If m_objSelectedAnnotation Is Nothing Then
      Return
    End If

    If m_intPoint > -1 Then
      'graph.Series("REM").Points(m_intPoint).Color = Color.FromArgb(200, 65, 140, 240) ' Color.LightSteelBlue
    End If

    m_intPoint = 0
    If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.DataPointLabel Or result.ChartElementType = ChartElementType.LegendItem Then
      If result.Series.Name.StartsWith("REM") Then
        m_intPoint = result.PointIndex
        'result.Series.Points(result.PointIndex).Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue
        If TypeOf (m_objSelectedAnnotation) Is CalloutAnnotation Then

          If m_objSelectedAnnotation.Tag.ToString.StartsWith("MP3::") Then
            CType(m_objSelectedAnnotation, CalloutAnnotation).Text = New FileInfo(m_objSelectedAnnotation.Tag.ToString.Replace("MP3::", "")).Name & " (" & m_intPoint & ")"
          ElseIf m_objSelectedAnnotation.Tag.ToString.StartsWith("MEM::") Then
            CType(m_objSelectedAnnotation, CalloutAnnotation).Text = m_objSelectedAnnotation.Tag.ToString.Replace("MEM::", "") & " (" & m_intPoint & ")"
          Else
            CType(m_objSelectedAnnotation, CalloutAnnotation).Text = New FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") & " (" & m_intPoint & ")"
          End If
        End If
      End If
    Else
      If TypeOf (m_objSelectedAnnotation) Is CalloutAnnotation Then

        If m_objSelectedAnnotation.Tag.ToString.StartsWith("MP3::") Then
          CType(m_objSelectedAnnotation, CalloutAnnotation).Text = New FileInfo(m_objSelectedAnnotation.Tag.ToString.Replace("MP3::", "")).Name & " (" & 0 & ")"
        ElseIf m_objSelectedAnnotation.Tag.ToString.StartsWith("MEM::") Then
          CType(m_objSelectedAnnotation, CalloutAnnotation).Text = m_objSelectedAnnotation.Tag.ToString.Replace("MEM::", "") & " (" & 0 & ")"
        Else
          CType(m_objSelectedAnnotation, CalloutAnnotation).Text = New FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") & " (" & 0 & ")"
        End If
      End If
    End If

    Return
  End Sub

  Private Sub graph_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles graph.DragDrop

  End Sub

  Private Sub graph_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles graph.DragEnter
    If e.Data.GetDataPresent("System.Windows.Forms.TreeNode()") Then
      e.Effect = DragDropEffects.Link
    Else
      e.Effect = DragDropEffects.None
    End If
  End Sub

  Private Sub graph_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles graph.DragOver
    If e.Data.GetDataPresent("System.Windows.Forms.TreeNode()") Then
      e.Effect = DragDropEffects.Link
    Else
      e.Effect = DragDropEffects.None
    End If
  End Sub

  Private Sub graph_AnnotationPositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles graph.AnnotationPositionChanged
    If Not m_objSelectedAnnotation Is Nothing Then
      Dim objCalloutCloud As New Charting.CalloutAnnotation
      objCalloutCloud.AllowSelecting = True
      objCalloutCloud.AllowAnchorMoving = True
      objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
      objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
      objCalloutCloud.Name = Guid.NewGuid.ToString
      objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.ShadowOffset = 1
      objCalloutCloud.Tag = m_objSelectedAnnotation.Tag
      objCalloutCloud.IsSizeAlwaysRelative = False
      objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter
      objCalloutCloud.SmartLabelStyle.Enabled = True
      objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
      objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
      objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
      Changed = True
      If m_objSelectedAnnotation.Tag.ToString.StartsWith("MP3::") Then
        objCalloutCloud.Text = New FileInfo(m_objSelectedAnnotation.Tag.ToString.Replace("MP3::", "")).Name & " (" & m_intPoint & ")"
      ElseIf m_objSelectedAnnotation.Tag.ToString.StartsWith("MEM::") Then
        objCalloutCloud.Text = m_objSelectedAnnotation.Tag.ToString.Replace("MEM::", "") & " (" & m_intPoint & ")"
      Else
        objCalloutCloud.Text = New FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") & " (" & m_intPoint & ")"
      End If
      objCalloutCloud.AnchorDataPoint = graph.Series("REM").Points(m_intPoint)
      graph.Annotations.Remove(m_objSelectedAnnotation)
      Me.graph.Annotations.Add(objCalloutCloud)
      m_objSelectedAnnotation = Nothing
      Return
    End If

    m_objSelectedAnnotation = Nothing
  End Sub

  Private Sub mnuAnnotationDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnotationDelete.Click
    DeleteAnnotation()
  End Sub

  Private Sub graph_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles graph.KeyDown
    If e.Control Then
      If e.KeyCode = Keys.V Then
        PasteAnnotation()
      End If
    End If
  End Sub

  Private Sub DeleteAnnotation()
    For Each objAnnotation As Annotation In graph.Annotations
      If objAnnotation.IsSelected Then
        graph.Annotations.Remove(objAnnotation)
        Changed = True
        Exit For
      End If
    Next
  End Sub

  Private Sub mnuAnnotationAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnotationAdd.Click

  End Sub

  Private Sub mnuLuciditySubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim objMenu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
    AddFile(objMenu.Tag, objMenu.Text)
  End Sub

  Private Sub AddFile(ByVal Lucidity As String, ByVal FileName As String)
    Dim objCalloutCloud As New Charting.CalloutAnnotation
    'objCalloutCloud.ClipToChartArea = "ChartArea1"
    objCalloutCloud.AllowAnchorMoving = True
    objCalloutCloud.AllowSelecting = True
    objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
    objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
    objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
    objCalloutCloud.Name = Guid.NewGuid.ToString
    objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
    objCalloutCloud.ShadowOffset = 1
    objCalloutCloud.Text = New FileInfo(FileName).Name.Replace(".ld3", "")
    objCalloutCloud.Tag = Lucidity
    objCalloutCloud.AnchorDataPoint = graph.Series("REM").Points(0)
    objCalloutCloud.SmartLabelStyle.Enabled = True
    objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
    objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
    objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
    Me.graph.Annotations.Add(objCalloutCloud)

    Changed = True
  End Sub

  Private Sub mnuLucidity_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChecks.DropDownOpening, mnuSubliminals.DropDownOpening, mnuRecordings.DropDownOpening, mnuReadings.DropDownOpening
    Dim objMenu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
    objMenu.DropDownItems.Clear()

    For Each strFile As String In Directory.GetFiles(m_strPath & "Lucidity\" & objMenu.Tag, "*.ld3")
      Dim objMenuSubItem As ToolStripMenuItem = objMenu.DropDownItems.Add(New FileInfo(strFile).Name.Replace(".ld3", ""), objMenu.Image, AddressOf mnuLuciditySubItem_Click)
      objMenuSubItem.Tag = strFile
    Next
  End Sub

  Private Sub mnuAddSoundFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If objOpenFileDialog.ShowDialog = DialogResult.OK Then
      Dim objCalloutCloud As New Charting.CalloutAnnotation
      'objCalloutCloud.ClipToChartArea = "ChartArea1"
      objCalloutCloud.AllowAnchorMoving = True
      objCalloutCloud.AllowSelecting = True
      objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
      objCalloutCloud.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue
      objCalloutCloud.Name = Guid.NewGuid.ToString
      objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue
      objCalloutCloud.ShadowOffset = 1
      objCalloutCloud.Text = New FileInfo(objOpenFileDialog.FileName).Name
      objCalloutCloud.Tag = "MP3::" & objOpenFileDialog.FileName
      objCalloutCloud.AnchorDataPoint = graph.Series("REM").Points(0)
      objCalloutCloud.SmartLabelStyle.Enabled = True
      objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = True
      objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = False
      objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
      Me.graph.Annotations.Add(objCalloutCloud)

      Changed = True
    End If
  End Sub

  Private Sub mnuAnnotationPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnotationPlay.Click
    If Not m_objClickedAnnotation Is Nothing Then
      Execute(m_objClickedAnnotation.Tag)
    End If
  End Sub
End Class
