<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoCuotas
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
        Me.textidsucursal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textnombres = New System.Windows.Forms.TextBox()
        Me.textnombreb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textidcuota = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textnumero = New System.Windows.Forms.TextBox()
        Me.combotipopago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.textdetalle = New System.Windows.Forms.TextBox()
        Me.combocuenta = New System.Windows.Forms.ComboBox()
        Me.textimporte = New System.Windows.Forms.TextBox()
        Me.borrar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.borrar)
        Me.GroupBox1.Controls.Add(Me.textidsucursal)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.textnombres)
        Me.GroupBox1.Controls.Add(Me.textnombreb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.textidcuota)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.textnumero)
        Me.GroupBox1.Controls.Add(Me.combotipopago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.textdetalle)
        Me.GroupBox1.Controls.Add(Me.combocuenta)
        Me.GroupBox1.Controls.Add(Me.textimporte)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'textidsucursal
        '
        Me.textidsucursal.Location = New System.Drawing.Point(339, 100)
        Me.textidsucursal.Name = "textidsucursal"
        Me.textidsucursal.Size = New System.Drawing.Size(34, 20)
        Me.textidsucursal.TabIndex = 81
        Me.textidsucursal.Text = "0"
        Me.textidsucursal.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(414, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 19)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Sucursal"
        '
        'textnombres
        '
        Me.textnombres.Location = New System.Drawing.Point(275, 74)
        Me.textnombres.Name = "textnombres"
        Me.textnombres.ReadOnly = True
        Me.textnombres.Size = New System.Drawing.Size(133, 20)
        Me.textnombres.TabIndex = 76
        '
        'textnombreb
        '
        Me.textnombreb.Location = New System.Drawing.Point(130, 74)
        Me.textnombreb.Name = "textnombreb"
        Me.textnombreb.ReadOnly = True
        Me.textnombreb.Size = New System.Drawing.Size(133, 20)
        Me.textnombreb.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Banco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "N° Transferencia / N° Cheque / N° Depósito"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 21)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textidcuota
        '
        Me.textidcuota.Location = New System.Drawing.Point(389, 208)
        Me.textidcuota.Name = "textidcuota"
        Me.textidcuota.Size = New System.Drawing.Size(55, 20)
        Me.textidcuota.TabIndex = 44
        Me.textidcuota.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Tipo Pago"
        '
        'textnumero
        '
        Me.textnumero.Location = New System.Drawing.Point(7, 130)
        Me.textnumero.Name = "textnumero"
        Me.textnumero.Size = New System.Drawing.Size(218, 20)
        Me.textnumero.TabIndex = 34
        '
        'combotipopago
        '
        Me.combotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotipopago.FormattingEnabled = True
        Me.combotipopago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Transferencia", "Depósito"})
        Me.combotipopago.Location = New System.Drawing.Point(9, 73)
        Me.combotipopago.Name = "combotipopago"
        Me.combotipopago.Size = New System.Drawing.Size(106, 21)
        Me.combotipopago.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Importe "
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button2.Location = New System.Drawing.Point(227, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 39
        Me.Button2.UseVisualStyleBackColor = True
        '
        'textdetalle
        '
        Me.textdetalle.Location = New System.Drawing.Point(9, 169)
        Me.textdetalle.Multiline = True
        Me.textdetalle.Name = "textdetalle"
        Me.textdetalle.Size = New System.Drawing.Size(212, 48)
        Me.textdetalle.TabIndex = 37
        '
        'combocuenta
        '
        Me.combocuenta.DisplayMember = "idcuenta"
        Me.combocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocuenta.FormattingEnabled = True
        Me.combocuenta.Location = New System.Drawing.Point(86, 32)
        Me.combocuenta.Name = "combocuenta"
        Me.combocuenta.Size = New System.Drawing.Size(199, 21)
        Me.combocuenta.TabIndex = 32
        Me.combocuenta.ValueMember = "idcuenta"
        '
        'textimporte
        '
        Me.textimporte.Location = New System.Drawing.Point(6, 31)
        Me.textimporte.Name = "textimporte"
        Me.textimporte.Size = New System.Drawing.Size(70, 20)
        Me.textimporte.TabIndex = 31
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(331, 141)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(83, 20)
        Me.borrar.TabIndex = 82
        Me.borrar.Text = "borrar"
        '
        'FormPagoCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 248)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FormPagoCuotas"
        Me.Text = "Pago Cuota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textnumero As System.Windows.Forms.TextBox
    Friend WithEvents combotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textdetalle As System.Windows.Forms.TextBox
    Friend WithEvents combocuenta As System.Windows.Forms.ComboBox
    Friend WithEvents textimporte As System.Windows.Forms.TextBox
    Friend WithEvents textidcuota As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textidsucursal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textnombres As System.Windows.Forms.TextBox
    Friend WithEvents textnombreb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents borrar As System.Windows.Forms.TextBox
End Class
