using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using System.Drawing.Drawing2D;
using System.IO;
namespace LightenedDream
{

	public partial class SplashForm
	{

		private MainForm m_formMain;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";

		private string m_strOldPath = DataDirectory.GetFolderPath() + "\\Liquid Dream III\\";
		private void SplashForm3_Load(object sender, System.EventArgs e)
		{
			this.Left = Screen.PrimaryScreen.Bounds.Left + (Screen.PrimaryScreen.Bounds.Width - (Screen.PrimaryScreen.Bounds.Width / 1.5)) / 2;
			this.Top = Screen.PrimaryScreen.Bounds.Top + (Screen.PrimaryScreen.Bounds.Height - (Screen.PrimaryScreen.Bounds.Height / 1.5)) / 2;
			this.Width = Screen.PrimaryScreen.Bounds.Width / 1.5;
			this.Height = Screen.PrimaryScreen.Bounds.Height / 1.5;
		}

		private void CheckFolders()
		{
			string strDirectory = null;


			try {
				// Migrate Liquid Dream to Lightened Dream
				if (Directory.Exists(m_strOldPath)) {
					foreach (string strOldDirectory in Directory.GetDirectories(m_strOldPath)) {
						Migrate(strOldDirectory);
					}
					Directory.Delete(m_strOldPath, true);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Migrate()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}

			try {
				strDirectory = DataDirectory.GetFolderPath();
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = DataDirectory.GetFolderPath() + "\\Lightened Dream";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

				strDirectory = m_strPath + "Dreams";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

				strDirectory = m_strPath + "Categories";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

				strDirectory = m_strPath + "Lucidity";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\Readings";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\Recordings";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\REM Cycles";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\REM Cycles\\Temp";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\Subliminals";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = m_strPath + "Lucidity\\Exercises";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

				strDirectory = m_strPath + "Resources";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

				strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);
				strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck";
				if (!Directory.Exists(strDirectory))
					Directory.CreateDirectory(strDirectory);

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Splash.LoadFolders()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}

		private void Migrate(string OldPath)
		{
			foreach (string strDirectory in Directory.GetDirectories(OldPath)) {
				Migrate(strDirectory);
			}
			if (!Directory.Exists(OldPath.Replace("Liquid Dream III", "Lightened Dream"))) {
				Directory.CreateDirectory(OldPath.Replace("Liquid Dream III", "Lightened Dream"));
			}
			foreach (string strFile in Directory.GetFiles(OldPath, "*.*")) {
				File.Move(strFile, strFile.Replace("Liquid Dream III", "Lightened Dream"));
			}
		}

		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{
			tmrLoad.Enabled = false;

			try {
				Application.DoEvents();
				graph.ChartAreas[0].AxisX.CustomLabels.Clear();
				graph.Series.Clear();
				graph.ResetAutoValues();
				graph.Annotations.Clear();

				Application.DoEvents();
				this.Opacity = 1;
				// Dreams
				int intPos = 0;

				// Dreams
				Series objDreams = graph.Series.Add("Dreams");
				objDreams.ChartType = SeriesChartType.Column;
				objDreams.Color = Color.FromArgb(200, 65, 140, 240);
				objDreams.BorderWidth = 1;
				objDreams.Points.AddY(0);

				CheckFolders();

				// Calculate Exercises
				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Lucidity\\Exercises")) {
					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							objDreams.Points[0].YValues[0] += 1;
						}
					}
				}
				Application.DoEvents();

				System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objExerciseAnnotation = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
				objExerciseAnnotation.AllowMoving = true;
				objExerciseAnnotation.AllowResizing = true;
				objExerciseAnnotation.AllowSelecting = true;
				objExerciseAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
				objExerciseAnnotation.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
				objExerciseAnnotation.ForeColor = System.Drawing.Color.SteelBlue;
				objExerciseAnnotation.LineColor = System.Drawing.Color.LightSteelBlue;
				objExerciseAnnotation.Name = Guid.NewGuid().ToString();
				objExerciseAnnotation.ShadowColor = System.Drawing.Color.SteelBlue;
				objExerciseAnnotation.ShadowOffset = 1;
				objExerciseAnnotation.Text = "Exercises (" + objDreams.Points[0].YValues[0] + ")";
				objExerciseAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
				objExerciseAnnotation.AnchorDataPoint = objDreams.Points[0];
				this.graph.Annotations.Add(objExerciseAnnotation);
				Application.DoEvents();
				System.Threading.Thread.Sleep(128);

				// Calculate Dreams
				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {
					int dreamCount = 0;
					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							dreamCount += 1;
						}
					}
					objDreams.Points.AddY(dreamCount);

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
					objDreamAnnotation.Text = new DirectoryInfo(strYearFolder).Name + " (" + dreamCount + ")";
					objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
					objDreamAnnotation.AnchorDataPoint = objDreams.Points[objDreams.Points.Count - 1];
					this.graph.Annotations.Add(objDreamAnnotation);
					Application.DoEvents();
					System.Threading.Thread.Sleep(128);
					intPos += 1;
					Application.DoEvents();
				}

				// Categories
				foreach (string categoryPath in Directory.GetDirectories(m_strPath + "Categories")) {
					intPos = objDreams.Points.AddY(Directory.GetFiles(categoryPath, "*.ld3", SearchOption.AllDirectories).Length);

					System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCategoryAnnotation = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
					objCategoryAnnotation.AllowMoving = true;
					objCategoryAnnotation.AllowResizing = true;
					objCategoryAnnotation.AllowSelecting = true;
					objCategoryAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
					objCategoryAnnotation.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
					objCategoryAnnotation.ForeColor = System.Drawing.Color.SteelBlue;
					objCategoryAnnotation.LineColor = System.Drawing.Color.LightSteelBlue;
					objCategoryAnnotation.Name = Guid.NewGuid().ToString();
					objCategoryAnnotation.ShadowColor = System.Drawing.Color.SteelBlue;
					objCategoryAnnotation.ShadowOffset = 1;
					objCategoryAnnotation.Text = new FileInfo(categoryPath).Name + " (" + objDreams.Points[intPos].YValues[0] + ")";
					objCategoryAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
					objCategoryAnnotation.AnchorDataPoint = objDreams.Points[intPos];
					this.graph.Annotations.Add(objCategoryAnnotation);

					Application.DoEvents();
					System.Threading.Thread.Sleep(128);
				}

				// Lucidity
				foreach (string strCategory in "REM Cycles,Subliminals,Recordings,Readings".Split(",")) {
					intPos = objDreams.Points.AddY(Directory.GetFiles(m_strPath + "Lucidity\\" + strCategory, "*.ld3").Length);

					System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation objCategoryAnnotation = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
					objCategoryAnnotation.AllowMoving = true;
					objCategoryAnnotation.AllowResizing = true;
					objCategoryAnnotation.AllowSelecting = true;
					objCategoryAnnotation.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
					objCategoryAnnotation.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
					objCategoryAnnotation.ForeColor = System.Drawing.Color.SteelBlue;
					objCategoryAnnotation.LineColor = System.Drawing.Color.LightSteelBlue;
					objCategoryAnnotation.Name = Guid.NewGuid().ToString();
					objCategoryAnnotation.ShadowColor = System.Drawing.Color.SteelBlue;
					objCategoryAnnotation.ShadowOffset = 1;
					objCategoryAnnotation.Text = strCategory + " (" + objDreams.Points[intPos].YValues[0] + ")";
					objCategoryAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;
					objCategoryAnnotation.AnchorDataPoint = objDreams.Points[intPos];
					this.graph.Annotations.Add(objCategoryAnnotation);

					Application.DoEvents();
					System.Threading.Thread.Sleep(128);
				}

				Application.DoEvents();
				m_formMain = new MainForm();

				while (!m_formMain.Loaded) {
					Application.DoEvents();
					System.Threading.Thread.Sleep(10);
				}

				this.Opacity = 0.6;
				Application.DoEvents();
				m_formMain.Show();
				Application.DoEvents();

				Application.DoEvents();
				System.Threading.Thread.Sleep(128);
				Application.DoEvents();
				Hide();

				m_formMain.LoadImport();

			} catch (Exception ex) {
				if (ex.Message.Contains("80040154")) {
					if (MessageBox.Show("Lightened Dream requires Windows Media Player, which can be downloaded for free from Microsoft. Would you like to download it now?", "Lightened Dream", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						try {
							System.Diagnostics.Process.Start("http://windows.microsoft.com/en-us/windows/download-windows-media-player");
						} catch (Exception mediaException) {
							MessageBox.Show(mediaException.Message, "LightenedDream.MediaPlayer.Download()", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				} else {
					MessageBox.Show(ex.Message, "LightenedDream.Splash.LoadGraph()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Application.Exit();
			}
		}
		public SplashForm()
		{
			Load += SplashForm3_Load;
			InitializeComponent();
		}
	}
}
