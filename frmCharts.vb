'Import statements
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmCharts
    'Instance data and fields
    Dim d(7) As Integer

    'Sets the chart data from parameters called in the frmMain class
    Public Sub SetChartData(s As Integer, m As Integer, t As Integer, w As Integer, th As Integer, f As Integer, sa As Integer)
        d(0) = s
        d(1) = m
        d(2) = t
        d(3) = w
        d(4) = th
        d(5) = f
        d(6) = sa
    End Sub

    'Retrives the chart data from the array
    Public Function GetChartData()
        Return d
    End Function

    'Loads the form and creates the graph
    Private Sub frmCharts_Load(sender As Object, e As EventArgs) Handles Me.Load

        chrSolution.Series.Add("Scheduled")
        chrSolution.Series("Scheduled").ChartType = SeriesChartType.Column
        chrSolution.Series("Scheduled").ChartArea = "ChartArea1"

        chrSolution.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
        chrSolution.ChartAreas("ChartArea1").AxisX.Interval = 1
        chrSolution.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
        chrSolution.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont

        chrSolution.ChartAreas("ChartArea1").AxisX.Title = "Day of Week"
        chrSolution.ChartAreas("ChartArea1").AxisY.Title = "# Employees Working"

        Dim dpnt(7) As DataPoint

        For i As Integer = 0 To 6
            dpnt(i) = New DataPoint()
            dpnt(i).SetValueY(GetChartData(i))
            dpnt(i).AxisLabel = GetDay(i)
            chrSolution.Series("Scheduled").Points.Add(dpnt(i))
        Next
    End Sub

    'Gets the day of the week to be displayed on the x-axis
    Private Function GetDay(i As Integer) As String
        Select Case i
            Case 0
                Return "Sun"
            Case 1
                Return "Mon"
            Case 2
                Return "Tue"
            Case 3
                Return "Wed"
            Case 4
                Return "Thu"
            Case 5
                Return "Fri"
            Case 6
                Return "Sat"
        End Select
    End Function
End Class