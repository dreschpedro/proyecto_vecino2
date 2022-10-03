<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadistica_global
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_ecopunto = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_pesonal = New System.Windows.Forms.DataGridView()
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.cht_residuo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dg_cartonero = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dg_ecopunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_pesonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_residuo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_cartonero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(109, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Residuos:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(402, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Residuos del Ecopunto:"
        '
        'dg_ecopunto
        '
        Me.dg_ecopunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_ecopunto.BackgroundColor = System.Drawing.Color.White
        Me.dg_ecopunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ecopunto.Location = New System.Drawing.Point(318, 64)
        Me.dg_ecopunto.Name = "dg_ecopunto"
        Me.dg_ecopunto.Size = New System.Drawing.Size(295, 251)
        Me.dg_ecopunto.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(79, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Asistencia de personal:"
        '
        'dg_pesonal
        '
        Me.dg_pesonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_pesonal.BackgroundColor = System.Drawing.Color.White
        Me.dg_pesonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pesonal.Location = New System.Drawing.Point(7, 64)
        Me.dg_pesonal.Name = "dg_pesonal"
        Me.dg_pesonal.Size = New System.Drawing.Size(298, 251)
        Me.dg_pesonal.TabIndex = 159
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
        Me.btn_imprimir.Location = New System.Drawing.Point(378, 8)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 157
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
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
        Me.btn_cerrar.TabIndex = 156
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'cht_residuo
        '
        ChartArea10.Name = "ChartArea1"
        Me.cht_residuo.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.cht_residuo.Legends.Add(Legend10)
        Me.cht_residuo.Location = New System.Drawing.Point(7, 345)
        Me.cht_residuo.Name = "cht_residuo"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Me.cht_residuo.Series.Add(Series10)
        Me.cht_residuo.Size = New System.Drawing.Size(300, 205)
        Me.cht_residuo.TabIndex = 166
        Me.cht_residuo.Text = "Chart1"
        '
        'dg_cartonero
        '
        Me.dg_cartonero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_cartonero.BackgroundColor = System.Drawing.Color.White
        Me.dg_cartonero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cartonero.Location = New System.Drawing.Point(318, 345)
        Me.dg_cartonero.Name = "dg_cartonero"
        Me.dg_cartonero.Size = New System.Drawing.Size(295, 205)
        Me.dg_cartonero.TabIndex = 167
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(354, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 13)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Cantidad de Residuos por Recuperador"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(90, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 29)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Estadísticas Globales"
        '
        'estadistica_global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 562)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg_cartonero)
        Me.Controls.Add(Me.cht_residuo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_ecopunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_pesonal)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estadistica_global"
        Me.Text = "Form10"
        CType(Me.dg_ecopunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_pesonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_residuo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_cartonero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_ecopunto As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_pesonal As DataGridView
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents cht_residuo As DataVisualization.Charting.Chart
    Friend WithEvents dg_cartonero As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
