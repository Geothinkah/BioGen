Imports System.ComponentModel
Imports System.IO

Public Class FrmOpenBiography
    Dim indx As Integer 'used to hold the index of the item selected

    Private Sub FrmOpenBiography_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBiographies()
    End Sub

    ''' <summary>
    ''' Fills the Listview (LstvOpenBiography) with the biography data
    ''' </summary>
    Private Sub LoadBiographies()
        'sort the biography file
        FrmMain.SortTsv(DataPath & "\" & BiographyFile, New Integer() {2}) 'sort column is 1 based not 0
        LstvOpenBiography.Items.Clear() 'clears the listviewbox
        Dim tempbiographyarray() As String = BiographyArray
        Try
            Using biographyReader As New StreamReader(DataPath & "\" & BiographyFile)
                Dim indx As Integer = 0 'index number to use for the tempbiographyarray
                Do While biographyReader.Peek <> -1 'see if there is another record to process
                    tempbiographyarray(indx) = biographyReader.ReadLine()
                    Dim temprecord() As String = Split(BiographyArray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                    LstvOpenBiography.Items.Add(temprecord(1)) 'display name
                    LstvOpenBiography.Items(indx).SubItems.Add(Format(CDate(temprecord(2).ToString), "MMM dd, yyyy")) 'display birthdate
                    LstvOpenBiography.Items(indx).SubItems.Add(temprecord(3)) 'display Living (Yes/No)
                    indx += 1   'Increase the index for use on the next record
                Loop
                biographyReader.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & BiographyFile & " file")
        End Try
    End Sub

    Private Sub LstvOpenBiography_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstvOpenBiography.SelectedIndexChanged
        Try

            'Dim indx As Integer 'used to hold the index of the item selected
            indx = LstvOpenBiography.SelectedIndices(0)
            BiographyRecord = Split(BiographyArray(indx), delimiter) '** Module Array - fills the array with the records variables
            BiographyArrayIndex = indx
            SelectedBiography = BiographyArray(indx)
            BioID = CInt(BiographyRecord(0))
            BioName = BiographyRecord(1)
            BioBirthDate = CDate(BiographyRecord(2))
            BioLiving = BiographyRecord(3)
            BioDeathDate = CDate(BiographyRecord(4))
            BioNickName = BiographyRecord(5)
            TextFileName = BiographyRecord(0) & "_" & BiographyRecord(1).Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs)
        If BioName = Nothing Then 'nothing was selected
            Beep()
            MsgBox("Please Select a Biography")
            Return
        End If

        'Assign Module level variables
        AssignVariables()

        'Create the database
        FrmMain.BioGenDatabase(TextFileName)

        'Display the text file
        FrmMain.DisplayTextFile(TextFileName)
        FrmMain.LblView.Text = BioName
        Close()

    End Sub

    Private Sub AssignVariables()
        'Assign Module level variables
        BiographyRecord = Split(BiographyArray(indx), delimiter) '** Module Array - fills the array with the records variables
        SelectedBiography = BiographyArray(indx) '** Module Variable ** Hold the entire tab deliminated string of the selected biography record
        BiographyArrayIndex = indx '** Module Variable ** save selected BiographyArray index (Module)

        'Assign the Module level Biography variables
        BioID = CInt(BiographyRecord(0))
        BioName = BiographyRecord(1)
        BioBirthDate = CDate(BiographyRecord(2))
        BioLiving = BiographyRecord(3)
        BioDeathDate = CDate(BiographyRecord(4))
        BioNickName = BiographyRecord(5)
        TextFileName = BioID & "_" & BioName.Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Select"
                If BioName = Nothing Then 'nothing was selected
                    Beep()
                    MsgBox("Please Select a Biography")
                    Return
                End If

                'Assign Module level variables
                AssignVariables()

                FrmSelectView.LblSelectedBiography.Text = BioName
                'FrmMain.LblView.Text = BioName
                Close()

            Case "Edit"
                'set buttons on the Form FrmNewBio
                FrmNewBio.BtnAdd.Enabled = False
                FrmNewBio.BtnSave.Enabled = True

                'Assign the variables
                AssignVariables()

                'set form fields
                FrmNewBio.TxtName.Text = BioName
                FrmNewBio.TxtNickName.Text = BioNickName
                FrmNewBio.CbxLiving.Text = BioLiving
                FrmNewBio.DtpBirthDate.Value = BioBirthDate
                FrmNewBio.DtpDeathDate.Value = BioDeathDate
                'do something with the recordid


                TextFileName = BioID & "_" & BioName.Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename

                FrmNewBio.Show()
                Close()

            Case "Delete"
                Beep()
                If MsgBox("Are you sure you want to delete " & BioName & "?", CType(vbYesNo + vbQuestion, Global.Microsoft.VisualBasic.MsgBoxStyle), "Quit") = vbYes Then
                    DeleteRecord(DataPath, BiographyFile, CStr(BioID), 0)
                    TextFileName = BioID & "_" & BioName.Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename
                    Try
                        My.Computer.FileSystem.DeleteFile(DataPath & "\" & TextFileName)
                    Catch ex As Exception
                    End Try

                    LoadBiographies()
                End If
                FrmMain.lblSelectedBiography.Text = "No Biography Selected"
                FrmMain.TxtFacts.Text = ""
                Close()
            Case Else

        End Select
    End Sub
End Class