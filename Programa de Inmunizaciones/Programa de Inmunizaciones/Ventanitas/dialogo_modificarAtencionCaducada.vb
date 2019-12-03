Public Class dialogo_modificarAtencionCaducada

    Private Sub dialogo_modificarAtencionCaducada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub cmd_confirmarNuevafecha_Click(sender As Object, e As EventArgs) Handles cmd_confirmarNuevafecha.Click
        Dim sql As String
        If lbl_id_atencion.Text <> "" Then
            sql = "UPDATE ATENCION_SOPORTE SET FECHA = '" & Me.txt_nuevaFecha.Text & "' WHERE ID = " & Me.lbl_id_atencion.Text
            acceso.ejecutar(sql)
            pop_up_recordatorios.dgv_atencionescaducadas.Rows.Clear()
            pop_up_recordatorios.verificarAtencionesPendientesCaducadas()


        End If

    End Sub

    Private Sub dialogo_modificarAtencionCaducada_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmd_actualizar_estado_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_estado.Click
        Dim sql As String
        If lbl_id_atencion.Text <> "" Then
            sql = "update atencion_soporte set id_estados_atencion = " & Me.cmb_estado_atencion.SelectedValue & "where id = " & Me.lbl_id_atencion.Text
            acceso.ejecutar(sql)
            pop_up_recordatorios.dgv_atencionescaducadas.Rows.Clear()
            pop_up_recordatorios.verificarAtencionesPendientesCaducadas()
        End If

    End Sub

    Private Sub cmd_guardar_atencion_Click(sender As Object, e As EventArgs) Handles cmd_guardar_atencion.Click
        Dim sql As String
        If lbl_id_atencion.Text <> "" Then
            sql = "update atencion_soporte set descripcion = '" & Me.txt_editarAtencion.Text & "' where id = " & Me.lbl_id_atencion.Text
            acceso.ejecutar(sql)
            pop_up_recordatorios.dgv_atencionescaducadas.Rows.Clear()
            pop_up_recordatorios.verificarAtencionesPendientesCaducadas()
        End If

    End Sub
End Class