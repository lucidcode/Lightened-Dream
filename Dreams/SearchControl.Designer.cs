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
	partial class SearchControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend Legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
			this.lstDreams = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.mnuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuAddTo = new System.Windows.Forms.ToolStripMenuItem();
			this.CategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D4.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
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
			this.lstDreams.Size = new System.Drawing.Size(226, 167);
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
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.lstDreams);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D2.Location = new System.Drawing.Point(0, 77);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 403);
			this.Panel3D2.TabIndex = 8;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			ChartArea1.Area3DStyle.Enable3D = true;
			ChartArea1.Area3DStyle.Inclination = 10;
			ChartArea1.Area3DStyle.IsClustered = true;
			ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
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
			ChartArea1.AxisX.LabelStyle.Interval = 0.0;
			CustomLabel3.Text = "x";
			CustomLabel4.Text = "x";
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel3);
			ChartArea1.AxisX2.CustomLabels.Add(CustomLabel4);
			ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea1.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea1.AxisY2.Maximum = 11.0;
			ChartArea1.AxisY2.Minimum = -11.0;
			ChartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea1.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea1.BackColor = System.Drawing.Color.White;
			ChartArea1.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea1.BackSecondaryColor = System.Drawing.Color.White;
			ChartArea1.BorderColor = System.Drawing.Color.White;
			ChartArea1.Name = "ChartArea1";
			ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)));
			this.graph.ChartAreas.Add(ChartArea1);
			Legend1.BackColor = System.Drawing.Color.LightSteelBlue;
			Legend1.ForeColor = System.Drawing.Color.MidnightBlue;
			Legend1.Name = "Legend1";
			this.graph.Legends.Add(Legend1);
			this.graph.Location = new System.Drawing.Point(3, 25);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series1.Legend = "Legend1";
			Series1.Name = "Series2";
			Series2.ChartArea = "ChartArea1";
			Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series2.Legend = "Legend1";
			Series2.Name = "Series3";
			this.graph.Series.Add(Series1);
			this.graph.Series.Add(Series2);
			this.graph.Size = new System.Drawing.Size(634, 375);
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
			this.lblTitle.Text = "Dreams";
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
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.Panel3D1.Controls.Add(this.btnSearch);
			this.Panel3D1.Controls.Add(this.txtSearch);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D1.Location = new System.Drawing.Point(0, 0);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(640, 71);
			this.Panel3D1.TabIndex = 0;
			//
			//btnSearch
			//
			this.btnSearch.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnSearch.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.ImageIndex = 0;
			this.btnSearch.ImageList = this.lstImgTlb;
			this.btnSearch.Location = new System.Drawing.Point(536, 27);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnSearch.Size = new System.Drawing.Size(101, 39);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "&Search";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "File.Dream.Search.3.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "File.Dream.Search.Clear.bmp");
			//
			//txtSearch
			//
			this.txtSearch.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtSearch.Location = new System.Drawing.Point(6, 27);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(524, 39);
			this.txtSearch.TabIndex = 0;
			//
			//Panel3D3
			//
			this.Panel3D3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D3.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor;
			this.Panel3D3.Controls.Add(this.Label1);
			this.Panel3D3.Controls.Add(this.Label3);
			this.Panel3D3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D3.Location = new System.Drawing.Point(0, 0);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(640, 24);
			this.Panel3D3.TabIndex = 5;
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label1.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.Label1.Location = new System.Drawing.Point(7, 3);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(630, 19);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Search";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label3.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.Label3.Location = new System.Drawing.Point(8, 3);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(90, 19);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Dream";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//mnuCategories
			//
			this.mnuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuAddTo });
			this.mnuCategories.Name = "mnuCategories";
			this.mnuCategories.Size = new System.Drawing.Size(114, 26);
			//
			//mnuAddTo
			//
			this.mnuAddTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.CategoryMenuItem });
			this.mnuAddTo.Image = (System.Drawing.Image)resources.GetObject("mnuAddTo.Image");
			this.mnuAddTo.Name = "mnuAddTo";
			this.mnuAddTo.Size = new System.Drawing.Size(113, 22);
			this.mnuAddTo.Text = "&Add To";
			//
			//CategoryMenuItem
			//
			this.CategoryMenuItem.Image = (System.Drawing.Image)resources.GetObject("CategoryMenuItem.Image");
			this.CategoryMenuItem.Name = "CategoryMenuItem";
			this.CategoryMenuItem.Size = new System.Drawing.Size(152, 22);
			this.CategoryMenuItem.Text = "Category";
			this.CategoryMenuItem.Visible = false;
			//
			//SearchControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor;
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D4.ResumeLayout(false);
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
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
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox withEventsField_txtSearch;
		internal System.Windows.Forms.TextBox txtSearch {
			get { return withEventsField_txtSearch; }
			set {
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.KeyDown -= txtSearch_KeyDown;
				}
				withEventsField_txtSearch = value;
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.KeyDown += txtSearch_KeyDown;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSearch;
		public System.Windows.Forms.Button btnSearch {
			get { return withEventsField_btnSearch; }
			set {
				if (withEventsField_btnSearch != null) {
					withEventsField_btnSearch.Click -= btnSearch_Click;
				}
				withEventsField_btnSearch = value;
				if (withEventsField_btnSearch != null) {
					withEventsField_btnSearch.Click += btnSearch_Click;
				}
			}
		}
		private System.Windows.Forms.ImageList lstImgTlb;
		private System.Windows.Forms.DataVisualization.Charting.Chart withEventsField_graph;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graph {
			get { return withEventsField_graph; }
			set {
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseMove -= graph_MouseMove;
					withEventsField_graph.MouseDown -= graph_MouseDown;
					withEventsField_graph.Click -= graph_Click;
				}
				withEventsField_graph = value;
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseMove += graph_MouseMove;
					withEventsField_graph.MouseDown += graph_MouseDown;
					withEventsField_graph.Click += graph_Click;
				}
			}
		}
		internal System.Windows.Forms.ContextMenuStrip mnuCategories;
		internal System.Windows.Forms.ToolStripMenuItem mnuAddTo;

		internal System.Windows.Forms.ToolStripMenuItem CategoryMenuItem;
	}
}
