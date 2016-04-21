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
	public partial class ExportForm
	{


		private bool m_boolChecking;

		private void ExportForm_Load(System.Object sender, System.EventArgs e)
		{
		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}


		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void chkSelectAll_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			m_boolChecking = true;
			CheckNodes(trvMain.Nodes, chkSelectAll.Checked);
			m_boolChecking = false;
		}

		private void CheckNodes(TreeNodeCollection Nodes, bool Checked)
		{
			foreach (TreeNode trvNode in Nodes) {
				trvNode.Checked = Checked;
				CheckNodes(trvNode.Nodes, Checked);
			}
		}

		private void trvMain_AfterCheck(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (m_boolChecking)
				return;

			CheckNodes(e.Node.Nodes, e.Node.Checked);
		}
		public ExportForm()
		{
			Load += ExportForm_Load;
			InitializeComponent();
		}
	}
}
