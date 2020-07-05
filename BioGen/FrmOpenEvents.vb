Imports System.IO

Public Class FrmOpenEvents

    Private Sub LoadEvents()

        'sort the biography file
        FrmMain.SortTsv(DataPath & "\" & CategoryDisplayFile, New Integer() {2}) 'sort column is 1 based not 0
        LstvEvents.Items.Clear() 'clears the listviewbox
        'Dim tempeventsarray() As String = BiographyArray
        Try
            Using eventsReader As New StreamReader(DataPath & "\" & CategoryDisplayFile)
                Dim indx As Integer = 0 'index number to use for the tempbiographyarray
                Do While eventsReader.Peek <> -1 'see if there is another record to process
                    'tempeventsarray(indx) = eventsReader.ReadLine()
                    EventsArray(indx) = eventsReader.ReadLine()
                    'EventsArray(indx) = tempeventsarray(indx)
                    ' Dim temprecord() As String = Split(tempeventsarray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                    Dim temprecord() As String = Split(EventsArray(indx), delimiter) '** Module Array ** holds the fields of the currently selected record
                    'ADD READ EVENTS RECORDS HERE
                    Dim eventdate = New Date(Convert.ToInt64(temprecord(1)))
                    LstvEvents.Items.Add(Format(eventdate.ToString), "MMM dd, yyyy") 'display event date
                    LstvEvents.Items(indx).SubItems.Add(temprecord(0)) 'display description
                    indx += 1   'Increase the index for use on the next record
                Loop
                eventsReader.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Error reading the " & CategoryDisplayFile & " file")
        End Try
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click

        Select Case BtnOption.Text
            Case "Edit"
                FrmCategoryEvents.BtnOption.Text = "Edit"
                FrmCategoryEvents.Show()
                Close()
            Case "Delete"
                FrmCategoryEvents.BtnOption.Text = "Delete"
                FrmCategoryEvents.Show()
            Case Else
                MsgBox("Unknow case in FrmOpenEvents: " & BtnOption.Text)
        End Select
        Close()
    End Sub

    Private Sub FrmOpenEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEvents()
    End Sub

    Private Sub LstvEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstvEvents.SelectedIndexChanged
        Try
            Dim tempeventsrecord() As String
            Dim indx As Integer
            indx = LstvEvents.SelectedIndices(0)
            tempeventsrecord = Split(EventsArray(indx), delimiter) '** Module Array - fills the array with the records variables
            'category file variables (0) CatEventDescription, (1) CatEventDate, (2) CatEventEndDate, (3) CatRange

            CatEventDescription = tempeventsrecord(0)
            Dim eventdate = New Date(Convert.ToInt64(tempeventsrecord(1)))

            CatEventDate = eventdate
            CatEventEndDate = CDate(tempeventsrecord(2))

            CatRange = tempeventsrecord(3)


        Catch ex As Exception

        End Try

        'MsgBox(LstvEvents.SelectedItems.ToString)
    End Sub
End Class