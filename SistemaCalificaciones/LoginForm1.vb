Imports System.Data
Imports System.Data.OleDb

Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim consulta As String
        consulta = "
                        Select u.*
                        From usuario as u
                        WHERE u.usuario = @IDUsuario 
                    "

        Using con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
            con.Open()

            Using cmdSelect As New System.Data.OleDb.OleDbCommand(consulta, con)
                cmdSelect.Parameters.Add("@IDUsuario", OleDbType.Char)
                cmdSelect.Parameters("@IDUsuario").Value = UsernameTextBox.Text
                Dim dtrReader As OleDbDataReader = cmdSelect.ExecuteReader()

                If dtrReader.HasRows Then
                    If dtrReader.Read() Then

                        If UCase(dtrReader("contraseña")) = UCase(PasswordTextBox.Text) Then
                            TipoUsuario = dtrReader("Tipo")
                            Dim formMain As New Menú
                            formMain.Show()
                            Me.Close()
                        Else
                            MsgBox("Contraseña no es correcta", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Usuario no Encontrado", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Usuario no Encontrado", MsgBoxStyle.Critical)
                End If
            End Using
        End Using


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
