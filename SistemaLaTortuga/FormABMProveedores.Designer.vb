<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABMProveedores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgProveedores = New System.Windows.Forms.DataGridView()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbIdProveedor = New System.Windows.Forms.TextBox()
        Me.tbProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgProveedores)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 217)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedores"
        '
        'dgProveedores
        '
        Me.dgProveedores.AllowUserToAddRows = False
        Me.dgProveedores.AllowUserToDeleteRows = False
        Me.dgProveedores.AllowUserToResizeRows = False
        Me.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProveedor, Me.nombre, Me.domicilio, Me.telefono})
        Me.dgProveedores.Location = New System.Drawing.Point(6, 36)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProveedores.Size = New System.Drawing.Size(467, 165)
        Me.dgProveedores.TabIndex = 4
        Me.dgProveedores.TabStop = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(498, 13)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(115, 341)
        Me.gbAcciones.TabIndex = 10
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(16, 235)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(80, 34)
        Me.bSalir.TabIndex = 5
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(16, 179)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(80, 32)
        Me.bEliminar.TabIndex = 4
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(16, 119)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(80, 36)
        Me.bModificar.TabIndex = 3
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(16, 61)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 35)
        Me.bNuevo.TabIndex = 2
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbTelefono)
        Me.GroupBox2.Controls.Add(Me.tbDomicilio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbIdProveedor)
        Me.GroupBox2.Controls.Add(Me.tbProveedor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 121)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(102, 95)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(185, 20)
        Me.tbTelefono.TabIndex = 23
        '
        'tbDomicilio
        '
        Me.tbDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDomicilio.Location = New System.Drawing.Point(102, 57)
        Me.tbDomicilio.Name = "tbDomicilio"
        Me.tbDomicilio.Size = New System.Drawing.Size(185, 20)
        Me.tbDomicilio.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Domicilio"
        '
        'tbIdProveedor
        '
        Me.tbIdProveedor.Location = New System.Drawing.Point(326, 22)
        Me.tbIdProveedor.Name = "tbIdProveedor"
        Me.tbIdProveedor.Size = New System.Drawing.Size(41, 20)
        Me.tbIdProveedor.TabIndex = 19
        Me.tbIdProveedor.Visible = False
        '
        'tbProveedor
        '
        Me.tbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProveedor.Location = New System.Drawing.Point(102, 19)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.Size = New System.Drawing.Size(185, 20)
        Me.tbProveedor.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Proveedor"
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "IdProveedor"
        Me.idProveedor.HeaderText = "idProveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        Me.idProveedor.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NombreProveedor"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'domicilio
        '
        Me.domicilio.DataPropertyName = "DomicilioProveedor"
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "TelefonoProveedor"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 120
        '
        'FormABMProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 360)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormABMProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents idProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents tbProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
