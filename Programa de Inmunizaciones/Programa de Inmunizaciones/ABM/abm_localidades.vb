Public Class abm_localidades

    Private Sub abm_localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_dptos.cargar()
        cargar_grilla()
        limpiar(Controls)
        txt_id_localidad.Enabled = True
        cmb_dptos.SelectedIndex = -1
        cmd_guardar.Enabled = False
        cmd_eliminar.Enabled = False
        tip()
        acceso.autocompletar(txt_descripcion, "LOCALIDADES", "descripcion")

    End Sub

    Enum estado
        insertar
        modificar
    End Enum
    Enum analizar_existencia
        existe
        no_existe
    End Enum

    Dim condicion As estado = estado.insertar
    Private Sub abm_localidades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cargar_grilla() '   VER CON LORE PARA QUE APAREZCA NOMBRE DEL DPTO EN LA GRILLA!
        Dim sql As String = ""
        Dim tabla As New DataTable
        sql &= "SELECT L.id, L.descripcion, L.cod_postal, L.id_departamento, D.descripcion AS descrip"
        sql &= " FROM LOCALIDADES L JOIN DEPARTAMENTOS D ON L.id_departamento = D.id "

        tabla = acceso.consulta(sql)

        dgv_localidades.Rows.Clear()
        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_localidades.Rows.Add()
            Me.dgv_localidades.Rows(c).Cells("id_localidad").Value = tabla.Rows(c)("id")
            Me.dgv_localidades.Rows(c).Cells("cod_postal").Value = tabla.Rows(c)("cod_postal")
            Me.dgv_localidades.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.dgv_localidades.Rows(c).Cells("dpto").Value = tabla.Rows(c)("descrip")
            Me.dgv_localidades.Rows(c).Cells("id_dpto").Value = tabla.Rows(c)("id_departamento")

        Next
    End Sub

    Private Sub insertar()
        Dim sql As String = ""

        sql &= "INSERT INTO LOCALIDADES VALUES ( " & Me.txt_id_localidad.Text & ",'" & Me.txt_descripcion.Text & "' , " & Me.txt_cod_postal.Text & ", " & Me.cmb_dptos.SelectedValue & ")"
        acceso.ejecutar(sql)

    End Sub

    Private Sub modificar()
        Dim sql As String = ""

        sql &= "UPDATE LOCALIDADES "
        sql &= "SET descripcion = '" & Me.txt_descripcion.Text
        sql &= "', cod_postal = " & Me.txt_cod_postal.Text
        sql &= ", id_departamento = " & Me.cmb_dptos.SelectedValue
        sql &= " WHERE id = " & Me.txt_id_localidad.Text

        acceso.ejecutar(sql)

    End Sub

    Private Function validar_campos() As Boolean
        If txt_id_localidad.Text = "" Then
            MessageBox.Show("El campo ID está vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_id_localidad.Focus()
            Exit Function
        End If
        If txt_descripcion.Text = "" Then
            MessageBox.Show("El campo DESCRIPCIÓN está vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.txt_descripcion.Focus()
            Exit Function
        End If
        If txt_cod_postal.Text = "" Then
            MessageBox.Show("El campo CODIGO POSTAL está vacío!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            txt_cod_postal.Focus()
            Exit Function
        End If
        If cmb_dptos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un departamento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Me.cmb_dptos.Focus()
            Exit Function
        End If

        Return True
    End Function

    Private Function validar_existencia() As analizar_existencia
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT * FROM LOCALIDADES WHERE id = " & Me.txt_id_localidad.Text
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If

    End Function

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        guardar()
    End Sub
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



    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.nuevo()
    End Sub

    Private Sub dgv_localidades_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_localidades.CellMouseDoubleClick
        condicion = estado.modificar
        Dim tabla As DataTable
        Dim sql As String = ""
        txt_id_localidad.Enabled = False

        sql &= "SELECT * FROM LOCALIDADES WHERE id = " & Me.dgv_localidades.CurrentRow.Cells("id_localidad").Value

        tabla = acceso.consulta(sql)
        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Debe seleccionar una fila válida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.txt_id_localidad.Text = tabla.Rows(0)("id")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Me.txt_cod_postal.Text = tabla.Rows(0)("cod_postal")
        Me.cmb_dptos.SelectedValue = tabla.Rows(0)("id_departamento")

        cmd_eliminar.Enabled = True
        cmd_guardar.Enabled = True
        cmd_nuevo.Enabled = True
        cmd_cancelar.Enabled = True
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim sql As String = ""
        If MessageBox.Show("¿Esta seguro que desea borrar el registro?", _
             "Atencion", MessageBoxButtons.OKCancel, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            If IsNumeric(Me.txt_id_localidad.Text) Then
                sql = "DELETE FROM LOCALIDADES "
                sql &= "WHERE id = " & Me.txt_id_localidad.Text

                acceso.ejecutar(sql)
            Else
                MessageBox.Show("El elemento no existe o ingrese un valor numérico")
                Me.txt_id_localidad.Focus()
                Exit Sub
            End If
        End If
        Me.txt_id_localidad.Enabled = True
        Me.cargar_grilla()
        Me.limpiar(Me.Controls)
        cmd_cancelar.Enabled = True
        Me.condicion = estado.insertar
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        limpiar(Controls)
        cmd_nuevo.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_cancelar.Enabled = False
        cmd_guardar.Enabled = False
        cargar_grilla()
        cmb_dptos.SelectedIndex = -1
        txt_id_localidad.Enabled = True
        txt_id_localidad.Focus()
    End Sub

    Private Sub cmd_buscar_id_Click(sender As Object, e As EventArgs) Handles cmd_buscar_id.Click

        Dim sql As String = ""
        Dim tabla As New DataTable
        If txt_id_localidad.Text = "" Then
            MessageBox.Show("Ingrese un valor numérico antes de buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd_buscar_id.Focus()
            Exit Sub
        Else
            sql &= "SELECT L.id, L.descripcion, L.cod_postal, L.id_departamento, D.descripcion AS descrip"
            sql &= " FROM LOCALIDADES L JOIN DEPARTAMENTOS D ON L.id_departamento = D.id WHERE L.id = " & Me.txt_id_localidad.Text
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró una localidad con el ID: " & Me.txt_id_localidad.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgv_localidades.Rows.Clear()
                dgv_localidades.Rows.Add()
                dgv_localidades.Rows(0).Cells("id_localidad").Value = tabla.Rows(0)("id")
                dgv_localidades.Rows(0).Cells("descripcion").Value = tabla.Rows(0)("descripcion")
                dgv_localidades.Rows(0).Cells("cod_postal").Value = tabla.Rows(0)("cod_postal")
                dgv_localidades.Rows(0).Cells("dpto").Value = tabla(0)("descrip")
                dgv_localidades.Rows(0).Cells("id_dpto").Value = tabla(0)("id_departamento")
            End If
        End If
        limpiar(Controls)
        txt_id_localidad.Focus()

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cmd_buscar_codpostal_Click(sender As Object, e As EventArgs) Handles cmd_buscar_codpostal.Click
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim c As Integer = 0
        If txt_cod_postal.Text = "" Then
            MessageBox.Show("Ingrese un valor numérico antes de buscar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd_buscar_id.Focus()
            Exit Sub
        Else
            sql &= "SELECT L.id, L.descripcion, L.cod_postal, L.id_departamento, D.descripcion AS descrip"
            sql &= " FROM LOCALIDADES L JOIN DEPARTAMENTOS D ON L.id_departamento = D.id WHERE L.cod_postal = " & Me.txt_cod_postal.Text
            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontró una localidad con el Codigo Postal: " & Me.txt_cod_postal.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dgv_localidades.Rows.Clear()
                For c = 0 To tabla.Rows.Count - 1
                    dgv_localidades.Rows.Add()
                    dgv_localidades.Rows(c).Cells("id_localidad").Value = tabla.Rows(c)("id")
                    dgv_localidades.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
                    dgv_localidades.Rows(c).Cells("cod_postal").Value = tabla.Rows(c)("cod_postal")
                    dgv_localidades.Rows(c).Cells("dpto").Value = tabla(c)("descrip")
                    dgv_localidades.Rows(c).Cells("id_dpto").Value = tabla(c)("id_departamento")
                Next
            End If
        End If
        limpiar(Controls)
        txt_cod_postal.Focus()
    End Sub

    Private Sub cmd_buscar_nombre_Click(sender As Object, e As EventArgs) Handles cmd_buscar_nombre.Click
        Dim tabla As New DataTable
        Dim sql As String = ""

        If Me.txt_descripcion.Text = "" Then
            MessageBox.Show("Debe ingresar un nombre en el campo descripcion!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            sql &= "SELECT L.id, L.descripcion, L.cod_postal, L.id_departamento, D.descripcion AS descrip"
            sql &= " FROM LOCALIDADES L JOIN DEPARTAMENTOS D ON L.id_departamento = D.id WHERE L.descripcion = '" & Me.txt_descripcion.Text & "' "

            tabla = acceso.consulta(sql)

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No existe una localidad con el nombre: " & Me.txt_descripcion.Text)
                txt_descripcion.Focus()
                Exit Sub
            Else
                Me.dgv_localidades.Rows.Clear()
                Me.dgv_localidades.Rows.Add()
                Me.dgv_localidades.Rows(0).Cells("id_localidad").Value = tabla.Rows(0)("id")
                Me.dgv_localidades.Rows(0).Cells("cod_postal").Value = tabla.Rows(0)("cod_postal")
                Me.dgv_localidades.Rows(0).Cells("descripcion").Value = tabla.Rows(0)("descripcion")
                Me.dgv_localidades.Rows(0).Cells("id_dpto").Value = tabla.Rows(0)("id_departamento")
                Me.dgv_localidades.Rows(0).Cells("dpto").Value = tabla.Rows(0)("descrip")
            End If
        End If
        limpiar(Controls)
    End Sub

    Private Sub cmd_filtrar_dptos_Click(sender As Object, e As EventArgs) Handles cmd_filtrar_dptos.Click
        Dim tabla As New DataTable
        Dim sql As String = ""
        If cmb_dptos.SelectedIndex <> -1 Then
            sql &= "SELECT L.id, L.descripcion, L.cod_postal, L.id_departamento, D.descripcion AS descrip"
            sql &= " FROM LOCALIDADES L JOIN DEPARTAMENTOS D ON L.id_departamento = D.id WHERE L.id_departamento = " & Me.cmb_dptos.SelectedValue

            tabla = acceso.consulta(sql)
            Dim c As Integer = 0
            dgv_localidades.Rows.Clear()

            For c = 0 To tabla.Rows.Count - 1
                dgv_localidades.Rows.Add()
                dgv_localidades.Rows(c).Cells("id_localidad").Value = tabla.Rows(c)("id")
                dgv_localidades.Rows(c).Cells("cod_postal").Value = tabla.Rows(c)("cod_postal")
                dgv_localidades.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
                dgv_localidades.Rows(c).Cells("id_dpto").Value = tabla.Rows(c)("id_departamento")
                dgv_localidades.Rows(c).Cells("dpto").Value = tabla.Rows(c)("descrip")

            Next
        Else
            MessageBox.Show("Debe seleccionar un departamento antes de buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_dptos.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub nuevo()
        Dim sql As String = "select * from localidades "
        Dim tabla As New DataTable
        limpiar(Controls)
        tabla = acceso.consulta(sql)
        Dim ultimo As Integer = tabla.Rows.Count() - 1
        Me.txt_id_localidad.Text = tabla.Rows(ultimo)("id") + 1
        txt_id_localidad.Enabled = False
        cmd_eliminar.Enabled = False
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        cmd_cancelar.Enabled = True
        cmb_dptos.SelectedIndex = -1
        txt_descripcion.Focus()

    End Sub

    Private Sub guardar()
        If Me.validar_campos() = True Then
            If condicion = estado.insertar Then
                If validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe una localidad con ese ID!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
        Else
            Exit Sub
        End If
        Me.limpiar(Controls)
        cargar_grilla()
        Me.cmd_guardar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        cmd_eliminar.Enabled = False
        cmd_cancelar.Enabled = True
        cmb_dptos.SelectedIndex = -1
    End Sub

    Private Sub abm_localidades_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            nuevo()
        End If
        If e.Control And e.KeyCode.ToString = "G" Then
            guardar()
        End If
    End Sub

    Private Sub tip()
        tltp_localidades.SetToolTip(cmd_buscar_codpostal, "Buscar por código postal")
        tltp_localidades.SetToolTip(cmd_buscar_id, "Buscar por ID de la localidad")
        tltp_localidades.SetToolTip(cmd_buscar_nombre, "Buscar por nombre de la localidad")
        tltp_localidades.SetToolTip(cmd_cancelar, "Limpiar formulario")
        tltp_localidades.SetToolTip(cmd_eliminar, "Eliminar registro")
        tltp_localidades.SetToolTip(cmd_filtrar_dptos, "Buscar localidades por departamento")
        tltp_localidades.SetToolTip(cmd_guardar, "Guardar")
        tltp_localidades.SetToolTip(cmd_nuevo, "Nuevo")
        tltp_localidades.SetToolTip(cmd_salir, "Salir")


    End Sub


    Private Sub cmb_dptos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_dptos.SelectedValueChanged
        Dim localidades As String = ""
        If cmb_dptos.SelectedIndex <> -1 Then
            Dim tabla As New DataTable
            Dim sql As String = "SELECT * FROM LOCALIDADES WHERE id_departamento = " & Me.cmb_dptos.SelectedValue

            tabla = acceso.consulta(sql)

            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count - 1
                localidades += tabla.Rows(c)("descripcion") & vbCrLf

            Next
        End If
        tltp_localidades.SetToolTip(cmb_dptos, localidades)

    End Sub

    'CODIGO DE AUTOCOMPLETADO: VER
    'Private Sub autocompletar(ByVal textbx As TextBox)

    '    cmd = New OleDb.OleDbCommand("select descripcion from LOCALIDADES", conexion)
    '    res = cmd.ExecuteReader()

    '    While res.Read()
    '        textbx.AutoCompleteCustomSource.Add(res.Item("descripcion"))


    '    End While
    '    res.Close()


    'End Sub

    'Dim conexion As OleDb.OleDbConnection
    'Dim cmd As OleDb.OleDbCommand
    'Dim adaptador As OleDb.OleDbDataAdapter
    'Dim res As OleDb.OleDbDataReader

    'Private Sub abrir()
    '    conexion = New OleDb.OleDbConnection("Provider=SQLNCLI11;Data Source=LORE-PC\SQLEXPRESS;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88")
    '    conexion.Open()
    'End Sub
    ''FIN DE CODIGO DE AUTOCOMPLETADO


End Class