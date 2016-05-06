'Import statements
Imports System.Data.OleDb

Public Class Database
    'Instance data and fields
    Private myDataAdapter As OleDbDataAdapter
    Private myConnectionStr As String
    Private myCommand As OleDbCommand
    Private myDataSet As New DataSet
    Private mySQL As String
    Private myConnection As OleDbConnection
    Public EmployeeList As New List(Of Employee)
    Public AvailList As New List(Of Avail)
    Public ShiftList As New List(Of Shift)
    Public PeriodList As New List(Of Integer)
    Private myDataReader As OleDbDataReader
    Public ApptList As New List(Of Integer)
    Public ApptNames As New List(Of Appointment)
    Public AuthList As New List(Of Authentication)
    Public SalaryList As New List(Of Integer)
    Public ShiftLengths As New List(Of Integer)
    Public Workspan As New List(Of Integer)

    'Constructor
    Public Sub New()
        FillDataSet()
        FillAllLists()
    End Sub

    'Methods
    Public Sub CreateDataAdapter(tableName As String)
        myConnectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\SwiftDatabase.accdb"
        mySQL = "SELECT * FROM " & tableName
        myDataAdapter = New OleDbDataAdapter(mySQL, myConnectionStr)
        myDataAdapter.Fill(myDataSet, tableName)
    End Sub

    'Gets the value at a specific location in a table in the Access db
    Public Function GetValue(i As Integer, colName As String, tableName As String) As String
        Return myDataSet.Tables(tableName).Rows(i)(colName).ToString
    End Function

    'Gets the number of rows in a specified table in the Access db
    Public Function GetRowCount(tableName As String) As Integer
        Return myDataSet.Tables(tableName).Rows.Count
    End Function

    'Creates the data adapters for referencing tables in the Access db
    Public Sub FillDataSet()
        CreateDataAdapter("Employees")
        CreateDataAdapter("Availability")
        CreateDataAdapter("Shifts")
        CreateDataAdapter("Appointments")
        CreateDataAdapter("Periods")
        CreateDataAdapter("Authentication")
        CreateDataAdapter("Workspan")
    End Sub

    'Fills the list of employees from the Access db
    Public Sub FillEmployeeList()
        EmployeeList.Clear()
        For i As Integer = 0 To GetRowCount("Employees") - 1
            Dim r As New Employee
            r.ID = CInt(GetValue(i, "ID", "Employees"))
            r.FirstName = GetValue(i, "FirstName", "Employees")
            r.LastName = GetValue(i, "LastName", "Employees")
            EmployeeList.Add(r)
        Next
    End Sub

    'Fills the list of employee availabilities from the Access db
    Public Sub FillAvailList()
        AvailList.Clear()
        For i As Integer = 0 To GetRowCount("Availability") - 1
            Dim r As New Avail
            r.ID = CInt(GetValue(i, "ID", "Availability"))
            r.Shift = CInt(GetValue(i, "Shift", "Availability"))
            r.Rating = CDbl(GetValue(i, "Rating", "Availability"))
            AvailList.Add(r)
        Next
    End Sub

    'Fills the list of shifts from the Access db
    Public Sub FillShiftList()
        ShiftList.Clear()
        For i As Integer = 0 To GetRowCount("Shifts") - 1
            Dim r As New Shift
            r.Shift = CInt(GetValue(i, "Shift", "Shifts"))
            r.NumEmployees = CInt(GetValue(i, "NumEmployees", "Shifts"))
            ShiftList.Add(r)
        Next
    End Sub

    'Fills the list of periods from the Access db
    Public Sub FillPeriodList()
        PeriodList.Clear()
        For i As Integer = 0 To GetRowCount("Shifts") - 1
            Dim r As New Integer
            r = CInt(GetValue(i, "ID", "Periods"))
            PeriodList.Add(r)
        Next
    End Sub

    'Fills the list of appointments from the Access db
    Public Sub FillApptList()
        ApptList.Clear()
        For i As Integer = 0 To GetRowCount("Appointments") - 1
            Dim r As New Integer
            r = CInt(GetValue(i, "Period", "Appointments"))
            ApptList.Add(r)
        Next
    End Sub

    'Fills the list of clients holding an appointment from the Access db
    Public Sub FillApptNamesList()
        ApptNames.Clear()
        For i As Integer = 0 To GetRowCount("Appointments") - 1
            Dim r As New Appointment
            r.ID = CInt(GetValue(i, "ID", "Appointments"))
            r.Name = GetValue(i, "Name", "Appointments")
            r.period = CInt(GetValue(i, "Period", "Appointments"))
            ApptNames.Add(r)
        Next
    End Sub

    'Fills the list of authorized users from the Access db
    Public Sub FillAuthList()
        AuthList.Clear()
        For i As Integer = 0 To GetRowCount("Authentication") - 1
            Dim r As New Authentication
            r.ID = CInt(GetValue(i, "ID", "Authentication"))
            r.Username = GetValue(i, "Username", "Authentication")
            r.Password = GetValue(i, "Password", "Authentication")
            r.FullName = GetValue(i, "FullName", "Authentication")
            AuthList.Add(r)
        Next
    End Sub

    'Fills the list of salaries by day from the Access db
    Public Sub FillSalaryList()
        SalaryList.Clear()
        For i As Integer = 0 To GetRowCount("Shifts") - 1
            Dim r As New Integer
            r = CInt(GetValue(i, "Salary", "Shifts"))
            SalaryList.Add(r)
        Next
    End Sub

    'Fills the shift lengths list from the Access db
    Public Sub FillShiftLengthList()
        ShiftLengths.Clear()
        For i As Integer = 0 To GetRowCount("Shifts") - 1
            Dim r As New Integer
            r = CInt(GetValue(i, "Length", "Shifts"))
            ShiftLengths.Add(r)
        Next
    End Sub

    'Fills the workspan list from the Access db
    Public Sub FillWorkspan()
        Workspan.Clear()
        For i As Integer = 0 To GetRowCount("Workspan") - 1
            Dim r As New Integer
            r = CInt(GetValue(i, "Length", "Workspan"))
            Workspan.Add(r)
        Next
    End Sub

    'Fills all of the lists from the Access db
    Public Sub FillAllLists()
        FillEmployeeList()
        FillAvailList()
        FillShiftList()
        FillPeriodList()
        FillApptList()
        FillApptNamesList()
        FillAuthList()
        FillSalaryList()
        FillShiftLengthList()
        FillWorkspan()
    End Sub

    'Supports the validation process when the user logs in
    Public Function GetNameFromUid(uid As String)
        Dim o = From u In AuthList
                Where u.Username = uid
                Select u.FullName
        Return o
    End Function

    'Changes the shift length variable for the optimization problem
    Public Function ChangeShiftLength(n As Integer)
        Dim dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbSource = "Data Source=" & Application.StartupPath & "\SwiftDatabase.accdb"

        Dim sql = "UPDATE Workspan " &
            "SET Length=(@p1);"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", n)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        FillAllLists()
    End Function

    'Adds an employee to the Access db when the Add Employee form is submitted by the user
    Public Function AddEmployee(f As String, l As String)
        Dim dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbSource = "Data Source=" & Application.StartupPath & "\SwiftDatabase.accdb"

        Dim nuIndex As Integer = EmployeeList.Count() + 1

        Dim sql = "INSERT INTO Employees " &
            "VALUES (@p1, @p2, @p3);"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", nuIndex)
                cmd.Parameters.AddWithValue("@p2", f)
                cmd.Parameters.AddWithValue("@p3", l)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        FillAllLists()
    End Function

    'Adds an appointment to the Access db when the Add Appointment form is submitted by the user
    Public Function AddAppointment(n As String, p As Integer)
        Dim dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbSource = "Data Source=" & Application.StartupPath & "\SwiftDatabase.accdb"

        Dim nuIndex As Integer = ApptList.Count() + 1


        Dim sql = "INSERT INTO Appointments " &
            "VALUES (@p1, @p2, @p3);"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", nuIndex)
                cmd.Parameters.AddWithValue("@p2", n)
                cmd.Parameters.AddWithValue("@p3", p)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        FillAllLists()
    End Function

    'Adds employee availability values when the Add Employee form is submitted by the user
    Public Function AddAvailability(s As Double, m As Double, t As Double, w As Double, th As Double, f As Double, sa As Double)
        Dim i As Integer = EmployeeList.Count() + 1
        AddAvailabilityForShift(i, 1, s)
        AddAvailabilityForShift(i, 2, m)
        AddAvailabilityForShift(i, 3, t)
        AddAvailabilityForShift(i, 4, w)
        AddAvailabilityForShift(i, 5, th)
        AddAvailabilityForShift(i, 6, f)
        AddAvailabilityForShift(i, 7, sa)
        FillAllLists()
    End Function

    'Adds an employee availability value for a given day when the Add Employee form is submitted by the user
    Public Function AddAvailabilityForShift(id As Integer, shift As Integer, rating As Double)
        Dim dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbSource = "Data Source=" & Application.StartupPath & "\SwiftDatabase.accdb"

        Dim sql = "INSERT INTO Availability " &
            "VALUES (@p1, @p2, @p3);"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", id)
                cmd.Parameters.AddWithValue("@p2", shift)
                cmd.Parameters.AddWithValue("@p3", rating)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        FillAllLists()
    End Function

    'Adds salary values when the Change Salary form is submitted by the user
    Public Function AddSalaries(s As Double, m As Double, t As Double, w As Double, th As Double, f As Double, sa As Double)
        AddSalariesForShift(1, s)
        AddSalariesForShift(2, m)
        AddSalariesForShift(3, t)
        AddSalariesForShift(4, w)
        AddSalariesForShift(5, th)
        AddSalariesForShift(6, f)
        AddSalariesForShift(7, sa)
    End Function

    'Adds a salary value for a given day when the Change Salary form is submitted by the user
    Public Function AddSalariesForShift(id As Integer, salary As Integer)
        Dim dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Dim dbSource = "Data Source=" & Application.StartupPath & "\SwiftDatabase.accdb"

        Dim sql = "UPDATE Shifts " &
            "SET Salary=(@p1) WHERE Shift=(@p2);"

        Using con = New OleDb.OleDbConnection(dbProvider & dbSource)
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", salary)
                cmd.Parameters.AddWithValue("@p2", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        FillAllLists()
    End Function
End Class


