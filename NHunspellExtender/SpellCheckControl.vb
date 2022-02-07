Imports System.Drawing
Imports NHunspell

    ''' <summary>
    ''' This class holds the text in the textbox, along with which words are spelling errors.
    ''' This class will also return the requested number of suggestions for misspelled words.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SpellCheckControl


#Region "Variables"
    Private FullText As String
    Private _Text(,) As String
    Public myNHunspell As Hunspell = Nothing

    Private _spellingErrors() As String
    Private _spellingErrorRanges() As CharacterRange
    Private _setTextCalledFirst As Boolean
    Private _ignoreRange() As CharacterRange
    Private _dontResetIgnoreRanges As Boolean
#End Region


#Region "New"
    Public Sub New(ByRef NHunspellObject As Hunspell)
        ReDim _Text(1, -1)
        ReDim _spellingErrors(-1)
        FullText = ""
        myNHunspell = NHunspellObject
        _setTextCalledFirst = False
        ReDim _ignoreRange(-1)
        _dontResetIgnoreRanges = False
    End Sub
#End Region


#Region "Adding or Removing Text"
    ''' <summary>
    ''' Adds a character directly after the selection start and checks the new word
    ''' for spelling errors
    ''' </summary>
    ''' <param name="Input">The character to be added</param>
    ''' <param name="SelectionStart">The position to add the character after</param>
    ''' <remarks></remarks>
    Public Sub AddText(ByVal Input As String, ByVal SelectionStart As Long)
        'Sometimes, the setText gets called first.
        If _setTextCalledFirst Then
            _setTextCalledFirst = False
            Return
        End If

        'If we are allowed to reset the ignore ranges, reset them
        If Not _dontResetIgnoreRanges Then
            ReDim _ignoreRange(-1)
        End If

        'Check if the input is a letter or digit and if not, see if it is splitting up
        'a previous word.  If not, we don't need to do anything further
        If Not Char.IsLetterOrDigit(Input) Then
            'We're going to see if it's being added at the beginning or at the end.
            'If it is, then we don't need to do anything about it.
            'Then we're going to see if the character preceding it or following after
            'it is a non letter or digit.  If it is, then we don't need to go any further

            If SelectionStart = 0 Then GoTo SaveFullText
            If SelectionStart >= FullText.Length Then GoTo SaveFullText
            If Not Char.IsLetterOrDigit(FullText(SelectionStart - 1)) Or _
                Not Char.IsLetterOrDigit(FullText(SelectionStart)) Then GoTo SaveFullText
        End If



        'Now we need to figure out what the original word was and what the new word will be
        Dim originalWord As String
        Dim newWord As String
        Dim endOfWord As Integer
        Dim beginning As Integer
        Dim resetSpellingRanges As Boolean = False



        'Start with the case that we're at the beginning of the text
        If SelectionStart = 0 Then
            'Now make sure there is a letter or digit currently at the beginning of the original text
            If Not Char.IsLetterOrDigit(Left(FullText, 1)) Then
                originalWord = ""
                newWord = Input
            Else
                'Find the end of the word that begins the FullText
                endOfWord = FindLastLetterOrDigitFromPosition(SelectionStart)
                originalWord = Left(FullText, (endOfWord - SelectionStart + 1))
                newWord = Input & originalWord
            End If



        ElseIf SelectionStart = FullText.Length Then
            'Now check if we're at the end
            'Make sure there is a letter or digit at the end of the original text
            If Not Char.IsLetterOrDigit(Right(FullText, 1)) Then
                originalWord = ""
                newWord = Input
            Else
                beginning = FindFirstLetterOrDigitFromPosition(SelectionStart)
                originalWord = Right(FullText, (SelectionStart - beginning))
                newWord = originalWord & Input
            End If



        Else 'We're somewhere in the middle of the text
            beginning = FindFirstLetterOrDigitFromPosition(SelectionStart)
            endOfWord = FindLastLetterOrDigitFromPosition(SelectionStart)

            'Example: "This" inserting after 'h'
            'SelectionStart = 2
            'beginning = 0
            'endOfWord = 3
            originalWord = Mid(FullText, beginning + 1, (endOfWord - beginning + 1))

            'Check if the original word is actually a word
            'If there are not non letters or digits (like two spaces in a row)
            'and someone is putting a letter or digit between them, original word will be
            'one of the non letters or digits
            If originalWord.Length = 1 Then
                If Not Char.IsLetterOrDigit(originalWord(0)) Then
                    originalWord = ""
                End If
            End If

            If originalWord = "" Then
                newWord = Input
            Else
                newWord = Mid(FullText, beginning + 1, (SelectionStart - beginning)) & _
                          Input & _
                          Mid(FullText, SelectionStart + 1, (endOfWord - SelectionStart + 1))
            End If

        End If

        'Check if the original word was added already (original word could be a space which would not
        'have been added)
        If UBound(_Text, 2) > -1 Then


            If originalWord.Length > 0 Then


                For i = 0 To UBound(_Text, 2)


                    If _Text(0, i) = originalWord Then
                        'Yay, we found it!

                        'Check if the original word is being split up
                        'into two words.  If we get here, and the char is not a digit
                        'or letter, then it is because we've already checked a non-letter
                        'or digit being added at the beginning or end of a word
                        If Not Char.IsLetterOrDigit(Input) Then


                            'we have two words now
                            Dim word1, word2 As String
                            word1 = Left(newWord, (SelectionStart - beginning))
                            word2 = Right(newWord, (endOfWord - SelectionStart + 1))

                            'Replace the original word with the first new word
                            'Check if the original word is in the sentence more than once
                            If _Text(1, i) > 1 Then


                                'If it is, then we're subtracting one instance of the original
                                'word and adding a newword
                                _Text(1, i) = _Text(1, i) - 1

                                'See if word1 was has already been added
                                Dim foundWord1 As Boolean = False

                                For j = 0 To UBound(_Text, 2)
                                    If _Text(0, j) = word1 Then
                                        foundWord1 = True
                                        _Text(1, j) = _Text(1, j) + 1
                                        Exit For
                                    End If
                                Next

                                If Not foundWord1 Then
                                    ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                                    _Text(0, UBound(_Text, 2)) = word1
                                    _Text(1, UBound(_Text, 2)) = 1
                                End If


                            Else
                                'If the original is only in once, we can either replace it, or remove it
                                'First wee need to see if word1 is in already
                                'See if word1 was has already been added
                                Dim foundWord1 As Boolean = False

                                For j = 0 To UBound(_Text, 2)
                                    If _Text(0, j) = word1 Then
                                        foundWord1 = True
                                        _Text(1, j) = _Text(1, j) + 1
                                        Exit For
                                    End If
                                Next

                                If Not foundWord1 Then
                                    'If we didn't find it already in the array, just replace the
                                    'original with the new word
                                    _Text(0, i) = word1
                                Else 'We did find word1 in the array, so remove the original from it
                                    For j = i + 1 To UBound(_Text, 2)
                                        _Text(0, j - 1) = _Text(0, j)
                                        _Text(1, j - 1) = _Text(1, j)
                                    Next

                                    ReDim Preserve _Text(1, UBound(_Text, 2) - 1)
                                End If

                                'See if the original word was a spelling error and remove it
                                For j = 0 To UBound(_spellingErrors)
                                    If _spellingErrors(j) = originalWord Then
                                        If UBound(_spellingErrors) > 0 Then
                                            'If there is more than one entry in _spellingErrors
                                            'then move the entries above this one down one
                                            For k = (j + 1) To UBound(_spellingErrors)
                                                _spellingErrors(k - 1) = _spellingErrors(k)
                                            Next
                                        End If
                                        ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)

                                        resetSpellingRanges = True
                                        Exit For
                                    End If
                                Next
                            End If

                            'see if word2 has already been added
                            Dim foundWord2 As Boolean = False
                            For j = 0 To UBound(_Text, 2)
                                If _Text(0, j) = word2 Then
                                    foundWord2 = True
                                    _Text(1, j) = _Text(1, j) + 1
                                    Exit For
                                End If
                            Next

                            If Not foundWord2 Then
                                ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                                _Text(0, UBound(_Text, 2)) = word2
                                _Text(1, UBound(_Text, 2)) = 1
                            End If

                            'Spell check both words
                            Dim foundSpellingWord1 As Boolean = False
                            For j = 0 To UBound(_spellingErrors)
                                If _spellingErrors(j) = word1 Then
                                    foundSpellingWord1 = True
                                    Exit For
                                End If
                            Next

                            If Not myNHunspell.Spell(word1) And Not foundSpellingWord1 Then
                                ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                                _spellingErrors(UBound(_spellingErrors)) = word1
                                resetSpellingRanges = True
                            ElseIf Not myNHunspell.Spell(word1) Then
                                resetSpellingRanges = True
                            End If

                            Dim foundSpellingWord2 As Boolean = False
                            For j = 0 To UBound(_spellingErrors)
                                If _spellingErrors(j) = word2 Then
                                    foundSpellingWord2 = True
                                    Exit For
                                End If
                            Next

                            If Not myNHunspell.Spell(word2) And Not foundSpellingWord2 Then
                                ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                                _spellingErrors(UBound(_spellingErrors)) = word2
                                resetSpellingRanges = True
                            ElseIf Not myNHunspell.Spell(word2) Then
                                resetSpellingRanges = True
                            End If

                            'We've handled everything, we can GoTo SaveFullText
                            GoTo SaveFullText
                        End If



                        'We get here if the original word is not being split into two
                        'so just replace the original word in the array with the new one
                        If _Text(1, i) > 1 Then
                            'If the original word is in the text more than once, subtract one
                            'instance of it
                            _Text(1, i) = _Text(1, i) - 1

                            'See if the new word is in the array already
                            Dim foundNewWord As Boolean = False

                            For j = 0 To UBound(_Text, 2)
                                If _Text(0, j) = newWord Then
                                    _Text(1, j) = _Text(1, j) + 1
                                    foundNewWord = True
                                End If
                            Next

                            If Not foundNewWord Then
                                'Add a new word to the array
                                ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                                _Text(0, UBound(_Text, 2)) = newWord
                                _Text(1, UBound(_Text, 2)) = 1

                                'Spell check it
                                Dim foundSpellNewWord As Boolean = False
                                For j = 0 To UBound(_spellingErrors)
                                    If _spellingErrors(j) = newWord Then
                                        foundSpellNewWord = True
                                        Exit For
                                    End If
                                Next

                                'Check if the new word is a spelling error
                                If Not myNHunspell.Spell(newWord) And Not foundSpellNewWord Then
                                    ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                                    _spellingErrors(UBound(_spellingErrors)) = newWord
                                    resetSpellingRanges = True
                                ElseIf Not myNHunspell.Spell(newWord) Then
                                    resetSpellingRanges = True
                                End If
                            End If

                            'We've handled everything, we can GoTo SaveFullText
                            GoTo SaveFullText


                        Else
                            'We get here if the original word is only in the text once and it's not
                            'being split into two words

                            'Check if the new word is already added
                            Dim foundNewWord As Boolean = False

                            For j = 0 To UBound(_Text, 2)
                                If _Text(0, j) = newWord Then
                                    _Text(1, j) = _Text(1, j) + 1
                                    foundNewWord = True
                                    Exit For
                                End If
                            Next

                            If Not foundNewWord Then
                                'If the new word is not in the array, then we can just replace
                                'the original word with it
                                _Text(0, i) = newWord

                                'Spell check the new word (just a double check)
                                Dim foundNewWordinSpell As Boolean = False

                                For j = 0 To UBound(_spellingErrors)
                                    If _spellingErrors(j) = newWord Then
                                        foundNewWordinSpell = True
                                        Exit For
                                    End If
                                Next

                                'Check if the new word is a spelling error
                                If Not myNHunspell.Spell(newWord) And Not foundNewWordinSpell Then
                                    ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                                    _spellingErrors(UBound(_spellingErrors)) = newWord
                                    resetSpellingRanges = True
                                ElseIf Not myNHunspell.Spell(newWord) Then
                                    resetSpellingRanges = True
                                End If
                            Else
                                'We did find the new word and we've already added one instance
                                'The only thing left is to remove the original word
                                For j = i + 1 To UBound(_Text, 2)
                                    _Text(0, j - 1) = _Text(0, j)
                                    _Text(1, j - 1) = _Text(1, j)
                                Next
                                ReDim Preserve _Text(1, UBound(_Text, 2) - 1)
                            End If

                            'See if the original word was a spelling error and remove it
                            For j = 0 To UBound(_spellingErrors)
                                If _spellingErrors(j) = originalWord Then
                                    If UBound(_spellingErrors) > 0 Then
                                        'If there is more than one entry in _spellingErrors
                                        'then move the entries above this one down one
                                        For k = (j + 1) To UBound(_spellingErrors)
                                            _spellingErrors(k - 1) = _spellingErrors(k)
                                        Next
                                    End If
                                    ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                    resetSpellingRanges = True
                                    Exit For
                                End If
                            Next

                            If Not myNHunspell.Spell(newWord) Then resetSpellingRanges = True

                            'We've handled everything so we can GoTo SaveFullText
                            GoTo SaveFullText
                        End If
                    End If
                Next



                'If we get past the Next, then something went wrong
            Else
                'If we get here, then original word is blank
                'See if the new word is in the array
                Dim foundNewWord As Boolean = False

                For i = 0 To UBound(_Text, 2)
                    If _Text(0, i) = newWord Then
                        foundNewWord = True
                        _Text(1, i) = _Text(1, i) + 1
                        Exit For
                    End If
                Next

                If Not foundNewWord Then
                    ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                    _Text(0, UBound(_Text, 2)) = newWord
                    _Text(1, UBound(_Text, 2)) = 1

                    'Check if the new word is a spelling error
                    If Not myNHunspell.Spell(newWord) Then
                        ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                        _spellingErrors(UBound(_spellingErrors)) = newWord
                        resetSpellingRanges = True
                    End If
                End If
            End If


        Else
            'If we get here, then there is nothing in the Text array yet
            ReDim _Text(1, 0)
            _Text(0, 0) = newWord
            _Text(1, 0) = 1

            'Check if the new word is a spelling error
            If Not myNHunspell.Spell(newWord) Then
                ReDim _spellingErrors(0)
                _spellingErrors(0) = newWord
                resetSpellingRanges = True
            End If
        End If



SaveFullText:
        'Save FullText
        If SelectionStart = 0 Then
            'We're at the beginning of the text
            FullText = Input & FullText
        ElseIf SelectionStart = FullText.Length Then
            'We're at the end of the text
            FullText = FullText & Input
        Else
            'We're somewhere in the middle
            FullText = Left(FullText, SelectionStart) & _
                            Input & _
                            Right(FullText, FullText.Length - SelectionStart)
        End If

        'Reset the spelling error ranges
        If resetSpellingRanges Then
            Call SetSpellingErrorRanges()
        End If
    End Sub


    ''' <summary>
    ''' Removes the character after the selection start (which is 0-based)
    ''' </summary>
    ''' <param name="SelectionStart">The position directly before the character to be removed</param>
    ''' <remarks></remarks>
    Public Sub RemoveText(ByVal SelectionStart As Integer)
        'Remove Text is going to function as delete key
        'If the position given to us is at the end, this won't work
        'Also, if there is nothing in fulltext, then there's nothing to delete
        If SelectionStart = (FullText.Length) Or FullText.Length = 0 Or SelectionStart = -1 Then Return

        'Sometimes the SetText is called first
        If _setTextCalledFirst = True Then
            _setTextCalledFirst = False
            Return
        End If

        'If we can reset the ignoreRanges, then do that
        If Not _dontResetIgnoreRanges Then
            ReDim _ignoreRange(-1)
        End If


        'If there is only one char in FullText, we can just reset it
        If FullText.Length = 1 Then
            FullText = ""
            ReDim _Text(1, -1)
            ReDim _spellingErrors(-1)
            Return
        End If

        Dim originalWord As String
        Dim newWord As String
        Dim endOfWord As Integer
        Dim beginning As Integer
        Dim resetSpellingRanges As Boolean = False

        'Check if we're deleting a non letter or digit
        If Not Char.IsLetterOrDigit(FullText(SelectionStart)) Then


            'see if there are no letters or digits around it...if so, we just
            'update fulltext and move on

            'Check if at the end
            If SelectionStart = (FullText.Length - 1) And _
                Not Char.IsLetterOrDigit(FullText(SelectionStart)) Then
                GoTo SaveFullText


            ElseIf SelectionStart = 0 Then
                'We're at the beginning
                GoTo SaveFullText


            Else
                'We're in the middle

                'Check the char on either side...if one of them is a non letter or digit
                'then we can also just save the full text.  We're not combining two words
                'into one,
                'Example: "This is. A" deleting the period
                If Not Char.IsLetterOrDigit(FullText(SelectionStart - 1)) Or _
                    Not Char.IsLetterOrDigit(FullText(SelectionStart + 1)) Then
                    GoTo SaveFullText


                Else
                    'If both of the char on either side are letters or digits, then
                    'we're merging two words into one...this is a special case where
                    'we will need to delete both of the original words and create a new one

                    'We need to get the two original words
                    'Example "this tle" deleting the space
                    'SelectionStart = 4
                    'firstWord beginning = 0
                    'firstWord end = 3
                    'secondWord beginning = 5
                    'secondWord end = 7

                    Dim firstWord, secondWord As String

                    'Get the first word (to do this, use SelectionStart -1)
                    beginning = FindFirstLetterOrDigitFromPosition(SelectionStart - 1)
                    firstWord = Mid(FullText, beginning + 1, SelectionStart - beginning)

                    'Get the second word (to do this, use Selection Start +1)
                    endOfWord = FindLastLetterOrDigitFromPosition(SelectionStart + 1)
                    secondWord = Mid(FullText, SelectionStart + 2, endOfWord - SelectionStart)

                    'The new word is just firstWord & secondWord
                    newWord = firstWord & secondWord

                    'Find the first word and remove one instance of it
                    For i = 0 To UBound(_Text, 2)


                        If _Text(0, i) = firstWord And _Text(1, i) = 1 Then
                            'Remove the word from Text and _spellingErrors
                            For j = i + 1 To UBound(_Text, 2)
                                _Text(0, j - 1) = _Text(0, j)
                                _Text(1, j - 1) = _Text(1, j)
                            Next

                            ReDim Preserve _Text(1, UBound(_Text, 2) - 1)

                            'now remove it from the spell check
                            For j = 0 To UBound(_spellingErrors)
                                If UBound(_spellingErrors) > 0 Then
                                    For k = j + 1 To UBound(_spellingErrors)
                                        _spellingErrors(k - 1) = _spellingErrors(k)
                                    Next
                                End If
                                ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                resetSpellingRanges = True
                                Exit For
                            Next

                            Exit For


                        ElseIf _Text(0, i) = firstWord And _Text(1, i) = 1 Then
                            'just remove an instance of the word
                            _Text(1, i) = _Text(1, i) - 1
                            Exit For
                        End If
                    Next



                    'Find the second word and remove one instance of it
                    For i = 0 To UBound(_Text, 2)


                        If _Text(0, i) = secondWord And _Text(1, i) = 1 Then
                            'Remove the word from Text and _spellingErrors
                            For j = i + 1 To UBound(_Text, 2)
                                _Text(0, j - 1) = _Text(0, j)
                                _Text(1, j - 1) = _Text(1, j)
                            Next

                            ReDim Preserve _Text(1, UBound(_Text, 2) - 1)

                            'now remove it from the spell check
                            For j = 0 To UBound(_spellingErrors)
                                If UBound(_spellingErrors) > 0 Then
                                    For k = j + 1 To UBound(_spellingErrors)
                                        _spellingErrors(k - 1) = _spellingErrors(k)
                                    Next
                                End If
                                ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                resetSpellingRanges = True
                                Exit For
                            Next

                            Exit For


                        ElseIf _Text(0, i) = firstWord And _Text(1, i) = 1 Then
                            'just remove an instance of the word
                            _Text(1, i) = _Text(1, i) - 1
                            Exit For
                        End If


                    Next

                    'Now add the new word
                    ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                    _Text(0, UBound(_Text, 2)) = newWord
                    _Text(1, UBound(_Text, 2)) = 1

                    'Now spell check it
                    If Not myNHunspell.Spell(newWord) Then
                        ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                        _spellingErrors(UBound(_spellingErrors)) = newWord
                        resetSpellingRanges = True
                    End If
                End If

                GoTo SaveFullText
            End If

        End If



        'Now we need to figure out what the original word was and what the new word will be

        'Start with the case that we're at the beginning of the text
        If SelectionStart = 0 Then


            'Now make sure there is a letter or digit currently at the beginning of the text
            If Not Char.IsLetterOrDigit(Left(FullText, 1)) Then
                'Example: " This" deleting the leading whitespace
                originalWord = ""
                newWord = ""
            Else
                'Example: "This" deleting T
                'SelectionStart = 0
                'endOfWord = 3

                'Find the end of the word that begins the FullText
                endOfWord = FindLastLetterOrDigitFromPosition(SelectionStart)
                originalWord = Left(FullText, (endOfWord - SelectionStart + 1))
                newWord = Right(originalWord, originalWord.Length - 1)
            End If


        ElseIf SelectionStart = FullText.Length - 1 Then


            'Now check if we're at the end
            'Make sure there is a letter or digit at the end of the text
            If Not Char.IsLetterOrDigit(Right(FullText, 1)) Then
                'Example: "This " deleting preceding white space
                originalWord = ""
                newWord = ""
            Else
                'Example: "This" deleting s
                'SelectionStart = 3
                'beginning = 0

                beginning = FindFirstLetterOrDigitFromPosition(SelectionStart)
                originalWord = Right(FullText, ((SelectionStart + 1) - beginning))
                newWord = Left(originalWord, originalWord.Length - 1)
            End If


        Else 'We're somewhere in the middle of the text


            beginning = FindFirstLetterOrDigitFromPosition(SelectionStart)
            endOfWord = FindLastLetterOrDigitFromPosition(SelectionStart)

            'Example: "This" deleting i         "This will" deleting s
            'SelectionStart = 2                 SelectionStart = 3
            'beginning = 0                      beginning = 0
            'endOfWord = 3                      endOfWord = 3
            originalWord = Mid(FullText, beginning + 1, (endOfWord - beginning + 1))

            newWord = Mid(FullText, beginning + 1, SelectionStart - beginning) & _
                      Mid(FullText, SelectionStart + 2, (endOfWord - SelectionStart))
        End If



        If UBound(_Text, 2) > -1 Then


            For i = 0 To UBound(_Text, 2)


                If _Text(0, i) = originalWord And _Text(1, i) = 1 Then


                    'Make sure there is a new word and we weren't deleting a single char word
                    If newWord.Length > 0 Then
                        'Check if the word already exists
                        Dim foundNewWord As Boolean = False

                        For j = 0 To UBound(_Text, 2)
                            If _Text(0, j) = newWord Then
                                foundNewWord = True
                                _Text(1, j) = _Text(1, j) + 1

                                'we can also delete the original word
                                'See if the original word was a spelling error and remove it
                                For l = 0 To UBound(_spellingErrors)
                                    If _spellingErrors(l) = originalWord Then
                                        If UBound(_spellingErrors) > 0 Then
                                            For k = l + 1 To UBound(_spellingErrors)
                                                _spellingErrors(k - 1) = _spellingErrors(k)
                                            Next

                                            ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                            resetSpellingRanges = True
                                        Else
                                            ReDim _spellingErrors(-1)
                                            resetSpellingRanges = True
                                        End If
                                        Exit For
                                    End If
                                Next

                                'Move all entries in array after this down one
                                For l = i + 1 To UBound(_Text, 2)
                                    _Text(0, l - 1) = _Text(0, l)
                                    _Text(1, l - 1) = _Text(1, l)
                                Next

                                ReDim Preserve _Text(1, UBound(_Text, 2) - 1)

                                Exit For
                            End If
                        Next



                        If Not foundNewWord Then
                            'replace the originalword with the newword
                            _Text(0, i) = newWord

                            'See if the original word was a spelling error and remove it
                            For l = 0 To UBound(_spellingErrors)
                                If _spellingErrors(l) = originalWord Then
                                    If UBound(_spellingErrors) > 0 Then
                                        For k = l + 1 To UBound(_spellingErrors)
                                            _spellingErrors(k - 1) = _spellingErrors(k)
                                        Next

                                        ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                        resetSpellingRanges = True
                                    Else
                                        ReDim _spellingErrors(-1)
                                        resetSpellingRanges = True
                                    End If
                                    Exit For
                                End If
                            Next

                            'Spell check the new word
                            Dim foundSpellNewWord As Boolean = False

                            For j = 0 To UBound(_spellingErrors)
                                If _spellingErrors(j) = newWord Then
                                    foundSpellNewWord = True
                                    Exit For
                                End If
                            Next

                            If Not foundSpellNewWord And Not myNHunspell.Spell(newWord) Then
                                ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                                _spellingErrors(UBound(_spellingErrors)) = newWord
                                resetSpellingRanges = True
                            End If
                        End If

                        Exit For


                    Else
                        'There is no newWord...just delete the original word
                        For j = i + 1 To UBound(_Text, 2)
                            _Text(0, j - 1) = _Text(0, j)
                            _Text(1, j - 1) = _Text(1, j)
                        Next

                        ReDim Preserve _Text(1, UBound(_Text, 2) - 1)

                        'See if the original was a spelling error
                        For j = 0 To UBound(_spellingErrors)
                            If _spellingErrors(j) = originalWord Then
                                If UBound(_spellingErrors) > 0 Then
                                    For k = j + 1 To UBound(_spellingErrors)
                                        _spellingErrors(k - 1) = _spellingErrors(k)
                                    Next

                                    ReDim Preserve _spellingErrors(UBound(_spellingErrors) - 1)
                                    resetSpellingRanges = True
                                Else
                                    ReDim _spellingErrors(-1)
                                    resetSpellingRanges = True
                                End If
                                Exit For
                            End If
                        Next

                        Exit For


                    End If


                ElseIf _Text(0, i) = originalWord And _Text(1, i) > 1 Then
                    'Reduce the number of duplicate entries by one
                    _Text(1, i) = _Text(1, i) - 1

                    'see if the new word is an already added word
                    Dim FoundNewWord As Boolean = False

                    For j = 0 To UBound(_Text, 2)
                        If _Text(0, j) = newWord Then
                            FoundNewWord = True
                            _Text(1, j) = _Text(1, j) + 1
                            Exit For
                        End If
                    Next

                    If Not FoundNewWord Then
                        'Make sure there is a new word and we weren't deleting a single char word
                        If newWord.Length > 0 Then
                            ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                            _Text(0, UBound(_Text, 2)) = newWord
                            _Text(1, UBound(_Text, 2)) = 1

                            'Spell check newWord
                            FoundNewWord = False

                            For j = 0 To UBound(_spellingErrors)
                                If _spellingErrors(j) = newWord Then
                                    FoundNewWord = True
                                    Exit For
                                End If
                            Next

                            If Not FoundNewWord Then
                                If Not myNHunspell.Spell(newWord) Then
                                    ReDim _spellingErrors(UBound(_spellingErrors) + 1)
                                    _spellingErrors(UBound(_spellingErrors)) = newWord
                                    resetSpellingRanges = True
                                End If
                            End If
                            Exit For


                        Else
                            'If there is no new word, then move any word after it down the array and
                            'resize the array
                            For j = i + 1 To UBound(_Text, 2) Step -1
                                _Text(0, j - 1) = _Text(0, j)
                                _Text(1, j - 1) = _Text(1, j)
                            Next
                            ReDim Preserve _Text(1, UBound(_Text, 2) - 1)
                            Exit For
                        End If


                    End If


                End If


            Next


        End If

SaveFullText:
        'Save FullText
        If SelectionStart = 0 Then
            'we're at the beginning
            FullText = Right(FullText, FullText.Length - 1)
        ElseIf SelectionStart = FullText.Length - 1 Then
            'Deleting the last character
            FullText = Left(FullText, FullText.Length - 1)
        Else
            'Deleting somewhere in the middle
            FullText = Left(FullText, SelectionStart) & _
                       Right(FullText, (FullText.Length - SelectionStart - 1))
        End If

        'Reset the spelling error ranges
        If resetSpellingRanges Then
            Call SetSpellingErrorRanges()
        End If
    End Sub


    ''' <summary>
    ''' Parse the input string into its separate words
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <remarks></remarks>
    Public Sub SetText(ByVal Input As String)
        'If we have already handled this with the keypress or keydown events
        'This will allow for the text to change based on non-user input
        If FullText = Input Then Return

        'If we can reset the ignore ranges, then do that
        If Not _dontResetIgnoreRanges Then
            ReDim _ignoreRange(-1)
        End If

        _setTextCalledFirst = True

        'The idea here is that we need to know the start of a new word, and if the last letter
        'was part of another word.  wordStarted is used to determine if we have already had
        'a letter or digit preceding the current char.
        Dim wordStart As Integer = 1
        Dim wordStarted As Boolean = False
        ReDim _Text(1, -1)
        ReDim _spellingErrors(-1)
        ReDim _spellingErrorRanges(-1)

        'set FullText
        FullText = Input
        Dim resetSpellingRanges As Boolean = False


        'Go through every char in the textbox one by one
        For i = 1 To Input.Length


            If Not Char.IsLetterOrDigit(Mid(Input, i, 1)) And wordStarted = True Then
                'We know it's not a letter or digit so it could be the end of a word


                'Check if it's an apostrophe or hyphen, if it is, it's not the end of a word
                If (Mid(Input, i, 1) = "'" Or Mid(Input, i, 1) = "-") And i <> Input.Length Then
                    If Char.IsLetterOrDigit(Mid(Input, i + 1, 1)) Then
                        'is an apostrophe or hyphen, then we just go to the next character
                        GoTo FoundApostrophe
                    End If
                End If

                'Check if we think this is the beginning of a word.  If wordStart = i, then
                'we're possibly at the beginning of a word
                If wordStart <> i Then
                    wordStarted = False

                    'Now see if the word has already been added (we're not adding words
                    'more than once.  This way we only have to spell check each word once)
                    Dim boolFound As Boolean = False

                    For j = 0 To UBound(_Text, 2)
                        If _Text(0, j) = Trim(Mid(Input, wordStart, i - wordStart)) Then
                            boolFound = True
                            _Text(1, j) = _Text(1, j) + 1
                            Exit For
                        End If
                    Next


                    'If the word hasn't been added, add it and then spell check it
                    If Not boolFound Then
                        ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
                        _Text(0, UBound(_Text, 2)) = Trim(Mid(Input, wordStart, i - wordStart))
                        _Text(1, UBound(_Text, 2)) = 1

                        'Spell check it
                        Dim foundWord As Boolean = False

                        For j = 0 To UBound(_spellingErrors)
                            If _spellingErrors(j) = Trim(Mid(Input, wordStart, i - wordStart)) Then
                                foundWord = True
                                Exit For
                            End If
                        Next

                        If Not myNHunspell.Spell(_Text(0, UBound(_Text, 2))) And Not foundWord Then
                            ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                            _spellingErrors(UBound(_spellingErrors)) = _Text(0, UBound(_Text, 2))
                            resetSpellingRanges = True
                        End If
                    End If
                    wordStart = i + 1
                End If
            ElseIf Char.IsLetterOrDigit(Mid(Input, i, 1)) Then
                If Not wordStarted Then wordStart = i
                wordStarted = True
            End If
FoundApostrophe:
        Next



        'We have to check the last character separately or the last word won't be added
        If Not Char.IsLetterOrDigit(Right(Input, 1)) Then
            GoTo ResetSpelling
        End If

        'Check the last word and see it is had been added
        Dim boolFound2 As Boolean = False

        For j = 0 To UBound(_Text, 2)
            If _Text(0, j) = Trim(Mid(Input, wordStart, Input.Length - wordStart + 1)) Then
                boolFound2 = True
                _Text(1, j) = _Text(1, j) + 1
                Exit For
            End If
        Next

        'If it hasn't been added, add it and spell check it
        If Not boolFound2 Then
            ReDim Preserve _Text(1, UBound(_Text, 2) + 1)
            _Text(0, UBound(_Text, 2)) = Trim(Mid(Input, wordStart, Input.Length - wordStart + 1))
            _Text(1, UBound(_Text, 2)) = 1

            'Spell check it
            Dim foundWord As Boolean = False

            For j = 0 To UBound(_spellingErrors)
                If _spellingErrors(j) = _Text(0, UBound(_Text, 2)) Then
                    foundWord = True
                    Exit For
                End If
            Next

            If Not myNHunspell.Spell(_Text(0, UBound(_Text, 2))) And Not foundWord Then
                ReDim Preserve _spellingErrors(UBound(_spellingErrors) + 1)
                _spellingErrors(UBound(_spellingErrors)) = _Text(0, UBound(_Text, 2))
                resetSpellingRanges = True
            End If
        End If
ResetSpelling:
        If resetSpellingRanges Then
            SetSpellingErrorRanges()
        End If
    End Sub


#End Region


#Region "FindPositions"
    ''' <summary>
    ''' Given a starting point, we're looking at the characters before it to find the
    ''' position of the first character in the word containing the starting point
    ''' </summary>
    ''' <param name="SelectionStart">0-based starting point</param>
    ''' <returns>0-based index of the first character in the word</returns>
    ''' <remarks></remarks>
    Private Function FindFirstLetterOrDigitFromPosition(ByVal SelectionStart As Long) As Long
        For i = SelectionStart - 1 To 0 Step -1
            If Not Char.IsLetterOrDigit(FullText(i)) Then
                'Need to check if it's an apostrophe or hyphen
                Dim foundApOrHyph As Boolean = False

                If (FullText(i) = "'" Or FullText(i) = "-") And i <> 0 Then
                    If Char.IsLetterOrDigit(FullText(i - 1)) Then
                        foundApOrHyph = True
                    End If
                End If

                If Not foundApOrHyph Then
                    Return i + 1
                End If
            End If
        Next

        Return 0
    End Function


    ''' <summary>
    ''' Given a starting position, this will return the 0-based index representing
    ''' the end of a word containing the character at the starting position
    ''' </summary>
    ''' <param name="SelectionStart">0-based index</param>
    ''' <returns>0-based index of the last character in the word</returns>
    ''' <remarks></remarks>
    Private Function FindLastLetterOrDigitFromPosition(ByVal SelectionStart As Long) As Long
        'Character array is 0 based in this function
        For i = SelectionStart To FullText.Length - 1
            If Not Char.IsLetterOrDigit(FullText(i)) Then
                'Need to check if it's an apostrophe or hyphen 
                Dim foundApOrHyph As Boolean = False

                If (FullText(i) = "'" Or FullText(i) = "-") And i <> FullText.Length Then
                    If Char.IsLetterOrDigit(FullText(i + 1)) Then
                        foundApOrHyph = True
                    End If
                End If

                If Not foundApOrHyph Then
                    'We found the character after the end of the last word
                    Return i - 1
                End If
            End If
        Next

        Return FullText.Length - 1
    End Function


#End Region


#Region "Spelling Functions and Subs"
    ''' <summary>
    ''' Add the range of a word to ignore.
    ''' </summary>
    ''' <param name="IgnoreRange"></param>
    ''' <remarks></remarks>
    Public Sub AddRangeToIgnore(ByVal IgnoreRange As CharacterRange)
        ReDim Preserve _ignoreRange(UBound(_ignoreRange) + 1)
        _ignoreRange(UBound(_ignoreRange)) = IgnoreRange
    End Sub


    Public Sub ClearIgnoreRanges()
        ReDim _ignoreRange(-1)
    End Sub


    Public Sub DontResetIgnoreRanges(Optional ByVal DontReset As Boolean = True)
        _dontResetIgnoreRanges = DontReset
    End Sub


    Public Function GetIgnoreRanges() As CharacterRange()
        Return _ignoreRange
    End Function


    ''' <summary>
    ''' Returns the ranges of characters associated with misspelled words.
    ''' This is used by the CustomPaint to know where to paint the squiggly lines
    ''' </summary>
    ''' <returns>CharacterRange</returns>
    ''' <remarks></remarks>
    Public Function GetSpellingErrorRanges() As CharacterRange()
        Return _spellingErrorRanges
    End Function


    ''' <summary>
    ''' Return the words that are spelling errors
    ''' </summary>
    ''' <returns>Array of strings</returns>
    ''' <remarks></remarks>
    Public Function GetSpellingErrors() As String()
        Return _spellingErrors
    End Function


    ''' <summary>
    ''' Returns the requested number of suggestions based on the inputted word
    ''' </summary>
    ''' <param name="Word">Word we need suggestions for</param>
    ''' <param name="NumberOfSuggestions">How many suggestions to return</param>
    ''' <returns>Array of strings with the suggestions</returns>
    ''' <remarks></remarks>
    Public Function GetSuggestions(ByVal Word As String, ByVal NumberOfSuggestions As Integer) As String()
        Dim suggestions() As String
        Dim NHunspellSugg As New List(Of String)
        ReDim suggestions(-1)
        NHunspellSugg = myNHunspell.Suggest(Word)

        For i = 0 To NumberOfSuggestions - 1
            If i < NHunspellSugg.Count Then
                ReDim Preserve suggestions(UBound(suggestions) + 1)
                suggestions(UBound(suggestions)) = NHunspellSugg.Item(i)
            End If
        Next

        Return suggestions
    End Function


    ''' <summary>
    ''' Given a 0-based char index, returns the misspelled word that that character is part of
    ''' </summary>
    ''' <param name="CharIndex">0-based Index</param>
    ''' <returns>Strings.String Type</returns>
    ''' <remarks></remarks>
    Public Function GetMisspelledWordAtPosition(ByVal CharIndex As Integer) As String
        Dim currentRange As CharacterRange

        For Each currentRange In _spellingErrorRanges
            If (CharIndex >= currentRange.First) And (CharIndex <= (currentRange.First + currentRange.Length + 1)) Then
                Return Mid(FullText, currentRange.First + 1, currentRange.Length)
            End If
        Next

        Return ""
    End Function


    ''' <summary>
    ''' Returns whether or not the text has any spelling errors
    ''' </summary>
    ''' <returns>A boolean representing whether there are spelling errors</returns>
    ''' <remarks></remarks>
    Public Function HasSpellingErrors() As Boolean
        Return (UBound(_spellingErrors) > -1)
    End Function


    ''' <summary>
    ''' Given a 0-based character index, returns whether the item is part of a misspelled word
    ''' </summary>
    ''' <param name="CharIndex">0-based index</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function IsPartOfSpellingError(ByVal CharIndex As Integer) As Boolean
        Dim currentRange As CharacterRange
        Dim result As Boolean = False

        For Each currentRange In _spellingErrorRanges
            If (CharIndex >= currentRange.First) And (CharIndex <= (currentRange.First + currentRange.Length + 1)) Then
                result = True
                Exit For
            End If
        Next

        If result Then
            'we need to check if it's part of an ignore range
            For Each currentRange In _ignoreRange
                If CharIndex >= currentRange.First And (CharIndex <= (currentRange.First + currentRange.Length + 1)) Then
                    result = False
                    Exit For
                End If
            Next
        End If

        Return result
    End Function


    ''' <summary>
    ''' Sets the character ranges of the spelling errors
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetSpellingErrorRanges()
        ReDim _spellingErrorRanges(-1)

        If Not HasSpellingErrors() Then Return

        'The idea here is that we need to know the start of a new word, and if the last letter
        'was part of another word
        Dim wordStart As Integer = 1
        Dim wordStarted As Boolean = False

        'Go through every char in FullText one by one
        For i = 1 To FullText.Length
            If Not Char.IsLetterOrDigit(Mid(FullText, i, 1)) Then
                'We know it's not a letter or digit so it could be the end of a word

                'Check if it's an apostrophe or hyphen, if it is, it's not the end of a word
                If (Mid(FullText, i, 1) = "'" Or Mid(FullText, i, 1) = "-") And i <> FullText.Length Then
                    If Char.IsLetterOrDigit(Mid(FullText, i + 1, 1)) Then
                        'is an apostrophe or hyphen
                        GoTo FoundApostrophe
                    End If
                End If

                'Check if we think this is the beginning of a word
                If wordStart <> i Then
                    wordStarted = False

                    Dim currentWord As String = Trim(Mid(FullText, wordStart, i - wordStart))

                    'Spell check it
                    For j = 0 To UBound(_spellingErrors)
                        If _spellingErrors(j) = currentWord Then
                            'Add it to the array
                            ReDim Preserve _spellingErrorRanges(UBound(_spellingErrorRanges) + 1)
                            _spellingErrorRanges(UBound(_spellingErrorRanges)) = _
                                   New CharacterRange(wordStart - 1, currentWord.Length)
                        End If
                    Next
                End If
            Else
                If Not wordStarted Then wordStart = i
                wordStarted = True
            End If
FoundApostrophe:
        Next

        'We have to check the last character separately or the last word won't be added
        If Not Char.IsLetterOrDigit(Right(FullText, 1)) Then
            Return
        End If

        Dim lastWord As String = Trim(Mid(FullText, wordStart, FullText.Length - wordStart + 1))

        'Spell check it
        For j = 0 To UBound(_spellingErrors)
            If _spellingErrors(j) = lastWord Then
                'Add it to the array
                ReDim Preserve _spellingErrorRanges(UBound(_spellingErrorRanges) + 1)
                _spellingErrorRanges(UBound(_spellingErrorRanges)) = New CharacterRange(wordStart - 1, lastWord.Length)
            End If
        Next
    End Sub


#End Region


    Public Sub UpdateHunspell(ByRef newHunspell As Hunspell)
        myNHunspell = newHunspell
    End Sub

End Class
