Public Class ButtonArray
    Inherits System.Collections.CollectionBase
    Public btnControlArray As Button
    Public btnIndex As Integer
    Private ReadOnly btnHostForm As System.Windows.Forms.Form
    Public Function AddNewButton(ByVal ButtonText As String, btnLeft As Integer, btnTop As Integer) As System.Windows.Forms.Button
        ' Create a new instance of the Button class
        Dim aButton As New System.Windows.Forms.Button()
        ' Add the button to the collection's internal list
        Me.List.Add(aButton)
        ' Add the button to the controls collection of the form referenced by the btnHostForm Field
        btnHostForm.Controls.Add(aButton)
        ' Set initial properties for the Button object
        Select Case CurrentFormName
            Case "frmMainMenu", "frmMainMenu2"
                aButton.Top = Count * 65 ' 40  '25
                aButton.Left = 85  '175
                aButton.Width = 650  '500
                aButton.Height = 45
                aButton.FlatStyle = FlatStyle.Popup
                aButton.Font = RKLFont16BI
                aButton.BackColor = Color.LightGray
                aButton.Tag = Me.Count
                ''''Select Case Count
                ''''    Case 1
                ''''        aButton.Text = "This is the &First Button"
                ''''    Case 2
                ''''        aButton.Text = "This is the &Second Button"
                ''''    Case 3
                ''''        aButton.Text = "This is the &Third Button"
                ''''End Select
                aButton.Text = "Marv Button " & Me.Count.ToString
                aButton.Text = ButtonText
            Case "frmInitialTrademarkDocumentInputTabs"
                Select Case GroupInDocumentInputTabs
                    Case "grpReviewEachOfficeAction"
                        aButton.Top = btnTop
                        aButton.Left = btnLeft
                        aButton.Width = 65  '70
                        aButton.Height = 26  '45
                        aButton.FlatStyle = FlatStyle.Popup
                        aButton.Font = RKLFont11B
                        aButton.BackColor = Color.LightGray
                        aButton.Tag = Me.Count
                        aButton.Text = ButtonText
                End Select
            Case "frmMethodsOfReferencingTrademarksForScreenDisplay"
                aButton.Top = btnTop
                aButton.Left = btnLeft
                aButton.Width = 130  '650  '500
                aButton.Height = 28  '45
                aButton.FlatStyle = FlatStyle.Popup
                aButton.Font = RKLFont12B
                aButton.BackColor = Color.LightGray
                aButton.Tag = Me.Count
                'Select Case Count
                '    Case 1
                '        aButton.Text = "This is the &First Button"
                '    Case 2
                '        aButton.Text = "This is the &Second Button"
                '    Case 3
                '        aButton.Text = "This is the &Third Button"
                'End Select
                'aButton.Text = "Marv Button " & Me.Count.ToString
                aButton.Text = ButtonText
            Case "frmTrademarkDisplayOrParameterChanges"
                aButton.Top = btnTop
                aButton.Left = btnLeft
                aButton.Width = 18  '650  '500
                aButton.Height = 14  '45
                aButton.FlatStyle = FlatStyle.Popup
                aButton.Font = RKLFont8B
                aButton.BackColor = Color.LightGray
                aButton.Tag = Me.Count
                aButton.Text = ButtonText
        End Select
        AddHandler aButton.Click, AddressOf ClickHandler
        Return aButton
    End Function
    Public Sub New(ByVal host As System.Windows.Forms.Form)
        btnHostForm = host
    End Sub
    Default Public ReadOnly Property Item(ByVal Index As Integer) As System.Windows.Forms.Button
        Get
            btnIndex = Index '- 1
            'UpperBound = Collection.Items.Count - 1, or UpperBound = UBound(Array) 

            'Return CType(Me.List.Item(Index), System.Windows.Forms.Button)
            Return CType(Me.List.Item(btnIndex), System.Windows.Forms.Button)
        End Get
    End Property
    Public Sub Remove(ByVal ButtonToBeRemoved As Integer)
        ' Check to be sure there is a button to remove
        ''''If Me.Count > 0 Then
        ' Remove the last button added to the array from the host form
        ' controls collection.  NOTE: The use of the default property in
        ' accessing the array.
        ''''btnHostForm.Controls.Remove(Me(Me.Count - 1))
        btnHostForm.Controls.Remove(Me(ButtonToBeRemoved))
        ''''Me.List.RemoveAt(Me.Count - 1)
        Me.List.RemoveAt(ButtonToBeRemoved)
        ''''End If
    End Sub
    Public Sub ClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tempDocketNumber As String
        Dim DocketNumberFound As String
        Dim tempSubDocketNumber As String
        Dim tempResponse As Integer

        '''''MessageBox.Show("You have clicked button " & CType(CType(sender, System.Windows.Forms.Button).Tag, String))
        ButtonNumberClicked = CType(sender, System.Windows.Forms.Button).Tag
        ''''MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)
        ''''Call DisplayMenu("MainMenu")
        Select Case CurrentFormName
            Case "frmMainMenu", "frmMainMenu2"
                Select Case MenuLevel
                    Case 1
                        Select Case ButtonNumberClicked
                            Case 1
                                Call DisplayMenu("TypeOfTradeMarkDocument")
                            Case 2
                                'frmMethodsOfReferencingTrademarksForScreenDisplay.Close()
                                CurrentFormName = "frmMethodsOfReferencingTrademarksForScreenDisplay"
                                frmMethodsOfReferencingTrademarksForScreenDisplay.Show()
                            Case 3
                                'frmInitialTrademarkDocumentInput4.Show()
                                ''''''frmTestToTriggerError.ShowDialog()
                            Case 4
                                PressCapsLockKey(VK_CAPITAL) 'Turn CapsLock Off                       
                                End
                        End Select
                    Case 2
                        Select Case ButtonNumberClicked
                            Case 1
                                TrademarkType = "Federal Trademark Application"
                                frmInitialTrademarkApplicationInput.Show()
                            Case 2
                                TrademarkType = "Federal Trademark Registration"
                                frmInitialTrademarkApplicationInput.Show()
                            Case 3

                            Case 4

                        End Select
                    Case 3
                        Select Case ButtonNumberClicked
                            Case 1
                                'frmInitialTrademarkDocumentInput4.Show()
                            Case 2

                            Case 3

                            Case 4

                            Case 5

                            Case 6

                            Case 7

                        End Select
                End Select
            Case "frmInitialTrademarkDocumentInputTabs"
                Select Case GroupInDocumentInputTabs
                    Case "grpReviewEachOfficeAction"
                        With frmInitialTrademarkApplicationInputTabs
                            If NowReviewing1To6 = False Then
                                For I = 6 To 11
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Visible = False
                                Next
                                For I = 0 To 5
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Visible = True
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Checked = False
                                Next
                                .btnArrayReviewNextOfficeActionsGroup.Item(0).Text = ">>7-12"
                                NowReviewing1To6 = True
                                'NowReviewing7To12 = True
                            ElseIf NowReviewing1To6 = True Then
                                For I = 0 To 5
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Visible = False
                                Next
                                For I = 6 To 11
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Visible = True
                                    .rdoArrayReviewEachOfficeAction.rdoItem(I).Checked = False
                                Next
                                .btnArrayReviewNextOfficeActionsGroup.Item(0).Text = "<<1-6"
                                NowReviewing1To6 = False
                                'NowReviewing7To12 = False
                            End If
                        End With
                End Select
            Case "frmMethodsOfReferencingTrademarksForScreenDisplay"
                Select Case ButtonNumberClicked
                    Case 1  'By General Docket Number
                        'MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)

                        'Now Get and Display the current Client Name for entered Docket Number in
                        '   the RKLAccountDB And the Docket Table
                        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
                        OpenTableInRKLTrademarkDB("TrademarkDocuments")

                        With adoRKLTrademarkRecordset
                            Do Until .EOF
                                tempDocketNumber = .Fields!DocketNumber.Value.ToString   '("DocketNumber").ToString
                                'frmMethodsOfReferencingTrademarksForScreenDisplay.btnArrayMethodOfReference.Item(0).Text = "Looking..."
                                If frmMethodsOfReferencingTrademarksForScreenDisplay.txtByGeneralDocketNumber.Text = Trim(tempDocketNumber) Then
                                    'Hold the selected Docket Number plus other values for later use
                                    CurrentRKLDocket = Trim$(frmMethodsOfReferencingTrademarksForScreenDisplay.txtByGeneralDocketNumber.Text)
                                    'Hold the Bookmark of this record
                                    BookmarkOfRecordFoundDuringOKDisplay = .Bookmark

                                    AbsolutePositionOfRecordFoundDuringOKDisplay = .AbsolutePosition
                                    'Now Count the Number of Records that match the CurrentRKLDocket
                                    DocketNumberFound = CurrentRKLDocket
                                    CountOfRecordsForThisGeneralDocketNumber = 1
                                    Do Until DocketNumberFound <> CurrentRKLDocket
                                        .MoveNext()
                                        If .EOF Then Exit Do
                                        DocketNumberFound = Trim$(.Fields!DocketNumber.Value.ToString)
                                        If DocketNumberFound = CurrentRKLDocket Then
                                            CountOfRecordsForThisGeneralDocketNumber = CountOfRecordsForThisGeneralDocketNumber + 1
                                        Else
                                            Exit Do
                                        End If
                                    Loop

                                    With frmMethodsOfReferencingTrademarksForScreenDisplay
                                        '.btnArrayMethodOfReference.Item(0).Text = "F o u n d !"
                                        '.btnArrayMethodOfReference.Item(0).BackColor = Color.LawnGreen
                                        CloseTableInRKLTrademarkDB()
                                        CloseConnectionToRKLTrademarkDB()
                                        .btnDone.Enabled = True
                                        .btnDone.ForeColor = Color.Black
                                        .btnDone.BackColor = clrOrange
                                        .AcceptButton = .btnDone
                                    End With
                                    Exit Sub
                                End If
                                .MoveNext()
                            Loop
                        End With

                        With frmMethodsOfReferencingTrademarksForScreenDisplay
                            Call msgDocketNumberNotFound(.txtByGeneralDocketNumber.Text)
                            CloseTableInRKLTrademarkDB()
                            CloseConnectionToRKLTrademarkDB()
                            '.btnArrayMethodOfReference.Item(0).Text = "Look-This-Up"
                            .txtByGeneralDocketNumber.Text = ""
                            .txtByGeneralDocketNumber.Focus()
                        End With

                    Case 2   'By Docket Number before Sub-Docket Number
                        'MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)
                        'Now the see if entered Sub-Docket Number for the entered Docket Number is in the RKLTrademarkDB
                        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
                        OpenTableInRKLTrademarkDB("TrademarkDocuments")

                        With adoRKLTrademarkRecordset
                            Do Until .EOF
                                tempDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                                With frmMethodsOfReferencingTrademarksForScreenDisplay
                                    '.btnArrayMethodOfReference.Item(1).BackColor = clrGreyGainsboro
                                    '.btnArrayMethodOfReference.Item(2).Text = "Looking..."
                                    If (.txtDocketNumber.Text = tempDocketNumber) Then
                                        BookmarkOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.Bookmark
                                        AbsolutePositionOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.AbsolutePosition

                                        DocketNumber = tempDocketNumber
                                        '.btnArrayMethodOfReference.Item(1).Text = "F o u n d !"
                                        '.btnArrayMethodOfReference.Item(1).BackColor = Color.LawnGreen
                                        CloseTableInRKLTrademarkDB()
                                        CloseConnectionToRKLTrademarkDB()
                                        .lblSubDocketNumber.Enabled = True
                                        .txtSubDocketNumber.Enabled = True
                                        .txtSubDocketNumber.Focus()
                                        Exit Sub
                                    End If
                                End With
                                .MoveNext()
                            Loop
                        End With

                        With frmMethodsOfReferencingTrademarksForScreenDisplay
                            Call msgDocketNumberNotFoundWhileTryingToDisplayRecords(tempResponse, .txtDocketNumber.Text)
                            Select Case tempResponse
                                Case 6 'Yes
                                    '.btnArrayMethodOfReference.Item(1).BackColor = clrGreyGainsboro
                                    '.btnArrayMethodOfReference.Item(1).Text = "Look-This-Up"
                                    .txtDocketNumber.Text = ""
                                    .txtDocketNumber.Focus()
                                Case 7 'No
                                    .btnReset.PerformClick()
                            End Select
                            CloseTableInRKLTrademarkDB()
                            CloseConnectionToRKLTrademarkDB()
                            Exit Sub
                        End With

                    Case 3  'By Sub-Docket Number After Docket Number is Entered
                        'MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)


                        'Now the see if entered Sub-Docket Number for the entered Docket Number is in the RKLTrademarkDB
                        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
                        OpenTableInRKLTrademarkDB("TrademarkDocuments")

                        With adoRKLTrademarkRecordset
                            Do Until .EOF
                                tempDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                                tempSubDocketNumber = Trim(.Fields!SubDocketNumber.Value.ToString)

                                With frmMethodsOfReferencingTrademarksForScreenDisplay
                                    '.btnArrayMethodOfReference.Item(2).BackColor = clrGreyGainsboro
                                    '.btnArrayMethodOfReference.Item(2).Text = "Looking..."
                                    If (.txtDocketNumber.Text = tempDocketNumber) And
                                               (.txtSubDocketNumber.Text = tempSubDocketNumber) Then

                                        BookmarkOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.Bookmark
                                        AbsolutePositionOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.AbsolutePosition

                                        DocketNumber = tempDocketNumber
                                        SubDocketNumber = tempSubDocketNumber
                                        '.btnArrayMethodOfReference.Item(2).Text = "F o u n d !"
                                        '.btnArrayMethodOfReference.Item(2).BackColor = Color.LawnGreen
                                        CloseTableInRKLTrademarkDB()
                                        CloseConnectionToRKLTrademarkDB()
                                        .btnDone.Enabled = True
                                        .btnDone.BackColor = clrOrange
                                        .AcceptButton = .btnDone
                                        Exit Sub
                                    End If
                                End With
                                .MoveNext()
                            Loop
                        End With

                        With frmMethodsOfReferencingTrademarksForScreenDisplay
                            Call msgSubDocketNumberNotFoundWhileTryingToDisplayRecords(tempResponse, .txtDocketNumber.Text, .txtSubDocketNumber.Text)
                            Select Case tempResponse
                                Case 6 'Yes
                                    '.btnArrayMethodOfReference.Item(2).BackColor = clrGreyGainsboro
                                    '.btnArrayMethodOfReference.Item(2).Text = "Look-This-Up"
                                    .txtSubDocketNumber.Text = ""
                                            .txtSubDocketNumber.Focus()
                                        Case 7 'No
                                            .btnReset.PerformClick()
                                    End Select
                                    CloseTableInRKLTrademarkDB()
                                    CloseConnectionToRKLTrademarkDB()
                                    Exit Sub
                                End With
                        End Select
            Case Else
                End
        End Select
    End Sub
End Class
