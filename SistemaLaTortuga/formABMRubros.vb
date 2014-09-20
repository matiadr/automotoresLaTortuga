Imports System.Data.SqlClient
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

    Private Sub formABMRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGRubros()
    End Sub


    Private Sub cargarDGRubros()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Rubros order by NombreRubro", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgRubro.DataSource = dt
        CN.Close()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Rubros values ('" & tbRubro.Text & "')", CN)
            cmd.ExecuteNonQuery()
            CN.Close()
            MessageBox.Show("Rubro Agregado")
            cargarDGRubros()
            bNuevo.Enabled = False
            bModificar.Enabled = False
            tbRubro.Text = ""
            formCuentas.cargarCBRubros()
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos, intente mas tarde")
        End Try

    End Sub

    Private Sub dgRubro_Click(sender As Object, e As EventArgs) Handles dgRubro.Click, dgRubro.KeyDown, dgRubro.KeyUp
        If dgRubro.RowCount > 0 Then
            tbRubro.Text = dgRubro.Item("rubro", dgRubro.SelectedRows(0).Index).Value()
            tbIdRubro.Text = dgRubro.Item("idRubro", dgRubro.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
        End If
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("update Rubros set NombreRubro='" & tbRubro.Text & "' where IdRubro = '" & tbIdRubro.Text & "'", CN)
            cmd.ExecuteNonQuery()
            CN.Close()
            MessageBox.Show("Modificacion Efectuada")
            cargarDGRubros()
            bModificar.Enabled = False
            tbRubro.Text = ""
            tbIdRubro.Text = ""
            formCuentas.cargarCBRubros()
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la actualizacion, intente mas tarde")
        End Try
    End Sub
End Class