<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_peticiones_desarrollos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_peticiones_desarrollos))
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_datos_recordatorio = New System.Windows.Forms.GroupBox()
        Me.txt_desarrollador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha_solucion = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecha_solucion = New System.Windows.Forms.Label()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_estado_pedido = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_desarrollo = New System.Windows.Forms.TextBox()
        Me.txt_fecha_pedido = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_solicitado = New System.Windows.Forms.RichTextBox()
        Me.grp_respuesta = New System.Windows.Forms.GroupBox()
        Me.txt_respuesta = New System.Windows.Forms.RichTextBox()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desarrollador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_solucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.solicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.respuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_contador_pendientes = New System.Windows.Forms.Label()
        Me.lbl_registradas_hoy = New System.Windows.Forms.Label()
        Me.lbl_contador_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grp_datos_recordatorio.SuspendLayout()
        Me.grp_descripcion.SuspendLayout()
        Me.grp_respuesta.SuspendLayout()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(182, 490)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(70, 60)
        Me.cmd_eliminar.TabIndex = 19
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(254, 491)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 60)
        Me.cmd_limpiar.TabIndex = 20
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
        Me.cmd_guardar.Location = New System.Drawing.Point(98, 490)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 60)
        Me.cmd_guardar.TabIndex = 17
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(19, 490)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 60)
        Me.cmd_nuevo.TabIndex = 18
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
        Me.cmd_salir.Location = New System.Drawing.Point(1095, 493)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 60)
        Me.cmd_salir.TabIndex = 21
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'grp_datos_recordatorio
        '
        Me.grp_datos_recordatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_desarrollador)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label2)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_solucion)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_fecha_solucion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_empleados)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label1)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_estado_pedido)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_id_desarrollo)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_pedido)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_estado)
        Me.grp_datos_recordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_recordatorio.Location = New System.Drawing.Point(14, 12)
        Me.grp_datos_recordatorio.Name = "grp_datos_recordatorio"
        Me.grp_datos_recordatorio.Size = New System.Drawing.Size(470, 197)
        Me.grp_datos_recordatorio.TabIndex = 0
        Me.grp_datos_recordatorio.TabStop = False
        Me.grp_datos_recordatorio.Text = "Peticiones de Desarrollo"
        '
        'txt_desarrollador
        '
        Me.txt_desarrollador.Location = New System.Drawing.Point(127, 103)
        Me.txt_desarrollador.Name = "txt_desarrollador"
        Me.txt_desarrollador.Size = New System.Drawing.Size(326, 21)
        Me.txt_desarrollador.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Desarrollador"
        '
        'txt_fecha_solucion
        '
        Me.txt_fecha_solucion.Location = New System.Drawing.Point(128, 73)
        Me.txt_fecha_solucion.Mask = "00/00/0000"
        Me.txt_fecha_solucion.Name = "txt_fecha_solucion"
        Me.txt_fecha_solucion.Size = New System.Drawing.Size(112, 21)
        Me.txt_fecha_solucion.TabIndex = 3
        Me.txt_fecha_solucion.ValidatingType = GetType(Date)
        '
        'lbl_fecha_solucion
        '
        Me.lbl_fecha_solucion.AutoSize = True
        Me.lbl_fecha_solucion.Location = New System.Drawing.Point(7, 78)
        Me.lbl_fecha_solucion.Name = "lbl_fecha_solucion"
        Me.lbl_fecha_solucion.Size = New System.Drawing.Size(92, 13)
        Me.lbl_fecha_solucion.TabIndex = 54
        Me.lbl_fecha_solucion.Text = "Fecha Solucion"
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
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(426, 131)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(29, 25)
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
        Me.cmd_buscar.Location = New System.Drawing.Point(412, 16)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(43, 36)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmb_empleados
        '
        Me.cmb_empleados._descripcion = "nombres"
        Me.cmb_empleados._nombre_tabla = "EMPLEADOS"
        Me.cmb_empleados._pk = "id"
        Me.cmb_empleados.FormattingEnabled = True
        Me.cmb_empleados.Location = New System.Drawing.Point(129, 166)
        Me.cmb_empleados.Name = "cmb_empleados"
        Me.cmb_empleados.Size = New System.Drawing.Size(325, 21)
        Me.cmb_empleados.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Administrador"
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(8, 24)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(19, 13)
        Me.lbl_id_notificacion.TabIndex = 52
        Me.lbl_id_notificacion.Text = "Id"
        '
        'cmb_estado_pedido
        '
        Me.cmb_estado_pedido._descripcion = "descripcion"
        Me.cmb_estado_pedido._nombre_tabla = "ESTADOS_PEDIDOS"
        Me.cmb_estado_pedido._pk = "id"
        Me.cmb_estado_pedido.FormattingEnabled = True
        Me.cmb_estado_pedido.Location = New System.Drawing.Point(129, 134)
        Me.cmb_estado_pedido.Name = "cmb_estado_pedido"
        Me.cmb_estado_pedido.Size = New System.Drawing.Size(287, 21)
        Me.cmb_estado_pedido.TabIndex = 5
        '
        'txt_id_desarrollo
        '
        Me.txt_id_desarrollo.Location = New System.Drawing.Point(127, 21)
        Me.txt_id_desarrollo.Name = "txt_id_desarrollo"
        Me.txt_id_desarrollo.Size = New System.Drawing.Size(158, 21)
        Me.txt_id_desarrollo.TabIndex = 0
        '
        'txt_fecha_pedido
        '
        Me.txt_fecha_pedido.Location = New System.Drawing.Point(128, 47)
        Me.txt_fecha_pedido.Mask = "00/00/0000"
        Me.txt_fecha_pedido.Name = "txt_fecha_pedido"
        Me.txt_fecha_pedido.Size = New System.Drawing.Size(112, 21)
        Me.txt_fecha_pedido.TabIndex = 2
        Me.txt_fecha_pedido.ValidatingType = GetType(Date)
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(8, 52)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(82, 13)
        Me.lbl_perfil.TabIndex = 49
        Me.lbl_perfil.Text = "Fecha Pedido"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(8, 138)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(87, 13)
        Me.lbl_estado.TabIndex = 30
        Me.lbl_estado.Text = "Estado Pedido"
        '
        'grp_descripcion
        '
        Me.grp_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.grp_descripcion.Controls.Add(Me.txt_solicitado)
        Me.grp_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_descripcion.Location = New System.Drawing.Point(15, 219)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(469, 139)
        Me.grp_descripcion.TabIndex = 23
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Solicitado"
        '
        'txt_solicitado
        '
        Me.txt_solicitado.Location = New System.Drawing.Point(10, 17)
        Me.txt_solicitado.Name = "txt_solicitado"
        Me.txt_solicitado.Size = New System.Drawing.Size(441, 116)
        Me.txt_solicitado.TabIndex = 0
        Me.txt_solicitado.Text = ""
        '
        'grp_respuesta
        '
        Me.grp_respuesta.BackColor = System.Drawing.Color.Transparent
        Me.grp_respuesta.Controls.Add(Me.txt_respuesta)
        Me.grp_respuesta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_respuesta.Location = New System.Drawing.Point(14, 364)
        Me.grp_respuesta.Name = "grp_respuesta"
        Me.grp_respuesta.Size = New System.Drawing.Size(469, 119)
        Me.grp_respuesta.TabIndex = 24
        Me.grp_respuesta.TabStop = False
        Me.grp_respuesta.Text = "Respuesta"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(10, 18)
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(441, 94)
        Me.txt_respuesta.TabIndex = 0
        Me.txt_respuesta.Text = ""
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToAddRows = False
        Me.dgv_pedidos.AllowUserToDeleteRows = False
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.desarrollador, Me.fecha_pedido, Me.fecha_solucion, Me.estado, Me.id_estado, Me.id_administrador, Me.administrador, Me.solicitado, Me.respuesta})
        Me.dgv_pedidos.Location = New System.Drawing.Point(509, 20)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.ReadOnly = True
        Me.dgv_pedidos.Size = New System.Drawing.Size(657, 467)
        Me.dgv_pedidos.TabIndex = 25
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'desarrollador
        '
        Me.desarrollador.HeaderText = "Desarollador"
        Me.desarrollador.Name = "desarrollador"
        Me.desarrollador.ReadOnly = True
        '
        'fecha_pedido
        '
        Me.fecha_pedido.HeaderText = "Fecha Pedido"
        Me.fecha_pedido.Name = "fecha_pedido"
        Me.fecha_pedido.ReadOnly = True
        '
        'fecha_solucion
        '
        Me.fecha_solucion.HeaderText = "Fecha Solucion"
        Me.fecha_solucion.Name = "fecha_solucion"
        Me.fecha_solucion.ReadOnly = True
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
        'solicitado
        '
        Me.solicitado.HeaderText = "Solicitado"
        Me.solicitado.Name = "solicitado"
        Me.solicitado.ReadOnly = True
        Me.solicitado.Width = 200
        '
        'respuesta
        '
        Me.respuesta.HeaderText = "Respuesta"
        Me.respuesta.Name = "respuesta"
        Me.respuesta.ReadOnly = True
        '
        'lbl_contador_pendientes
        '
        Me.lbl_contador_pendientes.AutoSize = True
        Me.lbl_contador_pendientes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_pendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_pendientes.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_pendientes.Location = New System.Drawing.Point(817, 533)
        Me.lbl_contador_pendientes.Name = "lbl_contador_pendientes"
        Me.lbl_contador_pendientes.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_pendientes.TabIndex = 58
        '
        'lbl_registradas_hoy
        '
        Me.lbl_registradas_hoy.AutoSize = True
        Me.lbl_registradas_hoy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_registradas_hoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registradas_hoy.ForeColor = System.Drawing.Color.White
        Me.lbl_registradas_hoy.Location = New System.Drawing.Point(528, 533)
        Me.lbl_registradas_hoy.Name = "lbl_registradas_hoy"
        Me.lbl_registradas_hoy.Size = New System.Drawing.Size(157, 17)
        Me.lbl_registradas_hoy.TabIndex = 57
        Me.lbl_registradas_hoy.Text = "Pedidos Pendientes:"
        '
        'lbl_contador_total
        '
        Me.lbl_contador_total.AutoSize = True
        Me.lbl_contador_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_total.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_total.Location = New System.Drawing.Point(768, 496)
        Me.lbl_contador_total.Name = "lbl_contador_total"
        Me.lbl_contador_total.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_total.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(528, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total:"
        '
        'Registrar_peticiones_desarrollos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1179, 564)
        Me.Controls.Add(Me.lbl_contador_pendientes)
        Me.Controls.Add(Me.lbl_registradas_hoy)
        Me.Controls.Add(Me.lbl_contador_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Controls.Add(Me.grp_respuesta)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.grp_datos_recordatorio)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Registrar_peticiones_desarrollos"
        Me.Text = "PETICIONES DESARROLLO"
        Me.grp_datos_recordatorio.ResumeLayout(False)
        Me.grp_datos_recordatorio.PerformLayout()
        Me.grp_descripcion.ResumeLayout(False)
        Me.grp_respuesta.ResumeLayout(False)
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_datos_recordatorio As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_pedido As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_desarrollo As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_pedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_solicitado As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_desarrollador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_solucion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fecha_solucion As System.Windows.Forms.Label
    Friend WithEvents grp_respuesta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_respuesta As System.Windows.Forms.RichTextBox
    Friend WithEvents dgv_pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desarrollador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_solucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents solicitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents respuesta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_contador_pendientes As System.Windows.Forms.Label
    Friend WithEvents lbl_registradas_hoy As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_total As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
