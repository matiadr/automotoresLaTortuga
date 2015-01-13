﻿Imports System.Data.SqlClient
Public Class formBuscarCliente


    Private Sub formBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGClientes()
    End Sub

    Public Sub cargarDGClientes()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdCliente,NombreC,NumeroDni from Clientes order by NombreC", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgClientes.DataSource = dt
        CN.Close()
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String = "select IdCliente,NombreC,NumeroDni from Clientes where NombreC like '" & tbBusqueda.Text & "%' or NumeroDni like '" & tbBusqueda.Text & "%' order by NombreC" 'Busco por Nombre
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgClientes.DataSource = tabla2
        miConexion.Close()
    End Sub

    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgClientes.DoubleClick
        If textform.Text = "v" Then
            formVehiculos.textidcliente.Text = dgClientes.Item("idCliente", dgClientes.SelectedRows(0).Index).Value()
            formVehiculos.textnombre.Text = dgClientes.Item("Nombre", dgClientes.SelectedRows(0).Index).Value()
            formVehiculos.Button2.Enabled = True
        Else
            If textform.Text = "ch" Then
                formCheques.textcodigoc.Text = dgClientes.Item("idCliente", dgClientes.SelectedRows(0).Index).Value()
                formCheques.textnombrec.Text = dgClientes.Item("Nombre", dgClientes.SelectedRows(0).Index).Value()
            Else
                If textform.Text = "ve" Then
                    formVentas.tbIdCliente.Text = dgClientes.Item("idCliente", dgClientes.SelectedRows(0).Index).Value()

                End If
            End If
        End If
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class