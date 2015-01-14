﻿Imports System.Data.SqlClient
Public Class FormDocumentos

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formCuentas.Show()
    End Sub

    Private Sub CargarDGdocumentos()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select ImporteDocumento,FechaDocumento from Documentos where IdVenta = '" & formVentas.textidventa.Text & "'", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        DGdocumentos.DataSource = dt
        CN.Close()
    End Sub
    Private Sub FormDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCuentas()
        CargarDGdocumentos()
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Documentos (IdVenta,ImporteDocumento,FechaDocumento,IdCuenta,Pagado) values ('" & formVentas.textidventa.Text & "','" & textimported.Text & "','" & DTfechadocumento.Value & "','" & ComboCuentas.SelectedValue & "', 'No')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Entrega Ingresada")
            CargarDGdocumentos()

            Dim suma As New SqlCommand("Select sum(importedocumento) from Documentos where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

            formVentas.textsumadocumentos.Text = suma.ExecuteScalar()

        Catch ex As SqlException
            MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
        End Try
       

    End Sub

    Private Sub textimported_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textimported.KeyPress
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

    Private Sub textimported_TextChanged(sender As Object, e As EventArgs) Handles textimported.TextChanged

    End Sub
End Class