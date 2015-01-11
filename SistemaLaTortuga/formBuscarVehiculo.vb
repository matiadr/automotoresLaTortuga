Imports System.Data.SqlClient
Public Class formBuscarVehiculo


    Public tipoBoton As Integer

    Private Sub formBuscarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGVehiculos()
    End Sub

    Private Sub cargarDGVehiculos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and Vendido = 'N' order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub
    Private Sub cargarDGVehiculosvendidos(id As Integer)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and Vendido = 'S' and IdVehiculo <> '" & id & "'  order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub
    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs)
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)

        If texttipoboton.Text = 1 Then
            Dim seleccion As String = "select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and (NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%' or Dominio like '" & tbBusqueda.Text & "%') and vendido = 'N' order by NombreMarca,NombreModelo"
            miConexion.Open()
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            dgVehiculos.DataSource = tabla2
        Else
            Dim seleccion As String = "select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and (NombreMarca like '" & tbBusqueda.Text & "%' or NombreModelo like '" & tbBusqueda.Text & "%' or Dominio like '" & tbBusqueda.Text & "%') and vendido = 'S' order by NombreMarca,NombreModelo"
            miConexion.Open()
            Dim tabla2 As DataTable
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(seleccion, CN)
            tabla2 = New DataTable
            da.Fill(tabla2)
            dgVehiculos.DataSource = tabla2
        End If

        miConexion.Close()
    End Sub



    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs)
        If texttipoboton.Text = 1 Then
            formVentas.tbIdVehVenta.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
            Me.Close()
        Else

            formvehiculoentrega.textidvehiculo.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()

            Me.Close()


        End If
    End Sub

   


    Private Sub tbBusqueda_TextChanged_1(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio from Vehiculos v,Modelos m,Marcas ma where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and Vendido = 'N' and (dominio like '" & tbBusqueda.Text & "%' or NombreMarca like '" & tbBusqueda.Text & "%') order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub dgVehiculos_DoubleClick(sender As Object, e As EventArgs) Handles dgVehiculos.DoubleClick
        If texttipoboton.Text = "ve" Then
            formVentas.tbIdVehVenta.Text = dgVehiculos.Item("IdVehiculo", dgVehiculos.SelectedRows(0).Index).Value()

        Else
            If texttipoboton.Text = "ven" Then

                formvehiculoentrega.textidvehiculo.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
            Else


                FormGastosVehiculo.textidvehiculo.Text = dgVehiculos.Item("IdVxc", dgVehiculos.SelectedRows(0).Index).Value()

                FormGastosVehiculo.textpatente.Text = dgVehiculos.Item("dominio", dgVehiculos.SelectedRows(0).Index).Value()
                FormGastosVehiculo.textmodelo.Text = dgVehiculos.Item("modelo", dgVehiculos.SelectedRows(0).Index).Value()

            End If
        End If
        Me.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class