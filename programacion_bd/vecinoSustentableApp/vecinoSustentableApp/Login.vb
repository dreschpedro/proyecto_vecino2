Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Login
#Region "customize Controls"
    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 45)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 45)
        txtPass.UseSystemPasswordChar = True
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
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 35)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 35)
        txtPass.UseSystemPasswordChar = True

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

    Private Sub IconButton1_Paint(sender As Object, e As PaintEventArgs) Handles IconButton1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myrectangle As Rectangle = IconButton1.ClientRectangle
        myrectangle.Inflate(0, 40)
        buttonPath.AddEllipse(myrectangle)
        IconButton1.Region = New Region(buttonPath)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        principal.Show()
        Me.Close()
    End Sub
End Class