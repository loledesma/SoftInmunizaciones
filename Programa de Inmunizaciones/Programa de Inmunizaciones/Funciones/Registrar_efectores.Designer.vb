﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_efectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_efectores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp_datos_vacunatorio = New System.Windows.Forms.GroupBox()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.cmd_buscar_nombre = New System.Windows.Forms.Button()
        Me.cmd_buscar_cuie = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_horarioDesde = New System.Windows.Forms.TextBox()
        Me.txt_horarioHasta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_grilla_empleados = New System.Windows.Forms.GroupBox()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.grp_datos_empleados = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmd_limpiar_empleados = New System.Windows.Forms.Button()
        Me.cmd_eliminar_empleado = New System.Windows.Forms.Button()
        Me.cmd_agregar_empleado = New System.Windows.Forms.Button()
        Me.cmd_empleado_nuevo = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_numero_doc = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grp_grilla_vacunatorios = New System.Windows.Forms.GroupBox()
        Me.dgv_vacunatorios = New System.Windows.Forms.DataGridView()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_listados = New System.Windows.Forms.Button()
        Me.cmd_estadistica = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_buscar_empleadoXDNI = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_estados_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tipos_documento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tipo_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_estado_efector = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tipos_efectores = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_referentes = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_barrios = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.grp_datos_vacunatorio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_grilla_empleados.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_empleados.SuspendLayout()
        Me.grp_grilla_vacunatorios.SuspendLayout()
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_vacunatorio
        '
        Me.grp_datos_vacunatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_cuie)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_buscar_nombre)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmd_buscar_cuie)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipo_carga)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label15)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_estado_efector)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label14)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_tipos_efectores)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label13)
        Me.grp_datos_vacunatorio.Controls.Add(Me.cmb_referentes)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label12)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label11)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_horarioDesde)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_horarioHasta)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label10)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_telefono)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label9)
        Me.grp_datos_vacunatorio.Controls.Add(Me.GroupBox2)
        Me.grp_datos_vacunatorio.Controls.Add(Me.txt_nombre)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label2)
        Me.grp_datos_vacunatorio.Controls.Add(Me.Label1)
        Me.grp_datos_vacunatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_vacunatorio.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_vacunatorio.Name = "grp_datos_vacunatorio"
        Me.grp_datos_vacunatorio.Size = New System.Drawing.Size(511, 324)
        Me.grp_datos_vacunatorio.TabIndex = 0
        Me.grp_datos_vacunatorio.TabStop = False
        Me.grp_datos_vacunatorio.Text = "Datos del vacunatorio  "
        '
        'txt_cuie
        '
        Me.txt_cuie.Location = New System.Drawing.Point(114, 23)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(159, 20)
        Me.txt_cuie.TabIndex = 0
        '
        'cmd_buscar_nombre
        '
        Me.cmd_buscar_nombre.BackgroundImage = CType(resources.GetObject("cmd_buscar_nombre.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_nombre.Location = New System.Drawing.Point(395, 46)
        Me.cmd_buscar_nombre.Name = "cmd_buscar_nombre"
        Me.cmd_buscar_nombre.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_nombre.TabIndex = 3
        Me.cmd_buscar_nombre.UseVisualStyleBackColor = True
        '
        'cmd_buscar_cuie
        '
        Me.cmd_buscar_cuie.BackgroundImage = CType(resources.GetObject("cmd_buscar_cuie.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_cuie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_cuie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_cuie.Location = New System.Drawing.Point(279, 19)
        Me.cmd_buscar_cuie.Name = "cmd_buscar_cuie"
        Me.cmd_buscar_cuie.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_cuie.TabIndex = 1
        Me.cmd_buscar_cuie.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(279, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Tipo carga"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(279, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tipo Efector"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Referente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "hasta"
        '
        'txt_horarioDesde
        '
        Me.txt_horarioDesde.Location = New System.Drawing.Point(114, 113)
        Me.txt_horarioDesde.Name = "txt_horarioDesde"
        Me.txt_horarioDesde.Size = New System.Drawing.Size(53, 20)
        Me.txt_horarioDesde.TabIndex = 5
        '
        'txt_horarioHasta
        '
        Me.txt_horarioHasta.Location = New System.Drawing.Point(212, 113)
        Me.txt_horarioHasta.Name = "txt_horarioHasta"
        Me.txt_horarioHasta.Size = New System.Drawing.Size(61, 20)
        Me.txt_horarioHasta.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Horario de atención"
        '
        'txt_telefono
        '
        Me.txt_telefono.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txt_telefono.Location = New System.Drawing.Point(114, 75)
        Me.txt_telefono.Mask = "99999999999"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(159, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Teléfono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_departamento)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmb_localidades)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_barrios)
        Me.GroupBox2.Controls.Add(Me.txt_numero)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_calle)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(6, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 106)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Localidad"
        '
        'txt_numero
        '
        Me.txt_numero.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.txt_numero.Location = New System.Drawing.Point(434, 19)
        Me.txt_numero.Mask = "99999999"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(59, 20)
        Me.txt_numero.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Barrio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(108, 19)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(275, 20)
        Me.txt_calle.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Calle"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 49)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(275, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIE"
        '
        'grp_grilla_empleados
        '
        Me.grp_grilla_empleados.BackColor = System.Drawing.Color.Transparent
        Me.grp_grilla_empleados.Controls.Add(Me.dgv_empleados)
        Me.grp_grilla_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_grilla_empleados.Location = New System.Drawing.Point(529, 278)
        Me.grp_grilla_empleados.Name = "grp_grilla_empleados"
        Me.grp_grilla_empleados.Size = New System.Drawing.Size(714, 221)
        Me.grp_grilla_empleados.TabIndex = 9
        Me.grp_grilla_empleados.TabStop = False
        Me.grp_grilla_empleados.Text = "Empleados"
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_doc, Me.numero, Me.nombre_empleado, Me.apellido, Me.cargo, Me.usuario, Me.perfil, Me.id_cargo, Me.estado_empleado, Me.id_perfil})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_empleados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_empleados.Location = New System.Drawing.Point(6, 19)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.Size = New System.Drawing.Size(702, 194)
        Me.dgv_empleados.TabIndex = 0
        '
        'grp_datos_empleados
        '
        Me.grp_datos_empleados.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_empleados.Controls.Add(Me.cmd_buscar_empleadoXDNI)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_estados_empleados)
        Me.grp_datos_empleados.Controls.Add(Me.Label3)
        Me.grp_datos_empleados.Controls.Add(Me.txt_id_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.Label20)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_limpiar_empleados)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_eliminar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_agregar_empleado)
        Me.grp_datos_empleados.Controls.Add(Me.cmd_empleado_nuevo)
        Me.grp_datos_empleados.Controls.Add(Me.txt_usuario)
        Me.grp_datos_empleados.Controls.Add(Me.Label17)
        Me.grp_datos_empleados.Controls.Add(Me.txt_numero_doc)
        Me.grp_datos_empleados.Controls.Add(Me.txt_apellido)
        Me.grp_datos_empleados.Controls.Add(Me.label16)
        Me.grp_datos_empleados.Controls.Add(Me.Label19)
        Me.grp_datos_empleados.Controls.Add(Me.cmb_tipos_documento)
        Me.grp_datos_empleados.Controls.Add(Me.Label18)
        Me.grp_datos_empleados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_empleados.Location = New System.Drawing.Point(12, 342)
        Me.grp_datos_empleados.Name = "grp_datos_empleados"
        Me.grp_datos_empleados.Size = New System.Drawing.Size(511, 156)
        Me.grp_datos_empleados.TabIndex = 1
        Me.grp_datos_empleados.TabStop = False
        Me.grp_datos_empleados.Text = "Datos del empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Estado empleado"
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_id_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_id_empleado.Location = New System.Drawing.Point(114, 16)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(53, 20)
        Me.txt_id_empleado.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "ID"
        '
        'cmd_limpiar_empleados
        '
        Me.cmd_limpiar_empleados.BackColor = System.Drawing.Color.Transparent
        Me.cmd_limpiar_empleados.BackgroundImage = CType(resources.GetObject("cmd_limpiar_empleados.BackgroundImage"), System.Drawing.Image)
        Me.cmd_limpiar_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_limpiar_empleados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_limpiar_empleados.FlatAppearance.BorderSize = 0
        Me.cmd_limpiar_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_limpiar_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_limpiar_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_limpiar_empleados.Location = New System.Drawing.Point(414, 124)
        Me.cmd_limpiar_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar_empleados.Name = "cmd_limpiar_empleados"
        Me.cmd_limpiar_empleados.Size = New System.Drawing.Size(25, 25)
        Me.cmd_limpiar_empleados.TabIndex = 8
        Me.cmd_limpiar_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar_empleados.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_empleado
        '
        Me.cmd_eliminar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_empleado.BackgroundImage = CType(resources.GetObject("cmd_eliminar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_eliminar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_eliminar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_eliminar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_eliminar_empleado.Location = New System.Drawing.Point(479, 124)
        Me.cmd_eliminar_empleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar_empleado.Name = "cmd_eliminar_empleado"
        Me.cmd_eliminar_empleado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_eliminar_empleado.TabIndex = 10
        Me.cmd_eliminar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar_empleado.UseVisualStyleBackColor = False
        '
        'cmd_agregar_empleado
        '
        Me.cmd_agregar_empleado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_empleado.BackgroundImage = CType(resources.GetObject("cmd_agregar_empleado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_agregar_empleado.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_agregar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_agregar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_agregar_empleado.Location = New System.Drawing.Point(445, 124)
        Me.cmd_agregar_empleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_agregar_empleado.Name = "cmd_agregar_empleado"
        Me.cmd_agregar_empleado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_agregar_empleado.TabIndex = 9
        Me.cmd_agregar_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_agregar_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_agregar_empleado.UseVisualStyleBackColor = False
        '
        'cmd_empleado_nuevo
        '
        Me.cmd_empleado_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.BackgroundImage = CType(resources.GetObject("cmd_empleado_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_empleado_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_empleado_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_empleado_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_empleado_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_empleado_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_empleado_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_empleado_nuevo.Location = New System.Drawing.Point(427, 40)
        Me.cmd_empleado_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_empleado_nuevo.Name = "cmd_empleado_nuevo"
        Me.cmd_empleado_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_empleado_nuevo.TabIndex = 4
        Me.cmd_empleado_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_empleado_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_empleado_nuevo.UseVisualStyleBackColor = False
        '
        'txt_usuario
        '
        Me.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_usuario.Location = New System.Drawing.Point(114, 97)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(275, 20)
        Me.txt_usuario.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Usuario Sigipsa"
        '
        'txt_numero_doc
        '
        Me.txt_numero_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_numero_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_numero_doc.Location = New System.Drawing.Point(223, 43)
        Me.txt_numero_doc.Name = "txt_numero_doc"
        Me.txt_numero_doc.Size = New System.Drawing.Size(166, 20)
        Me.txt_numero_doc.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_apellido.Location = New System.Drawing.Point(114, 70)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(275, 20)
        Me.txt_apellido.TabIndex = 5
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(17, 73)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(49, 13)
        Me.label16.TabIndex = 23
        Me.label16.Text = "Apellidos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Número"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Tipo Doc"
        '
        'grp_grilla_vacunatorios
        '
        Me.grp_grilla_vacunatorios.BackColor = System.Drawing.Color.Transparent
        Me.grp_grilla_vacunatorios.Controls.Add(Me.dgv_vacunatorios)
        Me.grp_grilla_vacunatorios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_grilla_vacunatorios.Location = New System.Drawing.Point(529, 12)
        Me.grp_grilla_vacunatorios.Name = "grp_grilla_vacunatorios"
        Me.grp_grilla_vacunatorios.Size = New System.Drawing.Size(714, 260)
        Me.grp_grilla_vacunatorios.TabIndex = 8
        Me.grp_grilla_vacunatorios.TabStop = False
        Me.grp_grilla_vacunatorios.Text = "Vacunatorios"
        '
        'dgv_vacunatorios
        '
        Me.dgv_vacunatorios.AllowUserToAddRows = False
        Me.dgv_vacunatorios.AllowUserToDeleteRows = False
        Me.dgv_vacunatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.nombre, Me.referente, Me.localidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_vacunatorios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_vacunatorios.Location = New System.Drawing.Point(6, 19)
        Me.dgv_vacunatorios.Name = "dgv_vacunatorios"
        Me.dgv_vacunatorios.ReadOnly = True
        Me.dgv_vacunatorios.Size = New System.Drawing.Size(702, 232)
        Me.dgv_vacunatorios.TabIndex = 0
        '
        'cuie
        '
        Me.cuie.HeaderText = "CUIE"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 225
        '
        'referente
        '
        Me.referente.HeaderText = "Referente"
        Me.referente.Name = "referente"
        Me.referente.ReadOnly = True
        Me.referente.Width = 225
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 165
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
        Me.cmd_listados.Location = New System.Drawing.Point(535, 505)
        Me.cmd_listados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_listados.Name = "cmd_listados"
        Me.cmd_listados.Size = New System.Drawing.Size(60, 60)
        Me.cmd_listados.TabIndex = 5
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
        Me.cmd_estadistica.Location = New System.Drawing.Point(614, 505)
        Me.cmd_estadistica.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_estadistica.Name = "cmd_estadistica"
        Me.cmd_estadistica.Size = New System.Drawing.Size(60, 60)
        Me.cmd_estadistica.TabIndex = 6
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
        Me.cmd_salir.Location = New System.Drawing.Point(1184, 505)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 7
        Me.cmd_salir.UseVisualStyleBackColor = False
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(150, 504)
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
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.Location = New System.Drawing.Point(82, 505)
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
        Me.cmd_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.Location = New System.Drawing.Point(14, 505)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 3
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_buscar_empleadoXDNI
        '
        Me.cmd_buscar_empleadoXDNI.BackgroundImage = CType(resources.GetObject("cmd_buscar_empleadoXDNI.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_empleadoXDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_empleadoXDNI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_empleadoXDNI.Location = New System.Drawing.Point(395, 40)
        Me.cmd_buscar_empleadoXDNI.Name = "cmd_buscar_empleadoXDNI"
        Me.cmd_buscar_empleadoXDNI.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_empleadoXDNI.TabIndex = 3
        Me.cmd_buscar_empleadoXDNI.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Width = 30
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 75
        '
        'nombre_empleado
        '
        Me.nombre_empleado.HeaderText = "Nombre"
        Me.nombre_empleado.Name = "nombre_empleado"
        Me.nombre_empleado.ReadOnly = True
        Me.nombre_empleado.Width = 180
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellidos"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 180
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario Sigipsa"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 150
        '
        'perfil
        '
        Me.perfil.HeaderText = "Perfil"
        Me.perfil.Name = "perfil"
        Me.perfil.ReadOnly = True
        '
        'id_cargo
        '
        Me.id_cargo.HeaderText = "ID Cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        '
        'estado_empleado
        '
        Me.estado_empleado.HeaderText = "Estado Empleado"
        Me.estado_empleado.Name = "estado_empleado"
        Me.estado_empleado.ReadOnly = True
        '
        'id_perfil
        '
        Me.id_perfil.HeaderText = "ID Perfil"
        Me.id_perfil.Name = "id_perfil"
        Me.id_perfil.ReadOnly = True
        Me.id_perfil.Visible = False
        '
        'cmb_estados_empleados
        '
        Me.cmb_estados_empleados._descripcion = "descripcion"
        Me.cmb_estados_empleados._nombre_tabla = "ESTADOS_EMPLEADOS"
        Me.cmb_estados_empleados._pk = "id"
        Me.cmb_estados_empleados.FormattingEnabled = True
        Me.cmb_estados_empleados.Location = New System.Drawing.Point(114, 121)
        Me.cmb_estados_empleados.Name = "cmb_estados_empleados"
        Me.cmb_estados_empleados.Size = New System.Drawing.Size(275, 21)
        Me.cmb_estados_empleados.TabIndex = 7
        '
        'cmb_tipos_documento
        '
        Me.cmb_tipos_documento._descripcion = "descripcion"
        Me.cmb_tipos_documento._nombre_tabla = "TIPOS_DOCUMENTO"
        Me.cmb_tipos_documento._pk = "id"
        Me.cmb_tipos_documento.FormattingEnabled = True
        Me.cmb_tipos_documento.Location = New System.Drawing.Point(114, 43)
        Me.cmb_tipos_documento.Name = "cmb_tipos_documento"
        Me.cmb_tipos_documento.Size = New System.Drawing.Size(53, 21)
        Me.cmb_tipos_documento.TabIndex = 1
        '
        'cmb_tipo_carga
        '
        Me.cmb_tipo_carga._descripcion = "descripcion"
        Me.cmb_tipo_carga._nombre_tabla = "TIPO_CARGA"
        Me.cmb_tipo_carga._pk = "id"
        Me.cmb_tipo_carga.FormattingEnabled = True
        Me.cmb_tipo_carga.Location = New System.Drawing.Point(346, 176)
        Me.cmb_tipo_carga.Name = "cmb_tipo_carga"
        Me.cmb_tipo_carga.Size = New System.Drawing.Size(159, 21)
        Me.cmb_tipo_carga.TabIndex = 10
        '
        'cmb_estado_efector
        '
        Me.cmb_estado_efector._descripcion = "descripcion"
        Me.cmb_estado_efector._nombre_tabla = "ESTADOS_EFECTOR"
        Me.cmb_estado_efector._pk = "id"
        Me.cmb_estado_efector.FormattingEnabled = True
        Me.cmb_estado_efector.Location = New System.Drawing.Point(114, 176)
        Me.cmb_estado_efector.Name = "cmb_estado_efector"
        Me.cmb_estado_efector.Size = New System.Drawing.Size(159, 21)
        Me.cmb_estado_efector.TabIndex = 9
        '
        'cmb_tipos_efectores
        '
        Me.cmb_tipos_efectores._descripcion = "descripcion"
        Me.cmb_tipos_efectores._nombre_tabla = "TIPOS_EFECTORES"
        Me.cmb_tipos_efectores._pk = "id"
        Me.cmb_tipos_efectores.FormattingEnabled = True
        Me.cmb_tipos_efectores.Location = New System.Drawing.Point(346, 143)
        Me.cmb_tipos_efectores.Name = "cmb_tipos_efectores"
        Me.cmb_tipos_efectores.Size = New System.Drawing.Size(159, 21)
        Me.cmb_tipos_efectores.TabIndex = 8
        '
        'cmb_referentes
        '
        Me.cmb_referentes._descripcion = "nombre"
        Me.cmb_referentes._nombre_tabla = "EFECTORES"
        Me.cmb_referentes._pk = "CUIE"
        Me.cmb_referentes.FormattingEnabled = True
        Me.cmb_referentes.Location = New System.Drawing.Point(114, 143)
        Me.cmb_referentes.Name = "cmb_referentes"
        Me.cmb_referentes.Size = New System.Drawing.Size(159, 21)
        Me.cmb_referentes.TabIndex = 7
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(108, 45)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(159, 21)
        Me.cmb_departamento.TabIndex = 2
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(332, 45)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(161, 21)
        Me.cmb_localidades.TabIndex = 3
        '
        'cmb_barrios
        '
        Me.cmb_barrios._descripcion = "descripcion"
        Me.cmb_barrios._nombre_tabla = "BARRIOS"
        Me.cmb_barrios._pk = "id"
        Me.cmb_barrios.FormattingEnabled = True
        Me.cmb_barrios.Location = New System.Drawing.Point(108, 72)
        Me.cmb_barrios.Name = "cmb_barrios"
        Me.cmb_barrios.Size = New System.Drawing.Size(159, 21)
        Me.cmb_barrios.TabIndex = 4
        '
        'Registrar_efectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1255, 567)
        Me.Controls.Add(Me.cmd_listados)
        Me.Controls.Add(Me.cmd_estadistica)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_grilla_vacunatorios)
        Me.Controls.Add(Me.grp_datos_empleados)
        Me.Controls.Add(Me.grp_grilla_empleados)
        Me.Controls.Add(Me.grp_datos_vacunatorio)
        Me.KeyPreview = True
        Me.Name = "Registrar_efectores"
        Me.Text = "Registro de efectores"
        Me.grp_datos_vacunatorio.ResumeLayout(False)
        Me.grp_datos_vacunatorio.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp_grilla_empleados.ResumeLayout(False)
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_empleados.ResumeLayout(False)
        Me.grp_datos_empleados.PerformLayout()
        Me.grp_grilla_vacunatorios.ResumeLayout(False)
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_vacunatorio As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrios As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_horarioDesde As System.Windows.Forms.TextBox
    Friend WithEvents txt_horarioHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_efector As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_referentes As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_nombre As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_cuie As System.Windows.Forms.Button
    Friend WithEvents grp_grilla_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents grp_datos_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_documento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grp_grilla_vacunatorios As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_listados As System.Windows.Forms.Button
    Friend WithEvents cmd_estadistica As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents cmd_empleado_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar_empleados As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_empleado As System.Windows.Forms.Button
    Friend WithEvents cmd_agregar_empleado As System.Windows.Forms.Button
    Friend WithEvents dgv_vacunatorios As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents txt_id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents referente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_estados_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_empleadoXDNI As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
