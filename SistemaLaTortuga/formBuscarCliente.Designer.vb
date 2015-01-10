<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBuscarCliente
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
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbBusqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textform)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 59)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'textform
        '
        Me.textform.Location = New System.Drawing.Point(324, 29)
        Me.textform.Name = "textform"
        Me.textform.Size = New System.Drawing.Size(68, 20)
        Me.textform.TabIndex = 7
        Me.textform.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(150, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 316)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.AllowUserToResizeRows = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCliente, Me.dni, Me.nombre})
        Me.dgClientes.Location = New System.Drawing.Point(29, 19)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(346, 291)
        Me.dgClientes.TabIndex = 1
        Me.dgClientes.TabStop = False
        '
        'idCliente
        '
        Me.idCliente.DataPropertyName = "IdCliente"
        Me.idCliente.HeaderText = "idCliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Visible = False
        '
        'dni
        '
        Me.dni.DataPropertyName = "NumeroDni"
        Me.dni.HeaderText = "Dni"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NombreC"
        Me.nombre.FillWeight = 150.0!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.label1)
        Me.GroupBox3.Controls.Add(Me.tbBusqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 44)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(71, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Buscar"
        '
        'tbBusqueda
        '
        Me.tbBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBusqueda.Location = New System.Drawing.Point(117, 13)
        Me.tbBusqueda.Name = "tbBusqueda"
        Me.tbBusqueda.Size = New System.Drawing.Size(188, 20)
        Me.tbBusqueda.TabIndex = 5
        '
        'formBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 427)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textform As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents tbBusqueda As System.Windows.Forms.TextBox
End Class
