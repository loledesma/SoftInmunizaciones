Public Class Inventario_cadena_de_frio

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

    Private Sub Inventario_cadena_de_frio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedValue = -1
        Me.cmb_departamento.cargar()
        Me.cmb_departamento.SelectedValue = -1
        Me.cmb_tipos_efectores.cargar()
        Me.cmb_tipos_efectores.SelectedValue = -1
        Me.cmb_tipo_heladera.cargar()
        Me.cmb_tipo_heladera.SelectedValue = -1
        Me.cmb_funcionamiento_heladera.cargar()
        Me.cmb_funcionamiento_heladera.SelectedValue = -1
        Me.cmb_marca_heladera.cargar()
        Me.cmb_marca_heladera.SelectedValue = -1


        acceso.autocompletar(txt_efector, "EFECTORES", "nombre")
        acceso.autocompletar(txt_empleado_apellido, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_empleado_nombre, "EMPLEADOS", "nombres")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")



        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamento.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamento.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamento.SelectedValue)
                cmb_localidades.Enabled = True
                cmb_localidades.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub txt_nombre_LostFocus(sender As Object, e As EventArgs) Handles txt_efector.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efector.Text <> "" Then
                sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
                sql &= " WHERE E.nombre='" & txt_efector.Text & "'"
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
                sql &= "SELECT E.nombre As nombre FROM EFECTORES E "
                sql &= " WHERE E.cuie='" & txt_cuie.Text & "'"
                tabla = acceso.consulta(sql)
                If tabla.Rows.Count <> 0 Then
                    txt_efector.Text = tabla.Rows(0)("nombre")
                End If
            End If
        End If
    End Sub

    Private Sub cmd_efector_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_efector_nuevo.Click
        If MessageBox.Show("¿Desea agregar un efector nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Registrar_efectores.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        If MessageBox.Show("¿Desea agregar un empleado nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            abm_empleados.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.nuevo()
    End Sub

    Private Sub nuevo()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar

        Me.txt_efector.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
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
    Private Sub Inventario_cadena_de_frio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
            limpiar(Me.Controls)
        Else
            e.Cancel = False
        End If
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
        If txt_empleado_apellido.Text = "" And txt_empleado_nombre.Text = "" Then
            MessageBox.Show("¡Debe ingresar el nombre y apellido para buscar el empleado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_empleado_nombre.Focus()
            Exit Sub
        Else
            If txt_empleado_apellido.Text = "" And txt_empleado_nombre.Text <> "" Then
                MessageBox.Show("¡Ingrese un apellido para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_empleado_apellido.Focus()
                Exit Sub
            ElseIf txt_empleado_apellido.Text <> "" And txt_empleado_nombre.Text = "" Then
                MessageBox.Show("¡Ingrese un nombre para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_empleado_nombre.Focus()
                Exit Sub
            ElseIf txt_empleado_apellido.Text <> "" And txt_empleado_nombre.Text <> "" Then
                sql = ""
                sql &= "SELECT EMP.id as id, EMP.usuario_sigipsa as usuario_sigipsa"
                sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EXE ON EMP.id = EXE.id_empleados "
                sql &= " WHERE EMP.nombres='" & Me.txt_empleado_nombre.Text & "' AND EMP.apellidos= '" & Me.txt_empleado_apellido.Text & "'"
                sql &= " AND EXE.id_efector='" & Me.txt_cuie.Text & "'"

                tabla = acceso.consulta(sql)
                If tabla.Rows.Count = 0 Then
                    If MessageBox.Show("No se encontro el empleado con esos datos para ese efector ¿Desea registrarlo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                        abm_empleados.ShowDialog()
                    Else
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Empleado encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        condicion_click = doble_Click.activado
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        If txt_cuie.Text = "" Then
            MsgBox("Debe ingresar el efector para buscar su inventario")
            Me.txt_cuie.Focus()
            Exit Sub
        Else
            sql &= "SELECT EF.cuie as cuie, EF.nombre as nombre, EF.id_localidad as id_localidad, EF.id_departamento as id_departamento "
            sql &= ", EF.id_tipo as tipo_efector "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.cuie='" & Me.txt_cuie.Text & "'"

            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cmb_departamento.SelectedValue = tabla.Rows(0)("id_departamento")
                Me.cmb_localidades.cargar()
                cmb_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
                Me.condicion_click = doble_Click.desactivado
                cmb_tipos_efectores.SelectedValue = tabla.Rows(0)("tipo_efector")

                sql = ""
                sql &= "SELECT IH.fecha_info as fecha_info, E.nombres as nombres, E.apellidos as apellidos "
                sql &= "FROM EMPLEADOS E JOIN INVENTARIO_CF_HELADERA IH ON E.id = IH.id_empleado "
                sql &= " WHERE IH.id_efector='" & Me.txt_cuie.Text & "'"
                tabla.Rows.Clear()
                tabla = acceso.consulta(sql)

                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No hay inventario de heladera para el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    txt_empleado_nombre.Text = tabla.Rows(0)("nombres")
                    txt_empleado_apellido.Text = tabla.Rows(0)("apellidos")
                    txt_fecha_info.Text = tabla.Rows(0)("fecha_info")
                    cargar_inventario_heladera()
                    cargar_inventario_termo()
                    cargar_inventario_termometro()
                End If
            End If



        End If
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub cargar_inventario_heladera()

        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT IH.id as id,IH.fecha_info as fecha_info, IH.fecha as fecha, IH.modelo as modelo, IH.nro_serie as nro_serie, "
        sql &= " IH.capacidad as capacidad, IH.medidas as medidas, IH.motivo as motivo, IH.observaciones as observaciones "
        sql &= " , M.descripcion as marca, F.descripcion as funcionamiento, TH.descripcion as tipo_heladera "
        sql &= ", TH.id as id_tipo_heladera, M.id as id_marca, F.id as id_funcionamiento "
        sql &= "FROM INVENTARIO_CF_HELADERA IH JOIN TIPO_HELADERA TH ON IH.id_tipo_heladera = TH.id "
        sql &= " JOIN MARCA M ON IH.id_marca = M.id JOIN FUNCIONAMIENTO F ON IH.id_funcionamiento = F.id "
        sql &= " WHERE IH.id_efector='" & Me.txt_cuie.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        dgv_heladeras.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            dgv_heladeras.Rows.Add()
            dgv_heladeras.Rows(c).Cells("id_heladera").Value = tabla.Rows(c)("id")
            dgv_heladeras.Rows(c).Cells("tipo_heladera").Value = tabla.Rows(c)("tipo_heladera")
            dgv_heladeras.Rows(c).Cells("id_tipo_heladera").Value = tabla.Rows(c)("id_tipo_heladera")
            dgv_heladeras.Rows(c).Cells("marca").Value = tabla.Rows(c)("marca")
            dgv_heladeras.Rows(c).Cells("id_marca").Value = tabla.Rows(c)("id_marca")
            dgv_heladeras.Rows(c).Cells("modelo").Value = tabla.Rows(c)("modelo")
            dgv_heladeras.Rows(c).Cells("nro_serie").Value = tabla.Rows(c)("nro_serie")
            dgv_heladeras.Rows(c).Cells("capacidad").Value = tabla.Rows(c)("capacidad")
            dgv_heladeras.Rows(c).Cells("medidas").Value = tabla.Rows(c)("medidas")
            dgv_heladeras.Rows(c).Cells("motivo").Value = tabla.Rows(c)("motivo")
            dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value = tabla.Rows(c)("observaciones")
            dgv_heladeras.Rows(c).Cells("id_funcionamiento").Value = tabla.Rows(c)("id_funcionamiento")
            dgv_heladeras.Rows(c).Cells("funcionamiento").Value = tabla.Rows(c)("funcionamiento")
            dgv_heladeras.Rows(c).Cells("fecha_info").Value = tabla.Rows(c)("fecha_info")
            dgv_heladeras.Rows(c).Cells("fecha_heladera").Value = tabla.Rows(c)("fecha")
            dgv_heladeras.Rows(c).Cells("antiguedad").Value = calcular_antiguedad(tabla.Rows(c)("fecha"))
        Next

    End Sub

    Private Function calcular_antiguedad(ByRef fecha As String) As String
        Dim hoy As Date = Date.Today
        Dim comparador As Date = fecha
        Dim antiguedad As String = DateDiff(DateInterval.Year, comparador, hoy).ToString

        Return antiguedad
    End Function
    Private Sub cargar_inventario_termo()
        Dim sql As String = ""
        Dim tabla As New DataTable


        sql &= "SELECT id, fecha, cantidad, tipo_termo, observaciones "
        sql &= " FROM INVENTARIO_CF_TERMOS "
        sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No hay inventario de termo para el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            dgv_termos.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1

                dgv_termos.Rows.Add()
                dgv_termos.Rows(c).Cells("id_termo").Value = tabla.Rows(c)("id")
                dgv_termos.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
                dgv_termos.Rows(c).Cells("tipo_termo").Value = tabla.Rows(c)("tipo_termo")
                dgv_termos.Rows(c).Cells("observaciones_termo").Value = tabla.Rows(c)("observaciones")
                dgv_termos.Rows(c).Cells("cantidad").Value = tabla.Rows(c)("cantidad")
            Next
        End If
        

    End Sub

    Private Sub cargar_inventario_termometro()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT id, fecha,cantidad, tipo_termometro, observaciones "
        sql &= " FROM INVENTARIO_CF_TERMOMETRO "
        sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No hay inventario de termometro para el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            dgv_termometros.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1

                dgv_termometros.Rows.Add()
                dgv_termometros.Rows(c).Cells("id_termometro").Value = tabla.Rows(c)("id")
                dgv_termometros.Rows(c).Cells("fecha_termometro").Value = tabla.Rows(c)("fecha")
                dgv_termometros.Rows(c).Cells("tipo_termometro").Value = tabla.Rows(c)("tipo_termometro")
                dgv_termometros.Rows(c).Cells("observaciones_termometro").Value = tabla.Rows(c)("observaciones")
                dgv_termometros.Rows(c).Cells("cantidad_termometro").Value = tabla.Rows(c)("cantidad")
            Next
        End If
    End Sub

    Private Sub dgv_heladeras_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_heladeras.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim sql As String = ""
        Dim tabla As New DataTable

        If txt_cuie.Text = "" Then
            MsgBox("Debe haber seleccionado el efector")
        Else
            sql &= " SELECT * FROM INVENTARIO_CF_HELADERA "
            sql &= " WHERE id_efector= '" & Me.txt_cuie.Text & "'"
            sql &= " AND id = " & Me.dgv_heladeras.CurrentRow.Cells("id_heladera").Value
            tabla = acceso.consulta(sql)
        End If

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe en la base!")
            Exit Sub
        Else
            Me.txt_id_heladera.Text = tabla.Rows(0)("id")
            Me.txt_fecha_heladera.Text = tabla.Rows(0)("fecha")
            Me.cmb_tipo_heladera.SelectedValue = tabla.Rows(0)("id_tipo_heladera")
            Me.cmb_marca_heladera.SelectedValue = tabla.Rows(0)("id_marca")
            Me.txt_modelo_heladera.Text = tabla.Rows(0)("modelo")
            Me.txt_nro_serie_heladera.Text = tabla.Rows(0)("nro_serie")
            Me.txt_capacidad_heladra.Text = tabla.Rows(0)("capacidad")
            Me.txt_medidas_heladera.Text = tabla.Rows(0)("medidas")
            Me.cmb_funcionamiento_heladera.SelectedValue = tabla.Rows(0)("id_funcionamiento")
            Me.txt_motivo_heladera.Text = tabla.Rows(0)("motivo")
            Me.txt_observaciones_heladera.Text = tabla.Rows(0)("observaciones")
            Me.txt_antiguedad_heladera.Text = calcular_antiguedad(tabla.Rows(0)("fecha"))
        End If
    End Sub

    Private Sub dgv_termos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_termos.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim sql As String = ""
        Dim tabla As New DataTable

        If txt_cuie.Text = "" Then
            MsgBox("Debe haber seleccionado el efector")
        Else
            sql &= " SELECT * FROM INVENTARIO_CF_TERMOS "
            sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
            sql &= " AND id = " & Me.dgv_termos.CurrentRow.Cells("id_termo").Value
            tabla = acceso.consulta(sql)
        End If

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe en la base!")
            Exit Sub
        Else
            Me.txt_id_termos.Text = tabla.Rows(0)("id")
            Me.txt_fecha_termo.Text = tabla.Rows(0)("fecha")
            Me.txt_tipo_termo.Text = tabla.Rows(0)("tipo_termo")
            Me.txt_cantidad_termo.Text = tabla.Rows(0)("cantidad")
            Me.txt_observaciones_termo.Text = tabla.Rows(0)("observaciones")
        End If
    End Sub

    Private Sub dgv_termometro_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_termometros.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim sql As String = ""
        Dim tabla As New DataTable

        If txt_cuie.Text = "" Then
            MsgBox("Debe haber seleccionado el efector")
        Else
            sql &= " SELECT * FROM INVENTARIO_CF_TERMOMETRO "
            sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
            sql &= " AND id = " & Me.dgv_termometros.CurrentRow.Cells("id_termometro").Value
            tabla = acceso.consulta(sql)
        End If

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe en la base!")
            Exit Sub
        Else
            Me.txt_id_termometro.Text = tabla.Rows(0)("id")
            Me.txt_fecha_termometro.Text = tabla.Rows(0)("fecha")
            Me.txt_tipo_termometro.Text = tabla.Rows(0)("tipo_termometro")
            Me.txt_cantidad_termometros.Text = tabla.Rows(0)("cantidad")
            Me.txt_observaciones_termometro.Text = tabla.Rows(0)("observaciones")
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.condicion_click = doble_Click.desactivado
        cmb_departamento.SelectedValue = -1
        Me.cmb_localidades.SelectedValue = -1
        Me.cmb_tipos_efectores.SelectedValue = -1
        Me.txt_efector.Text = ""
        Me.txt_cuie.Text = ""
        Me.txt_fecha_info.Text = ""
        Me.txt_empleado_apellido.Text = ""
        Me.txt_empleado_nombre.Text = ""
        Me.dgv_termometros.Rows.Clear()
        Me.dgv_termos.Rows.Clear()
        Me.dgv_heladeras.Rows.Clear()
    End Sub
   

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        guardar()
    End Sub


    Private Function validar_cabecera() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If IsDate(txt_fecha_info.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de recepcion de la info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_info.Focus()
            Exit Function
        ElseIf txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_cuie.Focus()
            Exit Function
        ElseIf cmb_departamento.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_departamento.Focus()
            Exit Function
        ElseIf cmb_localidades.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar la localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_localidades.Focus()
            Exit Function
        ElseIf txt_empleado_apellido.Text = "" Then
            MessageBox.Show("Debe ingresar el apellido del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_empleado_apellido.Focus()
            Exit Function
        ElseIf txt_empleado_nombre.Text = "" Then
            MessageBox.Show("Debe ingresar el nombre del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_empleado_nombre.Focus()
            Exit Function
        ElseIf cmb_tipos_efectores.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar el tipo del efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipos_efectores.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_heladera() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If cmb_tipo_heladera.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar el tipo de la heladera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        ElseIf cmb_marca_heladera.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar la marca de la heladera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_marca_heladera.Focus()
            Exit Function
        ElseIf txt_fecha_heladera.Text > hoy Then
            MessageBox.Show("La fecha de ingreso de la heladera no puede ser mayor a hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_heladera.Focus()
            Exit Function
        ElseIf txt_modelo_heladera.Text = "" Then
            MessageBox.Show("Debe ingresar el modelo de la heladera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_modelo_heladera.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_heladera.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_heladera.Focus()
            Exit Function
        ElseIf cmb_funcionamiento_heladera.SelectedValue = -1 Then
            MessageBox.Show("Debe seleccionar el funcionamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_funcionamiento_heladera.Focus()
            Exit Function
        End If
        Return True
    End Function


    Private Sub cmd_agregar_heladera_Click(sender As Object, e As EventArgs) Handles cmd_agregar_heladera.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0
        If validar_cabecera() = True Then
            If validar_heladera() = True Then
                For c = 0 To dgv_heladeras.Rows.Count - 1
                    If Me.txt_nro_serie_heladera.Text = dgv_heladeras.Rows(c).Cells("nro_serie").Value Then
                        If txt_id_heladera.Text = "" Then
                            dgv_heladeras.Rows(c).Cells("id_heladera").Value = "Null"
                        Else
                            dgv_heladeras.Rows(c).Cells("id_heladera").Value = txt_id_heladera.Text
                        End If
                        dgv_heladeras.Rows(c).Cells("tipo_heladera").Value = cmb_tipo_heladera.Text
                        dgv_heladeras.Rows(c).Cells("id_tipo_heladera").Value = cmb_tipo_heladera.SelectedValue
                        dgv_heladeras.Rows(c).Cells("marca").Value = cmb_marca_heladera.Text
                        dgv_heladeras.Rows(c).Cells("id_marca").Value = cmb_marca_heladera.SelectedValue
                        dgv_heladeras.Rows(c).Cells("modelo").Value = txt_modelo_heladera.Text
                        dgv_heladeras.Rows(c).Cells("nro_serie").Value = txt_nro_serie_heladera.Text
                        dgv_heladeras.Rows(c).Cells("capacidad").Value = txt_capacidad_heladra.Text
                        dgv_heladeras.Rows(c).Cells("medidas").Value = txt_medidas_heladera.Text
                        dgv_heladeras.Rows(c).Cells("motivo").Value = txt_motivo_heladera.Text
                        dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value = txt_observaciones_heladera.Text
                        dgv_heladeras.Rows(c).Cells("id_funcionamiento").Value = cmb_funcionamiento_heladera.SelectedValue
                        dgv_heladeras.Rows(c).Cells("funcionamiento").Value = cmb_funcionamiento_heladera.Text
                        dgv_heladeras.Rows(c).Cells("fecha_info").Value = txt_fecha_info.Text
                        dgv_heladeras.Rows(c).Cells("fecha_heladera").Value = txt_fecha_heladera.Text
                        dgv_heladeras.Rows(c).Cells("antiguedad").Value = calcular_antiguedad(txt_fecha_heladera.Text)
                        flag = True
                    End If
                Next
                If flag = False Then
                    dgv_heladeras.Rows.Add()

                    If txt_id_heladera.Text = "" Then
                        dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("id_heladera").Value = "Null"
                    Else
                        dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("id_heladera").Value = txt_id_heladera.Text
                    End If
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("tipo_heladera").Value = cmb_tipo_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("id_tipo_heladera").Value = cmb_tipo_heladera.SelectedValue
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("marca").Value = cmb_marca_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("id_marca").Value = cmb_marca_heladera.SelectedValue
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("modelo").Value = txt_modelo_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("nro_serie").Value = txt_nro_serie_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("capacidad").Value = txt_capacidad_heladra.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("medidas").Value = txt_medidas_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("motivo").Value = txt_motivo_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("observaciones_heladera").Value = txt_observaciones_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("id_funcionamiento").Value = cmb_funcionamiento_heladera.SelectedValue
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("funcionamiento").Value = cmb_funcionamiento_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("fecha_info").Value = txt_fecha_info.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("fecha_heladera").Value = txt_fecha_heladera.Text
                    dgv_heladeras.Rows(dgv_heladeras.Rows.Count - 1).Cells("antiguedad").Value = calcular_antiguedad(txt_fecha_heladera.Text)
                End If
            End If
        End If
       
        limpiar_heladeras()
    End Sub

    Private Sub cmd_limpiar_heladera_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_heladera.Click
        limpiar_heladeras()
    End Sub

    Private Sub limpiar_heladeras()
        txt_id_heladera.Text = ""
        txt_id_heladera.Enabled = False
        cmb_tipo_heladera.SelectedValue = -1
        cmb_localidades.SelectedValue = -1
        cmb_marca_heladera.SelectedValue = -1
        txt_modelo_heladera.Text = ""
        txt_motivo_heladera.Text = ""
        txt_medidas_heladera.Text = ""
        txt_capacidad_heladra.Text = ""
        txt_nro_serie_heladera.Text = ""
        txt_antiguedad_heladera.Text = ""
        txt_fecha_heladera.Text = ""
        txt_observaciones_heladera.Text = ""
        cmb_funcionamiento_heladera.SelectedValue = -1

        cmd_agregar_heladera.Enabled = True
        cmd_eliminar_heladera.Enabled = False
    End Sub

    Private Sub cmd_eliminar_heladera_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_heladera.Click
        Dim num As Integer = dgv_heladeras.CurrentRow.Index
        For c = 0 To dgv_heladeras.Rows.Count - 1
            If num = c Then
                dgv_heladeras.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

    Private Sub cmd_limpiar_termo_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_termo.Click
        limpiar_termos()
    End Sub

    Private Sub limpiar_termos()
        txt_id_termos.Text = ""
        txt_id_termos.Enabled = False
        txt_tipo_termo.Text = ""
        txt_cantidad_termo.Text = ""
        txt_observaciones_termo.Text = ""
        txt_fecha_termo.Text = ""

        cmd_agregar_termo.Enabled = True
        cmd_eliminar_termo.Enabled = False
    End Sub

    Private Function validar_termo() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_tipo_termo.Text = "" Then
            MessageBox.Show("Debe seleccionar el tipo del termo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        ElseIf txt_cantidad_termo.Text = "" Then
            MessageBox.Show("Debe ingresar la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_termo.Text) = False Then
            MessageBox.Show("Debe ingresar la fecha de recepcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Sub cmd_agregar_termo_Click(sender As Object, e As EventArgs) Handles cmd_agregar_termo.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0
        If validar_cabecera() = True Then
            If validar_termo() = True Then
                For c = 0 To dgv_termos.Rows.Count - 1
                    If txt_tipo_termo.Text = dgv_termos.Rows(c).Cells("tipo_termo").Value Then

                        If txt_id_termos.Text = "" Then
                            dgv_termos.Rows(c).Cells("id_termo").Value = "Null"
                        Else
                            dgv_termos.Rows(c).Cells("id_termo").Value = txt_id_termos.Text
                        End If

                        dgv_termos.Rows(c).Cells("fecha").Value = txt_fecha_termo.Text
                        dgv_termos.Rows(c).Cells("tipo_termo").Value = txt_tipo_termo.Text

                        If txt_observaciones_termo.Text = "" Then
                            dgv_termos.Rows(c).Cells("observaciones_termo").Value = "No hay datos"
                        Else
                            dgv_termos.Rows(c).Cells("observaciones_termo").Value = txt_observaciones_termo.Text
                        End If

                        dgv_termos.Rows(c).Cells("cantidad").Value = txt_cantidad_termo.Text
                        flag = True
                    End If
                Next
                If flag = False Then
                    dgv_termos.Rows.Add()

                    If txt_id_termos.Text = "" Then
                        dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("id_termo").Value = "Null"
                    Else
                        dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("id_termo").Value = txt_id_termos.Text
                    End If
                    dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("fecha").Value = txt_fecha_termo.Text
                    dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("tipo_termo").Value = txt_tipo_termo.Text

                    If txt_observaciones_termo.Text = "" Then
                        dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("observaciones_termo").Value = "No hay datos"
                    Else
                        dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("observaciones_termo").Value = txt_observaciones_termo.Text
                    End If

                    dgv_termos.Rows(dgv_termos.Rows.Count - 1).Cells("cantidad").Value = txt_cantidad_termo.Text
                End If
            End If
        End If

        limpiar_termos()
    End Sub

    Private Sub cmd_eliminar_termo_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_termo.Click
        Dim num As Integer = dgv_termos.CurrentRow.Index
        For c = 0 To dgv_termos.Rows.Count - 1
            If num = c Then
                dgv_termos.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

 
    Private Sub guardar()


        If validar_cabecera() = True Then
            If dgv_heladeras.Rows.Count() = 0 Then
                If dgv_termometros.Rows.Count() = 0 Then
                    If dgv_termos.Rows.Count() = 0 Then
                        MessageBox.Show("No hay nada cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        grabar_termos()
                    End If
                Else
                    grabar_termometros()
                    If dgv_termos.Rows.Count() <> 0 Then
                        grabar_termos()
                    End If
                End If
            Else
                grabar_heladeras()
                If dgv_termometros.Rows.Count() = 0 Then
                    If dgv_termos.Rows.Count() <> 0 Then
                        grabar_termos()
                    End If
                Else
                    grabar_termometros()
                    If dgv_termos.Rows.Count() <> 0 Then
                        grabar_termos()
                    End If
                End If
            End If
        End If



        dgv_heladeras.Rows.Clear()
        dgv_termometros.Rows.Clear()
        dgv_termos.Rows.Clear()
        limpiar_heladeras()
        limpiar_termometros()
        limpiar_termos()
        limpiar(Me.Controls)

    End Sub

    Private Function validar_existencia(ByVal id As Integer, ByVal nombre_tabla As String) As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM " & nombre_tabla
        sql &= " WHERE id= " & id
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If


    End Function

    Private Function ObtenerId(ByVal tabla As String)
        Dim id As Integer = 0
        Dim sqlId = ""
        Dim tablaId As New DataTable

        sqlId = "SELECT * FROM " & tabla
        tablaId = acceso.consulta(sqlId)

        If tablaId.Rows.Count = 0 Then
            id = 1
        Else
            Dim ultimo As Integer = tablaId.Rows.Count() - 1
            id = tablaId.Rows(ultimo)("id") + 1
        End If
        Return id
    End Function

    Private Sub grabar_termos()
        Dim c As Integer = 0
        Dim Sql As String = ""
        Dim id As Integer = 0

        For c = 0 To dgv_termos.Rows.Count() - 1
            If dgv_termos.Rows(c).Cells("id_termo").Value.ToString() <> "Null" Then
                Sql = "UPDATE INVENTARIO_CF_TERMOS"
                Sql &= " SET fecha ='" & Me.dgv_termos.Rows(c).Cells("fecha").Value & "'"
                Sql &= ", cantidad= " & Me.dgv_termos.Rows(c).Cells("cantidad").Value
                Sql &= ", tipo_termo='" & Me.dgv_termos.Rows(c).Cells("tipo_termo").Value & "'"

                If IsNothing(Me.dgv_termos.Rows(c).Cells("observaciones_termo").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones='" & Me.dgv_termos.Rows(c).Cells("observaciones_termo").Value & "'"
                End If

                Sql &= " WHERE id_efector ='" & Me.txt_cuie.Text & "'"
                Sql &= " AND id = " & dgv_termos.Rows(c).Cells("id_termo").Value
                acceso.ejecutar(Sql)
            Else

                id = ObtenerId("INVENTARIO_CF_TERMOS")
                acceso._nombre_tabla = "INVENTARIO_CF_TERMOS"

                Sql &= "id = " & id
                Sql &= ", fecha= '" & Me.dgv_termos.Rows(c).Cells("fecha").Value & "'"
                Sql &= ", id_efector =" & txt_cuie.Text
                Sql &= ", cantidad=" & Me.dgv_termos.Rows(c).Cells("cantidad").Value
                Sql &= ", tipo_termo=" & Me.dgv_termos.Rows(c).Cells("tipo_termo").Value

                If IsNothing(Me.dgv_termos.Rows(c).Cells("observaciones_termo").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones= " & Me.dgv_termos.Rows(c).Cells("observaciones_termo").Value
                End If
                acceso.insertar(Sql)
            End If
            Sql = ""
            
        Next
    End Sub

    Private Sub grabar_termometros()
        Dim c As Integer = 0
        Dim Sql As String = ""
        Dim id As Integer = 0

        For c = 0 To dgv_termometros.Rows.Count() - 1

            If dgv_termometros.Rows(c).Cells("id_termometro").Value.ToString() <> "Null" Then
                Sql = "UPDATE INVENTARIO_CF_TERMOMETRO"
                Sql &= " SET fecha ='" & Me.dgv_termometros.Rows(c).Cells("fecha_termometro").Value & "'"
                Sql &= ", cantidad= " & Me.dgv_termometros.Rows(c).Cells("cantidad_termometro").Value
                Sql &= ", tipo_termometro='" & Me.dgv_termometros.Rows(c).Cells("tipo_termometro").Value & "'"

                If IsNothing(Me.dgv_termometros.Rows(c).Cells("observaciones_termometro").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones='" & Me.dgv_termometros.Rows(c).Cells("observaciones_termometro").Value & "'"
                End If

                Sql &= " WHERE id_efector ='" & Me.txt_cuie.Text & "'"
                Sql &= " AND id = " & dgv_termometros.Rows(c).Cells("id_termometro").Value
                acceso.ejecutar(Sql)

            Else
                acceso._nombre_tabla = "INVENTARIO_CF_TERMOMETRO"
                id = ObtenerId("INVENTARIO_CF_TERMOMETRO")

                Sql &= "id = " & id
                Sql &= ", id_efector =" & txt_cuie.Text
                Sql &= ", fecha= '" & Me.dgv_termometros.Rows(c).Cells("fecha_termometro").Value & "'"
                Sql &= ", cantidad=" & Me.dgv_termometros.Rows(c).Cells("cantidad_termometro").Value
                Sql &= ", tipo_termometro=" & Me.dgv_termometros.Rows(c).Cells("tipo_termometro").Value

                If IsNothing(Me.dgv_termometros.Rows(c).Cells("observaciones_termometro").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones= " & Me.dgv_termometros.Rows(c).Cells("observaciones_termometro").Value
                End If
                acceso.insertar(Sql)
            End If
            
            Sql = ""
        Next
    End Sub

    Private Sub grabar_heladeras()
        Dim c As Integer = 0
        Dim Sql As String = ""
        Dim tabla As New DataTable
        Dim sql_insert As String = ""
        Dim id As Integer = 0

        sql_insert = "SELECT id FROM EMPLEADOS WHERE nombres='" & Me.txt_empleado_nombre.Text & "'"
        sql_insert &= " AND apellidos= '" & Me.txt_empleado_apellido.Text & "'"
        tabla = acceso.consulta(sql_insert)

        For c = 0 To dgv_heladeras.Rows.Count() - 1
            If dgv_heladeras.Rows(c).Cells("id_heladera").Value.ToString() <> "Null" Then
                Sql = "UPDATE INVENTARIO_CF_HELADERA"
                Sql &= " SET fecha ='" & Me.dgv_heladeras.Rows(c).Cells("fecha_heladera").Value & "'"
                Sql &= ", id_tipo_heladera= " & Me.dgv_heladeras.Rows(c).Cells("id_tipo_heladera").Value
                Sql &= ", modelo= '" & Me.dgv_heladeras.Rows(c).Cells("modelo").Value & "'"
                Sql &= ", id_marca= " & Me.dgv_heladeras.Rows(c).Cells("id_marca").Value
                Sql &= ", nro_serie= '" & Me.dgv_heladeras.Rows(c).Cells("nro_serie").Value & "'"
                Sql &= ", medidas= '" & Me.dgv_heladeras.Rows(c).Cells("medidas").Value & "'"
                Sql &= ", capacidad= '" & Me.dgv_heladeras.Rows(c).Cells("capacidad").Value & "'"
                Sql &= ", id_funcionamiento= " & Me.dgv_heladeras.Rows(c).Cells("id_funcionamiento").Value
                Sql &= ", fecha_info= '" & Me.dgv_heladeras.Rows(c).Cells("fecha_info").Value & "'"

                If IsNothing(Me.dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones='" & Me.dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value & "'"
                End If

                If IsNothing(Me.dgv_heladeras.Rows(c).Cells("motivo").Value) Then
                    Sql &= ", motivo= No hay datos "
                Else
                    Sql &= ", motivo='" & Me.dgv_heladeras.Rows(c).Cells("motivo").Value & "'"
                End If

                Sql &= " WHERE id_efector ='" & Me.txt_cuie.Text & "'"
                Sql &= " AND id = " & dgv_heladeras.Rows(c).Cells("id_heladera").Value
                acceso.ejecutar(Sql)

            Else
                acceso._nombre_tabla = "INVENTARIO_CF_HELADERA"
                id = ObtenerId("INVENTARIO_CF_HELADERA")

                Sql &= "id = " & id
                Sql &= ", id_efector =" & txt_cuie.Text
                Sql &= ", id_empleado=" & tabla.Rows(0)("id")
                Sql &= ", fecha='" & Me.dgv_heladeras.Rows(c).Cells("fecha_heladera").Value & "'"
                Sql &= ", id_tipo_heladera= " & Me.dgv_heladeras.Rows(c).Cells("id_tipo_heladera").Value
                Sql &= ", id_marca= " & Me.dgv_heladeras.Rows(c).Cells("id_marca").Value
                Sql &= ", modelo= " & Me.dgv_heladeras.Rows(c).Cells("modelo").Value
                Sql &= ", nro_serie= " & Me.dgv_heladeras.Rows(c).Cells("nro_serie").Value
                Sql &= ", capacidad= " & Me.dgv_heladeras.Rows(c).Cells("capacidad").Value
                Sql &= ", medidas= " & Me.dgv_heladeras.Rows(c).Cells("medidas").Value
                Sql &= ", id_funcionamiento= " & Me.dgv_heladeras.Rows(c).Cells("id_funcionamiento").Value

                If IsNothing(Me.dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value) Then
                    Sql &= ", observaciones= No hay datos "
                Else
                    Sql &= ", observaciones=" & Me.dgv_heladeras.Rows(c).Cells("observaciones_heladera").Value
                End If

                If IsNothing(Me.dgv_heladeras.Rows(c).Cells("motivo").Value) Then
                    Sql &= ", motivo= No hay datos "
                Else
                    Sql &= ", motivo= " & Me.dgv_heladeras.Rows(c).Cells("motivo").Value
                End If

                Sql &= ", fecha_info='" & Me.dgv_heladeras.Rows(c).Cells("fecha_info").Value & "'"

                acceso.insertar(Sql)
            End If

            Sql = ""
        Next
    End Sub

    Private Function validar_termometro()
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_tipo_termometro.Text = "" Then
            MessageBox.Show("Debe seleccionar el tipo del termometro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        ElseIf txt_cantidad_termometros.Text = "" Then
            MessageBox.Show("Debe ingresar la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha_termometro.Text) = False Then
            MessageBox.Show("Debe ingresar la fecha de recepcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_heladera.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Sub cmd_limpiar_termometro_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_termometro.Click
        limpiar_termometros()
    End Sub

    Private Sub limpiar_termometros()
        txt_id_termometro.Text = ""
        txt_id_termometro.Enabled = False
        txt_tipo_termometro.Text = ""
        txt_cantidad_termometros.Text = ""
        txt_observaciones_termometro.Text = ""
        txt_fecha_termometro.Text = ""

        cmd_agregar_termometro.Enabled = True
        cmd_eliminar_termometro.Enabled = False
    End Sub

    Private Sub cmd_agregar_termometro_Click(sender As Object, e As EventArgs) Handles cmd_agregar_termometro.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0
        If validar_cabecera() = True Then
            If validar_termometro() = True Then
                For c = 0 To dgv_termometros.Rows.Count - 1
                    If txt_tipo_termometro.Text = dgv_termometros.Rows(c).Cells("tipo_termometro").Value Then
                        If txt_id_termometro.Text = "" Then
                            dgv_termometros.Rows(c).Cells("id_termometro").Value = "Null"
                        Else
                            dgv_termometros.Rows(c).Cells("id_termometro").Value = txt_id_termometro.Text
                        End If

                        dgv_termometros.Rows(c).Cells("fecha_termometro").Value = txt_fecha_termometro.Text
                        dgv_termometros.Rows(c).Cells("tipo_termometro").Value = txt_tipo_termometro.Text

                        If txt_observaciones_termometro.Text = "" Then
                            dgv_termometros.Rows(c).Cells("observaciones_termometro").Value = "No hay datos"
                        Else
                            dgv_termometros.Rows(c).Cells("observaciones_termometro").Value = txt_observaciones_termometro.Text
                        End If

                        dgv_termometros.Rows(c).Cells("cantidad_termometro").Value = txt_cantidad_termometros.Text
                        flag = True
                    End If
                Next
                If flag = False Then
                    dgv_termometros.Rows.Add()

                    If txt_id_termometro.Text = "" Then
                        dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("id_termometro").Value = "Null"
                    Else
                        dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("id_termometro").Value = txt_id_termometro.Text
                    End If

                    dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("fecha_termometro").Value = txt_fecha_termometro.Text
                    dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("tipo_termometro").Value = txt_tipo_termometro.Text

                    If txt_observaciones_termometro.Text = "" Then
                        dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("observaciones_termometro").Value = "No hay datos"
                    Else
                        dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("observaciones_termometro").Value = txt_observaciones_termometro.Text
                    End If

                    dgv_termometros.Rows(dgv_termometros.Rows.Count - 1).Cells("cantidad_termometro").Value = txt_cantidad_termometros.Text
                End If
            End If
        End If

        limpiar_termometros()
    End Sub

    Private Sub cmd_eliminar_termometro_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_termometro.Click
        Dim num As Integer = dgv_termometros.CurrentRow.Index
        For c = 0 To dgv_termometros.Rows.Count - 1
            If num = c Then
                dgv_termometros.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub
End Class