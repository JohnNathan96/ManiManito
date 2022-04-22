Imports FontAwesome.Sharp
Public Class Form1
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        DisableButton()

        If senderBtn IsNot Nothing Then
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.ForeColor = customColor

        End If

    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(3, 49, 71)
            currentBtn.ForeColor = Color.FromArgb(142, 203, 231)
            currentBtn.IconColor = Color.FromArgb(142, 203, 231)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        If childForm.Text = "FormVentas" Then
            lblFormTitle.Text = "Ventas"
        End If
        If childForm.Text = "FormProductos" Then
            lblFormTitle.Text = "Productos"
        End If


    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActiveButton(sender, Color.FromArgb(251, 133, 0))
        OpenChildForm(New FormVentas)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        ActiveButton(sender, Color.FromArgb(251, 133, 0))
        OpenChildForm(New FormProductos)
    End Sub
End Class
