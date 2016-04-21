using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Dreams.Tags
{

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
namespace lucidcode.LightenedDream.Dreams
{


	public class Dreaming
	{

		public static string[] GetWords(string Dream)
		{
			string strWords = Dream.Replace(",", " ");
			strWords = strWords.Replace(".", " ");
			strWords = strWords.Replace("/", " ");
			strWords = strWords.Replace("\\", " ");
			strWords = strWords.Replace(";", " ");
			strWords = strWords.Replace("-", " ");
			strWords = strWords.Replace("!", " ");
			strWords = strWords.Replace("?", " ");
			strWords = strWords.Replace("&", " ");
			strWords = strWords.Replace("'s", " ");
			strWords = strWords.Replace(">", " ");
			strWords = strWords.Replace("<", " ");
			strWords = strWords.Replace("(", " ");
			strWords = strWords.Replace(")", " ");
			strWords = strWords.Replace(Constants.vbNewLine, " ");
			strWords = strWords.Replace(Constants.vbCr, " ");
			strWords = strWords.Replace(Constants.vbLf, " ");
			return strWords.Split(' ');
		}

	}
}


