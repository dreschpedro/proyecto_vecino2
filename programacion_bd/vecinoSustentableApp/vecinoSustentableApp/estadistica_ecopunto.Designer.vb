<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadistica_ecopunto
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
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.cmb_ecopunto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_pesonal = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_ecopunto = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_cartonero = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dg_pesonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_ecopunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_cartonero, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_imprimir.Location = New System.Drawing.Point(413, 475)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 146
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'cmb_ecopunto
        '
        Me.cmb_ecopunto.FormattingEnabled = True
        Me.cmb_ecopunto.Location = New System.Drawing.Point(386, 32)
        Me.cmb_ecopunto.Name = "cmb_ecopunto"
        Me.cmb_ecopunto.Size = New System.Drawing.Size(221, 21)
        Me.cmb_ecopunto.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(393, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 20)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Seleccioná el Ecopunto:"
        '
        'dg_pesonal
        '
        Me.dg_pesonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_pesonal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dg_pesonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pesonal.Location = New System.Drawing.Point(10, 90)
        Me.dg_pesonal.Name = "dg_pesonal"
        Me.dg_pesonal.Size = New System.Drawing.Size(292, 178)
        Me.dg_pesonal.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(40, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Personas que asisten al Ecopunto:"
        '
        'dg_ecopunto
        '
        Me.dg_ecopunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_ecopunto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dg_ecopunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ecopunto.Location = New System.Drawing.Point(321, 90)
        Me.dg_ecopunto.Name = "dg_ecopunto"
        Me.dg_ecopunto.Size = New System.Drawing.Size(286, 178)
        Me.dg_ecopunto.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(394, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Residuos del Ecopunto:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(241, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Recuperador de Residuos:"
        '
        'dg_cartonero
        '
        Me.dg_cartonero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_cartonero.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dg_cartonero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cartonero.Location = New System.Drawing.Point(12, 301)
        Me.dg_cartonero.Name = "dg_cartonero"
        Me.dg_cartonero.Size = New System.Drawing.Size(595, 160)
        Me.dg_cartonero.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(105, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 24)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Estadísticas de Ecopunto"
        '
        'estadistica_ecopunto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 522)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dg_cartonero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_ecopunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg_pesonal)
        Me.Controls.Add(Me.cmb_ecopunto)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estadistica_ecopunto"
        Me.Text = "Form9"
        CType(Me.dg_pesonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_ecopunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_cartonero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_ecopunto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dg_pesonal As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_ecopunto As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dg_cartonero As DataGridView
    Friend WithEvents Label6 As Label
End Class
