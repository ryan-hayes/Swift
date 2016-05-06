<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.txtPaySat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPayFri = New System.Windows.Forms.TextBox()
        Me.txtPayWed = New System.Windows.Forms.TextBox()
        Me.txtPayTue = New System.Windows.Forms.TextBox()
        Me.txtPayMon = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPaySun = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPayThu = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.imgSwiftLogo = New System.Windows.Forms.PictureBox()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPaySat
        '
        Me.txtPaySat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPaySat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaySat.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPaySat.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPaySat.Location = New System.Drawing.Point(259, 249)
        Me.txtPaySat.Name = "txtPaySat"
        Me.txtPaySat.Size = New System.Drawing.Size(251, 32)
        Me.txtPaySat.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 36)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Saturday"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 35)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Friday"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 35)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Thursday"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 35)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Wednesday"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 35)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tuesday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sunday"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPayFri
        '
        Me.txtPayFri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPayFri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPayFri.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPayFri.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPayFri.Location = New System.Drawing.Point(259, 208)
        Me.txtPayFri.Name = "txtPayFri"
        Me.txtPayFri.Size = New System.Drawing.Size(251, 32)
        Me.txtPayFri.TabIndex = 48
        '
        'txtPayWed
        '
        Me.txtPayWed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPayWed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPayWed.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPayWed.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPayWed.Location = New System.Drawing.Point(259, 126)
        Me.txtPayWed.Name = "txtPayWed"
        Me.txtPayWed.Size = New System.Drawing.Size(251, 32)
        Me.txtPayWed.TabIndex = 46
        '
        'txtPayTue
        '
        Me.txtPayTue.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPayTue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPayTue.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPayTue.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPayTue.Location = New System.Drawing.Point(259, 85)
        Me.txtPayTue.Name = "txtPayTue"
        Me.txtPayTue.Size = New System.Drawing.Size(251, 32)
        Me.txtPayTue.TabIndex = 45
        '
        'txtPayMon
        '
        Me.txtPayMon.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPayMon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPayMon.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPayMon.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPayMon.Location = New System.Drawing.Point(259, 44)
        Me.txtPayMon.Name = "txtPayMon"
        Me.txtPayMon.Size = New System.Drawing.Size(251, 32)
        Me.txtPayMon.TabIndex = 44
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 167)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 35)
        Me.Panel5.TabIndex = 4
        '
        'txtPaySun
        '
        Me.txtPaySun.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPaySun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaySun.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPaySun.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPaySun.Location = New System.Drawing.Point(259, 3)
        Me.txtPaySun.Name = "txtPaySun"
        Me.txtPaySun.Size = New System.Drawing.Size(251, 32)
        Me.txtPaySun.TabIndex = 43
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtPaySat, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayFri, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayThu, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayWed, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayTue, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayMon, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPaySun, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(177, 88)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(513, 288)
        Me.TableLayoutPanel1.TabIndex = 62
        '
        'txtPayThu
        '
        Me.txtPayThu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPayThu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPayThu.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.txtPayThu.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPayThu.Location = New System.Drawing.Point(259, 167)
        Me.txtPayThu.Name = "txtPayThu"
        Me.txtPayThu.Size = New System.Drawing.Size(251, 32)
        Me.txtPayThu.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 35)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 35)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 35)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 35)
        Me.Panel4.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 208)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(250, 35)
        Me.Panel6.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 249)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(250, 36)
        Me.Panel7.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(451, 242)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(217, 32)
        Me.TextBox2.TabIndex = 60
        Me.TextBox2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(130, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 34)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Edit Salary Rates"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(479, 401)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(108, 39)
        Me.btnGo.TabIndex = 58
        Me.btnGo.Text = "Save"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(288, 401)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 39)
        Me.btnClose.TabIndex = 57
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.SWIFT.My.Resources.Resources.Drawing__48_
        Me.PictureBox2.Location = New System.Drawing.Point(727, 386)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
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
        Me.imgSwiftLogo.TabIndex = 65
        Me.imgSwiftLogo.TabStop = False
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 513)
        Me.Controls.Add(Me.imgSwiftLogo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Salary Rates"
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPaySat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPayFri As TextBox
    Friend WithEvents txtPayWed As TextBox
    Friend WithEvents txtPayTue As TextBox
    Friend WithEvents txtPayMon As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPaySun As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtPayThu As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents imgSwiftLogo As PictureBox
End Class
