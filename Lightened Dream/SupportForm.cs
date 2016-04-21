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
	public partial class SupportForm
	{

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;
			cmbType.Text = "Comment";
			try {
				txtOS.Text = Environment.OSVersion.ToString();

			} catch (Exception ex) {
			}
			txtReplyAddress.Focus();
			Application.DoEvents();
			webSupport.Url = new Uri("http://www.lucid-code.com/LightenedDream/Support");
		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{
			try {
				EmailService.EmailService objEmailService = new EmailService.EmailService();
				string strResult = objEmailService.Send(txtReplyAddress.Text, cmbType.Text, txtOS.Text, txtMessage.Text);

				if (strResult == "Success!") {
					MessageBox.Show("The message has been sent. Thank you for your " + cmbType.Text.ToLower() + "!", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show(strResult, "LightenedDream.Support.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Support.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public SupportForm()
		{
			InitializeComponent();
		}
	}
}
