Public Class Enviar_correo_global
    Enum estado
        insertar
        modificar
    End Enum
    Enum analizar
        existe
        noExiste
    End Enum

    Dim condicion_estado As estado = estado.insertar

    Private Sub Enviar_correo_global_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


 
    Private Sub abm_stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
   


    Private Sub cmd_empleado_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_empleado_nuevo.Click
        abm_empleados.ShowDialog()
    End Sub

    Private Sub cmd_enviar_Click(sender As Object, e As EventArgs) Handles cmd_enviar.Click
        enviarCorreo(txt_destinatario.Text, txt_cuerpo.Text, txt_asunto.Text)
    End Sub

  
End Class