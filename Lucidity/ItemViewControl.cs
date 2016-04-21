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

	public partial class ItemViewControl
	{

		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\Lucidity\\";
		private string m_strType;

		private bool m_boolSpelling = false;
		public void EnableSpellCheck()
		{
			m_boolSpelling = true;
		}

		public void DisableSpellCheck()
		{
			m_boolSpelling = false;
		}

		public bool Changed()
		{

			if (m_strType == "Subliminal") {
				return objSublinalControl.Changed;
			} else if (m_strType == "Reading") {
				return objSpeedReadingControl.Changed;
			} else if (m_strType == "Recording") {
				return objRecordingViewControl.Changed;
			}

		}

		public void LoadFile(string strFileName)
		{

			try {
				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(strFileName);

				pnlContainer.Controls.Clear();

				m_strType = xmlDoc.DocumentElement.Name;
				txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText;

				if (m_strType == "Subliminal") {
					pnlContainer.Controls.Add(objSublinalControl);
					objSublinalControl.Location = new Point(0, 0);
					objSublinalControl.Dock = DockStyle.Fill;
					lblTitle.Text = "Lucidity - Subliminals - " + txtTitle.Text;
					objSublinalControl.LoadFile(strFileName);
					NHunspellTextBoxExtender1.SetSpellCheckEnabled(objSublinalControl.txtMessages, true);
				} else if (m_strType == "Reading") {
					pnlContainer.Controls.Add(objSpeedReadingControl);
					objSpeedReadingControl.Location = new Point(0, 0);
					objSpeedReadingControl.Dock = DockStyle.Fill;
					lblTitle.Text = "Lucidity - Readings - " + txtTitle.Text;
					objSpeedReadingControl.LoadFile(strFileName);
					NHunspellTextBoxExtender1.SetSpellCheckEnabled(objSpeedReadingControl.txtReadings, true);
				} else if (m_strType == "Recording") {
					pnlContainer.Controls.Add(objRecordingViewControl);
					objRecordingViewControl.Location = new Point(0, 0);
					objRecordingViewControl.Dock = DockStyle.Fill;
					lblTitle.Text = "Lucidity - Recordings - " + txtTitle.Text;
					objRecordingViewControl.LoadFile(strFileName);
					NHunspellTextBoxExtender1.SetSpellCheckEnabled(objRecordingViewControl.txtSpeech, true);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save(string Type)
		{

			try {
				string strFileName = null;
				strFileName = m_strPath + m_strType + "s\\" + txtTitle.Text + ".ld3";
				if ((FileName != strFileName)) {
					// Make sure the file doesn't already exist
					if ((File.Exists(strFileName))) {
						if (MessageBox.Show("The file '" + new FileInfo(strFileName).Name.Replace(".ld3", "") + "' already exists." + Constants.vbNewLine + "Would you like to replace it?", "Overwrite File?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
							File.Delete(strFileName);
						} else {
							return;
						}
					}

					File.Move(FileName, strFileName);
					FileName = strFileName;
				}

				if (m_strType == "Subliminal") {
					objSublinalControl.Save(txtTitle.Text, txtDescription.Text, strFileName);
				} else if (m_strType == "Reading") {
					objSpeedReadingControl.Save(txtTitle.Text, txtDescription.Text, strFileName);
				} else if (m_strType == "Recording") {
					objRecordingViewControl.Save(txtTitle.Text, txtDescription.Text, strFileName);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public string CreateNew(string Type)
		{

			try {
				m_strType = Type;
				string strTitle = "New " + m_strType;
				string strFileName = null;
				strFileName = m_strPath + m_strType + "s\\" + strTitle + ".ld3";

				int intPos = 2;
				do {
					if ((File.Exists(strFileName))) {
						strTitle = "New " + m_strType + " " + intPos.ToString();
						strFileName = m_strPath + m_strType + "s\\" + strTitle + ".ld3";
						intPos += 1;
					} else {
						break; // TODO: might not be correct. Was : Exit Do
					}
				} while (true);

				string strXml = null;
				strXml = "<" + m_strType + ">";
				strXml += "<Title>" + strTitle + "</Title>";
				strXml += "<Description></Description>";
				strXml += "</" + m_strType + ">";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.Save(strFileName);

				return strFileName;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Item.Create()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool Play()
		{
			if (m_strType == "Subliminal") {
				objSublinalControl.Play();
				return true;
			} else if (m_strType == "Reading") {
				objSpeedReadingControl.Play();
			} else if (m_strType == "Recording") {
				objRecordingViewControl.Play();
			}
			return false;
		}

		public bool Playing()
		{
			if (m_strType == "Subliminal") {
				return objSublinalControl.Playing;
			}
			return false;
		}

		public void StopRunning()
		{
			if (m_strType == "Subliminal") {
				objSublinalControl.StopRunning();
			} else if (m_strType == "Reading") {
				objSpeedReadingControl.StopRunning();
			} else if (m_strType == "Recording") {
				objRecordingViewControl.StopRunning();
			}
		}
		public ItemViewControl()
		{
			InitializeComponent();
		}

	}
}
