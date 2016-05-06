'Import statements
Imports System.Data.OleDb
Public Class frmAuth
    'Instance data and fields
    Public myData As New Database
    Public Property newOpt As New Optimization(myData)

    'Close procedure for transitioning between login form and main form
    Private Sub routeClosing()
        Me.Hide()
    End Sub

    'Authenticates the user based on the provided credentials
    Private Sub auth()
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim valid As Boolean = False
        For Each a In newOpt.CheckCredentials(username, password)
            valid = True
        Next
        If valid Then
            routeClosing()
            Dim oForm As frmMain
            oForm = New frmMain
            oForm.uid = username
            oForm.Activate()
            oForm.Show()
        Else
            MsgBox("The username and/or password you provided were not able to be authenticated. Please try again.", vbCritical, "Authentication Error")
        End If
    End Sub

    'Attempts to authenticate input when the user clicks this button
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        auth()
        routeClosing()
    End Sub

    'Closes the form if the user presses the "Close" button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class