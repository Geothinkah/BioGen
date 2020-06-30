Imports System.IO

Public Class FrmOpenCategory
    Dim indx As Integer 'used to hold the index of the item selected
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Select"
                FrmMain.LblCategory.Text = SelectedCategoryName
                FrmMain.LblCategory.Visible = True
                Close()
            Case "Edit"
                'FrmCatagory.Text = "Edit Category"
                FrmCatagory.BtnOption.Text = "Edit"
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
End Class