<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_usuarios))
        Me.grp_datos_efector = New System.Windows.Forms.GroupBox()
        Me.txt_cuie = New System.Windows.Forms.TextBox()
        Me.lbl_cuie = New System.Windows.Forms.Label()
        Me.txt_efectores = New System.Windows.Forms.TextBox()
        Me.lbl_vacunatorio = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_departamento = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tltp_usuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_usuario = New System.Windows.Forms.GroupBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_estados_usuarios = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Inmunizaciones = New Programa_de_Inmunizaciones.Inmunizaciones()
        Me.LIST_USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grp_datos_efector.SuspendLayout()
        Me.grp_usuario.SuspendLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grp_datos_efector.Size = New System.Drawing.Size(436, 133)
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
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.AutoScrollMargin = New System.Drawing.Size(2, 2)
        Me.ReportViewer1.AutoScrollMinSize = New System.Drawing.Size(2, 2)
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LIST_USUARIOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.list_usuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(18, 150)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(967, 436)
        Me.ReportViewer1.TabIndex = 6
        '
        'grp_usuario
        '
        Me.grp_usuario.BackColor = System.Drawing.Color.Transparent
        Me.grp_usuario.Controls.Add(Me.cmd_ejecutar)
        Me.grp_usuario.Controls.Add(Me.cmb_estados_usuarios)
        Me.grp_usuario.Controls.Add(Me.Label4)
        Me.grp_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grp_usuario.Location = New System.Drawing.Point(480, 12)
        Me.grp_usuario.Name = "grp_usuario"
        Me.grp_usuario.Size = New System.Drawing.Size(505, 133)
        Me.grp_usuario.TabIndex = 50
        Me.grp_usuario.TabStop = False
        Me.grp_usuario.Text = "Datos Usuario"
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
        Me.cmd_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ejecutar.Location = New System.Drawing.Point(424, 30)
        Me.cmd_ejecutar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 31
        Me.cmd_ejecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_ejecutar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Estado"
        '
        'cmb_estados_usuarios
        '
        Me.cmb_estados_usuarios._descripcion = "descripcion"
        Me.cmb_estados_usuarios._nombre_tabla = "ESTADOS_USUARIOS"
        Me.cmb_estados_usuarios._pk = "id"
        Me.cmb_estados_usuarios.FormattingEnabled = True
        Me.cmb_estados_usuarios.Location = New System.Drawing.Point(124, 48)
        Me.cmb_estados_usuarios.Name = "cmb_estados_usuarios"
        Me.cmb_estados_usuarios.Size = New System.Drawing.Size(281, 21)
        Me.cmb_estados_usuarios.TabIndex = 0
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
        'Inmunizaciones
        '
        Me.Inmunizaciones.DataSetName = "Inmunizaciones"
        Me.Inmunizaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIST_USUARIOSBindingSource
        '
        Me.LIST_USUARIOSBindingSource.DataMember = "LIST_USUARIOS"
        Me.LIST_USUARIOSBindingSource.DataSource = Me.Inmunizaciones
        '
        'list_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(997, 598)
        Me.Controls.Add(Me.grp_usuario)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.grp_datos_efector)
        Me.Name = "list_usuarios"
        Me.Text = "USUARIOS"
        Me.grp_datos_efector.ResumeLayout(False)
        Me.grp_datos_efector.PerformLayout()
        Me.grp_usuario.ResumeLayout(False)
        Me.grp_usuario.PerformLayout()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tltp_usuarios As System.Windows.Forms.ToolTip
    Friend WithEvents grp_usuario As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_estados_usuarios As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents LIST_USUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
End Class
