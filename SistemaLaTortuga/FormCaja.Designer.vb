<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaja
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
        Me.DGcaja = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteMovimientoingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteMovimientoegreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextEfectivo = New System.Windows.Forms.TextBox()
        Me.TextCheques = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textsaldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textanterior = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textegresos = New System.Windows.Forms.TextBox()
        Me.textingresos = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGcaja)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 398)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DGcaja
        '
        Me.DGcaja.AllowUserToAddRows = False
        Me.DGcaja.AllowUserToDeleteRows = False
        Me.DGcaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.DetalleMovimiento, Me.ImporteMovimientoingreso, Me.ImporteMovimientoegreso})
        Me.DGcaja.Location = New System.Drawing.Point(21, 21)
        Me.DGcaja.Name = "DGcaja"
        Me.DGcaja.ReadOnly = True
        Me.DGcaja.Size = New System.Drawing.Size(675, 361)
        Me.DGcaja.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'DetalleMovimiento
        '
        Me.DetalleMovimiento.DataPropertyName = "DetalleMovimiento"
        Me.DetalleMovimiento.HeaderText = "Detalle"
        Me.DetalleMovimiento.Name = "DetalleMovimiento"
        Me.DetalleMovimiento.ReadOnly = True
        Me.DetalleMovimiento.Width = 200
        '
        'ImporteMovimientoingreso
        '
        Me.ImporteMovimientoingreso.DataPropertyName = "ImporteMovimientoingreo"
        Me.ImporteMovimientoingreso.HeaderText = "Ingresos"
        Me.ImporteMovimientoingreso.Name = "ImporteMovimientoingreso"
        Me.ImporteMovimientoingreso.ReadOnly = True
        '
        'ImporteMovimientoegreso
        '
        Me.ImporteMovimientoegreso.DataPropertyName = "ImporteMovimientoegreso"
        Me.ImporteMovimientoegreso.HeaderText = "Egresos"
        Me.ImporteMovimientoegreso.Name = "ImporteMovimientoegreso"
        Me.ImporteMovimientoegreso.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(738, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 553)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextEfectivo)
        Me.GroupBox3.Controls.Add(Me.TextCheques)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.textsaldo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.textanterior)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.textegresos)
        Me.GroupBox3.Controls.Add(Me.textingresos)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 469)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 92)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Efectivo"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cheques"
        Me.Label7.Visible = False
        '
        'TextEfectivo
        '
        Me.TextEfectivo.Location = New System.Drawing.Point(386, 49)
        Me.TextEfectivo.Name = "TextEfectivo"
        Me.TextEfectivo.Size = New System.Drawing.Size(81, 20)
        Me.TextEfectivo.TabIndex = 11
        Me.TextEfectivo.Visible = False
        '
        'TextCheques
        '
        Me.TextCheques.Location = New System.Drawing.Point(248, 49)
        Me.TextCheques.Name = "TextCheques"
        Me.TextCheques.Size = New System.Drawing.Size(81, 20)
        Me.TextCheques.TabIndex = 10
        Me.TextCheques.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Saldo Total"
        Me.Label6.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(550, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(479, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Saldo Diario"
        '
        'textsaldo
        '
        Me.textsaldo.Enabled = False
        Me.textsaldo.Location = New System.Drawing.Point(550, 16)
        Me.textsaldo.Name = "textsaldo"
        Me.textsaldo.Size = New System.Drawing.Size(81, 20)
        Me.textsaldo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Saldo Anterior"
        '
        'textanterior
        '
        Me.textanterior.Enabled = False
        Me.textanterior.Location = New System.Drawing.Point(99, 16)
        Me.textanterior.Name = "textanterior"
        Me.textanterior.Size = New System.Drawing.Size(81, 20)
        Me.textanterior.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Egresos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingresos"
        '
        'textegresos
        '
        Me.textegresos.Enabled = False
        Me.textegresos.Location = New System.Drawing.Point(386, 16)
        Me.textegresos.Name = "textegresos"
        Me.textegresos.Size = New System.Drawing.Size(81, 20)
        Me.textegresos.TabIndex = 1
        '
        'textingresos
        '
        Me.textingresos.Enabled = False
        Me.textingresos.Location = New System.Drawing.Point(248, 16)
        Me.textingresos.Name = "textingresos"
        Me.textingresos.Size = New System.Drawing.Size(81, 20)
        Me.textingresos.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTfecha)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 62)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'DTfecha
        '
        Me.DTfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfecha.Location = New System.Drawing.Point(291, 22)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.Size = New System.Drawing.Size(108, 20)
        Me.DTfecha.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha"
        '
        'Button8
        '
        Me.Button8.Image = Global.SistemaLaTortuga.My.Resources.Resources.fileprint
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(28, 421)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(140, 39)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Imprimir"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(28, 488)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 39)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(28, 354)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(140, 39)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Pago Administrador"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.SistemaLaTortuga.My.Resources.Resources.Report
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(28, 287)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 39)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Otros Egresos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.SistemaLaTortuga.My.Resources.Resources.Ventas
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(28, 220)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 39)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Otros Ingresos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SistemaLaTortuga.My.Resources.Resources.Money_Calculator
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(28, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Doc. Esp."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaLaTortuga.My.Resources.Resources.filenew
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(28, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cuotas Plan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.cars
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(28, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Gastos Vehículos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 573)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormCaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGcaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGcaja As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textsaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textanterior As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textegresos As System.Windows.Forms.TextBox
    Friend WithEvents textingresos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DTfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents TextCheques As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteMovimientoingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteMovimientoegreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
