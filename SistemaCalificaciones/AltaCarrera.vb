Imports System.Data
Imports System.Data.OleDb
Public Class AltaCarrera
    Private Sub Limpiar()
        txtID_Carrera.Text = ""
        txtNombreC.Text = ""


    End Sub
    Private Function savedatacarrera() As Boolean

        Dim consulta As String
        consulta = "    Delete  
                        From Carrera as c
                        WHERE c.Id_Carrera = @IDCarrera 
                    "

        Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
            con.Open()

            Using cmdSelect As New OleDbCommand(consulta, con)
                cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                cmdSelect.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                Dim dtrReader As Integer = cmdSelect.ExecuteNonQuery
            End Using
        End Using

        Dim consultaAdd As String
        consultaAdd = "    INSERT INTO Carrera (Id_Carrera,Nombre) 
                            Select @IDCarrera AS Id_Carrera, @IDNombre As Nombre"

        Using conins As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
            conins.Open()

            Using cmdInsert As New OleDbCommand(consultaAdd, conins)
                cmdInsert.Parameters.Add("@IDCarrera", OleDbType.Char)
                cmdInsert.Parameters.Add("@IDNombre", OleDbType.Char)
                cmdInsert.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                cmdInsert.Parameters("@IDNombre").Value = txtNombreC.Text
                Dim dtrInsert As Integer = cmdInsert.ExecuteNonQuery
                If dtrInsert <= 0 Then

                    Return False
                End If

            End Using

        End Using




        Return True


    End Function
    Private Function savedatamateriacarrera() As Boolean

        Dim consulta As String
        consulta = "    Delete  
                        From Carrera_materia as c
                        WHERE c.Id_Carrera = @IDCarrera 
                    "

        Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
            con.Open()

            Using cmdSelect As New OleDbCommand(consulta, con)
                cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                cmdSelect.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                Dim dtrReader As Integer = cmdSelect.ExecuteNonQuery
            End Using
        End Using

        Dim renglontickets As DataGridViewRow
        Dim contSeleccion As Integer

        contSeleccion = 0
        For Each renglontickets In datagMaterias.Rows

            If IsNothing(renglontickets.Cells(0).Value) Then
            Else

                Dim consultaAdd As String
                consultaAdd = "    INSERT INTO Carrera_Materia (Id_Carrera,Id_Materia) 
                            Select @IDCarrera AS Id_Carrera, @IDMateria As Id_Materia"

                Using conins As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                    conins.Open()

                    Using cmdInsert As New OleDbCommand(consultaAdd, conins)
                        cmdInsert.Parameters.Add("@IDCarrera", OleDbType.Char)
                        cmdInsert.Parameters.Add("@IDMateria", OleDbType.Char)
                        cmdInsert.Parameters("@IDCarrera").Value = renglontickets.Cells(0).Value
                        cmdInsert.Parameters("@IDMateria").Value = renglontickets.Cells(1).Value
                        Dim dtrInsert As Integer = cmdInsert.ExecuteNonQuery
                        If dtrInsert <= 0 Then
                            Return False
                        End If

                    End Using

                End Using


            End If


        Next




        Return True


    End Function
    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdAñadirM.Click
        Try
            Dim guardado As Boolean = savedatacarrera()
            If guardado = False Then
                MsgBox("Datos no guardados..", MsgBoxStyle.Critical)
            End If
            guardado = savedatamateriacarrera()
            If guardado = False Then
                MsgBox("Datos no guardados..", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

    End Sub

    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        'lwMateria.Items.Add(cmbAñadir.SelectedValue, cmbAñadir.SelectedText)
        Dim index As Integer = cmbAñadir.SelectedIndex
        Dim cuatri As Integer = obtencuatri(cmbAñadir.SelectedValue.ToString)
        Dim row As String() = New String() {txtID_Carrera.Text, cmbAñadir.SelectedValue, cmbAñadir.Text, cuatri}
        datagMaterias.Rows.Add(row)
        cmbAñadir.Items.RemoveAt(index)
    End Sub

    Private Sub txtID_Carrera_TextChanged(sender As Object, e As EventArgs) Handles txtID_Carrera.TextChanged

    End Sub

    Private Sub BindMaterias()
        Try


            Dim consulta As String
            consulta = "  SELECT Materia.Id_Materia, Materia.Nombre FROM Materia LEFT JOIN (SELECT carrera_materia.id_carrera, carrera_materia.id_materia
                            FROM Carrera INNER JOIN carrera_materia ON Carrera.Id_Carrera = carrera_materia.id_carrera
                            WHERE Carrera.Id_Carrera= @IDCarrera) AS  c ON c.id_materia = Materia.ID_Materia
                            WHERE ISNULL(c.ID_Materia )
                            ;

                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then
                        'If dtrReader.Read() Then
                        'Dim bindingSource1 As New BindingSource()
                        'bindingSource1.DataSource = dtrReader
                        'cmbAñadir.ValueMember = "ID_Materia"
                        'cmbAñadir.DisplayMember = "Nombre"
                        'cmbAñadir.DataSource = bindingSource1
                        'cmbAñadir.Refresh()
                        'End If
                        Do While dtrReader.Read

                            cmbAñadir.Items.Add(dtrReader("Nombre"))


                        Loop
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Try


            Dim consulta As String
            consulta = "    Select c.*  
                        From Carrera as c
                        WHere ID_Carrera = @IDCarrera
                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        If dtrReader.Read() Then
                            txtNombreC.Text = dtrReader("Nombre")
                            Call BindMaterias()
                            Call BindMateriasCarrera()
                            txtID_Carrera.Enabled = False
                            txtID_Carrera.BackColor = Color.LightGray
                            cmbAñadir.Enabled = True
                            cmbAñadir.BackColor = Color.White
                            datagMaterias.Enabled = True
                            datagMaterias.BackgroundColor = Color.White
                            btn_Añadir.Enabled = True
                            txtNombreC.Enabled = True
                            txtNombreC.BackColor = Color.White
                        End If
                    Else

                        Dim seleccion As Integer = MsgBox("Carrera no encontrada, deseas añadir...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                        If seleccion = vbYes Then
                            txtID_Carrera.Enabled = False
                            txtID_Carrera.BackColor = Color.LightGray
                            cmbAñadir.Enabled = True
                            cmbAñadir.BackColor = Color.White
                            datagMaterias.Enabled = True
                            datagMaterias.BackgroundColor = Color.White
                            btn_Añadir.Enabled = True
                            txtNombreC.Enabled = True
                            txtNombreC.BackColor = Color.White
                            txtNombreC.Text = ""
                            Call BindMaterias()
                            Call BindMateriasCarrera()
                        End If
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

    End Sub
    Private Sub BindMateriasCarrera()
        Try


            Dim consulta As String
            consulta = "  SELECT Carrera.Id_Carrera, Materia.Id_Materia, Materia.Nombre, Materia.Cuatrimestre
                            FROM (Carrera INNER JOIN carrera_materia ON Carrera.Id_Carrera = carrera_materia.id_carrera) INNER JOIN Materia ON carrera_materia.id_materia = Materia.Id_Materia
                            WHERE Carrera.Id_Carrera= @IDCarrera

                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = txtID_Carrera.Text
                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then
                        Do While dtrReader.Read
                            Dim row As String() = New String() {dtrReader("ID_Carrera"), dtrReader("Id_Materia"), dtrReader("Nombre"), dtrReader("Cuatrimestre")}
                            datagMaterias.Rows.Add(row)
                        Loop
                        'Dim bindingSource1 As New BindingSource()
                        'bindingSource1.DataSource = dtrReader
                        'datagMaterias.DataSource = bindingSource1
                        'datagMaterias.Refresh()
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

    End Sub

    Private Function obtencuatri(ID_Materia As String) As Integer
        Try


            Dim consulta As String
            consulta = "  SELECT Materia.*
                            FROM Materia 
                            WHERE Materia.id_materia = @IDMateria;
                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDMateria", OleDbType.Char)
                    cmdSelect.Parameters("@IDMateria").Value = ID_Materia.ToString
                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then
                        If dtrReader.Read() Then
                            Return dtrReader("Cuatrimestre")
                        End If
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Return 0

        End Try

        Return 0

    End Function



    Private Sub AltaCarrera_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtID_Carrera.Enabled = True
        txtID_Carrera.BackColor = Color.White
        cmbAñadir.Enabled = False
        cmbAñadir.BackColor = Color.LightGray
        datagMaterias.Enabled = False
        datagMaterias.BackgroundColor = Color.LightGray
        btn_Añadir.Enabled = False
        txtNombreC.Enabled = False
        txtNombreC.BackColor = Color.LightGray
        cmdBuscar.Enabled = True
        datagMaterias.ColumnCount = 4
        datagMaterias.Columns(0).Name = "ID_Carrera"
        datagMaterias.Columns(1).Name = "Id_Materia"
        datagMaterias.Columns(2).Name = "Nombre"
        datagMaterias.Columns(3).Name = "Cuatrimestre"
    End Sub
End Class