Imports System.Data
Imports System.Data.OleDb
Public Class ConsultaCalificaciones
    Private Sub ConsultaCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datagCalificaciones.ReadOnly = True


        'datagCalificaciones.Visible = False
        ''TODO: esta línea de código carga datos en la tabla 'SistemaDataSet2.Grupo' Puede moverla o quitarla según sea necesario.
        'Me.GrupoTableAdapter.Fill(Me.SistemaDataSet2.Grupo)
        ''TODO: esta línea de código carga datos en la tabla 'SistemaDataSet1.alumno_materia' Puede moverla o quitarla según sea necesario.
        'Me.Alumno_materiaTableAdapter.Fill(Me.SistemaDataSet1.alumno_materia)


        lstAlumno.Items.Clear()
        lstGrupo.Items.Clear()
        lstCarrera.Items.Clear()
        datagCalificaciones.Rows.Clear()

        datagCalificaciones.ColumnCount = 3
        datagCalificaciones.Columns(0).Name = "ID_Materia"
        datagCalificaciones.Columns(1).Name = "Nombre"
        datagCalificaciones.Columns(2).Name = "Calificacion"


        Call bindCarreras()

    End Sub
    Private Sub Desactivar()
        lstCarrera.Enabled = True
        datagCalificaciones.Enabled = False
        datagCalificaciones.BackgroundColor = Color.DarkGray
        lstGrupo.Enabled = True
    End Sub
    Private Sub Activar()
        lstCarrera.Enabled = False
        lstCarrera.BackColor = Color.DarkGray
        datagCalificaciones.Enabled = True
        datagCalificaciones.BackgroundColor = Color.White
        lstGrupo.BackColor = Color.DarkGray

        lstGrupo.Enabled = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagCalificaciones.CellContentClick

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try


            Dim consulta As String
            consulta = " SELECT Grupo.Id_Grupo
                        FROM (Grupo INNER JOIN Alumno ON Grupo.MatriculaAlumno = Alumno.Matricula) INNER JOIN Carrera ON Alumno.Carrera = Carrera.Id_Carrera
                        WHERE (((Carrera.Id_Carrera)=@IDCarrera))
                            GROUP BY Grupo.Id_Grupo;

                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrea", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = lstCarrera.Text

                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        lstGrupo.Items.Clear()
                        Do While dtrReader.Read()

                            lstGrupo.Items.Add(dtrReader("ID_Grupo"))
                        Loop
                        Call Activar()


                    Else

                        Dim seleccion As Integer = MsgBox("Carrera no encontrada", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                        If seleccion = vbYes Then


                        End If
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try
    End Sub

    Private Sub bindCarreras()
        Try


            Dim consulta As String
            consulta = " SELECT Carrera.* 
                        FROM Carrera ;

                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()
                Using cmdSelect As New OleDbCommand(consulta, con)
                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        lstGrupo.Items.Clear()
                        Do While dtrReader.Read()
                            lstCarrera.Items.Add(dtrReader("ID_Carrera"))
                        Loop
                    Else
                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try
    End Sub
    Private Sub ltbGrupo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCarrera.SelectedIndexChanged

        Try

            lstAlumno.Items.Clear()
            lstGrupo.Items.Clear()
            datagCalificaciones.Rows.Clear()

            Dim consulta As String
            consulta = " SELECT Grupo.Id_Grupo
                        FROM (Grupo INNER JOIN Alumno ON Grupo.MatriculaAlumno = Alumno.Matricula) INNER JOIN Carrera ON Alumno.Carrera = Carrera.Id_Carrera
                        WHERE (((Carrera.Id_Carrera)=@IDCarrera))
                            GROUP BY Grupo.Id_Grupo;

                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = lstCarrera.Text

                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        lstGrupo.Items.Clear()
                        Do While dtrReader.Read()

                            lstGrupo.Items.Add(dtrReader("ID_Grupo"))
                        Loop

                    Else

                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try
    End Sub

    Private Sub lstGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrupo.SelectedIndexChanged
        Try

            lstAlumno.Items.Clear()
            datagCalificaciones.Rows.Clear()

            Dim consulta As String
            consulta = " SELECT Alumno.Matricula, Alumno.Nombre, Alumno.ApellidoP, Alumno.ApellidoM
                        FROM (((Grupo INNER JOIN Alumno ON Grupo.MatriculaAlumno = Alumno.Matricula) INNER JOIN (Carrera INNER JOIN carrera_materia ON Carrera.Id_Carrera = carrera_materia.id_carrera) ON Alumno.Carrera = carrera_materia.id_carrera) INNER JOIN Materia ON carrera_materia.id_materia = Materia.Id_Materia) INNER JOIN alumno_materia ON (Grupo.MatriculaAlumno = alumno_materia.matricula) AND (Grupo.Id_Grupo = alumno_materia.Grupo)
                        
                        GROUP BY Alumno.Matricula, Alumno.Nombre, Alumno.ApellidoP, Alumno.ApellidoM
                              "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = lstCarrera.Text
                    cmdSelect.Parameters.Add("@IDGrupo", OleDbType.Char)
                    cmdSelect.Parameters("@IDGrupo").Value = lstGrupo.Text

                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        lstAlumno.Items.Clear()
                        Do While dtrReader.Read()

                            lstAlumno.Items.Add(dtrReader("Matricula") & "|" & dtrReader("Nombre") & " " & dtrReader("ApellidoP") & " " & dtrReader("ApellidoM"))
                        Loop



                    Else


                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try
    End Sub

    Private Sub lstAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlumno.SelectedIndexChanged
        Try

            datagCalificaciones.Rows.Clear()
            Dim consulta As String
            consulta = " SELECT Grupo.Id_Grupo, Carrera.Nombre AS NombreCarrera, alumno_materia.matricula, materia.id_materia, Materia.Nombre, alumno_materia.calificacion
                            FROM (((Grupo INNER JOIN Alumno ON Grupo.MatriculaAlumno = Alumno.Matricula) INNER JOIN (Carrera INNER JOIN carrera_materia ON Carrera.Id_Carrera = carrera_materia.id_carrera) ON Alumno.Carrera = carrera_materia.id_carrera) INNER JOIN Materia ON carrera_materia.id_materia = Materia.Id_Materia) INNER JOIN alumno_materia ON (Grupo.Id_Grupo = alumno_materia.Grupo) AND (Grupo.MatriculaAlumno = alumno_materia.matricula)

                              "
            '            WHERE(((alumno_materia.matricula) =@IDMatricula) And ((alumno_materia.Grupo)=@IDGrupo) And ((carrera_materia.id_carrera)=@IDCarrera));

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDCarrera", OleDbType.Char)
                    cmdSelect.Parameters("@IDCarrera").Value = lstCarrera.Text
                    cmdSelect.Parameters.Add("@IDGrupo", OleDbType.Char)
                    cmdSelect.Parameters("@IDGrupo").Value = lstGrupo.Text
                    cmdSelect.Parameters.Add("@IDMatricula", OleDbType.Char)
                    cmdSelect.Parameters("@IDMatricula").Value = Mid(lstAlumno.Text, 1, InStr(lstAlumno.Text, "|") - 1)

                    Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                    If dtrReader.HasRows Then

                        datagCalificaciones.Rows.Clear()

                        Do While dtrReader.Read()
                            Dim row As String() = New String() {dtrReader("Id_Materia"), dtrReader("Nombre"), dtrReader("Calificacion")}
                            datagCalificaciones.Rows.Add(row)
                        Loop



                    Else


                    End If

                End Using


            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try
    End Sub

End Class