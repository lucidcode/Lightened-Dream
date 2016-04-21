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
	public partial class SubliminalForm
	{

		public string[] Messages;
		public int Duration = 200;

		private int m_intPosition;
		public SubliminalForm(int Interval, int Duration, double dblOpacity, Color colBackColor, Color colForeColor, string[] arrMessages, Font objFont)
		{
			InitializeComponent();
			tmrLoad.Interval = Interval;
			tmrHide.Interval = Duration;
			Messages = arrMessages;
			lblText.Font = objFont;
			Opacity = dblOpacity;
			BackColor = colBackColor;
			lblText.ForeColor = colForeColor;
			this.Duration = Duration;
			this.Visible = true;
			this.Location = new Point(-10000, -10000);
			tmrLoad_Tick(null, null);
			VBMath.Randomize();
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;

			try {
				int intScreensHeight = 0;
				int intScreensWidth = 0;

				foreach (Screen objScreen in Screen.AllScreens) {
					intScreensWidth += objScreen.Bounds.Width;
					intScreensHeight += objScreen.Bounds.Height;
				}

				lblText.Text = Messages[m_intPosition].Replace(Constants.vbNewLine, "").Replace(Constants.vbCr, "").Replace(Constants.vbLf, "").Replace(Constants.vbCrLf, "");

				m_intPosition += 1;

				if (m_intPosition >= Messages.Length)
					m_intPosition = 0;

				if (string.IsNullOrEmpty(lblText.Text)) {
					tmrLoad_Tick(null, null);
					return;
				}

				lblText.Location = new Point(2, 4);
				Application.DoEvents();
				this.Left = Conversion.Int(VBMath.Rnd() * (intScreensWidth - this.Width));
				this.Top = Conversion.Int(VBMath.Rnd() * (intScreensHeight - this.Height));
				Application.DoEvents();

				this.Width = lblText.Width + 4;
				this.Height = lblText.Height + 8;
				//Me.Visible = True
				//If Not ParentForm Is Nothing Then
				//  ParentForm.Focus()
				//End If

			} catch (Exception ex) {
			}

			tmrHide.Enabled = true;
		}

		private void tmrHide_Tick(System.Object sender, System.EventArgs e)
		{
			tmrHide.Enabled = false;
			Application.DoEvents();
			this.Location = new Point(-10000, -10000);
			//Me.Visible = False
			tmrLoad.Enabled = true;
		}
	}
}
