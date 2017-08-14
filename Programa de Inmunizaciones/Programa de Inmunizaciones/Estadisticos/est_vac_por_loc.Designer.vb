<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_vac_por_loc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(est_vac_por_loc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_generar)
        Me.GroupBox1.Controls.Add(Me.cmb_localidades)
        Me.GroupBox1.Controls.Add(Me.cmb_departamentos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(204, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 89)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'cmd_generar
        '
        Me.cmd_generar.BackgroundImage = CType(resources.GetObject("cmd_generar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_generar.FlatAppearance.BorderSize = 0
        Me.cmd_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_generar.Location = New System.Drawing.Point(423, 19)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_generar.TabIndex = 4
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(96, 52)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(278, 21)
        Me.cmb_localidades.TabIndex = 3
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(96, 24)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(278, 21)
        Me.cmb_departamentos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.est_efectores_localidad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 107)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(949, 381)
        Me.ReportViewer1.TabIndex = 3
        '
        'est_vac_por_loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 500)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "est_vac_por_loc"
        Me.Text = "est_vac_por_loc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_generar As System.Windows.Forms.Button
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EST_EFECTORES_X_LOC_X_DPTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones2 As Programa_de_Inmunizaciones.Inmunizaciones2
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
