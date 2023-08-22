Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' Verificar si todos los campos están completos
        If String.IsNullOrEmpty(TDni.Text) OrElse String.IsNullOrEmpty(TApellido.Text) OrElse String.IsNullOrEmpty(TNombre.Text) Then
            MessageBox.Show("Debe completar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim ask As MsgBoxResult ' Declarar la variable "ask" de tipo MsgBoxResult

            ' Mostrar el mensaje de consulta con el focus en "SI"
            ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            ' Verificar la respuesta del usuario
            If ask = MsgBoxResult.Yes Then
                MessageBox.Show("El cliente: " + TNombre.Text + " " + TApellido.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        ' Verificar si al menos un campo está vacío
        If String.IsNullOrEmpty(TDni.Text) OrElse String.IsNullOrEmpty(TApellido.Text) OrElse String.IsNullOrEmpty(TNombre.Text) Then
            MessageBox.Show("Debe completar todos los campos antes de eliminar", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim clienteNombre As String = TApellido.Text + " " + TNombre.Text ' Obtener el nombre del cliente
            Dim ask As MsgBoxResult ' Declarar la variable "ask" de tipo MsgBoxResult

            ' Mostrar el mensaje de advertencia con el focus en "NO"
            ask = MessageBox.Show("Está a punto de eliminar el Cliente: " & clienteNombre & vbCrLf & "¿Confirmar Eliminación?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

            ' Verificar la respuesta del usuario
            If ask = MsgBoxResult.Yes Then
                ' Limpiar los campos de texto
                TDni.Clear()
                TApellido.Clear()
                TNombre.Clear()

                ' Mostrar el nombre del cliente eliminado en un Label
                LModificar.Text = "" & clienteNombre

                MessageBox.Show("Cliente eliminado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Label (modifical)'
    Private Sub LModificar_Click(sender As Object, e As EventArgs) Handles LModificar.Click

    End Sub

    'Texbox DNI - Toma lectura del teclado y solo acepta valores numericos'
    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        ' Verificar si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Evitar que se ingrese el carácter no válido
        End If
    End Sub

    'Texbox Apellido - Toma lectura del teclado y solo acepta valores alfabeticos'
    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        ' Verificar si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True ' Evitar que se ingrese el carácter no válido
        End If
    End Sub

    'Texbox Nombre - Toma lectura del teclado y solo acepta valores alfabeticos'
    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        ' Verificar si la tecla presionada es una letra o una tecla de control (como Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True ' Evitar que se ingrese el carácter no válido
        End If
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            If RBVaron.Checked Then
                PictureBox1.BackgroundImageLayout = ImageLayout.Center
                PictureBox1.BackgroundImage = Image.FromFile("C:\Users\Luciano\source\repos\Practico 2\Practico 2\Imagenes\varon.png")
            End If
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBox1.BackgroundImageLayout = ImageLayout.Center
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\Luciano\source\repos\Practico 2\Practico 2\Imagenes\mujer.png")
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        If MsgBox("¿Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class



