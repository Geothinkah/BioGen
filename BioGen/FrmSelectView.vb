Imports System.IO
Public Class FrmSelectView
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        FrmMain.BtnSelectView.Enabled = True
        Close()
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        FrmMain.BtnSelectView.Enabled = True
        FrmMain.BioGenDatabase(TextFileName) 'generate the text file
        FrmMain.DisplayTextFile(TextFileName) 'display the text file
        FrmMain.LblBiography.Text = BioName 'display the selected biography
        FrmMain.BtnSelectView.Enabled = True
        FrmMain.Enabled = True
        Hide() 'hide this form for further use
    End Sub

    Private Sub FrmSelectView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If no one has been selected yet, show FrmOpenBiography
        FrmMain.BtnSelectView.Enabled = False
        FrmMain.TxtFacts.Text = Nothing
        If BioName = Nothing Then
            Hide()
            FrmOpenBiography.BtnOption.Text = "Select"
            FrmOpenBiography.Show()
        End If
        FillCblCategories()
    End Sub

    Private Sub BtnSelectBiography_Click(sender As Object, e As EventArgs) Handles BtnSelectBiography.Click
        Enabled = False
        FrmOpenBiography.BtnOption.Text = "Select"
        FrmOpenBiography.Show()
    End Sub
    Friend Sub FillCblCategories()
        'sort the biography file
        FrmMain.SortTsv(DataPath & "\" & CategoryFile, New Integer() {2}) 'sort column is 1 based not 0
        ClbCategories.Items.Clear() 'clears the listviewbox
        Try
            Using categoryReader As New StreamReader(DataPath & "\" & CategoryFile)
                Dim indx As Integer = 0 'index number to use for the tempbiographyarray
                Do While categoryReader.Peek <> -1 'see if there is another record to process
                    CategoryArray(indx) = categoryReader.ReadLine()
                    CategoryView(indx) = False
                    Dim temprecord() As String = Split(CategoryArray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                    ClbCategories.Items.Add(temprecord(1)) 'display name
                    'LstvSelectCategory.Items(indx).SubItems.Add(temprecord(1)) 'display Living (Yes/No)
                    indx += 1   'Increase the index for use on the next record
                Loop
                categoryReader.Close()
            End Using

        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & CategoryFile & " file")
        End Try
    End Sub

    Private Sub ClbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbCategories.SelectedIndexChanged
        'set CategoryView(indx) to true or false for displaying purposes
        Dim indx As Integer
        indx = ClbCategories.SelectedIndex
        CategoryView(indx) = ClbCategories.GetItemChecked(indx)
        'MsgBox(indx & " " & CategoryView(indx))
        'MsgBox(ClbCategories.SelectedItem)
    End Sub

End Class