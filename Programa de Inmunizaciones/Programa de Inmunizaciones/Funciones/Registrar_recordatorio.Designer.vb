﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_recordatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_recordatorio))
        Me.dgv_recordatorios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_descripcion = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.grp_datos_recordatorio = New System.Windows.Forms.GroupBox()
        Me.cmd_actualizar_estado = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id_notificacion = New System.Windows.Forms.Label()
        Me.txt_id_recordatorio = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.cmb_empleados = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_estado_atencion = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_descripcion.SuspendLayout()
        Me.grp_datos_recordatorio.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_recordatorios
        '
        Me.dgv_recordatorios.AllowUserToAddRows = False
        Me.dgv_recordatorios.AllowUserToDeleteRows = False
        Me.dgv_recordatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recordatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.estado, Me.id_estado, Me.id_administrador, Me.administrador, Me.descripcion})
        Me.dgv_recordatorios.Location = New System.Drawing.Point(421, 14)
        Me.dgv_recordatorios.Name = "dgv_recordatorios"
        Me.dgv_recordatorios.ReadOnly = True
        Me.dgv_recordatorios.Size = New System.Drawing.Size(675, 429)
        Me.dgv_recordatorios.TabIndex = 10
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
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
        Me.administrador.Width = 150
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'grp_descripcion
        '
        Me.grp_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.grp_descripcion.Controls.Add(Me.txt_descripcion)
        Me.grp_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_descripcion.Location = New System.Drawing.Point(12, 176)
        Me.grp_descripcion.Name = "grp_descripcion"
        Me.grp_descripcion.Size = New System.Drawing.Size(403, 267)
        Me.grp_descripcion.TabIndex = 12
        Me.grp_descripcion.TabStop = False
        Me.grp_descripcion.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(9, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(381, 238)
        Me.txt_descripcion.TabIndex = 0
        Me.txt_descripcion.Text = ""
        '
        'grp_datos_recordatorio
        '
        Me.grp_datos_recordatorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_actualizar_estado)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmd_buscar)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_empleados)
        Me.grp_datos_recordatorio.Controls.Add(Me.Label1)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_id_notificacion)
        Me.grp_datos_recordatorio.Controls.Add(Me.cmb_estado_atencion)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_id_recordatorio)
        Me.grp_datos_recordatorio.Controls.Add(Me.txt_fecha)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_perfil)
        Me.grp_datos_recordatorio.Controls.Add(Me.lbl_estado)
        Me.grp_datos_recordatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_recordatorio.Location = New System.Drawing.Point(12, 12)
        Me.grp_datos_recordatorio.Name = "grp_datos_recordatorio"
        Me.grp_datos_recordatorio.Size = New System.Drawing.Size(403, 146)
        Me.grp_datos_recordatorio.TabIndex = 11
        Me.grp_datos_recordatorio.TabStop = False
        Me.grp_datos_recordatorio.Text = "Recordatorio"
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
        Me.cmd_actualizar_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_actualizar_estado.Location = New System.Drawing.Point(365, 72)
        Me.cmd_actualizar_estado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_actualizar_estado.Name = "cmd_actualizar_estado"
        Me.cmd_actualizar_estado.Size = New System.Drawing.Size(25, 25)
        Me.cmd_actualizar_estado.TabIndex = 4
        Me.cmd_actualizar_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_actualizar_estado.UseVisualStyleBackColor = False
        '
        'cmd_buscar
        '
        Me.cmd_buscar.BackgroundImage = CType(resources.GetObject("cmd_buscar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.Location = New System.Drawing.Point(353, 16)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(37, 36)
        Me.cmd_buscar.TabIndex = 1
        Me.cmd_buscar.UseVisualStyleBackColor = True
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
        'txt_id_recordatorio
        '
        Me.txt_id_recordatorio.Location = New System.Drawing.Point(109, 21)
        Me.txt_id_recordatorio.Name = "txt_id_recordatorio"
        Me.txt_id_recordatorio.Size = New System.Drawing.Size(136, 20)
        Me.txt_id_recordatorio.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(110, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha.TabIndex = 2
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
        'cmb_empleados
        '
        Me.cmb_empleados._descripcion = "nombres"
        Me.cmb_empleados._nombre_tabla = "EMPLEADOS"
        Me.cmb_empleados._pk = "id"
        Me.cmb_empleados.FormattingEnabled = True
        Me.cmb_empleados.Location = New System.Drawing.Point(111, 107)
        Me.cmb_empleados.Name = "cmb_empleados"
        Me.cmb_empleados.Size = New System.Drawing.Size(279, 21)
        Me.cmb_empleados.TabIndex = 5
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
        Me.cmb_estado_atencion.TabIndex = 3
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
        Me.cmd_eliminar.Location = New System.Drawing.Point(156, 465)
        Me.cmd_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_eliminar.TabIndex = 15
        Me.cmd_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_eliminar.UseVisualStyleBackColor = False
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
        Me.cmd_limpiar.Location = New System.Drawing.Point(218, 466)
        Me.cmd_limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_limpiar.TabIndex = 16
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
        Me.cmd_guardar.Location = New System.Drawing.Point(84, 465)
        Me.cmd_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_guardar.TabIndex = 13
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
        Me.cmd_nuevo.Location = New System.Drawing.Point(16, 465)
        Me.cmd_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(60, 60)
        Me.cmd_nuevo.TabIndex = 14
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
        Me.cmd_salir.Location = New System.Drawing.Point(1024, 464)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 17
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Registrar_recordatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1107, 538)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grp_descripcion)
        Me.Controls.Add(Me.grp_datos_recordatorio)
        Me.Controls.Add(Me.dgv_recordatorios)
        Me.Name = "Registrar_recordatorio"
        Me.Text = "Registrar_recordatorio"
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_descripcion.ResumeLayout(False)
        Me.grp_datos_recordatorio.ResumeLayout(False)
        Me.grp_datos_recordatorio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_recordatorios As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp_descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents grp_datos_recordatorio As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_actualizar_estado As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_empleados As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_notificacion As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_atencion As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_id_recordatorio As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
End Class