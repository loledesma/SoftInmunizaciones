<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_barrios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_barrios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grp_barrios = New System.Windows.Forms.GroupBox()
        Me.cmb_dptos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_buscar_descripcion = New System.Windows.Forms.Button()
        Me.cmd_buscar_id = New System.Windows.Forms.Button()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_id_barrio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_barrios = New System.Windows.Forms.DataGridView()
        Me.id_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.grp_barrios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_barrios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_barrios
        '
        Me.grp_barrios.BackColor = System.Drawing.Color.Transparent
        Me.grp_barrios.Controls.Add(Me.cmb_dptos)
        Me.grp_barrios.Controls.Add(Me.Label4)
        Me.grp_barrios.Controls.Add(Me.cmd_buscar_descripcion)
        Me.grp_barrios.Controls.Add(Me.cmd_buscar_id)
        Me.grp_barrios.Controls.Add(Me.cmb_localidades)
        Me.grp_barrios.Controls.Add(Me.txt_descripcion)
        Me.grp_barrios.Controls.Add(Me.txt_id_barrio)
        Me.grp_barrios.Controls.Add(Me.Label3)
        Me.grp_barrios.Controls.Add(Me.Label2)
        Me.grp_barrios.Controls.Add(Me.Label1)
        Me.grp_barrios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_barrios.Location = New System.Drawing.Point(12, 12)
        Me.grp_barrios.Name = "grp_barrios"
        Me.grp_barrios.Size = New System.Drawing.Size(521, 85)
        Me.grp_barrios.TabIndex = 0
        Me.grp_barrios.TabStop = False
        Me.grp_barrios.Text = "Datos"
        '
        'cmb_dptos
        '
        Me.cmb_dptos._descripcion = "descripcion"
        Me.cmb_dptos._nombre_tabla = "departamentos"
        Me.cmb_dptos._pk = "id"
        Me.cmb_dptos.FormattingEnabled = True
        Me.cmb_dptos.Location = New System.Drawing.Point(68, 49)
        Me.cmb_dptos.Name = "cmb_dptos"
        Me.cmb_dptos.Size = New System.Drawing.Size(140, 21)
        Me.cmb_dptos.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Localidad"
        '
        'cmd_buscar_descripcion
        '
        Me.cmd_buscar_descripcion.BackgroundImage = CType(resources.GetObject("cmd_buscar_descripcion.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_descripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_descripcion.Location = New System.Drawing.Point(490, 23)
        Me.cmd_buscar_descripcion.Name = "cmd_buscar_descripcion"
        Me.cmd_buscar_descripcion.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_descripcion.TabIndex = 7
        Me.cmd_buscar_descripcion.UseVisualStyleBackColor = True
        '
        'cmd_buscar_id
        '
        Me.cmd_buscar_id.BackgroundImage = CType(resources.GetObject("cmd_buscar_id.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_id.Location = New System.Drawing.Point(135, 20)
        Me.cmd_buscar_id.Name = "cmd_buscar_id"
        Me.cmd_buscar_id.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_id.TabIndex = 6
        Me.cmd_buscar_id.UseVisualStyleBackColor = True
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "localidades"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(279, 49)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(205, 21)
        Me.cmb_localidades.TabIndex = 5
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(279, 23)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(205, 20)
        Me.txt_descripcion.TabIndex = 4
        '
        'txt_id_barrio
        '
        Me.txt_id_barrio.Location = New System.Drawing.Point(71, 23)
        Me.txt_id_barrio.Name = "txt_id_barrio"
        Me.txt_id_barrio.Size = New System.Drawing.Size(58, 20)
        Me.txt_id_barrio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dpto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barrio"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgv_barrios)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 210)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existentes"
        '
        'dgv_barrios
        '
        Me.dgv_barrios.AllowUserToAddRows = False
        Me.dgv_barrios.AllowUserToDeleteRows = False
        Me.dgv_barrios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barrio, Me.barrio, Me.id_localidad, Me.localidad})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_barrios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_barrios.Location = New System.Drawing.Point(6, 19)
        Me.dgv_barrios.Name = "dgv_barrios"
        Me.dgv_barrios.ReadOnly = True
        Me.dgv_barrios.Size = New System.Drawing.Size(509, 185)
        Me.dgv_barrios.TabIndex = 0
        '
        'id_barrio
        '
        Me.id_barrio.HeaderText = "ID Barrio"
        Me.id_barrio.Name = "id_barrio"
        Me.id_barrio.ReadOnly = True
        Me.id_barrio.Width = 30
        '
        'barrio
        '
        Me.barrio.HeaderText = "Barrio"
        Me.barrio.Name = "barrio"
        Me.barrio.ReadOnly = True
        Me.barrio.Width = 200
        '
        'id_localidad
        '
        Me.id_localidad.HeaderText = "ID Localidad"
        Me.id_localidad.Name = "id_localidad"
        Me.id_localidad.ReadOnly = True
        Me.id_localidad.Width = 30
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 200
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(473, 320)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 11
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(217, 320)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 10
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_limpiar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.BackgroundImage = CType(resources.GetObject("cmd_guardar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_guardar.FlatAppearance.BorderSize = 0
        Me.cmd_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.Location = New System.Drawing.Point(81, 320)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 7
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(13, 320)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_nuevo.UseVisualStyleBackColor = False
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(149, 320)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_eliminar.TabIndex = 8
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'abm_barrios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(545, 389)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_barrios)
        Me.Name = "abm_barrios"
        Me.Text = "Barrios"
        Me.grp_barrios.ResumeLayout(False)
        Me.grp_barrios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_barrios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_barrios As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_barrio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_barrios As System.Windows.Forms.DataGridView
    Friend WithEvents id_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_descripcion As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_id As System.Windows.Forms.Button
    Friend WithEvents cmb_dptos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
