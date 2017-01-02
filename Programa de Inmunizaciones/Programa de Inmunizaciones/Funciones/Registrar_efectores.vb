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
        cmb_departamento.cargar()
        cmb_localidades.cargar()
        cmb_referentes.cargar()
        cmb_tipos_efectores.cargar()
        cmb_estado_efector.cargar()
        cmb_tipo_carga.cargar()
        limpiar(Controls)
        cargar_grilla_vacunatorios()
        acceso.autocompletar(txt_numero_doc, "EMPLEADOS", "nro_doc")
        acceso.autocompletar(txt_apellido, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_usuario, "EMPLEADOS", "usuario_sigipsa")

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

    Private Sub cargar_grilla_vacunatorios()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT EF.cuie, EF.nombre, E.nombre AS nombre_referente, L.descripcion AS nombre_loc FROM "
        sql &= "EFECTORES EF JOIN EFECTORES E ON EF.id_referente = E.cuie JOIN LOCALIDADES L on L.id = EF.id_localidad "

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

        sql2 &= " SELECT * FROM EFECTORES "
        sql2 &= " WHERE cuie = '" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_cuie.Text = tabla2.Rows(0)("cuie")
        Me.txt_nombre.Text = tabla2.Rows(0)("nombre")
        Me.cmb_departamento.SelectedValue = tabla2.Rows(0)("id_departamento")
        Me.cmb_localidades.SelectedValue = tabla2.Rows(0)("id_localidad")

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

        Me.cmb_referentes.SelectedValue = tabla2.Rows(0)("id_referente")
        Me.cmb_tipos_efectores.SelectedValue = tabla2.Rows(0)("id_tipo")
        If IsDBNull(tabla2.Rows(0)("id_tipo_carga")) Then
            Me.cmb_tipo_carga.SelectedIndex = -1
        Else
            Me.cmb_tipo_carga.SelectedValue = tabla2.Rows(0)("id_tipo_carga")
        End If

        Me.cmb_estado_efector.SelectedValue = tabla2.Rows(0)("id_estado")


        sql &= "SELECT EM.id AS id_empleado, EM.nro_doc, EM.nombres AS nombre_empleado, EM.apellidos AS apellido_empleado,C.descripcion AS cargo, EM.usuario_sigipsa, PS.descripcion AS perfil, EE.id_cargo, EE.id_perfil, TD.descripcion AS tipo_doc FROM "
        sql &= "EMPLEADOS EM JOIN EMPLEADOSXEFECTOR ON EM.id_empleado = EE.id_empleados JOIN TIPOS_DOCUMENTO ON EM.id_tipo_doc = TD.id JOIN PERFILES_SIGIPSA PS ON PS.id = EE.id_perfil "
        sql &= "WHERE id_efector = '" & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value & "'"

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
                dgv_empleados.Rows(c).Cells("nombre_empleado").Value = tabla.Rows(c)("nombre_empleado")
                dgv_empleados.Rows(c).Cells("apellido").Value = tabla.Rows(c)("apellido_empleado")
                dgv_empleados.Rows(c).Cells("cargo").Value = tabla.Rows(c)("cargo")
                dgv_empleados.Rows(c).Cells("usuario").Value = tabla.Rows(c)("usuario_sigipsa")
                dgv_empleados.Rows(c).Cells("perfil").Value = tabla.Rows(c)("perfil")
                dgv_empleados.Rows(c).Cells("id_cargo").Value = tabla.Rows(c)("id_cargo")
                dgv_empleados.Rows(c).Cells("id_perfil").Value = tabla.Rows(c)("id_perfil")
            Next
        End If

        Me.condicion_click = doble_Click.desactivado
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

    Private Function validar_efector() As Boolean
        If txt_cuie.Text = "" Then
            MessageBox.Show("¡Debe ingresar un CUIE!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cuie.Focus()
            Return False
            Exit Function
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("¡Debe ingresar el nombre del vacunatorio!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nombre.Focus()
            Return False
            Exit Function
        End If
        If cmb_referentes.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un referente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cmb_referentes.Focus()
            Return False
            Exit Function
        End If
        If cmb_estado_efector.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un estado para el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_efector.Focus()
            Return False
            Exit Function
        End If
        If cmb_tipo_carga.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de carga para el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_estado_efector.Focus()
            Return False
            Exit Function
        End If
        If cmb_tipos_efectores.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un tipo de efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_tipos_efectores.Focus()
            Return False
            Exit Function
        End If
        If cmb_localidades.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar una localidad a la cual pertenezca el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_localidades.Focus()
            Return False
            Exit Function
        End If
        If cmb_departamento.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar un departamento al cual pertenezca el efector!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_departamento.Focus()
            Return False
            Exit Function
        End If
        If (txt_telefono.Text = "" Or txt_calle.Text = "" Or txt_numero.Text = "" Or txt_horarioDesde.Text = "" Or txt_horarioHasta.Text = "" Or cmb_barrios.SelectedIndex = -1) = True Then
            If MessageBox.Show("Hay algun/os valor/es no obligatorios sin ingresar/seleccionar, está seguro que desea continuar?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                Return True
            Else

                Return False

            End If

        End If

        Return True
    End Function

    Private Sub guardar()
        If validar_efector() = True Then
            If Me.dgv_vacunatorios.Rows.Count = 0 Then
                If MessageBox.Show("¿Está seguro que desea registrar un efector sin empleados asignados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                Else
                    If validar_existencia() = analizar_existencia.existe Then
                        MessageBox.Show("¡El efector ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_cuie.Focus()
                    Else
                        insertar_efector()
                        Exit Sub
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub insertar_efector()
        Dim sql As String = ""

        acceso._nombre_tabla = "EFECTORES"

        sql &= "cuie=" & Me.txt_cuie.Text
        sql &= ", nombre =" & Me.txt_nombre.Text
        sql &= ", id_departamento =" & Me.cmb_departamento.SelectedValue
        sql &= ", id_localidad =" & Me.cmb_localidades.SelectedValue
        sql &= ", id_referente=" & Me.cmb_referentes.SelectedValue
        sql &= ", id_tipo =" & Me.cmb_tipos_efectores.SelectedValue
        sql &= ", id_tipo_carga =" & Me.cmb_tipo_carga.SelectedValue
        sql &= ", id_estado =" & Me.cmb_estado_efector.SelectedValue

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
        'CONTINUAR DESDE ACÁ !

    End Sub
    Private Sub nuevo()

        limpiar(Controls)
        condicion_estado = estado.insertar

        grp_datos_empleados.Enabled = True
        grp_datos_vacunatorio.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        txt_cuie.Focus()

    End Sub

    Private Sub grabar_empleadoxefector()
        Dim c As Integer = 0
        Dim txt_insert As String = ""

        acceso._nombre_tabla = "EMPLEADOSXEFECTOR"

        For c = 0 To Me.dgv_vacunatorios.Rows.Count() - 1
            txt_insert = " id_efector=" & Me.dgv_vacunatorios.Rows(c).Cells("cuie").Value
            txt_insert &= ", id_empleados=" & Me.txt_id_empleado.Text
            txt_insert &= ", id_cargo=" & Me.dgv_empleados.Rows(c).Cells("id_cargo").Value
            txt_insert &= ", id_perfil=" & Me.dgv_empleados.Rows(c).Cells("id_perfil").Value

            acceso.insertar(txt_insert)
            txt_insert = ""
        Next
    End Sub

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM EFECTORES "
        sql &= " WHERE cuie=" & Me.txt_cuie.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        If MessageBox.Show("¿Desea agregar un empleado nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            abm_empleados.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub


End Class