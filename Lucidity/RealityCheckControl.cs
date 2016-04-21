using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization;
namespace lucidcode.LightenedDream.Lucidity
{

	public partial class RealityCheckControl
	{


		private bool m_boolLoaded = false;
		private void REMCyclesControl_Load(object sender, System.EventArgs e)
		{
			m_boolLoaded = true;
		}
		public RealityCheckControl()
		{
			Load += REMCyclesControl_Load;
			InitializeComponent();
		}

	}
}
