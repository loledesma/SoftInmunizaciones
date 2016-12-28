<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmd_listados = New System.Windows.Forms.Button()
        Me.cmd_estadistica = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grp_datos_generales = New System.Windows.Forms.GroupBox()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.txt_id_notificacion = New System.Windows.Forms.TextBox()
        Me.cmd_efector_nuevo = New System.Windows.Forms.Button()
        Me.cmd_buscar_notificacion = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.grp_datos_notificacion = New System.Windows.Forms.GroupBox()
        Me.cmb_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_perdidas = New System.Windows.Forms.Label()
        Me.lbl_carga = New System.Windows.Forms.Label()
        Me.grp_datos_empleados = New System.Windows.Forms.GroupBox()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.cmd_buscar_empleado = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.dgv_notificaciones = New System.Windows.Forms.DataGridView()
        Me.tltp_notificaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_generales.SuspendLayout()
        Me.grp_datos_notificacion.SuspendLayout()
        Me.grp_datos_empleados.SuspendLayout()
        CType(Me.dgv_notificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmd_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_limpiar.Location = New System.Drawing.Point(214, 432)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 35
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
        Me.cmd_guardar.Location = New System.Drawing.Point(78, 432)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 32
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
        Me.cmd_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_eliminar.Location = New System.Drawing.Point(146, 432)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_eliminar.TabIndex = 33
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
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.Location = New System.Drawing.Point(10, 432)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 34
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_listados
        '
        Me.cmd_listados.BackColor = System.Drawing.Color.Transparent
        Me.cmd_listados.BackgroundImage = CType(resources.GetObject("cmd_listados.BackgroundImage"), System.Drawing.Image)
        Me.cmd_listados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_listados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_listados.FlatAppearance.BorderSize = 0
        Me.cmd_listados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_listados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_listados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_listados.Location = New System.Drawing.Point(544, 434)
        Me.cmd_listados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_listados.Name = "cmd_listados"
        Me.cmd_listados.Size = New System.Drawing.Size(60, 60)
        Me.cmd_listados.TabIndex = 39
        Me.cmd_listados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_listados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_listados.UseVisualStyleBackColor = False
        '
        'cmd_estadistica
        '
        Me.cmd_estadistica.BackColor = System.Drawing.Color.Transparent
        Me.cmd_estadistica.BackgroundImage = CType(resources.GetObject("cmd_estadistica.BackgroundImage"), System.Drawing.Image)
        Me.cmd_estadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_estadistica.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_estadistica.FlatAppearance.BorderSize = 0
        Me.cmd_estadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_estadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_estadistica.Location = New System.Drawing.Point(462, 434)
        Me.cmd_estadistica.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_estadistica.Name = "cmd_estadistica"
        Me.cmd_estadistica.Size = New System.Drawing.Size(60, 60)
        Me.cmd_estadistica.TabIndex = 38
        Me.cmd_estadistica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_estadistica.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(995, 432)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 40
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'grp_datos_generales
        '
        Me.grp_datos_generales.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_generales.Controls.Add(Me.txt_efectores)
        Me.grp_datos_generales.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_generales.Controls.Add(Me.txt_id_notificacion)
        Me.grp_datos_generales.Controls.Add(Me.cmd_efector_nuevo)
        Me.grp_datos_generales.Controls.Add(Me.cmd_buscar_notificacion)
        Me.grp_datos_generales.Controls.Add(Me.txt_fecha)
        Me.grp_datos_generales.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_generales.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_generales.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_generales.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_generales.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_generales.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_generales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_generales.Location = New System.Drawing.Point(10, 3)
        Me.grp_datos_generales.Name = "grp_datos_generales"
        Me.grp_datos_generales.Size = New System.Drawing.Size(403, 159)
        Me.grp_datos_generales.TabIndex = 43
        Me.grp_datos_generales.TabStop = False
        Me.grp_datos_generales.Text = "Datos Generales"
        '
        'txt_efectores
        '
        Me.txt_efectores.Location = New System.Drawing.Point(114, 125)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(217, 20)
        Me.txt_efectores.TabIndex = 54
        '
        'lbl_id_notificacion
        '
        Me.lbl_id_notificacion.AutoSize = True
        Me.lbl_id_notificacion.Location = New System.Drawing.Point(8, 24)
        Me.lbl_id_notificacion.Name = "lbl_id_notificacion"
        Me.lbl_id_notificacion.Size = New System.Drawing.Size(16, 13)
        Me.lbl_id_notificacion.TabIndex = 48
        Me.lbl_id_notificacion.Text = "Id"
        '
        'txt_id_notificacion
        '
        Me.txt_id_notificacion.Location = New System.Drawing.Point(115, 21)
        Me.txt_id_notificacion.Name = "txt_id_notificacion"
        Me.txt_id_notificacion.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_notificacion.TabIndex = 47
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
        Me.cmd_efector_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(368, 121)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_efector_nuevo.TabIndex = 41
        Me.cmd_efector_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_efector_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_efector_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_buscar_notificacion
        '
        Me.cmd_buscar_notificacion.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_notificacion.BackgroundImage = CType(resources.GetObject("cmd_buscar_notificacion.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_notificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_notificacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar_notificacion.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_notificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_notificacion.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_notificacion.Location = New System.Drawing.Point(370, 14)
        Me.cmd_buscar_notificacion.Name = "cmd_buscar_notificacion"
        Me.cmd_buscar_notificacion.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_notificacion.TabIndex = 45
        Me.cmd_buscar_notificacion.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(115, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 44
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(114, 72)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(216, 21)
        Me.cmb_departamentos.TabIndex = 42
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(8, 52)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(37, 13)
        Me.lbl_perfil.TabIndex = 37
        Me.lbl_perfil.Text = "Fecha"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(115, 99)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(216, 21)
        Me.cmb_localidades.TabIndex = 33
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(8, 128)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(64, 13)
        Me.lbl_vacunatorio.TabIndex = 32
        Me.lbl_vacunatorio.Text = "Vacunatorio"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(8, 102)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 31
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(8, 78)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_departamento.TabIndex = 30
        Me.lbl_departamento.Text = "Departamento"
        '
        'grp_datos_notificacion
        '
        Me.grp_datos_notificacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_carga)
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_stock)
        Me.grp_datos_notificacion.Controls.Add(Me.cmb_perdidas)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_stock)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_perdidas)
        Me.grp_datos_notificacion.Controls.Add(Me.lbl_carga)
        Me.grp_datos_notificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_notificacion.Location = New System.Drawing.Point(10, 168)
        Me.grp_datos_notificacion.Name = "grp_datos_notificacion"
        Me.grp_datos_notificacion.Size = New System.Drawing.Size(403, 114)
        Me.grp_datos_notificacion.TabIndex = 44
        Me.grp_datos_notificacion.TabStop = False
        Me.grp_datos_notificacion.Text = "Datos Notificación"
        '
        'cmb_carga
        '
        Me.cmb_carga._descripcion = "descripcion"
        Me.cmb_carga._nombre_tabla = "CARGA"
        Me.cmb_carga._pk = "id"
        Me.cmb_carga.FormattingEnabled = True
        Me.cmb_carga.Location = New System.Drawing.Point(112, 22)
        Me.cmb_carga.Name = "cmb_carga"
        Me.cmb_carga.Size = New System.Drawing.Size(216, 21)
        Me.cmb_carga.TabIndex = 42
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = "descripcion"
        Me.cmb_stock._nombre_tabla = "STOCK"
        Me.cmb_stock._pk = "id"
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(112, 75)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(217, 21)
        Me.cmb_stock.TabIndex = 34
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = "descripcion"
        Me.cmb_perdidas._nombre_tabla = "LOCALIDADES"
        Me.cmb_perdidas._pk = "id"
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(112, 49)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(216, 21)
        Me.cmb_perdidas.TabIndex = 33
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(6, 77)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(35, 13)
        Me.lbl_stock.TabIndex = 32
        Me.lbl_stock.Text = "Stock"
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(6, 51)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(48, 13)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Perdidas"
        '
        'lbl_carga
        '
        Me.lbl_carga.AutoSize = True
        Me.lbl_carga.Location = New System.Drawing.Point(6, 27)
        Me.lbl_carga.Name = "lbl_carga"
        Me.lbl_carga.Size = New System.Drawing.Size(35, 13)
        Me.lbl_carga.TabIndex = 30
        Me.lbl_carga.Text = "Carga"
        '
        'grp_datos_empleados
        '
        Me.grp_datos_empleados.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_empleados.Controls.Add(Me.txt_apellidos)
        Me.grp_datos_empleados.Controls.Add(Me.txt_nombres)
        Me.grp_datos_empleados.Controls.Add(Me.lbl_apellidos)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_buscar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.txt_usuario)
        Me.grp_datos_empleados.Controls.Add(Me.txt_id_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.lbl_nombre)
        Me.grp_datos_empleados.Controls.Add(Me.lbl_usuario)
        Me.grp_datos_empleados.Controls.Add(Me.lbl_id)
        Me.grp_datos_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_empleados.Location = New System.Drawing.Point(10, 288)
        Me.grp_datos_empleados.Name = "grp_datos_empleados"
        Me.grp_datos_empleados.Size = New System.Drawing.Size(403, 137)
        Me.grp_datos_empleados.TabIndex = 45
        Me.grp_datos_empleados.TabStop = False
        Me.grp_datos_empleados.Text = "Datos Empleado"
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(110, 80)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(272, 20)
        Me.txt_apellidos.TabIndex = 53
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(110, 53)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(272, 20)
        Me.txt_nombres.TabIndex = 52
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Location = New System.Drawing.Point(7, 83)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellidos.TabIndex = 51
        Me.lbl_apellidos.Text = "Apellidos"
        '
        'cmd_buscar_empleado
        '
        Me.cmd_buscar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleado.BackgroundImage = CType(resources.GetObject("cmd_buscar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_empleado.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_empleado.Location = New System.Drawing.Point(368, 15)
        Me.cmd_buscar_empleado.Name = "cmd_buscar_empleado"
        Me.cmd_buscar_empleado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_empleado.TabIndex = 49
        Me.cmd_buscar_empleado.UseVisualStyleBackColor = False
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(110, 108)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(272, 20)
        Me.txt_usuario.TabIndex = 50
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(109, 23)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_empleado.TabIndex = 49
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 55)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_nombre.TabIndex = 32
        Me.lbl_nombre.Text = "Nombres"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(7, 112)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 31
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(6, 27)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 13)
        Me.lbl_id.TabIndex = 30
        Me.lbl_id.Text = "Id"
        '
        'dgv_notificaciones
        '
        Me.dgv_notificaciones.AllowUserToAddRows = False
        Me.dgv_notificaciones.AllowUserToDeleteRows = False
        Me.dgv_notificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_notificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.nombre_efector, Me.carga, Me.perdidas, Me.stock, Me.id_stock, Me.id_cargo, Me.id_perfil, Me.id})
        Me.dgv_notificaciones.Location = New System.Drawing.Point(425, 8)
        Me.dgv_notificaciones.Name = "dgv_notificaciones"
        Me.dgv_notificaciones.ReadOnly = True
        Me.dgv_notificaciones.Size = New System.Drawing.Size(628, 418)
        Me.dgv_notificaciones.TabIndex = 46
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
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
        'id_cargo
        '
        Me.id_cargo.HeaderText = "id_cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        '
        'id_perfil
        '
        Me.id_perfil.HeaderText = "id_perfil"
        Me.id_perfil.Name = "id_perfil"
        Me.id_perfil.ReadOnly = True
        Me.id_perfil.Visible = False
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 504)
        Me.Controls.Add(Me.dgv_notificaciones)
        Me.Controls.Add(Me.grp_datos_empleados)
        Me.Controls.Add(Me.grp_datos_notificacion)
        Me.Controls.Add(Me.grp_datos_generales)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_listados)
        Me.Controls.Add(Me.cmd_estadistica)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.KeyPreview = True
        Me.Name = "Registrar_notificaciones"
        Me.Text = "Registro_notificaciones"
        Me.grp_datos_generales.ResumeLayout(False)
        Me.grp_datos_generales.PerformLayout()
        Me.grp_datos_notificacion.ResumeLayout(False)
        Me.grp_datos_notificacion.PerformLayout()
        Me.grp_datos_empleados.ResumeLayout(False)
        Me.grp_datos_empleados.PerformLayout()
        CType(Me.dgv_notificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_listados As System.Windows.Forms.Button
    Friend WithEvents cmd_estadistica As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grp_datos_generales As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_buscar_notificacion As System.Windows.Forms.Button
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents txt_id_notificacion As System.Windows.Forms.TextBox
    Friend WithEvents grp_datos_notificacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmb_stock As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_perdidas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_perdidas As System.Windows.Forms.Label
    Friend WithEvents lbl_carga As System.Windows.Forms.Label
    Friend WithEvents grp_datos_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents dgv_notificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents tltp_notificaciones As System.Windows.Forms.ToolTip
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
