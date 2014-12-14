<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVehiculosVendidos
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
        Me.viewerVehVendidos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteVehiculosVendidos1 = New SistemaLaTortuga.reporteVehiculosVendidos()
        Me.SuspendLayout()
        '
        'viewerVehVendidos
        '
        Me.viewerVehVendidos.ActiveViewIndex = 0
        Me.viewerVehVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerVehVendidos.CachedPageNumberPerDoc = 10
        Me.viewerVehVendidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerVehVendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerVehVendidos.Location = New System.Drawing.Point(0, 0)
        Me.viewerVehVendidos.Name = "viewerVehVendidos"
        Me.viewerVehVendidos.ReportSource = Me.reporteVehiculosVendidos1
        Me.viewerVehVendidos.Size = New System.Drawing.Size(586, 415)
        Me.viewerVehVendidos.TabIndex = 0
        '
        'FormReporteVehiculosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 415)
        Me.Controls.Add(Me.viewerVehVendidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteVehiculosVendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculos Vendidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerVehVendidos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteVehiculosVendidos1 As SistemaLaTortuga.reporteVehiculosVendidos
End Class
