using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Windows.Forms.DataVisualization;
namespace lucidcode.LightenedDream.Dreams
{

	public partial class RecentDreamSignControl
	{

		public event CategoryFileCreatedEventHandler CategoryFileCreated;
		public delegate void CategoryFileCreatedEventHandler(string Category, string Item);
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolSearching = false;

		private bool m_boolLoading = true;
		private string[] m_arrDreamFiles;

		private int m_intSelectedFile = 0;
		private string m_strSelectedNewCategory;
		private List<Word> m_arrWords = new List<Word>();

		private List<string> m_arrIgnore = new List<string>();
		private Series objSeries;
		private Series objDreams;
		private List<Word> m_arrTop100 = new List<Word>();

		private List<Word> m_arrTop10 = new List<Word>();
		public RecentDreamSignControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.
			objDreams = Chart1.Series.Add("Dreams");
			objDreams.ChartType = SeriesChartType.Column;
			objDreams.Color = Color.FromArgb(200, 65, 140, 240);
			objDreams.BorderWidth = 1;

		}

		private class Word
		{
			public string Name = "";
			public int Count = 1;
		}

		private void mnuToolNewCategoryItem_Click(System.Object sender, System.EventArgs e)
		{
			if (CategoryFileCreated != null) {
        CategoryFileCreated(((ToolStripMenuItem)sender).Tag.ToString(), m_strSelectedNewCategory);
			}

			foreach (Word objWord in m_arrTop100) {
				if (objWord.Name == m_strSelectedNewCategory) {
					objWord.Name = "";
				}
			}

			mnuCategories.Hide();

			m_arrTop10.Clear();
			LoadGraph();
		}

		public void StartSearch()
		{
			cmbFromYear.Items.Clear();
			cmbToYear.Items.Clear();

			foreach (string year in Directory.GetDirectories(m_strPath + "Dreams")) {
				cmbFromYear.Items.Add(new DirectoryInfo(year).Name);
				cmbToYear.Items.Add(new DirectoryInfo(year).Name);
			}

      cmbFromYear.Text = cmbFromYear.Items[0].ToString();
      cmbToYear.Text = cmbFromYear.Items[cmbFromYear.Items.Count - 1].ToString();

			cmbFromMonth.Text = "1";
      cmbToMonth.Text = DateTime.Now.Month.ToString();

			m_boolLoading = false;
			RunSearch();
		}


		private void RunSearch()
		{
			if (m_boolLoading)
				return;

			objDreams.Points.Clear();
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(1000);
			tmrSearching.Enabled = true;

			lblTitle.Text = "Recent Dream Signs";

			pnlSearching.Visible = true;
			graph.Height = this.Height - graph.Top - 48;

			XmlDocument xmlDocIgnore = new XmlDocument();
			string strXml = "";

			m_arrWords = new List<Word>();
			m_arrIgnore = new List<string>();
			m_arrTop100 = new List<Word>();
			m_arrTop10 = new List<Word>();

			// Make sure that the ignore file exists
			if ((!File.Exists(m_strPath + "IgnoreList.ld3"))) {
				// Create the ignore file
				strXml = "<LightenedDream>";
				strXml += "</LightenedDream>";
				xmlDocIgnore.LoadXml(strXml);
				xmlDocIgnore.Save(m_strPath + "IgnoreList.ld3");
			}

			xmlDocIgnore.Load(m_strPath + "IgnoreList.ld3");

			foreach (XmlNode xmlNode in xmlDocIgnore.DocumentElement.SelectNodes("Ignore")) {
				m_arrIgnore.Add(xmlNode.InnerText.ToLower());
			}

			m_arrDreamFiles = Directory.GetFiles(m_strPath + "Dreams\\", "*.ld3", SearchOption.AllDirectories);
			m_arrWords.Clear();

			graph.Series.Clear();
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Visible = true;

			m_intSelectedFile = 0;

			tmrDreamSigns.Enabled = true;

			objSeries = graph.Series.Add("DreamSigns");
			objSeries.ChartType = SeriesChartType.Column;

			objSeries.Color = Color.FromArgb(200, 65, 140, 240);
			objSeries.BorderWidth = 1;
			objSeries["BarLabelStyle"] = "Center";

		}

		public void CountDreamTypes()
		{
			objDreams.Points.Clear();
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(1000);
			tmrSearching.Enabled = true;

			lblTitle.Text = "Dream Types";

			pnlSearching.Visible = true;
			graph.Height = this.Height - graph.Top - 48;

			m_arrWords = new List<Word>();
			m_arrIgnore = new List<string>();
			m_arrTop100 = new List<Word>();
			m_arrTop10 = new List<Word>();

			m_arrDreamFiles = Directory.GetFiles(m_strPath + "Dreams\\", "*.ld3", SearchOption.AllDirectories);
			m_arrWords.Clear();

			graph.Series.Clear();
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Visible = true;

			m_intSelectedFile = 0;

			tmrDreamTypes.Enabled = true;

			objSeries = graph.Series.Add("DreamSigns");
			objSeries.ChartType = SeriesChartType.Column;

			objSeries.Color = Color.FromArgb(200, 65, 140, 240);
			objSeries.BorderWidth = 1;
			objSeries["BarLabelStyle"] = "Center";
		}

		private void tmrDreamSigns_Tick(System.Object sender, System.EventArgs e)
		{
			tmrDreamSigns.Enabled = false;

			if (m_intSelectedFile >= m_arrDreamFiles.Length) {
				tmrDreamSigns.Enabled = false;
				pnlSearching.Visible = false;
				graph.Height = this.Height - graph.Top - 8;
				tmrSearching.Enabled = false;
				return;
			}

			int month = Convert.ToInt32(new FileInfo(m_arrDreamFiles[m_intSelectedFile]).Directory.Name);
			int year = Convert.ToInt32(new FileInfo(m_arrDreamFiles[m_intSelectedFile]).Directory.Parent.Name);

			int fromYear = Convert.ToInt32(cmbFromYear.Text);
			int fromMonth = Convert.ToInt32(cmbFromMonth.Text);
			int toYear = Convert.ToInt32(cmbToYear.Text);
      int toMonth = Convert.ToInt32(cmbToMonth.Text);

			if ((year > fromYear) | (year == fromYear & month >= fromMonth)) {
				if ((year < toYear) | (year == toYear & month <= toMonth)) {
					XmlDocument xmlDream = new XmlDocument();
					xmlDream.Load(m_arrDreamFiles[m_intSelectedFile]);
					string[] arrWords = lucidcode.LightenedDream.Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText);
					Search(arrWords);
				}
			}

			m_intSelectedFile += 1;
			tmrDreamSigns.Enabled = true;
		}

		private void tmrDreamTypes_Tick(System.Object sender, System.EventArgs e)
		{
			tmrDreamTypes.Enabled = false;

			if (m_intSelectedFile >= m_arrDreamFiles.Length) {
				tmrDreamTypes.Enabled = false;
				pnlSearching.Visible = false;
				graph.Height = this.Height - graph.Top - 8;
				tmrSearching.Enabled = false;
				return;
			}

			XmlDocument xmlDream = new XmlDocument();
			xmlDream.Load(m_arrDreamFiles[m_intSelectedFile]);

			string strDreamType = xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText;

			switch (strDreamType) {
				case "1":
					strDreamType = "Thought";
					break;
				case "2":
					strDreamType = "Daydream";
					break;
				case "3":
					strDreamType = "Nightmare";
					break;
				case "4":
					strDreamType = "Foggy Dream";
					break;
				case "5":
					strDreamType = "Normal Dream";
					break;
				case "6":
					strDreamType = "Vivid Dream";
					break;
				case "7":
					strDreamType = "Lucid Dream";
					break;
				case "8":
					strDreamType = "Epic Dream";
					break;
				case "9":
					strDreamType = "Wake Induced";
					break;
				default:
					strDreamType = "Unclassified";
					break;
			}

			bool boolAlreadyExists = false;
			foreach (Word objTopWord in m_arrTop100) {
				if (strDreamType.ToLower() == objTopWord.Name.ToLower()) {
					boolAlreadyExists = true;
					objTopWord.Count += 1;
					break; // TODO: might not be correct. Was : Exit For
				}
			}

			if (!boolAlreadyExists) {
				Word objDreamType = new Word();
				objDreamType.Name = strDreamType;
				objDreamType.Count = 1;
				m_arrTop100.Add(objDreamType);
			}

			LoadGraph(true);

			m_intSelectedFile += 1;
			tmrDreamTypes.Enabled = true;
		}

		private void Search(string[] arrWords)
		{
			if (m_boolSearching) {
				return;
			}

			List<string> FoundList = new List<string>();


			foreach (string strWord in arrWords) {

				if (!string.IsNullOrEmpty(strWord)) {
					// Check if the word is in the list
					bool boolFound = false;
					foreach (Word objWord in m_arrWords) {
						if (objWord.Name.ToLower() == strWord.ToLower()) {
							boolFound = true;
							if (!FoundList.Contains(strWord.ToLower())) {
								objWord.Count += 1;
								FoundList.Add(strWord.ToLower());
							}
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolFound) {
						// Check if it is in the black list
						bool boolIgnored = false;
						foreach (string strIgnoreWord in m_arrIgnore) {
							if (strIgnoreWord.ToLower() == strWord.ToLower()) {
								boolIgnored = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}

						if (!boolIgnored) {
							// Add it to the list
							Word objWord = new Word();
							objWord.Name = strWord;
							m_arrWords.Add(objWord);
							FoundList.Add(strWord.ToLower());
						}

					}
				}

			}

			// Find the top 100

			foreach (Word objWord in m_arrWords) {
				if (m_arrTop100.Count < 100) {
					bool boolAlreadyExists = false;
					foreach (Word objTopWord in m_arrTop100) {
						if (objWord.Name.ToLower() == objTopWord.Name.ToLower()) {
							boolAlreadyExists = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolAlreadyExists) {
						m_arrTop100.Add(objWord);
					}

				} else {
					bool boolAlreadyExists = false;
					foreach (Word objTopWord in m_arrTop100) {
						if (objWord.Name.ToLower() == objTopWord.Name.ToLower()) {
							boolAlreadyExists = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolAlreadyExists) {
						foreach (Word objTopWord in m_arrTop100) {

							if (objWord.Count > objTopWord.Count) {
								objTopWord.Name = objWord.Name;
								objTopWord.Count = objWord.Count;

								Application.DoEvents();

								break; // TODO: might not be correct. Was : Exit For
							}
						}
					}

				}
			}

			LoadGraph();

			m_boolSearching = false;
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				if (tmrSearching.Enabled)
					return;
				if (lblTitle.Text == "Dream Types")
					return;

				HitTestResult result = graph.HitTest(e.X, e.Y);

				// Reset Data Point Attributes
				DataPoint point = null;
				foreach (Series objSeries in graph.Series) {
					foreach (DataPoint point_loopVariable in objSeries.Points) {
						point = point_loopVariable;
						point.Color = Color.FromArgb(200, point.Color.R, point.Color.G, point.Color.B);
					}
				}

				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					this.Cursor = Cursors.Hand;
					point = result.Series.Points[result.PointIndex];
					point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B);
				} else {
					this.Cursor = Cursors.Default;
				}

			} catch (Exception ex) {
			}
		}

		private void graph_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (lblTitle.Text == "Dream Types")
				return;

			tmrDreamSigns.Enabled = false;
			pnlSearching.Visible = false;
			graph.Height = this.Height - graph.Top - 8;
			tmrSearching.Enabled = false;

			HitTestResult result = graph.HitTest(e.X, e.Y);
			DataPoint point = null;
			if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
				point = result.Series.Points[result.PointIndex];
				m_strSelectedNewCategory = point.Tag.ToString();
				mnuIgnore.Text = "Ignore '" + m_strSelectedNewCategory + "'";
				mnuCategories.Show(graph, e.X, e.Y);
			}
		}

		private void mnuCategories_Click(System.Object sender, System.EventArgs e)
		{
			if (CategoryFileCreated != null) {
        CategoryFileCreated(((ToolStripMenuItem)sender).Tag.ToString(), m_strSelectedNewCategory);
			}

			foreach (Word objWord in m_arrTop100) {
				if (objWord.Name == m_strSelectedNewCategory) {
					objWord.Name = "";
				}
			}
			m_arrTop10.Clear();
			LoadGraph();
		}

		private void tmrSearching_Tick(System.Object sender, System.EventArgs e)
		{
			objDreams.Points.AddY(Conversion.Int(VBMath.Rnd() * 1000));
			objDreams.Points.Remove(objDreams.Points[0]);
		}

		private void LoadGraph(bool DisplayCount = false)
		{
			objSeries.Points.Clear();
			graph.Annotations.Clear();

			// Find the top 10
			foreach (Word objWord in m_arrTop100) {
				if (m_arrTop10.Count < 10) {
					bool boolAlreadyExists = false;
					foreach (Word objTopWord in m_arrTop10) {
						if (objWord.Name.ToLower() == objTopWord.Name.ToLower()) {
							boolAlreadyExists = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolAlreadyExists) {
						if (!string.IsNullOrEmpty(objWord.Name)) {
							m_arrTop10.Add(objWord);
						}
					}

				} else {
					bool boolAlreadyExists = false;
					foreach (Word objTopWord in m_arrTop10) {
						if (objWord.Name.ToLower() == objTopWord.Name.ToLower()) {
							boolAlreadyExists = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolAlreadyExists) {
						if (m_arrTop10.Count > 0) {
							foreach (Word objTopWord in m_arrTop10) {
								if (objWord.Count > objTopWord.Count) {
									if (!string.IsNullOrEmpty(objWord.Name)) {
										objTopWord.Name = objWord.Name;
										objTopWord.Count = objWord.Count;
										Application.DoEvents();
										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}
						}
					}

				}
			}


			int intAdded = 0;
			foreach (Word objTopWord in m_arrTop10) {
				objSeries.Points.AddY(objTopWord.Count);
				objSeries.Points[objSeries.Points.Count - 1].Tag = objTopWord.Name;
				objSeries.Points[objSeries.Points.Count - 1].ToolTip = objTopWord.Name + " (" + objTopWord.Count + ")";

				System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objDreamAnnotation = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
				objDreamAnnotation.AllowMoving = true;
				objDreamAnnotation.AllowResizing = true;
				objDreamAnnotation.AllowSelecting = true;
				objDreamAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
				objDreamAnnotation.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
				objDreamAnnotation.ForeColor = System.Drawing.Color.SteelBlue;
				objDreamAnnotation.LineColor = System.Drawing.Color.LightSteelBlue;
				objDreamAnnotation.Name = Guid.NewGuid().ToString();
				objDreamAnnotation.ShadowColor = System.Drawing.Color.SteelBlue;
				objDreamAnnotation.ShadowOffset = 1;
				objDreamAnnotation.Text = objTopWord.Name;
				if (DisplayCount)
					objDreamAnnotation.Text = objDreamAnnotation.Text + " (" + objTopWord.Count + ")";
				objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
				objDreamAnnotation.AnchorDataPoint = objSeries.Points[objSeries.Points.Count - 1];
				this.graph.Annotations.Add(objDreamAnnotation);
				intAdded += 1;
				if (intAdded > 10) {
					break; // TODO: might not be correct. Was : Exit For
				}
			}

			if (pnlSearching.Visible == false) {
				if (m_arrTop100.Count < 10) {
					StartSearch();
				}
			}

		}

		private void mnuIgnore_Click(System.Object sender, System.EventArgs e)
		{

			try {
				// Load the ignore file
				XmlDocument xmlDocIgnore = new XmlDocument();
				xmlDocIgnore.Load(m_strPath + "IgnoreList.ld3");

				// Add the new word to the ignore file
				XmlNode xmlNode = xmlDocIgnore.CreateElement("Ignore");
				xmlNode.InnerText = m_strSelectedNewCategory;
				xmlDocIgnore.DocumentElement.AppendChild(xmlNode);
				xmlDocIgnore.Save(m_strPath + "IgnoreList.ld3");

				// Reload the graph
				foreach (Word objWord in m_arrTop100) {
					if (objWord.Name == m_strSelectedNewCategory) {
						m_arrTop100.Remove(objWord);
						break; // TODO: might not be correct. Was : Exit For
					}
				}

				LoadGraph();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.DreamSigns.Ignore()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbFromYear_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			RunSearch();
		}

		private void cmbFromMonth_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			RunSearch();
		}

		private void cmbToYear_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			RunSearch();
		}

		private void cmbToMonth_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			RunSearch();
		}
	}
}
