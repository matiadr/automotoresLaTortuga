Imports System.Data.SqlClient
Public Class formConsultaVehiculos

    Private Sub formConsultaVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGVehiculos()
    End Sub

    Private Sub cargarDGVehiculos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Activo' order by NombreC", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgStockVehiculos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs)
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String
        If (rbEnStock.Checked) Then
            seleccion = "select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Activo' and ( NombreC like '" & tbBusqueda.Text & "%' or NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%') order by NombreC"
        Else
            seleccion = "select Max(FechaHasta),NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Pasivo' and Not Exists (select * from VehiculosxClientes vc1 where vc.IdVehiculo=vc1.IdVehiculo and Estado='Activo') and ( NombreC like '" & tbBusqueda.Text & "%' or NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%') group by NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto order by NombreC"
        End If
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgStockVehiculos.DataSource = tabla2
        miConexion.Close()
    End Sub

    Private Sub rbVendidos_CheckedChanged(sender As Object, e As EventArgs)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        If (rbEnStock.Checked) Then
            Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Activo' order by NombreC", CN)
            Dim lista As SqlDataReader = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(lista)
            dgStockVehiculos.DataSource = dt
        Else
            Dim cmd As New SqlCommand("select Max(FechaHasta),NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Pasivo' and Not Exists (select * from VehiculosxClientes vc1 where vc.IdVehiculo=vc1.IdVehiculo and Estado='Activo') group by NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto order by NombreC", CN)
            Dim lista As SqlDataReader = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(lista)
            dgStockVehiculos.DataSource = dt
        End If
        CN.Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub rbEnStock_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnStock.CheckedChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Activo' order by NombreC", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgStockVehiculos.DataSource = dt
        CN.Close()

    End Sub

    Private Sub tbBusqueda_TextChanged_1(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        If rbEnStock.Checked = True Then


            Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Activo' and (NombreC like '" & tbBusqueda.Text & "%' or nombremarca like '" & tbBusqueda.Text & "%' )  order by NombreC", CN)
            Dim lista As SqlDataReader = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(lista)
            dgStockVehiculos.DataSource = dt
            CN.Close()


        Else ' consulto los vendidos, que aca van a apareces mas de de uno, porque fueron vendidos mas de una vez...se lo vendieron a un cliente
            'el cliente lo uso, al tiempo lo entrego, y ese miso vehiculo fue vendido a otra persona.
            Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Pasivo' and (NombreC like '" & tbBusqueda.Text & "%' or nombremarca like '" & tbBusqueda.Text & "%' ) order by NombreC", CN)
            Dim lista As SqlDataReader = cmd.ExecuteReader
            Dim dt As New DataTable()
            dt.Load(lista)
            dgStockVehiculos.DataSource = dt
            CN.Close()
        End If

       

    End Sub

    Private Sub rbVendidos_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbVendidos.CheckedChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()


        Dim cmd As New SqlCommand("select NombreC,NumeroDni,NombreModelo,NombreMarca,Año,Tipo,Dominio,FechaAlta,PrecioCosto from Vehiculos v,Clientes c,VehiculosxClientes vc,Marcas m,Modelos mo where vc.IdVehiculo=v.IdVehiculo and vc.IdCliente = c.IdCliente and v.IdModelo=mo.IdModelo and mo.IdMarca = m.IdMarca and vc.Estado ='Pasivo' order by NombreC", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgStockVehiculos.DataSource = dt
        CN.Close()
    End Sub
End Class