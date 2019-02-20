Imports System.Windows.Forms

Public Class por_up_back_up
    Dim id As Integer
    Dim controlador As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub back_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        controlarBack()
    End Sub

    Private Sub controlarBack()
        Dim tabla As New DataTable
        Dim sql As String
        Dim num As Integer = 0

        sql = "SELECT top 1 id_backuper FROM BACK_UP ORDER BY fecha desc "
        tabla = acceso.consulta(sql)

        If tabla.Rows.Count() = 0 Then
            controlador = 2
            picbox_1.Image = Programa_de_Inmunizaciones.My.Resources.customer_person_people_woman_you_1627
            Label1.Text = "LORE"
        Else
            num = tabla.Rows(0)("id_backuper")
            If num = 4 Then
                controlador = 2
                picbox_1.Image = Programa_de_Inmunizaciones.My.Resources.customer_person_people_woman_you_1627
                Label1.Text = "L"
            Else
                If num = 2 Then
                    controlador = 3
                    picbox_1.Image = Programa_de_Inmunizaciones.My.Resources.images__2_
                    Label1.Text = "Joaquin"
                Else
                    controlador = 4
                    picbox_1.Image = Programa_de_Inmunizaciones.My.Resources.images__1_
                    Label1.Text = "Leandro"
                End If
            End If
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim sql As String = ""
        Dim hoy As Date = Date.Today.ToString("dd/MM/yyyy")
        acceso._nombre_tabla = "BACK_UP"


        sql &= " id_backuper =" & controlador
        sql &= ", fecha = '" & hoy & "'"

        acceso.insertar(sql)
    End Sub


End Class
