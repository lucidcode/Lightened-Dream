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
	partial class SupportForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings2 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			this.panel3D2 = new lucidcode.Controls.Panel3D();
			this.webSupport = new System.Windows.Forms.WebBrowser();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.lstImgTlb = new System.Windows.Forms.ImageList(this.components);
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtOS = new System.Windows.Forms.TextBox();
			this.txtReplyAddress = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel3D2.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.SuspendLayout();
			//
			//panel3D2
			//
			this.panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.panel3D2.Controls.Add(this.webSupport);
			this.panel3D2.Location = new System.Drawing.Point(12, 162);
			this.panel3D2.Name = "panel3D2";
			this.panel3D2.Size = new System.Drawing.Size(763, 268);
			this.panel3D2.TabIndex = 16;
			//
			//webSupport
			//
			this.webSupport.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.webSupport.Location = new System.Drawing.Point(3, 3);
			this.webSupport.MinimumSize = new System.Drawing.Size(20, 20);
			this.webSupport.Name = "webSupport";
			this.webSupport.Size = new System.Drawing.Size(757, 262);
			this.webSupport.TabIndex = 283;
			this.webSupport.Url = new System.Uri("", System.UriKind.Relative);
			//
			//Panel3D1
			//
			this.Panel3D1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D1.Controls.Add(this.btnOk);
			this.Panel3D1.Controls.Add(this.btnCancel);
			this.Panel3D1.Controls.Add(this.TableLayoutPanel1);
			this.Panel3D1.Controls.Add(this.txtMessage);
			this.Panel3D1.Controls.Add(this.Panel3D3);
			this.Panel3D1.Controls.Add(this.Label9);
			this.Panel3D1.Location = new System.Drawing.Point(12, 12);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(763, 144);
			this.Panel3D1.TabIndex = 16;
			//
			//lstImgTlb
			//
			this.lstImgTlb.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTlb.ImageStream");
			this.lstImgTlb.TransparentColor = System.Drawing.Color.White;
			this.lstImgTlb.Images.SetKeyName(0, "Send.2.bmp");
			this.lstImgTlb.Images.SetKeyName(1, "Send.Cancel.bmp");
			this.lstImgTlb.Images.SetKeyName(2, "Action.Forward.bmp");
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35f));
			this.TableLayoutPanel1.Controls.Add(this.txtOS, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtReplyAddress, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.cmbType, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(757, 29);
			this.TableLayoutPanel1.TabIndex = 0;
			//
			//txtOS
			//
			this.txtOS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOS.Location = new System.Drawing.Point(227, 3);
			this.txtOS.Name = "txtOS";
			this.txtOS.Size = new System.Drawing.Size(237, 21);
			this.txtOS.TabIndex = 280;
			//
			//txtReplyAddress
			//
			this.txtReplyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtReplyAddress.Location = new System.Drawing.Point(570, 3);
			this.txtReplyAddress.Name = "txtReplyAddress";
			this.txtReplyAddress.Size = new System.Drawing.Size(184, 21);
			this.txtReplyAddress.TabIndex = 1;
			this.txtReplyAddress.Text = "anonymous@lucid-code.com";
			//
			//Label15
			//
			this.Label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label15.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label15.Location = new System.Drawing.Point(3, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(70, 29);
			this.Label15.TabIndex = 270;
			this.Label15.Text = "Type";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cmbType
			//
			this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
				"Bug Report",
				"Feature Request",
				"Comment",
				"Contribution"
			});
			this.cmbType.Location = new System.Drawing.Point(79, 3);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(102, 21);
			this.cmbType.TabIndex = 0;
			//
			//Label11
			//
			this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(470, 0);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(94, 29);
			this.Label11.TabIndex = 278;
			this.Label11.Text = "Reply Address";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(187, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(34, 29);
			this.Label1.TabIndex = 279;
			this.Label1.Text = "OS";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtMessage
			//
			this.txtMessage.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtMessage.Location = new System.Drawing.Point(82, 55);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(564, 84);
			this.txtMessage.TabIndex = 1;
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
			this.Panel3D3.Controls.Add(this.Label7);
			this.Panel3D3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings2, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D3.Location = new System.Drawing.Point(0, 0);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(763, 24);
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
			this.Label7.Size = new System.Drawing.Size(753, 19);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "Feedback";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label9
			//
			this.Label9.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label9.Location = new System.Drawing.Point(8, 54);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(90, 21);
			this.Label9.TabIndex = 280;
			this.Label9.Text = "Message";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
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
			this.btnOk.Location = new System.Drawing.Point(652, 55);
			this.btnOk.Name = "btnOk";
			this.btnOk.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnOk.Size = new System.Drawing.Size(105, 39);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&Submit";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
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
			this.btnCancel.Location = new System.Drawing.Point(652, 100);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.btnCancel.Size = new System.Drawing.Size(105, 39);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//SupportForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(784, 442);
			this.Controls.Add(this.Panel3D1);
			this.Controls.Add(this.panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "SupportForm";
			this.Text = "Support Lightened Dream";
			this.panel3D2.ResumeLayout(false);
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D1;
		internal lucidcode.Controls.Panel3D Panel3D3;
		public System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.WebBrowser webSupport;
		internal System.Windows.Forms.ComboBox cmbType;
		internal System.Windows.Forms.TextBox txtReplyAddress;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.TextBox txtMessage;
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
		internal System.Windows.Forms.TextBox txtOS;
		internal System.Windows.Forms.Label Label1;
	}
}
