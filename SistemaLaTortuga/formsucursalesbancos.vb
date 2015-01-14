Imports System.Data.SqlClient
Public Class formsucursalesbancos

    Public Sub cargarsucursales()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdSucursal,CodigoSucursal,NombreSucursal,CodigoBanco,NombreBanco from Sucursales s,Bancos B where s.idbanco = b.idbanco order by NombreBanco,nombresucursal", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgsucursalesb.DataSource = dt
        CN.Close()
    End Sub
    Private Sub formsucursalesbancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarsucursales()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub bNuevoCliente_Click_1(sender As Object, e As EventArgs) Handles bNuevoCliente.Click
        formABMSucursales.Show()
    End Sub

  

    Private Sub dgsucursalesb_DoubleClick(sender As Object, e As EventArgs) Handles dgsucursalesb.DoubleClick
        If textform.Text = "ch" Then
            formCheques.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
            formCheques.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
            formCheques.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
            formCheques.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
            formCheques.textids.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
        Else
            If textform.Text = "ee" Then
                ' FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                FormEntregasEfectivo.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                FormEntregasEfectivo.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
            End If
            If textform.Text = "gv" Then
                ' FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                FormGastosVehiculo.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                FormGastosVehiculo.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                FormGastosVehiculo.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()

            Else
                If textform.Text = "oe" Then
                    ' FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                    FormOtrosEgresos.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                    ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                    FormOtrosEgresos.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                    FormOtrosEgresos.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                Else
                    If textform.Text = "pd" Then
                        ' FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                        FormPagarDocumento.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                        ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                        FormPagarDocumento.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                        FormPagarDocumento.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                    Else
                        If textform.Text = "pa" Then
                            ' FormEntregasEfectivo.textidsucursal.Text = dgsucursalesb.Item("CodigoSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                            FormPagoAdministrador.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                            ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                            FormPagoAdministrador.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                            FormPagoAdministrador.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                        Else
                            If textform.Text = "pcu" Then
                                FormPagoCuotas.textnombres.Text = dgsucursalesb.Item("NombreSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                                ' FormEntregasEfectivo.textidbanco.Text = dgsucursalesb.Item("CodigoBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                                FormPagoCuotas.textnombreb.Text = dgsucursalesb.Item("NombreBanco", dgsucursalesb.SelectedRows(0).Index).Value()
                                FormPagoCuotas.textidsucursal.Text = dgsucursalesb.Item("IdSucursal", dgsucursalesb.SelectedRows(0).Index).Value()
                            End If
                        End If
                    End If
                End If
            End If

        End If
        Me.Close()
    End Sub

   
 
    Private Sub dgsucursalesb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgsucursalesb.CellContentClick

    End Sub
End Class