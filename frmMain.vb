Public Class frmMain
    'Instance data and fields
    Public myData As New Database
    Public Property newOpt As New Optimization(mydata)
    Public uid As String

    Public Sub LoadMain()
        'Solves the optimization model
        newOpt.SolveModel2()
        newOpt.SolveModel()
        'Populates the calendar boxes with scheduled employees
        Dim numShifts As Integer = 3
        Dim s As Shift
        For i As Integer = 1 To 7
            If i = 1 Then 'Sunday
                lstSunday.Items.Clear()
                For j As Integer = 5 To 6
                    s = newOpt.GetShift(i + j)
                    For Each o In s.Employees
                        lstSunday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
                s = newOpt.GetShift(i)
                For Each o In s.Employees
                    lstSunday.Items.Add(o.FirstName & " " & o.LastName)
                Next
            ElseIf i = 2 Then 'Monday
                lstMonday.Items.Clear()
                For j As Integer = 0 To (numShifts - 2) 'avoids negative exception
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstMonday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            ElseIf i = 3 Then 'Tuesday
                lstTuesday.Items.Clear()
                For j = 0 To (numShifts - 1)
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstTuesday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            ElseIf i = 4 Then 'Wednesday
                lstWednesday.Items.Clear()
                For j = 0 To (numShifts - 1)
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstWednesday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            ElseIf i = 5 Then 'Thursday
                lstThursday.Items.Clear()
                For j = 0 To (numShifts - 1)
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstThursday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            ElseIf i = 6 Then 'Friday
                lstFriday.Items.Clear()
                For j = 0 To (numShifts - 1)
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstFriday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            ElseIf i = 7 Then 'Saturday
                lstSaturday.Items.Clear()
                For j = 0 To (numShifts - 1)
                    s = newOpt.GetShift(i - j)
                    For Each o In s.Employees
                        lstSaturday.Items.Add(o.FirstName & " " & o.LastName)
                    Next
                Next
            End If
        Next

        'Highlights today's column
        chngTodayColor()

        'Updates the statistics beneath each calendar column
        Dim totalLabor As Double = (CDbl(lstSunday.Items.Count * myData.SalaryList(0) * myData.ShiftLengths(0))) +
            (CDbl(lstMonday.Items.Count * myData.SalaryList(1) * myData.ShiftLengths(1))) +
            (CDbl(lstTuesday.Items.Count * myData.SalaryList(2) * myData.ShiftLengths(2))) +
            (CDbl(lstWednesday.Items.Count * myData.SalaryList(3) * myData.ShiftLengths(3))) +
            (CDbl(lstThursday.Items.Count * myData.SalaryList(4) * myData.ShiftLengths(4))) +
            (CDbl(lstFriday.Items.Count * myData.SalaryList(5) * myData.ShiftLengths(5))) +
            (CDbl(lstSaturday.Items.Count * myData.SalaryList(6) * myData.ShiftLengths(6)))
        aSun.Text = FormatCurrency(CDbl(lstSunday.Items.Count * myData.SalaryList(0) * myData.ShiftLengths(0)))
        aMon.Text = FormatCurrency(CDbl(lstMonday.Items.Count * myData.SalaryList(1) * myData.ShiftLengths(1)))
        aTue.Text = FormatCurrency(CDbl(lstTuesday.Items.Count * myData.SalaryList(2) * myData.ShiftLengths(2)))
        aWed.Text = FormatCurrency(CDbl(lstWednesday.Items.Count * myData.SalaryList(3) * myData.ShiftLengths(3)))
        aThu.Text = FormatCurrency(CDbl(lstThursday.Items.Count * myData.SalaryList(4) * myData.ShiftLengths(4)))
        aFri.Text = FormatCurrency(CDbl(lstFriday.Items.Count * myData.SalaryList(5) * myData.ShiftLengths(5)))
        aSat.Text = FormatCurrency(CDbl(lstSaturday.Items.Count * myData.SalaryList(6) * myData.ShiftLengths(6)))
        bSun.Text = lstSunday.Items.Count
        bMon.Text = lstMonday.Items.Count
        bTue.Text = lstTuesday.Items.Count
        bWed.Text = lstWednesday.Items.Count
        bThu.Text = lstThursday.Items.Count
        bFri.Text = lstFriday.Items.Count
        bSat.Text = lstSaturday.Items.Count
        cSun.Text = FormatPercent(CDbl(lstSunday.Items.Count * myData.SalaryList(0) * myData.ShiftLengths(0)) / totalLabor)
        cMon.Text = FormatPercent(CDbl(lstMonday.Items.Count * myData.SalaryList(1) * myData.ShiftLengths(1)) / totalLabor)
        cTue.Text = FormatPercent(CDbl(lstTuesday.Items.Count * myData.SalaryList(2) * myData.ShiftLengths(2)) / totalLabor)
        cWed.Text = FormatPercent(CDbl(lstWednesday.Items.Count * myData.SalaryList(3) * myData.ShiftLengths(3)) / totalLabor)
        cThu.Text = FormatPercent(CDbl(lstThursday.Items.Count * myData.SalaryList(4) * myData.ShiftLengths(4)) / totalLabor)
        cFri.Text = FormatPercent(CDbl(lstFriday.Items.Count * myData.SalaryList(5) * myData.ShiftLengths(5)) / totalLabor)
        cSat.Text = FormatPercent(CDbl(lstSaturday.Items.Count * myData.SalaryList(6) * myData.ShiftLengths(6)) / totalLabor)
        dSun.Text = myData.ShiftLengths(0)
        dMon.Text = myData.ShiftLengths(1)
        dTue.Text = myData.ShiftLengths(2)
        dWed.Text = myData.ShiftLengths(3)
        dThu.Text = myData.ShiftLengths(4)
        dFri.Text = myData.ShiftLengths(5)
        dSat.Text = myData.ShiftLengths(6)
    End Sub

    Public Sub chngTodayColor()
        Dim a = Now.DayOfWeek.ToString()
        Dim bcT As Integer() = {238, 255, 232}
        If a = "Sunday" Then
            lstSunday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(1)
            lblMetroWorking.Text = lstSunday.Items.Count()
        ElseIf a = "Monday" Then
            lstMonday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(2)
            lblMetroWorking.Text = lstMonday.Items.Count()
        ElseIf a = "Tuesday" Then
            lstTuesday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(3)
            lblMetroWorking.Text = lstTuesday.Items.Count()
        ElseIf a = "Wednesday" Then
            lstWednesday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(4)
            lblMetroWorking.Text = lstWednesday.Items.Count()
        ElseIf a = "Thursday" Then
            lstThursday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(5)
            lblMetroWorking.Text = lstThursday.Items.Count()
        ElseIf a = "Friday" Then
            lstFriday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(6)
            lblMetroWorking.Text = lstFriday.Items.Count()
        ElseIf a = "Saturday" Then
            lstSaturday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
            changeMetroGrid(7)
            lblMetroWorking.Text = lstSaturday.Items.Count()
        End If
    End Sub

    'Event handler for the Load behavior of the form
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Gets the name of the current user
        lblUsername.Text = Environment.UserName
        'Gets today's date
        Dim tDate = DateTime.Now.ToString("MM/dd/yyyy")
        lblToday.Text = tDate
        lblSnapshotHdr.Text = "Today's Snapshot"
        'Adds dates to the headers of each calendar column
        Dim getSunday As Date = Now.AddDays(0 - Now.DayOfWeek).ToString("MM/dd/yyyy")
        Dim getSaturday As Date = Now.AddDays(6 - Now.DayOfWeek).ToString("MM/dd/yyyy")
        lblWeekOf.Text = "Week of Sunday " & getSunday & " - Saturday " & getSaturday
        btnSunHeader.Text = Now.AddDays(0 - Now.DayOfWeek).ToString("dd")
        btnMonHeader.Text = Now.AddDays(1 - Now.DayOfWeek).ToString("dd")
        btnTueHeader.Text = Now.AddDays(2 - Now.DayOfWeek).ToString("dd")
        btnWedHeader.Text = Now.AddDays(3 - Now.DayOfWeek).ToString("dd")
        btnThuHeader.Text = Now.AddDays(4 - Now.DayOfWeek).ToString("dd")
        btnFriHeader.Text = Now.AddDays(5 - Now.DayOfWeek).ToString("dd")
        btnSatHeader.Text = Now.AddDays(6 - Now.DayOfWeek).ToString("dd")
        LoadMain()
    End Sub

    'Holds the hours that the business is open on each day
    Dim startTimeByDate As Integer() = {11, 12, 12, 12, 12, 11, 11}
    Dim endTimeByDate As Integer() = {7, 8, 8, 9, 10, 11, 11}

    'Changes the values in the metro grid when a day is selected
    Private Sub changeMetroGrid(dayInt As Integer)
        lblMetroStartTime.Text = startTimeByDate(dayInt - 1)
        lblMetroEndTime.Text = endTimeByDate(dayInt - 1)
        If startTimeByDate(dayInt - 1) = 12 Then
            lblMetroStartTimeIndicator.Text = "PM"
        Else
            lblMetroStartTimeIndicator.Text = "AM"
        End If
        If endTimeByDate(dayInt - 1) = 12 Then
            lblMetroEndTimeIndicator.Text = "AM"
        Else
            lblMetroEndTimeIndicator.Text = "PM"
        End If
        lblMetroAppts.Text = newOpt.GetAppointments(CInt(dayInt))
        lstSidebarMulti.Items.Clear()
        For Each a In newOpt.GetApptNames(dayInt)
            lstSidebarMulti.Items.Add(a)
        Next
    End Sub

    Private Sub clearLists()
        lstSunday.Items.Clear()
        lstMonday.Items.Clear()
        lstTuesday.Items.Clear()
        lstWednesday.Items.Clear()
        lstThursday.Items.Clear()
        lstFriday.Items.Clear()
        lstSaturday.Items.Clear()
    End Sub

    'User clicks on Sunday column header
    Private Sub btnSunHeader_Click(sender As Object, e As EventArgs) Handles btnSunHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstSunday.Items.Count()
        changeMetroGrid(1)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(0 - Now.DayOfWeek).ToString("MM/dd")
        lstSunday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Monday column header
    Private Sub btnMonHeader_Click(sender As Object, e As EventArgs) Handles btnMonHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstMonday.Items.Count()
        changeMetroGrid(2)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(1 - Now.DayOfWeek).ToString("MM/dd")
        lstMonday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Tuesday column header
    Private Sub btnTueHeader_Click(sender As Object, e As EventArgs) Handles btnTueHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstTuesday.Items.Count()
        changeMetroGrid(3)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(2 - Now.DayOfWeek).ToString("MM/dd")
        lstTuesday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Wednesday column header
    Private Sub btnWedHeader_Click(sender As Object, e As EventArgs) Handles btnWedHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstWednesday.Items.Count()
        changeMetroGrid(4)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(3 - Now.DayOfWeek).ToString("MM/dd")
        lstWednesday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Thursday column header
    Private Sub btnThuHeader_Click(sender As Object, e As EventArgs) Handles btnThuHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstThursday.Items.Count()
        changeMetroGrid(5)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(4 - Now.DayOfWeek).ToString("MM/dd")
        lstThursday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Friday column header
    Private Sub btnFriHeader_Click(sender As Object, e As EventArgs) Handles btnFriHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstFriday.Items.Count()
        changeMetroGrid(6)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(5 - Now.DayOfWeek).ToString("MM/dd")
        lstFriday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on Friday column header
    Private Sub btnSatHeader_Click(sender As Object, e As EventArgs) Handles btnSatHeader.Click
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstSaturday.Items.Count()
        changeMetroGrid(7)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(6 - Now.DayOfWeek).ToString("MM/dd")
        lstSaturday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the New Appointment button in the header
    Private Sub tsbNewAppt_Click(sender As Object, e As EventArgs) Handles tsbNewAppt.Click
        Dim oForm As frmAddAppointment
        oForm = New frmAddAppointment
        oForm.Activate()
        oForm.Show()
    End Sub

    'User clicks on the Add Employee button in the header
    Private Sub tsbAddEmployee_Click(sender As Object, e As EventArgs) Handles tsbAddEmployee.Click
        Dim oForm As frmAddEmployee
        oForm = New frmAddEmployee
        oForm.Activate()
        oForm.Show()
    End Sub

    'User clicks on the Salaries button in the header
    Private Sub tsbPayroll_Click(sender As Object, e As EventArgs) Handles tsbPayroll.Click
        Dim oForm As frmPayroll
        oForm = New frmPayroll
        oForm.Activate()
        oForm.Show()
    End Sub

    'User clicks on the Shifts button in the header
    Private Sub tsbShifts_Click(sender As Object, e As EventArgs) Handles tsbShifts.Click
        Dim oForm As frmShift
        oForm = New frmShift
        oForm.Activate()
        oForm.Show()
    End Sub

    'User clicks on the Sunday lstbox
    Private Sub lstSunday_MouseClick(sender As Object, e As EventArgs) Handles lstSunday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstSunday.Items.Count()
        changeMetroGrid(1)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(0 - Now.DayOfWeek).ToString("MM/dd")
        lstSunday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Monday lstbox
    Private Sub lstMonday_MouseClick(sender As Object, e As EventArgs) Handles lstMonday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstMonday.Items.Count()
        changeMetroGrid(2)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(1 - Now.DayOfWeek).ToString("MM/dd")
        lstMonday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Tuesday lstbox
    Private Sub lstTuesday_MouseClick(sender As Object, e As EventArgs) Handles lstTuesday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstTuesday.Items.Count()
        changeMetroGrid(3)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(2 - Now.DayOfWeek).ToString("MM/dd")
        lstTuesday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Wednesday lstbox
    Private Sub lstWednesday_MouseClick(sender As Object, e As EventArgs) Handles lstWednesday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstWednesday.Items.Count()
        changeMetroGrid(4)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(3 - Now.DayOfWeek).ToString("MM/dd")
        lstWednesday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Thursday lstbox
    Private Sub lstThursday_MouseClick(sender As Object, e As EventArgs) Handles lstThursday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstThursday.Items.Count()
        changeMetroGrid(5)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(4 - Now.DayOfWeek).ToString("MM/dd")
        lstThursday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Friday lstbox
    Private Sub lstFriday_MouseClick(sender As Object, e As EventArgs) Handles lstFriday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstFriday.Items.Count()
        changeMetroGrid(6)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(5 - Now.DayOfWeek).ToString("MM/dd")
        lstFriday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'User clicks on the Saturday lstbox
    Private Sub lstSaturday_MouseClick(sender As Object, e As EventArgs) Handles lstSaturday.SelectedIndexChanged
        backColorChng()
        chngTodayColor()
        lblMetroWorking.Text = lstSaturday.Items.Count()
        changeMetroGrid(7)
        lblSnapshotHdr.Text = "Snapshot of " & Now.AddDays(6 - Now.DayOfWeek).ToString("MM/dd")
        lstSaturday.BackColor() = Color.FromArgb(198, 240, 156)
    End Sub

    'Opens the Meet the Team form
    Private Sub btnTeam_Click(sender As Object, e As EventArgs) Handles btnTeam.Click
        Dim oForm As frmTeam
        oForm = New frmTeam
        oForm.Activate()
        oForm.Show()
    End Sub

    'Logs the user out of the system when clicked
    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        Me.Close()
    End Sub

    'Opens the How To form when clicked by the user
    Private Sub btnHowTo_Click(sender As Object, e As EventArgs) Handles btnHowTo.Click
        Dim oForm As frmHowTo
        oForm = New frmHowTo
        oForm.Activate()
        oForm.Show()
    End Sub

    'Recalculates the optimization model based on new parameters
    Private Sub tsbRecalc_Click(sender As Object, e As EventArgs) Handles tsbRecalc.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    'Changes the background color of the day-of-week listboxes
    Private Sub backColorChng()
        Dim bcT As Integer() = {222, 242, 252}
        lstSunday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstMonday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstTuesday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstWednesday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstThursday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstFriday.BackColor = Color.FromArgb(bcT(0), bcT(1), bcT(2))
        lstSaturday.BackColor() = Color.FromArgb(bcT(0), bcT(1), bcT(2))
    End Sub

    'Opens the View/Edit Appointments box when clicked by the user
    Private Sub tsbEditAppts_Click(sender As Object, e As EventArgs) Handles tsbEditAppts.Click
        Dim oForm As frmEditAppts
        oForm = New frmEditAppts
        oForm.Activate()
        oForm.Show()
    End Sub

    'Opens the View/Edit Employees box when clicked by the user
    Private Sub tsbEditEmps_Click(sender As Object, e As EventArgs) Handles tsbEditEmps.Click
        Dim oForm As frmEditEmps
        oForm = New frmEditEmps
        oForm.Activate()
        oForm.Show()
    End Sub

    'Opens the Charts box when clicked by the user
    Private Sub tsbCharts_Click(sender As Object, e As EventArgs) Handles tsbCharts.Click
        Dim oForm As frmCharts
        oForm = New frmCharts
        oForm.Activate()
        oForm.SetChartData(CInt(lstSunday.Items.Count), CInt(lstMonday.Items.Count), CInt(lstTuesday.Items.Count),
                               CInt(lstWednesday.Items.Count), CInt(lstThursday.Items.Count), CInt(lstFriday.Items.Count),
                               CInt(lstSaturday.Items.Count))
        oForm.Show()
    End Sub
End Class