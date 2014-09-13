Public Class formABMModelos

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbModelo_TextChanged(sender As Object, e As EventArgs) Handles tbModelo.TextChanged
        If tbModelo.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class