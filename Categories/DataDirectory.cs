using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace lucidcode.LightenedDream.Categories
{

	public class DataDirectory
	{

		public static string GetFolderPath()
		{
			string strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\";
			if ((File.Exists(strPath + "LightenedDreamDirectory.ld3"))) {
				XmlDocument xmlDocDataDirectory = new XmlDocument();
				xmlDocDataDirectory.Load(strPath + "LightenedDreamDirectory.ld3");
				if (Directory.Exists(xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText)) {
					return xmlDocDataDirectory.DocumentElement.SelectSingleNode("Directory").InnerText;
				}
			}

			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\";
		}

	}
}
