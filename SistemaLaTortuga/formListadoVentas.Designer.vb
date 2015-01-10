<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlistadoventas
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
        Me.DGventas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textidventa = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGventas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 482)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DGventas
        '
        Me.DGventas.AllowUserToAddRows = False
        Me.DGventas.AllowUserToDeleteRows = False
        Me.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaVenta, Me.Comprador, Me.Vehiculo, Me.Marca, Me.Modelo, Me.Año, Me.Dominio})
        Me.DGventas.Location = New System.Drawing.Point(10, 17)
        Me.DGventas.Name = "DGventas"
        Me.DGventas.ReadOnly = True
        Me.DGventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGventas.Size = New System.Drawing.Size(865, 452)
        Me.DGventas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.textidventa)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(890, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar"
        '
        'textidventa
        '
        Me.textidventa.Location = New System.Drawing.Point(17, 16)
        Me.textidventa.Name = "textidventa"
        Me.textidventa.Size = New System.Drawing.Size(46, 20)
        Me.textidventa.TabIndex = 1
        Me.textidventa.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(370, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 541)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(891, 63)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(411, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FechaVenta
        '
        Me.FechaVenta.DataPropertyName = "FechaVenta"
        Me.FechaVenta.HeaderText = "Fecha"
        Me.FechaVenta.Name = "FechaVenta"
        Me.FechaVenta.ReadOnly = True
        '
        'Comprador
        '
        Me.Comprador.DataPropertyName = "NombreC"
        Me.Comprador.HeaderText = "Comprador"
        Me.Comprador.Name = "Comprador"
        Me.Comprador.ReadOnly = True
        Me.Comprador.Width = 200
        '
        'Vehiculo
        '
        Me.Vehiculo.DataPropertyName = "Tipo"
        Me.Vehiculo.HeaderText = "Vehiculo"
        Me.Vehiculo.Name = "Vehiculo"
        Me.Vehiculo.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "NombreMarca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 150
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "NombreModelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'Año
        '
        Me.Año.DataPropertyName = "año"
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        Me.Año.ReadOnly = True
        Me.Año.Width = 80
        '
        'Dominio
        '
        Me.Dominio.DataPropertyName = "Dominio"
        Me.Dominio.HeaderText = "Dominio"
        Me.Dominio.Name = "Dominio"
        Me.Dominio.ReadOnly = True
        Me.Dominio.Width = 90
        '
        'formlistadoventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 642)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "formlistadoventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGventas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents textidventa As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dominio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
