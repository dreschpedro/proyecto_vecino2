Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class principal
    Private currentBtn As Icon
    Private leftBorderBtn As Panel

    'constructor
    'Public Sub New()

    '    ' Esta llamada es exigida por el diseñador.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    leftBorderBtn = New Panel()
    '    leftBorderBtn.Size = New Size(276, 45)
    '    PanelMenu.Controls.Add(leftBorderBtn)
    '    'Form'
    '    Me.Text = String.Empty
    '    'Me.ControlBox = False
    '    'Me.DoubleBuffered = True
    '    Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    'End Sub

    Private currentForm As Form = Nothing
    Private Sub abrirFormulariosHijos(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelhijoForm.Controls.Add(childForm)
        PanelhijoForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol_usuario = "Voluntario" Then
            btnDashboar.Enabled = False
            btnEcopunto.Enabled = False
            btnPersonal.Enabled = False
        ElseIf rol_usuario = "Responsable" Then
            btnEcopunto.Enabled = False
            btnConfigUsers.Enabled = False
        End If
        ocultarSubmenu()
    End Sub

    Private Sub ocultarSubmenu()
        PanelResiduosSubmenu.Visible = False
        PanelPersonalSubmenu.Visible = False
        PanelEstadisticasSubmenu.Visible = False
    End Sub

    Private Sub mostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnResiduos_Click(sender As Object, e As EventArgs) Handles btnResiduos.Click
        mostrarSubMenu(PanelResiduosSubmenu)
    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        mostrarSubMenu(PanelPersonalSubmenu)
    End Sub

    Private Sub btnDashboar_Click(sender As Object, e As EventArgs) Handles btnDashboar.Click
        mostrarSubMenu(PanelEstadisticasSubmenu)
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        abrirFormulariosHijos(New registros_hoy())
        ocultarSubmenu()
    End Sub

    Private Sub IconEgreso_Click(sender As Object, e As EventArgs) Handles IconEgreso.Click
        abrirFormulariosHijos(New salida_residuo())
        ocultarSubmenu()
    End Sub

    Private Sub btnAsistencias_Click(sender As Object, e As EventArgs) Handles btnAsistencias.Click
        abrirFormulariosHijos(New asistencia())
        ocultarSubmenu()
    End Sub

    Private Sub btnConfigUsers_Click(sender As Object, e As EventArgs) Handles btnConfigUsers.Click
        abrirFormulariosHijos(New config_user())
        ocultarSubmenu()
    End Sub

    Private Sub btnEcopunto_Click(sender As Object, e As EventArgs) Handles btnEcopunto.Click
        abrirFormulariosHijos(New ecopunto())
        ocultarSubmenu()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        abrirFormulariosHijos(New ayuda())
        ocultarSubmenu()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub



    Private Sub btnEstResiduos_Click(sender As Object, e As EventArgs) Handles btnEstResiduos.Click
        abrirFormulariosHijos(New estadistica_residuo())
        ocultarSubmenu()
    End Sub

    Private Sub btnEstaPersonal_Click_1(sender As Object, e As EventArgs) Handles btnEstaPersonal.Click
        abrirFormulariosHijos(New estadistica_personal())
        ocultarSubmenu()
    End Sub

    Private Sub btnEstEcopunto_Click_1(sender As Object, e As EventArgs) Handles btnEstEcopunto.Click
        abrirFormulariosHijos(New estadistica_ecopunto())
        ocultarSubmenu()
    End Sub

    Private Sub btnEstGloblaes_Click_1(sender As Object, e As EventArgs) Handles btnEstGloblaes.Click
        abrirFormulariosHijos(New estadistica_global())
        ocultarSubmenu()
    End Sub


    ''Drag Form'
    '<DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    'Private Shared Sub ReleaseCapture()
    'End Sub
    '<DllImport("user32.DLL", EntryPoint:="SendMessage")>
    'Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    'End Sub
    'Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
    '    ReleaseCapture()
    '    SendMessage(Me.Handle, &H112&, &HF012&, 0)
    'End Sub

    'Close-Maximize-Minimize'
    'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    '    Application.Exit()
    'End Sub
    'Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
    '    If WindowState = FormWindowState.Normal Then
    '        WindowState = FormWindowState.Maximized
    '    Else
    '        WindowState = FormWindowState.Normal
    '    End If
    'End Sub
    'Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    '    WindowState = FormWindowState.Minimized
    'End Sub
    'Remove transparent border in maximized state'
    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    If WindowState = FormWindowState.Maximized Then
    '        FormBorderStyle = FormBorderStyle.None
    '    Else
    '        FormBorderStyle = FormBorderStyle.Sizable
    '    End If
    'End Sub

    Private Sub fechayhora_Tick(sender As Object, e As EventArgs) Handles fechayhora.Tick
        LblFecha.Text = DateTime.Now.ToLongDateString()
        LblHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub PanelhijoForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelhijoForm.Paint

    End Sub


    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    Login.Show()
    'End Sub


End Class


