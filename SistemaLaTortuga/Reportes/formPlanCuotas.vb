
Imports System.Data.SqlClient
Public Class FormPlan

    Private Sub FormPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Cuotas where idplan = '" & formVentas.textidplan.Text & "' order by NumeroCuota", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGplan.DataSource = dt
        CN.Close()
    End Sub
End Class