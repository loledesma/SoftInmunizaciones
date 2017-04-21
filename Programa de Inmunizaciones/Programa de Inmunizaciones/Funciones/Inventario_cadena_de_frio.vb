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
        limpiar(Me.Controls)
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedValue = -1
        Me.cmb_departamento.cargar()
        Me.cmb_departamento.SelectedValue = -1


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


    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        'Me.nuevo()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        'guardar()
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
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        If txt_cuie.Text = "" Then
            MsgBox("Debe ingresar el efector para buscar su inventario")
            Me.txt_cuie.Focus()
            Exit Sub
        Else
            sql &= "SELECT EF.cuie as cuie, EF.nombre as nombre, EF.id_localidad as id_localidad, EF.id_departamento as id_departamento "
            sql &= ", EF.tipo as tipo_efector "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.cuie='" & Me.txt_cuie.Text & "'"

            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró el efector: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cmb_departamento.SelectedValue = tabla.Rows(0)("id_departamento")
                cmb_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
                cmb_tipos_efectores.SelectedValue = tabla.Rows(0)("tipo_efector")
            End If

            sql &= "SELECT E.nombres as nombres, E.apellidos as apellidos"
            sql &= "FROM EMPLEADOS E JOIN INVENTARIO_CF_HELADERA IH JOIN E.id = IH.id_empleado "
            sql &= " WHERE IH.id_efector='" & Me.txt_cuie.Text & "'"
            tabla.Rows.Clear()
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No hay inventario de heladera para el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                txt_empleado_nombre.Text = tabla.Rows(0)("nombres")
                txt_empleado_apellido.Text = tabla.Rows(0)("apellidos")
                cargar_inventario_heladera()
                cargar_inventario_termo()
                cargar_inventario_termometro()
            End If

        End If
        limpiar(Me.Controls)
        Me.condicion_estado = condicion.modificar
    End Sub

    Private Sub cargar_inventario_heladera()

        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT IH.id as id, IH.fecha as fecha, IH.modelo as modelo, IH.nro_serie as nro_serie, "
        sql &= " IH.capacidad as capacidad, IH.medidas as medidas, IH.motivo as motivo, IH.observaciones as observaciones "
        sql &= " M.descripcion as marca, F.descripcion as funcionamiento, TH.descripcion as tipo_heladera "
        sql &= " TH.id as id_tipo_heladera, M.id as id_marca, F.id as id_funcionamiento "
        sql &= "FROM INVENTARIO_CF_HELADERA IH JOIN TIPO_HELADERA TH ON IH.id_tipo_heladera = TH.id "
        sql &= " JOIN MARCA M ON IH.id_marca = M.id JOIN FUNCIONAMIENTO F ON IH.id_funcionamiento = F.id "
        sql &= " WHERE IH.id_efector='" & Me.txt_cuie.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        For c = 0 To tabla.Rows.Count - 1
            dgv_heladeras.Rows.Clear()
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
            dgv_heladeras.Rows(c).Cells("observaciones").Value = tabla.Rows(c)("observaciones")
            dgv_heladeras.Rows(c).Cells("id_funcionamiento").Value = tabla.Rows(c)("id_funcionamiento")
            dgv_heladeras.Rows(c).Cells("funcionamiento").Value = tabla.Rows(c)("funcionamiento")
            dgv_heladeras.Rows(c).Cells("antiguedad").Value = calcular_antiguedad(tabla.Rows(c)("fecha"))
        Next

    End Sub

    Private Function calcular_antiguedad(ByRef fecha As String) As String
        Dim hoy As Date = Date.Today
        Dim comparador As Date = fecha
        Dim antiguedad As String = DateDiff(DateInterval.Year, hoy, comparador).ToString

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
        Else
            For c = 0 To tabla.Rows.Count - 1
                dgv_termos.Rows.Clear()
                dgv_termos.Rows.Add()
                dgv_termos.Rows(c).Cells("id_termo").Value = tabla.Rows(c)("id")
                dgv_heladeras.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
                dgv_heladeras.Rows(c).Cells("tipo_termo").Value = tabla.Rows(c)("tipo_termo")
                dgv_heladeras.Rows(c).Cells("observaciones_termo").Value = tabla.Rows(c)("observaciones")
                dgv_heladeras.Rows(c).Cells("cantidad").Value = tabla.Rows(c)("cantidad")
            Next

        End If
        

    End Sub

    Private Sub cargar_inventario_termometro()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT id, cantidad, tipo_termometro, observaciones "
        sql &= " FROM INVENTARIO_CF_TERMOMETRO "
        sql &= " WHERE id_efector='" & Me.txt_cuie.Text & "'"
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No hay inventario de termometro para el efector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For c = 0 To tabla.Rows.Count - 1
                dgv_termos.Rows.Clear()
                dgv_termos.Rows.Add()
                dgv_termos.Rows(c).Cells("id_termometro").Value = tabla.Rows(c)("id")
                dgv_heladeras.Rows(c).Cells("fecha_termometro").Value = tabla.Rows(c)("fecha")
                dgv_heladeras.Rows(c).Cells("tipo_termometro").Value = tabla.Rows(c)("tipo_termometro")
                dgv_heladeras.Rows(c).Cells("observaciones_termometro").Value = tabla.Rows(c)("observaciones")
                dgv_heladeras.Rows(c).Cells("cantidad_termometro").Value = tabla.Rows(c)("cantidad")
            Next
        End If
    End Sub


End Class