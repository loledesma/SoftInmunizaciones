﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_notificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_notificaciones))
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_datos_generales = New System.Windows.Forms.GroupBox()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.cmd_efector_nuevo = New System.Windows.Forms.Button()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.dgv_notificaciones = New System.Windows.Forms.DataGridView()
        Me.tltp_notificaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_datos_notificacion = New System.Windows.Forms.GroupBox()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.txt_id_notificacion = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_perdidas = New System.Windows.Forms.Label()
        Me.lbl_carga = New System.Windows.Forms.Label()
        Me.cmd_buscar_notificaciones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_contador_notif = New System.Windows.Forms.Label()
        Me.lbl_contador_hoy = New System.Windows.Forms.Label()
        Me.lbl_registradas_hoy = New System.Windows.Forms.Label()
        Me.rdio_hoy = New System.Windows.Forms.RadioButton()
        Me.rdio_todas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_atenciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tltp_empleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_grilla = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_notifica = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_generales.SuspendLayout()
        CType(Me.dgv_notificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_notificacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(253, 355)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_limpiar.TabIndex = 6
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
        Me.cmd_guardar.Location = New System.Drawing.Point(97, 355)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_guardar.TabIndex = 4
        Me.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_guardar.UseVisualStyleBackColor = False
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
        Me.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar.Location = New System.Drawing.Point(175, 355)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(70, 70)
        Me.cmd_eliminar.TabIndex = 5
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 355)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 70)
        Me.cmd_nuevo.TabIndex = 3
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
        Me.cmd_salir.Location = New System.Drawing.Point(1160, 354)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 70)
        Me.cmd_salir.TabIndex = 9
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'grp_datos_generales
        '
        Me.grp_datos_generales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_generales.Controls.Add(Me.txt_cuie)
        Me.grp_datos_generales.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_generales.Controls.Add(Me.txt_efectores)
        Me.grp_datos_generales.Controls.Add(Me.cmd_efector_nuevo)
        Me.grp_datos_generales.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_generales.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_generales.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_generales.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_generales.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_generales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_generales.Location = New System.Drawing.Point(13, 195)
        Me.grp_datos_generales.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grp_datos_generales.Name = "grp_datos_generales"
        Me.grp_datos_generales.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grp_datos_generales.Size = New System.Drawing.Size(470, 153)
        Me.grp_datos_generales.TabIndex = 1
        Me.grp_datos_generales.TabStop = False
        Me.grp_datos_generales.Text = "Datos Efector"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(133, 110)
        Me.txt_cuie.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(283, 22)
        Me.txt_cuie.TabIndex = 3
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(13, 111)
        Me.lbl_cuie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(32, 16)
        Me.lbl_cuie.TabIndex = 55
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(133, 84)
        Me.txt_efectores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(283, 22)
        Me.txt_efectores.TabIndex = 2
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
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(421, 108)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(29, 29)
        Me.cmd_efector_nuevo.TabIndex = 4
        Me.cmd_efector_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_efector_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_efector_nuevo.UseVisualStyleBackColor = False
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(9, 87)
        Me.lbl_vacunatorio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(47, 16)
        Me.lbl_vacunatorio.TabIndex = 32
        Me.lbl_vacunatorio.Text = "Efector"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(9, 57)
        Me.lbl_localidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(63, 16)
        Me.lbl_localidad.TabIndex = 31
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(9, 29)
        Me.lbl_departamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(89, 16)
        Me.lbl_departamento.TabIndex = 30
        Me.lbl_departamento.Text = "Departamento"
        '
        'dgv_notificaciones
        '
        Me.dgv_notificaciones.AllowUserToAddRows = False
        Me.dgv_notificaciones.AllowUserToDeleteRows = False
        Me.dgv_notificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_notificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.nombre_efector, Me.carga, Me.perdidas, Me.stock, Me.id_stock, Me.id_carga, Me.id_perdidas, Me.id_efector, Me.id})
        Me.dgv_notificaciones.Location = New System.Drawing.Point(496, 120)
        Me.dgv_notificaciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgv_notificaciones.Name = "dgv_notificaciones"
        Me.dgv_notificaciones.ReadOnly = True
        Me.dgv_notificaciones.Size = New System.Drawing.Size(734, 228)
        Me.dgv_notificaciones.TabIndex = 46
        '
        'grp_datos_notificacion
        '
        Me.grp_datos_notificacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_carga)
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_stock)
        Me.grp_datos_notificacion.Controls.Add(Me.txt_id_notificacion)
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_perdidas)
        Me.grp_datos_notificacion.Controls.Add(Me.txt_fecha)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_stock)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_perdidas)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_carga)
        Me.grp_datos_notificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_notificacion.Location = New System.Drawing.Point(15, 3)
        Me.grp_datos_notificacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grp_datos_notificacion.Name = "grp_datos_notificacion"
        Me.grp_datos_notificacion.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grp_datos_notificacion.Size = New System.Drawing.Size(470, 185)
        Me.grp_datos_notificacion.TabIndex = 0
        Me.grp_datos_notificacion.TabStop = False
        Me.grp_datos_notificacion.Text = "Datos Notificación"
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(8, 28)
        Me.lbl_id_notificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(19, 16)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id"
        '
        'txt_id_notificacion
        '
        Me.txt_id_notificacion.Location = New System.Drawing.Point(133, 25)
        Me.txt_id_notificacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_id_notificacion.Name = "txt_id_notificacion"
        Me.txt_id_notificacion.Size = New System.Drawing.Size(158, 22)
        Me.txt_id_notificacion.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(133, 55)
        Me.txt_fecha.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(111, 22)
        Me.txt_fecha.TabIndex = 1
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(8, 149)
        Me.lbl_stock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(37, 16)
        Me.lbl_stock.TabIndex = 32
        Me.lbl_stock.Text = "Stock"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(8, 60)
        Me.lbl_perfil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(40, 16)
        Me.lbl_perfil.TabIndex = 49
        Me.lbl_perfil.Text = "Fecha"
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(8, 119)
        Me.lbl_perdidas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(59, 16)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Perdidas"
        '
        'lbl_carga
        '
        Me.lbl_carga.AutoSize = True
        Me.lbl_carga.Location = New System.Drawing.Point(8, 91)
        Me.lbl_carga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_carga.Name = "lbl_carga"
        Me.lbl_carga.Size = New System.Drawing.Size(45, 16)
        Me.lbl_carga.TabIndex = 30
        Me.lbl_carga.Text = "Carga"
        '
        'cmd_buscar_notificaciones
        '
        Me.cmd_buscar_notificaciones.BackgroundImage = CType(resources.GetObject("cmd_buscar_notificaciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_notificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_notificaciones.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_notificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_notificaciones.Location = New System.Drawing.Point(651, 21)
        Me.cmd_buscar_notificaciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_buscar_notificaciones.Name = "cmd_buscar_notificaciones"
        Me.cmd_buscar_notificaciones.Size = New System.Drawing.Size(48, 46)
        Me.cmd_buscar_notificaciones.TabIndex = 5
        Me.cmd_buscar_notificaciones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(494, 356)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Notificaciones registradas: "
        '
        'lbl_contador_notif
        '
        Me.lbl_contador_notif.AutoSize = True
        Me.lbl_contador_notif.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_notif.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_contador_notif.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_notif.Location = New System.Drawing.Point(660, 356)
        Me.lbl_contador_notif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_contador_notif.Name = "lbl_contador_notif"
        Me.lbl_contador_notif.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_notif.TabIndex = 48
        '
        'lbl_contador_hoy
        '
        Me.lbl_contador_hoy.AutoSize = True
        Me.lbl_contador_hoy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_hoy.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_contador_hoy.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_hoy.Location = New System.Drawing.Point(680, 383)
        Me.lbl_contador_hoy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_contador_hoy.Name = "lbl_contador_hoy"
        Me.lbl_contador_hoy.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_hoy.TabIndex = 50
        '
        'lbl_registradas_hoy
        '
        Me.lbl_registradas_hoy.AutoSize = True
        Me.lbl_registradas_hoy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_registradas_hoy.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_registradas_hoy.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_registradas_hoy.Location = New System.Drawing.Point(494, 383)
        Me.lbl_registradas_hoy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_registradas_hoy.Name = "lbl_registradas_hoy"
        Me.lbl_registradas_hoy.Size = New System.Drawing.Size(186, 16)
        Me.lbl_registradas_hoy.TabIndex = 49
        Me.lbl_registradas_hoy.Text = "Notificaciones registradas hoy: "
        '
        'rdio_hoy
        '
        Me.rdio_hoy.AutoSize = True
        Me.rdio_hoy.BackColor = System.Drawing.Color.Transparent
        Me.rdio_hoy.ForeColor = System.Drawing.Color.White
        Me.rdio_hoy.Location = New System.Drawing.Point(1054, 396)
        Me.rdio_hoy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdio_hoy.Name = "rdio_hoy"
        Me.rdio_hoy.Size = New System.Drawing.Size(48, 20)
        Me.rdio_hoy.TabIndex = 51
        Me.rdio_hoy.TabStop = True
        Me.rdio_hoy.Text = "Hoy"
        Me.rdio_hoy.UseVisualStyleBackColor = False
        '
        'rdio_todas
        '
        Me.rdio_todas.AutoSize = True
        Me.rdio_todas.BackColor = System.Drawing.Color.Transparent
        Me.rdio_todas.ForeColor = System.Drawing.Color.White
        Me.rdio_todas.Location = New System.Drawing.Point(1054, 361)
        Me.rdio_todas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdio_todas.Name = "rdio_todas"
        Me.rdio_todas.Size = New System.Drawing.Size(60, 20)
        Me.rdio_todas.TabIndex = 52
        Me.rdio_todas.TabStop = True
        Me.rdio_todas.Text = "Todas"
        Me.rdio_todas.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_atenciones)
        Me.GroupBox1.Controls.Add(Me.cmb_notifica)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_notificaciones)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(506, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 85)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(309, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 54
        Me.Button1.Tag = "Registrar atención"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_atenciones
        '
        Me.txt_atenciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_atenciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_atenciones.Location = New System.Drawing.Point(7, 49)
        Me.txt_atenciones.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_atenciones.Name = "txt_atenciones"
        Me.txt_atenciones.Size = New System.Drawing.Size(294, 22)
        Me.txt_atenciones.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Fecha Hasta"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(510, 51)
        Me.txt_fecha_hasta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(111, 22)
        Me.txt_fecha_hasta.TabIndex = 50
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(510, 17)
        Me.txt_fecha_desde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(111, 22)
        Me.txt_fecha_desde.TabIndex = 1
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Fecha Desde"
        '
        'lbl_grilla
        '
        Me.lbl_grilla.AutoSize = True
        Me.lbl_grilla.BackColor = System.Drawing.Color.Transparent
        Me.lbl_grilla.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_grilla.ForeColor = System.Drawing.Color.White
        Me.lbl_grilla.Location = New System.Drawing.Point(649, 414)
        Me.lbl_grilla.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_grilla.Name = "lbl_grilla"
        Me.lbl_grilla.Size = New System.Drawing.Size(0, 16)
        Me.lbl_grilla.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(494, 414)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Notificaciones en la grilla"
        '
        'cmb_notifica
        '
        Me.cmb_notifica._descripcion = "descripcion"
        Me.cmb_notifica._nombre_tabla = "TIPO_NOTIFICACION"
        Me.cmb_notifica._pk = "id"
        Me.cmb_notifica.FormattingEnabled = True
        Me.cmb_notifica.Location = New System.Drawing.Point(7, 21)
        Me.cmb_notifica.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_notifica.Name = "cmb_notifica"
        Me.cmb_notifica.Size = New System.Drawing.Size(332, 23)
        Me.cmb_notifica.TabIndex = 53
        '
        'cmb_carga
        '
        Me.cmb_carga._descripcion = "descripcion"
        Me.cmb_carga._nombre_tabla = "CARGA"
        Me.cmb_carga._pk = "id"
        Me.cmb_carga.FormattingEnabled = True
        Me.cmb_carga.Location = New System.Drawing.Point(132, 86)
        Me.cmb_carga.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_carga.Name = "cmb_carga"
        Me.cmb_carga.Size = New System.Drawing.Size(250, 23)
        Me.cmb_carga.TabIndex = 2
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = "descripcion"
        Me.cmb_stock._nombre_tabla = "STOCK"
        Me.cmb_stock._pk = "id"
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(132, 147)
        Me.cmb_stock.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(251, 23)
        Me.cmb_stock.TabIndex = 4
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = "descripcion"
        Me.cmb_perdidas._nombre_tabla = "PERDIDAS"
        Me.cmb_perdidas._pk = "id"
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(132, 117)
        Me.cmb_perdidas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(250, 23)
        Me.cmb_perdidas.TabIndex = 3
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(134, 21)
        Me.cmb_departamentos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(279, 23)
        Me.cmb_departamentos.TabIndex = 0
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(134, 54)
        Me.cmb_localidades.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(279, 23)
        Me.cmb_localidades.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(510, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Resultado de la búsqueda:"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.ToolTipText = "Fecha de notificación"
        Me.fecha.Width = 80
        '
        'nombre_efector
        '
        Me.nombre_efector.HeaderText = "Vacunatorio"
        Me.nombre_efector.Name = "nombre_efector"
        Me.nombre_efector.ReadOnly = True
        Me.nombre_efector.Width = 200
        '
        'carga
        '
        Me.carga.HeaderText = "Carga"
        Me.carga.Name = "carga"
        Me.carga.ReadOnly = True
        '
        'perdidas
        '
        Me.perdidas.HeaderText = "Perdidas"
        Me.perdidas.Name = "perdidas"
        Me.perdidas.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'id_stock
        '
        Me.id_stock.HeaderText = "id_stock"
        Me.id_stock.Name = "id_stock"
        Me.id_stock.ReadOnly = True
        Me.id_stock.Visible = False
        '
        'id_carga
        '
        Me.id_carga.HeaderText = "id_carga"
        Me.id_carga.Name = "id_carga"
        Me.id_carga.ReadOnly = True
        Me.id_carga.Visible = False
        '
        'id_perdidas
        '
        Me.id_perdidas.HeaderText = "id_perdidas"
        Me.id_perdidas.Name = "id_perdidas"
        Me.id_perdidas.ReadOnly = True
        Me.id_perdidas.Visible = False
        '
        'id_efector
        '
        Me.id_efector.HeaderText = "CUIE"
        Me.id_efector.Name = "id_efector"
        Me.id_efector.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Registrar_notificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 445)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_grilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdio_todas)
        Me.Controls.Add(Me.rdio_hoy)
        Me.Controls.Add(Me.lbl_contador_hoy)
        Me.Controls.Add(Me.lbl_registradas_hoy)
        Me.Controls.Add(Me.lbl_contador_notif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grp_datos_notificacion)
        Me.Controls.Add(Me.dgv_notificaciones)
        Me.Controls.Add(Me.grp_datos_generales)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Registrar_notificaciones"
        Me.Text = "NOTIFICACIONES"
        Me.grp_datos_generales.ResumeLayout(False)
        Me.grp_datos_generales.PerformLayout()
        CType(Me.dgv_notificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_notificacion.ResumeLayout(False)
        Me.grp_datos_notificacion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_datos_generales As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
    Friend WithEvents dgv_notificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents tltp_notificaciones As System.Windows.Forms.ToolTip
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents grp_datos_notificacion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_stock As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_notificacion As System.Windows.Forms.TextBox
    Friend WithEvents cmb_perdidas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_perdidas As System.Windows.Forms.Label
    Friend WithEvents lbl_carga As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_notificaciones As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_notif As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_hoy As System.Windows.Forms.Label
    Friend WithEvents lbl_registradas_hoy As System.Windows.Forms.Label
    Friend WithEvents rdio_hoy As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_todas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_atenciones As System.Windows.Forms.TextBox
    Friend WithEvents cmb_notifica As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tltp_empleados As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_grilla As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
