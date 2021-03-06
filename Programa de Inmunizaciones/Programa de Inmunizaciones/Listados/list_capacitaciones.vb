﻿Public Class list_capacitaciones

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_click = doble_Click.desactivado

    Private Sub list_capacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_departamentos.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.cargar()
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_departamentos.Focus()
        Me.ReportViewer1.Clear()

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_departamentos.SelectedIndex <> -1 Then
                cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
                cmb_localidades.Enabled = True
                cmb_localidades.SelectedIndex = -1
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

    Private Sub list_atenciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validar_fecha() As Boolean
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        Dim desde As Date = txt_fecha_desde.Text
        Dim hasta As Date = txt_fecha_hasta.Text
        Dim limite As Date = "01/01/1990"

        If Me.txt_fecha_hasta.Text > hoy Then
            MessageBox.Show("La fecha ingresada (hasta) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_hasta.Focus()
            Return False
        ElseIf desde > hasta Then
            MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Return False
        ElseIf desde < limite Then
            MessageBox.Show("La fecha ingresada (desde) es inválida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Return False
        End If
        Return True
    End Function

    'Private Function validar() As Boolean
    '    If cmb_departamentos.SelectedIndex <> -1 Then
    '        If cmb_localidades.SelectedIndex = -1 Then
    '            MessageBox.Show("Debe seleccionar la localidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.cmb_localidades.Focus()
    '            Return False
    '            Exit Function
    '        ElseIf txt_cuie.Text = "" Then
    '            MessageBox.Show("Debe ingresar el cuie", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_cuie.Focus()
    '            Return False
    '            Exit Function
    '        ElseIf txt_efectores.Text = "" Then
    '            MessageBox.Show("Debe ingresar el efector", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.txt_efectores.Focus()
    '            Return False
    '            Exit Function
    '        End If
    '    End If
    '    Return True
    'End Function

    Private Sub imprimir()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT C.fecha_efectiva as fecha_efectiva, L.descripcion as nombre_localidad, T.descripcion as tipo_capacitacion "
        sql &= " , C.descripcion as descripcion "
        sql &= " FROM CAPACITACIONES C "
        sql &= " JOIN LOCALIDADES L ON C.id_localidad = L.id "
        sql &= " JOIN DEPARTAMENTOS D ON L.id_departamento = D.id "
        sql &= " JOIN TIPO_CAPACITACIONES T ON C.id_tipo = T.id "


        If IsDate(txt_fecha_desde.Text) And IsDate(txt_fecha_hasta.Text) = False Then
            MessageBox.Show("Debe ingresar las dos fechas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_hasta.Focus()
            Exit Sub
        ElseIf IsDate(txt_fecha_hasta.Text) And IsDate(txt_fecha_desde.Text) = False Then
            MessageBox.Show("Debe ingresar las dos fechas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_fecha_desde.Focus()
            Exit Sub
        End If

        If IsDate(Me.txt_fecha_desde.Text) And IsDate(Me.txt_fecha_hasta.Text) Then
            If Me.validar_fecha() = False Then
                Exit Sub
            Else
                sql &= " WHERE fecha_efectiva BETWEEN '" & Me.txt_fecha_desde.Text & "' AND '" & Me.txt_fecha_hasta.Text & "'"
            End If
            If Me.cmb_departamentos.SelectedIndex <> -1 Then
                sql &= " AND D.id = " & Me.cmb_departamentos.SelectedValue
            ElseIf cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id= " & Me.cmb_localidades.SelectedValue

            End If
        ElseIf Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id= " & Me.cmb_localidades.SelectedValue
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE L.id= " & Me.cmb_localidades.SelectedValue
        End If

        sql &= "ORDER BY fecha_efectiva, tipo_capacitacion "

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.ReportViewer1.Clear()
            MessageBox.Show("No hay datos para esa búsqueda")
            Exit Sub
        End If

        Me.LIST_CAPACITACIONESBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        Me.imprimir()
    End Sub


    Private Sub listados_notificaciones_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 200

        'Me.ReportViewer1.Anchor = AnchorStyles.Left
        'Me.ReportViewer1.Anchor = AnchorStyles.Right
        'Me.ReportViewer1.PerformAutoScale()
    End Sub
End Class