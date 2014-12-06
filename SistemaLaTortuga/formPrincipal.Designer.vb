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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDeVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasVehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelosVehículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbBSD = New System.Windows.Forms.TextBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.tbEquipo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VehiculosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CajaToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, -1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 44)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ClientesToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.Cliente1
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(105, 36)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarVehiculosToolStripMenuItem, Me.StockDeVehiculosToolStripMenuItem})
        Me.VehiculosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.VehiculosToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.cars
        Me.VehiculosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(116, 36)
        Me.VehiculosToolStripMenuItem.Text = "&Vehiculos"
        '
        'AdministrarVehiculosToolStripMenuItem
        '
        Me.AdministrarVehiculosToolStripMenuItem.Name = "AdministrarVehiculosToolStripMenuItem"
        Me.AdministrarVehiculosToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.AdministrarVehiculosToolStripMenuItem.Text = "Administrar Vehiculos"
        '
        'StockDeVehiculosToolStripMenuItem
        '
        Me.StockDeVehiculosToolStripMenuItem.Name = "StockDeVehiculosToolStripMenuItem"
        Me.StockDeVehiculosToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.StockDeVehiculosToolStripMenuItem.Text = "Stock de Vehiculos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.VentasToolStripMenuItem.Image = CType(resources.GetObject("VentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(95, 36)
        Me.VentasToolStripMenuItem.Text = "Ve&ntas"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CajaToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.Money_Calculator
        Me.CajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(82, 36)
        Me.CajaToolStripMenuItem.Text = "Ca&ja"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasToolStripMenuItem1, Me.RubrosCuentasToolStripMenuItem, Me.BancosToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.MarcasVehículosToolStripMenuItem, Me.ModelosVehículosToolStripMenuItem, Me.ProvinciasToolStripMenuItem, Me.LocalidadesToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.AdministraciónToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.Administrar_converted
        Me.AdministraciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(151, 36)
        Me.AdministraciónToolStripMenuItem.Text = "&Administración"
        '
        'CuentasToolStripMenuItem1
        '
        Me.CuentasToolStripMenuItem1.Name = "CuentasToolStripMenuItem1"
        Me.CuentasToolStripMenuItem1.Size = New System.Drawing.Size(219, 38)
        Me.CuentasToolStripMenuItem1.Text = "Cuentas"
        '
        'RubrosCuentasToolStripMenuItem
        '
        Me.RubrosCuentasToolStripMenuItem.Name = "RubrosCuentasToolStripMenuItem"
        Me.RubrosCuentasToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.RubrosCuentasToolStripMenuItem.Text = "Rubros Cuentas"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.bank_icon
        Me.BancosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.bank_icon
        Me.SucursalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales Bancos"
        '
        'MarcasVehículosToolStripMenuItem
        '
        Me.MarcasVehículosToolStripMenuItem.Name = "MarcasVehículosToolStripMenuItem"
        Me.MarcasVehículosToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.MarcasVehículosToolStripMenuItem.Text = "Marcas Vehículos"
        '
        'ModelosVehículosToolStripMenuItem
        '
        Me.ModelosVehículosToolStripMenuItem.Name = "ModelosVehículosToolStripMenuItem"
        Me.ModelosVehículosToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.ModelosVehículosToolStripMenuItem.Text = "Modelos Vehículos"
        '
        'ProvinciasToolStripMenuItem
        '
        Me.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem"
        Me.ProvinciasToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.ProvinciasToolStripMenuItem.Text = "Provincias"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(219, 38)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ReportesToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.Report
        Me.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(112, 36)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.SalirToolStripMenuItem.Image = Global.SistemaLaTortuga.My.Resources.Resources.Salir
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(82, 36)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'tbBSD
        '
        Me.tbBSD.Location = New System.Drawing.Point(800, 251)
        Me.tbBSD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBSD.Name = "tbBSD"
        Me.tbBSD.Size = New System.Drawing.Size(180, 29)
        Me.tbBSD.TabIndex = 1
        Me.tbBSD.Text = "latortuga"
        Me.tbBSD.Visible = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(800, 347)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(180, 29)
        Me.tbUsuario.TabIndex = 2
        Me.tbUsuario.Text = "sa"
        Me.tbUsuario.Visible = False
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(800, 442)
        Me.tbClave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(180, 29)
        Me.tbClave.TabIndex = 3
        Me.tbClave.Text = "06qiad"
        Me.tbClave.Visible = False
        '
        'tbEquipo
        '
        Me.tbEquipo.Location = New System.Drawing.Point(800, 518)
        Me.tbEquipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEquipo.Name = "tbEquipo"
        Me.tbEquipo.Size = New System.Drawing.Size(221, 29)
        Me.tbEquipo.TabIndex = 5
        Me.tbEquipo.Text = "MATI-D"
        Me.tbEquipo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(1892, 1148)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 138)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaLaTortuga.My.Resources.Resources.la_tortuga_colon
        Me.PictureBox2.Location = New System.Drawing.Point(1051, 618)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 76)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 58)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 715)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tbEquipo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbBSD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "formPrincipal"
        Me.Text = "Sistema de Gestion - Automotores La Tortuga"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbBSD As System.Windows.Forms.TextBox
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbClave As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbEquipo As System.Windows.Forms.TextBox
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
    Friend WithEvents RubrosCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdministrarVehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDeVehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
