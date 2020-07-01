Imports System.IO

Public Class FrmNewBio

#Region "***** Initialize *****"
    Private Sub FrmNewBio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSettings() ' need the next RecordID number
    End Sub

#End Region

#Region "***** If living hide death date stuff *****"
    Private Sub CbxLiving_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxLiving.SelectedIndexChanged
        If CbxLiving.Text = "Yes" Then
            LblDeath.Visible = False 'Death Date Label
            DtpDeathDate.Visible = False 'Death DateTimePicker
        Else
            LblDeath.Visible = True
            DtpDeathDate.Visible = True
        End If
    End Sub
#End Region

#Region "***** Close *****"

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub AddRecord()
        If Trim(TxtName.Text) IsNot "" Then

            'set module level variables for the new biography
            RecordID += 1 'increase the id for use by this record
            BioID = RecordID 'assign the new RecordID to the BioID
            BioName = Trim(TxtName.Text)
            BioBirthDate = DtpBirthDate.Value
            BioLiving = CbxLiving.Text
            Select Case CbxLiving.Text
                Case "Yes"
                    BioDeathDate = CDate("12/2/2005") 'my father's death date. I don't want the program to bomb out for lack of a date
                Case Else
                    BioDeathDate = DtpDeathDate.Value
            End Select
            BioNickName = Trim(TxtNickName.Text)
            If BioNickName = Nothing Then 'If there is no nickname set it to their first name
                Dim namearray() = Split(BioName, " ")
                BioNickName = namearray(0)
            Else
                BioNickName = Trim(BioNickName)
            End If

            'create the string variable of the tab delimited record
            SelectedBiography = CStr(BioID) & vbTab _
                & BioName & vbTab _
                & BioBirthDate.ToShortDateString & vbTab _
                & BioLiving & vbTab _
                & BioDeathDate.ToShortDateString & vbTab _
                & BioNickName

            'create BiographyRecord Array
            BiographyRecord = Split(SelectedBiography, vbTab) 'create fields

            'create the text file name
            TextFileName = BiographyRecord(0) & "_" & BiographyRecord(1).Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename


            'append the new biography record to the BiographyFile
            Try
                Dim biographywriter As New StreamWriter(DataPath & "\" & BiographyFile, True) 'True appends the record to the file. False replaces the file.
                biographywriter.WriteLine(SelectedBiography)
                biographywriter.Close()
            Catch ex As Exception
                Dim unused = MsgBox("Error trying to write a new biography record")
            End Try
        Else
            Beep()
            MsgBox("Name is a required field")
            TxtName.Select()
            Return
        End If
        SaveSettings()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Add"
                If Trim(TxtName.Text) IsNot "" Then

                    'set module level variables for the new biography
                    RecordID += 1 'increase the id for use by this record
                    BioID = RecordID 'assign the new RecordID to the BioID
                    BioName = Trim(TxtName.Text)
                    BioBirthDate = DtpBirthDate.Value
                    BioLiving = CbxLiving.Text
                    Select Case CbxLiving.Text
                        Case "Yes"
                            BioDeathDate = CDate("12/2/2005") 'my father's death date. I don't want the program to bomb out for lack of a date
                        Case Else
                            BioDeathDate = DtpDeathDate.Value
                    End Select
                    BioNickName = Trim(TxtNickName.Text)
                    If BioNickName = Nothing Then 'If there is no nickname set it to their first name
                        Dim namearray() = Split(BioName, " ")
                        BioNickName = namearray(0)
                    Else
                        BioNickName = Trim(BioNickName)
                    End If

                    'create the string variable of the tab delimited record
                    SelectedBiography = CStr(BioID) & vbTab _
                & BioName & vbTab _
                & BioBirthDate.ToShortDateString & vbTab _
                & BioLiving & vbTab _
                & BioDeathDate.ToShortDateString & vbTab _
                & BioNickName

                    'create BiographyRecord Array
                    BiographyRecord = Split(SelectedBiography, vbTab) 'create fields

                    'create the text file name
                    TextFileName = BiographyRecord(0) & "_" & BiographyRecord(1).Replace(" ", "") & ".tsv" ' remove spaces from their name for use in the filename


                    'append the new biography record to the BiographyFile
                    Try
                        Dim biographywriter As New StreamWriter(DataPath & "\" & BiographyFile, True) 'True appends the record to the file. False replaces the file.
                        biographywriter.WriteLine(SelectedBiography)
                        biographywriter.Close()
                    Catch ex As Exception
                        Dim unused = MsgBox("Error trying to write a new biography record")
                    End Try
                Else
                    Beep()
                    MsgBox("Name is a required field")
                    TxtName.Select()
                    Return
                End If
                'create the text file
                FrmMain.BioGenDatabase(TextFileName)
                'display the text file
                FrmMain.DisplayTextFile(TextFileName)
                SaveSettings()
                Close()

            Case "Save"
                If Trim(BioName) = "" Then
                    Beep()
                    MsgBox("Name is a required field")
                    TxtName.Select()
                    Return
                End If

                'Delete Files
                Try
                    My.Computer.FileSystem.DeleteFile(DataPath & "\" & TextFileName)
                Catch ex As Exception
                End Try
                Dim unused = DeleteRecord(DataPath, BiographyFile, CStr(BioID), 0)
                AddRecord()
                'create the textfile
                FrmMain.BioGenDatabase(TextFileName)
                'display the textfile
                FrmMain.DisplayTextFile(TextFileName)
                Close()
            Case Else
                MsgBox("Unknow Option")
        End Select
    End Sub

#End Region

End Class