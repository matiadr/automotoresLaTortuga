Imports System.Data.SqlClient
Public Class formbuscavehiculoactivo

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim seleccion As String = "select vc.IdVehiculo,IdVxC,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma, VehiculosxClientes vc where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.idvehiculo = vc.idvehiculo and (NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%' or Dominio like '" & tbBusqueda.Text & "%') and Estado = 'Activo' order by NombreMarca,NombreModelo"

        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgVehiculos.DataSource = tabla2
    End Sub

    Private Sub formbuscavehiculoactivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'muestra todos los vehiculos activos de VEHICULOSXCLIENTES
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim seleccion As String = "select vc.IdVehiculo,IdVxC,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma, VehiculosxClientes vc where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.idvehiculo = vc.idvehiculo and Estado = 'Activo' order by NombreMarca,NombreModelo"

        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgVehiculos.DataSource = tabla2


    End Sub

  

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub tbBusqueda_TextChanged_1(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim seleccion As String = "select vc.IdVehiculo,IdVxC,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma, VehiculosxClientes vc where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.idvehiculo = vc.idvehiculo and Estado = 'Activo' and (dominio like '" & tbBusqueda.Text & "%' or NombreMarca like '" & tbBusqueda.Text & "%') order by NombreMarca,NombreModelo"

        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgVehiculos.DataSource = tabla2
    End Sub


    Private Sub dgVehiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVehiculos.CellContentClick

    End Sub
End Class