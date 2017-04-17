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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_entrega_insumos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp_datos_recordatorio = New System.Windows.Forms.GroupBox()
        Me.cmd_agregar_efector = New System.Windows.Forms.Button()
        Me.txt_nombre_efector = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_receptor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_entrega = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecha_entrega = New System.Windows.Forms.Label()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_autorizador = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_autoriza = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_estado_entrega = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_entrega = New System.Windows.Forms.TextBox()
        Me.txt_fecha_pedido = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.grp_detalle = New System.Windows.Forms.GroupBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_nro_serie = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_ver_stock = New System.Windows.Forms.Button()
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
        Me.dgv_entrega = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_entrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_autoriza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_detalle_entrega = New System.Windows.Forms.DataGridView()
        Me.id_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_recordatorio.SuspendLayout()
        Me.grp_detalle.SuspendLayout()
        CType(Me.dgv_entrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalle_entrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_recordatorio
        '
        Me.grp_datos_recordatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_agregar_efector)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_nombre_efector)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label7)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_cuie)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label6)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_observaciones)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label5)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_receptor)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label1)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_entrega)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_fecha_entrega)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_autorizador)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_autoriza)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_estado_entrega)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_id_entrega)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha_pedido)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_estado)
        Me.grp_datos_recordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_recordatorio.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_recordatorio.Name = "grp_datos_recordatorio"
        Me.grp_datos_recordatorio.Size = New System.Drawing.Size(420, 397)
        Me.grp_datos_recordatorio.TabIndex = 0
        Me.grp_datos_recordatorio.TabStop = False
        Me.grp_datos_recordatorio.Text = "Entrega y Pedido"
        '
        'cmd_agregar_efector
        '
        Me.cmd_agregar_efector.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_efector.BackgroundImage = CType(resources.GetObject("cmd_agregar_efector.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_efector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_efector.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_efector.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_efector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_efector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_efector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_efector.Location = New System.Drawing.Point(388, 74)
        Me.cmd_agregar_efector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_efector.Name = "cmd_agregar_efector"
        Me.cmd_agregar_efector.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_efector.TabIndex = 5
        Me.cmd_agregar_efector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_efector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_efector.UseVisualStyleBackColor = False
        '
        'txt_nombre_efector
        '
        Me.txt_nombre_efector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nombre_efector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nombre_efector.Location = New System.Drawing.Point(108, 76)
        Me.txt_nombre_efector.Name = "txt_nombre_efector"
        Me.txt_nombre_efector.Size = New System.Drawing.Size(271, 20)
        Me.txt_nombre_efector.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Efector"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(109, 105)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(78, 20)
        Me.txt_cuie.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cuie"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(109, 243)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(283, 141)
        Me.txt_observaciones.TabIndex = 14
        Me.txt_observaciones.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Observaciones"
        '
        'txt_receptor
        '
        Me.txt_receptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_receptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_receptor.Location = New System.Drawing.Point(109, 204)
        Me.txt_receptor.Name = "txt_receptor"
        Me.txt_receptor.Size = New System.Drawing.Size(283, 20)
        Me.txt_receptor.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Recibe"
        '
        'txt_fecha_entrega
        '
        Me.txt_fecha_entrega.Location = New System.Drawing.Point(310, 48)
        Me.txt_fecha_entrega.Mask = "00/00/0000"
        Me.txt_fecha_entrega.Name = "txt_fecha_entrega"
        Me.txt_fecha_entrega.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_entrega.TabIndex = 3
        Me.txt_fecha_entrega.ValidatingType = GetType(Date)
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
        Me.cmd_actualizar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(365, 135)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_actualizar_estado.TabIndex = 8
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
        Me.cmb_autorizador.Location = New System.Drawing.Point(109, 167)
        Me.cmb_autorizador.Name = "cmb_autorizador"
        Me.cmb_autorizador.Size = New System.Drawing.Size(279, 21)
        Me.cmb_autorizador.TabIndex = 9
        '
        'lbl_autoriza
        '
        Me.lbl_autoriza.AutoSize = True
        Me.lbl_autoriza.Location = New System.Drawing.Point(5, 170)
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
        'cmb_estado_entrega
        '
        Me.cmb_estado_entrega._descripcion = "descripcion"
        Me.cmb_estado_entrega._nombre_tabla = "ESTADO_ENTREGA"
        Me.cmb_estado_entrega._pk = "id"
        Me.cmb_estado_entrega.FormattingEnabled = True
        Me.cmb_estado_entrega.Location = New System.Drawing.Point(109, 139)
        Me.cmb_estado_entrega.Name = "cmb_estado_entrega"
        Me.cmb_estado_entrega.Size = New System.Drawing.Size(247, 21)
        Me.cmb_estado_entrega.TabIndex = 7
        '
        'txt_id_entrega
        '
        Me.txt_id_entrega.Location = New System.Drawing.Point(109, 21)
        Me.txt_id_entrega.Name = "txt_id_entrega"
        Me.txt_id_entrega.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_entrega.TabIndex = 0
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
        Me.lbl_estado.Location = New System.Drawing.Point(6, 143)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(76, 13)
        Me.lbl_estado.TabIndex = 30
        Me.lbl_estado.Text = "Estado Pedido"
        '
        'grp_detalle
        '
        Me.grp_detalle.BackColor = System.Drawing.Color.Transparent
        Me.grp_detalle.Controls.Add(Me.txt_modelo)
        Me.grp_detalle.Controls.Add(Me.txt_nro_serie)
        Me.grp_detalle.Controls.Add(Me.cmb_marca)
        Me.grp_detalle.Controls.Add(Me.Label11)
        Me.grp_detalle.Controls.Add(Me.Label10)
        Me.grp_detalle.Controls.Add(Me.Label9)
        Me.grp_detalle.Controls.Add(Me.cmd_ver_stock)
        Me.grp_detalle.Controls.Add(Me.cmd_limpiar_insumo)
        Me.grp_detalle.Controls.Add(Me.cmd_eliminar_insumo)
        Me.grp_detalle.Controls.Add(Me.cmd_agregar_insumo)
        Me.grp_detalle.Controls.Add(Me.txt_cantidad)
        Me.grp_detalle.Controls.Add(Me.Label3)
        Me.grp_detalle.Controls.Add(Me.cmb_insumos)
        Me.grp_detalle.Controls.Add(Me.Label8)
        Me.grp_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_detalle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_detalle.Location = New System.Drawing.Point(12, 415)
        Me.grp_detalle.Name = "grp_detalle"
        Me.grp_detalle.Size = New System.Drawing.Size(420, 217)
        Me.grp_detalle.TabIndex = 1
        Me.grp_detalle.TabStop = False
        Me.grp_detalle.Text = "Detalle de Entrega y Pedido"
        '
        'txt_modelo
        '
        Me.txt_modelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_modelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_modelo.Location = New System.Drawing.Point(99, 99)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(283, 20)
        Me.txt_modelo.TabIndex = 3
        '
        'txt_nro_serie
        '
        Me.txt_nro_serie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nro_serie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nro_serie.Location = New System.Drawing.Point(99, 73)
        Me.txt_nro_serie.Name = "txt_nro_serie"
        Me.txt_nro_serie.Size = New System.Drawing.Size(283, 20)
        Me.txt_nro_serie.TabIndex = 2
        '
        'cmb_marca
        '
        Me.cmb_marca._descripcion = "descripcion"
        Me.cmb_marca._nombre_tabla = "MARCA"
        Me.cmb_marca._pk = "id"
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(99, 128)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(160, 21)
        Me.cmb_marca.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Marca"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Nro de Serie"
        '
        'cmd_ver_stock
        '
        Me.cmd_ver_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_ver_stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_ver_stock.FlatAppearance.BorderSize = 0
        Me.cmd_ver_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ver_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ver_stock.Location = New System.Drawing.Point(133, 165)
        Me.cmd_ver_stock.Name = "cmd_ver_stock"
        Me.cmd_ver_stock.Size = New System.Drawing.Size(130, 37)
        Me.cmd_ver_stock.TabIndex = 8
        Me.cmd_ver_stock.Text = "VER STOCK"
        Me.cmd_ver_stock.UseVisualStyleBackColor = True
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
        Me.cmd_limpiar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar_insumo.Location = New System.Drawing.Point(325, 150)
        Me.cmd_limpiar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_insumo.Name = "cmd_limpiar_insumo"
        Me.cmd_limpiar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_insumo.TabIndex = 5
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
        Me.cmd_eliminar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_insumo.Location = New System.Drawing.Point(388, 150)
        Me.cmd_eliminar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_insumo.Name = "cmd_eliminar_insumo"
        Me.cmd_eliminar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_insumo.TabIndex = 7
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
        Me.cmd_agregar_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_insumo.Location = New System.Drawing.Point(357, 150)
        Me.cmd_agregar_insumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_insumo.Name = "cmd_agregar_insumo"
        Me.cmd_agregar_insumo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_insumo.TabIndex = 6
        Me.cmd_agregar_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_insumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_insumo.UseVisualStyleBackColor = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(100, 47)
        Me.txt_cantidad.Mask = "9999999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(98, 20)
        Me.txt_cantidad.TabIndex = 1
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
        Me.cmb_insumos.Location = New System.Drawing.Point(100, 19)
        Me.cmb_insumos.Name = "cmb_insumos"
        Me.cmb_insumos.Size = New System.Drawing.Size(247, 21)
        Me.cmb_insumos.TabIndex = 0
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
        Me.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_limpiar.Location = New System.Drawing.Point(157, 649)
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
        Me.cmd_guardar.Location = New System.Drawing.Point(89, 647)
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(21, 647)
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
        Me.cmd_salir.Location = New System.Drawing.Point(937, 648)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 5
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'dgv_entrega
        '
        Me.dgv_entrega.AllowUserToAddRows = False
        Me.dgv_entrega.AllowUserToDeleteRows = False
        Me.dgv_entrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_entrega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha_pedido, Me.fecha_entrega, Me.estado, Me.autoriza, Me.id_autoriza, Me.cuie, Me.efector, Me.id_estado})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_entrega.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_entrega.Location = New System.Drawing.Point(438, 16)
        Me.dgv_entrega.Name = "dgv_entrega"
        Me.dgv_entrega.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgv_entrega.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_entrega.Size = New System.Drawing.Size(559, 393)
        Me.dgv_entrega.TabIndex = 64
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
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
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
        'id_estado
        '
        Me.id_estado.HeaderText = "id_estado"
        Me.id_estado.Name = "id_estado"
        Me.id_estado.ReadOnly = True
        Me.id_estado.Visible = False
        '
        'dgv_detalle_entrega
        '
        Me.dgv_detalle_entrega.AllowUserToAddRows = False
        Me.dgv_detalle_entrega.AllowUserToDeleteRows = False
        Me.dgv_detalle_entrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_entrega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_insumo, Me.insumo, Me.cantidad, Me.nro_serie, Me.modelo, Me.id_marca})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_detalle_entrega.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_detalle_entrega.Location = New System.Drawing.Point(438, 420)
        Me.dgv_detalle_entrega.Name = "dgv_detalle_entrega"
        Me.dgv_detalle_entrega.ReadOnly = True
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgv_detalle_entrega.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_detalle_entrega.Size = New System.Drawing.Size(559, 210)
        Me.dgv_detalle_entrega.TabIndex = 6
        '
        'id_insumo
        '
        Me.id_insumo.HeaderText = "id_insumo"
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
        'nro_serie
        '
        Me.nro_serie.HeaderText = "nro_serie"
        Me.nro_serie.Name = "nro_serie"
        Me.nro_serie.ReadOnly = True
        Me.nro_serie.Visible = False
        '
        'modelo
        '
        Me.modelo.HeaderText = "modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Visible = False
        '
        'id_marca
        '
        Me.id_marca.HeaderText = "id_marca"
        Me.id_marca.Name = "id_marca"
        Me.id_marca.ReadOnly = True
        Me.id_marca.Visible = False
        '
        'Registrar_entrega_insumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 714)
        Me.Controls.Add(Me.dgv_detalle_entrega)
        Me.Controls.Add(Me.dgv_entrega)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_detalle)
        Me.Controls.Add(Me.grp_datos_recordatorio)
        Me.KeyPreview = True
        Me.Name = "Registrar_entrega_insumos"
        Me.Text = "ENTREGA DE INSUMOS"
        Me.grp_datos_recordatorio.ResumeLayout(False)
        Me.grp_datos_recordatorio.PerformLayout()
        Me.grp_detalle.ResumeLayout(False)
        Me.grp_detalle.PerformLayout()
        CType(Me.dgv_entrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalle_entrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_recordatorio As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fecha_entrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fecha_entrega As System.Windows.Forms.Label
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_autorizador As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_autoriza As System.Windows.Forms.Label
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_entrega As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_entrega As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_pedido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents grp_detalle As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_insumos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_limpiar_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_insumo As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_insumo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_receptor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_ver_stock As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_efector As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_efector As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_entrega As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_detalle_entrega As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_pedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_entrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autoriza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_autoriza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_marca As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents id_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_serie As System.Windows.Forms.TextBox
End Class
