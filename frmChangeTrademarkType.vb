Public Class frmChangeTrademarkType
    Public rdoArrayTypeOfTrademark As RadioButtonArray
    Private Sub frmChangeTrademarkType_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rdoTitleTypeOfTrademark As String
        Dim LeftTypeOfTrademark As Integer
        Dim TopTypeOfTrademark As Integer

        CurrentFormName = "frmChangeTrademarkType"

        With Me
            .Text = "Trademark Type Change"

            'Set up all of the Labels and Text for this Form
            .lblFormTitle.Font = RKLFont16B
            lblFormTitle.Text = "You are Changing the Value of: The Type of Trademark"

            .lblCurrentTrademarkType.Font = RKLFont14B
            .lblCurrentTrademarkType.Text = "Current Type of Trademark:"

            .txtCurrentTrademarkType.Font = RKLFont12B
            .txtCurrentTrademarkType.BackColor = Color.LawnGreen
            .txtCurrentTrademarkType.Text = frmTrademarkDisplayOrParameterChanges.txtTrademarkType.Text.ToString
            .txtCurrentTrademarkType.ReadOnly = True

            .lblNewTrademarkType.Font = RKLFont14B
            .lblNewTrademarkType.Text = "New Type of Trademark:"
            .lblNewTrademarkType.Enabled = False

            .txtNewTrademarkType.Font = RKLFont12B
            .txtNewTrademarkType.Text = ""
            .txtNewTrademarkType.ReadOnly = True
            .txtNewTrademarkType.Enabled = False

            .grpTrademarkTypeBeingChanged.Font = RKLFont14BI
            .grpTrademarkTypeBeingChanged.Text = "Click on the Type that this Trademark is being changed to:"

            'Now setup the Options fopr the Trademark Types
            rdoArrayTypeOfTrademark = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftTypeOfTrademark = 30 '100 '150  '20
            TopTypeOfTrademark = 35 '20  '5  '1

            rdoTitleTypeOfTrademark = "Trademark (Goods)"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTrademark = "Service Mark (Services)"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTrademark = "Combined Trademark/Service"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 400 '480  '530  '500 represents the start of a new Column of Radio Buttons
            TopTypeOfTrademark = 35 '20  '1

            rdoTitleTypeOfTrademark = "Collective Memberahip Mark"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTrademark = "Certification Mark"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            rdoTitleTypeOfTrademark = "Collective Mark"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            LeftTypeOfTrademark = 740 '820 '870  '500 represents the start of a new Column of Radio Buttons
            TopTypeOfTrademark = 35 '20  '1

            rdoTitleTypeOfTrademark = "Concurrent Use Mark"
            .grpTrademarkTypeBeingChanged.Controls.Add(rdoArrayTypeOfTrademark.AddNewRadioButton(rdoTitleTypeOfTrademark, LeftTypeOfTrademark, TopTypeOfTrademark))

            .grpTrademarkTypeBeingChanged.BackColor = clrOrange

            'Now Setup the Buttons
            .btnDone.Font = RKLFont12BI
            .btnDone.Text = "Done"
            .btnDone.Enabled = False
            .btnReset.Font = RKLFont12BI
            .btnReset.Text = "Reset"
            .btnReset.Enabled = False
            .btnCancel.Font = RKLFont12BI
            .btnCancel.Text = "Cancel"
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        With Me
            .lblNewTrademarkType.Enabled = False
            .txtNewTrademarkType.Text = ""
            .txtNewTrademarkType.BackColor = clrLemmonChiffon
            .txtNewTrademarkType.Enabled = False
            For I = 1 To 7
                rdoArrayTypeOfTrademark.rdoItem(I).Checked = False  '.BackColor = clrLightestGray
            Next I
            .btnDone.Enabled = False
            .btnReset.Enabled = False
        End With
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        With frmTrademarkDisplayOrParameterChanges
            .txtTrademarkType.Text = TrademarkType.ToString
            'Change the BackColor of Display frame to indicate that there has been a change
            .grpTrademarkType.BackColor = clrYellow  '&HFFFF&   'Dark Yellow
            .chkControlArrayForDisplayOrChanges.chkItem(4).BackColor = clrYellow  '&HFFFF&   'Dark Yellow
            .chkControlArrayForDisplayOrChanges.chkItem(4).Checked = True  '.Value = 1
            'Change the Command Button Captions to show that a change was made
            .btnDone.Font = RKLFont12BI 'RKLFont(12, "B", "I")
            .btnDone.Text = " Done - OK To Save Changes "
            .AcceptButton = .btnDone '  .Default = True '.SetFocus
            .btnRestoreAllOriginalValues.Enabled = True
            .btnCancel.Enabled = True
            .btnNext.Enabled = False
        End With
        CurrentFormName = "frmTrademarkDisplayOrParameterChanges"
        Me.Close()
    End Sub

    Private Sub frmChangeTrademarkType_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.txtCurrentTrademarkType.SelectionStart = 0
    End Sub
End Class