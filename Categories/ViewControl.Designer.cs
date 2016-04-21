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
	partial class ViewControl : System.Windows.Forms.UserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewControl));
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel5 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lstImgDreams = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lstDreams = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.Label12 = new System.Windows.Forms.Label();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.txtKeywords = new System.Windows.Forms.TextBox();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//lstImgDreams
			//
			this.lstImgDreams.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgDreams.ImageStream");
			this.lstImgDreams.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImgDreams.Images.SetKeyName(0, "Dream4.ico");
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.Label2);
			this.Panel3D2.Controls.Add(this.Label1);
			this.Panel3D2.Controls.Add(this.lstDreams);
			this.Panel3D2.Controls.Add(this.Label12);
			this.Panel3D2.Controls.Add(this.graph);
			this.Panel3D2.Controls.Add(this.txtKeywords);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Controls.Add(this.txtName);
			this.Panel3D2.Controls.Add(this.txtDescription);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.TabIndex = 7;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 81);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(77, 21);
			this.Label2.TabIndex = 32;
			this.Label2.Text = "Description";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 54);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(77, 21);
			this.Label1.TabIndex = 31;
			this.Label1.Text = "Words";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstDreams
			//
			this.lstDreams.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstDreams.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.TextBackColor;
			this.lstDreams.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstDreams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.lstDreams.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lstDreams.FullRowSelect = true;
			this.lstDreams.Location = new System.Drawing.Point(353, 51);
			this.lstDreams.MultiSelect = false;
			this.lstDreams.Name = "lstDreams";
			this.lstDreams.Size = new System.Drawing.Size(270, 136);
			this.lstDreams.SmallImageList = this.lstImgDreams;
			this.lstDreams.TabIndex = 1;
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
			//Label12
			//
			this.Label12.Location = new System.Drawing.Point(8, 27);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(77, 21);
			this.Label12.TabIndex = 30;
			this.Label12.Text = "Title";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = global::lucidcode.LightenedDream.Categories.My.MySettings.Default.FormBackColor;
			ChartArea2.Area3DStyle.Enable3D = true;
			ChartArea2.Area3DStyle.Inclination = 10;
			ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea2.Area3DStyle.PointDepth = 200;
			ChartArea2.Area3DStyle.PointGapDepth = 0;
			ChartArea2.Area3DStyle.Rotation = 10;
			ChartArea2.Area3DStyle.WallWidth = 0;
			CustomLabel5.FromPosition = 0.5;
			CustomLabel5.Text = "2009/11";
			CustomLabel5.ToPosition = 1.5;
			CustomLabel6.FromPosition = 1.5;
			CustomLabel6.Text = "2009/12";
			CustomLabel6.ToPosition = 2.5;
			ChartArea2.AxisX.CustomLabels.Add(CustomLabel5);
			ChartArea2.AxisX.CustomLabels.Add(CustomLabel6);
			ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.AxisX.IsLabelAutoFit = false;
			ChartArea2.AxisX.LabelStyle.Angle = 90;
			ChartArea2.AxisX.LabelStyle.Interval = 0;
			ChartArea2.AxisX.Title = "Dreams";
			CustomLabel7.Text = "x";
			CustomLabel8.Text = "x";
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel7);
			ChartArea2.AxisX2.CustomLabels.Add(CustomLabel8);
			ChartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea2.BackColor = System.Drawing.Color.White;
			ChartArea2.Name = "ChartArea1";
			ChartArea2.ShadowColor = System.Drawing.Color.White;
			this.graph.ChartAreas.Add(ChartArea2);
			this.graph.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Categories.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.graph.Location = new System.Drawing.Point(3, 137);
			this.graph.Name = "graph";
			Series2.ChartArea = "ChartArea1";
			Series2.Font = new System.Drawing.Font("Verdana", 8.25f);
			Series2.Name = "DreamSeries";
			Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.graph.Series.Add(Series2);
			this.graph.Size = new System.Drawing.Size(633, 340);
			this.graph.TabIndex = 0;
			this.graph.TabStop = false;
			//
			//txtKeywords
			//
			this.txtKeywords.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtKeywords.Location = new System.Drawing.Point(91, 54);
			this.txtKeywords.Name = "txtKeywords";
			this.txtKeywords.Size = new System.Drawing.Size(542, 21);
			this.txtKeywords.TabIndex = 1;
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
			this.lblTitle.Text = "Title";
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
			//txtName
			//
			this.txtName.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtName.Location = new System.Drawing.Point(91, 27);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(542, 21);
			this.txtName.TabIndex = 0;
			//
			//txtDescription
			//
			this.txtDescription.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtDescription.Location = new System.Drawing.Point(91, 81);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(541, 41);
			this.txtDescription.TabIndex = 2;
			//
			//ViewControl
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
			this.Name = "ViewControl";
			this.Size = new System.Drawing.Size(640, 480);
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblType;
		private System.Windows.Forms.ListView withEventsField_lstDreams;
		internal System.Windows.Forms.ListView lstDreams {
			get { return withEventsField_lstDreams; }
			set {
				if (withEventsField_lstDreams != null) {
					withEventsField_lstDreams.DoubleClick -= lstDreams_DoubleClick;
				}
				withEventsField_lstDreams = value;
				if (withEventsField_lstDreams != null) {
					withEventsField_lstDreams.DoubleClick += lstDreams_DoubleClick;
				}
			}
		}
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		private System.Windows.Forms.DataVisualization.Charting.Chart withEventsField_graph;
		internal System.Windows.Forms.DataVisualization.Charting.Chart graph {
			get { return withEventsField_graph; }
			set {
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseDown -= graph_MouseDown;
					withEventsField_graph.MouseMove -= graph_MouseMove;
				}
				withEventsField_graph = value;
				if (withEventsField_graph != null) {
					withEventsField_graph.MouseDown += graph_MouseDown;
					withEventsField_graph.MouseMove += graph_MouseMove;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImgDreams;
		private System.Windows.Forms.TextBox withEventsField_txtName;
		public System.Windows.Forms.TextBox txtName {
			get { return withEventsField_txtName; }
			set {
				if (withEventsField_txtName != null) {
					withEventsField_txtName.TextChanged -= txtName_TextChanged;
				}
				withEventsField_txtName = value;
				if (withEventsField_txtName != null) {
					withEventsField_txtName.TextChanged += txtName_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtDescription;
		internal System.Windows.Forms.TextBox txtDescription {
			get { return withEventsField_txtDescription; }
			set {
				if (withEventsField_txtDescription != null) {
					withEventsField_txtDescription.TextChanged -= txtDescription_TextChanged;
				}
				withEventsField_txtDescription = value;
				if (withEventsField_txtDescription != null) {
					withEventsField_txtDescription.TextChanged += txtDescription_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtKeywords;
		public System.Windows.Forms.TextBox txtKeywords {
			get { return withEventsField_txtKeywords; }
			set {
				if (withEventsField_txtKeywords != null) {
					withEventsField_txtKeywords.TextChanged -= txtKeywords_TextChanged;
				}
				withEventsField_txtKeywords = value;
				if (withEventsField_txtKeywords != null) {
					withEventsField_txtKeywords.TextChanged += txtKeywords_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;

		internal System.Windows.Forms.Label Label12;
	}
}
