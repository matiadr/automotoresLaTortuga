<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formABMBancos))
        Me.tbIdBanco = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgBancos = New System.Windows.Forms.DataGridView()
        Me.idBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.tbBanco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbIdBanco
        '
        Me.tbIdBanco.Location = New System.Drawing.Point(140, 185)
        Me.tbIdBanco.Name = "tbIdBanco"
        Me.tbIdBanco.Size = New System.Drawing.Size(37, 20)
        Me.tbIdBanco.TabIndex = 12
        Me.tbIdBanco.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgBancos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 167)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bancos"
        '
        'dgBancos
        '
        Me.dgBancos.AllowUserToAddRows = False
        Me.dgBancos.AllowUserToDeleteRows = False
        Me.dgBancos.AllowUserToResizeRows = False
        Me.dgBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idBanco, Me.codigoBanco, Me.banco})
        Me.dgBancos.Location = New System.Drawing.Point(6, 36)
        Me.dgBancos.Name = "dgBancos"
        Me.dgBancos.ReadOnly = True
        Me.dgBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBancos.Size = New System.Drawing.Size(266, 110)
        Me.dgBancos.TabIndex = 4
        Me.dgBancos.TabStop = False
        '
        'idBanco
        '
        Me.idBanco.DataPropertyName = "IdBanco"
        Me.idBanco.HeaderText = "idBanco"
        Me.idBanco.Name = "idBanco"
        Me.idBanco.ReadOnly = True
        Me.idBanco.Visible = False
        '
        'codigoBanco
        '
        Me.codigoBanco.DataPropertyName = "CodigoBanco"
        Me.codigoBanco.HeaderText = "Codigo"
        Me.codigoBanco.Name = "codigoBanco"
        Me.codigoBanco.ReadOnly = True
        '
        'banco
        '
        Me.banco.DataPropertyName = "NombreBanco"
        Me.banco.HeaderText = "Banco"
        Me.banco.Name = "banco"
        Me.banco.ReadOnly = True
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(309, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(133, 262)
        Me.gbAcciones.TabIndex = 10
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
        'tbBanco
        '
        Me.tbBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbBanco.Location = New System.Drawing.Point(59, 209)
        Me.tbBanco.Name = "tbBanco"
        Me.tbBanco.Size = New System.Drawing.Size(118, 20)
        Me.tbBanco.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Banco"
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Location = New System.Drawing.Point(13, 242)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(40, 13)
        Me.Codigo.TabIndex = 13
        Me.Codigo.Text = "Codigo"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(59, 239)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(118, 20)
        Me.tbCodigo.TabIndex = 14
        '
        'formABMBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 297)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.tbIdBanco)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.Controls.Add(Me.tbBanco)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formABMBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Bancos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbIdBanco As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgBancos As System.Windows.Forms.DataGridView
    Friend WithEvents idBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bNuevo As System.Windows.Forms.Button
    Friend WithEvents tbBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.Label
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
End Class
