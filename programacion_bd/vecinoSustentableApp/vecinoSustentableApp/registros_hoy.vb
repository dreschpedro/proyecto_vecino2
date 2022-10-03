Imports MySql.Data.MySqlClient

Public Class registros_hoy
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub CargarGrilla(ByVal cadena As String)
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

    Private Sub registros_hoy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarGrilla("SELECT residuo.nombre_residuo AS nombre_residuo, registros_hoy.cantidad_residuo AS cantidad_residuo FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If Trim(cmbNombreResiduo.Text) = "" And Trim(txtCantidad.Text) = "" Then
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
            Comando.CommandText = "select * from registros_hoy where id_eco_resid = '" & Trim(txt_id_reg.Text) & "';"
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
                Comando.CommandText = "insert into registros_hoy (id_eco_resid, id_residuo, id_ecopunto, cantidad_residuo) values (" & Trim(txt_id_reg.Text) & "," & Trim(cmbNombreResiduo.Text) & "," & Trim(cmbNombreEcopunto.Text) & "," & Trim(txtCantidad.Text) & ");"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery
                MsgBox("Registros Agregados: " & Resultado)

                'cargo el list
                Call CargarGrilla("SELECT residuo.nombre_residuo AS cmbNombreResiduo, registros_hoy.cantidad_residuo AS txtCantidad FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo ")
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



    'Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbNombreResiduo.KeyPress
    '    If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Or (Char.IsPunctuation(e.KeyChar))) Then 'numeros, Supr y backspace
    '        e.Handled = True 'no se controla
    '    Else
    '        e.Handled = False 'no permite ingresar letras
    '    End If

    'End Sub

End Class