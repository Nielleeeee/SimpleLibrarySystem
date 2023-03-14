<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtIDNum = New System.Windows.Forms.TextBox()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.cbShowpass = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 21)
        Me.Panel2.TabIndex = 3
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(87, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NEW PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(89, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "STUDENT / ADMIN NUMBER:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(90, 101)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(220, 23)
        Me.txtNewPass.TabIndex = 12
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'txtIDNum
        '
        Me.txtIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNum.Location = New System.Drawing.Point(90, 52)
        Me.txtIDNum.Name = "txtIDNum"
        Me.txtIDNum.Size = New System.Drawing.Size(220, 22)
        Me.txtIDNum.TabIndex = 11
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Location = New System.Drawing.Point(90, 209)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(220, 30)
        Me.btnChangePass.TabIndex = 15
        Me.btnChangePass.Text = "CHANGE PASSWORD"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(87, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "RE-TYPE NEW PASSWORD:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(90, 151)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(220, 23)
        Me.txtConfirmPass.TabIndex = 16
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'cbShowpass
        '
        Me.cbShowpass.AutoSize = True
        Me.cbShowpass.ForeColor = System.Drawing.Color.White
        Me.cbShowpass.Location = New System.Drawing.Point(209, 180)
        Me.cbShowpass.Name = "cbShowpass"
        Me.cbShowpass.Size = New System.Drawing.Size(101, 17)
        Me.cbShowpass.TabIndex = 22
        Me.cbShowpass.Text = "Show password"
        Me.cbShowpass.UseVisualStyleBackColor = True
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 260)
        Me.Controls.Add(Me.cbShowpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtIDNum)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPasswordForm"
        Me.Text = "Forgot Password"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtIDNum As TextBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents cbShowpass As CheckBox
End Class
