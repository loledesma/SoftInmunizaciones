Public Class Registrar_efectores
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

    Private Sub Registrar_efectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipos_documento.cargar()
        cmb_barrios.cargar()
        cmb_estado_rm.cargar()
        cmb_perfil.cargar()
        cmb_departamento.cargar()
        cmb_localidades.cargar()
        cmb_cargo.cargar()

        cmb_tipos_efectores.cargar()
        cmb_estado_efector.cargar()
        cmb_tipo_carga.cargar()
        cmb_estados_empleados.cargar()
        limpiar(Controls)
        cargar_grilla_vacunatorios()

        tip()
        acceso.autocompletar(txt_numero_doc, "EMPLEADOS", "nro_doc")
        acceso.autocompletar(txt_apellido, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_nombres_empleado, "EMPLEADOS", "nombres")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        acceso.autocompletar(txt_nombre, "EFECTORES", "nombre")
        acceso.autocompletar(txt_referentes, "EFECTORES", "nombre")

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub tip()
        tltp_efectores.SetToolTip(cmd_limpiar, "Limpiar")
        tltp_efectores.SetToolTip(cmd_buscar_empleadoXDNI, "Buscar id empleado por dni")
        tltp_efectores.SetToolTip(cmd_eliminar_empleado, "Eliminar empleado de la grilla")
        tltp_efectores.SetToolTip(cmd_limpiar_empleados, "Limpiar grilla de empleados")
        tltp_efectores.SetToolTip(cmd_agregar_empleado, "Agregar empleado a la grilla")
        tltp_efectores.SetToolTip(cmd_buscar_cuie, "Buscar efector por CUIE")
        tltp_efectores.SetToolTip(cmd_empleado_nuevo, "Dar de alta empleado nuevo")
        tltp_efectores.SetToolTip(cmd_guardar, "Guardar")
        tltp_efectores.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_efectores.SetToolTip(cmd_salir, "Salir")
    End Sub



    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub Registrar_efectores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
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

    Private Sub txt_nombre_LostFocus(sender As Object, e As EventArgs) Handles txt_nombre.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_nombre.Text <> "" Then
                sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
                sql &= " WHERE E.nombre='" & txt_nombre.Text & "'"
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
                    txt_nombre.Text = tabla.Rows(0)("nombre")
                End If
            End If
        End If
    End Sub

    Private Sub cargar_grilla_vacunatorios()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT TOP 10 EF.cuie, EF.nombre, E.nombre AS nombre_referente, L.descripcion AS nombre_loc FROM "
        sql &= "EFECTORES EF JOIN EFECTORES E ON EF.id_referente = E.cuie JOIN LOCALIDADES L on L.id = EF.id_localidad "
        sql &= " ORDER BY EF.id_referente desc "

        tabla = acceso.consulta(sql)

        Dim C As Integer = 0

        dgv_vacunatorios.Rows.Clear()

        For C = 0 To tabla.Rows.Count - 1
            dgv_vacunatorios.Rows.Add()

            dgv_vacunatorios.Rows(C).Cells("cuie").Value = tabla.Rows(C)("CUIE")
            dgv_vacunatorios.Rows(C).Cells("nombre").Value = tabla.Rows(C)("nombre")
            dgv_vacunatorios.Rows(C).Cells("referente").Value = tabla.Rows(C)("nombre_referente")
            dgv_vacunatorios.Rows(C).Cells("localidad").Value = tabla.Rows(C)("nombre_loc")
        Next
    End Sub
    Private Sub dgv_vacunatorios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_vacunatorios.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = estado.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""
        dgv_empleados.Rows.Clear()
        limpiar_empleados()

        sql2 &= " SELECT * FROM EFECTORES "
        sql2 &= " WHERE cuie ='" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_cuie.Text = tabla2.Rows(0)("cuie")
        Me.txt_nombre.Text = tabla2.Rows(0)("nombre")
        Me.cmb_departamento.SelectedValue = tabla2.Rows(0)("id_departamento")
        Me.cmb_localidades.SelectedValue = tabla2.Rows(0)("id_localidad")
        Me.condicion_click = doble_Click.desactivado
        Me.txt_heladera.Text = tabla2.Rows(0)("tiene_heladera")
        Me.txt_pc.Text = tabla2.Rows(0)("tiene_internet")



        If IsDBNull(tabla2.Rows(0)("estado_rm")) Then
            Me.cmb_estado_rm.SelectedIndex = -1
        Else
            Me.cmb_estado_rm.SelectedValue = tabla2.Rows(0)("estado_rm")
        End If

        If IsDBNull(tabla2.Rows(0)("id_barrio")) Then
            Me.cmb_barrios.SelectedIndex = -1
        Else
            Me.cmb_barrios.SelectedValue = tabla2.Rows(0)("id_barrio")
        End If

        If IsDBNull(tabla2.Rows(0)("calle")) Then
            txt_calle.Text = ""
        Else
            Me.txt_calle.Text = tabla2.Rows(0)("calle")
        End If

        If IsDBNull(tabla2.Rows(0)("nro")) Then
            txt_numero.Text = ""
        Else
            Me.txt_numero.Text = tabla2.Rows(0)("nro")
        End If

        If IsDBNull(tabla2.Rows(0)("telefono")) Then
            txt_telefono.Text = ""
        Else
            Me.txt_telefono.Text = tabla2.Rows(0)("telefono")
        End If

        If IsDBNull(tabla2.Rows(0)("horario_desde")) Then
            Me.txt_horarioDesde.Text = ""
        Else
            Me.txt_horarioDesde.Text = tabla2.Rows(0)("horario_desde")
        End If

        If IsDBNull(tabla2.Rows(0)("horario_hasta")) Then
            Me.txt_horarioHasta.Text = ""
        Else
            Me.txt_horarioHasta.Text = tabla2.Rows(0)("horario_hasta")
        End If

        sql = ""
        sql &= "SELECT nombre FROM EFECTORES WHERE cuie='" & tabla2.Rows(0)("id_referente") & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        Me.txt_referentes.Text = tabla.Rows(0)("nombre")
        Me.cmb_tipos_efectores.SelectedValue = tabla2.Rows(0)("id_tipo")
        If IsDBNull(tabla2.Rows(0)("id_tipo_carga")) Then
            Me.cmb_tipo_carga.SelectedIndex = -1
        Else
            Me.cmb_tipo_carga.SelectedValue = tabla2.Rows(0)("id_tipo_carga")
        End If

        Me.cmb_estado_efector.SelectedValue = tabla2.Rows(0)("id_estado")

        sql = ""
        sql &= "SELECT EM.id AS id_empleado, EM.nro_doc as nro_doc, EM.nombres AS nombre_empleado, EM.apellidos AS apellido_empleado, "
        sql &= " C.descripcion AS cargo, EM.usuario_sigipsa as usuario_sigipsa, EE.id_cargo as id_cargo, EE.id_perfil as id_perfil, TD.descripcion AS tipo_doc, "
        sql &= " ESTXEMPL.descripcion AS estado_empleado, EE.id_estado_empleado as id_estado "
        sql &= " , EE.año_curso as año_curso "
        sql &= " FROM EMPLEADOS EM JOIN EMPLEADOSXEFECTOR EE ON EM.id = EE.id_empleados "
        sql &= " JOIN TIPOS_DOCUMENTO TD ON EM.id_tipo_doc = TD.id "
        sql &= " JOIN CARGO C ON C.id = EE.id_cargo "
        sql &= " JOIN ESTADOS_EMPLEADOS ESTXEMPL ON ESTXEMPL.id = EE.id_estado_empleado  "
        sql &= "WHERE EE.id_efector='" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)



        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El efector seleccionado no tiene empleados asignados!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Dim c As Integer = 0
            dgv_empleados.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1
                dgv_empleados.Rows.Add()
                dgv_empleados.Rows(c).Cells("id").Value = tabla.Rows(c)("id_empleado")
                dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("tipo_doc")
                dgv_empleados.Rows(c).Cells("numero").Value = tabla.Rows(c)("nro_doc")
                dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombre_empleado")
                dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellido_empleado")
                dgv_empleados.Rows(c).Cells("cargo").Value = tabla.Rows(c)("cargo")
                dgv_empleados.Rows(c).Cells("usuario").Value = tabla.Rows(c)("usuario_sigipsa")
                dgv_empleados.Rows(c).Cells("id_cargo").Value = tabla.Rows(c)("id_cargo")
                dgv_empleados.Rows(c).Cells("estado_empleado").Value = tabla.Rows(c)("estado_empleado")
                dgv_empleados.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estado")

                If IsDBNull(tabla.Rows(c)("año_curso")) Then
                    dgv_empleados.Rows(c).Cells("año_curso").Value = "NO CARGADO"
                Else
                    dgv_empleados.Rows(c).Cells("año_curso").Value = tabla.Rows(c)("año_curso")
                End If

                sql = ""
                sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
                sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
                sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
                sql &= " WHERE EMP.id = " & dgv_empleados.Rows(c).Cells("id").Value & " AND EE.id_efector='" & Me.txt_cuie.Text & "'"
                tabla2.Clear()
                tabla2 = acceso.consulta(sql)

                If tabla2.Rows.Count() = 0 Then
                    dgv_empleados.Rows(c).Cells("perfil").Value = "NULL"
                    dgv_empleados.Rows(c).Cells("id_perfil").Value = "NULL"
                Else
                    dgv_empleados.Rows(c).Cells("perfil").Value = tabla2.Rows(0)("perfil")
                    dgv_empleados.Rows(c).Cells("id_perfil").Value = tabla2.Rows(0)("id_perfil")
                End If
            Next
        End If

    End Sub
    Private Sub dgv_empleados_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_empleados.CellMouseDoubleClick
        condicion_click = doble_Click.activado
        Dim tabla As DataTable
        Dim sql As String = ""


        If Me.txt_cuie.Text = "" Then
            MessageBox.Show("Debe seleccionar un efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_cuie.Focus()
            Exit Sub
        End If

        sql &= " SELECT EMP.id as id_empleado, EMP.id_tipo_doc as tipo_doc, EMP.nro_doc as nro_doc "
        sql &= " , EMP.apellidos as apellidos, EMP.nombres as nombres, EMP.usuario_sigipsa as usuario "
        sql &= " , EE.id_cargo as id_cargo, EE.id_estado_empleado as id_estado, EE.id_cargo as id_cargo "
        sql &= ", EE.año_curso as año_curso, EE.id_perfil as perfil_usuario "
        sql &= " FROM EFECTORES E JOIN EMPLEADOSXEFECTOR EE ON EE.id_efector = E.cuie "
        sql &= " JOIN EMPLEADOS EMP ON EMP.id = EE.id_empleados"
        sql &= " WHERE E.cuie ='" & Me.txt_cuie.Text & "'"
        sql &= " AND EE.id_empleados =" & Me.dgv_empleados.CurrentRow.Cells("id").Value
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡El empleado no se encuentra asignado al efector todavia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Me.txt_id_empleado.Text = tabla.Rows(0)("id_empleado")
        Me.cmb_tipos_documento.SelectedValue = tabla.Rows(0)("tipo_doc")
        Me.txt_numero_doc.Text = tabla.Rows(0)("nro_doc")
        Me.txt_apellido.Text = tabla.Rows(0)("apellidos")
        Me.txt_nombres_empleado.Text = tabla.Rows(0)("nombres")
        Me.cmb_estados_empleados.SelectedValue = tabla.Rows(0)("id_estado")
        Me.cmb_cargo.SelectedValue = tabla.Rows(0)("id_cargo")
        If IsDBNull(tabla.Rows(0)("año_curso")) Then
            txt_año_curso.Text = "0"
        Else
            txt_año_curso.Text = tabla.Rows(0)("año_curso")
        End If

        If IsDBNull(tabla.Rows(0)("perfil_usuario")) Then
            Me.cmb_perfil.SelectedIndex = -1
        Else
            Me.cmb_perfil.SelectedValue = tabla.Rows(0)("perfil_usuario")
        End If

        Me.cmd_eliminar_empleado.Enabled = False
        Me.txt_id_empleado.Enabled = False
        Me.cmd_limpiar_empleados.Enabled = True
        Me.cmd_agregar_empleado.Enabled = True
        Me.cmd_nuevo.Enabled = False

        condicion_click = doble_Click.desactivado
    End Sub

    Private Sub registrar_efectores_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamento.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamento.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamento.SelectedValue)
                cmb_localidades.Enabled = True
                cmb_localidades.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Function validar_efector() As Boolean
        If txt_cuie.Text = "" Then
            MessageBox.Show("¡Debe ingresar un CUIE!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cuie.Focus()
            Return False
            Exit Function
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("¡Debe ingresar el nombre del vacunatorio!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nombre.Focus()
            Return False
            Exit Function
        ElseIf txt_referentes.Text = "" Then
            MessageBox.Show("¡Debe ingresar un referente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_referentes.Focus()
            Return False
            Exit Function
        ElseIf cmb_estado_efector.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado para el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_efector.Focus()
            Return False
            Exit Function
        ElseIf cmb_tipo_carga.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de carga para el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_efector.Focus()
            Return False
            Exit Function
        ElseIf txt_pc.Text <> "SI" Then
            If txt_pc.Text <> "NO" Then
                If txt_pc.Text <> "DESCONOCIDO" Then
                    MessageBox.Show("¡Debe ingresar SI, NO O DESCONOCIDO!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_pc.Focus()
                    Return False
                    Exit Function
                End If
            End If
        ElseIf txt_heladera.Text <> "SI" Then
            If txt_heladera.Text <> "NO" Then
                If txt_heladera.Text <> "DESCONOCIDO" Then
                    MessageBox.Show("¡Debe ingresar SI, NO O DESCONOCIDO!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_pc.Focus()
                    Return False
                    Exit Function
                End If
            End If
        ElseIf cmb_tipos_efectores.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_tipos_efectores.Focus()
            Return False
            Exit Function
        ElseIf cmb_localidades.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar una localidad a la cual pertenezca el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            cmb_localidades.Focus()
            Exit Function
        ElseIf cmb_departamento.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un departamento al cual pertenezca el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_departamento.Focus()
            Return False
            Exit Function
        End If
        'If (txt_telefono.Text = "" Or txt_calle.Text = "" Or txt_numero.Text = "" Or txt_horarioDesde.Text = "" Or txt_horarioHasta.Text = "" Or cmb_barrios.SelectedIndex = -1) = True Then
        '    If MessageBox.Show("Hay algun/os valor/es no obligatorios sin ingresar/seleccionar, está seguro que desea continuar?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End If
        Return True
    End Function

    Private Sub guardar()
        If validar_efector() = True Then
            If condicion_estado = estado.insertar Then
                If validar_existencia() = analizar_existencia.no_existe Then
                    If dgv_empleados.Rows.Count() = 0 Then
                        If MessageBox.Show("¿Desea registrar el efector sin empleados?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                            Me.txt_id_empleado.Focus()
                            Exit Sub
                        Else
                            Me.insertar_efector()
                        End If
                    Else
                        Me.insertar_efector()
                        grabar_empleadoxefector()
                    End If
                Else
                    MessageBox.Show("Ya se encuentra registrado este efector")
                    Me.txt_cuie.Focus()
                    Exit Sub
                End If
            Else
                Me.modificar()
                modificar_empleadoXEfector()
            End If
        Else
            Exit Sub
        End If


        dgv_empleados.Rows.Clear()
        dgv_vacunatorios.Rows.Clear()
        limpiar(Me.Controls)
        cargar_grilla_vacunatorios()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT cuie FROM EFECTORES WHERE nombre='" & Me.txt_referentes.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        sql = ""
        sql = "UPDATE EFECTORES "
        sql &= " SET nombre='" & Me.txt_nombre.Text & "'"
        sql &= " , id_departamento= " & Me.cmb_departamento.SelectedValue
        sql &= " , id_localidad= " & Me.cmb_localidades.SelectedValue

        If cmb_barrios.SelectedIndex <> -1 Then
            sql &= ", id_barrio = " & Me.cmb_barrios.SelectedValue
        Else
            sql &= ", id_barrio = Null"
        End If

        If txt_calle.Text <> "" Then
            sql &= ", calle ='" & txt_calle.Text & "'"
        Else
            sql &= ", calle = Null "
        End If

        If txt_numero.Text <> "" Then
            sql &= ", nro = " & Me.txt_numero.Text
        Else
            sql &= ", nro = Null"
        End If

        If txt_telefono.Text <> "" Then
            sql &= ", telefono = " & Me.txt_telefono.Text
        Else
            sql &= ", telefono = Null "
        End If
        If txt_horarioDesde.Text <> "" Then
            sql &= ", horario_desde = " & Me.txt_horarioDesde.Text
        Else
            sql &= ", horario_desde = Null "
        End If

        If txt_horarioHasta.Text <> "" Then
            sql &= ", horario_hasta = " & Me.txt_horarioHasta.Text
        Else
            sql &= ", horario_hasta = Null"
        End If


        sql &= " , id_referente='" & tabla.Rows(0)("cuie") & "'"
        sql &= " , id_tipo= " & Me.cmb_tipos_efectores.SelectedValue
        sql &= " , id_estado= " & Me.cmb_estado_efector.SelectedValue
        sql &= " , id_tipo_carga= " & Me.cmb_tipo_carga.SelectedValue
        sql &= ", tiene_heladera='" & Me.txt_heladera.Text & "'"
        sql &= ", tiene_internet='" & Me.txt_pc.Text & "'"


        If cmb_estado_rm.SelectedValue <> -1 Then
            sql &= ", estado_rm = " & Me.cmb_estado_rm.SelectedValue
        Else
            sql &= ", estado_rm = Null"
        End If
        sql &= " WHERE cuie='" & Me.txt_cuie.Text & "'"

        acceso.ejecutar(sql)

    End Sub

    Private Sub modificar_empleadoXEfector()
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        For c = 0 To dgv_empleados.Rows.Count() - 1
            If validar_existencia_empleado(Me.dgv_empleados.Rows(c).Cells("id").Value) = analizar_existencia.existe Then
                txt_insert &= "UPDATE EMPLEADOSXEFECTOR "
                txt_insert &= " SET id_cargo= " & Me.dgv_empleados.Rows(c).Cells("id_cargo").Value
                If IsNothing(Me.dgv_empleados.Rows(c).Cells("id_perfil").Value) Then
                    txt_insert &= ", id_perfil= Null"
                Else
                    txt_insert &= ", id_perfil=" & Me.dgv_empleados.Rows(c).Cells("id_perfil").Value
                End If
                txt_insert &= ", id_estado_empleado=" & Me.dgv_empleados.Rows(c).Cells("id_estado").Value
                txt_insert &= " WHERE id_empleados= " & Me.dgv_empleados.Rows(c).Cells("id").Value & " AND id_efector='" & txt_cuie.Text & "'"

                acceso.ejecutar(txt_insert)

            Else
                acceso._nombre_tabla = "EMPLEADOSXEFECTOR"
                txt_insert = " id_efector=" & Me.txt_cuie.Text
                txt_insert &= ", id_empleados=" & Me.dgv_empleados.Rows(c).Cells("id").Value
                txt_insert &= ", id_cargo=" & Me.dgv_empleados.Rows(c).Cells("id_cargo").Value
                If IsNothing(Me.dgv_empleados.Rows(c).Cells("id_perfil").Value) Then
                    txt_insert &= ", id_perfil=Null"
                Else
                    txt_insert &= ", id_perfil=" & Me.dgv_empleados.Rows(c).Cells("id_perfil").Value
                End If

                If IsNothing(Me.dgv_empleados.Rows(c).Cells("año_curso").Value) Then
                    txt_insert &= ", año_curso=Null"
                Else
                    txt_insert &= ", año_curso=" & Me.dgv_empleados.Rows(c).Cells("año_curso").Value
                End If


                txt_insert &= ", id_estado_empleado=" & Me.dgv_empleados.Rows(c).Cells("id_estado").Value
                acceso.insertar(txt_insert)
            End If
            txt_insert = ""
        Next

        limpiar(Me.Controls)
        Me.cargar_grilla_vacunatorios()
    End Sub
    Private Sub insertar_efector()
        Dim sql As String = ""

        acceso._nombre_tabla = "EFECTORES"

        Dim tabla As New DataTable

        sql &= "SELECT cuie FROM EFECTORES WHERE nombre='" & Me.txt_referentes.Text & "'"
        tabla = acceso.consulta(sql)

        sql = ""
        sql &= "cuie =" & Me.txt_cuie.Text
        sql &= ", nombre =" & Me.txt_nombre.Text
        sql &= ", id_departamento =" & Me.cmb_departamento.SelectedValue
        sql &= ", id_localidad =" & Me.cmb_localidades.SelectedValue
        sql &= ", id_referente=" & tabla.Rows(0)("cuie")
        sql &= ", id_tipo =" & Me.cmb_tipos_efectores.SelectedValue
        sql &= ", id_tipo_carga =" & Me.cmb_tipo_carga.SelectedValue
        sql &= ", id_estado =" & Me.cmb_estado_efector.SelectedValue
        sql &= ", tiene_heladera=" & Me.txt_heladera.Text
        sql &= ", tiene_internet=" & Me.txt_pc.Text

        If cmb_estado_rm.SelectedValue <> -1 Then
            sql &= ", estado_rm = " & Me.cmb_estado_rm.SelectedValue
        Else
            sql &= ", estado_rm = Null"
        End If

        If txt_calle.Text <> "" Then
            sql &= ", calle =" & txt_calle.Text
        Else
            sql &= ", calle = Null "
        End If

        If txt_numero.Text <> "" Then
            sql &= ", nro = " & Me.txt_numero.Text
        Else
            sql &= ", nro = Null"
        End If

        If txt_telefono.Text <> "" Then
            sql &= ", telefono = " & Me.txt_telefono.Text
        Else
            sql &= ", telefono = Null "
        End If

        If txt_horarioDesde.Text <> "" Then
            sql &= ", horario_desde = " & Me.txt_horarioDesde.Text
        Else
            sql &= ", horario_desde = Null "
        End If

        If txt_horarioHasta.Text <> "" Then
            sql &= ", horario_hasta = " & Me.txt_horarioHasta.Text
        Else
            sql &= ", horario_hasta = Null"
        End If

        If cmb_barrios.SelectedIndex <> -1 Then
            sql &= ", id_barrio = " & Me.cmb_barrios.SelectedValue
        Else
            sql &= ", id_barrio = Null"
        End If
        acceso.insertar(sql)
    End Sub
    Private Function validar_empleado()
        If txt_id_empleado.Text = "" Then
            MessageBox.Show("¡No se puede agregar un empleado sin su ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_id_empleado.Focus()
            Exit Function
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("¡El campo nombre no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_nombre.Focus()
            Exit Function
        ElseIf txt_apellido.Text = "" Then
            MessageBox.Show("¡El campo apellido no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_apellido.Focus()
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
        ElseIf cmb_estados_empleados.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado para el empleado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_estados_empleados.Focus()
            Return False
            Exit Function
        ElseIf cmb_cargo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_cargo.Focus()
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_existencia_empleado(ByVal id As Integer) As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM EMPLEADOSXEFECTOR"
        sql &= " WHERE id_empleados = " & id & "AND id_efector='" & Me.txt_cuie.Text & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function
    Private Sub agregar_en_grilla_empleados()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0

        If validar_efector() = True Then
            If validar_empleado() = True Then

                For c = 0 To dgv_empleados.Rows.Count - 1
                    If Me.txt_id_empleado.Text = dgv_empleados.Rows(c).Cells("id").Value Then
                        dgv_empleados.Rows(c).Cells("id").Value = txt_id_empleado.Text
                        dgv_empleados.Rows(c).Cells("numero").Value = txt_numero_doc.Text
                        dgv_empleados.Rows(c).Cells("nombres").Value = txt_nombres_empleado.Text
                        dgv_empleados.Rows(c).Cells("apellidos").Value = txt_apellido.Text
                        dgv_empleados.Rows(c).Cells("id_estado").Value = Me.cmb_estados_empleados.SelectedValue
                        dgv_empleados.Rows(c).Cells("id_cargo").Value = Me.cmb_cargo.SelectedValue

                        If txt_año_curso.Text <> "" Then
                            dgv_empleados.Rows(c).Cells("año_curso").Value = Me.txt_año_curso.Text
                        Else
                            dgv_empleados.Rows(c).Cells("año_curso").Value = "NO CARGADO"
                        End If

                        If cmb_perfil.SelectedValue <> -1 Then
                            dgv_empleados.Rows(c).Cells("id_perfil").Value = Me.cmb_perfil.SelectedValue
                            sql = ""
                            sql &= "SELECT P.descripcion as descripcion "
                            sql &= " FROM PERFILES_SIGIPSA P "
                            sql &= "WHERE P.id = " & Me.cmb_perfil.SelectedValue
                            tabla.Clear()
                            tabla = acceso.consulta(sql)
                            dgv_empleados.Rows(c).Cells("perfil").Value = tabla.Rows(0)("descripcion")
                        Else
                            dgv_empleados.Rows(c).Cells("id_perfil").Value = "Null"
                            dgv_empleados.Rows(c).Cells("perfil").Value = "Null"
                        End If

                        sql = ""
                        sql &= "SELECT TD.descripcion FROM TIPOS_DOCUMENTO TD WHERE TD.id = " & Me.cmb_tipos_documento.SelectedValue()
                        tabla.Clear()
                        tabla = acceso.consulta(sql)
                        dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(0)("descripcion")
                        sql = ""
                        sql &= "SELECT C.descripcion as descripcion FROM CARGO C "
                        sql &= " WHERE C.id = " & Me.cmb_cargo.SelectedValue
                        tabla.Clear()
                        tabla = acceso.consulta(sql)
                        dgv_empleados.Rows(c).Cells("cargo").Value = tabla.Rows(0)("descripcion")

                        sql = ""
                        sql &= "SELECT ESTEMPL.descripcion as descripcion"
                        sql &= " FROM ESTADOS_EMPLEADOS ESTEMPL "
                        sql &= "WHERE ESTEMPL.id = " & Me.cmb_estados_empleados.SelectedValue
                        tabla.Clear()
                        tabla = acceso.consulta(sql)
                        dgv_empleados.Rows(c).Cells("estado_empleado").Value = tabla.Rows(0)("descripcion")

                        flag = True

                    End If

                Next
                If flag = False Then
                    dgv_empleados.Rows.Add()
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id").Value = Me.txt_id_empleado.Text
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("numero").Value = Me.txt_numero_doc.Text
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("nombres").Value = txt_nombres_empleado.Text
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("apellidos").Value = txt_apellido.Text
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id_estado").Value = Me.cmb_estados_empleados.SelectedValue
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id_cargo").Value = Me.cmb_cargo.SelectedValue

                    If txt_año_curso.Text <> "" Then
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("año_curso").Value = Me.txt_año_curso.Text
                    Else
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("año_curso").Value = "NO CARGADO"
                    End If

                    If cmb_perfil.SelectedValue <> -1 Then
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id_perfil").Value = Me.cmb_perfil.SelectedValue
                        sql = ""
                        sql &= "SELECT P.descripcion as descripcion "
                        sql &= " FROM PERFILES_SIGIPSA P "
                        sql &= "WHERE P.id = " & Me.cmb_perfil.SelectedValue
                        tabla.Clear()
                        tabla = acceso.consulta(sql)
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("perfil").Value = tabla.Rows(0)("descripcion")
                    Else
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("id_perfil").Value = "Null"
                        dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("perfil").Value = "Null"
                    End If
                    sql = ""
                    sql &= "SELECT TD.descripcion FROM TIPOS_DOCUMENTO TD WHERE TD.id = " & Me.cmb_tipos_documento.SelectedValue()
                    tabla.Clear()
                    tabla = acceso.consulta(sql)
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("tipo_doc").Value = tabla.Rows(0)("descripcion")
                    sql = ""
                    sql &= "SELECT C.descripcion FROM CARGO C WHERE C.id = " & Me.cmb_cargo.SelectedValue
                    tabla.Clear()
                    tabla = acceso.consulta(sql)
                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("cargo").Value = tabla.Rows(0)("descripcion")
                    'sql = ""
                    'sql &= "SELECT P.descripcion, EE.id_perfil FROM PERFILES_SIGIPSA P JOIN EMPLEADOSXEFECTOR EE ON P.id = EE.id_perfil "
                    'sql &= "WHERE EE.id_empleados = " & Me.txt_id_empleado.Text
                    'tabla.Clear()
                    'tabla = acceso.consulta(sql)
                    'dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("perfil").Value = tabla.Rows(0)("descripcion")
                    sql = ""
                    sql &= "SELECT ESTEMPL.descripcion as descripcion "
                    sql &= " FROM ESTADOS_EMPLEADOS ESTEMPL "
                    sql &= "WHERE ESTEMPL.id= " & Me.cmb_estados_empleados.SelectedValue
                    tabla.Clear()
                    tabla = acceso.consulta(sql)

                    dgv_empleados.Rows(dgv_empleados.Rows.Count - 1).Cells("estado_empleado").Value = tabla.Rows(0)("descripcion")

                End If
            End If
        End If

        limpiar_empleados()

    End Sub
    Private Sub nuevo()

        limpiar(Controls)
        condicion_estado = estado.insertar
        grp_datos_empleados.Enabled = True
        grp_datos_vacunatorio.Enabled = True
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        txt_cuie.Focus()
        Me.dgv_empleados.Rows.Clear()
        Me.dgv_vacunatorios.Rows.Clear()
        cargar_grilla_vacunatorios()
    End Sub

    Private Sub grabar_empleadoxefector()
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        acceso._nombre_tabla = "EMPLEADOSXEFECTOR"

        For c = 0 To Me.dgv_empleados.Rows.Count() - 1
            txt_insert = " id_efector=" & Me.txt_cuie.Text
            txt_insert &= ", id_empleados=" & Me.dgv_empleados.Rows(c).Cells("id").Value
            txt_insert &= ", id_cargo=" & Me.dgv_empleados.Rows(c).Cells("id_cargo").Value
            txt_insert &= ", id_estado_empleado=" & Me.dgv_empleados.Rows(c).Cells("id_estado").Value

            If IsNothing(Me.dgv_empleados.Rows(c).Cells("id_perfil").Value) Then
                txt_insert &= ", id_perfil=Null"
            Else
                txt_insert &= ", id_perfil=" & Me.dgv_empleados.Rows(c).Cells("id_perfil").Value
            End If

            If IsNothing(Me.dgv_empleados.Rows(c).Cells("año_curso").Value) Then
                txt_insert &= ", año_curso=Null"
            Else
                txt_insert &= ", año_curso=" & Me.dgv_empleados.Rows(c).Cells("año_curso").Value
            End If


            acceso.insertar(txt_insert)
            txt_insert = ""
        Next
    End Sub

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM EFECTORES "
        sql &= " WHERE cuie='" & Me.txt_cuie.Text & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        abm_empleados.ShowDialog()
    End Sub

    Private Sub cmd_buscar_empleadoXDNI_Click(sender As Object, e As EventArgs) Handles cmd_buscar_empleadoXDNI.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        txt_id_empleado.Enabled = False

        If txt_numero_doc.Text = "" Or cmb_tipos_documento.SelectedValue = -1 Then
            MsgBox("Debe seleccionar un tipo e ingresar un documento")
        Else
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
                Me.txt_apellido.Text = tabla.Rows(0)("apellidos")
                Me.txt_nombres_empleado.Text = tabla.Rows(0)("nombres")

            End If
        End If

    End Sub

    Private Sub cmd_agregar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_agregar_empleado.Click
        agregar_en_grilla_empleados()
    End Sub

    Private Sub cmd_limpiar_empleados_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_empleados.Click
        limpiar_empleados()

    End Sub

    Private Sub limpiar_empleados()
        Me.dgv_empleados.Enabled = True
        Me.cmb_estados_empleados.SelectedIndex = -1
        Me.cmb_tipos_documento.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1
        Me.cmd_eliminar_empleado.Enabled = True
        Me.cmd_empleado_nuevo.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_numero_doc.Text = ""
        Me.txt_id_empleado.Text = ""
        Me.txt_nombres_empleado.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_año_curso.Text = ""
        Me.cmb_perfil.SelectedValue = -1
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

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_id_empleado.Enabled = True
        Me.grp_datos_vacunatorio.Enabled = True
        Me.grp_datos_empleados.Enabled = True
        Me.limpiar(Me.Controls)
        Me.condicion_estado = estado.insertar
        Me.txt_cuie.Focus()
        Me.cmd_guardar.Enabled = True
        Me.dgv_empleados.Rows.Clear()
        Me.dgv_vacunatorios.Rows.Clear()
        cargar_grilla_vacunatorios()
    End Sub


    'Private Sub cmd_buscar_nombre_Click(sender As Object, e As EventArgs) Handles cmd_buscar_nombre.Click
    '    Dim sql As String = ""
    '    Dim tabla As New DataTable
    '    Dim tabla2 As New DataTable
    '    Dim c As Integer = 0
    '    If txt_cuie.Text = "" Then
    '        MessageBox.Show("Ingrese un un numero de cuie para buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_cuie.Focus()
    '        Exit Sub
    '    Else
    '        sql &= "SELECT EF.cuie, EF.nombre, E.nombre AS nombre_referente, L.descripcion AS nombre_loc FROM "
    '        sql &= "EFECTORES EF JOIN EFECTORES E ON EF.id_referente = E.cuie JOIN LOCALIDADES L on L.id = EF.id_localidad "
    '        sql &= " WHERE EF.nombre= " & Me.txt_nombre.Text
    '        tabla = acceso.consulta(sql)

    '        If tabla.Rows.Count = 0 Then
    '            MessageBox.Show("No se encontró un efector con el numero: " & Me.txt_cuie.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            dgv_vacunatorios.Rows.Clear()

    '            For c = 0 To tabla.Rows.Count - 1
    '                dgv_vacunatorios.Rows.Add()

    '                dgv_vacunatorios.Rows(c).Cells("cuie").Value = tabla.Rows(c)("CUIE")
    '                dgv_vacunatorios.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
    '                dgv_vacunatorios.Rows(c).Cells("referente").Value = tabla.Rows(c)("nombre_referente")
    '                dgv_vacunatorios.Rows(c).Cells("localidad").Value = tabla.Rows(c)("nombre_loc")
    '            Next

    '            sql &= "SELECT EM.id AS id_empleado, EM.nro_doc as nro_doc, EM.nombres AS nombre_empleado, EM.apellidos AS apellido_empleado, "
    '            sql &= " C.descripcion AS cargo, EM.usuario_sigipsa as usuario_sigipsa, EE.id_cargo as id_cargo, EE.id_perfil as id_perfil, TD.descripcion AS tipo_doc, "
    '            sql &= " ESTXEMPL.descripcion AS estado_empleado, EE.id_estado_empleado as id_estado "
    '            sql &= " FROM EMPLEADOS EM JOIN EMPLEADOSXEFECTOR EE ON EM.id = EE.id_empleados "
    '            sql &= " JOIN TIPOS_DOCUMENTO TD ON EM.id_tipo_doc = TD.id "
    '            sql &= " JOIN CARGO C ON C.id = EE.id_cargo "
    '            sql &= " JOIN ESTADOS_EMPLEADOS ESTXEMPL ON ESTXEMPL.id = EE.id_estado_empleado  "
    '            sql &= "WHERE EE.id_efector='" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"

    '            tabla2 = acceso.consulta(sql)


    '            If tabla2.Rows.Count() = 0 Then
    '                MessageBox.Show("El efector seleccionado no tiene empleados asignados!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            Else

    '                dgv_empleados.Rows.Clear()
    '                For c = 0 To tabla.Rows.Count - 1
    '                    dgv_empleados.Rows.Add()
    '                    dgv_empleados.Rows(c).Cells("id").Value = tabla.Rows(c)("id_empleado")
    '                    dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("tipo_doc")
    '                    dgv_empleados.Rows(c).Cells("numero").Value = tabla.Rows(c)("nro_doc")
    '                    dgv_empleados.Rows(c).Cells("nombres").Value = tabla.Rows(c)("nombre_empleado")
    '                    dgv_empleados.Rows(c).Cells("apellidos").Value = tabla.Rows(c)("apellido_empleado")
    '                    dgv_empleados.Rows(c).Cells("cargo").Value = tabla.Rows(c)("cargo")
    '                    dgv_empleados.Rows(c).Cells("usuario").Value = tabla.Rows(c)("usuario_sigipsa")
    '                    dgv_empleados.Rows(c).Cells("id_cargo").Value = tabla.Rows(c)("id_cargo")
    '                    dgv_empleados.Rows(c).Cells("estado_empleado").Value = tabla.Rows(c)("estado_empleado")
    '                    dgv_empleados.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estado")

    '                    sql = ""
    '                    sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
    '                    sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
    '                    sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
    '                    sql &= " WHERE EMP.id = " & dgv_empleados.Rows(c).Cells("id").Value & " AND EE.id_efector='" & Me.txt_cuie.Text & "'"
    '                    tabla2.Clear()
    '                    tabla2 = acceso.consulta(sql)

    '                    If tabla2.Rows.Count() = 0 Then
    '                        dgv_empleados.Rows(c).Cells("perfil").Value = "NULL"
    '                        dgv_empleados.Rows(c).Cells("id_perfil").Value = "NULL"
    '                    Else
    '                        dgv_empleados.Rows(c).Cells("perfil").Value = tabla2.Rows(0)("perfil")
    '                        dgv_empleados.Rows(c).Cells("id_perfil").Value = tabla2.Rows(0)("id_perfil")
    '                    End If
    '                Next
    '            End If
    '        End If
    '    End If
    '    limpiar(Me.Controls)
    '    txt_nombre.Focus()
    '    Me.condicion_estado = estado.modificar
    'End Sub

    Private Sub cmd_buscar_cuie_Click(sender As Object, e As EventArgs) Handles cmd_buscar_cuie.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim c As Integer = 0
        If txt_nombre.Text = "" Then
            MessageBox.Show("Ingrese una institucion a buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nombre.Focus()
            Exit Sub
        Else
            If txt_cuie.Text = "" Then
                sql &= "SELECT EF.cuie as cuie, EF.nombre as nombre, EF.id_localidad as id_localidad, EF.id_referente as id_referente "
                sql &= " FROM EFECTORES EF "
                sql &= " WHERE EF.nombre LIKE '%" & txt_nombre.Text & "%'"
                tabla = acceso.consulta(sql)

                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No se encontró el efector: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dgv_vacunatorios.Rows.Clear()

                    For c = 0 To tabla.Rows.Count - 1
                        dgv_vacunatorios.Rows.Add()

                        dgv_vacunatorios.Rows(c).Cells("cuie").Value = tabla.Rows(c)("CUIE")
                        dgv_vacunatorios.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")

                        sql = ""
                        sql = " SELECT descripcion as nombre_loc FROM LOCALIDADES WHERE id= " & tabla.Rows(c)("id_localidad")
                        tabla2.Rows.Clear()
                        tabla2 = acceso.consulta(sql)

                        dgv_vacunatorios.Rows(c).Cells("localidad").Value = tabla2.Rows(0)("nombre_loc")
                        sql = ""
                        sql = " SELECT nombre as nombre_referente FROM EFECTORES WHERE cuie='" & tabla.Rows(c)("id_referente") & "'"
                        tabla2.Rows.Clear()
                        tabla2 = acceso.consulta(sql)
                        dgv_vacunatorios.Rows(c).Cells("referente").Value = tabla2.Rows(0)("nombre_referente")
                    Next
                End If

            Else
                sql &= "SELECT EF.cuie as cuie, EF.nombre as nombre, EF.id_localidad as id_localidad, EF.id_referente as id_referente "
                sql &= " FROM EFECTORES EF "
                sql &= " WHERE EF.cuie='" & Me.txt_cuie.Text & "'"

                tabla = acceso.consulta(sql)

                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No se encontró el efector: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dgv_vacunatorios.Rows.Clear()

                    For c = 0 To tabla.Rows.Count - 1
                        dgv_vacunatorios.Rows.Add()

                        dgv_vacunatorios.Rows(c).Cells("cuie").Value = tabla.Rows(c)("CUIE")
                        dgv_vacunatorios.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")

                        sql = ""
                        sql = " SELECT descripcion as nombre_loc FROM LOCALIDADES WHERE id= " & tabla.Rows(c)("id_localidad")
                        tabla2.Rows.Clear()
                        tabla2 = acceso.consulta(sql)

                        dgv_vacunatorios.Rows(c).Cells("localidad").Value = tabla2.Rows(0)("nombre_loc")
                        sql = ""
                        sql = " SELECT nombre as nombre_referente FROM EFECTORES WHERE cuie='" & tabla.Rows(c)("id_referente") & "'"
                        tabla2.Rows.Clear()
                        tabla2 = acceso.consulta(sql)
                        dgv_vacunatorios.Rows(c).Cells("referente").Value = tabla2.Rows(0)("nombre_referente")
                    Next

                    sql = ""
                    sql &= "SELECT EM.id AS id_empleado, EM.nro_doc as nro_doc, EM.nombres AS nombre_empleado, EM.apellidos AS apellido_empleado, "
                    sql &= " C.descripcion AS cargo, EM.usuario_sigipsa as usuario_sigipsa, EE.id_cargo as id_cargo, EE.id_perfil as id_perfil, TD.descripcion AS tipo_doc, "
                    sql &= " ESTXEMPL.descripcion AS estado_empleado, EE.id_estado_empleado as id_estado "
                    sql &= ", EE.año_curso as año_curso "
                    sql &= " FROM EMPLEADOS EM JOIN EMPLEADOSXEFECTOR EE ON EM.id = EE.id_empleados "
                    sql &= " JOIN TIPOS_DOCUMENTO TD ON EM.id_tipo_doc = TD.id "
                    sql &= " JOIN CARGO C ON C.id = EE.id_cargo "
                    sql &= " JOIN ESTADOS_EMPLEADOS ESTXEMPL ON ESTXEMPL.id = EE.id_estado_empleado  "
                    sql &= "WHERE EE.id_efector='" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"
                    tabla2.Rows.Clear()
                    tabla2 = acceso.consulta(sql)

                    If tabla2.Rows.Count() = 0 Then
                        MessageBox.Show("El efector seleccionado no tiene empleados asignados!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        dgv_empleados.Rows.Clear()
                        For c = 0 To tabla2.Rows.Count - 1
                            dgv_empleados.Rows.Add()
                            dgv_empleados.Rows(c).Cells("id").Value = tabla2.Rows(c)("id_empleado")
                            dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla2.Rows(c)("tipo_doc")
                            dgv_empleados.Rows(c).Cells("numero").Value = tabla2.Rows(c)("nro_doc")
                            dgv_empleados.Rows(c).Cells("nombres").Value = tabla2.Rows(c)("nombre_empleado")
                            dgv_empleados.Rows(c).Cells("apellidos").Value = tabla2.Rows(c)("apellido_empleado")
                            dgv_empleados.Rows(c).Cells("cargo").Value = tabla2.Rows(c)("cargo")
                            dgv_empleados.Rows(c).Cells("usuario").Value = tabla2.Rows(c)("usuario_sigipsa")
                            dgv_empleados.Rows(c).Cells("id_cargo").Value = tabla2.Rows(c)("id_cargo")
                            dgv_empleados.Rows(c).Cells("estado_empleado").Value = tabla2.Rows(c)("estado_empleado")
                            dgv_empleados.Rows(c).Cells("id_estado").Value = tabla2.Rows(c)("id_estado")

                            If IsDBNull(tabla2.Rows(c)("año_curso")) Then
                                dgv_empleados.Rows(c).Cells("año_curso").Value = "SIN CARGAR"
                            Else
                                dgv_empleados.Rows(c).Cells("año_curso").Value = tabla2.Rows(c)("año_curso")
                            End If

                            sql = ""
                            sql &= "SELECT P.descripcion As perfil, P.id As id_perfil "
                            sql &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
                            sql &= " JOIN PERFILES_SIGIPSA P ON EE.id_perfil = P.id "
                            sql &= " WHERE EMP.id = " & dgv_empleados.Rows(c).Cells("id").Value & " AND EE.id_efector='" & Me.txt_cuie.Text & "'"
                            tabla.Clear()
                            tabla = acceso.consulta(sql)

                            If tabla.Rows.Count() = 0 Then
                                dgv_empleados.Rows(c).Cells("perfil").Value = "NULL"
                                dgv_empleados.Rows(c).Cells("id_perfil").Value = "NULL"
                            Else
                                dgv_empleados.Rows(c).Cells("perfil").Value = tabla.Rows(0)("perfil")
                                dgv_empleados.Rows(c).Cells("id_perfil").Value = tabla.Rows(0)("id_perfil")
                            End If


                        Next
                    End If
                End If

            End If

        End If

        limpiar(Me.Controls)
        txt_nombre.Focus()
        Me.condicion_estado = estado.modificar
    End Sub

    Private Sub dgv_vacunatorios_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vacunatorios.CellValueChanged
        Dim valor As Integer
        Dim sql As String = ""

        sql &= "SELECT COUNT(*) "
        sql &= "FROM EFECTORES"

        valor = acceso.contadores(sql)

        lbl_contador_efectores.Text = valor
    End Sub


    Private Sub cmd_cadena_de_frio_Click(sender As Object, e As EventArgs) Handles cmd_cadena_de_frio.Click
        Inventario_cadena_de_frio.ShowDialog()
    End Sub

    Private Sub cmd_notificar_Click(sender As Object, e As EventArgs) Handles cmd_notificar.Click
        Registrar_notificaciones.ShowDialog()
    End Sub

End Class