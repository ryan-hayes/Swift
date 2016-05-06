<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuth))
        Me.imgSwiftLogo = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSwiftTitle = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgSwiftLogo
        '
        Me.imgSwiftLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgSwiftLogo.BackgroundImage = Global.SWIFT.My.Resources.Resources.Drawing
        Me.imgSwiftLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgSwiftLogo.Location = New System.Drawing.Point(143, 38)
        Me.imgSwiftLogo.Name = "imgSwiftLogo"
        Me.imgSwiftLogo.Size = New System.Drawing.Size(72, 137)
        Me.imgSwiftLogo.TabIndex = 27
        Me.imgSwiftLogo.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(355, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 23)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "EMS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSwiftTitle
        '
        Me.lblSwiftTitle.AutoSize = True
        Me.lblSwiftTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSwiftTitle.Font = New System.Drawing.Font("Corbel", 70.0!)
        Me.lblSwiftTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSwiftTitle.Location = New System.Drawing.Point(209, 51)
        Me.lblSwiftTitle.Name = "lblSwiftTitle"
        Me.lblSwiftTitle.Size = New System.Drawing.Size(253, 115)
        Me.lblSwiftTitle.TabIndex = 28
        Me.lblSwiftTitle.Text = "Swift"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Location = New System.Drawing.Point(148, 254)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(275, 32)
        Me.txtUsername.TabIndex = 30
        Me.txtUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPassword.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Location = New System.Drawing.Point(148, 304)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(275, 32)
        Me.txtPassword.TabIndex = 32
        Me.txtPassword.Text = "Password"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(148, 371)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 39)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.BackgroundImage = CType(resources.GetObject("btnGo.BackgroundImage"), System.Drawing.Image)
        Me.btnGo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(315, 371)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(108, 39)
        Me.btnGo.TabIndex = 36
        Me.btnGo.Text = "Log In"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-17, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(613, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Please log in to continue."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(581, 476)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.imgSwiftLogo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSwiftTitle)
        Me.Name = "UserAuth"
        Me.Text = "Swift EMS : User Authentication"
        CType(Me.imgSwiftLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgSwiftLogo As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSwiftTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents Label3 As Label
End Class
