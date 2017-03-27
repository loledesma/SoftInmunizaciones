Public Class acceso_datos
        Enum motores
            sqlServer
            mySql
            oracle
        End Enum
        Enum tipo_conexion
            simple
            transaccion
        End Enum
        Enum resultado
            ok
            fallido
        End Enum

        Dim control_transaccion As resultado = resultado.ok
        Dim ultimo_error As String = ""
        Dim configurar_conexion As tipo_conexion = tipo_conexion.simple
        Dim transcacion As Object
        Dim cadena_conexion As String = ""
        Dim conexion As Object
        Dim cmd As Object
        Dim motor As motores = motores.sqlServer
        Dim nombre_tabla As String = ""


        Public Property _nombre_tabla As String
            Get
                Return nombre_tabla
            End Get
            Set(value As String)
                nombre_tabla = value
            End Set
        End Property

        Public Property _cadena_conexion As String
            Get
                Return cadena_conexion
            End Get
            Set(value As String)
                cadena_conexion = value
            End Set
        End Property

        Public Property _motor As motores
            Get
                Return motor
            End Get
            Set(value As motores)
                motor = value
            End Set
        End Property

        Public Sub New()
            Select Case Me.motor
                Case motores.sqlServer
                    Me.conexion = New OleDb.OleDbConnection
                    Me.cmd = New OleDb.OleDbCommand
            End Select
        End Sub

        Private Function conectar() As resultado

            If conexion.state.ToString <> "Open" Then
                conexion.ConnectionString = cadena_conexion

                Try
                    conexion.Open()
                Catch ex As Exception
                    MessageBox.Show("Error al intentar conectar", "Error grave")
                    Me.ultimo_error = ex.Message
                    Return resultado.fallido
                End Try

                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                If Me.configurar_conexion = tipo_conexion.transaccion Then
                    Me.transcacion = conexion.BeginTransaction()
                    cmd.Transaction = Me.transcacion
                End If
            End If
            Return resultado.ok
        End Function

        Public Sub conexion_con_transaccion()
            Me.configurar_conexion = tipo_conexion.transaccion
            Me.control_transaccion = resultado.ok
        End Sub

        Public Sub cerrar_con_transaccion()
            If control_transaccion = resultado.ok Then
                Me.transcacion.Commit()
            Else
                Me.transcacion.Rollback()
            End If

            Me.conexion.Close()
            Me.configurar_conexion = tipo_conexion.simple
        End Sub

        Private Sub cerrar()
            If configurar_conexion = tipo_conexion.simple Then
                Me.conexion.close()
            End If
        End Sub

        Public Function consulta(ByRef sql As String) As DataTable
            Dim tabla As New DataTable
            Me.conectar()
            Me.cmd.CommandText = sql
            Try
                tabla.Load(cmd.ExecuteReader())
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.cerrar()
            Return tabla
        End Function

        Public Sub ejecutar(ByVal comando As String)
            Me.conectar()
            Me.cmd.CommandText = comando

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.cerrar()
        End Sub

        Public Function insertar(ByVal datos As String) As resultado
            Dim igual, coma, columna As Integer
            Dim valor As String
            Dim str As String = datos.ToUpper
            Dim tabla As DataTable
            Dim nom_col As String
            Dim cabecera As String = ""
            Dim paquete_datos As String = ""
            Dim tipo_dato As String = ""
            Dim sql_insert As String = ""

            tabla = Me.estructura_tabla()

            Dim c As Integer

            For c = 0 To tabla.Columns.Count() - 1
                nom_col = tabla.Columns(c).Caption.ToUpper 'Caption es el nombre de la tabla
                columna = str.IndexOf(nom_col) 'Verifica si el nombre de la columna se encuentra en el string
                If columna = -1 Then
                    Continue For 'Es un next forzado. Toda la programación siguiente la saltea
                End If
                igual = str.IndexOf("=", columna) 'Busca el igual condicionado después de columna, que ya se encontró
                coma = str.IndexOf(",", columna)

                If coma = -1 Then
                    valor = str.Substring(igual + 1)
                Else
                    valor = str.Substring(igual + 1, coma - igual - 1)
                End If

                tipo_dato = tabla.Columns(c).DataType.Name

                If cabecera = "" Then
                    cabecera += nom_col
                    paquete_datos += Me.formatear(valor, tipo_dato)
                Else
                    cabecera += "," + nom_col
                    paquete_datos += "," + Me.formatear(valor, tipo_dato)
                End If
            Next

            sql_insert = "INSERT INTO " & Me.nombre_tabla
            sql_insert &= "(" & cabecera & ") VALUES ("
            sql_insert &= paquete_datos & ")"

            If resultado.ok = Me.conectar() Then
                Me.cmd.CommandText = sql_insert
                Try
                    Me.cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Me.control_transaccion = resultado.fallido
                    Me.cerrar()
                    Return resultado.fallido
                End Try
                Me.cerrar()
                Return resultado.ok
            End If

        End Function

        Private Function formatear(ByVal dato As String, ByVal tipo_dato As String) As String
            Select Case tipo_dato
                Case "String"
                    Return "'" + dato + "'"
                Case Else
                    Return dato
            End Select
        End Function

        Private Function estructura_tabla() As DataTable
            Dim sql As String = ""
            sql = "SELECT TOP 1 * FROM " & Me.nombre_tabla 'Devuelve la primer fila de la tabla
            Select Case Me.motor
                Case motores.sqlServer
                    Return Me.consulta(sql)
            End Select

            Return New DataTable
        End Function

        Public Sub borrar(ByVal tabla As String, ByVal restriccion As String)
            Dim sql As String = ""

            sql &= "DELETE FROM " & tabla
            sql &= " WHERE " & restriccion
            acceso.ejecutar(sql)

    End Sub

    Public Sub borrar(ByVal tabla As String, ByVal restriccion As String, ByVal restriccion2 As String)
        Dim sql As String = ""

        sql &= "DELETE FROM " & tabla
        sql &= " WHERE " & restriccion
        sql &= " AND " & restriccion2
        acceso.ejecutar(sql)

    End Sub

    Public Function leo_tabla() As Data.DataTable
        Return Me.consulta("SELECT * FROM " & Me.nombre_tabla)
    End Function

    Public Function leo_tabla(ByVal nombre As String) As Data.DataTable
        Return Me.consulta("SELECT * FROM " & nombre)
    End Function

    Public Function leo_tabla(ByVal pk As Integer, ByVal descripcion As String, ByVal nombre As String) As Data.DataTable
        Return Me.consulta("SELECT " & pk & ", " & descripcion & " FROM " & nombre)
    End Function

    Public Function leo_tabla(ByVal nom_tabla As String, ByVal nom_col As String, ByVal valor As String) As Data.DataTable
        Return Me.consulta("SELECT * FROM " & nom_tabla & " WHERE " & nom_col & "= " & valor)
    End Function

    Public Function leo_tabla(ByVal nom_tabla As String, ByVal nom_col As String, ByVal valor As String, ByVal nom_col2 As String, ByVal valor2 As String) As Data.DataTable
        Return Me.consulta("SELECT * FROM " & nom_tabla & " WHERE " & nom_col & "= " & valor & " OR " & nom_col2 & " = " & valor2)
    End Function

    Public Sub autocompletar(ByVal textbx As TextBox, ByVal tabla As String, ByVal descripcion As String)
        Dim conexion As OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbCommand
        Dim res As OleDb.OleDbDataReader
        conexion = New OleDb.OleDbConnection("Provider=SQLNCLI11;Data Source=25.36.109.252;Persist Security Info=True;User ID=LORE;Initial Catalog=INMUNIZACIONES;password = lore88")
        conexion.Open()

        cmd = New OleDb.OleDbCommand("SELECT " & descripcion & " FROM " & tabla, conexion)
        res = cmd.ExecuteReader()

        While res.Read()
            If IsDBNull(res.Item(descripcion)) = False Then
                textbx.AutoCompleteCustomSource.Add(res.Item(descripcion))
            End If
        End While
        res.Close()
    End Sub

End Class
