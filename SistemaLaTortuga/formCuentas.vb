Public Class formCuentas

    Private Sub bNuevoRubro_Click(sender As Object, e As EventArgs) Handles bNuevoRubro.Click
        formABMRubros.Show()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

End Class