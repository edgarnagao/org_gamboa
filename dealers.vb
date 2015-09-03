

Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Proveedores

    '************************************************************
    '                           CARGAR FORMAS
    '************************************************************

    'Cargar la forma 2
    Private Sub dealers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Desactivate the text box
        Call desactivate_fields()

        'Sub to fill the ids on drop down
        Call id_dropdown()

        'load the noma and app
        Call load_name()

        'Seleciona 
        idDealerCombo.Text = "Selecciona"

        'Selecciona to nombre dropdown
        searchNombre.Text = "Selecciona"

    End Sub


    '*************************************************************
    '                           BOTONES_Click
    '*************************************************************

    'Boton Agregar
    Private Sub agregarButton_Click(sender As Object, e As EventArgs) Handles agregarButton.Click

        'Validate if the fields are empty
        If idDealer.Text = "" Then
            MsgBox("Has click en 'Nuevo' para agregar Proveedor", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Nuevo Proveedor")
            Exit Sub
        End If

        'Sub to writ in the data base the new reg or the edited 
        If idDealer.Text <> " " And idDealerCombo.Text = "Selecciona" And searchNombre.Text = "Selecciona" Then
            Call agegar_info()
        Else
            Call add_edit()
        End If

        'Clear the filters 
        Call clear_all()

        'Desactivate fields
        Call desactivate_fields()

        'Put the selectiona 
        idDealerCombo.Text = "Selecciona"

        'Put Selecciona en dorpwdown
        searchNombre.Text = "Selecciona"

        'Add the new id to the dropdown
        Call id_dropdown()

        'Reaload the nombres dorpdown
        Call load_name()

        'Enababled the id dropdown
        idDealerCombo.Enabled = True

        'Enabled the name dorpdown
        searchNombre.Enabled = True

    End Sub

    'Boton Nuevo
    Private Sub nuevoButton_Click(sender As Object, e As EventArgs) Handles nuevoButton.Click

        'Edit the fields
        Call activate_fields()

        'Clear the fields
        Call clear_all()

        'Set the last id
        Call last_Id()

        'Desactivate the idDealer
        idDealerCombo.Enabled = False

        'Desactivate the name dorp down
        searchNombre.Enabled = False

        'Reset the dropdowns
        idDealerCombo.Text = "Selecciona"
        searchNombre.Text = "Selecciona"

        'Split the date
        Dim splitDate = Split(Now, " ")

        'Set the date
        fechaBox.Text = splitDate(0)

    End Sub

    'Boton Editar
    Private Sub editarButton_Click(sender As Object, e As EventArgs) Handles editarButton.Click

        'If not Id send message to add one
        If idDealerCombo.Text = "Selecciona" And searchNombre.Text = "Selecciona" Then
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
        idDealer.Text = ""

        'Clear the date field
        fechaBox.Text = ""

        'Eabled the id dropdown for search
        idDealerCombo.Enabled = True

        'put 'Seleciona' in the dropdown
        idDealerCombo.Text = "Selecciona"

        'Eabled the id dropdown for search
        searchNombre.Enabled = True

        'put 'Seleciona' in the dropdown
        searchNombre.Text = "Selecciona"

        'Reload the dropdown
        Call id_dropdown()
        Call load_name()



    End Sub

    'Boton Eliminar
    Private Sub eliminarButton_Click(sender As Object, e As EventArgs) Handles eliminarButton.Click

        Dim intResponse As Integer

        'If not Id send message to add one
        If idDealerCombo.Text = "Selecciona" And searchNombre.Text = "Selecciona" Then
            MsgBox("Se tiene que selecionar una ID o Nombre para eliminar el Proveedor", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Ningun Proveedor selecionado")
            Exit Sub
        End If

        'Ask to make sure the user want to elimante the 'Proveedor'
        intResponse = MsgBox("Estas seguro que quieres eliminar el Proveedor", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Eliminar Proveedor")

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
        command.CommandText = "DELETE From dealer WHERE serial_id =  '" & idDealer.Text & "';"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

        'Clear the fields
        Call clear_all()

        'Desactivate the text box
        Call desactivate_fields()

        'Clear the id
        idDealer.Text = ""

        'Clear the date field
        fechaBox.Text = ""

        'Eabled the id dropdown for search
        idDealerCombo.Enabled = True

        'Enabled the nombre dorpdown
        searchNombre.Enabled = True

        idDealerCombo.Text = "Selecciona"

        searchNombre.Text = "Selecciona"

        'Reload the id drop down
        Call id_dropdown()

        'REload the nombre dorpdown
        Call load_name()

    End Sub


    '**************************************************************
    '                       CAMPOS_OnChage
    '**************************************************************


    'Buscar por ID en Base de Datos
    Private Sub idDealerCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idDealerCombo.SelectedIndexChanged

        Call search_by_id()

        'After select and Id desactivate the Nombre and Proveedor
        searchNombre.Enabled = False

    End Sub

    'Buscar por Nombre y Apellido en Base de Datos
    Private Sub searchNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchNombre.SelectedIndexChanged

        Call search_by_name()

        'After select nombre desactivate the Nombre and Proveedor
        idDealerCombo.Enabled = False

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
        If codeDealerBox.Text = "" Then
            codeDealerBox.Text = vbNull
        End If

        If phoneDealerBox.Text = "" Then
            phoneDealerBox.Text = vbNull
        End If

        If cellDealerBox.Text = "" Then
            cellDealerBox.Text = vbNull
        End If

        'Query to insert data
        command.CommandText = "INSERT INTO dealer (serial_id, first_name, last_name, street_addr, neighborhood, zip, joining_date, phone, mobile, email, state, city, company_name, rfc) VALUES ('" & idDealer.Text & "','" & nombreDealerBox.Text & "','" & apellidosDealerBox.Text & "','" & streetDealerBox.Text & "','" & hoodDealerBox.Text & "','" & codeDealerBox.Text & "','" & fechaBox.Text & "','" & phoneDealerBox.Text & "','" & cellDealerBox.Text & "','" & mailDealerBox.Text & "', '" & stateDealerBox.Text & "', '" & cityDealerBox.Text & "','" & empresaDealerBox.Text & "', '" & rfcDealerBox.Text & "'  );"
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
        command.CommandText = "Select * From gamboadb.dealer"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString

            idDealerCombo.Items.Add(id)

        End While

        'End Conection
        con.Close()

    End Sub

    'Desactivar los campos
    Public Sub desactivate_fields()
        'Desactive the textbox
        idDealer.Enabled = False
        nombreDealerBox.Enabled = False
        apellidosDealerBox.Enabled = False
        streetDealerBox.Enabled = False
        hoodDealerBox.Enabled = False
        codeDealerBox.Enabled = False
        fechaBox.Enabled = False
        phoneDealerBox.Enabled = False
        cellDealerBox.Enabled = False
        mailDealerBox.Enabled = False
        stateDealerBox.Enabled = False
        cityDealerBox.Enabled = False
        empresaDealerBox.Enabled = False
        rfcDealerBox.Enabled = False
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
        command.CommandText = "Select serial_id From gamboadb.dealer order by serial_id DESC Limit 1"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString

            idDealer.Text = id + 1

        End While

        'Check if the id has value
        If idDealer.Text = "" Then
            idDealer.Text = "1"
        End If


        'End Conection
        con.Close()



    End Sub

    'Activar los campos
    Sub activate_fields()
        nombreDealerBox.Enabled = True
        apellidosDealerBox.Enabled = True
        streetDealerBox.Enabled = True
        hoodDealerBox.Enabled = True
        codeDealerBox.Enabled = True
        fechaBox.Enabled = True
        phoneDealerBox.Enabled = True
        cellDealerBox.Enabled = True
        mailDealerBox.Enabled = True
        stateDealerBox.Enabled = True
        cityDealerBox.Enabled = True
        empresaDealerBox.Enabled = True
        rfcDealerBox.Enabled = True
    End Sub

    'Limpiar todos los campos
    Sub clear_all()

        'Clear the fields
        idDealer.Text = ""
        nombreDealerBox.Text = ""
        apellidosDealerBox.Text = ""
        streetDealerBox.Text = ""
        hoodDealerBox.Text = ""
        codeDealerBox.Text = ""
        fechaBox.Text = ""
        phoneDealerBox.Text = ""
        cellDealerBox.Text = ""
        mailDealerBox.Text = ""
        stateDealerBox.Text = ""
        cityDealerBox.Text = ""
        empresaDealerBox.Text = ""
        rfcDealerBox.Text = ""

        'Clear the id dropdown
        idDealerCombo.Items.Clear()

        'Clear the nombre dropdown
        searchNombre.Items.Clear()

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
        command.CommandText = "Select * From dealer where serial_id = '" & idDealerCombo.Text & "';"
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
            idDealer.Text = idValue
            nombreDealerBox.Text = nom
            apellidosDealerBox.Text = app
            streetDealerBox.Text = calle
            hoodDealerBox.Text = colValue
            fechaBox.Text = fecha
            mailDealerBox.Text = correo
            stateDealerBox.Text = estado
            cityDealerBox.Text = ciudad
            empresaDealerBox.Text = empresa
            rfcDealerBox.Text = rfc

            'Validate the phone its not 0
            If ccp = "1" Then
                codeDealerBox.Text = ""
            Else
                codeDealerBox.Text = ccp
            End If

            'Validate the phone its not 0
            If num = "1" Then
                phoneDealerBox.Text = ""
            Else
                phoneDealerBox.Text = num
            End If

            'Validate the mobile its not 0
            If cel = "1" Then
                cellDealerBox.Text = ""
            Else
                cellDealerBox.Text = cel
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
        If codeDealerBox.Text = "" Then
            codeDealerBox.Text = vbNull
        End If

        If phoneDealerBox.Text = "" Then
            phoneDealerBox.Text = vbNull
        End If

        If cellDealerBox.Text = "" Then
            cellDealerBox.Text = vbNull
        End If

        'Query to insert data
        command.CommandText = "UPDATE dealer  SET first_name = '" & nombreDealerBox.Text & "', last_name = '" & apellidosDealerBox.Text & "' , street_addr = '" & streetDealerBox.Text & "', neighborhood = '" & hoodDealerBox.Text & "', zip = '" & codeDealerBox.Text & "', joining_date = '" & fechaBox.Text & "', phone = '" & phoneDealerBox.Text & "' , mobile = '" & cellDealerBox.Text & "' , email = '" & mailDealerBox.Text & "', state = '" & stateDealerBox.Text & "', city = '" & cityDealerBox.Text & "', company_name = '" & empresaDealerBox.Text & "', rfc = '" & rfcDealerBox.Text & "'   where serial_id = '" & idDealer.Text & "'  "
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
        command.CommandText = "Select * From gamboadb.dealer"
        READER = command.ExecuteReader

        While READER.Read

            Dim nom = READER("first_name").ToString
            Dim app = READER("last_name").ToString

            searchNombre.Items.Add(nom & "  " & app)

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
        nombresValue = Split(searchNombre.Text, "  ")

        'Query to insert data
        command.CommandText = "Select * From dealer where first_name = '" & nombresValue(0) & "' and last_name = '" & nombresValue(1) & "' "
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
            idDealer.Text = idValue
            nombreDealerBox.Text = nom
            apellidosDealerBox.Text = app
            streetDealerBox.Text = calle
            hoodDealerBox.Text = colValue
            fechaBox.Text = fecha
            mailDealerBox.Text = correo
            stateDealerBox.Text = estado
            cityDealerBox.Text = ciudad
            empresaDealerBox.Text = empresa
            rfcDealerBox.Text = rfc

            'Validate the phone its not 0
            If ccp = "1" Then
                codeDealerBox.Text = ""
            Else
                codeDealerBox.Text = ccp
            End If

            'Validate the phone its not 0
            If num = "1" Then
                phoneDealerBox.Text = ""
            Else
                phoneDealerBox.Text = num
            End If

            'Validate the mobile its not 0
            If cel = "1" Then
                cellDealerBox.Text = ""
            Else
                cellDealerBox.Text = cel
            End If

        End While

        'End Conection
        con.Close()

    End Sub



    Private Sub cotizacionButton_Click(sender As Object, e As EventArgs)
        Quotation.Show()
    End Sub


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub groupCliente_Enter(sender As Object, e As EventArgs) Handles groupCliente.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class


