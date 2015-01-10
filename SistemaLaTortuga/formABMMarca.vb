Imports System.Data.SqlClient
Public Class formABMMarca

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbMarca_TextChanged(sender As Object, e As EventArgs)
        If tbMarca.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub


    Private Sub formABMMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGMarcas()
    End Sub

    Private Sub cargarDGMarcas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Marcas order by NombreMarca", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgMarcas.DataSource = dt
        CN.Close()
    End Sub


    Private Sub dgMarcas_Click(sender As Object, e As EventArgs) Handles dgMarcas.Click, dgMarcas.KeyDown, dgMarcas.KeyUp
        If dgMarcas.RowCount > 0 Then
            tbMarca.Text = dgMarcas.Item("marca", dgMarcas.SelectedRows(0).Index).Value()
            tbIdMarca.Text = dgMarcas.Item("idMarca", dgMarcas.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Marcas values ('" & tbMarca.Text & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Marca Agregada")
        cargarDGMarcas()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbMarca.Text = ""
        CN.Close()
        formVehiculos.cargarCBMarcas()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Marcas set NombreMarca='" & tbMarca.Text & "' where IdMarca= '" & tbIdMarca.Text & "'", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modificacion Efectuada")
        CN.Close()
        cargarDGMarcas()
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbMarca.Text = ""
        tbIdMarca.Text = ""
        formVehiculos.cargarCBMarcas()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Marcas where IdMarca ='" & tbIdMarca.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGMarcas()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbMarca.Text = ""
                tbIdMarca.Text = ""
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicha Marca esta siendo usada", "Advertencia")
        End Try
    End Sub
End Class