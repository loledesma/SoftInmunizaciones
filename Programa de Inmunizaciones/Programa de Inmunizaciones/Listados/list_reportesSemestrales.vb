Public Class list_reportesSemestrales

    Private Sub list_reportesSemestrales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim tabla As New DataTable

        sql = " SELECT E.nombre as nombre_efector, E.cuie, ENR.descripcion AS estado_notificacion, EIC.descripcion AS estado_carga, EIP.descripcion AS estado_perdidas, EIS.descripcion AS estado_stock, "
        sql &= " TN.descripcion as notifica_cada, ERM.descripcion as estado_resumen_mensual  "
        sql &= " FROM DETALLE_REPORTE DR JOIN EFECTORES E on E.cuie = DR.cuie "
        sql &= " JOIN ESTADO_NOTIF_REPORTES ENR on ENR.id = DR.id_estado_notif"
        sql &= " JOIN ESTADO_INDICADORES EIC on EIC.id = DR.id_reporte_carga "
        sql &= " JOIN ESTADO_INDICADORES EIP ON EIP.id = DR.id_reporte_perdidas "
        sql &= " JOIN ESTADO_INDICADORES EIS ON EIS.id = DR.id_reporte_stock "
        sql &= " JOIN TIPO_NOTIFICACION TN ON TN.id = DR.id_tiempo_notif JOIN ESTADO_RM ERM ON ERM.id = DR.id_estado_rm "
        sql &= " WHERE DR.id_reporte = 6"



        tabla = acceso.consulta(sql)
        Me.LIST_REPORTESBindingSource.DataSource = tabla

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class