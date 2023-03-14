Imports MySql.Data.MySqlClient
Public Class Form1
    'List of Contributors:
    'Plaza, Jan Danielle
    'Cembrano, Stephanie Rei Allana
    'Gacad, Christopher

    'MySQL Connection
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")

    'Make form movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
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

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbShowpass.CheckedChanged
        'Show Password Tick Box
        If txtPass.UseSystemPasswordChar = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Application.Exit()
    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        'Signup Button
        txtName.Clear()
        txtPass.Clear()
        txtStudnum.Clear()

        Dim signup As New SignupForm()
        signup.Show()
        Me.Hide()
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

    Private Sub btnLuser_Click(sender As Object, e As EventArgs) Handles btnLuser.Click
        'Login User Button (Click)
        Try
            Dim command As New MySqlCommand("SELECT `USERNAME`, `STUDENT NUMBER`, `PASSWORD` FROM `signupuser_table` WHERE `USERNAME` = @Username AND `STUDENT NUMBER` = @Studnum AND `PASSWORD` = @Password", connection)

            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = txtName.Text
            command.Parameters.Add("@Studnum", MySqlDbType.VarChar).Value = txtStudnum.Text
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtPass.Text


            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() = 0 Then

                MsgBox("Invalid Username Or Password")

            Else

                MsgBox("Logged In Succesfully as User!")
                txtStudnum.Clear()
                txtPass.Clear()

                Dim UserPage As New UserPageForm
                UserPageForm.userpage = txtName.Text.ToUpper
                UserPageForm.Show()
                Me.Hide()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnLadmin_Click(sender As Object, e As EventArgs) Handles btnLadmin.Click
        'Login Admin Button (Click)
        Try
            Dim command As New MySqlCommand("SELECT `ADMIN NUMBER`, `ADMIN PASSWORD` FROM `admin_table` WHERE `ADMIN NUMBER` = @adminNum AND `ADMIN PASSWORD` = @adminPass", connection)

            command.Parameters.Add("@adminNum", MySqlDbType.VarChar).Value = txtStudnum.Text
            command.Parameters.Add("@adminPass", MySqlDbType.VarChar).Value = txtPass.Text

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() = 0 Then

                MessageBox.Show("Invalid Username Or Password")

            Else

                MessageBox.Show("Logged In Succesfully as Admin!")
                txtStudnum.Clear()
                txtPass.Clear()

                Dim AdminPage As New Admin
                Admin.Show()
                Me.Hide()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        'Forgot Password Button (Click)
        Dim forgotpass As New ForgotPasswordForm
        forgotpass.Show()
    End Sub
End Class
