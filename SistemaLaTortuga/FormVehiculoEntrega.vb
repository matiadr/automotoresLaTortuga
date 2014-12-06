Imports System.Data.SqlClient
Public Class formvehiculoentrega



    Private Sub bVehEntrega_Click(sender As Object, e As EventArgs) Handles bVehEntrega.Click
        formBuscarVehiculo.Show()
        formBuscarVehiculo.tipoBoton = 1
    End Sub

    Private Sub BuscarAutoVenta(id As String)
        Try
            Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
            Dim miConexion As New SqlConnection(CN)
            miConexion.Open()
            Dim seleccion As String = "select NombreMarca,NombreModelo,Tipo,Dominio,Año,TipoMotor,Chasis,Motor,PrecioVenta from Vehiculos v,Marcas ma,Modelos m where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and IdVehiculo='" & id & "'"
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            tbMarcaVehEntrega.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehEntrega.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehEntrega.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehEntrega.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehEntrega.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehEntrega.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehEntrega.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehEntrega.Text = tabla2.Rows.Item(0).Item("Motor")
            'tbPrecioVentaVehentrega.Text = tabla2.Rows.Item(0).Item("PrecioVenta")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub
    Private Sub textidvehiculo_TextChanged(sender As Object, e As EventArgs) Handles textidvehiculo.TextChanged
        If textidvehiculo.Text.Length > 0 Then
            BuscarAutoVenta(textidvehiculo.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBuscarVehiculo.texttipoboton.Text = 2 'asigno el numero 2 a la variable para saber que tengo que cargar los datos en el form de entrega
        formBuscarVehiculo.Show()
    End Sub
    Public Sub cargarentregas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select v.IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio, precioe from Vehiculos v,Modelos m,Marcas ma, vehiculosentregas ve where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.idvehiculo = ve.idvehiculo and idventa = '" & formVentas.textidventa.Text & "' order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        formVentas.DGentregas.DataSource = dt
        CN.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'debo crear registro en la tabla VEHICULOSENTREGAS

        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into VehiculosEntregas values ('" & formVentas.textidventa.Text & "','" & textidvehiculo.Text & "','" & tbPrecioCostoVehEntrega.Text & "','" & textdetalle.Text & "','" & textdeuda.Text & "')", CN)
        cmd.ExecuteNonQuery()

        CN.Close()

        cargarentregas()
       
        'debeo crear registro en la tabla VEHICULOSXCLIENTES para saber quien me entrego ese vehiculo
        Dim CNN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CNN.Open()
        Dim cmde As New SqlCommand("insert into Vehiculosxclientes values ('" & textidvehiculo.Text & "','" & formVentas.tbIdCliente.Text & "','" & formVentas.dtfecha.Value & "','" & formVentas.dtfecha.Value & "','" & "Activo" & "')", CNN)
        cmde.ExecuteNonQuery()

        Dim suma As New SqlCommand("Select sum(PrecioE) from VehiculosEntregas where Idventa = '" & formVentas.textidventa.Text & "' ", CNN)

        formVentas.textsumaentregasv.Text = suma.ExecuteScalar()


        'tambien debo agregarlo a LA TABLA VEHICULOS. hay dos casos, pudo haber estado y le cambio el estado vendido a N con otros datos, o no, y tengo que agregarlo
        'en realidad cuando busco el vehiculo si no está lo voy a AGREGAR y ya queda en estado VENDIDO = S
        'por lo tanto en esta instancia siempre voy a encontrar este fehículo asi que lo que voy hacer es siempre cambiarle el estado Vendido a S 

        Dim cambiarestado As New SqlCommand("update Vehiculos set Vendido = 'S' where idvehiculo ='" & textidvehiculo.Text & "' ", CNN)
        cambiarestado.ExecuteNonQuery()






        CNN.Close()





    End Sub
End Class