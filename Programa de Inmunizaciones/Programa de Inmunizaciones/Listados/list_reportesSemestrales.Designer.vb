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
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1723, 927)
        Me.ReportViewer1.TabIndex = 0
        '
        'list_reportesSemestrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1747, 951)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "list_reportesSemestrales"
        Me.Text = "list_reportesSemestrales"
        CType(Me.LIST_REPORTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inmunizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LIST_REPORTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inmunizaciones As Programa_de_Inmunizaciones.Inmunizaciones
End Class
