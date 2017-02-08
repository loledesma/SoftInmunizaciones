Public Class est_empleados_con_y_sin_curso

    Private Sub est_empleados_con_y_sin_curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_departamentos.cargar()
        cmb_localidades.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1
        cmb_departamentos.Focus()
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
    Private Sub est_empleados_con_y_sin_curso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

        sql &= "SELECT EE.descripcion AS curso, COUNT (*) AS cantidad "
        sql &= "FROM ESTADOS_EMPLEADOS EE JOIN EMPLEADOSXEFECTOR EMPEF ON EMPEF.id_estado_empleado = EE.id JOIN EMPLEADOS E ON E.id = EMPEF.id_empleados JOIN EFECTORES EF ON EF.cuie = EMPEF.id_efector "
        If cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE EF.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND EF.id_localidad = " & Me.cmb_localidades.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE EF.id_localidad = " & Me.cmb_localidades.SelectedValue
        End If

        sql &= "GROUP BY EE.descripcion"
        tabla = acceso.consulta(sql)


        EST_EMPLEADOS_CON_Y_SIN_CURSOBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        imprimir()
    End Sub
End Class