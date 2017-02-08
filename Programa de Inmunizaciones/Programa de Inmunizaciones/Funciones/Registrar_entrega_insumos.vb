Public Class Registrar_entrega_insumos

   

    Enum analizar_existencia
        existe
        no_existe
    End Enum


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
            guardar()
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
        guardar()
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
        Dim sql As String = ""
        Dim tabla As New DataTable

        If validar_entrega() Then
            If validar_detalle() Then
                If dgv_detalle_entrega.Rows.Count() = 0 Then
                    MessageBox.Show("Debe ingresar los insumos que se entregaron")
                    cmb_insumos.Focus()
                    Exit Sub
                Else
                    Dim c As Integer = 0
                    For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
                        sql = ""
                        sql &= "UPDATE DETALLE_ENTREGA_INSUMOS "
                        sql &= " SET id_entrega= " & Me.txt_id_entrega.Text
                        sql &= ", id_insumo= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
                        sql &= ", cantidad= " & Me.dgv_detalle_entrega.Rows(c).Cells("cantidad").Value
                        acceso.ejecutar(sql)
                    Next

                    sql = ""
                    sql &= "UPDATE ENTREGA_INSUMOS "
                    sql &= " SET id_estado_entrega= " & Me.cmb_estado_entrega.SelectedValue
                    sql &= " , id_receptor= " & Me.txt_id_empleado.Text
                    sql &= " , fecha_entrega= '" & Me.txt_fecha_entrega.Text & "'"

                    If txt_observaciones.Text <> "" Then
                        sql &= ", observaciones='" & Me.txt_observaciones.Text & "'"
                    End If

                    sql &= " WHERE id= " & Me.txt_id_entrega.Text
                    acceso.ejecutar(sql)
                    
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub registrar_rechazo()
        Dim sql As String = ""
        Dim tabla As New DataTable

        If validar_entrega() Then
            sql &= "UPDATE FROM ENTREGA_INSUMOS "
            sql &= " SET id_estado_entrega= " & Me.cmb_estado_entrega.SelectedValue
            sql &= " WHERE id= " & Me.txt_id_entrega.Text
            acceso.ejecutar(sql)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub dgv_entrega_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_entrega.CellMouseDoubleClick
        dgv_detalle_entrega.Rows.Clear()
        limpiar(Controls)
        Me.cmd_guardar.Enabled = False
        Dim tabla As DataTable
        Dim tabla2 As DataTable

        Dim sql As String = ""
        Dim sql2 As String = ""

        sql &= "SELECT * FROM ENTREGA_INSUMOS WHERE id = " & Me.dgv_entrega.CurrentRow.Cells("id").Value
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡El empleado buscado no se encuentra registrado todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.txt_id_entrega.Text = tabla.Rows(0)("id")
        Me.txt_fecha_pedido.Text = tabla.Rows(0)("fecha_pedido")

        If IsDBNull(tabla.Rows(0)("fecha_entrega")) Then
            txt_fecha_entrega.Text = ""
        Else
            txt_fecha_entrega.Text = tabla.Rows(0)("fecha_entrega")
        End If
        Me.txt_cuie.Text = tabla.Rows(0)("id_efector")

        sql2 = ""
        sql2 &= "SELECT nombre FROM EFECTORES WHERE cuie='" & Me.txt_cuie.Text & "'"
        tabla2 = acceso.consulta(sql2)

        Me.txt_nombre_efector.Text = tabla2.Rows(0)("nombre")


        Me.cmb_estado_entrega.SelectedValue = tabla.Rows(0)("id_estado_entrega")
        Me.cmb_autorizador.SelectedValue = tabla.Rows(0)("id_autoriza")

        If IsDBNull(tabla.Rows(0)("id_receptor")) Then
            txt_id_empleado.Text = ""
            txt_nombre.Text = ""
            txt_apellido.Text = ""
        Else
            txt_id_empleado.Text = tabla.Rows(0)("id_receptor")

            sql = ""
            sql &= "SELECT * FROM EMPLEADOS WHERE id=" & Me.txt_id_empleado.Text
            tabla2 = acceso.consulta(sql)
            txt_nombre.Text = tabla2.Rows(0)("nombres")
            txt_apellido.Text = tabla2.Rows(0)("apellidos")
        End If

        If IsDBNull(tabla.Rows(0)("observaciones")) Then
            txt_observaciones.Text = ""
        Else
            txt_observaciones.Text = tabla.Rows(0)("observaciones")
        End If

        sql = ""
        sql &= " SELECT DEI.id_entrega as id_entrega, DEI.id_insumo as id_insumo, DEI.cantidad as cantidad "
        sql &= ", I.descripcion as insumo "
        sql &= " FROM DETALLE_ENTREGA_INSUMOS DEI JOIN INSUMOS I ON DEI.id_insumo = I.id "
        sql &= " WHERE DEI.id_entrega = " & Me.dgv_entrega.CurrentRow.Cells("id").Value
        tabla2.Clear()
        tabla2 = acceso.consulta(sql)

        If tabla2.Rows.Count = 0 Then
            MessageBox.Show("El pedido no tiene insumos asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmd_agregar_insumo.Enabled = True
            Me.cmd_eliminar_insumo.Enabled = False
        Else
            Me.cmd_eliminar_insumo.Enabled = True
            Me.cmd_agregar_insumo.Enabled = True
            Dim c As Integer = 0
            For c = 0 To tabla2.Rows.Count() - 1
                dgv_detalle_entrega.Rows.Add()
                dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = tabla2.Rows(c)("id_insumo")
                dgv_detalle_entrega.Rows(c).Cells("insumo").Value = tabla2.Rows(c)("insumo")
                dgv_detalle_entrega.Rows(c).Cells("cantidad").Value = tabla2.Rows(c)("cantidad")
            Next
        End If

        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = True
        cmd_agregar_insumo.Enabled = True
        cmd_eliminar_insumo.Enabled = False

    End Sub

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM ENTREGA_INSUMOS "
        sql &= " WHERE fecha_pedido = '" & Me.txt_fecha_pedido.Text & "'"
        sql &= " AND id_efector= '" & Me.txt_cuie.Text & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

        Return True
    End Function
    Private Sub guardar()
        If Me.validar_entrega() = True Then
            If Me.validar_existencia() = analizar_existencia.no_existe Then
                If dgv_detalle_entrega.Rows.Count = 0 Then
                    MessageBox.Show("Debe ingresar los insumos pedidos")
                    Exit Sub
                Else
                    Me.insertar_pedido()
                    Me.insertar_detalle_entrega()
                End If
            Else
                MessageBox.Show("Ya se encuentra registrado este pedido")
            End If
        Else
            Exit Sub
        End If

        dgv_detalle_entrega.Rows.Clear()
        dgv_entrega.Rows.Clear()
        Me.limpiar(Me.Controls)
        Me.cargar_grilla_entregas()
        Me.txt_id_entrega.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub


    Private Sub nuevo()
        limpiar(Controls)
        Me.txt_observaciones.Text = ""
        Me.txt_fecha_pedido.Text = ""
        Me.txt_fecha_entrega.Text = ""
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

    Private Function validar_detalle() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_id_entrega.Text = "" Then
            MessageBox.Show("Debe ingresar el id de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_entrega.Focus()
            Exit Function
        ElseIf txt_id_empleado.Text = "" Then
            MessageBox.Show("Debe ingresar un empleado que recibe o buscar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_empleado.Focus()
            Exit Function
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Debe ingresar un nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nombre.Focus()
            Exit Function
        ElseIf txt_apellido.Text = "" Then
            MessageBox.Show("Debe ingresar un apellido de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_apellido.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_entrega.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_entrega.Focus()
            Exit Function
        ElseIf txt_fecha_entrega.Text > hoy Then
            MessageBox.Show("Debe ingresar una fecha de entrega valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_entrega.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_entrega() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If IsNumeric(txt_id_entrega.Text) = False Then
            MessageBox.Show("Debe ingresar un numero de entrega valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_entrega.Focus()
            Exit Function
        ElseIf txt_nombre_efector.Text = "" Then
            MessageBox.Show("Debe ingresar un efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nombre_efector.Focus()
            Exit Function
        ElseIf txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar un efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_cuie.Focus()
            Exit Function
        ElseIf cmb_autorizador.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar quien recibio y/o autoriza el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_autorizador.Focus()
            Exit Function
        ElseIf cmb_estado_entrega.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado para el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_estado_entrega.Focus()
            Exit Function
        ElseIf txt_fecha_pedido.Text > hoy Then
            MessageBox.Show("Debe ingresar una fecha de alta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_pedido.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_pedido.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de pedido para ese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_pedido.Focus()
            Exit Function
        End If
        Return True
    End Function

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
            Me.dgv_entrega.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estado_entrega")

            sql = ""
            sql &= "SELECT nombre FROM EFECTORES where cuie='" & tabla.Rows(c)("id_efector") & "'"
            tabla2 = acceso.consulta(sql)
            Me.dgv_entrega.Rows(c).Cells("efector").Value = tabla2.Rows(0)("nombre")

            sql = ""
            sql &= "SELECT nombres FROM EMPLEADOS WHERE id= " & tabla.Rows(c)("id_autoriza")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)
            Me.dgv_entrega.Rows(c).Cells("autoriza").Value = tabla2.Rows(0)("nombres")

            sql = ""
            sql &= "SELECT descripcion FROM ESTADO_ENTREGA WHERE id= " & tabla.Rows(c)("id_estado_entrega")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)
            Me.dgv_entrega.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")
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

    Private Sub insertar_pedido()
        Dim sql As String = ""
        Dim fecha As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim tabla As New DataTable
        acceso._nombre_tabla = "ENTREGA_INSUMOS"

        sql = "id = " & Me.txt_id_entrega.Text
        sql &= " fecha_pedido= '" & Me.txt_fecha_pedido.Text & "'"
        If IsDate(txt_fecha_entrega.Text) Then
            sql &= ", fecha_entrega = '" & Me.txt_fecha_entrega.Text & "'"
        Else
            sql &= ", fecha_entrega =Null"
        End If

        If txt_id_empleado.Text <> "" Then
            sql &= ", id_receptor=" & Me.txt_id_empleado.Text
        Else
            sql &= ", id_receptor=Null"
        End If

        sql &= ", id_autoriza=" & Me.cmb_autorizador.SelectedValue
        sql &= " , id_efector=" & Me.txt_cuie.Text

        If txt_observaciones.Text <> "" Then
            sql &= ", observaciones = " & Me.txt_observaciones.Text
        Else
            sql &= ", observaciones = NULL"
        End If

        acceso.insertar(sql)

        sql = ""
        sql = "SELECT * FROM ENTREGA_INSUMOS WHERE id= " & Me.txt_id_entrega.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() <> 0 Then
            sql = ""
            sql &= "UPDATE ENTREGA_INSUMOS "
            sql &= " SET id_estado_entrega= 2"
            sql &= " WHERE id= " & Me.txt_id_entrega.Text
        End If
    End Sub

    Private Sub insertar_detalle_entrega()
        Dim sql As String = ""
        Dim fecha As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim tabla As New DataTable
        acceso._nombre_tabla = "DETALLE_ENTREGA_INSUMOS"

        Dim c As Integer
        For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
            sql &= "id_entrega = " & Me.txt_id_entrega.Text
            sql &= ", id_insumo = " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
            sql &= " , cantidad= " & Me.dgv_detalle_entrega.Rows(c).Cells("cantidad").Value

            acceso.insertar(sql)

            sql = ""
        Next
    End Sub


    Private Sub cmd_limpiar_insumo_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_insumo.Click
        limpiar_insumos()
    End Sub

    Private Sub limpiar_insumos()
        Me.cmb_insumos.SelectedIndex = -1
        Me.txt_cantidad.Text = ""
        Me.cmd_agregar_efector.Enabled = True
        Me.cmd_eliminar_insumo.Enabled = False
    End Sub

    Private Sub cmd_agregar_insumo_Click(sender As Object, e As EventArgs) Handles cmd_agregar_insumo.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0

        If validar_entrega() = True Then
            If validar_detalle() = True Then

                For c = 0 To dgv_detalle_entrega.Rows.Count - 1
                    If Me.cmb_insumos.SelectedValue = dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value Then
                        dgv_detalle_entrega.Rows(c).Cells("cantidad").Value = txt_id_empleado.Text
                       
                        sql = ""
                        sql &= "SELECT descripcion FROM INSUMOS WHERE id = " & dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
                        tabla.Clear()
                        tabla = acceso.consulta(sql)
                        dgv_detalle_entrega.Rows(c).Cells("insumo").Value = tabla.Rows(0)("descripcion")

                        flag = True
                    End If
                Next
                If flag = False Then
                    dgv_detalle_entrega.Rows.Add()
                    dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("id_insumo").Value = Me.txt_id_entrega.Text
                    dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("cantidad").Value = Me.txt_cantidad.Text
                  
                    sql = ""
                    sql &= "SELECT descripcion FROM INSUMOS WHERE id = " & dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("id_insumo").Value
                    tabla.Clear()
                    tabla = acceso.consulta(sql)
                    dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("insumo").Value = tabla.Rows(0)("descripcion")

                End If
            End If
        End If

        limpiar_insumos()
    End Sub

    Private Sub cmd_eliminar_insumo_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_insumo.Click
        Dim num As Integer = dgv_detalle_entrega.CurrentRow.Index
        For c = 0 To dgv_detalle_entrega.Rows.Count - 1
            If num = c Then
                dgv_detalle_entrega.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

End Class