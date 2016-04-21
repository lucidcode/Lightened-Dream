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
	partial class MonthListControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.lstDreams = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.Inclination = 10;
			ChartArea1.Area3DStyle.IsClustered = true;
			ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea1.Area3DStyle.PointDepth = 200;
			ChartArea1.Area3DStyle.PointGapDepth = 0;
			ChartArea1.Area3DStyle.Rotation = 10;
			ChartArea1.Area3DStyle.WallWidth = 0;
			CustomLabel1.FromPosition = 0.5;
			CustomLabel1.Text = "2009/11";
			CustomLabel1.ToPosition = 1.5;
			CustomLabel2.FromPosition = 1.5;
			CustomLabel2.Text = "2009/12";
			CustomLabel2.ToPosition = 2.5;
			ChartArea1.AxisX.CustomLabels.Add(CustomLabel1);
			ChartArea1.AxisX.CustomLabels.Add(CustomLabel2);
			ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisX.IsLabelAutoFit = false;
			ChartArea1.AxisX.LabelStyle.Angle = 90;
			ChartArea1.AxisX.LabelStyle.Interval = 0;
			CustomLabel3.Text = "x";
			CustomLabel4.Text = "x";
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel3);
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel4);
			ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.IsStartedFromZero = false;
			ChartArea1.AxisY2.LabelStyle.Enabled = false;
			ChartArea1.AxisY2.MajorGrid.Enabled = false;
			ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea1.AxisY2.MajorTickMark.Enabled = false;
			ChartArea1.AxisY2.Maximum = 1200;
			ChartArea1.AxisY2.Minimum = -1200;
			ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea1.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea1.BackColor = System.Drawing.Color.White;
			ChartArea1.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea1.BackSecondaryColor = System.Drawing.Color.White;
			ChartArea1.BorderColor = System.Drawing.Color.White;
			ChartArea1.Name = "ChartArea1";
			ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)));
			this.graph.ChartAreas.Add(ChartArea1);
			this.graph.Location = new System.Drawing.Point(3, 30);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series1.Name = "Series2";
			Series2.ChartArea = "ChartArea1";
			Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series2.Name = "Series3";
			this.graph.Series.Add(Series1);
			this.graph.Series.Add(Series2);
			this.graph.Size = new System.Drawing.Size(634, 447);
			this.graph.TabIndex = 1;
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.lstDreams);
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.TabIndex = 8;
			//
			//lstDreams
			//
			this.lstDreams.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstDreams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5
			});
			this.lstDreams.FullRowSelect = true;
			this.lstDreams.Location = new System.Drawing.Point(191, 30);
			this.lstDreams.MultiSelect = false;
			this.lstDreams.Name = "lstDreams";
			this.lstDreams.Size = new System.Drawing.Size(370, 205);
			this.lstDreams.TabIndex = 2;
			this.lstDreams.UseCompatibleStateImageBehavior = false;
			this.lstDreams.View = System.Windows.Forms.View.Details;
			this.lstDreams.Visible = false;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Date";
			this.ColumnHeader1.Width = 124;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "Title";
			this.ColumnHeader2.Width = 72;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Words";
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "Sleep";
			//
			//ColumnHeader5
			//
			this.ColumnHeader5.Text = "Awake";
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
			this.lblTitle.Text = "Dreams - Month";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 19);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Dream";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//MonthListControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor;
			this.Name = "MonthListControl";
			this.Size = new System.Drawing.Size(640, 480);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		private System.Windows.Forms.DataVisualization.Charting.Chart withEventsField_graph;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graph {
			get { return withEventsField_graph; }
			set {
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseMove -= graph_MouseMove;
					withEventsField_graph.MouseDown -= graph_MouseDown;
				}
				withEventsField_graph = value;
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseMove += graph_MouseMove;
					withEventsField_graph.MouseDown += graph_MouseDown;
				}
			}
		}
		internal System.Windows.Forms.ListView lstDreams;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;

		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
	}
}
