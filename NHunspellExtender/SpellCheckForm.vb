Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Reflection

Public Class SpellCheckForm


#Region "Private variables"
    Private _originalRichTextBox As RichTextBox
    Private _originalTextBox As TextBox
    'Used as a temporary textbox for manipulating the RTF info without causing screen updates

    Private _callingTextBox As TextBoxBase
    'The textboxbase that called this form

    Private _spellChecker As SpellCheckControl
    'The spellCheckControl associated with the calling textboxbase

    Private sentenceBreaks(,) As Long
    'sentenceBreaks stores the original position of the sentence break
    'along with the new position of the sentence breaks
    'Example:          0123456789012345678901234567890123456789012
    '_OriginalText  = "Thie ist a test.  To shiw the way it werks.
    '_NewText       = "This is a test. To show the way it works."
    'sentenceBreaks = { 15 , 14 }
    '                 { 42 , 40 }

    Private currentSentence As Long
    'Used as an index representing which sentence we are currently in

    Private currentWordStart As Long
    'An index representing the starting position of the currently misspelled word in relation
    'to the full text

    Private DisableTextChanged As Boolean
    'Used to make sure that if we change the text programmatically, the buttons aren't changed

    Private currentWordRange As CharacterRange
    'An index of the currently misspelled word in relation to the current sentence

    Private currentSentenceStartIndex As Long
    'An index representing the starting point for the current sentence in relation to the full text

    Private _zoomFactor As Double
    'The ZoomFactor of the calling textboxbase if it's a RichTextBox

    Private _DisableConfirmationPrompt As Boolean
#End Region


#Region "New and Shown"

    Public Sub New(ByRef CallingControl As TextBoxBase, ByVal SpellChecker As SpellCheckControl, _
                   ByVal DisableConfirmationPrompt As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        _zoomFactor = 1

        'Set up the form
        If TypeOf CallingControl Is RichTextBox Then
            _originalRichTextBox = New RichTextBox
            _originalTextBox = Nothing

            _originalRichTextBox.Rtf = CType(CallingControl, RichTextBox).Rtf
            _zoomFactor = 1
            _zoomFactor = CType(CallingControl, RichTextBox).ZoomFactor
        Else
            _originalRichTextBox = Nothing
            _originalTextBox = New TextBox

            _originalTextBox.Text = CallingControl.Text
        End If

        _DisableConfirmationPrompt = DisableConfirmationPrompt

        _callingTextBox = CallingControl

        _spellChecker = SpellChecker

        lboSuggestions.Items.Clear()

        'Make sure that we're starting the spell checking fresh
        _spellChecker.ClearIgnoreRanges()

        SetSentenceBreaks()
        currentWordStart = -1
        DisableTextChanged = False

        SetNextWord()
    End Sub

    Private Sub SpellCheckForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _originalTextBox IsNot Nothing Then
            If _originalTextBox.Text = "" Or Not _spellChecker.HasSpellingErrors Then Me.Hide()
        Else
            If _originalRichTextBox.Text = "" Or Not _spellChecker.HasSpellingErrors Then Me.Hide()
        End If
    End Sub

#End Region


#Region "Add Word to Dictionary"

    ''' <summary>
    ''' Given a misspelled word, this will add the word to the dictionary as a correctly spelled word.
    ''' This added word will be perpetuated on future program starts
    ''' </summary>
    ''' <param name="sender">The System.Windows.Forms.Button that was clicked</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If Not _DisableConfirmationPrompt Then
            Dim dlgResult As DialogResult
            dlgResult = MyDialog.Show("This will add the word to the dictionary." & vbNewLine & "Continue?", _
                                        "Add Word to Dictionary")

            'Check if we're to disable future prompts
            If dlgResult = (DialogResult.Ignore + DialogResult.No) Then
                _DisableConfirmationPrompt = True
                Return
            ElseIf dlgResult = (DialogResult.Yes + DialogResult.Ignore) Then
                _DisableConfirmationPrompt = True
            ElseIf dlgResult = DialogResult.No Then
                Return
            End If
        End If
        
        'Get the word to add
        Dim currentWord As String = Mid(txtCurrentSentence.Text, currentWordRange.First + 1, currentWordRange.Length)

        'Add it to the spell checker in memory
        _spellChecker.myNHunspell.Add(currentWord)

        'Add it to the added words file on disk
        Dim callingDir As String = Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location)

        'Try and write to the directory to see if we can
        Dim boolFailed As Boolean = False

        Try
            Directory.CreateDirectory(callingDir & "\Test")
        Catch ex As Exception
            boolFailed = True
        Finally
            If Directory.Exists(callingDir & "\Test") Then Directory.Delete(callingDir & "\Test")
        End Try

        If boolFailed Then
            callingDir = "C:\Windows\Temp"
        End If

        If Not Directory.Exists(callingDir & "\SpellCheck") Then
            Directory.CreateDirectory(callingDir & "\SpellCheck")
        End If

        Dim regKey As Microsoft.Win32.RegistryKey = _
            Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\NHunspellTextBoxExtender\Languages")

        Dim language As String = regKey.GetValue("Default")

        regKey.Close()
        regKey.Dispose()

        Using w As New StreamWriter(callingDir & "\SpellCheck\" & language & "AddedWords.dat", True)
            w.WriteLine(currentWord)
            w.Flush()
            w.Close()
        End Using

        'Reset the callingTextBox
        'Make sure that the ignore ranges aren't reset (we can do this because we always start at the beginning
        'and move forwards so any previously set ignore ranges should still be ignored)
        _spellChecker.DontResetIgnoreRanges()

        'Clear the original text and overwrite it (just to refresh the spell checking)
        _callingTextBox.Clear()

        'If it's a RichTextBox, we also have to reset the RTF and ZoomFactor
        If TypeOf _callingTextBox Is RichTextBox Then
            CType(_callingTextBox, RichTextBox).Rtf = _originalRichTextBox.Rtf
            CType(_callingTextBox, RichTextBox).ZoomFactor = 1
            CType(_callingTextBox, RichTextBox).ZoomFactor = _zoomFactor
        Else
            _callingTextBox.Text = _originalTextBox.Text
        End If

        _spellChecker.DontResetIgnoreRanges(False)

        'Go to the next misspelled word
        If Not SetNextWord() Then
            Me.Hide()
        End If
    End Sub

#End Region


#Region "Ignore"

    ''' <summary>
    ''' This will ignore the currently selected word one time.  This only lasts as long as the text is not
    ''' changed by the user.
    ''' Also serves as the Undo Edit button if the user types in the textbox
    ''' </summary>
    ''' <param name="sender">System.Windows.Forms.Button</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdIgnoreOnce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIgnoreOnce.Click
        'Check if we've retitled the button
        If cmdIgnoreOnce.Text = "Undo Edit" Then
            'We're going to reset the text to its original state before any user manipulation
            DisableTextChanged = True

            'We're just going to change the currentWordStart to a couple before (subtracting one would work as
            'well, but why not use 2?) and then just tell it to set the next word
            currentWordStart -= 2
            SetNextWord()

            DisableTextChanged = False
        Else
            'We get here if we're ignoring the misspelled word once.
            'We do this by adding an ignore range to the control's spellcheckcontrol

            'Get the range of the word in the newtext
            Dim rangeStart As Long

            If UBound(sentenceBreaks, 2) = 0 Then
                rangeStart = currentWordRange.First
            Else
                rangeStart = currentSentenceStartIndex + currentWordRange.First
            End If

            'Add the range to ignore
            _spellChecker.AddRangeToIgnore(New CharacterRange(rangeStart, currentWordRange.Length))

            'Reset the calling textbox
            _spellChecker.DontResetIgnoreRanges()

            'Clear the original text and overwrite it (just to refresh the spell checking)
            _callingTextBox.Clear()

            'If it's a RichTextBox, we also have to reset the RTF and ZoomFactor
            If TypeOf _callingTextBox Is RichTextBox Then
                CType(_callingTextBox, RichTextBox).Rtf = _originalRichTextBox.Rtf
                CType(_callingTextBox, RichTextBox).ZoomFactor = 1
                CType(_callingTextBox, RichTextBox).ZoomFactor = _zoomFactor
            Else
                _callingTextBox.Text = _originalTextBox.Text
            End If

            _spellChecker.DontResetIgnoreRanges(False)

            'Go to the next misspelled word
            If Not SetNextWord() Then
                'we have gone through all of the spelling errors
                Me.Hide()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This will ignore all future instances of the word for the remainder of the time the calling form is open.
    ''' This is done by adding the word to the spellchecker dictionary in memory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdIgnoreAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIgnoreAll.Click
        'Make sure they want to do this because it can't be undone until this session finishes
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("This will ignore all instances of the word." & vbNewLine & "Continue?", _
                                    "Ignore All", MessageBoxButtons.YesNo)

        If dlgResult = Windows.Forms.DialogResult.Yes Then
            'get the current word then add it to the dictionary in memory

            Dim currentWord As String = Mid(txtCurrentSentence.Text, currentWordRange.First + 1, currentWordRange.Length)
            _spellChecker.myNHunspell.Add(currentWord)

            'Reset the calling textbox
            _spellChecker.DontResetIgnoreRanges()

            'Clear the original text and overwrite it (just to refresh the spell checking)
            _callingTextBox.Clear()

            'If it's a RichTextBox, we also have to reset the RTF and ZoomFactor
            If TypeOf _callingTextBox Is RichTextBox Then
                CType(_callingTextBox, RichTextBox).Rtf = _originalRichTextBox.Rtf
                CType(_callingTextBox, RichTextBox).ZoomFactor = 1
                CType(_callingTextBox, RichTextBox).ZoomFactor = _zoomFactor
            Else
                _callingTextBox.Text = _originalTextBox.Text
            End If

            _spellChecker.DontResetIgnoreRanges(False)

            'Go to the next word
            If Not SetNextWord() Then
                'we have gone through all of the spelling errors
                Me.Hide()
            End If
        End If
    End Sub

#End Region


#Region "Change Word"

    ''' <summary>
    ''' This will change one instance of the word.  It will either use the word selected from the listbox
    ''' or what the user types.  The user can change the whole sentence through this function.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        'If the listbox is enabled, then we're changing the word to the selected word from the list box
        'Otherwise, it's what was typed in the text box.

        'First, see if the new word is spelled correctly.  Otherwise, ask them if that's what they want to do
        'If it is, add any of the _NewText that occurred before this sentence, then add the sentence in the box
        'then add any sentences after this one.
        Dim textBoxToUse As TextBoxBase

        If _originalRichTextBox IsNot Nothing Then
            textBoxToUse = _originalRichTextBox
        Else
            textBoxToUse = _originalTextBox
        End If

        Dim originalSentenceLength = sentenceBreaks(1, currentSentence) - currentSentenceStartIndex + 1
        Dim newSentenceLength = txtCurrentSentence.TextLength

        If lboSuggestions.Enabled Then
            Dim rightAmount As Integer

            Dim currentWord As String = Mid(txtCurrentSentence.Text, currentWordRange.First + 1, currentWordRange.Length)

            Dim newSentence As String
            newSentence = Microsoft.VisualBasic.Strings.Left(txtCurrentSentence.Text, currentWordRange.First) & _
                          lboSuggestions.SelectedItem.ToString
            rightAmount = txtCurrentSentence.TextLength - currentWordRange.First - currentWordRange.Length
            newSentence = newSentence & Microsoft.VisualBasic.Strings.Right(txtCurrentSentence.Text, rightAmount)
            txtCurrentSentence.Text = newSentence

            'Get the new word
            Dim newWord As String

            newWord = lboSuggestions.SelectedItem.ToString

            'Now change the original textbox
            'We're going to select the original word and then update the Selected Text.  This will preserve the
            'Selected RTF

            With textBoxToUse
                .SelectionStart = currentWordStart
                .SelectionLength = currentWordRange.Length
                .SelectedText = newWord
            End With

            currentWordStart += (newSentenceLength - originalSentenceLength)
        Else
            'We're just going to assume that the whole sentence needs to be changed if the user didn't
            'select a word from the suggestions box. It's more of a headache to try to find out if the
            'user has changed more than the original word than it is to just change the whole sentence

            With textBoxToUse
                .SelectionStart = currentSentenceStartIndex
                .SelectionLength = originalSentenceLength
                .SelectedText = txtCurrentSentence.Text
            End With

            currentWordStart = currentSentenceStartIndex
        End If

        'We need to update the sentence breaks and currentWordStart
        'Update sentenceBreaks
        For i = currentSentence To UBound(sentenceBreaks, 2)
            sentenceBreaks(1, i) = sentenceBreaks(1, i) + (newSentenceLength - originalSentenceLength)
        Next


        'Reset the calling textbox
        _spellChecker.DontResetIgnoreRanges()

        'Clear the original text and overwrite it (just to refresh the spell checking)
        _callingTextBox.Clear()

        'If it's a RichTextBox, we also have to reset the RTF and ZoomFactor
        If TypeOf _callingTextBox Is RichTextBox Then
            CType(_callingTextBox, RichTextBox).Rtf = _originalRichTextBox.Rtf
            CType(_callingTextBox, RichTextBox).ZoomFactor = 1
            CType(_callingTextBox, RichTextBox).ZoomFactor = _zoomFactor
        Else
            _callingTextBox.Text = _originalTextBox.Text
        End If

        _spellChecker.DontResetIgnoreRanges(False)

        If Not SetNextWord() Then
            Me.Hide()
        End If
    End Sub

    ''' <summary>
    ''' This will change all instances of the misspelled word.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdChangeAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeAll.Click
        'get the original word and the new word.  then go through all of the remaining misspelled words and see
        'if the original word occurs again.  Replace them as you go and update the _originalTextBox
        'along with the sentence breaks

        Dim textBoxToUse As TextBoxBase

        If _originalRichTextBox IsNot Nothing Then
            textBoxToUse = _originalRichTextBox
        Else
            textBoxToUse = _originalTextBox
        End If

        Dim originalWord As String = Mid(textBoxToUse.Text, currentSentenceStartIndex + currentWordRange.First + 1, _
                                         currentWordRange.Length)
        Dim newWord As String
        Dim originalSentenceLength = sentenceBreaks(1, currentSentence) - currentSentenceStartIndex + 1
        Dim newSentenceLength = txtCurrentSentence.TextLength

        If lboSuggestions.Enabled Then
            newWord = lboSuggestions.SelectedItem.ToString
        Else
            newWord = Mid(txtCurrentSentence.Text, currentWordRange.First + 1, _
                          currentWordRange.Length + (newSentenceLength - originalSentenceLength))
        End If

        'Spell check the new word
        If Not _spellChecker.myNHunspell.Spell(newWord) Then
            Dim dlgResult As DialogResult
            dlgResult = MessageBox.Show(newWord & " is not recognized as a correctly spelled word." & _
                                        vbNewLine & "Would you like to continue with the replacement?", _
                                        "Misspelled Word", MessageBoxButtons.YesNo)
            If dlgResult = Windows.Forms.DialogResult.No Then
                Return
            End If
        End If

        'Now go through each character range starting with the current range and see if it matches
        '(We don't want to change any previously looked at words)
        Dim currentRange As CharacterRange
        Dim offsetOfFirstChar As Integer = 0

        For Each currentRange In _spellChecker.GetSpellingErrorRanges
            If currentRange.First >= currentWordRange.First + offsetOfFirstChar + currentSentenceStartIndex Then
                'Check if the current word matches
                If Mid(textBoxToUse.Text, _
                       currentRange.First + 1 + offsetOfFirstChar, _
                       currentRange.Length) = originalWord Then

                    'Figure out where we are in relation to _NewText
                    'To do that, find the sentence break of this sentence and find the offset from the original
                    Dim offset As Integer = 0
                    Dim sentenceIndex As Integer = 0

                    For i = 0 To UBound(sentenceBreaks, 2)
                        If sentenceBreaks(1, i) > currentRange.First Then
                            sentenceIndex = i
                            Exit For
                        End If
                    Next

                    'Update the _originalTextBox
                    With textBoxToUse
                        .SelectionStart = currentRange.First + offsetOfFirstChar
                        .SelectionLength = currentRange.Length
                        .SelectedText = newWord
                    End With

                    'Update sentence breaks
                    offset = newWord.Length - originalWord.Length
                    offsetOfFirstChar += (newWord.Length - originalWord.Length)
                    For i = sentenceIndex To UBound(sentenceBreaks, 2)
                        sentenceBreaks(1, i) = sentenceBreaks(1, i) + offset
                    Next
                End If
            End If
        Next

        'Reset the calling textbox
        _spellChecker.DontResetIgnoreRanges()

        'Clear the original text and overwrite it (just to refresh the spell checking)
        _callingTextBox.Clear()

        'If it's a RichTextBox, we also have to reset the RTF and ZoomFactor
        If TypeOf _callingTextBox Is RichTextBox Then
            CType(_callingTextBox, RichTextBox).Rtf = _originalRichTextBox.Rtf
            CType(_callingTextBox, RichTextBox).ZoomFactor = 1
            CType(_callingTextBox, RichTextBox).ZoomFactor = _zoomFactor
        Else
            _callingTextBox.Text = _originalTextBox.Text
        End If

        _spellChecker.DontResetIgnoreRanges(False)

        'Update the sentence breaks
        For i = 0 To UBound(sentenceBreaks, 2)
            sentenceBreaks(0, i) = sentenceBreaks(1, i)
        Next

        'Go to the next word
        If Not SetNextWord() Then
            Me.Hide()
        End If
    End Sub

#End Region


#Region "Cancel"

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Hide()
    End Sub

#End Region


#Region "Events"

    ''' <summary>
    ''' Handles if the user types in the textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles txtCurrentSentence.TextChanged
        Dim textBoxToUse As TextBoxBase

        If _originalRichTextBox IsNot Nothing Then
            textBoxToUse = _originalRichTextBox
        Else
            textBoxToUse = _originalTextBox
        End If

        'Check if we were the one that changed the text and not the user
        If Not DisableTextChanged Then
            'see if something other than the current word was changed
            'This doesn't work the way it should...

            If Microsoft.VisualBasic.Strings.Left(textBoxToUse.Text, currentWordRange.First) <> _
               Microsoft.VisualBasic.Strings.Left(txtCurrentSentence.Text, currentWordRange.First) Then
                'Changed something besides the selected word
                cmdChangeAll.Enabled = False
            Else
                Dim rightAmount As Integer = textBoxToUse.TextLength - currentWordRange.First - currentWordRange.Length
                If Microsoft.VisualBasic.Strings.Right(textBoxToUse.Text, rightAmount) <> _
                   Microsoft.VisualBasic.Strings.Right(txtCurrentSentence.Text, rightAmount) Then
                    cmdChangeAll.Enabled = False
                End If
            End If

            'Change the buttons and listbox
            lboSuggestions.Enabled = False
            cmdIgnoreAll.Enabled = False
            cmdAdd.Enabled = False
            cmdIgnoreOnce.Text = "Undo Edit"

            'Change the word to the original formatting
            Dim selectionStart As Integer = txtCurrentSentence.SelectionStart
            txtCurrentSentence.SelectionStart = 0
            txtCurrentSentence.SelectionLength = txtCurrentSentence.TextLength
            txtCurrentSentence.SelectionColor = Color.Black
            txtCurrentSentence.SelectionFont = New Font(txtCurrentSentence.Font, FontStyle.Regular)
            txtCurrentSentence.SelectionStart = selectionStart
            txtCurrentSentence.SelectionLength = 0
        End If
    End Sub

#End Region


#Region "Other Subs and Functions"
    Public ReadOnly Property DisableConfirmationPrompt As Boolean
        Get
            Return _DisableConfirmationPrompt
        End Get
    End Property


    ''' <summary>
    ''' Returns the new text for the control
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NewText() As String
        If _originalRichTextBox IsNot Nothing Then
            Return _originalRichTextBox.Text
        Else
            Return _originalTextBox.Text
        End If
    End Function

    ''' <summary>
    ''' Goes through the text and finds any sentence breaks.  We only care about '.', '!' and '?"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetSentenceBreaks()
        ReDim sentenceBreaks(1, -1)

        Dim textBoxToUse As TextBoxBase

        If _originalRichTextBox IsNot Nothing Then
            textBoxToUse = _originalRichTextBox
        Else
            textBoxToUse = _originalTextBox
        End If

        'Search through the text and find any sentence breaks
        '(the last char is always a sentence break, so we don't
        'need to include it now
        For i = 0 To textBoxToUse.TextLength - 2
            If IsSentenceEnding(textBoxToUse.Text(i)) Then
                ReDim Preserve sentenceBreaks(1, UBound(sentenceBreaks, 2) + 1)
                sentenceBreaks(0, UBound(sentenceBreaks, 2)) = i
                sentenceBreaks(1, UBound(sentenceBreaks, 2)) = i
            End If
        Next

        'now add the last char as its own break
        ReDim Preserve sentenceBreaks(1, UBound(sentenceBreaks, 2) + 1)
        sentenceBreaks(0, UBound(sentenceBreaks, 2)) = textBoxToUse.TextLength - 1
        sentenceBreaks(1, UBound(sentenceBreaks, 2)) = textBoxToUse.TextLength - 1
    End Sub

    ''' <summary>
    ''' See if the current character is a '.', '?' or '!'
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsSentenceEnding(ByVal Input As Char)
        If Input = "." Or Input = "?" Or Input = "!" Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Refresh the textbox to show the next misspelled word
    ''' </summary>
    ''' <returns>A Boolean value indicating if there was another misspelled word.</returns>
    ''' <remarks></remarks>
    Public Function SetNextWord() As Boolean
        Dim textBoxToUse As TextBoxBase

        If _originalRichTextBox IsNot Nothing Then
            textBoxToUse = _originalRichTextBox
        Else
            textBoxToUse = _originalTextBox
        End If

        'Get the character ranges and then check if there is a misspelled word after the current word
        Dim ranges() As CharacterRange = _spellChecker.GetSpellingErrorRanges
        DisableTextChanged = True

        Dim currentRange As CharacterRange

        'Reset buttons
        cmdIgnoreAll.Enabled = True
        cmdIgnoreOnce.Text = "Ignore Once"
        cmdAdd.Enabled = True
        lboSuggestions.Enabled = True
        cmdChangeAll.Enabled = True

        'Go through all of the misspelled words and find the next one
        For Each currentRange In ranges
            If currentRange.First > currentWordStart Then
                'We found the next word to look at.  Now load its sentence into the text box
                'and then highlight the selected word

                currentWordStart = currentRange.First

                'Find the sentence break after the currentWordStart and then put that sentence
                'into the textbox
                For i = 0 To UBound(sentenceBreaks, 2)
                    If i = 0 Then
                        If sentenceBreaks(1, i) > currentWordStart Then
                            currentSentenceStartIndex = 0

                            'Set the textbox text
                            txtCurrentSentence.Text = Microsoft.VisualBasic.Strings.Left(textBoxToUse.Text, _
                                                                                         sentenceBreaks(0, i) + 1)

                            'Now find word to highlight
                            'Un-highlight everything first
                            txtCurrentSentence.SelectionStart = 0
                            txtCurrentSentence.SelectionLength = txtCurrentSentence.TextLength
                            txtCurrentSentence.SelectionColor = Color.Black
                            txtCurrentSentence.SelectionFont = New Font(txtCurrentSentence.Font, FontStyle.Regular)

                            'if the calling textbox was a richtextbox, then set the original formatting
                            If TypeOf _callingTextBox Is RichTextBox Then
                                _originalRichTextBox.SelectionStart = currentSentenceStartIndex
                                _originalRichTextBox.SelectionLength = txtCurrentSentence.TextLength

                                txtCurrentSentence.Rtf = _originalRichTextBox.SelectedRtf
                            End If

                            'Now highlight the new word and set the caret to the end of the word
                            txtCurrentSentence.SelectionStart = currentRange.First
                            txtCurrentSentence.SelectionLength = currentRange.Length
                            txtCurrentSentence.SelectionColor = Color.Red
                            txtCurrentSentence.SelectionFont = New Font(txtCurrentSentence.Font, FontStyle.Bold)
                            txtCurrentSentence.SelectionLength = 0
                            txtCurrentSentence.SelectionStart = currentRange.First + currentRange.Length + 1

                            txtCurrentSentence.ZoomFactor = 1
                            txtCurrentSentence.ZoomFactor = _zoomFactor

                            'Now set up the suggestions box
                            Dim st As String
                            lboSuggestions.Items.Clear()

                            For Each st In _spellChecker.GetSuggestions(Mid(textBoxToUse.Text, _
                                                                            currentRange.First + 1, _
                                                                            currentRange.Length), 10)
                                lboSuggestions.Items.Add(st)
                            Next

                            If lboSuggestions.Items.Count > 0 Then
                                lboSuggestions.SelectedIndex = 0
                            Else
                                lboSuggestions.Items.Add("No suggestions found.")
                                lboSuggestions.Enabled = False
                            End If


                            currentWordRange = New CharacterRange(currentRange.First, currentRange.Length)
                            'originalTextBoxText = txtCurrentSentence.Text
                            DisableTextChanged = False
                            Return True
                        End If
                    Else
                        If (sentenceBreaks(1, i) > currentWordStart) And _
                           (sentenceBreaks(1, i - 1) < currentWordStart) Then
                            Dim startingPoint, sentenceLength As Long
                            startingPoint = sentenceBreaks(1, i - 1) + 1
                            'We add one to take us to the character directly after the previous sentence

                            'Now find the next letter or digit
                            For j = startingPoint To textBoxToUse.TextLength
                                If Char.IsLetterOrDigit(textBoxToUse.Text(j)) Then
                                    startingPoint = j
                                    Exit For
                                End If
                            Next

                            currentSentenceStartIndex = startingPoint
                            sentenceLength = sentenceBreaks(1, i) - startingPoint + 1

                            'Now we add one to make it 1-based for the Mid function
                            startingPoint += 1

                            'Set the text of the textbox
                            txtCurrentSentence.Text = Mid(textBoxToUse.Text, startingPoint, sentenceLength)
                            currentSentence = i

                            'Now we need to highlight the correct word
                            Dim wordStartInSent As Integer
                            wordStartInSent = currentRange.First - (startingPoint - 1) 'set starting point to 0-based

                            'Un-highlight everything first
                            txtCurrentSentence.SelectionStart = 0
                            txtCurrentSentence.SelectionLength = txtCurrentSentence.TextLength
                            txtCurrentSentence.SelectionColor = Color.Black
                            txtCurrentSentence.SelectionFont = New Font(txtCurrentSentence.Font, FontStyle.Regular)

                            'if the calling textbox was a richtextbox, then set the original formatting
                            If TypeOf _callingTextBox Is RichTextBox Then
                                _originalRichTextBox.SelectionStart = currentSentenceStartIndex
                                _originalRichTextBox.SelectionLength = txtCurrentSentence.TextLength

                                txtCurrentSentence.Rtf = _originalRichTextBox.SelectedRtf
                            End If

                            'Now highlight the new word
                            txtCurrentSentence.SelectionStart = wordStartInSent
                            txtCurrentSentence.SelectionLength = currentRange.Length
                            txtCurrentSentence.SelectionColor = Color.Red
                            txtCurrentSentence.SelectionFont = New Font(txtCurrentSentence.Font, FontStyle.Bold)
                            txtCurrentSentence.SelectionLength = 0
                            txtCurrentSentence.SelectionStart = currentRange.First + currentRange.Length + 1

                            txtCurrentSentence.ZoomFactor = 1
                            txtCurrentSentence.ZoomFactor = _zoomFactor

                            'Now set up the suggestions box
                            Dim st As String
                            lboSuggestions.Items.Clear()

                            For Each st In _spellChecker.GetSuggestions(Mid(textBoxToUse.Text, _
                                                                            currentRange.First + 1, _
                                                                            currentRange.Length), 10)
                                lboSuggestions.Items.Add(st)
                            Next

                            If lboSuggestions.Items.Count > 0 Then
                                lboSuggestions.SelectedIndex = 0
                            Else
                                lboSuggestions.Items.Add("No suggestions found")
                                lboSuggestions.Enabled = False
                            End If

                            currentWordRange = New CharacterRange(wordStartInSent, currentRange.Length)
                            DisableTextChanged = False
                            Return True
                        End If
                    End If
                Next
            End If
        Next

        'If we get here, then there are no more misspelled words
        Return False
    End Function

    ''' <summary>
    ''' Returns the Rich Text Formatted text for RichTextBox controls.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetRTF() As String
        If _originalRichTextBox IsNot Nothing Then
            Return _originalRichTextBox.Rtf
        Else
            Return ""
        End If
    End Function

#End Region

End Class