Public Class AboutUsForm
    'List of contributor: Plaza, Jan Danielle

    'Make form movable
    Dim isMouseDown As Boolean = False
    Dim mouseOffset As Point

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub lblMini_Click(sender As Object, e As EventArgs) Handles lblMini.Click
        'Make form movable
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AboutUsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Make form movable
        If isMouseDown = True Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub AboutUsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'Make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub AboutUsForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
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

End Class