Public Class Menú

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub cmd_abm_localidades_Click(sender As Object, e As EventArgs) Handles cmd_abm_localidades.Click
        abm_localidades.ShowDialog()
    End Sub

    Private Sub cmd_abm_carga_Click(sender As Object, e As EventArgs) Handles cmd_abm_carga.Click
        abm_carga.ShowDialog()
    End Sub

    Private Sub cmd_abm_cargo_Click(sender As Object, e As EventArgs) Handles cmd_abm_cargo.Click
        abm_cargo.ShowDialog()
    End Sub

    Private Sub cmd_amb_despartamentos_Click(sender As Object, e As EventArgs) Handles cmd_amb_despartamentos.Click
        abm_departamentos.ShowDialog()
    End Sub

    Private Sub cmd_abm_empleados_Click(sender As Object, e As EventArgs) Handles cmd_abm_empleados.Click
        abm_empleados.ShowDialog()
    End Sub

    Private Sub cmd_abm_tiposDoc_Click(sender As Object, e As EventArgs) Handles cmd_abm_tiposDoc.Click
        abm_tipos_documento.ShowDialog()
    End Sub

    Private Sub cmd_estado_capacitac_Click(sender As Object, e As EventArgs) Handles cmd_estado_capacitac.Click
        abm_estado_capacitaciones.ShowDialog()
    End Sub

    Private Sub cmd_estados_atencion_Click(sender As Object, e As EventArgs) Handles cmd_estados_atencion.Click
        abm_estados_atencion.ShowDialog()
    End Sub

    Private Sub cmd_estados_efector_Click(sender As Object, e As EventArgs) Handles cmd_estados_efector.Click
        abm_estados_efector.ShowDialog()
    End Sub

    Private Sub cmd_abm_estado_pedidos_Click(sender As Object, e As EventArgs) Handles cmd_abm_estado_pedidos.Click
        abm_estados_pedidos.ShowDialog()
    End Sub

    Private Sub cmd_abm_perdidas_Click(sender As Object, e As EventArgs) Handles cmd_abm_perdidas.Click
        abm_perdidas.ShowDialog()
    End Sub

    Private Sub cmd_abm_stock_Click(sender As Object, e As EventArgs) Handles cmd_abm_stock.Click
        abm_stock.ShowDialog()
    End Sub

    Private Sub cmd_abm_tipos_efectores_Click(sender As Object, e As EventArgs) Handles cmd_abm_tipos_efectores.Click
        abm_tipos_efectores.ShowDialog()
    End Sub

    Private Sub cmd_abm_barrios_Click(sender As Object, e As EventArgs) Handles cmd_abm_barrios.Click
        abm_barrios.ShowDialog()
    End Sub
End Class
