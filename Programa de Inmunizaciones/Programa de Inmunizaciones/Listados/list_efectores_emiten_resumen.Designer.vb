﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_efectores_emiten_resumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_efectores_emiten_resumen))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LIST_EMITEN_SIGIPSABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.grp_datos_efector = New System.Windows.Forms.GroupBox()
        Me.cmb_emite_sigipsa = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.LIST_EMITEN_SIGIPSABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_efector.SuspendLayout()
        Me.SuspendLayout()
        '
        'LIST_EMITEN_SIGIPSABindingSource
        '
        Me.LIST_EMITEN_SIGIPSABindingSource.DataMember = "LIST_EMITEN_SIGIPSA"
        Me.LIST_EMITEN_SIGIPSABindingSource.DataSource = Me.Inmunizaciones
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_datos_efector
        '
        Me.grp_datos_efector.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_efector.Controls.Add(Me.cmb_emite_sigipsa)
        Me.grp_datos_efector.Controls.Add(Me.Label1)
        Me.grp_datos_efector.Controls.Add(Me.cmd_ejecutar)
        Me.grp_datos_efector.Controls.Add(Me.txt_cuie)
        Me.grp_datos_efector.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_efector.Controls.Add(Me.txt_efectores)
        Me.grp_datos_efector.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_efector.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_efector.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_efector.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_efector.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_efector.Location = New System.Drawing.Point(80, 12)
        Me.grp_datos_efector.Name = "grp_datos_efector"
        Me.grp_datos_efector.Size = New System.Drawing.Size(628, 133)
        Me.grp_datos_efector.TabIndex = 5
        Me.grp_datos_efector.TabStop = False
        Me.grp_datos_efector.Text = "Datos Efector"
        '
        'cmb_emite_sigipsa
        '
        Me.cmb_emite_sigipsa._descripcion = "descripcion"
        Me.cmb_emite_sigipsa._nombre_tabla = "ESTADO_RM"
        Me.cmb_emite_sigipsa._pk = "id"
        Me.cmb_emite_sigipsa.FormattingEnabled = True
        Me.cmb_emite_sigipsa.Location = New System.Drawing.Point(354, 103)
        Me.cmb_emite_sigipsa.Name = "cmb_emite_sigipsa"
        Me.cmb_emite_sigipsa.Size = New System.Drawing.Size(155, 21)
        Me.cmb_emite_sigipsa.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Emisión de resumen"
        '
        'cmd_ejecutar
        '
        Me.cmd_ejecutar.BackgroundImage = CType(resources.GetObject("cmd_ejecutar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ejecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_ejecutar.FlatAppearance.BorderSize = 0
        Me.cmd_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ejecutar.Location = New System.Drawing.Point(515, 35)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 50
        Me.cmd_ejecutar.UseVisualStyleBackColor = True
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(122, 103)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(119, 20)
        Me.txt_cuie.TabIndex = 4
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(8, 103)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuie.TabIndex = 49
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(122, 75)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(387, 20)
        Me.txt_efectores.TabIndex = 2
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(122, 22)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(387, 21)
        Me.cmb_departamentos.TabIndex = 0
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(122, 49)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(387, 21)
        Me.cmb_localidades.TabIndex = 1
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(6, 77)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(64, 13)
        Me.lbl_vacunatorio.TabIndex = 32
        Me.lbl_vacunatorio.Text = "Vacunatorio"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(6, 51)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidad.TabIndex = 31
        Me.lbl_localidad.Text = "Localidad"
        '
        'lbl_departamento
        '
        Me.lbl_departamento.AutoSize = True
        Me.lbl_departamento.Location = New System.Drawing.Point(6, 27)
        Me.lbl_departamento.Name = "lbl_departamento"
        Me.lbl_departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_departamento.TabIndex = 30
        Me.lbl_departamento.Text = "Departamento"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_EMITEN_SIGIPSABindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_ef_eminten_sigipsa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 151)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(807, 433)
        Me.ReportViewer1.TabIndex = 6
        '
        'list_efectores_emiten_resumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 596)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_datos_efector)
        Me.Name = "list_efectores_emiten_resumen"
        Me.Text = "Efectores por emisión de resumen"
        CType(Me.LIST_EMITEN_SIGIPSABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_efector.ResumeLayout(False)
        Me.grp_datos_efector.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_datos_efector As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_EMITEN_SIGIPSABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
    Friend WithEvents cmb_emite_sigipsa As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
