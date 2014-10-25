<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVehiculos))
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.rbAño = New System.Windows.Forms.RadioButton()
        Me.rbMarca = New System.Windows.Forms.RadioButton()
        Me.rbDominio = New System.Windows.Forms.RadioButton()
        Me.rbModelo = New System.Windows.Forms.RadioButton()
        Me.rbTipoVehiculo = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgVehiculos = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioGastos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoMotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chasis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDatosVehiculo = New System.Windows.Forms.GroupBox()
        Me.tbAño = New System.Windows.Forms.MaskedTextBox()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tbObservacion = New System.Windows.Forms.RichTextBox()
        Me.tbIdModelo = New System.Windows.Forms.TextBox()
        Me.tbIdMarca = New System.Windows.Forms.TextBox()
        Me.tbIdVehiculo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bNuevoModelo = New System.Windows.Forms.Button()
        Me.bNuevaMarca = New System.Windows.Forms.Button()
        Me.tbFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.tbAdeuda = New System.Windows.Forms.TextBox()
        Me.tbTransferencia = New System.Windows.Forms.TextBox()
        Me.tbVenta = New System.Windows.Forms.TextBox()
        Me.tbGastos = New System.Windows.Forms.TextBox()
        Me.tbCosto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipoMotor = New System.Windows.Forms.ComboBox()
        Me.tbColor = New System.Windows.Forms.TextBox()
        Me.cbModelo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.tbNroMotor = New System.Windows.Forms.TextBox()
        Me.tbNroChasis = New System.Windows.Forms.TextBox()
        Me.tbDominio = New System.Windows.Forms.TextBox()
        Me.tbTipoVehiculo = New System.Windows.Forms.TextBox()
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
        Me.gbAcciones.SuspendLayout()
        Me.gbClientes.SuspendLayout()
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(717, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(161, 336)
        Me.gbAcciones.TabIndex = 3
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.bNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bNuevo.Cursor = System.Windows.Forms.Cursors.Cross
        Me.bNuevo.Enabled = False
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(17, 36)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 54)
        Me.bNuevo.TabIndex = 18
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.rbAño)
        Me.gbClientes.Controls.Add(Me.rbMarca)
        Me.gbClientes.Controls.Add(Me.rbDominio)
        Me.gbClientes.Controls.Add(Me.rbModelo)
        Me.gbClientes.Controls.Add(Me.rbTipoVehiculo)
        Me.gbClientes.Controls.Add(Me.Label19)
        Me.gbClientes.Controls.Add(Me.tbBusqueda)
        Me.gbClientes.Controls.Add(Me.Label1)
        Me.gbClientes.Controls.Add(Me.dgVehiculos)
        Me.gbClientes.Location = New System.Drawing.Point(12, 12)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(694, 336)
        Me.gbClientes.TabIndex = 1
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Vehiculos"
        '
        'rbAño
        '
        Me.rbAño.AutoSize = True
        Me.rbAño.Location = New System.Drawing.Point(306, 55)
        Me.rbAño.Name = "rbAño"
        Me.rbAño.Size = New System.Drawing.Size(44, 17)
        Me.rbAño.TabIndex = 7
        Me.rbAño.Text = "Año"
        Me.rbAño.UseVisualStyleBackColor = True
        '
        'rbMarca
        '
        Me.rbMarca.AutoSize = True
        Me.rbMarca.Location = New System.Drawing.Point(176, 55)
        Me.rbMarca.Name = "rbMarca"
        Me.rbMarca.Size = New System.Drawing.Size(55, 17)
        Me.rbMarca.TabIndex = 6
        Me.rbMarca.Text = "Marca"
        Me.rbMarca.UseVisualStyleBackColor = True
        '
        'rbDominio
        '
        Me.rbDominio.AutoSize = True
        Me.rbDominio.Location = New System.Drawing.Point(356, 55)
        Me.rbDominio.Name = "rbDominio"
        Me.rbDominio.Size = New System.Drawing.Size(63, 17)
        Me.rbDominio.TabIndex = 5
        Me.rbDominio.Text = "Dominio"
        Me.rbDominio.UseVisualStyleBackColor = True
        '
        'rbModelo
        '
        Me.rbModelo.AutoSize = True
        Me.rbModelo.Location = New System.Drawing.Point(240, 55)
        Me.rbModelo.Name = "rbModelo"
        Me.rbModelo.Size = New System.Drawing.Size(60, 17)
        Me.rbModelo.TabIndex = 4
        Me.rbModelo.Text = "Modelo"
        Me.rbModelo.UseVisualStyleBackColor = True
        '
        'rbTipoVehiculo
        '
        Me.rbTipoVehiculo.AutoSize = True
        Me.rbTipoVehiculo.Checked = True
        Me.rbTipoVehiculo.Location = New System.Drawing.Point(83, 55)
        Me.rbTipoVehiculo.Name = "rbTipoVehiculo"
        Me.rbTipoVehiculo.Size = New System.Drawing.Size(90, 17)
        Me.rbTipoVehiculo.TabIndex = 3
        Me.rbTipoVehiculo.TabStop = True
        Me.rbTipoVehiculo.Text = "Tipo Vehiculo"
        Me.rbTipoVehiculo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Filtrar por "
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(73, 26)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(141, 20)
        Me.tbBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar "
        '
        'dgVehiculos
        '
        Me.dgVehiculos.AllowUserToAddRows = False
        Me.dgVehiculos.AllowUserToDeleteRows = False
        Me.dgVehiculos.AllowUserToResizeRows = False
        Me.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca, Me.precioVenta, Me.precioCosto, Me.precioGastos, Me.modelo, Me.tipoVehiculo, Me.tipoMotor, Me.año, Me.dominio, Me.idVehiculo, Me.idModelo, Me.idMarca, Me.observaciones, Me.motor, Me.chasis, Me.color, Me.fechaAlta})
        Me.dgVehiculos.Location = New System.Drawing.Point(13, 78)
        Me.dgVehiculos.Name = "dgVehiculos"
        Me.dgVehiculos.ReadOnly = True
        Me.dgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculos.Size = New System.Drawing.Size(652, 252)
        Me.dgVehiculos.TabIndex = 0
        Me.dgVehiculos.TabStop = False
        '
        'marca
        '
        Me.marca.DataPropertyName = "NombreMarca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'precioVenta
        '
        Me.precioVenta.DataPropertyName = "PrecioVenta"
        Me.precioVenta.HeaderText = "precioVenta"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.ReadOnly = True
        Me.precioVenta.Visible = False
        '
        'precioCosto
        '
        Me.precioCosto.DataPropertyName = "PrecioCosto"
        Me.precioCosto.HeaderText = "precioCosto"
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = True
        Me.precioCosto.Visible = False
        '
        'precioGastos
        '
        Me.precioGastos.DataPropertyName = "PrecioGastos"
        Me.precioGastos.HeaderText = "precioGastos"
        Me.precioGastos.Name = "precioGastos"
        Me.precioGastos.ReadOnly = True
        Me.precioGastos.Visible = False
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "NombreModelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'tipoVehiculo
        '
        Me.tipoVehiculo.DataPropertyName = "Tipo"
        Me.tipoVehiculo.HeaderText = "Tipo Vehiculo"
        Me.tipoVehiculo.Name = "tipoVehiculo"
        Me.tipoVehiculo.ReadOnly = True
        '
        'tipoMotor
        '
        Me.tipoMotor.DataPropertyName = "TipoMotor"
        Me.tipoMotor.HeaderText = "Tipo Motor"
        Me.tipoMotor.Name = "tipoMotor"
        Me.tipoMotor.ReadOnly = True
        '
        'año
        '
        Me.año.DataPropertyName = "Año"
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        '
        'dominio
        '
        Me.dominio.DataPropertyName = "Dominio"
        Me.dominio.HeaderText = "Dominio"
        Me.dominio.Name = "dominio"
        Me.dominio.ReadOnly = True
        '
        'idVehiculo
        '
        Me.idVehiculo.DataPropertyName = "IdVehiculo"
        Me.idVehiculo.HeaderText = "idVehiculo"
        Me.idVehiculo.Name = "idVehiculo"
        Me.idVehiculo.ReadOnly = True
        Me.idVehiculo.Visible = False
        '
        'idModelo
        '
        Me.idModelo.DataPropertyName = "IdModelo"
        Me.idModelo.HeaderText = "idModelo"
        Me.idModelo.Name = "idModelo"
        Me.idModelo.ReadOnly = True
        Me.idModelo.Visible = False
        '
        'idMarca
        '
        Me.idMarca.DataPropertyName = "IdMarca"
        Me.idMarca.HeaderText = "idMarca"
        Me.idMarca.Name = "idMarca"
        Me.idMarca.ReadOnly = True
        Me.idMarca.Visible = False
        '
        'observaciones
        '
        Me.observaciones.DataPropertyName = "Observaciones"
        Me.observaciones.HeaderText = "observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Visible = False
        '
        'motor
        '
        Me.motor.DataPropertyName = "Motor"
        Me.motor.HeaderText = "motor"
        Me.motor.Name = "motor"
        Me.motor.ReadOnly = True
        Me.motor.Visible = False
        '
        'chasis
        '
        Me.chasis.DataPropertyName = "Chasis"
        Me.chasis.HeaderText = "chasis"
        Me.chasis.Name = "chasis"
        Me.chasis.ReadOnly = True
        Me.chasis.Visible = False
        '
        'color
        '
        Me.color.DataPropertyName = "Color"
        Me.color.HeaderText = "color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.Visible = False
        '
        'fechaAlta
        '
        Me.fechaAlta.DataPropertyName = "FechaAlta"
        Me.fechaAlta.HeaderText = "fechaAlta"
        Me.fechaAlta.Name = "fechaAlta"
        Me.fechaAlta.ReadOnly = True
        Me.fechaAlta.Visible = False
        '
        'gbDatosVehiculo
        '
        Me.gbDatosVehiculo.Controls.Add(Me.tbAño)
        Me.gbDatosVehiculo.Controls.Add(Me.bLimpiar)
        Me.gbDatosVehiculo.Controls.Add(Me.tbObservacion)
        Me.gbDatosVehiculo.Controls.Add(Me.tbIdModelo)
        Me.gbDatosVehiculo.Controls.Add(Me.tbIdMarca)
        Me.gbDatosVehiculo.Controls.Add(Me.tbIdVehiculo)
        Me.gbDatosVehiculo.Controls.Add(Me.Label18)
        Me.gbDatosVehiculo.Controls.Add(Me.bNuevoModelo)
        Me.gbDatosVehiculo.Controls.Add(Me.bNuevaMarca)
        Me.gbDatosVehiculo.Controls.Add(Me.tbFechaAlta)
        Me.gbDatosVehiculo.Controls.Add(Me.tbAdeuda)
        Me.gbDatosVehiculo.Controls.Add(Me.tbTransferencia)
        Me.gbDatosVehiculo.Controls.Add(Me.tbVenta)
        Me.gbDatosVehiculo.Controls.Add(Me.tbGastos)
        Me.gbDatosVehiculo.Controls.Add(Me.tbCosto)
        Me.gbDatosVehiculo.Controls.Add(Me.Label17)
        Me.gbDatosVehiculo.Controls.Add(Me.Label16)
        Me.gbDatosVehiculo.Controls.Add(Me.Label15)
        Me.gbDatosVehiculo.Controls.Add(Me.Label14)
        Me.gbDatosVehiculo.Controls.Add(Me.cbTipoMotor)
        Me.gbDatosVehiculo.Controls.Add(Me.tbColor)
        Me.gbDatosVehiculo.Controls.Add(Me.cbModelo)
        Me.gbDatosVehiculo.Controls.Add(Me.Label13)
        Me.gbDatosVehiculo.Controls.Add(Me.Label12)
        Me.gbDatosVehiculo.Controls.Add(Me.cbMarca)
        Me.gbDatosVehiculo.Controls.Add(Me.tbNroMotor)
        Me.gbDatosVehiculo.Controls.Add(Me.tbNroChasis)
        Me.gbDatosVehiculo.Controls.Add(Me.tbDominio)
        Me.gbDatosVehiculo.Controls.Add(Me.tbTipoVehiculo)
        Me.gbDatosVehiculo.Controls.Add(Me.Label11)
        Me.gbDatosVehiculo.Controls.Add(Me.Label10)
        Me.gbDatosVehiculo.Controls.Add(Me.Label9)
        Me.gbDatosVehiculo.Controls.Add(Me.Label4)
        Me.gbDatosVehiculo.Controls.Add(Me.Label8)
        Me.gbDatosVehiculo.Controls.Add(Me.Label7)
        Me.gbDatosVehiculo.Controls.Add(Me.Label6)
        Me.gbDatosVehiculo.Controls.Add(Me.Label5)
        Me.gbDatosVehiculo.Controls.Add(Me.Label3)
        Me.gbDatosVehiculo.Controls.Add(Me.Label2)
        Me.gbDatosVehiculo.Location = New System.Drawing.Point(12, 354)
        Me.gbDatosVehiculo.Name = "gbDatosVehiculo"
        Me.gbDatosVehiculo.Size = New System.Drawing.Size(694, 314)
        Me.gbDatosVehiculo.TabIndex = 2
        Me.gbDatosVehiculo.TabStop = False
        Me.gbDatosVehiculo.Text = "Datos Vehiculo"
        '
        'tbAño
        '
        Me.tbAño.Location = New System.Drawing.Point(405, 84)
        Me.tbAño.Mask = "9999"
        Me.tbAño.Name = "tbAño"
        Me.tbAño.Size = New System.Drawing.Size(93, 20)
        Me.tbAño.TabIndex = 7
        Me.tbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bLimpiar
        '
        Me.bLimpiar.Location = New System.Drawing.Point(588, 27)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(77, 23)
        Me.bLimpiar.TabIndex = 39
        Me.bLimpiar.TabStop = False
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'tbObservacion
        '
        Me.tbObservacion.Location = New System.Drawing.Point(405, 153)
        Me.tbObservacion.Name = "tbObservacion"
        Me.tbObservacion.Size = New System.Drawing.Size(224, 58)
        Me.tbObservacion.TabIndex = 14
        Me.tbObservacion.Text = ""
        '
        'tbIdModelo
        '
        Me.tbIdModelo.Location = New System.Drawing.Point(260, 90)
        Me.tbIdModelo.Name = "tbIdModelo"
        Me.tbIdModelo.Size = New System.Drawing.Size(32, 20)
        Me.tbIdModelo.TabIndex = 37
        Me.tbIdModelo.TabStop = False
        Me.tbIdModelo.Visible = False
        '
        'tbIdMarca
        '
        Me.tbIdMarca.Location = New System.Drawing.Point(260, 58)
        Me.tbIdMarca.Name = "tbIdMarca"
        Me.tbIdMarca.Size = New System.Drawing.Size(23, 20)
        Me.tbIdMarca.TabIndex = 36
        Me.tbIdMarca.TabStop = False
        Me.tbIdMarca.Visible = False
        '
        'tbIdVehiculo
        '
        Me.tbIdVehiculo.Location = New System.Drawing.Point(529, 27)
        Me.tbIdVehiculo.Name = "tbIdVehiculo"
        Me.tbIdVehiculo.Size = New System.Drawing.Size(35, 20)
        Me.tbIdVehiculo.TabIndex = 35
        Me.tbIdVehiculo.TabStop = False
        Me.tbIdVehiculo.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "* Campos Obligatorios"
        '
        'bNuevoModelo
        '
        Me.bNuevoModelo.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevoModelo.Location = New System.Drawing.Point(220, 88)
        Me.bNuevoModelo.Name = "bNuevoModelo"
        Me.bNuevoModelo.Size = New System.Drawing.Size(32, 23)
        Me.bNuevoModelo.TabIndex = 33
        Me.bNuevoModelo.TabStop = False
        Me.bNuevoModelo.Text = "..."
        Me.bNuevoModelo.UseVisualStyleBackColor = True
        '
        'bNuevaMarca
        '
        Me.bNuevaMarca.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevaMarca.Location = New System.Drawing.Point(220, 56)
        Me.bNuevaMarca.Name = "bNuevaMarca"
        Me.bNuevaMarca.Size = New System.Drawing.Size(32, 23)
        Me.bNuevaMarca.TabIndex = 32
        Me.bNuevaMarca.TabStop = False
        Me.bNuevaMarca.Text = "..."
        Me.bNuevaMarca.UseVisualStyleBackColor = True
        '
        'tbFechaAlta
        '
        Me.tbFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaAlta.Location = New System.Drawing.Point(93, 198)
        Me.tbFechaAlta.Name = "tbFechaAlta"
        Me.tbFechaAlta.Size = New System.Drawing.Size(121, 20)
        Me.tbFechaAlta.TabIndex = 11
        '
        'tbAdeuda
        '
        Me.tbAdeuda.Location = New System.Drawing.Point(94, 272)
        Me.tbAdeuda.Name = "tbAdeuda"
        Me.tbAdeuda.Size = New System.Drawing.Size(100, 20)
        Me.tbAdeuda.TabIndex = 13
        '
        'tbTransferencia
        '
        Me.tbTransferencia.Location = New System.Drawing.Point(94, 234)
        Me.tbTransferencia.Name = "tbTransferencia"
        Me.tbTransferencia.Size = New System.Drawing.Size(100, 20)
        Me.tbTransferencia.TabIndex = 12
        '
        'tbVenta
        '
        Me.tbVenta.Location = New System.Drawing.Point(405, 269)
        Me.tbVenta.Name = "tbVenta"
        Me.tbVenta.Size = New System.Drawing.Size(100, 20)
        Me.tbVenta.TabIndex = 17
        '
        'tbGastos
        '
        Me.tbGastos.Location = New System.Drawing.Point(565, 234)
        Me.tbGastos.Name = "tbGastos"
        Me.tbGastos.Size = New System.Drawing.Size(100, 20)
        Me.tbGastos.TabIndex = 16
        '
        'tbCosto
        '
        Me.tbCosto.Location = New System.Drawing.Point(405, 234)
        Me.tbCosto.Name = "tbCosto"
        Me.tbCosto.Size = New System.Drawing.Size(100, 20)
        Me.tbCosto.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(364, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Venta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(365, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Costo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Transferencia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 198)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Fecha Alta"
        '
        'cbTipoMotor
        '
        Me.cbTipoMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMotor.FormattingEnabled = True
        Me.cbTipoMotor.Items.AddRange(New Object() {"NAFTA ", "DIESEL", "GNC"})
        Me.cbTipoMotor.Location = New System.Drawing.Point(405, 26)
        Me.cbTipoMotor.Name = "cbTipoMotor"
        Me.cbTipoMotor.Size = New System.Drawing.Size(93, 21)
        Me.cbTipoMotor.TabIndex = 5
        '
        'tbColor
        '
        Me.tbColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbColor.Location = New System.Drawing.Point(94, 158)
        Me.tbColor.Name = "tbColor"
        Me.tbColor.Size = New System.Drawing.Size(137, 20)
        Me.tbColor.TabIndex = 10
        '
        'cbModelo
        '
        Me.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModelo.FormattingEnabled = True
        Me.cbModelo.Location = New System.Drawing.Point(94, 90)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Size = New System.Drawing.Size(121, 21)
        Me.cbModelo.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(373, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Año *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(332, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Observacion"
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(93, 58)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cbMarca.TabIndex = 3
        Me.cbMarca.Tag = ""
        '
        'tbNroMotor
        '
        Me.tbNroMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNroMotor.Location = New System.Drawing.Point(93, 125)
        Me.tbNroMotor.Name = "tbNroMotor"
        Me.tbNroMotor.Size = New System.Drawing.Size(222, 20)
        Me.tbNroMotor.TabIndex = 8
        '
        'tbNroChasis
        '
        Me.tbNroChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNroChasis.Location = New System.Drawing.Point(405, 122)
        Me.tbNroChasis.Name = "tbNroChasis"
        Me.tbNroChasis.Size = New System.Drawing.Size(224, 20)
        Me.tbNroChasis.TabIndex = 9
        '
        'tbDominio
        '
        Me.tbDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDominio.Location = New System.Drawing.Point(405, 58)
        Me.tbDominio.Name = "tbDominio"
        Me.tbDominio.Size = New System.Drawing.Size(93, 20)
        Me.tbDominio.TabIndex = 6
        '
        'tbTipoVehiculo
        '
        Me.tbTipoVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbTipoVehiculo.Location = New System.Drawing.Point(93, 26)
        Me.tbTipoVehiculo.Name = "tbTipoVehiculo"
        Me.tbTipoVehiculo.Size = New System.Drawing.Size(190, 20)
        Me.tbTipoVehiculo.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Tipo Motor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nro de Motor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Modelo *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(524, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gastos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Dominio "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nro de Chasis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Adeuda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Marca *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo Vehiculo *"
        '
        'formVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 673)
        Me.Controls.Add(Me.gbDatosVehiculo)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Vehiculos"
        Me.gbAcciones.ResumeLayout(False)
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosVehiculo.ResumeLayout(False)
        Me.gbDatosVehiculo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents gbDatosVehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents tbNroMotor As System.Windows.Forms.TextBox
    Friend WithEvents tbNroChasis As System.Windows.Forms.TextBox
    Friend WithEvents tbDominio As System.Windows.Forms.TextBox
    Friend WithEvents tbTipoVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoMotor As System.Windows.Forms.ComboBox
    Friend WithEvents tbColor As System.Windows.Forms.TextBox
    Friend WithEvents cbModelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents tbVenta As System.Windows.Forms.TextBox
    Friend WithEvents tbGastos As System.Windows.Forms.TextBox
    Friend WithEvents tbCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbAdeuda As System.Windows.Forms.TextBox
    Friend WithEvents tbTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents bNuevaMarca As System.Windows.Forms.Button
    Friend WithEvents bNuevoModelo As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbIdModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbIdMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbIdVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents tbObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents bLimpiar As System.Windows.Forms.Button
    Friend WithEvents rbAño As System.Windows.Forms.RadioButton
    Friend WithEvents rbMarca As System.Windows.Forms.RadioButton
    Friend WithEvents rbDominio As System.Windows.Forms.RadioButton
    Friend WithEvents rbModelo As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoVehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioGastos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoMotor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dominio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chasis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbAño As System.Windows.Forms.MaskedTextBox
End Class
