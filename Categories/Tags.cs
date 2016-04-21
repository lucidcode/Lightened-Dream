using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace lucidcode.LightenedDream.Categories.Tags
{

	public class CategoriesFolder
	{

		public string Path = "";
		public CategoriesFolder(string Folder)
		{
			Path = Folder;
		}
	}

	public class CategoryFolder
	{

		public string Path = "";
		public CategoryFolder(string Folder)
		{
			Path = Folder;
		}
	}

	public class CategoryFile
	{
		public string Path = "";

		public string Category = "";
		public CategoryFile(string File, string Type)
		{
			Path = File;
			Category = Type;
		}
	}

}
