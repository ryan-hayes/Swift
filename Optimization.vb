'Import statements
Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization
    'Instance data and fields
    Public Property myData As New Database
    Public myModel As New SimplexSolver

    'Constructor
    Public Sub New(db As Database)
        db = myData
    End Sub

    'Gets shifts that an employee is scheduled for
    Public Function GetShiftsForEmployee(oid As Integer)
        Dim s = From employees In myData.AvailList
                Where employees.ID = oid
                Select employees.Shift
        Return s
    End Function

    'Gets employees that are scheduled for a shift
    Public Function GetEmployeesForShift(sid As Integer)
        Dim o = From shifts In myData.AvailList
                Where shifts.Shift = sid
                Select shifts.ID
        Return o
    End Function

    'Gets an employee object from a provided employee id
    Public Function GetEmployee(oid As Integer) As Employee
        For Each o In myData.EmployeeList
            If o.ID = oid Then
                Return o
            End If
        Next
    End Function

    'Gets a shift object from a provided shift id
    Public Function GetShift(sid As Integer) As Shift
        For Each s In myData.ShiftList
            If s.Shift = sid Then
                Return s
            End If
        Next
    End Function

    'Gets an appointment object from a provided appt id
    Public Function GetAppointments(per As Integer)
        Dim output As Integer
        For Each appt In myData.ApptList
            If appt = per Then
                output += 1
            End If
        Next
        Return output
    End Function

    'Gets the names of clients who hold an appointment
    Public Function GetApptNames(per As Integer)
        Dim a = From appts In myData.ApptNames
                Where appts.period = per
                Select appts.Name
        Return a
    End Function

    'Checks the credentials of the administrative user attempting to log in
    Public Function CheckCredentials(u As String, p As String)
        Dim a = From auth In myData.AuthList
                Where auth.Username = u
                Where auth.Password = p
                Select auth.ID
        Return a
    End Function

    'Solves ranking optimization model
    Public Sub SolveModel()
        'Variables
        For Each a In myData.AvailList
            Dim aid As Integer
            Dim akey As String = "x" & a.ID & a.Shift
            myModel.AddVariable(akey, aid)
            myModel.SetBounds(aid, 0, 1)
        Next
        'Constraints
        For Each o In myData.EmployeeList
            Dim bid As Integer
            Dim bkey As String = "employee" & o.ID
            myModel.AddRow(bkey, bid)

            Dim shifts = GetShiftsForEmployee(o.ID)
            For Each s In shifts
                Dim ckey As String = "x" & o.ID & s
                Dim cid As Integer = myModel.GetIndexFromKey(ckey)
                myModel.SetCoefficient(bid, cid, 1)
            Next
            myModel.SetBounds(bid, 0, 1)
        Next
        For Each s In myData.ShiftList
            Dim did As Integer
            Dim dkey As String = "shift" & s.Shift
            myModel.AddRow(dkey, did)
            Dim employees = GetEmployeesForShift(s.Shift)
            For Each o In employees
                Dim ekey As String = "x" & o & s.Shift
                Dim eid As Integer = myModel.GetIndexFromKey(ekey)
                myModel.SetCoefficient(did, eid, 1)
            Next
            myModel.SetBounds(did, s.NumEmployees, s.NumEmployees)
        Next
        'Objective function
        Dim fid As Integer
        myModel.AddRow("obj", fid)
        For Each a In myData.AvailList
            Dim gkey As String = "x" & a.ID & a.Shift
            Dim gid As Integer = myModel.GetIndexFromKey(gkey)
            myModel.SetCoefficient(fid, gid, a.Rating)
        Next
        'Model implementation
        myModel.AddGoal(fid, 0, True)
        myModel.Solve(New SimplexSolverParams)
        'Feasibility check
        If myModel.Result <> LinearResult.Optimal Then
            MsgBox("Model infeasible.")
        End If
        'Adds values to properties
        For Each a In myData.AvailList
            Dim hkey As Integer = myModel.GetIndexFromKey("x" & a.ID & a.Shift)
            Dim hval As Integer = myModel.GetValue(hkey).ToDouble
            If hval > 0.000001 Then
                Dim o As Employee = GetEmployee(a.ID)
                Dim s As Shift = GetShift(a.Shift)
                o.Shift = s
                s.Employees.Add(o)
            End If
        Next
    End Sub

    'Solves ranking optimization model
    Public Sub SolveModel2()
        Dim myModel As New SimplexSolver
        Dim shftCnt As Integer = myData.ShiftList.Count - 1
        'Variables
        Dim empid(shftCnt) As Integer
        For i As Integer = 0 To shftCnt - 1
            myModel.AddVariable("x" & i, empid(i))
            myModel.SetBounds(empid(i), 0, Rational.PositiveInfinity)
            myModel.SetIntegrality(empid(i), True)
        Next
        'Constraints
        For i As Integer = 0 To shftCnt - 1
            Dim cid As Integer
            myModel.AddRow("shift" & i, cid)
            For j As Integer = 0 To shftCnt - 1
                If (i - j + shftCnt) Mod shftCnt <= CInt(myData.Workspan(0)) Then
                    myModel.SetCoefficient(cid, empid(j), 1)
                End If
            Next
            myModel.SetBounds(cid, CInt(GetAppointments(i)), Rational.PositiveInfinity)
        Next

        'Objective function
        Dim objid As Integer
        myModel.AddRow("obj", objid)
        For i As Integer = 0 To shftCnt - 1
            myModel.SetCoefficient(objid, empid(i), myData.SalaryList(i))
        Next
        'Model implementation
        myModel.AddGoal(objid, 0, True)
        myModel.Solve(New SimplexSolverParams)
        'Feasibility check
        If myModel.Result <> LinearResult.Optimal Then
            MsgBox("Model infeasible.")
        End If
        'Solution return
        For i As Integer = 0 To shftCnt - 1
            myData.ShiftList(i).NumEmployees = myModel.GetValue(empid(i)).ToDouble
        Next
        'Objective function return
        Dim ObjVal As Double = myModel.GetValue(objid).ToDouble
    End Sub
End Class
