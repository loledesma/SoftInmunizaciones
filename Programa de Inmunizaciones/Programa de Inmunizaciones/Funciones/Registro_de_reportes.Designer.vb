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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_reportes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_confirmar_reportes = New System.Windows.Forms.Button()
        Me.cmd_eliminar_reporte = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Reporte = New System.Windows.Forms.GroupBox()
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
        Me.dgv_vacunatorios = New System.Windows.Forms.DataGridView()
        Me.efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_buscar_añoYsemestre = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_notificaciones = New System.Windows.Forms.Button()
        Me.cmb_notificaciones = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_emite_resumen = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_tiempo_notificacion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_semestre_reporte = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_año_reporte = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_notificoOk = New System.Windows.Forms.Label()
        Me.efectorTerminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuieTerminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emision_resumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo_notificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmd_salir.Location = New System.Drawing.Point(1471, 743)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(73, 71)
        Me.cmd_salir.TabIndex = 19
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmd_salir)
        Me.GroupBox1.Controls.Add(Me.Reporte)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_añoYsemestre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_semestre_reporte)
        Me.GroupBox1.Controls.Add(Me.cmb_año_reporte)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1554, 821)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "El GoupBox de los GroupBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmd_confirmar_reportes)
        Me.GroupBox2.Controls.Add(Me.cmd_eliminar_reporte)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(501, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1047, 678)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes realizados"
        '
        'cmd_confirmar_reportes
        '
        Me.cmd_confirmar_reportes.BackColor = System.Drawing.Color.Transparent
        Me.cmd_confirmar_reportes.BackgroundImage = CType(resources.GetObject("cmd_confirmar_reportes.BackgroundImage"), System.Drawing.Image)
        Me.cmd_confirmar_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_confirmar_reportes.FlatAppearance.BorderSize = 0
        Me.cmd_confirmar_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_confirmar_reportes.Location = New System.Drawing.Point(992, 622)
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
        Me.cmd_eliminar_reporte.Location = New System.Drawing.Point(937, 622)
        Me.cmd_eliminar_reporte.Name = "cmd_eliminar_reporte"
        Me.cmd_eliminar_reporte.Size = New System.Drawing.Size(49, 50)
        Me.cmd_eliminar_reporte.TabIndex = 18
        Me.cmd_eliminar_reporte.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.efectorTerminado, Me.cuieTerminado, Me.notificaciones, Me.carga, Me.perdidas, Me.stock, Me.emision_resumen, Me.tiempo_notificacion, Me.observaciones})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 594)
        Me.DataGridView1.TabIndex = 0
        '
        'Reporte
        '
        Me.Reporte.BackColor = System.Drawing.Color.Transparent
        Me.Reporte.Controls.Add(Me.lbl_notificoOk)
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
        Me.Reporte.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Reporte.Location = New System.Drawing.Point(6, 313)
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Size = New System.Drawing.Size(491, 424)
        Me.Reporte.TabIndex = 14
        Me.Reporte.TabStop = False
        Me.Reporte.Text = "Reporte"
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
        Me.txt_observaciones.Location = New System.Drawing.Point(9, 241)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(476, 121)
        Me.txt_observaciones.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(11, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Observaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(59, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Carga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(46, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Perdidas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(1, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notificacion cada:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(59, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(18, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Emite resumen"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dgv_vacunatorios)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
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
        'dgv_vacunatorios
        '
        Me.dgv_vacunatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.efector, Me.cuie})
        Me.dgv_vacunatorios.Location = New System.Drawing.Point(14, 32)
        Me.dgv_vacunatorios.Name = "dgv_vacunatorios"
        Me.dgv_vacunatorios.Size = New System.Drawing.Size(465, 207)
        Me.dgv_vacunatorios.TabIndex = 8
        '
        'efector
        '
        Me.efector.HeaderText = "Vacunatorio"
        Me.efector.Name = "efector"
        Me.efector.Width = 350
        '
        'cuie
        '
        Me.cuie.HeaderText = "CUIE"
        Me.cuie.Name = "cuie"
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
        Me.cmd_buscar_añoYsemestre.TabIndex = 12
        Me.cmd_buscar_añoYsemestre.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(395, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Año"
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
        'cmb_notificaciones
        '
        Me.cmb_notificaciones._descripcion = ""
        Me.cmb_notificaciones._nombre_tabla = ""
        Me.cmb_notificaciones._pk = ""
        Me.cmb_notificaciones.FormattingEnabled = True
        Me.cmb_notificaciones.Location = New System.Drawing.Point(100, 31)
        Me.cmb_notificaciones.Name = "cmb_notificaciones"
        Me.cmb_notificaciones.Size = New System.Drawing.Size(342, 21)
        Me.cmb_notificaciones.TabIndex = 14
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = ""
        Me.cmb_stock._nombre_tabla = ""
        Me.cmb_stock._pk = ""
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(100, 136)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(342, 21)
        Me.cmb_stock.TabIndex = 12
        '
        'cmb_emite_resumen
        '
        Me.cmb_emite_resumen._descripcion = ""
        Me.cmb_emite_resumen._nombre_tabla = ""
        Me.cmb_emite_resumen._pk = ""
        Me.cmb_emite_resumen.FormattingEnabled = True
        Me.cmb_emite_resumen.Location = New System.Drawing.Point(100, 163)
        Me.cmb_emite_resumen.Name = "cmb_emite_resumen"
        Me.cmb_emite_resumen.Size = New System.Drawing.Size(342, 21)
        Me.cmb_emite_resumen.TabIndex = 11
        '
        'cmb_tiempo_notificacion
        '
        Me.cmb_tiempo_notificacion._descripcion = ""
        Me.cmb_tiempo_notificacion._nombre_tabla = ""
        Me.cmb_tiempo_notificacion._pk = ""
        Me.cmb_tiempo_notificacion.FormattingEnabled = True
        Me.cmb_tiempo_notificacion.Location = New System.Drawing.Point(100, 190)
        Me.cmb_tiempo_notificacion.Name = "cmb_tiempo_notificacion"
        Me.cmb_tiempo_notificacion.Size = New System.Drawing.Size(342, 21)
        Me.cmb_tiempo_notificacion.TabIndex = 10
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = ""
        Me.cmb_perdidas._nombre_tabla = ""
        Me.cmb_perdidas._pk = ""
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(100, 109)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(342, 21)
        Me.cmb_perdidas.TabIndex = 9
        '
        'cmb_carga
        '
        Me.cmb_carga._descripcion = ""
        Me.cmb_carga._nombre_tabla = ""
        Me.cmb_carga._pk = ""
        Me.cmb_carga.FormattingEnabled = True
        Me.cmb_carga.Location = New System.Drawing.Point(100, 82)
        Me.cmb_carga.Name = "cmb_carga"
        Me.cmb_carga.Size = New System.Drawing.Size(342, 21)
        Me.cmb_carga.TabIndex = 7
        '
        'cmb_semestre_reporte
        '
        Me.cmb_semestre_reporte._descripcion = ""
        Me.cmb_semestre_reporte._nombre_tabla = ""
        Me.cmb_semestre_reporte._pk = ""
        Me.cmb_semestre_reporte.FormattingEnabled = True
        Me.cmb_semestre_reporte.Location = New System.Drawing.Point(578, 27)
        Me.cmb_semestre_reporte.Name = "cmb_semestre_reporte"
        Me.cmb_semestre_reporte.Size = New System.Drawing.Size(105, 21)
        Me.cmb_semestre_reporte.TabIndex = 9
        '
        'cmb_año_reporte
        '
        Me.cmb_año_reporte._descripcion = ""
        Me.cmb_año_reporte._nombre_tabla = ""
        Me.cmb_año_reporte._pk = ""
        Me.cmb_año_reporte.FormattingEnabled = True
        Me.cmb_año_reporte.Location = New System.Drawing.Point(440, 27)
        Me.cmb_año_reporte.Name = "cmb_año_reporte"
        Me.cmb_año_reporte.Size = New System.Drawing.Size(65, 21)
        Me.cmb_año_reporte.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(689, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hospital de Referencia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(810, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 22)
        Me.TextBox1.TabIndex = 60
        '
        'lbl_notificoOk
        '
        Me.lbl_notificoOk.AutoSize = True
        Me.lbl_notificoOk.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notificoOk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_notificoOk.Location = New System.Drawing.Point(97, 55)
        Me.lbl_notificoOk.Name = "lbl_notificoOk"
        Me.lbl_notificoOk.Size = New System.Drawing.Size(37, 13)
        Me.lbl_notificoOk.TabIndex = 60
        Me.lbl_notificoOk.Text = "----------"
        '
        'efectorTerminado
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.efectorTerminado.DefaultCellStyle = DataGridViewCellStyle1
        Me.efectorTerminado.FillWeight = 150.0!
        Me.efectorTerminado.HeaderText = "Vacunatorio"
        Me.efectorTerminado.MinimumWidth = 10
        Me.efectorTerminado.Name = "efectorTerminado"
        Me.efectorTerminado.Width = 150
        '
        'cuieTerminado
        '
        Me.cuieTerminado.HeaderText = "CUIE"
        Me.cuieTerminado.Name = "cuieTerminado"
        Me.cuieTerminado.Width = 50
        '
        'notificaciones
        '
        Me.notificaciones.HeaderText = "Notificaciones"
        Me.notificaciones.Name = "notificaciones"
        '
        'carga
        '
        Me.carga.HeaderText = "Carga"
        Me.carga.Name = "carga"
        '
        'perdidas
        '
        Me.perdidas.HeaderText = "Perdidas"
        Me.perdidas.Name = "perdidas"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'emision_resumen
        '
        Me.emision_resumen.HeaderText = "Emite Resumen"
        Me.emision_resumen.Name = "emision_resumen"
        '
        'tiempo_notificacion
        '
        Me.tiempo_notificacion.HeaderText = "Notifica cada:"
        Me.tiempo_notificacion.Name = "tiempo_notificacion"
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Width = 250
        '
        'Registro_de_reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1574, 840)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registro_de_reportes"
        Me.Text = "Registro_de_reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_vacunatorios As System.Windows.Forms.DataGridView
    Friend WithEvents efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_buscar_añoYsemestre As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_semestre_reporte As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_año_reporte As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmd_notificaciones As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_notificoOk As System.Windows.Forms.Label
    Friend WithEvents efectorTerminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuieTerminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emision_resumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiempo_notificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
