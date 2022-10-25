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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub IconButton1_Paint(sender As Object, e As PaintEventArgs) Handles btn_ingresar.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = btn_ingresar.ClientRectangle
        myrectangle.Inflate(0, 40)
        buttonPath.AddEllipse(myrectangle)
        btn_ingresar.Region = New Region(buttonPath)
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        '"SELECT * FROM usuarios WHERE nombre_usuario='"
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
            Comando.CommandText = "SELECT usuario, pass FROM personal WHERE usuario='" & Trim(txt_usuario.Text) & "' AND pass='" & Trim(txt_usuario.Text) & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows <> False Then
                'si es verdadero, hay concidencia del usuario y clave cargados
                DReader.Read()
                'abro el formulario principal
                principal.Show()
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

        'principal.Show()
        'Me.Close()
    End Sub

End Class