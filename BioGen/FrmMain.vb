'------------- Header --------------------
' Author: David Wesley Benner
' Date: 6/14/2020
' Purpose: To generate a persons biography
' Change Log: 
'   6/17/2020 - Created merged database file
'   6/26/2020 - Added view checkboxes (presidents/birthdays/events)
'   7/4/2020 - Implimented Events
' -----------------------------------------

Imports System.IO

Public Class FrmMain

#Region "***** Initialization *****"
    Dim ind As Byte = 0 'used in the tool strip menu ... it was added for the edit box menu
    Dim url As String 'used in the tool strip menu ... it was added for the edit box menu

    'Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    RtxBiography.Select() 'set the focus in the biography editor a richtextbox
    'End Sub


    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        LblTimer.Text = Format(Date.Now, "dddd       MMMM d, yyyy       h:mm:ss  tt ")
    End Sub
#End Region

#Region "----- All Menu Items -----"

#Region "----- Main Menu Items -----"
    Private Sub Edit_Biography_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        FrmOpenBiography.BtnOption.Text = "Edit"
        'Edit biography got here
        FrmOpenBiography.Show()
    End Sub

    Private Sub Delete_Biography_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        FrmOpenBiography.BtnOption.Text = "Delete"
        'Delete biography got here
        FrmOpenBiography.Show()
    End Sub

    Private Sub Add_Biography_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FrmNewBio.BtnOption.Text = "Add"
        'add biography got here
        FrmNewBio.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

#End Region

#Region "----- Web Menu Items -----"
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim unused = Process.Start("http://www.google.com/#hl=en&q=" & TxbSearch.Text.Replace(" ", "+"))
        TxbSearch.Text = ""
        TxbSearch.Focus()
    End Sub
    Private Sub FamilySearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamilySearchToolStripMenuItem.Click
        Process.Start("https://www.familysearch.org/campaign/hints?ancestor_pid_1=L6FN-648&et_cid=1738718&et_rid=150021690&linkid=CTA&cid=em-rh-8016")
    End Sub

    Private Sub OnThisDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnThisDateToolStripMenuItem.Click
        Process.Start("https://www.onthisday.com/")
    End Sub
#End Region

#Region "----- Document File Menu Items -----"

    Private Sub Open_Document_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        Dim myStream As Stream = Nothing
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* "
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True


        If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (OpenFileDialog1.FileName.Length > 0) Then
            Try
                myStream = OpenFileDialog1.OpenFile
                If myStream IsNot Nothing Then
                    RtxBiography.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    url = OpenFileDialog1.FileName
                    LblFileName.Text = Trim(OpenFileDialog1.FileName)
                End If
            Catch ex As Exception
                MessageBox.Show("Can not read file from disk. Original error." & ex.Message)
            Finally
                If (myStream IsNot Nothing) Then
                    ind = 1
                    myStream.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub Save_Document_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save Text Files"
        SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* "
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True


        Try
            RtxBiography.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText) ' may want to change this to RichText
            LblFileName.Text = Trim(OpenFileDialog1.FileName)
        Catch ex As Exception
            Call SaveAs_Document_Click(Me, e)
        End Try
    End Sub

    Private Sub SaveAs_Document_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save Text Files"
        SaveFileDialog1.CheckFileExists = False
        SaveFileDialog1.CheckPathExists = False
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* "
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            RtxBiography.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText) ' may want to change this to RichText
            LblFileName.Text = Trim(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Font_Document_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = RtxBiography.Font
        FontDialog1.ShowDialog()
        RtxBiography.Font = FontDialog1.Font
    End Sub

#End Region

#Region "----- Document Edit Menu -----"
    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        RtxBiography.SelectedText = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RtxBiography.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RtxBiography.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Copy()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Cut()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RtxBiography.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem3.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Text = ""
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RtxBiography.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Copy()
        End If
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Cut()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        RtxBiography.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        RtxBiography.SelectAll()
    End Sub

#End Region

#Region "----- Category Area Menu Items"
    Private Sub Rename_Category_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        FrmOpenCategory.Text = "Rename Category"
        FrmOpenCategory.BtnOption.Text = "Rename"
        FrmOpenCategory.Show()
    End Sub

    Private Sub Delete_Category_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        FrmOpenCategory.Text = "Delete Category"
        FrmOpenCategory.BtnOption.Text = "Delete"
        FrmOpenCategory.Show()
    End Sub

    Private Sub Select_Category_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        FrmOpenCategory.BtnOption.Text = "Select"
        lblSelectedBiography.Select()
        FrmOpenCategory.Show()
    End Sub

    Private Sub Add_Category_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        FrmCatagory.BtnOption.Text = "Save"
        FrmCatagory.Show()
    End Sub

    Private Sub Add_Event_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        FrmCategoryEvents.BtnOption.Text = "Add"
        FrmCategoryEvents.Show()
    End Sub

    Private Sub Edit_Event_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        FrmOpenEvents.BtnOption.Text = "Edit"
        FrmOpenEvents.Show()
    End Sub

    Private Sub Delete_Event_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        FrmOpenEvents.BtnOption.Text = "Delete"
        FrmOpenEvents.Show()
    End Sub


#End Region

#End Region

#Region "***** Generate the Databases *****"
    Friend Sub BioGenDatabase(ByVal filename As String)
        TextFileName = filename
        'TextFileName EXISTS ALREADY, DELETE IT AND START FRESH
        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & TextFileName)
        Catch ex As Exception
        End Try

        'Process the biography records
        Try
            Using biographyReader As New StreamReader(DataPath & "\" & BiographyFile)

                Dim record As String = Nothing ' used to writhe the record to the database file
                Dim filewriter As New StreamWriter(DataPath & "\" & TextFileName, True) 'True appends the record to the file. False replaces the file.
                Dim sortdate As String = Nothing 'sort on their birthday calculated - not their birth date

                'Process each biography record
                Do While biographyReader.Peek <> -1 'see if there is another record to process

                    'Create the Biography Record Array
                    BiographyRecord = Split(biographyReader.ReadLine(), delimiter) '** Module Array ** holds the fields of the currently selected record

                    'Process the biography record
                    If FrmSelectView.CkbAllBios.Checked Or (RootBioID = CInt(BiographyRecord(0))) Then
                        If (RootBioBirthDate <= CDate(BiographyRecord(2))) Or ((BiographyRecord(3) = "No") And (RootBioBirthDate <= CDate(BiographyRecord(4)))) Then

                            If RootBioBirthDate <= CDate(BiographyRecord(2)) Then
                                If BiographyRecord(3) = "Yes" And RootBioLiving = "Yes" Then
                                    'Write the birth record
                                    sortdate = CStr(CDate(BiographyRecord(2)).Ticks) ' BioBirthDate - convert to ticks for sorting purposes
                                    'birth record = type (0), birthdate(1) in ticks, name(2)
                                    record = "Biog" & vbTab & sortdate & vbTab & BiographyRecord(1)
                                    filewriter.WriteLine(record)
                                Else
                                    'if the root person was living when this biography was born process it
                                    If RootBioDeathDate >= CDate(BiographyRecord(2)) Then
                                        'Write the birth record
                                        sortdate = CStr(CDate(BiographyRecord(2)).Ticks) ' BioBirthDate - convert to ticks for sorting purposes
                                        'birth record = type (0), birthdate(1) in ticks, name(2)
                                        record = "Biog" & vbTab & sortdate & vbTab & BiographyRecord(1)
                                        filewriter.WriteLine(record)
                                    End If
                                End If
                            End If
                            If FrmSelectView.CbxDeaths.Checked Then

                                'Write the death record
                                sortdate = CStr(CDate(BiographyRecord(4)).Ticks) ' convert to ticks for sorting purposes

                                If BiographyRecord(3) = "No" And RootBioBirthDate <= CDate(BiographyRecord(4)) Then
                                    'record = type, death date, name, birth date
                                    If RootBioLiving = "Yes" Then
                                        record = "Dead" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                        filewriter.WriteLine(record)
                                    Else
                                        'if this person died in the lifetime of the root person the process it
                                        If RootBioDeathDate >= CDate(BiographyRecord(4)) Then
                                            record = "Dead" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                            filewriter.WriteLine(record)
                                        End If
                                    End If
                                End If
                            End If

                        End If

                        If FrmSelectView.CbxBirthdays.Checked Then

                            'Create the birthday records
                            'birthday record = type (0), birthday (1) in ticks, name (2), death date (3)
                            Dim monthsValue As Integer = 12 'used to increase the birthdate by one year
                            Dim newDate As Date = CDate(BiographyRecord(2)) '= DateAdd(DateInterval.Month, monthsValue, dateValue)
                            If RootBioLiving = "Yes" Then
                                If BiographyRecord(3) = "Yes" Then 'this person is still living
                                    Do While newDate < Now
                                        newDate = DateAdd(DateInterval.Month, monthsValue, newDate) 'calculate next birthday

                                        If (newDate < Now) And (newDate >= RootBioBirthDate) Then
                                            sortdate = CStr(newDate.Ticks) ' convert to ticks for sorting purposes

                                            'Type, birthday, name, living?, birthdate
                                            record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                            filewriter.WriteLine(record)
                                        End If
                                    Loop
                                Else    'this person has passed away
                                    Do While (newDate < CDate(BiographyRecord(4)))
                                        newDate = DateAdd(DateInterval.Month, monthsValue, newDate) 'calculate next birthday
                                        If newDate >= RootBioBirthDate Then
                                            If newDate < CDate(BiographyRecord(4)) Then 'calculate only while they were alive
                                                sortdate = CStr(newDate.Ticks) ' convert to ticks for sorting purposes
                                                record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                                filewriter.WriteLine(record)
                                            End If
                                        End If
                                    Loop
                                End If
                            Else 'root person is not living
                                Do While (newDate < RootBioDeathDate) And (newDate >= RootBioBirthDate)
                                    newDate = DateAdd(DateInterval.Month, monthsValue, newDate) 'calculate next birthday
                                    If newDate >= RootBioBirthDate And (newDate >= RootBioBirthDate) Then
                                        If newDate < RootBioDeathDate Then 'calculate only while they were alive
                                            sortdate = CStr(newDate.Ticks) ' convert to ticks for sorting purposes
                                            record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                            filewriter.WriteLine(record)
                                        End If
                                    End If
                                Loop
                            End If
                        End If
                    End If
                Loop
                biographyReader.Close()

                'Process Categories
                Try
                    Using categoryReader As New StreamReader(DataPath & "\" & CategoryFile)
                        Dim indx As Integer = 0 'index number to use for the tempbiographyarray
                        Do While categoryReader.Peek <> -1 'see if there is another record to process
                            CategoryArray(indx) = categoryReader.ReadLine()
                            'see if it's wanted in the display
                            If CategoryView(indx) Then

                                'catagory record = "(0) id, (1) name, (2) file name associated with this catagory
                                Dim temprecord() As String = Split(CategoryArray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                                'process the events file here
                                Try
                                    Using eventsReader As New StreamReader(DataPath & "\" & temprecord(2))
                                        'category event record = (0) description, (1) date, (2) end date, (3) range
                                        Do While eventsReader.Peek <> -1
                                            Dim viewrecord As String = eventsReader.ReadLine()
                                            temprecord = Split(viewrecord, vbTab)
                                            'If individual Then
                                            If RootBioBirthDate <= CDate(temprecord(1)) Then
                                                If RootBioLiving = "Yes" Then
                                                    record = temprecord(0) & vbTab & CStr(CDate(temprecord(1)).Ticks & vbTab &
                                                temprecord(2) & vbTab & temprecord(3))
                                                    'MsgBox("record: " & record)
                                                    filewriter.WriteLine(record)
                                                Else
                                                    If RootBioDeathDate >= CDate(temprecord(2)) Then
                                                        record = temprecord(0) & vbTab & CStr(CDate(temprecord(1)).Ticks & vbTab &
                                                                                                  temprecord(2) & vbTab & temprecord(3))
                                                        filewriter.WriteLine(record)
                                                    End If
                                                End If
                                            End If
                                        Loop
                                        eventsReader.Close()
                                    End Using
                                Catch ex As Exception

                                End Try
                            End If
                            indx += 1   'Increase the index for use on the next record
                        Loop
                        categoryReader.Close()
                    End Using

                Catch ex As Exception
                    Dim unused = MsgBox("Error reading the " & CategoryFile & " file")
                End Try

                filewriter.Close()
            End Using

        Catch ex As Exception
        End Try

        'sort the database
        SortTsv(DataPath & "\" & TextFileName, New Integer() {2, 3})

    End Sub

#End Region

#Region "***** Display the Databases *****"
    Private Sub BtnSelectView_Click(sender As Object, e As EventArgs) Handles BtnSelectView.Click
        Enabled = False
        FrmSelectView.Show()
    End Sub


    Friend Sub DisplayTextFile(ByVal textfile As String)
        TxtFacts.Text = Nothing 'clear the textbox

        'read the textfile and process each record
        Try
            Dim outputtext As New System.Text.StringBuilder 'build the string to be put in the text box. this will include the entire textfile
            outputtext.Append(vbCrLf)
            Dim textfilereader As New IO.StreamReader(DataPath & "\" & textfile)

            'process the textfile
            Do While textfilereader.Peek <> -1 'see if there is another record to process
                Dim recordstring = textfilereader.ReadLine() 'read the next record
                Dim recordarray() As String = Split(recordstring, vbTab) 'create the record fields
                Dim yearonly = New Date(Convert.ToInt64(recordarray(1)))
                If DtpYearOnly.Checked And DtpYearOnly.Value.Year = CDate(yearonly).Year Or DtpYearOnly.Checked = False Then
                    Select Case recordarray(0) 'type of record

                        Case "Biog" 'birth record
                            If FrmSelectView.CbxBirthDate.Checked Then
                                'birth record = (0) type (1) birthdate in ticks, (2) name
                                Dim birthdate = New Date(Convert.ToInt64(recordarray(1)))
                                outputtext.Append("   " & recordarray(2) & " BORN on ")
                                outputtext.Append(CnvDate(CStr(birthdate)))
                                outputtext.Append(vbCrLf & vbCrLf)
                            End If
                        Case "Bday" 'birthday record
                            If FrmSelectView.CbxBirthdays.Checked Then

                                'birthday record = (0) type, (1) birthday, (2) name, (3) birth date
                                Dim birthday = New Date(Convert.ToInt64(recordarray(1)))
                                outputtext.Append("   " & recordarray(2) & " TURNED ")
                                Dim num As Long = DateDiff(DateInterval.Year, CDate(recordarray(3)), birthday)
                                outputtext.Append(" " & Words_1_999(CInt(num)) & " on ")
                                outputtext.Append(CStr(birthday))
                                outputtext.Append(vbCrLf & vbCrLf)
                            End If

                        Case "Dead" 'death record
                            If FrmSelectView.CbxDeaths.Checked Then
                                'death record = (0) type, (1) death date in ticks, (2) name, (3) birth date
                                Dim death = New DateTime(Convert.ToInt64(recordarray(1)))
                                outputtext.Append("   " & recordarray(2) & " PASSED on " & CnvDate(CStr(death)))
                                If CDate(CnvDate(recordarray(3))).Month >= death.Month Then
                                    If CDate(CnvDate(recordarray(3))).Month = death.Month Then
                                        If CDate(recordarray(3)).Day < death.Day Then
                                            outputtext.Append(" at " & Words_1_999(CInt(DateDiff(DateInterval.Year, CDate(recordarray(3)), death))))
                                        Else
                                            outputtext.Append(" at " & (Words_1_999(CInt(DateDiff(DateInterval.Year, CDate(recordarray(3)), death)) - 1)))
                                        End If
                                    Else
                                        outputtext.Append(" at " & Words_1_999(CInt(DateDiff(DateInterval.Year, CDate(recordarray(3)), death))))
                                    End If
                                Else
                                    outputtext.Append(" at " & Words_1_999(CInt(DateDiff(DateInterval.Year, CDate(recordarray(3)), death))))
                                End If
                                outputtext.Append(vbCrLf & vbCrLf)
                            End If
                        Case Else
                            'record = (0) description, (1) date - sortdate, (2) end date, (3) range Yes/No
                            outputtext.Append("   " & recordarray(0))
                            If recordarray(3) = "Yes" Then
                                outputtext.Append("   (")
                            Else
                                outputtext.Append("    ")
                            End If
                            Dim eventdate As New DateTime(Convert.ToInt64(recordarray(1)))
                            outputtext.Append(CStr(eventdate))
                            If recordarray(3) = "Yes" Then
                                outputtext.Append(" - " & recordarray(2) & ")")
                            End If
                            outputtext.Append(vbCrLf & vbCrLf)
                    End Select
                End If
            Loop
            TxtFacts.Text = Nothing
            TxtFacts.Text = outputtext.ToString
            outputtext.Clear()
            textfilereader.Close()
        Catch ex As Exception
            'MsgBox("Somethin went wrong in the DisplayTextFile(textfile) routine")
        End Try
    End Sub
#Region "----- Functions (CnvDate & Turn numbers to words) -----"
    Function CnvDate(dt As String) As String
        ' Return Format(CDate(dt), "dddd, MMM d, yyyy")
        Return Format(CDate(dt), "MMM d, yyyy")
    End Function


    'Returns a word for this value between 1 and 999
    Private Function Words_1_999(ByVal num As Integer) As String
        Dim hundreds As Integer
        Dim remainder As Integer
        Dim result As String = Nothing

        hundreds = num \ 100
        remainder = num - hundreds * 100

        If hundreds > 0 Then
            result = Words_1_19(hundreds) & " hundred-"
        End If

        If remainder > 0 Then
            result &= Words_1_99(remainder)
        End If

        Words_1_999 = Trim$(result)
    End Function

    ' Return a word for this value between 1 and 19.
    Private Function Words_1_19(ByVal num As Integer) As String
        Select Case num
            Case 1
                Words_1_19 = "One"
            Case 2
                Words_1_19 = "Two"
            Case 3
                Words_1_19 = "Three"
            Case 4
                Words_1_19 = "Four"
            Case 5
                Words_1_19 = "Five"
            Case 6
                Words_1_19 = "Six"
            Case 7
                Words_1_19 = "Seven"
            Case 8
                Words_1_19 = "Eight"
            Case 9
                Words_1_19 = "Nine"
            Case 10
                Words_1_19 = "Ten"
            Case 11
                Words_1_19 = "Eleven"
            Case 12
                Words_1_19 = "Twelve"
            Case 13
                Words_1_19 = "Thirteen"
            Case 14
                Words_1_19 = "Fourteen"
            Case 15
                Words_1_19 = "Fifteen"
            Case 16
                Words_1_19 = "Sixteen"
            Case 17
                Words_1_19 = "Seventeen"
            Case 18
                Words_1_19 = "Eightteen"
            Case 19
                Words_1_19 = "Nineteen"
            Case Else
                If num = 0 Then
                    Words_1_19 = ""
                Else
                    Words_1_19 = CStr(num)
                End If

                Exit Select
        End Select
        Return CStr(Words_1_19)
    End Function

    ' Return a word for this value between 1 and 99.
    Private Function Words_1_99(ByVal num As Integer) As String
        Dim result As String = Nothing
        Dim tens As Integer

        tens = num \ 10

        If tens <= 1 Then
            ' 1 <= num <= 19
            result = result & " " & Words_1_19(num)
        Else
            ' 20 <= num
            ' Get the tens digit word.
            Select Case tens
                Case 2
                    result = "Twenty"
                Case 3
                    result = "Thirty"
                Case 4
                    result = "Forty"
                Case 5
                    result = "Fifty"
                Case 6
                    result = "Sixty"
                Case 7
                    result = "Seventy"
                Case 8
                    result = "Eighty"
                Case 9
                    result = "Ninety"
            End Select

            ' Add the ones digit number.
            'If num > (num - (tens / 10)) Then
            If (num - tens * 10) <> 0 Then
                result = result & "-" & Words_1_19(num - tens * 10)
            End If

        End If

        Words_1_99 = Trim$(result)
    End Function
#End Region
#End Region

#Region "----- Sort TSV Files ----"
    ''' <summary>
    ''' Sorts the tsv by turning it into a datatable, applying a view filter, and then writing the result back to the tsv.
    ''' An Integer Or array Of integers representing the column numbers To sort On (In the order specified by the array).
    ''' The columns numbers are treated at being 1 based not 0 based.
    ''' 
    ''' This routine allows For delimiters In the data, which takes a little extra time And could be removed If you 
    ''' knew that your data would Not have a comma In it.
    ''' 
    ''' </summary>
    ''' <param name="sourceFile"></param>
    ''' <param name="sortColumns"></param>
    ''' 
    Friend Sub SortTsv(ByVal sourceFile As String, ByVal ParamArray sortColumns() As Integer)

        'create the datatable
        Dim dt As DataTable = TsvToTable(sourceFile)

        'build the sort column names
        If sortColumns.Length > 0 Then
            Dim sortStr As String = String.Empty
            For i As Integer = 0 To sortColumns.Length - 1
                If sortStr.Length > 0 Then sortStr &= ", "
                sortStr &= "Column" & sortColumns(i).ToString 'appends the sort column number to the end of "Column"
            Next

            'sort the table
            dt.DefaultView.Sort = sortStr
        End If
        TableToTSV(sourceFile, dt.DefaultView.ToTable)
    End Sub

    'Parses a tsv into a datatable  
    Private Function TsvToTable(ByVal filePathName As String) As DataTable
        Dim result As New DataTable
        If IO.File.Exists(filePathName) Then
            Dim parser As New FileIO.TextFieldParser(filePathName) With {
                .Delimiters = New String() {delimiter},
                .HasFieldsEnclosedInQuotes = False, 'set to True if data may contain delimiters  
                .TextFieldType = FileIO.FieldType.Delimited,
                .TrimWhiteSpace = True
            }

            While Not parser.EndOfData
                AddValuesToTable(parser.ReadFields, result)
            End While

            parser.Close()
        End If
        Return result
    End Function

    'Writes a datatable back into a tsv  
    Private Sub TableToTSV(ByVal sourceFile As String, ByVal sourceTable As DataTable)
        Dim sb As New Text.StringBuilder

        For Each dr As DataRow In sourceTable.Rows
            sb.AppendLine(String.Join(delimiter, Array.ConvertAll(dr.ItemArray,
            Function(o As Object) If(o.ToString.Contains(","),
            o.ToString, o.ToString))))
            'ControlChars.Quote & o.ToString & ControlChars.Quote, o.ToString)))) 'changed so that commas would be allowed - see if i need this anyways
        Next


        'IO.File.WriteAllText(DataPath & "\" & TextFileName, sb.ToString)
        File.WriteAllText(sourceFile, sb.ToString)

    End Sub

    'Ensures a datatable can hold an array of values and then adds a new row  
    Private Sub AddValuesToTable(ByVal source() As String, ByVal destination As DataTable)
        Dim existing As Integer = destination.Columns.Count
        For i As Integer = 0 To source.Length - existing - 1
            destination.Columns.Add("Column" & (existing + 1 + i).ToString, GetType(String))
        Next
        destination.Rows.Add(source)
    End Sub
#End Region

#Region "----- Reset all files -----"

#Region "----- Validate Reset and Start Proceedure -----"
    Private Sub ResetAllFiles_Click(sender As Object, e As EventArgs) Handles FactoryResetToolStripMenuItem.Click
        Dim intResponse As Integer
        Beep()
        intResponse = MsgBox("Are you sure you want to Reset All Files?" & vbCrLf & "You won't lose your text documents but" & vbCrLf & "you will lose all your data files.",
                            CType(vbYesNo + vbQuestion + vbDefaultButton2, MsgBoxStyle), "Delete")
        If intResponse = vbYes Then
            ReadSettings()
            SetUpProgram()
        End If
    End Sub

    Friend Sub SetUpProgram()

        'disable the form while the files are being created
        Enabled = False
#End Region

#Region "----- Delete Files -----"
        'Delete Files
        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & SettingsFile)
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & BiographyFile)
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & CategoryFile)
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & "500_Presidents.tsv")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & "502_Miscellaneous.tsv")
        Catch ex As Exception
        End Try

        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & "501_Wars.tsv")
        Catch ex As Exception
        End Try

#End Region

#Region "----- Create The Presidents Events -----"
        'Create Presidents File
        'record = (0) description, (1) date, (2) end date, (3) range
        WritePresEvents("President George Washington", "7/1/1789", "4/4/1797", "Yes")
        WritePresEvents("President John Adams", "4/4/1797", "4/4/1801", "Yes")
        WritePresEvents("President Thomas Jefferson", "4/4/1801", "4/4/1809", "Yes")
        WritePresEvents("President James Madison", "4/4/1809", "4/4/1817", "Yes")
        WritePresEvents("President James Monroe", "4/4/1817", "4/4/1825", "Yes")
        WritePresEvents("President John Q. Adams", "4/4/1825", "4/4/1829", "Yes")
        WritePresEvents("President Andrew Jackson", "4/4/1829", "4/4/1837", "Yes")
        WritePresEvents("President Martin Van Buren", "4/4/1837", "3/4/1841", "Yes")
        WritePresEvents("President William H. Harrison", "3/4/1841", "4/4/1841", "Yes")
        WritePresEvents("President John Tyler", "4/6/1841", "3/4/1845", "Yes")
        WritePresEvents("President James K. Polk", "3/4/1845", "3/4/1849", "Yes")
        WritePresEvents("President Zachary Taylor", "3/5/1849", "7/9/1850", "Yes")
        WritePresEvents("President Millard Fillmore", "7/10/1850", "3/4/1853", "Yes")
        WritePresEvents("President Franklin Pierce", "3/4/1853", "3/4/1857", "Yes")
        WritePresEvents("President James Buchanan", "3/4/1857", "4/4/1861", "Yes")
        WritePresEvents("President Abrham Lincoln", "3/4/1861", "4/15/1865", "Yes")
        WritePresEvents("President Andrew Johnson", "4/15/1865", "3/4/1869", "Yes")
        WritePresEvents("President Ulysses S. Grant", "3/4/1869", "3/4/1877", "Yes")
        WritePresEvents("President Rutherford B. Hayes", "3/4/1877", "3/4/1881", "Yes")
        WritePresEvents("President James Garfield", "3/4/1881", "9/19/1881", "Yes")
        WritePresEvents("President Chester A. Arthur", "9/20/1881", "3/4/1885", "Yes")
        WritePresEvents("President Grover Cleveland", "3/4/1885", "3/4/1889", "Yes")
        WritePresEvents("President Benjamin Harrison", "3/4/1889", "3/4/1893", "Yes")
        WritePresEvents("President Grover Cleveland", "3/4/1893", "3/4/1897", "Yes")
        WritePresEvents("President William McKinley", "3/4/1897", "9/14/1901", "Yes")
        WritePresEvents("President Theodore Roosevelt", "9/14/1901", "4/4/1909", "Yes")
        WritePresEvents("President William H. Taft", "3/4/1909", "3/4/1913", "Yes")
        WritePresEvents("President Woodrow Wilson", "3/4/1913", "3/4/1921", "Yes")
        WritePresEvents("President Warren Harding", "3/4/1921", "8/2/1923", "Yes")
        WritePresEvents("President Calvin Coolidge", "8/3/1923", "3/4/1929", "Yes")
        WritePresEvents("President Herbert Hoover", "3/4/1929", "3/4/1933", "Yes")
        WritePresEvents("President Franklin D Roosevelt", "3/4/1933", "4/12/1945", "Yes")
        WritePresEvents("President Harry S Truman", "4/12/1945", "1/20/1953", "Yes")
        WritePresEvents("President Dwight Eisenhower", "1/20/1953", "1/20/1961", "Yes")
        WritePresEvents("President John F. Kennedy", "1/20/1961", "11/22/1963", "Yes")
        WritePresEvents("President Lyndon Johnson", "11/22/1963", "1/20/1969", "Yes")
        WritePresEvents("President Richard Nixon", "1/20/1969", "8/9/1974", "Yes")
        WritePresEvents("President Gerald Ford", "8/9/1974", "1/20/1977", "Yes")
        WritePresEvents("President Jimmy Carter", "1/20/1977", "1/20/1981", "Yes")
        WritePresEvents("President Ronald Reagan", "1/20/1981", "1/20/1989", "Yes")
        WritePresEvents("President George H.W. Bush", "1/20/1989", "1/20/1993", "Yes")
        WritePresEvents("President Bill Clinton", "1/20/1993", "1/20/2001", "Yes")
        WritePresEvents("President George W. Bush", "1/20/2001", "1/20/2009", "Yes")
        WritePresEvents("PRESIDENT Barack Obama", "1/20/2009", "1/20/2017", "Yes")
        WritePresEvents("*         donald j. trump", "1/20/2017", "1/20/2021", "Yes")
        WritePresEvents("PRESIDENT Joe Biden", "1/20/2021", "1/20/2029", "Yes")
        WritePresEvents("President Kennedy Assassinated", "11/22/1963", "11/22/1963", "No")
        WritePresEvents("Robert Kennedy Assassinated", "6/6/1968", "6/6/1968", "No")
        WritePresEvents("President Lincoln Assassinated", "4/15/1865", "4/15/1865", "No")

        'add the category Miscellanous record to the category file
        Try
            'True appends the record to the file. False replaces the file.

            Dim prescatwriter As New StreamWriter(DataPath & "\" & CategoryFile, True)
            Dim presrecord As String = Nothing
            presrecord = Nothing
            presrecord = "500" & vbTab & "Presidents" & vbTab & "500_Presidents.tsv"
            prescatwriter.WriteLine(presrecord)
            prescatwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a Wars' Category Record.")
        End Try
#End Region

#Region "----- Create The Miscellaneous Events -----"
        'add the Miscellaneous category file with some records
        'record = (0) description, (1) date, (2) end date, (3) range (Yes/No)
        WriteMiscEvents("First Man on the Moon", "11/20/1969", "11/20/1969", "No")
        WriteMiscEvents("Martin Luther King Jr Assassinated", "4/4/1968", "4/4/1968", "No")
        WriteMiscEvents("Johnny Cash Died", "12/12/2003", "12/12/2003", "No")
        WriteMiscEvents("Wright Brothers first flight!", "12/17/1903", "12/17/1903", "No")
        WriteMiscEvents("Elvis Presley Died.", "8/16/1977", "8/16/1977", "No")
        WriteMiscEvents("Final Sequencing of the Human Genome!", "4/14/2003", "4/14/2003", "No")
        WriteMiscEvents("Katrina made Landfall in New Orleans", "8/29/2005", "8/29/2005", "No")
        WriteMiscEvents("Black Tuesday Stock Market Crash", "10/29/1929", "10/29/1929", "No")
        WriteMiscEvents("The Beatles First arrive in America!", "2/7/1964", "2/7/1964", "No")


        'add the category Miscellanous record to the category file
        Try
            'True appends the record to the file. False replaces the file.

            Dim warcatwriter As New StreamWriter(DataPath & "\" & CategoryFile, True)
            Dim catrecord As String = Nothing
            catrecord = Nothing
            catrecord = "502" & vbTab & "Miscellaneous" & vbTab & "502_Miscellaneous.tsv"
            warcatwriter.WriteLine(catrecord)
            warcatwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a Wars' Category Record.")
        End Try
#End Region

#Region "----- Create The War Events -----"
        'Create Wars File
        'record = (0) description, (1) date, (2) end date, (3) range

        WriteWarsEvents("Terrorist Attack on World Trade Center", "9/11/2001", "9/11/2001", "No")
        WriteWarsEvents("Attack on Pearl Harbor", "12/2/1941", "12/2/1941", "No")
        WriteWarsEvents("World War I began", "7/28/1914", "7/28/1914", "No")
        WriteWarsEvents("World War I ends", "11/11/1918", "11/11/1918", "No")
        WriteWarsEvents("World War II began", "11/1/1939", "11/1/1939", "No")
        WriteWarsEvents("World War II ends", "9/2/1945", "9/2/1945", "No")
        WriteWarsEvents("Vietnam Era Started for Veterans", "2/28/1961", "2/28/1961", "No")
        WriteWarsEvents("Vietnam Era Ended for Veterans", "5/7/1975", "5/7/1975", "No")
        WriteWarsEvents("American Revolutionary War began", "4/19/1775", "4/19/1775", "No")
        WriteWarsEvents("American Revolutionary War ended", "9/3/1783", "9/3/1783", "No")
        WriteWarsEvents("Korean War began", "6/25/1950", "6/25/1950", "No")
        WriteWarsEvents("Korean War ended", "7/27/1953", "7/27/1953", "No")
        WriteWarsEvents("Civil War Began", "4/12/1861", "4/12/1861", "No")
        WriteWarsEvents("Civil War Ended", "4/9/1865", "4/9/1865", "No")
        WriteWarsEvents("Atom Bomb droped on Hiroshima", "8/6/1945", "8/6/1945", "No")
        WriteWarsEvents("Atom Bomb droped on Nagasaki", "8/9/1945", "8/9/1945", "No")
        WriteWarsEvents("Gulf War starts", "8/2/1990", "8/2/1990", "No")
        WriteWarsEvents("Gulf War ends", "2/28/1991", "2/28/1991", "No")
        WriteWarsEvents("The U.S. War in Afghanistan started", "10/7/2001", "10/7/2001", "No")
        WriteWarsEvents("The U.S. War in Iraq started", "3/20/2003", "3/20/2003", "No")
        WriteWarsEvents("The U.S. War in Iraq ended", "12/18/2011", "12/18/2011", "No")
        WriteWarsEvents("U.S. involved in 134 'wars' ~ PRX", "9/16/2014", "9/16/2014", "No")
        WriteWarsEvents("The U.S. has been at war 225 out of 243 years since 1776 ~ The News", "1/9/2020", "1/9/2020", "No")

        'add the category war record to the category file
        Try
            'True appends the record to the file. False replaces the file.

            Dim warcatwriter As New StreamWriter(DataPath & "\" & CategoryFile, True)
            Dim catrecord As String = Nothing
            catrecord = Nothing
            catrecord = "501" & vbTab & "Wars" & vbTab & "501_Wars.tsv"
            warcatwriter.WriteLine(catrecord)
            warcatwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a Wars' Category Record.")
        End Try
#End Region

#Region "----- Create The Biographies & End Reset -----"

        ReadSettings()
        'Create Biography File
        'biography record = (0) id, (1) name, (2) birth date, (3) living Yes/No, (4) death date, (5) nickname
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Clara Dennison Hobart", "9/24/1885", "No", "10/16/1968", "Bimmie")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Eleanor Soper", "8/2/1904", "No", "11/16/1981", "Grammie Soper")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Emily Jean Blatt", "7/24/1985", "Yes", "12/3/2005", "Emily")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Janice Lynn DeMille", "10/10/1953", "Yes", "12/3/2005", "Janice")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Jonathan James Benner", "12/21/1988", "Yes", "12/3/2005", "Jon")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Peter Jason Jenkins", "3/24/1971", "Yes", "12/3/2005", "Pete")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Phyllis Evelyn Farris", "7/2/1916", "No", "12/17/1990", "Grammie Benner")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Reginia Ray Joice", "6/4/1952", "Yes", "12/3/2005", "Gina")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Virginia May Jenkins", "6/22/1935", "No", "6/18/1976", "Ginny")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Patricia Ann Benner", "4/8/1940", "No", "8/11/2016", "Aunt Pat")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Sylvia Ann Angel", "6/7/1931", "No", "6/2/2008", "Aunt Sylvia")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Florence Elizabeth Tucker", "4/1/1896", "No", "7/1/1979", "Nana")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Lawrence Wayne Benner", "5/15/1955", "Yes", "12/3/2005", "Larry")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "David Wesley Benner", "5/15/1955", "Yes", "12/3/2005", "David")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Reginald Raymond Benner", "4/26/1932", "No", "12/5/2005", "Reggie")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Carl Harold Benner", "5/6/1908", "No", "7/12/1983", "Grampa Benner")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "John C Benner", "8/14/1880", "No", "1/12/1952", "John")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "John Huddleston Benner", "1/31/1850", "No", "9/9/1913", "John")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Abner Gardner Benner", "10/20/1812", "No", "5/14/1891", "Abner")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Christopher Benner Jr", "11/9/1791", "No", "3/19/1862", "Christopher")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Christopher Henry Benner", "5/24/1757", "No", "9/8/1842", "Christopher")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Philip Earl Jenkins", "3/31/1936", "No", "12/28/1989", "Phil")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Peter Jason Jenkins", "2/23/1971", "Yes", "12/3/2005", "Pete")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Earle R Angell", "7/18/1926", "No", "5/26/1998", "Earle")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "William DeMille", "12/15/1951", "No", "12/3/2005", "Bill")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Dwight Joice", "10/10/1946", "No", "12/3/2005", "Dwight")


        SaveSettings()

        'all done creating the files - enable the form
        Enabled = True
    End Sub
#End Region

#Region "----- Sub Routines For Writing The Setup Files -----"
    Public Sub WriteWarsEvents(name As String, startterm As String, endterm As String, daterange As String)

        Try
            'True appends the record to the file. False replaces the file.
            'record = (0) description, (1) date, (2) end date, (3) range

            Dim warwriter As New StreamWriter(DataPath & "\" & "501_Wars.tsv", True)
            Dim record As String = Nothing
            record = Nothing
            record = name & vbTab & startterm & vbTab & endterm & vbTab & daterange
            warwriter.WriteLine(record)
            warwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a Wars' record.")

        End Try
    End Sub

    Public Sub WriteMiscEvents(name As String, startterm As String, endterm As String, daterange As String)

        Try
            'True appends the record to the file. False replaces the file.
            'record = (0) description, (1) date, (2) end date, (3) range

            Dim warwriter As New StreamWriter(DataPath & "\" & "502_Miscellaneous.tsv", True)
            Dim record As String = Nothing
            record = Nothing
            record = name & vbTab & startterm & vbTab & endterm & vbTab & daterange
            warwriter.WriteLine(record)
            warwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a Miscellaneous record.")

        End Try
    End Sub
    Public Sub WritePresEvents(name As String, startterm As String, endterm As String, daterange As String)

        Try
            'True appends the record to the file. False replaces the file.
            'record = (0) description, (1) date, (2) end date, (3) range

            Dim presidentwriter As New StreamWriter(DataPath & "\" & "500_Presidents.tsv", True)
            Dim record As String = Nothing
            record = Nothing
            record = name & vbTab & startterm & vbTab & endterm & vbTab & daterange
            presidentwriter.WriteLine(record)
            presidentwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a President's record.")

        End Try
    End Sub


    ''' <summary>
    ''' biography record = (0) id, (1) name, (2) birth date, (3) living Yes/No, (4) death date, (5) nickname
    ''' </summary>
    ''' <param name="path"></param>
    ''' <param name="filename"></param>
    ''' <param name="recordnumber"></param>
    ''' <param name="name"></param>
    ''' <param name="birthdate"></param>
    ''' <param name="living"></param>
    ''' <param name="deathdate"></param>
    ''' <param name="nickname"></param>
    Public Sub WriteBiographies(ByVal path As String, filename As String, recordnumber As String,
                ByVal name As String, ByVal birthdate As String,
                ByVal living As String, ByVal deathdate As String, nickname As String)

        Try
            Dim biographywriter As New StreamWriter(path & "\" & filename, True) 'True appends the record to the file. False replaces the file.
            Dim record As String = recordnumber & vbTab & name & vbTab & birthdate & vbTab &
                living & vbTab & deathdate & vbTab & nickname
            biographywriter.WriteLine(record)
            biographywriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Failed in the WriteToFile " & filename)

        End Try
    End Sub

#End Region

#End Region


    Private Sub DtpYearOnly_ValueChanged(sender As Object, e As EventArgs) Handles DtpYearOnly.ValueChanged
        If DtpYearOnly.Checked Then
            DisplayTextFile(TextFileName)
            'MsgBox("Checked " & DtpYearOnly.Value.Year)
        Else
            DisplayTextFile(TextFileName)
            'MsgBox("Unchecked")
        End If
    End Sub

    Private Sub RtxBiography_TextChanged(sender As Object, e As EventArgs) Handles RtxBiography.TextChanged
        If LblFileName.Text <> "* " & Trim(OpenFileDialog1.FileName) Then
            LblFileName.Text = "* " & Trim(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
