<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subir_Calificaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subir_Calificaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datagCalificaciones = New System.Windows.Forms.DataGridView()
        Me.AlumnomateriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaDataSet1 = New WindowsApplication1.SistemaDataSet1()
        Me.Alumno_materiaTableAdapter = New WindowsApplication1.SistemaDataSet1TableAdapters.alumno_materiaTableAdapter()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.SistemaDataSet2 = New WindowsApplication1.SistemaDataSet2()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoTableAdapter = New WindowsApplication1.SistemaDataSet2TableAdapters.GrupoTableAdapter()
        Me.lstGrupo = New System.Windows.Forms.ListBox()
        Me.lstCarrera = New System.Windows.Forms.ListBox()
        Me.lstAlumno = New System.Windows.Forms.ListBox()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.datagCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnomateriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subir Calificaciones"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(45, 90)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(36, 13)
        Me.lblGrupo.TabIndex = 4
        Me.lblGrupo.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Carrera"
        '
        'datagCalificaciones
        '
        Me.datagCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagCalificaciones.Location = New System.Drawing.Point(261, 41)
        Me.datagCalificaciones.Name = "datagCalificaciones"
        Me.datagCalificaciones.Size = New System.Drawing.Size(298, 191)
        Me.datagCalificaciones.TabIndex = 6
        '
        'AlumnomateriaBindingSource
        '
        Me.AlumnomateriaBindingSource.DataMember = "alumno_materia"
        Me.AlumnomateriaBindingSource.DataSource = Me.SistemaDataSet1
        '
        'SistemaDataSet1
        '
        Me.SistemaDataSet1.DataSetName = "SistemaDataSet1"
        Me.SistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alumno_materiaTableAdapter
        '
        Me.Alumno_materiaTableAdapter.ClearBeforeFill = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(1, -1)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 32)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.UseVisualStyleBackColor = True
        Me.cmdBuscar.Visible = False
        '
        'SistemaDataSet2
        '
        Me.SistemaDataSet2.DataSetName = "SistemaDataSet2"
        Me.SistemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.SistemaDataSet2
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'lstGrupo
        '
        Me.lstGrupo.FormattingEnabled = True
        Me.lstGrupo.Location = New System.Drawing.Point(90, 90)
        Me.lstGrupo.Name = "lstGrupo"
        Me.lstGrupo.Size = New System.Drawing.Size(165, 43)
        Me.lstGrupo.TabIndex = 7
        '
        'lstCarrera
        '
        Me.lstCarrera.FormattingEnabled = True
        Me.lstCarrera.Location = New System.Drawing.Point(90, 41)
        Me.lstCarrera.Name = "lstCarrera"
        Me.lstCarrera.Size = New System.Drawing.Size(165, 43)
        Me.lstCarrera.TabIndex = 8
        '
        'lstAlumno
        '
        Me.lstAlumno.FormattingEnabled = True
        Me.lstAlumno.Location = New System.Drawing.Point(90, 139)
        Me.lstAlumno.Name = "lstAlumno"
        Me.lstAlumno.Size = New System.Drawing.Size(165, 95)
        Me.lstAlumno.TabIndex = 9
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(42, 139)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
        Me.lblAlumno.TabIndex = 10
        Me.lblAlumno.Text = "Alumno"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Subir_Calificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 244)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAlumno)
        Me.Controls.Add(Me.lstAlumno)
        Me.Controls.Add(Me.lstCarrera)
        Me.Controls.Add(Me.lstGrupo)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.datagCalificaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Subir_Calificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir_Calificaciones"
        CType(Me.datagCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnomateriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents datagCalificaciones As DataGridView
    Friend WithEvents SistemaDataSet1 As SistemaDataSet1
    Friend WithEvents AlumnomateriaBindingSource As BindingSource
    Friend WithEvents Alumno_materiaTableAdapter As SistemaDataSet1TableAdapters.alumno_materiaTableAdapter
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents SistemaDataSet2 As SistemaDataSet2
    Friend WithEvents GrupoBindingSource As BindingSource
    Friend WithEvents GrupoTableAdapter As SistemaDataSet2TableAdapters.GrupoTableAdapter
    Friend WithEvents lstGrupo As ListBox
    Friend WithEvents lstCarrera As ListBox
    Friend WithEvents lstAlumno As ListBox
    Friend WithEvents lblAlumno As Label
    Friend WithEvents Button1 As Button
End Class
