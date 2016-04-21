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
using System.Windows.Forms.DataVisualization;
using System.Drawing.Drawing2D;
namespace lucidcode.LightenedDream.Dreams
{

	public partial class MonthListControl
	{

		public event DreamSelectedEventHandler DreamSelected;
		public delegate void DreamSelectedEventHandler(string Dream);

		public void LoadMonth(string Folder, string Year, string Month)
		{
			double intPos = 0.5;
			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();
			graph.ResetAutoValues();
			graph.Annotations.Clear();

			lstDreams.Items.Clear();

			DateTime dtMonth = new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), 1);

			int intPoint = 0;
			ListViewItem lstItem = null;
			int intLongestDream = 0;

			int intMostLucidDream = 0;

			string strMostLucidDream = "";

			lblTitle.Text = "Dreams - " + Strings.Format(dtMonth, "yyyy - MMMM");

			// Load each dream
			foreach (string strDreamFile in Directory.GetFiles(Folder, "*.ld3")) {
				XmlDocument xmlDream = new XmlDocument();
				int intLucidity = 1;
				xmlDream.Load(strDreamFile);
				lstItem = new ListViewItem(xmlDream.DocumentElement.SelectSingleNode("Date").InnerText);
				lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Title").InnerText);
				lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.Split(' ').Length.ToString());
				if (xmlDream.DocumentElement.SelectSingleNode("Sleep") != null) {
					//If xmlDream.DocumentElement.SelectSingleNode("Sleep").InnerText = xmlDream.DocumentElement.SelectSingleNode("Awake").InnerText Then
					//  lstItem.SubItems.Add("23:30")
					//  lstItem.SubItems.Add("06:30")
					//Else
					lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Sleep").InnerText);
					lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Awake").InnerText);
					//End If

					lstItem.SubItems.Add(xmlDream.DocumentElement.SelectSingleNode("Time").InnerText);
				}

				if (xmlDream.DocumentElement.SelectSingleNode("Lucidity") != null) {
					intLucidity = Convert.ToInt32(xmlDream.DocumentElement.SelectSingleNode("Lucidity").InnerText);
				}

				lstItem.Tag = strDreamFile;
				lstDreams.Items.Add(lstItem);
        if (Convert.ToInt32(lstItem.SubItems[2].Text) > intLongestDream)
        {
					intLongestDream = Convert.ToInt32(lstItem.SubItems[2].Text);
				}

				if (Convert.ToInt32(lstItem.SubItems[2].Text) * intLucidity > intMostLucidDream) {
					intMostLucidDream = Convert.ToInt32(lstItem.SubItems[2].Text) * intLucidity;
					strMostLucidDream = lstItem.Text + " - " + lstItem.SubItems[1].Text;
				}
			}

			Series objMoonSeries = graph.Series.Add("Moon");
			objMoonSeries.ChartType = SeriesChartType.SplineArea;
			objMoonSeries.Color = Color.WhiteSmoke;
			graph.ApplyPaletteColors();

			AnnotationGroup star = new AnnotationGroup();
			star.Width = 15;
			star.Height = 15;
			star.AllowSelecting = true;
			star.AllowResizing = true;

			graph.Annotations.Add(star);

			PointF[] starPolygon = new PointF[] {
				new PointF(1, 6),
				new PointF(27, 23),
				new PointF(33, 5),
				new PointF(44, 22),
				new PointF(58, 0),
				new PointF(57, 19),
				new PointF(75, 11),
				new PointF(70, 28),
				new PointF(100, 37),
				new PointF(81, 53),
				new PointF(99, 65),
				new PointF(75, 67),
				new PointF(87, 98),
				new PointF(63, 69),
				new PointF(60, 94),
				new PointF(47, 69),
				new PointF(34, 100),
				new PointF(32, 69),
				new PointF(23, 74),
				new PointF(26, 61),
				new PointF(4, 72),
				new PointF(22, 49),
				new PointF(0, 39),
				new PointF(23, 32),
				new PointF(1, 6)
			};

			GraphicsPath starPath = new GraphicsPath();

			starPath.AddPolygon(starPolygon);
			PolygonAnnotation poly = new PolygonAnnotation();
			poly.Name = "Star";
			poly.GraphicsPath = starPath;
			star.Annotations.Add(poly);

			// Set star polygon annotation position and appearance
			star.Annotations["Star"].X = 0;
			star.Annotations["Star"].Y = 0;
			star.Annotations["Star"].Width = 100;
			star.Annotations["Star"].Height = 100;
			star.Annotations["Star"].LineColor = System.Drawing.Color.LightSteelBlue;
			star.Annotations["Star"].BackColor = Color.White;
			star.Annotations["Star"].ShadowColor = System.Drawing.Color.SteelBlue;
			star.Annotations["Star"].ShadowOffset = 1;

			// Add text in the middle of the star shape
			TextAnnotation textAnnotation = new TextAnnotation();
			textAnnotation.Name = "StarText";
			textAnnotation.Text = "Lucid";
			textAnnotation.X = 20;
			textAnnotation.Y = 15;
			textAnnotation.Width = 60;
			textAnnotation.Height = 60;
			textAnnotation.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			textAnnotation.ForeColor = System.Drawing.Color.SteelBlue;
			star.Annotations.Add(textAnnotation);

			int intDayCountOutside = 0;


			do {
				intDayCountOutside += 1;

				int intDayCount = 0;

				foreach (ListViewItem lstItem_loopVariable in lstDreams.Items) {
					lstItem = lstItem_loopVariable;
					if (lstItem.Text == dtMonth.ToString()) {
						intDayCount += 1;

						Series objSeriesN = graph.Series.Add("Day" + intDayCountOutside + "." + intDayCount);
						objSeriesN.ChartType = SeriesChartType.StackedColumn;
						objSeriesN.Color = Color.FromArgb(200, 65, 140, 240);
						objSeriesN.BorderWidth = 1;
						DateTime dtMonth2 = new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), 1);

						do {

              if (lstItem.Text == dtMonth2.ToString())
              {
								intPoint = objSeriesN.Points.AddY(lstItem.SubItems[2].Text);
								objSeriesN.Points[intPoint].ToolTip = Strings.Format(dtMonth2, "dd") + " " + lstItem.SubItems[1].Text;
								objSeriesN.Points[intPoint].Tag = dtMonth2.Day;


								if (strMostLucidDream == lstItem.Text + " - " + lstItem.SubItems[1].Text) {
									star.AnchorDataPoint = objSeriesN.Points[intPoint];
									star.AnchorAlignment = ContentAlignment.BottomCenter;
									textAnnotation.Text = lstItem.SubItems[1].Text;
									star.Tag = Strings.Format(dtMonth2, "dd") + " " + lstItem.SubItems[1].Text;


								} else {
									System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
									//objCalloutCloud.ClipToChartArea = "ChartArea1"
									//              objCalloutCloud.BackColor = Color.WhiteSmoke  'Color.FromArgb(0, 0, 0, 0)
									//              objCalloutCloud.BackColor = Color.FromArgb(0, 0, 0, 0)
									objCalloutCloud.AllowSelecting = true;
									objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
									objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
									objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
									objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
									objCalloutCloud.Name = Guid.NewGuid().ToString();
									objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
									//              objCalloutCloud.ShadowColor = Color.FromArgb(0, 0, 0, 0) ' System.Drawing.Color.
									objCalloutCloud.ShadowOffset = 1;
									objCalloutCloud.Text = lstItem.SubItems[1].Text;
									objCalloutCloud.Tag = Strings.Format(dtMonth2, "dd") + " " + lstItem.SubItems[1].Text;
									objCalloutCloud.AnchorAlignment = ContentAlignment.BottomCenter;
									objCalloutCloud.AnchorDataPoint = objSeriesN.Points[intPoint];
									this.graph.Annotations.Add(objCalloutCloud);

								}

							} else {
								objSeriesN.Points.AddY(0);
							}

							dtMonth2 = dtMonth2.AddDays(1);
            } while (!(dtMonth2.Month.ToString() != Month));

					}
				}

				dtMonth = dtMonth.AddDays(1);
				intPos = intPos + 1;
			} while (!(dtMonth.Month.ToString() != Month));

			Series objSleepSeries = graph.Series.Add("Sleep");
			objSleepSeries.ChartType = SeriesChartType.SplineRange;
			objSleepSeries.Color = Color.FromArgb(100, 65, 240, 40);
			objSleepSeries.YAxisType = AxisType.Secondary;

			Series objDreamSeries = graph.Series.Add("DreamTime");
			objDreamSeries.ChartType = SeriesChartType.Spline;
			objDreamSeries.Color = Color.FromArgb(200, 65, 140, 240);
			//Color.FromArgb(128, Color.LightSteelBlue.R, Color.LightSteelBlue.G, Color.LightSteelBlue.B)
			objDreamSeries.YAxisType = AxisType.Secondary;

			dtMonth = new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), 1);

			double[] dblLastVals = null;
			//objSleepSeries.Points.Add(New Double() {100, 50})
			dblLastVals = new double[] {
				100,
				50
			};

			bool boolFirstDream = true;
			int intMissedDreamTimes = 1;
			int intPointDream = 0;

			do {
				int intValue = 0;
				bool boolFound = false;

				foreach (ListViewItem lstItem_loopVariable in lstDreams.Items) {
					lstItem = lstItem_loopVariable;
					if (lstItem.Text == dtMonth.ToString()) {
						intValue += Convert.ToInt32(lstItem.SubItems[2].Text);
					}
				}

				foreach (ListViewItem lstItem_loopVariable in lstDreams.Items) {
					lstItem = lstItem_loopVariable;
					if (lstItem.Text == dtMonth.ToString()) {
						boolFound = true;
						break; // TODO: might not be correct. Was : Exit For
					}
				}


				if (boolFound) {
					string[] arrSleep = lstItem.SubItems[3].Text.Split(':');
					string[] arrAwake = lstItem.SubItems[4].Text.Split(':');
					string[] arrDream = lstItem.SubItems[5].Text.Split(':');

          DateTime dtSleep = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(arrSleep[0]), Convert.ToInt32(arrSleep[1]), 0);
          DateTime dtAwake = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(arrAwake[0]), Convert.ToInt32(arrAwake[1]), 0);
          DateTime dtDream = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(arrDream[0]), Convert.ToInt32(arrDream[1]), 0);

					int intPointA = (dtSleep.Hour * 100) + dtSleep.Minute;
					int intPointB = (dtAwake.Hour * 100) + dtAwake.Minute;
					intPointDream = (dtDream.Hour * 100) + dtDream.Minute;

					if (intPointA > 1200) {
						intPointA = intPointA - 2400;
					}

					if (intPointB > 1200) {
						intPointB = intPointB - 2400;
					}

					if (intPointDream > 1200) {
						intPointDream = intPointDream - 2400;
					}

					if (intPointA == intPointB) {
						intPointA -= 1;
					}

					if (intPointA > intPointB) {
						int intTemp = intPointA;
						intPointA = intPointB;
						intPointB = intTemp;
					}

					objSleepSeries.Points.Add(new double[] {
						intPointB,
						intPointA
					});
					objDreamSeries.Points.Add(intPointDream);

					dblLastVals = new double[] {
						intPointB,
						intPointA
					};

					if (boolFirstDream) {
						boolFirstDream = false;
						for (int i = 0; i <= intMissedDreamTimes - 1; i++) {
							objSleepSeries.Points.Add(new double[] {
								intPointB,
								intPointA
							});
							objDreamSeries.Points.Add(intPointDream);
						}
					}

					//Dim boolOverlap As Boolean = False
					//If dtSleep > dtAwake Then
					//  dtSleep = dtSleep.AddDays(-1)
					//  boolOverlap = True
					//End If

					//Dim dtTime As TimeSpan = dtAwake.Subtract(dtSleep)

					//Dim intPointA As Integer = (intLongestDream / 1440) * (12 * 60) / 2

					//If boolOverlap Then
					//  intPointA += (intLongestDream / 1440) * (((24 - dtSleep.Hour) * 60) + dtSleep.Minute) / 2
					//Else
					//  intPointA += (intLongestDream / 1440) * (((dtSleep.Hour) * 60) + dtSleep.Minute) / 2
					//End If

					//Dim intPointB As Integer = intPointA + ((intLongestDream / 1440) * (dtTime.TotalMinutes)) / 2
					//If intPointA > intPointB Then
					//  objSleepSeries.Points.Add(New Double() {intPointA + 2, intPointB})
					//  dblLastVals = New Double() {intPointA + 2, intPointB}
					//Else
					//  objSleepSeries.Points.Add(New Double() {intPointB + 2, intPointA})
					//  dblLastVals = New Double() {intPointB + 2, intPointA}
					//End If

				} else {
					if (boolFirstDream) {
						intMissedDreamTimes += 1;
					} else {
						objSleepSeries.Points.Add(dblLastVals);
						objDreamSeries.Points.Add(intPointDream);
					}

					//Dim intPointA As Integer = (intLongestDream / 1440) * (12 * 60) / 2
					//Dim intPointB As Integer = intPointA
					//If dblLastVals Is Nothing Then
					//  dblLastVals = New Double() {intPointB + 2, intPointA}
					//End If
					//objSleepSeries.Points.Add(dblLastVals)
				}

				int intMoonAge = MoonAge(dtMonth.Year, dtMonth.Month, dtMonth.Day);
				objMoonSeries.Points.AddY((intLongestDream / 14) * intMoonAge);

				dtMonth = dtMonth.AddDays(1);
				intPos = intPos + 1;
			} while (!(dtMonth.Month.ToString() != Month));

		}

    private int MoonAge(int Year, int Month, int Day)
		{
      double strmonth = 0;
      double strday = 0;
      double stryear = 0;
      double yy = 0;
      double y = 0;
      double m = 0;
      double d = 0;
      double p2 = 0;
			double mm = 0;
      double k1 = 0;
      double k2 = 0;
      double k3 = 0;
      double j = 0;
      double v = 0;
      double ip = 0;
      int ag = 0;

			strmonth = Month;
			strday = Day;
			stryear = Year;

			y = stryear;
			m = strmonth;
			d = strday;
			p2 = 2 * 3.14159;

			yy = y - Conversion.Int((12 - m) / 10);
			mm = m + 9;
			if (mm >= 12) {
				mm = mm - 12;
			}
			k1 = Conversion.Int(365.25 * (yy + 4712));
			k2 = Conversion.Int(30.6 * mm + 0.5);
			k3 = Conversion.Int(Conversion.Int((yy / 100) + 49) * 0.75) - 38;

			// JD for dates in Julian calendar
			j = k1 + k2 + d + 59;
			if (j > 2299160) {
				// For Gregorian calendar
				j = j - k3;
			}

			// J is the Julian date at 12h UT on day in question

			// Calculate illumination (synodic) phase
			v = (j - 2451550.1) / 29.530588853;
			v = v - Conversion.Int(v);
			if (v < 0) {
				v = v + 1;
			}
			ip = v;

			// Moon's age in days
			ag = Convert.ToInt32(ip * 29.53);

			//' phases from
			//phase = Array("new", "waxing crescent", "in its first quarter", _
			//"waxing gibbous", "full", "waning gibbous", _
			//"in its last quarter", "waning crescent")
			switch (ag) {
				case 0:
				case 29:
					return 0;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					return Conversion.Int(ag);
				case 7:
					return Conversion.Int(ag);
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
					return Conversion.Int(ag);
				case 14:
					return 14;
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
					return 14 - (Conversion.Int(ag) - 14);
				case 22:
					return 14 - (Conversion.Int(ag) - 14);
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
					return 14 - (Conversion.Int(ag) - 14);
			}

			if (Conversion.Int(ag) == 29)
				return 0;
			return Convert.ToInt32(ag);
		}

		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try {
				HitTestResult result = graph.HitTest(e.X, e.Y);

				// Reset Data Point Attributes
				DataPoint point = null;
				foreach (Series objSeries in graph.Series) {
					if (objSeries.Name.StartsWith("Day")) {
						foreach (DataPoint point_loopVariable in objSeries.Points) {
							point = point_loopVariable;
							point.Color = Color.FromArgb(200, 65, 140, 240);
						}
					}
				}
				//For Each point In graph.Series("Sleep").Points
				//  point.Color = Color.FromArgb(100, 65, 240, 40)
				//Next
				foreach (DataPoint point_loopVariable in graph.Series["DreamTime"].Points) {
					point = point_loopVariable;
					point.Color = Color.FromArgb(200, 65, 140, 240);
				}

				foreach (Annotation objAnnotation in graph.Annotations) {
					objAnnotation.BackColor = Color.White;
					objAnnotation.ForeColor = Color.SteelBlue;
				}



				if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {

					if (result.Series.Name.StartsWith("Day")) {
						// Set cursor type 
						this.Cursor = Cursors.Hand;

						// Find selected data point
						point = result.Series.Points[result.PointIndex];
						point.Color = Color.FromArgb(255, 65, 140, 240);
						// Color.LightSteelBlue

						//graph.Series("Sleep").Points(result.PointIndex + 1).Color = Color.FromArgb(200, 65, 240, 40)
						graph.Series["DreamTime"].Points[result.PointIndex + 1].Color = Color.FromArgb(255, 65, 140, 240);

						foreach (Annotation objAnnotation in graph.Annotations) {
							if (object.ReferenceEquals(objAnnotation.AnchorDataPoint, point)) {
								objAnnotation.BackColor = Color.FromArgb(200, 65, 140, 240);
								objAnnotation.ForeColor = Color.White;
							}
						}


					} else if (result.Series.Name.StartsWith("Sleep")) {
						//' Set cursor type 
						//Me.Cursor = Cursors.Hand

						//' Find selected data point
						//point = result.Series.Points(result.PointIndex)
						//point.Color = Color.FromArgb(200, 65, 240, 40) ' Color.LightSteelBlue



					} else {
						// Set default cursor
						this.Cursor = Cursors.Default;
					}
				} else {

					if (result.ChartElementType == ChartElementType.Annotation) {
						this.Cursor = Cursors.Hand;


						point = result.Object.AnchorDataPoint;
						point.Color = Color.FromArgb(255, 65, 140, 240);
						// Color.LightSteelBlue

						//graph.Series("Sleep").Points(point.Tag).Color = Color.FromArgb(200, 65, 240, 40)
						graph.Series["DreamTime"].Points[Convert.ToInt32(point.Tag)].Color = Color.FromArgb(255, 65, 140, 240);

						((Annotation)result.Object).BackColor = Color.FromArgb(200, 65, 140, 240);
						((Annotation)result.Object).ForeColor = Color.White;
					} else {
						// Set default cursor
						this.Cursor = Cursors.Default;
					}
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
	}
}
