<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddAppointment))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDatePicker = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgSwiftLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(392, 255)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(108, 39)
        Me.btnGo.TabIndex = 41
        Me.btnGo.Text = "Add"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(225, 255)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 39)
        Me.btnClose.TabIndex = 40
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtClientName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtClientName.Location = New System.Drawing.Point(206, 132)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(317, 32)
        Me.txtClientName.TabIndex = 37
        Me.txtClientName.Text = "Client Name"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(59, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 34)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Add an Appointment"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDatePicker
        '
        Me.cmbDatePicker.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmbDatePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic)
        Me.cmbDatePicker.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbDatePicker.FormattingEnabled = True
        Me.cmbDatePicker.Location = New System.Drawing.Point(206, 186)
        Me.cmbDatePicker.Name = "cmbDatePicker"
        Me.cmbDatePicker.Size = New System.Drawing.Size(317, 32)
        Me.cmbDatePicker.TabIndex = 42
        Me.cmbDatePicker.Text = "Day this Week"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SWIFT.My.Resources.Resources.Drawing__40_
        Me.PictureBox1.Location = New System.Drawing.Point(627, 304)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'imgSwiftLogo
        '
        Me.imgSwiftLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgSwiftLogo.BackgroundImage = Global.SWIFT.My.Resources.Resources.Drawing__43_
        Me.imgSwiftLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgSwiftLogo.Image = CType(resources.GetObject("imgSwiftLogo.Image"), System.Drawing.Image)
        Me.imgSwiftLogo.Location = New System.Drawing.Point(12, 12)
        Me.imgSwiftLogo.Name = "imgSwiftLogo"
        Me.imgSwiftLogo.Size = New System.Drawing.Size(42, 78)
        Me.imgSwiftLogo.TabIndex = 44
        Me.imgSwiftLogo.TabStop = False
        '
        'frmAddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 412)
        Me.Controls.Add(Me.imgSwiftLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbDatePicker)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add an Appointment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDatePicker As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgSwiftLogo As PictureBox
End Class
