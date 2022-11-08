Imports MySql.Data.MySqlClient

Public Class config_user

    Dim consulta_personal = "SELECT personal.usuario AS usuario FROM personal ORDER BY personal.id_personal;"

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


    '           FORM LOAD
    Private Sub config_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pruebo conexion a la base de datos
        Call conectar()
        Call CargarList(consulta_personal)


        'Opciones en el combobos de "Rol"
        'Se muestran al iniciar el formulario, solo se pueden elejir entre esas 2
        cmb_rol.Items.Add("Administrador")
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
        txt_buscar.Text = ""

    End Sub

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

    Private Sub btn_limpiar_campos_Click(sender As Object, e As EventArgs) Handles btn_limpiar_campos.Click
        Call LimpiarForm()
        lb_usuario.SelectedIndex = -1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If txt_usuario.Text = "" Or txt_pass.Text = "" Or cmb_rol.Text = "" Or txt_ape.Text = "" Or txt_nombre.Text = "" Or txt_telefono.Text = "" Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical, "ATENCION")
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
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical, "ATENCION")
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

                MsgBox("Registros Agregados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
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
        If Trim(txt_usuario.Text) = "" Or Trim(txt_pass.Text) = "" Or Trim(cmb_rol.SelectedIndex) = -1 Or Trim(txt_ape.Text) = "" Or Trim(txt_nombre.Text) = "" Or Trim(txt_telefono.Text) = "" Then
            MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Critical, "ATENCION")
            lb_usuario.Focus()
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
            Comando.CommandText = "select usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & Trim(txt_usuario.Text) & "';"
            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then

                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para MODIFICAR un registro
                Comando.CommandText = "update personal set usuario='" & Trim(txt_usuario.Text) & "',pass='" & Trim(txt_pass.Text) & "',rol='" & Trim(cmb_rol.Text) & "',apellido='" & Trim(txt_ape.Text) & "',nombre='" & Trim(txt_nombre.Text) & "',telefono='" & Trim(txt_telefono.Text) & "' where usuario = '" & Trim(txt_usuario.Text) & "';"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                'MsgBox("Registros Modificados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

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
            Dim prFont As New Font("Arial", 15, FontStyle.Bold)
            ' la posicion superior
            'imprimir una imagen
            'e.Graphics.DrawImage(Pboximagen.Image, 10, 10, 200, 200)
            'direccion
            e.Graphics.DrawString("av 3 de febrero 1860", prFont, Brushes.Black, 10, 205)
            'tel
            e.Graphics.DrawString("tel:376446897", prFont, Brushes.Black, 40, 235)
            ' factura lado derecho superior
            e.Graphics.DrawString("n°de factura", prFont, Brushes.Black, 650, 10)
            'e.Graphics.DrawString(labelcantidaddefactura.Text, prFont, Brushes.Black, 650, 40)
            'tipo de factura
            e.Graphics.DrawRectangle(Pens.Black, 300, 10, 200, 200)

            'imprimimos la fecha y hora
            prFont = New Font("Arial", 12, FontStyle.Italic)
            e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " - " &
                                  Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 610, 100)

            'stilo A,B.C
            prFont = New Font("arial", 120, FontStyle.Underline)
            e.Graphics.DrawString("B", prFont, Brushes.Black, 320, 0)

            'GRAFICAR LINE 
            e.Graphics.DrawLine(Pens.Black, 0, 300, 850, 300)

            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("PACIENTE", prFont, Brushes.Black, 15, 310)

            prFont = New Font("Arial", 12, FontStyle.Italic)
            'datos de paciente 
            e.Graphics.DrawString("MIA KHALIFA:", prFont, Brushes.Black, 10, 350)
            'e.Graphics.DrawString(lblnombre.Text, prFont, Brushes.Black, 80, 350)
            e.Graphics.DrawString("apellido:", prFont, Brushes.Black, 10, 370)
            'e.Graphics.DrawString(Lblapellido.Text, prFont, Brushes.Black, 80, 370)
            e.Graphics.DrawString("dni :", prFont, Brushes.Black, 10, 390)
            'e.Graphics.DrawString(Lbldni.Text, prFont, Brushes.Black, 80, 390)
            e.Graphics.DrawString("numero afiliado :", prFont, Brushes.Black, 10, 410)
            'e.Graphics.DrawString(Lblafiliado.Text, prFont, Brushes.Black, 130, 410)
            e.Graphics.DrawLine(Pens.Black, 0, 440, 850, 440)

            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("tratamiento", prFont, Brushes.Black, 10, 460)
            'e.Graphics.DrawString(ComboBoxtratamiento2.Text, prFont, Brushes.Black, 10, 520)
            e.Graphics.DrawString("precio.uni", prFont, Brushes.Black, 210, 460)
            'e.Graphics.DrawString(Txtprecio.Text, prFont, Brushes.Black, 210, 520)
            e.Graphics.DrawString("cantidad ", prFont, Brushes.Black, 410, 460)
            'e.Graphics.DrawString(Txtcantidad.Text, prFont, Brushes.Black, 410, 520)
            e.Graphics.DrawString("total ", prFont, Brushes.Black, 610, 460)
            'e.Graphics.DrawString(Txttotal.Text, prFont, Brushes.Black, 610, 520)
            'imprimir lineas
            e.Graphics.DrawLine(Pens.Black, 0, 490, 850, 490)
            e.Graphics.DrawLine(Pens.Black, 210, 440, 210, 1000)
            e.Graphics.DrawLine(Pens.Black, 410, 440, 410, 1000)
            e.Graphics.DrawLine(Pens.Black, 610, 440, 610, 1000)
            e.Graphics.DrawLine(Pens.Black, 0, 1000, 850, 1000)
            'imprimir un rectangulo
            ' e.Graphics.DrawRectangle(Pens.Green, 90, 90, 250, 100)
            'imprimir un circulo
            'e.Graphics.DrawEllipse(Pens.Indigo, 350, 900, 300, 100)
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btn_vista_Click(sender As Object, e As EventArgs) Handles btn_vista.Click
        'para una vista previa
        'selecciono PrintDocument generado
        VistaPrevia.Document = HojaImpresion
        'tamaño de ventana
        VistaPrevia.Width = 900
        VistaPrevia.Height = 700
        'vista previa
        VistaPrevia.ShowDialog()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If OpcionImpresora.ShowDialog = 1 Then
            'defino impresora seleccionada
            HojaImpresion.PrinterSettings = OpcionImpresora.PrinterSettings
            'imprimie directamente
            HojaImpresion.Print()
        End If
    End Sub





End Class