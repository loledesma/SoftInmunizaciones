Public Class Registrar_ingreso_stock
    Enum condicion
        modificar
        insertar
    End Enum

    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Enum doble_Click
        activado
        desactivado
    End Enum

    Dim condicion_inicial As condicion = condicion.insertar
    Dim condicion_click As doble_Click = doble_Click.desactivado


    Private Sub Registrar_ingreso_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        acceso.autocompletar(txt_nro_serie, "STOCK_INSUMOS", "nro_serie")
        acceso.autocompletar(txt_modelo, "STOCK_INSUMOS", "modelo")
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        Me.cmd_limpiar.Enabled = True
        Me.grp_stock.Enabled = False
        Me.cmb_marca.cargar()
        Me.cmb_insumos.cargar()
        Me.cmb_insumos.SelectedIndex = -1
        Me.cmb_marca.SelectedIndex = -1

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

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
        cmd_nuevo.Enabled = True
        condicion_inicial = condicion.insertar
    End Sub
 
    Private Sub Registrar_ingreso_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        limpiar(Me.Controls)
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.nuevo()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        guardar()
    End Sub

    Private Sub nuevo()
        Me.limpiar(Me.Controls)
        Me.grp_stock.Enabled = True
        Me.cmb_insumos.Enabled = True
        Me.txt_nro_serie.Enabled = True
        Me.txt_modelo.Enabled = True
        Me.cmb_marca.Enabled = True
        Me.cmb_insumos.SelectedValue = -1
        Me.cmb_marca.SelectedValue = -1
        Me.cmd_guardar.Enabled = True
        Me.condicion_inicial = condicion.insertar
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim tabla2 As New DataTable

        sql &= "SELECT * FROM STOCK_INSUMOS ORDER BY id_insumo "
        tabla = acceso.consulta(sql)

        Dim c As Integer = 0

        dgv_stock.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            dgv_stock.Rows.Add()
            dgv_stock.Rows(c).Cells("id_insumo").Value = tabla.Rows(c)("id_insumo")
            dgv_stock.Rows(c).Cells("nro_serie").Value = tabla.Rows(c)("nro_serie")
            dgv_stock.Rows(c).Cells("modelo").Value = tabla.Rows(c)("modelo")
            dgv_stock.Rows(c).Cells("id_marca").Value = tabla.Rows(c)("id_marca")
            dgv_stock.Rows(c).Cells("cantidad").Value = tabla.Rows(c)("cantidad")

            sql = ""
            sql &= "SELECT descripcion FROM MARCA WHERE id = " & tabla.Rows(c)("id_marca")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_stock.Rows(c).Cells("marca").Value = tabla2.Rows(0)("descripcion")

            sql = ""
            sql &= "SELECT descripcion FROM INSUMOS WHERE id= " & tabla.Rows(c)("id_insumo")
            tabla2.Rows.Clear()
            tabla2 = acceso.consulta(sql)

            dgv_stock.Rows(c).Cells("insumo").Value = tabla2.Rows(0)("descripcion")
        Next
    End Sub

    Private Sub dgv_stock_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_stock.CellMouseDoubleClick
        Dim tabla As DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM STOCK_INSUMOS WHERE id_insumo=" & Me.dgv_stock.CurrentRow.Cells("id_insumo").Value
        sql &= " AND nro_serie='" & Me.dgv_stock.CurrentRow.Cells("nro_serie").Value & "'"
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("¡No está cargado ese insumo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Me.cmb_insumos.SelectedValue = tabla.Rows(0)("id_insumo")
            Me.txt_cantidad.Text = tabla.Rows(0)("cantidad")
            Me.txt_nro_serie.Text = tabla.Rows(0)("nro_serie")
            Me.cmb_marca.SelectedValue = tabla.Rows(0)("id_marca")
            Me.txt_modelo.Text = tabla.Rows(0)("modelo")
        End If

        Me.grp_stock.Enabled = True
        Me.cmb_insumos.Enabled = False
        Me.txt_nro_serie.Enabled = False
        Me.txt_modelo.Enabled = False
        Me.cmb_marca.Enabled = False
        Me.txt_cantidad.Enabled = True
        Me.condicion_inicial = condicion.modificar
        Me.cmd_limpiar.Enabled = True
        Me.cmd_guardar.Enabled = True
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.grp_stock.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmb_insumos.Enabled = True
        Me.txt_nro_serie.Enabled = True
        Me.txt_modelo.Enabled = True
        Me.cmb_marca.Enabled = True
        Me.txt_cantidad.Text = ""
        Me.txt_modelo.Text = ""
        Me.txt_nro_serie.Text = ""
        Me.cmb_insumos.SelectedValue = -1
        Me.cmb_marca.SelectedValue = -1
        Me.condicion_inicial = condicion.insertar
    End Sub

    Private Sub guardar()
        If condicion_inicial = condicion.insertar Then
            If validar_datos() Then
                If validar_stock() = analizar_existencia.existe Then
                    If MessageBox.Show("El insumo ya se encuentra cargado, ¿Desea sumar al stock?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                        sumar()
                    Else
                        Exit Sub
                    End If
                Else
                    insertar()
                End If
            End If
        Else
            If MessageBox.Show("El insumo ya se encuentra cargado, ¿Desea modificar el insumo en stock?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                modificar()
            Else
                Exit Sub
            End If
        End If
        limpiar(Me.Controls)
        Me.cmd_limpiar.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False
        cargar_grilla()
    End Sub



    Private Function validar_datos() As Boolean
        If cmb_insumos.SelectedValue = -1 Then
            MessageBox.Show("¡Debe ingresar un insumo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_insumos.Focus()
            Return False
            Exit Function
        ElseIf txt_nro_serie.Text = "" Then
            MessageBox.Show("¡Debe ingresar un numero de serie!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_nro_serie.Focus()
            Return False
            Exit Function
        ElseIf cmb_marca.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar una marca!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_marca.Focus()
            Return False
            Exit Function
        ElseIf txt_cantidad.Text = "" Then
            MessageBox.Show("¡Debe ingresar una cantidad!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cantidad.Focus()
            Return False
            Exit Function
        ElseIf txt_modelo.Text = "" Then
            MessageBox.Show("¡Debe ingresar un modelo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_modelo.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function validar_stock() As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = ""
        sql &= " SELECT * FROM STOCK_INSUMOS WHERE id_insumo=" & Me.cmb_insumos.SelectedValue
        sql &= " AND nro_serie ='" & Me.txt_nro_serie.Text & "'"
        sql &= " AND modelo='" & Me.txt_modelo.Text & "'"
        sql &= " AND id_marca=" & Me.cmb_marca.SelectedValue
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
            Exit Function
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub insertar()
        Dim sql As String = ""
        acceso._nombre_tabla = "STOCK_INSUMOS"

        sql &= "id_insumo = " & Me.cmb_insumos.SelectedValue
        sql &= ", nro_serie =" & Me.txt_nro_serie.Text
        sql &= ", cantidad= " & Me.txt_cantidad.Text
        sql &= ", modelo=" & Me.txt_modelo.Text
        sql &= ", id_marca =" & Me.cmb_marca.SelectedValue

        acceso.insertar(sql)

    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql = "UPDATE STOCK_INSUMOS "
        sql &= " SET cantidad = " & Me.txt_cantidad.Text
        sql &= " WHERE id_insumo = " & Me.cmb_insumos.SelectedValue & " AND nro_serie='" & Me.txt_nro_serie.Text & "'"

        acceso.ejecutar(sql)
    End Sub

    Private Sub sumar()
        Dim tabla As New DataTable
        Dim sql As String = ""
        Dim cantidad As Integer = 0

        sql = ""
        sql = "SELECT cantidad FROM STOCK_INSUMOS WHERE id_insumo= " & Me.cmb_insumos.SelectedValue
        sql &= " AND nro_serie='" & Me.txt_nro_serie.Text & "'"
        tabla = acceso.consulta(sql)


        If tabla.Rows.Count() <> 0 Then
            cantidad = tabla.Rows(0)("cantidad") + Convert.ToInt16(Me.txt_cantidad.Text)
            sql = ""
            sql &= " UPDATE STOCK_INSUMOS SET cantidad= " & cantidad
            sql &= " WHERE id_insumo= " & Me.cmb_insumos.SelectedValue
            sql &= " and nro_serie= '" & Me.txt_nro_serie.Text & "'"
            acceso.ejecutar(sql)
        End If

    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        If cmb_insumos.SelectedValue <> -1 Then
            If txt_nro_serie.Text <> "" Then
                If MessageBox.Show("¿Está seguro que desea eliminar el insumo?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    sql = "DELETE FROM STOCK_INSUMOS "
                    sql &= "WHERE id_insumo = " & Me.cmb_insumos.SelectedValue
                    sql &= " AND nro_serie='" & Me.txt_nro_serie.Text & "'"
                    acceso.ejecutar(sql)
                End If
            Else
                MessageBox.Show("El elemento no existe o no ingreso el nro serie")
                Me.txt_nro_serie.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("El elemento no existe o no selecciono un insumo")
            Me.cmb_insumos.Focus()
            Exit Sub
        End If

        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        Me.condicion_inicial = condicion.insertar
    End Sub

    Private Sub dgv_stock_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock.CellValueChanged
        Dim contadorCPU As Integer = 0
        Dim contadorMonitor As Integer = 0
        Dim contadorHeladera As Integer = 0
        Dim c As Integer
        For c = 0 To dgv_stock.Rows.Count() - 1
            If dgv_stock.Rows(c).Cells("id_insumo").Value = 1 Then
                contadorHeladera = contadorHeladera + 1
            ElseIf dgv_stock.Rows(c).Cells("id_insumo").Value = 2 Then
                contadorMonitor = contadorMonitor + 1
            Else
                contadorCPU = contadorCPU + 1
            End If
        Next
        lbl_contador_cpu.Text = contadorCPU
        lbl_contador_heladeras.Text = contadorHeladera
        lbl_contador_monitores.Text = contadorMonitor
    End Sub
End Class