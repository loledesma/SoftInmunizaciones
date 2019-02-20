<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_cumpleaños
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_up_cumpleaños))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgv_cumples = New System.Windows.Forms.DataGridView()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.enviar_Correo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mail_contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_cumples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(472, 157)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'dgv_cumples
        '
        Me.dgv_cumples.AllowUserToAddRows = False
        Me.dgv_cumples.AllowUserToDeleteRows = False
        Me.dgv_cumples.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_cumples.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgv_cumples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cumples.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellidos, Me.nombres, Me.nro_doc, Me.mail_contacto, Me.enviar_Correo})
        Me.dgv_cumples.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_cumples.Location = New System.Drawing.Point(12, 53)
        Me.dgv_cumples.Name = "dgv_cumples"
        Me.dgv_cumples.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_cumples.Size = New System.Drawing.Size(603, 83)
        Me.dgv_cumples.StandardTab = True
        Me.dgv_cumples.TabIndex = 1
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Calibri", 25.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_titulo.Location = New System.Drawing.Point(195, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(259, 41)
        Me.lbl_titulo.TabIndex = 2
        Me.lbl_titulo.Text = "Hoy cumple años:"
        '
        'enviar_Correo
        '
        Me.enviar_Correo.HeaderText = "Enviar correo"
        Me.enviar_Correo.Name = "enviar_Correo"
        Me.enviar_Correo.Text = "Enviar correo"
        Me.enviar_Correo.UseColumnTextForButtonValue = True
        '
        'mail_contacto
        '
        Me.mail_contacto.HeaderText = "Correo"
        Me.mail_contacto.Name = "mail_contacto"
        Me.mail_contacto.Width = 160
        '
        'nro_doc
        '
        Me.nro_doc.HeaderText = "Documento"
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Width = 70
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombre"
        Me.nombres.Name = "nombres"
        Me.nombres.Width = 110
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        '
        'pop_up_cumpleaños
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(620, 198)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgv_cumples)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pop_up_cumpleaños"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_cumples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents dgv_cumples As System.Windows.Forms.DataGridView
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail_contacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enviar_Correo As System.Windows.Forms.DataGridViewButtonColumn

End Class
