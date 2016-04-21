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
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class FolderViewControl
	{

		public string FileName;
		private string m_strPath = DataDirectory.GetFolderPath() + "\\Lightened Dream\\Lucidity\\";
		private string m_strFolder;

		public bool Playing = false;
		public event LucidItemSelectedEventHandler LucidItemSelected;
		public delegate void LucidItemSelectedEventHandler(string Category, string FileName);

		public void LoadFolder(string Folder)
		{

			try {
				m_strFolder = Folder;
				lblTitle.Text = "Lucidity - " + m_strFolder;
				lstLucidity.Items.Clear();
				foreach (string strCatgeoryFile in Directory.GetFiles(m_strPath + m_strFolder, "*.ld3")) {
					ListViewItem lstItem = new ListViewItem(new FileInfo(strCatgeoryFile).Name.Replace(".ld3", ""));
					lstItem.ImageIndex = lstImg.Images.IndexOfKey(m_strFolder);
					lstLucidity.Items.Add(lstItem);
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Lucidity.Items.Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lstLucdity_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((lstLucidity.GetItemAt(e.X, e.Y) != null)) {
				lstLucidity.Cursor = Cursors.Hand;
			} else {
				lstLucidity.Cursor = Cursors.Default;
			}
		}

		private void lstLucdity_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (lstLucidity.SelectedItems.Count == 0)
				return;
			if (LucidItemSelected != null) {
				LucidItemSelected(m_strFolder, lstLucidity.SelectedItems[0].Text);
			}
		}

		private int GetRandomItem(int Max)
		{
			int intId = VBMath.Rnd() * Max;
			if (intId >= Max)
				intId = Max - 1;
			return intId;
		}
		public FolderViewControl()
		{
			InitializeComponent();
		}

	}
}
