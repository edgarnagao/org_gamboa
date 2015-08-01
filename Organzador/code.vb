






Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Module code

    Dim idclient As Object

    Sub agregar_info()

        ' assuming you already have your connection as conn
        Dim command As New MySqlCommand
        Dim con As New MySqlConnection("Server=127.0.0.1;Database=gamboadb;Uid=root;Pwd=asajiro89*;")
        con.Open()

        'Command conection
        command.Connection = con

        'Query to insert data
        command.CommandText = "INSERT INTO client (id_client) VALUES ('" & idclient.Text & "')"
        command.ExecuteNonQuery()

        'End Conection
        con.Close()

    End Sub


End Module
