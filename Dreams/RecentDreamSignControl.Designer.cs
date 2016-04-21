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
	partial class RecentDreamSignControl : System.Windows.Forms.UserControl
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel31 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel32 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel29 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel30 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series Series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentDreamSignControl));
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
			this.mnuIgnore = new System.Windows.Forms.ToolStripMenuItem();
			this.tmrDreamSigns = new System.Windows.Forms.Timer(this.components);
			this.tmrSearching = new System.Windows.Forms.Timer(this.components);
			this.tmrDreamTypes = new System.Windows.Forms.Timer(this.components);
			this.Label11 = new System.Windows.Forms.Label();
			this.cmbFromYear = new System.Windows.Forms.ComboBox();
			this.cmbFromMonth = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbToMonth = new System.Windows.Forms.ComboBox();
			this.cmbToYear = new System.Windows.Forms.ComboBox();
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
			this.lstDreams.Location = new System.Drawing.Point(484, 30);
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
			this.Panel3D2.Controls.Add(this.cmbToMonth);
			this.Panel3D2.Controls.Add(this.cmbToYear);
			this.Panel3D2.Controls.Add(this.Label1);
			this.Panel3D2.Controls.Add(this.cmbFromMonth);
			this.Panel3D2.Controls.Add(this.cmbFromYear);
			this.Panel3D2.Controls.Add(this.Label11);
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
			ChartArea16.Area3DStyle.Enable3D = true;
			ChartArea16.Area3DStyle.Inclination = 10;
			ChartArea16.Area3DStyle.IsClustered = true;
			ChartArea16.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea16.Area3DStyle.PointDepth = 200;
			ChartArea16.Area3DStyle.PointGapDepth = 0;
			ChartArea16.Area3DStyle.Rotation = 10;
			ChartArea16.Area3DStyle.WallWidth = 0;
			ChartArea16.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea16.AxisX.IsLabelAutoFit = false;
			ChartArea16.AxisX.LabelStyle.Angle = 90;
			ChartArea16.AxisX.LabelStyle.Enabled = false;
			ChartArea16.AxisX.LabelStyle.Interval = 0.0;
			ChartArea16.AxisX.LineColor = System.Drawing.Color.Transparent;
			ChartArea16.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			ChartArea16.AxisX.LineWidth = 0;
			ChartArea16.AxisX.MajorGrid.Enabled = false;
			ChartArea16.AxisX.MajorGrid.LineWidth = 0;
			ChartArea16.AxisX.MajorTickMark.Enabled = false;
			ChartArea16.AxisX.MajorTickMark.LineWidth = 0;
			ChartArea16.AxisX.MajorTickMark.Size = 0f;
			ChartArea16.AxisX.MinorGrid.LineWidth = 0;
			ChartArea16.AxisX.MinorTickMark.LineWidth = 0;
			ChartArea16.AxisX.MinorTickMark.Size = 0f;
			ChartArea16.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			CustomLabel31.Text = "x";
			CustomLabel32.Text = "x";
			ChartArea16.AxisX2.CustomLabels.Add(CustomLabel31);
			ChartArea16.AxisX2.CustomLabels.Add(CustomLabel32);
			ChartArea16.AxisX2.LineWidth = 0;
			ChartArea16.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea16.AxisY.LabelStyle.Enabled = false;
			ChartArea16.AxisY.LineWidth = 0;
			ChartArea16.AxisY.MajorGrid.Enabled = false;
			ChartArea16.AxisY.MajorTickMark.Enabled = false;
			ChartArea16.AxisY.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			ChartArea16.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea16.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea16.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea16.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea16.AxisY2.LineWidth = 0;
			ChartArea16.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea16.AxisY2.Maximum = 11.0;
			ChartArea16.AxisY2.Minimum = -11.0;
			ChartArea16.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea16.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea16.BackColor = System.Drawing.Color.LightSteelBlue;
			ChartArea16.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea16.BackSecondaryColor = System.Drawing.Color.Transparent;
			ChartArea16.BorderColor = System.Drawing.Color.LightSteelBlue;
			ChartArea16.BorderWidth = 0;
			ChartArea16.Name = "ChartArea1";
			ChartArea16.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(ChartArea16);
			this.Chart1.Location = new System.Drawing.Point(3, 3);
			this.Chart1.Name = "Chart1";
			Series24.ChartArea = "ChartArea1";
			Series24.Name = "Series1";
			this.Chart1.Series.Add(Series24);
			this.Chart1.Size = new System.Drawing.Size(628, 33);
			this.Chart1.TabIndex = 283;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			ChartArea15.Area3DStyle.Enable3D = true;
			ChartArea15.Area3DStyle.Inclination = 10;
			ChartArea15.Area3DStyle.IsClustered = true;
			ChartArea15.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea15.Area3DStyle.PointGapDepth = 0;
			ChartArea15.Area3DStyle.Rotation = 10;
			ChartArea15.Area3DStyle.WallWidth = 0;
			ChartArea15.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea15.AxisX.IsLabelAutoFit = false;
			ChartArea15.AxisX.LabelStyle.Angle = 90;
			ChartArea15.AxisX.LabelStyle.Enabled = false;
			ChartArea15.AxisX.LabelStyle.Interval = 0.0;
			ChartArea15.AxisX.MajorGrid.Enabled = false;
			ChartArea15.AxisX.MajorTickMark.Enabled = false;
			CustomLabel29.Text = "x";
			CustomLabel30.Text = "x";
			ChartArea15.AxisX2.CustomLabels.Add(CustomLabel29);
			ChartArea15.AxisX2.CustomLabels.Add(CustomLabel30);
			ChartArea15.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea15.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea15.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea15.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea15.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea15.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea15.AxisY2.Maximum = 11.0;
			ChartArea15.AxisY2.Minimum = -11.0;
			ChartArea15.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea15.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea15.BackColor = System.Drawing.Color.White;
			ChartArea15.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea15.BackSecondaryColor = System.Drawing.Color.White;
			ChartArea15.BorderColor = System.Drawing.Color.White;
			ChartArea15.Name = "ChartArea1";
			ChartArea15.ShadowColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(0)));
			this.graph.ChartAreas.Add(ChartArea15);
			this.graph.Location = new System.Drawing.Point(3, 58);
			this.graph.Name = "graph";
			Series22.ChartArea = "ChartArea1";
			Series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series22.Name = "Series2";
			Series23.ChartArea = "ChartArea1";
			Series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			Series23.Name = "Series3";
			this.graph.Series.Add(Series22);
			this.graph.Series.Add(Series23);
			this.graph.Size = new System.Drawing.Size(634, 374);
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
			this.lblTitle.Text = "Recent Dream Signs";
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
			this.mnuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuIgnore });
			this.mnuCategories.Name = "mnuCategories";
			this.mnuCategories.Size = new System.Drawing.Size(109, 26);
			//
			//mnuIgnore
			//
			this.mnuIgnore.Name = "mnuIgnore";
			this.mnuIgnore.Size = new System.Drawing.Size(108, 22);
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
			//Label11
			//
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(8, 30);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(74, 21);
			this.Label11.TabIndex = 32;
			this.Label11.Text = "Date Range";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbFromYear
			//
			this.cmbFromYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFromYear.FormattingEnabled = true;
			this.cmbFromYear.Items.AddRange(new object[] { "2014" });
			this.cmbFromYear.Location = new System.Drawing.Point(88, 31);
			this.cmbFromYear.Name = "cmbFromYear";
			this.cmbFromYear.Size = new System.Drawing.Size(56, 21);
			this.cmbFromYear.TabIndex = 33;
			//
			//cmbFromMonth
			//
			this.cmbFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFromMonth.FormattingEnabled = true;
			this.cmbFromMonth.Items.AddRange(new object[] {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12"
			});
			this.cmbFromMonth.Location = new System.Drawing.Point(150, 31);
			this.cmbFromMonth.Name = "cmbFromMonth";
			this.cmbFromMonth.Size = new System.Drawing.Size(38, 21);
			this.cmbFromMonth.TabIndex = 34;
			//
			//Label1
			//
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(194, 31);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(11, 21);
			this.Label1.TabIndex = 35;
			this.Label1.Text = "-";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbToMonth
			//
			this.cmbToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbToMonth.FormattingEnabled = true;
			this.cmbToMonth.Items.AddRange(new object[] {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12"
			});
			this.cmbToMonth.Location = new System.Drawing.Point(273, 31);
			this.cmbToMonth.Name = "cmbToMonth";
			this.cmbToMonth.Size = new System.Drawing.Size(38, 21);
			this.cmbToMonth.TabIndex = 37;
			//
			//cmbToYear
			//
			this.cmbToYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbToYear.FormattingEnabled = true;
			this.cmbToYear.Items.AddRange(new object[] { "2014" });
			this.cmbToYear.Location = new System.Drawing.Point(211, 31);
			this.cmbToYear.Name = "cmbToYear";
			this.cmbToYear.Size = new System.Drawing.Size(56, 21);
			this.cmbToYear.TabIndex = 36;
			//
			//RecentDreamSignControl
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
			this.Name = "RecentDreamSignControl";
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
		internal System.Windows.Forms.Label Label11;
		private System.Windows.Forms.ComboBox withEventsField_cmbToMonth;
		internal System.Windows.Forms.ComboBox cmbToMonth {
			get { return withEventsField_cmbToMonth; }
			set {
				if (withEventsField_cmbToMonth != null) {
					withEventsField_cmbToMonth.SelectedIndexChanged -= cmbToMonth_SelectedIndexChanged;
				}
				withEventsField_cmbToMonth = value;
				if (withEventsField_cmbToMonth != null) {
					withEventsField_cmbToMonth.SelectedIndexChanged += cmbToMonth_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cmbToYear;
		internal System.Windows.Forms.ComboBox cmbToYear {
			get { return withEventsField_cmbToYear; }
			set {
				if (withEventsField_cmbToYear != null) {
					withEventsField_cmbToYear.SelectedIndexChanged -= cmbToYear_SelectedIndexChanged;
				}
				withEventsField_cmbToYear = value;
				if (withEventsField_cmbToYear != null) {
					withEventsField_cmbToYear.SelectedIndexChanged += cmbToYear_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ComboBox withEventsField_cmbFromMonth;
		internal System.Windows.Forms.ComboBox cmbFromMonth {
			get { return withEventsField_cmbFromMonth; }
			set {
				if (withEventsField_cmbFromMonth != null) {
					withEventsField_cmbFromMonth.SelectedIndexChanged -= cmbFromMonth_SelectedIndexChanged;
				}
				withEventsField_cmbFromMonth = value;
				if (withEventsField_cmbFromMonth != null) {
					withEventsField_cmbFromMonth.SelectedIndexChanged += cmbFromMonth_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cmbFromYear;
		internal System.Windows.Forms.ComboBox cmbFromYear {
			get { return withEventsField_cmbFromYear; }
			set {
				if (withEventsField_cmbFromYear != null) {
					withEventsField_cmbFromYear.SelectedIndexChanged -= cmbFromYear_SelectedIndexChanged;
				}
				withEventsField_cmbFromYear = value;
				if (withEventsField_cmbFromYear != null) {
					withEventsField_cmbFromYear.SelectedIndexChanged += cmbFromYear_SelectedIndexChanged;
				}
			}

		}
	}
}
