Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ClickButton(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cumples.CellContentClick
        If dgv_cumples.CurrentRow.Cells("enviar_Correo").Value Then
            enviarCorreo(dgv_cumples.CurrentRow.Cells("mail_contacto").Value)
        End If
    End Sub


End Class
