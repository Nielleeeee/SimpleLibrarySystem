Imports MySql.Data.MySqlClient

Public Class UserPageForm
    'List of Contributors:
    'Plaza, Jan Danielle
    'Clemente, Mark Jay
    'Roa, Gabriel James

    Public Shared userpage

    'Make Form Movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Sub AutoComplete()
        'Sub for Search Title Auto Complete
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
        'Sub for Loading of Publish Table
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


    Private Sub btnLogout_click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Logout Button (Click)
        Dim login As New Form1
        Dim response As VariantType
        response = MsgBox("Are you sure you'd like to logout?", vbYesNo + vbQuestion, "Exit")
        If response = vbYes Then
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub UserPageForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'User Form Load 
        lblDate.Text = Format(Date.Now, "MM/dd/yyyy")
        lblName.Text = userpage

        LoadPublishTable()
        AutoComplete()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        'Make Form Movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        'Make Form Movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Upload Button Click
        Dim upload As New UploadForm
        upload.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        'Will Show About Us Form
        Dim aboutus As New AboutUsForm
        aboutus.Show()
    End Sub


    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        'Preview the Selected Document in the DataGridView
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Select Case DataGridView1.Item("FILE TYPE", DataGridView1.CurrentRow.Index).Value
            Case "PDF"
                Try
                    With PDF_Reader
                        .Show()
                        .Focus()
                        .AxAcroPDF1.src = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME", DataGridView1.CurrentRow.Index).Value
                    End With

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()

            Case "WORD"
                Dim word As Microsoft.Office.Interop.Word.Application
                Dim doc As Microsoft.Office.Interop.Word.Document

                Try
                    word = CreateObject("Word.Application")
                    word.Visible = True
                    doc = word.Documents.Add(Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME", DataGridView1.CurrentRow.Index).Value)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()

            Case "EXCEL"
                Dim exlapp As Microsoft.Office.Interop.Excel.Application
                Dim file As String

                Try
                    file = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME", DataGridView1.CurrentRow.Index).Value
                    exlapp = CreateObject("Excel.Application")
                    exlapp.Visible = True
                    exlapp.Workbooks.Open(file)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()

            Case "POWERPOINT"
                Dim pptpres As Microsoft.Office.Interop.PowerPoint.Presentation
                Dim pptapp As Microsoft.Office.Interop.PowerPoint.Application
                Dim file As String

                Try
                    file = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME", DataGridView1.CurrentRow.Index).Value
                    pptapp = CreateObject("Powerpoint.Application")
                    pptapp.Visible = True
                    pptpres = pptapp.Presentations.Open(file)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()

        End Select
    End Sub

    Private Sub cbFiletype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiletype.SelectedIndexChanged
        'Filter by File Type
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
        'Clear All Used Filter
        cbCategory.SelectedIndex = -1
        cbFiletype.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now
        txtSearch.Clear()
        LoadPublishTable()
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        'Filter by Category
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Search Like Title
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

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        'Download Form Will Show
        Dim download As New DownloadForm
        download.Show()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Filter by Date Uploaded
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
End Class
