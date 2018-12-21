Public Class frmInitialTrademarkApplicationInput
    Public rdoArrayCategoryOfTypeOfTrademark As RadioButtonArray
    Public rdoArrayTrademarkOwnersEntityStatus As RadioButtonArray

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim tempDate As String

        With Me
            Select Case CategoryOfTrademarkType
                Case "Intent to Use"
                    FirstUseDate = 0
                    FirstUseDateInCommerce = 0
                    MadridProtocolSerialNumber = "NONE"
                    WIPOFilingDate = 0
                Case "Use Mark"
                    If Trim(.txtFirstUseDate.Text.ToString) = "" Then
                        FirstUseDate = 0
                    Else
                        tempDate = AddSlashesToStringDate(.txtFirstUseDate.Text.ToString)
                        FirstUseDate = ConvertToRKLDate(tempDate)
                    End If
                    If Trim(.txtFirstUseDateInCommerce.Text.ToString) = "NONE" Then
                        FirstUseDateInCommerce = 0
                    Else
                        tempDate = AddSlashesToStringDate(.txtFirstUseDateInCommerce.Text.ToString)
                        FirstUseDateInCommerce = ConvertToRKLDate(tempDate)
                    End If
                    MadridProtocolSerialNumber = "NONE"
                    WIPOFilingDate = 0
                Case "Madrid Protocol"
                    FirstUseDate = 0
                    FirstUseDateInCommerce = 0
                    MadridProtocolSerialNumber = .txtMadridProtocolSerialNumber.Text.ToString
                    tempDate = AddSlashesToStringDate(.txtWIPOFilingDate.Text.ToString)
                    WIPOFilingDate = ConvertToRKLDate(tempDate)
            End Select
            DocketNumber = Trim(.txtDocketNumber.Text.ToString)
            SubDocketNumber = Trim(.txtSubDocketNumber.Text.ToString)
            CountryCode = Trim(.txtCountryCode.Text.ToString)
            'ResponsibleAttorney <== This is captured when the RKL Atty List-Item is clicked

            ClientName = Trim(.txtClientName.Text.ToString)
            ClientDocketNumber = Trim(.txtClientDocketNumber.Text.ToString)

            'TrademarkType <== This is captured when the Radio-Button is Clicked
            MarkText = Trim(.rtbInputOfMark.Text.ToString)
            GoodsServicesUsedByMark = Trim(.rtbInputOfGoodsAndOrServices.Text.ToString)



            ''''''If Trim(.txtEnterFirstUseDateInInterStateCommerce.Text) = "NONE" Then
            ''''''    FirstUseDateInInterStateCommerce = 0
            ''''''Else
            ''''''    tempDate = AddSlashesToStringDate(.txtEnterFirstUseDateInInterStateCommerce.Text)
            ''''''    FirstUseDateInInterStateCommerce = ConvertToRKLDate(tempDate)
            ''''''End If


            'ApplicationSerialNumber
            'ApplicationFilingDate
            'LastUSPTOOfficialActionDate
            'RegistrationNumber
            'RegistrationIssueDate

            Select Case TrademarkType
                Case "Federal Trademark Application"
                    frmInitialTrademarkApplicationInputTabs.Show()
                Case "Federal Trademark Registration"
                    frmInitialTrademarkRegistrationInputTabs.Show()
            End Select




            'Call WriteNewTrademarkDocumentInputToRKLTrademarkTable()

            'Call msgSavedTrademarkDocument()

            'CurrentFormName = "frmMainMenu2"

            .Close()
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

    Private Sub frmInitialTrademarkApplicationInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rdoTitleCategoryOfTypeOfTrademark As String
        Dim LeftCatagoryOfTypeOfTrademark As Integer
        Dim TopCategoryOfTypeOfTrademark As Integer

        Dim rdoTitleTrademarkOwnersEntityStatus As String
        Dim LeftTrademarkOwnersEntityStatus As Integer
        Dim TopTrademarkOwnersEntityStatus As Integer

        CurrentFormName = "frmInitialTrademarkApplicationInput"

        '''''TrademarkType = "Federal Trademark Application"

        With Me
            .WindowState = FormWindowState.Maximized

            .Text = TrademarkType

            .lblFormTitle.Font = RKLFont16B
            '.lblFormTitle.Text = "Initial Federal Trademark Application Document Input"
            .lblFormTitle.Text = "Initial " & TrademarkType & " Document Input"

            'Now Set up the Multi-Column Radio Buttons for CatagoryOfTypeOfTrademark            
            .grpCategoryOfTrademarkType.Font = RKLFont14BI
            '.grpCategoryOfTrademarkType.Text = "Click on the Category of the Type of Trademark Application Being Input"
            .grpCategoryOfTrademarkType.Text = "Click on the Category of the Type of " & TrademarkType & " Being Input"
            rdoArrayCategoryOfTypeOfTrademark = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftCatagoryOfTypeOfTrademark = 470
            TopCategoryOfTypeOfTrademark = 40

            rdoTitleCategoryOfTypeOfTrademark = "Intent to Use"
            .grpCategoryOfTrademarkType.Controls.Add(rdoArrayCategoryOfTypeOfTrademark.AddNewRadioButton(rdoTitleCategoryOfTypeOfTrademark, LeftCatagoryOfTypeOfTrademark, TopCategoryOfTypeOfTrademark))

            LeftCatagoryOfTypeOfTrademark = 690
            rdoTitleCategoryOfTypeOfTrademark = "Use Mark"
            .grpCategoryOfTrademarkType.Controls.Add(rdoArrayCategoryOfTypeOfTrademark.AddNewRadioButton(rdoTitleCategoryOfTypeOfTrademark, LeftCatagoryOfTypeOfTrademark, TopCategoryOfTypeOfTrademark))

            LeftCatagoryOfTypeOfTrademark = 870
            rdoTitleCategoryOfTypeOfTrademark = "Madrid Protocol"
            .grpCategoryOfTrademarkType.Controls.Add(rdoArrayCategoryOfTypeOfTrademark.AddNewRadioButton(rdoTitleCategoryOfTypeOfTrademark, LeftCatagoryOfTypeOfTrademark, TopCategoryOfTypeOfTrademark))

            .grpCategoryOfTrademarkType.Enabled = True
            .grpCategoryOfTrademarkType.BackColor = clrOrange
            For I = 0 To 2
                .rdoArrayCategoryOfTypeOfTrademark.rdoItem(I).Enabled = True
            Next

            'Set up Fields for Use Mark  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            .grpFirstUseDate.Text = ""
            .grpFirstUseDate.BackColor = clrOrange
            .lblFirstUseDate.Font = RKLFont12BI
            .lblFirstUseDate.Text = "Enter First Use Date:"
            .txtFirstUseDate.Font = RKLFont12B
            .txtFirstUseDate.Text = ""
            .btnFirstUseDate.Font = RKLFont11BI
            .btnFirstUseDate.Text = "Done"
            .grpFirstUseDate.Visible = False

            .grpFirstUseDateInCommerce.Text = ""
            .lblFirstUseDateInCommerce.Font = RKLFont12BI
            .lblFirstUseDateInCommerce.Text = "Enter First Use Date In Commerce: "
            .txtFirstUseDateInCommerce.Font = RKLFont12B
            .txtFirstUseDateInCommerce.Text = ""
            .btnFirstUseDateInCommerce.Font = RKLFont12BI
            .btnFirstUseDateInCommerce.Text = "NONE"
            .grpFirstUseDateInCommerce.Visible = False
            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            'Set up Fields for Madrid Protocol   >>>>>>>>>>>>>>>>>>>>>>>>>>>
            .grpMadridProtocolSerialNumber.Top = 70  '65
            .grpMadridProtocolSerialNumber.BackColor = clrOrange
            .grpMadridProtocolSerialNumber.Text = ""
            .lblMadridProtocolSerialNumber.Font = RKLFont12BI
            .lblMadridProtocolSerialNumber.Text = "Enter Madrid Protocol Serial No.:"
            .txtMadridProtocolSerialNumber.Font = RKLFont12B
            .txtMadridProtocolSerialNumber.Text = ""
            .btnMadridProtocolSerialNumber.Font = RKLFont11BI
            .btnMadridProtocolSerialNumber.Text = "Done"
            .btnMadridProtocolSerialNumber.Enabled = False
            .grpMadridProtocolSerialNumber.Visible = False

            .grpWIPOFilingDate.Top = 70  '65
            .grpWIPOFilingDate.BackColor = clrLighestOrange   'clrOrange
            .grpWIPOFilingDate.Text = ""
            .lblWIPOFilingDate.Font = RKLFont12BI
            .lblWIPOFilingDate.Text = "Enter WIPO Filing Date:"
            .txtWIPOFilingDate.Font = RKLFont12B
            .txtWIPOFilingDate.Text = ""
            '''''''.btnDoneWIPOFilingDate.Font = RKLFont11BI
            '''''''.btnDoneWIPOFilingDate.Text = "Done"
            '''''''.btnDoneWIPOFilingDate.Enabled = False
            .grpWIPOFilingDate.Enabled = False
            .grpWIPOFilingDate.Visible = False

            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            .grpDocketNumberSubDocketNumber.Font = RKLFont14B
            .grpDocketNumberSubDocketNumber.Text = "Enter Docket Number, Sub-Docket Number, Client Docket Number"

            .grpDocketNumber.Text = ""
            '.grpDocketNumber.BackColor = clrOrange
            .lblDocketNumber.Font = RKLFont12BI
            .lblDocketNumber.Text = "Enter Docket Number:"
            '.lblDocketNumber.BackColor = clrOrange
            .txtDocketNumber.Font = RKLFont12B
            .txtDocketNumber.Text = ""
            .txtDocketNumber.BackColor = clrLemmonChiffon
            .txtDocketNumber.Focus()
            .btnLookUpDN.Font = RKLFont11B
            .btnLookUpDN.Text = "Look-This-Up"
            .btnLookUpDN.Enabled = False

            .grpClientName.Font = RKLFont12B
            .grpClientName.Text = "Client Name"

            .grpClientName.Enabled = False

            .txtClientName.Font = RKLFont12B
            .txtClientName.Text = ""
            .txtClientName.Enabled = False

            .grpSubDocketNumber.Text = ""
            .grpSubDocketNumber.Enabled = False

            .lblSubDocketNumber.Font = RKLFont12BI
            .lblSubDocketNumber.Text = "Enter Sub-Docket Number:"
            .lblSubDocketNumber.Enabled = False

            .txtSubDocketNumber.Font = RKLFont12B
            .txtSubDocketNumber.Text = ""
            .txtSubDocketNumber.Enabled = False

            .btnLookUpSDN.Font = RKLFont11B
            .btnLookUpSDN.Text = "Look-This-Up"
            .btnLookUpSDN.Enabled = False

            IntialLoadOfThisFormCompleted = False
            .grpSelectResponsibleAttorney.Font = RKLFont12BI
            'Open the Connection to the RKL rklfeesattorneys DB
            .grpSelectResponsibleAttorney.Text = "Select Responsible Attorney "
            .lstSelectResponsibleAttorney.Font = RKLFont12B
            .lstSelectResponsibleAttorney.BackColor = clrLemmonChiffon
            OpenConnectionToRKLAccountingDB("rklfeesattorneys.mdb")
            'Open the Attorney Name Table
            OpenTableInRKLAccountingDB("AttorneyNames")
            With adoRKLAccountingRecordset
                Me.lstSelectResponsibleAttorney.Items.Add("Scroll & Click")
                Do Until .EOF
                    'Get the Attorney Name from the current Record
                    Me.lstSelectResponsibleAttorney.Items.Add(Trim(.Fields!RKLAttyName.Value))
                    .MoveNext()
                Loop
            End With
            Me.lstSelectResponsibleAttorney.TopIndex = 0
            Me.lstSelectResponsibleAttorney.SetSelected(0, False)
            'Close the Table and the DB
            CloseTableInRKLAccountingDB()
            CloseConnectionToRKLAccountingDB()
            IntialLoadOfThisFormCompleted = True

            .grpSelectResponsibleAttorney.Enabled = False
            .lstSelectResponsibleAttorney.Enabled = False

            .grpDocketNumberSubDocketNumber.Enabled = False

            'Set up grpCountryCode
            .grpCountryCode.Font = RKLFont12BI
            .grpCountryCode.Text = ""
            .lblCountryCode.Font = RKLFont12BI
            .lblCountryCode.Text = "Enter the Two or Three Letter Country Code:"
            .txtCountryCode.Enabled = False
            .txtCountryCode.Font = RKLFont12B
            .txtCountryCode.Text = ""

            .btnCountryCode.Font = RKLFont11BI
            .btnCountryCode.Text = "Done"
            .grpCountryCode.Enabled = False
            .lblCountryCode.Enabled = False
            .btnCountryCode.Enabled = False

            'Set up grpTrademarkOwnersEntityStatus
            .grpTrademarkOwnersEntityStatus.Font = RKLFont12BI
            .grpTrademarkOwnersEntityStatus.Text = "Click on the Trademark Owner's Entity Status"
            rdoArrayTrademarkOwnersEntityStatus = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftTrademarkOwnersEntityStatus = 60
            TopTrademarkOwnersEntityStatus = 18

            rdoTitleTrademarkOwnersEntityStatus = "1. Small Entity Status"
            .grpTrademarkOwnersEntityStatus.Controls.Add(rdoArrayTrademarkOwnersEntityStatus.AddNewRadioButton(rdoTitleTrademarkOwnersEntityStatus, LeftTrademarkOwnersEntityStatus, TopTrademarkOwnersEntityStatus))
            LeftTrademarkOwnersEntityStatus = 250
            TopTrademarkOwnersEntityStatus = 18

            rdoTitleTrademarkOwnersEntityStatus = "2. Large Entity Status"
            .grpTrademarkOwnersEntityStatus.Controls.Add(rdoArrayTrademarkOwnersEntityStatus.AddNewRadioButton(rdoTitleTrademarkOwnersEntityStatus, LeftTrademarkOwnersEntityStatus, TopTrademarkOwnersEntityStatus))
            LeftTrademarkOwnersEntityStatus = 430
            TopTrademarkOwnersEntityStatus = 18

            rdoTitleTrademarkOwnersEntityStatus = "3. Micro Entity Status"
            .grpTrademarkOwnersEntityStatus.Controls.Add(rdoArrayTrademarkOwnersEntityStatus.AddNewRadioButton(rdoTitleTrademarkOwnersEntityStatus, LeftTrademarkOwnersEntityStatus, TopTrademarkOwnersEntityStatus))

            'Now disable the above rdo-buttons
            For I = 0 To 2
                rdoArrayTrademarkOwnersEntityStatus.rdoItem(I).Enabled = False
            Next
            .grpTrademarkOwnersEntityStatus.Enabled = False

            'Set up Client Docket Number
            .grpClientDocketNumber.Text = ""
            .grpClientDocketNumber.Enabled = False

            .lblClientDocketNumber.Font = RKLFont12BI
            .lblClientDocketNumber.Text = "Enter Client Docket Number:"
            .lblClientDocketNumber.Enabled = False

            .txtClientDocketNumber.Font = RKLFont12B
            .txtClientDocketNumber.Text = ""
            .btnClientDocketNumber.Font = RKLFont11B
            .btnClientDocketNumber.Text = "NONE"
            .btnClientDocketNumber.Enabled = False

            'Set up Foreign Client Reference Number
            .grpForeignClientReferenceNumber.Text = ""
            .grpForeignClientReferenceNumber.Enabled = False

            .lblForeignClientReferenceNumber.Font = RKLFont12BI
            .lblForeignClientReferenceNumber.Text = "Enter Foreign Client Reference Number:"
            lblForeignClientReferenceNumber.Enabled = False

            .txtForeignClientReferenceNumber.Font = RKLFont12B
            .txtForeignClientReferenceNumber.Text = ""
            .btnForeignClientReferenceNumber.Font = RKLFont11BI
            .btnForeignClientReferenceNumber.Text = "NONE"
            .btnForeignClientReferenceNumber.Enabled = False
            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            '''''''Now Set up the Multi-Row/Multi-Column Radio Buttons for TypeOfTrademark
            ''''''.grpTypeOfTrademark.Font = RKLFont14BI
            ''''''.grpTypeOfTrademark.Text = "Click on the Type of Trademark Being Input"
            ''''''rdoArrayTypeOfTrademark = New RadioButtonArray(Me) '<== Me refers to this Form

            ''''''LeftTypeOfTrademark = 150  '20
            ''''''TopTypeOfTrademark = 20  '5  '1

            ''''''rdoTitleTypeOfTrademark = "Trademark (Goods)"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''rdoTitleTypeOfTrademark = "Service Mark (Services)"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''rdoTitleTypeOfTrademark = "Combined Trademark/Service"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''LeftTypeOfTrademark = 530  '500 represents the start of a new Column of Radio Buttons
            ''''''TopTypeOfTrademark = 20  '1

            ''''''rdoTitleTypeOfTrademark = "Collective Memberahip Mark"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''rdoTitleTypeOfTrademark = "Certification Mark"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''rdoTitleTypeOfTrademark = "Collective Mark"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''LeftTypeOfTrademark = 870  '500 represents the start of a new Column of Radio Buttons
            ''''''TopTypeOfTrademark = 20  '1

            ''''''rdoTitleTypeOfTrademark = "Concurrent Use Mark"
            ''''''.grpTypeOfTrademark.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            ''''''For I = 0 To 6
            ''''''    .rdoArrayTypeOfTrademark.rdoItem(I).Enabled = False
            ''''''Next I

            ''''''.grpTypeOfTrademark.Enabled = False
            '''''''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            .grpInputOfMark.Font = RKLFont14B
            .grpInputOfMark.Text = "Input of Mark"
            .lblInputOfMarkInstructions.Font = RKLFont14BI
            .lblInputOfMarkInstructions.Text = "     (Please limit the description to 100 characters)"
            .rtbInputOfMark.Font = RKLFont14B
            .rtbInputOfMark.Text = ""

            .btnDoneInputOfMark.Font = RKLFont14BI
            .btnDoneInputOfMark.Text = " Done Input Of Mark "

            .btnClearInputOfMark.Font = RKLFont14BI
            .btnClearInputOfMark.Text = " Clear Input Of Mark "

            .grpInputOfMark.Enabled = False

            .grpInputOfGoodsAndOrServices.Font = RKLFont14B
            .grpInputOfGoodsAndOrServices.Text = "Input Of Goods And/Or Services Used by the Mark"
            .lblInputOfGoodsAndOrServices.Font = RKLFont16BI
            .lblInputOfGoodsAndOrServices.Text = "(Please limit the description To 80 characters...Don't write your life story)"

            .rtbInputOfGoodsAndOrServices.Font = RKLFont14B
            .rtbInputOfGoodsAndOrServices.Text = ""

            .btnDoneInputOfGoodAndOrServices.Font = RKLFont14BI
            .btnDoneInputOfGoodAndOrServices.Text = " Done Input of Goods/Services"

            .btnClearInputOfGoodAndOrServices.Font = RKLFont14BI
            .btnClearInputOfGoodAndOrServices.Text = " Clear Input of Goods/Services"

            .grpInputOfGoodsAndOrServices.Enabled = False

            '.grpEnterFirstUseDateInInterStateCommerce.Text = ""
            '.lblEnterFirstUseDateInInterStateCommerce.Font = RKLFont14BI
            '.lblEnterFirstUseDateInInterStateCommerce.Text = "Enter First Use Date In Inter-State Commerce: "
            '.btnNoneFirstUseDateInInterstateCommerce.Font = RKLFont12BI
            '.btnNoneFirstUseDateInInterstateCommerce.Text = "NONE"
            '.grpEnterFirstUseDateInInterStateCommerce.Enabled = False

            .btnDone.Font = RKLFont16BI
            .btnDone.Text = " D o n e "
            .btnDone.Enabled = False
            .btnReset.Font = RKLFont16BI
            .btnReset.Text = " Reset "
            .btnReset.Enabled = False
            .btnCancel.Font = RKLFont16BI
            .btnCancel.Text = " Cancel "
        End With
    End Sub

    Private Sub btnLookUpDN_Click(sender As Object, e As EventArgs) Handles btnLookUpDN.Click
        Dim tempDocketNumber As String

        'Now Get and Display the current Client Name for entered Docket Number in
        '   the RKLAccountDB And the Docket Table
        OpenConnectionToRKLTrademarkDB("rklaccountingDB.mdb")
        OpenTableInRKLTrademarkDB("Docket")

        With adoRKLTrademarkRecordset
            Do Until .EOF
                tempDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)   '("DocketNumber").ToString

                If Me.txtDocketNumber.Text = Trim(tempDocketNumber) Then
                    DocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                    Me.grpClientName.Enabled = True
                    Me.grpClientName.BackColor = clrLighestOrange
                    Me.txtClientName.Enabled = True
                    Me.txtClientName.Text = .Fields!ClientName.Value.ToString

                    With Me
                        .grpDocketNumber.BackColor = clrLighestOrange 'Color.FromArgb(255, 224, 192) 'Lightest Orange
                        .lblDocketNumber.BackColor = clrLighestOrange 'Color.FromArgb(255, 224, 192) 'Lightest Orange                      .grpClientName.Enabled = True

                        .grpSubDocketNumber.Enabled = True
                        .grpSubDocketNumber.BackColor = clrOrange 'Color.Orange
                        .lblSubDocketNumber.Enabled = True
                        .lblSubDocketNumber.BackColor = clrOrange 'Color.Orange
                        .txtSubDocketNumber.Enabled = True
                        .txtSubDocketNumber.Focus()
                        CloseTableInRKLTrademarkDB()
                        CloseConnectionToRKLTrademarkDB()
                        Exit Sub
                    End With
                End If
                .MoveNext()
            Loop
        End With
        Call msgDocketNumberNotFound(Me.txtDocketNumber.Text)
        CloseTableInRKLTrademarkDB()
        CloseConnectionToRKLTrademarkDB()
        Me.txtDocketNumber.Text = ""
        Me.txtDocketNumber.Focus()
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub txtDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtDocketNumber.TextChanged
#Enable Warning IDE1006 ' Naming Styles
        With Me
            If Len(.txtDocketNumber.Text) > 0 Then
                .btnReset.Enabled = True
                .txtDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
                .btnLookUpDN.Enabled = True
                .AcceptButton = btnLookUpDN
            Else
                .txtDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                .btnReset.Enabled = False
            End If

        End With
    End Sub

    Private Sub txtClientName_TextChanged(sender As Object, e As EventArgs) Handles txtClientName.TextChanged
        With Me
            If Len(.txtClientName.Text) > 0 Then
                .txtClientName.BackColor = clrLightGreen
                .AcceptButton = .btnClientDocketNumber
            Else
                .txtClientName.BackColor = clrLemmonChiffon
                .txtClientName.SelectionStart = 0
            End If
        End With
    End Sub

    Private Sub txtSubDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSubDocketNumber.TextChanged
        With Me
            If .txtSubDocketNumber.Text.Length > 0 Then
                .txtSubDocketNumber.BackColor = clrLightGreen
                .btnLookUpSDN.Enabled = True
                .AcceptButton = .btnLookUpSDN
            Else
                .txtSubDocketNumber.BackColor = clrLemmonChiffon
                .btnLookUpSDN.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtlClientDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtClientDocketNumber.TextChanged
        With Me
            If .txtClientDocketNumber.Text.Length > 0 Then
                .txtClientDocketNumber.BackColor = clrLightGreen
                .btnClientDocketNumber.Enabled = True
                .btnClientDocketNumber.Text = "Done"
                .AcceptButton = btnClientDocketNumber
            Else
                .txtClientDocketNumber.BackColor = clrLemmonChiffon
                .btnClientDocketNumber.Text = "None"
                .AcceptButton = btnClientDocketNumber
            End If
        End With
    End Sub

    Private Sub btnLookUpSDN_Click(sender As Object, e As EventArgs) Handles btnLookUpSDN.Click
        Dim tempRKLDocketInDB As String
        Dim tempInsertedSubDocketNumber As String
        Dim tempSubDocketNumberInDB As String
        'Dim tempResponse As Integer
        With Me
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>            
            ''''          SubDocketNumber = Trim$(.txtSubDocketNumber.Text)
            tempInsertedSubDocketNumber = Trim$(.txtSubDocketNumber.Text)
            FullDocketNumber = DocketNumber & "-" & tempInsertedSubDocketNumber


            'NOTE:  On 08/20/17 Mort told Marv to NOT-allow ANY RECORDS THAT HAVE DUPLICATE RECORDS WITH DN-AND-SDN's be entered
            '  So, the next section checks to see if a record within the Table already exists with this DN and the new SDN - If so, send an error message
            '  First, Open a new Connection to the Patent DB
            OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
            OpenTableInRKLTrademarkDB("TrademarkDocuments")

            With adoRKLTrademarkRecordset   'Use with VB PatentDocuments Table
                Do
                    tempRKLDocketInDB = Trim$(.Fields!DocketNumber.Value.ToString)
                    tempSubDocketNumberInDB = Trim$(.Fields!SubDocketNumber.Value.ToString)
                    Me.btnLookUpSDN.BackColor = Color.Yellow '&HFFFF&   'Dark Yellow
                    Me.btnLookUpSDN.Text = "Searching..."
                    If (DocketNumber = tempRKLDocketInDB) And (tempInsertedSubDocketNumber = tempSubDocketNumberInDB) Then
                        'Display an error message
                        Call msgMustNotEnterRecordWithDuplicateDNandSDN(tempInsertedSubDocketNumber)
                        'Clear the SDN Input Text Control
                        Me.btnLookUpSDN.Text = "Look-This-Up"
                        Me.btnLookUpSDN.BackColor = clrGreyGainsboro  'Color.DarkGray '&H8000000F  'ButtonFace
                        Me.btnLookUpSDN.Enabled = False
                        Me.txtSubDocketNumber.Text = ""
                        Me.txtSubDocketNumber.Focus()
                        CloseConnectionToRKLTrademarkDB()
                        CloseTableInRKLTrademarkDB()
                        Exit Sub
                    Else
                        .MoveNext()
                    End If
                Loop Until .EOF
                CloseConnectionToRKLTrademarkDB()
                CloseTableInRKLTrademarkDB()
            End With


            'Change the BackColor of the LookUp Button and Label it "OK to Use!"
            .btnLookUpSDN.BackColor = clrLime  '&HFF00&      'Green
            .btnLookUpSDN.Text = "OK to Use!"
            ''''''''.fraSubDocketNumber.BackColor = &HC0E0FF  'Lightest Orange
            ''''''''.fraClientReferenceNumber.Enabled = True
            ''''''''.fraClientReferenceNumber.BackColor = &H80C0FF   'Light Orange
            ''''''''.lblClientReferenceNumber.Enabled = True
            ''''''''.lblClientReferenceNumber.BackColor = &H80C0FF   'Light Orange
            ''''''''.cmdDoneClientReferenceNumber.Enabled = True
            ''''''''.txtClientReferenceNumber.Enabled = True
            ''''''''.txtClientReferenceNumber.SetFocus

            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            .grpSubDocketNumber.BackColor = clrLighestOrange
            .lblSubDocketNumber.BackColor = clrLighestOrange

            ''''''.grpSelectResponsibleAttorney.Enabled = True
            ''''''.grpSelectResponsibleAttorney.BackColor = clrOrange
            ''''''.lstSelectResponsibleAttorney.Enabled = True
            ''''''.lstSelectResponsibleAttorney.Focus()


            ''''''.grpClientDocketNumber.Enabled = True
            ''''''.grpClientDocketNumber.BackColor = clrOrange
            ''''''.txtClientDocketNumber.Enabled = True
            ''''''.txtClientDocketNumber.Focus()
            ''''''.btnClientDocketNumber.Enabled = True

            .grpCountryCode.Enabled = True
            .grpCountryCode.BackColor = clrOrange
            .lblCountryCode.Enabled = True
            .lblCountryCode.BackColor = clrOrange
            .txtCountryCode.Enabled = True
            .txtCountryCode.Focus()


        End With
    End Sub

    Private Sub btnClientDocketNumber_Click(sender As Object, e As EventArgs) Handles btnClientDocketNumber.Click
        With Me
            If .btnClientDocketNumber.Text = "None" Then
                .txtClientDocketNumber.Text = "None"
                .grpClientDocketNumber.BackColor = clrLighestOrange
                .lblSubDocketNumber.BackColor = clrLighestOrange

                .grpForeignClientReferenceNumber.Enabled = True
                .grpForeignClientReferenceNumber.BackColor = clrOrange
                .lblForeignClientReferenceNumber.Enabled = True
                .lblForeignClientReferenceNumber.BackColor = clrOrange
                .txtForeignClientReferenceNumber.Focus()

                ''''''.grpSelectResponsibleAttorney.Enabled = True
                ''''''.lstSelectResponsibleAttorney.Enabled = True
                ''''''.grpSelectResponsibleAttorney.BackColor = clrOrange
            Else
                .grpClientDocketNumber.BackColor = clrLighestOrange
                .lblSubDocketNumber.BackColor = clrLighestOrange

                .grpForeignClientReferenceNumber.Enabled = True
                .grpForeignClientReferenceNumber.BackColor = clrOrange
                .lblForeignClientReferenceNumber.Enabled = True
                .lblForeignClientReferenceNumber.BackColor = clrOrange
                .btnForeignClientReferenceNumber.Enabled = True
                .txtForeignClientReferenceNumber.Focus()

                '''''.grpSelectResponsibleAttorney.Enabled = True
                '''''.lstSelectResponsibleAttorney.Enabled = True
                '''''.grpSelectResponsibleAttorney.BackColor = clrOrange
            End If
        End With
    End Sub

    Private Sub rtbInputOfMark_TextChanged(sender As Object, e As EventArgs) Handles rtbInputOfMark.TextChanged
        With Me
            If .rtbInputOfMark.Text.Length > 0 Then
                .rtbInputOfMark.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen

                .AcceptButton = .btnDoneInputOfMark
                If .rtbInputOfMark.Text.Length > 100 Then
                    Call msgThisFieldCantBeLongerThan(.rtbInputOfMark.Text.Length - 1)
                    .rtbInputOfMark.Text = Microsoft.VisualBasic.Left(.rtbInputOfMark.Text, 100)
                    .rtbInputOfMark.SelectionStart = rtbInputOfMark.Text.Length + 1
                Else
                    .lblMarkCharactersRemaining.Text = "Characters Remaining: " & (100 - .rtbInputOfMark.Text.Length).ToString
                End If
            Else
                .lblMarkCharactersRemaining.Text = "Characters Remaining: " & (100 - .rtbInputOfMark.Text.Length).ToString
                .rtbInputOfMark.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
            End If

        End With
    End Sub

    Private Sub btnDoneInputOfMark_Click(sender As Object, e As EventArgs) Handles btnDoneInputOfMark.Click
        With Me
            .grpInputOfMark.BackColor = clrLighestOrange
            .lblInputOfMarkInstructions.BackColor = clrLighestOrange

            .grpInputOfGoodsAndOrServices.Enabled = True
            .grpInputOfGoodsAndOrServices.BackColor = clrOrange
            .lblInputOfGoodsAndOrServices.BackColor = clrOrange

            .rtbInputOfGoodsAndOrServices.Focus()
        End With
    End Sub

    Private Sub btnClearInputOfMark_Click(sender As Object, e As EventArgs) Handles btnClearInputOfMark.Click
        With Me
            .rtbInputOfMark.Text = ""
            .rtbInputOfMark.Focus()
        End With
    End Sub

    Private Sub rtbInputOfGoodsAndOrServices_TextChanged(sender As Object, e As EventArgs) Handles rtbInputOfGoodsAndOrServices.TextChanged
        Dim MaxWidthOfText As Integer = 80

        With Me
            If .rtbInputOfGoodsAndOrServices.Text.Length > 0 Then
                .rtbInputOfGoodsAndOrServices.BackColor = clrLightGreen

                .AcceptButton = .btnDoneInputOfGoodAndOrServices
                If .rtbInputOfGoodsAndOrServices.Text.Length > MaxWidthOfText Then
                    Call msgThisFieldCantBeLongerThan(.rtbInputOfGoodsAndOrServices.Text.Length - 1)
                    .rtbInputOfGoodsAndOrServices.Text = Microsoft.VisualBasic.Left(.rtbInputOfGoodsAndOrServices.Text, MaxWidthOfText)
                    .rtbInputOfGoodsAndOrServices.SelectionStart = rtbInputOfGoodsAndOrServices.Text.Length + 1
                Else
                    .lblGoodsCharactersRemaining.Text = "Characters Remaining: " & (MaxWidthOfText - .rtbInputOfGoodsAndOrServices.Text.Length).ToString
                End If
            Else
                .lblGoodsCharactersRemaining.Text = "Characters Remaining: " & (MaxWidthOfText - .rtbInputOfGoodsAndOrServices.Text.Length).ToString
                .rtbInputOfGoodsAndOrServices.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub

    Private Sub btnDoneInputOfGoodAndOrServices_Click(sender As Object, e As EventArgs) Handles btnDoneInputOfGoodAndOrServices.Click
        With Me
            .grpInputOfGoodsAndOrServices.BackColor = clrLighestOrange
            .lblInputOfGoodsAndOrServices.BackColor = clrLighestOrange

            .btnDone.Enabled = True
            AcceptButton = btnDone
        End With
    End Sub

    Private Sub btnClearInputOfGoodAndOrServices_Click(sender As Object, e As EventArgs) Handles btnClearInputOfGoodAndOrServices.Click
        With Me
            .rtbInputOfGoodsAndOrServices.Text = ""
            .rtbInputOfGoodsAndOrServices.Focus()
        End With
    End Sub

    Private Sub txtFirstUseDateInCommerce_TextChanged(sender As Object, e As EventArgs) Handles txtFirstUseDateInCommerce.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer

        With Me
            If Trim(.txtFirstUseDateInCommerce.Text) = "NONE" Then
                .txtFirstUseDateInCommerce.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                .grpFirstUseDateInCommerce.BackColor = clrLighestOrange
                .lblFirstUseDateInCommerce.BackColor = clrLighestOrange

                .grpDocketNumberSubDocketNumber.Enabled = True
                .grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
                .grpDocketNumber.BackColor = clrOrange
                .txtDocketNumber.Enabled = True
                .txtDocketNumber.Focus()
                Exit Sub
            End If

            Start = .txtFirstUseDateInCommerce.SelectionStart
            Length = .txtFirstUseDateInCommerce.SelectionLength
            .txtFirstUseDateInCommerce.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.txtFirstUseDateInCommerce.Text)) > 0 Then
                .btnFirstUseDateInCommerce.Text = "Done"
                .txtFirstUseDateInCommerce.Mask = "00/00/0000"
                .txtFirstUseDateInCommerce.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .txtFirstUseDateInCommerce.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .txtFirstUseDateInCommerce.SelectionStart = Start
                    .txtFirstUseDateInCommerce.SelectionLength = Length
                End If
                If Len(Trim(.txtFirstUseDateInCommerce.Text)) = 8 Then
                    .txtFirstUseDateInCommerce.Mask = "00/00/0000"
                    .grpFirstUseDateInCommerce.BackColor = clrLighestOrange
                    .lblFirstUseDateInCommerce.BackColor = clrLighestOrange

                    .grpDocketNumberSubDocketNumber.Enabled = True
                    .grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
                    .grpDocketNumber.BackColor = clrOrange
                    .txtDocketNumber.Enabled = True
                    .txtDocketNumber.Focus()
                End If
            Else
                .txtFirstUseDateInCommerce.BackColor = clrLemmonChiffon
                .txtFirstUseDateInCommerce.Mask = "00/00/0000"
                .btnFirstUseDateInCommerce.Text = "NONE"
            End If
        End With
    End Sub


    Private Sub lstSelectResponsibleAttorney_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSelectResponsibleAttorney.SelectedIndexChanged
        If IntialLoadOfThisFormCompleted = False Then Exit Sub
        With Me
            Dim tempRKLAttorneySelected As String = .lstSelectResponsibleAttorney.SelectedItem
            ResponsibleAttorney = Trim(tempRKLAttorneySelected)

            .grpSelectResponsibleAttorney.BackColor = clrLighestOrange

            '''''''GroupInDocumentInitialInput = "grpTrademarkOwnersEntityStatus"
            '''''''.grpTrademarkOwnersEntityStatus.Enabled = True
            '''''''.grpTrademarkOwnersEntityStatus.BackColor = clrOrange
            '''''''For I = 0 To 2
            '''''''    .rdoArrayTrademarkOwnersEntityStatus.rdoItem(I).Enabled = True
            '''''''Next
            ''''''''NOTE: THE NEXT LINE IS TEMPORARY UNTIL MORT SAYS TO LET THE USER PICK WHICH ON
            '''''''.rdoArrayTrademarkOwnersEntityStatus.rdoItem(0).Select()
            ''''''''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            .grpClientDocketNumber.Enabled = True
            .grpClientDocketNumber.BackColor = clrOrange
            .txtClientDocketNumber.Enabled = True
            .txtClientDocketNumber.Focus()
            ''''''.btnClientDocketNumber.Enabled = False

            ''''''''''''.grpInputOfMark.Enabled = True
            ''''''''''''.grpInputOfMark.BackColor = clrOrange
            ''''''''''''.rtbInputOfMark.Focus()

        End With
    End Sub

    Private Sub btnFirstUseDateInCommerce_Click(sender As Object, e As EventArgs) Handles btnFirstUseDateInCommerce.Click
        With Me
            .grpFirstUseDateInCommerce.BackColor = clrLighestOrange
            .lblFirstUseDateInCommerce.BackColor = clrLighestOrange

            .txtFirstUseDateInCommerce.Mask = ""
            .txtFirstUseDateInCommerce.Text = "NONE"
        End With
    End Sub

    Private Sub btnNoneFirstUseDateInInterstateCommerce_Click(sender As Object, e As EventArgs)
        ''''''With Me
        ''''''    .txtEnterFirstUseDateInInterStateCommerce.Mask = ""
        ''''''    .txtEnterFirstUseDateInInterStateCommerce.Text = "NONE"
        ''''''End With
    End Sub

    Private Sub txtMadridProtocolSerialNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMadridProtocolSerialNumber.TextChanged
        With Me
            If .txtMadridProtocolSerialNumber.Text.Length > 0 Then
                .txtMadridProtocolSerialNumber.BackColor = clrLightGreen
                .btnMadridProtocolSerialNumber.Enabled = True
                .btnMadridProtocolSerialNumber.Text = "Done"
                .AcceptButton = btnMadridProtocolSerialNumber
                If .txtMadridProtocolSerialNumber.Text.Length > 30 Then
                    Call msgThisFieldCantBeLongerThan(.txtMadridProtocolSerialNumber.Text.Length - 1)
                    .txtMadridProtocolSerialNumber.Text = Microsoft.VisualBasic.Left(.txtMadridProtocolSerialNumber.Text, 30)
                    .txtMadridProtocolSerialNumber.SelectionStart = txtMadridProtocolSerialNumber.Text.Length + 1
                End If
            Else
                .txtMadridProtocolSerialNumber.BackColor = clrLemmonChiffon
                .btnMadridProtocolSerialNumber.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtWIPOFilingDate_TextChanged(sender As Object, e As EventArgs) Handles txtWIPOFilingDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer
        Dim tempDate As String

        With Me
            Start = .txtWIPOFilingDate.SelectionStart
            Length = .txtWIPOFilingDate.SelectionLength
            .txtWIPOFilingDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.txtWIPOFilingDate.Text)) > 0 Then
                .txtWIPOFilingDate.Mask = "00/00/0000"
                .txtWIPOFilingDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .txtWIPOFilingDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .txtWIPOFilingDate.SelectionStart = Start
                    .txtWIPOFilingDate.SelectionLength = Length
                End If
                If Len(Trim(.txtWIPOFilingDate.Text)) = 8 Then
                    .grpWIPOFilingDate.BackColor = clrLighestOrange
                    .lblWIPOFilingDate.BackColor = clrLighestOrange
                    tempDate = AddSlashesToStringDate(.txtWIPOFilingDate.Text)
                    WIPOFilingDate = ConvertToRKLDate(tempDate)
                    .txtWIPOFilingDate.Text = tempDate
                    ''''''.btnDoneWIPOFilingDate.Enabled = True
                    ''''''.AcceptButton = .btnDoneWIPOFilingDate
                    .grpWIPOFilingDate.BackColor = clrLighestOrange
                    .lblWIPOFilingDate.BackColor = clrLighestOrange

                    .grpDocketNumberSubDocketNumber.Enabled = True
                    .grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
                    .grpDocketNumber.BackColor = clrOrange
                    .txtDocketNumber.Enabled = True
                    .txtDocketNumber.Focus()
                End If
            Else
                .txtWIPOFilingDate.BackColor = clrLemmonChiffon
                ''''''.btnDoneWIPOFilingDate.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnMadridProtocolSerialNumber_Click(sender As Object, e As EventArgs) Handles btnMadridProtocolSerialNumber.Click
        With Me
            .grpMadridProtocolSerialNumber.BackColor = clrLighestOrange
            .lblMadridProtocolSerialNumber.BackColor = clrLighestOrange
            MadridProtocolSerialNumber = .txtMadridProtocolSerialNumber.Text.ToString

            .grpWIPOFilingDate.Enabled = True
            .grpWIPOFilingDate.BackColor = clrOrange
            .txtWIPOFilingDate.Enabled = True
            .txtWIPOFilingDate.Focus()
        End With
    End Sub

    Private Sub txtFirstUseDate_TextChanged(sender As Object, e As EventArgs) Handles txtFirstUseDate.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer
        Dim tempDate As String

        With Me
            Start = .txtFirstUseDate.SelectionStart
            Length = .txtFirstUseDate.SelectionLength
            .txtFirstUseDate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.txtFirstUseDate.Text)) > 0 Then
                .txtFirstUseDate.Mask = "00/00/0000"
                .txtFirstUseDate.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .txtFirstUseDate.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .txtFirstUseDate.SelectionStart = Start
                    .txtFirstUseDate.SelectionLength = Length
                End If
                If Len(Trim(.txtFirstUseDate.Text)) = 8 Then
                    tempDate = AddSlashesToStringDate(.txtFirstUseDate.Text)
                    RegistrationIssueDate = ConvertToRKLDate(tempDate)
                    .txtFirstUseDate.Text = tempDate
                    .txtFirstUseDate.Mask = "00/00/0000"
                    .btnFirstUseDate.Enabled = True
                    .AcceptButton = btnFirstUseDate

                    ''''''.grpUseMark.BackColor = clrLighestOrange
                    ''''''.lblUseMark.BackColor = clrLighestOrange

                    ''''''.grpTMSerNumDate.Enabled = True
                    ''''''.grpTMSerNumDate.BackColor = clrLighestOrange

                    ''''''.grpEnterTMSerNum.Enabled = True
                    ''''''.grpEnterTMSerNum.BackColor = clrOrange
                    ''''''.lblEnterTMSerNum.Enabled = True
                    ''''''.lblEnterTMSerNum.BackColor = clrOrange
                    ''''''.txtEnterTMSerNum.Enabled = True
                    ''''''.txtEnterTMSerNum.Focus()
                Else
                    .btnFirstUseDate.Enabled = False
                End If
            Else
                .txtFirstUseDate.BackColor = clrLemmonChiffon
                .btnFirstUseDate.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnFirstUseDate_Click(sender As Object, e As EventArgs) Handles btnFirstUseDate.Click
        With Me
            '.grpCategoryOfTrademarkType.BackColor = clrLighestOrange
            .grpFirstUseDate.BackColor = clrLighestOrange
            .lblFirstUseDate.BackColor = clrLighestOrange

            .grpFirstUseDateInCommerce.Enabled = True
            .grpFirstUseDateInCommerce.BackColor = clrOrange
            .lblFirstUseDateInCommerce.BackColor = clrOrange
            .txtFirstUseDateInCommerce.Focus()

            '''''.grpDocketNumberSubDocketNumber.Enabled = True
            '''''.grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
            '''''.grpDocketNumber.BackColor = clrOrange
            '''''.txtDocketNumber.Enabled = True
            '''''.txtDocketNumber.Focus()
        End With
    End Sub

    Private Sub btnWIPOFilingDate_Click(sender As Object, e As EventArgs)
        With Me
            .grpWIPOFilingDate.BackColor = clrLighestOrange
            .lblWIPOFilingDate.BackColor = clrLighestOrange

            .grpDocketNumberSubDocketNumber.Enabled = True
            .grpDocketNumberSubDocketNumber.BackColor = clrLighestOrange
            .grpDocketNumber.BackColor = clrOrange
            .txtDocketNumber.Enabled = True
            .txtDocketNumber.Focus()
        End With
    End Sub

    Private Sub txtForeignClientReferenceNumber_TextChanged(sender As Object, e As EventArgs) Handles txtForeignClientReferenceNumber.TextChanged
        With Me
            If .txtForeignClientReferenceNumber.Text.Length > 0 Then
                .txtForeignClientReferenceNumber.BackColor = clrLightGreen
                .btnForeignClientReferenceNumber.Enabled = True
                .btnForeignClientReferenceNumber.Text = "Done"
                .AcceptButton = btnForeignClientReferenceNumber
            Else
                .txtForeignClientReferenceNumber.BackColor = clrLemmonChiffon
                .btnForeignClientReferenceNumber.Text = "NONE"
                .AcceptButton = btnForeignClientReferenceNumber
            End If
        End With
    End Sub

    Private Sub btnForeignClientReferenceNumber_Click(sender As Object, e As EventArgs) Handles btnForeignClientReferenceNumber.Click
        With Me
            If .btnForeignClientReferenceNumber.Text = "NONE" Then
                .txtForeignClientReferenceNumber.Text = "NONE"
                .grpForeignClientReferenceNumber.BackColor = clrLighestOrange
                .lblForeignClientReferenceNumber.BackColor = clrLighestOrange

                .grpInputOfMark.Enabled = True
                .grpInputOfMark.BackColor = clrOrange
                .lblInputOfMarkInstructions.Enabled = True
                .lblInputOfMarkInstructions.BackColor = clrOrange
                .rtbInputOfMark.Focus()
            Else
                .grpForeignClientReferenceNumber.BackColor = clrLighestOrange
                .lblForeignClientReferenceNumber.BackColor = clrLighestOrange

                .grpInputOfMark.Enabled = True
                .grpInputOfMark.BackColor = clrOrange
                .lblInputOfMarkInstructions.Enabled = True
                .lblInputOfMarkInstructions.BackColor = clrOrange
                .rtbInputOfMark.Focus()

            End If
        End With
    End Sub

    Private Sub txtCountryCode_TextChanged(sender As Object, e As EventArgs) Handles txtCountryCode.TextChanged
        With Me
            If .txtCountryCode.Text.Length > 0 Then
                .txtCountryCode.BackColor = clrLightGreen
                .btnCountryCode.Enabled = True
                '.btnCountryCode.Text = "Done"
                .AcceptButton = btnCountryCode
                If .txtCountryCode.Text.Length > 3 Then
                    Call msgThisFieldCantBeLongerThan(.txtCountryCode.Text.Length - 1)
                    .txtCountryCode.Text = Microsoft.VisualBasic.Left(.txtCountryCode.Text, 3)
                    .txtCountryCode.SelectionStart = txtCountryCode.Text.Length + 1
                End If
            Else
                .txtCountryCode.BackColor = clrLemmonChiffon
                .btnCountryCode.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnCountryCode_Click(sender As Object, e As EventArgs) Handles btnCountryCode.Click
        With Me
            .grpCountryCode.BackColor = clrLighestOrange
            .lblCountryCode.BackColor = clrLighestOrange

            GroupInDocumentInitialInput = "grpTrademarkOwnersEntityStatus"
            .grpTrademarkOwnersEntityStatus.Enabled = True
            .grpTrademarkOwnersEntityStatus.BackColor = clrOrange
            For I = 0 To 2
                .rdoArrayTrademarkOwnersEntityStatus.rdoItem(I).Enabled = True
            Next
            'NOTE: THE NEXT LINE IS TEMPORARY UNTIL MORT SAYS TO LET THE USER PICK WHICH ON
            .rdoArrayTrademarkOwnersEntityStatus.rdoItem(0).Select()
            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            .grpSelectResponsibleAttorney.Enabled = True
            .grpSelectResponsibleAttorney.BackColor = clrOrange
            .lstSelectResponsibleAttorney.Enabled = True
            .lstSelectResponsibleAttorney.Focus()
        End With
    End Sub
End Class