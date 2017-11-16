Public Class Form1
    Dim fail As Integer

    'pseudo laboratorio 1
    '
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles salir.Click
        'cerrar el programa la ventana y el programa
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles initialize.Click
        'limpia los datos que existan en los boxes password y username
        Password.Text = ""
        Username.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        'if anidado que verifica si el nombre de usuario es entrada o ENTRADA y si la clave es 12345
        'envia el mensaje de que la clave es correcta, si ninguna de las condiciones se cumple 
        'entonces envia el mensaje de usuario no es correcto o contrasena no es correcta

        If Username.Text = "entrada" Or Username.Text = "ENTRADA" Then
            If Password.Text = "12345" Then
                MsgBox("Usuario y Clave son Correctos")
                Form2.Show()
            Else
                MsgBox("Su clave es incorrecta")

            End If

        Else
            MsgBox("su nombre de usuario no es el que quiero.")
        End If

    End Sub
End Class
