Public Class TextBoxArray
    Inherits System.Collections.CollectionBase
    Public txtControlArray As TextBoxArray
    Private ReadOnly txtHostForm As System.Windows.Forms.Form
    Public Function AddNewTextBox(LocLeft As Integer, LocTop As Integer, txtWidth As Integer) As System.Windows.Forms.TextBox
        Dim aTextBox As New System.Windows.Forms.TextBox
        Me.List.Add(aTextBox)
        txtHostForm.Controls.Add(aTextBox)

        Select Case CurrentFormName
            Case "frmTrademarkDisplayOrParameterChanges"
                'If aTextBoxCount = 0 Then
                aTextBoxCount += 1
                'Else
                '    aTextBox.Text = aTextBoxCount.ToString
                '    aTextBox.Top = LocTop + (aTextBoxCount * 20)
                '    aTextBoxCount += 1
                'End If
                aTextBox.Text = ""
                aTextBox.Top = LocTop
                aTextBox.Left = LocLeft
                aTextBox.Width = txtWidth
                aTextBox.Font = RKLFont12B
                aTextBox.Tag = Me.Count
            Case Else

        End Select


        AddHandler aTextBox.TextChanged, AddressOf txtClickHandler
        Return aTextBox
    End Function
    Public Sub New(ByVal host As System.Windows.Forms.Form)
        txtHostForm = host
        'Me.AddNewTextBox(1, 1)
    End Sub
    Default Public ReadOnly Property txtItem(ByVal txtIndex As Integer) As System.Windows.Forms.TextBox
        Get
            Return CType(Me.List.Item(txtIndex), System.Windows.Forms.TextBox)
        End Get
    End Property
    Public Sub Remove(ByVal TextBoxToBeRemoved As Integer)
        'If Me.Count > 0 Then
        txtHostForm.Controls.Remove(Me(TextBoxToBeRemoved))
        Me.List.RemoveAt(TextBoxToBeRemoved)
        'End If
    End Sub
    Public Sub txtClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        TextBoxNumberClicked = (CType(sender, System.Windows.Forms.TextBox).Tag) - 1

        Select Case CurrentFormName
            Case "frmTrademarkDisplayOrParameterChanges"
                Select Case GroupInTrademarkDisplayOrParameterChanges
                    Case "ActionTypeReceived"
                        With frmTrademarkDisplayOrParameterChanges
                            'If .aTextBox.item(0).Text.Length > 0 Then
                            '    .txtSubDocketNumber.BackColor = clrLightGreen
                            '    .btnLookUpSDN.Enabled = True
                            '    .AcceptButton = .btnLookUpSDN
                            'Else
                            '    .txtSubDocketNumber.BackColor = clrLemmonChiffon
                            '    .btnLookUpSDN.Enabled = False
                            'End If
                        End With
                    Case 2


                End Select
        End Select
    End Sub
End Class
