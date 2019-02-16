<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaAlumno))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblAltaA = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.lblConfirmarC = New System.Windows.Forms.Label()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.lblMaterno = New System.Windows.Forms.Label()
        Me.lblPaterno = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.lblMatricula)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(76, 27)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 4
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(191, 20)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 32)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(20, 30)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(50, 13)
        Me.lblMatricula.TabIndex = 1
        Me.lblMatricula.Text = "Matricula"
        '
        'lblAltaA
        '
        Me.lblAltaA.AutoSize = True
        Me.lblAltaA.Location = New System.Drawing.Point(31, 19)
        Me.lblAltaA.Name = "lblAltaA"
        Me.lblAltaA.Size = New System.Drawing.Size(68, 13)
        Me.lblAltaA.TabIndex = 0
        Me.lblAltaA.Text = "Alta Alumnos"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(137, 293)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmar.TabIndex = 15
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(137, 267)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(100, 20)
        Me.txtContra.TabIndex = 13
        '
        'lblConfirmarC
        '
        Me.lblConfirmarC.AutoSize = True
        Me.lblConfirmarC.Location = New System.Drawing.Point(21, 296)
        Me.lblConfirmarC.Name = "lblConfirmarC"
        Me.lblConfirmarC.Size = New System.Drawing.Size(108, 13)
        Me.lblConfirmarC.TabIndex = 14
        Me.lblConfirmarC.Text = "Confirmar Contraseña"
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(40, 267)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(61, 13)
        Me.lblContra.TabIndex = 12
        Me.lblContra.Text = "Contraseña"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(112, 339)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(195, 339)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBorrar.TabIndex = 18
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(26, 339)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 16
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'lblMaterno
        '
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.Location = New System.Drawing.Point(35, 209)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(86, 13)
        Me.lblMaterno.TabIndex = 8
        Me.lblMaterno.Text = "Apellido Materno"
        '
        'lblPaterno
        '
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.Location = New System.Drawing.Point(28, 172)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(84, 13)
        Me.lblPaterno.TabIndex = 6
        Me.lblPaterno.Text = "Apellido &Paterno"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(35, 127)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(137, 206)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterno.TabIndex = 9
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(137, 165)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtPaterno.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(137, 124)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(55, 241)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(41, 13)
        Me.lblCarrera.TabIndex = 10
        Me.lblCarrera.Text = "Carrera"
        '
        'txtCarrera
        '
        Me.txtCarrera.Location = New System.Drawing.Point(137, 238)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(100, 20)
        Me.txtCarrera.TabIndex = 11
        '
        'AltaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(282, 374)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.lblCarrera)
        Me.Controls.Add(Me.txtConfirmar)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.lblConfirmarC)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.lblMaterno)
        Me.Controls.Add(Me.lblPaterno)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblAltaA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AltaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaAlumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMatricula As Label
    Friend WithEvents lblAltaA As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents lblConfirmarC As Label
    Friend WithEvents lblContra As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents lblMaterno As Label
    Friend WithEvents lblPaterno As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCarrera As Label
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents txtMatricula As MaskedTextBox
End Class
