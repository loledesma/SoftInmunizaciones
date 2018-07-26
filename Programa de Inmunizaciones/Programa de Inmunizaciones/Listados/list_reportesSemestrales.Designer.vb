<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_reportesSemestrales
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_reportesSemestrales))
        Me.LIST_REPORTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_cuie_responsable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cuie_particular = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmd_generar_repo = New System.Windows.Forms.Button()
        Me.cmd_buscar_centro_partic = New System.Windows.Forms.Button()
        Me.txt_vacunatorio_particular = New System.Windows.Forms.TextBox()
        Me.txt_centro_responsable = New System.Windows.Forms.TextBox()
        Me.tltp_reportes = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_semestres = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_años = New Programa_de_Inmunizaciones.ComboBoxV1()
        CType(Me.LIST_REPORTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIST_REPORTESBindingSource
        '
        Me.LIST_REPORTESBindingSource.DataMember = "LIST_REPORTES"
        Me.LIST_REPORTESBindingSource.DataSource = Me.Inmunizaciones
        '
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 85
        ReportDataSource1.Name = "list_reportes"
        ReportDataSource1.Value = Me.LIST_REPORTESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_reportes_semestrales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 131)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1487, 549)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_cuie_responsable
        '
        Me.txt_cuie_responsable.Location = New System.Drawing.Point(460, 36)
        Me.txt_cuie_responsable.Name = "txt_cuie_responsable"
        Me.txt_cuie_responsable.Size = New System.Drawing.Size(102, 20)
        Me.txt_cuie_responsable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vacunatorio responsable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vacunatorio particular"
        '
        'txt_cuie_particular
        '
        Me.txt_cuie_particular.Location = New System.Drawing.Point(460, 75)
        Me.txt_cuie_particular.Name = "txt_cuie_particular"
        Me.txt_cuie_particular.Size = New System.Drawing.Size(102, 20)
        Me.txt_cuie_particular.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(703, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Semestre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(592, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Año"
        '
        'cmd_generar_repo
        '
        Me.cmd_generar_repo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_generar_repo.BackgroundImage = CType(resources.GetObject("cmd_generar_repo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_generar_repo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_generar_repo.FlatAppearance.BorderSize = 0
        Me.cmd_generar_repo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_generar_repo.Location = New System.Drawing.Point(910, 26)
        Me.cmd_generar_repo.Name = "cmd_generar_repo"
        Me.cmd_generar_repo.Size = New System.Drawing.Size(37, 36)
        Me.cmd_generar_repo.TabIndex = 4
        Me.cmd_generar_repo.UseVisualStyleBackColor = False
        '
        'cmd_buscar_centro_partic
        '
        Me.cmd_buscar_centro_partic.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar_centro_partic.BackgroundImage = CType(resources.GetObject("cmd_buscar_centro_partic.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_centro_partic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_centro_partic.FlatAppearance.BorderSize = 0
        Me.cmd_buscar_centro_partic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar_centro_partic.Location = New System.Drawing.Point(568, 66)
        Me.cmd_buscar_centro_partic.Name = "cmd_buscar_centro_partic"
        Me.cmd_buscar_centro_partic.Size = New System.Drawing.Size(37, 36)
        Me.cmd_buscar_centro_partic.TabIndex = 7
        Me.cmd_buscar_centro_partic.UseVisualStyleBackColor = False
        '
        'txt_vacunatorio_particular
        '
        Me.txt_vacunatorio_particular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_vacunatorio_particular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_vacunatorio_particular.Location = New System.Drawing.Point(142, 75)
        Me.txt_vacunatorio_particular.Name = "txt_vacunatorio_particular"
        Me.txt_vacunatorio_particular.Size = New System.Drawing.Size(312, 20)
        Me.txt_vacunatorio_particular.TabIndex = 5
        '
        'txt_centro_responsable
        '
        Me.txt_centro_responsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_centro_responsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_centro_responsable.Location = New System.Drawing.Point(142, 36)
        Me.txt_centro_responsable.Name = "txt_centro_responsable"
        Me.txt_centro_responsable.Size = New System.Drawing.Size(312, 20)
        Me.txt_centro_responsable.TabIndex = 0
        '
        'cmb_semestres
        '
        Me.cmb_semestres._descripcion = "descripcion"
        Me.cmb_semestres._nombre_tabla = "semestres"
        Me.cmb_semestres._pk = "id"
        Me.cmb_semestres.FormattingEnabled = True
        Me.cmb_semestres.Location = New System.Drawing.Point(760, 35)
        Me.cmb_semestres.Name = "cmb_semestres"
        Me.cmb_semestres.Size = New System.Drawing.Size(144, 21)
        Me.cmb_semestres.TabIndex = 3
        '
        'cmb_años
        '
        Me.cmb_años._descripcion = "descripcion"
        Me.cmb_años._nombre_tabla = "reportes_años"
        Me.cmb_años._pk = "id"
        Me.cmb_años.FormattingEnabled = True
        Me.cmb_años.Location = New System.Drawing.Point(624, 35)
        Me.cmb_años.Name = "cmb_años"
        Me.cmb_años.Size = New System.Drawing.Size(69, 21)
        Me.cmb_años.TabIndex = 2
        '
        'list_reportesSemestrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1512, 692)
        Me.Controls.Add(Me.txt_centro_responsable)
        Me.Controls.Add(Me.txt_vacunatorio_particular)
        Me.Controls.Add(Me.cmd_buscar_centro_partic)
        Me.Controls.Add(Me.cmd_generar_repo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_semestres)
        Me.Controls.Add(Me.cmb_años)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cuie_particular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cuie_responsable)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "list_reportesSemestrales"
        Me.Text = "list_reportesSemestrales"
        CType(Me.LIST_REPORTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_REPORTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
    Friend WithEvents txt_cuie_responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cuie_particular As System.Windows.Forms.TextBox
    Friend WithEvents cmb_años As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_semestres As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_generar_repo As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_centro_partic As System.Windows.Forms.Button
    Friend WithEvents txt_vacunatorio_particular As System.Windows.Forms.TextBox
    Friend WithEvents txt_centro_responsable As System.Windows.Forms.TextBox
    Friend WithEvents tltp_reportes As System.Windows.Forms.ToolTip
End Class
