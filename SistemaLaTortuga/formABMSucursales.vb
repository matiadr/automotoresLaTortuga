Imports System.Data.SqlClient
Public Class formABMSucursales

    Private Sub formABMSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGSucursales()
        cargarCBBancos()
    End Sub

    Private Sub cargarDGSucursales()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select b.IdBanco,IdSucursal,NombreSucursal,NombreBanco,CodigoSucursal,CodigoBanco from Bancos b,Sucursales s where s.IdBanco = b.IdBanco order by NombreSucursal,NombreBanco", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgModelos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub cargarCBBancos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Bancos order by NombreBanco", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        cbBancos.DataSource = ds.Tables(0)
        cbBancos.ValueMember = "IdBanco"
        cbBancos.DisplayMember = "NombreBanco"
    End Sub

    Private Sub tbSucursal_TextChanged(sender As Object, e As EventArgs) Handles tbSucursal.TextChanged
        If tbSucursal.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub cbBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedIndexChanged
        tbIdBanco.Text = cbBancos.SelectedValue.ToString
    End Sub

    Private Sub dgModelos_Click(sender As Object, e As EventArgs) Handles dgModelos.Click, dgModelos.KeyDown, dgModelos.KeyUp
        If dgModelos.RowCount > 0 Then
            tbSucursal.Text = dgModelos.Item("sucursal", dgModelos.SelectedRows(0).Index).Value()
            tbCodigoSucursal.Text = dgModelos.Item("codigoSucursal", dgModelos.SelectedRows(0).Index).Value()
            tbIdSucursal.Text = dgModelos.Item("idSucursal", dgModelos.SelectedRows(0).Index).Value()
            cbBancos.SelectedValue = dgModelos.Item("idBanco", dgModelos.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Sucursales (NombreSucursal,CodigoSucursal,IdBanco) values ('" & tbSucursal.Text & "','" & tbCodigoSucursal.Text & "','" & tbIdBanco.Text & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Sucursal Agregada")
        CN.Close()
        cargarDGSucursales()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        LimpiarPantalla()
    End Sub

    Private Sub LimpiarPantalla()
        tbSucursal.Text = ""
        tbIdSucursal.Text = ""
        tbCodigoSucursal.Text = ""
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarPantalla()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Sucursales set NombreSucursal='" & tbSucursal.Text & "',IdBanco='" & tbIdBanco.Text & "',CodigoSucursal= '" & tbCodigoSucursal.Text & "' where IdSucursal= '" & tbIdSucursal.Text & "'", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modificacion Efectuada")
        CN.Close()
        cargarDGSucursales()
        bModificar.Enabled = False
        bEliminar.Enabled = False
        LimpiarPantalla()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Sucursales where IdSucursal ='" & tbIdSucursal.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGSucursales()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbSucursal.Text = ""
                tbIdSucursal.Text = ""
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicha sucursal esta siendo usada", "Advertencia")
        End Try
    End Sub
End Class