Imports System.Data.SqlClient
Public Class formBuscarVehiculo

    'Va a guardar 1 si el click se hizo en el boton de buscar vehiculo para la venta,
    'sino sera 2 si fue en el vehiculo de entrega, esto lo hago para saber en que textBox 
    'guardar el IdVehiculo
    Public tipoBoton As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub formBuscarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGVehiculos()
    End Sub

    Private Sub cargarDGVehiculos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String = "select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and (NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%' or Dominio like '" & tbBusqueda.Text & "%') order by NombreMarca,NombreModelo"
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgVehiculos.DataSource = tabla2
        miConexion.Close()
    End Sub

    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgVehiculos.DoubleClick
        If tipoBoton = 1 Then
            formVentas.tbIdVehVenta.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
        Else
            formVentas.tbIdVehEntrega.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
        End If
        Me.Close()
    End Sub

    Private Sub dgVehiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVehiculos.CellContentClick

    End Sub
End Class