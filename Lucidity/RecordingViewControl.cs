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
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class RecordingViewControl
	{

		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private string m_strTitle;
		private string m_strFile;
		[DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
		private bool m_boolImported = false;
		public bool Changed = false;

		private System.Speech.Synthesis.SpeechSynthesizer m_objSpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
		public void LoadFile(string strFileName)
		{

			try {
				if (FileName == strFileName)
					return;
				objPlayer.Visible = false;

				// Delete old temp files
				try {
					foreach (string strFile in Directory.GetFiles(m_strPath + "\\Resources\\", "*.*")) {
						File.Delete(strFile);
					}
				} catch (Exception ex) {
				}

				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);

				try {
					m_strTitle = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				} catch (Exception ex2) {
				}

				if ((xmlDoc.DocumentElement.SelectSingleNode("Data") != null)) {
					byte[] arrByte = Convert.FromBase64String(xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText);
					FileStream objFS = new FileStream(m_strPath + "\\Resources\\" + m_strTitle + ".mp3", FileMode.Create);
					objFS.Write(arrByte, 0, arrByte.Length);
					objFS.Close();
					if (arrByte.Length > 0) {
						objPlayer.Visible = true;
					}
					// objPlayer.URL = (m_strPath + "\Resources\" + m_strTitle + ".mp3")
				}

				txtSpeech.Text = "";
				if ((xmlDoc.DocumentElement.SelectSingleNode("Speech") != null)) {
					txtSpeech.Text = xmlDoc.DocumentElement.SelectSingleNode("Speech").InnerText;
					//m_objSpeechSynthesizer.SpeakAsync(txtSpeech.Text)
				}

				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save(string Title, string Description, string strFileName)
		{

			try {
				FileName = strFileName;

				objPlayer.close();
				Application.DoEvents();

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(FileName);

				xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText = Title;
				xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText = Description;

				if (xmlDoc.DocumentElement.SelectSingleNode("Data") == null) {
					XmlNode xmlDataNode = xmlDoc.CreateElement("Data");
					xmlDoc.DocumentElement.AppendChild(xmlDataNode);
				}

				if (m_boolImported) {
					FileStream objFS = null;
					objFS = new FileStream(m_strFile, FileMode.Open);
					byte[] arrBytes = new byte[objFS.Length + 1];
					objFS.Read(arrBytes, 0, objFS.Length);
					objFS.Close();
					xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText = Convert.ToBase64String(arrBytes);
				} else {
					if (File.Exists(m_strPath + "\\Resources\\" + m_strFile)) {
						FileStream objFS = null;
						objFS = new FileStream(m_strPath + "\\Resources\\" + m_strFile, FileMode.Open);
						byte[] arrBytes = new byte[objFS.Length + 1];
						objFS.Read(arrBytes, 0, objFS.Length);
						objFS.Close();
						xmlDoc.DocumentElement.SelectSingleNode("Data").InnerText = Convert.ToBase64String(arrBytes);
					}
				}

				if (xmlDoc.DocumentElement.SelectSingleNode("Speech") == null) {
					XmlNode xmlDataNode = xmlDoc.CreateElement("Speech");
					xmlDoc.DocumentElement.AppendChild(xmlDataNode);
				}

				xmlDoc.DocumentElement.SelectSingleNode("Speech").InnerText = txtSpeech.Text;

				xmlDoc.Save(FileName);
				m_boolImported = false;
				Changed = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Play()
		{

			try {
				if (objPlayer.URL != m_strPath + "\\Resources\\stop.mp3") {
					string strFile = objPlayer.URL;
					objPlayer.URL = m_strPath + "\\Resources\\stop.mp3";
					objPlayer.URL = m_strPath + "\\Resources\\" + m_strTitle + ".mp3";
				}

				//objPlayer.URL = (m_strPath + "\Resources\stop.mp3")
				//Application.DoEvents()
				//objPlayer.close()
				//Application.DoEvents()
				//Me.objPlayer.settings.volume = 100
				//m_objSpeechSynthesizer.SpeakAsyncCancelAll()

				//Dim xmlDocRec As New XmlDocument
				//xmlDocRec.Load(FileName)

				//If Not xmlDocRec.DocumentElement.SelectSingleNode("Data") Is Nothing Then
				//  If xmlDocRec.DocumentElement.SelectSingleNode("Data").InnerText <> "" Then
				//    Dim arrByte() As Byte = Convert.FromBase64String(xmlDocRec.DocumentElement.SelectSingleNode("Data").InnerText)
				//    Dim objFS As New FileStream(m_strPath + "\Resources\" + m_strTitle + ".mp3", FileMode.Create)
				//    objFS.Write(arrByte, 0, arrByte.Length)
				//    objFS.Close()

				//    objPlayer.URL = (m_strPath + "\Resources\" + m_strTitle + ".mp3")
				//  End If
				//End If

				if (!string.IsNullOrEmpty(txtSpeech.Text)) {
					m_objSpeechSynthesizer.SpeakAsync(txtSpeech.Text);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void StopRunning()
		{

			try {
				objPlayer.close();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Recording.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void toolStart_Click(System.Object sender, System.EventArgs e)
		{
			if (toolStart.Text == "&Start") {
				m_boolImported = false;
				if (!string.IsNullOrEmpty(m_strFile)) {
					if (File.Exists(m_strPath + "\\Resources\\" + m_strFile)) {
						File.Delete(m_strPath + "\\Resources\\" + m_strFile);
					}
				}
				m_strFile = DateAndTime.Now.Ticks.ToString() + ".wav";
				mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
				mciSendString("record recsound", "", 0, 0);
				toolStart.Text = "&Stop";
			} else {
				int intres = mciSendString("save recsound \"" + m_strPath + "Resources\\" + m_strFile + "\"", "", 0, 0);
				mciSendString("close recsound ", "", 0, 0);
				objPlayer.URL = (m_strPath + "\\Resources\\" + m_strFile);
				toolStart.Text = "&Start";
				Changed = true;
				objPlayer.Visible = true;
			}
		}

		private void toolImport_Click(System.Object sender, System.EventArgs e)
		{
			OpenFileDialog objOFD = new OpenFileDialog();
			objOFD.Title = "Select Sound File";
			objOFD.Filter = "All Files|*.*|Wave Files|*.wav|MP3 Files|*.mp3";
			if (objOFD.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				objPlayer.URL = (objOFD.FileName);
				m_strFile = objOFD.FileName;
				m_boolImported = true;
				Changed = true;
				objPlayer.Visible = true;

			}
		}
	}
}
