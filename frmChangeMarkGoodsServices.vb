Public Class frmChangeMarkGoodsServices
    Public LengthOfRTBText As Integer
    Private Sub frmChangeMarkGoodsServices_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tempLenOfSelectedDataFieldNameToBeChanged As Integer
        Dim tempLocationOfTheDot As Integer
        Dim NameOnlyOfSelectedDataFieldToBeChanged

        CurrentFormName = "frmChangeMarkGoodsServices"

        With Me
            .Text = "Changing the Value of: " & SelectedDataFieldNameToBeChanged
            .BackColor = clrLighestOrange

            .lblFormTitle.Font = RKLFont16B
            .lblFormTitle.Text = "You are Changing the Value of: " & SelectedDataFieldNameToBeChanged

            'Get the Name of the DataField WITHOUT the Number and Dot
            tempLenOfSelectedDataFieldNameToBeChanged = SelectedDataFieldNameToBeChanged.Length
            tempLocationOfTheDot = InStr(SelectedDataFieldNameToBeChanged, ".")
            NameOnlyOfSelectedDataFieldToBeChanged = Mid(SelectedDataFieldNameToBeChanged, tempLocationOfTheDot + 2, tempLenOfSelectedDataFieldNameToBeChanged)

            .grpCurrentMarkGoodsServices.Font = RKLFont14B
            .grpCurrentMarkGoodsServices.BackColor = clrLightGray
            .grpCurrentMarkGoodsServices.Text = "Current " & NameOnlyOfSelectedDataFieldToBeChanged.ToString & ":"
            .txtCurrentMarkGoodsServices.Font = RKLFont14B
            .txtCurrentMarkGoodsServices.Text = CurrentValueOfSelectedDataField.ToString
            .txtCurrentMarkGoodsServices.BackColor = clrLightGreen

            .grpNewMarkGoodsServices.Font = RKLFont14BI
            .grpNewMarkGoodsServices.Text = "Enter the New Value for the " & NameOnlyOfSelectedDataFieldToBeChanged.ToString
            Select Case CheckBoxNumberClicked
                Case 5  'Mark
                    LengthOfRTBText = 100
                Case 6  'Goods and/or Services
                    LengthOfRTBText = 70
            End Select
            .grpNewMarkGoodsServices.Text = .grpNewMarkGoodsServices.Text & " (Max. Characters = " & LengthOfRTBText.ToString & ")"
            .grpNewMarkGoodsServices.BackColor = clrOrange

            .lblCharactersRemaining.Text = "Characters Remaining: " & (LengthOfRTBText.ToString)

            'Now empty/clear the contents of the rtb-Control
            '.rtbNewMarkGoodsServices.Clear()
            '.rtbNewMarkGoodsServices.Update()
            '.rtbNewMarkGoodsServices.Text = Nothing
            'Dim temprtbNewMarkGoodsServices As String
            '.rtbNewMarkGoodsServices.SelectAll()
            '.rtbNewMarkGoodsServices.SelectedText = ""
            'temprtbNewMarkGoodsServices = .rtbNewMarkGoodsServices.Text
            .rtbNewMarkGoodsServices.Text = ""
            .rtbNewMarkGoodsServices.Font = RKLFont14B

            .lblCharactersRemaining.Font = RKLFont16B

            .btnDone.Font = RKLFont16BI
            .btnDone.Text = "Done"
            .btnReset.Font = RKLFont16BI
            .btnReset.Text = "Reset"
            .btnCancel.Font = RKLFont16BI
            .btnCancel.Text = "Cancel"
        End With
    End Sub

    Private Sub rtbNewMarkGoodsServices_TextChanged(sender As Object, e As EventArgs) Handles rtbNewMarkGoodsServices.TextChanged
        Dim temprtbNewMarkGoodsServices As String
        Dim tempLentemprtbNewMarkGoodsServices As Integer

        Select Case CheckBoxNumberClicked
            Case 5  'Mark
                LengthOfRTBText = 100
            Case 6  'Goods and/or Services
                LengthOfRTBText = 70
        End Select
        With Me
            temprtbNewMarkGoodsServices = .rtbNewMarkGoodsServices.Text
            tempLentemprtbNewMarkGoodsServices = temprtbNewMarkGoodsServices.Length
            If Trim(temprtbNewMarkGoodsServices.Length) > 0 Then
                .btnDone.Enabled = True
                .btnReset.Enabled = True

                .rtbNewMarkGoodsServices.BackColor = clrLightGreen 'Color.FromArgb(144, 238, 144) 'LightGreen

                .AcceptButton = .btnDone
                If .rtbNewMarkGoodsServices.Text.Length > LengthOfRTBText Then
                    Call msgThisFieldCantBeLongerThan(.rtbNewMarkGoodsServices.Text.Length - 1)
                    .rtbNewMarkGoodsServices.Text = Microsoft.VisualBasic.Left(.rtbNewMarkGoodsServices.Text, LengthOfRTBText)
                    .rtbNewMarkGoodsServices.SelectionStart = rtbNewMarkGoodsServices.Text.Length + 1
                Else
                    .lblCharactersRemaining.Text = "Characters Remaining: " & (LengthOfRTBText - .rtbNewMarkGoodsServices.Text.Length).ToString
                End If
            Else
                .lblCharactersRemaining.Text = "Characters Remaining: " & (LengthOfRTBText - .rtbNewMarkGoodsServices.Text.Length).ToString
                .rtbNewMarkGoodsServices.BackColor = clrLemmonChiffon   'Color.FromArgb(255, 250, 205) 'LemmonChiffon

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
                Me.rtbNewMarkGoodsServices.Text = ""
                CurrentFormName = "frmMainMenu2"
                Me.Close()
            Case 7 'No
                'Do Nothing
        End Select
    End Sub

    Private Sub frmChangeMarkGoodsServices_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.rtbNewMarkGoodsServices.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With Me
            .btnReset.Enabled = False
            .btnDone.Enabled = False
            .rtbNewMarkGoodsServices.Text = ""
            .rtbNewMarkGoodsServices.Focus()
        End With
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        With frmTrademarkDisplayOrParameterChanges
            Select Case CheckBoxNumberClicked
                Case 5 'Mark                                        
                    .txtMarkText.Text = Me.rtbNewMarkGoodsServices.Text.ToString
                    'Change the BackColor of Display frame to indicate that there has been a change
                    .grpMarkText.BackColor = clrYellow  '&HFFFF&   'Dark Yellow
                Case 6 'Goods and/or Services
                    .txtGoodsServicesUsedByMark.Text = Me.rtbNewMarkGoodsServices.Text.ToString
                    .grpGoodsServicesUsedByMark.BackColor = clrYellow
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
End Class