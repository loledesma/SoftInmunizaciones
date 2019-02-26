Public Class SampleIIdentity
    Implements System.Security.Principal.IIdentity
    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole
    Public ReadOnly Property AuthenticationType As String Implements Security.Principal.IIdentity.AuthenticationType
        Get
            Return "SqlDataBase"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name As String Implements Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property
    Public Sub New(ByVal name As String, ByVal password As String)
        Dim rol As Integer = 0
        If IsValidNameAndPassword(name, password) Then
            nameValue = name
            authenticatedValue = True
            rol = obtenerRol(name)
            If rol <> 1 Then
                roleValue = ApplicationServices.BuiltInRole.User
            Else
                roleValue = ApplicationServices.BuiltInRole.Administrator
            End If

        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If
    End Sub

    Private Function obtenerRol(ByVal name As String) As Integer
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT * FROM USUARIOS_GEVAC "
        sql &= " WHERE usuario='" & name & "'"
        tabla = acceso.consulta(sql)
        Dim rol As Integer = tabla.Rows(0)("id_rol")
        Return rol
    End Function

    Private Function IsValidNameAndPassword(
    ByVal username As String,
    ByVal password As String) As Boolean


        Dim contraseña As String = GetPassword(username)

        If contraseña <> "" Then
            If contraseña = password Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function
    Private Function GetPassword(ByVal username As String) As String
        Dim tabla As New DataTable
        Dim sql As String

        If username = "" Then
            MsgBox("Debe ingresar su usuario")
        Else
            sql = "SELECT * FROM USUARIOS_GEVAC WHERE usuario='" & username & "'"
            tabla = acceso.consulta(sql)
            If Trim(username).ToLower = tabla.Rows(0)("usuario") Then
                Return tabla.Rows(0)("contraseña")
            Else
                Return ""
            End If
        End If

    End Function



End Class
