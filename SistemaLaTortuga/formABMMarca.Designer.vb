<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMMarca
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
        Me.dgMarcas = New System.Windows.Forms.DataGridView()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.idMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbIdMarca = New System.Windows.Forms.TextBox()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgMarcas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 167)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marcas"
        '
        'dgMarcas
        '
        Me.dgMarcas.AllowUserToAddRows = False
        Me.dgMarcas.AllowUserToDeleteRows = False
        Me.dgMarcas.AllowUserToResizeRows = False
        Me.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMarca, Me.marca})
        Me.dgMarcas.Location = New System.Drawing.Point(6, 36)
        Me.dgMarcas.Name = "dgMarcas"
        Me.dgMarcas.ReadOnly = True
        Me.dgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMarcas.Size = New System.Drawing.Size(228, 111)
        Me.dgMarcas.TabIndex = 4
        Me.dgMarcas.TabStop = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(271, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(120, 262)
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
        Me.bSalir.TabIndex = 5
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
        Me.bEliminar.TabIndex = 4
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
        Me.bModificar.TabIndex = 3
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
        Me.bNuevo.TabIndex = 2
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'idMarca
        '
        Me.idMarca.DataPropertyName = "IdMarca"
        Me.idMarca.HeaderText = "idMarca"
        Me.idMarca.Name = "idMarca"
        Me.idMarca.ReadOnly = True
        Me.idMarca.Visible = False
        '
        'marca
        '
        Me.marca.DataPropertyName = "NombreMarca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 180
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdMarca)
        Me.GroupBox2.Controls.Add(Me.tbMarca)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 87)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'tbIdMarca
        '
        Me.tbIdMarca.Location = New System.Drawing.Point(18, 61)
        Me.tbIdMarca.Name = "tbIdMarca"
        Me.tbIdMarca.Size = New System.Drawing.Size(43, 20)
        Me.tbIdMarca.TabIndex = 14
        Me.tbIdMarca.Visible = False
        '
        'tbMarca
        '
        Me.tbMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMarca.Location = New System.Drawing.Point(70, 36)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(134, 20)
        Me.tbMarca.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Marca"
        '
        'formABMMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 282)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formABMMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Marcas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgMarcas As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents idMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
