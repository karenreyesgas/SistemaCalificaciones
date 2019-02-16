<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaMateria
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SistemaDataSetBindingSource As BindingSource
    Friend WithEvents SistemaDataSet As SistemaDataSet
    Friend WithEvents MateriaTableAdapter As SistemaDataSetTableAdapters.MateriaTableAdapter
    Friend WithEvents CuatrimestreBindingSource As BindingSource
    Friend WithEvents CuatrimestreTableAdapter As SistemaDataSetTableAdapters.cuatrimestreTableAdapter
    Friend WithEvents IdMateriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuatrimestreDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
