Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging
Public Class Subir_Horarios
    Private Sub Subir_Horarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
        con.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")
        con.Open()
        Dim cm As New OleDbCommand

        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = DialogResult.OK Then
            picBlob.Image = Image.FromFile(dialog.FileName)
        End If
        con.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim con As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sistema.mdb")

        MsgBox("Horario Guardado.")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGrupo.Click

    End Sub
End Class