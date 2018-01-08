<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareas
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.picbox_1 = New System.Windows.Forms.PictureBox()
        Me.picbox_2 = New System.Windows.Forms.PictureBox()
        Me.picbox_3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picbox_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(577, 274)
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
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Calibri", 20.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_titulo.Location = New System.Drawing.Point(34, 18)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(649, 33)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "LOS SIGUIENTES EMPLEADOS TIENEN TAREAS PENDIENTES"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picbox_1
        '
        Me.picbox_1.Image = Global.Programa_de_Inmunizaciones.My.Resources.Resources.customer_person_people_woman_you_1627
        Me.picbox_1.Location = New System.Drawing.Point(66, 81)
        Me.picbox_1.Name = "picbox_1"
        Me.picbox_1.Size = New System.Drawing.Size(112, 108)
        Me.picbox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_1.TabIndex = 4
        Me.picbox_1.TabStop = False
        Me.picbox_1.Visible = False
        '
        'picbox_2
        '
        Me.picbox_2.Image = Global.Programa_de_Inmunizaciones.My.Resources.Resources.images__2_
        Me.picbox_2.Location = New System.Drawing.Point(282, 81)
        Me.picbox_2.Name = "picbox_2"
        Me.picbox_2.Size = New System.Drawing.Size(126, 108)
        Me.picbox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_2.TabIndex = 5
        Me.picbox_2.TabStop = False
        Me.picbox_2.Visible = False
        '
        'picbox_3
        '
        Me.picbox_3.Image = Global.Programa_de_Inmunizaciones.My.Resources.Resources.images__1_
        Me.picbox_3.Location = New System.Drawing.Point(488, 81)
        Me.picbox_3.Name = "picbox_3"
        Me.picbox_3.Size = New System.Drawing.Size(126, 108)
        Me.picbox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_3.TabIndex = 6
        Me.picbox_3.TabStop = False
        Me.picbox_3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(83, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LORE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(306, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "JOACO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(519, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "LEA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 20.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 33)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "REVISE SU TABLERO DE ACTIVIDADES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tareas
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programa_de_Inmunizaciones.My.Resources.Resources.vacu_logo_min
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(735, 315)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picbox_3)
        Me.Controls.Add(Me.picbox_2)
        Me.Controls.Add(Me.picbox_1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tareas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "¡ATENCION!"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.picbox_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents picbox_1 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_2 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
