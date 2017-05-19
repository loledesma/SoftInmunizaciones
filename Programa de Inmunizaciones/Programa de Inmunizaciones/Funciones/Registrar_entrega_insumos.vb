Public Class Registrar_entrega_insumos

    Enum condicion
        modificar
        insertar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_inicial As condicion = condicion.insertar
    Dim condicion_click As doble_Click = doble_Click.desactivado
    Private Sub cmd_busca_efector_Click(sender As Object, e As EventArgs)
        listados_efector_loc_dpto.ShowDialog()
    End Sub


    Private Sub cmd_ver_stock_Click(sender As Object, e As EventArgs) Handles cmd_ver_stock.Click
        Registrar_ingreso_stock.ShowDialog()
    End Sub

    Private Sub Registrar_entrega_insumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla_entregas()
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        acceso.autocompletar(txt_nombre_efector, "EFECTORES", "nombre")
        acceso.autocompletar(txt_nro_serie, "STOCK_INSUMOS", "nro_serie")
        acceso.autocompletar(txt_modelo, "STOCK_INSUMOS", "modelo")
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_entrega.Focus()
        Me.cmb_marca.cargar()
        Me.cmb_estado_entrega.cargar()
        Me.cmb_insumos.cargar()
        cargar_combo()
        Me.cmb_autorizador.SelectedIndex = -1
        Me.cmb_estado_entrega.SelectedIndex = -1
        Me.cmb_insumos.SelectedIndex = -1
        Me.cmb_marca.SelectedIndex = -1

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

    Private Sub txt_nro_serie_LostFocus(sender As Object, e As EventArgs) Handles txt_nro_serie.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""

        If Me.condicion_click = doble_Click.desactivado Then
            sql &= "SELECT * FROM STOCK_INSUMOS WHERE nro_serie='" & Me.txt_nro_serie.Text & "'"
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count() = 0 Then
                MsgBox("Ese nro de serie no corresponde a un insumo registrado en stock")
                If MessageBox.Show("¿Desea ingresar un insumo nuevo a stock?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                    Registrar_ingreso_stock.ShowDialog()
                Else
                    Exit Sub
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
        condicion_inicial = condicion.insertar
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
    Private Sub Registrar_entrega_insumos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
            ElseIf Me.cmb_estado_entrega.SelectedValue = 4 Then
                MsgBox("Debe usar el boton de devolucion para cambiar el estado a modificad/devuelto")
            End If
        End If
        cargar_grilla_entregas()
        limpiar(Me.Controls)
        Me.txt_observaciones.Text = ""
    End Sub



    Private Sub registrar_entrega()
        Dim sql As String = ""
        Dim tabla As New DataTable

        If validar_pedido() Then
            If validar_entrega() Then
                If dgv_detalle_entrega.Rows.Count() = 0 Then
                    MessageBox.Show("Debe ingresar los insumos que se entregaron")
                    cmb_insumos.Focus()
                    Exit Sub
                Else
                    If validar_stock() Then
                        Dim c As Integer = 0
                        For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
                            sql = ""
                            sql &= "SELECT cantidad FROM STOCK_INSUMOS WHERE id_insumo= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
                            sql &= " and nro_serie= '" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value & "'"
                            tabla = acceso.consulta(sql)

                            If tabla.Rows(0)("cantidad") = 0 Then
                                MsgBox("No hay stock para ese insumo")
                                Exit Sub
                            Else
                                sql = ""
                                sql &= "UPDATE DETALLE_ENTREGA_INSUMOS "
                                sql &= " SET cantidad= " & Me.dgv_detalle_entrega.Rows(c).Cells("cantidad").Value
                                sql &= " , nro_serie='" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value & "'"
                                sql &= " , modelo='" & Me.dgv_detalle_entrega.Rows(c).Cells("modelo").Value & "'"
                                sql &= " , id_marca= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_marca").Value
                                sql &= " WHERE id_entrega= " & Me.txt_id_entrega.Text & " AND id_insumo= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
                                acceso.ejecutar(sql)
                            End If
                        Next

                        sql = ""
                        sql &= "SELECT * FROM DETALLE_ENTREGA_INSUMOS WHERE id_entrega= " & Me.txt_id_entrega.Text
                        tabla.Clear()
                        tabla = acceso.consulta(sql)

                        sql = ""
                        sql &= "UPDATE ENTREGA_INSUMOS "
                        sql &= " SET id_estado_entrega= " & Me.cmb_estado_entrega.SelectedValue
                        sql &= " , receptor= '" & Me.txt_receptor.Text & "'"
                        sql &= " , fecha_entrega= '" & Me.txt_fecha_entrega.Text & "'"
                        If txt_observaciones.Text <> "" Then
                            sql &= ", observaciones='" & Me.txt_observaciones.Text & "'"
                        End If
                        sql &= " WHERE id= " & Me.txt_id_entrega.Text
                        acceso.ejecutar(sql)

                        descontar_stock()
                    End If
                End If
            End If
        Else
            Exit Sub
        End If


    End Sub

    Private Sub descontar_stock()
        Dim tabla As DataTable
        Dim sql As String = ""
        Dim cantidad As Integer = 0


        For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
            sql = ""
            sql = "SELECT cantidad FROM STOCK_INSUMOS WHERE id_insumo= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
            sql &= " AND nro_serie='" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value & "'"
            tabla = acceso.consulta(sql)


            If tabla.Rows.Count() <> 0 Then
                cantidad = tabla.Rows(0)("cantidad") - Convert.ToInt16(dgv_detalle_entrega.Rows(c).Cells("cantidad").Value)
                sql = ""
                sql &= " UPDATE STOCK_INSUMOS SET cantidad= " & cantidad
                sql &= " WHERE id_insumo= " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
                sql &= " and nro_serie= '" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value & "'"
                acceso.ejecutar(sql)
            End If


            tabla.Clear()
        Next
    End Sub
    Private Sub registrar_rechazo()
        Dim sql As String = ""
        Dim tabla As New DataTable

        If validar_entrega() Then
            sql &= "UPDATE ENTREGA_INSUMOS "
            sql &= " SET id_estado_entrega= " & Me.cmb_estado_entrega.SelectedValue
            sql &= ", fecha_entrega='" & Me.txt_fecha_entrega.Text & "'"
            sql &= " WHERE id= " & Me.txt_id_entrega.Text
            acceso.ejecutar(sql)

        Else
            Exit Sub
        End If
    End Sub
    Private Sub dgv_detalle_entrega_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_detalle_entrega.CellMouseDoubleClick
        Dim tabla As DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM DETALLE_ENTREGA_INSUMOS WHERE id_entrega= " & Me.txt_id_entrega.Text
        sql &= " AND nro_serie= '" & Me.dgv_detalle_entrega.CurrentRow.Cells("nro_serie").Value & "'"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No está cargado aun ese detalle!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Me.cmb_insumos.SelectedValue = tabla.Rows(0)("id_insumo")
            Me.txt_cantidad.Text = tabla.Rows(0)("cantidad")
            Me.txt_nro_serie.Text = tabla.Rows(0)("nro_serie")
            Me.cmb_marca.SelectedValue = tabla.Rows(0)("id_marca")
            Me.txt_modelo.Text = tabla.Rows(0)("modelo")
        End If

    End Sub

    Private Sub dgv_entrega_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_entrega.CellMouseDoubleClick
        condicion_inicial = condicion.modificar
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
            MessageBox.Show("¡La entrega buscada no se encuentra registrado todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        If IsDBNull(tabla.Rows(0)("receptor")) Then
            txt_receptor.Text = ""
            
        Else
            txt_receptor.Text = tabla.Rows(0)("receptor")
        End If

        If IsDBNull(tabla.Rows(0)("observaciones")) Then
            txt_observaciones.Text = ""
        Else
            txt_observaciones.Text = tabla.Rows(0)("observaciones")
        End If

        sql = ""
        sql &= " SELECT DEI.id_entrega as id_entrega, DEI.id_insumo as id_insumo, DEI.cantidad as cantidad "
        sql &= ", I.descripcion as insumo, DEI.nro_serie as nro_serie, DEI.modelo as modelo, DEI.id_marca as id_marca "
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
                dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value = tabla2.Rows(c)("nro_serie")
                dgv_detalle_entrega.Rows(c).Cells("id_marca").Value = tabla2.Rows(c)("id_marca")
                dgv_detalle_entrega.Rows(c).Cells("modelo").Value = tabla2.Rows(c)("modelo")
            Next
        End If

        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = True
        cmd_agregar_insumo.Enabled = True
        cmd_eliminar_insumo.Enabled = False
        cmd_actualizar_estado.Enabled = True
    End Sub

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM ENTREGA_INSUMOS "
        sql &= " WHERE fecha_pedido ='" & Me.txt_fecha_pedido.Text & "'"
        sql &= " AND id_efector= '" & Me.txt_cuie.Text & "'"
        sql &= " AND id_estado_entrega= 2"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

        Return True
    End Function

    Private Function validar_stock() As Boolean
        Dim sql As String = ""
        Dim tabla As New DataTable

        Dim c As Integer = 0

        For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
            sql = ""
            sql &= " SELECT * FROM STOCK_INSUMOS WHERE id_insumo=" & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value
            sql &= " AND nro_serie ='" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value & "'"
            sql &= " AND modelo='" & Me.dgv_detalle_entrega.Rows(c).Cells("modelo").Value & "'"
            sql &= " AND id_marca=" & Me.dgv_detalle_entrega.Rows(c).Cells("id_marca").Value
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count() = 0 Then
                MessageBox.Show("El insumo " & Me.dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value & " que trata de entregar no corresponde a un insumo en stock, verifique la grilla")
                Return False
                Exit Function
            End If
        Next


        Return True
    End Function

    Private Function existe_inventario() As Boolean
        Dim c As Integer = 0
        For c = 0 To dgv_detalle_entrega.Rows.Count - 1
            If dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 1 Or dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 4 Or dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 5 Then
                Return True
            Else
                Return False
            End If
        Next
    End Function
    Private Sub guardar()
        If condicion_inicial = condicion.insertar Then
            If Me.validar_pedido() = True Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    If dgv_detalle_entrega.Rows.Count = 0 Then
                        MessageBox.Show("Debe ingresar los insumos pedidos")
                        Exit Sub
                    Else
                        Me.insertar_pedido()
                        Me.insertar_detalle_entrega()

                        If cmb_estado_entrega.SelectedValue = 1 Then
                            registrar_entrega()
                        End If


                        If existe_inventario() = True Then
                            actualizar_inventario()
                        End If

                    End If
                Else
                    MessageBox.Show("Ya se encuentra registrado este pedido, debe cambiar el estado")
                End If
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Debe actualizar el estado si desea realizar algun cambio")
        End If



        dgv_detalle_entrega.Rows.Clear()
        dgv_entrega.Rows.Clear()
        Me.limpiar(Me.Controls)
        Me.cargar_grilla_entregas()
        Me.txt_observaciones.Text = ""
        Me.txt_id_entrega.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Sub actualizar_inventario()
        MessageBox.Show("No se olvide de actualizar el inventario de cadena de frio")
        Inventario_cadena_de_frio.txt_cuie.Text = Me.txt_cuie.Text
        Inventario_cadena_de_frio.txt_efector.Text = Me.txt_nombre_efector.Text
        If txt_fecha_entrega.Text <> "" Then
            Inventario_cadena_de_frio.txt_fecha_info.Text = Me.txt_fecha_entrega.Text
        End If

        'Dim c As Integer = 0
        'For c = 0 To dgv_detalle_entrega.Rows.Count - 1
        '    If dgv_detalle_entrega.Rows.Count() <> 0 Then
        '        If dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 1 Then
        '            Inventario_cadena_de_frio.cmb_marca_heladera.SelectedValue = dgv_detalle_entrega.Rows(c).Cells("id_marca").Value
        '            Inventario_cadena_de_frio.txt_nro_serie_heladera.Text = dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value
        '            Inventario_cadena_de_frio.txt_modelo_heladera.Text = dgv_detalle_entrega.Rows(c).Cells("modelo").Value
        '            Inventario_cadena_de_frio.cmb_tipo_heladera.Focus()
        '        ElseIf dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 4 Then
        '            Inventario_cadena_de_frio.txt_tipo_termo.Text = dgv_detalle_entrega.Rows(c).Cells("modelo").Value
        '        ElseIf dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = 5 Then

        '        End If
        '    End If

        'Next

        Inventario_cadena_de_frio.ShowDialog()
    End Sub


    Private Sub nuevo()
        limpiar(Me.Controls)
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

        Me.dgv_detalle_entrega.Rows.Clear()
        Me.txt_id_entrega.Enabled = False
        Me.cmb_estado_entrega.Enabled = True
        Me.txt_fecha_entrega.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_actualizar_estado.Enabled = False
    End Sub

    Private Function validar_entrega() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_id_entrega.Text = "" Then
            MessageBox.Show("Debe ingresar el id de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_entrega.Focus()
            Exit Function
        ElseIf txt_receptor.Text = "" Then
            MessageBox.Show("Debe ingresar al menos un nombre de receptor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_receptor.Focus()
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

    Private Function validar_pedido() As Boolean
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
            MessageBox.Show("Debe ingresar una fecha de pedido valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_pedido.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_entrega.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de entrega valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    'Private Sub cmd_buscar_empleado_Click(sender As Object, e As EventArgs)
    '    Dim sql As String = ""
    '    Dim tabla As New DataTable
    '    Dim c As Integer = 0

    '    If txt_cuie.Text = "" Then
    '        MessageBox.Show("Debe ingresar el cuie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_cuie.Focus()
    '        Exit Sub
    '    End If
    '    If txt_receptor.Text = "" And txt_nombre.Text = "" Then
    '        MessageBox.Show("¡Ingrese un valor para buscar por nombre y apellido o usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_nombre.Focus()
    '        Exit Sub
    '    ElseIf txt_receptor.Text = "" And txt_nombre.Text <> "" Then
    '        MessageBox.Show("¡Ingrese un apellido para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_receptor.Focus()
    '        Exit Sub
    '    ElseIf txt_receptor.Text <> "" And txt_nombre.Text = "" Then
    '        MessageBox.Show("¡Ingrese un nombre para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_nombre.Focus()
    '        Exit Sub
    '    ElseIf txt_receptor.Text <> "" And txt_nombre.Text <> "" Then
    '        sql = ""
    '        sql &= "SELECT EMP.id as id, EMP.usuario_sigipsa as usuario_sigipsa"
    '        sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EXE ON EMP.id = EXE.id_empleados "
    '        sql &= " WHERE EMP.nombres='" & Me.txt_nombre.Text & "' AND EMP.apellidos= '" & Me.txt_receptor.Text & "'"
    '        sql &= " AND EXE.id_efector='" & Me.txt_cuie.Text & "'"

    '        tabla = acceso.consulta(sql)
    '        If tabla.Rows.Count = 0 Then
    '            MessageBox.Show("No se encontro id de empleado con esos datos para ese efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            Me.txt_id_empleado.Text = tabla.Rows(0)("id")
    '        End If
    '    End If
    'End Sub

    Private Sub insertar_pedido()
        Dim sql As String = ""
        Dim fecha As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim tabla As New DataTable
        acceso._nombre_tabla = "ENTREGA_INSUMOS"

        sql = "id = " & Me.txt_id_entrega.Text
        sql &= ", fecha_pedido='" & Me.txt_fecha_pedido.Text & "'"

        If IsDate(txt_fecha_entrega.Text) Then
            sql &= ", fecha_entrega ='" & Me.txt_fecha_entrega.Text & "'"
        Else
            sql &= ", fecha_entrega =Null"
        End If

        If txt_receptor.Text <> "" Then
            sql &= ", receptor=" & Me.txt_receptor.Text
        Else
            sql &= ", receptor=Null"
        End If


        sql &= ", id_estado_entrega= " & Me.cmb_estado_entrega.SelectedValue
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
            sql &= ", nro_serie=" & Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value
            sql &= ", id_marca=" & Me.dgv_detalle_entrega.Rows(c).Cells("id_marca").Value
            sql &= ", modelo=" & Me.dgv_detalle_entrega.Rows(c).Cells("modelo").Value

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
        Me.txt_modelo.Text = ""
        Me.cmb_insumos.SelectedIndex = -1
        Me.cmb_marca.SelectedIndex = -1
        Me.txt_nro_serie.Text = ""
        Me.cmd_agregar_efector.Enabled = True
        Me.cmd_eliminar_insumo.Enabled = True
    End Sub

    Private Sub cmd_agregar_insumo_Click(sender As Object, e As EventArgs) Handles cmd_agregar_insumo.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cuenta As Integer
        Dim flag As Boolean = False
        Dim c As Integer = 0

        If validar_pedido() = True Then
            For c = 0 To dgv_detalle_entrega.Rows.Count() - 1
                If Me.cmb_insumos.SelectedValue = dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value And Me.txt_nro_serie.Text = Me.dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value Then
                    cuenta = Convert.ToInt16(txt_cantidad.Text) + Convert.ToInt16(dgv_detalle_entrega.Rows(c).Cells("cantidad").Value)
                    dgv_detalle_entrega.Rows(c).Cells("cantidad").Value = cuenta
                    dgv_detalle_entrega.Rows(c).Cells("id_insumo").Value = cmb_insumos.SelectedValue
                    dgv_detalle_entrega.Rows(c).Cells("id_marca").Value = cmb_marca.SelectedValue
                    dgv_detalle_entrega.Rows(c).Cells("modelo").Value = txt_modelo.Text
                    dgv_detalle_entrega.Rows(c).Cells("nro_serie").Value = txt_nro_serie.Text

                    sql = ""
                    sql &= "SELECT descripcion FROM INSUMOS WHERE id = " & cmb_insumos.SelectedValue
                    tabla.Clear()
                    tabla = acceso.consulta(sql)
                    dgv_detalle_entrega.Rows(c).Cells("insumo").Value = tabla.Rows(0)("descripcion")

                    flag = True
                End If
            Next
            If flag = False Then
                dgv_detalle_entrega.Rows.Add()
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("id_insumo").Value = Me.cmb_insumos.SelectedValue
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("cantidad").Value = Me.txt_cantidad.Text
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("id_marca").Value = cmb_marca.SelectedValue
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("modelo").Value = txt_modelo.Text
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("nro_serie").Value = txt_nro_serie.Text

                sql = ""
                sql &= "SELECT descripcion FROM INSUMOS WHERE id = " & cmb_insumos.SelectedValue
                tabla.Clear()
                tabla = acceso.consulta(sql)
                dgv_detalle_entrega.Rows(dgv_detalle_entrega.Rows.Count - 1).Cells("insumo").Value = tabla.Rows(0)("descripcion")

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

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.condicion_inicial = condicion.modificar
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""

        If IsDate(txt_fecha_pedido.Text) = False Then
            MessageBox.Show("¡Debe ingresar una fecha para buscar!")
            Exit Sub
        ElseIf txt_cuie.Text = "" Then
            MessageBox.Show("¡Debe ingresar un efector para buscar!")
            Exit Sub
        End If
        sql &= "SELECT * FROM ENTREGA_INSUMOS "
        sql &= " WHERE fecha_pedido='" & Me.txt_fecha_pedido.Text & "'"
        sql &= " AND id_efector='" & Me.txt_cuie.Text & "'"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe el pedido solicitado!")
            Exit Sub
        Else
            Dim c As Integer = 0
            dgv_entrega.Rows.Clear()
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
        End If


        limpiar(Me.Controls)
        Me.condicion_inicial = condicion.modificar
    End Sub

    Private Function validar_detalle() As Boolean
        If IsNumeric(txt_id_entrega.Text) = False Then
            MessageBox.Show("Debe ingresar un pedido para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_cantidad.Focus()
            Exit Function
        ElseIf IsNumeric(txt_cantidad.Text) = False Then
            MessageBox.Show("Debe ingresar un numero en la cantidad o seleccionar un insumo de un pedido de la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_cantidad.Focus()
            Exit Function
        ElseIf txt_nro_serie.Text = "" Then
            MessageBox.Show("Debe ingresar un efector o seleccionar un insumo de un pedido de la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nro_serie.Focus()
            Exit Function
        ElseIf txt_modelo.Text = "" Then
            MessageBox.Show("Debe ingresar un modelo o seleccionar un insumo de un pedido de la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_modelo.Focus()
            Exit Function
        ElseIf cmb_insumos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un insumo o seleccionar un insumo de un pedido de la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_insumos.Focus()
            Exit Function
        ElseIf cmb_marca.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una marca o seleccionar un insumo de un pedido de la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_estado_entrega.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Sub devolver_stock()
        Dim sql As String = ""
        acceso._nombre_tabla = "STOCK_INSUMOS"

        sql &= "id_insumo = " & Me.cmb_insumos.SelectedValue
        sql &= ", nro_serie =" & Me.txt_nro_serie.Text
        sql &= ", cantidad= " & Me.txt_cantidad.Text
        sql &= ", modelo=" & Me.txt_modelo.Text
        sql &= ", id_marca =" & Me.cmb_marca.SelectedValue

        acceso.insertar(sql)

    End Sub
    Private Sub cmd_devolucion_Click(sender As Object, e As EventArgs) Handles cmd_devolucion.Click
        Dim sql As String = ""
        If MessageBox.Show("¿Desea registrar el reingreso de un insumo al stock?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            If validar_detalle() Then
                devolver_stock()
                MsgBox("No olvide registrar en observaciones cual fue la devolucion realizada")
                If txt_observaciones.Text = "" Then
                    MsgBox("Debe registrar en observaciones cual fue la devolucion realizada")
                Else
                    sql = ""
                    sql &= "UPDATE ENTREGA_INSUMOS "
                    sql &= " SET observaciones='" & Me.txt_observaciones.Text & "'"
                    sql &= ", id_estado_entrega= 4"
                    sql &= " WHERE id= " & txt_id_entrega.Text
                  
                    acceso.ejecutar(sql)
                    MsgBox("Devolucion Realizada")
                    cargar_grilla_entregas()
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class