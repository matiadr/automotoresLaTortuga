Imports System.Data.SqlClient
Public Class FormCaja





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormGastosVehiculo.Show()
    End Sub

    Private Sub cargarCaja()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()

        'muestro los movimientos de caja egresos e ingresos
        Dim cmd As New SqlCommand("select Nombre, DetalleMovimiento, ImporteMovimientoIngreo, ImporteMovimientoEgreso from MovimientosDiarios  where fechamovimiento = '" & DTfecha.Value & "' order by IdMovimientoDiario ", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGcaja.DataSource = dt

        'calculo la suma de ingresos de esa fecha
        Dim cmdi As New SqlCommand("select sum(ImporteMovimientoIngreo) from MovimientosDiarios  where fechamovimiento = '" & DTfecha.Value & "'  ", CN)
      
        textingresos.Text = Conversion.Str(cmdi.ExecuteScalar)
        If textingresos.Text = "Null" Then
            textingresos.Text = 0
        Else
        End If



        'calculo la suma de ingresos de esa fecha
        Dim cmde As New SqlCommand("select sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento = '" & DTfecha.Value & "'  ", CN)

        textegresos.Text = Conversion.Str(cmde.ExecuteScalar)
        If textegresos.Text = "Null" Then
            textegresos.Text = 0
        Else
        End If


        'calculo el saldo de ingresos y egresos de esa fecha
        Dim cmds As New SqlCommand("select sum(ImporteMovimientoIngreo) - sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento = '" & DTfecha.Value & "' ", CN)

        textsaldo.Text = Conversion.Str(cmds.ExecuteScalar)
        If textsaldo.Text = "Null" Then
            textsaldo.Text = 0
        Else
        End If
        'calculo el saldo anterior, seria todo lo entrado menos lo salido hasta la fecha seleccionada

        Dim cmdsa As New SqlCommand("select sum(ImporteMovimientoIngreo) - sum(ImporteMovimientoEgreso) from MovimientosDiarios  where fechamovimiento < '" & DTfecha.Value & "' ", CN)



        textanterior.Text = Conversion.Str(cmdsa.ExecuteScalar)
        If textanterior.Text = "Null" Then
            textanterior.Text = 0
        Else
        End If

        CN.Close()
    End Sub

    Private Sub FormCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcaja()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormIngresos.Show()
    End Sub

    Private Sub DTfecha_ValueChanged(sender As Object, e As EventArgs) Handles DTfecha.ValueChanged
        cargarCaja()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormPagoDocumentos.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FormPagoAdministrador.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormOtrosEgresos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPagoPlanes.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        Dim daDatos As New SqlDataAdapter  ' Objeto Adaptador para leer datos de la Base de datos
        Dim dtDatos As New DataSet  ' datatable para recibir los datos de la base de datos
        CN.Open()
        Dim seleccion As String = "select DetalleMovimiento as Detalle,Nombre,ImporteMovimientoingreo as Ingreso,ImporteMovimientoegreso as Egreso from MovimientosDiarios where FechaMovimiento = '" & DTfecha.Value & "'"
        daDatos = New SqlDataAdapter(seleccion, CN)
        daDatos.Fill(dtDatos, "MovimientoDiario")
        CN.Close()
        Dim rpt As reporteMovDiario = New reporteMovDiario
        rpt.SetDataSource(dtDatos)
        rpt.SetParameterValue("fecha", DTfecha.Value)
        FormReporteMovDiario.viewerReporteMovDiario.ReportSource = rpt
        FormReporteMovDiario.Show()
    End Sub
End Class