Public Class frmEditEmps
    Private Sub frmEditEmps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SwiftDatabaseDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.SwiftDatabaseDataSet.Employees)
    End Sub
End Class