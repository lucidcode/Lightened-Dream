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
	partial class ItemViewControl : System.Windows.Forms.UserControl
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
			lucidcode.LightenedDream.Lucidity.My.MySettings MySettings1 = new lucidcode.LightenedDream.Lucidity.My.MySettings();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.Panel3D2 = new lucidcode.Controls.Panel3D();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel3D4 = new lucidcode.Controls.Panel3D();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.NHunspellTextBoxExtender1 = new NHunspellTextBoxExtender();
			this.objRecordingViewControl = new lucidcode.LightenedDream.Lucidity.RecordingViewControl();
			this.objSpeedReadingControl = new lucidcode.LightenedDream.Lucidity.SpeedReadingViewControl();
			this.objSublinalControl = new lucidcode.LightenedDream.Lucidity.SubliminalViewControl();
			this.pnlContainer.SuspendLayout();
			this.Panel3D2.SuspendLayout();
			this.Panel3D4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).BeginInit();
			this.SuspendLayout();
			//
			//pnlContainer
			//
			this.pnlContainer.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlContainer.Controls.Add(this.objRecordingViewControl);
			this.pnlContainer.Controls.Add(this.objSpeedReadingControl);
			this.pnlContainer.Controls.Add(this.objSublinalControl);
			this.pnlContainer.Location = new System.Drawing.Point(0, 98);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(815, 473);
			this.pnlContainer.TabIndex = 0;
			//
			//Panel3D2
			//
			this.Panel3D2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D2.Controls.Add(this.txtDescription);
			this.Panel3D2.Controls.Add(this.Label1);
			this.Panel3D2.Controls.Add(this.Panel3D4);
			this.Panel3D2.Controls.Add(this.txtTitle);
			this.Panel3D2.Controls.Add(this.Label2);
			this.Panel3D2.Location = new System.Drawing.Point(0, 0);
			this.Panel3D2.Name = "Panel3D2";
			this.Panel3D2.Size = new System.Drawing.Size(815, 88);
			this.Panel3D2.TabIndex = 6;
			//
			//txtDescription
			//
			this.txtDescription.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtDescription.Location = new System.Drawing.Point(101, 57);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(709, 21);
			this.txtDescription.TabIndex = 7;
			//
			//Label1
			//
			this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label1.Location = new System.Drawing.Point(8, 57);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(108, 21);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Description";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Panel3D4
			//
			this.Panel3D4.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D4.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.TitleBackColor;
			this.Panel3D4.Controls.Add(this.lblTitle);
			this.Panel3D4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D4.Location = new System.Drawing.Point(0, 0);
			this.Panel3D4.Name = "Panel3D4";
			this.Panel3D4.Size = new System.Drawing.Size(815, 24);
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
			this.lblTitle.Size = new System.Drawing.Size(802, 19);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Title";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//txtTitle
			//
			this.txtTitle.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtTitle.Location = new System.Drawing.Point(101, 30);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(709, 21);
			this.txtTitle.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Label2.Location = new System.Drawing.Point(8, 30);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(108, 21);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Title";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NHunspellTextBoxExtender1
			//
			this.NHunspellTextBoxExtender1.Language = "English";
			this.NHunspellTextBoxExtender1.MaintainUserChoice = false;
			this.NHunspellTextBoxExtender1.NumberofSuggestions = NHunspellTextBoxExtender.SuggestionNumbers.Five;
			this.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7;
			this.NHunspellTextBoxExtender1.SpellAsYouType = true;
			//
			//objRecordingViewControl
			//
			this.objRecordingViewControl.BackColor = System.Drawing.Color.LightSteelBlue;
			this.objRecordingViewControl.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.objRecordingViewControl.ForeColor = System.Drawing.Color.MidnightBlue;
			this.objRecordingViewControl.Location = new System.Drawing.Point(609, 100);
			this.objRecordingViewControl.Name = "objRecordingViewControl";
			this.objRecordingViewControl.Size = new System.Drawing.Size(117, 87);
			this.objRecordingViewControl.TabIndex = 3;
			//
			//objSpeedReadingControl
			//
			this.objSpeedReadingControl.BackColor = System.Drawing.Color.LightSteelBlue;
			this.objSpeedReadingControl.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.objSpeedReadingControl.ForeColor = System.Drawing.Color.MidnightBlue;
			this.objSpeedReadingControl.Location = new System.Drawing.Point(220, 226);
			this.objSpeedReadingControl.Name = "objSpeedReadingControl";
			this.objSpeedReadingControl.Size = new System.Drawing.Size(166, 116);
			this.objSpeedReadingControl.TabIndex = 2;
			//
			//objSublinalControl
			//
			this.objSublinalControl.BackColor = System.Drawing.Color.LightSteelBlue;
			this.objSublinalControl.Font = new System.Drawing.Font("Verdana", 8.25f);
			this.objSublinalControl.ForeColor = System.Drawing.Color.MidnightBlue;
			this.objSublinalControl.Location = new System.Drawing.Point(0, 0);
			this.objSublinalControl.Name = "objSublinalControl";
			this.objSublinalControl.Size = new System.Drawing.Size(540, 199);
			this.objSublinalControl.TabIndex = 0;
			//
			//ItemViewControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormBackColor;
			this.Controls.Add(this.Panel3D2);
			this.Controls.Add(this.pnlContainer);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.Font;
			this.ForeColor = global::lucidcode.LightenedDream.Lucidity.My.MySettings.Default.FormForeColor;
			this.Name = "ItemViewControl";
			this.Size = new System.Drawing.Size(815, 571);
			this.pnlContainer.ResumeLayout(false);
			this.Panel3D2.ResumeLayout(false);
			this.Panel3D2.PerformLayout();
			this.Panel3D4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.NHunspellTextBoxExtender1).EndInit();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel pnlContainer;
		internal lucidcode.Controls.Panel3D Panel3D2;
		internal lucidcode.Controls.Panel3D Panel3D4;
		internal System.Windows.Forms.Label lblTitle;
		internal System.Windows.Forms.TextBox txtTitle;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtDescription;
		internal System.Windows.Forms.Label Label1;
		internal lucidcode.LightenedDream.Lucidity.SubliminalViewControl objSublinalControl;
		internal lucidcode.LightenedDream.Lucidity.SpeedReadingViewControl objSpeedReadingControl;
		internal lucidcode.LightenedDream.Lucidity.RecordingViewControl objRecordingViewControl;

		internal NHunspellTextBoxExtender NHunspellTextBoxExtender1;
	}
}
