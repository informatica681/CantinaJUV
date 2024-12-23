Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing
Imports System.Resources
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class PRUEBACAJA
    Dim conn As New MySqlConnection
    Dim dt As New DataTable
    Dim conexion As String = ("server=localhost;userid=root;password=escuela;database=cantinakarting")
    Dim cantidad As Integer = 1
    Dim precioUnitario As Decimal = 0
    Dim GRIAN As Integer
    Dim stockactual As Integer

    Private Sub PRUEBACAJA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        Dim datos As New DataSet
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 18)
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next


        Using adaptador As New MySqlDataAdapter("Select nombre, cant, subtotal From pedido", conexion)
            adaptador.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LoadComboBox()
        TbCant.Text = "1"
        TbTOTAL.Text = GRIAN
        TbImporte.Text = ""
        TbVuelto.Text = ""
        LimpiarTablaPedido()
    End Sub

    Private Sub LimpiarTablaPedido()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim cmdDelete As New MySqlCommand("DELETE FROM pedido", conn)
            cmdDelete.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar la tabla: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Dim datos As New DataSet
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 18)
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Using adaptador As New MySqlDataAdapter("Select nombre, cant, subtotal From pedido", conexion)
            adaptador.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadComboBox()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim query As String = "SELECT nombre FROM productos"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While reader.Read()
                ComboBox1.Items.Add(reader("nombre").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el ComboBox: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        If ComboBox1.SelectedItem Is Nothing Then

            Exit Sub
        End If
        Try
            conn.Open()
            Dim selectedProduct As String = ComboBox1.SelectedItem.ToString()
            Dim query As String = "SELECT nombre, stock, precio_unitario FROM productos WHERE nombre = @nombre"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nombre", selectedProduct)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                TbPrecio.Text = reader("precio_unitario").ToString()
                TbNombre.Text = reader("nombre").ToString()
                precioUnitario = Convert.ToInt16(reader("precio_unitario"))
                RecalcularSubtotal()
                stockactual = Convert.ToInt32(reader("stock"))
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Total()
        Dim precio As Integer = Convert.ToInt32(TbPrecio.Text)
        Dim cantidad As Integer = Convert.ToInt32(TbCant.Text)
        Dim subtotal As Decimal = cantidad * precio
        Dim total As Decimal = GRIAN + subtotal
        TbTOTAL.Text = total
    End Sub

    Private Sub RecalcularSubtotal()
        Dim subtotal As Integer = cantidad * precioUnitario
        TbSubTotal.Text = subtotal.ToString()
        Total()
    End Sub

    Private Sub BtMas_Click(sender As Object, e As EventArgs) Handles BtMas.Click
        cantidad += 1
        TbCant.Text = cantidad.ToString()
        RecalcularSubtotal()
    End Sub

    Private Sub BtMenos_Click(sender As Object, e As EventArgs) Handles BtMenos.Click
        If cantidad > 1 Then
            cantidad -= 1
            TbCant.Text = cantidad.ToString()
            RecalcularSubtotal()
        End If
    End Sub
    Private Sub MostrarImpresorasDisponibles()
        Dim impresoras As String = ""
        For Each printer In PrinterSettings.InstalledPrinters
            impresoras &= printer & vbCrLf
        Next
        MessageBox.Show("Impresoras disponibles: " & vbCrLf & impresoras)
    End Sub
    Private Sub BtAnotar_Click(sender As Object, e As EventArgs) Handles BtAnotar.Click
        If String.IsNullOrWhiteSpace(TbCant.Text) OrElse TbCant.Text = "0" Then
            MessageBox.Show("La cantidad no puede ser 0. Por favor, ingrese un valor válido.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim queryStock As String = "SELECT stock FROM productos WHERE nombre = @nombre"
            Dim cmdStock As New MySqlCommand(queryStock, conn)
            cmdStock.Parameters.AddWithValue("@nombre", TbNombre.Text)
            Dim stockActual As Integer = Convert.ToInt32(cmdStock.ExecuteScalar())
            Dim cantidadSolicitada As Integer = Convert.ToInt32(TbCant.Text)

            If cantidadSolicitada > stockActual Then
                MessageBox.Show("No hay suficiente stock disponible. Stock actual: " & stockActual.ToString(), "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim precio As Integer = Convert.ToInt32(TbPrecio.Text) '
            Dim cantidad As Integer = Convert.ToInt32(TbCant.Text)
            Dim subtotal As Decimal = cantidad * precio

            Dim entrada As String = "INSERT INTO pedido (nombre, cant, subtotal) VALUES (@nombre, @cant, @subtotal)"
            Dim cmd As New MySqlCommand(entrada, conn)
            cmd.Parameters.AddWithValue("@nombre", TbNombre.Text)
            cmd.Parameters.AddWithValue("@cant", cantidad)
            cmd.Parameters.AddWithValue("@subtotal", TbSubTotal.Text)
            cmd.ExecuteNonQuery()
            GRIAN += subtotal
            TbTOTAL.Text = GRIAN.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        dt.Clear()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Try
            Using adaptador As New MySqlDataAdapter("SELECT nombre, cant FROM pedido", conexion)
                adaptador.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox("Error al actualizar el DataGridView: " & ex.Message)
        End Try

    End Sub
    Private Sub GenerarTicket(productos As List(Of Tuple(Of String, Integer, String)), fecha As String, nombreImpresora As String)
        Dim doc As New PrintDocument()
        ' Configura la impresora
        doc.PrinterSettings.PrinterName = nombreImpresora
        If Not doc.PrinterSettings.IsValid Then
            MessageBox.Show("La impresora no es válida o no está disponible.")
            Return
        End If

        ' Agregar el evento de impresión
        AddHandler doc.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                      Dim y As Integer = 20
                                      Dim desplazamientoX As Integer = 10 ' Desplazamiento en el eje X
                                      Dim total As Decimal = 0

                                      Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
                                      Dim fontRegular As New Font("Courier New", 8)
                                      Dim fontBold As New Font("Courier New", 8, FontStyle.Bold)

                                      ' Encabezado del ticket
                                      e.Graphics.DrawString("Ticket de Compra", fontHeader, Brushes.Black, 50 + desplazamientoX, y)
                                      y += 40
                                      e.Graphics.DrawString($"Fecha: {fecha}", fontRegular, Brushes.Black, 15 + desplazamientoX, y)
                                      y += 40

                                      ' Encabezados de las columnas
                                      e.Graphics.DrawString("Producto".PadRight(15), fontBold, Brushes.Black, 15 + desplazamientoX, y)
                                      e.Graphics.DrawString("Cant".PadLeft(5), fontBold, Brushes.Black, 155 + desplazamientoX, y)
                                      e.Graphics.DrawString("Subtotal".PadLeft(12), fontBold, Brushes.Black, 195 + desplazamientoX, y)
                                      y += 20

                                      ' Imprimir los productos
                                      For Each producto In productos
                                          Dim nombre As String = producto.Item1
                                          Dim cantidad As Integer = producto.Item2
                                          Dim subtotal As String = producto.Item3
                                          total += subtotal

                                          ' Formato cada fila
                                          e.Graphics.DrawString(nombre.PadRight(15), fontRegular, Brushes.Black, 20 + desplazamientoX, y)
                                          e.Graphics.DrawString(cantidad.ToString().PadLeft(5), fontRegular, Brushes.Black, 150 + desplazamientoX, y)
                                          e.Graphics.DrawString(subtotal.PadLeft(10), fontRegular, Brushes.Black, 200 + desplazamientoX, y)

                                          y += 20
                                      Next

                                      ' Espacio antes del total
                                      y += 20
                                      e.Graphics.DrawString($"Total: $ {total:F2}", fontBold, Brushes.Black, 20 + desplazamientoX, y)
                                      y += 30
                                      e.Graphics.DrawString("Gracias por su compra!", fontRegular, Brushes.Black, 20 + desplazamientoX, y)
                                  End Sub

        Try
            ' Realiza la impresión
            doc.Print()
        Catch ex As Exception
            MessageBox.Show("Error al intentar imprimir: " & ex.Message)
        End Try
    End Sub
    Private Sub BtImprimir_Click(sender As Object, e As EventArgs) Handles BtImprimir.Click
        Dim TotalDia As Decimal = 0
        Dim fecha As String = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        Dim nombreImpresora As String = "POS-80C"
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")

        If String.IsNullOrWhiteSpace(TbTOTAL.Text) OrElse TbTOTAL.Text = "0" Then
            MessageBox.Show("El total es 0. No se puede procesar el pedido.", "Total inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            TotalDia += GRIAN

            Dim insertarMontoQuery As String = "INSERT INTO monto (montofinal, fecha) VALUES (@monto, @fecha)"
            Dim cmdInsertarMonto As New MySqlCommand(insertarMontoQuery, conn)
            cmdInsertarMonto.Parameters.AddWithValue("@monto", GRIAN)
            cmdInsertarMonto.Parameters.AddWithValue("@fecha", fecha)
            cmdInsertarMonto.ExecuteNonQuery()

            Dim queryPedido As String = "SELECT nombre, cant, subtotal FROM pedido"
            Dim cmdPedido As New MySqlCommand(queryPedido, conn)
            Dim readerPedido As MySqlDataReader = cmdPedido.ExecuteReader()

            Dim productosVendidos As New List(Of Tuple(Of String, Integer, String))
            While readerPedido.Read()
                Dim nombreProducto As String = readerPedido("nombre").ToString()
                Dim cantidadVendida As Integer = Convert.ToInt32(readerPedido("cant"))
                Dim subtotal As String = readerPedido("subtotal").ToString()
                productosVendidos.Add(Tuple.Create(nombreProducto, cantidadVendida, subtotal))
            End While
            readerPedido.Close()

            For Each producto In productosVendidos
                Dim nombreProducto As String = producto.Item1
                Dim cantidadVendida As Integer = producto.Item2

                Dim queryStock As String = "SELECT stock FROM productos WHERE nombre = @nombre"
                Dim cmdStock As New MySqlCommand(queryStock, conn)
                cmdStock.Parameters.AddWithValue("@nombre", nombreProducto)
                Dim stockActual As Integer = Convert.ToInt32(cmdStock.ExecuteScalar())

                Dim nuevoStock As Integer = stockActual - cantidadVendida
                Dim actualizarStockQuery As String = "UPDATE productos SET stock = @nuevoStock WHERE nombre = @nombre"
                Dim actualizarCmd As New MySqlCommand(actualizarStockQuery, conn)
                actualizarCmd.Parameters.AddWithValue("@nuevoStock", nuevoStock)
                actualizarCmd.Parameters.AddWithValue("@nombre", nombreProducto)
                actualizarCmd.ExecuteNonQuery()

                Dim queryExistente As String = "SELECT cantidad_total FROM productos_vendidos WHERE nombre = @nombre"
                Dim cmdExistente As New MySqlCommand(queryExistente, conn)
                cmdExistente.Parameters.AddWithValue("@nombre", nombreProducto)
                Dim cantidadTotalActual As Object = cmdExistente.ExecuteScalar()

                If cantidadTotalActual IsNot Nothing Then
                    Dim nuevaCantidad As Integer = Convert.ToInt32(cantidadTotalActual) + cantidadVendida
                    Dim queryActualizar As String = "UPDATE productos_vendidos SET cantidad_total = @nuevaCantidad WHERE nombre = @nombre"
                    Dim cmdActualizar As New MySqlCommand(queryActualizar, conn)
                    cmdActualizar.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad)
                    cmdActualizar.Parameters.AddWithValue("@nombre", nombreProducto)
                    cmdActualizar.ExecuteNonQuery()
                Else
                    Dim queryInsertar As String = "INSERT INTO productos_vendidos (nombre, cantidad_total) VALUES (@nombre, @cantidad)"
                    Dim cmdInsertar As New MySqlCommand(queryInsertar, conn)
                    cmdInsertar.Parameters.AddWithValue("@nombre", nombreProducto)
                    cmdInsertar.Parameters.AddWithValue("@cantidad", cantidadVendida)
                    cmdInsertar.ExecuteNonQuery()
                End If

                Dim insertarVentaQuery As String = "INSERT INTO historial (nombre, cant, fecha) VALUES (@nombre, @cantidad, @fecha)"
                Dim insertarCmd As New MySqlCommand(insertarVentaQuery, conn)
                insertarCmd.Parameters.AddWithValue("@nombre", nombreProducto)
                insertarCmd.Parameters.AddWithValue("@cantidad", cantidadVendida)
                insertarCmd.Parameters.AddWithValue("@fecha", fecha)
                insertarCmd.ExecuteNonQuery()
            Next
            ' Generar el ticket
            GenerarTicket(productosVendidos, fecha, nombreImpresora)

            Dim queryDelete As String = "DELETE FROM pedido"
            Dim cmdDelete As New MySqlCommand(queryDelete, conn)
            cmdDelete.ExecuteNonQuery()

            GRIAN = 0
            TbTOTAL.Text = "0"
            TbImporte.Text = ""
            TbVuelto.Text = ""

            dt.Clear()
            Using adaptador As New MySqlDataAdapter("SELECT nombre, cant FROM pedido", conn)
                adaptador.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el stock o procesar el pedido: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ObtenerMontoTotal()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim query As String = "SELECT SUM(montofinal) FROM monto"
            Dim cmd As New MySqlCommand(query, conn)
            Dim total As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error al obtener el monto total: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub TbSubTotal_TextChanged(sender As Object, e As EventArgs) Handles TbSubTotal.TextChanged
        RecalcularSubtotal()
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        LimpiarTablaPedido()
        Me.Close()
        Menu.Show()

    End Sub

    Private Sub TbImporte_TextChanged(sender As Object, e As EventArgs) Handles TbImporte.TextChanged
        Dim A As Integer = Convert.ToInt32(TbTOTAL.Text)
        Dim B As Integer
        If String.IsNullOrWhiteSpace(TbImporte.Text) Then
            B = 0
        Else
            B = Convert.ToInt32(TbImporte.Text)
        End If
        TbVuelto.Text = (B - A)
    End Sub

    Private Sub BtVaciar_Click(sender As Object, e As EventArgs) Handles BtVaciar.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")

        Try
            conn.Open()
            Dim queryDelete As String = "DELETE FROM pedido"
            Dim cmdDelete As New MySqlCommand(queryDelete, conn)
            cmdDelete.ExecuteNonQuery()
            dt.Clear()
            Using adaptador As New MySqlDataAdapter("SELECT nombre, cant FROM pedido", conn)
                adaptador.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            GRIAN = 0
            TbTOTAL.Text = "0"
            TbImporte.Text = ""
            TbVuelto.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error al intentar limpiar el pedido: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class