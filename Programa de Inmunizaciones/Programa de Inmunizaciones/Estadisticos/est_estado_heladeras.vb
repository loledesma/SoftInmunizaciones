Public Class est_estado_heladeras

    Private Sub est_estado_heladeras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.Clear()
        cmb_departamentos.cargar()
        cmb_localidades.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1
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

    Private Sub est_estado_heladeras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

        sql &= " SELECT E.antiguedad AS estado_heladera, COUNT (*) AS cantidad "
        sql &= "FROM EFECTORES E "
        If cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad = " & Me.cmb_localidades.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad = " & Me.cmb_localidades.SelectedValue
        End If
        sql &= " GROUP BY E.antiguedad "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para la búsqueda!", "Atención")
            ReportViewer1.Clear()
            Exit Sub
        End If

        EST_ESTADO_HELADERASBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        imprimir()
    End Sub
End Class