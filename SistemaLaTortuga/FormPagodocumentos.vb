Imports System.Data.SqlClient
Public Class FormPagoDocumentos
    Public Sub CargarClientes()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Clientes order by NombreC", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        ComboCliente.DataSource = ds
        ComboCliente.ValueMember = "IdClient"
        ComboCliente.DisplayMember = "NombreC"
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim cmd As New SqlCommand("select IdDocumento,FechaDocumento as Fecha, ImporteDocumento as Importe, NombreMarca as Marca,NombreModelo as Modelo, Dominio From Documentos d, Ventas v, Vehiculos ve,Modelos mo, Marcas ma where d.idventa = v.idventa and idcomprador = '" & ComboCliente.SelectedValue & "' and Pagado = 'No' and v.IdVehiculoVenta = ve.IdVehiculo and Mo.IdMarca = Ma.idMarca and ve.idModelo = Mo.IdModelo Order By IdDocumento asc ", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGdocumentos.DataSource = dt

        CN.Close()
    End Sub

    Private Sub textid_TextChanged(sender As Object, e As EventArgs) Handles textid.TextChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim doc As Integer
        doc = Conversion.Int(textid.Text)

        Dim cmd As New SqlCommand("select IdDocumento,FechaPago, ImportePago, FormaPago, NumeroTransaccion,NombreSucursal,NombreBanco From PagosDocumentos, Sucursales, Bancos where IdDocumento = '" & doc & "' and Sucursales.idbanco = Bancos.IdBanco and PagosDocumentos.IdSucursal = Sucursales.IdSucursal ", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGpagos.DataSource = dt


        CN.Close()
    End Sub

    Private Sub DGdocumentos_DoubleClick(sender As Object, e As EventArgs) Handles DGdocumentos.DoubleClick
        If DGdocumentos.RowCount > 0 Then
            textid.Text = DGdocumentos.Item("IdDocumento", DGdocumentos.SelectedRows(0).Index).Value()
            FormPagarDocumento.Show()
        End If
    End Sub

    Private Sub DGdocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdocumentos.CellContentClick

    End Sub
End Class