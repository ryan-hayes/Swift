Public Class frmEditAppts
    Private Sub frmEditAppt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SwiftDatabaseDataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SwiftDatabaseDataSet.Appointments)
    End Sub
End Class