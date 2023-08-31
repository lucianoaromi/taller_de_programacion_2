
Imports System.IO


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear() ' Limpia las filas existentes al cargar el formulario
    End Sub

    Private Sub GuardarImagen_Click(sender As Object, e As EventArgs) Handles GuardarImagen.Click
        ' Abre un cuadro de diálogo para seleccionar una imagen.
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtiene la ruta de la imagen seleccionada.
            Dim imagePath As String = openFileDialog.FileName

            ' Muestra la imagen en el PictureBox.
            PictureBox1.Image = Image.FromFile(imagePath)

            ' Muestra la ruta de la imagen en el TextBox.
            TRutaImagen.Text = imagePath
        End If
    End Sub

    Private Sub AgregarDatos_Click(sender As Object, e As EventArgs) Handles AgregarDatos.Click
        Dim sexo As String = If(RadioButtonHombre.Checked, "Hombre", "Mujer")
        Dim rutaImagen As String = TRutaImagen.Text

        Dim saldo As Decimal
        If Not Decimal.TryParse(TSaldo.Text, saldo) Then
            MessageBox.Show("Ingrese un valor numérico válido en el campo Saldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fila As Object() = {
            TApellido.Text,
            TNombre.Text,
            DFechaNacimiento.Value.ToString("dd/MM/yyyy"),
            sexo,
            "Eliminar",
            TSaldo.Text,
            Image.FromFile(rutaImagen),
            rutaImagen
        }

        Dim rowIndex As Integer = DataGridView1.Rows.Add(fila)

        If saldo < 50 Then
            DataGridView1.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red

        End If

        DataGridView1.Rows(rowIndex).Height = 50 ' Cambiar esta altura según tus necesidades

        ' Agregar imagen redimensionada y centrada en la celda
        If File.Exists(rutaImagen) Then
            DataGridView1.Rows(rowIndex).Cells("Imagen").Value = ResizeImage(Image.FromFile(rutaImagen), DataGridView1.Columns("Imagen").Width, DataGridView1.Rows(rowIndex).Height)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar esta fila?", "Eliminar Fila", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Image Then
            Dim img As Image = DirectCast(e.Value, Image)
            Dim cellSize As Size = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Size
            Dim newImg As Image = ResizeImage(img, cellSize.Width, cellSize.Height)
            e.Value = newImg
            e.FormattingApplied = True
        End If
    End Sub

    Private Function ResizeImage(image As Image, width As Integer, height As Integer) As Image
        Dim newImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(newImage)
            g.DrawImage(image, 0, 0, width, height)
        End Using
        Return newImage
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Llena los campos de los TextBox con los datos de la fila seleccionada
            TApellido.Text = selectedRow.Cells("Apellido").Value.ToString()
            TNombre.Text = selectedRow.Cells("Nombre").Value.ToString()
            DFechaNacimiento.Value = DateTime.Parse(selectedRow.Cells("FechaNacimiento").Value.ToString())

            Dim sexo As String = selectedRow.Cells("Sexo").Value.ToString()
            If sexo = "Hombre" Then
                RadioButtonHombre.Checked = True
            ElseIf sexo = "Mujer" Then
                RadioButtonMujer.Checked = True
            End If

            TSaldo.Text = selectedRow.Cells("Saldo").Value.ToString()
            TRutaImagen.Text = selectedRow.Cells("Ruta").Value.ToString()

            ' Cargar la imagen en el PictureBox si la ruta es válida
            If File.Exists(TRutaImagen.Text) Then
                PictureBox1.Image = Image.FromFile(TRutaImagen.Text)
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub


End Class
