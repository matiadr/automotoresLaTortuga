Imports System.Data.SqlClient
Public Class formsucursalesbancos

    Public Sub cargarsucursales()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdSucursal,CodigoSucursal,NombreSucursal,CodigoBanco,NombreBanco from Sucursales s,Bancos B where s.idbanco = b.idbanco order by NombreBanco,nombresucursal", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgsucursalesb.DataSource = dt
        CN.Close()
    End Sub
    Private Sub formsucursalesbancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarsucursales()
    End Sub

    Private Sub dgsucursalesb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgsucursalesb_DoubleClick(sender As Object, e As EventArgs)

        formCheques.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
        formCheques.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
        formCheques.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
        formCheques.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
        formCheques.textids.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
        formVehiculos.Button2.Enabled = True


        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub bNuevoCliente_Click(sender As Object, e As EventArgs)

    End Sub
End Class