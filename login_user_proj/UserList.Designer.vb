<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserList))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Historic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "User Master List"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(11, 97)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(476, 392)
        Me.DataGridView3.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 21)
        Me.Panel2.TabIndex = 22
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
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteUser.FlatAppearance.BorderSize = 0
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteUser.Location = New System.Drawing.Point(11, 509)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(235, 39)
        Me.btnDeleteUser.TabIndex = 23
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRefresh.Location = New System.Drawing.Point(252, 509)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(235, 39)
        Me.btnRefresh.TabIndex = 24
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'UserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 560)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserList"
        Me.Text = "Form2"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnRefresh As Button
End Class
