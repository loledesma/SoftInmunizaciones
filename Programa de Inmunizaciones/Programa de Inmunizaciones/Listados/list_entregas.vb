Public Class list_atenciones

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub list_atenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_insumos.cargar()
        Me.cmb_insumos.SelectedIndex = -1
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        tip()
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
                Me.txt_cuie.Text = ""
                Me.txt_efectores.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efectores.Text <> "" Then
                sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
                sql &= " WHERE E.nombre='" & txt_efectores.Text & "'"
                tabla = acceso.consulta(sql)
                txt_cuie.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub

    Private Sub txt_cuie_LostFocus(sender As Object, e As EventArgs) Handles txt_cuie.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_cuie.Text <> "" Then
                sql &= "SELECT E.nombre As nombre FROM EFECTORES E "
                sql &= " WHERE E.cuie='" & txt_cuie.Text & "'"
                tabla = acceso.consulta(sql)
                txt_efectores.Text = tabla.Rows(0)("nombre")
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
                Case "Programa_de_Inmunizaciones.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
    End Sub

    Private Sub list_entregas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validar_fecha() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim desde As Date = txt_fecha_desde.Text
        Dim hasta As Date = txt_fecha_hasta.Text
        Dim limite As Date = "01/01/1990"

        If Me.txt_fecha_hasta.Text > hoy Then
            MessageBox.Show("La fecha ingresada (hasta) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_hasta.Focus()
            Return False
        ElseIf desde > hasta Then
            MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Return False
        ElseIf desde < limite Then
            MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Return False
        End If
        Return True
    End Function

    'Private Function validar() As Boolean
    '    If cmb_departamentos.SelectedIndex <> -1 Then
    '        If cmb_localidades.SelectedIndex = -1 Then
    '            MessageBox.Show("Debe seleccionar la localidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.cmb_localidades.Focus()
    '            Return False
    '            Exit Function
    '        ElseIf txt_cuie.Text = "" Then
    '            MessageBox.Show("Debe ingresar el cuie", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_cuie.Focus()
    '            Return False
    '            Exit Function
    '        ElseIf txt_efectores.Text = "" Then
    '            MessageBox.Show("Debe ingresar el efector", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_efectores.Focus()
    '            Return False
    '            Exit Function
    '        End If
    '    End If
    '    Return True
    'End Function

    Private Sub imprimir()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT EI.fecha_pedido as fecha_pedido, EI.fecha_entrega as fecha_entrega, EST.descripcion as estado, "
        sql &= " E.cuie as cuie,E.nombre as nombre_vacunatorio, EI.receptor as receptor, I.descripcion as insumo "
        sql &= ", DEI.nro_serie as nro_serie, DEI.modelo as modelo, M.descripcion as marca "
        sql &= " FROM ENTREGA_INSUMOS EI JOIN DETALLE_ENTREGA_INSUMOS DEI ON EI.id = DEI.id_entrega "
        sql &= " JOIN EFECTORES E ON EI.id_efector = E.cuie "
        sql &= " JOIN INSUMOS I ON DEI.id_insumo = I.id "
        sql &= " JOIN MARCA M ON DEI.id_marca = M.id "
        sql &= " JOIN ESTADO_ENTREGA EE On EE.id = EI.id_estado_entrega "
    
        If IsDate(txt_fecha_desde.Text) And IsDate(txt_fecha_hasta.Text) = False Then
            MessageBox.Show("Debe ingresar las dos fechas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_hasta.Focus()
            Exit Sub
        ElseIf IsDate(txt_fecha_hasta.Text) And IsDate(txt_fecha_desde.Text) = False Then
            MessageBox.Show("Debe ingresar las dos fechas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Exit Sub
        End If

        If IsDate(Me.txt_fecha_desde.Text) And IsDate(Me.txt_fecha_hasta.Text) Then
            If Me.validar_fecha() = False Then
                Exit Sub
            Else
                sql &= " WHERE fecha_pedido BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
            End If
            If Me.cmb_departamentos.SelectedIndex <> -1 Then
                sql &= " AND E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            ElseIf cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            ElseIf cmb_insumos.SelectedIndex <> -1 Then
                sql &= " AND DEI.id_insumo =" & Me.cmb_insumos.SelectedValue
            ElseIf cmb_estado_entrega.SelectedIndex <> -1 Then
                sql &= " AND EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
            End If
        ElseIf Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            ElseIf cmb_insumos.SelectedIndex <> -1 Then
                sql &= " AND DEI.id_insumo =" & Me.cmb_insumos.SelectedValue
            ElseIf cmb_estado_entrega.SelectedIndex <> -1 Then
                sql &= " AND EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            ElseIf cmb_insumos.SelectedIndex <> -1 Then
                sql &= " AND DEI.id_insumo =" & Me.cmb_insumos.SelectedValue
            ElseIf cmb_estado_entrega.SelectedIndex <> -1 Then
                sql &= " AND EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE E.cuie='" & Me.txt_cuie.Text & "'"
            If cmb_insumos.SelectedIndex <> -1 Then
                sql &= " AND DEI.id_insumo =" & Me.cmb_insumos.SelectedValue
            ElseIf cmb_estado_entrega.SelectedIndex <> -1 Then
                sql &= " AND EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
            End If
        ElseIf cmb_insumos.SelectedIndex <> -1 Then
            sql &= " WHERE DEI.id_insumo =" & Me.cmb_insumos.SelectedValue
            If cmb_estado_entrega.SelectedIndex <> -1 Then
                sql &= " AND EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
            End If
        ElseIf cmb_estado_entrega.SelectedIndex <> -1 Then
            sql &= " WHERE EI.id_estado_entrega =" & Me.cmb_estado_entrega.SelectedValue
        End If

        sql &= "ORDER BY fecha_pedido, estado, nombre_vacunatorio "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If

        Me.LISTENTREGASBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200

        'Me.ReportViewer1.Anchor = AnchorStyles.Left
        'Me.ReportViewer1.Anchor = AnchorStyles.Right
        'Me.ReportViewer1.PerformAutoScale()
    End Sub
End Class