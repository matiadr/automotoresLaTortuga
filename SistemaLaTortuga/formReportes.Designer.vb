<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formReportes))
        Me.bGenerarReporte = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.tbFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.tbFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbEntreFechas = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbReportes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbVehiculo = New System.Windows.Forms.TextBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.tbIdVehiculo = New System.Windows.Forms.TextBox()
        Me.bBuscarVehiculo = New System.Windows.Forms.Button()
        Me.gbVehiculos = New System.Windows.Forms.GroupBox()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.bBuscarCliente = New System.Windows.Forms.Button()
        Me.cbRubros = New System.Windows.Forms.ComboBox()
        Me.gbRubros = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.gbCuentas = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.gbEntreFechas.SuspendLayout()
        Me.gbClientes.SuspendLayout()
        Me.gbVehiculos.SuspendLayout()
        Me.gbRubros.SuspendLayout()
        Me.gbCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'bGenerarReporte
        '
        Me.bGenerarReporte.Location = New System.Drawing.Point(98, 380)
        Me.bGenerarReporte.Name = "bGenerarReporte"
        Me.bGenerarReporte.Size = New System.Drawing.Size(99, 36)
        Me.bGenerarReporte.TabIndex = 0
        Me.bGenerarReporte.Text = "Generar Reporte"
        Me.bGenerarReporte.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(241, 380)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(99, 36)
        Me.bSalir.TabIndex = 8
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'tbFechaDesde
        '
        Me.tbFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaDesde.Location = New System.Drawing.Point(60, 13)
        Me.tbFechaDesde.Name = "tbFechaDesde"
        Me.tbFechaDesde.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaDesde.TabIndex = 9
        '
        'tbFechaHasta
        '
        Me.tbFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaHasta.Location = New System.Drawing.Point(241, 13)
        Me.tbFechaHasta.Name = "tbFechaHasta"
        Me.tbFechaHasta.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaHasta.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasta"
        '
        'gbEntreFechas
        '
        Me.gbEntreFechas.Controls.Add(Me.Label1)
        Me.gbEntreFechas.Controls.Add(Me.Label2)
        Me.gbEntreFechas.Controls.Add(Me.tbFechaDesde)
        Me.gbEntreFechas.Controls.Add(Me.tbFechaHasta)
        Me.gbEntreFechas.Enabled = False
        Me.gbEntreFechas.Location = New System.Drawing.Point(12, 100)
        Me.gbEntreFechas.Name = "gbEntreFechas"
        Me.gbEntreFechas.Size = New System.Drawing.Size(360, 39)
        Me.gbEntreFechas.TabIndex = 13
        Me.gbEntreFechas.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Listados"
        '
        'cbReportes
        '
        Me.cbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReportes.FormattingEnabled = True
        Me.cbReportes.Location = New System.Drawing.Point(70, 21)
        Me.cbReportes.Name = "cbReportes"
        Me.cbReportes.Size = New System.Drawing.Size(285, 21)
        Me.cbReportes.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Vehiculo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cliente"
        '
        'tbVehiculo
        '
        Me.tbVehiculo.Location = New System.Drawing.Point(60, 13)
        Me.tbVehiculo.Name = "tbVehiculo"
        Me.tbVehiculo.ReadOnly = True
        Me.tbVehiculo.Size = New System.Drawing.Size(225, 20)
        Me.tbVehiculo.TabIndex = 18
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(60, 15)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.ReadOnly = True
        Me.tbCliente.Size = New System.Drawing.Size(225, 20)
        Me.tbCliente.TabIndex = 19
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.tbIdVehiculo)
        Me.gbClientes.Controls.Add(Me.bBuscarVehiculo)
        Me.gbClientes.Controls.Add(Me.tbVehiculo)
        Me.gbClientes.Controls.Add(Me.Label4)
        Me.gbClientes.Location = New System.Drawing.Point(12, 154)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(360, 41)
        Me.gbClientes.TabIndex = 20
        Me.gbClientes.TabStop = False
        '
        'tbIdVehiculo
        '
        Me.tbIdVehiculo.Location = New System.Drawing.Point(335, 13)
        Me.tbIdVehiculo.Name = "tbIdVehiculo"
        Me.tbIdVehiculo.Size = New System.Drawing.Size(19, 20)
        Me.tbIdVehiculo.TabIndex = 20
        Me.tbIdVehiculo.Visible = False
        '
        'bBuscarVehiculo
        '
        Me.bBuscarVehiculo.Location = New System.Drawing.Point(292, 11)
        Me.bBuscarVehiculo.Name = "bBuscarVehiculo"
        Me.bBuscarVehiculo.Size = New System.Drawing.Size(36, 23)
        Me.bBuscarVehiculo.TabIndex = 19
        Me.bBuscarVehiculo.Text = "..."
        Me.bBuscarVehiculo.UseVisualStyleBackColor = True
        '
        'gbVehiculos
        '
        Me.gbVehiculos.Controls.Add(Me.tbIdCliente)
        Me.gbVehiculos.Controls.Add(Me.bBuscarCliente)
        Me.gbVehiculos.Controls.Add(Me.tbCliente)
        Me.gbVehiculos.Controls.Add(Me.Label5)
        Me.gbVehiculos.Location = New System.Drawing.Point(12, 201)
        Me.gbVehiculos.Name = "gbVehiculos"
        Me.gbVehiculos.Size = New System.Drawing.Size(360, 41)
        Me.gbVehiculos.TabIndex = 21
        Me.gbVehiculos.TabStop = False
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(335, 15)
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(19, 20)
        Me.tbIdCliente.TabIndex = 21
        Me.tbIdCliente.Visible = False
        '
        'bBuscarCliente
        '
        Me.bBuscarCliente.Location = New System.Drawing.Point(292, 13)
        Me.bBuscarCliente.Name = "bBuscarCliente"
        Me.bBuscarCliente.Size = New System.Drawing.Size(36, 23)
        Me.bBuscarCliente.TabIndex = 20
        Me.bBuscarCliente.Text = "..."
        Me.bBuscarCliente.UseVisualStyleBackColor = True
        '
        'cbRubros
        '
        Me.cbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubros.FormattingEnabled = True
        Me.cbRubros.Location = New System.Drawing.Point(55, 11)
        Me.cbRubros.Name = "cbRubros"
        Me.cbRubros.Size = New System.Drawing.Size(177, 21)
        Me.cbRubros.TabIndex = 22
        '
        'gbRubros
        '
        Me.gbRubros.Controls.Add(Me.label6)
        Me.gbRubros.Controls.Add(Me.cbRubros)
        Me.gbRubros.Location = New System.Drawing.Point(15, 285)
        Me.gbRubros.Name = "gbRubros"
        Me.gbRubros.Size = New System.Drawing.Size(253, 41)
        Me.gbRubros.TabIndex = 23
        Me.gbRubros.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 14)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(36, 13)
        Me.label6.TabIndex = 23
        Me.label6.Text = "Rubro"
        '
        'gbCuentas
        '
        Me.gbCuentas.Controls.Add(Me.Label7)
        Me.gbCuentas.Controls.Add(Me.cbCuentas)
        Me.gbCuentas.Location = New System.Drawing.Point(198, 332)
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.Size = New System.Drawing.Size(253, 41)
        Me.gbCuentas.TabIndex = 24
        Me.gbCuentas.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Cuenta"
        '
        'cbCuentas
        '
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(55, 11)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(177, 21)
        Me.cbCuentas.TabIndex = 22
        '
        'formReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 475)
        Me.Controls.Add(Me.gbCuentas)
        Me.Controls.Add(Me.gbRubros)
        Me.Controls.Add(Me.gbVehiculos)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.cbReportes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbEntreFechas)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGenerarReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.gbEntreFechas.ResumeLayout(False)
        Me.gbEntreFechas.PerformLayout()
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        Me.gbVehiculos.ResumeLayout(False)
        Me.gbVehiculos.PerformLayout()
        Me.gbRubros.ResumeLayout(False)
        Me.gbRubros.PerformLayout()
        Me.gbCuentas.ResumeLayout(False)
        Me.gbCuentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents tbFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbEntreFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbReportes As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents bBuscarVehiculo As System.Windows.Forms.Button
    Friend WithEvents gbVehiculos As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents bBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents cbRubros As System.Windows.Forms.ComboBox
    Friend WithEvents gbRubros As System.Windows.Forms.GroupBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
End Class
