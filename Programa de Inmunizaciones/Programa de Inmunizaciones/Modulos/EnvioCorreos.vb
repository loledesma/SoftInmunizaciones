﻿Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient


    Sub enviarCorreo(ByVal destinatario As String)
        Try
            correos.To.Clear()
            'correos.Body = mensaje
            'correos.Subject = asunto
            correos.From = New MailAddress("soft.inmunizaciones@gmail.com")
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            correos.Subject = "¡FELIZ CUMPLE!"
            'Dim imagen = New System.Drawing.Bitmap()

            Dim text As String = "Desde el equipo de sistemas esperamos que pases un excelente día y que tengas un excelente cumpleaños!"

            Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, MediaTypeNames.Text.Plain)

            Dim html As String = "<img src='cid:imagen' />"

            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html)

            Dim img As LinkedResource = New LinkedResource("C:\Users\LORE\Documents\GitHub\SoftInmunizaciones\Programa de Inmunizaciones\Programa de Inmunizaciones\Resources\cumpleaños.jpg", MediaTypeNames.Image.Jpeg)
            img.ContentId = "cumpleaños"

            htmlView.LinkedResources.Add(img)

            correos.AlternateViews.Add(plainView)
            correos.AlternateViews.Add(htmlView)


            'Dim ruta = Programa_de_Inmunizaciones.My.Resources.Cartel_cumpleaños.ToString
            'If ruta <> "" Then
            '    Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
            '    correos.Attachments.Add(archivo)
            'End If

            'Dim ruta As String = Application.StartupPath & "\Resources\cumpleaños.jpg"
            'Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
            'correos.Attachments.Add(archivo)


            envios.Credentials = New NetworkCredential("soft.inmunizaciones@gmail.com", "Inmunizaciones2015")

            ''Datos importantes no modificables para tener acceso a las cuentas

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
