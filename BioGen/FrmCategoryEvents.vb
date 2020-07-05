Imports System.IO

Public Class FrmCategoryEvents
    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Add"
                'event record (0) date, (1) description, (2) range yes/no (3) end date 
                CatEventDescription = Trim(TxtEventDesc.Text)
                CatEventDate = DtpCateBeginDate.Value.Date
                If RbtnYes.Checked Then
                    CatRange = "Yes"
                    CatEventEndDate = DtpEndDate.Value.Date
                Else
                    CatRange = "No"
                    CatEventEndDate = CatEventDate
                End If

                'category file variables (0) CatEventDescription, (1) CatEventDate, (2) CatEventEndDate, (3) CatRange

                AddEvents(CatEventDescription, CStr(CatEventDate), CStr(CatEventEndDate), CatRange)
                TxtEventDesc.Text = Nothing
                FrmOpenCategory.CreateCategoryEvents() 'create the events text file to be displayed (EventsTextFile)
                FrmOpenCategory.DisplayCategoryEvents() 'displays the events for the selected category
                'Close()
            Case "Select"
                MsgBox("Select")
                Close()
            Case "Save"

                'delete record
                DeleteRecord(DataPath, SelectedCategoryFile, CStr(CatEventDescription), 0)

                'assign variables
                CatEventDescription = Trim(TxtEventDesc.Text)
                CatEventDate = DtpCateBeginDate.Value
                CatEventEndDate = DtpEndDate.Value
                If RbtnYes.Checked Then
                    CatRange = "Yes"
                Else
                    CatRange = "No"
                End If

                'assign variables to newrecord
                Dim newrecord As String
                'category file variables (0) CatEventDescription, (1) CatEventDate, (2) CatEventEndDate, (3) CatRange
                newrecord = CatEventDescription & vbTab & CatEventDate.ToShortDateString & vbTab & CatEventEndDate.ToShortDateString & vbTab & CatRange

                'append edited record
                Dim eventwriter As New StreamWriter(DataPath & "\" & SelectedCategoryFile, True) 'True = append, False = replace file
                eventwriter.WriteLine(newrecord)
                eventwriter.Close()
                Close()
            Case "Delete"
                'delete record
                DeleteRecord(DataPath, SelectedCategoryFile, CStr(CatEventDescription), 0)
                Close()
        End Select
    End Sub

    Private Sub RbtnYes_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnYes.CheckedChanged
        If RbtnYes.Checked Then
            DtpEndDate.Visible = True
        Else
            DtpEndDate.Visible = False
        End If
    End Sub

    Private Sub RbtnNo_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNo.CheckedChanged
        If RbtnNo.Checked Then
            DtpEndDate.Visible = False
        Else
            DtpEndDate.Visible = True
        End If
    End Sub

    Public Sub AddEvents(name As String, eventdate As String, enddate As String, daterange As String)

        Try
            'True appends the record to the file. False replaces the file.
            'record = (0) description, (1) date, (2) end date, (3) range

            Dim eventwriter As New StreamWriter(DataPath & "\" & SelectedCategoryFile, True)
            Dim record As String = Nothing
            record = Nothing
            record = name & vbTab & eventdate & vbTab & enddate & vbTab & daterange
            eventwriter.WriteLine(record)
            eventwriter.Close()

        Catch ex As Exception
            Dim unused = MsgBox("Error trying to write a record to " & SelectedCategoryFile)

        End Try
    End Sub

    Private Sub FrmCategoryEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case BtnOption.Text
            Case "Edit"
                BtnOption.Text = "Save"
                TxtEventDesc.Text = CatEventDescription
                DtpCateBeginDate.Value = CatEventDate
                DtpEndDate.Value = CatEventEndDate
                If CatRange = "Yes" Then
                    RbtnYes.Checked = True
                    RbtnNo.Checked = False
                Else
                    RbtnYes.Checked = False
                    RbtnNo.Checked = True
                End If
            Case "Delete"
                BtnOption.Text = "Delete"
                TxtEventDesc.Text = CatEventDescription
                DtpCateBeginDate.Value = CatEventDate
                DtpEndDate.Value = CatEventEndDate
                If CatRange = "Yes" Then
                    RbtnYes.Checked = True
                    RbtnNo.Checked = False
                Else
                    RbtnYes.Checked = False
                    RbtnNo.Checked = True
                End If
            Case Else

        End Select
    End Sub
End Class