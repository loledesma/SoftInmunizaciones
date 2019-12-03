Public Class listados_efector_x_refe
    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub listados_efector_x_refe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
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
                Case "WindowsApplication1.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
    End Sub

    Private Sub listados_referentes_y_efectores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

        sql &= "SELECT REF.cuie as cuie_referente, REF.nombre as referente, "
        sql &= " E.cuie as cuie_efector, E.nombre as efector, D.descripcion as departamento, "
        sql &= " L.descripcion as localidad   "
        sql &= " FROM EFECTORES E JOIN EFECTORES REF ON E.id_referente = REF.cuie "
        sql &= " JOIN LOCALIDADES L ON L.id = E.id_localidad JOIN DEPARTAMENTOS D on E.id_departamento = D.id "

        If txt_cuie.Text <> "" Then
            sql &= " WHERE REF.cuie ='" & Me.txt_cuie.Text & "'"
        End If

        sql &= "ORDER BY D.descripcion, L.descripcion "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If

        LIST_EFEC_X_REFEBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200

        'Me.ReportViewer1.Anchor = AnchorStyles.Left
        'Me.ReportViewer1.Anchor = AnchorStyles.Right
        'Me.ReportViewer1.PerformAutoScale()
    End Sub

    Private Sub cmd_ejecutar_Click_1(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub
End Class
