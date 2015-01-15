Imports System.Data.SqlClient
Public Class formReporteGastoVehiculo

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
            Dim seleccion As String = "select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and (NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%' or Dominio like '" & tbBusqueda.Text & "%') and vendido = 'N' order by NombreMarca,NombreModelo"
            miConexion.Open()
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            dgVehiculos.DataSource = tabla2
        miConexion.Close()
    End Sub

    Private Sub cargarDGVehiculos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and Vendido = 'N' order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub formReporteGastoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGVehiculos()
    End Sub


    Private Sub dgVehiculos_Click(sender As Object, e As EventArgs) Handles dgVehiculos.Click
        If dgVehiculos.RowCount > 0 Then
            textIdVeh.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If textIdVeh.Text = "" Then
            MessageBox.Show("Seleccione un auto antes de generar el reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select FechaGasto as fecha,DetalleGasto as detalle,ImporteGasto as importe,NombreProveedor as proveedor from GastosVehiculos g, Proveedores p, VehiculosXClientes vxc where g.IdProveedor = p.IdProveedor and g.IdVxC = vxc.IdVxC and vxc.IdVehiculo = '" & textIdVeh.Text & "'"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "GastosXVehiculo")
        CN.Close()
        Dim rpt As reporteGastosXVehiculo = New reporteGastosXVehiculo
        rpt.SetDataSource(dtDatos)
        Dim vehiculo As String = dgVehiculos.Item("marca", dgVehiculos.SelectedRows(0).Index).Value() + " " + dgVehiculos.Item("modelo", dgVehiculos.SelectedRows(0).Index).Value() + " " + dgVehiculos.Item("tipoVehiculo", dgVehiculos.SelectedRows(0).Index).Value() + " " + Conversion.Str(dgVehiculos.Item("año", dgVehiculos.SelectedRows(0).Index).Value()) + ", Dominio: " + dgVehiculos.Item("dominio", dgVehiculos.SelectedRows(0).Index).Value()
        rpt.SetParameterValue("vehiculo", vehiculo)
        FormReporteGastosXVehiculo.viewerGastosXVehiculos.ReportSource = rpt

        FormReporteGastosXVehiculo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class