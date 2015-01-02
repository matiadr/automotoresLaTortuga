<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoAdministrador
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combobanco = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textnumero = New System.Windows.Forms.TextBox()
        Me.combotipopago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textdetalle = New System.Windows.Forms.TextBox()
        Me.combocuenta = New System.Windows.Forms.ComboBox()
        Me.textimporte = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.combobanco)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textnumero)
        Me.GroupBox1.Controls.Add(Me.combotipopago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.textdetalle)
        Me.GroupBox1.Controls.Add(Me.combocuenta)
        Me.GroupBox1.Controls.Add(Me.textimporte)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Banco"
        '
        'combobanco
        '
        Me.combobanco.DisplayMember = "idbanco"
        Me.combobanco.FormattingEnabled = True
        Me.combobanco.Location = New System.Drawing.Point(322, 72)
        Me.combobanco.Name = "combobanco"
        Me.combobanco.Size = New System.Drawing.Size(141, 21)
        Me.combobanco.TabIndex = 35
        Me.combobanco.ValueMember = "idbanco"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Tipo Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "N°"
        '
        'textnumero
        '
        Me.textnumero.Location = New System.Drawing.Point(152, 72)
        Me.textnumero.Name = "textnumero"
        Me.textnumero.Size = New System.Drawing.Size(164, 20)
        Me.textnumero.TabIndex = 34
        '
        'combotipopago
        '
        Me.combotipopago.FormattingEnabled = True
        Me.combotipopago.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.combotipopago.Location = New System.Drawing.Point(40, 74)
        Me.combotipopago.Name = "combotipopago"
        Me.combotipopago.Size = New System.Drawing.Size(106, 21)
        Me.combotipopago.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Importe "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textdetalle
        '
        Me.textdetalle.Location = New System.Drawing.Point(40, 142)
        Me.textdetalle.Multiline = True
        Me.textdetalle.Name = "textdetalle"
        Me.textdetalle.Size = New System.Drawing.Size(212, 48)
        Me.textdetalle.TabIndex = 37
        '
        'combocuenta
        '
        Me.combocuenta.DisplayMember = "idcuenta"
        Me.combocuenta.FormattingEnabled = True
        Me.combocuenta.Location = New System.Drawing.Point(117, 33)
        Me.combocuenta.Name = "combocuenta"
        Me.combocuenta.Size = New System.Drawing.Size(147, 21)
        Me.combocuenta.TabIndex = 32
        Me.combocuenta.ValueMember = "idcuenta"
        '
        'textimporte
        '
        Me.textimporte.Location = New System.Drawing.Point(37, 32)
        Me.textimporte.Name = "textimporte"
        Me.textimporte.Size = New System.Drawing.Size(70, 20)
        Me.textimporte.TabIndex = 31
        '
        'FormPagoAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 224)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPagoAdministrador"
        Me.Text = "Pago Administrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents combobanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textnumero As System.Windows.Forms.TextBox
    Friend WithEvents combotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textdetalle As System.Windows.Forms.TextBox
    Friend WithEvents combocuenta As System.Windows.Forms.ComboBox
    Friend WithEvents textimporte As System.Windows.Forms.TextBox
End Class
