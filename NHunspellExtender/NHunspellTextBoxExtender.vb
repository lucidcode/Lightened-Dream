Imports System.Windows.Forms
Imports System.ComponentModel
Imports NHunspell
Imports System.Reflection
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports Microsoft.Win32

<ToolboxBitmap(GetType(NHunspellTextBoxExtender), "spellcheck.png"), _
 ProvideProperty("SpellCheckEnabled", GetType(Control))> _
Public Class NHunspellTextBoxExtender
    Inherits Component
    Implements IExtenderProvider, ISupportInitialize

    'Private Const MessageLogPath As String = "D:\Messagelog6.txt"


#Region "Private Classes"


    ''' <summary>
    ''' This is the class that handles painting the wavy red lines.
    ''' 
    ''' It utilizes the NativeWindow to find out when it needs to draw
    ''' </summary>
    ''' <remarks></remarks>
    Private Class CustomPaintTextBox
        Inherits NativeWindow

        Private parentTextBox As TextBoxBase
        Private myBitmap As Bitmap
        Private textBoxGraphics As Graphics
        Private bufferGraphics As Graphics
        Private mySpellCheckControl As SpellCheckControl
        Private myParent As NHunspellTextBoxExtender

        Public Event CustomPaintComplete(ByVal sender As TextBoxBase, ByVal Milliseconds As Long)

        ''' <summary>
        ''' This is called when the textbox is being redrawn.
        ''' When it is, for the textbox to get refreshed, call it's default
        ''' paint method and then call our method
        ''' </summary>
        ''' <param name="m">The windows message</param>
        ''' <remarks></remarks>
        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            Select Case m.Msg
                Case 15 'This is the WM_PAINT message
                    'Invalidate the textBoxBase so that it gets refreshed properly
                    parentTextBox.Invalidate()

                    'call the default win32 Paint method for the TextBoxBase first
                    MyBase.WndProc(m)

                    'now use our code to draw the extra stuff
                    Me.CustomPaint()

                Case Else
                    MyBase.WndProc(m)
            End Select
        End Sub

        Public Sub New(ByRef CallingTextBox As TextBoxBase, ByRef ThisSpellCheckControl As SpellCheckControl, _
                       ByRef Parent As NHunspellTextBoxExtender)
            'Set up the CustomPaintTextBox
            parentTextBox = CallingTextBox

            'Create the link to the parent
            myParent = Parent

            'Create a bitmap with the same dimensions as the textbox
            myBitmap = New Bitmap(parentTextBox.Width, parentTextBox.Height)

            'Create the graphics object from this bitmpa...this is where we will draw the lines to start with
            bufferGraphics = Graphics.FromImage(myBitmap)
            bufferGraphics.Clip = New Region(parentTextBox.ClientRectangle)

            'Get the graphics object for the textbox.  We use this to draw the bufferGraphics
            textBoxGraphics = Graphics.FromHwnd(parentTextBox.Handle)

            'Assign a handle for this class and set it to the handle for the textbox
            Me.AssignHandle(parentTextBox.Handle)

            'We also need to make sure we update the handle if the handle for the textbox changes
            'This occurs if wordWrap is turned off for a RichTextBox
            AddHandler parentTextBox.HandleCreated, AddressOf TextBoxBase_HandleCreated

            'We need to add a handler to change the clip rectangle if the textBox is resized
            AddHandler parentTextBox.ClientSizeChanged, AddressOf TextBoxBase_ClientSizeChanged

            'Now set our spellchecker
            mySpellCheckControl = ThisSpellCheckControl
        End Sub

        ''' <summary>
        ''' Gets the ranges of chars that represent the spelling errors and then draw a wavy red line underneath
        ''' them.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub CustomPaint() 'ByVal sender As Object, ByVal e As DoWorkEventArgs)
            'Determine if we need to draw anything
            If Not mySpellCheckControl.HasSpellingErrors Then Return
            If Not myParent.IsEnabled(parentTextBox) Then Return
            If Not myParent.SpellAsYouType Then Return

            'Benchmarking
            Dim startTime As DateTime = Now

            Dim tempRTB As RichTextBox = Nothing

            If TypeOf parentTextBox Is RichTextBox Then
                tempRTB = New RichTextBox
                tempRTB.Rtf = CType(parentTextBox, RichTextBox).Rtf
            End If

            'Clear the graphics buffer
            bufferGraphics.Clear(Color.Transparent)

            'Now, find out if any of the spelling errors are within the visible part of the textbox
            Dim CharRanges() As CharacterRange = mySpellCheckControl.GetSpellingErrorRanges
            Dim visibleRanges() As CharacterRange
            ReDim visibleRanges(-1)

            'First get the ranges of characters visible in the textbox
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(parentTextBox.ClientRectangle.Width, parentTextBox.ClientRectangle.Height)
            Dim startIndex As Long = parentTextBox.GetCharIndexFromPosition(startPoint)
            Dim endIndex As Long = parentTextBox.GetCharIndexFromPosition(endPoint)

            'Benchmarking
            'Dim visibleStartTime As DateTime = Now

            'Go through each of the charRanges that were returned and see if they're visible
            For i = 0 To UBound(CharRanges)

                Dim rangeStart As Integer = -1
                Dim rangeEnd As Integer = -1

                'See if it's an ignore range
                Dim currentIgnoreRange As CharacterRange
                Dim ignoreRange As Boolean = False

                For Each currentIgnoreRange In mySpellCheckControl.GetIgnoreRanges
                    If (currentIgnoreRange.First = CharRanges(i).First) And _
                       (currentIgnoreRange.Length = CharRanges(i).Length) Then
                        ignoreRange = True
                    End If
                Next

                'If it's not a range we're to ignore, then see if it's visible
                If Not ignoreRange Then
                    For j = CharRanges(i).First To (CharRanges(i).First + (CharRanges(i).Length) - 1)
                        With parentTextBox
                            If j >= startIndex And j <= endIndex Then
                                If rangeStart = -1 Then
                                    rangeStart = j
                                Else
                                    rangeEnd = j
                                End If
                            End If
                        End With
                    Next

                    'Now add a new visibleRange to the array
                    If rangeStart <> -1 And rangeEnd <> -1 Then
                        Dim newRange As New CharacterRange(rangeStart, rangeEnd - rangeStart + 1)
                        ReDim Preserve visibleRanges(UBound(visibleRanges) + 1)
                        visibleRanges(UBound(visibleRanges)) = newRange
                    End If
                End If
            Next

            'Dim visibleDiff As TimeSpan = Now.Subtract(visibleStartTime)
            'Debug.Print("VisibleRanges: " & visibleDiff.TotalMilliseconds & " Milliseconds")

            'Now that we have the ranges that are visible, we're going to create the end points
            'to call the drawWave
            Dim currentRange As CharacterRange


            'Benchmarking
            'Dim drawStartTime As DateTime = Now

            For Each currentRange In visibleRanges
                'Get the X, Y of the start and end characters
                startPoint = parentTextBox.GetPositionFromCharIndex(currentRange.First)
                endPoint = parentTextBox.GetPositionFromCharIndex(currentRange.First + currentRange.Length - 1)

                If startPoint.Y <> endPoint.Y Then
                    'We have a word on multiple lines
                    Dim curIndex, startingIndex As Integer
                    curIndex = currentRange.First
                    startingIndex = curIndex

GetNextLine:
                    'Determine the first line of waves to draw
                    While (parentTextBox.GetPositionFromCharIndex(curIndex).Y = startPoint.Y) And _
                          (curIndex <= (currentRange.First + currentRange.Length - 1))
                        curIndex += 1
                    End While

                    'Go back to the previous character
                    curIndex -= 1

                    endPoint = parentTextBox.GetPositionFromCharIndex(curIndex)
                    Dim offsets As Point = GetOffsets(parentTextBox, startingIndex, curIndex, tempRTB)

                    'Dim offsetsDiff As TimeSpan = Now.Subtract(startTime)
                    'Debug.Print("Get Offsets: " & offsetsDiff.TotalMilliseconds & " Milliseconds")

                    'If we're using a RichTextBox, we have to account for the zoom factor
                    If TypeOf parentTextBox Is RichTextBox Then offsets.Y *= CType(parentTextBox, RichTextBox).ZoomFactor

                    'Reset the starting and ending points to make sure we're underneath the word
                    '(The measurestring adds some margin, so remove them)
                    startPoint.Y += offsets.Y - 2
                    endPoint.Y += offsets.Y - 2
                    endPoint.X += offsets.X - 0

                    'Add a new wavy line using the starting and ending point
                    DrawWave(startPoint, endPoint)

                    'Dim drawWaveDiff As TimeSpan = Now.Subtract(startTime)
                    'Debug.Print("DrawWave: " & drawWaveDiff.TotalMilliseconds & " Milliseconds")

                    startingIndex = curIndex + 1
                    curIndex += 1
                    startPoint = parentTextBox.GetPositionFromCharIndex(curIndex)

                    If curIndex <= (currentRange.First + currentRange.Length - 1) Then
                        GoTo GetNextLine
                    End If
                Else
                    Dim offsets As Point = GetOffsets(parentTextBox, currentRange.First, _
                                                      (currentRange.First + currentRange.Length - 1), tempRTB)

                    'Dim offsetsDiff As TimeSpan = Now.Subtract(startTime)
                    'Debug.Print("Get Offsets: " & offsetsDiff.TotalMilliseconds & " Milliseconds")

                    'If we're using a RichTextBox, we have to account for the zoom factor
                    If TypeOf parentTextBox Is RichTextBox Then offsets.Y *= CType(parentTextBox, RichTextBox).ZoomFactor

                    'Reset the starting and ending points to make sure we're underneath the word
                    '(The measurestring adds some margin, so remove them)
                    startPoint.Y += offsets.Y - 2
                    endPoint.Y += offsets.Y - 2
                    endPoint.X += offsets.X - 4

                    'Add a new wavy line using the starting and ending point
                    'If e.Cancel Then Return
                    DrawWave(startPoint, endPoint)

                    'Dim drawWaveDiff As TimeSpan = Now.Subtract(startTime)
                    'Debug.Print("DrawWave: " & drawWaveDiff.TotalMilliseconds & " Milliseconds")
                End If
            Next

            'Dim drawDiff As TimeSpan = Now.Subtract(drawStartTime)
            'Debug.Print("Draw: " & drawDiff.TotalMilliseconds & " Milliseconds")

            'We've drawn all of the wavy lines, so draw that image over the textbox
            textBoxGraphics.DrawImageUnscaled(myBitmap, 0, 0)

            'Dim dateDiff As TimeSpan = Now.Subtract(startTime)
            'Debug.Print("----TotalTime: " & dateDiff.Seconds & " Seconds, " & dateDiff.Milliseconds & " Milliseconds------------")

            RaiseEvent CustomPaintComplete(parentTextBox, Now.Subtract(startTime).TotalMilliseconds)
        End Sub

        ''' <summary>
        ''' Determines the X and Y offsets to use based on font height last letter width
        ''' </summary>
        ''' <param name="curTextBox"></param>
        ''' <param name="startingIndex"></param>
        ''' <param name="endingIndex"></param>
        ''' <param name="tempRTB"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetOffsets(ByRef curTextBox As TextBoxBase, ByVal startingIndex As Integer, _
                                    ByVal endingIndex As Integer, Optional ByVal tempRTB As RichTextBox = Nothing) As Point
            Dim startTime As DateTime = Now

            'We now have the top left point of the characters, now we need to add the offsets
            Dim offsetY As Integer = 0
            Dim fontToUse As Font = curTextBox.Font
            Dim offsets As Point

            fontToUse = New Font(fontToUse.FontFamily, 0.1, fontToUse.Style, fontToUse.Unit, fontToUse.GdiCharSet, fontToUse.GdiVerticalFont)

            'If it's a RichTextBox, we have to do some extra things
            If TypeOf curTextBox Is RichTextBox Then
                'We need to go through every character where we will draw the lines and get the tallest
                'font height

                'Benchmarking
                'Dim beforeCreateTextBoxDiff As TimeSpan = Now.Subtract(startTime)
                'Debug.Print("    Before Create TextBox: " & beforeCreateTextBoxDiff.TotalMilliseconds & " Milliseconds")

                'Create a temporary textbox for getting the RTF info so that we don't have to select and
                'de-select a lot of text and cause the screen to have to refresh
                If tempRTB Is Nothing Then
                    tempRTB = New RichTextBox
                    tempRTB.Rtf = CType(curTextBox, RichTextBox).Rtf
                End If

                'Benchmarking
                'Dim createTextBoxDiff As TimeSpan = Now.Subtract(startTime)
                'Debug.Print("    Create TextBox: " & createTextBoxDiff.TotalMilliseconds & " Milliseconds")

                With tempRTB
                    If .Text.Length > 0 Then
                        'Have to find the first visible character on that line
                        Dim firstCharInLine, lastCharInLine, curCharLine As Long
                        curCharLine = .GetLineFromCharIndex(startingIndex)
                        firstCharInLine = .GetFirstCharIndexFromLine(curCharLine)
                        lastCharInLine = .GetFirstCharIndexFromLine(curCharLine + 1)

                        If lastCharInLine = -1 Then lastCharInLine = curTextBox.TextLength

                        Dim getFontHeightStart As DateTime = Now

                        'Now go through every character that is visible and get the biggest font height
                        'Use the tempRTB for this
                        For i = firstCharInLine + 1 To (lastCharInLine + 1)
                            .SelectionStart = i
                            .SelectionLength = 1
                            If .SelectionFont.Height > fontToUse.Height Then
                                'fontHeight = .SelectionFont.Height
                                fontToUse = .SelectionFont
                            End If
                        Next

                        'Benchmarking
                        'Dim foundHeightdiff As TimeSpan = Now.Subtract(startTime)
                        'Debug.Print("    Get Font Height: " & foundHeightdiff.TotalMilliseconds & " Milliseconds")

                        offsetY = fontToUse.Height
                    End If

                End With
            Else
                'If we get here, it's just a standard textbox and we can just use the font height
                fontToUse = curTextBox.Font

                offsetY = curTextBox.Font.Height
            End If

            'Now find out how wide the last character is
            Dim offsetX As Integer = 0
            offsetX = textBoxGraphics.MeasureString(curTextBox.Text(startingIndex + (endingIndex - startingIndex)), _
                                                    fontToUse).Width

            offsets = New Point(offsetX, offsetY)

            'Benchmarking
            'Dim timeDiff As TimeSpan = Now.Subtract(startTime)
            'Debug.Print("GetOffsets: " & timeDiff.TotalMilliseconds & " Milliseconds")

            Return offsets
        End Function

        ''' <summary>
        ''' The textbox is not redrawn much, so this will force the textbox to call the custom paint function.
        ''' Otherwise, text can be entered and no wavy red lines will appear
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ForcePaint()
            parentTextBox.Invalidate()
        End Sub

        ''' <summary>
        ''' Draws the wavy red line given a starting point and an ending point
        ''' </summary>
        ''' <param name="StartOfLine">A Point representing the starting point</param>
        ''' <param name="EndOfLine">A Point representing the ending point</param>
        ''' <remarks></remarks>
        Private Sub DrawWave(ByVal StartOfLine As Point, ByVal EndOfLine As Point)
            Dim newPen As Pen = Pens.Red

            If (EndOfLine.X - StartOfLine.X) > 4 Then
                Dim pl As New ArrayList
                For i = StartOfLine.X To (EndOfLine.X - 2) Step 4
                    pl.Add(New Point(i, StartOfLine.Y))
                    pl.Add(New Point(i + 2, StartOfLine.Y + 2))
                Next

                Dim p() As Point = CType(pl.ToArray(GetType(Point)), Point())
                bufferGraphics.DrawLines(newPen, p)
            Else
                bufferGraphics.DrawLine(newPen, StartOfLine, EndOfLine)
            End If
        End Sub

        ''' <summary>
        ''' Reassign this classes handle and the graphics object anytime the textbox's handle is changed
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TextBoxBase_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.AssignHandle(parentTextBox.Handle)
            textBoxGraphics = Graphics.FromHwnd(parentTextBox.Handle)
        End Sub

        ''' <summary>
        ''' When the TextBoxBase is resized, this will reset the objects that are used to draw
        ''' the wavy, red line.  Without this, anything outside of the original bounds will not
        ''' be drawn
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TextBoxBase_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim tempTextBox As TextBoxBase = sender

            'Create a bitmap with the same dimensions as the textbox
            myBitmap = New Bitmap(tempTextBox.Width, tempTextBox.Height)

            'Create the graphics object from this bitmpa...this is where we will draw the lines to start with
            bufferGraphics = Graphics.FromImage(myBitmap)
            bufferGraphics.Clip = New Region(tempTextBox.ClientRectangle)

            'Get the graphics object for the textbox.  We use this to draw the bufferGraphics
            textBoxGraphics = Graphics.FromHwnd(tempTextBox.Handle)
        End Sub
    End Class


#End Region




#Region "Variables"
    Private myNHunspell As Hunspell = Nothing

    'Hashtables
    Private controlEnabled As Hashtable
    Private mySpellCheckers As Hashtable
    Private myCustomPaintingTextBoxes As Hashtable
    Private myContextMenus As Hashtable
    'Private testHash As Hashtable

    'Other
    Private controlPressed As Boolean = False
    Private drawTest As CustomPaintTextBox
    Private myControls() As Control
    Private boolDisableAddWordPrompt As Boolean = False
    Private initializing As Boolean = False

    'Property values
    Private _SpellAsYouType As Boolean
    Private _shortcutKey As Shortcut
    Private myNumOfSuggestions As Integer
    Private _Language As String

    'Declared functions
    Private Declare Function GetScrollPos Lib "user32.dll" ( _
            ByVal hWnd As IntPtr, _
            ByVal nBar As Integer) As Integer
    Private Declare Function SetScrollPos Lib "user32.dll" ( _
            ByVal hWnd As IntPtr, _
            ByVal nBar As Integer, _
            ByVal nPos As Integer, _
            ByVal bRedraw As Boolean) As Integer
    Private Declare Function PostMessageA Lib "user32.dll" ( _
            ByVal hwnd As IntPtr, _
            ByVal wMsg As Integer, _
            ByVal wParam As Integer, _
            ByVal lParam As Integer) As Boolean
    Private Declare Auto Function SendMessage Lib "user32.dll" ( _
            ByVal hWnd As IntPtr, _
            ByVal wMsg As Int32, _
            ByVal wParam As IntPtr, _
            ByVal lParam As IntPtr) As IntPtr

    ' Scrollbar direction
    Const SBS_HORZ = 0
    Const SBS_VERT = 1

    ' Windows Messages
    Const WM_VSCROLL = &H115
    Const WM_HSCROLL = &H114
    Const SB_THUMBPOSITION = 4

    'Redrawing
    Private Const WM_SETREDRAW As Int32 = &HB
#End Region




#Region "ISupportInitialize"
    Public Sub BeginInit() Implements System.ComponentModel.ISupportInitialize.BeginInit
        initializing = True
    End Sub

    Public Sub EndInit() Implements System.ComponentModel.ISupportInitialize.EndInit
        initializing = False
    End Sub
#End Region




#Region "New and CanExtend Methods"



    ''' <summary>
    ''' Determines which items this extender can extend.  It is only objects that implement TextBoxBase
    ''' </summary>
    ''' <param name="extendee">The control being checked</param>
    ''' <returns>A boolean value indicating whether it can be extended</returns>
    ''' <remarks></remarks>
    Public Function CanExtend(ByVal extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
        Return (TypeOf extendee Is TextBoxBase) And (Not myNHunspell Is Nothing)
    End Function




    ''' <summary>
    ''' We need to make sure that the dic and aff files are on the disk.  Then, we try to create
    ''' the Hunspell object.  After that, we set up the hashtables and tooltip
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        'Biggest problem is the requirement to have two dictionary files on the HDD along with
        'either the x64 or x86 Hunspell DLL which are not .NET dlls.
        'To get around this, we find the directory that the program is being called from and add
        'the dictionary files.
        'Then, we try to create the Hunspell and if a "DLL not found" error is thrown, we find out
        'where the dll's were supposed to be and then add them.

        AddHandler Me.LanguageChanged, AddressOf MyLanguageChanged
        MaintainUserChoice = True

        Dim USdic, USaff As String

        'Get the calling assembly's location
        Dim callingDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

        'Try and write to the directory to see if we can
        Dim boolFailed As Boolean = False

        Try
            Directory.CreateDirectory(callingDir & "\Test")
        Catch ex As Exception
            boolFailed = True
        Finally
            Directory.Delete(callingDir & "\Test")
        End Try

        If boolFailed Then
            callingDir = "C:\Windows\Temp"
        End If


        'First see if there is a registry value that tells us where to get the dictionary from.
        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender")


        If regKey Is Nothing Then
            regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True).CreateSubKey("NHunspellTextBoxExtender")
            Dim regKeyLanguage As RegistryKey = regKey.CreateSubKey("Languages")
            regKeyLanguage.SetValue("Default", "English")

            'Set the paths for the dic and aff files
            USdic = callingDir & "\SpellCheck\en_US.dic"
            USaff = callingDir & "\SpellCheck\en_US.aff"

            'Check if the spell check directory already exists.  If not, add it
            If Not Directory.Exists(callingDir & "\SpellCheck") Then
                Directory.CreateDirectory(callingDir & "\SpellCheck")
                Dim newDirInfo As New DirectoryInfo(callingDir & "\SpellCheck")
                newDirInfo.Attributes = FileAttributes.Hidden
            End If

            'Check if the spell check files already exist.  If not, add it
            If Not File.Exists(USaff) Then
                Try
                    File.WriteAllBytes(USaff, My.Resources.en_US)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                End Try
            End If

            If Not File.Exists(USdic) Then
                Try
                    File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                End Try
            End If

            Dim paths() As String = {USaff, USdic}
            regKeyLanguage.SetValue("English", paths, RegistryValueKind.MultiString)

            Dim languages() As String = {"English"}
            regKeyLanguage.SetValue("LanguageList", languages, RegistryValueKind.MultiString)

            regKeyLanguage.Close()
            regKeyLanguage.Dispose()

            _Language = "English"
        Else
            'Get the default language
            Dim regKeyLanguage As RegistryKey = regKey.OpenSubKey("Languages", True)

            Dim defaultLanguage As String = regKeyLanguage.GetValue("Default")

            Dim paths() As String

            paths = TryCast(regKeyLanguage.GetValue(defaultLanguage), String())

            _Language = defaultLanguage

            If regKeyLanguage.GetValue(defaultLanguage) Is Nothing Then
                'Check if English is there and use it...otherwise, check if another language is available
                paths = TryCast(regKeyLanguage.GetValue("English"), String())

                If regKeyLanguage.GetValue("English") Is Nothing Then
                    'Set the paths for the dic and aff files
                    USdic = callingDir & "\SpellCheck\en_US.dic"
                    USaff = callingDir & "\SpellCheck\en_US.aff"

                    'Check if the spell check directory already exists.  If not, add it
                    If Not Directory.Exists(callingDir & "\SpellCheck") Then
                        Directory.CreateDirectory(callingDir & "\SpellCheck")
                        Dim newDirInfo As New DirectoryInfo(callingDir & "\SpellCheck")
                        newDirInfo.Attributes = FileAttributes.Hidden
                    End If

                    'Check if the spell check files already exist.  If not, add it
                    If Not File.Exists(USaff) Then
                        Try
                            File.WriteAllBytes(USaff, My.Resources.en_US)
                        Catch ex As Exception
                            MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                        End Try
                    End If

                    If Not File.Exists(USdic) Then
                        Try
                            File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                        Catch ex As Exception
                            MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                        End Try
                    End If

                    paths = {USaff, USdic}
                    _Language = "English"
                Else
                    If Not File.Exists(paths(0)) Then
                        USaff = callingDir & "\SpellCheck\en_US.aff"

                        Try
                            File.WriteAllBytes(USaff, My.Resources.en_US)
                        Catch ex As Exception
                            MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                        End Try

                        paths(0) = USaff
                    End If

                    If Not File.Exists(paths(1)) Then
                        USdic = callingDir & "\SpellCheck\en_US.dic"

                        Try
                            File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                        Catch ex As Exception
                            MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                        End Try

                        paths(1) = USdic
                    End If
                End If

                _Language = "English"
            End If
            USaff = paths(0)
            USdic = paths(1)

            'check if these files exist
            If Not File.Exists(USaff) Then
                USaff = callingDir & "\SpellCheck\en_US.aff"

                Try
                    File.WriteAllBytes(USaff, My.Resources.en_US)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                End Try

                paths(0) = USaff

                regKeyLanguage.SetValue(_Language, paths, RegistryValueKind.MultiString)
            End If
            If Not File.Exists(USdic) Then
                USdic = callingDir & "\SpellCheck\en_US.dic"

                Try
                    File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                End Try

                paths(1) = USdic

                regKeyLanguage.SetValue(_Language, paths, RegistryValueKind.MultiString)
            End If

            regKeyLanguage.Flush()
            regKeyLanguage.Close()
            regKeyLanguage.Dispose()
        End If

        regKey.Close()
        regKey.Dispose()

        'Create the new hunspell
CreateNewHunspell:
        Try
            'Hunspell.NativeDllPath = "D:\Temp"

            myNHunspell = New Hunspell(USaff, USdic)
        Catch ex As Exception
            If TypeOf ex Is System.DllNotFoundException Then
                'Get where the dll is supposed to be
                Dim DLLpath As String = Trim(Strings.Mid(ex.Message, InStr(ex.Message, "DLL not found:") + 14))
                Dim DLLName As String = Path.GetFileName(DLLpath)

                'Find out which DLL is missing
                If DLLName = "Hunspellx64.dll" Then
                    'Copy the dll to the directory
                    Try
                        File.WriteAllBytes(DLLpath, My.Resources.Hunspellx64)
                    Catch ex2 As Exception
                        MessageBox.Show("Error writing Hunspellx64.dll" & vbNewLine & ex2.Message)
                    End Try

                    'Try again
                    GoTo CreateNewHunspell
                ElseIf DLLName = "Hunspellx86.dll" Then 'x86 dll
                    'Copy the dll to the directory
                    Try
                        File.WriteAllBytes(DLLpath, My.Resources.Hunspellx86)
                    Catch ex3 As Exception
                        MessageBox.Show("Error writing Hunspellx86.dll" & vbNewLine & ex3.Message)
                    End Try

                    'Try again
                    GoTo CreateNewHunspell
                ElseIf DLLName = "NHunspell.dll" Then
                    Try
                        File.WriteAllBytes(DLLpath, My.Resources.NHunspell)
                    Catch ex4 As Exception
                        MessageBox.Show("Error writing NHunspell.dll" & vbNewLine & ex4.Message)
                    End Try
                Else
                    MessageBox.Show(ex.Message & ex.StackTrace)
                End If
            Else
                MessageBox.Show("SpellChecker cannot be created." & vbNewLine & "Spell checking will be disabled." & _
                vbNewLine & vbNewLine & ex.Message & ex.StackTrace)
                myNHunspell = Nothing
            End If
        End Try

        'myNHunspell = FromAssembly()

        'See if there are any words to add
        If File.Exists(callingDir & "\SpellCheck\" & _Language & "AddedWords.dat") Then
            Using r As New StreamReader(callingDir & "\SpellCheck\" & _Language & "AddedWords.dat")
                While Not r.EndOfStream
                    myNHunspell.Add(Trim(Replace(r.ReadLine, vbNewLine, "")))
                End While
                r.Close()
            End Using
        End If

        'Set up Hashtables
        controlEnabled = New Hashtable
        mySpellCheckers = New Hashtable
        myCustomPaintingTextBoxes = New Hashtable
        myContextMenus = New Hashtable

        'Set the initial properties
        myNumOfSuggestions = 5
        _SpellAsYouType = True
        _shortcutKey = Shortcut.F7
        ReDim myControls(-1)
    End Sub


    'Private Shared Function FromAssembly() As Object
    'Dim a As Assembly = Assembly.Load(My.Resources.NHunspell)
    'Dim type_l As Type = a.GetType("NHunspell.Hunspell")
    'Dim types(1) As Type
    'types(0) = GetType(String)
    'types(1) = GetType(String)
    'Dim ctor As ConstructorInfo = type_l.GetConstructor(types)

    'Dim USdic, USaff As String
    'Dim callingDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

    ''Set the paths for the dic and aff files
    'USdic = callingDir & "\SpellCheck\en_US.dic"
    'USaff = callingDir & "\SpellCheck\en_US.aff"

    ''Check if the spell check directory already exists.  If not, add it
    'If Not Directory.Exists(callingDir & "\SpellCheck") Then
    'Directory.CreateDirectory(callingDir & "\SpellCheck")
    'Dim newDirInfo As New DirectoryInfo(callingDir & "\SpellCheck")
    'newDirInfo.Attributes = FileAttributes.Hidden
    'End If

    ''Check if the spell check files already exist.  If not, add it
    'If Not File.Exists(USaff) Then
    'Try
    'File.WriteAllBytes(USaff, My.Resources.en_US)
    'Catch ex As Exception
    'MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
    'End Try
    'End If

    'If Not File.Exists(USdic) Then
    'Try
    'File.WriteAllBytes(USdic, My.Resources.en_US_dic)
    'Catch ex As Exception
    'MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
    'End Try
    'End If

    'Dim params(1) As Object
    'params(0) = USaff
    'params(1) = USdic

    'Dim result As Object = Nothing

    'CreateNewHunspell:
    'Try
    'result = ctor.Invoke(params)
    'Catch ex As Exception
    'If TypeOf ex.InnerException Is System.DllNotFoundException Then
    ''Get where the dll is supposed to be
    'Dim DLLpath As String = Trim(Strings.Mid(ex.InnerException.Message, InStr(ex.InnerException.Message, "DLL not found:") + 14))
    'Dim DLLName As String = Path.GetFileName(DLLpath)

    ''Find out which DLL is missing
    'If DLLName = "Hunspellx64.dll" Then
    ''Copy the dll to the directory
    'Try
    'File.WriteAllBytes(DLLpath, My.Resources.Hunspellx64)
    'Catch ex2 As Exception
    'MessageBox.Show("Error writing Hunspellx64.dll" & vbNewLine & ex2.Message)
    'End Try

    ''Try again
    'GoTo CreateNewHunspell
    'ElseIf DLLName = "Hunspellx86.dll" Then 'x86 dll
    ''Copy the dll to the directory
    'Try
    'File.WriteAllBytes(DLLpath, My.Resources.Hunspellx86)
    'Catch ex3 As Exception
    'MessageBox.Show("Error writing Hunspellx86.dll" & vbNewLine & ex3.Message)
    'End Try

    ''Try again
    'GoTo CreateNewHunspell
    ''ElseIf DLLName = "NHunspell.dll" Then
    ''Try
    ''File.WriteAllBytes(DLLpath, My.Resources.NHunspell)
    ''Catch ex4 As Exception
    ''MessageBox.Show("Error writing NHunspell.dll" & vbNewLine & ex4.Message)
    ''End Try
    'Else
    'MessageBox.Show(ex.Message & ex.StackTrace)
    'End If
    'Else
    'MessageBox.Show("SpellChecker cannot be created." & vbNewLine & "Spell checking will be disabled." & _
    'vbNewLine & vbNewLine & ex.Message & ex.StackTrace)
    'Return Nothing
    'End If
    'End Try

    'Return result
    'End Function
    Public Shared Function MyResolveEventHandler(ByVal sender As Object, ByVal args As ResolveEventArgs) As Assembly
        For i = 0 To AppDomain.CurrentDomain.GetAssemblies.Count - 1
            MessageBox.Show(args.Name & vbNewLine & AppDomain.CurrentDomain.GetAssemblies(i).GetName().Name)

            If AppDomain.CurrentDomain.GetAssemblies(i).GetName().Name = args.Name Then
                Return AppDomain.CurrentDomain.GetAssemblies(i)
            End If
        Next

        Return Nothing
    End Function

#End Region




#Region "Enable/Disable"



    ''' <summary>
    ''' Allows this class the be enabled programatically
    ''' </summary>
    ''' <param name="TextBoxesToEnable">
    ''' Allows the programmer to add as many TextBoxBases as they want at once.
    ''' </param>
    ''' <remarks>
    ''' Examples:
    ''' EnableTextBoxBase(TextBox1)
    ''' EnableTextBoxBase(RichTextBox1, RichTextBox2, TextBox1)
    ''' </remarks>
    Public Sub EnableTextBoxBase(ByVal ParamArray TextBoxesToEnable() As TextBoxBase) 'ByRef TextBoxToEnable As TextBoxBase)
        For c = 0 To UBound(TextBoxesToEnable)
            If TypeOf (TextBoxesToEnable(c)) Is TextBoxBase Then

                Dim TextBoxToEnable As TextBoxBase = TextBoxesToEnable(c)

                'Set the hashtables
                If controlEnabled(TextBoxToEnable) Is Nothing Then
                    controlEnabled.Add(TextBoxToEnable, True)
                    mySpellCheckers.Add(TextBoxToEnable, New SpellCheckControl(myNHunspell))
                    myCustomPaintingTextBoxes.Add(TextBoxToEnable, New CustomPaintTextBox(CType(TextBoxToEnable, TextBoxBase), _
                                                  CType(mySpellCheckers(TextBoxToEnable), SpellCheckControl), Me))
                    AddHandler CType(myCustomPaintingTextBoxes(TextBoxToEnable), CustomPaintTextBox).CustomPaintComplete, AddressOf OnCustomPaintComplete

                    If TextBoxToEnable.ContextMenuStrip Is Nothing Then
                        TextBoxToEnable.ContextMenuStrip = New ContextMenuStrip
                    End If
                    TextBoxToEnable.ContextMenuStrip.Tag = TextBoxToEnable.Name

                    myContextMenus.Add(TextBoxToEnable, TextBoxToEnable.ContextMenuStrip)

                    Dim boolFound As Boolean = False
                    For i = 0 To UBound(myControls)
                        If myControls(i).Name = TextBoxToEnable.Name Then
                            boolFound = True
                            Exit For
                        End If
                    Next

                    If Not boolFound Then
                        ReDim Preserve myControls(UBound(myControls) + 1)
                        myControls(UBound(myControls)) = TextBoxToEnable
                    End If

                    'Set up all of the handlers
                    AddHandler TextBoxToEnable.TextChanged, AddressOf TextBox_TextChanged
                    AddHandler TextBoxToEnable.KeyDown, AddressOf TextBox_KeyDown
                    AddHandler TextBoxToEnable.KeyPress, AddressOf TextBox_KeyPress
                    AddHandler TextBoxToEnable.MouseMove, AddressOf TextBox_MouseMove
                    AddHandler TextBoxToEnable.ContextMenuStrip.Opening, AddressOf ContextMenu_Opening
                    AddHandler TextBoxToEnable.ContextMenuStrip.Closed, AddressOf ContextMenu_Closed

                    CType(mySpellCheckers(TextBoxToEnable), SpellCheckControl).SetText(TextBoxToEnable.Text)
                Else
                    controlEnabled(TextBoxToEnable) = True
                End If

                TextBoxToEnable.Invalidate()
            End If
        Next
    End Sub



    ''' <summary>
    ''' Allows this class to be disabled programatically
    ''' </summary>
    ''' <param name="TextBoxToDisable"></param>
    ''' <remarks></remarks>
    Public Sub DisableTextBoxBase(ByRef TextBoxToDisable As TextBoxBase)
        controlEnabled(TextBoxToDisable) = False
        TextBoxToDisable.Invalidate()
    End Sub




    Public Function IsEnabled(ByRef TextBoxBaseToCheck As TextBoxBase) As Boolean
        Return controlEnabled(TextBoxBaseToCheck)
    End Function




#End Region




#Region "Provided Properties"


#Region "Enabled"


    ''' <summary>
    ''' This will return whether the spell checker is enabled for the requested textbox.
    ''' The default value is false, otherwise, the SetSpellCheckEnabled will never be called
    ''' and there will be no way to set up the event handlers
    ''' </summary>
    ''' <param name="extendee">The control being tested</param>
    ''' <returns>A boolean representing whether spell check is enabled</returns>
    ''' <remarks></remarks>
    <Category("SpellCheck"), DefaultValue(False)> _
    Public Function GetSpellCheckEnabled(ByVal extendee As Control) As Boolean
        If controlEnabled(extendee) Is Nothing Then
            controlEnabled.Add(extendee, False)
        End If

        Return controlEnabled(extendee)
    End Function


    ''' <summary>
    ''' Sets whether the spellcheck is enabled.  This is only called if the requested value
    ''' is different from the default value (therefore if the spell check is enabled).
    ''' Once we set the enabled property, we then set up the event handlers
    ''' 
    ''' In case the spellchecker is disabled programatically, we include the options for 
    ''' removing the event handlers as well.
    ''' </summary>
    ''' <param name="extendee">The control associated with the enabled request</param>
    ''' <param name="Input">A boolean representing whether spell check is enabled</param>
    ''' <remarks></remarks>
    Public Sub SetSpellCheckEnabled(ByVal extendee As Control, ByVal Input As Boolean)
        If myNHunspell Is Nothing Then
            controlEnabled.Add(extendee, False)
            Return
        End If

        'Set the hashtables
        If controlEnabled(extendee) Is Nothing Then
            controlEnabled.Add(extendee, (Input And (Not myNHunspell Is Nothing)))

            mySpellCheckers.Add(extendee, New SpellCheckControl(myNHunspell))
            myCustomPaintingTextBoxes.Add(extendee, New CustomPaintTextBox(CType(extendee, TextBoxBase), _
                                                                           CType(mySpellCheckers(extendee), SpellCheckControl), _
                                                                           Me))
            AddHandler CType(myCustomPaintingTextBoxes(extendee), CustomPaintTextBox).CustomPaintComplete, AddressOf OnCustomPaintComplete

            If (CType(extendee, TextBoxBase).ContextMenuStrip) Is Nothing Then
                CType(extendee, TextBoxBase).ContextMenuStrip = New ContextMenuStrip
            End If

            AddHandler CType(extendee, TextBoxBase).ContextMenuStrip.Opening, AddressOf ContextMenu_Opening
            AddHandler CType(extendee, TextBoxBase).ContextMenuStrip.Closed, AddressOf ContextMenu_Closed

            myContextMenus.Add(extendee, CType(extendee, TextBoxBase).ContextMenuStrip)

            ReDim Preserve myControls(UBound(myControls) + 1)
            myControls(UBound(myControls)) = extendee
        Else
            controlEnabled(extendee) = (Input And (Not myNHunspell Is Nothing))
        End If

        'Get the handlers
        If Input = True And Not myNHunspell Is Nothing Then
            AddHandler CType(extendee, TextBoxBase).TextChanged, AddressOf TextBox_TextChanged
            AddHandler CType(extendee, TextBoxBase).KeyDown, AddressOf TextBox_KeyDown
            AddHandler CType(extendee, TextBoxBase).KeyPress, AddressOf TextBox_KeyPress
            AddHandler CType(extendee, TextBoxBase).MouseMove, AddressOf TextBox_MouseMove
        Else
            RemoveHandler CType(extendee, TextBoxBase).TextChanged, AddressOf TextBox_TextChanged
            RemoveHandler CType(extendee, TextBoxBase).KeyDown, AddressOf TextBox_KeyDown
            RemoveHandler CType(extendee, TextBoxBase).KeyPress, AddressOf TextBox_KeyPress
            RemoveHandler CType(extendee, TextBoxBase).MouseMove, AddressOf TextBox_MouseMove
        End If

    End Sub

#End Region


#End Region




#Region "Properties"



    Public Enum SuggestionNumbers
        One
        Two
        Three
        Four
        Five
    End Enum



    <Description("Sets the key that will bring up the full spell check dialog"), _
     Browsable(True)> _
    Public Property ShortcutKey() As Shortcut
        Get
            Return _shortcutKey
        End Get
        Set(ByVal value As Shortcut)
            _shortcutKey = value
        End Set
    End Property



    <Description("Sets the number of suggestions that will be returned on a right-click"), _
     Browsable(True), DefaultValue(SuggestionNumbers.Five)> _
    Public Property NumberofSuggestions() As SuggestionNumbers
        Get
            Select Case myNumOfSuggestions
                Case 1
                    Return SuggestionNumbers.One
                Case 2
                    Return SuggestionNumbers.Two
                Case 3
                    Return SuggestionNumbers.Three
                Case 4
                    Return SuggestionNumbers.Four
                Case Else
                    Return SuggestionNumbers.Five
            End Select
        End Get
        Set(ByVal value As SuggestionNumbers)
            Select Case value
                Case SuggestionNumbers.One
                    myNumOfSuggestions = 1
                Case SuggestionNumbers.Two
                    myNumOfSuggestions = 2
                Case SuggestionNumbers.Three
                    myNumOfSuggestions = 3
                Case SuggestionNumbers.Four
                    myNumOfSuggestions = 4
                Case SuggestionNumbers.Five
                    myNumOfSuggestions = 5
            End Select
        End Set
    End Property



    <Description("Enables or disables spell checking as the user types.")> _
    Public Property SpellAsYouType() As Boolean
        Get
            Return _SpellAsYouType
        End Get
        Set(ByVal value As Boolean)
            _SpellAsYouType = value

            For Each txtBox As TextBoxBase In myControls
                txtBox.Invalidate()
            Next
        End Set
    End Property


    Public Event LanguageChanged(ByVal sender As Object, ByVal NewLanguage As String)


    <Description("Selects the language for spell checking. (Will only change the language on the developer's computer)")> _
    <EditorAttribute(GetType(LanguageEditor), GetType(Drawing.Design.UITypeEditor))> _
    Public Property Language() As String
        Get
            Return _Language
        End Get
        Set(ByVal value As String)
            If MaintainUserChoice And Not Me.DesignMode Then Return

            Dim boolFound As Boolean = False

            For Each lang In GetAvailableLanguages()
                If lang = value Then boolFound = True
            Next

            If Not boolFound Then Return

            Dim raiseChangeEvent As Boolean = (value <> _Language)

            _Language = value

            If raiseChangeEvent Then
                RaiseEvent LanguageChanged(Me, value)
            End If
        End Set
    End Property


    <Description("If selected to false, whenever the program starts up, it will default to the designer selection" & vbNewLine & _
                 "If selected to true, will disable any direct calls to change the language." & _
                 "To change the language, use the SelectLanguage method")> _
    Public Property MaintainUserChoice As Boolean

#End Region




#Region "Events"



#Region "CustomEvents"
    Public Event CustomPaintComplete(ByVal sender As TextBoxBase, ByVal Milliseconds As Long)

    Public Sub OnCustomPaintComplete(ByVal sender As TextBoxBase, ByVal Milliseconds As Long)
        RaiseEvent CustomPaintComplete(sender, Milliseconds)
    End Sub
#End Region



#Region "TextBox Events"


    ''' <summary>
    ''' When the text changes, check all of the words in the text box.  If there is a spelling error
    ''' then inform the user of that error.
    ''' </summary>
    ''' <param name="sender">The textbox that is being typed in</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'If Not _SpellAsYouType Then Return

        With CType(mySpellCheckers(sender), SpellCheckControl)
            .SetText(CType(sender, TextBoxBase).Text)
        End With

        CType(sender, TextBoxBase).Invalidate()
    End Sub



    ''' <summary>
    ''' Handles the shortcuts (have to use KeyDown because KeyPress doesn't capture the function keys or delete)
    ''' </summary>
    ''' <param name="sender">The TextBox being typed in</param>
    ''' <param name="e">The key being pushed down</param>
    ''' <remarks></remarks>
    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If ShortcutKey = e.KeyCode Then
            'If Not _SpellAsYouType Then
            'CType(mySpellCheckers(sender), SpellCheckControl).SetText(CType(sender, TextBoxBase).Text)
            'End If

            If Not CType(mySpellCheckers(sender), SpellCheckControl).HasSpellingErrors Then Return

            RunFullSpellChecker(CType(sender, TextBoxBase))
            Return
        End If

        'If Not _SpellAsYouType Then Return

        If e.Control Or e.Alt Then
            controlPressed = True
        Else
            controlPressed = False
        End If

        If e.KeyCode = Keys.Delete Then
            For i = 1 To CType(sender, TextBoxBase).SelectionLength + 1
                CType(mySpellCheckers(sender), SpellCheckControl).RemoveText(CType(sender, TextBoxBase).SelectionStart)
            Next

            With CType(myCustomPaintingTextBoxes(sender), CustomPaintTextBox)
                .ForcePaint()
            End With
        End If
    End Sub



    ''' <summary>
    ''' Handles the backspace and adding characters
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Not _SpellAsYouType Then Return

        With CType(mySpellCheckers(sender), SpellCheckControl)
            If controlPressed Then Return

            If CType(sender, TextBoxBase).SelectionLength > 0 Then
                For i = 1 To CType(sender, TextBoxBase).SelectionLength
                    .RemoveText(CType(sender, TextBoxBase).SelectionStart)
                Next
            End If

            If Asc(e.KeyChar) = Keys.Back Then
                .RemoveText(CType(sender, TextBoxBase).SelectionStart - 1)
            Else
                .AddText(e.KeyChar, CType(sender, TextBoxBase).SelectionStart)
            End If

            With CType(myCustomPaintingTextBoxes(sender), CustomPaintTextBox)
                .ForcePaint()
            End With
        End With
    End Sub


#End Region



#Region "Mouse Events"


    Private currentMouseLocation As Point
    Private currentTextBox As TextBoxBase


    Private Sub TextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        currentMouseLocation = e.Location
        currentTextBox = CType(sender, TextBoxBase)
    End Sub



#End Region



    Private Sub MyLanguageChanged(ByVal sender As Object, ByVal NewLanguage As String)
        CType(sender, NHunspellTextBoxExtender).SetLanguage(NewLanguage)
    End Sub


#End Region




#Region "ContextMenu"

    Friend WithEvents Suggestion1, Suggestion2, Suggestion3, Suggestion4, Suggestion5 As ToolStripMenuItem
    Friend WithEvents AddWord, IgnoreWord, IgnoreAll, Spelling As ToolStripMenuItem
    Private Separator1, Separator2 As ToolStripSeparator
    Private originalMouseLocation As Point
    Private ownerTextBox As TextBoxBase

    ''' <summary>
    ''' Controls all of the contextmenuitem clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub ContextMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
         Handles Suggestion1.Click, Suggestion2.Click, Suggestion3.Click, Suggestion4.Click, _
                 Suggestion5.Click, AddWord.Click, IgnoreWord.Click, IgnoreAll.Click, Spelling.Click
        'Get which button was clicked then perform its action.  Afterwards, remove all buttons

        Select Case CType(sender, ToolStripMenuItem).Name
            'If it's a Spell1 through Spell5, then it's a suggestion item
            Case "qwr3Spell1"
                ReplaceWord(Suggestion1.Tag, Suggestion1.Text)
            Case "qwr3Spell2"
                ReplaceWord(Suggestion2.Tag, Suggestion2.Text)
            Case "qwr3Spell3"
                ReplaceWord(Suggestion3.Tag, Suggestion3.Text)
            Case "qwr3Spell4"
                ReplaceWord(Suggestion4.Tag, Suggestion4.Text)
            Case "qwr3Spell5"
                ReplaceWord(Suggestion5.Tag, Suggestion5.Text)
            Case "qwr3Add"
                AddWordToDictionary(AddWord.Tag)
            Case "qwr3Ignore"
                IgnoreSelectedWord(IgnoreWord.Tag, CType(CType(sender, ToolStripMenuItem).Owner, ContextMenuStrip).Left, _
                                   CType(CType(sender, ToolStripMenuItem).Owner, ContextMenuStrip).Top)
            Case "qwr3IgnoreAll"
                IgnoreAllWord(IgnoreAll.Tag)
            Case "qwr3Spelling"
                Dim ownerTextBoxBase As TextBoxBase = Nothing

                For i = 0 To UBound(myControls)
                    If myControls(i).Name = Spelling.Tag Then
                        ownerTextBoxBase = myControls(i)
                    End If
                Next

                RunFullSpellChecker(ownerTextBoxBase)
        End Select
    End Sub


    ''' <summary>
    ''' If it was closed by not clicking on an item, then we remove the items and reset them
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ContextMenu_Closed(ByVal sender As Object, _
                                   ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs)
        If e.CloseReason = ToolStripDropDownCloseReason.ItemClicked Then Return

        With CType(sender, ContextMenuStrip)
            If Not Suggestion1 Is Nothing Then
                .Items.Remove(Suggestion1)
                Suggestion1 = Nothing
            End If
            If Not Suggestion2 Is Nothing Then
                .Items.Remove(Suggestion2)
                Suggestion2 = Nothing
            End If
            If Not Suggestion3 Is Nothing Then
                .Items.Remove(Suggestion3)
                Suggestion3 = Nothing
            End If
            If Not Suggestion4 Is Nothing Then
                .Items.Remove(Suggestion4)
                Suggestion4 = Nothing
            End If
            If Not Suggestion5 Is Nothing Then
                .Items.Remove(Suggestion5)
                Suggestion5 = Nothing
            End If
            If Not AddWord Is Nothing Then
                .Items.Remove(AddWord)
                AddWord = Nothing
            End If
            If Not IgnoreWord Is Nothing Then
                .Items.Remove(IgnoreWord)
                IgnoreWord = Nothing
            End If
            If Not IgnoreAll Is Nothing Then
                .Items.Remove(IgnoreAll)
                IgnoreAll = Nothing
            End If
            If Not Spelling Is Nothing Then
                .Items.Remove(Spelling)
                Spelling = Nothing
            End If
            If Not Separator1 Is Nothing Then
                .Items.Remove(Separator1)
                Separator1 = Nothing
            End If
            If Not Separator2 Is Nothing Then
                .Items.Remove(Separator2)
                Separator2 = Nothing
            End If
        End With
    End Sub


    ''' <summary>
    ''' If we are spell checking as the user types, add items to the textbox's context menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ContextMenu_Opening(ByVal sender As System.Object, _
                                    ByVal e As System.ComponentModel.CancelEventArgs)
        If Not _SpellAsYouType Then Return

        'MessageBox.Show(CType(sender, ContextMenuStrip).MouseButtons.ToString)

        e.Cancel = True

        'Make sure that none of the items are still in the menu
        With CType(sender, ContextMenuStrip)
            If Not Suggestion1 Is Nothing Then
                .Items.Remove(Suggestion1)
                Suggestion1 = Nothing
            End If
            If Not Suggestion2 Is Nothing Then
                .Items.Remove(Suggestion2)
                Suggestion2 = Nothing
            End If
            If Not Suggestion3 Is Nothing Then
                .Items.Remove(Suggestion3)
                Suggestion3 = Nothing
            End If
            If Not Suggestion4 Is Nothing Then
                .Items.Remove(Suggestion4)
                Suggestion4 = Nothing
            End If
            If Not Suggestion5 Is Nothing Then
                .Items.Remove(Suggestion5)
                Suggestion5 = Nothing
            End If

            If Not AddWord Is Nothing Then
                .Items.Remove(AddWord)
            End If
            If Not IgnoreWord Is Nothing Then
                .Items.Remove(IgnoreWord)
            End If
            If Not IgnoreAll Is Nothing Then
                .Items.Remove(IgnoreAll)
            End If
            If Not Spelling Is Nothing Then
                .Items.Remove(Spelling)
            End If

            If Not Separator1 Is Nothing Then
                .Items.Remove(Separator1)
                Separator1 = Nothing
            End If
            If Not Separator2 Is Nothing Then
                .Items.Remove(Separator2)
                Separator2 = Nothing
            End If
        End With

        'See if we're over a spelling error

        'get the textbox
        ownerTextBox = currentTextBox

        'See if spell-checking is enabled
        If Not controlEnabled(ownerTextBox) Then
            If CType(sender, ContextMenuStrip).Items.Count <> 0 Then e.Cancel = False

            Return
        End If

        'first see if there are any spelling errors
        If Not CType(mySpellCheckers(ownerTextBox), SpellCheckControl).HasSpellingErrors Then
            If CType(sender, ContextMenuStrip).Items.Count <> 0 Then e.Cancel = False

            Return
        End If

        Dim charIndex As Integer

        'Get the location of the word based on the starting point for the context menu
        originalMouseLocation = currentMouseLocation

        charIndex = ownerTextBox.GetCharIndexFromPosition(currentMouseLocation)

        'This will actually still return a character even if not directly over one.  We need to check the character
        'height against the mouseLocation.Y
        If TypeOf ownerTextBox Is RichTextBox Then

            With CType(ownerTextBox, RichTextBox)
                'We're going to find the font that was the tallest used
                Dim fontHeight As Integer
                Dim selFont As Font
                selFont = .Font

                Dim firstCharInLine, lastCharInLine, curCharLine As Long
                curCharLine = .GetLineFromCharIndex(charIndex)
                firstCharInLine = .GetFirstCharIndexFromLine(curCharLine)
                lastCharInLine = .GetFirstCharIndexFromLine(curCharLine + 1)

                If lastCharInLine = -1 Then lastCharInLine = ownerTextBox.TextLength

                Dim tempRTB As New RichTextBox
                tempRTB.Rtf = .Rtf

                With tempRTB
                    'Now find the tallest font
                    For i = (firstCharInLine + 1) To (lastCharInLine + 1)
                        .SelectionStart = i
                        .SelectionLength = 1
                        If .SelectionFont.Height > fontHeight Then
                            fontHeight = .SelectionFont.Height
                            selFont = .SelectionFont
                        End If
                    Next
                End With

                'Now find out if the mouse could be over the word or is in blank space
                Using g As Graphics = .CreateGraphics
                    Dim y As Integer
                    y = g.MeasureString(.GetCharFromPosition(currentMouseLocation), selFont).Height + _
                        .GetPositionFromCharIndex(charIndex).Y
                    If currentMouseLocation.Y > y Or currentMouseLocation.Y < 0 Then
                        If CType(sender, ContextMenuStrip).Items.Count <> 0 Then
                            e.Cancel = False
                        End If

                        Return
                    End If
                End Using
            End With
        Else
            'We get here if it's a regular textbox.  We can juse use it's font height and see if
            'we're over an item or blank space
            Using g As Graphics = ownerTextBox.CreateGraphics
                Dim y As Integer

                Dim currentIndex As Long = ownerTextBox.GetCharIndexFromPosition(currentMouseLocation)
                Dim currentLine As Long = ownerTextBox.GetLineFromCharIndex(currentIndex)

                y = ownerTextBox.Font.Height * (currentLine + 1)
                If currentMouseLocation.Y > y Or currentMouseLocation.Y < 0 Then
                    'We're not actually over an item

                    If CType(sender, ContextMenuStrip).Items.Count <> 0 Then
                        e.Cancel = False
                    End If

                    Return
                End If
            End Using
        End If

        'If the current charIndex is not part of a misspelled word, just exit
        If Not CType(mySpellCheckers(ownerTextBox), SpellCheckControl).IsPartOfSpellingError(charIndex) Then
            e.Cancel = True
            Return
        End If

        'Otherwise...


        'Set up the contextmenu
        If CType(sender, ContextMenuStrip).Items.Count > 0 Then
            'We're adding to the user created context menu, so add a line
            Separator1 = New ToolStripSeparator
            CType(sender, ContextMenuStrip).Items.Add(Separator1)
        End If

        'Get the suggestions
        Dim suggestions() As String
        ReDim suggestions(-1)
        Dim misspelledWord As String
        With CType(mySpellCheckers(ownerTextBox), SpellCheckControl)
            misspelledWord = .GetMisspelledWordAtPosition(charIndex)
            suggestions = .GetSuggestions(misspelledWord, myNumOfSuggestions)
        End With

        'Add the suggestion buttons
        With CType(sender, ContextMenuStrip)
            If UBound(suggestions) = -1 Then
                Suggestion1 = New ToolStripMenuItem("No suggestions found")
                Suggestion1.Name = "qwr3Spell1"
                Suggestion1.ToolTipText = "No suggestions found"
                Suggestion1.Font = New Font(Suggestion1.Font, FontStyle.Italic)
                Suggestion1.Tag = misspelledWord
                Suggestion1.Enabled = False
                .Items.Add(Suggestion1)
            Else
                For i = 0 To UBound(suggestions)
                    Dim onClickHandler As New EventHandler(AddressOf ContextMenuItem_Click)

                    'The tag on the suggestion items is the misspelled word
                    Select Case i
                        Case 0
                            Suggestion1 = New ToolStripMenuItem(suggestions(i))
                            Suggestion1.Name = "qwr3Spell1"
                            Suggestion1.ToolTipText = suggestions(i)
                            Suggestion1.Font = New Font(Suggestion1.Font, FontStyle.Bold)
                            Suggestion1.Tag = misspelledWord
                            .Items.Add(Suggestion1)
                        Case 1
                            Suggestion2 = New ToolStripMenuItem(suggestions(i))
                            Suggestion2.Name = "qwr3Spell2"
                            Suggestion2.ToolTipText = suggestions(i)
                            Suggestion2.Font = New Font(Suggestion2.Font, FontStyle.Bold)
                            Suggestion2.Tag = misspelledWord
                            .Items.Add(Suggestion2)
                        Case 2
                            Suggestion3 = New ToolStripMenuItem(suggestions(i))
                            Suggestion3.Name = "qwr3Spell3"
                            Suggestion3.ToolTipText = suggestions(i)
                            Suggestion3.Font = New Font(Suggestion3.Font, FontStyle.Bold)
                            Suggestion3.Tag = misspelledWord
                            .Items.Add(Suggestion3)
                        Case 3
                            Suggestion4 = New ToolStripMenuItem(suggestions(i))
                            Suggestion4.Name = "qwr3Spell4"
                            Suggestion4.ToolTipText = suggestions(i)
                            Suggestion4.Font = New Font(Suggestion4.Font, FontStyle.Bold)
                            Suggestion4.Tag = misspelledWord
                            .Items.Add(Suggestion4)
                        Case 4
                            Suggestion5 = New ToolStripMenuItem(suggestions(i))
                            Suggestion5.Name = "qwr3Spell5"
                            Suggestion5.ToolTipText = suggestions(i)
                            Suggestion5.Font = New Font(Suggestion5.Font, FontStyle.Bold)
                            Suggestion5.Tag = misspelledWord
                            .Items.Add(Suggestion5)
                    End Select
                Next
            End If

            Separator2 = New ToolStripSeparator
            .Items.Add(Separator2)

            'Now add the add and ignore buttons
            If AddWord Is Nothing Then
                AddWord = New ToolStripMenuItem("Add Word...")
                AddWord.Name = "qwr3Add"
                AddWord.ToolTipText = "Add the word to the dictionary"
            End If
            'The addWord Tag is the misspelled word
            AddWord.Tag = misspelledWord
            .Items.Add(AddWord)

            If IgnoreWord Is Nothing Then
                IgnoreWord = New ToolStripMenuItem("Ignore Once...")
                IgnoreWord.Name = "qwr3Ignore"
                IgnoreWord.ToolTipText = "Ignore this instance of the currently selected word"
            End If

            'The ignore once tag is the name of the textbox
            IgnoreWord.Tag = ownerTextBox.Name
            .Items.Add(IgnoreWord)

            If IgnoreAll Is Nothing Then
                IgnoreAll = New ToolStripMenuItem("Ignore All...")
                IgnoreAll.Name = "qwr3IgnoreAll"
                IgnoreAll.ToolTipText = "Ignore all instances of the currently selected word"
            End If
            'The ignore all Tag is the misspelled word
            IgnoreAll.Tag = misspelledWord
            .Items.Add(IgnoreAll)

            'Now add the spelling button
            If Spelling Is Nothing Then
                Spelling = New ToolStripMenuItem("Run Spell Checker...")
                Spelling.Name = "qwr3Spelling"
                Spelling.ToolTipText = "Runs the full spell checker on this text."
            End If
            'The Spelling tag is the name of the textbox
            Spelling.Tag = ownerTextBox.Name
            .Items.Add(Spelling)
        End With

        e.Cancel = False
    End Sub


    ''' <summary>
    ''' Replaces the word that was clicked on with a word from the suggestions
    ''' </summary>
    ''' <param name="OriginalWord"></param>
    ''' <param name="NewWord"></param>
    ''' <remarks></remarks>
    Private Sub ReplaceWord(ByVal OriginalWord As String, ByVal NewWord As String)
        'Get original scroll position
        Dim Position = GetScrollPos(ownerTextBox.Handle, SBS_VERT)

        'Disable redraw
        SendMessage(ownerTextBox.Handle, WM_SETREDRAW, New IntPtr(CInt(False)), IntPtr.Zero)

        'Get the location of the original word to replace from the contextmenustrip
        Dim charIndex As Integer = ownerTextBox.GetCharIndexFromPosition(originalMouseLocation)

        Dim charRanges() As CharacterRange

        With CType(mySpellCheckers(ownerTextBox), SpellCheckControl)
            charRanges = .GetSpellingErrorRanges()
        End With

        Dim wordStart As Integer
        wordStart = -1

        Dim currentRange As CharacterRange

        For Each currentRange In charRanges
            If charIndex >= currentRange.First And charIndex <= (currentRange.First + currentRange.Length - 1) Then
                wordStart = currentRange.First
            End If
        Next

        If wordStart = -1 Then Return

        If TypeOf ownerTextBox Is RichTextBox Then
            Dim _zoomFactor As Double = CType(ownerTextBox, RichTextBox).ZoomFactor

            Dim tempRTB As New RichTextBox
            tempRTB.Rtf = CType(ownerTextBox, RichTextBox).Rtf

            tempRTB.SelectionStart = wordStart
            tempRTB.SelectionLength = OriginalWord.Length
            tempRTB.SelectedText = NewWord

            CType(ownerTextBox, RichTextBox).Rtf = tempRTB.Rtf
            CType(ownerTextBox, RichTextBox).ZoomFactor = 1
            CType(ownerTextBox, RichTextBox).ZoomFactor = _zoomFactor
        Else
            If wordStart = 0 Then
                ownerTextBox.Text = Microsoft.VisualBasic.Strings.Replace(ownerTextBox.Text, OriginalWord, NewWord, 1)
            Else
                ownerTextBox.Text = Microsoft.VisualBasic.Strings.Left(ownerTextBox.Text, wordStart - 1) & _
                                    Microsoft.VisualBasic.Strings.Replace(ownerTextBox.Text, OriginalWord, NewWord, wordStart, 1)
            End If
        End If

        ownerTextBox.SelectionStart = wordStart + NewWord.Length
        ownerTextBox.SelectionLength = 0

        'Reset scroll position
        If (SetScrollPos(ownerTextBox.Handle, SBS_VERT, Position, True) <> -1) Then
            PostMessageA(ownerTextBox.Handle, WM_VSCROLL, SB_THUMBPOSITION + &H10000 * Position, Nothing)
        End If

        'Enable redraw
        SendMessage(ownerTextBox.Handle, WM_SETREDRAW, New IntPtr(CInt(True)), IntPtr.Zero)

        ownerTextBox.Refresh()
    End Sub


    ''' <summary>
    ''' Adds the word to the dictionary in memory and to a file on disk
    ''' </summary>
    ''' <param name="WordToAdd"></param>
    ''' <remarks></remarks>
    Private Sub AddWordToDictionary(ByVal WordToAdd As String)
        If Not boolDisableAddWordPrompt Then
            Dim result As DialogResult
            result = MyDialog.Show("This will add the word " & Chr(34) & WordToAdd & Chr(34) & "." & _
                                     vbNewLine & vbNewLine & "Are you sure?", "Add Word to Dictionary")

            'result = MessageBox.Show("This will add the word " & Chr(34) & WordToAdd & Chr(34) & "." & _
            'vbNewLine & vbNewLine & "Are you sure?", "Add Word to Dictionary", _
            'MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            'Check if we're to disable future prompts
            If result = (DialogResult.Ignore + DialogResult.No) Then
                boolDisableAddWordPrompt = True
                Return
            ElseIf result = (DialogResult.Yes + DialogResult.Ignore) Then
                boolDisableAddWordPrompt = True
            ElseIf result = DialogResult.No Then
                Return
            End If
        End If

        'Add it to the dictionary in memory
        myNHunspell.Add(WordToAdd)

        'Add it to the file on disk
        Dim callingDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

        'Try and write to the directory to see if we can
        Dim boolFailed As Boolean = False

        Try
            Directory.CreateDirectory(callingDir & "\Test")
        Catch ex As Exception
            boolFailed = True
        Finally
            Directory.Delete(callingDir & "\Test")
        End Try

        If boolFailed Then
            callingDir = "C:\Windows\Temp"
        End If

        If Not Directory.Exists(callingDir & "\SpellCheck") Then
            Directory.CreateDirectory(callingDir & "\SpellCheck")
        End If

        Using w As New StreamWriter(callingDir & "\SpellCheck\" & Language & "AddedWords.dat", True)
            w.WriteLine(WordToAdd)
            w.Flush()
            w.Close()
        End Using

        'Reset all of the textboxes to refresh the spelling
        For i = 0 To UBound(myControls)
            If TypeOf myControls(i) Is TextBoxBase Then
                With CType(myControls(i), TextBoxBase)
                    'Get original scroll position
                    Dim Position = GetScrollPos(.Handle, SBS_VERT)

                    'Disable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(False)), IntPtr.Zero)

                    Dim controlText, controlRTF As String
                    controlText = .Text
                    controlRTF = ""

                    If TypeOf myControls(i) Is RichTextBox Then
                        controlRTF = CType(myControls(i), RichTextBox).Rtf
                    End If

                    Dim selectionStart, selectionLength As Integer
                    selectionLength = .SelectionLength
                    selectionStart = .SelectionStart

                    .ResetText()
                    .Text = controlText

                    If controlRTF <> "" Then
                        CType(myControls(i), RichTextBox).Rtf = controlRTF
                    End If

                    .SelectionStart = selectionStart
                    .SelectionLength = selectionLength

                    'Reset scroll position
                    If (SetScrollPos(.Handle, SBS_VERT, Position, True) <> -1) Then
                        PostMessageA(.Handle, WM_VSCROLL, SB_THUMBPOSITION + &H10000 * Position, Nothing)
                    End If

                    'Enable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(True)), IntPtr.Zero)

                    .Refresh()
                End With
            End If
        Next


    End Sub


    ''' <summary>
    ''' Ignores the selected word once
    ''' </summary>
    ''' <param name="callingTextBoxName"></param>
    ''' <param name="LeftLocation"></param>
    ''' <param name="TopLocation"></param>
    ''' <remarks></remarks>
    Private Sub IgnoreSelectedWord(ByVal callingTextBoxName As String, ByVal LeftLocation As Integer, _
                                   ByVal TopLocation As Integer)
        'We're only ignoring the currently selected word, so we need to get the range to add it to the spell checker
        Dim callingTextBox As TextBoxBase = Nothing

        For i = 0 To UBound(myControls)
            If myControls(i).Name = callingTextBoxName Then
                callingTextBox = myControls(i)
            End If
        Next

        If callingTextBox Is Nothing Then Return

        'Get the range of the original word
        Dim charIndex As Integer = _
            callingTextBox.GetCharIndexFromPosition(originalMouseLocation)

        Dim misspelledRange As New CharacterRange(-1, -1)
        Dim currentRange As CharacterRange

        For Each currentRange In CType(mySpellCheckers(callingTextBox), SpellCheckControl).GetSpellingErrorRanges
            If currentRange.First <= charIndex And (currentRange.First + currentRange.Length + 1) >= charIndex Then
                misspelledRange = currentRange
                Exit For
            End If
        Next

        If misspelledRange.First = -1 Then Return

        'Add the range to the ignore words list
        CType(mySpellCheckers(callingTextBox), SpellCheckControl).AddRangeToIgnore(misspelledRange)

        'repaint the textbox
        callingTextBox.Invalidate()
    End Sub


    ''' <summary>
    ''' Ignore all instances of the word.  This will add the word to the dictionary in memory, but not on disk
    ''' </summary>
    ''' <param name="WordToIgnore"></param>
    ''' <remarks></remarks>
    Private Sub IgnoreAllWord(ByVal WordToIgnore As String)


        'Add the word to the dictionary in memory
        myNHunspell.Add(WordToIgnore)

        'Reset all of the textboxes to refresh the spelling
        For i = 0 To UBound(myControls)
            If TypeOf myControls(i) Is TextBoxBase Then
                With CType(myControls(i), TextBoxBase)
                    'Get original scroll position
                    Dim Position = GetScrollPos(.Handle, SBS_VERT)

                    'Disable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(False)), IntPtr.Zero)

                    Dim controlText, controlRTF As String
                    controlText = .Text
                    controlRTF = ""

                    If TypeOf myControls(i) Is RichTextBox Then
                        controlRTF = CType(myControls(i), RichTextBox).Rtf
                    End If

                    Dim selectionStart, selectionLength As Integer
                    selectionLength = .SelectionLength
                    selectionStart = .SelectionStart

                    .ResetText()
                    .Text = controlText

                    If controlRTF <> "" Then
                        CType(myControls(i), RichTextBox).Rtf = controlRTF
                    End If

                    .SelectionStart = selectionStart
                    .SelectionLength = selectionLength

                    'Reset scroll position
                    If (SetScrollPos(.Handle, SBS_VERT, Position, True) <> -1) Then
                        PostMessageA(.Handle, WM_VSCROLL, SB_THUMBPOSITION + &H10000 * Position, Nothing)
                    End If

                    'Enable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(True)), IntPtr.Zero)

                    .Refresh()
                End With
            End If
        Next


    End Sub


#End Region




#Region "Change Language"
    Public Function GetAvailableLanguages() As String()
        Dim languageList() As String

        Dim regKey As RegistryKey = _
            Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages")
        languageList = TryCast(regKey.GetValue("LanguageList"), String())

        regKey.Close()
        regKey.Dispose()

        Return languageList
    End Function

    Public Sub SetLanguage(ByVal NewLanguage As String)
        'Check if the language is in the registry
        Dim boolFound As Boolean = False

        For Each st As String In GetAvailableLanguages()
            If st = NewLanguage Then boolFound = True
        Next

        If Not boolFound Then
            Throw New ArgumentException("LanguageToRemove does not exist!", "LanguageToRemove", _
                    New Exception("The language " & NewLanguage & " is not currently loaded."))
        End If

        'Open the registry
        Dim regKey As RegistryKey = _
            Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        Dim paths() As String = TryCast(regKey.GetValue(NewLanguage), String())

        If regKey.GetValue(NewLanguage) Is Nothing Then
            'If we get there, then the Aff and Dic files don't exist

            Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())
            Dim newLanguageList(UBound(languages) - 1) As String
            Dim count As Integer = 0

            For Each Lang In languages
                If Lang <> NewLanguage Then
                    newLanguageList(count) = Lang
                    count += 1
                End If
            Next

            regKey.SetValue("LanguageList", newLanguageList, Microsoft.Win32.RegistryValueKind.MultiString)
            regKey.DeleteValue(NewLanguage)

            regKey.Close()
            regKey.Dispose()

            Throw New FileNotFoundException("Aff and Dic files are missing")
        Else
            For Each path In paths
                If Not System.IO.File.Exists(path) Then
                    'System.Windows.Forms.MessageBox.Show("Aff and Dic files are missing")

                    Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())
                    Dim newLanguageList(UBound(languages) - 1) As String
                    Dim count As Integer = 0

                    For Each Lang In languages
                        If Lang <> NewLanguage Then
                            newLanguageList(count) = Lang
                            count += 1
                        End If
                    Next

                    regKey.SetValue("LanguageList", newLanguageList, Microsoft.Win32.RegistryValueKind.MultiString)
                    regKey.DeleteValue(NewLanguage)

                    regKey.Close()
                    regKey.Dispose()

                    Throw New FileNotFoundException("File not found", path)
                End If
            Next
        End If

        'If we get here, then the paths and language are valid
        'Now try to create the object
        Try
            myNHunspell = New Hunspell(paths(0), paths(1))
        Catch ex As Exception
            'MessageBox.Show("Could not create the new Hunspell using the specified language")

            Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())
            Dim newLanguageList(UBound(languages) - 1) As String
            Dim count As Integer = 0

            For Each Lang In languages
                If Lang <> NewLanguage Then
                    newLanguageList(count) = Lang
                    count += 1
                End If
            Next

            regKey.SetValue("LanguageList", newLanguageList, Microsoft.Win32.RegistryValueKind.MultiString)
            regKey.DeleteValue(NewLanguage)

            regKey.Close()
            regKey.Dispose()

            Throw ex
        End Try

        'See if there are any words to add
        If File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location) & _
                       "\SpellCheck\" & _Language & "AddedWords.dat") Then
            Using r As New StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location) & _
                                        "\SpellCheck\" & _Language & "AddedWords.dat")
                While Not r.EndOfStream
                    myNHunspell.Add(Trim(Replace(r.ReadLine, vbNewLine, "")))
                End While
                r.Close()
            End Using
        End If

        _Language = NewLanguage
        regKey.SetValue("Default", NewLanguage)
        regKey.Close()
        regKey.Dispose()

        'Reset all of the textboxes to refresh the spelling
        For i = 0 To UBound(myControls)
            If TypeOf myControls(i) Is TextBoxBase Then
                With CType(myControls(i), TextBoxBase)
                    With CType(mySpellCheckers(myControls(i)), SpellCheckControl)
                        .UpdateHunspell(myNHunspell)
                    End With


                    'Get original scroll position
                    Dim Position = GetScrollPos(.Handle, SBS_VERT)

                    'Disable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(False)), IntPtr.Zero)

                    Dim controlText, controlRTF As String
                    controlText = .Text
                    controlRTF = ""

                    If TypeOf myControls(i) Is RichTextBox Then
                        controlRTF = CType(myControls(i), RichTextBox).Rtf
                    End If

                    Dim selectionStart, selectionLength As Integer
                    selectionLength = .SelectionLength
                    selectionStart = .SelectionStart

                    .ResetText()
                    .Text = controlText

                    If controlRTF <> "" Then
                        CType(myControls(i), RichTextBox).Rtf = controlRTF
                    End If

                    .SelectionStart = selectionStart
                    .SelectionLength = selectionLength

                    'Reset scroll position
                    If (SetScrollPos(.Handle, SBS_VERT, Position, True) <> -1) Then
                        PostMessageA(.Handle, WM_VSCROLL, SB_THUMBPOSITION + &H10000 * Position, Nothing)
                    End If

                    'Enable redraw
                    SendMessage(.Handle, WM_SETREDRAW, New IntPtr(CInt(True)), IntPtr.Zero)

                    .Refresh()
                End With
            End If
        Next
    End Sub

    Public Function AddNewLanguage() As Boolean
        'Open an AddLanguage Form
        Dim newAddLanguage As New AddLanguage
        newAddLanguage.ShowDialog()

        If newAddLanguage.Result = DialogResult.Cancel Then Return False

        'Add the Item to the registry
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())

        Dim boolFound As Boolean = False
        For Each lang In languages
            If lang = newAddLanguage.txtName.Text Then
                boolFound = True
                Exit For
            End If
        Next

        If Not boolFound Then
            ReDim Preserve languages(UBound(languages) + 1)
            languages(UBound(languages)) = newAddLanguage.txtName.Text

            regKey.SetValue("LanguageList", languages, Microsoft.Win32.RegistryValueKind.MultiString)
        End If

        Dim paths(1) As String

        paths(0) = newAddLanguage.txtAff.Text
        paths(1) = newAddLanguage.txtDic.Text

        regKey.SetValue(newAddLanguage.txtName.Text, paths, Microsoft.Win32.RegistryValueKind.MultiString)

        regKey.Close()
        regKey.Dispose()

        Return True
    End Function

    Public Sub RemoveLanguage(ByVal LanguageToRemove As String)
        'Check if the language is in the registry
        Dim boolFound As Boolean = False

        For Each st As String In GetAvailableLanguages()
            If st = LanguageToRemove Then boolFound = True
        Next

        If Not boolFound Then
            Throw New ArgumentException("LanguageToRemove does not exist!", "LanguageToRemove", _
                    New Exception("The language " & LanguageToRemove & " is not currently loaded."))
        End If

        'Open the registry
        Dim regKey As RegistryKey = _
            Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        'Remove the language from the LanguageList
        Dim languages() As String = TryCast(regKey.GetValue("LanguageList"), String())

        If UBound(languages) = -1 Then
            Throw New Exception("Unable to retrieve Language list from registry")
        End If

        Dim newLanguageList(UBound(languages) - 1) As String
        Dim count As Integer = 0

        For Each lang In languages
            If lang <> LanguageToRemove Then
                newLanguageList(count) = lang
                count += 1
            End If
        Next

        'Update the registry
        regKey.SetValue("LanguageList", newLanguageList, RegistryValueKind.MultiString)

        If regKey.GetValue(LanguageToRemove) IsNot Nothing Then
            regKey.DeleteValue(LanguageToRemove)
        End If

        'Check if the default was the language removed
        If regKey.GetValue("Default") = LanguageToRemove Then
            If regKey.GetValue("English") IsNot Nothing Then
                SetLanguage("English")
            Else
                If GetAvailableLanguages.Count = 0 Then
                    'Default to English
                    ResetLanguages()
                Else
                    SetLanguage(GetAvailableLanguages()(0))
                End If
            End If
        End If

        'Check if all of the languagues were removed
        If newLanguageList.Count = 0 Then
            ResetLanguages()
        End If

        regKey.Close()
        regKey.Dispose()
    End Sub

    Private Sub ResetLanguages()
        Dim USdic, USaff As String

        'Get the calling assembly's location
        Dim callingDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

        Dim regKey As RegistryKey = _
            Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        Dim paths() As String = TryCast(regKey.GetValue("English"), String())

        If regKey.GetValue("English") Is Nothing Then
            'Set the paths for the dic and aff files
            USdic = callingDir & "\SpellCheck\en_US.dic"
            USaff = callingDir & "\SpellCheck\en_US.aff"

            'Check if the spell check directory already exists.  If not, add it
            If Not Directory.Exists(callingDir & "\SpellCheck") Then
                Directory.CreateDirectory(callingDir & "\SpellCheck")
                Dim newDirInfo As New DirectoryInfo(callingDir & "\SpellCheck")
                newDirInfo.Attributes = FileAttributes.Hidden
            End If

            'Check if the spell check files already exist.  If not, add it
            If Not File.Exists(USaff) Then
                Try
                    File.WriteAllBytes(USaff, My.Resources.en_US)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                End Try
            End If

            If Not File.Exists(USdic) Then
                Try
                    File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                End Try
            End If

            paths = {USaff, USdic}
        Else
            If Not File.Exists(paths(0)) Then
                USaff = callingDir & "\SpellCheck\en_US.aff"

                Try
                    File.WriteAllBytes(USaff, My.Resources.en_US)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.aff file!" & vbNewLine & ex.Message)
                End Try

                paths(0) = USaff
            End If

            If Not File.Exists(paths(1)) Then
                USdic = callingDir & "\SpellCheck\en_US.dic"

                Try
                    File.WriteAllBytes(USdic, My.Resources.en_US_dic)
                Catch ex As Exception
                    MessageBox.Show("Error writing en_US.dic file!" & vbNewLine & ex.Message)
                End Try

                paths(1) = USdic
            End If
        End If

        _Language = "English"
        regKey.SetValue("Default", "English")
        regKey.SetValue("English", paths, RegistryValueKind.MultiString)
        regKey.SetValue("LanguageList", {"English"}, RegistryValueKind.MultiString)
        regKey.Close()
        regKey.Dispose()

        SetLanguage("English")

    End Sub

    Public Sub UpdateLanguageFiles(ByVal LanguageToUpdate As String, ByVal NewAffFileLocation As String, _
                                   ByVal NewDicFileLocation As String, _
                                   Optional ByVal OverwriteExistingFiles As Boolean = False, _
                                   Optional ByVal RemoveOlderFiles As Boolean = False)
        'Check if the language exists
        Dim boolFound As Boolean = False

        For Each st As String In GetAvailableLanguages()
            If st = LanguageToUpdate Then boolFound = True
        Next

        If Not boolFound Then
            Throw New ArgumentException("LanguageToRemove does not exist!", "LanguageToRemove", _
                    New Exception("The language " & LanguageToUpdate & " is not currently loaded and cannot be updated." & _
                                  vbNewLine & "If you are trying to add a new language, use teh AddLanguage() method"))
        End If

        'Check if the new file paths are valid
        If Not File.Exists(NewAffFileLocation) Then
            Throw New FileNotFoundException("File could not be found", NewAffFileLocation)
        End If

        If Not File.Exists(NewDicFileLocation) Then
            Throw New FileNotFoundException("File could not be found", NewDicFileLocation)
        End If

        'Open the registry key
        Dim regKey As RegistryKey = _
            Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages", True)

        Dim paths() As String

        If OverwriteExistingFiles Then
            'Get the original file locations
            paths = TryCast(regKey.GetValue(LanguageToUpdate), String())

            'If nothing was returned, we can just overwrite the registry
            If regKey.GetValue(LanguageToUpdate) Is Nothing Then
                ReDim paths(1)
                paths(0) = NewAffFileLocation
                paths(1) = NewDicFileLocation
            Else
                'If we are overwriting, we need to check that the originals exist
                If paths(0) = "" Then
                    paths(0) = NewAffFileLocation
                Else
                    File.Copy(NewAffFileLocation, paths(0))
                End If

                If paths(1) = "" Then
                    paths(1) = NewDicFileLocation
                Else
                    File.Copy(NewDicFileLocation, paths(1))
                End If
            End If

            'Save the new paths
            regKey.SetValue(LanguageToUpdate, paths, RegistryValueKind.MultiString)
            regKey.Close()
            regKey.Dispose()
        Else
            'If we are removing the older files, check if they exist, then delete them
            If RemoveOlderFiles Then
                paths = TryCast(regKey.GetValue(LanguageToUpdate), String())

                If paths(0) <> "" Then
                    If File.Exists(paths(0)) Then File.Delete(paths(0))

                    If File.Exists(paths(1)) Then File.Delete(paths(1))
                End If
            End If

            'Reset the registry
            ReDim paths(1)
            paths(0) = NewAffFileLocation
            paths(1) = NewDicFileLocation

            regKey.SetValue(LanguageToUpdate, paths, RegistryValueKind.MultiString)
            regKey.Close()
            regKey.Dispose()
        End If
    End Sub
#End Region




#Region "SpellCheckForm"

    Public Sub RunFullSpellChecker(ByRef callingTextBox As TextBoxBase)
        'first see if there is anything misspelled
        If Not CType(mySpellCheckers(callingTextBox), SpellCheckControl).HasSpellingErrors Then
            MessageBox.Show("No spelling errors were detected." & vbNewLine & _
                            vbNewLine & "Spell check is complete.")
            Return
        End If

        'If the textbox is a rich text box, we have to get the selection fonts
        Dim fontHashTable As New Hashtable
        Dim rtf As String = ""
        Dim zoomFactor As Double = 1

        If TypeOf callingTextBox Is RichTextBox Then
            rtf = CType(callingTextBox, RichTextBox).Rtf
            zoomFactor = CType(callingTextBox, RichTextBox).ZoomFactor
        End If

        'Create the new spell checking form
        Dim newSpellCheckForm As New SpellCheckForm(callingTextBox, _
                                                    CType(mySpellCheckers(callingTextBox),  _
                                                    SpellCheckControl), _
                                                    boolDisableAddWordPrompt)

        'Show the form
        newSpellCheckForm.ShowDialog()

        'We get here when the form is closed.
        'We're going to refresh the text in the textbox
        boolDisableAddWordPrompt = newSpellCheckForm.DisableConfirmationPrompt

        'First make sure that the ignore ranges are not reset
        CType(mySpellCheckers(callingTextBox), SpellCheckControl).DontResetIgnoreRanges()

        'Clear the text in the textbox and reset it
        callingTextBox.Clear()

        callingTextBox.Text = newSpellCheckForm.NewText

        If TypeOf callingTextBox Is RichTextBox Then
            With CType(callingTextBox, RichTextBox)
                .Rtf = newSpellCheckForm.GetRTF
                .ZoomFactor = 1
                .ZoomFactor = zoomFactor
            End With
        End If

        callingTextBox.SelectionStart = callingTextBox.TextLength

        CType(mySpellCheckers(callingTextBox), SpellCheckControl).DontResetIgnoreRanges(False)

        callingTextBox.Invalidate()

        'Reset all of the textboxes to refresh the spelling
        For i = 0 To UBound(myControls)
            If myControls(i).Name <> callingTextBox.Name Then
                If TypeOf myControls(i) Is TextBoxBase Then
                    With CType(myControls(i), TextBoxBase)
                        Dim controlText, controlRTF As String
                        controlText = .Text
                        controlRTF = ""

                        If TypeOf myControls(i) Is RichTextBox Then
                            controlRTF = CType(myControls(i), RichTextBox).Rtf
                        End If

                        Dim selectionStart, selectionLength As Integer
                        selectionLength = .SelectionLength
                        selectionStart = .SelectionStart

                        .ResetText()
                        .Text = controlText

                        If controlRTF <> "" Then
                            CType(myControls(i), RichTextBox).Rtf = controlRTF
                        End If

                        .SelectionStart = selectionStart
                        .SelectionLength = selectionLength
                    End With
                End If
            End If
        Next
    End Sub


#End Region



End Class



