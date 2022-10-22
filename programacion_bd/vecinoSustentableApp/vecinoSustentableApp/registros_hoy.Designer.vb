<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registros_hoy
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnModificar = New FontAwesome.Sharp.IconButton()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.lblMedida = New System.Windows.Forms.Label()
        Me.cmbNombreResiduo = New System.Windows.Forms.ComboBox()
        Me.cmbNombreEcopunto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_id_registro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(483, 230)
        Me.txtCantidad.MaximumSize = New System.Drawing.Size(140, 20)
        Me.txtCantidad.MinimumSize = New System.Drawing.Size(140, 20)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(140, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(479, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre del Residuo:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(479, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Residuos registrados hoy:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEliminar.IconSize = 15
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(484, 562)
        Me.btnEliminar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnEliminar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(194, 35)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.AutoSize = True
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btnModificar.IconColor = System.Drawing.Color.Black
        Me.btnModificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModificar.IconSize = 15
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(484, 521)
        Me.btnModificar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnModificar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(194, 35)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.IconSize = 15
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(483, 480)
        Me.btnBuscar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnBuscar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(194, 35)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.BackColor = System.Drawing.Color.Lime
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregar.IconColor = System.Drawing.Color.Black
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 15
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(482, 439)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 35)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblMedida
        '
        Me.lblMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida.AutoSize = True
        Me.lblMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedida.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMedida.Location = New System.Drawing.Point(645, 234)
        Me.lblMedida.Name = "lblMedida"
        Me.lblMedida.Size = New System.Drawing.Size(13, 16)
        Me.lblMedida.TabIndex = 22
        Me.lblMedida.Text = "-"
        '
        'cmbNombreResiduo
        '
        Me.cmbNombreResiduo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNombreResiduo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreResiduo.FormattingEnabled = True
        Me.cmbNombreResiduo.Location = New System.Drawing.Point(482, 174)
        Me.cmbNombreResiduo.Name = "cmbNombreResiduo"
        Me.cmbNombreResiduo.Size = New System.Drawing.Size(193, 21)
        Me.cmbNombreResiduo.TabIndex = 2
        '
        'cmbNombreEcopunto
        '
        Me.cmbNombreEcopunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNombreEcopunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreEcopunto.FormattingEnabled = True
        Me.cmbNombreEcopunto.Location = New System.Drawing.Point(482, 114)
        Me.cmbNombreEcopunto.Name = "cmbNombreEcopunto"
        Me.cmbNombreEcopunto.Size = New System.Drawing.Size(193, 21)
        Me.cmbNombreEcopunto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(479, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre del Ecopunto:"
        '
        'lbl_id_registro
        '
        Me.lbl_id_registro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id_registro.AutoSize = True
        Me.lbl_id_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_registro.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_id_registro.Location = New System.Drawing.Point(525, 42)
        Me.lbl_id_registro.Name = "lbl_id_registro"
        Me.lbl_id_registro.Size = New System.Drawing.Size(124, 25)
        Me.lbl_id_registro.TabIndex = 29
        Me.lbl_id_registro.Text = "id_registro"
        '
        'registros_hoy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 611)
        Me.Controls.Add(Me.lbl_id_registro)
        Me.Controls.Add(Me.cmbNombreEcopunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNombreResiduo)
        Me.Controls.Add(Me.lblMedida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registros_hoy"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMedida As Label
    Friend WithEvents cmbNombreResiduo As ComboBox
    Friend WithEvents cmbNombreEcopunto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_id_registro As Label
End Class
