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
namespace lucidcode.LightenedDream.Categories
{

	public partial class CategoriesListControl
	{

		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";

		private string m_strFileName;
		public event CategorySelectedEventHandler CategorySelected;
		public delegate void CategorySelectedEventHandler(string Category);

		public void LoadCategories()
		{
			try {
				graph.ChartAreas[0].BackColor = this.BackColor;

				Series objSeries = graph.Series["DreamSeries"];
				objSeries.Points.Clear();
				objSeries["PieDrawingStyle"] = "SoftEdge";
				lstCategories.Items.Clear();

				Series objDozenSeries = graphDozen.Series["DreamSeries"];
				objDozenSeries.Color = Color.FromArgb(200, 65, 140, 240);
				objDozenSeries.BorderWidth = 1;
				objSeries["BarLabelStyle"] = "Right";
				objDozenSeries.Points.Clear();

				int total = 0;

				foreach (string categoryPath in Directory.GetDirectories(m_strPath + "Categories")) {
					int intCount = 0;
					foreach (string categoryFile in Directory.GetFiles(categoryPath, "*.ld3", SearchOption.AllDirectories)) {
						System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
						xmlDoc.Load(categoryFile);
						intCount += xmlDoc.DocumentElement.SelectNodes("//Dream").Count;
					}

					ListViewItem lstItem = new ListViewItem(new FileInfo(categoryPath).Name);
					lstItem.SubItems.Add(intCount.ToString());
					lstCategories.Items.Add(lstItem);

					if (intCount > 0) {
						int intPoint = objSeries.Points.AddY(intCount);
						objSeries.Points[intPoint].Label = new FileInfo(categoryPath).Name;

						int intPointDozen = objDozenSeries.Points.AddY(intCount);
						objDozenSeries.Points[intPointDozen].Label = " " + new FileInfo(categoryPath).Name;
						total += 1;
					}
				}

				if (total > 12) {
					graphDozen.Visible = true;
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			HitTestResult result = graph.HitTest(e.X, e.Y);

			// Reset Data Point Attributes
			DataPoint point = null;
			foreach (DataPoint point_loopVariable in graph.Series[0].Points) {
				point = point_loopVariable;
				point["PieDrawingStyle"] = "SoftEdge";
				//point("Exploded") = "False"
			}

			if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
				// Set cursor type 
				this.Cursor = Cursors.Hand;

				// Find selected data point
				point = graph.Series[0].Points[result.PointIndex];
				point["PieDrawingStyle"] = "Concave";
				//point("Exploded") = "True"
			} else {
				// Set default cursor
				this.Cursor = Cursors.Default;
			}
		}

		private void graph_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				HitTestResult result = graph.HitTest(e.X, e.Y);
				DataPoint point = null;
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					// Set cursor type 
					this.Cursor = Cursors.Hand;

					// Find selected data point
					point = graph.Series[0].Points[result.PointIndex];
					if (CategorySelected != null) {
						CategorySelected(point.Label);
					}
				}
			}
		}

		private void graphDozen_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				HitTestResult result = graphDozen.HitTest(e.X, e.Y);
				DataPoint point = null;
				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
					// Set cursor type 
					this.Cursor = Cursors.Hand;

					// Find selected data point
					point = graphDozen.Series[0].Points[result.PointIndex];
					if (CategorySelected != null) {
						CategorySelected(point.Label.Trim(' '));
					}
				}
			}
		}

		private void graphDozen_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			HitTestResult result = graphDozen.HitTest(e.X, e.Y);

			// Reset Data Point Attributes
			DataPoint point = null;
			foreach (Series objSeries in graphDozen.Series) {
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
		}
		public CategoriesListControl()
		{
			InitializeComponent();
		}
	}
}
