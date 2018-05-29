Imports System.Net.Mail

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
    Dim ADJUNTO As Attachment

    Private Sub Enviar_correo_global_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar(Controls)

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
                Case "Programa_de_Inmunizaciones.ComboBoxV1"
                    cmd = obj
                    cmd.SelectedIndex = -1
                Case "System.Windows.Forms.GroupBox"
                    Me.limpiar(obj.Controls)
            End Select
        Next obj

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
        If txt_adjuntos.Text = "" Then
            enviarCorreo(txt_destinatario.Text, txt_cuerpo.Text, txt_asunto.Text)
        Else
            enviarCorreo(txt_destinatario.Text, txt_cuerpo.Text, txt_asunto.Text, ADJUNTO)
        End If
    End Sub




    Private Sub txt_examinar_Click(sender As Object, e As EventArgs) Handles txt_examinar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ADJUNTO = New Attachment(OpenFileDialog1.FileName)
            Dim ARCHIVO As String = OpenFileDialog1.FileName
            txt_adjuntos.Text = OpenFileDialog1.FileName.Remove(0, OpenFileDialog1.FileName.LastIndexOf("\") + 1)
        End If
    End Sub
End Class