﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_capacitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_capacitaciones))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.grp_datos_efector = New System.Windows.Forms.GroupBox()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.grp_datos_atenciones = New System.Windows.Forms.GroupBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_hasta = New System.Windows.Forms.Label()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_desde = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.LIST_CAPACITACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grp_datos_efector.SuspendLayout()
        Me.grp_datos_atenciones.SuspendLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_efector
        '
        Me.grp_datos_efector.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_efector.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_efector.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_efector.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_efector.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_efector.Location = New System.Drawing.Point(18, 11)
        Me.grp_datos_efector.Name = "grp_datos_efector"
        Me.grp_datos_efector.Size = New System.Drawing.Size(436, 102)
        Me.grp_datos_efector.TabIndex = 4
        Me.grp_datos_efector.TabStop = False
        Me.grp_datos_efector.Text = "Datos Efector"
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(125, 27)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(281, 21)
        Me.cmb_departamentos.TabIndex = 0
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(125, 54)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(281, 21)
        Me.cmb_localidades.TabIndex = 1
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(9, 56)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 31
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(9, 32)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_departamento.TabIndex = 30
        Me.lbl_departamento.Text = "Departamento"
        '
        'grp_datos_atenciones
        '
        Me.grp_datos_atenciones.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_atenciones.Controls.Add(Me.cmd_ejecutar)
        Me.grp_datos_atenciones.Controls.Add(Me.txt_fecha_hasta)
        Me.grp_datos_atenciones.Controls.Add(Me.lbl_hasta)
        Me.grp_datos_atenciones.Controls.Add(Me.txt_fecha_desde)
        Me.grp_datos_atenciones.Controls.Add(Me.lbl_desde)
        Me.grp_datos_atenciones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_atenciones.Location = New System.Drawing.Point(472, 11)
        Me.grp_datos_atenciones.Name = "grp_datos_atenciones"
        Me.grp_datos_atenciones.Size = New System.Drawing.Size(514, 102)
        Me.grp_datos_atenciones.TabIndex = 5
        Me.grp_datos_atenciones.TabStop = False
        Me.grp_datos_atenciones.Text = "Datos Atenciones"
        '
        'cmd_ejecutar
        '
        Me.cmd_ejecutar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_ejecutar.BackgroundImage = CType(resources.GetObject("cmd_ejecutar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ejecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_ejecutar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_ejecutar.FlatAppearance.BorderSize = 0
        Me.cmd_ejecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.cmd_ejecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.cmd_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ejecutar.Location = New System.Drawing.Point(385, 30)
        Me.cmd_ejecutar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 10
        Me.cmd_ejecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_ejecutar.UseVisualStyleBackColor = False
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(281, 50)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_hasta.TabIndex = 35
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(236, 54)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 34
        Me.lbl_hasta.Text = "Hasta"
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(116, 50)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'lbl_desde
        '
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Location = New System.Drawing.Point(59, 53)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_desde.TabIndex = 33
        Me.lbl_desde.Text = "Desde"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_CAPACITACIONESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_capacitaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(18, 129)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(967, 457)
        Me.ReportViewer1.TabIndex = 6
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIST_CAPACITACIONESBindingSource
        '
        Me.LIST_CAPACITACIONESBindingSource.DataMember = "LIST_CAPACITACIONES"
        Me.LIST_CAPACITACIONESBindingSource.DataSource = Me.Inmunizaciones
        '
        'list_capacitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 598)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_datos_atenciones)
        Me.Controls.Add(Me.grp_datos_efector)
        Me.Name = "list_capacitaciones"
        Me.Text = "CAPACITACIONES"
        Me.grp_datos_efector.ResumeLayout(False)
        Me.grp_datos_efector.PerformLayout()
        Me.grp_datos_atenciones.ResumeLayout(False)
        Me.grp_datos_atenciones.PerformLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_CAPACITACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_efector As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents grp_datos_atenciones As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_CAPACITACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
End Class
