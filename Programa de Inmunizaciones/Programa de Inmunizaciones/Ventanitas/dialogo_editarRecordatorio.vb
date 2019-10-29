Public Class dialogo_editarRecordatorio

    Private Sub cmd_confirmarCambios_Click(sender As Object, e As EventArgs) Handles cmd_confirmarCambios.Click
        guardar()
    End Sub
    Private Sub guardar()
        Dim sql As String
        If txt_editarRecordatorio.Text <> "" Then

            sql = "update recordatorios set descripcion = '" & Me.txt_editarRecordatorio.Text & "'"
            sql &= "where id = " & Me.lbl_idRecordatorio.Text
            acceso.ejecutar(sql)
            Me.lbl_idRecordatorio.Text = "--"
            Me.txt_editarRecordatorio.Text = "☺"
            MessageBox.Show("Recordatorio actualizado correctamente ☺", "Wipuuu☺☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            pop_up_recordatorios.dgv_recordatorios.Rows.Clear()
            pop_up_recordatorios.dgv_recordatoriosDiaSiguiente.Rows.Clear()
            pop_up_recordatorios.verificar()
            pop_up_recordatorios.verificarMañana()
            If pop_up_recordatorios.dgv_recordatorios.Rows.Count() = 0 And pop_up_recordatorios.dgv_recordatoriosDiaSiguiente.Rows.Count() = 0 And pop_up_recordatorios.dgv_atencionescaducadas.Rows.Count() = 0 Then
                pop_up_recordatorios.Close()
            End If
        End If
    End Sub
    Private Sub dialogo_editarRecordatorio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.guardar()
        End If
    End Sub
    
    Private Sub dialogo_editarRecordatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class