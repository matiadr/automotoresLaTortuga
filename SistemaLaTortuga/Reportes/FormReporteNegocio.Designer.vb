<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteNegocio
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
        Me.ViewerNegocio = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReporteNegocio1 = New SistemaLaTortuga.ReporteNegocio()
        Me.SuspendLayout()
        '
        'ViewerNegocio
        '
        Me.ViewerNegocio.ActiveViewIndex = 0
        Me.ViewerNegocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewerNegocio.CachedPageNumberPerDoc = 10
        Me.ViewerNegocio.Cursor = System.Windows.Forms.Cursors.Default
        Me.ViewerNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewerNegocio.Location = New System.Drawing.Point(0, 0)
        Me.ViewerNegocio.Name = "ViewerNegocio"
        Me.ViewerNegocio.ReportSource = Me.ReporteNegocio1
        Me.ViewerNegocio.Size = New System.Drawing.Size(735, 425)
        Me.ViewerNegocio.TabIndex = 0
        '
        'FormReporteNegocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 425)
        Me.Controls.Add(Me.ViewerNegocio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteNegocio"
        Me.Text = "Reporte Negocio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewerNegocio As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReporteNegocio1 As SistemaLaTortuga.ReporteNegocio
End Class
