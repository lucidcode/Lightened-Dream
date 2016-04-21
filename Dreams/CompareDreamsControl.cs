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

	public partial class CompareDreamsControl
	{

		public event MonthSelectedEventHandler MonthSelected;
		public delegate void MonthSelectedEventHandler(string Month);
		public event CategoryFileSelectedEventHandler CategoryFileSelected;
		public delegate void CategoryFileSelectedEventHandler(string Category, string Item);
		public event CategoryFileCreatedEventHandler CategoryFileCreated;
		public delegate void CategoryFileCreatedEventHandler(string Category, string Item);


		public bool OnlyCategories = false;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";

		private bool m_boolSearching = false;
		private List<Dream> m_arrDreams = new List<Dream>();

		private int m_intSelectedFile = 0;
		private string m_strSelectedNewCategory;
		private List<Word> m_arrWords = new List<Word>();
		private List<string> m_arrIgnore = new List<string>();

		private List<string> m_arrCategories = new List<string>();
		private Series objSeries;

		private Series objDreams;
		public CompareDreamsControl()
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

		private class Dream
		{
			public string File = "";
			public string Name = "";
			public List<string> Words = new List<string>();
			public int Matches;
			public Dream Parent;
			public List<Dream> SimilarDreams;
			public string SharedWords = "";
		}

		public void StartSearch()
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

			pnlSearching.Visible = true;
			graph.Height = this.Height - graph.Top - 48;

			XmlDocument xmlDocIgnore = new XmlDocument();
			string strXml = "";

			m_arrWords = new List<Word>();
			m_arrIgnore = new List<string>();
			m_arrCategories = new List<string>();

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

			// Load each Category
			foreach (string strCategory in Directory.GetDirectories(m_strPath + "Categories")) {
				LoadCategoryFolder(strCategory);
			}

			string[] arrDreamFiles = Directory.GetFiles(m_strPath + "Dreams\\", "*.ld3", SearchOption.AllDirectories);
			foreach (string strDreamFile in arrDreamFiles) {
				Dream objDream = new Dream();
				objDream.File = strDreamFile;
				m_arrDreams.Add(objDream);
			}

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

		private void LoadCategoryFolder(string categoryPath)
		{
			foreach (string strCatgeoryFile in Directory.GetFiles(categoryPath, "*.ld3")) {
				string strName = new FileInfo(strCatgeoryFile).Name.Replace(".ld3", "");

				m_arrCategories.Add(strName.ToLower());

				XmlDocument xmlDocCategory = new XmlDocument();
				xmlDocCategory.Load(strCatgeoryFile);
				foreach (XmlNode xmlWord in xmlDocCategory.DocumentElement.SelectNodes("Names/Name")) {
					m_arrCategories.Add(xmlWord.InnerText.ToLower());
				}
			}

			foreach (string subCategory in Directory.GetDirectories(categoryPath)) {
				LoadCategoryFolder(subCategory);
			}
		}

		private void tmrDreamSigns_Tick(System.Object sender, System.EventArgs e)
		{
			tmrDreamSigns.Enabled = false;

			if (m_intSelectedFile >= m_arrDreams.Count) {
				tmrDreamSigns.Enabled = false;

				m_intSelectedFile = 0;
				tmrDreams.Enabled = true;
				return;
			}

			XmlDocument xmlDream = new XmlDocument();
			xmlDream.Load(m_arrDreams[m_intSelectedFile].File);

			m_arrDreams[m_intSelectedFile].Name = new FileInfo(m_arrDreams[m_intSelectedFile].File).Name.Replace(".ld3", "");
			string[] arrWords = lucidcode.LightenedDream.Dreams.Dreaming.GetWords(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText);
			List<string> arrWordsInDream = SearchForDreamSigns(arrWords, m_arrDreams[m_intSelectedFile].Name);
			m_arrDreams[m_intSelectedFile].Words = arrWordsInDream;

			m_intSelectedFile += 1;
			tmrDreamSigns.Enabled = true;
		}

		private void tmrDreams_Tick(System.Object sender, System.EventArgs e)
		{
			tmrDreams.Enabled = false;

			if (m_intSelectedFile >= m_arrDreams.Count) {
				tmrSearching.Enabled = false;
				tmrDreams.Enabled = false;
				pnlSearching.Visible = false;

				graph.Height = this.Height - graph.Top - 8;
				tmrDreams.Enabled = false;

				CalculateSimliarities();
				return;
			}


			m_arrDreams[m_intSelectedFile].SimilarDreams = new List<Dream>();

			// Compare lists

			foreach (Dream objExisitingDream in m_arrDreams) {
				string strSharedWords = "";
				if (m_arrDreams[m_intSelectedFile].File != objExisitingDream.File) {
					int intSameWords = 0;
					foreach (string objOtherWord in m_arrDreams[m_intSelectedFile].Words) {
						foreach (string objWord in objExisitingDream.Words) {
							if (objOtherWord == objWord) {
								intSameWords += 1;
								strSharedWords += objWord + ", ";
								break; // TODO: might not be correct. Was : Exit For
							}
						}
					}

					if (intSameWords > 0) {
						Dream objExisitingDreamClone = new Dream();
						objExisitingDreamClone.Name = objExisitingDream.Name;
						objExisitingDreamClone.File = objExisitingDream.File;
						objExisitingDreamClone.Matches = intSameWords;
						objExisitingDreamClone.SharedWords = strSharedWords.TrimEnd(' ').TrimEnd(',');
						//objExisitingDreamClone.Parent = m_arrDreams(m_intSelectedFile)
						m_arrDreams[m_intSelectedFile].SimilarDreams.Add(objExisitingDreamClone);
					}

					// Cull to top 3
					List<Dream> arrTop3 = new List<Dream>();

					foreach (Dream objSimilarDream in m_arrDreams[m_intSelectedFile].SimilarDreams) {
						if (arrTop3.Count < 3) {
							arrTop3.Add(objSimilarDream);

						} else {
							foreach (Dream objTopDream in arrTop3) {

								if (objSimilarDream.Matches > objTopDream.Matches) {
									arrTop3.Remove(objTopDream);

									Dream objDreamClone = new Dream();
									objDreamClone.Name = objSimilarDream.Name;
									objDreamClone.File = objSimilarDream.File;
									objDreamClone.Matches = objSimilarDream.Matches;
									objDreamClone.SharedWords = objSimilarDream.SharedWords;

									arrTop3.Add(objDreamClone);

									break; // TODO: might not be correct. Was : Exit For
								}
							}

						}
					}

					m_arrDreams[m_intSelectedFile].SimilarDreams = arrTop3;

				}
			}

			CalculateSimliarities();

			m_intSelectedFile += 1;
			tmrDreams.Enabled = true;
		}


		List<Word> m_arrAllWordsDreams = new List<Word>();

		List<Word> m_arrLatestDreams = new List<Word>();
		private List<string> SearchForDreamSigns(string[] arrWords, string Entry)
		{
			if (m_boolSearching) {
				return null;
			}

			List<string> arrWordsInDream = new List<string>();


			foreach (string strWord in arrWords) {

				if (!string.IsNullOrEmpty(strWord)) {
					// Check if the word is already in the list
					bool boolFound = false;
					foreach (string strExisitingWord in arrWordsInDream) {
						if (strExisitingWord.ToLower() == strWord.ToLower()) {
							boolFound = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					// Make sure it isn't in the ignore list
					foreach (string strExisitingWord in m_arrIgnore) {
						if (strExisitingWord.ToLower() == strWord.ToLower()) {
							boolFound = true;
							break; // TODO: might not be correct. Was : Exit For
						}
					}

					if (!boolFound) {
						if (OnlyCategories) {
							foreach (string strCategory in m_arrCategories) {
								if (strCategory.ToLower() == strWord.ToLower()) {
									arrWordsInDream.Add(strWord.ToLower());
									break; // TODO: might not be correct. Was : Exit For
								}
							}
						} else {
							arrWordsInDream.Add(strWord.ToLower());
						}



					}
				}

			}

			if (m_arrLatestDreams.Count > 10) {
				m_arrLatestDreams.Remove(m_arrLatestDreams[0]);
			}

			Word objDreamWord = new Word();
			objDreamWord.Name = Entry;
			objDreamWord.Count = arrWordsInDream.Count;
			m_arrLatestDreams.Add(objDreamWord);

			// Find the top 10
			//    For Each objWord As String In arrWordsInDream

			//        If m_arrTop10.Count < 10 Then
			//            m_arrTop10.Add(objWord)
			//        Else

			//            Dim boolAlreadyExists As Boolean = False
			//            For Each objTopWord As Word In m_arrTop10
			//                If objWord.Name.ToLower = objTopWord.Name.ToLower Then
			//                    boolAlreadyExists = True
			//                    Exit For
			//                End If
			//            Next

			//            If Not boolAlreadyExists Then
			//                For Each objTopWord As Word In m_arrTop10
			//                    If objWord.Count > objTopWord.Count Then

			//                        objTopWord.Name = objWord.Name
			//                        objTopWord.Count = objWord.Count

			//                        Application.DoEvents()

			//                        Exit For
			//                    End If
			//                Next
			//            End If

			//        End If

			//    Next

			objSeries.Points.Clear();
			graph.Annotations.Clear();

			foreach (Word objTopWord in m_arrLatestDreams) {
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
				objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
				objDreamAnnotation.AnchorDataPoint = objSeries.Points[objSeries.Points.Count - 1];
				this.graph.Annotations.Add(objDreamAnnotation);
			}

			m_boolSearching = false;

			return arrWordsInDream;
		}

		string strReport = "";
		private void CalculateSimliarities()
		{
			List<Dream> arrTop10 = new List<Dream>();


			foreach (Dream objDream in m_arrDreams) {
				if ((objDream.SimilarDreams != null)) {

					foreach (Dream objSimilarDream in objDream.SimilarDreams) {

						if (arrTop10.Count < 5) {
							// Make sure it doesn't exist yet
							bool boolExists = false;
							foreach (Dream objAlreadyTop10 in arrTop10) {
								if (objAlreadyTop10.File == objSimilarDream.File) {
									if (objAlreadyTop10.Parent.File == objDream.File) {
										boolExists = true;
										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}

							//Flip
							foreach (Dream objAlreadyTop10 in arrTop10) {
								if (objAlreadyTop10.Parent.File == objSimilarDream.File) {
									if (objAlreadyTop10.File == objDream.File) {
										boolExists = true;
										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}

							if (!boolExists) {
								Dream objDreamClone = new Dream();
								objDreamClone.Name = objSimilarDream.Name;
								objDreamClone.File = objSimilarDream.File;
								objDreamClone.Parent = objDream;
								objDreamClone.Matches = objSimilarDream.Matches;
								objDreamClone.SharedWords = objSimilarDream.SharedWords;

								arrTop10.Add(objDreamClone);
							}

						} else {
							// Make sure it doesn't exist yet
							bool boolExists = false;
							foreach (Dream objAlreadyTop10 in arrTop10) {
								if (objAlreadyTop10.File == objSimilarDream.File) {
									if (objAlreadyTop10.Parent.File == objDream.File) {
										boolExists = true;
										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}

							//Flip
							foreach (Dream objAlreadyTop10 in arrTop10) {
								if (objAlreadyTop10.Parent.File == objSimilarDream.File) {
									if (objAlreadyTop10.File == objDream.File) {
										boolExists = true;
										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}

							if (!boolExists) {
								foreach (Dream objTopDream in arrTop10) {
									if (objSimilarDream.Matches > objTopDream.Matches) {
										arrTop10.Remove(objTopDream);

										Dream objDreamClone = new Dream();
										objDreamClone.Name = objSimilarDream.Name;
										objDreamClone.File = objSimilarDream.File;
										objDreamClone.Matches = objSimilarDream.Matches;
										objDreamClone.Parent = objDream;
										objDreamClone.SharedWords = objSimilarDream.SharedWords;
										arrTop10.Add(objDreamClone);

										Application.DoEvents();

										break; // TODO: might not be correct. Was : Exit For
									}
								}
							}
						}

					}
				}
			}

			objSeries.Points.Clear();
			graph.Annotations.Clear();

			strReport = "";
			foreach (Dream objTopDream in arrTop10) {
				objSeries.Points.AddY(objTopDream.Matches);
				objSeries.Points[objSeries.Points.Count - 1].Tag = objTopDream.Name;
				objSeries.Points[objSeries.Points.Count - 1].ToolTip = "[" + objTopDream.Matches + "]: " + ParaString(objTopDream.SharedWords);

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
				objDreamAnnotation.Text = objTopDream.Parent.Name + Constants.vbNewLine + " ≈≈≈ " + Constants.vbNewLine + objTopDream.Name + Constants.vbNewLine;
				objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
				objDreamAnnotation.AnchorDataPoint = objSeries.Points[objSeries.Points.Count - 1];
				this.graph.Annotations.Add(objDreamAnnotation);
				strReport += objTopDream.Parent.Name + " ≈≈≈ " + objTopDream.Name + Constants.vbNewLine + "[" + objTopDream.Matches + "]: " + objTopDream.SharedWords + Constants.vbNewLine + Constants.vbNewLine;
			}
      strReport = strReport.TrimEnd('\r').TrimEnd('\n');
      strReport = strReport.TrimEnd('\r').TrimEnd('\n');
			Application.DoEvents();

		}

		private string ParaString(string str)
		{
			int chunkSize = 64;
			int stringLength = str.Length;
			int i = 0;
			string strResponse = "";

			while (i < stringLength) {
				if (i + chunkSize > stringLength) {
					chunkSize = stringLength - i;
				}

				strResponse += str.Substring(i, chunkSize) + Constants.vbNewLine;

				i += chunkSize;
			}

      return strResponse.TrimEnd('\r').TrimEnd('\n');
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				if (tmrSearching.Enabled)
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
			tmrDreamSigns.Enabled = false;
			pnlSearching.Visible = false;
			graph.Height = this.Height - graph.Top - 8;
			tmrSearching.Enabled = false;

			mnuCategories.Show(graph, e.X, e.Y);
		}

		private void mnuCategories_Click(System.Object sender, System.EventArgs e)
		{
			if (CategoryFileCreated != null) {
        CategoryFileCreated(((ToolStripMenuItem)sender).Tag.ToString(), m_strSelectedNewCategory);
			}

		}

		private void tmrSearching_Tick(System.Object sender, System.EventArgs e)
		{
			objDreams.Points.AddY(Conversion.Int(VBMath.Rnd() * 1000));
			objDreams.Points.Remove(objDreams.Points[0]);
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

				// Rerun the search
				StartSearch();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.DreamSigns.Ignore()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuCopy_Click(System.Object sender, System.EventArgs e)
		{
			Clipboard.SetText(strReport);
			MessageBox.Show("The comparison report was successfully copied to the clipboard.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
