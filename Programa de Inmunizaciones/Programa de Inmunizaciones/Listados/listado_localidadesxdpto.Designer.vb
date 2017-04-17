<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_localidadesxdpto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado_localidadesxdpto))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LIST_LOCALIDADES_X_DPTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_generar_listado = New System.Windows.Forms.Button()
        Me.cmb_dptos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.LIST_LOCALIDADES_X_DPTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LIST_LOCALIDADES_X_DPTOBindingSource
        '
        Me.LIST_LOCALIDADES_X_DPTOBindingSource.DataMember = "LIST_LOCALIDADES_X_DPTO"
        Me.LIST_LOCALIDADES_X_DPTOBindingSource.DataSource = Me.Inmunizaciones
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_generar_listado)
        Me.GroupBox1.Controls.Add(Me.cmb_dptos)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Departamentos"
        '
        'cmd_generar_listado
        '
        Me.cmd_generar_listado.BackColor = System.Drawing.Color.Transparent
        Me.cmd_generar_listado.BackgroundImage = CType(resources.GetObject("cmd_generar_listado.BackgroundImage"), System.Drawing.Image)
        Me.cmd_generar_listado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_generar_listado.FlatAppearance.BorderSize = 0
        Me.cmd_generar_listado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_generar_listado.Location = New System.Drawing.Point(336, 10)
        Me.cmd_generar_listado.Name = "cmd_generar_listado"
        Me.cmd_generar_listado.Size = New System.Drawing.Size(50, 50)
        Me.cmd_generar_listado.TabIndex = 1
        Me.cmd_generar_listado.UseVisualStyleBackColor = False
        '
        'cmb_dptos
        '
        Me.cmb_dptos._descripcion = "descripcion"
        Me.cmb_dptos._nombre_tabla = "departamentos"
        Me.cmb_dptos._pk = "id"
        Me.cmb_dptos.FormattingEnabled = True
        Me.cmb_dptos.Location = New System.Drawing.Point(19, 26)
        Me.cmb_dptos.Name = "cmb_dptos"
        Me.cmb_dptos.Size = New System.Drawing.Size(295, 21)
        Me.cmb_dptos.TabIndex = 0
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_LOCALIDADES_X_DPTOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_localidad_x_dpto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 84)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(886, 343)
        Me.ReportViewer1.TabIndex = 1
        '
        'listado_localidadesxdpto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "listado_localidadesxdpto"
        Me.Text = "Localidades por departamento"
        CType(Me.LIST_LOCALIDADES_X_DPTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_dptos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmd_generar_listado As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_LOCALIDADES_X_DPTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
End Class
