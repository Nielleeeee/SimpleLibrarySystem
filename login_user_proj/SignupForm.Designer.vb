<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpBday = New System.Windows.Forms.DateTimePicker()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.txtStudnum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbShowpass = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FULL NAME*"
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(56, 136)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(255, 26)
        Me.txtUname.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(55, 188)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(255, 26)
        Me.txtPass.TabIndex = 4
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD*"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(251, 308)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(60, 26)
        Me.txtAge.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(207, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "AGE*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SEX*"
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMale.ForeColor = System.Drawing.Color.White
        Me.rdMale.Location = New System.Drawing.Point(10, 23)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(61, 23)
        Me.rdMale.TabIndex = 8
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFemale.ForeColor = System.Drawing.Color.White
        Me.rdFemale.Location = New System.Drawing.Point(70, 23)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(75, 23)
        Me.rdFemale.TabIndex = 9
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BIRTH DATE*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(55, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "COURSE*"
        '
        'dtpBday
        '
        Me.dtpBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBday.Location = New System.Drawing.Point(55, 368)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(255, 26)
        Me.dtpBday.TabIndex = 13
        '
        'cbCourse
        '
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Items.AddRange(New Object() {"DCvET", "DCET", "DEET", "DECET", "DICT", "DMET", "DOMT", "DRET"})
        Me.cbCourse.Location = New System.Drawing.Point(55, 419)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(255, 28)
        Me.cbCourse.TabIndex = 14
        '
        'txtStudnum
        '
        Me.txtStudnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudnum.Location = New System.Drawing.Point(55, 87)
        Me.txtStudnum.Name = "txtStudnum"
        Me.txtStudnum.Size = New System.Drawing.Size(255, 26)
        Me.txtStudnum.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "STUDENT NUMBER*"
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSignup.Location = New System.Drawing.Point(55, 465)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(255, 39)
        Me.btnSignup.TabIndex = 17
        Me.btnSignup.Text = "SIGNUP"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(56, 510)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(255, 39)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 34)
        Me.Panel2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "SIGNUP FORM"
        '
        'picExit
        '
        Me.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(10, 6)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(10, 10)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExit.TabIndex = 12
        Me.picExit.TabStop = False
        '
        'lblMini
        '
        Me.lblMini.AutoSize = True
        Me.lblMini.BackColor = System.Drawing.Color.Transparent
        Me.lblMini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMini.Location = New System.Drawing.Point(26, -4)
        Me.lblMini.Name = "lblMini"
        Me.lblMini.Size = New System.Drawing.Size(19, 20)
        Me.lblMini.TabIndex = 13
        Me.lblMini.Text = "_"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.login_user_proj.My.Resources.Resources._284584551_5333264930084612_8327250292297784134_n
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(364, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 580)
        Me.Panel1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 93)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Great, You will be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "able to access your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "digital library soon!"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbShowpass
        '
        Me.cbShowpass.AutoSize = True
        Me.cbShowpass.ForeColor = System.Drawing.Color.White
        Me.cbShowpass.Location = New System.Drawing.Point(210, 275)
        Me.cbShowpass.Name = "cbShowpass"
        Me.cbShowpass.Size = New System.Drawing.Size(101, 17)
        Me.cbShowpass.TabIndex = 21
        Me.cbShowpass.Text = "Show password"
        Me.cbShowpass.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.rdFemale)
        Me.Panel3.Controls.Add(Me.rdMale)
        Me.Panel3.Location = New System.Drawing.Point(55, 286)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 63)
        Me.Panel3.TabIndex = 22
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(55, 240)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(255, 26)
        Me.txtConfirmPass.TabIndex = 24
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(53, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "CONFIRM PASSWORD*"
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 580)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbShowpass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.txtStudnum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbCourse)
        Me.Controls.Add(Me.dtpBday)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignupForm"
        Me.Text = "SIGNUP FORM"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpBday As DateTimePicker
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents txtStudnum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbShowpass As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label10 As Label
End Class
