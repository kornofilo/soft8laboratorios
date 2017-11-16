Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Salida.Text = TextBox1.Text
        Salida.ForeColor = Color.DarkBlue
        Salida2.Text = TextBox1.Text
        Salida2.BackColor = Color.Azure
        Salida2.ForeColor = Color.Coral

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Salida2.ForeColor = Color.Cyan
            Salida2.Text = "Abuso de Mayusculas es malo para la salud"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Salida2.ForeColor = Color.Crimson
            Salida2.Text = "Akai desu"
        End If
    End Sub
End Class