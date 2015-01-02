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
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textidventa = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Size = New System.Drawing.Size(769, 482)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DGventas
        '
        Me.DGventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaVenta, Me.Comprador, Me.Vehiculo, Me.Marca, Me.Modelo, Me.Año, Me.Dominio})
        Me.DGventas.Location = New System.Drawing.Point(10, 17)
        Me.DGventas.Name = "DGventas"
        Me.DGventas.Size = New System.Drawing.Size(753, 452)
        Me.DGventas.TabIndex = 0
        '
        'FechaVenta
        '
        Me.FechaVenta.DataPropertyName = "FechaVenta"
        Me.FechaVenta.HeaderText = "FechaVenta"
        Me.FechaVenta.Name = "FechaVenta"
        '
        'Comprador
        '
        Me.Comprador.DataPropertyName = "NombreC"
        Me.Comprador.HeaderText = "Comprador"
        Me.Comprador.Name = "Comprador"
        '
        'Vehiculo
        '
        Me.Vehiculo.DataPropertyName = "Tipo"
        Me.Vehiculo.HeaderText = "Vehiculo"
        Me.Vehiculo.Name = "Vehiculo"
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "NombreMarca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "NombreModelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        '
        'Año
        '
        Me.Año.DataPropertyName = "año"
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        '
        'Dominio
        '
        Me.Dominio.DataPropertyName = "Dominio"
        Me.Dominio.HeaderText = "Dominio"
        Me.Dominio.Name = "Dominio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textidventa)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.TextBox1.Location = New System.Drawing.Point(183, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(787, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 529)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nueva"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formlistadoventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 547)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formlistadoventas"
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textidventa As System.Windows.Forms.TextBox
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dominio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
