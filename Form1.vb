

Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FormProducts


    Private Sub FormProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Desactivate fields 
        Call desactivate_fields()

        'Load the id dropdown
        Call id_prod_dropdown()

        'Enable false to ´Guardar Modificacion'
        saveModification.Enabled = False

        'Put Selecciona on the drop down
        idProduct.Text = "Selecciona"



    End Sub

    '*****************************************************************************
    '                                 BUTTONS
    '*****************************************************************************

    'New Button
    Private Sub nuevoButton_Click(sender As Object, e As EventArgs) Handles nuevoButton.Click

        'Edit the fields
        Call activate_fields()

        'Clear the fields
        Call clear_all()

        'Reset the dropdowns
        idProduct.Text = "Selecciona"

        'Desabled the id product dropdown
        idProduct.Enabled = False

    End Sub

    'Add button
    Private Sub agregarButton_Click(sender As Object, e As EventArgs) Handles agregarButton.Click

        Dim intResponse As Integer

        'Validate if the fields are empty
        If idProductoBox.Enabled = False Then
            MsgBox("Has click en 'Nuevo' para agregar Clientee", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Nuevo Cliente")
            Exit Sub
        End If

        'Validate the Id is not allready in use
        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader
        con.Open()

        'Validate if enter to validate the existing ID
        If idProduct.Text = "Selecciona" Then

            'Command conection
            command.Connection = con

            'Query to insert data
            command.CommandText = "Select * From Products WHERE serial_id =  '" & idProductoBox.Text & "';"
            READER = command.ExecuteReader

            'If the ID already exist
            If READER.Read Then
                intResponse = MsgBox("El ID (codigo) de producto ya esta en uso. Desaea ver el producto con este codigo?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Codigo en uso actualmente")

                'If click on Ok serach the product
                If intResponse = MsgBoxResult.Ok Then

                    'Populate the information
                    Call search_by(idProductoBox)
                    Call desactivate_fields()
                    Exit Sub
                Else
                    'Exit the sub
                    Exit Sub

                End If

                'End Conection
                con.Close()

            End If

        End If

        'Sub to set in the data base the new reg or the edited 
        If idProduct.Text = "Selecciona" Then
            Call add_info()
        Else
            Call add_edit()
        End If

        'Clear the filters 
        Call clear_all()

        'Desactivate fields
        Call desactivate_fields()

        'Eneabed the id product
        idProduct.Enabled = True

        'Load the dropdown
        Call id_prod_dropdown()

        'Put the selectiona 
        idProduct.Text = "Selecciona"

    End Sub

    'Cancel button
    Private Sub cancelarButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click

        'Clear the fields
        Call clear_all()

        'Desactivate the text box
        Call desactivate_fields()

        'Eabled the id dropdown for search
        idProduct.Enabled = True

        'put 'Seleciona' in the dropdown
        idProduct.Text = "Selecciona"

        'Reload the dropdown
        Call id_prod_dropdown()

        'Enable false to ´Guardar Modificacion'
        saveModification.Enabled = False
        agregarButton.Enabled = True


    End Sub

    'Delete button
    Private Sub eliminarButton_Click(sender As Object, e As EventArgs) Handles eliminarButton.Click
        Dim intResponse As Integer

        'If not Id send message to add one
        If idProduct.Text = "Selecciona" Then
            MsgBox("Se tiene que selecionar una ID o para eliminar el Producto", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Ningun Producto selecionado")
            Exit Sub
        End If

        'Ask to make sure the user want to elimante the 'Clientee'
        intResponse = MsgBox("Esta seguro que quiere eliminar el Producto", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Eliminar Producto")

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
        command.CommandText = "DELETE From Products WHERE serial_id =  '" & idProductoBox.Text & "';"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

        'Clear the fields
        Call clear_all()

        'Desactivate the text box
        Call desactivate_fields()

        'Eabled the id dropdown for search
        idProduct.Enabled = True


        idProduct.Text = "Selecciona"


        'Reload the id drop down
        Call id_prod_dropdown()


    End Sub

    'Edit button
    Private Sub editarButton_Click(sender As Object, e As EventArgs) Handles editarButton.Click
        'If not Id send message to add one
        If idProduct.Text = "Selecciona" Then
            MsgBox("Se tiene que selecionar una ID para editar", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly = True, "Sin ID")
            Exit Sub
        End If

        Call activate_fields()

        'Enable the save modify
        saveModification.Enabled = True

        'Desable 'Add button
        agregarButton.Enabled = False

    End Sub

    'Save Modification button
    Private Sub saveModification_Click(sender As Object, e As EventArgs) Handles saveModification.Click
        Dim intResponse As Integer
        'Validate the Id is not allready in use
        'Conection data
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader
        con.Open()
        'Validate if enter to validate the existing ID
        If idProduct.Text = "Selecciona" Then

            'Command conection
            Command.Connection = con

            'Query to insert data
            Command.CommandText = "Select * From Products WHERE serial_id =  '" & idProductoBox.Text & "';"
            READER = Command.ExecuteReader

            'If the ID already exist
            If READER.Read Then
                intResponse = MsgBox("El ID (codigo) de producto ya esta en uso. Desaea ver el producto con este codigo?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Codigo en uso actualmente")

                'If click on Ok serach the product
                If intResponse = MsgBoxResult.Ok Then

                    'Populate the information
                    Call search_by(idProductoBox)
                    Call desactivate_fields()
                    Exit Sub
                Else
                    'Exit the sub
                    Exit Sub

                End If

                'End Conection
                con.Close()

            End If

        End If

        'Save the modification
        Call add_edit()

        'Enable false to ´Guardar Modificacion'
        saveModification.Enabled = False
        agregarButton.Enabled = True

        'Desactive the filed
        Call desactivate_fields()

    End Sub

    '*****************************************************************************
    '                           ELEMENTS ON CHANGE
    '*****************************************************************************

    Private Sub idProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idProduct.SelectedIndexChanged
        Call search_by(idProduct)
    End Sub

    '*****************************************************************************
    '                           GENERAL FUNCTIONS
    '*****************************************************************************

    'Desactive the textbox
    Public Sub desactivate_fields()

        idProductoBox.Enabled = False
        nameProductBox.Enabled = False
        typeBox.Enabled = False
        descriptionBox.Enabled = False
        weighBox.Enabled = False
        widthBox.Enabled = False
        longBox.Enabled = False
        highBox.Enabled = False
        firstPrice.Enabled = False
        secondPrice.Enabled = False
        thirdPrice.Enabled = False
        fourthPrice.Enabled = False

    End Sub

    'Activate fields
    Sub activate_fields()

        idProductoBox.Enabled = True
        nameProductBox.Enabled = True
        typeBox.Enabled = True
        descriptionBox.Enabled = True
        weighBox.Enabled = True
        widthBox.Enabled = True
        longBox.Enabled = True
        highBox.Enabled = True
        firstPrice.Enabled = True
        secondPrice.Enabled = True
        thirdPrice.Enabled = True
        fourthPrice.Enabled = True

    End Sub

    'Clear the fields 
    Sub clear_all()

        idProductoBox.Text = ""
        nameProductBox.Text = ""
        typeBox.Text = ""
        descriptionBox.Text = ""
        weighBox.Text = ""
        widthBox.Text = ""
        longBox.Text = ""
        highBox.Text = ""
        firstPrice.Text = ""
        secondPrice.Text = ""
        thirdPrice.Text = ""
        fourthPrice.Text = ""

        'Clear the id product dorpdown
        idProduct.Items.Clear()

    End Sub

    'Search by Id
    Public Function search_by(element)

        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select * From products where serial_id = '" & element.Text & "';"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString
            Dim nameProd = READER("product").ToString
            Dim typeProd = READER("type_prod").ToString
            Dim desc = READER("description").ToString
            Dim weigh = READER("weight_prod").ToString
            Dim widthProd = READER("width_prod").ToString
            Dim longProd = READER("long_prod").ToString
            Dim highProd = READER("high_prod").ToString
            Dim first = READER("price").ToString
            Dim second = READER("second_price").ToString
            Dim third = READER("third_price").ToString
            Dim fourth = READER("fourth_price").ToString


            'Add the info
            idProductoBox.Text = id
            nameProductBox.Text = nameProd
            typeBox.Text = typeProd
            descriptionBox.Text = desc
            weighBox.Text = weigh
            widthBox.Text = widthProd
            longBox.Text = longProd
            highBox.Text = highProd

            'Set Emprty string
            If first = 1 Then
                firstPrice.Text = ""
            Else
                firstPrice.Text = first
            End If

            If second = 1 Then
                secondPrice.Text = ""
            Else
                secondPrice.Text = second
            End If

            If third = 1 Then
                thirdPrice.Text = ""
            Else
                thirdPrice.Text = third
            End If

            If fourth = 1 Then
                fourthPrice.Text = ""
            Else
                fourthPrice.Text = fourth
            End If



        End While

        'End Conection
        con.Close()

    End Function


    'Load the id dropdown
    Public Sub id_prod_dropdown()

        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        Dim READER As MySqlDataReader

        'Open connection
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "Select * From gamboadb.products"
        READER = command.ExecuteReader

        While READER.Read

            Dim id = READER("serial_id").ToString

            idProduct.Items.Add(id)

        End While

        'End Conection
        con.Close()

    End Sub

    'Add Info to DB
    Sub add_info()

        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()
        Dim prices(3) As Object

        'Arrray of the prices
        prices(0) = firstPrice
        prices(1) = secondPrice
        prices(2) = thirdPrice
        prices(3) = fourthPrice

        'Command conection
        command.Connection = con

        'Loop to check if there is null values
        For index = 0 To 3

            If String.IsNullOrEmpty(prices(index).Text) Then
                prices(index).Text = vbNull
            End If

        Next

        'Query to insert data
        command.CommandText = "INSERT INTO Products (serial_id, product, type_prod, description, weight_prod, high_prod, width_prod, long_prod, price, second_price, third_price, fourth_price) VALUES ('" & idProductoBox.Text & "','" & nameProductBox.Text & "','" & typeBox.Text & "','" & descriptionBox.Text & "','" & weighBox.Text & "','" & highBox.Text & "','" & widthBox.Text & "','" & longBox.Text & "','" & firstPrice.Text & "','" & secondPrice.Text & "','" & thirdPrice.Text & "', '" & fourthPrice.Text & "');"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

    End Sub

    'Add info after edit
    Sub add_edit()

        'Conection data
        Dim filterElement As Object
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()
        Dim prices(3) As Object

        'Command conection
        command.Connection = con

        'Arrray of the prices
        prices(0) = firstPrice
        prices(1) = secondPrice
        prices(2) = thirdPrice
        prices(3) = fourthPrice

        'Command conection
        command.Connection = con

        'Loop to check if there is null values
        For index = 0 To 3

            If String.IsNullOrEmpty(prices(index).Text) Then
                prices(index).Text = vbNull
            End If

        Next

        'Verify if there is a modification from the message box of same id
        'Or is a modification from the dropdown
        If idProduct.Text = "Selecciona" Then
            filterElement = idProduct
        Else
            filterElement = idProductoBox
        End If

        'Query to insert data
        command.CommandText = "UPDATE products  SET serial_id = '" & idProductoBox.Text & "', product = '" & nameProductBox.Text & "' , type_prod = '" & typeBox.Text & "', description = '" & descriptionBox.Text & "', weight_prod = '" & weighBox.Text & "', high_prod = '" & highBox.Text & "', width_prod = '" & widthBox.Text & "' , long_prod = '" & longBox.Text & "' , price = '" & firstPrice.Text & "', second_price = '" & secondPrice.Text & "', third_price = '" & thirdPrice.Text & "', fourth_price = '" & fourthPrice.Text & "'where serial_id = '" & filterElement.Text & "'  "
        command.ExecuteNonQuery()

        'End Conection
        con.Close()
    End Sub

   


    
  
   

    Private Sub firstPrice_TextChanged(sender As Object, e As EventArgs) Handles firstPrice.TextChanged
        Dim unitPrice

        'Get the unit price
        unitPrice = firstPrice.Text

        'Out the sub when clear the fields 
        If unitPrice = "" Then
            Exit Sub
        End If

        'Set the other prices
        secondPrice.Text = (unitPrice - (unitPrice * 0.03))
        thirdPrice.Text = (unitPrice - (unitPrice * 0.09))
        fourthPrice.Text = (unitPrice - (unitPrice * 0.12))

    End Sub

   
    
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class