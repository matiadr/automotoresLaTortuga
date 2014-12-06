
Public Class formPrincipal

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        formClientes.Show()
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosToolStripMenuItem.Click
        formVehiculos.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formCuentas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MarcasVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasVehículosToolStripMenuItem.Click
        formABMMarca.Show()
    End Sub

    Private Sub ModelosVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelosVehículosToolStripMenuItem.Click
        formABMModelos.Show()
    End Sub

    Private Sub ProvinciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvinciasToolStripMenuItem.Click
        formABMProvincia.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        formABMLocalidad.Show()
    End Sub


    Private Sub RubrosCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubrosCuentasToolStripMenuItem.Click
        formABMRubros.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        formABMBancos.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem1.Click
        formCuentas.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        formABMSucursales.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        formVentas.Show()
        formVentas.GroupBox3.Enabled = False
        formVentas.GroupBox4.Enabled = False
    End Sub

   

End Class

