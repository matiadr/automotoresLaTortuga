﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbClientes.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosCliente.SuspendLayout()
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
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.tbFechaNac)
        Me.gbDatosCliente.Controls.Add(Me.tbOcupacion)
        Me.gbDatosCliente.Controls.Add(Me.tbTelefono)
        Me.gbDatosCliente.Controls.Add(Me.tbDomicilio)
        Me.gbDatosCliente.Controls.Add(Me.tbDocumento)
        Me.gbDatosCliente.Controls.Add(Me.tbNombre)
        Me.gbDatosCliente.Controls.Add(Me.tbCuit)
        Me.gbDatosCliente.Controls.Add(Me.cbRespIVA)
        Me.gbDatosCliente.Controls.Add(Me.cbLocalidad)
        Me.gbDatosCliente.Controls.Add(Me.cbProvincia)
        Me.gbDatosCliente.Controls.Add(Me.Label11)
        Me.gbDatosCliente.Controls.Add(Me.Label10)
        Me.gbDatosCliente.Controls.Add(Me.Label9)
        Me.gbDatosCliente.Controls.Add(Me.Label4)
        Me.gbDatosCliente.Controls.Add(Me.Label8)
        Me.gbDatosCliente.Controls.Add(Me.Label7)
        Me.gbDatosCliente.Controls.Add(Me.Label6)
        Me.gbDatosCliente.Controls.Add(Me.Label5)
        Me.gbDatosCliente.Controls.Add(Me.Label3)
        Me.gbDatosCliente.Controls.Add(Me.Label2)
        Me.gbDatosCliente.Location = New System.Drawing.Point(12, 360)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(684, 316)
        Me.gbDatosCliente.TabIndex = 1
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos Cliente"
        '
        'tbOcupacion
        '
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
        Me.tbDomicilio.Location = New System.Drawing.Point(108, 121)
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(224, 20)
        Me.tbDomicilio.TabIndex = 5
        '
        'tbDocumento
        '
        Me.tbDocumento.Location = New System.Drawing.Point(108, 58)
        Me.tbDocumento.Name = "tbDocumento"
        Me.tbDocumento.Size = New System.Drawing.Size(117, 20)
        Me.tbDocumento.TabIndex = 3
        '
        'tbNombre
        '
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
        Me.cbLocalidad.Location = New System.Drawing.Point(363, 155)
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
        Me.Label8.Location = New System.Drawing.Point(304, 155)
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
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nro Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'bSalir
        '
        Me.bSalir.Controls.Add(Me.b)
        Me.bSalir.Controls.Add(Me.bEliminar)
        Me.bSalir.Controls.Add(Me.bModificar)
        Me.bSalir.Controls.Add(Me.Button1)
        Me.bSalir.Location = New System.Drawing.Point(726, 24)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(184, 336)
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
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 54)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
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
        'formClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 686)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Controls.Add(Me.gbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Clientes"
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.bSalir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents gbDatosCliente As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.GroupBox
    Friend WithEvents b As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
End Class
