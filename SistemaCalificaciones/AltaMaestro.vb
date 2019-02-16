Imports System.Data
Imports System.Data.OleDb


Public Class AltaMaestro


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMatricula.Click

    End Sub

    Private Sub AltaMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Desactivar_Captura()


    End Sub


    Private Sub Activar_Captura()
        txtMatricula.Enabled = False
        txtMatricula.BackColor = Color.LightSlateGray
        txtNombre.Enabled = True
        txtNombre.BackColor = Color.White
        txtPaterno.Enabled = True
        txtPaterno.BackColor = Color.White
        txtMaterno.Enabled = True
        txtMaterno.BackColor = Color.White
        txtContra.Enabled = True
        txtContra.BackColor = Color.White
        txtConfirmar.Enabled = True
        txtConfirmar.BackColor = Color.White
        cmdGuardar.Enabled = True
        cmdBorrar.Enabled = True
        cmdCancelar.Enabled = True
        'cmdBorrar.Visible = False
        cmdBuscar.Enabled = False
        txtNombre.Focus()

    End Sub
    Private Sub Desactivar_Captura()
        txtMatricula.Enabled = True
        txtMatricula.BackColor = Color.White
        txtNombre.Enabled = False
        txtNombre.BackColor = Color.LightSlateGray
        txtPaterno.Enabled = False
        txtPaterno.BackColor = Color.LightSlateGray
        txtMaterno.Enabled = False
        txtMaterno.BackColor = Color.LightSlateGray
        txtContra.Enabled = False
        txtContra.BackColor = Color.LightSlateGray
        txtConfirmar.Enabled = False
        txtConfirmar.BackColor = Color.LightSlateGray
        cmdGuardar.Enabled = False
        cmdBorrar.Enabled = False
        'cmdBorrar.Visible = False
        cmdCancelar.Enabled = False
        cmdBuscar.Enabled = True
        txtMatricula.Focus()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatricula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cmdBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click


        cmdBorrar.Visible = False
        Dim consulta As String
        consulta = "
                        Select m.*
                        From Maestro as m
                        WHERE m.Matricula = @IDMatricula 
                    "

        Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
            con.Open()

            Using cmdSelect As New OleDbCommand(consulta, con)
                cmdSelect.Parameters.Add("@IDMatricula", OleDbType.Char)
                cmdSelect.Parameters("@IDMatricula").Value = txtMatricula.Text
                Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                If dtrReader.HasRows Then
                    If dtrReader.Read() Then

                        txtNombre.Text = dtrReader("Nombre")
                        txtPaterno.Text = dtrReader("ApellidoP")
                        txtMaterno.Text = dtrReader("ApellidoM")
                        txtContra.Text = dtrReader("Contrasena")
                        'txtConfirmar.Text = dtrReader("ConfirmarContra")

                        cmdBorrar.Visible = True
                        'Dim strToHash As String = psw.Text

                    Else

                    End If
                Else
                    Dim Seleccion As Integer = MsgBox("Matricula no encontrada , deseas dar de alta...?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                    If Seleccion = vbYes Then
                        txtNombre.Text = ""
                        txtPaterno.Text = ""
                        txtMaterno.Text = ""
                        txtConfirmar.Text = ""
                        txtContra.Text = ""
                    End If
                End If
            End Using
        End Using


        Call Activar_Captura()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdBorrar.Visible = False
        Call Desactivar_Captura()
    End Sub

    Private Sub AltaMaestro_Activated(sender As Object, e As EventArgs) Handles Me.Activated


    End Sub

    Private Sub txtPaterno_TextChanged(sender As Object, e As EventArgs) Handles txtPaterno.TextChanged

    End Sub

    Private Sub txtPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaterno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMaterno_TextChanged(sender As Object, e As EventArgs) Handles txtMaterno.TextChanged

    End Sub

    Private Sub txtMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaterno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus

    End Sub

    Private Sub txtPaterno_GotFocus(sender As Object, e As EventArgs) Handles txtPaterno.GotFocus
        txtPaterno.SelectionStart = 0
        txtPaterno.SelectionLength = Len(txtPaterno.Text)
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Try
            If txtContra.Text <> txtConfirmar.Text Then
                MsgBox("Contraseñas no coinciden", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim consulta As String
            consulta = "    Delete  
                        From Maestro as m
                        WHERE m.Matricula = @IDMatricula 
                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDMatricula", OleDbType.Char)
                    cmdSelect.Parameters("@IDMatricula").Value = txtMatricula.Text
                    Dim dtrReader As Integer = cmdSelect.ExecuteNonQuery

                    'If dtrReader > 0 Then
                    Dim consultaAdd As String
                    consultaAdd = "    INSERT INTO Maestro (Matricula,Nombre,ApellidoP,ApellidoM,Contrasena) 
                            Select @IDMatricula AS Matricula, @IDNombre As Nombre, @IDApellidoP As ApellidoP, @IDApellidoM  As ApellidoM, @IDContrasena As Contrasena
                        "
                    Using conins As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                        conins.Open()

                        Using cmdInsert As New OleDbCommand(consultaAdd, conins)
                            cmdInsert.Parameters.Add("@IDMatricula", OleDbType.Char)
                            cmdInsert.Parameters.Add("@IDNombre", OleDbType.Char)
                            cmdInsert.Parameters.Add("@IDApellidoP", OleDbType.Char)
                            cmdInsert.Parameters.Add("@IDApellidoM", OleDbType.Char)
                            cmdInsert.Parameters.Add("@IDContrasena", OleDbType.Char)


                            'Dim strToHash As String = txtContra.Text
                            'Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
                            'Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
                            'bytesToHash = sha1Obj.ComputeHash(bytesToHash)
                            'Dim strResult As String = ""
                            'For Each b As Byte In bytesToHash
                            '    strResult += b.ToString("x2")
                            'Next

                            cmdInsert.Parameters("@IDMatricula").Value = txtMatricula.Text
                            cmdInsert.Parameters("@IDNombre").Value = txtNombre.Text
                            cmdInsert.Parameters("@IDApellidoP").Value = txtPaterno.Text
                            cmdInsert.Parameters("@IDApellidoM").Value = txtMaterno.Text
                            cmdInsert.Parameters("@IDContrasena").Value = txtContra.Text

                            Dim dtrInsert As Integer = cmdInsert.ExecuteNonQuery

                            If dtrInsert <= 0 Then
                                MsgBox("No se pudo actualizar registro volver a intentar")
                                Exit Sub
                            End If

                        End Using

                    End Using
                    Dim actualizausuario As Boolean = Añade_usuario(txtMatricula.Text, txtContra.Text, "T")
                    If actualizausuario = False Then
                        MsgBox("No se pudo actualizar registro volver a intentar")
                        Exit Sub
                    End If

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

        MsgBox("Registro Actualizado")
        Call Desactivar_Captura()

    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Dim Seleccion As Integer = MsgBox("Deseas Eliminar Registro...?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If Seleccion = vbNo Then
            Exit Sub
        End If
        cmdBorrar.Visible = False
        Try

            Dim consulta As String
            consulta = "    Delete  
                        From Maestro as m
                        WHERE m.Matricula = @IDMatricula 
                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDMatricula", OleDbType.Char)
                    cmdSelect.Parameters("@IDMatricula").Value = txtMatricula.Text
                    Dim dtrReader As Integer = cmdSelect.ExecuteNonQuery

                    If dtrReader > 0 Then

                    Else

                        MsgBox("No se pudo actualizar registro volver a intentar")
                        Exit Sub


                    End If

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error no identificado con No. " + Err.Number.ToString + " con mensaje " + ErrorToString.ToString)
            Exit Sub

        End Try

        MsgBox("Registro Eliminado")
        Call Desactivar_Captura()

    End Sub
    Private Function Añade_usuario(Usuario As String, contraseña As String, tipousuario As String) As Boolean

        Try


            Dim consulta As String
            consulta = "    Delete  
                        From usuario as u
                        WHERE u.usuario = @IDUsuario 
                    "

            Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                con.Open()

                Using cmdSelect As New OleDbCommand(consulta, con)
                    cmdSelect.Parameters.Add("@IDUsuario", OleDbType.Char)
                    cmdSelect.Parameters("@IDUsuario").Value = Usuario
                    Dim dtrReader As Integer = cmdSelect.ExecuteNonQuery
                End Using

            End Using


            Dim consultaAdd As String
            consultaAdd = "     INSERT INTO usuario (usuario,contraseña,Tipo) 
                            Select @IDUsuario As usuario, @IDContraseña As contraseña, @IDTipo As Tipo

                        "

            Using conins As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
                conins.Open()

                Using cmdInsert As New OleDbCommand(consultaAdd, conins)
                    cmdInsert.Parameters.Add("@IDUsuario", OleDbType.Char)
                    cmdInsert.Parameters.Add("@IDContraseña", OleDbType.Char)
                    cmdInsert.Parameters.Add("@IDTipo", OleDbType.Char)


                    cmdInsert.Parameters("@IDUsuario").Value = Usuario
                    cmdInsert.Parameters("@IDContraseña").Value = contraseña
                    cmdInsert.Parameters("@IDTipo").Value = tipousuario


                    Dim dtrInsert As Integer = cmdInsert.ExecuteNonQuery

                    If dtrInsert <= 0 Then
                        Return False
                    End If

                End Using

            End Using


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Sub lblConfirmarC_Click(sender As Object, e As EventArgs) Handles lblConfirmarC.Click

    End Sub
End Class


