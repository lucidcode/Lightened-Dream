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
	public partial class WILDForm
	{

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{

			try {
				Lucidity.FlashesForm formFlashes = new Lucidity.FlashesForm(txtInterval.Text);
				formFlashes.FlashColor = colText.Color;
				formFlashes.BackColor = colBackground.Color;
				formFlashes.Timeout = cmbLength.Text * 1000;
				formFlashes.Show();
				formFlashes.Play();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.WILD.Induce()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;
			cmbLength.Text = 15;
		}
		public WILDForm()
		{
			InitializeComponent();
		}
	}
}
