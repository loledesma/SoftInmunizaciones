Public Class ComboBoxV1
    Inherits ComboBox
    Dim nombre_tabla As String = ""
    Dim pk As String = ""
    Dim descripcion As String = ""

    Public Property _nombre_tabla As String
        Get
            Return nombre_tabla
        End Get
        Set(value As String)
            nombre_tabla = value
        End Set
    End Property

    Public Property _pk As String
        Get
            Return pk
        End Get
        Set(value As String)
            pk = value
        End Set
    End Property

    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'URGENTE : Modificar
    Public Sub cargar()
        Dim tabla As New DataTable
        Dim acc As acceso_datos = global1.acceso
        tabla = acc.leo_tabla(nombre_tabla)
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
        Me.DataSource = tabla
    End Sub

    Public Sub cargar(ByVal nom_col As String, ByVal valor As String)
        Dim tabla As New DataTable
        Dim acc As acceso_datos = global1.acceso
        tabla = acc.leo_tabla(nombre_tabla, nom_col, valor)
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
        Me.DataSource = tabla
    End Sub

    Public Sub cargar(ByVal nom_col As String, ByVal valor As String, ByVal nom_col2 As String, ByVal valor2 As String)
        Dim tabla As New DataTable
        Dim acc As acceso_datos = global1.acceso
        tabla = acc.leo_tabla(nombre_tabla, nom_col, valor, nom_col2, valor2)
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
        Me.DataSource = tabla
    End Sub
End Class
