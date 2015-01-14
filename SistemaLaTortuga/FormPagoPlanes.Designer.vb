<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoPlanes
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGcuotas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechacuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalleplan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idplan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numerocuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importecuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGcuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(588, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 257)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGcuotas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 180)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'DGcuotas
        '
        Me.DGcuotas.AllowUserToAddRows = False
        Me.DGcuotas.AllowUserToDeleteRows = False
        Me.DGcuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechacuota, Me.detalleplan, Me.idplan, Me.idcliente, Me.idcuota, Me.numerocuota, Me.importecuota, Me.pago})
        Me.DGcuotas.Location = New System.Drawing.Point(7, 16)
        Me.DGcuotas.Name = "DGcuotas"
        Me.DGcuotas.ReadOnly = True
        Me.DGcuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGcuotas.Size = New System.Drawing.Size(545, 158)
        Me.DGcuotas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ComboCliente
        '
        Me.ComboCliente.DisplayMember = "NombreC"
        Me.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(14, 30)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(268, 21)
        Me.ComboCliente.TabIndex = 4
        Me.ComboCliente.ValueMember = "IdCliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'fechacuota
        '
        Me.fechacuota.DataPropertyName = "fechacuota"
        Me.fechacuota.HeaderText = "Fecha"
        Me.fechacuota.Name = "fechacuota"
        Me.fechacuota.ReadOnly = True
        Me.fechacuota.Width = 80
        '
        'detalleplan
        '
        Me.detalleplan.DataPropertyName = "detalleplan"
        Me.detalleplan.HeaderText = "Plan"
        Me.detalleplan.Name = "detalleplan"
        Me.detalleplan.ReadOnly = True
        Me.detalleplan.Width = 150
        '
        'idplan
        '
        Me.idplan.DataPropertyName = "idplan"
        Me.idplan.HeaderText = "idplan"
        Me.idplan.Name = "idplan"
        Me.idplan.ReadOnly = True
        Me.idplan.Visible = False
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'idcuota
        '
        Me.idcuota.DataPropertyName = "idcuota"
        Me.idcuota.HeaderText = "idcuota"
        Me.idcuota.Name = "idcuota"
        Me.idcuota.ReadOnly = True
        Me.idcuota.Visible = False
        '
        'numerocuota
        '
        Me.numerocuota.DataPropertyName = "numerocuota"
        Me.numerocuota.HeaderText = "Cuota N°"
        Me.numerocuota.Name = "numerocuota"
        Me.numerocuota.ReadOnly = True
        Me.numerocuota.Width = 80
        '
        'importecuota
        '
        Me.importecuota.DataPropertyName = "importecuota"
        Me.importecuota.HeaderText = "Importe"
        Me.importecuota.Name = "importecuota"
        Me.importecuota.ReadOnly = True
        Me.importecuota.Width = 80
        '
        'pago
        '
        Me.pago.DataPropertyName = "pago"
        Me.pago.HeaderText = "Pago"
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Width = 80
        '
        'FormPagoPlanes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 299)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormPagoPlanes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGcuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGcuotas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents fechacuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalleplan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idplan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numerocuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importecuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pago As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
