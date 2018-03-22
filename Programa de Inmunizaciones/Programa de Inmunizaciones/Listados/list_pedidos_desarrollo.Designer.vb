<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_pedidos_desarrollo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_pedidos_desarrollo))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LIST_PEDIDOS_DESARROLLOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.grp_pedidos_desarrollo = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmb_estado_pedido = New Programa_de_Inmunizaciones.ComboBoxV1()
        CType(Me.LIST_PEDIDOS_DESARROLLOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_pedidos_desarrollo.SuspendLayout()
        Me.SuspendLayout()
        '
        'LIST_PEDIDOS_DESARROLLOBindingSource
        '
        Me.LIST_PEDIDOS_DESARROLLOBindingSource.DataMember = "LIST_PEDIDOS_DESARROLLO"
        Me.LIST_PEDIDOS_DESARROLLOBindingSource.DataSource = Me.Inmunizaciones
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_pedidos_desarrollo
        '
        Me.grp_pedidos_desarrollo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_pedidos_desarrollo.BackColor = System.Drawing.Color.Transparent
        Me.grp_pedidos_desarrollo.Controls.Add(Me.txt_fecha_hasta)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.txt_fecha_desde)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.cmb_estado_pedido)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.cmd_ejecutar)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.Label3)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.Label2)
        Me.grp_pedidos_desarrollo.Controls.Add(Me.Label1)
        Me.grp_pedidos_desarrollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_pedidos_desarrollo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_pedidos_desarrollo.Location = New System.Drawing.Point(178, 12)
        Me.grp_pedidos_desarrollo.Name = "grp_pedidos_desarrollo"
        Me.grp_pedidos_desarrollo.Size = New System.Drawing.Size(472, 95)
        Me.grp_pedidos_desarrollo.TabIndex = 0
        Me.grp_pedidos_desarrollo.TabStop = False
        Me.grp_pedidos_desarrollo.Text = "Flitros"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(284, 52)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_hasta.TabIndex = 55
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(98, 52)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_desde.TabIndex = 54
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'cmd_ejecutar
        '
        Me.cmd_ejecutar.BackgroundImage = CType(resources.GetObject("cmd_ejecutar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ejecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_ejecutar.FlatAppearance.BorderSize = 0
        Me.cmd_ejecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmd_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ejecutar.Location = New System.Drawing.Point(387, 19)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 52
        Me.cmd_ejecutar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado de pedido"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.WhiteSmoke
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_PEDIDOS_DESARROLLOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_pedidos_desarrollo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 113)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(780, 481)
        Me.ReportViewer1.TabIndex = 1
        '
        'cmb_estado_pedido
        '
        Me.cmb_estado_pedido._descripcion = "descripcion"
        Me.cmb_estado_pedido._nombre_tabla = "ESTADOS_PEDIDOS"
        Me.cmb_estado_pedido._pk = "id"
        Me.cmb_estado_pedido.FormattingEnabled = True
        Me.cmb_estado_pedido.Location = New System.Drawing.Point(98, 27)
        Me.cmb_estado_pedido.Name = "cmb_estado_pedido"
        Me.cmb_estado_pedido.Size = New System.Drawing.Size(284, 21)
        Me.cmb_estado_pedido.TabIndex = 53
        '
        'list_pedidos_desarrollo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 606)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_pedidos_desarrollo)
        Me.Name = "list_pedidos_desarrollo"
        Me.Text = "Pedidos de desarrollo "
        CType(Me.LIST_PEDIDOS_DESARROLLOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_pedidos_desarrollo.ResumeLayout(False)
        Me.grp_pedidos_desarrollo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_pedidos_desarrollo As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_PEDIDOS_DESARROLLOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
    Friend WithEvents cmb_estado_pedido As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents txt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_desde As System.Windows.Forms.MaskedTextBox
End Class
