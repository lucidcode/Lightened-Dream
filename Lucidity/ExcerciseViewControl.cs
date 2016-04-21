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

	public partial class ExerciseViewControl
	{

		public int Words;
		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolLoading = false;

		private System.Speech.Synthesis.SpeechSynthesizer m_objSpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();

		public bool Playing = false;
		public event CategoryCreatedEventHandler CategoryCreated;
		public delegate void CategoryCreatedEventHandler(string Category, string Name, string FileName);
		public event PlayingStoppedEventHandler PlayingStopped;
		public delegate void PlayingStoppedEventHandler();

		public bool Changed = false;
		public ExerciseViewControl()
		{
			InitializeComponent();
			m_objSpeechSynthesizer.SpeakCompleted += m_objSpeechSynthesizer_SpeakCompleted;
		}

		public void EnableSpellCheck()
		{
			NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtExercise, true);
		}

		public void DisableSpellCheck()
		{
			NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtExercise, false);
		}

		public void LoadExercise(string strFileName)
		{
			try {
				if (FileName != strFileName) {
					m_objSpeechSynthesizer.SpeakAsyncCancelAll();
					Playing = false;
				}

				m_boolLoading = true;
				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);

				try {
					string[] arrDate = Strings.Split(xmlDoc.DocumentElement.SelectSingleNode("Date").InnerText, "-");
					string[] arrTime = Strings.Split(xmlDoc.DocumentElement.SelectSingleNode("Time").InnerText, ":");
					dtDate.Value = new System.DateTime(arrDate[0], arrDate[1], arrDate[2], arrTime[0], arrTime[1], 0);
				} catch (Exception ex) {
				}

				txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				txtTask.Text = xmlDoc.DocumentElement.SelectSingleNode("Task").InnerText;
				txtExercise.Text = xmlDoc.DocumentElement.SelectSingleNode("Details").InnerText;
				lblTitle.Text = "Lucidity - Exercises - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;

				cmbLucidity.Text = xmlDoc.DocumentElement.SelectSingleNode("Lucidity").InnerText;

				Words = txtExercise.Text.Split(' ').Length;
				m_boolLoading = false;
				Changed = false;
				Playing = false;
				//LoadCategories()
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Exercises.LoadExercise()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save()
		{
			try {
				string strXml = null;

				strXml = "<Exercise>";
				strXml += "<Date>" + Strings.Format(dtDate.Value, "yyyy-MM-dd") + "</Date>";
				strXml += "<Time>" + Strings.Format(dtDate.Value, "HH:mm") + "</Time>";
				strXml += "<Title>" + txtTitle.Text + "</Title>";
				strXml += "<Task>" + txtTask.Text + "</Task>";
				strXml += "<Details></Details>";
				strXml += "<Lucidity>" + Conversion.Val(cmbLucidity.Text) + "</Lucidity>";
				strXml += "</Exercise>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.DocumentElement.SelectSingleNode("Details").InnerText = txtExercise.Text;
				if ((FileName != GetFolder(dtDate.Value) + Strings.Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3")) {
					File.Delete(FileName);
				}
				FileName = GetFolder(dtDate.Value) + Strings.Format(dtDate.Value, "dd") + " " + txtTitle.Text + ".ld3";
				xmlDoc.Save(FileName);
				Changed = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Exercises.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Play()
		{
			try {
				m_objSpeechSynthesizer.SpeakAsync(txtExercise.Text);
				Playing = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Exercises.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void m_objSpeechSynthesizer_SpeakCompleted(object sender, System.Speech.Synthesis.SpeakCompletedEventArgs e)
		{
			Playing = false;
			if (PlayingStopped != null) {
				PlayingStopped();
			}
		}

		public void StopPlaying()
		{
			try {
				m_objSpeechSynthesizer.SpeakAsyncCancelAll();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Exercises.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetFolder(DateTime FolderDate)
		{
			if (!Directory.Exists(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy"))) {
				Directory.CreateDirectory(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy"));
			}
			if (!Directory.Exists(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"))) {
				Directory.CreateDirectory(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"));
			}
			return m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM") + "\\";
		}

		private void txtTitle_TextChanged(System.Object sender, System.EventArgs e)
		{
			lblTitle.Text = "Lucidity - Exercises - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;
			Changed = true;
		}

		private void dtDate_ValueChanged(System.Object sender, System.EventArgs e)
		{
			lblTitle.Text = "Lucidity - Exercises - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;
			try {
			} catch (Exception ex) {
			}
			Changed = true;
		}

		private void txtExercise_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (!m_boolLoading) {
				Changed = true;
			}
		}

		private void cmbLucidity_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

	}
}
