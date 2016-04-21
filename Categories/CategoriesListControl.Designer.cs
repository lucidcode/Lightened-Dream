using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Categories
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class CategoriesListControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint DataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0, 1.0);
			System.Windows.Forms.DataVisualization.Charting.DataPoint DataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0, 2.0);
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint DataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0, 1.0);
			System.Windows.Forms.DataVisualization.Charting.DataPoint DataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0, 2.0);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.graphDozen = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lstCategories = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblDescription = new System.Windows.Forms.Label();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graphDozen).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.graphDozen);
			this.Panel3D2.Controls.Add(this.lstCategories);
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.lblDescription);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.TabIndex = 7;
			//
			//graphDozen
			//
			this.graphDozen.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graphDozen.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.Inclination = 10;
			ChartArea1.Area3DStyle.PointDepth = 50;
			ChartArea1.Area3DStyle.PointGapDepth = 50;
			ChartArea1.Area3DStyle.Rotation = 10;
			ChartArea1.Area3DStyle.WallWidth = 0;
			ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisX.LabelStyle.Interval = 0.0;
			ChartArea1.AxisX.MajorGrid.Enabled = false;
			ChartArea1.AxisX.MajorTickMark.Enabled = false;
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1);
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2);
			ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.BackColor = System.Drawing.Color.LightSteelBlue;
			ChartArea1.Name = "ChartArea1";
			this.graphDozen.ChartAreas.Add(ChartArea1);
			this.graphDozen.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.graphDozen.Location = new System.Drawing.Point(3, 30);
			this.graphDozen.Name = "graphDozen";
			this.graphDozen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			Series1.ChartArea = "ChartArea1";
			Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
			Series1.CustomProperties = "BarLabelStyle=Outside";
			Series1.Font = new System.Drawing.Font("Verdana", 8.25f);
			Series1.LabelForeColor = System.Drawing.Color.MidnightBlue;
			Series1.Name = "DreamSeries";
			DataPoint1.AxisLabel = "yyy";
			DataPoint2.AxisLabel = "xxx";
			DataPoint2.Label = "x";
			DataPoint2.LegendText = "xx";
			DataPoint2.ToolTip = "xx";
			Series1.Points.Add(DataPoint1);
			Series1.Points.Add(DataPoint2);
			Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
			Series1.SmartLabelStyle.MaxMovingDistance = 50.0;
			Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			this.graphDozen.Series.Add(Series1);
			this.graphDozen.Size = new System.Drawing.Size(634, 447);
			this.graphDozen.TabIndex = 24;
			this.graphDozen.Visible = false;
			//
			//lstCategories
			//
			this.lstCategories.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.lstCategories.Location = new System.Drawing.Point(435, 49);
			this.lstCategories.MultiSelect = false;
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(172, 167);
			this.lstCategories.TabIndex = 1;
			this.lstCategories.UseCompatibleStateImageBehavior = false;
			this.lstCategories.View = System.Windows.Forms.View.Details;
			this.lstCategories.Visible = false;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Category";
			this.ColumnHeader1.Width = 124;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "Entries";
			this.ColumnHeader2.Width = 74;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor;
			ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.AxisX.LabelStyle.Interval = 0.0;
			ChartArea2.AxisX.Title = "Dreams";
			CustomLabel3.Text = "x";
			CustomLabel4.Text = "x";
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel3);
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel4);
			ChartArea2.AxisX2.Title = "x";
			ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.BackColor = System.Drawing.Color.LightSteelBlue;
			ChartArea2.Name = "ChartArea1";
			this.graph.ChartAreas.Add(ChartArea2);
			this.graph.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.graph.Location = new System.Drawing.Point(3, 30);
			this.graph.Name = "graph";
			this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			Series2.ChartArea = "ChartArea1";
			Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			Series2.Font = new System.Drawing.Font("Verdana", 8.25f);
			Series2.Name = "DreamSeries";
			DataPoint3.AxisLabel = "yyy";
			DataPoint4.AxisLabel = "xxx";
			DataPoint4.Label = "x";
			DataPoint4.LegendText = "xx";
			DataPoint4.ToolTip = "xx";
			Series2.Points.Add(DataPoint3);
			Series2.Points.Add(DataPoint4);
			Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			this.graph.Series.Add(Series2);
			this.graph.Size = new System.Drawing.Size(634, 447);
			this.graph.TabIndex = 1;
			//
			//lblDescription
			//
			this.lblDescription.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblDescription.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblDescription.Location = new System.Drawing.Point(8, 27);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(621, 31);
			this.lblDescription.TabIndex = 23;
			this.lblDescription.Text = "Dream";
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.lblType);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(640, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(8, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(628, 19);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Categories";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblType
			//
			this.lblType.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblType.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold);
			this.lblType.ForeColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.TitleForeColor;
			this.lblType.Location = new System.Drawing.Point(8, 3);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(90, 19);
			this.lblType.TabIndex = 3;
			this.lblType.Text = "Category";
			this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//CategoriesListControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.FormForeColor;
			this.Name = "CategoriesListControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graphDozen).EndInit();
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		public System.Windows.Forms.Label lblDescription;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblType;
		internal System.Windows.Forms.ListView lstCategories;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
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
		private System.Windows.Forms.DataVisualization.Charting.Chart withEventsField_graphDozen;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graphDozen {
			get { return withEventsField_graphDozen; }
			set {
				if (withEventsField_graphDozen != null) {
					withEventsField_graphDozen.MouseDown -= graphDozen_MouseDown;
					withEventsField_graphDozen.MouseMove -= graphDozen_MouseMove;
				}
				withEventsField_graphDozen = value;
				if (withEventsField_graphDozen != null) {
					withEventsField_graphDozen.MouseDown += graphDozen_MouseDown;
					withEventsField_graphDozen.MouseMove += graphDozen_MouseMove;
				}
			}

		}
	}
}
