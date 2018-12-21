Public Class frmTrademarkDisplayOrParameterChanges
    Public btnControlArrayForDisplayOrChanges As ButtonArray
    Public chkControlArrayForDisplayOrChanges As CheckBoxArray
    Public txtControlArray As TextBoxArray

    Public btnNextStatementButtonNotYetClickedForTheFirstTime As Boolean
    Public btnNextStatmentButtonJustClickedForTheFirstTime As Boolean
    Public SequenceNumberOfRecordBeingDisplayed As Integer

    Public RestoringOriginalValues As Boolean

    Private Sub frmTrademarkDisplayOrParameterChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chkTop As Integer
        Dim chkLeft As Integer

        Dim LeftEdgeOfTextBox As Integer
        Dim TopEdgeOfTextBox As Integer
        Dim WidthOfTextBox As Integer

        'Initialize the next switch for use with the btnNext Button to avoid
        ' opening the Table more than once
        btnNextStatementButtonNotYetClickedForTheFirstTime = True

        With Me
            CurrentFormName = .Name
            WindowState = FormWindowState.Maximized

            'Set up the DB Record Number
            .lblDBRecordNumber.Font = RKLFont11B
            .lblDBRecordNumber.Text = "DB Record Number: " & Trim(BookmarkOfRecordFoundDuringOKDisplay.ToString)
            '.txtDBRecordNumber.Font = RKLFont11B
            '.txtDBRecordNumber.Text = Trim(BookmarkOfRecordFoundDuringOKDisplay.ToString)

            'Initialize the Sequence Number of the Record being Displayed
            SequenceNumberOfRecordBeingDisplayed = 1
            .lblDocOfTotalDocs.Font = RKLFont11B
            If CountOfRecordsForThisGeneralDocketNumber > 0 Then
                .lblDocOfTotalDocs.Text = "Doc.#: " & Trim(SequenceNumberOfRecordBeingDisplayed.ToString) & " of " & Trim(CountOfRecordsForThisGeneralDocketNumber.ToString)
            Else
                .lblDocOfTotalDocs.Text = "Doc.#: " & Trim(SequenceNumberOfRecordBeingDisplayed.ToString)
            End If

            .lblFormTitle.Font = RKLFont16B
            .lblFormTitle.Text = "Trademark Document for " & DocketNumber & "-" & SubDocketNumber

            btnControlArrayForDisplayOrChanges = New ButtonArray(Me)
            chkControlArrayForDisplayOrChanges = New CheckBoxArray(Me)

            .lblInstructions.Font = RKLFont14BI
            .lblInstructions.Text = "Select the Operation Number You Wish to Work With by Clicking a Check Box"

            .grpRKLDocketNumber.Font = RKLFont12B
            .grpRKLDocketNumber.Text = "1. RKL Docket No."
            .txtFullDocketNumber.Font = RKLFont12B
            .txtFullDocketNumber.ReadOnly = True

            .grpClientDocketNumber.Font = RKLFont12B
            .grpClientDocketNumber.Text = "2. Client Docket Number"
            .txtClientDocketNumber.Font = RKLFont12B
            .txtClientDocketNumber.ReadOnly = True

            .grpCountryCode.Font = RKLFont12B
            .grpCountryCode.Text = "3. Country"
            .txtCountryCode.Font = RKLFont12B
            .txtCountryCode.ReadOnly = True

            .grpResponsibleAttorney.Font = RKLFont12B
            .grpResponsibleAttorney.Text = "4. Responsible Attorney"
            .txtResponsibleAttorney.Font = RKLFont12B
            .txtResponsibleAttorney.ReadOnly = True

            .grpTrademarkType.Font = RKLFont12B
            .grpTrademarkType.Text = "5. Type of Trademark"
            .txtTrademarkType.Font = RKLFont12B
            .txtTrademarkType.ReadOnly = True

            .grpMarkText.Font = RKLFont12B
            .grpMarkText.Text = "6. Mark"
            .txtMarkText.Font = RKLFont12B
            .txtMarkText.ReadOnly = True

            .grpGoodsServicesUsedByMark.Font = RKLFont12B
            .grpGoodsServicesUsedByMark.Text = "7. Goods and/or Services Used by the Mark"
            .txtGoodsServicesUsedByMark.Font = RKLFont12B
            .txtGoodsServicesUsedByMark.ReadOnly = True

            .grpFirstUseDate.Font = RKLFont12B
            .grpFirstUseDate.Text = "8. First Use Date"
            .txtFirstUseDate.Font = RKLFont12B
            .txtFirstUseDate.ReadOnly = True

            .grpFirstUseDateInCommerce.Font = RKLFont12B
            .grpFirstUseDateInCommerce.Text = "9. First Use Date in Commerce"
            .txtFirstUseDateInCommerce.Font = RKLFont12B
            .txtFirstUseDateInCommerce.ReadOnly = True

            If CategoryOfTrademarkType = "Madrid Protocol" Then
                .grpMadridProtocolSerialNumber.Visible = True
                .grpMadridProtocolSerialNumber.Font = RKLFont12B
                .grpMadridProtocolSerialNumber.Text = "Madrid Protocol Serial No.:"
                .txtMadridProtocolSerialNumber.Font = RKLFont12B
                '.txtMadridProtocolSerialNumber.Text = MadridProtocolSerialNumber.ToString
                .txtMadridProtocolSerialNumber.BackColor = clrSpringGreen
                .txtMadridProtocolSerialNumber.ReadOnly = True

                .grpWIPOFilingDate.Visible = True
                .grpWIPOFilingDate.Font = RKLFont12B
                .grpWIPOFilingDate.Text = "WIPO Filing Date"
                .txtWIPOFilingDate.Font = RKLFont12B
                '.txtWIPOFilingDate.Text = ConvertFromRKLDate(WIPOFilingDate, "MonthNumber")
                .txtWIPOFilingDate.BackColor = clrSpringGreen
                .txtWIPOFilingDate.ReadOnly = True
            Else
                .grpMadridProtocolSerialNumber.Visible = False
                .grpWIPOFilingDate.Visible = False
            End If

            'Now add the Checkboxes to each Group-Box
            chkLeft = 12
            chkTop = 15
            .grpRKLDocketNumber.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpClientDocketNumber.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpCountryCode.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpResponsibleAttorney.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpTrademarkType.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpMarkText.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpGoodsServicesUsedByMark.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpFirstUseDateInCommerce.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpFirstUseDate.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpMadridProtocolSerialNumber.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .grpWIPOFilingDate.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Set up the Tabs
            ''ActionTypeReceived
            chkTop = 22
            .grpActionTypeReceived1st.Text = "1st Action Type Received"
            .grpActionTypeReceived1st.Controls.Add(btnControlArrayForDisplayOrChanges.AddNewButton("D", 10, 20))
            .grpActionTypeReceived1st.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived1st.Font = RKLFont12B
            .txtActionTypeReceived1st.Text = ""
            .grpActionTypeReceived2nd.Text = "2nd Action Type Received"
            .grpActionTypeReceived2nd.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived2nd.Font = RKLFont12B
            .txtActionTypeReceived2nd.Text = ""
            .grpActionTypeReceived3rd.Text = "3rd Action Type Received"
            .grpActionTypeReceived3rd.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived3rd.Font = RKLFont12B
            .txtActionTypeReceived3rd.Text = ""
            .grpActionTypeReceived4th.Text = "4th Action Type Received"
            .grpActionTypeReceived4th.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived4th.Font = RKLFont12B
            .txtActionTypeReceived4th.Text = ""
            .grpActionTypeReceived5th.Text = "5th Action Type Received"
            .grpActionTypeReceived5th.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived5th.Font = RKLFont12B
            .txtActionTypeReceived5th.Text = ""
            .grpActionTypeReceived6th.Text = "6th Action Type Received"
            .grpActionTypeReceived6th.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))
            .txtActionTypeReceived6th.Font = RKLFont12B
            .txtActionTypeReceived6th.Text = ""
            .grpActionTypeReceived7th.Text = "7th Action Type Received"
            .grpActionTypeReceived7th.Controls.Add(chkControlArrayForDisplayOrChanges.AddNewCheckBox("", chkLeft, chkTop))

            .grpActionTypeReceived8th.Text = "8th Action Type Received"
            .grpActionTypeReceived9th.Text = "9th Action Type Received"
            .grpActionTypeReceived10th.Text = "10th Action Type Received"
            .grpActionTypeReceived11th.Text = "11th Action Type Received"
            .grpActionTypeReceived12th.Text = "12th Action Type Received"

            '''''''Now add TextBoxes to this GroupBox
            ''''''GroupInTrademarkDisplayOrParameterChanges = "ActionTypeReceived"
            ''''''txtControlArray = New TextBoxArray(Me)
            ''''''LeftEdgeOfTextBox = 40
            ''''''TopEdgeOfTextBox = 20
            ''''''WidthOfTextBox = 340

            ''''''.grpActionTypeReceived1st.Controls.Add(txtControlArray.AddNewTextBox(LeftEdgeOfTextBox, TopEdgeOfTextBox, WidthOfTextBox))

            .grpMailingDate1st.Text = "1st Mailing Date"
            .grpMailingDate2nd.Text = "2nd Mailing Date"
            .grpMailingDate3rd.Text = "3rd Mailing Date"
            .grpMailingDate4th.Text = "4th Mailing Date"
            .grpMailingDate5th.Text = "5th Mailing Date"
            .grpMailingDate6th.Text = "6th Mailing Date"
            .grpMailingDate7th.Text = "7th Mailing Date"
            .grpMailingDate8th.Text = "8th Mailing Date"
            .grpMailingDate9th.Text = "9th Mailing Date"
            .grpMailingDate10th.Text = "10th Mailing Date"
            .grpMailingDate11th.Text = "11th Mailing Date"
            ''''''''''=>>>>.grpMailingDate12th.Text = "12th Mailing Date"

            .grpResponseDueDate1st.Font = RKLFont10B
            .grpResponseDueDate1st.Text = "1st Response Due Date"
            .grpResponseDueDate2nd.Font = RKLFont10B
            .grpResponseDueDate2nd.Text = "2nd Response Due Date"
            .grpResponseDueDate3rd.Font = RKLFont10B
            .grpResponseDueDate3rd.Text = "3rd Response Due Date"
            .grpResponseDueDate4th.Font = RKLFont10B
            .grpResponseDueDate4th.Text = "4th Response Due Date"
            .grpResponseDueDate5th.Font = RKLFont10B
            .grpResponseDueDate5th.Text = "5th Response Due Date"
            .grpResponseDueDate6th.Font = RKLFont10B
            .grpResponseDueDate6th.Text = "6th Response Due Date"
            .grpResponseDueDate7th.Text = "7th Response Due Date"
            .grpResponseDueDate8th.Text = "8th Response Due Date"
            .grpResponseDueDate9th.Text = "9th Response Due Date"
            .grpResponseDueDate10th.Text = "10th Response Due Date"
            .grpResponseDueDate11th.Text = "11th Response Due Date"
            .grpResponseDueDate12th.Text = "12th Response Due Date"

            .grpResponseType1st.Text = "1st Response Type"
            .grpResponseType2nd.Text = "2nd Response Type"
            .grpResponseType3rd.Text = "3rd Response Type"
            .grpResponseType4th.Text = "4th Response Type"
            .grpResponseType5th.Text = "5th Response Type"
            .grpResponseType6th.Text = "6th Response Type"
            .grpResponseType7th.Text = "7th Response Type"
            .grpResponseType8th.Text = "8th Response Type"
            .grpResponseType9th.Text = "9th Response Type"
            .grpResponseType10th.Text = "10th Response Type"
            .grpResponseType11th.Text = "11th Response Type"
            .grpResponseType12th.Text = "12th Response Type"

            .grpResponseMadeDate1st.Font = RKLFont10B
            .grpResponseMadeDate1st.Text = "1st Response Made Date"
            .txtResponseMadeDate1st.Font = RKLFont12B
            .grpResponseMadeDate2nd.Font = RKLFont10B
            .grpResponseMadeDate2nd.Text = "2nd Response Made Date"
            .txtResponseMadeDate2nd.Font = RKLFont12B
            .grpResponseMadeDate3rd.Font = RKLFont10B
            .grpResponseMadeDate3rd.Text = "3rd Response Made Date"
            .txtResponseMadeDate3rd.Font = RKLFont12B
            .grpResponseMadeDate4th.Font = RKLFont10B
            .grpResponseMadeDate4th.Text = "4th Response Made Date"
            .txtResponseMadeDate4th.Font = RKLFont12B
            .grpResponseMadeDate5th.Font = RKLFont10B
            .grpResponseMadeDate5th.Text = "5th Response Made Date"
            .txtResponseMadeDate5th.Font = RKLFont12B
            .grpResponseMadeDate6th.Font = RKLFont10B
            .grpResponseMadeDate6th.Text = "6th Response Made Date"
            .txtResponseMadeDate6th.Font = RKLFont12B
            .grpResponseMadeDate7th.Text = "7th Response Made Date"
            .grpResponseMadeDate8th.Text = "8th Response Made Date"
            .grpResponseMadeDate9th.Text = "9th Response Made Date"
            .grpResponseMadeDate10th.Text = "10th Response Made Date"
            .grpResponseMadeDate11th.Text = "11th Response Made Date"
            .grpResponseMadeDate12th.Text = "12th Response Made Date"

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            .btnNext.Font = RKLFont12BI
            .btnNext.Text = "Next >>"

            .btnDone.Font = RKLFont14BI
            .btnDone.Text = " D o n e "

            .btnRestoreAllOriginalValues.Font = RKLFont14BI
            .btnRestoreAllOriginalValues.Text = "Restore All Original Values"
            .btnRestoreAllOriginalValues.Enabled = False

            .btnCancel.Font = RKLFont16BI
            .btnCancel.Text = " Cancel "
            '.AcceptButton = .btnCancel
        End With

    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Response As Integer
        Call msgSureWantToCancelThan(Response)
        Select Case Response
            Case 6 'Yes
                IntialLoadOfThisFormCompleted = False
                CurrentFormName = "frmMainMenu2"

                Me.Close()
            Case 7 'No
                'Do Nothing
        End Select
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim tempFindDocketNumber As String
        'Dim tempFindSubDocketNumber As String
        'Dim CurrentRecordSubDocketNumber As String
        Dim CurrentRecordsClientDocketNumber As String

        'Dim tempTitle As String

        'Dim tempFindDocketNumber As String
        Dim tempFoundDocketNumber As String
        Dim tempResponse As Integer

        'Dim tempInsertedAParticularTrademarkDocumentTitle As String
        'Dim tempInsertedTrademarkNumber As String

        'Dim tempAbsolutePosition As Long

        'ManuallyChangingPctFinalDateToEnterNationalPhasesChapter2 = False

        CountOfCksChecked = 0

        '06-10-07: The FIRST time this CMD is Clicked:
        '           The Connection, the Docket Table and Sub-Docket Table
        '           are still OPEN at this point AND
        '           the Record Pointers are set to the:
        '              - Selected Docket Number
        '              - Selected Sub-Docket Number
        '           A N D
        '           The these Records a being displayed in this Form
        '
        'If this is the First time this cmdButton is clicked then
        '  Open the Conncection to the DB, the Docket Table, and the SubDocket Table
        If btnNextStatementButtonNotYetClickedForTheFirstTime Then
            'Set this switch to False so that attempts to open
            ' Tables don't happen more than once
            ' -- This switch is defined in the General_Declarations Section and
            '     is initialized to True on the Form_Load Routine of this Form
            btnNextStatementButtonNotYetClickedForTheFirstTime = False
            'Open a Connection to the RKL Trademark Database
            OpenConnectionToRKLTrademarkDB("rkltrademark.mdb")
            'Open the TrademarkDocuments Table
            OpenTableInRKLTrademarkDB("TrademarkDocuments")
            'Move the Record Pointer to the Initial Record Number Found in frmMethodsOfReferencingTrademarksForScreenDisplay
            adoRKLTrademarkRecordset.MoveFirst()
            adoRKLTrademarkRecordset.Move(AbsolutePositionOfRecordFoundDuringOKDisplay - 1)
        End If

        'Get the Record from the Trademark Table and the NEXT Record
        '  using the Selected Method for Referencing the Displayed Docs
        InitialValuesAlreadyLoaded = False
        Select Case SelectedMethodNumberForReferencingDisplayedDocs
            Case 1  '"1. General Docket Number"
                With adoRKLTrademarkRecordset 'This is for the TrademarkDocments Table
                    Do Until .EOF
                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                        '  Displayed in the frmMethodOfReferencingTrademarksForScreenDisplay
                        '  Form - Then Moved to the Next Record each time this btnButton is clicked
                        'tempAbsolutePosition = .AbsolutePosition
                        If .EOF Then
                            'Disable this Command Button
                            Me.btnNext.Enabled = False
                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                            Select Case tempResponse
                                Case vbYes
                                    'Close the Trademark Table
                                    CloseTableInRKLTrademarkDB()
                                    'ReStart the Referencing Form
                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                                    'Unload the Statement Display form
                                    Me.Close()
                                    Exit Sub
                                Case vbNo
                                    'Close the Trademark Table
                                    CloseTableInRKLTrademarkDB()
                                    'Close the Connection
                                    CloseConnectionToRKLTrademarkDB()
                                    'Unload all forms except the Menu
                                    Me.Close()
                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                                    CurrentFormName = "frmMainMenu2"
                                Case vbCancel
                                    '                              LastRecordNumberOfFoundSubdocketNumber = .RecordCount
                                    '                              .MoveLast
                                    Me.btnRestoreAllOriginalValues.PerformClick()
                            End Select
                            Exit Sub
                        End If
                        tempFindDocketNumber = .Fields!DocketNumber.Value.ToString
                        If Trim$(tempFindDocketNumber) = CurrentRKLDocket Then
                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                            InitialValuesAlreadyLoaded = True
                            'Display the Found DB Record Number
                            BookmarkOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.Bookmark
                            AbsolutePositionOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.AbsolutePosition
                            'Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                            Me.lblDBRecordNumber.Text = "DB Record Number: " & Trim(BookmarkOfRecordFoundDuringOKDisplay.ToString)
                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                            'Display the new Sequence Number
                            If CountOfRecordsForThisGeneralDocketNumber > 0 Then
                                Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString & " of " & Trim$(Str$(CountOfRecordsForThisGeneralDocketNumber))
                            Else
                                Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                            End If

                            If .AbsolutePosition = .RecordCount Then
                                'Disable this Command Button
                                Me.btnNext.Enabled = False
                                Exit Sub
                            End If
                            Exit Sub
                        End If
                    Loop
                End With
                '            Case 1 '2. Specific Docket Number and Sub-docket Number
                '                With adoRKLTrademarkRecordset
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        ' displayed by the frmMethodsOfReferencingTrademarksForScreenDisplay form
                '                        If .EOF Then 'Stop Here or Display an at-the-end-of-the Trademark Documents Message
                '                            Me.btnNext.Enabled = False
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Docket Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the SubDocket Table
                '                                    '                                CloseTable2InRKLdb
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                Case vbCancel
                '                                    'Move the Record-Pointer BACK to LastRecordNumberOfFoundSubdocketNumber
                '                                    '  First calulate the amount of records to move backward - This MUST be a NEGATIVE number
                '                                    '                                          QuantityOfRecordsToMoveBack = LastRecordNumberOfFoundSubdocketNumber - .RecordCount - 1
                '                                    '                                          .Move QuantityOfRecordsToMoveBack
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        'See IF the Next Record's DocketNumber and SubDocket Number matches with the Currrent-Selected DocketNumber and SubDocket Number
                '                        '                        CurrentRecordSubDocketNumber = Trim$(.Fields!SubDocketNumber)
                '                        If (CurrentRKLDocket = Trim$(.Fields!DocketNumber.Value)) And (CurrentSubDocketNumber = Trim$(.Fields!SubDocketNumber)) Then
                '                            'Capture the Current Record Number for this SubDocket
                '                            ' - This will become the LastSubDocketNumberRecordNumber viewed by the user
                '                            ' - Defined in General Section of this Module
                '                            '                            LastSubDocketNumberRecordNumber = .AbsolutePosition
                '                            '                            Me.cmdPrevStatement.Enabled = True
                '                            'Capture all the Docket Fields to be displayed for the
                '                            'Parameters Selected by the user
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition

                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            InitialValuesAlreadyLoaded = True
                '                            'Capture the all the SubDocket Fields to be displayed for the
                '                            '  Parameters Selected by the user
                '                            '                            Call AssignSubDocketRecordToDisplayFormFields(adoRKLRecordset2, frmTrademarkDisplayOrParameterChanges)
                '                            'Capture the RecordNumber of this SubDocket Record
                '                            LastRecordNumberOfFoundSubdocketNumber = .AbsolutePosition
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            If .AbsolutePosition = .RecordCount Then
                '                                'Disable this Command Button
                '                                Me.btnNext.Enabled = False
                '                                Exit Sub
                '                            End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With

                '            Case 2  '3. By A Client's Docket Number"
                '                With adoRKLTrademarkRecordset
                '                    .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                    Do Until .EOF
                '                        'See IF the Next Record's Client DocketNumber matches with the Currrent-Selected  ClientDocketNumber
                '                        '                        CurrentRecordsClientDocketNumber = Trim$(.Fields!ClientDocketNumber)
                '                        If CurrentClientDocketNumber = Trim$(.Fields!ClientDocketNumber.Value) Then
                '                            'Capture the Current Record Number for this SubDocket
                '                            ' - This will become the LastSubDocketNumberRecordNumber viewed by the user
                '                            ' - Defined in General Section of this Module
                '                            LastSubDocketNumberRecordNumber = .AbsolutePosition
                '                            '                            Me.cmdPrevStatement.Enabled = True
                '                            'Capture the all the Docket Fields to be displayed for the
                '                            'Parameters Selected by the user
                '                            '                            Call AssignDocketRecordToDisplayFormFields(adoRKLRecordset, frmTrademarkDisplayOrParameterChanges)
                '                            'Capture the all the SubDocket Fields to be displayed for the
                '                            '  Parameters Selected by the user
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition

                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            Exit Do
                '                        End If
                '                        .MoveNext()
                '                    Loop
                '                    If .EOF Then 'Stop Here or Display an at-the-end-of-the Sub-Docket Numbers Message
                '                        Me.btnNext.Enabled = False
                '                        Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                        Select Case tempResponse
                '                            Case vbYes
                '                                'Close the Trademark Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                'Show the BlankBackground Form
                '                                '                                frmBlankBackground.Show
                '                                '                                ReStart the Referencing Form
                '                                frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                '                                Unload the Statement Display form
                '                                Me.Close()
                '                                'Unload the BlankBackground Form
                '                                '                                Unload frmBlankBackground
                '                                Exit Sub
                '                            Case vbNo
                '                                'Close the Docket Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                'Unload all forms except the Menu
                '                                Me.Close()
                ''                                Unload frmMethodsOfReferencingStatementsForScreenDisplay
                '                            Case vbCancel
                '                                'Move the Record-Pointer BACK to LastRecordNumberOfFoundSubdocketNumber
                '                                '  First calulate the amount of records to move backward - This MUST be a NEGATIVE number
                '                                '                                QuantityOfRecordsToMoveBack = LastRecordNumberOfFoundSubdocketNumber - .RecordCount - 1
                '                                '                                .Move QuantityOfRecordsToMoveBack
                '                                Me.btnRestoreAllOriginalValues.PerformClick()
                '                        End Select
                '                        Exit Sub
                '                    End If
                '                End With

                '            Case 3   '"4. By A Particular Trademark Application Serial Number or U.S. Publication Number"
                '                ''''' Me.btnNext.Visible = False
                '                With adoRKLTrademarkRecordset
                '                    .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                    Do Until .EOF
                '                        'See IF the Next Record's TrademarkApplicationSerialNumber. matches with the Currrent-Selected  TrademarkApplicationSerialNumber OR Pub Number
                '                        If (InsertedTrademarkSerialNumberOrPublicationNumber = UCase$(Trim$(.Fields!TrademarkApplicationSerialNumber))) _
                '                           Or (InsertedTrademarkSerialNumberOrPublicationNumber = UCase$(Trim$(.Fields!PublicationNumberUSDocuments))) _
                '                           Or (tempInsertedTrademarkSerialNumberOrPublicationNumber = UCase$(Trim$(.Fields!PublicationNumberPCTDocuments))) _
                '                           Or (tempInsertedTrademarkSerialNumberOrPublicationNumber = UCase$(Trim$(.Fields!PublicationNumberForeignDocuments))) Then
                '                            'Capture the Current Record Number for this SubDocket
                '                            ' - This will become the LastSubDocketNumberRecordNumber viewed by the user
                '                            ' - Defined in General Section of this Module
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition

                '                            LastSubDocketNumberRecordNumber = .AbsolutePosition
                '                            '                            Me.cmdPrevStatement.Enabled = True
                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            Exit Do
                '                        End If
                '                        .MoveNext()
                '                    Loop
                '                    If .EOF Then 'Stop Here or Display an at-the-end-of-the Sub-Docket Numbers Message
                '                        Me.btnNext.Enabled = False
                '                        Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                        Select Case tempResponse
                '                            Case vbYes
                '                                'Close the Trademark Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                '                                ReStart the Referencing Form
                '                                frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                '                                Unload the Statement Display form
                '                                Me.Close()
                '                                Exit Sub
                '                            Case vbNo
                '                                'Close the Docket Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                'Unload all forms except the Menu
                '                                Me.Close()
                '                            Case vbCancel
                '                                '  First calulate the amount of records to move backward - This MUST be a NEGATIVE number
                '                                '                                QuantityOfRecordsToMoveBack = LastRecordNumberOfFoundSubdocketNumber - .RecordCount - 1
                '                                '                                .Move QuantityOfRecordsToMoveBack
                '                                Me.btnRestoreAllOriginalValues.PerformClick()
                '                        End Select
                '                        Exit Sub
                '                    End If
                '                End With
                '            Case 4 ' "5. By A Particular Trademark Number"
                '                ''''' Me.btnNext.Visible = False
                '                With adoRKLTrademarkRecordset
                '                    .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                    Do Until .EOF
                '                        'See IF the Next Record's TrademarkNumber. matches with the Currrent-Selected  TrademarkNumber
                '                        tempInsertedTrademarkNumber = Trim$(frmMethodsOfReferencingTrademarksForScreenDisplay.txtAParticularTrademarkNumber.Text)
                '                        If Val(.Fields!TrademarkNumber.Value) > 0 Or UCase$(.Fields!TrademarkNumber) <> "NONE" Then
                '                            tempITrademarkNumber = .Fields!TrademarkNumber.Value.ToString
                '                            If tempIInsertedTrademarkNumber = tempITrademarkNumber Then
                '                                'Capture the Current Record Number for this SubDocket
                '                                ' - This will become the LastSubDocketNumberRecordNumber viewed by the user
                '                                ' - Defined in General Section of this Module
                '                                LastSubDocketNumberRecordNumber = .AbsolutePosition
                '                                BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                                AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                                '                            Me.cmdPrevStatement.Enabled = True
                '                                Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                                InitialValuesAlreadyLoaded = True
                '                                'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                                SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                                'Dispaly the new Sequence Number
                '                                Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                                Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                                Exit Do
                '                            End If
                '                        End If
                '                        .MoveNext()
                '                    Loop
                '                    If .EOF Then 'Stop Here or Display an at-the-end-of-the Sub-Docket Numbers Message
                '                        Me.btnNext.Enabled = False
                '                        Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                        Select Case tempResponse
                '                            Case vbYes
                '                                'Close the Trademark Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                '                                ReStart the Referencing Form
                '                                frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                '                                Unload the Statement Display form
                '                                Me.Close()
                '                                Exit Sub
                '                            Case vbNo
                '                                'Close the Docket Table
                '                                CloseTableInRKLTrademarkDB()
                '                                'Close the Connection
                '                                CloseConnectionToRKLTrademarkDB()
                '                                'Unload all forms except the Menu
                '                                Me.Close()
                '                            Case vbCancel
                '                                '  First calulate the amount of records to move backward - This MUST be a NEGATIVE number
                '                                '                                QuantityOfRecordsToMoveBack = LastRecordNumberOfFoundSubdocketNumber - .RecordCount - 1
                '                                '                                .Move QuantityOfRecordsToMoveBack
                '                                Me.btnRestoreAllOriginalValues.PerformClick()
                '                        End Select
                '                        Exit Sub
                '                    End If
                '                End With
                '            Case 5 '"6. By A Particular Inventor"
                '                '******************************************************
                '                With adoRKLTrademarkRecordset 'This is for the TrademarkDocuments Table
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        '  Displayed in the frmMethodOfReferencingTrademarkssForScreenDisplay
                '                        '  Form - Then Moved to the Next Record each time this cmdButton is clicked
                '                        If .EOF Then
                '                            'Disable this Command Button
                '                            Me.btnNext.Enabled = False
                '                            'Set the Focus to the Previous Cmd Button so user doesn't
                '                            '  have to click without any record movement
                '                            '''''                        Me.cmdPrevStatement.Enabled = True
                '                            '''''                        Me.cmdPrevStatement.SetFocus
                '                            '''''                        cmdPreviousStatmentButtonJustClickedForTheFirstTime = True
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                Case vbCancel
                '                                    '                              LastRecordNumberOfFoundSubdocketNumber = .RecordCount
                '                                    '                              .MoveLast
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        ''''                    Me.cmdPrevStatement.Enabled = True
                '                        ''''''               .Move .AbsolutePosition
                '                        '''''               'Place all this TrademarkDocument's Fields in the Display Form for the
                '                        '''''               '  Parameters Selected by the user
                '                        '                    InputInventorName = UCase$(Trim$(Me.txtInventorName.Text))
                '                        If (InStr(.Fields!FirstNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!SecondNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!ThirdNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!FourthNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!FifthNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!SixthNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!SeventhNamedInventor, InputInventorName) > 0) Or
                '                      (InStr(.Fields!EighthNamedInventor, InputInventorName) > 0) Then

                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Display the Found DB Record Number
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            If .AbsolutePosition = .RecordCount Then
                '                                'Disable this Command Button
                '                                Me.btnNext.Enabled = False
                '                                '''''                        'Set the Focus to the Previous Cmd Button so user doesn't
                '                                '''''                        '  have to click without any record movement
                '                                '''''                        Me.cmdPrevStatement.SetFocus
                '                                '''''                        cmdPreviousStatmentButtonJustClickedForTheFirstTime = True
                '                                Exit Sub
                '                            End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With
                '            Case 6 '"7. Title
                '                With adoRKLTrademarkRecordset 'This is for the TrademarkDocments Table
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        '  Displayed in the frmMethodOfReferencingTrademarkssForScreenDisplay
                '                        '  Form - Then Moved to the Next Record each time this cmdButton is clicked
                '                        If .EOF Then
                '                            'Disable this Command Button
                '                            Me.btnNext.Enabled = False
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                Case vbCancel
                '                                    '                              LastRecordNumberOfFoundSubdocketNumber = .RecordCount
                '                                    '                              .MoveLast
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        tempInsertedAParticularTrademarkDocumentTitle = UCase$(Trim$(InsertedAParticularTrademarkDocumentTitle))
                '                        If (InStr(UCase$(.Fields!TrademarkTitle), tempInsertedAParticularTrademarkDocumentTitle) > 0) Then
                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Display the Found DB Record Number
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            If .AbsolutePosition = .RecordCount Then
                '                                'Disable this Command Button
                '                                Me.btnNext.Enabled = False
                '                                Exit Sub
                '                            End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With
                '            Case 7 '"8. By A Particular Applicant or Trademarkee"
                '                With adoRKLTrademarkRecordset 'This is for the TrademarkDocments Table
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        '  Displayed in the frmMethodOfReferencingTrademarkssForScreenDisplay
                '                        '  Form - Then Moved to the Next Record each time this cmdButton is clicked
                '                        If .EOF Then
                '                            'Disable this Command Button
                '                            Me.btnNext.Enabled = False
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                Case vbCancel
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        tempIInsertedAParticularApplicant = UCase$(Trim$(InsertedAParticularApplicant))
                '                        If (InStr(UCase$(.Fields!ApplicantWhenDifferentFromInventorsForeignDocuments), tempIInsertedAParticularApplicant) > 0) Then
                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Display the Found DB Record Number
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            If .AbsolutePosition = .RecordCount Then
                '                                'Disable this Command Button
                '                                Me.btnNext.Enabled = False
                '                                Exit Sub
                '                            End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With
                '            Case 8 '"9. A Particular Trademark Document Assignee"
                '                With adoRKLTrademarkRecordset 'This is for the TrademarkDocments Table
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        '  Displayed in the frmMethodOfReferencingTrademarkssForScreenDisplay
                '                        '  Form - Then Moved to the Next Record each time this cmdButton is clicked
                '                        If .EOF Then
                '                            'Disable this Command Button
                '                            Me.btnNext.Enabled = False
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                Case vbCancel
                '                                    '                              LastRecordNumberOfFoundSubdocketNumber = .RecordCount
                '                                    '                              .MoveLast
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        If (InStr(.Fields!FirstNamedAssignee, InsertedAParticularAssignee) > 0) Or
                '                      (InStr(.Fields!SecondNamedAssignee, InsertedAParticularAssignee) > 0) Or
                '                      (InStr(.Fields!ThirdNamedAssignee, InsertedAParticularAssignee) > 0) Or
                '                      (InStr(.Fields!FourthNamedAssignee, InsertedAParticularAssignee) > 0) Then
                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Display the Found DB Record Number
                '                            BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            If .AbsolutePosition = .RecordCount Then
                '                                'Disable this Command Button
                '                                Me.btnNext.Enabled = False
                '                                Exit Sub
                '                            End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With
                '            Case 12  '9, 10, 11, 12
                '                With adoRKLTrademarkRecordset 'This is for the TrademarkDocments Table
                '                    Do Until .EOF
                '                        .MoveNext() 'Pointer is Moved to the Next Record because the First record was
                '                        '  Displayed in the frmMethodOfReferencingTrademarkssForScreenDisplay
                '                        '  Form - Then Moved to the Next Record each time this cmdButton is clicked
                '                        If .EOF Then
                '                            'Disable this Command Button
                '                            Me.btnNext.Enabled = False
                '                            Call msgNoFurtherTrademarkDocumentsLeftInTheComputerRecords(tempResponse)
                '                            FoundAtLeastOneRecord = False
                '                            NowAtEOF = True
                '                            Select Case tempResponse
                '                                Case vbYes
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'ReStart the Referencing Form
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.btnReset.PerformClick()
                '                                    'Unload the Statement Display form
                '                                    Me.Close()
                '                                    Exit Sub
                '                                Case vbNo
                '                                    'Close the Trademark Table
                '                                    CloseTableInRKLTrademarkDB()
                '                                    'Close the Connection
                '                                    CloseConnectionToRKLTrademarkDB()
                '                                    'Unload all forms except the Menu
                '                                    Me.Close()
                '                                    frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                '                                    Exit Sub
                '                                Case vbCancel
                '                                    Me.btnRestoreAllOriginalValues.PerformClick()
                '                            End Select
                '                            Exit Sub
                '                        End If
                '                        CurrentFormName = "frmTrademarkDisplayOrParameterChanges"
                '                        Call DoCharSearch
                '                        If NowAtEOF = True Then Exit Sub
                '                        If FoundAtLeastOneRecord Then
                '                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                '                            InitialValuesAlreadyLoaded = True
                '                            'Display the Found DB Record Number
                '                            '                                        BookmarkOfRecordFoundDuringOKDisplay = .Bookmark
                '                            '                                        AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            'Increment the Record-Being-Displayed Sequesnce counter by 1
                '                            SequenceNumberOfRecordBeingDisplayed = SequenceNumberOfRecordBeingDisplayed + 1
                '                            'Dispaly the new Sequence Number
                '                            Me.lblDocOfTotalDocs.Text = "Doc.#: " & SequenceNumberOfRecordBeingDisplayed.ToString
                '                            Me.txtDBRecordNumber.Text = Trim$(Str$(BookmarkOfRecordFoundDuringOKDisplay))
                '                            '                                        If .AbsolutePosition = .RecordCount Then
                '                            '                                            'Disable this Command Button
                '                            '                                            Me.btnNext.Enabled = False
                '                            '                                   '''''                        'Set the Focus to the Previous Cmd Button so user doesn't
                '                            '                                   '''''                        '  have to click without any record movement
                '                            '                                   '''''                        Me.cmdPrevStatement.SetFocus
                '                            '                                   '''''                        cmdPreviousStatmentButtonJustClickedForTheFirstTime = True
                '                            '                                            Exit Sub
                '                            '                                        End If
                '                            Exit Sub
                '                        End If
                '                    Loop
                '                End With
        End Select

    End Sub

    Private Sub btnRestoreAllOriginalValues_Click(sender As Object, e As EventArgs) Handles btnRestoreAllOriginalValues.Click
        'Place all the Trademark Document's Fields back in the Display Form for the
        'Set the DB-Table to the Current Record
        'Open a Connection to the RKL Trademark Database
        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        ''Open the Trademark Table
        OpenTableInRKLTrademarkDB("TrademarkDocuments")
        'Move the Record-Pointer to the Originally FOUND record
        adoRKLTrademarkRecordset.MoveFirst()
        'adoRKLTrademarkRecordset.Bookmark = BookmarkOfRecordFoundDuringOKDisplay
        adoRKLTrademarkRecordset.AbsolutePosition = AbsolutePositionOfRecordFoundDuringOKDisplay

        Call AssignTrademarkRecordToDisplayFormFields(Me)
        'The next Variable is used to make sure that the frmChangeParameterValue does not appear during this procedure
        RestoringOriginalValues = True

        With Me
            'Restore the grpColors and chkBoxes
            .grpRKLDocketNumber.BackColor = clrLightestGray
            .grpClientDocketNumber.BackColor = clrLightestGray
            .grpCountryCode.BackColor = clrLightestGray
            .grpResponsibleAttorney.BackColor = clrLightestGray
            .grpTrademarkType.BackColor = clrLightestGray
            .grpMarkText.BackColor = clrLightestGray
            .grpGoodsServicesUsedByMark.BackColor = clrLightestGray
            .grpFirstUseDateInCommerce.BackColor = clrLightestGray
            .grpFirstUseDate.BackColor = clrLightestGray

            For I = 0 To 8
                chkControlArrayForDisplayOrChanges.chkItem(I).BackColor = clrLightestGray
                chkControlArrayForDisplayOrChanges.chkItem(I).CheckState = CheckState.Unchecked
            Next I

            'Reset the Form-Bottom Buttons
            .btnNext.Enabled = True
            .btnDone.Font = RKLFont16BI 'RKLFont(16, "B", "I")
            .btnDone.Text = " D o n e "
            .btnDone.Enabled = True
            .btnRestoreAllOriginalValues.Enabled = False
            '.btnCancel.Enabled = False
        End With

        RestoringOriginalValues = False



    End Sub

    Private Sub txtFullDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFullDocketNumber.TextChanged
        With Me
            If Trim(.txtFullDocketNumber.Text.Length) > 0 Then
                .txtFullDocketNumber.BackColor = clrLightGreen
            Else
                .txtFullDocketNumber.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtClientDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtClientDocketNumber.TextChanged
        With Me
            If Trim(.txtClientDocketNumber.Text.Length) > 0 Then
                .txtClientDocketNumber.BackColor = clrLightGreen
            Else
                .txtClientDocketNumber.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtCountryCode_TextChanged(sender As Object, e As EventArgs) Handles txtCountryCode.TextChanged
        With Me
            If Trim(.txtCountryCode.Text.Length) > 0 Then
                .txtCountryCode.BackColor = clrLightGreen
            Else
                .txtCountryCode.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponsibleAttorney_TextChanged(sender As Object, e As EventArgs) Handles txtResponsibleAttorney.TextChanged
        With Me
            If Trim(.txtResponsibleAttorney.Text.Length) > 0 Then
                .txtResponsibleAttorney.BackColor = clrLightGreen
            Else
                .txtResponsibleAttorney.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtTypeOfTrademark_TextChanged(sender As Object, e As EventArgs) Handles txtTrademarkType.TextChanged
        With Me
            If Trim(.txtTrademarkType.Text.Length) > 0 Then
                .txtTrademarkType.BackColor = clrLightGreen
            Else
                .txtTrademarkType.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub frmTrademarkDisplayOrParameterChanges_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.txtFullDocketNumber.SelectionStart = 0
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim tempDate As String

        If Me.btnDone.Text = " D o n e " Then
            '''''     'Reset variables
            '''''     ReShowingForms = False
            '''''     NowChangingStatementDisbursementFees = False
            '''''     ChangesHaveBeenMadeSoOKToPrintRevisedStatements = False

            'Close the Table
            CloseTableInRKLTrademarkDB()
            'Close the Connection
            CloseConnectionToRKLTrademarkDB()
            'Reset ALL of the Controls in the Methods Form so
            ' they can be reused properly if the User goes directly back
            ' in to another session using Methods
            '    frmMethodsOfReferencingStatementsForScreenDisplay.cmdReset.Value = 1
            'Unload the Forms
            frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
            InitialValuesAlreadyLoaded = False
            CurrentFormName = "frmMainMenu2"
            Me.Close()
            Exit Sub
        End If

        Dim Response As Integer
        Call msgSureWantToSaveChangedDataFields(Response)
        Select Case Response
            Case vbCancel
                Exit Sub
            Case vbYes
                'Continue by doing nothing else here
                'Do nothing - Let the flow continue in this Subroutine
            Case vbNo
                'Close the Trademark Documents Table
                CloseTableInRKLTrademarkDB()
                'Close the Connection
                CloseConnectionToRKLTrademarkDB()
                frmMethodsOfReferencingTrademarksForScreenDisplay.Show()
                '        NowChangingStatementDisbursementFees = False
                Me.Close()
                '        msgSavedNoChangesToParameters
                Exit Sub
        End Select

        Dim NewDocketNumber As String
        Dim NewSubDocketNumber As String
        'Dim BaseSubDocketNumber As String
        'Dim PositionOfSDNSeperator As Integer
        'Dim PositionOfSDNSeperatorFound As Boolean

        Dim tempLenOfFullDocketNumber As Integer
        Dim tempQtyCharsBeforeDash As Integer
        Dim tempQtyCharsAfterDash As Integer

        'Open a Connection to the RKL Trademark Database
        OpenConnectionToRKLTrademarkDB("rklTrademark.mdb")
        'Open the TrademarkDocuments Table
        OpenTableInRKLTrademarkDB("TrademarkDocuments")
        'Set the Absolute-Record-Pointer to the Same Record Number Found in frmMethodsOfReferencingTrademarksForScreenDisplay        
        adoRKLTrademarkRecordset.AbsolutePosition = AbsolutePositionOfRecordFoundDuringOKDisplay
        With Me
            .btnNext.Enabled = True

            'Docket Number and SubDocket Number
            If chkControlArrayForDisplayOrChanges.chkItem(0).Checked = True Then 'The Full Docket Number has changed
                ''Parse and Capture the DocketNumber Sub-Docket Number from the Full Docket Number
                '' Parse and Find the character-location of the - character from the Full Docket Number
                tempQtyCharsBeforeDash = InStr(1, Trim$(.txtFullDocketNumber.Text), "-") - 1
                tempLenOfFullDocketNumber = Len(Trim$(.txtFullDocketNumber.Text))
                tempQtyCharsAfterDash = tempLenOfFullDocketNumber - tempQtyCharsBeforeDash - 1
                NewDocketNumber = Mid(Trim$(.txtFullDocketNumber.Text), 1, tempQtyCharsBeforeDash)
                NewSubDocketNumber = Mid(Trim$(.txtFullDocketNumber.Text), tempQtyCharsBeforeDash + 2, tempQtyCharsAfterDash)

                DocketNumber = NewDocketNumber
                SubDocketNumber = NewSubDocketNumber

                ''Next for the SubDocket Data-Field use the NewSubDocketNumber not the BaseSubDocketNumber
                adoRKLTrademarkRecordset.Fields!DocketNumber.Value = Trim$(NewDocketNumber)
                adoRKLTrademarkRecordset.Fields!SubDocketNumber.Value = Trim$(NewSubDocketNumber)

            End If

            'Client Docket Number
            If chkControlArrayForDisplayOrChanges.chkItem(1).Checked = True Then 'The Client Docket Number has changed
                ClientDocketNumber = Trim(.txtClientDocketNumber.Text)
                adoRKLTrademarkRecordset.Fields!ClientDocketNumber.Value = ClientDocketNumber
            End If

            'Country Code
            If chkControlArrayForDisplayOrChanges.chkItem(2).Checked = True Then 'The Country Code has changed
                CountryCode = Trim(.txtCountryCode.Text)
                adoRKLTrademarkRecordset.Fields!CountryCode.Value = CountryCode
            End If

            'Responsible Attorney
            If chkControlArrayForDisplayOrChanges.chkItem(3).Checked = True Then 'The Responsible Attorney has changed
                ResponsibleAttorney = Trim(.txtResponsibleAttorney.Text)
                adoRKLTrademarkRecordset.Fields!ResponsibleAttorney.Value = ResponsibleAttorney
            End If

            'Trademark Type
            If chkControlArrayForDisplayOrChanges.chkItem(4).Checked = True Then 'The Trademark Type has changed
                TrademarkType = Trim(.txtTrademarkType.Text)
                adoRKLTrademarkRecordset.Fields!TrademarkType.Value = TrademarkType
            End If

            'Mark
            If chkControlArrayForDisplayOrChanges.chkItem(5).Checked = True Then 'The Mark has changed
                MarkText = Trim(.txtMarkText.Text)
                adoRKLTrademarkRecordset.Fields!MarkText.Value = MarkText
            End If

            'Goods and/or Services
            If chkControlArrayForDisplayOrChanges.chkItem(6).Checked = True Then 'The Mark has changed
                GoodsServicesUsedByMark = Trim(.txtGoodsServicesUsedByMark.Text)
                adoRKLTrademarkRecordset.Fields!GoodsServicesUsedByMark.Value = GoodsServicesUsedByMark
            End If

            ''First Use Date In Commerce
            If chkControlArrayForDisplayOrChanges.chkItem(7).Checked = True Then 'The First Use Date In Commerce has changed                
                If .txtFirstUseDateInCommerce.Text = "NONE" Then
                    FirstUseDateInCommerce = 0
                Else
                    tempDate = AddSlashesToStringDate(.txtFirstUseDateInCommerce.Text)
                    FirstUseDateInCommerce = ConvertToRKLDate(tempDate)
                End If
                adoRKLTrademarkRecordset.Fields!FirstUseDateInCommerce.Value = FirstUseDateInCommerce
            End If

            ''First Use Date In InterState Commerce
            ''''''If chkControlArrayForDisplayOrChanges.chkItem(8).Checked = True Then 'The First Use Date In InterState Commerce has changed
            ''''''    If .txtFirstUseDateInInterStateCommerce.Text = "NONE" Then
            ''''''        FirstUseDateInInterStateCommerce = 0
            ''''''    Else
            ''''''        tempDate = AddSlashesToStringDate(.txtFirstUseDateInInterStateCommerce.Text)
            ''''''        FirstUseDateInInterStateCommerce = ConvertToRKLDate(tempDate)
            ''''''    End If
            ''''''adoRKLTrademarkRecordset.Fields!FirstUseDateInInterStateCommerce.Value = FirstUseDateInInterStateCommerce
            ''''''End If
        End With
        adoRKLTrademarkRecordset.Update()
        Call CloseTableInRKLTrademarkDB()
        Call CloseConnectionToRKLTrademarkDB()
        Call msgSavedTrademarkDocument()
        Me.Close()
        '''''frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
        CurrentFormName = "frmMainMenu2"
    End Sub

    Private Sub txtMarkText_TextChanged(sender As Object, e As EventArgs) Handles txtMarkText.TextChanged
        With Me
            If Trim(.txtMarkText.Text.Length) > 0 Then
                .txtMarkText.BackColor = clrLightGreen
            Else
                .txtMarkText.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtGoodsServicesUsedByMark_TextChanged(sender As Object, e As EventArgs) Handles txtGoodsServicesUsedByMark.TextChanged
        With Me
            If Trim(.txtGoodsServicesUsedByMark.Text.Length) > 0 Then
                .txtGoodsServicesUsedByMark.BackColor = clrLightGreen
            Else
                .txtGoodsServicesUsedByMark.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtFirstUseDateInCommerce_TextChanged(sender As Object, e As EventArgs) Handles txtFirstUseDateInCommerce.TextChanged
        With Me
            If Trim(.txtFirstUseDateInCommerce.Text.Length) > 0 Then
                .txtFirstUseDateInCommerce.BackColor = clrLightGreen
            Else
                .txtFirstUseDateInCommerce.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtFirstUseDate_TextChanged(sender As Object, e As EventArgs) Handles txtFirstUseDate.TextChanged
        With Me
            If Trim(.txtFirstUseDate.Text.Length) > 0 Then
                .txtFirstUseDate.BackColor = clrLightGreen
            Else
                .txtFirstUseDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived1st_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived1st.TextChanged
        With Me
            Dim tempText As String
            tempText = .txtActionTypeReceived1st.Text
            If Trim(.txtActionTypeReceived1st.Text.Length) > 0 Then
                .txtActionTypeReceived1st.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived1st.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived2nd_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived2nd.TextChanged
        With Me
            If Trim(.txtActionTypeReceived2nd.Text.Length) > 0 Then
                .txtActionTypeReceived2nd.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived2nd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived3rd_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived3rd.TextChanged
        With Me
            If Trim(.txtActionTypeReceived3rd.Text.Length) > 0 Then
                .txtActionTypeReceived3rd.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived3rd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived4th_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived4th.TextChanged
        With Me
            If Trim(.txtActionTypeReceived4th.Text.Length) > 0 Then
                .txtActionTypeReceived4th.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived4th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived5th_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived5th.TextChanged
        With Me
            If Trim(.txtActionTypeReceived5th.Text.Length) > 0 Then
                .txtActionTypeReceived5th.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived5th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtActionTypeReceived6th_TextChanged(sender As Object, e As EventArgs) Handles txtActionTypeReceived6th.TextChanged
        With Me
            If Trim(.txtActionTypeReceived6th.Text.Length) > 0 Then
                .txtActionTypeReceived6th.BackColor = clrLightGreen
            Else
                .txtActionTypeReceived6th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtMailingDate1st_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate1st.TextChanged
        With Me
            If Trim(.txtMailingDate1st.Text.Length) > 0 Then
                .txtMailingDate1st.BackColor = clrLightGreen
            Else
                .txtMailingDate1st.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtMailingDate2nd_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate2nd.TextChanged
        With Me
            If Trim(.txtMailingDate2nd.Text.Length) > 0 Then
                .txtMailingDate2nd.BackColor = clrLightGreen
            Else
                .txtMailingDate2nd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtMailingDate3rd_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate3rd.TextChanged
        With Me
            If Trim(.txtMailingDate3rd.Text.Length) > 0 Then
                .txtMailingDate3rd.BackColor = clrLightGreen
            Else
                .txtMailingDate3rd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtMailingDate4th_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate4th.TextChanged
        With Me
            If Trim(.txtMailingDate4th.Text.Length) > 0 Then
                .txtMailingDate4th.BackColor = clrLightGreen
            Else
                .txtMailingDate4th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtMailingDate5th_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate5th.TextChanged
        With Me
            If Trim(.txtMailingDate5th.Text.Length) > 0 Then
                .txtMailingDate5th.BackColor = clrLightGreen
            Else
                .txtMailingDate5th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub
    Private Sub txtMailingDate6th_TextChanged(sender As Object, e As EventArgs) Handles txtMailingDate6th.TextChanged
        With Me
            If Trim(.txtMailingDate6th.Text.Length) > 0 Then
                .txtMailingDate6th.BackColor = clrLightGreen
            Else
                .txtMailingDate6th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate1st_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate1st.TextChanged
        With Me
            If Trim(.txtResponseDueDate1st.Text.Length) > 0 Then
                .txtResponseDueDate1st.BackColor = clrLightGreen
            Else
                .txtResponseDueDate1st.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate2nd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate2nd.TextChanged
        With Me
            If Trim(.txtResponseDueDate2nd.Text.Length) > 0 Then
                .txtResponseDueDate2nd.BackColor = clrLightGreen
            Else
                .txtResponseDueDate2nd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate3rd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate3rd.TextChanged
        With Me
            If Trim(.txtResponseDueDate3rd.Text.Length) > 0 Then
                .txtResponseDueDate3rd.BackColor = clrLightGreen
            Else
                .txtResponseDueDate3rd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate4th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate4th.TextChanged
        With Me
            If Trim(.txtResponseDueDate4th.Text.Length) > 0 Then
                .txtResponseDueDate4th.BackColor = clrLightGreen
            Else
                .txtResponseDueDate4th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate5th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate5th.TextChanged
        With Me
            If Trim(.txtResponseDueDate5th.Text.Length) > 0 Then
                .txtResponseDueDate5th.BackColor = clrLightGreen
            Else
                .txtResponseDueDate5th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseDueDate6th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseDueDate6th.TextChanged
        With Me
            If Trim(.txtResponseDueDate6th.Text.Length) > 0 Then
                .txtResponseDueDate6th.BackColor = clrLightGreen
            Else
                .txtResponseDueDate6th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub
    Private Sub txtResponseMadeDate1st_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate1st.TextChanged
        With Me
            If Trim(.txtResponseMadeDate1st.Text.Length) > 0 Then
                .txtResponseMadeDate1st.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate1st.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseMadeDate2nd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate2nd.TextChanged
        With Me
            If Trim(.txtResponseMadeDate2nd.Text.Length) > 0 Then
                .txtResponseMadeDate2nd.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate2nd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseMadeDate3rd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate3rd.TextChanged
        With Me
            If Trim(.txtResponseMadeDate3rd.Text.Length) > 0 Then
                .txtResponseMadeDate3rd.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate3rd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseMadeDate4th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate4th.TextChanged
        With Me
            If Trim(.txtResponseMadeDate4th.Text.Length) > 0 Then
                .txtResponseMadeDate4th.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate4th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseMadeDate5th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate5th.TextChanged
        With Me
            If Trim(.txtResponseMadeDate5th.Text.Length) > 0 Then
                .txtResponseMadeDate5th.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate5th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseMadeDate6th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseMadeDate6th.TextChanged
        With Me
            If Trim(.txtResponseMadeDate6th.Text.Length) > 0 Then
                .txtResponseMadeDate6th.BackColor = clrLightGreen
            Else
                .txtResponseMadeDate6th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType1st_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType1st.TextChanged
        With Me
            If Trim(.txtResponseType1st.Text.Length) > 0 Then
                .txtResponseType1st.BackColor = clrLightGreen
            Else
                .txtResponseType1st.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType2nd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType2nd.TextChanged
        With Me
            If Trim(.txtResponseType2nd.Text.Length) > 0 Then
                .txtResponseType2nd.BackColor = clrLightGreen
            Else
                .txtResponseType2nd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType3rd_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType3rd.TextChanged
        With Me
            If Trim(.txtResponseType3rd.Text.Length) > 0 Then
                .txtResponseType3rd.BackColor = clrLightGreen
            Else
                .txtResponseType3rd.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType4th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType4th.TextChanged
        With Me
            If Trim(.txtResponseType4th.Text.Length) > 0 Then
                .txtResponseType4th.BackColor = clrLightGreen
            Else
                .txtResponseType4th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType5th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType5th.TextChanged
        With Me
            If Trim(.txtResponseType5th.Text.Length) > 0 Then
                .txtResponseType5th.BackColor = clrLightGreen
            Else
                .txtResponseType5th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtResponseType6th_TextChanged(sender As Object, e As EventArgs) Handles txtResponseType6th.TextChanged
        With Me
            If Trim(.txtResponseType6th.Text.Length) > 0 Then
                .txtResponseType6th.BackColor = clrLightGreen
            Else
                .txtResponseType6th.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub
End Class