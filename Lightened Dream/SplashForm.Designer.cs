using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace LightenedDream
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class SplashForm : System.Windows.Forms.Form
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title Title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel3D2 = new lucidcode.Controls.Panel3D();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.panel3D2.SuspendLayout();
			this.SuspendLayout();
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
			this.tmrLoad.Interval = 10;
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
			this.graph.Location = new System.Drawing.Point(2, 2);
			this.graph.Name = "graph";
			Series1.ChartArea = "ChartArea1";
			Series1.Name = "Series1";
			this.graph.Series.Add(Series1);
			this.graph.Size = new System.Drawing.Size(636, 476);
			this.graph.TabIndex = 2;
			Title1.DockedToChartArea = "ChartArea1";
			Title1.Font = new System.Drawing.Font("Viner Hand ITC", 27.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			Title1.ForeColor = System.Drawing.Color.SteelBlue;
			Title1.Name = "Title1";
			Title1.ShadowColor = System.Drawing.Color.White;
			Title1.ShadowOffset = 2;
			Title1.Text = "Lightened Dream";
			this.graph.Titles.Add(Title1);
			//
			//panel3D2
			//
			this.panel3D2.Controls.Add(this.graph);
			this.panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3D2.Location = new System.Drawing.Point(0, 0);
			this.panel3D2.Name = "panel3D2";
			this.panel3D2.Size = new System.Drawing.Size(640, 480);
			this.panel3D2.TabIndex = 17;
			//
			//SplashForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "SplashForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lightened Dream";
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.panel3D2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Timer withEventsField_tmrLoad;
		internal System.Windows.Forms.Timer tmrLoad {
			get { return withEventsField_tmrLoad; }
			set {
				if (withEventsField_tmrLoad != null) {
					withEventsField_tmrLoad.Tick -= tmrLoad_Tick;
				}
				withEventsField_tmrLoad = value;
				if (withEventsField_tmrLoad != null) {
					withEventsField_tmrLoad.Tick += tmrLoad_Tick;
				}
			}
		}
		internal lucidcode.Controls.Panel3D panel3D2;
		private System.Windows.Forms.DataVisualization.Charting.Chart graph;
	}
}
