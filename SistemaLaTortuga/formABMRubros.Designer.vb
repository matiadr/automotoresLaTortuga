<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMRubros
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
        Me.dgRubro = New System.Windows.Forms.DataGridView()
        Me.idRubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbIdRubro = New System.Windows.Forms.TextBox()
        Me.tbRubro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgRubro)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 186)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rubros"
        '
        'dgRubro
        '
        Me.dgRubro.AllowUserToAddRows = False
        Me.dgRubro.AllowUserToDeleteRows = False
        Me.dgRubro.AllowUserToResizeRows = False
        Me.dgRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRubro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRubro, Me.rubro})
        Me.dgRubro.Location = New System.Drawing.Point(6, 19)
        Me.dgRubro.Name = "dgRubro"
        Me.dgRubro.ReadOnly = True
        Me.dgRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRubro.Size = New System.Drawing.Size(257, 161)
        Me.dgRubro.TabIndex = 4
        Me.dgRubro.TabStop = False
        '
        'idRubro
        '
        Me.idRubro.DataPropertyName = "IdRubro"
        Me.idRubro.HeaderText = "idRubro"
        Me.idRubro.Name = "idRubro"
        Me.idRubro.ReadOnly = True
        Me.idRubro.Visible = False
        '
        'rubro
        '
        Me.rubro.DataPropertyName = "NombreRubro"
        Me.rubro.HeaderText = "Rubro"
        Me.rubro.Name = "rubro"
        Me.rubro.ReadOnly = True
        Me.rubro.Width = 150
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(287, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(117, 262)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdRubro)
        Me.GroupBox2.Controls.Add(Me.tbRubro)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 72)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'tbIdRubro
        '
        Me.tbIdRubro.Location = New System.Drawing.Point(65, 46)
        Me.tbIdRubro.Name = "tbIdRubro"
        Me.tbIdRubro.Size = New System.Drawing.Size(100, 20)
        Me.tbIdRubro.TabIndex = 14
        Me.tbIdRubro.Visible = False
        '
        'tbRubro
        '
        Me.tbRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbRubro.Location = New System.Drawing.Point(65, 19)
        Me.tbRubro.Name = "tbRubro"
        Me.tbRubro.Size = New System.Drawing.Size(134, 20)
        Me.tbRubro.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Rubro"
        '
        'formABMRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 278)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formABMRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Rubros"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgRubro As System.Windows.Forms.DataGridView
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents idRubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdRubro As System.Windows.Forms.TextBox
    Friend WithEvents tbRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
