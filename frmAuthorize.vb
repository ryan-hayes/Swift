'Import statements
Imports System.Data.OleDb
Public Class frmAuth
    'Instance data and fields
    Public myData As New Database
    Public Property newOpt As New Optimization(myData)

    'Constructor
    Public Sub New(db As Database)
        db = myData
    End Sub

    Public Function GetNameOfUser(u As String)
        Dim a = From auth In myData.AuthList
                Where auth.Username = u
                Select auth.FullName
        Return a
    End Function

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
            oForm.Activate()
            For Each u In GetNameOfUser(username)
                oForm.lblUsername.Text = u
            Next
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