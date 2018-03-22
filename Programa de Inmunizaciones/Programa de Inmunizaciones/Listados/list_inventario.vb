Public Class list_inventario

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub list_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        Me.cmb_departamentos.Focus()
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer4.AutoScroll = True


        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Me.ReportViewer4.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub



    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamentos.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
                cmb_localidades.Enabled = True
                cmb_localidades.SelectedIndex = -1
                Me.txt_cuie.Text = ""
                Me.txt_efectores.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If Me.condicion_click = doble_Click.desactivado Then
            If txt_efectores.Text <> "" Then
                sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
                sql &= " WHERE E.nombre='" & txt_efectores.Text & "'"
                tabla = acceso.consulta(sql)
                txt_cuie.Text = tabla.Rows(0)("cuie")
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
                txt_efectores.Text = tabla.Rows(0)("nombre")
            End If
        End If
    End Sub



    Private Sub limpiar(ByVal de_donde As Object)
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
    End Sub

    Private Sub list_inventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub imprimir()
        Dim inventario As New DataTable
        Dim heladera As New DataTable
        Dim termos As New DataTable
        Dim termometro As New DataTable
        Dim sql As String = ""

        inventario = imprimir_inventario()
        termos = imprimir_termos()
        termometro = imprimir_termometro()
        heladera = imprimir_heladera()

        If inventario.Rows.Count() = 0 Then
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        Else
            If termos.Rows.Count() = 0 Then
                MessageBox.Show("No hay datos de termos")
            ElseIf termometro.Rows.Count() = 0 Then
                MessageBox.Show("No hay datos de termometros")
            ElseIf heladera.Rows.Count() = 0 Then
                MessageBox.Show("No hay datos de heladera")
            End If

            LISTINVENTARIOBindingSource.DataSource = inventario
            LISTINVENTHELADERABindingSource.DataSource = heladera
            LISTINVENTTERMOMETROSBindingSource.DataSource = termometro
            LISTINVENTTERMOSBindingSource.DataSource = termos

            Me.ReportViewer4.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()
            Me.ReportViewer3.RefreshReport()
        End If
    End Sub



    Private Function imprimir_inventario() As DataTable
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT IC.id_efector as cuie, E.nombre as nombre_vacunatorio, EMP.nombres as nombre_informante "
        sql &= ", EMP.apellidos as apellido_informante, IC.fecha as fecha_informacion "
        sql &= " FROM INVENTARIO_CF IC "
        sql &= " JOIN EFECTORES E ON E.cuie = IC.id_efector "
        sql &= " JOIN EMPLEADOS EMP ON IC.id_empleado = EMP.id "

        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE EF.cuie ='" & Me.txt_cuie.Text & "'"
        End If

        sql &= "ORDER BY nombre_vacunatorio "

        tabla = acceso.consulta(sql)

        Return tabla
    End Function

    Private Function imprimir_heladera() As DataTable
        Dim hoy As Date = Date.Today
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT IC.id_efector as cuie, E.nombre as nombre_vacunatorio, TH.descripcion as tipo_heladera "
        sql &= " , M.descripcion as marca_heladera, ICT.modelo as modelo, ICT.nro_serie as nro_serie "
        sql &= " , ICT.capacidad as capacidad_heladera, ICT.medidas as medidas, antiguedad = DateDiff(YEAR, ICT.fecha, '" & hoy & "') "
        sql &= " , FUN.descripcion as funciona "
        sql &= " , ICT.motivo as motivo, ICT.observaciones as observaciones "
        sql &= " FROM INVENTARIO_CF_HELADERA ICT JOIN INVENTARIO_CF IC ON ICT.id_efector = IC.id_efector "
        sql &= " JOIN EFECTORES E ON E.cuie = IC.id_efector "
        sql &= " JOIN TIPO_HELADERA TH ON TH.id = ICT.id_tipo_heladera "
        sql &= " JOIN MARCA M ON M.id = ICT.id_marca "
        sql &= " JOIN FUNCIONAMIENTO FUN ON ICT.id_funcionamiento = FUN.id "


        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE EF.cuie ='" & Me.txt_cuie.Text & "'"
        End If

        sql &= "ORDER BY nombre_vacunatorio "

        tabla = acceso.consulta(sql)

        Return tabla
    End Function

    Private Function imprimir_termos() As DataTable
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT IC.id_efector as cuie, E.nombre as nombre_vacunatorio, ICT.tipo_termo as marca_termos, ICT.cantidad as cantidad_termos "
        sql &= " , ICT.observaciones as observaciones_termos "
        sql &= " FROM INVENTARIO_CF_TERMOS ICT JOIN INVENTARIO_CF IC ON ICT.id_efector = IC.id_efector "
        sql &= " JOIN EFECTORES E ON E.cuie = IC.id_efector "



        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE EF.cuie ='" & Me.txt_cuie.Text & "'"
        End If

        sql &= "ORDER BY nombre_vacunatorio "

        tabla = acceso.consulta(sql)

        Return tabla
    End Function

    Private Function imprimir_termometro() As DataTable
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT IC.id_efector as cuie, E.nombre as nombre_vacunatorio, ICT.tipo_termometro as marca_termometros, ICT.cantidad as cantidad_termometros "
        sql &= " , ICT.observaciones as observaciones_termometros "
        sql &= " FROM INVENTARIO_CF_TERMOMETRO ICT JOIN INVENTARIO_CF IC ON ICT.id_efector = IC.id_efector "
        sql &= " JOIN EFECTORES E ON E.cuie = IC.id_efector "



        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad= " & Me.cmb_localidades.SelectedValue
            ElseIf txt_cuie.Text <> "" Then
                sql &= " AND E.cuie ='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_localidad= " & Me.cmb_localidades.SelectedValue
            If txt_cuie.Text <> "" Then
                sql &= " AND E.cuie='" & Me.txt_cuie.Text & "'"
            End If
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE EF.cuie ='" & Me.txt_cuie.Text & "'"
        End If

        sql &= "ORDER BY nombre_vacunatorio "

        tabla = acceso.consulta(sql)

        Return tabla
    End Function


    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Me.ReportViewer1.Width = Me.Width - 50
        'Me.ReportViewer1.Height = Me.Height - 200

        'Me.ReportViewer1.Anchor = AnchorStyles.Left
        'Me.ReportViewer1.Anchor = AnchorStyles.Right
        'Me.ReportViewer1.PerformAutoScale()

        Me.TabControl1.Width = Me.Width - 50
        Me.TabControl1.Height = Me.Height - 200



    End Sub

   
End Class