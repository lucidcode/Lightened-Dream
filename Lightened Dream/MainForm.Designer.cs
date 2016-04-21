using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace LightenedDream
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class MainForm : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode TreeNode13 = new System.Windows.Forms.TreeNode("Node0");
			System.Windows.Forms.TreeNode TreeNode14 = new System.Windows.Forms.TreeNode("Dreams", new System.Windows.Forms.TreeNode[] { TreeNode13 });
			System.Windows.Forms.TreeNode TreeNode15 = new System.Windows.Forms.TreeNode("Characters");
			System.Windows.Forms.TreeNode TreeNode16 = new System.Windows.Forms.TreeNode("Locations");
			System.Windows.Forms.TreeNode TreeNode17 = new System.Windows.Forms.TreeNode("Objects");
			System.Windows.Forms.TreeNode TreeNode18 = new System.Windows.Forms.TreeNode("Actions");
			System.Windows.Forms.TreeNode TreeNode19 = new System.Windows.Forms.TreeNode("Themes");
			System.Windows.Forms.TreeNode TreeNode20 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
				TreeNode15,
				TreeNode16,
				TreeNode17,
				TreeNode18,
				TreeNode19
			});
			System.Windows.Forms.TreeNode TreeNode21 = new System.Windows.Forms.TreeNode("REM Cycles");
			System.Windows.Forms.TreeNode TreeNode22 = new System.Windows.Forms.TreeNode("Reality Checks");
			System.Windows.Forms.TreeNode TreeNode23 = new System.Windows.Forms.TreeNode("Dream Inductions");
			System.Windows.Forms.TreeNode TreeNode24 = new System.Windows.Forms.TreeNode("Lucidity", new System.Windows.Forms.TreeNode[] {
				TreeNode21,
				TreeNode22,
				TreeNode23
			});
			lucidcode.LightenedDream.Dreams.My.MySettings MySettings4 = new lucidcode.LightenedDream.Dreams.My.MySettings();
			System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel CustomLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Series Series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolNew = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuToolNewDream = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuNewCustomCatgeory = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolNewCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuToolNewREMCycle = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolNewCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolNewSubliminal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolNewRecording = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolNewReading = new System.Windows.Forms.ToolStripMenuItem();
			this.ExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExerciseRndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolDelete = new System.Windows.Forms.ToolStripButton();
			this.toolSave = new System.Windows.Forms.ToolStripButton();
			this.toolUpdate = new System.Windows.Forms.ToolStripButton();
			this.toolSearch = new System.Windows.Forms.ToolStripButton();
			this.toolBack = new System.Windows.Forms.ToolStripButton();
			this.toolForward = new System.Windows.Forms.ToolStripButton();
			this.Panel3D3 = new lucidcode.Controls.Panel3D();
			this.Panel3D6 = new lucidcode.Controls.Panel3D();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.CategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNewCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
			this.REMCycleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SubliminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecordingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewExercise = new System.Windows.Forms.ToolStripMenuItem();
			this.RandomExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.LucidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLucidityREMCycles = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLuciditySubliminals = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLucidityRecordings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLucidityReadings = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuToolsDreamSignBuilder = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsRecentDreamSigns = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsCompareDreams = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsDreamTypeCount = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsFIELD = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsWILD = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsWhyLD = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.SpellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCheckSpelling = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSpellingLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsDataDirectory = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuQuickStart = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuHelpUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpSupport = new System.Windows.Forms.ToolStripMenuItem();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Panel3D1 = new lucidcode.Controls.Panel3D();
			this.Panel3D8 = new lucidcode.Controls.Panel3D();
			this.Label3 = new System.Windows.Forms.Label();
			this.trvMain = new System.Windows.Forms.TreeView();
			this.mnuTrv = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuTreeNewCategoryFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTreeNewCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTrvNewExercise = new System.Windows.Forms.ToolStripMenuItem();
			this.RandomExerciseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuTrvDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTrvPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuTrvExplorer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTrvSendTo = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTrvSendToDesktop = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTrvSendToLD4All = new System.Windows.Forms.ToolStripMenuItem();
			this.lstImgTrv = new System.Windows.Forms.ImageList(this.components);
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.tmrLoad = new System.Windows.Forms.Timer(this.components);
			this.Panel3D5 = new lucidcode.Controls.Panel3D();
			this.Panel3D7 = new lucidcode.Controls.Panel3D();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolPlay = new System.Windows.Forms.ToolStripButton();
			this.toolREMCycles = new System.Windows.Forms.ToolStripButton();
			this.toolSubliminals = new System.Windows.Forms.ToolStripButton();
			this.toolRecordings = new System.Windows.Forms.ToolStripButton();
			this.toolReadings = new System.Windows.Forms.ToolStripButton();
			this.toolLucidityExercises = new System.Windows.Forms.ToolStripButton();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lstImgIco = new System.Windows.Forms.ImageList(this.components);
			this.tmrProcessing = new System.Windows.Forms.Timer(this.components);
			this.pnlProcessing = new lucidcode.Controls.Panel3D();
			this.pnlSearching = new lucidcode.Controls.Panel3D();
			this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tmrSaving = new System.Windows.Forms.Timer(this.components);
			this.ToolStrip1.SuspendLayout();
			this.Panel3D3.SuspendLayout();
			this.Panel3D6.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.Panel3D1.SuspendLayout();
			this.Panel3D8.SuspendLayout();
			this.mnuTrv.SuspendLayout();
			this.Panel3D5.SuspendLayout();
			this.Panel3D7.SuspendLayout();
			this.ToolStrip3.SuspendLayout();
			this.pnlProcessing.SuspendLayout();
			this.pnlSearching.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.graph).BeginInit();
			this.SuspendLayout();
			//
			//ToolStrip1
			//
			this.ToolStrip1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ToolStrip1.AutoSize = false;
			this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.toolNew,
				this.toolDelete,
				this.toolSave,
				this.toolUpdate,
				this.toolSearch,
				this.toolBack,
				this.toolForward
			});
			this.ToolStrip1.Location = new System.Drawing.Point(10, 27);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.ShowItemToolTips = false;
			this.ToolStrip1.Size = new System.Drawing.Size(250, 54);
			this.ToolStrip1.TabIndex = 6;
			this.ToolStrip1.Text = "ToolStrip1";
			//
			//toolNew
			//
			this.toolNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuToolNewDream,
				this.ToolStripMenuItem6,
				this.mnuNewCustomCatgeory,
				this.mnuToolNewCategoryItem,
				this.ToolStripMenuItem7,
				this.mnuToolNewREMCycle,
				this.mnuToolNewCheck,
				this.mnuToolNewSubliminal,
				this.mnuToolNewRecording,
				this.mnuToolNewReading,
				this.ExerciseToolStripMenuItem,
				this.ExerciseRndToolStripMenuItem
			});
			this.toolNew.Image = (System.Drawing.Image)resources.GetObject("toolNew.Image");
			this.toolNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolNew.ImageTransparentColor = System.Drawing.Color.White;
			this.toolNew.Name = "toolNew";
			this.toolNew.Size = new System.Drawing.Size(52, 51);
			this.toolNew.Text = "&New";
			this.toolNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//mnuToolNewDream
			//
			this.mnuToolNewDream.Image = global::LightenedDream.My.Resources.Resources.Dream_Final2;
			this.mnuToolNewDream.Name = "mnuToolNewDream";
			this.mnuToolNewDream.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewDream.Text = "&Dream";
			//
			//ToolStripMenuItem6
			//
			this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			this.ToolStripMenuItem6.Size = new System.Drawing.Size(188, 6);
			//
			//mnuNewCustomCatgeory
			//
			this.mnuNewCustomCatgeory.Image = (System.Drawing.Image)resources.GetObject("mnuNewCustomCatgeory.Image");
			this.mnuNewCustomCatgeory.Name = "mnuNewCustomCatgeory";
			this.mnuNewCustomCatgeory.Size = new System.Drawing.Size(191, 24);
			this.mnuNewCustomCatgeory.Text = "Category";
			//
			//mnuToolNewCategoryItem
			//
			this.mnuToolNewCategoryItem.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewCategoryItem.Image");
			this.mnuToolNewCategoryItem.Name = "mnuToolNewCategoryItem";
			this.mnuToolNewCategoryItem.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewCategoryItem.Tag = "CategoryItem";
			this.mnuToolNewCategoryItem.Text = "Category &Item";
			//
			//ToolStripMenuItem7
			//
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new System.Drawing.Size(188, 6);
			//
			//mnuToolNewREMCycle
			//
			this.mnuToolNewREMCycle.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewREMCycle.Image");
			this.mnuToolNewREMCycle.Name = "mnuToolNewREMCycle";
			this.mnuToolNewREMCycle.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewREMCycle.Tag = "REM Cycle";
			this.mnuToolNewREMCycle.Text = "REM Cycle";
			//
			//mnuToolNewCheck
			//
			this.mnuToolNewCheck.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewCheck.Image");
			this.mnuToolNewCheck.Name = "mnuToolNewCheck";
			this.mnuToolNewCheck.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewCheck.Tag = "Check";
			this.mnuToolNewCheck.Text = "&Check";
			//
			//mnuToolNewSubliminal
			//
			this.mnuToolNewSubliminal.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewSubliminal.Image");
			this.mnuToolNewSubliminal.Name = "mnuToolNewSubliminal";
			this.mnuToolNewSubliminal.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewSubliminal.Tag = "Subliminal";
			this.mnuToolNewSubliminal.Text = "&Subliminal";
			//
			//mnuToolNewRecording
			//
			this.mnuToolNewRecording.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewRecording.Image");
			this.mnuToolNewRecording.Name = "mnuToolNewRecording";
			this.mnuToolNewRecording.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewRecording.Tag = "Recording";
			this.mnuToolNewRecording.Text = "&Recording";
			//
			//mnuToolNewReading
			//
			this.mnuToolNewReading.Image = (System.Drawing.Image)resources.GetObject("mnuToolNewReading.Image");
			this.mnuToolNewReading.Name = "mnuToolNewReading";
			this.mnuToolNewReading.Size = new System.Drawing.Size(191, 24);
			this.mnuToolNewReading.Tag = "Reading";
			this.mnuToolNewReading.Text = "&Reading";
			//
			//ExerciseToolStripMenuItem
			//
			this.ExerciseToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ExerciseToolStripMenuItem.Image");
			this.ExerciseToolStripMenuItem.Name = "ExerciseToolStripMenuItem";
			this.ExerciseToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.ExerciseToolStripMenuItem.Text = "&Exercise";
			//
			//ExerciseRndToolStripMenuItem
			//
			this.ExerciseRndToolStripMenuItem.Image = global::LightenedDream.My.Resources.Resources.Dream_Final_2;
			this.ExerciseRndToolStripMenuItem.Name = "ExerciseRndToolStripMenuItem";
			this.ExerciseRndToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.ExerciseRndToolStripMenuItem.Text = "&Random Exercise";
			//
			//toolDelete
			//
			this.toolDelete.AutoSize = false;
			this.toolDelete.Image = (System.Drawing.Image)resources.GetObject("toolDelete.Image");
			this.toolDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolDelete.ImageTransparentColor = System.Drawing.Color.White;
			this.toolDelete.Name = "toolDelete";
			this.toolDelete.Size = new System.Drawing.Size(50, 48);
			this.toolDelete.Text = "&Delete";
			this.toolDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolSave
			//
			this.toolSave.AutoSize = false;
			this.toolSave.Image = (System.Drawing.Image)resources.GetObject("toolSave.Image");
			this.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolSave.ImageTransparentColor = System.Drawing.Color.White;
			this.toolSave.Name = "toolSave";
			this.toolSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolSave.Size = new System.Drawing.Size(40, 48);
			this.toolSave.Text = "&Save";
			this.toolSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolUpdate
			//
			this.toolUpdate.AutoSize = false;
			this.toolUpdate.Image = (System.Drawing.Image)resources.GetObject("toolUpdate.Image");
			this.toolUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolUpdate.ImageTransparentColor = System.Drawing.Color.White;
			this.toolUpdate.Name = "toolUpdate";
			this.toolUpdate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolUpdate.Size = new System.Drawing.Size(50, 48);
			this.toolUpdate.Text = "&Refresh";
			this.toolUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolSearch
			//
			this.toolSearch.AutoSize = false;
			this.toolSearch.Image = (System.Drawing.Image)resources.GetObject("toolSearch.Image");
			this.toolSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolSearch.ImageTransparentColor = System.Drawing.Color.White;
			this.toolSearch.Name = "toolSearch";
			this.toolSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolSearch.Size = new System.Drawing.Size(50, 48);
			this.toolSearch.Text = "&Search";
			this.toolSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolBack
			//
			this.toolBack.AutoSize = false;
			this.toolBack.Enabled = false;
			this.toolBack.Image = (System.Drawing.Image)resources.GetObject("toolBack.Image");
			this.toolBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolBack.ImageTransparentColor = System.Drawing.Color.White;
			this.toolBack.Name = "toolBack";
			this.toolBack.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolBack.Size = new System.Drawing.Size(48, 48);
			this.toolBack.Text = "&Back";
			this.toolBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolBack.Visible = false;
			//
			//toolForward
			//
			this.toolForward.AutoSize = false;
			this.toolForward.Enabled = false;
			this.toolForward.Image = (System.Drawing.Image)resources.GetObject("toolForward.Image");
			this.toolForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolForward.ImageTransparentColor = System.Drawing.Color.White;
			this.toolForward.Name = "toolForward";
			this.toolForward.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolForward.Size = new System.Drawing.Size(50, 48);
			this.toolForward.Text = "&Forward";
			this.toolForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolForward.Visible = false;
			//
			//Panel3D3
			//
			this.Panel3D3.Controls.Add(this.ToolStrip1);
			this.Panel3D3.Controls.Add(this.Panel3D6);
			this.Panel3D3.Location = new System.Drawing.Point(12, 27);
			this.Panel3D3.Name = "Panel3D3";
			this.Panel3D3.Size = new System.Drawing.Size(247, 80);
			this.Panel3D3.TabIndex = 23;
			//
			//Panel3D6
			//
			this.Panel3D6.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D6.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.Panel3D6.Controls.Add(this.Label16);
			this.Panel3D6.Controls.Add(this.Label4);
			this.Panel3D6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D6.Location = new System.Drawing.Point(0, 0);
			this.Panel3D6.Name = "Panel3D6";
			this.Panel3D6.Size = new System.Drawing.Size(247, 24);
			this.Panel3D6.TabIndex = 5;
			//
			//Label16
			//
			this.Label16.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label16.BackColor = System.Drawing.Color.Transparent;
			this.Label16.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label16.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label16.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label16.Location = new System.Drawing.Point(24, 3);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(220, 19);
			this.Label16.TabIndex = 3;
			this.Label16.Text = "Controls";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label4.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label4.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label4.Image = (System.Drawing.Image)resources.GetObject("Label4.Image");
			this.Label4.Location = new System.Drawing.Point(4, 4);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(16, 16);
			this.Label4.TabIndex = 4;
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.MenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.FileToolStripMenuItem,
				this.LucidityToolStripMenuItem,
				this.ToolsToolStripMenuItem,
				this.HelpToolStripMenuItem
			});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.MenuStrip1.Size = new System.Drawing.Size(1008, 28);
			this.MenuStrip1.TabIndex = 24;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.NewToolStripMenuItem,
				this.mnuFileSave,
				this.mnuFileDelete,
				this.ImportToolStripMenuItem,
				this.mnuFileExport,
				this.ToolStripMenuItem3,
				this.mnuFileExit
			});
			this.FileToolStripMenuItem.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.FileToolStripMenuItem.Text = "&File";
			//
			//NewToolStripMenuItem
			//
			this.NewToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.NewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.DreamToolStripMenuItem,
				this.ToolStripSeparator4,
				this.CategoryToolStripMenuItem1,
				this.mnuNewCategoryItem,
				this.ToolStripMenuItem9,
				this.REMCycleToolStripMenuItem1,
				this.SubliminalToolStripMenuItem,
				this.RecordingToolStripMenuItem1,
				this.ReadingToolStripMenuItem,
				this.mnuFileNewExercise,
				this.RandomExerciseToolStripMenuItem
			});
			this.NewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NewToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("NewToolStripMenuItem.Image");
			this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
			this.NewToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
			this.NewToolStripMenuItem.Text = "&New";
			//
			//DreamToolStripMenuItem
			//
			this.DreamToolStripMenuItem.Image = global::LightenedDream.My.Resources.Resources.Dream_Final2;
			this.DreamToolStripMenuItem.Name = "DreamToolStripMenuItem";
			this.DreamToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.DreamToolStripMenuItem.Text = "&Dream";
			//
			//ToolStripSeparator4
			//
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new System.Drawing.Size(188, 6);
			//
			//CategoryToolStripMenuItem1
			//
			this.CategoryToolStripMenuItem1.Image = global::LightenedDream.My.Resources.Resources.Folder_16;
			this.CategoryToolStripMenuItem1.Name = "CategoryToolStripMenuItem1";
			this.CategoryToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
			this.CategoryToolStripMenuItem1.Tag = "Category";
			this.CategoryToolStripMenuItem1.Text = "Category";
			//
			//mnuNewCategoryItem
			//
			this.mnuNewCategoryItem.Image = global::LightenedDream.My.Resources.Resources.Categories;
			this.mnuNewCategoryItem.Name = "mnuNewCategoryItem";
			this.mnuNewCategoryItem.Size = new System.Drawing.Size(191, 24);
			this.mnuNewCategoryItem.Tag = "Catgeory Item";
			this.mnuNewCategoryItem.Text = "Catgeory Item";
			//
			//ToolStripMenuItem9
			//
			this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
			this.ToolStripMenuItem9.Size = new System.Drawing.Size(188, 6);
			//
			//REMCycleToolStripMenuItem1
			//
			this.REMCycleToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("REMCycleToolStripMenuItem1.Image");
			this.REMCycleToolStripMenuItem1.Name = "REMCycleToolStripMenuItem1";
			this.REMCycleToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
			this.REMCycleToolStripMenuItem1.Text = "REM Cycle";
			//
			//SubliminalToolStripMenuItem
			//
			this.SubliminalToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("SubliminalToolStripMenuItem.Image");
			this.SubliminalToolStripMenuItem.Name = "SubliminalToolStripMenuItem";
			this.SubliminalToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.SubliminalToolStripMenuItem.Tag = "Subliminal";
			this.SubliminalToolStripMenuItem.Text = "&Subliminal";
			//
			//RecordingToolStripMenuItem1
			//
			this.RecordingToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RecordingToolStripMenuItem1.Image");
			this.RecordingToolStripMenuItem1.Name = "RecordingToolStripMenuItem1";
			this.RecordingToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
			this.RecordingToolStripMenuItem1.Tag = "Recording";
			this.RecordingToolStripMenuItem1.Text = "&Recording";
			//
			//ReadingToolStripMenuItem
			//
			this.ReadingToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ReadingToolStripMenuItem.Image");
			this.ReadingToolStripMenuItem.Name = "ReadingToolStripMenuItem";
			this.ReadingToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.ReadingToolStripMenuItem.Tag = "Reading";
			this.ReadingToolStripMenuItem.Text = "&Reading";
			//
			//mnuFileNewExercise
			//
			this.mnuFileNewExercise.Image = (System.Drawing.Image)resources.GetObject("mnuFileNewExercise.Image");
			this.mnuFileNewExercise.Name = "mnuFileNewExercise";
			this.mnuFileNewExercise.Size = new System.Drawing.Size(191, 24);
			this.mnuFileNewExercise.Text = "&Exercise";
			//
			//RandomExerciseToolStripMenuItem
			//
			this.RandomExerciseToolStripMenuItem.Image = global::LightenedDream.My.Resources.Resources.Dream_Final_2;
			this.RandomExerciseToolStripMenuItem.Name = "RandomExerciseToolStripMenuItem";
			this.RandomExerciseToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.RandomExerciseToolStripMenuItem.Text = "&Random Exercise";
			//
			//mnuFileSave
			//
			this.mnuFileSave.Image = (System.Drawing.Image)resources.GetObject("mnuFileSave.Image");
			this.mnuFileSave.Name = "mnuFileSave";
			this.mnuFileSave.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S);
			this.mnuFileSave.Size = new System.Drawing.Size(187, 24);
			this.mnuFileSave.Text = "&Save";
			//
			//mnuFileDelete
			//
			this.mnuFileDelete.Image = (System.Drawing.Image)resources.GetObject("mnuFileDelete.Image");
			this.mnuFileDelete.Name = "mnuFileDelete";
			this.mnuFileDelete.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete);
			this.mnuFileDelete.Size = new System.Drawing.Size(187, 24);
			this.mnuFileDelete.Text = "&Delete";
			//
			//ImportToolStripMenuItem
			//
			this.ImportToolStripMenuItem.Image = global::LightenedDream.My.Resources.Resources.Graph_Import;
			this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
			this.ImportToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
			this.ImportToolStripMenuItem.Text = "&Import...";
			this.ImportToolStripMenuItem.Visible = false;
			//
			//mnuFileExport
			//
			this.mnuFileExport.Image = global::LightenedDream.My.Resources.Resources.Graph_Export;
			this.mnuFileExport.Name = "mnuFileExport";
			this.mnuFileExport.Size = new System.Drawing.Size(187, 24);
			this.mnuFileExport.Text = "Ex&port";
			this.mnuFileExport.Visible = false;
			//
			//ToolStripMenuItem3
			//
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new System.Drawing.Size(184, 6);
			//
			//mnuFileExit
			//
			this.mnuFileExit.Image = global::LightenedDream.My.Resources.Resources.Graph_Import;
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.ShortcutKeys = (System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4);
			this.mnuFileExit.Size = new System.Drawing.Size(187, 24);
			this.mnuFileExit.Text = "E&xit";
			//
			//LucidityToolStripMenuItem
			//
			this.LucidityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuLucidityREMCycles,
				this.mnuLuciditySubliminals,
				this.mnuLucidityRecordings,
				this.mnuLucidityReadings
			});
			this.LucidityToolStripMenuItem.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.LucidityToolStripMenuItem.Name = "LucidityToolStripMenuItem";
			this.LucidityToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.LucidityToolStripMenuItem.Text = "&Lucidity";
			//
			//mnuLucidityREMCycles
			//
			this.mnuLucidityREMCycles.Image = (System.Drawing.Image)resources.GetObject("mnuLucidityREMCycles.Image");
			this.mnuLucidityREMCycles.Name = "mnuLucidityREMCycles";
			this.mnuLucidityREMCycles.Size = new System.Drawing.Size(154, 24);
			this.mnuLucidityREMCycles.Tag = "REM Cycles";
			this.mnuLucidityREMCycles.Text = "&REM Cycles";
			//
			//mnuLuciditySubliminals
			//
			this.mnuLuciditySubliminals.Image = (System.Drawing.Image)resources.GetObject("mnuLuciditySubliminals.Image");
			this.mnuLuciditySubliminals.Name = "mnuLuciditySubliminals";
			this.mnuLuciditySubliminals.Size = new System.Drawing.Size(154, 24);
			this.mnuLuciditySubliminals.Tag = "Subliminals";
			this.mnuLuciditySubliminals.Text = "&Subliminals";
			//
			//mnuLucidityRecordings
			//
			this.mnuLucidityRecordings.Image = (System.Drawing.Image)resources.GetObject("mnuLucidityRecordings.Image");
			this.mnuLucidityRecordings.Name = "mnuLucidityRecordings";
			this.mnuLucidityRecordings.Size = new System.Drawing.Size(154, 24);
			this.mnuLucidityRecordings.Tag = "Recordings";
			this.mnuLucidityRecordings.Text = "&Recordings";
			//
			//mnuLucidityReadings
			//
			this.mnuLucidityReadings.Image = (System.Drawing.Image)resources.GetObject("mnuLucidityReadings.Image");
			this.mnuLucidityReadings.Name = "mnuLucidityReadings";
			this.mnuLucidityReadings.Size = new System.Drawing.Size(154, 24);
			this.mnuLucidityReadings.Tag = "Readings";
			this.mnuLucidityReadings.Text = "&Readings";
			//
			//ToolsToolStripMenuItem
			//
			this.ToolsToolStripMenuItem.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuToolsPlay,
				this.ToolStripMenuItem22,
				this.mnuToolsDreamSignBuilder,
				this.mnuToolsRecentDreamSigns,
				this.mnuToolsCompareDreams,
				this.mnuToolsDreamTypeCount,
				this.mnuToolsFIELD,
				this.mnuToolsWILD,
				this.mnuToolsWhyLD,
				this.ToolStripMenuItem5,
				this.SpellingToolStripMenuItem,
				this.mnuToolsDataDirectory
			});
			this.ToolsToolStripMenuItem.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
			this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
			this.ToolsToolStripMenuItem.Text = "&Tools";
			//
			//mnuToolsPlay
			//
			this.mnuToolsPlay.Image = (System.Drawing.Image)resources.GetObject("mnuToolsPlay.Image");
			this.mnuToolsPlay.Name = "mnuToolsPlay";
			this.mnuToolsPlay.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mnuToolsPlay.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsPlay.Text = "&Play";
			//
			//ToolStripMenuItem22
			//
			this.ToolStripMenuItem22.Name = "ToolStripMenuItem22";
			this.ToolStripMenuItem22.Size = new System.Drawing.Size(208, 6);
			//
			//mnuToolsDreamSignBuilder
			//
			this.mnuToolsDreamSignBuilder.Image = (System.Drawing.Image)resources.GetObject("mnuToolsDreamSignBuilder.Image");
			this.mnuToolsDreamSignBuilder.Name = "mnuToolsDreamSignBuilder";
			this.mnuToolsDreamSignBuilder.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsDreamSignBuilder.Text = "&Dream Sign Builder";
			//
			//mnuToolsRecentDreamSigns
			//
			this.mnuToolsRecentDreamSigns.Image = (System.Drawing.Image)resources.GetObject("mnuToolsRecentDreamSigns.Image");
			this.mnuToolsRecentDreamSigns.Name = "mnuToolsRecentDreamSigns";
			this.mnuToolsRecentDreamSigns.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsRecentDreamSigns.Text = "&Recent Dream Signs";
			//
			//mnuToolsCompareDreams
			//
			this.mnuToolsCompareDreams.Image = global::LightenedDream.My.Resources.Resources.Dream4;
			this.mnuToolsCompareDreams.Name = "mnuToolsCompareDreams";
			this.mnuToolsCompareDreams.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsCompareDreams.Text = "&Compare Dreams";
			//
			//mnuToolsDreamTypeCount
			//
			this.mnuToolsDreamTypeCount.Image = global::LightenedDream.My.Resources.Resources.Dream4;
			this.mnuToolsDreamTypeCount.Name = "mnuToolsDreamTypeCount";
			this.mnuToolsDreamTypeCount.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsDreamTypeCount.Text = "&Dream Type Count";
			//
			//mnuToolsFIELD
			//
			this.mnuToolsFIELD.Image = global::LightenedDream.My.Resources.Resources.Lucidity2;
			this.mnuToolsFIELD.Name = "mnuToolsFIELD";
			this.mnuToolsFIELD.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsFIELD.Text = "FIELD Inducer";
			//
			//mnuToolsWILD
			//
			this.mnuToolsWILD.Image = (System.Drawing.Image)resources.GetObject("mnuToolsWILD.Image");
			this.mnuToolsWILD.Name = "mnuToolsWILD";
			this.mnuToolsWILD.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsWILD.Text = "&WILD Inducer";
			//
			//mnuToolsWhyLD
			//
			this.mnuToolsWhyLD.Image = (System.Drawing.Image)resources.GetObject("mnuToolsWhyLD.Image");
			this.mnuToolsWhyLD.Name = "mnuToolsWhyLD";
			this.mnuToolsWhyLD.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsWhyLD.Text = "Wh&y LD";
			//
			//ToolStripMenuItem5
			//
			this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			this.ToolStripMenuItem5.Size = new System.Drawing.Size(208, 6);
			//
			//SpellingToolStripMenuItem
			//
			this.SpellingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuCheckSpelling,
				this.mnuSpellingLanguage
			});
			this.SpellingToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("SpellingToolStripMenuItem.Image");
			this.SpellingToolStripMenuItem.Name = "SpellingToolStripMenuItem";
			this.SpellingToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.SpellingToolStripMenuItem.Text = "&Spelling";
			//
			//mnuCheckSpelling
			//
			this.mnuCheckSpelling.Checked = true;
			this.mnuCheckSpelling.CheckOnClick = true;
			this.mnuCheckSpelling.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuCheckSpelling.Name = "mnuCheckSpelling";
			this.mnuCheckSpelling.Size = new System.Drawing.Size(175, 24);
			this.mnuCheckSpelling.Text = "Check Spelling";
			//
			//mnuSpellingLanguage
			//
			this.mnuSpellingLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuEnglish });
			this.mnuSpellingLanguage.Name = "mnuSpellingLanguage";
			this.mnuSpellingLanguage.Size = new System.Drawing.Size(175, 24);
			this.mnuSpellingLanguage.Text = "&Language";
			//
			//mnuEnglish
			//
			this.mnuEnglish.Checked = true;
			this.mnuEnglish.CheckOnClick = true;
			this.mnuEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuEnglish.Name = "mnuEnglish";
			this.mnuEnglish.Size = new System.Drawing.Size(125, 24);
			this.mnuEnglish.Text = "&English";
			//
			//mnuToolsDataDirectory
			//
			this.mnuToolsDataDirectory.Image = (System.Drawing.Image)resources.GetObject("mnuToolsDataDirectory.Image");
			this.mnuToolsDataDirectory.Name = "mnuToolsDataDirectory";
			this.mnuToolsDataDirectory.Size = new System.Drawing.Size(211, 24);
			this.mnuToolsDataDirectory.Text = "D&ata Directory";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuHelpAbout,
				this.mnuQuickStart,
				this.ToolStripMenuItem11,
				this.mnuHelpUpdate,
				this.mnuHelpSupport
			});
			this.HelpToolStripMenuItem.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.HelpToolStripMenuItem.Text = "&Help";
			//
			//mnuHelpAbout
			//
			this.mnuHelpAbout.Image = (System.Drawing.Image)resources.GetObject("mnuHelpAbout.Image");
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(150, 24);
			this.mnuHelpAbout.Text = "&About";
			//
			//mnuQuickStart
			//
			this.mnuQuickStart.Image = (System.Drawing.Image)resources.GetObject("mnuQuickStart.Image");
			this.mnuQuickStart.Name = "mnuQuickStart";
			this.mnuQuickStart.Size = new System.Drawing.Size(150, 24);
			this.mnuQuickStart.Text = "&Quick Start";
			//
			//ToolStripMenuItem11
			//
			this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
			this.ToolStripMenuItem11.Size = new System.Drawing.Size(147, 6);
			//
			//mnuHelpUpdate
			//
			this.mnuHelpUpdate.Image = (System.Drawing.Image)resources.GetObject("mnuHelpUpdate.Image");
			this.mnuHelpUpdate.Name = "mnuHelpUpdate";
			this.mnuHelpUpdate.Size = new System.Drawing.Size(150, 24);
			this.mnuHelpUpdate.Text = "&Register...";
			//
			//mnuHelpSupport
			//
			this.mnuHelpSupport.Image = (System.Drawing.Image)resources.GetObject("mnuHelpSupport.Image");
			this.mnuHelpSupport.Name = "mnuHelpSupport";
			this.mnuHelpSupport.Size = new System.Drawing.Size(150, 24);
			this.mnuHelpSupport.Text = "&Support...";
			//
			//SplitContainer1
			//
			this.SplitContainer1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.SplitContainer1.Location = new System.Drawing.Point(12, 113);
			this.SplitContainer1.Name = "SplitContainer1";
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.Panel3D1);
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.pnlContainer);
			this.SplitContainer1.Size = new System.Drawing.Size(984, 605);
			this.SplitContainer1.SplitterDistance = 246;
			this.SplitContainer1.SplitterWidth = 5;
			this.SplitContainer1.TabIndex = 26;
			//
			//Panel3D1
			//
			this.Panel3D1.BackColor = System.Drawing.Color.White;
			this.Panel3D1.Controls.Add(this.Panel3D8);
			this.Panel3D1.Controls.Add(this.trvMain);
			this.Panel3D1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3D1.Location = new System.Drawing.Point(0, 0);
			this.Panel3D1.Name = "Panel3D1";
			this.Panel3D1.Size = new System.Drawing.Size(246, 605);
			this.Panel3D1.TabIndex = 23;
			//
			//Panel3D8
			//
			this.Panel3D8.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D8.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.Panel3D8.Controls.Add(this.Label3);
			this.Panel3D8.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D8.Location = new System.Drawing.Point(0, 0);
			this.Panel3D8.Name = "Panel3D8";
			this.Panel3D8.Size = new System.Drawing.Size(246, 24);
			this.Panel3D8.TabIndex = 6;
			//
			//Label3
			//
			this.Label3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label3.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label3.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label3.Location = new System.Drawing.Point(7, 3);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(236, 19);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Explorer";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//trvMain
			//
			this.trvMain.AllowDrop = true;
			this.trvMain.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.trvMain.BackColor = global::LightenedDream.My.MySettings.Default.TextBackColor;
			this.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvMain.ContextMenuStrip = this.mnuTrv;
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TextBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.trvMain.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.trvMain.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.trvMain.HideSelection = false;
			this.trvMain.ImageIndex = 0;
			this.trvMain.ImageList = this.lstImgTrv;
			this.trvMain.ItemHeight = 18;
			this.trvMain.Location = new System.Drawing.Point(2, 25);
			this.trvMain.Name = "trvMain";
			TreeNode13.Name = "Node0";
			TreeNode13.Text = "Node0";
			TreeNode14.Name = "Node0";
			TreeNode14.Text = "Dreams";
			TreeNode15.Name = "Node1";
			TreeNode15.Text = "Characters";
			TreeNode16.Name = "Node3";
			TreeNode16.Text = "Locations";
			TreeNode17.Name = "Node4";
			TreeNode17.Text = "Objects";
			TreeNode18.Name = "Node0";
			TreeNode18.Text = "Actions";
			TreeNode19.Name = "Node5";
			TreeNode19.Text = "Themes";
			TreeNode20.Name = "Node14";
			TreeNode20.Text = "Categories";
			TreeNode21.Name = "Node10";
			TreeNode21.Text = "REM Cycles";
			TreeNode22.Name = "Node11";
			TreeNode22.Text = "Reality Checks";
			TreeNode23.Name = "Node12";
			TreeNode23.Text = "Dream Inductions";
			TreeNode24.Name = "Node8";
			TreeNode24.Text = "Lucidity";
			this.trvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
				TreeNode14,
				TreeNode20,
				TreeNode24
			});
			this.trvMain.SelectedImageIndex = 1;
			this.trvMain.ShowLines = false;
			this.trvMain.Size = new System.Drawing.Size(240, 578);
			this.trvMain.TabIndex = 0;
			//
			//mnuTrv
			//
			this.mnuTrv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ToolStripMenuItem1,
				this.ToolStripMenuItem20,
				this.mnuTrvDelete,
				this.mnuTrvPlay,
				this.ToolStripMenuItem21,
				this.mnuTrvExplorer,
				this.mnuTrvSendTo
			});
			this.mnuTrv.Name = "mnuTrv";
			this.mnuTrv.Size = new System.Drawing.Size(203, 136);
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ToolStripMenuItem2,
				this.ToolStripSeparator1,
				this.mnuTreeNewCategoryFolder,
				this.mnuTreeNewCategoryItem,
				this.ToolStripSeparator2,
				this.ToolStripMenuItem15,
				this.ToolStripMenuItem17,
				this.ToolStripMenuItem18,
				this.ToolStripMenuItem19,
				this.mnuTrvNewExercise,
				this.RandomExerciseToolStripMenuItem1
			});
			this.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem1.Image");
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
			this.ToolStripMenuItem1.Text = "&New";
			//
			//ToolStripMenuItem2
			//
			this.ToolStripMenuItem2.Image = global::LightenedDream.My.Resources.Resources.Dream_Final2;
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(191, 24);
			this.ToolStripMenuItem2.Text = "&Dream";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(188, 6);
			//
			//mnuTreeNewCategoryFolder
			//
			this.mnuTreeNewCategoryFolder.Image = global::LightenedDream.My.Resources.Resources.Folder_16;
			this.mnuTreeNewCategoryFolder.Name = "mnuTreeNewCategoryFolder";
			this.mnuTreeNewCategoryFolder.Size = new System.Drawing.Size(191, 24);
			this.mnuTreeNewCategoryFolder.Tag = "Category";
			this.mnuTreeNewCategoryFolder.Text = "Category";
			//
			//mnuTreeNewCategoryItem
			//
			this.mnuTreeNewCategoryItem.Image = global::LightenedDream.My.Resources.Resources.Categories;
			this.mnuTreeNewCategoryItem.Name = "mnuTreeNewCategoryItem";
			this.mnuTreeNewCategoryItem.Size = new System.Drawing.Size(191, 24);
			this.mnuTreeNewCategoryItem.Tag = "CategoryItem";
			this.mnuTreeNewCategoryItem.Text = "Category Item";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(188, 6);
			//
			//ToolStripMenuItem15
			//
			this.ToolStripMenuItem15.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem15.Image");
			this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
			this.ToolStripMenuItem15.Size = new System.Drawing.Size(191, 24);
			this.ToolStripMenuItem15.Text = "&REM Cycle";
			//
			//ToolStripMenuItem17
			//
			this.ToolStripMenuItem17.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem17.Image");
			this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
			this.ToolStripMenuItem17.Size = new System.Drawing.Size(191, 24);
			this.ToolStripMenuItem17.Tag = "Subliminal";
			this.ToolStripMenuItem17.Text = "&Subliminal";
			//
			//ToolStripMenuItem18
			//
			this.ToolStripMenuItem18.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem18.Image");
			this.ToolStripMenuItem18.Name = "ToolStripMenuItem18";
			this.ToolStripMenuItem18.Size = new System.Drawing.Size(191, 24);
			this.ToolStripMenuItem18.Tag = "Recording";
			this.ToolStripMenuItem18.Text = "&Recording";
			//
			//ToolStripMenuItem19
			//
			this.ToolStripMenuItem19.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem19.Image");
			this.ToolStripMenuItem19.Name = "ToolStripMenuItem19";
			this.ToolStripMenuItem19.Size = new System.Drawing.Size(191, 24);
			this.ToolStripMenuItem19.Tag = "Reading";
			this.ToolStripMenuItem19.Text = "&Reading";
			//
			//mnuTrvNewExercise
			//
			this.mnuTrvNewExercise.Image = global::LightenedDream.My.Resources.Resources.Dream_Final1;
			this.mnuTrvNewExercise.Name = "mnuTrvNewExercise";
			this.mnuTrvNewExercise.Size = new System.Drawing.Size(191, 24);
			this.mnuTrvNewExercise.Text = "&Exercise";
			//
			//RandomExerciseToolStripMenuItem1
			//
			this.RandomExerciseToolStripMenuItem1.Image = global::LightenedDream.My.Resources.Resources.Dream_Final_2;
			this.RandomExerciseToolStripMenuItem1.Name = "RandomExerciseToolStripMenuItem1";
			this.RandomExerciseToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
			this.RandomExerciseToolStripMenuItem1.Text = "&Random Exercise";
			//
			//ToolStripMenuItem20
			//
			this.ToolStripMenuItem20.Name = "ToolStripMenuItem20";
			this.ToolStripMenuItem20.Size = new System.Drawing.Size(199, 6);
			//
			//mnuTrvDelete
			//
			this.mnuTrvDelete.Image = (System.Drawing.Image)resources.GetObject("mnuTrvDelete.Image");
			this.mnuTrvDelete.Name = "mnuTrvDelete";
			this.mnuTrvDelete.Size = new System.Drawing.Size(202, 24);
			this.mnuTrvDelete.Text = "&Delete";
			//
			//mnuTrvPlay
			//
			this.mnuTrvPlay.Image = (System.Drawing.Image)resources.GetObject("mnuTrvPlay.Image");
			this.mnuTrvPlay.Name = "mnuTrvPlay";
			this.mnuTrvPlay.Size = new System.Drawing.Size(202, 24);
			this.mnuTrvPlay.Text = "&Play";
			//
			//ToolStripMenuItem21
			//
			this.ToolStripMenuItem21.Name = "ToolStripMenuItem21";
			this.ToolStripMenuItem21.Size = new System.Drawing.Size(199, 6);
			//
			//mnuTrvExplorer
			//
			this.mnuTrvExplorer.Image = global::LightenedDream.My.Resources.Resources.Folder_Launch_16;
			this.mnuTrvExplorer.Name = "mnuTrvExplorer";
			this.mnuTrvExplorer.Size = new System.Drawing.Size(202, 24);
			this.mnuTrvExplorer.Text = "&Open File Location";
			//
			//mnuTrvSendTo
			//
			this.mnuTrvSendTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.mnuTrvSendToDesktop,
				this.mnuTrvSendToLD4All
			});
			this.mnuTrvSendTo.Image = global::LightenedDream.My.Resources.Resources.Graph_Export;
			this.mnuTrvSendTo.Name = "mnuTrvSendTo";
			this.mnuTrvSendTo.Size = new System.Drawing.Size(202, 24);
			this.mnuTrvSendTo.Text = "&Send To";
			//
			//mnuTrvSendToDesktop
			//
			this.mnuTrvSendToDesktop.Image = (System.Drawing.Image)resources.GetObject("mnuTrvSendToDesktop.Image");
			this.mnuTrvSendToDesktop.Name = "mnuTrvSendToDesktop";
			this.mnuTrvSendToDesktop.Size = new System.Drawing.Size(133, 24);
			this.mnuTrvSendToDesktop.Text = "&Desktop";
			//
			//mnuTrvSendToLD4All
			//
			this.mnuTrvSendToLD4All.Name = "mnuTrvSendToLD4All";
			this.mnuTrvSendToLD4All.Size = new System.Drawing.Size(133, 24);
			this.mnuTrvSendToLD4All.Text = "LD4All";
			this.mnuTrvSendToLD4All.Visible = false;
			//
			//lstImgTrv
			//
			this.lstImgTrv.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgTrv.ImageStream");
			this.lstImgTrv.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImgTrv.Images.SetKeyName(0, "Folder.16.ico");
			this.lstImgTrv.Images.SetKeyName(1, "Folder.Open.16.ico");
			this.lstImgTrv.Images.SetKeyName(2, "File.Characters0");
			this.lstImgTrv.Images.SetKeyName(3, "File.Characters");
			this.lstImgTrv.Images.SetKeyName(4, "File.Locations");
			this.lstImgTrv.Images.SetKeyName(5, "File.Objects");
			this.lstImgTrv.Images.SetKeyName(6, "File.Themes");
			this.lstImgTrv.Images.SetKeyName(7, "File.Emotions");
			this.lstImgTrv.Images.SetKeyName(8, "File.Actions");
			this.lstImgTrv.Images.SetKeyName(9, "File.Recordings");
			this.lstImgTrv.Images.SetKeyName(10, "File.Subliminals");
			this.lstImgTrv.Images.SetKeyName(11, "File.Checks");
			this.lstImgTrv.Images.SetKeyName(12, "File.Readings");
			this.lstImgTrv.Images.SetKeyName(13, "File.REM Cycles");
			this.lstImgTrv.Images.SetKeyName(14, "Dream");
			this.lstImgTrv.Images.SetKeyName(15, "Exercise");
			this.lstImgTrv.Images.SetKeyName(16, "Categories.ico");
			//
			//pnlContainer
			//
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(733, 605);
			this.pnlContainer.TabIndex = 0;
			//
			//tmrLoad
			//
			this.tmrLoad.Enabled = true;
			//
			//Panel3D5
			//
			this.Panel3D5.Controls.Add(this.Panel3D7);
			this.Panel3D5.Controls.Add(this.ToolStrip3);
			this.Panel3D5.Location = new System.Drawing.Point(265, 27);
			this.Panel3D5.Name = "Panel3D5";
			this.Panel3D5.Size = new System.Drawing.Size(378, 80);
			this.Panel3D5.TabIndex = 28;
			//
			//Panel3D7
			//
			this.Panel3D7.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3D7.BackColor = global::LightenedDream.My.MySettings.Default.TitleBackColor;
			this.Panel3D7.Controls.Add(this.Label6);
			this.Panel3D7.Controls.Add(this.Label2);
			this.Panel3D7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "TitleBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Panel3D7.Location = new System.Drawing.Point(0, 0);
			this.Panel3D7.Name = "Panel3D7";
			this.Panel3D7.Size = new System.Drawing.Size(378, 24);
			this.Panel3D7.TabIndex = 5;
			//
			//Label6
			//
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label6.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label6.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label6.Image = global::LightenedDream.My.Resources.Resources.Lucidity;
			this.Label6.Location = new System.Drawing.Point(4, 4);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(16, 16);
			this.Label6.TabIndex = 6;
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "TitleForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Label2.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::LightenedDream.My.MySettings.Default.TitleForeColor;
			this.Label2.Location = new System.Drawing.Point(24, 3);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(351, 19);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Lucidity";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ToolStrip3
			//
			this.ToolStrip3.AutoSize = false;
			this.ToolStrip3.BackColor = System.Drawing.Color.Transparent;
			this.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None;
			this.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.toolPlay,
				this.toolREMCycles,
				this.toolSubliminals,
				this.toolRecordings,
				this.toolReadings,
				this.toolLucidityExercises
			});
			this.ToolStrip3.Location = new System.Drawing.Point(10, 27);
			this.ToolStrip3.Name = "ToolStrip3";
			this.ToolStrip3.ShowItemToolTips = false;
			this.ToolStrip3.Size = new System.Drawing.Size(380, 54);
			this.ToolStrip3.TabIndex = 6;
			this.ToolStrip3.Text = "ToolStrip3";
			//
			//toolPlay
			//
			this.toolPlay.AutoSize = false;
			this.toolPlay.Enabled = false;
			this.toolPlay.Image = global::LightenedDream.My.Resources.Resources.Function_Play;
			this.toolPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolPlay.ImageTransparentColor = System.Drawing.Color.White;
			this.toolPlay.Name = "toolPlay";
			this.toolPlay.Size = new System.Drawing.Size(40, 48);
			this.toolPlay.Text = "&Play";
			this.toolPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolREMCycles
			//
			this.toolREMCycles.AutoSize = false;
			this.toolREMCycles.Image = (System.Drawing.Image)resources.GetObject("toolREMCycles.Image");
			this.toolREMCycles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolREMCycles.ImageTransparentColor = System.Drawing.Color.White;
			this.toolREMCycles.Name = "toolREMCycles";
			this.toolREMCycles.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolREMCycles.Size = new System.Drawing.Size(68, 48);
			this.toolREMCycles.Tag = "REM Cycles";
			this.toolREMCycles.Text = "&REM Cycles";
			this.toolREMCycles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolSubliminals
			//
			this.toolSubliminals.AutoSize = false;
			this.toolSubliminals.Image = (System.Drawing.Image)resources.GetObject("toolSubliminals.Image");
			this.toolSubliminals.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolSubliminals.ImageTransparentColor = System.Drawing.Color.White;
			this.toolSubliminals.Name = "toolSubliminals";
			this.toolSubliminals.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolSubliminals.Size = new System.Drawing.Size(68, 48);
			this.toolSubliminals.Tag = "Subliminals";
			this.toolSubliminals.Text = "&Subliminals";
			this.toolSubliminals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolRecordings
			//
			this.toolRecordings.AutoSize = false;
			this.toolRecordings.Image = global::LightenedDream.My.Resources.Resources.Action_Record;
			this.toolRecordings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolRecordings.ImageTransparentColor = System.Drawing.Color.White;
			this.toolRecordings.Name = "toolRecordings";
			this.toolRecordings.Size = new System.Drawing.Size(64, 48);
			this.toolRecordings.Tag = "Recordings";
			this.toolRecordings.Text = "&Recordings";
			this.toolRecordings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolReadings
			//
			this.toolReadings.AutoSize = false;
			this.toolReadings.Image = (System.Drawing.Image)resources.GetObject("toolReadings.Image");
			this.toolReadings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolReadings.ImageTransparentColor = System.Drawing.Color.White;
			this.toolReadings.Name = "toolReadings";
			this.toolReadings.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolReadings.Size = new System.Drawing.Size(56, 48);
			this.toolReadings.Tag = "Readings";
			this.toolReadings.Text = "Readin&gs";
			this.toolReadings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//toolLucidityExercises
			//
			this.toolLucidityExercises.AutoSize = false;
			this.toolLucidityExercises.Image = (System.Drawing.Image)resources.GetObject("toolLucidityExercises.Image");
			this.toolLucidityExercises.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolLucidityExercises.ImageTransparentColor = System.Drawing.Color.White;
			this.toolLucidityExercises.Name = "toolLucidityExercises";
			this.toolLucidityExercises.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolLucidityExercises.Size = new System.Drawing.Size(58, 48);
			this.toolLucidityExercises.Tag = "Exercises";
			this.toolLucidityExercises.Text = "E&xercises";
			this.toolLucidityExercises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			//lblStatus
			//
			this.lblStatus.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lblStatus.Location = new System.Drawing.Point(12, 708);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(984, 18);
			this.lblStatus.TabIndex = 29;
			this.lblStatus.Visible = false;
			//
			//lstImgIco
			//
			this.lstImgIco.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("lstImgIco.ImageStream");
			this.lstImgIco.TransparentColor = System.Drawing.Color.Transparent;
			this.lstImgIco.Images.SetKeyName(0, "Dream.0.ico");
			this.lstImgIco.Images.SetKeyName(1, "Dream.1.ico");
			this.lstImgIco.Images.SetKeyName(2, "Dream.2.ico");
			this.lstImgIco.Images.SetKeyName(3, "Dream.3.ico");
			this.lstImgIco.Images.SetKeyName(4, "Dream.4.ico");
			this.lstImgIco.Images.SetKeyName(5, "Dream.5.ico");
			this.lstImgIco.Images.SetKeyName(6, "Dream.6.ico");
			this.lstImgIco.Images.SetKeyName(7, "Dream.7.ico");
			this.lstImgIco.Images.SetKeyName(8, "Dream.8.ico");
			this.lstImgIco.Images.SetKeyName(9, "Dream.9.ico");
			this.lstImgIco.Images.SetKeyName(10, "Dream.10.ico");
			this.lstImgIco.Images.SetKeyName(11, "Dream.11.ico");
			this.lstImgIco.Images.SetKeyName(12, "Dream.12.ico");
			this.lstImgIco.Images.SetKeyName(13, "Dream.13.ico");
			this.lstImgIco.Images.SetKeyName(14, "Dream.14.ico");
			this.lstImgIco.Images.SetKeyName(15, "Dream.15.ico");
			this.lstImgIco.Images.SetKeyName(16, "Dream.16.ico");
			this.lstImgIco.Images.SetKeyName(17, "Dream.17.ico");
			this.lstImgIco.Images.SetKeyName(18, "Dream.18.ico");
			this.lstImgIco.Images.SetKeyName(19, "Dream.19.ico");
			this.lstImgIco.Images.SetKeyName(20, "Dream.20.ico");
			this.lstImgIco.Images.SetKeyName(21, "Dream.21.ico");
			this.lstImgIco.Images.SetKeyName(22, "Dream.22.ico");
			this.lstImgIco.Images.SetKeyName(23, "Dream.23.ico");
			this.lstImgIco.Images.SetKeyName(24, "Dream.24.ico");
			this.lstImgIco.Images.SetKeyName(25, "Dream.25.ico");
			this.lstImgIco.Images.SetKeyName(26, "Dream.26.ico");
			this.lstImgIco.Images.SetKeyName(27, "Dream.27.ico");
			this.lstImgIco.Images.SetKeyName(28, "Dream.28.ico");
			this.lstImgIco.Images.SetKeyName(29, "Dream.29.ico");
			this.lstImgIco.Images.SetKeyName(30, "Dream.30.ico");
			this.lstImgIco.Images.SetKeyName(31, "Dream.31.ico");
			this.lstImgIco.Images.SetKeyName(32, "Dream.32.ico");
			this.lstImgIco.Images.SetKeyName(33, "Dream.33.ico");
			//
			//tmrProcessing
			//
			this.tmrProcessing.Enabled = true;
			this.tmrProcessing.Interval = 250;
			//
			//pnlProcessing
			//
			this.pnlProcessing.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.pnlProcessing.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.pnlProcessing.Controls.Add(this.pnlSearching);
			this.pnlProcessing.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlProcessing.Location = new System.Drawing.Point(12, 27);
			this.pnlProcessing.Name = "pnlProcessing";
			this.pnlProcessing.Size = new System.Drawing.Size(984, 691);
			this.pnlProcessing.TabIndex = 30;
			this.pnlProcessing.Visible = false;
			//
			//pnlSearching
			//
			this.pnlSearching.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			MySettings4.Font = new System.Drawing.Font("Verdana", 8.25f);
			MySettings4.FormBackColor = System.Drawing.Color.LightSteelBlue;
			MySettings4.FormForeColor = System.Drawing.Color.MidnightBlue;
			MySettings4.LastAsleep = new System.DateTime(Convert.ToInt64(0));
			MySettings4.LastAwake = new System.DateTime(Convert.ToInt64(0));
			MySettings4.SettingsKey = "";
			MySettings4.TextBackColor = System.Drawing.Color.White;
			MySettings4.TitleBackColor = System.Drawing.Color.SteelBlue;
			MySettings4.TitleForeColor = System.Drawing.Color.White;
			this.pnlSearching.BackColor = MySettings4.FormBackColor;
			this.pnlSearching.Controls.Add(this.graph);
			this.pnlSearching.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", MySettings4, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pnlSearching.Location = new System.Drawing.Point(0, 0);
			this.pnlSearching.Name = "pnlSearching";
			this.pnlSearching.Size = new System.Drawing.Size(984, 691);
			this.pnlSearching.TabIndex = 19;
			//
			//graph
			//
			this.graph.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.graph.BackColor = System.Drawing.Color.Transparent;
			ChartArea4.Area3DStyle.Enable3D = true;
			ChartArea4.Area3DStyle.Inclination = 10;
			ChartArea4.Area3DStyle.IsClustered = true;
			ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
			ChartArea4.Area3DStyle.PointDepth = 200;
			ChartArea4.Area3DStyle.PointGapDepth = 0;
			ChartArea4.Area3DStyle.Rotation = 10;
			ChartArea4.Area3DStyle.WallWidth = 0;
			ChartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea4.AxisX.IsLabelAutoFit = false;
			ChartArea4.AxisX.LabelStyle.Angle = 90;
			ChartArea4.AxisX.LabelStyle.Enabled = false;
			ChartArea4.AxisX.LabelStyle.Interval = 0.0;
			ChartArea4.AxisX.LineColor = System.Drawing.Color.Transparent;
			ChartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			ChartArea4.AxisX.LineWidth = 0;
			ChartArea4.AxisX.MajorGrid.Enabled = false;
			ChartArea4.AxisX.MajorGrid.LineWidth = 0;
			ChartArea4.AxisX.MajorTickMark.Enabled = false;
			ChartArea4.AxisX.MajorTickMark.LineWidth = 0;
			ChartArea4.AxisX.MajorTickMark.Size = 0f;
			ChartArea4.AxisX.MinorGrid.LineWidth = 0;
			ChartArea4.AxisX.MinorTickMark.LineWidth = 0;
			ChartArea4.AxisX.MinorTickMark.Size = 0f;
			ChartArea4.AxisX.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			CustomLabel7.Text = "x";
			CustomLabel8.Text = "x";
			ChartArea4.AxisX2.CustomLabels.Add(CustomLabel7);
			ChartArea4.AxisX2.CustomLabels.Add(CustomLabel8);
			ChartArea4.AxisX2.LineWidth = 0;
			ChartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			ChartArea4.AxisY.LabelStyle.Enabled = false;
			ChartArea4.AxisY.LineWidth = 0;
			ChartArea4.AxisY.MajorGrid.Enabled = false;
			ChartArea4.AxisY.MajorTickMark.Enabled = false;
			ChartArea4.AxisY.TitleForeColor = System.Drawing.Color.LightSteelBlue;
			ChartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			ChartArea4.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			ChartArea4.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea4.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
			ChartArea4.AxisY2.LineWidth = 0;
			ChartArea4.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartArea4.AxisY2.Maximum = 11.0;
			ChartArea4.AxisY2.Minimum = -11.0;
			ChartArea4.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
			ChartArea4.AxisY2.ScaleBreakStyle.Enabled = true;
			ChartArea4.BackColor = System.Drawing.Color.LightSteelBlue;
			ChartArea4.BackImageTransparentColor = System.Drawing.Color.White;
			ChartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
			ChartArea4.BorderColor = System.Drawing.Color.LightSteelBlue;
			ChartArea4.BorderWidth = 0;
			ChartArea4.Name = "ChartArea1";
			ChartArea4.ShadowColor = System.Drawing.Color.Transparent;
			this.graph.ChartAreas.Add(ChartArea4);
			this.graph.Location = new System.Drawing.Point(3, 3);
			this.graph.Name = "graph";
			Series4.ChartArea = "ChartArea1";
			Series4.Name = "Series1";
			this.graph.Series.Add(Series4);
			this.graph.Size = new System.Drawing.Size(978, 685);
			this.graph.TabIndex = 283;
			//
			//tmrSaving
			//
			this.tmrSaving.Interval = 128;
			//
			//MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9f, 17f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::LightenedDream.My.MySettings.Default.FormBackColor;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.pnlProcessing);
			this.Controls.Add(this.SplitContainer1);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.Panel3D3);
			this.Controls.Add(this.Panel3D5);
			this.Controls.Add(this.MenuStrip1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::LightenedDream.My.MySettings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LightenedDream.My.MySettings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::LightenedDream.My.MySettings.Default, "FormForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Font = global::LightenedDream.My.MySettings.Default.Font;
			this.ForeColor = global::LightenedDream.My.MySettings.Default.FormForeColor;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.KeyPreview = true;
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "MainForm";
			this.Text = "Lightened Dream";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.Panel3D3.ResumeLayout(false);
			this.Panel3D6.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.Panel3D1.ResumeLayout(false);
			this.Panel3D8.ResumeLayout(false);
			this.mnuTrv.ResumeLayout(false);
			this.Panel3D5.ResumeLayout(false);
			this.Panel3D7.ResumeLayout(false);
			this.ToolStrip3.ResumeLayout(false);
			this.ToolStrip3.PerformLayout();
			this.pnlProcessing.ResumeLayout(false);
			this.pnlSearching.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.graph).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.ToolStrip ToolStrip1;
		private System.Windows.Forms.ToolStripButton withEventsField_toolSave;
		internal System.Windows.Forms.ToolStripButton toolSave {
			get { return withEventsField_toolSave; }
			set {
				if (withEventsField_toolSave != null) {
					withEventsField_toolSave.Click -= toolSave_Click;
				}
				withEventsField_toolSave = value;
				if (withEventsField_toolSave != null) {
					withEventsField_toolSave.Click += toolSave_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolDelete;
		internal System.Windows.Forms.ToolStripButton toolDelete {
			get { return withEventsField_toolDelete; }
			set {
				if (withEventsField_toolDelete != null) {
					withEventsField_toolDelete.Click -= toolDelete_Click;
				}
				withEventsField_toolDelete = value;
				if (withEventsField_toolDelete != null) {
					withEventsField_toolDelete.Click += toolDelete_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolBack;
		internal System.Windows.Forms.ToolStripButton toolBack {
			get { return withEventsField_toolBack; }
			set {
				if (withEventsField_toolBack != null) {
					withEventsField_toolBack.Click -= toolBack_Click;
				}
				withEventsField_toolBack = value;
				if (withEventsField_toolBack != null) {
					withEventsField_toolBack.Click += toolBack_Click;
				}
			}
		}
		internal lucidcode.Controls.Panel3D Panel3D3;
		internal lucidcode.Controls.Panel3D Panel3D6;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.SplitContainer SplitContainer1;
		internal lucidcode.Controls.Panel3D Panel3D1;
		private System.Windows.Forms.TreeView withEventsField_trvMain;
		internal System.Windows.Forms.TreeView trvMain {
			get { return withEventsField_trvMain; }
			set {
				if (withEventsField_trvMain != null) {
					withEventsField_trvMain.AfterSelect -= trvMain_AfterSelect;
					withEventsField_trvMain.KeyDown -= trvMain_KeyDown;
					withEventsField_trvMain.AfterExpand -= trvMain_AfterExpand;
					withEventsField_trvMain.AfterCollapse -= trvMain_AfterCollapse;
					withEventsField_trvMain.DragEnter -= trvMain_DragEnter;
					withEventsField_trvMain.DragDrop -= trvMain_DragDrop;
					withEventsField_trvMain.DragOver -= trvMain_DragOver;
					withEventsField_trvMain.BeforeExpand -= trvMain_BeforeExpand;
					withEventsField_trvMain.BeforeSelect -= trvMain_BeforeSelect;
					withEventsField_trvMain.ItemDrag -= trvMain_ItemDrag;
					withEventsField_trvMain.MouseDown -= trvMain_MouseDown;
				}
				withEventsField_trvMain = value;
				if (withEventsField_trvMain != null) {
					withEventsField_trvMain.AfterSelect += trvMain_AfterSelect;
					withEventsField_trvMain.KeyDown += trvMain_KeyDown;
					withEventsField_trvMain.AfterExpand += trvMain_AfterExpand;
					withEventsField_trvMain.AfterCollapse += trvMain_AfterCollapse;
					withEventsField_trvMain.DragEnter += trvMain_DragEnter;
					withEventsField_trvMain.DragDrop += trvMain_DragDrop;
					withEventsField_trvMain.DragOver += trvMain_DragOver;
					withEventsField_trvMain.BeforeExpand += trvMain_BeforeExpand;
					withEventsField_trvMain.BeforeSelect += trvMain_BeforeSelect;
					withEventsField_trvMain.ItemDrag += trvMain_ItemDrag;
					withEventsField_trvMain.MouseDown += trvMain_MouseDown;
				}
			}
		}
		internal System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Timer withEventsField_tmrLoad;
		internal System.Windows.Forms.Timer tmrLoad {
			get { return withEventsField_tmrLoad; }
			set {
				if (withEventsField_tmrLoad != null) {
					withEventsField_tmrLoad.Tick -= tmrLoad_Tick;
				}
				withEventsField_tmrLoad = value;
				if (withEventsField_tmrLoad != null) {
					withEventsField_tmrLoad.Tick += tmrLoad_Tick;
				}
			}
		}
		private System.Windows.Forms.ToolStripDropDownButton withEventsField_toolNew;
		internal System.Windows.Forms.ToolStripDropDownButton toolNew {
			get { return withEventsField_toolNew; }
			set {
				if (withEventsField_toolNew != null) {
					withEventsField_toolNew.Click -= toolNew_Click;
					withEventsField_toolNew.DropDownOpening -= toolNew_DropDownOpening;
				}
				withEventsField_toolNew = value;
				if (withEventsField_toolNew != null) {
					withEventsField_toolNew.Click += toolNew_Click;
					withEventsField_toolNew.DropDownOpening += toolNew_DropDownOpening;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewDream;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewDream {
			get { return withEventsField_mnuToolNewDream; }
			set {
				if (withEventsField_mnuToolNewDream != null) {
					withEventsField_mnuToolNewDream.Click -= mnuToolNewDream_Click;
				}
				withEventsField_mnuToolNewDream = value;
				if (withEventsField_mnuToolNewDream != null) {
					withEventsField_mnuToolNewDream.Click += mnuToolNewDream_Click;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImgTrv;
		internal lucidcode.Controls.Panel3D Panel3D8;
		internal System.Windows.Forms.Label Label3;
		internal lucidcode.Controls.Panel3D Panel3D5;
		internal lucidcode.Controls.Panel3D Panel3D7;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ToolStrip ToolStrip3;
		private System.Windows.Forms.ToolStripButton withEventsField_toolREMCycles;
		internal System.Windows.Forms.ToolStripButton toolREMCycles {
			get { return withEventsField_toolREMCycles; }
			set {
				if (withEventsField_toolREMCycles != null) {
					withEventsField_toolREMCycles.Click -= toolLucidity_Click;
				}
				withEventsField_toolREMCycles = value;
				if (withEventsField_toolREMCycles != null) {
					withEventsField_toolREMCycles.Click += toolLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolForward;
		internal System.Windows.Forms.ToolStripButton toolForward {
			get { return withEventsField_toolForward; }
			set {
				if (withEventsField_toolForward != null) {
					withEventsField_toolForward.Click -= toolForward_Click;
				}
				withEventsField_toolForward = value;
				if (withEventsField_toolForward != null) {
					withEventsField_toolForward.Click += toolForward_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolUpdate;
		internal System.Windows.Forms.ToolStripButton toolUpdate {
			get { return withEventsField_toolUpdate; }
			set {
				if (withEventsField_toolUpdate != null) {
					withEventsField_toolUpdate.Click -= toolUpdate_Click;
				}
				withEventsField_toolUpdate = value;
				if (withEventsField_toolUpdate != null) {
					withEventsField_toolUpdate.Click += toolUpdate_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_NewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem {
			get { return withEventsField_NewToolStripMenuItem; }
			set {
				if (withEventsField_NewToolStripMenuItem != null) {
					withEventsField_NewToolStripMenuItem.DropDownOpening -= NewToolStripMenuItem_DropDownOpening;
				}
				withEventsField_NewToolStripMenuItem = value;
				if (withEventsField_NewToolStripMenuItem != null) {
					withEventsField_NewToolStripMenuItem.DropDownOpening += NewToolStripMenuItem_DropDownOpening;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuFileSave;
		internal System.Windows.Forms.ToolStripMenuItem mnuFileSave {
			get { return withEventsField_mnuFileSave; }
			set {
				if (withEventsField_mnuFileSave != null) {
					withEventsField_mnuFileSave.Click -= mnuFileSave_Click;
				}
				withEventsField_mnuFileSave = value;
				if (withEventsField_mnuFileSave != null) {
					withEventsField_mnuFileSave.Click += mnuFileSave_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuFileDelete;
		internal System.Windows.Forms.ToolStripMenuItem mnuFileDelete {
			get { return withEventsField_mnuFileDelete; }
			set {
				if (withEventsField_mnuFileDelete != null) {
					withEventsField_mnuFileDelete.Click -= mnuFileDelete_Click;
				}
				withEventsField_mnuFileDelete = value;
				if (withEventsField_mnuFileDelete != null) {
					withEventsField_mnuFileDelete.Click += mnuFileDelete_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuHelpAbout;
		internal System.Windows.Forms.ToolStripMenuItem mnuHelpAbout {
			get { return withEventsField_mnuHelpAbout; }
			set {
				if (withEventsField_mnuHelpAbout != null) {
					withEventsField_mnuHelpAbout.Click -= mnuHelpAbout_Click;
				}
				withEventsField_mnuHelpAbout = value;
				if (withEventsField_mnuHelpAbout != null) {
					withEventsField_mnuHelpAbout.Click += mnuHelpAbout_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ToolStripButton withEventsField_toolPlay;
		internal System.Windows.Forms.ToolStripButton toolPlay {
			get { return withEventsField_toolPlay; }
			set {
				if (withEventsField_toolPlay != null) {
					withEventsField_toolPlay.Click -= toolPlay_Click;
				}
				withEventsField_toolPlay = value;
				if (withEventsField_toolPlay != null) {
					withEventsField_toolPlay.Click += toolPlay_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuFileExport;
		internal System.Windows.Forms.ToolStripMenuItem mnuFileExport {
			get { return withEventsField_mnuFileExport; }
			set {
				if (withEventsField_mnuFileExport != null) {
					withEventsField_mnuFileExport.Click -= mnuFileExport_Click;
				}
				withEventsField_mnuFileExport = value;
				if (withEventsField_mnuFileExport != null) {
					withEventsField_mnuFileExport.Click += mnuFileExport_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuFileExit;
		internal System.Windows.Forms.ToolStripMenuItem mnuFileExit {
			get { return withEventsField_mnuFileExit; }
			set {
				if (withEventsField_mnuFileExit != null) {
					withEventsField_mnuFileExit.Click -= mnuFileExit_Click;
				}
				withEventsField_mnuFileExit = value;
				if (withEventsField_mnuFileExit != null) {
					withEventsField_mnuFileExit.Click += mnuFileExit_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsPlay;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsPlay {
			get { return withEventsField_mnuToolsPlay; }
			set {
				if (withEventsField_mnuToolsPlay != null) {
					withEventsField_mnuToolsPlay.Click -= mnuToolsPlay_Click;
				}
				withEventsField_mnuToolsPlay = value;
				if (withEventsField_mnuToolsPlay != null) {
					withEventsField_mnuToolsPlay.Click += mnuToolsPlay_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolRecordings;
		internal System.Windows.Forms.ToolStripButton toolRecordings {
			get { return withEventsField_toolRecordings; }
			set {
				if (withEventsField_toolRecordings != null) {
					withEventsField_toolRecordings.Click -= toolLucidity_Click;
				}
				withEventsField_toolRecordings = value;
				if (withEventsField_toolRecordings != null) {
					withEventsField_toolRecordings.Click += toolLucidity_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_DreamToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DreamToolStripMenuItem {
			get { return withEventsField_DreamToolStripMenuItem; }
			set {
				if (withEventsField_DreamToolStripMenuItem != null) {
					withEventsField_DreamToolStripMenuItem.Click -= mnuToolNewDream_Click;
				}
				withEventsField_DreamToolStripMenuItem = value;
				if (withEventsField_DreamToolStripMenuItem != null) {
					withEventsField_DreamToolStripMenuItem.Click += mnuToolNewDream_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewCategoryItem;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewCategoryItem {
			get { return withEventsField_mnuToolNewCategoryItem; }
			set {
				if (withEventsField_mnuToolNewCategoryItem != null) {
					withEventsField_mnuToolNewCategoryItem.Click -= mnuToolNewCategoryItem_Click;
				}
				withEventsField_mnuToolNewCategoryItem = value;
				if (withEventsField_mnuToolNewCategoryItem != null) {
					withEventsField_mnuToolNewCategoryItem.Click += mnuToolNewCategoryItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewREMCycle;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewREMCycle {
			get { return withEventsField_mnuToolNewREMCycle; }
			set {
				if (withEventsField_mnuToolNewREMCycle != null) {
					withEventsField_mnuToolNewREMCycle.Click -= mnuToolNewREMCycle_Click;
				}
				withEventsField_mnuToolNewREMCycle = value;
				if (withEventsField_mnuToolNewREMCycle != null) {
					withEventsField_mnuToolNewREMCycle.Click += mnuToolNewREMCycle_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewCheck;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewCheck {
			get { return withEventsField_mnuToolNewCheck; }
			set {
				if (withEventsField_mnuToolNewCheck != null) {
					withEventsField_mnuToolNewCheck.Click -= mnuToolNewLucidItem_Click;
				}
				withEventsField_mnuToolNewCheck = value;
				if (withEventsField_mnuToolNewCheck != null) {
					withEventsField_mnuToolNewCheck.Click += mnuToolNewLucidItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewSubliminal;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewSubliminal {
			get { return withEventsField_mnuToolNewSubliminal; }
			set {
				if (withEventsField_mnuToolNewSubliminal != null) {
					withEventsField_mnuToolNewSubliminal.Click -= mnuToolNewLucidItem_Click;
				}
				withEventsField_mnuToolNewSubliminal = value;
				if (withEventsField_mnuToolNewSubliminal != null) {
					withEventsField_mnuToolNewSubliminal.Click += mnuToolNewLucidItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CategoryToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem1 {
			get { return withEventsField_CategoryToolStripMenuItem1; }
			set {
				if (withEventsField_CategoryToolStripMenuItem1 != null) {
					withEventsField_CategoryToolStripMenuItem1.Click -= mnuToolNewCategoryFolder_Click;
				}
				withEventsField_CategoryToolStripMenuItem1 = value;
				if (withEventsField_CategoryToolStripMenuItem1 != null) {
					withEventsField_CategoryToolStripMenuItem1.Click += mnuToolNewCategoryFolder_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuNewCategoryItem;
		internal System.Windows.Forms.ToolStripMenuItem mnuNewCategoryItem {
			get { return withEventsField_mnuNewCategoryItem; }
			set {
				if (withEventsField_mnuNewCategoryItem != null) {
					withEventsField_mnuNewCategoryItem.Click -= mnuToolNewCategoryItem_Click;
				}
				withEventsField_mnuNewCategoryItem = value;
				if (withEventsField_mnuNewCategoryItem != null) {
					withEventsField_mnuNewCategoryItem.Click += mnuToolNewCategoryItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RecordingToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem RecordingToolStripMenuItem1 {
			get { return withEventsField_RecordingToolStripMenuItem1; }
			set {
				if (withEventsField_RecordingToolStripMenuItem1 != null) {
					withEventsField_RecordingToolStripMenuItem1.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_RecordingToolStripMenuItem1 = value;
				if (withEventsField_RecordingToolStripMenuItem1 != null) {
					withEventsField_RecordingToolStripMenuItem1.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_REMCycleToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem REMCycleToolStripMenuItem1 {
			get { return withEventsField_REMCycleToolStripMenuItem1; }
			set {
				if (withEventsField_REMCycleToolStripMenuItem1 != null) {
					withEventsField_REMCycleToolStripMenuItem1.Click -= REMCycleToolStripMenuItem1_Click;
				}
				withEventsField_REMCycleToolStripMenuItem1 = value;
				if (withEventsField_REMCycleToolStripMenuItem1 != null) {
					withEventsField_REMCycleToolStripMenuItem1.Click += REMCycleToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuHelpSupport;
		internal System.Windows.Forms.ToolStripMenuItem mnuHelpSupport {
			get { return withEventsField_mnuHelpSupport; }
			set {
				if (withEventsField_mnuHelpSupport != null) {
					withEventsField_mnuHelpSupport.Click -= mnuHelpSupport_Click;
				}
				withEventsField_mnuHelpSupport = value;
				if (withEventsField_mnuHelpSupport != null) {
					withEventsField_mnuHelpSupport.Click += mnuHelpSupport_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.ToolStripButton withEventsField_toolSubliminals;
		internal System.Windows.Forms.ToolStripButton toolSubliminals {
			get { return withEventsField_toolSubliminals; }
			set {
				if (withEventsField_toolSubliminals != null) {
					withEventsField_toolSubliminals.Click -= toolLucidity_Click;
				}
				withEventsField_toolSubliminals = value;
				if (withEventsField_toolSubliminals != null) {
					withEventsField_toolSubliminals.Click += toolLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolReadings;
		internal System.Windows.Forms.ToolStripButton toolReadings {
			get { return withEventsField_toolReadings; }
			set {
				if (withEventsField_toolReadings != null) {
					withEventsField_toolReadings.Click -= toolLucidity_Click;
				}
				withEventsField_toolReadings = value;
				if (withEventsField_toolReadings != null) {
					withEventsField_toolReadings.Click += toolLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ContextMenuStrip withEventsField_mnuTrv;
		internal System.Windows.Forms.ContextMenuStrip mnuTrv {
			get { return withEventsField_mnuTrv; }
			set {
				if (withEventsField_mnuTrv != null) {
					withEventsField_mnuTrv.Opening -= mnuTrv_Opening;
				}
				withEventsField_mnuTrv = value;
				if (withEventsField_mnuTrv != null) {
					withEventsField_mnuTrv.Opening += mnuTrv_Opening;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvSendTo;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvDelete;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvDelete {
			get { return withEventsField_mnuTrvDelete; }
			set {
				if (withEventsField_mnuTrvDelete != null) {
					withEventsField_mnuTrvDelete.Click -= mnuTrvDelete_Click;
				}
				withEventsField_mnuTrvDelete = value;
				if (withEventsField_mnuTrvDelete != null) {
					withEventsField_mnuTrvDelete.Click += mnuTrvDelete_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvSendToDesktop;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvSendToDesktop {
			get { return withEventsField_mnuTrvSendToDesktop; }
			set {
				if (withEventsField_mnuTrvSendToDesktop != null) {
					withEventsField_mnuTrvSendToDesktop.Click -= mnuTrvSendToDesktop_Click;
				}
				withEventsField_mnuTrvSendToDesktop = value;
				if (withEventsField_mnuTrvSendToDesktop != null) {
					withEventsField_mnuTrvSendToDesktop.Click += mnuTrvSendToDesktop_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewRecording;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewRecording {
			get { return withEventsField_mnuToolNewRecording; }
			set {
				if (withEventsField_mnuToolNewRecording != null) {
					withEventsField_mnuToolNewRecording.Click -= mnuToolNewLucidItem_Click;
				}
				withEventsField_mnuToolNewRecording = value;
				if (withEventsField_mnuToolNewRecording != null) {
					withEventsField_mnuToolNewRecording.Click += mnuToolNewLucidItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolNewReading;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolNewReading {
			get { return withEventsField_mnuToolNewReading; }
			set {
				if (withEventsField_mnuToolNewReading != null) {
					withEventsField_mnuToolNewReading.Click -= mnuToolNewLucidItem_Click;
				}
				withEventsField_mnuToolNewReading = value;
				if (withEventsField_mnuToolNewReading != null) {
					withEventsField_mnuToolNewReading.Click += mnuToolNewLucidItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SubliminalToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SubliminalToolStripMenuItem {
			get { return withEventsField_SubliminalToolStripMenuItem; }
			set {
				if (withEventsField_SubliminalToolStripMenuItem != null) {
					withEventsField_SubliminalToolStripMenuItem.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_SubliminalToolStripMenuItem = value;
				if (withEventsField_SubliminalToolStripMenuItem != null) {
					withEventsField_SubliminalToolStripMenuItem.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ReadingToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ReadingToolStripMenuItem {
			get { return withEventsField_ReadingToolStripMenuItem; }
			set {
				if (withEventsField_ReadingToolStripMenuItem != null) {
					withEventsField_ReadingToolStripMenuItem.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_ReadingToolStripMenuItem = value;
				if (withEventsField_ReadingToolStripMenuItem != null) {
					withEventsField_ReadingToolStripMenuItem.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem LucidityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuLucidityREMCycles;
		internal System.Windows.Forms.ToolStripMenuItem mnuLucidityREMCycles {
			get { return withEventsField_mnuLucidityREMCycles; }
			set {
				if (withEventsField_mnuLucidityREMCycles != null) {
					withEventsField_mnuLucidityREMCycles.Click -= mnuLucidity_Click;
				}
				withEventsField_mnuLucidityREMCycles = value;
				if (withEventsField_mnuLucidityREMCycles != null) {
					withEventsField_mnuLucidityREMCycles.Click += mnuLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuLuciditySubliminals;
		internal System.Windows.Forms.ToolStripMenuItem mnuLuciditySubliminals {
			get { return withEventsField_mnuLuciditySubliminals; }
			set {
				if (withEventsField_mnuLuciditySubliminals != null) {
					withEventsField_mnuLuciditySubliminals.Click -= mnuLucidity_Click;
				}
				withEventsField_mnuLuciditySubliminals = value;
				if (withEventsField_mnuLuciditySubliminals != null) {
					withEventsField_mnuLuciditySubliminals.Click += mnuLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuLucidityRecordings;
		internal System.Windows.Forms.ToolStripMenuItem mnuLucidityRecordings {
			get { return withEventsField_mnuLucidityRecordings; }
			set {
				if (withEventsField_mnuLucidityRecordings != null) {
					withEventsField_mnuLucidityRecordings.Click -= mnuLucidity_Click;
				}
				withEventsField_mnuLucidityRecordings = value;
				if (withEventsField_mnuLucidityRecordings != null) {
					withEventsField_mnuLucidityRecordings.Click += mnuLucidity_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuLucidityReadings;
		internal System.Windows.Forms.ToolStripMenuItem mnuLucidityReadings {
			get { return withEventsField_mnuLucidityReadings; }
			set {
				if (withEventsField_mnuLucidityReadings != null) {
					withEventsField_mnuLucidityReadings.Click -= mnuLucidity_Click;
				}
				withEventsField_mnuLucidityReadings = value;
				if (withEventsField_mnuLucidityReadings != null) {
					withEventsField_mnuLucidityReadings.Click += mnuLucidity_Click;
				}
			}
		}
		internal System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ToolStripButton withEventsField_toolSearch;
		internal System.Windows.Forms.ToolStripButton toolSearch {
			get { return withEventsField_toolSearch; }
			set {
				if (withEventsField_toolSearch != null) {
					withEventsField_toolSearch.Click -= toolSearch_Click;
				}
				withEventsField_toolSearch = value;
				if (withEventsField_toolSearch != null) {
					withEventsField_toolSearch.Click += toolSearch_Click;
				}
			}
		}
		internal System.Windows.Forms.ImageList lstImgIco;
		private System.Windows.Forms.Timer withEventsField_tmrProcessing;
		internal System.Windows.Forms.Timer tmrProcessing {
			get { return withEventsField_tmrProcessing; }
			set {
				if (withEventsField_tmrProcessing != null) {
					withEventsField_tmrProcessing.Tick -= tmrProcessing_Tick;
				}
				withEventsField_tmrProcessing = value;
				if (withEventsField_tmrProcessing != null) {
					withEventsField_tmrProcessing.Tick += tmrProcessing_Tick;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvPlay;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvPlay {
			get { return withEventsField_mnuTrvPlay; }
			set {
				if (withEventsField_mnuTrvPlay != null) {
					withEventsField_mnuTrvPlay.Click -= mnuTrvPlay_Click;
				}
				withEventsField_mnuTrvPlay = value;
				if (withEventsField_mnuTrvPlay != null) {
					withEventsField_mnuTrvPlay.Click += mnuTrvPlay_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvExplorer;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvExplorer {
			get { return withEventsField_mnuTrvExplorer; }
			set {
				if (withEventsField_mnuTrvExplorer != null) {
					withEventsField_mnuTrvExplorer.Click -= mnuTrvExplorer_Click;
				}
				withEventsField_mnuTrvExplorer = value;
				if (withEventsField_mnuTrvExplorer != null) {
					withEventsField_mnuTrvExplorer.Click += mnuTrvExplorer_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuNewCustomCatgeory;
		internal System.Windows.Forms.ToolStripMenuItem mnuNewCustomCatgeory {
			get { return withEventsField_mnuNewCustomCatgeory; }
			set {
				if (withEventsField_mnuNewCustomCatgeory != null) {
					withEventsField_mnuNewCustomCatgeory.Click -= mnuNewCustomCatgeory_Click;
				}
				withEventsField_mnuNewCustomCatgeory = value;
				if (withEventsField_mnuNewCustomCatgeory != null) {
					withEventsField_mnuNewCustomCatgeory.Click += mnuNewCustomCatgeory_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2 {
			get { return withEventsField_ToolStripMenuItem2; }
			set {
				if (withEventsField_ToolStripMenuItem2 != null) {
					withEventsField_ToolStripMenuItem2.Click -= mnuToolNewDream_Click;
				}
				withEventsField_ToolStripMenuItem2 = value;
				if (withEventsField_ToolStripMenuItem2 != null) {
					withEventsField_ToolStripMenuItem2.Click += mnuToolNewDream_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTreeNewCategoryFolder;
		internal System.Windows.Forms.ToolStripMenuItem mnuTreeNewCategoryFolder {
			get { return withEventsField_mnuTreeNewCategoryFolder; }
			set {
				if (withEventsField_mnuTreeNewCategoryFolder != null) {
					withEventsField_mnuTreeNewCategoryFolder.Click -= mnuToolNewCategoryFolder_Click;
				}
				withEventsField_mnuTreeNewCategoryFolder = value;
				if (withEventsField_mnuTreeNewCategoryFolder != null) {
					withEventsField_mnuTreeNewCategoryFolder.Click += mnuToolNewCategoryFolder_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem15;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem15 {
			get { return withEventsField_ToolStripMenuItem15; }
			set {
				if (withEventsField_ToolStripMenuItem15 != null) {
					withEventsField_ToolStripMenuItem15.Click -= REMCycleToolStripMenuItem1_Click;
				}
				withEventsField_ToolStripMenuItem15 = value;
				if (withEventsField_ToolStripMenuItem15 != null) {
					withEventsField_ToolStripMenuItem15.Click += REMCycleToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem17;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem17 {
			get { return withEventsField_ToolStripMenuItem17; }
			set {
				if (withEventsField_ToolStripMenuItem17 != null) {
					withEventsField_ToolStripMenuItem17.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_ToolStripMenuItem17 = value;
				if (withEventsField_ToolStripMenuItem17 != null) {
					withEventsField_ToolStripMenuItem17.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem18;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem18 {
			get { return withEventsField_ToolStripMenuItem18; }
			set {
				if (withEventsField_ToolStripMenuItem18 != null) {
					withEventsField_ToolStripMenuItem18.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_ToolStripMenuItem18 = value;
				if (withEventsField_ToolStripMenuItem18 != null) {
					withEventsField_ToolStripMenuItem18.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem19;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem19 {
			get { return withEventsField_ToolStripMenuItem19; }
			set {
				if (withEventsField_ToolStripMenuItem19 != null) {
					withEventsField_ToolStripMenuItem19.Click -= CheckToolStripMenuItem_Click;
				}
				withEventsField_ToolStripMenuItem19 = value;
				if (withEventsField_ToolStripMenuItem19 != null) {
					withEventsField_ToolStripMenuItem19.Click += CheckToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem20;
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem21;
		internal System.Windows.Forms.ToolStripMenuItem SpellingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuCheckSpelling;
		internal System.Windows.Forms.ToolStripMenuItem mnuCheckSpelling {
			get { return withEventsField_mnuCheckSpelling; }
			set {
				if (withEventsField_mnuCheckSpelling != null) {
					withEventsField_mnuCheckSpelling.Click -= mnuCheckSpelling_Click;
				}
				withEventsField_mnuCheckSpelling = value;
				if (withEventsField_mnuCheckSpelling != null) {
					withEventsField_mnuCheckSpelling.Click += mnuCheckSpelling_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem mnuSpellingLanguage;
		internal System.Windows.Forms.ToolStripMenuItem mnuEnglish;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ExerciseToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExerciseToolStripMenuItem {
			get { return withEventsField_ExerciseToolStripMenuItem; }
			set {
				if (withEventsField_ExerciseToolStripMenuItem != null) {
					withEventsField_ExerciseToolStripMenuItem.Click -= ExerciseToolStripMenuItem_Click;
				}
				withEventsField_ExerciseToolStripMenuItem = value;
				if (withEventsField_ExerciseToolStripMenuItem != null) {
					withEventsField_ExerciseToolStripMenuItem.Click += ExerciseToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuFileNewExercise;
		internal System.Windows.Forms.ToolStripMenuItem mnuFileNewExercise {
			get { return withEventsField_mnuFileNewExercise; }
			set {
				if (withEventsField_mnuFileNewExercise != null) {
					withEventsField_mnuFileNewExercise.Click -= mnuFileNewExercise_Click;
				}
				withEventsField_mnuFileNewExercise = value;
				if (withEventsField_mnuFileNewExercise != null) {
					withEventsField_mnuFileNewExercise.Click += mnuFileNewExercise_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvNewExercise;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvNewExercise {
			get { return withEventsField_mnuTrvNewExercise; }
			set {
				if (withEventsField_mnuTrvNewExercise != null) {
					withEventsField_mnuTrvNewExercise.Click -= mnuTrvNewExercise_Click;
				}
				withEventsField_mnuTrvNewExercise = value;
				if (withEventsField_mnuTrvNewExercise != null) {
					withEventsField_mnuTrvNewExercise.Click += mnuTrvNewExercise_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ExerciseRndToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExerciseRndToolStripMenuItem {
			get { return withEventsField_ExerciseRndToolStripMenuItem; }
			set {
				if (withEventsField_ExerciseRndToolStripMenuItem != null) {
					withEventsField_ExerciseRndToolStripMenuItem.Click -= ExerciseRndToolStripMenuItem_Click;
				}
				withEventsField_ExerciseRndToolStripMenuItem = value;
				if (withEventsField_ExerciseRndToolStripMenuItem != null) {
					withEventsField_ExerciseRndToolStripMenuItem.Click += ExerciseRndToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RandomExerciseToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RandomExerciseToolStripMenuItem {
			get { return withEventsField_RandomExerciseToolStripMenuItem; }
			set {
				if (withEventsField_RandomExerciseToolStripMenuItem != null) {
					withEventsField_RandomExerciseToolStripMenuItem.Click -= RandomExerciseToolStripMenuItem_Click;
				}
				withEventsField_RandomExerciseToolStripMenuItem = value;
				if (withEventsField_RandomExerciseToolStripMenuItem != null) {
					withEventsField_RandomExerciseToolStripMenuItem.Click += RandomExerciseToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RandomExerciseToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem RandomExerciseToolStripMenuItem1 {
			get { return withEventsField_RandomExerciseToolStripMenuItem1; }
			set {
				if (withEventsField_RandomExerciseToolStripMenuItem1 != null) {
					withEventsField_RandomExerciseToolStripMenuItem1.Click -= RandomExerciseToolStripMenuItem1_Click;
				}
				withEventsField_RandomExerciseToolStripMenuItem1 = value;
				if (withEventsField_RandomExerciseToolStripMenuItem1 != null) {
					withEventsField_RandomExerciseToolStripMenuItem1.Click += RandomExerciseToolStripMenuItem1_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripButton withEventsField_toolLucidityExercises;
		internal System.Windows.Forms.ToolStripButton toolLucidityExercises {
			get { return withEventsField_toolLucidityExercises; }
			set {
				if (withEventsField_toolLucidityExercises != null) {
					withEventsField_toolLucidityExercises.Click -= toolLucidity_Click;
				}
				withEventsField_toolLucidityExercises = value;
				if (withEventsField_toolLucidityExercises != null) {
					withEventsField_toolLucidityExercises.Click += toolLucidity_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem22;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsWILD;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsWILD {
			get { return withEventsField_mnuToolsWILD; }
			set {
				if (withEventsField_mnuToolsWILD != null) {
					withEventsField_mnuToolsWILD.Click -= mnuToolsWILD_Click;
				}
				withEventsField_mnuToolsWILD = value;
				if (withEventsField_mnuToolsWILD != null) {
					withEventsField_mnuToolsWILD.Click += mnuToolsWILD_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsDreamSignBuilder;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsDreamSignBuilder {
			get { return withEventsField_mnuToolsDreamSignBuilder; }
			set {
				if (withEventsField_mnuToolsDreamSignBuilder != null) {
					withEventsField_mnuToolsDreamSignBuilder.Click -= mnuToolsDreamSignBuilder_Click;
				}
				withEventsField_mnuToolsDreamSignBuilder = value;
				if (withEventsField_mnuToolsDreamSignBuilder != null) {
					withEventsField_mnuToolsDreamSignBuilder.Click += mnuToolsDreamSignBuilder_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuHelpUpdate;
		internal System.Windows.Forms.ToolStripMenuItem mnuHelpUpdate {
			get { return withEventsField_mnuHelpUpdate; }
			set {
				if (withEventsField_mnuHelpUpdate != null) {
					withEventsField_mnuHelpUpdate.Click -= mnuHelpUpdate_Click;
				}
				withEventsField_mnuHelpUpdate = value;
				if (withEventsField_mnuHelpUpdate != null) {
					withEventsField_mnuHelpUpdate.Click += mnuHelpUpdate_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuQuickStart;
		internal System.Windows.Forms.ToolStripMenuItem mnuQuickStart {
			get { return withEventsField_mnuQuickStart; }
			set {
				if (withEventsField_mnuQuickStart != null) {
					withEventsField_mnuQuickStart.Click -= mnuQuickStart_Click;
				}
				withEventsField_mnuQuickStart = value;
				if (withEventsField_mnuQuickStart != null) {
					withEventsField_mnuQuickStart.Click += mnuQuickStart_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTrvSendToLD4All;
		internal System.Windows.Forms.ToolStripMenuItem mnuTrvSendToLD4All {
			get { return withEventsField_mnuTrvSendToLD4All; }
			set {
				if (withEventsField_mnuTrvSendToLD4All != null) {
					withEventsField_mnuTrvSendToLD4All.Click -= mnuTrvSendToLD4All_Click;
				}
				withEventsField_mnuTrvSendToLD4All = value;
				if (withEventsField_mnuTrvSendToLD4All != null) {
					withEventsField_mnuTrvSendToLD4All.Click += mnuTrvSendToLD4All_Click;
				}
			}
		}
		internal lucidcode.Controls.Panel3D pnlProcessing;
		internal lucidcode.Controls.Panel3D pnlSearching;
		private System.Windows.Forms.Timer withEventsField_tmrSaving;
		internal System.Windows.Forms.Timer tmrSaving {
			get { return withEventsField_tmrSaving; }
			set {
				if (withEventsField_tmrSaving != null) {
					withEventsField_tmrSaving.Tick -= tmrSaving_Tick;
				}
				withEventsField_tmrSaving = value;
				if (withEventsField_tmrSaving != null) {
					withEventsField_tmrSaving.Tick += tmrSaving_Tick;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsWhyLD;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsWhyLD {
			get { return withEventsField_mnuToolsWhyLD; }
			set {
				if (withEventsField_mnuToolsWhyLD != null) {
					withEventsField_mnuToolsWhyLD.Click -= mnuToolsWhyLD_Click;
				}
				withEventsField_mnuToolsWhyLD = value;
				if (withEventsField_mnuToolsWhyLD != null) {
					withEventsField_mnuToolsWhyLD.Click += mnuToolsWhyLD_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsCompareDreams;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsCompareDreams {
			get { return withEventsField_mnuToolsCompareDreams; }
			set {
				if (withEventsField_mnuToolsCompareDreams != null) {
					withEventsField_mnuToolsCompareDreams.Click -= mnuToolsCompareDreams_Click;
				}
				withEventsField_mnuToolsCompareDreams = value;
				if (withEventsField_mnuToolsCompareDreams != null) {
					withEventsField_mnuToolsCompareDreams.Click += mnuToolsCompareDreams_Click;
				}
			}
		}
		private System.Windows.Forms.DataVisualization.Charting.Chart graph;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsFIELD;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsFIELD {
			get { return withEventsField_mnuToolsFIELD; }
			set {
				if (withEventsField_mnuToolsFIELD != null) {
					withEventsField_mnuToolsFIELD.Click -= mnuToolsFIELD_Click;
				}
				withEventsField_mnuToolsFIELD = value;
				if (withEventsField_mnuToolsFIELD != null) {
					withEventsField_mnuToolsFIELD.Click += mnuToolsFIELD_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsDataDirectory;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsDataDirectory {
			get { return withEventsField_mnuToolsDataDirectory; }
			set {
				if (withEventsField_mnuToolsDataDirectory != null) {
					withEventsField_mnuToolsDataDirectory.Click -= mnuToolsDataDirectory_Click;
				}
				withEventsField_mnuToolsDataDirectory = value;
				if (withEventsField_mnuToolsDataDirectory != null) {
					withEventsField_mnuToolsDataDirectory.Click += mnuToolsDataDirectory_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsDreamTypeCount;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsDreamTypeCount {
			get { return withEventsField_mnuToolsDreamTypeCount; }
			set {
				if (withEventsField_mnuToolsDreamTypeCount != null) {
					withEventsField_mnuToolsDreamTypeCount.Click -= mnuToolsDreamTypeCount_Click;
				}
				withEventsField_mnuToolsDreamTypeCount = value;
				if (withEventsField_mnuToolsDreamTypeCount != null) {
					withEventsField_mnuToolsDreamTypeCount.Click += mnuToolsDreamTypeCount_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuTreeNewCategoryItem;
		internal System.Windows.Forms.ToolStripMenuItem mnuTreeNewCategoryItem {
			get { return withEventsField_mnuTreeNewCategoryItem; }
			set {
				if (withEventsField_mnuTreeNewCategoryItem != null) {
					withEventsField_mnuTreeNewCategoryItem.Click -= mnuToolNewCategoryItem_Click;
				}
				withEventsField_mnuTreeNewCategoryItem = value;
				if (withEventsField_mnuTreeNewCategoryItem != null) {
					withEventsField_mnuTreeNewCategoryItem.Click += mnuToolNewCategoryItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_mnuToolsRecentDreamSigns;
		internal System.Windows.Forms.ToolStripMenuItem mnuToolsRecentDreamSigns {
			get { return withEventsField_mnuToolsRecentDreamSigns; }
			set {
				if (withEventsField_mnuToolsRecentDreamSigns != null) {
					withEventsField_mnuToolsRecentDreamSigns.Click -= mnuToolsRecentDreamSigns_Click;
				}
				withEventsField_mnuToolsRecentDreamSigns = value;
				if (withEventsField_mnuToolsRecentDreamSigns != null) {
					withEventsField_mnuToolsRecentDreamSigns.Click += mnuToolsRecentDreamSigns_Click;
				}
			}

		}
	}
}
