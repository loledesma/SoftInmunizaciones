﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_recordatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_recordatorio))
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.grp_datos_recordatorio = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fechaEvento = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_prioridad = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_estado_atencion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_recordatorio = New System.Windows.Forms.TextBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.lbl_contador_pendientes = New System.Windows.Forms.Label()
        Me.lbl_registradas_hoy = New System.Windows.Forms.Label()
        Me.lbl_contador_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.dgv_recordatorios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_cambioGrilla = New System.Windows.Forms.Button()
        Me.grp_datos_recordatorio.SuspendLayout()
        Me.grp_descripcion.SuspendLayout()
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(7, 18)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(705, 215)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'grp_datos_recordatorio
        '
        Me.grp_datos_recordatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_recordatorio.Controls.Add(Me.Label4)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fechaEvento)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_prioridad)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label2)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_empleados)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label1)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_estado_atencion)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_id_recordatorio)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_estado)
        Me.grp_datos_recordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_recordatorio.Location = New System.Drawing.Point(14, 14)
        Me.grp_datos_recordatorio.Name = "grp_datos_recordatorio"
        Me.grp_datos_recordatorio.Size = New System.Drawing.Size(470, 241)
        Me.grp_datos_recordatorio.TabIndex = 0
        Me.grp_datos_recordatorio.TabStop = False
        Me.grp_datos_recordatorio.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Fecha evento"
        '
        'txt_fechaEvento
        '
        Me.txt_fechaEvento.Location = New System.Drawing.Point(127, 54)
        Me.txt_fechaEvento.Mask = "00/00/0000"
        Me.txt_fechaEvento.Name = "txt_fechaEvento"
        Me.txt_fechaEvento.Size = New System.Drawing.Size(112, 22)
        Me.txt_fechaEvento.TabIndex = 1
        Me.txt_fechaEvento.ValidatingType = GetType(Date)
        '
        'cmb_prioridad
        '
        Me.cmb_prioridad._descripcion = "descripcion"
        Me.cmb_prioridad._nombre_tabla = "PRIORIDADES"
        Me.cmb_prioridad._pk = "id"
        Me.cmb_prioridad.FormattingEnabled = True
        Me.cmb_prioridad.Location = New System.Drawing.Point(126, 118)
        Me.cmb_prioridad.Name = "cmb_prioridad"
        Me.cmb_prioridad.Size = New System.Drawing.Size(158, 23)
        Me.cmb_prioridad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Prioridad"
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
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(425, 83)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(29, 29)
        Me.cmd_actualizar_estado.TabIndex = 6
        Me.cmd_actualizar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar_estado.UseVisualStyleBackColor = False
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackgroundImage = CType(resources.GetObject("cmd_buscar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar.FlatAppearance.BorderSize = 0
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar.Location = New System.Drawing.Point(412, 18)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(43, 42)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmb_empleados
        '
        Me.cmb_empleados._descripcion = "nombres"
        Me.cmb_empleados._nombre_tabla = "EMPLEADOS"
        Me.cmb_empleados._pk = "id"
        Me.cmb_empleados.FormattingEnabled = True
        Me.cmb_empleados.Location = New System.Drawing.Point(126, 150)
        Me.cmb_empleados.Name = "cmb_empleados"
        Me.cmb_empleados.Size = New System.Drawing.Size(325, 23)
        Me.cmb_empleados.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Administrador"
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(8, 28)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(19, 16)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id"
        '
        'cmb_estado_atencion
        '
        Me.cmb_estado_atencion._descripcion = "descripcion"
        Me.cmb_estado_atencion._nombre_tabla = "ESTADOS_ATENCION"
        Me.cmb_estado_atencion._pk = "id"
        Me.cmb_estado_atencion.FormattingEnabled = True
        Me.cmb_estado_atencion.Location = New System.Drawing.Point(126, 87)
        Me.cmb_estado_atencion.Name = "cmb_estado_atencion"
        Me.cmb_estado_atencion.Size = New System.Drawing.Size(287, 23)
        Me.cmb_estado_atencion.TabIndex = 2
        '
        'txt_id_recordatorio
        '
        Me.txt_id_recordatorio.Location = New System.Drawing.Point(127, 24)
        Me.txt_id_recordatorio.Name = "txt_id_recordatorio"
        Me.txt_id_recordatorio.Size = New System.Drawing.Size(158, 22)
        Me.txt_id_recordatorio.TabIndex = 0
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(7, 91)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(96, 16)
        Me.lbl_estado.TabIndex = 30
        Me.lbl_estado.Text = "Estado Atención"
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(182, 537)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(70, 69)
        Me.cmd_eliminar.TabIndex = 3
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(254, 538)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5)
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
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar.Location = New System.Drawing.Point(98, 537)
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
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(19, 537)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 69)
        Me.cmd_nuevo.TabIndex = 5
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(1163, 537)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 69)
        Me.cmd_salir.TabIndex = 7
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'lbl_contador_pendientes
        '
        Me.lbl_contador_pendientes.AutoSize = True
        Me.lbl_contador_pendientes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_pendientes.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_contador_pendientes.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_pendientes.Location = New System.Drawing.Point(685, 565)
        Me.lbl_contador_pendientes.Name = "lbl_contador_pendientes"
        Me.lbl_contador_pendientes.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_pendientes.TabIndex = 58
        '
        'lbl_registradas_hoy
        '
        Me.lbl_registradas_hoy.AutoSize = True
        Me.lbl_registradas_hoy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_registradas_hoy.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_registradas_hoy.ForeColor = System.Drawing.Color.White
        Me.lbl_registradas_hoy.Location = New System.Drawing.Point(491, 563)
        Me.lbl_registradas_hoy.Name = "lbl_registradas_hoy"
        Me.lbl_registradas_hoy.Size = New System.Drawing.Size(153, 16)
        Me.lbl_registradas_hoy.TabIndex = 57
        Me.lbl_registradas_hoy.Text = "Recordatorios Pendientes:"
        '
        'lbl_contador_total
        '
        Me.lbl_contador_total.AutoSize = True
        Me.lbl_contador_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_total.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_contador_total.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_total.Location = New System.Drawing.Point(636, 522)
        Me.lbl_contador_total.Name = "lbl_contador_total"
        Me.lbl_contador_total.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_total.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(491, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total Recordatorios:"
        '
        'grp_descripcion
        '
        Me.grp_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_descripcion.Location = New System.Drawing.Point(513, 14)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(720, 241)
        Me.grp_descripcion.TabIndex = 1
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripción"
        '
        'dgv_recordatorios
        '
        Me.dgv_recordatorios.AllowUserToAddRows = False
        Me.dgv_recordatorios.AllowUserToDeleteRows = False
        Me.dgv_recordatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recordatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.fecha_evento, Me.imagen, Me.estado, Me.id_estado, Me.id_administrador, Me.administrador, Me.prioridad, Me.descripcion})
        Me.dgv_recordatorios.Location = New System.Drawing.Point(14, 262)
        Me.dgv_recordatorios.Name = "dgv_recordatorios"
        Me.dgv_recordatorios.ReadOnly = True
        Me.dgv_recordatorios.Size = New System.Drawing.Size(1219, 253)
        Me.dgv_recordatorios.TabIndex = 10
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha registro"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'fecha_evento
        '
        Me.fecha_evento.HeaderText = "Fecha del evento"
        Me.fecha_evento.Name = "fecha_evento"
        Me.fecha_evento.ReadOnly = True
        '
        'imagen
        '
        Me.imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.imagen.FillWeight = 200.0!
        Me.imagen.HeaderText = "Imagen"
        Me.imagen.MinimumWidth = 100
        Me.imagen.Name = "imagen"
        Me.imagen.ReadOnly = True
        Me.imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'id_estado
        '
        Me.id_estado.HeaderText = "id_estado"
        Me.id_estado.Name = "id_estado"
        Me.id_estado.ReadOnly = True
        Me.id_estado.Visible = False
        '
        'id_administrador
        '
        Me.id_administrador.HeaderText = "id_administrador"
        Me.id_administrador.Name = "id_administrador"
        Me.id_administrador.ReadOnly = True
        Me.id_administrador.Visible = False
        '
        'administrador
        '
        Me.administrador.HeaderText = "Administrador"
        Me.administrador.Name = "administrador"
        Me.administrador.ReadOnly = True
        Me.administrador.Width = 150
        '
        'prioridad
        '
        Me.prioridad.HeaderText = "Prioridad"
        Me.prioridad.Name = "prioridad"
        Me.prioridad.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 450
        '
        'cmb_cambioGrilla
        '
        Me.cmb_cambioGrilla.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cambioGrilla.BackgroundImage = CType(resources.GetObject("cmb_cambioGrilla.BackgroundImage"), System.Drawing.Image)
        Me.cmb_cambioGrilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_cambioGrilla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmb_cambioGrilla.FlatAppearance.BorderSize = 0
        Me.cmb_cambioGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_cambioGrilla.Location = New System.Drawing.Point(962, 537)
        Me.cmb_cambioGrilla.Name = "cmb_cambioGrilla"
        Me.cmb_cambioGrilla.Size = New System.Drawing.Size(70, 69)
        Me.cmb_cambioGrilla.TabIndex = 6
        Me.cmb_cambioGrilla.UseVisualStyleBackColor = False
        '
        'Registrar_recordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cmd_salir
        Me.ClientSize = New System.Drawing.Size(1246, 621)
        Me.Controls.Add(Me.cmb_cambioGrilla)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.lbl_contador_pendientes)
        Me.Controls.Add(Me.lbl_registradas_hoy)
        Me.Controls.Add(Me.lbl_contador_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_datos_recordatorio)
        Me.Controls.Add(Me.dgv_recordatorios)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Name = "Registrar_recordatorio"
        Me.Text = "TABLERO DE PENDIENTES"
        Me.grp_datos_recordatorio.ResumeLayout(False)
        Me.grp_datos_recordatorio.PerformLayout()
        Me.grp_descripcion.ResumeLayout(False)
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_datos_recordatorio As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_atencion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_recordatorio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_contador_pendientes As System.Windows.Forms.Label
    Friend WithEvents lbl_registradas_hoy As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_total As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_recordatorios As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_prioridad As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fechaEvento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_cambioGrilla As System.Windows.Forms.Button
End Class
