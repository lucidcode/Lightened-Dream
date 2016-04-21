using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class WhyLDForm
	{


		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{

			try {
				XmlDocument xmlDocReason = new XmlDocument();
				string strXml = "";

				// Create the reason file
				strXml = "<LightenedDream>";
				strXml += "<Reason></Reason>";
				strXml += "</LightenedDream>";
				xmlDocReason.LoadXml(strXml);
				xmlDocReason.DocumentElement.SelectSingleNode("Reason").InnerText = txtReason.Text;
				xmlDocReason.Save(m_strPath + "WhyLD.ld3");

				Close();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.WhyLD()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;


			try {
				XmlDocument xmlDocReason = new XmlDocument();
				string strXml = "";

				// Make sure that the reason file exists
				if ((!File.Exists(m_strPath + "WhyLD.ld3"))) {
					// Create the reason file
					strXml = "<LightenedDream>";
					strXml += "<Reason></Reason>";
					strXml += "</LightenedDream>";
					xmlDocReason.LoadXml(strXml);
					xmlDocReason.Save(m_strPath + "WhyLD.ld3");
				}

				xmlDocReason.Load(m_strPath + "WhyLD.ld3");
				txtReason.Text = xmlDocReason.DocumentElement.SelectSingleNode("Reason").InnerText;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.WhyLD()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public WhyLDForm()
		{
			InitializeComponent();
		}
	}
}
