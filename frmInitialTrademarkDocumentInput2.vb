Public Class frmInitialTrademarkDocumentInput2
    Public rdoControlArray As RadioButtonArray
    Public txtControlArray As TextBoxArray
    Public chkControlArray As CheckBoxArray
    Public grpControlArray As GroupBoxArray
    Private Sub frmInitialTrademarkDocumentInput2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .WindowState = FormWindowState.Maximized

            .pnlDocketNumber.BackColor = Color.Orange
            .lblDocketNumber.Font = RKLFont12BI
            .lblDocketNumber.Text = "Enter Docket Number:"
            .txtDocketNumber.Font = RKLFont12B
            .txtDocketNumber.Text = ""
            .btnLookUpDN.Font = RKLFont11B
            .btnLookUpDN.Text = "Look-This-Up"
            .btnLookUpDN.Enabled = False
            .grpClientName.Text = ""
            .txtClientName.Font = RKLFont12B
            .txtClientName.Text = ""

            .grpSubDocketNumber.Text = ""
            .lblSubDocketNumber.Font = RKLFont12BI
            .lblSubDocketNumber.Text = "Enter Sub-Docket Number:"
            .txtSubDocketNumber.Font = RKLFont12B
            .txtSubDocketNumber.Text = ""
            .btnDoneSDN.Font = RKLFont11B
            .btnDoneSDN.Text = "Done"
            .btnDoneSDN.Enabled = False

            .grpInputOfMark.Font = RKLFont14B
            .grpInputOfMark.Text = "Input of Mark"

            .lblInputOfMarkInstructions.Font = RKLFont16BI
            .lblInputOfMarkInstructions.Text = "   (If the Mark only consists of Words, then type in the Words)" &
                                               vbCrLf & "   (If the Mark is only a Design, then type in the Word...Design)" &
                                               vbCrLf & "(If the Mark is a combination of of a Word and Design, then type in the Words)"

            .rtbInputOfMark.Font = RKLFont12B
            .rtbInputOfMark.Text = ""

            'Set up the GroupBox, CheckBox, and TextBox at RunTime
            '.tplMainMenu.Controls.Add(MyControlArray.AddNewButton("Button Place Holder"), 1, I + 1)


            '''''CheckBox
            ''''.chkControlArray = New CheckBoxArray(Me)
            ''''.tlpForForm01.Controls.Add(chkControlArray.AddNewCheckBox("", 3, -1), 0, 0)
            '''''TextBox
            ''''.txtControlArray = New TextBoxArray(Me)
            ''''.tlpForForm01.Controls.Add(txtControlArray.AddNewTextBox(20, 3), 1, 0)
            '''''GroupBox
            ''''.grpControlArray = New GroupBoxArray(Me)
            ''''.tlpForForm01.Controls.Add(grpControlArray.AddNewGroupBox("Docket Number", 1, 1), 0, 0)

            .GroupBox1.Font = RKLFont14B
            .GroupBox1.Text = "Group Box One"
            .chkControlArray = New CheckBoxArray(Me)
            .TableLayoutPanel1.Controls.Add(chkControlArray.AddNewCheckBox("", 50, -1), 0, 0)
            .txtControlArray = New TextBoxArray(Me)
            .TableLayoutPanel1.Controls.Add(txtControlArray.AddNewTextBox(10, 7), 1, 0)
        End With
    End Sub
    Private Sub txtDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtDocketNumber.TextChanged
        With Me
            If Len(.txtDocketNumber.Text) > 0 Then
                .txtDocketNumber.BackColor = Color.LightGreen
                .btnLookUpDN.Enabled = True
                .AcceptButton = btnLookUpDN
            Else
                .txtDocketNumber.BackColor = Color.LightYellow
                .txtDocketNumber.SelectionStart = 0
                .btnLookUpDN.Enabled = False
            End If
        End With
    End Sub
    Private Sub btnLookUpDN_Click(sender As Object, e As EventArgs) Handles btnLookUpDN.Click
        Dim tempDocketNumber As String
        ''''Dim tempInsertedDocketNumber As String
        ''''Dim tempFindDocketNumber As String
        ''''Dim tempClientName As String

        'Now Get and Display the current Client Name for entered Docket Number in
        '   the RKLAccountDB And the Docket Table
        OpenConnectionToRKLTrademarkDB("rklaccountingDB.mdb")
        OpenTableInRKLTrademarkDB("Docket")
        ''''TrademarkRecordCount = adoRKLTrademarkRecordset.RecordCount
        ''''.lblTotalRecordCount.Text = "The Total Number of Records in this File is: " & TrademarkRecordCount.ToString
        With adoRKLTrademarkRecordset
            Do Until .EOF
                ''''tempDocketNumber = .Fields.Item("DocketNumber").Value   '("DocketNumber").ToString
                tempDocketNumber = .Fields!DocketNumber.Value.ToString   '("DocketNumber").ToString
                If Me.txtDocketNumber.Text = Trim(tempDocketNumber) Then
                    Me.txtClientName.Text = .Fields!ClientName.Value.ToString
                    Exit Do
                End If
                .MoveNext()
            Loop
        End With
        CloseTableInRKLTrademarkDB()
        CloseConnectionToRKLTrademarkDB()
        With Me
            .pnlDocketNumber.BackColor = Color.Thistle
            .grpSubDocketNumber.BackColor = Color.Orange
            .txtSubDocketNumber.Focus()
        End With
    End Sub
    Private Sub txtClientName_TextChanged(sender As Object, e As EventArgs) Handles txtClientName.TextChanged
        With Me
            If Len(.txtClientName.Text) > 0 Then
                .txtClientName.BackColor = Color.LightGreen
                .btnDoneSDN.Enabled = True
            Else
                .txtClientName.BackColor = Color.LightYellow
                .btnDoneSDN.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtSubDocketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSubDocketNumber.TextChanged
        With Me
            If Len(.txtSubDocketNumber.Text) > 0 Then
                .txtSubDocketNumber.BackColor = Color.LightGreen
            Else
                .txtSubDocketNumber.BackColor = Color.LightYellow
            End If
        End With
    End Sub
End Class