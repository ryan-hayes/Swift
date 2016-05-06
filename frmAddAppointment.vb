Public Class frmAddAppointment
    'Instance data and fields
    Public myData As New Database

    'Specifies the load behavior for the form
    Private Sub frmAddAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbDatePicker.Items.Add("Sunday")
        cmbDatePicker.Items.Add("Monday")
        cmbDatePicker.Items.Add("Tuesday")
        cmbDatePicker.Items.Add("Wednesday")
        cmbDatePicker.Items.Add("Thursday")
        cmbDatePicker.Items.Add("Friday")
        cmbDatePicker.Items.Add("Saturday")
    End Sub

    'Specifies the add behavior when the button is clicked by the user
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        myData.AddAppointment(txtClientName.Text, cmbDatePicker.SelectedIndex + 1)
        Me.Close()
    End Sub

    'Closes the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class