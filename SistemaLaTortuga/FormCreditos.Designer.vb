<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcreditos
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboCuentas = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textidcredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combobanco = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textsolicitado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTfechacredito = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textnumerocredito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textotorgado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTfechaotorgado = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboCuentas)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 183)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 52)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 20)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cuenta"
        '
        'ComboCuentas
        '
        Me.ComboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCuentas.FormattingEnabled = True
        Me.ComboCuentas.Location = New System.Drawing.Point(64, 16)
        Me.ComboCuentas.Name = "ComboCuentas"
        Me.ComboCuentas.Size = New System.Drawing.Size(164, 21)
        Me.ComboCuentas.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bguardar)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(510, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 223)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Bguardar
        '
        Me.Bguardar.Location = New System.Drawing.Point(20, 24)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(73, 57)
        Me.Bguardar.TabIndex = 12
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 57)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textidcredito)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.combobanco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textsolicitado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTfechacredito)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'textidcredito
        '
        Me.textidcredito.Location = New System.Drawing.Point(440, 19)
        Me.textidcredito.Name = "textidcredito"
        Me.textidcredito.Size = New System.Drawing.Size(44, 20)
        Me.textidcredito.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Banco"
        '
        'combobanco
        '
        Me.combobanco.DisplayMember = "idbanco"
        Me.combobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobanco.FormattingEnabled = True
        Me.combobanco.Location = New System.Drawing.Point(131, 24)
        Me.combobanco.Name = "combobanco"
        Me.combobanco.Size = New System.Drawing.Size(146, 21)
        Me.combobanco.TabIndex = 6
        Me.combobanco.ValueMember = "idbanco"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe Solicitado"
        '
        'textsolicitado
        '
        Me.textsolicitado.Location = New System.Drawing.Point(307, 26)
        Me.textsolicitado.Name = "textsolicitado"
        Me.textsolicitado.Size = New System.Drawing.Size(88, 20)
        Me.textsolicitado.TabIndex = 4
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
        'DTfechacredito
        '
        Me.DTfechacredito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfechacredito.Location = New System.Drawing.Point(6, 25)
        Me.DTfechacredito.Name = "DTfechacredito"
        Me.DTfechacredito.Size = New System.Drawing.Size(104, 20)
        Me.DTfechacredito.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.textnumerocredito)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.textotorgado)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DTfechaotorgado)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 67)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "N° Crédito"
        '
        'textnumerocredito
        '
        Me.textnumerocredito.Location = New System.Drawing.Point(243, 25)
        Me.textnumerocredito.Name = "textnumerocredito"
        Me.textnumerocredito.Size = New System.Drawing.Size(216, 20)
        Me.textnumerocredito.TabIndex = 12
        Me.textnumerocredito.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Importe Otorgado"
        '
        'textotorgado
        '
        Me.textotorgado.Location = New System.Drawing.Point(132, 25)
        Me.textotorgado.Name = "textotorgado"
        Me.textotorgado.Size = New System.Drawing.Size(88, 20)
        Me.textotorgado.TabIndex = 4
        Me.textotorgado.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha Otorgado"
        '
        'DTfechaotorgado
        '
        Me.DTfechaotorgado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfechaotorgado.Location = New System.Drawing.Point(6, 25)
        Me.DTfechaotorgado.Name = "DTfechaotorgado"
        Me.DTfechaotorgado.Size = New System.Drawing.Size(104, 20)
        Me.DTfechaotorgado.TabIndex = 0
        '
        'formcreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 247)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formcreditos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Créditos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textidcredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents combobanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textsolicitado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTfechacredito As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textnumerocredito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textotorgado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DTfechaotorgado As System.Windows.Forms.DateTimePicker
End Class
