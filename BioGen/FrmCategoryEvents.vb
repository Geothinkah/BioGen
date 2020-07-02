Public Class FrmCategoryEvents
    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Select Case BtnOption.Text
            Case "Add"
                'event record (0) date, (1) description, (2) range yes/no (3) end date 
                MsgBox("Add")
                Close()
            Case "Select"
                MsgBox("Select")
                Close()
            Case "Edit"
                MsgBox("Edit")
                Close()
            Case "Delete"
                MsgBox("Delete")
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
End Class