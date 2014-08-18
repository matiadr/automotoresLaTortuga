Public Class formVehiculos



    Private Sub b_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevaMarca_Click(sender As Object, e As EventArgs) Handles bNuevaMarca.Click
        formNuevaMarca.Show()
    End Sub

    Private Sub bNuevoModelo_Click(sender As Object, e As EventArgs) Handles bNuevoModelo.Click
        formNuevoModelo.Show()
    End Sub
End Class