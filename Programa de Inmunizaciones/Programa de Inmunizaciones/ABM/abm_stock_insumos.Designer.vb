<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_stock_insumos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_stock_insumos))
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.dgv_stock = New System.Windows.Forms.DataGridView()
        Me.id_insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_salir.FlatAppearance.BorderSize = 0
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.Location = New System.Drawing.Point(412, 195)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(60, 60)
        Me.cmd_salir.TabIndex = 64
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'dgv_stock
        '
        Me.dgv_stock.AllowUserToAddRows = False
        Me.dgv_stock.AllowUserToDeleteRows = False
        Me.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_insumo, Me.insumo, Me.cantidad})
        Me.dgv_stock.Location = New System.Drawing.Point(12, 12)
        Me.dgv_stock.Name = "dgv_stock"
        Me.dgv_stock.ReadOnly = True
        Me.dgv_stock.Size = New System.Drawing.Size(469, 154)
        Me.dgv_stock.TabIndex = 65
        '
        'id_insumo
        '
        Me.id_insumo.HeaderText = "id_insumo"
        Me.id_insumo.Name = "id_insumo"
        Me.id_insumo.ReadOnly = True
        Me.id_insumo.Visible = False
        '
        'insumo
        '
        Me.insumo.HeaderText = "Insumo"
        Me.insumo.Name = "insumo"
        Me.insumo.ReadOnly = True
        Me.insumo.Width = 300
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'abm_stock_insumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(510, 268)
        Me.Controls.Add(Me.dgv_stock)
        Me.Controls.Add(Me.cmd_salir)
        Me.Name = "abm_stock_insumos"
        Me.Text = "Stock Insumos"
        CType(Me.dgv_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents dgv_stock As System.Windows.Forms.DataGridView
    Friend WithEvents id_insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents insumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
