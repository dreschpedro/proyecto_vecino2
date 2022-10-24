Imports MySql.Data.MySqlClient


Public Class estadistica_residuo

    'consulta a usarse como parametro de la subrutina cargarLV
    Dim sql_rH_sin_hora As String = "SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo, registros_hoy.hora AS hora FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo"


    '##################     SUBRUTINAS       #######################

    Sub CargarLV(ByVal cadena As String)
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
                'limpio el list
                lviewResiduosHoy.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo la grilla utilizando el DReader
                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = lviewResiduosHoy.Items.Add(DReader("nombre_residuo"))
                    LV.SubItems.Add(DReader("cantidad_residuo"))

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
                    cmbNombreEcopunto.Items.Add(DReader(1))
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


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub estadistica_residuo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarLV(sql_rH_sin_hora)
        Call CargarEcopunto("SELECT ecopunto.id_ecopunto, nombre FROM ecopunto")
    End Sub

    Private Sub lviewResiduosHoy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviewResiduosHoy.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt_fecha.ValueChanged
        'MsgBox("Valor: " & dt_fecha.Value.ToString)
    End Sub

    Private Sub cbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles cbfecha.CheckedChanged
        If cbfecha.Checked = True Then
            dt_fecha.Enabled = True
        ElseIf cbfecha.Checked = False Then
            dt_fecha.Enabled = False
        End If
    End Sub
End Class