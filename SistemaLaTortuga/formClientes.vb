Public Class formClientes

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formNuevaProvincia.Show()
    End Sub

    Private Sub bNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles bNuevaLocalidad.Click
        dgLocalidades.Show()
    End Sub
End Class