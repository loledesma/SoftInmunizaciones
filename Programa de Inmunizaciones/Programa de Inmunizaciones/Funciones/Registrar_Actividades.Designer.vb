<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.cmb_tipo_capacitaciones = New Programa_de_Inmunizaciones.ComboBoxV1()
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
        Me.cmd_salir.Location = New System.Drawing.Point(838, 499)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(160, 499)
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
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(92, 500)
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
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(24, 500)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
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
        Me.lbl_contador_efectores.Location = New System.Drawing.Point(715, 296)
        Me.lbl_contador_efectores.Name = "lbl_contador_efectores"
        Me.lbl_contador_efectores.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_efectores.TabIndex = 53
        '
        'dgv_capas
        '
        Me.dgv_capas.AllowUserToAddRows = False
        Me.dgv_capas.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_capas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_capas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_capas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_programada, Me.tipo, Me.estado, Me.localidad})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_capas.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_capas.Location = New System.Drawing.Point(455, 12)
        Me.dgv_capas.Name = "dgv_capas"
        Me.dgv_capas.ReadOnly = True
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgv_capas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_capas.Size = New System.Drawing.Size(443, 159)
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
        Me.grp_datos_capacitacion.Location = New System.Drawing.Point(12, 10)
        Me.grp_datos_capacitacion.Name = "grp_datos_capacitacion"
        Me.grp_datos_capacitacion.Size = New System.Drawing.Size(418, 161)
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
        'dgv_actividades
        '
        Me.dgv_actividades.AllowUserToAddRows = False
        Me.dgv_actividades.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_actividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad, Me.actividad, Me.tomada, Me.en_curso, Me.realizada, Me.observaciones})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_actividades.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_actividades.Location = New System.Drawing.Point(16, 197)
        Me.dgv_actividades.Name = "dgv_actividades"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.dgv_actividades.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_actividades.Size = New System.Drawing.Size(882, 284)
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
        'Registrar_Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 568)
        Me.Controls.Add(Me.dgv_actividades)
        Me.Controls.Add(Me.dgv_capas)
        Me.Controls.Add(Me.grp_datos_capacitacion)
        Me.Controls.Add(Me.lbl_contador_efectores)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
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
End Class
