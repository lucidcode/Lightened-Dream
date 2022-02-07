Imports NHunspellExtender

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExerciseViewControl
  Inherits System.Windows.Forms.UserControl

  'UserControl1 overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim MySettings1 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
    Dim MySettings2 As lucidcode.LightenedDream.Dreams.My.MySettings = New lucidcode.LightenedDream.Dreams.My.MySettings
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExerciseViewControl))
    Me.txtExercise = New System.Windows.Forms.TextBox
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.txtTask = New System.Windows.Forms.TextBox
    Me.cmbLucidity = New System.Windows.Forms.ComboBox
    Me.dtDate = New System.Windows.Forms.DateTimePicker
    Me.txtTitle = New System.Windows.Forms.TextBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.NHunspellTextBoxExtender1 = New NHunspellTextBoxExtender
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtExercise
    '
    Me.txtExercise.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    MySettings1.Font = New System.Drawing.Font("Verdana", 8.25!)
    MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue
    MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue
    MySettings1.LastAsleep = New Date(CType(0, Long))
    MySettings1.LastAwake = New Date(CType(0, Long))
    MySettings1.SettingsKey = ""
    MySettings1.TextBackColor = System.Drawing.Color.White
    MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue
    MySettings1.TitleForeColor = System.Drawing.Color.White
    Me.txtExercise.BackColor = MySettings1.TextBackColor
    Me.txtExercise.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtExercise.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtExercise.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtExercise.Location = New System.Drawing.Point(8, 80)
    Me.txtExercise.Multiline = True
    Me.txtExercise.Name = "txtExercise"
    Me.txtExercise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtExercise.Size = New System.Drawing.Size(861, 492)
    Me.txtExercise.TabIndex = 2
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.txtTask)
    Me.Panel3D2.Controls.Add(Me.cmbLucidity)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Controls.Add(Me.dtDate)
    Me.Panel3D2.Controls.Add(Me.Label11)
    Me.Panel3D2.Controls.Add(Me.txtTitle)
    Me.Panel3D2.Controls.Add(Me.txtExercise)
    Me.Panel3D2.Controls.Add(Me.Label12)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D2.TabIndex = 8
    '
    'txtTask
    '
    Me.txtTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    MySettings2.Font = New System.Drawing.Font("Verdana", 8.25!)
    MySettings2.FormBackColor = System.Drawing.Color.LightSteelBlue
    MySettings2.FormForeColor = System.Drawing.Color.MidnightBlue
    MySettings2.LastAsleep = New Date(CType(0, Long))
    MySettings2.LastAwake = New Date(CType(0, Long))
    MySettings2.SettingsKey = ""
    MySettings2.TextBackColor = System.Drawing.Color.White
    MySettings2.TitleBackColor = System.Drawing.Color.SteelBlue
    MySettings2.TitleForeColor = System.Drawing.Color.White
    Me.txtTask.BackColor = MySettings2.TextBackColor
    Me.txtTask.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings2, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtTask.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTask.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtTask.Location = New System.Drawing.Point(271, 27)
    Me.txtTask.Multiline = True
    Me.txtTask.Name = "txtTask"
    Me.txtTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtTask.Size = New System.Drawing.Size(598, 47)
    Me.txtTask.TabIndex = 34
    '
    'cmbLucidity
    '
    Me.cmbLucidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbLucidity.FormattingEnabled = True
    Me.cmbLucidity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
    Me.cmbLucidity.Location = New System.Drawing.Point(233, 53)
    Me.cmbLucidity.Name = "cmbLucidity"
    Me.cmbLucidity.Size = New System.Drawing.Size(32, 21)
    Me.cmbLucidity.TabIndex = 3
    '
    'dtDate
    '
    Me.dtDate.CustomFormat = "ddd yyyy-MM-dd HH:mm"
    Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtDate.Location = New System.Drawing.Point(53, 53)
    Me.dtDate.Name = "dtDate"
    Me.dtDate.Size = New System.Drawing.Size(171, 21)
    Me.dtDate.TabIndex = 1
    '
    'txtTitle
    '
    Me.txtTitle.Location = New System.Drawing.Point(53, 27)
    Me.txtTitle.Name = "txtTitle"
    Me.txtTitle.Size = New System.Drawing.Size(212, 21)
    Me.txtTitle.TabIndex = 0
    '
    'Label11
    '
    Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label11.Location = New System.Drawing.Point(8, 27)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(39, 21)
    Me.Label11.TabIndex = 31
    Me.Label11.Text = "Title"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(7, 53)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(39, 21)
    Me.Label12.TabIndex = 29
    Me.Label12.Text = "Date"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = MySettings1.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.Label2)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(874, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.ForeColor = MySettings1.TitleForeColor
    Me.lblTitle.Location = New System.Drawing.Point(7, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(864, 19)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Title"
    Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = MySettings1.TitleForeColor
    Me.Label2.Location = New System.Drawing.Point(8, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 19)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Dream"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstImg
    '
    Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
    Me.lstImg.Images.SetKeyName(0, "Categories.ico")
    Me.lstImg.Images.SetKeyName(1, "Lucidity.ico")
    '
    'NHunspellTextBoxExtender1
    '
    Me.NHunspellTextBoxExtender1.Language = "English"
    Me.NHunspellTextBoxExtender1.MaintainUserChoice = False
    Me.NHunspellTextBoxExtender1.NumberofSuggestions = NHunspellTextBoxExtender.SuggestionNumbers.Five
    Me.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7
    Me.NHunspellTextBoxExtender1.SpellAsYouType = True
    '
    'ExerciseViewControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = MySettings1.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", MySettings1, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = MySettings1.Font
    Me.ForeColor = MySettings1.FormForeColor
    Me.Name = "ExerciseViewControl"
    Me.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D2.PerformLayout()
    Me.Panel3D4.ResumeLayout(False)
    CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents txtTitle As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Public WithEvents dtDate As System.Windows.Forms.DateTimePicker
  Public WithEvents txtExercise As System.Windows.Forms.TextBox
  Friend WithEvents cmbLucidity As System.Windows.Forms.ComboBox
  Friend WithEvents NHunspellTextBoxExtender1 As NHunspellTextBoxExtender
  Public WithEvents txtTask As System.Windows.Forms.TextBox

End Class
