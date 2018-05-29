<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajustes_Pendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajustes_Pendientes))
        Me.dgv_atenc_pendientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_aceptar = New System.Windows.Forms.Button()
        Me.txt_atenciones = New System.Windows.Forms.Button()
        Me.cuie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_efector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_atenc_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_atenc_pendientes
        '
        Me.dgv_atenc_pendientes.AllowUserToAddRows = False
        Me.dgv_atenc_pendientes.AllowUserToDeleteRows = False
        Me.dgv_atenc_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_atenc_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuie, Me.nombre_efector})
        resources.ApplyResources(Me.dgv_atenc_pendientes, "dgv_atenc_pendientes")
        Me.dgv_atenc_pendientes.Name = "dgv_atenc_pendientes"
        Me.dgv_atenc_pendientes.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Name = "Label1"
        '
        'txt_aceptar
        '
        resources.ApplyResources(Me.txt_aceptar, "txt_aceptar")
        Me.txt_aceptar.Name = "txt_aceptar"
        Me.txt_aceptar.UseVisualStyleBackColor = True
        '
        'txt_atenciones
        '
        Me.txt_atenciones.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.txt_atenciones, "txt_atenciones")
        Me.txt_atenciones.FlatAppearance.BorderSize = 0
        Me.txt_atenciones.Name = "txt_atenciones"
        Me.txt_atenciones.UseVisualStyleBackColor = False
        '
        'cuie
        '
        resources.ApplyResources(Me.cuie, "cuie")
        Me.cuie.Name = "cuie"
        Me.cuie.ReadOnly = True
        '
        'nombre_efector
        '
        resources.ApplyResources(Me.nombre_efector, "nombre_efector")
        Me.nombre_efector.Name = "nombre_efector"
        Me.nombre_efector.ReadOnly = True
        '
        'Ajustes_Pendientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txt_atenciones)
        Me.Controls.Add(Me.txt_aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_atenc_pendientes)
        Me.Name = "Ajustes_Pendientes"
        CType(Me.dgv_atenc_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_atenc_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_atenciones As System.Windows.Forms.Button
    Friend WithEvents cuie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_efector As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
