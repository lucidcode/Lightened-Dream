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
	public partial class FlashesForm
	{

		private int m_intPosition;
		public Color FlashColor;
		public Color BGColor;
		public int Timeout = 1000;

		private bool m_boolOn = false;

		public FlashesForm(int Interval)
		{
			Load += SpeedReadingForm_Load;
			KeyDown += SpeedReadingForm_KeyDown;
			FormClosing += SpeedReadingForm_FormClosing;
			Click += FlashesForm_Click;
			InitializeComponent();

			this.Width = Screen.PrimaryScreen.Bounds.Width;
			this.Height = Screen.PrimaryScreen.Bounds.Height;

			tmrLoad.Interval = Interval;
		}

		public void Play()
		{
			tmrLoad.Enabled = true;
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;
			if (m_boolOn) {
				m_boolOn = false;
				lblText.BackColor = BGColor;
			} else {
				m_boolOn = true;
				lblText.BackColor = FlashColor;
			}

			m_intPosition += 1;

			if (m_intPosition >= Timeout) {
				tmrLoad.Enabled = false;
				Close();
				return;
			}
			tmrLoad.Enabled = true;
		}

		private void lblText_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void FlashesForm_Click(object sender, System.EventArgs e)
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

			tmrLoad.Enabled = !tmrLoad.Enabled;
		}

		private void SpeedReadingForm_Load(object sender, System.EventArgs e)
		{
			Cursor.Hide();
		}
	}
}
