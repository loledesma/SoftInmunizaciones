<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_cadena_de_frio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_cadena_de_frio))
        Me.grp_datos_vacunatorio = New System.Windows.Forms.GroupBox()
        Me.txt_referentes = New System.Windows.Forms.TextBox()
        Me.cmb_estado_rm = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_pc = New System.Windows.Forms.TextBox()
        Me.txt_heladera = New System.Windows.Forms.TextBox()
        Me.lbl_pc = New System.Windows.Forms.Label()
        Me.lbl_heladera = New System.Windows.Forms.Label()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.cmd_buscar_cuie = New System.Windows.Forms.Button()
        Me.cmb_tipo_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_estado_efector = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_tipos_efectores = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_horarioDesde = New System.Windows.Forms.TextBox()
        Me.txt_horarioHasta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_departamento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_barrios = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_datos_vacunatorio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos_vacunatorio
        '
        Me.grp_datos_vacunatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_referentes)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_estado_rm)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label17)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_pc)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_heladera)
        Me.grp_datos_vacunatorio.Controls.Add(Me.lbl_pc)
        Me.grp_datos_vacunatorio.Controls.Add(Me.lbl_heladera)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_cuie)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_buscar_cuie)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipo_carga)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label15)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_estado_efector)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label14)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipos_efectores)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label13)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label12)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label11)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_horarioDesde)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_horarioHasta)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label10)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_telefono)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label9)
        Me.grp_datos_vacunatorio.Controls.Add(Me.GroupBox2)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_nombre)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label2)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label1)
        Me.grp_datos_vacunatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_vacunatorio.Location = New System.Drawing.Point(25, 23)
        Me.grp_datos_vacunatorio.Name = "grp_datos_vacunatorio"
        Me.grp_datos_vacunatorio.Size = New System.Drawing.Size(511, 375)
        Me.grp_datos_vacunatorio.TabIndex = 1
        Me.grp_datos_vacunatorio.TabStop = False
        Me.grp_datos_vacunatorio.Text = "Datos del vacunatorio  "
        '
        'txt_referentes
        '
        Me.txt_referentes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_referentes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_referentes.Location = New System.Drawing.Point(111, 137)
        Me.txt_referentes.Name = "txt_referentes"
        Me.txt_referentes.Size = New System.Drawing.Size(384, 20)
        Me.txt_referentes.TabIndex = 8
        '
        'cmb_estado_rm
        '
        Me.cmb_estado_rm._descripcion = "descripcion"
        Me.cmb_estado_rm._nombre_tabla = "ESTADO_RM"
        Me.cmb_estado_rm._pk = "id"
        Me.cmb_estado_rm.FormattingEnabled = True
        Me.cmb_estado_rm.Location = New System.Drawing.Point(345, 170)
        Me.cmb_estado_rm.Name = "cmb_estado_rm"
        Me.cmb_estado_rm.Size = New System.Drawing.Size(153, 21)
        Me.cmb_estado_rm.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(319, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "RM"
        '
        'txt_pc
        '
        Me.txt_pc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_pc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_pc.Location = New System.Drawing.Point(371, 110)
        Me.txt_pc.Name = "txt_pc"
        Me.txt_pc.Size = New System.Drawing.Size(125, 20)
        Me.txt_pc.TabIndex = 7
        '
        'txt_heladera
        '
        Me.txt_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_heladera.Location = New System.Drawing.Point(112, 108)
        Me.txt_heladera.Name = "txt_heladera"
        Me.txt_heladera.Size = New System.Drawing.Size(112, 20)
        Me.txt_heladera.TabIndex = 6
        '
        'lbl_pc
        '
        Me.lbl_pc.AutoSize = True
        Me.lbl_pc.Location = New System.Drawing.Point(308, 113)
        Me.lbl_pc.Name = "lbl_pc"
        Me.lbl_pc.Size = New System.Drawing.Size(43, 13)
        Me.lbl_pc.TabIndex = 20
        Me.lbl_pc.Text = "Internet"
        '
        'lbl_heladera
        '
        Me.lbl_heladera.AutoSize = True
        Me.lbl_heladera.Location = New System.Drawing.Point(16, 113)
        Me.lbl_heladera.Name = "lbl_heladera"
        Me.lbl_heladera.Size = New System.Drawing.Size(50, 13)
        Me.lbl_heladera.TabIndex = 19
        Me.lbl_heladera.Text = "Heladera"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(112, 19)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(159, 20)
        Me.txt_cuie.TabIndex = 0
        '
        'cmd_buscar_cuie
        '
        Me.cmd_buscar_cuie.BackgroundImage = CType(resources.GetObject("cmd_buscar_cuie.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_cuie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_cuie.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_cuie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_cuie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_cuie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_cuie.Location = New System.Drawing.Point(440, 15)
        Me.cmd_buscar_cuie.Name = "cmd_buscar_cuie"
        Me.cmd_buscar_cuie.Size = New System.Drawing.Size(62, 56)
        Me.cmd_buscar_cuie.TabIndex = 1
        Me.cmd_buscar_cuie.UseVisualStyleBackColor = True
        '
        'cmb_tipo_carga
        '
        Me.cmb_tipo_carga._descripcion = "descripcion"
        Me.cmb_tipo_carga._nombre_tabla = "TIPO_CARGA"
        Me.cmb_tipo_carga._pk = "id"
        Me.cmb_tipo_carga.FormattingEnabled = True
        Me.cmb_tipo_carga.Location = New System.Drawing.Point(345, 206)
        Me.cmb_tipo_carga.Name = "cmb_tipo_carga"
        Me.cmb_tipo_carga.Size = New System.Drawing.Size(153, 21)
        Me.cmb_tipo_carga.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(281, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Tipo carga"
        '
        'cmb_estado_efector
        '
        Me.cmb_estado_efector._descripcion = "descripcion"
        Me.cmb_estado_efector._nombre_tabla = "ESTADOS_EFECTOR"
        Me.cmb_estado_efector._pk = "id"
        Me.cmb_estado_efector.FormattingEnabled = True
        Me.cmb_estado_efector.Location = New System.Drawing.Point(113, 205)
        Me.cmb_estado_efector.Name = "cmb_estado_efector"
        Me.cmb_estado_efector.Size = New System.Drawing.Size(159, 21)
        Me.cmb_estado_efector.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Estado"
        '
        'cmb_tipos_efectores
        '
        Me.cmb_tipos_efectores._descripcion = "descripcion"
        Me.cmb_tipos_efectores._nombre_tabla = "TIPOS_EFECTORES"
        Me.cmb_tipos_efectores._pk = "id"
        Me.cmb_tipos_efectores.FormattingEnabled = True
        Me.cmb_tipos_efectores.Location = New System.Drawing.Point(111, 170)
        Me.cmb_tipos_efectores.Name = "cmb_tipos_efectores"
        Me.cmb_tipos_efectores.Size = New System.Drawing.Size(194, 21)
        Me.cmb_tipos_efectores.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tipo Efector"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Referente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "hasta"
        '
        'txt_horarioDesde
        '
        Me.txt_horarioDesde.Location = New System.Drawing.Point(325, 75)
        Me.txt_horarioDesde.Name = "txt_horarioDesde"
        Me.txt_horarioDesde.Size = New System.Drawing.Size(53, 20)
        Me.txt_horarioDesde.TabIndex = 4
        '
        'txt_horarioHasta
        '
        Me.txt_horarioHasta.Location = New System.Drawing.Point(435, 77)
        Me.txt_horarioHasta.Name = "txt_horarioHasta"
        Me.txt_horarioHasta.Size = New System.Drawing.Size(61, 20)
        Me.txt_horarioHasta.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Horario de atención"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(112, 77)
        Me.txt_telefono.Mask = "99999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Teléfono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_departamento)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmb_localidades)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_barrios)
        Me.GroupBox2.Controls.Add(Me.txt_numero)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_calle)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(6, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 106)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(108, 45)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(159, 21)
        Me.cmb_departamento.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Departamento"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(332, 45)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(158, 21)
        Me.cmb_localidades.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Localidad"
        '
        'cmb_barrios
        '
        Me.cmb_barrios._descripcion = "descripcion"
        Me.cmb_barrios._nombre_tabla = "BARRIOS"
        Me.cmb_barrios._pk = "id"
        Me.cmb_barrios.FormattingEnabled = True
        Me.cmb_barrios.Location = New System.Drawing.Point(108, 72)
        Me.cmb_barrios.Name = "cmb_barrios"
        Me.cmb_barrios.Size = New System.Drawing.Size(159, 21)
        Me.cmb_barrios.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(434, 19)
        Me.txt_numero.Mask = "99999999"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(56, 20)
        Me.txt_numero.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Barrio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(108, 19)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(275, 20)
        Me.txt_calle.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Calle"
        '
        'txt_nombre
        '
        Me.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre.Location = New System.Drawing.Point(112, 49)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(275, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIE"
        '
        'Inventario_cadena_de_frio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(823, 461)
        Me.Controls.Add(Me.grp_datos_vacunatorio)
        Me.Name = "Inventario_cadena_de_frio"
        Me.Text = "INVENTARIO DE CADENA DE FRIO"
        Me.grp_datos_vacunatorio.ResumeLayout(False)
        Me.grp_datos_vacunatorio.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_vacunatorio As System.Windows.Forms.GroupBox
    Friend WithEvents txt_referentes As System.Windows.Forms.TextBox
    Friend WithEvents cmb_estado_rm As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_pc As System.Windows.Forms.TextBox
    Friend WithEvents txt_heladera As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pc As System.Windows.Forms.Label
    Friend WithEvents lbl_heladera As System.Windows.Forms.Label
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar_cuie As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_efector As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_horarioDesde As System.Windows.Forms.TextBox
    Friend WithEvents txt_horarioHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrios As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
