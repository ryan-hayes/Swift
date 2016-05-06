Public Class frmPayroll
    'Instance data and fields
    Public myData As New Database

    'User loads the Payroll form
    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPaySun.Text = myData.SalaryList(0)
        txtPayMon.Text = myData.SalaryList(1)
        txtPayTue.Text = myData.SalaryList(2)
        txtPayWed.Text = myData.SalaryList(3)
        txtPayThu.Text = myData.SalaryList(4)
        txtPayFri.Text = myData.SalaryList(5)
        txtPaySat.Text = myData.SalaryList(6)
    End Sub

    'Submits the form
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        myData.AddSalaries(CInt(txtPaySun.Text), CInt(txtPayMon.Text), CInt(txtPayTue.Text), CInt(txtPayWed.Text),
                           CInt(txtPayThu.Text), CInt(txtPayFri.Text), CInt(txtPaySat.Text))
        Me.Close()
    End Sub

    'User closes the Payroll form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class