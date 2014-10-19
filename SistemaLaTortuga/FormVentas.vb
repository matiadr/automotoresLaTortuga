Imports System.Data.SqlClient
Public Class formVentas


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bBuscarCliente.Click
        formBuscarCliente.Show()
    End Sub

    Private Sub BuscarCliente(id As String)
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        miConexion.Open()
        Dim seleccion As String = "select NombreC,Domicilio,NombreLocalidad,CodigoPostal,TipoDni,NumeroDni,Telefono from Clientes c,Localidades l where c.IdLocalidad=l.IdLocalidad and IdCliente='" & id & "'"
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        tbNombre.Text = tabla2.Rows.Item(0).Item("NombreC")
        tbDomicilio.Text = tabla2.Rows.Item(0).Item("Domicilio")
        tbLocalidad.Text = tabla2.Rows.Item(0).Item("NombreLocalidad")
        tbCodPostal.Text = tabla2.Rows.Item(0).Item("CodigoPostal")
        tbTipoDoc.Text = tabla2.Rows.Item(0).Item("TipoDni")
        tbNroDoc.Text = tabla2.Rows.Item(0).Item("NumeroDni")
        tbTelefono.Text = tabla2.Rows.Item(0).Item("Telefono")
    End Sub
    Private Sub tbIdCliente_TextChanged(sender As Object, e As EventArgs) Handles tbIdCliente.TextChanged
        If tbIdCliente.Text.Length > 0 Then
            BuscarCliente(tbIdCliente.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bVehVenta.Click
        formBuscarVehiculo.Show()
        formBuscarVehiculo.tipoBoton = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        formBuscarVehiculo.Show()
        formBuscarVehiculo.tipoBoton = 2
    End Sub

    Private Sub tbIdVehVenta_TextChanged(sender As Object, e As EventArgs) Handles tbIdVehVenta.TextChanged
        If tbIdVehVenta.Text.Length > 0 Then
            BuscarAutoVenta(tbIdVehVenta.Text)
        End If
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
            tbMarcaVehVenta.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehVenta.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehVenta.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehVenta.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehVenta.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehVenta.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehVenta.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehVenta.Text = tabla2.Rows.Item(0).Item("Motor")
            tbPrecioVentaVehVenta.Text = tabla2.Rows.Item(0).Item("PrecioVenta")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub

    Private Sub BuscarAutoEntrega(id As String)
        Try
            Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
            Dim miConexion As New SqlConnection(CN)
            miConexion.Open()
            Dim seleccion As String = "select NombreMarca,NombreModelo,Tipo,Dominio,Año,TipoMotor,Chasis,Motor,PrecioCosto from Vehiculos v,Marcas ma,Modelos m where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and IdVehiculo='" & id & "'"
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            tbMarcaVehVenta.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehVenta.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehVenta.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehVenta.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehVenta.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehVenta.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehVenta.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehVenta.Text = tabla2.Rows.Item(0).Item("Motor")
            tbpreciocostoVehVenta.Text = tabla2.Rows.Item(0).Item("PrecioCosto")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub
    Private Sub tbIdVehEntrega_TextChanged(sender As Object, e As EventArgs)
        If tbIdVehEntrega.Text.Length > 0 Then
            BuscarAutoEntrega(tbIdVehEntrega.Text)
        End If
    End Sub


    

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        If tbIdCliente.Text.Length > 0 Then
            BuscarCliente(tbIdCliente.Text)
        End If
        If tbIdVehVenta.Text.Length > 0 Then
            BuscarAutoVenta(tbIdVehVenta.Text)
        End If
        If tbIdVehEntrega.Text.Length > 0 Then
            BuscarAutoEntrega(tbIdVehEntrega.Text)
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        formvehiculoentrega.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormEntregasEfectivo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormDocumentos.Show()
    End Sub

    Private Sub formVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Ventas values ('" & tbidvendedor.Text & "','" & tbIdCliente.Text & "','" & tbIdVehVenta.Text & "','" & TbPrecioCostoVehVenta.Text & "','" & tbPrecioVentaVehVenta.Text & "','" & tbtransferencia.Text & "','" & dtfecha.Value & "')", CN)
        cmd.ExecuteNonQuery()
        CN.Close()

        'busco el codigo de esta venta...o sea el maximo de la tabla ventas
        Dim venta As New SqlCommand("Select max(idventa) from ventas", CN)
        Dim codigo As String = venta.ExecuteScalar
        textidventa.Text = codigo



            MessageBox.Show("Venta Ingresada")



            'habilito los groupbox para poder cargar los vehiculos entregados, y otros medios de pagos
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
    End Sub
End Class