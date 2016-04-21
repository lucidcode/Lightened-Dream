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
	partial class WILDForm : System.Windows.Forms.Form
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
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WILDForm));
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cmbLength = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.colText = new lucidcode.Controls.ColorPicker();
			this.Label12 = new System.Windows.Forms.Label();
			this.colBackground = new lucidcode.Controls.ColorPicker();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label7 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel3D1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.TableLayoutPanel1);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Location = new System.Drawing.Point(12, 12);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(459, 88);
			this.Panel3D1.TabIndex = 16;
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.Controls.Add(this.cmbLength, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtInterval, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.colText, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.colBackground, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 27);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(445, 52);
			this.TableLayoutPanel1.TabIndex = 31;
			//
			//cmbLength
			//
			this.cmbLength.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLength.FormattingEnabled = true;
			this.cmbLength.Items.AddRange(new object[] {
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
				"15",
				"20",
				"30"
			});
			this.cmbLength.Location = new System.Drawing.Point(301, 3);
			this.cmbLength.Name = "cmbLength";
			this.cmbLength.Size = new System.Drawing.Size(141, 21);
			this.cmbLength.TabIndex = 41;
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(241, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(54, 24);
			this.Label1.TabIndex = 40;
			this.Label1.Text = "Length";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtInterval
			//
			this.txtInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInterval.Location = new System.Drawing.Point(95, 3);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(140, 21);
			this.txtInterval.TabIndex = 39;
			this.txtInterval.Text = "128";
			//
			//colText
			//
			this.colText.Color = System.Drawing.Color.White;
			this.colText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colText.Location = new System.Drawing.Point(301, 27);
			this.colText.Name = "colText";
			this.colText.Size = new System.Drawing.Size(141, 22);
			this.colText.TabIndex = 36;
			//
			//Label12
			//
			this.Label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label12.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label12.Location = new System.Drawing.Point(241, 24);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(54, 28);
			this.Label12.TabIndex = 35;
			this.Label12.Text = "Flash";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//colBackground
			//
			this.colBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colBackground.Location = new System.Drawing.Point(95, 27);
			this.colBackground.Name = "colBackground";
			this.colBackground.Size = new System.Drawing.Size(140, 22);
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
			//Label4
			//
			this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label4.Location = new System.Drawing.Point(3, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(86, 24);
			this.Label4.TabIndex = 25;
			this.Label4.Text = "Interval (ms)";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.Panel3D3.Size = new System.Drawing.Size(459, 24);
			this.Panel3D3.TabIndex = 282;
			//
			//Label7
			//
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label7.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.Label7.Location = new System.Drawing.Point(7, 3);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(448, 19);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Settings";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//btnOk
			//
			this.btnOk.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOk.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.ImageIndex = 0;
			this.btnOk.ImageList = this.lstImgTlb;
			this.btnOk.Location = new System.Drawing.Point(366, 106);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnOk.Size = new System.Drawing.Size(105, 39);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&Induce";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "Function.Stop.bmp");
			//
			//btnCancel
			//
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 1;
			this.btnCancel.ImageList = this.lstImgTlb;
			this.btnCancel.Location = new System.Drawing.Point(255, 106);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnCancel.Size = new System.Drawing.Size(105, 39);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
			//
			//Label2
			//
			this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label2.Location = new System.Drawing.Point(12, 103);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(237, 42);
			this.Label2.TabIndex = 34;
			this.Label2.Text = "Darken the room, lean forward, close your eyes and watch closely.";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//WILDForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(483, 151);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.Panel3D1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WILDForm";
			this.Text = "WILD Inducer";
			this.Panel3D1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label7;
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
		private System.Windows.Forms.Button withEventsField_btnOk;
		public System.Windows.Forms.Button btnOk {
			get { return withEventsField_btnOk; }
			set {
				if (withEventsField_btnOk != null) {
					withEventsField_btnOk.Click -= btnOk_Click;
				}
				withEventsField_btnOk = value;
				if (withEventsField_btnOk != null) {
					withEventsField_btnOk.Click += btnOk_Click;
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
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.TextBox txtInterval;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label1;
		internal lucidcode.Controls.ColorPicker colText;
		internal System.Windows.Forms.Label Label12;
		internal lucidcode.Controls.ColorPicker colBackground;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox cmbLength;
	}
}
