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
	partial class AboutForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			this.panel3D3 = new lucidcode.Controls.Panel3D();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3D2 = new lucidcode.Controls.Panel3D();
			this.lblUpdate = new System.Windows.Forms.LinkLabel();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblWeb = new System.Windows.Forms.LinkLabel();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.panel3D3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			this.panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//panel3D3
			//
			this.panel3D3.Controls.Add(this.PictureBox2);
			this.panel3D3.Location = new System.Drawing.Point(12, 12);
			this.panel3D3.Name = "panel3D3";
			this.panel3D3.Size = new System.Drawing.Size(662, 187);
			this.panel3D3.TabIndex = 15;
			//
			//PictureBox2
			//
			this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
			this.PictureBox2.Location = new System.Drawing.Point(2, 2);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(658, 183);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex = 0;
			this.PictureBox2.TabStop = false;
			//
			//panel3D2
			//
			this.panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.panel3D2.Controls.Add(this.lblUpdate);
			this.panel3D2.Controls.Add(this.Panel3D4);
			this.panel3D2.Controls.Add(this.label6);
			this.panel3D2.Controls.Add(this.lblAuthor);
			this.panel3D2.Controls.Add(this.label1);
			this.panel3D2.Controls.Add(this.lblDescription);
			this.panel3D2.Controls.Add(this.lblWeb);
			this.panel3D2.Controls.Add(this.Label5);
			this.panel3D2.Controls.Add(this.Label8);
			this.panel3D2.Controls.Add(this.label3);
			this.panel3D2.Controls.Add(this.lblCopyright);
			this.panel3D2.Controls.Add(this.label2);
			this.panel3D2.Controls.Add(this.lblVersion);
			this.panel3D2.Controls.Add(this.lblProductName);
			this.panel3D2.Location = new System.Drawing.Point(12, 205);
			this.panel3D2.Name = "panel3D2";
			this.panel3D2.Size = new System.Drawing.Size(662, 165);
			this.panel3D2.TabIndex = 16;
			//
			//lblUpdate
			//
			this.lblUpdate.LinkArea = new System.Windows.Forms.LinkArea(0, 99);
			this.lblUpdate.Location = new System.Drawing.Point(141, 91);
			this.lblUpdate.Name = "lblUpdate";
			this.lblUpdate.Size = new System.Drawing.Size(517, 21);
			this.lblUpdate.TabIndex = 283;
			this.lblUpdate.TabStop = true;
			this.lblUpdate.Text = "(Version 0.0.1 is now available!)";
			this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblUpdate.UseCompatibleTextRendering = true;
			this.lblUpdate.Visible = false;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings1.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings1.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings1.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings1.SettingsKey = "";
			MySettings1.TextBackColor = System.Drawing.Color.White;
			MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings1.TitleForeColor = System.Drawing.Color.White;
			this.Panel3D4.BackColor = MySettings1.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label4);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(662, 24);
			this.Panel3D4.TabIndex = 282;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(7, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(652, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "About";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(8, 3);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 19);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Dream";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label6
			//
			this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label6.Location = new System.Drawing.Point(8, 69);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 280;
			this.label6.Text = "Author";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblAuthor
			//
			this.lblAuthor.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblAuthor.ForeColor = System.Drawing.Color.Black;
			this.lblAuthor.Location = new System.Drawing.Point(104, 69);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(554, 21);
			this.lblAuthor.TabIndex = 281;
			this.lblAuthor.Tag = "";
			this.lblAuthor.Text = "Michael Paul Coder";
			this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label1
			//
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 278;
			this.label1.Text = "Description";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblDescription
			//
			this.lblDescription.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblDescription.ForeColor = System.Drawing.Color.Black;
			this.lblDescription.Location = new System.Drawing.Point(104, 48);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(554, 21);
			this.lblDescription.TabIndex = 279;
			this.lblDescription.Tag = "";
			this.lblDescription.Text = "A dream journal designed to focus your conscious awareness in the dream state.";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblWeb
			//
			this.lblWeb.LinkArea = new System.Windows.Forms.LinkArea(0, 40);
			this.lblWeb.Location = new System.Drawing.Point(103, 132);
			this.lblWeb.Name = "lblWeb";
			this.lblWeb.Size = new System.Drawing.Size(557, 21);
			this.lblWeb.TabIndex = 277;
			this.lblWeb.TabStop = true;
			this.lblWeb.Text = "http://www.lucidcode.com/LightenedDream";
			this.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblWeb.UseCompatibleTextRendering = true;
			//
			//Label5
			//
			this.Label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label5.Location = new System.Drawing.Point(7, 132);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(90, 21);
			this.Label5.TabIndex = 276;
			this.Label5.Text = "Web";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label8
			//
			this.Label8.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label8.Location = new System.Drawing.Point(8, 111);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(90, 21);
			this.Label8.TabIndex = 270;
			this.Label8.Text = "Copyright";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label3
			//
			this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label3.Location = new System.Drawing.Point(8, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 270;
			this.label3.Text = "Version";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblCopyright
			//
			this.lblCopyright.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblCopyright.ForeColor = System.Drawing.Color.Black;
			this.lblCopyright.Location = new System.Drawing.Point(104, 111);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(554, 21);
			this.lblCopyright.TabIndex = 271;
			this.lblCopyright.Tag = "";
			this.lblCopyright.Text = "© 2000 - 2016 lucidcode";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label2
			//
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(8, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 270;
			this.label2.Text = "Product";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblVersion
			//
			this.lblVersion.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblVersion.ForeColor = System.Drawing.Color.Black;
			this.lblVersion.Location = new System.Drawing.Point(104, 90);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(554, 21);
			this.lblVersion.TabIndex = 271;
			this.lblVersion.Tag = "";
			this.lblVersion.Text = "0.0.0";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblProductName
			//
			this.lblProductName.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblProductName.ForeColor = System.Drawing.Color.Black;
			this.lblProductName.Location = new System.Drawing.Point(104, 27);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(554, 21);
			this.lblProductName.TabIndex = 271;
			this.lblProductName.Tag = "";
			this.lblProductName.Text = "Lightened Dream";
			this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
			//
			//AboutForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(683, 380);
			this.Controls.Add(this.panel3D2);
			this.Controls.Add(this.panel3D3);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Text = "About Lightened Dream";
			this.panel3D3.ResumeLayout(false);
			this.panel3D3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			this.panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D panel3D3;
		private System.Windows.Forms.PictureBox PictureBox2;
		internal lucidcode.Controls.Panel3D panel3D2;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label lblAuthor;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.LinkLabel withEventsField_lblWeb;
		internal System.Windows.Forms.LinkLabel lblWeb {
			get { return withEventsField_lblWeb; }
			set {
				if (withEventsField_lblWeb != null) {
					withEventsField_lblWeb.LinkClicked -= LinkLabel1_LinkClicked;
				}
				withEventsField_lblWeb = value;
				if (withEventsField_lblWeb != null) {
					withEventsField_lblWeb.LinkClicked += LinkLabel1_LinkClicked;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Label lblVersion;
		internal System.Windows.Forms.Label lblProductName;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.LinkLabel withEventsField_lblUpdate;
		internal System.Windows.Forms.LinkLabel lblUpdate {
			get { return withEventsField_lblUpdate; }
			set {
				if (withEventsField_lblUpdate != null) {
					withEventsField_lblUpdate.LinkClicked -= lblUpdate_LinkClicked;
				}
				withEventsField_lblUpdate = value;
				if (withEventsField_lblUpdate != null) {
					withEventsField_lblUpdate.LinkClicked += lblUpdate_LinkClicked;
				}
			}
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
		public AboutForm()
		{
			FormClosing += AboutForm_FormClosing;
			Load += AboutForm_Load;
			InitializeComponent();
		}
	}
}
