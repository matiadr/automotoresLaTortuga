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
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bNuevaProvincia = New System.Windows.Forms.GroupBox()
        Me.bNuevaLocalidad = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.tbOcupacion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.tbDocumento = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbCuit = New System.Windows.Forms.MaskedTextBox()
        Me.cbRespIVA = New System.Windows.Forms.ComboBox()
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
        Me.bSalir = New System.Windows.Forms.GroupBox()
        Me.b = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbClientes.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNuevaProvincia.SuspendLayout()
        Me.bSalir.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.tbBusqueda)
        Me.gbClientes.Controls.Add(Me.Label1)
        Me.gbClientes.Controls.Add(Me.dgClientes)
        Me.gbClientes.Location = New System.Drawing.Point(13, 12)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(684, 336)
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
        Me.tbBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.AllowUserToResizeRows = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.idCliente, Me.Documento, Me.Domicilio, Me.Provincia, Me.Localidad})
        Me.dgClientes.Location = New System.Drawing.Point(13, 63)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(652, 252)
        Me.dgClientes.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'idCliente
        '
        Me.idCliente.HeaderText = "idCliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'bNuevaProvincia
        '
        Me.bNuevaProvincia.Controls.Add(Me.Label12)
        Me.bNuevaProvincia.Controls.Add(Me.bNuevaLocalidad)
        Me.bNuevaProvincia.Controls.Add(Me.Button2)
        Me.bNuevaProvincia.Controls.Add(Me.tbFechaNac)
        Me.bNuevaProvincia.Controls.Add(Me.tbOcupacion)
        Me.bNuevaProvincia.Controls.Add(Me.tbTelefono)
        Me.bNuevaProvincia.Controls.Add(Me.tbDomicilio)
        Me.bNuevaProvincia.Controls.Add(Me.tbDocumento)
        Me.bNuevaProvincia.Controls.Add(Me.tbNombre)
        Me.bNuevaProvincia.Controls.Add(Me.tbCuit)
        Me.bNuevaProvincia.Controls.Add(Me.cbRespIVA)
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
        Me.bNuevaProvincia.Location = New System.Drawing.Point(12, 360)
        Me.bNuevaProvincia.Name = "bNuevaProvincia"
        Me.bNuevaProvincia.Size = New System.Drawing.Size(684, 316)
        Me.bNuevaProvincia.TabIndex = 1
        Me.bNuevaProvincia.TabStop = False
        Me.bNuevaProvincia.Text = "Datos Cliente"
        '
        'bNuevaLocalidad
        '
        Me.bNuevaLocalidad.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevaLocalidad.Location = New System.Drawing.Point(538, 154)
        Me.bNuevaLocalidad.Name = "bNuevaLocalidad"
        Me.bNuevaLocalidad.Size = New System.Drawing.Size(30, 23)
        Me.bNuevaLocalidad.TabIndex = 13
        Me.bNuevaLocalidad.TabStop = False
        Me.bNuevaLocalidad.Text = "..."
        Me.bNuevaLocalidad.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.Button2.Location = New System.Drawing.Point(278, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.TabStop = False
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbFechaNac
        '
        Me.tbFechaNac.Location = New System.Drawing.Point(111, 93)
        Me.tbFechaNac.Mask = "00/00/0000"
        Me.tbFechaNac.Name = "tbFechaNac"
        Me.tbFechaNac.Size = New System.Drawing.Size(84, 20)
        Me.tbFechaNac.TabIndex = 4
        Me.tbFechaNac.ValidatingType = GetType(Date)
        '
        'tbOcupacion
        '
        Me.tbOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbOcupacion.Location = New System.Drawing.Point(110, 234)
        Me.tbOcupacion.Name = "tbOcupacion"
        Me.tbOcupacion.Size = New System.Drawing.Size(222, 20)
        Me.tbOcupacion.TabIndex = 9
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(108, 195)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(222, 20)
        Me.tbTelefono.TabIndex = 8
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(108, 121)
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(224, 20)
        Me.tbDomicilio.TabIndex = 5
        '
        'tbDocumento
        '
        Me.tbDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDocumento.Location = New System.Drawing.Point(108, 58)
        Me.tbDocumento.Name = "tbDocumento"
        Me.tbDocumento.Size = New System.Drawing.Size(117, 20)
        Me.tbDocumento.TabIndex = 3
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
        Me.tbCuit.Location = New System.Drawing.Point(363, 269)
        Me.tbCuit.Mask = "##-########-#"
        Me.tbCuit.Name = "tbCuit"
        Me.tbCuit.Size = New System.Drawing.Size(100, 20)
        Me.tbCuit.TabIndex = 11
        '
        'cbRespIVA
        '
        Me.cbRespIVA.FormattingEnabled = True
        Me.cbRespIVA.Items.AddRange(New Object() {"MONOTRIBUTO", "R. INSCRIPTO", "C. FINAL", "EXENTO"})
        Me.cbRespIVA.Location = New System.Drawing.Point(110, 272)
        Me.cbRespIVA.Name = "cbRespIVA"
        Me.cbRespIVA.Size = New System.Drawing.Size(121, 21)
        Me.cbRespIVA.TabIndex = 10
        '
        'cbLocalidad
        '
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(382, 155)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(149, 21)
        Me.cbLocalidad.TabIndex = 7
        '
        'cbProvincia
        '
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(110, 155)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(162, 21)
        Me.cbProvincia.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Telefonos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Domicilio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CUIT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Localidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Provincia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ocupacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Resp. IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 58)
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
        'bSalir
        '
        Me.bSalir.Controls.Add(Me.b)
        Me.bSalir.Controls.Add(Me.bEliminar)
        Me.bSalir.Controls.Add(Me.bModificar)
        Me.bSalir.Controls.Add(Me.bNuevo)
        Me.bSalir.Location = New System.Drawing.Point(726, 24)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(184, 324)
        Me.bSalir.TabIndex = 2
        Me.bSalir.TabStop = False
        Me.bSalir.Text = "Acciones"
        '
        'b
        '
        Me.b.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b.Location = New System.Drawing.Point(17, 253)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(110, 50)
        Me.b.TabIndex = 15
        Me.b.Text = "Salir"
        Me.b.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(17, 183)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(110, 50)
        Me.bEliminar.TabIndex = 14
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
        Me.bModificar.TabIndex = 13
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(17, 36)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 54)
        Me.bNuevo.TabIndex = 12
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(556, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "* Campos Obligatorios"
        '
        'formClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 686)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bNuevaProvincia)
        Me.Controls.Add(Me.gbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Clientes"
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNuevaProvincia.ResumeLayout(False)
        Me.bNuevaProvincia.PerformLayout()
        Me.bSalir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents bNuevaProvincia As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.GroupBox
    Friend WithEvents b As System.Windows.Forms.Button
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
    Friend WithEvents cbRespIVA As System.Windows.Forms.ComboBox
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbFechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bNuevaLocalidad As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
