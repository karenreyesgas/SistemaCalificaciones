<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaCarrera))
        Me.lblAltaCarreras = New System.Windows.Forms.Label()
        Me.lblID_Carrera = New System.Windows.Forms.Label()
        Me.txtID_Carrera = New System.Windows.Forms.TextBox()
        Me.lblNombreC = New System.Windows.Forms.Label()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.cmbAñadir = New System.Windows.Forms.ComboBox()
        Me.MateriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaDataSet = New WindowsApplication1.SistemaDataSet()
        Me.btn_Añadir = New System.Windows.Forms.Button()
        Me.lbl__AñadirM = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MateriaTableAdapter = New WindowsApplication1.SistemaDataSetTableAdapters.MateriaTableAdapter()
        Me.cmdAñadirM = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.datagMaterias = New System.Windows.Forms.DataGridView()
        Me.cmdGuardarMateria = New System.Windows.Forms.Button()
        CType(Me.MateriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAltaCarreras
        '
        Me.lblAltaCarreras.AutoSize = True
        Me.lblAltaCarreras.Location = New System.Drawing.Point(84, 22)
        Me.lblAltaCarreras.Name = "lblAltaCarreras"
        Me.lblAltaCarreras.Size = New System.Drawing.Size(67, 13)
        Me.lblAltaCarreras.TabIndex = 0
        Me.lblAltaCarreras.Text = "Alta Carreras"
        '
        'lblID_Carrera
        '
        Me.lblID_Carrera.AutoSize = True
        Me.lblID_Carrera.Location = New System.Drawing.Point(18, 41)
        Me.lblID_Carrera.Name = "lblID_Carrera"
        Me.lblID_Carrera.Size = New System.Drawing.Size(55, 13)
        Me.lblID_Carrera.TabIndex = 1
        Me.lblID_Carrera.Text = "ID Carrera"
        '
        'txtID_Carrera
        '
        Me.txtID_Carrera.Location = New System.Drawing.Point(87, 41)
        Me.txtID_Carrera.Name = "txtID_Carrera"
        Me.txtID_Carrera.Size = New System.Drawing.Size(106, 20)
        Me.txtID_Carrera.TabIndex = 2
        '
        'lblNombreC
        '
        Me.lblNombreC.AutoSize = True
        Me.lblNombreC.Location = New System.Drawing.Point(18, 90)
        Me.lblNombreC.Name = "lblNombreC"
        Me.lblNombreC.Size = New System.Drawing.Size(81, 13)
        Me.lblNombreC.TabIndex = 4
        Me.lblNombreC.Text = "Nombre Carrera"
        '
        'txtNombreC
        '
        Me.txtNombreC.Location = New System.Drawing.Point(105, 83)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(106, 20)
        Me.txtNombreC.TabIndex = 5
        '
        'cmbAñadir
        '
        Me.cmbAñadir.DisplayMember = "Id_Materia"
        Me.cmbAñadir.FormattingEnabled = True
        Me.cmbAñadir.Location = New System.Drawing.Point(105, 112)
        Me.cmbAñadir.Name = "cmbAñadir"
        Me.cmbAñadir.Size = New System.Drawing.Size(287, 21)
        Me.cmbAñadir.TabIndex = 7
        Me.cmbAñadir.ValueMember = "Id_Materia"
        '
        'MateriaBindingSource
        '
        Me.MateriaBindingSource.DataMember = "Materia"
        Me.MateriaBindingSource.DataSource = Me.SistemaDataSet
        '
        'SistemaDataSet
        '
        Me.SistemaDataSet.DataSetName = "SistemaDataSet"
        Me.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Añadir
        '
        Me.btn_Añadir.Location = New System.Drawing.Point(398, 112)
        Me.btn_Añadir.Name = "btn_Añadir"
        Me.btn_Añadir.Size = New System.Drawing.Size(34, 23)
        Me.btn_Añadir.TabIndex = 8
        Me.btn_Añadir.Text = "+"
        Me.btn_Añadir.UseVisualStyleBackColor = True
        '
        'lbl__AñadirM
        '
        Me.lbl__AñadirM.AutoSize = True
        Me.lbl__AñadirM.Location = New System.Drawing.Point(18, 117)
        Me.lbl__AñadirM.Name = "lbl__AñadirM"
        Me.lbl__AñadirM.Size = New System.Drawing.Size(75, 13)
        Me.lbl__AñadirM.TabIndex = 6
        Me.lbl__AñadirM.Text = "Añadir Materia"
        '
        'MateriaTableAdapter
        '
        Me.MateriaTableAdapter.ClearBeforeFill = True
        '
        'cmdAñadirM
        '
        Me.cmdAñadirM.Location = New System.Drawing.Point(153, 287)
        Me.cmdAñadirM.Name = "cmdAñadirM"
        Me.cmdAñadirM.Size = New System.Drawing.Size(72, 23)
        Me.cmdAñadirM.TabIndex = 9
        Me.cmdAñadirM.Text = "Guardar"
        Me.cmdAñadirM.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(199, 31)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 32)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'datagMaterias
        '
        Me.datagMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagMaterias.Location = New System.Drawing.Point(21, 141)
        Me.datagMaterias.Name = "datagMaterias"
        Me.datagMaterias.Size = New System.Drawing.Size(434, 121)
        Me.datagMaterias.TabIndex = 9
        '
        'cmdGuardarMateria
        '
        Me.cmdGuardarMateria.Location = New System.Drawing.Point(21, 287)
        Me.cmdGuardarMateria.Name = "cmdGuardarMateria"
        Me.cmdGuardarMateria.Size = New System.Drawing.Size(115, 23)
        Me.cmdGuardarMateria.TabIndex = 12
        Me.cmdGuardarMateria.Text = "Guardar Materia"
        Me.cmdGuardarMateria.UseVisualStyleBackColor = True
        '
        'AltaCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(467, 337)
        Me.Controls.Add(Me.cmdGuardarMateria)
        Me.Controls.Add(Me.datagMaterias)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdAñadirM)
        Me.Controls.Add(Me.lbl__AñadirM)
        Me.Controls.Add(Me.btn_Añadir)
        Me.Controls.Add(Me.cmbAñadir)
        Me.Controls.Add(Me.txtNombreC)
        Me.Controls.Add(Me.lblNombreC)
        Me.Controls.Add(Me.txtID_Carrera)
        Me.Controls.Add(Me.lblID_Carrera)
        Me.Controls.Add(Me.lblAltaCarreras)
        Me.MaximizeBox = False
        Me.Name = "AltaCarrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaCarrera"
        CType(Me.MateriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaCarreras As Label
    Friend WithEvents lblID_Carrera As Label
    Friend WithEvents txtID_Carrera As TextBox
    Friend WithEvents lblNombreC As Label
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents cmbAñadir As ComboBox
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents lbl__AñadirM As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SistemaDataSet As SistemaDataSet
    Friend WithEvents MateriaBindingSource As BindingSource
    Friend WithEvents MateriaTableAdapter As SistemaDataSetTableAdapters.MateriaTableAdapter
    Friend WithEvents cmdAñadirM As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents datagMaterias As DataGridView
    Friend WithEvents cmdGuardarMateria As Button
End Class
