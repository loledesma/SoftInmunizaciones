<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_ingreso_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_ingreso_stock))
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.id_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_stock = New System.Windows.Forms.GroupBox()
        Me.cmb_buscar_tipo = New System.Windows.Forms.Button()
        Me.cmd_buscar_marca = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_nro_serie = New System.Windows.Forms.TextBox()
        Me.cmb_marca = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_insumos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.lbl_contador_monitores = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_contador_heladeras = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_contador_cpu = New System.Windows.Forms.Label()
        Me.lbl_contador_termos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tltp_stock = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_stock.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salir.Location = New System.Drawing.Point(931, 351)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(70, 60)
        Me.cmd_salir.TabIndex = 4
        Me.cmd_salir.UseVisualStyleBackColor = False
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
        Me.cmd_guardar.Location = New System.Drawing.Point(94, 352)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(70, 60)
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(15, 352)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(70, 60)
        Me.cmd_nuevo.TabIndex = 1
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.AllowUserToDeleteRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_insumo, Me.id_marca, Me.insumo, Me.nro_serie, Me.modelo, Me.marca, Me.cantidad})
        Me.dgv_stock.Location = New System.Drawing.Point(14, 191)
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.Size = New System.Drawing.Size(987, 154)
        Me.dgv_stock.TabIndex = 66
        '
        'id_insumo
        '
        Me.id_insumo.HeaderText = "id_insumo"
        Me.id_insumo.Name = "id_insumo"
        Me.id_insumo.ReadOnly = True
        Me.id_insumo.Visible = False
        '
        'id_marca
        '
        Me.id_marca.HeaderText = "id_marca"
        Me.id_marca.Name = "id_marca"
        Me.id_marca.ReadOnly = True
        Me.id_marca.Visible = False
        '
        'insumo
        '
        Me.insumo.HeaderText = "Insumo"
        Me.insumo.Name = "insumo"
        Me.insumo.ReadOnly = True
        Me.insumo.Width = 300
        '
        'nro_serie
        '
        Me.nro_serie.HeaderText = "Numero de Serie"
        Me.nro_serie.Name = "nro_serie"
        Me.nro_serie.ReadOnly = True
        Me.nro_serie.Width = 150
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 150
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'grp_stock
        '
        Me.grp_stock.BackColor = System.Drawing.Color.Transparent
        Me.grp_stock.Controls.Add(Me.cmb_buscar_tipo)
        Me.grp_stock.Controls.Add(Me.cmd_buscar_marca)
        Me.grp_stock.Controls.Add(Me.txt_cantidad)
        Me.grp_stock.Controls.Add(Me.Label3)
        Me.grp_stock.Controls.Add(Me.txt_modelo)
        Me.grp_stock.Controls.Add(Me.txt_nro_serie)
        Me.grp_stock.Controls.Add(Me.cmb_marca)
        Me.grp_stock.Controls.Add(Me.Label11)
        Me.grp_stock.Controls.Add(Me.Label10)
        Me.grp_stock.Controls.Add(Me.Label9)
        Me.grp_stock.Controls.Add(Me.cmb_insumos)
        Me.grp_stock.Controls.Add(Me.Label8)
        Me.grp_stock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_stock.Location = New System.Drawing.Point(19, 12)
        Me.grp_stock.Name = "grp_stock"
        Me.grp_stock.Size = New System.Drawing.Size(502, 173)
        Me.grp_stock.TabIndex = 0
        Me.grp_stock.TabStop = False
        Me.grp_stock.Text = "Ingreso"
        '
        'cmb_buscar_tipo
        '
        Me.cmb_buscar_tipo.BackgroundImage = CType(resources.GetObject("cmb_buscar_tipo.BackgroundImage"), System.Drawing.Image)
        Me.cmb_buscar_tipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmb_buscar_tipo.FlatAppearance.BorderSize = 0
        Me.cmb_buscar_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_buscar_tipo.Location = New System.Drawing.Point(454, 16)
        Me.cmb_buscar_tipo.Name = "cmb_buscar_tipo"
        Me.cmb_buscar_tipo.Size = New System.Drawing.Size(29, 27)
        Me.cmb_buscar_tipo.TabIndex = 80
        Me.cmb_buscar_tipo.UseVisualStyleBackColor = True
        '
        'cmd_buscar_marca
        '
        Me.cmd_buscar_marca.BackgroundImage = CType(resources.GetObject("cmd_buscar_marca.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_marca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_marca.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_marca.Location = New System.Drawing.Point(454, 101)
        Me.cmd_buscar_marca.Name = "cmd_buscar_marca"
        Me.cmd_buscar_marca.Size = New System.Drawing.Size(29, 27)
        Me.cmd_buscar_marca.TabIndex = 74
        Me.cmd_buscar_marca.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(114, 133)
        Me.txt_cantidad.Mask = "9999999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(114, 21)
        Me.txt_cantidad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Cantidad"
        '
        'txt_modelo
        '
        Me.txt_modelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_modelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_modelo.Location = New System.Drawing.Point(113, 76)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(329, 21)
        Me.txt_modelo.TabIndex = 2
        '
        'txt_nro_serie
        '
        Me.txt_nro_serie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_nro_serie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nro_serie.Location = New System.Drawing.Point(112, 47)
        Me.txt_nro_serie.Name = "txt_nro_serie"
        Me.txt_nro_serie.Size = New System.Drawing.Size(329, 21)
        Me.txt_nro_serie.TabIndex = 1
        '
        'cmb_marca
        '
        Me.cmb_marca._descripcion = "descripcion"
        Me.cmb_marca._nombre_tabla = "MARCA"
        Me.cmb_marca._pk = "id"
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(114, 102)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(186, 21)
        Me.cmb_marca.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Marca"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Nro de Serie"
        '
        'cmb_insumos
        '
        Me.cmb_insumos._descripcion = "descripcion"
        Me.cmb_insumos._nombre_tabla = "INSUMOS"
        Me.cmb_insumos._pk = "id"
        Me.cmb_insumos.FormattingEnabled = True
        Me.cmb_insumos.Location = New System.Drawing.Point(112, 19)
        Me.cmb_insumos.Name = "cmb_insumos"
        Me.cmb_insumos.Size = New System.Drawing.Size(287, 21)
        Me.cmb_insumos.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(174, 354)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(70, 60)
        Me.cmd_limpiar.TabIndex = 3
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar.UseVisualStyleBackColor = False
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(253, 354)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(70, 60)
        Me.cmd_eliminar.TabIndex = 67
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'lbl_contador_monitores
        '
        Me.lbl_contador_monitores.AutoSize = True
        Me.lbl_contador_monitores.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_monitores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_monitores.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_monitores.Location = New System.Drawing.Point(647, 44)
        Me.lbl_contador_monitores.Name = "lbl_contador_monitores"
        Me.lbl_contador_monitores.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_monitores.TabIndex = 69
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(527, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 17)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Monitores :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(527, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Heladeras :"
        '
        'lbl_contador_heladeras
        '
        Me.lbl_contador_heladeras.AutoSize = True
        Me.lbl_contador_heladeras.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_heladeras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_heladeras.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_heladeras.Location = New System.Drawing.Point(642, 124)
        Me.lbl_contador_heladeras.Name = "lbl_contador_heladeras"
        Me.lbl_contador_heladeras.Size = New System.Drawing.Size(0, 16)
        Me.lbl_contador_heladeras.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(527, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "CPUs :"
        '
        'lbl_contador_cpu
        '
        Me.lbl_contador_cpu.AutoSize = True
        Me.lbl_contador_cpu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_cpu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_contador_cpu.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_cpu.Location = New System.Drawing.Point(602, 83)
        Me.lbl_contador_cpu.Name = "lbl_contador_cpu"
        Me.lbl_contador_cpu.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_cpu.TabIndex = 73
        '
        'lbl_contador_termos
        '
        Me.lbl_contador_termos.AutoSize = True
        Me.lbl_contador_termos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contador_termos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador_termos.ForeColor = System.Drawing.Color.White
        Me.lbl_contador_termos.Location = New System.Drawing.Point(647, 163)
        Me.lbl_contador_termos.Name = "lbl_contador_termos"
        Me.lbl_contador_termos.Size = New System.Drawing.Size(0, 17)
        Me.lbl_contador_termos.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(527, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Termos :"
        '
        'Registrar_ingreso_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 420)
        Me.Controls.Add(Me.lbl_contador_termos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_contador_cpu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_contador_heladeras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_contador_monitores)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.grp_stock)
        Me.Controls.Add(Me.dgv_stock)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_salir)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Registrar_ingreso_stock"
        Me.Text = "STOCK"
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_stock.ResumeLayout(False)
        Me.grp_stock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents dgv_stock As System.Windows.Forms.DataGridView
    Friend WithEvents grp_stock As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_marca As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_insumos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_nro_serie As System.Windows.Forms.TextBox
    Friend WithEvents id_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_contador_monitores As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_heladeras As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_contador_cpu As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_marca As System.Windows.Forms.Button
    Friend WithEvents cmb_buscar_tipo As System.Windows.Forms.Button
    Friend WithEvents lbl_contador_termos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tltp_stock As System.Windows.Forms.ToolTip
End Class
