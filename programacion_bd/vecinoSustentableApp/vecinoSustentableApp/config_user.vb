Imports MySql.Data.MySqlClient

Public Class config_user


    Private Sub config_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pruebo conexion a la base de datos
        Call conectar()
        Call CargarList()


        'Opciones en el combobos de "Rol"
        'Se muestran al iniciar el formulario, solo se pueden elejir entre esas 2
        cmb_rol.Items.Add("Responsable")
        cmb_rol.Items.Add("Voluntario")
    End Sub

    '###################### SUBRUTINAS ####################

    Sub LimpiarForm()
        txt_usuario.Text = ""
        txt_pass.Text = ""
        cmb_rol.SelectedIndex = -1  'carga la opcion en blanco, que no tiene nada seleccionado
        txt_ape.Text = ""
        txt_nombre.Text = ""
        txt_telefono.Text = ""

    End Sub

    Sub CargarList()
        'cargo el list con los nombres
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
            Comando.CommandText = "SELECT personal.usuario AS usuario FROM personal ORDER BY personal.id_personal;"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'entonces cargo el list
                'limpio el list
                lb_usuario.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo el list con el campo "nombre" utilizando el DReader
                Do While DReader.Read
                    lb_usuario.Items.Add(DReader("usuario"))
                Loop
            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()


            'nueva consulta SQL
            'cuento la cantidad de registros
            'Comando.CommandText = "select COUNT(clavesocio) as Total from socio;"

            'cierro el DReader
            'DReader.Close()

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub lb_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_usuario.SelectedIndexChanged
        If lb_usuario.SelectedIndex >= 0 Then
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

                'cargo la sentencia para buscar un registro
                Comando.CommandText = "select * from personal where usuario = '" & lb_usuario.SelectedItem.ToString & "' ;"

                'obtengo los datos y los devuelvo a un objeto DataReader
                Dim DReader As MySqlDataReader

                'el método ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                'consulto si trajo registros
                If DReader.HasRows Then
                    'utilizo el DataReader para "mostrar" por los datos
                    DReader.Read()
                    txt_usuario.Text = DReader("usuario")
                    txt_pass.Text = DReader("pass")
                    cmb_rol.Text = DReader("rol")
                    txt_ape.Text = DReader("apellido")
                    txt_nombre.Text = DReader("nombre")
                    txt_telefono.Text = DReader("telefono")
                Else
                    MsgBox("El Socio no existe")
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
        End If
    End Sub

    '#############  BOTONES ##############

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If txt_usuario.Text = "" Or txt_pass.Text = "" Or cmb_rol.Text = "" Or txt_ape.Text = "" Or txt_nombre.Text = "" Or txt_telefono.Text = "" Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical)
            txt_usuario.Focus()
            Exit Sub
        End If

        'agrego un registro a la tabla
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

            'PRIMERO CONTROLO QUE EL REGISTRO NO EXISTA
            Comando.CommandText = "select usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & txt_usuario.Text & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si no encontro, entonces agrego
            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            Else
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para AGREGAR un registro
                Comando.CommandText = "insert into personal (usuario, pass, rol, apellido, nombre, telefono) values ('" & Trim(txt_usuario.Text) & "','" & Trim(txt_pass.Text) & "','" & Trim(cmb_rol.Text) & "','" & Trim(txt_ape.Text) & "','" & Trim(txt_nombre.Text) & "','" & Trim(txt_telefono.Text) & "');"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Agregados: " & Resultado)

                'cargo el list
                Call CargarList()
                Call LimpiarForm()
            End If


            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_limpiar_campos_Click(sender As Object, e As EventArgs) Handles btn_limpiar_campos.Click
        Call LimpiarForm()
    End Sub
End Class