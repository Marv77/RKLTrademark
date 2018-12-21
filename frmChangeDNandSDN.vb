Public Class frmChangeDNandSDN
    Public NewRKLDocketNumber As String
    Public NewSubDocketNumber As String
    Public CurrentRKLDocketNumberHasChanged As Boolean
    Public CurrentSubDocketNumberHasChanged As Boolean

    Private Sub frmChangeDNandSDN_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            CurrentFormName = .Name
            .Text = "Change Docket Number and/or Sub-Docket Number ==> " & CurrentFormName

            .lblFormTitle.Font = RKLFont16B
            .lblFormTitle.Text = "You Are Changing the Values of: The Docket Number and/or the Sub-Docket Number"

            .lblCurrentFullDocketNumber.Font = RKLFont14B
            .lblCurrentFullDocketNumber.Text = "Current Full Docket Number: "
            .txtCurrentFullDocketNumber.Font = RKLFont14B
            .txtCurrentFullDocketNumber.Text = CurrentRKLDocket & "-" & CurrentSubDocketNumber
            .txtCurrentFullDocketNumber.ReadOnly = True

            .lblNewFullDocketNumber.Font = RKLFont14B
            .lblNewFullDocketNumber.Text = "New Full Docket Number: "
            .txtNewFullDocketNumber.Font = RKLFont14B
            .txtNewFullDocketNumber.Text = ""
            .txtNewFullDocketNumber.ReadOnly = True

            .grpOriginalFullDocketNumber.Font = RKLFont14B
            .grpOriginalFullDocketNumber.Text = "Original Full Docket Number"
            .txtOriginalFullDocketNumber.Font = RKLFont14B
            .txtOriginalFullDocketNumber.Text = OrigDocketNumber & "-" & OrigSubDocketNumber
            .txtOriginalFullDocketNumber.ReadOnly = True

            .pnlChangeDNandSDN.BackColor = clrLighestOrange

            .pnlChangeDocketNumber.BackColor = clrLightestGray
            .lblCurrentDocketNumber.Font = RKLFont14B
            .lblCurrentDocketNumber.Text = "Current Docket Number:"
            .txtCurrentDocketNumber.Font = RKLFont14B
            .txtCurrentDocketNumber.Text = CurrentRKLDocket
            .txtCurrentDocketNumber.ReadOnly = True
            .grpEnterNewDocketNumber.Font = RKLFont14BI
            .grpEnterNewDocketNumber.Text = "Click this Box and Enter the New Value for the Docket Number:"
            .grpEnterNewDocketNumber.BackColor = clrOrange
            .txtEnterNewDocketNumber.Font = RKLFont14B
            .txtEnterNewDocketNumber.Text = ""
            .btnLookUpDN.Font = RKLFont14BI
            .btnLookUpDN.Text = " Look-This-Up "
            .btnLookUpDN.Enabled = False
            .btnResetDN.Font = RKLFont14BI
            .btnResetDN.Text = " Reset "
            .btnResetDN.Enabled = False

            .pnlChangeSubDocketNumber.BackColor = clrLightestGray
            .lblCurrentSubDocketNumber.Font = RKLFont14B
            .lblCurrentSubDocketNumber.Text = "Current Sub-Docket Number:"
            .txtCurrentSubDocketNumber.Font = RKLFont14B
            .txtCurrentSubDocketNumber.Text = CurrentSubDocketNumber
            .txtCurrentSubDocketNumber.ReadOnly = True
            .grpEnterNewSubDocketNumber.Font = RKLFont14BI
            .grpEnterNewSubDocketNumber.Text = "Click this Box and Enter the New Value for the Sub-Docket Number:"
            .grpEnterNewSubDocketNumber.BackColor = clrOrange
            .txtEnterNewSubDocketNumber.Font = RKLFont14B
            .txtEnterNewSubDocketNumber.Text = ""
            .btnLookUpSDN.Font = RKLFont14BI
            .btnLookUpSDN.Text = " Look-This-Up "
            .btnLookUpSDN.BackColor = clrLightGray
            .btnResetSDN.Font = RKLFont14BI
            .btnResetSDN.Text = " Reset "
            .btnResetSDN.Enabled = False

            .btnDone.Font = RKLFont14BI
            .btnDone.Text = " Done "
            .btnDone.Enabled = False
            .btnDone.BackColor = clrLightGray
            .btnReset.Font = RKLFont14BI
            .btnReset.Text = " Reset "
            .btnReset.Enabled = False
            .btnRestoreOrigFullDocketNumber.Font = RKLFont12BI
            .btnRestoreOrigFullDocketNumber.Text = " Restore Original Full Docket "
            .btnRestoreOrigFullDocketNumber.Enabled = False

            .btnCancel.Font = RKLFont14BI
            .btnCancel.Text = " Cancel "
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Response As Integer
        Call msgSureWantToCancelThan(Response)
        Select Case Response
            Case 6 'Yes
                IntialLoadOfThisFormCompleted = False
                Me.Close()
                CurrentFormName = "frmMainMenu2"

                Me.Close()
            Case 7 'No
                'Do Nothing
        End Select
    End Sub

    Private Sub txtCurrentFullDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentFullDocketNumber.TextChanged
        With Me
            If Len(.txtCurrentFullDocketNumber.Text) > 0 Then
                '.btnReset.Enabled = True
                .txtCurrentFullDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
                '.btnLookUpDN.Enabled = True
                '.AcceptButton = btnLookUpDN
            Else
                .txtCurrentFullDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                '.btnReset.Enabled = False
            End If

        End With
    End Sub

    Private Sub txtOriginalFullDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtOriginalFullDocketNumber.TextChanged
        With Me
            If Len(.txtOriginalFullDocketNumber.Text) > 0 Then
                .txtOriginalFullDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
            Else
                .txtOriginalFullDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtNewFullDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNewFullDocketNumber.TextChanged
        With Me
            If Len(.txtNewFullDocketNumber.Text) > 0 Then
                .txtNewFullDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
            Else
                .txtNewFullDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtCurrentDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentDocketNumber.TextChanged
        With Me
            If Len(.txtCurrentDocketNumber.Text) > 0 Then
                .txtCurrentDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
            Else
                .txtCurrentDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
            End If
        End With
    End Sub

    Private Sub txtEnterNewDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtEnterNewDocketNumber.TextChanged
        With Me
            If Len(.txtEnterNewDocketNumber.Text) > 0 Then
                .btnResetDN.Enabled = True
                .txtEnterNewDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
                .btnLookUpDN.Enabled = True
                .AcceptButton = btnLookUpDN
            Else
                .txtEnterNewDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                .btnLookUpDN.Enabled = False
                .btnResetDN.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtEnterNewSubDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtEnterNewSubDocketNumber.TextChanged
        With Me
            If Len(.txtEnterNewSubDocketNumber.Text) > 0 Then
                .btnResetSDN.Enabled = True
                .txtEnterNewSubDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
                .btnLookUpSDN.Enabled = True
                .AcceptButton = btnLookUpSDN
            Else
                .txtEnterNewSubDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
                .btnLookUpSDN.Enabled = False
                .btnResetSDN.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtCurrentSubDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentSubDocketNumber.TextChanged
        With Me
            If Len(.txtCurrentSubDocketNumber.Text) > 0 Then
                .txtCurrentSubDocketNumber.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen
            Else
                .txtCurrentSubDocketNumber.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon
            End If
        End With
    End Sub

    Private Sub btnResetDN_Click(sender As Object, e As EventArgs) Handles btnResetDN.Click
        With Me
            If CurrentSubDocketNumberHasChanged = True Then
                .txtNewFullDocketNumber.Text = OrigDocketNumber & "-" & NewSubDocketNumber
            Else
                .txtNewFullDocketNumber.Text = ""
            End If
            .txtEnterNewDocketNumber.Text = ""
            .btnLookUpDN.Text = " Look-This-Up "
            .btnLookUpDN.BackColor = clrLightGray
            .btnLookUpDN.Enabled = False
            .btnResetDN.Enabled = False
        End With
    End Sub

    Private Sub btnResetSDN_Click(sender As Object, e As EventArgs) Handles btnResetSDN.Click
        With Me
            If CurrentRKLDocketNumberHasChanged = True Then
                .txtNewFullDocketNumber.Text = NewRKLDocketNumber & "-" & OrigSubDocketNumber
            Else
                .txtNewFullDocketNumber.Text = ""
            End If
            .txtEnterNewSubDocketNumber.Text = ""
            .btnLookUpSDN.Text = " Look-This-Up "
            .btnLookUpSDN.BackColor = clrLightGray
            .btnLookUpSDN.Enabled = False
            .btnResetSDN.Enabled = False
        End With
    End Sub

    Private Sub btnRestoreOrigFullDocketNumber_Click(sender As Object, e As EventArgs) Handles btnRestoreOrigFullDocketNumber.Click
        With Me
            .btnReset.PerformClick()

            .txtCurrentFullDocketNumber.Text = OrigDocketNumber & "-" & OrigSubDocketNumber
            .txtNewFullDocketNumber.Text = ""  'OrigDocketNumber & "-" & OrigSubDocketNumber
            .txtCurrentDocketNumber.Text = OrigDocketNumber
            CurrentRKLDocket = OrigDocketNumber
            .txtCurrentSubDocketNumber.Text = OrigSubDocketNumber
            CurrentSubDocketNumber = OrigSubDocketNumber

            CurrentRKLDocketNumberHasChanged = False
            CurrentSubDocketNumberHasChanged = False

            .btnRestoreOrigFullDocketNumber.Enabled = False
            .btnDone.Enabled = True
        End With
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim NewFullDocketNumber As String

        With Me
            NewFullDocketNumber = ""
            If CurrentRKLDocketNumberHasChanged And CurrentSubDocketNumberHasChanged Then
                NewFullDocketNumber = NewRKLDocketNumber & "-" & NewSubDocketNumber
            ElseIf CurrentRKLDocketNumberHasChanged And (Not CurrentSubDocketNumberHasChanged) Then
                NewFullDocketNumber = NewRKLDocketNumber & "-" & CurrentSubDocketNumber
            ElseIf (Not CurrentRKLDocketNumberHasChanged) And CurrentSubDocketNumberHasChanged Then
                NewFullDocketNumber = CurrentRKLDocket & "-" & NewSubDocketNumber
            ElseIf (Not CurrentRKLDocketNumberHasChanged) And (Not CurrentSubDocketNumberHasChanged) And (Len(.txtNewFullDocketNumber.Text) > 0) Then
                NewFullDocketNumber = CurrentRKLDocket & "-" & CurrentSubDocketNumber
            End If

            With frmTrademarkDisplayOrParameterChanges
                .txtFullDocketNumber.Text = NewFullDocketNumber
                'Change the BackColor of Display frame to indicate that there has been a change
                .grpRKLDocketNumber.BackColor = clrYellow  '&HFFFF&   'Dark Yellow
                .chkControlArrayForDisplayOrChanges.chkItem(0).BackColor = clrYellow  '&HFFFF&   'Dark Yellow
                .chkControlArrayForDisplayOrChanges.chkItem(0).Checked = True  '.Value = 1
                'Change the Command Button Captions to show that a change was made
                .btnDone.Font = RKLFont12BI 'RKLFont(12, "B", "I")
                .btnDone.Text = " Done - OK To Save Changes "
                .AcceptButton = .btnDone '  .Default = True '.SetFocus
                .btnRestoreAllOriginalValues.Enabled = True
                .btnCancel.Enabled = True
                .btnNext.Enabled = False
                '.btnPrevStatement.Enabled = False
            End With
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

    Private Sub btnLookUpDN_Click(sender As Object, e As EventArgs) Handles btnLookUpDN.Click
        Dim tempFirstTwoChars As String
        Dim tempDocketNumber As String
        'Dim tempHighestSubDocketNumber As String
        'Dim tempLastSubDocketNumber As String

        With Me
            'FIRST Look for MR in the first 2 chars
            'If Left(.txtEnterNewDocketNumber.Text, 2) <> "MR" Then
            tempFirstTwoChars = .txtEnterNewDocketNumber.Text.Substring(0, 2)
            If tempFirstTwoChars <> "MR" Then
                Call msgMustHaveMR()
                .txtEnterNewDocketNumber.Text = ""
                .txtEnterNewDocketNumber.Focus()
                Exit Sub
            End If
        End With

        'Read each Record to look for the matching Docket Number
        OpenConnectionToRKLAccountingDB("rklaccountingDB.mdb")
        OpenTableInRKLAccountingDB("Docket")

        With adoRKLAccountingRecordset
            Do Until .EOF  '.Recordset.EOF
                'Get the Docket Number from the current Record
                tempDocketNumber = Trim$(.Fields!DocketNumber.Value.ToString)
                If Me.txtEnterNewDocketNumber.Text = tempDocketNumber Then
                    ''Hold the selected Docket Number and the ClientName for later use
                    'CurrentRKLDocket = Me.txtDocketNumber.Text
                    'ClientName = .Fields!ClientName
                    '.MoveFirst()
                    'Close the Docket table
                    CloseTableInRKLAccountingDB()
                    CloseConnectionToRKLAccountingDB()
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    With Me
                        .btnLookUpDN.Text = "F o u n d !"
                        .btnLookUpDN.BackColor = clrLime '&HFF00&      'Green

                        NewRKLDocketNumber = Trim$(.txtEnterNewDocketNumber.Text)

                        CurrentRKLDocketNumberHasChanged = True
                        If CurrentSubDocketNumberHasChanged Then
                            .txtNewFullDocketNumber.Text = NewRKLDocketNumber & "-" & NewSubDocketNumber
                        Else
                            .txtNewFullDocketNumber.Text = NewRKLDocketNumber & "-" & CurrentSubDocketNumber
                        End If
                        .btnResetDN.Enabled = True
                        .btnDone.Enabled = True
                        .btnReset.Enabled = True
                        .btnRestoreOrigFullDocketNumber.Enabled = True
                        .btnReset.Enabled = True
                    End With
                    CloseTableInRKLAccountingDB()
                    CloseConnectionToRKLAccountingDB()
                    Exit Sub
                End If
                .MoveNext()
            Loop
            'If this is executed then the Docket Number was not found
            '  So send the user a message
            msgDocketNumberNotFound(Me.txtEnterNewDocketNumber.Text)
            'Set the Focus to the Docket Number input field
            .MoveFirst() 'Set DB pointer back to first record
            'txtClientName.Text = ""
            Me.Show()
            Me.txtEnterNewDocketNumber.Text = ""
            Me.txtEnterNewDocketNumber.Focus()
            CloseTableInRKLAccountingDB()
            CloseConnectionToRKLAccountingDB()
            Exit Sub
        End With
    End Sub

    Private Sub btnLookUpSDN_Click(sender As Object, e As EventArgs) Handles btnLookUpSDN.Click
        Dim BaseSubDocketNumber As String
        Dim intBaseSubDocketNumber As Long
        Dim PositionOfSDNSeperator As Integer
        Dim PositionOfSDNSeperatorFound As Boolean

        Dim tempRKLDocketInDB As String
        Dim tempRKLDocketNumber As String
        Dim tempInsertedSubDocketNumber As String
        Dim tempSubDocketNumberInDB As String

        With Me
            If CurrentRKLDocketNumberHasChanged = True Then
                tempRKLDocketNumber = Trim(.txtEnterNewDocketNumber.Text)
            Else
                tempRKLDocketNumber = CurrentRKLDocket
            End If

            tempInsertedSubDocketNumber = Trim$(.txtEnterNewSubDocketNumber.Text)
            FullDocketNumber = CurrentRKLDocket & "-" & tempInsertedSubDocketNumber




            'NOTE:  On 08/20/17 Mort told Marv to NOT-allow ANY RECORDS THAT HAVE DUPLICATE RECORDS WITH DN-AND-SDN's be entered
            '  So, the next section checks to see if a record within the Table already exists with this DN and the new SDN - If so, send an error message
            '  First, Open a new Connection to the Patent DB
            OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
            OpenTableInRKLTrademarkDB("TrademarkDocuments")

            With adoRKLTrademarkRecordset   'Use with VB PatentDocuments Table
                Do
                    tempRKLDocketInDB = Trim$(.Fields!DocketNumber.Value.ToString)
                    tempSubDocketNumberInDB = Trim$(.Fields!SubDocketNumber.Value.ToString)
                    Me.btnLookUpSDN.BackColor = clrYellow '&HFFFF&   'Dark Yellow
                    Me.btnLookUpSDN.Text = "Searching..."
                    If (tempRKLDocketNumber = tempRKLDocketInDB) And (tempInsertedSubDocketNumber = tempSubDocketNumberInDB) Then
                        'Display an error message
                        Call msgMustNotEnterRecordWithDuplicateDNandSDN(tempInsertedSubDocketNumber)
                        'Clear the SDN Input Text Control
                        Me.btnLookUpSDN.Text = " Look-This-Up "
                        Me.btnLookUpSDN.BackColor = clrLightGray '&H8000000F  'ButtonFace
                        Me.btnLookUpSDN.Enabled = False
                        Me.txtEnterNewSubDocketNumber.Text = ""
                        Me.txtEnterNewSubDocketNumber.Focus()
                        CloseTableInRKLTrademarkDB()
                        CloseConnectionToRKLTrademarkDB()
                        Exit Sub
                    Else
                        .MoveNext()
                    End If
                Loop Until .EOF
                CloseTableInRKLTrademarkDB()
                CloseConnectionToRKLTrademarkDB()
                ''Now Make the ORIGINAL Found Record the Current Record
                '.MoveFirst()
                '.Move(AbsolutePositionOfRecordFoundDuringOKDisplay)
            End With

            With Me
                'If Len(Trim$(.txtField(0).Text)) > 0 Then
                HaveSentASubDocketNumberMessageToUser = False
                Call ValidateInsertedSDN(Trim$(.txtEnterNewSubDocketNumber.Text), Me)
                If HaveSentASubDocketNumberMessageToUser = True Then
                    If CurrentRKLDocketNumberHasChanged = True Then
                        .txtNewFullDocketNumber.Text = tempRKLDocketNumber & "-" & CurrentSubDocketNumber
                    Else
                        .txtNewFullDocketNumber.Text = ""
                    End If
                    .btnLookUpSDN.Text = " Look-This-Up "
                    .btnLookUpSDN.BackColor = clrLightGray
                    .btnLookUpSDN.Enabled = False

                    .txtEnterNewSubDocketNumber.Text = ""
                    .txtEnterNewSubDocketNumber.Focus()

                    .btnDone.Text = " Done "
                    .btnDone.Enabled = False
                    .btnDone.BackColor = clrLightGray
                Else
                    NewSubDocketNumber = tempInsertedSubDocketNumber
                    CurrentSubDocketNumberHasChanged = True
                    If CurrentRKLDocketNumberHasChanged = True Then
                        .txtNewFullDocketNumber.Text = tempRKLDocketNumber & "-" & NewSubDocketNumber
                    Else
                        .txtNewFullDocketNumber.Text = CurrentRKLDocket & "-" & NewSubDocketNumber
                    End If
                    .btnLookUpSDN.BackColor = clrLime '&HFF00&      'Green
                    .btnLookUpSDN.Text = "OK to Use!"
                    .btnResetSDN.Enabled = True
                    .btnReset.Enabled = True
                    .btnDone.Enabled = True
                    .btnDone.BackColor = clrLime
                    .btnDone.Text = " Now Click Here "
                    .AcceptButton = .btnDone
                End If
            End With

            CloseTableInRKLTrademarkDB()
            CloseConnectionToRKLTrademarkDB()

        End With
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With Me
            .btnResetDN.PerformClick()
            .btnResetSDN.PerformClick()
            .btnDone.Text = " Done "
            .btnDone.Enabled = False
            .btnDone.BackColor = clrLightGray
        End With
    End Sub
End Class