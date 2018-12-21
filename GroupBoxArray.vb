Public Class GroupBoxArray
    Inherits System.Collections.CollectionBase
    Public grpControlArray As GroupBox
    Private ReadOnly grpHostForm As System.Windows.Forms.Form
    Public Function AddNewGroupBox(ByVal grpBoxCaption As String, LocLeft As Integer, LocTop As Integer) _
                                     As System.Windows.Forms.GroupBox
        ' Create a new instance of the GroupBox class
        Dim aGroupBox As New System.Windows.Forms.GroupBox
        ' Add the button to the collection's internal list
        Me.List.Add(aGroupBox)
        ' Add the button to the controls collection of the form referenced by the btnHostForm Field
        grpHostForm.Controls.Add(aGroupBox)
        ' Set initial properties for the Button object
        If aGroupBoxCount = 0 Then
            aGroupBox.Top = LocTop
            aGroupBoxCount = 1
        Else
            aGroupBox.Top = LocTop + (aGroupBoxCount * 60)  'Count * 65 ' 40  '25
            aGroupBoxCount += 1
        End If
        aGroupBox.Anchor = (AnchorStyles.Left And AnchorStyles.Right)

        aGroupBox.Left = LocLeft  '200  '85  '175
        aGroupBox.Width = 650  '500
        aGroupBox.Height = 60  '70  '45
        'aCheckBox.FlatStyle = FlatStyle.Popup
        aGroupBox.Font = RKLFont14BI
        aGroupBox.BackColor = Color.Transparent
        aGroupBox.Tag = Me.Count
        aGroupBox.Text = grpBoxCaption
        AddHandler aGroupBox.Click, AddressOf grpClickHandler
        Return aGroupBox
    End Function
    Public Sub New(ByVal host As System.Windows.Forms.Form)
        grpHostForm = host
        'Me.AddNewGroupBox("This is a DUMMY Check Box", 200, 20)
    End Sub
    Default Public ReadOnly Property chkItem(ByVal grpIndex As Integer) As System.Windows.Forms.CheckBox
        Get
            Return CType(Me.List.Item(grpIndex), System.Windows.Forms.CheckBox)
        End Get
    End Property
    Public Sub Remove(ByVal GroupBoxToBeRemoved As Integer)
        ' Check to be sure there is a button to remove
        ''''If Me.Count > 0 Then
        ' Remove the last button added to the array from the host form
        ' controls collection.  NOTE: The use of the default property in
        ' accessing the array.
        ''''btnHostForm.Controls.Remove(Me(Me.Count - 1))
        grpHostForm.Controls.Remove(Me(GroupBoxToBeRemoved))
        ''''Me.List.RemoveAt(Me.Count - 1)
        Me.List.RemoveAt(GroupBoxToBeRemoved)
        ''''End If
    End Sub
    Public Sub grpClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        '''''MessageBox.Show("You have clicked button " & CType(CType(sender, System.Windows.Forms.Button).Tag, String))
        GroupBoxNumberClicked = (CType(sender, System.Windows.Forms.GroupBox).Tag) - 1
        ''''MessageBox.Show("You have clicked button " & ButtonNumberClicked.ToString)
        ''''Call DisplayMenu("MainMenu")
        'Select Case MenuLevel
        'Case 1
        Select Case GroupBoxNumberClicked
            Case 1

                'Call DisplayMenu("TypeOfTradeMarkDocument")
                MessageBox.Show("You have clicked group box " & CheckBoxNumberClicked.ToString)
            Case 2
                MessageBox.Show("You have clicked group box " & CheckBoxNumberClicked.ToString)
            Case 3
                MessageBox.Show("You have clicked group box " & CheckBoxNumberClicked.ToString)
            Case 4
                MessageBox.Show("You have clicked group box " & CheckBoxNumberClicked.ToString)
        End Select
        'Case 2
        Select Case GroupBoxNumberClicked
            Case 1
                'Call DisplayMenu("TypeOfTradeMarkApplication")
            Case 2

            Case 3

            Case 4

        End Select
        'Case 3
        Select Case GroupBoxNumberClicked
            Case 1

            Case 2

            Case 3

            Case 4

            Case 5

            Case 6

            Case 7

        End Select
        'End Select
    End Sub
End Class
