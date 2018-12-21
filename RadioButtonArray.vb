Public Class RadioButtonArray
    Inherits System.Collections.CollectionBase
    Public rdoControlArray As RadioButton
    Public temprdoIndex As Integer
    Private ReadOnly rdoHostForm As System.Windows.Forms.Form
    Public Function AddNewRadioButton(ByVal rdoButtonCaption As String, LocLeft As Integer, LocTop As Integer) As System.Windows.Forms.RadioButton
        ' Create a new instance of the Button class
        Dim aRadioButton As New System.Windows.Forms.RadioButton()

        ' Add the button to the collection's internal list
        Me.List.Add(aRadioButton)
        ' Add the button to the controls collection of the form referenced by the btnHostForm Field
        rdoHostForm.Controls.Add(aRadioButton)

        ' Set initial properties for the Selected Radio Button object Type
        aRadioButton.Anchor = (AnchorStyles.Left And AnchorStyles.Right)
        Select Case rdoButtonCaption
            Case "Intent to Use", "Use Mark", "Madrid Protocol"
                aRadioButton.Width = 180
                aRadioButton.Top = LocTop
                aRadioButton.Left = LocLeft
                aRadioButton.Text = rdoButtonCaption
            Case "1. Small Entity Status", "2. Large Entity Status", "3. Micro Entity Status"
                aRadioButton.Width = 160
                aRadioButton.Top = LocTop
                aRadioButton.Left = LocLeft
                aRadioButton.Text = rdoButtonCaption
            Case "Yes", "No"
                Select Case rdoButtonCaption
                    Case "Yes"
                        aRadioButton.Width = 60  '80
                        aRadioButton.Top = LocTop ' + 30
                        aRadioButton.Left = LocLeft
                    Case "No"
                        aRadioButton.Left = LocLeft + 80  '100
                        aRadioButton.Top = LocTop ' + 30
                End Select
                aRadioButton.Font = RKLFont12B
                aRadioButton.Text = rdoButtonCaption
            Case "LabelYes", "LabelNo"
                Select Case rdoButtonCaption
                    Case "LabelYes"
                        aRadioButton.Text = "Yes"
                        aRadioButton.Width = 80
                        aRadioButton.Top = LocTop ' + 30
                        aRadioButton.Left = LocLeft
                    Case "LabelNo"
                        aRadioButton.Text = "No"
                        aRadioButton.Left = LocLeft + 80  '100
                        aRadioButton.Top = LocTop ' + 30
                End Select
            Case "MethodOfReference"
                aRadioButton.Top = LocTop
                aRadioButton.Left = LocLeft  '200  '85  '175
                aRadioButton.Width = 50 '300 '400 '550 '650  '500
                aRadioButton.Text = ""
                aRadioButtonCount += 1
            Case "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth", "Eleventh", "Twelveth"
                aRadioButton.Top = LocTop
                aRadioButton.Left = LocLeft
                aRadioButton.Text = rdoButtonCaption
                Select Case rdoButtonCaption
                    Case "First"
                        aRadioButton.Width = 70
                    Case "Second"
                        aRadioButton.Width = 100
                    Case "Fifth"
                        aRadioButton.Width = 70
                    Case "Sixth"
                        aRadioButton.Width = 75
                    Case "Seventh"
                        aRadioButton.Width = 104
                    Case "Eighth"
                        aRadioButton.Width = 90
                        aRadioButton.Height = 30
                        aRadioButton.Top = 4
                    Case "Ninth"
                        aRadioButton.Width = 80
                    Case "Eleventh"
                        aRadioButton.Width = 110
                    Case "Twelveth"
                        aRadioButton.Width = 112
                    Case Else
                        aRadioButton.Width = 90
                End Select
                aRadioButtonCount += 1
            Case Else
                Select Case CurrentFormName
                    Case "frmInitialTrademarkApplicationInputTabs"
                        Select Case GroupInDocumentInputTabs
                            Case "grpTypeOfActionReceived"
                                If aRadioButtonCount = 0 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButtonCount = 1
                                ElseIf aRadioButtonCount = 4 Then  '3 Then   '4 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButtonCount = 0
                                    aRadioButtonCount += 1
                                Else
                                    aRadioButton.Top = LocTop + (aRadioButtonCount * 26)  'Count * 65 ' 40  '25
                                    aRadioButtonCount += 1
                                End If
                                aRadioButton.Font = RKLFont10B
                                aRadioButton.Left = LocLeft  '200  '85  '175
                                aRadioButton.Width = 350 '300 '400 '550 '650  '500
                                aRadioButton.Height = 30
                                aRadioButton.Text = rdoButtonCaption
                            Case "grpTypeOfTimeGivenForAResponse"
                                If aRadioButtonCount = 0 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButton.Width = 85
                                    aRadioButtonCount = 1
                                ElseIf (aRadioButtonCount = 1) Or (aRadioButtonCount = 2) Then
                                    aRadioButton.Top = LocTop
                                    aRadioButton.Width = 85
                                    aRadioButtonCount += 1
                                ElseIf aRadioButtonCount = 3 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButton.Width = 400
                                    aRadioButtonCount += 1
                                ElseIf aRadioButtonCount = 4 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButton.Width = 250
                                    aRadioButtonCount += 1
                                End If
                                aRadioButton.Left = LocLeft  '200  '85  '175                       
                                aRadioButton.Height = 20
                                aRadioButton.Text = rdoButtonCaption
                            Case "grpTypeOfResponseMade"
                                If aRadioButtonCount = 0 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButtonCount = 1
                                ElseIf aRadioButtonCount = 4 Then  '3 Then   '4 Then
                                    aRadioButton.Top = LocTop
                                    aRadioButtonCount = 0
                                    aRadioButtonCount += 1
                                Else
                                    aRadioButton.Top = LocTop + (aRadioButtonCount * 26)  'Count * 65 ' 40  '25
                                    aRadioButtonCount += 1
                                End If
                                aRadioButton.Font = RKLFont11B
                                aRadioButton.Left = LocLeft  '200  '85  '175
                                aRadioButton.Width = 300 '400 '550 '650  '500
                                aRadioButton.Text = rdoButtonCaption
                            Case Else
                                aRadioButton.Height = 40 '45
                                aRadioButton.Font = RKLFont12B
                        End Select
                    Case Else
                        If aRadioButtonCount = 0 Then
                            aRadioButton.Top = LocTop
                            aRadioButtonCount = 1
                        ElseIf aRadioButtonCount = 3 Then   '4 Then
                            aRadioButton.Top = LocTop
                            aRadioButtonCount = 0
                            aRadioButtonCount += 1
                        Else
                            aRadioButton.Top = LocTop + (aRadioButtonCount * 30)  'Count * 65 ' 40  '25
                            aRadioButtonCount += 1
                        End If
                        aRadioButton.Left = LocLeft  '200  '85  '175
                        aRadioButton.Width = 300 '400 '550 '650  '500
                        aRadioButton.Text = rdoButtonCaption
                End Select
        End Select

        aRadioButton.BackColor = Color.Transparent
        aRadioButton.Tag = Me.Count

        AddHandler aRadioButton.Click, AddressOf rdoClickHandler
        Return aRadioButton
    End Function
    Public Sub New(ByVal host As System.Windows.Forms.Form)
        rdoHostForm = host
        'Me.AddNewRadioButton("This is a DUMMY Radio Button", 200, 20)
    End Sub
    Default Public ReadOnly Property rdoItem(ByVal rdoIndex As Integer) As System.Windows.Forms.RadioButton
        Get
            temprdoIndex = rdoIndex   '- 1
            'Return CType(Me.List.Item(rdoIndex), System.Windows.Forms.RadioButton)
            Return CType(Me.List.Item(temprdoIndex), System.Windows.Forms.RadioButton)
        End Get
    End Property
    Public Sub Remove(ByVal RadioButtonToBeRemoved As Integer)
        ' Check to be sure there is a button to remove
        ''''If Me.Count > 0 Then
        ' Remove the last button added to the array from the host form
        ' controls collection.  NOTE: The use of the default property in
        ' accessing the array.
        ''''btnHostForm.Controls.Remove(Me(Me.Count - 1))
        rdoHostForm.Controls.Remove(Me(RadioButtonToBeRemoved))
        ''''Me.List.RemoveAt(Me.Count - 1)
        Me.List.RemoveAt(RadioButtonToBeRemoved)
        ''''End If
    End Sub
    Public Sub rdoClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        '''''MessageBox.Show("You have clicked button " & CType(CType(sender, System.Windows.Forms.Button).Tag, String))
        RadioButtonNumberClicked = (CType(sender, System.Windows.Forms.RadioButton).Tag) ' - 1
        ''''MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)
        Dim tempTabIndex As Integer

        Select Case CurrentFormName
            Case "frmInitialTrademarkApplicationInput"
                With frmInitialTrademarkApplicationInput
                    Select Case GroupInDocumentInitialInput
                        Case "grpTrademarkOwnersEntityStatus"
                            Select Case RadioButtonNumberClicked
                                Case 1  '"1. Small Entity Status"
                                    TrademarkOwnersEntityStatus = "Small"
                                Case 2  '"2. Large Entity Status"
                                    TrademarkOwnersEntityStatus = "Large"
                                Case 3  '"3. Micro Entity Status"
                                    TrademarkOwnersEntityStatus = "Micro"
                            End Select
                            For I = 0 To 2
                                .rdoArrayTrademarkOwnersEntityStatus.rdoItem(I).Enabled = False
                            Next
                            .grpTrademarkOwnersEntityStatus.BackColor = clrLighestOrange
                            .grpTrademarkOwnersEntityStatus.Enabled = False

                            ''''''.grpClientDocketNumber.Enabled = True
                            ''''''.grpClientDocketNumber.BackColor = clrOrange
                            ''''''.txtClientDocketNumber.Enabled = True
                            ''''''.txtClientDocketNumber.Focus()
                        Case Else
                            .grpCategoryOfTrademarkType.BackColor = clrLighestOrange
                            Select Case RadioButtonNumberClicked
                                Case 1
                                    CategoryOfTrademarkType = "Intent to Use"
                                    'Hide the other opt Choices
                                    .txtFirstUseDate.Text = ""
                                    .grpFirstUseDate.Visible = False
                                    .grpFirstUseDateInCommerce.Visible = False
                                    .txtMadridProtocolSerialNumber.Text = ""
                                    .grpMadridProtocolSerialNumber.Visible = False
                                    .txtWIPOFilingDate.Text = ""
                                    .grpWIPOFilingDate.Visible = False

                                    .grpDocketNumberSubDocketNumber.Enabled = True
                                    .grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
                                    .grpDocketNumber.BackColor = clrOrange
                                    .txtDocketNumber.Enabled = True
                                    .txtDocketNumber.Focus()
                                Case 2
                                    CategoryOfTrademarkType = "Use Mark"
                                    'Hide the other opt Choices
                                    .grpDocketNumberSubDocketNumber.BackColor = clrLightestGray
                                    .grpDocketNumber.BackColor = clrLightestGray
                                    .txtDocketNumber.Text = ""
                                    .grpDocketNumberSubDocketNumber.Enabled = False
                                    .txtMadridProtocolSerialNumber.Text = ""
                                    .grpMadridProtocolSerialNumber.Visible = False
                                    .txtWIPOFilingDate.Text = ""
                                    .grpWIPOFilingDate.Enabled = False
                                    .grpWIPOFilingDate.Visible = False

                                    .grpFirstUseDateInCommerce.Visible = True

                                    .grpFirstUseDate.Visible = True
                                    .grpFirstUseDate.BackColor = clrOrange
                                    .lblFirstUseDate.BackColor = clrOrange
                                    .txtFirstUseDate.Focus()
                                Case 3
                                    'Hide the other opt Choices
                                    .grpDocketNumberSubDocketNumber.BackColor = clrLightestGray
                                    .grpDocketNumber.BackColor = clrLightestGray
                                    .txtDocketNumber.Text = ""
                                    .grpDocketNumberSubDocketNumber.Enabled = False
                                    .txtFirstUseDate.Text = ""
                                    .grpFirstUseDate.Visible = False
                                    '.txtFirstUseDateInCommerce.Mask = ""
                                    .txtFirstUseDateInCommerce.Text = ""
                                    .grpFirstUseDateInCommerce.Visible = False

                                    CategoryOfTrademarkType = "Madrid Protocol"
                                    .grpMadridProtocolSerialNumber.Visible = True
                                    .grpWIPOFilingDate.Visible = True
                                    .txtMadridProtocolSerialNumber.Text = ""
                                    .txtMadridProtocolSerialNumber.Focus()
                            End Select
                    End Select
                End With            'RadioButtonNumberClicked = RadioButtonNumberClicked + 1
                'Select Case RadioButtonNumberClicked
                'Case 1
                '===> MessageBox.Show("You have clicked radio button " & RadioButtonNumberClicked.ToString)
                '    Case 2
                '        MessageBox.Show("You have clicked radio button " & RadioButtonNumberClicked.ToString)
                '    Case 3
                '        MessageBox.Show("You have clicked radio button " & RadioButtonNumberClicked.ToString)
                '    Case 4
                '        MessageBox.Show("You have clicked radio button " & RadioButtonNumberClicked.ToString)
                'End Select

            Case "frmInitialTrademarkApplicationInputTabs"
                With frmInitialTrademarkApplicationInputTabs
                    tempTabIndex = .tabTrademarkDocument.SelectedIndex
                    Select Case tempTabIndex
                        Case 1 'Official Actions
                            Select Case GroupInDocumentInputTabs
                                Case "grpHaveThereBeenAnyOfficialActions"
                                    Select Case RadioButtonNumberClicked
                                        Case 1  'Yes
                                            .grpHaveThereBeenAnyOfficialActions.BackColor = clrLighestOrange
                                            .lblHaveThereBeenAnyOfficialActions.BackColor = clrLighestOrange

                                            .grpEnterPatentOfficeMailingDate.Enabled = True
                                            .grpEnterPatentOfficeMailingDate.BackColor = clrOrange
                                            .lblEnterPatentOfficeMailingDate.Enabled = True
                                            .lblEnterPatentOfficeMailingDate.BackColor = clrOrange
                                            'Add the Sequence-umber-In-A-Word to the appropriate Groups/Labels
                                            .grpTypeOfActionReceived.Text = "Click on the Type of Trademark Office Action Received for the"
                                            .grpTypeOfActionReceived.Text = .grpTypeOfActionReceived.Text & " ==> " & GetOfficialActionSequenceWord() & " Patent Office Action:"
                                            '.lblResponseDueDate.Text = "The Response Due Date is as Follows:"
                                            .lblResponseDueDate.Text = "The " & GetOfficialActionSequenceWord() & " Response Due Date is:"
                                            '.grpTypeOfResponseMade.Text = "Click on the Type of Response that was Made to the Patent Office Action:"
                                            .grpTypeOfResponseMade.Text = "Click on the Type of Response that was Made to the " & GetOfficialActionSequenceWord() & " Patent Office Action:"
                                            .mtbEnterPatentOfficeMailingDate.Enabled = True
                                            .mtbEnterPatentOfficeMailingDate.Focus()
                                        Case 2  'No
                                            Call InitializeAllActionVariables()
                                            'Count the Number of Actions and Set the Number in the ReviewAllActions Group

                                            'Now Show the next Tab
                                            .tabTrademarkDocument.SelectedIndex = 2  'Goto State Registrations
                                    End Select
                                Case "grpTypeOfActionReceived"
                                    .grpTypeOfActionReceived.BackColor = clrLighestOrange

                                    .grpTypeOfTimeGivenForAResponse.Enabled = True
                                    .grpTypeOfTimeGivenForAResponse.BackColor = clrOrange
                                    For I = 0 To 7  '11
                                        .rdoArrayTypeOfTMOfficeActions.rdoItem(I).BackColor = clrLighestOrange
                                    Next
                                    For I = 0 To 4
                                        .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = True
                                        .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).BackColor = clrOrange
                                    Next I
                                    .lblOR1.BackColor = clrOrange
                                    .lblOR2.BackColor = clrOrange

                                    .grpNumberOfTimeToRespond.BackColor = clrControl
                                    '=RadioButtonNumberClicked
                                    GroupInDocumentInputTabs = "grpNumberOfTimeToRespond"
                                Case "grpNumberOfTimeToRespond"
                                    .grpTypeOfTimeGivenForAResponse.BackColor = clrLighestOrange

                                    If Not NowInDisplayModeForOfficialActions Then
                                        SequenceNumberToUse = SequenceOfPatentOfficeAction
                                    Else
                                        SequenceNumberToUse = SelectedSequenceOfPatentOfficeAction
                                    End If

                                    Select Case SequenceNumberToUse
                                        Case 1
                                            FirstTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 2
                                            SecondTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 3
                                            ThirdTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 4
                                            FourthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 5
                                            FifthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 6
                                            SixthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 7
                                            SeventhTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 8
                                            EighthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 9
                                            NinthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 10
                                            TenthTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 11
                                            EleventhTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                        Case 12
                                            TwelvethTypeOfTimeGivenForResponse = RadioButtonNumberClicked
                                    End Select

                                    Select Case RadioButtonNumberClicked
                                        Case 1  'Days
                                            TypeOfTimePeriodToRespond = "d"
                                            For I = 0 To 4
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I

                                            .grpNumberOfTimeToRespond.Enabled = True
                                            .grpNumberOfTimeToRespond.BackColor = clrOrange
                                            .lblNumberOfTimeToRespond.Enabled = True
                                            .lblNumberOfTimeToRespond.Text = "Enter Number of Days to Respond:"
                                            .txtNumberOfTimeToRespond.Enabled = True
                                            .txtNumberOfTimeToRespond.Focus()
                                        Case 2  'Weeks
                                            TypeOfTimePeriodToRespond = "ww"
                                            .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(0).Enabled = False
                                            For I = 2 To 4
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I

                                            .grpNumberOfTimeToRespond.Enabled = True
                                            .grpNumberOfTimeToRespond.BackColor = clrOrange
                                            .lblNumberOfTimeToRespond.Enabled = True
                                            .lblNumberOfTimeToRespond.Text = "Enter Number of Weeks to Respond:"
                                            .txtNumberOfTimeToRespond.Enabled = True
                                            .txtNumberOfTimeToRespond.Focus()
                                        Case 3  'Months
                                            TypeOfTimePeriodToRespond = "m"
                                            For I = 0 To 1
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I
                                            For I = 3 To 4
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I

                                            .grpNumberOfTimeToRespond.Enabled = True
                                            .grpNumberOfTimeToRespond.BackColor = clrOrange
                                            .lblNumberOfTimeToRespond.Enabled = True
                                            .lblNumberOfTimeToRespond.Text = "Enter Number of Months to Respond:"
                                            .txtNumberOfTimeToRespond.Enabled = True
                                            .txtNumberOfTimeToRespond.Focus()
                                        Case 4  'A Particular Date
                                            For I = 0 To 2
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I
                                            .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(4).Enabled = False

                                            .mtbResponseToBeOnAParticularDate.Enabled = True
                                            .mtbResponseToBeOnAParticularDate.Focus()
                                        Case 5  'No Response Necessary
                                            For I = 0 To 3
                                                .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).Enabled = False
                                            Next I
                                            'Make sure that the txtEnterNumberOfTimeToRepond field is cleared and that cmdDoneNumberOfTimesResponseGivenIn is disabled
                                            .grpNumberOfTimeToRespond.BackColor = clrLighestOrange '&H8000000F  'ButtonFace
                                            .lblNumberOfTimeToRespond.BackColor = clrLighestOrange  '&H8000000F  'ButtonFace
                                            .grpNumberOfTimeToRespond.Enabled = False
                                            .lblNumberOfTimeToRespond.Enabled = False
                                            .txtNumberOfTimeToRespond.Text = ""
                                            .btnDoneNumberOfTimeToRespond.Enabled = False

                                            ''Make sure that txtResponseToBeMadeOnAParticularDate is cleared
                                            '.txtResponseToBeMadeOnAParticularDate.Mask = ""
                                            '.txtResponseToBeMadeOnAParticularDate.Text = ""
                                            '.txtResponseToBeMadeOnAParticularDate.Mask = "##/##/####"                                            

                                            '.calReponseDueOnAParticularDate.Visible = False

                                            USPTOActionResponseDueDate = 0

                                            '.grpActionDate.Visible = False
                                            .lblResponseDueDate.Visible = False
                                            .txtResponseDueDate.Visible = False

                                            .lblResponseDueDate.Visible = False
                                            .txtResponseDueDate.Visible = False

                                            .grpResponseDueDate.Enabled = True
                                            .grpResponseDueDate.BackColor = clrOrange
                                            .lblThereIsNoResponseNecessaryForThisAction.Visible = True
                                            .lblThereIsNoResponseNecessaryForThisAction.Font = RKLFont12B
                                            .lblThereIsNoResponseNecessaryForThisAction.Text = "There is NO Response Necessary for this Action!"
                                            .lblThereIsNoResponseNecessaryForThisAction.Width = 500
                                            .lblThereIsNoResponseNecessaryForThisAction.Top = 16
                                            .lblThereIsNoResponseNecessaryForThisAction.Left = 35

                                            GroupInDocumentInputTabs = "grpResponseDueDate"
                                            ''''''''Call CaptureAndDisplayUSPTOActionDueDate()

                                    End Select
                                    .lblOR1.BackColor = clrLighestOrange
                                    .lblOR1.Enabled = False
                                    .lblOR2.BackColor = clrLighestOrange
                                    .lblOR2.Enabled = False
                                    For I = 0 To 4
                                        .rdoArrayTypeOfTimeGivenForAResponse.rdoItem(I).BackColor = clrLighestOrange
                                    Next I
                                Case "grpResponseDueDate"
                                    Select Case RadioButtonNumberClicked
                                        Case 1  'Yes
                                            .grpResponseDueDate.BackColor = clrLighestOrange
                                            .lblResponseDueDate.BackColor = clrLighestOrange
                                            .lblIsResponseDueDateCorrect.BackColor = clrLighestOrange

                                            .grpWasAResponsedFiled.Enabled = True
                                            .grpWasAResponsedFiled.BackColor = clrOrange
                                            .lblWasAResponsedFiled.Enabled = True
                                            .lblWasAResponsedFiled.BackColor = clrOrange

                                            GroupInDocumentInputTabs = "grpWasAResponsedFiled"
                                        Case 2  'No

                                    End Select
                                Case "grpWasAResponsedFiled"
                                    Select Case RadioButtonNumberClicked
                                        Case 1  'Yes
                                            .grpWasAResponsedFiled.BackColor = clrLighestOrange
                                            .lblWasAResponsedFiled.BackColor = clrLighestOrange

                                            .grpTypeOfResponseMade.Enabled = True
                                            .grpTypeOfResponseMade.BackColor = clrOrange

                                            For I = 0 To 2 '11
                                                .rdoArrayTypeOfTMResponseMade.rdoItem(I).Enabled = True
                                            Next I

                                            .grpResponseMadeDate.Enabled = False
                                            .grpResponseMadeDate.BackColor = clrControl
                                            GroupInDocumentInputTabs = "grpTypeOfResponseMade"
                                        Case 2  'No

                                    End Select
                                Case "grpTypeOfResponseMade"
                                    .grpTypeOfResponseMade.BackColor = clrLighestOrange

                                    .grpResponseMadeDate.Enabled = True
                                    .grpResponseMadeDate.BackColor = clrOrange
                                    .lblResponseMadeDate.Enabled = True
                                    .lblResponseMadeDate.BackColor = clrOrange
                                    .mtbResponseMadeDate.Enabled = True
                                    .mtbResponseMadeDate.Focus()
                                    '=RadioButtonNumberClicked
                            End Select
                        Case 2  'State Registrations
                            Select Case RadioButtonNumberClicked
                                Case 1  'Yes
                                    'With frmInitialTrademarkDocumentInputTabs
                                    .grpAreThereAnyStateRegistrations.BackColor = clrLighestOrange
                                    .lblAreThereAnyStateRegistrations.BackColor = clrLighestOrange
                                    .grpStateNames.Enabled = True
                                    .grpStateNames.BackColor = clrOrange
                                    'End With
                                Case 2  'No
                                    'With frmInitialTrademarkDocumentInputTabs
                                    '.btnResetStateNames.PerformClick()
                                    .btnDoneOKToSave.Enabled = True
                                    .btnDoneOKToSave.BackColor = clrOrange
                                    'Now goto Next Tab
                                    '.tabTrademarkDocument.SelectedIndex = 1
                                    'End With
                            End Select
                        Case 3
                    End Select
                End With
            Case "frmMethodsOfReferencingTrademarksForScreenDisplay"
                With frmMethodsOfReferencingTrademarksForScreenDisplay
                    .btnReset.Enabled = True
                    SelectedMethodNumberForReferencingDisplayedDocs = RadioButtonNumberClicked
                    Select Case RadioButtonNumberClicked
                        Case 1
                            Dim Response As Integer
                            Call msgSureWantToUseGeneralDocketNumber(Response)
                            Select Case Response
                                Case vbYes
                                    .grpByGeneralDocketNumber.Enabled = True
                                    .grpByGeneralDocketNumber.BackColor = clrOrange
                                    .lblByGeneralDocketNumber.Enabled = True
                                    .lblByGeneralDocketNumber.BackColor = clrOrange
                                    .txtByGeneralDocketNumber.Enabled = True
                                    .txtByGeneralDocketNumber.Focus()

                                    .rdoArrayMethodOfReference.rdoItem(1).Checked = False
                                    .grpByDocketNumberSubDocketNumber.Enabled = False
                                Case vbNo
                                    .btnReset.PerformClick()
                            End Select

                        Case 2
                            .grpByDocketNumberSubDocketNumber.Enabled = True
                            .grpByDocketNumberSubDocketNumber.BackColor = clrOrange
                            .lblDocketNumber.Enabled = True
                            .lblDocketNumber.BackColor = clrOrange
                            .lblSubDocketNumber.BackColor = clrOrange
                            .txtDocketNumber.Enabled = True
                            .txtDocketNumber.Focus()

                            .rdoArrayMethodOfReference.rdoItem(0).Checked = False
                            .grpByGeneralDocketNumber.Enabled = False
                    End Select
                    .btnReset.Enabled = True
                End With
            Case "frmChangeTrademarkType"
                With frmChangeTrademarkType
                    .lblNewTrademarkType.Enabled = True
                    .txtNewTrademarkType.Enabled = True
                    .txtNewTrademarkType.Text = .rdoArrayTypeOfTrademark.rdoItem(RadioButtonNumberClicked).Text.ToString
                    TrademarkType = .rdoArrayTypeOfTrademark.rdoItem(RadioButtonNumberClicked).Text.ToString
                    .txtNewTrademarkType.BackColor = Color.LawnGreen
                    .txtNewTrademarkType.ReadOnly = True
                    .btnReset.Enabled = True
                    .btnDone.Enabled = True
                End With
        End Select
    End Sub
End Class
