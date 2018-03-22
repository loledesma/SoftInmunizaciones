Public Class SampleIPrincipal

    Implements System.Security.Principal.IPrincipal
    Private identityValue As SampleIIdentity


    Public ReadOnly Property Identity As Security.Principal.IIdentity Implements Security.Principal.IPrincipal.Identity
        Get

            Return identityValue
        End Get
    End Property

    Public Function IsInRole(role As String) As Boolean Implements Security.Principal.IPrincipal.IsInRole
        Return role = identityValue.Role.ToString
    End Function

    Public Sub New(ByVal name As String, ByVal password As String)
        identityValue = New SampleIIdentity(name, password)
    End Sub
End Class
