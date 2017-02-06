<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_entrega_insumos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_entrega_insumos))
        Me.grp_datos_recordatorio = New System.Windows.Forms.GroupBox()
        Me.txt_solicitado = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_buscar_empleado = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.txt_fecha_solucion = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecha_entrega = New System.Windows.Forms.Label()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_autorizador = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_autoriza = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_estado_pedido = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_desarrollo = New System.Windows.Forms.TextBox()
        Me.txt_fecha_pedido = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_limpiar_insumo = New System.Windows.Forms.Button()
        Me.cmd_eliminar_insumo = New System.Windows.Forms.Button()
        Me.cmd_agregar_insumo = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_insumos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_entrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmd_busca_efector = New System.Windows.Forms.Button()
        Me.grp_datos_recordatorio.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_recordatorio
        '
        Me.grp_datos_recordatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_busca_efector)
        Me.grp_datos_recordatorio.Controls.Add(Me.TextBox2)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label6)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_solicitado)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label5)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_apellido)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label4)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label2)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_buscar_empleado)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_nombre)
        Me.grp_datos_recordatorio.Controls.Add(Me.TextBox1)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label1)
        Me.grp_datos_recordatorio.Controls.Add(Me.dgv_empleados)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_solucion)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_fecha_entrega)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_autorizador)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_autoriza)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_estado_pedido)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_id_desarrollo)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_pedido)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_estado)
        Me.grp_datos_recordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_recordatorio.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_recordatorio.Name = "grp_datos_recordatorio"
        Me.grp_datos_recordatorio.Size = New System.Drawing.Size(983, 325)
        Me.grp_datos_recordatorio.TabIndex = 23
        Me.grp_datos_recordatorio.TabStop = False
        Me.grp_datos_recordatorio.Text = "Entrega"
        '
        'txt_solicitado
        '
        Me.txt_solicitado.Location = New System.Drawing.Point(108, 238)
        Me.txt_solicitado.Name = "txt_solicitado"
        Me.txt_solicitado.Size = New System.Drawing.Size(283, 81)
        Me.txt_solicitado.TabIndex = 69
        Me.txt_solicitado.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Observaciones"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(108, 212)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(283, 20)
        Me.txt_apellido.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre"
        '
        'cmb_buscar_empleado
        '
        Me.cmb_buscar_empleado.BackgroundImage = CType(resources.GetObject("cmb_buscar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmb_buscar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_buscar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_buscar_empleado.Location = New System.Drawing.Point(213, 155)
        Me.cmb_buscar_empleado.Name = "cmb_buscar_empleado"
        Me.cmb_buscar_empleado.Size = New System.Drawing.Size(20, 20)
        Me.cmb_buscar_empleado.TabIndex = 64
        Me.cmb_buscar_empleado.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(108, 182)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(283, 20)
        Me.txt_nombre.TabIndex = 63
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 20)
        Me.TextBox1.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Recibe"
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha_pedido, Me.fecha_entrega, Me.autoriza, Me.id_autoriza, Me.cuie, Me.efector})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_empleados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_empleados.Location = New System.Drawing.Point(418, 19)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.Size = New System.Drawing.Size(559, 300)
        Me.dgv_empleados.TabIndex = 60
        '
        'txt_fecha_solucion
        '
        Me.txt_fecha_solucion.Location = New System.Drawing.Point(315, 48)
        Me.txt_fecha_solucion.Mask = "00/00/0000"
        Me.txt_fecha_solucion.Name = "txt_fecha_solucion"
        Me.txt_fecha_solucion.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_solucion.TabIndex = 55
        Me.txt_fecha_solucion.ValidatingType = GetType(Date)
        '
        'lbl_fecha_entrega
        '
        Me.lbl_fecha_entrega.AutoSize = True
        Me.lbl_fecha_entrega.Location = New System.Drawing.Point(211, 53)
        Me.lbl_fecha_entrega.Name = "lbl_fecha_entrega"
        Me.lbl_fecha_entrega.Size = New System.Drawing.Size(77, 13)
        Me.lbl_fecha_entrega.TabIndex = 54
        Me.lbl_fecha_entrega.Text = "Fecha Entrega"
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
        Me.cmd_actualizar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(364, 95)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_actualizar_estado.TabIndex = 4
        Me.cmd_actualizar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar_estado.UseVisualStyleBackColor = False
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackgroundImage = CType(resources.GetObject("cmd_buscar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.Location = New System.Drawing.Point(252, 14)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(36, 33)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmb_autorizador
        '
        Me.cmb_autorizador._descripcion = "nombres"
        Me.cmb_autorizador._nombre_tabla = "EMPLEADOS"
        Me.cmb_autorizador._pk = "id"
        Me.cmb_autorizador.FormattingEnabled = True
        Me.cmb_autorizador.Location = New System.Drawing.Point(108, 127)
        Me.cmb_autorizador.Name = "cmb_autorizador"
        Me.cmb_autorizador.Size = New System.Drawing.Size(279, 21)
        Me.cmb_autorizador.TabIndex = 5
        '
        'lbl_autoriza
        '
        Me.lbl_autoriza.AutoSize = True
        Me.lbl_autoriza.Location = New System.Drawing.Point(5, 130)
        Me.lbl_autoriza.Name = "lbl_autoriza"
        Me.lbl_autoriza.Size = New System.Drawing.Size(45, 13)
        Me.lbl_autoriza.TabIndex = 53
        Me.lbl_autoriza.Text = "Autoriza"
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
        'cmb_estado_pedido
        '
        Me.cmb_estado_pedido._descripcion = "descripcion"
        Me.cmb_estado_pedido._nombre_tabla = "ESTADO_ENTREGA"
        Me.cmb_estado_pedido._pk = "id"
        Me.cmb_estado_pedido.FormattingEnabled = True
        Me.cmb_estado_pedido.Location = New System.Drawing.Point(108, 99)
        Me.cmb_estado_pedido.Name = "cmb_estado_pedido"
        Me.cmb_estado_pedido.Size = New System.Drawing.Size(247, 21)
        Me.cmb_estado_pedido.TabIndex = 3
        '
        'txt_id_desarrollo
        '
        Me.txt_id_desarrollo.Location = New System.Drawing.Point(109, 21)
        Me.txt_id_desarrollo.Name = "txt_id_desarrollo"
        Me.txt_id_desarrollo.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_desarrollo.TabIndex = 0
        '
        'txt_fecha_pedido
        '
        Me.txt_fecha_pedido.Location = New System.Drawing.Point(109, 47)
        Me.txt_fecha_pedido.Mask = "00/00/0000"
        Me.txt_fecha_pedido.Name = "txt_fecha_pedido"
        Me.txt_fecha_pedido.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_pedido.TabIndex = 2
        Me.txt_fecha_pedido.ValidatingType = GetType(Date)
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(7, 52)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(73, 13)
        Me.lbl_perfil.TabIndex = 49
        Me.lbl_perfil.Text = "Fecha Pedido"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(6, 103)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(76, 13)
        Me.lbl_estado.TabIndex = 30
        Me.lbl_estado.Text = "Estado Pedido"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar_insumo)
        Me.GroupBox1.Controls.Add(Me.cmd_eliminar_insumo)
        Me.GroupBox1.Controls.Add(Me.cmd_agregar_insumo)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_insumos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(6, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 138)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Entrega"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_insumo, Me.insumo, Me.cantidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(418, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(559, 101)
        Me.DataGridView1.TabIndex = 61
        '
        'id_insumo
        '
        Me.id_insumo.HeaderText = "Id Insumo"
        Me.id_insumo.Name = "id_insumo"
        Me.id_insumo.ReadOnly = True
        Me.id_insumo.Visible = False
        '
        'insumo
        '
        Me.insumo.HeaderText = "Insumo"
        Me.insumo.Name = "insumo"
        Me.insumo.ReadOnly = True
        Me.insumo.Width = 300
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'cmd_limpiar_insumo
        '
        Me.cmd_limpiar_insumo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_insumo.BackgroundImage = CType(resources.GetObject("cmd_limpiar_insumo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_insumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_insumo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_insumo.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_insumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_insumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_limpiar_insumo.Location = New System.Drawing.Point(308, 49)
        Me.cmd_limpiar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_insumo.Name = "cmd_limpiar_insumo"
        Me.cmd_limpiar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_insumo.TabIndex = 59
        Me.cmd_limpiar_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_insumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_insumo.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_insumo
        '
        Me.cmd_eliminar_insumo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_insumo.BackgroundImage = CType(resources.GetObject("cmd_eliminar_insumo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_insumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_insumo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_insumo.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_insumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_insumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_eliminar_insumo.Location = New System.Drawing.Point(371, 49)
        Me.cmd_eliminar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_insumo.Name = "cmd_eliminar_insumo"
        Me.cmd_eliminar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_insumo.TabIndex = 61
        Me.cmd_eliminar_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_insumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_insumo.UseVisualStyleBackColor = False
        '
        'cmd_agregar_insumo
        '
        Me.cmd_agregar_insumo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_insumo.BackgroundImage = CType(resources.GetObject("cmd_agregar_insumo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_insumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_insumo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_insumo.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_insumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_insumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_agregar_insumo.Location = New System.Drawing.Point(340, 49)
        Me.cmd_agregar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_insumo.Name = "cmd_agregar_insumo"
        Me.cmd_agregar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_insumo.TabIndex = 60
        Me.cmd_agregar_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_insumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_insumo.UseVisualStyleBackColor = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(109, 49)
        Me.txt_cantidad.Mask = "9999999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(98, 20)
        Me.txt_cantidad.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Cantidad"
        '
        'cmb_insumos
        '
        Me.cmb_insumos._descripcion = "descripcion"
        Me.cmb_insumos._nombre_tabla = "INSUMOS"
        Me.cmb_insumos._pk = "id"
        Me.cmb_insumos.FormattingEnabled = True
        Me.cmb_insumos.Location = New System.Drawing.Point(107, 19)
        Me.cmb_insumos.Name = "cmb_insumos"
        Me.cmb_insumos.Size = New System.Drawing.Size(247, 21)
        Me.cmb_insumos.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Insumo"
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(145, 513)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 62
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
        Me.cmd_guardar.Location = New System.Drawing.Point(77, 511)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 59
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(9, 511)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 60
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
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(935, 513)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 63
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'fecha_pedido
        '
        Me.fecha_pedido.HeaderText = "Fecha Pedido"
        Me.fecha_pedido.Name = "fecha_pedido"
        Me.fecha_pedido.ReadOnly = True
        '
        'fecha_entrega
        '
        Me.fecha_entrega.HeaderText = "Fecha Entrega"
        Me.fecha_entrega.Name = "fecha_entrega"
        Me.fecha_entrega.ReadOnly = True
        '
        'autoriza
        '
        Me.autoriza.HeaderText = "Autoriza"
        Me.autoriza.Name = "autoriza"
        Me.autoriza.ReadOnly = True
        Me.autoriza.Width = 200
        '
        'id_autoriza
        '
        Me.id_autoriza.HeaderText = "id_autoriza"
        Me.id_autoriza.Name = "id_autoriza"
        Me.id_autoriza.ReadOnly = True
        Me.id_autoriza.Visible = False
        '
        'cuie
        '
        Me.cuie.HeaderText = "id_efector"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Visible = False
        '
        'efector
        '
        Me.efector.HeaderText = "Efector"
        Me.efector.Name = "efector"
        Me.efector.ReadOnly = True
        Me.efector.Width = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cuie"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 20)
        Me.TextBox2.TabIndex = 71
        '
        'cmd_busca_efector
        '
        Me.cmd_busca_efector.BackgroundImage = CType(resources.GetObject("cmd_busca_efector.BackgroundImage"), System.Drawing.Image)
        Me.cmd_busca_efector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_busca_efector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_busca_efector.Location = New System.Drawing.Point(212, 72)
        Me.cmd_busca_efector.Name = "cmd_busca_efector"
        Me.cmd_busca_efector.Size = New System.Drawing.Size(20, 20)
        Me.cmd_busca_efector.TabIndex = 72
        Me.cmd_busca_efector.UseVisualStyleBackColor = True
        '
        'Registrar_entrega_insumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1007, 585)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_datos_recordatorio)
        Me.Name = "Registrar_entrega_insumos"
        Me.Text = "Entrega de Insumos"
        Me.grp_datos_recordatorio.ResumeLayout(False)
        Me.grp_datos_recordatorio.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_recordatorio As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fecha_solucion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fecha_entrega As System.Windows.Forms.Label
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_autorizador As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_autoriza As System.Windows.Forms.Label
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_pedido As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_desarrollo As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_pedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_insumos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_insumo As System.Windows.Forms.Button
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_buscar_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_solicitado As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_busca_efector As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_entrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autoriza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_autoriza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents efector As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
