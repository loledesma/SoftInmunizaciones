Public Class pop_up_ajustes_pendientes
    Public Sub Ajustes_Pendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
    Public Function verificar() As Boolean
        Dim flag As Boolean = True

        Dim tabla As DataTable
        Dim sql As String
        sql = "SELECT EFECTOR.nombre, ATENC.id_efector FROM ATENCION_SOPORTE ATENC JOIN EFECTORES EFECTOR ON ATENC.id_efector = EFECTOR.cuie WHERE ATENC.id_asunto = 5 and day(ATENC.fecha) = day(GETDATE()) and month(ATENC.fecha) = month(getdate()) and year(ATENC.fecha) = year(GETDATE()) AND ATENC.id_estados_atencion = 2"
        tabla = acceso.consulta(sql)
        If tabla.Rows.Count = 0 Then
            flag = False
        End If
        Return flag
    End Function

    Public Sub cargar_grilla()
        Dim tabla As DataTable
        Dim sql As String
        sql = "SELECT EFECTOR.nombre, ATENC.id_efector FROM ATENCION_SOPORTE ATENC JOIN EFECTORES EFECTOR ON ATENC.id_efector = EFECTOR.cuie WHERE ATENC.id_asunto = 5 and day(ATENC.fecha) = day(GETDATE()) and month(ATENC.fecha) = month(getdate()) and year(ATENC.fecha) = year(GETDATE()) AND ATENC.id_estados_atencion = 2"
        tabla = acceso.consulta(sql)
        If tabla.Rows.Count <> 0 Then
            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                dgv_atenc_pendientes.Rows.Add()
                dgv_atenc_pendientes.Rows(c).Cells("cuie").Value = tabla.Rows(c)("id_efector")
                dgv_atenc_pendientes.Rows(c).Cells("nombre_efector").Value = tabla.Rows(c)("nombre")
            Next
        End If
    End Sub

    Private Sub txt_atenciones_Click(sender As Object, e As EventArgs) Handles txt_atenciones.Click
        Registrar_atencion.Show()
    End Sub

    Private Sub txt_aceptar_Click(sender As Object, e As EventArgs) Handles txt_aceptar.Click
        Me.Close()
    End Sub
End Class