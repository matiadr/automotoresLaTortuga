
Imports System.Data.SqlClient
Public Class formPrincipal

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        formClientes.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formCuentas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MarcasVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasVehículosToolStripMenuItem.Click
        formABMMarca.Show()
    End Sub

    Private Sub ModelosVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelosVehículosToolStripMenuItem.Click
        formABMModelos.Show()
    End Sub

    Private Sub ProvinciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvinciasToolStripMenuItem.Click
        formABMProvincia.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        formABMLocalidad.Show()
    End Sub


    Private Sub RubrosCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubrosCuentasToolStripMenuItem.Click
        formABMRubros.Show()
    End Sub

    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        formABMBancos.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem1.Click
        formCuentas.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        formABMSucursales.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub AdministrarVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVehiculosToolStripMenuItem.Click
        formVehiculos.Show()
    End Sub

    Private Sub StockDeVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeVehiculosToolStripMenuItem.Click
        formConsultaVehiculos.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        formVentas.Show()
        formVentas.GroupBox3.Enabled = False
        formVentas.GroupBox4.Enabled = False
    End Sub


    Private Sub CajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem.Click
        FormCaja.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FormABMProveedores.Show()
    End Sub

    Private Sub StockDeVehiculosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockDeVehiculosToolStripMenuItem1.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NombreMarca,NombreModelo,Dominio,Tipo,TipoMotor,Año from Vehiculos v,Modelos m,Marcas ma where v.IdModelo = m.IdModelo and m.IdMarca = ma.IdMarca order by NombreMarca,NombreModelo,Año"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "StockVehiculo")
        Dim rpt As reporteStockVehiculos = New reporteStockVehiculos
        rpt.SetDataSource(dtDatos)
        FormReporteStockVehiculos.viewerStockVehiculos.ReportSource = rpt
        FormReporteStockVehiculos.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Dim CN As New SqlConnection("Data Source='" & tbEquipo.Text & "';INITIAL Catalog='" & tbBSD.Text & "' ;Persist Security Info=True;User ID='" & tbUsuario.Text & "';Password='" & tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NombreC as Nombre,Domicilio as Direccion,Telefono,NombreLocalidad as Ciudad,NombreProvincia as Provincia from Clientes c,Localidades l,Provincias p where c.IdLocalidad=l.IdLocalidad and l.IdProvincia=p.IdProvincia order by NombreC"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Cliente")
        Dim rpt As reporteClientes = New reporteClientes
        rpt.SetDataSource(dtDatos)
        FormReporteClientes.viewerClientes.ReportSource = rpt
        FormReporteClientes.Show()
    End Sub

    Private Sub VehiculosVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosVendidosToolStripMenuItem.Click
        FormFechasDesdeHasta.ShowDialog()
    End Sub
End Class

