﻿Public Class Registrar_atencion

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
        acceso.autocompletar(txt_efector, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        cmb_estado_atencion.cargar()
        Me.cmb_estado_atencion.SelectedIndex = -1
        cargar_combo()
        tip()
        Me.txt_id_atencion.Focus()
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

        sql &= "SELECT A.id as id, A.fecha as fecha, A.id_estados_atencion as id_estado, A.id_efector as cuie, A.descripcion as descripcion "
        sql &= " , A.id_administrador as id_administrador "
        sql &= " FROM ATENCION_SOPORTE A "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0

        dgv_atenciones.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            dgv_atenciones.Rows.Add()
            dgv_atenciones.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
            dgv_atenciones.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
            dgv_atenciones.Rows(c).Cells("cuie").Value = tabla.Rows(c)("cuie")
            dgv_atenciones.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estado")
            dgv_atenciones.Rows(c).Cells("cuie").Value = tabla.Rows(c)("cuie")
            dgv_atenciones.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            dgv_atenciones.Rows(c).Cells("id_administrador").Value = tabla.Rows(c)("id_administrador")

            sql = ""
            sql &= "SELECT E.nombre as nombre FROM EFECTORES E WHERE cuie='" & tabla.Rows(c)("cuie") & "'"
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_atenciones.Rows(c).Cells("efector").Value = tabla2.Rows(0)("nombre")

            sql = ""
            sql &= "SELECT descripcion as estado FROM ESTADOS_ATENCION WHERE id= " & tabla.Rows(c)("id_estado")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)


            dgv_atenciones.Rows(c).Cells("estado").Value = tabla2.Rows(0)("estado")

            sql = ""
            sql &= "SELECT nombres FROM EMPLEADOS WHERE id=" & tabla.Rows(c)("id_administrador")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_atenciones.Rows(c).Cells("administrador").Value = tabla2.Rows(0)("nombres")
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

    Private Sub dgv_atenciones_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_atenciones.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim sql As String = ""
        limpiar(Controls)


        sql &= "SELECT * FROM ATENCION_SOPORTE "
        sql &= " WHERE id= " & dgv_atenciones.CurrentRow.Cells("id").Value
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_id_atencion.Text = Me.dgv_atenciones.CurrentRow.Cells("id").Value
        Me.txt_fecha.Text = tabla.Rows(0)("fecha")
        Me.cmb_estado_atencion.SelectedValue = tabla.Rows(0)("id_estados_atencion")
        Me.cmb_empleados.SelectedValue = tabla.Rows(0)("id_administrador")
        Me.txt_cuie.Text = tabla.Rows(0)("id_efector")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")

        sql = ""
        sql &= "SELECT nombre FROM EFECTORES WHERE cuie='" & tabla.Rows(0)("id_efector") & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)
        Me.txt_efector.Text = tabla.Rows(0)("nombre")

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
        If txt_cuie.Text = "" Then
            MessageBox.Show("¡Debe ingresar un efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cuie.Focus()
            Return False
            Exit Function
        ElseIf txt_efector.Text = "" Then
            MessageBox.Show("¡Debe ingresar un efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_efector.Focus()
            Return False
            Exit Function
        ElseIf cmb_empleados.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un administrador!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_empleados.Focus()
            Return False
            Exit Function
        ElseIf cmb_estado_atencion.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado de la atención!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_atencion.Focus()
            Return False
            Exit Function
        ElseIf txt_fecha.Text > hoy Then
            MessageBox.Show("Debe ingresar una fecha de alta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha.Focus()
            Exit Function
        ElseIf IsDate(txt_fecha.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Sub tip()
        tltp_atencion.SetToolTip(cmd_buscar, "Buscar atencion")
        tltp_atencion.SetToolTip(cmd_eliminar, "Eliminar")
        tltp_atencion.SetToolTip(cmd_guardar, "Guardar")
        tltp_atencion.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_atencion.SetToolTip(cmd_salir, "Salir")
        tltp_atencion.SetToolTip(cmd_limpiar, "Limpiar")
        tltp_atencion.SetToolTip(cmd_actualizar_estado, "Actualizar estado de la atención")
        tltp_atencion.SetToolTip(cmd_efector_nuevo, "Alta de efector de nuevo")
    End Sub

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM ATENCION_SOPORTE "
        sql &= "WHERE id = " & Me.txt_id_atencion.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub insertar()
        Dim sql As String = ""
        acceso._nombre_tabla = "ATENCION_SOPORTE"

        sql &= "id = " & Me.txt_id_atencion.Text
        sql &= ", fecha ='" & Me.txt_fecha.Text & "'"
        sql &= ", id_estados_atencion= " & Me.cmb_estado_atencion.SelectedValue
        sql &= ", id_efector=" & Me.txt_cuie.Text
        sql &= ", descripcion =" & Me.txt_descripcion.Text
        sql &= ", id_administrador =" & Me.cmb_empleados.SelectedValue
        acceso.insertar(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE ATENCION_SOPORTE "
        sql &= " SET fecha = '" & Me.txt_fecha.Text & "'"
        sql &= ", id_estados_atencion = " & Me.cmb_estado_atencion.SelectedValue
        sql &= ", id_efector='" & Me.txt_cuie.Text & "'"
        sql &= ", descripcion ='" & Me.txt_descripcion.Text & "'"
        sql &= ", id_administrador =" & Me.cmb_empleados.SelectedValue
        sql &= " WHERE id = " & Me.txt_id_atencion.Text

        acceso.ejecutar(sql)
    End Sub

    Private Sub guardar()
        If Me.validar() = True Then
            If condicion_estado = condicion.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya se encuentra cargada esta atención")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
        Else
            Exit Sub
        End If
        Me.limpiar(Me.Controls)
        Me.txt_descripcion.Text = ""
        Me.cargar_grilla()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Sub nuevo()
        limpiar(Controls)
        Me.condicion_estado = condicion.insertar
        Dim sql As String = "SELECT * FROM ATENCION_SOPORTE"
        Dim tabla As New DataTable
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.txt_id_atencion.Text = 1
        Else
            Dim ultimo As Integer = tabla.Rows.Count() - 1
            Me.txt_id_atencion.Text = tabla.Rows(ultimo)("id") + 1
        End If

        Me.txt_id_atencion.Enabled = False
        Me.cmb_empleados.Enabled = True
        Me.cmb_estado_atencion.Enabled = True
        Me.txt_fecha.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_eliminar.Enabled = False
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        If IsNumeric(Me.txt_id_atencion.Text) Then
            If MessageBox.Show("¿Esta seguro que desea borrar el registro?", _
             "Atencion", MessageBoxButtons.OKCancel, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                sql = "DELETE FROM ATENCION_SOPORTE "
                sql &= "WHERE id = " & Me.txt_id_atencion.Text
                acceso.ejecutar(sql)
            End If
        Else
            MessageBox.Show("El elemento no existe o ingrese un valor numérico")
            Me.txt_id_atencion.Focus()
            Exit Sub
        End If

        Me.txt_id_atencion.Enabled = True
        Me.txt_descripcion.Text = ""
        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
    End Sub

    Private Sub cmd_actualizar_estado_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_estado.Click
        Dim sql As String = ""
        Dim tabla As DataTable

        If txt_id_atencion.Text = "" Then
            MessageBox.Show("Seleccione una atención para actualizar el estado")
            Me.txt_id_atencion.Focus()
            Exit Sub
        End If

        sql &= "SELECT * FROM ATENCION_SOPORTE WHERE id=" & Me.txt_id_atencion.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No se encuentra registrada esa atención todavia")
            Me.txt_id_atencion.Focus()
            Exit Sub
        Else
            sql &= "UPDATE ATENCION_SOPORTE"
            sql &= " SET id_estados_atencion= " & Me.cmb_estado_atencion.SelectedValue
            sql &= " WHERE id= " & Me.txt_id_atencion.Text
            acceso.ejecutar(sql)
        End If
        cargar_grilla()
    End Sub

    Private Sub cmd_efector_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_efector_nuevo.Click
        If MessageBox.Show("¿Desea agregar un efector nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Registrar_efectores.ShowDialog()
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

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.condicion_estado = condicion.modificar
        Me.condicion_click = doble_Click.activado
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""


        If validar_cuie() Then
            sql &= "SELECT * FROM ATENCION_SOPORTE "
            sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
            sql &= " ORDER BY fecha"
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count() = 0 Then
                MessageBox.Show("¡No existe la atencion solicitada!")
                Exit Sub
            Else
                Dim c As Integer = 0
                dgv_atenciones.Rows.Clear()
                For c = 0 To tabla.Rows.Count() - 1
                    dgv_atenciones.Rows.Add()
                    dgv_atenciones.Rows(c).Cells("id").Value = tabla.Rows(0)("id")
                    dgv_atenciones.Rows(c).Cells("fecha").Value = tabla.Rows(0)("fecha")
                    dgv_atenciones.Rows(c).Cells("cuie").Value = tabla.Rows(0)("id_efector")
                    dgv_atenciones.Rows(c).Cells("id_estado").Value = tabla.Rows(0)("id_estados_atencion")
                    dgv_atenciones.Rows(c).Cells("id_administrador").Value = tabla.Rows(0)("id_administrador")
                    dgv_atenciones.Rows(c).Cells("descripcion").Value = tabla.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM ESTADOS_ATENCION WHERE id=" & Me.dgv_atenciones.Rows(c).Cells("id_estado").Value
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_atenciones.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT nombres FROM EMPLEADOS WHERE id= " & Me.dgv_atenciones.Rows(c).Cells("id_administrador").Value
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_atenciones.Rows(c).Cells("administrador").Value = tabla2.Rows(0)("nombres")

                    sql = ""
                    sql &= "SELECT nombre FROM EFECTORES WHERE cuie='" & Me.dgv_atenciones.Rows(c).Cells("cuie").Value & "'"
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)
                    dgv_atenciones.Rows(c).Cells("efector").Value = tabla2.Rows(0)("nombre")
                Next
            End If
        End If


        limpiar(Me.Controls)
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_id_atencion.Enabled = True
        Me.grp_datos_atencion.Enabled = True
        Me.grp_descripcion.Enabled = True
        Me.descripcion.ToolTipText = ""
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.txt_id_atencion.Focus()
        Me.cargar_grilla()
        Me.txt_descripcion.Text = ""
    End Sub
End Class