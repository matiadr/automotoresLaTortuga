<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteAdministrador
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
        Me.viewerAdministrador = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteAdministrador1 = New SistemaLaTortuga.reporteAdministrador()
        Me.SuspendLayout()
        '
        'viewerAdministrador
        '
        Me.viewerAdministrador.ActiveViewIndex = 0
        Me.viewerAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerAdministrador.CachedPageNumberPerDoc = 10
        Me.viewerAdministrador.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerAdministrador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerAdministrador.Location = New System.Drawing.Point(0, 0)
        Me.viewerAdministrador.Name = "viewerAdministrador"
        Me.viewerAdministrador.ReportSource = Me.reporteAdministrador1
        Me.viewerAdministrador.Size = New System.Drawing.Size(692, 392)
        Me.viewerAdministrador.TabIndex = 0
        '
        'FormReporteAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 392)
        Me.Controls.Add(Me.viewerAdministrador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormReporteAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deuda Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerAdministrador As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteAdministrador1 As SistemaLaTortuga.reporteAdministrador
End Class
