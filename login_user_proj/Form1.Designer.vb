<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbShowpass = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnLadmin = New System.Windows.Forms.Button()
        Me.btnLuser = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtStudnum = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblForgotPass)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cbShowpass)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSignup)
        Me.Panel1.Controls.Add(Me.btnLadmin)
        Me.Panel1.Controls.Add(Me.btnLuser)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtStudnum)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 464)
        Me.Panel1.TabIndex = 0
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblForgotPass.Location = New System.Drawing.Point(76, 278)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(99, 13)
        Me.lblForgotPass.TabIndex = 22
        Me.lblForgotPass.Text = "Forgot Password?"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblName.Location = New System.Drawing.Point(78, 130)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 13)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "NAME: "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(79, 146)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 22)
        Me.txtName.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.login_user_proj.My.Resources.Resources._280960118_1444965122614051_3527457123771302743_n
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(358, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(254, 464)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Historic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(44, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Online Library"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PUP-ITECH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbShowpass
        '
        Me.cbShowpass.AutoSize = True
        Me.cbShowpass.ForeColor = System.Drawing.Color.White
        Me.cbShowpass.Location = New System.Drawing.Point(198, 277)
        Me.cbShowpass.Name = "cbShowpass"
        Me.cbShowpass.Size = New System.Drawing.Size(101, 17)
        Me.cbShowpass.TabIndex = 11
        Me.cbShowpass.Text = "Show password"
        Me.cbShowpass.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(76, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(78, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "STUDENT / ADMIN NUMBER:"
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.Location = New System.Drawing.Point(79, 413)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(220, 36)
        Me.btnSignup.TabIndex = 7
        Me.btnSignup.Text = "SIGN-UP"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnLadmin
        '
        Me.btnLadmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLadmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLadmin.ForeColor = System.Drawing.Color.White
        Me.btnLadmin.Location = New System.Drawing.Point(79, 371)
        Me.btnLadmin.Name = "btnLadmin"
        Me.btnLadmin.Size = New System.Drawing.Size(220, 36)
        Me.btnLadmin.TabIndex = 6
        Me.btnLadmin.Text = "LOGIN AS ADMIN"
        Me.btnLadmin.UseVisualStyleBackColor = False
        '
        'btnLuser
        '
        Me.btnLuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLuser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnLuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLuser.ForeColor = System.Drawing.Color.White
        Me.btnLuser.Location = New System.Drawing.Point(79, 329)
        Me.btnLuser.Name = "btnLuser"
        Me.btnLuser.Size = New System.Drawing.Size(220, 36)
        Me.btnLuser.TabIndex = 5
        Me.btnLuser.Text = "LOGIN AS USER"
        Me.btnLuser.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(79, 248)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(220, 23)
        Me.txtPass.TabIndex = 4
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtStudnum
        '
        Me.txtStudnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudnum.Location = New System.Drawing.Point(79, 196)
        Me.txtStudnum.Name = "txtStudnum"
        Me.txtStudnum.Size = New System.Drawing.Size(220, 22)
        Me.txtStudnum.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 21)
        Me.Panel2.TabIndex = 2
        '
        'picExit
        '
        Me.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(12, 8)
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
        Me.lblMini.Location = New System.Drawing.Point(28, -2)
        Me.lblMini.Name = "lblMini"
        Me.lblMini.Size = New System.Drawing.Size(19, 20)
        Me.lblMini.TabIndex = 13
        Me.lblMini.Text = "_"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 464)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtStudnum As TextBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnLadmin As Button
    Friend WithEvents btnLuser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbShowpass As CheckBox
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblForgotPass As Label
End Class
