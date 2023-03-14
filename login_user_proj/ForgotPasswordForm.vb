Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm
    'List of Contributors:
    'Plaza, Jan Danielle

    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        'Change Password Button (Click)
        Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=71319_Nielle;database=oop_testproj")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            If (txtNewPass.Text = String.Empty) Or (txtConfirmPass.Text = String.Empty) Or (txtIDNum.Text = String.Empty) Then
                MsgBox("Please fill out the required field to continue!", vbOKOnly + vbCritical, "Warning")
            Else
                If txtNewPass.Text <> txtConfirmPass.Text Then
                    MsgBox("Password Does Not Match!", vbOKOnly + vbCritical, "Warning")
                Else
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT `STUDENT NUMBER` FROM `signupuser_table` WHERE `STUDENT NUMBER` = @Studnum"
                        .Parameters.Add("@Studnum", MySqlDbType.VarChar).Value = txtIDNum.Text
                    End With
                    da.SelectCommand = cmd
                    dt.Clear()
                    da.Fill(dt)

                    If dt.Rows.Count() = 0 Then
                        MsgBox("Invalid Student Number!", vbOKOnly + vbCritical, "Warning")
                    Else
                        Try
                            With cmd
                                .Connection = con
                                .CommandText = "UPDATE `signupuser_table` SET `PASSWORD` = '" & txtNewPass.Text & "' WHERE `STUDENT NUMBER` = '" & txtIDNum.Text & "'"
                            End With
                            cmd.ExecuteNonQuery()
                            MsgBox("Password Change Successful")
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ForgotPasswordForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make Form Movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub ForgotPasswordForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub ForgotPasswordForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        'Make Form Movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        'Make Form Movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub cbShowpass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowpass.CheckedChanged
        'Show Password Tickbox 
        If txtNewPass.UseSystemPasswordChar = True Then
            txtNewPass.UseSystemPasswordChar = False
        Else
            txtNewPass.UseSystemPasswordChar = True
        End If

        If txtConfirmPass.UseSystemPasswordChar = True Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class