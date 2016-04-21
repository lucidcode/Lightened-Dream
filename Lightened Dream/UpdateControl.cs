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
using System.IO;
namespace LightenedDream
{

	public partial class UpdateControl
	{


		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\";
		public void UpdateDatabase()
		{
			// Load each year
			foreach (string strYearFolder in Directory.GetDirectories(m_strPath + "Dreams")) {
				TreeNode trvYear = new TreeNode(new DirectoryInfo(strYearFolder).Name);
				lucidcode.LightenedDream.Dreams.Tags.YearFolder objYearTag = new lucidcode.LightenedDream.Dreams.Tags.YearFolder(strYearFolder, trvYear.Text);
				trvYear.Tag = objYearTag;
				//trvDreams.Nodes.Add(trvYear)

				// Load each month
				foreach (string strMonthFolder in Directory.GetDirectories(strYearFolder)) {
					TreeNode trvMonth = new TreeNode(new DirectoryInfo(strMonthFolder).Name);
					lucidcode.LightenedDream.Dreams.Tags.MonthFolder objMonthTag = new lucidcode.LightenedDream.Dreams.Tags.MonthFolder(strMonthFolder, trvYear.Text, trvMonth.Text);
					trvMonth.Tag = objMonthTag;
					trvYear.Nodes.Add(trvMonth);

					// Load each dream
					foreach (string strDreamFile in Directory.GetFiles(strMonthFolder, "*.ld3")) {
						//trvDream = New TreeNode(New FileInfo(strDreamFile).Name.Replace(".ld3", ""))
						lucidcode.LightenedDream.Dreams.Tags.DreamFile objDreamTag = new lucidcode.LightenedDream.Dreams.Tags.DreamFile(strDreamFile);
						//trvDream.Tag = objDreamTag
						//trvDream.ImageIndex = 12
						//trvDream.SelectedImageIndex = 12
						//trvMonth.Nodes.Add(trvDream)

						//' Add the loading node
						//Dim trvLoading As New TreeNode("Loading Categories...")
						//trvDream.Nodes.Add(trvLoading)
					}

				}
			}
		}
		public UpdateControl()
		{
			InitializeComponent();
		}

	}
}
