<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConsultaVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formConsultaVehiculos))
        Me.dgStockVehiculos = New System.Windows.Forms.DataGridView()
        Me.dueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.rbEnStock = New System.Windows.Forms.RadioButton()
        Me.rbVendidos = New System.Windows.Forms.RadioButton()
        CType(Me.dgStockVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgStockVehiculos
        '
        Me.dgStockVehiculos.AllowUserToAddRows = False
        Me.dgStockVehiculos.AllowUserToDeleteRows = False
        Me.dgStockVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dueño, Me.dni, Me.marca, Me.modelo, Me.tipo, Me.dominio, Me.fechaAlta, Me.precioCosto, Me.año})
        Me.dgStockVehiculos.Location = New System.Drawing.Point(25, 54)
        Me.dgStockVehiculos.Name = "dgStockVehiculos"
        Me.dgStockVehiculos.ReadOnly = True
        Me.dgStockVehiculos.Size = New System.Drawing.Size(828, 322)
        Me.dgStockVehiculos.TabIndex = 0
        '
        'dueño
        '
        Me.dueño.DataPropertyName = "NombreC"
        Me.dueño.HeaderText = "Dueño"
        Me.dueño.Name = "dueño"
        Me.dueño.ReadOnly = True
        '
        'dni
        '
        Me.dni.DataPropertyName = "NumeroDni"
        Me.dni.HeaderText = "Dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'marca
        '
        Me.marca.DataPropertyName = "NombreMarca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "NombreModelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "Tipo"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'dominio
        '
        Me.dominio.DataPropertyName = "Dominio"
        Me.dominio.HeaderText = "Dominio"
        Me.dominio.Name = "dominio"
        Me.dominio.ReadOnly = True
        '
        'fechaAlta
        '
        Me.fechaAlta.DataPropertyName = "FechaAlta"
        Me.fechaAlta.HeaderText = "Fecha Alta"
        Me.fechaAlta.Name = "fechaAlta"
        Me.fechaAlta.ReadOnly = True
        '
        'precioCosto
        '
        Me.precioCosto.DataPropertyName = "PrecioCosto"
        Me.precioCosto.HeaderText = "Precio Costo"
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = True
        '
        'año
        '
        Me.año.DataPropertyName = "Año"
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        Me.año.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(91, 24)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(194, 20)
        Me.tbBusqueda.TabIndex = 2
        '
        'rbEnStock
        '
        Me.rbEnStock.AutoSize = True
        Me.rbEnStock.Checked = True
        Me.rbEnStock.Location = New System.Drawing.Point(305, 27)
        Me.rbEnStock.Name = "rbEnStock"
        Me.rbEnStock.Size = New System.Drawing.Size(69, 17)
        Me.rbEnStock.TabIndex = 3
        Me.rbEnStock.TabStop = True
        Me.rbEnStock.Text = "En Stock"
        Me.rbEnStock.UseVisualStyleBackColor = True
        '
        'rbVendidos
        '
        Me.rbVendidos.AutoSize = True
        Me.rbVendidos.Location = New System.Drawing.Point(419, 27)
        Me.rbVendidos.Name = "rbVendidos"
        Me.rbVendidos.Size = New System.Drawing.Size(69, 17)
        Me.rbVendidos.TabIndex = 4
        Me.rbVendidos.Text = "Vendidos"
        Me.rbVendidos.UseVisualStyleBackColor = True
        '
        'formConsultaVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 394)
        Me.Controls.Add(Me.rbVendidos)
        Me.Controls.Add(Me.rbEnStock)
        Me.Controls.Add(Me.tbBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgStockVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "formConsultaVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock de Vehiculos"
        CType(Me.dgStockVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgStockVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dominio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbEnStock As System.Windows.Forms.RadioButton
    Friend WithEvents rbVendidos As System.Windows.Forms.RadioButton
End Class
