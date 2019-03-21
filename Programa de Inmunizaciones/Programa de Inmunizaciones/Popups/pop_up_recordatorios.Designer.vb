<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_recordatorios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_up_recordatorios))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_recordatorios = New System.Windows.Forms.DataGridView()
        Me.id_recordatorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_solucionado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_posponer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_recordatorios = New System.Windows.Forms.Button()
        Me.dgv_recordatoriosDiaSiguiente = New System.Windows.Forms.DataGridView()
        Me.id_recordatorioMañana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionMañana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.administrador_mañana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_solucionadoMañana = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_posponerMañana = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmd_editarMañana = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_refresh = New System.Windows.Forms.Button()
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_recordatoriosDiaSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_recordatorios
        '
        Me.dgv_recordatorios.AllowUserToAddRows = False
        Me.dgv_recordatorios.AllowUserToDeleteRows = False
        Me.dgv_recordatorios.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_recordatorios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_recordatorios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgv_recordatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recordatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_recordatorio, Me.descripcion, Me.administrador, Me.cmd_solucionado, Me.cmd_posponer, Me.cmd_editar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = "N/A"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_recordatorios.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_recordatorios.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_recordatorios.Location = New System.Drawing.Point(14, 55)
        Me.dgv_recordatorios.Name = "dgv_recordatorios"
        Me.dgv_recordatorios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_recordatorios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_recordatorios.Size = New System.Drawing.Size(959, 204)
        Me.dgv_recordatorios.StandardTab = True
        Me.dgv_recordatorios.TabIndex = 2
        '
        'id_recordatorio
        '
        Me.id_recordatorio.HeaderText = "ID Record."
        Me.id_recordatorio.Name = "id_recordatorio"
        Me.id_recordatorio.ToolTipText = "Ok"
        Me.id_recordatorio.Visible = False
        Me.id_recordatorio.Width = 5
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Recordatorio"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 400
        '
        'administrador
        '
        Me.administrador.HeaderText = "Registrado por"
        Me.administrador.Name = "administrador"
        Me.administrador.Width = 75
        '
        'cmd_solucionado
        '
        Me.cmd_solucionado.HeaderText = "Estado actual"
        Me.cmd_solucionado.Name = "cmd_solucionado"
        Me.cmd_solucionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmd_solucionado.Text = ""
        '
        'cmd_posponer
        '
        Me.cmd_posponer.HeaderText = "Cambiar fecha"
        Me.cmd_posponer.Name = "cmd_posponer"
        Me.cmd_posponer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmd_posponer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmd_posponer.Text = "Cambiar fecha"
        Me.cmd_posponer.UseColumnTextForButtonValue = True
        '
        'cmd_editar
        '
        Me.cmd_editar.HeaderText = "Editar"
        Me.cmd_editar.Name = "cmd_editar"
        Me.cmd_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmd_editar.Text = "Editar"
        Me.cmd_editar.UseColumnTextForButtonValue = True
        '
        'cmd_recordatorios
        '
        Me.cmd_recordatorios.BackColor = System.Drawing.Color.Transparent
        Me.cmd_recordatorios.BackgroundImage = CType(resources.GetObject("cmd_recordatorios.BackgroundImage"), System.Drawing.Image)
        Me.cmd_recordatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_recordatorios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_recordatorios.FlatAppearance.BorderSize = 0
        Me.cmd_recordatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_recordatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_recordatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_recordatorios.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.cmd_recordatorios.Location = New System.Drawing.Point(902, 435)
        Me.cmd_recordatorios.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_recordatorios.Name = "cmd_recordatorios"
        Me.cmd_recordatorios.Size = New System.Drawing.Size(66, 66)
        Me.cmd_recordatorios.TabIndex = 61
        Me.cmd_recordatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_recordatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_recordatorios.UseVisualStyleBackColor = False
        '
        'dgv_recordatoriosDiaSiguiente
        '
        Me.dgv_recordatoriosDiaSiguiente.AllowUserToAddRows = False
        Me.dgv_recordatoriosDiaSiguiente.AllowUserToDeleteRows = False
        Me.dgv_recordatoriosDiaSiguiente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_recordatoriosDiaSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_recordatoriosDiaSiguiente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgv_recordatoriosDiaSiguiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_recordatoriosDiaSiguiente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_recordatorioMañana, Me.descripcionMañana, Me.administrador_mañana, Me.cmd_solucionadoMañana, Me.cmd_posponerMañana, Me.cmd_editarMañana})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = "N/A"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_recordatoriosDiaSiguiente.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_recordatoriosDiaSiguiente.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_recordatoriosDiaSiguiente.Location = New System.Drawing.Point(10, 301)
        Me.dgv_recordatoriosDiaSiguiente.Name = "dgv_recordatoriosDiaSiguiente"
        Me.dgv_recordatoriosDiaSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_recordatoriosDiaSiguiente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_recordatoriosDiaSiguiente.Size = New System.Drawing.Size(959, 126)
        Me.dgv_recordatoriosDiaSiguiente.StandardTab = True
        Me.dgv_recordatoriosDiaSiguiente.TabIndex = 62
        '
        'id_recordatorioMañana
        '
        Me.id_recordatorioMañana.HeaderText = "ID Record."
        Me.id_recordatorioMañana.Name = "id_recordatorioMañana"
        Me.id_recordatorioMañana.ToolTipText = "Ok"
        Me.id_recordatorioMañana.Visible = False
        Me.id_recordatorioMañana.Width = 5
        '
        'descripcionMañana
        '
        Me.descripcionMañana.HeaderText = "Recordatorio"
        Me.descripcionMañana.Name = "descripcionMañana"
        Me.descripcionMañana.Width = 400
        '
        'administrador_mañana
        '
        Me.administrador_mañana.HeaderText = "Registrado por"
        Me.administrador_mañana.Name = "administrador_mañana"
        Me.administrador_mañana.Width = 75
        '
        'cmd_solucionadoMañana
        '
        Me.cmd_solucionadoMañana.HeaderText = "Estado actual"
        Me.cmd_solucionadoMañana.Name = "cmd_solucionadoMañana"
        Me.cmd_solucionadoMañana.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmd_solucionadoMañana.Text = ""
        '
        'cmd_posponerMañana
        '
        Me.cmd_posponerMañana.HeaderText = "Cambiar fecha"
        Me.cmd_posponerMañana.Name = "cmd_posponerMañana"
        Me.cmd_posponerMañana.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmd_posponerMañana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmd_posponerMañana.Text = "Cambiar fecha"
        Me.cmd_posponerMañana.UseColumnTextForButtonValue = True
        '
        'cmd_editarMañana
        '
        Me.cmd_editarMañana.HeaderText = "Editar"
        Me.cmd_editarMañana.Name = "cmd_editarMañana"
        Me.cmd_editarMañana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmd_editarMañana.Text = "Editar"
        Me.cmd_editarMañana.UseColumnTextForButtonValue = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl1.Location = New System.Drawing.Point(14, 277)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(215, 18)
        Me.lbl1.TabIndex = 63
        Me.lbl1.Text = "Actividades para mañana"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 18)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Actividades para hoy"
        '
        'cmd_refresh
        '
        Me.cmd_refresh.BackColor = System.Drawing.Color.Transparent
        Me.cmd_refresh.BackgroundImage = CType(resources.GetObject("cmd_refresh.BackgroundImage"), System.Drawing.Image)
        Me.cmd_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_refresh.FlatAppearance.BorderSize = 0
        Me.cmd_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_refresh.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.cmd_refresh.Location = New System.Drawing.Point(826, 435)
        Me.cmd_refresh.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(66, 66)
        Me.cmd_refresh.TabIndex = 65
        Me.cmd_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_refresh.UseVisualStyleBackColor = False
        '
        'pop_up_recordatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(983, 511)
        Me.Controls.Add(Me.cmd_refresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.dgv_recordatoriosDiaSiguiente)
        Me.Controls.Add(Me.cmd_recordatorios)
        Me.Controls.Add(Me.dgv_recordatorios)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 10.0!)
        Me.Name = "pop_up_recordatorios"
        Me.Text = "Recordatorios del día"
        CType(Me.dgv_recordatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_recordatoriosDiaSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_recordatorios As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_recordatorios As System.Windows.Forms.Button
    Friend WithEvents dgv_recordatoriosDiaSiguiente As System.Windows.Forms.DataGridView
    Friend WithEvents id_recordatorio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_solucionado As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_posponer As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_editar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents id_recordatorioMañana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcionMañana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents administrador_mañana As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_solucionadoMañana As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_posponerMañana As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmd_editarMañana As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_refresh As System.Windows.Forms.Button
End Class
