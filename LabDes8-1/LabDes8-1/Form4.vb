Imports System.ComponentModel

Public Class Form4
    Private Sub cbOperaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOperaciones.SelectedIndexChanged
        If cbOperaciones.SelectedIndex = 0 Then
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            Simbolo.Text = "+"
        End If
        If cbOperaciones.SelectedIndex = 1 Then
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
            Simbolo.Text = "-"
        End If
        If cbOperaciones.SelectedIndex = 2 Then
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
            Simbolo.Text = "-"
        End If
        If cbOperaciones.SelectedIndex = 3 Then
            If Val(TextBox2.Text) <> 0 Then
                TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
                Simbolo.Text = "/"
            Else
                MsgBox("no se puede dividir por cero")
            End If
        End If
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Valor es nulo")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox1, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Valor es nulo")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox2, "")
            e.Cancel = False
        End If
    End Sub
End Class