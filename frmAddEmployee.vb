Public Class frmAddEmployee
    'Instance data and fields
    Public main As New frmMain
    Public myData As New Database

    'Submits the form
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        myData.AddEmployee(txtFirstName.Text, txtLastName.Text)
        myData.AddAvailability(CInt(txtSun.Text), CInt(txtMon.Text), CInt(txtTue.Text), CInt(txtWed.Text),
                               CInt(txtThu.Text), CInt(txtFri.Text), CInt(txtSat.Text))
        Me.Close()
    End Sub

    'Closes the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class