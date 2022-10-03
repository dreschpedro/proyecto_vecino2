<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ecopunto
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
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_horario = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_modificar = New FontAwesome.Sharp.IconButton()
        Me.btn_buscar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtEcopunto = New System.Windows.Forms.TextBox()
        Me.ch_lunes = New System.Windows.Forms.CheckBox()
        Me.dt_dias = New System.Windows.Forms.DateTimePicker()
        Me.ch_martes = New System.Windows.Forms.CheckBox()
        Me.ch_miercoles = New System.Windows.Forms.CheckBox()
        Me.ch_jueves = New System.Windows.Forms.CheckBox()
        Me.ch_viernes = New System.Windows.Forms.CheckBox()
        Me.ch_sabado = New System.Windows.Forms.CheckBox()
        Me.ch_domingo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btn_imprimir.Location = New System.Drawing.Point(435, 350)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 145
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(435, 134)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(194, 20)
        Me.txtDireccion.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(436, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Horario de Cierre:"
        '
        'dt_horario
        '
        Me.dt_horario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_horario.Checked = False
        Me.dt_horario.Location = New System.Drawing.Point(435, 182)
        Me.dt_horario.Name = "dt_horario"
        Me.dt_horario.Size = New System.Drawing.Size(194, 20)
        Me.dt_horario.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(436, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Horario de Apertura:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_eliminar.IconColor = System.Drawing.Color.Black
        Me.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminar.IconSize = 20
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(434, 513)
        Me.btn_eliminar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_eliminar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(194, 35)
        Me.btn_eliminar.TabIndex = 139
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.BackColor = System.Drawing.Color.Yellow
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btn_modificar.IconColor = System.Drawing.Color.Black
        Me.btn_modificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificar.IconSize = 20
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.Location = New System.Drawing.Point(434, 472)
        Me.btn_modificar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_modificar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(194, 35)
        Me.btn_modificar.TabIndex = 138
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_buscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_buscar.IconColor = System.Drawing.Color.Black
        Me.btn_buscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_buscar.IconSize = 20
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(435, 432)
        Me.btn_buscar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_buscar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(194, 35)
        Me.btn_buscar.TabIndex = 137
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.Lime
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregar.IconColor = System.Drawing.Color.Black
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 20
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(435, 391)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 35)
        Me.btnAgregar.TabIndex = 136
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(436, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(12, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 29)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Ecopuntos:"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(436, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(133, 13)
        Me.label1.TabIndex = 132
        Me.label1.Text = "Nombre del Ecopunto:"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(12, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 131
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 466)
        Me.DataGridView1.TabIndex = 130
        '
        'txtEcopunto
        '
        Me.txtEcopunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEcopunto.Location = New System.Drawing.Point(435, 83)
        Me.txtEcopunto.Name = "txtEcopunto"
        Me.txtEcopunto.Size = New System.Drawing.Size(194, 20)
        Me.txtEcopunto.TabIndex = 146
        '
        'ch_lunes
        '
        Me.ch_lunes.AutoSize = True
        Me.ch_lunes.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_lunes.Location = New System.Drawing.Point(548, 257)
        Me.ch_lunes.Name = "ch_lunes"
        Me.ch_lunes.Size = New System.Drawing.Size(55, 17)
        Me.ch_lunes.TabIndex = 147
        Me.ch_lunes.Text = "Lunes"
        Me.ch_lunes.UseVisualStyleBackColor = True
        '
        'dt_dias
        '
        Me.dt_dias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_dias.Checked = False
        Me.dt_dias.Location = New System.Drawing.Point(435, 231)
        Me.dt_dias.Name = "dt_dias"
        Me.dt_dias.Size = New System.Drawing.Size(194, 20)
        Me.dt_dias.TabIndex = 143
        '
        'ch_martes
        '
        Me.ch_martes.AutoSize = True
        Me.ch_martes.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_martes.Location = New System.Drawing.Point(451, 281)
        Me.ch_martes.Name = "ch_martes"
        Me.ch_martes.Size = New System.Drawing.Size(58, 17)
        Me.ch_martes.TabIndex = 148
        Me.ch_martes.Text = "Martes"
        Me.ch_martes.UseVisualStyleBackColor = True
        '
        'ch_miercoles
        '
        Me.ch_miercoles.AutoSize = True
        Me.ch_miercoles.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_miercoles.Location = New System.Drawing.Point(547, 281)
        Me.ch_miercoles.Name = "ch_miercoles"
        Me.ch_miercoles.Size = New System.Drawing.Size(71, 17)
        Me.ch_miercoles.TabIndex = 149
        Me.ch_miercoles.Text = "Miércoles"
        Me.ch_miercoles.UseVisualStyleBackColor = True
        '
        'ch_jueves
        '
        Me.ch_jueves.AutoSize = True
        Me.ch_jueves.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_jueves.Location = New System.Drawing.Point(451, 304)
        Me.ch_jueves.Name = "ch_jueves"
        Me.ch_jueves.Size = New System.Drawing.Size(60, 17)
        Me.ch_jueves.TabIndex = 150
        Me.ch_jueves.Text = "Jueves"
        Me.ch_jueves.UseVisualStyleBackColor = True
        '
        'ch_viernes
        '
        Me.ch_viernes.AutoSize = True
        Me.ch_viernes.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_viernes.Location = New System.Drawing.Point(547, 304)
        Me.ch_viernes.Name = "ch_viernes"
        Me.ch_viernes.Size = New System.Drawing.Size(61, 17)
        Me.ch_viernes.TabIndex = 151
        Me.ch_viernes.Text = "Viernes"
        Me.ch_viernes.UseVisualStyleBackColor = True
        '
        'ch_sabado
        '
        Me.ch_sabado.AutoSize = True
        Me.ch_sabado.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_sabado.Location = New System.Drawing.Point(451, 327)
        Me.ch_sabado.Name = "ch_sabado"
        Me.ch_sabado.Size = New System.Drawing.Size(63, 17)
        Me.ch_sabado.TabIndex = 152
        Me.ch_sabado.Text = "Sábado"
        Me.ch_sabado.UseVisualStyleBackColor = True
        '
        'ch_domingo
        '
        Me.ch_domingo.AutoSize = True
        Me.ch_domingo.ForeColor = System.Drawing.Color.Gainsboro
        Me.ch_domingo.Location = New System.Drawing.Point(548, 327)
        Me.ch_domingo.Name = "ch_domingo"
        Me.ch_domingo.Size = New System.Drawing.Size(68, 17)
        Me.ch_domingo.TabIndex = 153
        Me.ch_domingo.Text = "Domingo"
        Me.ch_domingo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(448, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Días Activos:"
        '
        'ecopunto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 561)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ch_domingo)
        Me.Controls.Add(Me.ch_sabado)
        Me.Controls.Add(Me.ch_viernes)
        Me.Controls.Add(Me.ch_jueves)
        Me.Controls.Add(Me.ch_miercoles)
        Me.Controls.Add(Me.ch_martes)
        Me.Controls.Add(Me.ch_lunes)
        Me.Controls.Add(Me.txtEcopunto)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.dt_dias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt_horario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ecopunto"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_horario As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_modificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_buscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtEcopunto As TextBox
    Friend WithEvents ch_lunes As CheckBox
    Friend WithEvents dt_dias As DateTimePicker
    Friend WithEvents ch_martes As CheckBox
    Friend WithEvents ch_miercoles As CheckBox
    Friend WithEvents ch_jueves As CheckBox
    Friend WithEvents ch_viernes As CheckBox
    Friend WithEvents ch_sabado As CheckBox
    Friend WithEvents ch_domingo As CheckBox
    Friend WithEvents Label5 As Label
End Class
