Public Class list_no_notifican
    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado
    Private Sub list_no_notifican_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_departamentos.Focus()
        Me.ReportViewer1.Clear()

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamentos.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
                cmb_localidades.Enabled = True
                cmb_localidades.SelectedIndex = -1
            End If
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

    Private Sub listados_no_notifican_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validar_fecha() As Boolean

        If IsDate(txt_fecha_desde.Text) = False Then
            MessageBox.Show("¡Debe ingresar una fecha desde!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_fecha_desde.Focus()
            Return False
            Exit Function
        ElseIf IsDate(txt_fecha_hasta.Text) = False Then
            MessageBox.Show("¡Debe ingresar una fecha hasta!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_fecha_hasta.Focus()
            Return False
            Exit Function
            'ElseIf desde > fecha Then
            '    MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.txt_fecha_desde.Focus()
            '    Return False
            '    Exit Function
            'ElseIf Convert.ToDateTime(txt_fecha_desde).Year <> Convert.ToDateTime(txt_fecha_hasta).Year Then
            '    MessageBox.Show("¡Debe ingresar periodos del mismo año!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txt_fecha_desde.Focus()
            '    Return False
            '    Exit Function
            'ElseIf DateDiff(DateInterval.Month, Convert.ToDateTime(txt_fecha_hasta), Convert.ToDateTime(txt_fecha_desde)) <> 3 Then
            '    MessageBox.Show("¡Debe ingresar el nombre del vacunatorio!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txt_fecha_desde.Focus()
            '    Return False
            '    Exit Function
        End If
            Return True
    End Function

    Private Sub imprimir()
        Dim tabla As New DataTable
        Dim sql As String = ""

        If validar_fecha() = True Then

            sql &= " SELECT D.descripcion As departamento, L.descripcion as localidad, E.cuie as cuie, E.nombre As nombre_vacunatorio"
            sql &= " FROM EFECTORES E JOIN DEPARTAMENTOS D ON E.id_departamento = D.id "
            sql &= " JOIN LOCALIDADES L ON E.id_localidad = L.id "

            If Me.cmb_departamentos.SelectedIndex <> -1 Then
                sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue
               
                If cmb_localidades.SelectedIndex <> -1 Then
                    sql &= " AND L.id = " & Me.cmb_localidades.SelectedValue
                    sql &= " AND E.id_estado= 3 AND E.cuie NOT IN "
                    sql &= " (SELECT NE.id_efector as Cuie "
                    sql &= " FROM NOTIFICACIONXEFECTOR NE JOIN EFECTORES E ON NE.id_efector = E.cuie "
                    sql &= " WHERE NE.fecha BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
                    sql &= " GROUP BY NE.id_efector "
                    sql &= " HAVING COUNT(NE.id_efector)>= 10) "
                    sql &= " ORDER BY D.descripcion, L.descripcion, E.nombre "
                Else
                    sql &= " AND E.id_estado= 3 AND E.cuie NOT IN "
                    sql &= " (SELECT NE.id_efector as Cuie "
                    sql &= " FROM NOTIFICACIONXEFECTOR NE JOIN EFECTORES E ON NE.id_efector = E.cuie "
                    sql &= " WHERE NE.fecha BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
                    sql &= " GROUP BY NE.id_efector "
                    sql &= " HAVING COUNT(NE.id_efector)>= 10) "
                    sql &= " ORDER BY D.descripcion, L.descripcion, E.nombre "
                End If
            Else
                sql &= " WHERE E.id_estado= 3 AND E.cuie NOT IN "
                sql &= " (SELECT NE.id_efector as Cuie "
                sql &= " FROM NOTIFICACIONXEFECTOR NE JOIN EFECTORES E ON NE.id_efector = E.cuie "
                sql &= " WHERE NE.fecha BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
                sql &= " GROUP BY NE.id_efector "
                sql &= " HAVING COUNT(NE.id_efector)>= 10) "
                sql &= " ORDER BY D.descripcion, L.descripcion, E.nombre "
            End If

            tabla = acceso.consulta(sql)

            If tabla.Rows.Count() = 0 Then
                Me.ReportViewer1.Clear()
                MessageBox.Show("No hay datos para esa búsqueda")
                Exit Sub
            End If

            LISTNONOTIFICABindingSource.DataSource = tabla
            Me.ReportViewer1.RefreshReport()
        End If

        
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 100

    End Sub
    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub
End Class