Imports System.Data.SqlClient
Public Class formVehiculos



    Private Sub b_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevaMarca_Click(sender As Object, e As EventArgs) Handles bNuevaMarca.Click
        formABMMarca.Show()
    End Sub

    Private Sub bNuevoModelo_Click(sender As Object, e As EventArgs) Handles bNuevoModelo.Click
        formABMModelos.Show()
    End Sub



    Private Sub tbTipoVehiculo_TextChanged(sender As Object, e As EventArgs) Handles tbTipoVehiculo.TextChanged
        If tbTipoVehiculo.Text.Length > 0 And tbAño.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub cargarComboBoxs()
        Dim tipoMotor As New DataTable
        tipoMotor.Columns.Add("codigo", GetType(Integer))
        tipoMotor.Columns.Add("descripcion", GetType(String))
        tipoMotor.Rows.Add(New Object() {0, "NAFTA"})
        tipoMotor.Rows.Add(New Object() {1, "DIESEL"})
        tipoMotor.Rows.Add(New Object() {2, "GNC"})
        tipoMotor.AcceptChanges()
        cbTipoMotor.DataSource = tipoMotor
        cbTipoMotor.ValueMember = "descripcion"
        cbTipoMotor.DisplayMember = "descripcion"

        ''Seleccionamos el tipoMotor inicial.
        cbTipoMotor.SelectedIndex = 0
    End Sub

    Private Sub cargarDGVehiculos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' order by Tipo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgVehiculos.DataSource = dt
        CN.Close()
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and Tipo like '" & tbBusqueda.Text & "%' order by Tipo" 'Busco por Nombre
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgVehiculos.DataSource = tabla2
        miConexion.Close()
    End Sub

    Public Sub cargarCBMarcas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Marcas order by NombreMarca", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        cbMarca.DataSource = ds.Tables(0)
        cbMarca.ValueMember = "IdMarca"
        cbMarca.DisplayMember = "NombreMarca"
    End Sub

    Public Sub cargarCBModelos(id As String)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdModelo,NombreModelo from Modelos where IdMarca='" & id & "' order by NombreModelo", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        cbModelo.DataSource = ds.Tables(0)
        cbModelo.ValueMember = "IdModelo"
        cbModelo.DisplayMember = "NombreModelo"
    End Sub
    Private Sub formVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGVehiculos()
        cargarComboBoxs()
        cargarCBMarcas()
        tbIdMarca.Text = cbMarca.SelectedValue.ToString
        cargarCBModelos(tbIdMarca.Text)
    End Sub

    Private Sub cbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModelo.SelectedIndexChanged
        tbIdModelo.Text = cbModelo.SelectedValue.ToString
    End Sub

    Private Sub cbMarca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbMarca.SelectionChangeCommitted
        tbIdMarca.Text = cbMarca.SelectedValue.ToString
        cargarCBModelos(tbIdMarca.Text)
    End Sub

    Private Sub dgVehiculos_Click(sender As Object, e As EventArgs) Handles dgVehiculos.Click, dgVehiculos.KeyDown, dgVehiculos.KeyUp
        If dgVehiculos.RowCount > 0 Then
            tbIdVehiculo.Text = dgVehiculos.Item("idVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
            tbTipoVehiculo.Text = dgVehiculos.Item("tipoVehiculo", dgVehiculos.SelectedRows(0).Index).Value()
            tbIdMarca.Text = dgVehiculos.Item("idMarca", dgVehiculos.SelectedRows(0).Index).Value()
            cbMarca.SelectedValue = tbIdMarca.Text
            cargarCBModelos(tbIdMarca.Text)
            tbNroMotor.Text = dgVehiculos.Item("motor", dgVehiculos.SelectedRows(0).Index).Value()
            tbNroChasis.Text = dgVehiculos.Item("chasis", dgVehiculos.SelectedRows(0).Index).Value()
            tbColor.Text = dgVehiculos.Item("color", dgVehiculos.SelectedRows(0).Index).Value()
            tbObservacion.Text = dgVehiculos.Item("observaciones", dgVehiculos.SelectedRows(0).Index).Value()
            tbAño.Text = dgVehiculos.Item("año", dgVehiculos.SelectedRows(0).Index).Value()
            tbFechaAlta.Text = dgVehiculos.Item("fechaAlta", dgVehiculos.SelectedRows(0).Index).Value()
            cbTipoMotor.SelectedValue = dgVehiculos.Item("tipoMotor", dgVehiculos.SelectedRows(0).Index).Value()
            tbDominio.Text = dgVehiculos.Item("dominio", dgVehiculos.SelectedRows(0).Index).Value()
            tbVenta.Text = dgVehiculos.Item("precioVenta", dgVehiculos.SelectedRows(0).Index).Value()
            tbCosto.Text = dgVehiculos.Item("precioCosto", dgVehiculos.SelectedRows(0).Index).Value()
            tbGastos.Text = dgVehiculos.Item("precioGastos", dgVehiculos.SelectedRows(0).Index).Value()
            bModificar.Enabled = True
        End If
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Vehiculos (IdModelo,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,TipoMotor,Vendido,PrecioVenta,PrecioCosto,PrecioGastos) values ('" & tbIdModelo.Text & "','" & tbAño.Text & "','" & tbTipoVehiculo.Text & "','" & tbNroMotor.Text & "','" & tbNroChasis.Text & "','" & tbDominio.Text & "','" & tbColor.Text & "','" & tbObservacion.Text & "','" & tbFechaAlta.Text & "','" & cbTipoMotor.SelectedValue & "','N','" & tbVenta.Text & "','" & tbCosto.Text & "','" & tbGastos.Text & "')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Vehiculo Agregado")
            cargarDGVehiculos()
            LimpiarPantalla()
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub LimpiarPantalla()
        tbIdVehiculo.Text = ""
        tbTipoVehiculo.Text = ""
        tbNroMotor.Text = ""
        tbNroChasis.Text = ""
        tbColor.Text = ""
        tbObservacion.Text = ""
        tbAño.Text = ""
        tbFechaAlta.Text = Date.Today
        tbDominio.Text = ""
        tbVenta.Text = ""
        tbCosto.Text = ""
        tbGastos.Text = ""
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        LimpiarPantalla()
        bModificar.Enabled = False
    End Sub


    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("update Vehiculos set Año= '" & tbAño.Text & "',Tipo='" & tbTipoVehiculo.Text & "',Motor='" & tbNroMotor.Text & "',Chasis='" & tbNroChasis.Text & "',Dominio='" & tbDominio.Text & "',IdModelo='" & tbIdModelo.Text & "',Color='" & tbColor.Text & "',Observaciones='" & tbObservacion.Text & "',FechaAlta='" & tbFechaAlta.Text & "',TipoMotor='" & cbTipoMotor.SelectedValue & "',PrecioVenta='" & tbVenta.Text & "',PrecioCosto='" & tbCosto.Text & "',PrecioGastos= '" & tbGastos.Text & "' where IdVehiculo= '" & tbIdVehiculo.Text & "'", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modificacion Efectuada")
            cargarDGVehiculos()
            LimpiarPantalla()
            bModificar.Enabled = False
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub
End Class