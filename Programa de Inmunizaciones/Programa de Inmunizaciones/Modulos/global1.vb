
Module global1
    Public acceso As New acceso_datos With {._motor = acceso_datos.motores.sqlServer _
                                        , ._cadena_conexion = "Provider=SQLNCLI11;Data Source=25.36.109.252;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88"} 'VER CADENA DE CONEXION DEFINITIVA
    Public acceso2 As New acceso_datos With {._motor = acceso_datos.motores.sqlServer _
                                       , ._cadena_conexion = "Provider=SQLNCLI11;Data Source=LORE-PC\SQLEXPRESS;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88"} 'VER CADENA DE CONEXION DEFINITIVA
End Module

