Public Class abm_stock_insumos

   

    Private Sub abm_stock_insumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        sql &= "SELECT * FROM STOCK_INSUMOS "
        tabla = acceso.consulta(sql)

        dgv_stock.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            dgv_stock.Rows.Add()
            dgv_stock.Rows(c).Cells("id_insumo").Value = tabla.Rows(c)("id_insumo")
            dgv_stock.Rows(c).Cells("cantidad").Value = tabla.Rows(c)("cantidad")

            sql = ""
            sql &= "SELECT descripcion FROM INSUMOS WHERE id= " & tabla.Rows(c)("id_insumo")
            tabla2 = acceso.consulta(sql)

            dgv_stock.Rows(c).Cells("insumo").Value = tabla2.Rows(0)("descripcion")
        Next
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
End Class