using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Lucidity
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class REMCyclesControl : System.Windows.Forms.UserControl
	{

		//UserControl1 overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripMenuItem mnuAddSoundFile = null;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REMCyclesControl));
			System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation Border3DAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation();
			System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation VerticalLineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.LineAnnotation LineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation VerticalLineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation ArrowAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();
			System.Windows.Forms.DataVisualization.Charting.ImageAnnotation ImageAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.ImageAnnotation();
			System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation CalloutAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
			System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation CalloutAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
			System.Windows.Forms.DataVisualization.Charting.TextAnnotation TextAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
			System.Windows.Forms.DataVisualization.Charting.PolygonAnnotation PolygonAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.PolygonAnnotation();
			System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation PolylineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation();
			System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint AnnotationPathPoint1 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
			System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint AnnotationPathPoint2 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
			System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint AnnotationPathPoint3 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.ListViewItem ListViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
				"00:30",
				"DJ Tiesto - Lord of Trance"
			}, 0);
			System.Windows.Forms.ListViewItem ListViewItem2 = new System.Windows.Forms.ListViewItem("02:00");
			System.Windows.Forms.ListViewItem ListViewItem3 = new System.Windows.Forms.ListViewItem("03:30");
			System.Windows.Forms.ListViewItem ListViewItem4 = new System.Windows.Forms.ListViewItem("05:00");
			System.Windows.Forms.ListViewItem ListViewItem5 = new System.Windows.Forms.ListViewItem("06:30");
			System.Windows.Forms.ListViewItem ListViewItem6 = new System.Windows.Forms.ListViewItem("08:00");
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.tmrWatch = new System.Windows.Forms.Timer(this.components);
			this.mnuAnnotation = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuAnnotationAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuChecks = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSubliminals = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadingToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRecordings = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuReadings = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAnnotationPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnnotationCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnnotationPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnnotationDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.Label5 = new System.Windows.Forms.Label();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cmbCycles = new System.Windows.Forms.ComboBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.lstItems = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbCycleLength = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.objPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.objOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			mnuAddSoundFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAnnotation.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.objPlayer).BeginInit();
			this.Panel3D1.SuspendLayout();
			this.SuspendLayout();
			//
			//mnuAddSoundFile
			//
			mnuAddSoundFile.Image = (System.Drawing.Image)resources.GetObject("mnuAddSoundFile.Image");
			mnuAddSoundFile.Name = "mnuAddSoundFile";
			mnuAddSoundFile.Size = new System.Drawing.Size(138, 22);
			mnuAddSoundFile.Text = "&Sound File...";
			mnuAddSoundFile.Click += this.mnuAddSoundFile_Click;
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImg.Images.SetKeyName(0, "Sounds.ico");
			//
			//tmrWatch
			//
			this.tmrWatch.Interval = 1000;
			//
			//mnuAnnotation
			//
			this.mnuAnnotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuAnnotationAdd,
				this.ToolStripMenuItem1,
				this.mnuAnnotationPlay,
				this.mnuAnnotationCopy,
				this.mnuAnnotationPaste,
				this.mnuAnnotationDelete
			});
			this.mnuAnnotation.Name = "mnuAnnotation";
			this.mnuAnnotation.Size = new System.Drawing.Size(111, 120);
			//
			//mnuAnnotationAdd
			//
			this.mnuAnnotationAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuChecks,
				this.mnuSubliminals,
				this.mnuRecordings,
				this.mnuReadings,
				this.ToolStripMenuItem2,
				mnuAddSoundFile
			});
			this.mnuAnnotationAdd.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.mnuAnnotationAdd.Image = (System.Drawing.Image)resources.GetObject("mnuAnnotationAdd.Image");
			this.mnuAnnotationAdd.Name = "mnuAnnotationAdd";
			this.mnuAnnotationAdd.Size = new System.Drawing.Size(110, 22);
			this.mnuAnnotationAdd.Text = "&Import";
			//
			//mnuChecks
			//
			this.mnuChecks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.LoadingToolStripMenuItem });
			this.mnuChecks.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.mnuChecks.Image = (System.Drawing.Image)resources.GetObject("mnuChecks.Image");
			this.mnuChecks.Name = "mnuChecks";
			this.mnuChecks.Size = new System.Drawing.Size(138, 22);
			this.mnuChecks.Tag = "Checks";
			this.mnuChecks.Text = "&Checks";
			//
			//LoadingToolStripMenuItem
			//
			this.LoadingToolStripMenuItem.Name = "LoadingToolStripMenuItem";
			this.LoadingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.LoadingToolStripMenuItem.Text = "Loading...";
			//
			//mnuSubliminals
			//
			this.mnuSubliminals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.LoadingToolStripMenuItem3 });
			this.mnuSubliminals.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.mnuSubliminals.Image = (System.Drawing.Image)resources.GetObject("mnuSubliminals.Image");
			this.mnuSubliminals.Name = "mnuSubliminals";
			this.mnuSubliminals.Size = new System.Drawing.Size(138, 22);
			this.mnuSubliminals.Tag = "Subliminals";
			this.mnuSubliminals.Text = "&Subliminals";
			//
			//LoadingToolStripMenuItem3
			//
			this.LoadingToolStripMenuItem3.Name = "LoadingToolStripMenuItem3";
			this.LoadingToolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
			this.LoadingToolStripMenuItem3.Text = "Loading...";
			//
			//mnuRecordings
			//
			this.mnuRecordings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.LoadingToolStripMenuItem2 });
			this.mnuRecordings.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.mnuRecordings.Image = (System.Drawing.Image)resources.GetObject("mnuRecordings.Image");
			this.mnuRecordings.Name = "mnuRecordings";
			this.mnuRecordings.Size = new System.Drawing.Size(138, 22);
			this.mnuRecordings.Tag = "Recordings";
			this.mnuRecordings.Text = "&Recordings";
			//
			//LoadingToolStripMenuItem2
			//
			this.LoadingToolStripMenuItem2.Name = "LoadingToolStripMenuItem2";
			this.LoadingToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
			this.LoadingToolStripMenuItem2.Text = "Loading...";
			//
			//mnuReadings
			//
			this.mnuReadings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.LoadingToolStripMenuItem1 });
			this.mnuReadings.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.mnuReadings.Image = (System.Drawing.Image)resources.GetObject("mnuReadings.Image");
			this.mnuReadings.Name = "mnuReadings";
			this.mnuReadings.Size = new System.Drawing.Size(138, 22);
			this.mnuReadings.Tag = "Readings";
			this.mnuReadings.Text = "&Readings";
			//
			//LoadingToolStripMenuItem1
			//
			this.LoadingToolStripMenuItem1.Name = "LoadingToolStripMenuItem1";
			this.LoadingToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
			this.LoadingToolStripMenuItem1.Text = "Loading...";
			//
			//ToolStripMenuItem2
			//
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
			//
			//mnuAnnotationPlay
			//
			this.mnuAnnotationPlay.Image = (System.Drawing.Image)resources.GetObject("mnuAnnotationPlay.Image");
			this.mnuAnnotationPlay.Name = "mnuAnnotationPlay";
			this.mnuAnnotationPlay.Size = new System.Drawing.Size(110, 22);
			this.mnuAnnotationPlay.Text = "&Play";
			//
			//mnuAnnotationCopy
			//
			this.mnuAnnotationCopy.Image = (System.Drawing.Image)resources.GetObject("mnuAnnotationCopy.Image");
			this.mnuAnnotationCopy.Name = "mnuAnnotationCopy";
			this.mnuAnnotationCopy.Size = new System.Drawing.Size(110, 22);
			this.mnuAnnotationCopy.Text = "&Copy";
			//
			//mnuAnnotationPaste
			//
			this.mnuAnnotationPaste.Enabled = false;
			this.mnuAnnotationPaste.Image = (System.Drawing.Image)resources.GetObject("mnuAnnotationPaste.Image");
			this.mnuAnnotationPaste.Name = "mnuAnnotationPaste";
			this.mnuAnnotationPaste.Size = new System.Drawing.Size(110, 22);
			this.mnuAnnotationPaste.Text = "&Paste";
			//
			//mnuAnnotationDelete
			//
			this.mnuAnnotationDelete.Image = (System.Drawing.Image)resources.GetObject("mnuAnnotationDelete.Image");
			this.mnuAnnotationDelete.Name = "mnuAnnotationDelete";
			this.mnuAnnotationDelete.Size = new System.Drawing.Size(110, 22);
			this.mnuAnnotationDelete.Text = "&Delete";
			//
			//Label5
			//
			this.Label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label5.Location = new System.Drawing.Point(7, 30);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(82, 21);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "Sleep Cycles";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(640, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(7, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(630, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "REM Cycles";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 19);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Dream";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbCycles
			//
			this.cmbCycles.FormattingEnabled = true;
			this.cmbCycles.Items.AddRange(new object[] {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8"
			});
			this.cmbCycles.Location = new System.Drawing.Point(95, 30);
			this.cmbCycles.Name = "cmbCycles";
			this.cmbCycles.Size = new System.Drawing.Size(38, 21);
			this.cmbCycles.TabIndex = 10;
			this.cmbCycles.Text = "6";
			//
			//txtTime
			//
			this.txtTime.Location = new System.Drawing.Point(346, 31);
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			this.txtTime.Size = new System.Drawing.Size(71, 21);
			this.txtTime.TabIndex = 13;
			this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			Border3DAnnotation1.AllowAnchorMoving = true;
			Border3DAnnotation1.AllowMoving = true;
			Border3DAnnotation1.AllowSelecting = true;
			Border3DAnnotation1.AllowTextEditing = true;
			Border3DAnnotation1.AnchorX = 5;
			Border3DAnnotation1.AnchorY = 50;
			Border3DAnnotation1.AxisXName = "ChartArea1\\rX";
			Border3DAnnotation1.BackColor = System.Drawing.Color.LightSteelBlue;
			Border3DAnnotation1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
			Border3DAnnotation1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
			Border3DAnnotation1.Font = new System.Drawing.Font("Verdana", 8.25f);
			Border3DAnnotation1.ForeColor = System.Drawing.Color.MidnightBlue;
			Border3DAnnotation1.IsMultiline = true;
			Border3DAnnotation1.LineColor = System.Drawing.Color.Empty;
			Border3DAnnotation1.Name = "Border3DAnnotation1";
			Border3DAnnotation1.Text = "Tiesto - Lord of Trance";
			Border3DAnnotation1.YAxisName = "ChartArea1\\rY";
			VerticalLineAnnotation1.AllowMoving = true;
			VerticalLineAnnotation1.AnchorX = 15;
			VerticalLineAnnotation1.AnchorY = 10;
			VerticalLineAnnotation1.IsInfinitive = true;
			VerticalLineAnnotation1.LineColor = System.Drawing.Color.DarkCyan;
			VerticalLineAnnotation1.LineWidth = 5;
			VerticalLineAnnotation1.Name = "VerticalLineAnnotation1";
			VerticalLineAnnotation1.ShadowOffset = 1;
			VerticalLineAnnotation1.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round;
			LineAnnotation1.Name = "LineAnnotation1";
			LineAnnotation1.Width = 3;
			VerticalLineAnnotation2.AnchorX = 1;
			VerticalLineAnnotation2.AnchorY = 1;
			VerticalLineAnnotation2.LineColor = System.Drawing.Color.SteelBlue;
			VerticalLineAnnotation2.LineWidth = 2;
			VerticalLineAnnotation2.Name = "objNow";
			VerticalLineAnnotation2.X = 12;
			VerticalLineAnnotation2.Y = 50;
			ArrowAnnotation1.ArrowSize = 7;
			ArrowAnnotation1.Name = "ArrowAnnotation1";
			ArrowAnnotation1.X = 50;
			ArrowAnnotation1.Y = 20;
			ImageAnnotation1.AllowMoving = true;
			ImageAnnotation1.AllowSelecting = true;
			ImageAnnotation1.AllowTextEditing = true;
			ImageAnnotation1.Image = "C:\\lucidcode\\Development\\lucidcode\\ico\\Lightened Dream\\Action.Forward.bmp";
			ImageAnnotation1.ImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
			ImageAnnotation1.Name = "ImageAnnotation1";
			ImageAnnotation1.ToolTip = "xxx";
			CalloutAnnotation1.AllowTextEditing = true;
			CalloutAnnotation1.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
			CalloutAnnotation1.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			CalloutAnnotation1.ForeColor = System.Drawing.Color.SteelBlue;
			CalloutAnnotation1.LineColor = System.Drawing.Color.LightSteelBlue;
			CalloutAnnotation1.Name = "objCalloutCloud";
			CalloutAnnotation1.ShadowColor = System.Drawing.Color.SteelBlue;
			CalloutAnnotation1.ShadowOffset = 1;
			CalloutAnnotation1.Text = "Dj Tiesto - Lord of Trance";
			CalloutAnnotation1.X = 20;
			CalloutAnnotation1.Y = 20;
			CalloutAnnotation2.AllowAnchorMoving = true;
			CalloutAnnotation2.BackColor = System.Drawing.Color.LightYellow;
			CalloutAnnotation2.CalloutAnchorCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
			CalloutAnnotation2.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
			CalloutAnnotation2.ClipToChartArea = "ChartArea1";
			CalloutAnnotation2.IsMultiline = true;
			CalloutAnnotation2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			CalloutAnnotation2.LineWidth = 4;
			CalloutAnnotation2.Name = "CalloutAnnotation3";
			CalloutAnnotation2.ShadowOffset = 2;
			CalloutAnnotation2.Text = "xxxxxxxxxx bhh hh";
			CalloutAnnotation2.X = 40;
			CalloutAnnotation2.Y = 10;
			TextAnnotation1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			TextAnnotation1.IsMultiline = true;
			TextAnnotation1.Name = "TextAnnotation1";
			TextAnnotation1.ShadowOffset = 2;
			TextAnnotation1.Text = "TextAnnotation1";
			TextAnnotation1.X = 20;
			TextAnnotation1.Y = 10;
			PolygonAnnotation1.Name = "PolygonAnnotation1";
			AnnotationPathPoint1.PointType = Convert.ToByte(0);
			AnnotationPathPoint1.X = 5f;
			AnnotationPathPoint1.Y = 5f;
			AnnotationPathPoint2.X = 40f;
			AnnotationPathPoint2.Y = 40f;
			PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint1);
			PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint2);
			PolylineAnnotation1.GraphicsPathPoints.Add(AnnotationPathPoint3);
			PolylineAnnotation1.Name = "PolylineAnnotation1";
			this.graph.Annotations.Add(Border3DAnnotation1);
			this.graph.Annotations.Add(VerticalLineAnnotation1);
			this.graph.Annotations.Add(LineAnnotation1);
			this.graph.Annotations.Add(VerticalLineAnnotation2);
			this.graph.Annotations.Add(ArrowAnnotation1);
			this.graph.Annotations.Add(ImageAnnotation1);
			this.graph.Annotations.Add(CalloutAnnotation1);
			this.graph.Annotations.Add(CalloutAnnotation2);
			this.graph.Annotations.Add(TextAnnotation1);
			this.graph.Annotations.Add(PolygonAnnotation1);
			this.graph.Annotations.Add(PolylineAnnotation1);
			this.graph.BackColor = System.Drawing.Color.LightSteelBlue;
			this.graph.BorderlineWidth = 0;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.Inclination = 10;
			ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea1.Area3DStyle.PointDepth = 300;
			ChartArea1.Area3DStyle.PointGapDepth = 0;
			ChartArea1.Area3DStyle.Rotation = 10;
			ChartArea1.Area3DStyle.WallWidth = 0;
			ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisX.IsLabelAutoFit = false;
			ChartArea1.AxisX.LabelStyle.Angle = 90;
			ChartArea1.AxisX.LabelStyle.Interval = 0;
			ChartArea1.AxisX.LineWidth = 0;
			ChartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
			CustomLabel1.Text = "x";
			CustomLabel2.Text = "x";
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1);
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2);
			ChartArea1.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
			ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.BackColor = System.Drawing.Color.White;
			ChartArea1.Name = "ChartArea1";
			ChartArea1.ShadowColor = System.Drawing.Color.White;
			this.graph.ChartAreas.Add(ChartArea1);
			this.graph.Location = new System.Drawing.Point(3, 3);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.Font = new System.Drawing.Font("Verdana", 8.25f);
			Series1.LabelAngle = 90;
			Series1.LabelBorderWidth = 0;
			Series1.MarkerBorderWidth = 0;
			Series1.Name = "DreamSeries";
			Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.graph.Series.Add(Series1);
			this.graph.Size = new System.Drawing.Size(634, 364);
			this.graph.TabIndex = 2;
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Panel3D2.Controls.Add(this.lstItems);
			this.Panel3D2.Controls.Add(this.Label1);
			this.Panel3D2.Controls.Add(this.cmbCycleLength);
			this.Panel3D2.Controls.Add(this.Label3);
			this.Panel3D2.Controls.Add(this.Label5);
			this.Panel3D2.Controls.Add(this.txtDescription);
			this.Panel3D2.Controls.Add(this.txtTitle);
			this.Panel3D2.Controls.Add(this.Label4);
			this.Panel3D2.Controls.Add(this.cmbCycles);
			this.Panel3D2.Controls.Add(this.Label11);
			this.Panel3D2.Controls.Add(this.txtTime);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 104);
			this.Panel3D2.TabIndex = 8;
			//
			//lstItems
			//
			this.lstItems.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader3,
				this.ColumnHeader2
			});
			this.lstItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
				ListViewItem1,
				ListViewItem2,
				ListViewItem3,
				ListViewItem4,
				ListViewItem5,
				ListViewItem6
			});
			this.lstItems.Location = new System.Drawing.Point(474, 31);
			this.lstItems.MultiSelect = false;
			this.lstItems.Name = "lstItems";
			this.lstItems.Size = new System.Drawing.Size(163, 70);
			this.lstItems.SmallImageList = this.lstImg;
			this.lstItems.TabIndex = 1;
			this.lstItems.UseCompatibleStateImageBehavior = false;
			this.lstItems.View = System.Windows.Forms.View.Details;
			this.lstItems.Visible = false;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Time";
			this.ColumnHeader1.Width = 97;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Type";
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "File";
			this.ColumnHeader2.Width = 249;
			//
			//Label1
			//
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(296, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(44, 21);
			this.Label1.TabIndex = 34;
			this.Label1.Text = "Time";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbCycleLength
			//
			this.cmbCycleLength.FormattingEnabled = true;
			this.cmbCycleLength.Items.AddRange(new object[] {
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21",
				"22",
				"23",
				"24",
				"25",
				"26",
				"27",
				"28",
				"29",
				"30",
				"31",
				"32",
				"33",
				"34",
				"35",
				"36",
				"37",
				"38",
				"39",
				"40",
				"41",
				"42",
				"43",
				"44",
				"45",
				"46",
				"47",
				"48",
				"49",
				"50",
				"51",
				"52",
				"53",
				"54",
				"55",
				"56",
				"57",
				"58",
				"59",
				"60",
				"61",
				"62",
				"63",
				"64",
				"65",
				"66",
				"67",
				"68",
				"69",
				"70",
				"71",
				"72",
				"73",
				"74",
				"75",
				"76",
				"77",
				"78",
				"79",
				"80",
				"81",
				"82",
				"83",
				"84",
				"85",
				"86",
				"87",
				"88",
				"89",
				"90",
				"91",
				"92",
				"93",
				"94",
				"95",
				"96",
				"97",
				"98",
				"99",
				"100",
				"101",
				"102",
				"103",
				"104",
				"105",
				"106",
				"107",
				"108",
				"109",
				"110",
				"111",
				"112",
				"113",
				"114",
				"115",
				"116",
				"117",
				"118",
				"119",
				"120"
			});
			this.cmbCycleLength.Location = new System.Drawing.Point(232, 31);
			this.cmbCycleLength.Name = "cmbCycleLength";
			this.cmbCycleLength.Size = new System.Drawing.Size(44, 21);
			this.cmbCycleLength.TabIndex = 10;
			this.cmbCycleLength.Text = "60";
			//
			//Label3
			//
			this.Label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label3.Location = new System.Drawing.Point(144, 30);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(82, 21);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Cycle Length";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtDescription
			//
			this.txtDescription.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtDescription.Location = new System.Drawing.Point(94, 78);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(543, 21);
			this.txtDescription.TabIndex = 32;
			//
			//txtTitle
			//
			this.txtTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtTitle.Location = new System.Drawing.Point(94, 54);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(543, 21);
			this.txtTitle.TabIndex = 32;
			//
			//Label4
			//
			this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label4.Location = new System.Drawing.Point(8, 77);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(79, 21);
			this.Label4.TabIndex = 33;
			this.Label4.Text = "Description";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label11
			//
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(8, 53);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(79, 21);
			this.Label11.TabIndex = 33;
			this.Label11.Text = "Title";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//objPlayer
			//
			this.objPlayer.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.objPlayer.Enabled = true;
			this.objPlayer.Location = new System.Drawing.Point(217, 28);
			this.objPlayer.Name = "objPlayer";
			this.objPlayer.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("objPlayer.OcxState");
			this.objPlayer.Size = new System.Drawing.Size(284, 45);
			this.objPlayer.TabIndex = 22;
			this.objPlayer.Visible = false;
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Panel3D1.Controls.Add(this.graph);
			this.Panel3D1.Controls.Add(this.objPlayer);
			this.Panel3D1.Location = new System.Drawing.Point(0, 110);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(640, 370);
			this.Panel3D1.TabIndex = 9;
			//
			//objOpenFileDialog
			//
			this.objOpenFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*";
			this.objOpenFileDialog.Title = "REM Cycles - Import";
			//
			//REMCyclesControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.Name = "REMCyclesControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.mnuAnnotation.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.objPlayer).EndInit();
			this.Panel3D1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ImageList lstImg;
		internal System.Windows.Forms.ContextMenuStrip mnuAnnotation;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuAnnotationAdd;
		internal System.Windows.Forms.ToolStripMenuItem mnuAnnotationAdd {
			get { return withEventsField_mnuAnnotationAdd; }
			set {
				if (withEventsField_mnuAnnotationAdd != null) {
					withEventsField_mnuAnnotationAdd.Click -= mnuAnnotationAdd_Click;
				}
				withEventsField_mnuAnnotationAdd = value;
				if (withEventsField_mnuAnnotationAdd != null) {
					withEventsField_mnuAnnotationAdd.Click += mnuAnnotationAdd_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuAnnotationCopy;
		internal System.Windows.Forms.ToolStripMenuItem mnuAnnotationCopy {
			get { return withEventsField_mnuAnnotationCopy; }
			set {
				if (withEventsField_mnuAnnotationCopy != null) {
					withEventsField_mnuAnnotationCopy.Click -= mnuAnnotationCopy_Click;
				}
				withEventsField_mnuAnnotationCopy = value;
				if (withEventsField_mnuAnnotationCopy != null) {
					withEventsField_mnuAnnotationCopy.Click += mnuAnnotationCopy_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuAnnotationPaste;
		internal System.Windows.Forms.ToolStripMenuItem mnuAnnotationPaste {
			get { return withEventsField_mnuAnnotationPaste; }
			set {
				if (withEventsField_mnuAnnotationPaste != null) {
					withEventsField_mnuAnnotationPaste.Click -= mnuAnnotationPaste_Click;
				}
				withEventsField_mnuAnnotationPaste = value;
				if (withEventsField_mnuAnnotationPaste != null) {
					withEventsField_mnuAnnotationPaste.Click += mnuAnnotationPaste_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuAnnotationDelete;
		internal System.Windows.Forms.ToolStripMenuItem mnuAnnotationDelete {
			get { return withEventsField_mnuAnnotationDelete; }
			set {
				if (withEventsField_mnuAnnotationDelete != null) {
					withEventsField_mnuAnnotationDelete.Click -= mnuAnnotationDelete_Click;
				}
				withEventsField_mnuAnnotationDelete = value;
				if (withEventsField_mnuAnnotationDelete != null) {
					withEventsField_mnuAnnotationDelete.Click += mnuAnnotationDelete_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		private System.Windows.Forms.ComboBox withEventsField_cmbCycles;
		internal System.Windows.Forms.ComboBox cmbCycles {
			get { return withEventsField_cmbCycles; }
			set {
				if (withEventsField_cmbCycles != null) {
					withEventsField_cmbCycles.SelectedIndexChanged -= cmbCycles_SelectedIndexChanged;
				}
				withEventsField_cmbCycles = value;
				if (withEventsField_cmbCycles != null) {
					withEventsField_cmbCycles.SelectedIndexChanged += cmbCycles_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.DataVisualization.Charting.Chart withEventsField_graph;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graph {
			get { return withEventsField_graph; }
			set {
				if (withEventsField_graph != null) {
					withEventsField_graph.AnnotationPlaced -= graph_AnnotationPlaced;
					withEventsField_graph.AnnotationPositionChanging -= graph_AnnotationPositionChanging;
					withEventsField_graph.MouseDown -= graph_MouseDown;
					withEventsField_graph.MouseMove -= graph_MouseMove;
					withEventsField_graph.DragDrop -= graph_DragDrop;
					withEventsField_graph.DragEnter -= graph_DragEnter;
					withEventsField_graph.DragOver -= graph_DragOver;
					withEventsField_graph.AnnotationPositionChanged -= graph_AnnotationPositionChanged;
					withEventsField_graph.KeyDown -= graph_KeyDown;
				}
				withEventsField_graph = value;
				if (withEventsField_graph != null) {
					withEventsField_graph.AnnotationPlaced += graph_AnnotationPlaced;
					withEventsField_graph.AnnotationPositionChanging += graph_AnnotationPositionChanging;
					withEventsField_graph.MouseDown += graph_MouseDown;
					withEventsField_graph.MouseMove += graph_MouseMove;
					withEventsField_graph.DragDrop += graph_DragDrop;
					withEventsField_graph.DragEnter += graph_DragEnter;
					withEventsField_graph.DragOver += graph_DragOver;
					withEventsField_graph.AnnotationPositionChanged += graph_AnnotationPositionChanged;
					withEventsField_graph.KeyDown += graph_KeyDown;
				}
			}
		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal AxWMPLib.AxWindowsMediaPlayer objPlayer;
		internal System.Windows.Forms.ListView lstItems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.Label Label3;
		private System.Windows.Forms.ComboBox withEventsField_cmbCycleLength;
		internal System.Windows.Forms.ComboBox cmbCycleLength {
			get { return withEventsField_cmbCycleLength; }
			set {
				if (withEventsField_cmbCycleLength != null) {
					withEventsField_cmbCycleLength.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
				}
				withEventsField_cmbCycleLength = value;
				if (withEventsField_cmbCycleLength != null) {
					withEventsField_cmbCycleLength.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label1;
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal System.Windows.Forms.TextBox txtDescription;
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuChecks;
		internal System.Windows.Forms.ToolStripMenuItem mnuChecks {
			get { return withEventsField_mnuChecks; }
			set {
				if (withEventsField_mnuChecks != null) {
					withEventsField_mnuChecks.DropDownOpening -= mnuLucidity_DropDownOpening;
				}
				withEventsField_mnuChecks = value;
				if (withEventsField_mnuChecks != null) {
					withEventsField_mnuChecks.DropDownOpening += mnuLucidity_DropDownOpening;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuReadings;
		internal System.Windows.Forms.ToolStripMenuItem mnuReadings {
			get { return withEventsField_mnuReadings; }
			set {
				if (withEventsField_mnuReadings != null) {
					withEventsField_mnuReadings.DropDownOpening -= mnuLucidity_DropDownOpening;
				}
				withEventsField_mnuReadings = value;
				if (withEventsField_mnuReadings != null) {
					withEventsField_mnuReadings.DropDownOpening += mnuLucidity_DropDownOpening;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuRecordings;
		internal System.Windows.Forms.ToolStripMenuItem mnuRecordings {
			get { return withEventsField_mnuRecordings; }
			set {
				if (withEventsField_mnuRecordings != null) {
					withEventsField_mnuRecordings.DropDownOpening -= mnuLucidity_DropDownOpening;
				}
				withEventsField_mnuRecordings = value;
				if (withEventsField_mnuRecordings != null) {
					withEventsField_mnuRecordings.DropDownOpening += mnuLucidity_DropDownOpening;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem LoadingToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LoadingToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem LoadingToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuSubliminals;
		internal System.Windows.Forms.ToolStripMenuItem mnuSubliminals {
			get { return withEventsField_mnuSubliminals; }
			set {
				if (withEventsField_mnuSubliminals != null) {
					withEventsField_mnuSubliminals.DropDownOpening -= mnuLucidity_DropDownOpening;
				}
				withEventsField_mnuSubliminals = value;
				if (withEventsField_mnuSubliminals != null) {
					withEventsField_mnuSubliminals.DropDownOpening += mnuLucidity_DropDownOpening;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem LoadingToolStripMenuItem3;
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
		internal System.Windows.Forms.OpenFileDialog objOpenFileDialog;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuAnnotationPlay;
		internal System.Windows.Forms.ToolStripMenuItem mnuAnnotationPlay {
			get { return withEventsField_mnuAnnotationPlay; }
			set {
				if (withEventsField_mnuAnnotationPlay != null) {
					withEventsField_mnuAnnotationPlay.Click -= mnuAnnotationPlay_Click;
				}
				withEventsField_mnuAnnotationPlay = value;
				if (withEventsField_mnuAnnotationPlay != null) {
					withEventsField_mnuAnnotationPlay.Click += mnuAnnotationPlay_Click;
				}
			}
		}
		private System.Windows.Forms.Timer withEventsField_tmrWatch;
		public System.Windows.Forms.Timer tmrWatch {
			get { return withEventsField_tmrWatch; }
			set {
				if (withEventsField_tmrWatch != null) {
					withEventsField_tmrWatch.Tick -= tmrWatch_Tick;
				}
				withEventsField_tmrWatch = value;
				if (withEventsField_tmrWatch != null) {
					withEventsField_tmrWatch.Tick += tmrWatch_Tick;
				}
			}
		}

		public System.Windows.Forms.TextBox txtTitle;
	}
}
