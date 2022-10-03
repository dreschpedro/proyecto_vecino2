<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class config_user
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
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_modificar = New FontAwesome.Sharp.IconButton()
        Me.btn_buscar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_apeNom = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_ecopunto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_rol = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btn_eliminar.TabIndex = 122
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btn_modificar.TabIndex = 121
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btn_buscar.Location = New System.Drawing.Point(435, 403)
        Me.btn_buscar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_buscar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(194, 35)
        Me.btn_buscar.TabIndex = 120
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnAgregar.Location = New System.Drawing.Point(435, 362)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 35)
        Me.btnAgregar.TabIndex = 119
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
        Me.Label6.Location = New System.Drawing.Point(431, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Nombre del Ecopunto:"
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
        Me.Label4.Size = New System.Drawing.Size(316, 29)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Configuración de Usuario:"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(432, 137)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 13)
        Me.label1.TabIndex = 114
        Me.label1.Text = "Nombre del Usuario:"
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
        Me.btn_cerrar.TabIndex = 113
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
        Me.DataGridView1.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(431, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Rol:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(432, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Apellido y Nombre:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(431, 301)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(193, 20)
        Me.txt_telefono.TabIndex = 127
        '
        'txt_apeNom
        '
        Me.txt_apeNom.Location = New System.Drawing.Point(431, 247)
        Me.txt_apeNom.Name = "txt_apeNom"
        Me.txt_apeNom.Size = New System.Drawing.Size(193, 20)
        Me.txt_apeNom.TabIndex = 128
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(431, 153)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(193, 20)
        Me.txt_usuario.TabIndex = 130
        '
        'txt_ecopunto
        '
        Me.txt_ecopunto.Location = New System.Drawing.Point(431, 99)
        Me.txt_ecopunto.Name = "txt_ecopunto"
        Me.txt_ecopunto.Size = New System.Drawing.Size(193, 20)
        Me.txt_ecopunto.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(428, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Telefono:"
        '
        'lbl_rol
        '
        Me.lbl_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_rol.AutoSize = True
        Me.lbl_rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_rol.Location = New System.Drawing.Point(476, 199)
        Me.lbl_rol.Name = "lbl_rol"
        Me.lbl_rol.Size = New System.Drawing.Size(11, 13)
        Me.lbl_rol.TabIndex = 133
        Me.lbl_rol.Text = "-"
        '
        'config_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 561)
        Me.Controls.Add(Me.lbl_rol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_ecopunto)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_apeNom)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "config_user"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_modificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_buscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_apeNom As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_ecopunto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_rol As Label
End Class
