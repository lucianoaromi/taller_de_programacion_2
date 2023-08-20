Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Boton de guardar texto y mostrarlo en el tercer textBox'
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        TextBox3.Text = TextBox1.Text + " " + TextBox2.Text
    End Sub

    'Boton de eliminar texto'
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    'Boton de Salir'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    'Combinacion de teclas para salir: Ctrl + Shift + S'
    Private Sub Form1_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.S Then
            If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
