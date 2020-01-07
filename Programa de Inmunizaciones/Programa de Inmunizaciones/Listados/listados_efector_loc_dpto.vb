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

        Me.ReportViewer1.RefreshReport()
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
        sql &= " EF.cuie as cuie, EF.nombre as nombre_efector, EF.horario_desde as horario_desde, EF.horario_hasta as horario_hasta, (cast(ef.calle as varchar ) + ' ' + cast(ef.nro as varchar)) as direccion, EF.telefono as teléfono "
        sql &= " FROM EFECTORES EF JOIN DEPARTAMENTOS D ON EF.id_departamento = D.id "
        sql &= " JOIN LOCALIDADES L ON EF.id_localidad= L.id "
        sql &= " JOIN TIPOS_EFECTORES TE ON EF.id_tipo = TE.id WHERE 1 = 1 "

        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " AND D.id = " & Me.cmb_departamentos.SelectedValue
        End If
        If cmb_localidades.SelectedIndex <> -1 Then
            sql &= " AND L.id= " & Me.cmb_localidades.SelectedValue
            End If
        If cmb_tipo_efector.SelectedIndex <> -1 Then
            sql &= " AND EF.id_tipo= " & Me.cmb_tipo_efector.SelectedValue
        ElseIf cmb_tipo_efector.SelectedIndex = -1 Then
            sql &= "and EF.id_tipo != 4 "
        End If
        If Me.txt_referente.Text <> "" Then
            sql &= "AND EF.id_referente = (select E.cuie from efectores e where e.nombre like '%" & Me.txt_referente.Text & "%')"
        End If
        sql &= " ORDER BY nombre_departamento, nombre_localidad, tipo_efector, nombre_efector "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If

        Me.LIST_EFECTOR_X_LOC_X_DPTOBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200

        
    End Sub

    Private Sub txt_referente_Leave(sender As Object, e As EventArgs) Handles txt_referente.Leave
        Dim tabla As New DataTable
        Dim sql As String
        If txt_referente.Text <> "" Then
            sql = "SELECT E.nombre from efectores E where E.nombre like '%" & Me.txt_referente.Text & "%'"
            tabla = acceso.consulta(sql)

            txt_referente.Text = tabla.Rows(0)("nombre")
            tabla.Clear()
        End If
    End Sub

    


    Private Sub txt_referente_MouseEnter_1(sender As Object, e As EventArgs) Handles txt_referente.MouseEnter
        If txt_referente.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            Dim empleados As String = ""
            Dim tabla2 As New DataTable

            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_referente.Text & "%'"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            ToolTip1.SetToolTip(txt_referente, efectores)

        Else
            Exit Sub
        End If
    End Sub
End Class
