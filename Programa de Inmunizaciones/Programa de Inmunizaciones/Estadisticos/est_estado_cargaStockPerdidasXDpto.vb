Public Class est_estado_cargaStockPerdidasXDpto

    Private Sub est_estado_cargaStockPerdidasXDpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        cmb_carga.cargar()
        cmb_departamentos.cargar()
        cmb_localidades.cargar()
        cmb_perdidas.cargar()
        cmb_stock.cargar()
        cmb_carga.SelectedIndex = -1
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1
        cmb_perdidas.SelectedIndex = -1
        cmb_stock.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class