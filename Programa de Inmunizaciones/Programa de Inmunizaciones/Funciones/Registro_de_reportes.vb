Public Class Registro_de_reportes
    Enum condicion
        insertar
        modificar
    End Enum
    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_estado As condicion = condicion.insertar

    Dim condicion_click As doble_Click = doble_Click.desactivado

    Private Sub Regisro_de_reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)
        cmb_año.cargar()
        cmb_año.SelectedIndex() = -1
        cmb_semestre_reporte.cargar()
        cmb_semestre_reporte.SelectedIndex() = -1
        cmb_notificaciones.cargar()
        cmb_notificaciones.SelectedIndex() = -1
        cmb_carga.cargar()
        cmb_carga.SelectedIndex() = -1
        cmb_perdidas.cargar()
        cmb_perdidas.SelectedIndex() = -1
        cmb_stock.cargar()
        cmb_stock.SelectedIndex() = -1
        cmb_emite_resumen.cargar()
        cmb_emite_resumen.SelectedIndex() = -1
        cmb_tiempo_notificacion.cargar()
        cmb_tiempo_notificacion.SelectedIndex() = -1
        acceso.autocompletar(txt_responsable, "EFECTORES", "nombre")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub
    Private Sub txt_responsable_MouseEnter(sender As Object, e As EventArgs)
        If txt_responsable.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            Dim empleados As String = ""
            Dim tabla2 As New DataTable

            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_responsable.Text & "%' AND (EF.id_tipo=2 or EF.id_tipo=3)"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            tltp_reportes.SetToolTip(txt_responsable, efectores)

        Else
            Exit Sub
        End If
    End Sub


    Private Sub limpiar(ByVal de_donde As Object)
        Me.condicion_estado = condicion.insertar
        Dim cmd As ComboBoxV1

        For Each obj As System.Windows.Forms.Control In de_donde
            Select Case obj.GetType.ToString
                Case "System.Windows.Forms.TextBox"
                    obj.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    obj.Text = ""
                Case "Programa_de_Inmunizaciones.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj

    End Sub

 

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lbl_notificoOk.Click

    End Sub

    Private Sub cmd_notificaciones_Click(sender As Object, e As EventArgs) Handles cmd_notificaciones.Click
        Registrar_notificaciones.ShowDialog()
    End Sub

    Private Sub cmd_buscar_añoYsemestre_Click(sender As Object, e As EventArgs) Handles cmd_buscar_añoYsemestre.Click
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        Dim sql As String = ""
        Dim cuie As String = ""
        Dim id As Integer = 0

        If validar_reporte() = True Then
            If txt_responsable.Text <> "" Then
           
                cuie = devolver_cuie_responsable()
                id = devolver_id_reporte()

                Sql = ""
                Sql &= "SELECT E.cuie as cuie, E.nombre as nombre "
                Sql &= " FROM EFECTORES E "
                sql &= " WHERE E.id_referente= '" & cuie & "' AND E.cuie NOT IN "
                sql &= "(SELECT cuie FROM DETALLE_REPORTE WHERE id_reporte= " & id & ")"
                tabla2 = acceso.consulta(Sql)

            End If
        Else
            If txt_responsable.Text <> "" Then
                cuie = devolver_cuie_responsable()

                sql = ""
                sql &= "SELECT E.cuie as cuie, E.nombre as nombre "
                sql &= " FROM EFECTORES E "
                sql &= " WHERE E.id_referente= '" & cuie & "'"
                tabla2 = acceso.consulta(sql)


                Me.dgv_vacunatorios.Rows.Clear()
                Me.dgv_vacunatorios.Rows.Add()
                Me.dgv_vacunatorios.Rows(0).Cells("cuie").Value = cuie
                Me.dgv_vacunatorios.Rows(0).Cells("efector").Value = txt_responsable.Text
                If tabla2.Rows.Count() <> 0 Then
                    Dim c As Integer = 0
                    For c = 1 To tabla2.Rows.Count() - 1
                        Me.dgv_vacunatorios.Rows.Add()
                        Me.dgv_vacunatorios.Rows(c).Cells("cuie").Value = tabla2.Rows(c)("cuie")
                        Me.dgv_vacunatorios.Rows(c).Cells("efector").Value = tabla2.Rows(c)("nombre")
                    Next
                End If

        End If
        End If

        If tabla.Rows.Count() <> 0 Then
            Me.dgv_vacunatorios.Rows.Clear()
            Me.dgv_vacunatorios.Rows.Add()
            Me.dgv_vacunatorios.Rows(0).Cells("cuie").Value = cuie
            Me.dgv_vacunatorios.Rows(0).Cells("efector").Value = txt_responsable.Text
            If tabla2.Rows.Count() <> 0 Then
                Dim c As Integer = 0
                For c = 1 To tabla2.Rows.Count() - 1
                    Me.dgv_vacunatorios.Rows.Add()
                    Me.dgv_vacunatorios.Rows(c).Cells("cuie").Value = tabla2.Rows(c)("cuie")
                    Me.dgv_vacunatorios.Rows(c).Cells("efector").Value = tabla2.Rows(c)("nombre")
                Next
            End If

        End If
    End Sub

    Private Function validar_reporte() As Boolean
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cuie As String = ""

        If txt_responsable.Text <> "" Then
            cuie = devolver_cuie_responsable()

            sql = ""
            sql &= "SELECT * FROM REPORTES "
            sql &= " WHERE año= '" & cmb_año.Text & "' AND id_semestre= " & cmb_semestre_reporte.SelectedValue
            sql &= " AND responsable= '" & cuie & "'"
            tabla.Clear()
            tabla = acceso.consulta(sql)
        End If

        If tabla.Rows.Count() <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

   
    Private Sub dgv_vacunatorios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_vacunatorios.RowHeaderMouseClick
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cuie As String = ""

        If dgv_vacunatorios.SelectedRows.Count() <> 0 Then
            controlar_notificaciones()
            sql = "SELECT E.estado_rm as estado_rm, E.id_tipo_notificacion as tipo_notificacion FROM EFECTORES E WHERE E.cuie='" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count() <> 0 Then
                If IsDBNull(tabla.Rows(0)("estado_rm")) Then
                    cmb_emite_resumen.SelectedValue = -1
                Else
                    cmb_emite_resumen.SelectedValue = tabla.Rows(0)("estado_rm")
                End If

                If IsDBNull(tabla.Rows(0)("tipo_notificacion")) Then
                    cmb_tiempo_notificacion.SelectedValue = -1
                Else
                    cmb_tiempo_notificacion.SelectedValue = tabla.Rows(0)("tipo_notificacion")
                End If
            Else
                cmb_emite_resumen.SelectedValue = -1
                cmb_tiempo_notificacion.SelectedValue = -1
            End If
        End If
    End Sub

    Private Function controlar_notificaciones() As Boolean

        Return True
    End Function


    Private Sub cmd_agregar_reporte_Click(sender As Object, e As EventArgs) Handles cmd_agregar_reporte.Click
        Dim numero As Integer = 0
        If validar_llenado() Then
            dgv_reportes.Rows.Add()
            numero = dgv_reportes.Rows.Count() - 1
            dgv_reportes.Rows(numero).Cells("efectorTerminado").Value = dgv_vacunatorios.CurrentRow.Cells("efector").Value
            dgv_reportes.Rows(numero).Cells("cuieTerminado").Value = dgv_vacunatorios.CurrentRow.Cells("cuie").Value
            dgv_reportes.Rows(numero).Cells("id_notificaciones").Value = cmb_notificaciones.SelectedValue
            dgv_reportes.Rows(numero).Cells("notificaciones").Value = cmb_notificaciones.Text
            dgv_reportes.Rows(numero).Cells("id_carga").Value = cmb_carga.SelectedValue
            dgv_reportes.Rows(numero).Cells("carga").Value = cmb_carga.Text
            dgv_reportes.Rows(numero).Cells("id_perdidas").Value = cmb_perdidas.SelectedValue
            dgv_reportes.Rows(numero).Cells("perdidas").Value = cmb_perdidas.Text
            dgv_reportes.Rows(numero).Cells("id_stock").Value = cmb_stock.SelectedValue
            dgv_reportes.Rows(numero).Cells("stock").Value = cmb_stock.Text
            dgv_reportes.Rows(numero).Cells("id_emision_resumen").Value = cmb_emite_resumen.SelectedValue
            dgv_reportes.Rows(numero).Cells("emision_resumen").Value = cmb_emite_resumen.Text
            dgv_reportes.Rows(numero).Cells("id_tiempo_notificacion").Value = cmb_tiempo_notificacion.SelectedValue
            dgv_reportes.Rows(numero).Cells("tiempo_notificacion").Value = cmb_tiempo_notificacion.Text
            dgv_reportes.Rows(numero).Cells("observaciones").Value = txt_observaciones.Text

            dgv_vacunatorios.Rows.RemoveAt(dgv_vacunatorios.CurrentRow.Index)
        Else
            Exit Sub
        End If
        limpiar_indicadores()
    End Sub

    Private Sub limpiar_indicadores()
        cmb_notificaciones.SelectedIndex = -1
        cmb_carga.SelectedIndex = -1
        cmb_perdidas.SelectedIndex = -1
        cmb_stock.SelectedIndex = -1
        cmb_emite_resumen.SelectedIndex = -1
        cmb_tiempo_notificacion.SelectedIndex = -1
        txt_observaciones.Text = ""
    End Sub

    Private Function validar_llenado() As Boolean
        If Me.cmb_notificaciones.SelectedIndex = -1 Then
            MessageBox.Show("Debe llenar el campo de notificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_notificaciones.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_carga.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_carga.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_perdidas.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de perdidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_perdidas.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_stock.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_stock.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_emite_resumen.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de resumen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_emite_resumen.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_tiempo_notificacion.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un tiempo de notificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_tiempo_notificacion.Focus()
            Return False
            Exit Function
        ElseIf Me.txt_observaciones.Text = "" Then
            MessageBox.Show("Debe seleccionar una observacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_observaciones.Focus()
            Return False
            Exit Function
        End If
        Return True

    End Function

    Private Sub cmd_confirmar_reportes_Click(sender As Object, e As EventArgs) Handles cmd_confirmar_reportes.Click
        If dgv_reportes.Rows.Count() <> 0 Then
            guardar_reporte()
        End If
        limpiar(Controls)
    End Sub

    Private Sub guardar_reporte()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cuie As String = ""

        If validar_reporte() Then
            guardar_detalle()
            Exit Sub
        Else
            cuie = devolver_cuie_responsable()

            acceso._nombre_tabla = "REPORTES"

            sql &= " año = " & Me.cmb_año.Text
            sql &= ", id_semestre = " & Me.cmb_semestre_reporte.SelectedValue
            sql &= ", id_responsable = " & cuie

            acceso.insertar(sql)

            guardar_detalle()
        End If
    End Sub

    Private Function devolver_cuie_responsable() As String
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cuie As String = ""
        Dim id_reporte As Integer = 0

        sql = "SELECT cuie FROM EFECTORES WHERE nombre= '" & Me.txt_responsable.Text & "'"
        tabla = acceso.consulta(sql)
        cuie = tabla.Rows(0)("cuie")

        If cuie <> "" Then
            Return cuie
        End If
    End Function

    Private Function devolver_id_reporte() As Integer
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim id_reporte As Integer = 0
        Dim cuie As String = ""

        cuie = devolver_cuie_responsable()

        sql = ""
        sql &= "SELECT id_reporte FROM REPORTES "
        sql &= " WHERE año= '" & cmb_año.Text & "' AND id_semestre= " & cmb_semestre_reporte.SelectedValue
        sql &= " AND responsable= '" & cuie & "'"
        tabla.Clear()
        tabla = acceso.consulta(sql)
        id_reporte = tabla.Rows(0)("id_reporte")


    End Function

    Private Function validar_detalle(ByRef cuie As String) As Boolean
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim id_reporte As Integer = 0

        cuie = devolver_cuie_responsable()
        id_reporte = devolver_id_reporte()

        sql = ""
        sql &= "SELECT * FROM DETALLE_REPORTE WHERE id_reporte= " & id_reporte & " AND cuie= '" & cuie & "'"
        tabla.Clear()
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() <> 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub guardar_detalle()
        Dim c As Integer = 0
        Dim Sql As String = ""
        Dim id_reporte As Integer = 0
        Dim cuie As String = ""

        id_reporte = devolver_id_reporte()
        cuie = devolver_cuie_responsable()


        For c = 0 To dgv_reportes.Rows.Count() - 1
            If validar_detalle(dgv_reportes.Rows(c).Cells("cuieTerminado").Value) Then
                Sql = "UPDATE DETALLE_REPORTE"
                Sql &= " SET id_estado_notif =" & Me.dgv_reportes.Rows(c).Cells("id_notificaciones").Value
                Sql &= ", id_reporte_carga= " & Me.dgv_reportes.Rows(c).Cells("id_carga").Value
                Sql &= ", id_reporte_perdidas= " & Me.dgv_reportes.Rows(c).Cells("id_perdidas").Value
                Sql &= ", id_reporte_stock= " & Me.dgv_reportes.Rows(c).Cells("id_stock").Value
                Sql &= ", id_estado_rm= " & Me.dgv_reportes.Rows(c).Cells("id_emision_resumen").Value
                Sql &= ", id_tiempo_notif= " & Me.dgv_reportes.Rows(c).Cells("id_tiempo_notificacion").Value
                Sql &= ", observaciones= '" & Me.dgv_reportes.Rows(c).Cells("observaciones").Value & "'"
                Sql &= " WHERE id_reporte =" & id_reporte
                Sql &= " AND cuie = '" & cuie & "'"
                acceso.ejecutar(Sql)
            Else

                acceso._nombre_tabla = "DETALLE_REPORTE"
                Sql &= " id_reporte =" & id_reporte
                Sql &= ", cuie= " & cuie
                Sql &= ", id_estado_notif =" & Me.dgv_reportes.Rows(c).Cells("id_notificaciones").Value
                Sql &= ", id_reporte_carga= " & Me.dgv_reportes.Rows(c).Cells("id_carga").Value
                Sql &= ", id_reporte_perdidas= " & Me.dgv_reportes.Rows(c).Cells("id_perdidas").Value
                Sql &= ", id_reporte_stock= " & Me.dgv_reportes.Rows(c).Cells("id_stock").Value
                Sql &= ", id_estado_rm= " & Me.dgv_reportes.Rows(c).Cells("id_emision_resumen").Value
                Sql &= ", id_tiempo_notif= " & Me.dgv_reportes.Rows(c).Cells("id_tiempo_notificacion").Value
                Sql &= ", observaciones= " & Me.dgv_reportes.Rows(c).Cells("observaciones").Value

                acceso.insertar(Sql)
            End If
            Sql = ""

        Next
    End Sub


    Private Sub cmd_eliminar_reporte_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_reporte.Click
        Dim num As Integer = dgv_reportes.CurrentRow.Index
        For c = 0 To dgv_reportes.Rows.Count - 1
            If num = c Then
                dgv_reportes.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub
End Class