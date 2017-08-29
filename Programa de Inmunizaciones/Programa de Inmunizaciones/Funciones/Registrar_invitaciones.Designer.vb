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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_invitaciones))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_limpiar_invitado = New System.Windows.Forms.Button()
        Me.cmd_eliminar_invitado = New System.Windows.Forms.Button()
        Me.cmd_agregar_invitado = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.grp_datos_capacitacion = New System.Windows.Forms.GroupBox()
        Me.dgv_capas = New System.Windows.Forms.DataGridView()
        Me.fecha_programada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgv_efectores = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacunatorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones2 = New System.Windows.Forms.RichTextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.grp_datos_capacitacion.SuspendLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.cmd_limpiar_invitado.Location = New System.Drawing.Point(330, 183)
        Me.cmd_limpiar_invitado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_invitado.Name = "cmd_limpiar_invitado"
        Me.cmd_limpiar_invitado.Size = New System.Drawing.Size(25, 25)
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
        Me.cmd_eliminar_invitado.Location = New System.Drawing.Point(393, 183)
        Me.cmd_eliminar_invitado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_invitado.Name = "cmd_eliminar_invitado"
        Me.cmd_eliminar_invitado.Size = New System.Drawing.Size(25, 25)
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
        Me.cmd_agregar_invitado.Location = New System.Drawing.Point(362, 183)
        Me.cmd_agregar_invitado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_invitado.Name = "cmd_agregar_invitado"
        Me.cmd_agregar_invitado.Size = New System.Drawing.Size(25, 25)
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
        Me.cmd_salir.Location = New System.Drawing.Point(819, 445)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(59, 53)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(131, 47)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(184, 20)
        Me.txt_cuie.TabIndex = 65
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(16, 48)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuie.TabIndex = 67
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(130, 19)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(282, 20)
        Me.txt_efectores.TabIndex = 64
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(14, 21)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(64, 13)
        Me.lbl_vacunatorio.TabIndex = 66
        Me.lbl_vacunatorio.Text = "Vacunatorio"
        '
        'grp_datos_capacitacion
        '
        Me.grp_datos_capacitacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_capacitacion.Controls.Add(Me.dgv_capas)
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
        Me.grp_datos_capacitacion.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_capacitacion.Name = "grp_datos_capacitacion"
        Me.grp_datos_capacitacion.Size = New System.Drawing.Size(866, 191)
        Me.grp_datos_capacitacion.TabIndex = 68
        Me.grp_datos_capacitacion.TabStop = False
        Me.grp_datos_capacitacion.Text = "Capacitacion"
        '
        'dgv_capas
        '
        Me.dgv_capas.AllowUserToAddRows = False
        Me.dgv_capas.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_capas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_capas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_capas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_programada, Me.tipo, Me.estado, Me.localidad})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_capas.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_capas.Location = New System.Drawing.Point(417, 15)
        Me.dgv_capas.Name = "dgv_capas"
        Me.dgv_capas.ReadOnly = True
        Me.dgv_capas.Size = New System.Drawing.Size(443, 157)
        Me.dgv_capas.TabIndex = 66
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
        'txt_lugar
        '
        Me.txt_lugar.Location = New System.Drawing.Point(110, 120)
        Me.txt_lugar.Name = "txt_lugar"
        Me.txt_lugar.Size = New System.Drawing.Size(268, 20)
        Me.txt_lugar.TabIndex = 0
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(5, 89)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(37, 13)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Fecha"
        '
        'txt_fecha_efectiva
        '
        Me.txt_fecha_efectiva.Location = New System.Drawing.Point(111, 85)
        Me.txt_fecha_efectiva.Mask = "00/00/0000"
        Me.txt_fecha_efectiva.Name = "txt_fecha_efectiva"
        Me.txt_fecha_efectiva.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_efectiva.TabIndex = 3
        Me.txt_fecha_efectiva.ValidatingType = GetType(Date)
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(6, 25)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(81, 13)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id Capacitacion"
        '
        'cmb_tipo_capacitaciones
        '
        Me.cmb_tipo_capacitaciones._descripcion = "descripcion"
        Me.cmb_tipo_capacitaciones._nombre_tabla = "TIPO_CAPACITACIONES"
        Me.cmb_tipo_capacitaciones._pk = "id"
        Me.cmb_tipo_capacitaciones.FormattingEnabled = True
        Me.cmb_tipo_capacitaciones.Location = New System.Drawing.Point(110, 51)
        Me.cmb_tipo_capacitaciones.Name = "cmb_tipo_capacitaciones"
        Me.cmb_tipo_capacitaciones.Size = New System.Drawing.Size(216, 21)
        Me.cmb_tipo_capacitaciones.TabIndex = 1
        '
        'txt_id_capacitacion
        '
        Me.txt_id_capacitacion.Location = New System.Drawing.Point(111, 22)
        Me.txt_id_capacitacion.Name = "txt_id_capacitacion"
        Me.txt_id_capacitacion.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_capacitacion.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Lugar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_confirmada)
        Me.GroupBox3.Controls.Add(Me.chk_enviada)
        Me.GroupBox3.Controls.Add(Me.dgv_efectores)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(866, 215)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invitado"
        '
        'chk_confirmada
        '
        Me.chk_confirmada.AutoSize = True
        Me.chk_confirmada.Location = New System.Drawing.Point(234, 86)
        Me.chk_confirmada.Name = "chk_confirmada"
        Me.chk_confirmada.Size = New System.Drawing.Size(79, 17)
        Me.chk_confirmada.TabIndex = 72
        Me.chk_confirmada.Text = "Confirmada"
        Me.chk_confirmada.UseVisualStyleBackColor = True
        '
        'chk_enviada
        '
        Me.chk_enviada.AutoSize = True
        Me.chk_enviada.Location = New System.Drawing.Point(132, 85)
        Me.chk_enviada.Name = "chk_enviada"
        Me.chk_enviada.Size = New System.Drawing.Size(65, 17)
        Me.chk_enviada.TabIndex = 71
        Me.chk_enviada.Text = "Enviada"
        Me.chk_enviada.UseVisualStyleBackColor = True
        '
        'dgv_efectores
        '
        Me.dgv_efectores.AllowUserToAddRows = False
        Me.dgv_efectores.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_efectores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_efectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_efectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.observaciones, Me.vacunatorio, Me.invitacion})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_efectores.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_efectores.Location = New System.Drawing.Point(418, 19)
        Me.dgv_efectores.Name = "dgv_efectores"
        Me.dgv_efectores.ReadOnly = True
        Me.dgv_efectores.Size = New System.Drawing.Size(443, 157)
        Me.dgv_efectores.TabIndex = 67
        '
        'cuie
        '
        Me.cuie.HeaderText = "Cuie"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Obsevaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Visible = False
        '
        'vacunatorio
        '
        Me.vacunatorio.HeaderText = "Vacunatorio"
        Me.vacunatorio.Name = "vacunatorio"
        Me.vacunatorio.ReadOnly = True
        '
        'invitacion
        '
        Me.invitacion.HeaderText = "Invitacion"
        Me.invitacion.Name = "invitacion"
        Me.invitacion.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Invitacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Observaciones"
        '
        'txt_observaciones2
        '
        Me.txt_observaciones2.Location = New System.Drawing.Point(132, 125)
        Me.txt_observaciones2.Name = "txt_observaciones2"
        Me.txt_observaciones2.Size = New System.Drawing.Size(280, 51)
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(153, 444)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
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
        Me.cmd_guardar.Location = New System.Drawing.Point(85, 445)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 71
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(17, 445)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 72
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'Registrar_invitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(924, 518)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_datos_capacitacion)
        Me.Controls.Add(Me.cmd_salir)
        Me.KeyPreview = True
        Me.Name = "Registrar_invitaciones"
        Me.Text = "INVITACIONES"
        Me.grp_datos_capacitacion.ResumeLayout(False)
        Me.grp_datos_capacitacion.PerformLayout()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_efectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents dgv_capas As System.Windows.Forms.DataGridView
    Friend WithEvents fecha_programada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_efectores As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents chk_confirmada As System.Windows.Forms.CheckBox
    Friend WithEvents chk_enviada As System.Windows.Forms.CheckBox
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vacunatorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invitacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
