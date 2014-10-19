Imports System.Data.SqlClient

Public Class formClientes

    Private Sub b_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bABMProvincia.Click
        formABMProvincia.Show()
    End Sub


    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged, tbDomicilio.TextChanged, tbDocumento.TextChanged
        If tbNombre.Text.Length > 0 And tbDocumento.Text.Length > 0 And tbDomicilio.Text.Length > 0 Then
            bNuevo.Enabled = True
        Else
            bNuevo.Enabled = False
        End If
    End Sub

    Private Sub bNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles bNuevaLocalidad.Click
        formABMLocalidad.Show()
    End Sub

    Private Sub cargarDGClientes()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Clientes c,Localidades l,Provincias p where c.IdLocalidad=l.IdLocalidad and l.IdProvincia=p.IdProvincia order by NombreC", CN)
        Dim lista As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable()
        dt.Load(lista)
        dgClientes.DataSource = dt
        CN.Close()
    End Sub

    Private Sub cargarComboBoxs()
        Dim tipoDni As New DataTable
        tipoDni.Columns.Add("codigo", GetType(Integer))
        tipoDni.Columns.Add("descripcion", GetType(String))
        tipoDni.Rows.Add(New Object() {0, "DU"})
        tipoDni.Rows.Add(New Object() {1, "LC"})
        tipoDni.Rows.Add(New Object() {2, "LE"})
        tipoDni.AcceptChanges()
        cbTipoDoc.DataSource = tipoDni
        cbTipoDoc.ValueMember = "descripcion"
        cbTipoDoc.DisplayMember = "descripcion"

        ''Seleccionamos el tipoDni inicial.
        cbTipoDoc.SelectedIndex = 0

        cbTipoDocConyuge.DataSource = tipoDni
        cbTipoDocConyuge.ValueMember = "descripcion"
        cbTipoDocConyuge.DisplayMember = "descripcion"
        cbTipoDocConyuge.SelectedIndex = 0


        Dim estadoCivil As New DataTable
        estadoCivil.Columns.Add("codigo", GetType(Integer))
        estadoCivil.Columns.Add("descripcion", GetType(String))
        estadoCivil.Rows.Add(New Object() {0, "SOLTERO/A"})
        estadoCivil.Rows.Add(New Object() {1, "CASADO/A"})
        estadoCivil.Rows.Add(New Object() {2, "SEPARADO/A"})
        estadoCivil.Rows.Add(New Object() {3, "DIVORCIADO/A"})
        estadoCivil.Rows.Add(New Object() {4, "VIUDO/A"})
        estadoCivil.Rows.Add(New Object() {5, "OTRO"})
        estadoCivil.AcceptChanges()
        cbEstadoCivil.DataSource = estadoCivil
        cbEstadoCivil.ValueMember = "descripcion"
        cbEstadoCivil.DisplayMember = "descripcion"

        'Seleccionamos el estado civil inicial.
        cbTipoDoc.SelectedIndex = 0

        Dim tipoIva As New DataTable
        tipoIva.Columns.Add("codigo", GetType(Integer))
        tipoIva.Columns.Add("descripcion", GetType(String))
        tipoIva.Rows.Add(New Object() {0, "MONOTRIBUTO"})
        tipoIva.Rows.Add(New Object() {1, "R.INSCRIPTO"})
        tipoIva.Rows.Add(New Object() {2, "C.FINAL"})
        tipoIva.Rows.Add(New Object() {3, "EXENTO"})
        tipoIva.AcceptChanges()
        cbTipoIva.DataSource = tipoIva
        cbTipoIva.ValueMember = "descripcion"
        cbTipoIva.DisplayMember = "descripcion"

        'Seleccionamos el tipoIva inicial.
        cbTipoIva.SelectedIndex = 2
    End Sub

    Private Sub formClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboBoxs()
        cargarDGClientes()
        cargarCBProvincias()
        tbIdProvincia.Text = cbProvincia.SelectedValue.ToString
        cargarCBLocalidades(tbIdProvincia.Text)
    End Sub



    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("insert into Clientes (NombreC,TipoDni,NumeroDni,Domicilio,FechaNacimiento,IdLocalidad,Cuit,EstadoCivil,Telefono,Email,TipoIva,Ocupacion,NombreCConyuge,DniConyuge,TipoDniConyuge) values ('" & tbNombre.Text & "','" & cbTipoDoc.SelectedValue & "','" & tbDocumento.Text & "','" & tbDomicilio.Text & "','" & tbFechaNac.Text & "','" & tbIdLocalidad.Text & "','" & tbCuit.Text & "','" & cbEstadoCivil.SelectedValue & "','" & tbTelefono.Text & "','" & tbEmail.Text & "','" & cbTipoIva.SelectedValue & "','" & tbOcupacion.Text & "','" & tbNombreConyuge.Text & "','" & tbDocumentoConyuge.Text & "','" & cbTipoDocConyuge.SelectedValue & "')", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente Agregado")
            cargarDGClientes()
            limpiarPantalla()
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub

    Private Sub limpiarPantalla()
        tbNombre.Text = ""
        tbFechaNac.Text = ""
        tbEmail.Text = ""
        tbOcupacion.Text = ""
        tbCuit.Text = ""
        tbDocumento.Text = ""
        tbDomicilio.Text = ""
        tbTelefono.Text = ""
        tbIdCliente.Text = ""
        tbNombreConyuge.Text = ""
        tbDocumentoConyuge.Text = ""
        cbEstadoCivil.SelectedIndex = 0
    End Sub

    Public Sub cargarCBProvincias()
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select * from Provincias order by NombreProvincia", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        cbProvincia.DataSource = ds.Tables(0)
        cbProvincia.ValueMember = "IdProvincia"
        cbProvincia.DisplayMember = "NombreProvincia"
    End Sub

    Public Sub cargarCBLocalidades(id As String)
        Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
        CN.Open()
        Dim cmd As New SqlCommand("select IdLocalidad,NombreLocalidad from Localidades where IdProvincia='" & id & "' order by NombreLocalidad", CN)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        CN.Close()
        cbLocalidad.DataSource = ds.Tables(0)
        cbLocalidad.ValueMember = "IdLocalidad"
        cbLocalidad.DisplayMember = "NombreLocalidad"
    End Sub


    Private Sub cbProvincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProvincia.SelectionChangeCommitted
        tbIdProvincia.Text = cbProvincia.SelectedValue.ToString
        cargarCBLocalidades(tbIdProvincia.Text)
    End Sub


    Private Sub cbLocalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLocalidad.SelectedIndexChanged
        tbIdLocalidad.Text = cbLocalidad.SelectedValue.ToString
    End Sub


    Private Sub dgClientes_Click(sender As Object, e As EventArgs) Handles dgClientes.Click, dgClientes.KeyDown, dgClientes.KeyUp
        If dgClientes.RowCount > 0 Then
            tbIdCliente.Text = dgClientes.Item("idCliente", dgClientes.SelectedRows(0).Index).Value()
            tbNombre.Text = dgClientes.Item("nombre", dgClientes.SelectedRows(0).Index).Value()
            tbFechaNac.Text = dgClientes.Item("fechaNacimiento", dgClientes.SelectedRows(0).Index).Value()
            tbEmail.Text = dgClientes.Item("email", dgClientes.SelectedRows(0).Index).Value()
            tbOcupacion.Text = dgClientes.Item("ocupacion", dgClientes.SelectedRows(0).Index).Value()
            tbCuit.Text = dgClientes.Item("cuit", dgClientes.SelectedRows(0).Index).Value()
            tbDocumento.Text = dgClientes.Item("Documento", dgClientes.SelectedRows(0).Index).Value()
            tbDomicilio.Text = dgClientes.Item("Domicilio", dgClientes.SelectedRows(0).Index).Value()
            tbTelefono.Text = dgClientes.Item("telefono", dgClientes.SelectedRows(0).Index).Value()
            tbIdProvincia.Text = dgClientes.Item("idProvincia", dgClientes.SelectedRows(0).Index).Value()
            cbProvincia.SelectedValue = tbIdProvincia.Text
            cargarCBLocalidades(tbIdProvincia.Text)
            cbLocalidad.SelectedValue = dgClientes.Item("idLocalidad", dgClientes.SelectedRows(0).Index).Value()
            cbEstadoCivil.SelectedValue = dgClientes.Item("estadoCivil", dgClientes.SelectedRows(0).Index).Value().ToString
            cbTipoDoc.SelectedValue = dgClientes.Item("tipoDni", dgClientes.SelectedRows(0).Index).Value().ToString
            cbTipoIva.SelectedValue = dgClientes.Item("tipoIva", dgClientes.SelectedRows(0).Index).Value().ToString
            cbTipoDocConyuge.SelectedValue = dgClientes.Item("tipoDniConyuge", dgClientes.SelectedRows(0).Index).Value().ToString
            tbNombreConyuge.Text = dgClientes.Item("nombreConyuge", dgClientes.SelectedRows(0).Index).Value().ToString
            tbDocumentoConyuge.Text = dgClientes.Item("dniConyuge", dgClientes.SelectedRows(0).Index).Value().ToString
            bModificar.Enabled = True
        End If
    End Sub

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim CN As String = "Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'"
        Dim miConexion As New SqlConnection(CN)
        Dim seleccion As String = "select * from Clientes c,Localidades l,Provincias p where c.IdLocalidad=l.IdLocalidad and l.IdProvincia=p.IdProvincia and NombreC like '" & tbBusqueda.Text & "%' order by NombreC" 'Busco por Nombre
        miConexion.Open()
        Dim tabla2 As DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(seleccion, CN)
        tabla2 = New DataTable
        da.Fill(tabla2)
        dgClientes.DataSource = tabla2
        miConexion.Close()
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        limpiarPantalla()
        bModificar.Enabled = False
    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Try
            Dim CN As New SqlConnection("Data Source='" & formPrincipal.tbEquipo.Text & "';INITIAL Catalog='" & formPrincipal.tbBSD.Text & "' ;Persist Security Info=True;User ID='" & formPrincipal.tbUsuario.Text & "';Password='" & formPrincipal.tbClave.Text & "'")
            CN.Open()
            Dim cmd As New SqlCommand("update Clientes set NombreC= '" & tbNombre.Text & "',TipoDni='" & cbTipoDoc.SelectedValue & "',NumeroDni='" & tbDocumento.Text & "',Domicilio='" & tbDomicilio.Text & "',FechaNacimiento='" & tbFechaNac.Text & "',IdLocalidad='" & tbIdLocalidad.Text & "',Cuit='" & tbCuit.Text & "',EstadoCivil='" & cbEstadoCivil.SelectedValue & "',Telefono='" & tbTelefono.Text & "',Email='" & tbEmail.Text & "',TipoIva='" & cbTipoIva.SelectedValue & "',Ocupacion='" & tbOcupacion.Text & "',NombreCConyuge= '" & tbNombreConyuge.Text & "',TipoDniConyuge= '" & cbTipoDocConyuge.SelectedValue & "', DniConyuge= '" & tbDocumentoConyuge.Text & "' where IdCliente= '" & tbIdCliente.Text & "'", CN)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Modificacion Efectuada")
            cargarDGClientes()
            limpiarPantalla()
            bModificar.Enabled = False
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error en la base de datos,intente mas tarde")
        End Try
    End Sub


    Private Sub cbEstadoCivil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstadoCivil.SelectedIndexChanged

        If cbEstadoCivil.SelectedValue.ToString = "CASADO/A" Then
            lNombreConyuge.Visible = True
            tbNombreConyuge.Visible = True
            lTipoDocConyuge.Visible = True
            cbTipoDocConyuge.Visible = True
            lNroDocConyuge.Visible = True
            tbDocumentoConyuge.Visible = True
        Else
            lNombreConyuge.Visible = False
            tbNombreConyuge.Visible = False
            lTipoDocConyuge.Visible = False
            cbTipoDocConyuge.Visible = False
            lNroDocConyuge.Visible = False
            tbDocumentoConyuge.Visible = False
        End If
    End Sub

End Class