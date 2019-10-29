
Module global1
    ' Cadena de conexión Red Local Provider=SQLNCLI11;Data Source=LORE-PC\SQLEXPRESS;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES; password= lore88
    'Provider=SQLNCLI11;Data Source=25.36.109.252;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES; password= lore88
    Public acceso As New acceso_datos With {._motor = acceso_datos.motores.sqlServer, ._cadena_conexion = "Provider=SQLNCLI11;Data Source=LORE-PC\SQLEXPRESS;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES; password= lore88"}

    Enum conexion_hamachi
        vacio
        hamachi
        interno
    End Enum

    Public validacion_conexion As conexion_hamachi = conexion_hamachi.vacio

End Module

