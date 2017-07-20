Public Class list_empleados_x_estado

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub list_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_estados_empleados.cargar()
        Me.cmb_estados_empleados.SelectedIndex = -1
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
                cmb_departamentos.SelectedValue = -1
                cmb_localidades.SelectedValue = -1
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
                cmb_departamentos.SelectedValue = -1
                cmb_localidades.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub tip()
        tltp_usuarios.SetToolTip(cmd_ejecutar, "EJECUTAR")
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

    Private Sub list_usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

        sql &= "SELECT D.descripcion as nombre_departamento, L.descripcion as nombre_localidad, E.nombre as nombre_efector, EMP.nombres as nombre_empleado "
        sql &= ", EMP.apellidos as apellido_empleado "
        sql &= ", EXU.descripcion as estado, EXE.año_curso as año_curso, EMP.caracteristica as caracteristica, EMP.telefono as telefono "
        sql &= " FROM EFECTORES E JOIN EMPLEADOSXEFECTOR EXE ON E.cuie = EXE.id_efector "
        sql &= " JOIN EMPLEADOS EMP ON EXE.id_empleados = EMP.id "
        sql &= " JOIN ESTADOS_EMPLEADOS EXU ON EXU.id = EXE.id_estado_empleado "
        sql &= " JOIN DEPARTAMENTOS D ON D.id = E.id_departamento "
        sql &= " JOIN LOCALIDADES L ON L.id = E.id_localidad "


        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND EXE.id_efector ='" & Me.txt_cuie.Text & "'"
            ElseIf cmb_estados_empleados.SelectedIndex <> -1 Then
                sql &= " AND EXU.id=" & Me.cmb_estados_empleados.SelectedValue
            ElseIf txt_año_curso.Text <> "" Then
                sql &= " AND año_curso= " & txt_año_curso.Text
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            ElseIf cmb_estados_empleados.SelectedIndex <> -1 Then
                sql &= " AND estado=" & Me.cmb_estados_empleados.SelectedValue
            ElseIf txt_año_curso.Text <> "" Then
                sql &= " AND año_curso= " & txt_año_curso.Text
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE E.cuie ='" & Me.txt_cuie.Text & "'"
            If cmb_estados_empleados.SelectedIndex <> -1 Then
                sql &= " AND estado= " & Me.cmb_estados_empleados.SelectedValue
            ElseIf txt_año_curso.Text <> "" Then
                sql &= " AND año_curso= " & txt_año_curso.Text
            End If
        ElseIf cmb_estados_empleados.SelectedIndex <> -1 Then
            sql &= " WHERE estado= " & Me.cmb_estados_empleados.SelectedValue
            If txt_año_curso.Text <> "" Then
                sql &= " AND año_curso= " & txt_año_curso.Text
            End If
        ElseIf txt_año_curso.Text <> "" Then
            sql &= " WHERE año_curso= " & txt_año_curso.Text
        End If

        sql &= "ORDER BY nombre_efector, nombre_empleado, apellido_empleado "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If
        Me.LIST_EMPLEADOS_X_ESTADOBindingSource.DataSource = tabla
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