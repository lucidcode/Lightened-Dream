<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewControl
  Inherits System.Windows.Forms.UserControl

  'UserControl1 overrides dispose to clean up the component list.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewControl))
    Me.txtDream = New System.Windows.Forms.TextBox
    Me.Panel3D1 = New lucidcode.Controls.Panel3D
    Me.Panel3D3 = New lucidcode.Controls.Panel3D
    Me.tbUnassigned = New System.Windows.Forms.TrackBar
    Me.Label3 = New System.Windows.Forms.Label
    Me.lstUnassigned = New System.Windows.Forms.ListView
    Me.Panel3D2 = New lucidcode.Controls.Panel3D
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.cmbLucidity = New System.Windows.Forms.ComboBox
    Me.objDreamSlider = New lucidcode.Controls.MultiSliderControl.SliderControl
    Me.Label9 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.dtEnd = New System.Windows.Forms.DateTimePicker
    Me.dtStart = New System.Windows.Forms.DateTimePicker
    Me.dtDate = New System.Windows.Forms.DateTimePicker
    Me.txtTitle = New System.Windows.Forms.TextBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.Panel3D15 = New lucidcode.Controls.Panel3D
    Me.Panel3D16 = New lucidcode.Controls.Panel3D
    Me.Label8 = New System.Windows.Forms.Label
    Me.lstEmotions = New System.Windows.Forms.ListView
    Me.Panel3D13 = New lucidcode.Controls.Panel3D
    Me.Panel3D14 = New lucidcode.Controls.Panel3D
    Me.Label7 = New System.Windows.Forms.Label
    Me.lstThemes = New System.Windows.Forms.ListView
    Me.Panel3D11 = New lucidcode.Controls.Panel3D
    Me.Panel3D12 = New lucidcode.Controls.Panel3D
    Me.Label6 = New System.Windows.Forms.Label
    Me.lstActions = New System.Windows.Forms.ListView
    Me.Panel3D9 = New lucidcode.Controls.Panel3D
    Me.Panel3D10 = New lucidcode.Controls.Panel3D
    Me.Label5 = New System.Windows.Forms.Label
    Me.lstObjects = New System.Windows.Forms.ListView
    Me.Panel3D7 = New lucidcode.Controls.Panel3D
    Me.Panel3D8 = New lucidcode.Controls.Panel3D
    Me.Label4 = New System.Windows.Forms.Label
    Me.lstLocations = New System.Windows.Forms.ListView
    Me.Panel3D5 = New lucidcode.Controls.Panel3D
    Me.Panel3D6 = New lucidcode.Controls.Panel3D
    Me.Label1 = New System.Windows.Forms.Label
    Me.lstCharacters = New System.Windows.Forms.ListView
    Me.Panel3D4 = New lucidcode.Controls.Panel3D
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lstImg = New System.Windows.Forms.ImageList(Me.components)
    Me.NHunspellTextBoxExtender1 = New Spell_Checker.NHunspellTextBoxExtender()
    Me.Panel3D1.SuspendLayout()
    Me.Panel3D3.SuspendLayout()
    CType(Me.tbUnassigned, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3D2.SuspendLayout()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel3D15.SuspendLayout()
    Me.Panel3D16.SuspendLayout()
    Me.Panel3D13.SuspendLayout()
    Me.Panel3D14.SuspendLayout()
    Me.Panel3D11.SuspendLayout()
    Me.Panel3D12.SuspendLayout()
    Me.Panel3D9.SuspendLayout()
    Me.Panel3D10.SuspendLayout()
    Me.Panel3D7.SuspendLayout()
    Me.Panel3D8.SuspendLayout()
    Me.Panel3D5.SuspendLayout()
    Me.Panel3D6.SuspendLayout()
    Me.Panel3D4.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtDream
    '
    Me.txtDream.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDream.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TextBackColor
    Me.txtDream.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TextBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtDream.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDream.ForeColor = System.Drawing.Color.MidnightBlue
    Me.txtDream.Location = New System.Drawing.Point(4, 57)
    Me.txtDream.Multiline = True
    Me.txtDream.Name = "txtDream"
    Me.txtDream.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtDream.Size = New System.Drawing.Size(861, 299)
    Me.txtDream.TabIndex = 2
    '
    'Panel3D1
    '
    Me.Panel3D1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D1.BackColor = System.Drawing.Color.White
    Me.Panel3D1.Controls.Add(Me.Panel3D3)
    Me.Panel3D1.Controls.Add(Me.lstUnassigned)
    Me.Panel3D1.Location = New System.Drawing.Point(3, 3)
    Me.Panel3D1.Name = "Panel3D1"
    Me.Panel3D1.Size = New System.Drawing.Size(132, 187)
    Me.Panel3D1.TabIndex = 7
    '
    'Panel3D3
    '
    Me.Panel3D3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D3.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D3.Controls.Add(Me.tbUnassigned)
    Me.Panel3D3.Controls.Add(Me.Label3)
    Me.Panel3D3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D3.Name = "Panel3D3"
    Me.Panel3D3.Size = New System.Drawing.Size(132, 24)
    Me.Panel3D3.TabIndex = 5
    '
    'tbUnassigned
    '
    Me.tbUnassigned.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbUnassigned.AutoSize = False
    Me.tbUnassigned.LargeChange = 1
    Me.tbUnassigned.Location = New System.Drawing.Point(85, 2)
    Me.tbUnassigned.Maximum = 5
    Me.tbUnassigned.Minimum = 1
    Me.tbUnassigned.Name = "tbUnassigned"
    Me.tbUnassigned.Size = New System.Drawing.Size(44, 19)
    Me.tbUnassigned.TabIndex = 37
    Me.tbUnassigned.TabStop = False
    Me.tbUnassigned.Value = 5
    Me.tbUnassigned.Visible = False
    '
    'Label3
    '
    Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label3.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label3.Location = New System.Drawing.Point(3, 3)
    Me.Label3.Margin = New System.Windows.Forms.Padding(0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(126, 19)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Unassigned"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstUnassigned
    '
    Me.lstUnassigned.AllowDrop = True
    Me.lstUnassigned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstUnassigned.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstUnassigned.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstUnassigned.FullRowSelect = True
    Me.lstUnassigned.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstUnassigned.Location = New System.Drawing.Point(3, 30)
    Me.lstUnassigned.MultiSelect = False
    Me.lstUnassigned.Name = "lstUnassigned"
    Me.lstUnassigned.Size = New System.Drawing.Size(126, 154)
    Me.lstUnassigned.TabIndex = 0
    Me.lstUnassigned.TabStop = False
    Me.lstUnassigned.UseCompatibleStateImageBehavior = False
    Me.lstUnassigned.View = System.Windows.Forms.View.List
    '
    'Panel3D2
    '
    Me.Panel3D2.Controls.Add(Me.SplitContainer1)
    Me.Panel3D2.Controls.Add(Me.Panel3D4)
    Me.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3D2.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D2.Name = "Panel3D2"
    Me.Panel3D2.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D2.TabIndex = 8
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(3, 25)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmbLucidity)
    Me.SplitContainer1.Panel1.Controls.Add(Me.objDreamSlider)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
    Me.SplitContainer1.Panel1.Controls.Add(Me.dtEnd)
    Me.SplitContainer1.Panel1.Controls.Add(Me.dtStart)
    Me.SplitContainer1.Panel1.Controls.Add(Me.dtDate)
    Me.SplitContainer1.Panel1.Controls.Add(Me.txtTitle)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
    Me.SplitContainer1.Panel1.Controls.Add(Me.txtDream)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
    Me.SplitContainer1.Size = New System.Drawing.Size(868, 554)
    Me.SplitContainer1.SplitterDistance = 359
    Me.SplitContainer1.SplitterWidth = 2
    Me.SplitContainer1.TabIndex = 11
    '
    'cmbLucidity
    '
    Me.cmbLucidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbLucidity.FormattingEnabled = True
    Me.cmbLucidity.Items.AddRange(New Object() {"1 Thought", "2 Daydream", "3 Nightmare", "4 Foggy Dream", "5 Normal Dream", "6 Vivid Dream", "7 Lucid Dream", "8 Epic Dream", "9 Wake Induced"})
    Me.cmbLucidity.Location = New System.Drawing.Point(229, 5)
    Me.cmbLucidity.Name = "cmbLucidity"
    Me.cmbLucidity.Size = New System.Drawing.Size(122, 21)
    Me.cmbLucidity.TabIndex = 3
    '
    'objDreamSlider
    '
    Me.objDreamSlider.AllowDream = True
    Me.objDreamSlider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.objDreamSlider.DisplayInterval = 12
    Me.objDreamSlider.DreamTime = System.TimeSpan.Parse("22:30:00")
    Me.objDreamSlider.Increment = 10
    Me.objDreamSlider.Location = New System.Drawing.Point(357, 7)
    Me.objDreamSlider.Maximum = System.TimeSpan.Parse("12:00:00")
    Me.objDreamSlider.Minimum = System.TimeSpan.Parse("12:00:01")
    Me.objDreamSlider.Name = "objDreamSlider"
    Me.objDreamSlider.ShowIncrement = True
    Me.objDreamSlider.Size = New System.Drawing.Size(508, 47)
    Me.objDreamSlider.StartTime = System.TimeSpan.Parse("18:30:01")
    Me.objDreamSlider.StopTime = System.TimeSpan.Parse("23:50:00")
    Me.objDreamSlider.TabIndex = 38
    '
    'Label9
    '
    Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label9.Location = New System.Drawing.Point(810, 1)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(52, 21)
    Me.Label9.TabIndex = 35
    Me.Label9.Text = "Awake"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label13
    '
    Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label13.Location = New System.Drawing.Point(486, 3)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(52, 21)
    Me.Label13.TabIndex = 37
    Me.Label13.Text = "Clarity"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dtEnd
    '
    Me.dtEnd.CustomFormat = "HH:mm"
    Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtEnd.Location = New System.Drawing.Point(293, 30)
    Me.dtEnd.Name = "dtEnd"
    Me.dtEnd.ShowUpDown = True
    Me.dtEnd.Size = New System.Drawing.Size(58, 21)
    Me.dtEnd.TabIndex = 5
    Me.dtEnd.Value = New Date(2009, 12, 2, 6, 0, 0, 0)
    '
    'dtStart
    '
    Me.dtStart.CustomFormat = "HH:mm"
    Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtStart.Location = New System.Drawing.Point(229, 30)
    Me.dtStart.Name = "dtStart"
    Me.dtStart.ShowUpDown = True
    Me.dtStart.Size = New System.Drawing.Size(58, 21)
    Me.dtStart.TabIndex = 4
    Me.dtStart.Value = New Date(2009, 12, 2, 23, 0, 0, 0)
    '
    'dtDate
    '
    Me.dtDate.CustomFormat = "ddd yyyy-MM-dd HH:mm"
    Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtDate.Location = New System.Drawing.Point(49, 30)
    Me.dtDate.Name = "dtDate"
    Me.dtDate.Size = New System.Drawing.Size(171, 21)
    Me.dtDate.TabIndex = 1
    '
    'txtTitle
    '
    Me.txtTitle.Location = New System.Drawing.Point(49, 4)
    Me.txtTitle.Name = "txtTitle"
    Me.txtTitle.Size = New System.Drawing.Size(171, 21)
    Me.txtTitle.TabIndex = 0
    '
    'Label11
    '
    Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label11.Location = New System.Drawing.Point(4, 4)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(39, 21)
    Me.Label11.TabIndex = 31
    Me.Label11.Text = "Title"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.Location = New System.Drawing.Point(3, 30)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(39, 21)
    Me.Label12.TabIndex = 29
    Me.Label12.Text = "Date"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label10
    '
    Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
    Me.Label10.Location = New System.Drawing.Point(235, 1)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(52, 21)
    Me.Label10.TabIndex = 33
    Me.Label10.Text = "Sleep"
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 7
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D15, 6, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D13, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D11, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D9, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D7, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D5, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Panel3D1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 193)
    Me.TableLayoutPanel1.TabIndex = 8
    '
    'Panel3D15
    '
    Me.Panel3D15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D15.BackColor = System.Drawing.Color.White
    Me.Panel3D15.Controls.Add(Me.Panel3D16)
    Me.Panel3D15.Controls.Add(Me.lstEmotions)
    Me.Panel3D15.Location = New System.Drawing.Point(746, 3)
    Me.Panel3D15.Name = "Panel3D15"
    Me.Panel3D15.Size = New System.Drawing.Size(119, 187)
    Me.Panel3D15.TabIndex = 13
    '
    'Panel3D16
    '
    Me.Panel3D16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D16.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D16.Controls.Add(Me.Label8)
    Me.Panel3D16.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D16.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D16.Name = "Panel3D16"
    Me.Panel3D16.Size = New System.Drawing.Size(119, 24)
    Me.Panel3D16.TabIndex = 5
    '
    'Label8
    '
    Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label8.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
    Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label8.Location = New System.Drawing.Point(3, 3)
    Me.Label8.Margin = New System.Windows.Forms.Padding(0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(113, 19)
    Me.Label8.TabIndex = 3
    Me.Label8.Text = "    Emotions"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstEmotions
    '
    Me.lstEmotions.AllowDrop = True
    Me.lstEmotions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstEmotions.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstEmotions.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstEmotions.FullRowSelect = True
    Me.lstEmotions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstEmotions.Location = New System.Drawing.Point(3, 30)
    Me.lstEmotions.MultiSelect = False
    Me.lstEmotions.Name = "lstEmotions"
    Me.lstEmotions.Size = New System.Drawing.Size(113, 154)
    Me.lstEmotions.TabIndex = 0
    Me.lstEmotions.TabStop = False
    Me.lstEmotions.UseCompatibleStateImageBehavior = False
    Me.lstEmotions.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D13
    '
    Me.Panel3D13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D13.BackColor = System.Drawing.Color.White
    Me.Panel3D13.Controls.Add(Me.Panel3D14)
    Me.Panel3D13.Controls.Add(Me.lstThemes)
    Me.Panel3D13.Location = New System.Drawing.Point(625, 3)
    Me.Panel3D13.Name = "Panel3D13"
    Me.Panel3D13.Size = New System.Drawing.Size(115, 187)
    Me.Panel3D13.TabIndex = 12
    '
    'Panel3D14
    '
    Me.Panel3D14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D14.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D14.Controls.Add(Me.Label7)
    Me.Panel3D14.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D14.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D14.Name = "Panel3D14"
    Me.Panel3D14.Size = New System.Drawing.Size(115, 24)
    Me.Panel3D14.TabIndex = 5
    '
    'Label7
    '
    Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label7.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
    Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label7.Location = New System.Drawing.Point(3, 3)
    Me.Label7.Margin = New System.Windows.Forms.Padding(0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(109, 19)
    Me.Label7.TabIndex = 3
    Me.Label7.Text = "    Themes"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstThemes
    '
    Me.lstThemes.AllowDrop = True
    Me.lstThemes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstThemes.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstThemes.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstThemes.FullRowSelect = True
    Me.lstThemes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstThemes.Location = New System.Drawing.Point(3, 30)
    Me.lstThemes.MultiSelect = False
    Me.lstThemes.Name = "lstThemes"
    Me.lstThemes.Size = New System.Drawing.Size(109, 154)
    Me.lstThemes.TabIndex = 0
    Me.lstThemes.TabStop = False
    Me.lstThemes.UseCompatibleStateImageBehavior = False
    Me.lstThemes.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D11
    '
    Me.Panel3D11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D11.BackColor = System.Drawing.Color.White
    Me.Panel3D11.Controls.Add(Me.Panel3D12)
    Me.Panel3D11.Controls.Add(Me.lstActions)
    Me.Panel3D11.Location = New System.Drawing.Point(521, 3)
    Me.Panel3D11.Name = "Panel3D11"
    Me.Panel3D11.Size = New System.Drawing.Size(98, 187)
    Me.Panel3D11.TabIndex = 11
    '
    'Panel3D12
    '
    Me.Panel3D12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D12.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D12.Controls.Add(Me.Label6)
    Me.Panel3D12.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D12.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D12.Name = "Panel3D12"
    Me.Panel3D12.Size = New System.Drawing.Size(98, 24)
    Me.Panel3D12.TabIndex = 5
    '
    'Label6
    '
    Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label6.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
    Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label6.Location = New System.Drawing.Point(3, 3)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(92, 19)
    Me.Label6.TabIndex = 3
    Me.Label6.Text = "    Actions"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstActions
    '
    Me.lstActions.AllowDrop = True
    Me.lstActions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstActions.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstActions.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstActions.FullRowSelect = True
    Me.lstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstActions.Location = New System.Drawing.Point(3, 30)
    Me.lstActions.MultiSelect = False
    Me.lstActions.Name = "lstActions"
    Me.lstActions.Size = New System.Drawing.Size(92, 154)
    Me.lstActions.TabIndex = 0
    Me.lstActions.TabStop = False
    Me.lstActions.UseCompatibleStateImageBehavior = False
    Me.lstActions.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D9
    '
    Me.Panel3D9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D9.BackColor = System.Drawing.Color.White
    Me.Panel3D9.Controls.Add(Me.Panel3D10)
    Me.Panel3D9.Controls.Add(Me.lstObjects)
    Me.Panel3D9.Location = New System.Drawing.Point(400, 3)
    Me.Panel3D9.Name = "Panel3D9"
    Me.Panel3D9.Size = New System.Drawing.Size(115, 187)
    Me.Panel3D9.TabIndex = 10
    '
    'Panel3D10
    '
    Me.Panel3D10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D10.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D10.Controls.Add(Me.Label5)
    Me.Panel3D10.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D10.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D10.Name = "Panel3D10"
    Me.Panel3D10.Size = New System.Drawing.Size(115, 24)
    Me.Panel3D10.TabIndex = 5
    '
    'Label5
    '
    Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label5.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
    Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label5.Location = New System.Drawing.Point(3, 3)
    Me.Label5.Margin = New System.Windows.Forms.Padding(0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(109, 19)
    Me.Label5.TabIndex = 3
    Me.Label5.Text = "    Objects"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstObjects
    '
    Me.lstObjects.AllowDrop = True
    Me.lstObjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstObjects.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstObjects.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstObjects.FullRowSelect = True
    Me.lstObjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstObjects.Location = New System.Drawing.Point(3, 30)
    Me.lstObjects.MultiSelect = False
    Me.lstObjects.Name = "lstObjects"
    Me.lstObjects.Size = New System.Drawing.Size(109, 154)
    Me.lstObjects.TabIndex = 0
    Me.lstObjects.TabStop = False
    Me.lstObjects.UseCompatibleStateImageBehavior = False
    Me.lstObjects.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D7
    '
    Me.Panel3D7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D7.BackColor = System.Drawing.Color.White
    Me.Panel3D7.Controls.Add(Me.Panel3D8)
    Me.Panel3D7.Controls.Add(Me.lstLocations)
    Me.Panel3D7.Location = New System.Drawing.Point(279, 3)
    Me.Panel3D7.Name = "Panel3D7"
    Me.Panel3D7.Size = New System.Drawing.Size(115, 187)
    Me.Panel3D7.TabIndex = 9
    '
    'Panel3D8
    '
    Me.Panel3D8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D8.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D8.Controls.Add(Me.Label4)
    Me.Panel3D8.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D8.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D8.Name = "Panel3D8"
    Me.Panel3D8.Size = New System.Drawing.Size(115, 24)
    Me.Panel3D8.TabIndex = 5
    '
    'Label4
    '
    Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
    Me.Label4.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
    Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label4.Location = New System.Drawing.Point(3, 3)
    Me.Label4.Margin = New System.Windows.Forms.Padding(0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(109, 19)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "    Locations"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstLocations
    '
    Me.lstLocations.AllowDrop = True
    Me.lstLocations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstLocations.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstLocations.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstLocations.FullRowSelect = True
    Me.lstLocations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstLocations.Location = New System.Drawing.Point(3, 30)
    Me.lstLocations.MultiSelect = False
    Me.lstLocations.Name = "lstLocations"
    Me.lstLocations.Size = New System.Drawing.Size(109, 154)
    Me.lstLocations.TabIndex = 0
    Me.lstLocations.TabStop = False
    Me.lstLocations.UseCompatibleStateImageBehavior = False
    Me.lstLocations.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D5
    '
    Me.Panel3D5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D5.BackColor = System.Drawing.Color.White
    Me.Panel3D5.Controls.Add(Me.Panel3D6)
    Me.Panel3D5.Controls.Add(Me.lstCharacters)
    Me.Panel3D5.Location = New System.Drawing.Point(141, 3)
    Me.Panel3D5.Name = "Panel3D5"
    Me.Panel3D5.Size = New System.Drawing.Size(132, 187)
    Me.Panel3D5.TabIndex = 8
    '
    'Panel3D6
    '
    Me.Panel3D6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D6.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D6.Controls.Add(Me.Label1)
    Me.Panel3D6.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D6.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D6.Name = "Panel3D6"
    Me.Panel3D6.Size = New System.Drawing.Size(132, 24)
    Me.Panel3D6.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
    Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label1.Location = New System.Drawing.Point(2, 3)
    Me.Label1.Margin = New System.Windows.Forms.Padding(0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(127, 19)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "    Characters"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstCharacters
    '
    Me.lstCharacters.AllowDrop = True
    Me.lstCharacters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.lstCharacters.ForeColor = System.Drawing.Color.MidnightBlue
    Me.lstCharacters.FullRowSelect = True
    Me.lstCharacters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lstCharacters.Location = New System.Drawing.Point(3, 30)
    Me.lstCharacters.MultiSelect = False
    Me.lstCharacters.Name = "lstCharacters"
    Me.lstCharacters.Size = New System.Drawing.Size(126, 154)
    Me.lstCharacters.TabIndex = 0
    Me.lstCharacters.TabStop = False
    Me.lstCharacters.UseCompatibleStateImageBehavior = False
    Me.lstCharacters.View = System.Windows.Forms.View.SmallIcon
    '
    'Panel3D4
    '
    Me.Panel3D4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3D4.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleBackColor
    Me.Panel3D4.Controls.Add(Me.lblTitle)
    Me.Panel3D4.Controls.Add(Me.Label2)
    Me.Panel3D4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Panel3D4.Location = New System.Drawing.Point(0, 0)
    Me.Panel3D4.Name = "Panel3D4"
    Me.Panel3D4.Size = New System.Drawing.Size(874, 24)
    Me.Panel3D4.TabIndex = 5
    '
    'lblTitle
    '
    Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTitle.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
    Me.lblTitle.Location = New System.Drawing.Point(7, 3)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(864, 19)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Title"
    Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "TitleForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.TitleForeColor
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
    'ViewControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.FormBackColor
    Me.Controls.Add(Me.Panel3D2)
    Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "FormBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default, "FormForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.Font = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.Font
    Me.ForeColor = Global.lucidcode.LiquidDream.Dreams.My.MySettings.Default.FormForeColor
    Me.Name = "ViewControl"
    Me.Size = New System.Drawing.Size(874, 582)
    Me.Panel3D1.ResumeLayout(False)
    Me.Panel3D3.ResumeLayout(False)
    CType(Me.tbUnassigned, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3D2.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.PerformLayout()
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel3D15.ResumeLayout(False)
    Me.Panel3D16.ResumeLayout(False)
    Me.Panel3D13.ResumeLayout(False)
    Me.Panel3D14.ResumeLayout(False)
    Me.Panel3D11.ResumeLayout(False)
    Me.Panel3D12.ResumeLayout(False)
    Me.Panel3D9.ResumeLayout(False)
    Me.Panel3D10.ResumeLayout(False)
    Me.Panel3D7.ResumeLayout(False)
    Me.Panel3D8.ResumeLayout(False)
    Me.Panel3D5.ResumeLayout(False)
    Me.Panel3D6.ResumeLayout(False)
    Me.Panel3D4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel3D2 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D4 As lucidcode.Controls.Panel3D
  Public WithEvents lblTitle As System.Windows.Forms.Label
  Friend WithEvents lstUnassigned As System.Windows.Forms.ListView
  Friend WithEvents Panel3D1 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D3 As lucidcode.Controls.Panel3D
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Public WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Panel3D15 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D16 As lucidcode.Controls.Panel3D
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lstEmotions As System.Windows.Forms.ListView
  Friend WithEvents Panel3D13 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D14 As lucidcode.Controls.Panel3D
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents lstThemes As System.Windows.Forms.ListView
  Friend WithEvents Panel3D11 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D12 As lucidcode.Controls.Panel3D
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents lstActions As System.Windows.Forms.ListView
  Friend WithEvents Panel3D9 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D10 As lucidcode.Controls.Panel3D
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lstObjects As System.Windows.Forms.ListView
  Friend WithEvents Panel3D7 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D8 As lucidcode.Controls.Panel3D
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lstLocations As System.Windows.Forms.ListView
  Friend WithEvents Panel3D5 As lucidcode.Controls.Panel3D
  Friend WithEvents Panel3D6 As lucidcode.Controls.Panel3D
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lstCharacters As System.Windows.Forms.ListView
  Friend WithEvents lstImg As System.Windows.Forms.ImageList
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtTitle As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Public WithEvents dtDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents tbUnassigned As System.Windows.Forms.TrackBar
  Public WithEvents txtDream As System.Windows.Forms.TextBox
  Friend WithEvents objDreamSlider As lucidcode.Controls.MultiSliderControl.SliderControl
  Friend WithEvents cmbLucidity As System.Windows.Forms.ComboBox
  Friend WithEvents NHunspellTextBoxExtender1 As Spell_Checker.NHunspellTextBoxExtender

End Class
