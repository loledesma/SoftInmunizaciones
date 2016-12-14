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
                Case "WindowsApplication1.ComboBoxV1"
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
        Me.dgv_empleados.Enabled = True
        Me.txt_id_empleado.Enabled = True
        Me.grp_datos_laborales.Enabled = True
        Me.grp_datos_personales.Enabled = True
        Me.grp_datos_sigipsa.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.condicion_estado = estado.insertar
        Me.limpiar(Me.Controls)
        Me.txt_id_empleado.Focus()
        cargar_grilla()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT EF.nombre As efector, E.nombres As nombre, E.apellidos As apellido "
        sql &= "FROM EMPLEADOS E JOIN EMPLEADOSXEFECTOR EE ON E.id = EE.id_empleados "
        sql &= "JOIN EFECTORES EF ON EE.id_efector = EF.cuie "
        sql &= "ORDER BY efector"
        tabla = acceso.consulta(sql)

        Me.dgv_empleados.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_empleados.Rows.Add()
            Me.dgv_empleados.Rows(c).Cells("efector").Value = tabla.Rows(c)("efector")
            Me.dgv_empleados.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.dgv_empleados.Rows(c).Cells("apellido").Value = tabla.Rows(c)("apellido")
        Next
    End Sub

    ' Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs)
    ' If Me.cmb_departamentos.SelectedIndex <> -1 Then
    ' Me.cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
    'Me.cmb_localidades.Enabled = True
    'Else
    'Me.cmb_localidades.SelectedIndex = -1
    ' End If
    ' End Sub

    'Private Sub cmb_localidades_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_localidades.SelectedValueChanged
    'If Me.cmb_localidades.SelectedIndex <> -1 Then
    '   Me.cmb_efectores.cargar("id_localidad", Me.cmb_localidades.SelectedValue)
    '  Me.cmb_efectores.Enabled = True
    '   Me.cmb_efectores.SelectedIndex = -1
    '  Else
    '   Me.cmb_efectores.SelectedIndex = -1
    '  End If
    ' End Sub


  
End Class