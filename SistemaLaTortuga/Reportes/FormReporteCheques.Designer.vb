<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCheques
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
        Me.viewerCheques = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteCheques1 = New SistemaLaTortuga.reporteCheques()
        Me.SuspendLayout()
        '
        'viewerCheques
        '
        Me.viewerCheques.ActiveViewIndex = 0
        Me.viewerCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerCheques.CachedPageNumberPerDoc = 10
        Me.viewerCheques.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerCheques.Location = New System.Drawing.Point(0, 0)
        Me.viewerCheques.Name = "viewerCheques"
        Me.viewerCheques.ReportSource = Me.reporteCheques1
        Me.viewerCheques.Size = New System.Drawing.Size(667, 442)
        Me.viewerCheques.TabIndex = 0
        '
        'FormReporteCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 442)
        Me.Controls.Add(Me.viewerCheques)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Cheques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerCheques As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteCheques1 As SistemaLaTortuga.reporteCheques
End Class
