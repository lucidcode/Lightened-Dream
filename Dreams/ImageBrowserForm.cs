using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using System.Threading;
using Newtonsoft.Json;
namespace lucidcode.LightenedDream.Dreams
{

	public partial class ImageBrowserForm
	{


		private Series objDreams;

		public Image DreamImage;
		private List<Image> Images = new List<Image>();
		private SearchClass objSearchClass = new SearchClass();

		private string strLastSearch = "https://api.gettyimages.com/v3/search/images/creative?phrase=light";
		private void ImageBrowserForm_Load(System.Object sender, System.EventArgs e)
		{
			DoubleBuffered = true;

			graph.ChartAreas[0].AxisX.CustomLabels.Clear();
			graph.Series.Clear();
			graph.ResetAutoValues();
			graph.Annotations.Clear();

			objDreams = graph.Series.Add("Dreams");
			objDreams.ChartType = SeriesChartType.Column;
			objDreams.Color = Color.FromArgb(200, 65, 140, 240);
			objDreams.BorderWidth = 1;

			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(0);
			objDreams.Points.AddY(1000);

		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(System.Object sender, System.EventArgs e)
		{

			try {
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "LightenedDream.Dreams.SelectImage()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtKeywords_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Search();
			}
		}

		private void btnSearch_Click(System.Object sender, System.EventArgs e)
		{
			Search();
		}

		public void Search()
		{
			if (tmrSearching.Enabled) {
				objSearchClass.Completed = true;
				System.Threading.Thread.Sleep(100);
				Application.DoEvents();
				System.Threading.Thread.Sleep(100);
			}

			tmrSearching.Enabled = true;

			Images.Clear();
			lstImages.Items.Clear();
			lstImg.Images.Clear();
			pnlSearching.Visible = true;

			objSearchClass = new SearchClass();
			strLastSearch = "https://api.gettyimages.com/v3/search/images/creative?phrase=" + txtKeywords.Text.Replace(" ", "_").Replace(Constants.vbNewLine, "_") + "";
			objSearchClass.Keywords = strLastSearch;
			objSearchClass.Completed = false;
			//AddHandler objSearchClass.ThumbnailAdded, AddressOf ThumbnailAdded
			//AddHandler objSearchClass.ImageAdded, AddressOf ImageAdded
			//AddHandler objSearchClass.ItemAdded, AddressOf ItemAdded
			objSearchClass.ListItemAdded += ListItemAdded;

			Thread objThread = new Thread(objSearchClass.DoSearchWork);
			objThread.Start();

			do {
				if (objSearchClass.Completed)
					break; // TODO: might not be correct. Was : Exit Do
				Application.DoEvents();
				System.Threading.Thread.Sleep(128);
			} while (true);

			pnlSearching.Visible = false;
			tmrSearching.Enabled = false;
		}

		private delegate void ListItemAddedDelegate(Image Thumbnail, Image Bitmap, ListViewItem Item);
		private void ListItemAdded(Image Thumbnail, Image Bitmap, ListViewItem Item)
		{
			try {
				if (InvokeRequired) {
					if (objSearchClass.Completed)
						return;
					ListItemAddedDelegate d = new ListItemAddedDelegate(ListItemAdded);
					Invoke(d, Thumbnail, Bitmap, Item);
				} else {
					Images.Add(Thumbnail);
					lstImg.Images.Add(Bitmap);
					Item.ImageIndex = lstImg.Images.Count - 1;
					lstImages.Items.Add(Item);
					Item.EnsureVisible();
				}
			} catch (Exception ex) {
			}
		}

		private class SearchClass
		{

			public string Keywords = "Dream";

			public bool Completed = false;
			public event ListItemAddedEventHandler ListItemAdded;
			public delegate void ListItemAddedEventHandler(Image Thumbnail, Image Bitmap, ListViewItem Item);


			private int m_intDownloaded = 0;
			public void DoSearchWork()
			{
				int intImageIndex = 0;
				int intStart = 0;
				int intEnd = 0;
				string strSource = null;


				try {
					System.Net.WebClient objWebClient = new System.Net.WebClient();
					objWebClient.Headers.Add("Api-Key", "5z67acwgvytgqsnw9ae4vwwg");
					strSource = objWebClient.DownloadString(Keywords);

					var objImages = JsonConvert.DeserializeObject(strSource);

					foreach (object objImage in objImages("images")) {
						DownloadClass objDownloadClass = new DownloadClass();
						objDownloadClass.Title = objImage("title");
						objDownloadClass.FileID = objImage("display_sizes")(0)("uri");
						objDownloadClass.ImageIndex = intImageIndex;
						objDownloadClass.Completed = false;
						objDownloadClass.ListItemAdded += ListItemAddedX;

						Thread objThread = new Thread(objDownloadClass.DoDownloadWork);
						objThread.Start();

						Thread.Sleep(2);
						Application.DoEvents();

						if (Completed)
							break; // TODO: might not be correct. Was : Exit For
						intImageIndex += 1;

					}

					// Wait for all the threads to complete
					int intCompleted = intImageIndex * -1;


					do {
						if (Completed)
							break; // TODO: might not be correct. Was : Exit Do

						if (m_intDownloaded == intImageIndex - 1) {
							break; // TODO: might not be correct. Was : Exit Do
						}

					} while (true);


				} catch (Exception ex) {
				}

				Completed = true;

			}

			private void ListItemAddedX(Image Thumbnail, Image Bitmap, ListViewItem Item)
			{
				if (ListItemAdded != null) {
					ListItemAdded(Thumbnail, Bitmap, Item);
				}

				m_intDownloaded += 1;
			}

		}

		private class DownloadClass
		{

			public event ListItemAddedEventHandler ListItemAdded;
			public delegate void ListItemAddedEventHandler(Image Thumbnail, Image Bitmap, ListViewItem Item);
			public string Title;
			public int ImageIndex;
			public string FileID;

			public bool Completed = false;
			public void DoDownloadWork()
			{
				try {
					System.Net.WebClient objWebClient = new System.Net.WebClient();
					byte[] arrImage = objWebClient.DownloadData(FileID);

					Thread.Sleep(2);
					Application.DoEvents();

					System.IO.MemoryStream objMem = new System.IO.MemoryStream(arrImage);
					Image imgThumbnail = Image.FromStream(objMem);
					Bitmap bmpThumbnail = new Bitmap(110, 110, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
					Image imgBitmap = Image.FromHbitmap(bmpThumbnail.GetHbitmap());

					System.Drawing.Graphics objGraphics = Graphics.FromImage(imgBitmap);
					objGraphics.Clear(Color.White);
					objGraphics.DrawImage(imgThumbnail, 0, 0, imgThumbnail.Width, imgThumbnail.Height);

					ListViewItem lstThumbnail = new ListViewItem(Title);
					lstThumbnail.ToolTipText = Title;
					lstThumbnail.ImageIndex = ImageIndex;
					lstThumbnail.Tag = FileID;

					if (ListItemAdded != null) {
						ListItemAdded(imgThumbnail, imgBitmap, lstThumbnail);
					}

				} catch (Exception ex) {
				}

			}
		}

		private void lstImages_MouseMove(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((lstImages.GetItemAt(e.X, e.Y) != null)) {
				lstImages.Cursor = Cursors.Hand;
			} else {
				lstImages.Cursor = Cursors.Default;
			}
		}


		private void lstImages_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
		}

		private void tmrSearching_Tick(System.Object sender, System.EventArgs e)
		{
			objDreams.Points.AddY(Conversion.Int(VBMath.Rnd() * 1000));
			objDreams.Points.Remove(objDreams.Points[0]);
		}

		private void txtKeywords_Enter(System.Object sender, System.EventArgs e)
		{
			txtKeywords.SelectAll();
		}

		private void lstImages_Click(System.Object sender, System.EventArgs e)
		{
			if (lstImages.SelectedItems.Count == 0)
				return;
			DreamImage = Images[lstImages.SelectedItems[0].ImageIndex];
			DialogResult = System.Windows.Forms.DialogResult.OK;
			objSearchClass.Completed = true;
			Close();
		}

		private void lblRAC_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.gettyimages.com");
		}


		private void ImageBrowserForm_FormClosing(System.Object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			objSearchClass.Completed = true;
		}

		private void tmrDoSearch_Tick(System.Object sender, System.EventArgs e)
		{
			tmrDoSearch.Enabled = false;
			if (!string.IsNullOrEmpty(txtKeywords.Text))
				Search();
		}
	}
}
namespace lucidcode.LightenedDream.Dreams
{

	public class ListViewNF : System.Windows.Forms.ListView
	{
		public ListViewNF()
		{
			//Activate double buffering
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

			//Enable the OnNotifyMessage event so we get a chance to filter out 
			// Windows messages before they get to the form's WndProc
			this.SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		protected override void OnNotifyMessage(Message m)
		{
			//Filter out the WM_ERASEBKGND message
			if (m.Msg != 0x14) {
				base.OnNotifyMessage(m);
			}
		}
	}
}
