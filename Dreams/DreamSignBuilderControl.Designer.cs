using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Dreams
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class DreamSignBuilderControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series Series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DreamSignBuilderControl));
			this.lstDreams = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.pnlSearching = new lucidcode.Controls.Panel3D();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.mnuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuAddTo = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuIgnore = new System.Windows.Forms.ToolStripMenuItem();
			this.tmrDreamSigns = new System.Windows.Forms.Timer(this.components);
			this.tmrSearching = new System.Windows.Forms.Timer(this.components);
			this.tmrDreamTypes = new System.Windows.Forms.Timer(this.components);
			this.CategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Panel3D2.SuspendLayout();
			this.pnlSearching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Chart1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D4.SuspendLayout();
			this.mnuCategories.SuspendLayout();
			this.SuspendLayout();
			//
			//lstDreams
			//
			this.lstDreams.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstDreams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3
			});
			this.lstDreams.FullRowSelect = true;
			this.lstDreams.Location = new System.Drawing.Point(200, 25);
			this.lstDreams.MultiSelect = false;
			this.lstDreams.Name = "lstDreams";
			this.lstDreams.Size = new System.Drawing.Size(226, 244);
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
			this.ColumnHeader2.Width = 296;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Words";
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.Panel3D2.Controls.Add(this.pnlSearching);
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.lstDreams);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.TabIndex = 8;
			//
			//pnlSearching
			//
			this.pnlSearching.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlSearching.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.pnlSearching.Controls.Add(this.Chart1);
			this.pnlSearching.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlSearching.Location = new System.Drawing.Point(3, 438);
			this.pnlSearching.Name = "pnlSearching";
			this.pnlSearching.Size = new System.Drawing.Size(634, 39);
			this.pnlSearching.TabIndex = 19;
			//
			//Chart1
			//
			this.Chart1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Chart1.BackColor = System.Drawing.Color.Transparent;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.Inclination = 10;
			ChartArea1.Area3DStyle.IsClustered = true;
			ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea1.Area3DStyle.PointDepth = 200;
			ChartArea1.Area3DStyle.PointGapDepth = 0;
			ChartArea1.Area3DStyle.Rotation = 10;
			ChartArea1.Area3DStyle.WallWidth = 0;
			ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisX.IsLabelAutoFit = false;
			ChartArea1.AxisX.LabelStyle.Angle = 90;
			ChartArea1.AxisX.LabelStyle.Enabled = false;
			ChartArea1.AxisX.LabelStyle.Interval = 0.0;
			ChartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
			ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			ChartArea1.AxisX.LineWidth = 0;
			ChartArea1.AxisX.MajorGrid.Enabled = false;
			ChartArea1.AxisX.MajorGrid.LineWidth = 0;
			ChartArea1.AxisX.MajorTickMark.Enabled = false;
			ChartArea1.AxisX.MajorTickMark.LineWidth = 0;
			ChartArea1.AxisX.MajorTickMark.Size = 0f;
			ChartArea1.AxisX.MinorGrid.LineWidth = 0;
			ChartArea1.AxisX.MinorTickMark.LineWidth = 0;
			ChartArea1.AxisX.MinorTickMark.Size = 0f;
			ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			CustomLabel1.Text = "x";
			CustomLabel2.Text = "x";
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel1);
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel2);
			ChartArea1.AxisX2.LineWidth = 0;
			ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisY.LabelStyle.Enabled = false;
			ChartArea1.AxisY.LineWidth = 0;
			ChartArea1.AxisY.MajorGrid.Enabled = false;
			ChartArea1.AxisY.MajorTickMark.Enabled = false;
			ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.LineWidth = 0;
			ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea1.AxisY2.Maximum = 11.0;
			ChartArea1.AxisY2.Minimum = -11.0;
			ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea1.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea1.BackColor = System.Drawing.Color.LightSteelBlue;
			ChartArea1.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
			ChartArea1.BorderColor = System.Drawing.Color.LightSteelBlue;
			ChartArea1.BorderWidth = 0;
			ChartArea1.Name = "ChartArea1";
			ChartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(ChartArea1);
			this.Chart1.Location = new System.Drawing.Point(3, 3);
			this.Chart1.Name = "Chart1";
			Series1.ChartArea = "ChartArea1";
			Series1.Name = "Series1";
			this.Chart1.Series.Add(Series1);
			this.Chart1.Size = new System.Drawing.Size(628, 33);
			this.Chart1.TabIndex = 283;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			ChartArea2.Area3DStyle.Enable3D = true;
			ChartArea2.Area3DStyle.Inclination = 10;
			ChartArea2.Area3DStyle.IsClustered = true;
			ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea2.Area3DStyle.PointGapDepth = 0;
			ChartArea2.Area3DStyle.Rotation = 10;
			ChartArea2.Area3DStyle.WallWidth = 0;
			ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.AxisX.IsLabelAutoFit = false;
			ChartArea2.AxisX.LabelStyle.Angle = 90;
			ChartArea2.AxisX.LabelStyle.Enabled = false;
			ChartArea2.AxisX.LabelStyle.Interval = 0.0;
			ChartArea2.AxisX.MajorGrid.Enabled = false;
			ChartArea2.AxisX.MajorTickMark.Enabled = false;
			CustomLabel3.Text = "x";
			CustomLabel4.Text = "x";
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel3);
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel4);
			ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea2.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea2.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea2.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea2.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea2.AxisY2.Maximum = 11.0;
			ChartArea2.AxisY2.Minimum = -11.0;
			ChartArea2.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea2.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea2.BackColor = System.Drawing.Color.White;
			ChartArea2.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea2.BackSecondaryColor = System.Drawing.Color.White;
			ChartArea2.BorderColor = System.Drawing.Color.White;
			ChartArea2.Name = "ChartArea1";
			ChartArea2.ShadowColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)));
			this.graph.ChartAreas.Add(ChartArea2);
			this.graph.Location = new System.Drawing.Point(3, 25);
			this.graph.Name = "graph";
			Series2.ChartArea = "ChartArea1";
			Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series2.Name = "Series2";
			Series3.ChartArea = "ChartArea1";
			Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series3.Name = "Series3";
			this.graph.Series.Add(Series2);
			this.graph.Series.Add(Series3);
			this.graph.Size = new System.Drawing.Size(634, 407);
			this.graph.TabIndex = 6;
			this.graph.Visible = false;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(640, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(7, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(630, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Dream Signs";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 19);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Dream";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "File.Dream.Search.3.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "File.Dream.Search.Clear.bmp");
			//
			//mnuCategories
			//
			this.mnuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuAddTo,
				this.mnuIgnore
			});
			this.mnuCategories.Name = "mnuCategories";
			this.mnuCategories.Size = new System.Drawing.Size(114, 48);
			//
			//mnuAddTo
			//
			this.mnuAddTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.CategoryMenuItem });
			this.mnuAddTo.Image = (System.Drawing.Image)resources.GetObject("mnuAddTo.Image");
			this.mnuAddTo.Name = "mnuAddTo";
			this.mnuAddTo.Size = new System.Drawing.Size(113, 22);
			this.mnuAddTo.Text = "&Add To";
			//
			//mnuIgnore
			//
			this.mnuIgnore.Name = "mnuIgnore";
			this.mnuIgnore.Size = new System.Drawing.Size(113, 22);
			this.mnuIgnore.Text = "&Ignore";
			//
			//tmrDreamSigns
			//
			//
			//tmrSearching
			//
			this.tmrSearching.Interval = 128;
			//
			//tmrDreamTypes
			//
			//
			//CategoryMenuItem
			//
			this.CategoryMenuItem.Image = (System.Drawing.Image)resources.GetObject("CategoryMenuItem.Image");
			this.CategoryMenuItem.Name = "CategoryMenuItem";
			this.CategoryMenuItem.Size = new System.Drawing.Size(152, 22);
			this.CategoryMenuItem.Text = "Category";
			this.CategoryMenuItem.Visible = false;
			//
			//DreamSignControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor;
			this.Name = "DreamSignControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.ResumeLayout(false);
			this.pnlSearching.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.Chart1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D4.ResumeLayout(false);
			this.mnuCategories.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ListView lstDreams;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		private System.Windows.Forms.ImageList lstImgTlb;
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
		internal System.Windows.Forms.ContextMenuStrip mnuCategories;
		internal System.Windows.Forms.ToolStripMenuItem mnuAddTo;
		private System.Windows.Forms.Timer withEventsField_tmrDreamSigns;
		internal System.Windows.Forms.Timer tmrDreamSigns {
			get { return withEventsField_tmrDreamSigns; }
			set {
				if (withEventsField_tmrDreamSigns != null) {
					withEventsField_tmrDreamSigns.Tick -= tmrDreamSigns_Tick;
				}
				withEventsField_tmrDreamSigns = value;
				if (withEventsField_tmrDreamSigns != null) {
					withEventsField_tmrDreamSigns.Tick += tmrDreamSigns_Tick;
				}
			}
		}
		internal lucidcode.Controls.Panel3D pnlSearching;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Timer withEventsField_tmrSearching;
		internal System.Windows.Forms.Timer tmrSearching {
			get { return withEventsField_tmrSearching; }
			set {
				if (withEventsField_tmrSearching != null) {
					withEventsField_tmrSearching.Tick -= tmrSearching_Tick;
				}
				withEventsField_tmrSearching = value;
				if (withEventsField_tmrSearching != null) {
					withEventsField_tmrSearching.Tick += tmrSearching_Tick;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuIgnore;
		internal System.Windows.Forms.ToolStripMenuItem mnuIgnore {
			get { return withEventsField_mnuIgnore; }
			set {
				if (withEventsField_mnuIgnore != null) {
					withEventsField_mnuIgnore.Click -= mnuIgnore_Click;
				}
				withEventsField_mnuIgnore = value;
				if (withEventsField_mnuIgnore != null) {
					withEventsField_mnuIgnore.Click += mnuIgnore_Click;
				}
			}
		}
		private System.Windows.Forms.Timer withEventsField_tmrDreamTypes;
		internal System.Windows.Forms.Timer tmrDreamTypes {
			get { return withEventsField_tmrDreamTypes; }
			set {
				if (withEventsField_tmrDreamTypes != null) {
					withEventsField_tmrDreamTypes.Tick -= tmrDreamTypes_Tick;
				}
				withEventsField_tmrDreamTypes = value;
				if (withEventsField_tmrDreamTypes != null) {
					withEventsField_tmrDreamTypes.Tick += tmrDreamTypes_Tick;
				}
			}
		}

		internal System.Windows.Forms.ToolStripMenuItem CategoryMenuItem;
	}
}
