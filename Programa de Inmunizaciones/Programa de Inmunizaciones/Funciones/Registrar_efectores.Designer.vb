<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_efectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_efectores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_tipo_carga = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_estado_efector = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_tipos_efectores = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_referentes = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_departamento = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_localidades = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_barrios = New Programa_de_Inmunizaciones.ComboBoxV1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_buscar_id = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_id)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_carga)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmb_estado_efector)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmb_tipos_efectores)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmb_referentes)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del vacunatorio  "
        '
        'cmb_tipo_carga
        '
        Me.cmb_tipo_carga._descripcion = "descripcion"
        Me.cmb_tipo_carga._nombre_tabla = "TIPO_CARGA"
        Me.cmb_tipo_carga._pk = "id"
        Me.cmb_tipo_carga.FormattingEnabled = True
        Me.cmb_tipo_carga.Location = New System.Drawing.Point(346, 176)
        Me.cmb_tipo_carga.Name = "cmb_tipo_carga"
        Me.cmb_tipo_carga.Size = New System.Drawing.Size(159, 21)
        Me.cmb_tipo_carga.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(279, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Tipo carga"
        '
        'cmb_estado_efector
        '
        Me.cmb_estado_efector._descripcion = "descripcion"
        Me.cmb_estado_efector._nombre_tabla = "ESTADOS_EFECTOR"
        Me.cmb_estado_efector._pk = "id"
        Me.cmb_estado_efector.FormattingEnabled = True
        Me.cmb_estado_efector.Location = New System.Drawing.Point(114, 176)
        Me.cmb_estado_efector.Name = "cmb_estado_efector"
        Me.cmb_estado_efector.Size = New System.Drawing.Size(159, 21)
        Me.cmb_estado_efector.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Estado"
        '
        'cmb_tipos_efectores
        '
        Me.cmb_tipos_efectores._descripcion = "descripcion"
        Me.cmb_tipos_efectores._nombre_tabla = "TIPOS_EFECTORES"
        Me.cmb_tipos_efectores._pk = "id"
        Me.cmb_tipos_efectores.FormattingEnabled = True
        Me.cmb_tipos_efectores.Location = New System.Drawing.Point(346, 143)
        Me.cmb_tipos_efectores.Name = "cmb_tipos_efectores"
        Me.cmb_tipos_efectores.Size = New System.Drawing.Size(159, 21)
        Me.cmb_tipos_efectores.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(279, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Tipo Efector"
        '
        'cmb_referentes
        '
        Me.cmb_referentes._descripcion = "nombre"
        Me.cmb_referentes._nombre_tabla = "EFECTORES"
        Me.cmb_referentes._pk = "CUIE"
        Me.cmb_referentes.FormattingEnabled = True
        Me.cmb_referentes.Location = New System.Drawing.Point(114, 143)
        Me.cmb_referentes.Name = "cmb_referentes"
        Me.cmb_referentes.Size = New System.Drawing.Size(159, 21)
        Me.cmb_referentes.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Referente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "hasta"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(114, 113)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(53, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(212, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(61, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Horario de atención"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MaskedTextBox3.Location = New System.Drawing.Point(114, 75)
        Me.MaskedTextBox3.Mask = "99999999999"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(159, 20)
        Me.MaskedTextBox3.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Teléfono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_departamento)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmb_localidades)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_barrios)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(6, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 106)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cmb_departamento
        '
        Me.cmb_departamento._descripcion = "descripcion"
        Me.cmb_departamento._nombre_tabla = "DEPARTAMENTOS"
        Me.cmb_departamento._pk = "id"
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(108, 72)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(159, 21)
        Me.cmb_departamento.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Departamento"
        '
        'cmb_localidades
        '
        Me.cmb_localidades._descripcion = "descripcion"
        Me.cmb_localidades._nombre_tabla = "LOCALIDADES"
        Me.cmb_localidades._pk = "id"
        Me.cmb_localidades.FormattingEnabled = True
        Me.cmb_localidades.Location = New System.Drawing.Point(332, 45)
        Me.cmb_localidades.Name = "cmb_localidades"
        Me.cmb_localidades.Size = New System.Drawing.Size(161, 21)
        Me.cmb_localidades.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Localidad"
        '
        'cmb_barrios
        '
        Me.cmb_barrios._descripcion = "descripcion"
        Me.cmb_barrios._nombre_tabla = "BARRIOS"
        Me.cmb_barrios._pk = "id"
        Me.cmb_barrios.FormattingEnabled = True
        Me.cmb_barrios.Location = New System.Drawing.Point(108, 45)
        Me.cmb_barrios.Name = "cmb_barrios"
        Me.cmb_barrios.Size = New System.Drawing.Size(159, 21)
        Me.cmb_barrios.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Barrio"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MaskedTextBox2.Location = New System.Drawing.Point(434, 19)
        Me.MaskedTextBox2.Mask = "99999999"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(59, 20)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(108, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(275, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Calle"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Culture = New System.Globalization.CultureInfo("es-ES")
        Me.MaskedTextBox1.Location = New System.Drawing.Point(114, 23)
        Me.MaskedTextBox1.Mask = "99999999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(159, 20)
        Me.MaskedTextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIE"
        '
        'cmd_buscar_id
        '
        Me.cmd_buscar_id.BackgroundImage = CType(resources.GetObject("cmd_buscar_id.BackgroundImage"), System.Drawing.Image)
        Me.cmd_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_buscar_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar_id.Location = New System.Drawing.Point(279, 19)
        Me.cmd_buscar_id.Name = "cmd_buscar_id"
        Me.cmd_buscar_id.Size = New System.Drawing.Size(25, 25)
        Me.cmd_buscar_id.TabIndex = 20
        Me.cmd_buscar_id.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(395, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(529, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 324)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Empleados"
        '
        'Registrar_efectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 415)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_efectores"
        Me.Text = "Registro de efectores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrios As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_departamento As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidades As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_carga As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_efector As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipos_efectores As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_referentes As Programa_de_Inmunizaciones.ComboBoxV1
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar_id As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
