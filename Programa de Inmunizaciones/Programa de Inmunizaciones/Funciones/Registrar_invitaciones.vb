Public Class Registrar_invitaciones

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

    Private Sub Registrar_invitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        cargar_grilla()

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Me.cmb_tipo_capacitaciones.cargar()
        If cmb_tipo_capacitaciones.SelectedValue = -1 Then
            Me.cmb_tipo_capacitaciones.cargar()
            Me.cmb_tipo_capacitaciones.SelectedValue = -1
        End If

    End Sub

    Private Sub txt_efectores_MouseEnter(sender As Object, e As EventArgs) Handles txt_efectores.MouseEnter
        If txt_efectores.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_efectores.Text & "%'"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            tltp_efectores.SetToolTip(txt_efectores, efectores)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        limpiar_todo()
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

    Private Sub dgv_capas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_capas.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        dgv_efectores.Rows.Clear()

        sql2 &= " SELECT * FROM CAPACITACIONES "
        sql2 &= " WHERE fecha_programada ='" & Me.dgv_capas.CurrentRow.Cells("fecha_programada").Value & "'"
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        Me.txt_id_capacitacion.Text = tabla2.Rows(0)("id")
        Me.cmb_tipo_capacitaciones.SelectedValue = tabla2.Rows(0)("id_tipo")
        Me.txt_lugar.Text = tabla2.Rows(0)("lugar")
        Me.txt_fecha_efectiva.Text = tabla2.Rows(0)("fecha_programada")


        sql = ""
        sql &= "SELECT * FROM INVITACIONES"
        sql &= " WHERE id_capacitacion= " & Me.txt_id_capacitacion.Text
        tabla.Rows.Clear()
        tabla = acceso.consulta(sql)
        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("La capacitacion no tiene invitaciones registradas!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.condicion_click = doble_Click.desactivado
            Exit Sub
        Else
            Dim c As Integer = 0
            dgv_efectores.Rows.Clear()
            For c = 0 To tabla.Rows.Count - 1
                dgv_efectores.Rows.Add()
                dgv_efectores.Rows(c).Cells("cuie").Value = tabla.Rows(c)("id_efector")

                sql = ""
                sql &= " SELECT * FROM EFECTORES WHERE cuie= '" & tabla.Rows(c)("id_efector") & "'"
                tabla2.Rows.Clear()
                tabla2 = acceso.consulta(sql)

                dgv_efectores.Rows(c).Cells("vacunatorio").Value = tabla2.Rows(0)("nombre")


                If IsDBNull(tabla.Rows(c)("invitacion")) = False Then
                    dgv_efectores.Rows(c).Cells("invitacion").Value = tabla.Rows(c)("invitacion")
                Else
                    dgv_efectores.Rows(c).Cells("invitacion").Value = "NO HAY INVITACION ENVIADA"
                End If

            Next
        End If

        Me.condicion_click = doble_Click.desactivado
    End Sub


    Private Sub dgv_efectores_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_efectores.CellMouseDoubleClick
        Me.condicion_click = doble_Click.activado
        Me.condicion_estado = condicion.modificar
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        If txt_id_capacitacion.Text = "" Then
            MsgBox("Debe ingresar un id de capacitacion")
        End If


        sql2 &= " SELECT * FROM INVITACIONES "
        sql2 &= " WHERE id_capacitacion =" & Me.txt_id_capacitacion.Text
        sql2 &= " AND id_efector = '" & Me.dgv_efectores.CurrentRow.Cells("cuie").Value & "'"
        tabla2 = acceso.consulta(sql2)

        If tabla2.Rows.Count() = 0 Then
            MessageBox.Show("¡No existe selección!")
            Exit Sub
        End If

        sql = "SELECT * FROM EFECTORES WHERE cuie= '" & Me.dgv_efectores.CurrentRow.Cells("cuie").Value & "'"
        tabla = acceso.consulta(sql)

        Me.txt_cuie.Text = tabla2.Rows(0)("id_efector")
        Me.txt_efectores.Text = tabla.Rows(0)("nombre")

        If IsDBNull(tabla2.Rows(0)("observaciones")) Then
            Me.txt_observaciones2.Text = "NO HAY OBSERVACIONES CARGADAS"
        Else
            Me.txt_observaciones2.Text = tabla2.Rows(0)("observaciones")
        End If

        If tabla2.Rows(0)("invitacion") = "ENVIADA" Then
            Me.chk_enviada.Checked = True
        Else
            Me.chk_confirmada.Checked = True
        End If

        Me.condicion_click = doble_Click.desactivado
    End Sub

    Private Sub nuevo()
        Me.limpiar(Me.Controls)
        Me.txt_observaciones2.Text = ""
        Me.condicion_estado = condicion.insertar
        Me.txt_id_capacitacion.Enabled = False
        Me.cmb_tipo_capacitaciones.Focus()
        Me.dgv_efectores.Rows.Clear()
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Function validar_capacitacion() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        If txt_id_capacitacion.Text = "" Then
            MessageBox.Show("¡Debe ingresar una capacitacion!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_id_capacitacion.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function


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

    Private Sub guardar()
        If validar_existencia() = analizar_existencia.existe Then
            validar_grilla()
        Else
            MessageBox.Show("Debe registrar primero la capacitacion")
            Exit Sub
        End If


        dgv_efectores.Rows.Clear()
        dgv_capas.Rows.Clear()
        limpiar(Me.Controls)
        limpiar_todo()
    End Sub




    Private Sub cmd_agregar_invitado_Click(sender As Object, e As EventArgs) Handles cmd_agregar_invitado.Click
        agregar_en_grilla_invitados()
    End Sub


    Private Sub cmd_limpiar_invitados_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_invitado.Click
        limpiar_invitados()
    End Sub

    Private Sub limpiar_invitados()
        Me.chk_confirmada.Checked = False
        Me.chk_enviada.Checked = False
        Me.txt_cuie.Text = ""
        Me.txt_efectores.Text = ""
        Me.txt_observaciones2.Text = ""
    End Sub

    Private Function validar_invitado() As Boolean
        If chk_confirmada.Checked = False Then
            If chk_enviada.Checked = False Then
                MessageBox.Show("¡Debe seleccionar si la invitacion fue enviada o confirmada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                chk_enviada.Focus()
                Exit Function
            End If
        End If
        Return True
    End Function

    Private Sub agregar_en_grilla_invitados()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim flag As Boolean = False
        Dim c As Integer = 0

        If validar_invitado() = True Then
            For c = 0 To dgv_efectores.Rows.Count - 1
                If Me.txt_cuie.Text = dgv_efectores.Rows(c).Cells("cuie").Value Then
                    dgv_efectores.Rows(c).Cells("cuie").Value = txt_cuie.Text
                    dgv_efectores.Rows(c).Cells("vacunatorio").Value = txt_efectores.Text

                    If txt_observaciones2.Text <> "" Then
                        dgv_efectores.Rows(c).Cells("observaciones").Value = txt_observaciones2.Text
                    Else
                        dgv_efectores.Rows(c).Cells("observaciones").Value = Nothing
                    End If


                    If chk_confirmada.Checked = True Then
                        dgv_efectores.Rows(c).Cells("invitacion").Value = "CONFIRMADA"
                    Else
                        dgv_efectores.Rows(c).Cells("invitacion").Value = "ENVIADA"
                    End If

                    flag = True

                End If

            Next
            If flag = False Then
                dgv_efectores.Rows.Add()
                dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("cuie").Value = txt_cuie.Text
                dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("vacunatorio").Value = txt_efectores.Text

                If txt_observaciones2.Text <> "" Then
                    dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("observaciones").Value = txt_observaciones2.Text
                Else
                    dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("observaciones").Value = Nothing
                End If


                If chk_confirmada.Checked = True Then
                    dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("invitacion").Value = "CONFIRMADA"
                Else
                    dgv_efectores.Rows(dgv_efectores.Rows.Count - 1).Cells("invitacion").Value = "ENVIADA"
                End If
                
            End If
        End If
        limpiar_invitados()
    End Sub

    Private Sub cmd_eliminar_empleado_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_invitado.Click
        Dim num As Integer = dgv_efectores.CurrentRow.Index
        For c = 0 To dgv_efectores.Rows.Count - 1
            If num = c Then
                dgv_efectores.Rows.RemoveAt(c)
                Exit For
            End If
        Next
    End Sub

    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efectores.Text <> "" Then
                sql &= "SELECT cuie FROM EFECTORES"
                sql &= " WHERE nombre='" & txt_efectores.Text & "'"
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
                sql &= "SELECT nombre as nombre FROM EFECTORES "
                sql &= " WHERE cuie='" & txt_cuie.Text & "'"
                tabla = acceso.consulta(sql)
                If tabla.Rows.Count() <> 0 Then
                    txt_efectores.Text = tabla.Rows(0)("nombre")
                End If
            End If
        End If
    End Sub


    Private Sub validar_grilla()
        Dim c As Integer = 0
        Dim Sql As String = ""

        If dgv_efectores.Rows.Count() = 0 Then
            MsgBox("Debe registrar una invitacion")
        Else
            For c = 0 To dgv_efectores.Rows.Count() - 1
                If validar_existencia_efector(Me.dgv_efectores.Rows(c).Cells("cuie").Value) = analizar_existencia.existe Then
                    Sql = ""
                    Sql = "UPDATE INVITACIONES "
                    Sql &= " SET invitacion='" & Me.dgv_efectores.Rows(c).Cells("invitacion").Value & "'"

                    If IsNothing(Me.dgv_efectores.Rows(c).Cells("observaciones").Value) Then
                        Sql &= " , observaciones= NULL "
                    Else
                        Sql &= " , observaciones='" & Me.dgv_efectores.Rows(c).Cells("observaciones").Value & "'"
                    End If

                    Sql &= " WHERE id_capacitacion = " & Me.txt_id_capacitacion.Text
                    Sql &= " AND id_efector= '" & dgv_efectores.Rows(c).Cells("cuie").Value & "'"
                    acceso.ejecutar(Sql)

                Else
                    acceso._nombre_tabla = "INVITACIONES"
                    Sql = ""
                    Sql &= "id_capacitacion = " & Me.txt_id_capacitacion.Text
                    Sql &= ", id_efector=" & dgv_efectores.Rows(c).Cells("cuie").Value
                    Sql &= ", invitacion =" & Me.dgv_efectores.Rows(c).Cells("invitacion").Value

                    If IsNothing(Me.dgv_efectores.Rows(c).Cells("observaciones").Value) Then
                        Sql &= ", observaciones=NULL"
                    Else
                        Sql &= ", observaciones= " & Me.dgv_efectores.Rows(c).Cells("observaciones").Value
                    End If
                    acceso.insertar(Sql)
                End If

                Sql = ""
            Next
        End If


        
    End Sub

    Private Function validar_existencia_efector(ByVal cuie As String) As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= " SELECT * FROM INVITACIONES WHERE id_capacitacion= " & Me.txt_id_capacitacion.Text
        sql &= " AND id_efector= '" & cuie & "'"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function



    Private Sub limpiar_todo()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = condicion.insertar
        Me.condicion_click = doble_Click.desactivado
        Me.txt_id_capacitacion.Text = ""
        Me.cmb_tipo_capacitaciones.SelectedValue = -1
        Me.txt_fecha_efectiva.Text = ""
        Me.txt_lugar.Text = ""
        Me.dgv_efectores.Rows.Clear()
        cargar_grilla()
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        limpiar_todo()
    End Sub


    Private Sub cmd_buscar_efectores_Click(sender As Object, e As EventArgs)
        Registrar_efectores.ShowDialog()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        guardar()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        nuevo()
    End Sub

    Private Sub dgv_efectores_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_efectores.CellValueChanged
        Dim valor1 As Integer = 0

        valor1 = dgv_efectores.Rows.Count()
        lbl_contador_total.Text = valor1
    End Sub
End Class