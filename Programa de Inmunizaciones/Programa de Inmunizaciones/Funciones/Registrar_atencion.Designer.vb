<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_atencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_atencion))
        Me.grp_datos_atencion = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar_notificaciones = New System.Windows.Forms.Button()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_c = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_notificacion = New System.Windows.Forms.TextBox()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_perdidas = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.dgv_atenciones = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perdidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_atencion.SuspendLayout()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_atencion
        '
        Me.grp_datos_atencion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_atencion.Controls.Add(Me.cmd_buscar_notificaciones)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_atencion.Controls.Add(Me.cmb_c)
        Me.grp_datos_atencion.Controls.Add(Me.cmb_stock)
        Me.grp_datos_atencion.Controls.Add(Me.txt_id_notificacion)
        Me.grp_datos_atencion.Controls.Add(Me.cmb_perdidas)
        Me.grp_datos_atencion.Controls.Add(Me.txt_fecha)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_stock)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_perdidas)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_estado)
        Me.grp_datos_atencion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_atencion.Location = New System.Drawing.Point(22, 12)
        Me.grp_datos_atencion.Name = "grp_datos_atencion"
        Me.grp_datos_atencion.Size = New System.Drawing.Size(403, 161)
        Me.grp_datos_atencion.TabIndex = 1
        Me.grp_datos_atencion.TabStop = False
        Me.grp_datos_atencion.Text = "Datos Notificación"
        '
        'cmd_buscar_notificaciones
        '
        Me.cmd_buscar_notificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_notificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_notificaciones.Location = New System.Drawing.Point(352, 15)
        Me.cmd_buscar_notificaciones.Name = "cmd_buscar_notificaciones"
        Me.cmd_buscar_notificaciones.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar_notificaciones.TabIndex = 5
        Me.cmd_buscar_notificaciones.UseVisualStyleBackColor = True
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
        'cmb_c
        '
        Me.cmb_c._descripcion = "descripcion"
        Me.cmb_c._nombre_tabla = "CARGA"
        Me.cmb_c._pk = "id"
        Me.cmb_c.FormattingEnabled = True
        Me.cmb_c.Location = New System.Drawing.Point(113, 74)
        Me.cmb_c.Name = "cmb_c"
        Me.cmb_c.Size = New System.Drawing.Size(216, 21)
        Me.cmb_c.TabIndex = 2
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = "descripcion"
        Me.cmb_stock._nombre_tabla = "STOCK"
        Me.cmb_stock._pk = "id"
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(113, 127)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(217, 21)
        Me.cmb_stock.TabIndex = 4
        '
        'txt_id_notificacion
        '
        Me.txt_id_notificacion.Location = New System.Drawing.Point(114, 21)
        Me.txt_id_notificacion.Name = "txt_id_notificacion"
        Me.txt_id_notificacion.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_notificacion.TabIndex = 0
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = "descripcion"
        Me.cmb_perdidas._nombre_tabla = "PERDIDAS"
        Me.cmb_perdidas._pk = "id"
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(113, 101)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(216, 21)
        Me.cmb_perdidas.TabIndex = 3
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(114, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 1
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(7, 129)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(35, 13)
        Me.lbl_stock.TabIndex = 32
        Me.lbl_stock.Text = "Stock"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Location = New System.Drawing.Point(7, 52)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(37, 13)
        Me.lbl_perfil.TabIndex = 49
        Me.lbl_perfil.Text = "Fecha"
        '
        'lbl_perdidas
        '
        Me.lbl_perdidas.AutoSize = True
        Me.lbl_perdidas.Location = New System.Drawing.Point(7, 103)
        Me.lbl_perdidas.Name = "lbl_perdidas"
        Me.lbl_perdidas.Size = New System.Drawing.Size(48, 13)
        Me.lbl_perdidas.TabIndex = 31
        Me.lbl_perdidas.Text = "Perdidas"
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(7, 79)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(85, 13)
        Me.lbl_estado.TabIndex = 30
        Me.lbl_estado.Text = "Estado Atención"
        '
        'dgv_atenciones
        '
        Me.dgv_atenciones.AllowUserToAddRows = False
        Me.dgv_atenciones.AllowUserToDeleteRows = False
        Me.dgv_atenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_atenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.nombre_efector, Me.carga, Me.perdidas, Me.stock, Me.id_stock, Me.id_carga, Me.id_perdidas, Me.id_efector, Me.id})
        Me.dgv_atenciones.Location = New System.Drawing.Point(500, 12)
        Me.dgv_atenciones.Name = "dgv_atenciones"
        Me.dgv_atenciones.ReadOnly = True
        Me.dgv_atenciones.Size = New System.Drawing.Size(628, 437)
        Me.dgv_atenciones.TabIndex = 47
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
        'id_carga
        '
        Me.id_carga.HeaderText = "id_carga"
        Me.id_carga.Name = "id_carga"
        Me.id_carga.ReadOnly = True
        Me.id_carga.Visible = False
        '
        'id_perdidas
        '
        Me.id_perdidas.HeaderText = "id_perdidas"
        Me.id_perdidas.Name = "id_perdidas"
        Me.id_perdidas.ReadOnly = True
        Me.id_perdidas.Visible = False
        '
        'id_efector
        '
        Me.id_efector.HeaderText = "id_efector"
        Me.id_efector.Name = "id_efector"
        Me.id_efector.ReadOnly = True
        Me.id_efector.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Registrar_atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1157, 460)
        Me.Controls.Add(Me.dgv_atenciones)
        Me.Controls.Add(Me.grp_datos_atencion)
        Me.Name = "Registrar_atencion"
        Me.Text = "ATENCIONES"
        Me.grp_datos_atencion.ResumeLayout(False)
        Me.grp_datos_atencion.PerformLayout()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_atencion As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscar_notificaciones As System.Windows.Forms.Button
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_c As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_stock As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_notificacion As System.Windows.Forms.TextBox
    Friend WithEvents cmb_perdidas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_perdidas As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_atenciones As System.Windows.Forms.DataGridView
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perdidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
