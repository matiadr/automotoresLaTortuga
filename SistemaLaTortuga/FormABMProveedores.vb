Imports System.Data.SqlClient
Public Class FormABMProveedores

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Proveedores values ('" & tbProveedor.Text & "','" & tbDomicilio.Text & "', '" & tbTelefono.Text & "')", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Proveedor Agregado")
        cargarDGProveedores()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbProveedor.Text = ""
        tbDomicilio.Text = ""
        tbTelefono.Text = ""
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Proveedores set NombreProveedor='" & tbProveedor.Text & "', DomicilioProveedor = '" & tbDomicilio.Text & "', TelefonoProveedor = '" & tbTelefono.Text & "' where IdProveedor = '" & tbIdProveedor.Text & "'", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Modificacion Efectuada")
        cargarDGProveedores()
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbProveedor.Text = ""
        tbIdProveedor.Text = ""
        tbDomicilio.Text = ""
        tbTelefono.Text = ""
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Proveedores where IdProveedor ='" & tbIdProveedor.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGProveedores()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbProveedor.Text = ""
                tbIdProveedor.Text = ""
                tbDomicilio.Text = ""
                tbTelefono.Text = ""
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicho proveedor esta siendo usado", "Advertencia")
        End Try
    End Sub


    Private Sub dgProveedores_Click(sender As Object, e As EventArgs) Handles dgProveedores.Click
        If dgProveedores.RowCount > 0 Then
            tbProveedor.Text = dgProveedores.Item("nombre", dgProveedores.SelectedRows(0).Index).Value()
            tbIdProveedor.Text = dgProveedores.Item("idProveedor", dgProveedores.SelectedRows(0).Index).Value()
            tbDomicilio.Text = dgProveedores.Item("domicilio", dgProveedores.SelectedRows(0).Index).Value()
            tbTelefono.Text = dgProveedores.Item("telefono", dgProveedores.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub FormABMProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGProveedores()
    End Sub

    Private Sub cargarDGProveedores()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Proveedores order by NombreProveedor", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgProveedores.DataSource = dt
        CN.Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbProveedor_TextChanged(sender As Object, e As EventArgs) Handles tbProveedor.TextChanged
        If tbProveedor.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class