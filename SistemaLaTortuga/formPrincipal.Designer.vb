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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbBSD = New System.Windows.Forms.TextBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasVehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelosVehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VehiculosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CajaToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
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
        Me.tbBSD.Text = "latortuga"
        Me.tbBSD.Visible = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(436, 188)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tbUsuario.TabIndex = 2
        Me.tbUsuario.Text = "sa"
        Me.tbUsuario.Visible = False
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(436, 239)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(100, 20)
        Me.tbClave.TabIndex = 3
        Me.tbClave.Text = "Ccp846"
        Me.tbClave.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "la-tortuga-colon.jpg")
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.SistemaLaTortuga.My.Resources.Resources.la_tortuga_colon
        Me.PictureBox1.Location = New System.Drawing.Point(1032, 622)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 77)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(428, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "SRVPROD"
        Me.TextBox1.Visible = False
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasToolStripMenuItem1, Me.BancosToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.MarcasVehículosToolStripMenuItem, Me.ModelosVehículosToolStripMenuItem, Me.ProvinciasToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'CuentasToolStripMenuItem1
        '
        Me.CuentasToolStripMenuItem1.Name = "CuentasToolStripMenuItem1"
        Me.CuentasToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.CuentasToolStripMenuItem1.Text = "Cuentas"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales Bancos"
        '
        'MarcasVehículosToolStripMenuItem
        '
        Me.MarcasVehículosToolStripMenuItem.Name = "MarcasVehículosToolStripMenuItem"
        Me.MarcasVehículosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MarcasVehículosToolStripMenuItem.Text = "Marcas Vehículos"
        '
        'ModelosVehículosToolStripMenuItem
        '
        Me.ModelosVehículosToolStripMenuItem.Name = "ModelosVehículosToolStripMenuItem"
        Me.ModelosVehículosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ModelosVehículosToolStripMenuItem.Text = "Modelos Vehículos"
        '
        'ProvinciasToolStripMenuItem
        '
        Me.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem"
        Me.ProvinciasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ProvinciasToolStripMenuItem.Text = "Provincias"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbBSD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formPrincipal"
        Me.Text = "Sistema de Gestion - Automotores La Tortuga"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbBSD As System.Windows.Forms.TextBox
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbClave As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasVehículosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelosVehículosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
