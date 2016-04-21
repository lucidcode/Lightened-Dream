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
	partial class RecordingViewControl : System.Windows.Forms.UserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingViewControl));
			System.Windows.Forms.ListViewItem ListViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
				"today",
				"xxx"
			}, 0);
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.objPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolStart = new System.Windows.Forms.ToolStripButton();
			this.toolImport = new System.Windows.Forms.ToolStripButton();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.Label2 = new System.Windows.Forms.Label();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.lstRecordings = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.txtSpeech = new System.Windows.Forms.TextBox();
			this.Panel3D2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.objPlayer).BeginInit();
			this.ToolStrip3.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.Controls.Add(this.objPlayer);
			this.Panel3D2.Controls.Add(this.ToolStrip3);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(411, 80);
			this.Panel3D2.TabIndex = 6;
			//
			//objPlayer
			//
			this.objPlayer.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.objPlayer.Enabled = true;
			this.objPlayer.Location = new System.Drawing.Point(112, 29);
			this.objPlayer.Name = "objPlayer";
			this.objPlayer.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("objPlayer.OcxState");
			this.objPlayer.Size = new System.Drawing.Size(294, 45);
			this.objPlayer.TabIndex = 34;
			this.objPlayer.Visible = false;
			//
			//ToolStrip3
			//
			this.ToolStrip3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ToolStrip3.AutoSize = false;
			this.ToolStrip3.BackColor = System.Drawing.Color.Transparent;
			this.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.toolStart,
				this.toolImport
			});
			this.ToolStrip3.Location = new System.Drawing.Point(3, 27);
			this.ToolStrip3.Name = "ToolStrip3";
			this.ToolStrip3.ShowItemToolTips = false;
			this.ToolStrip3.Size = new System.Drawing.Size(470, 54);
			this.ToolStrip3.TabIndex = 33;
			this.ToolStrip3.Text = "ToolStrip3";
			//
			//toolStart
			//
			this.toolStart.AutoSize = false;
			this.toolStart.Image = (System.Drawing.Image)resources.GetObject("toolStart.Image");
			this.toolStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStart.ImageTransparentColor = System.Drawing.Color.White;
			this.toolStart.Name = "toolStart";
			this.toolStart.Size = new System.Drawing.Size(50, 48);
			this.toolStart.Text = "&Start";
			this.toolStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolImport
			//
			this.toolImport.AutoSize = false;
			this.toolImport.Image = (System.Drawing.Image)resources.GetObject("toolImport.Image");
			this.toolImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolImport.ImageTransparentColor = System.Drawing.Color.White;
			this.toolImport.Name = "toolImport";
			this.toolImport.Size = new System.Drawing.Size(50, 48);
			this.toolImport.Text = "&Import";
			this.toolImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(411, 24);
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
			this.Label2.Size = new System.Drawing.Size(398, 19);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Recording";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImg.Images.SetKeyName(0, "File.Recording.ico");
			//
			//lstRecordings
			//
			this.lstRecordings.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lstRecordings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3
			});
			this.lstRecordings.FullRowSelect = true;
			this.lstRecordings.HideSelection = false;
			this.lstRecordings.Items.AddRange(new System.Windows.Forms.ListViewItem[] { ListViewItem1 });
			this.lstRecordings.LabelEdit = true;
			this.lstRecordings.Location = new System.Drawing.Point(3, 158);
			this.lstRecordings.Name = "lstRecordings";
			this.lstRecordings.Size = new System.Drawing.Size(405, 157);
			this.lstRecordings.SmallImageList = this.lstImg;
			this.lstRecordings.TabIndex = 0;
			this.lstRecordings.UseCompatibleStateImageBehavior = false;
			this.lstRecordings.View = System.Windows.Forms.View.Details;
			this.lstRecordings.Visible = false;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.DisplayIndex = 2;
			this.ColumnHeader1.Text = "Description";
			this.ColumnHeader1.Width = 116;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.DisplayIndex = 0;
			this.ColumnHeader2.Text = "Date";
			this.ColumnHeader2.Width = 161;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.DisplayIndex = 1;
			this.ColumnHeader3.Text = "Length";
			this.ColumnHeader3.Width = 88;
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Panel3D1.Controls.Add(this.lstRecordings);
			this.Panel3D1.Controls.Add(this.txtSpeech);
			this.Panel3D1.Location = new System.Drawing.Point(0, 84);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(411, 389);
			this.Panel3D1.TabIndex = 8;
			//
			//txtSpeech
			//
			this.txtSpeech.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtSpeech.Font = new System.Drawing.Font("Calibri", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtSpeech.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtSpeech.Location = new System.Drawing.Point(3, 3);
			this.txtSpeech.Multiline = true;
			this.txtSpeech.Name = "txtSpeech";
			this.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSpeech.Size = new System.Drawing.Size(403, 376);
			this.txtSpeech.TabIndex = 2;
			//
			//RecordingViewControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.Panel3D2);
			this.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Name = "RecordingViewControl";
			this.Size = new System.Drawing.Size(411, 473);
			this.Panel3D2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.objPlayer).EndInit();
			this.ToolStrip3.ResumeLayout(false);
			this.ToolStrip3.PerformLayout();
			this.Panel3D4.ResumeLayout(false);
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		internal System.Windows.Forms.Label Label2;
		internal AxWMPLib.AxWindowsMediaPlayer objPlayer;
		internal System.Windows.Forms.ToolStrip ToolStrip3;
		private System.Windows.Forms.ToolStripButton withEventsField_toolStart;
		internal System.Windows.Forms.ToolStripButton toolStart {
			get { return withEventsField_toolStart; }
			set {
				if (withEventsField_toolStart != null) {
					withEventsField_toolStart.Click -= toolStart_Click;
				}
				withEventsField_toolStart = value;
				if (withEventsField_toolStart != null) {
					withEventsField_toolStart.Click += toolStart_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolImport;
		internal System.Windows.Forms.ToolStripButton toolImport {
			get { return withEventsField_toolImport; }
			set {
				if (withEventsField_toolImport != null) {
					withEventsField_toolImport.Click -= toolImport_Click;
				}
				withEventsField_toolImport = value;
				if (withEventsField_toolImport != null) {
					withEventsField_toolImport.Click += toolImport_Click;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImg;
		internal System.Windows.Forms.ListView lstRecordings;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal lucidcode.Controls.Panel3D Panel3D1;

		public System.Windows.Forms.TextBox txtSpeech;
		public RecordingViewControl()
		{
			InitializeComponent();
		}
	}
}
