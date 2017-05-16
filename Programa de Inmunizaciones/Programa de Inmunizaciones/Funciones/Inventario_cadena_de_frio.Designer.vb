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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_cadena_de_frio))
        Me.grp_datos_vacunatorio = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_info = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmd_buscar_empleado = New System.Windows.Forms.Button()
        Me.cmb_departamento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_empleado_apellido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_empleado_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_heladera = New System.Windows.Forms.Label()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_tipos_efectores = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_efector = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Heladera = New System.Windows.Forms.TabPage()
        Me.dgv_heladeras = New System.Windows.Forms.DataGridView()
        Me.id_heladera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_heladera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_heladera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_heladera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.antiguedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcionamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_funcionamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones_heladera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_detalle = New System.Windows.Forms.GroupBox()
        Me.txt_antiguedad_heladera = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_fecha_heladera = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.txt_id_heladera = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_observaciones_heladera = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_motivo_heladera = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_funcionamiento_heladera = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_medidas_heladera = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_capacidad_heladra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_modelo_heladera = New System.Windows.Forms.TextBox()
        Me.txt_nro_serie_heladera = New System.Windows.Forms.TextBox()
        Me.cmb_marca_heladera = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_heladera = New System.Windows.Forms.Button()
        Me.cmd_eliminar_heladera = New System.Windows.Forms.Button()
        Me.cmd_agregar_heladera = New System.Windows.Forms.Button()
        Me.cmb_tipo_heladera = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_termos = New System.Windows.Forms.DataGridView()
        Me.id_termo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_termo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones_termo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_tipo_termo = New System.Windows.Forms.TextBox()
        Me.txt_fecha_termo = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_id_termos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_observaciones_termo = New System.Windows.Forms.RichTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_cantidad_termo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_termo = New System.Windows.Forms.Button()
        Me.cmd_eliminar_termo = New System.Windows.Forms.Button()
        Me.cmd_agregar_termo = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_termometros = New System.Windows.Forms.DataGridView()
        Me.id_termometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_termometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_termometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_termometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones_termometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_tipo_termometro = New System.Windows.Forms.TextBox()
        Me.txt_fecha_termometro = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_id_termometro = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_observaciones_termometro = New System.Windows.Forms.RichTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_cantidad_termometros = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_termometro = New System.Windows.Forms.Button()
        Me.cmd_eliminar_termometro = New System.Windows.Forms.Button()
        Me.cmd_agregar_termometro = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmd_efector_nuevo = New System.Windows.Forms.Button()
        Me.cmd_empleado_nuevo = New System.Windows.Forms.Button()
        Me.grp_datos_vacunatorio.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Heladera.SuspendLayout()
        CType(Me.dgv_heladeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_detalle.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_termos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_termometros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos_vacunatorio
        '
        Me.grp_datos_vacunatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_empleado_nuevo)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_efector_nuevo)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_fecha_info)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label26)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_buscar_empleado)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_departamento)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_empleado_apellido)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label8)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label7)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_empleado_nombre)
        Me.grp_datos_vacunatorio.Controls.Add(Me.lbl_heladera)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_cuie)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipos_efectores)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label13)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_efector)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label2)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label1)
        Me.grp_datos_vacunatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_vacunatorio.Location = New System.Drawing.Point(21, 5)
        Me.grp_datos_vacunatorio.Name = "grp_datos_vacunatorio"
        Me.grp_datos_vacunatorio.Size = New System.Drawing.Size(867, 153)
        Me.grp_datos_vacunatorio.TabIndex = 0
        Me.grp_datos_vacunatorio.TabStop = False
        Me.grp_datos_vacunatorio.Text = "Datos del vacunatorio  "
        '
        'txt_fecha_info
        '
        Me.txt_fecha_info.Location = New System.Drawing.Point(171, 127)
        Me.txt_fecha_info.Mask = "00/00/0000"
        Me.txt_fecha_info.Name = "txt_fecha_info"
        Me.txt_fecha_info.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_info.TabIndex = 9
        Me.txt_fecha_info.ValidatingType = GetType(Date)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 13)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Fecha Informacion"
        '
        'cmd_buscar_empleado
        '
        Me.cmd_buscar_empleado.BackgroundImage = CType(resources.GetObject("cmd_buscar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_empleado.Location = New System.Drawing.Point(640, 84)
        Me.cmd_buscar_empleado.Name = "cmd_buscar_empleado"
        Me.cmd_buscar_empleado.Size = New System.Drawing.Size(37, 36)
        Me.cmd_buscar_empleado.TabIndex = 8
        Me.cmd_buscar_empleado.UseVisualStyleBackColor = True
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(162, 38)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(277, 21)
        Me.cmb_departamento.TabIndex = 3
        '
        'txt_empleado_apellido
        '
        Me.txt_empleado_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_empleado_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_empleado_apellido.Location = New System.Drawing.Point(378, 94)
        Me.txt_empleado_apellido.Name = "txt_empleado_apellido"
        Me.txt_empleado_apellido.Size = New System.Drawing.Size(259, 20)
        Me.txt_empleado_apellido.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 44)
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
        Me.cmb_localidades.Location = New System.Drawing.Point(504, 39)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(278, 21)
        Me.cmb_localidades.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Localidad"
        '
        'txt_empleado_nombre
        '
        Me.txt_empleado_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_empleado_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_empleado_nombre.Location = New System.Drawing.Point(171, 95)
        Me.txt_empleado_nombre.Name = "txt_empleado_nombre"
        Me.txt_empleado_nombre.Size = New System.Drawing.Size(200, 20)
        Me.txt_empleado_nombre.TabIndex = 6
        '
        'lbl_heladera
        '
        Me.lbl_heladera.AutoSize = True
        Me.lbl_heladera.Location = New System.Drawing.Point(13, 96)
        Me.lbl_heladera.Name = "lbl_heladera"
        Me.lbl_heladera.Size = New System.Drawing.Size(153, 13)
        Me.lbl_heladera.TabIndex = 19
        Me.lbl_heladera.Text = "Responsable de la Informacion"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(640, 13)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(142, 20)
        Me.txt_cuie.TabIndex = 1
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackgroundImage = CType(resources.GetObject("cmd_buscar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar.FlatAppearance.BorderSize = 0
        Me.cmd_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar.Location = New System.Drawing.Point(794, 64)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(62, 56)
        Me.cmd_buscar.TabIndex = 0
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmb_tipos_efectores
        '
        Me.cmb_tipos_efectores._descripcion = "descripcion"
        Me.cmb_tipos_efectores._nombre_tabla = "TIPOS_EFECTORES"
        Me.cmb_tipos_efectores._pk = "id"
        Me.cmb_tipos_efectores.FormattingEnabled = True
        Me.cmb_tipos_efectores.Location = New System.Drawing.Point(162, 66)
        Me.cmb_tipos_efectores.Name = "cmb_tipos_efectores"
        Me.cmb_tipos_efectores.Size = New System.Drawing.Size(194, 21)
        Me.cmb_tipos_efectores.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tipo Efector"
        '
        'txt_efector
        '
        Me.txt_efector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efector.Location = New System.Drawing.Point(163, 12)
        Me.txt_efector.Name = "txt_efector"
        Me.txt_efector.Size = New System.Drawing.Size(434, 20)
        Me.txt_efector.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Efector"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(602, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIE"
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(163, 639)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 4
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
        Me.cmd_guardar.Location = New System.Drawing.Point(95, 639)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 3
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(27, 639)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 2
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(821, 649)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Heladera)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(24, 177)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(857, 455)
        Me.TabControl1.TabIndex = 0
        '
        'Heladera
        '
        Me.Heladera.BackgroundImage = CType(resources.GetObject("Heladera.BackgroundImage"), System.Drawing.Image)
        Me.Heladera.Controls.Add(Me.dgv_heladeras)
        Me.Heladera.Controls.Add(Me.grp_detalle)
        Me.Heladera.Location = New System.Drawing.Point(4, 22)
        Me.Heladera.Name = "Heladera"
        Me.Heladera.Padding = New System.Windows.Forms.Padding(3)
        Me.Heladera.Size = New System.Drawing.Size(849, 429)
        Me.Heladera.TabIndex = 1
        Me.Heladera.Text = "Heladera"
        Me.Heladera.UseVisualStyleBackColor = True
        '
        'dgv_heladeras
        '
        Me.dgv_heladeras.AllowUserToAddRows = False
        Me.dgv_heladeras.AllowUserToDeleteRows = False
        Me.dgv_heladeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_heladeras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_heladera, Me.nro_serie, Me.tipo_heladera, Me.id_tipo_heladera, Me.marca, Me.id_marca, Me.modelo, Me.capacidad, Me.medidas, Me.fecha_heladera, Me.antiguedad, Me.funcionamiento, Me.id_funcionamiento, Me.motivo, Me.observaciones_heladera, Me.fecha_info})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_heladeras.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_heladeras.Location = New System.Drawing.Point(14, 246)
        Me.dgv_heladeras.Name = "dgv_heladeras"
        Me.dgv_heladeras.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgv_heladeras.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_heladeras.Size = New System.Drawing.Size(818, 160)
        Me.dgv_heladeras.TabIndex = 7
        '
        'id_heladera
        '
        Me.id_heladera.HeaderText = "Id"
        Me.id_heladera.Name = "id_heladera"
        Me.id_heladera.ReadOnly = True
        Me.id_heladera.Visible = False
        Me.id_heladera.Width = 200
        '
        'nro_serie
        '
        Me.nro_serie.HeaderText = "Numero de Serie"
        Me.nro_serie.Name = "nro_serie"
        Me.nro_serie.ReadOnly = True
        Me.nro_serie.Width = 150
        '
        'tipo_heladera
        '
        Me.tipo_heladera.FillWeight = 200.0!
        Me.tipo_heladera.HeaderText = "Tipo Heladera"
        Me.tipo_heladera.Name = "tipo_heladera"
        Me.tipo_heladera.ReadOnly = True
        Me.tipo_heladera.Width = 200
        '
        'id_tipo_heladera
        '
        Me.id_tipo_heladera.HeaderText = "id_tipo_heladera"
        Me.id_tipo_heladera.Name = "id_tipo_heladera"
        Me.id_tipo_heladera.ReadOnly = True
        Me.id_tipo_heladera.Visible = False
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'id_marca
        '
        Me.id_marca.HeaderText = "id_marca"
        Me.id_marca.Name = "id_marca"
        Me.id_marca.ReadOnly = True
        Me.id_marca.Visible = False
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'capacidad
        '
        Me.capacidad.HeaderText = "capacidad"
        Me.capacidad.Name = "capacidad"
        Me.capacidad.ReadOnly = True
        Me.capacidad.Visible = False
        '
        'medidas
        '
        Me.medidas.HeaderText = "medidas"
        Me.medidas.Name = "medidas"
        Me.medidas.ReadOnly = True
        Me.medidas.Visible = False
        '
        'fecha_heladera
        '
        Me.fecha_heladera.HeaderText = "fecha_heladera"
        Me.fecha_heladera.Name = "fecha_heladera"
        Me.fecha_heladera.ReadOnly = True
        Me.fecha_heladera.Visible = False
        '
        'antiguedad
        '
        Me.antiguedad.HeaderText = "Antiguedad"
        Me.antiguedad.Name = "antiguedad"
        Me.antiguedad.ReadOnly = True
        '
        'funcionamiento
        '
        Me.funcionamiento.HeaderText = "Funcionamiento"
        Me.funcionamiento.Name = "funcionamiento"
        Me.funcionamiento.ReadOnly = True
        Me.funcionamiento.Width = 200
        '
        'id_funcionamiento
        '
        Me.id_funcionamiento.HeaderText = "id_funcionamiento"
        Me.id_funcionamiento.Name = "id_funcionamiento"
        Me.id_funcionamiento.ReadOnly = True
        Me.id_funcionamiento.Visible = False
        '
        'motivo
        '
        Me.motivo.HeaderText = "motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.ReadOnly = True
        Me.motivo.Visible = False
        '
        'observaciones_heladera
        '
        Me.observaciones_heladera.HeaderText = "observaciones"
        Me.observaciones_heladera.Name = "observaciones_heladera"
        Me.observaciones_heladera.ReadOnly = True
        Me.observaciones_heladera.Visible = False
        '
        'fecha_info
        '
        Me.fecha_info.HeaderText = "fecha_info"
        Me.fecha_info.Name = "fecha_info"
        Me.fecha_info.ReadOnly = True
        Me.fecha_info.Visible = False
        '
        'grp_detalle
        '
        Me.grp_detalle.BackColor = System.Drawing.Color.Transparent
        Me.grp_detalle.Controls.Add(Me.txt_antiguedad_heladera)
        Me.grp_detalle.Controls.Add(Me.Label16)
        Me.grp_detalle.Controls.Add(Me.txt_fecha_heladera)
        Me.grp_detalle.Controls.Add(Me.lbl_perfil)
        Me.grp_detalle.Controls.Add(Me.txt_id_heladera)
        Me.grp_detalle.Controls.Add(Me.Label15)
        Me.grp_detalle.Controls.Add(Me.txt_observaciones_heladera)
        Me.grp_detalle.Controls.Add(Me.Label14)
        Me.grp_detalle.Controls.Add(Me.txt_motivo_heladera)
        Me.grp_detalle.Controls.Add(Me.Label12)
        Me.grp_detalle.Controls.Add(Me.cmb_funcionamiento_heladera)
        Me.grp_detalle.Controls.Add(Me.Label6)
        Me.grp_detalle.Controls.Add(Me.txt_medidas_heladera)
        Me.grp_detalle.Controls.Add(Me.Label5)
        Me.grp_detalle.Controls.Add(Me.txt_capacidad_heladra)
        Me.grp_detalle.Controls.Add(Me.Label3)
        Me.grp_detalle.Controls.Add(Me.txt_modelo_heladera)
        Me.grp_detalle.Controls.Add(Me.txt_nro_serie_heladera)
        Me.grp_detalle.Controls.Add(Me.cmb_marca_heladera)
        Me.grp_detalle.Controls.Add(Me.Label11)
        Me.grp_detalle.Controls.Add(Me.Label10)
        Me.grp_detalle.Controls.Add(Me.Label9)
        Me.grp_detalle.Controls.Add(Me.cmd_limpiar_heladera)
        Me.grp_detalle.Controls.Add(Me.cmd_eliminar_heladera)
        Me.grp_detalle.Controls.Add(Me.cmd_agregar_heladera)
        Me.grp_detalle.Controls.Add(Me.cmb_tipo_heladera)
        Me.grp_detalle.Controls.Add(Me.Label4)
        Me.grp_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_detalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_detalle.Location = New System.Drawing.Point(10, 10)
        Me.grp_detalle.Name = "grp_detalle"
        Me.grp_detalle.Size = New System.Drawing.Size(822, 217)
        Me.grp_detalle.TabIndex = 0
        Me.grp_detalle.TabStop = False
        Me.grp_detalle.Text = "Inventario Cadena de Frio Heladera"
        '
        'txt_antiguedad_heladera
        '
        Me.txt_antiguedad_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_antiguedad_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_antiguedad_heladera.Location = New System.Drawing.Point(669, 82)
        Me.txt_antiguedad_heladera.Name = "txt_antiguedad_heladera"
        Me.txt_antiguedad_heladera.Size = New System.Drawing.Size(139, 20)
        Me.txt_antiguedad_heladera.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(568, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Antiguedad en años"
        '
        'txt_fecha_heladera
        '
        Me.txt_fecha_heladera.Location = New System.Drawing.Point(454, 84)
        Me.txt_fecha_heladera.Mask = "00/00/0000"
        Me.txt_fecha_heladera.Name = "txt_fecha_heladera"
        Me.txt_fecha_heladera.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_heladera.TabIndex = 7
        Me.txt_fecha_heladera.ValidatingType = GetType(Date)
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(355, 86)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(92, 13)
        Me.lbl_perfil.TabIndex = 53
        Me.lbl_perfil.Text = "Fecha Recepcion"
        '
        'txt_id_heladera
        '
        Me.txt_id_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_heladera.Location = New System.Drawing.Point(33, 18)
        Me.txt_id_heladera.Name = "txt_id_heladera"
        Me.txt_id_heladera.Size = New System.Drawing.Size(44, 20)
        Me.txt_id_heladera.TabIndex = 72
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 13)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Id"
        '
        'txt_observaciones_heladera
        '
        Me.txt_observaciones_heladera.Location = New System.Drawing.Point(454, 110)
        Me.txt_observaciones_heladera.Name = "txt_observaciones_heladera"
        Me.txt_observaciones_heladera.Size = New System.Drawing.Size(193, 97)
        Me.txt_observaciones_heladera.TabIndex = 10
        Me.txt_observaciones_heladera.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(369, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Observaciones"
        '
        'txt_motivo_heladera
        '
        Me.txt_motivo_heladera.Location = New System.Drawing.Point(99, 109)
        Me.txt_motivo_heladera.Name = "txt_motivo_heladera"
        Me.txt_motivo_heladera.Size = New System.Drawing.Size(193, 97)
        Me.txt_motivo_heladera.TabIndex = 9
        Me.txt_motivo_heladera.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Motivo"
        '
        'cmb_funcionamiento_heladera
        '
        Me.cmb_funcionamiento_heladera._descripcion = "descripcion"
        Me.cmb_funcionamiento_heladera._nombre_tabla = "FUNCIONAMIENTO"
        Me.cmb_funcionamiento_heladera._pk = "id"
        Me.cmb_funcionamiento_heladera.FormattingEnabled = True
        Me.cmb_funcionamiento_heladera.Location = New System.Drawing.Point(99, 82)
        Me.cmb_funcionamiento_heladera.Name = "cmb_funcionamiento_heladera"
        Me.cmb_funcionamiento_heladera.Size = New System.Drawing.Size(160, 21)
        Me.cmb_funcionamiento_heladera.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Funcionamiento"
        '
        'txt_medidas_heladera
        '
        Me.txt_medidas_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_medidas_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_medidas_heladera.Location = New System.Drawing.Point(668, 51)
        Me.txt_medidas_heladera.Name = "txt_medidas_heladera"
        Me.txt_medidas_heladera.Size = New System.Drawing.Size(139, 20)
        Me.txt_medidas_heladera.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(604, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Medidas"
        '
        'txt_capacidad_heladra
        '
        Me.txt_capacidad_heladra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_capacidad_heladra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_capacidad_heladra.Location = New System.Drawing.Point(453, 52)
        Me.txt_capacidad_heladra.Name = "txt_capacidad_heladra"
        Me.txt_capacidad_heladra.Size = New System.Drawing.Size(139, 20)
        Me.txt_capacidad_heladra.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Capacidad"
        '
        'txt_modelo_heladera
        '
        Me.txt_modelo_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_modelo_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_modelo_heladera.Location = New System.Drawing.Point(667, 20)
        Me.txt_modelo_heladera.Name = "txt_modelo_heladera"
        Me.txt_modelo_heladera.Size = New System.Drawing.Size(139, 20)
        Me.txt_modelo_heladera.TabIndex = 2
        '
        'txt_nro_serie_heladera
        '
        Me.txt_nro_serie_heladera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nro_serie_heladera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nro_serie_heladera.Location = New System.Drawing.Point(99, 52)
        Me.txt_nro_serie_heladera.Name = "txt_nro_serie_heladera"
        Me.txt_nro_serie_heladera.Size = New System.Drawing.Size(283, 20)
        Me.txt_nro_serie_heladera.TabIndex = 3
        '
        'cmb_marca_heladera
        '
        Me.cmb_marca_heladera._descripcion = "descripcion"
        Me.cmb_marca_heladera._nombre_tabla = "MARCA"
        Me.cmb_marca_heladera._pk = "id"
        Me.cmb_marca_heladera.FormattingEnabled = True
        Me.cmb_marca_heladera.Location = New System.Drawing.Point(453, 18)
        Me.cmb_marca_heladera.Name = "cmb_marca_heladera"
        Me.cmb_marca_heladera.Size = New System.Drawing.Size(140, 21)
        Me.cmb_marca_heladera.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(390, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Marca"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(603, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Nro de Serie"
        '
        'cmd_limpiar_heladera
        '
        Me.cmd_limpiar_heladera.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_heladera.BackgroundImage = CType(resources.GetObject("cmd_limpiar_heladera.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_heladera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_heladera.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_heladera.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_heladera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_heladera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_heladera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_heladera.Location = New System.Drawing.Point(714, 181)
        Me.cmd_limpiar_heladera.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_heladera.Name = "cmd_limpiar_heladera"
        Me.cmd_limpiar_heladera.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_heladera.TabIndex = 11
        Me.cmd_limpiar_heladera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_heladera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_heladera.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_heladera
        '
        Me.cmd_eliminar_heladera.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_heladera.BackgroundImage = CType(resources.GetObject("cmd_eliminar_heladera.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_heladera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_heladera.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_heladera.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_heladera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_heladera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_heladera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_heladera.Location = New System.Drawing.Point(777, 181)
        Me.cmd_eliminar_heladera.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_heladera.Name = "cmd_eliminar_heladera"
        Me.cmd_eliminar_heladera.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_heladera.TabIndex = 13
        Me.cmd_eliminar_heladera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_heladera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_heladera.UseVisualStyleBackColor = False
        '
        'cmd_agregar_heladera
        '
        Me.cmd_agregar_heladera.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_heladera.BackgroundImage = CType(resources.GetObject("cmd_agregar_heladera.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_heladera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_heladera.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_heladera.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_heladera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_heladera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_heladera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_heladera.Location = New System.Drawing.Point(746, 181)
        Me.cmd_agregar_heladera.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_heladera.Name = "cmd_agregar_heladera"
        Me.cmd_agregar_heladera.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_heladera.TabIndex = 12
        Me.cmd_agregar_heladera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_heladera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_heladera.UseVisualStyleBackColor = False
        '
        'cmb_tipo_heladera
        '
        Me.cmb_tipo_heladera._descripcion = "descripcion"
        Me.cmb_tipo_heladera._nombre_tabla = "TIPO_HELADERA"
        Me.cmb_tipo_heladera._pk = "id"
        Me.cmb_tipo_heladera.FormattingEnabled = True
        Me.cmb_tipo_heladera.Location = New System.Drawing.Point(135, 19)
        Me.cmb_tipo_heladera.Name = "cmb_tipo_heladera"
        Me.cmb_tipo_heladera.Size = New System.Drawing.Size(247, 21)
        Me.cmb_tipo_heladera.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Tipo"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.dgv_termos)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 429)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Termos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_termos
        '
        Me.dgv_termos.AllowUserToAddRows = False
        Me.dgv_termos.AllowUserToDeleteRows = False
        Me.dgv_termos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_termos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_termo, Me.fecha, Me.cantidad, Me.tipo_termo, Me.observaciones_termo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_termos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_termos.Location = New System.Drawing.Point(17, 252)
        Me.dgv_termos.Name = "dgv_termos"
        Me.dgv_termos.ReadOnly = True
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgv_termos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_termos.Size = New System.Drawing.Size(818, 160)
        Me.dgv_termos.TabIndex = 9
        '
        'id_termo
        '
        Me.id_termo.HeaderText = "Id"
        Me.id_termo.Name = "id_termo"
        Me.id_termo.ReadOnly = True
        Me.id_termo.Visible = False
        Me.id_termo.Width = 200
        '
        'fecha
        '
        Me.fecha.FillWeight = 200.0!
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 250
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'tipo_termo
        '
        Me.tipo_termo.HeaderText = "Tipo Termo"
        Me.tipo_termo.Name = "tipo_termo"
        Me.tipo_termo.ReadOnly = True
        Me.tipo_termo.Width = 150
        '
        'observaciones_termo
        '
        Me.observaciones_termo.HeaderText = "Observaciones"
        Me.observaciones_termo.Name = "observaciones_termo"
        Me.observaciones_termo.ReadOnly = True
        Me.observaciones_termo.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_tipo_termo)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_termo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_id_termos)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones_termo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad_termo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar_termo)
        Me.GroupBox1.Controls.Add(Me.cmd_eliminar_termo)
        Me.GroupBox1.Controls.Add(Me.cmd_agregar_termo)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 217)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventario Cadena de Frio Termos"
        '
        'txt_tipo_termo
        '
        Me.txt_tipo_termo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_tipo_termo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_tipo_termo.Location = New System.Drawing.Point(72, 52)
        Me.txt_tipo_termo.Name = "txt_tipo_termo"
        Me.txt_tipo_termo.Size = New System.Drawing.Size(139, 20)
        Me.txt_tipo_termo.TabIndex = 1
        '
        'txt_fecha_termo
        '
        Me.txt_fecha_termo.Location = New System.Drawing.Point(330, 82)
        Me.txt_fecha_termo.Mask = "00/00/0000"
        Me.txt_fecha_termo.Name = "txt_fecha_termo"
        Me.txt_fecha_termo.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_termo.TabIndex = 3
        Me.txt_fecha_termo.ValidatingType = GetType(Date)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(231, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Fecha Recepcion"
        '
        'txt_id_termos
        '
        Me.txt_id_termos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_termos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_termos.Location = New System.Drawing.Point(71, 22)
        Me.txt_id_termos.Name = "txt_id_termos"
        Me.txt_id_termos.Size = New System.Drawing.Size(44, 20)
        Me.txt_id_termos.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 13)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Id"
        '
        'txt_observaciones_termo
        '
        Me.txt_observaciones_termo.Location = New System.Drawing.Point(96, 114)
        Me.txt_observaciones_termo.Name = "txt_observaciones_termo"
        Me.txt_observaciones_termo.Size = New System.Drawing.Size(331, 97)
        Me.txt_observaciones_termo.TabIndex = 4
        Me.txt_observaciones_termo.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 121)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Observaciones"
        '
        'txt_cantidad_termo
        '
        Me.txt_cantidad_termo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cantidad_termo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cantidad_termo.Location = New System.Drawing.Point(72, 82)
        Me.txt_cantidad_termo.Name = "txt_cantidad_termo"
        Me.txt_cantidad_termo.Size = New System.Drawing.Size(139, 20)
        Me.txt_cantidad_termo.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 87)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "Cantidad"
        '
        'cmd_limpiar_termo
        '
        Me.cmd_limpiar_termo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_termo.BackgroundImage = CType(resources.GetObject("cmd_limpiar_termo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_termo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_termo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_termo.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_termo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_termo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_termo.Location = New System.Drawing.Point(458, 185)
        Me.cmd_limpiar_termo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_termo.Name = "cmd_limpiar_termo"
        Me.cmd_limpiar_termo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_termo.TabIndex = 5
        Me.cmd_limpiar_termo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_termo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_termo.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_termo
        '
        Me.cmd_eliminar_termo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_termo.BackgroundImage = CType(resources.GetObject("cmd_eliminar_termo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_termo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_termo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_termo.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_termo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_termo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_termo.Location = New System.Drawing.Point(521, 185)
        Me.cmd_eliminar_termo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_termo.Name = "cmd_eliminar_termo"
        Me.cmd_eliminar_termo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_termo.TabIndex = 7
        Me.cmd_eliminar_termo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_termo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_termo.UseVisualStyleBackColor = False
        '
        'cmd_agregar_termo
        '
        Me.cmd_agregar_termo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_termo.BackgroundImage = CType(resources.GetObject("cmd_agregar_termo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_termo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_termo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_termo.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_termo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_termo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_termo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_termo.Location = New System.Drawing.Point(490, 185)
        Me.cmd_agregar_termo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_termo.Name = "cmd_agregar_termo"
        Me.cmd_agregar_termo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_termo.TabIndex = 6
        Me.cmd_agregar_termo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_termo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_termo.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 13)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Tipo/Marca"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.dgv_termometros)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(849, 429)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Termometro"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_termometros
        '
        Me.dgv_termometros.AllowUserToAddRows = False
        Me.dgv_termometros.AllowUserToDeleteRows = False
        Me.dgv_termometros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_termometros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_termometro, Me.fecha_termometro, Me.tipo_termometro, Me.cantidad_termometro, Me.observaciones_termometro})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_termometros.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_termometros.Location = New System.Drawing.Point(19, 252)
        Me.dgv_termometros.Name = "dgv_termometros"
        Me.dgv_termometros.ReadOnly = True
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgv_termometros.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_termometros.Size = New System.Drawing.Size(818, 160)
        Me.dgv_termometros.TabIndex = 11
        '
        'id_termometro
        '
        Me.id_termometro.HeaderText = "Id"
        Me.id_termometro.Name = "id_termometro"
        Me.id_termometro.ReadOnly = True
        Me.id_termometro.Visible = False
        Me.id_termometro.Width = 200
        '
        'fecha_termometro
        '
        Me.fecha_termometro.FillWeight = 200.0!
        Me.fecha_termometro.HeaderText = "Fecha"
        Me.fecha_termometro.Name = "fecha_termometro"
        Me.fecha_termometro.ReadOnly = True
        '
        'tipo_termometro
        '
        Me.tipo_termometro.HeaderText = "Tipo Termometro"
        Me.tipo_termometro.Name = "tipo_termometro"
        Me.tipo_termometro.ReadOnly = True
        Me.tipo_termometro.Width = 200
        '
        'cantidad_termometro
        '
        Me.cantidad_termometro.HeaderText = "Cantidad"
        Me.cantidad_termometro.Name = "cantidad_termometro"
        Me.cantidad_termometro.ReadOnly = True
        '
        'observaciones_termometro
        '
        Me.observaciones_termometro.HeaderText = "Observaciones"
        Me.observaciones_termometro.Name = "observaciones_termometro"
        Me.observaciones_termometro.ReadOnly = True
        Me.observaciones_termometro.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_tipo_termometro)
        Me.GroupBox2.Controls.Add(Me.txt_fecha_termometro)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_id_termometro)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txt_observaciones_termometro)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad_termometros)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cmd_limpiar_termometro)
        Me.GroupBox2.Controls.Add(Me.cmd_eliminar_termometro)
        Me.GroupBox2.Controls.Add(Me.cmd_agregar_termometro)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 217)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventario Cadena de Frio Termometro"
        '
        'txt_tipo_termometro
        '
        Me.txt_tipo_termometro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_tipo_termometro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_tipo_termometro.Location = New System.Drawing.Point(72, 52)
        Me.txt_tipo_termometro.Name = "txt_tipo_termometro"
        Me.txt_tipo_termometro.Size = New System.Drawing.Size(139, 20)
        Me.txt_tipo_termometro.TabIndex = 1
        '
        'txt_fecha_termometro
        '
        Me.txt_fecha_termometro.Location = New System.Drawing.Point(330, 82)
        Me.txt_fecha_termometro.Mask = "00/00/0000"
        Me.txt_fecha_termometro.Name = "txt_fecha_termometro"
        Me.txt_fecha_termometro.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_termometro.TabIndex = 3
        Me.txt_fecha_termometro.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(231, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Fecha Recepcion"
        '
        'txt_id_termometro
        '
        Me.txt_id_termometro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_termometro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_termometro.Location = New System.Drawing.Point(71, 22)
        Me.txt_id_termometro.Name = "txt_id_termometro"
        Me.txt_id_termometro.Size = New System.Drawing.Size(44, 20)
        Me.txt_id_termometro.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Id"
        '
        'txt_observaciones_termometro
        '
        Me.txt_observaciones_termometro.Location = New System.Drawing.Point(96, 114)
        Me.txt_observaciones_termometro.Name = "txt_observaciones_termometro"
        Me.txt_observaciones_termometro.Size = New System.Drawing.Size(331, 97)
        Me.txt_observaciones_termometro.TabIndex = 4
        Me.txt_observaciones_termometro.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 13)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Observaciones"
        '
        'txt_cantidad_termometros
        '
        Me.txt_cantidad_termometros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cantidad_termometros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cantidad_termometros.Location = New System.Drawing.Point(72, 82)
        Me.txt_cantidad_termometros.Name = "txt_cantidad_termometros"
        Me.txt_cantidad_termometros.Size = New System.Drawing.Size(139, 20)
        Me.txt_cantidad_termometros.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Cantidad"
        '
        'cmd_limpiar_termometro
        '
        Me.cmd_limpiar_termometro.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_termometro.BackgroundImage = CType(resources.GetObject("cmd_limpiar_termometro.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_termometro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_termometro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_termometro.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_termometro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_termometro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_termometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_termometro.Location = New System.Drawing.Point(458, 185)
        Me.cmd_limpiar_termometro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_termometro.Name = "cmd_limpiar_termometro"
        Me.cmd_limpiar_termometro.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_termometro.TabIndex = 5
        Me.cmd_limpiar_termometro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_termometro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_termometro.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_termometro
        '
        Me.cmd_eliminar_termometro.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_termometro.BackgroundImage = CType(resources.GetObject("cmd_eliminar_termometro.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_termometro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_termometro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_termometro.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_termometro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_termometro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_termometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_termometro.Location = New System.Drawing.Point(521, 185)
        Me.cmd_eliminar_termometro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_termometro.Name = "cmd_eliminar_termometro"
        Me.cmd_eliminar_termometro.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_termometro.TabIndex = 7
        Me.cmd_eliminar_termometro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_termometro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_termometro.UseVisualStyleBackColor = False
        '
        'cmd_agregar_termometro
        '
        Me.cmd_agregar_termometro.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_termometro.BackgroundImage = CType(resources.GetObject("cmd_agregar_termometro.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_termometro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_termometro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_termometro.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_termometro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_termometro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_termometro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_termometro.Location = New System.Drawing.Point(490, 185)
        Me.cmd_agregar_termometro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_termometro.Name = "cmd_agregar_termometro"
        Me.cmd_agregar_termometro.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_termometro.TabIndex = 6
        Me.cmd_agregar_termometro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_termometro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_termometro.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Tipo/Marca"
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
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(789, 13)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(20, 20)
        Me.cmd_efector_nuevo.TabIndex = 56
        Me.cmd_efector_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_efector_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_efector_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_empleado_nuevo
        '
        Me.cmd_empleado_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.BackgroundImage = CType(resources.GetObject("cmd_empleado_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_empleado_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_empleado_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_empleado_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_empleado_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_empleado_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_empleado_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_empleado_nuevo.Location = New System.Drawing.Point(684, 93)
        Me.cmd_empleado_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_empleado_nuevo.Name = "cmd_empleado_nuevo"
        Me.cmd_empleado_nuevo.Size = New System.Drawing.Size(20, 20)
        Me.cmd_empleado_nuevo.TabIndex = 57
        Me.cmd_empleado_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_empleado_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_empleado_nuevo.UseVisualStyleBackColor = False
        '
        'Inventario_cadena_de_frio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 712)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_datos_vacunatorio)
        Me.Name = "Inventario_cadena_de_frio"
        Me.Text = "INVENTARIO DE CADENA DE FRIO"
        Me.grp_datos_vacunatorio.ResumeLayout(False)
        Me.grp_datos_vacunatorio.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Heladera.ResumeLayout(False)
        CType(Me.dgv_heladeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_detalle.ResumeLayout(False)
        Me.grp_detalle.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_termos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_termometros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_vacunatorio As System.Windows.Forms.GroupBox
    Friend WithEvents txt_empleado_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_heladera As System.Windows.Forms.Label
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_tipos_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_efector As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents txt_empleado_apellido As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Heladera As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grp_detalle As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_funcionamiento_heladera As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_medidas_heladera As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_capacidad_heladra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_modelo_heladera As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_serie_heladera As System.Windows.Forms.TextBox
    Friend WithEvents cmb_marca_heladera As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_heladera As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_heladera As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_heladera As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo_heladera As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones_heladera As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_motivo_heladera As System.Windows.Forms.RichTextBox
    Friend WithEvents dgv_heladeras As System.Windows.Forms.DataGridView
    Friend WithEvents txt_antiguedad_heladera As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_heladera As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents txt_id_heladera As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgv_termos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tipo_termo As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_termo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_id_termos As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones_termo As System.Windows.Forms.RichTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_termo As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_termo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_termo As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_termo As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents id_termo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_termo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones_termo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_termometros As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tipo_termometro As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_termometro As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones_termometro As System.Windows.Forms.RichTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_termometros As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_termometro As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_termometro As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_termometro As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_termometro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_info As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents id_termometro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_termometro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_termometro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad_termometro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones_termometro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_heladera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_heladera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_heladera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capacidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_heladera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents antiguedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents funcionamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_funcionamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones_heladera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_info As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_empleado_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
End Class
