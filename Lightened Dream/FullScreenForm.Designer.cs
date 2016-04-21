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
	partial class FullScreenForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullScreenForm));
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.pnlClose = new lucidcode.Controls.Panel3D();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.SuspendLayout();
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImg.Images.SetKeyName(0, "Sounds.ico");
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.pnlContainer);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(836, 498);
			this.Panel3D2.TabIndex = 9;
			//
			//pnlContainer
			//
			this.pnlContainer.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlContainer.Location = new System.Drawing.Point(3, 25);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(830, 470);
			this.pnlContainer.TabIndex = 7;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
			this.Panel3D4.Controls.Add(this.pnlClose);
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.ForeColor = System.Drawing.Color.White;
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(836, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//pnlClose
			//
			this.pnlClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.pnlClose.BackColor = System.Drawing.Color.SteelBlue;
			this.pnlClose.Controls.Add(this.lblClose);
			this.pnlClose.Location = new System.Drawing.Point(813, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Size = new System.Drawing.Size(23, 24);
			this.pnlClose.TabIndex = 6;
			//
			//lblClose
			//
			this.lblClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.lblClose.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lblClose.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblClose.ForeColor = System.Drawing.Color.Black;
			this.lblClose.Location = new System.Drawing.Point(3, 3);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(17, 19);
			this.lblClose.TabIndex = 3;
			this.lblClose.Text = "_";
			this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.Location = new System.Drawing.Point(26, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(807, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Lightened Dream";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Image = (System.Drawing.Image)resources.GetObject("Label2.Image");
			this.Label2.Location = new System.Drawing.Point(4, 4);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(16, 16);
			this.Label2.TabIndex = 4;
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//FullScreenForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(836, 498);
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "FullScreenForm";
			this.ShowInTaskbar = false;
			this.Text = "Lightened Dream";
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.pnlClose.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ImageList lstImg;
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal System.Windows.Forms.Panel pnlContainer;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		internal lucidcode.Controls.Panel3D pnlClose;
		private System.Windows.Forms.Label withEventsField_lblClose;
		public System.Windows.Forms.Label lblClose {
			get { return withEventsField_lblClose; }
			set {
				if (withEventsField_lblClose != null) {
					withEventsField_lblClose.Click -= lblClose_Click;
				}
				withEventsField_lblClose = value;
				if (withEventsField_lblClose != null) {
					withEventsField_lblClose.Click += lblClose_Click;
				}
			}
		}
	}
}
