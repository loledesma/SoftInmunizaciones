<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_de_reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_reportes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_efector_nuevo = New System.Windows.Forms.Button()
        Me.txt_responsable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_confirmar_reportes = New System.Windows.Forms.Button()
        Me.cmd_eliminar_reporte = New System.Windows.Forms.Button()
        Me.dgv_reportes = New System.Windows.Forms.DataGridView()
        Me.efectorTerminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuieTerminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_notificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emision_resumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_emision_resumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo_notificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tiempo_notificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reporte = New System.Windows.Forms.GroupBox()
        Me.cmd_notificaciones = New System.Windows.Forms.Button()
        Me.cmd_agregar_reporte = New System.Windows.Forms.Button()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_buscar_añoYsemestre = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tltp_reportes = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgv_vacunatorios = New System.Windows.Forms.DataGridView()
        Me.cmb_año = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_notificaciones = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_emite_resumen = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tiempo_notificacion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_semestre_reporte = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reporte.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(1271, 738)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(73, 71)
        Me.cmd_salir.TabIndex = 19
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_efector_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_responsable)
        Me.GroupBox1.Controls.Add(Me.cmb_año)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.Reporte)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_añoYsemestre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_semestre_reporte)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1368, 737)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "El GoupBox de los GroupBox"
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
        Me.cmd_efector_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_efector_nuevo.Location = New System.Drawing.Point(1113, 24)
        Me.cmd_efector_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_efector_nuevo.Name = "cmd_efector_nuevo"
        Me.cmd_efector_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_efector_nuevo.TabIndex = 21
        Me.cmd_efector_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_efector_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_efector_nuevo.UseVisualStyleBackColor = False
        '
        'txt_responsable
        '
        Me.txt_responsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_responsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_responsable.Location = New System.Drawing.Point(810, 28)
        Me.txt_responsable.Name = "txt_responsable"
        Me.txt_responsable.Size = New System.Drawing.Size(243, 20)
        Me.txt_responsable.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(689, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hospital de Referencia"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox2.Controls.Add(Me.cmd_confirmar_reportes)
        Me.GroupBox2.Controls.Add(Me.cmd_eliminar_reporte)
        Me.GroupBox2.Controls.Add(Me.dgv_reportes)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(514, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 677)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes realizados"
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(668, 623)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(51, 48)
        Me.cmd_limpiar.TabIndex = 60
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar.UseVisualStyleBackColor = False
        '
        'cmd_confirmar_reportes
        '
        Me.cmd_confirmar_reportes.BackColor = System.Drawing.Color.Transparent
        Me.cmd_confirmar_reportes.BackgroundImage = CType(resources.GetObject("cmd_confirmar_reportes.BackgroundImage"), System.Drawing.Image)
        Me.cmd_confirmar_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_confirmar_reportes.FlatAppearance.BorderSize = 0
        Me.cmd_confirmar_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_confirmar_reportes.Location = New System.Drawing.Point(726, 621)
        Me.cmd_confirmar_reportes.Name = "cmd_confirmar_reportes"
        Me.cmd_confirmar_reportes.Size = New System.Drawing.Size(49, 50)
        Me.cmd_confirmar_reportes.TabIndex = 17
        Me.cmd_confirmar_reportes.UseVisualStyleBackColor = False
        '
        'cmd_eliminar_reporte
        '
        Me.cmd_eliminar_reporte.BackColor = System.Drawing.Color.Transparent
        Me.cmd_eliminar_reporte.BackgroundImage = CType(resources.GetObject("cmd_eliminar_reporte.BackgroundImage"), System.Drawing.Image)
        Me.cmd_eliminar_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_eliminar_reporte.FlatAppearance.BorderSize = 0
        Me.cmd_eliminar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_eliminar_reporte.Location = New System.Drawing.Point(781, 621)
        Me.cmd_eliminar_reporte.Name = "cmd_eliminar_reporte"
        Me.cmd_eliminar_reporte.Size = New System.Drawing.Size(49, 50)
        Me.cmd_eliminar_reporte.TabIndex = 18
        Me.cmd_eliminar_reporte.UseVisualStyleBackColor = False
        '
        'dgv_reportes
        '
        Me.dgv_reportes.AllowUserToAddRows = False
        Me.dgv_reportes.AllowUserToDeleteRows = False
        Me.dgv_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reportes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.efectorTerminado, Me.cuieTerminado, Me.notificaciones, Me.id_notificaciones, Me.carga, Me.id_carga, Me.perdidas, Me.id_perdidas, Me.stock, Me.id_stock, Me.emision_resumen, Me.id_emision_resumen, Me.tiempo_notificacion, Me.id_tiempo_notificacion, Me.observaciones})
        Me.dgv_reportes.Location = New System.Drawing.Point(6, 19)
        Me.dgv_reportes.Name = "dgv_reportes"
        Me.dgv_reportes.ReadOnly = True
        Me.dgv_reportes.Size = New System.Drawing.Size(824, 596)
        Me.dgv_reportes.TabIndex = 0
        '
        'efectorTerminado
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.efectorTerminado.DefaultCellStyle = DataGridViewCellStyle1
        Me.efectorTerminado.FillWeight = 150.0!
        Me.efectorTerminado.HeaderText = "Vacunatorio"
        Me.efectorTerminado.MinimumWidth = 10
        Me.efectorTerminado.Name = "efectorTerminado"
        Me.efectorTerminado.ReadOnly = True
        Me.efectorTerminado.Width = 150
        '
        'cuieTerminado
        '
        Me.cuieTerminado.HeaderText = "CUIE"
        Me.cuieTerminado.Name = "cuieTerminado"
        Me.cuieTerminado.ReadOnly = True
        Me.cuieTerminado.Width = 50
        '
        'notificaciones
        '
        Me.notificaciones.HeaderText = "Notificaciones"
        Me.notificaciones.Name = "notificaciones"
        Me.notificaciones.ReadOnly = True
        '
        'id_notificaciones
        '
        Me.id_notificaciones.HeaderText = "id_notificaciones"
        Me.id_notificaciones.Name = "id_notificaciones"
        Me.id_notificaciones.ReadOnly = True
        Me.id_notificaciones.Visible = False
        '
        'carga
        '
        Me.carga.HeaderText = "Carga"
        Me.carga.Name = "carga"
        Me.carga.ReadOnly = True
        '
        'id_carga
        '
        Me.id_carga.HeaderText = "id_carga"
        Me.id_carga.Name = "id_carga"
        Me.id_carga.ReadOnly = True
        Me.id_carga.Visible = False
        '
        'perdidas
        '
        Me.perdidas.HeaderText = "Perdidas"
        Me.perdidas.Name = "perdidas"
        Me.perdidas.ReadOnly = True
        '
        'id_perdidas
        '
        Me.id_perdidas.HeaderText = "id_perdidas"
        Me.id_perdidas.Name = "id_perdidas"
        Me.id_perdidas.ReadOnly = True
        Me.id_perdidas.Visible = False
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
        'emision_resumen
        '
        Me.emision_resumen.HeaderText = "Emite Resumen"
        Me.emision_resumen.Name = "emision_resumen"
        Me.emision_resumen.ReadOnly = True
        '
        'id_emision_resumen
        '
        Me.id_emision_resumen.HeaderText = "id_emision_resumen"
        Me.id_emision_resumen.Name = "id_emision_resumen"
        Me.id_emision_resumen.ReadOnly = True
        Me.id_emision_resumen.Visible = False
        '
        'tiempo_notificacion
        '
        Me.tiempo_notificacion.HeaderText = "Notifica cada:"
        Me.tiempo_notificacion.Name = "tiempo_notificacion"
        Me.tiempo_notificacion.ReadOnly = True
        '
        'id_tiempo_notificacion
        '
        Me.id_tiempo_notificacion.HeaderText = "id_tiempo_notificacion"
        Me.id_tiempo_notificacion.Name = "id_tiempo_notificacion"
        Me.id_tiempo_notificacion.ReadOnly = True
        Me.id_tiempo_notificacion.Visible = False
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Width = 250
        '
        'Reporte
        '
        Me.Reporte.BackColor = System.Drawing.Color.Transparent
        Me.Reporte.Controls.Add(Me.cmd_notificaciones)
        Me.Reporte.Controls.Add(Me.cmd_agregar_reporte)
        Me.Reporte.Controls.Add(Me.txt_observaciones)
        Me.Reporte.Controls.Add(Me.Label11)
        Me.Reporte.Controls.Add(Me.cmb_notificaciones)
        Me.Reporte.Controls.Add(Me.Label10)
        Me.Reporte.Controls.Add(Me.cmb_stock)
        Me.Reporte.Controls.Add(Me.cmb_emite_resumen)
        Me.Reporte.Controls.Add(Me.cmb_tiempo_notificacion)
        Me.Reporte.Controls.Add(Me.cmb_perdidas)
        Me.Reporte.Controls.Add(Me.cmb_carga)
        Me.Reporte.Controls.Add(Me.Label9)
        Me.Reporte.Controls.Add(Me.Label8)
        Me.Reporte.Controls.Add(Me.Label5)
        Me.Reporte.Controls.Add(Me.Label7)
        Me.Reporte.Controls.Add(Me.Label6)
        Me.Reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Reporte.Location = New System.Drawing.Point(6, 313)
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Size = New System.Drawing.Size(491, 424)
        Me.Reporte.TabIndex = 14
        Me.Reporte.TabStop = False
        Me.Reporte.Text = "Reporte"
        '
        'cmd_notificaciones
        '
        Me.cmd_notificaciones.BackColor = System.Drawing.Color.Transparent
        Me.cmd_notificaciones.BackgroundImage = CType(resources.GetObject("cmd_notificaciones.BackgroundImage"), System.Drawing.Image)
        Me.cmd_notificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_notificaciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_notificaciones.FlatAppearance.BorderSize = 0
        Me.cmd_notificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_notificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_notificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_notificaciones.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.cmd_notificaciones.Location = New System.Drawing.Point(449, 28)
        Me.cmd_notificaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_notificaciones.Name = "cmd_notificaciones"
        Me.cmd_notificaciones.Size = New System.Drawing.Size(29, 25)
        Me.cmd_notificaciones.TabIndex = 59
        Me.cmd_notificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_notificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_notificaciones.UseVisualStyleBackColor = False
        '
        'cmd_agregar_reporte
        '
        Me.cmd_agregar_reporte.BackColor = System.Drawing.Color.Transparent
        Me.cmd_agregar_reporte.BackgroundImage = CType(resources.GetObject("cmd_agregar_reporte.BackgroundImage"), System.Drawing.Image)
        Me.cmd_agregar_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_agregar_reporte.FlatAppearance.BorderSize = 0
        Me.cmd_agregar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_agregar_reporte.Location = New System.Drawing.Point(430, 368)
        Me.cmd_agregar_reporte.Name = "cmd_agregar_reporte"
        Me.cmd_agregar_reporte.Size = New System.Drawing.Size(49, 50)
        Me.cmd_agregar_reporte.TabIndex = 7
        Me.cmd_agregar_reporte.UseVisualStyleBackColor = False
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(7, 219)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(476, 121)
        Me.txt_observaciones.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(9, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Observaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(20, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Notificaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(59, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Carga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(46, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Perdidas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(1, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notificacion cada:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(59, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(18, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Emite resumen"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dgv_vacunatorios)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 248)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selección de Vacunatorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(182, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Vacunatorios"
        '
        'cmd_buscar_añoYsemestre
        '
        Me.cmd_buscar_añoYsemestre.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_añoYsemestre.BackgroundImage = CType(resources.GetObject("cmd_buscar_añoYsemestre.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_añoYsemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_añoYsemestre.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_añoYsemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_añoYsemestre.Location = New System.Drawing.Point(1061, 19)
        Me.cmd_buscar_añoYsemestre.Name = "cmd_buscar_añoYsemestre"
        Me.cmd_buscar_añoYsemestre.Size = New System.Drawing.Size(35, 35)
        Me.cmd_buscar_añoYsemestre.TabIndex = 3
        Me.cmd_buscar_añoYsemestre.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(521, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Semestre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(395, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Año"
        '
        'dgv_vacunatorios
        '
        Me.dgv_vacunatorios.AllowUserToAddRows = False
        Me.dgv_vacunatorios.AllowUserToDeleteRows = False
        Me.dgv_vacunatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.efector, Me.departamento, Me.cuie})
        Me.dgv_vacunatorios.Location = New System.Drawing.Point(9, 32)
        Me.dgv_vacunatorios.Name = "dgv_vacunatorios"
        Me.dgv_vacunatorios.ReadOnly = True
        Me.dgv_vacunatorios.Size = New System.Drawing.Size(469, 207)
        Me.dgv_vacunatorios.TabIndex = 47
        '
        'cmb_año
        '
        Me.cmb_año._descripcion = "descripcion"
        Me.cmb_año._nombre_tabla = "REPORTES_AÑOS"
        Me.cmb_año._pk = "id"
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Location = New System.Drawing.Point(427, 27)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(81, 21)
        Me.cmb_año.TabIndex = 0
        '
        'cmb_notificaciones
        '
        Me.cmb_notificaciones._descripcion = "descripcion"
        Me.cmb_notificaciones._nombre_tabla = "ESTADO_NOTIF_REPORTES"
        Me.cmb_notificaciones._pk = "id"
        Me.cmb_notificaciones.FormattingEnabled = True
        Me.cmb_notificaciones.Location = New System.Drawing.Point(100, 31)
        Me.cmb_notificaciones.Name = "cmb_notificaciones"
        Me.cmb_notificaciones.Size = New System.Drawing.Size(342, 21)
        Me.cmb_notificaciones.TabIndex = 0
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = "descripcion"
        Me.cmb_stock._nombre_tabla = "ESTADO_INDICADORES"
        Me.cmb_stock._pk = "id"
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(100, 112)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(342, 21)
        Me.cmb_stock.TabIndex = 3
        '
        'cmb_emite_resumen
        '
        Me.cmb_emite_resumen._descripcion = "descripcion"
        Me.cmb_emite_resumen._nombre_tabla = "ESTADO_RM"
        Me.cmb_emite_resumen._pk = "id"
        Me.cmb_emite_resumen.FormattingEnabled = True
        Me.cmb_emite_resumen.Location = New System.Drawing.Point(100, 139)
        Me.cmb_emite_resumen.Name = "cmb_emite_resumen"
        Me.cmb_emite_resumen.Size = New System.Drawing.Size(342, 21)
        Me.cmb_emite_resumen.TabIndex = 4
        '
        'cmb_tiempo_notificacion
        '
        Me.cmb_tiempo_notificacion._descripcion = "descripcion"
        Me.cmb_tiempo_notificacion._nombre_tabla = "TIPO_NOTIFICACION"
        Me.cmb_tiempo_notificacion._pk = "id"
        Me.cmb_tiempo_notificacion.FormattingEnabled = True
        Me.cmb_tiempo_notificacion.Location = New System.Drawing.Point(100, 166)
        Me.cmb_tiempo_notificacion.Name = "cmb_tiempo_notificacion"
        Me.cmb_tiempo_notificacion.Size = New System.Drawing.Size(342, 21)
        Me.cmb_tiempo_notificacion.TabIndex = 5
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = "descripcion"
        Me.cmb_perdidas._nombre_tabla = "ESTADO_INDICADORES"
        Me.cmb_perdidas._pk = "id"
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(100, 85)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(342, 21)
        Me.cmb_perdidas.TabIndex = 2
        '
        'cmb_carga
        '
        Me.cmb_carga._descripcion = "descripcion"
        Me.cmb_carga._nombre_tabla = "ESTADO_INDICADORES"
        Me.cmb_carga._pk = "id"
        Me.cmb_carga.FormattingEnabled = True
        Me.cmb_carga.Location = New System.Drawing.Point(100, 58)
        Me.cmb_carga.Name = "cmb_carga"
        Me.cmb_carga.Size = New System.Drawing.Size(342, 21)
        Me.cmb_carga.TabIndex = 1
        '
        'cmb_semestre_reporte
        '
        Me.cmb_semestre_reporte._descripcion = "descripcion"
        Me.cmb_semestre_reporte._nombre_tabla = "SEMESTRES"
        Me.cmb_semestre_reporte._pk = "id"
        Me.cmb_semestre_reporte.FormattingEnabled = True
        Me.cmb_semestre_reporte.Location = New System.Drawing.Point(578, 27)
        Me.cmb_semestre_reporte.Name = "cmb_semestre_reporte"
        Me.cmb_semestre_reporte.Size = New System.Drawing.Size(105, 21)
        Me.cmb_semestre_reporte.TabIndex = 1
        '
        'efector
        '
        Me.efector.FillWeight = 150.0!
        Me.efector.HeaderText = "Vacunatorio"
        Me.efector.MinimumWidth = 10
        Me.efector.Name = "efector"
        Me.efector.ReadOnly = True
        Me.efector.Width = 290
        '
        'departamento
        '
        Me.departamento.HeaderText = "Departmaneto"
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        '
        'cuie
        '
        Me.cuie.FillWeight = 150.0!
        Me.cuie.HeaderText = "Cuie"
        Me.cuie.MinimumWidth = 10
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Width = 80
        '
        'Registro_de_reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registro_de_reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro_de_reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reporte.ResumeLayout(False)
        Me.Reporte.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_vacunatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_confirmar_reportes As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_reporte As System.Windows.Forms.Button
    Friend WithEvents dgv_reportes As System.Windows.Forms.DataGridView
    Friend WithEvents Reporte As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_agregar_reporte As System.Windows.Forms.Button
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_notificaciones As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_stock As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_emite_resumen As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_tiempo_notificacion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_perdidas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_añoYsemestre As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_semestre_reporte As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmd_notificaciones As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_año As ComboBoxV1
    Friend WithEvents tltp_reportes As ToolTip
    Friend WithEvents txt_responsable As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents efectorTerminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuieTerminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_notificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emision_resumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_emision_resumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiempo_notificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tiempo_notificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_efector_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents dgv_vacunatorios As System.Windows.Forms.DataGridView
    Friend WithEvents efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
