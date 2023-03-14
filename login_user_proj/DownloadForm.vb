Imports MySql.Data.MySqlClient
Public Class DownloadForm
    'List of contributors: Plaza, Jan Danielle

    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Dim fpath As String
    Dim fname As String
    Dim ftype As String
    Dim ftypeName As String

    Sub AutoComplete()
        'sub for search title autocomplete
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim acsc As New AutoCompleteStringCollection

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `publish_table` ORDER BY TITLE ASC"
            End With
            da.SelectCommand = cmd
            da.Fill(ds, "TITLE")


            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                acsc.Add(ds.Tables(0).Rows(i)("TITLE").ToString)
            Next
            con.Close()
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearch.AutoCompleteCustomSource = acsc
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub LoadPublishTable()
        'sub for loading the publish table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            da.Dispose()

            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `publish_table` ORDER BY `TITLE` ASC"
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


    Private Sub DownloadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form load
        LoadPublishTable()
        AutoComplete()
    End Sub

    Private Sub DownloadForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub DownloadForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub DownloadForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
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

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Browse destination folder
        Dim DBrowse As New FolderBrowserDialog
        If DBrowse.ShowDialog() = DialogResult.OK Then
            txtPath.Text = DBrowse.SelectedPath
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        'download the selected file in the gridview
        If txtPath.Text = String.Empty Or txtFname.Text = String.Empty Then
            MsgBox("Please fill out the required field to continue!", vbOKOnly + vbCritical, "Warning")
        Else
            Timer1.Start()
        End If

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'assigning of docs type per file type
        ftype = DataGridView1.Item("FILE TYPE", DataGridView1.CurrentRow.Index).Value
        If ftype = "PDF" Then
            ftypeName = ".pdf"
        ElseIf ftype = "WORD" Then
            ftypeName = ".docx"
        ElseIf ftype = "EXCEL" Then
            ftypeName = ".xlsx"
        ElseIf ftype = "POWERPOINT" Then
            ftypeName = ".pptx"
        End If
        fpath = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME", DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Download process
        Try
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                fname = txtFname.Text
                My.Computer.Network.DownloadFile(fpath, txtPath.Text + "\" + fname + ftypeName)
                MsgBox("File Downloaded!")
                ProgressBar1.Value = 0
                txtPath.Clear()
                txtFname.Clear()
                cbCategory.SelectedIndex = -1
                cbFiletype.SelectedIndex = -1
                DateTimePicker1.Value = Date.Now
                LoadPublishTable()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'search alike title
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        If txtSearch.Text = String.Empty Then
            LoadPublishTable()
        Else
            Try
                con.Open()
                da.Dispose()

                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `publish_table` WHERE `TITLE` LIKE '%" & txtSearch.Text & "%'"
                End With
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
                da.Dispose()
            End Try
        End If
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        'filter by category
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Select Case cbCategory.SelectedIndex
            Case 0
                LoadPublishTable()
            Case 1
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='General Works' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 2
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Philosophy and Psychology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 3
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Religion' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 4
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Social Sciences' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 5
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Language' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 6
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Natural Sciences and Mathematics' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 7
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 8
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Arts' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 9
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Literature and Rhetoric' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 10
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='History, Biography, and Geography' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 11
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='NSTP (CWTS/ROTC)' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 12
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Civil Engineering and Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 13
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Computer Engineering Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 14
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Electrical Engineering Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 15
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Electronics Engineering Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 16
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Information Communication Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 17
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Mechanical Engineering Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 18
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Office Management Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 19
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `CATEGORY`='Railway Engineering Technology' ORDER BY `FILE TYPE` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
        End Select
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'filter by date uploaded
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        If DateTimePicker1.Value = Date.Now Then
            LoadPublishTable()
        Else
            Try
                con.Open()
                da.Dispose()

                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `publish_table` WHERE `DATE UPLOADED` LIKE '%" & DateTimePicker1.Value.Date & "%'"
                End With
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
                da.Dispose()
            End Try
        End If
    End Sub

    Private Sub cbFiletype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiletype.SelectedIndexChanged
        'filter by file type
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Select Case cbFiletype.SelectedIndex
            Case 0
                LoadPublishTable()
            Case 1 'PDF
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `FILE TYPE`='PDF' ORDER BY `CATEGORY` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 2 'WORD
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `FILE TYPE`='WORD' ORDER BY `CATEGORY` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 3 'POWERPOINT
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `FILE TYPE`='POWERPOINT' ORDER BY `CATEGORY` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
            Case 4 'EXCEL
                Try
                    con.Open()
                    da.Dispose()

                    With cmd
                        .Connection = con
                        .CommandText = "SELECT * FROM `publish_table` WHERE `FILE TYPE`='EXCEL' ORDER BY `CATEGORY` ASC"
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                    da.Dispose()
                End Try
        End Select
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        'clear all applied filter
        txtSearch.Clear()
        cbCategory.SelectedIndex = -1
        cbFiletype.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now
        LoadPublishTable()
    End Sub

End Class