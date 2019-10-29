<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogo_modificarAtencionCaducada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialogo_modificarAtencionCaducada))
        Me.lbl_nombre_efector = New System.Windows.Forms.Label()
        Me.lbl_efector = New System.Windows.Forms.Label()
        Me.cmd_confirmarNuevafecha = New System.Windows.Forms.Button()
        Me.txt_nuevaFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fecha_actual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.lbl_id_atencion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_estado_atencion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_editarAtencion = New System.Windows.Forms.TextBox()
        Me.cmd_guardar_atencion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nombre_efector
        '
        Me.lbl_nombre_efector.AutoSize = True
        Me.lbl_nombre_efector.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre_efector.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nombre_efector.Location = New System.Drawing.Point(117, 41)
        Me.lbl_nombre_efector.Name = "lbl_nombre_efector"
        Me.lbl_nombre_efector.Size = New System.Drawing.Size(0, 16)
        Me.lbl_nombre_efector.TabIndex = 10
        '
        'lbl_efector
        '
        Me.lbl_efector.AutoSize = True
        Me.lbl_efector.BackColor = System.Drawing.Color.Transparent
        Me.lbl_efector.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_efector.Location = New System.Drawing.Point(13, 41)
        Me.lbl_efector.Name = "lbl_efector"
        Me.lbl_efector.Size = New System.Drawing.Size(98, 16)
        Me.lbl_efector.TabIndex = 9
        Me.lbl_efector.Text = "Centro de salud"
        '
        'cmd_confirmarNuevafecha
        '
        Me.cmd_confirmarNuevafecha.BackColor = System.Drawing.Color.Transparent
        Me.cmd_confirmarNuevafecha.BackgroundImage = CType(resources.GetObject("cmd_confirmarNuevafecha.BackgroundImage"), System.Drawing.Image)
        Me.cmd_confirmarNuevafecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_confirmarNuevafecha.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_confirmarNuevafecha.FlatAppearance.BorderSize = 0
        Me.cmd_confirmarNuevafecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_confirmarNuevafecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_confirmarNuevafecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_confirmarNuevafecha.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.cmd_confirmarNuevafecha.Location = New System.Drawing.Point(260, 99)
        Me.cmd_confirmarNuevafecha.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_confirmarNuevafecha.Name = "cmd_confirmarNuevafecha"
        Me.cmd_confirmarNuevafecha.Size = New System.Drawing.Size(33, 32)
        Me.cmd_confirmarNuevafecha.TabIndex = 15
        Me.cmd_confirmarNuevafecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_confirmarNuevafecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_confirmarNuevafecha.UseVisualStyleBackColor = False
        '
        'txt_nuevaFecha
        '
        Me.txt_nuevaFecha.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.txt_nuevaFecha.Location = New System.Drawing.Point(133, 104)
        Me.txt_nuevaFecha.Mask = "00/00/0000"
        Me.txt_nuevaFecha.Name = "txt_nuevaFecha"
        Me.txt_nuevaFecha.Size = New System.Drawing.Size(116, 22)
        Me.txt_nuevaFecha.TabIndex = 14
        Me.txt_nuevaFecha.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nueva fecha"
        '
        'lbl_fecha_actual
        '
        Me.lbl_fecha_actual.AutoSize = True
        Me.lbl_fecha_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha_actual.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_fecha_actual.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_fecha_actual.Location = New System.Drawing.Point(97, 68)
        Me.lbl_fecha_actual.Name = "lbl_fecha_actual"
        Me.lbl_fecha_actual.Size = New System.Drawing.Size(0, 16)
        Me.lbl_fecha_actual.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado"
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
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(417, 130)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(37, 37)
        Me.cmd_actualizar_estado.TabIndex = 20
        Me.cmd_actualizar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar_estado.UseVisualStyleBackColor = False
        '
        'lbl_id_atencion
        '
        Me.lbl_id_atencion.AutoSize = True
        Me.lbl_id_atencion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id_atencion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_atencion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_id_atencion.Location = New System.Drawing.Point(81, 9)
        Me.lbl_id_atencion.Name = "lbl_id_atencion"
        Me.lbl_id_atencion.Size = New System.Drawing.Size(0, 16)
        Me.lbl_id_atencion.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Id Atencion"
        '
        'cmb_estado_atencion
        '
        Me.cmb_estado_atencion._descripcion = "descripcion"
        Me.cmb_estado_atencion._nombre_tabla = "ESTADOS_ATENCION"
        Me.cmb_estado_atencion._pk = "id"
        Me.cmb_estado_atencion.FormattingEnabled = True
        Me.cmb_estado_atencion.Location = New System.Drawing.Point(133, 139)
        Me.cmb_estado_atencion.Name = "cmb_estado_atencion"
        Me.cmb_estado_atencion.Size = New System.Drawing.Size(276, 21)
        Me.cmb_estado_atencion.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Atención"
        '
        'txt_editarAtencion
        '
        Me.txt_editarAtencion.Location = New System.Drawing.Point(133, 169)
        Me.txt_editarAtencion.Multiline = True
        Me.txt_editarAtencion.Name = "txt_editarAtencion"
        Me.txt_editarAtencion.Size = New System.Drawing.Size(434, 94)
        Me.txt_editarAtencion.TabIndex = 24
        '
        'cmd_guardar_atencion
        '
        Me.cmd_guardar_atencion.BackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar_atencion.BackgroundImage = CType(resources.GetObject("cmd_guardar_atencion.BackgroundImage"), System.Drawing.Image)
        Me.cmd_guardar_atencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_guardar_atencion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_guardar_atencion.FlatAppearance.BorderSize = 0
        Me.cmd_guardar_atencion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_guardar_atencion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_guardar_atencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_guardar_atencion.Location = New System.Drawing.Point(575, 226)
        Me.cmd_guardar_atencion.Margin = New System.Windows.Forms.Padding(5)
        Me.cmd_guardar_atencion.Name = "cmd_guardar_atencion"
        Me.cmd_guardar_atencion.Size = New System.Drawing.Size(37, 37)
        Me.cmd_guardar_atencion.TabIndex = 25
        Me.cmd_guardar_atencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar_atencion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_guardar_atencion.UseVisualStyleBackColor = False
        '
        'dialogo_modificarAtencionCaducada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 326)
        Me.Controls.Add(Me.cmd_guardar_atencion)
        Me.Controls.Add(Me.txt_editarAtencion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_id_atencion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_actualizar_estado)
        Me.Controls.Add(Me.cmb_estado_atencion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_confirmarNuevafecha)
        Me.Controls.Add(Me.txt_nuevaFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fecha_actual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nombre_efector)
        Me.Controls.Add(Me.lbl_efector)
        Me.KeyPreview = True
        Me.Name = "dialogo_modificarAtencionCaducada"
        Me.Text = "Modificar atencion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_efector As System.Windows.Forms.Label
    Friend WithEvents lbl_efector As System.Windows.Forms.Label
    Friend WithEvents cmd_confirmarNuevafecha As System.Windows.Forms.Button
    Friend WithEvents txt_nuevaFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_actual As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmb_estado_atencion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_id_atencion As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_editarAtencion As System.Windows.Forms.TextBox
    Friend WithEvents cmd_guardar_atencion As System.Windows.Forms.Button
End Class
