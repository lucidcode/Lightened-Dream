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
	partial class RegisterForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.btnOk = new System.Windows.Forms.Button();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtReplyAddress = new System.Windows.Forms.TextBox();
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.btnOk);
			this.Panel3D1.Controls.Add(this.txtReplyAddress);
			this.Panel3D1.Controls.Add(this.btnCancel);
			this.Panel3D1.Controls.Add(this.Label11);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Location = new System.Drawing.Point(12, 12);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(325, 96);
			this.Panel3D1.TabIndex = 16;
			//
			//btnOk
			//
			this.btnOk.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOk.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnOk.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.ImageIndex = 0;
			this.btnOk.ImageList = this.lstImgTlb;
			this.btnOk.Location = new System.Drawing.Point(106, 54);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnOk.Size = new System.Drawing.Size(105, 39);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&Submit";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Send.2.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "Send.Cancel.bmp");
			this.lstImgTlb.Images.SetKeyName(2, "Action.Forward.bmp");
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
			this.btnCancel.Location = new System.Drawing.Point(217, 54);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnCancel.Size = new System.Drawing.Size(105, 39);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
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
			this.Panel3D3.Size = new System.Drawing.Size(325, 24);
			this.Panel3D3.TabIndex = 282;
			//
			//Label7
			//
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label7.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.Label7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label7.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label7.Location = new System.Drawing.Point(7, 3);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(315, 19);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Register for Updates";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label11
			//
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(7, 27);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(94, 21);
			this.Label11.TabIndex = 278;
			this.Label11.Text = "Email Address";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtReplyAddress
			//
			this.txtReplyAddress.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtReplyAddress.Location = new System.Drawing.Point(107, 27);
			this.txtReplyAddress.Name = "txtReplyAddress";
			this.txtReplyAddress.Size = new System.Drawing.Size(215, 21);
			this.txtReplyAddress.TabIndex = 1;
			this.txtReplyAddress.Text = "anonymous@lucid-code.com";
			//
			//RegisterForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(349, 120);
			this.Controls.Add(this.Panel3D1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "RegisterForm";
			this.Text = "Register for Lightened Dream Updates";
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label7;
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
		internal System.Windows.Forms.TextBox txtReplyAddress;
		internal System.Windows.Forms.Label Label11;
	}
}
