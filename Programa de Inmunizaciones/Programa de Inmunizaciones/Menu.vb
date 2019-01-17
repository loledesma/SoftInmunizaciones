Imports System.Data
Imports System.Data.SqlClient

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Inicio_sesion.ShowDialog()
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            verifCumple()
            back_up.ShowDialog()
            If Ajustes_Pendientes.verificar() = True Then
                Ajustes_Pendientes.ShowDialog()
            Else
                Exit Sub
            End If
        End If
    End Sub


    Private Sub verifCumple()
        Dim tabla = New DataTable
        Dim sql = ""

        sql = "select distinct E.nombres, E.apellidos, E.nro_doc, E.mail_contacto from EMPLEADOS E JOIN EMPLEADOSXEFECTOR EE ON E.id = EE.id_empleados "
        sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie "
        sql &= " where Day(E.fecha_nac) = " & Date.Today.Day & " And Month(E.fecha_nac) = " & Date.Today.Month
        sql &= " AND EE.id_estado_empleado != 4 "
        sql &= " AND EF.id_estado = 3"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() <> 0 Then
            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count() - 1

                Dialog1.dgv_cumples.Rows.Add()
                Dialog1.dgv_cumples.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
                Dialog1.dgv_cumples.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")
                Dialog1.dgv_cumples.Rows(c).Cells("mail_contacto").Value = tabla.Rows(c)("mail_contacto")
                Dialog1.dgv_cumples.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")

            Next
            Dialog1.ShowDialog()
        End If

    End Sub
    Private Sub GestiónDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeEmpleadosToolStripMenuItem.Click
        abm_empleados.Show()
    End Sub

    Private Sub EfectoresPorDptoYLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorDptoYLocalidadToolStripMenuItem.Click
        listados_efector_loc_dpto.Show()
    End Sub

    Private Sub NotificacionesPorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        listados_notificaciones.Show()
    End Sub

    Private Sub NuevaNotificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_notificaciones.Show()
    End Sub

    Private Sub GestiónDeLocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeLocalidadesToolStripMenuItem.Click
        abm_localidades.Show()
    End Sub

    Private Sub GestiónDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeDepartamentosToolStripMenuItem.Click
        abm_departamentos.Show()
    End Sub

    Private Sub GestiónDeBarriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeBarriosToolStripMenuItem.Click
        abm_barrios.Show()
    End Sub

    Private Sub GestiónDeVacunatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeVacunatoriosToolStripMenuItem.Click
        Registrar_efectores.Show()
    End Sub


    Private Sub NuevaAtenciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_atencion.Show()
    End Sub

    Private Sub ReferentesRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        listados_referentes_y_efectores.Show()
    End Sub
    Private Sub AtencionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        list_atenciones.Show()
    End Sub
    Private Sub UsuariosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosRegistradosToolStripMenuItem.Click
        list_usuarios.Show()
    End Sub

    Private Sub LocalidadesPorDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesPorDepartamentosToolStripMenuItem.Click
        listado_localidadesxdpto.Show()
    End Sub

    Private Sub EfectoresPorReferenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorReferenteToolStripMenuItem.Click
        listados_efector_x_refe.Show()
    End Sub

    Private Sub EfectoresPorEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorEstadoToolStripMenuItem.Click
        list_efectores_x_estado.Show()
    End Sub

    Private Sub ReferentesRegistradosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReferentesRegistradosToolStripMenuItem.Click
        listados_referentes_y_efectores.Show()
    End Sub


    Private Sub RegistrarPeticionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_peticiones_desarrollos.Show()
    End Sub

    Private Sub VacunatoriosImplementadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosImplementadosToolStripMenuItem.Click
        est_efectores_implementados.Show()
    End Sub

    'Private Sub StockDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    abm_stock_insumos.ShowDialog()
    'End Sub

    Private Sub RegistrarEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEntregaToolStripMenuItem.Click
        Registrar_entrega_insumos.Show()
    End Sub

    Private Sub EstadoDeHeladerasPorEfectorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        list_heladeras_antiguas.Show()
    End Sub

    Private Sub EmpleadosPorCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorCursoToolStripMenuItem.Click
        est_empleados_con_y_sin_curso.Show()
    End Sub

    Private Sub VacunatoriosSegúnHeladeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosSegúnHeladeraToolStripMenuItem.Click
        est_ef_con_y_sin_heladera.Show()
    End Sub

    Private Sub EstadoDeHeladerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeHeladerasToolStripMenuItem.Click
        est_estado_heladeras.Show()
    End Sub

    Private Sub EmisiónDeResumenDesdeSigipsaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmisiónDeResumenDesdeSigipsaToolStripMenuItem.Click
        est_efect_emiten_sigipsa.Show()
    End Sub

    Private Sub menu_programa_inmunizaciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menu_programa_inmunizaciones.ItemClicked

    End Sub

    Private Sub NuevoRecordatorioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Registrar_recordatorio.Show()
    End Sub

    Private Sub NuevaNotificaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaNotificaciónToolStripMenuItem1.Click
        Registrar_notificaciones.Show()
    End Sub

    Private Sub NotificacionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesRegistradasToolStripMenuItem.Click
        listados_notificaciones.Show()
    End Sub

    Private Sub NuevaAtencónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaAtencónToolStripMenuItem.Click
        Registrar_atencion.Show()
    End Sub

    Private Sub RegistrarNvaPeticiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNvaPeticiónToolStripMenuItem.Click
        Registrar_peticiones_desarrollos.Show()
    End Sub

    Private Sub EfectoresPorEmisiónDeResumenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresPorEmisiónDeResumenToolStripMenuItem.Click
        list_efectores_emiten_resumen.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Registrar_ingreso_stock.Show()
    End Sub

    Private Sub RegistrarNuevaCapacitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevaCapacitaciónToolStripMenuItem.Click
        Registrar_capacitaciones.Show()
    End Sub

    Private Sub EfectoresQueNoNotificanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresQueNoNotificanToolStripMenuItem.Click
        list_no_notifican.Show()
    End Sub

    Private Sub EfectoresConInternetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfectoresConInternetToolStripMenuItem.Click
        list_efect_internet.Show()
    End Sub

    Private Sub InventarioDeCadenaDeFrioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InventarioDeCadenaDeFrioToolStripMenuItem.Click
        Inventario_cadena_de_frio.Show()
    End Sub

    Private Sub PedidosDeDesarrolloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosDeDesarrolloToolStripMenuItem.Click
        list_pedidos_desarrollo.Show()
    End Sub

    Private Sub CapacitacionesRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapacitacionesRegistradasToolStripMenuItem.Click
        list_capacitaciones.Show()
    End Sub

    Private Sub AtencionesRegistradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtencionesRegistradasToolStripMenuItem1.Click
        list_atenciones.Show()
    End Sub

    Private Sub EntregasRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasRealizadasToolStripMenuItem.Click
        list_entregas.Show()
    End Sub

    Private Sub RegistrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInventarioToolStripMenuItem.Click
        Inventario_cadena_de_frio.Show()
    End Sub

    Private Sub InventariosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariosRegistradosToolStripMenuItem.Click
        list_inventario.Show()
    End Sub

    Private Sub RegistrarRecordatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarRecordatorioToolStripMenuItem.Click
        Registrar_recordatorio.ShowDialog()
    End Sub
    Private Sub EmpleadosPorEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosPorEstadoToolStripMenuItem.Click
        list_empleados_x_estado.Show()
    End Sub


    Private Sub VacunatoriosPorLocalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacunatoriosPorLocalidadToolStripMenuItem.Click
        Est_Efect_x_Loc.ShowDialog()
    End Sub

    Private Sub GestionarInvitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarInvitacionesToolStripMenuItem.Click
        Registrar_invitaciones.Show()
    End Sub

    Private Sub GestionarActividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarActividadesToolStripMenuItem.Click
        Registrar_Actividades.Show()
    End Sub

    Private Sub CantidadDeEfectoresSegunEstadoDeNotificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeEfectoresSegunEstadoDeNotificacionesToolStripMenuItem.Click
        est_estado_cargaStockPerdidasXDpto.Show()
    End Sub

    Private Sub cmd_enviar_correo_Click(sender As Object, e As EventArgs) Handles cmd_enviar_correo.Click
        Enviar_correo_global.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registrar_notificaciones.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registrar_atencion.Show()
    End Sub

    Private Sub RegistroDeReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeReportesToolStripMenuItem.Click
        Registro_de_reportes.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        list_reportesSemestrales.Show()
    End Sub
End Class