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
	partial class SubliminalForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubliminalForm));
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.lblText = new System.Windows.Forms.Label();
			this.tmrHide = new System.Windows.Forms.Timer(this.components);
			this.Panel3D1.SuspendLayout();
			this.SuspendLayout();
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
			this.tmrLoad.Interval = 5000;
			//
			//Panel3D1
			//
			this.Panel3D1.Controls.Add(this.lblText);
			this.Panel3D1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D1.Location = new System.Drawing.Point(0, 0);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(192, 21);
			this.Panel3D1.TabIndex = 13;
			//
			//lblText
			//
			this.lblText.AutoSize = true;
			this.lblText.Font = new System.Drawing.Font("Lucida Console", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(2, 2);
			this.lblText.MaximumSize = new System.Drawing.Size(256, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(0, 16);
			this.lblText.TabIndex = 1;
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//tmrHide
			//
			this.tmrHide.Interval = 5000;
			//
			//SubliminalForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(192, 21);
			this.Controls.Add(this.Panel3D1);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "SubliminalForm";
			this.Opacity = 0.8;
			this.ShowInTaskbar = false;
			this.Text = "SubliminalForm";
			this.TopMost = true;
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
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
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Timer withEventsField_tmrHide;
		internal System.Windows.Forms.Timer tmrHide {
			get { return withEventsField_tmrHide; }
			set {
				if (withEventsField_tmrHide != null) {
					withEventsField_tmrHide.Tick -= tmrHide_Tick;
				}
				withEventsField_tmrHide = value;
				if (withEventsField_tmrHide != null) {
					withEventsField_tmrHide.Tick += tmrHide_Tick;
				}
			}
		}
	}
}
