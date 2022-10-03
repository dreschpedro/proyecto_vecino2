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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.cht_año = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cht_mes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cht_dia = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg_cartonero = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        CType(Me.cht_año, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_dia, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cht_año
        '
        Me.cht_año.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea4.Name = "ChartArea1"
        Me.cht_año.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.cht_año.Legends.Add(Legend4)
        Me.cht_año.Location = New System.Drawing.Point(12, 305)
        Me.cht_año.Name = "cht_año"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.cht_año.Series.Add(Series4)
        Me.cht_año.Size = New System.Drawing.Size(300, 205)
        Me.cht_año.TabIndex = 168
        Me.cht_año.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(70, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 13)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Cantidad de Residuos en el AÑO"
        '
        'cht_mes
        '
        Me.cht_mes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea5.Name = "ChartArea1"
        Me.cht_mes.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.cht_mes.Legends.Add(Legend5)
        Me.cht_mes.Location = New System.Drawing.Point(319, 71)
        Me.cht_mes.Name = "cht_mes"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.cht_mes.Series.Add(Series5)
        Me.cht_mes.Size = New System.Drawing.Size(300, 205)
        Me.cht_mes.TabIndex = 170
        Me.cht_mes.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(388, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Cantidad de Residuos en el MES"
        '
        'cht_dia
        '
        ChartArea6.Name = "ChartArea1"
        Me.cht_dia.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.cht_dia.Legends.Add(Legend6)
        Me.cht_dia.Location = New System.Drawing.Point(13, 71)
        Me.cht_dia.Name = "cht_dia"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.cht_dia.Series.Add(Series6)
        Me.cht_dia.Size = New System.Drawing.Size(300, 205)
        Me.cht_dia.TabIndex = 172
        Me.cht_dia.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(70, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Cantidad de Residuos en el DIA"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(351, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 13)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Cantidad de Residuos por Recuperador"
        '
        'dg_cartonero
        '
        Me.dg_cartonero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_cartonero.BackgroundColor = System.Drawing.Color.White
        Me.dg_cartonero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cartonero.Location = New System.Drawing.Point(318, 305)
        Me.dg_cartonero.Name = "dg_cartonero"
        Me.dg_cartonero.Size = New System.Drawing.Size(301, 205)
        Me.dg_cartonero.TabIndex = 173
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
        Me.btn_imprimir.Location = New System.Drawing.Point(419, 7)
        Me.btn_imprimir.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.MinimumSize = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(194, 35)
        Me.btn_imprimir.TabIndex = 176
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'estadistica_residuo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 522)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg_cartonero)
        Me.Controls.Add(Me.cht_dia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cht_mes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cht_año)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estadistica_residuo"
        Me.Text = "Form7"
        CType(Me.cht_año, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_cartonero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cerrar As Button
    Friend WithEvents cht_año As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents cht_mes As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents cht_dia As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dg_cartonero As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
End Class
