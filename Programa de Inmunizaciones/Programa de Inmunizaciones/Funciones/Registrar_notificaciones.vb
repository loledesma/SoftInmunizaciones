Public Class Registrar_notificaciones
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
    Private Sub Registrar_notificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Me.Controls)
        Me.cargar_grilla()
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_apellidos, "EMPLEADOS", "apellidos")
        acceso.autocompletar(txt_usuario, "EMPLEADOS", "usuario_sigipsa")
        tip()
        Me.cmd_eliminar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_id_empleado.Focus()
        Me.cmb_departamentos.cargar()
        Me.cmb_localidades.cargar()
        Me.cmb_carga.cargar()
        Me.cmb_perdidas.cargar()
        Me.cmb_stock.cargar()
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_carga.SelectedIndex = -1
        Me.cmb_perdidas.SelectedIndex = -1
        Me.cmb_stock.SelectedIndex = -1


        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub tip()
        tltp_notificaciones.SetToolTip(cmd_efector_nuevo, "Dar de alta efector nuevo")
        tltp_notificaciones.SetToolTip(cmd_buscar_empleado, "Buscar empleado")
        tltp_notificaciones.SetToolTip(cmd_buscar_notificacion, "Buscar notificación")
        tltp_notificaciones.SetToolTip(cmd_listados, "Listados")
        tltp_notificaciones.SetToolTip(cmd_estadistica, "Estadísticos")
        tltp_notificaciones.SetToolTip(cmd_eliminar, "Eliminar")
        tltp_notificaciones.SetToolTip(cmd_guardar, "Guardar")
        tltp_notificaciones.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_notificaciones.SetToolTip(cmd_salir, "Salir")
    End Sub
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_id_empleado.Enabled = True
        Me.grp_datos_generales.Enabled = True
        Me.grp_datos_notificacion.Enabled = True
        Me.grp_datos_empleados.Enabled = True
        Me.limpiar(Me.Controls)
        Me.cmd_eliminar.Enabled = False
        Me.condicion_estado = estado.insertar
        Me.txt_id_empleado.Focus()
        cargar_grilla()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        'sql &= "SELECT NE.fecha as fecha, NE.id_efector, E.nombre, NE.id_estado_carga, C.descripcion"
        'sql &= ", NE.id_estado_stock "
        'sql &= "FROM NOTIFICACIONXEFECTOR NE JOIN "
        'sql &= "ORDER BY NE.fecha"
        'tabla = acceso.consulta(sql)

        Me.dgv_notificaciones.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
          
        Next
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
    Private Sub Registrar_notificaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub Registrar_notificaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub guardar()

    End Sub

    Private Sub nuevo()

    End Sub
   
End Class