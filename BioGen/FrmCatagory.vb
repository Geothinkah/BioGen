Imports System.IO

Public Class FrmCatagory
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Save"
                ReadSettings()
                Try
                    'declare the record variables
                    Dim categoryrecord As String = Nothing
                    Dim id As Integer = RecordID
                    Dim catname As String = TxtName.Text.Replace(" ", "")
                    Dim catfilename As String

                    'make sure a name is entered
                    If Trim(TxtName.Text) = "" Then
                        Beep()
                        MsgBox("You must supply a name for the catagory.")
                        Exit Try
                    Else
                        'check to see if the catagory already exists
                        If CheckForRecord(catname) Then
                            'catagory already exists, exit out
                            Beep()
                            MsgBox(catname & " already exists.")
                            'categorywriter.Close()
                            Exit Try
                        End If

                        'note to self: have to open after compare or it will lock the record and fail the compare routine
                        'open the StreamWriter
                        Dim categorywriter As New StreamWriter(DataPath & "\" & CategoryFile, True) 'True = append, False = replace file

                        'get the record id and increase it by 1
                        ReadSettings()
                        RecordID += +1

                        'build the catagory filename
                        catfilename = CStr(id) & "_" & catname & ".tsv"

                        'build the catagory record
                        'catagory record = "(0) id, (1) name, (2) file name associated with this catagory
                        categoryrecord = CStr(id) & vbTab & catname & vbTab & catfilename

                        'write the new catagory record
                        categorywriter.WriteLine(categoryrecord)
                        categorywriter.Close()
                        SaveSettings()

                        'set category variables
                        SelectedCategoryID = id
                        SelectedCategoryName = catname
                        SelectedCategoryFile = catfilename

                        'set label text
                        FrmMain.LblCategory.Text = SelectedCategoryName
                        FrmMain.LblCategory.Visible = True
                        Close()
                    End If
                Catch ex As Exception
                    Beep()
                    Dim unused = MsgBox("Error trying to write the category record.")
                End Try

            Case "Rename"
                Dim tempname As String
                tempname = Trim(TxtName.Text)
                'MsgBox("Edit Routine")
                'make sure a name is entered
                If Trim(tempname) = "" Then
                    Beep()
                    MsgBox("You must supply a name for the catagory.")
                    'Exit Try
                Else
                    'check to see if the catagory already exists
                    If CheckForRecord(tempname) Then
                        'catagory already exists, exit out
                        Beep()
                        MsgBox(tempname & " already exists.")
                        'Note: I could check to see if they are just changing the case of a letter
                        'but figure it's easy enough to change name and then change it back 
                        'Exit Try
                    Else

                        'Rename the file associated with this category
                        tempname = Trim(TxtName.Text.Replace(" ", ""))
                        Dim newfilename As String
                        newfilename = CStr(SelectedCategoryID) & "_" & tempname & ".tsv"
                        Try
                            My.Computer.FileSystem.RenameFile(DataPath & "\" & SelectedCategoryFile, newfilename)
                        Catch ex As Exception
                            MsgBox("Error renaming file. Why? File not closed? Maybe?")
                        End Try
                        SelectedCategoryFile = newfilename

                        'delete record
                        DeleteRecord(DataPath, CategoryFile, CStr(SelectedCategoryID), 0)

                        'assign variables to newrecord
                        Dim newrecord As String
                        SelectedCategoryName = Trim(TxtName.Text)
                        newrecord = SelectedCategoryID & vbTab & Trim(TxtName.Text) & vbTab & SelectedCategoryFile

                        'append edited record
                        Dim categorywriter As New StreamWriter(DataPath & "\" & CategoryFile, True) 'True = append, False = replace file
                        categorywriter.WriteLine(newrecord)
                        categorywriter.Close()

                        FrmMain.LblCategory.Text = SelectedCategoryName
                        FrmOpenCategory.BtnOption.Text = "Select"
                        FrmOpenCategory.Show()
                        Close()
                    End If
                End If
            Case Else


        End Select


    End Sub

    Friend Function CheckForRecord(ByVal catname As String) As Boolean

        'declare variables
        Dim categoryrecord As String 'tab deliminated record
        Dim recordflag As Boolean = False 'will be set to true if the catagory already exists
        Dim currentrecord() As String 'the array that holds the current record

        'check to see if record exists
        'catagory record = "(0) id, (1) name, (2) file name associated with this catagory
        Try
            Dim categoryReader As New System.IO.StreamReader(DataPath & "\" & CategoryFile)
            Do While categoryReader.Peek <> -1
                categoryrecord = categoryReader.ReadLine()
                currentrecord = Split(categoryrecord, vbTab) 'create fields
                If currentrecord(1).ToUpper = catname.ToUpper Then
                    recordflag = True
                    Exit Try
                End If
            Loop
            categoryReader.Close()
        Catch ex As Exception
        End Try
        Return recordflag
    End Function

    Private Sub FrmCatagory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmMain.LblCategory.Visible = False
    End Sub
End Class