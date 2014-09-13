Public Class formABMMarca

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbMarca_TextChanged(sender As Object, e As EventArgs) Handles tbMarca.TextChanged
        If tbMarca.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class