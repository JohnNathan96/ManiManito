<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbIDP = New System.Windows.Forms.ComboBox()
        Me.cbProveedorProd = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtCantidadProv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1092, 13)
        Me.Panel2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1082, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 628)
        Me.Panel1.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1082, 47)
        Me.Panel3.TabIndex = 22
        '
        'txtCodigo
        '
        Me.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigo.Location = New System.Drawing.Point(59, 0)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(1023, 26)
        Me.txtCodigo.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Código"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtDescripcionProd)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1082, 43)
        Me.Panel4.TabIndex = 23
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionProd.Location = New System.Drawing.Point(92, 0)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.Size = New System.Drawing.Size(990, 26)
        Me.txtDescripcionProd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtPrecioProd)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1082, 43)
        Me.Panel5.TabIndex = 24
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrecioProd.Location = New System.Drawing.Point(53, 0)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(1029, 26)
        Me.txtPrecioProd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Precio"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel6.Controls.Add(Me.cbIDP)
        Me.Panel6.Controls.Add(Me.cbProveedorProd)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 146)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1082, 43)
        Me.Panel6.TabIndex = 25
        '
        'cbIDP
        '
        Me.cbIDP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbIDP.FormattingEnabled = True
        Me.cbIDP.Location = New System.Drawing.Point(897, 0)
        Me.cbIDP.Name = "cbIDP"
        Me.cbIDP.Size = New System.Drawing.Size(185, 28)
        Me.cbIDP.TabIndex = 2
        Me.cbIDP.Visible = False
        '
        'cbProveedorProd
        '
        Me.cbProveedorProd.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbProveedorProd.FormattingEnabled = True
        Me.cbProveedorProd.Location = New System.Drawing.Point(81, 0)
        Me.cbProveedorProd.Name = "cbProveedorProd"
        Me.cbProveedorProd.Size = New System.Drawing.Size(816, 28)
        Me.cbProveedorProd.TabIndex = 1
        Me.cbProveedorProd.Text = "Selecciona un Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Proveedor"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txtCantidadProv)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 189)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1082, 43)
        Me.Panel7.TabIndex = 26
        '
        'txtCantidadProv
        '
        Me.txtCantidadProv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidadProv.Location = New System.Drawing.Point(73, 0)
        Me.txtCantidadProv.Name = "txtCantidadProv"
        Me.txtCantidadProv.Size = New System.Drawing.Size(1009, 26)
        Me.txtCantidadProv.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cantidad"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 232)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 409)
        Me.Panel8.TabIndex = 27
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(882, 232)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 409)
        Me.Panel9.TabIndex = 30
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel11.Controls.Add(Me.IconButton3)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(200, 232)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(200, 409)
        Me.Panel11.TabIndex = 32
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 60
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 0)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(200, 63)
        Me.IconButton3.TabIndex = 30
        Me.IconButton3.Text = "Guardar"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel10.Controls.Add(Me.IconButton1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(682, 232)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 409)
        Me.Panel10.TabIndex = 33
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.SkullCrossbones
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 60
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(200, 63)
        Me.IconButton1.TabIndex = 31
        Me.IconButton1.Text = "Cancelar"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(400, 232)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(282, 409)
        Me.Panel12.TabIndex = 34
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 641)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormProductos"
        Me.Text = "FormProductos"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbProveedorProd As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtCantidadProv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbIDP As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel12 As Panel
End Class
