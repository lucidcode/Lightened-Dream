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
	partial class ImageBrowserForm : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBrowserForm));
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtKeywords = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tmrSearching = new System.Windows.Forms.Timer(this.components);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.lstImages = new lucidcode.LightenedDream.Dreams.ListViewNF();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.pnlSearching = new lucidcode.Controls.Panel3D();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblRAC = new System.Windows.Forms.LinkLabel();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.tmrDoSearch = new System.Windows.Forms.Timer(this.components);
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.Panel3D2.SuspendLayout();
			this.pnlSearching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.SuspendLayout();
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.btnSearch);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Controls.Add(this.txtKeywords);
			this.Panel3D1.Location = new System.Drawing.Point(12, 12);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(720, 76);
			this.Panel3D1.TabIndex = 16;
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
			this.btnSearch.Location = new System.Drawing.Point(612, 30);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnSearch.Size = new System.Drawing.Size(105, 39);
			this.btnSearch.TabIndex = 283;
			this.btnSearch.Text = "&Search";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "Function.Stop.bmp");
			//
			//Panel3D3
			//
			this.Panel3D3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings1.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings1.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings1.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings1.SettingsKey = "";
			MySettings1.TextBackColor = System.Drawing.Color.White;
			MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings1.TitleForeColor = System.Drawing.Color.White;
			this.Panel3D3.BackColor = MySettings1.TitleBackColor;
			this.Panel3D3.Controls.Add(this.Label7);
			this.Panel3D3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D3.Location = new System.Drawing.Point(0, 0);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(720, 24);
			this.Panel3D3.TabIndex = 282;
			//
			//Label7
			//
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label7.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor;
			this.Label7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label7.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.Label7.Location = new System.Drawing.Point(7, 3);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(710, 19);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Keywords";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtKeywords
			//
			this.txtKeywords.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtKeywords.Location = new System.Drawing.Point(10, 30);
			this.txtKeywords.Multiline = true;
			this.txtKeywords.Name = "txtKeywords";
			this.txtKeywords.Size = new System.Drawing.Size(596, 39);
			this.txtKeywords.TabIndex = 39;
			//
			//btnCancel
			//
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 1;
			this.btnCancel.ImageList = this.lstImgTlb;
			this.btnCancel.Location = new System.Drawing.Point(627, 391);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnCancel.Size = new System.Drawing.Size(105, 39);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//tmrSearching
			//
			this.tmrSearching.Interval = 128;
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.BackColor = System.Drawing.Color.White;
			this.Panel3D2.Controls.Add(this.lstImages);
			this.Panel3D2.Location = new System.Drawing.Point(12, 94);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(720, 291);
			this.Panel3D2.TabIndex = 17;
			//
			//lstImages
			//
			this.lstImages.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstImages.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lstImages.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor;
			this.lstImages.LargeImageList = this.lstImg;
			this.lstImages.Location = new System.Drawing.Point(2, 2);
			this.lstImages.Name = "lstImages";
			this.lstImages.Size = new System.Drawing.Size(716, 287);
			this.lstImages.TabIndex = 0;
			this.lstImages.UseCompatibleStateImageBehavior = false;
			//
			//lstImg
			//
			this.lstImg.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.lstImg.ImageSize = new System.Drawing.Size(110, 110);
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			//
			//pnlSearching
			//
			this.pnlSearching.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlSearching.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.pnlSearching.Controls.Add(this.graph);
			this.pnlSearching.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlSearching.Location = new System.Drawing.Point(12, 391);
			this.pnlSearching.Name = "pnlSearching";
			this.pnlSearching.Size = new System.Drawing.Size(606, 39);
			this.pnlSearching.TabIndex = 18;
			this.pnlSearching.Visible = false;
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
			this.graph.ChartAreas.Add(ChartArea1);
			this.graph.Location = new System.Drawing.Point(3, 3);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.Name = "Series1";
			this.graph.Series.Add(Series1);
			this.graph.Size = new System.Drawing.Size(600, 33);
			this.graph.TabIndex = 283;
			//
			//lblRAC
			//
			this.lblRAC.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lblRAC.LinkArea = new System.Windows.Forms.LinkArea(0, 37);
			this.lblRAC.Location = new System.Drawing.Point(131, 401);
			this.lblRAC.Name = "lblRAC";
			this.lblRAC.Size = new System.Drawing.Size(86, 21);
			this.lblRAC.TabIndex = 286;
			this.lblRAC.TabStop = true;
			this.lblRAC.Text = "gettyimages";
			this.lblRAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRAC.UseCompatibleTextRendering = true;
			//
			//lblAuthor
			//
			this.lblAuthor.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lblAuthor.ForeColor = System.Drawing.Color.Black;
			this.lblAuthor.Location = new System.Drawing.Point(12, 400);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(205, 21);
			this.lblAuthor.TabIndex = 285;
			this.lblAuthor.Tag = "";
			this.lblAuthor.Text = "Images courtesy of ";
			this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//tmrDoSearch
			//
			this.tmrDoSearch.Interval = 128;
			//
			//ImageBrowserForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(745, 442);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.pnlSearching);
			this.Controls.Add(this.Panel3D2);
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.lblRAC);
			this.Controls.Add(this.lblAuthor);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ImageBrowserForm";
			this.Text = "Image Browser";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.Panel3D2.ResumeLayout(false);
			this.pnlSearching.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label7;
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
		private System.Windows.Forms.ImageList lstImgTlb;
		private System.Windows.Forms.Button withEventsField_btnCancel;
		public System.Windows.Forms.Button btnCancel {
			get { return withEventsField_btnCancel; }
			set {
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click -= btnCancel_Click;
				}
				withEventsField_btnCancel = value;
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click += btnCancel_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtKeywords;
		internal System.Windows.Forms.TextBox txtKeywords {
			get { return withEventsField_txtKeywords; }
			set {
				if (withEventsField_txtKeywords != null) {
					withEventsField_txtKeywords.KeyDown -= txtKeywords_KeyDown;
					withEventsField_txtKeywords.Enter -= txtKeywords_Enter;
				}
				withEventsField_txtKeywords = value;
				if (withEventsField_txtKeywords != null) {
					withEventsField_txtKeywords.KeyDown += txtKeywords_KeyDown;
					withEventsField_txtKeywords.Enter += txtKeywords_Enter;
				}
			}
		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		private ListViewNF withEventsField_lstImages;
		internal ListViewNF lstImages {
			get { return withEventsField_lstImages; }
			set {
				if (withEventsField_lstImages != null) {
					withEventsField_lstImages.MouseMove -= lstImages_MouseMove;
					withEventsField_lstImages.SelectedIndexChanged -= lstImages_SelectedIndexChanged;
					withEventsField_lstImages.Click -= lstImages_Click;
				}
				withEventsField_lstImages = value;
				if (withEventsField_lstImages != null) {
					withEventsField_lstImages.MouseMove += lstImages_MouseMove;
					withEventsField_lstImages.SelectedIndexChanged += lstImages_SelectedIndexChanged;
					withEventsField_lstImages.Click += lstImages_Click;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImg;
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
		internal lucidcode.Controls.Panel3D pnlSearching;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graph;
		private System.Windows.Forms.LinkLabel withEventsField_lblRAC;
		internal System.Windows.Forms.LinkLabel lblRAC {
			get { return withEventsField_lblRAC; }
			set {
				if (withEventsField_lblRAC != null) {
					withEventsField_lblRAC.LinkClicked -= lblRAC_LinkClicked;
				}
				withEventsField_lblRAC = value;
				if (withEventsField_lblRAC != null) {
					withEventsField_lblRAC.LinkClicked += lblRAC_LinkClicked;
				}
			}
		}
		internal System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Timer withEventsField_tmrDoSearch;
		internal System.Windows.Forms.Timer tmrDoSearch {
			get { return withEventsField_tmrDoSearch; }
			set {
				if (withEventsField_tmrDoSearch != null) {
					withEventsField_tmrDoSearch.Tick -= tmrDoSearch_Tick;
				}
				withEventsField_tmrDoSearch = value;
				if (withEventsField_tmrDoSearch != null) {
					withEventsField_tmrDoSearch.Tick += tmrDoSearch_Tick;
				}
			}
		}
		public ImageBrowserForm()
		{
			FormClosing += ImageBrowserForm_FormClosing;
			Load += ImageBrowserForm_Load;
			InitializeComponent();
		}
	}
}
