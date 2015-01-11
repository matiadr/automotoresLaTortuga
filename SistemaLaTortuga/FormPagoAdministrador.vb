Imports System.Data.SqlClient
Public Class FormPagoAdministrador
    Public Sub CargarCuentas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Cuentas order by NombreCuenta", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        combocuenta.DataSource = ds
        combocuenta.ValueMember = "IdCuenta"
        combocuenta.DisplayMember = "NombreCuenta"
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
    
    Private Sub FormPagoAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBancos()
        CargarCuentas()
        combotipopago.SelectedIndex = 0
    End Sub

    Private Sub cargarCaja()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        'muestro los movimientos de caja egresos e ingresos
        Dim cmd As New SqlCommand("select Nombre, DetalleMovimiento, ImporteMovimientoIngreo, ImporteMovimientoEgreso from MovimientosDiarios  where fechamovimiento = '" & FormCaja.DTfecha.Value & "' order by IdMovimientoDiario ", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        FormCaja.DGcaja.DataSource = dt

        'calculo la suma de ingresos de esa fecha
        Dim cmdi As New SqlCommand("select sum(ImporteMovimientoIngreo) from MovimientosDiarios  where fechamovimiento = '" & FormCaja.DTfecha.Value & "'  ", CN)

        FormCaja.textingresos.Text = Conversion.Str(cmdi.ExecuteScalar)
        If FormCaja.textingresos.Text = "Null" Then
            FormCaja.textingresos.Text = 0
        Else
        End If



        'calculo la suma de ingresos de esa fecha
        Dim cmde As New SqlCommand("select sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento = '" & FormCaja.DTfecha.Value & "'  ", CN)

        FormCaja.textegresos.Text = Conversion.Str(cmde.ExecuteScalar)
        If FormCaja.textegresos.Text = "Null" Then
            FormCaja.textegresos.Text = 0
        Else
        End If


        'calculo el saldo de ingresos y egresos de esa fecha
        Dim cmds As New SqlCommand("select sum(ImporteMovimientoIngreo) - sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento = '" & FormCaja.DTfecha.Value & "' ", CN)

        FormCaja.textsaldo.Text = Conversion.Str(cmds.ExecuteScalar)
        If FormCaja.textsaldo.Text = "Null" Then
            FormCaja.textsaldo.Text = 0
        Else
        End If
        'calculo el saldo anterior, seria todo lo entrado menos lo salido hasta la fecha seleccionada

        Dim cmdsa As New SqlCommand("select sum(ImporteMovimientoIngreo) - sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento < '" & FormCaja.DTfecha.Value & "' ", CN)



        FormCaja.textanterior.Text = Conversion.Str(cmdsa.ExecuteScalar)
        If FormCaja.textanterior.Text = "Null" Then
            FormCaja.textanterior.Text = 0
        Else
        End If

        CN.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If textimporte.Text = "" Then
            MessageBox.Show("Debe ingresar un importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()


        'agrego tambien un registro en MOVIMIENTOS DIARIOS
        Dim cmde As New SqlCommand("insert into MovimientosDiarios values ('" & combocuenta.SelectedValue & "','" & textdetalle.Text & "', '" & FormCaja.DTfecha.Value & "', '" & Conversion.Val(textimporte.Text) & "', '" & 0 & "','" & 0 & "', '  " & "Administrador" & "', '" & "Administrador" & "')", CN)
        cmde.ExecuteNonQuery()

        'busco ahoar el id del movimiento cargado
        Dim max As New SqlCommand("select max(idMovimientoDiario) from MovimientosDiarios", CN)
        Dim id = max.ExecuteScalar()

        Dim cmd As New SqlCommand("insert into PagosAdministrador values ('" & textimporte.Text & "','" & FormCaja.DTfecha.Value & "', '" & combotipopago.Text & "', '" & textnumero.Text & "', '" & combobanco.SelectedValue & "', '" & id & "')", CN)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Pago Ingresado")


        cargarCaja()

        CN.Close()

        Me.Close()
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