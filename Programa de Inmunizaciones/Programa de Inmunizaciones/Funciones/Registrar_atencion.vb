Public Class Registrar_atencion

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

    Private Sub Registrar_atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)
        cargar_grilla()
        acceso.autocompletar(txt_efector, "EFECTORES", "nombre")
        cmb_estado_atencion.cargar()
        Me.cmb_estado_atencion.SelectedIndex = -1
        cargar_combo()
        Me.cmb_empleados.SelectedIndex = -1
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Private Sub cargar_combo()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT E.id as id, E.nombres as nombre, EMP.id_cargo "
        sql &= " FROM EMPLEADOS E JOIN EMPLEADOSXEFECTOR EMP ON E.id = EMP.id_empleados "
        sql &= " WHERE EMP.id_cargo = 1 "

        tabla = acceso.consulta(sql)

        Me.cmb_empleados.DataSource = tabla
        Me.cmb_empleados.DisplayMember = "nombre"
        Me.cmb_empleados.ValueMember = "id"
    End Sub
    Private Sub cargar_grilla()

    End Sub
    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub Registrar_atencion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        'Dim tabla As New DataTable
        'Dim sql As String = ""

        'sql &= "SELECT  A.id as id, A.fecha as fecha, A.id_efector as cuie, A.id_administra"
        'sql &= " FROM ATENCION_SOPORTE "

        'tabla = acceso.consulta(sql)

        'Dim C As Integer = 0

        'dgv_atenciones.Rows.Clear()

        'For C = 0 To tabla.Rows.Count - 1
        '    dgv_atenciones.Rows.Add()

        '    dgv_atenciones.Rows(C).Cells("cuie").Value = tabla.Rows(C)("CUIE")
        '    dgv_vacunatorios.Rows(C).Cells("nombre").Value = tabla.Rows(C)("nombre")
        '    dgv_vacunatorios.Rows(C).Cells("referente").Value = tabla.Rows(C)("nombre_referente")
        '    dgv_vacunatorios.Rows(C).Cells("localidad").Value = tabla.Rows(C)("nombre_loc")
        'Next
    End Sub

    ''me quede en el doble click
End Class