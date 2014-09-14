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

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged, tbDocumento.TextChanged
        If tbNombre.Text.Length > 0 And tbDocumento.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub formClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class