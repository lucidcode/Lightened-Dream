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

	public partial class CategoryListControl
	{

		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private string m_strFileName;
		public string Category;

		public string CategoryFile;
		public event CategorySelectedEventHandler CategorySelected;
		public delegate void CategorySelectedEventHandler(string Entry);

		public void LoadCategory()
		{
			try {
				graph.ChartAreas[0].BackColor = this.BackColor;

				lblT.Visible = true;
				txtName.Visible = true;
				txtName.Text = Category;

				Series objSeries = graph.Series["DreamSeries"];
				objSeries.Points.Clear();
				objSeries["PieDrawingStyle"] = "SoftEdge";
				lstCategories.Items.Clear();
				lblTitle.Text = "Categories - " + Category;

				bool hasData = false;

				Series objDozenSeries = graphDozen.Series["DreamSeries"];
				objDozenSeries.Color = Color.FromArgb(200, 65, 140, 240);
				objDozenSeries.BorderWidth = 1;
				objSeries["BarLabelStyle"] = "Right";
				objDozenSeries.Points.Clear();

				int total = 0;

				foreach (string strCatgeoryFolder in Directory.GetDirectories(CategoryFile)) {
					int intCount = 0;
					foreach (string strCatgeoryFile in Directory.GetFiles(strCatgeoryFolder, "*.ld3", SearchOption.AllDirectories)) {
						System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
						xmlDoc.Load(strCatgeoryFile);

						intCount += xmlDoc.DocumentElement.SelectNodes("//Dream").Count;
					}

					ListViewItem lstItem = new ListViewItem(new DirectoryInfo(strCatgeoryFolder).Name);
					lstItem.SubItems.Add(intCount.ToString());
					lstCategories.Items.Add(lstItem);

					if (intCount > 0) {
						int intPoint = objSeries.Points.AddY(intCount);
						objSeries.Points[intPoint].Label = lstItem.Text;
						hasData = true;

						int intPointDozen = objDozenSeries.Points.AddY(intCount);
						objDozenSeries.Points[intPointDozen].Label = " " + new DirectoryInfo(strCatgeoryFolder).Name;
						total += 1;
					}
				}

				foreach (string strCatgeoryFile in Directory.GetFiles(CategoryFile, "*.ld3")) {
					System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
					xmlDoc.Load(strCatgeoryFile);

					int intCount = xmlDoc.DocumentElement.SelectNodes("//Dream").Count;

					ListViewItem lstItem = new ListViewItem(new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
					lstItem.SubItems.Add(intCount.ToString());;
					lstCategories.Items.Add(lstItem);

					if (intCount > 0) {
						int intPoint = objSeries.Points.AddY(intCount);
						objSeries.Points[intPoint].Label = lstItem.Text;
						hasData = true;

						int intPointDozen = objDozenSeries.Points.AddY(intCount);
						objDozenSeries.Points[intPointDozen].Label = " " + new FileInfo(strCatgeoryFile).Name.Replace(".ld3", "");
						total += 1;
					}
				}

				graph.Visible = hasData;

				if (total > 12) {
					graphDozen.Visible = true;
				} else {
					graphDozen.Visible = false;
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Categories.LoadCategory()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save()
		{
			if (txtName.Text != Category) {
				Directory.Move(CategoryFile, new DirectoryInfo(CategoryFile).Parent.FullName + "\\" + txtName.Text);
				CategoryFile = new DirectoryInfo(CategoryFile).Parent.FullName + "\\" + txtName.Text;
				Category = txtName.Text;
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
			}

			if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
				// Set cursor type 
				this.Cursor = Cursors.Hand;

				// Find selected data point
				point = graph.Series[0].Points[result.PointIndex];
				point["PieDrawingStyle"] = "Concave";
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
	}
}
