
Imports System.Data.SqlClient
Public Class formPrincipal

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        formClientes.ShowDialog()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formCuentas.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MarcasVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasVehículosToolStripMenuItem.Click
        formABMMarca.ShowDialog()
    End Sub

    Private Sub ModelosVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelosVehículosToolStripMenuItem.Click
        formABMModelos.ShowDialog()
    End Sub

    Private Sub ProvinciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvinciasToolStripMenuItem.Click
        formABMProvincia.ShowDialog()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        formABMLocalidad.ShowDialog()
    End Sub


    Private Sub RubrosCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubrosCuentasToolStripMenuItem.Click
        formABMRubros.ShowDialog()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        formABMBancos.ShowDialog()
    End Sub

    Private Sub CuentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem1.Click
        formCuentas.ShowDialog()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        formABMSucursales.ShowDialog()
    End Sub


    Private Sub AdministrarVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVehiculosToolStripMenuItem.Click
        formVehiculos.ShowDialog()
    End Sub

    Private Sub StockDeVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeVehiculosToolStripMenuItem.Click
        formConsultaVehiculos.ShowDialog()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        formVentas.Show()
        formVentas.GroupBox3.Enabled = False
        formVentas.GroupBox4.Enabled = False
    End Sub


    Private Sub CajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem.Click
        FormCaja.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormABMProveedores.ShowDialog()
    End Sub

    Private Sub StockDeVehiculosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockDeVehiculosToolStripMenuItem1.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NombreMarca,NombreModelo,Dominio,Tipo,TipoMotor,Año from Vehiculos v,Modelos m,Marcas ma where v.IdModelo = m.IdModelo and m.IdMarca = ma.IdMarca  and Vendido='N' order by NombreMarca,NombreModelo,Año"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "StockVehiculo")
        CN.Close()
        Dim rpt As reporteStockVehiculos = New reporteStockVehiculos
        rpt.SetDataSource(dtDatos)
        FormReporteStockVehiculos.viewerStockVehiculos.ReportSource = rpt
        FormReporteStockVehiculos.ShowDialog()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NombreC as Nombre,Domicilio as Direccion,Telefono,NombreLocalidad as Ciudad,NombreProvincia as Provincia from Clientes c,Localidades l,Provincias p where c.IdLocalidad=l.IdLocalidad and l.IdProvincia=p.IdProvincia order by NombreC"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Cliente")
        CN.Close()
        Dim rpt As reporteClientes = New reporteClientes
        rpt.SetDataSource(dtDatos)
        FormReporteClientes.viewerClientes.ReportSource = rpt
        FormReporteClientes.ShowDialog()
    End Sub

    Private Sub VehiculosVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosVendidosToolStripMenuItem.Click
        FormFechasDesdeHasta.tipoListado = "vehVendidos"
        FormFechasDesdeHasta.ShowDialog()
    End Sub

    Private Sub EstadoDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeChequesToolStripMenuItem.Click
        FormFechasDesdeHasta.tipoListado = "cheques"
        FormFechasDesdeHasta.ShowDialog()
    End Sub

    Private Sub TransferenciasCobradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciasCobradasToolStripMenuItem.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select ve.idcomprador, ve.FechaVenta, NombreC as Cliente, NumeroDni as Dni, NombreMarca as Marca, NombreModelo as Modelo, Dominio, ve.Gastos as Cobrada, ve.TransferenciaReal as Real, (Ve.Gastos - ve.TransferenciaReal) as Diferencia from Clientes c,Vehiculos v, Modelos mo, Marcas ma, Ventas ve  where c.idcliente = ve.idComprador and ve.idvehiculoventa = v.idvehiculo and mo.idModelo = V.idModelo and mo.IdMarca = ma.idMarca and (Ve.Gastos - ve.TransferenciaReal) <> 0 order by ve.fechaventa desc"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Transferencia")
        CN.Close()
        Dim rpt As ReporteTransferencias = New ReporteTransferencias
        rpt.SetDataSource(dtDatos)
        FormReporteTransferencias.CrystalReportViewer1.ReportSource = rpt

        FormReporteTransferencias.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        formlistadoventas.ShowDialog()
    End Sub


    Private Sub ChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequesToolStripMenuItem.Click
        formCheques.ShowDialog()
    End Sub

    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select fecha,'Venta' as detalle, ImporteAdministrador as importe, '0' as pago from Administrador UNION (select FechaPago as fecha,'Pago' as detalle, '0' as importe, ImportePago as pago from PagosAdministrador)"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Administrador")
        CN.Close()
        Dim rpt As reporteAdministrador = New reporteAdministrador
        rpt.SetDataSource(dtDatos)
        FormReporteAdministrador.viewerAdministrador.ReportSource = rpt

        FormReporteAdministrador.ShowDialog()
    End Sub
End Class

