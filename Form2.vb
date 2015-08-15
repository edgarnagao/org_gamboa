

Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form2

    '************************************************************
    '                           CARGAR FORMAS
    '************************************************************

    'Cargar la forma 2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Desactivate the text box
        Call desactivate_fields()

        'Sub to fill the ids on drop down
        Call id_dropdown()

        'load the noma and app
        Call load_name()

        'Seleciona 
        idCliente.Text = "Selecciona"

        'Selecciona to nombre dropdown
        buscarNombre.Text = "Selecciona"

    End Sub


    '*************************************************************
    '                           BOTONES_Click
    '*************************************************************

    'Boton Agregar
    Private Sub agregarButton_Click(sender As Object, e As EventArgs) Handles agregarButton.Click

        'Validate if the fields are empty
        If idBox.Text = "" Then
            MsgBox("Has click en 'Nuevo' para agregar Clientee", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Nuevo Clientee")
            Exit Sub
        End If

        'Sub to writ in the data base the new reg or the edited 
        If idBox.Text <> " " And idCliente.Text = "Selecciona" And buscarNombre.Text = "Selecciona" Then
            Call agegar_info()
        Else
            Call add_edit()
        End If

        'Clear the filters 
        Call clear_all()

        'Desactivate fields
        Call desactivate_fields()

        'Put the selectiona 
        idCliente.Text = "Selecciona"

        'Put Selecciona en dorpwdown
        buscarNombre.Text = "Selecciona"

        'Add the new id to the dropdown
        Call id_dropdown()

        'Reaload the nombres dorpdown
        Call load_name()

        'Enababled the id dropdown
        idCliente.Enabled = True

        'Enabled the name dorpdown
        buscarNombre.Enabled = True

    End Sub

    'Boton Nuevo
    Private Sub nuevoButton_Click(sender As Object, e As EventArgs) Handles nuevoButton.Click

        'Edit the fields
        Call activate_fields()

        'Clear the fields
        Call clear_all()

        'Set the last id
        Call last_Id()

        'Desactivate the idbox
        idCliente.Enabled = False

        'Desactivate the name dorp down
        buscarNombre.Enabled = False

        'Reset the dropdowns
        idCliente.Text = "Selecciona"
        buscarNombre.Text = "Selecciona"

        'Split the date
        Dim splitDate = Split(Now, " ")

        'Set the date
        fechaBox.Text = splitDate(0)

    End Sub

    'Boton Editar
    Private Sub editarButton_Click(sender As Object, e As EventArgs) Handles editarButton.Click

        'If not Id send message to add one
        If idCliente.Text = "Selecciona" And buscarNombre.Text = "Selecciona" Then
            MsgBox("Se tiene que selecionar una ID para editar", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Sin ID")
            Exit Sub
        End If

        Call activate_fields()


    End Sub

    'Boton Cancelar
    Private Sub cancelarButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click

        'Clear the fields
        Call clear_all()

        'Desactivate the text box
        Call desactivate_fields()

        'Clear the id
        idBox.Text = ""

        'Clear the date field
        fechaBox.Text = ""

        'Eabled the id dropdown for search
        idCliente.Enabled = True

        'put 'Seleciona' in the dropdown
        idCliente.Text = "Selecciona"

        'Eabled the id dropdown for search
        buscarNombre.Enabled = True

        'put 'Seleciona' in the dropdown
        buscarNombre.Text = "Selecciona"

        'Reload the dropdown
        Call id_dropdown()
        Call load_name()



    End Sub

    'Boton Eliminar
    Private Sub eliminarButton_Click(sender As Object, e As EventArgs) Handles eliminarButton.Click

        Dim intResponse As Integer

        'If not Id send message to add one
        If idCliente.Text = "Selecciona" And buscarNombre.Text = "Selecciona" Then
            MsgBox("Se tiene que selecionar una ID o Nombre para eliminar el Clientee", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Ningun Clientee selecionado")
            Exit Sub
        End If

        'Ask to make sure the user want to elimante the 'Clientee'
        intResponse = MsgBox("Estas seguro que quieres eliminar el Clientee", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Eliminar Clientee")

        If Not intResponse = MsgBoxResult.Ok Then
            Exit Sub
        End If

        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "DELETE From Client WHERE serial_id =  '" & idBox.Text & "';"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

        'Clear the fields
        Call clear_all()

        'Desactivate the text box
        Call desactivate_fields()

        'Clear the id
        idBox.Text = ""

        'Clear the date field
        fechaBox.Text = ""

        'Eabled the id dropdown for search
        idCliente.Enabled = True

        'Enabled the nombre dorpdown
        buscarNombre.Enabled = True

        idCliente.Text = "Selecciona"

        buscarNombre.Text = "Selecciona"

        'Reload the id drop down
        Call id_dropdown()

        'REload the nombre dorpdown
        Call load_name()

    End Sub


    '**************************************************************
    '                       CAMPOS_OnChage
    '**************************************************************


    'Buscar por ID en Base de Datos
    Private Sub idCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idCliente.SelectedIndexChanged

        Call search_by_id()

        'After select and Id desactivate the Nombre and Clientee
        buscarNombre.Enabled = False

    End Sub

    'Buscar por Nombre y Apellido en Base de Datos
    Private Sub buscarNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles buscarNombre.SelectedIndexChanged

        Call search_by_name()

        'After select nombre desactivate the Nombre and Clientee
        idCliente.Enabled = False

    End Sub


    '***************************************************************
    '                  FUNCIONES PUBLICAS GENERALES
    '***************************************************************

    'Agregar informacion a BD 
    Public Sub agegar_info()
        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()

        'Command conection
        command.Connection = con

        'send Null insted of empty streing
        If codigoBox.Text = "" Then
            codigoBox.Text = vbNull
        End If

        If telefonoBox.Text = "" Then
            telefonoBox.Text = vbNull
        End If

        If celularBox.Text = "" Then
            celularBox.Text = vbNull
        End If

        'Query to insert data
        command.CommandText = "INSERT INTO Client (serial_id, first_name, last_name, street_addr, neighborhood, zip, joining_date, phone, mobile, email, state, city, company_name, rfc) VALUES ('" & idBox.Text & "','" & nombreBox.Text & "','" & apellidosBox.Text & "','" & calleBox.Text & "','" & coloniaBox.Text & "','" & codigoBox.Text & "','" & fechaBox.Text & "','" & telefonoBox.Text & "','" & celularBox.Text & "','" & correoClienteeBox.Text & "', '" & estadoBox.Text & "', '" & ciudadBox.Text & "','" & empresaBox.Text & "', '" & rfcBox.Text & "'  );"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()
    End Sub

    'Cargar la informacion del ID en el Dropdown
    Public Sub id_dropdown()
        'Assuming you already have your connection as conn
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader

        'Open connection
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select * From gamboadb.Client"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString

            idCliente.Items.Add(id)

        End While

        'End Conection
        con.Close()

    End Sub

    'Desactivar los campos
    Public Sub desactivate_fields()
        'Desactive the textbox
        idBox.Enabled = False
        nombreBox.Enabled = False
        apellidosBox.Enabled = False
        calleBox.Enabled = False
        coloniaBox.Enabled = False
        codigoBox.Enabled = False
        fechaBox.Enabled = False
        telefonoBox.Enabled = False
        celularBox.Enabled = False
        correoClienteeBox.Enabled = False
        estadoBox.Enabled = False
        ciudadBox.Enabled = False
        empresaBox.Enabled = False
        rfcBox.Enabled = False
    End Sub

    'Obtener el ultimo ID de la bd
    Sub last_Id()

        'Assuming you already have your connection as conn
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader

        'Open connection
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select serial_id From gamboadb.Client order by serial_id DESC Limit 1"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString

            idBox.Text = id + 1

        End While

        'Check if the id has value
        If idBox.Text = "" Then
            idBox.Text = "1"
        End If


        'End Conection
        con.Close()



    End Sub

    'Activar los campos
    Sub activate_fields()
        nombreBox.Enabled = True
        apellidosBox.Enabled = True
        calleBox.Enabled = True
        coloniaBox.Enabled = True
        codigoBox.Enabled = True
        fechaBox.Enabled = True
        telefonoBox.Enabled = True
        celularBox.Enabled = True
        correoClienteeBox.Enabled = True
        estadoBox.Enabled = True
        ciudadBox.Enabled = True
        empresaBox.Enabled = True
        rfcBox.Enabled = True
    End Sub

    'Limpiar todos los campos
    Sub clear_all()

        'Clear the fields
        idBox.Text = ""
        nombreBox.Text = ""
        apellidosBox.Text = ""
        calleBox.Text = ""
        coloniaBox.Text = ""
        codigoBox.Text = ""
        fechaBox.Text = ""
        telefonoBox.Text = ""
        celularBox.Text = ""
        correoClienteeBox.Text = ""
        estadoBox.Text = ""
        ciudadBox.Text = ""
        empresaBox.Text = ""
        rfcBox.Text = ""

        'Clear the id dropdown
        idCliente.Items.Clear()

        'Clear the nombre dropdown
        buscarNombre.Items.Clear()

    End Sub

    'Buscar por ID
    Sub search_by_id()

        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select * From Client where serial_id = '" & idCliente.Text & "';"
        READER = command.ExecuteReader

        While READER.Read

            Dim idValue = READER("serial_id").ToString
            Dim nom = READER("first_name").ToString
            Dim app = READER("last_name").ToString
            Dim calle = READER("street_addr").ToString
            Dim colValue = READER("neighborhood").ToString
            Dim ccp = READER("zip").ToString
            Dim fecha = READER("joining_date").ToString
            Dim num = READER("phone").ToString
            Dim cel = READER("mobile").ToString
            Dim correo = READER("email").ToString
            Dim estado = READER("state").ToString
            Dim ciudad = READER("city").ToString
            Dim empresa = READER("company_name").ToString
            Dim rfc = READER("rfc").ToString

            'Add the info
            idBox.Text = idValue
            nombreBox.Text = nom
            apellidosBox.Text = app
            calleBox.Text = calle
            coloniaBox.Text = colValue
            fechaBox.Text = fecha
            correoClienteeBox.Text = correo
            estadoBox.Text = estado
            ciudadBox.Text = ciudad
            empresaBox.Text = empresa
            rfcBox.Text = rfc

            'Validate the phone its not 0
            If ccp = "1" Then
                codigoBox.Text = ""
            Else
                codigoBox.Text = ccp
            End If

            'Validate the phone its not 0
            If num = "1" Then
                telefonoBox.Text = ""
            Else
                telefonoBox.Text = num
            End If

            'Validate the mobile its not 0
            If cel = "1" Then
                celularBox.Text = ""
            Else
                celularBox.Text = cel
            End If

        End While

        'End Conection
        con.Close()


    End Sub

    'Editar la informacion en bd
    Sub add_edit()

        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()

        'Command conection
        command.Connection = con

        'send Null insted of empty streing
        If codigoBox.Text = "" Then
            codigoBox.Text = vbNull
        End If

        If telefonoBox.Text = "" Then
            telefonoBox.Text = vbNull
        End If

        If celularBox.Text = "" Then
            celularBox.Text = vbNull
        End If

        'Query to insert data
        command.CommandText = "UPDATE Client  SET first_name = '" & nombreBox.Text & "', last_name = '" & apellidosBox.Text & "' , street_addr = '" & calleBox.Text & "', neighborhood = '" & coloniaBox.Text & "', zip = '" & codigoBox.Text & "', joining_date = '" & fechaBox.Text & "', phone = '" & telefonoBox.Text & "' , mobile = '" & celularBox.Text & "' , email = '" & correoClienteeBox.Text & "', state = '" & estadoBox.Text & "', city = '" & ciudadBox.Text & "', company_name = '" & empresaBox.Text & "', rfc = '" & rfcBox.Text & "'   where serial_id = '" & idBox.Text & "'  "
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

    End Sub

    'Cargar los nombres para el dorpdown
    Sub load_name()

        'Assuming you already have your connection as conn
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader

        'Open connection
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select * From gamboadb.Client"
        READER = command.ExecuteReader

        While READER.Read

            Dim nom = READER("first_name").ToString
            Dim app = READER("last_name").ToString

            buscarNombre.Items.Add(nom & "  " & app)

        End While

        'End Conection
        con.Close()

    End Sub

    'Buscar por nombre en bd
    Sub search_by_name()

        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=localhost;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader
        Dim nombresValue
        con.Open()

        'Command conection
        command.Connection = con

        'Dived the string
        nombresValue = Split(buscarNombre.Text, "  ")

        'Query to insert data
        command.CommandText = "Select * From Client where first_name = '" & nombresValue(0) & "' and last_name = '" & nombresValue(1) & "' "
        READER = command.ExecuteReader

        While READER.Read

            Dim idValue = READER("serial_id").ToString
            Dim nom = READER("first_name").ToString
            Dim app = READER("last_name").ToString
            Dim calle = READER("street_addr").ToString
            Dim colValue = READER("neighborhood").ToString
            Dim ccp = READER("zip").ToString
            Dim fecha = READER("joining_date").ToString
            Dim num = READER("phone").ToString
            Dim cel = READER("mobile").ToString
            Dim correo = READER("email").ToString
            Dim estado = READER("state").ToString
            Dim ciudad = READER("city").ToString
            Dim empresa = READER("company_name").ToString
            Dim rfc = READER("rfc").ToString

            'Add the info
            idBox.Text = idValue
            nombreBox.Text = nom
            apellidosBox.Text = app
            calleBox.Text = calle
            coloniaBox.Text = colValue
            fechaBox.Text = fecha
            correoClienteeBox.Text = correo
            estadoBox.Text = estado
            ciudadBox.Text = ciudad
            empresaBox.Text = empresa
            rfcBox.Text = rfc

            'Validate the phone its not 0
            If ccp = "1" Then
                codigoBox.Text = ""
            Else
                codigoBox.Text = ccp
            End If

            'Validate the phone its not 0
            If num = "1" Then
                telefonoBox.Text = ""
            Else
                telefonoBox.Text = num
            End If

            'Validate the mobile its not 0
            If cel = "1" Then
                celularBox.Text = ""
            Else
                celularBox.Text = cel
            End If

        End While

        'End Conection
        con.Close()

    End Sub



    Private Sub cotizacionButton_Click(sender As Object, e As EventArgs) Handles cotizacionButton.Click
        MsgBox("Realizar cotizacion")
    End Sub




    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class


