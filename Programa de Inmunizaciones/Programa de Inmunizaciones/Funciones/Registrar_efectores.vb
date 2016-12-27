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
        sql &= "EFECTORES EF JOIN EFECTORES E ON EF.cuie = E.id_referente JOIN LOCALIDADES L on L.id = EF.id_localidad "

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

        Dim fecha As Date
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        sql &= " SELECT * FROM EFECTORES "
        sql &= " WHERE cuie = " & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value

        sql2 &= "E.*, EE.id_empleados, EE.id_efector, EM.id FROM "
        sql2 &= "EFECTORES E JOIN EMPLEADOSXEFECTOR EE ON E.cuie = EE.id_efector JOIN EMPLEADOS EM ON EM.id = EE.id_empleados "
        sql2 &= "WHERE E.cuie = " & Me.dgv_vacunatorios.CurrentRow.Cells("cuie").Value

        tabla = acceso.consulta(sql)
        tabla2 = acceso.consulta(sql2)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No existe selección!")
            Exit Sub
        End If


    End Sub
End Class