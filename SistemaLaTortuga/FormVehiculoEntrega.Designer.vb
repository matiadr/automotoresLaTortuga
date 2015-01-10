<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formvehiculoentrega
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbidmarca = New System.Windows.Forms.TextBox()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.texttipoventrega = New System.Windows.Forms.TextBox()
        Me.combomodelo = New System.Windows.Forms.ComboBox()
        Me.combomarca = New System.Windows.Forms.ComboBox()
        Me.textidvehiculo = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbPrecioCostoVehEntrega = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.textdetalle = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.textdeuda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbChasisVehEntrega = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbAñoVehEntrega = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbDominioVehEntrega = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbMotorVehEntrega = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbidmarca)
        Me.GroupBox3.Controls.Add(Me.combotipo)
        Me.GroupBox3.Controls.Add(Me.texttipoventrega)
        Me.GroupBox3.Controls.Add(Me.combomodelo)
        Me.GroupBox3.Controls.Add(Me.combomarca)
        Me.GroupBox3.Controls.Add(Me.textidvehiculo)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.tbPrecioCostoVehEntrega)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.textdetalle)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.textdeuda)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tbChasisVehEntrega)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tbAñoVehEntrega)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.tbDominioVehEntrega)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.tbMotorVehEntrega)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 174)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'tbidmarca
        '
        Me.tbidmarca.Location = New System.Drawing.Point(127, 18)
        Me.tbidmarca.Name = "tbidmarca"
        Me.tbidmarca.Size = New System.Drawing.Size(29, 20)
        Me.tbidmarca.TabIndex = 29
        Me.tbidmarca.Visible = False
        '
        'combotipo
        '
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"NAFTA ", "DIESEL", "GNC"})
        Me.combotipo.Location = New System.Drawing.Point(12, 106)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(91, 21)
        Me.combotipo.TabIndex = 28
        '
        'texttipoventrega
        '
        Me.texttipoventrega.Location = New System.Drawing.Point(156, 26)
        Me.texttipoventrega.Name = "texttipoventrega"
        Me.texttipoventrega.Size = New System.Drawing.Size(189, 20)
        Me.texttipoventrega.TabIndex = 27
        '
        'combomodelo
        '
        Me.combomodelo.FormattingEnabled = True
        Me.combomodelo.Items.AddRange(New Object() {"NAFTA ", "DIESEL", "GNC"})
        Me.combomodelo.Location = New System.Drawing.Point(8, 67)
        Me.combomodelo.Name = "combomodelo"
        Me.combomodelo.Size = New System.Drawing.Size(115, 21)
        Me.combomodelo.TabIndex = 26
        '
        'combomarca
        '
        Me.combomarca.FormattingEnabled = True
        Me.combomarca.Location = New System.Drawing.Point(8, 26)
        Me.combomarca.Name = "combomarca"
        Me.combomarca.Size = New System.Drawing.Size(116, 21)
        Me.combomarca.TabIndex = 25
        '
        'textidvehiculo
        '
        Me.textidvehiculo.Location = New System.Drawing.Point(470, 14)
        Me.textidvehiculo.Name = "textidvehiculo"
        Me.textidvehiculo.Size = New System.Drawing.Size(39, 20)
        Me.textidvehiculo.TabIndex = 24
        Me.textidvehiculo.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(354, 14)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Precio Entrega"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(153, 14)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 17
        Me.Label36.Text = "Tipo Vehiculo"
        '
        'tbPrecioCostoVehEntrega
        '
        Me.tbPrecioCostoVehEntrega.Location = New System.Drawing.Point(357, 27)
        Me.tbPrecioCostoVehEntrega.Name = "tbPrecioCostoVehEntrega"
        Me.tbPrecioCostoVehEntrega.Size = New System.Drawing.Size(94, 20)
        Me.tbPrecioCostoVehEntrega.TabIndex = 19
        Me.tbPrecioCostoVehEntrega.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(104, 129)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Detalle"
        '
        'textdetalle
        '
        Me.textdetalle.Location = New System.Drawing.Point(103, 142)
        Me.textdetalle.Name = "textdetalle"
        Me.textdetalle.Size = New System.Drawing.Size(393, 20)
        Me.textdetalle.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 127)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Deuda"
        '
        'textdeuda
        '
        Me.textdeuda.Location = New System.Drawing.Point(8, 142)
        Me.textdeuda.Name = "textdeuda"
        Me.textdeuda.Size = New System.Drawing.Size(80, 20)
        Me.textdeuda.TabIndex = 15
        Me.textdeuda.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(313, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Chasis"
        '
        'tbChasisVehEntrega
        '
        Me.tbChasisVehEntrega.Location = New System.Drawing.Point(313, 107)
        Me.tbChasisVehEntrega.Name = "tbChasisVehEntrega"
        Me.tbChasisVehEntrega.Size = New System.Drawing.Size(190, 20)
        Me.tbChasisVehEntrega.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(269, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Año"
        '
        'tbAñoVehEntrega
        '
        Me.tbAñoVehEntrega.Location = New System.Drawing.Point(269, 65)
        Me.tbAñoVehEntrega.Name = "tbAñoVehEntrega"
        Me.tbAñoVehEntrega.Size = New System.Drawing.Size(105, 20)
        Me.tbAñoVehEntrega.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(153, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Dominio"
        '
        'tbDominioVehEntrega
        '
        Me.tbDominioVehEntrega.Location = New System.Drawing.Point(156, 67)
        Me.tbDominioVehEntrega.Name = "tbDominioVehEntrega"
        Me.tbDominioVehEntrega.Size = New System.Drawing.Size(92, 20)
        Me.tbDominioVehEntrega.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(110, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Motor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Tipo"
        '
        'tbMotorVehEntrega
        '
        Me.tbMotorVehEntrega.Location = New System.Drawing.Point(109, 107)
        Me.tbMotorVehEntrega.Name = "tbMotorVehEntrega"
        Me.tbMotorVehEntrega.Size = New System.Drawing.Size(198, 20)
        Me.tbMotorVehEntrega.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Modelo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Marca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 173)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(22, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaLaTortuga.My.Resources.Resources.search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formvehiculoentrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 203)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.Name = "formvehiculoentrega"
        Me.Text = "Vehículo entrega"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tbPrecioCostoVehEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents textdetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents textdeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbChasisVehEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbAñoVehEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbDominioVehEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbMotorVehEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textidvehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents texttipoventrega As System.Windows.Forms.TextBox
    Friend WithEvents combomodelo As System.Windows.Forms.ComboBox
    Friend WithEvents combomarca As System.Windows.Forms.ComboBox
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents tbidmarca As System.Windows.Forms.TextBox
End Class
