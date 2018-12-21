Public Class CheckBoxArray
    Inherits System.Collections.CollectionBase
    Public chkControlArray As CheckBox
    Private ReadOnly chkHostForm As System.Windows.Forms.Form
    Public Function AddNewCheckBox(ByVal chkBoxCaption As String, LocLeft As Integer, LocTop As Integer) As System.Windows.Forms.CheckBox
        ' Create a new instance of the Button class
        Dim aCheckBox As New System.Windows.Forms.CheckBox()
        ' Add the button to the collection's internal list
        Me.List.Add(aCheckBox)
        ' Add the button to the controls collection of the form referenced by the chkHostForm Field
        chkHostForm.Controls.Add(aCheckBox)
        ' Set initial properties for the Button object
        ' Set initial properties for the Button object
        Select Case CurrentFormName
            Case "frmTrademarkDisplayOrParameterChanges"
                'If aCheckBoxCount = 0 Then
                '    aCheckBox.Top = LocTop
                '    aCheckBoxCount = 1
                'Else
                '    aCheckBox.Top = LocTop + (aCheckBoxCount * 30)  'Count * 65 ' 40  '25
                '    aCheckBoxCount += 1
                'End If
                'aCheckBox.Anchor = (AnchorStyles.Left And AnchorStyles.Right)
                'aCheckBox.Anchor = AnchorStyles.Right
                aCheckBox.Top = LocTop
                aCheckBox.Left = LocLeft  '200  '85  '175
                aCheckBox.Width = 50  '650  '500
                aCheckBox.Height = 40 '60  '45
                'aCheckBox.FlatStyle = FlatStyle.Popup
                aCheckBox.Font = RKLFont14BI
                aCheckBox.BackColor = Color.Transparent
                aCheckBox.Tag = Me.Count
                aCheckBox.Text = chkBoxCaption
            Case "frmInitialTrademarkApplicationInputTabs"
                aCheckBox.Top = LocTop
                aCheckBox.Left = LocLeft  '200  '85  '175
                aCheckBox.Width = 200 '50  '650  '500
                aCheckBox.Height = 40 '60  '45
                'aCheckBox.FlatStyle = FlatStyle.Popup
                aCheckBox.Font = RKLFont12B
                aCheckBox.BackColor = Color.Transparent
                aCheckBox.Tag = Me.Count
                aCheckBox.Text = chkBoxCaption
                'aCheckBox.Enabled = False
            Case Else
                If aCheckBoxCount = 0 Then
                    aCheckBox.Top = LocTop
                    aCheckBoxCount = 1
                Else
                    aCheckBox.Top = LocTop + (aCheckBoxCount * 30)  'Count * 65 ' 40  '25
                    aCheckBoxCount += 1
                End If
                'aCheckBox.Anchor = (AnchorStyles.Left And AnchorStyles.Right)
                'aCheckBox.Anchor = AnchorStyles.Right

                aCheckBox.Left = LocLeft  '200  '85  '175
                aCheckBox.Width = 50  '650  '500
                aCheckBox.Height = 40 '60  '45
                'aCheckBox.FlatStyle = FlatStyle.Popup
                aCheckBox.Font = RKLFont14BI
                aCheckBox.BackColor = Color.Transparent
                aCheckBox.Tag = Me.Count
                aCheckBox.Text = chkBoxCaption
        End Select

        AddHandler aCheckBox.Click, AddressOf chkClickHandler
        Return aCheckBox
    End Function
    Public Sub New(ByVal host As System.Windows.Forms.Form)
        chkHostForm = host
        ''''Me.AddNewCheckBox("This is a DUMMY Check Box", 200, 20)
    End Sub
    Default Public ReadOnly Property chkItem(ByVal chkIndex As Integer) As System.Windows.Forms.CheckBox
        Get
            Return CType(Me.List.Item(chkIndex), System.Windows.Forms.CheckBox)
        End Get
    End Property
    Public Sub Remove(ByVal CheckBoxToBeRemoved As Integer)
        ' Check to be sure there is a button to remove
        ''''If Me.Count > 0 Then
        ' Remove the last button added to the array from the host form
        ' controls collection.  NOTE: The use of the default property in
        ' accessing the array.
        ''''btnHostForm.Controls.Remove(Me(Me.Count - 1))
        chkHostForm.Controls.Remove(Me(CheckBoxToBeRemoved))
        ''''Me.List.RemoveAt(Me.Count - 1)
        Me.List.RemoveAt(CheckBoxToBeRemoved)
        ''''End If
    End Sub
    Public Sub chkClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        '''''MessageBox.Show("You have clicked button " & CType(CType(sender, System.Windows.Forms.Button).Tag, String))
        CheckBoxNumberClicked = (CType(sender, System.Windows.Forms.CheckBox).Tag) - 1

        Select Case CurrentFormName        'Select Case MenuLevel
            Case "frmTrademarkDisplayOrParameterChanges"
                Dim tempLenOfFullDocketNumber As Integer
                Dim tempQtyCharsBeforeDash As Integer
                Dim tempQtyCharsAfterDash As Integer

                Select Case CheckBoxNumberClicked
                    Case 0 'Full Docket Number
                        'MessageBox.Show("You have clicked check box " & CheckBoxNumberClicked.ToString)
                        ''Parse and Capture the Docket Number and Sub-Docket Number from the Full Docket Number
                        '' First Parse and Find the character-location of the - character from the Full Docket Number
                        With frmTrademarkDisplayOrParameterChanges
                            tempLenOfFullDocketNumber = Len(Trim$(.txtFullDocketNumber.Text))
                            tempQtyCharsBeforeDash = InStr(1, Trim$(.txtFullDocketNumber.Text), "-") - 1
                            tempQtyCharsAfterDash = tempLenOfFullDocketNumber - tempQtyCharsBeforeDash - 1

                            CurrentRKLDocket = Left(Trim$(.txtFullDocketNumber.Text), tempQtyCharsBeforeDash)
                            OrigDocketNumber = CurrentRKLDocket
                            CurrentSubDocketNumber = Right(Trim$(.txtFullDocketNumber.Text), tempQtyCharsAfterDash)
                            OrigSubDocketNumber = CurrentSubDocketNumber
                        End With
                        frmChangeDNandSDN.ShowDialog()
                    Case 1 'Client Docket Number
                        'MessageBox.Show("You have clicked check box " & CheckBoxNumberClicked.ToString)
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtClientDocketNumber.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpClientDocketNumber.Text.ToString
                        End With
                        frmChangeTrademarkDataFields.ShowDialog()
                    Case 2 'Country Code
                        'MessageBox.Show("You have clicked check box " & CheckBoxNumberClicked.ToString)
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtCountryCode.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpCountryCode.Text.ToString
                        End With
                        frmChangeTrademarkDataFields.ShowDialog()
                    Case 3 'Responsible Attorney
                        'MessageBox.Show("You have clicked check box " & CheckBoxNumberClicked.ToString)
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtResponsibleAttorney.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpResponsibleAttorney.Text.ToString
                        End With
                        frmChangeTrademarkDataFields.ShowDialog()
                    Case 4  'Type of Trademark
                        'MessageBox.Show("You have clicked check box " & CheckBoxNumberClicked.ToString)
                        frmChangeTrademarkType.ShowDialog() '<==Modal
                    Case 5  'Mark
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtMarkText.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpMarkText.Text.ToString
                        End With
                        frmChangeMarkGoodsServices.ShowDialog() '<==Modal
                    Case 6  'Goods and/or Services
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtGoodsServicesUsedByMark.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpGoodsServicesUsedByMark.Text.ToString
                        End With
                        frmChangeMarkGoodsServices.ShowDialog() '<==Modal
                    Case 7 'First Use Date In Commerce
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtFirstUseDateInCommerce.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpFirstUseDateInCommerce.Text.ToString
                        End With
                        frmChangeTrademarkDataFields.ShowDialog()
                    Case 8  'First Use Date In InterState Commerce
                        With frmTrademarkDisplayOrParameterChanges
                            CurrentValueOfSelectedDataField = .txtFirstUseDate.Text.ToString
                            SelectedDataFieldNameToBeChanged = .grpFirstUseDate.Text.ToString
                        End With
                        frmChangeTrademarkDataFields.ShowDialog()
                End Select
            Case "frmInitialTrademarkApplicationInputTabs"
                With frmInitialTrademarkApplicationInputTabs
                    .btnDoneStateNames.Enabled = True
                    .btnResetStateNames.Enabled = True
                End With


        End Select
    End Sub
End Class
