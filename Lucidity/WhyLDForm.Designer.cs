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
	partial class WhyLDForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhyLDForm));
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.btnOk = new System.Windows.Forms.Button();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.Label2 = new System.Windows.Forms.Label();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label7 = new System.Windows.Forms.Label();
			this.lstImgSave = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.txtReason);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Location = new System.Drawing.Point(12, 12);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(402, 88);
			this.Panel3D1.TabIndex = 16;
			//
			//btnOk
			//
			this.btnOk.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOk.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.ImageIndex = 0;
			this.btnOk.ImageList = this.lstImgSave;
			this.btnOk.Location = new System.Drawing.Point(309, 106);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnOk.Size = new System.Drawing.Size(105, 39);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&Save";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Function.Stop.bmp");
			//
			//btnCancel
			//
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 0;
			this.btnCancel.ImageList = this.lstImgTlb;
			this.btnCancel.Location = new System.Drawing.Point(198, 106);
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
			this.Label2.Size = new System.Drawing.Size(176, 42);
			this.Label2.TabIndex = 34;
			this.Label2.Text = "Write down why you want to lucid dream. Keep changing the reason until it works.";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtReason
			//
			this.txtReason.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtReason.Location = new System.Drawing.Point(3, 25);
			this.txtReason.Multiline = true;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(395, 60);
			this.txtReason.TabIndex = 40;
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
			this.Panel3D3.Size = new System.Drawing.Size(402, 24);
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
			this.Label7.Size = new System.Drawing.Size(391, 19);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Reason";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstImgSave
			//
			this.lstImgSave.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgSave.ImageStream");
			this.lstImgSave.TransparentColor = System.Drawing.Color.White;
			this.lstImgSave.Images.SetKeyName(0, "File.Dream.Save.3.bmp");
			//
			//WhyLDForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(426, 151);
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
			this.Name = "WhyLDForm";
			this.Text = "Why LD";
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtReason;
		private System.Windows.Forms.ImageList lstImgSave;
	}
}
