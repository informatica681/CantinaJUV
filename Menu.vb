Imports MySql.Data.MySqlClient

Public Class Menu
    Private Sub BtProductos_Click(sender As Object, e As EventArgs) Handles BtProductos.Click
        Productos.Show()
    End Sub

    Private Sub BtResumen_Click(sender As Object, e As EventArgs) Handles BtResumen.Click
        CAJA.Show()
    End Sub

    Private Sub PRUEBA_Click(sender As Object, e As EventArgs) Handles PRUEBA.Click
        PRUEBACAJA.Show()
    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
End Class