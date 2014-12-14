Imports System.Data.SqlClient
Public Class FormGastosVehiculo
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
    Public Sub CargarProveedores()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Proveedroes order by NombreProveedor", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        Comboproveedor.DataSource = ds
        Comboproveedor.ValueMember = "IdBanco"
        Comboproveedor.DisplayMember = "NombreBanco"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("insert into GastosVehiculos values ('" & textidvehiculo.Text & "','" & combocuenta.SelectedValue & "', '" & textdetalle.Text & "', '" & textimporte.Text & "', '" & FormCaja.DTfecha.Value & "', '" & Comboproveedor.SelectedValue & "')", CN)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Gasto Agregado")

        'agrego tambien un registro en MOVIMIENTOS DIARIOS
        Dim cmde As New SqlCommand("insert into MovimientosDiarios values ('" & combocuenta.SelectedValue & "','" & textdetalle.Text & "', '" & FormCaja.DTfecha.Value & "', '" & 0 & "', '" & textimporte.Text & "', '" & FormCaja.DTfecha.Value & "', '" & Comboproveedor.SelectedValue & "')", CN)
        cmde.ExecuteNonQuery()
        CN.Close()

        Me.Close()
    End Sub

    
    Private Sub FormGastosVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBancos()
        CargarCuentas()
        cargarProveedores()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formbuscavehiculoactivo.Show()
    End Sub
End Class