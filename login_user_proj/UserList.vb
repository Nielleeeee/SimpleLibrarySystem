Imports MySql.Data.MySqlClient

Public Class UserList
    'List of contributors: Plaza, Jan Danielle

    'Make form movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable

    Sub UserTableLoad()
        'sub for user table load
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            con.Open()
            dt.Clear()
            da.Dispose()

            With cmd
                .Connection = con
                .CommandText = "SELECT `ID`, `AGE`, `GENDER`, `BDAY`, `COURSE`, `STUDENT NUMBER` FROM `signupuser_table`"
            End With
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub UserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'userlist form load
        UserTableLoad()
    End Sub

    Private Sub UserList_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub UserList_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub UserList_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
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

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        'Delete selected user from the grid view
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i

        Try
            con.Open()
            sql = "DELETE FROM `signupuser_table` WHERE ID='" & DataGridView3.CurrentRow.Cells(0).Value & "' "
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been DELETED successfully!")
                UserTableLoad()
            Else
                MsgBox("No record has been DELETED!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'refresh table
        UserTableLoad()
    End Sub
End Class