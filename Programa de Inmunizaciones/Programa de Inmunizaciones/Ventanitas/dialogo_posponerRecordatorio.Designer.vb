<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogo_posponerRecordatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialogo_posponerRecordatorio))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fecha_actual_evento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nuevaFechaEvento = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_confirmarNuevafecha = New System.Windows.Forms.Button()
        Me.lbl_idRecordatorio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(14, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(96, 16)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "ID Recordatorio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha actual del recordatorio"
        '
        'lbl_fecha_actual_evento
        '
        Me.lbl_fecha_actual_evento.AutoSize = True
        Me.lbl_fecha_actual_evento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha_actual_evento.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_fecha_actual_evento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_fecha_actual_evento.Location = New System.Drawing.Point(258, 54)
        Me.lbl_fecha_actual_evento.Name = "lbl_fecha_actual_evento"
        Me.lbl_fecha_actual_evento.Size = New System.Drawing.Size(0, 16)
        Me.lbl_fecha_actual_evento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nueva fecha"
        '
        'txt_nuevaFechaEvento
        '
        Me.txt_nuevaFechaEvento.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.txt_nuevaFechaEvento.Location = New System.Drawing.Point(134, 92)
        Me.txt_nuevaFechaEvento.Mask = "00/00/0000"
        Me.txt_nuevaFechaEvento.Name = "txt_nuevaFechaEvento"
        Me.txt_nuevaFechaEvento.Size = New System.Drawing.Size(116, 22)
        Me.txt_nuevaFechaEvento.TabIndex = 4
        Me.txt_nuevaFechaEvento.ValidatingType = GetType(Date)
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
        Me.cmd_confirmarNuevafecha.Location = New System.Drawing.Point(261, 87)
        Me.cmd_confirmarNuevafecha.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_confirmarNuevafecha.Name = "cmd_confirmarNuevafecha"
        Me.cmd_confirmarNuevafecha.Size = New System.Drawing.Size(33, 32)
        Me.cmd_confirmarNuevafecha.TabIndex = 5
        Me.cmd_confirmarNuevafecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_confirmarNuevafecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_confirmarNuevafecha.UseVisualStyleBackColor = False
        '
        'lbl_idRecordatorio
        '
        Me.lbl_idRecordatorio.AutoSize = True
        Me.lbl_idRecordatorio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_idRecordatorio.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.lbl_idRecordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_idRecordatorio.Location = New System.Drawing.Point(149, 24)
        Me.lbl_idRecordatorio.Name = "lbl_idRecordatorio"
        Me.lbl_idRecordatorio.Size = New System.Drawing.Size(0, 16)
        Me.lbl_idRecordatorio.TabIndex = 6
        '
        'dialogo_posponerRecordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(355, 150)
        Me.Controls.Add(Me.lbl_idRecordatorio)
        Me.Controls.Add(Me.cmd_confirmarNuevafecha)
        Me.Controls.Add(Me.txt_nuevaFechaEvento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fecha_actual_evento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.KeyPreview = True
        Me.Name = "dialogo_posponerRecordatorio"
        Me.Text = "Posponer Recordatorio ☺"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_actual_evento As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nuevaFechaEvento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_confirmarNuevafecha As System.Windows.Forms.Button
    Friend WithEvents lbl_idRecordatorio As System.Windows.Forms.Label
End Class
