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
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class REMCyclesControl
	{

		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		public string FileName;
		private DateTime m_dtStartTime;
		private int m_intLastMinute = -1;

		private System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation m_objNow = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
		public bool Changed = false;
		private SpeedReadingForm m_formSpeedReading;

		private System.Speech.Synthesis.SpeechSynthesizer m_objSpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
		private void REMCyclesControl_Load(object sender, System.EventArgs e)
		{
		}

		public string CreateNew()
		{

			try {
				string strTitle = "New REM Cycle";
				string strFileName = null;
				strFileName = m_strPath + "\\Lucidity\\REM Cycles\\" + strTitle + ".ld3";

				int intPos = 2;
				do {
					if ((File.Exists(strFileName))) {
						strTitle = "New " + "REM Cycle" + " " + intPos.ToString();
						strFileName = m_strPath + "\\Lucidity\\REM Cycles\\" + strTitle + ".ld3";
						intPos += 1;
					} else {
						break; // TODO: might not be correct. Was : Exit Do
					}
				} while (true);

				string strXml = null;
				strXml = "<REM>";
				strXml += "<Title>" + strTitle + "</Title>";
				strXml += "<Description></Description>";
				strXml += "<Cycles>6</Cycles>";
				strXml += "<CyclesLength>90</CyclesLength>";
				strXml += "</REM>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);
				xmlDoc.Save(strFileName);

				return strFileName;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Create()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void Save()
		{

			try {
				string strFileName = null;
				strFileName = m_strPath + "Lucidity\\REM Cycles\\" + txtTitle.Text + ".ld3";
				if ((FileName != strFileName)) {
					File.Move(FileName, strFileName);
					FileName = strFileName;
				}

				lblTitle.Text = "Lucidity - REM Cycles - " + txtTitle.Text;

				XmlWriter textWriter = new XmlTextWriter(strFileName + ".tmp", null);
				textWriter.WriteStartElement("REM");

				textWriter.WriteStartElement("Title");
				textWriter.WriteString(txtTitle.Text);
				textWriter.WriteEndElement();

				textWriter.WriteStartElement("Description");
				textWriter.WriteString(txtDescription.Text);
				textWriter.WriteEndElement();

				textWriter.WriteStartElement("Cycles");
				textWriter.WriteString(cmbCycles.Text);
				textWriter.WriteEndElement();

				textWriter.WriteStartElement("CyclesLength");
				textWriter.WriteString(cmbCycleLength.Text);
				textWriter.WriteEndElement();

				textWriter.WriteStartElement("Items");
				foreach (Annotation objAnnotation in graph.Annotations) {
					if (objAnnotation is CalloutAnnotation) {
						textWriter.WriteStartElement("Item");
						textWriter.WriteAttributeString("Position", objAnnotation.AnchorDataPoint.ToolTip);


						if (objAnnotation.Tag.ToString().StartsWith("MP3::")) {
							textWriter.WriteAttributeString("Name", new FileInfo(objAnnotation.Tag.ToString().Replace("MP3::", "")).Name);
							textWriter.WriteAttributeString("Path", objAnnotation.Tag.ToString().Replace("MP3::", ""));

						} else if (objAnnotation.Tag.ToString().StartsWith("MEM::MP3::")) {
							// Read the item from the loaded xml doc
							XmlReader reader = XmlReader.Create(strFileName);
							bool boolFound = false;

							do {
								boolFound = reader.ReadToFollowing("Item");

								if (boolFound) {
									if (objAnnotation.Tag.ToString().Replace("MEM::MP3::", "") == reader.GetAttribute("Name")) {
										reader.Read();
										if (string.IsNullOrEmpty(reader.Name())) {
											reader.Read();
										}
										break; // TODO: might not be correct. Was : Exit Do
									}

								} else {
									break; // TODO: might not be correct. Was : Exit Do
								}
							} while (true);
							textWriter.WriteAttributeString("Name", objAnnotation.Tag.ToString().Replace("MEM::MP3::", ""));

							// Insert loaded xml doc item into REM
							textWriter.WriteNode(reader, true);
							textWriter.Flush();
							reader.Close();

						} else if (objAnnotation.Tag.ToString().StartsWith("MEM::")) {
							// Read the item from the loaded xml doc
							XmlReader reader = XmlReader.Create(strFileName);
							bool boolFound = false;

							do {
								boolFound = reader.ReadToFollowing("Item");

								if (boolFound) {
									//reader.ReadString()
									if (objAnnotation.Tag.ToString().Replace("MEM::", "") == reader.GetAttribute("Name")) {
										reader.Read();
										if (string.IsNullOrEmpty(reader.Name())) {
											reader.Read();
										}
										//reader.ReadToDescendant()
										break; // TODO: might not be correct. Was : Exit Do
									}

								} else {
									break; // TODO: might not be correct. Was : Exit Do
								}
							} while (true);
							//boolFound = reader.ReadToFollowing("@Name='" + objAnnotation.Tag.ToString.Replace("MEM::", "") + "'")

							textWriter.WriteAttributeString("Name", objAnnotation.Tag.ToString().Replace("MEM::", ""));

							// Insert loaded xml doc item into REM
							textWriter.WriteNode(reader, true);
							textWriter.Flush();
							reader.Close();
						} else {
							if (objAnnotation.Tag.ToString().EndsWith(".ld3")) {
								// Read the original lucidity item
								XmlReader reader = XmlReader.Create(objAnnotation.Tag);
								reader.Read();

								textWriter.WriteAttributeString("Name", new FileInfo(objAnnotation.Tag).Name.Replace(".ld3", ""));

								// Insert the original lucidity item into REM
								textWriter.WriteNode(reader, true);
								textWriter.Flush();
								reader.Close();
							} else {
								// Read the sound file

								// Insert the sound file into REM
							}
						}
						textWriter.WriteEndElement();
					}
				}

				textWriter.WriteEndElement();
				textWriter.WriteEndElement();
				textWriter.Close();

				File.Delete(strFileName);
				File.Move(strFileName + ".tmp", strFileName);

				Changed = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Save()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void LoadREM(string strFileName)
		{
			try {
				if (FileName == strFileName)
					return;
				// Don't reload if it is the same file.

				Changed = false;
				tmrWatch.Enabled = false;

				FileName = strFileName;
				XmlReader reader = XmlReader.Create(FileName);
				reader.Read();

				bool boolFound = false;

				boolFound = reader.ReadToFollowing("Title");
				if (boolFound) {
					if (reader.Name != "Title")
						reader.Read();
					if (string.IsNullOrEmpty(reader.Value))
						reader.Read();
					lblTitle.Text = "Lucidity - REM Cycles - " + reader.Value;
					txtTitle.Text = reader.Value;
				}

				boolFound = reader.ReadToFollowing("Description");
				if (boolFound) {
					if (reader.Name != "Description")
						reader.Read();
					if (string.IsNullOrEmpty(reader.Value))
						reader.Read();
					txtDescription.Text = reader.Value;
				}

				// Reset to be safe of empty description node
				reader = XmlReader.Create(FileName);
				reader.Read();

				boolFound = reader.ReadToFollowing("Cycles");
				if (boolFound) {
					if (reader.Name != "Cycles")
						reader.Read();
					if (string.IsNullOrEmpty(reader.Value))
						reader.Read();
					cmbCycles.Text = reader.Value;
				}

				boolFound = reader.ReadToFollowing("CyclesLength");
				if (boolFound) {
					if (reader.Name != "CyclesLength")
						reader.Read();
					if (string.IsNullOrEmpty(reader.Value))
						reader.Read();
					cmbCycleLength.Text = reader.Value;
				}

				DrawGraph();


				this.graph.Annotations.Clear();
				int intCount = 1;
				m_objNow.LineColor = System.Drawing.Color.SteelBlue;
				m_objNow.BackColor = Color.Green;
				m_objNow.LineWidth = 4;
				m_objNow.StartCap = LineAnchorCapStyle.Arrow;
				m_objNow.EndCap = LineAnchorCapStyle.Arrow;
				m_objNow.Name = Guid.NewGuid().ToString();
				m_objNow.Visible = true;
				m_objNow.IsInfinitive = true;
				m_objNow.SetAnchor(graph.Series["REM"].Points[0], graph.Series["REM"].Points[0]);
				this.graph.Annotations.Add(m_objNow);

				m_intPoint = 0;

				lstItems.Items.Clear();

				do {
					boolFound = reader.ReadToFollowing("Item");

					if (boolFound) {
						System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
						objCalloutCloud.AllowSelecting = true;
						objCalloutCloud.AllowAnchorMoving = true;
						objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
						objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
						objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
						objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
						objCalloutCloud.Name = Guid.NewGuid().ToString();
						objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
						objCalloutCloud.ShadowOffset = 1;
						objCalloutCloud.SmartLabelStyle.Enabled = true;
						objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
						objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
						objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

						string strPosition = "";
						string strName = "";
						string strFirstChildName = "";

						boolFound = reader.MoveToAttribute("Position");
						if (boolFound) {
							strPosition = reader.Value;
						}

						boolFound = reader.MoveToAttribute("Name");
						if (boolFound) {
							strName = reader.Value;
						}

						objCalloutCloud.Text = strName + " (" + strPosition + ")";
						objCalloutCloud.ToolTip = objCalloutCloud.Text;

						boolFound = reader.MoveToAttribute("Path");
						if (boolFound) {
							strName = reader.Value;
							objCalloutCloud.Tag = "MP3::" + strName;
						} else {
							reader.Read();
							reader.Read();
							strFirstChildName = reader.Name;
							if (strFirstChildName == "FILE") {
								objCalloutCloud.Tag = "MEM::MP3::" + strName;
							// Recording
							} else {
								objCalloutCloud.Tag = "MEM::" + strName;
							}
						}
						foreach (DataPoint point in graph.Series["REM"].Points) {
							if (point.ToolTip == strPosition) {
								objCalloutCloud.AnchorDataPoint = point;
								objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter;
							}
						}
						this.graph.Annotations.Add(objCalloutCloud);
						intCount += 1;

						ListViewItem lstItem = new ListViewItem(strPosition);
						lstItem.SubItems.Add(strName);
						lstItem.SubItems.Add(strName);
						lstItem.Tag = strName;
						lstItems.Items.Add(lstItem);

					} else {
						break; // TODO: might not be correct. Was : Exit Do
					}

				} while (true);

				return;

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(FileName);
				lblTitle.Text = "Lucidity - REM Cycles - " + xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				txtTitle.Text = xmlDoc.DocumentElement.SelectSingleNode("Title").InnerText;
				txtDescription.Text = xmlDoc.DocumentElement.SelectSingleNode("Description").InnerText;
				cmbCycles.Text = xmlDoc.DocumentElement.SelectSingleNode("Cycles").InnerText;
				if ((xmlDoc.DocumentElement.SelectSingleNode("CyclesLength") != null)) {
					cmbCycleLength.Text = xmlDoc.DocumentElement.SelectSingleNode("CyclesLength").InnerText;
				} else {
					cmbCycleLength.Text = "90";
				}



				foreach (XmlNode xmlItem in xmlDoc.DocumentElement.SelectNodes("Items/Item")) {
					System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
					objCalloutCloud.AllowSelecting = true;
					objCalloutCloud.AllowAnchorMoving = true;
					objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
					objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
					objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
					objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
					objCalloutCloud.Name = Guid.NewGuid().ToString();
					objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
					objCalloutCloud.ShadowOffset = 1;
					objCalloutCloud.SmartLabelStyle.Enabled = true;
					objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
					objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
					objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
					objCalloutCloud.Text = xmlItem.Attributes["Name"].InnerText + " (" + xmlItem.Attributes["Position"].InnerText + ")";

					if ((xmlItem.Attributes["Path"] != null)) {
						objCalloutCloud.Tag = "MP3::" + xmlItem.Attributes["Path"].InnerText;
					} else {
						if (xmlItem.FirstChild.Name == "FILE") {
							objCalloutCloud.Tag = "MEM::MP3::" + xmlItem.Attributes["Name"].InnerText;
						// Recording
						} else {
							objCalloutCloud.Tag = "MEM::" + xmlItem.Attributes["Name"].InnerText;
						}
					}

					foreach (DataPoint point in graph.Series["REM"].Points) {
						if (point.ToolTip == xmlItem.Attributes["Position"].InnerText) {
							objCalloutCloud.AnchorDataPoint = point;
							objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter;
						}
					}

					this.graph.Annotations.Add(objCalloutCloud);
					intCount += 1;

					ListViewItem lstItem = new ListViewItem(xmlItem.Attributes["Position"].InnerText);
					lstItem.SubItems.Add(xmlItem.Attributes["Name"].InnerText);
					lstItem.SubItems.Add(xmlItem.Attributes["Name"].InnerText);
					lstItem.Tag = xmlItem.Attributes["Name"].InnerText;
					lstItems.Items.Add(lstItem);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public void Play()
		{
			m_intLastMinute = -1;
			m_dtStartTime = DateAndTime.Now.AddSeconds(1);
			m_objNow.SetAnchor(graph.Series["REM"].Points[0], graph.Series["REM"].Points[0]);
			tmrWatch.Enabled = true;
		}

		public void StopRunning()
		{
			m_intLastMinute = -1;
			m_dtStartTime = DateAndTime.Now.AddSeconds(1);
			m_objNow.SetAnchor(graph.Series["REM"].Points[0], graph.Series["REM"].Points[0]);
			tmrWatch.Enabled = false;
			objPlayer.close();
		}

		private void Execute(string Item)
		{

			try {
				objPlayer.close();

				// Delete old temp files
				try {
					foreach (string strFile in Directory.GetFiles(m_strPath + "\\Lucidity\\REM Cycles\\Temp", "*.*")) {
						File.Delete(strFile);
					}
				} catch (Exception ex) {
				}


				if (Item.StartsWith("Reading")) {
				} else if (Item.StartsWith("MP3::")) {
					objPlayer.close();
					Application.DoEvents();
					this.objPlayer.settings.volume = 100;
					objPlayer.URL = Item.Replace("MP3::", "");

				} else if (Item.StartsWith("MEM::MP3::")) {
					XmlReader reader = XmlReader.Create(FileName);
					bool boolFound = false;

					do {
						boolFound = reader.ReadToFollowing("Item");
						if (boolFound) {
							if (Item.ToString().Replace("MEM::MP3::", "") == reader.GetAttribute("Name")) {
								reader.Read();
								string strType = reader.Name();
								if (string.IsNullOrEmpty(strType)) {
									reader.Read();
									strType = reader.Name();
								}
								// Recording
								if (strType == "FILE") {
									objPlayer.close();
									Application.DoEvents();
									this.objPlayer.settings.volume = 100;
									FileStream fs = new FileStream(m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::MP3::", ""), FileMode.Create);

									byte[] buf = new byte[1024];
									int numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
									while ((numRead > 0)) {
										fs.Write(buf, 0, numRead);
										numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
									}

									fs.Close();
									reader.Close();

									objPlayer.URL = m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::MP3::", "");
									return;
								}
							}

						} else {
							break; // TODO: might not be correct. Was : Exit Do
						}
					} while (true);
					reader.Close();
				} else if (Item.StartsWith("MEM::")) {
					XmlReader reader = XmlReader.Create(FileName);
					bool boolFound = false;
					do {
						boolFound = reader.ReadToFollowing("Item");
						if (boolFound) {
							if (Item.ToString().Replace("MEM::", "") == reader.GetAttribute("Name")) {
								reader.Read();
								string strType = reader.Name();
								if (string.IsNullOrEmpty(strType)) {
									reader.Read();
									strType = reader.Name();
								}
								// Recording


								if (strType == "FILE") {
									objPlayer.close();
									Application.DoEvents();
									this.objPlayer.settings.volume = 100;
									FileStream fs = new FileStream(m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::", ""), FileMode.Create);

									byte[] buf = new byte[1024];
									int numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
									while ((numRead > 0)) {
										fs.Write(buf, 0, numRead);
										numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
									}

									fs.Close();
									reader.Close();
									objPlayer.URL = m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::", "");
									return;
								} else if (strType == "Recording") {

									if (reader.ReadToFollowing("Data")) {
										objPlayer.close();
										Application.DoEvents();
										this.objPlayer.settings.volume = 100;
										FileStream fs = new FileStream(m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::", "") + ".mp3", FileMode.Create);
										byte[] buf = new byte[1024];
										int numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
										while ((numRead > 0)) {
											fs.Write(buf, 0, numRead);
											numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
										}

										fs.Close();

										objPlayer.URL = m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + Item.ToString().Replace("MEM::", "") + ".mp3";

										// Speak
										if (reader.ReadToFollowing("Speech")) {
											reader.Read();
											m_objSpeechSynthesizer.SpeakAsyncCancelAll();
											m_objSpeechSynthesizer.SpeakAsync(reader.Value);
										}

										reader.Close();

										return;
									}

									// Reading

								} else if (strType == "Reading") {
									if ((m_formSpeedReading != null)) {
										m_formSpeedReading.Close();
									}

									m_formSpeedReading = new SpeedReadingForm(GetReaderValue(reader, "Interval"));
									m_formSpeedReading.BackColor = Color.FromArgb(GetReaderValue(reader, "Background"));
									m_formSpeedReading.lblText.ForeColor = Color.FromArgb(GetReaderValue(reader, "Text"));
									m_formSpeedReading.lblText.Font = new Font(m_formSpeedReading.lblText.Font.FontFamily, Convert.ToInt32(GetReaderValue(reader, "Size")), FontStyle.Regular);

									string strMessages = "";

									while (reader.ReadToFollowing("Message")) {
										reader.Read();
										strMessages += reader.Value + Constants.vbNewLine;
									}

									if (strMessages.Length > 0) {
										strMessages = strMessages.Substring(0, strMessages.Length - 1);
									}

									m_formSpeedReading.Messages = strMessages.Split(Constants.vbNewLine);
									m_formSpeedReading.Show();
									m_formSpeedReading.BringToFront();
									m_formSpeedReading.Top = 0;
									m_formSpeedReading.Left = 0;
									m_formSpeedReading.PlayLoop = false;
									m_formSpeedReading.Play();
									reader.Close();
									return;


									// Subliminal

								} else if (strType == "Subliminal") {

								}
							}

						} else {
							break; // TODO: might not be correct. Was : Exit Do
						}
					} while (true);


					reader.Close();

				} else {
					XmlReader reader = XmlReader.Create(Item);

					if (reader.ReadToFollowing("Data")) {
						objPlayer.close();
						Application.DoEvents();
						this.objPlayer.settings.volume = 100;
						FileStream fs = new FileStream(m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + new FileInfo(Item).Name.Replace(".ld3", ".mp3"), FileMode.Create);

						byte[] buf = new byte[1024];
						int numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
						while ((numRead > 0)) {
							fs.Write(buf, 0, numRead);
							numRead = reader.ReadElementContentAsBase64(buf, 0, 1024);
						}

						fs.Close();

						objPlayer.URL = m_strPath + "\\Lucidity\\REM Cycles\\Temp\\" + new FileInfo(Item).Name.Replace(".ld3", ".mp3");

						// Speak
						if (reader.ReadToFollowing("Speech")) {
							reader.Read();
							m_objSpeechSynthesizer.SpeakAsyncCancelAll();
							m_objSpeechSynthesizer.SpeakAsync(reader.Value);
						}


						reader.Close();

						return;

					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.REMCycles.Execute()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetReaderValue(XmlReader Reader, string Node)
		{
			Reader.ReadToFollowing(Node);
			Reader.Read();
			return Reader.Value;
		}

		private Int32 GetHour(string StartTime)
		{
			return Strings.Split(StartTime, ":")[0];
		}

		private Int32 GetMinute(string StartTime)
		{
			return Strings.Split(StartTime, ":")[1];
		}


		private void dtStart_ValueChanged(System.Object sender, System.EventArgs e)
		{
			//   Dim x As Microsoft.Visua

		}


		private bool m_boolUp = false;
		private void DrawGraph()
		{
			try {
				double intPos = 0.5;
				graph.ChartAreas[0].AxisX.CustomLabels.Clear();
				graph.Series.Clear();

				int intCycles = 6;
				int intLength = 6;

				try {
					if (!string.IsNullOrEmpty(cmbCycles.Text)) {
						intCycles = Convert.ToInt32(cmbCycles.Text);
					}
				} catch (Exception ex) {
				}
				try {
					if (!string.IsNullOrEmpty(cmbCycles.Text)) {
						intLength = Convert.ToInt32(cmbCycleLength.Text);
					}
				} catch (Exception ex) {
				}

				System.Windows.Forms.DataVisualization.Charting.CustomLabel objLabel = null;
				DateTime dtTime = DateTime.Now;

				Series objSeriesView = graph.Series.Add("View");
				objSeriesView.ChartType = SeriesChartType.SplineArea;

				Series objSeries = graph.Series.Add("REM");
				objSeries.ChartType = SeriesChartType.Column;
				//SeriesChartType.Column 

				objSeries.Color = Color.FromArgb(0, 65, 140, 240);
				objSeries["BarLabelStyle"] = "Center";
				objSeriesView.Color = Color.FromArgb(200, 65, 140, 240);
				objSeriesView.BorderWidth = 2;
				objSeriesView.Points.AddXY(1, intLength - (intLength / 3));

				int x = 2;
				for (int iCycle = 0; iCycle <= intCycles - 1; iCycle++) {
					if (m_boolUp) {
						m_boolUp = false;
					} else {
						m_boolUp = true;
					}

					objSeriesView.Points.AddXY(x, intLength - (intLength / 3));

					bool boolDirChanged = false;
					bool boolDirDrawn = false;


					for (int iMinute = 1; iMinute <= intLength + 1; iMinute++) {
						if (iMinute <= intLength / 2) {
							x = objSeries.Points.AddY(intLength - iMinute + 1 - (intLength / 3));
						} else {
							boolDirChanged = true;
							x = objSeries.Points.AddY(iMinute - (intLength / 3));
						}

						if (boolDirChanged) {
							if (!boolDirDrawn) {
								boolDirDrawn = true;
								objLabel = graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos - 5, intPos + 5, Strings.Format(dtTime, "HH:mm"));
								objSeriesView.Points.AddXY(x, intLength / 2 - (intLength / 3));
							}
						}


						objSeries.Points[objSeries.Points.Count - 1].ToolTip = objSeries.Points.Count - 1;
						intPos += 1;
						dtTime = dtTime.AddMinutes(1);
					}

					objLabel = graph.ChartAreas[0].AxisX.CustomLabels.Add(intPos - 5, intPos + 5, Strings.Format(dtTime, "HH:mm"));
				}


				//For intCycle As Integer = 1 To intCycles

				//  For intSubCycle As Integer = 1 To 30

				//  Next

				//  intPoint = objSeries.Points.AddY(4)
				//  intPos = intPos + 1
				//  intPoint = objSeries.Points.AddY(2)
				//  intPos = intPos + 1
				//  intPoint = objSeries.Points.AddY(6)
				//  intPos = intPos + 1
				//  intPoint = objSeries.Points.AddY(4)
				//  intPos = intPos + 1

				//  dtTime = dtTime.AddMinutes(90)

				//  intPoint = objSeries.Points.AddY(10 + intCycle)
				//  objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))
				//  intPos = intPos + 1
				//Next

				//Dim intREMLength As Integer = cmbCycleLength.Text
				//For intCycle As Integer = 1 To intCycles

				//  For intSubCycle As Integer = 1 To intREMLength
				//    dtTime = dtTime.AddMinutes(1)
				//    intPoint = objSeries.Points.AddY(12)
				//    objSeries.Points(intPoint).Tag = dtTime.ToString()
				//    objSeries.Points(intPoint).Color = Color.FromArgb(0, 0, 0, 32)
				//    intPos = intPos + 1
				//  Next
				//  'intPoint = objSeries.Points.AddY(10)

				//Next


				//For intCycle As Integer = 1 To intCycles

				//  For intSubCycle As Integer = 1 To 30
				//    intPoint = objSeries.Points.AddY(4)
				//    intPos = intPos + 1
				//    dtTime = dtTime.AddMinutes(1)
				//  Next
				//  'objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))

				//  For intSubCycle As Integer = 1 To 30
				//    intPoint = objSeries.Points.AddY(2)
				//    intPos = intPos + 1
				//    dtTime = dtTime.AddMinutes(1)
				//  Next
				//  'objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))

				//  For intSubCycle As Integer = 1 To 30
				//    intPoint = objSeries.Points.AddY(6)
				//    intPos = intPos + 1
				//    dtTime = dtTime.AddMinutes(1)
				//  Next

				//  intPoint = objSeries.Points.AddY(10 + intCycle)
				//  objLabel = graph.ChartAreas(0).AxisX.CustomLabels.Add(intPos, intPos + 1, Format(dtTime, "HH:mm"))
				//  intPos = intPos + 1
				//Next

				//LoadREM(FileName)


			} catch (Exception ex) {
			}
		}

		private void tmrWatch_Tick(System.Object sender, System.EventArgs e)
		{
			TimeSpan dtTime = DateTime.Now.Subtract(m_dtStartTime);
			int intCurrentMinute = dtTime.TotalMinutes - 0.5;
			txtTime.Text = Strings.Format(dtTime.Hours, "00") + ":" + Strings.Format(dtTime.Minutes, "00") + ":" + Strings.Format(dtTime.Seconds, "00");

			if (m_intLastMinute != Convert.ToInt32(intCurrentMinute)) {
				m_intLastMinute = intCurrentMinute;
				if (graph.Series["REM"].Points.Count - 1 >= intCurrentMinute) {
					m_objNow.SetAnchor(graph.Series["REM"].Points[intCurrentMinute], graph.Series["REM"].Points[intCurrentMinute]);
					foreach (Annotation objAnnotation in graph.Annotations) {
						if ((objAnnotation) is CalloutAnnotation) {
							if (object.ReferenceEquals(objAnnotation.AnchorDataPoint, graph.Series["REM"].Points[intCurrentMinute])) {
								objAnnotation.BackColor = Color.LightSteelBlue;
								objAnnotation.ForeColor = Color.White;
								Application.DoEvents();
								Execute(objAnnotation.Tag);
								objAnnotation.BackColor = Color.SteelBlue;
								objAnnotation.ForeColor = Color.White;
							}
						}
					}
				} else {
					tmrWatch.Enabled = false;
					return;
				}
				//graph.Series("REM").Points(dtTime.TotalMinutes - 1).Color = Color.FromArgb(0, 0, 0, 0)
				//graph.Series("REM").Points(intCurrentMinute).Color = Color.SteelBlue

			}

		}

		private void graph_AnnotationPlaced(object sender, System.EventArgs e)
		{
		}

		private PointF FindNearestDataPoint(double X, double Y)
		{
			// get the int portion of the X value
			int curIndex = Convert.ToInt32(Math.Round(X));

			// if curIndex is less than 1 curIndex is set to 1
			curIndex = Convert.ToInt32(Math.Max(curIndex, 1));

			// if curIndex is greater than 11 curIndex is set to 11 (X Value of max point in series)
			curIndex = Convert.ToInt32(Math.Min(curIndex, graph.Series["REM"].Points.Count - 5));

			// return the point value of the nearest point
			return new PointF(curIndex, Convert.ToSingle(graph.Series["REM"].Points[curIndex - 1].YValues[0]));
		}



		private Annotation m_objSelectedAnnotation;
		private void graph_AnnotationPositionChanging(System.Object sender, System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs e)
		{
			m_objSelectedAnnotation = e.Annotation;
			return;
		}

		private void graph_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				m_ptPaste = new Point(e.X, e.Y);
				HitTestResult result = graph.HitTest(e.X, e.Y);
				if (result.ChartElementType == ChartElementType.Annotation) {
					if (result.Object is CalloutAnnotation) {
						m_objClickedAnnotation = result.Object;
						mnuAnnotationPlay.Enabled = true;
						mnuAnnotationCopy.Enabled = true;
						mnuAnnotationDelete.Enabled = true;
						if (m_objCopiedAnnotation == null) {
							mnuAnnotationPaste.Enabled = false;
						} else {
							mnuAnnotationPaste.Enabled = true;
						}
						mnuAnnotation.Show(graph, e.X, e.Y);
					}
				} else {
					mnuAnnotationPlay.Enabled = false;
					mnuAnnotationCopy.Enabled = false;
					mnuAnnotationDelete.Enabled = false;
					if (m_objCopiedAnnotation == null) {
						mnuAnnotationPaste.Enabled = false;
					} else {
						mnuAnnotationPaste.Enabled = true;
					}
					mnuAnnotation.Show(graph, e.X, e.Y);
				}
			}
		}


		private Point m_ptPaste;
		private System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation m_objCopiedAnnotation;

		private System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation m_objClickedAnnotation;
		private void mnuAnnotationCopy_Click(System.Object sender, System.EventArgs e)
		{
			mnuAnnotationPaste.Enabled = true;
			m_objCopiedAnnotation = m_objClickedAnnotation;
		}

		private void mnuAnnotationPaste_Click(System.Object sender, System.EventArgs e)
		{
			PasteAnnotation();
		}

		private void PasteAnnotation()
		{
			if ((m_objCopiedAnnotation != null)) {
				System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
				//objCalloutCloud.ClipToChartArea = "ChartArea1"
				objCalloutCloud.AllowAnchorMoving = true;
				objCalloutCloud.AllowSelecting = true;
				objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
				objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
				objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
				objCalloutCloud.Name = Guid.NewGuid().ToString();
				objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.ShadowOffset = 1;
				objCalloutCloud.Text = m_objCopiedAnnotation.Text;
				objCalloutCloud.Tag = m_objCopiedAnnotation.Tag;
				objCalloutCloud.AnchorDataPoint = m_objCopiedAnnotation.AnchorDataPoint;
				objCalloutCloud.SmartLabelStyle.Enabled = true;
				objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
				objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
				objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
				this.graph.Annotations.Add(objCalloutCloud);
				Changed = true;
			}
		}

		private void cmbCycles_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			DrawGraph();
		}

		private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			DrawGraph();
		}

		private int m_intLastX;
		private int m_intLastY;

		private DateTime m_intLastTag;
		int m_intPoint = 0;
		private void graph_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			HitTestResult result = graph.HitTest(e.X, e.Y);

			if (m_objSelectedAnnotation == null) {
				return;
			}

			if (m_intPoint > -1) {
				//graph.Series("REM").Points(m_intPoint).Color = Color.FromArgb(200, 65, 140, 240) ' Color.LightSteelBlue
			}

			m_intPoint = 0;
			if (result.ChartElementType == ChartElementType.DataPoint | result.ChartElementType == ChartElementType.DataPointLabel | result.ChartElementType == ChartElementType.LegendItem) {
				if (result.Series.Name.StartsWith("REM")) {
					m_intPoint = result.PointIndex;
					//result.Series.Points(result.PointIndex).Color = Color.FromArgb(255, 65, 140, 240) ' Color.LightSteelBlue

					if ((m_objSelectedAnnotation) is CalloutAnnotation) {
						if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MP3::")) {
							((CalloutAnnotation)m_objSelectedAnnotation).Text = new FileInfo(m_objSelectedAnnotation.Tag.ToString().Replace("MP3::", "")).Name + " (" + m_intPoint + ")";
						} else if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MEM::")) {
							((CalloutAnnotation)m_objSelectedAnnotation).Text = m_objSelectedAnnotation.Tag.ToString().Replace("MEM::", "") + " (" + m_intPoint + ")";
						} else {
							((CalloutAnnotation)m_objSelectedAnnotation).Text = new FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") + " (" + m_intPoint + ")";
						}
					}
				}
			} else {

				if ((m_objSelectedAnnotation) is CalloutAnnotation) {
					if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MP3::")) {
						((CalloutAnnotation)m_objSelectedAnnotation).Text = new FileInfo(m_objSelectedAnnotation.Tag.ToString().Replace("MP3::", "")).Name + " (" + 0 + ")";
					} else if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MEM::")) {
						((CalloutAnnotation)m_objSelectedAnnotation).Text = m_objSelectedAnnotation.Tag.ToString().Replace("MEM::", "") + " (" + 0 + ")";
					} else {
						((CalloutAnnotation)m_objSelectedAnnotation).Text = new FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") + " (" + 0 + ")";
					}
				}
			}

			return;
		}


		private void graph_DragDrop(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
		}

		private void graph_DragEnter(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode()")) {
				e.Effect = DragDropEffects.Link;
			} else {
				e.Effect = DragDropEffects.None;
			}
		}

		private void graph_DragOver(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode()")) {
				e.Effect = DragDropEffects.Link;
			} else {
				e.Effect = DragDropEffects.None;
			}
		}

		private void graph_AnnotationPositionChanged(object sender, System.EventArgs e)
		{
			if ((m_objSelectedAnnotation != null)) {
				System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
				objCalloutCloud.AllowSelecting = true;
				objCalloutCloud.AllowAnchorMoving = true;
				objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
				objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
				objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
				objCalloutCloud.Name = Guid.NewGuid().ToString();
				objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.ShadowOffset = 1;
				objCalloutCloud.Tag = m_objSelectedAnnotation.Tag;
				objCalloutCloud.IsSizeAlwaysRelative = false;
				objCalloutCloud.AnchorAlignment = ContentAlignment.MiddleCenter;
				objCalloutCloud.SmartLabelStyle.Enabled = true;
				objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
				objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
				objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
				Changed = true;
				if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MP3::")) {
					objCalloutCloud.Text = new FileInfo(m_objSelectedAnnotation.Tag.ToString().Replace("MP3::", "")).Name + " (" + m_intPoint + ")";
				} else if (m_objSelectedAnnotation.Tag.ToString().StartsWith("MEM::")) {
					objCalloutCloud.Text = m_objSelectedAnnotation.Tag.ToString().Replace("MEM::", "") + " (" + m_intPoint + ")";
				} else {
					objCalloutCloud.Text = new FileInfo(m_objSelectedAnnotation.Tag).Name.Replace(".ld3", "") + " (" + m_intPoint + ")";
				}
				objCalloutCloud.AnchorDataPoint = graph.Series["REM"].Points[m_intPoint];
				graph.Annotations.Remove(m_objSelectedAnnotation);
				this.graph.Annotations.Add(objCalloutCloud);
				m_objSelectedAnnotation = null;
				return;
			}

			m_objSelectedAnnotation = null;
		}

		private void mnuAnnotationDelete_Click(System.Object sender, System.EventArgs e)
		{
			DeleteAnnotation();
		}

		private void graph_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control) {
				if (e.KeyCode == Keys.V) {
					PasteAnnotation();
				}
			}
		}

		private void DeleteAnnotation()
		{
			foreach (Annotation objAnnotation in graph.Annotations) {
				if (objAnnotation.IsSelected) {
					graph.Annotations.Remove(objAnnotation);
					Changed = true;
					break; // TODO: might not be correct. Was : Exit For
				}
			}
		}


		private void mnuAnnotationAdd_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void mnuLuciditySubItem_Click(System.Object sender, System.EventArgs e)
		{
			ToolStripMenuItem objMenu = (ToolStripMenuItem)sender;
			AddFile(objMenu.Tag, objMenu.Text);
		}

		private void AddFile(string Lucidity, string FileName)
		{
			System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
			//objCalloutCloud.ClipToChartArea = "ChartArea1"
			objCalloutCloud.AllowAnchorMoving = true;
			objCalloutCloud.AllowSelecting = true;
			objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
			objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
			objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
			objCalloutCloud.Name = Guid.NewGuid().ToString();
			objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
			objCalloutCloud.ShadowOffset = 1;
			objCalloutCloud.Text = new FileInfo(FileName).Name.Replace(".ld3", "");
			objCalloutCloud.Tag = Lucidity;
			objCalloutCloud.AnchorDataPoint = graph.Series["REM"].Points[0];
			objCalloutCloud.SmartLabelStyle.Enabled = true;
			objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
			objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
			objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
			this.graph.Annotations.Add(objCalloutCloud);

			Changed = true;
		}

		private void mnuLucidity_DropDownOpening(System.Object sender, System.EventArgs e)
		{
			ToolStripMenuItem objMenu = (ToolStripMenuItem)sender;
			objMenu.DropDownItems.Clear();

			foreach (string strFile in Directory.GetFiles(m_strPath + "Lucidity\\" + objMenu.Tag, "*.ld3")) {
				ToolStripMenuItem objMenuSubItem = objMenu.DropDownItems.Add(new FileInfo(strFile).Name.Replace(".ld3", ""), objMenu.Image, mnuLuciditySubItem_Click);
				objMenuSubItem.Tag = strFile;
			}
		}

		private void mnuAddSoundFile_Click(System.Object sender, System.EventArgs e)
		{
			if (objOpenFileDialog.ShowDialog() == DialogResult.OK) {
				System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCalloutCloud = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
				//objCalloutCloud.ClipToChartArea = "ChartArea1"
				objCalloutCloud.AllowAnchorMoving = true;
				objCalloutCloud.AllowSelecting = true;
				objCalloutCloud.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
				objCalloutCloud.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
				objCalloutCloud.ForeColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.LineColor = System.Drawing.Color.LightSteelBlue;
				objCalloutCloud.Name = Guid.NewGuid().ToString();
				objCalloutCloud.ShadowColor = System.Drawing.Color.SteelBlue;
				objCalloutCloud.ShadowOffset = 1;
				objCalloutCloud.Text = new FileInfo(objOpenFileDialog.FileName).Name;
				objCalloutCloud.Tag = "MP3::" + objOpenFileDialog.FileName;
				objCalloutCloud.AnchorDataPoint = graph.Series["REM"].Points[0];
				objCalloutCloud.SmartLabelStyle.Enabled = true;
				objCalloutCloud.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
				objCalloutCloud.SmartLabelStyle.IsOverlappedHidden = false;
				objCalloutCloud.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
				this.graph.Annotations.Add(objCalloutCloud);

				Changed = true;
			}
		}

		private void mnuAnnotationPlay_Click(System.Object sender, System.EventArgs e)
		{
			if ((m_objClickedAnnotation != null)) {
				Execute(m_objClickedAnnotation.Tag);
			}
		}
		public REMCyclesControl()
		{
			Load += REMCyclesControl_Load;
			InitializeComponent();
		}
	}
}
