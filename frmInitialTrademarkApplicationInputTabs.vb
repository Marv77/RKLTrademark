Public Class frmInitialTrademarkApplicationInputTabs
    Public rdoArrayYesOrNo As RadioButtonArray
    Public rdoArrayYesOrNoHaveThereBeenAnyOfficialActions As RadioButtonArray
    Public rdoArrayYesOrNoAreThereAnyMoreOfficialActions As RadioButtonArray
    Public rdoArrayYesOrNoIsThisCorrect As RadioButtonArray
    Public rdoArrayYesOrNoWasAResponseFiled As RadioButtonArray
    Public rdoArrayTypeOfTMOfficeActions As RadioButtonArray
    Public rdoArrayTypeOfTimeGivenForAResponse As RadioButtonArray
    Public rdoArrayTypeOfTMResponseMade As RadioButtonArray
    Public rdoArrayReviewEachOfficeAction As RadioButtonArray
    Public btnArrayReviewNextOfficeActionsGroup As ButtonArray
    Public chkControlArrayForSelectingStates As CheckBoxArray

    Public LastInventorNameViewed As Integer
    Public AssigneeIndexChecked As Integer
    Public AssignmentYesIndexChecked As Integer
    Public LastAssigneeHasBeenChecked As Boolean



    Private Sub frmInitialTrademarkDocumentInputTabs_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim rdoTitleReviewEachOfficeAction As String
        Dim rdoTitleTypeOfTMOfficialActions As String
        Dim rdoTitleTypeOfTimeGivenForAResponse As String
        Dim rdoTitleTypeOfTMResponseMade As String

        Dim LeftTypeOfTrademark As Integer
        Dim TopTypeOfTrademark As Integer

        Dim StateName As String
        Dim StateNumber As Integer
        Dim chkLeft As Integer
        Dim LeftColBase As Integer
        Dim chkTop As Integer
        Dim SpaceFactor As Integer

        NowInDisplayModeForOfficialActions = False

        With Me
            CurrentFormName = .Name
            WindowState = FormWindowState.Maximized

            .lblFormTitle.Font = RKLFont16B
            .lblFormTitle.Text = "Initial Trademark Document Input (continued)"
            .lblFormTitle.Top = 5
            .lblFormTitle.Left = 100

            'Setup Client Identification Summary
            .grpClientIdentificationSummary.Font = RKLFont12B
            .grpClientIdentificationSummary.Text = "Client Identification Summary"

            .grpFullDocketNumber.Font = RKLFont12B
            .grpFullDocketNumber.Text = "Full Docket Number"
            .txtFullDocketNumber.Font = RKLFont12B
            .txtFullDocketNumber.Text = FullDocketNumber
            .txtFullDocketNumber.BackColor = clrSpringGreen
            .txtFullDocketNumber.ReadOnly = True

            .grpClientDocketNumber.Font = RKLFont12B
            .grpClientDocketNumber.Text = "Client Docket Number"
            .txtClientDocketNumber.Font = RKLFont12B
            .txtClientDocketNumber.Text = ClientDocketNumber
            .txtClientDocketNumber.BackColor = clrSpringGreen
            .txtClientDocketNumber.ReadOnly = True

            .grpClientName.Font = RKLFont12B
            .grpClientName.Text = "Client Name"
            .txtClientName.Font = RKLFont12B
            .txtClientName.Text = ClientName
            .txtClientName.BackColor = clrSpringGreen
            .txtClientName.ReadOnly = True

            'Setup Trademark Identification
            .grpTrademarkIdentification.Font = RKLFont12B
            .grpTrademarkIdentification.Text = "Trademark Identification"

            .grpMark.Font = RKLFont12B
            .grpMark.Text = "Mark"
            .txtMark.Font = RKLFont12B
            .txtMark.Text = MarkText
            .txtMark.BackColor = clrSpringGreen
            .txtMark.ReadOnly = True

            .grpGoodsAndOrServices.Font = RKLFont12B
            .grpGoodsAndOrServices.Text = "Goods and/or Services Used by the Mark"
            .txtGoodsAndOrServices.Font = RKLFont12B
            .txtGoodsAndOrServices.Text = GoodsServicesUsedByMark
            .txtGoodsAndOrServices.BackColor = clrSpringGreen
            .txtGoodsAndOrServices.ReadOnly = True

            .grpDisplayFirstUseDate.Font = RKLFont12B
            .grpDisplayFirstUseDate.Text = "First Use Date"
            .txtDisplayFirstUseDate.Font = RKLFont12B

            If FirstUseDate = 0 Then
                .txtDisplayFirstUseDate.Text = "NONE"
            Else
                .txtDisplayFirstUseDate.Text = ConvertFromRKLDate(FirstUseDate, "MonthNumber")
            End If
            .txtDisplayFirstUseDate.BackColor = clrSpringGreen
            .txtDisplayFirstUseDate.ReadOnly = True

            .grpDisplayFirstUseDateInCommerce.Font = RKLFont12B
            .grpDisplayFirstUseDateInCommerce.Text = "First Use Date in Commerce"
            .txtDisplayFirstUseDateInCommerce.Font = RKLFont12B

            If FirstUseDateInCommerce = 0 Then
                .txtDisplayFirstUseDateInCommerce.Text = "NONE"
            Else
                .txtDisplayFirstUseDateInCommerce.Text = ConvertFromRKLDate(FirstUseDateInCommerce, "MonthNumber")
            End If
            .txtDisplayFirstUseDateInCommerce.BackColor = clrSpringGreen
            .txtDisplayFirstUseDateInCommerce.ReadOnly = True

            .grpTMRegistrationNum.Font = RKLFont12B
            .grpTMRegistrationNum.Text = "TM Registration Number"
            .txtTMRegistrationNum.Font = RKLFont12B
            .txtTMRegistrationNum.Text = ""
            .txtTMRegistrationNum.ReadOnly = True

            .grpTMRegistrationDate.Font = RKLFont12B
            .grpTMRegistrationDate.Text = "TM Registration Date"
            .txtTMRegistrationDate.Font = RKLFont12B
            .txtTMRegistrationDate.Text = ""
            .txtTMRegistrationDate.ReadOnly = True

            .grpTMSerialNum.Font = RKLFont12B
            .grpTMSerialNum.Text = "TM Serial Number"
            .txtTMSerialNum.Font = RKLFont12B
            .txtTMSerialNum.Text = ""
            .txtTMSerialNum.ReadOnly = True

            .grpTMApplicationFilinglDate.Font = RKLFont12B
            .grpTMApplicationFilinglDate.Text = "TM Application Filing Date"
            .txtTMApplicationFilinglDate.Font = RKLFont12B
            .txtTMApplicationFilinglDate.Text = ""
            .txtTMApplicationFilinglDate.ReadOnly = True

            If CategoryOfTrademarkType = "Madrid Protocol" Then
                .grpMadridProtocolSerialNumber.Visible = True
                .grpMadridProtocolSerialNumber.Font = RKLFont12B
                .grpMadridProtocolSerialNumber.Text = "Madrid Protocol Serial No.:"
                .txtMadridProtocolSerialNumber.Font = RKLFont12B
                .txtMadridProtocolSerialNumber.Text = MadridProtocolSerialNumber.ToString
                .txtMadridProtocolSerialNumber.BackColor = clrSpringGreen
                .txtMadridProtocolSerialNumber.ReadOnly = True

                .grpWIPOFilingDate.Visible = True
                .grpWIPOFilingDate.Font = RKLFont12B
                .grpWIPOFilingDate.Text = "WIPO Filing Date"
                .txtWIPOFilingDate.Font = RKLFont12B
                .txtWIPOFilingDate.Text = ConvertFromRKLDate(WIPOFilingDate, "MonthNumber")
                .txtWIPOFilingDate.BackColor = clrSpringGreen
                .txtWIPOFilingDate.ReadOnly = True
            Else
                .grpMadridProtocolSerialNumber.Visible = False
                .grpWIPOFilingDate.Visible = False
            End If

            'Initialize All of the Action Variables so there will be no NULL values in the Variables
            Call InitializeAllActionVariables()

            'Disable all but the First Tab
            .tabOfficialActionsAndResponses.Enabled = False
            '.tabStateRegistrations.Enabled = False

            'Setup the Tab for the TM Registration Number/Date and Serial Number and Date
            .tabTrademarkDocument.TabPages(0).BackColor = clrLighestOrange


            Select Case TrademarkType
                Case "Federal Trademark Application"
                    .tabTrademarkDocument.TabPages(0).Text = "Application"
                    .grpTMApplicationAndRegistration.Font = RKLFont14B
                    .grpTMApplicationAndRegistration.Text = "Trademark Application"

                    '''''''  Set up the Group for the TM Registraton NUMBER and DATE
                    ''''''.grpTMRegNumDate.Font = RKLFont12B
                    ''''''.grpTMRegNumDate.Text = "Enter Trademark Registration Number and Registration Date"
                    ''''''.grpTMRegNumDate.BackColor = clrLighestOrange

                    '''''''  Set up the TM Registraton NUMBER
                    ''''''.grpEnterTMRegNum.Text = ""
                    ''''''.grpEnterTMRegNum.BackColor = clrOrange

                    ''''''.lblEnterTMRegNum.Font = RKLFont12BI
                    ''''''.lblEnterTMRegNum.Text = "Enter Trademark Registration Number:"
                    ''''''.lblEnterTMRegNum.BackColor = clrOrange

                    ''''''.txtEnterTMRegNum.Font = RKLFont12B
                    ''''''.txtEnterTMRegNum.Text = ""
                    ''''''.txtEnterTMRegNum.Focus()

                    ''''''.btnDoneEnterTMRegNum.Font = RKLFont12BI
                    ''''''.btnDoneEnterTMRegNum.Text = "Done"
                    ''''''.btnDoneEnterTMRegNum.Enabled = False

                    '''''''  Set up the TM Registraton DATE
                    ''''''.grpEnterTMRegDate.Text = ""
                    ''''''.grpEnterTMRegDate.BackColor = clrControl

                    ''''''.lblEnterTMRegDate.Font = RKLFont12BI
                    ''''''.lblEnterTMRegDate.Text = "Enter Trademark Registration Date:"

                    ''''''.lblEnterTMRegDate.Enabled = False
                    ''''''.grpEnterTMRegDate.Enabled = False

                    'Hide the Registration Group
                    '.grpTMRegNumDate.Visible = False

                    '  Set up the Group for the TM Serial NUMBER and DATE
                    .grpTMSerNumDate.Font = RKLFont12B
                    .grpTMSerNumDate.Text = "Enter Trademark Serial Number and Application Filing Date"
                    .grpTMSerNumDate.Enabled = True
                    .grpTMSerNumDate.BackColor = clrLighestOrange    'clrControl


                    '  Set up the TM Serial NUMBER
                    .grpEnterTMSerNum.Enabled = True
                    .grpEnterTMSerNum.Text = ""
                    .grpEnterTMSerNum.BackColor = clrOrange 'clrControl

                    .lblEnterTMSerNum.Enabled = True
                    .lblEnterTMSerNum.Font = RKLFont12BI
                    .lblEnterTMSerNum.Text = "Enter Trademark Serial Number:"
                    .lblEnterTMSerNum.BackColor = clrOrange 'clrControl

                    .txtEnterTMSerNum.Enabled = True
                    .txtEnterTMSerNum.Font = RKLFont12B
                    .txtEnterTMSerNum.Text = ""
                    .txtEnterTMSerNum.Focus()

                    .btnDoneEnterTMSerNum.Font = RKLFont12BI
                    .btnDoneEnterTMSerNum.Text = "Done"
                    .btnDoneEnterTMSerNum.Enabled = False

                    '.grpEnterTMSerNum.Enabled = False
                    '.lblEnterTMSerNum.Enabled = False
                    '.txtEnterTMSerNum.Enabled = False

                    '  Set up the TM Application Filing DATE
                    .grpEnterTMSerDate.Text = ""
                    .grpEnterTMSerDate.BackColor = clrControl

                    .lblEnterTMSerDate.Font = RKLFont12BI
                    .lblEnterTMSerDate.Text = "Enter Trademark Application Filing Date:"
                    .lblEnterTMSerDate.BackColor = clrControl

                    .grpEnterTMSerDate.Enabled = False
                    .lblEnterTMSerDate.Enabled = False
                    .mtbEnterTMSerDate.Enabled = False

                    .btnDoneEnteringTMRegAndSer.Font = RKLFont12BI
                    .btnDoneEnteringTMRegAndSer.Text = "Done - Entering TM Registaration and Application"
                    .btnDoneEnteringTMRegAndSer.Enabled = False
                Case "Federal Trademark Registration"
                    '.grpTMApplicationAndRegistration.Font = RKLFont14B
                    '.grpTMApplicationAndRegistration.Text = "Trademark Registration and Application"

                    ''  Set up the Group for the TM Registraton NUMBER and DATE
                    '.grpTMRegNumDate.Font = RKLFont12B
                    '.grpTMRegNumDate.Text = "Enter Trademark Registration Number and Registration Date"
                    '.grpTMRegNumDate.BackColor = clrLighestOrange

                    ''  Set up the TM Registraton NUMBER
                    '.grpEnterTMRegNum.Text = ""
                    '.grpEnterTMRegNum.BackColor = clrOrange

                    '.lblEnterTMRegNum.Font = RKLFont12BI
                    '.lblEnterTMRegNum.Text = "Enter Trademark Registration Number:"
                    '.lblEnterTMRegNum.BackColor = clrOrange

                    '.txtEnterTMRegNum.Font = RKLFont12B
                    '.txtEnterTMRegNum.Text = ""
                    '.txtEnterTMRegNum.Focus()

                    '.btnDoneEnterTMRegNum.Font = RKLFont12BI
                    '.btnDoneEnterTMRegNum.Text = "Done"
                    '.btnDoneEnterTMRegNum.Enabled = False

                    ''  Set up the TM Registraton DATE
                    '.grpEnterTMRegDate.Text = ""
                    '.grpEnterTMRegDate.BackColor = clrControl

                    '.lblEnterTMRegDate.Font = RKLFont12BI
                    '.lblEnterTMRegDate.Text = "Enter Trademark Registration Date:"

                    '.lblEnterTMRegDate.Enabled = False
                    '.grpEnterTMRegDate.Enabled = False

                    '  Set up the Group for the TM Serial NUMBER and DATE
                    .grpTMSerNumDate.Font = RKLFont12B
                    .grpTMSerNumDate.Text = "Enter Trademark Serial Number and Application Filing Date"
                    .grpTMSerNumDate.BackColor = clrControl
                    .grpTMSerNumDate.Enabled = False

                    '  Set up the TM Serial NUMBER
                    .grpEnterTMSerNum.Text = ""
                    .grpEnterTMSerNum.BackColor = clrControl

                    .lblEnterTMSerNum.Font = RKLFont12BI
                    .lblEnterTMSerNum.Text = "Enter Trademark Serial Number:"
                    .lblEnterTMSerNum.BackColor = clrControl

                    .txtEnterTMSerNum.Font = RKLFont12B
                    .txtEnterTMSerNum.Text = ""

                    .btnDoneEnterTMSerNum.Font = RKLFont12BI
                    .btnDoneEnterTMSerNum.Text = "Done"
                    .btnDoneEnterTMSerNum.Enabled = False

                    .grpEnterTMSerNum.Enabled = False
                    .lblEnterTMSerNum.Enabled = False
                    .txtEnterTMSerNum.Enabled = False

                    '  Set up the TM Application Filing DATE
                    .grpEnterTMSerDate.Text = ""
                    .grpEnterTMSerDate.BackColor = clrControl

                    .lblEnterTMSerDate.Font = RKLFont12BI
                    .lblEnterTMSerDate.Text = "Enter Trademark Application Filing Date:"
                    .lblEnterTMSerDate.BackColor = clrControl

                    .grpEnterTMSerDate.Enabled = False
                    .lblEnterTMSerDate.Enabled = False
                    .mtbEnterTMSerDate.Enabled = False

                    .btnDoneEnteringTMRegAndSer.Font = RKLFont12BI
                    .btnDoneEnteringTMRegAndSer.Text = "Done - Entering Trademark Application"
                    .btnDoneEnteringTMRegAndSer.Enabled = False
            End Select

            '^^^End of Tab for TM Registration and Application Filing Date Setup^^^^^^^^^^^^^^^^

            'Setup the Tab for Official Actions
            SequenceOfPatentOfficeAction = 1

            .tabTrademarkDocument.TabPages(1).BackColor = clrLighestOrange

            .grpOfficialActionsAndResponses.Font = RKLFont14B
            .grpOfficialActionsAndResponses.Text = "Official Actions and Responses to the USPTO"

            '.grpActionDate.Font = RKLFont12B
            '.grpActionDate.Text = "Action Mailing Date"
            '.txtActionDate.Font = RKLFont12B
            '.txtActionDate.BackColor = clrSpringGreen
            '.txtActionDate.ReadOnly = True
            '.grpActionDate.Visible = False

            ''The next code-segment is for testing only>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '.tlpHaveThereBeenAnyOfficialActions.ColumnCount = 3
            '.tlpHaveThereBeenAnyOfficialActions.SetColumnSpan(grpReviewEachOfficeAction, 3)
            '.grpHaveThereBeenAnyOfficialActions.Visible = False
            '.grpEnterPatentOfficeMailingDate.Visible = False
            '.grpReviewEachOfficeAction.Top = 2
            '.grpReviewEachOfficeAction.BackColor = clrOrange
            '.grpReviewEachOfficeAction.Height = 80
            '.grpReviewEachOfficeAction.Width = 1200
            '.grpReviewEachOfficeAction.Text = ""
            ''.lblReviewEachOfficeAction.Visible = False
            '.lblReviewEachOfficeAction.Font = RKLFont13BI
            '.lblReviewEachOfficeAction.Top = 17  '20
            '.lblReviewEachOfficeAction.Left = 16
            '.lblReviewEachOfficeAction.Text = "Click on the Official Action you would like to Review:"
            '''''Now create the opt's for the Six and Twelve Actions to be Reviewed
            'rdoArrayReviewEachOfficeAction = New RadioButtonArray(Me)
            'GroupInDocumentInputTabs = "grpReviewEachOfficeAction"

            'TopTypeOfTrademark = 8

            'LeftTypeOfTrademark = 520
            'rdoTitleReviewEachOfficeAction = "First"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 600
            'rdoTitleReviewEachOfficeAction = "Second"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 710
            'rdoTitleReviewEachOfficeAction = "Third"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 800
            'rdoTitleReviewEachOfficeAction = "Fourth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 900
            'rdoTitleReviewEachOfficeAction = "Fifth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 980
            'rdoTitleReviewEachOfficeAction = "Sixth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'TopTypeOfTrademark = 6

            'LeftTypeOfTrademark = 480
            'rdoTitleReviewEachOfficeAction = "Seventh"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 585
            'rdoTitleReviewEachOfficeAction = "Eighth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 680
            'rdoTitleReviewEachOfficeAction = "Ninth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 765
            'rdoTitleReviewEachOfficeAction = "Tenth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 855
            'rdoTitleReviewEachOfficeAction = "Eleventh"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 965
            'rdoTitleReviewEachOfficeAction = "Twelveth"
            '.grpReviewEachOfficeAction.Controls.Add(rdoArrayReviewEachOfficeAction.AddNewRadioButton(rdoTitleReviewEachOfficeAction, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''Hide opt's Seventh through Twelveth
            'NowReviewing1To6 = True
            ''NowReviewing7To12 = False
            'For I = 6 To 11  '0 To 5
            '    .rdoArrayReviewEachOfficeAction.rdoItem(I).Visible = False
            'Next

            ''Now create the Button to switch the view from 1-6 to 7-12 and visa-versa
            'GroupInDocumentInputTabs = "grpReviewEachOfficeAction"
            'btnArrayReviewNextOfficeActionsGroup = New ButtonArray(Me)

            ''.tplMainMenu.Controls.Add(MyControlArray.AddNewButton("Button Place Holder", 0, 0), 1, I + 1)
            '.grpReviewEachOfficeAction.Controls.Add(btnArrayReviewNextOfficeActionsGroup.AddNewButton(">>7-12", 1080, 17))

            'Hide the Controls for ReviewEachOfficeAction
            ' grp, lbl, opt, btn
            .grpReviewEachOfficeAction.Visible = False

            ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            .grpHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            .grpHaveThereBeenAnyOfficialActions.Text = ""
            .lblHaveThereBeenAnyOfficialActions.Font = RKLFont12BI
            .lblHaveThereBeenAnyOfficialActions.Text = "Have there been any Official Actions from the Post Office?"
            .lblHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            .lblHaveThereBeenAnyOfficialActions.Left = 78

            'rdoArrayYesOrNo = New RadioButtonArray(Me)
            rdoArrayYesOrNoHaveThereBeenAnyOfficialActions = New RadioButtonArray(Me)
            .grpHaveThereBeenAnyOfficialActions.Controls.Add(rdoArrayYesOrNoHaveThereBeenAnyOfficialActions.AddNewRadioButton("Yes", 532, 14))
            .grpHaveThereBeenAnyOfficialActions.Controls.Add(rdoArrayYesOrNoHaveThereBeenAnyOfficialActions.AddNewRadioButton("No", 515, 14))

            .grpEnterPatentOfficeMailingDate.Text = ""
            .lblEnterPatentOfficeMailingDate.Font = RKLFont12BI
            .lblEnterPatentOfficeMailingDate.Text = "Enter Patent Office Mailing Date:"

            .grpEnterPatentOfficeMailingDate.Enabled = False
            .lblEnterPatentOfficeMailingDate.Enabled = False
            .mtbEnterPatentOfficeMailingDate.Enabled = False

            'Now Set up the Multi-Row/Multi-Column Radio Buttons for TypeOfTMOfficActionType
            .grpTypeOfActionReceived.Font = RKLFont12BI
            .grpTypeOfActionReceived.Text = "Click on the Type of Trademark Office Action Received for the"

            aRadioButtonCount = 0
            rdoArrayTypeOfTMOfficeActions = New RadioButtonArray(Me) '<== Me refers to this Form

            GroupInDocumentInputTabs = "grpTypeOfActionReceived"

            LeftTypeOfTrademark = 20 '150  '20
            TopTypeOfTrademark = 15  '8 '10 '20  '5  '1

            rdoTitleTypeOfTMOfficialActions = "1. Application Non-Final Action Received"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "2. Application Final Action Received"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "3. Application Priority Action Received"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "4. Application Examiner's Amendment"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 400 '350 '530  '500 represents the start of a new Column of Radio Buttons
            TopTypeOfTrademark = 15  '8 '10 '20  '1

            rdoTitleTypeOfTMOfficialActions = "5. Application Notice of Publcation"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "6. Abandonment Notification Received"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "7. Suspension of Actions Sent"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMOfficialActions = "8. Notice of Allowance (ONLY INTENT TO USE)"
            .grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 690 '870  '500 represents the start of a new Column of Radio Buttons
            'TopTypeOfTrademark = 15  '8 '10 '20  '1

            'rdoTitleTypeOfTMOfficialActions = "9. Official Action Type"
            '.grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMOfficialActions = "10. Official Action Type"
            '.grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMOfficialActions = "11. Official Action Type"
            '.grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMOfficialActions = "12. Official Action Type"
            '.grpTypeOfActionReceived.Controls.Add(rdoArrayTypeOfTMOfficeActions.AddNewRadioButton(rdoTitleTypeOfTMOfficialActions, LeftTypeOfTrademark, TopTypeOfTrademark))

            .grpTypeOfActionReceived.Enabled = False

            .grpTypeOfTimeGivenForAResponse.Font = RKLFont12BI
            .grpTypeOfTimeGivenForAResponse.Text = "Click on the Type of Time Given for a Response to the Last Action:"

            aRadioButtonCount = 0
            rdoArrayTypeOfTimeGivenForAResponse = New RadioButtonArray(Me) '<== Me refers to this Form

            GroupInDocumentInputTabs = "grpTypeOfTimeGivenForAResponse"

            LeftTypeOfTrademark = 80 '150  '20
            TopTypeOfTrademark = 16  '9 '10 '20  '5  '1

            rdoTitleTypeOfTimeGivenForAResponse = "Days"
            .grpTypeOfTimeGivenForAResponse.Controls.Add(rdoArrayTypeOfTimeGivenForAResponse.AddNewRadioButton(rdoTitleTypeOfTimeGivenForAResponse, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 170 '150  '20
            TopTypeOfTrademark = 16  '9 '10 '20  '5  '1
            rdoTitleTypeOfTimeGivenForAResponse = "Weeks"
            .grpTypeOfTimeGivenForAResponse.Controls.Add(rdoArrayTypeOfTimeGivenForAResponse.AddNewRadioButton(rdoTitleTypeOfTimeGivenForAResponse, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 270 '150  '20
            TopTypeOfTrademark = 16  '9 '10 '20  '5  '1

            rdoTitleTypeOfTimeGivenForAResponse = "Months"
            .grpTypeOfTimeGivenForAResponse.Controls.Add(rdoArrayTypeOfTimeGivenForAResponse.AddNewRadioButton(rdoTitleTypeOfTimeGivenForAResponse, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 455 '150  '20
            TopTypeOfTrademark = 34  '26 '10 '20  '5  '1

            rdoTitleTypeOfTimeGivenForAResponse = "Response to be Made on a Particular Date:"
            .grpTypeOfTimeGivenForAResponse.Controls.Add(rdoArrayTypeOfTimeGivenForAResponse.AddNewRadioButton(rdoTitleTypeOfTimeGivenForAResponse, LeftTypeOfTrademark, TopTypeOfTrademark))
            .mtbResponseToBeOnAParticularDate.Font = RKLFont12B

            LeftTypeOfTrademark = 945 '150  '20
            TopTypeOfTrademark = 34   '26 '10 '20  '5  '1

            rdoTitleTypeOfTimeGivenForAResponse = "No Response Necessary"
            .grpTypeOfTimeGivenForAResponse.Controls.Add(rdoArrayTypeOfTimeGivenForAResponse.AddNewRadioButton(rdoTitleTypeOfTimeGivenForAResponse, LeftTypeOfTrademark, TopTypeOfTrademark))
            .grpTypeOfTimeGivenForAResponse.Enabled = False

            .grpNumberOfTimeToRespond.Text = ""
            .lblNumberOfTimeToRespond.Font = RKLFont12BI
            .lblNumberOfTimeToRespond.Text = "Enter Number of Time to Respond:"
            .txtNumberOfTimeToRespond.Font = RKLFont12B
            .txtNumberOfTimeToRespond.Text = ""
            .btnDoneNumberOfTimeToRespond.Font = RKLFont11BI
            .btnDoneNumberOfTimeToRespond.Text = "Done"
            .grpNumberOfTimeToRespond.Enabled = False

            .lblThereIsNoResponseNecessaryForThisAction.Visible = False

            .grpResponseDueDate.Text = ""
            .lblResponseDueDate.Font = RKLFont12B
            .lblResponseDueDate.Text = "The Response Due Date is:"
            .txtResponseDueDate.Font = RKLFont12B
            .txtResponseDueDate.Text = ""
            .lblIsResponseDueDateCorrect.Font = RKLFont12BI
            .lblIsResponseDueDateCorrect.Text = "Is this correct?"
            ''rdoArrayYesOrNo = New RadioButtonArray(Me)
            rdoArrayYesOrNoIsThisCorrect = New RadioButtonArray(Me)
            .grpResponseDueDate.Controls.Add(rdoArrayYesOrNoIsThisCorrect.AddNewRadioButton("Yes", 550, 14))
            .grpResponseDueDate.Controls.Add(rdoArrayYesOrNoIsThisCorrect.AddNewRadioButton("No", 530, 14))
            .grpResponseDueDate.Enabled = False

            .grpWasAResponsedFiled.Text = ""
            .lblWasAResponsedFiled.Font = RKLFont12BI
            .lblWasAResponsedFiled.Text = "Was a Response Filed at the Patent Office?"
            ''rdoArrayYesOrNo = New RadioButtonArray(Me)
            rdoArrayYesOrNoWasAResponseFiled = New RadioButtonArray(Me)
            .grpWasAResponsedFiled.Controls.Add(rdoArrayYesOrNoWasAResponseFiled.AddNewRadioButton("Yes", 340, 14))
            .grpWasAResponsedFiled.Controls.Add(rdoArrayYesOrNoWasAResponseFiled.AddNewRadioButton("No", 320, 14))

            .grpWasAResponsedFiled.Enabled = False

            .grpTypeOfResponseMade.Font = RKLFont12BI
            .grpTypeOfResponseMade.Text = "Click on the Type of Response that was Made to the Patent Office Action:"
            aRadioButtonCount = 0
            rdoArrayTypeOfTMResponseMade = New RadioButtonArray(Me) '<== Me refers to this Form

            GroupInDocumentInputTabs = "grpTypeOfResponseMade"

            LeftTypeOfTrademark = 20 '150  '20
            TopTypeOfTrademark = 25 '20  '5  '1

            rdoTitleTypeOfTMResponseMade = "1. Response to Non-Final Action"
            .grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMResponseMade = "2. Response to Final Action"
            .grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTMResponseMade = "3. Appeal to TTAB"
            .grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "4. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 350 '530  '500 represents the start of a new Column of Radio Buttons
            'TopTypeOfTrademark = 25 '20  '1

            'rdoTitleTypeOfTMResponseMade = "5. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "6. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "7. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "8. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'LeftTypeOfTrademark = 690 '870  '500 represents the start of a new Column of Radio Buttons
            'TopTypeOfTrademark = 25 '20  '1

            'rdoTitleTypeOfTMResponseMade = "9. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "10. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "11. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            'rdoTitleTypeOfTMResponseMade = "12. Response Made Type"
            '.grpTypeOfResponseMade.Controls.Add(rdoArrayTypeOfTMResponseMade.AddNewRadioButton(rdoTitleTypeOfTMResponseMade, LeftTypeOfTrademark, TopTypeOfTrademark))

            .grpTypeOfResponseMade.Enabled = False

            .grpResponseMadeDate.Text = ""
            .lblResponseMadeDate.Font = RKLFont12BI
            .lblResponseMadeDate.Text = "Enter the Action Response Made on Date:"
            .mtbResponseMadeDate.Font = RKLFont12B
            .mtbResponseMadeDate.Text = ""
            .btnDoneResponseMadeDate.Font = RKLFont11BI
            .btnDoneResponseMadeDate.Text = "Done"

            .btnResetThisActionAndResponse.Font = RKLFont12BI
            .btnResetThisActionAndResponse.Text = "Reset This Action and Response"
            '^^^End of Tab for Official Actions and Responses Setup^^^^^^^^^^^^^^^^

            'Setup the Tab for State Registrations
            .tabTrademarkDocument.TabPages(2).BackColor = clrLighestOrange

            .grpAreThereAnyStateRegistrations.Text = ""
            .grpAreThereAnyStateRegistrations.BackColor = clrOrange

            .lblAreThereAnyStateRegistrations.Font = RKLFont14B
            .lblAreThereAnyStateRegistrations.Text = "Have you Applied for or Registered this Mark in any States?"
            .lblAreThereAnyStateRegistrations.BackColor = clrOrange
            .lblAreThereAnyStateRegistrations.Left = 30

            rdoArrayYesOrNo = New RadioButtonArray(Me)
            .grpAreThereAnyStateRegistrations.Controls.Add(rdoArrayYesOrNo.AddNewRadioButton("Yes", 605, 7))
            .grpAreThereAnyStateRegistrations.Controls.Add(rdoArrayYesOrNo.AddNewRadioButton("No", 595, 7))

            'Now add the Checkboxes and State Names
            .grpStateNames.Font = RKLFont14BI
            .grpStateNames.Text = "Click on the Box for EACH State where the Mark is Registered:"
            .grpStateNames.Enabled = False

            'Set up the Statenames and their Abbeviations
            Call AssignStateNamesToAnArray()
            chkControlArrayForSelectingStates = New CheckBoxArray(Me)
            LeftColBase = 80
            '1st Column of State Names           
            chkTop = 0
            SpaceFactor = 20
            For StateNumber = 1 To 10
                StateName = arrStateNames(StateNumber, 1) & ", " & arrStateNames(StateNumber, 2)
                chkLeft = LeftColBase
                chkTop = chkTop + SpaceFactor  '20
                SpaceFactor = 28
                .grpStateNames.Controls.Add(chkControlArrayForSelectingStates.AddNewCheckBox(StateName, chkLeft, chkTop))
            Next StateNumber
            '2nd Column of State Names
            chkTop = 0
            SpaceFactor = 20
            For StateNumber = 11 To 20
                StateName = arrStateNames(StateNumber, 1) & ", " & arrStateNames(StateNumber, 2)
                chkLeft = LeftColBase + 210
                chkTop = chkTop + SpaceFactor  '20
                SpaceFactor = 28
                .grpStateNames.Controls.Add(chkControlArrayForSelectingStates.AddNewCheckBox(StateName, chkLeft, chkTop))
            Next StateNumber
            '3rd Column of State Names
            chkTop = 0
            SpaceFactor = 20
            For StateNumber = 21 To 30
                StateName = arrStateNames(StateNumber, 1) & ", " & arrStateNames(StateNumber, 2)
                chkLeft = LeftColBase + 420
                chkTop = chkTop + SpaceFactor  '20
                SpaceFactor = 28
                .grpStateNames.Controls.Add(chkControlArrayForSelectingStates.AddNewCheckBox(StateName, chkLeft, chkTop))
            Next StateNumber
            '4th Column of State Names
            chkTop = 0
            SpaceFactor = 20
            For StateNumber = 31 To 40
                StateName = arrStateNames(StateNumber, 1) & ", " & arrStateNames(StateNumber, 2)
                chkLeft = LeftColBase + 630
                chkTop = chkTop + SpaceFactor  '20
                SpaceFactor = 28
                .grpStateNames.Controls.Add(chkControlArrayForSelectingStates.AddNewCheckBox(StateName, chkLeft, chkTop))
            Next StateNumber
            '5th Column of State Names
            chkTop = 0
            SpaceFactor = 20
            For StateNumber = 41 To 50
                StateName = arrStateNames(StateNumber, 1) & ", " & arrStateNames(StateNumber, 2)
                chkLeft = LeftColBase + 840
                chkTop = chkTop + SpaceFactor  '20
                SpaceFactor = 28
                .grpStateNames.Controls.Add(chkControlArrayForSelectingStates.AddNewCheckBox(StateName, chkLeft, chkTop))
            Next StateNumber
            'Now Disable all of the StateName Checkboxes
            'For I = 0 To 49
            '    chkControlArrayForSelectingStates.chkItem(I).Enabled = False
            'Next I

            'Set the Buttons for the State Names
            .btnDoneStateNames.Font = RKLFont14BI
            .btnDoneStateNames.Text = "Done Selecting States"
            .btnDoneStateNames.Enabled = False
            .btnResetStateNames.Font = RKLFont14BI
            .btnResetStateNames.Text = "Reset"
            .btnResetStateNames.Enabled = False

            'Setup the Form's Buttons
            .btnDoneOKToSave.Font = RKLFont12BI
            .btnDoneOKToSave.Text = "Done - OK to Save"
            .btnDoneOKToSave.Enabled = False

            .btnCancel.Font = RKLFont12BI
            .btnCancel.Text = "Cancel"

        End With
    End Sub

    Private Sub btnResetStateNames_Click(sender As Object, e As EventArgs) Handles btnResetStateNames.Click
        With Me
            'Clear the Check Boxes
            For I = 0 To 49
                chkControlArrayForSelectingStates.chkItem(I).Checked = False
            Next I
            'Reset the State Name Group Box
            .grpStateNames.BackColor = clrLightestGray
            .grpStateNames.Enabled = False

            'Reset the question
            For I = 0 To 1
                rdoArrayYesOrNo.rdoItem(I).Checked = False
            Next I
            .grpAreThereAnyStateRegistrations.BackColor = clrOrange
            .lblAreThereAnyStateRegistrations.BackColor = clrOrange

            'Reset the Buttons
            .btnDoneStateNames.Enabled = False
            .btnResetStateNames.Enabled = False

        End With
    End Sub

    Private Sub btnDoneStateNames_Click(sender As Object, e As EventArgs) Handles btnDoneStateNames.Click
        Dim tempStateName As String
        Dim lentempStateName As Integer
        Dim tempStateAbbreviation As String

        StateRegistrationsOfMark = ""

        With Me
            'Loop through each State-chkBox to see if it has been Checked
            ' If it has been checked, then:
            '   1. Hold it's text/caption
            '   2. Seperate and hold the Abreviation
            '   3. Add the Abbrev to the DB-Data-Field
            For I = 0 To 49
                If chkControlArrayForSelectingStates.chkItem(I).Checked = True Then
                    '1. Hold it's text/caption
                    tempStateName = chkControlArrayForSelectingStates.chkItem(I).Text
                    '2. Seperate and hold the Abreviation
                    lentempStateName = tempStateName.Length
                    tempStateAbbreviation = Mid(tempStateName, lentempStateName - 1)
                    '3. Add the Abbrev to the DB-Data-Field
                    If StateRegistrationsOfMark.Length > 0 Then
                        StateRegistrationsOfMark = StateRegistrationsOfMark & ", " & tempStateAbbreviation
                    Else
                        StateRegistrationsOfMark = tempStateAbbreviation
                    End If
                End If
            Next I
            ''''''.tabTrademarkDocument.SelectedIndex = 1
            .btnDoneOKToSave.Enabled = True
            .btnDoneOKToSave.BackColor = clrOrange
        End With

    End Sub

    Private Sub btnDoneOKToSave_Click(sender As Object, e As EventArgs) Handles btnDoneOKToSave.Click
        With Me
            Call WriteNewTrademarkDocumentInputToRKLTrademarkTable()

            Call msgSavedTrademarkDocument()

            CurrentFormName = "frmMainMenu2"

            .Close()
        End With
    End Sub

    Private Sub txtEnterTMRegNum_TextChanged(sender As Object, e As EventArgs)
        'With Me
        '    If Len(.txtEnterTMRegNum.Text) > 0 Then
        '        .txtEnterTMRegNum.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
        '        .btnDoneEnterTMRegNum.Enabled = True
        '        .AcceptButton = .btnDoneEnterTMRegNum
        '    Else
        '        .txtEnterTMRegNum.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
        '        .btnDoneEnterTMRegNum.Enabled = False
        '    End If

        'End With
    End Sub

    Private Sub btnDoneEnterTMRegNum_Click(sender As Object, e As EventArgs)
        'With Me
        '    RegistrationNumber = Trim(.txtEnterTMRegNum.Text)
        '    .txtTMRegistrationNum.Text = RegistrationNumber
        '    .grpEnterTMRegNum.BackColor = clrLighestOrange
        '    .lblEnterTMRegNum.BackColor = clrLighestOrange

        '    .grpEnterTMRegDate.Enabled = True
        '    .grpEnterTMRegDate.BackColor = clrOrange
        '    .lblEnterTMRegDate.Enabled = True
        '    .mtbEnterTMRegDate.Enabled = True
        '    .mtbEnterTMRegDate.Focus()
        'End With
    End Sub

    Private Sub mtbEnterTMRegDate_TextChanged(sender As Object, e As EventArgs)
        'Dim DateToBeChecked As String
        'Dim IsBadDate As Boolean
        'Dim Start As Integer
        'Dim Length As Integer
        'Dim tempDate As String

        'With Me
        '    Start = .mtbEnterTMRegDate.SelectionStart
        '    Length = .mtbEnterTMRegDate.SelectionLength
        '    .mtbEnterTMRegDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        '    If Len(Trim(.mtbEnterTMRegDate.Text)) > 0 Then
        '        .mtbEnterTMRegDate.Mask = "00/00/0000"
        '        .mtbEnterTMRegDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
        '        'Now check for a valid date
        '        DateToBeChecked = .mtbEnterTMRegDate.Text
        '        Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
        '        If IsBadDate = True Then
        '            .mtbEnterTMRegDate.SelectionStart = Start
        '            .mtbEnterTMRegDate.SelectionLength = Length
        '        End If
        '        If Len(Trim(.mtbEnterTMRegDate.Text)) = 8 Then
        '            tempDate = AddSlashesToStringDate(.mtbEnterTMRegDate.Text)
        '            RegistrationIssueDate = ConvertToRKLDate(tempDate)
        '            .txtTMRegistrationDate.Text = tempDate
        '            .mtbEnterTMRegDate.Mask = "00/00/0000"
        '            .grpEnterTMRegDate.BackColor = clrLighestOrange
        '            .lblEnterTMRegDate.BackColor = clrLighestOrange

        '            .grpTMSerNumDate.Enabled = True
        '            .grpTMSerNumDate.BackColor = clrLighestOrange

        '            .grpEnterTMSerNum.Enabled = True
        '            .grpEnterTMSerNum.BackColor = clrOrange
        '            .lblEnterTMSerNum.Enabled = True
        '            .lblEnterTMSerNum.BackColor = clrOrange
        '            .txtEnterTMSerNum.Enabled = True
        '            .txtEnterTMSerNum.Focus()
        '        End If
        '    Else
        '        .mtbEnterTMRegDate.BackColor = clrLemmonChiffon
        '    End If
        'End With
    End Sub

    Private Sub txtEnterTMSerNum_TextChanged(sender As Object, e As EventArgs) Handles txtEnterTMSerNum.TextChanged
        With Me
            If Len(.txtEnterTMSerNum.Text) > 0 Then
                .txtEnterTMSerNum.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
                .btnDoneEnterTMSerNum.Enabled = True
                .AcceptButton = .btnDoneEnterTMSerNum
            Else
                .txtEnterTMSerNum.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                .btnDoneEnterTMSerNum.Enabled = False
            End If

        End With
    End Sub

    Private Sub btnDoneEnterTMSerNum_Click(sender As Object, e As EventArgs) Handles btnDoneEnterTMSerNum.Click
        With Me
            ApplicationSerialNumber = Trim(.txtEnterTMSerNum.Text)
            .txtTMSerialNum.Text = ApplicationSerialNumber
            .grpEnterTMSerNum.BackColor = clrLighestOrange
            .lblEnterTMSerNum.BackColor = clrLighestOrange

            .grpEnterTMSerDate.Enabled = True
            .grpEnterTMSerDate.BackColor = clrOrange
            .lblEnterTMSerDate.Enabled = True
            .lblEnterTMSerDate.BackColor = clrOrange
            .mtbEnterTMSerDate.Enabled = True
            .mtbEnterTMSerDate.Focus()
        End With
    End Sub

    Private Sub mtbEnterTMSerDate_TextChanged(sender As Object, e As EventArgs) Handles mtbEnterTMSerDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer
        Dim tempDate As String

        With Me
            Start = .mtbEnterTMSerDate.SelectionStart
            Length = .mtbEnterTMSerDate.SelectionLength
            .mtbEnterTMSerDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.mtbEnterTMSerDate.Text)) > 0 Then

                .mtbEnterTMSerDate.Mask = "00/00/0000"
                .mtbEnterTMSerDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .mtbEnterTMSerDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .mtbEnterTMSerDate.SelectionStart = Start
                    .mtbEnterTMSerDate.SelectionLength = Length
                End If
                If Len(Trim(.mtbEnterTMSerDate.Text)) = 8 Then
                    tempDate = AddSlashesToStringDate(.mtbEnterTMSerDate.Text)
                    ApplicationFilingDate = ConvertToRKLDate(tempDate)
                    .txtTMApplicationFilinglDate.Text = tempDate
                    .mtbEnterTMSerDate.Mask = "00/00/0000"
                    .grpEnterTMSerDate.BackColor = clrLighestOrange
                    .lblEnterTMSerDate.BackColor = clrLighestOrange

                    .grpTMSerNumDate.Enabled = True
                    .grpTMSerNumDate.BackColor = clrLighestOrange

                    '.tabOfficialActionsAndResponses.Enabled = True
                    '.tabTrademarkDocument.SelectedTab = tabOfficialActionsAndResponses

                    .btnDoneEnteringTMRegAndSer.Enabled = True
                    .AcceptButton = btnDoneEnteringTMRegAndSer
                End If
            Else
                .mtbEnterTMSerDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtTMRegistrationDate_TextChanged(sender As Object, e As EventArgs) Handles txtTMRegistrationDate.TextChanged
        With Me
            If Len(.txtTMRegistrationDate.Text) > 0 Then
                .txtTMRegistrationDate.BackColor = clrSpringGreen
            Else
                .txtTMRegistrationDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtTMApplicationFilinglDate_TextChanged(sender As Object, e As EventArgs) Handles txtTMApplicationFilinglDate.TextChanged
        With Me
            If Len(.txtTMApplicationFilinglDate.Text) > 0 Then
                .txtTMApplicationFilinglDate.BackColor = clrSpringGreen
            Else
                .txtTMApplicationFilinglDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtTMRegistrationNum_TextChanged(sender As Object, e As EventArgs) Handles txtTMRegistrationNum.TextChanged
        With Me
            If Len(.txtTMRegistrationNum.Text) > 0 Then
                .txtTMRegistrationNum.BackColor = clrSpringGreen
            Else
                .txtTMRegistrationNum.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtTMSerialNum_TextChanged(sender As Object, e As EventArgs) Handles txtTMSerialNum.TextChanged
        With Me
            If Len(.txtTMSerialNum.Text) > 0 Then
                .txtTMSerialNum.BackColor = clrSpringGreen
            Else
                .txtTMSerialNum.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub btnDoneEnteringTMRegAndSer_Click(sender As Object, e As EventArgs) Handles btnDoneEnteringTMRegAndSer.Click
        With Me
            .tabOfficialActionsAndResponses.Enabled = True
            GroupInDocumentInputTabs = "grpHaveThereBeenAnyOfficialActions"
            .tabTrademarkDocument.SelectedTab = tabOfficialActionsAndResponses
        End With
    End Sub

    Private Sub mtbEnterPatentOfficeMailingDate_TextChanged(sender As Object, e As EventArgs) Handles mtbEnterPatentOfficeMailingDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer

        Dim tempPatentOfficeActionMailingDate As String
        Dim PatentOfficeActionMailingDate As Long
        ''Dim DayNumber As Integer
        ''Dim MonthNumber As Integer
        ''Dim YearNumber As Long


        With Me
            Start = .mtbEnterPatentOfficeMailingDate.SelectionStart
            Length = .mtbEnterPatentOfficeMailingDate.SelectionLength
            .mtbEnterPatentOfficeMailingDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.mtbEnterPatentOfficeMailingDate.Text)) > 0 Then
                .mtbEnterPatentOfficeMailingDate.Mask = "00/00/0000"
                .mtbEnterPatentOfficeMailingDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .mtbEnterPatentOfficeMailingDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .mtbEnterPatentOfficeMailingDate.SelectionStart = Start
                    .mtbEnterPatentOfficeMailingDate.SelectionLength = Length
                End If
                If Len(Trim(.mtbEnterPatentOfficeMailingDate.Text)) = 8 Then
                    .mtbEnterPatentOfficeMailingDate.Mask = "00/00/0000"
                    .grpEnterPatentOfficeMailingDate.BackColor = clrLighestOrange
                    .lblEnterPatentOfficeMailingDate.BackColor = clrLighestOrange

                    'Capture the  Date for the Current Action Sequence
                    .lblThereIsNoResponseNecessaryForThisAction.Visible = False
                    '.grpActionDate.Visible = True
                    '.grpActionDate.Enabled = True
                    '.txtActionDate.Enabled = True
                    '.txtActionDate.Text = .mtbEnterPatentOfficeMailingDate.Text
                    'tempPatentOfficeActionMailingDate = Trim$(.mtbEnterPatentOfficeMailingDate.Text)
                    tempPatentOfficeActionMailingDate = AddSlashesToStringDate(.mtbEnterPatentOfficeMailingDate.Text)
                    PatentOfficeActionMailingDate = ConvertToRKLDate(tempPatentOfficeActionMailingDate)
                    '     SystemDateFormat = CDate(tempPatentOfficeActionMailingDate)
                    '     Call SeperateDateIntoDateParts(SystemDateFormat, DayNumber, MonthNumber, YearNumber)
                    '.grpActionDate.BackColor = clrSpringGreen '&HC0FFC0 'Light Green


                    If Not NowInDisplayModeForOfficialActions Then
                        SequenceNumberToUse = SequenceOfPatentOfficeAction
                    Else
                        SequenceNumberToUse = SelectedSequenceOfPatentOfficeAction
                    End If

                    Select Case SequenceNumberToUse   'SequenceOfPatentOfficeAction
                        Case 1
                            FirstUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "First " & .grpActionDate.Text
                        Case 2
                            SecondUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Second " & .grpActionDate.Text
                        Case 3
                            ThirdUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Third " & .grpActionDate.Text
                        Case 4
                            FourthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Fourth " & .grpActionDate.Text
                        Case 5
                            FifthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Fifth " & .grpActionDate.Text
                        Case 6
                            SixthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Sixth " & .grpActionDate.Text
                        Case 7
                            SeventhUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Seventh " & .grpActionDate.Text
                        Case 8
                            EighthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Eighth " & .grpActionDate.Text
                        Case 9
                            NinthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Ninth " & .grpActionDate.Text
                        Case 10
                            TenthUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Tenth " & .grpActionDate.Text
                        Case 11
                            EleventhUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Eleventh " & .grpActionDate.Text
                        Case 12
                            TwelvethUSPTOActionMailingDate = PatentOfficeActionMailingDate
                            '.grpActionDate.Text = "Twelveth " & .grpActionDate.Text
                    End Select


                    .grpTypeOfActionReceived.Enabled = True
                    .grpTypeOfActionReceived.BackColor = clrOrange
                    For I = 0 To 7  '11
                        rdoArrayTypeOfTMOfficeActions.rdoItem(I).Enabled = True
                        rdoArrayTypeOfTMOfficeActions.rdoItem(I).BackColor = clrOrange
                    Next
                    GroupInDocumentInputTabs = "grpTypeOfActionReceived"
                End If
            Else
                .mtbEnterPatentOfficeMailingDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtNumberOfTimeToRespond_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfTimeToRespond.TextChanged
        Dim tempCheckedText As String
        Dim BackColorValue As Color
        With Me
            If (Val(.txtNumberOfTimeToRespond.Text) > 0) Or (txtNumberOfTimeToRespond.Text.Length > 0) Then
                'Check to see if a number was entered
                Call CheckTextForNumber(.txtNumberOfTimeToRespond.Text, tempCheckedText, BackColorValue)
                .txtNumberOfTimeToRespond.Text = tempCheckedText
                .txtNumberOfTimeToRespond.BackColor = clrSpringGreen '&HC0FFC0 'Light Green
                .txtNumberOfTimeToRespond.SelectionStart = Len(tempCheckedText) + 1
                If Val(.txtNumberOfTimeToRespond.Text) > 0 Then
                    .txtNumberOfTimeToRespond.Focus()
                End If
                .btnDoneNumberOfTimeToRespond.Enabled = True
                '.cmdDoneNumberOfTimesResponseGivenIn.Caption = " Done "
                .AcceptButton = btnDoneNumberOfTimeToRespond
                If Len(.txtNumberOfTimeToRespond.Text) > 3 Then
                    'Send msg - No more than 3 characters allowed
                    Call msgThisFieldCantBeLongerThan(3)
                    .txtNumberOfTimeToRespond.Text = Microsoft.VisualBasic.Left(.txtNumberOfTimeToRespond.Text, 3)
                    .txtNumberOfTimeToRespond.SelectionStart = .txtNumberOfTimeToRespond.Text.Length + 1
                End If
            Else
                .txtNumberOfTimeToRespond.BackColor = clrLemmonChiffon  '&HC0FFFF 'Yellow
            End If
        End With
    End Sub

    Private Sub btnDoneNumberOfTimeToRespond_Click(sender As Object, e As EventArgs) Handles btnDoneNumberOfTimeToRespond.Click
        'This Sub is used only when Type of Time Periods SELECTED is Days, Months, or Years
        Dim DayNumber As Integer
        Dim MonthNumber As Integer
        Dim YearNumber As Long
        Dim DaysInAMonth As Integer
        Dim B As Double
        Dim C As Integer
        Dim DayCounter As Integer
        Dim MonthCounter As Integer
        Dim YearCounter As Long
        Dim tempPatentOfficeActionMailingDate As String
        Dim tempNumberOfTimePeriodsToRespond As Integer  '<===Was SUMF in Sub Response
        Dim tempPeriodTypeCounter As Integer  '<===Was SUM in Sub Response
        Dim tempUSPTOActionResponseDueDate As Date
        Dim SystemDateFormat As Date

        If Not NowInDisplayModeForOfficialActions Then
            SequenceNumberToUse = SequenceOfPatentOfficeAction
        Else
            SequenceNumberToUse = SelectedSequenceOfPatentOfficeAction
        End If

        With Me
            Select Case SequenceNumberToUse   'SequenceOfPatentOfficeAction
                Case 1
                    FirstTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(FirstUSPTOActionMailingDate, "MonthNumber")
                Case 2
                    SecondTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(SecondUSPTOActionMailingDate, "MonthNumber")
                Case 3
                    ThirdTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(ThirdUSPTOActionMailingDate, "MonthNumber")
                Case 4
                    FourthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(FourthUSPTOActionMailingDate, "MonthNumber")
                Case 5
                    FifthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(FifthUSPTOActionMailingDate, "MonthNumber")
                Case 6
                    SixthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(SixthUSPTOActionMailingDate, "MonthNumber")
                Case 7
                    SeventhTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(SeventhUSPTOActionMailingDate, "MonthNumber")
                Case 8
                    EighthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(EighthUSPTOActionMailingDate, "MonthNumber")
                Case 9
                    NinthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(NinthUSPTOActionMailingDate, "MonthNumber")
                Case 10
                    TenthTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(TenthUSPTOActionMailingDate, "MonthNumber")
                Case 11
                    EleventhTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(EleventhUSPTOActionMailingDate, "MonthNumber")
                Case 12
                    TwelvethTimeToRespond = Trim$(.txtNumberOfTimeToRespond.Text)
                    tempPatentOfficeActionMailingDate = ConvertFromRKLDate(TwelvethUSPTOActionMailingDate, "MonthNumber")
            End Select

            'SystemDateFormat = CDate(tempPatentOfficeActionMailingDate)
            SystemDateFormat = Convert.ToDateTime(tempPatentOfficeActionMailingDate)
            '     Call SeperateDateIntoDateParts(SystemDateFormat, DayNumber, MonthNumber, YearNumber)

            tempNumberOfTimePeriodsToRespond = CLng(Trim$(.txtNumberOfTimeToRespond.Text))

            tempUSPTOActionResponseDueDate = GetTheResponseDueDate(TypeOfTimePeriodToRespond, tempNumberOfTimePeriodsToRespond, SystemDateFormat)

            USPTOActionResponseDueDate = ConvertToRKLDate(tempUSPTOActionResponseDueDate)

            .grpNumberOfTimeToRespond.BackColor = clrLighestOrange '&HC0E0FF  'Lightest Orange
            .lblNumberOfTimeToRespond.BackColor = clrLighestOrange '&HC0E0FF  'Lightest Orange

            For I = 0 To 4
                rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).BackColor = clrLighestOrange
            Next

            Call CaptureAndDisplayUSPTOActionDueDate()

            GroupInDocumentInputTabs = "grpResponseDueDate"
        End With

    End Sub

    Private Sub mtbResponseToBeOnAParticularDate_TextChanged(sender As Object, e As EventArgs) Handles mtbResponseToBeOnAParticularDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer

        Dim tempDate As String

        'Dim tempPatentOfficeActionMailingDate As String
        'Dim PatentOfficeActionMailingDate As Long
        'Dim DayNumber As Integer
        'Dim MonthNumber As Integer
        'Dim YearNumber As Long

        With Me
            Start = .mtbResponseToBeOnAParticularDate.SelectionStart
            Length = .mtbResponseToBeOnAParticularDate.SelectionLength
            .mtbResponseToBeOnAParticularDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.mtbResponseToBeOnAParticularDate.Text)) > 0 Then
                .mtbResponseToBeOnAParticularDate.Mask = "00/00/0000"
                .mtbResponseToBeOnAParticularDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .mtbResponseToBeOnAParticularDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .mtbResponseToBeOnAParticularDate.SelectionStart = Start
                    .mtbResponseToBeOnAParticularDate.SelectionLength = Length
                    Exit Sub
                End If
                If Len(Trim(.mtbResponseToBeOnAParticularDate.Text)) = 8 Then
                    tempDate = AddSlashesToStringDate(.mtbResponseToBeOnAParticularDate.Text)
                    USPTOActionResponseDueDate = ConvertToRKLDate(tempDate)
                    .mtbResponseToBeOnAParticularDate.Mask = "00/00/0000"
                    .grpTypeOfTimeGivenForAResponse.BackColor = clrLighestOrange
                    .lblOR1.BackColor = clrLighestOrange
                    .lblOR2.BackColor = clrLighestOrange

                    .grpResponseDueDate.Enabled = True
                    .grpResponseDueDate.BackColor = clrOrange
                    .lblResponseDueDate.Enabled = True
                    .lblResponseDueDate.BackColor = clrOrange
                    .lblIsResponseDueDateCorrect.BackColor = clrOrange

                    Call CaptureAndDisplayUSPTOActionDueDate()

                    GroupInDocumentInputTabs = "grpResponseDueDate"
                End If
            Else
                .mtbResponseToBeOnAParticularDate.BackColor = clrLemmonChiffon
            End If


        End With
    End Sub

    Private Sub mtbResponseMadeDate_TextChanged(sender As Object, e As EventArgs) Handles mtbResponseMadeDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer

        Dim tempResponseMadeDate As String
        Dim ResponseMadeDate As Long
        'Dim DayNumber As Integer
        'Dim MonthNumber As Integer
        'Dim YearNumber As Long


        With Me
            Start = .mtbResponseMadeDate.SelectionStart
            Length = .mtbResponseMadeDate.SelectionLength
            .mtbResponseMadeDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.mtbResponseMadeDate.Text)) > 0 Then
                .mtbResponseMadeDate.Mask = "00/00/0000"
                .mtbResponseMadeDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .mtbResponseMadeDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .mtbResponseMadeDate.SelectionStart = Start
                    .mtbResponseMadeDate.SelectionLength = Length
                End If
                If Len(Trim(.mtbResponseMadeDate.Text)) = 8 Then
                    .mtbResponseMadeDate.Mask = "00/00/0000"
                    .grpResponseMadeDate.BackColor = clrLighestOrange
                    .lblResponseMadeDate.BackColor = clrLighestOrange

                    tempResponseMadeDate = AddSlashesToStringDate(.mtbResponseMadeDate.Text)
                    ResponseMadeDate = ConvertToRKLDate(tempResponseMadeDate)

                    If Not NowInDisplayModeForOfficialActions Then
                        SequenceNumberToUse = SequenceOfPatentOfficeAction
                    Else
                        SequenceNumberToUse = SelectedSequenceOfPatentOfficeAction
                    End If

                    Select Case SequenceNumberToUse   'SequenceOfPatentOfficeAction
                        Case 1
                            FirstUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 2
                            SecondUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 3
                            ThirdUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 4
                            FourthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 5
                            FifthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 6
                            SixthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 7
                            SeventhUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 8
                            EighthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 9
                            NinthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 10
                            TenthUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 11
                            EleventhUSPTOActionResponseMadeDate = ResponseMadeDate
                        Case 12
                            TwelvethUSPTOActionResponseMadeDate = ResponseMadeDate
                    End Select
                    .btnDoneResponseMadeDate.Enabled = True
                    .btnDoneResponseMadeDate.BackColor = clrOrange
                    .btnResetThisActionAndResponse.Enabled = True
                End If
            Else
                .mtbResponseMadeDate.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub btnDoneResponseMadeDate_Click(sender As Object, e As EventArgs) Handles btnDoneResponseMadeDate.Click
        Dim tempNewActionMailingDate As Date
        Dim NewActionMailingDate As Long
        Dim NewTypeOfTMOfficeAction As String
        Dim tempNewReponseDueDate As Date
        Dim NewReponseDueDate As Long
        Dim tempNewResponseMadeDate As Date
        Dim NewResponseMadeDate As Long
        Dim tempDate As String
        Dim NewTypeOfPatentOfficeResponse As String

        If Not NowInDisplayModeForOfficialActions Then
            SequenceNumberToUse = SequenceOfPatentOfficeAction
        Else
            SequenceNumberToUse = SelectedSequenceOfPatentOfficeAction
        End If

        With Me
            'Now Capture each of the Values for Actions associated with the current SequenceNumberToUse
            tempDate = AddSlashesToStringDate(.mtbEnterPatentOfficeMailingDate.Text)
            tempNewActionMailingDate = Trim$(tempDate)
            NewActionMailingDate = ConvertToRKLDate(tempNewActionMailingDate)

            For I = 0 To 7
                If rdoArrayTypeOfTMOfficeActions.rdoItem(I).Checked = True Then
                    NewTypeOfTMOfficeAction = Strings.Mid(rdoArrayTypeOfTMOfficeActions.rdoItem(I).Text.ToString, 4)
                    Exit For
                End If
            Next

            tempNewReponseDueDate = Trim$(.txtResponseDueDate.Text)
            NewReponseDueDate = ConvertToRKLDate(tempNewReponseDueDate)

            For I = 0 To 2
                If rdoArrayTypeOfTMResponseMade.rdoItem(I).Checked = True Then
                    NewTypeOfPatentOfficeResponse = Strings.Mid(rdoArrayTypeOfTMResponseMade.rdoItem(I).Text.ToString, 4)
                    Exit For
                End If
            Next

            tempDate = AddSlashesToStringDate(.mtbResponseMadeDate.Text)
            tempNewResponseMadeDate = Trim$(tempDate)
            NewResponseMadeDate = ConvertToRKLDate(tempNewResponseMadeDate)

            Select Case SequenceNumberToUse   'SequenceOfPatentOfficeAction
                Case 1
                    FirstUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfFirstUSPTOAction = NewTypeOfTMOfficeAction
                    FirstUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfFirstPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    FirstUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 2
                    SecondUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfSecondUSPTOAction = NewTypeOfTMOfficeAction
                    SecondUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfSecondPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    SecondUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 3
                    ThirdUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfThirdUSPTOAction = NewTypeOfTMOfficeAction
                    ThirdUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfThirdPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    ThirdUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 4
                    FourthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfFourthUSPTOAction = NewTypeOfTMOfficeAction
                    FourthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfFourthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    FourthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 5
                    FifthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfFifthUSPTOAction = NewTypeOfTMOfficeAction
                    FifthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfFifthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    FifthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 6
                    SixthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfSixthUSPTOAction = NewTypeOfTMOfficeAction
                    SixthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfSixthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    SixthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 7
                    SeventhUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfSeventhUSPTOAction = NewTypeOfTMOfficeAction
                    SeventhUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfSeventhPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    SeventhUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 8
                    EighthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfEighthUSPTOAction = NewTypeOfTMOfficeAction
                    EighthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfEighthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    EighthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 9
                    NinthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfNinthUSPTOAction = NewTypeOfTMOfficeAction
                    NinthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfNinthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    NinthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 10
                    TenthUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfTenthUSPTOAction = NewTypeOfTMOfficeAction
                    TenthUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfTenthPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    TenthUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 11
                    EleventhUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfEleventhUSPTOAction = NewTypeOfTMOfficeAction
                    EleventhUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfEleventhPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    EleventhUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case 12
                    TwelvethUSPTOActionMailingDate = NewActionMailingDate
                    TypeOfTwelvethUSPTOAction = NewTypeOfTMOfficeAction
                    TwelvethUSPTOActionResponseDueDate = NewReponseDueDate
                    TypeOfTwelvethPatentOfficeResponse = NewTypeOfPatentOfficeResponse
                    TwelvethUSPTOActionResponseMadeDate = NewResponseMadeDate
                Case Is > 12
                    .tabTrademarkDocument.SelectedIndex = 2  'Goto State Registrations
            End Select

            '>>>>>>>>>>>>>>>The next Section needs a lot of work
            If Not NowInDisplayModeForOfficialActions Then
                SequenceOfPatentOfficeAction = SequenceOfPatentOfficeAction + 1
            End If

            If SequenceOfPatentOfficeAction > 12 Then   '6 Then

                'First Re-set this Office Actions Tab so it can be reviewed before this Patent Document Record is saved - Added 7/30/17
                '  Set this Tab so it displays the First Office Action - as the Default display
                '''''.fraAreThereAnyMoreOfficeActionsToBeEntered.Visible = False

                '''''.fraReviewEachOfficeAction(0).Visible = True
                '''''.fraReviewEachOfficeAction(0).Top = 285

                '''''              'Disable the Sequence Number of the OfficialAction Options that haven't been entered
                '''''               If SequenceOfPatentOfficeAction < 6 Then
                '''''                    For I = SequenceOfPatentOfficeAction To 5
                '''''                         .optReviewEachOfficeAction(I).Enabled = False
                '''''                    Next I
                '''''               End If

                NowInDisplayModeForOfficialActions = True

                'THE NEXT LINE TRIGGERS THE SETTING UP OF THE OFFICIAL ACTIONS TAB FOR REVIEWING
                '''''.optReviewEachOfficeAction(0).Value = True

                'If PatentDocumentCountryCode = "US" Then
                '    If (PatentType = "Utility Patent") Or (PatentType = "Reissue Utility Patent") Or (PatentType = "Re-Exam Utility Patent") Then
                '        If PatentApplicationFilingDate > 19801212 Then
                '            'If this is reached then calulate the Mainenence Fees and ask if any have been paid in the Next Tab
                '            Call CalculatePatentMaintenanceFeeDates
                '            .fraMaintenanceFeeData.Enabled = True
                '            .fraMaintenanceFeeData.BackColor = &HC0E0FF  'Lightest Orange
                '            .fraHaveAnyMaintenanceFeesBeenPaid.Enabled = True
                '            .fraHaveAnyMaintenanceFeesBeenPaid.BackColor = &H80C0FF 'Light Orange
                '            .lblHaveAnyMaintenanceFeesBeenPaid.Enabled = True
                '            .lblHaveAnyMaintenanceFeesBeenPaid.BackColor = &H80C0FF 'Light Orange
                '            .optHaveAnyMaintenanceFeesBeenPaid(0).Enabled = True
                '            .optHaveAnyMaintenanceFeesBeenPaid(0).BackColor = &H80C0FF 'Light Orange
                '            .optHaveAnyMaintenanceFeesBeenPaid(1).Enabled = True
                '            .optHaveAnyMaintenanceFeesBeenPaid(1).BackColor = &H80C0FF 'Light Orange
                '        Else
                '            .fraInventorsNames.Enabled = True
                '            .fraInventorsNames.BackColor = &HC0E0FF  'Lightest Orange
                '            .fraInventorName(0).Enabled = True
                '            .fraInventorName(0).BackColor = &H80C0FF 'Light Orange
                '            .chkInventorName(0).Enabled = True
                '            .chkInventorName(0).BackColor = &H80C0FF 'Light Orange
                '            .chkInventorName(0).Value = vbChecked
                '            .txtInventorName(0).SetFocus
                '        End If
                '    Else
                '        .fraInventorsNames.Enabled = True
                '        .fraInventorsNames.BackColor = &HC0E0FF  'Lightest Orange
                '        .fraInventorName(0).Enabled = True
                '        .fraInventorName(0).BackColor = &H80C0FF 'Light Orange
                '        .chkInventorName(0).Enabled = True
                '        .chkInventorName(0).BackColor = &H80C0FF 'Light Orange
                '        .chkInventorName(0).Value = vbChecked
                '        .txtInventorName(0).SetFocus
                '    End If
                'Else
                '    .fraInventorsNames.Enabled = True
                '    .fraInventorsNames.BackColor = &HC0E0FF  'Lightest Orange
                '    .fraInventorName(0).Enabled = True
                '    .fraInventorName(0).BackColor = &H80C0FF 'Light Orange
                '    .chkInventorName(0).Enabled = True
                '    .chkInventorName(0).BackColor = &H80C0FF 'Light Orange
                '    .chkInventorName(0).Value = vbChecked
                '    .txtInventorName(0).SetFocus
                'End If

                '.tabPatentDocument.TabEnabled(4) = True
                '.tabPatentDocument.Tab = 4
                .tabTrademarkDocument.SelectedTab = tabStateRegistrations
            Else
                '</Added by: Project Administrator at: 7/27/2017-10:05:09 on machine: MARV-PC>
                ''''''.fraNewResponseMadeDate.BackColor = &H8000000F  'ButtonFace
                ''''''.lblNewResponseMadeDate.BackColor = &H8000000F  'ButtonFace
                ''''''.txtNewResponseMadeDate.Mask = "##/##/####"

                'Call ShowFrameForAreThereAnyMoreActionsToBeEntered
            End If
            '.cmdResetActionEntries.Enabled = False


            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            With Me


                '.btnResetThisActionAndResponse.PerformClick()
                Call SetUpFreshActionAndResponseScreenForInput()

                'Now Change the Label for HaveThereBeenAnyOfficialActions
                .lblHaveThereBeenAnyOfficialActions.Text = "Are there any more Official Actions to be entered?"

                'Hide the Original Yes-No rdoButons
                For I = 0 To 1
                    .rdoArrayYesOrNoHaveThereBeenAnyOfficialActions.rdoItem(I).Visible = False
                Next

                'GroupInDocumentInputTabs = "AreThereAnyMoreOfficialActions"
                'Create two new Yes-No rdoButtons
                .rdoArrayYesOrNoAreThereAnyMoreOfficialActions = New RadioButtonArray(Me)
                .grpHaveThereBeenAnyOfficialActions.Controls.Add(.rdoArrayYesOrNoAreThereAnyMoreOfficialActions.AddNewRadioButton("Yes", 532, 14))
                .grpHaveThereBeenAnyOfficialActions.Controls.Add(.rdoArrayYesOrNoAreThereAnyMoreOfficialActions.AddNewRadioButton("No", 515, 14))
            End With
        End With
    End Sub

    Private Sub btnResetThisActionAndResponse_Click(sender As Object, e As EventArgs) Handles btnResetThisActionAndResponse.Click
        With Me
            '.fraOfficialActionsAndResponses.BackColor = &H8000000F  'ButtonFace
            .grpOfficialActionsAndResponses.BackColor = clrControl
            .grpHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            .lblHaveThereBeenAnyOfficialActions.BackColor = clrOrange
            For I = 0 To 1
                '.optHaveThereBeenAnyOfficialActionsFromThePatentOffice(I).BackColor = &H8000000F  'ButtonFace
                '.optHaveThereBeenAnyOfficialActionsFromThePatentOffice(I).Value = False
                ''rdoArrayYesOrNo.rdoItem(I).Checked = False
                rdoArrayYesOrNoHaveThereBeenAnyOfficialActions.rdoItem(I).Checked = False
            Next I

            'Now Disable the ActionMailingDate Controls
            '.txtPatentOfficeActionMailingDate.Mask = ""
            '.txtPatentOfficeActionMailingDate.Text = ""
            '.txtPatentOfficeActionMailingDate.Mask = "##/##/####"
            .mtbEnterPatentOfficeMailingDate.Text = ""
            .mtbEnterPatentOfficeMailingDate.Mask = "00/00/0000"
            '.fraPatentOfficeActionMailingDate.BackColor = &H8000000F  'ButtonFace
            .grpEnterPatentOfficeMailingDate.BackColor = clrControl
            '.fraPatentOfficeActionMailingDate.Enabled = False
            .grpEnterPatentOfficeMailingDate.Enabled = False
            '.lblPatentOfficeActionTypeAndMailingDate.BackColor = &H8000000F  'ButtonFace
            .lblEnterPatentOfficeMailingDate.BackColor = clrControl
            '.lblPatentOfficeActionTypeAndMailingDate.Enabled = False
            .lblEnterPatentOfficeMailingDate.Enabled = False
            '.txtPatentOfficeActionMailingDate.Enabled = False
            .mtbEnterPatentOfficeMailingDate.Enabled = False

            'Now Disable the Office Action Options
            For I = 0 To 7  '11
                '.optTypeOfPatentOfficialAction(I).Value = False
                rdoArrayTypeOfTMOfficeActions.rdoItem(I).Checked = False
                '.optTypeOfPatentOfficialAction(I).BackColor = &H8000000F  'ButtonFace
                rdoArrayTypeOfTMOfficeActions.rdoItem(I).BackColor = clrControl
                '.optTypeOfPatentOfficialAction(I).Enabled = False
                rdoArrayTypeOfTMOfficeActions.rdoItem(I).Enabled = False
            Next I
            '.fraTypeOfPatentOfficeAction.BackColor = &H8000000F  'ButtonFace
            .grpTypeOfActionReceived.BackColor = clrControl
            '.fraTypeOfPatentOfficeAction.Enabled = False
            .grpTypeOfActionReceived.Enabled = False



            '.fraTypeOfTimeGivenForResponse.BackColor = &H8000000F  'ButtonFace
            .grpTypeOfTimeGivenForAResponse.BackColor = clrControl
            '.fraTypeOfTimeGivenForResponse.Enabled = False
            .grpTypeOfTimeGivenForAResponse.Enabled = False
            '.fraResponseTimeGivenIn.BackColor = &H8000000F  'ButtonFace
            .grpNumberOfTimeToRespond.BackColor = clrControl
            '.fraResponseTimeGivenIn.Enabled = False
            .grpNumberOfTimeToRespond.Enabled = False
            '.lblEnterNumberOfTimeToRepond.BackColor = &H8000000F  'ButtonFace
            .lblNumberOfTimeToRespond.BackColor = clrControl
            '.lblEnterNumberOfTimeToRepond.Enabled = False
            .lblNumberOfTimeToRespond.Enabled = False
            '.txtEnterNumberOfTimeToRepond.Text = ""
            .txtNumberOfTimeToRespond.Text = ""
            '.cmdDoneNumberOfTimesResponseGivenIn.Enabled = False
            .btnDoneNumberOfTimeToRespond.Enabled = False
            .lblOR1.BackColor = clrControl '&H8000000F  'ButtonFace
            .lblOR1.Enabled = False
            .lblOR2.BackColor = clrControl  '&H8000000F  'ButtonFace
            .lblOR2.Enabled = False
            '.txtResponseToBeMadeOnAParticularDate.Mask = ""
            '.txtResponseToBeMadeOnAParticularDate.Text = ""
            .mtbResponseToBeOnAParticularDate.Text = ""
            '.txtResponseToBeMadeOnAParticularDate.Mask = "##/##/####"
            .mtbResponseToBeOnAParticularDate.Mask = "00/00/0000"

            For I = 0 To 4
                '.optResponseTimeGivenIn(I).Value = False
                rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Checked = False
                '.optResponseTimeGivenIn(I).BackColor = &H8000000F  'ButtonFace 
                rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).BackColor = clrControl
                '.optResponseTimeGivenIn(I).Enabled = False
                rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
            Next I

            '.fraTheResponseDueDateIs.BackColor = &H8000000F  'ButtonFace
            .grpResponseDueDate.BackColor = clrControl
            '.fraTheResponseDueDateIs.Enabled = False
            .grpResponseDueDate.Enabled = False
            '.lblTheResponseDueDateIs.BackColor = &H8000000F  'ButtonFace
            .lblResponseDueDate.BackColor = clrControl
            '.lblTheResponseDueDateIs.Enabled = False
            .lblResponseDueDate.Enabled = False
            '.txtTheResponseDueDateIs.Text = ""
            .txtResponseDueDate.Text = ""
            .txtResponseDueDate.BackColor = clrLemmonChiffon
            '.lblIsThisDueDateCorrect.BackColor = &H8000000F  'ButtonFace
            .lblIsResponseDueDateCorrect.BackColor = clrControl
            '.lblIsThisDueDateCorrect.Enabled = False
            .lblIsResponseDueDateCorrect.Enabled = False
            For I = 0 To 1
                '.optIsThisDueDateCorrect(I).BackColor = &H8000000F  'ButtonFace
                '.optIsThisDueDateCorrect(I).Value = False
                ''rdoArrayYesOrNo.rdoItem(I).Checked = False
                rdoArrayYesOrNoIsThisCorrect.rdoItem(I).Checked = False
                '.optIsThisDueDateCorrect(I).Enabled = False
                '.optWasAResponseFiledAtThePatentOffice(I).BackColor = &H8000000F  'ButtonFace
                '.optWasAResponseFiledAtThePatentOffice(I).Value = False
                '.optWasAResponseFiledAtThePatentOffice(I).Enabled = False
                rdoArrayYesOrNoWasAResponseFiled.rdoItem(I).Checked = False
            Next I
            '.fraWasAResponseFiledAtThePatentOffice.BackColor = &H8000000F  'ButtonFace
            .grpWasAResponsedFiled.BackColor = clrControl
            '.fraWasAResponseFiledAtThePatentOffice.Enabled = False
            .grpWasAResponsedFiled.Enabled = False
            '.lblWasAResponseFiledAtThePatentOffice.BackColor = &H8000000F  'ButtonFace
            .lblWasAResponsedFiled.BackColor = clrControl
            '.lblWasAResponseFiledAtThePatentOffice.Enabled = False
            .lblWasAResponsedFiled.Enabled = False

            'Now Disable the Response Made Controls
            For I = 0 To 11
                '.optTypeOfResponseToPatentOfficeAction(I).Value = False
                rdoArrayTypeOfTMResponseMade.rdoItem(I).Checked = False
                '.optTypeOfResponseToPatentOfficeAction(I).BackColor = &H8000000F  'ButtonFace
                '.optTypeOfResponseToPatentOfficeAction(I).Enabled = False
                rdoArrayTypeOfTMResponseMade.rdoItem(I).Enabled = False
            Next I
            '.fraTypeOfResponseToPatentOfficeAction.BackColor = &H8000000F  'ButtonFace
            .grpTypeOfResponseMade.BackColor = clrControl
            '.fraTypeOfResponseToPatentOfficeAction.Enabled = False
            .grpTypeOfResponseMade.Enabled = False
            ''.fraPriorActionResponseMadeOnDate.BackColor = &H8000000F  'ButtonFace
            ''.fraPriorActionResponseMadeOnDate.Enabled = False
            ''.lblPriorActionResponseMadeOnDate.BackColor = &H8000000F  'ButtonFace
            ''.lblPriorActionResponseMadeOnDate.Enabled = False
            ''.txtPriorActionResponseMadeOnDate.Enabled = False
            '.fraNewResponseMadeDate.BackColor = &H8000000F  'ButtonFace
            .grpResponseMadeDate.BackColor = clrControl
            '.fraNewResponseMadeDate.Enabled = False
            .grpResponseMadeDate.Enabled = False
            '.lblNewResponseMadeDate.Enabled = False
            .lblResponseMadeDate.BackColor = clrControl
            .lblResponseMadeDate.Enabled = False
            '.txtNewResponseMadeDate.Mask = ""
            '.txtNewResponseMadeDate.Text = ""
            .mtbResponseMadeDate.Text = ""
            '.txtNewResponseMadeDate.Mask = "##/##/####"
            .mtbResponseMadeDate.Mask = "00/00/0000"
            '.txtNewResponseMadeDate.Enabled = False
            .mtbResponseMadeDate.Enabled = False
            '.cmdDoneNewResponseMadeDate.Enabled = False
            .btnDoneResponseMadeDate.BackColor = clrControl
            .btnDoneResponseMadeDate.Enabled = False


            'Clear each of the Entries for the Current Actions
            Select Case SequenceNumberToUse
                Case 1
                    FirstUSPTOActionMailingDate = 0
                    FirstUSPTOActionResponseDueDate = 0
                    FirstUSPTOActionResponseMadeDate = 0
                    TypeOfFirstUSPTOAction = "NONE"
                    TypeOfFirstPatentOfficeResponse = "NONE"
                Case 2
                    SecondUSPTOActionMailingDate = 0
                    SecondUSPTOActionResponseDueDate = 0
                    SecondUSPTOActionResponseMadeDate = 0
                    TypeOfSecondUSPTOAction = "NONE"
                    TypeOfSecondPatentOfficeResponse = "NONE"
                Case 3
                    ThirdUSPTOActionMailingDate = 0
                    ThirdUSPTOActionResponseDueDate = 0
                    ThirdUSPTOActionResponseMadeDate = 0
                    TypeOfThirdUSPTOAction = "NONE"
                    TypeOfThirdPatentOfficeResponse = "NONE"
                Case 4
                    FourthUSPTOActionMailingDate = 0
                    FourthUSPTOActionResponseDueDate = 0
                    FourthUSPTOActionResponseMadeDate = 0
                    TypeOfFourthUSPTOAction = "NONE"
                    TypeOfFourthPatentOfficeResponse = "NONE"
                Case 5
                    FifthUSPTOActionMailingDate = 0
                    FifthUSPTOActionResponseDueDate = 0
                    FifthUSPTOActionResponseMadeDate = 0
                    TypeOfFifthUSPTOAction = "NONE"
                    TypeOfFifthPatentOfficeResponse = "NONE"
                Case 6
                    SixthUSPTOActionMailingDate = 0
                    SixthUSPTOActionResponseDueDate = 0
                    SixthUSPTOActionResponseMadeDate = 0
                    TypeOfSixthUSPTOAction = "NONE"
                    TypeOfSixthPatentOfficeResponse = "NONE"
                Case 7
                    SeventhUSPTOActionMailingDate = 0
                    SeventhUSPTOActionResponseDueDate = 0
                    SeventhUSPTOActionResponseMadeDate = 0
                    TypeOfSeventhUSPTOAction = "NONE"
                    TypeOfSeventhPatentOfficeResponse = "NONE"
                Case 8
                    EighthUSPTOActionMailingDate = 0
                    EighthUSPTOActionResponseDueDate = 0
                    EighthUSPTOActionResponseMadeDate = 0
                    TypeOfEighthUSPTOAction = "NONE"
                    TypeOfEighthPatentOfficeResponse = "NONE"
                Case 9
                    NinthUSPTOActionMailingDate = 0
                    NinthUSPTOActionResponseDueDate = 0
                    NinthUSPTOActionResponseMadeDate = 0
                    TypeOfNinthUSPTOAction = "NONE"
                    TypeOfNinthPatentOfficeResponse = "NONE"
                Case 10
                    TenthUSPTOActionMailingDate = 0
                    TenthUSPTOActionResponseDueDate = 0
                    TenthUSPTOActionResponseMadeDate = 0
                    TypeOfTenthUSPTOAction = "NONE"
                    TypeOfTenthPatentOfficeResponse = "NONE"
                Case 11
                    EleventhUSPTOActionMailingDate = 0
                    EleventhUSPTOActionResponseDueDate = 0
                    EleventhUSPTOActionResponseMadeDate = 0
                    TypeOfEleventhUSPTOAction = "NONE"
                    TypeOfEleventhPatentOfficeResponse = "NONE"
                Case 12
                    TwelvethUSPTOActionMailingDate = 0
                    TwelvethUSPTOActionResponseDueDate = 0
                    TwelvethUSPTOActionResponseMadeDate = 0
                    TypeOfTwelvethUSPTOAction = "NONE"
                    TypeOfTwelvethPatentOfficeResponse = "NONE"
            End Select

            '.cmdResetActionEntries.Enabled = False           
            .btnResetThisActionAndResponse.Enabled = False
            '.txtActionDate.Text = ""
            '.grpActionDate.Text = "Action Mailing Date"
            '.grpActionDate.Visible = False
            GroupInDocumentInputTabs = "grpHaveThereBeenAnyOfficialActions"
        End With

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Response As Integer
        Call msgSureWantToCancelThan(Response)
        Select Case Response
            Case 6 'Yes
                CurrentFormName = "frmMainMenu2"

                Me.Close()
            Case 7 'No
                'Do Nothing
        End Select
    End Sub
End Class