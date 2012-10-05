<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemViewControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim MySettings1 As lucidcode.LightenedDream.Lucidity.My.MySettings = New lucidcode.LightenedDream.Lucidity.My.MySettings
        Me.pnlContainer = New System.Windows.Forms.Panel
        Me.Panel3D2 = New lucidcode.Controls.Panel3D
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3D4 = New lucidcode.Controls.Panel3D
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NHunspellTextBoxExtender1 = New Spell_Checker.NHunspellTextBoxExtender
        Me.objRecordingViewControl = New lucidcode.LightenedDream.Lucidity.RecordingViewControl
        Me.objSpeedReadingControl = New lucidcode.LightenedDream.Lucidity.SpeedReadingViewControl
        Me.objMerlinViewControl = New lucidcode.LightenedDream.Lucidity.MerlinViewControl
        Me.objSublinalControl = New lucidcode.LightenedDream.Lucidity.SubliminalViewControl
        Me.pnlContainer.SuspendLayout()
        Me.Panel3D2.SuspendLayout()
        Me.Panel3D4.SuspendLayout()
        CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContainer.Controls.Add(Me.objRecordingViewControl)
        Me.pnlContainer.Controls.Add(Me.objSpeedReadingControl)
        Me.pnlContainer.Controls.Add(Me.objMerlinViewControl)
        Me.pnlContainer.Controls.Add(Me.objSublinalControl)
        Me.pnlContainer.Location = New System.Drawing.Point(0, 98)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(815, 473)
        Me.pnlContainer.TabIndex = 0
        '
        'Panel3D2
        '
        Me.Panel3D2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D2.Controls.Add(Me.txtDescription)
        Me.Panel3D2.Controls.Add(Me.Label1)
        Me.Panel3D2.Controls.Add(Me.Panel3D4)
        Me.Panel3D2.Controls.Add(Me.txtTitle)
        Me.Panel3D2.Controls.Add(Me.Label2)
        Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D2.Name = "Panel3D2"
        Me.Panel3D2.Size = New System.Drawing.Size(815, 88)
        Me.Panel3D2.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(101, 57)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(709, 21)
        Me.txtDescription.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3D4
        '
        Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3D4.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor
        Me.Panel3D4.Controls.Add(Me.lblTitle)
        Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
        Me.Panel3D4.Name = "Panel3D4"
        Me.Panel3D4.Size = New System.Drawing.Size(815, 24)
        Me.Panel3D4.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor
        Me.lblTitle.Location = New System.Drawing.Point(8, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(802, 19)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(101, 30)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(709, 21)
        Me.txtTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Title"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NHunspellTextBoxExtender1
        '
        Me.NHunspellTextBoxExtender1.Language = "English"
        Me.NHunspellTextBoxExtender1.MaintainUserChoice = False
        Me.NHunspellTextBoxExtender1.NumberofSuggestions = Spell_Checker.NHunspellTextBoxExtender.SuggestionNumbers.Five
        Me.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7
        Me.NHunspellTextBoxExtender1.SpellAsYouType = True
        '
        'objRecordingViewControl
        '
        Me.objRecordingViewControl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.objRecordingViewControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.objRecordingViewControl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.objRecordingViewControl.Location = New System.Drawing.Point(609, 100)
        Me.objRecordingViewControl.Name = "objRecordingViewControl"
        Me.objRecordingViewControl.Size = New System.Drawing.Size(117, 87)
        Me.objRecordingViewControl.TabIndex = 3
        '
        'objSpeedReadingControl
        '
        Me.objSpeedReadingControl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.objSpeedReadingControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.objSpeedReadingControl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.objSpeedReadingControl.Location = New System.Drawing.Point(220, 226)
        Me.objSpeedReadingControl.Name = "objSpeedReadingControl"
        Me.objSpeedReadingControl.Size = New System.Drawing.Size(166, 116)
        Me.objSpeedReadingControl.TabIndex = 2
        '
        'objMerlinViewControl
        '
        Me.objMerlinViewControl.BackColor = System.Drawing.Color.LightSteelBlue
        MySettings1.Font = New System.Drawing.Font("Verdana", 8.25!)
        MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue
        MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue
        MySettings1.SettingsKey = ""
        MySettings1.TextBackColor = System.Drawing.Color.White
        MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue
        MySettings1.TitleForeColor = System.Drawing.Color.White
        Me.objMerlinViewControl.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.objMerlinViewControl.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", MySettings1, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.objMerlinViewControl.DataBindings.Add(New System.Windows.Forms.Binding("Font", MySettings1, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.objMerlinViewControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.objMerlinViewControl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.objMerlinViewControl.Location = New System.Drawing.Point(289, 245)
        Me.objMerlinViewControl.Name = "objMerlinViewControl"
        Me.objMerlinViewControl.Size = New System.Drawing.Size(485, 191)
        Me.objMerlinViewControl.TabIndex = 1
        '
        'objSublinalControl
        '
        Me.objSublinalControl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.objSublinalControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.objSublinalControl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.objSublinalControl.Location = New System.Drawing.Point(0, 0)
        Me.objSublinalControl.Name = "objSublinalControl"
        Me.objSublinalControl.Size = New System.Drawing.Size(540, 199)
        Me.objSublinalControl.TabIndex = 0
        '
        'ItemViewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
        Me.Controls.Add(Me.Panel3D2)
        Me.Controls.Add(Me.pnlContainer)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font
        Me.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor
        Me.Name = "ItemViewControl"
        Me.Size = New System.Drawing.Size(815, 571)
        Me.pnlContainer.ResumeLayout(False)
        Me.Panel3D2.ResumeLayout(False)
        Me.Panel3D2.PerformLayout()
        Me.Panel3D4.ResumeLayout(False)
        CType(Me.NHunspellTextBoxExtender1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
    Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents objSublinalControl As lucidcode.LightenedDream.Lucidity.SubliminalViewControl
    Friend WithEvents objMerlinViewControl As lucidcode.LightenedDream.Lucidity.MerlinViewControl
    Friend WithEvents objSpeedReadingControl As lucidcode.LightenedDream.Lucidity.SpeedReadingViewControl
    Friend WithEvents objRecordingViewControl As lucidcode.LightenedDream.Lucidity.RecordingViewControl
  Friend WithEvents NHunspellTextBoxExtender1 As Spell_Checker.NHunspellTextBoxExtender

End Class
