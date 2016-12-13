Public Class abm_tipos_documento

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
        Me.cmd_guardar.Enabled = False
        cmd_eliminar.Enabled = False
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

        If validar_campos() = True Then
            If condicion = estado.insertar Then
                If Me.validar_Existencia() = analizar_existencia.noExiste Then
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

    Private Function validar_campos() As Boolean

        If Me.txt_id_tipo_doc.Text = "" Then
            MessageBox.Show("El ID no puede estar vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_tipo_doc.Focus()
            Exit Function
        End If
        If Me.txt_descripcion.Text = "" Then
            MessageBox.Show("La descripción no puede estár vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_descripcion.Focus()
            Exit Function
        End If

        Return True

    End Function

   

    Private Sub dgv_tipos_doc_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_tipos_doc.CellMouseDoubleClick

        Me.condicion = estado.modificar
        Dim tabla As New DataTable
        Dim sql As String = ""
        Me.txt_id_tipo_doc.Enabled = False

        sql &= "SELECT * FROM TIPOS_DOCUMENTO WHERE id = " & Me.dgv_tipos_doc.CurrentRow.Cells("id_tipo_doc").Value

        tabla = acceso.consulta(sql)

        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Me.txt_id_tipo_doc.Text = tabla.Rows(0)("id")

    End Sub


    Private Sub cmb_buscar_Click(sender As Object, e As EventArgs) Handles cmb_buscar.Click
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM TIPOS_DOCUMENTO WHERE id = " & Me.txt_id_tipo_doc.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() - 1 Then
            MessageBox.Show("No existe tipo de documento con el ID ingresado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cargar_grilla()
            Me.cmd_nuevo.Enabled = True
            Me.cmd_guardar.Enabled = True
            Me.txt_id_tipo_doc.Focus()
            Exit Sub
        Else
            dgv_tipos_doc.Rows.Clear()
            dgv_tipos_doc.Rows.Add()
            dgv_tipos_doc.Rows(0).Cells("id_tipo_doc").Value = tabla.Rows(0)("id")
            dgv_tipos_doc.Rows(0).Cells("descripcion").Value = tabla.Rows(0)("descripcion")
        End If

    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.limpiar(Me.Controls)
        cmd_nuevo.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_guardar.Enabled = True
        Me.txt_id_tipo_doc.Enabled = True
        Me.txt_id_tipo_doc.Focus()

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.limpiar(Controls)
        Me.txt_descripcion.Focus()
        cmd_guardar.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_nuevo.Enabled = False
        txt_id_tipo_doc.Enabled = False

        Dim tabla As New DataTable

        Dim sql As String = ""

        sql &= "select * from tipos_documento "

        tabla = acceso.consulta(sql)

        txt_id_tipo_doc.Text = tabla.Rows().Count() + 1
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = "DELETE FROM TIPOS_DOCUMENTO WHERE id = " & txt_id_tipo_doc.Text
        acceso.ejecutar(sql)
        Me.cargar_grilla()
        Me.limpiar(Controls)
        cmd_nuevo.Enabled = True
        cmd_cancelar.Enabled = True
        cmd_guardar.Enabled = False
    End Sub


End Class