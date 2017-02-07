Public Class Registrar_entrega_insumos

    Enum condicion
        insertar
        modificar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Dim condicion_estado As condicion = condicion.insertar

    Enum doble_Click
        activado
        desactivado
    End Enum


    Dim condicion_click As doble_Click = doble_Click.desactivado
    Private Sub cmd_busca_efector_Click(sender As Object, e As EventArgs)
        listados_efector_loc_dpto.ShowDialog()
    End Sub

    Private Sub cmd_ver_stock_Click(sender As Object, e As EventArgs) Handles cmd_ver_stock.Click
        abm_stock_insumos.ShowDialog()
    End Sub

    Private Sub Registrar_entrega_insumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla_entregas()
        acceso.autocompletar(txt_nombre, "EMPLEADOS", "nombres")
        acceso.autocompletar(txt_apellido, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        acceso.autocompletar(txt_nombre_efector, "EFECTORES", "nombre")
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_entrega.Focus()
        Me.cmb_estado_entrega.cargar()
        Me.cmb_insumos.cargar()
        cargar_combo()
        Me.cmb_autorizador.SelectedIndex = -1
        Me.cmb_estado_entrega.SelectedIndex = -1
        Me.cmb_insumos.SelectedIndex = -1

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub txt_nombre_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_nombre_efector.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_nombre_efector.Text <> "" Then
                sql &= "SELECT E.cuie as cuie, D.id as id_dpto, L.id as id_localidad FROM EFECTORES E JOIN DEPARTAMENTOS D ON D.id = E.id_departamento join LOCALIDADES L ON L.id = E.id_localidad "
                sql &= " WHERE E.nombre= '" & txt_nombre_efector.Text & "'"
                tabla = acceso.consulta(sql)

                If tabla.Rows.Count() <> 0 Then
                    txt_cuie.Text = tabla.Rows(0)("cuie")
                End If
            End If
        End If
    End Sub

    Private Sub txt_cuie_LostFocus(sender As Object, e As EventArgs) Handles txt_cuie.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_cuie.Text <> "" Then
                sql &= "SELECT E.nombre as nombre, D.id as id_dpto, L.id as id_localidad FROM EFECTORES E JOIN DEPARTAMENTOS D ON D.id = E.id_departamento join LOCALIDADES L ON L.id = E.id_localidad "
                sql &= " WHERE E.cuie='" & txt_cuie.Text & "'"
                tabla = acceso.consulta(sql)
                If tabla.Rows.Count() <> 0 Then
                    txt_nombre_efector.Text = tabla.Rows(0)("nombre")

                End If
            End If
        End If
    End Sub

    Private Sub limpiar(ByVal de_donde As Object)
        condicion_estado = condicion.insertar
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
        cmd_nuevo.Enabled = True
    End Sub
    Private Sub cargar_combo()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT E.id as id, E.nombres as nombre, EMP.id_cargo "
        sql &= " FROM EMPLEADOS E JOIN EMPLEADOSXEFECTOR EMP ON E.id = EMP.id_empleados "
        sql &= " WHERE EMP.id_cargo = 1 "

        tabla = acceso.consulta(sql)

        Me.cmb_autorizador.DataSource = tabla
        Me.cmb_autorizador.DisplayMember = "nombre"
        Me.cmb_autorizador.ValueMember = "id"
    End Sub
    Private Sub Registrar_notificaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            'guardar()
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        limpiar(Me.Controls)
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.nuevo()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        'guardar()
    End Sub

    Private Sub cmd_agregar_efector_Click(sender As Object, e As EventArgs) Handles cmd_agregar_efector.Click
        Registrar_efectores.ShowDialog()
    End Sub

    Private Sub cmd_actualizar_estado_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_estado.Click
        Dim sql As String = ""
        Dim tabla As DataTable

        If txt_id_entrega.Text = "" Then
            MessageBox.Show("Seleccione una entrega para actualizar el estado")
            Me.txt_id_entrega.Focus()
            Exit Sub
        End If

        sql &= "SELECT * FROM ENTREGA_INSUMOS WHERE id=" & Me.txt_id_entrega.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No se encuentra registrada esa entrega todavia")
            Me.txt_id_entrega.Focus()
            Exit Sub
        Else
            If Me.cmb_estado_entrega.SelectedValue = 1 Then
                registrar_entrega()
            ElseIf Me.cmb_estado_entrega.SelectedValue = 3 Then
                registrar_rechazo()
            End If
        End If
        cargar_grilla_entregas()
    End Sub

    Private Sub registrar_entrega()

    End Sub

    Private Sub registrar_rechazo()

    End Sub



    'Private Sub dgv_entrega_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_entrega.CellMouseDoubleClick
    '    dgv_detalle_entrega.Rows.Clear()
    '    limpiar(Controls)
    '    Me.cmd_guardar.Enabled = False


    '    Dim tabla As DataTable
    '    Dim tabla2 As DataTable
    '    Dim tabla3 As DataTable
    '    Dim sql As String = ""
    '    Dim sql2 As String = ""
    '    txt_id_empleado.Enabled = False
    '    Dim fecha As Date

    '    sql &= "SELECT * FROM EMPLEADOS WHERE id = " & Me.dgv_entrega.CurrentRow.Cells("id_empleado").Value

    '    sql2 &= "SELECT * FROM ESTADOXUSUARIOS "
    '    sql2 &= " WHERE id_empleado= " & Me.dgv_entrega.CurrentRow.Cells(0).Value


    '    tabla = acceso.consulta(sql)
    '    tabla2 = acceso.consulta(sql2)
    '    If tabla.Rows.Count() = 0 Then
    '        MessageBox.Show("¡El empleado buscado no se encuentra registrado todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Exit Sub
    '    End If
    '    Me.txt_id_empleado.Text = tabla.Rows(0)("id")
    '    Me.cmb_tipo_doc.SelectedValue = tabla.Rows(0)("id_tipo_doc")
    '    Me.txt_nro_documento.Text = tabla.Rows(0)("nro_doc")
    '    Me.txt_nombre.Text = tabla.Rows(0)("nombres")
    '    Me.txt_apellido.Text = tabla.Rows(0)("apellidos")

    '    If IsDBNull(tabla.Rows(0)("caracteristica")) Then
    '        Me.txt_caracteristica.Text = ""
    '    Else
    '        Me.txt_caracteristica.Text = tabla.Rows(0)("caracteristica")
    '    End If

    '    If IsDBNull(tabla.Rows(0)("telefono")) Then
    '        Me.txt_telefono.Text = ""
    '    Else
    '        Me.txt_telefono.Text = tabla.Rows(0)("telefono")
    '    End If

    '    If IsDBNull(tabla.Rows(0)("mail_contacto")) Then
    '        Me.txt_email.Text = ""
    '    Else
    '        Me.txt_email.Text = tabla.Rows(0)("mail_contacto")
    '    End If

    '    sql = ""
    '    sql &= "SELECT EMP.usuario_sigipsa As usuario_sigipsa, EU.id_estado As id_estado "
    '    sql &= " FROM EMPLEADOS EMP JOIN ESTADOXUSUARIOS EU ON EMP.id = EU.id_empleado "
    '    sql &= "WHERE id= " & tabla.Rows(0)("id") & " AND usuario_sigipsa IS NOT NULL "
    '    tabla3 = acceso.consulta(sql)

    '    If tabla3.Rows.Count() = 0 Then
    '        Me.txt_usuario.Text = ""
    '        Me.cmb_estados.SelectedIndex = -1
    '    Else
    '        Me.txt_usuario.Text = tabla3.Rows(0)("usuario_Sigipsa")
    '        Me.cmb_estados.SelectedValue = tabla3.Rows(0)("id_estado")
    '    End If

    '    If IsDBNull(tabla.Rows(0)("fecha_alta")) Then
    '        Me.txt_fecha.Text = ""
    '    Else
    '        fecha = tabla.Rows(0)("fecha_alta")
    '        Me.txt_fecha.Text = fecha.ToString("dd/MM/yyyy")
    '    End If

    '    sql = ""
    '    sql &= " SELECT EF.cuie As cuie, EF.nombre As nombre_efector, C.descripcion As cargo, EST.descripcion As estado "
    '    sql &= " , EE.id_cargo As id_cargo, EE.id_estado_empleado As id_estado "
    '    sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
    '    sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
    '    sql &= " JOIN CARGO C ON EE.id_cargo = C.id"
    '    sql &= " JOIN ESTADOS_EMPLEADOS EST ON EE.id_estado_empleado = EST.id"
    '    sql &= " WHERE EMP.id = " & Me.dgv_entrega.CurrentRow.Cells("id_empleado").Value
    '    tabla2.Clear()
    '    tabla2 = acceso.consulta(sql)

    '    If tabla2.Rows.Count = 0 Then
    '        MessageBox.Show("El empleado seleccionado no tiene efectores asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Me.cmd_agregar_efector.Enabled = True
    '    Else
    '        Dim c As Integer = 0
    '        For c = 0 To tabla2.Rows.Count() - 1
    '            dgv_efectores.Rows.Add()
    '            dgv_efectores.Rows(c).Cells("cuie").Value = tabla2.Rows(c)("cuie")
    '            dgv_efectores.Rows(c).Cells("nombre_efector").Value = tabla2.Rows(c)("nombre_efector")
    '            dgv_efectores.Rows(c).Cells("cargo").Value = tabla2.Rows(c)("cargo")
    '            dgv_efectores.Rows(c).Cells("estado_empleado").Value = tabla2.Rows(c)("estado")
    '            dgv_efectores.Rows(c).Cells("id_cargo").Value = tabla2.Rows(c)("id_cargo")
    '            dgv_efectores.Rows(c).Cells("id_estado").Value = tabla2.Rows(c)("id_estado")

    '            sql = ""
    '            sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
    '            sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
    '            sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
    '            sql &= " WHERE EMP.id = " & Me.dgv_entrega.CurrentRow.Cells("id_empleado").Value
    '            tabla.Clear()
    '            tabla = acceso.consulta(sql)
    '            If tabla.Rows.Count() = 0 Then
    '                dgv_efectores.Rows(c).Cells("perfil").Value = ""
    '                dgv_efectores.Rows(c).Cells("id_perfil").Value = ""
    '            Else
    '                dgv_efectores.Rows(c).Cells("perfil").Value = tabla.Rows(c)("perfil")
    '                dgv_efectores.Rows(c).Cells("id_perfil").Value = tabla.Rows(c)("id_perfil")
    '            End If
    '        Next
    '    End If

    '    cmd_guardar.Enabled = True
    '    cmd_nuevo.Enabled = True
    '    cmd_efector_nuevo.Enabled = True
    '    cmd_agregar_efector.Enabled = True
    '    cmd_eliminar_efector.Enabled = False
    '    Me.condicion_estado = estado.modificar
    'End Sub
    'Private Sub guardar()
    '    If Me.validar_pedido() = True Then
    '        If condicion_estado = condicion.insertar Then
    '            If Me.validar_existencia() = analizar_existencia.no_existe Then
    '                If dgv_efectores.Rows.Count = 0 Then
    '                    If MessageBox.Show("¿Desea registrar el empleado sin efectores?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
    '                        Me.cmb_departamentos.Focus()
    '                        Exit Sub
    '                    Else
    '                        Me.insertar_empleado()
    '                    End If
    '                End If
    '                Me.insertar_empleado()
    '                grabar_empleadoxefector()
    '            Else
    '                MessageBox.Show("Ya se encuentra registrado este empleado")
    '                Exit Sub
    '            End If
    '        Else
    '            Me.modificar()
    '            modificar_empleadoxefector()
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    '    dgv_efectores.Rows.Clear()
    '    dgv_entrega.Rows.Clear()
    '    Me.limpiar(Me.Controls)
    '    Me.cargar_grilla()
    '    Me.txt_id_empleado.Enabled = True
    '    Me.cmd_nuevo.Enabled = True
    '    Me.cmd_guardar.Enabled = True
    '    Me.cmd_limpiar.Enabled = True
    'End Sub

    Private Sub nuevo()
        limpiar(Controls)
        Me.txt_fecha_pedido.Text = ""
        Me.txt_fecha_entrega.Text = ""
        Me.condicion_estado = condicion.insertar
        Dim sql As String = "SELECT * FROM ENTREGA_INSUMOS "
        Dim tabla As New DataTable
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.txt_id_entrega.Text = 1
        Else
            Dim ultimo As Integer = tabla.Rows.Count() - 1
            Me.txt_id_entrega.Text = tabla.Rows(ultimo)("id") + 1
        End If

        Me.txt_id_entrega.Enabled = False
        Me.cmb_estado_entrega.Enabled = True
        Me.txt_fecha_entrega.Focus()
        Me.cmd_guardar.Enabled = True
    End Sub


    Private Sub cargar_grilla_entregas()
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * "
        sql &= "FROM ENTREGA_INSUMOS "
        sql &= "ORDER BY fecha_entrega"
        tabla = acceso.consulta(sql)

        Me.dgv_detalle_entrega.Rows.Clear()
        Me.dgv_entrega.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_entrega.Rows.Add()
            Me.dgv_entrega.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
            Me.dgv_entrega.Rows(c).Cells("fecha_pedido").Value = tabla.Rows(c)("fecha_pedido")
            Me.dgv_entrega.Rows(c).Cells("fecha_entrega").Value = tabla.Rows(c)("fecha_entrega")
            Me.dgv_entrega.Rows(c).Cells("id_autoriza").Value = tabla.Rows(c)("id_autoriza")
            Me.dgv_entrega.Rows(c).Cells("cuie").Value = tabla.Rows(c)("id_efector")

            sql = ""
            sql &= "SELECT nombre FROM EFECTORES where cuie='" & tabla.Rows(c)("id_efector") & "'"
            tabla2 = acceso.consulta(sql)
            Me.dgv_entrega.Rows(c).Cells("efector").Value = tabla2.Rows(0)("nombre")

            sql = ""
            sql &= "SELECT nombres FROM EMPLEADOS WHERE id= " & tabla.Rows(c)("id_autoriza")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)
            Me.dgv_entrega.Rows(c).Cells("autoriza").Value = tabla2.Rows(0)("nombres")
        Next
    End Sub
    Private Sub cmd_buscar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_buscar_empleado.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim c As Integer = 0

        If txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar el cuie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_cuie.Focus()
            Exit Sub
        End If
        If txt_apellido.Text = "" And txt_nombre.Text = "" Then
            MessageBox.Show("¡Ingrese un valor para buscar por nombre y apellido o usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nombre.Focus()
            Exit Sub
        ElseIf txt_apellido.Text = "" And txt_nombre.Text <> "" Then
            MessageBox.Show("¡Ingrese un apellido para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_apellido.Focus()
            Exit Sub
        ElseIf txt_apellido.Text <> "" And txt_nombre.Text = "" Then
            MessageBox.Show("¡Ingrese un nombre para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nombre.Focus()
            Exit Sub
        ElseIf txt_apellido.Text <> "" And txt_nombre.Text <> "" Then
            sql = ""
            sql &= "SELECT EMP.id as id, EMP.usuario_sigipsa as usuario_sigipsa"
            sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EXE ON EMP.id = EXE.id_empleados "
            sql &= " WHERE EMP.nombres='" & Me.txt_nombre.Text & "' AND EMP.apellidos= '" & Me.txt_apellido.Text & "'"
            sql &= " AND EXE.id_efector='" & Me.txt_cuie.Text & "'"

            tabla = acceso.consulta(sql)
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontro id de empleado con esos datos para ese efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.txt_id_empleado.Text = tabla.Rows(0)("id")
            End If
        End If
    End Sub


End Class