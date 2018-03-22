Public Class list_efectores_x_estado

    Private Sub list_efectores_x_estado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_departamentos.cargar()
        cmb_estado_efector.cargar()
        cmb_localidades.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_estado_efector.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1
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
                Case "WindowsApplication1.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
    End Sub

    Private Sub list_efectores_x_estado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT E.nombre AS nombre_efector, D.descripcion AS nombre_departamento, L.descripcion AS nombre_localidad, E.cuie as cuie, EE.descripcion AS estado "
        sql &= " FROM EFECTORES E JOIN ESTADOS_EFECTOR EE ON E.id_estado = EE.id JOIN LOCALIDADES L ON E.id_localidad = L.id JOIN DEPARTAMENTOS D ON L.id_departamento = D.id "

        If cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue

            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id = " & Me.cmb_localidades.SelectedValue
                If cmb_estado_efector.SelectedIndex <> -1 Then
                    sql &= " AND EE.id = " & Me.cmb_estado_efector.SelectedValue
                End If
            ElseIf cmb_estado_efector.SelectedIndex <> -1 Then
                sql &= " AND EE.id = " & Me.cmb_estado_efector.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE L.id = " & cmb_localidades.SelectedValue
            If cmb_estado_efector.SelectedIndex <> -1 Then
                sql &= " AND EE.id = " & Me.cmb_estado_efector.SelectedValue
            End If
        ElseIf cmb_estado_efector.SelectedIndex <> -1 Then
            sql &= " WHERE EE.id = " & Me.cmb_estado_efector.SelectedValue
        End If

        sql &= "ORDER BY nombre_departamento "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para la búsqueda!")
            Me.ReportViewer1.Clear()
            Exit Sub

        End If

        Me.LIST_EFECTOR_X_ESTADOBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub cmd_generar_listado_Click(sender As Object, e As EventArgs) Handles cmd_generar_listado.Click
        imprimir()
    End Sub

   
    Private Sub list_efectores_x_estado_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200
        Me.ReportViewer1.PerformAutoScale()
    End Sub

    
    Private Sub list_efectores_x_estado_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "B" Then
            imprimir()
        End If
    End Sub
End Class