﻿Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class SplashForm

    Private m_formMain As MainForm
    Private m_strPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Lightened Dream\"
    Private m_strOldPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\lucidcode\Liquid Dream III\"
    Private m_strCategories As String = "Characters,Locations,Objects,Actions,Themes,Emotions"

    Private Sub SplashForm3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = Screen.PrimaryScreen.Bounds.Left + (Screen.PrimaryScreen.Bounds.Width / 2) / 2
        Me.Top = Screen.PrimaryScreen.Bounds.Top + (Screen.PrimaryScreen.Bounds.Height / 2) / 2
        Me.Width = Screen.PrimaryScreen.Bounds.Width / 2
        Me.Height = Screen.PrimaryScreen.Bounds.Height / 2
    End Sub

    Private Sub CheckFolders()
        Dim strDirectory As String

        Try

            ' Migrate Liquid Dream to Lightened Dream
            If Directory.Exists(m_strOldPath) Then
                For Each strOldDirectory As String In Directory.GetDirectories(m_strOldPath)
                    Migrate(strOldDirectory)
                Next
                Directory.Delete(m_strOldPath, True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Migrate()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        Try
            strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\lucidcode"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\lucidcode\Lightened Dream"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

            strDirectory = m_strPath & "Dreams"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

            strDirectory = m_strPath & "Categories"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Actions"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Characters"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Emotions"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Locations"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Objects"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Categories\Themes"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

            strDirectory = m_strPath & "Lucidity"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\Checks"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\Readings"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\Recordings"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\REM Cycles"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\REM Cycles\Temp"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\Subliminals"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = m_strPath & "Lucidity\Exercises"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

            strDirectory = m_strPath & "Resources"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

            strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)
            strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\lucidcode\SpellCheck"
            If Not Directory.Exists(strDirectory) Then Directory.CreateDirectory(strDirectory)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Splash.LoadFolders()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Private Sub Migrate(ByVal OldPath As String)
        For Each strDirectory As String In Directory.GetDirectories(OldPath)
            Migrate(strDirectory)
        Next
        If Not Directory.Exists(OldPath.Replace("Liquid Dream III", "Lightened Dream")) Then
            Directory.CreateDirectory(OldPath.Replace("Liquid Dream III", "Lightened Dream"))
        End If
        For Each strFile As String In Directory.GetFiles(OldPath, "*.*")
            File.Move(strFile, strFile.Replace("Liquid Dream III", "Lightened Dream"))
        Next
    End Sub

    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        tmrLoad.Enabled = False

        Try
            Application.DoEvents()
            graph.ChartAreas(0).AxisX.CustomLabels.Clear()
            graph.Series.Clear()
            graph.ResetAutoValues()
            graph.Annotations.Clear()

            Application.DoEvents()
            Me.Opacity = 1
            ' Dreams
            Dim intPos As Integer = 0

            ' Dreams
            Dim objDreams As Series = graph.Series.Add("Dreams")
            objDreams.ChartType = SeriesChartType.Column
            objDreams.Color = Color.FromArgb(200, 65, 140, 240)
            objDreams.BorderWidth = 1
            objDreams.Points.AddY(0)
            objDreams.Points.AddY(0)

            CheckFolders()

            ' Calculate Exercises
            For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Lucidity\Exercises")
                For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
                    For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
                        objDreams.Points(0).YValues(0) += 1
                    Next
                Next
            Next
            Application.DoEvents()

            Dim objExerciseAnnotation As New Charting.CalloutAnnotation
            objExerciseAnnotation.AllowMoving = True
            objExerciseAnnotation.AllowResizing = True
            objExerciseAnnotation.AllowSelecting = True
            objExerciseAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
            objExerciseAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            objExerciseAnnotation.ForeColor = System.Drawing.Color.SteelBlue
            objExerciseAnnotation.LineColor = System.Drawing.Color.LightSteelBlue
            objExerciseAnnotation.Name = Guid.NewGuid.ToString
            objExerciseAnnotation.ShadowColor = System.Drawing.Color.SteelBlue
            objExerciseAnnotation.ShadowOffset = 1
            objExerciseAnnotation.Text = "Exercises (" & objDreams.Points(0).YValues(0) & ")"
            objExerciseAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
            objExerciseAnnotation.AnchorDataPoint = objDreams.Points(0)
            Me.graph.Annotations.Add(objExerciseAnnotation)
            Application.DoEvents()
            System.Threading.Thread.Sleep(128)

            ' Calculate Dreams
            For Each strYearFolder As String In Directory.GetDirectories(m_strPath + "Dreams")
                For Each strMonthFolder As String In Directory.GetDirectories(strYearFolder)
                    For Each strDreamFile As String In Directory.GetFiles(strMonthFolder, "*.ld3")
                        objDreams.Points(1).YValues(0) += 1
                    Next
                Next
            Next
            Application.DoEvents()

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
            objDreamAnnotation.Text = "Dreams (" & objDreams.Points(1).YValues(0) & ")"
            objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
            objDreamAnnotation.AnchorDataPoint = objDreams.Points(1)
            Me.graph.Annotations.Add(objDreamAnnotation)
            Application.DoEvents()
            System.Threading.Thread.Sleep(128)
            intPos += 1

            ' Categories
            For Each strCategory As String In m_strCategories.Split(",")
                intPos = objDreams.Points.AddY(Directory.GetFiles(m_strPath & "Categories\" & strCategory, "*.ld3").Length)

                Dim objCategoryAnnotation As New Charting.CalloutAnnotation
                objCategoryAnnotation.AllowMoving = True
                objCategoryAnnotation.AllowResizing = True
                objCategoryAnnotation.AllowSelecting = True
                objCategoryAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
                objCategoryAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                objCategoryAnnotation.ForeColor = System.Drawing.Color.SteelBlue
                objCategoryAnnotation.LineColor = System.Drawing.Color.LightSteelBlue
                objCategoryAnnotation.Name = Guid.NewGuid.ToString
                objCategoryAnnotation.ShadowColor = System.Drawing.Color.SteelBlue
                objCategoryAnnotation.ShadowOffset = 1
                objCategoryAnnotation.Text = strCategory & " (" & objDreams.Points(intPos).YValues(0) & ")"
                objCategoryAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
                objCategoryAnnotation.AnchorDataPoint = objDreams.Points(intPos)
                Me.graph.Annotations.Add(objCategoryAnnotation)

                Application.DoEvents()
                System.Threading.Thread.Sleep(128)
            Next

            ' Lucidity
            For Each strCategory As String In "REM Cycles,Checks,Subliminals,Recordings,Readings".Split(",")
                intPos = objDreams.Points.AddY(Directory.GetFiles(m_strPath & "Lucidity\" & strCategory, "*.ld3").Length)

                Dim objCategoryAnnotation As New Charting.CalloutAnnotation
                objCategoryAnnotation.AllowMoving = True
                objCategoryAnnotation.AllowResizing = True
                objCategoryAnnotation.AllowSelecting = True
                objCategoryAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud
                objCategoryAnnotation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                objCategoryAnnotation.ForeColor = System.Drawing.Color.SteelBlue
                objCategoryAnnotation.LineColor = System.Drawing.Color.LightSteelBlue
                objCategoryAnnotation.Name = Guid.NewGuid.ToString
                objCategoryAnnotation.ShadowColor = System.Drawing.Color.SteelBlue
                objCategoryAnnotation.ShadowOffset = 1
                objCategoryAnnotation.Text = strCategory & " (" & objDreams.Points(intPos).YValues(0) & ")"
                objCategoryAnnotation.AnchorAlignment = ContentAlignment.BottomCenter
                objCategoryAnnotation.AnchorDataPoint = objDreams.Points(intPos)
                Me.graph.Annotations.Add(objCategoryAnnotation)

                Application.DoEvents()
                System.Threading.Thread.Sleep(128)
            Next

            Application.DoEvents()
            m_formMain = New MainForm

            Do While Not m_formMain.Loaded
                Application.DoEvents()
                System.Threading.Thread.Sleep(10)
            Loop

            Me.Opacity = 0.6
            Application.DoEvents()
            m_formMain.Show()
            Application.DoEvents()
            m_formMain.LoadMerlin()

            Application.DoEvents()
            System.Threading.Thread.Sleep(128)
            Application.DoEvents()
            Hide()

            m_formMain.LoadImport()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "LightenedDream.Splash.LoadGraph()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub
End Class