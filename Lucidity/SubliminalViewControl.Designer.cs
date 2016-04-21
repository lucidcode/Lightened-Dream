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
	partial class SubliminalViewControl : System.Windows.Forms.UserControl
	{

		//UserControl overrides dispose to clean up the component list.
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
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.Label2 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.cmbSize = new System.Windows.Forms.ComboBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.colText = new lucidcode.Controls.ColorPicker();
			this.Label12 = new System.Windows.Forms.Label();
			this.colBackground = new lucidcode.Controls.ColorPicker();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblInterval = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.cmbTransparency = new System.Windows.Forms.ComboBox();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtMessages = new System.Windows.Forms.TextBox();
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Controls.Add(this.TableLayoutPanel1);
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(732, 83);
			this.Panel3D2.TabIndex = 6;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(732, 24);
			this.Panel3D4.TabIndex = 32;
			//
			//Label2
			//
			this.Label2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(719, 19);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Settings";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.Controls.Add(this.txtDuration, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtInterval, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.cmbSize, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.colText, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.colBackground, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblInterval, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.cmbTransparency, 5, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 27);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(724, 52);
			this.TableLayoutPanel1.TabIndex = 31;
			//
			//txtDuration
			//
			this.txtDuration.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDuration.Location = new System.Drawing.Point(316, 3);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(151, 21);
			this.txtDuration.TabIndex = 6;
			//
			//txtInterval
			//
			this.txtInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInterval.Location = new System.Drawing.Point(95, 3);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(151, 21);
			this.txtInterval.TabIndex = 39;
			//
			//cmbSize
			//
			this.cmbSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSize.FormattingEnabled = true;
			this.cmbSize.Items.AddRange(new object[] {
				"8",
				"9",
				"10",
				"11",
				"12",
				"14",
				"16",
				"18",
				"20",
				"22",
				"24",
				"26",
				"28",
				"36",
				"48",
				"72"
			});
			this.cmbSize.Location = new System.Drawing.Point(569, 27);
			this.cmbSize.Name = "cmbSize";
			this.cmbSize.Size = new System.Drawing.Size(152, 21);
			this.cmbSize.TabIndex = 38;
			//
			//Label13
			//
			this.Label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label13.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label13.Location = new System.Drawing.Point(473, 24);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(90, 28);
			this.Label13.TabIndex = 37;
			this.Label13.Text = "Size";
			this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//colText
			//
			this.colText.Color = System.Drawing.Color.White;
			this.colText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colText.Location = new System.Drawing.Point(316, 27);
			this.colText.Name = "colText";
			this.colText.Size = new System.Drawing.Size(151, 22);
			this.colText.TabIndex = 36;
			//
			//Label12
			//
			this.Label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label12.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label12.Location = new System.Drawing.Point(252, 24);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(58, 28);
			this.Label12.TabIndex = 35;
			this.Label12.Text = "Text";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//colBackground
			//
			this.colBackground.Color = System.Drawing.Color.SteelBlue;
			this.colBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colBackground.Location = new System.Drawing.Point(95, 27);
			this.colBackground.Name = "colBackground";
			this.colBackground.Size = new System.Drawing.Size(151, 22);
			this.colBackground.TabIndex = 34;
			//
			//Label11
			//
			this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(3, 24);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(86, 28);
			this.Label11.TabIndex = 33;
			this.Label11.Text = "Background";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(473, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(90, 24);
			this.Label1.TabIndex = 29;
			this.Label1.Text = "Transparency";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblInterval
			//
			this.lblInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblInterval.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblInterval.Location = new System.Drawing.Point(3, 0);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(86, 24);
			this.lblInterval.TabIndex = 25;
			this.lblInterval.Text = "Interval";
			this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label3.Location = new System.Drawing.Point(252, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(58, 24);
			this.Label3.TabIndex = 27;
			this.Label3.Text = "Duration";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbTransparency
			//
			this.cmbTransparency.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbTransparency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTransparency.FormattingEnabled = true;
			this.cmbTransparency.Items.AddRange(new object[] {
				"99",
				"98",
				"97",
				"96",
				"95",
				"94",
				"93",
				"92",
				"91",
				"90",
				"89",
				"88",
				"87",
				"86",
				"85",
				"84",
				"83",
				"82",
				"81",
				"80",
				"79",
				"78",
				"77",
				"76",
				"75",
				"74",
				"73",
				"72",
				"71",
				"70",
				"69",
				"68",
				"67",
				"66",
				"65",
				"64",
				"63",
				"62",
				"61",
				"60",
				"59",
				"58",
				"57",
				"56",
				"55",
				"54",
				"53",
				"52",
				"51",
				"50",
				"49",
				"48",
				"47",
				"46",
				"45",
				"44",
				"43",
				"42",
				"41",
				"40",
				"39",
				"38",
				"37",
				"36",
				"35",
				"34",
				"33",
				"32",
				"31",
				"30",
				"29",
				"28",
				"27",
				"26",
				"25",
				"24",
				"23",
				"22",
				"21",
				"20",
				"19",
				"18",
				"17",
				"16",
				"15",
				"14",
				"13",
				"12",
				"11",
				"10",
				"9",
				"8",
				"7",
				"6",
				"5",
				"4",
				"3",
				"2",
				"1",
				"0"
			});
			this.cmbTransparency.Location = new System.Drawing.Point(569, 3);
			this.cmbTransparency.Name = "cmbTransparency";
			this.cmbTransparency.Size = new System.Drawing.Size(152, 21);
			this.cmbTransparency.TabIndex = 31;
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Controls.Add(this.txtMessages);
			this.Panel3D1.Location = new System.Drawing.Point(0, 89);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(732, 263);
			this.Panel3D1.TabIndex = 30;
			//
			//Panel3D3
			//
			this.Panel3D3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D3.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D3.Controls.Add(this.Label8);
			this.Panel3D3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D3.Location = new System.Drawing.Point(0, 0);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(735, 24);
			this.Panel3D3.TabIndex = 5;
			//
			//Label8
			//
			this.Label8.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label8.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label8.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.Label8.Location = new System.Drawing.Point(8, 3);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(722, 19);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Messages";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtMessages
			//
			this.txtMessages.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtMessages.Location = new System.Drawing.Point(3, 25);
			this.txtMessages.Multiline = true;
			this.txtMessages.Name = "txtMessages";
			this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessages.Size = new System.Drawing.Size(726, 235);
			this.txtMessages.TabIndex = 2;
			//
			//SubliminalViewControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Controls.Add(this.Panel3D2);
			this.Controls.Add(this.Panel3D1);
			this.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Name = "SubliminalViewControl";
			this.Size = new System.Drawing.Size(732, 352);
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label lblInterval;
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ComboBox withEventsField_cmbTransparency;
		internal System.Windows.Forms.ComboBox cmbTransparency {
			get { return withEventsField_cmbTransparency; }
			set {
				if (withEventsField_cmbTransparency != null) {
					withEventsField_cmbTransparency.SelectedIndexChanged -= cmbTransparency_SelectedIndexChanged;
				}
				withEventsField_cmbTransparency = value;
				if (withEventsField_cmbTransparency != null) {
					withEventsField_cmbTransparency.SelectedIndexChanged += cmbTransparency_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cmbSize;
		internal System.Windows.Forms.ComboBox cmbSize {
			get { return withEventsField_cmbSize; }
			set {
				if (withEventsField_cmbSize != null) {
					withEventsField_cmbSize.SelectedIndexChanged -= cmbSize_SelectedIndexChanged;
				}
				withEventsField_cmbSize = value;
				if (withEventsField_cmbSize != null) {
					withEventsField_cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label13;
		private lucidcode.Controls.ColorPicker withEventsField_colText;
		internal lucidcode.Controls.ColorPicker colText {
			get { return withEventsField_colText; }
			set {
				if (withEventsField_colText != null) {
					withEventsField_colText.ColorChanged -= colText_ColorChanged;
				}
				withEventsField_colText = value;
				if (withEventsField_colText != null) {
					withEventsField_colText.ColorChanged += colText_ColorChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label12;
		private lucidcode.Controls.ColorPicker withEventsField_colBackground;
		internal lucidcode.Controls.ColorPicker colBackground {
			get { return withEventsField_colBackground; }
			set {
				if (withEventsField_colBackground != null) {
					withEventsField_colBackground.ColorChanged -= colBackground_ColorChanged;
				}
				withEventsField_colBackground = value;
				if (withEventsField_colBackground != null) {
					withEventsField_colBackground.ColorChanged += colBackground_ColorChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label11;
		private System.Windows.Forms.TextBox withEventsField_txtDuration;
		internal System.Windows.Forms.TextBox txtDuration {
			get { return withEventsField_txtDuration; }
			set {
				if (withEventsField_txtDuration != null) {
					withEventsField_txtDuration.TextChanged -= txtDuration_TextChanged;
				}
				withEventsField_txtDuration = value;
				if (withEventsField_txtDuration != null) {
					withEventsField_txtDuration.TextChanged += txtDuration_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtInterval;
		internal System.Windows.Forms.TextBox txtInterval {
			get { return withEventsField_txtInterval; }
			set {
				if (withEventsField_txtInterval != null) {
					withEventsField_txtInterval.TextChanged -= txtInterval_TextChanged;
				}
				withEventsField_txtInterval = value;
				if (withEventsField_txtInterval != null) {
					withEventsField_txtInterval.TextChanged += txtInterval_TextChanged;
				}
			}
		}
		internal lucidcode.Controls.Panel3D Panel3D4;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.TextBox withEventsField_txtMessages;
		public System.Windows.Forms.TextBox txtMessages {
			get { return withEventsField_txtMessages; }
			set {
				if (withEventsField_txtMessages != null) {
					withEventsField_txtMessages.TextChanged -= txtMessages_TextChanged;
				}
				withEventsField_txtMessages = value;
				if (withEventsField_txtMessages != null) {
					withEventsField_txtMessages.TextChanged += txtMessages_TextChanged;
				}
			}

		}
	}
}
