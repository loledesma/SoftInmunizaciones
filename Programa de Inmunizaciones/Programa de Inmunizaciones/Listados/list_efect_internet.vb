Public Class list_efect_internet

    Private Sub list_efect_internet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_departamentos.cargar()
        cmb_localidades.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1
        acceso.autocompletar(txt_efectores, "EFECTORES", "nombre")
        acceso.autocompletar(txt_cuie, "EFECTORES", "cuie")
        cmb_departamentos.Focus()
        Me.ReportViewer1.Clear()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged
        If cmb_departamentos.SelectedIndex <> -1 Then
            cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
            cmb_localidades.Enabled = True
            cmb_localidades.SelectedIndex = -1
            Me.txt_cuie.Text = ""
            Me.txt_efectores.Text = ""
        End If
    End Sub
    Private Sub txt_efectores_LostFocus(sender As Object, e As EventArgs) Handles txt_efectores.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_efectores.Text <> "" Then
            sql &= "SELECT E.cuie As cuie FROM EFECTORES E "
            sql &= " WHERE E.nombre='" & txt_efectores.Text & "'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count <> 0 Then
                txt_cuie.Text = tabla.Rows(0)("cuie")
            End If
        End If
    End Sub

    Private Sub txt_cuie_LostFocus(sender As Object, e As EventArgs) Handles txt_cuie.LostFocus
        Dim tabla As New DataTable
        Dim sql As String = ""
        If txt_cuie.Text <> "" Then
            sql &= "SELECT E.nombre As nombre FROM EFECTORES E "
            sql &= " WHERE E.cuie='" & txt_cuie.Text & "'"
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count <> 0 Then
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


    Private Sub list_efect_internet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub imprimir()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT D.descripcion as nombre_departamento, L.descripcion as nombre_localidad, EF.nombre as nombre_efector, EF.cuie as cuie, EF.tiene_internet as tiene_conexion"
        sql &= " FROM EFECTORES EF JOIN LOCALIDADES L ON EF.id_localidad = L.id JOIN DEPARTAMENTOS D ON D.id = L.id_departamento"

        If Me.cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id = " & Me.cmb_localidades.SelectedValue
                If txt_efectores.Text <> "" Then
                    sql &= " AND EF.nombre = '" & Me.txt_efectores.Text & "'"
                    If txt_conexion.Text <> "" Then
                        sql &= " AND EF.tiene_internet = '" & Me.txt_conexion.Text & "'"
                    End If
                ElseIf txt_cuie.Text <> "" Then
                    sql &= " AND EF.cuie = " & Me.txt_cuie.Text & "'"
                    If txt_conexion.Text <> "" Then
                        sql &= " AND EF.tiene_internet = '" & Me.txt_conexion.Text & "'"
                    End If
                End If
            ElseIf txt_conexion.Text <> "" Then
                sql &= " AND EF.tiene_internet = '" & Me.txt_conexion.Text & "'"
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE L.id= " & Me.cmb_localidades.SelectedValue
        ElseIf txt_cuie.Text <> "" Then
            sql &= " WHERE EF.cuie ='" & Me.txt_cuie.Text & "'"
        ElseIf txt_conexion.Text <> "" Then
            sql &= " WHERE EF.tiene_internet = '" & Me.txt_conexion.Text & "'"
        End If



        tabla = acceso.consulta(sql)
        LIST_EFECTORES_CON_INTERNETBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click
        imprimir()
    End Sub

    Private Sub list_efect_internet_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.ReportViewer1.Width = Me.Width - 50
        Me.ReportViewer1.Height = Me.Height - 100
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class