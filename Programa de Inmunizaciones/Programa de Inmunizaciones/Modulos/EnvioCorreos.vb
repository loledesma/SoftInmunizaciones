Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient


    Sub enviarCorreo(ByVal destinatario As String)
        Try
            correos.To.Clear()
            correos.Body = "Desde el equipo de sistemas esperamos que pases un excelente día y que tengas un excelente cumpleaños!"
            correos.Subject = "!Feliz cumple!"
            'correos.Body = mensaje
            'correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            Dim ruta As String = "C:\Users\Joaquin\Source\Repos\SoftInmunizaciones4\Programa de Inmunizaciones\Programa de Inmunizaciones\Imagenes\Cartel cumpleaños.jpg"
            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correos.Attachments.Add(archivo)
            End If

            correos.From = New MailAddress("here va el correo")
            envios.Credentials = New NetworkCredential("aca tambien va el correo", "acá va la pwrd")

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module
