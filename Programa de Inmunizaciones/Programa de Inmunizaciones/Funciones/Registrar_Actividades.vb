Public Class Registrar_Actividades
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

    Private Sub Registrar_Actividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
        cmb_tipo_capacitaciones.cargar()
        cmb_etapas.cargar()
        cmb_etapas.SelectedValue = -1

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM CAPACITACIONES ORDER BY fecha_programada desc "

        tabla = acceso.consulta(sql)

        Dim C As Integer = 0

        dgv_capas.Rows.Clear()

        For C = 0 To tabla.Rows.Count - 1
            dgv_capas.Rows.Add()
            dgv_capas.Rows(C).Cells("fecha_programada").Value = tabla.Rows(C)("fecha_programada")

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

    Private Sub abm_empleados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub

    Private Sub nuevo()

    End Sub

    Private Sub guardar()

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        limpiar_todo()
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

    Private Sub limpiar_todo()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.condicion_click = doble_Click.desactivado
        Me.txt_id_capacitacion.Text = ""
        Me.cmb_tipo_capacitaciones.SelectedValue = -1
        Me.txt_fecha_efectiva.Text = ""
        Me.txt_lugar.Text = ""
        cargar_grilla()
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        limpiar_todo()
    End Sub
    Private Sub cmd_buscar_capacitaciones_Click(sender As Object, e As EventArgs) Handles cmd_buscar_capacitaciones.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        If IsDate(txt_fecha_efectiva.Text) = False Then
            MsgBox("Debe ingresar una fecha para buscar la capacitacion")

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

        If IsDate(txt_fecha_efectiva.Text) = False Then
            MsgBox("Debe ingresar la fecha")
            Me.txt_fecha_efectiva.Focus()
            Exit Sub
        Else
            sql &= "SELECT * "
            sql &= " FROM CAPACITACIONES "
            sql &= " WHERE fecha_programada = '" & Me.txt_fecha_efectiva.Text & "'"

            tabla = acceso.consulta(sql)

            If tabla.Rows().Count = 0 Then
                MessageBox.Show("¡No existe una capacitacion para esa fecha!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                dgv_capas.Rows.Clear()

                For c = 0 To tabla.Rows.Count - 1
                    dgv_capas.Rows.Add()
                    dgv_capas.Rows(c).Cells("fecha_programada").Value = tabla.Rows(c)("fecha_programada")

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

    Private Sub dgv_capas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_capas.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        dgv_actividades.Rows.Clear()

        sql2 &= " SELECT * FROM CAPACITACIONES "
        sql2 &= " WHERE fecha_programada ='" & Me.dgv_capas.CurrentRow.Cells("fecha_programada").Value & "'"
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.cmb_tipo_capacitaciones.cargar()

        Me.txt_id_capacitacion.Text = tabla2.Rows(0)("id")
        Me.cmb_tipo_capacitaciones.SelectedValue = tabla2.Rows(0)("id_tipo")
        Me.txt_lugar.Text = tabla2.Rows(0)("lugar")
        Me.txt_fecha_efectiva.Text = tabla2.Rows(0)("fecha_programada")

        cargar_actividades()
        
        Me.condicion_click = doble_Click.desactivado
    End Sub

    Private Sub cargar_actividades()
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        If cmb_etapas.SelectedIndex <> -1 Then
            sql = "SELECT * FROM ACTIVIDADES WHERE id_etapa=" & Me.cmb_etapas.SelectedValue
        Else
            sql = "SELECT * FROM ACTIVIDADES"
        End If


        tabla = acceso.consulta(sql)

        dgv_actividades.Rows.Clear()

        If tabla.Rows.Count() <> 0 Then
            Dim C As Integer = 0
            For C = 0 To tabla.Rows.Count - 1
                Me.dgv_actividades.Rows.Add()
                Me.dgv_actividades.Rows(C).Cells("id_actividad").Value = tabla.Rows(C)("id")
                Me.dgv_actividades.Rows(C).Cells("actividad").Value = tabla.Rows(C)("descripcion")
            Next
        End If

        sql2 = "SELECT * FROM ACTIVIDADESXCAPACITACION WHERE id_capacitacion= " & Me.txt_id_capacitacion.Text
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() <> 0 Then
            Dim d As Integer = 0
            For d = 0 To tabla2.Rows.Count - 1
                Dim e As Integer = 0
                For e = 0 To dgv_actividades.Rows.Count() - 1
                    If tabla2.Rows(d)("id_actividad") = Me.dgv_actividades.Rows(e).Cells("id_actividad").Value Then
                        If IsDBNull(tabla2.Rows(d)("id_estado_actividad")) = False Then
                            If tabla2.Rows(d)("id_estado_actividad") = 1 Then
                                Me.dgv_actividades.Rows(e).Cells("tomada").Value = True
                            Else
                                If tabla2.Rows(d)("id_estado_actividad") = 2 Then
                                    Me.dgv_actividades.Rows(e).Cells("en_curso").Value = True
                                Else
                                    Me.dgv_actividades.Rows(e).Cells("realizada").Value = True
                                End If
                            End If
                        End If
                        If IsDBNull(tabla2.Rows(d)("observaciones")) Then
                            Me.dgv_actividades.Rows(e).Cells("observaciones").Value = Nothing
                        Else
                            Me.dgv_actividades.Rows(e).Cells("observaciones").Value = tabla2.Rows(d)("observaciones")
                        End If
                    End If
                Next
            Next
        End If
    End Sub
    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM CAPACITACIONES "
        sql &= "WHERE id =" & Me.txt_id_capacitacion.Text


        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If validar_existencia() = analizar_existencia.existe Then
            check_actividades()
        Else
            MessageBox.Show("Debe registrar primero la capacitacion")
            Exit Sub
        End If


        dgv_actividades.Rows.Clear()
        dgv_capas.Rows.Clear()
        limpiar(Me.Controls)
        limpiar_todo()
    End Sub

    Private Function validar_actividades() As Boolean
        Dim d As Integer = 0
        Dim check As Boolean = True
        For d = 0 To dgv_actividades.Rows.Count() - 1
            If dgv_actividades.Rows(d).Cells("tomada").Value = False Then
                If dgv_actividades.Rows(d).Cells("en_curso").Value = False Then
                    If dgv_actividades.Rows(d).Cells("realizada").Value = False Then
                        check = False
                    Else
                        check = True
                    End If
                Else
                    check = True
                    If dgv_actividades.Rows(d).Cells("realizada").Value = True Then
                        MsgBox("No debe dejar la actividad en dos estados")
                        check = False
                        Return check
                        Exit Function
                    End If
                End If
            Else
                If dgv_actividades.Rows(d).Cells("en_curso").Value = True Then
                    MsgBox("No debe dejar la actividad en dos estados")
                    check = False
                    Return check
                    Exit Function
                Else
                    If dgv_actividades.Rows(d).Cells("realizada").Value = True Then
                        MsgBox("No debe dejar la actividad en dos estados")
                        check = False
                        Return check
                        Exit Function
                    End If
                End If
                check = True
            End If
        Next
        Return check
    End Function


    Private Function existe_actividad(ByVal id As Integer) As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM ACTIVIDADESXCAPACITACION WHERE id_capacitacion= " & Me.txt_id_capacitacion.Text
        sql &= " AND id_actividad= " & id
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function
    Private Function validar_actividades(ByVal id_actividad As Integer) As Boolean
        Dim d As Integer = 0
        Dim check As Boolean = True
        For d = 0 To dgv_actividades.Rows.Count() - 1
            If dgv_actividades.Rows(d).Cells("id_actividad").Value = id_actividad Then
                If dgv_actividades.Rows(d).Cells("tomada").Value = False Then
                    If dgv_actividades.Rows(d).Cells("en_curso").Value = False Then
                        If dgv_actividades.Rows(d).Cells("realizada").Value = False Then
                            check = False
                            Exit For
                        Else
                            check = True
                            Exit For
                        End If
                    Else
                        check = True
                        Exit For
                    End If
                Else
                    check = True
                    Exit For
                End If
            End If
        Next
        Return check
    End Function


    Private Sub check_actividades()
        Dim c As Integer = 0
        Dim Sql As String = ""

        For c = 0 To dgv_actividades.Rows.Count() - 1
            If existe_actividad(Me.dgv_actividades.Rows(c).Cells("id_actividad").Value) = analizar_existencia.existe Then
                If validar_actividades(Me.dgv_actividades.Rows(c).Cells("id_actividad").Value) Then
                    Sql = ""
                    Sql = "UPDATE ACTIVIDADESXCAPACITACION "
                    Sql &= " SET "

                    If Me.dgv_actividades.Rows(c).Cells("realizada").Value = True Then
                        Sql &= " id_estado_actividad= 3"
                    Else
                        If Me.dgv_actividades.Rows(c).Cells("en_curso").Value = True Then
                            Sql &= " id_estado_actividad= 2"
                        Else
                            If Me.dgv_actividades.Rows(c).Cells("tomada").Value = True Then
                                Sql &= " id_estado_actividad= 1"
                            End If
                        End If
                    End If

                    If IsNothing(Me.dgv_actividades.Rows(c).Cells("observaciones").Value) Then
                        Sql &= ", observaciones=NULL"
                    Else
                        Sql &= ", observaciones= '" & Me.dgv_actividades.Rows(c).Cells("observaciones").Value & "'"
                    End If

                    Sql &= " WHERE id_capacitacion = " & Me.txt_id_capacitacion.Text
                    Sql &= " AND id_actividad= " & Me.dgv_actividades.Rows(c).Cells("id_actividad").Value
                    acceso.ejecutar(Sql)
                End If
            Else
                If validar_actividades(Me.dgv_actividades.Rows(c).Cells("id_actividad").Value) Then
                    acceso._nombre_tabla = "ACTIVIDADESXCAPACITACION"
                    Sql = ""
                    Sql &= "id_capacitacion = " & Me.txt_id_capacitacion.Text
                    Sql &= ", id_actividad= " & Me.dgv_actividades.Rows(c).Cells("id_actividad").Value

                    If Me.dgv_actividades.Rows(c).Cells("realizada").Value Then
                        Sql &= ", id_estado_actividad= 3"
                    Else
                        If Me.dgv_actividades.Rows(c).Cells("en_curso").Value Then
                            Sql &= ", id_estado_actividad= 2"
                        Else
                            If Me.dgv_actividades.Rows(c).Cells("tomada").Value Then
                                Sql &= ", id_estado_actividad= 1"
                            End If
                        End If
                    End If
                    If IsNothing(Me.dgv_actividades.Rows(c).Cells("observaciones").Value) Then
                        Sql &= ", observaciones=NULL"
                    Else
                        Sql &= ", observaciones=" & Me.dgv_actividades.Rows(c).Cells("observaciones").Value
                    End If
                    acceso.insertar(Sql)
                End If
            End If

            Sql = ""
        Next
    End Sub

    Private Sub cmd_actualizar_Click(sender As Object, e As EventArgs) Handles cmd_actualizar.Click
        cargar_actividades()
    End Sub
End Class