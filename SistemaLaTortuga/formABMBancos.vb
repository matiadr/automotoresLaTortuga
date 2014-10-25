Imports System.Data.SqlClient
Public Class formABMBancos

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tbBanco_TextChanged(sender As Object, e As EventArgs) Handles tbBanco.TextChanged
        If tbBanco.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
            bModificar.Enabled = False
        End If
    End Sub


    Private Sub cargarDGBancos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Bancos order by NombreBanco", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgBancos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Bancos values ('" & tbCodigo.Text & "','" & tbBanco.Text & "')", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Banco Agregado")
        cargarDGBancos()
        bNuevo.Enabled = False
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbBanco.Text = ""
        tbCodigo.Text = ""
    End Sub


    Private Sub dgBancos_Click(sender As Object, e As EventArgs) Handles dgBancos.Click, dgBancos.KeyUp
        If dgBancos.RowCount > 0 Then
            tbBanco.Text = dgBancos.Item("banco", dgBancos.SelectedRows(0).Index).Value()
            tbIdBanco.Text = dgBancos.Item("idBanco", dgBancos.SelectedRows(0).Index).Value()
            tbCodigo.Text = dgBancos.Item("codigoBanco", dgBancos.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("update Bancos set NombreBanco='" & tbBanco.Text & "',CodigoBanco='" & tbCodigo.Text & "' where IdBanco = '" & tbIdBanco.Text & "'", CN)
        cmd.ExecuteNonQuery()
        CN.Close()
        MessageBox.Show("Modificacion Efectuada")
        cargarDGBancos()
        bModificar.Enabled = False
        bEliminar.Enabled = False
        tbBanco.Text = ""
        tbIdBanco.Text = ""
        tbCodigo.Text = ""
    End Sub

    Private Sub formABMBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGBancos()
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Bancos where IdBanco ='" & tbIdBanco.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGBancos()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                tbBanco.Text = ""
                tbIdBanco.Text = ""
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicho banco esta siendo usado", "Advertencia")
        End Try
    End Sub
End Class