Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=71319_Nielle;database=oop_testproj"
        con.Open()
    End Sub
End Module
