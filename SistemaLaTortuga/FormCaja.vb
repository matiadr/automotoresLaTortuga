Imports System.Data.SqlClient
Public Class FormCaja





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGastosVehiculo.Show()
    End Sub

    Private Sub cargarCaja()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from MovimientosDiarios order by IdMovimientoDiario", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGcaja.DataSource = dt
        CN.Close()
    End Sub

    Private Sub FormCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcaja()
    End Sub
End Class