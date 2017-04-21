Public Class Registrar_capacitaciones

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

    Private Sub Registrar_capacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Me.Controls)
        cargar_grilla()
        Me.cmb_tipo_capacitaciones.cargar()
        Me.cmb_tipo_capacitaciones.SelectedValue = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedValue = -1
        Me.cmb_estado.cargar()
        Me.cmb_estado.SelectedValue = -1
        Me.cmb_tipos_documento.cargar()
        Me.cmb_tipos_documento.SelectedValue = -1
        Me.cmb_departamento.cargar()
        Me.cmb_departamento.SelectedValue = -1
        

        acceso.autocompletar(txt_numero_doc, "EMPLEADOS", "nro_doc")
        acceso.autocompletar(txt_apellido_empleado, "EMPLEADOS", "apellidos")



        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
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

    Private Sub Registrar_capacitaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub cmd_buscar_capacitaciones_Click(sender As Object, e As EventArgs) Handles cmd_buscar_capacitaciones.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        If IsDate(txt_fecha_efectiva.Text) = False Then
            If cmb_localidades.SelectedValue = -1 Then
                MessageBox.Show("Debe ingresar una fecha o una localidad para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_fecha_efectiva.Focus()
            Else
                buscar_x_localidad()
            End If
        Else
            buscar_x_fecha()
        End If

        limpiar(Me.Controls)
        txt_fecha_efectiva.Focus()
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub buscar_x_fecha()
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        txt_id_capacitacion.Enabled = False

        If IsDate(txt_fecha_programada.Text) = False Then
            MsgBox("Debe ingresar la fecha")
            Me.txt_fecha_programada.Focus()
            Exit Sub
        Else
            sql &= "SELECT * "
            sql &= " FROM CAPACITACIONES "
            sql &= " WHERE fecha_programada = '" & Me.txt_fecha_programada.Text & "'"

            tabla = acceso.consulta(sql)

            If tabla.Rows().Count = 0 Then
                MessageBox.Show("¡No existe una capacitacion para esa fecha!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                dgv_capas.Rows.Clear()

                For c = 0 To tabla.Rows.Count - 1
                    dgv_capas.Rows.Add()

                    dgv_capas.Rows(c).Cells("id_capacitacion").Value = tabla.Rows(c)("id")
                    dgv_capas.Rows(c).Cells("fecha_programada").Value = tabla.Rows(c)("fecha_programada")

                    If IsDBNull(tabla.Rows(c)("fecha_efectiva")) Then
                        dgv_capas.Rows(c).Cells("fecha_efectiva").Value = tabla.Rows(c)("fecha_efectiva")
                    Else
                        dgv_capas.Rows(c).Cells("fecha_efectiva").Value = " "
                    End If

                    sql = ""
                    sql &= "SELECT descripcion FROM TIPO_CAPACITACIONES WHERE id= " & tabla.Rows(c)("id_tipo")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("tipo").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM ESTADO_CAPACITACIONES WHERE id= " & tabla.Rows(c)("id_estado")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM LOCALIDADES WHERE id= " & tabla.Rows(c)("id_localidad")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("localidad").Value = tabla2.Rows(0)("descripcion")
                Next
            End If
        End If
    End Sub

    Private Sub buscar_x_localidad()
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        txt_id_capacitacion.Enabled = False

        If IsDate(txt_fecha_programada.Text) = False Then
            MsgBox("Debe ingresar la fecha")
            Me.txt_fecha_programada.Focus()
            Exit Sub
        Else
            sql &= "SELECT * "
            sql &= " FROM CAPACITACIONES "
            sql &= " WHERE id_localidad = " & Me.cmb_localidades.SelectedValue

            tabla = acceso.consulta(sql)

            If tabla.Rows().Count = 0 Then
                MessageBox.Show("¡No existe una capacitacion para esa localidad!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                dgv_capas.Rows.Clear()

                For c = 0 To tabla.Rows.Count - 1
                    dgv_capas.Rows.Add()

                    dgv_capas.Rows(c).Cells("id_capacitacion").Value = tabla.Rows(c)("id")
                    dgv_capas.Rows(c).Cells("fecha_programada").Value = tabla.Rows(c)("fecha_programada")

                    If IsDBNull(tabla.Rows(c)("fecha_efectiva")) Then
                        dgv_capas.Rows(c).Cells("fecha_efectiva").Value = tabla.Rows(c)("fecha_efectiva")
                    Else
                        dgv_capas.Rows(c).Cells("fecha_efectiva").Value = " "
                    End If

                    sql = ""
                    sql &= "SELECT descripcion FROM TIPO_CAPACITACIONES WHERE id= " & tabla.Rows(c)("id_tipo")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("tipo").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM ESTADO_CAPACITACIONES WHERE id= " & tabla.Rows(c)("id_estado")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")

                    sql = ""
                    sql &= "SELECT descripcion FROM LOCALIDADES WHERE id= " & tabla.Rows(c)("id_localidad")
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    dgv_capas.Rows(c).Cells("estado").Value = tabla2.Rows(0)("descripcion")
                Next
            End If
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM CAPACITACIONES ORDER BY fecha_efectiva "

        tabla = acceso.consulta(sql)

        Dim C As Integer = 0

        dgv_capas.Rows.Clear()

        For C = 0 To tabla.Rows.Count - 1
            dgv_capas.Rows.Add()
            dgv_capas.Rows(C).Cells("id_capacitacion").Value = tabla.Rows(C)("id")
            dgv_capas.Rows(C).Cells("fecha_programada").Value = tabla.Rows(C)("fecha_programada")

            If IsDBNull(tabla.Rows(C)("fecha_efectiva")) Then
                dgv_capas.Rows(C).Cells("fecha_efectiva").Value = ""
            Else
                dgv_capas.Rows(C).Cells("fecha_efectiva").Value = tabla.Rows(C)("fecha_efectiva")
            End If

            sql = ""
            sql &= "SELECT descripcion FROM TIPO_CAPACITACIONES WHERE id= " & tabla.Rows(C)("id_tipo")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_capas.Rows(C).Cells("tipo").Value = tabla2.Rows(0)("descripcion")

            sql = ""
            sql &= "SELECT descripcion FROM ESTADO_CAPACITACIONES WHERE id= " & tabla.Rows(C)("id_estado")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_capas.Rows(C).Cells("estado").Value = tabla2.Rows(0)("descripcion")


            sql = ""
            sql &= "SELECT descripcion FROM LOCALIDADES WHERE id= " & tabla.Rows(C)("id_localidad")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_capas.Rows(C).Cells("localidad").Value = tabla2.Rows(0)("descripcion")
        Next
    End Sub

    Private Sub dgv_capas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_capas.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""
        dgv_empleados.Rows.Clear()


        sql2 &= " SELECT * FROM CAPACITACIONES "
        sql2 &= " WHERE id =" & Me.dgv_capas.CurrentRow.Cells("id_capacitacion").Value
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_id_capacitacion.Text = tabla2.Rows(0)("id")
        Me.cmb_tipo_capacitaciones.SelectedValue = tabla2.Rows(0)("id_tipo")
        Me.txt_lugar.Text = tabla2.Rows(0)("lugar")

        sql = ""
        sql &= "SELECT D.id FROM DEPARTAMENTOS D JOIN LOCALIDADES L ON D.id = L.id_departamento "
        sql &= " WHERE L.id= " & tabla2.Rows(0)("id_localidad")
        tabla.Clear()
        tabla = acceso.consulta(sql)
        Me.cmb_departamento.SelectedValue = tabla.Rows(0)("id")
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedValue = tabla2.Rows(0)("id_localidad")


        If IsDBNull(tabla2.Rows(0)("fecha_efectiva")) Then
            Me.txt_fecha_efectiva.Text = ""
        Else
            Me.txt_fecha_efectiva.Text = tabla2.Rows(0)("fecha_efectiva")
        End If
        Me.txt_fecha_programada.Text = tabla2.Rows(0)("fecha_programada")
        Me.txt_hora.Text = tabla2.Rows(0)("hora")
        Me.cmb_estado.SelectedValue = tabla2.Rows(0)("id_estado")
        Me.txt_duracion_prevista.Text = tabla2.Rows(0)("duracion_prevista")

        If IsDBNull(tabla2.Rows(0)("duracion_real")) Then
            Me.txt_duracion_real.Text = ""
        Else
            Me.txt_duracion_real.Text = tabla2.Rows(0)("duracion_real")
        End If

        If IsDBNull(tabla2.Rows(0)("observaciones")) Then
            Me.txt_observaciones.Text = ""
        Else
            Me.txt_observaciones.Text = tabla2.Rows(0)("observaciones")
        End If

        If IsDBNull(tabla2.Rows(0)("descripcion")) Then
            Me.txt_descripcion.Text = ""
        Else
            Me.txt_descripcion.Text = tabla2.Rows(0)("descripcion")
        End If

        sql = ""
        sql &= "SELECT A.realizoEvaluacion As realizoEvaluacion, E.nombres As nombre_empleado, E.apellidos As apellido_empleado "
        sql &= ", E.id_tipo_doc As tipo_doc, E.nro_doc As nro_doc, A.id_empleado As id_empleado, A.observaciones As observaciones "
        sql &= " FROM ASISTENCIA A JOIN EMPLEADOS E ON A.id_empleado = E.id "
        sql &= " JOIN EMPLEADOSXEFECTOR EE ON E.id = EE.id_empleados "
        sql &= " WHERE A.id_capacitacion= " & Me.txt_id_capacitacion.Text
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)


        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("La capacitacion no tiene asistencia registrada!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Dim c As Integer = 0
            dgv_empleados.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1
                dgv_empleados.Rows.Add()
                dgv_empleados.Rows(c).Cells("id").Value = tabla.Rows(c)("id_empleado")

                sql = ""
                sql &= " SELECT * FROM TIPOS_DOCUMENTO WHERE id= " & tabla.Rows(c)("tipo_doc")
                tabla2.Rows.Clear()
                tabla2 = acceso.consulta(sql)

                dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla2.Rows(0)("descripcion")
                dgv_empleados.Rows(c).Cells("numero").Value = tabla.Rows(c)("nro_doc")
                dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombre_empleado")
                dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellido_empleado")
                dgv_empleados.Rows(c).Cells("realizoEvaluacion").Value = tabla.Rows(c)("realizoEvaluacion")

                If IsDBNull(tabla.Rows(c)("observaciones")) = False Then
                    dgv_empleados.Rows(c).Cells("observaciones").Value = tabla.Rows(c)("observaciones")
                Else
                    dgv_empleados.Rows(c).Cells("observaciones").Value = "NULL"
                End If

                sql = ""
                sql &= "SELECT mail_contacto FROM EMPLEADOS WHERE id= " & tabla.Rows(c)("id_empleado")
                tabla2.Rows.Clear()
                tabla2 = acceso.consulta(sql)

                dgv_empleados.Rows(c).Cells("mail").Value = tabla2.Rows(0)("mail_contacto")

            Next
        End If
        Me.condicion_click = doble_Click.desactivado
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

    Private Sub dgv_empleados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_empleados.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        If txt_id_capacitacion.Text = "" Then
            MsgBox("Debe ingresar un id de capacitacion")
        End If


        sql2 &= " SELECT * FROM ASISTENCIA "
        sql2 &= " WHERE id_capacitacion =" & Me.txt_id_capacitacion.Text
        sql2 &= " AND id_empleado = " & Me.dgv_empleados.CurrentRow.Cells("id").Value
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_id_empleado.Text = tabla2.Rows(0)("id_empleado")
        Me.txt_realizoEvaluacion.Text = tabla2.Rows(0)("realizoEvaluacion")

        If IsDBNull(tabla2.Rows(0)("observaciones")) Then
            Me.txt_observaciones2.Text = ""
        Else
            Me.txt_observaciones2.Text = tabla2.Rows(0)("observaciones")
        End If


        sql = ""
        sql &= " SELECT * FROM EMPLEADOS WHERE id= " & Me.txt_id_empleado.Text
        tabla = acceso.consulta(sql)

        Me.cmb_tipos_documento.SelectedValue = tabla.Rows(0)("id_tipo_doc")
        Me.txt_numero_doc.Text = tabla.Rows(0)("nro_doc")
        Me.txt_nombres_empleado.Text = tabla.Rows(0)("nombres")
        Me.txt_apellido_empleado.Text = tabla.Rows(0)("apellidos")


    End Sub

    Private Sub nuevo()
        Me.limpiar(Me.Controls)
        Me.txt_descripcion.Text = ""
        Me.txt_observaciones.Text = ""
        Me.condicion_estado = condicion.insertar
        Dim sql As String = "SELECT * FROM CAPACITACIONES "
        Dim tabla As New DataTable
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.txt_id_capacitacion.Text = 1
        Else
            Dim ultimo As Integer = tabla.Rows.Count() - 1
            Me.txt_id_capacitacion.Text = tabla.Rows(ultimo)("id") + 1
        End If

        Me.txt_id_capacitacion.Enabled = False
        Me.cmb_tipo_capacitaciones.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Function validar_capacitacion() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_id_capacitacion.Text = "" Then
            MessageBox.Show("¡Debe ingresar un numero de capacitacion!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_id_capacitacion.Focus()
            Return False
            Exit Function
        ElseIf txt_duracion_prevista.Text = "" Then
            MessageBox.Show("¡Debe ingresar una duracion prevista!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_duracion_prevista.Focus()
            Return False
            Exit Function
        ElseIf txt_hora.Text = "" Then
            MessageBox.Show("¡Debe ingresar una Hora de realizacion!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_hora.Focus()
            Return False
            Exit Function
        ElseIf cmb_localidades.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar una localidad!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_localidades.Focus()
            Return False
            Exit Function
        ElseIf cmb_tipo_capacitaciones.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de capacitacion!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_tipo_capacitaciones.Focus()
            Return False
            Exit Function
        ElseIf cmb_estado.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado.Focus()
            Return False
            Exit Function
        ElseIf IsDate(txt_fecha_programada.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha programada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_fecha_programada.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_post() As Boolean
        If IsDate(txt_fecha_efectiva.Text) = False Then
            MessageBox.Show("Debe ingresar una fecha efectiva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_fecha_efectiva.Focus()
            Return False
            Exit Function
        ElseIf txt_duracion_real.Text = "" Then
            MessageBox.Show("¡Debe ingresar una duracion real!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_duracion_real.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM CAPACITACIONES "
        sql &= "WHERE fecha_programada = '" & Me.txt_fecha_efectiva.Text & "'"
        sql &= " AND hora= " & Me.txt_hora.Text
        sql &= " AND lugar='" & Me.txt_lugar.Text & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub guardar()
        If validar_capacitacion() = True Then
            If condicion_estado = condicion.insertar Then
                If validar_existencia() = analizar_existencia.no_existe Then
                    ingresar()
                Else
                    MessageBox.Show("Ya se encuentra registrado esta capacitacion")
                    Exit Sub
                End If
            Else
                If MessageBox.Show("¿Desea registrar la realizacion de la capacitacion?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    modificar()
                Else
                    If validar_post() Then
                        modificar()
                    Else
                        Exit Sub
                    End If
                End If
            End If
        End If


        dgv_empleados.Rows.Clear()
        dgv_capas.Rows.Clear()
        limpiar(Me.Controls)
        cargar_grilla()
    End Sub

    Private Sub modificar()
        Dim Sql As String = ""
        Sql = "UPDATE CAPACITACIONES "
  
        Sql &= "SET fecha_programada ='" & Me.txt_fecha_programada.Text & "'"

        If IsDate(txt_fecha_efectiva.Text) Then
            Sql &= ", fecha_efectiva ='" & Me.txt_fecha_efectiva.Text & "'"
        Else
            Sql &= ", fecha_efectiva= NULL"
        End If

        Sql &= ", hora=" & Me.txt_hora.Text
        Sql &= " , id_localidad= " & Me.cmb_localidades.SelectedValue
        Sql &= ", id_estado= " & Me.cmb_estado.SelectedValue
        Sql &= ", lugar='" & Me.txt_lugar.Text & "'"

        If txt_observaciones.Text = "" Then
            Sql &= ", observaciones= NULL "
        Else
            Sql &= ", observaciones= '" & Me.txt_observaciones.Text & "'"
        End If
        If txt_descripcion.Text = "" Then
            Sql &= ", descripcion= NULL "
        Else
            Sql &= ", descripcion= '" & Me.txt_descripcion.Text & "'"
        End If

        Sql &= ", duracion_prevista= " & Me.txt_duracion_prevista.Text

        If txt_duracion_real.Text = "" Then
            Sql &= ", duracion_real= NULL"
        Else
            Sql &= ", duracion_real= " & Me.txt_duracion_real.Text
        End If

        Sql &= ", id_tipo= " & Me.cmb_tipo_capacitaciones.SelectedValue
        Sql &= " WHERE id = " & Me.txt_id_capacitacion.Text

        acceso.ejecutar(Sql)
    End Sub

    Private Sub ingresar()
        Dim sql As String = ""
        acceso._nombre_tabla = "CAPACITACIONES"

        sql &= "id = " & Me.txt_id_capacitacion.Text
        sql &= ", fecha_programada ='" & Me.txt_fecha_programada.Text & "'"

        If IsDate(txt_fecha_efectiva.Text) Then
            sql &= ", fecha_efectiva ='" & Me.txt_fecha_efectiva.Text & "'"
        Else
            sql &= ", fecha_efectiva= NULL"
        End If
        sql &= ", hora= " & Me.txt_hora.Text
        sql &= " , id_localidad=" & Me.cmb_localidades.SelectedValue
        sql &= ", id_estado=" & Me.cmb_estado.SelectedValue
        sql &= ", lugar=" & Me.txt_lugar.Text

        If txt_observaciones.Text = "" Then
            sql &= ", observaciones= NULL "
        Else
            sql &= ", observaciones= " & Me.txt_observaciones.Text
        End If


        If txt_descripcion.Text = "" Then
            sql &= ", descripcion= NULL "
        Else
            sql &= ", descripcion= " & Me.txt_descripcion.Text
        End If

        sql &= ", duracion_prevista= " & Me.txt_duracion_prevista.Text

        If txt_duracion_real.Text = "" Then
            sql &= ", duracion_real= NULL"
        Else
            sql &= ", duracion_real= " & Me.txt_duracion_real.Text
        End If

        sql &= ", id_tipo= " & Me.cmb_tipo_capacitaciones.SelectedValue

        acceso.insertar(sql)
    End Sub
 

    Private Sub cmd_agregar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_agregar_empleado.Click
        agregar_en_grilla_empleados()
    End Sub


    Private Sub cmd_limpiar_empleados_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_empleados.Click
        limpiar_empleados()
    End Sub

    Private Sub limpiar_empleados()
        Me.dgv_empleados.Enabled = True
        Me.cmb_tipos_documento.SelectedIndex = -1
        Me.cmd_eliminar_empleado.Enabled = True
        Me.cmd_empleado_nuevo.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_numero_doc.Text = ""
        Me.txt_id_empleado.Text = ""
        Me.txt_nombres_empleado.Text = ""
        Me.txt_apellido_empleado.Text = ""
        Me.txt_realizoEvaluacion.Text = ""
        Me.txt_observaciones2.Text = ""
    End Sub

    Private Function validar_empleado() As Boolean
        If txt_id_empleado.Text = "" Then
            MessageBox.Show("¡No se puede agregar un empleado sin su ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_id_empleado.Focus()
            Exit Function
        ElseIf txt_nombres_empleado.Text = "" Then
            MessageBox.Show("¡El campo nombre no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_nombres_empleado.Focus()
            Exit Function
        ElseIf txt_apellido_empleado.Text = "" Then
            MessageBox.Show("¡El campo apellido no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_apellido_empleado.Focus()
            Exit Function
        ElseIf txt_numero_doc.Text = "" Then
            MessageBox.Show("¡El campo número de documento no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_numero_doc.Focus()
            Return False
            Exit Function
        ElseIf cmb_tipos_documento.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de documento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_tipos_documento.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub agregar_en_grilla_empleados()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0

        If validar_empleado() = True Then
            For c = 0 To dgv_empleados.Rows.Count - 1
                If Me.txt_id_empleado.Text = dgv_empleados.Rows(c).Cells("id").Value Then
                    dgv_empleados.Rows(c).Cells("id").Value = txt_id_empleado.Text
                    dgv_empleados.Rows(c).Cells("numero").Value = txt_numero_doc.Text
                    dgv_empleados.Rows(c).Cells("nombres").Value = txt_nombres_empleado.Text
                    dgv_empleados.Rows(c).Cells("apellidos").Value = txt_apellido_empleado.Text
                    dgv_empleados.Rows(c).Cells("realizoEvaluacion").Value = txt_realizoEvaluacion.Text
                    dgv_empleados.Rows(c).Cells("observaciones").Value = txt_observaciones2.Text

                    sql = ""
                    sql &= "SELECT TD.descripcion FROM TIPOS_DOCUMENTO TD WHERE TD.id = " & Me.cmb_tipos_documento.SelectedValue()
                    tabla.Clear()
                    tabla = acceso.consulta(sql)
                    dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(0)("descripcion")

                    flag = True

                End If

            Next
            If flag = False Then
                dgv_empleados.Rows.Add()
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id").Value = Me.txt_id_empleado.Text
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("numero").Value = Me.txt_numero_doc.Text
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("nombres").Value = txt_nombres_empleado.Text
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("apellidos").Value = txt_apellido_empleado.Text
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("realizoEvaluacion").Value = txt_realizoEvaluacion.Text
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("observaciones").Value = txt_observaciones2.Text

                sql = ""
                sql &= "SELECT TD.descripcion FROM TIPOS_DOCUMENTO TD WHERE TD.id = " & Me.cmb_tipos_documento.SelectedValue()
                tabla.Clear()
                tabla = acceso.consulta(sql)
                dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("tipo_doc").Value = tabla.Rows(0)("descripcion")
            End If
        End If
        limpiar_empleados()
    End Sub

    Private Sub cmd_eliminar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_empleado.Click
        Dim num As Integer = dgv_empleados.CurrentRow.Index
        For c = 0 To dgv_empleados.Rows.Count - 1
            If num = c Then
                dgv_empleados.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

    Private Sub cmd_limpiar_asistencia_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_asistencia.Click
        txt_numero_doc.Text = ""
        txt_apellido_empleado.Text = ""
        txt_nombres_empleado.Text = ""
        txt_realizoEvaluacion.Text = ""
        txt_observaciones2.Text = ""
        Me.txt_id_empleado.Text = ""
        Me.cmb_tipos_documento.SelectedValue = -1
    End Sub


    Private Sub cmd_buscar_empleadoXDNI_Click(sender As Object, e As EventArgs) Handles cmd_buscar_empleadoXDNI.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        txt_id_empleado.Enabled = False


        sql &= "SELECT E.id as id_empleado, E.id_tipo_doc, E.nro_doc, E.apellidos , E.nombres, E.usuario_sigipsa "
        sql &= " FROM EMPLEADOS E "
        sql &= " WHERE nro_doc = " & Me.txt_numero_doc.Text & " AND id_tipo_doc = " & Me.cmb_tipos_documento.SelectedValue

        tabla = acceso.consulta(sql)

        If tabla.Rows().Count = 0 Then
            MessageBox.Show("No existe ningún empleado con el DNI ingresado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Me.txt_id_empleado.Text = tabla.Rows(0)("id_empleado")
            Me.cmb_tipos_documento.SelectedValue = tabla.Rows(0)("id_tipo_doc")
            Me.txt_numero_doc.Text = tabla.Rows(0)("nro_doc")
            Me.txt_apellido_empleado.Text = tabla.Rows(0)("apellidos")
            Me.txt_nombres_empleado.Text = tabla.Rows(0)("nombres")
        End If
    End Sub
    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        abm_empleados.ShowDialog()
    End Sub


    Private Sub cmd_actualizar_sigipsa_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_sigipsa.Click
        If txt_numero_doc.Text = "" Then
            MessageBox.Show("Ingrese un un numero de documento para actualizar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If cmb_tipos_documento.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un tipo de documento para actualizar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                abm_empleados.txt_nro_documento.Text = Me.txt_numero_doc.Text
                abm_empleados.cmb_tipo_doc.cargar()
                abm_empleados.cmb_tipo_doc.SelectedValue = Me.cmb_tipos_documento.SelectedValue
                abm_empleados.ShowDialog()
            End If
        End If
    End Sub

    Private Function validar_existencia_empleado(ByVal id As Integer) As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM ASISTENCIA WHERE id_capacitacion= " & Me.txt_id_capacitacion.Text
        sql &= " AND id_empleado= " & id
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function

    Private Sub cmd_guardar_asistencia_Click(sender As Object, e As EventArgs) Handles cmd_guardar_asistencia.Click
        Dim c As Integer = 0
        If txt_id_capacitacion.Text <> "" Then
            If dgv_empleados.Rows.Count() = 0 Then
                MsgBox("Debe ingresar los asistentes a la capacitacion")
                Me.txt_id_empleado.Focus()
                Exit Sub
            Else
                validar_grilla()
            End If
        Else
            MsgBox("Debe ingresar una capacitacion para poder registrar o modificar la asistencia")
            Exit Sub
        End If

        dgv_empleados.Rows.Clear()
        dgv_capas.Rows.Clear()
        limpiar_empleados()
        cargar_grilla()
    End Sub

    Private Sub validar_grilla()
        Dim c As Integer = 0
        Dim Sql As String = ""

        For c = 0 To dgv_empleados.Rows.Count() - 1
            If validar_existencia_empleado(Me.dgv_empleados.Rows(c).Cells("id").Value) = analizar_existencia.existe Then
                Sql = "UPDATE ASISTENCIA"
                Sql &= " SET realizoEvaluacion ='" & Me.dgv_empleados.Rows(c).Cells("realizoEvaluacion").Value & "'"

                If IsNothing(Me.dgv_empleados.Rows(c).Cells("observaciones").Value) Then
                    Sql &= ", observaciones= NULL "
                Else
                    Sql &= ", observaciones='" & Me.dgv_empleados.Rows(c).Cells("observaciones").Value & "'"
                End If

                Sql &= " WHERE id_capacitacion = " & Me.txt_id_capacitacion.Text
                Sql &= " AND id_empleado= " & dgv_empleados.Rows(c).Cells("id").Value
                acceso.ejecutar(Sql)

            Else
                acceso._nombre_tabla = "ASISTENCIA"


                sql &= "id_capacitacion = " & Me.txt_id_capacitacion.Text
                sql &= ", id_empleado =" & dgv_empleados.Rows(c).Cells("id").Value
                sql &= ", realizoEvaluacion=" & Me.dgv_empleados.Rows(c).Cells("realizoEvaluacion").Value

                If IsNothing(Me.dgv_empleados.Rows(c).Cells("observaciones").Value) Then
                    Sql &= ", observaciones= NULL "
                Else
                    Sql &= ", observaciones= " & Me.dgv_empleados.Rows(c).Cells("observaciones").Value
                End If
                acceso.insertar(Sql)
            End If

            Sql = ""
        Next
    End Sub


    Private Sub cmd_nueva_asistencia_Click(sender As Object, e As EventArgs) Handles cmd_nueva_asistencia.Click
        Me.limpiar(Me.Controls)
        Me.txt_realizoEvaluacion.Text = ""
        Me.txt_observaciones2.Text = ""

        If txt_id_capacitacion.Text = "" Then
            MsgBox("Recuerde que no puede cargar una asistencia si no tiene una capacitación cargada y seleccionada")
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.condicion_click = doble_Click.desactivado
        Me.txt_id_capacitacion.Text = ""
        cmb_departamento.SelectedValue = -1
        Me.cmb_tipo_capacitaciones.SelectedValue = -1
        Me.txt_fecha_programada.Text = ""
        Me.txt_fecha_efectiva.Text = ""
        Me.txt_lugar.Text = ""
        Me.cmb_localidades.SelectedValue = -1
        Me.txt_descripcion.Text = ""
        Me.txt_observaciones.Text = ""
        Me.txt_duracion_prevista.Text = ""
        Me.cmb_estado.SelectedValue = -1
        Me.txt_hora.Text = ""
    End Sub


    Private Sub cmd_buscar_efectores_Click(sender As Object, e As EventArgs)
        Registrar_efectores.ShowDialog()
    End Sub


    Private Sub cmd_actualizar_estado_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_estado.Click
        Dim sql As String = ""
        Dim tabla As DataTable

        If txt_id_capacitacion.Text = "" Then
            MessageBox.Show("Seleccione una capacitacion para actualizar el estado")
            Me.txt_id_capacitacion.Focus()
            Exit Sub
        End If

        sql &= "SELECT * FROM CAPACITACIONES WHERE id=" & Me.txt_id_capacitacion.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No se encuentra registrada la capacitacion todavia")
            Me.txt_id_capacitacion.Focus()
            Exit Sub
        Else
            If cmb_estado.SelectedValue = 3 Then
                sql &= "UPDATE CAPACITACIONES "
                sql &= " SET id_estado= " & Me.cmb_estado.SelectedValue
                sql &= " WHERE id= " & Me.txt_id_capacitacion.Text
                acceso.ejecutar(sql)
            ElseIf cmb_estado.SelectedValue = 1 Then
                If validar_post() Then
                    sql &= "UPDATE CAPACITACIONES "
                    sql &= " SET id_estado= " & Me.cmb_estado.SelectedValue
                    sql &= " WHERE id= " & Me.txt_id_capacitacion.Text
                    acceso.ejecutar(sql)

                    modificar()
                Else
                    Exit Sub
                End If
            End If
           
        End If
        cargar_grilla()
    End Sub


    Private Sub dgv_empleados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellValueChanged
        lbl_asistentes.Text = Me.dgv_empleados.Rows.Count()
    End Sub
 
  
End Class