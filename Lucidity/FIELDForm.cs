using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class FIELDForm
	{

		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolMouseDown;

		private DateTime m_boolStartTime;
		private void FIELDForm_Load(System.Object sender, System.EventArgs e)
		{
			// Check if the FIELD file exists
			if ((File.Exists(m_strPath + "FIELD.ld3"))) {
				XmlDocument xmlDocFIELD = new XmlDocument();
				xmlDocFIELD.Load(m_strPath + "FIELD.ld3");
				txtAnthem.Text = xmlDocFIELD.DocumentElement.SelectSingleNode("Anthem").InnerText;
			}
			if (string.IsNullOrEmpty(txtAnthem.Text)) {
				txtAnthem.Text = m_strPath + "Anthem.mp3";
			}
		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			m_boolMouseDown = true;
			m_boolStartTime = DateTime.Now;
		}

		private void btnOk_MouseUp(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			m_boolMouseDown = false;


			try {
				// Play the anthem

				if ((File.Exists(txtAnthem.Text))) {
					objPlayer.close();
					Application.DoEvents();
					this.objPlayer.settings.volume = 100;
					objPlayer.URL = txtAnthem.Text;

				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.FIELD.Induce()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tmrFIELD_Tick(System.Object sender, System.EventArgs e)
		{
			if (m_boolMouseDown) {
				TimeSpan dtDiff = DateTime.Now.Subtract(m_boolStartTime);
				string strDiff = "";

				if (dtDiff.Days < 10) {
					strDiff += "0" + dtDiff.Days;
				} else {
					strDiff += dtDiff.Days;
				}
				if (dtDiff.Hours < 10) {
					strDiff += ":" + "0" + dtDiff.Hours;
				} else {
					strDiff += ":" + dtDiff.Hours;
				}
				if (dtDiff.Minutes < 10) {
					strDiff += ":" + "0" + dtDiff.Minutes;
				} else {
					strDiff += ":" + dtDiff.Minutes;
				}
				if (dtDiff.Seconds < 10) {
					strDiff += ":" + "0" + dtDiff.Seconds;
				} else {
					strDiff += ":" + dtDiff.Seconds;
				}
				if (dtDiff.Milliseconds < 10) {
					strDiff += ":" + "0" + dtDiff.Milliseconds;
				} else {
					strDiff += ":" + dtDiff.Milliseconds;
				}

				Text = "FIELD Inducer - " + strDiff;
			}
		}

		private void btnBrowse_Click(System.Object sender, System.EventArgs e)
		{
			try {
				if (objOpenFileDialog.ShowDialog() == DialogResult.OK) {
					txtAnthem.Text = objOpenFileDialog.FileName;
				}

				// Save the FIELD file
				string strXml = null;
				strXml = "<LightenedDream>";
				strXml += "<Anthem>";
				strXml += "</Anthem>";
				strXml += "</LightenedDream>";
				XmlDocument xmlDocFIELD = new XmlDocument();
				xmlDocFIELD.LoadXml(strXml);
				xmlDocFIELD.DocumentElement.SelectSingleNode("Anthem").InnerText = txtAnthem.Text;
				xmlDocFIELD.Save(m_strPath + "FIELD.ld3");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.FIELD.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public FIELDForm()
		{
			Load += FIELDForm_Load;
			InitializeComponent();
		}
	}
}
