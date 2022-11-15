Imports MySql.Data.MySqlClient

Public Class config_user

    Dim consulta_personal = "SELECT personal.usuario AS usuario FROM personal ORDER BY personal.id_personal;"

    Public id_foto As String
    Public img_path As String = ""
    Public txtId As String
    Public iddelabosta, idnum As Integer
    Public id_actual As String
    Public id_alto As String

    '############## VALIDACION DE ESCRITURA  ######################
    '           USUARIO Y CLAVE
    Private Sub camposUP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress, txt_pass.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsLetter(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, letras, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite simbolos
        End If
    End Sub

    '           APELLIDO Y NOMBRE
    Private Sub camposNA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ape.KeyPress, txt_nombre.KeyPress
        If ((Char.IsLetter(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'letras, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite simbolos ni numeros
        End If
    End Sub

    '           TELEFONO
    Private Sub camposTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite simbolos ni letras
        End If
    End Sub


    Private Sub the_last_id()


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
                Comando.CommandText = "SELECT MAX(id_personal+1) AS idmasuno
                                          From personal"

                'obtengo los datos y los devuelvo a un objeto DataReader
                Dim DReader As MySqlDataReader

                'el método ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                'consulto si trajo registros
                If DReader.HasRows Then
                    'Call BuscarImagenBD("id_personal")
                    'utilizo el DataReader para "mostrar" los datos
                    DReader.Read()
                id_alto = DReader("idmasuno")
                'Label9.Text = id_alto

            Else
                    'MsgBox("EL SOCIO NO EXISTE", MsgBoxStyle.Critical, "ATENCION")
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

    '           FORM LOAD
    Private Sub config_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pruebo conexion a la base de datos
        Call conectar()
        Call CargarList(consulta_personal)
        Call the_last_id()

        'Opciones en el combobos de "Rol"
        'Se muestran al iniciar el formulario, solo se pueden elejir entre esas 2
        cmb_rol.Items.Add("Administrador")
        cmb_rol.Items.Add("Responsable")
        cmb_rol.Items.Add("Voluntario")
    End Sub

    '###################### SUBRUTINAS ####################


    '           CONVERTIR IMG A BYTE
    Public Function ConvertImageFiletoBytes(ByVal ImageFilePath As String) As Byte()
        'funcion convierte la imagen a binario para guardar en la BD
        Dim _tempByte() As Byte = Nothing
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageFilePath")
            Return Nothing
        End If
        Try
            Dim _fileInfo As New IO.FileInfo(ImageFilePath)
            Dim _NumBytes As Long = _fileInfo.Length
            Dim _FStream As New IO.FileStream(ImageFilePath, IO.FileMode.Open, IO.FileAccess.Read)
            Dim _BinaryReader As New IO.BinaryReader(_FStream)
            _tempByte = _BinaryReader.ReadBytes(Convert.ToInt32(_NumBytes))
            _fileInfo = Nothing
            _NumBytes = 0
            _FStream.Close()
            _FStream.Dispose()
            _BinaryReader.Close()
            Return _tempByte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
                'Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageData")
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertImageFiletoMemoryStream(ByVal ImageFilePath As String) As IO.MemoryStream
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Return Nothing
            ' Throw New ArgumentNullException("ILa imagen no puede estar vacia", "ImageFilePath")
        End If
        Return ConvertBytesToMemoryStream(ConvertImageFiletoBytes(ImageFilePath))
    End Function

    '           buscar IMG en BD
    Sub BuscarImagenBD(ByVal id_personal_IMG As Integer)
        Dim Conn As MySql.Data.MySqlClient.MySqlConnection
        Conn = New MySql.Data.MySqlClient.MySqlConnection

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=vecino_sustentable; port=3306;"
            Conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Connect")
        End Try

        Dim cons_sql As String
        cons_sql = "Select *
                    From imagenes
                    Where id_img = " & id_personal_IMG & ";"

        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        adapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(cons_sql, Conn)

        Dim Data As New DataTable 'Data debe estar cargado con algun dato -> ¿?
        Dim commandbuild As New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter)
        adapter.Fill(Data)

        If Data.Rows.Count > 0 Then
            'cargo la imagen
            Dim lb() As Byte = Data.Rows(Data.Rows.Count - 1).Item("foto")
            Dim lstr As New System.IO.MemoryStream(lb)
            'cargo la imagen en el+ picture
            pbPicture.Image = Image.FromStream(lstr)
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Else
            MsgBox("NO HAY IMAGEN", MsgBoxStyle.Critical, "ATENCION")
        End If
    End Sub

    Sub LimpiarForm()
        txt_usuario.Text = ""
        txt_pass.Text = ""
        cmb_rol.SelectedIndex = -1  'carga la opcion en blanco, que no tiene nada seleccionado
        txt_ape.Text = ""
        txt_nombre.Text = ""
        txt_telefono.Text = ""
        txt_buscar.Text = ""
        pbPicture.Image = Nothing
        lb_usuario.SelectedIndex = -1


    End Sub

    'Private Sub guardaFoto()
    '    'guarda la imagen seleccionada en la BD
    '    If img_path <> "" Then

    '        'informo el path del archivo de imagen a la funcion
    '        Dim filename As String = img_path
    '        Dim FileSize As UInt32

    '        Dim Conn As MySql.Data.MySqlClient.MySqlConnection
    '        Conn = New MySql.Data.MySqlClient.MySqlConnection

    '        Try
    '            If Conn.State = ConnectionState.Open Then Conn.Close()
    '            Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=vecino_sustentable; port=3306"
    '            Conn.Open()

    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString, "Connect")
    '        End Try

    '        Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

    '        Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

    '        FileSize = mstream.Length

    '        Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
    '        Dim sql As String
    '        mstream.Close()

    '        iddelabosta = lb_usuario.Items.Count + 1


    '        sql = "insert into personal (foto, tam_archivo, nom_archivo) VALUES( @Archi, @TamArchi, @NomArchi)"


    '        Try

    '            With sqlcmd
    '                .CommandText = sql
    '                .Connection = Conn
    '                .Parameters.AddWithValue("@NomArchi", filename)
    '                .Parameters.AddWithValue("@TamArchi", FileSize)
    '                .Parameters.AddWithValue("@Archi", arrImage)
    '                .ExecuteNonQuery()
    '            End With

    '            'limpio imagen
    '            img_path = ""
    '            pbPicture.Image = Nothing

    '            'pbPicture.
    '            MsgBox("IMAGEN GUARDADA EN BD")
    '            'Call CargarList()

    '            Conn.Close()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try

    '    End If

    '    Call LimpiarForm()
    'End Sub

    Sub CargarList(ByVal cadena As String)
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
            Comando.CommandText = cadena

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
            'Comando.CommandText = "Select COUNT(clavesocio) As Total from socio;"

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

    Private Sub actualizar_IMG(ByVal id_person_nuevo As String)
        'guarda la imagen seleccionada en la BD
        If img_path <> "" Then

            'informo el path del archivo de imagen a la funcion
            Dim filename As String = img_path
            Dim FileSize As UInt32

            Dim Conn As MySql.Data.MySqlClient.MySqlConnection
            Conn = New MySql.Data.MySqlClient.MySqlConnection

            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.ConnectionString = "server= localhost; user id=root; password=123456; database=vecino_sustentable; port=3306;"
                Conn.Open()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Connect")
            End Try

            Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

            Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

            FileSize = mstream.Length

            Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
            Dim sql As String
            mstream.Close()

            sql = "Update imagenes
                    SET foto= @Archi,
                    tam_archivo = @TamArchi,
                    nom_archivo = @NomArchi
                    WHERE id_personal ='" & id_person_nuevo & "';"



            Try

                With sqlcmd
                    .CommandText = sql
                    .Connection = Conn
                    .Parameters.AddWithValue("@NomArchi", filename)
                    .Parameters.AddWithValue("@TamArchi", FileSize)
                    .Parameters.AddWithValue("@Archi", arrImage)
                    .ExecuteNonQuery()
                End With

                'limpio imagen
                img_path = ""
                pbPicture.Image = Nothing

                'pbPicture.
                MsgBox("IMAGEN ACTUALIZADA EN BD")
                Call CargarList(consulta_personal)

                Conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub guardarIMG(ByVal id_person_nuevo As String)
        'guarda la imagen seleccionada en la BD
        If img_path <> "" Then

            'informo el path del archivo de imagen a la funcion
            Dim filename As String = img_path
            Dim FileSize As UInt32

            Dim Conn As MySql.Data.MySqlClient.MySqlConnection
            Conn = New MySql.Data.MySqlClient.MySqlConnection

            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.ConnectionString = "server= localhost; user id=root; password=123456; database=vecino_sustentable; port=3306;"
                Conn.Open()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Connect")
            End Try

            Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

            Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

            FileSize = mstream.Length

            Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
            Dim sql As String
            mstream.Close()

            sql = "insert into imagenes (id_personal, foto, tam_archivo, nom_archivo) VALUES('" & id_person_nuevo & "', @Archi, @TamArchi, @NomArchi)"

            Try
                With sqlcmd
                    .CommandText = sql
                    .Connection = Conn
                    .Parameters.AddWithValue("@NomArchi", filename)
                    .Parameters.AddWithValue("@TamArchi", FileSize)
                    .Parameters.AddWithValue("@Archi", arrImage)
                    .ExecuteNonQuery()
                End With
                'limpio imagen
                img_path = ""
                pbPicture.Image = Nothing

                'pbPicture.
                MsgBox("IMAGEN GUARDADA EN BD")
                Call CargarList(consulta_personal)
                Conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    ''subrutina agregar imagen a BD
    ''guarda la imagen seleccionada en la BD
    'If img_path <> "" Then

    '    'informo el path del archivo de imagen a la funcion
    '    Dim filename As String = img_path
    '    Dim FileSize As UInt32

    '    Dim Conn As MySql.Data.MySqlClient.MySqlConnection
    '    Conn = New MySql.Data.MySqlClient.MySqlConnection

    '    Try
    '        If Conn.State = ConnectionState.Open Then Conn.Close()
    '        Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=vecino_sustentable; port=3306;"
    '        Conn.Open()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, "Connect")
    '    End Try


    '    '###########################################################################
    '    'Dim Comando As New MySqlCommand
    '    'Comando.CommandText = "select * imagenes where id_personal = '" & id_personal & "';"
    '    ''obtengo los datos y los devuelvo a un objeto DataReader
    '    'Dim DReader As MySqlDataReader
    '    ''el método ExecuteReader trae los datos de la BD
    '    'DReader = Comando.ExecuteReader

    '    'id_personal = DReader("id_personal")

    '    'Dim eso As String = ""

    '    '###########################################################################

    '    Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

    '    Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

    '    FileSize = mstream.Length

    '    Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
    '    Dim sql As String
    '    mstream.Close()

    '    'sql = "insert into imagenes (id_personal, foto, tam_archivo, nom_archivo) VALUES(" & id_personal & ", @Archi, @TamArchi, @NomArchi)"
    '    sql = "insert into imagenes (foto, tam_archivo, nom_archivo) VALUES( @Archi, @TamArchi, @NomArchi) "

    '    Try

    '        With sqlcmd
    '            .CommandText = sql
    '            .Connection = Conn

    '            .Parameters.AddWithValue("@NomArchi", filename)
    '            .Parameters.AddWithValue("@TamArchi", FileSize)
    '            .Parameters.AddWithValue("@Archi", arrImage)
    '            .ExecuteNonQuery()
    '        End With

    '        'limpio imagen
    '        img_path = ""
    '        pbPicture.Image = Nothing

    '        'pbPicture.
    '        MsgBox("IMAGEN GUARDADA EN BD")
    '        Call CargarList(consulta_personal)

    '        Conn.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End If


    '#############  BOTONES ##############

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
                Comando.CommandText = "SELECT personal.id_personal AS id_personal,
                                        personal.usuario AS usuario,
                                        personal.pass AS pass,
                                        personal.rol AS rol,
                                        personal.apellido AS apellido,
                                        personal.nombre AS nombre,
                                        personal.telefono AS telefono,
                                        imagenes.id_img AS id_img
                                        FROM imagenes
                                        JOIN personal ON personal.id_personal = imagenes.id_personal
                                        WHERE personal.usuario = '" & lb_usuario.SelectedItem.ToString & "';"

                'obtengo los datos y los devuelvo a un objeto DataReader
                Dim DReader As MySqlDataReader

                'el método ExecuteReader trae los datos de la BD
                DReader = Comando.ExecuteReader

                'consulto si trajo registros
                If DReader.HasRows Then
                    'Call BuscarImagenBD("id_personal")
                    'utilizo el DataReader para "mostrar" los datos
                    DReader.Read()
                    txtId = DReader("id_personal")
                    id_actual = DReader("id_personal")
                    txt_usuario.Text = DReader("usuario")
                    txt_pass.Text = DReader("pass")
                    cmb_rol.Text = DReader("rol")
                    txt_ape.Text = DReader("apellido")
                    txt_nombre.Text = DReader("nombre")
                    txt_telefono.Text = DReader("telefono")
                    id_foto = DReader("id_img")
                    Call BuscarImagenBD(Trim(id_foto))
                Else
                    MsgBox("EL SOCIO NO TIENE IMAGEN CARGADA", MsgBoxStyle.Critical, "ATENCION")
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
        'Call BuscarImagenBD(txtId)
        '##################################################################################################
        'buscar imagen BD
        'busco una imagen cargada en la BD y la traigo
        'If txtId <> "" Then
        '    Call BuscarImagenBD(txtId)
        'End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_campos_Click(sender As Object, e As EventArgs) Handles btn_limpiar_campos.Click
        Call LimpiarForm()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados

        If (img_path = "") Or (cmb_rol.SelectedIndex = -1) Or Trim(txt_ape.Text = "") Or Trim(txt_nombre.Text = "") Or Trim(txt_usuario.Text = "") Or Trim(txt_pass.Text = "") Or Trim(txt_telefono.Text = "") Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical, "ATENCION")
            txt_nombre.Focus()
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
            Comando.CommandText = "select id_personal, usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & txt_usuario.Text & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si no encontro, entonces agrego
            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical, "ATENCION")
                'cierro el DataReader
                DReader.Close()
            Else
                'cierro el DataReader
                DReader.Close()

                Comando.CommandText = "insert into personal (usuario, pass, rol, apellido, nombre, telefono) 
                                        values ('" & Trim(txt_usuario.Text) & "',
                                        '" & Trim(txt_pass.Text) & "',
                                        '" & Trim(cmb_rol.Text) & "',
                                        '" & Trim(txt_ape.Text) & "',
                                        '" & Trim(txt_nombre.Text) & "',
                                        '" & Trim(txt_telefono.Text) & "');"



                ''#################################################

                'Comando.CommandText = "SELECT MAX(id_personal+1) AS idmasuno
                '                          From personal"

                ''el método ExecuteReader trae los datos de la BD
                'DReader = Comando.ExecuteReader

                ''consulto si trajo registros
                ''If DReader.HasRows Then
                ''Call BuscarImagenBD("id_personal")
                ''utilizo el DataReader para "mostrar" los datos
                'DReader.Read()
                '    id_alto = DReader("idmasuno")

                '    '################################################


                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Agregados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
                Call guardarIMG(Trim(id_alto))
                Call CargarList(consulta_personal)
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

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        'primero controlo que esten los datos cargados

        If (lb_usuario.SelectedIndex = -1) Or (cmb_rol.SelectedIndex = -1) Or Trim(txt_ape.Text = "") Or Trim(txt_nombre.Text = "") Or Trim(txt_usuario.Text = "") Or Trim(txt_pass.Text = "") Or Trim(txt_telefono.Text = "") Then
            MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Information, "ATENCION")
            txt_nombre.Focus()
            Exit Sub
        End If

        'modifico un registro de la tabla
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

            'PRIMERO CONTROLO QUE EL REGISTRO EXISTA
            Comando.CommandText = "select id_personal, usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & Trim(txt_usuario.Text) & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then

                'cierro el DataReader
                DReader.Close()



                Comando.CommandText = "update personal 
                                        set usuario='" & Trim(txt_usuario.Text) & "',
                                        pass='" & Trim(txt_pass.Text) & "',
                                        rol='" & Trim(cmb_rol.Text) & "',
                                        apellido='" & Trim(txt_ape.Text) & "',
                                        nombre='" & Trim(txt_nombre.Text) & "',
                                        telefono='" & Trim(txt_telefono.Text) & "' 
                                        where usuario = '" & Trim(txt_usuario.Text) & "';"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Modificados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
                'Call guardarIMG(Trim(id_foto))
                Call actualizar_IMG(txtId)
                Call CargarList(consulta_personal)
                Call LimpiarForm()

            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical, "ATENCION")
                'cierro el DataReader
                DReader.Close()
            End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        'primero controlo que esten los datos cargados
        If Trim(txt_usuario.Text) = "" And Trim(txt_pass.Text) = "" And Trim(cmb_rol.SelectedIndex) = -1 And Trim(txt_ape.Text) = "" And Trim(txt_nombre.Text) = "" And Trim(txt_telefono.Text) = "" Then
            MsgBox("SELECCIONE REGISTRO A ELIMINAR", MsgBoxStyle.Critical, "ATENCION")
            lb_usuario.Focus()
            Exit Sub
        End If

        'elimino un registro de la tabla
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

            'PRIMERO CONTROLO QUE EL REGISTRO EXISTA
            Comando.CommandText = "select usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & Trim(txt_usuario.Text) & "';"
            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader
            'si encontro, entonces ELIMINO
            If DReader.HasRows Then
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para ELIMINAR un registro
                Comando.CommandText = "delete from personal where usuario = '" & Trim(txt_usuario.Text) & "';"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Eliminados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
                Call CargarList(consulta_personal)
                Call LimpiarForm()
            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical, "ATENCION")
                'cierro el DataReader
                DReader.Close()
            End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click

        'abro la ventana de busqueda 
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'cargo en el text el Path de la Imagen
            img_path = OpenFileDialog1.FileName
            'cargo la imagen en el picturebox 
            pbPicture.ImageLocation = img_path
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btn_sacar_foto_Click(sender As Object, e As EventArgs) Handles btn_sacar_foto.Click

    End Sub

    'BUSQUEDA ASISTIDA ----> CAMPO USUARIO
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        'busco los temas segun lo ingresado
        'armo la consulta y llamo a la subrutina
        If txt_buscar.Text <> "" Then
            ' si escribio algo busco

            Dim ConsultaSQL = "SELECT usuario, pass, rol, apellido, nombre, telefono from personal WHERE ((usuario like '%" & txt_buscar.Text & "%') OR (apellido like '%" & txt_buscar.Text & "%') OR (nombre like '%" & txt_buscar.Text & "%')) order by nombre;"

            Call CargarList(ConsultaSQL)
        Else
            'si no cargo nada limpio el list
            'txt_usuario.Items.Clear()
            Call CargarList(consulta_personal)
            'lstTemas.Visible = False
        End If
    End Sub


    '###################        IMPRESORA       ################

    Private Sub factura_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles HojaImpresion.PrintPage
        Try
            ' La fuente a usar
            Dim prFont As New Font("Arial", 30, FontStyle.Bold)
            ' la posicion superior
            'imprimir una imagen
            e.Graphics.DrawImage(pbPicture.Image, 30, 30, 200, 200)
            'direccion
            e.Graphics.DrawString("Vecino Sutentable", prFont, Brushes.Black, 300, 30)

            prFont = New Font("Arial", 25, FontStyle.Bold)
            'e.Graphics.DrawString("Impreso por el Administrador:", prFont, Brushes.Black, 170, 200)
            'prFont = New Font("Arial", 25, FontStyle.Italic)
            'e.Graphics.DrawString(ape_usuario & ", " & nom_usuario, prFont, Brushes.Black, 250, 240)
            'factura lado derecho superior
            'e.Graphics.DrawString("n°de factura", prFont, Brushes.Black, 650, 10)
            'e.Graphics.DrawString(labelcantidaddefactura.Text, prFont, Brushes.Black, 650, 40)
            'tipo de factura
            'e.Graphics.DrawRectangle(Pens.Black, 300, 10, 200, 200)

            'imprimimos la fecha y hora
            'prFont = New Font("Arial", 12, FontStyle.Italic)
            'e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " - " &
            'Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 610, 100)

            'stilo A,B.C
            'prFont = New Font("arial", 100, FontStyle.Underline)
            'e.Graphics.DrawString("C", prFont, Brushes.Black, 320, 0)

            'GRAFICAR LINE -> por bajo de "Impreso por el Administrador: Dresch, Pedro"
            e.Graphics.DrawLine(Pens.Black, 0, 300, 850, 300)

            'prFont = New Font("Arial", 18, FontStyle.Bold)
            'e.Graphics.DrawString(cmb_rol.Text, prFont, Brushes.Black, 15, 310)

            prFont = New Font("Arial", 12, FontStyle.Bold)
            'datos de paciente 
            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("ROL:", prFont, Brushes.Black, 250, 100)
            prFont = New Font("Arial", 18, FontStyle.Italic)
            e.Graphics.DrawString(cmb_rol.Text, prFont, Brushes.Black, 330, 100)

            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("APELLIDO:", prFont, Brushes.Black, 250, 140)
            prFont = New Font("Arial", 18, FontStyle.Italic)
            e.Graphics.DrawString(txt_ape.Text, prFont, Brushes.Black, 400, 140)

            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("NOMBRE:", prFont, Brushes.Black, 250, 180)
            prFont = New Font("Arial", 18, FontStyle.Italic)
            e.Graphics.DrawString(txt_nombre.Text, prFont, Brushes.Black, 380, 180)

            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("TELEFONO:", prFont, Brushes.Black, 250, 220)
            prFont = New Font("Arial", 18, FontStyle.Italic)
            e.Graphics.DrawString(txt_telefono.Text, prFont, Brushes.Black, 410, 220)


            'e.Graphics.DrawLine(Pens.Black, 0, 440, 850, 440)

            'prFont = New Font("Arial", 18, FontStyle.Bold)
            'e.Graphics.DrawString("tratamiento", prFont, Brushes.Black, 10, 460)
            'e.Graphics.DrawString(ComboBoxtratamiento2.Text, prFont, Brushes.Black, 10, 520)
            'e.Graphics.DrawString("precio.uni", prFont, Brushes.Black, 210, 460)
            'e.Graphics.DrawString(Txtprecio.Text, prFont, Brushes.Black, 210, 520)
            'e.Graphics.DrawString("cantidad ", prFont, Brushes.Black, 410, 460)
            'e.Graphics.DrawString(Txtcantidad.Text, prFont, Brushes.Black, 410, 520)
            'e.Graphics.DrawString("total ", prFont, Brushes.Black, 610, 460)
            'e.Graphics.DrawString(Txttotal.Text, prFont, Brushes.Black, 610, 520)
            'imprimir lineas
            'e.Graphics.DrawLine(Pens.Black, 0, 490, 850, 490)
            'e.Graphics.DrawLine(Pens.Black, 210, 440, 210, 1000)
            'e.Graphics.DrawLine(Pens.Black, 410, 440, 410, 1000)
            'e.Graphics.DrawLine(Pens.Black, 610, 440, 610, 1000)
            'e.Graphics.DrawLine(Pens.Black, 0, 1000, 850, 1000)
            'imprimir un rectangulo
            ' e.Graphics.DrawRectangle(Pens.Green, 90, 90, 250, 100)
            'imprimir un circulo
            'e.Graphics.DrawEllipse(Pens.Indigo, 350, 900, 300, 100)
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btn_vista_Click(sender As Object, e As EventArgs) Handles btn_vista.Click
        'si los campos estan cargados, se muestra
        If Trim(txt_usuario.Text) <> "" And Trim(txt_pass.Text) <> "" And Trim(cmb_rol.SelectedIndex) <> -1 And Trim(txt_ape.Text) <> "" And Trim(txt_nombre.Text) <> "" And Trim(txt_telefono.Text) <> "" Then
            'para una vista previa
            'selecciono PrintDocument generado
            VistaPrevia.Document = HojaImpresion
            'tamaño de ventana
            VistaPrevia.Width = 300
            VistaPrevia.Height = 300
            'vista previa
            VistaPrevia.ShowDialog()
        Else
            MsgBox("Seleccione un Usuario para imprimir", MsgBoxStyle.Critical, "ATENCION")
            Exit Sub
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        'si los campos estan cargados, se muestra
        If Trim(txt_usuario.Text) <> "" And Trim(txt_pass.Text) <> "" And Trim(cmb_rol.SelectedIndex) <> -1 And Trim(txt_ape.Text) <> "" And Trim(txt_nombre.Text) <> "" And Trim(txt_telefono.Text) <> "" Then
            If OpcionImpresora.ShowDialog = 1 Then
                'defino impresora seleccionada
                HojaImpresion.PrinterSettings = OpcionImpresora.PrinterSettings
                'imprimie directamente
                HojaImpresion.Print()
            End If
        Else
            MsgBox("Seleccione un Usuario para imprimir", MsgBoxStyle.Critical, "ATENCION")
            Exit Sub
        End If

    End Sub


End Class