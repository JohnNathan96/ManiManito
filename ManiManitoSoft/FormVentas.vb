Imports MySql.Data.MySqlClient
Public Class FormVentas
    Dim total As Double = 0.0
    Dim cambio As Double = 0.0

    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged
        If txtImporte.Text <> "" Then
            cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
            txtCambio.Text = cambio
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        total = 0.00
        Try
            If DataGridView1.RowCount > 1 Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                For x As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                    DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value = CDbl(DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value) * CDbl(DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value)
                    total = total + DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value
                Next
            End If
            txtTotal.Text = total
            If txtImporte.Text <> "" Then
                cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
                txtCambio.Text = cambio
            End If
        Catch ex As Exception
            MessageBox.Show("Selecciona una fila valida")
        End Try
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        total = 0.00
        If DataGridView1.RowCount > 1 Then
            DataGridView1.CurrentRow.Cells("ColumnCantidad").Value = CInt(DataGridView1.CurrentRow.Cells("ColumnCantidad").Value) - 1
            If DataGridView1.CurrentRow.Cells("ColumnCantidad").Value = 0 Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If
            If DataGridView1.RowCount > 0 Then
                For x As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                    DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value = CDbl(DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value) * CDbl(DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value)
                    total = total + DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value
                Next
            End If
            txtTotal.Text = total
            If txtImporte.Text <> "" Then
                cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
                txtCambio.Text = cambio
            End If
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        total = 0.00
        If DataGridView1.RowCount > 1 Then
            DataGridView1.CurrentRow.Cells("ColumnCantidad").Value = CInt(DataGridView1.CurrentRow.Cells("ColumnCantidad").Value) + 1
            For x As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value = CDbl(DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value) * CDbl(DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value)
                total = total + DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value
            Next
        End If
        txtTotal.Text = total
        If txtImporte.Text <> "" Then
            cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
            txtCambio.Text = cambio
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim transaccion As MySqlTransaction
        Dim idU As Integer
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

            Dim comand As New MySqlCommand("insert into ventas (fecha,total)values('" & Date.Now & "','" & txtTotal.Text & "')", conexionString)
            comand.Transaction = transaccion
            comand.ExecuteNonQuery()
            transaccion.Commit()
            Dim selid As New MySqlCommand("SELECT MAX(idventa) AS idventa FROM ventas", conexionString)
            Dim lector As MySqlDataReader
            lector = selid.ExecuteReader
            While lector.Read
                idU = lector(0)
            End While
            conexionString.Close()

            For x As Integer = 0 To DataGridView1.RowCount - 2
                Dim transaccionDetalle As MySqlTransaction
                Dim conexionStringDetalle As New MySqlConnection(conexion.ToString)
                conexionStringDetalle.Open()
                transaccionDetalle = conexionStringDetalle.BeginTransaction
                Dim aidi As String = DataGridView1.Rows.Item(x).Cells("IDP").Value
                Dim cant As String = DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value
                Dim prcld As String = DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value
                Dim insertDetalle As New MySqlCommand("insert into detalleventa (idventadetalle,idProducto,cantidad,precioAlDia)values('" & idU & "','" & aidi & "','" & cant & "','" & prcld & "')", conexionStringDetalle)
                insertDetalle.Transaction = transaccionDetalle
                insertDetalle.ExecuteNonQuery()
                Dim actualiza As New MySqlCommand("update productos set cantidad ='" & CInt(DataGridView1.Rows.Item(x).Cells("CantExistente").Value) - CInt(cant) & "' where idproducto='" & aidi & "'", conexionStringDetalle)
                actualiza.Transaction = transaccionDetalle
                actualiza.ExecuteNonQuery()
                transaccionDetalle.Commit()
                conexionStringDetalle.Close()
            Next

        Catch ex As Exception
            MessageBox.Show("Oops algo falló dile a John que esto salió -> " + ex.Message)
        End Try
        DataGridView1.Rows.Clear()
        txtCambio.Text = ""
        txtImporte.Text = ""
        txtTotal.Text = ""
        cbProductosV.Text = ""
    End Sub

    Private Sub busquedaPres(caractes As String)
        DataGridView2.Rows.Clear()
        DataGridView2.Visible = True
        Try
            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = "manimanito"
            conexion.Database = "manimanito"
            conexion.Port = "3306"

            Dim conexionString As New MySqlConnection(conexion.ToString)
            conexionString.Open()

            Dim comand As New MySqlCommand("select * from productos where detalleProducto like '%" + caractes + "%'", conexionString)

            Dim lector As MySqlDataReader
            lector = comand.ExecuteReader

            While lector.Read
                DataGridView2.BringToFront()
                DataGridView2.Rows.Add(lector(1), lector(2), lector(0))
            End While

            conexionString.Close()
        Catch ex As Exception
            MessageBox.Show("Oops algo falló dile a john que esto salió -> " + ex.Message)
        End Try
    End Sub

    Private Sub Busqueda(codigo As String)
        Dim row As Integer = 0
        Dim ban As Boolean = False
        total = 0.00
        For z As Integer = 0 To DataGridView1.RowCount - 1 Step 1
            If codigo = DataGridView1.Rows.Item(z).Cells("IDP").Value Then
                ban = True
                row = z
                Exit For
            End If
        Next

        If ban = False Then
            Try
                Dim conexion As New MySqlConnectionStringBuilder()
                conexion.Server = "localhost"
                conexion.UserID = "root"
                conexion.Password = "manimanito"
                conexion.Database = "manimanito"
                conexion.Port = "3306"

                Dim conexionString As New MySqlConnection(conexion.ToString)
                conexionString.Open()

                Dim comand As New MySqlCommand("select * from productos where idproducto = '" + codigo + "'", conexionString)

                Dim lector As MySqlDataReader
                lector = comand.ExecuteReader

                While lector.Read
                    DataGridView1.Rows.Add(1, lector(1), lector(2), 0, lector(0), lector(4))
                End While

                conexionString.Close()
            Catch ex As Exception
                MessageBox.Show("Oops algo falló dile a john que esto salió -> " + ex.Message)
            End Try
        End If
        If ban = True Then
            DataGridView1.Rows.Item(row).Cells("ColumnCantidad").Value = CInt(DataGridView1.Rows.Item(row).Cells("ColumnCantidad").Value) + 1
        End If

        If DataGridView1.RowCount > 0 Then
            For x As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value = CDbl(DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value) * CDbl(DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value)
                total = total + DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value
            Next
        End If
        txtTotal.Text = total
        If txtImporte.Text <> "" Then
            cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
            txtCambio.Text = cambio
        End If
        cbProductosV.Text = ""
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        total = 0.00
        txtTotal.Text = ""

        Dim cant As String = InputBox("Ingresa la cantidad de gramos, cucharadas o porcion que va a vender", "Cantidad")
        If cant <> "" Then
            Dim row As Integer = 0
            Dim ban As Boolean = False
            Dim id As String = DataGridView2.Rows(e.RowIndex).Cells("ID").Value
            For z As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                If id = DataGridView1.Rows.Item(z).Cells("IDP").Value Then
                    ban = True
                    row = z
                    Exit For
                End If
            Next
            If ban = False Then
                DataGridView1.Rows.Add(cant, DataGridView2.CurrentRow.Cells("DGDescripcion").Value, DataGridView2.CurrentRow.Cells("Precio2").Value, 0.00, DataGridView2.CurrentRow.Cells("ID").Value)
            End If

            If ban = True Then
                DataGridView1.Rows.Item(row).Cells("ColumnCantidad").Value = CDbl(DataGridView1.Rows.Item(row).Cells("ColumnCantidad").Value) + CDbl(cant)
            End If

            If DataGridView1.RowCount > 0 Then
                For x As Integer = 0 To DataGridView1.RowCount - 1 Step 1
                    DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value = CDbl(DataGridView1.Rows.Item(x).Cells("ColumnPrecio").Value) * CDbl(DataGridView1.Rows.Item(x).Cells("ColumnCantidad").Value)
                    total = total + DataGridView1.Rows.Item(x).Cells("ColumnImporte").Value
                Next
            End If
            txtTotal.Text = total
            DataGridView2.Visible = False
            DataGridView2.Rows.Clear()
            If txtImporte.Text <> "" Then
                cambio = Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtTotal.Text)
                txtCambio.Text = cambio
            End If
            cbProductosV.Text = ""
        End If

        If cant = "" Then
            DataGridView2.Rows.Clear()
            DataGridView2.Visible = False
            cbProductosV.Text = ""
        End If
    End Sub

    Private Sub cbProductosV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProductosV.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataGridView2.Visible = False
            Busqueda(cbProductosV.Text)
        End If
        If Char.IsLetterOrDigit(e.KeyChar) Then
            busquedaPres(cbProductosV.Text)
        End If
    End Sub
End Class