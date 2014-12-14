<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteGastosXVehiculo
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
        Me.viewerGastosXVehiculos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteGastosXVehiculo1 = New SistemaLaTortuga.reporteGastosXVehiculo()
        Me.SuspendLayout()
        '
        'viewerGastosXVehiculos
        '
        Me.viewerGastosXVehiculos.ActiveViewIndex = 0
        Me.viewerGastosXVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerGastosXVehiculos.CachedPageNumberPerDoc = 10
        Me.viewerGastosXVehiculos.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerGastosXVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerGastosXVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.viewerGastosXVehiculos.Name = "viewerGastosXVehiculos"
        Me.viewerGastosXVehiculos.ReportSource = Me.reporteGastosXVehiculo1
        Me.viewerGastosXVehiculos.Size = New System.Drawing.Size(694, 410)
        Me.viewerGastosXVehiculos.TabIndex = 0
        '
        'FormReporteGastosXVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 410)
        Me.Controls.Add(Me.viewerGastosXVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteGastosXVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos por Vehiculo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerGastosXVehiculos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteGastosXVehiculo1 As SistemaLaTortuga.reporteGastosXVehiculo
End Class
