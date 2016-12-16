Public Class Registrar_efectores

    Private Sub Registrar_efectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_barrios.cargar()
        cmb_departamento.cargar()
        cmb_localidades.cargar()
        cmb_referentes.cargar()
        cmb_tipos_efectores.cargar()
        cmb_estado_efector.cargar()
        cmb_tipo_carga.cargar()

    End Sub

End Class