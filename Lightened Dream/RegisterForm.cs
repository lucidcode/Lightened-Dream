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
	public partial class RegisterForm
	{

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{
			try {
				EmailService.EmailService objEmailService = new EmailService.EmailService();
				string strResult = objEmailService.Send(txtReplyAddress.Text, "Update Request", Environment.OSVersion.ToString(), "");

				if (strResult == "Success!") {
					MessageBox.Show("Thank you for your update request! An email will be sent to " + txtReplyAddress.Text + " when the next version is released.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show(strResult, "LightenedDream.Register.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Register.Send()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public RegisterForm()
		{
			InitializeComponent();
		}
	}
}
