Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization
Imports System.Threading
Imports Newtonsoft.Json

Public Class ImageBrowserForm

  Private objDreams As Series

  Public DreamImage As Image

  Private Images As New List(Of Image)
  Private objSearchClass As New SearchClass()
  Private strLastSearch As String = "https://api.gettyimages.com/v3/search/images/creative?phrase=light"

  Private Sub ImageBrowserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    DoubleBuffered = True

    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Series.Clear()
    graph.ResetAutoValues()
    graph.Annotations.Clear()

    objDreams = graph.Series.Add("Dreams")
    objDreams.ChartType = SeriesChartType.Column
    objDreams.Color = Color.FromArgb(200, 65, 140, 240)
    objDreams.BorderWidth = 1

    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(0)
    objDreams.Points.AddY(1000)

  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Close()
  End Sub

  Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Try

    Catch ex As Exception
      MessageBox.Show(ex.Message, "LightenedDream.Dreams.SelectImage()", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtKeywords_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeywords.KeyDown
    If e.KeyCode = Keys.Enter Then
      Search()
    End If
  End Sub

  Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    Search()
  End Sub

  Public Sub Search()
    If tmrSearching.Enabled Then
      objSearchClass.Completed = True
      System.Threading.Thread.Sleep(100)
      Application.DoEvents()
      System.Threading.Thread.Sleep(100)
    End If

    tmrSearching.Enabled = True

    Images.Clear()
    lstImages.Items.Clear()
    lstImg.Images.Clear()
    pnlSearching.Visible = True

    objSearchClass = New SearchClass
    strLastSearch = "https://api.gettyimages.com/v3/search/images/creative?phrase=" + txtKeywords.Text.Replace(" ", "_").Replace(vbNewLine, "_") + ""
    objSearchClass.Keywords = strLastSearch
    objSearchClass.Completed = False
    'AddHandler objSearchClass.ThumbnailAdded, AddressOf ThumbnailAdded
    'AddHandler objSearchClass.ImageAdded, AddressOf ImageAdded
    'AddHandler objSearchClass.ItemAdded, AddressOf ItemAdded
    AddHandler objSearchClass.ListItemAdded, AddressOf ListItemAdded

    Dim objThread As New Thread(AddressOf objSearchClass.DoSearchWork)
    objThread.Start()

    Do
      If objSearchClass.Completed Then Exit Do
      Application.DoEvents()
      System.Threading.Thread.Sleep(128)
    Loop

    pnlSearching.Visible = False
    tmrSearching.Enabled = False
  End Sub

  Private Delegate Sub ListItemAddedDelegate(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem)
  Private Sub ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem)
    Try
      If InvokeRequired Then
        If objSearchClass.Completed Then Exit Sub
        Dim d As New ListItemAddedDelegate(AddressOf ListItemAdded)
        Invoke(d, Thumbnail, Bitmap, Item)
      Else
        Images.Add(Thumbnail)
        lstImg.Images.Add(Bitmap)
        Item.ImageIndex = lstImg.Images.Count - 1
        lstImages.Items.Add(Item)
        Item.EnsureVisible()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Class SearchClass

    Public Keywords As String = "Dream"
    Public Completed As Boolean = False

    Public Event ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem)

    Private m_intDownloaded As Integer = 0

    Public Sub DoSearchWork()
      Dim intImageIndex As Integer = 0
      Dim intStart As Integer = 0
      Dim intEnd As Integer = 0
      Dim strSource As String

      Try

        Dim objWebClient As New System.Net.WebClient
        objWebClient.Headers.Add("Api-Key", "5z67acwgvytgqsnw9ae4vwwg")
        strSource = objWebClient.DownloadString(Keywords)

        Dim objImages = JsonConvert.DeserializeObject(strSource)

        For Each objImage As Object In objImages("images")

          Dim objDownloadClass As New DownloadClass
          objDownloadClass.Title = objImage("title")
          objDownloadClass.FileID = objImage("display_sizes")(0)("uri")
          objDownloadClass.ImageIndex = intImageIndex
          objDownloadClass.Completed = False
          AddHandler objDownloadClass.ListItemAdded, AddressOf ListItemAddedX

          Dim objThread As New Thread(AddressOf objDownloadClass.DoDownloadWork)
          objThread.Start()

          Thread.Sleep(2)
          Application.DoEvents()

          If Completed Then Exit For
          intImageIndex += 1

        Next

        ' Wait for all the threads to complete
        Dim intCompleted As Integer = intImageIndex * -1

        Do

          If Completed Then Exit Do

          If m_intDownloaded = intImageIndex - 1 Then
            Exit Do
          End If

        Loop

      Catch ex As Exception

      End Try

      Completed = True

    End Sub

    Private Sub ListItemAddedX(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem)
      RaiseEvent ListItemAdded(Thumbnail, Bitmap, Item)

      m_intDownloaded += 1
    End Sub

  End Class

  Private Class DownloadClass

    Public Event ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem)
    Public Title As String
    Public ImageIndex As Integer
    Public FileID As String
    Public Completed As Boolean = False

    Public Sub DoDownloadWork()
      Try
        Dim objWebClient As New System.Net.WebClient
        Dim arrImage As Byte() = objWebClient.DownloadData(FileID)

        Thread.Sleep(2)
        Application.DoEvents()

        Dim objMem As New System.IO.MemoryStream(arrImage)
        Dim imgThumbnail As Image = Image.FromStream(objMem)
        Dim bmpThumbnail As New Bitmap(110, 110, Imaging.PixelFormat.Format32bppArgb)
        Dim imgBitmap As Image = Image.FromHbitmap(bmpThumbnail.GetHbitmap)

        Dim objGraphics As System.Drawing.Graphics = Graphics.FromImage(imgBitmap)
        objGraphics.Clear(Color.White)
        objGraphics.DrawImage(imgThumbnail, 0, 0, imgThumbnail.Width, imgThumbnail.Height)

        Dim lstThumbnail As New ListViewItem(Title)
        lstThumbnail.ToolTipText = Title
        lstThumbnail.ImageIndex = ImageIndex
        lstThumbnail.Tag = FileID

        RaiseEvent ListItemAdded(imgThumbnail, imgBitmap, lstThumbnail)
      Catch ex As Exception

      End Try

    End Sub
  End Class

  Private Sub lstImages_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstImages.MouseMove
    If Not lstImages.GetItemAt(e.X, e.Y) Is Nothing Then
      lstImages.Cursor = Cursors.Hand
    Else
      lstImages.Cursor = Cursors.Default
    End If
  End Sub

  Private Sub lstImages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstImages.SelectedIndexChanged

  End Sub

  Private Sub tmrSearching_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSearching.Tick
    objDreams.Points.AddY(Int(Rnd() * 1000))
    objDreams.Points.Remove(objDreams.Points(0))
  End Sub

  Private Sub txtKeywords_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeywords.Enter
    txtKeywords.SelectAll()
  End Sub

  Private Sub lstImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstImages.Click
    If lstImages.SelectedItems.Count = 0 Then Return
    DreamImage = Images(lstImages.SelectedItems(0).ImageIndex)
    DialogResult = Windows.Forms.DialogResult.OK
    objSearchClass.Completed = True
    Close()
  End Sub

  Private Sub lblRAC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRAC.LinkClicked
    System.Diagnostics.Process.Start("http://www.gettyimages.com")
  End Sub

  Private Sub ImageBrowserForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    objSearchClass.Completed = True
  End Sub

  Private Sub tmrDoSearch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDoSearch.Tick
    tmrDoSearch.Enabled = False
    If txtKeywords.Text <> "" Then Search()
  End Sub
End Class

Public Class ListViewNF
  Inherits System.Windows.Forms.ListView
  Public Sub New()
    'Activate double buffering
    Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

    'Enable the OnNotifyMessage event so we get a chance to filter out 
    ' Windows messages before they get to the form's WndProc
    Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
  End Sub

  Protected Overrides Sub OnNotifyMessage(ByVal m As Message)
    'Filter out the WM_ERASEBKGND message
    If m.Msg <> &H14 Then
      MyBase.OnNotifyMessage(m)
    End If
  End Sub
End Class