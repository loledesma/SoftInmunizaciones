Public Class abm_stock
    Enum estado
        insertar
        modificar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Dim condicion_estado As estado = estado.insertar
    Private Sub abm_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiar(Me.Controls)
        Me.txt_id_stock.Enabled = True
        Me.cargar_grilla()
        Me.cmd_eliminar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.txt_id_stock.Focus()
        tip()
        acceso.autocompletar(txt_descripcion, "STOCK", "descripcion")
    End Sub

    Private Sub tip()
        tltp_stock.SetToolTip(cmd_buscar, "Buscar por Id")
        tltp_stock.SetToolTip(cmd_eliminar, "Eliminar")
        tltp_stock.SetToolTip(cmd_guardar, "Guardar")
        tltp_stock.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_stock.SetToolTip(cmd_salir, "Salir")
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

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM CARGA WHERE id = " & Me.txt_id_stock.Text

        tabla = acceso.consulta(sql)

        If Not (tabla.Rows.Count() = 0) Then
            Me.dgv_stock.Rows.Clear()
            Me.dgv_stock.Rows.Add()
            Me.dgv_stock.Rows(0).Cells("id_stock").Value = tabla.Rows(0)("id")
            Me.dgv_stock.Rows(0).Cells("descripcion").Value = tabla.Rows(0)("descripcion")
        Else
            MessageBox.Show("No existe ese estado de stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_id_stock.Focus()
            Exit Sub
        End If
        Me.cmd_eliminar.Enabled = True
        Me.condicion_estado = estado.modificar
        limpiar(Controls)
    End Sub

    Private Sub abm_stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM STOCK"
        tabla = acceso.consulta(sql)

        Me.dgv_stock.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.dgv_stock.Rows.Add()
            Me.dgv_stock.Rows(c).Cells("id_stock").Value = tabla.Rows(c)("id")
            Me.dgv_stock.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    Private Sub grid_stock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock.CellDoubleClick

        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = " SELECT * FROM STOCK "
        sql &= " WHERE id = " & Me.dgv_stock.CurrentRow.Cells(0).Value

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("NO EXISTE SELECCION")
            Exit Sub
        End If

        Me.txt_id_stock.Text = tabla.Rows(0)("id")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")

        Me.condicion_estado = estado.modificar

        Me.cmd_eliminar.Enabled = True
        Me.txt_id_stock.Enabled = False

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs)
        Me.dgv_stock.Enabled = True
        Me.txt_descripcion.Enabled = True
        Me.txt_id_stock.Enabled = True
        Me.cmd_eliminar.Enabled = False
        Me.condicion_estado = estado.insertar
        Me.limpiar(Me.Controls)
        Me.txt_id_stock.Focus()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs)
        Me.nuevo()
    End Sub

    Private Sub nuevo()
        Me.condicion_estado = estado.insertar
        Me.limpiar(Me.Controls)
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM STOCK"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Me.txt_id_stock.Text = 1
        Else
            Dim ultimo As Integer = tabla.Rows.Count() - 1
            Me.txt_id_stock.Text = tabla.Rows(ultimo)("id") + 1
        End If

        Me.txt_id_stock.Enabled = False
        Me.txt_descripcion.Focus()
        Me.cmd_guardar.Enabled = True
        Me.cmd_eliminar.Enabled = False
    End Sub
    Private Function validar()
        If Me.txt_id_stock.Text = "" Then
            MessageBox.Show("El id está vacío", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_id_stock.Focus()
            Return False
        ElseIf IsNumeric(Me.txt_id_stock.Text) = False Then
            MessageBox.Show("No se admiten caracteres en el ID", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_id_stock.Focus()
            Return False
        ElseIf Me.txt_descripcion.Text = "" Then
            MessageBox.Show("La Descripcion está vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txt_descripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validar_existencia() As analizar_existencia
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM STOCK "
        sql &= "WHERE id = " & Me.txt_id_stock.Text

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs)
        Me.guardar()
    End Sub

    Private Sub guardar()
        If Me.validar() = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este estado de stock en la base de datos")
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
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_limpiar.Enabled = True
    End Sub

    Private Sub insertar()
        Dim sql As String = ""

        sql = "INSERT INTO STOCK"
        sql &= " VALUES (" & Me.txt_id_stock.Text
        sql &= ", '" & Me.txt_descripcion.Text & "')"

        acceso.ejecutar(sql)
    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE STOCK "
        sql &= " SET descripcion = '" & Me.txt_descripcion.Text & "'"
        sql &= " WHERE id = " & Me.txt_id_stock.Text

        acceso.ejecutar(sql)
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs)
        Dim sql As String = ""
        If MessageBox.Show("¿Esta seguro que desea borrar el registro?", _
             "Atencion", MessageBoxButtons.OKCancel, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            If IsNumeric(Me.txt_id_stock.Text) Then
                sql = "DELETE FROM STOCK "
                sql &= "WHERE id = " & Me.txt_id_stock.Text

                acceso.ejecutar(sql)
            Else
                MessageBox.Show("El elemento no existe o ingrese un valor numérico")
                Me.txt_id_stock.Focus()
                Exit Sub
            End If
        End If
        Me.txt_id_stock.Enabled = True
        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        Me.condicion_estado = estado.insertar
    End Sub

    Private Sub abm_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub


End Class