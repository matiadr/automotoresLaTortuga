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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgStockVehiculos = New System.Windows.Forms.DataGridView()
        Me.Dueño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbVendidos = New System.Windows.Forms.RadioButton()
        Me.rbEnStock = New System.Windows.Forms.RadioButton()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgStockVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgStockVehiculos)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 353)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dgStockVehiculos
        '
        Me.dgStockVehiculos.AllowUserToAddRows = False
        Me.dgStockVehiculos.AllowUserToDeleteRows = False
        Me.dgStockVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStockVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dueño, Me.dni, Me.marca, Me.modelo, Me.tipo, Me.dominio, Me.fechaAlta, Me.precioCosto, Me.año})
        Me.dgStockVehiculos.Location = New System.Drawing.Point(8, 24)
        Me.dgStockVehiculos.Name = "dgStockVehiculos"
        Me.dgStockVehiculos.ReadOnly = True
        Me.dgStockVehiculos.Size = New System.Drawing.Size(966, 322)
        Me.dgStockVehiculos.TabIndex = 1
        '
        'Dueño
        '
        Me.Dueño.DataPropertyName = "NombreC"
        Me.Dueño.HeaderText = "Propietario"
        Me.Dueño.Name = "Dueño"
        Me.Dueño.ReadOnly = True
        Me.Dueño.Width = 150
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
        Me.marca.Width = 150
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "NombreModelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 150
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
        Me.dominio.Width = 80
        '
        'fechaAlta
        '
        Me.fechaAlta.DataPropertyName = "FechaAlta"
        Me.fechaAlta.HeaderText = "Fecha Alta"
        Me.fechaAlta.Name = "fechaAlta"
        Me.fechaAlta.ReadOnly = True
        Me.fechaAlta.Width = 90
        '
        'precioCosto
        '
        Me.precioCosto.DataPropertyName = "PrecioCosto"
        Me.precioCosto.HeaderText = "Precio Costo"
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = True
        Me.precioCosto.Width = 90
        '
        'año
        '
        Me.año.DataPropertyName = "Año"
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        Me.año.Visible = False
        Me.año.Width = 70
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbVendidos)
        Me.GroupBox2.Controls.Add(Me.rbEnStock)
        Me.GroupBox2.Controls.Add(Me.tbBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(981, 64)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'rbVendidos
        '
        Me.rbVendidos.AutoSize = True
        Me.rbVendidos.Location = New System.Drawing.Point(623, 22)
        Me.rbVendidos.Name = "rbVendidos"
        Me.rbVendidos.Size = New System.Drawing.Size(69, 17)
        Me.rbVendidos.TabIndex = 8
        Me.rbVendidos.Text = "Vendidos"
        Me.rbVendidos.UseVisualStyleBackColor = True
        '
        'rbEnStock
        '
        Me.rbEnStock.AutoSize = True
        Me.rbEnStock.Checked = True
        Me.rbEnStock.Location = New System.Drawing.Point(509, 22)
        Me.rbEnStock.Name = "rbEnStock"
        Me.rbEnStock.Size = New System.Drawing.Size(69, 17)
        Me.rbEnStock.TabIndex = 7
        Me.rbEnStock.TabStop = True
        Me.rbEnStock.Text = "En Stock"
        Me.rbEnStock.UseVisualStyleBackColor = True
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(295, 19)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(194, 20)
        Me.tbBusqueda.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 424)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(980, 69)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(425, 23)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(103, 40)
        Me.bSalir.TabIndex = 22
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'formConsultaVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 500)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formConsultaVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock de Vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgStockVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgStockVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents Dueño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dominio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVendidos As System.Windows.Forms.RadioButton
    Friend WithEvents rbEnStock As System.Windows.Forms.RadioButton
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
End Class
