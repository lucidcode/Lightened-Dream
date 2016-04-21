using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Lucidity.Tags
{

	public class LucidityFolder
	{

		public string Path = "";
		public LucidityFolder(string Folder)
		{
			Path = Folder;
		}
	}

	public class REMCyclesFolder
	{

		public string Path = "";
		public REMCyclesFolder(string Folder)
		{
			Path = Folder;
		}
	}

	public class REMCycleFile
	{

		public string Path = "";
		public REMCycleFile(string Folder)
		{
			Path = Folder;
		}
	}

	public class LucidItemFolder
	{
		public string Path = "";

		public string Type = "";
		public LucidItemFolder(string Folder, string strType)
		{
			Path = Folder;
			Type = strType;
		}
	}

	public class LucidItemFile
	{
		public string Path = "";

		public string Type = "";
		public LucidItemFile(string strPath, string strType)
		{
			Path = strPath;
			Type = strType;
		}
	}


	public class DreamsFolder
	{

		public string Path = "";
		public DreamsFolder(string Folder)
		{
			Path = Folder;
		}
	}

	public class YearFolder
	{
		public string Path = "";

		public string Year = "";
		public YearFolder(string Folder, string strYear)
		{
			Path = Folder;
			Year = strYear;
		}
	}

	public class YearsFolder
	{
		public string Path = "";

		public string Year = "";
		public YearsFolder(string Folder, string strYear)
		{
			Path = Folder;
			Year = strYear;
		}
	}

	public class MonthFolder
	{
		public string Path = "";
		public string Year = "";

		public string Month = "";
		public MonthFolder(string Folder, string strYear, string strMonth)
		{
			Path = Folder;
			Year = strYear;
			Month = strMonth;
		}
	}

	public class DreamFile
	{

		public string Path = "";
		public DreamFile(string File)
		{
			Path = File;
		}
	}


}
