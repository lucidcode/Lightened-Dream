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

	public partial class YearListControl
	{

		public event MonthSelectedEventHandler MonthSelected;
		public delegate void MonthSelectedEventHandler(string Month);

		public void LoadYear(string Folder, string Year)
		{
			double intPos = 0.5;
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();
			lstDreams.Items.Clear();

			DateTime dtYear = new DateTime(Year, 1, 1);
			int currentMonth = 0;


			lblTitle.Text = "Lucidity - Exercises - " + Year;
			Series objSeries = graph.Series.Add("Year");
			objSeries.ChartType = SeriesChartType.Column;

			//objSeries.BorderDashStyle = ChartDashStyle.Solid
			objSeries.Color = Color.FromArgb(200, 65, 140, 240);
			objSeries.BorderWidth = 1;
			objSeries["BarLabelStyle"] = "Center";



			foreach (string strMonthFolder in Directory.GetDirectories(Folder)) {
				objSeries.Points.AddY(0);
				objSeries.Points[objSeries.Points.Count - 1].ToolTip = new DirectoryInfo(strMonthFolder).Name;

				graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos, intPos + 1, new DirectoryInfo(strMonthFolder).Name);
				intPos += 1;

				foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
					objSeries.Points[objSeries.Points.Count - 1].YValues[0] += 1;
				}
				Application.DoEvents();
			}

			return;


		}


		private void tbcMain_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
		}


		private void lstCategories_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				HitTestResult result = graph.HitTest(e.X, e.Y);

				// Reset Data Point Attributes
				DataPoint point = null;
				foreach (DataPoint point_loopVariable in graph.Series["Year"].Points) {
					point = point_loopVariable;
					point.Color = Color.FromArgb(200, 65, 140, 240);
				}

				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {

					if (result.Series.Name == "Year") {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = graph.Series["Year"].Points[result.PointIndex];
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

		private void graph_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				HitTestResult result = graph.HitTest(e.X, e.Y);
				DataPoint point = null;
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					if (result.Series.Name == "Year") {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = graph.Series["Year"].Points[result.PointIndex];
						if (MonthSelected != null) {
							MonthSelected(point.ToolTip);
						}
					}
				}
			}
		}
	}
}
