using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class SubliminalViewControl
	{

		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\Lucidity\\Subliminals";
		private SubliminalForm m_formSubliminal;
		public bool Changed;

		public bool Playing = false;
		public void LoadFile(string strFileName)
		{
			try {
				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);

				// Set default values
				txtInterval.Text = 5000;
				txtDuration.Text = 1000;
				cmbTransparency.Text = 50;
				cmbSize.Text = 12;

				try {
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText)) {
						txtInterval.Text = xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Duration").InnerText)) {
						txtDuration.Text = xmlDoc.DocumentElement.SelectSingleNode("Duration").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Transparency").InnerText)) {
						cmbTransparency.Text = xmlDoc.DocumentElement.SelectSingleNode("Transparency").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText)) {
						colBackground.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText);
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText)) {
						colText.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText);
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText)) {
						cmbSize.Text = xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText;
					}
				} catch (Exception ex2) {
					txtInterval.Text = 5000;
					txtDuration.Text = 1000;
					cmbTransparency.Text = 50;
					cmbSize.Text = 12;
				}

				txtMessages.Text = "";
				foreach (XmlNode xmlMessage in xmlDoc.DocumentElement.SelectNodes("Messages/Message")) {
					txtMessages.Text += xmlMessage.InnerText + Constants.vbNewLine;
				}

				// Remove last NewLine
				if (txtMessages.Text.Length > 0) {
					txtMessages.Text = txtMessages.Text.Substring(0, txtMessages.Text.Length - 1);
				}
				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save(string Title, string Description, string strFileName)
		{
			try {
				string strXml = null;
				FileName = strFileName;

				strXml = "<Subliminal>";
				strXml += "<Title>" + Title + "</Title>";
				strXml += "<Description>" + Description + "</Description>";
				strXml += "<Interval>" + txtInterval.Text + "</Interval>";
				strXml += "<Duration>" + txtDuration.Text + "</Duration>";
				strXml += "<Transparency>" + cmbTransparency.Text + "</Transparency>";
				strXml += "<Background>" + colBackground.Color.ToArgb().ToString() + "</Background>";
				strXml += "<Text>" + colText.Color.ToArgb().ToString() + "</Text>";
				strXml += "<Size>" + cmbSize.Text + "</Size>";
				strXml += "<Messages>";
				foreach (string strMessage in txtMessages.Text.Split(Constants.vbNewLine)) {
					var strReplaces = strMessage.Replace(Constants.vbNewLine, "").Replace(Constants.vbCr, "").Replace(Constants.vbLf, "").Replace(Constants.vbCrLf, "");
					if (!string.IsNullOrEmpty(strReplaces)) {
						strXml += "<Message>" + strReplaces + "</Message>";
					}
				}
				strXml += "</Messages>";
				strXml += "</Subliminal>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.Save(FileName);
				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Play()
		{

			try {
				if ((m_formSubliminal != null)) {
					m_formSubliminal.Close();
				}

				m_formSubliminal = new SubliminalForm(txtInterval.Text, txtDuration.Text, (100 - cmbTransparency.Text) / 100, colBackground.Color, colText.Color, txtMessages.Text.Split(Constants.vbNewLine), new Font(lblInterval.Font.FontFamily, Convert.ToSingle(cmbSize.Text), FontStyle.Regular));
				m_formSubliminal.Show();
				Playing = true;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void StopRunning()
		{
			try {
				if ((m_formSubliminal != null)) {
					m_formSubliminal.Close();
				}
				Playing = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Subliminal.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtInterval_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtDuration_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtMessages_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void cmbTransparency_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void cmbSize_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void colText_ColorChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void colBackground_ColorChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}
		public SubliminalViewControl()
		{
			InitializeComponent();
		}
	}
}
