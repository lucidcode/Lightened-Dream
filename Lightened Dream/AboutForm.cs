using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
namespace LightenedDream
{

	public partial class AboutForm
	{

		private string m_strUpdateURL = "http://www.lucid-code.com/LightenedDream";

		private bool m_boolClosing = false;
		private void AboutForm_Load(System.Object sender, System.EventArgs e)
		{
			lblVersion.Text = Application.ProductVersion;
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;


			try {
				UpdateClass objUpdater = new UpdateClass();
				Thread objUpdateThread = new Thread(objUpdater.CheckForUpdate);
				objUpdateThread.Start();

				do {
					Application.DoEvents();
					System.Threading.Thread.Sleep(10);

					if (objUpdater.Complete) {
						break; // TODO: might not be correct. Was : Exit Do
					}
					if (m_boolClosing) {
						//objUpdateThread.Abort()
						return;
					}
				} while (true);

				if (UpdateAvailable(objUpdater.Version)) {
					m_strUpdateURL = objUpdater.URL;
					lblUpdate.Visible = true;
					lblUpdate.Text = "A new version (" + objUpdater.Version + ") is available. Download now!";
				}

			} catch (Exception ex) {
			}
		}

		private bool UpdateAvailable(string NewVersion)
		{

			try {
				string OldVersion = lblVersion.Text;
				string[] arrOldVersion = Strings.Split(lblVersion.Text, ".");
				// 2.9.9.0
				string[] arrNewVersion = Strings.Split(NewVersion, ".");
				//    ' 2.9.9.1

				if (Conversion.Val(arrNewVersion[0]) > Conversion.Val(arrOldVersion[0])) {
					return true;
				} else {
					if (Conversion.Val(arrNewVersion[1]) > Conversion.Val(arrOldVersion[1])) {
						return true;
					} else {
						if (Conversion.Val(arrNewVersion[2]) > Conversion.Val(arrOldVersion[2])) {
							return true;
						} else {
							if (Conversion.Val(arrNewVersion[3]) > Conversion.Val(arrOldVersion[3])) {
								return true;
							} else {
								return false;
							}
						}
					}
				}
			} catch (Exception ex) {
				return false;
			}
		}

		private void lblUpdate_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start(m_strUpdateURL);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.About.Link()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("http://www.lucidcode.com/LightenedDream/");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.About.Link()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AboutForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			m_boolClosing = true;
		}

		private class UpdateClass
		{

			public string Version;
			public string URL;

			public bool Complete = false;
			public void CheckForUpdate()
			{

				try {
					WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
					HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://www.lucid-code.com/LightenedDream/updates/LatestVersion.html");
					objRequest.Method = "GET";
					HttpWebResponse objWebResponse = (HttpWebResponse)objRequest.GetResponse();
					StreamReader objResponseStream = new StreamReader(objWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding(1252));
					var strResponse = objResponseStream.ReadToEnd();
					objWebResponse.Close();
					objResponseStream.Close();

					if (strResponse.StartsWith("Version ")) {
						string[] arrLines = strResponse.Split(Constants.vbNewLine);
						Version = arrLines[0].Replace("Version ", "");
						URL = arrLines[1];
					}

				} catch (Exception ex) {
				}

				Complete = true;
			}

		}
	}
}
