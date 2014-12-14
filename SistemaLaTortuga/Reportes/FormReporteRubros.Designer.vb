<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteRubros
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
        Me.viewerRubros = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteRubros1 = New SistemaLaTortuga.reporteRubros()
        Me.SuspendLayout()
        '
        'viewerRubros
        '
        Me.viewerRubros.ActiveViewIndex = 0
        Me.viewerRubros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerRubros.CachedPageNumberPerDoc = 10
        Me.viewerRubros.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerRubros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerRubros.Location = New System.Drawing.Point(0, 0)
        Me.viewerRubros.Name = "viewerRubros"
        Me.viewerRubros.ReportSource = Me.reporteRubros1
        Me.viewerRubros.Size = New System.Drawing.Size(581, 393)
        Me.viewerRubros.TabIndex = 0
        '
        'FormReporteRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 393)
        Me.Controls.Add(Me.viewerRubros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Rubros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerRubros As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteRubros1 As SistemaLaTortuga.reporteRubros
End Class
