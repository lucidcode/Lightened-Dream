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

	public partial class LucidityControl
	{

		public event LucidFolderSelectedEventHandler LucidFolderSelected;
		public delegate void LucidFolderSelectedEventHandler(string Category);

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
			if (LucidFolderSelected != null) {
				LucidFolderSelected(lstLucidity.SelectedItems[0].Text);
			}
		}
		public LucidityControl()
		{
			InitializeComponent();
		}

	}
}
