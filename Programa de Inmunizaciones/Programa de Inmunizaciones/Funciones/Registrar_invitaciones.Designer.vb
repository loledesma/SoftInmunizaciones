<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_invitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_invitaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_limpiar_invitado = New System.Windows.Forms.Button()
        Me.cmd_eliminar_invitado = New System.Windows.Forms.Button()
        Me.cmd_agregar_invitado = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.grp_datos_capacitacion = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar_capacitaciones = New System.Windows.Forms.Button()
        Me.txt_lugar = New System.Windows.Forms.TextBox()
        Me.lbl_perdidas = New System.Windows.Forms.Label()
        Me.txt_fecha_efectiva = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_tipo_capacitaciones = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_capacitacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_confirmada = New System.Windows.Forms.CheckBox()
        Me.chk_enviada = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones2 = New System.Windows.Forms.RichTextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.dgv_capas = New System.Windows.Forms.DataGridView()
        Me.fecha_programada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_efectores = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacunatorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tltp_efectores = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_contador_total = New System.Windows.Forms.Label()
        Me.lbl_invitados = New System.Windows.Forms.Label()
        Me.grp_datos_capacitacion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_efectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_limpiar_invitado
        '
        Me.cmd_limpiar_invitado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_invitado.BackgroundImage = CType(resources.GetObject("cmd_limpiar_invitado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_invitado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_invitado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_invitado.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_invitado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_invitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_invitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_invitado.Location = New System.Drawing.Point(385, 211)
        Me.cmd_limpiar_invitado.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_limpiar_invitado.Name = "cmd_limpiar_invitado"
        Me.cmd_limpiar_invitado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_limpiar_invitado.TabIndex = 11
        Me.cmd_limpiar_invitado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_invitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_invitado.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_invitado
        '
        Me.cmd_eliminar_invitado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_invitado.BackgroundImage = CType(resources.GetObject("cmd_eliminar_invitado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_invitado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_invitado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_invitado.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_invitado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_invitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_invitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_invitado.Location = New System.Drawing.Point(458, 211)
        Me.cmd_eliminar_invitado.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_eliminar_invitado.Name = "cmd_eliminar_invitado"
        Me.cmd_eliminar_invitado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_eliminar_invitado.TabIndex = 13
        Me.cmd_eliminar_invitado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_invitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_invitado.UseVisualStyleBackColor = False
        '
        'cmd_agregar_invitado
        '
        Me.cmd_agregar_invitado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_invitado.BackgroundImage = CType(resources.GetObject("cmd_agregar_invitado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_invitado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_invitado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_invitado.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_invitado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_invitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_invitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_invitado.Location = New System.Drawing.Point(422, 211)
        Me.cmd_agregar_invitado.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_agregar_invitado.Name = "cmd_agregar_invitado"
        Me.cmd_agregar_invitado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_agregar_invitado.TabIndex = 12
        Me.cmd_agregar_invitado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_invitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_invitado.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(955, 513)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(69, 61)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(153, 54)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(214, 22)
        Me.txt_cuie.TabIndex = 65
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(19, 55)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(32, 16)
        Me.lbl_cuie.TabIndex = 67
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(152, 22)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(328, 22)
        Me.txt_efectores.TabIndex = 64
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(16, 24)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(75, 16)
        Me.lbl_vacunatorio.TabIndex = 66
        Me.lbl_vacunatorio.Text = "Vacunatorio"
        '
        'grp_datos_capacitacion
        '
        Me.grp_datos_capacitacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_capacitacion.Controls.Add(Me.cmd_buscar_capacitaciones)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_lugar)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_perdidas)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_fecha_efectiva)
        Me.grp_datos_capacitacion.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_capacitacion.Controls.Add(Me.cmb_tipo_capacitaciones)
        Me.grp_datos_capacitacion.Controls.Add(Me.txt_id_capacitacion)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label5)
        Me.grp_datos_capacitacion.Controls.Add(Me.Label6)
        Me.grp_datos_capacitacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_capacitacion.Location = New System.Drawing.Point(14, 14)
        Me.grp_datos_capacitacion.Name = "grp_datos_capacitacion"
        Me.grp_datos_capacitacion.Size = New System.Drawing.Size(488, 220)
        Me.grp_datos_capacitacion.TabIndex = 68
        Me.grp_datos_capacitacion.TabStop = False
        Me.grp_datos_capacitacion.Text = "Capacitacion"
        '
        'cmd_buscar_capacitaciones
        '
        Me.cmd_buscar_capacitaciones.BackgroundImage = CType(resources.GetObject("cmd_buscar_capacitaciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_capacitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_capacitaciones.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_capacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_capacitaciones.Location = New System.Drawing.Point(398, 22)
        Me.cmd_buscar_capacitaciones.Name = "cmd_buscar_capacitaciones"
        Me.cmd_buscar_capacitaciones.Size = New System.Drawing.Size(47, 46)
        Me.cmd_buscar_capacitaciones.TabIndex = 8
        Me.cmd_buscar_capacitaciones.UseVisualStyleBackColor = True
        '
        'txt_lugar
        '
        Me.txt_lugar.Location = New System.Drawing.Point(128, 138)
        Me.txt_lugar.Name = "txt_lugar"
        Me.txt_lugar.Size = New System.Drawing.Size(312, 22)
        Me.txt_lugar.TabIndex = 0
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(6, 103)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(40, 16)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Fecha"
        '
        'txt_fecha_efectiva
        '
        Me.txt_fecha_efectiva.Location = New System.Drawing.Point(129, 98)
        Me.txt_fecha_efectiva.Mask = "00/00/0000"
        Me.txt_fecha_efectiva.Name = "txt_fecha_efectiva"
        Me.txt_fecha_efectiva.Size = New System.Drawing.Size(112, 22)
        Me.txt_fecha_efectiva.TabIndex = 3
        Me.txt_fecha_efectiva.ValidatingType = GetType(Date)
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(7, 29)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(96, 16)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id Capacitacion"
        '
        'cmb_tipo_capacitaciones
        '
        Me.cmb_tipo_capacitaciones._descripcion = "descripcion"
        Me.cmb_tipo_capacitaciones._nombre_tabla = "TIPO_CAPACITACIONES"
        Me.cmb_tipo_capacitaciones._pk = "id"
        Me.cmb_tipo_capacitaciones.FormattingEnabled = True
        Me.cmb_tipo_capacitaciones.Location = New System.Drawing.Point(128, 59)
        Me.cmb_tipo_capacitaciones.Name = "cmb_tipo_capacitaciones"
        Me.cmb_tipo_capacitaciones.Size = New System.Drawing.Size(251, 23)
        Me.cmb_tipo_capacitaciones.TabIndex = 1
        '
        'txt_id_capacitacion
        '
        Me.txt_id_capacitacion.Location = New System.Drawing.Point(129, 25)
        Me.txt_id_capacitacion.Name = "txt_id_capacitacion"
        Me.txt_id_capacitacion.Size = New System.Drawing.Size(158, 22)
        Me.txt_id_capacitacion.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Lugar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_confirmada)
        Me.GroupBox3.Controls.Add(Me.chk_enviada)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_observaciones2)
        Me.GroupBox3.Controls.Add(Me.txt_efectores)
        Me.GroupBox3.Controls.Add(Me.lbl_vacunatorio)
        Me.GroupBox3.Controls.Add(Me.txt_cuie)
        Me.GroupBox3.Controls.Add(Me.lbl_cuie)
        Me.GroupBox3.Controls.Add(Me.cmd_eliminar_invitado)
        Me.GroupBox3.Controls.Add(Me.cmd_agregar_invitado)
        Me.GroupBox3.Controls.Add(Me.cmd_limpiar_invitado)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(14, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 248)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invitado"
        '
        'chk_confirmada
        '
        Me.chk_confirmada.AutoSize = True
        Me.chk_confirmada.Location = New System.Drawing.Point(273, 99)
        Me.chk_confirmada.Name = "chk_confirmada"
        Me.chk_confirmada.Size = New System.Drawing.Size(94, 20)
        Me.chk_confirmada.TabIndex = 72
        Me.chk_confirmada.Text = "Confirmada"
        Me.chk_confirmada.UseVisualStyleBackColor = True
        '
        'chk_enviada
        '
        Me.chk_enviada.AutoSize = True
        Me.chk_enviada.Location = New System.Drawing.Point(154, 98)
        Me.chk_enviada.Name = "chk_enviada"
        Me.chk_enviada.Size = New System.Drawing.Size(72, 20)
        Me.chk_enviada.TabIndex = 71
        Me.chk_enviada.Text = "Enviada"
        Me.chk_enviada.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Invitacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Observaciones"
        '
        'txt_observaciones2
        '
        Me.txt_observaciones2.Location = New System.Drawing.Point(154, 144)
        Me.txt_observaciones2.Name = "txt_observaciones2"
        Me.txt_observaciones2.Size = New System.Drawing.Size(326, 58)
        Me.txt_observaciones2.TabIndex = 68
        Me.txt_observaciones2.Text = ""
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(178, 512)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_limpiar.TabIndex = 73
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
        Me.cmd_guardar.Location = New System.Drawing.Point(99, 513)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_guardar.TabIndex = 71
        Me.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'dgv_capas
        '
        Me.dgv_capas.AllowUserToAddRows = False
        Me.dgv_capas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_capas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_capas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_capas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_programada, Me.tipo, Me.estado, Me.localidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_capas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_capas.Location = New System.Drawing.Point(531, 16)
        Me.dgv_capas.Name = "dgv_capas"
        Me.dgv_capas.ReadOnly = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_capas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_capas.Size = New System.Drawing.Size(517, 218)
        Me.dgv_capas.TabIndex = 74
        '
        'fecha_programada
        '
        Me.fecha_programada.HeaderText = "Fecha "
        Me.fecha_programada.Name = "fecha_programada"
        Me.fecha_programada.ReadOnly = True
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
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 200
        '
        'dgv_efectores
        '
        Me.dgv_efectores.AllowUserToAddRows = False
        Me.dgv_efectores.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_efectores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_efectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_efectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.vacunatorio, Me.invitacion, Me.observaciones})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_efectores.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_efectores.Location = New System.Drawing.Point(531, 246)
        Me.dgv_efectores.Name = "dgv_efectores"
        Me.dgv_efectores.ReadOnly = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgv_efectores.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_efectores.Size = New System.Drawing.Size(517, 235)
        Me.dgv_efectores.TabIndex = 75
        '
        'cuie
        '
        Me.cuie.HeaderText = "Cuie"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Width = 60
        '
        'vacunatorio
        '
        Me.vacunatorio.HeaderText = "Vacunatorio"
        Me.vacunatorio.Name = "vacunatorio"
        Me.vacunatorio.ReadOnly = True
        Me.vacunatorio.Width = 230
        '
        'invitacion
        '
        Me.invitacion.HeaderText = "Invitacion"
        Me.invitacion.Name = "invitacion"
        Me.invitacion.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Obsevaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Visible = False
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(20, 513)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 69)
        Me.cmd_nuevo.TabIndex = 72
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'lbl_contador_total
        '
        Me.lbl_contador_total.AutoSize = True
        Me.lbl_contador_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_total.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_contador_total.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_total.Location = New System.Drawing.Point(653, 501)
        Me.lbl_contador_total.Name = "lbl_contador_total"
        Me.lbl_contador_total.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_total.TabIndex = 77
        '
        'lbl_invitados
        '
        Me.lbl_invitados.AutoSize = True
        Me.lbl_invitados.BackColor = System.Drawing.Color.Transparent
        Me.lbl_invitados.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_invitados.ForeColor = System.Drawing.Color.White
        Me.lbl_invitados.Location = New System.Drawing.Point(541, 501)
        Me.lbl_invitados.Name = "lbl_invitados"
        Me.lbl_invitados.Size = New System.Drawing.Size(93, 16)
        Me.lbl_invitados.TabIndex = 76
        Me.lbl_invitados.Text = "Total Invitados:"
        '
        'Registrar_invitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1078, 598)
        Me.Controls.Add(Me.lbl_contador_total)
        Me.Controls.Add(Me.lbl_invitados)
        Me.Controls.Add(Me.dgv_efectores)
        Me.Controls.Add(Me.dgv_capas)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_datos_capacitacion)
        Me.Controls.Add(Me.cmd_salir)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.KeyPreview = True
        Me.Name = "Registrar_invitaciones"
        Me.Text = "INVITACIONES"
        Me.grp_datos_capacitacion.ResumeLayout(False)
        Me.grp_datos_capacitacion.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_efectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar_invitado As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_invitado As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_invitado As System.Windows.Forms.Button
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents grp_datos_capacitacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscar_capacitaciones As System.Windows.Forms.Button
    Friend WithEvents txt_lugar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_perdidas As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_efectiva As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_capacitaciones As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_capacitacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents chk_confirmada As System.Windows.Forms.CheckBox
    Friend WithEvents chk_enviada As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_capas As System.Windows.Forms.DataGridView
    Friend WithEvents fecha_programada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_efectores As System.Windows.Forms.DataGridView
    Friend WithEvents tltp_efectores As System.Windows.Forms.ToolTip
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vacunatorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_contador_total As System.Windows.Forms.Label
    Friend WithEvents lbl_invitados As System.Windows.Forms.Label
End Class
