<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExercisesViewControl
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
    Me.components = New System.ComponentModel.Container
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("I Am - In Search of Lucidity Day 01", 4)
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExercisesViewControl))
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.lstLucidity = New System.Windows.Forms.ListView
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Panel3D2.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel3D2
    '
    Me.Panel3D2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D2.Controls.Add(Me.lstLucidity)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(815, 571)
    Me.Panel3D2.TabIndex = 6
    '
    'lstLucidity
    '
    Me.lstLucidity.Activation = System.Windows.Forms.ItemActivation.OneClick
    Me.lstLucidity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLucidity.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lstLucidity.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor
        Me.lstLucidity.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstLucidity.LargeImageList = Me.lstImg
        Me.lstLucidity.Location = New System.Drawing.Point(3, 30)
        Me.lstLucidity.Name = "lstLucidity"
        Me.lstLucidity.Size = New System.Drawing.Size(809, 538)
        Me.lstLucidity.TabIndex = 6
        Me.lstLucidity.TileSize = New System.Drawing.Size(150, 32)
        Me.lstLucidity.UseCompatibleStateImageBehavior = False
        Me.lstLucidity.View = System.Windows.Forms.View.Tile
        '
        'lstImg
        '
        Me.lstImg.ImageStream = CType(resources.GetObject("lstImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImg.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImg.Images.SetKeyName(0, "Recordings")
        Me.lstImg.Images.SetKeyName(1, "Readings")
        Me.lstImg.Images.SetKeyName(2, "Checks")
        Me.lstImg.Images.SetKeyName(3, "REM Cycles")
        Me.lstImg.Images.SetKeyName(4, "Subliminals")
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
        Me.lblTitle.Text = "Exercises"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExercisesViewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor
        Me.Controls.Add(Me.Panel3D2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font
        Me.ForeColor = Global.lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor
    Me.Name = "ExercisesViewControl"
    Me.Size = New System.Drawing.Size(815, 571)
    Me.Panel3D2.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Friend WithEvents lblTitle As System.Windows.Forms.Label
  Friend WithEvents lstLucidity As System.Windows.Forms.ListView
  Friend WithEvents lstImg As System.Windows.Forms.ImageList

End Class
