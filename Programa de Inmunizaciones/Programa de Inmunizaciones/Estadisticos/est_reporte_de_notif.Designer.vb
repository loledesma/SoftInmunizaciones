<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_reporte_de_notif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(est_reporte_de_notif))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Inmunizaciones2 = New Programa_de_Inmunizaciones.Inmunizaciones2()
        Me.EST_REPORTE_DE_NOTIFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Inmunizaciones2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EST_REPORTE_DE_NOTIFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cmd_generar)
        Me.GroupBox1.Controls.Add(Me.cmb_localidades)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(209, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 73)
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
        Me.cmd_generar.Location = New System.Drawing.Point(707, 14)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(49, 46)
        Me.cmd_generar.TabIndex = 4
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Items.AddRange(New Object() {"PRIMERO", "SEGUNDO", "TERCERO", "CUARTO"})
        Me.cmb_localidades.Location = New System.Drawing.Point(501, 28)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(182, 21)
        Me.cmb_localidades.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Trimestre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro de Salud"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "reporte_de_notif"
        ReportDataSource1.Value = Me.EST_REPORTE_DE_NOTIFBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programa_de_Inmunizaciones.est_reporte_de_notificaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 91)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1112, 639)
        Me.ReportViewer1.TabIndex = 3
        '
        'Inmunizaciones2
        '
        Me.Inmunizaciones2.DataSetName = "Inmunizaciones2"
        Me.Inmunizaciones2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EST_REPORTE_DE_NOTIFBindingSource
        '
        Me.EST_REPORTE_DE_NOTIFBindingSource.DataMember = "EST_REPORTE_DE_NOTIF"
        Me.EST_REPORTE_DE_NOTIFBindingSource.DataSource = Me.Inmunizaciones2
        '
        'est_reporte_de_notif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1136, 742)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "est_reporte_de_notif"
        Me.Text = "Reporte de Notificaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Inmunizaciones2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EST_REPORTE_DE_NOTIFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_generar As System.Windows.Forms.Button
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EST_REPORTE_DE_NOTIFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones2 As Programa_de_Inmunizaciones.Inmunizaciones2
End Class
