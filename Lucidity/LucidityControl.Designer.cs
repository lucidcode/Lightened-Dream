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
	partial class LucidityControl : System.Windows.Forms.UserControl
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem ListViewItem1 = new System.Windows.Forms.ListViewItem("REM Cycles", 0);
			System.Windows.Forms.ListViewItem ListViewItem2 = new System.Windows.Forms.ListViewItem("Checks", 1);
			System.Windows.Forms.ListViewItem ListViewItem3 = new System.Windows.Forms.ListViewItem("Subliminals", 2);
			System.Windows.Forms.ListViewItem ListViewItem4 = new System.Windows.Forms.ListViewItem("Recordings", 3);
			System.Windows.Forms.ListViewItem ListViewItem5 = new System.Windows.Forms.ListViewItem("Readings", 4);
			System.Windows.Forms.ListViewItem ListViewItem6 = new System.Windows.Forms.ListViewItem("Exercises", 5);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LucidityControl));
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lstLucidity = new System.Windows.Forms.ListView();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.BackColor = System.Drawing.Color.White;
			this.Panel3D2.Controls.Add(this.lstLucidity);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(700, 535);
			this.Panel3D2.TabIndex = 6;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(700, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(8, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(687, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Lucidity";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstLucidity
			//
			this.lstLucidity.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstLucidity.BackColor = System.Drawing.Color.White;
			this.lstLucidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstLucidity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lstLucidity.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor;
			this.lstLucidity.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
				ListViewItem1,
				ListViewItem2,
				ListViewItem3,
				ListViewItem4,
				ListViewItem5,
				ListViewItem6
			});
			this.lstLucidity.LargeImageList = this.lstImg;
			this.lstLucidity.Location = new System.Drawing.Point(3, 30);
			this.lstLucidity.Name = "lstLucidity";
			this.lstLucidity.Scrollable = false;
			this.lstLucidity.Size = new System.Drawing.Size(692, 502);
			this.lstLucidity.TabIndex = 6;
			this.lstLucidity.UseCompatibleStateImageBehavior = false;
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.White;
			this.lstImg.Images.SetKeyName(0, "REM Cycles");
			this.lstImg.Images.SetKeyName(1, "Checks");
			this.lstImg.Images.SetKeyName(2, "Subliminals");
			this.lstImg.Images.SetKeyName(3, "Recordings");
			this.lstImg.Images.SetKeyName(4, "Checks");
			this.lstImg.Images.SetKeyName(5, "Graph.Exercise2.bmp");
			//
			//LucidityControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor;
			this.Name = "LucidityControl";
			this.Size = new System.Drawing.Size(700, 535);
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		internal System.Windows.Forms.Label lblTitle;
		internal System.Windows.Forms.ImageList lstImg;
		private System.Windows.Forms.ListView withEventsField_lstLucidity;
		internal System.Windows.Forms.ListView lstLucidity {
			get { return withEventsField_lstLucidity; }
			set {
				if (withEventsField_lstLucidity != null) {
					withEventsField_lstLucidity.MouseMove -= lstLucdity_MouseMove;
					withEventsField_lstLucidity.SelectedIndexChanged -= lstLucdity_SelectedIndexChanged;
				}
				withEventsField_lstLucidity = value;
				if (withEventsField_lstLucidity != null) {
					withEventsField_lstLucidity.MouseMove += lstLucdity_MouseMove;
					withEventsField_lstLucidity.SelectedIndexChanged += lstLucdity_SelectedIndexChanged;
				}
			}

		}
	}
}
