<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharts))
        Me.chrSolution = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chrSolution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chrSolution
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrSolution.ChartAreas.Add(ChartArea1)
        Me.chrSolution.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chrSolution.Legends.Add(Legend1)
        Me.chrSolution.Location = New System.Drawing.Point(0, 0)
        Me.chrSolution.Name = "chrSolution"
        Me.chrSolution.Size = New System.Drawing.Size(738, 445)
        Me.chrSolution.TabIndex = 1
        Me.chrSolution.Text = "Chart1"
        '
        'frmCharts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 445)
        Me.Controls.Add(Me.chrSolution)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCharts"
        Me.Text = "Employee Scheduling Chart"
        CType(Me.chrSolution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chrSolution As DataVisualization.Charting.Chart
End Class
