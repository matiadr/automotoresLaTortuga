Imports System.Data.SqlClient
Public Class formcreditos
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

    Private Sub CargarCreditos()
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        miConexion.Open()
        Dim seleccion As String = "select * from Creditos, Bancos where IdVenta ='" & formVentas.textidventa.Text & "' and Creditos.IdBanco = Bancos.IdBanco"
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        DTfechacredito.Value = tabla2.Rows.Item(0).Item("Fecha")
        textsolicitado.Text = tabla2.Rows.Item(0).Item("ImporteSolicitado")
        combobanco.Text = tabla2.Rows.Item(0).Item("NombreBanco")
        DTfechaotorgado.Value = tabla2.Rows.Item(0).Item("FechaOtorgado")
        textotorgado.Text = tabla2.Rows.Item(0).Item("ImporteOtorgado")
        textnumerocredito.Text = tabla2.Rows.Item(0).Item("NumeroCredito")



    End Sub

    Private Sub formcreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBancos()
        CargarCuentas()
        CargarCreditos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Bguardar_Click(sender As Object, e As EventArgs) Handles Bguardar.Click
        Dim venta As Integer = formVentas.textidventa.Text
        

        If textidcredito.Text = "" Then


            Try
                Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
                CN.Open()



                Dim cmd As New SqlCommand("insert into Creditos (Fecha,IdVenta,ImporteSolicitado,IdBanco) values ('" & DTfechacredito.Value & "','" & venta & "','" & Conversion.Val(textsolicitado.Text) & "','" & combobanco.SelectedValue & "')", CN)
                cmd.ExecuteNonQuery()

                formVentas.textcredsolicitado.Text = textsolicitado.Text
                formVentas.textcredotorgado.Text = textotorgado.Text




            Catch ex As SqlException
                MessageBox.Show("No se pudo realizar la operacion,intente mas tarde", "Advertencia-Error en la base de datos,")
            End Try

        Else ' modifico

            Dim CNN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CNN.Open()

            Dim cmde As New SqlCommand("update into Creditos (Fecha,IdVenta,ImporteSolicitado,IdBanco,FechaOtorgado,ImporteOtorgado,NumeroCredito) values ('" & DTfechacredito.Value & "','" & venta & "','" & Conversion.Val(textsolicitado.Text) & "','" & combobanco.SelectedValue & "', '" & DTfechaotorgado.Value & "', '" & Conversion.Val(textotorgado.Text) & "', '" & Conversion.Val(textnumerocredito.Text & "') "), CNN)
            cmde.ExecuteNonQuery()

            formVentas.textcredsolicitado.Text = textsolicitado.Text
            formVentas.textcredotorgado.Text = textotorgado.Text
        End If

        Me.Close()
    End Sub
End Class