Public Class abm_empleados

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

    Private Sub abm_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        acceso.autocompletar(txt_apellido, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_nro_documento, "EMPLEADOS", "nro_doc")
        acceso.autocompletar(txt_usuario, "EMPLEADOS", "usuario_sigipsa")
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        tip()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_id_empleado.Focus()
        Me.cmb_tipo_doc.cargar()
        Me.cmb_localidades.cargar()
        Me.cmb_perfil.cargar()
        Me.cmb_cargo.cargar()
        Me.cmb_departamentos.cargar()
        Me.cmb_estados.cargar()
        Me.cmb_estado_empleado.cargar()
        Me.cmb_estados.SelectedIndex = -1
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_perfil.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1
        Me.cmb_estado_empleado.SelectedIndex = -1

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub tip()
        tltp_empleados.SetToolTip(cmd_efector_nuevo, "Dar de alta efector nuevo")
        tltp_empleados.SetToolTip(cmd_agregar_efector, "Agregar un nuevo efector al empleado")
        tltp_empleados.SetToolTip(cmd_eliminar_efector, "Eliminar un efector del empleado")
        tltp_empleados.SetToolTip(cmd_buscar_x_apellido, "Buscar empleado por apellido")
        tltp_empleados.SetToolTip(cmd_buscar_x_documento, "Buscar empleado por documento")
        tltp_empleados.SetToolTip(cmd_buscar_x_usuario, "Buscar empleado por usuario de Sigipsa")
        tltp_empleados.SetToolTip(cmd_limpiar_laboral, "Limpiar datos laborales")
        tltp_empleados.SetToolTip(cmd_guardar, "Guardar")
        tltp_empleados.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_empleados.SetToolTip(cmd_limpiar, "Limpiar")
        tltp_empleados.SetToolTip(cmd_salir, "Salir")
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

    Private Sub abm_empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            limpiar(Me.Controls)
            Me.cmb_estados.SelectedIndex = -1
            Me.cmb_departamentos.SelectedIndex = -1
            Me.cmb_tipo_doc.SelectedIndex = -1
            Me.cmb_localidades.SelectedIndex = -1
            Me.cmb_perfil.SelectedIndex = -1
            Me.cmb_cargo.SelectedIndex = -1
            Me.cmb_estado_empleado.SelectedIndex = -1
            e.Cancel = False
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_id_empleado.Enabled = True
        Me.grp_datos_laborales.Enabled = True
        Me.grp_datos_personales.Enabled = True
        Me.grp_datos_sigipsa.Enabled = True
        Me.limpiar(Me.Controls)
        Me.condicion_estado = estado.insertar
        Me.txt_id_empleado.Focus()
        txt_cuie.Enabled = True
        txt_nombre.Enabled = True
        cargar_grilla()
        Me.condicion_click = doble_Click.desactivado
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_tipo_doc.SelectedValue = 1
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        limpiar(Me.Controls)
        Me.cmb_estados.SelectedIndex = -1
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_tipo_doc.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_perfil.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1
        Me.cmb_estado_empleado.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT TOP 10 T.descripcion, E.id As id, E.nombres As nombres, E.apellidos As apellidos, E.nro_doc "
        sql &= "FROM EMPLEADOS E JOIN TIPOS_DOCUMENTO T ON E.id_tipo_doc = T.id "
        sql &= "ORDER BY E.id"
        tabla = acceso.consulta(sql)
        Me.dgv_efectores.Rows.Clear()
        Me.dgv_empleados.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_empleados.Rows.Add()
            Me.dgv_empleados.Rows(c).Cells("id_empleado").Value = tabla.Rows(c)("id")
            Me.dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
            Me.dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")
            Me.dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("descripcion")
            Me.dgv_empleados.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")
        Next
    End Sub

    'Private Sub grid_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
    '    Me.condicion_click = doble_Click.activado

    '    Dim fecha As Date
    '    Dim tabla As New DataTable
    '    Dim tabla2 As New DataTable
    '    Dim sql As String = ""
    '    Dim sql2 As String = ""

    '    sql &= " SELECT * FROM EMPLEADOS "
    '    sql &= " WHERE id = " & Me.dgv_empleados.CurrentRow.Cells(0).Value

    '    sql2 &= "SELECT E.cuie As cuie, E.id_departamento As id_depto, E.id_localidad As id_loc, EE.id_cargo As cargo, EE.id_perfil as perfil "
    '    sql2 &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
    '    sql2 &= " JOIN EFECTORES E ON EE.id_efector = E.cuie"
    '    sql2 &= " WHERE EMP.id = " & Me.dgv_empleados.CurrentRow.Cells(0).Value

    '    sql2 &= "SELECT * FROM ESTADOXUSUARIOS "
    '    sql2 &= " WHERE id_empleado= " & Me.dgv_empleados.CurrentRow.Cells(0).Value

    '    tabla = acceso.consulta(sql)
    '    tabla2 = acceso.consulta(sql2)

    '    If tabla.Rows.Count() = 0 Then
    '        MessageBox.Show("NO EXISTE SELECCION")
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

    '    If IsDBNull(tabla.Rows(0)("usuario_sigipsa")) Then
    '        Me.txt_usuario.Text = ""
    '        Me.cmb_estados.SelectedIndex = -1
    '    Else
    '        Me.txt_usuario.Text = tabla.Rows(0)("usuario_Sigipsa")
    '        Me.cmb_estados.SelectedValue = tabla2.Rows(0)("id_estado")
    '    End If

    '    If IsDBNull(tabla.Rows(0)("fecha_alta")) Then
    '        Me.txt_fecha.Text = ""
    '    Else
    '        fecha = tabla.Rows(0)("fecha_alta")
    '        Me.txt_fecha.Text = fecha.ToString("dd/MM/yyyy")
    '    End If

    '    Me.grp_datos_laborales.Enabled = True
    '    Me.grp_datos_personales.Enabled = True
    '    Me.txt_id_empleado.Enabled = False
    '    Me.grp_datos_sigipsa.Enabled = True
    '    Me.condicion_estado = estado.modificar
    '    Me.cmd_eliminar.Enabled = True
    '    Me.condicion_click = doble_Click.desactivado
    'End Sub

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamentos.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
                cmb_localidades.Enabled = True
                'cmb_localidades.SelectedIndex = -1
            End If
        End If
    End Sub



    'Private Sub cmb_localidades_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_localidades.SelectedValueChanged
    '    If Me.condicion_click = doble_Click.desactivado Then
    '        If cmb_localidades.SelectedIndex <> -1 Then
    '            cmb_efectores.ResetText()
    '            cmb_efectores.cargar("id_localidad", Me.cmb_localidades.SelectedValue)
    '            cmb_efectores.SelectedIndex = -1
    '            cmb_efectores.Enabled = True
    '        End If
    '    End If
    'End Sub
    Public Sub buscar_x_documento()
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        Dim c As Integer = 0
        If txt_nro_documento.Text = "" Then
            MessageBox.Show("Ingrese un numero de documento antes de buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nro_documento.Focus()
            Exit Sub
        ElseIf cmb_tipo_doc.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_tipo_doc.Focus()
            Exit Sub
        Else
            sql &= "SELECT EMP.id As id_empleado, EMP.id_tipo_doc As tipo_doc, EMP.nombres As nombres, EMP.apellidos As apellidos, EMP.nro_doc As nro_doc "
            sql &= " FROM EMPLEADOS EMP "
            sql &= "WHERE EMP.nro_doc = " & Me.txt_nro_documento.Text
            tabla = acceso.consulta(sql)
            sql = ""
            sql &= " SELECT EF.cuie As cuie, EF.nombre As nombre_efector, C.descripcion As cargo,  EST.descripcion As estado"
            sql &= ", EE.id_cargo as id_cargo, EE.id_estado_empleado As id_estado "
            sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
            sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
            sql &= " JOIN CARGO C ON EE.id_cargo = C.id"
            sql &= " JOIN ESTADOS_EMPLEADOS EST ON EE.id_estado_empleado = EST.id "
            sql &= " WHERE EMP.nro_doc = " & Me.txt_nro_documento.Text
            tabla2 = acceso.consulta(sql)



            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró un empleado con el numero: " & Me.txt_nro_documento.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgv_empleados.Rows.Clear()
                For c = 0 To tabla.Rows.Count - 1
                    dgv_empleados.Rows.Add()
                    dgv_empleados.Rows(c).Cells("id_empleado").Value = tabla.Rows(c)("id_empleado")
                    dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
                    dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")
                    dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("tipo_doc")
                    dgv_empleados.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")

                Next

                If tabla2.Rows.Count = 0 Then
                    MessageBox.Show("El empleado buscado no tiene efectores asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cmd_eliminar_efector.Enabled = True
                Else
                    dgv_efectores.Rows.Clear()
                    For d = 0 To tabla2.Rows.Count - 1
                        dgv_efectores.Rows.Add()
                        dgv_efectores.Rows(d).Cells("cuie").Value = tabla2.Rows(d)("cuie")
                        dgv_efectores.Rows(d).Cells("nombre_efector").Value = tabla2.Rows(d)("nombre_efector")
                        dgv_efectores.Rows(d).Cells("cargo").Value = tabla2.Rows(d)("cargo")
                        dgv_efectores.Rows(d).Cells("estado_empleado").Value = tabla2.Rows(d)("estado")
                        dgv_efectores.Rows(d).Cells("id_cargo").Value = tabla2.Rows(d)("id_cargo")
                        dgv_efectores.Rows(d).Cells("id_estado").Value = tabla2.Rows(d)("id_estado")

                        sql = ""
                        sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
                        sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
                        sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
                        sql &= " WHERE EMP.nro_doc = " & Me.txt_nro_documento.Text
                        tabla3.Clear()
                        tabla3 = acceso.consulta(sql)

                        If tabla3.Rows.Count() = 0 Then
                            dgv_efectores.Rows(d).Cells("perfil").Value = ""
                            dgv_efectores.Rows(d).Cells("id_perfil").Value = ""
                        Else
                            dgv_efectores.Rows(d).Cells("perfil").Value = tabla3.Rows(0)("perfil")
                            dgv_efectores.Rows(d).Cells("id_perfil").Value = tabla3.Rows(0)("id_perfil")
                        End If

                    Next
                End If
            End If
        End If
        limpiar(Me.Controls)
        txt_nro_documento.Focus()
        Me.cmd_eliminar_efector.Enabled = False
        Me.condicion_estado = estado.modificar
    End Sub
    Private Sub cmd_buscar_x_documento_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_documento.Click
        buscar_x_documento()
    End Sub

    Private Sub cmd_buscar_x_apellido_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_apellido.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim c As Integer = 0
        If txt_apellido.Text = "" Then
            MessageBox.Show("¡Ingrese un apellido antes de buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_apellido.Focus()
            Exit Sub
        Else
            sql &= "SELECT EMP.id As id_empleado, EMP.id_tipo_doc As tipo_doc, EMP.nombres As nombres, EMP.apellidos As apellidos, EMP.nro_doc As nro_doc "
            sql &= " FROM EMPLEADOS EMP "
            sql &= "WHERE EMP.apellidos = '" & Me.txt_apellido.Text & "'"
            tabla = acceso.consulta(sql)

            sql = ""
            sql &= " SELECT EF.cuie As cuie, EF.nombre As nombre_efector, C.descripcion As cargo, EST.descripcion As estado "
            sql &= " , EE.id_cargo as id_cargo, EE.id_estado_empleado As id_estado, EST.descripcion as estado "
            sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
            sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
            sql &= " JOIN CARGO C ON EE.id_cargo = C.id"
            sql &= " JOIN ESTADOS_EMPLEADOS EST ON EE.id_estado_empleado = EST.id "
            sql &= " WHERE EMP.apellidos = '" & Me.txt_apellido.Text & "'"
            tabla2 = acceso.consulta(sql)


            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró un empleado con el apellido: " & Me.txt_apellido.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgv_empleados.Rows.Clear()
                dgv_efectores.Rows.Clear()
                For c = 0 To tabla.Rows.Count - 1
                    dgv_empleados.Rows.Add()
                    dgv_empleados.Rows(c).Cells("id_empleado").Value = tabla.Rows(c)("id_empleado")
                    dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
                    dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")
                    dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("tipo_doc")
                    dgv_empleados.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")

                Next

                'If tabla2.Rows.Count = 0 Then
                '    MessageBox.Show("El empleado buscado no tiene efectores asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Me.cmd_eliminar_efector.Enabled = True
                'Else
                '    For c = 0 To tabla2.Rows.Count - 1
                '        dgv_efectores.Rows.Add()
                '        dgv_efectores.Rows(c).Cells("cuie").Value = tabla2.Rows(c)("cuie")
                '        dgv_efectores.Rows(c).Cells("nombre_efector").Value = tabla2.Rows(c)("nombre_efector")
                '        dgv_efectores.Rows(c).Cells("cargo").Value = tabla2.Rows(c)("cargo")
                '        dgv_efectores.Rows(c).Cells("estado_empleado").Value = tabla2.Rows(c)("estado")
                '        dgv_efectores.Rows(c).Cells("id_cargo").Value = tabla2.Rows(c)("id_cargo")
                '        dgv_efectores.Rows(c).Cells("id_estado").Value = tabla2.Rows(c)("id_estado")

                '        sql = ""
                '        sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
                '        sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
                '        sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
                '        sql &= " WHERE EMP.apellidos = '" & Me.txt_apellido.Text & "'"
                '        tabla.Clear()
                '        tabla = acceso.consulta(sql)


                '        If tabla.Rows.Count() = 0 Then
                '            dgv_efectores.Rows(c).Cells("perfil").Value = ""
                '            dgv_efectores.Rows(c).Cells("id_perfil").Value = ""
                '        Else
                '            dgv_efectores.Rows(c).Cells("perfil").Value = tabla.Rows(c)("perfil")
                '            dgv_efectores.Rows(c).Cells("id_perfil").Value = tabla.Rows(c)("id_perfil")
                '        End If


                '    Next
                'End If
            End If
        End If
        limpiar(Controls)
        txt_apellido.Focus()
        Me.cmd_eliminar_efector.Enabled = False
        Me.condicion_estado = estado.modificar
    End Sub

    Private Sub cmd_buscar_x_usuario_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_usuario.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim c As Integer = 0
        If txt_usuario.Text = "" Then
            MessageBox.Show("¡Ingrese un usuario antes de buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_usuario.Focus()
            Exit Sub
        Else
            sql &= "SELECT EMP.id As id_empleado, EMP.id_tipo_doc As tipo_doc, EMP.nombres As nombres, EMP.apellidos As apellidos, EMP.nro_doc As nro_doc "
            sql &= " FROM EMPLEADOS EMP "
            sql &= "WHERE EMP.usuario_sigipsa = '" & Me.txt_usuario.Text & "'"
            tabla = acceso.consulta(sql)
            sql = ""
            sql &= " SELECT EF.cuie As cuie, EF.nombre As nombre_efector, C.descripcion As cargo, EST.descripcion As estado "
            sql &= " , EE.id_cargo as id_cargo, EE.id_estado_empleado As id_estado "
            sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
            sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
            sql &= " JOIN CARGO C ON EE.id_cargo = C.id"
            sql &= " JOIN ESTADOS_EMPLEADOS EST ON EE.id_estado_empleado = EST.id "
            sql &= " WHERE EMP.usuario_sigipsa = '" & Me.txt_usuario.Text & "'"
            tabla2 = acceso.consulta(sql)


            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró un empleado con el usuario: " & Me.txt_usuario.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgv_empleados.Rows.Clear()
                dgv_efectores.Rows.Clear()
                For c = 0 To tabla.Rows.Count - 1
                    dgv_empleados.Rows.Add()
                    dgv_empleados.Rows(c).Cells("id_empleado").Value = tabla.Rows(c)("id_empleado")
                    dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombres")
                    dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellidos")
                    dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("tipo_doc")
                    dgv_empleados.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")

                Next
            End If
        End If
        limpiar(Controls)
        txt_usuario.Focus()
        Me.cmd_eliminar_efector.Enabled = False
        Me.condicion_estado = estado.modificar
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

    Private Function obtenerId()
        Dim id As Integer = 0
        Dim sqlId = ""
        Dim tablaId As New DataTable

        sqlId = "SELECT * FROM EMPLEADOS"
        tablaId = acceso.consulta(sqlId)

        If tablaId.Rows.Count = 0 Then
            id = 1
            txt_id_empleado.Text = id
        Else
            Dim ultimo As Integer = tablaId.Rows.Count() - 1
            id = tablaId.Rows(ultimo)("id") + 1
            txt_id_empleado.Text = id
        End If
        Return id
    End Function
    Private Sub guardar()

        If Me.validar_empleado() = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    If dgv_efectores.Rows.Count = 0 Then
                        If MessageBox.Show("¿Desea registrar el empleado sin efectores?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                            Me.cmb_departamentos.Focus()
                            Exit Sub
                        Else
                            Me.insertar_empleado()
                        End If

                    Else

                        Me.insertar_empleado()
                        grabar_empleadoxefector()
                    End If

                Else
                    MessageBox.Show("Ya se encuentra registrado este empleado")
                    Exit Sub
                End If
            Else
                Me.modificar()
                modificar_empleadoxefector()
            End If
        Else
            Exit Sub
        End If
        dgv_efectores.Rows.Clear()
        dgv_empleados.Rows.Clear()
        Me.limpiar(Me.Controls)
        Me.cargar_grilla()
        Me.txt_id_empleado.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE EMPLEADOS "
        sql &= " SET id_tipo_doc = " & Me.cmb_tipo_doc.SelectedValue
        sql &= " , nro_doc= " & Me.txt_nro_documento.Text
        sql &= " , nombres= '" & Me.txt_nombre.Text & "'"
        sql &= " , apellidos= '" & Me.txt_apellido.Text & "'"
        ' sql &= " , caracteristica= " & Me.txt_caracteristica.Text

        If txt_telefono.Text <> "" Then
            sql &= ", telefono = " & Me.txt_telefono.Text
            sql &= ", caracteristica = " & Me.txt_caracteristica.Text
        Else
            sql &= ", telefono = Null "
            sql &= ", caracteristica = Null "
        End If

        If txt_email.Text <> "" Then
            sql &= ", mail_contacto='" & Me.txt_email.Text & "'"
        Else
            sql &= ", mail_contacto= Null"
        End If

        If txt_usuario.Text <> "" Then
            sql &= " , usuario_sigipsa='" & Me.txt_usuario.Text & "'"
            sql &= " , fecha_alta= '" & Me.txt_fecha.Text & "'"
        Else
            sql &= ", usuario_sigipsa=NULL"
            sql &= ", fecha_alta=NULL"
        End If
        sql &= " WHERE id = " & Me.txt_id_empleado.Text

        acceso.ejecutar(sql)

        alta_estado()

    End Sub


    Private Function validar_existencia_efector(ByVal cuie As String) As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM EMPLEADOSXEFECTOR"
        sql &= " WHERE id_empleados = " & Me.txt_id_empleado.Text & "AND id_efector='" & cuie & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub insertar_empleado()
        Dim sql As String = ""
        Dim fecha As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim tabla As New DataTable
        acceso._nombre_tabla = "EMPLEADOS"



        sql = " id_tipo_doc = " & Me.cmb_tipo_doc.SelectedValue
        sql &= ", nro_doc = " & Me.txt_nro_documento.Text
        sql &= ", nombres=" & Me.txt_nombre.Text
        sql &= ", apellidos=" & Me.txt_apellido.Text

        If txt_telefono.Text <> "" Then
            sql &= ", telefono = " & Me.txt_telefono.Text
            sql &= ", caracteristica = " & Me.txt_caracteristica.Text
        Else
            sql &= ", telefono = Null "
            sql &= ", caracteristica = Null "
        End If
        If txt_email.Text <> "" Then
            sql &= ", mail_contacto=" & Me.txt_email.Text
        Else
            sql &= ", mail_contacto= Null"
        End If
        If txt_usuario.Text <> "" Then
            sql &= ", usuario_sigipsa=" & Me.txt_usuario.Text
        Else
            sql &= ", usuario_sigipsa=Null"
        End If

        If IsDate(txt_fecha.Text) Then
            sql &= ", fecha_alta = '" & Me.txt_fecha.Text & "'"
        Else
            sql &= ", fecha alta =Null"
        End If

        acceso.insertar(sql)

        sql = ""
        sql = "SELECT id FROM EMPLEADOS WHERE id_tipo_doc= " & Me.cmb_tipo_doc.SelectedValue & " AND nro_doc= " & Me.txt_nro_documento.Text

        tabla = acceso.consulta(sql)


        If tabla.Rows.Count() <> 0 Then
            Me.txt_id_empleado.Text = tabla.Rows(0)("id")
            If cmb_estado_empleado.SelectedValue <> -1 Then
                alta_estado()
            End If
        End If

    End Sub

    Private Sub alta_estado()
        Dim sql As String = ""

        If validar_existencia_estado() = analizar_existencia.existe Then
            sql &= "UPDATE ESTADOXUSUARIOS"
            sql &= " SET id_estado= " & Me.cmb_estados.SelectedValue
            sql &= " WHERE id_empleado= " & Me.txt_id_empleado.Text

            acceso.ejecutar(sql)
        Else
            acceso._nombre_tabla = "ESTADOXUSUARIOS"

            sql &= "id_estado = " & Me.cmb_estados.SelectedValue
            sql &= ", id_empleado = " & Me.txt_id_empleado.Text

            acceso.insertar(sql)
        End If

    End Sub

    Private Function validar_existencia_estado() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM ESTADOXUSUARIOS "
        sql &= "WHERE id_empleado= " & Me.txt_id_empleado.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM EMPLEADOS"
        sql &= " WHERE nro_doc = " & Me.txt_nro_documento.Text
        sql &= " AND id_tipo_doc = " & Me.cmb_tipo_doc.SelectedValue

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function
    Private Sub grabar_empleadoxefector()
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        For c = 0 To Me.dgv_efectores.Rows.Count() - 1
            acceso._nombre_tabla = "EMPLEADOSXEFECTOR"
            txt_insert = " id_efector=" & Me.dgv_efectores.Rows(c).Cells("cuie").Value
            txt_insert &= ", id_empleados=" & Me.txt_id_empleado.Text
            txt_insert &= ", id_cargo=" & Me.dgv_efectores.Rows(c).Cells("id_cargo").Value
            txt_insert &= ", id_estado_empleado=" & Me.dgv_efectores.Rows(c).Cells("id_estado").Value

            If IsNothing(Me.dgv_efectores.Rows(c).Cells("id_perfil").Value) Then
                txt_insert &= ", id_perfil=Null"
            Else
                txt_insert &= ", id_perfil=" & Me.dgv_efectores.Rows(c).Cells("id_perfil").Value
            End If

            acceso.insertar(txt_insert)
            txt_insert = ""
        Next
    End Sub

    Private Sub modificar_empleadoxefector()
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        For c = 0 To dgv_efectores.Rows.Count() - 1
            If validar_existencia_efector(dgv_efectores.Rows(c).Cells("cuie").Value) = analizar_existencia.existe Then
                txt_insert &= "UPDATE EMPLEADOSXEFECTOR "
                txt_insert &= " SET id_cargo= " & Me.dgv_efectores.Rows(c).Cells("id_cargo").Value

                If IsNothing(Me.dgv_efectores.Rows(c).Cells("id_perfil").Value) Then
                    txt_insert &= ", id_perfil= Null"
                Else
                    txt_insert &= ", id_perfil=" & Me.dgv_efectores.Rows(c).Cells("id_perfil").Value
                End If

                txt_insert &= ", id_estado_empleado=" & Me.dgv_efectores.Rows(c).Cells("id_estado").Value
                txt_insert &= " WHERE id_empleados= " & Me.txt_id_empleado.Text & " AND id_efector='" & Me.dgv_efectores.Rows(c).Cells("cuie").Value & "'"
                acceso.ejecutar(txt_insert)
            Else
                acceso._nombre_tabla = "EMPLEADOSXEFECTOR"
                txt_insert = " id_efector=" & Me.dgv_efectores.Rows(c).Cells("cuie").Value
                txt_insert &= ", id_empleados=" & Me.txt_id_empleado.Text
                txt_insert &= ", id_cargo=" & Me.dgv_efectores.Rows(c).Cells("id_cargo").Value

                If IsNothing(Me.dgv_efectores.Rows(c).Cells("id_perfil").Value) Then
                    txt_insert &= ", id_perfil=Null"
                Else
                    txt_insert &= ", id_perfil=" & Me.dgv_efectores.Rows(c).Cells("id_perfil").Value
                End If

                txt_insert &= ", id_estado_empleado=" & Me.dgv_efectores.Rows(c).Cells("id_estado").Value
                acceso.insertar(txt_insert)
            End If
            txt_insert = ""
        Next

        limpiar(Me.Controls)
        Me.cargar_grilla()
    End Sub

    Private Sub nuevo()
        Dim sql As String = "SELECT * FROM EMPLEADOS "
        Dim tabla As New DataTable
        limpiar(Controls)
        condicion_click = doble_Click.desactivado
        condicion_estado = estado.insertar
        tabla = acceso.consulta(sql)
        'If tabla.Rows.Count() = 0 Then
        '    Me.txt_id_empleado.Text = 1
        'Else
        '    Dim ultimo As Integer = tabla.Rows.Count() - 1
        '    Me.txt_id_empleado.Text = tabla.Rows(ultimo)("id") + 1
        'End If
        grp_datos_laborales.Enabled = True
        grp_datos_personales.Enabled = True
        grp_datos_sigipsa.Enabled = True
        txt_id_empleado.Enabled = False
        cmb_departamentos.Enabled = True
        cmb_localidades.Enabled = True
        txt_efectores.Enabled = True
        dgv_efectores.Rows.Clear()
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        Me.cmb_tipo_doc.SelectedValue = 1
        txt_nro_documento.Focus()
        Me.cmd_eliminar_efector.Enabled = True
        cargar_grilla()
    End Sub


    Private Sub dgv_empleados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_empleados.CellMouseDoubleClick
        dgv_efectores.Rows.Clear()
        limpiar(Controls)
        condicion_estado = estado.modificar
        Dim tabla As DataTable
        Dim tabla2 As DataTable
        Dim tabla3 As DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""
        txt_id_empleado.Enabled = False
        Dim fecha As Date

        sql &= "SELECT * FROM EMPLEADOS WHERE id = " & Me.dgv_empleados.CurrentRow.Cells("id_empleado").Value

        sql2 &= "SELECT * FROM ESTADOXUSUARIOS "
        sql2 &= " WHERE id_empleado= " & Me.dgv_empleados.CurrentRow.Cells(0).Value


        tabla = acceso.consulta(sql)
        tabla2 = acceso.consulta(sql2)
        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡El empleado buscado no se encuentra registrado todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.txt_id_empleado.Text = tabla.Rows(0)("id")
        Me.cmb_tipo_doc.SelectedValue = tabla.Rows(0)("id_tipo_doc")
        Me.txt_nro_documento.Text = tabla.Rows(0)("nro_doc")
        Me.txt_nombre.Text = tabla.Rows(0)("nombres")
        Me.txt_apellido.Text = tabla.Rows(0)("apellidos")

        If IsDBNull(tabla.Rows(0)("caracteristica")) Then
            Me.txt_caracteristica.Text = ""
        Else
            Me.txt_caracteristica.Text = tabla.Rows(0)("caracteristica")
        End If

        If IsDBNull(tabla.Rows(0)("telefono")) Then
            Me.txt_telefono.Text = ""
        Else
            Me.txt_telefono.Text = tabla.Rows(0)("telefono")
        End If

        If IsDBNull(tabla.Rows(0)("mail_contacto")) Then
            Me.txt_email.Text = ""
        Else
            Me.txt_email.Text = tabla.Rows(0)("mail_contacto")
        End If

        sql = ""
        sql &= "SELECT EMP.usuario_sigipsa As usuario_sigipsa, EU.id_estado As id_estado "
        sql &= " FROM EMPLEADOS EMP JOIN ESTADOXUSUARIOS EU ON EMP.id = EU.id_empleado "
        sql &= "WHERE id= " & tabla.Rows(0)("id") & " AND usuario_sigipsa IS NOT NULL "
        tabla3 = acceso.consulta(sql)

        If tabla3.Rows.Count() = 0 Then
            Me.txt_usuario.Text = ""
            Me.cmb_estados.SelectedIndex = -1
        Else
            Me.txt_usuario.Text = tabla3.Rows(0)("usuario_Sigipsa")
            Me.cmb_estados.SelectedValue = tabla3.Rows(0)("id_estado")
        End If

        If IsDBNull(tabla.Rows(0)("fecha_alta")) Then
            Me.txt_fecha.Text = ""
        Else
            fecha = tabla.Rows(0)("fecha_alta")
            Me.txt_fecha.Text = fecha.ToString("dd/MM/yyyy")
        End If

        sql = ""
        sql &= " SELECT EF.cuie As cuie, EF.nombre As nombre_efector, C.descripcion As cargo, EST.descripcion As estado "
        sql &= " , EE.id_cargo As id_cargo, EE.id_estado_empleado As id_estado "
        sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
        sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
        sql &= " JOIN CARGO C ON EE.id_cargo = C.id"
        sql &= " JOIN ESTADOS_EMPLEADOS EST ON EE.id_estado_empleado = EST.id"
        sql &= " WHERE EMP.id = " & Me.dgv_empleados.CurrentRow.Cells("id_empleado").Value
        tabla2.Clear()
        tabla2 = acceso.consulta(sql)

        If tabla2.Rows.Count = 0 Then
            MessageBox.Show("El empleado seleccionado no tiene efectores asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmd_agregar_efector.Enabled = True
        Else
            Dim c As Integer = 0
            For c = 0 To tabla2.Rows.Count() - 1
                dgv_efectores.Rows.Add()
                dgv_efectores.Rows(c).Cells("cuie").Value = tabla2.Rows(c)("cuie")
                dgv_efectores.Rows(c).Cells("nombre_efector").Value = tabla2.Rows(c)("nombre_efector")
                dgv_efectores.Rows(c).Cells("cargo").Value = tabla2.Rows(c)("cargo")
                dgv_efectores.Rows(c).Cells("estado_empleado").Value = tabla2.Rows(c)("estado")
                dgv_efectores.Rows(c).Cells("id_cargo").Value = tabla2.Rows(c)("id_cargo")
                dgv_efectores.Rows(c).Cells("id_estado").Value = tabla2.Rows(c)("id_estado")

                sql = ""
                sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
                sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
                sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
                sql &= " WHERE EMP.id = " & Me.dgv_empleados.CurrentRow.Cells("id_empleado").Value
                sql &= " AND EE.id_efector='" & tabla2.Rows(c)("cuie") & "'"
                tabla.Clear()
                tabla = acceso.consulta(sql)
                If tabla.Rows.Count() = 0 Then
                    dgv_efectores.Rows(c).Cells("perfil").Value = ""
                    dgv_efectores.Rows(c).Cells("id_perfil").Value = ""
                Else
                    dgv_efectores.Rows(c).Cells("perfil").Value = tabla.Rows(0)("perfil")
                    dgv_efectores.Rows(c).Cells("id_perfil").Value = tabla.Rows(0)("id_perfil")
                End If
            Next
        End If

        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = True
        cmd_efector_nuevo.Enabled = True
        cmd_agregar_efector.Enabled = True
        cmd_eliminar_efector.Enabled = False
        Me.condicion_estado = estado.modificar
    End Sub

    Private Sub cmd_efector_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_efector_nuevo.Click
        Registrar_efectores.ShowDialog()
    End Sub

    Private Sub dgv_efectores_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_efectores.CellMouseDoubleClick
        condicion_click = doble_Click.activado
        Dim tabla As DataTable
        Dim sql As String = ""
        txt_efectores.Enabled = False

        If Me.txt_id_empleado.Text = "" Then
            MessageBox.Show("Debe seleccionar un empleado para buscar sus efectores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_nro_documento.Focus()
            Exit Sub
        End If

        sql &= " SELECT EF.nombre As nombre_efector, EF.cuie As cuie, EF.id_departamento As dpto, EF.id_localidad As localidad, EE.id_cargo As cargo, EE.id_perfil As perfil, EE.id_estado_empleado as estado"
        sql &= " FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
        sql &= " JOIN EFECTORES EF ON EE.id_efector = EF.cuie"
        sql &= " WHERE EF.cuie = '" & Me.dgv_efectores.CurrentRow.Cells("cuie").Value & "'"
        sql &= " AND EE.id_empleados = " & Me.txt_id_empleado.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡El efector buscado no se encuentra asignado a ese empleado todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.cmb_departamentos.SelectedValue = tabla.Rows(0)("dpto")
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedValue = tabla.Rows(0)("localidad")
        Me.txt_efectores.Text = tabla.Rows(0)("nombre_efector")
        Me.txt_cuie.Text = tabla.Rows(0)("cuie")
        Me.cmb_cargo.SelectedValue = tabla.Rows(0)("cargo")
        If IsDBNull(tabla.Rows(0)("perfil")) Then
            Me.cmb_perfil.SelectedIndex = -1
        Else
            Me.cmb_perfil.SelectedValue = tabla.Rows(0)("perfil")
        End If

        Me.cmb_estado_empleado.SelectedValue = tabla.Rows(0)("estado")


        grp_datos_laborales.Enabled = True
        Me.cmd_eliminar_efector.Enabled = False
        Me.txt_cuie.Enabled = False
        Me.txt_efectores.Enabled = False
        Me.cmd_efector_nuevo.Enabled = False
        Me.cmd_limpiar_laboral.Enabled = True
        Me.cmd_agregar_efector.Enabled = True
    End Sub

    Private Function validar_empleado() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_id_empleado.Text = "..." Then
            MessageBox.Show("Debe seleccionar un id de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_empleado.Focus()
            Exit Function
        ElseIf cmb_tipo_doc.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_tipo_doc.Focus()
            Exit Function
        ElseIf IsNumeric(txt_nro_documento.Text) = False Then
            MessageBox.Show("Debe ingresar un numero de documento válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nro_documento.Focus()
            Exit Function
        ElseIf txt_nro_documento.Text = "" Then
            MessageBox.Show("Debe ingresar un numero de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nro_documento.Focus()
            Exit Function
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_nombre.Focus()
            Exit Function
        ElseIf txt_apellido.Text = "" Then
            MessageBox.Show("Debe ingresar un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_apellido.Focus()
            Exit Function
        ElseIf txt_telefono.Text <> "" Then
            If txt_caracteristica.Text = "" Then
                MessageBox.Show("Debe ingresar la caracteristica del numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Me.txt_caracteristica.Focus()
                Exit Function
            End If
        ElseIf txt_usuario.Text <> "" Then
            If cmb_estados.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un estado para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Me.cmb_estados.Focus()
                Exit Function
            ElseIf txt_fecha.Text > hoy Then
                MessageBox.Show("Debe ingresar una fecha de alta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Me.txt_fecha.Focus()
                Exit Function
            ElseIf IsDate(txt_fecha.Text) = False Then
                MessageBox.Show("Debe ingresar una fecha de alta para ese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Me.txt_fecha.Focus()
                Exit Function
            End If
        End If
        Return True
    End Function

    Private Function validar_efector() As Boolean
        If cmb_departamentos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_departamentos.Focus()
            Exit Function
        ElseIf cmb_localidades.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_localidades.Focus()
            Exit Function
        ElseIf txt_efectores.Text = "" Then
            MessageBox.Show("Debe seleccionar un efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_efectores.Focus()
            Exit Function
        ElseIf txt_cuie.Text = "" Then
            MessageBox.Show("Debe ingresar un cuie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_cuie.Focus()
            Exit Function
        ElseIf cmb_cargo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_cargo.Focus()
            Exit Function
        ElseIf cmb_estado_empleado.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un estado del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_estado_empleado.Focus()
            Exit Function
        End If
        Return True
    End Function
    Private Sub cmd_agregar_efector_Click(sender As Object, e As EventArgs) Handles cmd_agregar_efector.Click
        Dim flag As Boolean = False
        Dim tabla1 As New DataTable
        Dim sql As String = ""

        If validar_empleado() = True Then
            If validar_efector() = True Then
                For c = 0 To dgv_efectores.Rows.Count - 1
                    If Me.txt_cuie.Text = Me.dgv_efectores.Rows(c).Cells("cuie").Value Then
                        Me.dgv_efectores.Rows(c).Cells("cuie").Value = Me.txt_cuie.Text
                        Me.dgv_efectores.Rows(c).Cells("nombre_efector").Value = Me.txt_efectores.Text
                        Me.dgv_efectores.Rows(c).Cells("id_cargo").Value = Me.cmb_cargo.SelectedValue
                        Me.dgv_efectores.Rows(c).Cells("id_estado").Value = Me.cmb_estado_empleado.SelectedValue
                        sql = ""
                        sql &= "SELECT C.descripcion As descripcion FROM CARGO C "
                        sql &= " WHERE C.id = " & Me.cmb_cargo.SelectedValue
                        tabla1.Clear()
                        tabla1 = acceso.consulta(sql)
                        Me.dgv_efectores.Rows(c).Cells("cargo").Value = tabla1.Rows(0)("descripcion")

                        sql = ""
                        sql &= "SELECT ENT.descripcion AS descripcion FROM ESTADOS_EMPLEADOS ENT "
                        sql &= " WHERE ENT.id= " & Me.cmb_estado_empleado.SelectedValue
                        tabla1.Clear()
                        tabla1 = acceso.consulta(sql)
                        Me.dgv_efectores.Rows(c).Cells("estado_empleado").Value = tabla1.Rows(0)("descripcion")

                        If cmb_perfil.SelectedIndex = -1 Then
                            Me.dgv_efectores.Rows(c).Cells("id_perfil").Value = Nothing
                            Me.dgv_efectores.Rows(c).Cells("perfil").Value = Nothing
                        Else
                            Me.dgv_efectores.Rows(c).Cells("id_perfil").Value = Me.cmb_perfil.SelectedValue
                            sql = ""
                            sql &= "SELECT P.descripcion As descripcion FROM PERFILES_SIGIPSA P "
                            sql &= " WHERE P.id= " & Me.cmb_perfil.SelectedValue
                            tabla1.Clear()
                            tabla1 = acceso.consulta(sql)
                            Me.dgv_efectores.Rows(c).Cells("perfil").Value = tabla1.Rows(0)("descripcion")
                        End If

                        flag = True
                    End If
                Next
                If flag = False Then
                    Me.dgv_efectores.Rows.Add()
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("cuie").Value = Me.txt_cuie.Text
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("nombre_efector").Value = Me.txt_efectores.Text
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("id_cargo").Value = Me.cmb_cargo.SelectedValue
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("id_estado").Value = Me.cmb_estado_empleado.SelectedValue
                    sql = ""
                    sql &= "SELECT C.descripcion As descripcion FROM CARGO C "
                    sql &= " WHERE C.id= " & Me.cmb_cargo.SelectedValue
                    tabla1.Clear()
                    tabla1 = acceso.consulta(sql)
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("cargo").Value = tabla1.Rows(0)("descripcion")

                    If cmb_perfil.SelectedIndex = -1 Then
                        Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("id_perfil").Value = Nothing
                        Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("perfil").Value = Nothing
                    Else
                        Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("id_perfil").Value = Me.cmb_perfil.SelectedValue
                        sql = ""
                        sql &= "SELECT P.descripcion As descripcion FROM PERFILES_SIGIPSA P "
                        sql &= " WHERE P.id= " & Me.cmb_perfil.SelectedValue
                        tabla1.Clear()
                        tabla1 = acceso.consulta(sql)
                        Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("perfil").Value = tabla1.Rows(0)("descripcion")
                    End If

                    sql = ""
                    sql &= "SELECT ENT.descripcion AS descripcion FROM ESTADOS_EMPLEADOS ENT "
                    sql &= " WHERE ENT.id= " & Me.cmb_estado_empleado.SelectedValue
                    tabla1.Clear()
                    tabla1 = acceso.consulta(sql)
                    Me.dgv_efectores.Rows(Me.dgv_efectores.Rows.Count - 1).Cells("estado_empleado").Value = tabla1.Rows(0)("descripcion")
                End If
            End If
        End If
        Me.cmd_eliminar_efector.Enabled = True
        Me.txt_efectores.Clear()
        Me.txt_cuie.Clear()
        Me.cmb_departamentos.ResetText()
        Me.cmb_localidades.ResetText()
        Me.cmb_estado_empleado.ResetText()
        Me.cmb_departamentos.Focus()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_estado_empleado.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1
        Me.cmb_perfil.SelectedIndex = -1
    End Sub

    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efectores.Text <> "" Then
                sql &= "SELECT E.cuie as cuie, D.id as id_dpto, L.id as id_localidad FROM EFECTORES E JOIN DEPARTAMENTOS D ON D.id = E.id_departamento join LOCALIDADES L ON L.id = E.id_localidad "
                sql &= " WHERE E.nombre='" & txt_efectores.Text & "'"
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
    Private Sub cmd_eliminar_efector_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_efector.Click
        Dim num As Integer = dgv_efectores.CurrentRow.Index
        For c = 0 To dgv_efectores.Rows.Count - 1
            If num = c Then
                dgv_efectores.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

    Private Sub cmd_limpiar_laboral_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_laboral.Click
        Me.dgv_efectores.Enabled = True
        Me.cmb_departamentos.Enabled = True
        Me.cmb_localidades.Enabled = True
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_estado_empleado.SelectedIndex = -1
        Me.txt_cuie.Text = ""
        Me.txt_cuie.Enabled = True
        Me.cmb_perfil.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1
        Me.cmd_efector_nuevo.Enabled = True
        Me.cmd_eliminar_efector.Enabled = True
    End Sub

    Private Sub cmd_cambiar_estado_Click(sender As Object, e As EventArgs) Handles cmd_cambiar_estado.Click
        Me.alta_estado()
    End Sub

    Private Sub dgv_vacunatorios_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellValueChanged

        Dim valor1 As Integer
        Dim sql As String = ""

        sql &= "SELECT COUNT(*) "
        sql &= "FROM EMPLEADOS  "

        valor1 = acceso.contadores(sql)

        lbl_contador_empleados.Text = valor1
    End Sub

    'Private Sub txt_nro_documento_TextChanged(sender As Object, e As EventArgs) Handles txt_nro_documento.TextChanged
    '    acceso.autocompletar(txt_nro_documento, "EMPLEADOS", "nro_doc")
    'End Sub

    'Private Sub txt_apelldo_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged
    '    acceso.autocompletar(txt_apellido, "EMPLEADOS", "apellidos")
    'End Sub


End Class