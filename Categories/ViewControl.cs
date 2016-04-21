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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
namespace lucidcode.LightenedDream.Categories
{

	public partial class ViewControl
	{

		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		public string FileName;
		public event SelectDreamEventHandler SelectDream;
		public delegate void SelectDreamEventHandler(string DreamDate, string Title);
		private string m_strCategory;
		public bool Changed = false;
		public event RandomWordEventHandler RandomWord;
		public delegate void RandomWordEventHandler(string Word);

		public void LoadCategory(string strFileName, string Category)
		{

			try {
				// Make sure it is not a sub category
				if (!File.Exists(strFileName)) {
					string strSubName = strFileName.Replace(m_strPath + "Categories\\" + Category + "\\", "").Replace(".ld3", "");
					foreach (string strSubFile in Directory.GetFiles(m_strPath + "Categories\\" + Category, "*.ld3")) {
						bool boolFoundSub = false;
						XmlDocument xmlDocSibling = new XmlDocument();
						xmlDocSibling.Load(strSubFile);
						foreach (XmlNode xmlWord in xmlDocSibling.DocumentElement.SelectNodes("Names/Name")) {
							if (strSubName == xmlWord.InnerText) {
								strFileName = strSubFile;
								boolFoundSub = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}
						if (boolFoundSub)
							break; // TODO: might not be correct. Was : Exit For
					}
				}

				XmlDocument xmlDoc = new XmlDocument();
				FileName = strFileName;
				xmlDoc.Load(FileName);
				m_strCategory = Category;
				lblType.Text = m_strCategory;
				lblTitle.Text = "Categories - " + Category + " - " + xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText;
				txtName.Text = xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText;
				txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText;
				lblTitle.Tag = xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText;
				txtKeywords.Text = "";
				List<string> arrKeywords = new List<string>();

				foreach (XmlNode xmlKeyWord in xmlDoc.DocumentElement.SelectNodes("Names/Name")) {
					arrKeywords.Add(xmlKeyWord.InnerText);
				}

				arrKeywords.Sort();

				foreach (string strKeyword in arrKeywords) {
					txtKeywords.Text += strKeyword + ", ";
				}

				if (txtKeywords.Text.Length > 2) {
					txtKeywords.Text = txtKeywords.Text.Substring(0, txtKeywords.Text.Length - 2);
				}

				UpdateView();
				Changed = false;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void lstCategorized_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
		}

		private void tbcMain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			UpdateView();
		}

		private void UpdateView()
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(FileName);

			// Get Top Month
			int intTopMonth = 0;
			if ((xmlDoc.DocumentElement.SelectSingleNode("Dreams") != null)) {
				foreach (XmlNode xmlYear in xmlDoc.DocumentElement.SelectSingleNode("Dreams").ChildNodes) {
					foreach (XmlNode xmlMonth in xmlYear.ChildNodes) {
						if (xmlMonth.ChildNodes.Count > intTopMonth) {
							intTopMonth = xmlMonth.ChildNodes.Count;
						}
					}
				}
			}

			double intPos = 0.5;
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();

			for (int i = 1; i <= intTopMonth; i++) {
				System.Windows.Forms.DataVisualization.Charting.Series objSeries = graph.Series.Add("DreamSeries." + i);
				objSeries.ChartType = SeriesChartType.StackedColumn;
				objSeries.Color = Color.FromArgb(200, 65, 140, 240);
			}

			foreach (XmlNode xmlYear in xmlDoc.DocumentElement.SelectNodes("Dreams/Year")) {

				foreach (XmlNode xmlMonth in xmlYear.SelectNodes("Month")) {
					int intSeries = 1;
					foreach (XmlNode xmlDream in xmlMonth.SelectNodes("Dream")) {
						int intPoint = graph.Series["DreamSeries." + intSeries].Points.AddY(1);
						graph.Series["DreamSeries." + intSeries].Points[intPoint].ToolTip = xmlDream.Attributes["Title"].InnerText;
						graph.Series["DreamSeries." + intSeries].Points[intPoint].Tag = xmlDream.Attributes["Date"].InnerText;
						intSeries += 1;
					}

					for (int i = intSeries; i <= intTopMonth; i++) {
						graph.Series["DreamSeries." + i].Points.AddY(0);
					}

					System.Windows.Forms.DataVisualization.Charting.CustomLabel objLabel = graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos, intPos + 1, xmlYear.Attributes["Value"].InnerText + "-" + xmlMonth.Attributes["Value"].InnerText);
					intPos = intPos + 1;
				}
			}
		}

		public void Save()
		{
			Changed = false;
			if (txtName.Text != lblTitle.Tag) {
				var newFileName = new FileInfo(FileName).Directory.FullName + "\\" + txtName.Text + ".ld3";
				File.Move(FileName, newFileName);
				FileName = newFileName;
			}

			WorkerClass objWorkerClass = new WorkerClass();
			objWorkerClass.Name = txtName.Text;
			objWorkerClass.Description = txtDescription.Text;
			objWorkerClass.Keywords = txtKeywords.Text;
			objWorkerClass.FileName = FileName;
			objWorkerClass.RandomWord += RandomWordLocal;

			System.Threading.Thread objProcessingThread = new System.Threading.Thread(objWorkerClass.DoSave);
			objProcessingThread.Start();

			do {
				System.Threading.Thread.Sleep(1);
				Application.DoEvents();
				if (objWorkerClass.Completed)
					break; // TODO: might not be correct. Was : Exit Do
			} while (true);

			UpdateView();

		}

		private void RandomWordLocal(string Word)
		{
			if (RandomWord != null) {
				RandomWord(Word);
			}
		}

		private class WorkerClass
		{

			public bool Completed;
			public string Name;
			public string Description;
			public string Keywords;
			public string FileName;

			private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
			public event RandomWordEventHandler RandomWord;
			public delegate void RandomWordEventHandler(string Word);

			private class SafeFilename
			{
				public string Filename;
				public string Guid;
			}

			public void DoSave()
			{

				try {
					List<SafeFilename> safeFilenames = new List<SafeFilename>();

					string strXml = null;
					strXml = "<Category>";

					strXml += "<Name></Name>";
					strXml += "<Description></Description>";
					strXml += "<Names>";

					var strNamesXml = "";
					List<string> arrKeywords = new List<string>();
					arrKeywords.Add(Name.ToLower());
					foreach (string strKeyWord in Keywords.Replace(", ", ",").Split(',')) {
						if (!string.IsNullOrEmpty(strKeyWord)) {
							arrKeywords.Add(strKeyWord.ToLower());
							strXml += "<Name>" + strKeyWord.TrimStart(' ') + "</Name>";
						}
					}

					strXml += "</Names>";

					// Update the list
					// Load each year
					strXml += "<Dreams>";
					foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {
						strXml += "<Year Value='" + new DirectoryInfo(strYearFolder).Name + "'>";
						// Load each month
						foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
							strXml += "<Month Value='" + new DirectoryInfo(strMonthFolder).Name + "'>";
							// Load each dream
							foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
								System.Threading.Thread.Sleep(2);
								XmlDocument xmlDream = new XmlDocument();
								xmlDream.Load(strDreamFile);

								foreach (string strKeyWord in arrKeywords) {
									bool boolFound = false;

									if ((strKeyWord.Contains(" "))) {
										if ((xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower().Contains(strKeyWord))) {
											boolFound = true;
										}
									} else {
										foreach (string strWord in lucidcode.LightenedDream.Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower())) {
											if (strWord == strKeyWord) {
												boolFound = true;
												break; // TODO: might not be correct. Was : Exit For
											}
										}
									}

									if (boolFound) {
										if (RandomWord != null) {
											RandomWord(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText);
										}

										SafeFilename safeFilename = new SafeFilename();
										safeFilename.Guid = Guid.NewGuid().ToString();
										safeFilename.Filename = xmlDream.DocumentElement.SelectSingleNode("Title").InnerText;

										safeFilenames.Add(safeFilename);
										strXml += "<Dream Date='" + xmlDream.DocumentElement.SelectSingleNode("Date").InnerText + "' Title='" + safeFilename.Guid + "' />";

										break; // TODO: might not be correct. Was : Exit For
									}

								}

							}
							strXml += "</Month>";
						}
						strXml += "</Year>";
					}
					strXml += "</Dreams>";
					strXml += "</Category>";

					XmlDocument xmlDoc = new XmlDocument();
					xmlDoc.LoadXml(strXml);

					xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText = Name;
					xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText = Description;

					foreach (XmlNode xmlDream in xmlDoc.DocumentElement.SelectNodes("//Dream")) {
						foreach (SafeFilename safeFilename in safeFilenames) {
							if (safeFilename.Guid == xmlDream.Attributes["Title"].InnerText) {
								xmlDream.Attributes["Title"].InnerText = safeFilename.Filename;
							}
						}
					}

					xmlDoc.Save(FileName);
					Completed = true;

				} catch (Exception ex) {
					Completed = true;
					MessageBox.Show(ex.Message + "/r/n" + "Stack trace: " + ex.StackTrace, "LightenedDream.Categories.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

		}

		private void lstDreams_DoubleClick(object sender, System.EventArgs e)
		{
			if (lstDreams.SelectedItems.Count == 0)
				return;
			if (SelectDream != null) {
				SelectDream(lstDreams.SelectedItems[0].Text, lstDreams.SelectedItems[0].SubItems[1].Text);
			}
		}

		private void graph_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				HitTestResult result = graph.HitTest(e.X, e.Y);
				DataPoint point = null;
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					if (result.Series.Name.StartsWith("DreamSeries")) {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = result.Series.Points[result.PointIndex];
						if (SelectDream != null) {
							SelectDream(point.Tag.ToString(), point.ToolTip);
						}
					}
				}
			}
		}

		private void graph_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				HitTestResult result = graph.HitTest(e.X, e.Y);

				// Reset Data Point Attributes
				DataPoint point = null;
				foreach (Series objSeries in graph.Series) {
					if (objSeries.Name.StartsWith("DreamSeries")) {
						foreach (DataPoint point_loopVariable in objSeries.Points) {
							point = point_loopVariable;
							point.Color = Color.FromArgb(200, 65, 140, 240);
						}
					}
				}

				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {

					if (result.Series.Name.StartsWith("DreamSeries")) {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = result.Series.Points[result.PointIndex];
						point.Color = Color.FromArgb(255, 65, 140, 240);
						// Color.LightSteelBlue
					} else {
						// Set default cursor
						this.Cursor = Cursors.Default;
					}
				} else {
					// Set default cursor
					this.Cursor = Cursors.Default;
				}


			} catch (Exception ex) {
			}
		}

		private void txtName_TextChanged(System.Object sender, System.EventArgs e)
		{
			lblTitle.Text = "Categories - " + m_strCategory + " - " + txtName.Text;
			Changed = true;
		}

		private void txtKeywords_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}

		private void txtDescription_TextChanged(System.Object sender, System.EventArgs e)
		{
			Changed = true;
		}
		public ViewControl()
		{
			InitializeComponent();
		}
	}
}
