<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subir_Horarios
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
        Me.picBlob = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        CType(Me.picBlob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBlob
        '
        Me.picBlob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBlob.Location = New System.Drawing.Point(12, 2)
        Me.picBlob.Name = "picBlob"
        Me.picBlob.Size = New System.Drawing.Size(747, 532)
        Me.picBlob.TabIndex = 0
        Me.picBlob.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Subir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(233, 540)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Guardar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(23, 550)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(39, 13)
        Me.lblGrupo.TabIndex = 3
        Me.lblGrupo.Text = "Grupo:"
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(68, 543)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(74, 20)
        Me.txtGrupo.TabIndex = 4
        '
        'Subir_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 608)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picBlob)
        Me.Name = "Subir_Horarios"
        Me.Text = "Form1"
        CType(Me.picBlob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBlob As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Save As Button
    Friend WithEvents lblGrupo As Label
    Friend WithEvents txtGrupo As TextBox
End Class
