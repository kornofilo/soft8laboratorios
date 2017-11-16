Public Class Form2
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles mensaje.MouseLeave
        mensaje.Visible = False
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        mensaje.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        mensaje.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub mensaje_Click(sender As Object, e As EventArgs) Handles mensaje.Click

    End Sub
End Class