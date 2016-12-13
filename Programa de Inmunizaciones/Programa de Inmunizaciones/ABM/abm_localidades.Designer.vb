<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_localidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_localidades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_buscar_nombre = New System.Windows.Forms.Button()
        Me.cmb_dptos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_buscar_codpostal = New System.Windows.Forms.Button()
        Me.txt_cod_postal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_buscar_id = New System.Windows.Forms.Button()
        Me.txt_id_localidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_localidades = New System.Windows.Forms.DataGridView()
        Me.id_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_dpto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_filtrar_dptos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_localidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(439, 305)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 6
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_cancelar.BackgroundImage = CType(resources.GetObject("cmd_cancelar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_cancelar.FlatAppearance.BorderSize = 0
        Me.cmd_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_cancelar.Location = New System.Drawing.Point(217, 305)
        Me.cmd_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancelar.UseVisualStyleBackColor = False
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
        Me.cmd_guardar.Location = New System.Drawing.Point(81, 305)
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(13, 305)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 4
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(149, 305)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_eliminar.TabIndex = 3
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_filtrar_dptos)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_nombre)
        Me.GroupBox1.Controls.Add(Me.cmb_dptos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_codpostal)
        Me.GroupBox1.Controls.Add(Me.txt_cod_postal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_id)
        Me.GroupBox1.Controls.Add(Me.txt_id_localidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'cmd_buscar_nombre
        '
        Me.cmd_buscar_nombre.BackgroundImage = CType(resources.GetObject("cmd_buscar_nombre.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_nombre.Location = New System.Drawing.Point(455, 23)
        Me.cmd_buscar_nombre.Name = "cmd_buscar_nombre"
        Me.cmd_buscar_nombre.Size = New System.Drawing.Size(26, 25)
        Me.cmd_buscar_nombre.TabIndex = 9
        Me.cmd_buscar_nombre.UseVisualStyleBackColor = True
        '
        'cmb_dptos
        '
        Me.cmb_dptos._descripcion = "descripcion"
        Me.cmb_dptos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_dptos._pk = "id"
        Me.cmb_dptos.FormattingEnabled = True
        Me.cmb_dptos.Location = New System.Drawing.Point(277, 52)
        Me.cmb_dptos.Name = "cmb_dptos"
        Me.cmb_dptos.Size = New System.Drawing.Size(170, 21)
        Me.cmb_dptos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Departamento"
        '
        'cmd_buscar_codpostal
        '
        Me.cmd_buscar_codpostal.BackgroundImage = CType(resources.GetObject("cmd_buscar_codpostal.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_codpostal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_codpostal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_codpostal.Location = New System.Drawing.Point(167, 49)
        Me.cmd_buscar_codpostal.Name = "cmd_buscar_codpostal"
        Me.cmd_buscar_codpostal.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_codpostal.TabIndex = 3
        Me.cmd_buscar_codpostal.UseVisualStyleBackColor = True
        '
        'txt_cod_postal
        '
        Me.txt_cod_postal.Location = New System.Drawing.Point(91, 52)
        Me.txt_cod_postal.Name = "txt_cod_postal"
        Me.txt_cod_postal.Size = New System.Drawing.Size(70, 20)
        Me.txt_cod_postal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cod. Postal"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(277, 26)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(170, 20)
        Me.txt_descripcion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'cmd_buscar_id
        '
        Me.cmd_buscar_id.BackgroundImage = CType(resources.GetObject("cmd_buscar_id.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_id.Location = New System.Drawing.Point(167, 23)
        Me.cmd_buscar_id.Name = "cmd_buscar_id"
        Me.cmd_buscar_id.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_id.TabIndex = 1
        Me.cmd_buscar_id.UseVisualStyleBackColor = True
        '
        'txt_id_localidad
        '
        Me.txt_id_localidad.Location = New System.Drawing.Point(91, 26)
        Me.txt_id_localidad.Name = "txt_id_localidad"
        Me.txt_id_localidad.Size = New System.Drawing.Size(70, 20)
        Me.txt_id_localidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Localidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgv_localidades)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Existentes"
        '
        'dgv_localidades
        '
        Me.dgv_localidades.AllowUserToAddRows = False
        Me.dgv_localidades.AllowUserToDeleteRows = False
        Me.dgv_localidades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_localidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_localidad, Me.cod_postal, Me.descripcion, Me.id_dpto, Me.dpto})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_localidades.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_localidades.Location = New System.Drawing.Point(9, 19)
        Me.dgv_localidades.Name = "dgv_localidades"
        Me.dgv_localidades.ReadOnly = True
        Me.dgv_localidades.Size = New System.Drawing.Size(472, 167)
        Me.dgv_localidades.TabIndex = 0
        '
        'id_localidad
        '
        Me.id_localidad.HeaderText = "ID"
        Me.id_localidad.Name = "id_localidad"
        Me.id_localidad.ReadOnly = True
        Me.id_localidad.Width = 30
        '
        'cod_postal
        '
        Me.cod_postal.HeaderText = "Cod. Postal"
        Me.cod_postal.Name = "cod_postal"
        Me.cod_postal.ReadOnly = True
        Me.cod_postal.Width = 45
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'id_dpto
        '
        Me.id_dpto.HeaderText = "ID Dpto"
        Me.id_dpto.Name = "id_dpto"
        Me.id_dpto.ReadOnly = True
        Me.id_dpto.Width = 30
        '
        'dpto
        '
        Me.dpto.HeaderText = "Departamento"
        Me.dpto.Name = "dpto"
        Me.dpto.ReadOnly = True
        Me.dpto.Width = 175
        '
        'cmd_filtrar_dptos
        '
        Me.cmd_filtrar_dptos.BackgroundImage = CType(resources.GetObject("cmd_filtrar_dptos.BackgroundImage"), System.Drawing.Image)
        Me.cmd_filtrar_dptos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_filtrar_dptos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_filtrar_dptos.Location = New System.Drawing.Point(455, 49)
        Me.cmd_filtrar_dptos.Name = "cmd_filtrar_dptos"
        Me.cmd_filtrar_dptos.Size = New System.Drawing.Size(26, 25)
        Me.cmd_filtrar_dptos.TabIndex = 10
        Me.cmd_filtrar_dptos.UseVisualStyleBackColor = True
        '
        'abm_localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 373)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Name = "abm_localidades"
        Me.Text = "abm_localidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_localidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_localidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_id As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_codpostal As System.Windows.Forms.Button
    Friend WithEvents txt_cod_postal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_dptos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_localidades As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_buscar_nombre As System.Windows.Forms.Button
    Friend WithEvents id_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_postal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_dpto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dpto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_filtrar_dptos As System.Windows.Forms.Button
End Class
