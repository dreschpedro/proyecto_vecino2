Imports MySql.Data.MySqlClient
Imports System.Data

Public Class registros_hoy
    Private encontrado As String = ""
    Dim sql_rH As String = "SELECT registros_hoy.id_eco_resid AS id_registro, ecopunto.nombre AS ecopunto, residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY registros_hoy.id_eco_resid "

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
                lv_registro.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo la grilla utilizando el DReader
                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = lv_registro.Items.Add(DReader("ecopunto"))  'columna ecopunto
                    LV.SubItems.Add(DReader("residuo"))              'columna residuo
                    LV.SubItems.Add(DReader("cantidad"))             'columna cantidad

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

    Sub CargarResiduo(ByVal cadena As String)
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

                    cmb_residuo.ValueMember = DReader(0) 'valor con el que se trabaja (id del residuo)
                    cmb_residuo.DisplayMember = DReader(1) 'valor que se muestra (nombre del residuo)

                    cmb_residuo.Items.Add(DReader(1))


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

    Private Sub registros_hoy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarLV(sql_rH)
        Call CargarEcopunto("SELECT ecopunto.id_ecopunto, nombre FROM ecopunto order by ecopunto.id_ecopunto")
        Call CargarResiduo("SELECT residuo.id_residuo as id, residuo.nombre_residuo AS nombre FROM residuo ORDER BY residuo.id_residuo")
    End Sub

    Private Sub LimpiarForm()
        cmb_residuo.SelectedIndex = -1
        txt_cantidad.Text = ""
    End Sub


    '###################       BOTONES       #######################
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If (cmb_ecopunto.SelectedIndex) = -1 Or (cmb_ecopunto.SelectedIndex) = -1 Or (txt_cantidad.Text) = "" Or (txt_cantidad.Text) <= 0 Then

            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical, "ATENCIÓN !!")
            cmb_residuo.Focus()
            Exit Sub
        End If

        'agrego un registro a la tabla
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            ''trabajo con los datos
            ''el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand
            ''conecto el objeto command
            Comando.Connection = conexion
            ''configuro Command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'PRIMERO CONTROLO QUE EL REGISTRO NO EXISTA
            'Comando.CommandText = "select * from registros_hoy where id_eco_resid = '""';"
            'obtengo los datos y los devuelvo a un objeto DataReader
            'Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            'DReader = Comando.ExecuteReader
            'si no encontro, entonces agrego
            'If DReader.HasRows Then
            '    MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
            '    'cierro el DataReader
            '    DReader.Close()
            'Else
            'cierro el DataReader
            'DReader.Close()


            'cargo la sentencia para AGREGAR un registro
            Comando.CommandText = "insert into registros_hoy (id_ecopunto, id_residuo, cantidad_residuo) values (" & (cmb_ecopunto.SelectedIndex + 1) & "," & (cmb_residuo.SelectedIndex + 1) & "," & Trim(txt_cantidad.Text) & ");"

            Dim Resultado As Integer 'variable para recibir respuesta de ejecucion
            'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
            Resultado = Comando.ExecuteNonQuery
            'MsgBox("Registros Agregados: " & Resultado, MsgBoxStyle.Information, "Atención")

            'limpio el list
            'lv_registro.Items.Clear()

            'cargo el list
            Call CargarLV(sql_rH)
            Call LimpiarForm()
            'End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub


    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    If cmb_residuo.Text <> "" Then
    '        ' si escribo algo, busco
    '        Dim consulta = "SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo WHERE (nombre_residuo like '%" & cmb_residuo.Text & "%');"

    '        'Call CargarLV(consulta)
    '    Else
    '        MsgBox("Seleccione un Residuo", MsgBoxStyle.Information, "Atención")
    '    End If

    'End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'controlo que se selecionó un registros del list
        If lv_registro.SelectedItems.Count < 0 Then
            'controlo que esten los datos cargados
            If (cmb_ecopunto.SelectedIndex) = -1 Or (cmb_residuo.SelectedIndex) = -1 Or Trim(txt_cantidad.Text) = "" Then
                MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Critical, "ATENCION")
                cmb_ecopunto.Focus()
                Exit Sub
            End If
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
            Comando.CommandText = "select * from registros_hoy"


            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            Dim id_registro As String = DReader(0)
            MsgBox("Valor: ", id_registro.ToString)

            'si encontro, entonces modifico
            'If DReader.HasRows Then 'estoompueba sy egistros cargados en el List
            'cierro el DataReader
            'DReader.Close()

            'cargo la sentencia para MODIFICAR un registro
            'Comando.CommandText = "update personal set usuario='" & Trim(txt_usuario.Text) & "',pass='" & Trim(txt_pass.Text) & "',rol='" & Trim(cmb_rol.Text) & "',apellido='" & Trim(txt_ape.Text) & "',nombre='" & Trim(txt_nombre.Text) & "',telefono='" & Trim(txt_telefono.Text) & "' where usuario = '" & Trim(txt_usuario.Text) & "';"
            'variable para recibir respuesta de ejecucion
            Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Modificados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

            'cargo el list
            Call CargarLV(sql_rH)
            Call LimpiarForm()
            'Else
            MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical, "ATENCION")
            'cierro el DataReader
            'DReader.Close()
            'End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    'Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    'primero controlo que esten los datos cargados
    '    If Trim(txt_usuario.Text) = "" And Trim(txt_pass.Text) = "" And Trim(cmb_rol.SelectedIndex) = -1 And Trim(txt_ape.Text) = "" And Trim(txt_nombre.Text) = "" And Trim(txt_telefono.Text) = "" Then
    '        MsgBox("SELECCIONE REGISTRO A ELIMINAR", MsgBoxStyle.Critical, "AAAAAAA")
    '        lb_usuario.Focus()
    '        Exit Sub
    '    End If

    '    'elimino un registro de la tabla
    '    Try
    '        'conecto a la base
    '        Call conectar()
    '        conexion.Open()

    '        'trabajo con los datos
    '        'el objeto command permite ejecutar sentencias SQL
    '        Dim Comando As New MySqlCommand
    '        'conecto el objeto command
    '        Comando.Connection = conexion
    '        'configuro command para sentencia SQL
    '        Comando.CommandType = CommandType.Text

    '        'PRIMERO CONTROLO QUE EL REGISTRO EXISTA
    '        Comando.CommandText = "select usuario, pass, rol, apellido, nombre, telefono from personal where usuario = '" & Trim(txt_usuario.Text) & "';"
    '        'obtengo los datos y los devuelvo a un objeto DataReader
    '        Dim DReader As MySqlDataReader
    '        'el método ExecuteReader trae los datos de la BD
    '        DReader = Comando.ExecuteReader
    '        'si encontro, entonces ELIMINO
    '        If DReader.HasRows Then
    '            'cierro el DataReader
    '            DReader.Close()

    '            'cargo la sentencia para ELIMINAR un registro
    '            Comando.CommandText = "delete from personal where usuario = '" & Trim(txt_usuario.Text) & "';"
    '            'variable para recibir respuesta de ejecucion
    '            Dim Resultado As Integer
    '            'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
    '            Resultado = Comando.ExecuteNonQuery

    '            MsgBox("Registros Eliminados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

    '            'cargo el list
    '            Call CargarList(consulta_personal)
    '            Call LimpiarForm()
    '        Else
    '            MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical, "CCCCCCCC")
    '            'cierro el DataReader
    '            DReader.Close()
    '        End If
    '        'cierro la conexion
    '        conexion.Close()

    '    Catch ex As Exception
    '        'SI HAY UN ERROR MUESTRO EL MENSAJE
    '        MsgBox(ex.Message)
    '        conexion.Close()
    '    End Try
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If

    End Sub

    Private Sub lv_registro_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lv_registro.ColumnClick

        Dim consulta As String

        'depende la columna que hace click ordena la lista

        Select Case e.Column
            Case 0 'ecopunto
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY ecopunto.nombre"
            Case 1 'residuo
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY residuo.nombre_residuo"
            Case 2 'cantidad
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY registros_hoy.cantidad_residuo"
        End Select

        Call CargarLV(consulta)
    End Sub

    Private Sub cmb_ecopunto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ecopunto.SelectedIndexChanged
        'MsgBox("Valor: " & cmb_ecopunto.SelectedIndex + 1)
    End Sub

    Private Sub lv_registro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_registro.SelectedIndexChanged
        'obtengo los datos seleccionados del listview

        'si el count es mayor a 0 esta seleccionado algo
        If lv_registro.SelectedItems.Count > 0 Then
            'traigo los datos
            Dim item As ListViewItem = lv_registro.SelectedItems(0)
            'cargo los textbox
            cmb_ecopunto.Text = item.SubItems(0).Text
            cmb_residuo.Text = item.SubItems(1).Text
            txt_cantidad.Text = item.SubItems(2).Text
        End If


    End Sub

    Private Sub cmb_residuo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_residuo.SelectedIndexChanged

    End Sub
End Class