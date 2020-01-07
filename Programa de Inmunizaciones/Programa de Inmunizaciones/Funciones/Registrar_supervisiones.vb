Public Class Registrar_supervisiones

    Private Sub Registrar_supervisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo()
        Me.cmb_empleados.SelectedIndex = -1
        Me.cmb_heladera.cargar()
        Me.cmb_heladera.SelectedIndex = -1
        Me.cmb_tipos_documento.cargar()
        Me.cmb_tipos_documento.SelectedIndex = -1
        Me.cmb_tipo_heladera.cargar()
        Me.cmb_tipo_heladera.SelectedIndex = -1
    End Sub
    Private Sub cargar_combo()
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql &= "SELECT E.id as id, E.nombres as nombre, EMP.id_cargo "
        sql &= " FROM EMPLEADOS E JOIN EMPLEADOSXEFECTOR EMP ON E.id = EMP.id_empleados "
        sql &= " WHERE EMP.id_cargo = 1 "

        tabla = acceso.consulta(sql)

        Me.cmb_empleados.DataSource = tabla
        Me.cmb_empleados.DisplayMember = "nombre"
        Me.cmb_empleados.ValueMember = "id"
    End Sub

   
End Class