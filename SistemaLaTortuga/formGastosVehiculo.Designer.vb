<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGastosVehiculo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Comboproveedor = New System.Windows.Forms.ComboBox()
        Me.textidvehiculo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combobanco = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textnumero = New System.Windows.Forms.TextBox()
        Me.combotipopago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.te = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textdetalle = New System.Windows.Forms.TextBox()
        Me.combocuenta = New System.Windows.Forms.ComboBox()
        Me.textimporte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.texttipov = New System.Windows.Forms.TextBox()
        Me.textpatente = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Comboproveedor)
        Me.GroupBox1.Controls.Add(Me.textidvehiculo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.combobanco)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textnumero)
        Me.GroupBox1.Controls.Add(Me.combotipopago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.te)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.textdetalle)
        Me.GroupBox1.Controls.Add(Me.combocuenta)
        Me.GroupBox1.Controls.Add(Me.textimporte)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.texttipov)
        Me.GroupBox1.Controls.Add(Me.textpatente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Proveedor"
        '
        'Comboproveedor
        '
        Me.Comboproveedor.DisplayMember = "idcuenta"
        Me.Comboproveedor.FormattingEnabled = True
        Me.Comboproveedor.Location = New System.Drawing.Point(239, 75)
        Me.Comboproveedor.Name = "Comboproveedor"
        Me.Comboproveedor.Size = New System.Drawing.Size(192, 21)
        Me.Comboproveedor.TabIndex = 19
        Me.Comboproveedor.ValueMember = "idproveedor"
        '
        'textidvehiculo
        '
        Me.textidvehiculo.Location = New System.Drawing.Point(376, 17)
        Me.textidvehiculo.Name = "textidvehiculo"
        Me.textidvehiculo.Size = New System.Drawing.Size(55, 20)
        Me.textidvehiculo.TabIndex = 18
        Me.textidvehiculo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Banco"
        '
        'combobanco
        '
        Me.combobanco.DisplayMember = "idbanco"
        Me.combobanco.FormattingEnabled = True
        Me.combobanco.Location = New System.Drawing.Point(291, 114)
        Me.combobanco.Name = "combobanco"
        Me.combobanco.Size = New System.Drawing.Size(141, 21)
        Me.combobanco.TabIndex = 16
        Me.combobanco.ValueMember = "idbanco"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tipo Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "N°"
        '
        'textnumero
        '
        Me.textnumero.Location = New System.Drawing.Point(121, 114)
        Me.textnumero.Name = "textnumero"
        Me.textnumero.Size = New System.Drawing.Size(164, 20)
        Me.textnumero.TabIndex = 13
        '
        'combotipopago
        '
        Me.combotipopago.FormattingEnabled = True
        Me.combotipopago.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.combotipopago.Location = New System.Drawing.Point(9, 116)
        Me.combotipopago.Name = "combotipopago"
        Me.combotipopago.Size = New System.Drawing.Size(106, 21)
        Me.combotipopago.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Importe "
        '
        'te
        '
        Me.te.AutoSize = True
        Me.te.Location = New System.Drawing.Point(83, 12)
        Me.te.Name = "te"
        Me.te.Size = New System.Drawing.Size(50, 13)
        Me.te.TabIndex = 8
        Me.te.Text = "Vehículo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Patente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textdetalle
        '
        Me.textdetalle.Location = New System.Drawing.Point(9, 184)
        Me.textdetalle.Multiline = True
        Me.textdetalle.Name = "textdetalle"
        Me.textdetalle.Size = New System.Drawing.Size(212, 48)
        Me.textdetalle.TabIndex = 5
        '
        'combocuenta
        '
        Me.combocuenta.DisplayMember = "idcuenta"
        Me.combocuenta.FormattingEnabled = True
        Me.combocuenta.Location = New System.Drawing.Point(86, 75)
        Me.combocuenta.Name = "combocuenta"
        Me.combocuenta.Size = New System.Drawing.Size(147, 21)
        Me.combocuenta.TabIndex = 4
        Me.combocuenta.ValueMember = "idcuenta"
        '
        'textimporte
        '
        Me.textimporte.Location = New System.Drawing.Point(6, 74)
        Me.textimporte.Name = "textimporte"
        Me.textimporte.Size = New System.Drawing.Size(70, 20)
        Me.textimporte.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'texttipov
        '
        Me.texttipov.Location = New System.Drawing.Point(82, 28)
        Me.texttipov.Name = "texttipov"
        Me.texttipov.Size = New System.Drawing.Size(216, 20)
        Me.texttipov.TabIndex = 1
        '
        'textpatente
        '
        Me.textpatente.Location = New System.Drawing.Point(6, 28)
        Me.textpatente.Name = "textpatente"
        Me.textpatente.Size = New System.Drawing.Size(70, 20)
        Me.textpatente.TabIndex = 0
        '
        'FormGastosVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormGastosVehiculo"
        Me.Text = "Gastos Por Vehículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents te As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textdetalle As System.Windows.Forms.TextBox
    Friend WithEvents combocuenta As System.Windows.Forms.ComboBox
    Friend WithEvents textimporte As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents texttipov As System.Windows.Forms.TextBox
    Friend WithEvents textpatente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textnumero As System.Windows.Forms.TextBox
    Friend WithEvents combotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents combobanco As System.Windows.Forms.ComboBox
    Friend WithEvents textidvehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Comboproveedor As System.Windows.Forms.ComboBox
End Class
