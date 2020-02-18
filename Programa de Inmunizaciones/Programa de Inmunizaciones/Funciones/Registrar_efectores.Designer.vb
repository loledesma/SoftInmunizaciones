<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_efectores
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_efectores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp_datos_vacunatorio = New System.Windows.Forms.GroupBox()
        Me.txt_correo_efector = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmb_notifica = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmd_cadena_de_frio = New System.Windows.Forms.Button()
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
        Me.grp_datos_empleados = New System.Windows.Forms.GroupBox()
        Me.txt_año_curso = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_perfil = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmd_actualizar_sigipsa = New System.Windows.Forms.Button()
        Me.cmb_cargo = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.txt_nombres_empleado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmd_buscar_empleadoXDNI = New System.Windows.Forms.Button()
        Me.cmb_estados_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_empleados = New System.Windows.Forms.Button()
        Me.cmd_eliminar_empleado = New System.Windows.Forms.Button()
        Me.cmd_agregar_empleado = New System.Windows.Forms.Button()
        Me.cmd_empleado_nuevo = New System.Windows.Forms.Button()
        Me.txt_numero_doc = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_tipos_documento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.tltp_efectores = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_vacunatorios = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_notificar = New System.Windows.Forms.Button()
        Me.cmd_atenciones = New System.Windows.Forms.Button()
        Me.lbl_contador_efectores = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmb_tipo_institucion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.grp_datos_vacunatorio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_datos_empleados.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_vacunatorio
        '
        Me.grp_datos_vacunatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipo_institucion)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label27)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_correo_efector)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label26)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_notifica)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label25)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_cadena_de_frio)
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
        Me.grp_datos_vacunatorio.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_vacunatorio.Name = "grp_datos_vacunatorio"
        Me.grp_datos_vacunatorio.Size = New System.Drawing.Size(671, 496)
        Me.grp_datos_vacunatorio.TabIndex = 0
        Me.grp_datos_vacunatorio.TabStop = False
        Me.grp_datos_vacunatorio.Text = "Datos del vacunatorio  "
        '
        'txt_correo_efector
        '
        Me.txt_correo_efector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_correo_efector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_correo_efector.Location = New System.Drawing.Point(170, 117)
        Me.txt_correo_efector.Name = "txt_correo_efector"
        Me.txt_correo_efector.Size = New System.Drawing.Size(445, 22)
        Me.txt_correo_efector.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 123)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(138, 16)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Correo del vacunatorio"
        '
        'cmb_notifica
        '
        Me.cmb_notifica._descripcion = "descripcion"
        Me.cmb_notifica._nombre_tabla = "TIPO_NOTIFICACION"
        Me.cmb_notifica._pk = "id"
        Me.cmb_notifica.FormattingEnabled = True
        Me.cmb_notifica.Location = New System.Drawing.Point(171, 299)
        Me.cmb_notifica.Name = "cmb_notifica"
        Me.cmb_notifica.Size = New System.Drawing.Size(115, 23)
        Me.cmb_notifica.TabIndex = 14
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 301)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 16)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Notifica"
        '
        'cmd_cadena_de_frio
        '
        Me.cmd_cadena_de_frio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cadena_de_frio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_cadena_de_frio.FlatAppearance.BorderSize = 0
        Me.cmd_cadena_de_frio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_cadena_de_frio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_cadena_de_frio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cadena_de_frio.Font = New System.Drawing.Font("Calibri", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.cmd_cadena_de_frio.Location = New System.Drawing.Point(128, 327)
        Me.cmd_cadena_de_frio.Name = "cmd_cadena_de_frio"
        Me.cmd_cadena_de_frio.Size = New System.Drawing.Size(335, 29)
        Me.cmd_cadena_de_frio.TabIndex = 15
        Me.cmd_cadena_de_frio.Text = "ACTUALIZAR INVENTARIO CADENA DE FRIO"
        Me.cmd_cadena_de_frio.UseVisualStyleBackColor = True
        '
        'txt_referentes
        '
        Me.txt_referentes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_referentes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_referentes.Location = New System.Drawing.Point(171, 182)
        Me.txt_referentes.Name = "txt_referentes"
        Me.txt_referentes.Size = New System.Drawing.Size(444, 22)
        Me.txt_referentes.TabIndex = 9
        '
        'cmb_estado_rm
        '
        Me.cmb_estado_rm._descripcion = "descripcion"
        Me.cmb_estado_rm._nombre_tabla = "ESTADO_RM"
        Me.cmb_estado_rm._pk = "id"
        Me.cmb_estado_rm.FormattingEnabled = True
        Me.cmb_estado_rm.Location = New System.Drawing.Point(441, 220)
        Me.cmb_estado_rm.Name = "cmb_estado_rm"
        Me.cmb_estado_rm.Size = New System.Drawing.Size(174, 23)
        Me.cmb_estado_rm.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(411, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "RM"
        '
        'txt_pc
        '
        Me.txt_pc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_pc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_pc.Location = New System.Drawing.Point(471, 152)
        Me.txt_pc.Name = "txt_pc"
        Me.txt_pc.Size = New System.Drawing.Size(144, 22)
        Me.txt_pc.TabIndex = 8
        '
        'txt_heladera
        '
        Me.txt_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_heladera.Location = New System.Drawing.Point(171, 149)
        Me.txt_heladera.Name = "txt_heladera"
        Me.txt_heladera.Size = New System.Drawing.Size(148, 22)
        Me.txt_heladera.TabIndex = 7
        '
        'lbl_pc
        '
        Me.lbl_pc.AutoSize = True
        Me.lbl_pc.Location = New System.Drawing.Point(396, 156)
        Me.lbl_pc.Name = "lbl_pc"
        Me.lbl_pc.Size = New System.Drawing.Size(50, 16)
        Me.lbl_pc.TabIndex = 20
        Me.lbl_pc.Text = "Internet"
        '
        'lbl_heladera
        '
        Me.lbl_heladera.AutoSize = True
        Me.lbl_heladera.Location = New System.Drawing.Point(15, 151)
        Me.lbl_heladera.Name = "lbl_heladera"
        Me.lbl_heladera.Size = New System.Drawing.Size(125, 16)
        Me.lbl_heladera.TabIndex = 19
        Me.lbl_heladera.Text = "PC en el Vacunatorio"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(171, 23)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(185, 22)
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
        Me.cmd_buscar_cuie.Location = New System.Drawing.Point(553, 18)
        Me.cmd_buscar_cuie.Name = "cmd_buscar_cuie"
        Me.cmd_buscar_cuie.Size = New System.Drawing.Size(72, 65)
        Me.cmd_buscar_cuie.TabIndex = 2
        Me.cmd_buscar_cuie.UseVisualStyleBackColor = True
        '
        'cmb_tipo_carga
        '
        Me.cmb_tipo_carga._descripcion = "descripcion"
        Me.cmb_tipo_carga._nombre_tabla = "TIPO_CARGA"
        Me.cmb_tipo_carga._pk = "id"
        Me.cmb_tipo_carga.FormattingEnabled = True
        Me.cmb_tipo_carga.Location = New System.Drawing.Point(441, 262)
        Me.cmb_tipo_carga.Name = "cmb_tipo_carga"
        Me.cmb_tipo_carga.Size = New System.Drawing.Size(174, 23)
        Me.cmb_tipo_carga.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(367, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Tipo carga"
        '
        'cmb_estado_efector
        '
        Me.cmb_estado_efector._descripcion = "descripcion"
        Me.cmb_estado_efector._nombre_tabla = "ESTADOS_EFECTOR"
        Me.cmb_estado_efector._pk = "id"
        Me.cmb_estado_efector.FormattingEnabled = True
        Me.cmb_estado_efector.Location = New System.Drawing.Point(171, 261)
        Me.cmb_estado_efector.Name = "cmb_estado_efector"
        Me.cmb_estado_efector.Size = New System.Drawing.Size(185, 23)
        Me.cmb_estado_efector.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Estado"
        '
        'cmb_tipos_efectores
        '
        Me.cmb_tipos_efectores._descripcion = "descripcion"
        Me.cmb_tipos_efectores._nombre_tabla = "TIPOS_EFECTORES"
        Me.cmb_tipos_efectores._pk = "id"
        Me.cmb_tipos_efectores.FormattingEnabled = True
        Me.cmb_tipos_efectores.Location = New System.Drawing.Point(171, 220)
        Me.cmb_tipos_efectores.Name = "cmb_tipos_efectores"
        Me.cmb_tipos_efectores.Size = New System.Drawing.Size(223, 23)
        Me.cmb_tipos_efectores.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tipo Efector"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Referente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(494, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "hasta"
        '
        'txt_horarioDesde
        '
        Me.txt_horarioDesde.Location = New System.Drawing.Point(419, 88)
        Me.txt_horarioDesde.Name = "txt_horarioDesde"
        Me.txt_horarioDesde.Size = New System.Drawing.Size(61, 22)
        Me.txt_horarioDesde.TabIndex = 4
        '
        'txt_horarioHasta
        '
        Me.txt_horarioHasta.Location = New System.Drawing.Point(547, 90)
        Me.txt_horarioHasta.Name = "txt_horarioHasta"
        Me.txt_horarioHasta.Size = New System.Drawing.Size(68, 22)
        Me.txt_horarioHasta.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(293, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Horario de atención"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(171, 90)
        Me.txt_telefono.Mask = "99999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(116, 22)
        Me.txt_telefono.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 122)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(126, 52)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(185, 23)
        Me.cmb_departamento.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Departamento"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(387, 52)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(184, 23)
        Me.cmb_localidades.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Localidad"
        '
        'cmb_barrios
        '
        Me.cmb_barrios._descripcion = "descripcion"
        Me.cmb_barrios._nombre_tabla = "BARRIOS"
        Me.cmb_barrios._pk = "id"
        Me.cmb_barrios.FormattingEnabled = True
        Me.cmb_barrios.Location = New System.Drawing.Point(126, 83)
        Me.cmb_barrios.Name = "cmb_barrios"
        Me.cmb_barrios.Size = New System.Drawing.Size(185, 23)
        Me.cmb_barrios.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(506, 22)
        Me.txt_numero.Mask = "99999999"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(65, 22)
        Me.txt_numero.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Barrio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(126, 22)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(320, 22)
        Me.txt_calle.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Calle"
        '
        'txt_nombre
        '
        Me.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre.Location = New System.Drawing.Point(171, 58)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(375, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIE"
        '
        'grp_datos_empleados
        '
        Me.grp_datos_empleados.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_empleados.Controls.Add(Me.txt_año_curso)
        Me.grp_datos_empleados.Controls.Add(Me.Label24)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_perfil)
        Me.grp_datos_empleados.Controls.Add(Me.Label23)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_actualizar_sigipsa)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_cargo)
        Me.grp_datos_empleados.Controls.Add(Me.lbl_cargo)
        Me.grp_datos_empleados.Controls.Add(Me.txt_nombres_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.Label21)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_buscar_empleadoXDNI)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_estados_empleados)
        Me.grp_datos_empleados.Controls.Add(Me.Label3)
        Me.grp_datos_empleados.Controls.Add(Me.txt_id_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.Label20)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_limpiar_empleados)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_eliminar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_agregar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_empleado_nuevo)
        Me.grp_datos_empleados.Controls.Add(Me.txt_numero_doc)
        Me.grp_datos_empleados.Controls.Add(Me.txt_apellido)
        Me.grp_datos_empleados.Controls.Add(Me.label16)
        Me.grp_datos_empleados.Controls.Add(Me.Label19)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_tipos_documento)
        Me.grp_datos_empleados.Controls.Add(Me.Label18)
        Me.grp_datos_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_empleados.Location = New System.Drawing.Point(5, 537)
        Me.grp_datos_empleados.Name = "grp_datos_empleados"
        Me.grp_datos_empleados.Size = New System.Drawing.Size(678, 252)
        Me.grp_datos_empleados.TabIndex = 1
        Me.grp_datos_empleados.TabStop = False
        Me.grp_datos_empleados.Text = "Datos del empleado"
        '
        'txt_año_curso
        '
        Me.txt_año_curso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_año_curso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_año_curso.Location = New System.Drawing.Point(395, 143)
        Me.txt_año_curso.Name = "txt_año_curso"
        Me.txt_año_curso.Size = New System.Drawing.Size(114, 22)
        Me.txt_año_curso.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(303, 147)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 16)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Año del Curso"
        '
        'cmb_perfil
        '
        Me.cmb_perfil._descripcion = "descripcion"
        Me.cmb_perfil._nombre_tabla = "PERFILES_SIGIPSA"
        Me.cmb_perfil._pk = "id"
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Location = New System.Drawing.Point(133, 180)
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(161, 23)
        Me.cmb_perfil.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 187)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 16)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Perfil"
        '
        'cmd_actualizar_sigipsa
        '
        Me.cmd_actualizar_sigipsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_actualizar_sigipsa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_actualizar_sigipsa.FlatAppearance.BorderSize = 0
        Me.cmd_actualizar_sigipsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_actualizar_sigipsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_actualizar_sigipsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actualizar_sigipsa.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_actualizar_sigipsa.Location = New System.Drawing.Point(154, 203)
        Me.cmd_actualizar_sigipsa.Name = "cmd_actualizar_sigipsa"
        Me.cmd_actualizar_sigipsa.Size = New System.Drawing.Size(257, 40)
        Me.cmd_actualizar_sigipsa.TabIndex = 11
        Me.cmd_actualizar_sigipsa.Text = "VER DATOS DEL EMPLEADO"
        Me.cmd_actualizar_sigipsa.UseVisualStyleBackColor = True
        '
        'cmb_cargo
        '
        Me.cmb_cargo._descripcion = "descripcion"
        Me.cmb_cargo._nombre_tabla = "CARGO"
        Me.cmb_cargo._pk = "id"
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(351, 180)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(160, 23)
        Me.cmb_cargo.TabIndex = 10
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Location = New System.Drawing.Point(303, 185)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(44, 16)
        Me.lbl_cargo.TabIndex = 32
        Me.lbl_cargo.Text = "Cargo"
        '
        'txt_nombres_empleado
        '
        Me.txt_nombres_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombres_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombres_empleado.Location = New System.Drawing.Point(133, 113)
        Me.txt_nombres_empleado.Name = "txt_nombres_empleado"
        Me.txt_nombres_empleado.Size = New System.Drawing.Size(378, 22)
        Me.txt_nombres_empleado.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 16)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Nombres"
        '
        'cmd_buscar_empleadoXDNI
        '
        Me.cmd_buscar_empleadoXDNI.BackgroundImage = CType(resources.GetObject("cmd_buscar_empleadoXDNI.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_empleadoXDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_empleadoXDNI.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_empleadoXDNI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleadoXDNI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleadoXDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_empleadoXDNI.Location = New System.Drawing.Point(516, 48)
        Me.cmd_buscar_empleadoXDNI.Name = "cmd_buscar_empleadoXDNI"
        Me.cmd_buscar_empleadoXDNI.Size = New System.Drawing.Size(29, 29)
        Me.cmd_buscar_empleadoXDNI.TabIndex = 3
        Me.cmd_buscar_empleadoXDNI.UseVisualStyleBackColor = True
        '
        'cmb_estados_empleados
        '
        Me.cmb_estados_empleados._descripcion = "descripcion"
        Me.cmb_estados_empleados._nombre_tabla = "ESTADOS_EMPLEADOS"
        Me.cmb_estados_empleados._pk = "id"
        Me.cmb_estados_empleados.FormattingEnabled = True
        Me.cmb_estados_empleados.Location = New System.Drawing.Point(133, 143)
        Me.cmb_estados_empleados.Name = "cmb_estados_empleados"
        Me.cmb_estados_empleados.Size = New System.Drawing.Size(153, 23)
        Me.cmb_estados_empleados.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Estado empleado"
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_empleado.Location = New System.Drawing.Point(133, 18)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(61, 22)
        Me.txt_id_empleado.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 16)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "ID"
        '
        'cmd_limpiar_empleados
        '
        Me.cmd_limpiar_empleados.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_empleados.BackgroundImage = CType(resources.GetObject("cmd_limpiar_empleados.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_empleados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_empleados.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_empleados.Location = New System.Drawing.Point(482, 215)
        Me.cmd_limpiar_empleados.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_limpiar_empleados.Name = "cmd_limpiar_empleados"
        Me.cmd_limpiar_empleados.Size = New System.Drawing.Size(29, 29)
        Me.cmd_limpiar_empleados.TabIndex = 13
        Me.cmd_limpiar_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_empleados.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_empleado
        '
        Me.cmd_eliminar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_empleado.BackgroundImage = CType(resources.GetObject("cmd_eliminar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_empleado.Location = New System.Drawing.Point(555, 215)
        Me.cmd_eliminar_empleado.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_eliminar_empleado.Name = "cmd_eliminar_empleado"
        Me.cmd_eliminar_empleado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_eliminar_empleado.TabIndex = 14
        Me.cmd_eliminar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_empleado.UseVisualStyleBackColor = False
        '
        'cmd_agregar_empleado
        '
        Me.cmd_agregar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_empleado.BackgroundImage = CType(resources.GetObject("cmd_agregar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_empleado.Location = New System.Drawing.Point(519, 215)
        Me.cmd_agregar_empleado.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_agregar_empleado.Name = "cmd_agregar_empleado"
        Me.cmd_agregar_empleado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_agregar_empleado.TabIndex = 12
        Me.cmd_agregar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_empleado.UseVisualStyleBackColor = False
        '
        'cmd_empleado_nuevo
        '
        Me.cmd_empleado_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.BackgroundImage = CType(resources.GetObject("cmd_empleado_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_empleado_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_empleado_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_empleado_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_empleado_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_empleado_nuevo.Location = New System.Drawing.Point(553, 48)
        Me.cmd_empleado_nuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_empleado_nuevo.Name = "cmd_empleado_nuevo"
        Me.cmd_empleado_nuevo.Size = New System.Drawing.Size(29, 29)
        Me.cmd_empleado_nuevo.TabIndex = 4
        Me.cmd_empleado_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_empleado_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_empleado_nuevo.UseVisualStyleBackColor = False
        '
        'txt_numero_doc
        '
        Me.txt_numero_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_numero_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_numero_doc.Location = New System.Drawing.Point(260, 50)
        Me.txt_numero_doc.Name = "txt_numero_doc"
        Me.txt_numero_doc.Size = New System.Drawing.Size(251, 22)
        Me.txt_numero_doc.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido.Location = New System.Drawing.Point(133, 81)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(378, 22)
        Me.txt_apellido.TabIndex = 5
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(20, 84)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(60, 16)
        Me.label16.TabIndex = 23
        Me.label16.Text = "Apellidos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(202, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Número"
        '
        'cmb_tipos_documento
        '
        Me.cmb_tipos_documento._descripcion = "descripcion"
        Me.cmb_tipos_documento._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_tipos_documento._pk = "id"
        Me.cmb_tipos_documento.FormattingEnabled = True
        Me.cmb_tipos_documento.Location = New System.Drawing.Point(133, 50)
        Me.cmb_tipos_documento.Name = "cmb_tipos_documento"
        Me.cmb_tipos_documento.Size = New System.Drawing.Size(61, 23)
        Me.cmb_tipos_documento.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Tipo Doc"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(1339, 795)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 69)
        Me.cmd_salir.TabIndex = 7
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar.BackgroundImage = CType(resources.GetObject("cmd_limpiar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar.Location = New System.Drawing.Point(175, 798)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_limpiar.TabIndex = 3
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.BackgroundImage = CType(resources.GetObject("cmd_guardar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_guardar.FlatAppearance.BorderSize = 0
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(96, 799)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_guardar.TabIndex = 2
        Me.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.BackgroundImage = CType(resources.GetObject("cmd_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(17, 799)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 69)
        Me.cmd_nuevo.TabIndex = 6
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_doc, Me.numero, Me.nombres, Me.apellidos, Me.cargo, Me.usuario, Me.perfil, Me.estado_empleado, Me.año_curso, Me.id_cargo, Me.id_perfil, Me.id_estado})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_empleados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_empleados.Location = New System.Drawing.Point(700, 442)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_empleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_empleados.Size = New System.Drawing.Size(709, 347)
        Me.dgv_empleados.TabIndex = 9
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Width = 30
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 75
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 180
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 180
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario Sigipsa"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 150
        '
        'perfil
        '
        Me.perfil.HeaderText = "Perfil Sigipsa"
        Me.perfil.Name = "perfil"
        Me.perfil.ReadOnly = True
        '
        'estado_empleado
        '
        Me.estado_empleado.HeaderText = "Estado Empleado"
        Me.estado_empleado.Name = "estado_empleado"
        Me.estado_empleado.ReadOnly = True
        '
        'año_curso
        '
        Me.año_curso.HeaderText = "Año Curso"
        Me.año_curso.Name = "año_curso"
        Me.año_curso.ReadOnly = True
        '
        'id_cargo
        '
        Me.id_cargo.HeaderText = "ID Cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        '
        'id_perfil
        '
        Me.id_perfil.HeaderText = "ID Perfil"
        Me.id_perfil.Name = "id_perfil"
        Me.id_perfil.ReadOnly = True
        Me.id_perfil.Visible = False
        '
        'id_estado
        '
        Me.id_estado.HeaderText = "ID Estado"
        Me.id_estado.Name = "id_estado"
        Me.id_estado.ReadOnly = True
        Me.id_estado.Visible = False
        '
        'dgv_vacunatorios
        '
        Me.dgv_vacunatorios.AllowUserToAddRows = False
        Me.dgv_vacunatorios.AllowUserToDeleteRows = False
        Me.dgv_vacunatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.nombre, Me.referente, Me.localidad})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_vacunatorios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_vacunatorios.Location = New System.Drawing.Point(700, 12)
        Me.dgv_vacunatorios.Name = "dgv_vacunatorios"
        Me.dgv_vacunatorios.ReadOnly = True
        Me.dgv_vacunatorios.Size = New System.Drawing.Size(709, 374)
        Me.dgv_vacunatorios.TabIndex = 8
        '
        'cuie
        '
        Me.cuie.HeaderText = "CUIE"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 225
        '
        'referente
        '
        Me.referente.HeaderText = "Referente"
        Me.referente.Name = "referente"
        Me.referente.ReadOnly = True
        Me.referente.Width = 225
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 165
        '
        'cmd_notificar
        '
        Me.cmd_notificar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_notificar.BackgroundImage = CType(resources.GetObject("cmd_notificar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_notificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_notificar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_notificar.FlatAppearance.BorderSize = 0
        Me.cmd_notificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_notificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_notificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_notificar.Location = New System.Drawing.Point(255, 798)
        Me.cmd_notificar.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_notificar.Name = "cmd_notificar"
        Me.cmd_notificar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_notificar.TabIndex = 4
        Me.cmd_notificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_notificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_notificar.UseVisualStyleBackColor = False
        '
        'cmd_atenciones
        '
        Me.cmd_atenciones.BackColor = System.Drawing.Color.Transparent
        Me.cmd_atenciones.BackgroundImage = CType(resources.GetObject("cmd_atenciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_atenciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_atenciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_atenciones.FlatAppearance.BorderSize = 0
        Me.cmd_atenciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_atenciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_atenciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_atenciones.Location = New System.Drawing.Point(340, 799)
        Me.cmd_atenciones.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_atenciones.Name = "cmd_atenciones"
        Me.cmd_atenciones.Size = New System.Drawing.Size(70, 69)
        Me.cmd_atenciones.TabIndex = 5
        Me.cmd_atenciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_atenciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_atenciones.UseVisualStyleBackColor = False
        '
        'lbl_contador_efectores
        '
        Me.lbl_contador_efectores.AutoSize = True
        Me.lbl_contador_efectores.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_efectores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_efectores.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_efectores.Location = New System.Drawing.Point(834, 411)
        Me.lbl_contador_efectores.Name = "lbl_contador_efectores"
        Me.lbl_contador_efectores.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_efectores.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(697, 411)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 16)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Efectores registrados:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(349, 305)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Tipo Institución"
        '
        'cmb_tipo_institucion
        '
        Me.cmb_tipo_institucion._descripcion = "descripcion"
        Me.cmb_tipo_institucion._nombre_tabla = "TIPO_INSTITUCION"
        Me.cmb_tipo_institucion._pk = "id"
        Me.cmb_tipo_institucion.FormattingEnabled = True
        Me.cmb_tipo_institucion.Location = New System.Drawing.Point(441, 302)
        Me.cmb_tipo_institucion.Name = "cmb_tipo_institucion"
        Me.cmb_tipo_institucion.Size = New System.Drawing.Size(174, 23)
        Me.cmb_tipo_institucion.TabIndex = 15
        '
        'Registrar_efectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1443, 578)
        Me.Controls.Add(Me.lbl_contador_efectores)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.grp_datos_vacunatorio)
        Me.Controls.Add(Me.cmd_atenciones)
        Me.Controls.Add(Me.cmd_notificar)
        Me.Controls.Add(Me.dgv_vacunatorios)
        Me.Controls.Add(Me.dgv_empleados)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_datos_empleados)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.KeyPreview = True
        Me.Name = "Registrar_efectores"
        Me.Text = "Registro de efectores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.grp_datos_vacunatorio.ResumeLayout(False)
        Me.grp_datos_vacunatorio.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp_datos_empleados.ResumeLayout(False)
        Me.grp_datos_empleados.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_datos_vacunatorio As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrios As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_horarioDesde As System.Windows.Forms.TextBox
    Friend WithEvents txt_horarioHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_efector As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_cuie As System.Windows.Forms.Button
    Friend WithEvents grp_datos_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_documento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_doc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_empleado_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar_empleados As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_empleado As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents cmb_estados_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_empleadoXDNI As System.Windows.Forms.Button
    Friend WithEvents txt_nombres_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_cargo As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_cargo As System.Windows.Forms.Label
    Friend WithEvents txt_pc As System.Windows.Forms.TextBox
    Friend WithEvents txt_heladera As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pc As System.Windows.Forms.Label
    Friend WithEvents lbl_heladera As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_rm As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents tltp_efectores As System.Windows.Forms.ToolTip
    Friend WithEvents txt_referentes As System.Windows.Forms.TextBox
    Friend WithEvents cmd_cadena_de_frio As System.Windows.Forms.Button
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_vacunatorios As System.Windows.Forms.DataGridView
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents referente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_notificar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmd_actualizar_sigipsa As System.Windows.Forms.Button
    Friend WithEvents cmb_perfil As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año_curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_año_curso As System.Windows.Forms.TextBox
    Friend WithEvents cmb_notifica As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmd_atenciones As System.Windows.Forms.Button
    Friend WithEvents txt_correo_efector As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_efectores As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_institucion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label27 As System.Windows.Forms.Label
End Class
