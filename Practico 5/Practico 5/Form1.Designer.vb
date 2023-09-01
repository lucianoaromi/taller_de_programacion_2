<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.DFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonHombre = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMujer = New System.Windows.Forms.RadioButton()
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GuardarImagen = New System.Windows.Forms.Button()
        Me.TRutaImagen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AgregarDatos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(257, 44)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(226, 34)
        Me.TNombre.TabIndex = 0
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(257, 96)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(226, 34)
        Me.TApellido.TabIndex = 1
        '
        'DFechaNacimiento
        '
        Me.DFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DFechaNacimiento.Location = New System.Drawing.Point(336, 140)
        Me.DFechaNacimiento.Name = "DFechaNacimiento"
        Me.DFechaNacimiento.Size = New System.Drawing.Size(108, 34)
        Me.DFechaNacimiento.TabIndex = 2
        '
        'RadioButtonHombre
        '
        Me.RadioButtonHombre.AutoSize = True
        Me.RadioButtonHombre.BackColor = System.Drawing.SystemColors.Desktop
        Me.RadioButtonHombre.Location = New System.Drawing.Point(319, 180)
        Me.RadioButtonHombre.Name = "RadioButtonHombre"
        Me.RadioButtonHombre.Size = New System.Drawing.Size(93, 30)
        Me.RadioButtonHombre.TabIndex = 3
        Me.RadioButtonHombre.TabStop = True
        Me.RadioButtonHombre.Text = "Hombre"
        Me.RadioButtonHombre.UseVisualStyleBackColor = False
        '
        'RadioButtonMujer
        '
        Me.RadioButtonMujer.AutoSize = True
        Me.RadioButtonMujer.BackColor = System.Drawing.SystemColors.Desktop
        Me.RadioButtonMujer.Location = New System.Drawing.Point(400, 180)
        Me.RadioButtonMujer.Name = "RadioButtonMujer"
        Me.RadioButtonMujer.Size = New System.Drawing.Size(77, 30)
        Me.RadioButtonMujer.TabIndex = 4
        Me.RadioButtonMujer.TabStop = True
        Me.RadioButtonMujer.Text = "Mujer"
        Me.RadioButtonMujer.UseVisualStyleBackColor = False
        '
        'TSaldo
        '
        Me.TSaldo.Location = New System.Drawing.Point(257, 215)
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.Size = New System.Drawing.Size(226, 34)
        Me.TSaldo.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GuardarImagen
        '
        Me.GuardarImagen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GuardarImagen.ForeColor = System.Drawing.Color.Black
        Me.GuardarImagen.Location = New System.Drawing.Point(183, 258)
        Me.GuardarImagen.Name = "GuardarImagen"
        Me.GuardarImagen.Size = New System.Drawing.Size(62, 32)
        Me.GuardarImagen.TabIndex = 7
        Me.GuardarImagen.Text = "Foto"
        Me.GuardarImagen.UseVisualStyleBackColor = False
        '
        'TRutaImagen
        '
        Me.TRutaImagen.Enabled = False
        Me.TRutaImagen.Location = New System.Drawing.Point(257, 260)
        Me.TRutaImagen.Name = "TRutaImagen"
        Me.TRutaImagen.Size = New System.Drawing.Size(226, 34)
        Me.TRutaImagen.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(185, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre:"
        Me.Label1.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(189, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha de nacimiento:"
        '
        'AgregarDatos
        '
        Me.AgregarDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AgregarDatos.Image = CType(resources.GetObject("AgregarDatos.Image"), System.Drawing.Image)
        Me.AgregarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarDatos.Location = New System.Drawing.Point(320, 307)
        Me.AgregarDatos.Name = "AgregarDatos"
        Me.AgregarDatos.Size = New System.Drawing.Size(104, 46)
        Me.AgregarDatos.TabIndex = 13
        Me.AgregarDatos.Text = "Agregar"
        Me.AgregarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarDatos.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(195, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Saldo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.FechaNacimiento, Me.Sexo, Me.Eliminar, Me.Saldo, Me.Imagen, Me.Ruta})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(92, 372)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(675, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 6
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 80
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 80
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.MinimumWidth = 6
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Width = 80
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.MinimumWidth = 6
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 80
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 80
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.MinimumWidth = 6
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Saldo.Width = 80
        '
        'Imagen
        '
        Me.Imagen.HeaderText = "Foto"
        Me.Imagen.MinimumWidth = 6
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Width = 70
        '
        'Ruta
        '
        Me.Ruta.HeaderText = "Ruta"
        Me.Ruta.MinimumWidth = 6
        Me.Ruta.Name = "Ruta"
        Me.Ruta.Width = 80
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(570, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 243)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(560, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 260)
        Me.Panel1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Practico_5.My.Resources.Resources._93b6a4a67850083ea24d8a9fd1039ab9
        Me.ClientSize = New System.Drawing.Size(858, 559)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AgregarDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TRutaImagen)
        Me.Controls.Add(Me.GuardarImagen)
        Me.Controls.Add(Me.TSaldo)
        Me.Controls.Add(Me.RadioButtonMujer)
        Me.Controls.Add(Me.RadioButtonHombre)
        Me.Controls.Add(Me.DFechaNacimiento)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario con DataGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents DFechaNacimiento As DateTimePicker
    Friend WithEvents RadioButtonHombre As RadioButton
    Friend WithEvents RadioButtonMujer As RadioButton
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GuardarImagen As Button
    Friend WithEvents TRutaImagen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AgregarDatos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
End Class
