<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFiletype = New System.Windows.Forms.ComboBox()
        Me.txtUploadName = New System.Windows.Forms.TextBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFilepath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(94, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CATEGORY*"
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"General Works", "Philosophy and Psychology", "Religion", "Social Sciences", "Language", "Natural Sciences and Mathematics", "Technology", "Arts", "Literature and Rhetoric", "History, Biography, and Geography", "NSTP (CWTS/ROTC)", "Civil Engineering and Technology", "Computer Engineering Technology", "Electrical Engineering Technology", "Electronics Engineering Technology", "Information Communication Technology", "Mechanical Engineering Technology", "Office Management Technology", "Railway Engineering Technology"})
        Me.cbCategory.Location = New System.Drawing.Point(98, 225)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(396, 24)
        Me.cbCategory.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(94, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FILE TYPE*"
        '
        'cbFiletype
        '
        Me.cbFiletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiletype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiletype.FormattingEnabled = True
        Me.cbFiletype.Items.AddRange(New Object() {"WORD", "POWERPOINT", "EXCEL", "PDF"})
        Me.cbFiletype.Location = New System.Drawing.Point(98, 283)
        Me.cbFiletype.Name = "cbFiletype"
        Me.cbFiletype.Size = New System.Drawing.Size(396, 24)
        Me.cbFiletype.TabIndex = 6
        '
        'txtUploadName
        '
        Me.txtUploadName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUploadName.Location = New System.Drawing.Point(98, 164)
        Me.txtUploadName.Name = "txtUploadName"
        Me.txtUploadName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUploadName.Size = New System.Drawing.Size(396, 26)
        Me.txtUploadName.TabIndex = 14
        '
        'lblMini
        '
        Me.lblMini.AutoSize = True
        Me.lblMini.BackColor = System.Drawing.Color.Transparent
        Me.lblMini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMini.ForeColor = System.Drawing.Color.Black
        Me.lblMini.Location = New System.Drawing.Point(28, -2)
        Me.lblMini.Name = "lblMini"
        Me.lblMini.Size = New System.Drawing.Size(19, 20)
        Me.lblMini.TabIndex = 13
        Me.lblMini.Text = "_"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 30)
        Me.Panel2.TabIndex = 15
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(98, 384)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(180, 30)
        Me.btnUpload.TabIndex = 17
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(314, 384)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(180, 30)
        Me.btnBrowse.TabIndex = 16
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 30)
        Me.Panel1.TabIndex = 16
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(496, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 17)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(94, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "NAME (Uploader)*"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(98, 431)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(396, 23)
        Me.ProgressBar1.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(98, 469)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(396, 22)
        Me.dtpDate.TabIndex = 21
        Me.dtpDate.Visible = False
        '
        'txtFilepath
        '
        Me.txtFilepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilepath.Location = New System.Drawing.Point(98, 340)
        Me.txtFilepath.Name = "txtFilepath"
        Me.txtFilepath.ReadOnly = True
        Me.txtFilepath.Size = New System.Drawing.Size(396, 26)
        Me.txtFilepath.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(94, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "FILE PATH*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(94, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TITLE (Academic Material)*"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(98, 104)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTitle.Size = New System.Drawing.Size(396, 26)
        Me.txtTitle.TabIndex = 24
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
        'UploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImage = Global.login_user_proj.My.Resources.Resources.upload_bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFilepath)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtUploadName)
        Me.Controls.Add(Me.cbFiletype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UploadForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFiletype As ComboBox
    Friend WithEvents txtUploadName As TextBox
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtFilepath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
End Class
