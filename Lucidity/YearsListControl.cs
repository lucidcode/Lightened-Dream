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
using System.Windows.Forms.DataVisualization.Charting;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class YearsListControl
	{

		public event MonthSelectedEventHandler MonthSelected;
		public delegate void MonthSelectedEventHandler(string Month);
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private bool m_boolSearching = false;

		private Series objDreamSeries;

		private string m_strSelectedNewCategory;

		public void LoadYears()
		{
			if (m_boolSearching) {
				return;
			}

			m_boolSearching = true;

			try {
				double intPos = 0.5;

				XmlDocument xmlDream = new XmlDocument();

				graph.Series.Clear();
				graph.ChartAreas[0].AxisX.CustomLabels.Clear();
				graph.Visible = true;

				objDreamSeries = graph.Series.Add("Dreams");
				objDreamSeries.ChartType = SeriesChartType.Column;
				objDreamSeries.Tag = 0;
				objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240);
				objDreamSeries.BorderWidth = 1;
				objDreamSeries["BarLabelStyle"] = "Center";


				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Lucidity\\Exercises")) {

					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						objDreamSeries.Points.AddY(0);

						graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos, intPos + 1, new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name);
						intPos += 1;


						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							objDreamSeries.Tag += 1;
							objDreamSeries.Points[objDreamSeries.Points.Count - 1].YValues[0] += 1;
							objDreamSeries.Points[objDreamSeries.Points.Count - 1].ToolTip = new DirectoryInfo(strYearFolder).Name + "-" + new DirectoryInfo(strMonthFolder).Name;

						}

						Application.DoEvents();

					}
				}

				// Totals
				objDreamSeries.Name += " (" + objDreamSeries.Tag + ")";


			} catch (Exception ex) {
			}

			m_boolSearching = false;
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
					if (result.Series.Name.StartsWith("Dreams (")) {
						this.Cursor = Cursors.Hand;
						point = result.Series.Points[result.PointIndex];
						point.Color = Color.FromArgb(255, point.Color.R, point.Color.G, point.Color.B);
					} else {
						this.Cursor = Cursors.Default;
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
						point = objDreamSeries.Points[result.PointIndex];
						if (MonthSelected != null) {
							MonthSelected(point.ToolTip);
						}
					}
				}
			}
		}

	}
}
