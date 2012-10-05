Imports System.Xml

Public Class MerlinViewControl

  Public FileName As String
  Private m_formSubliminal As SubliminalForm
  Friend objMerlin As New AxAgentObjects.AxAgent
  Private m_intPos As Integer = 0
  Private m_boolStop As Boolean = False
  Private m_intHeight As Integer = 26
  Public Changed As Boolean

  Public Sub LoadFile(ByVal strFileName As String)
    Try
      Dim xmlDoc As New XmlDocument
      FileName = strFileName
      xmlDoc.Load(FileName)

      m_intPos = 0
      pnlContainer.Controls.Clear()
      For Each xmlItem As XmlNode In xmlDoc.DocumentElement.SelectNodes("Sequence/Item")
        AddItem(xmlItem.SelectSingleNode("Type").InnerText, xmlItem.SelectSingleNode("Details").InnerText)
      Next
      Changed = False

    Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Save(ByVal Title As String, ByVal Description As String, ByVal strFileName As String)
        Try
            Dim strXml As String

            FileName = strFileName

            strXml = "<Check>"
            strXml += "<Title>" + Title + "</Title>"
            strXml += "<Description>" + Description + "</Description>"
            strXml += "<Sequence>"
            For Each objMerlinItem As MerlinItemControl In pnlContainer.Controls
                strXml += "<Item>"
                strXml += "<Type>" + objMerlinItem.lblType.Text + "</Type>"
                strXml += "<Details>" + objMerlinItem.lblDescription.Text + "</Details>"
                strXml += "</Item>"
            Next
            strXml += "</Sequence>"

            strXml += "</Check>"

            Dim xmlDoc As New XmlDocument
            xmlDoc.LoadXml(strXml)
            xmlDoc.Save(FileName)
            Changed = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Play()
        Try

            If Not objMerlin.Characters("Merlin").Visible Then
                objMerlin.Characters("Merlin").Show()
            End If

            m_boolStop = False
            For Each objMerlinItem As MerlinItemControl In pnlContainer.Controls
                If m_boolStop Then Return

                If objMerlinItem.lblType.Text = "Act" Then
                    Dim arrActions() As String = cmbAct.Text.Split(" ")
                    objMerlin.Characters("Merlin").Play(objMerlinItem.lblDescription.Text)
                ElseIf objMerlinItem.lblType.Text = "Speak" Then
                    objMerlin.Characters("Merlin").Speak(objMerlinItem.lblDescription.Text)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StopRunning()
        Try
            m_boolStop = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Try
            If Not objMerlin.Characters("Merlin").Visible Then
                objMerlin.Characters("Merlin").Show()
            End If

            If optAct.Checked Then
                Dim arrActions() As String = cmbAct.Text.Split(" ")
                objMerlin.Characters("Merlin").Play(arrActions(0))
            ElseIf optSpeak.Checked Then
                objMerlin.Characters("Merlin").Speak(txtSpeak.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.Test()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            If optAct.Checked Then
                Dim arrActions() As String = cmbAct.Text.Split(" ")
                AddItem("Act", arrActions(0))
            ElseIf optSpeak.Checked Then
                AddItem("Speak", txtSpeak.Text)
            End If
            pnlAdd.Visible = False
            Changed = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.OK()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddItem(ByVal Type As String, ByVal Description As String)
        Try
            Dim objMerlinItem As New MerlinItemControl

            objMerlinItem.Location = New System.Drawing.Point(2, 2 + m_intPos * (m_intHeight + 4))
            objMerlinItem.Name = "objMerlinItem"
            objMerlinItem.Size = New System.Drawing.Size(pnlContainer.Width - 8, m_intHeight)
            objMerlinItem.lblType.Text = Type
            objMerlinItem.lblDescription.Text = Description
            AddHandler objMerlinItem.Delete, AddressOf objMerlinItem_Deleted
            pnlContainer.Controls.Add(objMerlinItem)
            m_intPos += 1
            pnlAdd.Visible = False
            Changed = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Check.AddItem()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub objMerlinItem_Deleted(ByRef Item As MerlinItemControl)
    pnlContainer.Controls.Remove(Item)
    m_intPos = 0

    For Each objMerlinItem As MerlinItemControl In pnlContainer.Controls
      objMerlinItem.Location = New System.Drawing.Point(2, 2 + m_intPos * (m_intHeight + 4))
      objMerlinItem.Size = New System.Drawing.Size(pnlContainer.Width - 8, m_intHeight)
      m_intPos += 1
    Next
    Changed = True

  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    pnlAdd.Visible = False
  End Sub

  Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
    pnlAdd.Visible = True
  End Sub
End Class
