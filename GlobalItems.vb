
Module GlobalItems

    'Public Declare Function GetKeyState Lib "user32" Alias "GetKeyState" (ByVal nVirtKey As Long) As Integer
    'Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Integer
    '***********************************************
    'The following Constants are used to set the CapsLock to On or Off
    Public Const KEYEVENTF_KEYUP = &H2
    Public Const VK_CAPITAL = &H14  'Caps Lock
    'Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    Public CurrentFormName As String
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public I As Integer
    Public aButton As New System.Windows.Forms.Button()
    Public aRadioButton As New System.Windows.Forms.RadioButton()
    Public aRadioButtonCount As Integer
    Public aTextBox As New System.Windows.Forms.TextBox
    Public aTextBoxCount As Integer
    Public aCheckBoxCount As Integer
    Public aGroupBox As New System.Windows.Forms.CheckBox
    Public aGroupBoxCount As Integer

    'Fonts
    Public RKLFontArial As New FontFamily("Arial")
    Public RKLFont16BI As New Font(RKLFontArial, 16, FontStyle.Bold Or FontStyle.Italic)
    Public RKLFont16B As New Font(RKLFontArial, 16, FontStyle.Bold)
    Public RKLFont14BI As New Font(RKLFontArial, 14, FontStyle.Bold Or FontStyle.Italic)
    Public RKLFont14B As New Font(RKLFontArial, 14, FontStyle.Bold)
    Public RKLFont13BI As New Font(RKLFontArial, 13, FontStyle.Bold Or FontStyle.Italic)
    Public RKLFont12BI As New Font(RKLFontArial, 12, FontStyle.Bold Or FontStyle.Italic)
    Public RKLFont12B As New Font(RKLFontArial, 12, FontStyle.Bold)
    Public RKLFont11BI As New Font(RKLFontArial, 11, FontStyle.Bold Or FontStyle.Italic)
    Public RKLFont11B As New Font(RKLFontArial, 11, FontStyle.Bold)
    Public RKLFont10B As New Font(RKLFontArial, 10, FontStyle.Bold)
    Public RKLFont9B As New Font(RKLFontArial, 9, FontStyle.Bold)
    Public RKLFont8B As New Font(RKLFontArial, 8, FontStyle.Bold)
    Public RKLFont8BI As New Font(RKLFontArial, 8, FontStyle.Bold Or FontStyle.Italic)

    'Colors to be used for BackColor
    Public clrControl As Color = Color.FromArgb(236, 233, 216)
    Public clrLightGreen As Color = Color.FromArgb(144, 238, 144) 'LightGreen
    Public clrLime As Color = Color.FromArgb(0, 255, 0)  'Bright Green
    Public clrLimeGreen As Color = Color.FromArgb(50, 205, 50)
    Public clrSpringGreen As Color = Color.FromArgb(0, 255, 127)
    Public clrDeepSkyBlue As Color = Color.FromArgb(0, 191, 255)
    Public clrLemmonChiffon As Color = Color.FromArgb(255, 250, 205) 'LemmonChiffon
    Public clrLighestOrange As Color = Color.FromArgb(255, 224, 192) 'Lightest Orange
    Public clrOrange As Color = Color.Orange
    Public clrLightestGray As Color = Color.FromArgb(240, 240, 240)  'Lightest Gray
    Public clrLightGray As Color = Color.FromArgb(211, 211, 211)
    Public clrDarkGray As Color = Color.FromArgb(169, 169, 169)
    Public clrGreyGainsboro As Color = Color.FromArgb(220, 220, 220)
    Public clrSilverGray As Color = Color.FromArgb(192, 192, 192)
    Public clrYellow As Color = Color.FromArgb(255, 255, 0)

    Public ButtonNumberClicked As Integer
    Public MenuLevel As Integer = 1

    Public RadioButtonNumberClicked As Integer
    Public TextBoxNumberClicked As Integer
    Public CheckBoxNumberClicked As Integer
    Public GroupBoxNumberClicked As Integer

    Public GroupInDocumentInputTabs As String
    Public GroupInDocumentInitialInput As String

    Public GroupInTrademarkDisplayOrParameterChanges As String

    Public PathToTrademarkDB As String
    Public adoRKLTrademarkDBConnection As New ADODB.Connection
    Public adoRKLTrademarkDBConnectIsOpen As Boolean
    Public adoRKLTrademarkRecordset As New ADODB.Recordset

    Public PathToAccountingDB As String
    Public adoRKLAccountingDBConnection As New ADODB.Connection
    Public adoRKLAccountingDBConnectIsOpen As Boolean
    Public adoRKLAccountingRecordset As New ADODB.Recordset

    Public InitialValuesAlreadyLoaded As Boolean
    Public SelectedMethodNumberForReferencingDisplayedDocs As Integer

    Public BookmarkOfRecordFoundDuringOKDisplay As String
    Public AbsolutePositionOfRecordFoundDuringOKDisplay As Long
    Public CountOfCksChecked As Integer
    Public CountOfRecordsForThisGeneralDocketNumber As Long
    Public LastRecordNumberOfFoundSubdocketNumber As Double
    Public LastSubDocketNumberRecordNumber As Double

    Public UserName As String
    Public RKLTodaysDate As String = Format(Now, "Short Date")
    Public lngRKLDate As Long

    Public CurrentRKLDocket As String
    Public CurrentSubDocketNumber As String
    Public CurrentClientDocketNumber As String
    Public ClientName As String
    Public HaveSentASubDocketNumberMessageToUser As Boolean

    Public SelectedDataFieldNameToBeChanged As String
    Public CurrentValueOfSelectedDataField As String

    'The following Holds the Original Values from the DB when they are Assigned in the Display process
    Public OrigDocketNumber As String
    Public OrigSubDocketNumber As String
    Public OrigClientDocketNumber As String
    Public OrigtxtCountryCode As String
    Public OrigResponsibleAttorney As String
    Public OrigTrademarkType As String
    Public OrigMarkText As String
    Public OrigGoodsServicesUsedByMark As String
    Public OrigFirstUseDate As Long
    Public OrigFirstUseDateInCommerce As Long

    Public OrigStateRegistrationsOfMark As String
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    'The following Holds the State Names and their Abbreviations
    Public arrStateNames(51, 3) As String

    'The following are the DB Field Names >>>>>>>>>>>>>>>>>>
    Public IntialLoadOfThisFormCompleted As Boolean
    Public FullDocketNumber As String
    Public DocketNumber As String
    Public SubDocketNumber As String
    Public ResponsibleAttorney As String
    Public TrademarkOwnersEntityStatus As String
    Public ClientDocketNumber As String
    Public CountryCode As String
    Public TrademarkType As String
    Public CategoryOfTrademarkType As String
    Public FirstUseDate As Long
    Public FirstUseDateInCommerce As Long
    'Public FirstUseDateInInterStateCommerce As Long
    Public MadridProtocolSerialNumber As String
    Public WIPOFilingDate As Long
    Public MarkText As String
    Public GoodsServicesUsedByMark As String

    Public ApplicationSerialNumber As String
    Public ApplicationFilingDate As Long
    Public RegistrationNumber As String
    Public RegistrationIssueDate As Long
    Public StateRegistrationsOfMark As String

    'The following defines the Variables for use in ALL TWELVE Official Actions
    Public NowReviewing1To6 As Boolean
    Public NowReviewing7To12 As Boolean
    Public USPTOActionResponseDueDate As Long
    Public TypeOfTimePeriodToRespond As String

    'Fields entered in Tab 3 Screen - Official Actions
    Public FirstUSPTOActionMailingDate As Long  '<== was OA1
    Public SecondUSPTOActionMailingDate As Long
    Public ThirdUSPTOActionMailingDate As Long
    Public FourthUSPTOActionMailingDate As Long
    Public FifthUSPTOActionMailingDate As Long
    Public SixthUSPTOActionMailingDate As Long
    Public SeventhUSPTOActionMailingDate As Long
    Public EighthUSPTOActionMailingDate As Long
    Public NinthUSPTOActionMailingDate As Long
    Public TenthUSPTOActionMailingDate As Long
    Public EleventhUSPTOActionMailingDate As Long
    Public TwelvethUSPTOActionMailingDate As Long

    Public FirstUSPTOActionResponseDueDate As Long  '<== was OARD1
    Public SecondUSPTOActionResponseDueDate As Long
    Public ThirdUSPTOActionResponseDueDate As Long
    Public FourthUSPTOActionResponseDueDate As Long
    Public FifthUSPTOActionResponseDueDate As Long
    Public SixthUSPTOActionResponseDueDate As Long
    Public SeventhUSPTOActionResponseDueDate As Long
    Public EighthUSPTOActionResponseDueDate As Long
    Public NinthUSPTOActionResponseDueDate As Long
    Public TenthUSPTOActionResponseDueDate As Long
    Public EleventhUSPTOActionResponseDueDate As Long
    Public TwelvethUSPTOActionResponseDueDate As Long

    Public FirstUSPTOActionResponseMadeDate As Long  '<== was OARM1
    Public SecondUSPTOActionResponseMadeDate As Long
    Public ThirdUSPTOActionResponseMadeDate As Long
    Public FourthUSPTOActionResponseMadeDate As Long
    Public FifthUSPTOActionResponseMadeDate As Long
    Public SixthUSPTOActionResponseMadeDate As Long
    Public SeventhUSPTOActionResponseMadeDate As Long
    Public EighthUSPTOActionResponseMadeDate As Long
    Public NinthUSPTOActionResponseMadeDate As Long
    Public TenthUSPTOActionResponseMadeDate As Long
    Public EleventhUSPTOActionResponseMadeDate As Long
    Public TwelvethUSPTOActionResponseMadeDate As Long

    Public TypeOfFirstUSPTOAction As String
    Public TypeOfSecondUSPTOAction As String
    Public TypeOfThirdUSPTOAction As String
    Public TypeOfFourthUSPTOAction As String
    Public TypeOfFifthUSPTOAction As String
    Public TypeOfSixthUSPTOAction As String
    Public TypeOfSeventhUSPTOAction As String
    Public TypeOfEighthUSPTOAction As String
    Public TypeOfNinthUSPTOAction As String
    Public TypeOfTenthUSPTOAction As String
    Public TypeOfEleventhUSPTOAction As String
    Public TypeOfTwelvethUSPTOAction As String

    Public TypeOfFirstPatentOfficeResponse As String
    Public TypeOfSecondPatentOfficeResponse As String
    Public TypeOfThirdPatentOfficeResponse As String
    Public TypeOfFourthPatentOfficeResponse As String
    Public TypeOfFifthPatentOfficeResponse As String
    Public TypeOfSixthPatentOfficeResponse As String
    Public TypeOfSeventhPatentOfficeResponse As String
    Public TypeOfEighthPatentOfficeResponse As String
    Public TypeOfNinthPatentOfficeResponse As String
    Public TypeOfTenthPatentOfficeResponse As String
    Public TypeOfEleventhPatentOfficeResponse As String
    Public TypeOfTwelvethPatentOfficeResponse As String


    Public FirstTypeOfTimeGivenForResponse As Integer
    Public SecondTypeOfTimeGivenForResponse As Integer
    Public ThirdTypeOfTimeGivenForResponse As Integer
    Public FourthTypeOfTimeGivenForResponse As Integer
    Public FifthTypeOfTimeGivenForResponse As Integer
    Public SixthTypeOfTimeGivenForResponse As Integer
    Public SeventhTypeOfTimeGivenForResponse As Integer
    Public EighthTypeOfTimeGivenForResponse As Integer
    Public NinthTypeOfTimeGivenForResponse As Integer
    Public TenthTypeOfTimeGivenForResponse As Integer
    Public EleventhTypeOfTimeGivenForResponse As Integer
    Public TwelvethTypeOfTimeGivenForResponse As Integer

    Public FirstTimeToRespond As Integer
    Public SecondTimeToRespond As Integer
    Public ThirdTimeToRespond As Integer
    Public FourthTimeToRespond As Integer
    Public FifthTimeToRespond As Integer
    Public SixthTimeToRespond As Integer
    Public SeventhTimeToRespond As Integer
    Public EighthTimeToRespond As Integer
    Public NinthTimeToRespond As Integer
    Public TenthTimeToRespond As Integer
    Public EleventhTimeToRespond As Integer
    Public TwelvethTimeToRespond As Integer

    Public FirstResponseToBeMadeOnAParticularDate As Date
    Public SecondResponseToBeMadeOnAParticularDate As Date
    Public ThirdResponseToBeMadeOnAParticularDate As Date
    Public FourthResponseToBeMadeOnAParticularDate As Date
    Public FifthResponseToBeMadeOnAParticularDate As Date
    Public SixthResponseToBeMadeOnAParticularDate As Date
    Public SeventhResponseToBeMadeOnAParticularDate As Date
    Public EighthResponseToBeMadeOnAParticularDate As Date
    Public NinthResponseToBeMadeOnAParticularDate As Date
    Public TenthResponseToBeMadeOnAParticularDate As Date
    Public EleventhResponseToBeMadeOnAParticularDate As Date
    Public TwelvethResponseToBeMadeOnAParticularDate As Date

    Public FirstIsThisDueDateCorrect As Integer
    Public SecondIsThisDueDateCorrect As Integer
    Public ThirdIsThisDueDateCorrect As Integer
    Public FourthIsThisDueDateCorrect As Integer
    Public FifthIsThisDueDateCorrect As Integer
    Public SixthIsThisDueDateCorrect As Integer
    Public SeventhIsThisDueDateCorrect As Integer
    Public EighthIsThisDueDateCorrect As Integer
    Public NinthIsThisDueDateCorrect As Integer
    Public TenthIsThisDueDateCorrect As Integer
    Public EleventhIsThisDueDateCorrect As Integer
    Public TwelvethIsThisDueDateCorrect As Integer

    Public FirstWasResponseFiledAtThePatentOffice As Integer
    Public SecondWasResponseFiledAtThePatentOffice As Integer
    Public ThirdWasResponseFiledAtThePatentOffice As Integer
    Public FourthWasResponseFiledAtThePatentOffice As Integer
    Public FifthWasResponseFiledAtThePatentOffice As Integer
    Public SixthWasResponseFiledAtThePatentOffice As Integer
    Public SeventhWasResponseFiledAtThePatentOffice As Integer
    Public EighthWasResponseFiledAtThePatentOffice As Integer
    Public NinthWasResponseFiledAtThePatentOffice As Integer
    Public TenthWasResponseFiledAtThePatentOffice As Integer
    Public EleventhWasResponseFiledAtThePatentOffice As Integer
    Public TwelvethWasResponseFiledAtThePatentOffice As Integer

    Public SelectedSequenceOfPatentOfficeAction As Integer
    Public NowInDisplayModeForOfficialActions As Boolean
    Public SequenceNumberToUse As Integer
    Public SequenceOfPatentOfficeAction As Integer

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    'Public LastUSPTOOfficialActionDate



    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '''''Public Function RKLFont(Size As Integer, Bold As String, Italic As String) As Font
    '''''    'This Function Sets the Font Properties for the Target Object
    '''''    ' This is the Model ==> Public RKLFont As New Font(RKLFontArial, 16, FontStyle.Bold Or FontStyle.Italic)
    '''''    Dim SetRKLFont As Font
    '''''    SetRKLFont.SystemFontName = "Arial"


    '''''    Return SetRKLFont  'RKLFont
    '''''End Function
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    'Public Function CapsLockOn() As Boolean
    '    Dim iKeyState As Integer
    '    iKeyState = GetKeyState(vbKeyCapital)
    '    CapsLockOn = (iKeyState = 1 Or iKeyState = -127)
    'End Function
    Public Sub PressCapsLockKey(ByVal lngKey As Byte) 'WAS lngKey as Long
        Call keybd_event(lngKey, 0, 0, 0)
        Call keybd_event(lngKey, 0, KEYEVENTF_KEYUP, 0)
    End Sub


    Public Sub DisplayMenu(ByVal MenuName As String)
        With frmMainMenu2.tplMainMenu.Controls
            For I = 0 To 6
                'frmMainMenu2.MyControlArray.Item(I).Visible = True
                frmMainMenu2.MyControlArray.Item(I).Visible = True
            Next I
            Select Case MenuName
                Case "MainMenu"
                    MenuLevel = 1
                    With frmMainMenu2
                        .btnMainMenu.Visible = False
                        .btnPreviousMenu.Visible = False
                        .tplMainMenu.BackColor = Color.PowderBlue
                        .lblMenuTitle.Text = "Trademark Main Menu"
                        .lblMenuTitle.Left = 290 '350
                    End With
                    With frmMainMenu2.MyControlArray
                        For I = 0 To 3
                            .Item(I).Width = 650
                            .Item(I).Left = 85
                            .Item(I).Font = RKLFont16BI
                            .Item(I).Top = (I + 1) * 65
                            .Item(I).Anchor = AnchorStyles.Left Or AnchorStyles.Right
                        Next
                        .Item(0).Text = "&Input New Trademark Documents"
                        .Item(1).Text = "&Data Change or Screen Display of Trademark Documents"
                        .Item(2).Text = "&Screen and/or Hardcopy Printout"
                        .Item(3).Text = "Enough Already - Leave this Program"
                        .Item(4).Visible = False
                        .Item(5).Visible = False
                        .Item(6).Visible = False
                    End With
                Case "TypeOfTradeMarkDocument"
                    MenuLevel = 2
                    With frmMainMenu2
                        .btnPreviousMenu.Visible = True
                        .btnMainMenu.Visible = True
                        .lblMenuTitle.Text = "Type of Trademark Document Being Entered"
                        .lblMenuTitle.Left = 165
                    End With
                    With frmMainMenu2.MyControlArray
                        For I = 0 To 3
                            .Item(I).Width = 500
                            .Item(I).Left = 175
                            .Item(I).Font = RKLFont16BI
                            .Item(I).Top = (I + 1) * 65
                            .Item(I).Anchor = AnchorStyles.Left Or AnchorStyles.Right
                        Next
                        .Item(0).Text = "Federal Trademark &Application"
                        .Item(1).Text = "Federal Trademark &Registration"
                        .Item(2).Text = "&Madrid Protocol Application"
                        .Item(3).Text = "&Intent To Use Federal Application"
                        .Item(4).Text = "&Common Law Mark"
                        .Item(5).Visible = False
                        .Item(6).Visible = False
                    End With
                Case "TypeOfTradeMarkApplication"
                    MenuLevel = 3
                    With frmMainMenu2
                        .btnPreviousMenu.Visible = True
                        .btnMainMenu.Visible = True
                        .tplMainMenu.BackColor = Color.CornflowerBlue
                        .lblMenuTitle.Text = "Type of Trademark Application"
                        .lblMenuTitle.Left = 250
                    End With
                    With frmMainMenu2.MyControlArray
                        For I = 0 To 6
                            .Item(I).Width = 500
                            .Item(I).Left = 175
                            .Item(I).Font = RKLFont14BI
                            .Item(I).Top = (I + 1) * 53
                            .Item(I).Anchor = AnchorStyles.Left Or AnchorStyles.Right
                        Next
                        .Item(0).Text = "Trademark (Goods)"
                        .Item(1).Text = "Service Mark (Services)"
                        .Item(2).Text = "Trademark/Service Mark (Goods && Services)"
                        .Item(3).Text = "Collective Membership Mark"
                        .Item(4).Text = "Certification Mark"
                        .Item(5).Text = "Collective Mark"
                        .Item(6).Text = "Concurrent Use Mark"
                    End With
            End Select
        End With
    End Sub
    Public Sub CloseConnectionToRKLTrademarkDB()
        If adoRKLTrademarkDBConnectIsOpen Then
            adoRKLTrademarkDBConnection.Close()
            adoRKLTrademarkDBConnection = Nothing
            adoRKLTrademarkDBConnectIsOpen = False
        End If
    End Sub
    Public Sub OpenConnectionToRKLTrademarkDB(ByVal RKLDb As String)
        '  Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\Admin\Marv's Folder\Mort\Patent DB\RKLPatent.mdb"
        'Purpose of this Routine
        ' 1) Connect and Open the RKLTrademark.mdb Database
        ' 2) The Variable adoRKLDBConnection is a Public variable which will be
        '      available as the RKLDb Connection for all Routines
        ' ==> Open connection Example <==
        '    strCnxn = "Provider='sqloledb';Data Source='MySqlServer';" &
        '            "Initial Catalog='Pubs';Integrated Security='SSPI';"
        '    Set Cnxn = New ADODB.Connection  
        '    Cnxn.Open strCnxn  
        '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        Dim stradoRKLTrademarkDBConnection As String
        ''''Public adoRKLDBConnection As ADODB.Connection

        stradoRKLTrademarkDBConnection = "Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" & PathToTrademarkDB &
            "\" & RKLDb & ";" & "Persist Security Info=False"

        adoRKLTrademarkDBConnection = New ADODB.Connection

        adoRKLTrademarkDBConnection.Open(stradoRKLTrademarkDBConnection)        'Define Connection to the RKLDb
        adoRKLTrademarkDBConnectIsOpen = True
    End Sub
    Public Sub CloseTableInRKLTrademarkDB()
        On Error Resume Next
        adoRKLTrademarkRecordset.Close()
        ''''adoRKLTrademarkRecordset = Nothing
    End Sub
    Public Sub OpenTableInRKLTrademarkDB(ByVal RKLTable As String)
        Dim tempRKLTable As String
        tempRKLTable = Trim(RKLTable)

        ''''adoRKLTrademarkRecordset.Open(tempRKLTable, adoRKLTrademarkDBConnect,
        ''''         ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)

        'adoRKLTrademarkRecordset.Open(tempRKLTable, adoRKLDBConnection,
        '         ADODB.LockTypeEnum.adLockOptimistic)


        'adoRKLTrademarkRecordset.Open(tempRKLTable, adoRKLDBConnection,
        'ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)

        Try
            adoRKLTrademarkRecordset.Open(tempRKLTable, adoRKLTrademarkDBConnection,
        ADODB.CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic)
        Catch
            Exit Sub
        End Try
    End Sub
    Public Function ConvertToRKLDate(ByVal InCommingDate As Date) As Long
        'This routine converts the system supplIed date format to Mort's date format.
        'MORT'S FORMAT (from the True Basic program):  LET TDATE = TDAY + 100*TMONTH + 10000*TYEAR

        Dim intDay As Integer
        Dim intMonth As Integer
        Dim intYear As Long
        '''''Dim RKLDateNumber As Long

        intDay = DatePart("d", InCommingDate)
        intMonth = DatePart("m", InCommingDate)
        intYear = DatePart("yyyy", InCommingDate)

        ConvertToRKLDate = intDay + (intMonth * 100) + (intYear * 10000)
        Return ConvertToRKLDate

    End Function
    Public Function ConvertFromRKLDate(ByVal IncomingRKLDate As Long, ByVal DisplayDateFormat As String)
        'This routine converts Mort's date format to the system supplied date format.
        ' The returning Date can be Formated either:
        ' 1) As a Long format with a Word for the Month - Ex.: January 1, 2009
        ' 2) As a Short format with a Number for the Month - Ex.: 1/1/09
        'MORT'S FORMAT (from the True Basic program):  LET TDATE = TDAY + 100*TMONTH + 10000*TYEAR

        Dim SystemDateFormat As Date
        Dim strInComingRKLDate As String
        Dim datYear As String
        Dim datMonth As String
        Dim strDate As String
        Dim datDay As String
        Dim strFullDate As String

        On Error GoTo ErrorHandler

        If IncomingRKLDate > 0 Then
            strInComingRKLDate = Trim$(Str$(IncomingRKLDate))
            datYear = Mid(strInComingRKLDate, 1, 4)
            datMonth = Mid(strInComingRKLDate, 5, 2)
            datDay = Mid(strInComingRKLDate, 7, 2)

            'Realign the Strings into a Date format
            strInComingRKLDate = datMonth & "/" & datDay & "/" & datYear
            'Convert from a String Variable to a Date Variable
            'Select a Long-Word or Short-Number format
            Select Case DisplayDateFormat
                Case "MonthWord"
                    SystemDateFormat = CDate(strInComingRKLDate)
                    strDate = Format(SystemDateFormat, "mmmm dd, yyyy")
                    ConvertFromRKLDate = strDate
                Case "MonthNumber"
                    ConvertFromRKLDate = strInComingRKLDate   'SystemDateFormat
            End Select
        End If

        If ConvertFromRKLDate IsNot Nothing Then
            Return ConvertFromRKLDate
            Exit Function
        End If

ErrorHandler:
        MessageBox.Show("Now in the ConvertFromRKLDate function" & vbCrLf & vbCrLf &
            "Error: " & Err.Number & " = " & Err.Description _
            & vbCrLf &
            "InComingRKLDate = " & IncomingRKLDate _
            & vbCrLf &
            "PLEASE WRITE DOWN THE ABOVE INFORMATION AND CONTACT MARV")
    End Function
    Public Sub CheckTextForNumber(ByRef TextToCheck As String, ByRef CheckedText As String, ByRef BackColorValue As Color)
        'The purpose of this routine is to:
        ' 1) See If the last character entered is a Number
        '    A) If it is a Number, then send the whole field back as-is
        '    B) If is is not a Number, then strip off the non-numeric character before sending it back
        ' 2) Test for the length of the field to change the BackColor:
        '    A) If it's > 0 then make the BackColor variable = Light Green
        '    B) If it's = 0 then make the BackColor variable = Light Yellow
        Dim ThisIsANumber As Boolean
        Dim tempTextToCheck As String

        tempTextToCheck = TextToCheck
        ThisIsANumber = IsNumeric(TextToCheck)
        If ThisIsANumber Then
            BackColorValue = Color.Green  '&HC0FFC0  'Light Green
            CheckedText = TextToCheck
            Exit Sub
        Else 'The last character entered in TextToCheck is a non-nmeric character
            'Strip off the last character
            tempTextToCheck = Mid(tempTextToCheck, 1, Len(tempTextToCheck) - 1)
            If Len(tempTextToCheck) > 0 Then
                BackColorValue = Color.Green  '&HC0FFC0  'Light Green
                CheckedText = tempTextToCheck
                Exit Sub
            Else
                CheckedText = ""
                BackColorValue = clrLemmonChiffon 'Color.Yellow  '&HC0FFFF  'Yellow
                Exit Sub
            End If
        End If
    End Sub
    Public Sub CheckForValidDateEntered(ByVal DateToBeChecked As String, ByRef IsBadDate As Boolean)
        Static tempMonthEntered As Integer
        Dim tempStrMonthAndDayEntered As String
        Static tempNumDayEntered As Integer
        Dim tempStrDayEntered As String
        Dim tempStrMonthAndDayAndYearEntered As String
        Dim tempNumYearEntered As Long
        Dim tempStrYearEntered As String
        Dim tempDateToBeChecked As String
        'Dim tempDate As Date
        Dim tempDay As Integer
        Dim tempMonth As Integer

        If (UCase$(DateToBeChecked) = UCase$("None")) Or (UCase$(DateToBeChecked) = UCase$("Non")) Or
            (UCase$(DateToBeChecked) = UCase$("No")) Or (UCase$(DateToBeChecked) = UCase$("N")) Or
            (UCase$(DateToBeChecked) = UCase$("one")) Or (UCase$(DateToBeChecked) = UCase$("ne")) Or
            (UCase$(DateToBeChecked) = UCase$("e")) Then
            Exit Sub
        End If

        'See if there is a "/" in the DateToBeChecked - AND if the Length is 8, 
        '  then check for a 2nd "/" then remove all "/" - This also means tha the Year part is only 2 chars long
        If (InStr(1, DateToBeChecked, "/") > 0) Then
            If Len(DateToBeChecked) = 10 Then
                tempDateToBeChecked = Mid$(DateToBeChecked, 1, 2) & Mid$(DateToBeChecked, 4, 2) & Mid$(DateToBeChecked, 7, 4)
            Else
                tempDateToBeChecked = Mid$(DateToBeChecked, 1, 2) & Mid$(DateToBeChecked, 4, 2) & Mid$(DateToBeChecked, 7, 2)
            End If
            DateToBeChecked = tempDateToBeChecked
        End If

        If Len(DateToBeChecked) = 2 And InStr(1, DateToBeChecked, "_") = 0 And InStr(1, DateToBeChecked, "/") = 0 Then  'check for a valid month
            If ((DateToBeChecked >= 1) And (DateToBeChecked <= 12)) Then
                tempMonthEntered = Val(DateToBeChecked)
                IsBadDate = False
                Exit Sub
            Else
                'Send and error msg to the user
                tempMonthEntered = Val(DateToBeChecked)
                Call msgDateIsInvalid(tempMonthEntered, "Month", 0)
                'Remove the Month-Entered Text and Re-display
                IsBadDate = True
                Exit Sub
            End If
        ElseIf Len(DateToBeChecked) = 4 And InStr(1, DateToBeChecked, "_") = 0 And InStr(1, DateToBeChecked, "/") = 0 Then   'check for a valid day
            If UCase$(Trim$(DateToBeChecked)) = "NONE" Then Exit Sub

            tempStrMonthAndDayEntered = Str$(Trim(DateToBeChecked))
            tempNumDayEntered = Val(Right$(tempStrMonthAndDayEntered, 2))
            tempStrDayEntered = Right$(Str$(DateToBeChecked), 2)
            Select Case tempMonthEntered
                Case 4, 6, 9, 11
                    If Not ((tempNumDayEntered >= 1) And (tempNumDayEntered <= 30)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonthEntered, "Day", tempNumDayEntered)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case 1, 3, 5, 7, 8, 10, 12
                    If Not ((tempNumDayEntered >= 1) And (tempNumDayEntered <= 31)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonthEntered, "Day", tempNumDayEntered)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case 2
                    If Not ((tempNumDayEntered >= 1) And (tempNumDayEntered <= 29)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonthEntered, "Day", tempNumDayEntered)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case Is > 12
                    'Send and error msg to the user
                    Call msgDateIsInvalid(tempMonth, "Month", tempDay)
                    'Remove the Day-Entered Text and Re-display
                    IsBadDate = True
                    Exit Sub
            End Select

        ElseIf Len(DateToBeChecked) = 8 And InStr(1, DateToBeChecked, "_") = 0 And InStr(1, DateToBeChecked, "/") = 0 Then 'check for a valid year
            'Seperate the Month and Day from the DateToBeChecked - Then check for the correct number of Days for that Month
            tempDay = Val(Mid$(DateToBeChecked, 3, 2))
            tempMonth = Val(Mid$(DateToBeChecked, 1, 2))

            Select Case tempMonth
                Case 4, 6, 9, 11
                    If Not ((tempDay >= 1) And (tempDay <= 30)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonth, "Day", tempDay)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case 1, 3, 5, 7, 8, 10, 12
                    If Not ((tempDay >= 1) And (tempDay <= 31)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonth, "Day", tempDay)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case 2
                    If Not ((tempDay >= 1) And (tempDay <= 29)) Then
                        'Send and error msg to the user
                        Call msgDateIsInvalid(tempMonth, "Day", tempDay)
                        'Remove the Day-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    End If
                Case Is > 12
                    'Send and error msg to the user
                    Call msgDateIsInvalid(tempMonth, "Month", tempDay)
                    'Remove the Day-Entered Text and Re-display
                    IsBadDate = True
                    Exit Sub
            End Select
            tempStrMonthAndDayAndYearEntered = Str$(DateToBeChecked)
            tempNumYearEntered = Val(Right$(tempStrMonthAndDayAndYearEntered, 4))
            If Not ((tempNumYearEntered >= 1950) And (tempNumYearEntered <= 2100)) Then
                tempStrYearEntered = Right$(tempStrMonthAndDayAndYearEntered, 4)
                'Send and error msg to the user
                Call msgDateIsInvalid(tempStrYearEntered, "Year", 0)
                'Remove the Year-Entered Text and Re-display
                IsBadDate = True
                Exit Sub
            End If
            'Now see if this valid year is a Leap Year
            ' ==>If the valid year is a Leap Year, then see if the Month entered is 2, then see if the Day entered is 29 - Which is an error
            If Not IsLeapYear(tempNumYearEntered) Then
                If tempMonthEntered = 2 Then
                    If tempNumDayEntered = 29 Then
                        Dim Msg, Style, Title As String
                        Dim Response As Integer
                        'Send a msg that since leap year was NOT entered and the month entered = 2, then the day cannot be 29
                        'Assemble and Send the Message
                        Msg = "The Year Number you entered ==> " & Trim$(Str$(tempNumYearEntered)) _
                            & " <== is not a Leap Year!" _
                            & vbCrLf & vbCrLf _
                            & "But you entered 29 as the Day for the Month of February within that Year." _
                            & vbCrLf & vbCrLf _
                            & "Please DELETE the bad number and enter a valid Year Number for the Month and Day and between 1950 and 2100!"
                        Title = "Please enter a valid Year Number !!!"
                        Style = vbOKOnly + vbCritical
                        Response = MsgBox(Msg, Style, Title)
                        'Remove the Year-Entered Text and Re-display
                        IsBadDate = True
                        Exit Sub
                    Else
                        IsBadDate = False
                        Exit Sub
                    End If
                End If
            End If
        End If
        IsBadDate = False
    End Sub
    Public Sub msgDateIsInvalid(ByVal NumberOfInvalidDateEntered As String, ByVal TypeOfInvalidDateEntered As String, ByVal DayOfMonthEntered As Integer)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        Select Case TypeOfInvalidDateEntered
            Case "Month"
                'Assemble and Send the Message
                Msg = "The Month Number you entered ==> " & NumberOfInvalidDateEntered _
                       & " <== is not valid!" _
                       & vbCrLf & vbCrLf _
                       & "Please DELETE the bad number and enter a valid Month Number between 1 and 12!"
                Title = "Please enter a valid Month Number !!!"
                Style = vbOKOnly + vbCritical
                Response = MsgBox(Msg, Style, Title)
            Case "Day"
                Dim HighDayNumber As Integer
                Select Case NumberOfInvalidDateEntered 'This is the Month-Number entered
                    Case 4, 6, 9, 11
                        HighDayNumber = 30
                    Case 1, 3, 5, 7, 8, 10, 12
                        HighDayNumber = 31
                    Case 2
                        HighDayNumber = 28
                End Select
                'Assemble and Send the Message
                Msg = "The Day Number you entered ==> " & Trim$(Str$(DayOfMonthEntered)) _
                  & " <== is not valid for Month: " & Trim$(Str$(NumberOfInvalidDateEntered)) & "!" _
                  & vbCrLf & vbCrLf _
                  & "Please DELETE the bad number and enter a valid Day Number between 1 and " & Trim$(Str$(HighDayNumber)) & "!"
                Title = "Please enter a valid Day Number !!!"
                Style = vbOKOnly + vbCritical
                Response = MsgBox(Msg, Style, Title)
            Case "Year"
                'Assemble and Send the Message
                Msg = "The Year Number you entered ==> " & NumberOfInvalidDateEntered _
                       & " <== is not valid!" _
                       & vbCrLf & vbCrLf _
                       & "Please DELETE the bad number and enter a valid Year Number between 1950 and 2100!"
                Title = "Please enter a valid Year Number !!!"
                Style = vbOKOnly + vbCritical
                Response = MsgBox(Msg, Style, Title)
        End Select
    End Sub
    Public Sub msgThisFieldCantBeLongerThan(ByVal FieldLength As Integer)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "Sorry, you can NOT enter more than " & FieldLength.ToString &
              " characters in this field!"
        Title = "Sorry, You Can NOT Enter More Than " & FieldLength.ToString &
              " Characters In This Field!!!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgSureWantToCancelThan(ByRef Response As Integer)
        Dim Msg, Style, Title As String
        'Dim Response As Integer

        'Assemble and Send the Message
        Msg = "Are you SURE you want to CANCEL?" &
              vbCrLf & vbCrLf &
              "If you click the 'Yes' button then " &
              "nothing you entered on this screen will be saved!"
        Title = "Are you SURE you want to CANCEL?"
        Style = vbYesNo + vbQuestion
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Function IsLeapYear(ByVal Year As Long) As Boolean
        If ((Year Mod 4 = 0) And (Year Mod 100 <> 100)) Or (Year Mod 400 = 0) Then
            IsLeapYear = True
        Else
            IsLeapYear = False
        End If
    End Function
    Public Function AddSlashesToStringDate(ByVal IncomingString As String) As String
        Dim strDay As String
        Dim strMonth As String
        Dim strYear As String

        strDay = Mid(IncomingString, 1, 2)
        strMonth = Mid(IncomingString, 3, 2)
        strYear = Mid(IncomingString, 5, 4)

        AddSlashesToStringDate = strDay & "/" & strMonth & "/" & strYear

        Return AddSlashesToStringDate

    End Function
    Public Sub WriteNewTrademarkDocumentInputToRKLTrademarkTable()
        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        OpenTableInRKLTrademarkDB("TrademarkDocuments")
        With adoRKLTrademarkRecordset
            .AddNew()

            .Fields!CategoryOfTrademarkType.Value = Trim(CategoryOfTrademarkType.ToString)
            .Fields!DocketNumber.Value = Trim(DocketNumber.ToString)
            .Fields!SubDocketNumber.Value = Trim(SubDocketNumber.ToString)
            .Fields!ClientDocketNumber.Value = Trim(ClientDocketNumber.ToString)
            .Fields!CountryCode.Value = Trim(CountryCode.ToString)
            .Fields!ResponsibleAttorney.Value = Trim(ResponsibleAttorney.ToString)
            .Fields!TrademarkOwnersEntityStatus.Value = Trim(TrademarkOwnersEntityStatus.ToString)
            .Fields!TrademarkType.Value = Trim(TrademarkType.ToString)
            .Fields!MarkText.Value = Trim(MarkText.ToString)
            .Fields!GoodsServicesUsedByMark.Value = Trim(GoodsServicesUsedByMark.ToString)
            .Fields!FirstUseDate.Value = FirstUseDate
            .Fields!FirstUseDateInCommerce.Value = FirstUseDateInCommerce
            .Fields!MadridProtocolSerialNumber.Value = Trim(MadridProtocolSerialNumber.ToString)
            .Fields!WIPOFilingDate.Value = WIPOFilingDate
            .Fields!RegistrationNumber.Value = RegistrationNumber
            .Fields!RegistrationIssueDate.Value = RegistrationIssueDate
            .Fields!ApplicationSerialNumber.Value = ApplicationSerialNumber
            .Fields!ApplicationFilingDate.Value = ApplicationFilingDate
            .Fields!StateRegistrationsOfMark.Value = StateRegistrationsOfMark

            .Fields!FirstUSPTOActionMailingDate.Value = FirstUSPTOActionMailingDate
            .Fields!SecondUSPTOActionMailingDate.Value = SecondUSPTOActionMailingDate
            .Fields!ThirdUSPTOActionMailingDate.Value = ThirdUSPTOActionMailingDate
            .Fields!FourthUSPTOActionMailingDate.Value = FourthUSPTOActionMailingDate
            .Fields!FifthUSPTOActionMailingDate.Value = FifthUSPTOActionMailingDate
            .Fields!SixthUSPTOActionMailingDate.Value = SixthUSPTOActionMailingDate
            .Fields!SeventhUSPTOActionMailingDate.Value = SeventhUSPTOActionMailingDate
            .Fields!EighthUSPTOActionMailingDate.Value = EighthUSPTOActionMailingDate
            .Fields!NinthUSPTOActionMailingDate.Value = NinthUSPTOActionMailingDate
            .Fields!TenthUSPTOActionMailingDate.Value = TenthUSPTOActionMailingDate
            .Fields!EleventhUSPTOActionMailingDate.Value = EleventhUSPTOActionMailingDate
            .Fields!TwelvethUSPTOActionMailingDate.Value = TwelvethUSPTOActionMailingDate

            .Fields!FirstUSPTOActionResponseDueDate.Value = FirstUSPTOActionResponseDueDate
            .Fields!SecondUSPTOActionResponseDueDate.Value = SecondUSPTOActionResponseDueDate
            .Fields!ThirdUSPTOActionResponseDueDate.Value = ThirdUSPTOActionResponseDueDate
            .Fields!FourthUSPTOActionResponseDueDate.Value = FourthUSPTOActionResponseDueDate
            .Fields!FifthUSPTOActionResponseDueDate.Value = FifthUSPTOActionResponseDueDate
            .Fields!SixthUSPTOActionResponseDueDate.Value = SixthUSPTOActionResponseDueDate
            .Fields!SeventhUSPTOActionResponseDueDate.Value = SeventhUSPTOActionResponseDueDate
            .Fields!EighthUSPTOActionResponseDueDate.Value = EighthUSPTOActionResponseDueDate
            .Fields!NinthUSPTOActionResponseDueDate.Value = NinthUSPTOActionResponseDueDate
            .Fields!TenthUSPTOActionResponseDueDate.Value = TenthUSPTOActionResponseDueDate
            .Fields!EleventhUSPTOActionResponseDueDate.Value = EleventhUSPTOActionResponseDueDate
            .Fields!TwelvethUSPTOActionResponseDueDate.Value = TwelvethUSPTOActionResponseDueDate

            .Fields!FirstUSPTOActionResponseMadeDate.Value = FirstUSPTOActionResponseMadeDate
            .Fields!SecondUSPTOActionResponseMadeDate.Value = SecondUSPTOActionResponseMadeDate
            .Fields!ThirdUSPTOActionResponseMadeDate.Value = ThirdUSPTOActionResponseMadeDate
            .Fields!FourthUSPTOActionResponseMadeDate.Value = FourthUSPTOActionResponseMadeDate
            .Fields!FifthUSPTOActionResponseMadeDate.Value = FifthUSPTOActionResponseMadeDate
            .Fields!SixthUSPTOActionResponseMadeDate.Value = SixthUSPTOActionResponseMadeDate
            .Fields!SeventhUSPTOActionResponseMadeDate.Value = SeventhUSPTOActionResponseMadeDate
            .Fields!EighthUSPTOActionResponseMadeDate.Value = EighthUSPTOActionResponseMadeDate
            .Fields!NinthUSPTOActionResponseMadeDate.Value = NinthUSPTOActionResponseMadeDate
            .Fields!TenthUSPTOActionResponseMadeDate.Value = TenthUSPTOActionResponseMadeDate
            .Fields!EleventhUSPTOActionResponseMadeDate.Value = EleventhUSPTOActionResponseMadeDate
            .Fields!TwelvethUSPTOActionResponseMadeDate.Value = TwelvethUSPTOActionResponseMadeDate


            .Fields!TypeOfFirstUSPTOAction.Value = Trim(TypeOfFirstUSPTOAction.ToString)
            .Fields!TypeOfSecondUSPTOAction.Value = Trim(TypeOfSecondUSPTOAction.ToString)
            .Fields!TypeOfThirdUSPTOAction.Value = Trim(TypeOfThirdUSPTOAction.ToString)
            .Fields!TypeOfFourthUSPTOAction.Value = Trim(TypeOfFourthUSPTOAction.ToString)
            .Fields!TypeOfFifthUSPTOAction.Value = Trim(TypeOfFifthUSPTOAction.ToString)
            .Fields!TypeOfSixthUSPTOAction.Value = Trim(TypeOfFifthUSPTOAction.ToString)
            .Fields!TypeOfSeventhUSPTOAction.Value = Trim(TypeOfSeventhUSPTOAction.ToString)
            .Fields!TypeOfEighthUSPTOAction.Value = Trim(TypeOfEighthUSPTOAction.ToString)
            .Fields!TypeOfNinthUSPTOAction.Value = Trim(TypeOfNinthUSPTOAction.ToString)
            .Fields!TypeOfTenthUSPTOAction.Value = Trim(TypeOfTenthUSPTOAction.ToString)
            .Fields!TypeOfEleventhUSPTOAction.Value = Trim(TypeOfEleventhUSPTOAction.ToString)
            .Fields!TypeOfTwelvethUSPTOAction.Value = Trim(TypeOfTwelvethUSPTOAction.ToString)

            .Fields!TypeOfFirstPatentOfficeResponse.Value = Trim(TypeOfFirstPatentOfficeResponse.ToString)
            .Fields!TypeOfSecondPatentOfficeResponse.Value = Trim(TypeOfSecondPatentOfficeResponse.ToString)
            .Fields!TypeOfThirdPatentOfficeResponse.Value = Trim(TypeOfThirdPatentOfficeResponse.ToString)
            .Fields!TypeOfFourthPatentOfficeResponse.Value = Trim(TypeOfFourthPatentOfficeResponse.ToString)
            .Fields!TypeOfFifthPatentOfficeResponse.Value = Trim(TypeOfFifthPatentOfficeResponse.ToString)
            .Fields!TypeOfSixthPatentOfficeResponse.Value = Trim(TypeOfSixthPatentOfficeResponse.ToString)
            .Fields!TypeOfSeventhPatentOfficeResponse.Value = Trim(TypeOfSeventhPatentOfficeResponse.ToString)
            .Fields!TypeOfEighthPatentOfficeResponse.Value = Trim(TypeOfEighthPatentOfficeResponse.ToString)
            .Fields!TypeOfNinthPatentOfficeResponse.Value = Trim(TypeOfNinthPatentOfficeResponse.ToString)
            .Fields!TypeOfTenthPatentOfficeResponse.Value = Trim(TypeOfTenthPatentOfficeResponse.ToString)
            .Fields!TypeOfEleventhPatentOfficeResponse.Value = Trim(TypeOfEleventhPatentOfficeResponse.ToString)
            .Fields!TypeOfTwelvethPatentOfficeResponse.Value = Trim(TypeOfTwelvethPatentOfficeResponse.ToString)

            .Update()
        End With
        CloseTableInRKLTrademarkDB()
        CloseConnectionToRKLTrademarkDB()
    End Sub
    Public Sub msgSavedTrademarkDocument()
        Dim Msg, Style, Title As String
        Dim Response

        Dim FullDocketNumber As String

        FullDocketNumber = DocketNumber & "-" & SubDocketNumber

        'Assemble and Send the Message
        Msg = "The Trademark Document for " & FullDocketNumber & " has been SAVED!"
        Title = "The Trademark Document for " & FullDocketNumber & " has been SAVED!!!"
        Style = vbInformation
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgMustNotEnterRecordWithDuplicateDNandSDN(ByVal tempInsertedSubDocketNumber As String)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "You have entered Docket Number: " & DocketNumber & " and Sub-Docket Number: " & tempInsertedSubDocketNumber & vbCrLf & vbCrLf _
                  & "There is already a Trademark Document in the Database for: " & DocketNumber & "-" & tempInsertedSubDocketNumber & vbCrLf & vbCrLf _
                  & "You MUST NOT enter a New Trademark Document with a Duplicate Docket Number and Sub-Docket Number!"
        Title = "You MUST NOT Have a Duplicate Docket Number and Sub-Docket Number!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgDocketNumberNotFound(ByVal tempDocketNumber As String)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "The Docket Number you entered ==> " & tempDocketNumber _
                & " <== was not " & vbCrLf & vbCrLf _
                & "found in the RKL Accounting Database." _
                & vbCrLf & vbCrLf _
                & "Please enter a Docket Number that is in RKL Accounting!"
        Title = "Please enter a Docket Number that is in RKL Accounting !!!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgSubDocketNumberNotFoundWhileTryingToDisplayRecords(ByRef Response As Integer, ByVal tempDocketNumber As String, ByVal tempSubDocketNumber As String)
        Dim Msg, Style, Title As String

        'Assemble and Send the Message
        Msg = "Sorry...I Did Not Find Sub-Docket: -" & tempSubDocketNumber &
                " For Your Main Docket Number: " & tempDocketNumber _
                & vbCrLf & vbCrLf &
                "Do you want to enter another Sub-Docket Number?" _
                & vbCrLf & vbCrLf &
                "  - If you Click 'Yes' then you will be able to enter another Sub-Docket Number." _
                 & vbCrLf & vbCrLf &
                "  - If you Click 'No' then this Screen will be Reset."
        Title = "I Did Not Find A Trademark Document For: " &
                 tempDocketNumber & "-" & tempSubDocketNumber & " !!!"
        Style = vbYesNo + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub AssignTrademarkRecordToDisplayFormFields(ByVal FormName As Form)
        'Dim tempTrademarkType As Integer
        'Dim ActionResponseDueDateToBeUsedToDetermineCurrentPatentStatus As Long
        'Dim ActionResponseDueDateSequenceNumberToBeUsedToCheckActionResponseMailingDateForStatus As Integer
        'Dim ActionResponseDueDateSequenceNumberToBeUsedToCheckActionResponseMadeDateForStatus As Integer
        'Dim ActionResponseMailingDateToBeUsedToDetermineCurrentPatentStatus As Long
        'Dim ActionResponseMadeDateToBeUsedToDetermineCurrentPatentStatus As Long

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'OpenConnectionToRKLTrademarkDB("RKLPatent.mdb")
        ''''''OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        'OpenTableInRKLTrademarkDB("PatentDocuments")
        ''''' OpenTableInRKLTrademarkDB("TrademarkDocuments")

        frmTrademarkDisplayOrParameterChanges.Show()

        With adoRKLTrademarkRecordset
            'Fields entered in Initial Screen
            'TrademarkDocumentCountryCode = .Fields!TrademarkDocumentCountryCode
            CategoryOfTrademarkType = Trim(.Fields!CategoryOfTrademarkType.Value.ToString)
            DocketNumber = Trim$(.Fields!DocketNumber.Value.ToString)
            OrigDocketNumber = DocketNumber
            SubDocketNumber = Trim$(.Fields!SubDocketNumber.Value.ToString)
            OrigSubDocketNumber = SubDocketNumber

            FullDocketNumber = Trim$(DocketNumber) & "-" & Trim$(SubDocketNumber)
            frmTrademarkDisplayOrParameterChanges.lblFormTitle.Text = "Trademark Document for " & FullDocketNumber
            frmTrademarkDisplayOrParameterChanges.txtFullDocketNumber.Text = FullDocketNumber    '.Fields!DocketNumber

            frmTrademarkDisplayOrParameterChanges.txtClientDocketNumber.Text = .Fields!ClientDocketNumber.Value.ToString
            OrigClientDocketNumber = .Fields!ClientDocketNumber.Value.ToString

            frmTrademarkDisplayOrParameterChanges.txtCountryCode.Text = .Fields!CountryCode.Value.ToString
            OrigtxtCountryCode = .Fields!CountryCode.Value.ToString

            frmTrademarkDisplayOrParameterChanges.txtResponsibleAttorney.Text = .Fields!ResponsibleAttorney.Value.ToString
            OrigResponsibleAttorney = .Fields!ResponsibleAttorney.Value.ToString

            frmTrademarkDisplayOrParameterChanges.txtTrademarkType.Text = .Fields!TrademarkType.Value.ToString
            OrigTrademarkType = .Fields!TrademarkType.Value.ToString

            'frmTrademarkDisplayOrParameterChanges.....TrademarkOwnersEntityStatus

            frmTrademarkDisplayOrParameterChanges.txtMarkText.Text = .Fields!MarkText.Value.ToString
            OrigMarkText = .Fields!MarkText.Value.ToString

            frmTrademarkDisplayOrParameterChanges.txtGoodsServicesUsedByMark.Text = .Fields!GoodsServicesUsedByMark.Value.ToString
            OrigGoodsServicesUsedByMark = .Fields!GoodsServicesUsedByMark.Value.ToString

            OrigStateRegistrationsOfMark = .Fields!StateRegistrationsOfMark.Value.ToString

            If .Fields!FirstUseDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtFirstUseDate.Text = ConvertFromRKLDate(.Fields!FirstUseDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtFirstUseDate.Text = "NONE"
            End If
            OrigFirstUseDate = .Fields!FirstUseDate.Value

            If .Fields!FirstUseDateInCommerce.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtFirstUseDateInCommerce.Text = ConvertFromRKLDate(.Fields!FirstUseDateInCommerce.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtFirstUseDateInCommerce.Text = "NONE"
            End If
            OrigFirstUseDateInCommerce = .Fields!FirstUseDateInCommerce.Value

            If CategoryOfTrademarkType = "Madrid Protocol" Then
                'With frmTrademarkDisplayOrParameterChanges
                '.grpMadridProtocolSerialNumber.Visible = True
                '.grpMadridProtocolSerialNumber.Font = RKLFont12B
                '.grpMadridProtocolSerialNumber.Text = "Madrid Protocol Serial No.:"
                frmTrademarkDisplayOrParameterChanges.txtMadridProtocolSerialNumber.Font = RKLFont12B
                frmTrademarkDisplayOrParameterChanges.txtMadridProtocolSerialNumber.Text = .Fields!MadridProtocolSerialNumber.Value.ToString
                frmTrademarkDisplayOrParameterChanges.txtMadridProtocolSerialNumber.BackColor = clrSpringGreen
                frmTrademarkDisplayOrParameterChanges.txtMadridProtocolSerialNumber.ReadOnly = True

                '.grpWIPOFilingDate.Visible = True
                '.grpWIPOFilingDate.Font = RKLFont12B
                '.grpWIPOFilingDate.Text = "WIPO Filing Date"
                frmTrademarkDisplayOrParameterChanges.txtWIPOFilingDate.Font = RKLFont12B
                frmTrademarkDisplayOrParameterChanges.txtWIPOFilingDate.Text = ConvertFromRKLDate(.Fields!WIPOFilingDate.Value, "MonthNumber")
                frmTrademarkDisplayOrParameterChanges.txtWIPOFilingDate.BackColor = clrSpringGreen
                frmTrademarkDisplayOrParameterChanges.txtWIPOFilingDate.ReadOnly = True
                'End With
            Else
                frmTrademarkDisplayOrParameterChanges.grpMadridProtocolSerialNumber.Visible = False
                frmTrademarkDisplayOrParameterChanges.grpWIPOFilingDate.Visible = False
            End If

            'First Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived1st.Text = .Fields!TypeOfFirstUSPTOAction.Value.ToString
            'Dim tttempp As String
            'tttempp = frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived1st.Text
            'Dim tttempp2 As String
            'tttempp2 = .Fields!TypeOfFirstUSPTOAction.Value.ToString()

            frmTrademarkDisplayOrParameterChanges.txtResponseType1st.Text = .Fields!TypeOfFirstPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!FirstUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate1st.Text = ConvertFromRKLDate(.Fields!FirstUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate1st.Text = "NONE"
            End If
            If .Fields!FirstUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate1st.Text = ConvertFromRKLDate(.Fields!FirstUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate1st.Text = "NONE"
            End If
            If .Fields!FirstUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate1st.Text = ConvertFromRKLDate(.Fields!FirstUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate1st.Text = "NONE"
            End If
            'End of First Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Second Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived2nd.Text = .Fields!TypeOfSecondUSPTOAction.Value.ToString
            'frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived2nd.Text = "Duh"
            'Dim tempValue As String
            'tempValue = .Fields!TypeOfSecondUSPTOAction.Value.ToString
            frmTrademarkDisplayOrParameterChanges.txtResponseType2nd.Text = .Fields!TypeOfSecondPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!SecondUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate2nd.Text = ConvertFromRKLDate(.Fields!SecondUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate2nd.Text = "NONE"
            End If
            If .Fields!SecondUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate2nd.Text = ConvertFromRKLDate(.Fields!SecondUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate2nd.Text = "NONE"
            End If
            If .Fields!SecondUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate2nd.Text = ConvertFromRKLDate(.Fields!SecondUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate2nd.Text = "NONE"
            End If
            'End of Second Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Third Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived3rd.Text = .Fields!TypeOfThirdUSPTOAction.Value.ToString
            frmTrademarkDisplayOrParameterChanges.txtResponseType3rd.Text = .Fields!TypeOfThirdPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!ThirdUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate3rd.Text = ConvertFromRKLDate(.Fields!ThirdUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate3rd.Text = "NONE"
            End If
            If .Fields!ThirdUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate3rd.Text = ConvertFromRKLDate(.Fields!ThirdUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate3rd.Text = "NONE"
            End If
            If .Fields!ThirdUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate3rd.Text = ConvertFromRKLDate(.Fields!ThirdUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate3rd.Text = "NONE"
            End If
            'End of Third Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Fourth Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived4th.Text = .Fields!TypeOfFourthUSPTOAction.Value.ToString
            frmTrademarkDisplayOrParameterChanges.txtResponseType4th.Text = .Fields!TypeOfFourthPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!FourthUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate4th.Text = ConvertFromRKLDate(.Fields!FourthUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate4th.Text = "NONE"
            End If
            If .Fields!FourthUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate4th.Text = ConvertFromRKLDate(.Fields!FourthUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate4th.Text = "NONE"
            End If
            If .Fields!FourthUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate4th.Text = ConvertFromRKLDate(.Fields!FourthUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate4th.Text = "NONE"
            End If
            'End of Fourth Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Fifth Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived5th.Text = .Fields!TypeOfFifthUSPTOAction.Value.ToString
            frmTrademarkDisplayOrParameterChanges.txtResponseType5th.Text = .Fields!TypeOfFifthPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!FifthUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate5th.Text = ConvertFromRKLDate(.Fields!FifthUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate5th.Text = "NONE"
            End If
            If .Fields!FifthUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate5th.Text = ConvertFromRKLDate(.Fields!FifthUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate5th.Text = "NONE"
            End If
            If .Fields!FifthUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate5th.Text = ConvertFromRKLDate(.Fields!FifthUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate5th.Text = "NONE"
            End If
            'End of Fifth Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Sixth Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields
            frmTrademarkDisplayOrParameterChanges.txtActionTypeReceived6th.Text = .Fields!TypeOfSixthUSPTOAction.Value.ToString
            frmTrademarkDisplayOrParameterChanges.txtResponseType6th.Text = .Fields!TypeOfSixthPatentOfficeResponse.Value.ToString
            ''Date Fields
            If .Fields!SixthUSPTOActionMailingDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtMailingDate6th.Text = ConvertFromRKLDate(.Fields!SixthUSPTOActionMailingDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtMailingDate6th.Text = "NONE"
            End If
            If .Fields!SixthUSPTOActionResponseDueDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate6th.Text = ConvertFromRKLDate(.Fields!SixthUSPTOActionResponseDueDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseDueDate6th.Text = "NONE"
            End If
            If .Fields!SixthUSPTOActionResponseMadeDate.Value > 0 Then
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate6th.Text = ConvertFromRKLDate(.Fields!SixthUSPTOActionResponseMadeDate.Value, "MonthNumber")
            Else
                frmTrademarkDisplayOrParameterChanges.txtResponseMadeDate6th.Text = "NONE"
            End If
            'End of Sixth Action^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Seventh Action>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ''Text Fields

            ''Date Fields
        End With
        'CloseTableInRKLTrademarkDB()
        'CloseConnectionToRKLTrademarkDB()
    End Sub
    Public Sub msgMustHaveMR()
        Dim Msg As String
        Dim Style As String
        Dim Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "You MUST enter ==> MR <== as the first " _
                & "two characters of the Docket Number."
        Title = "Please be sure to enter MR"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgSubDocketNumberMustNotBeOneOrZero(ByVal tempSubDocketNumberFromForm As Integer)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "The Sub-Docket Number must NOT be " & tempSubDocketNumberFromForm & " !" &
                vbCrLf & vbCrLf &
                "Please re-enter a correct Sub-Docket Number."
        Title = "The Sub-Docket Number must NOT be " & tempSubDocketNumberFromForm & " !"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)

    End Sub
    Public Sub ValidateInsertedSDN(ByVal InsertedSDN As String, ByVal FormName As Form)
        'The following ADDED on 9/8/17 in Accounting
        '>>>>>>>>>>>>>>>>>>Example of how to use this Sub
        'With Me
        '    If Len(Trim$(.txtField(0).Text)) > 0 Then
        '        HaveSentASubDocketNumberMessageToUser = False
        '        Call ValidateInsertedSDN(Trim$(.txtField(0).Text), Me)
        '        If HaveSentASubDocketNumberMessageToUser = True Then
        '            .cmdDoneEnterNewSubDocketNumber.Enabled = False
        '            .txtField(0).Text = ""
        '            .txtField(0).SetFocus
        '        Else
        '            .txtField(0).Locked = True
        '            .fraField(0).BackColor = &HC0E0FF  'Lightest Orange
        '            'Enable the next Frame and txtField
        '            .fraField(1).Enabled = True
        '            .fraField(1).Caption = "Type In The Person To Whom Statement Is Being Sent"
        '            .fraField(1).BackColor = &H80C0FF 'Light Orange
        '            .txtField(1).Enabled = True
        '            .txtField(1).Left = 1200
        '            .cmdDoneNameToBeSent.Left = 5800
        '            .txtField(1).SetFocus
        '            .cmdDoneEnterNewSubDocketNumber.Enabled = False
        '        End If
        '    Else
        '        HaveSentASubDocketNumberMessageToUser = False
        '        .cmdDoneEnterNewSubDocketNumber.Enabled = False
        '        Call msgSubDocketNumberMustNotBeBlank
        '        .txtField(0).SetFocus
        '    End If
        'End With
        '^^^^End of Example^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        'The purpose of this Routine is verify that the Entered Sub-Docket Number passes the following Validations BEFORE the User is allowed to procede:
        '    1) Was the number "2" Inserted as the SDN - If so, exit this routine because no more validation is needed
        '    2) The BASE-SDN is not '0' or '1'
        '    3) Does not contain BAD (non-Valid-Seperator) characters
        '    4) Does contain Valid-Seperator Characters - There can be multiple seperator characters
        '    5) If SDN doesn't contain BAD chars nor a Valid-Seperator but does contain numbers and letters, then send a Warning Msg to the User
        '    6) The Base-SDN Is NOT Greater than one-more than the HIGHEST Sub-Docket number that has been assign to this Docket
        '        -- This rule does not apply if SDN is = 2
        '        -- If the Base-SDN is Greater than one-more than the HIGHEST Sub-Docket number then send a message to the User
        '    NOTE: Per Mort, Duplicate SDN's are allowed ==> in ACCOUNTING ONLY

        ''See if the reason for Losing Focus is because the cmdCancel button was clicked - If so then initiate the cmdCancel functions
        'If Me.cmdCancel.Value = True Then
        '     Exit Sub
        'End If
        '''''If (Len(Trim$(Me.txtField(0))) = 0) And Not HaveSentASubDocketNumberMessageToUser Then
        '''''     HaveSentASubDocketNumberMessageToUser = True
        '''''     Call msgSubDocketNumberMustNotBeBlank
        '''''     Me.txtField(0).SetFocus
        '''''     Exit Sub
        '''''End If

        'Define local variables
        Dim strFormName As String

        Dim InsertedDocketNumber As String
        Dim PositionOfSDNSeperatorFound As Boolean
        Dim DashPosition As Integer
        Dim FindDocketNumber As String

        Dim LeftTwoCharsOfInsertedDocketNumber As String

        Dim PositionOfSDNSeperator As Integer
        '<This Variable was moved to Global.General and made Public on 9/11/17>
        'Dim PositionOfSDNSeperatorFound As Boolean
        '</This Variable was moved to Global.General and made Public>

        Dim InsertedSubDocketNumber As String
        Dim LenInsertedSubDocketNumber As Integer
        'Dim InsertededBaseSubDocketNumber As Integer
        Dim BaseSubDocketNumber As String
        Dim strBaseSubDocketNumber As String
        Dim HighestSubDocketNumber As Integer

        'Dim HaveSentASubDocketNumberMessageToUser As Boolean

        Dim CharacterToTest As String
        Dim CharPos As Long
        Dim PositionOfBadCharacter As Integer
        Dim BADCharacterFound As Boolean

        Dim TestCharInFirstPosition As String
        Dim TestForNumberInFirstPosition As Integer
        Dim TestCharInSecondPosition As String
        Dim TestForNumberInSecondPosition As Integer

        'strFormName = FormName.Name

        'Select Case CurrentFormName
        '    'Case "frmPrepareWorkOrderOrDisclosureExistingClient"
        '    '    InsertedDocketNumber = Trim$(frmPrepareWorkOrderOrDisclosureExistingClient.txtDocketNumber.Text)
        '    '    InsertedSubDocketNumber = Trim$(frmPrepareWorkOrderOrDisclosureExistingClient.txtField(0).Text)
        '    'Case "frmPrepareStatmentOrBillExistingClient"
        '    '    InsertedDocketNumber = Trim$(frmPrepareStatmentOrBillExistingClient.txtDocketNumber.Text)
        '    '    InsertedSubDocketNumber = Trim$(frmPrepareStatmentOrBillExistingClient.txtField(0).Text)
        '    Case "frmChangeDNandSDN"
        InsertedDocketNumber = CurrentRKLDocket
        InsertedSubDocketNumber = Trim$(frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text)
        'End Select

        LenInsertedSubDocketNumber = InsertedSubDocketNumber.Length

        'See if the FIRST Charactered in the Inserted SDN is a Number - If not, send the user a message
        TestCharInFirstPosition = Mid(InsertedSubDocketNumber, 1, 1)
        TestForNumberInFirstPosition = Asc(TestCharInFirstPosition)
        If TestForNumberInFirstPosition < 48 Or TestForNumberInFirstPosition > 57 Then  'This First Char of the Inserted SDN is NOT a number
            HaveSentASubDocketNumberMessageToUser = True
            Call msgSubDocketNumberFirstCharacterMustBeANumber(TestCharInFirstPosition)
            'Clear the Inserted SubDocket Number Field and Re-set it's Focus
            'Select Case strFormName
            '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
            '        FormName.txtField(0).Text = ""
            '        FormName.txtField(0).SetFocus
            '    Case "frmChangeParameterValue"
            frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
            frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
            'End Select
            Exit Sub
        Else
            'See if the First Char of this Numeric is a "1" or "0" - If so, see if there ia a SECOND char, if so see if it is a Number - If not then send the User a Msg
            If TestForNumberInFirstPosition = 48 Or TestForNumberInFirstPosition = 49 Then  'This First Char of the Inserted SDN is either a 1 or a 0
                If LenInsertedSubDocketNumber >= 2 Then 'The First Char is either "0" or "1" so see if the Second Char is a Number - If so, then a "1" in the First Position is OK
                    TestCharInSecondPosition = Mid(InsertedSubDocketNumber, 2, 1)
                    TestForNumberInSecondPosition = Asc(TestCharInSecondPosition)
                    If (TestForNumberInSecondPosition < 48 Or TestForNumberInSecondPosition > 57) Or (TestForNumberInFirstPosition = 48) Then  'This Second Char of the Inserted SDN is NOT a number - So, send a msg to User
                        HaveSentASubDocketNumberMessageToUser = True
                        Call msgSubDocketNumberMustNotBeOneOrZero(InsertedSubDocketNumber)
                        'Clear the Inserted SubDocket Number Field and Re-set it's Focus
                        'Select Case strFormName
                        '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
                        '        FormName.txtField(0).Text = ""
                        '        FormName.txtField(0).SetFocus
                        '    Case "frmChangeParameterValue"
                        frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
                        frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
                        'End Select
                        Exit Sub
                    End If
                End If
            End If
        End If

        If IsNumeric(InsertedSubDocketNumber) Then
            'See if the Inserted SDN is = 2 which means that this is a new client and therefore the first SDN is always 2 - So no need to
            '  do any more SDN Validation checking
            If (Trim$(InsertedSubDocketNumber) = "2") Then
                HaveSentASubDocketNumberMessageToUser = False
                Exit Sub
            End If
            'See if a Zero/0 or One/1 was entered as a SubDocket number - If so send a msg and clear the value
            ''''''     HaveSentASubDocketNumberMessageToUser = False
            If ((Val(Trim$(InsertedSubDocketNumber)) = 0) Or (Val(Trim$(InsertedSubDocketNumber)) = 1)) And Not HaveSentASubDocketNumberMessageToUser Then
                HaveSentASubDocketNumberMessageToUser = True
                Call msgSubDocketNumberMustNotBeOneOrZero(InsertedSubDocketNumber)
                'Clear the Inserted SubDocket Number Field and Re-set it's Focus
                'Select Case strFormName
                '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
                '        FormName.txtField(0).Text = ""
                '        FormName.txtField(0).SetFocus
                '    Case "frmChangeParameterValue"
                frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
                frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
                'End Select
                Exit Sub
            End If
        End If

        'Check NewSubDocketNumber for the existance of a character other than:
        '  numbers, lower-case alpha, upper-case alpha or "-" or "/" or "."
        ' Look for the bad chars by holding each char and comparing it to the correct ANSI chars
        Do Until (CharPos >= LenInsertedSubDocketNumber) Or BADCharacterFound
            For CharPos = 1 To LenInsertedSubDocketNumber
                'Check for numbers, or lower-case alphas, or upper-case alphas in each char of NewSubDocketNumber
                CharacterToTest = Mid(InsertedSubDocketNumber, CharPos, 1)
                Select Case Asc(CharacterToTest)
                    Case 48 To 57 'Numbers 0 thru 9
                        BADCharacterFound = False
                    Case 65 To 90 'Upper-case Alphabet
                        BADCharacterFound = False
                    Case 97 To 122 'Lower-case Alphabet
                        BADCharacterFound = False
                    Case 45, 46, 47 ' - or . or /
                        BADCharacterFound = False
                    Case Else
                        BADCharacterFound = True
                        PositionOfBadCharacter = CharPos
                        Exit Do
                End Select
            Next CharPos
        Loop
        If BADCharacterFound Then
            'Send msg to usr about the Bad Char
            HaveSentASubDocketNumberMessageToUser = True
            Call msgBADCharacterFound(InsertedSubDocketNumber, PositionOfBadCharacter)
            'Clear the Inserted SubDocket Number Field and Re-set it's Focus
            'Select Case strFormName
            '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
            '        FormName.txtField(0).Text = ""
            '        FormName.txtField(0).SetFocus
            '    Case "frmChangeParameterValue"
            frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
            frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
            'End Select
            Exit Sub
        End If

        '--------------------------------------------------------------------------------------------
        'At this Point the New SDN MAY not have any of the Valid-Seperators and must be checked to see if the User entered ONLY
        '   Numbers and Non-Valid-Seperator Characters - If so, then send the User a WARNING Message
        'First check to see if any the Valid Seperators are in the NEW-SDN - Is so, the New SDN can move to the remaining program steps
        '  If not, and is not-numeric then send a WARNING Message to the User
        '--------------------------------------------------------------------------------------------

        'Look for/Check that one of the Seperator charactors is in the New SubDocket Number
        PositionOfSDNSeperatorFound = False
        If Not IsNumeric(InsertedSubDocketNumber) Then
            'Check for "-"
            PositionOfSDNSeperator = InStr(1, InsertedSubDocketNumber, "-")
            If PositionOfSDNSeperator > 0 Then
                BaseSubDocketNumber = Left(InsertedSubDocketNumber, PositionOfSDNSeperator - 1)
                PositionOfSDNSeperatorFound = True
            End If

            'Check for "."
            PositionOfSDNSeperator = InStr(1, InsertedSubDocketNumber, ".")
            If PositionOfSDNSeperator > 0 Then
                BaseSubDocketNumber = Left(InsertedSubDocketNumber, PositionOfSDNSeperator - 1)
                PositionOfSDNSeperatorFound = True
            End If

            'Check for "/"
            PositionOfSDNSeperator = InStr(1, InsertedSubDocketNumber, "/")
            If PositionOfSDNSeperator > 0 Then
                BaseSubDocketNumber = Left(InsertedSubDocketNumber, PositionOfSDNSeperator - 1)
                PositionOfSDNSeperatorFound = True
            End If

            If (PositionOfSDNSeperator = 0) And Not PositionOfSDNSeperatorFound Then  'No acceptable seperator is being used
                'Now check to see if any other Non-Numbers are in the ORIGINAL-SDN - Is so, put the Non-Numbers in strBaseSubDocketNumber
                If IsNumeric(InsertedSubDocketNumber) Then
                    BaseSubDocketNumber = InsertedSubDocketNumber
                Else
                    'At this point, it was determined that oldSubDocketNumber containes a non-number - So, locate and seperate the
                    '   Non-Numbers from the Numbers and put them in seperate Variables
                    For CharPos = 1 To Len(InsertedSubDocketNumber)
                        'Check each Char for non-number
                        CharacterToTest = Mid$(InsertedSubDocketNumber, CharPos, 1)
                        If Not IsNumeric(CharacterToTest) Then
                            'A non-number has been found at the CharPos, so - place the two parts in in Seperate Variables
                            BaseSubDocketNumber = Mid$(InsertedSubDocketNumber, 1, CharPos - 1)
                            strBaseSubDocketNumber = Mid$(InsertedSubDocketNumber, CharPos, Len(InsertedSubDocketNumber))
                            Exit For
                        End If
                    Next CharPos
                End If
            End If

            If Not PositionOfSDNSeperatorFound Then
                'Send the Warning Message
                HaveSentASubDocketNumberMessageToUser = True
                Dim Response As Integer
                Call msgSDNDoesNotHaveAValidSeperator(InsertedSubDocketNumber, Response)
                Select Case Response
                    Case 6 'Yes
                        HaveSentASubDocketNumberMessageToUser = False
                         'Do nothing - Just let the program continue
                    Case 7 'No
                        'Clear the Inserted SubDocket Number Field and Re-set it's Focus so that another fresh SDN can be entered
                        'Select Case strFormName
                        '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
                        '        FormName.txtField(0).Text = ""
                        '        FormName.txtField(0).SetFocus
                        '    Case "frmChangeParameterValue"
                        frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
                        frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
                        'End Select
                        Exit Sub
                End Select
            End If
        Else
            BaseSubDocketNumber = Val(InsertedSubDocketNumber)
        End If

        'Find the matching Docket Number and GET its Highest SubDocketNumber
        OpenConnectionToRKLTrademarkDB("rklaccountingDB.mdb")
        OpenTableInRKLTrademarkDB("Docket")

        With adoRKLTrademarkRecordset
            FindDocketNumber = "DocketNumber = " & "'" & InsertedDocketNumber & "'" & ""
            .Find(FindDocketNumber)

            'Get the Highest SubDocket Number assigned from the RKL DB
            HighestSubDocketNumber = .Fields!HighestNumericalSubDocketNumberForADocketNumber.Value.ToString

            'See if the Input SubDocket is HIGHER than the one stored in the DB
            If BaseSubDocketNumber > HighestSubDocketNumber + 1 Then
                'Send a message to the User
                HaveSentASubDocketNumberMessageToUser = True
                Call msgSubDocketNoOverHighest(HighestSubDocketNumber, InsertedSubDocketNumber)
                'Clear the New SubDocket Number Field and Re-set it's Focus
                'Select Case strFormName
                '    Case "frmPrepareWorkOrderOrDisclosureExistingClient", "frmPrepareStatmentOrBillExistingClient"
                '        FormName.txtField(0).Text = ""
                '        FormName.txtField(0).SetFocus
                '        'Close the Docket Table
                '        CloseTableInRKLdb
                '        'Close the Connection
                '        CloseConnectionToRKLdb
                'Case "frmChangeParameterValue"
                frmChangeDNandSDN.txtEnterNewSubDocketNumber.Text = ""
                frmChangeDNandSDN.txtEnterNewSubDocketNumber.Focus()
                'End Select

                '<Removed by: Project Administrator at: 9/10/2017-11:18:06 on machine: MARV-PC>
                '         'Close the Docket Table
                '         CloseTableInRKLdb
                '         'Close the Connection
                '         CloseConnectionToRKLdb
                '</Removed by: Project Administrator at: 9/10/2017-11:18:06 on machine: MARV-PC>
                Exit Sub
            Else 'Just Close the Docket Table since the Input SDN is not > then Highest SDN + 1
                '<Removed by: Project Administrator at: 9/10/2017-11:18:43 on machine: MARV-PC>
                '         'Close the Docket Table
                '         CloseTableInRKLdb
                '</Removed by: Project Administrator at: 9/10/2017-11:18:43 on machine: MARV-PC>

                'set up the Next Field in the appropriate form
                '                Select Case strFormName
                '                    Case "frmPrepareWorkOrderOrDisclosureExistingClient"
                '                        'Close the Docket Table
                '                        CloseTableInRKLdb
                '                        frmPrepareWorkOrderOrDisclosureExistingClient.txtField(1).SetFocus
                '                    Case "frmPrepareStatmentOrBillExistingClient"
                '                        'Close the Docket Table
                '                        CloseTableInRKLdb
                ''                         InsertedDocketNumber = Trim$(frmPrepareStatmentOrBillExistingClient.txtDocketNumber.Text)
                ''                         InsertedSubDocketNumber = Trim$(frmPrepareStatmentOrBillExistingClient.txtField(0).Text)
                '                    Case "frmChangeParameterValue"
                '                         InsertedDocketNumber = CurrentRKLDocket
                '                         InsertedSubDocketNumber = Trim$(frmChangeParameterValue.txtNewParameterValue.Text)
                'End Select

                '''''''''         Me.txtField(1).SetFocus
                Exit Sub
            End If 'Test for: tempSubDocketNumberFromForm > tempHighestSubDocketNumber + 1

            '<Removed by: Project Administrator at: 9/10/2017-11:20:13 on machine: MARV-PC>
            ' CloseTableInRKLdb
            '</Removed by: Project Administrator at: 9/10/2017-11:20:13 on machine: MARV-PC>
        End With

    End Sub
    Public Sub msgSubDocketNumberFirstCharacterMustBeANumber(ByVal TestChar As String)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "The first character you entered ==> " & TestChar & " <== is not a number!" _
                & vbCrLf & vbCrLf &
                "The First Character of the Sub-Docket Number must only be a NUMBER." &
                vbCrLf & vbCrLf &
                "Please re-enter a correct Sub-Docket Number."
        Title = "Please be sure to enter a Numerical First Character in the Sub-Docket Number!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgBADCharacterFound(NewSubDocketNumber As String, PositionOfBadCharacter As Integer)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "The Sub-Docket Number you entered ==> " & NewSubDocketNumber & "<== contains an " &
              "incorrect character in position number: " & Trim$(Str$(PositionOfBadCharacter)) _
              & vbCr & vbCr &
              "1) Only numbers and letters are allowed, and" & vbCr &
              "2) Multiple seperators are allowed, and" & vbCr &
              "3) A seperator can only be either '/' or '-' or '.'" & vbCr & vbCr &
              "Please enter a correct Sub-Docket Number."

        Title = "The Sub-Docket Number You Entered Contains a BAD Character!!!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)

    End Sub
    Public Sub msgSDNDoesNotHaveAValidSeperator(ByVal NewSDN As String, ByRef Response As Integer)
        Dim Msg, Style, Title As String

        Msg = "The Sub-Docket Number you entered ==>" & NewSDN & " <== contains both NUMBERS and LETTERS " &
                "but does not contain any of the Valid Seperators!" _
        & vbCrLf & vbCrLf &
        " A Valid Seperator can only be either '/' or '-' or '.' " _
        & vbCrLf & vbCrLf &
        "Do you want to use this Sub-Docket Number?  ==> " & NewSDN _
        & vbCrLf & vbCrLf &
        "  1. Click on the 'Yes' button to use this Sub-Docket Number." _
        & vbCrLf & vbCrLf &
        "  2. Click on the 'No' button to enter a different Sub-Docket Number."

        Title = "Do You Want to Use this Sub-Docket Number ==> " & NewSDN & " !!!"

        Style = vbYesNo + vbExclamation

        Response = MsgBox(Msg, Style, Title)

    End Sub
    Public Sub msgSubDocketNoOverHighest(ByVal tempHighestSubDocketNumber As Integer,
                                     ByVal tempSubDocketNumberFromForm As Double)
        Dim Msg, Style, Title As String
        Dim Response As Integer

        'Assemble and Send the Message
        Msg = "           Warning...There is a Fatal Error!!!" & vbCrLf & vbCrLf &
                "The highest Sub-Docket Number for " & CurrentRKLDocket &
                " is " & Trim$(Str$(tempHighestSubDocketNumber)) & "." &
                vbCrLf & vbCrLf &
                "You are trying to insert Sub-Docket Number " &
                Trim$(Str$(tempSubDocketNumberFromForm)) & "." &
                vbCrLf & vbCrLf &
                "Which is not a proper Sub-Docket Number." &
                vbCrLf & vbCrLf &
                "Please re-enter a correct Sub-Docket Number, which should be no higher than " _
                & tempHighestSubDocketNumber + 1 & "."
        Title = "Please Be Sure To Enter A Proper Sub-Docket Number!!!"
        Style = vbOKOnly + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub OpenConnectionToRKLAccountingDB(ByVal RKLDb As String)
        '  Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\Admin\Marv's Folder\Mort\Patent DB\RKLPatent.mdb"
        'Purpose of this Routine
        ' 1) Connect and Open the RKLTrademark.mdb Database
        ' 2) The Variable adoRKLDBConnection is a Public variable which will be
        '      available as the RKLDb Connection for all Routines
        ' ==> Open connection Example <==
        '    strCnxn = "Provider='sqloledb';Data Source='MySqlServer';" &
        '            "Initial Catalog='Pubs';Integrated Security='SSPI';"
        '    Set Cnxn = New ADODB.Connection  
        '    Cnxn.Open strCnxn  
        '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        Dim stradoRKLAccountingDBConnection As String
        ''''Public adoRKLDBConnection As ADODB.Connection

        stradoRKLAccountingDBConnection = "Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" & PathToAccountingDB &
            "\" & RKLDb & ";" & "Persist Security Info=False"

        adoRKLAccountingDBConnection = New ADODB.Connection

        adoRKLAccountingDBConnection.Open(stradoRKLAccountingDBConnection)        'Define Connection to the RKLDb
        adoRKLAccountingDBConnectIsOpen = True
    End Sub
    Public Sub CloseConnectionToRKLAccountingDB()
        If adoRKLAccountingDBConnectIsOpen Then
            adoRKLAccountingDBConnection.Close()
            adoRKLAccountingDBConnection = Nothing
            adoRKLAccountingDBConnectIsOpen = False
        End If
    End Sub
    Public Sub OpenTableInRKLAccountingDB(ByVal RKLTable As String)
        Dim tempRKLTable As String
        tempRKLTable = Trim(RKLTable)

        Try
            adoRKLAccountingRecordset.Open(tempRKLTable, adoRKLAccountingDBConnection,
               ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        Catch
            Exit Sub
        End Try
    End Sub
    Public Sub CloseTableInRKLAccountingDB()
        On Error Resume Next
        adoRKLAccountingRecordset.Close()
    End Sub
    Public Sub msgDocketNumberNotFoundWhileTryingToDisplayRecords(ByRef Response As Integer, ByVal tempDocketNumber As String)
        Dim Msg, Style, Title As String

        'Assemble and Send the Message
        Msg = "Sorry...I Did Not Find Docket Number: " & tempDocketNumber _
                & " in the Trademark Database." _
                & vbCrLf & vbCrLf &
                "Do you want to enter another Docket Number?" _
                & vbCrLf & vbCrLf &
                "  - If you Click 'Yes' then you will be able to enter another Docket Number." _
                 & vbCrLf & vbCrLf &
                "  - If you Click 'No' then this Screen will be Reset."
        Title = "I Did Not Find A Trademark Document For: " &
                 tempDocketNumber & " !!!"
        Style = vbYesNo + vbCritical
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(ByRef Response As Integer)
        Dim Msg, Style, Title As String

        'Assemble and Send the Message
        Msg = "There are no further Patent Documents left in the computer " &
              "records according to your reference criteria!" _
                & vbCrLf & vbCrLf &
                "Do you want to display other Patent Documents?" _
                & vbCrLf & vbCrLf &
                "YOU HAVE THREE(3) CHOICES AS FOLLOWS:" _
                & vbCrLf & vbCrLf &
                "  1. Click on the 'Yes' button to enter new criteria." _
                & vbCrLf & vbCrLf &
                "  2. Click on the 'No' button to stop displaying other Patent Documents." _
                & vbCrLf & "      (You will be taken to the Menu Screen)." _
                & vbCrLf & vbCrLf &
                "  3. Click on the 'Cancel' button to continue reviewing using your current criteria."
        Title = "There Are No Further Paternt Documents Left In The Computer Records!!!"
        Style = vbYesNoCancel + vbExclamation
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgSureWantToUseGeneralDocketNumber(ByRef Response As Integer)
        Dim Msg, Style, Title As String
        'Dim Response As Integer

        'Assemble and Send the Message
        Msg = "You have selected to Reference and View ALL Trademark Documents by a General Docket Number!" &
                vbCrLf & vbCrLf &
                "Be aware that there may be a large number of Trademark Documents to View and Click-Through." &
                vbCrLf & vbCrLf & "Do you want to continue to view these Trademark Documents?"
        Title = "Do You Want to View ALL of These Trademark Documents?"
        Style = vbYesNo + vbQuestion
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub msgSureWantToSaveChangedDataFields(ByRef Response As Integer)
        Dim Msg, Style, Title As String

        'Assemble and Send the Message
        Msg = "Are you SURE you want to SAVE the changes you made in the computer records?" &
                vbCrLf & vbCrLf &
                "                                                                  R E M E M B E R" &
                vbCrLf & vbCrLf &
                "If you click the 'Yes' button then " &
                "everything you CHANGED on this screen will be SAVED!" &
                vbCrLf & vbCrLf &
                "If you click the 'No' button then " &
                "everything you CHANGED on the screen will be VOIDED " &
                "and nothing will be saved!!!" &
                vbCrLf & vbCrLf &
                "If you click the 'Cancel' button then " &
                "you will be returned to the Patent Display screen."
        Title = "Computer Storage double Check - Are you SURE you want this " &
                "SAVED in the computer records?"
        Style = vbYesNoCancel + vbQuestion
        Response = MsgBox(Msg, Style, Title)
    End Sub
    Public Sub AssignStateNamesToAnArray()
        arrStateNames(1, 1) = “Alabama”
        arrStateNames(1, 2) = “AL“
        arrStateNames(2, 1) = “Alaska”
        arrStateNames(2, 2) = “AK“
        arrStateNames(3, 1) = “Arizona”
        arrStateNames(3, 2) = “AZ“
        arrStateNames(4, 1) = “Arkansas”
        arrStateNames(4, 2) = “AR“
        arrStateNames(5, 1) = “California”
        arrStateNames(5, 2) = “CA“
        arrStateNames(6, 1) = “Colorado”
        arrStateNames(6, 2) = “CO“
        arrStateNames(7, 1) = “Connecticut”
        arrStateNames(7, 2) = “CT“
        arrStateNames(8, 1) = “Delaware”
        arrStateNames(8, 2) = “DE“
        arrStateNames(9, 1) = “Florida”
        arrStateNames(9, 2) = “FL“
        arrStateNames(10, 1) = “Georgia”
        arrStateNames(10, 2) = “GA“
        arrStateNames(11, 1) = “Hawaii”
        arrStateNames(11, 2) = “HI“
        arrStateNames(12, 1) = “Idaho”
        arrStateNames(12, 2) = “ID“
        arrStateNames(13, 1) = “Illinois”
        arrStateNames(13, 2) = “IL“
        arrStateNames(14, 1) = “Indiana”
        arrStateNames(14, 2) = “IN“
        arrStateNames(15, 1) = “Iowa”
        arrStateNames(15, 2) = “IA“
        arrStateNames(16, 1) = “Kansas”
        arrStateNames(16, 2) = “KS“
        arrStateNames(17, 1) = “Kentucky”
        arrStateNames(17, 2) = “KY“
        arrStateNames(18, 1) = “Louisiana”
        arrStateNames(18, 2) = “LA“
        arrStateNames(19, 1) = “Maine”
        arrStateNames(19, 2) = “ME“
        arrStateNames(20, 1) = “Maryland”
        arrStateNames(20, 2) = “MD“
        arrStateNames(21, 1) = “Massachusetts”
        arrStateNames(21, 2) = “MA“
        arrStateNames(22, 1) = “Michigan”
        arrStateNames(22, 2) = “MI“
        arrStateNames(23, 1) = “Minnesota”
        arrStateNames(23, 2) = “MN“
        arrStateNames(24, 1) = “Mississippi”
        arrStateNames(24, 2) = “MS“
        arrStateNames(25, 1) = “Missouri”
        arrStateNames(25, 2) = “MO“
        arrStateNames(26, 1) = “Montana”
        arrStateNames(26, 2) = “MT“
        arrStateNames(27, 1) = “Nebraska”
        arrStateNames(27, 2) = “NE“
        arrStateNames(28, 1) = “Nevada”
        arrStateNames(28, 2) = “NV“
        arrStateNames(29, 1) = “New Hampshire”
        arrStateNames(29, 2) = “NH“
        arrStateNames(30, 1) = “New Jersey”
        arrStateNames(30, 2) = “NJ“
        arrStateNames(31, 1) = “New Mexico”
        arrStateNames(31, 2) = “NM“
        arrStateNames(32, 1) = “New York”
        arrStateNames(32, 2) = “NY“
        arrStateNames(33, 1) = “North Carolina”
        arrStateNames(33, 2) = “NC“
        arrStateNames(34, 1) = “North Dakota”
        arrStateNames(34, 2) = “ND“
        arrStateNames(35, 1) = “Ohio”
        arrStateNames(35, 2) = “OH“
        arrStateNames(36, 1) = “Oklahoma”
        arrStateNames(36, 2) = “OK“
        arrStateNames(37, 1) = “Oregon”
        arrStateNames(37, 2) = “OR“
        arrStateNames(38, 1) = “Pennsylvania”
        arrStateNames(38, 2) = “PA“
        arrStateNames(39, 1) = “Rhode Island”
        arrStateNames(39, 2) = “RI“
        arrStateNames(40, 1) = “South Carolina”
        arrStateNames(40, 2) = “SC“
        arrStateNames(41, 1) = “South Dakota”
        arrStateNames(41, 2) = “SD“
        arrStateNames(42, 1) = “Tennessee”
        arrStateNames(42, 2) = “TN“
        arrStateNames(43, 1) = “Texas”
        arrStateNames(43, 2) = “TX“
        arrStateNames(44, 1) = “Utah”
        arrStateNames(44, 2) = “UT“
        arrStateNames(45, 1) = “Vermont”
        arrStateNames(45, 2) = “VT“
        arrStateNames(46, 1) = “Virginia”
        arrStateNames(46, 2) = “VA“
        arrStateNames(47, 1) = “Washington”
        arrStateNames(47, 2) = “WA“
        arrStateNames(48, 1) = “West Virginia”
        arrStateNames(48, 2) = “WV“
        arrStateNames(49, 1) = "Wisconsin”
        arrStateNames(49, 2) = “WI“
        arrStateNames(50, 1) = “Wyoming”
        arrStateNames(50, 2) = “WY“
    End Sub
    Public Function GetTheResponseDueDate(ByRef Interval As String, ByVal QuantityOfDateUnits As Long, IncomingDate As Date) As Date
        'DateAdd(interval, number, date)
        'SYNTAX
        'Parameter                      Description
        ' interval                            Required. The interval you want to add.
        ' number                           Required. The number of interval you want to add. Can either be positive, for dates in the future, or negative, for dates in the past.
        '                                                      (Long)
        'date                                Required. Variant or literal representing the date to which interval is added.

        'DateAdd Function intervals:
        'Interval Strings          Description
        's                            Second
        'n                            Minute
        'h                            Hour
        'd                             Day
        'm                            Month
        'yyyy                        Year
        'y                             Day of year
        'q                             Quarter
        'ww                          Week of year
        'w                            Weekday
        '
        'Note: To add days to date, you can use Day of Year ("y"), Day ("d"), or Weekday ("w").

        'Example:
        'DateAdd Returns Results in System's Short Date Format.
        'Current System 's Short Date Format: dd/MM/yyyy.
        'Current System Date and Time is:
        '
        'Statement                                 Result         Remark
        'DateAdd("s", 10, Now)
        'DateAdd("n", 10, Now)
        'DateAdd("h", 2.5, Now)                                number should be Long.
        'DateAdd("d", 7, Date)
        'DateAdd("m", 2, Date)
        'DateAdd("yyyy", 1, Date)x
        'DateAdd("y", 5, Date)
        'DateAdd("q", 1, Date)
        'DateAdd("ww", 2, Date)
        'DateAdd("w", 1, Date)
        '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        GetTheResponseDueDate = DateAdd(Interval, QuantityOfDateUnits, IncomingDate)

    End Function
    Public Sub CaptureAndDisplayUSPTOActionDueDate()
        Dim tempLabelCaption As String

        Select Case SequenceOfPatentOfficeAction
            Case 1
                FirstUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The First Action Response Due Date is:"
            Case 2
                SecondUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Second Action Response Due Date is:"
            Case 3
                ThirdUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Third Action Response Due Date is:"
            Case 4
                FourthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Fourth Action Response Due Date is:"
            Case 5
                FifthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Fifth Action Response Due Date is:"
            Case 6
                SixthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Sixth Action Response Due Date is:"
            Case 7
                SeventhUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Seventh Action Response Due Date is:"
            Case 8
                EighthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Eighth Action Response Due Date is:"
            Case 9
                NinthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Ninth Action Response Due Date is:"
            Case 10
                TenthUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Tenth Action Response Due Date is:"
            Case 11
                EleventhUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Eleventh Action Response Due Date is:"
            Case 12
                TwelvethUSPTOActionResponseDueDate = USPTOActionResponseDueDate
                'tempLabelCaption = "The Twelveth Action Response Due Date is:"
        End Select
        'If NowInPatentDocumentChangeMode Then
        '    With frmChangeOfficialActionsAndResponses
        '        .fraTheResponseDueDateIs.Enabled = True
        '        .lblTheResponseDueDateIs.Enabled = True
        '        .lblIsThisDueDateCorrect.Enabled = True
        '        .optIsThisDueDateCorrect(0).Enabled = True
        '        .optIsThisDueDateCorrect(1).Enabled = True
        '        .lblTheResponseDueDateIs.Visible = True
        '        .lblTheResponseDueDateIs.Caption = tempLabelCaption
        '        .txtTheResponseDueDateIs.Visible = True
        '        .txtTheResponseDueDateIs.Enabled = True
        '        .txtTheResponseDueDateIs.Text = ConvertFromRKLDate(USPTOActionResponseDueDate, "MonthNumber")
        '        .txtTheResponseDueDateIs.BackColor = &HFF00&      'Green
        '        .fraTheResponseDueDateIs.BackColor = &H80C0FF 'Light Orange
        '        .lblTheResponseDueDateIs.BackColor = &H80C0FF 'Light Orange
        '        .lblIsThisDueDateCorrect.BackColor = &H80C0FF 'Light Orange
        '        .optIsThisDueDateCorrect(0).BackColor = &H80C0FF 'Light Orange
        '        .optIsThisDueDateCorrect(1).BackColor = &H80C0FF 'Light Orange
        '    End With
        'Else
        With frmInitialTrademarkApplicationInputTabs
            .grpResponseDueDate.Enabled = True
            .lblResponseDueDate.Enabled = True
            .lblIsResponseDueDateCorrect.Enabled = True
            '.optIsThisDueDateCorrect(0).Enabled = True
            'rdoArrayYesOrNo.rdoItem(0).enabled = True
            '.optIsThisDueDateCorrect(1).Enabled = True
            '.lblResponseDueDate.Text = tempLabelCaption
            .txtResponseDueDate.Enabled = True
            .txtResponseDueDate.Text = ConvertFromRKLDate(USPTOActionResponseDueDate, "MonthNumber")
            .txtResponseDueDate.BackColor = clrLimeGreen '&HFF00&      'Green
            .grpResponseDueDate.BackColor = clrOrange '&H80C0FF 'Light Orange
            .lblResponseDueDate.BackColor = clrOrange '&H80C0FF 'Light Orange
            .lblIsResponseDueDateCorrect.BackColor = clrOrange '&H80C0FF 'Light Orange
            '.optIsThisDueDateCorrect(0).BackColor = &H80C0FF 'Light Orange
            '    .optIsThisDueDateCorrect(1).BackColor = &H80C0FF 'Light Orange
        End With
        'End If
    End Sub
    Public Function GetOfficialActionSequenceWord()
        Dim SequenceWord As String

        Select Case SequenceOfPatentOfficeAction
            Case 1
                SequenceWord = "First"
            Case 2
                SequenceWord = "Second"
            Case 3
                SequenceWord = "Third"
            Case 4
                SequenceWord = "Fourth"
            Case 5
                SequenceWord = "Fifth"
            Case 6
                SequenceWord = "Sixth"
            Case 7
                SequenceWord = "Seventh"
            Case 8
                SequenceWord = "Eighth"
            Case 9
                SequenceWord = "Ninth"
            Case 10
                SequenceWord = "Tenth"
            Case 11
                SequenceWord = "Eleventh"
            Case 12
                SequenceWord = "Twelveth"
        End Select

        GetOfficialActionSequenceWord = SequenceWord
        Return GetOfficialActionSequenceWord
    End Function
    Public Sub SetUpFreshActionAndResponseScreenForInput()
        With frmInitialTrademarkApplicationInputTabs
            '''''FirstUSPTOActionMailingDate = 0
            '''''FirstUSPTOActionResponseDueDate = 0
            '''''FirstUSPTOActionResponseMadeDate = 0
            '''''TypeOfFirstUSPTOAction = "NONE"
            '''''TypeOfFirstPatentOfficeResponse = "NONE"

            '''''SecondUSPTOActionMailingDate = 0
            '''''SecondUSPTOActionResponseDueDate = 0
            '''''SecondUSPTOActionResponseMadeDate = 0
            '''''TypeOfSecondUSPTOAction = "NONE"
            '''''TypeOfSecondPatentOfficeResponse = "NONE"

            '''''ThirdUSPTOActionMailingDate = 0
            '''''ThirdUSPTOActionResponseDueDate = 0
            '''''ThirdUSPTOActionResponseMadeDate = 0
            '''''TypeOfThirdUSPTOAction = "NONE"
            '''''TypeOfThirdPatentOfficeResponse = "NONE"

            '''''FourthUSPTOActionMailingDate = 0
            '''''FourthUSPTOActionResponseDueDate = 0
            '''''FourthUSPTOActionResponseMadeDate = 0
            '''''TypeOfFourthUSPTOAction = "NONE"
            '''''TypeOfFourthPatentOfficeResponse = "NONE"

            '''''FifthUSPTOActionMailingDate = 0
            '''''FifthUSPTOActionResponseDueDate = 0
            '''''FifthUSPTOActionResponseMadeDate = 0
            '''''TypeOfFifthUSPTOAction = "NONE"
            '''''TypeOfFifthPatentOfficeResponse = "NONE"

            '''''SixthUSPTOActionMailingDate = 0
            '''''SixthUSPTOActionResponseDueDate = 0
            '''''SixthUSPTOActionResponseMadeDate = 0
            '''''TypeOfSixthUSPTOAction = "NONE"
            '''''TypeOfSixthPatentOfficeResponse = "NONE"

            '''''SeventhUSPTOActionMailingDate = 0
            '''''SeventhUSPTOActionResponseDueDate = 0
            '''''SeventhUSPTOActionResponseMadeDate = 0
            '''''TypeOfSeventhUSPTOAction = "NONE"
            '''''TypeOfSeventhPatentOfficeResponse = "NONE"

            '''''EighthUSPTOActionMailingDate = 0
            '''''EighthUSPTOActionResponseDueDate = 0
            '''''EighthUSPTOActionResponseMadeDate = 0
            '''''TypeOfEighthUSPTOAction = "NONE"
            '''''TypeOfEighthPatentOfficeResponse = "NONE"

            '''''NinthUSPTOActionMailingDate = 0
            '''''NinthUSPTOActionResponseDueDate = 0
            '''''NinthUSPTOActionResponseMadeDate = 0
            '''''TypeOfNinthUSPTOAction = "NONE"
            '''''TypeOfNinthPatentOfficeResponse = "NONE"

            '''''TenthUSPTOActionMailingDate = 0
            '''''TenthUSPTOActionResponseDueDate = 0
            '''''TenthUSPTOActionResponseMadeDate = 0
            '''''TypeOfTenthUSPTOAction = "NONE"
            '''''TypeOfTenthPatentOfficeResponse = "NONE"

            '''''EleventhUSPTOActionMailingDate = 0
            '''''EleventhUSPTOActionResponseDueDate = 0
            '''''EleventhUSPTOActionResponseMadeDate = 0
            '''''TypeOfEleventhUSPTOAction = "NONE"
            '''''TypeOfEleventhPatentOfficeResponse = "NONE"

            '''''TwelvethUSPTOActionMailingDate = 0
            '''''TwelvethUSPTOActionResponseDueDate = 0
            '''''TwelvethUSPTOActionResponseMadeDate = 0
            '''''TypeOfTwelvethUSPTOAction = "NONE"
            '''''TypeOfTwelvethPatentOfficeResponse = "NONE"

            .grpOfficialActionsAndResponses.BackColor = clrControl
            .grpHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            .lblHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            For I = 0 To 1
                .rdoArrayYesOrNoHaveThereBeenAnyOfficialActions.rdoItem(I).Checked = False
            Next I

            'Now Disable the ActionMailingDate Controls
            .mtbEnterPatentOfficeMailingDate.Text = ""
            .mtbEnterPatentOfficeMailingDate.Mask = "00/00/0000"
            .grpEnterPatentOfficeMailingDate.BackColor = clrControl
            .grpEnterPatentOfficeMailingDate.Enabled = False
            .lblEnterPatentOfficeMailingDate.BackColor = clrControl
            .lblEnterPatentOfficeMailingDate.Enabled = False
            .mtbEnterPatentOfficeMailingDate.Enabled = False

            'Now Disable the Office Action Options
            For I = 0 To 7  '11
                .rdoArrayTypeOfTMOfficeActions.rdoItem(I).Checked = False
                .rdoArrayTypeOfTMOfficeActions.rdoItem(I).BackColor = clrControl
                .rdoArrayTypeOfTMOfficeActions.rdoItem(I).Enabled = False
            Next I
            .grpTypeOfActionReceived.BackColor = clrControl
            .grpTypeOfActionReceived.Enabled = False

            .grpTypeOfTimeGivenForAResponse.BackColor = clrControl
            .grpTypeOfTimeGivenForAResponse.Enabled = False
            .grpNumberOfTimeToRespond.BackColor = clrControl
            .grpNumberOfTimeToRespond.Enabled = False
            .lblNumberOfTimeToRespond.BackColor = clrControl
            .lblNumberOfTimeToRespond.Enabled = False
            .txtNumberOfTimeToRespond.Text = ""

            .btnDoneNumberOfTimeToRespond.Enabled = False
            .lblOR1.BackColor = clrControl '&H8000000F  'ButtonFace
            .lblOR1.Enabled = False
            .lblOR2.BackColor = clrControl  '&H8000000F  'ButtonFace
            .lblOR2.Enabled = False

            .mtbResponseToBeOnAParticularDate.Text = ""
            .mtbResponseToBeOnAParticularDate.Mask = "00/00/0000"

            For I = 0 To 4
                '.optResponseTimeGivenIn(I).Value = False
                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Checked = False
                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).BackColor = clrControl
                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
            Next I

            .grpResponseDueDate.BackColor = clrControl
            .grpResponseDueDate.Enabled = False
            .lblResponseDueDate.BackColor = clrControl
            .lblResponseDueDate.Enabled = False
            .txtResponseDueDate.Text = ""
            .txtResponseDueDate.BackColor = clrLemmonChiffon
            .lblIsResponseDueDateCorrect.BackColor = clrControl
            .lblIsResponseDueDateCorrect.Enabled = False
            For I = 0 To 1
                .rdoArrayYesOrNoIsThisCorrect.rdoItem(I).Checked = False
                .rdoArrayYesOrNoWasAResponseFiled.rdoItem(I).Checked = False
            Next I
            .grpWasAResponsedFiled.BackColor = clrControl
            .grpWasAResponsedFiled.Enabled = False
            .lblWasAResponsedFiled.BackColor = clrControl
            .lblWasAResponsedFiled.Enabled = False

            'Now Disable the Response Made Controls
            For I = 0 To 2  '11
                .rdoArrayTypeOfTMResponseMade.rdoItem(I).Checked = False
                .rdoArrayTypeOfTMResponseMade.rdoItem(I).Enabled = False
            Next I
            .grpTypeOfResponseMade.BackColor = clrControl
            .grpTypeOfResponseMade.Enabled = False
            .grpResponseMadeDate.BackColor = clrControl
            .grpResponseMadeDate.Enabled = False
            .lblResponseMadeDate.BackColor = clrControl
            .lblResponseMadeDate.Enabled = False
            .mtbResponseMadeDate.Text = ""
            .mtbResponseMadeDate.Mask = "00/00/0000"
            .mtbResponseMadeDate.Enabled = False
            .btnDoneResponseMadeDate.BackColor = clrControl
            .btnDoneResponseMadeDate.Enabled = False

            .btnResetThisActionAndResponse.Enabled = False
            '.txtActionDate.Text = ""
            '.grpActionDate.Text = "Action Mailing Date"
            '.grpActionDate.Visible = False
            GroupInDocumentInputTabs = "grpHaveThereBeenAnyOfficialActions"
        End With
    End Sub
    Public Sub InitializeAllActionVariables()
        FirstUSPTOActionMailingDate = 0
        FirstUSPTOActionResponseDueDate = 0
        FirstUSPTOActionResponseMadeDate = 0
        TypeOfFirstUSPTOAction = "NONE"
        TypeOfFirstPatentOfficeResponse = "NONE"

        SecondUSPTOActionMailingDate = 0
        SecondUSPTOActionResponseDueDate = 0
        SecondUSPTOActionResponseMadeDate = 0
        TypeOfSecondUSPTOAction = "NONE"
        TypeOfSecondPatentOfficeResponse = "NONE"

        ThirdUSPTOActionMailingDate = 0
        ThirdUSPTOActionResponseDueDate = 0
        ThirdUSPTOActionResponseMadeDate = 0
        TypeOfThirdUSPTOAction = "NONE"
        TypeOfThirdPatentOfficeResponse = "NONE"

        FourthUSPTOActionMailingDate = 0
        FourthUSPTOActionResponseDueDate = 0
        FourthUSPTOActionResponseMadeDate = 0
        TypeOfFourthUSPTOAction = "NONE"
        TypeOfFourthPatentOfficeResponse = "NONE"

        FifthUSPTOActionMailingDate = 0
        FifthUSPTOActionResponseDueDate = 0
        FifthUSPTOActionResponseMadeDate = 0
        TypeOfFifthUSPTOAction = "NONE"
        TypeOfFifthPatentOfficeResponse = "NONE"

        SixthUSPTOActionMailingDate = 0
        SixthUSPTOActionResponseDueDate = 0
        SixthUSPTOActionResponseMadeDate = 0
        TypeOfSixthUSPTOAction = "NONE"
        TypeOfSixthPatentOfficeResponse = "NONE"

        SeventhUSPTOActionMailingDate = 0
        SeventhUSPTOActionResponseDueDate = 0
        SeventhUSPTOActionResponseMadeDate = 0
        TypeOfSeventhUSPTOAction = "NONE"
        TypeOfSeventhPatentOfficeResponse = "NONE"

        EighthUSPTOActionMailingDate = 0
        EighthUSPTOActionResponseDueDate = 0
        EighthUSPTOActionResponseMadeDate = 0
        TypeOfEighthUSPTOAction = "NONE"
        TypeOfEighthPatentOfficeResponse = "NONE"

        NinthUSPTOActionMailingDate = 0
        NinthUSPTOActionResponseDueDate = 0
        NinthUSPTOActionResponseMadeDate = 0
        TypeOfNinthUSPTOAction = "NONE"
        TypeOfNinthPatentOfficeResponse = "NONE"

        TenthUSPTOActionMailingDate = 0
        TenthUSPTOActionResponseDueDate = 0
        TenthUSPTOActionResponseMadeDate = 0
        TypeOfTenthUSPTOAction = "NONE"
        TypeOfTenthPatentOfficeResponse = "NONE"

        EleventhUSPTOActionMailingDate = 0
        EleventhUSPTOActionResponseDueDate = 0
        EleventhUSPTOActionResponseMadeDate = 0
        TypeOfEleventhUSPTOAction = "NONE"
        TypeOfEleventhPatentOfficeResponse = "NONE"

        TwelvethUSPTOActionMailingDate = 0
        TwelvethUSPTOActionResponseDueDate = 0
        TwelvethUSPTOActionResponseMadeDate = 0
        TypeOfTwelvethUSPTOAction = "NONE"
        TypeOfTwelvethPatentOfficeResponse = "NONE"
    End Sub
End Module


