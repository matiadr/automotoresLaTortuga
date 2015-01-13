Imports System.Data.SqlClient
Public Class formABMLocalidad

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbLocalidad_TextChanged(sender As Object, e As EventArgs) Handles tbLocalidad.TextChanged
        If tbLocalidad.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub cargarDGLocalidades()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select l.IdLocalidad,p.IdProvincia,NombreLocalidad,NombreProvincia,CodigoPostal from Localidades l,Provincias p where l.IdProvincia=p.IdProvincia order by NombreLocalidad,NombreProvincia", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgLocalidades.DataSource = dt
        CN.Close()
    End Sub

    Private Sub cargarCBProvincias()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Provincias order by NombreProvincia", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        cbProvincia.DataSource = ds
        cbProvincia.ValueMember = "IdProvincia"
        cbProvincia.DisplayMember = "NombreProvincia"
    End Sub

    Private Sub formABMLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGLocalidades()
        cargarCBProvincias()
    End Sub

    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        tbIdProvincia.Text = cbProvincia.SelectedValue.ToString
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Localidades (NombreLocalidad,IdProvincia,CodigoPostal) values ('" & tbLocalidad.Text & "','" & tbIdProvincia.Text & "','" & tbCodPostal.Text & "')", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Localidad Agregada")
        cargarDGLocalidades()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbLocalidad.Text = ""
        formClientes.cargarCBLocalidades(formClientes.tbIdProvincia.Text)
    End Sub

    Private Sub dgLocalidades_Click(sender As Object, e As EventArgs) Handles dgLocalidades.Click, dgLocalidades.KeyDown, dgLocalidades.KeyUp
        If dgLocalidades.RowCount > 0 Then
            tbLocalidad.Text = dgLocalidades.Item("localidad", dgLocalidades.SelectedRows(0).Index).Value()
            tbCodPostal.Text = dgLocalidades.Item("codPostal", dgLocalidades.SelectedRows(0).Index).Value()
            tbIdProvincia.Text = dgLocalidades.Item("idProvincia", dgLocalidades.SelectedRows(0).Index).Value()
            cbProvincia.SelectedValue = tbIdProvincia.Text
            tbIdLocalidad.Text = dgLocalidades.Item("idLocalidad", dgLocalidades.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Localidades set NombreLocalidad='" & tbLocalidad.Text & "',CodigoPostal='" & tbCodPostal.Text & "', IdProvincia='" & tbIdProvincia.Text & "' where IdLocalidad= '" & tbIdLocalidad.Text & "'", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Modificacion Efectuada")
        CN.Close()
        cargarDGLocalidades()
        bModificar.Enabled = False
        tbLocalidad.Text = ""
        tbIdLocalidad.Text = ""
        formClientes.cargarCBLocalidades(formClientes.tbIdProvincia.Text)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Localidades where IdLocalidad ='" & tbIdLocalidad.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGLocalidades()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbLocalidad.Text = ""
                tbIdLocalidad.Text = ""
                formClientes.cargarCBLocalidades(formClientes.tbIdProvincia.Text)
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicha localidad esta siendo usada", "Advertencia")
        End Try
    End Sub
End Class