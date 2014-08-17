<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbBSD = New System.Windows.Forms.TextBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VehiculosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.VehiculosToolStripMenuItem.Text = "&Vehiculos"
        '
        'tbBSD
        '
        Me.tbBSD.Location = New System.Drawing.Point(436, 136)
        Me.tbBSD.Name = "tbBSD"
        Me.tbBSD.Size = New System.Drawing.Size(100, 20)
        Me.tbBSD.TabIndex = 1
        Me.tbBSD.Text = "nombreBSD"
        Me.tbBSD.Visible = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(436, 188)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tbUsuario.TabIndex = 2
        Me.tbUsuario.Text = "usuario"
        Me.tbUsuario.Visible = False
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(436, 239)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(100, 20)
        Me.tbClave.TabIndex = 3
        Me.tbClave.Text = "clave"
        Me.tbClave.Visible = False
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 369)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbBSD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbBSD As System.Windows.Forms.TextBox
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbClave As System.Windows.Forms.TextBox

End Class
