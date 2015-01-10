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
        If tbTipoVehiculo.Text.Length > 0 And tbIdVehiculo.Text = "" Then
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
        Dim seleccion As String
        If rbTipoVehiculo.Checked = True Then
            seleccion = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and Tipo like '" & tbBusqueda.Text & "%' order by Tipo" 'Busco por tipo
        Else
            If rbMarca.Checked = True Then
                seleccion = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and NombreMarca like '" & tbBusqueda.Text & "%' order by NombreMarca" 'Busco por marca
            Else
                If rbDominio.Checked = True Then
                    seleccion = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and Dominio like '" & tbBusqueda.Text & "%' order by Dominio" 'Busco por Dominio
                Else
                    If rbModelo.Checked = True Then
                        seleccion = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and NombreModelo like '" & tbBusqueda.Text & "%' order by NombreModelo" 'Busco por Modelo
                    Else
                        If rbAño.Checked = True Then
                            seleccion = "select IdVehiculo,mo.IdModelo,NombreModelo,m.IdMarca,NombreMarca,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,tipoMotor,PrecioVenta,PrecioCosto,PrecioGastos from Vehiculos v,Marcas m,Modelos mo where v.IdModelo=mo.IdModelo and mo.IdMarca=m.IdMarca and Vendido= 'N' and Año like '" & tbBusqueda.Text & "%' order by Año" 'Busco por Año
                        End If
                    End If
                End If
            End If
        End If
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
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        cbMarca.DataSource = ds
        cbMarca.ValueMember = "IdMarca"
        cbMarca.DisplayMember = "NombreMarca"
    End Sub

    Public Sub cargarCBModelos(id As String)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdModelo,NombreModelo from Modelos where IdMarca='" & id & "' order by NombreModelo", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        cbModelo.DataSource = ds
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

    Private Sub dgVehiculos_CellStyleContentChanged(sender As Object, e As DataGridViewCellStyleContentChangedEventArgs) Handles dgVehiculos.CellStyleContentChanged

    End Sub

    Private Sub dgVehiculos_Click(sender As Object, e As EventArgs) Handles dgVehiculos.Click, dgVehiculos.KeyDown, dgVehiculos.KeyUp

        textnombre.Text = ""
        textidcliente.Text = ""

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
            tbVenta.Text = Replace(dgVehiculos.Item("precioVenta", dgVehiculos.SelectedRows(0).Index).Value(), ",", ".")
            tbCosto.Text = Replace(dgVehiculos.Item("precioCosto", dgVehiculos.SelectedRows(0).Index).Value(), ",", ".")
            tbGastos.Text = Replace(dgVehiculos.Item("precioGastos", dgVehiculos.SelectedRows(0).Index).Value(), ",", ".")
            bModificar.Enabled = True
            bEliminar.Enabled = True
        End If


        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        'busco si hay un cliente asociado a dicho vehículo en la tabla VEHICULOSXCLIENTE
        Dim cliente As New SqlCommand("Select idcliente from VehiculosxClientes where idVehiculo = '" & tbIdVehiculo.Text & "' and Estado = 'Activo' ", CN)


        'cliente.ExecuteReader()

        '  Dim dt As New DataTable
        ' Dim da As New SqlDataAdapter(cliente)


        Dim reader As SqlDataReader = cliente.ExecuteReader()





        If reader.Read = Nothing Then

        Else
            textidcliente.Text = reader.GetInt32(0)


            reader.Close()
            'busco el cliente asociado a ese vehiculo de la tabla
            Dim nombre As New SqlCommand("Select NombreC from Clientes where idCliente = '" & textidcliente.Text & "'", CN)

            Dim readern As SqlDataReader = nombre.ExecuteReader()


            readern.Read()
            textnombre.Text = readern.GetString(0)

            readern.Close()


             End If



            CN.Close()



            'deshabilito el text del nombre si es que ya esta asignado y la fecha tambien y los botones
            If textnombre.Text <> "" Then
                textnombre.Enabled = False
                dtfecha.Enabled = False
                Button1.Enabled = False
                Button2.Enabled = False
            Else
                textnombre.Enabled = True
                dtfecha.Enabled = True
                Button1.Enabled = True

            End If


    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Vehiculos (IdModelo,Año,Tipo,Motor,Chasis,Dominio,Color,Observaciones,FechaAlta,TipoMotor,Vendido,PrecioVenta,PrecioCosto,PrecioGastos) values ('" & tbIdModelo.Text & "','" & tbAño.Text & "','" & tbTipoVehiculo.Text & "','" & tbNroMotor.Text & "','" & tbNroChasis.Text & "','" & tbDominio.Text & "','" & tbColor.Text & "','" & tbObservacion.Text & "','" & tbFechaAlta.Text & "','" & cbTipoMotor.SelectedValue & "','N','" & Conversion.Val(tbVenta.Text) & "','" & Conversion.Val(tbCosto.Text) & "','" & Conversion.Val(tbGastos.Text) & "')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Vehiculo Agregado")
            cargarDGVehiculos()
            CN.Close()
            LimpiarPantalla()
        Catch ex As SqlException
            MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
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
        bEliminar.Enabled = False

        textidcliente.Text = ""
        textnombre.Text = ""
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
            bEliminar.Enabled = False
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub tbCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCosto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = (",") Then
            e.Handled = True
            SendKeys.Send(".")
        End If
    End Sub

    Private Sub tbGastos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbGastos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = (",") Then
            e.Handled = True
            SendKeys.Send(".")
        End If
    End Sub

    Private Sub tbVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = (",") Then
            e.Handled = True
            SendKeys.Send(".")
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try
            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Vehiculos where IdVehiculo ='" & tbIdVehiculo.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGVehiculos()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                LimpiarPantalla()
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar ya que dicho vehiculo esta siendo usado", "Advertencia")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBuscarCliente.Show()
        formBuscarCliente.textform.Text = "v"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click





        'debeo crear registro en la tabla VEHICULOSXCLIENTES para saber quien me entrego ese vehiculo
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()


        'primero controlo que no exista ya un registro para ese vehiculo y este activo....porque si es asi pregunto si quiero eliminar al dueño anterior
        'y reemplazarlo
      

        Dim fecha As String = Format(tbFechaAlta.Value, "yyyy-MM-dd")

        Dim cmd As New SqlCommand("insert into VehiculosxClientes(IdVehiculo, IdCliente, FechaDesde, FechaHasta, Estado) values ('" & tbIdVehiculo.Text & "','" & textidcliente.Text & "','" & fecha & "','" & fecha & "','" & "Activo" & "')", CN)

        cmd.ExecuteNonQuery()

        



        CN.Close()

        Button1.Enabled = False
        Button2.Enabled = False
    End Sub


    Private Sub tbFechaAlta_ValueChanged(sender As Object, e As EventArgs) Handles tbFechaAlta.ValueChanged
        dtfecha.Value = tbFechaAlta.Value
    End Sub

End Class