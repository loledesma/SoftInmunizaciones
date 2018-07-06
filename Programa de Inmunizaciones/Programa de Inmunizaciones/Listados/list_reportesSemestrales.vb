Public Class list_reportesSemestrales

    Private Sub list_reportesSemestrales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acceso.autocompletar(txt_centro_responsable, "EFECTORES", "nombre")
        acceso.autocompletar(txt_vacunatorio_particular, "EFECTORES", "nombre")
        cmb_años.cargar()
        cmb_semestres.cargar()
        cmb_años.SelectedIndex() = -1
        cmb_semestres.SelectedIndex() = -1
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub

    Private Sub tip()

    End Sub
    Private Sub cmd_generar_repo_Click(sender As Object, e As EventArgs) Handles cmd_generar_repo.Click
        Dim sql As String
        Dim tabla As New DataTable

        sql = " SELECT E.nombre as nombre_efector, E.cuie, ENR.descripcion AS estado_notificacion, EIC.descripcion AS estado_carga, EIP.descripcion AS estado_perdidas, EIS.descripcion AS estado_stock, "
        sql &= " TN.descripcion as notifica_cada, ERM.descripcion as estado_resumen_mensual, DR.observaciones"
        sql &= " FROM DETALLE_REPORTE DR JOIN EFECTORES E on E.cuie = DR.cuie "
        sql &= " JOIN ESTADO_NOTIF_REPORTES ENR on ENR.id = DR.id_estado_notif"
        sql &= " JOIN ESTADO_INDICADORES EIC on EIC.id = DR.id_reporte_carga "
        sql &= " JOIN ESTADO_INDICADORES EIP ON EIP.id = DR.id_reporte_perdidas "
        sql &= " JOIN ESTADO_INDICADORES EIS ON EIS.id = DR.id_reporte_stock "
        sql &= " JOIN TIPO_NOTIFICACION TN ON TN.id = DR.id_tiempo_notif JOIN ESTADO_RM ERM ON ERM.id = DR.id_estado_rm JOIN REPORTES R on R.id = DR.id_reporte"
        sql &= " WHERE R.responsable = '" & Me.txt_cuie_responsable.Text & "' AND R.año = " & Me.cmb_años.Text & " AND R.id_semestre = " & Me.cmb_semestres.SelectedValue

        tabla = acceso.consulta(sql)
        Me.LIST_REPORTESBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_centro_responsable_Leave(sender As Object, e As EventArgs)
        Dim tabla As New DataTable
        Dim sql As String = ""

        If txt_centro_responsable.Text <> "" Then
            sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
            sql &= " WHERE E.nombre like '%" & Me.txt_centro_responsable.Text & "%'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_cuie_responsable.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub
    Private Sub txt_vacunatorio_particular_Leave(sender As Object, e As EventArgs)
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_cuie_particular.Text <> "" Then
            sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
            sql &= " WHERE E.nombre like '%" & Me.txt_cuie_particular.Text & "%'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_cuie_particular.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub
    Private Sub txt_cuie_responsable_Leave(sender As Object, e As EventArgs) Handles txt_cuie_responsable.Leave
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_cuie_responsable.Text <> "" Then
            sql &= "SELECT E.nombre as nombre FROM EFECTORES E"
            sql &= " WHERE E.cuie='" & txt_cuie_responsable.Text & "'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_centro_responsable.Text = tabla.Rows(0)("nombre")
            End If
        End If
    End Sub

   

    Private Sub txt_cuie_particular_Leave(sender As Object, e As EventArgs) Handles txt_cuie_particular.Leave
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_cuie_particular.Text <> "" Then
            sql &= "SELECT E.nombre as nombre FROM EFECTORES E"
            sql &= " WHERE E.cuie='" & txt_cuie_particular.Text & "'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_vacunatorio_particular.Text = tabla.Rows(0)("nombre")
            End If
        End If
    End Sub

    Private Sub cmd_buscar_centro_partic_Click(sender As Object, e As EventArgs) Handles cmd_buscar_centro_partic.Click
        Dim sql As String
        Dim tabla As New DataTable

        sql = " SELECT E.nombre as nombre_efector, E.cuie, ENR.descripcion AS estado_notificacion, EIC.descripcion AS estado_carga, EIP.descripcion AS estado_perdidas, EIS.descripcion AS estado_stock, "
        sql &= " TN.descripcion as notifica_cada, ERM.descripcion as estado_resumen_mensual, DR.observaciones"
        sql &= " FROM DETALLE_REPORTE DR JOIN EFECTORES E on E.cuie = DR.cuie "
        sql &= " JOIN ESTADO_NOTIF_REPORTES ENR on ENR.id = DR.id_estado_notif"
        sql &= " JOIN ESTADO_INDICADORES EIC on EIC.id = DR.id_reporte_carga "
        sql &= " JOIN ESTADO_INDICADORES EIP ON EIP.id = DR.id_reporte_perdidas "
        sql &= " JOIN ESTADO_INDICADORES EIS ON EIS.id = DR.id_reporte_stock "
        sql &= " JOIN TIPO_NOTIFICACION TN ON TN.id = DR.id_tiempo_notif JOIN ESTADO_RM ERM ON ERM.id = DR.id_estado_rm JOIN REPORTES R on R.id = DR.id_reporte"
        sql &= " WHERE DR.cuie= '" & Me.txt_cuie_particular.Text & "' AND R.año = " & Me.cmb_años.Text & " AND R.id_semestre = " & Me.cmb_semestres.SelectedValue

        tabla = acceso.consulta(sql)
        Me.LIST_REPORTESBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_centro_responsable_Enter(sender As Object, e As EventArgs) Handles txt_centro_responsable.Enter
        If txt_centro_responsable.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            Dim empleados As String = ""
            Dim tabla2 As New DataTable

            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_centro_responsable.Text & "%'"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            tltp_reportes.SetToolTip(txt_centro_responsable, efectores)

        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_vacunatorio_particular_Enter(sender As Object, e As EventArgs) Handles txt_vacunatorio_particular.Enter
        If txt_vacunatorio_particular.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            Dim empleados As String = ""
            Dim tabla2 As New DataTable

            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_vacunatorio_particular.Text & "%'"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            tltp_reportes.SetToolTip(txt_vacunatorio_particular, efectores)

        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_centro_responsable_Leave_1(sender As Object, e As EventArgs) Handles txt_centro_responsable.Leave
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_centro_responsable.Text <> "" Then
            sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
            sql &= " WHERE E.nombre like '%" & txt_centro_responsable.Text & "%'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_cuie_responsable.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub

    Private Sub txt_vacunatorio_particular_Leave_1(sender As Object, e As EventArgs) Handles txt_vacunatorio_particular.Leave
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_vacunatorio_particular.Text <> "" Then
            sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
            sql &= " WHERE E.nombre like '%" & txt_vacunatorio_particular.Text & "%'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                txt_cuie_particular.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub
End Class