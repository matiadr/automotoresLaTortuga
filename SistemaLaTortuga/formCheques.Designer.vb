<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCheques
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textids = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Combotipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.textcomentario = New System.Windows.Forms.TextBox()
        Me.textdepositadoen = New System.Windows.Forms.TextBox()
        Me.textengregadoa = New System.Windows.Forms.TextBox()
        Me.mecuit = New System.Windows.Forms.MaskedTextBox()
        Me.texttitular = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textnombres = New System.Windows.Forms.TextBox()
        Me.textidsucursal = New System.Windows.Forms.TextBox()
        Me.textnombreb = New System.Windows.Forms.TextBox()
        Me.textidbanco = New System.Windows.Forms.TextBox()
        Me.dtfecharecibido = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textnumeroch = New System.Windows.Forms.TextBox()
        Me.textimportech = New System.Windows.Forms.TextBox()
        Me.dtfechach = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textnombrec = New System.Windows.Forms.TextBox()
        Me.textcodigoc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cheques = New System.Windows.Forms.GroupBox()
        Me.dgcheques = New System.Windows.Forms.DataGridView()
        Me.NumeroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textidcheque = New System.Windows.Forms.TextBox()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.cheques.SuspendLayout()
        CType(Me.dgcheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textids)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Combotipo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboEstado)
        Me.GroupBox1.Controls.Add(Me.textcomentario)
        Me.GroupBox1.Controls.Add(Me.textdepositadoen)
        Me.GroupBox1.Controls.Add(Me.textengregadoa)
        Me.GroupBox1.Controls.Add(Me.mecuit)
        Me.GroupBox1.Controls.Add(Me.texttitular)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.textnombres)
        Me.GroupBox1.Controls.Add(Me.textidsucursal)
        Me.GroupBox1.Controls.Add(Me.textnombreb)
        Me.GroupBox1.Controls.Add(Me.textidbanco)
        Me.GroupBox1.Controls.Add(Me.dtfecharecibido)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.textnumeroch)
        Me.GroupBox1.Controls.Add(Me.textimportech)
        Me.GroupBox1.Controls.Add(Me.dtfechach)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.textnombrec)
        Me.GroupBox1.Controls.Add(Me.textcodigoc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cheque"
        '
        'textids
        '
        Me.textids.Location = New System.Drawing.Point(586, 106)
        Me.textids.Name = "textids"
        Me.textids.Size = New System.Drawing.Size(55, 20)
        Me.textids.TabIndex = 72
        Me.textids.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(383, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Tipo"
        '
        'Combotipo
        '
        Me.Combotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combotipo.FormattingEnabled = True
        Me.Combotipo.Items.AddRange(New Object() {"Al portador", "A la orden", "No a la orden"})
        Me.Combotipo.Location = New System.Drawing.Point(425, 213)
        Me.Combotipo.Name = "Combotipo"
        Me.Combotipo.Size = New System.Drawing.Size(113, 21)
        Me.Combotipo.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Estado"
        '
        'ComboEstado
        '
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"En cartera", "Depositado", "Entregado", "Rechazado"})
        Me.ComboEstado.Location = New System.Drawing.Point(78, 178)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(113, 21)
        Me.ComboEstado.TabIndex = 16
        '
        'textcomentario
        '
        Me.textcomentario.Location = New System.Drawing.Point(118, 252)
        Me.textcomentario.Multiline = True
        Me.textcomentario.Name = "textcomentario"
        Me.textcomentario.Size = New System.Drawing.Size(477, 58)
        Me.textcomentario.TabIndex = 20
        '
        'textdepositadoen
        '
        Me.textdepositadoen.Location = New System.Drawing.Point(118, 213)
        Me.textdepositadoen.Name = "textdepositadoen"
        Me.textdepositadoen.Size = New System.Drawing.Size(249, 20)
        Me.textdepositadoen.TabIndex = 18
        '
        'textengregadoa
        '
        Me.textengregadoa.Location = New System.Drawing.Point(284, 179)
        Me.textengregadoa.Name = "textengregadoa"
        Me.textengregadoa.Size = New System.Drawing.Size(249, 20)
        Me.textengregadoa.TabIndex = 17
        '
        'mecuit
        '
        Me.mecuit.Location = New System.Drawing.Point(404, 146)
        Me.mecuit.Mask = "99-99999999-9"
        Me.mecuit.Name = "mecuit"
        Me.mecuit.Size = New System.Drawing.Size(108, 20)
        Me.mecuit.TabIndex = 15
        Me.mecuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texttitular
        '
        Me.texttitular.Location = New System.Drawing.Point(77, 146)
        Me.texttitular.Name = "texttitular"
        Me.texttitular.Size = New System.Drawing.Size(249, 20)
        Me.texttitular.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(279, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 19)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Sucursal"
        '
        'textnombres
        '
        Me.textnombres.Location = New System.Drawing.Point(140, 109)
        Me.textnombres.Name = "textnombres"
        Me.textnombres.Size = New System.Drawing.Size(133, 20)
        Me.textnombres.TabIndex = 10
        '
        'textidsucursal
        '
        Me.textidsucursal.Location = New System.Drawing.Point(87, 109)
        Me.textidsucursal.Name = "textidsucursal"
        Me.textidsucursal.Size = New System.Drawing.Size(48, 20)
        Me.textidsucursal.TabIndex = 9
        '
        'textnombreb
        '
        Me.textnombreb.Location = New System.Drawing.Point(430, 106)
        Me.textnombreb.Name = "textnombreb"
        Me.textnombreb.Size = New System.Drawing.Size(133, 20)
        Me.textnombreb.TabIndex = 13
        '
        'textidbanco
        '
        Me.textidbanco.Location = New System.Drawing.Point(376, 106)
        Me.textidbanco.Name = "textidbanco"
        Me.textidbanco.Size = New System.Drawing.Size(48, 20)
        Me.textidbanco.TabIndex = 12
        '
        'dtfecharecibido
        '
        Me.dtfecharecibido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecharecibido.Location = New System.Drawing.Point(564, 71)
        Me.dtfecharecibido.Name = "dtfecharecibido"
        Me.dtfecharecibido.Size = New System.Drawing.Size(86, 20)
        Me.dtfecharecibido.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(518, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Recibido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(298, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "N°Cheque"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Importe"
        '
        'textnumeroch
        '
        Me.textnumeroch.Location = New System.Drawing.Point(355, 71)
        Me.textnumeroch.Name = "textnumeroch"
        Me.textnumeroch.Size = New System.Drawing.Size(157, 20)
        Me.textnumeroch.TabIndex = 7
        '
        'textimportech
        '
        Me.textimportech.Location = New System.Drawing.Point(215, 74)
        Me.textimportech.Name = "textimportech"
        Me.textimportech.Size = New System.Drawing.Size(60, 20)
        Me.textimportech.TabIndex = 6
        '
        'dtfechach
        '
        Me.dtfechach.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechach.Location = New System.Drawing.Point(77, 71)
        Me.dtfechach.Name = "dtfechach"
        Me.dtfechach.Size = New System.Drawing.Size(78, 20)
        Me.dtfechach.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 19)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textnombrec
        '
        Me.textnombrec.Location = New System.Drawing.Point(130, 37)
        Me.textnombrec.Name = "textnombrec"
        Me.textnombrec.Size = New System.Drawing.Size(249, 20)
        Me.textnombrec.TabIndex = 3
        '
        'textcodigoc
        '
        Me.textcodigoc.Location = New System.Drawing.Point(76, 37)
        Me.textcodigoc.Name = "textcodigoc"
        Me.textcodigoc.Size = New System.Drawing.Size(48, 20)
        Me.textcodigoc.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Comentario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Entregado a"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Depositado en"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Cuit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Titular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Cliente"
        '
        'cheques
        '
        Me.cheques.Controls.Add(Me.dgcheques)
        Me.cheques.Location = New System.Drawing.Point(12, 61)
        Me.cheques.Name = "cheques"
        Me.cheques.Size = New System.Drawing.Size(675, 218)
        Me.cheques.TabIndex = 1
        Me.cheques.TabStop = False
        Me.cheques.Text = "Cheques"
        '
        'dgcheques
        '
        Me.dgcheques.AllowUserToAddRows = False
        Me.dgcheques.AllowUserToDeleteRows = False
        Me.dgcheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCheque, Me.ImporteCheque, Me.FechaCheque, Me.NombreC, Me.NombreBanco, Me.idcheque})
        Me.dgcheques.Location = New System.Drawing.Point(6, 19)
        Me.dgcheques.Name = "dgcheques"
        Me.dgcheques.ReadOnly = True
        Me.dgcheques.Size = New System.Drawing.Size(663, 189)
        Me.dgcheques.TabIndex = 0
        '
        'NumeroCheque
        '
        Me.NumeroCheque.DataPropertyName = "NumeroCheque"
        Me.NumeroCheque.HeaderText = "Numero"
        Me.NumeroCheque.Name = "NumeroCheque"
        Me.NumeroCheque.ReadOnly = True
        '
        'ImporteCheque
        '
        Me.ImporteCheque.DataPropertyName = "ImporteCheque"
        Me.ImporteCheque.HeaderText = "Importe"
        Me.ImporteCheque.Name = "ImporteCheque"
        Me.ImporteCheque.ReadOnly = True
        Me.ImporteCheque.Width = 80
        '
        'FechaCheque
        '
        Me.FechaCheque.DataPropertyName = "FechaCheque"
        Me.FechaCheque.HeaderText = "Fecha"
        Me.FechaCheque.Name = "FechaCheque"
        Me.FechaCheque.ReadOnly = True
        Me.FechaCheque.Width = 80
        '
        'NombreC
        '
        Me.NombreC.DataPropertyName = "NombreC"
        Me.NombreC.HeaderText = "Cliente"
        Me.NombreC.Name = "NombreC"
        Me.NombreC.ReadOnly = True
        Me.NombreC.Width = 200
        '
        'NombreBanco
        '
        Me.NombreBanco.DataPropertyName = "NombreBanco"
        Me.NombreBanco.HeaderText = "Banco"
        Me.NombreBanco.Name = "NombreBanco"
        Me.NombreBanco.ReadOnly = True
        Me.NombreBanco.Width = 150
        '
        'idcheque
        '
        Me.idcheque.DataPropertyName = "IdCheque"
        Me.idcheque.HeaderText = "idcheque"
        Me.idcheque.Name = "idcheque"
        Me.idcheque.ReadOnly = True
        Me.idcheque.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.textidcheque)
        Me.GroupBox3.Controls.Add(Me.textbuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(675, 57)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(233, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Buscar"
        '
        'textidcheque
        '
        Me.textidcheque.Location = New System.Drawing.Point(621, 30)
        Me.textidcheque.Name = "textidcheque"
        Me.textidcheque.Size = New System.Drawing.Size(29, 20)
        Me.textidcheque.TabIndex = 4
        Me.textidcheque.Visible = False
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(284, 19)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(233, 20)
        Me.textbuscar.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bSalir)
        Me.GroupBox4.Controls.Add(Me.bEliminar)
        Me.GroupBox4.Controls.Add(Me.bModificar)
        Me.GroupBox4.Controls.Add(Me.bNuevo)
        Me.GroupBox4.Location = New System.Drawing.Point(706, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(140, 602)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(15, 360)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(110, 50)
        Me.bSalir.TabIndex = 22
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(15, 266)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(110, 50)
        Me.bEliminar.TabIndex = 24
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(15, 171)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(110, 54)
        Me.bModificar.TabIndex = 23
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.bNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bNuevo.Cursor = System.Windows.Forms.Cursors.Cross
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(15, 79)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 54)
        Me.bNuevo.TabIndex = 21
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'formCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 615)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cheques)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cheques.ResumeLayout(False)
        CType(Me.dgcheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents textcomentario As System.Windows.Forms.TextBox
    Friend WithEvents textdepositadoen As System.Windows.Forms.TextBox
    Friend WithEvents mecuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents texttitular As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents textnombres As System.Windows.Forms.TextBox
    Friend WithEvents textidsucursal As System.Windows.Forms.TextBox
    Friend WithEvents textnombreb As System.Windows.Forms.TextBox
    Friend WithEvents textidbanco As System.Windows.Forms.TextBox
    Friend WithEvents dtfecharecibido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents textnumeroch As System.Windows.Forms.TextBox
    Friend WithEvents textimportech As System.Windows.Forms.TextBox
    Friend WithEvents dtfechach As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textnombrec As System.Windows.Forms.TextBox
    Friend WithEvents textcodigoc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cheques As System.Windows.Forms.GroupBox
    Friend WithEvents dgcheques As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents textengregadoa As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents textids As System.Windows.Forms.TextBox
    Friend WithEvents textidcheque As System.Windows.Forms.TextBox
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents NumeroCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
