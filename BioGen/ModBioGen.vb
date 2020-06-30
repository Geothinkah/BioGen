﻿Imports System.IO
Module ModBioGen
#Region "***** Category Variables *****"
    'catagory record = "(0) id, (1) name, (2) file name associated with this catagory
    Friend SelectedCategoryID As Integer
    Friend SelectedCategoryName As String
    Friend SelectedCategoryFile As String
    Friend CategoryArray(100) As String

#End Region
#Region "***** Variables *****"
    Friend CategoryFile As String = "Category.tsv"


    Friend AllDatabaseFile As String = "AllDatabaseFile.tsv"
    Friend BiographyFile As String = "Biography.tsv"
    Friend SettingsFile As String = "Settings.tsv"
    Friend PresidentsFile As String = "Presidents.tsv"
    Friend EventsFile As String = "Events.tsv"

    Friend GeneratedFileName As String

    Friend DataPath As String = Application.UserAppDataPath
    Friend SelectBiographyOnly As Boolean = False 'used from the event pane to set a flag in FrmOpenBiography to adjest it's exit behavior
    Friend delimiter As String = vbTab
    Friend RecordID As Integer = 99999 'incremented in code for each new record

    Friend TextFileName As String 'holds the text file name created for each biography or AllDatabaseFile name for the full blown works

#End Region

#Region "***** Biography File Layout, Arrays, and Variables *****"

    '----- Miscellaneous biography stuff -----
    'BiographyFile - name of the tsv file
    'BiographyArray - Holds all the biography string records
    'SelectedBiography - Holds the string of the selected biography record
    'BiographyArrayIndex - 'Holds the currently selected BiographyArray index
    'BiographyRecord() - Holds the currently selected record variables

    'OLD FORMAT
    'Friend BioID As Integer = 0 '           (0) 
    'Friend BioName As String = Nothing '    (1)
    'Friend BioBirthDate As Date = Now '     (2)
    'Friend BioSex As String = "Male" '      (3)
    'Friend BioLiving As String = "Yes" '    (4)
    'Friend BioDeathDate As Date = Nothing ' (5)
    'Friend CatBirthdays As String = "Yes" ' (6)
    'Friend CatPresidents As String = "Yes" '(7)
    'Friend BioNickName As String = Nothing '(8)

    '----- Description of the Biography Record Fields -----
    '0 - BioID - generated by the program. Increases the RecordID variable before each record is created. RecordID is stored in the settings file
    '1 - BioName - the name of the person
    '2 - BioBirthDate - the birthdate of the person
    '3 - BioLiving - is this person still alive (Yes/No)
    '4 - BioDeathDate - the person's death date. Defaults to 12/5/2005 if they are still living (my father's death date)
    '5 - BioNickName - the persons nickname. Defaults to their first name if they don't have one

    'Biography Arrays
    Friend BiographyArray(100) As String 'Holds all the biography string records
    Friend BiographyRecord() As String 'Holds the currently selected record variables

    'Biography Variables
    Friend BioFileName As String 'created for individual's database
    Friend BiographyArrayIndex As Integer = 0 'Currently selected BiographyArray(index)
    Friend SelectedBiography As String 'Hold the entire string of the selected biography record

    'Biography File Layout
    Friend BioID As Integer = 0 '           (0) 
    Friend BioName As String = Nothing '    (1)
    Friend BioBirthDate As Date = Now '     (2)
    Friend BioLiving As String = "Yes" '    (3)
    Friend BioDeathDate As Date = Nothing ' (4)
    Friend BioNickName As String = Nothing '(5)


#End Region

#Region "***** Read and Save the SettingsFile *****"
    ''' <summary>
    ''' This reads the settings file
    ''' It set the RecordID global variable
    ''' Only use one line and tab seperate values
    ''' </summary>
    Friend Sub ReadSettings()
        Dim SplitLine() As String 'holds the variables in the settings file (0) is the RecordID 
        If File.Exists(DataPath & "\" & SettingsFile) = True Then
            Dim SettingsReader As New StreamReader(DataPath & "\" & SettingsFile, System.Text.Encoding.Default) 'open the StreamReader
            Do While SettingsReader.Peek() <> -1                     'Peek to see if there is another line of data to process
                Dim record As String = SettingsReader.ReadLine()   'Read the next line of data
                SplitLine = Split(record, vbTab) 'Separate the line into the SplitLine array
                RecordID = CInt(SplitLine(0)) ' (0) = Last ID used. Increment for each new record. I use this in all the basic files
            Loop
            SettingsReader.Close() 'Close the StreamReader
        End If
    End Sub


    Friend Sub SaveSettings()
        File.WriteAllText(DataPath & "\" & SettingsFile, CStr(RecordID))
    End Sub

#End Region

#Region "***** Events Array *****"

    Friend EventsArray(100) As String

#End Region

#Region "***** Presidents Variables and the Array *****"
    'Miscellaneous President stuff
    ' PresidentsFile holds the name of the file that contains the presidents infomation 'Presidents.tsv'
    ' PresidentArray(100) holds the string record for each president

    'Presidents Record
    '0 - PresID this is generated by the system
    '1 - PresNumber George Wasington was #1 and it goes up from there
    '2 - PresName President's name
    '3 - PresBeginTerm the start of their term of being President
    '4 - PresEndTerm the end of their Presidentcy


    Friend PresID As Integer               '(0) declared above because it's used in all my files
    Friend PresNumber As Integer '          (1) George Washington was #1 and it goes up from there
    Friend PresName As String '             (2) name
    Friend PresBeginTerm As Date '          (3) started their term
    Friend PresEndTerm As Date '            (4) ended their term

    Friend PresidentArray(100) As String

#End Region



#Region "***** Deletes a record *****"

    ''' <summary>
    ''' deletes a record from the given filename
    ''' </summary>
    ''' <param name="datapath"></param>
    ''' <param name="filename"></param>
    ''' <param name="deleteterm"></param>
    ''' <param name="deletetermposition"></param>
    ''' <returns></returns>
    Public Function DeleteRecord(ByVal datapath As String, ByVal filename As String, ByVal deleteterm As String, deletetermposition As Integer) As Boolean
        Dim deletedrecorded As Boolean = False
        Dim tempfile As String = "\tempfile.tsv"
        Dim currentline As String
        Try
            Dim filereader As New StreamReader(datapath & "\" & filename)
            Dim filewriter As New StreamWriter(datapath & tempfile, True)
            Do While filereader.Peek() <> -1
                currentline = filereader.ReadLine()
                Dim currentrecord() As String = Split(currentline, vbTab)
                If Not String.Compare(currentrecord(deletetermposition), deleteterm) = 0 Then
                    filewriter.WriteLine(currentline)
                Else
                    deletedrecorded = True
                End If
            Loop
            filewriter.Close()
            filereader.Close()

            My.Computer.FileSystem.DeleteFile(datapath & "\" & filename)
            My.Computer.FileSystem.RenameFile(datapath & tempfile, filename)

        Catch ex As Exception
            Dim unused = MsgBox("Failed in the delete proceedure for file: " & filename)
        End Try
        Return deletedrecorded
    End Function
#End Region


End Module