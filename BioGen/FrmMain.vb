'------------- Header --------------------
' Author: David Wesley Benner
' Date: 6/14/2020
' Purpose: To generate a persons biography
' Change Log: 
'   6/17/2020 - Created merged database file
'   6/26/2020 - Added view checkboxes (presidents/birthdays/events)
' -----------------------------------------

Imports System.IO

Public Class FrmMain

#Region "***** Initialization *****"
    Dim ind As Byte = 0 'used in the tool strip menu ... it was added for the edit box menu
    Dim url As String 'used in the tool strip menu ... it was added for the edit box menu

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtxBiography.Select() 'set the focus in the biography editor a richtextbox
    End Sub


    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        LblTimer.Text = Format(Date.Now, "dddd       MMMM d, yyyy       h:mm:ss  tt ")
    End Sub
#End Region

#Region "***** Sort *****"
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

#Region "***** Functions (CnvDate & Turn numbers to words) *****"
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

#Region "***** Menu Items *****"

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Enabled = False
        FrmNewBio.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Enabled = False
        FrmOpenBiography.Show()
    End Sub

    Private Sub FactoryResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactoryResetToolStripMenuItem.Click
        Dim intResponse As Integer
        Beep()
        intResponse = MsgBox("Are you sure you want to Reset All Files?" & vbCrLf & "You won't lose your text documents but" & vbCrLf & "you will lose all your data files.",
                            CType(vbYesNo + vbQuestion + vbDefaultButton2, MsgBoxStyle), "Delete")
        If intResponse = vbYes Then
            SetUpProgram()
        End If
    End Sub



#End Region

#Region "*** Reset all files (SetUpProgram) *****"

    Friend Sub SetUpProgram()

        'disable the form while the files are being created
        Enabled = False

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
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & PresidentsFile)
        Catch ex As Exception
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & EventsFile)
        Catch ex As Exception
        End Try

        'Create Biography File
        'biography record = (0) id, (1) name, (2) birth date, (3) living Yes/No, (4) death date, (5) nickname
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Clara Dennison Hobart", "9/24/1885", "No", "10/16/1968", "Bimmie")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Eleanor Soper", "8/2/1904", "No", "11/16/1981", "Grammie Soper")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Emily Jean Blatt", "7/24/1985", "Yes", "12/5/2005", "Emily")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Janice Lynn DeMille", "10/10/1953", "Yes", "12/5/2005", "Janice")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Jonathan James Benner", "12/21/1988", "Yes", "12/5/2005", "Jon")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Peter Jason Jenkins", "3/24/1971", "Yes", "12/5/2005", "Pete")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Phyllis Evelyn Farris", "7/2/1916", "No", "12/17/1990", "Grammie Benner")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Reginia Ray Joice", "6/4/1952", "Yes", "12/2/2005", "Gina")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Virginia May Jenkins", "6/22/1935", "No", "6/18/1976", "Ginny")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Patricia Ann Benner", "4/8/1940", "No", "8/11/2016", "Aunt Pat")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Sylvia Ann Angel", "6/7/1931", "No", "6/2/2008", "Aunt Sylvia")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Florence Elizabeth Tucker", "4/1/1896", "No", "7/1/1979", "Nana")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "Lawrence Wayne Benner", "5/15/1955", "Yes", "12/5/2005", "Larry")
        RecordID += 1
        WriteBiographies(DataPath, BiographyFile, CStr(RecordID), "David Wesley Benner", "5/15/1955", "Yes", "12/5/2005", "David")
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

        'Create Events File
        'events record = (0) type "Evnt", (1) date, (2) description

        RecordID += 1
        WriteEvents("Evnt", "11/22/1963", "President Kennedy Assassinated")
        RecordID += 1
        WriteEvents("Evnt", "11/20/1969", "First Man on the Moon")
        RecordID += 1
        WriteEvents("Evnt", "9/11/2001", "Terrorist Attack on World Trade Center")
        RecordID += 1
        WriteEvents("Evnt", "12/2/1941", "Attack on Pearl Harbor")
        RecordID += 1
        WriteEvents("Evnt", "6/6/1968", "Robert Kennedy Assassinated")
        RecordID += 1
        WriteEvents("Evnt", "4/15/1865", "President Lincoln Assassinated")
        RecordID += 1
        WriteEvents("Evnt", "4/4/1968", "Martin Luther King Jr Assassinated")
        RecordID += 1
        WriteEvents("Evnt", "12/12/2003", "Johnny Cash Died")
        RecordID += 1
        WriteEvents("Evnt", "12/17/1903", "Wright Brothers first flight!")
        RecordID += 1
        WriteEvents("Evnt", "8/16/1977", "Elvis Presley Died.")
        RecordID += 1
        WriteEvents("Evnt", "4/14/2003", "Final Sequencing of the Human Genome!")
        RecordID += 1
        WriteEvents("Evnt", "8/29/2005", "Katrina made Landfall in New Orleans")
        RecordID += 1
        WriteEvents("Evnt", "10/29/1929", "Black Tuesday - Stock Market Crash")
        RecordID += 1
        WriteEvents("Evnt", "7/28/1914", "World War I began.")
        RecordID += 1
        WriteEvents("Evnt", "11/11/1918", "World War I ends.")
        RecordID += 1
        WriteEvents("Evnt", "11/1/1939", "World War II began.")
        RecordID += 1
        WriteEvents("Evnt", "9/2/1945", "World War II ends.")
        RecordID += 1
        WriteEvents("Evnt", "2/28/1961", "Vietnam Era Started for Veterans.")
        RecordID += 1
        WriteEvents("Evnt", "5/7/1975", "Vietnam Era Ended for Veterans.")
        RecordID += 1
        WriteEvents("Evnt", "2/7/1964", "The Beatles First arrive in America!")
        RecordID += 1
        WriteEvents("Evnt", "7/1/1979", "Nana died sometime in 1979")
        RecordID += 1
        WriteEvents("Evnt", "4/19/1775", "American Revolutionary War began")
        RecordID += 1
        WriteEvents("Evnt", "9/3/1783", "American Revolutionary War ended")
        RecordID += 1
        WriteEvents("Evnt", "6/25/1950", "Korean War began")
        RecordID += 1
        WriteEvents("Evnt", "7/27/1953", "Korean War ended")
        RecordID += 1
        WriteEvents("Evnt", "4/12/1861", "Civil War Began")
        RecordID += 1
        WriteEvents("Evnt", "4/9/1865", "Civil War Ended")

        'Create Presidents File
        'presidents record = (0) number of their presidency, (2) name, (3) term begin date, (4) term end date
        WritePresidents("1", "George Washington", "7/1/1789", "4/4/1797")
        WritePresidents("2", "John Adams", "4/4/1797", "4/4/1801")
        WritePresidents("3", "Thomas Jefferson", "4/4/1801", "4/4/1809")
        WritePresidents("4", "James Madison", "4/4/1809", "4/4/1817")
        WritePresidents("5", "James Monroe", "4/4/1817", "4/4/1825")
        WritePresidents("6", "John Q. Adams", "4/4/1825", "4/4/1829")
        WritePresidents("7", "Andrew Jackson", "4/4/1829", "4/4/1837")
        WritePresidents("8", "Martin Van Buren", "4/4/1837", "3/4/1841")
        WritePresidents("9", "William H. Harrison", "3/4/1841", "4/4/1841")
        WritePresidents("10", "John Tyler", "4/6/1841", "3/4/1845")
        WritePresidents("11", "James K. Polk", "3/4/1845", "3/4/1849")
        WritePresidents("12", "Zachary Taylor", "3/5/1849", "7/9/1850")
        WritePresidents("13", "Millard Fillmore", "7/10/1850", "3/4/1853")
        WritePresidents("14", "Franklin Pierce", "3/4/1853", "3/4/1857")
        WritePresidents("15", "James Buchanan", "3/4/1857", "4/4/1861")
        WritePresidents("16", "Abrham Lincoln", "3/4/1861", "4/15/1865")
        WritePresidents("17", "Andrew Johnson", "4/15/1865", "3/4/1869")
        WritePresidents("18", "Ulysses S. Grant", "3/4/1869", "3/4/1877")
        WritePresidents("19", "Rutherford B. Hayes", "3/4/1877", "3/4/1881")
        WritePresidents("20", "James Garfield", "3/4/1881", "9/19/1881")
        WritePresidents("21", "Chester A. Arthur", "9/20/1881", "3/4/1885")
        WritePresidents("22", "Grover Cleveland", "3/4/1885", "3/4/1889")
        WritePresidents("23", "Benjamin Harrison", "3/4/1889", "3/4/1893")
        WritePresidents("24", "Grover Cleveland", "3/4/1893", "3/4/1897")
        WritePresidents("25", "William McKinley", "3/4/1897", "9/14/1901")
        WritePresidents("26", "Theodore Roosevelt", "9/14/1901", "4/4/1909")
        WritePresidents("27", "William H. Taft", "3/4/1909", "3/4/1913")
        WritePresidents("28", "Woodrow Wilson", "3/4/1913", "3/4/1921")
        WritePresidents("29", "Warren Harding", "3/4/1921", "8/2/1923")
        WritePresidents("30", "Calvin Coolidge", "8/3/1923", "3/4/1929")
        WritePresidents("31", "Herbert Hoover", "3/4/1929", "3/4/1933")
        WritePresidents("32", "Franklin D Roosevelt", "3/4/1933", "4/12/1945")
        WritePresidents("33", "Harry S Truman", "4/12/1945", "1/20/1953")
        WritePresidents("34", "Dwight Eisenhower", "1/20/1953", "1/20/1961")
        WritePresidents("35", "John F. Kennedy", "1/20/1961", "11/22/1963")
        WritePresidents("36", "Lyndon Johnson", "11/22/1963", "1/20/1969")
        WritePresidents("37", "Richard Nixon", "1/20/1969", "8/9/1974")
        WritePresidents("38", "Gerald Ford", "8/9/1974", "1/20/1977")
        WritePresidents("39", "Jimmy Carter", "1/20/1977", "1/20/1981")
        WritePresidents("40", "Ronald Reagan", "1/20/1981", "1/20/1989")
        WritePresidents("41", "George H.W. Bush", "1/20/1989", "1/20/1993")
        WritePresidents("42", "Bill Clinton", "1/20/1993", "1/20/2001")
        WritePresidents("43", "George W. Bush", "1/20/2001", "1/20/2009")
        WritePresidents("44", "Barack Obama", "1/20/2009", "1/20/2017")
        WritePresidents("45", "Donald J. Trump", "1/20/2017", "1/20/2021")
        WritePresidents("46", "Joe Biden", "1/20/2021", "1/20/2029")

        SaveSettings()
        'settings file = (0) record id - used for all added records

        'all done creating the files - enable the form
        Enabled = True
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

    ''' <summary>
    ''' presidents record = (0) number of their presidency, (2) name, (3) term begin date, (4) term end date
    ''' </summary>
    ''' <param name="nbr"></param>
    ''' <param name="name"></param>
    ''' <param name="startterm"></param>
    ''' <param name="endterm"></param>
    Public Sub WritePresidents(nbr As String, name As String, startterm As String, endterm As String)
        Try
            'True appends the record to the file. False replaces the file.
            Dim presidentwriter As New StreamWriter(DataPath & "\" & PresidentsFile, True)
            Dim record As String = Nothing
            RecordID += 1
            record = Nothing
            record = RecordID & vbTab & nbr & vbTab & name & vbTab & startterm & vbTab & endterm
            presidentwriter.WriteLine(record)
            presidentwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a President's record.")

        End Try

    End Sub

    ''' <summary>
    ''' events record = (0) type "Evnt", (1) date, (2) description
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="evntdate"></param>
    ''' <param name="description"></param>
    Public Sub WriteEvents(type As String, evntdate As String, description As String)

        Try
            'True appends the record to the file. False replaces the file.
            Dim eventswriter As New StreamWriter(DataPath & "\" & EventsFile, True)
            Dim record As String = Nothing
            record = type & vbTab & evntdate & vbTab & description
            eventswriter.WriteLine(record)
            eventswriter.Close()
        Catch ex As Exception
            Beep()
            Dim unused = MsgBox("Error trying to write an Events record.")
        End Try

    End Sub

#End Region

#Region "***** Web Items *****"
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

#Region "***** Editing Features for the document editor *****"
    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim nextForm As New FrmMain
        nextForm.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save Text Files"
        SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* "
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True


        Try
            RtxBiography.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText) ' may want to change this to RichText
        Catch ex As Exception
            Call SaveAsToolStripMenuItem_Click(Me, e)
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Title = "Save Text Files"
        SaveFileDialog1.CheckFileExists = False
        SaveFileDialog1.CheckPathExists = False
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.* "
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            RtxBiography.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText) ' may want to change this to RichText
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Close()
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

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If RtxBiography.SelectionLength > 0 Then
            RtxBiography.Text = ""
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RtxBiography.SelectAll()
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        RtxBiography.SelectedText = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = RtxBiography.Font
        FontDialog1.ShowDialog()
        RtxBiography.Font = FontDialog1.Font
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

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

#Region "***** Generate the Databases *****"
    Friend Sub BioGenDatabase(ByVal filename As String)


        'set type = True for the AllDatabaseFile and False for individual files
        Dim individual As Boolean 'set to True for individual biography database and False for the all inclusive database
        If filename = AllDatabaseFile Then
            TextFileName = AllDatabaseFile
            individual = False 'build all inclusive database
        Else
            TextFileName = filename
            individual = True 'build database for this biography only
        End If

        '----- Miscellaneous biography stuff -----
        'BiographyFile - name of the tsv file
        'BiographyArray - Holds all the biography string records
        'SelectedBiography - Holds the string of the selected biography record
        'BiographyArrayIndex - 'Holds the currently selected BiographyArray index
        'BiographyRecord() - Holds the currently selected record variables

        '----- Description of the Biography Record Fields -----
        '0 - BioID - generated by the program. Increases the RecordID variable before each record is created. RecordID is stored in the settings file
        '1 - BioName - the name of the person
        '2 - BioBirthDate - the birthdate of the person
        '3 - BioSex - the sex of the person (Male/Female/Other)
        '4 - BioLiving - is this person still alive (Yes/No)
        '5 - BioDeathDate - the person's death date. Defaults to 12/5/2005 if they are still living (my father's death date)
        '6 - CatBirthdays - include birthdays in this person's biography (Yes/No)
        '7 - CatPresidents - include presidents in this person's biography (Yes/No)
        '8 - BioNickName - the persons nickname. Defaults to their first name if they don't have one

        ''SET THE TextFileName VARIABLE
        'If individual Then
        '    TextFileName = BiographyRecord(0) & "_" & BiographyRecord(1).Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename
        'Else
        '    TextFileName = AllDatabaseFile
        'End If

        'IF TextFileName EXISTS ALREADY, DELETE IT AND START FRESH
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

                    'Create the Record Array
                    BiographyRecord = Split(biographyReader.ReadLine(), delimiter) '** Module Array ** holds the fields of the currently selected record

                    'if individual only do for them otherwise do for all records
                    If (individual And (CInt(BiographyRecord(0)) = BioID)) Or Not individual Then

                        'Write the birth record
                        '(0) "Biog" for biography record
                        '(1) sort date = BiographyRecord(2) / BioBirthDate
                        '(2) name = BiographyRecord(1) / BioName
                        sortdate = CStr(CDate(BiographyRecord(2)).Ticks) ' BioBirthDate - convert to ticks for sorting purposes
                        'record = type, birth date, name, death date
                        'record = "Biog" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(5)

                        'birth record = type' vbtab birthdate in ticks' vbtab name
                        record = "Biog" & vbTab & sortdate & vbTab & BiographyRecord(1)
                        filewriter.WriteLine(record)

                        'Write the death record to the database
                        '(0) "Dead" for death record
                        '(1) sort date = BiographyRecord(5) / BioDeathDate
                        '(2) name = BiographyRecord(1) / BioName
                        '(3) birth date = BiographyRecord(2) / BioBirthDate (needed to calculate age at death)
                        sortdate = CStr(CDate(BiographyRecord(4)).Ticks) ' convert to ticks for sorting purposes
                        If BiographyRecord(3) = "No" Then ' Create a death record
                            'record = type, death date, name, birth date
                            record = "Dead" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                            filewriter.WriteLine(record)
                        End If

                        'Write the BIRTHDAY records to the database
                        '(0) "Bday" for birthday record
                        '(1) sort date = Calculated birthday date
                        '(2) name = BiographyRecord(1) / BioName
                        '(3) birth date = BiographyRecord(2) / BioBirthDate (needed to calculate age at birthday)

                        'If (individual And BiographyRecord(6) = "Yes") Or Not individual Then 'if catbirthdays - BiographyRecord(6) = "Yes" or all inclusive do
                        'Create the birthday records
                        Dim monthsValue As Integer = 12 'used to increase the birthdate by one year
                        Dim newDate As Date = CDate(BiographyRecord(2)) '= DateAdd(DateInterval.Month, monthsValue, dateValue)
                        If BiographyRecord(3) = "Yes" Then 'this person is still living
                            Do While newDate < Now
                                newDate = DateAdd(DateInterval.Month, monthsValue, newDate) 'calculate next birthday
                                If newDate < Now Then
                                    sortdate = CStr(newDate.Ticks) ' convert to ticks for sorting purposes

                                    'Type, birthday, name, living?, birthdate
                                    record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                    filewriter.WriteLine(record)
                                End If
                            Loop
                        Else    'this person has passed away
                            Do While newDate < CDate(BiographyRecord(4))
                                newDate = DateAdd(DateInterval.Month, monthsValue, newDate) 'calculate next birthday
                                If newDate < CDate(BiographyRecord(4)) Then 'calculate only while they were alive
                                    sortdate = CStr(newDate.Ticks) ' convert to ticks for sorting purposes

                                    'Type, birthday, name, living?, birthdate
                                    'record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                    record = "Bday" & delimiter & sortdate & delimiter & BiographyRecord(1) & delimiter & BiographyRecord(2)
                                    filewriter.WriteLine(record)
                                End If
                            Loop
                        End If
                        'Else
                        'End If
                    End If
                Loop
                biographyReader.Close()
                filewriter.Close()
            End Using

        Catch ex As Exception
        End Try

        'create the presidents file if the individual wants it or if it's all inclusive
        ' If (individual And CatPresidents = "Yes") Or Not individual Then
        Dim presrecord As String 'tab deliminated record
        Try
            Dim presidentReader As New System.IO.StreamReader(DataPath & "\" & PresidentsFile)
            Dim filewriter As New StreamWriter(DataPath & "\" & TextFileName, True) 'True appends the record to the file. False replaces the file.
            Dim sortdate As String
            Dim record As String
            Do While presidentReader.Peek <> -1
                presrecord = presidentReader.ReadLine()
                Dim currentRecord() As String = Split(presrecord, delimiter) 'create fields

                'assign president's variables
                PresName = currentRecord(2)
                PresBeginTerm = CDate(currentRecord(3))
                sortdate = CStr(PresBeginTerm.Ticks) ' convert to ticks for sorting purposes
                'presidents textfile record
                '(0) type "Pres"
                '(1) start of presidency PresBeginTerm / Presidents(3)
                '(2) President's name
                '(3) end term
                record = "Pres" & delimiter & sortdate & delimiter & PresName & vbTab & currentRecord(3)
                filewriter.WriteLine(record)
            Loop
            presidentReader.Close()
            filewriter.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & PresidentsFile & " file")
        End Try

        ' End If


        'Process The events
        Dim eventrecord As String 'tab deliminated record
        Try
            Dim eventReader As New System.IO.StreamReader(DataPath & "\" & EventsFile)
            Dim filewriter As New StreamWriter(DataPath & "\" & TextFileName, True) 'True appends the record to the file. False replaces the file.

            Do While eventReader.Peek <> -1

                eventrecord = eventReader.ReadLine()
                Dim sortdate As String
                Dim currentRecord() As String = Split(eventrecord, delimiter) 'create fields
                sortdate = CStr(CDate(currentRecord(1)).Ticks) ' convert to ticks for sorting purposes
                'Description of the Events Record
                'Event(0)       Type - "Evnt"  for event record vrs other types like "Biog" for a biography record or "Pres" for a President record
                'Event(1)       Date - Date in ticks of the event (for sorting)
                'Event(2)       Description - Text of the event
                'Event(3)       The record id unique to this record
                'Event(4)       The biography record id (BioID) or "1955" to mean that it belongs in all the biographies
                'Event(5)       The biography name (BioName) or "Universal" for all biographies

                eventrecord = "Evnt" & delimiter & CDate(currentRecord(1)).Ticks.ToString & delimiter & currentRecord(2)
                filewriter.WriteLine(eventrecord)
            Loop

            eventReader.Close()
            filewriter.Close()
        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & EventsFile & " file")
        End Try

        'sort the database
        SortTsv(DataPath & "\" & TextFileName, New Integer() {2, 3})

    End Sub

#End Region

#Region "**** Catagories *****"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folderInfo As New IO.DirectoryInfo(DataPath) 'Or whatever dir path
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo
        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder
            CheckedListBox1.Items.Add(fileInFolder.Name)
        Next
    End Sub

#End Region

#Region "***** Display the TextFiles *****"
    Friend Sub DisplayTextFile(ByVal textfile As String)
        TxtFacts.Clear() 'clear the textbox

        'read the textfile and process each record
        Try
            Dim outputtext As New System.Text.StringBuilder 'build the string to be put in the text box. this will include the entire textfile
            Dim textfilereader As New IO.StreamReader(DataPath & "\" & textfile)

            'process the textfile
            Do While textfilereader.Peek <> -1 'see if there is another record to process
                Dim recordstring = textfilereader.ReadLine() 'read the next record
                Dim recordarray() As String = Split(recordstring, vbTab) 'create the record fields
                Select Case recordarray(0) 'type of record
                    Case "Biog" 'birth record
                        'birth record = (0) type (1) birthdate in ticks, (2) name

                        Dim birthdate = New Date(Convert.ToInt64(recordarray(1)))
                        outputtext.Append("   " & recordarray(2) & " BORN on ")
                        outputtext.Append(CnvDate(CStr(birthdate)))
                        outputtext.Append(vbCrLf & vbCrLf)

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

                    Case "Pres" 'president record
                        'presidents record (0) type, (1) date term began (2) name

                        If FrmSelectView.CbxPresidents.Checked Then
                            outputtext.Append("   PRESIDENT " & recordarray(2) & " took the oath on ")
                            Dim termdate = New DateTime(Convert.ToInt64(recordarray(1)))
                            outputtext.Append(" - " & CnvDate(CStr(termdate)))
                            outputtext.Append(vbCrLf & vbCrLf)
                        End If
                    Case "Evnt" 'event record
                        'event record = (0) type, (1) date of event in ticks (2) description of event

                        If FrmSelectView.CbxEvents.Checked Then
                            Dim eventdate As New DateTime(Convert.ToInt64(recordarray(1)))
                            outputtext.Append("   " & recordarray(2).ToUpper & " on ")
                            outputtext.Append(CnvDate(eventdate.ToShortDateString))
                            outputtext.Append(vbCrLf & vbCrLf)
                        End If
                    Case Else
                        MsgBox("Unknown type of record. Can't display. Record: " & recordstring)
                End Select
            Loop
            TxtFacts.Text = Nothing
            TxtFacts.Text = outputtext.ToString
            outputtext.Clear()
            textfilereader.Close()
        Catch ex As Exception
            MsgBox("Somethin went wrong in the DisplayTextFile(textfile) routine")
        End Try
    End Sub

    Private Sub BtnSelectView_Click(sender As Object, e As EventArgs) Handles BtnSelectView.Click
        FrmSelectView.Show()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        FrmOpenBiography.BtnOption.Text = "Select"
        FrmOpenBiography.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FrmNewBio.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        FrmOpenBiography.BtnOption.Text = "Edit"
        FrmOpenBiography.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        FrmOpenBiography.BtnOption.Text = "Delete"
        FrmOpenBiography.Show()
    End Sub

    Private Sub NewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem2.Click
        FrmCatagory.BtnOption.Text = "Save"
        FrmCatagory.Show()
    End Sub


#End Region

End Class
