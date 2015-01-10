<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formsucursalesbancos
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
        Me.textform = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgsucursalesb = New System.Windows.Forms.DataGridView()
        Me.IdSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bNuevoCliente = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgsucursalesb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textform)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 69)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'textform
        '
        Me.textform.Location = New System.Drawing.Point(404, 25)
        Me.textform.Name = "textform"
        Me.textform.Size = New System.Drawing.Size(68, 20)
        Me.textform.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(243, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgsucursalesb)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 310)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'dgsucursalesb
        '
        Me.dgsucursalesb.AllowUserToAddRows = False
        Me.dgsucursalesb.AllowUserToDeleteRows = False
        Me.dgsucursalesb.AllowUserToResizeRows = False
        Me.dgsucursalesb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsucursalesb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSucursal, Me.CodigoSucursal, Me.NombreSucursal, Me.CodigoBanco, Me.NombreBanco})
        Me.dgsucursalesb.Location = New System.Drawing.Point(10, 22)
        Me.dgsucursalesb.Name = "dgsucursalesb"
        Me.dgsucursalesb.ReadOnly = True
        Me.dgsucursalesb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgsucursalesb.Size = New System.Drawing.Size(547, 267)
        Me.dgsucursalesb.TabIndex = 7
        Me.dgsucursalesb.TabStop = False
        '
        'IdSucursal
        '
        Me.IdSucursal.DataPropertyName = "IdSucursal"
        Me.IdSucursal.HeaderText = "Sucursal"
        Me.IdSucursal.Name = "IdSucursal"
        Me.IdSucursal.ReadOnly = True
        Me.IdSucursal.Visible = False
        '
        'CodigoSucursal
        '
        Me.CodigoSucursal.DataPropertyName = "CodigoSucursal"
        Me.CodigoSucursal.HeaderText = "Código"
        Me.CodigoSucursal.Name = "CodigoSucursal"
        Me.CodigoSucursal.ReadOnly = True
        '
        'NombreSucursal
        '
        Me.NombreSucursal.DataPropertyName = "NombreSucursal"
        Me.NombreSucursal.HeaderText = "Sucursal"
        Me.NombreSucursal.Name = "NombreSucursal"
        Me.NombreSucursal.ReadOnly = True
        Me.NombreSucursal.Width = 150
        '
        'CodigoBanco
        '
        Me.CodigoBanco.DataPropertyName = "CodigoBanco"
        Me.CodigoBanco.HeaderText = "Código"
        Me.CodigoBanco.Name = "CodigoBanco"
        Me.CodigoBanco.ReadOnly = True
        '
        'NombreBanco
        '
        Me.NombreBanco.DataPropertyName = "NombreBanco"
        Me.NombreBanco.HeaderText = "Banco"
        Me.NombreBanco.Name = "NombreBanco"
        Me.NombreBanco.ReadOnly = True
        Me.NombreBanco.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bNuevoCliente)
        Me.GroupBox3.Controls.Add(Me.label1)
        Me.GroupBox3.Controls.Add(Me.tbBusqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(562, 46)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.bNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevoCliente.Location = New System.Drawing.Point(355, 12)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(110, 23)
        Me.bNuevoCliente.TabIndex = 13
        Me.bNuevoCliente.Text = "Nueva Sucursal"
        Me.bNuevoCliente.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(97, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(143, 14)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(188, 20)
        Me.tbBusqueda.TabIndex = 11
        '
        'formsucursalesbancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 434)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "formsucursalesbancos"
        Me.Text = "Sucursales Bancos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgsucursalesb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textform As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsucursalesb As System.Windows.Forms.DataGridView
    Friend WithEvents IdSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
End Class
