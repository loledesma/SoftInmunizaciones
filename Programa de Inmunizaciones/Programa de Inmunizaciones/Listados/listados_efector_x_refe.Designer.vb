<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listados_efector_x_refe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listados_efector_x_refe))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.grp_datos_efector = New System.Windows.Forms.GroupBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.LIST_EFEC_X_REFEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grp_datos_efector.SuspendLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_EFEC_X_REFEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_datos_efector
        '
        Me.grp_datos_efector.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_efector.Controls.Add(Me.cmd_ejecutar)
        Me.grp_datos_efector.Controls.Add(Me.txt_cuie)
        Me.grp_datos_efector.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_efector.Controls.Add(Me.txt_efectores)
        Me.grp_datos_efector.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_efector.Location = New System.Drawing.Point(237, 12)
        Me.grp_datos_efector.Name = "grp_datos_efector"
        Me.grp_datos_efector.Size = New System.Drawing.Size(490, 133)
        Me.grp_datos_efector.TabIndex = 3
        Me.grp_datos_efector.TabStop = False
        Me.grp_datos_efector.Text = "Datos Efector"
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
        Me.cmd_ejecutar.Location = New System.Drawing.Point(411, 20)
        Me.cmd_ejecutar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 50
        Me.cmd_ejecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_ejecutar.UseVisualStyleBackColor = False
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(122, 69)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(184, 20)
        Me.txt_cuie.TabIndex = 4
        '
        'lbl_cuie
        '
        Me.lbl_cuie.AutoSize = True
        Me.lbl_cuie.Location = New System.Drawing.Point(8, 69)
        Me.lbl_cuie.Name = "lbl_cuie"
        Me.lbl_cuie.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuie.TabIndex = 49
        Me.lbl_cuie.Text = "Cuie"
        '
        'txt_efectores
        '
        Me.txt_efectores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_efectores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_efectores.Location = New System.Drawing.Point(122, 41)
        Me.txt_efectores.Name = "txt_efectores"
        Me.txt_efectores.Size = New System.Drawing.Size(282, 20)
        Me.txt_efectores.TabIndex = 2
        '
        'lbl_vacunatorio
        '
        Me.lbl_vacunatorio.AutoSize = True
        Me.lbl_vacunatorio.Location = New System.Drawing.Point(6, 43)
        Me.lbl_vacunatorio.Name = "lbl_vacunatorio"
        Me.lbl_vacunatorio.Size = New System.Drawing.Size(54, 13)
        Me.lbl_vacunatorio.TabIndex = 32
        Me.lbl_vacunatorio.Text = "Referente"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.AutoScrollMargin = New System.Drawing.Size(2, 2)
        Me.ReportViewer1.AutoScrollMinSize = New System.Drawing.Size(2, 2)
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_EFEC_X_REFEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.listado_efector_x_refe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 163)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(993, 399)
        Me.ReportViewer1.TabIndex = 4
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIST_EFEC_X_REFEBindingSource
        '
        Me.LIST_EFEC_X_REFEBindingSource.DataMember = "LIST_EFEC_X_REFE"
        Me.LIST_EFEC_X_REFEBindingSource.DataSource = Me.Inmunizaciones
        '
        'listados_efector_x_refe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1017, 565)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_datos_efector)
        Me.Name = "listados_efector_x_refe"
        Me.Text = "REFERENTES Y SUS EFECTORES"
        Me.grp_datos_efector.ResumeLayout(False)
        Me.grp_datos_efector.PerformLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_EFEC_X_REFEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_datos_efector As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents LIST_EFEC_X_REFEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
End Class
