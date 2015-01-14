Imports System.Data.SqlClient

Public Class FormPagoPlanes


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
    Private Sub FormPagoPlanes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()

    End Sub
    Public Sub CargarCuotas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim cmd As New SqlCommand("select idcliente,detalleplan,idcuota,NumeroCuota,FechaCuota,ImporteCuota, sum(importepago) as pago From Planes p, Cuotas c LEFT JOIN PagoCuotas pc on c.idcuota=pc.idcuotaid  where p.idplan = c.idplan and idcliente = '" & ComboCliente.SelectedValue & "' group by idcliente,detalleplan,idcuota,numerocuota,fechacuota,importecuota order by numerocuota asc", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGcuotas.DataSource = dt

        CN.Close()
    End Sub
    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        CargarCuotas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub DGcuotas_DoubleClick(sender As Object, e As EventArgs) Handles DGcuotas.DoubleClick
        FormPagoCuotas.Show()
        FormPagoCuotas.textimporte.Text = Replace(DGcuotas.Item("ImporteCuota", DGcuotas.SelectedRows(0).Index).Value(), ",", ".")
        FormPagoCuotas.textidcuota.Text = DGcuotas.Item("idcuota", DGcuotas.SelectedRows(0).Index).Value()
    End Sub

    Private Sub DGcuotas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcuotas.CellContentClick

    End Sub
End Class