﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formABMSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formABMSucursales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgModelos = New System.Windows.Forms.DataGridView()
        Me.gbAcciones = New System.Windows.Forms.GroupBox()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.codigoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.tbCodigoSucursal = New System.Windows.Forms.TextBox()
        Me.tbSucursal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbIdSucursal = New System.Windows.Forms.TextBox()
        Me.tbIdBanco = New System.Windows.Forms.TextBox()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 209)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sucursales"
        '
        'dgModelos
        '
        Me.dgModelos.AllowUserToAddRows = False
        Me.dgModelos.AllowUserToDeleteRows = False
        Me.dgModelos.AllowUserToResizeRows = False
        Me.dgModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoBanco, Me.banco, Me.idBanco, Me.idSucursal, Me.sucursal, Me.codigoSucursal})
        Me.dgModelos.Location = New System.Drawing.Point(6, 27)
        Me.dgModelos.Name = "dgModelos"
        Me.dgModelos.ReadOnly = True
        Me.dgModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgModelos.Size = New System.Drawing.Size(444, 159)
        Me.dgModelos.TabIndex = 7
        Me.dgModelos.TabStop = False
        '
        'gbAcciones
        '
        Me.gbAcciones.Controls.Add(Me.bSalir)
        Me.gbAcciones.Controls.Add(Me.bEliminar)
        Me.gbAcciones.Controls.Add(Me.bModificar)
        Me.gbAcciones.Controls.Add(Me.bNuevo)
        Me.gbAcciones.Location = New System.Drawing.Point(474, 12)
        Me.gbAcciones.Name = "gbAcciones"
        Me.gbAcciones.Size = New System.Drawing.Size(115, 336)
        Me.gbAcciones.TabIndex = 17
        Me.gbAcciones.TabStop = False
        Me.gbAcciones.Text = "Acciones"
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SistemaLaTortuga.My.Resources.Resources._exit
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(19, 222)
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
        Me.bEliminar.Location = New System.Drawing.Point(19, 166)
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
        Me.bModificar.Location = New System.Drawing.Point(19, 106)
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
        Me.bNuevo.Location = New System.Drawing.Point(19, 48)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(80, 35)
        Me.bNuevo.TabIndex = 3
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = True
        '
        'codigoBanco
        '
        Me.codigoBanco.DataPropertyName = "CodigoBanco"
        Me.codigoBanco.HeaderText = "Cod. Banco"
        Me.codigoBanco.Name = "codigoBanco"
        Me.codigoBanco.ReadOnly = True
        Me.codigoBanco.Width = 90
        '
        'banco
        '
        Me.banco.DataPropertyName = "NombreBanco"
        Me.banco.HeaderText = "Banco"
        Me.banco.Name = "banco"
        Me.banco.ReadOnly = True
        Me.banco.Width = 150
        '
        'idBanco
        '
        Me.idBanco.DataPropertyName = "IdBanco"
        Me.idBanco.HeaderText = "idBanco"
        Me.idBanco.Name = "idBanco"
        Me.idBanco.ReadOnly = True
        Me.idBanco.Visible = False
        '
        'idSucursal
        '
        Me.idSucursal.DataPropertyName = "IdSucursal"
        Me.idSucursal.HeaderText = "idSucursal"
        Me.idSucursal.Name = "idSucursal"
        Me.idSucursal.ReadOnly = True
        Me.idSucursal.Visible = False
        '
        'sucursal
        '
        Me.sucursal.DataPropertyName = "NombreSucursal"
        Me.sucursal.HeaderText = "Sucursal"
        Me.sucursal.Name = "sucursal"
        Me.sucursal.ReadOnly = True
        Me.sucursal.Width = 150
        '
        'codigoSucursal
        '
        Me.codigoSucursal.DataPropertyName = "CodigoSucursal"
        Me.codigoSucursal.HeaderText = "codigoSucursal"
        Me.codigoSucursal.Name = "codigoSucursal"
        Me.codigoSucursal.ReadOnly = True
        Me.codigoSucursal.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bLimpiar)
        Me.GroupBox2.Controls.Add(Me.tbCodigoSucursal)
        Me.GroupBox2.Controls.Add(Me.tbSucursal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbIdSucursal)
        Me.GroupBox2.Controls.Add(Me.tbIdBanco)
        Me.GroupBox2.Controls.Add(Me.cbBancos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 122)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Location = New System.Drawing.Point(260, 17)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(65, 23)
        Me.bLimpiar.TabIndex = 34
        Me.bLimpiar.Text = "Limpiar"
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'tbCodigoSucursal
        '
        Me.tbCodigoSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCodigoSucursal.Location = New System.Drawing.Point(103, 62)
        Me.tbCodigoSucursal.Name = "tbCodigoSucursal"
        Me.tbCodigoSucursal.Size = New System.Drawing.Size(121, 20)
        Me.tbCodigoSucursal.TabIndex = 33
        '
        'tbSucursal
        '
        Me.tbSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSucursal.Location = New System.Drawing.Point(103, 98)
        Me.tbSucursal.Name = "tbSucursal"
        Me.tbSucursal.Size = New System.Drawing.Size(121, 20)
        Me.tbSucursal.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Codigo Sucursal"
        '
        'tbIdSucursal
        '
        Me.tbIdSucursal.Location = New System.Drawing.Point(260, 94)
        Me.tbIdSucursal.Name = "tbIdSucursal"
        Me.tbIdSucursal.Size = New System.Drawing.Size(35, 20)
        Me.tbIdSucursal.TabIndex = 30
        Me.tbIdSucursal.Visible = False
        '
        'tbIdBanco
        '
        Me.tbIdBanco.Location = New System.Drawing.Point(260, 62)
        Me.tbIdBanco.Name = "tbIdBanco"
        Me.tbIdBanco.Size = New System.Drawing.Size(35, 20)
        Me.tbIdBanco.TabIndex = 29
        Me.tbIdBanco.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(103, 19)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(121, 21)
        Me.cbBancos.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Banco"
        '
        'formABMSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 360)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAcciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formABMSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Sucursales"
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
    Friend WithEvents codigoBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bLimpiar As System.Windows.Forms.Button
    Friend WithEvents tbCodigoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents tbSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbIdSucursal As System.Windows.Forms.TextBox
    Friend WithEvents tbIdBanco As System.Windows.Forms.TextBox
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
