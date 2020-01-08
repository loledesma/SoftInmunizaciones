<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_atenciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_atenciones))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LISTATENCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.grp_datos_efector = New System.Windows.Forms.GroupBox()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.grp_datos_atenciones = New System.Windows.Forms.GroupBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_hasta = New System.Windows.Forms.Label()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_desde = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tltp_atenciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_asuntos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_estados_atenciones = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_palabra_contenida = New System.Windows.Forms.TextBox()
        CType(Me.LISTATENCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_datos_efector.SuspendLayout()
        Me.grp_datos_atenciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'LISTATENCIONESBindingSource
        '
        Me.LISTATENCIONESBindingSource.DataMember = "LIST_ATENCIONES"
        Me.LISTATENCIONESBindingSource.DataSource = Me.Inmunizaciones
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grp_datos_efector
        '
        Me.grp_datos_efector.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_efector.Controls.Add(Me.txt_cuie)
        Me.grp_datos_efector.Controls.Add(Me.lbl_cuie)
        Me.grp_datos_efector.Controls.Add(Me.txt_efectores)
        Me.grp_datos_efector.Controls.Add(Me.cmb_departamentos)
        Me.grp_datos_efector.Controls.Add(Me.cmb_localidades)
        Me.grp_datos_efector.Controls.Add(Me.lbl_vacunatorio)
        Me.grp_datos_efector.Controls.Add(Me.lbl_localidad)
        Me.grp_datos_efector.Controls.Add(Me.lbl_departamento)
        Me.grp_datos_efector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_efector.Location = New System.Drawing.Point(18, 11)
        Me.grp_datos_efector.Name = "grp_datos_efector"
        Me.grp_datos_efector.Size = New System.Drawing.Size(439, 148)
        Me.grp_datos_efector.TabIndex = 4
        Me.grp_datos_efector.TabStop = False
        Me.grp_datos_efector.Text = "Datos Efector"
        '
        'txt_cuie
        '
        Me.txt_cuie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cuie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cuie.Location = New System.Drawing.Point(122, 103)
        Me.txt_cuie.Name = "txt_cuie"
        Me.txt_cuie.Size = New System.Drawing.Size(184, 20)
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
        Me.txt_efectores.Size = New System.Drawing.Size(282, 20)
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
        Me.cmb_departamentos.Size = New System.Drawing.Size(281, 21)
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
        Me.cmb_localidades.Size = New System.Drawing.Size(281, 21)
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
        'grp_datos_atenciones
        '
        Me.grp_datos_atenciones.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos_atenciones.Controls.Add(Me.txt_palabra_contenida)
        Me.grp_datos_atenciones.Controls.Add(Me.Label3)
        Me.grp_datos_atenciones.Controls.Add(Me.Label2)
        Me.grp_datos_atenciones.Controls.Add(Me.cmb_estados_atenciones)
        Me.grp_datos_atenciones.Controls.Add(Me.Label1)
        Me.grp_datos_atenciones.Controls.Add(Me.cmb_asuntos)
        Me.grp_datos_atenciones.Controls.Add(Me.cmd_ejecutar)
        Me.grp_datos_atenciones.Controls.Add(Me.txt_fecha_hasta)
        Me.grp_datos_atenciones.Controls.Add(Me.lbl_hasta)
        Me.grp_datos_atenciones.Controls.Add(Me.txt_fecha_desde)
        Me.grp_datos_atenciones.Controls.Add(Me.lbl_desde)
        Me.grp_datos_atenciones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_datos_atenciones.Location = New System.Drawing.Point(472, 11)
        Me.grp_datos_atenciones.Name = "grp_datos_atenciones"
        Me.grp_datos_atenciones.Size = New System.Drawing.Size(514, 148)
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
        Me.cmd_ejecutar.Location = New System.Drawing.Point(447, 28)
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
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(301, 19)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_hasta.TabIndex = 35
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(256, 23)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 34
        Me.lbl_hasta.Text = "Hasta"
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(136, 19)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(97, 20)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'lbl_desde
        '
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Location = New System.Drawing.Point(74, 23)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_desde.TabIndex = 33
        Me.lbl_desde.Text = "Desde"
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
        ReportDataSource1.Value = Me.LISTATENCIONESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_atenciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(18, 165)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(967, 496)
        Me.ReportViewer1.TabIndex = 6
        '
        'cmb_asuntos
        '
        Me.cmb_asuntos._descripcion = "descripcion"
        Me.cmb_asuntos._nombre_tabla = "ASUNTO_ATENCIONES"
        Me.cmb_asuntos._pk = "id"
        Me.cmb_asuntos.FormattingEnabled = True
        Me.cmb_asuntos.Location = New System.Drawing.Point(136, 45)
        Me.cmb_asuntos.Name = "cmb_asuntos"
        Me.cmb_asuntos.Size = New System.Drawing.Size(262, 21)
        Me.cmb_asuntos.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Asunto"
        '
        'cmb_estados_atenciones
        '
        Me.cmb_estados_atenciones._descripcion = "descripcion"
        Me.cmb_estados_atenciones._nombre_tabla = "ESTADOS_ATENCION"
        Me.cmb_estados_atenciones._pk = "id"
        Me.cmb_estados_atenciones.FormattingEnabled = True
        Me.cmb_estados_atenciones.Location = New System.Drawing.Point(136, 72)
        Me.cmb_estados_atenciones.Name = "cmb_estados_atenciones"
        Me.cmb_estados_atenciones.Size = New System.Drawing.Size(262, 21)
        Me.cmb_estados_atenciones.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Palabra contenida"
        '
        'txt_palabra_contenida
        '
        Me.txt_palabra_contenida.Location = New System.Drawing.Point(136, 100)
        Me.txt_palabra_contenida.Name = "txt_palabra_contenida"
        Me.txt_palabra_contenida.Size = New System.Drawing.Size(262, 20)
        Me.txt_palabra_contenida.TabIndex = 55
        '
        'list_atenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 664)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_datos_atenciones)
        Me.Controls.Add(Me.grp_datos_efector)
        Me.Name = "list_atenciones"
        Me.Text = "ATENCIONES"
        CType(Me.LISTATENCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_datos_efector.ResumeLayout(False)
        Me.grp_datos_efector.PerformLayout()
        Me.grp_datos_atenciones.ResumeLayout(False)
        Me.grp_datos_atenciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_datos_efector As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cuie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuie As System.Windows.Forms.Label
    Friend WithEvents txt_efectores As System.Windows.Forms.TextBox
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents lbl_vacunatorio As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento As System.Windows.Forms.Label
    Friend WithEvents grp_datos_atenciones As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tltp_atenciones As System.Windows.Forms.ToolTip
    Friend WithEvents LISTATENCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
    Friend WithEvents txt_palabra_contenida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_estados_atenciones As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_asuntos As Programa_de_Inmunizaciones.ComboBoxV1
End Class
