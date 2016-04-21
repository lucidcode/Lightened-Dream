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
	partial class FlashesForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashesForm));
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.lblText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//tmrLoad
			//
			this.tmrLoad.Interval = 5000;
			//
			//lblText
			//
			this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblText.Font = new System.Drawing.Font("Lucida Console", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(0, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(666, 410);
			this.lblText.TabIndex = 2;
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//FlashesForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(666, 410);
			this.Controls.Add(this.lblText);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.KeyPreview = true;
			this.Name = "FlashesForm";
			this.ShowInTaskbar = false;
			this.Text = "SubliminalForm";
			this.TopMost = true;
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
		private System.Windows.Forms.Label withEventsField_lblText;
		internal System.Windows.Forms.Label lblText {
			get { return withEventsField_lblText; }
			set {
				if (withEventsField_lblText != null) {
					withEventsField_lblText.Click -= lblText_Click;
				}
				withEventsField_lblText = value;
				if (withEventsField_lblText != null) {
					withEventsField_lblText.Click += lblText_Click;
				}
			}
		}
	}
}
