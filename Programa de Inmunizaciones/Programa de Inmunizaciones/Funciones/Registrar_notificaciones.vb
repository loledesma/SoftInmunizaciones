Public Class Registrar_notificaciones
    Enum estado
        insertar
        modificar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Dim condicion_estado As estado = estado.insertar

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click As doble_Click = doble_Click.desactivado
    Private Sub Registrar_notificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Me.Controls)
        Me.cargar_grilla()
        lbl_contador_notif.Text = dgv_notificaciones.Rows.Count()
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_apellidos, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_nombres, "EMPLEADOS", "nombres")
        acceso.autocompletar(txt_usuario, "EMPLEADOS", "usuario_sigipsa")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        tip()
        Me.cmd_eliminar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_id_empleado.Focus()
        Me.cmb_departamentos.cargar()
        Me.cmb_localidades.cargar()
        Me.cmb_carga.cargar()
        Me.cmb_perdidas.cargar()
        Me.cmb_stock.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_carga.SelectedIndex = -1
        Me.cmb_perdidas.SelectedIndex = -1
        Me.cmb_stock.SelectedIndex = -1
        Me.txt_id_notificacion.Focus()


        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub tip()
        tltp_notificaciones.SetToolTip(cmd_efector_nuevo, "Dar de alta efector nuevo")
        tltp_notificaciones.SetToolTip(cmd_buscar_empleado, "Buscar id empleado")
        tltp_notificaciones.SetToolTip(cmd_buscar_notificaciones, "Buscar notificación")
        tltp_notificaciones.SetToolTip(cmd_empleado_nuevo, "Dar de alta empleado nuevo")
        tltp_notificaciones.SetToolTip(cmd_eliminar, "Eliminar")
        tltp_notificaciones.SetToolTip(cmd_guardar, "Guardar")
        tltp_notificaciones.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_notificaciones.SetToolTip(cmd_salir, "Salir")
        tltp_notificaciones.SetToolTip(cmd_limpiar, "Limpiar")
    End Sub
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.condicion_click = doble_Click.desactivado
        Me.txt_id_empleado.Enabled = True
        Me.grp_datos_generales.Enabled = True
        Me.grp_datos_notificacion.Enabled = True
        Me.grp_datos_empleados.Enabled = True
        Me.limpiar(Me.Controls)
        Me.cmd_eliminar.Enabled = False
        Me.condicion_estado = estado.insertar
        Me.txt_id_empleado.Focus()
        cargar_grilla()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT NE.id As id, NE.fecha As fecha, Ne.id_empleado As empleado, Ne.id_efector As cuie, E.nombre As nombre "
        sql &= ", C.descripcion As carga, S.descripcion As stock, P.descripcion As perdidas, C.id As id_carga, E.cuie As cuie "
        sql &= ", S.id As id_stock, P.id As id_perdidas "
        sql &= "FROM NOTIFICACIONXEFECTOR NE JOIN EFECTORES E ON NE.id_efector = E.cuie "
        sql &= " JOIN CARGA C ON NE.id_estado_carga = C.id"
        sql &= " JOIN STOCK S ON NE.id_estado_stock = S.id"
        sql &= " JOIN PERDIDAS P ON NE.id_estado_perdidas = P.id "
        sql &= "ORDER BY NE.fecha"
        tabla = acceso.consulta(sql)

        Me.dgv_notificaciones.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_notificaciones.Rows.Add()
            Me.dgv_notificaciones.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
            Me.dgv_notificaciones.Rows(c).Cells("nombre_efector").Value = tabla.Rows(c)("nombre")
            Me.dgv_notificaciones.Rows(c).Cells("carga").Value = tabla.Rows(c)("carga")
            Me.dgv_notificaciones.Rows(c).Cells("id_carga").Value = tabla.Rows(c)("id_carga")
            Me.dgv_notificaciones.Rows(c).Cells("stock").Value = tabla.Rows(c)("stock")
            Me.dgv_notificaciones.Rows(c).Cells("perdidas").Value = tabla.Rows(c)("perdidas")
            Me.dgv_notificaciones.Rows(c).Cells("id_stock").Value = tabla.Rows(c)("id_stock")
            Me.dgv_notificaciones.Rows(c).Cells("id_perdidas").Value = tabla.Rows(c)("id_perdidas")
            Me.dgv_notificaciones.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
            Me.dgv_notificaciones.Rows(c).Cells("id_efector").Value = tabla.Rows(c)("cuie")
        Next
    End Sub


    Private Sub limpiar(ByVal de_donde As Object)
        Me.condicion_estado = estado.insertar
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
    Private Sub Registrar_notificaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efectores.Text <> "" Then
                sql &= "SELECT E.cuie as cuie, D.id as id_dpto, L.id as id_localidad FROM EFECTORES E JOIN DEPARTAMENTOS D ON D.id = E.id_departamento join LOCALIDADES L ON L.id = E.id_localidad "
                sql &= " WHERE E.nombre= '" & txt_efectores.Text & "'"
                tabla = acceso.consulta(sql)

                If tabla.Rows.Count() <> 0 Then
                    txt_cuie.Text = tabla.Rows(0)("cuie")
                    cmb_departamentos.SelectedValue = tabla.Rows(0)("id_dpto")
                    cmb_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
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
                    txt_efectores.Text = tabla.Rows(0)("nombre")
                    cmb_departamentos.SelectedValue = tabla.Rows(0)("id_dpto")
                    cmb_localidades.SelectedValue = tabla.Rows(0)("id_localidad")

                End If
            End If
        End If
    End Sub


    Private Sub Registrar_notificaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Function validar() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
       
        If IsNumeric(Me.txt_id_notificacion.Text) = False Then
            MessageBox.Show("No se admiten caracteres en el ID", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_id_notificacion.Focus()
            Return False
            Exit Function
        ElseIf Me.txt_id_empleado.Text = "" Then
            MessageBox.Show("Debe seleccionar un id de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_id_empleado.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_carga.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_carga.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_perdidas.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de perdidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_perdidas.Focus()
            Return False
            Exit Function
        ElseIf Me.cmb_stock.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado de stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_stock.Focus()
            Return False
            Exit Function
        ElseIf Me.txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar el cuie", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_cuie.Focus()
            Return False
            Exit Function
        ElseIf Me.txt_fecha.Text = "" Then
            MessageBox.Show("Debe ingresar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_stock.Focus()
            Return False
            Exit Function
            'ElseIf Me.txt_fecha.Text >= hoy Then
            '    MessageBox.Show("Debe ingresar una fecha de alta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txt_fecha.Focus()
            '    Return False
            '    Exit Function
        End If
        Return True
    End Function

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM NOTIFICACIONXEFECTOR "
        sql &= "WHERE id = " & Me.txt_id_notificacion.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function

    Private Sub insertar()
        Dim sql As String = ""
        Dim id As Integer = 0
        id = obtenerId()
        acceso._nombre_tabla = "NOTIFICACIONXEFECTOR"


        sql &= "id = " & id
        sql &= ", fecha = '" & Me.txt_fecha.Text & "'"
        sql &= ", id_estado_carga = " & Me.cmb_carga.SelectedValue
        sql &= ", id_estado_stock = " & Me.cmb_stock.SelectedValue
        sql &= ", id_estado_perdidas = " & Me.cmb_perdidas.SelectedValue
        sql &= ", id_efector =" & Me.txt_cuie.Text
        sql &= ", id_empleado = " & Me.txt_id_empleado.Text

        acceso.insertar(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE NOTIFICACIONXEFECTOR "
        sql &= " SET fecha = '" & Me.txt_fecha.Text & "'"
        sql &= ", id_estado_carga = " & Me.cmb_carga.SelectedValue
        sql &= ", id_estado_stock= " & Me.cmb_stock.SelectedValue
        sql &= ", id_estado_perdidas= " & Me.cmb_perdidas.SelectedValue
        sql &= ", id_efector='" & Me.txt_cuie.Text & "'"
        sql &= ", id_empleado= " & Me.txt_id_empleado.Text
        sql &= " WHERE id = " & Me.txt_id_notificacion.Text

        acceso.ejecutar(sql)
    End Sub

    Private Function obtenerId()
        Dim id As Integer = 0
        Dim sqlId = ""
        Dim tablaId As New DataTable

        sqlId = "SELECT * FROM NOTIFICACIONXEFECTOR"
        tablaId = acceso.consulta(sqlId)

        If tablaId.Rows.Count = 0 Then
            id = 1
            txt_id_notificacion.Text = id
        Else
            Dim ultimo As Integer = tablaId.Rows.Count() - 1
            id = tablaId.Rows(ultimo)("id") + 1
            txt_id_notificacion.Text = id
        End If
        Return id
    End Function
    Private Sub guardar()

        If Me.validar() = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya se encuentra cargada esta notificación")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
        Else
            Exit Sub
        End If
        Me.limpiar(Me.Controls)
        Me.cargar_grilla()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Sub nuevo()
        Me.condicion_click = doble_Click.desactivado
        limpiar(Controls)
        Me.condicion_estado = estado.insertar
        Dim sql As String = "SELECT * FROM NOTIFICACIONXEFECTOR"
        Dim tabla As New DataTable
        tabla = acceso.consulta(sql)

        'If tabla.Rows.Count() = 0 Then
        '    Me.txt_id_notificacion.Text = 1
        'Else
        '    Dim ultimo As Integer = tabla.Rows.Count() - 1
        '    Me.txt_id_notificacion.Text = tabla.Rows(ultimo)("id") + 1
        'End If

        Me.txt_id_notificacion.Enabled = False
        Me.cmb_departamentos.Enabled = True
        Me.cmb_localidades.Enabled = True
        Me.txt_fecha.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_eliminar.Enabled = False
    End Sub

    Private Sub dgv_notificaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_notificaciones.CellDoubleClick
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM NOTIFICACIONXEFECTOR "
        sql &= "WHERE id = " & Me.dgv_notificaciones.CurrentRow.Cells(9).Value

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("NO EXISTE SELECCION")
            Exit Sub
        End If

        Me.txt_id_notificacion.Text = tabla.Rows(0)("id")
        Me.txt_fecha.Text = tabla.Rows(0)("fecha")
        Me.cmb_carga.SelectedValue = tabla.Rows(0)("id_estado_carga")
        Me.cmb_perdidas.SelectedValue = tabla.Rows(0)("id_estado_perdidas")
        Me.cmb_stock.SelectedValue = tabla.Rows(0)("id_estado_stock")

        sql = ""
        sql &= "SELECT * FROM EMPLEADOS "
        sql &= " WHERE id= " & tabla.Rows(0)("id_empleado")

        tabla2 = acceso.consulta(sql)

        Me.txt_id_empleado.Text = tabla2.Rows(0)("id")
        Me.txt_apellidos.Text = tabla2.Rows(0)("apellidos")
        Me.txt_nombres.Text = tabla2.Rows(0)("nombres")
        Me.txt_usuario.Text = tabla2.Rows(0)("usuario_sigipsa")

        sql = ""
        sql &= "SELECT * FROM EFECTORES "
        sql &= "WHERE cuie= '" & tabla.Rows(0)("id_efector") & "'"

        tabla3 = acceso.consulta(sql)

        Me.cmb_departamentos.SelectedValue = tabla3.Rows(0)("id_departamento")
        Me.cmb_localidades.SelectedValue = tabla3.Rows(0)("id_localidad")
        Me.txt_efectores.Text = tabla3.Rows(0)("nombre")
        Me.txt_cuie.Text = tabla.Rows(0)("id_efector")

        Me.grp_datos_empleados.Enabled = True
        Me.grp_datos_generales.Enabled = True
        Me.txt_id_empleado.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.condicion_click = doble_Click.desactivado
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        If IsNumeric(Me.txt_id_notificacion.Text) Then
            If MessageBox.Show("¿Esta seguro que desea borrar el registro?", _
             "Atencion", MessageBoxButtons.OKCancel, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                sql = "DELETE FROM NOTIFICACIONXEFECTOR "
                sql &= "WHERE id = " & Me.txt_id_notificacion.Text
                acceso.ejecutar(sql)
            End If
        Else
            MessageBox.Show("El elemento no existe o ingrese un valor numérico")
            Me.txt_id_notificacion.Focus()
            Exit Sub
        End If

        Me.txt_id_notificacion.Enabled = True
        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = estado.insertar
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

    Private Sub dgv_notificaciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_notificaciones.CellFormatting

        Dim carga As String = Me.dgv_notificaciones.Rows(e.RowIndex).Cells("carga").Value
        Dim stock As String = Me.dgv_notificaciones.Rows(e.RowIndex).Cells("stock").Value
        Dim perdidas As String = Me.dgv_notificaciones.Rows(e.RowIndex).Cells("perdidas").Value

        If carga = "AL DIA" And stock = "COINCIDE" And perdidas = "AL DIA" Then
            e.CellStyle.BackColor = Color.GreenYellow
        ElseIf carga = "ATRASADO" And stock = "NO COINCIDE" And perdidas = "ATRASADO" Then
            e.CellStyle.BackColor = Color.Red
        ElseIf carga = "NO INFORMA" Or stock = "NO INFORMA" Or perdidas = "NO INFORMA" Then
            e.CellStyle.BackColor = Color.Yellow
        End If
       

        'If perdidas = "AL DIA" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("perdidas").Style.BackColor = Color.GreenYellow
        'ElseIf perdidas = "ATRASADO" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("perdidas").Style.BackColor = Color.Yellow
        'ElseIf perdidas = "NO INFORMA" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("perdidas").Style.BackColor = Color.Red
        'End If


        'If stock = "COINCIDE" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("stock").Style.BackColor = Color.GreenYellow
        'ElseIf stock = "NO COINCIDE" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("stock").Style.BackColor = Color.Yellow
        'ElseIf stock = "NO INFORMA" Then
        '    Me.dgv_notificaciones.CurrentRow.Cells("stock").Style.BackColor = Color.Red
        'End If

    End Sub

    Private Sub cmd_efector_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_efector_nuevo.Click
        If MessageBox.Show("¿Desea agregar un efector nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Registrar_efectores.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    'Private Sub cmd_buscar_notificaciones_Click(sender As Object, e As EventArgs) Handles cmd_buscar_notificaciones.Click

    'End Sub

    Private Sub cmd_buscar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_buscar_empleado.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim c As Integer = 0

        If txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar el cuie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_cuie.Focus()
            Exit Sub
        End If
        If txt_apellidos.Text = "" And txt_nombres.Text = "" Then
            If txt_usuario.Text = "" Then
                MessageBox.Show("¡Ingrese un valor para buscar por nombre y apellido o usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_apellidos.Focus()
                Exit Sub
            ElseIf txt_usuario.Text <> "" Then
                sql = ""
                sql &= "SELECT EMP.id as id, EMP.nombres as nombres, EMP.apellidos as apellidos"
                sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EXE ON EMP.id = EXE.id_empleados "
                sql &= " WHERE EMP.usuario_sigipsa= '" & Me.txt_usuario.Text & "' AND EXE.id_efector ='" & Me.txt_cuie.Text & "'"

                tabla = acceso.consulta(sql)
                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No se encontró un empleado con el usuario: " & Me.txt_usuario.Text & " en ese efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.txt_id_empleado.Text = tabla.Rows(0)("id")
                    Me.txt_nombres.Text = tabla.Rows(0)("nombres")
                    Me.txt_apellidos.Text = tabla.Rows(0)("apellidos")
                End If
            End If
        Else
            If txt_apellidos.Text = "" And txt_nombres.Text <> "" Then
                MessageBox.Show("¡Ingrese un apellido para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_apellidos.Focus()
                Exit Sub
            ElseIf txt_apellidos.Text <> "" And txt_nombres.Text = "" Then
                MessageBox.Show("¡Ingrese un nombre para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_nombres.Focus()
                Exit Sub
            ElseIf txt_apellidos.Text <> "" And txt_nombres.Text <> "" Then
                sql = ""
                sql &= "SELECT EMP.id as id, EMP.usuario_sigipsa as usuario_sigipsa"
                sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EXE ON EMP.id = EXE.id_empleados "
                sql &= " WHERE EMP.nombres='" & Me.txt_nombres.Text & "' AND EMP.apellidos= '" & Me.txt_apellidos.Text & "'"
                sql &= " AND EXE.id_efector='" & Me.txt_cuie.Text & "'"

                tabla = acceso.consulta(sql)
                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No se encontro id de empleado con esos datos para ese efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.txt_id_empleado.Text = tabla.Rows(0)("id")
                    Me.txt_usuario.Text = tabla.Rows(0)("usuario_sigipsa")
                End If
            End If
        End If

    End Sub

    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        If MessageBox.Show("¿Desea agregar un empleado nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            abm_empleados.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Function validar_cuie() As Boolean
        If Me.txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar un cuie para buscar")
            Me.txt_cuie.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmd_buscar_notificaciones_Click(sender As Object, e As EventArgs) Handles cmd_buscar_notificaciones.Click
        Me.condicion_estado = estado.modificar
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""


        If validar_cuie() Then
            sql &= "SELECT * FROM NOTIFICACIONXEFECTOR "
            sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
            sql &= " ORDER BY fecha"
            tabla = acceso.consulta(sql)


            If tabla.Rows.Count() = 0 Then
                MessageBox.Show("¡No existe la notificación solicitada!")
                Exit Sub
            Else
                dgv_notificaciones.Rows.Clear()
                Dim c As Integer = 0
                For c = 0 To tabla.Rows.Count() - 1
                    dgv_notificaciones.Rows.Add()
                    dgv_notificaciones.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
                    dgv_notificaciones.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
                    dgv_notificaciones.Rows(c).Cells("id_stock").Value = tabla.Rows(c)("id_estado_stock")
                    dgv_notificaciones.Rows(c).Cells("id_perdidas").Value = tabla.Rows(c)("id_estado_perdidas")
                    dgv_notificaciones.Rows(c).Cells("id_carga").Value = tabla.Rows(c)("id_estado_carga")
                    dgv_notificaciones.Rows(c).Cells("id_efector").Value = tabla.Rows(c)("id_efector")

                    sql = ""
                    sql &= "SELECT nombre FROM EFECTORES WHERE cuie='" & Me.dgv_notificaciones.Rows(c).Cells("id_efector").Value & "'"
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_notificaciones.Rows(c).Cells("nombre_efector").Value = tabla2.Rows(0)("nombre")

                    sql = ""
                    sql &= "SELECT descripcion FROM CARGA WHERE id=" & Me.dgv_notificaciones.Rows(c).Cells("id_carga").Value
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_notificaciones.Rows(c).Cells("carga").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM STOCK WHERE id=" & Me.dgv_notificaciones.Rows(c).Cells("id_stock").Value
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_notificaciones.Rows(c).Cells("stock").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM PERDIDAS WHERE id=" & dgv_notificaciones.Rows(c).Cells("id_perdidas").Value
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_notificaciones.Rows(c).Cells("perdidas").Value = tabla2.Rows(0)("descripcion")
                Next
            End If
        End If
        limpiar(Me.Controls)
        Me.condicion_estado = estado.modificar
    End Sub

    Private Sub dgv_notificaciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_notificaciones.CellValueChanged
        lbl_contador_notif.Text = dgv_notificaciones.Rows.Count()
    End Sub
End Class