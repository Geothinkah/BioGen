Public Class FrmSelectView
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub CbxSelcecBiographies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSelectBiographies.SelectedIndexChanged
        If CbxSelectBiographies.Text = "All" Then
            FrmMain.LblView.Text = "All Biographies"
            TextFileName = AllDatabaseFile
        Else
            FrmOpenBiography.BtnOption.Text = "Select"
            FrmOpenBiography.Show()
        End If
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        FrmMain.BioGenDatabase(TextFileName)
        FrmMain.DisplayTextFile(TextFileName)
        Hide()
    End Sub
End Class