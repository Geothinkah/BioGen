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
    End Sub

    Private Sub BtnSelectBiography_Click(sender As Object, e As EventArgs) Handles BtnSelectBiography.Click
        Hide()
        FrmOpenBiography.BtnOption.Text = "Select"
        FrmOpenBiography.Show()
    End Sub
End Class