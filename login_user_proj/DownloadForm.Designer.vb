<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.lblMini = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFiletype = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.lblDropdown = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picExit)
        Me.Panel2.Controls.Add(Me.lblMini)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 21)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(736, 320)
        Me.DataGridView1.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.Location = New System.Drawing.Point(30, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 29)
        Me.txtSearch.TabIndex = 13
        Me.txtSearch.Text = "Search Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(407, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "File Type:"
        '
        'cbFiletype
        '
        Me.cbFiletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiletype.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiletype.FormattingEnabled = True
        Me.cbFiletype.Items.AddRange(New Object() {"", "PDF", "WORD", "POWERPOINT", "EXCEL"})
        Me.cbFiletype.Location = New System.Drawing.Point(410, 44)
        Me.cbFiletype.Name = "cbFiletype"
        Me.cbFiletype.Size = New System.Drawing.Size(184, 27)
        Me.cbFiletype.TabIndex = 16
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"", "General Works", "Philosophy and Psychology", "Religion", "Social Sciences", "Language", "Natural Sciences and Mathematics", "Technology", "Arts", "Literature and Rhetoric", "History, Biography, and Geography", "NSTP (CWTS/ROTC)", "Civil Engineering and Technology", "Computer Engineering Technology", "Electrical Engineering Technology", "Electronics Engineering Technology", "Information Communication Technology", "Mechanical Engineering Technology", "Office Management Technology", "Railway Engineering Technology"})
        Me.cbCategory.Location = New System.Drawing.Point(220, 44)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(184, 27)
        Me.cbCategory.TabIndex = 14
        '
        'lblDropdown
        '
        Me.lblDropdown.AutoSize = True
        Me.lblDropdown.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropdown.ForeColor = System.Drawing.Color.White
        Me.lblDropdown.Location = New System.Drawing.Point(217, 23)
        Me.lblDropdown.Name = "lblDropdown"
        Me.lblDropdown.Size = New System.Drawing.Size(69, 18)
        Me.lblDropdown.TabIndex = 15
        Me.lblDropdown.Text = "Category: "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(600, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 26)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(597, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Date: "
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "File Name: "
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(30, 458)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(564, 25)
        Me.txtFname.TabIndex = 27
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 545)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(564, 23)
        Me.ProgressBar1.TabIndex = 26
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(27, 486)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(110, 17)
        Me.lblWelcome.TabIndex = 25
        Me.lblWelcome.Text = "Browse Location: "
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(600, 501)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(166, 30)
        Me.btnBrowse.TabIndex = 24
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(600, 538)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(166, 30)
        Me.btnDownload.TabIndex = 23
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(30, 506)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(564, 25)
        Me.txtPath.TabIndex = 22
        '
        'btnClearFilter
        '
        Me.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilter.ForeColor = System.Drawing.Color.White
        Me.btnClearFilter.Location = New System.Drawing.Point(600, 79)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(166, 30)
        Me.btnClearFilter.TabIndex = 29
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.UseVisualStyleBackColor = False
        '
        'DownloadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 590)
        Me.Controls.Add(Me.btnClearFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFiletype)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.lblDropdown)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DownloadForm"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents lblMini As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFiletype As ComboBox
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents lblDropdown As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnClearFilter As Button
End Class
