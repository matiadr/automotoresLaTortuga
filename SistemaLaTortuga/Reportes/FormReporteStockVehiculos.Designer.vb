﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteStockVehiculos
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
        Me.viewerStockVehiculos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteStockVehiculos1 = New SistemaLaTortuga.reporteStockVehiculos()
        Me.SuspendLayout()
        '
        'viewerStockVehiculos
        '
        Me.viewerStockVehiculos.ActiveViewIndex = 0
        Me.viewerStockVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewerStockVehiculos.CachedPageNumberPerDoc = 10
        Me.viewerStockVehiculos.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewerStockVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewerStockVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.viewerStockVehiculos.Name = "viewerStockVehiculos"
        Me.viewerStockVehiculos.ReportSource = Me.reporteStockVehiculos1
        Me.viewerStockVehiculos.Size = New System.Drawing.Size(646, 444)
        Me.viewerStockVehiculos.TabIndex = 0
        '
        'FormReporteStockVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 444)
        Me.Controls.Add(Me.viewerStockVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteStockVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Vehiculos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewerStockVehiculos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteStockVehiculos1 As SistemaLaTortuga.reporteStockVehiculos
End Class
