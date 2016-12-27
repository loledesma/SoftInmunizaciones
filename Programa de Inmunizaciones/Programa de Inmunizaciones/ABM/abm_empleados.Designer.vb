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
        Me.txt_nro_documento = New System.Windows.Forms.TextBox()
        Me.cmd_buscar_x_apellido = New System.Windows.Forms.Button()
        Me.cmd_buscar_x_documento = New System.Windows.Forms.Button()
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
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.grp_datos_laborales = New System.Windows.Forms.GroupBox()
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
        Me.cmd_estadistica = New System.Windows.Forms.Button()
        Me.cmd_listados = New System.Windows.Forms.Button()
        Me.dgv_efectores = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_buscar_x_usuario = New System.Windows.Forms.Button()
        Me.grp_datos_sigipsa = New System.Windows.Forms.GroupBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.tltp_empleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.id_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perfil = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_cargo = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_efectores = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
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
        Me.grp_datos_personales.Controls.Add(Me.txt_nro_documento)
        Me.grp_datos_personales.Controls.Add(Me.cmb_tipo_doc)
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar_x_apellido)
        Me.grp_datos_personales.Controls.Add(Me.cmd_buscar_x_documento)
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
        Me.grp_datos_personales.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_personales.Name = "grp_datos_personales"
        Me.grp_datos_personales.Size = New System.Drawing.Size(419, 192)
        Me.grp_datos_personales.TabIndex = 2
        Me.grp_datos_personales.TabStop = False
        Me.grp_datos_personales.Text = "Datos Personales"
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nro_documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nro_documento.Location = New System.Drawing.Point(127, 80)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(170, 20)
        Me.txt_nro_documento.TabIndex = 32
        '
        'cmd_buscar_x_apellido
        '
        Me.cmd_buscar_x_apellido.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_apellido.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_apellido.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_apellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_apellido.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar_x_apellido.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_apellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_x_apellido.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_apellido.Location = New System.Drawing.Point(388, 130)
        Me.cmd_buscar_x_apellido.Name = "cmd_buscar_x_apellido"
        Me.cmd_buscar_x_apellido.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_apellido.TabIndex = 29
        Me.cmd_buscar_x_apellido.UseVisualStyleBackColor = False
        '
        'cmd_buscar_x_documento
        '
        Me.cmd_buscar_x_documento.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_documento.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_documento.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_documento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar_x_documento.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_documento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_x_documento.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_documento.Location = New System.Drawing.Point(303, 76)
        Me.cmd_buscar_x_documento.Name = "cmd_buscar_x_documento"
        Me.cmd_buscar_x_documento.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_documento.TabIndex = 28
        Me.cmd_buscar_x_documento.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "--"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(247, 159)
        Me.txt_telefono.Mask = "999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(135, 20)
        Me.txt_telefono.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = ")"
        '
        'txt_caracteristica
        '
        Me.txt_caracteristica.Location = New System.Drawing.Point(139, 159)
        Me.txt_caracteristica.Mask = "9999999"
        Me.txt_caracteristica.Name = "txt_caracteristica"
        Me.txt_caracteristica.Size = New System.Drawing.Size(67, 20)
        Me.txt_caracteristica.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "("
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(6, 163)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Telefono.TabIndex = 20
        Me.Telefono.Text = "Telefono"
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido.Location = New System.Drawing.Point(126, 133)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(256, 20)
        Me.txt_apellido.TabIndex = 19
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(6, 134)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellido.TabIndex = 18
        Me.lbl_apellido.Text = "Apellidos"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 110)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Nombres"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(126, 107)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(256, 20)
        Me.txt_nombre.TabIndex = 16
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(6, 81)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(82, 13)
        Me.lbl_documento.TabIndex = 14
        Me.lbl_documento.Text = "Nro Documento"
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(126, 22)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(136, 20)
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
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(1016, 507)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 32
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
        Me.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_limpiar.Location = New System.Drawing.Point(215, 507)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 31
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
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.Location = New System.Drawing.Point(79, 507)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 28
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
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.Location = New System.Drawing.Point(11, 507)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 30
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar.BackgroundImage = CType(resources.GetObject("cmd_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_eliminar.Location = New System.Drawing.Point(147, 507)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_eliminar.TabIndex = 29
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'grp_datos_laborales
        '
        Me.grp_datos_laborales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_laborales.Controls.Add(Me.cmd_limpiar_laboral)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_efector_nuevo)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_eliminar_efector)
        Me.grp_datos_laborales.Controls.Add(Me.cmd_agregar_efector)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_perfil)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_cargo)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_cargo)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_efectores)
        Me.grp_datos_laborales.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_laborales.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_laborales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_laborales.Location = New System.Drawing.Point(12, 320)
        Me.grp_datos_laborales.Name = "grp_datos_laborales"
        Me.grp_datos_laborales.Size = New System.Drawing.Size(419, 165)
        Me.grp_datos_laborales.TabIndex = 34
        Me.grp_datos_laborales.TabStop = False
        Me.grp_datos_laborales.Text = "Datos Laborales"
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
        Me.cmd_limpiar_laboral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_limpiar_laboral.Location = New System.Drawing.Point(317, 128)
        Me.cmd_limpiar_laboral.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_laboral.Name = "cmd_limpiar_laboral"
        Me.cmd_limpiar_laboral.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_laboral.TabIndex = 39
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
        Me.cmd_efector_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(353, 73)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_efector_nuevo.TabIndex = 41
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
        Me.cmd_eliminar_efector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_eliminar_efector.Location = New System.Drawing.Point(382, 128)
        Me.cmd_eliminar_efector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_efector.Name = "cmd_eliminar_efector"
        Me.cmd_eliminar_efector.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_efector.TabIndex = 39
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
        Me.cmd_agregar_efector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_agregar_efector.Location = New System.Drawing.Point(348, 128)
        Me.cmd_agregar_efector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_efector.Name = "cmd_agregar_efector"
        Me.cmd_agregar_efector.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_efector.TabIndex = 38
        Me.cmd_agregar_efector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_efector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_efector.UseVisualStyleBackColor = False
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(6, 133)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(30, 13)
        Me.lbl_perfil.TabIndex = 37
        Me.lbl_perfil.Text = "Perfil"
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Location = New System.Drawing.Point(6, 103)
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
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_empleado, Me.nombres, Me.apellidos, Me.id_tipo_doc, Me.tipo_doc, Me.nro_doc})
        Me.dgv_empleados.Location = New System.Drawing.Point(437, 18)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.Size = New System.Drawing.Size(639, 296)
        Me.dgv_empleados.TabIndex = 35
        '
        'cmd_estadistica
        '
        Me.cmd_estadistica.BackColor = System.Drawing.Color.Transparent
        Me.cmd_estadistica.BackgroundImage = CType(resources.GetObject("cmd_estadistica.BackgroundImage"), System.Drawing.Image)
        Me.cmd_estadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_estadistica.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_estadistica.FlatAppearance.BorderSize = 0
        Me.cmd_estadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_estadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_estadistica.Location = New System.Drawing.Point(611, 507)
        Me.cmd_estadistica.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_estadistica.Name = "cmd_estadistica"
        Me.cmd_estadistica.Size = New System.Drawing.Size(60, 60)
        Me.cmd_estadistica.TabIndex = 36
        Me.cmd_estadistica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_estadistica.UseVisualStyleBackColor = False
        '
        'cmd_listados
        '
        Me.cmd_listados.BackColor = System.Drawing.Color.Transparent
        Me.cmd_listados.BackgroundImage = CType(resources.GetObject("cmd_listados.BackgroundImage"), System.Drawing.Image)
        Me.cmd_listados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_listados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_listados.FlatAppearance.BorderSize = 0
        Me.cmd_listados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_listados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_listados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_listados.Location = New System.Drawing.Point(532, 507)
        Me.cmd_listados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_listados.Name = "cmd_listados"
        Me.cmd_listados.Size = New System.Drawing.Size(60, 60)
        Me.cmd_listados.TabIndex = 37
        Me.cmd_listados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_listados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_listados.UseVisualStyleBackColor = False
        '
        'dgv_efectores
        '
        Me.dgv_efectores.AllowUserToAddRows = False
        Me.dgv_efectores.AllowUserToDeleteRows = False
        Me.dgv_efectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_efectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.nombre_efector, Me.cargo, Me.perfil, Me.id_cargo, Me.id_perfil})
        Me.dgv_efectores.Location = New System.Drawing.Point(439, 326)
        Me.dgv_efectores.Name = "dgv_efectores"
        Me.dgv_efectores.ReadOnly = True
        Me.dgv_efectores.Size = New System.Drawing.Size(637, 159)
        Me.dgv_efectores.TabIndex = 38
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
        Me.txt_email.Location = New System.Drawing.Point(126, 19)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(257, 20)
        Me.txt_email.TabIndex = 30
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
        Me.txt_fecha.Location = New System.Drawing.Point(125, 68)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 30
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'cmd_buscar_x_usuario
        '
        Me.cmd_buscar_x_usuario.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_usuario.BackgroundImage = CType(resources.GetObject("cmd_buscar_x_usuario.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_x_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_x_usuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar_x_usuario.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_x_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_x_usuario.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_x_usuario.Location = New System.Drawing.Point(388, 44)
        Me.cmd_buscar_x_usuario.Name = "cmd_buscar_x_usuario"
        Me.cmd_buscar_x_usuario.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_x_usuario.TabIndex = 30
        Me.cmd_buscar_x_usuario.UseVisualStyleBackColor = False
        '
        'grp_datos_sigipsa
        '
        Me.grp_datos_sigipsa.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_sigipsa.Controls.Add(Me.cmd_buscar_x_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_fecha)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_fecha)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_usuario)
        Me.grp_datos_sigipsa.Controls.Add(Me.txt_email)
        Me.grp_datos_sigipsa.Controls.Add(Me.lbl_mail)
        Me.grp_datos_sigipsa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_sigipsa.Location = New System.Drawing.Point(12, 210)
        Me.grp_datos_sigipsa.Name = "grp_datos_sigipsa"
        Me.grp_datos_sigipsa.Size = New System.Drawing.Size(419, 104)
        Me.grp_datos_sigipsa.TabIndex = 30
        Me.grp_datos_sigipsa.TabStop = False
        Me.grp_datos_sigipsa.Text = "Datos Sigipsa"
        '
        'txt_usuario
        '
        Me.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_usuario.Location = New System.Drawing.Point(125, 45)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(257, 20)
        Me.txt_usuario.TabIndex = 31
        '
        'id_empleado
        '
        Me.id_empleado.HeaderText = "id"
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.ReadOnly = True
        Me.id_empleado.Width = 80
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
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(124, 22)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(216, 21)
        Me.cmb_departamentos.TabIndex = 42
        '
        'cmb_perfil
        '
        Me.cmb_perfil._descripcion = "descripcion"
        Me.cmb_perfil._nombre_tabla = "PERFILES_SIGIPSA"
        Me.cmb_perfil._pk = "id"
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Location = New System.Drawing.Point(124, 130)
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(139, 21)
        Me.cmb_perfil.TabIndex = 38
        '
        'cmb_cargo
        '
        Me.cmb_cargo._descripcion = "descripcion"
        Me.cmb_cargo._nombre_tabla = "CARGO"
        Me.cmb_cargo._pk = "id"
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(124, 101)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(139, 21)
        Me.cmb_cargo.TabIndex = 36
        '
        'cmb_efectores
        '
        Me.cmb_efectores._descripcion = "nombre"
        Me.cmb_efectores._nombre_tabla = "EFECTORES"
        Me.cmb_efectores._pk = "cuie"
        Me.cmb_efectores.FormattingEnabled = True
        Me.cmb_efectores.Location = New System.Drawing.Point(125, 75)
        Me.cmb_efectores.Name = "cmb_efectores"
        Me.cmb_efectores.Size = New System.Drawing.Size(217, 21)
        Me.cmb_efectores.TabIndex = 34
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(125, 49)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(216, 21)
        Me.cmb_localidades.TabIndex = 33
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc._descripcion = "descripcion"
        Me.cmb_tipo_doc._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_tipo_doc._pk = "id"
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(126, 49)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(137, 21)
        Me.cmb_tipo_doc.TabIndex = 30
        '
        'abm_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 581)
        Me.Controls.Add(Me.dgv_efectores)
        Me.Controls.Add(Me.cmd_listados)
        Me.Controls.Add(Me.cmd_estadistica)
        Me.Controls.Add(Me.dgv_empleados)
        Me.Controls.Add(Me.grp_datos_laborales)
        Me.Controls.Add(Me.grp_datos_sigipsa)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.grp_datos_personales)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
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
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_x_apellido As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_x_documento As System.Windows.Forms.Button
    Friend WithEvents grp_datos_laborales As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents cmb_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_estadistica As System.Windows.Forms.Button
    Friend WithEvents cmd_listados As System.Windows.Forms.Button
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
    Friend WithEvents cmd_buscar_x_usuario As System.Windows.Forms.Button
    Friend WithEvents grp_datos_sigipsa As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_efector As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents tltp_empleados As System.Windows.Forms.ToolTip
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents cmd_limpiar_laboral As System.Windows.Forms.Button
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
