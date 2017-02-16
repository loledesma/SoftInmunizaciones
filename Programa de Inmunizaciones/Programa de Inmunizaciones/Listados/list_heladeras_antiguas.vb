Public Class list_heladeras_antiguas

    Private Sub list_heladeras_antiguas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_departamentos.cargar()
        cmb_localidades.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.SelectedIndex = -1

        Me.ReportViewer1.RefreshReport()
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


    Private Sub list_heladeras_antiguas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged

        If cmb_departamentos.SelectedIndex <> -1 Then
            cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
            cmb_localidades.Enabled = True
            cmb_localidades.SelectedIndex = -1
        End If

    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        Dim tabla As New DataTable


        sql &= "SELECT D.descripcion AS nombre_dpto, L.descripcion AS nombre_localidad, E.cuie, E.nombre AS nombre_efector, E.antiguedad AS estado_heladera "
        sql &= " FROM EFECTORES E JOIN DEPARTAMENTOS D ON E.id_departamento = D.id JOIN LOCALIDADES L ON E.id_localidad = L.id "
        If cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE D.id = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND L.id = " & Me.cmb_localidades.SelectedValue
                If txt_antiguedad.Text <> "" Then
                    sql &= " AND E.antiguedad = '" & Me.txt_antiguedad.Text & "' "
                End If
            ElseIf cmb_departamentos.SelectedIndex <> -1 Then
                If txt_antiguedad.Text <> "" And txt_antiguedad.Text = "VIEJA" Or txt_antiguedad.Text = "DESCONOCIDO" Or txt_antiguedad.Text = "NUEVA" Then
                    sql &= " AND E.antiguedad = '" & Me.txt_antiguedad.Text & "'"
                End If
            End If
        ElseIf cmb_localidades.SelectedIndex <> -1 Then
            sql &= " WHERE L.id = " & Me.cmb_localidades.SelectedValue
            If txt_antiguedad.Text <> "" And txt_antiguedad.Text = "VIEJA" Or txt_antiguedad.Text = "DESCONOCIDO" Or txt_antiguedad.Text = "NUEVA" Then
                sql &= " AND E.antiguedad = '" & Me.txt_antiguedad.Text & "'"
            End If
        ElseIf txt_antiguedad.Text <> "" And txt_antiguedad.Text = "VIEJA" Or txt_antiguedad.Text = "DESCONOCIDO" Or txt_antiguedad.Text = "NUEVA" Then
            sql &= "WHERE E.antiguedad = '" & Me.txt_antiguedad.Text & "'"
        End If


        tabla = acceso.consulta(sql)
        LIST_HELADERAS_ANTIGUASBindingSource.DataSource = tabla
        ReportViewer1.RefreshReport()
    End Sub


    Private Sub cmd_ejecutar_Click(sender As Object, e As EventArgs) Handles cmd_ejecutar.Click

        If txt_antiguedad.Text <> "DESCONOCIDO" And txt_antiguedad.Text <> "VIEJA" And txt_antiguedad.Text <> "NUEVA" And txt_antiguedad.Text <> "" Then
            MessageBox.Show("Debe poner una antiguedad válida! (NUEVA, VIEJA O DESCONOCIDO)", "Atención", MessageBoxButtons.OK)
            txt_antiguedad.Focus()
            Exit Sub
        End If
        imprimir()
    End Sub
End Class