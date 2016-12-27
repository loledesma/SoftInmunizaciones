<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menú))
        Me.grp_abm = New System.Windows.Forms.GroupBox()
        Me.cmd_abm_tipos_efectores = New System.Windows.Forms.Button()
        Me.cmd_abm_stock = New System.Windows.Forms.Button()
        Me.cmd_abm_perdidas = New System.Windows.Forms.Button()
        Me.cmd_abm_estado_pedidos = New System.Windows.Forms.Button()
        Me.cmd_estados_efector = New System.Windows.Forms.Button()
        Me.cmd_estados_atencion = New System.Windows.Forms.Button()
        Me.cmd_estado_capacitac = New System.Windows.Forms.Button()
        Me.cmd_abm_localidades = New System.Windows.Forms.Button()
        Me.cmd_abm_tiposDoc = New System.Windows.Forms.Button()
        Me.cmd_abm_empleados = New System.Windows.Forms.Button()
        Me.cmd_amb_despartamentos = New System.Windows.Forms.Button()
        Me.cmd_abm_cargo = New System.Windows.Forms.Button()
        Me.cmd_abm_carga = New System.Windows.Forms.Button()
        Me.cmd_abm_barrios = New System.Windows.Forms.Button()
        Me.cmd_registro_efectores = New System.Windows.Forms.Button()
        Me.cmd_registrar_notificacion = New System.Windows.Forms.Button()
        Me.grp_abm.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_abm
        '
        Me.grp_abm.BackColor = System.Drawing.Color.Transparent
        Me.grp_abm.Controls.Add(Me.cmd_abm_tipos_efectores)
        Me.grp_abm.Controls.Add(Me.cmd_abm_stock)
        Me.grp_abm.Controls.Add(Me.cmd_abm_perdidas)
        Me.grp_abm.Controls.Add(Me.cmd_abm_estado_pedidos)
        Me.grp_abm.Controls.Add(Me.cmd_estados_efector)
        Me.grp_abm.Controls.Add(Me.cmd_estados_atencion)
        Me.grp_abm.Controls.Add(Me.cmd_estado_capacitac)
        Me.grp_abm.Controls.Add(Me.cmd_abm_localidades)
        Me.grp_abm.Controls.Add(Me.cmd_abm_tiposDoc)
        Me.grp_abm.Controls.Add(Me.cmd_abm_empleados)
        Me.grp_abm.Controls.Add(Me.cmd_amb_despartamentos)
        Me.grp_abm.Controls.Add(Me.cmd_abm_cargo)
        Me.grp_abm.Controls.Add(Me.cmd_abm_carga)
        Me.grp_abm.Controls.Add(Me.cmd_abm_barrios)
        Me.grp_abm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_abm.Location = New System.Drawing.Point(12, 12)
        Me.grp_abm.Name = "grp_abm"
        Me.grp_abm.Size = New System.Drawing.Size(313, 225)
        Me.grp_abm.TabIndex = 0
        Me.grp_abm.TabStop = False
        Me.grp_abm.Text = "ABM"
        '
        'cmd_abm_tipos_efectores
        '
        Me.cmd_abm_tipos_efectores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_tipos_efectores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_tipos_efectores.Location = New System.Drawing.Point(166, 189)
        Me.cmd_abm_tipos_efectores.Name = "cmd_abm_tipos_efectores"
        Me.cmd_abm_tipos_efectores.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_tipos_efectores.TabIndex = 13
        Me.cmd_abm_tipos_efectores.Text = "TIPOS EFECTORES"
        Me.cmd_abm_tipos_efectores.UseVisualStyleBackColor = True
        '
        'cmd_abm_stock
        '
        Me.cmd_abm_stock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_stock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_stock.Location = New System.Drawing.Point(166, 162)
        Me.cmd_abm_stock.Name = "cmd_abm_stock"
        Me.cmd_abm_stock.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_stock.TabIndex = 12
        Me.cmd_abm_stock.Text = "STOCK"
        Me.cmd_abm_stock.UseVisualStyleBackColor = True
        '
        'cmd_abm_perdidas
        '
        Me.cmd_abm_perdidas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_perdidas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_perdidas.Location = New System.Drawing.Point(166, 133)
        Me.cmd_abm_perdidas.Name = "cmd_abm_perdidas"
        Me.cmd_abm_perdidas.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_perdidas.TabIndex = 11
        Me.cmd_abm_perdidas.Text = "PERDIDAS"
        Me.cmd_abm_perdidas.UseVisualStyleBackColor = True
        '
        'cmd_abm_estado_pedidos
        '
        Me.cmd_abm_estado_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_estado_pedidos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_estado_pedidos.Location = New System.Drawing.Point(166, 106)
        Me.cmd_abm_estado_pedidos.Name = "cmd_abm_estado_pedidos"
        Me.cmd_abm_estado_pedidos.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_estado_pedidos.TabIndex = 10
        Me.cmd_abm_estado_pedidos.Text = "ESTADO PEDIDOS"
        Me.cmd_abm_estado_pedidos.UseVisualStyleBackColor = True
        '
        'cmd_estados_efector
        '
        Me.cmd_estados_efector.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_estados_efector.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_estados_efector.Location = New System.Drawing.Point(166, 77)
        Me.cmd_estados_efector.Name = "cmd_estados_efector"
        Me.cmd_estados_efector.Size = New System.Drawing.Size(125, 23)
        Me.cmd_estados_efector.TabIndex = 9
        Me.cmd_estados_efector.Text = "ESTADOS EFECTOR"
        Me.cmd_estados_efector.UseVisualStyleBackColor = True
        '
        'cmd_estados_atencion
        '
        Me.cmd_estados_atencion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_estados_atencion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_estados_atencion.Location = New System.Drawing.Point(166, 48)
        Me.cmd_estados_atencion.Name = "cmd_estados_atencion"
        Me.cmd_estados_atencion.Size = New System.Drawing.Size(125, 23)
        Me.cmd_estados_atencion.TabIndex = 8
        Me.cmd_estados_atencion.Text = "ESTADOS ATENCION"
        Me.cmd_estados_atencion.UseVisualStyleBackColor = True
        '
        'cmd_estado_capacitac
        '
        Me.cmd_estado_capacitac.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_estado_capacitac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_estado_capacitac.Location = New System.Drawing.Point(166, 19)
        Me.cmd_estado_capacitac.Name = "cmd_estado_capacitac"
        Me.cmd_estado_capacitac.Size = New System.Drawing.Size(125, 23)
        Me.cmd_estado_capacitac.TabIndex = 7
        Me.cmd_estado_capacitac.Text = "ESTADO CAPAC"
        Me.cmd_estado_capacitac.UseVisualStyleBackColor = True
        '
        'cmd_abm_localidades
        '
        Me.cmd_abm_localidades.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_localidades.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_localidades.Location = New System.Drawing.Point(6, 189)
        Me.cmd_abm_localidades.Name = "cmd_abm_localidades"
        Me.cmd_abm_localidades.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_localidades.TabIndex = 6
        Me.cmd_abm_localidades.Text = "LOCALIDADES"
        Me.cmd_abm_localidades.UseVisualStyleBackColor = True
        '
        'cmd_abm_tiposDoc
        '
        Me.cmd_abm_tiposDoc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_tiposDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_tiposDoc.Location = New System.Drawing.Point(6, 162)
        Me.cmd_abm_tiposDoc.Name = "cmd_abm_tiposDoc"
        Me.cmd_abm_tiposDoc.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_tiposDoc.TabIndex = 5
        Me.cmd_abm_tiposDoc.Text = "TIPOS DOC"
        Me.cmd_abm_tiposDoc.UseVisualStyleBackColor = True
        '
        'cmd_abm_empleados
        '
        Me.cmd_abm_empleados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_empleados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_empleados.Location = New System.Drawing.Point(6, 133)
        Me.cmd_abm_empleados.Name = "cmd_abm_empleados"
        Me.cmd_abm_empleados.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_empleados.TabIndex = 4
        Me.cmd_abm_empleados.Text = "EMPLEADOS"
        Me.cmd_abm_empleados.UseVisualStyleBackColor = True
        '
        'cmd_amb_despartamentos
        '
        Me.cmd_amb_despartamentos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_amb_despartamentos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_amb_despartamentos.Location = New System.Drawing.Point(6, 106)
        Me.cmd_amb_despartamentos.Name = "cmd_amb_despartamentos"
        Me.cmd_amb_despartamentos.Size = New System.Drawing.Size(125, 23)
        Me.cmd_amb_despartamentos.TabIndex = 3
        Me.cmd_amb_despartamentos.Text = "DEPARTAMENTOS"
        Me.cmd_amb_despartamentos.UseVisualStyleBackColor = True
        '
        'cmd_abm_cargo
        '
        Me.cmd_abm_cargo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_cargo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_cargo.Location = New System.Drawing.Point(6, 77)
        Me.cmd_abm_cargo.Name = "cmd_abm_cargo"
        Me.cmd_abm_cargo.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_cargo.TabIndex = 2
        Me.cmd_abm_cargo.Text = "CARGOS"
        Me.cmd_abm_cargo.UseVisualStyleBackColor = True
        '
        'cmd_abm_carga
        '
        Me.cmd_abm_carga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_carga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_carga.Location = New System.Drawing.Point(6, 48)
        Me.cmd_abm_carga.Name = "cmd_abm_carga"
        Me.cmd_abm_carga.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_carga.TabIndex = 1
        Me.cmd_abm_carga.Text = "CARGA"
        Me.cmd_abm_carga.UseVisualStyleBackColor = True
        '
        'cmd_abm_barrios
        '
        Me.cmd_abm_barrios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_abm_barrios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_abm_barrios.Location = New System.Drawing.Point(6, 19)
        Me.cmd_abm_barrios.Name = "cmd_abm_barrios"
        Me.cmd_abm_barrios.Size = New System.Drawing.Size(125, 23)
        Me.cmd_abm_barrios.TabIndex = 0
        Me.cmd_abm_barrios.Text = "BARRIOS"
        Me.cmd_abm_barrios.UseVisualStyleBackColor = True
        '
        'cmd_registro_efectores
        '
        Me.cmd_registro_efectores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_registro_efectores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_registro_efectores.Location = New System.Drawing.Point(334, 31)
        Me.cmd_registro_efectores.Name = "cmd_registro_efectores"
        Me.cmd_registro_efectores.Size = New System.Drawing.Size(125, 52)
        Me.cmd_registro_efectores.TabIndex = 14
        Me.cmd_registro_efectores.Text = "REGISTRO DE EFECTORES"
        Me.cmd_registro_efectores.UseVisualStyleBackColor = True
        '
        'cmd_registrar_notificacion
        '
        Me.cmd_registrar_notificacion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmd_registrar_notificacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmd_registrar_notificacion.Location = New System.Drawing.Point(331, 89)
        Me.cmd_registrar_notificacion.Name = "cmd_registrar_notificacion"
        Me.cmd_registrar_notificacion.Size = New System.Drawing.Size(125, 52)
        Me.cmd_registrar_notificacion.TabIndex = 15
        Me.cmd_registrar_notificacion.Text = "REGISTRAR NOTIFICACION"
        Me.cmd_registrar_notificacion.UseVisualStyleBackColor = True
        '
        'Menú
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(471, 294)
        Me.Controls.Add(Me.cmd_registrar_notificacion)
        Me.Controls.Add(Me.cmd_registro_efectores)
        Me.Controls.Add(Me.grp_abm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Menú"
        Me.Text = "Menú"
        Me.grp_abm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_abm As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_abm_localidades As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_tiposDoc As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_empleados As System.Windows.Forms.Button
    Friend WithEvents cmd_amb_despartamentos As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_cargo As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_carga As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_barrios As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_tipos_efectores As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_stock As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_perdidas As System.Windows.Forms.Button
    Friend WithEvents cmd_abm_estado_pedidos As System.Windows.Forms.Button
    Friend WithEvents cmd_estados_efector As System.Windows.Forms.Button
    Friend WithEvents cmd_estados_atencion As System.Windows.Forms.Button
    Friend WithEvents cmd_estado_capacitac As System.Windows.Forms.Button
    Friend WithEvents cmd_registro_efectores As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar_notificacion As System.Windows.Forms.Button

End Class
