using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace lucidcode.LightenedDream.Dreams
{

	public partial class DreamViewControl
	{

		public int Words;
		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolLoading = false;

		private System.Speech.Synthesis.SpeechSynthesizer m_objSpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();

		public bool Playing = false;
		public event RandomWordEventHandler RandomWord;
		public delegate void RandomWordEventHandler(string Word);
		public event CategoryCreatedEventHandler CategoryCreated;
		public delegate void CategoryCreatedEventHandler(string Category, string Name, string FileName);
		public event PlayingStoppedEventHandler PlayingStopped;
		public delegate void PlayingStoppedEventHandler();

		public bool Changed = false;

		ImageBrowserForm m_formImageBrowser;
		public DreamViewControl()
		{
			InitializeComponent();
			VBMath.Randomize();
			LoadDreamTypes();
			m_objSpeechSynthesizer.SpeakCompleted += m_objSpeechSynthesizer_SpeakCompleted;
		}

		private void LoadDreamTypes()
		{
			XmlDocument xmlDocDreamTypes = new XmlDocument();

			// Make sure that the dream types file exists
			if (!File.Exists(m_strPath + "DreamTypes.ld3")) {
				// Create the dream types file
				string strXml = "<LightenedDream>";
				strXml += "<DreamType>1 Thought</DreamType>";
				strXml += "<DreamType>2 Daydream</DreamType>";
				strXml += "<DreamType>3 Nightmare</DreamType>";
				strXml += "<DreamType>4 Foggy Dream</DreamType>";
				strXml += "<DreamType>5 Normal Dream</DreamType>";
				strXml += "<DreamType>6 Vivid Dream</DreamType>";
				strXml += "<DreamType>7 Lucid Dream</DreamType>";
				strXml += "<DreamType>8 Epic Dream</DreamType>";
				strXml += "<DreamType>9 Wake Induced</DreamType>";
				strXml += "</LightenedDream>";
				xmlDocDreamTypes.LoadXml(strXml);
				xmlDocDreamTypes.Save(m_strPath + "DreamTypes.ld3");
			}

			cmbLucidity.Items.Clear();
			xmlDocDreamTypes.Load(m_strPath + "DreamTypes.ld3");
			foreach (XmlNode xmlDreamType in xmlDocDreamTypes.DocumentElement.SelectNodes("DreamType")) {
				cmbLucidity.Items.Add(xmlDreamType.InnerText);
			}
		}

		public void EnableSpellCheck()
		{
			NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtDream, true);
		}

		public void DisableSpellCheck()
		{
			NHunspellTextBoxExtender1.SetSpellCheckEnabled(txtDream, false);
		}

		public void LoadDream(string strFileName, bool locked)
		{
			try {
				if (FileName != strFileName) {
					m_objSpeechSynthesizer.SpeakAsyncCancelAll();
					Playing = false;
				}

				txtTitle.ReadOnly = locked;
				cmbLucidity.Enabled = !locked;
				dtDate.Enabled = !locked;
				dtStart.Enabled = !locked;
				dtEnd.Enabled = !locked;
				objDreamSlider.Enabled = !locked;
				txtDream.Enabled = !locked;

				m_boolLoading = true;
				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);
				m_formImageBrowser = null;

				try {
					string[] arrDate = Strings.Split(xmlDoc.DocumentElement.SelectSingleNode("Date").InnerText, "-");
					string[] arrTime = Strings.Split(xmlDoc.DocumentElement.SelectSingleNode("Time").InnerText, ":");
					dtDate.Value = new System.DateTime(Convert.ToInt32(arrDate[0]), Convert.ToInt32(arrDate[1]), Convert.ToInt32(arrDate[2]), Convert.ToInt32(arrTime[0]), Convert.ToInt32(arrTime[1]), 0);
				} catch (Exception ex) {
				}

				txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				txtDream.Text = xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText;
				lblTitle.Text = "Dreams - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;

				if ((xmlDoc.DocumentElement.SelectSingleNode("Comments") != null)) {
					txtComments.Text = xmlDoc.DocumentElement.SelectSingleNode("Comments").InnerText;
				} else {
					txtComments.Text = "";
				}

				try {
					dtStart.Value = DateAndTime.Now.Date + " " + xmlDoc.DocumentElement.SelectSingleNode("Sleep").InnerText;
					dtEnd.Value = DateAndTime.Now.Date + " " + xmlDoc.DocumentElement.SelectSingleNode("Awake").InnerText;
					objDreamSlider.setStartTime(new TimeSpan(dtStart.Value.Hour, dtStart.Value.Minute, 0));
					objDreamSlider.setStopTime(new TimeSpan(dtEnd.Value.Hour, dtEnd.Value.Minute, 0));
					objDreamSlider.setDreamTime(new TimeSpan(dtDate.Value.Hour, dtDate.Value.Minute, 0));
				} catch (Exception ex) {
				}

				try {
					if (dtStart.Value == dtEnd.Value) {
						dtStart.Value = DateAndTime.Now.Date + " 23:30";
						dtEnd.Value = DateAndTime.Now.Date + " 06:30";
					}

				} catch (Exception ex) {
				}

				cmbLucidity.Text = "5 Normal Dream";
				if ((xmlDoc.DocumentElement.SelectSingleNode("Lucidity") != null)) {
					foreach (object strItem in cmbLucidity.Items) {
						if (strItem.StartsWith(xmlDoc.DocumentElement.SelectSingleNode("Lucidity").InnerText)) {
							cmbLucidity.SelectedItem = strItem;
							break; // TODO: might not be correct. Was : Exit For
						}
					}
				}

				if ((xmlDoc.DocumentElement.SelectSingleNode("Image") != null)) {
					MemoryStream objMemStream = new MemoryStream(Convert.FromBase64String(xmlDoc.DocumentElement.SelectSingleNode("Image").InnerText));
					pbDream.Image = Image.FromStream(objMemStream);
				} else {
					pbDream.Image = lstImgDreams.Images[GetRandomItem(lstImgDreams.Images.Count)];
					Save();
				}
				ResizeImage();

				Words = txtDream.Text.Split(' ').Length;
				m_boolLoading = false;
				Changed = false;
				Playing = false;
				//LoadCategories()
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Dreams.LoadDream()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save()
		{
			CategoryBuilder objCategoryBuilder = new CategoryBuilder();
			objCategoryBuilder.Dream = txtDream.Text;
			objCategoryBuilder.Words = Dreaming.GetWords(objCategoryBuilder.Dream);

			objCategoryBuilder.RandomWord += RandomWordLocal;
			objCategoryBuilder.AddCategoryItem += AddCategoryItemLocal;

			System.Threading.Thread objProcessingThread = new System.Threading.Thread(objCategoryBuilder.LoadCategories);
			objProcessingThread.Start();

			do {
				System.Threading.Thread.Sleep(10);
				Application.DoEvents();
				if (objCategoryBuilder.Completed)
					break; // TODO: might not be correct. Was : Exit Do
			} while (true);

			DoSave(objCategoryBuilder.Categories);
		}

		private void RandomWordLocal(string Word)
		{
			if (RandomWord != null) {
				RandomWord(Word);
			}
		}

		private void AddCategoryItemLocal(string Category, string Item)
		{
			AddCategoryItem(Category, Item);
		}

		public void DoSave(string Categories)
		{
			try {
				string strXml = null;

				strXml = "<Dream>";
				strXml += "<Date>" + Strings.Format(dtDate.Value, "yyyy-MM-dd") + "</Date>";
				strXml += "<Time>" + Strings.Format(dtDate.Value, "HH:mm") + "</Time>";
				strXml += "<Sleep>" + Strings.Format(dtStart.Value, "HH:mm") + "</Sleep>";
				strXml += "<Awake>" + Strings.Format(dtEnd.Value, "HH:mm") + "</Awake>";
				strXml += "<Title></Title>";
				strXml += "<Lucidity>" + Conversion.Val(cmbLucidity.Text) + "</Lucidity>";
				strXml += "<Dream></Dream>";
				strXml += "<Comments></Comments>";
				strXml += "<Clarity>5</Clarity>";

				strXml += "<SubCategories>" + Categories + "</SubCategories>";
				strXml += "<Image></Image>";
				strXml += "</Dream>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText = txtTitle.Text;
				xmlDoc.DocumentElement.SelectSingleNode("Dream").InnerText = txtDream.Text;
				xmlDoc.DocumentElement.SelectSingleNode("Comments").InnerText = txtComments.Text;

				try {
					MemoryStream objMemStream = new MemoryStream();
					pbDream.Image.Save(objMemStream, System.Drawing.Imaging.ImageFormat.Jpeg);
					xmlDoc.DocumentElement.SelectSingleNode("Image").InnerText = Convert.ToBase64String(objMemStream.ToArray());

				} catch (Exception ex) {
				}

				if ((FileName != GetFolder(dtDate.Value) + Strings.Format(dtDate.Value, "dd") + " " + SafeFilename(txtTitle.Text) + ".ld3")) {
					File.Delete(FileName);
				}
				FileName = GetFolder(dtDate.Value) + Strings.Format(dtDate.Value, "dd") + " " + SafeFilename(txtTitle.Text) + ".ld3";
				xmlDoc.Save(FileName);
				Changed = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Dreams.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public string SafeFilename(string fileName)
		{
			for (int i = 0; i <= Path.GetInvalidFileNameChars().Length - 1; i++) {
				fileName = fileName.Replace(Path.GetInvalidFileNameChars()[i], '_');
			}
			return fileName;
		}

		public void Play()
		{
			try {
				m_objSpeechSynthesizer.SpeakAsync(txtDream.Text);
				Playing = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Dreams.Play()", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show(ex.Message, "LightenedDream.Dreams.Stop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetFolder(DateTime FolderDate)
		{
			if (!Directory.Exists(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy"))) {
				Directory.CreateDirectory(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy"));
			}
			if (!Directory.Exists(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"))) {
				Directory.CreateDirectory(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"));
			}
			return m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM") + "\\";
		}

		private class CategoryItem
		{
			public string Category;
			public string Name;
			public List<string> SubItems = new List<string>();
		}

		private delegate void AddCategoryItemDelegate(string Category, string Item);
		private void AddCategoryItem(string Category, string Item)
		{
			//Try
			//    If InvokeRequired Then
			//        Dim d As New AddCategoryItemDelegate(AddressOf AddCategoryItem)
			//        Invoke(d, Category, Item)
			//    Else
			//        Dim lstItem As New ListViewItem(Item)
			//        lstItem.Tag = Category
			//        FindListView(Category).Items.Add(lstItem)
			//    End If
			//Catch ex As Exception
			//End Try
		}

		private class CategoryBuilder
		{

			public string Dream;
			public bool Completed;

			private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
			public event RandomWordEventHandler RandomWord;
			public delegate void RandomWordEventHandler(string Word);
			public event AddCategoryItemEventHandler AddCategoryItem;
			public delegate void AddCategoryItemEventHandler(string Category, string Item);

			public string[] Words;

			public string Categories;

			public List<string> FoundList = new List<string>();
			public string LoadCategories(string category)
			{
        String categories = "";
				var initialRun = false;
				if (category == null) {
					category = m_strPath + "Categories";
					initialRun = true;
				}

				foreach (string subCategory in Directory.GetDirectories(category)) {
					LoadCategories(subCategory);
				}

				foreach (string file in Directory.GetFiles(category)) {
					XmlDocument xmlDocCategory = new XmlDocument();
					xmlDocCategory.Load(file);

					bool foundWord = false;
					foreach (string word in Words) {
						if (!FoundList.Contains(word.ToLower())) {
							if (word.ToLower() == new FileInfo(file).Name.Replace(".ld3", "").ToLower()) {
								if (RandomWord != null) {
									RandomWord(word);
								}
								FoundList.Add(word.ToLower());
                categories += "<Category Path='" + category.Replace(m_strPath + "Categories\\", "") + "'>" + new FileInfo(file).Name.Replace(".ld3", "") + "</Category>";
							}
						}
					}

					foreach (XmlNode xmlWord in xmlDocCategory.DocumentElement.SelectNodes("Names/Name")) {
						foreach (string word in Words) {
							if (!FoundList.Contains(word.ToLower())) {
								if (word.ToLower() == xmlWord.InnerText.ToLower()) {
									if (RandomWord != null) {
										RandomWord(word);
									}
									FoundList.Add(word.ToLower());
                  categories += "<Category Path='" + category.Replace(m_strPath + "Categories\\", "") + "'>" + new FileInfo(file).Name.Replace(".ld3", "") + "</Category>";
								}
							}
						}
					}
				}

				if (initialRun) {
					Completed = true;
				}

        return categories;
			}

			public void LoadCategoriesOld()
			{

				try {
					List<CategoryItem> arrCategoryItems = new List<CategoryItem>();

					List<string> arrUnassigned = new List<string>();
					List<string> arrAssigned = new List<string>();

					// Preload categories
					foreach (string strCategoryDirectory in Directory.GetDirectories(m_strPath + "Categories")) {
						foreach (string strCatgeoryFile in Directory.GetFiles(m_strPath + "Categories\\" + strCategoryDirectory, "*.ld3")) {
							CategoryItem objCatgeoryItem = new CategoryItem();
							objCatgeoryItem.Category = strCategoryDirectory;
							objCatgeoryItem.Name = new FileInfo(strCatgeoryFile).Name.Replace(".ld3", "");
							arrCategoryItems.Add(objCatgeoryItem);

							XmlDocument xmlDocCategory = new XmlDocument();
							xmlDocCategory.Load(strCatgeoryFile);
							foreach (XmlNode xmlWord in xmlDocCategory.DocumentElement.SelectNodes("Names/Name")) {
								CategoryItem objCatgeorySubItem = new CategoryItem();
								objCatgeorySubItem.Category = strCategoryDirectory;
								objCatgeorySubItem.Name = xmlWord.InnerText.Trim(' ');
								objCatgeoryItem.SubItems.Add(xmlWord.InnerText);
								arrCategoryItems.Add(objCatgeorySubItem);
							}
						}
					}

					// Preload ignore list
					XmlDocument xmlDocIgnore = new XmlDocument();
					if ((File.Exists(m_strPath + "IgnoreList.ld3"))) {
						xmlDocIgnore.Load(m_strPath + "IgnoreList.ld3");
						foreach (XmlNode xmlNode in xmlDocIgnore.DocumentElement.SelectNodes("Ignore")) {
							arrUnassigned.Add(xmlNode.InnerText.ToLower());
						}
					}

					foreach (CategoryItem objCategoryItem in arrCategoryItems) {
						string strName = objCategoryItem.Name;

						if (strName.Contains(" ")) {
							if (Dream.ToLower().Contains(strName.ToLower())) {
								if (AddCategoryItem != null) {
									AddCategoryItem(objCategoryItem.Category, strName);
								}
								if (RandomWord != null) {
									RandomWord(strName);
								}

								arrAssigned.Add(strName.ToLower());

								foreach (string strSubItem in objCategoryItem.SubItems) {
									arrAssigned.Add(strSubItem.ToLower());
								}

							}
						}
					}

					foreach (string strWord in lucidcode.LightenedDream.Dreams.Dreaming.GetWords(Dream)) {
						bool boolExists = false;
						foreach (string strItem in arrUnassigned) {
							if (strItem == strWord.ToLower()) {
								boolExists = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}
						foreach (string strItem in arrAssigned) {
							if (strItem == strWord.ToLower()) {
								boolExists = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}

						if (!boolExists) {
							ListViewItem lstItem = new ListViewItem(strWord);
							bool boolCatgegorized = false;
							foreach (CategoryItem objCategoryItem in arrCategoryItems) {
								string strName = objCategoryItem.Name;

								if (strName.ToLower() == strWord.ToLower()) {
									boolCatgegorized = true;
									lstItem.Tag = objCategoryItem.Category;
									try {
										if (AddCategoryItem != null) {
											AddCategoryItem(objCategoryItem.Category, strWord);
										}
										if (RandomWord != null) {
											RandomWord(strWord);
										}

										arrAssigned.Add(strWord.ToLower());

										foreach (string strSubItem in objCategoryItem.SubItems) {
											arrAssigned.Add(strSubItem.ToLower());
										}

									} catch (Exception ex) {
									}
									break; // TODO: might not be correct. Was : Exit For
								}
							}

							if (strWord.Length > 4) {
								if (!boolCatgegorized) {
									try {
										arrUnassigned.Add(strWord.ToLower());
										if (AddCategoryItem != null) {
											AddCategoryItem("Unassigned", strWord);
										}
									} catch (Exception ex) {
									}
								}
							}
						}
					}

					Completed = true;
				} catch (Exception ex) {
					Completed = true;
					MessageBox.Show(ex.Message, "LightenedDream.Dreams.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void txtTitle_TextChanged(System.Object sender, System.EventArgs e)
		{
			lblTitle.Text = "Dreams - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;
			Changed = true;
		}

		private void dtDate_ValueChanged(System.Object sender, System.EventArgs e)
		{
			lblTitle.Text = "Dreams - " + Strings.Format(dtDate.Value, "yyyy-MM-dd") + " - " + txtTitle.Text;
			try {
				objDreamSlider.setDreamTime(new TimeSpan(dtDate.Value.Hour, dtDate.Value.Minute, 0));
			} catch (Exception ex) {
			}
			Changed = true;
		}

		private void txtDream_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (!m_boolLoading) {
				Changed = true;
			}
		}

		private void dtStart_ValueChanged(System.Object sender, System.EventArgs e)
		{
			objDreamSlider.setStartTime(new TimeSpan(dtStart.Value.Hour, dtStart.Value.Minute, 0));
			Changed = true;
		}

		private void dtEnd_ValueChanged(System.Object sender, System.EventArgs e)
		{
			objDreamSlider.setStopTime(new TimeSpan(dtEnd.Value.Hour, dtEnd.Value.Minute, 0));
			Changed = true;
		}

		private void cmbLucidity_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void objSleepHours_Resize(System.Object sender, System.EventArgs e)
		{
			if (objDreamSlider.Width > 310) {
				objDreamSlider.ShowIncrement = true;
			}
			if (objDreamSlider.Width <= 310) {
				objDreamSlider.ShowIncrement = false;
			}

			if (objDreamSlider.Width > 400) {
				objDreamSlider.DisplayInterval = 6;
			}
			if (objDreamSlider.Width <= 400) {
				objDreamSlider.DisplayInterval = 12;
			}
			if (objDreamSlider.Width <= 200) {
				objDreamSlider.DisplayInterval = 24;
			}
			if (objDreamSlider.Width <= 100) {
				objDreamSlider.DisplayInterval = 48;
			}
		}

		private void objDreamSlider_StartTimeChanged(System.TimeSpan Time)
		{
			try {
				dtStart.Value = new System.DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, Time.Hours, Time.Minutes, 0);
			} catch (Exception ex) {
			}
		}

		private void objDreamSlider_EndTimeChanged(System.TimeSpan Time)
		{
			try {
				dtEnd.Value = new System.DateTime(DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, Time.Hours, Time.Minutes, 0);
			} catch (Exception ex) {
			}
		}

		private void objDreamSlider_DreamTimeChanged(System.TimeSpan Time)
		{
			try {
				dtDate.Value = new System.DateTime(dtDate.Value.Year, dtDate.Value.Month, dtDate.Value.Day, Time.Hours, Time.Minutes, 0);
			} catch (Exception ex) {
			}
		}

		private void ResizeImage()
		{
			pnlDreamImage.Width = pbDream.Width + 4;
			pnlDreamImage.Height = pbDream.Height + 4;

			pnlControls.Left = pnlDreamImage.Left + pnlDreamImage.Width + 8;
			pnlControls.Width = SplitContainer1.Width - pnlControls.Left - 2;
		}

		private void mnuThumbnail_Opening(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (Clipboard.ContainsImage()) {
				mnuThumbnailPaste.Enabled = true;
			} else {
				mnuThumbnailPaste.Enabled = false;
			}
		}

		private void mnuThumbnailCopy_Click(System.Object sender, System.EventArgs e)
		{
			Clipboard.SetImage(pbDream.Image);
		}

		private void mnuThumbnailPaste_Click(System.Object sender, System.EventArgs e)
		{
			pbDream.Image = Clipboard.GetImage();
		}

		private int GetRandomItem(int Max)
		{
			VBMath.Randomize();
			int intId = VBMath.Rnd() * Max;
			if (intId >= Max)
				intId = Max - 1;
			return intId;
		}

		private string GetRandomWord()
		{
			VBMath.Randomize();
			string[] arrWords = Dreaming.GetWords(txtDream.Text);
			int intId = (new Random()).Next(0, arrWords.Length);
			return arrWords[intId];
		}

		private void pbDream_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				if (m_formImageBrowser == null) {
					m_formImageBrowser = new ImageBrowserForm();
				}

				m_formImageBrowser.txtKeywords.Text = GetRandomWord();
				m_formImageBrowser.tmrDoSearch.Enabled = true;

				if (m_formImageBrowser.ShowDialog() == DialogResult.OK) {
					if ((m_formImageBrowser.DreamImage != null)) {
						pbDream.Image = m_formImageBrowser.DreamImage;
						ResizeImage();
						Changed = true;
					}
				}
			}
		}
	}
}
