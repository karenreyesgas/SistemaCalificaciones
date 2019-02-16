<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCalificaciones))
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lstAlumno = New System.Windows.Forms.ListBox()
        Me.lstCarrera = New System.Windows.Forms.ListBox()
        Me.lstGrupo = New System.Windows.Forms.ListBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.datagCalificaciones = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.datagCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(16, 182)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
        Me.lblAlumno.TabIndex = 19
        Me.lblAlumno.Text = "Alumno"
        '
        'lstAlumno
        '
        Me.lstAlumno.FormattingEnabled = True
        Me.lstAlumno.Location = New System.Drawing.Point(64, 182)
        Me.lstAlumno.Name = "lstAlumno"
        Me.lstAlumno.Size = New System.Drawing.Size(165, 108)
        Me.lstAlumno.TabIndex = 18
        '
        'lstCarrera
        '
        Me.lstCarrera.FormattingEnabled = True
        Me.lstCarrera.Location = New System.Drawing.Point(64, 62)
        Me.lstCarrera.Name = "lstCarrera"
        Me.lstCarrera.Size = New System.Drawing.Size(165, 43)
        Me.lstCarrera.TabIndex = 17
        '
        'lstGrupo
        '
        Me.lstGrupo.FormattingEnabled = True
        Me.lstGrupo.Location = New System.Drawing.Point(64, 124)
        Me.lstGrupo.Name = "lstGrupo"
        Me.lstGrupo.Size = New System.Drawing.Size(165, 43)
        Me.lstGrupo.TabIndex = 16
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(177, 17)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 32)
        Me.cmdBuscar.TabIndex = 13
        Me.cmdBuscar.UseVisualStyleBackColor = True
        Me.cmdBuscar.Visible = False
        '
        'datagCalificaciones
        '
        Me.datagCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagCalificaciones.Location = New System.Drawing.Point(235, 62)
        Me.datagCalificaciones.Name = "datagCalificaciones"
        Me.datagCalificaciones.Size = New System.Drawing.Size(356, 228)
        Me.datagCalificaciones.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Carrera"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(19, 124)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(36, 13)
        Me.lblGrupo.TabIndex = 14
        Me.lblGrupo.Text = "Grupo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Consultar Calificaciones"
        '
        'ConsultaCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(612, 302)
        Me.Controls.Add(Me.lblAlumno)
        Me.Controls.Add(Me.lstAlumno)
        Me.Controls.Add(Me.lstCarrera)
        Me.Controls.Add(Me.lstGrupo)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.datagCalificaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaCalificaciones"
        CType(Me.datagCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAlumno As Label
    Friend WithEvents lstAlumno As ListBox
    Friend WithEvents lstCarrera As ListBox
    Friend WithEvents lstGrupo As ListBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents datagCalificaciones As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents Label1 As Label
End Class
