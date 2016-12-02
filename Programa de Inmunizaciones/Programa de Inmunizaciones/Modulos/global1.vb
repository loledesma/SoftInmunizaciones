
Module global1
    Public acceso As New acceso_datos With {._motor = acceso_datos.motores.sqlServer _
                                        , ._cadena_conexion = "Provider=SQLNCLI11;Data Source=192.168.0.6;User ID=LORE;Initial Catalog=INMUNIZACIONES"} 'VER CADENA DE CONEXION DEFINITIVA
End Module

