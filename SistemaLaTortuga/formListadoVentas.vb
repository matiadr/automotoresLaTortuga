Imports System.Data.SqlClient
Public Class formlistadoventas

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cargarventas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Ventas v, Clientes c, Vehiculos ve, Marcas ma, Modelos mo  where v.idvehiculoventa = ve.idvehiculo and v.idcomprador = c.idcliente and ve.idmodelo = mo.idmodelo and mo.idmarca = ma.idmarca order by FechaVenta desc", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGventas.DataSource = dt
        CN.Close()
    End Sub
    Private Sub formlistadoventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarventas()
    End Sub



    Private Sub DGventas_Click(sender As Object, e As EventArgs) Handles DGventas.Click
        textidventa.Text = DGventas.Item("idVenta", DGventas.SelectedRows(0).Index).Value()

        formVentas.Show()
    End Sub

    Public Sub cargarentregas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select v.IdVehiculo,NombreMarca,NombreModelo,Tipo,Año,Dominio, precioe from Vehiculos v,Modelos m,Marcas ma, vehiculosentregas ve where v.IdModelo=m.IdModelo and m.IdMarca=ma.IdMarca and v.idvehiculo = ve.idvehiculo and idventa = '" & formVentas.textidventa.Text & "' order by NombreMarca,NombreModelo", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        formVentas.DGentregas.DataSource = dt
        CN.Close()
    End Sub
    Private Sub textidventa_TextChanged(sender As Object, e As EventArgs) Handles textidventa.TextChanged
        'cargo el id de cliente para que muestre los datos personales
        formVentas.textidclientem.Text = DGventas.Item("idCliente", DGventas.SelectedRows(0).Index).Value()
        formVentas.textidventa.Text = textidventa.Text
        'que muestre los datos de la esposa/o si lo tuviese en ese momento de la tabla ventas y no de clientes, ya
        'que pudo haber cambiado

        'ahora muestro los datos del vehiculo pero con el precio de venta que figura en la tabla VENTA
        formVentas.textidvehiculoventam.Text = DGventas.Item("idVehiculoVenta", DGventas.SelectedRows(0).Index).Value()

        'muestro si hubo vehiculos entregados
        cargarentregas()

        'si hubo entregas en efectivo
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim suma As New SqlCommand("Select sum(importeentrega) from Entregas where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

        formVentas.textsumaentrega.Text = suma.ExecuteScalar()

        'si hubo credito
        Dim CNa As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CNa)
        miConexion.Open()
        Dim seleccion As String = "select * from Creditos, Bancos where IdVenta ='" & formVentas.textidventa.Text & "' and Creditos.IdBanco = Bancos.IdBanco"
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CNa)
        tabla2 = New DataTable
        da.Fill(tabla2)
     


        formVentas.textcredsolicitado.Text = tabla2.Rows.Item(0).Item("ImporteSolicitado")

        formVentas.textcredotorgado.Text = tabla2.Rows.Item(0).Item("ImporteOtorgado")











        'si hubo documentos
        Dim sumad As New SqlCommand("Select sum(importedocumento) from Documentos where Idventa = '" & formVentas.textidventa.Text & "' ", CN)


        formVentas.textsumadocumentos.Text = Conversion.Str(sumad.ExecuteScalar)
        If formVentas.textsumadocumentos.Text = "Null" Then
            formVentas.textsumadocumentos.Text = 0
        Else
        End If

        'si hubo plan


        Dim seleccionp As String = "select * from planes where IdVenta ='" & formVentas.textidventa.Text & "' "
        Dim tabla3 As DataTable
        Dim da3 As SqlDataAdapter
        da3 = New SqlDataAdapter(seleccionp, CNa)
        tabla3 = New DataTable
        da3.Fill(tabla3)

        Try


            formVentas.TextDetallePlan.Text = tabla3.Rows.Item(0).Item("DetallePlan")
            formVentas.TextCuotas.Text = tabla3.Rows.Item(0).Item("CantidadCuotas")
            formVentas.TextIntereses.Text = tabla3.Rows.Item(0).Item("Intereses")
            formVentas.TextMeses.Text = tabla3.Rows.Item(0).Item("MesesEntreCuotas")
            formVentas.DTprimeraCuota.Value = tabla3.Rows.Item(0).Item("FechaPrimerCuota")
            formVentas.TextValorCuota.Text = tabla3.Rows.Item(0).Item("ValorCuota")
            formVentas.TextImporteTotal.Text = tabla3.Rows.Item(0).Item("ImporteTotal")
            If tabla3.Rows.Item(0).Item("Cancelado") = True Then
                formVentas.ChkCancelado.Checked = True
            Else
                formVentas.ChkCancelado.Checked = False
            End If
            formVentas.textidplan.Text = tabla3.Rows.Item(0).Item("IdPlan")










            Dim sumap As New SqlCommand("Select sum(importefinanciadoplan) from Planes where Idventa = '" & formVentas.textidventa.Text & "' ", CN)


            formVentas.TextPlan.Text = Conversion.Str(sumap.ExecuteScalar)
            If formVentas.TextPlan.Text = "Null" Then
                formVentas.TextPlan.Text = 0
            Else
            End If





            'si hubo administrador
            Dim sumas As New SqlCommand("Select sum(importeadministrador) from Administrador where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

            formVentas.TextAdministrador.Text = Conversion.Str(sumas.ExecuteScalar)
            If formVentas.TextAdministrador.Text = "Null" Then
                formVentas.TextAdministrador.Text = 0
            Else
            End If
        Catch ex As SqlException

        End Try

    End Sub

    Private Sub DGventas_ClientSizeChanged(sender As Object, e As EventArgs) Handles DGventas.ClientSizeChanged

    End Sub
End Class