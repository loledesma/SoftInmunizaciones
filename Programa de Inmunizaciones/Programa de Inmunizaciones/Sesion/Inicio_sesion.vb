Public Class Inicio_sesion

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If name.Text = "" Then
            MsgBox("Debe ingresar un usuario")
        End If
        Dim samplePrincipal As New SampleIPrincipal(
    Me.name.Text, Me.password.Text)
        Me.password.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            MsgBox("El usuario y la contraseña son incorrectos")
        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal
            Me.Close()
        End If
    End Sub



    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Programa_de_Inmunizaciones.Menu.Close()

    End Sub
End Class
