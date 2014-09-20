<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formClientes))
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreConyuge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dniConyuge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProvincia1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDniConyuge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bNuevaProvincia = New System.Windows.Forms.GroupBox()
        Me.cbTipoDocConyuge = New System.Windows.Forms.ComboBox()
        Me.tbNombreConyuge = New System.Windows.Forms.TextBox()
        Me.lTipoDocConyuge = New System.Windows.Forms.Label()
        Me.lNombreConyuge = New System.Windows.Forms.Label()
        Me.tbDocumentoConyuge = New System.Windows.Forms.TextBox()
        Me.lNroDocConyuge = New System.Windows.Forms.Label()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tbIdProvincia = New System.Windows.Forms.TextBox()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.tbIdLocalidad = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bNuevaLocalidad = New System.Windows.Forms.Button()
        Me.bABMProvincia = New System.Windows.Forms.Button()
        Me.tbFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.tbOcupacion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.tbDocumento = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbCuit = New System.Windows.Forms.MaskedTextBox()
        Me.cbTipoIva = New System.Windows.Forms.ComboBox()
        Me.cbLocalidad = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.gbClientes.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNuevaProvincia.SuspendLayout()
        Me.gbAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.tbBusqueda)
        Me.gbClientes.Controls.Add(Me.Label1)
        Me.gbClientes.Controls.Add(Me.dgClientes)
        Me.gbClientes.Location = New System.Drawing.Point(13, 12)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(684, 325)
        Me.gbClientes.TabIndex = 0
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Clientes"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBusqueda.ForeColor = System.Drawing.Color.Black
        Me.tbBusqueda.Location = New System.Drawing.Point(73, 26)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(141, 20)
        Me.tbBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar "
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.AllowUserToResizeRows = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.nombreConyuge, Me.dniConyuge, Me.idLocalidad1, Me.idProvincia1, Me.fechaNacimiento, Me.tipoDniConyuge, Me.idProvincia, Me.idLocalidad, Me.Nombre, Me.tipoDni, Me.Documento, Me.estadoCivil, Me.telefono, Me.Domicilio, Me.Localidad, Me.Provincia, Me.ocupacion, Me.tipoIva, Me.cuit, Me.email})
        Me.dgClientes.Location = New System.Drawing.Point(13, 63)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(652, 252)
        Me.dgClientes.TabIndex = 0
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "IdCliente"
        Me.idCliente.HeaderText = "idCliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        '
        'nombreConyuge
        '
        Me.nombreConyuge.DataPropertyName = "NombreCConyuge"
        Me.nombreConyuge.HeaderText = "nombreConyuge"
        Me.nombreConyuge.Name = "nombreConyuge"
        Me.nombreConyuge.ReadOnly = True
        Me.nombreConyuge.Visible = False
        '
        'dniConyuge
        '
        Me.dniConyuge.DataPropertyName = "DniConyuge"
        Me.dniConyuge.HeaderText = "dniConyuge"
        Me.dniConyuge.Name = "dniConyuge"
        Me.dniConyuge.ReadOnly = True
        Me.dniConyuge.Visible = False
        '
        'idLocalidad1
        '
        Me.idLocalidad1.DataPropertyName = "idLocalidad1"
        Me.idLocalidad1.HeaderText = "idLocalidad1"
        Me.idLocalidad1.Name = "idLocalidad1"
        Me.idLocalidad1.ReadOnly = True
        Me.idLocalidad1.Visible = False
        '
        'idProvincia1
        '
        Me.idProvincia1.DataPropertyName = "idProvincia1"
        Me.idProvincia1.HeaderText = "idProvincia1"
        Me.idProvincia1.Name = "idProvincia1"
        Me.idProvincia1.ReadOnly = True
        Me.idProvincia1.Visible = False
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.fechaNacimiento.HeaderText = "fechaNacimiento"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.ReadOnly = True
        Me.fechaNacimiento.Visible = False
        '
        'tipoDniConyuge
        '
        Me.tipoDniConyuge.DataPropertyName = "TipoDniConyuge"
        Me.tipoDniConyuge.HeaderText = "tipoDniConyuge"
        Me.tipoDniConyuge.Name = "tipoDniConyuge"
        Me.tipoDniConyuge.ReadOnly = True
        Me.tipoDniConyuge.Visible = False
        '
        'idProvincia
        '
        Me.idProvincia.DataPropertyName = "IdProvincia"
        Me.idProvincia.HeaderText = "idProvincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = True
        Me.idProvincia.Visible = False
        '
        'idLocalidad
        '
        Me.idLocalidad.DataPropertyName = "IdLocalidad"
        Me.idLocalidad.HeaderText = "idLocalidad"
        Me.idLocalidad.Name = "idLocalidad"
        Me.idLocalidad.ReadOnly = True
        Me.idLocalidad.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NombreC"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'tipoDni
        '
        Me.tipoDni.DataPropertyName = "TipoDni"
        Me.tipoDni.HeaderText = "tipoDni"
        Me.tipoDni.Name = "tipoDni"
        Me.tipoDni.ReadOnly = True
        Me.tipoDni.Visible = False
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "NumeroDni"
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'estadoCivil
        '
        Me.estadoCivil.DataPropertyName = "EstadoCivil"
        Me.estadoCivil.HeaderText = "estadoCivil"
        Me.estadoCivil.Name = "estadoCivil"
        Me.estadoCivil.ReadOnly = True
        Me.estadoCivil.Visible = False
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "Telefono"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'Domicilio
        '
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "NombreLocalidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "NombreProvincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        '
        'ocupacion
        '
        Me.ocupacion.DataPropertyName = "Ocupacion"
        Me.ocupacion.HeaderText = "ocupacion"
        Me.ocupacion.Name = "ocupacion"
        Me.ocupacion.ReadOnly = True
        Me.ocupacion.Visible = False
        '
        'tipoIva
        '
        Me.tipoIva.DataPropertyName = "TipoIva"
        Me.tipoIva.HeaderText = "tipoIva"
        Me.tipoIva.Name = "tipoIva"
        Me.tipoIva.ReadOnly = True
        Me.tipoIva.Visible = False
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "Cuit"
        Me.cuit.HeaderText = "cuit"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Visible = False
        '
        'email
        '
        Me.email.DataPropertyName = "Email"
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Visible = False
        '
        'bNuevaProvincia
        '
        Me.bNuevaProvincia.Controls.Add(Me.cbTipoDocConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.tbNombreConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.lTipoDocConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.lNombreConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.tbDocumentoConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.lNroDocConyuge)
        Me.bNuevaProvincia.Controls.Add(Me.bLimpiar)
        Me.bNuevaProvincia.Controls.Add(Me.tbIdProvincia)
        Me.bNuevaProvincia.Controls.Add(Me.tbIdCliente)
        Me.bNuevaProvincia.Controls.Add(Me.tbIdLocalidad)
        Me.bNuevaProvincia.Controls.Add(Me.cbTipoDoc)
        Me.bNuevaProvincia.Controls.Add(Me.cbEstadoCivil)
        Me.bNuevaProvincia.Controls.Add(Me.tbEmail)
        Me.bNuevaProvincia.Controls.Add(Me.Label15)
        Me.bNuevaProvincia.Controls.Add(Me.Label14)
        Me.bNuevaProvincia.Controls.Add(Me.Label13)
        Me.bNuevaProvincia.Controls.Add(Me.Label12)
        Me.bNuevaProvincia.Controls.Add(Me.bNuevaLocalidad)
        Me.bNuevaProvincia.Controls.Add(Me.bABMProvincia)
        Me.bNuevaProvincia.Controls.Add(Me.tbFechaNac)
        Me.bNuevaProvincia.Controls.Add(Me.tbOcupacion)
        Me.bNuevaProvincia.Controls.Add(Me.tbTelefono)
        Me.bNuevaProvincia.Controls.Add(Me.tbDomicilio)
        Me.bNuevaProvincia.Controls.Add(Me.tbDocumento)
        Me.bNuevaProvincia.Controls.Add(Me.tbNombre)
        Me.bNuevaProvincia.Controls.Add(Me.tbCuit)
        Me.bNuevaProvincia.Controls.Add(Me.cbTipoIva)
        Me.bNuevaProvincia.Controls.Add(Me.cbLocalidad)
        Me.bNuevaProvincia.Controls.Add(Me.cbProvincia)
        Me.bNuevaProvincia.Controls.Add(Me.Label11)
        Me.bNuevaProvincia.Controls.Add(Me.Label10)
        Me.bNuevaProvincia.Controls.Add(Me.Label9)
        Me.bNuevaProvincia.Controls.Add(Me.Label4)
        Me.bNuevaProvincia.Controls.Add(Me.Label8)
        Me.bNuevaProvincia.Controls.Add(Me.Label7)
        Me.bNuevaProvincia.Controls.Add(Me.Label6)
        Me.bNuevaProvincia.Controls.Add(Me.Label5)
        Me.bNuevaProvincia.Controls.Add(Me.Label3)
        Me.bNuevaProvincia.Controls.Add(Me.Label2)
        Me.bNuevaProvincia.Location = New System.Drawing.Point(13, 338)
        Me.bNuevaProvincia.Name = "bNuevaProvincia"
        Me.bNuevaProvincia.Size = New System.Drawing.Size(684, 343)
        Me.bNuevaProvincia.TabIndex = 1
        Me.bNuevaProvincia.TabStop = False
        '
        'cbTipoDocConyuge
        '
        Me.cbTipoDocConyuge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocConyuge.FormattingEnabled = True
        Me.cbTipoDocConyuge.Location = New System.Drawing.Point(364, 87)
        Me.cbTipoDocConyuge.Name = "cbTipoDocConyuge"
        Me.cbTipoDocConyuge.Size = New System.Drawing.Size(72, 21)
        Me.cbTipoDocConyuge.TabIndex = 7
        Me.cbTipoDocConyuge.Visible = False
        '
        'tbNombreConyuge
        '
        Me.tbNombreConyuge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreConyuge.Location = New System.Drawing.Point(378, 125)
        Me.tbNombreConyuge.Name = "tbNombreConyuge"
        Me.tbNombreConyuge.Size = New System.Drawing.Size(186, 20)
        Me.tbNombreConyuge.TabIndex = 9
        Me.tbNombreConyuge.Visible = False
        '
        'lTipoDocConyuge
        '
        Me.lTipoDocConyuge.AutoSize = True
        Me.lTipoDocConyuge.Location = New System.Drawing.Point(266, 90)
        Me.lTipoDocConyuge.Name = "lTipoDocConyuge"
        Me.lTipoDocConyuge.Size = New System.Drawing.Size(96, 13)
        Me.lTipoDocConyuge.TabIndex = 28
        Me.lTipoDocConyuge.Text = "Tipo Doc Conyuge"
        Me.lTipoDocConyuge.Visible = False
        '
        'lNombreConyuge
        '
        Me.lNombreConyuge.AutoSize = True
        Me.lNombreConyuge.Location = New System.Drawing.Point(283, 128)
        Me.lNombreConyuge.Name = "lNombreConyuge"
        Me.lNombreConyuge.Size = New System.Drawing.Size(89, 13)
        Me.lNombreConyuge.TabIndex = 27
        Me.lNombreConyuge.Text = "Nombre Conyuge"
        Me.lNombreConyuge.Visible = False
        '
        'tbDocumentoConyuge
        '
        Me.tbDocumentoConyuge.Location = New System.Drawing.Point(537, 87)
        Me.tbDocumentoConyuge.Name = "tbDocumentoConyuge"
        Me.tbDocumentoConyuge.Size = New System.Drawing.Size(105, 20)
        Me.tbDocumentoConyuge.TabIndex = 8
        Me.tbDocumentoConyuge.Visible = False
        '
        'lNroDocConyuge
        '
        Me.lNroDocConyuge.AutoSize = True
        Me.lNroDocConyuge.Location = New System.Drawing.Point(439, 90)
        Me.lNroDocConyuge.Name = "lNroDocConyuge"
        Me.lNroDocConyuge.Size = New System.Drawing.Size(92, 13)
        Me.lNroDocConyuge.TabIndex = 25
        Me.lNroDocConyuge.Text = "Nro Doc Conyuge"
        Me.lNroDocConyuge.Visible = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Location = New System.Drawing.Point(559, 21)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.bLimpiar.TabIndex = 24
        Me.bLimpiar.Text = "Limpiar "
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'tbIdProvincia
        '
        Me.tbIdProvincia.Location = New System.Drawing.Point(21, 190)
        Me.tbIdProvincia.Name = "tbIdProvincia"
        Me.tbIdProvincia.Size = New System.Drawing.Size(20, 20)
        Me.tbIdProvincia.TabIndex = 23
        Me.tbIdProvincia.Visible = False
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(492, 19)
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(39, 20)
        Me.tbIdCliente.TabIndex = 22
        Me.tbIdCliente.Visible = False
        '
        'tbIdLocalidad
        '
        Me.tbIdLocalidad.Location = New System.Drawing.Point(588, 195)
        Me.tbIdLocalidad.Name = "tbIdLocalidad"
        Me.tbIdLocalidad.Size = New System.Drawing.Size(14, 20)
        Me.tbIdLocalidad.TabIndex = 21
        Me.tbIdLocalidad.Visible = False
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(108, 53)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(68, 21)
        Me.cbTipoDoc.TabIndex = 3
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.Location = New System.Drawing.Point(110, 125)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cbEstadoCivil.TabIndex = 6
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(399, 226)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(203, 20)
        Me.tbEmail.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(48, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Tipo Doc *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Estado Civil *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(361, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(556, 311)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "* Campos Obligatorios"
        '
        'bNuevaLocalidad
        '
        Me.bNuevaLocalidad.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevaLocalidad.Location = New System.Drawing.Point(539, 192)
        Me.bNuevaLocalidad.Name = "bNuevaLocalidad"
        Me.bNuevaLocalidad.Size = New System.Drawing.Size(30, 23)
        Me.bNuevaLocalidad.TabIndex = 13
        Me.bNuevaLocalidad.TabStop = False
        Me.bNuevaLocalidad.Text = "..."
        Me.bNuevaLocalidad.UseVisualStyleBackColor = True
        '
        'bABMProvincia
        '
        Me.bABMProvincia.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bABMProvincia.Location = New System.Drawing.Point(279, 193)
        Me.bABMProvincia.Name = "bABMProvincia"
        Me.bABMProvincia.Size = New System.Drawing.Size(27, 23)
        Me.bABMProvincia.TabIndex = 12
        Me.bABMProvincia.TabStop = False
        Me.bABMProvincia.Text = "..."
        Me.bABMProvincia.UseVisualStyleBackColor = True
        '
        'tbFechaNac
        '
        Me.tbFechaNac.Location = New System.Drawing.Point(111, 86)
        Me.tbFechaNac.Mask = "00/00/0000"
        Me.tbFechaNac.Name = "tbFechaNac"
        Me.tbFechaNac.Size = New System.Drawing.Size(84, 20)
        Me.tbFechaNac.TabIndex = 5
        Me.tbFechaNac.ValidatingType = GetType(Date)
        '
        'tbOcupacion
        '
        Me.tbOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOcupacion.Location = New System.Drawing.Point(111, 268)
        Me.tbOcupacion.Name = "tbOcupacion"
        Me.tbOcupacion.Size = New System.Drawing.Size(222, 20)
        Me.tbOcupacion.TabIndex = 15
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(109, 229)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(222, 20)
        Me.tbTelefono.TabIndex = 13
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(109, 159)
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(224, 20)
        Me.tbDomicilio.TabIndex = 10
        '
        'tbDocumento
        '
        Me.tbDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDocumento.Location = New System.Drawing.Point(297, 52)
        Me.tbDocumento.Name = "tbDocumento"
        Me.tbDocumento.Size = New System.Drawing.Size(117, 20)
        Me.tbDocumento.TabIndex = 4
        '
        'tbNombre
        '
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Location = New System.Drawing.Point(108, 26)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(224, 20)
        Me.tbNombre.TabIndex = 2
        '
        'tbCuit
        '
        Me.tbCuit.Location = New System.Drawing.Point(314, 303)
        Me.tbCuit.Mask = "##-########-#"
        Me.tbCuit.Name = "tbCuit"
        Me.tbCuit.Size = New System.Drawing.Size(100, 20)
        Me.tbCuit.TabIndex = 17
        '
        'cbTipoIva
        '
        Me.cbTipoIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoIva.FormattingEnabled = True
        Me.cbTipoIva.Location = New System.Drawing.Point(110, 303)
        Me.cbTipoIva.Name = "cbTipoIva"
        Me.cbTipoIva.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoIva.TabIndex = 16
        '
        'cbLocalidad
        '
        Me.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(383, 193)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(149, 21)
        Me.cbLocalidad.TabIndex = 12
        '
        'cbProvincia
        '
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(111, 193)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(162, 21)
        Me.cbProvincia.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Telefonos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Domicilio *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fecha Nacimiento *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CUIT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Localidad *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Provincia *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ocupacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Resp. IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nro Documento *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre *"
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(726, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(184, 336)
        Me.gbAcciones.TabIndex = 2
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(17, 253)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(110, 50)
        Me.bSalir.TabIndex = 21
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(17, 183)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(110, 50)
        Me.bEliminar.TabIndex = 20
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(17, 113)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(110, 54)
        Me.bModificar.TabIndex = 19
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(17, 36)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 54)
        Me.bNuevo.TabIndex = 18
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'formClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 689)
        Me.Controls.Add(Me.gbAcciones)
        Me.Controls.Add(Me.bNuevaProvincia)
        Me.Controls.Add(Me.gbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Clientes"
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNuevaProvincia.ResumeLayout(False)
        Me.bNuevaProvincia.PerformLayout()
        Me.gbAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents bNuevaProvincia As System.Windows.Forms.GroupBox
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbOcupacion As System.Windows.Forms.TextBox
    Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents tbDocumento As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbTipoIva As System.Windows.Forms.ComboBox
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbFechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents bNuevaLocalidad As System.Windows.Forms.Button
    Friend WithEvents bABMProvincia As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbIdLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents tbIdProvincia As System.Windows.Forms.TextBox
    Friend WithEvents bLimpiar As System.Windows.Forms.Button
    Friend WithEvents lTipoDocConyuge As System.Windows.Forms.Label
    Friend WithEvents lNombreConyuge As System.Windows.Forms.Label
    Friend WithEvents tbDocumentoConyuge As System.Windows.Forms.TextBox
    Friend WithEvents lNroDocConyuge As System.Windows.Forms.Label
    Friend WithEvents cbTipoDocConyuge As System.Windows.Forms.ComboBox
    Friend WithEvents tbNombreConyuge As System.Windows.Forms.TextBox
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreConyuge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dniConyuge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProvincia1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoDniConyuge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoDni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoCivil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ocupacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
