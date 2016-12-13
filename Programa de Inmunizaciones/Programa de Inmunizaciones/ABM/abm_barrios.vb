﻿Public Class abm_barrios
    Enum estado
        insertar
        modificar
    End Enum

    Enum analizar
        existe
        noExiste
    End Enum
    Dim condicion As estado = estado.insertar
    Private Sub abm_barrios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_localidades.cargar()
        cargar_grilla()
        cmb_dptos.cargar()
    End Sub
    Private Sub limpiar(ByVal de_donde As Object)
        Me.condicion = estado.insertar
        Dim cmb As ComboBoxV1

        For Each obj As System.Windows.Forms.Control In de_donde
            Select Case obj.GetType.ToString
                Case "System.Windows.Forms.TextBox"
                    obj.Text = ""
                Case "System.Windows.Forms.MaskedTextBox"
                    obj.Text = ""
                Case "WindowsApplication1.ComboBoxV1"
                    cmb = obj
                    cmb.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj
        cmd_nuevo.Enabled = True
    End Sub

    Private Sub cargar_grilla()

        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT B.id, B.descripcion, B.id_localidad,L.descripcion AS descrip "
        sql &= "FROM BARRIOS B JOIN LOCALIDADES L ON B.id_localidad = L.id "

        tabla = acceso.consulta(sql)

        dgv_barrios.Rows.Clear()
        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            dgv_barrios.Rows.Add()
            dgv_barrios.Rows(c).Cells("id_barrio").Value = tabla.Rows(c)("id")
            dgv_barrios.Rows(c).Cells("barrio").Value = tabla.Rows(c)("descripcion")
            dgv_barrios.Rows(c).Cells("id_localidad").Value = tabla.Rows(c)("id_localidad")
            dgv_barrios.Rows(c).Cells("localidad").Value = tabla.Rows(c)("descrip")
        Next
    End Sub
    Private Sub cmb_dptos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_dptos.SelectedValueChanged
        If Me.cmb_dptos.SelectedIndex <> -1 Then
            Me.cmb_localidades.cargar("id_departamento", Me.cmb_dptos.SelectedValue)
            Me.cmb_localidades.SelectedIndex = -1
            Me.cmb_localidades.Enabled = True
        End If
    End Sub

    Private Sub insertar()
        Dim sql As String = ""

        sql &= "INSERT INTO BARRIOS VALUES ( " & Me.txt_id_barrio.Text & ", '" & Me.txt_descripcion.Text & "' , " & Me.cmb_localidades.SelectedValue & ")"
        acceso.ejecutar(sql)
        Me.cargar_grilla()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE BARRIOS SET "
        sql &= "descripcion = '" & Me.txt_descripcion.Text & "' , id_localidad = " & Me.cmb_localidades.SelectedValue
        sql &= " WHERE id = " & Me.txt_id_barrio.Text

        acceso.ejecutar(sql)

    End Sub
    Private Sub abm_barrios(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    Private Function validar_campos() As Boolean
        If Me.txt_descripcion.Text = "" Then
            MessageBox.Show("El campo descripción no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_descripcion.Focus()
            Exit Function

        End If
        If Me.txt_id_barrio.Text = "" Then
            MessageBox.Show("El campo ID no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_barrio.Focus()
            Exit Function
        End If
        If Me.cmb_localidades.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una localidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_localidades.Focus()
            Exit Function
        End If

        Return True

    End Function
    Private Function validar_existencia() As analizar
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM BARRIOS WHERE id = " & Me.txt_id_barrio.Text

        tabla = acceso.consulta(sql)
        If tabla.Rows.Count = 0 Then
            Return analizar.noExiste
        Else
            Return analizar.existe
        End If
    End Function


    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If validar_campos() = True Then
            If condicion = estado.insertar Then
                If Me.validar_existencia() = analizar.noExiste Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe ese tipo de documento!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
        Else
            Exit Sub
        End If
        Me.limpiar(Me.Controls)
        Me.cargar_grilla()
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        limpiar(Controls)
        txt_id_barrio.Text = ""
        txt_id_barrio.Enabled = True
        txt_id_barrio.Focus()
        cargar_grilla()
        cmd_nuevo.Enabled = True
        cmd_guardar.Enabled = False
        cmd_eliminar.Enabled = False
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Dim sql As String = "select * from barrios"
        Dim tabla As New DataTable

        tabla = acceso.consulta(sql)

        Me.txt_id_barrio.Text = tabla.Rows.Count + 1
        txt_id_barrio.Enabled = False
        txt_descripcion.Focus()
        cmd_guardar.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_limpiar.Enabled = True
        cmd_nuevo.Enabled = False
        condicion = estado.insertar
    End Sub

   

    Private Sub dgv_barrios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_barrios.CellMouseDoubleClick
        condicion = estado.modificar


    End Sub
End Class