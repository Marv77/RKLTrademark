Public Class frmMethodsOfReferencingTrademarksForScreenDisplay
    Public OrigForeColor As Color
    Public OrigBackColor As Color
    'Public btnArrayMethodOfReference As ButtonArray
    Public rdoArrayMethodOfReference As RadioButtonArray

    Private Sub frmMethodsOfReferencingTrademarksForScreenDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim BlankNameOfMethodOfReference As String
        Dim LeftMethodOfReference As Integer
        Dim TopMethodOfReference As Integer

        CurrentFormName = "frmMethodsOfReferencingTrademarksForScreenDisplay"
        IntialLoadOfThisFormCompleted = False

        With Me
            .WindowState = FormWindowState.Maximized
            .lblFormTitle.Font = RKLFont16B
            .lblFormTitle.Text = "Trademark Document Dispaly or Change" & vbCrLf & "Method of Referencing Tradmark Documents Stored in the Computer"

            rdoArrayMethodOfReference = New RadioButtonArray(Me)
            'btnArrayMethodOfReference = New ButtonArray(Me)
            BlankNameOfMethodOfReference = "MethodOfReference"
            LeftMethodOfReference = 15
            TopMethodOfReference = 20

            .grpByGeneralDocketNumber.Font = RKLFont14B
            .grpByGeneralDocketNumber.Text = "1. By A General Docket Number"
            .grpByGeneralDocketNumber.Controls.Add(rdoArrayMethodOfReference.AddNewRadioButton(BlankNameOfMethodOfReference, LeftMethodOfReference, TopMethodOfReference))
            .lblByGeneralDocketNumber.Font = RKLFont14BI
            .lblByGeneralDocketNumber.Text = "Insert General Docket Number:"
            .txtByGeneralDocketNumber.Text = ""
            .txtByGeneralDocketNumber.Font = RKLFont12B
            .btnGeneralDocketNumber.Font = RKLFont11B
            .btnGeneralDocketNumber.Text = "Look-This-Up"
            .btnGeneralDocketNumber.Enabled = False

            '.grpByGeneralDocketNumber.Controls.Add(btnArrayMethodOfReference.AddNewButton("Look-This-Up", 865, 20))

            .lblByGeneralDocketNumber.Enabled = False
            .txtByGeneralDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(1).Enabled = False

            .grpByDocketNumberSubDocketNumber.Font = RKLFont14B
            .grpByDocketNumberSubDocketNumber.Text = "2. By A Specific Docket/Sub-Docket Number"
            .grpByDocketNumberSubDocketNumber.Controls.Add(rdoArrayMethodOfReference.AddNewRadioButton(BlankNameOfMethodOfReference, LeftMethodOfReference, TopMethodOfReference))
            .lblDocketNumber.Font = RKLFont14BI
            .lblDocketNumber.Text = "Insert Specific Docket Number:"
            .txtDocketNumber.Font = RKLFont12B
            .txtDocketNumber.Text = ""
            .btnDocketNumber.Font = RKLFont11B
            .btnDocketNumber.Text = "Look-This-Up"
            .btnDocketNumber.Enabled = False

            '.grpByDocketNumberSubDocketNumber.Controls.Add(btnArrayMethodOfReference.AddNewButton("Look-This-Up", 542, 22))

            .lblDocketNumber.Enabled = False
            .txtDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(2).Enabled = False

            .lblSubDocketNumber.Font = RKLFont14BI
            .lblSubDocketNumber.Text = "Insert Specific Sub-Docket Number:"
            .txtSubDocketNumber.Font = RKLFont12B
            .txtSubDocketNumber.Text = ""
            .btnSubDocketNumber.Font = RKLFont11B
            .btnSubDocketNumber.Text = "Look-This-Up"
            .btnSubDocketNumber.Enabled = False

            '.grpByDocketNumberSubDocketNumber.Controls.Add(btnArrayMethodOfReference.AddNewButton("Look-This-Up", 1195, 22))

            .lblSubDocketNumber.Enabled = False
            .txtSubDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(3).Enabled = False

            .btnDone.Font = RKLFont16BI
            OrigBackColor = .btnDone.BackColor
            OrigForeColor = .btnDone.ForeColor
            .btnDone.Text = " D o n e - OK to Display "
            .btnDone.Enabled = False
            .btnReset.Font = RKLFont16BI
            .btnReset.Text = " Reset "
            .btnReset.Enabled = False
            .btnCancel.Font = RKLFont16BI
            .btnCancel.Text = " Cancel "
        End With
        IntialLoadOfThisFormCompleted = True
    End Sub

    Private Sub txtSubDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSubDocketNumber.TextChanged
        With Me
            If Len(.txtSubDocketNumber.Text) > 0 Then
                .txtSubDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen                
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(3).Enabled = True
                    '.AcceptButton = btnArrayMethodOfReference.Item(3)
                End If
            Else
                .txtSubDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(3).Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub txtByGeneralDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtByGeneralDocketNumber.TextChanged
        Dim tempByGeneralDocketNumber As String

        With Me
            tempByGeneralDocketNumber = Trim(.txtByGeneralDocketNumber.Text)
            'If Len(.txtByGeneralDocketNumber.Text) > 0 Then
            If Len(tempByGeneralDocketNumber) > 0 Then
                .btnReset.Enabled = True
                .txtByGeneralDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen                
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(1).Enabled = True
                    '.AcceptButton = btnArrayMethodOfReference.Item(1)
                    .btnGeneralDocketNumber.Enabled = True
                    .AcceptButton = .btnGeneralDocketNumber
                End If
            Else
                .txtByGeneralDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(1).Enabled = False
                    .btnGeneralDocketNumber.Enabled = False
                End If
                .btnReset.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtDocketNumber.TextChanged
        With Me
            If Len(.txtDocketNumber.Text) > 0 Then
                .txtDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen                
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(2).Enabled = True
                    '.AcceptButton = btnArrayMethodOfReference.Item(2)
                    .btnDocketNumber.Enabled = True
                    .AcceptButton = .btnDocketNumber
                End If
            Else
                .txtDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(2).Enabled = False
                    .btnDocketNumber.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub txtSubDocketNumberNEW_TextChanged(sender As Object, e As EventArgs) Handles txtSubDocketNumber.TextChanged
        With Me
            If Len(.txtSubDocketNumber.Text) > 0 Then
                .txtSubDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen                
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(3).Enabled = True
                    '.AcceptButton = btnArrayMethodOfReference.Item(3)
                    .btnSubDocketNumber.Enabled = True
                    .AcceptButton = .btnSubDocketNumber
                End If
            Else
                .txtSubDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                If IntialLoadOfThisFormCompleted = True Then
                    'btnArrayMethodOfReference.Item(3).Enabled = False
                    .btnSubDocketNumber.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim tempEnteredGeneralDocketNumber As String
        Dim tempEnteredDocketNumber As String
        Dim tempDBDocketNumber As String
        Dim DocketNumberFound As String
        Dim tempEnteredSubDoocketNumber As String
        Dim tempDBSubDoocketNumber As String

        CountOfRecordsForThisGeneralDocketNumber = 0

        Select Case RadioButtonNumberClicked
            Case 1 'By General Docket Number
                tempEnteredGeneralDocketNumber = Trim(Me.txtByGeneralDocketNumber.Text.ToString)

                OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
                OpenTableInRKLTrademarkDB("TrademarkDocuments")

                With adoRKLTrademarkRecordset
                    Do Until .EOF
                        If .EOF Then
                            MessageBox.Show("Now at the END of the DB " & RadioButtonNumberClicked.ToString)
                        End If
                        tempDBDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                        If tempEnteredGeneralDocketNumber = tempDBDocketNumber Then
                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                            CountOfRecordsForThisGeneralDocketNumber = 1
                            'Hold the selected Docket Number plus other values for later use
                            CurrentRKLDocket = tempEnteredGeneralDocketNumber
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
                            frmTrademarkDisplayOrParameterChanges.Show()
                            frmTrademarkDisplayOrParameterChanges.txtFullDocketNumber.Focus()
                            Exit Do
                        End If
                        .MoveNext()
                    Loop
                End With
            Case 2 'By Docket Number and SubDocket Number
                tempEnteredDocketNumber = Trim(Me.txtDocketNumber.Text.ToString)
                tempEnteredSubDoocketNumber = Trim(Me.txtSubDocketNumber.Text.ToString)
                OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
                OpenTableInRKLTrademarkDB("TrademarkDocuments")

                With adoRKLTrademarkRecordset
                    Do Until .EOF
                        If .EOF Then
                            MessageBox.Show("Now at the END of the DB " & RadioButtonNumberClicked.ToString)
                        End If
                        tempDBDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                        tempDBSubDoocketNumber = Trim(.Fields!SubDocketNumber.Value.ToString)
                        If (tempEnteredDocketNumber = tempDBDocketNumber) And
                            (tempEnteredSubDoocketNumber = tempDBSubDoocketNumber) Then

                            Call AssignTrademarkRecordToDisplayFormFields(Me)
                            frmTrademarkDisplayOrParameterChanges.Show()
                            Exit Do
                        End If
                        .MoveNext()
                    Loop
                End With

        End Select
        IntialLoadOfThisFormCompleted = False
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With Me
            For I = 0 To 1
                rdoArrayMethodOfReference.rdoItem(I).Checked = False
            Next
            .grpByGeneralDocketNumber.Enabled = True
            .grpByGeneralDocketNumber.BackColor = clrLightestGray
            .lblByGeneralDocketNumber.Enabled = False
            .lblByGeneralDocketNumber.BackColor = clrLightestGray
            .txtByGeneralDocketNumber.Text = ""
            .txtByGeneralDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(1).Text = "Look-This-Up"
            'btnArrayMethodOfReference.Item(1).BackColor = clrGreyGainsboro
            'btnArrayMethodOfReference.Item(1).Enabled = False

            .grpByDocketNumberSubDocketNumber.Enabled = True
            .grpByDocketNumberSubDocketNumber.BackColor = clrLightestGray
            .lblDocketNumber.Enabled = False
            .lblDocketNumber.BackColor = clrLightestGray
            .txtDocketNumber.Text = ""
            .txtDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(2).Text = "Done"
            'btnArrayMethodOfReference.Item(2).BackColor = clrGreyGainsboro
            'btnArrayMethodOfReference.Item(2).Enabled = False

            .lblSubDocketNumber.Enabled = False
            .lblSubDocketNumber.BackColor = clrLightestGray
            .txtSubDocketNumber.Text = ""
            .txtSubDocketNumber.Enabled = False
            'btnArrayMethodOfReference.Item(3).Text = "Look-This-Up"
            'btnArrayMethodOfReference.Item(3).BackColor = clrGreyGainsboro
            'btnArrayMethodOfReference.Item(3).Enabled = False

            '.AcceptButton = .btnCancel
            .btnDone.ForeColor = OrigForeColor 'clrGreyGainsboro 'Color.DimGray
            .btnDone.BackColor = OrigBackColor 'clrSilverGray 'clrDarkGray 'clrGreyGainsboro
            .btnDone.Enabled = False

            .btnReset.Enabled = False
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
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

    Private Sub btnGeneralDocketNumber_Click(sender As Object, e As EventArgs) Handles btnGeneralDocketNumber.Click
        Dim tempDocketNumber As String
        Dim DocketNumberFound As String
        'Dim tempSubDocketNumber As String
        'Dim tempResponse As Integer

        Me.btnGeneralDocketNumber.BackColor = clrYellow
        Me.btnGeneralDocketNumber.Text = "Looking..."

        'Now Get and Display the current Client Name for entered Docket Number in
        '   the RKLAccountDB And the Docket Table
        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        OpenTableInRKLTrademarkDB("TrademarkDocuments")

        With adoRKLTrademarkRecordset
            Do Until .EOF
                tempDocketNumber = .Fields!DocketNumber.Value.ToString   '("DocketNumber").ToString
                'frmMethodsOfReferencingTrademarksForScreenDisplay.btnArrayMethodOfReference.Item(0).Text = "Looking..."
                If Me.txtByGeneralDocketNumber.Text = Trim(tempDocketNumber) Then
                    'Hold the selected Docket Number plus other values for later use
                    CurrentRKLDocket = Trim$(Me.txtByGeneralDocketNumber.Text)
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

                    With Me
                        '.btnArrayMethodOfReference.Item(0).Text = "F o u n d !"
                        '.btnArrayMethodOfReference.Item(0).BackColor = Color.LawnGreen
                        .btnGeneralDocketNumber.BackColor = Color.LawnGreen
                        .btnGeneralDocketNumber.Text = "F o u n d !"
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

        With Me
            Call msgDocketNumberNotFound(.txtByGeneralDocketNumber.Text)
            CloseTableInRKLTrademarkDB()
            CloseConnectionToRKLTrademarkDB()
            '.btnArrayMethodOfReference.Item(0).Text = "Look-This-Up"
            .txtByGeneralDocketNumber.Text = ""
            .txtByGeneralDocketNumber.Focus()
        End With

    End Sub

    Private Sub btnDocketNumber_Click(sender As Object, e As EventArgs) Handles btnDocketNumber.Click
        'By Docket Number before Sub-Docket Number
        Dim tempDocketNumber As String
        'Dim DocketNumberFound As String
        'Dim tempSubDocketNumber As String
        Dim tempResponse As Integer

        Me.btnDocketNumber.BackColor = clrYellow
        Me.btnDocketNumber.Text = "Looking..."

        'Now the see if entered Sub-Docket Number for the entered Docket Number is in the RKLTrademarkDB
        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        OpenTableInRKLTrademarkDB("TrademarkDocuments")

        With adoRKLTrademarkRecordset
            Do Until .EOF
                tempDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                With Me
                    '.btnArrayMethodOfReference.Item(1).BackColor = clrGreyGainsboro
                    '.btnArrayMethodOfReference.Item(2).Text = "Looking..."
                    If (.txtDocketNumber.Text = tempDocketNumber) Then
                        BookmarkOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.Bookmark
                        AbsolutePositionOfRecordFoundDuringOKDisplay = adoRKLTrademarkRecordset.AbsolutePosition

                        DocketNumber = tempDocketNumber
                        '.btnArrayMethodOfReference.Item(1).Text = "F o u n d !"
                        '.btnArrayMethodOfReference.Item(1).BackColor = Color.LawnGreen
                        .btnDocketNumber.BackColor = Color.LawnGreen
                        .btnDocketNumber.Text = "F o u n d !"
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

        With Me
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
    End Sub

    Private Sub btnSubDocketNumber_Click(sender As Object, e As EventArgs) Handles btnSubDocketNumber.Click
        'By Sub-Docket Number After Docket Number is Entered
        Dim tempDocketNumber As String
        Dim tempSubDocketNumber As String
        Dim tempResponse As Integer

        Me.btnSubDocketNumber.BackColor = clrYellow
        Me.btnSubDocketNumber.Text = "Looking..."

        'Now the see if entered Sub-Docket Number for the entered Docket Number is in the RKLTrademarkDB
        OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
        OpenTableInRKLTrademarkDB("TrademarkDocuments")

        With adoRKLTrademarkRecordset
            Do Until .EOF
                tempDocketNumber = Trim(.Fields!DocketNumber.Value.ToString)
                tempSubDocketNumber = Trim(.Fields!SubDocketNumber.Value.ToString)

                With Me
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
                        .btnSubDocketNumber.BackColor = Color.LawnGreen
                        .btnSubDocketNumber.Text = "F o u n d !"
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

        With Me
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
    End Sub
End Class