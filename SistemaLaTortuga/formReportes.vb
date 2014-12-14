﻿Imports System.Data.SqlClient

Public Class formReportes

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub formReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboBox()
    End Sub

    Private Sub CargarComboBox()
        Dim dtReportes As New DataTable
        dtReportes.Columns.Add("codigo", GetType(String))
        dtReportes.Columns.Add("descripcion", GetType(String))

        dtReportes.Rows.Add(New Object() {"creditos", "Creditos Solicitados y Otorgados"})
        dtReportes.Rows.Add(New Object() {"administrador", "Financidado por Administrador y pagos"})
        dtReportes.Rows.Add(New Object() {"saldoVenta", "Saldo por venta"})
        dtReportes.Rows.Add(New Object() {"negocioXCliente", "Negocio por Cliente"})
        dtReportes.Rows.Add(New Object() {"caja", "Caja"})
        dtReportes.Rows.Add(New Object() {"clientesXVeh", "Clientes por vehiculos"})
        dtReportes.Rows.Add(New Object() {"stockVeh", "Stock Vehiculos"})
        dtReportes.Rows.Add(New Object() {"vehVendidos", "Vehiculos vendidos"})
        dtReportes.Rows.Add(New Object() {"clientes", "Clientes"})
        dtReportes.Rows.Add(New Object() {"transferencias", "Transferencias Cobradas y Pagadas"})
        dtReportes.Rows.Add(New Object() {"cuotasVencidas", "Cuotas vencidas"})
        dtReportes.Rows.Add(New Object() {"cuotasCobrar", "Cuotas a Cobrar"})
        dtReportes.Rows.Add(New Object() {"gastosVeh", "Gastos por Vehiculos"})
        dtReportes.Rows.Add(New Object() {"rubros", "Rubros"})
        dtReportes.Rows.Add(New Object() {"cuentas", "Cuentas"})
        dtReportes.Rows.Add(New Object() {"cheques", "Cheques"})
        dtReportes.AcceptChanges()
        cbReportes.DataSource = dtReportes
        cbReportes.ValueMember = "codigo"
        cbReportes.DisplayMember = "descripcion"
        cbReportes.SelectedIndex = 0
    End Sub

    Private Sub bGenerarReporte_Click(sender As Object, e As EventArgs) Handles bGenerarReporte.Click

    End Sub

    Private Sub ReporteClientes()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
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


    Private Sub ReporteCheques()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NumeroCheque as numeroCheque,ImporteCheque as importe, NombreC as entregadoPor, FechaCheque as fecha, EstadoCheque as estado from Cheques c,Clientes cl where c.IdComprador = c.IdCliente and FechaCheque >= '" & tbFechaDesde.Text & "' and FechaCheque <= '" & tbFechaHasta.Text & "' order by NumeroCheque"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Cheque")
        Dim rpt As reporteCheques = New reporteCheques
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
        rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
        FormReporteCheques.viewerCheques.ReportSource = rpt
        FormReporteCheques.Show()
    End Sub


    Private Sub ReporteGastosXVehiculo()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select FechaGasto as fecha,ImporteGasto as importe,DetalleGasto as detalle,NombreProveedor as proveedor from GastosVehiculos g,Proveedores p where g.IdVehiculo = 2 and g.IdProveedor=p.IdProveedor order by FechaGasto"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "GastosXVehiculo")
        Dim rpt As reporteGastosXVehiculo = New reporteGastosXVehiculo
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("vehiculo", tbVehiculo.Text)
        FormReporteGastosXVehiculo.viewerGastosXVehiculos.ReportSource = rpt
        FormReporteGastosXVehiculo.Show()
    End Sub


    Private Sub ReporteRubros() 'falta terminar
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select NombreRubro as rubro,Sum(SaldoCuenta) as saldo from Rubros r,Cuentas c where c.IdRubro = r.IdRubro group by  NombreRubro order by NombreRubro"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Rubro")
        Dim rpt As reporteRubros = New reporteRubros
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
        rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
        FormReporteRubros.viewerRubros.ReportSource = rpt
        FormReporteCheques.Show()
    End Sub


    Private Sub ReporteCuentas() 'falta hacer select
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select "
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "Cuenta")
        Dim rpt As reporteCuentas = New reporteCuentas
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
        rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
        FormReporteCuentas.viewerCuentas.ReportSource = rpt
        FormReporteCuentas.Show()
    End Sub

    Private Sub ReporteStockVehiculos() 'falta hacer select
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select "
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "StockVehiculo")
        Dim rpt As reporteStockVehiculos = New reporteStockVehiculos
        rpt.SetDataSource(dtDatos)
        FormReporteStockVehiculos.viewerStockVehiculos.ReportSource = rpt
        FormReporteStockVehiculos.Show()
    End Sub

    Private Sub ReporteVehiculosVendidos() 'falta hacer select
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select "
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "VehiculoVendido")
        Dim rpt As reporteVehiculosVendidos = New reporteVehiculosVendidos
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
        rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
        FormReporteVehiculosVendidos.viewerVehVendidos.ReportSource = rpt
        FormReporteVehiculosVendidos.Show()
    End Sub
End Class