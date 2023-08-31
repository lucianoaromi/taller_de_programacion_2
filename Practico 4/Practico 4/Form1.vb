Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Texbox Desde - Toma lectura del teclado y solo acepta valores numericos'
    Private Sub TDesde(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Verificar si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Evitar que se ingrese el carácter no válido
        End If
    End Sub

    'Texbox Hasta - Toma lectura del teclado y solo acepta valores numericos'
    Private Sub THasta(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Verificar si la tecla presionada es un número o una tecla de control (como Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Evitar que se ingrese el carácter no válido
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Llama a la funcion CampoVacio que verifica que no exista campos vacios
        CampoVacio()

        ' Validar que los campos contengan números válidos
        Dim desde As Integer
        Dim hasta As Integer

        If Integer.TryParse(TextBox1.Text, desde) And Integer.TryParse(TextBox2.Text, hasta) Then

            ListBox1.Items.Clear()
            Chart1.Series.Clear()

            If desde > hasta Then
                MessageBox.Show("El valor de inicio debe ser mayor al valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Generar los números desde "desde" hasta "hasta" y mostrarlos en el cuadro de texto
            Dim serieNumeros As New DataVisualization.Charting.Series("Números Pares")
            For num As Integer = desde To hasta
                ListBox1.Items.Add(num.ToString())
                serieNumeros.Points.AddXY(num, num)
            Next

            Chart1.Series.Add(serieNumeros)

        End If

    End Sub

    Private Sub NumerosPares_Click(sender As Object, e As EventArgs) Handles NumerosPares.Click

        'Llama a la funcion CampoVacio que verifica que no exista campos vacios
        CampoVacio()

        Dim desde As Integer
        Dim hasta As Integer

        If Integer.TryParse(TextBox1.Text, desde) And Integer.TryParse(TextBox2.Text, hasta) Then

            ListBox1.Items.Clear()
            Chart1.Series.Clear()

            Dim serieNumerosPares As New DataVisualization.Charting.Series("Números Pares")
            For num As Integer = desde To hasta
                If num Mod 2 = 0 Then
                    ListBox1.Items.Add(num)
                    serieNumerosPares.Points.AddXY(num, num)
                End If
            Next

            Chart1.Series.Add(serieNumerosPares)

        End If

    End Sub



    Private Sub NumerosImpares_Click(sender As Object, e As EventArgs) Handles NumerosImpares.Click

        'Llama a la funcion CampoVacio que verifica que no exista campos vacios
        CampoVacio()

        Dim desde As Integer
        Dim hasta As Integer

        If Integer.TryParse(TextBox1.Text, desde) And Integer.TryParse(TextBox2.Text, hasta) Then

            ListBox1.Items.Clear()
            Chart1.Series.Clear()

            Dim serieNumerosImpares As New DataVisualization.Charting.Series("Números Pares")
            For num As Integer = desde To hasta
                If num Mod 2 <> 0 Then
                    ListBox1.Items.Add(num)
                    serieNumerosImpares.Points.AddXY(num, num)
                End If
            Next

            Chart1.Series.Add(serieNumerosImpares)

        End If

    End Sub

    Private Sub NumerosPrimos_Click(sender As Object, e As EventArgs) Handles NumerosPrimos.Click

        'Llama a la funcion CampoVacio que verifica que no exista campos vacios
        CampoVacio()

        Dim desde As Integer
        Dim hasta As Integer

        If Integer.TryParse(TextBox1.Text, desde) And Integer.TryParse(TextBox2.Text, hasta) Then

            ListBox1.Items.Clear()
            Chart1.Series.Clear()

            Dim serieNumerosPrimos As New DataVisualization.Charting.Series("Números Primos")
            For num As Integer = desde To hasta
                Dim isPrime As Boolean = True
                For i As Integer = 2 To Math.Sqrt(num)
                    If num Mod i = 0 Then
                        isPrime = False
                        Exit For
                    End If
                Next
                If isPrime Then
                    ListBox1.Items.Add(num)
                    serieNumerosPrimos.Points.AddXY(num, num)
                End If
            Next

            Chart1.Series.Add(serieNumerosPrimos)

        End If

    End Sub

    'Funcion CampoVacio que verifica que los todos los campos no esten vacios   
    Private Function CampoVacio()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return (False)

    End Function

End Class
