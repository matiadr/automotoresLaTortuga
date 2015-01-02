Imports System.Data.SqlClient
Public Class formvehiculoentrega



    Private Sub bVehEntrega_Click(sender As Object, e As EventArgs)

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
            combomarca.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            combomodelo.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            texttipoventrega.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehEntrega.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehEntrega.Text = tabla2.Rows.Item(0).Item("Año")
            combotipo.Text = tabla2.Rows.Item(0).Item("TipoMotor")
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

       


        'tambien debo agregarlo a LA TABLA VEHICULOS. hay dos casos, pudo haber estado y le cambio el estado vendido a N con otros datos, o no, y tengo que agregarlo
        'en realidad cuando busco el vehiculo si no está lo voy a AGREGAR y ya queda en estado VENDIDO = N

        If textidvehiculo.Text = "" Then 'entonces tengo que agregar el vehiculo a la tabla vehiculos, esto significa que no existe en la bd

            Dim CNV As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CNV.Open()
            Dim cmdv As New SqlCommand("insert into Vehiculos values ('" & combomodelo.SelectedValue & "','" & tbAñoVehEntrega.Text & "','" & texttipoventrega.Text & "','" & tbMotorVehEntrega.Text & "','" & tbChasisVehEntrega.Text & "', '" & tbDominioVehEntrega.Text & "', '" & " " & "', '" & " " & "', '" & "N" & "', '" & formVentas.dtfecha.Value & "', '" & combotipo.Text & "', '" & "0" & "'. '" & tbPrecioCostoVehEntrega.Text & "', '" & "0" & "' )", CNV)
            cmdv.ExecuteNonQuery()


            'busco el id del vehiculo cargado
            Dim maxi As New SqlCommand("Select max(idvehiculo) from vehiculos", CNV)
            Dim id = maxi.ExecuteScalar()

            CNV.Close()


            'debo crear registro en la tabla VEHICULOSENTREGAS

            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into VehiculosEntregas values ('" & formVentas.textidventa.Text & "','" & id & "','" & tbPrecioCostoVehEntrega.Text & "','" & textdetalle.Text & "','" & textdeuda.Text & "')", CN)
            cmd.ExecuteNonQuery()

            CN.Close()

            cargarentregas()

            'debeo crear registro en la tabla VEHICULOSXCLIENTES para saber quien me entrego ese vehiculo
            Dim CNN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CNN.Open()
            Dim cmde As New SqlCommand("insert into Vehiculosxclientes values ('" & id & "','" & formVentas.tbIdCliente.Text & "','" & formVentas.dtfecha.Value & "','" & formVentas.dtfecha.Value & "','" & "Activo" & "')", CNN)
            cmde.ExecuteNonQuery()

            Dim suma As New SqlCommand("Select sum(PrecioE) from VehiculosEntregas where Idventa = '" & formVentas.textidventa.Text & "' ", CNN)

            formVentas.textsumaentregasv.Text = suma.ExecuteScalar()


        Else ' significa que ya existe y solo le cambio el estado y tengo el id tambien

           

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

            Dim cambiarestado As New SqlCommand("update Vehiculos set Vendido = 'N' where idvehiculo ='" & textidvehiculo.Text & "' ", CNN)
            cambiarestado.ExecuteNonQuery()


            CNN.Close()

        End If

       





    End Sub

    Public Sub cargarCBMarcas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Marcas order by NombreMarca", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        combomarca.DataSource = ds
        combomarca.ValueMember = "IdMarca"
        combomarca.DisplayMember = "NombreMarca"
    End Sub

    Public Sub cargarCBModelos(id As String)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdModelo,NombreModelo from Modelos where IdMarca='" & id & "' order by NombreModelo", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        combomodelo.DataSource = ds
        combomodelo.ValueMember = "IdModelo"
        combomodelo.DisplayMember = "NombreModelo"
    End Sub
    Private Sub formvehiculoentrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBMarcas()
        tbidmarca.Text = combomarca.SelectedValue.ToString
        cargarCBModelos(tbidmarca.Text)


    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub combomarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combomarca.SelectedIndexChanged

    End Sub

    Private Sub combomarca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combomarca.SelectionChangeCommitted
        tbidmarca.Text = combomarca.SelectedValue.ToString
        cargarCBModelos(tbidmarca.Text)
    End Sub
End Class