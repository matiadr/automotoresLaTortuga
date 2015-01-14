Imports System.Data.SqlClient
Public Class formCheques

   

    Private Sub LimpiarPantalla()
        textcodigoc.Text = ""
        textnombrec.Text = ""
        textimportech.Text = ""
        textnumeroch.Text = ""
        textidbanco.Text = ""
        textnombreb.Text = ""
        textidsucursal.Text = ""
        textnombres.Text = ""
        dtfechach.Value = Today
        dtfecharecibido.Value = Today
        texttitular.Text = ""
        mecuit.Text = ""
        textengregadoa.Text = ""
        textdepositadoen.Text = ""
        textcomentario.Text = ""
    End Sub
    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        'Try
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()




        Dim cmd As New SqlCommand("insert into Cheques (IdCliente,ImporteCheque,FechaCheque,IdSucursal,NumeroCheque,FechaRecibido,TitularCheque,EstadoCheque,Cuit,TipoCheque,Entregadoa,DepositadoEn,Comentario) values ('" & textcodigoc.Text & "','" & textimportech.Text & "','" & dtfechach.Value & "','" & textids.Text & "','" & textnumeroch.Text & "','" & dtfecharecibido.Value & "','" & texttitular.Text & "','" & ComboEstado.Text & "','" & mecuit.Text & "','" & Combotipo.Text & "','" & textengregadoa.Text & "','" & textdepositadoen.Text & "','" & textcomentario.Text & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Cheque Agregado")
        cargarDGcheques()
        CN.Close()
        LimpiarPantalla()
        'Catch ex As SqlException
        'MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formBuscarCliente.Show()
        formBuscarCliente.textform.Text = "ch"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formsucursalesbancos.textform.Text = "ch"
        formsucursalesbancos.Show()
    End Sub

    Private Sub cargarDGcheques()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select Idcheque,NumeroCheque,ImporteCheque,FechaCheque,NombreC,NombreBanco from Cheques ch,Sucursales s, Bancos b,Clientes c where ch.IdCliente = c.IdCliente and ch.IdSucursal = S.IdSucursal and S.IdBanco = b.IdBanco order by FechaCheque asc", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgcheques.DataSource = dt
        CN.Close()
    End Sub
    Private Sub formCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGcheques()
        ComboEstado.SelectedIndex = 0
        Combotipo.SelectedIndex = 0
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub dgcheques_Click(sender As Object, e As EventArgs) Handles dgcheques.Click
        If dgcheques.RowCount > 0 Then
            textidcheque.Text = dgcheques.Item("IdCheque", dgcheques.SelectedRows(0).Index).Value()

            bModificar.Enabled = True
            bEliminar.Enabled = True
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub textidcheque_TextChanged(sender As Object, e As EventArgs) Handles textidcheque.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        miConexion.Open()
        Dim seleccion As String = "select * from Cheques ch,Clientes c,Sucursales s,Bancos b where idcheque = '" & textidcheque.Text & "' and ch.idcliente = c.idcliente and s.idbanco = b.idbanco "
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)




        textcodigoc.Text = tabla2.Rows.Item(0).Item("idcliente")
        textnombrec.Text = tabla2.Rows.Item(0).Item("NombreC")
        dtfechach.Value = tabla2.Rows.Item(0).Item("fechacheque")


        'cuando  leo el importe en la bd esta con coma, pero tengo que mostrarlo con punto ya que no puedo volver a guardarlo con coma, porque me daria error
        textimportech.Text = Replace(tabla2.Rows.Item(0).Item("ImporteCheque"), ",", ".")
        textnumeroch.Text = tabla2.Rows.Item(0).Item("numerocheque")
        dtfecharecibido.Value = tabla2.Rows.Item(0).Item("fecharecibido")
        textidsucursal.Text = tabla2.Rows.Item(0).Item("CodigoSucursal")
        textnombres.Text = tabla2.Rows.Item(0).Item("NombreSucursal")
        textidbanco.Text = tabla2.Rows.Item(0).Item("CodigoBanco")
        textnombreb.Text = tabla2.Rows.Item(0).Item("NombreBanco")
        textids.Text = tabla2.Rows.Item(0).Item("idsucursal")
        texttitular.Text = tabla2.Rows.Item(0).Item("titularcheque")
        mecuit.Text = tabla2.Rows.Item(0).Item("cuit")
        ComboEstado.Text = tabla2.Rows.Item(0).Item("estadocheque")
        textengregadoa.Text = tabla2.Rows.Item(0).Item("entregadoa")
        textdepositadoen.Text = tabla2.Rows.Item(0).Item("depositadoen")
        Combotipo.Text = tabla2.Rows.Item(0).Item("tipocheque")
        textcomentario.Text = tabla2.Rows.Item(0).Item("comentario")

        bModificar.Enabled = True
        bEliminar.Enabled = True
    End Sub


    Private Sub dgcheques_KeyUp(sender As Object, e As KeyEventArgs) Handles dgcheques.KeyUp
        textidcheque.Text = dgcheques.Item("IdCheque", dgcheques.SelectedRows(0).Index).Value()
    End Sub

    Private Sub dgcheques_KeyDown(sender As Object, e As KeyEventArgs) Handles dgcheques.KeyDown
        textidcheque.Text = dgcheques.Item("IdCheque", dgcheques.SelectedRows(0).Index).Value()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            'Dim cmd As New SqlCommand("update Vehiculos set Año= '" & tbAño.Text & "',Tipo='" & tbTipoVehiculo.Text & "',Motor='" & tbNroMotor.Text & "',Chasis='" & tbNroChasis.Text & "',Dominio='" & tbDominio.Text & "',IdModelo='" & tbIdModelo.Text & "',Color='" & tbColor.Text & "',Observaciones='" & tbObservacion.Text & "',FechaAlta='" & tbFechaAlta.Text & "',TipoMotor='" & cbTipoMotor.SelectedValue & "',PrecioVenta='" & tbVenta.Text & "',PrecioCosto='" & tbCosto.Text & "',PrecioGastos= '" & tbGastos.Text & "' where IdVehiculo= '" & tbIdVehiculo.Text & "'", CN)
            Dim cmd As New SqlCommand("update Cheques set IdCliente='" & textcodigoc.Text & "',ImporteCheque='" & textimportech.Text & "',FechaCheque='" & dtfechach.Value & "',IdSucursal='" & textids.Text & "',NumeroCheque='" & textnumeroch.Text & "',FechaRecibido='" & dtfecharecibido.Value & "',TitularCheque='" & texttitular.Text & "',EstadoCheque='" & ComboEstado.Text & "',Cuit='" & mecuit.Text & "',TipoCheque='" & Combotipo.Text & "',Entregadoa='" & textengregadoa.Text & "',DepositadoEn='" & textdepositadoen.Text & "',Comentario='" & textcomentario.Text & "'  where IdCheque = '" & textidcheque.Text & "'", CN)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Modificacion Efectuada")
            cargarDGcheques()
            LimpiarPantalla()
            bModificar.Enabled = False
            bEliminar.Enabled = False
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub textbuscar_TextChanged(sender As Object, e As EventArgs) Handles textbuscar.TextChanged



        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select idcheque,NumeroCheque,ImporteCheque,FechaCheque,NombreC,NombreBanco from Cheques ch,Sucursales s, Bancos b,Clientes c where ch.idcliente = c.idcliente and ch.idsucursal = S.idsucursal and S.idbanco = b.idbanco and (NombreC like  '" & textbuscar.Text & "%' or NumeroCheque like '" & textbuscar.Text & "%')  order by fechacheque asc", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgcheques.DataSource = dt




    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Try




            Dim res As MsgBoxResult
            res = MessageBox.Show("¿Esta seguro que desea eliminar?", "Atencion", MessageBoxButtons.YesNo)
            If res = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand("delete Cheques where IdCheque ='" & textidcheque.Text & "'", CN)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Eliminacion Efectuada")
                CN.Close()
                cargarDGcheques()
                bModificar.Enabled = False
                bEliminar.Enabled = False
                LimpiarPantalla()
            End If
        Catch ex As SqlException
            MessageBox.Show("No se puede eliminar consulte con el administrador", "Advertencia")
        End Try
    End Sub

    Private Sub textimportech_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textimportech.KeyPress
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


    Private Sub dgcheques_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcheques.CellContentClick

    End Sub

    Private Sub dgcheques_DoubleClick(sender As Object, e As EventArgs) Handles dgcheques.DoubleClick

    End Sub
End Class