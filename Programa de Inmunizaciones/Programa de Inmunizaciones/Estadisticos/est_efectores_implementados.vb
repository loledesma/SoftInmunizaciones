﻿Public Class est_efectores_implementados

    Private Sub est_efectores_implementados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_departamentos.cargar()
        cmb_departamentos.SelectedIndex = -1
        cmb_localidades.cargar()
        cmb_localidades.SelectedIndex = -1

    End Sub

    Private Sub cmb_departamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_departamentos.SelectedValueChanged

        If cmb_departamentos.SelectedIndex <> -1 Then
            cmb_localidades.cargar("id_departamento", Me.cmb_departamentos.SelectedValue)
            cmb_localidades.Enabled = True
            cmb_localidades.SelectedIndex = -1
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

    Private Sub est_efectores_implementados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.limpiar(Me.Controls)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT EE.descripcion AS estado, COUNT (*) AS cantidad "
        sql &= " FROM ESTADOS_EFECTOR EE JOIN EFECTORES E ON EE.id = E.id_estado "

        If cmb_departamentos.SelectedIndex <> -1 Then
            sql &= " WHERE E.id_departamento = " & Me.cmb_departamentos.SelectedValue
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= " AND E.id_localidad = " & Me.cmb_localidades.SelectedValue
            End If
        Else
            If cmb_localidades.SelectedIndex <> -1 Then
                sql &= "WHERE E.id_localidad = " & Me.cmb_localidades.SelectedValue
            End If
        End If

        sql &= "GROUP BY EE.descripcion"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para la búsqueda!")
            Exit Sub
        End If

        Me.EST_EFECTORES_IMPLEMENTADOSBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        imprimir()
    End Sub
End Class