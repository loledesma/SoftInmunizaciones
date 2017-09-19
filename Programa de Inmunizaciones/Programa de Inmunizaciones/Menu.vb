Imports System.Data
Imports System.Data.SqlClient
Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verifCumple()
    End Sub

    Private Sub verifCumple()
        Dim tabla = New DataTable
        Dim sql = ""

        sql = "select E.nombres, E.apellidos, E.nro_doc, E.mail_contacto from EMPLEADOS E where day(E.fecha_nac) = " & Date.Today.Day & " AND month (E.fecha_nac) = " & Date.Today.Month

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() <> 0 Then
            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count() - 1

                Dialog1.DataGridView1.Rows.Add()
                Dialog1.DataGridView1.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
                Dialog1.DataGridView1.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")

                Dialog1.DataGridView1.Rows(c).Cells("mail_contacto").Value = tabla.Rows(c)("mail_contacto")

                Dialog1.DataGridView1.Rows(c).Cells("enviarCorreo").Value = True
                Dialog1.DataGridView1.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")
                enviarCorreo(tabla.Rows(c)("mail_contacto"))
            Next
            Dialog1.ShowDialog()

        End If
    End Sub
    Private Sub GestiónDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeEmpleadosToolStripMenuItem.Click
        abm_empleados.ShowDialog()
    End Sub

    Private Sub EfectoresPorDptoYLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorDptoYLocalidadToolStripMenuItem.Click
        listados_efector_loc_dpto.ShowDialog()
    End Sub

    Private Sub NotificacionesPorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        listados_notificaciones.ShowDialog()
    End Sub

    Private Sub NuevaNotificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
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


    Private Sub NuevaAtenciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub LocalidadesPorDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesPorDepartamentosToolStripMenuItem.Click
        listado_localidadesxdpto.ShowDialog()
    End Sub

    Private Sub EfectoresPorReferenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorReferenteToolStripMenuItem.Click
        listados_efector_x_refe.ShowDialog()
    End Sub

    Private Sub EfectoresPorEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorEstadoToolStripMenuItem.Click
        list_efectores_x_estado.ShowDialog()
    End Sub

    Private Sub ReferentesRegistradosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReferentesRegistradosToolStripMenuItem.Click
        listados_referentes_y_efectores.ShowDialog()
    End Sub


    Private Sub RegistrarPeticionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_peticiones_desarrollos.ShowDialog()
    End Sub

    Private Sub VacunatoriosImplementadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosImplementadosToolStripMenuItem.Click
        est_efectores_implementados.ShowDialog()
    End Sub

    'Private Sub StockDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    abm_stock_insumos.ShowDialog()
    'End Sub

    Private Sub RegistrarEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEntregaToolStripMenuItem.Click
        Registrar_entrega_insumos.ShowDialog()
    End Sub

    Private Sub EstadoDeHeladerasPorEfectorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        list_heladeras_antiguas.ShowDialog()
    End Sub

    Private Sub EmpleadosPorCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorCursoToolStripMenuItem.Click
        est_empleados_con_y_sin_curso.ShowDialog()
    End Sub

    Private Sub VacunatoriosSegúnHeladeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosSegúnHeladeraToolStripMenuItem.Click
        est_ef_con_y_sin_heladera.ShowDialog()
    End Sub

    Private Sub EstadoDeHeladerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeHeladerasToolStripMenuItem.Click
        est_estado_heladeras.ShowDialog()
    End Sub

    Private Sub EmisiónDeResumenDesdeSigipsaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmisiónDeResumenDesdeSigipsaToolStripMenuItem.Click
        est_efect_emiten_sigipsa.ShowDialog()
    End Sub

    Private Sub menu_programa_inmunizaciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menu_programa_inmunizaciones.ItemClicked

    End Sub

    Private Sub NuevoRecordatorioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_recordatorio.ShowDialog()
    End Sub

    Private Sub NuevaNotificaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaNotificaciónToolStripMenuItem1.Click
        Registrar_notificaciones.ShowDialog()
    End Sub

    Private Sub NotificacionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesRegistradasToolStripMenuItem.Click
        listados_notificaciones.ShowDialog()
    End Sub

    Private Sub NuevaAtencónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaAtencónToolStripMenuItem.Click
        Registrar_atencion.ShowDialog()
    End Sub

    Private Sub RegistrarNvaPeticiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNvaPeticiónToolStripMenuItem.Click
        Registrar_peticiones_desarrollos.ShowDialog()
    End Sub

    Private Sub EfectoresPorEmisiónDeResumenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorEmisiónDeResumenToolStripMenuItem.Click
        list_efectores_emiten_resumen.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Registrar_ingreso_stock.ShowDialog()
    End Sub

    Private Sub RegistrarNuevaCapacitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevaCapacitaciónToolStripMenuItem.Click
        Registrar_capacitaciones.ShowDialog()
    End Sub

    Private Sub EfectoresQueNoNotificanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresQueNoNotificanToolStripMenuItem.Click
        list_no_notifican.ShowDialog()
    End Sub

    Private Sub EfectoresConInternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresConInternetToolStripMenuItem.Click
        list_efect_internet.ShowDialog()
    End Sub

    Private Sub InventarioDeCadenaDeFrioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InventarioDeCadenaDeFrioToolStripMenuItem.Click
        Inventario_cadena_de_frio.ShowDialog()
    End Sub

    Private Sub PedidosDeDesarrolloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosDeDesarrolloToolStripMenuItem.Click
        list_pedidos_desarrollo.ShowDialog()
    End Sub

    Private Sub CapacitacionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapacitacionesRegistradasToolStripMenuItem.Click
        list_capacitaciones.ShowDialog()
    End Sub

    Private Sub AtencionesRegistradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtencionesRegistradasToolStripMenuItem1.Click
        list_atenciones.ShowDialog()
    End Sub

    Private Sub EntregasRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasRealizadasToolStripMenuItem.Click
        list_entregas.ShowDialog()
    End Sub

    Private Sub RegistrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInventarioToolStripMenuItem.Click
        Inventario_cadena_de_frio.ShowDialog()
    End Sub

    Private Sub InventariosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariosRegistradosToolStripMenuItem.Click
        list_inventario.ShowDialog()
    End Sub

    Private Sub RegistrarRecordatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarRecordatorioToolStripMenuItem.Click
        Registrar_recordatorio.ShowDialog()
    End Sub
    Private Sub EmpleadosPorEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorEstadoToolStripMenuItem.Click
        list_empleados_x_estado.ShowDialog()
    End Sub


    Private Sub VacunatoriosPorLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosPorLocalidadToolStripMenuItem.Click
        Est_Efect_x_Loc.ShowDialog()
    End Sub

    Private Sub GestionarInvitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarInvitacionesToolStripMenuItem.Click
        Registrar_invitaciones.ShowDialog()
    End Sub

    Private Sub GestionarActividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarActividadesToolStripMenuItem.Click
        Registrar_Actividades.ShowDialog()
    End Sub
End Class