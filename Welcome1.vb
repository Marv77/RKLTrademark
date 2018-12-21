Public Class Welcome1
    Private Sub Welcome1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (My.Computer.Keyboard.CapsLock) Then
            ''''    'My.Computer.Keyboard.SendKeys("{CAPSLOCK}")
            ''''    My.Computer.Keyboard.SendKeys("{CAPSLOCK}")
            'Set the CapsLock Key to stay ON
            PressCapsLockKey(VK_CAPITAL) 'turn capslockon
        End If

        Dim TrademarkRecordCount As Long

        ''''''PathToTrademarkDB = "C:\Users\Admin\Marv's Folder\Mort\Trademark in VB17\RKLTrademarkForWindows"
        PathToTrademarkDB = "C:\Users\Admin\Marv's Folder\Mort\Trademark in VB17\RKLTrademarkForWin\RKLTrademarkForWin"
        PathToAccountingDB = "C:\Users\Admin\Marv's Folder\Mort\Trademark in VB17\RKLTrademarkForWin\RKLTrademarkForWin"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'PathToTrademarkDB = "Q:\NEWBilling\SOURCE\NEWTrademark"
        'PathToAccountingDB = "Q:\NEWBilling\SOURCE\NEWTrademark"

        adoRKLTrademarkDBConnectIsOpen = False

        ''''Dim RKLHeadingFont As New System.Drawing.Font("Arial", 24, FontStyle.Italic)
        With Me
            .lblRKLDBPath.Text = PathToTrademarkDB
            .grpTopHeading.Text = ""
            .grpTopHeading.BackColor = Color.Aquamarine
            .lblRKLHeading.Text = "Rosenberg, Klein && Lee"
            .lblChartered.Text = "Chartered"
            .lblWelcome.Text = "Welcome to the RKL Trademark Document Management Program"
            .lblCopyright.Text = "Copyright, 2017" & vbCrLf & "Morton J. Rosenberg"

            'Now Get and Display the current Record Count in the TradeMark [Patent] Documents Table
            'OpenConnectionToRKLTrademarkDB("RKLPatent.mdb")
            OpenConnectionToRKLTrademarkDB("RKLTrademark.mdb")
            'OpenTableInRKLTrademarkDB("PatentDocuments")
            OpenTableInRKLTrademarkDB("TrademarkDocuments")

            TrademarkRecordCount = adoRKLTrademarkRecordset.RecordCount
            .lblTotalRecordCount.Text = "The Total Number of Records in this File is: " & TrademarkRecordCount.ToString
            CloseTableInRKLTrademarkDB()
            CloseConnectionToRKLTrademarkDB()

            .grpLogin.Text = ""
            .lblLoginName.Text = "Please Type in your Login Name:"
            .rtbUserName.Text = Environ("UserName")

            .lblTodaysDate.Text = "Please Verify Today's Date:  " & RKLTodaysDate
            lngRKLDate = ConvertToRKLDate(RKLTodaysDate)
            .lblChangeDate.Text = "Click Here to Change Today's Date ==>"

            .btnContinue.Text = "Continue..."
            .btnExit.Text = "Exit"
        End With
    End Sub
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        With frmMainMenu2
            .ShowDialog()
        End With
        Me.Close()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PressCapsLockKey(VK_CAPITAL) 'Turn CapsLock Off
        End
    End Sub
    Private Sub rtbUserName_TextChanged(sender As Object, e As EventArgs) Handles rtbUserName.TextChanged
        With Me
            UserName = Strings.Trim(.rtbUserName.Text)
            If Strings.Len(UserName) > 0 Then
                .rtbUserName.BackColor = clrLightGreen 'System.Drawing.ColorTranslator.FromOle(&HC0FFC0)   'Color.LightGreen
            Else
                'Dim myColor As Color = ColorTranslator.FromWin32((Integer)win32Color)
                .rtbUserName.BackColor = clrLemmonChiffon 'System.Drawing.ColorTranslator.FromOle(&HFFBF00)
            End If
        End With
    End Sub
    Private Sub DateTimePicker1_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.TextChanged
        With Me
            RKLTodaysDate = DateTimePicker1.Value.ToShortDateString
            .lblTodaysDate.Text = "Please Verify Today's Date:  " & RKLTodaysDate

            lngRKLDate = ConvertToRKLDate(RKLTodaysDate)
        End With
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnForMarvOnly_Click(sender As Object, e As EventArgs)
        frmControlsTemplates.Show()
    End Sub

    Private Sub btnTestAForm_Click(sender As Object, e As EventArgs)
        frmInitialTrademarkApplicationInputTabs.Show()
    End Sub
End Class