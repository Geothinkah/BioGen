Public Class FrmSelectView
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        FrmMain.LblView.Visible = True
        Close()
    End Sub

    Private Sub CbxSelcectBiographies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSelectBiographies.SelectedIndexChanged
        If CbxSelectBiographies.Text = "All" Then
            FrmMain.LblView.Text = "All Biographies"
            TextFileName = AllDatabaseFile
        Else
            FrmOpenBiography.BtnOption.Text = "Select"
            FrmOpenBiography.Show()
        End If
        FrmMain.LblView.Visible = False 'don't show name until returning to FrmMain
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click

        FrmMain.LblView.Visible = False
        Select Case CbxSelectBiographies.Text

            Case ""
                Beep()
                MsgBox("Please Select A Biography")
                Exit Sub
            Case "All"
                FrmMain.LblView.Text = "All Biographies"
                TextFileName = AllDatabaseFile
            Case Else
                FrmMain.LblView.Text = BioName
        End Select
        FrmMain.BioGenDatabase(TextFileName)
        FrmMain.DisplayTextFile(TextFileName)
        FrmMain.LblView.Visible = True
        Hide()
    End Sub

    Private Sub FrmSelectView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSelectedBiography.Text = FrmMain.LblView.Text
        FrmMain.LblView.Visible = False
    End Sub
End Class