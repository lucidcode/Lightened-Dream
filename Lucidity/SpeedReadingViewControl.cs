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

	public partial class SpeedReadingViewControl
	{

		public string FileName;
		private SpeedReadingForm m_formSpeedReading;

		public bool Changed;
		public void LoadFile(string strFileName)
		{
			try {
				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);

				// Set defaults
				txtInterval.Text = 1024;
				txtWidth.Text = -1;
				txtHeight.Text = -1;
				cmbSize.Text = 36;

				try {
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText)) {
						txtInterval.Text = xmlDoc.DocumentElement.SelectSingleNode("Interval").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Width").InnerText)) {
						txtWidth.Text = xmlDoc.DocumentElement.SelectSingleNode("Width").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Height").InnerText)) {
						txtHeight.Text = xmlDoc.DocumentElement.SelectSingleNode("Height").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText)) {
						cmbSize.Text = xmlDoc.DocumentElement.SelectSingleNode("Size").InnerText;
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText)) {
						colBackground.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Background").InnerText);
					}
					if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText)) {
						colText.Color = Color.FromArgb(xmlDoc.DocumentElement.SelectSingleNode("Text").InnerText);
					}
				} catch (Exception ex2) {
					txtInterval.Text = 1000;
					txtWidth.Text = -1;
					txtHeight.Text = -1;
					cmbSize.Text = 36;
				}

				txtReadings.Text = "";
				foreach (XmlNode xmlMessage in xmlDoc.DocumentElement.SelectNodes("Messages/Message")) {
					txtReadings.Text += xmlMessage.InnerText + Constants.vbNewLine;
				}

				// Remove last NewLine
				if (txtReadings.Text.Length > 0) {
					txtReadings.Text = txtReadings.Text.Substring(0, txtReadings.Text.Length - 1);
				}
				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save(string Title, string Description, string strFileName)
		{
			try {
				string strXml = null;

				FileName = strFileName;

				strXml = "<Reading>";
				strXml += "<Title>" + Title + "</Title>";
				strXml += "<Description>" + Description + "</Description>";
				strXml += "<Interval>" + txtInterval.Text + "</Interval>";
				strXml += "<Width>" + txtWidth.Text + "</Width>";
				strXml += "<Height>" + txtHeight.Text + "</Height>";
				strXml += "<Background>" + colBackground.Color.ToArgb().ToString() + "</Background>";
				strXml += "<Text>" + colText.Color.ToArgb().ToString() + "</Text>";
				strXml += "<Size>" + cmbSize.Text + "</Size>";
				strXml += "<Messages>";
				foreach (string strMessage in txtReadings.Text.Split(Constants.vbNewLine)) {
					var strReplaces = strMessage.Replace(Constants.vbNewLine, "").Replace(Constants.vbCr, "").Replace(Constants.vbLf, "").Replace(Constants.vbCrLf, "");
					strXml += "<Message>" + strReplaces + "</Message>";
				}
				strXml += "</Messages>";
				strXml += "</Reading>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.Save(FileName);
				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Play()
		{
			try {
				if ((m_formSpeedReading != null)) {
					m_formSpeedReading.Close();
				}

				m_formSpeedReading = new SpeedReadingForm(txtInterval.Text);
				m_formSpeedReading.BackColor = colBackground.Color;
				m_formSpeedReading.lblText.ForeColor = colText.Color;
				m_formSpeedReading.lblText.Font = new Font(m_formSpeedReading.lblText.Font.FontFamily, Convert.ToInt32(cmbSize.Text), FontStyle.Regular);
				m_formSpeedReading.Messages = txtReadings.Text.Split(Constants.vbNewLine);
				m_formSpeedReading.Show();
				m_formSpeedReading.Top = 0;
				m_formSpeedReading.Left = 0;
				m_formSpeedReading.Play();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void StopRunning()
		{
			try {
				if (m_formSpeedReading == null) {
					m_formSpeedReading.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Reading.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Label8_Click(System.Object sender, System.EventArgs e)
		{
			string[] arrWords = txtReadings.Text.Split(' ');
			txtReadings.Text = "";
			foreach (string strWord in arrWords) {
				txtReadings.Text += strWord + Constants.vbNewLine;
			}
		}

		private void txtInterval_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtWidth_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtHeight_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtMessages_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void colBackground_ColorChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void colText_ColorChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void cmbSize_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}
		public SpeedReadingViewControl()
		{
			InitializeComponent();
		}
	}
}
