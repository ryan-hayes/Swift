<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSun = New System.Windows.Forms.TextBox()
        Me.imgSwiftLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSat = New System.Windows.Forms.TextBox()
        Me.txtFri = New System.Windows.Forms.TextBox()
        Me.txtThu = New System.Windows.Forms.TextBox()
        Me.txtWed = New System.Windows.Forms.TextBox()
        Me.txtTue = New System.Windows.Forms.TextBox()
        Me.txtMon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(379, 409)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(108, 39)
        Me.btnGo.TabIndex = 11
        Me.btnGo.Text = "Add"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(240, 409)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 39)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Location = New System.Drawing.Point(97, 155)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(251, 32)
        Me.txtFirstName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(60, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 34)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Add an Employee"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Location = New System.Drawing.Point(379, 155)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(251, 32)
        Me.txtLastName.TabIndex = 2
        '
        'txtSun
        '
        Me.txtSun.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtSun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSun.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSun.ForeColor = System.Drawing.SystemColors.Window
        Me.txtSun.Location = New System.Drawing.Point(3, 53)
        Me.txtSun.Name = "txtSun"
        Me.txtSun.Size = New System.Drawing.Size(70, 32)
        Me.txtSun.TabIndex = 3
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
        Me.imgSwiftLogo.TabIndex = 51
        Me.imgSwiftLogo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.SWIFT.My.Resources.Resources.Drawing__41_
        Me.PictureBox2.Location = New System.Drawing.Point(617, 401)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(93, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(375, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Last Name"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSat, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFri, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtThu, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWed, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTue, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMon, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSun, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(97, 268)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 100)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(459, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 50)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Sat"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkGray
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(383, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 50)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Fri"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkGray
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(307, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 50)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Thu"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(231, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 50)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Wed"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(155, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 50)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Tue"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(79, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 50)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Mon"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 50)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Sun"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSat
        '
        Me.txtSat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtSat.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSat.ForeColor = System.Drawing.SystemColors.Window
        Me.txtSat.Location = New System.Drawing.Point(459, 53)
        Me.txtSat.Name = "txtSat"
        Me.txtSat.Size = New System.Drawing.Size(70, 32)
        Me.txtSat.TabIndex = 9
        '
        'txtFri
        '
        Me.txtFri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFri.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFri.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFri.Location = New System.Drawing.Point(383, 53)
        Me.txtFri.Name = "txtFri"
        Me.txtFri.Size = New System.Drawing.Size(70, 32)
        Me.txtFri.TabIndex = 8
        '
        'txtThu
        '
        Me.txtThu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtThu.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThu.ForeColor = System.Drawing.SystemColors.Window
        Me.txtThu.Location = New System.Drawing.Point(307, 53)
        Me.txtThu.Name = "txtThu"
        Me.txtThu.Size = New System.Drawing.Size(70, 32)
        Me.txtThu.TabIndex = 7
        '
        'txtWed
        '
        Me.txtWed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtWed.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWed.ForeColor = System.Drawing.SystemColors.Window
        Me.txtWed.Location = New System.Drawing.Point(231, 53)
        Me.txtWed.Name = "txtWed"
        Me.txtWed.Size = New System.Drawing.Size(70, 32)
        Me.txtWed.TabIndex = 6
        '
        'txtTue
        '
        Me.txtTue.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtTue.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTue.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTue.Location = New System.Drawing.Point(155, 53)
        Me.txtTue.Name = "txtTue"
        Me.txtTue.Size = New System.Drawing.Size(70, 32)
        Me.txtTue.TabIndex = 5
        '
        'txtMon
        '
        Me.txtMon.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtMon.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMon.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMon.Location = New System.Drawing.Point(79, 53)
        Me.txtMon.Name = "txtMon"
        Me.txtMon.Size = New System.Drawing.Size(70, 32)
        Me.txtMon.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(93, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 22)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Shift Rankings (0-lowest, 5-highest)"
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 499)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.imgSwiftLogo)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee"
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtSun As TextBox
    Friend WithEvents imgSwiftLogo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSat As TextBox
    Friend WithEvents txtFri As TextBox
    Friend WithEvents txtThu As TextBox
    Friend WithEvents txtWed As TextBox
    Friend WithEvents txtTue As TextBox
    Friend WithEvents txtMon As TextBox
    Friend WithEvents Label4 As Label
End Class
