Public Class formNuevaProvincia

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbProvincia_TextChanged(sender As Object, e As EventArgs) Handles tbProvincia.TextChanged
        If tbProvincia.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class