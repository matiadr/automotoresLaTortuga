<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoDocumentos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGdocumentos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGpagos = New System.Windows.Forms.DataGridView()
        Me.textid = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGdocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'ComboCliente
        '
        Me.ComboCliente.DisplayMember = "NombreC"
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(16, 33)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(241, 21)
        Me.ComboCliente.TabIndex = 0
        Me.ComboCliente.ValueMember = "IdCliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGdocumentos)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DGdocumentos
        '
        Me.DGdocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Importe, Me.Marca, Me.Modelo, Me.Dominio})
        Me.DGdocumentos.Location = New System.Drawing.Point(10, 16)
        Me.DGdocumentos.Name = "DGdocumentos"
        Me.DGdocumentos.Size = New System.Drawing.Size(651, 136)
        Me.DGdocumentos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGpagos)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 163)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pagos"
        '
        'DGpagos
        '
        Me.DGpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaPago, Me.ImportePago, Me.FormaPago, Me.Numero, Me.Banco})
        Me.DGpagos.Location = New System.Drawing.Point(12, 21)
        Me.DGpagos.Name = "DGpagos"
        Me.DGpagos.Size = New System.Drawing.Size(635, 141)
        Me.DGpagos.TabIndex = 0
        '
        'textid
        '
        Me.textid.Location = New System.Drawing.Point(564, 28)
        Me.textid.Name = "textid"
        Me.textid.Size = New System.Drawing.Size(64, 20)
        Me.textid.TabIndex = 3
        Me.textid.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        '
        'Dominio
        '
        Me.Dominio.DataPropertyName = "Dominio"
        Me.Dominio.HeaderText = "Dominio"
        Me.Dominio.Name = "Dominio"
        '
        'FechaPago
        '
        Me.FechaPago.DataPropertyName = "FechaPago"
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.Name = "FechaPago"
        '
        'ImportePago
        '
        Me.ImportePago.DataPropertyName = "ImportePago"
        Me.ImportePago.HeaderText = "Importe"
        Me.ImportePago.Name = "ImportePago"
        '
        'FormaPago
        '
        Me.FormaPago.DataPropertyName = "FormaPago"
        Me.FormaPago.HeaderText = "Forma de Pago"
        Me.FormaPago.Name = "FormaPago"
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "NumeroTransaccion"
        Me.Numero.HeaderText = "N°"
        Me.Numero.Name = "Numero"
        '
        'Banco
        '
        Me.Banco.DataPropertyName = "NombreBanco"
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        '
        'FormPagoDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 432)
        Me.Controls.Add(Me.textid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPagoDocumentos"
        Me.Text = "Pago de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGdocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGdocumentos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGpagos As System.Windows.Forms.DataGridView
    Friend WithEvents textid As System.Windows.Forms.TextBox
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dominio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
