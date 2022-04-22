<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DGDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantExistente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbProductosV = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Producto, Me.Precio})
        Me.dgvVentas.Location = New System.Drawing.Point(0, 182)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowTemplate.Height = 28
        Me.dgvVentas.Size = New System.Drawing.Size(520, 169)
        Me.dgvVentas.TabIndex = 4
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 110
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 280
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 110
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1092, 641)
        Me.Panel4.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txtImporte)
        Me.Panel7.Controls.Add(Me.IconButton1)
        Me.Panel7.Controls.Add(Me.txtTotal)
        Me.Panel7.Controls.Add(Me.txtCambio)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(573, 390)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(509, 251)
        Me.Panel7.TabIndex = 23
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(44, 63)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(247, 26)
        Me.txtImporte.TabIndex = 19
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 60
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 143)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(509, 108)
        Me.IconButton1.TabIndex = 18
        Me.IconButton1.Text = "Cobrar"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(44, 15)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(247, 26)
        Me.txtTotal.TabIndex = 15
        Me.txtTotal.Text = "0.00"
        '
        'txtCambio
        '
        Me.txtCambio.Location = New System.Drawing.Point(44, 111)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(247, 26)
        Me.txtCambio.TabIndex = 17
        Me.txtCambio.Text = "0.00"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel6.Controls.Add(Me.IconButton4)
        Me.Panel6.Controls.Add(Me.IconButton3)
        Me.Panel6.Controls.Add(Me.IconButton2)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 390)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(573, 251)
        Me.Panel6.TabIndex = 22
        '
        'IconButton4
        '
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton4.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 60
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(12, 84)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(218, 63)
        Me.IconButton4.TabIndex = 23
        Me.IconButton4.Text = "Restar"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 60
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(12, 15)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(218, 63)
        Me.IconButton3.TabIndex = 22
        Me.IconButton3.Text = "Agregar"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 60
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(11, 146)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(327, 63)
        Me.IconButton2.TabIndex = 21
        Me.IconButton2.Text = "Eliminar Producto"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(462, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cambio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(462, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Importe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Total"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1082, 330)
        Me.Panel5.TabIndex = 21
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGDescripcion, Me.Precio2, Me.ID})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1082, 330)
        Me.DataGridView2.TabIndex = 1
        Me.DataGridView2.Visible = False
        '
        'DGDescripcion
        '
        Me.DGDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DGDescripcion.HeaderText = "Descripción del Producto"
        Me.DGDescripcion.Name = "DGDescripcion"
        Me.DGDescripcion.ReadOnly = True
        Me.DGDescripcion.Width = 800
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.ReadOnly = True
        Me.Precio2.Width = 180
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 120
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCantidad, Me.ColumnProducto, Me.ColumnPrecio, Me.ColumnImporte, Me.IDP, Me.CantExistente})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1082, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'ColumnCantidad
        '
        Me.ColumnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnCantidad.HeaderText = "Cantidad"
        Me.ColumnCantidad.Name = "ColumnCantidad"
        Me.ColumnCantidad.Width = 140
        '
        'ColumnProducto
        '
        Me.ColumnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnProducto.HeaderText = "Descripción del Producto"
        Me.ColumnProducto.Name = "ColumnProducto"
        Me.ColumnProducto.ReadOnly = True
        Me.ColumnProducto.Width = 500
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnPrecio.HeaderText = "Precio"
        Me.ColumnPrecio.Name = "ColumnPrecio"
        Me.ColumnPrecio.ReadOnly = True
        Me.ColumnPrecio.Width = 180
        '
        'ColumnImporte
        '
        Me.ColumnImporte.HeaderText = "Importe"
        Me.ColumnImporte.Name = "ColumnImporte"
        Me.ColumnImporte.ReadOnly = True
        Me.ColumnImporte.Width = 180
        '
        'IDP
        '
        Me.IDP.HeaderText = "ID"
        Me.IDP.Name = "IDP"
        Me.IDP.ReadOnly = True
        '
        'CantExistente
        '
        Me.CantExistente.HeaderText = "Existente"
        Me.CantExistente.Name = "CantExistente"
        Me.CantExistente.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cbProductosV)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1082, 47)
        Me.Panel3.TabIndex = 20
        '
        'cbProductosV
        '
        Me.cbProductosV.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbProductosV.FormattingEnabled = True
        Me.cbProductosV.Location = New System.Drawing.Point(73, 0)
        Me.cbProductosV.Name = "cbProductosV"
        Me.cbProductosV.Size = New System.Drawing.Size(937, 28)
        Me.cbProductosV.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1082, 13)
        Me.Panel2.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1082, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 641)
        Me.Panel1.TabIndex = 18
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 641)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgvVentas)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DGDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents cbProductosV As ComboBox
    Friend WithEvents ColumnCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnImporte As DataGridViewTextBoxColumn
    Friend WithEvents IDP As DataGridViewTextBoxColumn
    Friend WithEvents CantExistente As DataGridViewTextBoxColumn
End Class
