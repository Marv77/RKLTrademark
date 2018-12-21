Public Class frmTestToTriggerError
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub frmTestToTriggerError_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .btnDone.Font = RKLFont16BI
            .btnDone.Text = "Done"
        End With
    End Sub
End Class