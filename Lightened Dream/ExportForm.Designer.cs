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
	partial class ExportForm : System.Windows.Forms.Form
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
			System.Windows.Forms.TreeNode TreeNode1 = new System.Windows.Forms.TreeNode("Dreams");
			System.Windows.Forms.TreeNode TreeNode2 = new System.Windows.Forms.TreeNode("Characters");
			System.Windows.Forms.TreeNode TreeNode3 = new System.Windows.Forms.TreeNode("Locations");
			System.Windows.Forms.TreeNode TreeNode4 = new System.Windows.Forms.TreeNode("Objects");
			System.Windows.Forms.TreeNode TreeNode5 = new System.Windows.Forms.TreeNode("Actions");
			System.Windows.Forms.TreeNode TreeNode6 = new System.Windows.Forms.TreeNode("Themes");
			System.Windows.Forms.TreeNode TreeNode7 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
				TreeNode2,
				TreeNode3,
				TreeNode4,
				TreeNode5,
				TreeNode6
			});
			System.Windows.Forms.TreeNode TreeNode8 = new System.Windows.Forms.TreeNode("REM Cycles");
			System.Windows.Forms.TreeNode TreeNode9 = new System.Windows.Forms.TreeNode("Reality Checks");
			System.Windows.Forms.TreeNode TreeNode10 = new System.Windows.Forms.TreeNode("Dream Inductions");
			System.Windows.Forms.TreeNode TreeNode11 = new System.Windows.Forms.TreeNode("Lucidity", new System.Windows.Forms.TreeNode[] {
				TreeNode8,
				TreeNode9,
				TreeNode10
			});
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings2 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
			this.panel3D2 = new lucidcode.Controls.Panel3D();
			this.trvMain = new System.Windows.Forms.TreeView();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.chkSelectAll = new System.Windows.Forms.CheckBox();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.pgbStatus = new System.Windows.Forms.ProgressBar();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.lstImgTrv = new System.Windows.Forms.ImageList(this.components);
			this.panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//panel3D2
			//
			this.panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.panel3D2.Controls.Add(this.trvMain);
			this.panel3D2.Controls.Add(this.Panel3D4);
			this.panel3D2.Location = new System.Drawing.Point(12, 12);
			this.panel3D2.Name = "panel3D2";
			this.panel3D2.Size = new System.Drawing.Size(268, 325);
			this.panel3D2.TabIndex = 16;
			//
			//trvMain
			//
			this.trvMain.AllowDrop = true;
			this.trvMain.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.trvMain.BackColor = global::LightenedDream.My.MySettings.Default.TextBackColor;
			this.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvMain.CheckBoxes = true;
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.trvMain.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.trvMain.HideSelection = false;
			this.trvMain.ImageIndex = 0;
			this.trvMain.ImageList = this.lstImgTrv;
			this.trvMain.Indent = 19;
			this.trvMain.ItemHeight = 18;
			this.trvMain.Location = new System.Drawing.Point(3, 25);
			this.trvMain.Name = "trvMain";
			TreeNode1.Name = "Node0";
			TreeNode1.Text = "Dreams";
			TreeNode2.Name = "Node1";
			TreeNode2.Text = "Characters";
			TreeNode3.Name = "Node3";
			TreeNode3.Text = "Locations";
			TreeNode4.Name = "Node4";
			TreeNode4.Text = "Objects";
			TreeNode5.Name = "Node0";
			TreeNode5.Text = "Actions";
			TreeNode6.Name = "Node5";
			TreeNode6.Text = "Themes";
			TreeNode7.Name = "Node14";
			TreeNode7.Text = "Categories";
			TreeNode8.Name = "Node10";
			TreeNode8.Text = "REM Cycles";
			TreeNode9.Name = "Node11";
			TreeNode9.Text = "Reality Checks";
			TreeNode10.Name = "Node12";
			TreeNode10.Text = "Dream Inductions";
			TreeNode11.Name = "Node8";
			TreeNode11.Text = "Lucidity";
			this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
				TreeNode1,
				TreeNode7,
				TreeNode11
			});
			this.trvMain.SelectedImageIndex = 1;
			this.trvMain.Size = new System.Drawing.Size(262, 297);
			this.trvMain.TabIndex = 17;
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
			this.Panel3D4.Size = new System.Drawing.Size(268, 24);
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
			this.lblTitle.Size = new System.Drawing.Size(258, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Export";
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
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.btnOk);
			this.Panel3D1.Controls.Add(this.btnCancel);
			this.Panel3D1.Controls.Add(this.chkSelectAll);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Location = new System.Drawing.Point(12, 343);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(268, 66);
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
			this.btnOk.Location = new System.Drawing.Point(86, 26);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnOk.Size = new System.Drawing.Size(81, 37);
			this.btnOk.TabIndex = 309;
			this.btnOk.Text = "&OK";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
			//
			//btnCancel
			//
			this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10f);
			this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.ImageIndex = 0;
			this.btnCancel.Location = new System.Drawing.Point(173, 26);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnCancel.Size = new System.Drawing.Size(92, 37);
			this.btnCancel.TabIndex = 308;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//chkSelectAll
			//
			this.chkSelectAll.AutoSize = true;
			this.chkSelectAll.Location = new System.Drawing.Point(11, 30);
			this.chkSelectAll.Name = "chkSelectAll";
			this.chkSelectAll.Size = new System.Drawing.Size(79, 17);
			this.chkSelectAll.TabIndex = 283;
			this.chkSelectAll.Text = "&Select All";
			this.chkSelectAll.UseVisualStyleBackColor = true;
			//
			//Panel3D3
			//
			this.Panel3D3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings2.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings2.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings2.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings2.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings2.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings2.SettingsKey = "";
			MySettings2.TextBackColor = System.Drawing.Color.White;
			MySettings2.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings2.TitleForeColor = System.Drawing.Color.White;
			this.Panel3D3.BackColor = MySettings2.TitleBackColor;
			this.Panel3D3.Controls.Add(this.Label1);
			this.Panel3D3.Controls.Add(this.Label2);
			this.Panel3D3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings2, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D3.Location = new System.Drawing.Point(0, 0);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(268, 24);
			this.Panel3D3.TabIndex = 282;
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label1.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.Label1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label1.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label1.Location = new System.Drawing.Point(7, 3);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(258, 19);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Options";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 19);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Dream";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//pgbStatus
			//
			this.pgbStatus.Location = new System.Drawing.Point(12, 426);
			this.pgbStatus.Name = "pgbStatus";
			this.pgbStatus.Size = new System.Drawing.Size(268, 27);
			this.pgbStatus.TabIndex = 310;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Function.Play.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "File.LucidScribe.Add.bmp");
			//
			//lstImgTrv
			//
			this.lstImgTrv.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTrv.ImageStream");
			this.lstImgTrv.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImgTrv.Images.SetKeyName(0, "Folder.16.ico");
			this.lstImgTrv.Images.SetKeyName(1, "Folder.Open.16.ico");
			this.lstImgTrv.Images.SetKeyName(2, "File.Characters0");
			this.lstImgTrv.Images.SetKeyName(3, "File.Characters");
			this.lstImgTrv.Images.SetKeyName(4, "File.Locations");
			this.lstImgTrv.Images.SetKeyName(5, "File.Objects");
			this.lstImgTrv.Images.SetKeyName(6, "File.Themes");
			this.lstImgTrv.Images.SetKeyName(7, "File.Emotions");
			this.lstImgTrv.Images.SetKeyName(8, "File.Actions");
			this.lstImgTrv.Images.SetKeyName(9, "File.Recordings");
			this.lstImgTrv.Images.SetKeyName(10, "File.Subliminals");
			this.lstImgTrv.Images.SetKeyName(11, "File.Checks");
			this.lstImgTrv.Images.SetKeyName(12, "File.Readings");
			this.lstImgTrv.Images.SetKeyName(13, "File.REM Cycles");
			this.lstImgTrv.Images.SetKeyName(14, "Dream");
			//
			//ExportForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(289, 465);
			this.Controls.Add(this.pgbStatus);
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportForm";
			this.Text = "Export";
			this.panel3D2.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label4;
		private System.Windows.Forms.TreeView withEventsField_trvMain;
		internal System.Windows.Forms.TreeView trvMain {
			get { return withEventsField_trvMain; }
			set {
				if (withEventsField_trvMain != null) {
					withEventsField_trvMain.AfterCheck -= trvMain_AfterCheck;
				}
				withEventsField_trvMain = value;
				if (withEventsField_trvMain != null) {
					withEventsField_trvMain.AfterCheck += trvMain_AfterCheck;
				}
			}
		}
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		private System.Windows.Forms.CheckBox withEventsField_chkSelectAll;
		internal System.Windows.Forms.CheckBox chkSelectAll {
			get { return withEventsField_chkSelectAll; }
			set {
				if (withEventsField_chkSelectAll != null) {
					withEventsField_chkSelectAll.CheckedChanged -= chkSelectAll_CheckedChanged;
				}
				withEventsField_chkSelectAll = value;
				if (withEventsField_chkSelectAll != null) {
					withEventsField_chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
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
		internal System.Windows.Forms.ProgressBar pgbStatus;
		internal System.Windows.Forms.ImageList lstImgTrv;
		private System.Windows.Forms.ImageList lstImgTlb;
	}
}
