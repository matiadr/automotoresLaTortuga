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
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgVehiculos = New System.Windows.Forms.DataGridView()
        Me.idVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDatosVehiculo = New System.Windows.Forms.GroupBox()
        Me.bNuevoModelo = New System.Windows.Forms.Button()
        Me.bNuevaMarca = New System.Windows.Forms.Button()
        Me.tbRetiroPapeles = New System.Windows.Forms.DateTimePicker()
        Me.tbAdeuda = New System.Windows.Forms.TextBox()
        Me.tbTransferencia = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbTipoMotor = New System.Windows.Forms.ComboBox()
        Me.tbColor = New System.Windows.Forms.TextBox()
        Me.cbModelo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.tbNroMotor = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
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
        Me.gbAcciones.Controls.Add(Me.Button1)
        Me.gbAcciones.Location = New System.Drawing.Point(717, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(184, 336)
        Me.gbAcciones.TabIndex = 3
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(17, 253)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(110, 50)
        Me.bSalir.TabIndex = 4
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(17, 183)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(110, 50)
        Me.bEliminar.TabIndex = 3
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(17, 113)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(110, 54)
        Me.bModificar.TabIndex = 2
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbClientes
        '
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
        'tbBusqueda
        '
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
        Me.dgVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVehiculo, Me.tipoVehiculo, Me.marca, Me.modelo, Me.dominio, Me.año})
        Me.dgVehiculos.Location = New System.Drawing.Point(13, 63)
        Me.dgVehiculos.Name = "dgVehiculos"
        Me.dgVehiculos.ReadOnly = True
        Me.dgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculos.Size = New System.Drawing.Size(652, 252)
        Me.dgVehiculos.TabIndex = 0
        Me.dgVehiculos.TabStop = False
        '
        'idVehiculo
        '
        Me.idVehiculo.HeaderText = "idVehiculo"
        Me.idVehiculo.Name = "idVehiculo"
        Me.idVehiculo.ReadOnly = True
        Me.idVehiculo.Visible = False
        '
        'tipoVehiculo
        '
        Me.tipoVehiculo.HeaderText = "Tipo Vehiculo"
        Me.tipoVehiculo.Name = "tipoVehiculo"
        Me.tipoVehiculo.ReadOnly = True
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'dominio
        '
        Me.dominio.HeaderText = "Dominio"
        Me.dominio.Name = "dominio"
        Me.dominio.ReadOnly = True
        '
        'año
        '
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        '
        'gbDatosVehiculo
        '
        Me.gbDatosVehiculo.Controls.Add(Me.bNuevoModelo)
        Me.gbDatosVehiculo.Controls.Add(Me.bNuevaMarca)
        Me.gbDatosVehiculo.Controls.Add(Me.tbRetiroPapeles)
        Me.gbDatosVehiculo.Controls.Add(Me.tbAdeuda)
        Me.gbDatosVehiculo.Controls.Add(Me.tbTransferencia)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox9)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox8)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox7)
        Me.gbDatosVehiculo.Controls.Add(Me.Label17)
        Me.gbDatosVehiculo.Controls.Add(Me.Label16)
        Me.gbDatosVehiculo.Controls.Add(Me.Label15)
        Me.gbDatosVehiculo.Controls.Add(Me.Label14)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox5)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox2)
        Me.gbDatosVehiculo.Controls.Add(Me.cbTipoMotor)
        Me.gbDatosVehiculo.Controls.Add(Me.tbColor)
        Me.gbDatosVehiculo.Controls.Add(Me.cbModelo)
        Me.gbDatosVehiculo.Controls.Add(Me.Label13)
        Me.gbDatosVehiculo.Controls.Add(Me.Label12)
        Me.gbDatosVehiculo.Controls.Add(Me.cbMarca)
        Me.gbDatosVehiculo.Controls.Add(Me.tbNroMotor)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox4)
        Me.gbDatosVehiculo.Controls.Add(Me.TextBox3)
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
        'bNuevoModelo
        '
        Me.bNuevoModelo.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevoModelo.Location = New System.Drawing.Point(222, 90)
        Me.bNuevoModelo.Name = "bNuevoModelo"
        Me.bNuevoModelo.Size = New System.Drawing.Size(30, 23)
        Me.bNuevoModelo.TabIndex = 33
        Me.bNuevoModelo.TabStop = False
        Me.bNuevoModelo.Text = "..."
        Me.bNuevoModelo.UseVisualStyleBackColor = True
        '
        'bNuevaMarca
        '
        Me.bNuevaMarca.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevaMarca.Location = New System.Drawing.Point(222, 61)
        Me.bNuevaMarca.Name = "bNuevaMarca"
        Me.bNuevaMarca.Size = New System.Drawing.Size(32, 23)
        Me.bNuevaMarca.TabIndex = 32
        Me.bNuevaMarca.TabStop = False
        Me.bNuevaMarca.Text = "..."
        Me.bNuevaMarca.UseVisualStyleBackColor = True
        '
        'tbRetiroPapeles
        '
        Me.tbRetiroPapeles.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbRetiroPapeles.Location = New System.Drawing.Point(93, 198)
        Me.tbRetiroPapeles.Name = "tbRetiroPapeles"
        Me.tbRetiroPapeles.Size = New System.Drawing.Size(121, 20)
        Me.tbRetiroPapeles.TabIndex = 12
        '
        'tbAdeuda
        '
        Me.tbAdeuda.Location = New System.Drawing.Point(94, 272)
        Me.tbAdeuda.Name = "tbAdeuda"
        Me.tbAdeuda.Size = New System.Drawing.Size(100, 20)
        Me.tbAdeuda.TabIndex = 14
        '
        'tbTransferencia
        '
        Me.tbTransferencia.Location = New System.Drawing.Point(94, 234)
        Me.tbTransferencia.Name = "tbTransferencia"
        Me.tbTransferencia.Size = New System.Drawing.Size(100, 20)
        Me.tbTransferencia.TabIndex = 13
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(405, 269)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 17
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(565, 234)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(405, 234)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 15
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
        Me.Label14.Location = New System.Drawing.Point(12, 198)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Retiro Papeles"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(405, 155)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(224, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(405, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(93, 20)
        Me.TextBox2.TabIndex = 7
        '
        'cbTipoMotor
        '
        Me.cbTipoMotor.FormattingEnabled = True
        Me.cbTipoMotor.Items.AddRange(New Object() {"NAFTA ", "DIESEL"})
        Me.cbTipoMotor.Location = New System.Drawing.Point(405, 26)
        Me.cbTipoMotor.Name = "cbTipoMotor"
        Me.cbTipoMotor.Size = New System.Drawing.Size(93, 21)
        Me.cbTipoMotor.TabIndex = 5
        '
        'tbColor
        '
        Me.tbColor.Location = New System.Drawing.Point(94, 158)
        Me.tbColor.Name = "tbColor"
        Me.tbColor.Size = New System.Drawing.Size(137, 20)
        Me.tbColor.TabIndex = 10
        '
        'cbModelo
        '
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
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Año"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Ubicacion"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(93, 58)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cbMarca.TabIndex = 3
        '
        'tbNroMotor
        '
        Me.tbNroMotor.Location = New System.Drawing.Point(93, 125)
        Me.tbNroMotor.Name = "tbNroMotor"
        Me.tbNroMotor.Size = New System.Drawing.Size(222, 20)
        Me.tbNroMotor.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(405, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(224, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(405, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(93, 20)
        Me.TextBox3.TabIndex = 6
        '
        'tbTipoVehiculo
        '
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
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Modelo"
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
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Dominio"
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
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo Vehiculo"
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents gbDatosVehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents tbNroMotor As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tbRetiroPapeles As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbAdeuda As System.Windows.Forms.TextBox
    Friend WithEvents tbTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents idVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dominio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bNuevaMarca As System.Windows.Forms.Button
    Friend WithEvents bNuevoModelo As System.Windows.Forms.Button
End Class
