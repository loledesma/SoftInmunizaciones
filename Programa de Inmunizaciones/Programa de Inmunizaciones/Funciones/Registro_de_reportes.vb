Public Class Registro_de_reportes
    Enum condicion
        insertar
        modificar
    End Enum
    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_estado As condicion = condicion.insertar

    Dim condicion_click As doble_Click = doble_Click.desactivado

    Private Sub Regisro_de_reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)
        cmb_año.cargar()
        cmb_año.SelectedIndex() = -1
        cmb_semestre_reporte.cargar()
        cmb_semestre_reporte.SelectedIndex() = -1
        cmb_notificaciones.cargar()
        cmb_notificaciones.SelectedIndex() = -1
        cmb_carga.cargar()
        cmb_carga.SelectedIndex() = -1
        cmb_perdidas.cargar()
        cmb_perdidas.SelectedIndex() = -1
        cmb_stock.cargar()
        cmb_stock.SelectedIndex() = -1
        cmb_emite_resumen.cargar()
        cmb_emite_resumen.SelectedIndex() = -1
        cmb_tiempo_notificacion.cargar()
        cmb_tiempo_notificacion.SelectedIndex() = -1
        acceso.autocompletar(txt_responsable, "EFECTORES", "nombre")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub
    Private Sub txt_responsable_MouseEnter(sender As Object, e As EventArgs) Handles txt_responsable.MouseEnter
        If txt_responsable.Text <> "" Then
            Dim sql As String = ""
            Dim tabla As New DataTable
            Dim efectores As String = ""
            Dim empleados As String = ""
            Dim tabla2 As New DataTable

            sql &= "SELECT  EF.nombre as nombre "
            sql &= " FROM EFECTORES EF "
            sql &= " WHERE EF.nombre LIKE '%" & txt_responsable.Text & "%' AND (EF.id_tipo=2 or EF.id_tipo=3)"
            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                efectores += tabla.Rows(c)("nombre") & vbCrLf
            Next

            tltp_reportes.SetToolTip(txt_responsable, efectores)

        Else
            Exit Sub
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

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lbl_notificoOk.Click

    End Sub

    Private Sub cmd_notificaciones_Click(sender As Object, e As EventArgs) Handles cmd_notificaciones.Click
        Registrar_notificaciones.ShowDialog()
    End Sub

    Private Sub txt_responsable_LostFocus(sender As Object, e As EventArgs) Handles txt_responsable.LostFocus
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        If txt_responsable.Text <> "" Then
            sql &= "SELECT E.cuie as cuie "
            sql &= " FROM EFECTORES E "
            sql &= " WHERE E.nombres= '" & txt_responsable.Text & "'"
            tabla = acceso.consulta(sql)
            sql = ""
            sql &= "SELECT E.cuie as cuie, E.nombre as nombre "
            sql &= " FROM EFECTORES E "
            sql &= " WHERE E.referente= " & tabla.Rows(0)("cuie")
            tabla2 = acceso.consulta(sql)

            If tabla.Rows.Count() <> 0 Then

            End If
        End If
    End Sub

End Class