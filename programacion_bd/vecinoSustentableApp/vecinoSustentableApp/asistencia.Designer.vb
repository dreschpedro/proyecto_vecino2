<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class asistencia
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
        Me.cmb_ecopunto = New System.Windows.Forms.ComboBox()
        Me.cmb_personal = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtSalida = New System.Windows.Forms.DateTimePicker()
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
        Me.btn_eliminar.TabIndex = 107
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
        Me.btn_modificar.TabIndex = 106
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
        Me.btn_buscar.TabIndex = 105
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
        Me.btnAgregar.TabIndex = 104
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cmb_ecopunto
        '
        Me.cmb_ecopunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ecopunto.FormattingEnabled = True
        Me.cmb_ecopunto.Location = New System.Drawing.Point(435, 170)
        Me.cmb_ecopunto.MaximumSize = New System.Drawing.Size(194, 0)
        Me.cmb_ecopunto.MinimumSize = New System.Drawing.Size(194, 0)
        Me.cmb_ecopunto.Name = "cmb_ecopunto"
        Me.cmb_ecopunto.Size = New System.Drawing.Size(194, 21)
        Me.cmb_ecopunto.TabIndex = 103
        '
        'cmb_personal
        '
        Me.cmb_personal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_personal.FormattingEnabled = True
        Me.cmb_personal.Location = New System.Drawing.Point(435, 105)
        Me.cmb_personal.MaximumSize = New System.Drawing.Size(194, 0)
        Me.cmb_personal.MinimumSize = New System.Drawing.Size(194, 0)
        Me.cmb_personal.Name = "cmb_personal"
        Me.cmb_personal.Size = New System.Drawing.Size(194, 21)
        Me.cmb_personal.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(432, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 99
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
        Me.Label4.Size = New System.Drawing.Size(228, 29)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Asistencia de Hoy:"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(432, 89)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 13)
        Me.label1.TabIndex = 97
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
        Me.btn_cerrar.TabIndex = 96
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
        Me.DataGridView1.TabIndex = 95
        '
        'dtEntrada
        '
        Me.dtEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtEntrada.Location = New System.Drawing.Point(434, 232)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(195, 20)
        Me.dtEntrada.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(431, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Horario de Entrada:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(431, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Horario de Salida:"
        '
        'dtSalida
        '
        Me.dtSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtSalida.Location = New System.Drawing.Point(434, 290)
        Me.dtSalida.Name = "dtSalida"
        Me.dtSalida.Size = New System.Drawing.Size(195, 20)
        Me.dtSalida.TabIndex = 110
        '
        'asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtSalida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtEntrada)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmb_ecopunto)
        Me.Controls.Add(Me.cmb_personal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "asistencia"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_modificar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_buscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_ecopunto As ComboBox
    Friend WithEvents cmb_personal As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtEntrada As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtSalida As DateTimePicker
End Class
