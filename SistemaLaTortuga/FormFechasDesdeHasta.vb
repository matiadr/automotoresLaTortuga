Imports System.Data.SqlClient
Public Class FormFechasDesdeHasta

    Public tipoListado As String
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bGenerarReporte_Click(sender As Object, e As EventArgs) Handles bGenerarReporte.Click
        If tbFechaDesde.Text > tbFechaHasta.Text Then
            MessageBox.Show("El rango de fechas no es correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
            Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
            CN.Open()

            If tipoListado = "vehVendidos" Then
                Dim seleccion As String = "select FechaDesde as fecha, NombreC as nombre, NombreMarca as marca , NombreModelo as modelo,Tipo as tipo,Año as año from VehiculosxClientes vxc,Clientes c,Vehiculos v,Modelos m,Marcas ma where vxc.IdVehiculo = v.IdVehiculo and v.IdModelo = m.IdModelo and m.IdMarca = ma.IdMarca and vxc.IdCliente = c.IdCliente and Estado='Pasivo' and FechaDesde >= '" & tbFechaDesde.Text & "' and FechaDesde <= '" & tbFechaHasta.Text & "'"
                daDatos = New SqlDataAdapter(seleccion, CN)
                daDatos.Fill(dtDatos, "VehiculoVendido")
                CN.Close()
                Dim rpt As reporteVehiculosVendidos = New reporteVehiculosVendidos
                rpt.SetDataSource(dtDatos)
                rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
                rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
                FormReporteVehiculosVendidos.viewerVehVendidos.ReportSource = rpt
                FormReporteVehiculosVendidos.Show()
            Else
                If tipoListado = "cheques" Then
                    Dim seleccion As String = "select NumeroCheque as numeroCheque,ImporteCheque as importe, NombreC as entregadoPor, FechaCheque as fecha, EstadoCheque as estado from Cheques c,Clientes cl where c.IdComprador = cl.IdCliente and FechaCheque >= '" & tbFechaDesde.Text & "' and FechaCheque <= '" & tbFechaHasta.Text & "' order by NumeroCheque"
                    daDatos = New SqlDataAdapter(seleccion, CN)
                    daDatos.Fill(dtDatos, "Cheque")
                    Dim rpt As reporteCheques = New reporteCheques
                    rpt.SetDataSource(dtDatos)
                    rpt.SetParameterValue("fechaDesde", tbFechaDesde.Text)
                    rpt.SetParameterValue("fechaHasta", tbFechaHasta.Text)
                    FormReporteCheques.viewerCheques.ReportSource = rpt
                    FormReporteCheques.Show()
                End If
            End If
        End If
    End Sub
End Class