Public Class frmChangeTrademarkDataFields
    Private Sub frmChangeTrademarkDataFields_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tempLenOfSelectedDataFieldNameToBeChanged As Integer
        Dim tempLocationOfTheDot As Integer
        Dim NameOnlyOfSelectedDataFieldToBeChanged

        Dim tempSelectResponsibleAttorney As String

        CurrentFormName = "frmChangeTrademarkDataFields"

        IntialLoadOfThisFormCompleted = False

        With Me
            .lstResponsibleAttorney.Visible = False
            .mskNewDateField.Visible = False

            .Text = "Changing the Value of: " & SelectedDataFieldNameToBeChanged
            .lblFormTitle.Font = RKLFont14B
            .lblFormTitle.Text = "You are Changing the Value of: " & SelectedDataFieldNameToBeChanged

            'Get the Name of the DataField WITHOUT the Number and Dot
            tempLenOfSelectedDataFieldNameToBeChanged = SelectedDataFieldNameToBeChanged.Length
            tempLocationOfTheDot = InStr(SelectedDataFieldNameToBeChanged, ".")
            NameOnlyOfSelectedDataFieldToBeChanged = Mid(SelectedDataFieldNameToBeChanged, tempLocationOfTheDot + 2, tempLenOfSelectedDataFieldNameToBeChanged)

            .lblCurrentDataFieldValue.Font = RKLFont14B
            .lblCurrentDataFieldValue.Text = "Current " & NameOnlyOfSelectedDataFieldToBeChanged.ToString & ":"
            .txtCurrentDataFieldValue.Font = RKLFont14B
            .txtCurrentDataFieldValue.Text = CurrentValueOfSelectedDataField.ToString
            .txtCurrentDataFieldValue.BackColor = clrLightGreen

            .grpNewDataField.Font = RKLFont14BI
            .grpNewDataField.Text = "Enter the New Value for the " & NameOnlyOfSelectedDataFieldToBeChanged.ToString
            .grpNewDataField.BackColor = clrOrange

            Select Case CheckBoxNumberClicked
                Case 1, 2 'Client Docket Number, Country Code
                    '.Text = "Changing the Value of: " & SelectedDataFieldNameToBeChanged
                    '.lblFormTitle.Font = RKLFont14B
                    '.lblFormTitle.Text = "You are Changing the Value of: " & SelectedDataFieldNameToBeChanged

                    ''Get the Name of the DataField WITHOUT the Number and Dot
                    'tempLenOfSelectedDataFieldNameToBeChanged = SelectedDataFieldNameToBeChanged.Length
                    'tempLocationOfTheDot = InStr(SelectedDataFieldNameToBeChanged, ".")
                    'NameOnlyOfSelectedDataFieldToBeChanged = Mid(SelectedDataFieldNameToBeChanged, tempLocationOfTheDot + 2, tempLenOfSelectedDataFieldNameToBeChanged)

                    '.lblCurrentDataFieldValue.Font = RKLFont14B
                    '.lblCurrentDataFieldValue.Text = "Current " & NameOnlyOfSelectedDataFieldToBeChanged.ToString & ":"
                    '.txtCurrentDataFieldValue.Font = RKLFont14B
                    '.txtCurrentDataFieldValue.Text = CurrentValueOfSelectedDataField.ToString
                    '.txtCurrentDataFieldValue.BackColor = clrLightGreen
                    '.txtCurrentDataFieldValue.ReadOnly = True

                    '.grpNewDataField.Font = RKLFont14BI
                    '.grpNewDataField.Text = "Enter the New Value for the " & NameOnlyOfSelectedDataFieldToBeChanged.ToString
                    '.grpNewDataField.BackColor = clrOrange

                    .btnDone.Font = RKLFont16BI
                    .btnDone.Text = "Done"
                    .btnChangeValueToNone.Font = RKLFont8BI
                    .btnChangeValueToNone.Text = "Change Value to 'NONE'"
                    .btnReset.Font = RKLFont16BI
                    .btnReset.Text = "Reset"
                    .btnCancel.Font = RKLFont16BI
                    .btnCancel.Text = "Cancel"

                    .txtNewDataField.Font = RKLFont14B
                    .txtNewDataField.Text = ""
                    '.txtNewDataField.Select()

                Case 3 'Responsible Attorney
                    .txtNewDataField.Visible = False
                    .btnChangeValueToNone.Visible = False

                    .btnDone.Font = RKLFont16BI
                    .btnDone.Text = "Done"
                    .btnDone.Enabled = False
                    '.btnChangeValueToNone.Font = RKLFont8BI
                    '.btnChangeValueToNone.Text = "Change Value to 'NONE'"
                    .btnReset.Font = RKLFont16BI
                    .btnReset.Text = "Reset"
                    .btnReset.Enabled = False
                    .btnCancel.Font = RKLFont16BI
                    .btnCancel.Text = "Cancel"

                    'Add the List of RKL Attorneys
                    .lstResponsibleAttorney.Visible = True
                    .lstResponsibleAttorney.Top = 29
                    .lstResponsibleAttorney.Height = 24
                    .lstResponsibleAttorney.Width = 141

                    '==> There is a problem here with the FONT ==> .lstResponsibleAttorney.Font = RKLFont14B
                    .lstResponsibleAttorney.BackColor = clrLemmonChiffon
                    'Open a new Connection using the RKLAccounting OPEN Routine
                    OpenConnectionToRKLAccountingDB(("rklfeesattorneys.mdb"))
                    'OpenConnectionToRKLTrademarkDB("rklfeesattorneys.mdb")
                    'Open the Attorney Name Table
                    'OpenTableInRKLTrademarkDB("AttorneyNames")
                    OpenTableInRKLAccountingDB("AttorneyNames")
                    With adoRKLAccountingRecordset  'adoRKLTrademarkRecordset
                        Me.lstResponsibleAttorney.Items.Add("Scroll & Click")
                        Do Until .EOF
                            'Get the Attorney Name from the current Record
                            tempSelectResponsibleAttorney = Trim(adoRKLAccountingRecordset.Fields!RKLAttyName.Value.ToString)
                            'Me.lstResponsibleAttorney.Items.Add(Trim(.Fields!RKLAttyName.Value.ToString))Me.lstResponsibleAttorney.Items.Add(Trim(.Fields!RKLAttyName.Value.ToString))
                            Me.lstResponsibleAttorney.Items.Add(tempSelectResponsibleAttorney)
                            .MoveNext()
                        Loop
                    End With
                    Me.lstResponsibleAttorney.TopIndex = 0
                    Me.lstResponsibleAttorney.SetSelected(0, False)
                    'Close the Table and the DB
                    CloseTableInRKLAccountingDB()
                    CloseConnectionToRKLAccountingDB()

                Case 7  'First Use Date in Commerece                    
                    .txtNewDataField.Visible = False
                    '.btnChangeValueToNone.Visible = False
                    .lblFormTitle.Left = 50
                    .lblCurrentDataFieldValue.Left = 120

                    .mskNewDateField.Text = ""
                    .mskNewDateField.Visible = True
                    .mskNewDateField.Top = 30  '24
                    .mskNewDateField.Left = 230
                    .mskNewDateField.Font = RKLFont12B


                    .btnDone.Font = RKLFont16BI
                    .btnDone.Text = "Done"
                    .btnDone.Enabled = False
                    .btnChangeValueToNone.Font = RKLFont8BI
                    .btnChangeValueToNone.Text = "Change Value to 'NONE'"
                    .btnReset.Font = RKLFont16BI
                    .btnReset.Text = "Reset"
                    .btnReset.Enabled = False
                    .btnCancel.Font = RKLFont16BI
                    .btnCancel.Text = "Cancel"
                Case 8
                    .txtNewDataField.Visible = False
                    '.btnChangeValueToNone.Visible = False

                    'Adjust the Form-Controls to fit this Larger Title
                    .Width = 800
                    .lblFormTitle.Left = 60
                    .lblCurrentDataFieldValue.Left = 85
                    .txtCurrentDataFieldValue.Left = 530
                    .txtCurrentDataFieldValue.TextAlign = HorizontalAlignment.Center
                    .grpNewDataField.Width = 650
                    .btnDone.Width = 112
                    .btnDone.Left = 118
                    .btnChangeValueToNone.Width = 112
                    .btnChangeValueToNone.Left = 261
                    .btnReset.Width = 112
                    .btnReset.Left = 404
                    .btnCancel.Width = 112
                    .btnCancel.Left = 547


                    .mskNewDateField.Text = ""
                    .mskNewDateField.Visible = True
                    .mskNewDateField.Top = 30 '24
                    .mskNewDateField.Left = 280  '230
                    .mskNewDateField.Font = RKLFont12B

                    .btnDone.Font = RKLFont16BI
                    .btnDone.Text = "Done"
                    .btnDone.Enabled = False
                    .btnChangeValueToNone.Font = RKLFont8BI
                    .btnChangeValueToNone.Text = "Change Value to 'NONE'"
                    .btnReset.Font = RKLFont16BI
                    .btnReset.Text = "Reset"
                    .btnReset.Enabled = False
                    .btnCancel.Font = RKLFont16BI
                    .btnCancel.Text = "Cancel"

            End Select
        End With
        CurrentFormName = "frmTrademarkDisplayOrParameterChanges"
        IntialLoadOfThisFormCompleted = True
    End Sub
    Private Sub ResetControlsToOrigOnThisForm()
        With Me
            'Adjust the Form-Controls to fit this Larger Title
            .Width = 729
            .lblFormTitle.Left = 113
            .lblCurrentDataFieldValue.Left = 151
            .txtCurrentDataFieldValue.Left = 454
            .txtCurrentDataFieldValue.TextAlign = HorizontalAlignment.Left
            .grpNewDataField.Width = 584
            .btnDone.Width = 112
            .btnDone.Left = 88
            .btnChangeValueToNone.Width = 112
            .btnChangeValueToNone.Left = 231
            .btnReset.Width = 112
            .btnReset.Left = 374
            .btnCancel.Width = 112
            .btnCancel.Left = 517
        End With
    End Sub
    Private Sub txtNewDataField_TextChanged(sender As Object, e As EventArgs) Handles txtNewDataField.TextChanged
        With Me
            If Len(.txtNewDataField.Text) > 0 Then
                .txtNewDataField.BackColor = clrLightGreen
                .btnReset.Enabled = True
                .btnDone.Enabled = True
                .AcceptButton = .btnDone
            Else
                .txtNewDataField.BackColor = clrLemmonChiffon
                .btnReset.Enabled = False
                .btnDone.Enabled = False
            End If
        End With
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Response As Integer
        Call msgSureWantToCancelThan(Response)
        Select Case Response
            Case 6 'Yes
                Call ResetControlsToOrigOnThisForm()
                CurrentFormName = "frmTrademarkDisplayOrParameterChanges"
                With frmTrademarkDisplayOrParameterChanges
                    .chkControlArrayForDisplayOrChanges.chkItem(CheckBoxNumberClicked).BackColor = clrLightestGray
                    .chkControlArrayForDisplayOrChanges.chkItem(CheckBoxNumberClicked).CheckState = CheckState.Unchecked
                End With
                Me.Close()
            Case 7 'No
                'Do Nothing
        End Select
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With Me
            .btnDone.Enabled = False
            .btnReset.Enabled = False
            Select Case CheckBoxNumberClicked
                Case 7, 8
                    .mskNewDateField.Text = ""
                    .mskNewDateField.Mask = "00/00/0000"
                    .mskNewDateField.Focus()
                Case Else
                    .txtNewDataField.Text = ""
                    .txtNewDataField.Focus()
            End Select
        End With
    End Sub

    Private Sub btnChangeValueToNone_Click(sender As Object, e As EventArgs) Handles btnChangeValueToNone.Click
        With Me
            Select Case CheckBoxNumberClicked
                Case 7, 8
                    .mskNewDateField.Mask = ""
                    .mskNewDateField.Text = "NONE"
                    .btnDone.Enabled = True
                    .btnReset.Enabled = True
                Case Else
                    .txtNewDataField.Text = "NONE"
            End Select

        End With
    End Sub

    Private Sub frmChangeTrademarkDataFields_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        With Me
            Select Case CheckBoxNumberClicked
                Case 7, 8
                    Me.mskNewDateField.Select()
                Case Else
                    Me.txtNewDataField.Select()
            End Select
        End With


    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        With frmTrademarkDisplayOrParameterChanges
            Select Case CheckBoxNumberClicked
                Case 1 'Client Docket Number                    
                    .txtClientDocketNumber.Text = Me.txtNewDataField.Text.ToString
                    'Change the BackColor of Display frame to indicate that there has been a change
                    .grpClientDocketNumber.BackColor = clrYellow  '&HFFFF&   'Dark Yellow
                Case 2 'Country
                    .txtCountryCode.Text = Me.txtNewDataField.Text.ToString
                    .grpCountryCode.BackColor = clrYellow
                Case 3 'Responsible Attorney
                    .txtResponsibleAttorney.Text = Me.lstResponsibleAttorney.SelectedItem.ToString
                    .grpResponsibleAttorney.BackColor = clrYellow
                Case 7 'First Use Date in Commerce
                    .txtFirstUseDateInCommerce.Text = Me.mskNewDateField.Text.ToString
                    .grpFirstUseDateInCommerce.BackColor = clrYellow
                Case 8 'First Use Date in Interstate Commerce
                    Call ResetControlsToOrigOnThisForm()
                    .txtFirstUseDate.Text = Me.mskNewDateField.Text.ToString
                    .grpFirstUseDate.BackColor = clrYellow
            End Select
            .chkControlArrayForDisplayOrChanges.chkItem(CheckBoxNumberClicked).BackColor = clrYellow  '&HFFFF&   'Dark Yellow
            '.chkControlArrayForDisplayOrChanges.chkItem(CheckBoxNumberClicked).Checked = True  '.Value = 1
            'Change the Command Button Captions to show that a change was made
            .btnDone.Font = RKLFont12BI 'RKLFont(12, "B", "I")
            .btnDone.Text = " Done - OK To Save Changes "
            .AcceptButton = .btnDone '  .Default = True '.SetFocus
            .btnRestoreAllOriginalValues.Enabled = True
            .btnCancel.Enabled = True
            .btnNext.Enabled = False

        End With
        With Me
            'Reset the new values in this form
            .btnDone.BackColor = clrLightGray '&H8000000F  'ButtonFace
            .btnDone.Text = " Done "
            .btnReset.PerformClick()
            'Used to prevent the ChangeParameterForm from reappearing
            '  when it's Cancel button is clicked
            ''''''CheckBoxForThisParameterChangePreviouslyClicked(SelectedParameterNumberToBeChanged) = False
            'The following Variable is used to make sure that the Check is set to the appropriate
            '   Value - Depending on "when" box is checked
            ''''''ThisParameterChangedAtLeastOnce(SelectedParameterNumberToBeChanged) = True
        End With
        CurrentFormName = "frmTrademarkDisplayOrParameterChanges"
        Me.Close()
    End Sub

    Private Sub lstResponsibleAttorney_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResponsibleAttorney.SelectedIndexChanged
        If IntialLoadOfThisFormCompleted = False Then Exit Sub
        With Me
            Dim tempRKLAttorneySelected As String = .lstResponsibleAttorney.SelectedItem
            ResponsibleAttorney = Trim(tempRKLAttorneySelected)
            .btnDone.Enabled = True
            .btnDone.BackColor = clrOrange
        End With
    End Sub

    Private Sub mskNewDateField_TextChanged(sender As Object, e As EventArgs) Handles mskNewDateField.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer
        Dim tempmskNewDateField As String

        With Me
            Start = .mskNewDateField.SelectionStart
            Length = .mskNewDateField.SelectionLength
            .mskNewDateField.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            tempmskNewDateField = Trim(.mskNewDateField.Text)

            If tempmskNewDateField = "NONE" Then
                .mskNewDateField.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                Exit Sub
            End If

            If tempmskNewDateField.Length > 0 Then
                .mskNewDateField.Mask = "00/00/0000"
                .mskNewDateField.BackColor = Color.FromArgb(144, 238, 144) 'LightGreen
                'Now check for a valid date
                DateToBeChecked = .mskNewDateField.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .mskNewDateField.SelectionStart = Start
                    .mskNewDateField.SelectionLength = Length
                End If
                If Len(Trim(.mskNewDateField.Text)) = 8 Then
                    .mskNewDateField.Mask = "00/00/0000"
                    .btnReset.Enabled = True
                    .btnDone.Enabled = True
                    .AcceptButton = .btnDone
                End If
            Else
                .mskNewDateField.BackColor = clrLemmonChiffon
            End If
        End With
    End Sub
End Class