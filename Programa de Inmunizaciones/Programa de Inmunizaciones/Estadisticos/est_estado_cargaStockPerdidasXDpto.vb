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

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged

        If cmb_departamentos.SelectedIndex <> -1 Then
            cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
            cmb_localidades.Enabled = True
            cmb_localidades.SelectedIndex = -1
        End If

    End Sub

    Private Sub limpiar(ByVal de_donde As Object)
        Dim cmd As ComboBoxV1
        For Each obj As System.Windows.Forms.Control In de_donde
            Select Case obj.GetType.ToString
                Case "System.Windows.Forms.TextBox"
                    obj.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    obj.Text = ""
                Case "Programa_de_Inmunizaciones.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
    End Sub

    Private Sub imprimirCarga()
        Dim tablaCarga As New DataTable
        Dim sqlCarga As String = ""

        sqlCarga = "select D.descripcion as nombre_departamento, L.descripcion as nombre_localidad, COUNT(*) as cantidadEstadoCarga from EFECTORES E "
        sqlCarga &= "JOIN NOTIFICACIONXEFECTOR NE ON NE.id_efector = E.cuie "
        sqlCarga &= "JOIN DEPARTAMENTOS D on D.id = E.id_departamento JOIN LOCALIDADES L ON L.id = E.id_localidad"
        sqlCarga &= " Where E.id_departamento = " & Me.cmb_departamentos.SelectedValue & " AND (NE.id_estado_carga = " & Me.cmb_carga.SelectedValue & ") and NE.fecha between '" & Me.txt_fecha_desde.Text & "' and '" & Me.txt_fecha_hasta.Text & "' "
        sqlCarga &= "group by D.descripcion, L.descripcion"

        tablaCarga = acceso.consulta(sqlCarga)
        EST_EFECTORESXESTADONOTIFICACIONESBindingSource.DataSource = tablaCarga

        ReportViewer2.RefreshReport()
    End Sub

    Private Sub imprimirEstoc() 'Si Lore, puse Estoc..

    End Sub

    Private Sub imprimirPerdidas()

    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        imprimirCarga()
    End Sub
End Class