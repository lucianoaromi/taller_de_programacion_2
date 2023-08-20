<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        LNya = New Label()
        LModificar = New Label()
        LDni = New Label()
        LApellido = New Label()
        LNombre = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.BackColor = SystemColors.ActiveBorder
        LNya.Location = New Point(48, 78)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.BackColor = SystemColors.ActiveBorder
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(156, 78)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 1
        LModificar.Text = "modificar"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.BackColor = SystemColors.ActiveBorder
        LDni.Location = New Point(48, 142)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 2
        LDni.Text = "DNI"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.BackColor = SystemColors.ActiveBorder
        LApellido.Location = New Point(48, 203)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.BackColor = SystemColors.ActiveBorder
        LNombre.Location = New Point(48, 267)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(122, 142)
        TDni.Name = "TDni"
        TDni.Size = New Size(143, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(122, 195)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(143, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(122, 264)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(143, 23)
        TNombre.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.BackgroundImageLayout = ImageLayout.Stretch
        BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), Image)
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.Location = New Point(58, 460)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(100, 50)
        BGuardar.TabIndex = 8
        BGuardar.Text = "Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleRight
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(183, 460)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(100, 50)
        BEliminar.TabIndex = 9
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Location = New Point(18, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 387)
        Panel1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(30, 282)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 14
        Label1.Text = "Tarjeta de creditos:"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(146, 332)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(79, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Mastercrd"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(146, 307)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(47, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Visa"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(146, 282)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Naranja"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(342, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Checked = True
        RBVaron.Location = New Point(349, 268)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 12
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(429, 268)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 13
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(366, 460)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(100, 50)
        BSalir.TabIndex = 14
        BSalir.Text = "&Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(513, 548)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDni)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(LDni)
        Controls.Add(LModificar)
        Controls.Add(LNya)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BSalir As Button
End Class
