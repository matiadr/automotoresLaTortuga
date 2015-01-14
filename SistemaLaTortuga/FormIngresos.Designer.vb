<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresos
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combocuenta = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDetalle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combocuenta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboCliente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextDetalle)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextImporte)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dtfecha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 210)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(192, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 19)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Cuenta"
        '
        'combocuenta
        '
        Me.combocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocuenta.FormattingEnabled = True
        Me.combocuenta.Location = New System.Drawing.Point(6, 88)
        Me.combocuenta.Name = "combocuenta"
        Me.combocuenta.Size = New System.Drawing.Size(180, 21)
        Me.combocuenta.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Cliente"
        '
        'ComboCliente
        '
        Me.ComboCliente.DisplayMember = "NombreC"
        Me.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(253, 88)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(220, 21)
        Me.ComboCliente.TabIndex = 43
        Me.ComboCliente.ValueMember = "idCliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Detalle"
        '
        'TextDetalle
        '
        Me.TextDetalle.Location = New System.Drawing.Point(6, 138)
        Me.TextDetalle.Multiline = True
        Me.TextDetalle.Name = "TextDetalle"
        Me.TextDetalle.Size = New System.Drawing.Size(211, 57)
        Me.TextDetalle.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button1.Location = New System.Drawing.Point(223, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe"
        '
        'TextImporte
        '
        Me.TextImporte.Location = New System.Drawing.Point(136, 25)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(81, 20)
        Me.TextImporte.TabIndex = 4
        Me.TextImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha"
        '
        'Dtfecha
        '
        Me.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtfecha.Location = New System.Drawing.Point(6, 25)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(104, 20)
        Me.Dtfecha.TabIndex = 0
        '
        'FormIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 229)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormIngresos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos Varios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents combocuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
