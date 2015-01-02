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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.tbFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bGenerarReporte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasta"
        '
        'tbFechaDesde
        '
        Me.tbFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaDesde.Location = New System.Drawing.Point(75, 26)
        Me.tbFechaDesde.Name = "tbFechaDesde"
        Me.tbFechaDesde.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaDesde.TabIndex = 9
        '
        'tbFechaHasta
        '
        Me.tbFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaHasta.Location = New System.Drawing.Point(239, 26)
        Me.tbFechaHasta.Name = "tbFechaHasta"
        Me.tbFechaHasta.Size = New System.Drawing.Size(102, 20)
        Me.tbFechaHasta.TabIndex = 10
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(215, 71)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(99, 36)
        Me.bSalir.TabIndex = 16
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bGenerarReporte
        '
        Me.bGenerarReporte.Location = New System.Drawing.Point(75, 71)
        Me.bGenerarReporte.Name = "bGenerarReporte"
        Me.bGenerarReporte.Size = New System.Drawing.Size(99, 36)
        Me.bGenerarReporte.TabIndex = 15
        Me.bGenerarReporte.Text = "Generar Reporte"
        Me.bGenerarReporte.UseVisualStyleBackColor = True
        '
        'FormFechasDesdeHasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 131)
        Me.Controls.Add(Me.tbFechaHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbFechaDesde)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGenerarReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormFechasDesdeHasta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Fechas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bGenerarReporte As System.Windows.Forms.Button
End Class
