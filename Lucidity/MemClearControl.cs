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
using System.Windows.Forms.DataVisualization;
using System.Drawing.Drawing2D;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class MemClearControl
	{

		public event DreamSelectedEventHandler DreamSelected;
		public delegate void DreamSelectedEventHandler(string Dream);

		public void LoadDay(string Folder, string Year, string Month)
		{
			double intPos = 0.5;
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();
			graph.ResetAutoValues();
			graph.Annotations.Clear();

			lstDreams.Items.Clear();

			DateTime dtMonth = new DateTime(Year, Month, 1);

			int intPoint = 0;
			ListViewItem lstItem = null;
			int intLongestDream = 0;

			int intMostLucidDream = 0;

			string strMostLucidDream = "";

			lblTitle.Text = "Lucidity - Exercises - " + Strings.Format(dtMonth, "yyyy - MMMM");

			// Load each dream
			foreach (string strDreamFile in Directory.GetFiles(Folder, "*.ld3")) {
				XmlDocument xmlDream = new XmlDocument();
				int intLucidity = 1;
				xmlDream.Load(strDreamFile);
				lstItem = new ListViewItem(xmlDream.DocumentElement.SelectSingleNode("Date").InnerText);
				lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText);
				lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText);

				lstItem.Tag = strDreamFile;
				lstDreams.Items.Add(lstItem);
				if (lstItem.SubItems[2].Text > intLongestDream) {
					intLongestDream = lstItem.SubItems[2].Text;
				}

				if (lstItem.SubItems[2].Text * intLucidity > intMostLucidDream) {
					intMostLucidDream = lstItem.SubItems[2].Text * intLucidity;
					strMostLucidDream = lstItem.Text + " - " + lstItem.SubItems[1].Text;
				}
			}

			int intDayCountOutside = 0;


			do {
				intDayCountOutside += 1;

				int intDayCount = 0;

				foreach (ListViewItem lstItem_loopVariable in lstDreams.Items) {
					lstItem = lstItem_loopVariable;
					if (lstItem.Text == dtMonth) {
						intDayCount += 1;

						Series objSeriesN = graph.Series.Add("Day" + intDayCountOutside + "." + intDayCount);
						objSeriesN.ChartType = SeriesChartType.StackedColumn;
						objSeriesN.Color = Color.FromArgb(200, 65, 140, 240);
						objSeriesN.BorderWidth = 1;
						DateTime dtMonth2 = new DateTime(Year, Month, 1);

						do {
							if (lstItem.Text == dtMonth2) {
								intPoint = objSeriesN.Points.AddY(lstItem.SubItems[2].Text);
								objSeriesN.Points[intPoint].ToolTip = Strings.Format(dtMonth2, "dd") + " " + lstItem.SubItems[1].Text;
								objSeriesN.Points[intPoint].Tag = dtMonth2.Day;
							} else {
								objSeriesN.Points.AddY(0);
							}

							dtMonth2 = dtMonth2.AddDays(1);
						} while (!(dtMonth2.Month != Month));

					}
				}

				dtMonth = dtMonth.AddDays(1);
				intPos = intPos + 1;
			} while (!(dtMonth.Month != Month));

			Series objSleepSeries = graph.Series.Add("Sleep");
			objSleepSeries.ChartType = SeriesChartType.SplineRange;
			objSleepSeries.Color = Color.FromArgb(100, 65, 240, 40);
			objSleepSeries.YAxisType = AxisType.Secondary;

			Series objDreamSeries = graph.Series.Add("DreamTime");
			objDreamSeries.ChartType = SeriesChartType.Spline;
			objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240);
			//Color.FromArgb(128, Color.LightSteelBlue.R, Color.LightSteelBlue.G, Color.LightSteelBlue.B)
			objDreamSeries.YAxisType = AxisType.Secondary;

			dtMonth = new DateTime(Year, Month, 1);
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				HitTestResult result = graph.HitTest(e.X, e.Y);

				// Reset Data Point Attributes
				DataPoint point = null;
				foreach (Series objSeries_loopVariable in graph.Series) {
					objSeries = objSeries_loopVariable;
					if (objSeries.Name.StartsWith("Day")) {
						foreach (DataPoint point_loopVariable in objSeries.Points) {
							point = point_loopVariable;
							point.Color = Color.FromArgb(200, 65, 140, 240);
						}
					}
				}


				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {

					if (result.Series.Name.StartsWith("Day")) {
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
					if (result.Series.Name.StartsWith("Day")) {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = result.Series.Points[result.PointIndex];
						if (DreamSelected != null) {
							DreamSelected(point.ToolTip);
						}
					}
				} else {
					if (result.ChartElementType == ChartElementType.Annotation) {
						point = result.Object.AnchorDataPoint;
						if (DreamSelected != null) {
							DreamSelected(point.ToolTip);
						}
					}
				}
			}
		}
		public MemClearControl()
		{
			InitializeComponent();
		}
	}
}
