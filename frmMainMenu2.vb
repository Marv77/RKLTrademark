Public Class frmMainMenu2
    ' Declare a new ButtonArray Object.
    Public MyControlArray As ButtonArray

    '''''Private ReadOnly MenuItemTopPos1 As Integer
    '''''Private ReadOnly MenuItemTopPos2 As Integer = MenuItemTopPos1 * 2.3
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        ''''MyControlArray = New ButtonArray(Me)
        ''''For I = 1 To 3
        ''''    MyControlArray.AddNewButton()
        ''''Next I

        '>>>>>>>>>>>>>>>>>>>>>>>>>
        CurrentFormName = "frmMainMenu2"
        With Me
            .WindowState = FormWindowState.Maximized
            .FormBorderStyle = FormBorderStyle.Fixed3D

            .Text = "RKL [AppName] - Click on a Menu Item Button"
            .lblRKL.Text = "Rosenberg, Klein & Lee"
            .lblChartered.Text = "Chartered"
            .lblRKLTrademark.Text = "-- RKL Trademark --"
            .lblVersion.Text = "Version: " & "00.001"
            .lblTimeOfDayNow.Text = Format(Now, "hh:mm tt")
            .btnPreviousMenu.Font = RKLFont14BI
            .btnPreviousMenu.Text = "Previous Menu"
            .btnMainMenu.Font = RKLFont14BI
            .btnMainMenu.Text = "Main Menu"
            MyControlArray = New ButtonArray(Me)
            ' Add the first level of Buttons to the MainMenu
            'First Create the Five Basic Menu Buttons - Seven is for the Max number of Buttons needed
            For I = 1 To 7  '5
                ''''''MyControlArray.AddNewButton()
                '.grpToHoldButtons.Controls.Add(MyControlArray.AddNewButton("Button Place Holder"))
                .tplMainMenu.Controls.Add(MyControlArray.AddNewButton("Button Place Holder", 0, 0), 1, I + 1)
            Next I
            'Next display the First set of Menu Buttons
            Call DisplayMenu("MainMenu")
            ' Set the grpToHoldButtons BackColor INITIALLY to Light PowderBlue
            ''''.grpToHoldButtons.BackColor = Color.PowderBlue
        End With
        '^^^^^^^^^^^^^^^^^^^^^^^^^
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        ' Call the AddNewButton method of MyControlArray
        MyControlArray.AddNewButton("This Button was Added", 0, 0)
        ' Change the BackColor property of Button 0
        MyControlArray(0).BackColor = System.Drawing.Color.Red
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        ' Call the Remove method of MyControlArray
        MyControlArray.Remove(sender)
    End Sub

    Private Sub btnPreviousMenu_Click(sender As Object, e As EventArgs) Handles btnPreviousMenu.Click
        MenuLevel = MenuLevel - 1
        Select Case MenuLevel
            Case 1
                Call DisplayMenu("MainMenu")
            Case 2
                Call DisplayMenu("TypeOfTradeMarkDocument")
        End Select
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        MenuLevel = 1
        Call DisplayMenu("MainMenu")
    End Sub

    Private Sub lblMenuTitle_Click(sender As Object, e As EventArgs) Handles lblMenuTitle.Click

    End Sub

    Private Sub tplMainMenu_TextChanged(sender As Object, e As EventArgs) Handles tplMainMenu.TextChanged
        With Me

        End With
    End Sub

    'Private Sub btnPreviousMenu_Click_1(sender As Object, e As EventArgs) Handles btnPreviousMenu.Click

    'End Sub

    'Private Sub btnMainMenu_Click_1(sender As Object, e As EventArgs) Handles btnMainMenu.Click

    'End Sub
End Class