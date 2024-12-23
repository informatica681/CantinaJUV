Imports System.Diagnostics.Eventing.Reader
Imports System.Resources
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class CAJA
    Dim conn As New MySqlConnection
    Dim dt As New DataTable
    Dim conexion As String = ("server=localhost;userid=root;password=escuela;database=cantinakarting")
    Dim Montoinicial As Decimal

    Private Sub CAJA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        ObtenerSumaMontofinal()
        Dim datos As New DataSet
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 18)
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Using adaptador As New MySqlDataAdapter("Select nombre, cantidad_total From productos_vendidos", conexion)
            adaptador.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim connectionString As String = "server=localhost;user id=root;password=escuela;database=cantinakarting"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT montoinicial FROM monto;"
                Dim command As New MySqlCommand(query, connection)
                Dim resultado As Object = command.ExecuteScalar()
                Dim total As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))
                TbMontoinicial.Text = total.ToString()
            Catch ex As Exception
                MessageBox.Show("Error al obtener la suma: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Menu.Show()
        Close()
    End Sub

    Private Sub ObtenerSumaMontofinal()
        Dim connectionString As String = "server=localhost;user id=root;password=escuela;database=cantinakarting"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT SUM(montofinal) AS Total FROM monto;"
                Dim command As New MySqlCommand(query, connection)
                Dim resultado As Object = command.ExecuteScalar()
                Dim total As Integer = If(IsDBNull(resultado), 0, Convert.ToInt32(resultado))
                TBMontoFinal.Text = total.ToString()

            Catch ex As Exception
                MessageBox.Show("Error al obtener la suma: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtHistorial_Click(sender As Object, e As EventArgs) Handles BtHistorial.Click
        Historial.Show()
        Hide()
    End Sub

    Private Sub BtReiniciar_Click(sender As Object, e As EventArgs) Handles BtReiniciar.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")

        Try
            conn.Open()
            Dim queryLimpiarProductosVendidos As String = "DELETE FROM productos_vendidos"
            Dim cmdLimpiarProductosVendidos As New MySqlCommand(queryLimpiarProductosVendidos, conn)
            cmdLimpiarProductosVendidos.ExecuteNonQuery()
            Dim queryLimpiarPedido As String = "DELETE FROM pedido"
            Dim cmdLimpiarPedido As New MySqlCommand(queryLimpiarPedido, conn)
            cmdLimpiarPedido.ExecuteNonQuery()
            Dim queryReiniciarMonto As String = "DELETE FROM monto"
            Dim cmdReiniciarMonto As New MySqlCommand(queryReiniciarMonto, conn)
            cmdReiniciarMonto.ExecuteNonQuery()
            TBMontoFinal.Text = 0
            TbMontoinicial.Text = 0
            Using adaptador As New MySqlDataAdapter("Select nombre, cantidad_total From productos_vendidos", conexion)
                adaptador.Fill(dt)
                dt.Clear()
            End Using
            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Using adaptador As New MySqlDataAdapter("Select nombre, cantidad_total From productos_vendidos", conexion)
                adaptador.Fill(dt)
            End Using
            MessageBox.Show("El listado de productos vendidos han sido limpiado.")
        Catch ex As Exception
            MessageBox.Show("Error al limpiar las tablas: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtIngresar_Click(sender As Object, e As EventArgs) Handles BtIngresar.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim cant As Integer = Convert.ToInt32(TbMontoinicial.Text)
            Dim query As String = "INSERT INTO monto (montoinicial) VALUES (@montoinicial)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@montoinicial", cant)
            cmd.ExecuteNonQuery()
            MsgBox("Monto inicial establecido correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub TbMontoinicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbMontoinicial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TBMontoFinal.Focus()
        End If
    End Sub

    Private Sub TbMontoFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBMontoFinal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TbMontoinicial.Focus()
        End If
    End Sub

End Class