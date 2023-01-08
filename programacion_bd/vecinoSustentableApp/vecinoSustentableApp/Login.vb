Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Login
#Region "customize Controls"
    Private Sub CustomizeComponents()
        'txtUser
        txt_usuario.AutoSize = False
        txt_usuario.Size = New Size(350, 45)
        'txtPass
        txt_pass.AutoSize = False
        txt_pass.Size = New Size(350, 45)
        txt_pass.UseSystemPasswordChar = True
    End Sub
#End Region


#Region "Form Behaviors" 'ni idea de para que sirven las regiones pero por las dudas sigo el tutorial al pie de la letra
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region
    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Sub CargarEcopunto(ByVal cadena As String)
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'cargo la sentencia
            Comando.CommandText = cadena

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'utilizo el DataReader para "navegar" por los datos
                'cargo el combobox utilizando el DReader

                Do While DReader.Read
                    'se muestra el nombre del ecopunto (2da posicion)
                    cmb_ecopunto.Items.Add(DReader(1))

                    '##########################################################################
                    'cmb_ecopunto.ValueMember = DReader(0) 'valor con el que se trabaja (id del ecopunto)
                    'cmb_ecopunto.DisplayMember = DReader(1) 'valor que se muestra (nombre del ecopunto)

                    'cmb_ecopunto.Items.Add(cmb_ecopunto.DisplayMember)
                Loop

            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargar ecopunto
        Call CargarEcopunto("SELECT ecopunto.id_ecopunto, nombre FROM ecopunto order by ecopunto.id_ecopunto")
        txt_usuario.Select()


        'txtUser
        txt_usuario.AutoSize = False
        txt_usuario.Size = New Size(350, 35)
        'txtPass
        txt_pass.AutoSize = False
        txt_pass.Size = New Size(350, 35)
        txt_pass.UseSystemPasswordChar = True

        Try
            'para ganar velocidad conecto y desconecto de la base
            Call conectar()
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            'si hay error muestro el mensaje
            MessageBox.Show("No se ha podido conectar al servidor")
            MsgBox(ex.Message)
            conexion.Close()
        End Try

    End Sub

    Private Sub btn_ingresar_Paint(sender As Object, e As PaintEventArgs) Handles btn_ingresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = btn_ingresar.ClientRectangle
        myrectangle.Inflate(0, 40)
        buttonPath.AddEllipse(myrectangle)
        btn_ingresar.Region = New Region(buttonPath)
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim culosucio As Integer = 7

        cmb_ecopunto.SelectedIndex = culosucio

        'si estan cargados los campos, sigo
        If (txt_usuario.Text = "") Or (txt_pass.Text = "") Or (cmb_ecopunto.SelectedIndex = -1) Then
            MsgBox("CARGUE TODOS LOS CAMPOS", MsgBoxStyle.Critical, "ATENCION")
            conexion.Close()
        Else


            Try
                'conecto a la base
                Call conectar()
                conexion.Open()

                'trabajo con los datos

                'el objeto command permite ejecutar sentencias SQL
                Dim Comando As New MySqlCommand

                'conecto el objeto command
                Comando.Connection = conexion

                'configuro command para sentencia SQL
                Comando.CommandType = CommandType.Text

                'cargo la sentencia
                Comando.CommandText = "SELECT apellido, nombre, usuario, pass, rol FROM personal WHERE usuario='" & Trim(txt_usuario.Text) & "' AND pass='" & Trim(txt_pass.Text) & "';"

                'obtengo los datos y los devuelvo a un objeto DataReader
                Dim DReader As MySqlDataReader

                'el método ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                'consulto si trajo registros
                If DReader.HasRows <> False Then
                    'si es verdadero, hay concidencia del usuario y clave cargados
                    DReader.Read()

                    'guardo el rol del usuario que ingreso
                    rol_usuario = DReader("rol")
                    ape_usuario = DReader("apellido")
                    nom_usuario = DReader("nombre")
                    user = DReader("usuario")
                    'abro el formulario principal
                    principal.Show()
                    Me.Close()
                Else
                    MsgBox("USUARIO O CLAVE INCORRECTOS", MsgBoxStyle.Critical, "ATENCION")
                End If

                'cierro el DReader
                DReader.Close()

                'cierro la conexion
                conexion.Close()

            Catch ex As Exception
                'SI HAY UN ERROR MUESTRO EL MENSAJE
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If



        'principal.Show()
        'Me.Close()
    End Sub

    Private Sub btn_ojo_MouseLeave(sender As Object, e As EventArgs) Handles btn_ojo.MouseLeave
        txt_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_ojo_MouseEnter(sender As Object, e As EventArgs) Handles btn_ojo.MouseEnter
        txt_pass.UseSystemPasswordChar = False
    End Sub

    Private Sub cmb_ecopunto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ecopunto.SelectedIndexChanged
        lbl_eco.Text = cmb_ecopunto.SelectedIndex + 1
        lbl_nom_eco.Text = cmb_ecopunto.Text

        id_ecopunto = cmb_ecopunto.SelectedIndex + 1
        nombre_ecopunto = cmb_ecopunto.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ReportViewerForm2.Show()
    End Sub
End Class