<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMModelos
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
        Me.dgModelos = New System.Windows.Forms.DataGridView()
        Me.idMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbIdModelo = New System.Windows.Forms.TextBox()
        Me.tbIdMarca = New System.Windows.Forms.TextBox()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgModelos)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 209)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelos"
        '
        'dgModelos
        '
        Me.dgModelos.AllowUserToAddRows = False
        Me.dgModelos.AllowUserToDeleteRows = False
        Me.dgModelos.AllowUserToResizeRows = False
        Me.dgModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMarca, Me.idModelo, Me.marca, Me.modelo})
        Me.dgModelos.Location = New System.Drawing.Point(6, 27)
        Me.dgModelos.Name = "dgModelos"
        Me.dgModelos.ReadOnly = True
        Me.dgModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgModelos.Size = New System.Drawing.Size(360, 176)
        Me.dgModelos.TabIndex = 7
        Me.dgModelos.TabStop = False
        '
        'idMarca
        '
        Me.idMarca.DataPropertyName = "IdMarca"
        Me.idMarca.HeaderText = "idMarca"
        Me.idMarca.Name = "idMarca"
        Me.idMarca.ReadOnly = True
        Me.idMarca.Visible = False
        '
        'idModelo
        '
        Me.idModelo.DataPropertyName = "IdModelo"
        Me.idModelo.HeaderText = "idModelo"
        Me.idModelo.Name = "idModelo"
        Me.idModelo.ReadOnly = True
        Me.idModelo.Visible = False
        '
        'marca
        '
        Me.marca.DataPropertyName = "NombreMarca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 150
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "NombreModelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 150
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(400, 14)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(117, 311)
        Me.gbAcciones.TabIndex = 9
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(17, 210)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(80, 34)
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = Global.SistemaLaTortuga.My.Resources.Resources.cancel
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEliminar.Location = New System.Drawing.Point(17, 154)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(80, 32)
        Me.bEliminar.TabIndex = 5
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Image = Global.SistemaLaTortuga.My.Resources.Resources.edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(17, 94)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(80, 36)
        Me.bModificar.TabIndex = 4
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.Image = Global.SistemaLaTortuga.My.Resources.Resources.apply
        Me.bNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bNuevo.Location = New System.Drawing.Point(17, 36)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 35)
        Me.bNuevo.TabIndex = 3
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdModelo)
        Me.GroupBox2.Controls.Add(Me.tbIdMarca)
        Me.GroupBox2.Controls.Add(Me.tbModelo)
        Me.GroupBox2.Controls.Add(Me.cbMarca)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 97)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'tbIdModelo
        '
        Me.tbIdModelo.Location = New System.Drawing.Point(229, 70)
        Me.tbIdModelo.Name = "tbIdModelo"
        Me.tbIdModelo.Size = New System.Drawing.Size(35, 20)
        Me.tbIdModelo.TabIndex = 18
        Me.tbIdModelo.Visible = False
        '
        'tbIdMarca
        '
        Me.tbIdMarca.Location = New System.Drawing.Point(229, 14)
        Me.tbIdMarca.Name = "tbIdMarca"
        Me.tbIdMarca.Size = New System.Drawing.Size(35, 20)
        Me.tbIdMarca.TabIndex = 17
        Me.tbIdMarca.Visible = False
        '
        'tbModelo
        '
        Me.tbModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbModelo.Location = New System.Drawing.Point(85, 70)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(121, 20)
        Me.tbModelo.TabIndex = 16
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(85, 19)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cbMarca.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Modelo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Marca"
        '
        'formABMModelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 332)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formABMModelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Modelos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgModelos As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents idMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idModelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbIdMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents cbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
