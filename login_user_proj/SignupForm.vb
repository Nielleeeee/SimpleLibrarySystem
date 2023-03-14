Imports MySql.Data.MySqlClient

Public Class SignupForm
    'List of Contributors:
    'Plaza, Jan Danielle 
    'Calzada, Christian Kenneth

    'Make Form Moveable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Dim gender As String

    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        'Signup Button (Click)
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            If ((txtStudnum.Text = String.Empty) Or (txtUname.Text = String.Empty) Or (txtPass.Text = String.Empty) Or (txtAge.Text = String.Empty
                ) Or (cbCourse.SelectedIndex = -1) Or Not (rdFemale.Checked Or rdMale.Checked)) Then
                MsgBox("Please fill out the required field to continue!", vbOKOnly + vbCritical, "Warning")
            Else
                If txtPass.Text <> txtConfirmPass.Text Then
                    MsgBox("Password Does Not Match!", vbOKOnly + vbCritical, "Warning")
                Else
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT `STUDENT NUMBER` FROM `signupuser_table` WHERE `STUDENT NUMBER` = @Studnum"
                        .Parameters.Add("@Studnum", MySqlDbType.VarChar).Value = txtStudnum.Text
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)

                    If dt.Rows.Count() = 1 Then
                        MsgBox("Invalid Student Number!", vbOKOnly + vbCritical, "Warning")
                    Else
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO signupuser_table (`USERNAME`, `PASSWORD`, `AGE`, `GENDER`, `BDAY`, `COURSE`, `STUDENT NUMBER`) 
                               VALUES ('" & txtUname.Text & "', '" & txtPass.Text & "', " & txtAge.Text & ", '" & gender & "',
                               '" & dtpBday.Value.Date & "', '" & cbCourse.SelectedItem & "', '" & txtStudnum.Text & "')"
                        cmd.ExecuteNonQuery()

                        txtUname.Clear()
                        txtPass.Clear()
                        txtAge.Clear()
                        rdMale.Checked = False
                        rdFemale.Checked = False
                        cbCourse.SelectedIndex = -1
                        dtpBday.Value = Date.Now
                        txtStudnum.Clear()

                        MsgBox("Sign Up Successful", vbOKOnly, "Sign Up")

                        Dim login As New Form1
                        login.Show()
                        Me.Hide()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Login Button (Click)
        Dim login As New Form1
        login.Show()
        Me.Hide()

    End Sub

    Private Sub SignupForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make Form Moveable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub SignupForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make Form Moveable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub SignupForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        'Make Form Moveable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        'Make Form Moveable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        'Make Form Moveable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        'Make Form Moveable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub cbShowpass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowpass.CheckedChanged
        'Show Password Tickbox 
        If txtPass.UseSystemPasswordChar = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If

        If txtConfirmPass.UseSystemPasswordChar = True Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
