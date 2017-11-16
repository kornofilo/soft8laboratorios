Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then   'calculo para el primer check box
            TextBoxTotal1.Text = TextBoxCan1.Text * 50.0 ' calcula la cantidad en dolares en el primer total
            TextBoxTotal4.Text = Val(TextBoxTotal4.Text) + Val(TextBoxCan1.Text) 'calcula la cantidad de dolares totales
            TextBoxCan4.Text = Val(TextBoxCan4.Text) + Val(TextBoxCan1.Text)    'calcula la suma de articulos
        End If
        If CheckBox2.Checked Then
            TextBoxTotal2.Text = TextBoxCan2.Text * 100.0
            TextBoxTotal4.Text = Val(TextBoxTotal4.Text) + Val(TextBoxCan2.Text)
            TextBoxCan4.Text = Val(TextBoxCan4.Text) + Val(TextBoxCan2.Text)
        End If
        If CheckBox3.Checked Then
            TextBoxTotal3.Text = TextBoxCan3.Text * 200.0
            TextBoxTotal4.Text = Val(TextBoxTotal4.Text) + Val(TextBoxCan3.Text)
            TextBoxCan4.Text = Val(TextBoxCan4.Text) + Val(TextBoxCan3.Text)
        End If
        TextBoxTotal4.Text = Val(TextBoxTotal1.Text) + Val(TextBoxTotal2.Text) + Val(TextBoxTotal3.Text) 'calcula la cantidad de dolares totales
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' If CheckBox1.Checked Then
        'TextBoxTotal1.Text = tx
        'End If
    End Sub

    Private Sub TextBoxCan1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCan1.TextChanged

    End Sub
End Class