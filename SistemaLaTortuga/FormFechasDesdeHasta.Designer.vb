<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFechasDesdeHasta
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
        Me.tbFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bGenerarReporte = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbFechaDesde)
        Me.GroupBox1.Controls.Add(Me.bSalir)
        Me.GroupBox1.Controls.Add(Me.bGenerarReporte)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tbFechaHasta
        '
        Me.tbFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaHasta.Location = New System.Drawing.Point(239, 20)
        Me.tbFechaHasta.Name = "tbFechaHasta"
        Me.tbFechaHasta.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaHasta.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Desde"
        '
        'tbFechaDesde
        '
        Me.tbFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaDesde.Location = New System.Drawing.Point(75, 20)
        Me.tbFechaDesde.Name = "tbFechaDesde"
        Me.tbFechaDesde.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaDesde.TabIndex = 17
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(215, 65)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(113, 36)
        Me.bSalir.TabIndex = 22
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bGenerarReporte
        '
        Me.bGenerarReporte.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bGenerarReporte.Location = New System.Drawing.Point(53, 65)
        Me.bGenerarReporte.Name = "bGenerarReporte"
        Me.bGenerarReporte.Size = New System.Drawing.Size(114, 36)
        Me.bGenerarReporte.TabIndex = 21
        Me.bGenerarReporte.Text = "Generar Reporte"
        Me.bGenerarReporte.UseVisualStyleBackColor = True
        '
        'FormFechasDesdeHasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 131)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormFechasDesdeHasta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Fechas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bGenerarReporte As System.Windows.Forms.Button
End Class
