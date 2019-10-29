Public Class est_reporte_de_notif

    Private Sub est_reporte_de_notif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "select count(NXE.id_carga) as CARGA, count (NXE.id_perdidas) "

    End Sub
End Class