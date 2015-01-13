<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMLocalidad
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
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.dgLocalidades = New System.Windows.Forms.DataGridView()
        Me.idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbIdLocalidad = New System.Windows.Forms.TextBox()
        Me.tbIdProvincia = New System.Windows.Forms.TextBox()
        Me.tbCodPostal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLocalidad = New System.Windows.Forms.TextBox()
        Me.gbAcciones.SuspendLayout()
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(520, 21)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(121, 323)
        Me.gbAcciones.TabIndex = 6
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(17, 226)
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
        Me.bEliminar.Location = New System.Drawing.Point(17, 170)
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
        Me.bModificar.Location = New System.Drawing.Point(17, 110)
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
        Me.bNuevo.Location = New System.Drawing.Point(17, 52)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 35)
        Me.bNuevo.TabIndex = 3
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'dgLocalidades
        '
        Me.dgLocalidades.AllowUserToAddRows = False
        Me.dgLocalidades.AllowUserToDeleteRows = False
        Me.dgLocalidades.AllowUserToResizeRows = False
        Me.dgLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLocalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProvincia, Me.idLocalidad, Me.codPostal, Me.Localidad, Me.Provincia})
        Me.dgLocalidades.Location = New System.Drawing.Point(6, 27)
        Me.dgLocalidades.Name = "dgLocalidades"
        Me.dgLocalidades.ReadOnly = True
        Me.dgLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLocalidades.Size = New System.Drawing.Size(490, 159)
        Me.dgLocalidades.TabIndex = 7
        Me.dgLocalidades.TabStop = False
        '
        'idProvincia
        '
        Me.idProvincia.DataPropertyName = "IdProvincia"
        Me.idProvincia.HeaderText = "idProvincia"
        Me.idProvincia.Name = "idProvincia"
        Me.idProvincia.ReadOnly = True
        Me.idProvincia.Visible = False
        '
        'idLocalidad
        '
        Me.idLocalidad.DataPropertyName = "IdLocalidad"
        Me.idLocalidad.HeaderText = "idLocalidad"
        Me.idLocalidad.Name = "idLocalidad"
        Me.idLocalidad.ReadOnly = True
        Me.idLocalidad.Visible = False
        '
        'codPostal
        '
        Me.codPostal.DataPropertyName = "CodigoPostal"
        Me.codPostal.HeaderText = "Cod Postal"
        Me.codPostal.Name = "codPostal"
        Me.codPostal.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "NombreLocalidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        Me.Localidad.Width = 150
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "NombreProvincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        Me.Provincia.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgLocalidades)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 209)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localidades"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdLocalidad)
        Me.GroupBox2.Controls.Add(Me.tbIdProvincia)
        Me.GroupBox2.Controls.Add(Me.tbCodPostal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbLocalidad)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 113)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'tbIdLocalidad
        '
        Me.tbIdLocalidad.Location = New System.Drawing.Point(281, 32)
        Me.tbIdLocalidad.Name = "tbIdLocalidad"
        Me.tbIdLocalidad.Size = New System.Drawing.Size(34, 20)
        Me.tbIdLocalidad.TabIndex = 20
        Me.tbIdLocalidad.Visible = False
        '
        'tbIdProvincia
        '
        Me.tbIdProvincia.Location = New System.Drawing.Point(201, 32)
        Me.tbIdProvincia.Name = "tbIdProvincia"
        Me.tbIdProvincia.Size = New System.Drawing.Size(34, 20)
        Me.tbIdProvincia.TabIndex = 19
        Me.tbIdProvincia.Visible = False
        '
        'tbCodPostal
        '
        Me.tbCodPostal.Location = New System.Drawing.Point(242, 88)
        Me.tbCodPostal.Name = "tbCodPostal"
        Me.tbCodPostal.Size = New System.Drawing.Size(100, 20)
        Me.tbCodPostal.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "C.P."
        '
        'cbProvincia
        '
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(59, 32)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(121, 21)
        Me.cbProvincia.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Provincia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Localidad"
        '
        'tbLocalidad
        '
        Me.tbLocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbLocalidad.Location = New System.Drawing.Point(59, 88)
        Me.tbLocalidad.Name = "tbLocalidad"
        Me.tbLocalidad.Size = New System.Drawing.Size(147, 20)
        Me.tbLocalidad.TabIndex = 15
        '
        'formABMLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 354)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formABMLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Localidades"
        Me.gbAcciones.ResumeLayout(False)
        CType(Me.dgLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents dgLocalidades As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codPostal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents tbIdProvincia As System.Windows.Forms.TextBox
    Friend WithEvents tbCodPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbLocalidad As System.Windows.Forms.TextBox
End Class
