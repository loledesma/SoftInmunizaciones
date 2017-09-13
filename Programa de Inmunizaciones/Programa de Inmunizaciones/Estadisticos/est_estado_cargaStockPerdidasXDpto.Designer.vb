<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_estado_cargaStockPerdidasXDpto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(est_estado_cargaStockPerdidasXDpto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_ejecutar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_departamentos = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_stock = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.cmb_perdidas = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_perdidas)
        Me.GroupBox1.Controls.Add(Me.cmb_stock)
        Me.GroupBox1.Controls.Add(Me.cmb_carga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_localidades)
        Me.GroupBox1.Controls.Add(Me.cmb_departamentos)
        Me.GroupBox1.Controls.Add(Me.cmd_ejecutar)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(119, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cmd_ejecutar
        '
        Me.cmd_ejecutar.BackgroundImage = CType(resources.GetObject("cmd_ejecutar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ejecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_ejecutar.FlatAppearance.BorderSize = 0
        Me.cmd_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_ejecutar.Location = New System.Drawing.Point(801, 38)
        Me.cmd_ejecutar.Name = "cmd_ejecutar"
        Me.cmd_ejecutar.Size = New System.Drawing.Size(60, 60)
        Me.cmd_ejecutar.TabIndex = 5
        Me.cmd_ejecutar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 150)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1038, 529)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer2)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1030, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estado Carga"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1030, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estado Perdidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1030, 503)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Estado Stock"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Departamento"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(86, 72)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(309, 21)
        Me.cmb_localidades.TabIndex = 7
        '
        'cmb_departamentos
        '
        Me.cmb_departamentos._descripcion = "descripcion"
        Me.cmb_departamentos._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamentos._pk = "id"
        Me.cmb_departamentos.FormattingEnabled = True
        Me.cmb_departamentos.Location = New System.Drawing.Point(86, 45)
        Me.cmb_departamentos.Name = "cmb_departamentos"
        Me.cmb_departamentos.Size = New System.Drawing.Size(309, 21)
        Me.cmb_departamentos.TabIndex = 6
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1034, 503)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1034, 503)
        Me.ReportViewer2.TabIndex = 1
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1034, 503)
        Me.ReportViewer3.TabIndex = 1
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1034, 503)
        Me.ReportViewer4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Carga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Perdidas"
        '
        'cmb_carga
        '
        Me.cmb_carga._descripcion = "descripcion"
        Me.cmb_carga._nombre_tabla = "CARGA"
        Me.cmb_carga._pk = "id"
        Me.cmb_carga.FormattingEnabled = True
        Me.cmb_carga.Location = New System.Drawing.Point(459, 22)
        Me.cmb_carga.Name = "cmb_carga"
        Me.cmb_carga.Size = New System.Drawing.Size(235, 21)
        Me.cmb_carga.TabIndex = 13
        '
        'cmb_stock
        '
        Me.cmb_stock._descripcion = "descripcion"
        Me.cmb_stock._nombre_tabla = "STOCK"
        Me.cmb_stock._pk = "id"
        Me.cmb_stock.FormattingEnabled = True
        Me.cmb_stock.Location = New System.Drawing.Point(459, 59)
        Me.cmb_stock.Name = "cmb_stock"
        Me.cmb_stock.Size = New System.Drawing.Size(235, 21)
        Me.cmb_stock.TabIndex = 14
        '
        'cmb_perdidas
        '
        Me.cmb_perdidas._descripcion = "descripcion"
        Me.cmb_perdidas._nombre_tabla = "PERDIDA"
        Me.cmb_perdidas._pk = "id"
        Me.cmb_perdidas.FormattingEnabled = True
        Me.cmb_perdidas.Location = New System.Drawing.Point(459, 94)
        Me.cmb_perdidas.Name = "cmb_perdidas"
        Me.cmb_perdidas.Size = New System.Drawing.Size(235, 21)
        Me.cmb_perdidas.TabIndex = 15
        '
        'est_estado_cargaStockPerdidasXDpto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 691)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "est_estado_cargaStockPerdidasXDpto"
        Me.Text = "Cantidad efectores por estado de notificaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_ejecutar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_departamentos As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmb_perdidas As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_stock As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents cmb_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
End Class
