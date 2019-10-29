Public Class dialogo_posponerRecordatorio
    Private Sub cmd_confirmarNuevafecha_Click(sender As Object, e As EventArgs) Handles cmd_confirmarNuevafecha.Click
        guardar()
    End Sub

    Private Sub guardar()
        Dim sql As String

        sql = "UPDATE RECORDATORIOS SET FECHA_EVENTO = '" & Me.txt_nuevaFechaEvento.Text & "'"
        sql &= " WHERE ID = " & Me.lbl_idRecordatorio.Text

        acceso.ejecutar(sql)
        Me.lbl_idRecordatorio.Text = "--"
        Me.txt_nuevaFechaEvento.Text = ""
        Me.lbl_fecha_actual_evento.Text = "__/__/____"
        MessageBox.Show("Fecha actualizada correctamente ☺", "Wipuuu☺☺", MessageBoxButtons.OK)
        Me.Close()
        pop_up_recordatorios.dgv_recordatorios.Rows.Clear()
        pop_up_recordatorios.dgv_recordatoriosDiaSiguiente.Rows.Clear()
        pop_up_recordatorios.verificar()
        pop_up_recordatorios.verificarMañana()
        If pop_up_recordatorios.dgv_recordatorios.Rows.Count() = 0 And pop_up_recordatorios.dgv_recordatoriosDiaSiguiente.Rows.Count() = 0 Then
            MessageBox.Show("No hay actividades en el día ni mañana!", "Atención☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
            pop_up_recordatorios.Close()
        End If
    End Sub



    Private Sub dialogo_posponerRecordatorio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.guardar()
        End If
    End Sub

    Private Sub dialogo_posponerRecordatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class