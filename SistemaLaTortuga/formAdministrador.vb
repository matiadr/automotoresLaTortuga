Imports System.Data.SqlClient
Public Class formadministrador

    Private Sub Bguardar_Click(sender As Object, e As EventArgs) Handles Bguardar.Click
        'Try
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into Administrador (importeadministrador,idVenta,Fecha,idcomprador, idcuenta) values ('" & textimporte.Text & "','" & formVentas.textidventa.Text & "','" & DTfecha.Value & "','" & formVentas.tbIdCliente.Text & "', '" & ComboCuentas.SelectedValue & "')", CN)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Entrega Ingresada")


        Dim suma As New SqlCommand("Select sum(importeadministrador) from Administrador where Idventa = '" & formVentas.textidventa.Text & "' ", CN)

        formVentas.TextAdministrador.Text = suma.ExecuteScalar()

        'Catch ex As SqlException
        'MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
        'End Try

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
    Private Sub formadministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCuentas()

        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
       




        Dim suma As New SqlCommand("Select sum(importeadministrador) from Administrador where Idventa = '" & formVentas.textidventa.Text & "' ", CN)
        textimporte.Text = suma.ExecuteScalar()
        CN.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formCuentas.ShowDialog()
    End Sub
End Class