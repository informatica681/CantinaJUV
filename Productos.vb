Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X500
Imports Windows.Win32.System

Public Class Productos
    Dim conn As New MySqlConnection
    Dim dt As New DataTable
    Dim conexion As String = ("server=localhost;userid=root;password=escuela;database=cantinakarting")
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
            adaptador.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
        Menu.Hide()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Menu.Hide()
        TbNombre.Enabled = False
        TbCantidad.Enabled = False
        TbPrecioUnit.Enabled = False
        BtGuardarCamb.Hide()
        BtGuardar.Hide()
        BtCancelar.Hide()
        BtNoGuardarCam.Hide()
        LoadComboBox()
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub
    Private Sub LimpiarTextBox()
        TbNombre.Clear()
        TbCantidad.Clear()
        TbPrecioUnit.Clear()

    End Sub
    Private Sub HabilitarTextBox()
        TbCantidad.Enabled = True
        TbPrecioUnit.Enabled = True

    End Sub
    Private Sub DeshabilitarTextBox()
        TbNombre.Enabled = False
        TbCantidad.Enabled = False
        TbPrecioUnit.Enabled = False
    End Sub

    Private Sub HabilitarBotonesAME()
        BtAgregar.Enabled = True
        BtEliminar.Enabled = True
        BtModificar.Enabled = True
    End Sub
    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Close()
        Menu.Show()
    End Sub


    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        BtGuardar.Show()
        BtCancelar.Show()
        HabilitarTextBox()
        TbNombre.Show()
        LbNom.Show()
        LimpiarTextBox()
        TbNombre.Enabled = True
        ComboBox1.Enabled = False
        BtAgregar.Enabled = False
        BtModificar.Enabled = False
        BtEliminar.Enabled = False
    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            If String.IsNullOrWhiteSpace(TbCantidad.Text) Or String.IsNullOrWhiteSpace(TbPrecioUnit.Text) Or String.IsNullOrWhiteSpace(TbNombre.Text) Then
                MsgBox("Error: No se pueden dejar campos vacios")
            Else
                Dim cant As Integer = Convert.ToInt32(TbCantidad.Text)
                If cant = 0 Then
                    MsgBox("Error: Stock no puede ser 0")
                Else
                    conn.Open()
                    Dim query As String = "INSERT INTO productos (nombre, stock, precio_unitario) VALUES (@nombre, @stock, @precio_unitario)"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", TbNombre.Text)
                    cmd.Parameters.AddWithValue("@stock", TbCantidad.Text)
                    cmd.Parameters.AddWithValue("@precio_unitario", TbPrecioUnit.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto agregado correctamente")
                    Dim dt As New DataTable
                    Using adaptador As New MySqlDataAdapter("SELECT nombre, stock, precio_unitario FROM productos", conn)
                        adaptador.Fill(dt)
                    End Using
                    DataGridView1.DataSource = dt
                    For Each col As DataGridViewColumn In DataGridView1.Columns
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    Next
                    LimpiarTextBox()
                    DeshabilitarTextBox()
                    BtCancelar.Hide()
                    BtGuardar.Hide()
                    ComboBox1.Enabled = True
                    HabilitarBotonesAME()
                    LoadComboBox()
                    If ComboBox1.Items.Count > 0 Then
                        ComboBox1.SelectedIndex = 0
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        LimpiarTextBox()
        DeshabilitarTextBox()
        BtGuardar.Hide()
        BtCancelar.Hide()
        ComboBox1.Enabled = True
        HabilitarBotonesAME()

    End Sub

    Private Sub BtModificar_Click(sender As Object, e As EventArgs) Handles BtModificar.Click
        BtAgregar.Enabled = False
        BtEliminar.Enabled = False
        BtModificar.Enabled = False
        BtGuardarCamb.Show()
        BtNoGuardarCam.Show()
        HabilitarTextBox()

    End Sub
    Private Sub BtGuardarCamb_Click(sender As Object, e As EventArgs) Handles BtGuardarCamb.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim selectedProduct As String = ComboBox1.SelectedItem.ToString()
            Dim query As String = "UPDATE productos SET stock = @stock, precio_unitario = @precio WHERE nombre = @nombre"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@stock", TbCantidad.Text)
            cmd.Parameters.AddWithValue("@precio", TbPrecioUnit.Text)
            cmd.Parameters.AddWithValue("@nombre", selectedProduct)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Datos actualizados correctamente.")
                For Each col As DataGridViewColumn In DataGridView1.Columns
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
                Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
                    adaptador.Fill(dt)
                End Using
                DeshabilitarTextBox()
                BtGuardarCamb.Hide()
                BtNoGuardarCam.Hide()
                HabilitarBotonesAME()
                Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
                    adaptador.Fill(dt)
                    dt.Clear()
                End Using
                For Each col As DataGridViewColumn In DataGridView1.Columns
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
                Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
                    adaptador.Fill(dt)
                End Using
            Else
                MessageBox.Show("No se encontró el producto para actualizar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub BtNoGuardarCam_Click(sender As Object, e As EventArgs) Handles BtNoGuardarCam.Click
        LimpiarTextBox()
        DeshabilitarTextBox()
        BtGuardarCamb.Hide()
        BtNoGuardarCam.Hide()
        HabilitarBotonesAME()

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
                TbNombre.Text = reader("nombre").ToString()
                TbCantidad.Text = reader("stock").ToString()
                TbPrecioUnit.Text = reader("precio_unitario").ToString()
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

    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click
        Dim connStr As String = "server=localhost;userid=root;password=escuela;database=cantinakarting "
        Dim conn As New MySqlConnection(connStr)
        Dim consulta As String = ""
        conn.Open()
        If ComboBox1.SelectedItem Is Nothing Then
            Exit Sub
        Else
            Dim selectedProduct As String = ComboBox1.SelectedItem.ToString()
            Dim query As String = "DELETE FROM productos WHERE nombre = @nombre"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nombre", selectedProduct)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            MessageBox.Show("Producto eliminado correctamente")
            LimpiarTextBox()
            HabilitarBotonesAME()
            Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
                adaptador.Fill(dt)
                dt.Clear()
            End Using
            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            Using adaptador As New MySqlDataAdapter("Select nombre, stock, precio_unitario From productos", conexion)
                adaptador.Fill(dt)
            End Using
            LoadComboBox()
            If ComboBox1.Items.Count > 0 Then
                ComboBox1.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub TbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TbCantidad.Focus()
        End If
    End Sub

    Private Sub TbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TbPrecioUnit.Focus()
        End If
    End Sub

    Private Sub TbPrecioUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrecioUnit.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TbNombre.Focus()
        End If
    End Sub
End Class