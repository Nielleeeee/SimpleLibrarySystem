Imports MySql.Data.MySqlClient
Public Class UploadForm
    'List of contributors:
    'Plaza, Jan Danielle
    'Ibardaloza, Daniel Dave
    'Letegio, Rene

    'Make form movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Dim con As MySqlConnection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Dim i

    Private Sub UploadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show the current date
        lblDate.Text = Format(Date.Now, "MM/dd/yyyy")
    End Sub

    Private Sub UploadForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub UploadForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub UploadForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()

    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Browse a file to be uploaded
        If cbFiletype.SelectedIndex = -1 Then
            MsgBox("Please Select File Type!")
        Else
            Select Case cbFiletype.SelectedIndex
                Case 0 'WORD
                    Try
                        OpenFileDialog1.Filter = "Microsoft Word Document|*.docx"
                        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                            txtFilepath.Text = OpenFileDialog1.FileName
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Case 1
                    Try
                        OpenFileDialog1.Filter = "Microsoft PowerPoint Presentation|*.pptx"
                        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                            txtFilepath.Text = OpenFileDialog1.FileName
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Case 2
                    Try
                        OpenFileDialog1.Filter = "Microsoft Excel Worksheet|*.xlsx"
                        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                            txtFilepath.Text = OpenFileDialog1.FileName
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Case 3
                    Try
                        OpenFileDialog1.Filter = "PDF|*.pdf"
                        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                            txtFilepath.Text = OpenFileDialog1.FileName
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

            End Select
        End If

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Upload the document selected
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        If (txtTitle.Text = String.Empty) Or (txtUploadName.Text = String.Empty) Or (cbCategory.SelectedIndex = -1) Or (cbFiletype.SelectedIndex = -1) Or (txtFilepath.Text = String.Empty) Then
            MsgBox("Please fill out the required field to continue!", vbOKOnly + vbCritical, "Warning")
        Else
            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT `TITLE`, `FILENAME` FROM `publish_table` WHERE `TITLE` = @Title AND `FILENAME` = @Filename"
                    .Parameters.Add("@Title", MySqlDbType.VarChar).Value = txtTitle.Text
                    .Parameters.Add("@Filename", MySqlDbType.VarChar).Value = txtFilepath.Text
                End With
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                If dt.Rows.Count() = 0 Then
                    Timer1.Start()
                Else
                    MsgBox("Title or Filename Already Taken!", vbOKOnly + vbCritical, "Warning")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Uploading document process 
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Try
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                con.Open()
                sql = "INSERT INTO upload_table(`TITLE`, `UPLOADER NAME`, `FILE TYPE`, `CATEGORY`, `DATE UPLOADED`, `FILENAME`) 
                       VALUES('" & txtTitle.Text.ToUpper & "', '" & txtUploadName.Text.ToUpper & "', '" & cbFiletype.SelectedItem & "','" & cbCategory.SelectedItem & "', '" & dtpDate.Value.Date & "', '" & System.IO.Path.GetFileName(txtFilepath.Text) & "')"

                With cmd
                    .Connection = con
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With
                If txtFilepath.Text <> "" Then
                    System.IO.File.Copy(txtFilepath.Text, Application.StartupPath & "\Upload_File\" & System.IO.Path.GetFileName(txtFilepath.Text))
                End If
                MsgBox("File Uploaded!")
                txtTitle.Clear()
                txtUploadName.Clear()
                cbCategory.SelectedIndex = -1
                cbFiletype.SelectedIndex = -1
                txtFilepath.Clear()
                ProgressBar1.Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

End Class
