Imports System.Windows.Forms

Public Class Menú

    Private Sub mnu_AltaMaestro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_AltaMaestro.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        Dim altamaestros As New AltaMaestro
        altamaestros.MdiParent = Me
        altamaestros.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_AltaAlumno.Click, OpenToolStripButton.Click
        Dim altaalumnos As New AltaAlumno
        altaalumnos.MdiParent = Me
        altaalumnos.Show()

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Login As New LoginForm1
        Login.Show()
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        mnu_AltaDeRasgosAEvaluar.Visible = False
        mnuConsultaDeHorarios.Visible = False



        If UCase(TipoUsuario) = "S" Then
            mnu_AltaAlumno.Visible = False
            mnu_AltaCarreras.Visible = False
            mnu_AltaMaestro.Visible = False
            mnuSubirCalificaciones.Visible = False
            mnuConsultaDeHorarios.Visible = True
            mnuSubirHorarios.Visible = False
            mnu_AltaDeRasgosAEvaluar.Visible = False



            Separador2.Visible = False
        ElseIf UCase(TipoUsuario) = "T" Then

            mnuConsultaCalificaciones.Visible = False
            mnu_AltaCarreras.Visible = False
            mnu_AltaMaestro.Visible = False
            mnuSubirHorarios.Visible = False
            mnu_AltaDeRasgosAEvaluar.Visible = False
            mnuConsultaDeHorarios.Visible = False

        End If
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub mnuConsultaCalificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConsultaCalificaciones.Click
        Dim Consultar As New ConsultaCalificaciones
        Consultar.MdiParent = Me
        Consultar.Show()
    End Sub

    Private Sub mnu_AltaCarreras_Click(sender As Object, e As EventArgs) Handles mnu_AltaCarreras.Click
        Dim altaCarrera As New AltaCarrera
        altaCarrera.MdiParent = Me
        altaCarrera.Show()

    End Sub

    Private Sub mnuAltaMaterias_Click(sender As Object, e As EventArgs)
        Dim altaMateria As New AltaMateria
        altaMateria.MdiParent = Me
        altaMateria.Show()
    End Sub

    Private Sub mnuSubirCalificaciones_Click(sender As Object, e As EventArgs) Handles mnuSubirCalificaciones.Click
        Dim subircali As New Subir_Calificaciones
        Subir_Calificaciones.MdiParent = Me
        Subir_Calificaciones.Show()
    End Sub

    Private Sub mnuSubirHorarios_Click(sender As Object, e As EventArgs) Handles mnuSubirHorarios.Click
        Dim subirHorario As New Subir_Horarios
        Subir_Horarios.MdiParent = Me
        Subir_Horarios.Show()
    End Sub

    Private Sub mnuConsultaDeHorarios_Click(sender As Object, e As EventArgs) Handles mnuConsultaDeHorarios.Click
        Dim consulta As New ConsultarHorarios

        ConsultarHorarios.MdiParent = Me
        ConsultarHorarios.Show()
    End Sub
End Class
