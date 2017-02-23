Public Class listados_efector_loc_dpto
    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub listados_notificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_tipo_efector.cargar()
        Me.cmb_tipo_efector.SelectedIndex = -1
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
            End If
        End If
    End Sub

    Private Sub tip()
        tltp_notificaciones.SetToolTip(cmd_ejecutar, "EJECUTAR")
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

    Private Sub listados_efector_loc_dpto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    'Private Function validar_fecha() As Boolean
    '    Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
    '    Dim desde As Date = txt_fecha_desde.Text
    '    Dim hasta As Date = txt_fecha_hasta.Text
    '    Dim limite As Date = "01/01/1990"

    '    If Me.txt_fecha_hasta.Text > hoy Then
    '        MessageBox.Show("La fecha ingresada (hasta) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_fecha_hasta.Focus()
    '        Return False
    '    ElseIf desde > hasta Then
    '        MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_fecha_desde.Focus()
    '        Return False
    '    ElseIf desde < limite Then
    '        MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txt_fecha_desde.Focus()
    '        Return False
    '    End If
    '    Return True
    'End Function

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

        sql &= "SELECT D.descripcion as nombre_departamento, L.descripcion as nombre_localidad, TE.descripcion as tipo_efector, "
        sql &= " EF.cuie as cuie, EF.nombre as nombre_efector "
        sql &= " FROM EFECTORES EF JOIN DEPARTAMENTOS D ON EF.id_departamento = D.id "
        sql &= " JOIN LOCALIDADES L ON EF.id_localidad= L.id "
        sql &= " JOIN TIPOS_EFECTORES TE ON EF.id_tipo = TE.id "

        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id= " & Me.cmb_localidades.SelectedValue
                If cmb_tipo_efector.SelectedIndex <> -1 Then
                    sql &= " AND EF.id_tipo = " & Me.cmb_tipo_efector.SelectedValue
                End If
            ElseIf cmb_tipo_efector.SelectedIndex <> -1 Then
                sql &= " AND EF.id_tipo= " & Me.cmb_tipo_efector.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE L.id= " & Me.cmb_localidades.SelectedValue
            If cmb_tipo_efector.SelectedIndex <> -1 Then
                sql &= " AND EF.id_tipo = " & Me.cmb_tipo_efector.SelectedValue
            End If
        ElseIf cmb_tipo_efector.SelectedIndex <> -1 Then
            sql &= " WHERE EF.id_tipo= " & Me.cmb_tipo_efector.SelectedValue
        End If


        sql &= "ORDER BY nombre_departamento, nombre_localidad, tipo_efector, nombre_efector "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If

        Me.LISTEFECTORXLOCXDPTOBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200

        
    End Sub
End Class
