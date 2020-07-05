Imports System.IO

Public Class FrmOpenCategory
    Dim indx As Integer 'used to hold the index of the item selected


    Private Sub FrmOpenCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmMain.LblCategory.Visible = False
        LoadCategory()
    End Sub
    Private Sub LoadCategory()
        'sort the biography file
        FrmMain.SortTsv(DataPath & "\" & CategoryFile, New Integer() {2}) 'sort column is 1 based not 0
        LstvSelectCategory.Items.Clear() 'clears the listviewbox
        Try
            Using categoryReader As New StreamReader(DataPath & "\" & CategoryFile)
                Dim indx As Integer = 0 'index number to use for the tempbiographyarray
                Do While categoryReader.Peek <> -1 'see if there is another record to process
                    CategoryArray(indx) = categoryReader.ReadLine()
                    Dim temprecord() As String = Split(CategoryArray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                    LstvSelectCategory.Items.Add(temprecord(1)) 'display name
                    LstvSelectCategory.Items(indx).SubItems.Add(temprecord(1)) 'display Living (Yes/No)
                    indx += 1   'Increase the index for use on the next record
                Loop
                categoryReader.Close()
            End Using

        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & CategoryFile & " file")
        End Try

    End Sub

    Private Sub LstvSelectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstvSelectCategory.SelectedIndexChanged
        Try
            Dim tempcategoryrecord() As String
            indx = LstvSelectCategory.SelectedIndices(0)
            tempcategoryrecord = Split(CategoryArray(indx), delimiter) '** Module Array - fills the array with the records variables
            SelectedCategoryID = CInt(tempcategoryrecord(0))
            SelectedCategoryName = tempcategoryrecord(1)
            SelectedCategoryFile = tempcategoryrecord(2)
            'FrmMain.EventsToolStripMenuItem.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Select"
                FrmMain.LblCategory.Text = SelectedCategoryName
                FrmMain.LblCategory.Visible = True
                CreateCategoryEvents() 'create the events text file to be displayed (EventsTextFile)
                DisplayCategoryEvents() 'displays the events for the selected category
                Close()
            Case "Rename"
                'FrmCatagory.Text = "Edit Category"
                FrmCatagory.BtnOption.Text = "Rename"
                FrmCatagory.TxtName.Text = SelectedCategoryName
                FrmCatagory.Show()
                Close()
            Case "Delete"
                Beep()
                If MsgBox("Are you sure you want to delete " & SelectedCategoryName & "?", CType(vbYesNo + vbQuestion, Global.Microsoft.VisualBasic.MsgBoxStyle), "Quit") = vbYes Then
                    DeleteRecord(DataPath, CategoryFile, CStr(SelectedCategoryID), 0)
                    Try
                        My.Computer.FileSystem.DeleteFile(DataPath & "\" & SelectedCategoryFile)
                    Catch ex As Exception
                    End Try
                    LoadCategory()
                End If
                BtnOption.Text = "Select"
            Case Else
                MsgBox("Unknow case in FrmOpenCategory: " & BtnOption.Text)
                Close()
        End Select
    End Sub

#Region "***** Generate the CategoryDisplayFile *****"
    Friend Sub CreateCategoryEvents()

        'IF CategoryDisplayFile EXISTS ALREADY, DELETE IT AND START FRESH
        Try
            My.Computer.FileSystem.DeleteFile(DataPath & "\" & CategoryDisplayFile)
        Catch ex As Exception
        End Try

        'Process the category records
        Try
            Using categoryReader As New StreamReader(DataPath & "\" & CategoryFile)
                Dim record As String 'used to write the record to the database file
                Dim evntrecord() As String 'used to split the string record from the events file
                Dim filewriter As New StreamWriter(DataPath & "\" & CategoryDisplayFile, True) 'True appends the record to the file. False replaces the file.
                Dim sortdate As String = Nothing 'sort on their birthday calculated - not their birth date

                'Process each category record
                Do While categoryReader.Peek <> -1 'see if there is another record to process

                    'Create the Category Array
                    'catagory record = "(0) id, (1) name, (2) file name associated with this catagory
                    CategoryRecord = Split(categoryReader.ReadLine(), delimiter) '** Module Array ** holds the fields of the currently selected record
                    If CInt(CategoryRecord(0)) = SelectedCategoryID Then
                        Try
                            'category event record = (0) description, (1) date, (2) end date, (3) range
                            Using eventsReader As New StreamReader(DataPath & "\" & CategoryRecord(2))
                                Do While eventsReader.Peek <> -1 'see if there is another record to process
                                    evntrecord = Split(eventsReader.ReadLine(), vbTab)
                                    sortdate = CStr(CDate(evntrecord(1)).Ticks)
                                    record = evntrecord(0) & vbTab & sortdate _
                                        & vbTab & evntrecord(2) & vbTab & evntrecord(3)
                                    filewriter.WriteLine(record)
                                Loop
                                filewriter.Close()
                            End Using
                        Catch ex As Exception

                        End Try
                    End If
                Loop
                categoryReader.Close()
                filewriter.Close()

                'sort the database
                FrmMain.SortTsv(DataPath & "\" & CategoryDisplayFile, New Integer() {2, 1})
            End Using

        Catch ex As Exception
        End Try

    End Sub

#End Region



    Friend Sub DisplayCategoryEvents()
        FrmMain.TxtEvents.Text = Nothing 'clear the textbox

        'read the textfile and process each record
        Try
            Dim outputtext As New System.Text.StringBuilder 'build the string to be put in the text box. this will include the entire textfile
            Dim textfilereader As New IO.StreamReader(DataPath & "\" & CategoryDisplayFile)

            'process the textfile
            outputtext.Append(vbCrLf)
            Do While textfilereader.Peek <> -1 'see if there is another record to process
                Dim recordstring = textfilereader.ReadLine() 'read the next record
                Dim recordarray() As String = Split(recordstring, vbTab) 'create the record fields
                'category event record = (0) description, (1) date, (2) end date, (3) range

                Dim eventdate = New Date(Convert.ToInt64(recordarray(1)))
                outputtext.Append("   " & recordarray(0))
                If recordarray(3) = "No" Then
                    outputtext.Append(" - " & eventdate)
                Else
                    outputtext.Append(" (" & eventdate & " - " & recordarray(2) & ")")
                End If
                '                outputtext.Append(CnvDate(CStr(birthdate)))
                outputtext.Append(vbCrLf & vbCrLf)
            Loop
            FrmMain.TxtEvents.Text = Nothing
            FrmMain.TxtEvents.Text = outputtext.ToString
            outputtext.Clear()
            textfilereader.Close()
        Catch ex As Exception
            MsgBox("Somethin went wrong in the DisplayCategoryEvents & " & CategoryDisplayFile & " routine")
        End Try

    End Sub
End Class