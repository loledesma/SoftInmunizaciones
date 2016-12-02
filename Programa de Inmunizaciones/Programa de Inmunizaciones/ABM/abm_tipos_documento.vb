﻿Public Class abm_tipos_documento

    Enum estado
        insertar
        modificar
    End Enum

    Enum analizar_existencia
        existe
        noExiste
    End Enum

    Dim condicion As estado = estado.insertar

    Private Sub abm_tipos_documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    Private Sub abm_tipos_documento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM TIPOS_DOCUMENTO "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0
        Me.dgv_tipos_doc.Rows.Clear()
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_tipos_doc.Rows.Add()

            Me.dgv_tipos_doc.Rows(c).Cells("id_tipo_doc").Value = tabla.Rows(c)("id")
            Me.dgv_tipos_doc.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    Private Function validar_Existencia() As analizar_existencia

        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = " SELECT * FROM tipos_documento " _
        & " WHERE id= " & Me.txt_id_tipo_doc.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.noExiste
        Else
            Return analizar_existencia.existe

        End If


    End Function

    Private Sub limpiar(ByVal de_donde As Object)
        Me.condicion = estado.insertar
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


    Private Sub insertar()
        Dim sql As String = ""

        sql &= "INSERT INTO TIPOS_DOCUMENTO VALUES (" & Me.txt_id_tipo_doc.Text & ", '" & Me.txt_descripcion.Text & "')"
        acceso.ejecutar(sql)
        Me.cargar_grilla()

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE TIPOS_DOCUMENTO "
        sql &= "SET descripcion = '" & Me.txt_descripcion.Text & "'"
        sql &= " WHERE id = " & Me.txt_id_tipo_doc.Text
        acceso.ejecutar(sql)

        Me.cargar_grilla()

    End Sub



    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        'CONTINUAR DESDE ACÁ
    End Sub
End Class