﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntregasEfectivo
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textnumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combobanco = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textimporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combotipopago = New System.Windows.Forms.ComboBox()
        Me.DTfechaentrega = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dgentregas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboCuentas = New System.Windows.Forms.ComboBox()
        Me.textidbanco = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgentregas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textidbanco)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.textnumero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.combobanco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textimporte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Combotipopago)
        Me.GroupBox1.Controls.Add(Me.DTfechaentrega)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "N° Transferencia / N° Cheque / N° Depósito"
        '
        'textnumero
        '
        Me.textnumero.Location = New System.Drawing.Point(171, 75)
        Me.textnumero.Name = "textnumero"
        Me.textnumero.Size = New System.Drawing.Size(216, 20)
        Me.textnumero.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Banco"
        '
        'combobanco
        '
        Me.combobanco.DisplayMember = "idbanco"
        Me.combobanco.FormattingEnabled = True
        Me.combobanco.Location = New System.Drawing.Point(6, 75)
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
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe"
        '
        'textimporte
        '
        Me.textimporte.Location = New System.Drawing.Point(307, 26)
        Me.textimporte.Name = "textimporte"
        Me.textimporte.Size = New System.Drawing.Size(81, 20)
        Me.textimporte.TabIndex = 4
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
        'Combotipopago
        '
        Me.Combotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combotipopago.FormattingEnabled = True
        Me.Combotipopago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Transferencia", "Depósito"})
        Me.Combotipopago.Location = New System.Drawing.Point(149, 25)
        Me.Combotipopago.Name = "Combotipopago"
        Me.Combotipopago.Size = New System.Drawing.Size(135, 21)
        Me.Combotipopago.TabIndex = 1
        '
        'DTfechaentrega
        '
        Me.DTfechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfechaentrega.Location = New System.Drawing.Point(6, 25)
        Me.DTfechaentrega.Name = "DTfechaentrega"
        Me.DTfechaentrega.Size = New System.Drawing.Size(104, 20)
        Me.DTfechaentrega.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgentregas)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 140)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dgentregas
        '
        Me.Dgentregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgentregas.Location = New System.Drawing.Point(7, 16)
        Me.Dgentregas.Name = "Dgentregas"
        Me.Dgentregas.Size = New System.Drawing.Size(469, 116)
        Me.Dgentregas.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bguardar)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(516, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 306)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Bguardar
        '
        Me.Bguardar.Location = New System.Drawing.Point(20, 55)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(73, 57)
        Me.Bguardar.TabIndex = 12
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 57)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboCuentas)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 126)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 52)
        Me.GroupBox4.TabIndex = 3
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
        Me.ComboCuentas.FormattingEnabled = True
        Me.ComboCuentas.Location = New System.Drawing.Point(64, 16)
        Me.ComboCuentas.Name = "ComboCuentas"
        Me.ComboCuentas.Size = New System.Drawing.Size(164, 21)
        Me.ComboCuentas.TabIndex = 0
        '
        'textidbanco
        '
        Me.textidbanco.Location = New System.Drawing.Point(418, 43)
        Me.textidbanco.Name = "textidbanco"
        Me.textidbanco.Size = New System.Drawing.Size(29, 20)
        Me.textidbanco.TabIndex = 10
        '
        'FormEntregasEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 317)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEntregasEfectivo"
        Me.Text = "Entregas de Efectivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgentregas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents DTfechaentrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents combobanco As System.Windows.Forms.ComboBox
    Friend WithEvents Dgentregas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents textidbanco As System.Windows.Forms.TextBox
End Class