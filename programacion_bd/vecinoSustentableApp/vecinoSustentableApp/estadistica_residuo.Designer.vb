<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadistica_residuo
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
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.lviewResiduosHoy = New System.Windows.Forms.ListView()
        Me.Residuo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbNombreEcopunto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
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
        Me.btn_cerrar.TabIndex = 97
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(107, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 29)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Estadística de Residuos"
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
        Me.btn_imprimir.Location = New System.Drawing.Point(419, 475)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 176
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'lviewResiduosHoy
        '
        Me.lviewResiduosHoy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lviewResiduosHoy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Residuo, Me.Cantidad})
        Me.lviewResiduosHoy.FullRowSelect = True
        Me.lviewResiduosHoy.HideSelection = False
        Me.lviewResiduosHoy.Location = New System.Drawing.Point(12, 71)
        Me.lviewResiduosHoy.Name = "lviewResiduosHoy"
        Me.lviewResiduosHoy.Size = New System.Drawing.Size(389, 439)
        Me.lviewResiduosHoy.TabIndex = 188
        Me.lviewResiduosHoy.UseCompatibleStateImageBehavior = False
        Me.lviewResiduosHoy.View = System.Windows.Forms.View.Details
        '
        'Residuo
        '
        Me.Residuo.Text = "Residuo"
        Me.Residuo.Width = 193
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.Width = 80
        '
        'cmbNombreEcopunto
        '
        Me.cmbNombreEcopunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNombreEcopunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreEcopunto.FormattingEnabled = True
        Me.cmbNombreEcopunto.Location = New System.Drawing.Point(422, 87)
        Me.cmbNombreEcopunto.Name = "cmbNombreEcopunto"
        Me.cmbNombreEcopunto.Size = New System.Drawing.Size(200, 21)
        Me.cmbNombreEcopunto.TabIndex = 177
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(419, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Nombre del Ecopunto:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(419, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "fecha del registro:"
        '
        'DataRepeater1
        '
        Me.DataRepeater1.Controls.Add(Me.DataRepeater1.ItemTemplate)
        Me.DataRepeater1.Location = New System.Drawing.Point(0, 0)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(240, 150)
        Me.DataRepeater1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(419, 147)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(203, 20)
        Me.DateTimePicker1.TabIndex = 189
        '
        'estadistica_residuo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 522)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lviewResiduosHoy)
        Me.Controls.Add(Me.cmbNombreEcopunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estadistica_residuo"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents lviewResiduosHoy As ListView
    Friend WithEvents Residuo As ColumnHeader
    Friend WithEvents Cantidad As ColumnHeader
    Friend WithEvents cmbNombreEcopunto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
