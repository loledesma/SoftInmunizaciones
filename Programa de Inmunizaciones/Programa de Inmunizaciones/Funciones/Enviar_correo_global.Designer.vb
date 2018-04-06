<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enviar_correo_global
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enviar_correo_global))
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.cmd_empleado_nuevo = New System.Windows.Forms.Button()
        Me.txt_destinatario = New System.Windows.Forms.RichTextBox()
        Me.txt_asunto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_enviar = New System.Windows.Forms.Button()
        Me.grp_grilla_stock = New System.Windows.Forms.GroupBox()
        Me.txt_cuerpo = New System.Windows.Forms.RichTextBox()
        Me.tltp_perdidas = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_datos.SuspendLayout()
        Me.grp_grilla_stock.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos.Controls.Add(Me.cmd_empleado_nuevo)
        Me.grp_datos.Controls.Add(Me.txt_destinatario)
        Me.grp_datos.Controls.Add(Me.txt_asunto)
        Me.grp_datos.Controls.Add(Me.Label1)
        Me.grp_datos.Controls.Add(Me.lbl_descripcion)
        Me.grp_datos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grp_datos.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(421, 108)
        Me.grp_datos.TabIndex = 0
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos"
        '
        'cmd_empleado_nuevo
        '
        Me.cmd_empleado_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_empleado_nuevo.BackgroundImage = CType(resources.GetObject("cmd_empleado_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_empleado_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_empleado_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_empleado_nuevo.FlatAppearance.BorderSize = 0
        Me.cmd_empleado_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_empleado_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_empleado_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_empleado_nuevo.Location = New System.Drawing.Point(390, 14)
        Me.cmd_empleado_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_empleado_nuevo.Name = "cmd_empleado_nuevo"
        Me.cmd_empleado_nuevo.Size = New System.Drawing.Size(25, 25)
        Me.cmd_empleado_nuevo.TabIndex = 8
        Me.cmd_empleado_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_empleado_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_empleado_nuevo.UseVisualStyleBackColor = False
        '
        'txt_destinatario
        '
        Me.txt_destinatario.Location = New System.Drawing.Point(99, 16)
        Me.txt_destinatario.Name = "txt_destinatario"
        Me.txt_destinatario.Size = New System.Drawing.Size(287, 60)
        Me.txt_destinatario.TabIndex = 0
        Me.txt_destinatario.Text = ""
        '
        'txt_asunto
        '
        Me.txt_asunto.Location = New System.Drawing.Point(99, 82)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(287, 20)
        Me.txt_asunto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Asunto"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_descripcion.Location = New System.Drawing.Point(4, 22)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Destinatario"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(384, 450)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 34
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_enviar
        '
        Me.cmd_enviar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_enviar.BackgroundImage = CType(resources.GetObject("cmd_enviar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_enviar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_enviar.FlatAppearance.BorderSize = 0
        Me.cmd_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_enviar.Location = New System.Drawing.Point(-3, 450)
        Me.cmd_enviar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_enviar.Name = "cmd_enviar"
        Me.cmd_enviar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_enviar.TabIndex = 30
        Me.cmd_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_enviar.UseVisualStyleBackColor = False
        '
        'grp_grilla_stock
        '
        Me.grp_grilla_stock.BackColor = System.Drawing.Color.Transparent
        Me.grp_grilla_stock.Controls.Add(Me.txt_cuerpo)
        Me.grp_grilla_stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grp_grilla_stock.Location = New System.Drawing.Point(12, 126)
        Me.grp_grilla_stock.Name = "grp_grilla_stock"
        Me.grp_grilla_stock.Size = New System.Drawing.Size(421, 279)
        Me.grp_grilla_stock.TabIndex = 35
        Me.grp_grilla_stock.TabStop = False
        Me.grp_grilla_stock.Text = "Existentes"
        '
        'txt_cuerpo
        '
        Me.txt_cuerpo.Location = New System.Drawing.Point(5, 19)
        Me.txt_cuerpo.Name = "txt_cuerpo"
        Me.txt_cuerpo.Size = New System.Drawing.Size(410, 239)
        Me.txt_cuerpo.TabIndex = 0
        Me.txt_cuerpo.Text = ""
        '
        'Enviar_correo_global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programa_de_Inmunizaciones.My.Resources.Resources.vacu_logo_min
        Me.ClientSize = New System.Drawing.Size(445, 513)
        Me.Controls.Add(Me.grp_grilla_stock)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_enviar)
        Me.Controls.Add(Me.grp_datos)
        Me.DoubleBuffered = True
        Me.Name = "Enviar_correo_global"
        Me.Text = "Envio de Mail"
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.grp_grilla_stock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_enviar As System.Windows.Forms.Button
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents grp_grilla_stock As System.Windows.Forms.GroupBox
    Friend WithEvents tltp_perdidas As System.Windows.Forms.ToolTip
    Friend WithEvents txt_asunto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_destinatario As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_cuerpo As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_empleado_nuevo As System.Windows.Forms.Button
End Class
