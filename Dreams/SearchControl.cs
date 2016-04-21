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
namespace lucidcode.LightenedDream.Dreams
{

	public partial class SearchControl
	{

		public event MonthSelectedEventHandler MonthSelected;
		public delegate void MonthSelectedEventHandler(string Month);
		public event CategoryFileSelectedEventHandler CategoryFileSelected;
		public delegate void CategoryFileSelectedEventHandler(string CategoryItem);
		public event CategoryFileCreatedEventHandler CategoryFileCreated;
		public delegate void CategoryFileCreatedEventHandler(string Category, string Item);
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolSearching = false;

		private Series objDreamSeries;

		private string m_strSelectedNewCategory;

		public SearchControl()
		{
			// This call is required by the designer.
			InitializeComponent();

			// Load each Category
			foreach (string strCategory in Directory.GetDirectories(m_strPath + "Categories")) {
				LoadCategoryFolder(strCategory, mnuAddTo);
			}
		}

		private void LoadCategoryFolder(string strCategory, ToolStripMenuItem parentNode)
		{
			ToolStripMenuItem objToolMenuItem = new ToolStripMenuItem();
			objToolMenuItem.Image = CategoryMenuItem.Image;
			objToolMenuItem.Text = new DirectoryInfo(strCategory).Name;
			objToolMenuItem.Tag = strCategory;
			objToolMenuItem.Click += mnuToolNewCategoryItem_Click;
			parentNode.DropDownItems.Add(objToolMenuItem);

			foreach (string subCategory in Directory.GetDirectories(strCategory)) {
				LoadCategoryFolder(subCategory, objToolMenuItem);
			}
		}

		public void Activate()
		{
			txtSearch.Focus();
			if (!string.IsNullOrEmpty(txtSearch.Text)) {
				Search();
			}
		}


		private void Search()
		{
			if (m_boolSearching) {
				return;
			}

			m_boolSearching = true;

			try {
				double intPos = 0.5;

				var arrWords = txtSearch.Text.Replace(",", " ").Replace(Constants.vbNewLine, " ").Split(' ');
				XmlDocument xmlDream = new XmlDocument();

				graph.Series.Clear();
				graph.ChartAreas[0].AxisX.CustomLabels.Clear();
				graph.Visible = true;


				objDreamSeries = graph.Series.Add("Dreams");
				objDreamSeries.ChartType = SeriesChartType.SplineArea;
				objDreamSeries.Tag = 0;
				objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240);
				objDreamSeries.BorderWidth = 1;
				objDreamSeries["BarLabelStyle"] = "Center";

				objDreamSeries.Points.AddY(0);
				intPos = 1;

				// Load all the words
				foreach (string strWord in arrWords) {
					if (!string.IsNullOrEmpty(strWord)) {
						Series objSeries = graph.Series.Add(strWord);
						objSeries.ChartType = SeriesChartType.StackedColumn;
						graph.ApplyPaletteColors();
						objSeries.Points.Add(0);
						objSeries.Tag = 0;
					}
				}

				foreach (Series objSeries in graph.Series) {
					objSeries.Color = Color.FromArgb(200, objSeries.Color.R, objSeries.Color.G, objSeries.Color.B);
				}

				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {

					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						objDreamSeries.Points.AddY(0);

						foreach (string strWord in arrWords) {
							if (!string.IsNullOrEmpty(strWord)) {
								graph.Series[strWord].Points.AddY(0);
								graph.Series[strWord].Points[graph.Series[strWord].Points.Count - 1].ToolTip = strWord + " - " + new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name;
							}
						}

						graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos, intPos + 1, new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name);
						intPos += 1;


						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							objDreamSeries.Tag = Convert.ToInt32(objDreamSeries.Tag) + 1;
							objDreamSeries.Points[objDreamSeries.Points.Count - 1].YValues[0] += 1;
							objDreamSeries.Points[objDreamSeries.Points.Count - 1].ToolTip = new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name;

							xmlDream.Load(strDreamFile);

							foreach (string strWord in arrWords) {
								if (!string.IsNullOrEmpty(strWord)) {

									if ((xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower().Contains(strWord.ToLower()))) {
										graph.Series[strWord].Points[graph.Series[strWord].Points.Count - 1].YValues[0] += 1;
										graph.Series[strWord].Tag = Convert.ToInt32(graph.Series[strWord].Tag) + 1;

									}
								}
							}

						}

						foreach (string strWord in arrWords) {
							if (!string.IsNullOrEmpty(strWord)) {
								graph.Series[strWord].Points[graph.Series[strWord].Points.Count - 1].ToolTip = new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name + " - " + strWord + " (" + graph.Series[strWord].Points[graph.Series[strWord].Points.Count - 1].YValues[0] + ")";
							}
						}

						Application.DoEvents();

					}
				}

				// Link to categories
				foreach (Series objSeries in graph.Series) {

					if (objSeries.Name != "Dreams") {
						string strCatgeoryFile = FindCategoryFolder(m_strPath + "Categories", objSeries.Name.ToLower());

						if (!string.IsNullOrEmpty(strCatgeoryFile)) {
							string strTag = objSeries.Tag.ToString();
							objSeries.Tag = strCatgeoryFile;
							objSeries.Name += " (" + strTag + ")";
						}
					}
				}

				// Totals
				foreach (Series objSeries in graph.Series) {
					if (objSeries.Name != "Dreams") {
						if (Conversion.Val(objSeries.Tag) > 0) {
							string strName = objSeries.Name;
							objSeries.Name += " (" + objSeries.Tag + ")";
							objSeries.Tag = strName;
						}
					}
				}
				objDreamSeries.Name += " (" + objDreamSeries.Tag + ")";
				//For Each strWord As String In arrWords
				//  If strWord <> "" Then
				//    graph.Series(strWord).Name += " (" & graph.Series(strWord).Tag & ")"
				//  End If
				//Next


			} catch (Exception ex) {
			}

			m_boolSearching = false;
		}

		private string FindCategoryFolder(string categoryPath, string categoryName)
		{
			foreach (string strCatgeoryFile in Directory.GetFiles(categoryPath, "*.ld3")) {
				string strName = new FileInfo(strCatgeoryFile).Name.Replace(".ld3", "");
				if (strName.ToLower() == categoryName) {
					return strCatgeoryFile;
				}

				XmlDocument xmlDocCategory = new XmlDocument();
				xmlDocCategory.Load(strCatgeoryFile);
				foreach (XmlNode xmlWord in xmlDocCategory.DocumentElement.SelectNodes("Names/Name")) {
					if (xmlWord.InnerText.ToLower() == categoryName) {
						return strCatgeoryFile;
					}
				}
			}

			foreach (string subCategory in Directory.GetDirectories(categoryPath)) {
				string subCategoryItem = FindCategoryFolder(subCategory, categoryName);
				if (!string.IsNullOrEmpty(subCategoryItem)) {
					return subCategoryItem;
				}
			}

			return "";
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
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
					if (result.Series.Tag.ToString().Contains("\\")) {
						this.Cursor = Cursors.Hand;
						point = result.Series.Points[result.PointIndex];
						point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B);
					} else if (result.Series.Name.StartsWith("Dreams (")) {
						if (result.PointIndex > -1) {
							this.Cursor = Cursors.Hand;
							point = result.Series.Points[result.PointIndex];
							point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B);
						}
					} else {
						this.Cursor = Cursors.Default;
						point = result.Series.Points[result.PointIndex];
						point.Color = Color.FromArgb(220, point.Color.R, point.Color.G, point.Color.B);
					}
				} else {
					this.Cursor = Cursors.Default;
				}

			} catch (Exception ex) {
			}
		}

		private void graph_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				HitTestResult result = graph.HitTest(e.X, e.Y);
				DataPoint point = null;
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					if (result.Series.Name.StartsWith("Dreams (")) {
						if (result.PointIndex > -1) {
							point = objDreamSeries.Points[result.PointIndex];
							if (MonthSelected != null) {
								MonthSelected(point.ToolTip);
							}
						}
					} else {
						if (result.Series.Tag.ToString().Contains("\\")) {
							if (CategoryFileSelected != null) {
								CategoryFileSelected(result.Series.Tag.ToString());
							}
						} else {
							m_strSelectedNewCategory = result.Series.Tag.ToString();
							if (!(m_strSelectedNewCategory == "0")) {
								mnuAddTo.Text = "Add '" + m_strSelectedNewCategory + "' to";
								mnuCategories.Show(graph, e.X, e.Y);
							}
						}
					}
				}
			}

			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				HitTestResult result = graph.HitTest(e.X, e.Y);
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					if (result.Series.Name.StartsWith("Dreams (")) {
					} else {
						if (result.Series.Tag.ToString().Contains("\\")) {
						} else {
							m_strSelectedNewCategory = result.Series.Tag.ToString();
							mnuAddTo.Text = "Add '" + m_strSelectedNewCategory + "' to";
							mnuCategories.Show(graph, e.X, e.Y);
						}
					}
				}
			}
		}

		private void txtSearch_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Search();
			}
		}

		private void btnSearch_Click(System.Object sender, System.EventArgs e)
		{
			Search();
		}


		private void graph_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void mnuToolNewCategoryItem_Click(System.Object sender, System.EventArgs e)
		{
			if (CategoryFileCreated != null) {
				CategoryFileCreated(((ToolStripMenuItem)sender).Tag.ToString(), m_strSelectedNewCategory);
			}
		}
	}
}
