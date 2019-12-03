<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_empleados))
        Me.grp_datos_personales = New System.Windows.Forms.GroupBox()
        Me.cmb_tieneCurso = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_añoCurso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_fecha_nac = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nro_documento = New System.Windows.Forms.TextBox()
        Me.cmd_buscar_x_documento = New System.Windows.Forms.Button()
        Me.cmd_buscar_x_apellido = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_caracteristica = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.grp_datos_laborales = New System.Windows.Forms.GroupBox()
        Me.txt_año_curso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_laboral = New System.Windows.Forms.Button()
        Me.cmd_efector_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar_efector = New System.Windows.Forms.Button()
        Me.cmd_agregar_efector = New System.Windows.Forms.Button()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.id_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_efectores = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.grp_datos_sigipsa = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar_x_usuario = New System.Windows.Forms.Button()
        Me.cmd_cambiar_estado = New System.Windows.Forms.Button()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.tltp_empleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_contador_empleados = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tltp_efectores = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_estado_empleado = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perfil = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_cargo = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_estados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tipo_doc = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.grp_datos_personales.SuspendLayout()
        Me.grp_datos_laborales.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_efectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_sigipsa.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos_personales
        '
        Me.grp_datos_personales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_personales.Controls.Add(Me.cmb_tieneCurso)
        Me.grp_datos_personales.Controls.Add(Me.Label8)
        Me.grp_datos_personales.Controls.Add(Me.txt_añoCurso)
        Me.grp_datos_personales.Controls.Add(Me.Label7)
        Me.grp_datos_personales.Controls.Add(Me.Label6)
        Me.grp_datos_personales.Controls.Add(Me.txt_fecha_nac)
        Me.grp_datos_personales.Controls.Add(Me.txt_nro_documento)
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar_x_documento)
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar_x_apellido)
        Me.grp_datos_personales.Controls.Add(Me.cmb_tipo_doc)
        Me.grp_datos_personales.Controls.Add(Me.Label4)
        Me.grp_datos_personales.Controls.Add(Me.txt_telefono)
        Me.grp_datos_personales.Controls.Add(Me.Label3)
        Me.grp_datos_personales.Controls.Add(Me.txt_caracteristica)
        Me.grp_datos_personales.Controls.Add(Me.Label2)
        Me.grp_datos_personales.Controls.Add(Me.Telefono)
        Me.grp_datos_personales.Controls.Add(Me.txt_apellido)
        Me.grp_datos_personales.Controls.Add(Me.lbl_apellido)
        Me.grp_datos_personales.Controls.Add(Me.lbl_nombre)
        Me.grp_datos_personales.Controls.Add(Me.txt_nombre)
        Me.grp_datos_personales.Controls.Add(Me.lbl_documento)
        Me.grp_datos_personales.Controls.Add(Me.txt_id_empleado)
        Me.grp_datos_personales.Controls.Add(Me.lbl_descripcion)
        Me.grp_datos_personales.Controls.Add(Me.lbl_empleado)
        Me.grp_datos_personales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_personales.Location = New System.Drawing.Point(11, 11)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Size = New System.Drawing.Size(494, 214)
        Me.grp_datos_personales.TabIndex = 0
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'cmb_tieneCurso
        '
        Me.cmb_tieneCurso.FormattingEnabled = True
        Me.cmb_tieneCurso.Items.AddRange(New Object() {"SI", "NO", "DESCONOCIDO"})
        Me.cmb_tieneCurso.Location = New System.Drawing.Point(168, 177)
        Me.cmb_tieneCurso.Name = "cmb_tieneCurso"
        Me.cmb_tieneCurso.Size = New System.Drawing.Size(99, 21)
        Me.cmb_tieneCurso.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Año"
        '
        'txt_añoCurso
        '
        Me.txt_añoCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_añoCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_añoCurso.Location = New System.Drawing.Point(295, 177)
        Me.txt_añoCurso.Name = "txt_añoCurso"
        Me.txt_añoCurso.Size = New System.Drawing.Size(84, 20)
        Me.txt_añoCurso.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "¿Tiene curso de vacunación?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'txt_fecha_nac
        '
        Me.txt_fecha_nac.Location = New System.Drawing.Point(170, 131)
        Me.txt_fecha_nac.Mask = "00/00/0000"
        Me.txt_fecha_nac.Name = "txt_fecha_nac"
        Me.txt_fecha_nac.Size = New System.Drawing.Size(171, 20)
        Me.txt_fecha_nac.TabIndex = 5
        Me.txt_fecha_nac.ValidatingType = GetType(Date)
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nro_documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nro_documento.Location = New System.Drawing.Point(327, 50)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(135, 20)
        Me.txt_nro_documento.TabIndex = 2
        '
        'cmd_buscar_x_documento
        '
        Me.cmd_buscar_x_documento.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_documento.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_documento.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_x_documento.Location = New System.Drawing.Point(463, 46)
        Me.cmd_buscar_x_documento.Name = "cmd_buscar_x_documento"
        Me.cmd_buscar_x_documento.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_documento.TabIndex = 1
        Me.cmd_buscar_x_documento.UseVisualStyleBackColor = True
        '
        'cmd_buscar_x_apellido
        '
        Me.cmd_buscar_x_apellido.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_apellido.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_apellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_apellido.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_apellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_x_apellido.Location = New System.Drawing.Point(463, 102)
        Me.cmd_buscar_x_apellido.Name = "cmd_buscar_x_apellido"
        Me.cmd_buscar_x_apellido.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_apellido.TabIndex = 6
        Me.cmd_buscar_x_apellido.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "--"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(295, 154)
        Me.txt_telefono.Mask = "999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(171, 20)
        Me.txt_telefono.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = ")"
        '
        'txt_caracteristica
        '
        Me.txt_caracteristica.Location = New System.Drawing.Point(170, 154)
        Me.txt_caracteristica.Mask = "9999999"
        Me.txt_caracteristica.Name = "txt_caracteristica"
        Me.txt_caracteristica.Size = New System.Drawing.Size(97, 20)
        Me.txt_caracteristica.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "("
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(4, 158)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Telefono.TabIndex = 20
        Me.Telefono.Text = "Telefono"
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido.Location = New System.Drawing.Point(170, 105)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(292, 20)
        Me.txt_apellido.TabIndex = 4
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(4, 106)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellido.TabIndex = 18
        Me.lbl_apellido.Text = "Apellidos"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(4, 82)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Nombres"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(170, 79)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(292, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(274, 53)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(47, 13)
        Me.lbl_documento.TabIndex = 5
        Me.lbl_documento.Text = "Nro Doc"
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(170, 22)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(53, 20)
        Me.txt_id_empleado.TabIndex = 0
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 52)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(101, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Tipo de Documento"
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(6, 25)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(16, 13)
        Me.lbl_empleado.TabIndex = 0
        Me.lbl_empleado.Text = "Id"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(1033, 665)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 3
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar.BackgroundImage = CType(resources.GetObject("cmd_limpiar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar.Location = New System.Drawing.Point(163, 662)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 2
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
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(95, 662)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 1
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
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(27, 662)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 0
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'grp_datos_laborales
        '
        Me.grp_datos_laborales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_laborales.Controls.Add(Me.txt_año_curso)
        Me.grp_datos_laborales.Controls.Add(Me.Label5)
        Me.grp_datos_laborales.Controls.Add(Me.txt_cuie)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_laborales.Controls.Add(Me.txt_efectores)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_estado_empleado)
        Me.grp_datos_laborales.Controls.Add(Me.Label1)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_limpiar_laboral)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_efector_nuevo)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_eliminar_efector)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_agregar_efector)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_perfil)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_cargo)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_cargo)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_laborales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_laborales.Location = New System.Drawing.Point(11, 362)
        Me.grp_datos_laborales.Name = "grp_datos_laborales"
        Me.grp_datos_laborales.Size = New System.Drawing.Size(491, 232)
        Me.grp_datos_laborales.TabIndex = 2
        Me.grp_datos_laborales.TabStop = False
        Me.grp_datos_laborales.Text = "Datos Laborales"
        '
        'txt_año_curso
        '
        Me.txt_año_curso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_año_curso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_año_curso.Location = New System.Drawing.Point(393, 159)
        Me.txt_año_curso.Name = "txt_año_curso"
        Me.txt_año_curso.Size = New System.Drawing.Size(87, 20)
        Me.txt_año_curso.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Año del Curso"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(168, 103)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(184, 20)
        Me.txt_cuie.TabIndex = 3
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(10, 103)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuie.TabIndex = 49
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(168, 75)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(282, 20)
        Me.txt_efectores.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Estado"
        '
        'cmd_limpiar_laboral
        '
        Me.cmd_limpiar_laboral.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_laboral.BackgroundImage = CType(resources.GetObject("cmd_limpiar_laboral.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_laboral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_laboral.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_laboral.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_laboral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_laboral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_laboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_laboral.Location = New System.Drawing.Point(392, 200)
        Me.cmd_limpiar_laboral.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_laboral.Name = "cmd_limpiar_laboral"
        Me.cmd_limpiar_laboral.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_laboral.TabIndex = 8
        Me.cmd_limpiar_laboral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_laboral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_laboral.UseVisualStyleBackColor = False
        '
        'cmd_efector_nuevo
        '
        Me.cmd_efector_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_efector_nuevo.BackgroundImage = CType(resources.GetObject("cmd_efector_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_efector_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_efector_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_efector_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_efector_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_efector_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_efector_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(457, 71)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_efector_nuevo.TabIndex = 3
        Me.cmd_efector_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_efector_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_efector_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_efector
        '
        Me.cmd_eliminar_efector.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_efector.BackgroundImage = CType(resources.GetObject("cmd_eliminar_efector.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_efector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_efector.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_efector.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_efector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_efector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_efector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_efector.Location = New System.Drawing.Point(457, 200)
        Me.cmd_eliminar_efector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_efector.Name = "cmd_eliminar_efector"
        Me.cmd_eliminar_efector.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_efector.TabIndex = 10
        Me.cmd_eliminar_efector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_efector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_efector.UseVisualStyleBackColor = False
        '
        'cmd_agregar_efector
        '
        Me.cmd_agregar_efector.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_efector.BackgroundImage = CType(resources.GetObject("cmd_agregar_efector.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_efector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_efector.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_efector.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_efector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_efector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_efector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_efector.Location = New System.Drawing.Point(424, 200)
        Me.cmd_agregar_efector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_efector.Name = "cmd_agregar_efector"
        Me.cmd_agregar_efector.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_efector.TabIndex = 9
        Me.cmd_agregar_efector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_efector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_efector.UseVisualStyleBackColor = False
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(10, 186)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(30, 13)
        Me.lbl_perfil.TabIndex = 37
        Me.lbl_perfil.Text = "Perfil"
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Location = New System.Drawing.Point(8, 131)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_cargo.TabIndex = 35
        Me.lbl_cargo.Text = "Cargo"
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(6, 77)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(64, 13)
        Me.lbl_vacunatorio.TabIndex = 32
        Me.lbl_vacunatorio.Text = "Vacunatorio"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(6, 51)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 31
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(6, 27)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_departamento.TabIndex = 30
        Me.lbl_departamento.Text = "Departamento"
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_empleado, Me.tipo_doc, Me.nro_doc, Me.nombres, Me.apellidos, Me.id_tipo_doc})
        Me.dgv_empleados.Location = New System.Drawing.Point(511, 16)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.Size = New System.Drawing.Size(605, 262)
        Me.dgv_empleados.TabIndex = 9
        '
        'id_empleado
        '
        Me.id_empleado.HeaderText = "id"
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.ReadOnly = True
        Me.id_empleado.Visible = False
        Me.id_empleado.Width = 80
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        '
        'nro_doc
        '
        Me.nro_doc.HeaderText = "Nro Documento"
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.ReadOnly = True
        Me.nro_doc.Width = 150
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 150
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellido"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 150
        '
        'id_tipo_doc
        '
        Me.id_tipo_doc.HeaderText = "Id_Tipo_Doc"
        Me.id_tipo_doc.Name = "id_tipo_doc"
        Me.id_tipo_doc.ReadOnly = True
        Me.id_tipo_doc.Visible = False
        Me.id_tipo_doc.Width = 50
        '
        'dgv_efectores
        '
        Me.dgv_efectores.AllowUserToAddRows = False
        Me.dgv_efectores.AllowUserToDeleteRows = False
        Me.dgv_efectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_efectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.nombre_efector, Me.cargo, Me.perfil, Me.estado_empleado, Me.año_curso, Me.id_cargo, Me.id_perfil, Me.id_estado})
        Me.dgv_efectores.Location = New System.Drawing.Point(511, 362)
        Me.dgv_efectores.Name = "dgv_efectores"
        Me.dgv_efectores.ReadOnly = True
        Me.dgv_efectores.Size = New System.Drawing.Size(605, 225)
        Me.dgv_efectores.TabIndex = 10
        '
        'cuie
        '
        Me.cuie.HeaderText = "Cuie"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        '
        'nombre_efector
        '
        Me.nombre_efector.HeaderText = "Vacunatorio"
        Me.nombre_efector.Name = "nombre_efector"
        Me.nombre_efector.ReadOnly = True
        Me.nombre_efector.Width = 200
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 140
        '
        'perfil
        '
        Me.perfil.HeaderText = "Perfil"
        Me.perfil.Name = "perfil"
        Me.perfil.ReadOnly = True
        Me.perfil.Width = 150
        '
        'estado_empleado
        '
        Me.estado_empleado.HeaderText = "Estado"
        Me.estado_empleado.Name = "estado_empleado"
        Me.estado_empleado.ReadOnly = True
        '
        'año_curso
        '
        Me.año_curso.HeaderText = "Año Curso"
        Me.año_curso.Name = "año_curso"
        Me.año_curso.ReadOnly = True
        Me.año_curso.Visible = False
        '
        'id_cargo
        '
        Me.id_cargo.HeaderText = "id_cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        '
        'id_perfil
        '
        Me.id_perfil.HeaderText = "id_perfil"
        Me.id_perfil.Name = "id_perfil"
        Me.id_perfil.ReadOnly = True
        Me.id_perfil.Visible = False
        '
        'id_estado
        '
        Me.id_estado.HeaderText = "id_estado"
        Me.id_estado.Name = "id_estado"
        Me.id_estado.ReadOnly = True
        Me.id_estado.Visible = False
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(6, 24)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(95, 13)
        Me.lbl_mail.TabIndex = 1
        Me.lbl_mail.Text = "E-mail de contacto"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(169, 21)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(257, 20)
        Me.txt_email.TabIndex = 0
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(6, 45)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(80, 13)
        Me.lbl_usuario.TabIndex = 32
        Me.lbl_usuario.Text = "Usuario Sigipsa"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(6, 68)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(58, 13)
        Me.lbl_fecha.TabIndex = 33
        Me.lbl_fecha.Text = "Fecha Alta"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(169, 65)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 2
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'grp_datos_sigipsa
        '
        Me.grp_datos_sigipsa.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_sigipsa.Controls.Add(Me.cmd_buscar_x_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.cmd_cambiar_estado)
        Me.grp_datos_sigipsa.Controls.Add(Me.cmb_estados)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_estado)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_fecha)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_fecha)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_email)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_mail)
        Me.grp_datos_sigipsa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_sigipsa.Location = New System.Drawing.Point(12, 231)
        Me.grp_datos_sigipsa.Name = "grp_datos_sigipsa"
        Me.grp_datos_sigipsa.Size = New System.Drawing.Size(490, 125)
        Me.grp_datos_sigipsa.TabIndex = 1
        Me.grp_datos_sigipsa.TabStop = False
        Me.grp_datos_sigipsa.Text = "Datos Sigipsa"
        '
        'cmd_buscar_x_usuario
        '
        Me.cmd_buscar_x_usuario.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_usuario.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_usuario.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_x_usuario.Location = New System.Drawing.Point(432, 42)
        Me.cmd_buscar_x_usuario.Name = "cmd_buscar_x_usuario"
        Me.cmd_buscar_x_usuario.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_usuario.TabIndex = 2
        Me.cmd_buscar_x_usuario.UseVisualStyleBackColor = True
        '
        'cmd_cambiar_estado
        '
        Me.cmd_cambiar_estado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_cambiar_estado.BackgroundImage = CType(resources.GetObject("cmd_cambiar_estado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_cambiar_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cambiar_estado.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_cambiar_estado.FlatAppearance.BorderSize = 0
        Me.cmd_cambiar_estado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_cambiar_estado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_cambiar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cambiar_estado.Location = New System.Drawing.Point(316, 91)
        Me.cmd_cambiar_estado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_cambiar_estado.Name = "cmd_cambiar_estado"
        Me.cmd_cambiar_estado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_cambiar_estado.TabIndex = 5
        Me.cmd_cambiar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cambiar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cambiar_estado.UseVisualStyleBackColor = False
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(7, 93)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_estado.TabIndex = 34
        Me.lbl_estado.Text = "Estado"
        '
        'txt_usuario
        '
        Me.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_usuario.Location = New System.Drawing.Point(169, 45)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(257, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'lbl_contador_empleados
        '
        Me.lbl_contador_empleados.AutoSize = True
        Me.lbl_contador_empleados.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_empleados.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_empleados.Location = New System.Drawing.Point(642, 290)
        Me.lbl_contador_empleados.Name = "lbl_contador_empleados"
        Me.lbl_contador_empleados.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_empleados.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(508, 290)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(179, 17)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Empleados registrados:"
        '
        'cmb_estado_empleado
        '
        Me.cmb_estado_empleado._descripcion = "descripcion"
        Me.cmb_estado_empleado._nombre_tabla = "ESTADOS_EMPLEADOS"
        Me.cmb_estado_empleado._pk = "id"
        Me.cmb_estado_empleado.FormattingEnabled = True
        Me.cmb_estado_empleado.Location = New System.Drawing.Point(170, 156)
        Me.cmb_estado_empleado.Name = "cmb_estado_empleado"
        Me.cmb_estado_empleado.Size = New System.Drawing.Size(139, 21)
        Me.cmb_estado_empleado.TabIndex = 5
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(168, 22)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(281, 21)
        Me.cmb_departamentos.TabIndex = 0
        '
        'cmb_perfil
        '
        Me.cmb_perfil._descripcion = "descripcion"
        Me.cmb_perfil._nombre_tabla = "PERFILES_SIGIPSA"
        Me.cmb_perfil._pk = "id"
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Location = New System.Drawing.Point(170, 183)
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(139, 21)
        Me.cmb_perfil.TabIndex = 7
        '
        'cmb_cargo
        '
        Me.cmb_cargo._descripcion = "descripcion"
        Me.cmb_cargo._nombre_tabla = "CARGO"
        Me.cmb_cargo._pk = "id"
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(168, 129)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(139, 21)
        Me.cmb_cargo.TabIndex = 4
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(168, 49)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(281, 21)
        Me.cmb_localidades.TabIndex = 1
        '
        'cmb_estados
        '
        Me.cmb_estados._descripcion = "descripcion"
        Me.cmb_estados._nombre_tabla = "ESTADOS_USUARIOS"
        Me.cmb_estados._pk = "id"
        Me.cmb_estados.FormattingEnabled = True
        Me.cmb_estados.Location = New System.Drawing.Point(169, 90)
        Me.cmb_estados.Name = "cmb_estados"
        Me.cmb_estados.Size = New System.Drawing.Size(139, 21)
        Me.cmb_estados.TabIndex = 3
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc._descripcion = "descripcion"
        Me.cmb_tipo_doc._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_tipo_doc._pk = "id"
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(170, 49)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(97, 21)
        Me.cmb_tipo_doc.TabIndex = 1
        '
        'abm_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1128, 737)
        Me.Controls.Add(Me.lbl_contador_empleados)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dgv_efectores)
        Me.Controls.Add(Me.dgv_empleados)
        Me.Controls.Add(Me.grp_datos_laborales)
        Me.Controls.Add(Me.grp_datos_sigipsa)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.grp_datos_personales)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.KeyPreview = True
        Me.Name = "abm_empleados"
        Me.Text = "abm_empleados"
        Me.grp_datos_personales.ResumeLayout(False)
        Me.grp_datos_personales.PerformLayout()
        Me.grp_datos_laborales.ResumeLayout(False)
        Me.grp_datos_laborales.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_efectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_sigipsa.ResumeLayout(False)
        Me.grp_datos_sigipsa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_datos_personales As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_caracteristica As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents grp_datos_laborales As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_agregar_efector As System.Windows.Forms.Button
    Friend WithEvents cmb_perfil As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents cmb_cargo As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_cargo As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_doc As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents dgv_efectores As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grp_datos_sigipsa As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents tltp_empleados As System.Windows.Forms.ToolTip
    Friend WithEvents cmd_limpiar_laboral As System.Windows.Forms.Button
    Friend WithEvents cmb_estados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents cmd_cambiar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_x_usuario As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_x_apellido As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_x_documento As System.Windows.Forms.Button
    Friend WithEvents cmb_estado_empleado As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar_efector As System.Windows.Forms.Button
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_empleados As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents txt_año_curso As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_nac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tltp_efectores As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tieneCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txt_añoCurso As System.Windows.Forms.TextBox
    Friend WithEvents id_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año_curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
