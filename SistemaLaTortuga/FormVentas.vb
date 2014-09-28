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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bVehEntrega.Click
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
            tbMarcaVehEntrega.Text = tabla2.Rows.Item(0).Item("NombreMarca")
            tbModeloVehEntrega.Text = tabla2.Rows.Item(0).Item("NombreModelo")
            tbTipoVehEntrega.Text = tabla2.Rows.Item(0).Item("Tipo")
            tbDominioVehEntrega.Text = tabla2.Rows.Item(0).Item("Dominio")
            tbAñoVehEntrega.Text = tabla2.Rows.Item(0).Item("Año")
            tbTipoMotorVehEntrega.Text = tabla2.Rows.Item(0).Item("TipoMotor")
            tbChasisVehEntrega.Text = tabla2.Rows.Item(0).Item("Chasis")
            tbMotorVehEntrega.Text = tabla2.Rows.Item(0).Item("Motor")
            tbPrecioCostoVehEntrega.Text = tabla2.Rows.Item(0).Item("PrecioCosto")
        Catch ex As SqlException
            MessageBox.Show("No se pudo completar la operacion,Error en la base de datos")
        End Try
    End Sub
    Private Sub tbIdVehEntrega_TextChanged(sender As Object, e As EventArgs) Handles tbIdVehEntrega.TextChanged
        If tbIdVehEntrega.Text.Length > 0 Then
            BuscarAutoEntrega(tbIdVehEntrega.Text)
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bLimpiar.Click
        tbIdVehEntrega.Text = ""
        tbMarcaVehEntrega.Text = ""
        tbModeloVehEntrega.Text = ""
        tbTipoVehEntrega.Text = ""
        tbDominioVehEntrega.Text = ""
        tbAñoVehEntrega.Text = ""
        tbTipoMotorVehEntrega.Text = ""
        tbChasisVehEntrega.Text = ""
        tbMotorVehEntrega.Text = ""
        tbPrecioCostoVehEntrega.Text = ""
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

End Class