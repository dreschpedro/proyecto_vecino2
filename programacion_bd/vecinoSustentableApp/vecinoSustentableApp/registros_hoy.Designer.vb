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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnModificar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.cmb_residuo = New System.Windows.Forms.ComboBox()
        Me.cmb_ecopunto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv_registro = New System.Windows.Forms.ListView()
        Me.id_registro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ecopunto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.residuo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_id_registro = New System.Windows.Forms.Label()
        Me.lbl_eco = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_vista = New FontAwesome.Sharp.IconButton()
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
        Me.Label4.Location = New System.Drawing.Point(117, 11)
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
        Me.btnAgregar.Location = New System.Drawing.Point(483, 478)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 35)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cmb_residuo
        '
        Me.cmb_residuo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_residuo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_residuo.FormattingEnabled = True
        Me.cmb_residuo.Location = New System.Drawing.Point(482, 174)
        Me.cmb_residuo.Name = "cmb_residuo"
        Me.cmb_residuo.Size = New System.Drawing.Size(193, 21)
        Me.cmb_residuo.TabIndex = 2
        '
        'cmb_ecopunto
        '
        Me.cmb_ecopunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ecopunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ecopunto.FormattingEnabled = True
        Me.cmb_ecopunto.Location = New System.Drawing.Point(482, 114)
        Me.cmb_ecopunto.Name = "cmb_ecopunto"
        Me.cmb_ecopunto.Size = New System.Drawing.Size(193, 21)
        Me.cmb_ecopunto.TabIndex = 1
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
        'lv_registro
        '
        Me.lv_registro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_registro.AutoArrange = False
        Me.lv_registro.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_registro, Me.ecopunto, Me.residuo, Me.cantidad})
        Me.lv_registro.FullRowSelect = True
        Me.lv_registro.HideSelection = False
        Me.lv_registro.Location = New System.Drawing.Point(16, 101)
        Me.lv_registro.Name = "lv_registro"
        Me.lv_registro.Size = New System.Drawing.Size(457, 498)
        Me.lv_registro.TabIndex = 31
        Me.lv_registro.UseCompatibleStateImageBehavior = False
        Me.lv_registro.View = System.Windows.Forms.View.Details
        '
        'id_registro
        '
        Me.id_registro.Text = "id_registro"
        Me.id_registro.Width = 0
        '
        'ecopunto
        '
        Me.ecopunto.Text = "Ecopunto"
        Me.ecopunto.Width = 0
        '
        'residuo
        '
        Me.residuo.Text = "Residuo"
        Me.residuo.Width = 230
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.Width = 100
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_imprimir.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btn_imprimir.IconColor = System.Drawing.Color.White
        Me.btn_imprimir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_imprimir.IconSize = 20
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(484, 437)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 177
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(16, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(78, 75)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(190, 20)
        Me.txt_buscar.TabIndex = 178
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad.Location = New System.Drawing.Point(482, 230)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(193, 20)
        Me.txt_cantidad.TabIndex = 180
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(501, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "id_reg:"
        Me.Label5.Visible = False
        '
        'lbl_id_registro
        '
        Me.lbl_id_registro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id_registro.AutoSize = True
        Me.lbl_id_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_registro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_id_registro.Location = New System.Drawing.Point(553, 35)
        Me.lbl_id_registro.Name = "lbl_id_registro"
        Me.lbl_id_registro.Size = New System.Drawing.Size(11, 13)
        Me.lbl_id_registro.TabIndex = 182
        Me.lbl_id_registro.Text = "-"
        Me.lbl_id_registro.Visible = False
        '
        'lbl_eco
        '
        Me.lbl_eco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_eco.AutoSize = True
        Me.lbl_eco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_eco.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_eco.Location = New System.Drawing.Point(553, 57)
        Me.lbl_eco.Name = "lbl_eco"
        Me.lbl_eco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_eco.TabIndex = 184
        Me.lbl_eco.Text = "-"
        Me.lbl_eco.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(501, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "id_eco:"
        Me.Label7.Visible = False
        '
        'btn_vista
        '
        Me.btn_vista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_vista.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_vista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_vista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_vista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vista.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_vista.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btn_vista.IconColor = System.Drawing.Color.White
        Me.btn_vista.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_vista.IconSize = 20
        Me.btn_vista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_vista.Location = New System.Drawing.Point(485, 396)
        Me.btn_vista.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_vista.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_vista.Name = "btn_vista"
        Me.btn_vista.Size = New System.Drawing.Size(194, 35)
        Me.btn_vista.TabIndex = 185
        Me.btn_vista.Text = "Vista Previa"
        Me.btn_vista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_vista.UseVisualStyleBackColor = False
        '
        'registros_hoy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 611)
        Me.Controls.Add(Me.btn_vista)
        Me.Controls.Add(Me.lbl_eco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_id_registro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.lv_registro)
        Me.Controls.Add(Me.cmb_ecopunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_residuo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registros_hoy"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_residuo As ComboBox
    Friend WithEvents cmb_ecopunto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lv_registro As ListView
    Friend WithEvents residuo As ColumnHeader
    Friend WithEvents cantidad As ColumnHeader
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents ecopunto As ColumnHeader
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents id_registro As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_id_registro As Label
    Friend WithEvents lbl_eco As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_vista As FontAwesome.Sharp.IconButton
End Class
