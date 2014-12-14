<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCuentas
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
        Me.viewerCuentas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteCuentas1 = New SistemaLaTortuga.reporteCuentas()
        Me.SuspendLayout()
        '
        'viewerCuentas
        '
        Me.viewerCuentas.ActiveViewIndex = 0
        Me.viewerCuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerCuentas.CachedPageNumberPerDoc = 10
        Me.viewerCuentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerCuentas.Location = New System.Drawing.Point(0, 0)
        Me.viewerCuentas.Name = "viewerCuentas"
        Me.viewerCuentas.ReportSource = Me.reporteCuentas1
        Me.viewerCuentas.Size = New System.Drawing.Size(650, 446)
        Me.viewerCuentas.TabIndex = 0
        '
        'FormReporteCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 446)
        Me.Controls.Add(Me.viewerCuentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Cuentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerCuentas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteCuentas1 As SistemaLaTortuga.reporteCuentas
End Class
