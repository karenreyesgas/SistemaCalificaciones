<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaMaestro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaMaestro))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPaterno = New System.Windows.Forms.Label()
        Me.lblMaterno = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.lblConfirmarC = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(126, 136)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(126, 177)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtPaterno.TabIndex = 8
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(126, 218)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterno.TabIndex = 10
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(6, 26)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(50, 13)
        Me.lblMatricula.TabIndex = 2
        Me.lblMatricula.Text = "Matricula"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 139)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre"
        '
        'lblPaterno
        '
        Me.lblPaterno.AutoSize = True
        Me.lblPaterno.Location = New System.Drawing.Point(17, 184)
        Me.lblPaterno.Name = "lblPaterno"
        Me.lblPaterno.Size = New System.Drawing.Size(84, 13)
        Me.lblPaterno.TabIndex = 7
        Me.lblPaterno.Text = "Apellido &Paterno"
        '
        'lblMaterno
        '
        Me.lblMaterno.AutoSize = True
        Me.lblMaterno.Location = New System.Drawing.Point(15, 225)
        Me.lblMaterno.Name = "lblMaterno"
        Me.lblMaterno.Size = New System.Drawing.Size(86, 13)
        Me.lblMaterno.TabIndex = 9
        Me.lblMaterno.Text = "Apellido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alta Maestros"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(18, 323)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(182, 323)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBorrar.TabIndex = 17
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMatricula)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.lblMatricula)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(78, 19)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(69, 20)
        Me.txtMatricula.TabIndex = 3
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(178, 19)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 32)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(101, 323)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 16
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(29, 255)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(61, 13)
        Me.lblContra.TabIndex = 11
        Me.lblContra.Text = "Contraseña"
        '
        'lblConfirmarC
        '
        Me.lblConfirmarC.AutoSize = True
        Me.lblConfirmarC.Location = New System.Drawing.Point(9, 287)
        Me.lblConfirmarC.Name = "lblConfirmarC"
        Me.lblConfirmarC.Size = New System.Drawing.Size(108, 13)
        Me.lblConfirmarC.TabIndex = 13
        Me.lblConfirmarC.Text = "Confirmar Contraseña"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(126, 252)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(100, 20)
        Me.txtContra.TabIndex = 12
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(126, 284)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmar.TabIndex = 14
        '
        'AltaMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(279, 361)
        Me.Controls.Add(Me.txtConfirmar)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.lblConfirmarC)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMaterno)
        Me.Controls.Add(Me.lblPaterno)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "AltaMaestro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaMaestro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents lblMatricula As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPaterno As Label
    Friend WithEvents lblMaterno As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents txtMatricula As MaskedTextBox
    Friend WithEvents lblContra As Label
    Friend WithEvents lblConfirmarC As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtConfirmar As TextBox
End Class
