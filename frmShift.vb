Public Class frmShift
    'Instance data and fields
    Public myData As New Database
    Public Property newOpt As New Optimization(myData)

    'Users loads the form
    Private Sub frmShift_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 1 To 7
            cmbShiftPicker.Items.Add(i)
        Next
    End Sub

    'User selects a new shift and submits changes
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        myData.ChangeShiftLength(CInt(cmbShiftPicker.SelectedItem()))
        Me.Close()
    End Sub

    'User closes the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class