Imports System.Data.SqlClient
Public Class FormPagarDocumento
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
    Private Sub FormPagarDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBancos()
        CargarCuentas()
        ComboTipo.SelectedIndex = 0
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

    Private Sub cargarpagos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        Dim doc As Integer
        doc = Conversion.Int(FormPagoDocumentos.textid.Text)

        Dim cmd As New SqlCommand("select IdDocumento,FechaPago, ImportePago, FormaPago, NumeroTransaccion,NombreSucursal,NombreBanco From PagosDocumentos, Sucursales, Bancos where IdDocumento = '" & doc & "' and Sucursales.idbanco = Bancos.IdBanco and PagosDocumentos.IdSucursal = Sucursales.IdSucursal ", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        FormPagoDocumentos.DGpagos.DataSource = dt


        CN.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextImporte.Text = "" Then
            MessageBox.Show("Debe ingresar un importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()


            'agrego tambien un registro en MOVIMIENTOS DIARIOS
            Dim cmde As New SqlCommand("insert into MovimientosDiarios values ('" & combocuenta.SelectedValue & "','" & "Pago Documento" & "', '" & Dtfecha.Value & "', '" & TextImporte.Text & "', '" & 0 & "','" & FormPagoDocumentos.ComboCliente.SelectedValue & "', '  " & "Cliente" & "', '" & FormPagoDocumentos.ComboCliente.Text & "')", CN)
            cmde.ExecuteNonQuery()

            'busco ahoar el id del movimiento cargado
            Dim max As New SqlCommand("select max(idMovimientoDiario) from MovimientosDiarios", CN)
            Dim id = max.ExecuteScalar()

            Dim cmd As New SqlCommand("insert into PagosDocumentos values ('" & FormPagoDocumentos.textid.Text & "','" & Dtfecha.Value & "', '" & TextImporte.Text & "', '" & combocuenta.SelectedValue & "', '" & ComboTipo.Text & "', '" & Textnumero.Text & "', '" & ComboBanco.SelectedValue & "', '" & id & "' )", CN)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Pago Ingresado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cargarCaja()
            cargarpagos()
            CN.Close()

            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'lo que hago es modificar el registro del documento y al campo PAGADO le escribo SI
        Dim res As MsgBoxResult
        res = MessageBox.Show("¿Está seguro que va a pagar la totalidad del documento?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = MsgBoxResult.Yes Then
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()


            'modifico el campo pagado

            If CheckBox1.Checked = True Then
                Dim cmde As New SqlCommand("update documentos set Pagado ='" & "Si" & "' where iddocumento = '" & FormPagoDocumentos.textid.Text & "' ", CN)
                cmde.ExecuteNonQuery()
            Else
                Dim cmde As New SqlCommand("update documentos set Pagado ='" & "No" & "' where iddocumento = '" & FormPagoDocumentos.textid.Text & "' ", CN)
                cmde.ExecuteNonQuery()
            End If
            CN.Close()

            Me.Close()
        End If
    End Sub

    Private Sub TextImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte.KeyPress
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

    Private Sub TextImporte_TextChanged(sender As Object, e As EventArgs) Handles TextImporte.TextChanged

    End Sub
End Class