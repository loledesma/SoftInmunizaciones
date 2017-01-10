Public Class Registrar_atencion

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

    Private Sub Registrar_atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)
        cargar_grilla()
        acceso.autocompletar(txt_efector, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
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
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim tabla2 As New DataTable

        sql &= "SELECT A.id as id, A.fecha as fecha, A.id_estados_atencion as id_estado, A.id_efector as cuie, A.descripcion as descripcion "
        sql &= " , A.id_administrador as id_administrador "
        sql &= " FROM ATENCION_SOPORTE A "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0

        dgv_atenciones.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            dgv_atenciones.Rows.Add()
            dgv_atenciones.Rows(c).Cells("id").Value = tabla.Rows(c)("id")
            dgv_atenciones.Rows(c).Cells("fecha").Value = tabla.Rows(c)("fecha")
            dgv_atenciones.Rows(c).Cells("cuie").Value = tabla.Rows(c)("cuie")

            sql &= "SELECT E.nombre as nombre FROM EFECTORES E WHERE cuie='" & tabla.Rows(c)("cuie") & "'"
            tabla2 = acceso.consulta(sql)

            dgv_atenciones.Rows(c).Cells("efector").Value = tabla2.Rows(0)("nombre")


            sql = ""
            sql &= "SELECT descripcion as estado FROM ESTADOS_ATENCION WHERE id= " & tabla.Rows(c)("id_estado")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_atenciones.Rows(c).Cells("id_estado").Value = tabla.Rows(c)("id_estado")
            dgv_atenciones.Rows(c).Cells("estado").Value = tabla2.Rows(0)("estado")
            dgv_atenciones.Rows(c).Cells("cuie").Value = tabla.Rows(c)("cuie")
            dgv_atenciones.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            dgv_atenciones.Rows(c).Cells("id_administrador").Value = tabla.Rows(c)("id_administrador")

            sql = ""
            sql &= "SELECT nombres FROM EMPLEADOS WHERE id=" & tabla.Rows(c)("id_administrador")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_atenciones.Rows(c).Cells("administrador").Value = tabla2.Rows(0)("nombres")
        Next

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


End Class