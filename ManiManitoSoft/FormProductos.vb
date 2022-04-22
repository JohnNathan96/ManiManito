Imports MySql.Data.MySqlClient
Public Class FormProductos
    Dim id As Integer
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProveedorProd.Items.Add("Selecciona un proveedor")
        cbIDP.Items.Add("Selecciona un proveedor")
        Try
            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "manimanito"
            conexion.Database = "manimanito"
            conexion.Port = "3306"

            Dim conexionString As New MySqlConnection(conexion.ToString)
            conexionString.Open()

            Dim comand As New MySqlCommand("select * from proveedores", conexionString)

            Dim lector As MySqlDataReader
            lector = comand.ExecuteReader

            While lector.Read
                cbProveedorProd.Items.Add(lector(1))
                cbIDP.Items.Add(lector(0))
            End While

            conexionString.Close()
        Catch ex As Exception
            MessageBox.Show("Oops algo falló dile a john que esto salió -> " + ex.Message)
        End Try
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If txtCodigo.Text = "" Or txtCantidadProv.Text = "" Or txtDescripcionProd.Text = "" Or txtPrecioProd.Text = "" Or cbProveedorProd.SelectedIndex = 0 Then
            MessageBox.Show("Faltan Datos")
        Else
            Dim transaccion As MySqlTransaction
            Try
                Dim conexion As New MySqlConnectionStringBuilder()
                conexion.Server = "localhost"
                conexion.UserID = "root"
                conexion.Password = "manimanito"
                conexion.Database = "manimanito"
                conexion.Port = "3306"

                Dim conexionString As New MySqlConnection(conexion.ToString)
                conexionString.Open()
                transaccion = conexionString.BeginTransaction
                Dim prov As Integer = cbIDP.SelectedItem

                Dim comand As New MySqlCommand("insert into productos (idproducto,detalleProducto,precio,proveedor,cantidad)values('" & txtCodigo.Text & "','" & txtDescripcionProd.Text & "','" & txtPrecioProd.Text & "'," & prov & ",'" & txtCantidadProv.Text & "')", conexionString)
                comand.Transaction = transaccion
                comand.ExecuteNonQuery()
                transaccion.Commit()
            Catch ex As Exception
                Dim subString As String = Microsoft.VisualBasic.Left(ex.Message, 15)
                If subString = "Duplicate entry" Then
                    MessageBox.Show("Ya está registrado ese código de barras")
                Else
                    MessageBox.Show("Oops algo falló dile a John que esto salió -> " + subString)
                End If

            End Try
            txtCantidadProv.Text = ""
            txtCodigo.Text = ""
            txtDescripcionProd.Text = ""
            txtPrecioProd.Text = ""
            cbProveedorProd.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbProveedorProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedorProd.SelectedIndexChanged
        id = cbProveedorProd.SelectedIndex
        cbIDP.SelectedIndex = id
    End Sub

    Private Sub txtPrecioProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioProd.KeyPress
        Dim deci As Char = "."
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = deci Or Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadProv.KeyPress
        Dim deci As Char = "."
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = deci Or Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbProveedorProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProveedorProd.KeyPress
        e.Handled = True
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        txtCantidadProv.Text = ""
        txtCodigo.Text = ""
        txtDescripcionProd.Text = ""
        txtPrecioProd.Text = ""
        cbProveedorProd.SelectedIndex = 0
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        Dim ban As Boolean = False
        Dim prod As String = ""
        If Asc(e.KeyChar) = 13 Then
            Try
                Dim conexion As New MySqlConnectionStringBuilder()
                conexion.Server = "localhost"
                conexion.UserID = "root"
                conexion.Password = "manimanito"
                conexion.Database = "manimanito"
                conexion.Port = "3306"

                Dim conexionString As New MySqlConnection(conexion.ToString)
                conexionString.Open()

                Dim comand As New MySqlCommand("select * from productos where idproducto = '" & txtCodigo.Text & "'", conexionString)

                Dim lector As MySqlDataReader
                lector = comand.ExecuteReader

                While lector.Read
                    ban = True
                    prod = lector(1)
                End While

                If ban = True Then
                    MessageBox.Show("Este producto ya existe como " + prod)
                    txtCodigo.Text = ""
                End If

                conexionString.Close()
            Catch ex As Exception
                MessageBox.Show("Oops algo falló dile a john que esto salió -> " + ex.Message)
            End Try
        End If
    End Sub
End Class