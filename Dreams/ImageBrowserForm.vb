Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports System.Drawing.Drawing2D

Public Class ImageBrowserForm

  Private searchGraph As Series

  Public DreamImage As Image

  Private Images As New List(Of Image)
  Private searchInstance As New SearchClass()

  Private Sub ImageBrowserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    DoubleBuffered = True

    graph.ChartAreas(0).AxisX.CustomLabels.Clear()
    graph.Series.Clear()
    graph.ResetAutoValues()
    graph.Annotations.Clear()

    searchGraph = graph.Series.Add("Dreams")
    searchGraph.ChartType = SeriesChartType.Column
    searchGraph.Color = Color.FromArgb(200, 65, 140, 240)
    searchGraph.BorderWidth = 1

    For i As Int32 = 1 To 25
      searchGraph.Points.AddY(0)
    Next

    searchGraph.Points.AddY(1000)

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
    Images.Clear()
    lstImages.Items.Clear()
    lstImg.Images.Clear()
    pnlSearching.Visible = True

    searchInstance = New SearchClass
    searchInstance.URL = "https://www.everypixel.com/search?q=" + txtKeywords.Text.Replace(" ", "+").Replace(vbNewLine, "+") + "&stocks_type=free&page=1"
    searchInstance.Completed = False

    AddHandler searchInstance.ListItemAdded, AddressOf ListItemAdded

    Dim objThread As New Thread(AddressOf searchInstance.DoSearchWork)
    objThread.Start()

    Do
      If searchInstance.Completed Then Exit Do
      Application.DoEvents()
      Thread.Sleep(128)
    Loop

    pnlSearching.Visible = False
  End Sub

  Private Delegate Sub ListItemAddedDelegate(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem, ByVal Size As Integer)
  Private Sub ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem, ByVal Size As Integer)
    Try
      If Thumbnail Is Nothing Then Return
      If searchInstance.Completed Then Return
      If InvokeRequired Then
        If searchInstance.Completed Then Exit Sub
        Dim d As New ListItemAddedDelegate(AddressOf ListItemAdded)
        Invoke(d, Thumbnail, Bitmap, Item, Size)
      Else
        Images.Add(Bitmap)
        lstImg.Images.Add(Thumbnail)
        Item.ImageIndex = lstImg.Images.Count - 1
        lstImages.Items.Add(Item)
        Item.EnsureVisible()
        searchGraph.Points.AddY(Size)
        searchGraph.Points.Remove(searchGraph.Points(0))
        graph.ChartAreas(0).RecalculateAxesScale()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Class SearchClass

    Public URL As String = "Dream"
    Public Completed As Boolean = False

    Public Event ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem, ByVal Size As Integer)

    Private m_intDownloaded As Integer = 0

    Public Sub DoSearchWork()
      Dim intImageIndex As Integer = 0
      Dim intStart As Integer = 0
      Dim intEnd As Integer = 0
      Dim strSource As String

      Try

        Dim objWebClient As New System.Net.WebClient
        strSource = objWebClient.DownloadString(URL)

        Dim position As Integer = strSource.IndexOf("response.images")
        Dim titleSearchString As String = "title: '"
        Dim urlSearchString As String = "url: '"

        While True
          position = strSource.IndexOf(titleSearchString, position)

          If position < 0 Then
            If URL.Contains("&stocks_type=free") Then
              URL = URL.Replace("&stocks_type=free", "")
              strSource = objWebClient.DownloadString(URL)
              position = strSource.IndexOf("response.images")
              position = strSource.IndexOf(titleSearchString, position)
              If position < 0 Then Exit While
            Else
              Exit While
            End If
          End If

          If Completed Then Exit While

          Dim endPosition = strSource.IndexOf("',", position)
          Dim objDownloadClass As New DownloadClass
          objDownloadClass.Title = strSource.Substring(position + titleSearchString.Length, endPosition - position - titleSearchString.Length)

          position = strSource.IndexOf(urlSearchString, position)
          endPosition = strSource.IndexOf("',", position)
          objDownloadClass.FileID = strSource.Substring(position + urlSearchString.Length, endPosition - position - urlSearchString.Length)
          objDownloadClass.ImageIndex = intImageIndex
          objDownloadClass.Completed = False
          AddHandler objDownloadClass.ListItemAdded, AddressOf ListItemAddedX

          Dim objThread As New Thread(AddressOf objDownloadClass.DoDownloadWork)
          objThread.Start()

          Thread.Sleep(2)
          Application.DoEvents()

          intImageIndex += 1

          position = endPosition

        End While

        ' Wait for all the threads to complete
        Do

          If Completed Then Exit Do

          If intImageIndex = 0 Then Exit Do

          If m_intDownloaded >= intImageIndex - 1 Then
            Exit Do
          End If

        Loop

      Catch ex As Exception

        MessageBox.Show(ex.Message, "LightenedDream.ImageSearch()", MessageBoxButtons.OK, MessageBoxIcon.Error)

      End Try

      Completed = True

    End Sub

    Private Sub ListItemAddedX(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem, ByVal Size As Integer)
      RaiseEvent ListItemAdded(Thumbnail, Bitmap, Item, Size)

      m_intDownloaded += 1
    End Sub

  End Class

  Private Class DownloadClass

    Public Event ListItemAdded(ByVal Thumbnail As Image, ByVal Bitmap As Image, ByVal Item As ListViewItem, ByVal Size As Integer)
    Public Title As String
    Public ImageIndex As Integer
    Public FileID As String
    Public Completed As Boolean = False

    Public Sub DoDownloadWork()
      Try

        Thread.Sleep(2)

        Dim objWebClient As New System.Net.WebClient
        Dim arrImage As Byte() = objWebClient.DownloadData(FileID)

        Dim objMem As New System.IO.MemoryStream(arrImage)
        Dim imgOriginal As Image = Image.FromStream(objMem)
        Dim imgBitmap As Image = ResizeImage(imgOriginal, New Drawing.Size(110, 110), True) 'Image.FromHbitmap(bmpThumbnail.GetHbitmap)

        Dim bmpThumbnail As New Bitmap(110, 110, Imaging.PixelFormat.Format32bppArgb)
        Dim imgThumbnail As Image = Image.FromHbitmap(bmpThumbnail.GetHbitmap)
        Dim objGraphics As System.Drawing.Graphics = Graphics.FromImage(imgThumbnail)
        objGraphics.Clear(Color.White)
        objGraphics.DrawImage(imgBitmap, 0, 0, imgBitmap.Width, imgBitmap.Height)

        Dim lstThumbnail As New ListViewItem(Title)
        lstThumbnail.ToolTipText = Title
        lstThumbnail.ImageIndex = ImageIndex
        lstThumbnail.Tag = FileID

        RaiseEvent ListItemAdded(imgThumbnail, imgBitmap, lstThumbnail, arrImage.Length)
      Catch ex As Exception

        RaiseEvent ListItemAdded(Nothing, Nothing, Nothing, 0)

      End Try

    End Sub

    Private Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
      Try
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
          Dim originalWidth As Integer = image.Width
          Dim originalHeight As Integer = image.Height
          Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
          Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
          Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
          newWidth = CInt(originalWidth * percent)
          newHeight = CInt(originalHeight * percent)
        Else
          newWidth = size.Width
          newHeight = size.Height
        End If

        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
          graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
          graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using

        Return newImage

      Catch ex As Exception
        Return image
      End Try
    End Function
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

  Private Sub txtKeywords_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeywords.Enter
    txtKeywords.SelectAll()
  End Sub

  Private Sub lstImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstImages.Click
    If lstImages.SelectedItems.Count = 0 Then Return
    DreamImage = Images(lstImages.SelectedItems(0).ImageIndex)
    DialogResult = Windows.Forms.DialogResult.OK
    searchInstance.Completed = True
    Close()
  End Sub

  Private Sub lblRAC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRAC.LinkClicked
    System.Diagnostics.Process.Start("http://www.everypixel.com")
  End Sub

  Private Sub ImageBrowserForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    searchInstance.Completed = True
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