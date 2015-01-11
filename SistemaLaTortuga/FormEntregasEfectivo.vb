Imports System.Data.SqlClient
Public Class FormEntregasEfectivo
    Public Sub CargarCuentas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Cuentas order by NombreCuenta", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        ComboCuentas.DataSource = ds
        ComboCuentas.ValueMember = "IdCuenta"
        ComboCuentas.DisplayMember = "NombreCuenta"
    End Sub
    Public Sub CargarBancos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Bancos order by NombreBanco", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        combobanco.DataSource = ds
        combobanco.ValueMember = "IdBanco"
        combobanco.DisplayMember = "NombreBanco"
    End Sub
    
    Private Sub FormEntregasEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBancos()
        CargarCuentas()
        CargarDGEntregas()
    End Sub
    Private Sub CargarDGEntregas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select ImporteEntrega,FechaEntrega,FormaPago from Entregas where IdVenta = '" & formVentas.textidventa.Text & "'", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        Dgentregas.DataSource = dt
        CN.Close()
    End Sub
   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formCuentas.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Bguardar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Entregas (IdVenta,FormaPago,ImporteEntrega,FechaEntrega,NumeroTransaccion,IdSucursal,Idcuenta) values ('" & formVentas.textidventa.Text & "','" & Combotipopago.Text & "','" & textimporte.Text & "','" & DTfechaentrega.Value & "','" & textnumero.Text & "','" & combobanco.SelectedValue & "','" & ComboCuentas.SelectedValue & "')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Entrega Ingresada")
            CargarDGEntregas()

            Dim suma As New SqlCommand("Select sum(importeentrega) from Entregas where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

            formVentas.textsumaentrega.Text = suma.ExecuteScalar()

            'debo agregar esto que entrega en efectivo en la CAJA, a la tabla Movimientos
            Dim ent As New SqlCommand("insert into MovimientosDiarios (IdCuenta,DetalleMovimiento,FechaMovimiento,ImporteMovimientoIngreo,ImporteMovimientoEgreso,IdProveedor, Tipo, Nombre) values ('" & ComboCuentas.SelectedValue & "',  '" & Combotipopago.Text & "','" & formVentas.dtfecha.Value & "','" & textimporte.Text & "','" & 0 & "','" & formVentas.tbIdCliente.Text & "', 'Cliente', '" & formVentas.tbNombre.Text & "')", CN)
            ent.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
        End Try



    End Sub

    Private Sub combobanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobanco.SelectedIndexChanged
        textidbanco.Text = combobanco.SelectedValue
    End Sub

    Private Sub textimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textimporte.KeyPress
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

    Private Sub textimporte_TextChanged(sender As Object, e As EventArgs) Handles textimporte.TextChanged

    End Sub
End Class