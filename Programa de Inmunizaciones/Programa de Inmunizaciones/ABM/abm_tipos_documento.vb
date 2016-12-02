Public Class abm_tipos_documento

    Private Sub abm_tipos_documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM TIPOS_DOCUMENTO "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0
        Me.dgv_tipos_doc.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_tipos_doc.Rows.Add()

            Me.dgv_tipos_doc.Rows(c).Cells("id_tipo_doc").Value = tabla.Rows(c)("id")
            Me.dgv_tipos_doc.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

End Class