<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCuentas
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
        Me.gbCuentas = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbNombreCuenta = New System.Windows.Forms.RadioButton()
        Me.rbRubro = New System.Windows.Forms.RadioButton()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalleCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.gbCuenta = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tbIdCuenta = New System.Windows.Forms.TextBox()
        Me.tbDetalleCuenta = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bNuevoRubro = New System.Windows.Forms.Button()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.tbSaldo = New System.Windows.Forms.TextBox()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbCuentas.SuspendLayout()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.gbCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCuentas
        '
        Me.gbCuentas.Controls.Add(Me.Label6)
        Me.gbCuentas.Controls.Add(Me.rbNombreCuenta)
        Me.gbCuentas.Controls.Add(Me.rbRubro)
        Me.gbCuentas.Controls.Add(Me.tbBusqueda)
        Me.gbCuentas.Controls.Add(Me.Label1)
        Me.gbCuentas.Controls.Add(Me.dgCuentas)
        Me.gbCuentas.Location = New System.Drawing.Point(12, 12)
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.Size = New System.Drawing.Size(562, 386)
        Me.gbCuentas.TabIndex = 2
        Me.gbCuentas.TabStop = False
        Me.gbCuentas.Text = "Cuentas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Filtar por"
        '
        'rbNombreCuenta
        '
        Me.rbNombreCuenta.AutoSize = True
        Me.rbNombreCuenta.Checked = True
        Me.rbNombreCuenta.Location = New System.Drawing.Point(73, 55)
        Me.rbNombreCuenta.Name = "rbNombreCuenta"
        Me.rbNombreCuenta.Size = New System.Drawing.Size(99, 17)
        Me.rbNombreCuenta.TabIndex = 3
        Me.rbNombreCuenta.TabStop = True
        Me.rbNombreCuenta.Text = "Nombre Cuenta"
        Me.rbNombreCuenta.UseVisualStyleBackColor = True
        '
        'rbRubro
        '
        Me.rbRubro.AutoSize = True
        Me.rbRubro.Location = New System.Drawing.Point(187, 55)
        Me.rbRubro.Name = "rbRubro"
        Me.rbRubro.Size = New System.Drawing.Size(54, 17)
        Me.rbRubro.TabIndex = 2
        Me.rbRubro.Text = "Rubro"
        Me.rbRubro.UseVisualStyleBackColor = True
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(68, 26)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(141, 20)
        Me.tbBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar "
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.AllowUserToDeleteRows = False
        Me.dgCuentas.AllowUserToResizeRows = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.nombre, Me.tipoCuenta, Me.rubro, Me.saldo, Me.idRubro, Me.detalleCuenta})
        Me.dgCuentas.Location = New System.Drawing.Point(19, 82)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.ReadOnly = True
        Me.dgCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentas.Size = New System.Drawing.Size(522, 298)
        Me.dgCuentas.TabIndex = 0
        Me.dgCuentas.TabStop = False
        '
        'idCuenta
        '
        Me.idCuenta.DataPropertyName = "IdCuenta"
        Me.idCuenta.HeaderText = "idCuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NombreCuenta"
        Me.nombre.HeaderText = "Nombre Cuenta"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 120
        '
        'tipoCuenta
        '
        Me.tipoCuenta.DataPropertyName = "TipoCuenta"
        Me.tipoCuenta.HeaderText = "Tipo Cuenta"
        Me.tipoCuenta.Name = "tipoCuenta"
        Me.tipoCuenta.ReadOnly = True
        Me.tipoCuenta.Width = 50
        '
        'rubro
        '
        Me.rubro.DataPropertyName = "NombreRubro"
        Me.rubro.HeaderText = "Rubro"
        Me.rubro.Name = "rubro"
        Me.rubro.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "SaldoCuenta"
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'idRubro
        '
        Me.idRubro.DataPropertyName = "IdRubro"
        Me.idRubro.HeaderText = "idRubro"
        Me.idRubro.Name = "idRubro"
        Me.idRubro.ReadOnly = True
        Me.idRubro.Visible = False
        '
        'detalleCuenta
        '
        Me.detalleCuenta.DataPropertyName = "DetalleCuenta"
        Me.detalleCuenta.HeaderText = "detalleCuenta"
        Me.detalleCuenta.Name = "detalleCuenta"
        Me.detalleCuenta.ReadOnly = True
        Me.detalleCuenta.Visible = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(592, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(162, 386)
        Me.gbAcciones.TabIndex = 4
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
        Me.bSalir.TabIndex = 11
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
        Me.bEliminar.TabIndex = 10
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
        Me.bModificar.TabIndex = 9
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(17, 36)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 54)
        Me.bNuevo.TabIndex = 8
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'gbCuenta
        '
        Me.gbCuenta.Controls.Add(Me.Label8)
        Me.gbCuenta.Controls.Add(Me.bLimpiar)
        Me.gbCuenta.Controls.Add(Me.tbIdCuenta)
        Me.gbCuenta.Controls.Add(Me.tbDetalleCuenta)
        Me.gbCuenta.Controls.Add(Me.Label7)
        Me.gbCuenta.Controls.Add(Me.bNuevoRubro)
        Me.gbCuenta.Controls.Add(Me.cbRubro)
        Me.gbCuenta.Controls.Add(Me.rbResta)
        Me.gbCuenta.Controls.Add(Me.tbSaldo)
        Me.gbCuenta.Controls.Add(Me.rbSuma)
        Me.gbCuenta.Controls.Add(Me.Label4)
        Me.gbCuenta.Controls.Add(Me.Label2)
        Me.gbCuenta.Controls.Add(Me.tbNombre)
        Me.gbCuenta.Controls.Add(Me.Label3)
        Me.gbCuenta.Controls.Add(Me.Label5)
        Me.gbCuenta.Location = New System.Drawing.Point(12, 404)
        Me.gbCuenta.Name = "gbCuenta"
        Me.gbCuenta.Size = New System.Drawing.Size(562, 187)
        Me.gbCuenta.TabIndex = 5
        Me.gbCuenta.TabStop = False
        Me.gbCuenta.Text = "Cuenta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "* Campos Obligatorios"
        '
        'bLimpiar
        '
        Me.bLimpiar.Location = New System.Drawing.Point(416, 29)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.bLimpiar.TabIndex = 13
        Me.bLimpiar.TabStop = False
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'tbIdCuenta
        '
        Me.tbIdCuenta.Location = New System.Drawing.Point(298, 19)
        Me.tbIdCuenta.Name = "tbIdCuenta"
        Me.tbIdCuenta.Size = New System.Drawing.Size(59, 20)
        Me.tbIdCuenta.TabIndex = 12
        Me.tbIdCuenta.TabStop = False
        Me.tbIdCuenta.Visible = False
        '
        'tbDetalleCuenta
        '
        Me.tbDetalleCuenta.Location = New System.Drawing.Point(341, 67)
        Me.tbDetalleCuenta.Name = "tbDetalleCuenta"
        Me.tbDetalleCuenta.Size = New System.Drawing.Size(169, 49)
        Me.tbDetalleCuenta.TabIndex = 7
        Me.tbDetalleCuenta.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Detalle"
        '
        'bNuevoRubro
        '
        Me.bNuevoRubro.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevoRubro.Location = New System.Drawing.Point(220, 106)
        Me.bNuevoRubro.Name = "bNuevoRubro"
        Me.bNuevoRubro.Size = New System.Drawing.Size(32, 23)
        Me.bNuevoRubro.TabIndex = 9
        Me.bNuevoRubro.Text = "..."
        Me.bNuevoRubro.UseVisualStyleBackColor = True
        '
        'cbRubro
        '
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(88, 108)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(121, 21)
        Me.cbRubro.TabIndex = 5
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(157, 68)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 17)
        Me.rbResta.TabIndex = 4
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'tbSaldo
        '
        Me.tbSaldo.Location = New System.Drawing.Point(87, 149)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.Size = New System.Drawing.Size(122, 20)
        Me.tbSaldo.TabIndex = 6
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Checked = True
        Me.rbSuma.Location = New System.Drawing.Point(88, 68)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(55, 17)
        Me.rbSuma.TabIndex = 3
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma "
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Saldo *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre *"
        '
        'tbNombre
        '
        Me.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombre.Location = New System.Drawing.Point(88, 32)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(164, 20)
        Me.tbNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Rubro *"
        '
        'formCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 601)
        Me.Controls.Add(Me.gbAcciones)
        Me.Controls.Add(Me.gbCuentas)
        Me.Controls.Add(Me.gbCuenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Cuentas"
        Me.gbCuentas.ResumeLayout(False)
        Me.gbCuentas.PerformLayout()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.gbCuenta.ResumeLayout(False)
        Me.gbCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents gbCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bNuevoRubro As System.Windows.Forms.Button
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents rbResta As System.Windows.Forms.RadioButton
    Friend WithEvents tbSaldo As System.Windows.Forms.TextBox
    Friend WithEvents rbSuma As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbNombreCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbRubro As System.Windows.Forms.RadioButton
    Friend WithEvents idCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idRubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalleCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbDetalleCuenta As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents bLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
