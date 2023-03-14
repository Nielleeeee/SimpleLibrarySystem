Imports MySql.Data.MySqlClient

Public Class Admin
    'List of Contributors:
    'Plaza, Jan Danielle
    'Astoveza, Aprilyn
    'Bautista, Eco
    'Miramonte, John Daniel


    'Make Form Movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point
    Dim i

    Sub AutoCompletePublish()
        'Sub for search title auto complete (Publish Table)
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
            txtSearchPublish.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchPublish.AutoCompleteCustomSource = acsc
            txtSearchPublish.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub

    Sub AutoCompleteUpload()
        'Sub for search title auto complete (Upload Table) 
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
                .CommandText = "SELECT * FROM `upload_table` ORDER BY TITLE ASC"
            End With
            da.SelectCommand = cmd
            da.Fill(ds, "TITLE")


            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                acsc.Add(ds.Tables(0).Rows(i)("TITLE").ToString)
            Next

            txtSearchUpload.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchUpload.AutoCompleteCustomSource = acsc
            txtSearchUpload.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            da.Dispose()
            con.Close()
        End Try

    End Sub

    Sub LoadPendingTable()
        'Sub for loading the pending table
        Try
            openCon()
            da.Dispose()

            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `upload_table`"
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Sub LoadPublishTable()
        'Sub for loading the publish table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            da.Dispose()

            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `publish_table`"
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

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Admin form load
        lblDate.Text = Format(Date.Now, "MM/dd/yyyy")
        LoadPendingTable()
        LoadPublishTable()
        AutoCompletePublish()
        AutoCompleteUpload()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Logout from admin form
        Dim login As New Form1
        Dim response As VariantType
        response = MsgBox("Are you sure you'd like to logout?", vbYesNo + vbQuestion, "Exit")
        If response = vbYes Then
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
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

    Private Sub btnRefreshPending_Click(sender As Object, e As EventArgs) Handles btnRefreshPending.Click
        'Refresh Table
        LoadPendingTable()
    End Sub

    Private Sub btnRefreshPublish_Click(sender As Object, e As EventArgs) Handles btnRefreshPublish.Click
        'Refresh Table
        LoadPublishTable()
    End Sub

    Private Sub btnPreviewPending_Click(sender As Object, e As EventArgs) Handles btnPreviewPending.Click
        'Preview the Selected Document in the DataGridView
        Select Case DataGridView2.Item("FILE TYPE", DataGridView2.CurrentRow.Index).Value
            Case "PDF"
                Try
                    With PDF_Reader
                        .Show()
                        .Focus()
                        .AxAcroPDF1.src = Application.StartupPath & "\Upload_File\" & DataGridView2.Item("FILENAME",
                                                                               DataGridView2.CurrentRow.Index).Value
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPendingTable()

            Case "WORD"
                Dim word As Microsoft.Office.Interop.Word.Application
                Dim doc As Microsoft.Office.Interop.Word.Document

                Try
                    word = CreateObject("Word.Application")
                    word.Visible = True
                    doc = word.Documents.Add(Application.StartupPath & "\Upload_File\" & DataGridView2.Item("FILENAME",
                                                                                         DataGridView2.CurrentRow.Index).Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPendingTable()

            Case "EXCEL"
                Dim exlapp As Microsoft.Office.Interop.Excel.Application
                Dim file As String

                Try
                    file = Application.StartupPath & "\Upload_File\" & DataGridView2.Item("FILENAME",
                                                                       DataGridView2.CurrentRow.Index).Value
                    exlapp = CreateObject("Excel.Application")
                    exlapp.Visible = True
                    exlapp.Workbooks.Open(file)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPendingTable()

            Case "POWERPOINT"
                Dim pptpres As Microsoft.Office.Interop.PowerPoint.Presentation
                Dim pptapp As Microsoft.Office.Interop.PowerPoint.Application
                Dim file As String

                Try
                    file = Application.StartupPath & "\Upload_File\" & DataGridView2.Item("FILENAME",
                                                                       DataGridView2.CurrentRow.Index).Value
                    pptapp = CreateObject("Powerpoint.Application")
                    pptapp.Visible = True
                    pptpres = pptapp.Presentations.Open(file)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPendingTable()

        End Select

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Upload form will show
        Dim upload As New UploadForm
        upload.Show()

    End Sub

    Private Sub btnUserlist_Click(sender As Object, e As EventArgs) Handles btnUserlist.Click
        'Userlist form will show
        Dim userlist As New UserList
        userlist.Show()
        userlist.Focus()
    End Sub

    Private Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        'Transfer selected document to the publish table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Try
            con.Open()
            sql = "INSERT INTO `publish_table` SELECT * FROM `upload_table` WHERE TITLE='" & DataGridView2.CurrentRow.Cells(0).Value & "' "
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been PUBLISHED successfully!")
                sql = "DELETE FROM `upload_table` WHERE TITLE='" & DataGridView2.CurrentRow.Cells(0).Value & "' "
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                cmd.ExecuteNonQuery()
                LoadPublishTable()
                LoadPendingTable()
            Else
                MsgBox("No record has been PUBLISHED!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub txtSearchPublish_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPublish.TextChanged
        'Search like title
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        If txtSearchPublish.Text = String.Empty Then
            LoadPublishTable()
        Else
            Try
                con.Open()
                da.Dispose()

                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `publish_table` WHERE `TITLE` LIKE '%" & txtSearchPublish.Text & "%'"
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

    Private Sub btnDeletePending_Click(sender As Object, e As EventArgs) Handles btnDeletePending.Click
        'Delete the selected document in the pending table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Try
            con.Open()
            sql = "DELETE FROM `upload_table` WHERE TITLE='" & DataGridView2.CurrentRow.Cells(0).Value & "' "
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been DELETED successfully!")
                LoadPendingTable()
            Else
                MsgBox("No record has been DELETED!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDeletePublish_Click(sender As Object, e As EventArgs) Handles btnDeletePublish.Click
        'Delete selected document in the publish table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Try
            con.Open()
            sql = "DELETE FROM `publish_table` WHERE TITLE='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been DELETED successfully!")
                LoadPublishTable()
            Else
                MsgBox("No record has been DELETED!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        'Hold selected document to the pending table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Try
            con.Open()
            sql = "INSERT INTO `upload_table` SELECT * FROM `publish_table` WHERE TITLE='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been HOLD successfully!")
                sql = "DELETE FROM `publish_table` WHERE TITLE='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                cmd.ExecuteNonQuery()
                LoadPublishTable()
                LoadPendingTable()
            Else
                MsgBox("No record has been HOLD!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        'About us form will show
        Dim aboutus As New AboutUsForm
        aboutus.Show()
    End Sub

    Private Sub txtSearchUpload_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUpload.TextChanged
        'Search like title in pending table
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        If txtSearchUpload.Text = String.Empty Then
            LoadPendingTable()
        Else
            Try
                con.Open()
                da.Dispose()

                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `upload_table` WHERE `TITLE` LIKE '%" & txtSearchUpload.Text & "%'"
                End With
                da.SelectCommand = cmd
                dt.Clear()
                da.Fill(dt)
                DataGridView2.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
                da.Dispose()
            End Try
        End If
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        'Filter by Category
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Select Case cbTable.SelectedIndex
            Case 0
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
            Case 1
                Select Case cbCategory.SelectedIndex
                    Case 0
                        LoadPendingTable()
                    Case 1
                        Try
                            con.Open()
                            da.Dispose()

                            With cmd
                                .Connection = con
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='General Works' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Philosophy and Psychology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Religion' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Social Sciences' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Language' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Natural Sciences and Mathematics' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Arts' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Literature and Rhetoric' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='History, Biography, and Geography' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='NSTP (CWTS/ROTC)' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Civil Engineering and Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Computer Engineering Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Electrical Engineering Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Electronics Engineering Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Information Communication Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Mechanical Engineering Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Office Management Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `CATEGORY`='Railway Engineering Technology' ORDER BY `FILE TYPE` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        Finally
                            con.Close()
                            da.Dispose()
                        End Try
                End Select
        End Select


    End Sub

    Private Sub cbFiletype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiletype.SelectedIndexChanged
        'Filter by filetype
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Select Case cbTable.SelectedIndex
            Case 0
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
            Case 1
                Select Case cbFiletype.SelectedIndex
                    Case 0
                        LoadPendingTable()
                    Case 1 'PDF
                        Try
                            con.Open()
                            da.Dispose()

                            With cmd
                                .Connection = con
                                .CommandText = "SELECT * FROM `upload_table` WHERE `FILE TYPE`='PDF' ORDER BY `CATEGORY` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `FILE TYPE`='WORD' ORDER BY `CATEGORY` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `FILE TYPE`='POWERPOINT' ORDER BY `CATEGORY` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
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
                                .CommandText = "SELECT * FROM `upload_table` WHERE `FILE TYPE`='EXCEL' ORDER BY `CATEGORY` ASC"
                            End With
                            da.SelectCommand = cmd
                            dt.Clear()
                            da.Fill(dt)
                            DataGridView2.DataSource = dt
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        Finally
                            con.Close()
                            da.Dispose()
                        End Try
                End Select
        End Select
    End Sub

    Private Sub btnPreviewPublish_Click(sender As Object, e As EventArgs) Handles btnPreviewPublish.Click
        'Preview selected document in the publish table
        Select Case DataGridView1.Item("FILE TYPE", DataGridView1.CurrentRow.Index).Value
            Case "PDF"
                Try
                    With PDF_Reader
                        .Show()
                        .Focus()
                        .AxAcroPDF1.src = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME",
                                                                               DataGridView1.CurrentRow.Index).Value
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
                    doc = word.Documents.Add(Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME",
                                                                                         DataGridView1.CurrentRow.Index).Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()

            Case "EXCEL"
                Dim exlapp As Microsoft.Office.Interop.Excel.Application

                Dim file As String

                Try
                    file = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME",
                                                                       DataGridView1.CurrentRow.Index).Value
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
                    file = Application.StartupPath & "\Upload_File\" & DataGridView1.Item("FILENAME",
                                                                       DataGridView1.CurrentRow.Index).Value
                    pptapp = CreateObject("Powerpoint.Application")
                    pptapp.Visible = True
                    pptpres = pptapp.Presentations.Open(file)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoadPublishTable()
        End Select
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Filter by date uploaded
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

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        'Download form will show
        Dim download As New DownloadForm
        download.Show()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        'Remove all the applied filter
        cbCategory.SelectedIndex = -1
        cbFiletype.SelectedIndex = -1
        DateTimePicker1.Value = Date.Now
        txtSearchPublish.Clear()
        txtSearchUpload.Clear()
        cbTable.SelectedIndex = -1
        LoadPublishTable()
        LoadPendingTable()
    End Sub

End Class
