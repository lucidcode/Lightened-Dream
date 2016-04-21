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
	partial class RealityCheckControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.ListViewItem ListViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
				"00:30",
				"DJ Tiesto - Lord of Trance"
			}, 0);
			System.Windows.Forms.ListViewItem ListViewItem2 = new System.Windows.Forms.ListViewItem("02:00");
			System.Windows.Forms.ListViewItem ListViewItem3 = new System.Windows.Forms.ListViewItem("03:30");
			System.Windows.Forms.ListViewItem ListViewItem4 = new System.Windows.Forms.ListViewItem("05:00");
			System.Windows.Forms.ListViewItem ListViewItem5 = new System.Windows.Forms.ListViewItem("06:30");
			System.Windows.Forms.ListViewItem ListViewItem6 = new System.Windows.Forms.ListViewItem("08:00");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealityCheckControl));
			System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation Border3DAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.Border3DAnnotation();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.cmbCycles = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.dtStart = new System.Windows.Forms.DateTimePicker();
			this.Label4 = new System.Windows.Forms.Label();
			this.ListView1 = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//cmbCycles
			//
			this.cmbCycles.FormattingEnabled = true;
			this.cmbCycles.Items.AddRange(new object[] {
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8"
			});
			this.cmbCycles.Location = new System.Drawing.Point(378, 27);
			this.cmbCycles.Name = "cmbCycles";
			this.cmbCycles.Size = new System.Drawing.Size(96, 21);
			this.cmbCycles.TabIndex = 10;
			this.cmbCycles.Text = "6";
			//
			//Label5
			//
			this.Label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label5.Location = new System.Drawing.Point(244, 27);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(128, 21);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "Cycles";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//dtStart
			//
			this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtStart.Location = new System.Drawing.Point(142, 27);
			this.dtStart.Name = "dtStart";
			this.dtStart.Size = new System.Drawing.Size(96, 21);
			this.dtStart.TabIndex = 5;
			this.dtStart.Value = new System.DateTime(2009, 12, 2, 23, 0, 0, 0);
			//
			//Label4
			//
			this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label4.Location = new System.Drawing.Point(8, 27);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(128, 21);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Start Time";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ListView1
			//
			this.ListView1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
				ListViewItem1,
				ListViewItem2,
				ListViewItem3,
				ListViewItem4,
				ListViewItem5,
				ListViewItem6
			});
			this.ListView1.Location = new System.Drawing.Point(9, 51);
			this.ListView1.MultiSelect = false;
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new System.Drawing.Size(619, 174);
			this.ListView1.SmallImageList = this.lstImg;
			this.ListView1.TabIndex = 1;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = System.Windows.Forms.View.Details;
			this.ListView1.Visible = false;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Time";
			this.ColumnHeader1.Width = 97;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "File";
			this.ColumnHeader2.Width = 249;
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImg.Images.SetKeyName(0, "Sounds.ico");
			//
			//Panel3D2
			//
			this.Panel3D2.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.cmbCycles);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Controls.Add(this.Label5);
			this.Panel3D2.Controls.Add(this.dtStart);
			this.Panel3D2.Controls.Add(this.Label4);
			this.Panel3D2.Controls.Add(this.ListView1);
			this.Panel3D2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.TabIndex = 8;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			Border3DAnnotation1.AllowAnchorMoving = true;
			Border3DAnnotation1.AllowMoving = true;
			Border3DAnnotation1.AllowSelecting = true;
			Border3DAnnotation1.AllowTextEditing = true;
			Border3DAnnotation1.BackColor = System.Drawing.Color.LightSteelBlue;
			Border3DAnnotation1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
			Border3DAnnotation1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
			Border3DAnnotation1.Font = new System.Drawing.Font("Verdana", 8.25f);
			Border3DAnnotation1.ForeColor = System.Drawing.Color.MidnightBlue;
			Border3DAnnotation1.IsMultiline = true;
			Border3DAnnotation1.LineColor = System.Drawing.Color.Empty;
			Border3DAnnotation1.Name = "Border3DAnnotation1";
			Border3DAnnotation1.Text = "Tiesto - Lord of Trance";
			this.graph.Annotations.Add(Border3DAnnotation1);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			this.graph.BorderlineWidth = 0;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.IsRightAngleAxes = false;
			ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea1.Area3DStyle.Rotation = 0;
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
			this.graph.Location = new System.Drawing.Point(3, 110);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
			Series1.Name = "Series2";
			Series1.YValuesPerPoint = 6;
			Series2.ChartArea = "ChartArea1";
			Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			Series2.Font = new System.Drawing.Font("Verdana", 8.25f);
			Series2.LabelAngle = 90;
			Series2.LabelBorderWidth = 0;
			Series2.MarkerBorderWidth = 0;
			Series2.Name = "DreamSeries";
			Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.graph.Series.Add(Series1);
			this.graph.Series.Add(Series2);
			this.graph.Size = new System.Drawing.Size(634, 342);
			this.graph.TabIndex = 11;
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
			this.lblTitle.Text = "Reality Check";
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
			//RealityCheckControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Panel3D2);
			this.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.Name = "RealityCheckControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ListView ListView1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ImageList lstImg;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.DateTimePicker dtStart;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox cmbCycles;

		internal System.Windows.Forms.DataVisualization.Charting.Chart graph;
	}
}
