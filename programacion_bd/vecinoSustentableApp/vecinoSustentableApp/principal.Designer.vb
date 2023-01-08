<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.PanelEstadisticasSubmenu = New System.Windows.Forms.Panel()
        Me.btnEstGloblaes = New FontAwesome.Sharp.IconButton()
        Me.btnEstEcopunto = New FontAwesome.Sharp.IconButton()
        Me.btnEstaPersonal = New FontAwesome.Sharp.IconButton()
        Me.btnEstResiduos = New FontAwesome.Sharp.IconButton()
        Me.PanelPersonalSubmenu = New System.Windows.Forms.Panel()
        Me.btnConfigUsers = New FontAwesome.Sharp.IconButton()
        Me.btnAsistencias = New FontAwesome.Sharp.IconButton()
        Me.PanelResiduosSubmenu = New System.Windows.Forms.Panel()
        Me.IconEgreso = New FontAwesome.Sharp.IconButton()
        Me.btnIngreso = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nom_eco = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnAyuda = New FontAwesome.Sharp.IconButton()
        Me.btnDashboar = New FontAwesome.Sharp.IconButton()
        Me.btnEcopunto = New FontAwesome.Sharp.IconButton()
        Me.btnPersonal = New FontAwesome.Sharp.IconButton()
        Me.btnResiduos = New FontAwesome.Sharp.IconButton()
        Me.PanelhijoForm = New System.Windows.Forms.Panel()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.fechayhora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEstadisticasSubmenu.SuspendLayout()
        Me.PanelPersonalSubmenu.SuspendLayout()
        Me.PanelResiduosSubmenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelhijoForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEstadisticasSubmenu
        '
        Me.PanelEstadisticasSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.PanelEstadisticasSubmenu.Controls.Add(Me.btnEstGloblaes)
        Me.PanelEstadisticasSubmenu.Controls.Add(Me.btnEstEcopunto)
        Me.PanelEstadisticasSubmenu.Controls.Add(Me.btnEstaPersonal)
        Me.PanelEstadisticasSubmenu.Controls.Add(Me.btnEstResiduos)
        Me.PanelEstadisticasSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEstadisticasSubmenu.Location = New System.Drawing.Point(0, 521)
        Me.PanelEstadisticasSubmenu.Name = "PanelEstadisticasSubmenu"
        Me.PanelEstadisticasSubmenu.Size = New System.Drawing.Size(276, 185)
        Me.PanelEstadisticasSubmenu.TabIndex = 12
        '
        'btnEstGloblaes
        '
        Me.btnEstGloblaes.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEstGloblaes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstGloblaes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstGloblaes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstGloblaes.ForeColor = System.Drawing.Color.White
        Me.btnEstGloblaes.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas
        Me.btnEstGloblaes.IconColor = System.Drawing.Color.White
        Me.btnEstGloblaes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEstGloblaes.IconSize = 43
        Me.btnEstGloblaes.Location = New System.Drawing.Point(0, 135)
        Me.btnEstGloblaes.Name = "btnEstGloblaes"
        Me.btnEstGloblaes.Padding = New System.Windows.Forms.Padding(33, 0, 0, 0)
        Me.btnEstGloblaes.Size = New System.Drawing.Size(276, 45)
        Me.btnEstGloblaes.TabIndex = 14
        Me.btnEstGloblaes.Text = "Estadisticas Globales"
        Me.btnEstGloblaes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstGloblaes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstGloblaes.UseVisualStyleBackColor = False
        '
        'btnEstEcopunto
        '
        Me.btnEstEcopunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEstEcopunto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstEcopunto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstEcopunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstEcopunto.ForeColor = System.Drawing.Color.White
        Me.btnEstEcopunto.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot
        Me.btnEstEcopunto.IconColor = System.Drawing.Color.White
        Me.btnEstEcopunto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEstEcopunto.IconSize = 43
        Me.btnEstEcopunto.Location = New System.Drawing.Point(0, 90)
        Me.btnEstEcopunto.Name = "btnEstEcopunto"
        Me.btnEstEcopunto.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.btnEstEcopunto.Size = New System.Drawing.Size(276, 45)
        Me.btnEstEcopunto.TabIndex = 13
        Me.btnEstEcopunto.Text = "Estadisticas de los Ecopuntos"
        Me.btnEstEcopunto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstEcopunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstEcopunto.UseVisualStyleBackColor = False
        '
        'btnEstaPersonal
        '
        Me.btnEstaPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEstaPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstaPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstaPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstaPersonal.ForeColor = System.Drawing.Color.White
        Me.btnEstaPersonal.IconChar = FontAwesome.Sharp.IconChar.UserTag
        Me.btnEstaPersonal.IconColor = System.Drawing.Color.White
        Me.btnEstaPersonal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEstaPersonal.IconSize = 40
        Me.btnEstaPersonal.Location = New System.Drawing.Point(0, 45)
        Me.btnEstaPersonal.Name = "btnEstaPersonal"
        Me.btnEstaPersonal.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.btnEstaPersonal.Size = New System.Drawing.Size(276, 45)
        Me.btnEstaPersonal.TabIndex = 12
        Me.btnEstaPersonal.Text = "Estadisticas del Personal"
        Me.btnEstaPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstaPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstaPersonal.UseVisualStyleBackColor = False
        '
        'btnEstResiduos
        '
        Me.btnEstResiduos.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEstResiduos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstResiduos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstResiduos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstResiduos.ForeColor = System.Drawing.Color.White
        Me.btnEstResiduos.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.btnEstResiduos.IconColor = System.Drawing.Color.White
        Me.btnEstResiduos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEstResiduos.IconSize = 43
        Me.btnEstResiduos.Location = New System.Drawing.Point(0, 0)
        Me.btnEstResiduos.Name = "btnEstResiduos"
        Me.btnEstResiduos.Padding = New System.Windows.Forms.Padding(33, 0, 0, 0)
        Me.btnEstResiduos.Size = New System.Drawing.Size(276, 45)
        Me.btnEstResiduos.TabIndex = 11
        Me.btnEstResiduos.Text = "Historial de Residuos"
        Me.btnEstResiduos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEstResiduos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstResiduos.UseVisualStyleBackColor = False
        '
        'PanelPersonalSubmenu
        '
        Me.PanelPersonalSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.PanelPersonalSubmenu.Controls.Add(Me.btnConfigUsers)
        Me.PanelPersonalSubmenu.Controls.Add(Me.btnAsistencias)
        Me.PanelPersonalSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPersonalSubmenu.Location = New System.Drawing.Point(0, 334)
        Me.PanelPersonalSubmenu.Name = "PanelPersonalSubmenu"
        Me.PanelPersonalSubmenu.Size = New System.Drawing.Size(276, 97)
        Me.PanelPersonalSubmenu.TabIndex = 4
        '
        'btnConfigUsers
        '
        Me.btnConfigUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnConfigUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfigUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigUsers.ForeColor = System.Drawing.Color.White
        Me.btnConfigUsers.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.btnConfigUsers.IconColor = System.Drawing.Color.White
        Me.btnConfigUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConfigUsers.IconSize = 43
        Me.btnConfigUsers.Location = New System.Drawing.Point(0, 45)
        Me.btnConfigUsers.Name = "btnConfigUsers"
        Me.btnConfigUsers.Padding = New System.Windows.Forms.Padding(42, 0, 0, 0)
        Me.btnConfigUsers.Size = New System.Drawing.Size(276, 45)
        Me.btnConfigUsers.TabIndex = 2
        Me.btnConfigUsers.Text = "Configuración de Usuario"
        Me.btnConfigUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfigUsers.UseVisualStyleBackColor = False
        '
        'btnAsistencias
        '
        Me.btnAsistencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnAsistencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsistencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencias.ForeColor = System.Drawing.Color.White
        Me.btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.btnAsistencias.IconColor = System.Drawing.Color.White
        Me.btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAsistencias.IconSize = 40
        Me.btnAsistencias.Location = New System.Drawing.Point(0, 0)
        Me.btnAsistencias.Name = "btnAsistencias"
        Me.btnAsistencias.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnAsistencias.Size = New System.Drawing.Size(276, 45)
        Me.btnAsistencias.TabIndex = 1
        Me.btnAsistencias.Text = "Asistencias"
        Me.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAsistencias.UseVisualStyleBackColor = False
        '
        'PanelResiduosSubmenu
        '
        Me.PanelResiduosSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.PanelResiduosSubmenu.Controls.Add(Me.IconEgreso)
        Me.PanelResiduosSubmenu.Controls.Add(Me.btnIngreso)
        Me.PanelResiduosSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelResiduosSubmenu.Location = New System.Drawing.Point(0, 192)
        Me.PanelResiduosSubmenu.Name = "PanelResiduosSubmenu"
        Me.PanelResiduosSubmenu.Size = New System.Drawing.Size(276, 97)
        Me.PanelResiduosSubmenu.TabIndex = 2
        '
        'IconEgreso
        '
        Me.IconEgreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.IconEgreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconEgreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconEgreso.ForeColor = System.Drawing.Color.White
        Me.IconEgreso.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.IconEgreso.IconColor = System.Drawing.Color.White
        Me.IconEgreso.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconEgreso.IconSize = 46
        Me.IconEgreso.Location = New System.Drawing.Point(0, 45)
        Me.IconEgreso.Name = "IconEgreso"
        Me.IconEgreso.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IconEgreso.Size = New System.Drawing.Size(276, 45)
        Me.IconEgreso.TabIndex = 2
        Me.IconEgreso.Text = "Salida de Residuos"
        Me.IconEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconEgreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconEgreso.UseVisualStyleBackColor = False
        '
        'btnIngreso
        '
        Me.btnIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngreso.ForeColor = System.Drawing.Color.White
        Me.btnIngreso.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.btnIngreso.IconColor = System.Drawing.Color.White
        Me.btnIngreso.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIngreso.IconSize = 40
        Me.btnIngreso.Location = New System.Drawing.Point(0, 0)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnIngreso.Size = New System.Drawing.Size(276, 45)
        Me.btnIngreso.TabIndex = 1
        Me.btnIngreso.Text = "Ingreso de Residuos"
        Me.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIngreso.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.Label2)
        Me.PanelLogo.Controls.Add(Me.lbl_usuario)
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.lbl_nom_eco)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(276, 147)
        Me.PanelLogo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(3, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "Usuario:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_usuario.Location = New System.Drawing.Point(75, 95)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(13, 16)
        Me.lbl_usuario.TabIndex = 192
        Me.lbl_usuario.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(1, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Ecopunto:"
        '
        'lbl_nom_eco
        '
        Me.lbl_nom_eco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nom_eco.AutoSize = True
        Me.lbl_nom_eco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom_eco.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_nom_eco.Location = New System.Drawing.Point(3, 127)
        Me.lbl_nom_eco.Name = "lbl_nom_eco"
        Me.lbl_nom_eco.Size = New System.Drawing.Size(13, 16)
        Me.lbl_nom_eco.TabIndex = 190
        Me.lbl_nom_eco.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.vecinoSustentableApp.My.Resources.Resources.horizontal2
        Me.PictureBox1.Location = New System.Drawing.Point(34, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAyuda)
        Me.PanelMenu.Controls.Add(Me.PanelEstadisticasSubmenu)
        Me.PanelMenu.Controls.Add(Me.btnDashboar)
        Me.PanelMenu.Controls.Add(Me.btnEcopunto)
        Me.PanelMenu.Controls.Add(Me.PanelPersonalSubmenu)
        Me.PanelMenu.Controls.Add(Me.btnPersonal)
        Me.PanelMenu.Controls.Add(Me.PanelResiduosSubmenu)
        Me.PanelMenu.Controls.Add(Me.btnResiduos)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(293, 611)
        Me.PanelMenu.TabIndex = 2
        '
        'btnAyuda
        '
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAyuda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.ForeColor = System.Drawing.Color.White
        Me.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion
        Me.btnAyuda.IconColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyuda.IconSize = 32
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.Location = New System.Drawing.Point(0, 706)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAyuda.Size = New System.Drawing.Size(276, 45)
        Me.btnAyuda.TabIndex = 13
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnDashboar
        '
        Me.btnDashboar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboar.FlatAppearance.BorderSize = 0
        Me.btnDashboar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboar.ForeColor = System.Drawing.Color.White
        Me.btnDashboar.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        Me.btnDashboar.IconColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnDashboar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboar.IconSize = 32
        Me.btnDashboar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboar.Location = New System.Drawing.Point(0, 476)
        Me.btnDashboar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboar.Name = "btnDashboar"
        Me.btnDashboar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboar.Size = New System.Drawing.Size(276, 45)
        Me.btnDashboar.TabIndex = 6
        Me.btnDashboar.Text = "Estadísticas"
        Me.btnDashboar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboar.UseVisualStyleBackColor = True
        '
        'btnEcopunto
        '
        Me.btnEcopunto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEcopunto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEcopunto.FlatAppearance.BorderSize = 0
        Me.btnEcopunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEcopunto.ForeColor = System.Drawing.Color.White
        Me.btnEcopunto.IconChar = FontAwesome.Sharp.IconChar.MapLocation
        Me.btnEcopunto.IconColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEcopunto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEcopunto.IconSize = 32
        Me.btnEcopunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEcopunto.Location = New System.Drawing.Point(0, 431)
        Me.btnEcopunto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEcopunto.Name = "btnEcopunto"
        Me.btnEcopunto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEcopunto.Size = New System.Drawing.Size(276, 45)
        Me.btnEcopunto.TabIndex = 5
        Me.btnEcopunto.Text = "Ecopuntos"
        Me.btnEcopunto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEcopunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEcopunto.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPersonal.FlatAppearance.BorderSize = 0
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonal.ForeColor = System.Drawing.Color.White
        Me.btnPersonal.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnPersonal.IconColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnPersonal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPersonal.IconSize = 32
        Me.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonal.Location = New System.Drawing.Point(0, 289)
        Me.btnPersonal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPersonal.Size = New System.Drawing.Size(276, 45)
        Me.btnPersonal.TabIndex = 3
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnResiduos
        '
        Me.btnResiduos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResiduos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResiduos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnResiduos.FlatAppearance.BorderSize = 0
        Me.btnResiduos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResiduos.ForeColor = System.Drawing.Color.White
        Me.btnResiduos.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.btnResiduos.IconColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnResiduos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResiduos.IconSize = 32
        Me.btnResiduos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResiduos.Location = New System.Drawing.Point(0, 147)
        Me.btnResiduos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResiduos.Name = "btnResiduos"
        Me.btnResiduos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnResiduos.Size = New System.Drawing.Size(276, 45)
        Me.btnResiduos.TabIndex = 1
        Me.btnResiduos.Text = "Residuos"
        Me.btnResiduos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResiduos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResiduos.UseVisualStyleBackColor = True
        '
        'PanelhijoForm
        '
        Me.PanelhijoForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelhijoForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelhijoForm.Controls.Add(Me.LblFecha)
        Me.PanelhijoForm.Controls.Add(Me.LblHora)
        Me.PanelhijoForm.Controls.Add(Me.PictureBox2)
        Me.PanelhijoForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelhijoForm.Location = New System.Drawing.Point(293, 0)
        Me.PanelhijoForm.Name = "PanelhijoForm"
        Me.PanelhijoForm.Size = New System.Drawing.Size(691, 611)
        Me.PanelhijoForm.TabIndex = 4
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(170, 468)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(80, 29)
        Me.LblFecha.TabIndex = 2
        Me.LblFecha.Text = "Fecha"
        '
        'LblHora
        '
        Me.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 56.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.White
        Me.LblHora.Location = New System.Drawing.Point(193, 383)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(200, 85)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "Hora"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.vecinoSustentableApp.My.Resources.Resources.vecino_blanco_cutout4
        Me.PictureBox2.Location = New System.Drawing.Point(192, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(318, 294)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'fechayhora
        '
        Me.fechayhora.Enabled = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.PanelhijoForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 650)
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelEstadisticasSubmenu.ResumeLayout(False)
        Me.PanelPersonalSubmenu.ResumeLayout(False)
        Me.PanelResiduosSubmenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelhijoForm.ResumeLayout(False)
        Me.PanelhijoForm.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAyuda As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelEstadisticasSubmenu As Panel
    Friend WithEvents btnEstGloblaes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEstEcopunto As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEstaPersonal As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEstResiduos As FontAwesome.Sharp.IconButton
    Friend WithEvents IconEgreso As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIngreso As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConfigUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEcopunto As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelPersonalSubmenu As Panel
    Friend WithEvents btnAsistencias As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPersonal As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelResiduosSubmenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDashboar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnResiduos As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelhijoForm As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents fechayhora As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nom_eco As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_usuario As Label
End Class
