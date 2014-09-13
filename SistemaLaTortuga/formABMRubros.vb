Public Class formABMRubros

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbRubro_TextChanged(sender As Object, e As EventArgs) Handles tbRubro.TextChanged
        If tbRubro.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class