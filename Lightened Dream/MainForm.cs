using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using lucidcode.LightenedDream;
using System.Xml;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using System.Net;
using System.Threading;
namespace LightenedDream
{

	public partial class MainForm
	{

		public bool Loaded = false;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		private List<string> m_arrCategories = new List<string>();
		private List<TreeNode> m_arrBackHistory = new List<TreeNode>();
		private List<TreeNode> m_arrForwardHistory = new List<TreeNode>();
		private bool m_boolNavigating;

		private bool m_boolChanged = false;
		private lucidcode.LightenedDream.Dreams.DreamViewControl m_objDreamViewControl = new lucidcode.LightenedDream.Dreams.DreamViewControl();
		private lucidcode.LightenedDream.Dreams.MonthListControl m_objMonthListControl = new lucidcode.LightenedDream.Dreams.MonthListControl();
		private lucidcode.LightenedDream.Dreams.YearListControl m_objYearListControl = new lucidcode.LightenedDream.Dreams.YearListControl();
		private lucidcode.LightenedDream.Dreams.YearsListControl m_objYearsListControl = new lucidcode.LightenedDream.Dreams.YearsListControl();
		private lucidcode.LightenedDream.Dreams.SearchControl m_objSearchControl = new lucidcode.LightenedDream.Dreams.SearchControl();
		private lucidcode.LightenedDream.Dreams.DreamSignBuilderControl m_objDreamSignListControl = new lucidcode.LightenedDream.Dreams.DreamSignBuilderControl();
		private lucidcode.LightenedDream.Dreams.RecentDreamSignControl m_objRecentDreamSignControl = new lucidcode.LightenedDream.Dreams.RecentDreamSignControl();

		private lucidcode.LightenedDream.Dreams.CompareDreamsControl m_objCompareDreamsControl = new lucidcode.LightenedDream.Dreams.CompareDreamsControl();
		private lucidcode.LightenedDream.Categories.ViewControl m_objCategoryViewControl = new lucidcode.LightenedDream.Categories.ViewControl();
		private lucidcode.LightenedDream.Categories.CategoriesListControl m_objCategoriesListControl = new lucidcode.LightenedDream.Categories.CategoriesListControl();

		private lucidcode.LightenedDream.Categories.CategoryListControl m_objCategoryListControl = new lucidcode.LightenedDream.Categories.CategoryListControl();
		private lucidcode.LightenedDream.Lucidity.REMCyclesControl m_objREMCyclesControl = new lucidcode.LightenedDream.Lucidity.REMCyclesControl();
		private lucidcode.LightenedDream.Lucidity.ItemViewControl m_objLucidItemControl = new lucidcode.LightenedDream.Lucidity.ItemViewControl();
		private lucidcode.LightenedDream.Lucidity.FolderViewControl m_objLucidFolderViewControl = new lucidcode.LightenedDream.Lucidity.FolderViewControl();

		private lucidcode.LightenedDream.Lucidity.LucidityControl m_objLucidityControl = new lucidcode.LightenedDream.Lucidity.LucidityControl();
		private lucidcode.LightenedDream.Lucidity.ExerciseViewControl m_objExerciseViewControl = new lucidcode.LightenedDream.Lucidity.ExerciseViewControl();
		private lucidcode.LightenedDream.Lucidity.MonthListControl m_objExerciseMonthListControl = new lucidcode.LightenedDream.Lucidity.MonthListControl();
		private lucidcode.LightenedDream.Lucidity.YearListControl m_objExerciseYearListControl = new lucidcode.LightenedDream.Lucidity.YearListControl();
		private lucidcode.LightenedDream.Lucidity.YearsListControl m_objExerciseYearsListControl = new lucidcode.LightenedDream.Lucidity.YearsListControl();

		private TreeNode trvNodeImported = null;
		private  m_boolYearSelected = false;
		private bool m_boolAgentWorks = false;
		private DateTime m_dtLastREMPlayed;
		private AboutForm m_formAbout;

		private UpdateControl m_objUpdateControl = new UpdateControl();
		private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

		private Series m_objDreams;
		private UpdateClass m_objUpdater = new UpdateClass();

		private Thread m_objUpdateThread;
		private void tmrLoad_Tick(System.Object sender, System.EventArgs e)
		{

			try {
				tmrLoad.Enabled = false;

				try {
					m_objUpdateThread = new Thread(m_objUpdater.CheckForUpdate);
					m_objUpdateThread.Start();
				} catch (Exception ex) {
				}

				string strImportType = "";
				string strImportFileName = "";
				string strNewPath = "";
				try {
					if (Environment.GetCommandLineArgs().Length > 1) {
						strImportFileName = new FileInfo(Environment.GetCommandLineArgs(1)).Name;
						XmlReader xmlReader = xmlReader.Create(Environment.GetCommandLineArgs(1));
						xmlReader.Read();
						strImportType = xmlReader.Name;
						if (xmlReader.Name == "xml") {
							xmlReader.Read();
							strImportType = xmlReader.Name;
						}
						if (xmlReader.Name == "XML") {
							xmlReader.Read();
							strImportType = xmlReader.Name;
						}

						if (strImportType == "REM") {
							strNewPath = m_strPath + "Lucidity\\REM Cycles\\" + strImportFileName;
						} else if (strImportType == "Subliminal") {
							strNewPath = m_strPath + "Lucidity\\Subliminals\\" + strImportFileName;
						} else if (strImportType == "Exercises") {
							strNewPath = m_strPath + "Lucidity\\Exercises\\" + strImportFileName;
						} else if (strImportType == "Recording") {
							strNewPath = m_strPath + "Lucidity\\Recordings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;

						} else if (strImportType == "Category") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						} else if (strImportType == "Reading") {
							strNewPath = m_strPath + "Lucidity\\Readings\\" + strImportFileName;
						}

						//If File.Exists(m_strPath & "Lucidity\Readings\" & strImportFileName) Then
						try {
							File.Copy(Environment.GetCommandLineArgs(1), strNewPath, true);
						} catch (Exception ex) {
						}
						//End If
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "LightenedDream.Import()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				this.DoubleBuffered = true;
				LoadGUI();
				LoadTree();
				LoadSpellCheckLanguages();
				//Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
				lblStatus.Text = "";
				toolBack.Enabled = false;
				m_arrBackHistory.Clear();
				m_arrBackHistory.Add(trvMain.SelectedNode);

				m_objDreamViewControl.CategoryCreated += CategoryCreated;
				m_objDreamViewControl.PlayingStopped += PlayingStopped;
				m_objDreamViewControl.RandomWord += RandomWord;

				m_objMonthListControl.DreamSelected += DreamSelected;
				m_objYearListControl.MonthSelected += MonthSelected;
				m_objYearsListControl.MonthSelected += SearchMonthSelected;

				m_objExerciseMonthListControl.DreamSelected += ExerciseDreamSelected;
				m_objExerciseYearListControl.MonthSelected += ExerciseMonthSelected;
				m_objExerciseYearsListControl.MonthSelected += ExercisesearchMonthSelected;

				m_objSearchControl.MonthSelected += SearchMonthSelected;
				m_objSearchControl.CategoryFileSelected += SearchCategoryFileSelected;
				m_objSearchControl.CategoryFileCreated += SearchCategoryFileCreated;
				m_objDreamSignListControl.CategoryFileCreated += DreamSignCategoryFileCreated;

				m_objCategoryViewControl.SelectDream += SelectDream;
				m_objCategoryViewControl.RandomWord += RandomWord;
				m_objCategoriesListControl.CategorySelected += CategorySelected;
				m_objCategoryListControl.CategorySelected += CategorySelected;

				m_objLucidFolderViewControl.LucidItemSelected += LucidItemSelected;
				m_objLucidityControl.LucidFolderSelected += LucidFolderSelected;

				Loaded = true;

				SplitContainer1.SplitterDistance = 247;

				if (!string.IsNullOrEmpty(strImportType)) {
					if (strImportType == "REM") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "REM Cycles"), strImportFileName.Replace(".ld3", ""));
					} else if (strImportType == "Check") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "Checks"), strImportFileName.Replace(".ld3", ""));
					} else if (strImportType == "Subliminal") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "Subliminals"), strImportFileName.Replace(".ld3", ""));
					} else if (strImportType == "Exercises") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "Exercises"), strImportFileName.Replace(".ld3", ""));
					} else if (strImportType == "Recording") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "Recordings"), strImportFileName.Replace(".ld3", ""));
					} else if (strImportType == "Reading") {
						trvNodeImported = FindNode(FindNode(trvMain.Nodes[2], "Readings"), strImportFileName.Replace(".ld3", ""));
					}
				}

				VBMath.Randomize();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			m_objDreamViewControl.Focus();
			m_objDreamViewControl.txtDream.Focus();
		}

		public void LoadImport()
		{
			if ((trvNodeImported != null)) {
				trvMain.SelectedNode = trvNodeImported;
				if (mnuToolsPlay.Enabled) {
					System.Threading.Thread.Sleep(250);
					Application.DoEvents();
					System.Threading.Thread.Sleep(250);
					PlayLucid();
				}
			}
		}


		private void ImportFile()
		{
		}

		// Load all the user controls to speed up resizing / loading later
		private void LoadGUI()
		{
			// Dreams
			pnlContainer.Controls.Clear();
			m_objDreamViewControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objDreamViewControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objMonthListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objMonthListControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objYearListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objYearListControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objYearsListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objYearsListControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objSearchControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objSearchControl);
			Application.DoEvents();

			// Categories
			pnlContainer.Controls.Clear();
			m_objCategoryViewControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objCategoryViewControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objCategoriesListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objCategoriesListControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objCategoryListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objCategoryListControl);
			Application.DoEvents();

			// Lucidity
			pnlContainer.Controls.Clear();
			m_objREMCyclesControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objREMCyclesControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objLucidItemControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objLucidItemControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objLucidFolderViewControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objLucidFolderViewControl);
			Application.DoEvents();

			pnlContainer.Controls.Clear();
			m_objLucidityControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objLucidityControl);
			Application.DoEvents();

			// Exercises
		}

		private void LoadTree()
		{
			try {
				trvMain.Nodes.Clear();
				LoadDreams();
				LoadCategories();
				LoadLucidity();
				LoadExercises();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadTree()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadDreams()
		{
			try {
				// Create the Dream node
				TreeNode trvDreams = new TreeNode("Dreams");
				TreeNode trvDream = null;
				lucidcode.LightenedDream.Dreams.Tags.YearsFolder objDreamsFolderTag = new lucidcode.LightenedDream.Dreams.Tags.YearsFolder(m_strPath + "Dreams", "");
				trvDreams.Tag = objDreamsFolderTag;
				trvMain.Nodes.Add(trvDreams);

				// Make sure that the dreams folder exists
				if (!Directory.Exists(m_strPath + "Dreams")) {
					Directory.CreateDirectory(m_strPath + "Dreams");
				}

				// Make sure we have an entry
				if (Directory.GetDirectories(m_strPath + "Dreams").Length == 0) {
					CreateWelcomeDream();
				}

				// Load each year
				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {
					TreeNode trvYear = new TreeNode(new DirectoryInfo(strYearFolder).Name);
					lucidcode.LightenedDream.Dreams.Tags.YearFolder objYearTag = new lucidcode.LightenedDream.Dreams.Tags.YearFolder(strYearFolder, trvYear.Text);
					trvYear.Tag = objYearTag;
					trvDreams.Nodes.Add(trvYear);

					// Load each month
					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						TreeNode trvMonth = new TreeNode(new DirectoryInfo(strMonthFolder).Name);
						lucidcode.LightenedDream.Dreams.Tags.MonthFolder objMonthTag = new lucidcode.LightenedDream.Dreams.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text);
						trvMonth.Tag = objMonthTag;
						trvYear.Nodes.Add(trvMonth);

						// Load each dream
						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(strDreamFile);
							var dreamTitle = new FileInfo(strDreamFile).Name.Replace(".ld3", "");

							// Check for special characters in the title and load them from within the file
							if (dreamTitle.Contains("_")) {
								XmlDocument xmlDream = new XmlDocument();
								xmlDream.Load(strDreamFile);
								dreamTitle = dreamTitle.Substring(0, 3) + xmlDream.DocumentElement.SelectSingleNode("Title").InnerText;
							}

							trvDream = new TreeNode(dreamTitle);
							trvDream.Tag = objDreamTag;
							trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
							trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
							trvMonth.Nodes.Add(trvDream);

							// Add the loading node
							TreeNode trvLoading = new TreeNode("Loading Categories...");
							trvDream.Nodes.Add(trvLoading);
						}

					}
				}

				if (trvDream != null) {
					trvMain.SelectedNode = trvDream;
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadDreams()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CreateWelcomeDream()
		{
			Directory.CreateDirectory(m_strPath + "Dreams\\" + DateAndTime.Now.Year.ToString());
			Directory.CreateDirectory(m_strPath + "Dreams\\" + DateAndTime.Now.Year.ToString() + "\\" + Strings.Format(DateAndTime.Now, "MM"));

			string strXml = "<Dream>";
			strXml += "<Date>" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "</Date>";
			strXml += "<Time>04:20</Time>";
			strXml += "<Sleep>23:30</Sleep>";
			strXml += "<Awake>06:30</Awake>";
			strXml += "<Title>" + "First Entry" + "</Title>";
			strXml += "<Dream>" + "" + "</Dream>";
			strXml += "<Clarity>" + "5" + "</Clarity>";
			strXml += "<Lessons>" + "" + "</Lessons>";
			strXml += "</Dream>";

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(strXml);
			string strFileName = m_strPath + "Dreams\\" + DateAndTime.Now.Year.ToString() + "\\" + Strings.Format(DateAndTime.Now, "MM") + "\\" + Strings.Format(DateAndTime.Now, "dd") + " " + "First Entry" + ".ld3";
			xmlDoc.Save(strFileName);
		}

		private void CreateWelcomeExercise()
		{
			Directory.CreateDirectory(m_strPath + "\\Lucidity\\Exercises\\" + DateAndTime.Now.Year.ToString());
			Directory.CreateDirectory(m_strPath + "\\Lucidity\\Exercises\\" + DateAndTime.Now.Year.ToString() + "\\" + Strings.Format(DateAndTime.Now, "MM"));

			string strXml = "<Exercise>";
			strXml += "<Date>" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "</Date>";
			strXml += "<Time>" + Strings.Format(DateAndTime.Now, "HH:mm") + "</Time>";
			strXml += "<Title>" + "First Exercise" + "</Title>";
			strXml += "<Task>" + "Install Lightened Dream." + "</Task>";
			strXml += "<Details></Details>";
			strXml += "<Lucidity>" + "5" + "</Lucidity>";
			strXml += "</Exercise>";

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(strXml);
			string strFileName = m_strPath + "Lucidity\\Exercises\\" + DateAndTime.Now.Year.ToString() + "\\" + Strings.Format(DateAndTime.Now, "MM") + "\\" + Strings.Format(DateAndTime.Now, "dd") + " " + "First Exercise" + ".ld3";
			xmlDoc.Save(strFileName);
		}

		private void LoadCategories()
		{
			try {
				// Create the Categories node
				TreeNode trvCategories = new TreeNode("Categories");
				lucidcode.LightenedDream.Categories.Tags.CategoriesFolder objCategoriesFolderTag = new lucidcode.LightenedDream.Categories.Tags.CategoriesFolder(m_strPath + "Categories");
				trvCategories.Tag = objCategoriesFolderTag;
				trvMain.Nodes.Add(trvCategories);

				// Load each Category
				foreach (string strCategory in Directory.GetDirectories(m_strPath + "Categories")) {
					LoadCategoryFolder(strCategory, null);
					//Dim objToolMenuItem As New ToolStripMenuItem
					//objToolMenuItem.Text = strCategory.Substring(0, strCategory.Length - 1)
					//AddHandler objToolMenuItem.Click, AddressOf mnuToolNewCategory_Click
					//toolNew.DropDownItems.Add(objToolMenuItem)
				}

				// Load each custom category
				//For Each strFolder As String In Directory.GetDirectories(m_strPath + "Categories")
				//    Dim boolisDefault As Boolean = False
				//    For Each strCategory As String In m_strCategories.Split(",")
				//        If strCategory.ToLower = New DirectoryInfo(strFolder).Name.ToLower Then
				//            boolisDefault = True
				//            Exit For
				//        End If
				//    Next

				//    If Not boolisDefault Then
				//        LoadCategoryFolder(New DirectoryInfo(strFolder).Name)
				//    End If
				//Next
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void LoadCategoryFolder(string strCategory, TreeNode parentNode)
		{
			TreeNode trvCategoryFolder = new TreeNode(new DirectoryInfo(strCategory).Name);
			lucidcode.LightenedDream.Categories.Tags.CategoryFolder objCategoryFolderTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFolder(strCategory);
			trvCategoryFolder.Tag = objCategoryFolderTag;
			if (lstImgTrv.Images.IndexOfKey("Folder." + strCategory) != -1) {
				trvCategoryFolder.ImageIndex = 0;
				trvCategoryFolder.SelectedImageIndex = 1;
			}

			if ((parentNode != null)) {
				parentNode.Nodes.Add(trvCategoryFolder);
			} else {
				trvMain.Nodes[1].Nodes.Add(trvCategoryFolder);
			}

			foreach (string subCategory in Directory.GetDirectories(strCategory)) {
				LoadCategoryFolder(subCategory, trvCategoryFolder);
			}

			// Load each item
			foreach (string strCatgeoryFile in Directory.GetFiles(strCategory, "*.ld3")) {
				TreeNode trvCategory = new TreeNode(new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
				lucidcode.LightenedDream.Categories.Tags.CategoryFile objCategoryTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(strCatgeoryFile, strCategory);
				objCategoryTag.Category = strCategory.Replace(m_strPath + "Categories\\", "");
				trvCategory.Tag = objCategoryTag;
				trvCategory.ImageIndex = 16;
				trvCategory.SelectedImageIndex = 16;
				if (lstImgTrv.Images.IndexOfKey("File." + strCategory) != -1) {
					trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
					trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
				}
				trvCategoryFolder.Nodes.Add(trvCategory);
				m_arrCategories.Add(trvCategory.Text);

				// Load each dream
				System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
				xmlCategory.Load(strCatgeoryFile);
				foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
					TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
					lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
					trvDream.Tag = objDreamTag;
					trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
					trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
					trvCategory.Nodes.Add(trvDream);
					// Add the loading node
					TreeNode trvLoading = new TreeNode("Loading Categories...");
					trvDream.Nodes.Add(trvLoading);
				}
			}
		}

		private void LoadLucidity()
		{
			try {
				// Create the Lucidty node
				TreeNode trvLucidity = trvMain.Nodes.Add("Lucidity", "Lucidity");
				lucidcode.LightenedDream.Lucidity.Tags.LucidityFolder objLucidityFolderTag = new lucidcode.LightenedDream.Lucidity.Tags.LucidityFolder(m_strPath + "Lucidity");
				trvLucidity.Tag = objLucidityFolderTag;

				string strLucidity = "REM Cycles,Subliminals,Recordings,Readings";

				// Load each Category
				foreach (string strCategory in strLucidity.Split(",")) {
					TreeNode trvCategoryFolder = trvLucidity.Nodes.Add(strCategory, strCategory);
					//If strCategory = "REM Cycles" Then
					//  Dim objCategoryFolderTag As New Lucidity.Tags.REMCyclesFolder(m_strPath + "Lucidity\" + strCategory)
					//  trvCategoryFolder.Tag = objCategoryFolderTag
					//  If lstImgTrv.Images.IndexOfKey("Folder." & strCategory) <> -1 Then
					//    trvCategoryFolder.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." & strCategory)
					//    trvCategoryFolder.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." & strCategory)
					//  End If
					//Else
					lucidcode.LightenedDream.Lucidity.Tags.LucidItemFolder objCategoryFolderTag = new lucidcode.LightenedDream.Lucidity.Tags.LucidItemFolder(m_strPath + "Lucidity\\" + strCategory, strCategory);
					trvCategoryFolder.Tag = objCategoryFolderTag;
					if (lstImgTrv.Images.IndexOfKey("Folder." + strCategory) != -1) {
						trvCategoryFolder.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." + strCategory);
						trvCategoryFolder.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." + strCategory);
					}
					//End If

					// Make sure that the folder exists
					if (!Directory.Exists(m_strPath + "Lucidity\\" + strCategory)) {
						Directory.CreateDirectory(m_strPath + "Lucidity\\" + strCategory);
					}

					// Load each item
					foreach (string strCatgeoryFile in Directory.GetFiles(m_strPath + "Lucidity\\" + strCategory, "*.ld3")) {
						if (strCategory == "REM Cycles") {
							TreeNode trvCategory = new TreeNode(new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
							lucidcode.LightenedDream.Lucidity.Tags.REMCycleFile objCategoryTag = new lucidcode.LightenedDream.Lucidity.Tags.REMCycleFile(strCatgeoryFile);
							trvCategory.Tag = objCategoryTag;
							trvCategory.ImageIndex = 2;
							trvCategory.SelectedImageIndex = 2;
							if (lstImgTrv.Images.IndexOfKey("File." + strCategory) != -1) {
								trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
								trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
							}
							trvCategoryFolder.Nodes.Add(trvCategory);
						} else {
							TreeNode trvCategory = new TreeNode(new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
							lucidcode.LightenedDream.Lucidity.Tags.LucidItemFile objCategoryTag = new lucidcode.LightenedDream.Lucidity.Tags.LucidItemFile(strCatgeoryFile, new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
							trvCategory.Tag = objCategoryTag;
							trvCategory.ImageIndex = 2;
							trvCategory.SelectedImageIndex = 2;
							if (lstImgTrv.Images.IndexOfKey("File." + strCategory) != -1) {
								trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
								trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + strCategory);
							}
							trvCategoryFolder.Nodes.Add(trvCategory);

						}
					}

					// Create the menu items
					//Dim objToolMenuItem As New ToolStripMenuItem
					//objToolMenuItem.Text = strCategory.Substring(0, strCategory.Length - 1)
					//AddHandler objToolMenuItem.Click, AddressOf mnuToolNewCategory_Click
					//toolNew.DropDownItems.Add(objToolMenuItem)
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadCategories()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadExercises()
		{
			try {
				// Create the Exercises node
				TreeNode trvExercises = new TreeNode("Exercises");
				TreeNode trvDream = null;
				lucidcode.LightenedDream.Lucidity.Tags.YearsFolder objExercisesFolderTag = new lucidcode.LightenedDream.Lucidity.Tags.YearsFolder(m_strPath + "Lucidity\\Exercises", "");
				trvExercises.Tag = objExercisesFolderTag;
				trvMain.Nodes[2].Nodes.Add(trvExercises);

				// Make sure that the Exercises folder exists
				if (!Directory.Exists(m_strPath + "Lucidity\\Exercises")) {
					Directory.CreateDirectory(m_strPath + "Lucidity\\Exercises");
				}

				// Make sure we have an entry
				if (Directory.GetDirectories(m_strPath + "Lucidity\\Exercises").Length == 0) {
					CreateWelcomeExercise();
				}

				// Load each year
				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Lucidity\\Exercises")) {
					TreeNode trvYear = new TreeNode(new DirectoryInfo(strYearFolder).Name);
					lucidcode.LightenedDream.Lucidity.Tags.YearFolder objYearTag = new lucidcode.LightenedDream.Lucidity.Tags.YearFolder(strYearFolder, trvYear.Text);
					trvYear.Tag = objYearTag;
					trvExercises.Nodes.Add(trvYear);

					// Load each month
					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						TreeNode trvMonth = new TreeNode(new DirectoryInfo(strMonthFolder).Name);
						lucidcode.LightenedDream.Lucidity.Tags.MonthFolder objMonthTag = new lucidcode.LightenedDream.Lucidity.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text);
						trvMonth.Tag = objMonthTag;
						trvYear.Nodes.Add(trvMonth);

						// Load each dream
						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							trvDream = new TreeNode(new FileInfo(strDreamFile).Name.Replace(".ld3", ""));
							lucidcode.LightenedDream.Lucidity.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Lucidity.Tags.DreamFile(strDreamFile);
							trvDream.Tag = objDreamTag;
							trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Exercise");
							trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Exercise");
							trvMonth.Nodes.Add(trvDream);

							// Add the loading node
							//Dim trvLoading As New TreeNode("Loading Categories...")
							//trvDream.Nodes.Add(trvLoading)
						}

					}
				}

				//If trvDream IsNot Nothing Then
				//  trvMain.SelectedNode = trvDream
				//End If

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadExercises()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadSpellCheckLanguages()
		{
			try {
				XmlDocument xmlDocSettings = new XmlDocument();

				// Make sure the file exists
				if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck.xml")) {
					string strXml = "<lucidcode>";

					strXml += "<Language>English</Language>";
					strXml += "<CheckSpelling>True</CheckSpelling>";

					strXml += "</lucidcode>";
					xmlDocSettings.LoadXml(strXml);
					xmlDocSettings.Save(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck.xml");
				}

				xmlDocSettings.Load(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck.xml");
				if (xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText == "True") {
					m_objDreamViewControl.EnableSpellCheck();
					m_objLucidItemControl.EnableSpellCheck();
					mnuCheckSpelling.Checked = true;
				} else {
					mnuCheckSpelling.Checked = false;
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.LoadSpellCheckLanguages()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuCheckSpelling_Click(System.Object sender, System.EventArgs e)
		{
			try {
				XmlDocument xmlDocSettings = new XmlDocument();
				xmlDocSettings.Load(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck.xml");

				if (mnuCheckSpelling.Checked) {
					xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText = "True";
					m_objDreamViewControl.EnableSpellCheck();
					m_objLucidItemControl.EnableSpellCheck();
				} else {
					xmlDocSettings.DocumentElement.SelectSingleNode("CheckSpelling").InnerText = "False";
					m_objDreamViewControl.DisableSpellCheck();
					m_objLucidItemControl.DisableSpellCheck();
				}

				xmlDocSettings.Save(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\lucidcode\\SpellCheck.xml");

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.SetSpellCheck()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool CancelForSave(TreeNode trvNode, bool boolClosing)
		{
			try {
				bool boolChanged = false;
				if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
					boolChanged = m_objDreamViewControl.Changed;
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.DreamFile) {
					boolChanged = m_objExerciseViewControl.Changed;
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFile) {
					boolChanged = m_objCategoryViewControl.Changed;
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.REMCycleFile) {
					boolChanged = m_objREMCyclesControl.Changed;
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFile) {
					boolChanged = m_objLucidItemControl.Changed();
				}

				if (boolChanged) {
					DialogResult objResult = default(DialogResult);
					objResult = MessageBox.Show("Would you like to save the changes you made to '" + trvMain.SelectedNode.Text + "'?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (objResult == System.Windows.Forms.DialogResult.Yes) {
						//Save
						Save();
						//If TypeOf (trvMain.SelectedNode.Tag) Is Dreams.Tags.DreamFile Then
						//  m_objDreamViewControl.Save()
						//ElseIf TypeOf (trvNode.Tag) Is Categories.Tags.CategoryFile Then
						//  m_objCategoryViewControl.Save()
						//ElseIf TypeOf (trvNode.Tag) Is Lucidity.Tags.REMCycleFile Then
						//  m_objREMCyclesControl.Save()
						//ElseIf TypeOf (trvNode.Tag) Is Lucidity.Tags.LucidItemFile Then
						//  m_objLucidItemControl.Save()
						//End If
					} else if (objResult == System.Windows.Forms.DialogResult.Cancel) {
						return true;
					}
				}

				if ((trvNode.Tag) is Lucidity.Tags.REMCycleFile) {
					if (m_objREMCyclesControl.tmrWatch.Enabled) {
						if ((m_objREMCyclesControl.txtTitle.Text != trvNode.Text) | boolClosing) {
							if (MessageBox.Show("The REM Cycle '" + m_objREMCyclesControl.txtTitle.Text + "' is currently playing." + Constants.vbNewLine + "Are you sure you wish to stop it?", "Stop REM Cycle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) {
								return true;
							}
						}
					}
				}

				return false;


			} catch (Exception ex) {
			}
		}

		private void SelectTreeNode()
		{
			try {
				toolSave.Enabled = false;
				toolUpdate.Enabled = false;
				toolDelete.Enabled = false;
				toolPlay.Enabled = false;
				toolPlay.Image = LightenedDream.My.Resources.Function_Play;
				toolPlay.Text = "&Play";
				mnuToolsPlay.Enabled = false;
				toolBack.Enabled = false;
				toolForward.Enabled = false;
				lblStatus.Text = "";

				if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
					pnlContainer.Controls.Clear();
					m_objDreamViewControl.Dock = DockStyle.Fill;
					pnlContainer.Controls.Add(m_objDreamViewControl);
					Application.DoEvents();

					bool locked = true;
					if (!(trvMain.SelectedNode.Parent.Tag) is Categories.Tags.CategoryFile) {
						toolSave.Enabled = true;
						toolDelete.Enabled = true;
						locked = false;
					}

					m_objDreamViewControl.LoadDream(((Dreams.Tags.DreamFile)trvMain.SelectedNode.Tag).Path, locked);
					if (m_objDreamViewControl.Words == 1) {
						lblStatus.Text = m_objDreamViewControl.Words.ToString() + " Word";
					} else {
						lblStatus.Text = m_objDreamViewControl.Words.ToString() + " Words";
					}

					toolPlay.Enabled = true;
					mnuToolsPlay.Enabled = true;
					if (m_objDreamViewControl.Playing) {
						toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
						toolPlay.Text = "&Stop";
					} else {
						toolPlay.Image = LightenedDream.My.Resources.Function_Play;
						toolPlay.Text = "&Play";
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.DreamFile) {
					pnlContainer.Controls.Clear();
					m_objExerciseViewControl.Dock = DockStyle.Fill;
					pnlContainer.Controls.Add(m_objExerciseViewControl);
					Application.DoEvents();
					m_objExerciseViewControl.LoadExercise(((Lucidity.Tags.DreamFile)trvMain.SelectedNode.Tag).Path);
					if (!(trvMain.SelectedNode.Parent.Tag) is Categories.Tags.CategoryFile) {
						toolSave.Enabled = true;
						toolDelete.Enabled = true;
					}
					if (m_objExerciseViewControl.Words == 1) {
						lblStatus.Text = m_objExerciseViewControl.Words.ToString() + " Word";
					} else {
						lblStatus.Text = m_objExerciseViewControl.Words.ToString() + " Words";
					}

					toolPlay.Enabled = true;
					mnuToolsPlay.Enabled = true;
					if (m_objExerciseViewControl.Playing) {
						toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
						toolPlay.Text = "&Stop";
					} else {
						toolPlay.Image = LightenedDream.My.Resources.Function_Play;
						toolPlay.Text = "&Play";
					}
				} else if ((trvMain.SelectedNode.Tag) is Dreams.Tags.MonthFolder) {
					pnlContainer.Controls.Clear();
					m_objMonthListControl.Dock = DockStyle.Fill;
					m_objMonthListControl.LoadMonth(((Dreams.Tags.MonthFolder)trvMain.SelectedNode.Tag).Path, ((Dreams.Tags.MonthFolder)trvMain.SelectedNode.Tag).Year, ((Dreams.Tags.MonthFolder)trvMain.SelectedNode.Tag).Month);
					Application.DoEvents();
					pnlContainer.Controls.Add(m_objMonthListControl);
					if (trvMain.SelectedNode.Nodes.Count == 1) {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Dream";
					} else {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Dreams";
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.MonthFolder) {
					pnlContainer.Controls.Clear();
					m_objExerciseMonthListControl.Dock = DockStyle.Fill;
					m_objExerciseMonthListControl.LoadMonth(((Lucidity.Tags.MonthFolder)trvMain.SelectedNode.Tag).Path, ((Lucidity.Tags.MonthFolder)trvMain.SelectedNode.Tag).Year, ((Lucidity.Tags.MonthFolder)trvMain.SelectedNode.Tag).Month);
					Application.DoEvents();
					pnlContainer.Controls.Add(m_objExerciseMonthListControl);
					if (trvMain.SelectedNode.Nodes.Count == 1) {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Exercise";
					} else {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Exercises";
					}
				} else if ((trvMain.SelectedNode.Tag) is Dreams.Tags.YearFolder) {
					pnlContainer.Controls.Clear();
					m_objYearListControl.Dock = DockStyle.Fill;
					m_objYearListControl.LoadYear(((Dreams.Tags.YearFolder)trvMain.SelectedNode.Tag).Path, ((Dreams.Tags.YearFolder)trvMain.SelectedNode.Tag).Year);
					pnlContainer.Controls.Add(m_objYearListControl);
					if (trvMain.SelectedNode.Nodes.Count == 1) {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Month";
					} else {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Months";
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.YearFolder) {
					pnlContainer.Controls.Clear();
					m_objExerciseYearListControl.Dock = DockStyle.Fill;
					m_objExerciseYearListControl.LoadYear(((Lucidity.Tags.YearFolder)trvMain.SelectedNode.Tag).Path, ((Lucidity.Tags.YearFolder)trvMain.SelectedNode.Tag).Year);
					pnlContainer.Controls.Add(m_objExerciseYearListControl);
					if (trvMain.SelectedNode.Nodes.Count == 1) {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Month";
					} else {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Months";
					}
				} else if ((trvMain.SelectedNode.Tag) is Dreams.Tags.YearsFolder) {
					if (m_boolYearSelected)
						return;
					m_boolYearSelected = true;
					pnlContainer.Controls.Clear();
					m_objYearsListControl.Dock = DockStyle.Fill;
					m_objYearsListControl.LoadYears();
					pnlContainer.Controls.Add(m_objYearsListControl);
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.YearsFolder) {
					pnlContainer.Controls.Clear();
					m_objExerciseYearsListControl.Dock = DockStyle.Fill;
					m_objExerciseYearsListControl.LoadYears();
					pnlContainer.Controls.Add(m_objExerciseYearsListControl);

					// Categories
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFile) {
					pnlContainer.Controls.Clear();
					m_objCategoryViewControl.Dock = DockStyle.Fill;
					m_objCategoryViewControl.LoadCategory(((Categories.Tags.CategoryFile)trvMain.SelectedNode.Tag).Path, ((Categories.Tags.CategoryFile)trvMain.SelectedNode.Tag).Category);
					pnlContainer.Controls.Add(m_objCategoryViewControl);
					if (!(trvMain.SelectedNode.Parent.Tag) is Dreams.Tags.DreamFile) {
						toolSave.Enabled = true;
						toolDelete.Enabled = true;
					}
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
					if (trvMain.SelectedNode.Nodes.Count == 1) {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Entry";
					} else {
						lblStatus.Text = trvMain.SelectedNode.Nodes.Count.ToString() + " Entries";
					}
					pnlContainer.Controls.Clear();
					m_objCategoryListControl.Dock = DockStyle.Fill;
					m_objCategoryListControl.Category = trvMain.SelectedNode.Text;
					m_objCategoryListControl.CategoryFile = ((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path;
					m_objCategoryListControl.LoadCategory();
					pnlContainer.Controls.Add(m_objCategoryListControl);

					toolSave.Enabled = true;
					toolDelete.Enabled = true;
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoriesFolder) {
					pnlContainer.Controls.Clear();
					m_objCategoriesListControl.Dock = DockStyle.Fill;
					m_objCategoriesListControl.LoadCategories();
					pnlContainer.Controls.Add(m_objCategoriesListControl);

					// Lucidity 
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidityFolder) {
					pnlContainer.Controls.Clear();
					m_objLucidityControl.Dock = DockStyle.Fill;
					pnlContainer.Controls.Add(m_objLucidityControl);
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFolder) {
					pnlContainer.Controls.Clear();
					m_objLucidFolderViewControl.Dock = DockStyle.Fill;
					m_objLucidFolderViewControl.LoadFolder(((Lucidity.Tags.LucidItemFolder)trvMain.SelectedNode.Tag).Type);
					pnlContainer.Controls.Add(m_objLucidFolderViewControl);
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.REMCycleFile) {
					pnlContainer.Controls.Clear();
					m_objREMCyclesControl.Dock = DockStyle.Fill;
					m_objREMCyclesControl.LoadREM(((Lucidity.Tags.REMCycleFile)trvMain.SelectedNode.Tag).Path);
					pnlContainer.Controls.Add(m_objREMCyclesControl);
					toolSave.Enabled = true;
					toolDelete.Enabled = true;
					toolPlay.Enabled = true;
					mnuToolsPlay.Enabled = true;
					if (m_objREMCyclesControl.tmrWatch.Enabled) {
						toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
						toolPlay.Text = "&Stop";
					} else {
						toolPlay.Image = LightenedDream.My.Resources.Function_Play;
						toolPlay.Text = "&Play";
					}
					toolBack.Enabled = true;
					toolForward.Enabled = true;
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFile) {
					pnlContainer.Controls.Clear();
					m_objLucidItemControl.Dock = DockStyle.Fill;
					m_objLucidItemControl.LoadFile(((Lucidity.Tags.LucidItemFile)trvMain.SelectedNode.Tag).Path);
					pnlContainer.Controls.Add(m_objLucidItemControl);
					toolSave.Enabled = true;
					toolDelete.Enabled = true;
					toolPlay.Enabled = true;
					mnuToolsPlay.Enabled = true;
					toolBack.Enabled = true;
					toolForward.Enabled = true;
					if (m_objLucidItemControl.Playing()) {
						toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
						toolPlay.Text = "&Stop";
					} else {
						toolPlay.Image = LightenedDream.My.Resources.Function_Play;
						toolPlay.Text = "&Play";
					}
				}

				toolUpdate.Enabled = toolSave.Enabled;

				// Navigation
				if (!m_boolNavigating) {
					m_arrBackHistory.Add(trvMain.SelectedNode);
					if ((m_arrBackHistory.Count >= 1)) {
						toolBack.Enabled = true;
					}
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.SelectTreeNode()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SelectREMCycles()
		{
			trvMain.SelectedNode = trvMain.Nodes["Lucidity"].Nodes["REM Cycles"];
		}

		private void trvMain_AfterSelect(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			SelectTreeNode();
		}

		private void mnuToolNewDream_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewDream();
		}

		private void CreateNewDream()
		{
			// Generate new filename
			string strTitle = "New Dream";
			string strFileName = GetFolder(DateAndTime.Now) + Strings.Format(DateAndTime.Now, "dd") + " " + strTitle + ".ld3";
			int intPos = 2;
			do {
				if ((File.Exists(strFileName))) {
					strTitle = "New Dream " + intPos.ToString();
					strFileName = GetFolder(DateAndTime.Now) + Strings.Format(DateAndTime.Now, "dd") + " " + strTitle + ".ld3";
					intPos += 1;
				} else {
					break; // TODO: might not be correct. Was : Exit Do
				}
			} while (true);

			// Create a blank dream
			string strXml = null;
			strXml = "<Dream>";
			strXml += "<Date>" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "</Date>";
			strXml += "<Time>04:20</Time>";
			if (m_dtLastREMPlayed == null) {
				m_dtLastREMPlayed = DateAndTime.Now;
			}
			strXml += "<Sleep>23:30</Sleep>";
			strXml += "<Awake>06:30</Awake>";
			strXml += "<Title>" + strTitle + "</Title>";
			strXml += "<Lucidity>5</Lucidity>";
			strXml += "<Dream>" + "" + "</Dream>";
			strXml += "<Clarity>" + "" + "</Clarity>";
			strXml += "<Lessons>" + "" + "</Lessons>";
			strXml += "</Dream>";
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(strXml);
			xmlDoc.Save(strFileName);

			// Update Tree   
			TreeNode trvDream = new TreeNode(new FileInfo(strFileName).Name.Replace(".ld3", ""));
			lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(strFileName);
			trvDream.Tag = objDreamTag;
			trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
			trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
			GetDreamFolder(DateAndTime.Now).Nodes.Add(trvDream);

			// Select Dream
			trvMain.SelectedNode = trvDream;
			m_objDreamViewControl.Focus();
		}

		private void CreateNewExercise(bool Random)
		{
			var strSelectedName = "New Exercise";
			var strSelectedTask = "";
			var strSelectedDetails = "";
			var strSelectedLucidity = "1";

			if (Random) {
				// Randomly select Exercise
				XmlDocument xmlDocExercises = new XmlDocument();
				MemoryStream objMemStream = new MemoryStream(lucidcode.LightenedDream.Lucidity.My.Resources.Resources.Exercises);
				xmlDocExercises.Load(objMemStream);
				int intCount = xmlDocExercises.DocumentElement.SelectNodes("Exercise").Count;
				int intExercise = Conversion.Int(VBMath.Rnd() * intCount);
				int intPosition = 0;
				XmlNode xmlNodeExercise = null;

				foreach (XmlNode xmlNodeExercises in xmlDocExercises.DocumentElement.SelectNodes("Exercise")) {
					if (intPosition == intExercise) {
						xmlNodeExercise = xmlNodeExercises;
						strSelectedName = xmlNodeExercise.SelectSingleNode("Title").InnerText;
						strSelectedTask = xmlNodeExercise.SelectSingleNode("Task").InnerText;
						strSelectedLucidity = xmlNodeExercise.SelectSingleNode("Lucidity").InnerText;
						if ((xmlNodeExercise.SelectSingleNode("Details") != null)) {
							strSelectedDetails = xmlNodeExercise.SelectSingleNode("Details").InnerText;
						}
						break; // TODO: might not be correct. Was : Exit For
					}
					intPosition += 1;
				}
			}

			// Generate new filename
			string strTitle = strSelectedName;
			string strFileName = GetFolderExercise(DateAndTime.Now) + Strings.Format(DateAndTime.Now, "dd") + " " + strTitle + ".ld3";
			int intPos = 2;
			do {
				if ((File.Exists(strFileName))) {
					strTitle = strSelectedName + " " + intPos.ToString();
					strFileName = GetFolderExercise(DateAndTime.Now) + Strings.Format(DateAndTime.Now, "dd") + " " + strTitle + ".ld3";
					intPos += 1;
				} else {
					break; // TODO: might not be correct. Was : Exit Do
				}
			} while (true);

			// Create a new Exercise
			string strXml = null;
			strXml = "<Exercise>";
			strXml += "<Date>" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "</Date>";
			strXml += "<Time>" + Strings.Format(DateAndTime.Now, "HH:mm") + "</Time>";
			strXml += "<Title>" + strSelectedName + "</Title>";
			strXml += "<Task>" + strSelectedTask + "</Task>";
			strXml += "<Details>" + strSelectedDetails + "</Details>";
			strXml += "<Lucidity>" + strSelectedLucidity + "</Lucidity>";
			strXml += "</Exercise>";

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(strXml);
			xmlDoc.Save(strFileName);

			// Update Tree   
			TreeNode trvDream = new TreeNode(new FileInfo(strFileName).Name.Replace(".ld3", ""));
			lucidcode.LightenedDream.Lucidity.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Lucidity.Tags.DreamFile(strFileName);
			trvDream.Tag = objDreamTag;
			trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Exercise");
			trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Exercise");
			GetExerciseFolder(DateAndTime.Now).Nodes.Add(trvDream);

			// Select Exercise
			trvMain.SelectedNode = trvDream;
			m_objExerciseViewControl.Focus();
		}

		private string GetFolder(DateTime FolderDate)
		{
			if (!Directory.Exists(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy"))) {
				Directory.CreateDirectory(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy"));
			}
			if (!Directory.Exists(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"))) {
				Directory.CreateDirectory(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"));
			}
			return m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM") + "\\";
		}

		private string GetFolderExercise(DateTime FolderDate)
		{
			if (!Directory.Exists(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy"))) {
				Directory.CreateDirectory(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy"));
			}
			if (!Directory.Exists(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"))) {
				Directory.CreateDirectory(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"));
			}
			return m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM") + "\\";
		}

		private TreeNode GetDreamFolder(DateTime FolderDate)
		{
			if (FindNode(trvMain.Nodes[0], (Strings.Format(FolderDate, "yyyy"))) == null) {
				// Create a new year node
				TreeNode trvYearNode = trvMain.Nodes[0].Nodes.Add(Strings.Format(FolderDate, "yyyy"));
				lucidcode.LightenedDream.Dreams.Tags.YearFolder objYearTag = new lucidcode.LightenedDream.Dreams.Tags.YearFolder(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy"), Strings.Format(FolderDate, "yyyy"));
				trvYearNode.Tag = objYearTag;
			}
			if (FindNode(FindNode(trvMain.Nodes[0], Strings.Format(FolderDate, "yyyy")), Strings.Format(FolderDate, "MM")) == null) {
				// Create a new month node
				TreeNode trvMonthNode = FindNode(trvMain.Nodes[0], (Strings.Format(FolderDate, "yyyy"))).Nodes.Add(Strings.Format(FolderDate, "MM"));
				lucidcode.LightenedDream.Dreams.Tags.MonthFolder objMonthTag = new lucidcode.LightenedDream.Dreams.Tags.MonthFolder(m_strPath + "Dreams\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"), Strings.Format(FolderDate, "yyyy"), Strings.Format(FolderDate, "MM"));
				trvMonthNode.Tag = objMonthTag;
			}
			return FindNode(FindNode(trvMain.Nodes[0], Strings.Format(FolderDate, "yyyy")), Strings.Format(FolderDate, "MM"));
		}

		private TreeNode GetExerciseFolder(DateTime FolderDate)
		{
			if (FindNode(trvMain.Nodes[2].Nodes[4], (Strings.Format(FolderDate, "yyyy"))) == null) {
				// Create a new year node
				TreeNode trvYearNode = trvMain.Nodes[2].Nodes[4].Nodes.Add(Strings.Format(FolderDate, "yyyy"));
				lucidcode.LightenedDream.Lucidity.Tags.YearFolder objYearTag = new lucidcode.LightenedDream.Lucidity.Tags.YearFolder(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy"), Strings.Format(FolderDate, "yyyy"));
				trvYearNode.Tag = objYearTag;
			}
			if (FindNode(FindNode(trvMain.Nodes[2].Nodes[4], Strings.Format(FolderDate, "yyyy")), Strings.Format(FolderDate, "MM")) == null) {
				// Create a new month node
				TreeNode trvMonthNode = FindNode(trvMain.Nodes[2].Nodes[4], (Strings.Format(FolderDate, "yyyy"))).Nodes.Add(Strings.Format(FolderDate, "MM"));
				lucidcode.LightenedDream.Lucidity.Tags.MonthFolder objMonthTag = new lucidcode.LightenedDream.Lucidity.Tags.MonthFolder(m_strPath + "Lucidity\\Exercises\\" + Strings.Format(FolderDate, "yyyy") + "\\" + Strings.Format(FolderDate, "MM"), Strings.Format(FolderDate, "yyyy"), Strings.Format(FolderDate, "MM"));
				trvMonthNode.Tag = objMonthTag;
			}
			return FindNode(FindNode(trvMain.Nodes[2].Nodes[4], Strings.Format(FolderDate, "yyyy")), Strings.Format(FolderDate, "MM"));
		}

		private void mnuToolNewCategoryFolder_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewCategoryFolder();
		}

		private void mnuToolNewCategoryItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewCategoryItem();
		}

		private class SafeFilename
		{
			public string Filename;
			public string Guid;
		}


		private void CreateNewCategoryFolder()
		{
			string strCategory = "";

			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				strCategory = ((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path + "\\New Category";
			} else {
				CreateCustomCategory();
				return;
			}

			if (Directory.Exists(strCategory)) {
				return;
			}

			Directory.CreateDirectory(strCategory);

			TreeNode trvCategoryFolder = new TreeNode(new DirectoryInfo(strCategory).Name);
			lucidcode.LightenedDream.Categories.Tags.CategoryFolder objCategoryFolderTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFolder(strCategory);
			trvCategoryFolder.Tag = objCategoryFolderTag;
			if (lstImgTrv.Images.IndexOfKey("Folder." + strCategory) != -1) {
				trvCategoryFolder.ImageIndex = 0;
				trvCategoryFolder.SelectedImageIndex = 1;
			}

			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				trvMain.SelectedNode.Nodes.Add(trvCategoryFolder);
			} else {
				trvMain.Nodes[1].Nodes.Add(trvCategoryFolder);
			}

			trvCategoryFolder.EnsureVisible();
			trvMain.SelectedNode = trvCategoryFolder;
		}

		private void CreateNewCategoryItem()
		{
			string strCategory = "";

			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				strCategory = ((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path + "\\New Category Item.ld3";
			}

			int intPos = 2;
			do {
				if ((File.Exists(strCategory))) {
					if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
						strCategory = ((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path + "\\New Category Item " + intPos.ToString() + ".ld3";
					}
					intPos += 1;
				} else {
					break; // TODO: might not be correct. Was : Exit Do
				}
			} while (true);

			string strXml = null;
			strXml = "<Category>";
			strXml += "<Name></Name>";
			strXml += "<Description></Description>";
			strXml += "<Names></Names>";
			strXml += "<Dreams>";
			strXml += "</Dreams>";
			strXml += "</Category>";

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(strXml);

			xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText = "New Category Item";
			xmlDoc.Save(strCategory);

			// Update Tree   
			TreeNode trvCategoryItem = new TreeNode(new FileInfo(strCategory).Name.Replace(".ld3", ""));
			lucidcode.LightenedDream.Categories.Tags.CategoryFile objCategoryTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(strCategory, "");
			trvCategoryItem.Tag = objCategoryTag;
			trvCategoryItem.ImageIndex = 16;
			trvCategoryItem.SelectedImageIndex = 16;

			// Add Item
			if (FindNode(trvMain.Nodes[1], new FileInfo(((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path).Name) != null) {
				FindNode(trvMain.Nodes[1], new FileInfo(((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path).Name).Nodes.Add(trvCategoryItem);
			} else {
				trvMain.SelectedNode.Nodes.Add(trvCategoryItem);
			}

			// Select Item
			trvMain.SelectedNode = trvCategoryItem;

			// Load each dream
			System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
			xmlCategory.Load(strCategory);
			foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
				TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
				lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
				trvDream.Tag = objDreamTag;
				trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
				trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
				trvCategoryItem.Nodes.Add(trvDream);
				// Add the loading node
				TreeNode trvLoading = new TreeNode("Loading Categories...");
				trvDream.Nodes.Add(trvLoading);
			}

			m_objCategoryViewControl.Focus();

		}

		private void CreateNewCategory(string Path, string Name = "")
		{
			try {
				List<SafeFilename> safeFilenames = new List<SafeFilename>();

				if (string.IsNullOrEmpty(Name)) {
					Name = "New " + new DirectoryInfo(Path).Name;
				}
				string strTitle = Name;
				string strFileName = null;
				strFileName = Path + "\\" + strTitle + ".ld3";

				int intPos = 2;
				do {
					if ((File.Exists(strFileName))) {
						strTitle = "New " + new DirectoryInfo(Path).Name + " " + intPos.ToString();
						strFileName = Path + "\\" + strTitle + ".ld3";
						intPos += 1;
					} else {
						break; // TODO: might not be correct. Was : Exit Do
					}
				} while (true);

				string strXml = null;
				strXml = "<Category>";
				strXml += "<Name></Name>";
				strXml += "<Description></Description>";
				strXml += "<Names></Names>";
				strXml += "<Dreams>";
				foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {
					strXml += "<Year Value='" + new DirectoryInfo(strYearFolder).Name + "'>";
					// Load each month
					foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
						strXml += "<Month Value='" + new DirectoryInfo(strMonthFolder).Name + "'>";
						// Load each dream
						foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
							XmlDocument xmlDream = new XmlDocument();
							xmlDream.Load(strDreamFile);

							if ((xmlDream.DocumentElement.SelectSingleNode("Dream").InnerText.ToLower().Contains(strTitle.ToLower()))) {
								SafeFilename safeFilename = new SafeFilename();
								safeFilename.Guid = Guid.NewGuid().ToString();
								safeFilename.Filename = xmlDream.DocumentElement.SelectSingleNode("Title").InnerText;

								safeFilenames.Add(safeFilename);

								strXml += "<Dream Date='" + xmlDream.DocumentElement.SelectSingleNode("Date").InnerText + "' Title='" + safeFilename.Guid + "' />";
							}
						}
						strXml += "</Month>";
					}
					strXml += "</Year>";
				}
				strXml += "</Dreams>";
				strXml += "</Category>";

				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(strXml);

				xmlDoc.DocumentElement.SelectSingleNode("Name").InnerText = strTitle;

				foreach (XmlNode xmlDream in xmlDoc.DocumentElement.SelectNodes("//Dream")) {
					foreach (SafeFilename safeFilename in safeFilenames) {
						if (safeFilename.Guid == xmlDream.Attributes["Title"].InnerText) {
							xmlDream.Attributes["Title"].InnerText = safeFilename.Filename;
						}
					}
				}

				xmlDoc.Save(strFileName);

				// Update Tree   
				TreeNode trvCategoryItem = new TreeNode(new FileInfo(strFileName).Name.Replace(".ld3", ""));
				lucidcode.LightenedDream.Categories.Tags.CategoryFile objCategoryTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(strFileName, Name);
				trvCategoryItem.Tag = objCategoryTag;
				trvCategoryItem.ImageIndex = 16;
				trvCategoryItem.SelectedImageIndex = 16;

				// Add Item
				string[] relativePath = Path.Replace(m_strPath + "Categories", "").Split("\\");
				TreeNode parentNode = trvMain.Nodes[1];
				foreach (string categoryFolder in relativePath) {
					if (!string.IsNullOrEmpty(categoryFolder)) {
						parentNode = FindNode(parentNode, categoryFolder);
					}
				}

				parentNode.Nodes.Add(trvCategoryItem);

				// Select Item
				trvMain.SelectedNode = trvCategoryItem;

				// Load each dream
				System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
				xmlCategory.Load(strFileName);
				foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
					TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
					lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
					trvDream.Tag = objDreamTag;
					trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
					trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
					trvCategoryItem.Nodes.Add(trvDream);
					// Add the loading node
					TreeNode trvLoading = new TreeNode("Loading Categories...");
					trvDream.Nodes.Add(trvLoading);
				}

				m_objCategoryViewControl.Focus();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message + "/r/n" + "Stack trace: " + ex.StackTrace, "LightenedDream.Categories.Create()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private TreeNode FindNode(TreeNode Parent, string Value)
		{
			foreach (TreeNode trvNode in Parent.Nodes) {
				if (trvNode.Text.ToLower() == Value.ToLower()) {
					return trvNode;
				}
			}
			return null;
		}

		private void toolSave_Click(System.Object sender, System.EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			try {
				ShowSearching();
				Application.DoEvents();

				// Disabe the form
				Enabled = false;

				if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
					m_objDreamViewControl.Save();

					var dreamTitle = new FileInfo(m_objDreamViewControl.FileName).Name.Replace(".ld3", "");

					// Check for special characters in the title and load them from within the file
					if (dreamTitle.Contains("_")) {
						XmlDocument xmlDream = new XmlDocument();
						xmlDream.Load(m_objDreamViewControl.FileName);
						dreamTitle = dreamTitle.Substring(0, 3) + xmlDream.DocumentElement.SelectSingleNode("Title").InnerText;
					}

					trvMain.SelectedNode.Text = dreamTitle;
					trvMain.SelectedNode.Tag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_objDreamViewControl.FileName);
					TreeNode trvNewFolder = GetDreamFolder(m_objDreamViewControl.dtDate.Value);
					if ((!object.ReferenceEquals(trvNewFolder, trvMain.SelectedNode.Parent))) {
						TreeNode trvTemp = trvMain.SelectedNode;
						trvTemp.Remove();
						trvNewFolder.Nodes.Add(trvTemp);
						trvMain.SelectedNode = trvTemp;
					}
					ReloadDreamNodes(trvMain.SelectedNode);
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.DreamFile) {
					m_objExerciseViewControl.Save();
					//m_objDreamViewControl.UpdateView()
					trvMain.SelectedNode.Text = new FileInfo(m_objExerciseViewControl.FileName).Name.Replace(".ld3", "");
					trvMain.SelectedNode.Tag = new lucidcode.LightenedDream.Lucidity.Tags.DreamFile(m_objExerciseViewControl.FileName);
					TreeNode trvNewFolder = GetExerciseFolder(m_objExerciseViewControl.dtDate.Value);
					if ((!object.ReferenceEquals(trvNewFolder, trvMain.SelectedNode.Parent))) {
						TreeNode trvTemp = trvMain.SelectedNode;
						trvTemp.Remove();
						trvNewFolder.Nodes.Add(trvTemp);
						trvMain.SelectedNode = trvTemp;
					}
					//ReloadDreamNodes(trvMain.SelectedNode)
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
					m_objCategoryListControl.Save();
					if (m_objCategoryListControl.txtName.Text != trvMain.SelectedNode.Text) {
						trvMain.SelectedNode.Text = m_objCategoryListControl.txtName.Text;
						((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path = m_objCategoryListControl.CategoryFile;
					}
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFile) {
					m_objCategoryViewControl.Save();
					if (m_objCategoryViewControl.txtName.Text != trvMain.SelectedNode.Text) {
						// !ToDo: Update Tree
						trvMain.SelectedNode.Text = m_objCategoryViewControl.txtName.Text;
						((Categories.Tags.CategoryFile)trvMain.SelectedNode.Tag).Path = m_objCategoryViewControl.FileName;

						// Load each dream
						System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
						xmlCategory.Load(m_objCategoryViewControl.FileName);
						trvMain.SelectedNode.Nodes.Clear();
						foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
							TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
							lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
							trvDream.Tag = objDreamTag;
							trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
							trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
							trvMain.SelectedNode.Nodes.Add(trvDream);
							// Add the loading node
							TreeNode trvLoading = new TreeNode("Loading Categories...");
							trvDream.Nodes.Add(trvLoading);
						}
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFile) {
					m_objLucidItemControl.Save(((Lucidity.Tags.LucidItemFile)trvMain.SelectedNode.Tag).Type);
					// Update Tree
					trvMain.SelectedNode.Text = new FileInfo(m_objLucidItemControl.FileName).Name.Replace(".ld3", "");
					((Lucidity.Tags.LucidItemFile)trvMain.SelectedNode.Tag).Path = m_objLucidItemControl.FileName;
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.REMCycleFile) {
					m_objREMCyclesControl.Save();
					// Update Tree
					trvMain.SelectedNode.Text = new FileInfo(m_objREMCyclesControl.FileName).Name.Replace(".ld3", "");
					((Lucidity.Tags.REMCycleFile)trvMain.SelectedNode.Tag).Path = m_objREMCyclesControl.FileName;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Edit()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Enabled = true;
			HideSearching();
		}

		private void toolDelete_Click(System.Object sender, System.EventArgs e)
		{
			Delete();
		}

		private void Delete()
		{
			try {
				if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
					if (MessageBox.Show("Are you sure you wish to delete the dream '" + trvMain.SelectedNode.Text + "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						File.Delete(((Dreams.Tags.DreamFile)trvMain.SelectedNode.Tag).Path);
						if (trvMain.SelectedNode.Parent.Nodes.Count == 1) {
							// It is the last dream in the month, delete it
							Directory.Delete(((Dreams.Tags.MonthFolder)trvMain.SelectedNode.Parent.Tag).Path);
							if (trvMain.SelectedNode.Parent.Parent.Nodes.Count == 1) {
								// It is the last dream in the year, delete it
								Directory.Delete(((Dreams.Tags.YearFolder)trvMain.SelectedNode.Parent.Parent.Tag).Path);
								trvMain.SelectedNode.Parent.Parent.Remove();
							} else {
								trvMain.SelectedNode.Parent.Remove();
							}
						} else {
							trvMain.SelectedNode.Remove();
						}
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.DreamFile) {
					if (MessageBox.Show("Are you sure you wish to delete the Exercise '" + trvMain.SelectedNode.Text + "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						File.Delete(((Lucidity.Tags.DreamFile)trvMain.SelectedNode.Tag).Path);
						if (trvMain.SelectedNode.Parent.Nodes.Count == 1) {
							// It is the last Exercise in the month, delete it
							Directory.Delete(((Lucidity.Tags.MonthFolder)trvMain.SelectedNode.Parent.Tag).Path);
							if (trvMain.SelectedNode.Parent.Parent.Nodes.Count == 1) {
								// It is the last dream in the year, delete it
								Directory.Delete(((Lucidity.Tags.YearFolder)trvMain.SelectedNode.Parent.Parent.Tag).Path);
								trvMain.SelectedNode.Parent.Parent.Remove();
							} else {
								trvMain.SelectedNode.Parent.Remove();
							}
						} else {
							trvMain.SelectedNode.Remove();
						}
					}
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
					if (MessageBox.Show("Are you sure you wish to delete '" + trvMain.SelectedNode.Text + "'?" + Constants.vbNewLine + "And any files in it?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						Directory.Delete(((Categories.Tags.CategoryFolder)trvMain.SelectedNode.Tag).Path, true);
						trvMain.SelectedNode.Remove();
					}
				} else if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFile) {
					if (MessageBox.Show("Are you sure you wish to delete '" + trvMain.SelectedNode.Text + "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						File.Delete(((Categories.Tags.CategoryFile)trvMain.SelectedNode.Tag).Path);
						trvMain.SelectedNode.Remove();
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFile) {
					if (MessageBox.Show("Are you sure you wish to delete '" + trvMain.SelectedNode.Text + "'", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						File.Delete(((Lucidity.Tags.LucidItemFile)trvMain.SelectedNode.Tag).Path);
						trvMain.SelectedNode.Remove();
					}
				} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.REMCycleFile) {
					if (MessageBox.Show("Are you sure you wish to delete '" + trvMain.SelectedNode.Text + "'?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
						File.Delete(((Lucidity.Tags.REMCycleFile)trvMain.SelectedNode.Tag).Path);
						trvMain.SelectedNode.Remove();
					}
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Delete()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void trvMain_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) {
				Delete();
			}
		}

		private void trvMain_AfterExpand(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if ((e.Node.Tag) is Dreams.Tags.MonthFolder) {
				e.Node.ImageIndex = 1;
			} else if ((e.Node.Tag) is Dreams.Tags.YearFolder) {
				e.Node.ImageIndex = 1;
			} else if ((e.Node.Tag) is Dreams.Tags.DreamsFolder) {
				e.Node.ImageIndex = 1;
			} else if ((e.Node.Tag) is Categories.Tags.CategoryFolder) {
				if (lstImgTrv.Images.IndexOfKey("Folder." + e.Node.Text) != -1) {
					e.Node.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder.Open." + e.Node.Text);
				} else {
					e.Node.ImageIndex = 1;
				}
			} else if ((e.Node.Tag) is Categories.Tags.CategoriesFolder) {
				e.Node.ImageIndex = 1;
			}
		}

		private void trvMain_AfterCollapse(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if ((e.Node.Tag) is Dreams.Tags.MonthFolder) {
				e.Node.ImageIndex = 0;
			} else if ((e.Node.Tag) is Dreams.Tags.YearFolder) {
				e.Node.ImageIndex = 0;
			} else if ((e.Node.Tag) is Dreams.Tags.DreamsFolder) {
				e.Node.ImageIndex = 0;
			} else if ((e.Node.Tag) is Categories.Tags.CategoryFolder) {
				if (lstImgTrv.Images.IndexOfKey("Folder." + e.Node.Text) != -1) {
					e.Node.ImageIndex = lstImgTrv.Images.IndexOfKey("Folder." + e.Node.Text);
				} else {
					e.Node.ImageIndex = 0;
				}
			} else if ((e.Node.Tag) is Categories.Tags.CategoriesFolder) {
				e.Node.ImageIndex = 0;
			}
		}


		private void toolNew_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void trvMain_DragEnter(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()")) {
				e.Effect = DragDropEffects.Link;
			} else {
				e.Effect = DragDropEffects.None;
			}
		}

		private void trvMain_DragDrop(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			ListViewItem myItem = null;
			ListViewItem[] myItems = e.Data.GetData("System.Windows.Forms.ListViewItem()");
			int i = 0;

			foreach (ListViewItem myItem_loopVariable in myItems) {
				myItem = myItem_loopVariable;
				// Add the item to the target list.
				CreateNewCategory(trvMain.SelectedNode.Text.Substring(0, trvMain.SelectedNode.Text.Length - 1), myItems[i].Text.Substring(0, 1).ToUpper() + myItems[i].Text.Substring(1));

			}
		}

		private void trvMain_DragOver(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			TreeView tree = (TreeView)sender;

			e.Effect = DragDropEffects.None;

			//If Not e.Data.GetData(GetType(TreeNode)) Is Nothing Then
			if (e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()")) {
				Point pt = new Point(e.X, e.Y);
				pt = tree.PointToClient(pt);
				TreeNode node = tree.GetNodeAt(pt);
				if ((node != null)) {
					if ((node.Tag) is Categories.Tags.CategoryFolder) {
						e.Effect = DragDropEffects.Link;
						node.EnsureVisible();
						m_boolNavigating = true;
						tree.SelectedNode = node;
						m_boolNavigating = false;
					}
					if (node.Text == "Categories") {
						//e.Effect = DragDropEffects.Link
						//tree.SelectedNode = node
						node.Expand();
					}
				}
			}
		}

		private void CategoryCreated(string Category, string Name, string FileName)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Category) {
					trvMain.SelectedNode = trvNode;
				}
			}

			TreeNode trvCategory = new TreeNode(Name);
			lucidcode.LightenedDream.Categories.Tags.CategoryFile objCategoryTag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(FileName, Category);
			objCategoryTag.Category = Category;
			trvCategory.Tag = objCategoryTag;
			trvCategory.ImageIndex = 16;
			trvCategory.SelectedImageIndex = 16;
			if (lstImgTrv.Images.IndexOfKey("File." + Category) != -1) {
				trvCategory.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + Category);
				trvCategory.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + Category);
			}
			FindNode(trvMain.Nodes[1], Category).Nodes.Add(trvCategory);
			m_arrCategories.Add(trvCategory.Text);

			// Load each dream
			System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
			xmlCategory.Load(FileName);
			foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
				TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
				lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
				trvDream.Tag = objDreamTag;
				trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
				trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
				trvCategory.Nodes.Add(trvDream);
				// Add the loading node
				TreeNode trvLoading = new TreeNode("Loading Categories...");
				trvDream.Nodes.Add(trvLoading);
			}

			//ReloadDreamNodes(trvMain.SelectedNode)
		}

		private void PlayingStopped()
		{
			if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
				toolPlay.Image = LightenedDream.My.Resources.Function_Play;
				toolPlay.Text = "&Play";
			}
		}

		private void CategorySelected(string Category)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Category) {
					trvMain.SelectedNode = trvNode;
				}
			}
		}

		private void DreamSelected(string Dream)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Dream) {
					trvMain.SelectedNode = trvNode;
				}
			}
		}

		private void ExerciseDreamSelected(string Dream)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Dream) {
					trvMain.SelectedNode = trvNode;
				}
			}
		}

		private void SelectDream(string DreamDate, string Dream)
		{
			//For Each trvNode As TreeNode In trvMain.SelectedNode.Nodes
			//  If trvNode.Text = DreamDate & " " & Dream Then
			//    trvMain.SelectedNode = trvNode
			//  End If
			//Next
			//Return

			string[] arrMonth = DreamDate.Split("-");
			if (FindNode(trvMain.Nodes[0], arrMonth[0]) != null) {
				if (FindNode(FindNode(trvMain.Nodes[0], arrMonth[0]), arrMonth[1]) != null) {
					if (FindNode(FindNode(FindNode(trvMain.Nodes[0], arrMonth[0]), arrMonth[1]), arrMonth[2] + " " + Dream) != null) {
						trvMain.SelectedNode = FindNode(FindNode(FindNode(trvMain.Nodes[0], arrMonth[0]), arrMonth[1]), arrMonth[2] + " " + Dream);
					}
				}
			}
		}

		private void MonthSelected(string Month)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Month) {
					trvMain.SelectedNode = trvNode;
				}
			}
		}

		private void ExerciseMonthSelected(string Month)
		{
			foreach (TreeNode trvNode in trvMain.SelectedNode.Nodes) {
				if (trvNode.Text == Month) {
					trvMain.SelectedNode = trvNode;
				}
			}
		}

		private void SearchMonthSelected(string Month)
		{
			string[] arrMonth = Month.Split("-");
			if (FindNode(trvMain.Nodes[0], arrMonth[0]) != null) {
				if (FindNode(FindNode(trvMain.Nodes[0], arrMonth[0]), arrMonth[1]) != null) {
					trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes[0], arrMonth[0]), arrMonth[1]);
				}
			}
		}

		private void ExercisesearchMonthSelected(string Month)
		{
			string[] arrMonth = Month.Split("-");
			if (FindNode(trvMain.Nodes[2].Nodes[4], arrMonth[0]) != null) {
				if (FindNode(FindNode(trvMain.Nodes[2].Nodes[4], arrMonth[0]), arrMonth[1]) != null) {
					trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes[2].Nodes[4], arrMonth[0]), arrMonth[1]);
				}
			}
		}

		private void SearchCategoryFileSelected(string CategoryItem)
		{
			string[] relativePath = CategoryItem.Replace(m_strPath + "Categories", "").Split("\\");
			TreeNode parentNode = trvMain.Nodes[1];
			foreach (string categoryFolder in relativePath) {
				if (!string.IsNullOrEmpty(categoryFolder)) {
					parentNode = FindNode(parentNode, categoryFolder.Replace(".ld3", ""));
				}
			}
			trvMain.SelectedNode = parentNode;
		}

		private void SearchCategoryFileCreated(string Category, string Item)
		{
			CreateNewCategory(Category, Item);
		}

		private void DreamSignCategoryFileCreated(string Category, string Item)
		{
			CreateNewCategory(Category, Item);
			trvMain.SelectedNode = trvMain.Nodes[0];
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objDreamSignListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objDreamSignListControl);
		}

		private void LucidItemSelected(string Category, string FileName)
		{
			if (FindNode(trvMain.Nodes[2], Category) != null) {
				if (FindNode(FindNode(trvMain.Nodes[2], Category), FileName) != null) {
					trvMain.SelectedNode = FindNode(FindNode(trvMain.Nodes[2], Category), FileName);
				}
			}
		}

		private void LucidFolderSelected(string Category)
		{
			if (FindNode(trvMain.Nodes[2], Category) != null) {
				trvMain.SelectedNode = FindNode(trvMain.Nodes[2], Category);
			}
		}

		private void toolBack_Click(System.Object sender, System.EventArgs e)
		{
			m_boolNavigating = true;
			m_arrForwardHistory.Add(trvMain.SelectedNode);
			toolForward.Enabled = true;
			trvMain.SelectedNode = m_arrBackHistory[m_arrBackHistory.Count - 2];
			m_arrBackHistory.Remove(m_arrBackHistory[m_arrBackHistory.Count - 2]);
			if (m_arrBackHistory.Count <= 1) {
				toolBack.Enabled = false;
				m_arrBackHistory.Clear();
				m_arrBackHistory.Add(trvMain.SelectedNode);
			}
			m_boolNavigating = false;
		}

		private void toolForward_Click(System.Object sender, System.EventArgs e)
		{
			trvMain.SelectedNode = m_arrForwardHistory[m_arrForwardHistory.Count - 1];
			m_arrForwardHistory.Remove(m_arrForwardHistory[m_arrForwardHistory.Count - 1]);
			if (m_arrForwardHistory.Count == 0) {
				toolForward.Enabled = false;
			}
		}

		private void toolUpdate_Click(System.Object sender, System.EventArgs e)
		{
			Save();
			//  UpdateDatabase()
		}

		private void UpdateDatabase()
		{
			pnlContainer.Controls.Clear();
			m_objDreamViewControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objUpdateControl);
			m_objUpdateControl.UpdateDatabase();
		}

		private void toolCategories_Click(System.Object sender, System.EventArgs e)
		{
			if (FindNode(trvMain.Nodes[1], ((ToolStripButton)sender).Tag) != null) {
				trvMain.SelectedNode = FindNode(trvMain.Nodes[1], ((ToolStripButton)sender).Tag);
			}
		}

		private void toolPlay_Click(System.Object sender, System.EventArgs e)
		{
			PlayLucid();
		}


		private void PlayLucid()
		{

			if ((trvMain.SelectedNode.Tag) is Dreams.Tags.DreamFile) {
				if (m_objDreamViewControl.Playing) {
					m_objDreamViewControl.StopPlaying();
					toolPlay.Image = LightenedDream.My.Resources.Function_Play;
					toolPlay.Text = "&Play";
				} else {
					m_objDreamViewControl.Play();
					toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
					toolPlay.Text = "&Stop";
				}


			} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.REMCycleFile) {
				if (m_objREMCyclesControl.tmrWatch.Enabled) {
					m_objREMCyclesControl.StopRunning();
					toolPlay.Image = LightenedDream.My.Resources.Function_Play;
					toolPlay.Text = "&Play";
				} else {
					// Play
					FullScreenForm formFullScreen = new FullScreenForm();
					formFullScreen.pnlContainer.Controls.Add(m_objREMCyclesControl);
					m_objREMCyclesControl.Play();
					formFullScreen.Location = new Point(0, 0);
					formFullScreen.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
					formFullScreen.ShowDialog();
					pnlContainer.Controls.Add(m_objREMCyclesControl);
					m_dtLastREMPlayed = DateTime.Now;
					toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
					toolPlay.Text = "&Stop";
				}


			} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFile) {
				if (m_objLucidItemControl.Playing()) {
					m_objLucidItemControl.StopRunning();
					toolPlay.Image = LightenedDream.My.Resources.Function_Play;
					toolPlay.Text = "&Play";
				} else {
					if (m_objLucidItemControl.Play()) {
						toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
						toolPlay.Text = "&Stop";
					}
				}


			} else if ((trvMain.SelectedNode.Tag) is Lucidity.Tags.LucidItemFolder) {
				if (m_objLucidFolderViewControl.Playing) {
					toolPlay.Image = LightenedDream.My.Resources.Function_Play;
					toolPlay.Text = "&Play";
				} else {
					toolPlay.Image = LightenedDream.My.Resources.Function_Stop;
					toolPlay.Text = "&Stop";
				}

			}
		}

		private void trvMain_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			ExpandTree(e);
		}

		private void ExpandTree(System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			if ((e.Node.Tag) is Dreams.Tags.DreamFile) {
				ReloadDreamNodes(e.Node);
			} else if ((e.Node.Tag) is Categories.Tags.CategoryFile) {
				ReloadCatgeoryNodes(e.Node);
			}
		}

		private void ReloadDreamNodes(TreeNode trvNode)
		{
			bool boolExpanded = false;
			boolExpanded = trvNode.IsExpanded;
			trvNode.Nodes.Clear();
			System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
			xmlDoc.Load(((Dreams.Tags.DreamFile)trvNode.Tag).Path);
			foreach (XmlNode XmlNode in xmlDoc.DocumentElement.SelectNodes("Categories")) {
				if (XmlNode.Name != "Unassigned") {
					TreeNode trvCategory = new TreeNode(XmlNode.InnerText);
					trvCategory.Tag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(m_strPath + "Categories\\" + XmlNode.Name + "\\" + XmlNode.InnerText + ".ld3", XmlNode.Name);
					trvCategory.ImageIndex = 16;
					trvCategory.SelectedImageIndex = 16;
					trvNode.Nodes.Add(trvCategory);

					TreeNode trvLoading = new TreeNode("Loading Categories...");
					trvCategory.Nodes.Add(trvLoading);
				}
			}

			foreach (XmlNode XmlNode in xmlDoc.DocumentElement.SelectNodes("SubCategories/Category")) {
				TreeNode trvCategory = new TreeNode(XmlNode.InnerText);
				trvCategory.Tag = new lucidcode.LightenedDream.Categories.Tags.CategoryFile(m_strPath + "Categories\\" + XmlNode.Attributes["Path"].InnerText + "\\" + XmlNode.InnerText + ".ld3", XmlNode.Attributes["Path"].InnerText);
				trvCategory.ImageIndex = 16;
				trvCategory.SelectedImageIndex = 16;
				trvNode.Nodes.Add(trvCategory);

				TreeNode trvLoading = new TreeNode("Loading Categories...");
				trvCategory.Nodes.Add(trvLoading);
			}

			if (boolExpanded)
				trvNode.Expand();
		}

		private void ReloadCatgeoryNodes(TreeNode trvNode)
		{
			try {
				bool boolExpanded = false;
				boolExpanded = trvNode.IsExpanded;
				trvNode.Nodes.Clear();

				// Make sure it is not a sub category
				string strFileName = ((Categories.Tags.CategoryFile)trvNode.Tag).Path;
				if (!File.Exists(strFileName)) {
					string strSubName = strFileName.Replace(m_strPath + "Categories\\" + ((Categories.Tags.CategoryFile)trvNode.Tag).Category + "\\", "").Replace(".ld3", "");
					foreach (string strSubFile_loopVariable in Directory.GetFiles(m_strPath + "Categories\\" + ((Categories.Tags.CategoryFile)trvNode.Tag).Category, "*.ld3")) {
						strSubFile = strSubFile_loopVariable;
						bool boolFoundSub = false;
						XmlDocument xmlDocSibling = new XmlDocument();
						xmlDocSibling.Load(strSubFile);
						foreach (XmlNode xmlWord in xmlDocSibling.DocumentElement.SelectNodes("Names/Name")) {
							if (strSubName == xmlWord.InnerText) {
								strFileName = strSubFile;
								boolFoundSub = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}
						if (boolFoundSub)
							break; // TODO: might not be correct. Was : Exit For
					}
				}

				System.Xml.XmlDocument xmlCategory = new System.Xml.XmlDocument();
				xmlCategory.Load(strFileName);
				foreach (XmlNode xmlDreamNode in xmlCategory.DocumentElement.SelectNodes("//Dream")) {
					if (Strings.Format(Convert.ToDateTime(xmlDreamNode.Attributes["Date"].InnerText), "dd") + " " + xmlDreamNode.Attributes["Title"].InnerText != trvNode.Parent.Text) {
						TreeNode trvDream = new TreeNode(xmlDreamNode.Attributes["Date"].InnerText + " " + xmlDreamNode.Attributes["Title"].InnerText);
						lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(m_strPath + "Dreams\\" + xmlDreamNode.Attributes["Date"].InnerText.Replace("-", "/") + " " + m_objDreamViewControl.SafeFilename(xmlDreamNode.Attributes["Title"].InnerText) + ".ld3");
						trvDream.Tag = objDreamTag;
						trvDream.ImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
						trvDream.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("Dream");
						trvNode.Nodes.Add(trvDream);
						// Add the loading node
						TreeNode trvLoading = new TreeNode("Loading Categories...");
						trvDream.Nodes.Add(trvLoading);
					}
				}
				if (boolExpanded)
					trvNode.Expand();
			} catch (Exception ex) {
			}
		}

		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void toolLucidity_Click(System.Object sender, System.EventArgs e)
		{
			SelectLucidItem(((ToolStripButton)sender).Tag);
		}

		private void SelectLucidItem(string Type)
		{
			if (FindNode(trvMain.Nodes[2], Type) != null) {
				trvMain.SelectedNode = FindNode(trvMain.Nodes[2], Type);
			}
		}

		private void trvMain_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			if (CancelForSave(e.Node, false)) {
				e.Cancel = true;
			}
		}

		private void trvMain_ItemDrag(System.Object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			try {
				TreeNode myItem = null;
				TreeNode[] myItems = new TreeNode[sender.nodes.Count()];
				int i = 0;

				// Loop though the SelectedNodes collection for the source.
				foreach (TreeNode myItem_loopVariable in sender.nodes) {
					myItem = myItem_loopVariable;
					// Add the TreeNode to the array of ListViewItems.
					myItems[i] = myItem;
					i = i + 1;
				}
				// Create a DataObject containg the array of ListViewItems.
				sender.DoDragDrop(new DataObject("System.Windows.Forms.TreeNode()", myItems), DragDropEffects.Link);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Main.ItemDrag()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuHelpAbout_Click(System.Object sender, System.EventArgs e)
		{
			if (m_formAbout == null) {
				m_formAbout = new AboutForm();
			}
			m_formAbout.ShowDialog();
		}

		private class UpdateClass
		{

			public string Version;
			public string URL;

			public bool Complete = false;
			public void CheckForUpdate()
			{

				try {
					WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
					HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("http://www.lucid-code.com/LightenedDream/updates/LatestVersion.html");
					objRequest.Method = "GET";
					HttpWebResponse objWebResponse = (HttpWebResponse)objRequest.GetResponse();
					StreamReader objResponseStream = new StreamReader(objWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding(1252));
					var strResponse = objResponseStream.ReadToEnd();
					objWebResponse.Close();
					objResponseStream.Close();

					if (strResponse.StartsWith("Version ")) {
						string[] arrLines = strResponse.Split(Constants.vbNewLine);
						Version = arrLines[0].Replace("Version ", "");
						URL = arrLines[1];
					}

					if (UpdateAvailable(Version)) {
						if (MessageBox.Show("A new version (" + Version + ") is available. Would you like to download it now?", "Lightened Dream", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
							try {
								System.Diagnostics.Process.Start("explorer.exe", URL);
							} catch (Exception ex) {
								MessageBox.Show(ex.Message, "LightenedDream.Update.Launch()", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}

				} catch (Exception ex) {
				}

				Complete = true;
			}

			private bool UpdateAvailable(string NewVersion)
			{

				try {
					string OldVersion = Application.ProductVersion;
					string[] arrOldVersion = Strings.Split(Application.ProductVersion, ".");
					// 2.9.9.0
					string[] arrNewVersion = Strings.Split(NewVersion, ".");
					//    ' 2.9.9.1

					if (Conversion.Val(arrNewVersion[0]) > Conversion.Val(arrOldVersion[0])) {
						return true;
					} else {
						if (Conversion.Val(arrNewVersion[1]) > Conversion.Val(arrOldVersion[1])) {
							return true;
						} else {
							if (Conversion.Val(arrNewVersion[2]) > Conversion.Val(arrOldVersion[2])) {
								return true;
							} else {
								if (Conversion.Val(arrNewVersion[3]) > Conversion.Val(arrOldVersion[3])) {
									return true;
								} else {
									return false;
								}
							}
						}
					}
				} catch (Exception ex) {
					return false;
				}
			}

		}

		private void mnuHelpSupport_Click(System.Object sender, System.EventArgs e)
		{
			SupportForm formSupport = new SupportForm();
			formSupport.ShowDialog();
		}

		private void mnuTrvDelete_Click(System.Object sender, System.EventArgs e)
		{
			Delete();
		}

		private void mnuToolNewLucidItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewLucidityItem(((ToolStripMenuItem)sender).Tag);
		}

		private void CreateNewLucidityItem(string Type)
		{
			string strFilename = m_objLucidItemControl.CreateNew(Type);

			// Update Tree   
			TreeNode trvLucidItem = new TreeNode(new FileInfo(strFilename).Name.Replace(".ld3", ""));
			lucidcode.LightenedDream.Lucidity.Tags.LucidItemFile objDreamTag = new lucidcode.LightenedDream.Lucidity.Tags.LucidItemFile(strFilename, new FileInfo(strFilename).Name.Replace(".ld3", ""));
			trvLucidItem.Tag = objDreamTag;
			trvLucidItem.ImageIndex = 2;
			trvLucidItem.SelectedImageIndex = 2;
			if (lstImgTrv.Images.IndexOfKey("File." + Type + "s") != -1) {
				trvLucidItem.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + Type + "s");
				trvLucidItem.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + Type + "s");
			}

			// Add Item
			if (FindNode(trvMain.Nodes[2], Type + "s") != null) {
				FindNode(trvMain.Nodes[2], Type + "s").Nodes.Add(trvLucidItem);
			}

			// Select Item
			trvMain.SelectedNode = trvLucidItem;
		}

		private void mnuToolNewREMCycle_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewREMCycle();
		}

		private void CreateNewREMCycle()
		{
			string strFilename = m_objREMCyclesControl.CreateNew();

			// Update Tree   
			TreeNode trvLucidItem = new TreeNode(new FileInfo(strFilename).Name.Replace(".ld3", ""));
			lucidcode.LightenedDream.Lucidity.Tags.REMCycleFile objDreamTag = new lucidcode.LightenedDream.Lucidity.Tags.REMCycleFile(strFilename);
			trvLucidItem.Tag = objDreamTag;
			trvLucidItem.ImageIndex = 2;
			trvLucidItem.SelectedImageIndex = 2;
			if (lstImgTrv.Images.IndexOfKey("File." + "REM Cycles") != -1) {
				trvLucidItem.ImageIndex = lstImgTrv.Images.IndexOfKey("File." + "REM Cycles");
				trvLucidItem.SelectedImageIndex = lstImgTrv.Images.IndexOfKey("File." + "REM Cycles");
			}

			// Add Item
			if (FindNode(trvMain.Nodes[2], "REM Cycle" + "s") != null) {
				FindNode(trvMain.Nodes[2], "REM Cycle" + "s").Nodes.Add(trvLucidItem);
			}

			// Select Item
			trvMain.SelectedNode = trvLucidItem;
		}

		private void mnuFileExport_Click(System.Object sender, System.EventArgs e)
		{
			Export();
		}

		private void Export()
		{
			ExportForm formExport = new ExportForm();
			formExport.trvMain.Nodes.Clear();
			foreach (TreeNode trvNode in trvMain.Nodes) {
				formExport.trvMain.Nodes.Add(trvNode.Clone());
			}
			formExport.chkSelectAll.Checked = true;
			formExport.ShowDialog();
		}

		private void mnuCategories_Click(System.Object sender, System.EventArgs e)
		{
			if (FindNode(trvMain.Nodes[1], ((ToolStripMenuItem)sender).Tag) != null) {
				trvMain.SelectedNode = FindNode(trvMain.Nodes[1], ((ToolStripMenuItem)sender).Tag);
			}
		}

		private int m_intIco = 0;

		private List<Icon> m_arrIcons = new List<Icon>();
		private void tmrProcessing_Tick(System.Object sender, System.EventArgs e)
		{
			try {
				if (m_arrIcons.Count == 0) {
					foreach (Image objImage in lstImgIco.Images) {
						m_arrIcons.Add(Icon.FromHandle(((Bitmap)lstImgIco.Images[m_intIco]).GetHicon()));
						m_intIco += 1;
					}
					m_intIco = 0;
				}

				this.Icon = m_arrIcons[m_intIco];
				m_intIco += 1;
				if (m_intIco >= lstImgIco.Images.Count) {
					m_intIco = 0;
				}


			} catch (Exception ex) {
			}
		}

		private void mnuFileExit_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void mnuFileSave_Click(System.Object sender, System.EventArgs e)
		{
			Save();
		}

		private void mnuFileDelete_Click(System.Object sender, System.EventArgs e)
		{
			Delete();
		}

		private void mnuLucidityPlay_Click(System.Object sender, System.EventArgs e)
		{
			PlayLucid();
		}

		private void mnuToolsUpdate_Click(System.Object sender, System.EventArgs e)
		{
			UpdateDatabase();
		}

		private void REMCycleToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewREMCycle();
		}

		private void CheckToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewLucidityItem(((ToolStripMenuItem)sender).Tag);
		}

		private void mnuToolsPlay_Click(System.Object sender, System.EventArgs e)
		{
			PlayLucid();
		}

		private void toolVariables_Click(System.Object sender, System.EventArgs e)
		{
			MessageBox.Show("This feature is still dreaming itself into existence.", "Lightened Dream", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		}

		private void mnuLucidity_Click(System.Object sender, System.EventArgs e)
		{
			if (FindNode(trvMain.Nodes[2], ((ToolStripMenuItem)sender).Tag) != null) {
				trvMain.SelectedNode = FindNode(trvMain.Nodes[2], ((ToolStripMenuItem)sender).Tag);
			}
		}

		private void mnuTrvSendToDesktop_Click(System.Object sender, System.EventArgs e)
		{
			try {
				File.Copy(trvMain.SelectedNode.Tag.Path, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + new FileInfo(trvMain.SelectedNode.Tag.Path).Name);

				Interaction.Shell("explorer /select, \"" + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + new FileInfo(trvMain.SelectedNode.Tag.Path).Name + "\"", AppWinStyle.NormalFocus);

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.SendTo.Desktop()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuTrvPlay_Click(System.Object sender, System.EventArgs e)
		{
			PlayLucid();
		}

		private void mnuTrv_Opening(System.Object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (trvMain.SelectedNode == null) {
				mnuTrvPlay.Enabled = false;
				mnuTrvDelete.Enabled = false;
				mnuTrvSendTo.Enabled = false;
				mnuTrvExplorer.Enabled = false;
			} else {
				mnuTrvPlay.Enabled = mnuToolsPlay.Enabled;
				mnuTrvDelete.Enabled = toolDelete.Enabled;
				mnuTrvSendTo.Enabled = toolDelete.Enabled;
				mnuTrvExplorer.Enabled = true;
			}

			mnuTreeNewCategoryItem.Enabled = false;
			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				mnuTreeNewCategoryItem.Enabled = true;
			}
		}

		private void trvMain_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				if ((trvMain.GetNodeAt(e.X, e.Y) != null)) {
					trvMain.SelectedNode = trvMain.GetNodeAt(e.X, e.Y);
				}
			}
		}

		private void toolSearch_Click(System.Object sender, System.EventArgs e)
		{
			SelectSearch();
		}

		private void SelectSearch()
		{
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objSearchControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objSearchControl);
			m_objSearchControl.Activate();
		}


		private void mnuTrvExplorer_Click(System.Object sender, System.EventArgs e)
		{
			Interaction.Shell("explorer /select, \"" + new FileInfo(trvMain.SelectedNode.Tag.Path).DirectoryName + "\\" + new FileInfo(trvMain.SelectedNode.Tag.Path).Name + "\"", AppWinStyle.NormalFocus);

		}

		private void mnuFileNewCategoryFolder_Click(System.Object sender, System.EventArgs e)
		{
			CreateCustomCategory();
		}

		private void CreateCustomCategory()
		{
			string strName = "New Category";
			string strDirectory = m_strPath + "\\Categories\\" + strName;

			// Create folder
			int intPos = 2;
			do {
				if ((Directory.Exists(strDirectory))) {
					strName = "New Catgeory " + intPos.ToString();
					strDirectory = m_strPath + "\\Categories\\" + strName;
					intPos += 1;
				} else {
					break; // TODO: might not be correct. Was : Exit Do
				}
			} while (true);

			Directory.CreateDirectory(strDirectory);

			// Add to tree
			TreeNode trvItem = new TreeNode(strName);
			trvItem.Tag = new lucidcode.LightenedDream.Categories.Tags.CategoryFolder(strDirectory);
			trvMain.Nodes[1].Nodes.Add(trvItem);

			trvMain.SelectedNode = trvItem;
		}

		private void mnuNewCustomCatgeory_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewCategoryFolder();
		}


		public MainForm()
		{
			KeyDown += MainForm_KeyDown;
			FormClosing += MainForm_FormClosing;
			FormClosed += MainForm_FormClosed;
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.

		}

		private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (CancelForSave(trvMain.SelectedNode, true)) {
				e.Cancel = true;
			}
		}


		private void mnuTrvCopyToRecordings_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void mnuFileNewExercise_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(false);
		}

		private void ExerciseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(false);
		}

		private void mnuTrvNewExercise_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(false);
		}

		private void ExerciseRndToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(true);
		}

		private void RandomExerciseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(true);
		}

		private void RandomExerciseToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			CreateNewExercise(true);
		}

		private void mnuToolsWILD_Click(System.Object sender, System.EventArgs e)
		{
			lucidcode.LightenedDream.Lucidity.WILDForm formWILD = new lucidcode.LightenedDream.Lucidity.WILDForm();
			formWILD.ShowDialog();
		}

		private void mnuToolsFIELD_Click(System.Object sender, System.EventArgs e)
		{
			lucidcode.LightenedDream.Lucidity.FIELDForm formFIELD = new lucidcode.LightenedDream.Lucidity.FIELDForm();
			formFIELD.ShowDialog();
		}

		private void mnuToolsDreamSignBuilder_Click(System.Object sender, System.EventArgs e)
		{
			trvMain.SelectedNode = trvMain.Nodes[0];
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objDreamSignListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objDreamSignListControl);
			m_objDreamSignListControl.StartSearch();
		}

		private void mnuToolsCompareDreams_Click(System.Object sender, System.EventArgs e)
		{
			trvMain.SelectedNode = trvMain.Nodes[0];
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objCompareDreamsControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objCompareDreamsControl);
			m_objCompareDreamsControl.StartSearch();
		}

		private void mnuHelpUpdate_Click(System.Object sender, System.EventArgs e)
		{
			RegisterForm formRegister = new RegisterForm();
			formRegister.ShowDialog();
		}

		private void mnuQuickStart_Click(System.Object sender, System.EventArgs e)
		{
			Interaction.Shell("explorer \"" + Application.StartupPath + "\\QuickStart.pdf" + "\"", AppWinStyle.NormalFocus);
		}

		private void mnuTrvSendToLD4All_Click(System.Object sender, System.EventArgs e)
		{
			XmlDocument xmlDoc = new XmlDocument();
			string strXml = "";

			// Make sure that the LD4All file exists
			if ((!File.Exists(m_strPath + "LD4All.ld3"))) {
				// Create the LD4All file



				strXml = "<LightenedDream>";
				strXml += "</LightenedDream>";
				xmlDoc.LoadXml(strXml);
				xmlDoc.Save(m_strPath + "LD4All.ld3");
			}


		}


		private void tmrSearching_Tick(System.Object sender, System.EventArgs e)
		{
		}


		//Private Delegate Sub AddSearchItemDelegate()
		//Private Sub AddSearchItem()
		//  Try
		//    If InvokeRequired Then
		//      Dim d As New AddSearchItemDelegate(AddressOf AddSearchItem)
		//      Invoke(d)
		//    Else
		//      m_objDreams.Points.AddY(Int(Rnd() * 1000))
		//      m_objDreams.Points.Remove(m_objDreams.Points(0))
		//    End If
		//  Catch ex As Exception
		//  End Try
		//End Sub

		//Private m_objProcessingThread As Threading.Thread

		//Private Sub DoProcessingWork()
		//  Do
		//    AddSearchItem()
		//    Threading.Thread.Sleep(128)
		//  Loop
		//End Sub

		private void ShowSearching()
		{
			DoubleBuffered = true;

			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();
			graph.ResetAutoValues();
			graph.Annotations.Clear();

			m_objDreams = graph.Series.Add("Dreams");
			m_objDreams.ChartType = SeriesChartType.Column;
			m_objDreams.Color = Color.FromArgb(200, 65, 140, 240);
			m_objDreams.BorderWidth = 1;

			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(0);
			m_objDreams.Points.AddY(1000);

			m_arrRandomWords = new List<string>();

			tmrSaving.Interval = 128;
			pnlProcessing.Visible = true;
			tmrSaving.Enabled = true;
			m_boolDoneProcessing = false;
			m_dtStartTime = DateAndTime.Now;


			//m_objProcessingThread = New Threading.Thread(AddressOf DoProcessingWork)
			//m_objProcessingThread.Start()
		}


		private DateTime m_dtStartTime;

		private  m_boolDoneProcessing = false;

		private void HideSearching()
		{
			//Make sure that 500 milliseconds have passed
			do {
				TimeSpan dtSpeed = DateTime.Now.Subtract(m_dtStartTime);
				if (dtSpeed.TotalMilliseconds > 500) {
					break; // TODO: might not be correct. Was : Exit Do
				}

				System.Threading.Thread.Sleep(64);
				Application.DoEvents();

			} while (true);


			pnlProcessing.Visible = false;
			tmrSaving.Enabled = false;
			m_boolDoneProcessing = true;
		}

		private void tmrSaving_Tick(System.Object sender, System.EventArgs e)
		{
			//tmrSaving.Enabled = False
			if (m_boolDoneProcessing)
				return;

			TimeSpan dtSpeed = DateTime.Now.Subtract(m_dtStartTime);
			if (dtSpeed.TotalSeconds > 60) {
				tmrSaving.Interval = 512;
			}

			m_objDreams.Points.AddY(Conversion.Int(VBMath.Rnd() * 1000));

			if ((m_objDreams.Points[0].Tag != null)) {
				if (m_objDreams.Points[0].Tag == "X") {
					foreach (Annotation objDreamAnnotation_loopVariable in graph.Annotations) {
						objDreamAnnotation = objDreamAnnotation_loopVariable;
						if (object.ReferenceEquals(objDreamAnnotation.AnchorDataPoint, m_objDreams.Points[0])) {
							graph.Annotations.Remove(objDreamAnnotation);
							break; // TODO: might not be correct. Was : Exit For
						}
					}
				}
			}

			m_objDreams.Points.Remove(m_objDreams.Points[0]);
			Application.DoEvents();

			if (m_arrRandomWords.Count > 0) {
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
				objDreamAnnotation.Text = m_arrRandomWords[0];
				objDreamAnnotation.AnchorAlignment = ContentAlignment.BottomCenter;

				DataPoint objDataPoint = m_objDreams.Points[m_objDreams.Points.Count - 1];
				objDreamAnnotation.AnchorDataPoint = objDataPoint;
				objDataPoint.Tag = "X";

				this.graph.Annotations.Add(objDreamAnnotation);

				m_arrRandomWords.Remove(m_arrRandomWords[0]);

			}
		}


		private List<string> m_arrRandomWords;
		private void RandomWord(string Word)
		{
			m_arrRandomWords.Add(Word);
		}

		private void mnuToolsWhyLD_Click(System.Object sender, System.EventArgs e)
		{
			lucidcode.LightenedDream.Lucidity.WhyLDForm formWhyLD = new lucidcode.LightenedDream.Lucidity.WhyLDForm();
			formWhyLD.ShowDialog();
		}

		protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.Back)) {
				SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
				return true;
			}
			return base.ProcessCmdKey(msg, keyData);
		}

		private void MainForm_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//Try
			//  If e.Control And e.KeyCode = Keys.Back Then
			//    If TypeOf (sender) Is TextBox Then
			//      e.SuppressKeyPress = True
			//      Dim selStart As Integer = CType(sender, TextBox).SelectionStart
			//      While selStart > 0 AndAlso CType(sender, TextBox).Text.Substring(selStart - 1, 1) = " "
			//        selStart -= 1
			//      End While
			//      Dim prevSpacePos As Integer = -1
			//      If selStart <> 0 Then
			//        prevSpacePos = CType(sender, TextBox).Text.LastIndexOf(" "c, selStart - 1)
			//      End If
			//      CType(sender, TextBox).[Select](prevSpacePos + 1, CType(sender, TextBox).SelectionStart - prevSpacePos - 1)
			//      CType(sender, TextBox).SelectedText = ""
			//    Else
			//      e.SuppressKeyPress = True
			//      SendKeys.SendWait("^+{LEFT}{BACKSPACE}")
			//      e.Handled = True
			//    End If
			//  End If
			//Catch ex As Exception

			//End Try
		}

		private void mnuToolsDataDirectory_Click(System.Object sender, System.EventArgs e)
		{
			DataDirectoryForm formDataDirectory = new DataDirectoryForm();
			formDataDirectory.ShowDialog();
		}

		private void mnuToolsDreamTypeCount_Click(System.Object sender, System.EventArgs e)
		{
			trvMain.SelectedNode = trvMain.Nodes[0];
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objDreamSignListControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objDreamSignListControl);
			m_objDreamSignListControl.CountDreamTypes();
		}

		private void NewToolStripMenuItem_DropDownOpening(System.Object sender, System.EventArgs e)
		{
			mnuNewCategoryItem.Enabled = false;
			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				mnuNewCategoryItem.Enabled = true;
			}
		}

		private void mnuToolsRecentDreamSigns_Click(System.Object sender, System.EventArgs e)
		{
			trvMain.SelectedNode = trvMain.Nodes[0];
			trvMain.SelectedNode = null;
			pnlContainer.Controls.Clear();
			m_objRecentDreamSignControl.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(m_objRecentDreamSignControl);
			m_objRecentDreamSignControl.StartSearch();
		}

		private void toolNew_DropDownOpening(System.Object sender, System.EventArgs e)
		{
			mnuToolNewCategoryItem.Enabled = false;
			if ((trvMain.SelectedNode.Tag) is Categories.Tags.CategoryFolder) {
				mnuToolNewCategoryItem.Enabled = true;
			}
		}
	}
}
