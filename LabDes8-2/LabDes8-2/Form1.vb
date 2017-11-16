Public Class Form1
    'formula para calcular la raiz cuadrada: Math.Sqrt()
    Dim a, b, c, x1, x2 As Double 'declaracion de las variables

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        TextBoxA.Clear()
        TextBoxB.Clear()
        TextBoxC.Clear()
        TextBoxX1.Clear()
        TextBoxX2.Clear()
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        a = Val(TextBoxA.Text)
        b = Val(TextBoxB.Text)
        c = Val(TextBoxC.Text)


        If (b ^ 2) - (4 * a * c) < 0 Then
            MsgBox("no existe respuesta, las raices son imaginarias")
        ElseIf (b ^ 2) - (4 * a * c) = 0 Then
            x1 = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            MsgBox("Las Raices son " & Str$(x1) * " (equal).")
        Else : x1 = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            x2 = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
            MsgBox("Las Raices son " & Str$(x1) & " y  " & (x2))
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
