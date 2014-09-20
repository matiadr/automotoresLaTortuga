Imports System.Data.SqlClient
Public Class formABMProvincia

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbProvincia_TextChanged(sender As Object, e As EventArgs) Handles tbProvincia.TextChanged
        If tbProvincia.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
            bModificar.Enabled = False
        End If
    End Sub

    Private Sub formABMProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGProvincias()
    End Sub
    Private Sub cargarDGProvincias()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Provincias order by NombreProvincia", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgProvincias.DataSource = dt
        CN.Close()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Provincias values ('" & tbProvincia.Text & "')", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Provincia Agregada")
        cargarDGProvincias()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        tbProvincia.Text = ""
        formClientes.cargarCBProvincias()
    End Sub


    Private Sub dgProvincias_Click(sender As Object, e As EventArgs) Handles dgProvincias.Click, dgProvincias.KeyUp
        If dgProvincias.RowCount > 0 Then
            tbProvincia.Text = dgProvincias.Item("provincia", dgProvincias.SelectedRows(0).Index).Value()
            tbIdProvincia.Text = dgProvincias.Item("idProvincia", dgProvincias.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
        End If     
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Provincias set NombreProvincia='" & tbProvincia.Text & "' where IdProvincia = '" & tbIdProvincia.Text & "'", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Modificacion Efectuada")
        cargarDGProvincias()
        bModificar.Enabled = False
        tbProvincia.Text = ""
        tbIdProvincia.Text = ""
        formClientes.cargarCBProvincias()
    End Sub
End Class