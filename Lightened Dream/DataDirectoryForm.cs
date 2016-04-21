using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace LightenedDream
{

	public partial class DataDirectoryForm
	{

		private string m_strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\";

		private string m_strOldPath;
		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{

			try {
				// Check if the path has changed

				if (m_strOldPath != txtDataDirectory.Text) {
					// Make sure the new directory exists
					if (!Directory.Exists(txtDataDirectory.Text)) {
						Directory.CreateDirectory(txtDataDirectory.Text);
					}

					// Check if there already is a Lightened Dream directory
					if (Directory.Exists(txtDataDirectory.Text + "\\Lightened Dream")) {
						// Check if there are any files in it
						if ((Directory.GetFiles(txtDataDirectory.Text + "\\Lightened Dream").Length > 0)) {
							// Move the pre-existing files to a backup folder
							Directory.Move(txtDataDirectory.Text + "\\Lightened Dream", txtDataDirectory.Text + "\\Lightened Dream" + DateTime.Now.ToString(" - Backup yyyy-MM-Mdd_HHmmss"));
						} else {
							Directory.Delete(txtDataDirectory.Text + "\\Lightened Dream");
						}
					}

					// Move the data
					Directory.Move(m_strOldPath + "\\Lightened Dream", txtDataDirectory.Text + "\\Lightened Dream");

					// Save the new path
					XmlDocument xmlDocDataDirectory = new XmlDocument();
					string strXml = "";
					strXml = "<LightenedDream>";
					strXml += "<Directory></Directory>";
					strXml += "</LightenedDream>";
					xmlDocDataDirectory.LoadXml(strXml);
					xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText = txtDataDirectory.Text;
					xmlDocDataDirectory.Save(m_strPath + "LightenedDreamDirectory.ld3");

					Application.Restart();

				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.SetDataDirectory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;


			try {
				if ((File.Exists(m_strPath + "LightenedDreamDirectory.ld3"))) {
					XmlDocument xmlDocDataDirectory = new XmlDocument();
					xmlDocDataDirectory.Load(m_strPath + "LightenedDreamDirectory.ld3");
					txtDataDirectory.Text = xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText;
				} else {
					txtDataDirectory.Text = m_strPath;
				}

				m_strOldPath = txtDataDirectory.Text;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadDataDirectory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public DataDirectoryForm()
		{
			InitializeComponent();
		}
	}
}
