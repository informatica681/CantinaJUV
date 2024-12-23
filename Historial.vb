Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Resources
Public Class Historial
    Dim conn As New MySqlConnection
    Dim dt As New DataTable
    Dim conexion As String = ("server=localhost;userid=root;password=escuela;database=cantinakarting")
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LoadComboBox()
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 18)
    End Sub

    Private Sub LoadComboBox()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        Try
            conn.Open()
            Dim query As String = "SELECT DISTINCT fecha FROM historial" ' 
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While reader.Read()
                ComboBox1.Items.Add(reader("fecha").ToString())
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
        Dim fechaSeleccionada As String = ComboBox1.SelectedItem.ToString()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
        If ComboBox1.SelectedItem Is Nothing Then

            Exit Sub
        End If
        Try
            conn.Open()
            Dim query As String = "SELECT nombre, cant FROM historial WHERE fecha = @fecha"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        CAJA.Show()
        Close()
    End Sub

    Private Sub BtReiniciarHisto_Click(sender As Object, e As EventArgs) Handles BtReiniciarHisto.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que quieres borrar el historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Try
                Dim conn As New MySqlConnection("server=localhost;userid=root;password=escuela;database=cantinakarting")
                conn.Open()
                Dim queryDelete As String = "DELETE FROM historial"
                Dim cmdDelete As New MySqlCommand(queryDelete, conn)
                cmdDelete.ExecuteNonQuery()
                MessageBox.Show("Historial borrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadComboBox()
                If ComboBox1.Items.Count > 0 Then
                    ComboBox1.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error al borrar el historial: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub
End Class