﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_capacitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_capacitaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Capacitacion = New System.Windows.Forms.TabPage()
        Me.cmd_invitaciones = New System.Windows.Forms.Button()
        Me.cmd_actividades = New System.Windows.Forms.Button()
        Me.grp_buscar_empleado = New System.Windows.Forms.GroupBox()
        Me.txt_nombres_buscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_apellido_buscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_doc_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_doc_buscar = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_buscar_capas_empleado = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.dgv_capas = New System.Windows.Forms.DataGridView()
        Me.id_capacitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_programada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_efectiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.grp_datos_generales = New System.Windows.Forms.GroupBox()
        Me.cmb_departamento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.txt_lugar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grp_datos_capacitacion = New System.Windows.Forms.GroupBox()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmb_tipo_capacitaciones = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_duracion_real = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_duracion_prevista = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_estado = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_efectiva = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_buscar_capacitaciones = New System.Windows.Forms.Button()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.txt_id_capacitacion = New System.Windows.Forms.TextBox()
        Me.txt_fecha_programada = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_perdidas = New System.Windows.Forms.Label()
        Me.Asistencia = New System.Windows.Forms.TabPage()
        Me.cmd_enviar_correo = New System.Windows.Forms.Button()
        Me.lbl_asistentes = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_observaciones2 = New System.Windows.Forms.RichTextBox()
        Me.cmd_limpiar_asistencia = New System.Windows.Forms.Button()
        Me.cmd_guardar_asistencia = New System.Windows.Forms.Button()
        Me.cmd_nueva_asistencia = New System.Windows.Forms.Button()
        Me.grp_datos_empleados = New System.Windows.Forms.GroupBox()
        Me.cmd_actualizar_sigipsa = New System.Windows.Forms.Button()
        Me.txt_nombres_empleado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmd_buscar_empleadoXDNI = New System.Windows.Forms.Button()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_empleados = New System.Windows.Forms.Button()
        Me.cmd_eliminar_empleado = New System.Windows.Forms.Button()
        Me.cmd_agregar_empleado = New System.Windows.Forms.Button()
        Me.cmd_empleado_nuevo = New System.Windows.Forms.Button()
        Me.txt_numero_doc = New System.Windows.Forms.TextBox()
        Me.txt_apellido_empleado = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_tipos_documento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.realizoEvaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.certificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Capacitacion.SuspendLayout()
        Me.grp_buscar_empleado.SuspendLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grp_descripcion.SuspendLayout()
        Me.grp_datos_generales.SuspendLayout()
        Me.grp_datos_capacitacion.SuspendLayout()
        Me.Asistencia.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_datos_empleados.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Capacitacion)
        Me.TabControl1.Controls.Add(Me.Asistencia)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(899, 669)
        Me.TabControl1.TabIndex = 0
        '
        'Capacitacion
        '
        Me.Capacitacion.BackColor = System.Drawing.Color.Transparent
        Me.Capacitacion.BackgroundImage = CType(resources.GetObject("Capacitacion.BackgroundImage"), System.Drawing.Image)
        Me.Capacitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Capacitacion.Controls.Add(Me.cmd_invitaciones)
        Me.Capacitacion.Controls.Add(Me.cmd_actividades)
        Me.Capacitacion.Controls.Add(Me.grp_buscar_empleado)
        Me.Capacitacion.Controls.Add(Me.cmd_limpiar)
        Me.Capacitacion.Controls.Add(Me.cmd_guardar)
        Me.Capacitacion.Controls.Add(Me.cmd_nuevo)
        Me.Capacitacion.Controls.Add(Me.dgv_capas)
        Me.Capacitacion.Controls.Add(Me.GroupBox1)
        Me.Capacitacion.Controls.Add(Me.grp_descripcion)
        Me.Capacitacion.Controls.Add(Me.grp_datos_generales)
        Me.Capacitacion.Controls.Add(Me.grp_datos_capacitacion)
        Me.Capacitacion.Location = New System.Drawing.Point(4, 22)
        Me.Capacitacion.Name = "Capacitacion"
        Me.Capacitacion.Padding = New System.Windows.Forms.Padding(3)
        Me.Capacitacion.Size = New System.Drawing.Size(891, 643)
        Me.Capacitacion.TabIndex = 0
        Me.Capacitacion.Text = "Capacitacion"
        '
        'cmd_invitaciones
        '
        Me.cmd_invitaciones.BackColor = System.Drawing.Color.Transparent
        Me.cmd_invitaciones.BackgroundImage = CType(resources.GetObject("cmd_invitaciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_invitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_invitaciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_invitaciones.FlatAppearance.BorderSize = 0
        Me.cmd_invitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_invitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_invitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_invitaciones.Location = New System.Drawing.Point(505, 558)
        Me.cmd_invitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_invitaciones.Name = "cmd_invitaciones"
        Me.cmd_invitaciones.Size = New System.Drawing.Size(60, 60)
        Me.cmd_invitaciones.TabIndex = 15
        Me.cmd_invitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_invitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_invitaciones.UseVisualStyleBackColor = False
        '
        'cmd_actividades
        '
        Me.cmd_actividades.BackColor = System.Drawing.Color.Transparent
        Me.cmd_actividades.BackgroundImage = CType(resources.GetObject("cmd_actividades.BackgroundImage"), System.Drawing.Image)
        Me.cmd_actividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_actividades.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_actividades.FlatAppearance.BorderSize = 0
        Me.cmd_actividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_actividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_actividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actividades.Location = New System.Drawing.Point(421, 558)
        Me.cmd_actividades.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_actividades.Name = "cmd_actividades"
        Me.cmd_actividades.Size = New System.Drawing.Size(60, 60)
        Me.cmd_actividades.TabIndex = 14
        Me.cmd_actividades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actividades.UseVisualStyleBackColor = False
        '
        'grp_buscar_empleado
        '
        Me.grp_buscar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.grp_buscar_empleado.Controls.Add(Me.txt_nombres_buscar)
        Me.grp_buscar_empleado.Controls.Add(Me.Label10)
        Me.grp_buscar_empleado.Controls.Add(Me.txt_apellido_buscar)
        Me.grp_buscar_empleado.Controls.Add(Me.Label11)
        Me.grp_buscar_empleado.Controls.Add(Me.txt_doc_buscar)
        Me.grp_buscar_empleado.Controls.Add(Me.Label2)
        Me.grp_buscar_empleado.Controls.Add(Me.cmb_doc_buscar)
        Me.grp_buscar_empleado.Controls.Add(Me.Label9)
        Me.grp_buscar_empleado.Controls.Add(Me.cmd_buscar_capas_empleado)
        Me.grp_buscar_empleado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_buscar_empleado.Location = New System.Drawing.Point(7, 321)
        Me.grp_buscar_empleado.Name = "grp_buscar_empleado"
        Me.grp_buscar_empleado.Size = New System.Drawing.Size(843, 67)
        Me.grp_buscar_empleado.TabIndex = 0
        Me.grp_buscar_empleado.TabStop = False
        Me.grp_buscar_empleado.Text = "Busqueda de Capacitaciones de Empleado"
        '
        'txt_nombres_buscar
        '
        Me.txt_nombres_buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombres_buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombres_buscar.Location = New System.Drawing.Point(547, 15)
        Me.txt_nombres_buscar.Name = "txt_nombres_buscar"
        Me.txt_nombres_buscar.Size = New System.Drawing.Size(250, 20)
        Me.txt_nombres_buscar.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(451, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Nombres"
        '
        'txt_apellido_buscar
        '
        Me.txt_apellido_buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_apellido_buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido_buscar.Location = New System.Drawing.Point(547, 41)
        Me.txt_apellido_buscar.Name = "txt_apellido_buscar"
        Me.txt_apellido_buscar.Size = New System.Drawing.Size(250, 20)
        Me.txt_apellido_buscar.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(450, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Apellidos"
        '
        'txt_doc_buscar
        '
        Me.txt_doc_buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_doc_buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_doc_buscar.Location = New System.Drawing.Point(209, 27)
        Me.txt_doc_buscar.Name = "txt_doc_buscar"
        Me.txt_doc_buscar.Size = New System.Drawing.Size(216, 20)
        Me.txt_doc_buscar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Número"
        '
        'cmb_doc_buscar
        '
        Me.cmb_doc_buscar._descripcion = "descripcion"
        Me.cmb_doc_buscar._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_doc_buscar._pk = "id"
        Me.cmb_doc_buscar.FormattingEnabled = True
        Me.cmb_doc_buscar.Location = New System.Drawing.Point(100, 27)
        Me.cmb_doc_buscar.Name = "cmb_doc_buscar"
        Me.cmb_doc_buscar.Size = New System.Drawing.Size(53, 21)
        Me.cmb_doc_buscar.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tipo Doc"
        '
        'cmd_buscar_capas_empleado
        '
        Me.cmd_buscar_capas_empleado.BackgroundImage = CType(resources.GetObject("cmd_buscar_capas_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_capas_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_capas_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_capas_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_capas_empleado.Location = New System.Drawing.Point(806, 25)
        Me.cmd_buscar_capas_empleado.Name = "cmd_buscar_capas_empleado"
        Me.cmd_buscar_capas_empleado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_capas_empleado.TabIndex = 4
        Me.cmd_buscar_capas_empleado.UseVisualStyleBackColor = True
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(155, 576)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
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
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(79, 576)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
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
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(11, 575)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 1
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'dgv_capas
        '
        Me.dgv_capas.AllowUserToAddRows = False
        Me.dgv_capas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_capas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_capas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_capas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_capacitacion, Me.tipo, Me.estado, Me.fecha_programada, Me.fecha_efectiva, Me.localidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_capas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_capas.Location = New System.Drawing.Point(7, 394)
        Me.dgv_capas.Name = "dgv_capas"
        Me.dgv_capas.ReadOnly = True
        Me.dgv_capas.Size = New System.Drawing.Size(852, 157)
        Me.dgv_capas.TabIndex = 13
        '
        'id_capacitacion
        '
        Me.id_capacitacion.HeaderText = "Id Capacitacion"
        Me.id_capacitacion.Name = "id_capacitacion"
        Me.id_capacitacion.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'fecha_programada
        '
        Me.fecha_programada.HeaderText = "Fecha Programada"
        Me.fecha_programada.Name = "fecha_programada"
        Me.fecha_programada.ReadOnly = True
        '
        'fecha_efectiva
        '
        Me.fecha_efectiva.HeaderText = "Fecha Efectiva"
        Me.fecha_efectiva.Name = "fecha_efectiva"
        Me.fecha_efectiva.ReadOnly = True
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(449, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 121)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripcion"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(8, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(387, 86)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'grp_descripcion
        '
        Me.grp_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.grp_descripcion.Controls.Add(Me.txt_observaciones)
        Me.grp_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_descripcion.Location = New System.Drawing.Point(450, 232)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(400, 82)
        Me.grp_descripcion.TabIndex = 11
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(8, 20)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(386, 51)
        Me.txt_observaciones.TabIndex = 0
        Me.txt_observaciones.Text = ""
        '
        'grp_datos_generales
        '
        Me.grp_datos_generales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_generales.Controls.Add(Me.cmb_departamento)
        Me.grp_datos_generales.Controls.Add(Me.Label8)
        Me.grp_datos_generales.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_generales.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_generales.Controls.Add(Me.txt_lugar)
        Me.grp_datos_generales.Controls.Add(Me.Label6)
        Me.grp_datos_generales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_generales.Location = New System.Drawing.Point(447, 5)
        Me.grp_datos_generales.Name = "grp_datos_generales"
        Me.grp_datos_generales.Size = New System.Drawing.Size(403, 103)
        Me.grp_datos_generales.TabIndex = 10
        Me.grp_datos_generales.TabStop = False
        Me.grp_datos_generales.Text = "Ubicacion"
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(118, 42)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(268, 21)
        Me.cmb_departamento.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Departamento"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(118, 68)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(216, 21)
        Me.cmb_localidades.TabIndex = 2
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(14, 71)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 33
        Me.lbl_localidad.Text = "Localidad"
        '
        'txt_lugar
        '
        Me.txt_lugar.Location = New System.Drawing.Point(118, 15)
        Me.txt_lugar.Name = "txt_lugar"
        Me.txt_lugar.Size = New System.Drawing.Size(268, 20)
        Me.txt_lugar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Lugar"
        '
        'grp_datos_capacitacion
        '
        Me.grp_datos_capacitacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_capacitacion.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_capacitacion.Controls.Add(Me.cmb_tipo_capacitaciones)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label5)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_duracion_real)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label4)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_duracion_prevista)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label3)
        Me.grp_datos_capacitacion.Controls.Add(Me.cmb_estado)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label1)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_hora)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_fecha_efectiva)
        Me.grp_datos_capacitacion.Controls.Add(Me.cmd_buscar_capacitaciones)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_id_capacitacion)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_fecha_programada)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_stock)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_perdidas)
        Me.grp_datos_capacitacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_capacitacion.Location = New System.Drawing.Point(6, 4)
        Me.grp_datos_capacitacion.Name = "grp_datos_capacitacion"
        Me.grp_datos_capacitacion.Size = New System.Drawing.Size(403, 311)
        Me.grp_datos_capacitacion.TabIndex = 0
        Me.grp_datos_capacitacion.TabStop = False
        Me.grp_datos_capacitacion.Text = "Datos "
        '
        'cmd_actualizar_estado
        '
        Me.cmd_actualizar_estado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_actualizar_estado.BackgroundImage = CType(resources.GetObject("cmd_actualizar_estado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_actualizar_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_actualizar_estado.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_actualizar_estado.FlatAppearance.BorderSize = 0
        Me.cmd_actualizar_estado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_actualizar_estado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_actualizar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(359, 189)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_actualizar_estado.TabIndex = 14
        Me.cmd_actualizar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar_estado.UseVisualStyleBackColor = False
        '
        'cmb_tipo_capacitaciones
        '
        Me.cmb_tipo_capacitaciones._descripcion = "descripcion"
        Me.cmb_tipo_capacitaciones._nombre_tabla = "TIPO_CAPACITACIONES"
        Me.cmb_tipo_capacitaciones._pk = "id"
        Me.cmb_tipo_capacitaciones.FormattingEnabled = True
        Me.cmb_tipo_capacitaciones.Location = New System.Drawing.Point(111, 50)
        Me.cmb_tipo_capacitaciones.Name = "cmb_tipo_capacitaciones"
        Me.cmb_tipo_capacitaciones.Size = New System.Drawing.Size(216, 21)
        Me.cmb_tipo_capacitaciones.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Tipos"
        '
        'txt_duracion_real
        '
        Me.txt_duracion_real.Location = New System.Drawing.Point(112, 271)
        Me.txt_duracion_real.Name = "txt_duracion_real"
        Me.txt_duracion_real.Size = New System.Drawing.Size(99, 20)
        Me.txt_duracion_real.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Duracion Efectiva"
        '
        'txt_duracion_prevista
        '
        Me.txt_duracion_prevista.Location = New System.Drawing.Point(111, 233)
        Me.txt_duracion_prevista.Name = "txt_duracion_prevista"
        Me.txt_duracion_prevista.Size = New System.Drawing.Size(90, 20)
        Me.txt_duracion_prevista.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Duracion Prevista"
        '
        'cmb_estado
        '
        Me.cmb_estado._descripcion = "descripcion"
        Me.cmb_estado._nombre_tabla = "ESTADO_CAPACITACIONES"
        Me.cmb_estado._pk = "id"
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(112, 192)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(224, 21)
        Me.cmb_estado.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Estado"
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(111, 153)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora.TabIndex = 4
        '
        'txt_fecha_efectiva
        '
        Me.txt_fecha_efectiva.Location = New System.Drawing.Point(112, 116)
        Me.txt_fecha_efectiva.Mask = "00/00/0000"
        Me.txt_fecha_efectiva.Name = "txt_fecha_efectiva"
        Me.txt_fecha_efectiva.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_efectiva.TabIndex = 3
        Me.txt_fecha_efectiva.ValidatingType = GetType(Date)
        '
        'cmd_buscar_capacitaciones
        '
        Me.cmd_buscar_capacitaciones.BackgroundImage = CType(resources.GetObject("cmd_buscar_capacitaciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_capacitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_capacitaciones.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_capacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_capacitaciones.Location = New System.Drawing.Point(341, 19)
        Me.cmd_buscar_capacitaciones.Name = "cmd_buscar_capacitaciones"
        Me.cmd_buscar_capacitaciones.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar_capacitaciones.TabIndex = 8
        Me.cmd_buscar_capacitaciones.UseVisualStyleBackColor = True
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(7, 24)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(16, 13)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id"
        '
        'txt_id_capacitacion
        '
        Me.txt_id_capacitacion.Location = New System.Drawing.Point(112, 21)
        Me.txt_id_capacitacion.Name = "txt_id_capacitacion"
        Me.txt_id_capacitacion.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_capacitacion.TabIndex = 0
        '
        'txt_fecha_programada
        '
        Me.txt_fecha_programada.Location = New System.Drawing.Point(113, 84)
        Me.txt_fecha_programada.Mask = "00/00/0000"
        Me.txt_fecha_programada.Name = "txt_fecha_programada"
        Me.txt_fecha_programada.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_programada.TabIndex = 2
        Me.txt_fecha_programada.ValidatingType = GetType(Date)
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(11, 159)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(30, 13)
        Me.lbl_stock.TabIndex = 32
        Me.lbl_stock.Text = "Hora"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(7, 89)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(97, 13)
        Me.lbl_perfil.TabIndex = 49
        Me.lbl_perfil.Text = "Fecha Programada"
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(9, 120)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(79, 13)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Fecha Efectiva"
        '
        'Asistencia
        '
        Me.Asistencia.BackColor = System.Drawing.Color.Transparent
        Me.Asistencia.BackgroundImage = CType(resources.GetObject("Asistencia.BackgroundImage"), System.Drawing.Image)
        Me.Asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Asistencia.Controls.Add(Me.cmd_enviar_correo)
        Me.Asistencia.Controls.Add(Me.lbl_asistentes)
        Me.Asistencia.Controls.Add(Me.Label22)
        Me.Asistencia.Controls.Add(Me.GroupBox2)
        Me.Asistencia.Controls.Add(Me.cmd_limpiar_asistencia)
        Me.Asistencia.Controls.Add(Me.cmd_guardar_asistencia)
        Me.Asistencia.Controls.Add(Me.cmd_nueva_asistencia)
        Me.Asistencia.Controls.Add(Me.grp_datos_empleados)
        Me.Asistencia.Controls.Add(Me.dgv_empleados)
        Me.Asistencia.Location = New System.Drawing.Point(4, 22)
        Me.Asistencia.Name = "Asistencia"
        Me.Asistencia.Padding = New System.Windows.Forms.Padding(3)
        Me.Asistencia.Size = New System.Drawing.Size(891, 643)
        Me.Asistencia.TabIndex = 1
        Me.Asistencia.Text = "Asistencia"
        '
        'cmd_enviar_correo
        '
        Me.cmd_enviar_correo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_enviar_correo.BackgroundImage = CType(resources.GetObject("cmd_enviar_correo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_enviar_correo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_enviar_correo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_enviar_correo.FlatAppearance.BorderSize = 0
        Me.cmd_enviar_correo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_enviar_correo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_enviar_correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_enviar_correo.Location = New System.Drawing.Point(807, 543)
        Me.cmd_enviar_correo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_enviar_correo.Name = "cmd_enviar_correo"
        Me.cmd_enviar_correo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_enviar_correo.TabIndex = 56
        Me.cmd_enviar_correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_enviar_correo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_enviar_correo.UseVisualStyleBackColor = False
        '
        'lbl_asistentes
        '
        Me.lbl_asistentes.AutoSize = True
        Me.lbl_asistentes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_asistentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_asistentes.ForeColor = System.Drawing.Color.White
        Me.lbl_asistentes.Location = New System.Drawing.Point(742, 529)
        Me.lbl_asistentes.Name = "lbl_asistentes"
        Me.lbl_asistentes.Size = New System.Drawing.Size(0, 17)
        Me.lbl_asistentes.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(636, 528)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 17)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Asistentes:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_observaciones2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(536, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 207)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Observaciones"
        '
        'txt_observaciones2
        '
        Me.txt_observaciones2.Location = New System.Drawing.Point(8, 20)
        Me.txt_observaciones2.Name = "txt_observaciones2"
        Me.txt_observaciones2.Size = New System.Drawing.Size(303, 174)
        Me.txt_observaciones2.TabIndex = 0
        Me.txt_observaciones2.Text = ""
        '
        'cmd_limpiar_asistencia
        '
        Me.cmd_limpiar_asistencia.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_asistencia.BackgroundImage = CType(resources.GetObject("cmd_limpiar_asistencia.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_asistencia.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_asistencia.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_asistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_asistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_asistencia.Location = New System.Drawing.Point(160, 542)
        Me.cmd_limpiar_asistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_asistencia.Name = "cmd_limpiar_asistencia"
        Me.cmd_limpiar_asistencia.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar_asistencia.TabIndex = 7
        Me.cmd_limpiar_asistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_asistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_asistencia.UseVisualStyleBackColor = False
        '
        'cmd_guardar_asistencia
        '
        Me.cmd_guardar_asistencia.BackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar_asistencia.BackgroundImage = CType(resources.GetObject("cmd_guardar_asistencia.BackgroundImage"), System.Drawing.Image)
        Me.cmd_guardar_asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_guardar_asistencia.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_guardar_asistencia.FlatAppearance.BorderSize = 0
        Me.cmd_guardar_asistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar_asistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar_asistencia.Location = New System.Drawing.Point(92, 543)
        Me.cmd_guardar_asistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar_asistencia.Name = "cmd_guardar_asistencia"
        Me.cmd_guardar_asistencia.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar_asistencia.TabIndex = 5
        Me.cmd_guardar_asistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar_asistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_guardar_asistencia.UseVisualStyleBackColor = False
        '
        'cmd_nueva_asistencia
        '
        Me.cmd_nueva_asistencia.BackColor = System.Drawing.Color.Transparent
        Me.cmd_nueva_asistencia.BackgroundImage = CType(resources.GetObject("cmd_nueva_asistencia.BackgroundImage"), System.Drawing.Image)
        Me.cmd_nueva_asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_nueva_asistencia.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_nueva_asistencia.FlatAppearance.BorderSize = 0
        Me.cmd_nueva_asistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_nueva_asistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_nueva_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nueva_asistencia.Location = New System.Drawing.Point(24, 543)
        Me.cmd_nueva_asistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nueva_asistencia.Name = "cmd_nueva_asistencia"
        Me.cmd_nueva_asistencia.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nueva_asistencia.TabIndex = 6
        Me.cmd_nueva_asistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nueva_asistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nueva_asistencia.UseVisualStyleBackColor = False
        '
        'grp_datos_empleados
        '
        Me.grp_datos_empleados.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_empleados.Controls.Add(Me.cmd_actualizar_sigipsa)
        Me.grp_datos_empleados.Controls.Add(Me.txt_nombres_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.Label21)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_buscar_empleadoXDNI)
        Me.grp_datos_empleados.Controls.Add(Me.txt_id_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.Label20)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_limpiar_empleados)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_eliminar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_agregar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_empleado_nuevo)
        Me.grp_datos_empleados.Controls.Add(Me.txt_numero_doc)
        Me.grp_datos_empleados.Controls.Add(Me.txt_apellido_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.label16)
        Me.grp_datos_empleados.Controls.Add(Me.Label19)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_tipos_documento)
        Me.grp_datos_empleados.Controls.Add(Me.Label18)
        Me.grp_datos_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_empleados.Location = New System.Drawing.Point(19, 24)
        Me.grp_datos_empleados.Name = "grp_datos_empleados"
        Me.grp_datos_empleados.Size = New System.Drawing.Size(511, 207)
        Me.grp_datos_empleados.TabIndex = 2
        Me.grp_datos_empleados.TabStop = False
        Me.grp_datos_empleados.Text = "Datos del empleado"
        '
        'cmd_actualizar_sigipsa
        '
        Me.cmd_actualizar_sigipsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_actualizar_sigipsa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_actualizar_sigipsa.FlatAppearance.BorderSize = 0
        Me.cmd_actualizar_sigipsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actualizar_sigipsa.Location = New System.Drawing.Point(155, 159)
        Me.cmd_actualizar_sigipsa.Name = "cmd_actualizar_sigipsa"
        Me.cmd_actualizar_sigipsa.Size = New System.Drawing.Size(168, 35)
        Me.cmd_actualizar_sigipsa.TabIndex = 10
        Me.cmd_actualizar_sigipsa.Text = "ACTUALIZAR SIGIPSA"
        Me.cmd_actualizar_sigipsa.UseVisualStyleBackColor = True
        '
        'txt_nombres_empleado
        '
        Me.txt_nombres_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombres_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombres_empleado.Location = New System.Drawing.Point(114, 98)
        Me.txt_nombres_empleado.Name = "txt_nombres_empleado"
        Me.txt_nombres_empleado.Size = New System.Drawing.Size(325, 20)
        Me.txt_nombres_empleado.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Nombres"
        '
        'cmd_buscar_empleadoXDNI
        '
        Me.cmd_buscar_empleadoXDNI.BackgroundImage = CType(resources.GetObject("cmd_buscar_empleadoXDNI.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_empleadoXDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_empleadoXDNI.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_empleadoXDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_empleadoXDNI.Location = New System.Drawing.Point(442, 42)
        Me.cmd_buscar_empleadoXDNI.Name = "cmd_buscar_empleadoXDNI"
        Me.cmd_buscar_empleadoXDNI.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_empleadoXDNI.TabIndex = 3
        Me.cmd_buscar_empleadoXDNI.UseVisualStyleBackColor = True
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_empleado.Location = New System.Drawing.Point(114, 16)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(53, 20)
        Me.txt_id_empleado.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
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
        Me.cmd_limpiar_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_empleados.Location = New System.Drawing.Point(411, 133)
        Me.cmd_limpiar_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_empleados.Name = "cmd_limpiar_empleados"
        Me.cmd_limpiar_empleados.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_empleados.TabIndex = 11
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
        Me.cmd_eliminar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_empleado.Location = New System.Drawing.Point(474, 133)
        Me.cmd_eliminar_empleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_empleado.Name = "cmd_eliminar_empleado"
        Me.cmd_eliminar_empleado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_empleado.TabIndex = 13
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
        Me.cmd_agregar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_empleado.Location = New System.Drawing.Point(443, 133)
        Me.cmd_agregar_empleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_empleado.Name = "cmd_agregar_empleado"
        Me.cmd_agregar_empleado.Size = New System.Drawing.Size(25, 25)
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
        Me.cmd_empleado_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_empleado_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_empleado_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_empleado_nuevo.Location = New System.Drawing.Point(474, 42)
        Me.cmd_empleado_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_empleado_nuevo.Name = "cmd_empleado_nuevo"
        Me.cmd_empleado_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_empleado_nuevo.TabIndex = 4
        Me.cmd_empleado_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_empleado_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_empleado_nuevo.UseVisualStyleBackColor = False
        '
        'txt_numero_doc
        '
        Me.txt_numero_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_numero_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_numero_doc.Location = New System.Drawing.Point(223, 43)
        Me.txt_numero_doc.Name = "txt_numero_doc"
        Me.txt_numero_doc.Size = New System.Drawing.Size(216, 20)
        Me.txt_numero_doc.TabIndex = 2
        '
        'txt_apellido_empleado
        '
        Me.txt_apellido_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_apellido_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido_empleado.Location = New System.Drawing.Point(114, 70)
        Me.txt_apellido_empleado.Name = "txt_apellido_empleado"
        Me.txt_apellido_empleado.Size = New System.Drawing.Size(325, 20)
        Me.txt_apellido_empleado.TabIndex = 5
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(17, 73)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(49, 13)
        Me.label16.TabIndex = 23
        Me.label16.Text = "Apellidos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Número"
        '
        'cmb_tipos_documento
        '
        Me.cmb_tipos_documento._descripcion = "descripcion"
        Me.cmb_tipos_documento._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_tipos_documento._pk = "id"
        Me.cmb_tipos_documento.FormattingEnabled = True
        Me.cmb_tipos_documento.Location = New System.Drawing.Point(114, 43)
        Me.cmb_tipos_documento.Name = "cmb_tipos_documento"
        Me.cmb_tipos_documento.Size = New System.Drawing.Size(53, 21)
        Me.cmb_tipos_documento.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Tipo Doc"
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_doc, Me.numero, Me.nombres, Me.apellidos, Me.mail, Me.realizoEvaluacion, Me.certificado, Me.observaciones})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_empleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_empleados.Location = New System.Drawing.Point(20, 267)
        Me.dgv_empleados.Name = "dgv_empleados"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_empleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empleados.Size = New System.Drawing.Size(847, 245)
        Me.dgv_empleados.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.Width = 30
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.Width = 75
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        Me.nombres.Width = 180
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Width = 180
        '
        'mail
        '
        Me.mail.HeaderText = "E-mail"
        Me.mail.Name = "mail"
        Me.mail.Width = 150
        '
        'realizoEvaluacion
        '
        Me.realizoEvaluacion.HeaderText = "Realizo Evaluacion"
        Me.realizoEvaluacion.Name = "realizoEvaluacion"
        '
        'certificado
        '
        Me.certificado.HeaderText = "Certificado"
        Me.certificado.Name = "certificado"
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "observaciones"
        Me.observaciones.Name = "observaciones"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(846, 684)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(59, 53)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Registrar_capacitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(924, 741)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "Registrar_capacitaciones"
        Me.Text = "CAPACITACIONES"
        Me.TabControl1.ResumeLayout(False)
        Me.Capacitacion.ResumeLayout(False)
        Me.grp_buscar_empleado.ResumeLayout(False)
        Me.grp_buscar_empleado.PerformLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_descripcion.ResumeLayout(False)
        Me.grp_datos_generales.ResumeLayout(False)
        Me.grp_datos_generales.PerformLayout()
        Me.grp_datos_capacitacion.ResumeLayout(False)
        Me.grp_datos_capacitacion.PerformLayout()
        Me.Asistencia.ResumeLayout(False)
        Me.Asistencia.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_datos_empleados.ResumeLayout(False)
        Me.grp_datos_empleados.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Capacitacion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_datos_generales As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents txt_lugar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grp_datos_capacitacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipo_capacitaciones As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_duracion_real As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_duracion_prevista As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_hora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_efectiva As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_buscar_capacitaciones As System.Windows.Forms.Button
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents txt_id_capacitacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_programada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_perdidas As System.Windows.Forms.Label
    Friend WithEvents Asistencia As System.Windows.Forms.TabPage
    Friend WithEvents dgv_capas As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents grp_datos_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_actualizar_sigipsa As System.Windows.Forms.Button
    Friend WithEvents txt_nombres_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_empleadoXDNI As System.Windows.Forms.Button
    Friend WithEvents txt_id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_empleados As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_empleado As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_empleado As System.Windows.Forms.Button
    Friend WithEvents cmd_empleado_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_numero_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_empleado As System.Windows.Forms.TextBox
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_documento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_asistencia As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar_asistencia As System.Windows.Forms.Button
    Friend WithEvents cmd_nueva_asistencia As System.Windows.Forms.Button
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_observaciones2 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents id_capacitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_programada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_efectiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_asistentes As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grp_buscar_empleado As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscar_capas_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_doc_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_doc_buscar As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_nombres_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmd_invitaciones As System.Windows.Forms.Button
    Friend WithEvents cmd_actividades As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents realizoEvaluacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents certificado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_enviar_correo As System.Windows.Forms.Button
End Class
