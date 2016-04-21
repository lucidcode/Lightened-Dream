using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Dreams
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class DreamViewControl : System.Windows.Forms.UserControl
	{

		//UserControl1 overrides dispose to clean up the component list.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DreamViewControl));
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pnlText = new lucidcode.Controls.Panel3D();
			this.txtDream = new System.Windows.Forms.TextBox();
			this.pnlControls = new lucidcode.Controls.Panel3D();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.dtStart = new System.Windows.Forms.DateTimePicker();
			this.cmbLucidity = new System.Windows.Forms.ComboBox();
			this.dtEnd = new System.Windows.Forms.DateTimePicker();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.objDreamSlider = new lucidcode.Controls.MultiSliderControl.SliderControl();
			this.pnlDreamImage = new lucidcode.Controls.Panel3D();
			this.pbDream = new System.Windows.Forms.PictureBox();
			this.mnuThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuThumbnailCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuThumbnailPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.NHunspellTextBoxExtender1 = new NHunspellTextBoxExtender();
			this.lstImgDreams = new System.Windows.Forms.ImageList(this.components);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Panel3D2.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.pnlText.SuspendLayout();
			this.pnlControls.SuspendLayout();
			this.pnlDreamImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pbDream).BeginInit();
			this.mnuThumbnail.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).BeginInit();
			this.SuspendLayout();
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.SplitContainer1);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(874, 582);
			this.Panel3D2.TabIndex = 8;
			//
			//SplitContainer1
			//
			this.SplitContainer1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.SplitContainer1.Location = new System.Drawing.Point(3, 25);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.pnlText);
			this.SplitContainer1.Panel1.Controls.Add(this.pnlControls);
			this.SplitContainer1.Panel1.Controls.Add(this.pnlDreamImage);
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.txtComments);
			this.SplitContainer1.Size = new System.Drawing.Size(868, 554);
			this.SplitContainer1.SplitterDistance = 420;
			this.SplitContainer1.SplitterWidth = 2;
			this.SplitContainer1.TabIndex = 11;
			//
			//pnlText
			//
			this.pnlText.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlText.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.pnlText.Controls.Add(this.txtDream);
			this.pnlText.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlText.Location = new System.Drawing.Point(4, 123);
			this.pnlText.Name = "pnlText";
			this.pnlText.Size = new System.Drawing.Size(861, 294);
			this.pnlText.TabIndex = 42;
			//
			//txtDream
			//
			this.txtDream.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtDream.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TextBackColor;
			this.txtDream.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDream.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtDream.Font = new System.Drawing.Font("Calibri", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtDream.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtDream.Location = new System.Drawing.Point(2, 2);
			this.txtDream.Multiline = true;
			this.txtDream.Name = "txtDream";
			this.txtDream.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDream.Size = new System.Drawing.Size(857, 290);
			this.txtDream.TabIndex = 2;
			//
			//pnlControls
			//
			this.pnlControls.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlControls.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.pnlControls.Controls.Add(this.Label11);
			this.pnlControls.Controls.Add(this.Label12);
			this.pnlControls.Controls.Add(this.dtStart);
			this.pnlControls.Controls.Add(this.cmbLucidity);
			this.pnlControls.Controls.Add(this.dtEnd);
			this.pnlControls.Controls.Add(this.txtTitle);
			this.pnlControls.Controls.Add(this.dtDate);
			this.pnlControls.Controls.Add(this.objDreamSlider);
			this.pnlControls.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlControls.Location = new System.Drawing.Point(83, 5);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(782, 114);
			this.pnlControls.TabIndex = 41;
			//
			//Label11
			//
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(5, 6);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(38, 21);
			this.Label11.TabIndex = 31;
			this.Label11.Text = "Title";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label12
			//
			this.Label12.Location = new System.Drawing.Point(5, 35);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(37, 21);
			this.Label12.TabIndex = 29;
			this.Label12.Text = "Date";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//dtStart
			//
			this.dtStart.CustomFormat = "HH:mm";
			this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtStart.Location = new System.Drawing.Point(229, 35);
			this.dtStart.Name = "dtStart";
			this.dtStart.ShowUpDown = true;
			this.dtStart.Size = new System.Drawing.Size(58, 21);
			this.dtStart.TabIndex = 4;
			this.ToolTip1.SetToolTip(this.dtStart, "Sleep start time (time you fell asleep)");
			this.dtStart.Value = new System.DateTime(2009, 12, 2, 23, 0, 0, 0);
			//
			//cmbLucidity
			//
			this.cmbLucidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLucidity.FormattingEnabled = true;
			this.cmbLucidity.Items.AddRange(new object[] {
				"1 Thought",
				"2 Daydream",
				"3 Nightmare",
				"4 Foggy Dream",
				"5 Normal Dream",
				"6 Vivid Dream",
				"7 Lucid Dream",
				"8 Epic Dream",
				"9 Wake Induced"
			});
			this.cmbLucidity.Location = new System.Drawing.Point(229, 6);
			this.cmbLucidity.Name = "cmbLucidity";
			this.cmbLucidity.Size = new System.Drawing.Size(122, 21);
			this.cmbLucidity.TabIndex = 3;
			this.ToolTip1.SetToolTip(this.cmbLucidity, "Type of dream");
			//
			//dtEnd
			//
			this.dtEnd.CustomFormat = "HH:mm";
			this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtEnd.Location = new System.Drawing.Point(293, 35);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.ShowUpDown = true;
			this.dtEnd.Size = new System.Drawing.Size(58, 21);
			this.dtEnd.TabIndex = 5;
			this.ToolTip1.SetToolTip(this.dtEnd, "Sleep end time (time you woke up)");
			this.dtEnd.Value = new System.DateTime(2009, 12, 2, 6, 0, 0, 0);
			//
			//txtTitle
			//
			this.txtTitle.Location = new System.Drawing.Point(49, 6);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(171, 21);
			this.txtTitle.TabIndex = 0;
			this.ToolTip1.SetToolTip(this.txtTitle, "Title of the dream");
			//
			//dtDate
			//
			this.dtDate.CustomFormat = "ddd yyyy-MM-dd HH:mm";
			this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDate.Location = new System.Drawing.Point(49, 35);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(171, 21);
			this.dtDate.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.dtDate, "Date and time of the dream");
			//
			//objDreamSlider
			//
			this.objDreamSlider.AllowDream = true;
			this.objDreamSlider.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.objDreamSlider.DisplayInterval = 12;
			this.objDreamSlider.DreamTime = System.TimeSpan.Parse("23:30:00");
			this.objDreamSlider.Increment = 10;
			this.objDreamSlider.Location = new System.Drawing.Point(5, 63);
			this.objDreamSlider.Maximum = System.TimeSpan.Parse("12:00:00");
			this.objDreamSlider.Minimum = System.TimeSpan.Parse("12:00:01");
			this.objDreamSlider.Name = "objDreamSlider";
			this.objDreamSlider.ShowIncrement = true;
			this.objDreamSlider.Size = new System.Drawing.Size(772, 49);
			this.objDreamSlider.StartTime = System.TimeSpan.Parse("22:30:01");
			this.objDreamSlider.StopTime = System.TimeSpan.Parse("23:50:00");
			this.objDreamSlider.TabIndex = 38;
			//
			//pnlDreamImage
			//
			this.pnlDreamImage.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.pnlDreamImage.Controls.Add(this.pbDream);
			this.pnlDreamImage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlDreamImage.Location = new System.Drawing.Point(4, 5);
			this.pnlDreamImage.Name = "pnlDreamImage";
			this.pnlDreamImage.Size = new System.Drawing.Size(75, 114);
			this.pnlDreamImage.TabIndex = 39;
			//
			//pbDream
			//
			this.pbDream.ContextMenuStrip = this.mnuThumbnail;
			this.pbDream.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbDream.Location = new System.Drawing.Point(2, 2);
			this.pbDream.Name = "pbDream";
			this.pbDream.Size = new System.Drawing.Size(71, 110);
			this.pbDream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbDream.TabIndex = 40;
			this.pbDream.TabStop = false;
			//
			//mnuThumbnail
			//
			this.mnuThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuThumbnailCopy,
				this.mnuThumbnailPaste
			});
			this.mnuThumbnail.Name = "mnuThumbnail";
			this.mnuThumbnail.Size = new System.Drawing.Size(103, 48);
			//
			//mnuThumbnailCopy
			//
			this.mnuThumbnailCopy.Name = "mnuThumbnailCopy";
			this.mnuThumbnailCopy.Size = new System.Drawing.Size(102, 22);
			this.mnuThumbnailCopy.Text = "&Copy";
			//
			//mnuThumbnailPaste
			//
			this.mnuThumbnailPaste.Name = "mnuThumbnailPaste";
			this.mnuThumbnailPaste.Size = new System.Drawing.Size(102, 22);
			this.mnuThumbnailPaste.Text = "&Paste";
			//
			//txtComments
			//
			this.txtComments.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtComments.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TextBackColor;
			this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtComments.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtComments.Font = new System.Drawing.Font("Calibri", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtComments.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtComments.Location = new System.Drawing.Point(4, 1);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtComments.Size = new System.Drawing.Size(859, 128);
			this.txtComments.TabIndex = 3;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(874, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(7, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(864, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Title";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.TitleForeColor;
			this.Label2.Location = new System.Drawing.Point(8, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 19);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Dream";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lstImg
			//
			this.lstImg.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImg.ImageStream");
			this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImg.Images.SetKeyName(0, "Categories.ico");
			this.lstImg.Images.SetKeyName(1, "Lucidity.ico");
			//
			//NHunspellTextBoxExtender1
			//
			this.NHunspellTextBoxExtender1.Language = "English";
			this.NHunspellTextBoxExtender1.MaintainUserChoice = false;
			this.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7;
			this.NHunspellTextBoxExtender1.SpellAsYouType = true;
			//
			//lstImgDreams
			//
			this.lstImgDreams.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgDreams.ImageStream");
			this.lstImgDreams.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImgDreams.Images.SetKeyName(0, "1.png");
			this.lstImgDreams.Images.SetKeyName(1, "2.png");
			this.lstImgDreams.Images.SetKeyName(2, "4.png");
			this.lstImgDreams.Images.SetKeyName(3, "5.png");
			this.lstImgDreams.Images.SetKeyName(4, "6.png");
			this.lstImgDreams.Images.SetKeyName(5, "7.png");
			this.lstImgDreams.Images.SetKeyName(6, "8.png");
			this.lstImgDreams.Images.SetKeyName(7, "9.png");
			this.lstImgDreams.Images.SetKeyName(8, "10.png");
			this.lstImgDreams.Images.SetKeyName(9, "11.png");
			this.lstImgDreams.Images.SetKeyName(10, "13.png");
			//
			//ToolTip1
			//
			this.ToolTip1.AutoPopDelay = 5000;
			this.ToolTip1.BackColor = System.Drawing.Color.SteelBlue;
			this.ToolTip1.ForeColor = System.Drawing.Color.White;
			this.ToolTip1.InitialDelay = 500;
			this.ToolTip1.IsBalloon = true;
			this.ToolTip1.ReshowDelay = 100;
			//
			//DreamViewControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Dreams.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Dreams.My.MySettings.Default.FormForeColor;
			this.Name = "DreamViewControl";
			this.Size = new System.Drawing.Size(874, 582);
			this.Panel3D2.ResumeLayout(false);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.Panel2.PerformLayout();
			this.SplitContainer1.ResumeLayout(false);
			this.pnlText.ResumeLayout(false);
			this.pnlText.PerformLayout();
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			this.pnlDreamImage.ResumeLayout(false);
			this.pnlDreamImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.pbDream).EndInit();
			this.mnuThumbnail.ResumeLayout(false);
			this.Panel3D4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).EndInit();
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ImageList lstImg;
		internal System.Windows.Forms.SplitContainer SplitContainer1;
		private System.Windows.Forms.DateTimePicker withEventsField_dtEnd;
		internal System.Windows.Forms.DateTimePicker dtEnd {
			get { return withEventsField_dtEnd; }
			set {
				if (withEventsField_dtEnd != null) {
					withEventsField_dtEnd.ValueChanged -= dtEnd_ValueChanged;
				}
				withEventsField_dtEnd = value;
				if (withEventsField_dtEnd != null) {
					withEventsField_dtEnd.ValueChanged += dtEnd_ValueChanged;
				}
			}
		}
		private System.Windows.Forms.DateTimePicker withEventsField_dtStart;
		internal System.Windows.Forms.DateTimePicker dtStart {
			get { return withEventsField_dtStart; }
			set {
				if (withEventsField_dtStart != null) {
					withEventsField_dtStart.ValueChanged -= dtStart_ValueChanged;
				}
				withEventsField_dtStart = value;
				if (withEventsField_dtStart != null) {
					withEventsField_dtStart.ValueChanged += dtStart_ValueChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtTitle;
		internal System.Windows.Forms.TextBox txtTitle {
			get { return withEventsField_txtTitle; }
			set {
				if (withEventsField_txtTitle != null) {
					withEventsField_txtTitle.TextChanged -= txtTitle_TextChanged;
				}
				withEventsField_txtTitle = value;
				if (withEventsField_txtTitle != null) {
					withEventsField_txtTitle.TextChanged += txtTitle_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		private System.Windows.Forms.DateTimePicker withEventsField_dtDate;
		public System.Windows.Forms.DateTimePicker dtDate {
			get { return withEventsField_dtDate; }
			set {
				if (withEventsField_dtDate != null) {
					withEventsField_dtDate.ValueChanged -= dtDate_ValueChanged;
				}
				withEventsField_dtDate = value;
				if (withEventsField_dtDate != null) {
					withEventsField_dtDate.ValueChanged += dtDate_ValueChanged;
				}
			}
		}
		private lucidcode.Controls.MultiSliderControl.SliderControl withEventsField_objDreamSlider;
		internal lucidcode.Controls.MultiSliderControl.SliderControl objDreamSlider {
			get { return withEventsField_objDreamSlider; }
			set {
				if (withEventsField_objDreamSlider != null) {
					withEventsField_objDreamSlider.Resize -= objSleepHours_Resize;
					withEventsField_objDreamSlider.StartTimeChanged -= objDreamSlider_StartTimeChanged;
					withEventsField_objDreamSlider.EndTimeChanged -= objDreamSlider_EndTimeChanged;
					withEventsField_objDreamSlider.DreamTimeChanged -= objDreamSlider_DreamTimeChanged;
				}
				withEventsField_objDreamSlider = value;
				if (withEventsField_objDreamSlider != null) {
					withEventsField_objDreamSlider.Resize += objSleepHours_Resize;
					withEventsField_objDreamSlider.StartTimeChanged += objDreamSlider_StartTimeChanged;
					withEventsField_objDreamSlider.EndTimeChanged += objDreamSlider_EndTimeChanged;
					withEventsField_objDreamSlider.DreamTimeChanged += objDreamSlider_DreamTimeChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cmbLucidity;
		internal System.Windows.Forms.ComboBox cmbLucidity {
			get { return withEventsField_cmbLucidity; }
			set {
				if (withEventsField_cmbLucidity != null) {
					withEventsField_cmbLucidity.SelectedIndexChanged -= cmbLucidity_SelectedIndexChanged;
				}
				withEventsField_cmbLucidity = value;
				if (withEventsField_cmbLucidity != null) {
					withEventsField_cmbLucidity.SelectedIndexChanged += cmbLucidity_SelectedIndexChanged;
				}
			}
		}
		internal NHunspellTextBoxExtender NHunspellTextBoxExtender1;
		internal lucidcode.Controls.Panel3D pnlDreamImage;
		private System.Windows.Forms.PictureBox withEventsField_pbDream;
		internal System.Windows.Forms.PictureBox pbDream {
			get { return withEventsField_pbDream; }
			set {
				if (withEventsField_pbDream != null) {
					withEventsField_pbDream.MouseClick -= pbDream_MouseClick;
				}
				withEventsField_pbDream = value;
				if (withEventsField_pbDream != null) {
					withEventsField_pbDream.MouseClick += pbDream_MouseClick;
				}
			}
		}
		internal lucidcode.Controls.Panel3D pnlText;
		private System.Windows.Forms.TextBox withEventsField_txtDream;
		public System.Windows.Forms.TextBox txtDream {
			get { return withEventsField_txtDream; }
			set {
				if (withEventsField_txtDream != null) {
					withEventsField_txtDream.TextChanged -= txtDream_TextChanged;
				}
				withEventsField_txtDream = value;
				if (withEventsField_txtDream != null) {
					withEventsField_txtDream.TextChanged += txtDream_TextChanged;
				}
			}
		}
		internal lucidcode.Controls.Panel3D pnlControls;
		private System.Windows.Forms.ContextMenuStrip withEventsField_mnuThumbnail;
		internal System.Windows.Forms.ContextMenuStrip mnuThumbnail {
			get { return withEventsField_mnuThumbnail; }
			set {
				if (withEventsField_mnuThumbnail != null) {
					withEventsField_mnuThumbnail.Opening -= mnuThumbnail_Opening;
				}
				withEventsField_mnuThumbnail = value;
				if (withEventsField_mnuThumbnail != null) {
					withEventsField_mnuThumbnail.Opening += mnuThumbnail_Opening;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuThumbnailCopy;
		internal System.Windows.Forms.ToolStripMenuItem mnuThumbnailCopy {
			get { return withEventsField_mnuThumbnailCopy; }
			set {
				if (withEventsField_mnuThumbnailCopy != null) {
					withEventsField_mnuThumbnailCopy.Click -= mnuThumbnailCopy_Click;
				}
				withEventsField_mnuThumbnailCopy = value;
				if (withEventsField_mnuThumbnailCopy != null) {
					withEventsField_mnuThumbnailCopy.Click += mnuThumbnailCopy_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuThumbnailPaste;
		internal System.Windows.Forms.ToolStripMenuItem mnuThumbnailPaste {
			get { return withEventsField_mnuThumbnailPaste; }
			set {
				if (withEventsField_mnuThumbnailPaste != null) {
					withEventsField_mnuThumbnailPaste.Click -= mnuThumbnailPaste_Click;
				}
				withEventsField_mnuThumbnailPaste = value;
				if (withEventsField_mnuThumbnailPaste != null) {
					withEventsField_mnuThumbnailPaste.Click += mnuThumbnailPaste_Click;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImgDreams;
		internal System.Windows.Forms.ToolTip ToolTip1;

		public System.Windows.Forms.TextBox txtComments;
	}
}
