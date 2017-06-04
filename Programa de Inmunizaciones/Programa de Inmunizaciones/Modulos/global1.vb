
Module global1

    Public acceso As New acceso_datos With {._motor = acceso_datos.motores.sqlServer, ._cadena_conexion = "Provider=SQLNCLI11;Data Source=GRETA;Integrated Security=SSPI;Initial Catalog=INMUNIZACIONES"}
    'Public acceso As New acceso_datos
    'Dim cadena_conexion As String = ""
    'Dim conexion = New OleDb.OleDbConnection

    'Public Function instanciar_acceso() As acceso_datos
    '    acceso._motor = acceso_datos.motores.sqlServer
    '    acceso._cadena_conexion = "Provider=SQLNCLI11;Data Source=25.36.109.252;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88"
    '    Try
    '        conexion.ConnectionString = cadena_conexion
    '        conexion.Open()
    '        Return acceso
    '    Catch ex As Exception
    '        acceso._motor = acceso_datos.motores.sqlServer
    '        acceso._cadena_conexion = "Provider=SQLNCLI11;Data Source=LORE-PC\SQLEXPRESS;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88"
    '        Return acceso
    '    End Try
    'End Function

    Enum conexion_hamachi
        vacio
        hamachi
        interno
    End Enum

    Public validacion_conexion As conexion_hamachi = conexion_hamachi.vacio

End Module

