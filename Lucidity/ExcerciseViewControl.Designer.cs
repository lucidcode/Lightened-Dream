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
	partial class ExerciseViewControl : System.Windows.Forms.UserControl
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
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings1 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings2 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseViewControl));
			this.txtExercise = new System.Windows.Forms.TextBox();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.txtTask = new System.Windows.Forms.TextBox();
			this.cmbLucidity = new System.Windows.Forms.ComboBox();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lstImg = new System.Windows.Forms.ImageList(this.components);
			this.NHunspellTextBoxExtender1 = new NHunspellTextBoxExtender();
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).BeginInit();
			this.SuspendLayout();
			//
			//txtExercise
			//
			this.txtExercise.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings1.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings1.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings1.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings1.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings1.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings1.SettingsKey = "";
			MySettings1.TextBackColor = System.Drawing.Color.White;
			MySettings1.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings1.TitleForeColor = System.Drawing.Color.White;
			this.txtExercise.BackColor = MySettings1.TextBackColor;
			this.txtExercise.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings1, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtExercise.Font = new System.Drawing.Font("Calibri", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtExercise.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtExercise.Location = new System.Drawing.Point(8, 80);
			this.txtExercise.Multiline = true;
			this.txtExercise.Name = "txtExercise";
			this.txtExercise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtExercise.Size = new System.Drawing.Size(861, 492);
			this.txtExercise.TabIndex = 2;
			//
			//Panel3D2
			//
			this.Panel3D2.Controls.Add(this.txtTask);
			this.Panel3D2.Controls.Add(this.cmbLucidity);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Controls.Add(this.dtDate);
			this.Panel3D2.Controls.Add(this.Label11);
			this.Panel3D2.Controls.Add(this.txtTitle);
			this.Panel3D2.Controls.Add(this.txtExercise);
			this.Panel3D2.Controls.Add(this.Label12);
			this.Panel3D2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(874, 582);
			this.Panel3D2.TabIndex = 8;
			//
			//txtTask
			//
			this.txtTask.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings2.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings2.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings2.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings2.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings2.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings2.SettingsKey = "";
			MySettings2.TextBackColor = System.Drawing.Color.White;
			MySettings2.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings2.TitleForeColor = System.Drawing.Color.White;
			this.txtTask.BackColor = MySettings2.TextBackColor;
			this.txtTask.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings2, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtTask.Font = new System.Drawing.Font("Calibri", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txtTask.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtTask.Location = new System.Drawing.Point(271, 27);
			this.txtTask.Multiline = true;
			this.txtTask.Name = "txtTask";
			this.txtTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTask.Size = new System.Drawing.Size(598, 47);
			this.txtTask.TabIndex = 34;
			//
			//cmbLucidity
			//
			this.cmbLucidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLucidity.FormattingEnabled = true;
			this.cmbLucidity.Items.AddRange(new object[] {
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9"
			});
			this.cmbLucidity.Location = new System.Drawing.Point(233, 53);
			this.cmbLucidity.Name = "cmbLucidity";
			this.cmbLucidity.Size = new System.Drawing.Size(32, 21);
			this.cmbLucidity.TabIndex = 3;
			//
			//dtDate
			//
			this.dtDate.CustomFormat = "ddd yyyy-MM-dd HH:mm";
			this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDate.Location = new System.Drawing.Point(53, 53);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(171, 21);
			this.dtDate.TabIndex = 1;
			//
			//txtTitle
			//
			this.txtTitle.Location = new System.Drawing.Point(53, 27);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(212, 21);
			this.txtTitle.TabIndex = 0;
			//
			//Label11
			//
			this.Label11.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label11.Location = new System.Drawing.Point(8, 27);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(39, 21);
			this.Label11.TabIndex = 31;
			this.Label11.Text = "Title";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label12
			//
			this.Label12.Location = new System.Drawing.Point(7, 53);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(39, 21);
			this.Label12.TabIndex = 29;
			this.Label12.Text = "Date";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = MySettings1.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.Controls.Add(this.Label2);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings1, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(874, 24);
			this.Panel3D4.TabIndex = 5;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblTitle.ForeColor = MySettings1.TitleForeColor;
			this.lblTitle.Location = new System.Drawing.Point(7, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(864, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Title";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", MySettings1, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.ForeColor = MySettings1.TitleForeColor;
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
			this.NHunspellTextBoxExtender1.NumberofSuggestions = NHunspellTextBoxExtender.SuggestionNumbers.Five;
			this.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7;
			this.NHunspellTextBoxExtender1.SpellAsYouType = true;
			//
			//ExerciseViewControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = MySettings1.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", MySettings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings1, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", MySettings1, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = MySettings1.Font;
			this.ForeColor = MySettings1.FormForeColor;
			this.Name = "ExerciseViewControl";
			this.Size = new System.Drawing.Size(874, 582);
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D2.PerformLayout();
			this.Panel3D4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).EndInit();
			this.ResumeLayout(false);

		}
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ImageList lstImg;
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
		private System.Windows.Forms.TextBox withEventsField_txtExercise;
		public System.Windows.Forms.TextBox txtExercise {
			get { return withEventsField_txtExercise; }
			set {
				if (withEventsField_txtExercise != null) {
					withEventsField_txtExercise.TextChanged -= txtExercise_TextChanged;
				}
				withEventsField_txtExercise = value;
				if (withEventsField_txtExercise != null) {
					withEventsField_txtExercise.TextChanged += txtExercise_TextChanged;
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

		public System.Windows.Forms.TextBox txtTask;
	}
}
