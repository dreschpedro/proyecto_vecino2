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
                    LV = lv_registro.Items.Add(DReader("id_registro"))  'columna id_registro
                    LV.SubItems.Add(DReader("ecopunto"))                'columna ecopunto
                    LV.SubItems.Add(DReader("residuo"))                 'columna residuo
                    LV.SubItems.Add(DReader("cantidad"))                'columna cantidad

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
        If (cmb_ecopunto.SelectedIndex = -1) Or (cmb_ecopunto.SelectedIndex = -1) Or (txt_cantidad.Text = "") Or (txt_cantidad.Text <= "0") Then

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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'controlo que se selecionó un registros del list
        'controlo que esten los datos cargados

        If Trim(txt_cantidad.Text = "0") Then
            MsgBox("No puede ser 0", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End If

        If (lv_registro.SelectedItems.Count <= 0) Or (cmb_ecopunto.SelectedIndex = -1) Or (cmb_residuo.SelectedIndex = -1) Or Trim(txt_cantidad.Text = "") Then
            MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Critical, "ATENCION")
            cmb_ecopunto.Focus()
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
            Comando.CommandText = "SELECT registros_hoy.id_eco_resid AS id_registro, ecopunto.nombre AS ecopunto, residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto WHERE (registros_hoy.id_eco_resid = '" & Trim(lbl_id_registro.Text) & "') ORDER BY registros_hoy.id_eco_resid"
            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then

                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para MODIFICAR un registro
                Comando.CommandText = "update registros_hoy set id_ecopunto='" & (cmb_ecopunto.SelectedIndex + 1) & "',id_residuo='" & Trim(cmb_residuo.SelectedIndex + 1) & "',cantidad_residuo='" & Trim(txt_cantidad.Text) & "' where registros_hoy.id_eco_resid = '" & Trim(lbl_id_registro.Text) & "';"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                'MsgBox("Registros Modificados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
                Call CargarLV(sql_rH)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'controlo que se selecionó un registros del list
        'controlo que esten los datos cargados
        If (lv_registro.SelectedItems.Count <= 0) Or (cmb_ecopunto.SelectedIndex = -1) Or (cmb_residuo.SelectedIndex = -1) Or Trim(txt_cantidad.Text = "") Or Trim(txt_cantidad.Text = "0") Then
            MsgBox("SELECCIONE REGISTRO A ELIMINAR", MsgBoxStyle.Critical, "ATENCION")
            cmb_ecopunto.Focus()
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
            Comando.CommandText = "SELECT registros_hoy.id_eco_resid AS id_registro, ecopunto.nombre AS ecopunto, residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto WHERE (registros_hoy.id_eco_resid = '" & Trim(lbl_id_registro.Text) & "') ORDER BY registros_hoy.id_eco_resid"
            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader
            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then

                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para MODIFICAR un registro
                Comando.CommandText = "DELETE FROM registros_hoy WHERE registros_hoy.id_eco_resid = '" & Trim(lbl_id_registro.Text) & "';"
                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer
                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Eliminados: " & Resultado, MsgBoxStyle.Information, "ATENCION")

                'cargo el list
                Call CargarLV(sql_rH)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    '###################        IMPRESORA       ################

    'Private Sub factura_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles factura.PrintPage
    '    Try
    '        ' La fuente a usar
    '        Dim prFont As New Font("Arial", 15, FontStyle.Bold)
    '        ' la posicion superior
    '        'imprimir una imagen
    '        e.Graphics.DrawImage(Pboximagen.Image, 10, 10, 200, 200)
    '        'direccion
    '        e.Graphics.DrawString("av 3 de febrero 1860", prFont, Brushes.Black, 10, 205)
    '        'tel
    '        e.Graphics.DrawString("tel:376446897", prFont, Brushes.Black, 40, 235)
    '        ' factura lado derecho superior
    '        e.Graphics.DrawString("n°de factura", prFont, Brushes.Black, 650, 10)
    '        e.Graphics.DrawString(labelcantidaddefactura.Text, prFont, Brushes.Black, 650, 40)
    '        'tipo de factura
    '        e.Graphics.DrawRectangle(Pens.Black, 300, 10, 200, 200)

    '        'imprimimos la fecha y hora
    '        prFont = New Font("Arial", 12, FontStyle.Italic)
    '        e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " - " &
    '                              Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 610, 100)

    '        'stilo A,B.C
    '        prFont = New Font("arial", 120, FontStyle.Underline)
    '        e.Graphics.DrawString("B", prFont, Brushes.Black, 320, 0)

    '        'GRAFICAR LINE 
    '        e.Graphics.DrawLine(Pens.Black, 0, 300, 850, 300)

    '        prFont = New Font("Arial", 18, FontStyle.Bold)
    '        e.Graphics.DrawString("PACIENTE", prFont, Brushes.Black, 15, 310)

    '        prFont = New Font("Arial", 12, FontStyle.Italic)
    '        'datos de paciente 
    '        e.Graphics.DrawString("nombre :", prFont, Brushes.Black, 10, 350)
    '        e.Graphics.DrawString(lblnombre.Text, prFont, Brushes.Black, 80, 350)
    '        e.Graphics.DrawString("apellido:", prFont, Brushes.Black, 10, 370)
    '        e.Graphics.DrawString(Lblapellido.Text, prFont, Brushes.Black, 80, 370)
    '        e.Graphics.DrawString("dni :", prFont, Brushes.Black, 10, 390)
    '        e.Graphics.DrawString(Lbldni.Text, prFont, Brushes.Black, 80, 390)
    '        e.Graphics.DrawString("numero afiliado :", prFont, Brushes.Black, 10, 410)
    '        e.Graphics.DrawString(Lblafiliado.Text, prFont, Brushes.Black, 130, 410)
    '        e.Graphics.DrawLine(Pens.Black, 0, 440, 850, 440)

    '        prFont = New Font("Arial", 18, FontStyle.Bold)
    '        e.Graphics.DrawString("tratamiento", prFont, Brushes.Black, 10, 460)
    '        e.Graphics.DrawString(ComboBoxtratamiento2.Text, prFont, Brushes.Black, 10, 520)
    '        e.Graphics.DrawString("precio.uni", prFont, Brushes.Black, 210, 460)
    '        e.Graphics.DrawString(Txtprecio.Text, prFont, Brushes.Black, 210, 520)
    '        e.Graphics.DrawString("cantidad ", prFont, Brushes.Black, 410, 460)
    '        e.Graphics.DrawString(Txtcantidad.Text, prFont, Brushes.Black, 410, 520)
    '        e.Graphics.DrawString("total ", prFont, Brushes.Black, 610, 460)
    '        e.Graphics.DrawString(Txttotal.Text, prFont, Brushes.Black, 610, 520)
    '        'imprimir lineas
    '        e.Graphics.DrawLine(Pens.Black, 0, 490, 850, 490)
    '        e.Graphics.DrawLine(Pens.Black, 210, 440, 210, 1000)
    '        e.Graphics.DrawLine(Pens.Black, 410, 440, 410, 1000)
    '        e.Graphics.DrawLine(Pens.Black, 610, 440, 610, 1000)
    '        e.Graphics.DrawLine(Pens.Black, 0, 1000, 850, 1000)
    '        'imprimir un rectangulo
    '        ' e.Graphics.DrawRectangle(Pens.Green, 90, 90, 250, 100)
    '        'imprimir un circulo
    '        'e.Graphics.DrawEllipse(Pens.Indigo, 350, 900, 300, 100)
    '    Catch ex As Exception
    '        MessageBox.Show("ERROR: " & ex.Message, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub

    'Private Sub btn_vista_Click(sender As Object, e As EventArgs) Handles btn_vista.Click
    '    'para una vista previa
    '    'selecciono PrintDocument generado
    '    vistaprevia.Document = factura
    '    'tamaño de ventana
    '    vistaprevia.Width = 900
    '    vistaprevia.Height = 700
    '    'vista previa
    '    vistaprevia.ShowDialog()
    'End Sub

    'Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
    '    If OpcionImpresora.ShowDialog = 1 Then
    '        'defino impresora seleccionada
    '        factura.PrinterSettings = OpcionImpresora.PrinterSettings
    '        'imprimie directamente
    '        factura.Print()
    '    End If
    'End Sub

    '###################        VALIDACIONES DE LOS CAMPOS      #######################
    'click columnas
    Private Sub lv_registro_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lv_registro.ColumnClick

        Dim consulta As String
        consulta = "" 'para que no salte al advertencia que la variable no se usa

        'depende la columna que hace click ordena la lista

        Select Case e.Column
            Case 0 'id_registro
                'consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY registros_hoy.id_eco_resid"
                consulta = sql_rH
            Case 1 'ecopunto
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY ecopunto.nombre"
            Case 2 'residuo
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY residuo.nombre_residuo"
            Case 3 'cantidad
                consulta = "SELECT registros_hoy.id_eco_resid AS id_registro, residuo.nombre_residuo AS residuo, ecopunto.nombre AS ecopunto, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto ORDER BY registros_hoy.cantidad_residuo"
        End Select

        Call CargarLV(consulta)
    End Sub

    Private Sub lv_registro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_registro.SelectedIndexChanged
        'obtengo los datos seleccionados del listview
        'si el count es mayor a 0 esta seleccionado algo
        If lv_registro.SelectedItems.Count > 0 Then
            'traigo los datos
            Dim item As ListViewItem = lv_registro.SelectedItems(0)
            lbl_id_registro.Text = item.SubItems(0).Text
            'cargo los textbox
            cmb_ecopunto.Text = item.SubItems(1).Text
            cmb_residuo.Text = item.SubItems(2).Text
            txt_cantidad.Text = item.SubItems(3).Text
        End If


    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        'busco los temas segun lo ingresado
        'armo la consulta y llamo a la subrutina
        If txt_buscar.Text <> "" Then
            ' si escribio algo busco
            Dim ConsultaSQL = "SELECT registros_hoy.id_eco_resid AS id_registro, ecopunto.nombre AS ecopunto, residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM registros_hoy JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto WHERE (residuo.nombre_residuo like '%" & txt_buscar.Text & "%') ORDER BY registros_hoy.id_eco_resid;"

            Call CargarLV(ConsultaSQL)
        Else
            'si no cargo nada limpio el list
            lv_registro.Items.Clear()
            Call CargarLV(sql_rH)

        End If
    End Sub

    Private Sub txt_buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsPunctuation(e.KeyChar))) Then
            e.Handled = True 'No permite numeros y signos de puntuacion
        Else
            e.Handled = False 'Permite solo ingresar letras y borrar
        End If
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If
    End Sub

End Class