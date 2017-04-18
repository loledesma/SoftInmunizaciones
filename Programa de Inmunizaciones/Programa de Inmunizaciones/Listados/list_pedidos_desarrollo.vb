Public Class list_pedidos_desarrollo

    Private Sub list_pedidos_desarrollo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_estado_pedido.cargar()
        cmb_estado_pedido.SelectedIndex = -1
        txt_fecha_desde.Focus()
        Me.ReportViewer1.RefreshReport()
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

    Private Sub list_pedidos_desarrollo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub imprimir()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT PD.fecha_pedido, PD.fecha_solucion, PD.desarrollador, PD.descripcionSolicitud, PD.descripcionRespuesta, EP.descripcion as estado_pedido "
        sql &= "FROM PEDIDO_DESARROLLO PD JOIN ESTADOS_PEDIDOS EP ON EP.id = PD.id_estados_pedidos "
        If cmb_estado_pedido.SelectedIndex <> -1 Then
            sql &= "WHERE EP.id = " & Me.cmb_estado_pedido.SelectedValue
            If txt_fecha_desde.Text <> "" And txt_fecha_hasta.Text <> "" Then
                sql &= " AND PD.fecha_pedido between '" & Me.txt_fecha_desde.Text & "'AND '" & Me.txt_fecha_hasta.Text & "'"

            End If
        ElseIf txt_fecha_desde.Text <> "" And txt_fecha_hasta.Text <> "" Then
            sql &= "WHERE PD.fecha_pedido BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
        End If

        tabla = acceso.consulta(sql)
        LIST_PEDIDOS_DESARROLLOBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        If (txt_fecha_desde.Text <> "" And txt_fecha_hasta.Text = "") Or (txt_fecha_desde.Text = "" And txt_fecha_hasta.Text <> "") Then
            MessageBox.Show("Debe ingresar ambas fechas o ninguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            imprimir()
        End If
    End Sub

End Class