﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Actividades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Actividades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_contador_efectores = New System.Windows.Forms.Label()
        Me.dgv_capas = New System.Windows.Forms.DataGridView()
        Me.fecha_programada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgv_actividades = New System.Windows.Forms.DataGridView()
        Me.id_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tomada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.en_curso = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.realizada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_etapas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmd_actualizar = New System.Windows.Forms.Button()
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_capacitacion.SuspendLayout()
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmd_salir.Location = New System.Drawing.Point(978, 576)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 69)
        Me.cmd_salir.TabIndex = 5
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(187, 576)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 69)
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
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(107, 577)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(28, 577)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 69)
        Me.cmd_nuevo.TabIndex = 3
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'lbl_contador_efectores
        '
        Me.lbl_contador_efectores.AutoSize = True
        Me.lbl_contador_efectores.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_efectores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_efectores.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_efectores.Location = New System.Drawing.Point(834, 342)
        Me.lbl_contador_efectores.Name = "lbl_contador_efectores"
        Me.lbl_contador_efectores.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_efectores.TabIndex = 53
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
        Me.dgv_capas.Location = New System.Drawing.Point(531, 14)
        Me.dgv_capas.Name = "dgv_capas"
        Me.dgv_capas.ReadOnly = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgv_capas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_capas.Size = New System.Drawing.Size(517, 170)
        Me.dgv_capas.TabIndex = 76
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
        Me.grp_datos_capacitacion.Location = New System.Drawing.Point(14, 12)
        Me.grp_datos_capacitacion.Name = "grp_datos_capacitacion"
        Me.grp_datos_capacitacion.Size = New System.Drawing.Size(488, 172)
        Me.grp_datos_capacitacion.TabIndex = 75
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
        'dgv_actividades
        '
        Me.dgv_actividades.AllowUserToAddRows = False
        Me.dgv_actividades.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_actividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad, Me.actividad, Me.tomada, Me.en_curso, Me.realizada, Me.observaciones})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_actividades.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_actividades.Location = New System.Drawing.Point(19, 237)
        Me.dgv_actividades.Name = "dgv_actividades"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgv_actividades.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_actividades.Size = New System.Drawing.Size(1029, 328)
        Me.dgv_actividades.TabIndex = 77
        '
        'id_actividad
        '
        Me.id_actividad.HeaderText = "id_actividad"
        Me.id_actividad.Name = "id_actividad"
        Me.id_actividad.Visible = False
        '
        'actividad
        '
        Me.actividad.HeaderText = "Actividad"
        Me.actividad.Name = "actividad"
        Me.actividad.Width = 300
        '
        'tomada
        '
        Me.tomada.HeaderText = "Tomada"
        Me.tomada.Name = "tomada"
        Me.tomada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tomada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'en_curso
        '
        Me.en_curso.HeaderText = "En Curso"
        Me.en_curso.Name = "en_curso"
        Me.en_curso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.en_curso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'realizada
        '
        Me.realizada.HeaderText = "Realizada"
        Me.realizada.Name = "realizada"
        Me.realizada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.realizada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(20, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Etapas"
        '
        'cmb_etapas
        '
        Me.cmb_etapas._descripcion = "descripcion"
        Me.cmb_etapas._nombre_tabla = "ETAPAS"
        Me.cmb_etapas._pk = "id"
        Me.cmb_etapas.FormattingEnabled = True
        Me.cmb_etapas.Location = New System.Drawing.Point(142, 200)
        Me.cmb_etapas.Name = "cmb_etapas"
        Me.cmb_etapas.Size = New System.Drawing.Size(251, 23)
        Me.cmb_etapas.TabIndex = 64
        '
        'cmd_actualizar
        '
        Me.cmd_actualizar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_actualizar.BackgroundImage = CType(resources.GetObject("cmd_actualizar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_actualizar.FlatAppearance.BorderSize = 0
        Me.cmd_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actualizar.Location = New System.Drawing.Point(412, 200)
        Me.cmd_actualizar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_actualizar.Name = "cmd_actualizar"
        Me.cmd_actualizar.Size = New System.Drawing.Size(29, 29)
        Me.cmd_actualizar.TabIndex = 78
        Me.cmd_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar.UseVisualStyleBackColor = False
        '
        'Registrar_Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1069, 655)
        Me.Controls.Add(Me.cmd_actualizar)
        Me.Controls.Add(Me.cmb_etapas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_actividades)
        Me.Controls.Add(Me.dgv_capas)
        Me.Controls.Add(Me.grp_datos_capacitacion)
        Me.Controls.Add(Me.lbl_contador_efectores)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.KeyPreview = True
        Me.Name = "Registrar_Actividades"
        Me.Text = "ACTIVIDADES"
        CType(Me.dgv_capas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_capacitacion.ResumeLayout(False)
        Me.grp_datos_capacitacion.PerformLayout()
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents lbl_contador_efectores As System.Windows.Forms.Label
    Friend WithEvents dgv_capas As System.Windows.Forms.DataGridView
    Friend WithEvents fecha_programada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents dgv_actividades As System.Windows.Forms.DataGridView
    Friend WithEvents id_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tomada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents en_curso As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents realizada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_etapas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmd_actualizar As System.Windows.Forms.Button
End Class
