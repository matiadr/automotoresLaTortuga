Imports System.Data.SqlClient
Public Class formCuentas

    Private Sub bNuevoRubro_Click(sender As Object, e As EventArgs) Handles bNuevoRubro.Click
        formABMRubros.Show()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub cargarDGCuentas()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdCuenta,r.IdRubro,NombreCuenta,NombreRubro,SaldoCuenta,DetalleCuenta,TipoCuenta from Cuentas c,Rubros r where c.IdRubro=r.IdRubro order by NombreCuenta,NombreRubro", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgCuentas.DataSource = dt
        CN.Close()
    End Sub

    Public Sub cargarCBRubros()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Rubros order by NombreRubro", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        da.Fill(ds)
        CN.Close()
        cbRubro.DataSource = ds
        cbRubro.ValueMember = "IdRubro"
        cbRubro.DisplayMember = "NombreRubro"
    End Sub

    Private Sub formCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDGCuentas()
        cargarCBRubros()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim tipoCuenta As Integer
            If rbResta.Checked = True Then
                tipoCuenta = -1
            Else
                tipoCuenta = 1
            End If
            Dim cmd As New SqlCommand("insert into Cuentas (NombreCuenta,TipoCuenta,DetalleCuenta,SaldoCuenta,IdRubro) values ('" & tbNombre.Text & "','" & tipoCuenta & "','" & tbDetalleCuenta.Text & "','" & tbSaldo.Text & "','" & cbRubro.SelectedValue & "')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cuenta Agregada")
            cargarDGCuentas()
            limpiarPantalla()
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub limpiarPantalla()
        tbIdCuenta.Text = ""
        tbDetalleCuenta.Text = ""
        tbNombre.Text = ""
        tbSaldo.Text = ""
    End Sub

    Private Sub dgCuentas_Click(sender As Object, e As EventArgs) Handles dgCuentas.Click, dgCuentas.KeyDown, dgCuentas.KeyUp
        If dgCuentas.RowCount > 0 Then
            tbIdCuenta.Text = dgCuentas.Item("idCuenta", dgCuentas.SelectedRows(0).Index).Value()
            tbNombre.Text = dgCuentas.Item("nombre", dgCuentas.SelectedRows(0).Index).Value()
            tbSaldo.Text = Replace(dgCuentas.Item("saldo", dgCuentas.SelectedRows(0).Index).Value(), ",", ".")
            tbDetalleCuenta.Text = dgCuentas.Item("detalleCuenta", dgCuentas.SelectedRows(0).Index).Value()
            cbRubro.SelectedValue = dgCuentas.Item("idRubro", dgCuentas.SelectedRows(0).Index).Value()
            If dgCuentas.Item("tipoCuenta", dgCuentas.SelectedRows(0).Index).Value() = 1 Then
                rbSuma.Checked = True
            Else
                rbResta.Checked = True
            End If
            bModificar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        limpiarPantalla()
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim tipoCuenta As Integer
            If rbResta.Checked = True Then
                tipoCuenta = -1
            Else
                tipoCuenta = 1
            End If
            Dim cmd As New SqlCommand("update Cuentas set NombreCuenta= '" & tbNombre.Text & "',DetalleCuenta='" & tbDetalleCuenta.Text & "',SaldoCuenta='" & tbSaldo.Text & "',IdRubro='" & cbRubro.SelectedValue & "',TipoCuenta='" & tipoCuenta & "' where IdCuenta= '" & tbIdCuenta.Text & "'", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modificacion Efectuada")
            cargarDGCuentas()
            limpiarPantalla()
            bModificar.Enabled = False
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String
        If rbNombreCuenta.Checked = True Then
            seleccion = "select IdCuenta,r.IdRubro,NombreCuenta,NombreRubro,SaldoCuenta,DetalleCuenta,TipoCuenta from Cuentas c,Rubros r where c.IdRubro=r.IdRubro and NombreCuenta like '" & tbBusqueda.Text & "%' order by NombreCuenta,NombreRubro"
        Else
            seleccion = "select IdCuenta,r.IdRubro,NombreCuenta,NombreRubro,SaldoCuenta,DetalleCuenta,TipoCuenta from Cuentas c,Rubros r where c.IdRubro=r.IdRubro and NombreRubro like '" & tbBusqueda.Text & "%' order by NombreCuenta,NombreRubro"
        End If
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgCuentas.DataSource = tabla2
        miConexion.Close()
    End Sub


    Private Sub tbSalgo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSaldo.KeyPress
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

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged, tbSaldo.TextChanged
        If tbNombre.Text.Length > 0 And tbSaldo.Text.Length > 0 And tbIdCuenta.Text = "" Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub
End Class