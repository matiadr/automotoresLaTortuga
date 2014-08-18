<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bNuevo
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
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgVehiculos = New System.Windows.Forms.DataGridView()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.Nue = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbCuentas.SuspendLayout()
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCuentas
        '
        Me.gbCuentas.Controls.Add(Me.tbBusqueda)
        Me.gbCuentas.Controls.Add(Me.Label1)
        Me.gbCuentas.Controls.Add(Me.dgVehiculos)
        Me.gbCuentas.Location = New System.Drawing.Point(12, 12)
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.Size = New System.Drawing.Size(568, 386)
        Me.gbCuentas.TabIndex = 2
        Me.gbCuentas.TabStop = False
        Me.gbCuentas.Text = "Cuentas"
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
        Me.dgVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.nombre, Me.tipoCuenta, Me.rubro, Me.saldo})
        Me.dgVehiculos.Location = New System.Drawing.Point(13, 63)
        Me.dgVehiculos.Name = "dgVehiculos"
        Me.dgVehiculos.ReadOnly = True
        Me.dgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculos.Size = New System.Drawing.Size(506, 304)
        Me.dgVehiculos.TabIndex = 0
        Me.dgVehiculos.TabStop = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.Nue)
        Me.gbAcciones.Location = New System.Drawing.Point(610, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(184, 336)
        Me.gbAcciones.TabIndex = 4
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
        'Nue
        '
        Me.Nue.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Nue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nue.Location = New System.Drawing.Point(17, 36)
        Me.Nue.Name = "Nue"
        Me.Nue.Size = New System.Drawing.Size(110, 54)
        Me.Nue.TabIndex = 1
        Me.Nue.Text = "Nuevo"
        Me.Nue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(25, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 257)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta"
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "idCuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'tipoCuenta
        '
        Me.tipoCuenta.HeaderText = "Tipo Cuenta"
        Me.tipoCuenta.Name = "tipoCuenta"
        Me.tipoCuenta.ReadOnly = True
        '
        'rubro
        '
        Me.rubro.HeaderText = "Rubro"
        Me.rubro.Name = "rubro"
        Me.rubro.ReadOnly = True
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'bNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 703)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.Controls.Add(Me.gbCuentas)
        Me.Name = "bNuevo"
        Me.Text = "Administrar Cuentas"
        Me.gbCuentas.ResumeLayout(False)
        Me.gbCuentas.PerformLayout()
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents Nue As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
