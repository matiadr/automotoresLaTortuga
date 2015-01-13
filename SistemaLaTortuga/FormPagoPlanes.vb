Imports System.Data.SqlClient

Public Class FormPagoPlanes

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
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

    Private Sub ComboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCliente.SelectedIndexChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim cmd As New SqlCommand("select NumeroCuota,FechaCuota,ImporteCuota From Cuotas c, Planes p where p.idplan = c.idplan and idcliente = '" & ComboCliente.SelectedValue & "' order by numerocuota asc", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGcuotas.DataSource = dt

        CN.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub DGcuotas_DoubleClick(sender As Object, e As EventArgs) Handles DGcuotas.DoubleClick
        FormPagoCuotas.Show()
        FormPagoCuotas.textimporte.Text = DGcuotas.Item("ImporteCuota", DGcuotas.SelectedRows(0).Index).Value()

    End Sub
End Class