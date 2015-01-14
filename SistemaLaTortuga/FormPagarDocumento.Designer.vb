<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagarDocumento
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combocuenta = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textnumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textidsucursal)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.textnombres)
        Me.GroupBox1.Controls.Add(Me.textnombreb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combocuenta)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Textnumero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextImporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboTipo)
        Me.GroupBox1.Controls.Add(Me.Dtfecha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 220)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'textidsucursal
        '
        Me.textidsucursal.Location = New System.Drawing.Point(354, 75)
        Me.textidsucursal.Name = "textidsucursal"
        Me.textidsucursal.Size = New System.Drawing.Size(34, 20)
        Me.textidsucursal.TabIndex = 75
        Me.textidsucursal.Text = "0"
        Me.textidsucursal.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(290, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 19)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(148, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Sucursal"
        '
        'textnombres
        '
        Me.textnombres.Location = New System.Drawing.Point(151, 75)
        Me.textnombres.Name = "textnombres"
        Me.textnombres.ReadOnly = True
        Me.textnombres.Size = New System.Drawing.Size(133, 20)
        Me.textnombres.TabIndex = 70
        '
        'textnombreb
        '
        Me.textnombreb.Location = New System.Drawing.Point(6, 75)
        Me.textnombreb.Name = "textnombreb"
        Me.textnombreb.ReadOnly = True
        Me.textnombreb.Size = New System.Drawing.Size(133, 20)
        Me.textnombreb.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Banco"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 18)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(406, 197)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox1.TabIndex = 41
        Me.CheckBox1.Text = "Pago Total"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Cuenta"
        '
        'combocuenta
        '
        Me.combocuenta.DisplayMember = "idcuenta"
        Me.combocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocuenta.FormattingEnabled = True
        Me.combocuenta.Location = New System.Drawing.Point(6, 119)
        Me.combocuenta.Name = "combocuenta"
        Me.combocuenta.Size = New System.Drawing.Size(197, 21)
        Me.combocuenta.TabIndex = 39
        Me.combocuenta.ValueMember = "idcuenta"
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button1.Location = New System.Drawing.Point(240, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "N° Transferencia / N° Cheque / N° Depósito"
        '
        'Textnumero
        '
        Me.Textnumero.Location = New System.Drawing.Point(5, 177)
        Me.Textnumero.Name = "Textnumero"
        Me.Textnumero.Size = New System.Drawing.Size(216, 20)
        Me.Textnumero.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe"
        '
        'TextImporte
        '
        Me.TextImporte.Location = New System.Drawing.Point(307, 26)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(81, 20)
        Me.TextImporte.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Pago"
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
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Items.AddRange(New Object() {"Efectivo", "Cheque", "Transferencia", "Depósito"})
        Me.ComboTipo.Location = New System.Drawing.Point(149, 25)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(135, 21)
        Me.ComboTipo.TabIndex = 1
        '
        'Dtfecha
        '
        Me.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtfecha.Location = New System.Drawing.Point(6, 25)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(104, 20)
        Me.Dtfecha.TabIndex = 0
        '
        'FormPagarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormPagarDocumento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagar Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Textnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents combocuenta As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textidsucursal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textnombres As System.Windows.Forms.TextBox
    Friend WithEvents textnombreb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
