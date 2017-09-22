Imports System.Windows.Forms

Public Class Tareas

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlarPendientes()
    End Sub

    Private Sub controlarPendientes()
        Dim tabla As New DataTable
        Dim sql As String

        sql = "SELECT id_administrador as id FROM RECORDATORIOS "
        sql &= "WHERE id_estado = 2"
        tabla = acceso.consulta(sql)
        Dim c As Integer = 0

        For c = 0 To tabla.Rows.Count() - 1
            If tabla.Rows.Count() = 0 Then
                Exit Sub
            Else
                If tabla.Rows(c)("id") = 2 Then
                    Label1.Visible = True
                    picbox_1.Visible = True
                End If
                If tabla.Rows(c)("id") = 3 Then
                    Label2.Visible = True
                    picbox_2.Visible = True
                End If
                If tabla.Rows(c)("id") = 4 Then
                    Label3.Visible = True
                    picbox_3.Visible = True
                End If
            End If
        Next

    End Sub

End Class
