Public Class listado_localidadesxdpto

    Private Sub listado_localidadesxdpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_dptos.cargar()
        Me.cmb_dptos.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        Dim tabla As New DataTable


        sql &= "SELECT D.descripcion as nombre_departamento, L.descripcion as nombre_localidad FROM DEPARTAMENTOS D JOIN LOCALIDADES L ON L.id_departamento = D.id  "
        If cmb_dptos.SelectedIndex <> -1 Then

            sql &= "WHERE D.id = " & Me.cmb_dptos.SelectedValue
            sql &= " GROUP BY D.descripcion, L.descripcion "
        Else
            sql &= " GROUP BY D.descripcion, L.descripcion "
        End If

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron datos para la búsqueda!", "Ola k ase", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.ReportViewer1.Clear()
            Exit Sub
        End If


        Me.LIST_LOCALIDADES_X_DPTOBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_generar_listado_Click(sender As Object, e As EventArgs) Handles cmd_generar_listado.Click
        imprimir()
    End Sub

    
    Private Sub ReportViewer1_Resize(sender As Object, e As EventArgs) Handles ReportViewer1.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200
    End Sub

    Private Sub listado_localidadesxdpto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200
    End Sub
End Class