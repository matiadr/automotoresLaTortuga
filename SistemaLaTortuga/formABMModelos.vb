Imports System.Data.SqlClient
Public Class formABMModelos

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbModelo_TextChanged(sender As Object, e As EventArgs)
        If tbModelo.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub formABMModelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGModelos()
        cargarCBMarca()
    End Sub

    Private Sub cargarDGModelos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select m.IdMarca,IdModelo,NombreMarca,NombreModelo from Modelos m,Marcas ma where m.IdMarca = ma.IdMarca order by NombreModelo,NombreMarca", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgModelos.DataSource = dt
        CN.Close()
    End Sub


    Private Sub dgModelos_Click(sender As Object, e As EventArgs) Handles dgModelos.Click, dgModelos.KeyPress
        If dgModelos.RowCount > 0 Then
            tbIdMarca.Text = dgModelos.Item("idMarca", dgModelos.SelectedRows(0).Index).Value()
            tbIdModelo.Text = dgModelos.Item("idModelo", dgModelos.SelectedRows(0).Index).Value()
            tbModelo.Text = dgModelos.Item("modelo", dgModelos.SelectedRows(0).Index).Value()
            cbMarca.SelectedValue = tbIdMarca.Text
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Modelos (IdMarca,NombreModelo) values ('" & tbIdMarca.Text & "','" & tbModelo.Text & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modelo Agregado")
        cargarDGModelos()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbModelo.Text = ""
        CN.Close()
        formVehiculos.cargarCBModelos(formVehiculos.tbIdMarca.Text)
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Modelos set NombreModelo='" & tbModelo.Text & "',IdMarca='" & tbIdMarca.Text & "' where IdModelo= '" & tbIdModelo.Text & "'", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modificacion Efectuada")
        CN.Close()
        cargarDGModelos()
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbModelo.Text = ""
        tbIdModelo.Text = ""
        formVehiculos.cargarCBModelos(formVehiculos.tbIdMarca.Text)
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs)
        tbIdMarca.Text = cbMarca.SelectedValue.ToString
    End Sub

    Private Sub cargarCBMarca()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Marcas order by NombreMarca", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        cbMarca.DataSource = ds
        cbMarca.ValueMember = "IdMarca"
        cbMarca.DisplayMember = "NombreMarca"
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Modelos where IdModelo ='" & tbIdModelo.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGModelos()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbModelo.Text = ""
                tbIdModelo.Text = ""
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicho Modelo esta siendo usado", "Advertencia")
        End Try
    End Sub
End Class