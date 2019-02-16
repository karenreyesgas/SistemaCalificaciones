Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb

Public Class AltaMateria
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuatrimestreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CuatrimestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SistemaDataSet = New WindowsApplication1.SistemaDataSet()
        Me.SistemaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaTableAdapter = New WindowsApplication1.SistemaDataSetTableAdapters.MateriaTableAdapter()
        Me.CuatrimestreTableAdapter = New WindowsApplication1.SistemaDataSetTableAdapters.cuatrimestreTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuatrimestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMateriaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CuatrimestreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SistemaDataSetBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(573, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'IdMateriaDataGridViewTextBoxColumn
        '
        Me.IdMateriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Materia"
        Me.IdMateriaDataGridViewTextBoxColumn.HeaderText = "Id_Materia"
        Me.IdMateriaDataGridViewTextBoxColumn.Name = "IdMateriaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CuatrimestreDataGridViewTextBoxColumn
        '
        Me.CuatrimestreDataGridViewTextBoxColumn.DataPropertyName = "Cuatrimestre"
        Me.CuatrimestreDataGridViewTextBoxColumn.DataSource = Me.CuatrimestreBindingSource
        Me.CuatrimestreDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.CuatrimestreDataGridViewTextBoxColumn.HeaderText = "Cuatrimestre"
        Me.CuatrimestreDataGridViewTextBoxColumn.Name = "CuatrimestreDataGridViewTextBoxColumn"
        Me.CuatrimestreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CuatrimestreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CuatrimestreDataGridViewTextBoxColumn.ValueMember = "cuatrimestre"
        '
        'CuatrimestreBindingSource
        '
        Me.CuatrimestreBindingSource.DataMember = "cuatrimestre"
        Me.CuatrimestreBindingSource.DataSource = Me.SistemaDataSet
        '
        'SistemaDataSet
        '
        Me.SistemaDataSet.DataSetName = "SistemaDataSet"
        Me.SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SistemaDataSetBindingSource
        '
        Me.SistemaDataSetBindingSource.DataMember = "Materia"
        Me.SistemaDataSetBindingSource.DataSource = Me.SistemaDataSet
        '
        'MateriaTableAdapter
        '
        Me.MateriaTableAdapter.ClearBeforeFill = True
        '
        'CuatrimestreTableAdapter
        '
        Me.CuatrimestreTableAdapter.ClearBeforeFill = True
        '
        'AltaMateria
        '
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(573, 216)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AltaMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuatrimestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub AltaMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.cuatrimestre' Puede moverla o quitarla según sea necesario.
        Me.CuatrimestreTableAdapter.Fill(Me.SistemaDataSet.cuatrimestre)
        'TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.Materia' Puede moverla o quitarla según sea necesario.
        Me.MateriaTableAdapter.Fill(Me.SistemaDataSet.Materia)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged


    End Sub

    Private Sub DataGridView1_Validating(sender As Object, e As CancelEventArgs) Handles DataGridView1.Validating
    End Sub
End Class