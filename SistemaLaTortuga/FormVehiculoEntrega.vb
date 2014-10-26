Public Class formvehiculoentrega

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bVehEntrega_Click(sender As Object, e As EventArgs) Handles bVehEntrega.Click
        formBuscarVehiculo.Show()
        formBuscarVehiculo.tipoBoton = 1
    End Sub
End Class