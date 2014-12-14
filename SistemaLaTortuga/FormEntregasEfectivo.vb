﻿Imports System.Data.SqlClient
Public Class FormEntregasEfectivo
    Public Sub CargarCuentas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Cuentas order by NombreCuenta", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        ComboCuentas.DataSource = ds.Tables(0)
        ComboCuentas.ValueMember = "IdCuenta"
        ComboCuentas.DisplayMember = "NombreCuenta"
    End Sub
    Public Sub CargarBancos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Bancos order by NombreBanco", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        combobanco.DataSource = ds.Tables(0)
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
        ' Try
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Entregas (IdVenta,FormaPago,ImporteEntrega,FechaEntrega,NumeroTransaccion,IdSucursal,Idcuenta) values ('" & formVentas.textidventa.Text & "','" & Combotipopago.Text & "','" & textimporte.Text & "','" & DTfechaentrega.Value & "','" & textnumero.Text & "','" & combobanco.SelectedValue & "','" & ComboCuentas.SelectedValue & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Entrega Ingresada")
        CargarDGEntregas()

        Dim suma As New SqlCommand("Select sum(importeentrega) from Entregas where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

        formVentas.textsumaentrega.Text = suma.ExecuteScalar()

        'Catch ex As SqlException
        'MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
        'End Try



    End Sub

    Private Sub combobanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobanco.SelectedIndexChanged
        textidbanco.Text = combobanco.SelectedValue
    End Sub
End Class