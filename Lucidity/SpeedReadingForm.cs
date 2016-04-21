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
	public partial class SpeedReadingForm
	{

		public string[] Messages;

		private int m_intPosition;

		public bool PlayLoop = true;
		public SpeedReadingForm(int Interval)
		{
			Load += SpeedReadingForm_Load;
			KeyDown += SpeedReadingForm_KeyDown;
			FormClosing += SpeedReadingForm_FormClosing;
			InitializeComponent();

			this.Width = Screen.PrimaryScreen.Bounds.Width;
			this.Height = Screen.PrimaryScreen.Bounds.Height;

			tmrLoad.Interval = Interval;
		}

		public void Play()
		{
			tmrLoad.Enabled = true;
			tmrLoad_Tick(null, null);
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			lblText.Text = Messages[m_intPosition].Replace(Constants.vbNewLine, "").Replace(Constants.vbCr, "").Replace(Constants.vbLf, "").Replace(Constants.vbCrLf, "");
			Application.DoEvents();

			m_intPosition += 1;
			if (m_intPosition >= Messages.Length - 1) {
				if (PlayLoop) {
					m_intPosition = 0;
				} else {
					tmrLoad.Enabled = false;
					this.Close();
				}
			}
		}

		private void lblText_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void SpeedReadingForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			Cursor.Show();
		}

		private void SpeedReadingForm_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) {
				Close();
			}

			if (tmrLoad.Enabled == true) {
				lblText.Text = "[PAUSED]";
			} else {
				lblText.Text = Messages[m_intPosition].Replace(Constants.vbNewLine, "").Replace(Constants.vbCr, "").Replace(Constants.vbLf, "").Replace(Constants.vbCrLf, "");
			}
			tmrLoad.Enabled = !tmrLoad.Enabled;
		}

		private void SpeedReadingForm_Load(object sender, System.EventArgs e)
		{
			Cursor.Hide();
		}
	}
}
