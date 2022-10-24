Imports MySql.Data.MySqlClient

Public Class registros_hoy

    Private encontrado As Integer = -1

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
                lb_registro.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo la grilla utilizando el DReader
                Dim LV As New ListViewItem

                Do While DReader.Read
                    'LV = lb_registro.Items.Add(DReader("nombre_residuo"))
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
                    'se muestra el nombre del ecopunto (2da posicion)
                    cmbNombreResiduo.Items.Add(DReader(1))
                    'cmbNombreResiduo.Items.Add(DReader(1))
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
        'Call CargarLV(sql_rH_sin_hora)
        Call CargarEcopunto("SELECT ecopunto.id_ecopunto, nombre FROM ecopunto")
        Call CargarResiduo("SELECT residuo.id_residuo as id, residuo.nombre_residuo AS nombre FROM residuo ORDER BY residuo.id_residuo")
    End Sub

    Private Sub limpiarCampos()
        cmbNombreResiduo.Text = ""
        txtCantidad.Text = ""
    End Sub


    '###################       BOTONES       #######################
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If Trim(cmbNombreEcopunto.Text) = "" Or Trim(cmbNombreResiduo.Text) = "" Or Trim(txtCantidad.Text) = "" Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical)
            cmbNombreResiduo.Focus()
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
            'Comando.CommandText = "select * from registros_hoy where id_eco_resid = '""';"
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
                Comando.CommandText = "insert into registros_hoy (id_residuo, id_ecopunto, cantidad_residuo) values (" & Trim(cmbNombreResiduo.SelectedIndex + 1) & "," & (cmbNombreEcopunto.SelectedIndex + 1) & "," & Trim(txtCantidad.Text) & ");"

                'limpio los campos
                Call limpiarCampos()


                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & Resultado, vbYes, "Atención")

                'cargo el list
                'Call CargarLV(sql_rH_sin_hora)
                'Call LimpiarForm()
            End If
            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbNombreResiduo.Text <> "" Then
            ' si escribo algo, busco
            Dim consulta = "SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo WHERE (nombre_residuo like '%" & cmbNombreResiduo.Text & "%');"

            'Call CargarLV(consulta)
        Else
            MsgBox("Seleccione un Residuo", MsgBoxStyle.Information, "Atención")
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'primero controlo que esten los datos cargados
        If cmbNombreEcopunto.Text = "" And cmbNombreResiduo.Text = "" And txtCantidad.Text = "" Then
            MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Critical)
            cmbNombreResiduo.Focus()
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
            Comando.CommandText = "select * from registros_hoy where id_eco_resid = '""';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para MODIFICAR un registro
                'Comando.CommandText = "update socio set nombre='" & txtNombre.Text & "',direccion='" & txtDireccion.Text & "',telefono='" & txtTelefono.Text & "',categoria='" & Trim(txtCategoria.Text) & "' where clavesocio = " & encontrado & ";"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Modificados: " & Resultado)

                'cargo el list
                'Call CargarLV(sql_rH_sin_hora)
                Call limpiarCampos()

            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            End If


            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            'MsgBox("ERROR DE BASE DE DATOS", vbCritical)
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'primero controlo que esten los datos cargados
        If cmbNombreEcopunto.Text = "" And cmbNombreResiduo.Text = "" And txtCantidad.Text = "" Then
            MsgBox("SELECCIONE REGISTRO A ELIMINAR", MsgBoxStyle.Critical)
            cmbNombreResiduo.Focus()
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
            'Comando.CommandText = "select * from socio where clavesocio = " & Trim(txtClaveSocio.Text) & ";"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces ELIMINO
            If DReader.HasRows Then
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para ELIMINAR un registro
                'Comando.CommandText = "delete from socio where clavesocio = " & Trim(txtClaveSocio.Text) & ";"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Eliminados: " & Resultado)

                'cargo el list
                'Call CargarLV(sql_rH_sin_hora)
                Call limpiarCampos()

            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If

    End Sub

    Private Sub lviewResiduosHoy_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class