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
        Me.txt_efector = New System.Windows.Forms.TextBox()
        Me.lbl_efector = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmb_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.cmb_estado_atencion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_id_notificacion = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.dgv_atenciones = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.grp_datos_atencion.SuspendLayout()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_descripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos_atencion
        '
        Me.grp_datos_atencion.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_atencion.Controls.Add(Me.txt_cuie)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_atencion.Controls.Add(Me.txt_efector)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_efector)
        Me.grp_datos_atencion.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_atencion.Controls.Add(Me.cmb_empleados)
        Me.grp_datos_atencion.Controls.Add(Me.Label1)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_atencion.Controls.Add(Me.cmb_estado_atencion)
        Me.grp_datos_atencion.Controls.Add(Me.txt_id_notificacion)
        Me.grp_datos_atencion.Controls.Add(Me.txt_fecha)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_atencion.Controls.Add(Me.lbl_estado)
        Me.grp_datos_atencion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_atencion.Location = New System.Drawing.Point(22, 12)
        Me.grp_datos_atencion.Name = "grp_datos_atencion"
        Me.grp_datos_atencion.Size = New System.Drawing.Size(403, 204)
        Me.grp_datos_atencion.TabIndex = 1
        Me.grp_datos_atencion.TabStop = False
        Me.grp_datos_atencion.Text = "Datos Notificación"
        '
        'txt_efector
        '
        Me.txt_efector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efector.Location = New System.Drawing.Point(111, 161)
        Me.txt_efector.Name = "txt_efector"
        Me.txt_efector.Size = New System.Drawing.Size(247, 20)
        Me.txt_efector.TabIndex = 57
        '
        'lbl_efector
        '
        Me.lbl_efector.AutoSize = True
        Me.lbl_efector.Location = New System.Drawing.Point(7, 161)
        Me.lbl_efector.Name = "lbl_efector"
        Me.lbl_efector.Size = New System.Drawing.Size(41, 13)
        Me.lbl_efector.TabIndex = 56
        Me.lbl_efector.Text = "Efector"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackgroundImage = CType(resources.GetObject("cmd_buscar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.Location = New System.Drawing.Point(367, 156)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar.TabIndex = 55
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmb_empleados
        '
        Me.cmb_empleados._descripcion = "nombres"
        Me.cmb_empleados._nombre_tabla = "EMPLEADOS"
        Me.cmb_empleados._pk = "id"
        Me.cmb_empleados.FormattingEnabled = True
        Me.cmb_empleados.Location = New System.Drawing.Point(111, 107)
        Me.cmb_empleados.Name = "cmb_empleados"
        Me.cmb_empleados.Size = New System.Drawing.Size(279, 21)
        Me.cmb_empleados.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Administrador"
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
        'cmb_estado_atencion
        '
        Me.cmb_estado_atencion._descripcion = "descripcion"
        Me.cmb_estado_atencion._nombre_tabla = "ESTADOS_ATENCION"
        Me.cmb_estado_atencion._pk = "id"
        Me.cmb_estado_atencion.FormattingEnabled = True
        Me.cmb_estado_atencion.Location = New System.Drawing.Point(111, 75)
        Me.cmb_estado_atencion.Name = "cmb_estado_atencion"
        Me.cmb_estado_atencion.Size = New System.Drawing.Size(247, 21)
        Me.cmb_estado_atencion.TabIndex = 2
        '
        'txt_id_notificacion
        '
        Me.txt_id_notificacion.Location = New System.Drawing.Point(109, 21)
        Me.txt_id_notificacion.Name = "txt_id_notificacion"
        Me.txt_id_notificacion.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_notificacion.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(110, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 1
        Me.txt_fecha.ValidatingType = GetType(Date)
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
        Me.dgv_atenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.estado, Me.id_estado, Me.efector, Me.cuie, Me.id_administrador, Me.administrador, Me.descripcion})
        Me.dgv_atenciones.Location = New System.Drawing.Point(443, 12)
        Me.dgv_atenciones.Name = "dgv_atenciones"
        Me.dgv_atenciones.ReadOnly = True
        Me.dgv_atenciones.Size = New System.Drawing.Size(656, 488)
        Me.dgv_atenciones.TabIndex = 47
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
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
        'efector
        '
        Me.efector.HeaderText = "Efector"
        Me.efector.Name = "efector"
        Me.efector.ReadOnly = True
        Me.efector.Width = 200
        '
        'cuie
        '
        Me.cuie.HeaderText = "cuie"
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        Me.cuie.Visible = False
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
        Me.administrador.Visible = False
        Me.administrador.Width = 150
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'grp_descripcion
        '
        Me.grp_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_descripcion.Location = New System.Drawing.Point(22, 233)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(403, 267)
        Me.grp_descripcion.TabIndex = 55
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(19, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(372, 238)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(165, 521)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 58
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
        Me.cmd_guardar.Location = New System.Drawing.Point(97, 522)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 56
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(29, 522)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 57
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
        Me.cmd_salir.Location = New System.Drawing.Point(1041, 522)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 59
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(9, 135)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuie.TabIndex = 58
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(111, 135)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(150, 20)
        Me.txt_cuie.TabIndex = 59
        '
        'Registrar_atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1113, 594)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.dgv_atenciones)
        Me.Controls.Add(Me.grp_datos_atencion)
        Me.Name = "Registrar_atencion"
        Me.Text = "ATENCIONES"
        Me.grp_datos_atencion.ResumeLayout(False)
        Me.grp_datos_atencion.PerformLayout()
        CType(Me.dgv_atenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_descripcion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_atencion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_atencion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_notificacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_atenciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_efector As System.Windows.Forms.TextBox
    Friend WithEvents lbl_efector As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents efector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
End Class
