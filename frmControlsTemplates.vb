Public Class frmControlsTemplates
    Public rdoControlArray As RadioButtonArray
    Public chkControlArray As CheckBoxArray
    Public grpControlArray As GroupBoxArray
    Public txtControlArray As TextBoxArray


    Private Sub frmControlsTemplates_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rdoButtonTitle As String
        Dim LeftEdgeOfButton As Integer
        Dim TopEdgeOfButton As Integer

        Dim chkBoxCaption As String
        Dim LeftEdgeOfCheckBox As Integer
        Dim TopEdgeOfCheckBox As Integer

        Dim LeftEdgeOfTextBox As Integer
        Dim TopEdgeOfTextBox As Integer
        Dim WidthOfTextBox As Integer

        Dim grpBoxCaption As String
        Dim LeftEdgeOfGroupBox As Integer
        Dim TopEdgeOfGroupBox As Integer

        Dim clrBlue As Color = Color.FromArgb(0, 0, 255)
        'clrBlue = Color.FromArgb(0, 0, 255)   'RGB(0, 0, 256)


        With Me

            .grpOfCheckBoxes.BackColor = clrBlue

            'Now Set up the Multi-Row/Multi-Column Radio Buttons
            .grpOfRadioButtons.Font = RKLFont16BI
            .grpOfRadioButtons.Text = "Click on a Radio Button"
            rdoControlArray = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftEdgeOfButton = 20
            TopEdgeOfButton = 20  '5  '1

            rdoButtonTitle = "This is the First Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "This is the Second Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "This is the Third Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            LeftEdgeOfButton = 500  '500 represents the start of a new Column of Radio Buttons
            TopEdgeOfButton = 20  '1

            rdoButtonTitle = "This is the Fourth Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "This is the Fifth Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "This is the Sixth Radio Button Title"
            .grpOfRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            'Now Set up the Yes-No Radio Buttons
            .grpOfYesNoRadioButtons.Font = RKLFont16BI
            .grpOfYesNoRadioButtons.Text = "Click on a Yes or No Radio Button"
            rdoControlArray = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftEdgeOfButton = 20
            TopEdgeOfButton = 20  '5  '1

            rdoButtonTitle = "Yes"
            .grpOfYesNoRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "No"
            .grpOfYesNoRadioButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            'Now Set up the GroupBox with a Label and Yes-No Radio Buttons
            .grpWithLabelAndYesNoButtons.Text = ""
            rdoControlArray = New RadioButtonArray(Me) '<== Me refers to this Form

            LeftEdgeOfButton = 500
            TopEdgeOfButton = 10

            rdoButtonTitle = "LabelYes"
            .grpWithLabelAndYesNoButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            rdoButtonTitle = "LabelNo"
            .grpWithLabelAndYesNoButtons.Controls.Add(rdoControlArray.AddNewRadioButton(rdoButtonTitle, LeftEdgeOfButton, TopEdgeOfButton))

            .lblForYesNoButtons.Font = RKLFont14BI
            .lblForYesNoButtons.Text = "Please Click Yes of No:"

            'Now Set up the GroupBox with CheckBoxes
            .grpOfCheckBoxes.Font = RKLFont16BI
            .grpOfCheckBoxes.Text = "This is a Group of CheckBoxes"
            chkControlArray = New CheckBoxArray(Me)
            LeftEdgeOfCheckBox = 50
            TopEdgeOfCheckBox = 20

            'chkBoxCaption = "A CheckBox"
            .grpOfCheckBoxes.Controls.Add(chkControlArray.AddNewCheckBox(chkBoxCaption, LeftEdgeOfCheckBox, TopEdgeOfCheckBox))

            'chkBoxCaption = "Another CheckBox"
            .grpOfCheckBoxes.Controls.Add(chkControlArray.AddNewCheckBox(chkBoxCaption, LeftEdgeOfCheckBox, TopEdgeOfCheckBox))

            'Now add TextBoxes to this GroupBox
            txtControlArray = New TextBoxArray(Me)
            LeftEdgeOfTextBox = 100  '550
            TopEdgeOfTextBox = 30
            WidthOfTextBox = 100

            .grpOfCheckBoxes.Controls.Add(txtControlArray.AddNewTextBox(LeftEdgeOfTextBox, TopEdgeOfTextBox, WidthOfTextBox))

            'Now create a Composite set of Controls for Displaying and Editing Parameters: that include:
            '  Groupbox, CheckBox, TextBox - Many of these Composite Sets are to be in a larger GroupBox
            'Now Create the RKLChkTxtBox - Inside of a Group Box - The Group Box will have it's own Text-Identifer that
            '  describes the information that is to be entered into the TextBox
            grpControlArray = New GroupBoxArray(Me)
            LeftEdgeOfGroupBox = 20
            TopEdgeOfGroupBox = 20

            grpBoxCaption = "GB1"

            '.pnlRKLChkTxtBox.Controls.Add(grpControlArray.AddNewGroupBox(grpBoxCaption, LeftEdgeOfGroupBox, TopEdgeOfGroupBox))
            .grpOfAllParameterControls.Controls.Add(grpControlArray.AddNewGroupBox(grpBoxCaption, LeftEdgeOfGroupBox, TopEdgeOfGroupBox))

            'Now add a CheckBox to the 1st grpBox
            chkControlArray = New CheckBoxArray(Me)
            LeftEdgeOfCheckBox = 50
            TopEdgeOfCheckBox = 20

            chkBoxCaption = ""
            '.grpControlArray.Controls.Add(chkControlArray.AddNewCheckBox(chkBoxCaption, LeftEdgeOfCheckBox, TopEdgeOfCheckBox))

            grpBoxCaption = "GB2"
            .grpOfAllParameterControls.Controls.Add(grpControlArray.AddNewGroupBox(grpBoxCaption, LeftEdgeOfGroupBox, TopEdgeOfGroupBox))

            .txtEnterNumbersOnly.Text = ""
            .txtEnterNumbersOnly.Select()

        End With
    End Sub
    Private Sub grpOfRadioButtons_Enter(sender As Object, e As EventArgs) Handles grpOfRadioButtons.Enter

    End Sub

    Private Sub grpOfCheckBoxes_Enter(sender As Object, e As EventArgs) Handles grpOfCheckBoxes.Enter

    End Sub
    Private Sub txtEnterNumbersOnly_TextChanged(sender As Object, e As EventArgs) Handles txtEnterNumbersOnly.TextChanged
        Dim tempCheckedText As String
        Dim BackColorValue As Color

        With Me
            If (Val(.txtEnterNumbersOnly.Text) > 0) Or (Len(.txtEnterNumbersOnly.Text) > 0) Then
                'Check to see if a Number was entered
                Call CheckTextForNumber(.txtEnterNumbersOnly.Text, tempCheckedText, BackColorValue)
                .txtEnterNumbersOnly.Text = tempCheckedText
                .txtEnterNumbersOnly.BackColor = BackColorValue
                .txtEnterNumbersOnly.SelectionStart = Len(tempCheckedText) + 1
                If Val(.txtEnterNumbersOnly.Text) > 0 Then
                    .txtEnterNumbersOnly.Select()
                End If
                If Len(.txtEnterNumbersOnly.Text) > 3 Then
                    'Send msg -No more than 3 characters
                    MessageBox.Show("Sorry, you can not enter more than " & "3" & " characters in this field!",
                                    "No More Characters!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    .txtEnterNumbersOnly.Text = Microsoft.VisualBasic.Left(.txtEnterNumbersOnly.Text, 3)
                    .txtEnterNumbersOnly.SelectionStart = Len(.txtEnterNumbersOnly.Text) + 1
                End If
            Else
                .txtEnterNumbersOnly.BackColor = Color.Yellow
            End If

            'Initialize the txtDate Control
            .txtDateField.Text = ""
            .txtDateField.ValidatingType = GetType(DateTime)


        End With
    End Sub
    Private Sub txtDateField_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtDateField.MaskInputRejected
        '''''Dim DateToBeChecked As String
        '''''Dim IsBadDate As Boolean

        '''''With Me
        '''''    If Len(Trim(.txtDateField.Text)) > 0 Then
        '''''        .txtDateField.BackColor = Color.Green
        '''''        'Now check for a valid date
        '''''        DateToBeChecked = .txtDateField.Text
        '''''        Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)


        '''''    Else
        '''''        .txtDateField.BackColor = Color.Yellow

        '''''    End If
        '''''End With
    End Sub

    Private Sub txtDateField_TextChanged(sender As Object, e As EventArgs) Handles txtDateField.TextChanged
        Dim DateToBeChecked As String
        Dim IsBadDate As Boolean
        Dim Start As Integer
        Dim Length As Integer

        With Me
            Start = .txtDateField.SelectionStart
            Length = .txtDateField.SelectionLength
            .txtDateField.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
            If Len(Trim(.txtDateField.Text)) > 0 Then
                .txtDateField.Mask = "00/00/0000"
                .txtDateField.BackColor = Color.Green
                'Now check for a valid date
                DateToBeChecked = .txtDateField.Text
                Call CheckForValidDateEntered(DateToBeChecked, IsBadDate)
                If IsBadDate = True Then
                    .txtDateField.SelectionStart = Start
                    .txtDateField.SelectionLength = Length
                End If

            Else
                .txtDateField.BackColor = Color.Yellow

            End If
        End With
    End Sub

    Private Sub frmControlsTemplates_MinimumSizeChanged(sender As Object, e As EventArgs) Handles Me.MinimumSizeChanged

    End Sub
End Class