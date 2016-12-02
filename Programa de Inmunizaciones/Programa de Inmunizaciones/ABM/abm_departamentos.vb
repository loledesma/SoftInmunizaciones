Public Class abm_departamentos
    Enum estado
        insertar
        modificar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum
    Dim condicion_estado As estado = estado.insertar
    Private Sub abm_departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiar(Me.Controls)
        Me.txt_id_departamento.Enabled = True
        Me.cargar_grilla()
        Me.cmd_eliminar.Enabled = False
        Me.txt_id_departamento.Focus()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

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

    Private Sub abm_departamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM DEPARTAMENTOS"
        tabla = acceso.consulta(sql)

        Me.dgv_departamentos.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_departamentos.Rows.Add()
            Me.dgv_departamentos.Rows(c).Cells("id_departamentos").Value = tabla.Rows(c)("id")
            Me.dgv_departamentos.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub



End Class