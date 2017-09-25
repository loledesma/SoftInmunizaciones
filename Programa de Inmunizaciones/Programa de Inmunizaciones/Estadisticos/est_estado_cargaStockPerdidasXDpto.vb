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

        If cmb_carga.SelectedIndex = -1 Then
            MsgBox("No se puede hacer la busqueda si no seleccionó el estado ")
            Exit Sub

        End If

        sqlCarga = "SELECT D.descripcion as nombre_departamento,L.descripcion as nombre_localidad,COUNT(DISTINCT NE.id_efector) as cantidadEstadoCarga "
        sqlCarga &= " FROM NOTIFICACIONXEFECTOR NE JOIN EFECTORES E ON NE.id_efector = E.cuie "
        sqlCarga &= " JOIN DEPARTAMENTOS D ON E.id_departamento = D.id "
        sqlCarga &= " JOIN LOCALIDADES L ON E.id_localidad = L.id "
        sqlCarga &= "WHERE NE.fecha BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
        sqlCarga &= "  AND NE.id_estado_carga =  " & Me.cmb_carga.SelectedValue
        sqlCarga &= " AND NE.id_efector IN "
        sqlCarga &= " (SELECT TOP 1 N.id_efector FROM NOTIFICACIONXEFECTOR N "
        sqlCarga &= "WHERE N.id_efector = NE.id_efector"
        sqlCarga &= " AND N.id_estado_carga = " & Me.cmb_carga.SelectedValue
        sqlCarga &= "AND NE.fecha BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
        sqlCarga &= " ORDER BY N.fecha desc) "

        If cmb_departamentos.SelectedIndex <> -1 Then
            sqlCarga &= " AND D.id= " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sqlCarga &= " AND L.id= " & Me.cmb_localidades.SelectedValue
            End If
        Else
            If cmb_localidades.SelectedIndex <> -1 Then
                sqlCarga &= " AND L.id= " & Me.cmb_localidades.SelectedValue
            End If
        End If

        sqlCarga &= "GROUP BY D.descripcion, L.descripcion"


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