<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMProvincia
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
        Me.dgProvincias = New System.Windows.Forms.DataGridView()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbIdProvincia = New System.Windows.Forms.TextBox()
        Me.tbProvincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgProvincias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgProvincias
        '
        Me.dgProvincias.AllowUserToAddRows = False
        Me.dgProvincias.AllowUserToDeleteRows = False
        Me.dgProvincias.AllowUserToResizeRows = False
        Me.dgProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProvincias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProvincia, Me.provincia})
        Me.dgProvincias.Location = New System.Drawing.Point(6, 36)
        Me.dgProvincias.Name = "dgProvincias"
        Me.dgProvincias.ReadOnly = True
        Me.dgProvincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProvincias.Size = New System.Drawing.Size(246, 111)
        Me.dgProvincias.TabIndex = 4
        Me.dgProvincias.TabStop = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(292, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(123, 244)
        Me.gbAcciones.TabIndex = 5
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(18, 191)
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
        Me.bEliminar.Location = New System.Drawing.Point(18, 135)
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
        Me.bModificar.Location = New System.Drawing.Point(18, 75)
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
        Me.bNuevo.Location = New System.Drawing.Point(18, 17)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 35)
        Me.bNuevo.TabIndex = 2
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgProvincias)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 167)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provincias"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdProvincia)
        Me.GroupBox2.Controls.Add(Me.tbProvincia)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 73)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'tbIdProvincia
        '
        Me.tbIdProvincia.Location = New System.Drawing.Point(82, 53)
        Me.tbIdProvincia.Name = "tbIdProvincia"
        Me.tbIdProvincia.Size = New System.Drawing.Size(100, 20)
        Me.tbIdProvincia.TabIndex = 10
        Me.tbIdProvincia.Visible = False
        '
        'tbProvincia
        '
        Me.tbProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbProvincia.Location = New System.Drawing.Point(82, 26)
        Me.tbProvincia.Name = "tbProvincia"
        Me.tbProvincia.Size = New System.Drawing.Size(134, 20)
        Me.tbProvincia.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Provincia"
        '
        'idProvincia
        '
        Me.idProvincia.DataPropertyName = "IdProvincia"
        Me.idProvincia.HeaderText = "idProvincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = True
        Me.idProvincia.Visible = False
        '
        'provincia
        '
        Me.provincia.DataPropertyName = "NombreProvincia"
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        Me.provincia.Width = 200
        '
        'formABMProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 264)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formABMProvincia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Provincias"
        CType(Me.dgProvincias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgProvincias As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdProvincia As System.Windows.Forms.TextBox
    Friend WithEvents tbProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
