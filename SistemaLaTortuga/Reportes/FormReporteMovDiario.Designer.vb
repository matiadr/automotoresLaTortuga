<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteMovDiario
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
        Me.viewerReporteMovDiario = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteMovDiario1 = New SistemaLaTortuga.reporteMovDiario()
        Me.SuspendLayout()
        '
        'viewerReporteMovDiario
        '
        Me.viewerReporteMovDiario.ActiveViewIndex = 0
        Me.viewerReporteMovDiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerReporteMovDiario.CachedPageNumberPerDoc = 10
        Me.viewerReporteMovDiario.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerReporteMovDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerReporteMovDiario.Location = New System.Drawing.Point(0, 0)
        Me.viewerReporteMovDiario.Name = "viewerReporteMovDiario"
        Me.viewerReporteMovDiario.ReportSource = Me.reporteMovDiario1
        Me.viewerReporteMovDiario.Size = New System.Drawing.Size(520, 342)
        Me.viewerReporteMovDiario.TabIndex = 0
        '
        'FormReporteMovDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 342)
        Me.Controls.Add(Me.viewerReporteMovDiario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormReporteMovDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja Diaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerReporteMovDiario As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteMovDiario1 As SistemaLaTortuga.reporteMovDiario
End Class
