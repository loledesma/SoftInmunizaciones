Public Class abm_empleados

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

    Private Sub abm_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Me.Controls)
        Me.cargar_grilla()
        Me.cmd_eliminar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.txt_id_empleado.Focus()
        Me.cmb_tipo_doc.cargar()
        Me.cmb_departamentos.cargar()
        Me.cmb_localidades.cargar()
        Me.cmb_efectores.cargar()
        Me.cmb_perfil.cargar()
        Me.cmb_cargo.cargar()
        Me.cmb_tipo_doc.SelectedIndex = -1
        Me.cmb_departamentos.SelectedIndex = -1
        Me.cmb_localidades.SelectedIndex = -1
        Me.cmb_efectores.SelectedIndex = -1
        Me.cmb_perfil.SelectedIndex = -1
        Me.cmb_cargo.SelectedIndex = -1

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
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

    Private Sub abm_empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.grp_datos_laborales.Enabled = True
        Me.grp_datos_personales.Enabled = True
        Me.grp_datos_sigipsa.Enabled = True
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

        sql &= "SELECT T.descripcion, E.nombres As nombre, E.apellidos As apellido, E.nro_doc "
        sql &= "FROM EMPLEADOS E JOIN TIPOS_DOCUMENTO T ON E.id_tipo_doc = T.id "
        sql &= "ORDER BY E.id"
        tabla = acceso.consulta(sql)

        Me.dgv_empleados.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_empleados.Rows.Add()
            Me.dgv_empleados.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.dgv_empleados.Rows(c).Cells("apellido").Value = tabla.Rows(c)("apellido")
            Me.dgv_empleados.Rows(c).Cells("tipo_doc").Value = tabla.Rows(c)("descripcion")
            Me.dgv_empleados.Rows(c).Cells("nro_doc").Value = tabla.Rows(c)("nro_doc")
        Next
    End Sub

    Private Sub grid_empleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
        Me.condicion_click = doble_Click.activado
        Dim fecha As Date
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim sql2 As String = ""

        sql &= " SELECT * FROM EMPLEADOS "
        sql &= " WHERE id = " & Me.dgv_empleados.CurrentRow.Cells(0).Value

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("NO EXISTE SELECCION")
            Exit Sub
        End If

        Me.txt_id_empleado.Text = tabla.Rows(0)("id")
        Me.cmb_tipo_doc.SelectedValue = tabla.Rows(0)("id_tipo_doc")
        Me.txt_nro_documento.Text = tabla.Rows(0)("nro_doc")
        Me.txt_nombre.Text = tabla.Rows(0)("nombres")
        Me.txt_apellido.Text = tabla.Rows(0)("apellidos")
        Me.txt_caracteristica.Text = tabla.Rows(0)("caracteristica")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")
        Me.txt_email.Text = tabla.Rows(0)("mail_contacto")
        Me.txt_usuario.Text = tabla.Rows(0)("usuario_sigipsa")

        If IsDBNull(tabla.Rows(0)("fecha_alta")) Then
            Me.txt_fecha.Text = ""
        Else
            fecha = tabla.Rows(0)("fecha_alta")
            Me.txt_fecha.Text = fecha.ToString("dd/MM/yyyy")
        End If

        Me.grp_datos_laborales.Enabled = True
        Me.grp_datos_personales.Enabled = True
        Me.txt_id_empleado.Enabled = False
        Me.grp_datos_sigipsa.Enabled = True

        sql2 &= "SELECT E.cuie, E.id_departamento, E.id_localidad, E.id_cargo, E.id_perfil "
        sql2 &= "FROM EMPLEADOS EMP JOIN EMPLEADOSXEFECTOR EE ON EMP.id = EE.id_empleados "
        sql2 &= " JOIN EFECTORES E ON EE.id_efector = E.cuie"
        sql2 &= " WHERE EMP.id = " & Me.dgv_empleados.CurrentRow.Cells(0).Value


        Me.condicion_estado = estado.modificar
        Me.cmd_eliminar.Enabled = True
        Me.condicion_click = doble_Click.desactivado
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

    Private Sub cmb_localidades_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_localidades.SelectedValueChanged
        If Me.condicion_click = doble_Click.desactivado Then
            If cmb_localidades.SelectedIndex <> -1 Then
                cmb_efectores.ResetText()
                cmb_efectores.cargar("id_localidad", Me.cmb_localidades.SelectedValue)
                cmb_efectores.SelectedIndex = -1
                cmb_efectores.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmd_agregar_efector_Click(sender As Object, e As EventArgs) Handles cmd_agregar_efector.Click
        If MessageBox.Show("¿Desea agregar un efector nuevo?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Registrar_efectores.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmd_buscar_x_documento_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_documento.Click

    End Sub

    Private Sub cmd_buscar_x_apellido_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_apellido.Click

    End Sub

    Private Sub cmd_buscar_x_usuario_Click(sender As Object, e As EventArgs) Handles cmd_buscar_x_usuario.Click

    End Sub
End Class