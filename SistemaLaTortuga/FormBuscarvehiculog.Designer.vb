<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formbuscavehiculoactivo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgVehiculos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.idVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVxC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 68)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(345, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgVehiculos)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 331)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'dgVehiculos
        '
        Me.dgVehiculos.AllowUserToAddRows = False
        Me.dgVehiculos.AllowUserToDeleteRows = False
        Me.dgVehiculos.AllowUserToResizeRows = False
        Me.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVehiculo, Me.idVxC, Me.marca, Me.modelo, Me.tipoVehiculo, Me.año, Me.dominio})
        Me.dgVehiculos.Location = New System.Drawing.Point(6, 19)
        Me.dgVehiculos.Name = "dgVehiculos"
        Me.dgVehiculos.ReadOnly = True
        Me.dgVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculos.Size = New System.Drawing.Size(720, 293)
        Me.dgVehiculos.TabIndex = 10
        Me.dgVehiculos.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbBusqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 38)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(282, 12)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(188, 20)
        Me.tbBusqueda.TabIndex = 10
        '
        'idVehiculo
        '
        Me.idVehiculo.DataPropertyName = "IdVehiculo"
        Me.idVehiculo.HeaderText = "idVehiculo"
        Me.idVehiculo.Name = "idVehiculo"
        Me.idVehiculo.ReadOnly = True
        Me.idVehiculo.Visible = False
        '
        'idVxC
        '
        Me.idVxC.DataPropertyName = "IdVxC"
        Me.idVxC.HeaderText = "idVxC"
        Me.idVxC.Name = "idVxC"
        Me.idVxC.ReadOnly = True
        Me.idVxC.Visible = False
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
        'tipoVehiculo
        '
        Me.tipoVehiculo.DataPropertyName = "Tipo"
        Me.tipoVehiculo.HeaderText = "Tipo Vehiculo"
        Me.tipoVehiculo.Name = "tipoVehiculo"
        Me.tipoVehiculo.ReadOnly = True
        Me.tipoVehiculo.Width = 150
        '
        'año
        '
        Me.año.DataPropertyName = "Año"
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        Me.año.Width = 70
        '
        'dominio
        '
        Me.dominio.DataPropertyName = "Dominio"
        Me.dominio.HeaderText = "Dominio"
        Me.dominio.Name = "dominio"
        Me.dominio.ReadOnly = True
        Me.dominio.Width = 70
        '
        'formbuscavehiculoactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 451)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formbuscavehiculoactivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dgVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents idVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idVxC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dominio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
