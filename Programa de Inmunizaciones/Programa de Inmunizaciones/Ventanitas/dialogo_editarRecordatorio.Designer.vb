<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogo_editarRecordatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialogo_editarRecordatorio))
        Me.lbl_idRecordatorio = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_editarRecordatorio = New System.Windows.Forms.TextBox()
        Me.cmd_confirmarCambios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_idRecordatorio
        '
        Me.lbl_idRecordatorio.AutoSize = True
        Me.lbl_idRecordatorio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_idRecordatorio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idRecordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_idRecordatorio.Location = New System.Drawing.Point(128, 27)
        Me.lbl_idRecordatorio.Name = "lbl_idRecordatorio"
        Me.lbl_idRecordatorio.Size = New System.Drawing.Size(0, 16)
        Me.lbl_idRecordatorio.TabIndex = 8
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(12, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(110, 16)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "ID Recordatorio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modificación"
        '
        'txt_editarRecordatorio
        '
        Me.txt_editarRecordatorio.Location = New System.Drawing.Point(107, 62)
        Me.txt_editarRecordatorio.Multiline = True
        Me.txt_editarRecordatorio.Name = "txt_editarRecordatorio"
        Me.txt_editarRecordatorio.Size = New System.Drawing.Size(448, 75)
        Me.txt_editarRecordatorio.TabIndex = 10
        '
        'cmd_confirmarCambios
        '
        Me.cmd_confirmarCambios.BackColor = System.Drawing.Color.Transparent
        Me.cmd_confirmarCambios.BackgroundImage = CType(resources.GetObject("cmd_confirmarCambios.BackgroundImage"), System.Drawing.Image)
        Me.cmd_confirmarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_confirmarCambios.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_confirmarCambios.FlatAppearance.BorderSize = 0
        Me.cmd_confirmarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_confirmarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_confirmarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_confirmarCambios.Location = New System.Drawing.Point(513, 144)
        Me.cmd_confirmarCambios.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_confirmarCambios.Name = "cmd_confirmarCambios"
        Me.cmd_confirmarCambios.Size = New System.Drawing.Size(35, 35)
        Me.cmd_confirmarCambios.TabIndex = 11
        Me.cmd_confirmarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_confirmarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_confirmarCambios.UseVisualStyleBackColor = False
        '
        'dialogo_editarRecordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(561, 191)
        Me.Controls.Add(Me.cmd_confirmarCambios)
        Me.Controls.Add(Me.txt_editarRecordatorio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_idRecordatorio)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "dialogo_editarRecordatorio"
        Me.Text = "dialogo_editarRecordatorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_idRecordatorio As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_editarRecordatorio As System.Windows.Forms.TextBox
    Friend WithEvents cmd_confirmarCambios As System.Windows.Forms.Button
End Class
