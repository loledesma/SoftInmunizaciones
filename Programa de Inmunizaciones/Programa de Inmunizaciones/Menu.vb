Public Class Menu

    Private Sub GestiónDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeEmpleadosToolStripMenuItem.Click
        abm_empleados.ShowDialog()
    End Sub

    Private Sub EfectoresPorDptoYLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorDptoYLocalidadToolStripMenuItem.Click
        listados_efector_loc_dpto.ShowDialog()
    End Sub

    Private Sub NotificacionesPorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesPorToolStripMenuItem.Click
        listados_notificaciones.ShowDialog()
    End Sub

    Private Sub NuevaNotificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaNotificaciónToolStripMenuItem.Click
        Registrar_notificaciones.ShowDialog()
    End Sub

    Private Sub GestiónDeLocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeLocalidadesToolStripMenuItem.Click
        abm_localidades.ShowDialog()
    End Sub

    Private Sub GestiónDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeDepartamentosToolStripMenuItem.Click
        abm_departamentos.ShowDialog()
    End Sub

    Private Sub GestiónDeBarriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeBarriosToolStripMenuItem.Click
        abm_barrios.ShowDialog()
    End Sub

    Private Sub GestiónDeVacunatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeVacunatoriosToolStripMenuItem.Click
        Registrar_efectores.ShowDialog()
    End Sub


    Private Sub NuevaAtenciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaAtenciónToolStripMenuItem.Click
        Registrar_atencion.ShowDialog()
    End Sub

    Private Sub ReferentesRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        listados_referentes_y_efectores.ShowDialog()
    End Sub
    Private Sub AtencionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        list_atenciones.ShowDialog()
    End Sub
    Private Sub UsuariosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosRegistradosToolStripMenuItem.Click
        list_usuarios.ShowDialog()
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LocalidadesPorDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesPorDepartamentosToolStripMenuItem.Click
        listado_localidadesxdpto.Show()
    End Sub

    Private Sub EfectoresPorReferenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorReferenteToolStripMenuItem.Click

    End Sub

    Private Sub EfectoresPorEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorEstadoToolStripMenuItem.Click
        list_efectores_x_estado.ShowDialog()
    End Sub

    Private Sub ReferentesRegistradosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReferentesRegistradosToolStripMenuItem.Click
        listados_referentes_y_efectores.ShowDialog()
    End Sub

    Private Sub RegistrarRecordatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarRecordatorioToolStripMenuItem.Click
        Registrar_recordatorio.ShowDialog()
    End Sub

    Private Sub RegistrarPeticionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPeticionesToolStripMenuItem.Click
        Registrar_peticiones_desarrollos.ShowDialog()
    End Sub
End Class