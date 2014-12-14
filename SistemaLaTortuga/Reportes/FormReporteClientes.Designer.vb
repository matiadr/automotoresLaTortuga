<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteClientes
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
        Me.viewerClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteClientes1 = New SistemaLaTortuga.reporteClientes()
        Me.SuspendLayout()
        '
        'viewerClientes
        '
        Me.viewerClientes.ActiveViewIndex = 0
        Me.viewerClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerClientes.CachedPageNumberPerDoc = 10
        Me.viewerClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerClientes.Location = New System.Drawing.Point(0, 0)
        Me.viewerClientes.Name = "viewerClientes"
        Me.viewerClientes.ReportSource = Me.reporteClientes1
        Me.viewerClientes.Size = New System.Drawing.Size(666, 452)
        Me.viewerClientes.TabIndex = 0
        '
        'FormReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 452)
        Me.Controls.Add(Me.viewerClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteClientes1 As SistemaLaTortuga.reporteClientes
End Class
