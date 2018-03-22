Public Class Registrar_peticiones_desarrollos
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

    Private Sub Registrar_atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)
        cargar_grilla()
        cmb_estado_pedido.cargar()
        Me.cmb_estado_pedido.SelectedIndex = -1
        cargar_combo()
        Me.txt_id_desarrollo.Focus()
        Me.cmb_empleados.SelectedIndex = -1
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub Registrar_atencion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub

    Private Sub cargar_combo()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT E.id as id, E.nombres as nombre, EMP.id_cargo "
        sql &= " FROM EMPLEADOS E JOIN EMPLEADOSXEFECTOR EMP ON E.id = EMP.id_empleados "
        sql &= " WHERE EMP.id_cargo = 1 "

        tabla = acceso.consulta(sql)

        Me.cmb_empleados.DataSource = tabla
        Me.cmb_empleados.DisplayMember = "nombre"
        Me.cmb_empleados.ValueMember = "id"
    End Sub
    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim tabla2 As New DataTable

        sql &= "SELECT * "
        sql &= " FROM PEDIDO_DESARROLLO "
        sql &= " WHERE id_estados_pedidos= 2"
        sql &= " ORDER BY fecha_pedido desc "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0

        dgv_pedidos.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            dgv_pedidos.Rows.Add()
            dgv_pedidos.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
            dgv_pedidos.Rows(c).Cells("fecha_pedido").Value = tabla.Rows(c)("fecha_pedido")

            If IsDBNull(tabla.Rows(c)("fecha_solucion")) = True Then
                dgv_pedidos.Rows(c).Cells("fecha_solucion").Value = "NULL"
            Else
                dgv_pedidos.Rows(c).Cells("fecha_solucion").Value = tabla.Rows(c)("fecha_solucion")
            End If

            dgv_pedidos.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estados_pedidos")
            dgv_pedidos.Rows(c).Cells("solicitado").Value = tabla.Rows(c)("descripcionSolicitud")

            If IsDBNull(tabla.Rows(c)("descripcionRespuesta")) = True Then
                dgv_pedidos.Rows(c).Cells("respuesta").Value = "NULL"
            Else
                dgv_pedidos.Rows(c).Cells("respuesta").Value = tabla.Rows(c)("descripcionRespuesta")
            End If


            dgv_pedidos.Rows(c).Cells("id_administrador").Value = tabla.Rows(c)("id_administrador")
            dgv_pedidos.Rows(c).Cells("desarrollador").Value = tabla.Rows(c)("desarrollador")

            sql = ""
            sql &= "SELECT descripcion as estado FROM ESTADOS_PEDIDOS WHERE id= " & tabla.Rows(c)("id_estados_pedidos")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)
            dgv_pedidos.Rows(c).Cells("estado").Value = tabla2.Rows(0)("estado")

            sql = ""
            sql &= "SELECT nombres FROM EMPLEADOS WHERE id=" & tabla.Rows(c)("id_administrador")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)
            dgv_pedidos.Rows(c).Cells("administrador").Value = tabla2.Rows(0)("nombres")
        Next

    End Sub
    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub Registrar_atencion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub limpiar(ByVal de_donde As Object)
        Me.condicion_estado = condicion.insertar
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

    Private Sub dgv_pedidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_pedidos.CellFormatting

        Dim estado As String = Me.dgv_pedidos.Rows(e.RowIndex).Cells("estado").Value

        If estado = "PENDIENTE" Then
            e.CellStyle.BackColor = Color.Yellow
        ElseIf estado = "RECHZADO" Then
            e.CellStyle.BackColor = Color.Red
        End If

    End Sub

    Private Sub dgv_pedidos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_pedidos.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim sql As String = ""
        limpiar(Controls)


        sql &= "SELECT * FROM PEDIDO_DESARROLLO "
        sql &= " WHERE id= " & dgv_pedidos.CurrentRow.Cells("id").Value
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_id_desarrollo.Text = Me.dgv_pedidos.CurrentRow.Cells("id").Value
        Me.txt_fecha_pedido.Text = tabla.Rows(0)("fecha_pedido")

        If IsDBNull(tabla.Rows(0)("fecha_solucion")) = True Then
            txt_fecha_solucion.Text = "NULL"
        Else
            txt_fecha_solucion.Text = tabla.Rows(0)("fecha_solucion")
        End If

        Me.cmb_estado_pedido.SelectedValue = tabla.Rows(0)("id_estados_pedidos")
        Me.cmb_empleados.SelectedValue = tabla.Rows(0)("id_administrador")
        Me.txt_solicitado.Text = tabla.Rows(0)("descripcionSolicitud")


        If IsDBNull(tabla.Rows(0)("descripcionRespuesta")) = True Then
            Me.txt_respuesta.Text = "NULL"
        Else
            Me.txt_respuesta.Text = tabla.Rows(0)("descripcionRespuesta")
        End If

        Me.txt_desarrollador.Text = tabla.Rows(0)("desarrollador")

        Me.cmd_eliminar.Enabled = True
        Me.condicion_click = doble_Click.desactivado
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub abm_empleados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.nuevo()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        guardar()
    End Sub

    Private Function validar()
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If cmb_empleados.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un administrador!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_empleados.Focus()
            Return False
            Exit Function
        ElseIf cmb_estado_pedido.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado de la atención!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_pedido.Focus()
            Return False
            Exit Function
        ElseIf txt_fecha_pedido.Text > hoy Then
            MessageBox.Show("Debe ingresar una fecha correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_pedido.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_pedido.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_pedido.Focus()
            Exit Function
        End If
        Return True
    End Function



    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM PEDIDO_DESARROLLO "
        sql &= "WHERE id =" & Me.txt_id_desarrollo.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub insertar()
        Dim sql As String = ""
        acceso._nombre_tabla = "PEDIDO_DESARROLLO"

        sql &= "fecha_pedido ='" & Me.txt_fecha_pedido.Text & "'"

        If IsDate(txt_fecha_solucion.Text) Then
            sql &= ", fecha_solucion='" & Me.txt_fecha_solucion.Text & "'"
        Else
            sql &= ", fecha_solucion= NULL"
        End If

        If txt_respuesta.Text = "" Then
            sql &= ", descripcionRespuesta = NULL"
        Else
            sql &= ", descripcionRespuesta = " & Me.txt_respuesta.Text
        End If

        sql &= ", id_estados_pedidos = " & Me.cmb_estado_pedido.SelectedValue
        sql &= ", descripcionSolicitud =" & Me.txt_solicitado.Text
        sql &= ", desarrollador= " & Me.txt_desarrollador.Text
        sql &= ", id_administrador =" & Me.cmb_empleados.SelectedValue
        acceso.insertar(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE PEDIDO_DESARROLLO "
        sql &= " SET fecha_pedido ='" & Me.txt_fecha_pedido.Text & "'"

        If IsDate(txt_fecha_solucion.Text) = False Then
            sql &= ", fecha_solucion= Null"
        Else
            sql &= ", fecha_solucion='" & Me.txt_fecha_solucion.Text & "'"
        End If

        sql &= ", id_estados_pedidos = " & Me.cmb_estado_pedido.SelectedValue
        sql &= ", id_administrador =" & Me.cmb_empleados.SelectedValue
        sql &= ", descripcionSolicitud ='" & Me.txt_solicitado.Text & "'"


        If txt_respuesta.Text = "" Then
            sql &= ", descripcionRespuesta = NULL"
        Else
            sql &= ", descripcionRespuesta ='" & Me.txt_respuesta.Text & "'"
        End If

        sql &= ", desarrollador ='" & Me.txt_desarrollador.Text & "'"
        sql &= " WHERE id = " & Me.txt_id_desarrollo.Text

        acceso.ejecutar(sql)
    End Sub

    Private Sub guardar()
        If Me.validar() = True Then
            If condicion_estado = condicion.insertar Then
                Me.insertar()
            Else
                Me.modificar()
            End If
        Else
            Exit Sub
        End If
        'Me.limpiar(Me.Controls)
        'Me.txt_descripcion.Text = ""
        Me.cargar_grilla()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
        limpiar(Controls)
        Me.txt_respuesta.Text = ""
        Me.txt_solicitado.Text = ""
    End Sub

    Private Sub nuevo()
        limpiar(Controls)
        Me.txt_respuesta.Text = ""
        Me.txt_solicitado.Text = ""
        Me.condicion_estado = condicion.insertar
        Me.txt_id_desarrollo.Enabled = False
        Me.cmb_empleados.Enabled = True
        Me.cmb_estado_pedido.Enabled = True
        Me.txt_fecha_pedido.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_eliminar.Enabled = False
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        If IsNumeric(Me.txt_id_desarrollo.Text) Then
            If MessageBox.Show("¿Esta seguro que desea borrar el registro?", _
             "Atencion", MessageBoxButtons.OKCancel, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                sql = "DELETE FROM PEDIDO_DESARROLLO "
                sql &= "WHERE id = " & Me.txt_id_desarrollo.Text
                acceso.ejecutar(sql)
            End If
        Else
            MessageBox.Show("El elemento no existe o ingrese un valor numérico")
            Me.txt_id_desarrollo.Focus()
            Exit Sub
        End If

        Me.txt_id_desarrollo.Enabled = True
        Me.txt_respuesta.Text = ""
        Me.txt_solicitado.Text = ""
        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
    End Sub

    Private Sub cmd_actualizar_estado_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_estado.Click
        Dim sql As String = ""
        Dim tabla As DataTable

        If txt_id_desarrollo.Text = "" Then
            MessageBox.Show("Seleccione una peticion para actualizar el estado")
            Me.txt_id_desarrollo.Focus()
            Exit Sub
        End If

        sql &= "SELECT * FROM PEDIDO_DESARROLLO WHERE id=" & Me.txt_id_desarrollo.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No se encuentra registrado ese pedido todavia")
            Me.txt_id_desarrollo.Focus()
            Exit Sub
        Else
            sql &= "UPDATE PEDIDO_DESARROLLO"
            sql &= " SET id_estados_pedidos= " & Me.cmb_estado_pedido.SelectedValue
            If txt_fecha_solucion.Text <> "" Then
                sql &= ", fecha_solucion='" & Me.txt_fecha_solucion.Text & "'"
            Else
                sql &= ", fecha_solucion= NULL"
            End If
            sql &= " WHERE id= " & Me.txt_id_desarrollo.Text
            acceso.ejecutar(sql)
        End If
        cargar_grilla()
    End Sub



    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.condicion_estado = condicion.modificar
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM PEDIDO_DESARROLLO "
        sql &= " WHERE fecha_pedido BETWEEN &'" & Me.txt_fecha_pedido.Text & "' AND '" & Me.txt_fecha_solucion.Text & "'"
        sql &= " ORDER BY id_administrador"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe el pedido en esa fecha!")
            Exit Sub
        Else
            Dim c As Integer = 0
            dgv_pedidos.Rows.Clear()
            For c = 0 To tabla.Rows.Count() - 1
                dgv_pedidos.Rows.Add()
                dgv_pedidos.Rows(c).Cells("id").Value = tabla.Rows(0)("id")
                dgv_pedidos.Rows(c).Cells("fecha_pedido").Value = tabla.Rows(0)("fecha_pedido")

                If IsDBNull(tabla.Rows(0)("fecha_solucion")) = True Then
                    dgv_pedidos.Rows(c).Cells("fecha_solucion").Value = "NULL"
                Else
                    dgv_pedidos.Rows(c).Cells("fecha_solucion").Value = tabla.Rows(0)("fecha_solucion")
                End If

                If IsDBNull(tabla.Rows(0)("descripcionRespuesta")) = True Then
                    dgv_pedidos.Rows(c).Cells("respuesta").Value = "NULL"
                Else
                    dgv_pedidos.Rows(c).Cells("respuesta").Value = tabla.Rows(0)("descripcionRespuesta")
                End If

                dgv_pedidos.Rows(c).Cells("id_estado").Value = tabla.Rows(0)("id_estados_pedidos")
                dgv_pedidos.Rows(c).Cells("desarrollador").Value = tabla.Rows(0)("desarrollador")
                dgv_pedidos.Rows(c).Cells("id_administrador").Value = tabla.Rows(0)("id_administrador")
                dgv_pedidos.Rows(c).Cells("solicitado").Value = tabla.Rows(0)("descripcionSolicitud")

                sql = ""
                sql &= "SELECT descripcion FROM ESTADOS_PEDIDOS WHERE id=" & Me.dgv_pedidos.Rows(c).Cells("id_estado").Value
                tabla2.Rows.Clear()
                tabla2 = acceso.consulta(sql)
                dgv_pedidos.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")

                sql = ""
                sql &= "SELECT nombres FROM EMPLEADOS WHERE id= " & Me.dgv_pedidos.Rows(c).Cells("id_administrador").Value
                tabla2.Rows.Clear()
                tabla2 = acceso.consulta(sql)
                dgv_pedidos.Rows(c).Cells("administrador").Value = tabla2.Rows(0)("nombres")

            Next
        End If


        limpiar(Me.Controls)
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_id_desarrollo.Enabled = True
        Me.grp_datos_recordatorio.Enabled = True
        Me.grp_descripcion.Enabled = True
        Me.txt_respuesta.Text = ""
        Me.txt_solicitado.Text = ""
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.txt_id_desarrollo.Focus()
        Me.cargar_grilla()
    End Sub

    Private Sub grp_datos_recordatorio_Enter(sender As Object, e As EventArgs) Handles grp_datos_recordatorio.Enter

    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick

    End Sub

    Private Sub dgv_pedidos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellValueChanged
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Dim sql As String = ""


        sql &= "SELECT COUNT(*) "
        sql &= "FROM PEDIDO_DESARROLLO "

        valor1 = acceso.contadores(sql)

        sql = "SELECT COUNT(*) "
        sql &= "FROM PEDIDO_DESARROLLO WHERE id_estados_pedidos = 2"
        valor2 = acceso.contadores(sql)

        lbl_contador_pendientes.Text = valor2
        lbl_contador_total.Text = valor1
    End Sub
End Class