Public Class pop_up_recordatorios

    Private Sub pop_up_recordatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub verificar()
        Dim tabla As New DataTable
        Dim sql As String = ""


        sql = "SELECT R.descripcion as descripcion, R.fecha_evento,R.fecha, R.id, R.id_estado, E.NOMBRES from RECORDATORIOS R JOIN EMPLEADOS E ON R.id_administrador = E.id"
        sql &= " WHERE R.fecha_evento = '" & Date.Today & "'"

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count <> 0 Then
            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count() - 1
                dgv_recordatorios.Rows.Add()
                dgv_recordatorios.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
                dgv_recordatorios.Rows(c).Cells("administrador").Value = tabla.Rows(c)("nombres")
                dgv_recordatorios.Rows(c).Cells("id_recordatorio").Value = tabla.Rows(c)("id")
                If tabla.Rows(c)("id_estado") = 1 Then
                    dgv_recordatorios.Rows(c).Cells("cmd_solucionado").Value = "SOLUCIONADO"
                ElseIf tabla.Rows(c)("id_estado") = 2 Then
                    dgv_recordatorios.Rows(c).Cells("cmd_solucionado").Value = "PENDIENTE"
                ElseIf tabla.Rows(c)("id_estado") = 3 Then
                    dgv_recordatorios.Rows(c).Cells("cmd_solucionado").Value = "NO APLICA"
                End If
            Next
            Me.Show()
            'Else
            'MessageBox.Show("No hay eventos para el día de hoy!", "Atención", MessageBoxButtons.OK)
        End If


    End Sub


    'VERIFICAR DIA SIGUIENTE

    Public Sub verificarMañana()
        Dim tabla As New DataTable
        Dim sql As String = ""


        sql = "SELECT R.descripcion as descripcion, R.fecha_evento,R.fecha, R.id, R.id_estado, E.NOMBRES from RECORDATORIOS R JOIN EMPLEADOS E ON R.id_administrador = E.id"
        sql &= " WHERE DAY(R.fecha_evento) = " & Date.Today.Day + 1 & " AND MONTH(R.fecha_evento) =" & Date.Today.Month & " AND YEAR(R.fecha_evento) = " & Date.Today.Year

        tabla = acceso.consulta(sql)

        If tabla.Rows.Count <> 0 Then
            Dim c As Integer = 0
            For c = 0 To tabla.Rows.Count() - 1
                dgv_recordatoriosDiaSiguiente.Rows.Add()
                dgv_recordatoriosDiaSiguiente.Rows(c).Cells("descripcionMañana").Value = tabla.Rows(c)("descripcion")
                dgv_recordatoriosDiaSiguiente.Rows(c).Cells("administrador_mañana").Value = tabla.Rows(c)("nombres")
                dgv_recordatoriosDiaSiguiente.Rows(c).Cells("id_recordatorioMañana").Value = tabla.Rows(c)("id")
                If tabla.Rows(c)("id_estado") = 1 Then
                    dgv_recordatoriosDiaSiguiente.Rows(c).Cells("cmd_solucionadoMañana").Value = "SOLUCIONADO"
                ElseIf tabla.Rows(c)("id_estado") = 2 Then
                    dgv_recordatoriosDiaSiguiente.Rows(c).Cells("cmd_solucionadoMañana").Value = "PENDIENTE"
                ElseIf tabla.Rows(c)("id_estado") = 3 Then
                    dgv_recordatoriosDiaSiguiente.Rows(c).Cells("cmd_solucionadoMañana").Value = "NO APLICA"
                End If
            Next
            Me.Show()
        End If


    End Sub









    Private Sub cmd_recordatorios_Click(sender As Object, e As EventArgs) Handles cmd_recordatorios.Click

        Registrar_recordatorio.Show()

    End Sub

    Private Sub dgv_recordatorios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_recordatorios.CellClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "cmd_posponer" Then
            Dim tabla As New DataTable
            Dim sql As String

            sql = "select * from recordatorios where id = " & Me.dgv_recordatorios.CurrentRow.Cells("id_recordatorio").Value
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                dialogo_posponerRecordatorio.lbl_idRecordatorio.Text = tabla.Rows(0)("id")
                dialogo_posponerRecordatorio.lbl_fecha_actual_evento.Text = tabla.Rows(0)("fecha_evento")
                dialogo_posponerRecordatorio.txt_nuevaFechaEvento.Focus()
                dialogo_posponerRecordatorio.Show()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "cmd_editar" Then

            Dim tabla As New DataTable
            Dim sql As String

            sql = "select * from recordatorios where id = " & Me.dgv_recordatorios.CurrentRow.Cells("id_recordatorio").Value
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                dialogo_editarRecordatorio.lbl_idRecordatorio.Text = tabla.Rows(0)("id")
                dialogo_editarRecordatorio.txt_editarRecordatorio.Text = tabla.Rows(0)("descripcion")
                dialogo_editarRecordatorio.txt_editarRecordatorio.Focus()
                dialogo_editarRecordatorio.Show()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "cmd_solucionado" Then
            Dim tabla As New DataTable
            Dim sql1 As String = "select * from recordatorios where id = " & Me.dgv_recordatorios.CurrentRow.Cells("id_recordatorio").Value
            Dim sql As String = ""

            tabla = acceso.consulta(sql1)
            If tabla.Rows.Count() <> 0 Then
                If tabla.Rows(0)("id_estado") = 2 Or tabla.Rows(0)("id_estado") = 3 Then
                    sql = "update recordatorios set id_estado = 1 where id = " & Me.dgv_recordatorios.CurrentRow.Cells("id_recordatorio").Value
                    acceso.ejecutar(sql)
                    dgv_recordatorios.CurrentCell.Value = "SOLUCIONADO"
                    MessageBox.Show("Se actualizó el estado del recordatorio a SOLUCIONADO", "Atención☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf tabla.Rows(0)("id_estado") = 1 Then
                    sql = "update recordatorios set id_estado = 2 where id = " & Me.dgv_recordatorios.CurrentRow.Cells("id_recordatorio").Value
                    acceso.ejecutar(sql)
                    dgv_recordatorios.CurrentCell.Value = "PENDIENTE"
                    MessageBox.Show("Se actualizó el estado del recordatorio a PENDIENTE", "Atención☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
    End Sub









    'SEPARADOR GRILLA DIA SIGUIENTE




    Private Sub dgv_recordatoriosDiaSiguiente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_recordatoriosDiaSiguiente.CellClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "cmd_posponerMañana" Then
            Dim tabla As New DataTable
            Dim sql As String

            sql = "select * from recordatorios where id = " & Me.dgv_recordatoriosDiaSiguiente.CurrentRow.Cells("id_recordatorioMañana").Value
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                dialogo_posponerRecordatorio.lbl_idRecordatorio.Text = tabla.Rows(0)("id")
                dialogo_posponerRecordatorio.lbl_fecha_actual_evento.Text = tabla.Rows(0)("fecha_evento")
                dialogo_posponerRecordatorio.txt_nuevaFechaEvento.Focus()
                dialogo_posponerRecordatorio.Show()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "cmd_editarMañana" Then

            Dim tabla As New DataTable
            Dim sql As String

            sql = "select * from recordatorios where id = " & Me.dgv_recordatoriosDiaSiguiente.CurrentRow.Cells("id_recordatorioMañana").Value
            tabla = acceso.consulta(sql)
            If tabla.Rows.Count() <> 0 Then
                dialogo_editarRecordatorio.lbl_idRecordatorio.Text = tabla.Rows(0)("id")
                dialogo_editarRecordatorio.txt_editarRecordatorio.Text = tabla.Rows(0)("descripcion")
                dialogo_editarRecordatorio.txt_editarRecordatorio.Focus()
                dialogo_editarRecordatorio.Show()
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "cmd_solucionadoMañana" Then
            Dim tabla As New DataTable
            Dim sql1 As String = "select * from recordatorios where id = " & Me.dgv_recordatoriosDiaSiguiente.CurrentRow.Cells("id_recordatorioMañana").Value
            Dim sql As String = ""

            tabla = acceso.consulta(sql1)
            If tabla.Rows.Count() <> 0 Then
                If tabla.Rows(0)("id_estado") = 2 Or tabla.Rows(0)("id_estado") = 3 Then
                    sql = "update recordatorios set id_estado = 1 where id = " & Me.dgv_recordatoriosDiaSiguiente.CurrentRow.Cells("id_recordatorioMañana").Value
                    acceso.ejecutar(sql)
                    dgv_recordatoriosDiaSiguiente.CurrentCell.Value = "SOLUCIONADO"
                    MessageBox.Show("Se actualizó el estado del recordatorio a SOLUCIONADO", "Atención☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf tabla.Rows(0)("id_estado") = 1 Then
                    sql = "update recordatorios set id_estado = 2 where id = " & Me.dgv_recordatoriosDiaSiguiente.CurrentRow.Cells("id_recordatorioMañana").Value
                    acceso.ejecutar(sql)
                    dgv_recordatoriosDiaSiguiente.CurrentCell.Value = "PENDIENTE"
                    MessageBox.Show("Se actualizó el estado del recordatorio a PENDIENTE", "Atención☺", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
    End Sub

    Private Sub cmd_refresh_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click
        dgv_recordatorios.Rows.Clear()
        dgv_recordatoriosDiaSiguiente.Rows.Clear()
        verificar()
        verificarMañana()
    End Sub
End Class